Imports Ems_International_Logic.EMS
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports System.Data
Imports System.Data.SqlClient


Public Class Frm_Cuoc_Quoc_Te_Di
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
    Friend WithEvents grbDot_Tinh_Cuoc As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents dgDot_Tinh_Cuoc As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents txtId_Dot As System.Windows.Forms.TextBox
    Friend WithEvents txt_Ten_Doi_Tuong As System.Windows.Forms.TextBox
    Friend WithEvents txt_Dot As System.Windows.Forms.TextBox
    Friend WithEvents txt_Ten_Dot As System.Windows.Forms.TextBox
    Friend WithEvents txt_Ghi_Chu As System.Windows.Forms.TextBox
    Friend WithEvents btn_Them_Moi As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btn_Sua_Chua As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btn_Xoa As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btn_Cap_Nhat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btn_Huy_Bo As Infragistics.Win.Misc.UltraButton
    Friend WithEvents stb_Thong_Tin As System.Windows.Forms.StatusBar
    Friend WithEvents stb1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents grbDanh_Muc_Cuoc As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents dtp_Tu_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents dtp_Den_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents dgThong_Tin_Cuoc As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btn_Thoat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txt_RowIDX As System.Windows.Forms.TextBox
    Friend WithEvents ddMa_Nuoc As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents Nhap_So_Thap_Phan As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents Nhap_So_Nguyen As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents stb3 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents stb2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents stb4 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents btn_Load_Cuoc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbMa_Tien_Te As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Nhap_So_Thap_Phan_3 As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents ddMa_Tien_Te As Infragistics.Win.UltraWinGrid.UltraDropDown
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Tien_Te", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tien_Te")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Tien_Te")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ghi_Chu")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_Cuoc_Quoc_Te_Di))
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("DSQT_Danh_Muc_Dot", -1)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Dot")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Doi_Tuong")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dot")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Dot")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Bat_Dau")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Ket_Thuc")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ghi_Chu", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tien_Te")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Nuoc", -1)
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Nuoc")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("DSQT_Cuoc_Phat_QT_Di", -1)
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Cuoc")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_BP_D")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_BP_M")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_VCMBND")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Dot")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tien_Te")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tien_Te_VCMBND", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Tien_Te", -1)
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tien_Te")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Tien_Te")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ghi_Chu")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.grbDot_Tinh_Cuoc = New Infragistics.Win.Misc.UltraGroupBox
        Me.cbMa_Tien_Te = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        Me.txt_RowIDX = New System.Windows.Forms.TextBox
        Me.btn_Thoat = New Infragistics.Win.Misc.UltraButton
        Me.dtp_Den_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.dtp_Tu_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.btn_Load_Cuoc = New Infragistics.Win.Misc.UltraButton
        Me.btn_Huy_Bo = New Infragistics.Win.Misc.UltraButton
        Me.btn_Cap_Nhat = New Infragistics.Win.Misc.UltraButton
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.btn_Xoa = New Infragistics.Win.Misc.UltraButton
        Me.btn_Sua_Chua = New Infragistics.Win.Misc.UltraButton
        Me.btn_Them_Moi = New Infragistics.Win.Misc.UltraButton
        Me.txt_Ghi_Chu = New System.Windows.Forms.TextBox
        Me.txt_Ten_Dot = New System.Windows.Forms.TextBox
        Me.txt_Dot = New System.Windows.Forms.TextBox
        Me.txt_Ten_Doi_Tuong = New System.Windows.Forms.TextBox
        Me.txtId_Dot = New System.Windows.Forms.TextBox
        Me.dgDot_Tinh_Cuoc = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.stb_Thong_Tin = New System.Windows.Forms.StatusBar
        Me.stb1 = New System.Windows.Forms.StatusBarPanel
        Me.stb2 = New System.Windows.Forms.StatusBarPanel
        Me.stb3 = New System.Windows.Forms.StatusBarPanel
        Me.stb4 = New System.Windows.Forms.StatusBarPanel
        Me.grbDanh_Muc_Cuoc = New Infragistics.Win.Misc.UltraGroupBox
        Me.Nhap_So_Nguyen = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Me.Nhap_So_Thap_Phan = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Me.ddMa_Nuoc = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.dgThong_Tin_Cuoc = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.Nhap_So_Thap_Phan_3 = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Me.ddMa_Tien_Te = New Infragistics.Win.UltraWinGrid.UltraDropDown
        CType(Me.grbDot_Tinh_Cuoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDot_Tinh_Cuoc.SuspendLayout()
        CType(Me.cbMa_Tien_Te, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp_Den_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp_Tu_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDot_Tinh_Cuoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stb3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stb4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbDanh_Muc_Cuoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDanh_Muc_Cuoc.SuspendLayout()
        CType(Me.Nhap_So_Nguyen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nhap_So_Thap_Phan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddMa_Nuoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgThong_Tin_Cuoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nhap_So_Thap_Phan_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddMa_Tien_Te, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbDot_Tinh_Cuoc
        '
        Me.grbDot_Tinh_Cuoc.Controls.Add(Me.cbMa_Tien_Te)
        Me.grbDot_Tinh_Cuoc.Controls.Add(Me.UltraLabel6)
        Me.grbDot_Tinh_Cuoc.Controls.Add(Me.txt_RowIDX)
        Me.grbDot_Tinh_Cuoc.Controls.Add(Me.btn_Thoat)
        Me.grbDot_Tinh_Cuoc.Controls.Add(Me.dtp_Den_Ngay)
        Me.grbDot_Tinh_Cuoc.Controls.Add(Me.dtp_Tu_Ngay)
        Me.grbDot_Tinh_Cuoc.Controls.Add(Me.btn_Load_Cuoc)
        Me.grbDot_Tinh_Cuoc.Controls.Add(Me.btn_Huy_Bo)
        Me.grbDot_Tinh_Cuoc.Controls.Add(Me.btn_Cap_Nhat)
        Me.grbDot_Tinh_Cuoc.Controls.Add(Me.UltraLabel5)
        Me.grbDot_Tinh_Cuoc.Controls.Add(Me.UltraLabel4)
        Me.grbDot_Tinh_Cuoc.Controls.Add(Me.UltraLabel3)
        Me.grbDot_Tinh_Cuoc.Controls.Add(Me.UltraLabel2)
        Me.grbDot_Tinh_Cuoc.Controls.Add(Me.UltraLabel1)
        Me.grbDot_Tinh_Cuoc.Controls.Add(Me.btn_Xoa)
        Me.grbDot_Tinh_Cuoc.Controls.Add(Me.btn_Sua_Chua)
        Me.grbDot_Tinh_Cuoc.Controls.Add(Me.btn_Them_Moi)
        Me.grbDot_Tinh_Cuoc.Controls.Add(Me.txt_Ghi_Chu)
        Me.grbDot_Tinh_Cuoc.Controls.Add(Me.txt_Ten_Dot)
        Me.grbDot_Tinh_Cuoc.Controls.Add(Me.txt_Dot)
        Me.grbDot_Tinh_Cuoc.Controls.Add(Me.txt_Ten_Doi_Tuong)
        Me.grbDot_Tinh_Cuoc.Controls.Add(Me.txtId_Dot)
        Me.grbDot_Tinh_Cuoc.Controls.Add(Me.dgDot_Tinh_Cuoc)
        Me.grbDot_Tinh_Cuoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbDot_Tinh_Cuoc.Location = New System.Drawing.Point(0, 0)
        Me.grbDot_Tinh_Cuoc.Name = "grbDot_Tinh_Cuoc"
        Me.grbDot_Tinh_Cuoc.Size = New System.Drawing.Size(392, 544)
        Me.grbDot_Tinh_Cuoc.SupportThemes = False
        Me.grbDot_Tinh_Cuoc.TabIndex = 0
        Me.grbDot_Tinh_Cuoc.Text = "Thông tin đợt tính cước"
        '
        'cbMa_Tien_Te
        '
        Me.cbMa_Tien_Te.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance1.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.cbMa_Tien_Te.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.Caption = "Mã tiền tệ"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(64, 0)
        UltraGridColumn2.Header.Caption = "Tên tiền tệ"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(112, 0)
        UltraGridColumn3.Header.Caption = "Ghi chú"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        UltraGridBand1.Header.Caption = "Đường thư"
        UltraGridBand1.UseRowLayout = True
        Me.cbMa_Tien_Te.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance2.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance2.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbMa_Tien_Te.DisplayLayout.Override.HeaderAppearance = Appearance2
        Me.cbMa_Tien_Te.DisplayMember = ""
        Me.cbMa_Tien_Te.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMa_Tien_Te.Location = New System.Drawing.Point(256, 16)
        Me.cbMa_Tien_Te.Name = "cbMa_Tien_Te"
        Me.cbMa_Tien_Te.Size = New System.Drawing.Size(64, 21)
        Me.cbMa_Tien_Te.TabIndex = 16
        Me.cbMa_Tien_Te.ValueMember = ""
        Me.cbMa_Tien_Te.Visible = False
        '
        'UltraLabel6
        '
        Me.UltraLabel6.Location = New System.Drawing.Point(168, 16)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(80, 23)
        Me.UltraLabel6.TabIndex = 15
        Me.UltraLabel6.Text = "Mã tiền tệ"
        Me.UltraLabel6.Visible = False
        '
        'txt_RowIDX
        '
        Me.txt_RowIDX.Location = New System.Drawing.Point(280, 64)
        Me.txt_RowIDX.Name = "txt_RowIDX"
        Me.txt_RowIDX.Size = New System.Drawing.Size(88, 21)
        Me.txt_RowIDX.TabIndex = 6
        Me.txt_RowIDX.Text = "RowIDX"
        Me.txt_RowIDX.Visible = False
        '
        'btn_Thoat
        '
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        Me.btn_Thoat.Appearance = Appearance3
        Me.btn_Thoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Thoat.Location = New System.Drawing.Point(296, 32)
        Me.btn_Thoat.Name = "btn_Thoat"
        Me.btn_Thoat.Size = New System.Drawing.Size(88, 32)
        Me.btn_Thoat.TabIndex = 3
        Me.btn_Thoat.Text = "Th&oát"
        '
        'dtp_Den_Ngay
        '
        Me.dtp_Den_Ngay.DateTime = New Date(2008, 7, 3, 0, 0, 0, 0)
        Me.dtp_Den_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtp_Den_Ngay.Location = New System.Drawing.Point(288, 104)
        Me.dtp_Den_Ngay.MaskInput = "dd/mm/yyyy"
        Me.dtp_Den_Ngay.Name = "dtp_Den_Ngay"
        Me.dtp_Den_Ngay.ReadOnly = True
        Me.dtp_Den_Ngay.Size = New System.Drawing.Size(96, 23)
        Me.dtp_Den_Ngay.TabIndex = 14
        Me.dtp_Den_Ngay.Value = New Date(2008, 7, 3, 0, 0, 0, 0)
        '
        'dtp_Tu_Ngay
        '
        Me.dtp_Tu_Ngay.DateTime = New Date(2008, 7, 3, 0, 0, 0, 0)
        Me.dtp_Tu_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtp_Tu_Ngay.Location = New System.Drawing.Point(96, 104)
        Me.dtp_Tu_Ngay.MaskInput = "dd/mm/yyyy"
        Me.dtp_Tu_Ngay.Name = "dtp_Tu_Ngay"
        Me.dtp_Tu_Ngay.Size = New System.Drawing.Size(96, 23)
        Me.dtp_Tu_Ngay.TabIndex = 12
        Me.dtp_Tu_Ngay.Value = New Date(2008, 7, 3, 0, 0, 0, 0)
        '
        'btn_Load_Cuoc
        '
        Appearance4.Image = CType(resources.GetObject("Appearance4.Image"), Object)
        Me.btn_Load_Cuoc.Appearance = Appearance4
        Me.btn_Load_Cuoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Load_Cuoc.Location = New System.Drawing.Point(216, 168)
        Me.btn_Load_Cuoc.Name = "btn_Load_Cuoc"
        Me.btn_Load_Cuoc.Size = New System.Drawing.Size(168, 32)
        Me.btn_Load_Cuoc.TabIndex = 21
        Me.btn_Load_Cuoc.Text = "&Lấy th. tin cước đợt trước"
        '
        'btn_Huy_Bo
        '
        Appearance5.Image = CType(resources.GetObject("Appearance5.Image"), Object)
        Me.btn_Huy_Bo.Appearance = Appearance5
        Me.btn_Huy_Bo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Huy_Bo.Location = New System.Drawing.Point(104, 168)
        Me.btn_Huy_Bo.Name = "btn_Huy_Bo"
        Me.btn_Huy_Bo.Size = New System.Drawing.Size(88, 32)
        Me.btn_Huy_Bo.TabIndex = 20
        Me.btn_Huy_Bo.Text = "&Hủy bỏ"
        '
        'btn_Cap_Nhat
        '
        Appearance6.Image = CType(resources.GetObject("Appearance6.Image"), Object)
        Me.btn_Cap_Nhat.Appearance = Appearance6
        Me.btn_Cap_Nhat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cap_Nhat.Location = New System.Drawing.Point(8, 168)
        Me.btn_Cap_Nhat.Name = "btn_Cap_Nhat"
        Me.btn_Cap_Nhat.Size = New System.Drawing.Size(88, 32)
        Me.btn_Cap_Nhat.TabIndex = 19
        Me.btn_Cap_Nhat.Text = "&Cập nhật"
        '
        'UltraLabel5
        '
        Me.UltraLabel5.Location = New System.Drawing.Point(8, 136)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(56, 23)
        Me.UltraLabel5.TabIndex = 17
        Me.UltraLabel5.Text = "Ghi chú"
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Location = New System.Drawing.Point(200, 108)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(80, 23)
        Me.UltraLabel4.TabIndex = 13
        Me.UltraLabel4.Text = "Ngày kết thúc"
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Location = New System.Drawing.Point(8, 108)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(80, 23)
        Me.UltraLabel3.TabIndex = 11
        Me.UltraLabel3.Text = "Ngày bắt đầu"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Location = New System.Drawing.Point(200, 80)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(56, 23)
        Me.UltraLabel2.TabIndex = 9
        Me.UltraLabel2.Text = "Tên đợt"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(8, 80)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(80, 23)
        Me.UltraLabel1.TabIndex = 7
        Me.UltraLabel1.Text = "Số thứ tự đợt"
        '
        'btn_Xoa
        '
        Appearance7.Image = CType(resources.GetObject("Appearance7.Image"), Object)
        Me.btn_Xoa.Appearance = Appearance7
        Me.btn_Xoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Xoa.Location = New System.Drawing.Point(200, 32)
        Me.btn_Xoa.Name = "btn_Xoa"
        Me.btn_Xoa.Size = New System.Drawing.Size(88, 32)
        Me.btn_Xoa.TabIndex = 2
        Me.btn_Xoa.Text = "&Xóa bỏ"
        '
        'btn_Sua_Chua
        '
        Appearance8.Image = CType(resources.GetObject("Appearance8.Image"), Object)
        Me.btn_Sua_Chua.Appearance = Appearance8
        Me.btn_Sua_Chua.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Sua_Chua.Location = New System.Drawing.Point(104, 32)
        Me.btn_Sua_Chua.Name = "btn_Sua_Chua"
        Me.btn_Sua_Chua.Size = New System.Drawing.Size(88, 32)
        Me.btn_Sua_Chua.TabIndex = 1
        Me.btn_Sua_Chua.Text = "&Sửa chữa"
        '
        'btn_Them_Moi
        '
        Appearance9.Image = CType(resources.GetObject("Appearance9.Image"), Object)
        Me.btn_Them_Moi.Appearance = Appearance9
        Me.btn_Them_Moi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Them_Moi.Location = New System.Drawing.Point(8, 32)
        Me.btn_Them_Moi.Name = "btn_Them_Moi"
        Me.btn_Them_Moi.Size = New System.Drawing.Size(88, 32)
        Me.btn_Them_Moi.TabIndex = 0
        Me.btn_Them_Moi.Text = "&Tạo mới"
        '
        'txt_Ghi_Chu
        '
        Me.txt_Ghi_Chu.Location = New System.Drawing.Point(96, 136)
        Me.txt_Ghi_Chu.Name = "txt_Ghi_Chu"
        Me.txt_Ghi_Chu.Size = New System.Drawing.Size(288, 21)
        Me.txt_Ghi_Chu.TabIndex = 18
        Me.txt_Ghi_Chu.Text = "Ghi_Chu"
        '
        'txt_Ten_Dot
        '
        Me.txt_Ten_Dot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Ten_Dot.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_Ten_Dot.Location = New System.Drawing.Point(272, 80)
        Me.txt_Ten_Dot.Name = "txt_Ten_Dot"
        Me.txt_Ten_Dot.ReadOnly = True
        Me.txt_Ten_Dot.Size = New System.Drawing.Size(112, 21)
        Me.txt_Ten_Dot.TabIndex = 10
        Me.txt_Ten_Dot.Text = "Ten_Dot"
        '
        'txt_Dot
        '
        Me.txt_Dot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Dot.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_Dot.Location = New System.Drawing.Point(96, 80)
        Me.txt_Dot.Name = "txt_Dot"
        Me.txt_Dot.ReadOnly = True
        Me.txt_Dot.Size = New System.Drawing.Size(64, 21)
        Me.txt_Dot.TabIndex = 8
        Me.txt_Dot.Text = "Dot"
        '
        'txt_Ten_Doi_Tuong
        '
        Me.txt_Ten_Doi_Tuong.Location = New System.Drawing.Point(184, 64)
        Me.txt_Ten_Doi_Tuong.Name = "txt_Ten_Doi_Tuong"
        Me.txt_Ten_Doi_Tuong.Size = New System.Drawing.Size(88, 21)
        Me.txt_Ten_Doi_Tuong.TabIndex = 5
        Me.txt_Ten_Doi_Tuong.Text = "Ten_Doi_Tuong"
        Me.txt_Ten_Doi_Tuong.Visible = False
        '
        'txtId_Dot
        '
        Me.txtId_Dot.Location = New System.Drawing.Point(88, 64)
        Me.txtId_Dot.Name = "txtId_Dot"
        Me.txtId_Dot.Size = New System.Drawing.Size(88, 21)
        Me.txtId_Dot.TabIndex = 4
        Me.txtId_Dot.Text = "Id_Dot"
        Me.txtId_Dot.Visible = False
        '
        'dgDot_Tinh_Cuoc
        '
        Me.dgDot_Tinh_Cuoc.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.dgDot_Tinh_Cuoc.DisplayLayout.AddNewBox.Prompt = " "
        Appearance10.BackColor = System.Drawing.Color.White
        Appearance10.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgDot_Tinh_Cuoc.DisplayLayout.Appearance = Appearance10
        UltraGridColumn4.Header.VisiblePosition = 0
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 1
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.Caption = "Đợt"
        UltraGridColumn6.Header.VisiblePosition = 2
        UltraGridColumn6.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn6.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(46, 0)
        UltraGridColumn6.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn6.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn7.Header.Caption = "Tên đợt"
        UltraGridColumn7.Header.VisiblePosition = 3
        UltraGridColumn7.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn7.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn7.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(73, 0)
        UltraGridColumn7.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn7.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn8.Header.Caption = "Ngày bắt đầu"
        UltraGridColumn8.Header.VisiblePosition = 4
        UltraGridColumn8.MaskInput = "dd/mm/yyyy"
        UltraGridColumn8.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn8.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn8.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(80, 0)
        UltraGridColumn8.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn8.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn9.Header.Caption = "Ngày kết thúc"
        UltraGridColumn9.Header.VisiblePosition = 5
        UltraGridColumn9.MaskInput = "dd/mm/yyyy"
        UltraGridColumn9.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn9.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn9.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(84, 0)
        UltraGridColumn9.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn9.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn10.Header.Caption = "Ghi chú"
        UltraGridColumn10.Header.VisiblePosition = 6
        UltraGridColumn10.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn10.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn10.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(89, 0)
        UltraGridColumn10.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn10.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn11.Header.Caption = "Mã tiền tệ"
        UltraGridColumn11.Header.VisiblePosition = 7
        UltraGridColumn11.Hidden = True
        UltraGridColumn11.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn11.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn11.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(62, 0)
        UltraGridColumn11.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn11.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11})
        UltraGridBand2.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand2.UseRowLayout = True
        Me.dgDot_Tinh_Cuoc.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.dgDot_Tinh_Cuoc.DisplayLayout.InterBandSpacing = 10
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Me.dgDot_Tinh_Cuoc.DisplayLayout.Override.CardAreaAppearance = Appearance11
        Me.dgDot_Tinh_Cuoc.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance12.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance12.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance12.ForeColor = System.Drawing.Color.Black
        Appearance12.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance12.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgDot_Tinh_Cuoc.DisplayLayout.Override.HeaderAppearance = Appearance12
        Me.dgDot_Tinh_Cuoc.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance13.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDot_Tinh_Cuoc.DisplayLayout.Override.RowAppearance = Appearance13
        Appearance14.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance14.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgDot_Tinh_Cuoc.DisplayLayout.Override.RowSelectorAppearance = Appearance14
        Me.dgDot_Tinh_Cuoc.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgDot_Tinh_Cuoc.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance15.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance15.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance15.ForeColor = System.Drawing.Color.Black
        Me.dgDot_Tinh_Cuoc.DisplayLayout.Override.SelectedRowAppearance = Appearance15
        Me.dgDot_Tinh_Cuoc.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDot_Tinh_Cuoc.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgDot_Tinh_Cuoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDot_Tinh_Cuoc.Location = New System.Drawing.Point(8, 208)
        Me.dgDot_Tinh_Cuoc.Name = "dgDot_Tinh_Cuoc"
        Me.dgDot_Tinh_Cuoc.Size = New System.Drawing.Size(376, 328)
        Me.dgDot_Tinh_Cuoc.TabIndex = 22
        Me.dgDot_Tinh_Cuoc.Text = "Danh sách đợt tính cước"
        '
        'stb_Thong_Tin
        '
        Me.stb_Thong_Tin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stb_Thong_Tin.Location = New System.Drawing.Point(0, 549)
        Me.stb_Thong_Tin.Name = "stb_Thong_Tin"
        Me.stb_Thong_Tin.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.stb1, Me.stb2, Me.stb3, Me.stb4})
        Me.stb_Thong_Tin.ShowPanels = True
        Me.stb_Thong_Tin.Size = New System.Drawing.Size(912, 24)
        Me.stb_Thong_Tin.TabIndex = 1
        Me.stb_Thong_Tin.Text = "StatusBar1"
        '
        'stb1
        '
        Me.stb1.Text = "Tổng số đợt tính cước : "
        Me.stb1.Width = 150
        '
        'stb2
        '
        Me.stb2.Text = "Đợt tính cước số: "
        Me.stb2.Width = 242
        '
        'stb3
        '
        Me.stb3.Text = "Tổng số mục cước : "
        Me.stb3.Width = 236
        '
        'stb4
        '
        Me.stb4.Text = "Ấn F8 để xóa cước"
        Me.stb4.Width = 180
        '
        'grbDanh_Muc_Cuoc
        '
        Me.grbDanh_Muc_Cuoc.Controls.Add(Me.ddMa_Tien_Te)
        Me.grbDanh_Muc_Cuoc.Controls.Add(Me.Nhap_So_Thap_Phan_3)
        Me.grbDanh_Muc_Cuoc.Controls.Add(Me.Nhap_So_Nguyen)
        Me.grbDanh_Muc_Cuoc.Controls.Add(Me.Nhap_So_Thap_Phan)
        Me.grbDanh_Muc_Cuoc.Controls.Add(Me.ddMa_Nuoc)
        Me.grbDanh_Muc_Cuoc.Controls.Add(Me.dgThong_Tin_Cuoc)
        Me.grbDanh_Muc_Cuoc.Location = New System.Drawing.Point(392, 8)
        Me.grbDanh_Muc_Cuoc.Name = "grbDanh_Muc_Cuoc"
        Me.grbDanh_Muc_Cuoc.Size = New System.Drawing.Size(520, 536)
        Me.grbDanh_Muc_Cuoc.SupportThemes = False
        Me.grbDanh_Muc_Cuoc.TabIndex = 1
        '
        'Nhap_So_Nguyen
        '
        Me.Nhap_So_Nguyen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nhap_So_Nguyen.Location = New System.Drawing.Point(192, 120)
        Me.Nhap_So_Nguyen.Name = "Nhap_So_Nguyen"
        Me.Nhap_So_Nguyen.Size = New System.Drawing.Size(100, 23)
        Me.Nhap_So_Nguyen.TabIndex = 47
        Me.Nhap_So_Nguyen.Visible = False
        '
        'Nhap_So_Thap_Phan
        '
        Me.Nhap_So_Thap_Phan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nhap_So_Thap_Phan.Location = New System.Drawing.Point(136, 176)
        Me.Nhap_So_Thap_Phan.Name = "Nhap_So_Thap_Phan"
        Me.Nhap_So_Thap_Phan.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double
        Me.Nhap_So_Thap_Phan.Size = New System.Drawing.Size(100, 23)
        Me.Nhap_So_Thap_Phan.TabIndex = 46
        Me.Nhap_So_Thap_Phan.Visible = False
        '
        'ddMa_Nuoc
        '
        Me.ddMa_Nuoc.Cursor = System.Windows.Forms.Cursors.SizeWE
        Appearance16.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddMa_Nuoc.DisplayLayout.Appearance = Appearance16
        UltraGridColumn12.Header.Caption = "Mã Nước"
        UltraGridColumn12.Header.VisiblePosition = 0
        UltraGridColumn12.Width = 66
        UltraGridColumn13.Header.Caption = "Tên Nước"
        UltraGridColumn13.Header.VisiblePosition = 1
        UltraGridColumn13.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(119, 0)
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn12, UltraGridColumn13})
        UltraGridBand3.UseRowLayout = True
        Me.ddMa_Nuoc.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Appearance17.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance17.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance17.ForeColor = System.Drawing.Color.Black
        Appearance17.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddMa_Nuoc.DisplayLayout.Override.HeaderAppearance = Appearance17
        Me.ddMa_Nuoc.DisplayMember = "Ten_Nuoc"
        Me.ddMa_Nuoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddMa_Nuoc.Location = New System.Drawing.Point(120, 208)
        Me.ddMa_Nuoc.Name = "ddMa_Nuoc"
        Me.ddMa_Nuoc.Size = New System.Drawing.Size(200, 128)
        Me.ddMa_Nuoc.TabIndex = 45
        Me.ddMa_Nuoc.Text = "Mã Nước"
        Me.ddMa_Nuoc.ValueMember = "Ma_Nuoc"
        Me.ddMa_Nuoc.Visible = False
        '
        'dgThong_Tin_Cuoc
        '
        Me.dgThong_Tin_Cuoc.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.dgThong_Tin_Cuoc.DisplayLayout.AddNewBox.Prompt = " "
        Appearance18.BackColor = System.Drawing.Color.White
        Appearance18.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgThong_Tin_Cuoc.DisplayLayout.Appearance = Appearance18
        UltraGridColumn14.Header.VisiblePosition = 0
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.Caption = "Mã nước"
        UltraGridColumn15.Header.VisiblePosition = 2
        UltraGridColumn15.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn15.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn15.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(101, 0)
        UltraGridColumn15.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn15.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn16.Header.Caption = "Cước (D)"
        UltraGridColumn16.Header.VisiblePosition = 3
        UltraGridColumn16.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn16.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn16.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(66, 0)
        UltraGridColumn16.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn16.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn17.Header.Caption = "Cước (M)"
        UltraGridColumn17.Header.VisiblePosition = 4
        UltraGridColumn17.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn17.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn17.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(64, 0)
        UltraGridColumn17.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn17.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn18.Header.Caption = "Kh. lượng"
        UltraGridColumn18.Header.VisiblePosition = 5
        UltraGridColumn18.Hidden = True
        UltraGridColumn18.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(69, 0)
        UltraGridColumn19.Header.Caption = "Cước (KL)"
        UltraGridColumn19.Header.VisiblePosition = 6
        UltraGridColumn19.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn19.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn19.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(68, 0)
        UltraGridColumn19.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn19.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn20.Header.Caption = "Cước VC"
        UltraGridColumn20.Header.VisiblePosition = 7
        UltraGridColumn20.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn20.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn20.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(65, 0)
        UltraGridColumn20.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn20.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn21.Header.VisiblePosition = 1
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.Caption = "Mã tiền tệ"
        UltraGridColumn22.Header.VisiblePosition = 8
        UltraGridColumn22.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn22.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn22.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(71, 0)
        UltraGridColumn22.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn22.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn23.Header.Caption = "Mã tiền VC"
        UltraGridColumn23.Header.VisiblePosition = 9
        UltraGridColumn23.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn23.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn23.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(77, 0)
        UltraGridColumn23.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn23.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23})
        UltraGridBand4.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand4.UseRowLayout = True
        Me.dgThong_Tin_Cuoc.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.dgThong_Tin_Cuoc.DisplayLayout.InterBandSpacing = 10
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Me.dgThong_Tin_Cuoc.DisplayLayout.Override.CardAreaAppearance = Appearance19
        Me.dgThong_Tin_Cuoc.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance20.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance20.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance20.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance20.ForeColor = System.Drawing.Color.Black
        Appearance20.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance20.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgThong_Tin_Cuoc.DisplayLayout.Override.HeaderAppearance = Appearance20
        Me.dgThong_Tin_Cuoc.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance21.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgThong_Tin_Cuoc.DisplayLayout.Override.RowAppearance = Appearance21
        Appearance22.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance22.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgThong_Tin_Cuoc.DisplayLayout.Override.RowSelectorAppearance = Appearance22
        Me.dgThong_Tin_Cuoc.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgThong_Tin_Cuoc.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance23.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance23.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance23.ForeColor = System.Drawing.Color.Black
        Me.dgThong_Tin_Cuoc.DisplayLayout.Override.SelectedRowAppearance = Appearance23
        Me.dgThong_Tin_Cuoc.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgThong_Tin_Cuoc.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgThong_Tin_Cuoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgThong_Tin_Cuoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgThong_Tin_Cuoc.Location = New System.Drawing.Point(3, 2)
        Me.dgThong_Tin_Cuoc.Name = "dgThong_Tin_Cuoc"
        Me.dgThong_Tin_Cuoc.Size = New System.Drawing.Size(514, 531)
        Me.dgThong_Tin_Cuoc.TabIndex = 0
        Me.dgThong_Tin_Cuoc.Text = "Thông tin cước"
        '
        'Nhap_So_Thap_Phan_3
        '
        Me.Nhap_So_Thap_Phan_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nhap_So_Thap_Phan_3.Location = New System.Drawing.Point(264, 168)
        Me.Nhap_So_Thap_Phan_3.MaskInput = "nnn.nnn"
        Me.Nhap_So_Thap_Phan_3.Name = "Nhap_So_Thap_Phan_3"
        Me.Nhap_So_Thap_Phan_3.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double
        Me.Nhap_So_Thap_Phan_3.Size = New System.Drawing.Size(100, 23)
        Me.Nhap_So_Thap_Phan_3.TabIndex = 49
        Me.Nhap_So_Thap_Phan_3.Visible = False
        '
        'ddMa_Tien_Te
        '
        Me.ddMa_Tien_Te.Cursor = System.Windows.Forms.Cursors.Default
        Appearance24.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddMa_Tien_Te.DisplayLayout.Appearance = Appearance24
        UltraGridColumn24.Header.Caption = "Mã tiền tệ"
        UltraGridColumn24.Header.VisiblePosition = 0
        UltraGridColumn24.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(71, 0)
        UltraGridColumn25.Header.Caption = "Tên tiền tệ"
        UltraGridColumn25.Header.VisiblePosition = 1
        UltraGridColumn25.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(95, 0)
        UltraGridColumn26.Header.VisiblePosition = 2
        UltraGridColumn26.Hidden = True
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn24, UltraGridColumn25, UltraGridColumn26})
        UltraGridBand5.UseRowLayout = True
        Me.ddMa_Tien_Te.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Appearance25.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance25.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance25.ForeColor = System.Drawing.Color.Black
        Appearance25.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddMa_Tien_Te.DisplayLayout.Override.HeaderAppearance = Appearance25
        Me.ddMa_Tien_Te.DisplayMember = ""
        Me.ddMa_Tien_Te.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddMa_Tien_Te.Location = New System.Drawing.Point(216, 312)
        Me.ddMa_Tien_Te.Name = "ddMa_Tien_Te"
        Me.ddMa_Tien_Te.Size = New System.Drawing.Size(176, 128)
        Me.ddMa_Tien_Te.TabIndex = 50
        Me.ddMa_Tien_Te.Text = "Mã tiền tệ"
        Me.ddMa_Tien_Te.ValueMember = ""
        Me.ddMa_Tien_Te.Visible = False
        '
        'Frm_Cuoc_Quoc_Te_Di
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(912, 573)
        Me.Controls.Add(Me.grbDanh_Muc_Cuoc)
        Me.Controls.Add(Me.grbDot_Tinh_Cuoc)
        Me.Controls.Add(Me.stb_Thong_Tin)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Frm_Cuoc_Quoc_Te_Di"
        Me.Text = "Bảng cước Quốc tế đi"
        CType(Me.grbDot_Tinh_Cuoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDot_Tinh_Cuoc.ResumeLayout(False)
        CType(Me.cbMa_Tien_Te, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp_Den_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp_Tu_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDot_Tinh_Cuoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stb3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stb4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbDanh_Muc_Cuoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDanh_Muc_Cuoc.ResumeLayout(False)
        CType(Me.Nhap_So_Nguyen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nhap_So_Thap_Phan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddMa_Nuoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgThong_Tin_Cuoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nhap_So_Thap_Phan_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddMa_Tien_Te, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Khai báo biến toàn Form"
    Dim myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Dim myDSQT_Cuoc_Phat_QT_Di As New DSQT_Cuoc_Phat_QT_Di(GConnectionString)
    Dim myDSQT_Danh_Muc_Dot As New DSQT_Danh_Muc_Dot(GConnectionString)
    Dim myDSQT_Danh_Muc_Ma_Nuoc As New DSQT_Danh_Muc_Ma_Nuoc(GConnectionString)
    Dim myDSQT_Danh_Muc_Tien_Te As New DSQT_Danh_Muc_Tien_Te(GConnectionString)
    Dim myHam_Dung_Chung As New Ham_Dung_Chung
    Dim myHanh_Dong_Thuc_Hien As Integer
    Dim myNextCell As Boolean
    Dim myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Const myTen_Doi_Tuong As String = "DSQT_Cuoc_Phat_QT_Di"
#End Region

#Region "Hàm dùng chung"

#Region "KeyEnter"
    Private Sub dtp_Tu_Ngay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtp_Tu_Ngay.KeyDown, dtp_Den_Ngay.KeyDown, txt_Ghi_Chu.KeyDown, txt_Dot.KeyDown, txt_Ten_Dot.KeyDown, cbMa_Tien_Te.KeyDown
        If e.KeyValue = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
        End If
    End Sub
#End Region

#Region "GotFocus"
    Private Sub txt_Dot_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Dot.GotFocus
        txt_Dot.SelectionStart = 0
        txt_Dot.SelectionLength = txt_Dot.Text.Length
    End Sub
    Private Sub txt_Ten_Dot_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Ten_Dot.GotFocus
        txt_Ten_Dot.SelectionStart = 0
        txt_Ten_Dot.SelectionLength = txt_Ten_Dot.Text.Length
    End Sub
    Private Sub txt_Ghi_Chu_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Ghi_Chu.GotFocus
        txt_Ghi_Chu.SelectionStart = 0
        txt_Ghi_Chu.SelectionLength = txt_Ghi_Chu.Text.Length
    End Sub
    Private Sub dtp_Tu_Ngay_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtp_Tu_Ngay.GotFocus
        dtp_Tu_Ngay.SelectionStart = 0
        dtp_Tu_Ngay.SelectionLength = dtp_Tu_Ngay.Text.Length
    End Sub

    Private Sub dtp_Den_Ngay_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtp_Den_Ngay.GotFocus
        dtp_Den_Ngay.SelectionStart = 0
        dtp_Den_Ngay.SelectionLength = dtp_Den_Ngay.Text.Length
    End Sub
#End Region

#End Region

#Region "Tab Control"

#Region "Frm_Cuoc_Quoc_Te_Di_Load"
    Private Sub Frm_Cuoc_Quoc_Te_Di_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Enable_Control(True)
        GetData_MaNuoc()
        GetData_Danh_Muc_Tien_Te()
        DataGrid_Danh_Muc_Dot()
        If dgDot_Tinh_Cuoc.Rows.Count > 0 Then
            dgDot_Tinh_Cuoc.ActiveRow = dgDot_Tinh_Cuoc.Rows(0)
        Else
            Dua_Thong_Tin_Tren_Luoi_Vao_TextBox("", _
                                                "", _
                                                "", _
                                                "", _
                                                "", _
                                                Now.Date, _
                                                Now.Date, _
                                                "", _
                                                "")
            DataGrid_Thong_Tin_Cuoc(txtId_Dot.Text)
        End If
        btn_Them_Moi.Select()
        Refresh_Status_Bar()
    End Sub
#End Region
#Region "btn_Thoat_Click"
    Private Sub btn_Thoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Thoat.Click
        Me.Close()
        Me.Dispose()
    End Sub
#End Region
#Region "btn_Them_Moi_Click"
    Private Sub btn_Them_Moi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Them_Moi.Click
        myHanh_Dong_Thuc_Hien = 1   'Tao moi
        Enable_Control(False)
        'Chuan bi thong tin tao moi dot
        Chuan_Hoa_Thong_Tin_Dot_Truoc_Khi_Tao_Moi()
        dtp_Tu_Ngay.Select()
    End Sub
#End Region
#Region "btn_Sua_Chua_Click"
    Private Sub btn_Sua_Chua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Sua_Chua.Click
        'Kiem tra xem da chon dong can xoa trong luoi chua
        If Not IsNumeric(txt_RowIDX.Text) Then
            MessageBox.Show("Bạn chưa chọn đợt cần sửa chữa. Mời bạn chọn đợt cần sửa thông tin trong danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        myHanh_Dong_Thuc_Hien = 2   'Sua chua
        Enable_Control(False)
        dtp_Tu_Ngay.Select()
    End Sub
#End Region
#Region "btn_Xoa_Click"
    Private Sub btn_Xoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Xoa.Click
        Dim str As String
        'Kiem tra xem da chon dong can xoa trong luoi chua
        If Not IsNumeric(txt_RowIDX.Text) Then
            MessageBox.Show("Bạn chưa chọn đợt cần xóa. Mời bạn chọn đợt cần xóa trong danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        'Kiem tra: Ok => Xoa   Else   => Huy bo
        If Check_Before_Delete(txtId_Dot.Text) Then
            'Dòng thông báo
            str = "Bạn có chắc chắn muốn xóa đợt tính cước số : " & txt_Dot.Text & " không ?" & vbNewLine & "Hãy cẩn trọng trước khi đồng ý xóa, vì nếu xóa đợt tính cước thì các báo cáo liên quan có thể bị lỗi."
            If MessageBox.Show(str, "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                'Xoa trong database
                myDSQT_Danh_Muc_Dot.DSQT_Danh_Muc_Dot_Xoa(txtId_Dot.Text)
                'Xoa tren luoi
                dgDot_Tinh_Cuoc.Rows(CInt(txt_RowIDX.Text)).Delete(False)
                'Thông báo thành công
                MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If dgDot_Tinh_Cuoc.Rows.Count > 0 Then
                    dgDot_Tinh_Cuoc.ActiveRow = dgDot_Tinh_Cuoc.Rows(0)
                Else
                    Dua_Thong_Tin_Tren_Luoi_Vao_TextBox("", _
                                                        "", _
                                                        "", _
                                                        "", _
                                                        myTen_Doi_Tuong, _
                                                        Now().Date, _
                                                        Now().Date, _
                                                        "", _
                                                        "")
                    DataGrid_Thong_Tin_Cuoc(txtId_Dot.Text)
                End If
            Else
                'Thông báo hủy bỏ
                MessageBox.Show("Thao tác xóa đã bị hủy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            'Dòng thông báo
            str = "Bạn không được phép xóa đợt tính cước số : " & txt_Dot.Text & "." & vbNewLine & "Vì vẫn tồn tại thông tin về cước liên quan. Bạn phải xóa chi tiết về cước trước rồi mới thực hiện xóa đợt tính cước"
            MessageBox.Show(str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Refresh_Status_Bar()
    End Sub
#End Region
#Region "btn_Cap_Nhat_Click"
    Private Sub btn_Cap_Nhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cap_Nhat.Click
        If myHam_Dung_Chung.ConvertDateToInt(dtp_Tu_Ngay.Value) > myHam_Dung_Chung.ConvertDateToInt(dtp_Den_Ngay.Value) Then
            MessageBox.Show("Khoảng thời gian đợt cước không hợp lệ !!! Từ ngày không lớn hơn quá đến ngày", "Lỗi cập nhật thông tin đợt tính cước", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtp_Den_Ngay.Select()
            Exit Sub
        End If
        Select Case myHanh_Dong_Thuc_Hien
            Case 1      'Tao moi
                Them_Moi_Dot()
                'Chuyen sang nhap chi tiet cuoc
                dgThong_Tin_Cuoc.Select()
                AddNewRow(dgThong_Tin_Cuoc, False)
                dgThong_Tin_Cuoc.ActiveCell = dgThong_Tin_Cuoc.Rows(dgThong_Tin_Cuoc.Rows.Count - 1).Cells("Ma_Nuoc")
                dgThong_Tin_Cuoc.PerformAction(EnterEditMode, False, False)
            Case 2      'Sua chua
                If IsNumeric(txt_RowIDX.Text) Then
                    Sua_Chua_Danh_Muc_Dot()
                Else
                    MessageBox.Show("Bạn chưa chọn đợt cần cập nhật thông tin." & vbNewLine & "Mời bạn chọn đợt cần sửa thông tin trong danh sách đợt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Case Else
        End Select
        Enable_Control(True)
        'btn_Xem_Cuoc.Select()
        Refresh_Status_Bar()
    End Sub
#End Region
#Region "btn_Huy_Bo_Click"
    Private Sub btn_Huy_Bo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Huy_Bo.Click
        Enable_Control(True)
        'Refresh lai thong tin Textbox ve trang thai default
        If myHanh_Dong_Thuc_Hien = 1 Then       'Tao moi
            Dua_Thong_Tin_Tren_Luoi_Vao_TextBox("", _
                                                "", _
                                                "", _
                                                "", _
                                                "", _
                                                Now.Date, _
                                                Now.Date, _
                                                "", _
                                                "")
        Else        'Sua chua
            Chuyen_Den_Dong_Vua_Thuc_Hien_Cap_Nhat(CInt(txt_RowIDX.Text))
        End If
        btn_Them_Moi.Select()
    End Sub
#End Region
#Region "btn_Load_Cuoc_Click"
    Private Sub btn_Load_Cuoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Load_Cuoc.Click
        Load_Cuoc_Dot_Truoc()
    End Sub
#End Region

#Region "=========dgDot_Tinh_Cuoc========="
#Region "dgDot_Tinh_Cuoc_InitializeLayout"
    Private Sub dgDot_Tinh_Cuoc_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgDot_Tinh_Cuoc.InitializeLayout
        Dim idx As Integer
        myGridKeyDown = sender
        myGridKeyDown.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
        myGridKeyDown.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        myGridKeyDown.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
        For idx = 0 To myGridKeyDown.DisplayLayout.Bands(0).Columns.Count - 1
            myGridKeyDown.DisplayLayout.Bands(0).Columns(idx).CellActivation = Activation.ActivateOnly
            myGridKeyDown.DisplayLayout.Bands(0).Columns(idx).SortIndicator = SortIndicator.None
        Next
    End Sub
#End Region
#Region "dgDot_Tinh_Cuoc_KeyDown"
    Private Sub dgDot_Tinh_Cuoc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgDot_Tinh_Cuoc.KeyDown
        Try
            'Kiem tra cac KeyPress khong chuan ==> Thoat 
            If e.KeyValue < Keys.Space And e.KeyValue <> Keys.Enter And e.KeyValue <> Keys.Escape And e.KeyValue <> Keys.Tab Then
                Exit Sub
            End If
            myGridKeyDown = sender
            'Kiem tra cac loai Keys
            Select Case e.KeyValue
                Case Keys.Enter, Keys.Tab
                    myGridKeyDown.PerformAction(NextCellByTab, False, False)
                    e.Handled = True
                Case Keys.F1
            End Select
        Catch ex As Exception
            ' Call the exception handler
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "dgDot_Tinh_Cuoc_AfterCellActivate"
    Private Sub dgDot_Tinh_Cuoc_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDot_Tinh_Cuoc.AfterCellActivate
        'Try
        '    myGridKeyDown = sender
        '    If myGridKeyDown.ActiveRow.Cells("Id_Dot").Text <> "" Then
        '        Dua_Thong_Tin_Tren_Luoi_Vao_TextBox(myGridKeyDown.ActiveRow.Index, _
        '                                            myGridKeyDown.ActiveRow.Cells("Id_Dot").Text, _
        '                                            myGridKeyDown.ActiveRow.Cells("Dot").Value, _
        '                                            myGridKeyDown.ActiveRow.Cells("Ten_Dot").Text, _
        '                                            myGridKeyDown.ActiveRow.Cells("Ten_Doi_Tuong").Text, _
        '                                            myGridKeyDown.ActiveRow.Cells("Ngay_Bat_Dau").Value, _
        '                                            myGridKeyDown.ActiveRow.Cells("Ngay_Ket_Thuc").Value, _
        '                                            myGridKeyDown.ActiveRow.Cells("Ghi_Chu").Text)
        '    Else
        '        Dua_Thong_Tin_Tren_Luoi_Vao_TextBox("", _
        '                                            "", _
        '                                            "", _
        '                                            "", _
        '                                            "", _
        '                                            Now.Date, _
        '                                            Now.Date, _
        '                                            "")
        '    End If
        '    DataGrid_Thong_Tin_Cuoc(txtId_Dot.Text)
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        '    Dua_Thong_Tin_Tren_Luoi_Vao_TextBox("", _
        '                                        "", _
        '                                        "", _
        '                                        "", _
        '                                        "", _
        '                                        Now.Date, _
        '                                        Now.Date, _
        '                                        "")
        '    DataGrid_Thong_Tin_Cuoc("")
        'End Try
    End Sub
#End Region
#Region "dgDot_Tinh_Cuoc_AfterRowActivate"
    Private Sub dgDot_Tinh_Cuoc_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDot_Tinh_Cuoc.AfterRowActivate
        Try
            myGridKeyDown = sender
            If myGridKeyDown.ActiveRow.Cells("Id_Dot").Text <> "" Then
                Dua_Thong_Tin_Tren_Luoi_Vao_TextBox(myGridKeyDown.ActiveRow.Index, _
                                                    myGridKeyDown.ActiveRow.Cells("Id_Dot").Text, _
                                                    myGridKeyDown.ActiveRow.Cells("Dot").Value, _
                                                    myGridKeyDown.ActiveRow.Cells("Ten_Dot").Text, _
                                                    myGridKeyDown.ActiveRow.Cells("Ten_Doi_Tuong").Text, _
                                                    myGridKeyDown.ActiveRow.Cells("Ngay_Bat_Dau").Value, _
                                                    myGridKeyDown.ActiveRow.Cells("Ngay_Ket_Thuc").Value, _
                                                    myGridKeyDown.ActiveRow.Cells("Ghi_Chu").Text, _
                                                    myGridKeyDown.ActiveRow.Cells("Ma_Tien_Te").Text)
            Else
                Dua_Thong_Tin_Tren_Luoi_Vao_TextBox("", _
                                                    "", _
                                                    "", _
                                                    "", _
                                                    "", _
                                                    Now.Date, _
                                                    Now.Date, _
                                                    "", _
                                                    "")
            End If
            DataGrid_Thong_Tin_Cuoc(txtId_Dot.Text)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Dua_Thong_Tin_Tren_Luoi_Vao_TextBox("", _
                                                "", _
                                                "", _
                                                "", _
                                                "", _
                                                Now.Date, _
                                                Now.Date, _
                                                "", _
                                                "")
            DataGrid_Thong_Tin_Cuoc("")
        End Try
    End Sub
#End Region

#End Region
#Region "=========dgThong_Tin_Cuoc========="
#Region "dgThong_Tin_Cuoc_InitializeLayout"
    Private Sub dgThong_Tin_Cuoc_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgThong_Tin_Cuoc.InitializeLayout
        Dim idx As Integer
        myGridKeyDown = sender
        myNextCell = True
        myGridKeyDown.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
        myGridKeyDown.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        myGridKeyDown.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
        'Ma nuoc
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Nuoc").Style = ColumnStyle.DropDownValidate
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Nuoc").ValueList = ddMa_Nuoc
        'Ma Tien Te
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Tien_Te").Style = ColumnStyle.DropDownValidate
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Tien_Te").ValueList = ddMa_Tien_Te
        'Ma Tien Te VCMBND
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Tien_Te_VCMBND").Style = ColumnStyle.DropDownValidate
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Tien_Te_VCMBND").ValueList = ddMa_Tien_Te
        'Cuoc
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Cuoc_BP_D").EditorControl = Nhap_So_Thap_Phan
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Cuoc_BP_M").EditorControl = Nhap_So_Thap_Phan
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Cuoc").EditorControl = Nhap_So_Thap_Phan
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Cuoc_VCMBND").EditorControl = Nhap_So_Thap_Phan_3
        'Khoi luong
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Khoi_Luong").EditorControl = Nhap_So_Nguyen
    End Sub
#End Region
#Region "dgThong_Tin_Cuoc_InitializeTemplateAddRow"
    Private Sub dgThong_Tin_Cuoc_InitializeTemplateAddRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeTemplateAddRowEventArgs) Handles dgThong_Tin_Cuoc.InitializeTemplateAddRow
        myGridKeyDown = sender
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Khoi_Luong").DefaultCellValue = 1000
    End Sub
#End Region
#Region "dgThong_Tin_Cuoc_CellChange"
    Private Sub dgThong_Tin_Cuoc_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgThong_Tin_Cuoc.CellChange
        myGridKeyDown = sender
        If myGridKeyDown.ActiveCell.Column.Key = "Ma_Nuoc" Then
            If Not ddMa_Nuoc.IsDroppedDown Then
                myGridKeyDown.ActiveCell.DroppedDown = True
            End If
        End If
        If myGridKeyDown.ActiveCell.Column.Key = "Ma_Tien_Te" Then
            If Not ddMa_Tien_Te.IsDroppedDown Then
                myGridKeyDown.ActiveCell.DroppedDown = True
            End If
        End If
        If myGridKeyDown.ActiveCell.Column.Key = "Ma_Tien_Te_VCMBND" Then
            If Not ddMa_Tien_Te.IsDroppedDown Then
                myGridKeyDown.ActiveCell.DroppedDown = True
            End If
        End If
    End Sub
#End Region
#Region "dgThong_Tin_Cuoc_AfterExitEditMode"
    Private Sub dgThong_Tin_Cuoc_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgThong_Tin_Cuoc.AfterExitEditMode
        Try
            myGridKeyDown = sender
            'Kiem tra neu da co van de o AfterCellUpdate ==> Thoat luon
            If myNextCell = False Then Exit Sub
            'Khong cho nhap trung thong tin cuoc
            If myGridKeyDown.ActiveCell.Column.Key = "Ma_Nuoc" Then
                If myGridKeyDown.ActiveRow.Cells("Id_Cuoc").Text.Trim = "" Then
                    If myGridKeyDown.ActiveCell.Value Is DBNull.Value Then
                        Exit Sub
                    End If
                    Dim mId_Cuoc As String
                    mId_Cuoc = Create_Id_Cuoc(myGridKeyDown.ActiveRow.Cells("Ma_Nuoc").Value, txtId_Dot.Text)
                    If myDSQT_Cuoc_Phat_QT_Di.DSQT_Cuoc_Phat_QT_Di_Lay(mId_Cuoc).Ma_Nuoc <> "" Then
                        MessageBox.Show("Thông tin cước này đã tồn tại trong CSDL, bạn không được phép nhập thêm.", "Thông báo", MessageBoxButtons.OK)
                        myGridKeyDown.ActiveCell.Value = ""
                        myNextCell = False
                        Exit Sub
                    End If
                End If
                If myGridKeyDown.ActiveRow.Cells("Id_Cuoc").Text = "" Then
                    SetDefaultValueToCell(myGridKeyDown)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "dgThong_Tin_Cuoc_AfterRowUpdate"
    Private Sub dgThong_Tin_Cuoc_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgThong_Tin_Cuoc.AfterRowUpdate
        Try
            myGridKeyDown = sender

            'Kiem tra truoc khi cap nhat
            If myGridKeyDown.ActiveRow.Cells("Ma_Nuoc").Text = "" Then
                MessageBox.Show("Thông tin nhập vào không hợp lệ, mã nước không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If myGridKeyDown.ActiveRow.Cells("Id_Cuoc").Text = "" Then
                    myGridKeyDown.ActiveRow.Delete(False)
                End If
                Exit Sub
            End If
            If myGridKeyDown.ActiveRow.Cells("Ma_Tien_Te").Text = "" Then
                MessageBox.Show("Thông tin nhập vào không hợp lệ, mã tiền tệ không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If myGridKeyDown.ActiveRow.Cells("Id_Cuoc").Text = "" Then
                    myGridKeyDown.ActiveRow.Delete(False)
                End If
                Exit Sub
            End If
            If myGridKeyDown.ActiveRow.Cells("Ma_Tien_Te_VCMBND").Text = "" Then
                MessageBox.Show("Thông tin nhập vào không hợp lệ, mã tiền tệ cước VCMBND không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If myGridKeyDown.ActiveRow.Cells("Id_Cuoc").Text = "" Then
                    myGridKeyDown.ActiveRow.Delete(False)
                End If
                Exit Sub
            End If
            If Not IsNumeric(myGridKeyDown.ActiveRow.Cells("Cuoc_BP_D").Value) Then
                MessageBox.Show("Thông tin nhập vào không hợp lệ, cước bưu phẩm D phải là 1 số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If myGridKeyDown.ActiveRow.Cells("Id_Cuoc").Text = "" Then
                    myGridKeyDown.ActiveRow.Delete(False)
                End If
                Exit Sub
            End If
            If Not IsNumeric(myGridKeyDown.ActiveRow.Cells("Cuoc_BP_M").Value) Then
                MessageBox.Show("Thông tin nhập vào không hợp lệ, cước bưu phẩm M phải là 1 số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If myGridKeyDown.ActiveRow.Cells("Id_Cuoc").Text = "" Then
                    myGridKeyDown.ActiveRow.Delete(False)
                End If
                Exit Sub
            End If
            If Not IsNumeric(myGridKeyDown.ActiveRow.Cells("Cuoc").Value) Then
                MessageBox.Show("Thông tin nhập vào không hợp lệ, cước phải là 1 số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If myGridKeyDown.ActiveRow.Cells("Id_Cuoc").Text = "" Then
                    myGridKeyDown.ActiveRow.Delete(False)
                End If
                Exit Sub
            End If
            If Not IsNumeric(myGridKeyDown.ActiveRow.Cells("Khoi_Luong").Value) Then
                MessageBox.Show("Thông tin nhập vào không hợp lệ, khối lượng phải là 1 số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If myGridKeyDown.ActiveRow.Cells("Id_Cuoc").Text = "" Then
                    myGridKeyDown.ActiveRow.Delete(False)
                End If
                Exit Sub
            End If
            If Not IsNumeric(myGridKeyDown.ActiveRow.Cells("Cuoc_VCMBND").Value) Then
                MessageBox.Show("Thông tin nhập vào không hợp lệ, cước VCMBND phải là 1 số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If myGridKeyDown.ActiveRow.Cells("Id_Cuoc").Text = "" Then
                    myGridKeyDown.ActiveRow.Delete(False)
                End If
                Exit Sub
            End If

            Dim mDSQT_Cuoc_Phat_QT_Di_Chi_Tiet As New DSQT_Cuoc_Phat_QT_Di_Chi_Tiet
            mDSQT_Cuoc_Phat_QT_Di_Chi_Tiet.Id_Cuoc = Create_Id_Cuoc(myGridKeyDown.ActiveRow.Cells("Ma_Nuoc").Value, txtId_Dot.Text)
            mDSQT_Cuoc_Phat_QT_Di_Chi_Tiet.Id_Dot = txtId_Dot.Text
            mDSQT_Cuoc_Phat_QT_Di_Chi_Tiet.Ma_Nuoc = myGridKeyDown.ActiveRow.Cells("Ma_Nuoc").Value
            mDSQT_Cuoc_Phat_QT_Di_Chi_Tiet.Cuoc_BP_M = myGridKeyDown.ActiveRow.Cells("Cuoc_BP_M").Value
            mDSQT_Cuoc_Phat_QT_Di_Chi_Tiet.Cuoc_BP_D = myGridKeyDown.ActiveRow.Cells("Cuoc_BP_D").Value
            mDSQT_Cuoc_Phat_QT_Di_Chi_Tiet.Khoi_Luong = myGridKeyDown.ActiveRow.Cells("Khoi_Luong").Value
            mDSQT_Cuoc_Phat_QT_Di_Chi_Tiet.Cuoc_VCMBND = myGridKeyDown.ActiveRow.Cells("Cuoc_VCMBND").Value
            mDSQT_Cuoc_Phat_QT_Di_Chi_Tiet.Cuoc = myGridKeyDown.ActiveRow.Cells("Cuoc").Value
            mDSQT_Cuoc_Phat_QT_Di_Chi_Tiet.Ma_Tien_Te = myGridKeyDown.ActiveRow.Cells("Ma_Tien_Te").Value
            mDSQT_Cuoc_Phat_QT_Di_Chi_Tiet.Ma_Tien_Te_VCMBND = myGridKeyDown.ActiveRow.Cells("Ma_Tien_Te_VCMBND").Value
            myDSQT_Cuoc_Phat_QT_Di.DSQT_Cuoc_Phat_QT_Di_Cap_Nhat_Them(mDSQT_Cuoc_Phat_QT_Di_Chi_Tiet.Id_Cuoc, _
                                                                        mDSQT_Cuoc_Phat_QT_Di_Chi_Tiet.Ma_Nuoc, _
                                                                        mDSQT_Cuoc_Phat_QT_Di_Chi_Tiet.Cuoc_BP_D, _
                                                                        mDSQT_Cuoc_Phat_QT_Di_Chi_Tiet.Cuoc_BP_M, _
                                                                        mDSQT_Cuoc_Phat_QT_Di_Chi_Tiet.Khoi_Luong, _
                                                                        mDSQT_Cuoc_Phat_QT_Di_Chi_Tiet.Cuoc, _
                                                                        mDSQT_Cuoc_Phat_QT_Di_Chi_Tiet.Cuoc_VCMBND, _
                                                                        mDSQT_Cuoc_Phat_QT_Di_Chi_Tiet.Id_Dot, _
                                                                        mDSQT_Cuoc_Phat_QT_Di_Chi_Tiet.Ma_Tien_Te, _
                                                                        mDSQT_Cuoc_Phat_QT_Di_Chi_Tiet.Ma_Tien_Te_VCMBND)
            'Truyen gia tri vao luoi
            myGridKeyDown.ActiveRow.Cells("Id_Cuoc").Value = mDSQT_Cuoc_Phat_QT_Di_Chi_Tiet.Id_Cuoc
            myGridKeyDown.ActiveRow.Cells("Id_Dot").Value = mDSQT_Cuoc_Phat_QT_Di_Chi_Tiet.Id_Dot

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "dgThong_Tin_Cuoc_KeyDown"
    Private Sub dgThong_Tin_Cuoc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgThong_Tin_Cuoc.KeyDown
        Try
            myGridKeyDown = sender
            'Kiem tra cac KeyPress khong chuan ==> Thoat 
            If e.KeyValue < Keys.Space And e.KeyValue <> Keys.Enter And e.KeyValue <> Keys.Escape And e.KeyValue <> Keys.Tab Then
                Exit Sub
            End If
            myGridKeyDown = sender
            'Kiem tra cac loai Keys
            Select Case e.KeyValue
                Case Keys.Enter, Keys.Tab
                    'Kiem tra Cell co Value = Null, khong cho next cell
                    If myGridKeyDown.ActiveCell.Column.Key = "Ma_Nuoc" Or myGridKeyDown.ActiveCell.Column.Key = "Ma_Tien_Te" Or myGridKeyDown.ActiveCell.Column.Key = "Ma_Tien_Te_VCMBND" Then
                        If myGridKeyDown.ActiveCell.Text = "" Then
                            e.Handled = True
                            myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                            myCell = Nothing
                            Exit Sub
                        End If
                    Else
                        If Not IsNumeric(Replace_Dau_Gach_Duoi(myGridKeyDown.ActiveCell.Text)) Then
                            e.Handled = True
                            myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                            myCell = Nothing
                            Exit Sub
                        End If
                    End If

                    'Lay index cua Cell dang Active
                    myCell = myGridKeyDown.ActiveCell
                    'Thoat khoi Cell
                    myGridKeyDown.PerformAction(ExitEditMode, False, False)
                    'Kiem tra neu co van de thi khong cho Next Cell
                    If myNextCell = False Then
                        myGridKeyDown.ActiveCell = myCell
                        e.Handled = True
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                        myNextCell = True
                        Exit Sub
                    End If
                    myGridKeyDown.PerformAction(NextCellByTab, False, False)
                    e.Handled = True
                    myGridKeyDown.PerformAction(EnterEditMode, False, False)

                Case Keys.F8
                    Delete_Thong_Tin_Cuoc()
                    e.Handled = True
                Case Keys.F1
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "dgThong_Tin_Cuoc_AfterCellUpdate"
    Private Sub dgThong_Tin_Cuoc_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgThong_Tin_Cuoc.AfterCellUpdate
        Try
            If e.Cell.Row.Cells("Ma_Nuoc").Text <> "" And IsNumeric(e.Cell.Row.Cells("Cuoc_BP_D").Value) And IsNumeric(e.Cell.Row.Cells("Cuoc_BP_M").Value) Then
                AddNewRow(sender, True)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "dgThong_Tin_Cuoc_AfterRowInsert"
    Private Sub dgThong_Tin_Cuoc_AfterRowInsert(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgThong_Tin_Cuoc.AfterRowInsert
        Refresh_Status_Bar()
    End Sub
#End Region
#Region "dgThong_Tin_Cuoc_AfterRowsDeleted"
    Private Sub dgThong_Tin_Cuoc_AfterRowsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgThong_Tin_Cuoc.AfterRowsDeleted
        Refresh_Status_Bar()
    End Sub
#End Region
#Region "dgThong_Tin_Cuoc_BeforeCellUpdate"
    Private Sub dgThong_Tin_Cuoc_BeforeCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles dgThong_Tin_Cuoc.BeforeCellUpdate
        Try
            Dim mId_Cuoc As String
            If myGridKeyDown.ActiveCell Is Nothing Then
                myNextCell = True
                Exit Sub
            End If
            If myGridKeyDown.ActiveCell.Column.Key = "Ma_Nuoc" Then
                'Khong cho sua khi da ghi vao CSDL
                If myGridKeyDown.ActiveRow.Cells("Id_Cuoc").Text <> "" Then
                    MessageBox.Show("Thông tin cước này đã tồn tại trong CSDL, bạn không được phép sửa thông tin mã nước.", "Thông báo", MessageBoxButtons.OK)
                    myNextCell = False
                    e.Cancel = True
                    Exit Sub
                End If
            End If
            myNextCell = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#End Region

#End Region

#Region "Hàm người dùng"

#Region "Enable_Control"
    Private Sub Enable_Control(ByVal bolControl As Boolean)
        btn_Them_Moi.Enabled = bolControl
        btn_Sua_Chua.Enabled = bolControl
        btn_Xoa.Enabled = bolControl
        dgDot_Tinh_Cuoc.Enabled = bolControl
        btn_Cap_Nhat.Enabled = Not bolControl
        btn_Huy_Bo.Enabled = Not bolControl
        txt_Dot.Enabled = Not bolControl
        txt_Ten_Dot.Enabled = Not bolControl
        dtp_Tu_Ngay.Enabled = Not bolControl
        dtp_Den_Ngay.Enabled = Not bolControl
        txt_Ghi_Chu.Enabled = Not bolControl

        If dtp_Den_Ngay.Enabled = True Then
            If myHanh_Dong_Thuc_Hien = 2 Then
                dtp_Den_Ngay.ReadOnly = False
            Else
                dtp_Den_Ngay.ReadOnly = True
            End If
        End If

    End Sub
#End Region
#Region "Check_Before_Delete"
    Private Function Check_Before_Delete(ByVal mDot_Id As String) As Boolean
        Try
            'Kiem tra xem co duoc phep xoa khong
            If myDSQT_Cuoc_Phat_QT_Di.DSQT_Cuoc_Phat_QT_Di_Danh_Sach_Theo_Id_Dot(mDot_Id).Tables(0).Rows.Count > 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region
#Region "Refresh_Status_Bar"
    Private Sub Refresh_Status_Bar()
        Dim str1 As String
        Dim str2 As String
        Dim str3 As String
        Dim str4 As String
        Dim idx As Integer
        Dim tong_dong As Integer
        str1 = "Tổng số :  " & dgDot_Tinh_Cuoc.Rows.Count.ToString & " đợt cước."
        str2 = "Đang làm việc với đợt cước số: < " & txt_Dot.Text & " >"
        tong_dong = 0
        For idx = 0 To dgThong_Tin_Cuoc.Rows.Count - 1
            If dgThong_Tin_Cuoc.Rows(idx).Cells("Ma_Nuoc").Text <> "" And IsNumeric(dgThong_Tin_Cuoc.Rows(idx).Cells("Cuoc_BP_M").Value) Then
                tong_dong = tong_dong + 1
            End If
        Next
        str3 = "Tổng số :  " & tong_dong.ToString & " mục cước."
        str4 = "Ấn F8 để xóa mục cước."
        stb_Thong_Tin.Panels(0).Text = str1
        stb_Thong_Tin.Panels(1).Text = str2
        stb_Thong_Tin.Panels(2).Text = str3
        stb_Thong_Tin.Panels(3).Text = str4
    End Sub
#End Region
#Region "DataGrid_Danh_Muc_Dot"
    Private Sub DataGrid_Danh_Muc_Dot()
        dgDot_Tinh_Cuoc.DataSource = myDSQT_Danh_Muc_Dot.DSQT_Danh_Muc_Dot_Danh_Sach_Lay_Theo_Ten_Doi_Tuong(myTen_Doi_Tuong).Tables(0)
        dgDot_Tinh_Cuoc.DataBind()
    End Sub
#End Region
#Region "DataGrid_Thong_Tin_Cuoc"
    Private Sub DataGrid_Thong_Tin_Cuoc(ByVal mId_Dot As String)
        dgThong_Tin_Cuoc.DataSource = myDSQT_Cuoc_Phat_QT_Di.DSQT_Cuoc_Phat_QT_Di_Danh_Sach_Theo_Id_Dot(mId_Dot).Tables(0)
        dgThong_Tin_Cuoc.DataBind()
        Refresh_Status_Bar()
    End Sub
#End Region
#Region "GetData_Danh_Muc_Tien_Te"
    Private Sub GetData_Danh_Muc_Tien_Te()
        cbMa_Tien_Te.DataSource = myDSQT_Danh_Muc_Tien_Te.DSQT_Danh_Muc_Tien_Te_Danh_Sach()
        cbMa_Tien_Te.DataBind()

        ddMa_Tien_Te.DataSource = myDSQT_Danh_Muc_Tien_Te.DSQT_Danh_Muc_Tien_Te_Danh_Sach()
        ddMa_Tien_Te.DataBind()
        'cbMa_Tien_Te.LimitToList = True
        'If cbMa_Tien_Te.Rows.Count > 0 Then
        '    cbMa_Tien_Te.Value = cbMa_Tien_Te.Rows(0).Cells("Ma_Tien_Te").Value
        'End If
    End Sub
#End Region
#Region "Dua_Thong_Tin_Tren_Luoi_Vao_TextBox"
    Private Sub Dua_Thong_Tin_Tren_Luoi_Vao_TextBox(ByVal mRowIDX As String, ByVal mId_Dot As String, ByVal mDot As String, ByVal mTen_Dot As String, ByVal mTen_Doi_Tuong As String, ByVal mTu_Ngay As Date, ByVal mDen_Ngay As Date, ByVal mGhi_Chu As String, ByVal mMa_Tien_Te As String)
        txt_RowIDX.Text = mRowIDX
        txtId_Dot.Text = mId_Dot
        txt_Dot.Text = mDot
        txt_Ten_Dot.Text = mTen_Dot
        txt_Ten_Doi_Tuong.Text = mTen_Doi_Tuong
        dtp_Tu_Ngay.Value = mTu_Ngay
        dtp_Den_Ngay.Value = mDen_Ngay
        txt_Ghi_Chu.Text = mGhi_Chu
        cbMa_Tien_Te.Value = mMa_Tien_Te
    End Sub
#End Region
#Region "AddNewRow (Loai = True: nhap tren luoi ; Loai = false: insert vao luoi"
    Private Sub AddNewRow(ByVal sender As Object, ByVal Loai As Boolean)
        myGridKeyDown = sender
        If Not Loai Then  'Loai insert vao luoi
            If myGridKeyDown.Rows.Count = 0 Then  'Dong dau tien
                myGridKeyDown.Rows.Band.AddNew()
            Else
                If myGridKeyDown.Rows(myGridKeyDown.Rows.Count - 1).Cells("Dot").Text <> "" Then
                    myGridKeyDown.Rows.Band.AddNew()
                End If
            End If
        Else 'loai nhap tren luoi
            If Not myGridKeyDown.ActiveCell Is Nothing Then
                If myGridKeyDown.ActiveCell.Row.HasNextSibling = False Then
                    myGridKeyDown.Rows.Band.AddNew()
                End If
            End If
        End If
    End Sub
#End Region
#Region "Them_Moi_Dot"
    Private Sub Them_Moi_Dot()
        Try
            'If cbMa_Tien_Te.Text.Trim = "" Then
            '    MessageBox.Show("Mã Tiền tệ không được để trống!!!", "Lỗi cập nhật thông tin đợt tính cước", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Exit Sub
            'End If
            'Them vao du lieu
            myDSQT_Danh_Muc_Dot.DSQT_Danh_Muc_Dot_Cap_Nhat_Them(txtId_Dot.Text, _
                                                                txt_Dot.Text, _
                                                                txt_Ten_Dot.Text, _
                                                                txt_Ten_Doi_Tuong.Text, _
                                                                myHam_Dung_Chung.ConvertDateToInt(dtp_Tu_Ngay.Value), _
                                                                myHam_Dung_Chung.ConvertDateToInt(dtp_Den_Ngay.Value), _
                                                                txt_Ghi_Chu.Text, _
                                                                cbMa_Tien_Te.Text)
            'Lay thong tin dot vua them moi de dua vao luoi
            Dim mDSQT_Danh_Muc_Dot_Chi_Tiet As New DSQT_Danh_Muc_Dot_Chi_Tiet
            mDSQT_Danh_Muc_Dot_Chi_Tiet = myDSQT_Danh_Muc_Dot.DSQT_Danh_Muc_Dot_Lay(txtId_Dot.Text)
            'Cap nhat ngay ket thuc cua dot lien truoc do
            Dim mDot_Lien_Truoc As Integer
            'Lay Id_Dot liền trước đó
            mDot_Lien_Truoc = myDSQT_Danh_Muc_Dot.DSQT_Danh_Muc_Dot_Lay_Dot_Lien_Truoc_Dot_Lon_Nhat_Theo_Ten_Doi_Tuong(myTen_Doi_Tuong, mDSQT_Danh_Muc_Dot_Chi_Tiet.Dot)
            If mDot_Lien_Truoc > 0 Then
                Dim mId_Dot_Lien_Truoc As String = Create_Id_Dot(mDot_Lien_Truoc, myTen_Doi_Tuong)
                Dim mDSQT_Danh_Muc_Dot_Lien_Truoc_Chi_Tiet As New DSQT_Danh_Muc_Dot_Chi_Tiet
                mDSQT_Danh_Muc_Dot_Lien_Truoc_Chi_Tiet = myDSQT_Danh_Muc_Dot.DSQT_Danh_Muc_Dot_Lay(mId_Dot_Lien_Truoc)
                'Sua lai ngay ket thuc
                mDSQT_Danh_Muc_Dot_Lien_Truoc_Chi_Tiet.Ngay_Ket_Thuc = myHam_Dung_Chung.MinusIntDate(mDSQT_Danh_Muc_Dot_Chi_Tiet.Ngay_Bat_Dau, 1)
                'Cap nhat vao database
                myDSQT_Danh_Muc_Dot.DSQT_Danh_Muc_Dot_Cap_Nhat(mDSQT_Danh_Muc_Dot_Lien_Truoc_Chi_Tiet.Id_Dot, _
                                                                mDSQT_Danh_Muc_Dot_Lien_Truoc_Chi_Tiet.Dot, _
                                                                mDSQT_Danh_Muc_Dot_Lien_Truoc_Chi_Tiet.Ten_Dot, _
                                                                mDSQT_Danh_Muc_Dot_Lien_Truoc_Chi_Tiet.Ten_Doi_Tuong, _
                                                                mDSQT_Danh_Muc_Dot_Lien_Truoc_Chi_Tiet.Ngay_Bat_Dau, _
                                                                mDSQT_Danh_Muc_Dot_Lien_Truoc_Chi_Tiet.Ngay_Ket_Thuc, _
                                                                mDSQT_Danh_Muc_Dot_Lien_Truoc_Chi_Tiet.Ghi_Chu, _
                                                                mDSQT_Danh_Muc_Dot_Lien_Truoc_Chi_Tiet.Ma_Tien_Te)
            End If
            'Them dong vao luoi
            'AddNewRow(dgDot_Tinh_Cuoc, False)
            'Truyen thong tin textbox vao luoi            
            'Truyen_Thong_Tin_Them_Moi_Tu_CSDL_Vao_Luoi(dgDot_Tinh_Cuoc.Rows.Count - 1, mDSQT_Danh_Muc_Dot_Chi_Tiet)
            DataGrid_Danh_Muc_Dot()
            'Chuyen den vi tri vua tao moi
            Chuyen_Den_Dong_Vua_Thuc_Hien_Cap_Nhat(0)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "Sua_Chua_Danh_Muc_Dot"
    Private Sub Sua_Chua_Danh_Muc_Dot()
        Try
            'If cbMa_Tien_Te.Text.Trim = "" Then
            '    MessageBox.Show("Mã Tiền tệ không được để trống!!!", "Lỗi cập nhật thông tin đợt tính cước", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Exit Sub
            'End If
            'Sua vao du lieu
            myDSQT_Danh_Muc_Dot.DSQT_Danh_Muc_Dot_Cap_Nhat_Them(txtId_Dot.Text, _
                                                                txt_Dot.Text, _
                                                                txt_Ten_Dot.Text, _
                                                                txt_Ten_Doi_Tuong.Text, _
                                                                myHam_Dung_Chung.ConvertDateToInt(dtp_Tu_Ngay.Value), _
                                                                myHam_Dung_Chung.ConvertDateToInt(dtp_Den_Ngay.Value), _
                                                                txt_Ghi_Chu.Text, _
                                                                cbMa_Tien_Te.Text)
            'Truyen thong tin textbox vao luoi
            Truyen_Thong_Tin_TextBox_Vao_Luoi(CInt(txt_RowIDX.Text))
            'Chuyen den vi tri vua Cap nhat
            Chuyen_Den_Dong_Vua_Thuc_Hien_Cap_Nhat(CInt(txt_RowIDX.Text))
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "Create_Id_Dot"
    Private Function Create_Id_Dot(ByVal mDot As Integer, ByVal mTen_Doi_Tuong As String) As String
        Try
            Return mTen_Doi_Tuong & "_" & mDot.ToString("0000")
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        End Try
    End Function
#End Region
#Region "Kiem_Tra_Thong_Tin_Nguoi_Dung_Nhap_Vao_Truoc_Khi_Cap_Nhat"
    Private Function Kiem_Tra_Thong_Tin_Nguoi_Dung_Nhap_Vao_Truoc_Khi_Cap_Nhat() As Boolean

    End Function
#End Region
#Region "Chuan_Hoa_Thong_Tin_Dot_Truoc_Khi_Tao_Moi"
    Private Sub Chuan_Hoa_Thong_Tin_Dot_Truoc_Khi_Tao_Moi()
        Dim mDSQT_Danh_Muc_Dot_Chi_Tiet As New DSQT_Danh_Muc_Dot_Chi_Tiet
        'Lay thong tin vao bien
        mDSQT_Danh_Muc_Dot_Chi_Tiet.Dot = myDSQT_Danh_Muc_Dot.DSQT_Danh_Muc_Dot_Lay_Dot_Lon_Nhat_Theo_Ten_Doi_Tuong(myTen_Doi_Tuong) + 1
        mDSQT_Danh_Muc_Dot_Chi_Tiet.Id_Dot = Create_Id_Dot(mDSQT_Danh_Muc_Dot_Chi_Tiet.Dot, myTen_Doi_Tuong)
        mDSQT_Danh_Muc_Dot_Chi_Tiet.Ten_Dot = "Đot " & mDSQT_Danh_Muc_Dot_Chi_Tiet.Dot
        mDSQT_Danh_Muc_Dot_Chi_Tiet.Ten_Doi_Tuong = myTen_Doi_Tuong
        'Truyen bien vao textbox
        txtId_Dot.Text = mDSQT_Danh_Muc_Dot_Chi_Tiet.Id_Dot
        txt_Dot.Text = mDSQT_Danh_Muc_Dot_Chi_Tiet.Dot
        txt_Ten_Dot.Text = mDSQT_Danh_Muc_Dot_Chi_Tiet.Ten_Dot
        txt_Ten_Doi_Tuong.Text = mDSQT_Danh_Muc_Dot_Chi_Tiet.Ten_Doi_Tuong
        dtp_Tu_Ngay.Value = Now().Date
        dtp_Den_Ngay.Value = myHam_Dung_Chung.ConvertIntToDate(20991231)
        txt_Ghi_Chu.Text = ""
        cbMa_Tien_Te.Value = ""
        'If cbMa_Tien_Te.Rows.Count > 0 Then
        '    cbMa_Tien_Te.Value = cbMa_Tien_Te.Rows(0).Cells("Ma_Tien_Te").Value
        'End If
        txt_RowIDX.Text = ""
    End Sub
#End Region
#Region "Truyen_Thong_Tin_TextBox_Vao_Luoi"
    Private Sub Truyen_Thong_Tin_TextBox_Vao_Luoi(ByVal idxRow As Integer)
        Try
            dgDot_Tinh_Cuoc.Rows(idxRow).Cells("Id_Dot").Value = txtId_Dot.Text
            dgDot_Tinh_Cuoc.Rows(idxRow).Cells("Dot").Value = txt_Dot.Text
            dgDot_Tinh_Cuoc.Rows(idxRow).Cells("Ten_Dot").Value = txt_Ten_Dot.Text
            dgDot_Tinh_Cuoc.Rows(idxRow).Cells("Ten_Doi_Tuong").Value = txt_Ten_Doi_Tuong.Text
            dgDot_Tinh_Cuoc.Rows(idxRow).Cells("Ngay_Bat_Dau").Value = dtp_Tu_Ngay.Value
            dgDot_Tinh_Cuoc.Rows(idxRow).Cells("Ngay_Ket_Thuc").Value = dtp_Den_Ngay.Value
            dgDot_Tinh_Cuoc.Rows(idxRow).Cells("Ghi_Chu").Value = txt_Ghi_Chu.Text
            dgDot_Tinh_Cuoc.Rows(idxRow).Cells("Ma_Tien_Te").Value = cbMa_Tien_Te.Text
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region
#Region "Truyen_Thong_Tin_Them_Moi_Tu_CSDL_Vao_Luoi"
    Private Sub Truyen_Thong_Tin_Them_Moi_Tu_CSDL_Vao_Luoi(ByVal idxRow As Integer, ByVal mDSQT_Danh_Muc_Dot_Chi_Tiet As DSQT_Danh_Muc_Dot_Chi_Tiet)
        Try
            dgDot_Tinh_Cuoc.Rows(idxRow).Cells("Id_Dot").Value = mDSQT_Danh_Muc_Dot_Chi_Tiet.Id_Dot
            dgDot_Tinh_Cuoc.Rows(idxRow).Cells("Dot").Value = mDSQT_Danh_Muc_Dot_Chi_Tiet.Dot
            dgDot_Tinh_Cuoc.Rows(idxRow).Cells("Ten_Dot").Value = mDSQT_Danh_Muc_Dot_Chi_Tiet.Ten_Dot
            dgDot_Tinh_Cuoc.Rows(idxRow).Cells("Ten_Doi_Tuong").Value = mDSQT_Danh_Muc_Dot_Chi_Tiet.Ten_Doi_Tuong
            dgDot_Tinh_Cuoc.Rows(idxRow).Cells("Ngay_Bat_Dau").Value = myHam_Dung_Chung.ConvertIntToDate(mDSQT_Danh_Muc_Dot_Chi_Tiet.Ngay_Bat_Dau)
            dgDot_Tinh_Cuoc.Rows(idxRow).Cells("Ngay_Ket_Thuc").Value = myHam_Dung_Chung.ConvertIntToDate(mDSQT_Danh_Muc_Dot_Chi_Tiet.Ngay_Ket_Thuc)
            dgDot_Tinh_Cuoc.Rows(idxRow).Cells("Ghi_Chu").Value = mDSQT_Danh_Muc_Dot_Chi_Tiet.Ghi_Chu
            dgDot_Tinh_Cuoc.Rows(idxRow).Cells("Ma_Tien_Te").Value = mDSQT_Danh_Muc_Dot_Chi_Tiet.Ma_Tien_Te
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region
#Region "Chuyen_Den_Dong_Vua_Thuc_Hien_Cap_Nhat"
    Private Sub Chuyen_Den_Dong_Vua_Thuc_Hien_Cap_Nhat(ByVal mRowIDX As Integer)
        Try
            dgDot_Tinh_Cuoc.Rows(mRowIDX).Selected = True
            dgDot_Tinh_Cuoc.ActiveRow = dgDot_Tinh_Cuoc.Rows(mRowIDX)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "GetData_MaNuoc"
    Private Sub GetData_MaNuoc()
        ddMa_Nuoc.DataSource = myDSQT_Danh_Muc_Ma_Nuoc.DSQT_Danh_Muc_Ma_Nuoc_Danh_Sach_Rut_Gon
        ddMa_Nuoc.DataBind()
    End Sub
#End Region
#Region "Create_Id_Cuoc"
    Private Function Create_Id_Cuoc(ByVal mMa_Nuoc As String, ByVal mId_Dot As String) As String
        Try
            Return mMa_Nuoc & "_" & mId_Dot
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        End Try
    End Function
#End Region
#Region "Replace_Dau_Gach_Duoi"
    Private Function Replace_Dau_Gach_Duoi(ByVal mChuoi As String) As String
        Return mChuoi.Replace("_", "")
    End Function

#End Region
#Region "Delete_Thong_Tin_Cuoc"
    Private Sub Delete_Thong_Tin_Cuoc()
        Try
            If MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin cước : " & dgThong_Tin_Cuoc.ActiveRow.Cells("Ma_Nuoc").Text & " không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                myDSQT_Cuoc_Phat_QT_Di.DSQT_Cuoc_Phat_QT_Di_Xoa(myGridKeyDown.ActiveRow.Cells("Id_Cuoc").Text)
                dgThong_Tin_Cuoc.ActiveRow.Delete(False)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Load_Cuoc_Dot_Truoc"
    Private Sub Load_Cuoc_Dot_Truoc()
        Try
            'Lay thong tin dot dang su dung
            Dim mDSQT_Danh_Muc_Dot_Chi_Tiet As New DSQT_Danh_Muc_Dot_Chi_Tiet
            mDSQT_Danh_Muc_Dot_Chi_Tiet = myDSQT_Danh_Muc_Dot.DSQT_Danh_Muc_Dot_Lay(txtId_Dot.Text)
            'Kiem tra neu dot dang su dung da co cuoc thi khong cho load cuoc dot truoc vao
            If myDSQT_Cuoc_Phat_QT_Di.DSQT_Cuoc_Phat_QT_Di_Danh_Sach_Theo_Id_Dot(mDSQT_Danh_Muc_Dot_Chi_Tiet.Id_Dot).Tables(0).Rows.Count > 0 Then
                MessageBox.Show("Đợt tính cước này đã tồn tại thông tin chi tiết về cước, bạn không được phép thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            'Lay thong tin cua dot lien truoc do
            Dim mDot_Lien_Truoc As Integer
            'Lay STT Dot liền trước đó
            mDot_Lien_Truoc = myDSQT_Danh_Muc_Dot.DSQT_Danh_Muc_Dot_Lay_Dot_Lien_Truoc_Dot_Lon_Nhat_Theo_Ten_Doi_Tuong(myTen_Doi_Tuong, mDSQT_Danh_Muc_Dot_Chi_Tiet.Dot)
            'Neu co ton tai dot lien truoc
            If mDot_Lien_Truoc > 0 Then
                If MessageBox.Show("Bạn có chắc chắn muốn lấy thông tin cước của đợt : " & mDot_Lien_Truoc & " không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    'Lay Id_Dot lien truoc
                    Dim mId_Dot_Lien_Truoc As String = Create_Id_Dot(mDot_Lien_Truoc, myTen_Doi_Tuong)
                    'Lay thong tin cuoc dot lien truoc
                    Dim mData As DataTable
                    mData = myDSQT_Cuoc_Phat_QT_Di.DSQT_Cuoc_Phat_QT_Di_Danh_Sach_Theo_Id_Dot(mId_Dot_Lien_Truoc).Tables(0)
                    If mData.Rows.Count = 0 Then
                        MessageBox.Show("Đợt tính cước : " & mDot_Lien_Truoc.ToString & " không có thông tin về cước!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    'Duyet va ghi vao dot hien tai
                    Dim idx As Integer
                    Dim mId_Cuoc_Dot_Hien_Tai As String
                    For idx = 0 To mData.Rows.Count - 1
                        mId_Cuoc_Dot_Hien_Tai = Create_Id_Cuoc(mData.Rows(idx).Item("Ma_Nuoc"), mDSQT_Danh_Muc_Dot_Chi_Tiet.Id_Dot)
                        myDSQT_Cuoc_Phat_QT_Di.DSQT_Cuoc_Phat_QT_Di_Cap_Nhat_Them(mId_Cuoc_Dot_Hien_Tai, _
                                                                                mData.Rows(idx).Item("Ma_Nuoc"), _
                                                                                mData.Rows(idx).Item("Cuoc_BP_D"), _
                                                                                mData.Rows(idx).Item("Cuoc_BP_M"), _
                                                                                mData.Rows(idx).Item("Khoi_Luong"), _
                                                                                mData.Rows(idx).Item("Cuoc"), _
                                                                                mData.Rows(idx).Item("Cuoc_VCMBND"), _
                                                                                mDSQT_Danh_Muc_Dot_Chi_Tiet.Id_Dot, _
                                                                                mData.Rows(idx).Item("Ma_Tien_Te"), _
                                                                                mData.Rows(idx).Item("Ma_Tien_Te_VCMBND"))
                    Next
                    'Load len luoi
                    DataGrid_Thong_Tin_Cuoc(mDSQT_Danh_Muc_Dot_Chi_Tiet.Id_Dot)
                End If
            Else
                MessageBox.Show("Không có thông tin đợt liền trước. Load cước thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "------------------------SetDefaultValueToCell------------------------"
    Private Sub SetDefaultValueToCell(ByVal sender As Object)
        myGridKeyDown = sender
        If myGridKeyDown.ActiveRow.Cells("Ma_Tien_Te").Text = "" And myGridKeyDown.ActiveRow.Cells("Ma_Tien_Te_VCMBND").Text = "" Then
            If myGridKeyDown.ActiveRow.Index > 0 Then
                myGridKeyDown.ActiveRow.Cells("Ma_Tien_Te").Value = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index - 1).Cells("Ma_Tien_Te").Text
                myGridKeyDown.ActiveRow.Cells("Ma_Tien_Te_VCMBND").Value = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index - 1).Cells("Ma_Tien_Te_VCMBND").Text
            End If
        End If
    End Sub
#End Region
#End Region

End Class

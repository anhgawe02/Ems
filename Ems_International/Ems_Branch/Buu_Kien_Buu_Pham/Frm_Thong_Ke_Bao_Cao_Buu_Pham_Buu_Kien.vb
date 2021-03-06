Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports Ems_International_Logic.EMS

Public Class Frm_Thong_Ke_Bao_Cao_Buu_Pham_Buu_Kien
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
    Friend WithEvents grbThoi_Gian As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CbDen_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CbTu_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents grbDanh_Muc_Bao_Cao As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents optTy_Le_Thong_Quan As System.Windows.Forms.RadioButton
    Friend WithEvents optTy_Le_Kiem_Quan As System.Windows.Forms.RadioButton
    Friend WithEvents optChua_Thong_Quan As System.Windows.Forms.RadioButton
    Friend WithEvents optTon_Kho_Hai_Quan As System.Windows.Forms.RadioButton
    Friend WithEvents optTat_Ca As System.Windows.Forms.RadioButton
    Friend WithEvents nudSau As System.Windows.Forms.NumericUpDown
    Friend WithEvents optSau As System.Windows.Forms.RadioButton
    Friend WithEvents nudDen As System.Windows.Forms.NumericUpDown
    Friend WithEvents optDen As System.Windows.Forms.RadioButton
    Friend WithEvents nudBang As System.Windows.Forms.NumericUpDown
    Friend WithEvents optBang As System.Windows.Forms.RadioButton
    Friend WithEvents grbTuy_Chon As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnXem_Bao_Cao As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnThoat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnChi_Tiet As Infragistics.Win.Misc.UltraButton
    Friend WithEvents sFileDlg As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cbMa_Nuoc As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents optBao_Cao_Tong_Hop As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Nuoc", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Nuoc")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_Thong_Ke_Bao_Cao_Buu_Pham_Buu_Kien))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.grbThoi_Gian = New Infragistics.Win.Misc.UltraGroupBox
        Me.cbMa_Nuoc = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.CbDen_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.CbTu_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.grbDanh_Muc_Bao_Cao = New Infragistics.Win.Misc.UltraGroupBox
        Me.optBao_Cao_Tong_Hop = New System.Windows.Forms.RadioButton
        Me.optTon_Kho_Hai_Quan = New System.Windows.Forms.RadioButton
        Me.optChua_Thong_Quan = New System.Windows.Forms.RadioButton
        Me.optTy_Le_Kiem_Quan = New System.Windows.Forms.RadioButton
        Me.optTy_Le_Thong_Quan = New System.Windows.Forms.RadioButton
        Me.grbTuy_Chon = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.nudSau = New System.Windows.Forms.NumericUpDown
        Me.optSau = New System.Windows.Forms.RadioButton
        Me.nudDen = New System.Windows.Forms.NumericUpDown
        Me.optDen = New System.Windows.Forms.RadioButton
        Me.nudBang = New System.Windows.Forms.NumericUpDown
        Me.optBang = New System.Windows.Forms.RadioButton
        Me.optTat_Ca = New System.Windows.Forms.RadioButton
        Me.btnXem_Bao_Cao = New Infragistics.Win.Misc.UltraButton
        Me.btnThoat = New Infragistics.Win.Misc.UltraButton
        Me.btnChi_Tiet = New Infragistics.Win.Misc.UltraButton
        Me.sFileDlg = New System.Windows.Forms.SaveFileDialog
        CType(Me.grbThoi_Gian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbThoi_Gian.SuspendLayout()
        CType(Me.cbMa_Nuoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbDen_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbTu_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbDanh_Muc_Bao_Cao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDanh_Muc_Bao_Cao.SuspendLayout()
        CType(Me.grbTuy_Chon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbTuy_Chon.SuspendLayout()
        CType(Me.nudSau, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbThoi_Gian
        '
        Me.grbThoi_Gian.Controls.Add(Me.cbMa_Nuoc)
        Me.grbThoi_Gian.Controls.Add(Me.UltraLabel6)
        Me.grbThoi_Gian.Controls.Add(Me.UltraLabel3)
        Me.grbThoi_Gian.Controls.Add(Me.CbDen_Ngay)
        Me.grbThoi_Gian.Controls.Add(Me.UltraLabel4)
        Me.grbThoi_Gian.Controls.Add(Me.CbTu_Ngay)
        Me.grbThoi_Gian.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbThoi_Gian.Location = New System.Drawing.Point(8, 16)
        Me.grbThoi_Gian.Name = "grbThoi_Gian"
        Me.grbThoi_Gian.Size = New System.Drawing.Size(520, 80)
        Me.grbThoi_Gian.SupportThemes = False
        Me.grbThoi_Gian.TabIndex = 0
        Me.grbThoi_Gian.Text = "Thông tin khai thác"
        '
        'cbMa_Nuoc
        '
        Me.cbMa_Nuoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbMa_Nuoc.DataMember = Nothing
        UltraGridColumn1.Header.Caption = "Mã Nước"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.Header.Caption = "Tên Nước"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2})
        UltraGridBand1.Header.Caption = "Mã Nước"
        Me.cbMa_Nuoc.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.cbMa_Nuoc.DisplayMember = ""
        Me.cbMa_Nuoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMa_Nuoc.Location = New System.Drawing.Point(424, 40)
        Me.cbMa_Nuoc.Name = "cbMa_Nuoc"
        Me.cbMa_Nuoc.Size = New System.Drawing.Size(88, 21)
        Me.cbMa_Nuoc.TabIndex = 5
        Me.cbMa_Nuoc.ValueMember = ""
        '
        'UltraLabel6
        '
        Me.UltraLabel6.Location = New System.Drawing.Point(360, 42)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(64, 17)
        Me.UltraLabel6.TabIndex = 4
        Me.UltraLabel6.Text = "Mã Nước"
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Location = New System.Drawing.Point(176, 42)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel3.TabIndex = 2
        Me.UltraLabel3.Text = "Đến ngày"
        '
        'CbDen_Ngay
        '
        Me.CbDen_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.CbDen_Ngay.Location = New System.Drawing.Point(248, 38)
        Me.CbDen_Ngay.Name = "CbDen_Ngay"
        Me.CbDen_Ngay.Size = New System.Drawing.Size(96, 24)
        Me.CbDen_Ngay.TabIndex = 3
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Location = New System.Drawing.Point(8, 42)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel4.TabIndex = 0
        Me.UltraLabel4.Text = "Từ ngày"
        '
        'CbTu_Ngay
        '
        Me.CbTu_Ngay.DateTime = New Date(2008, 7, 3, 0, 0, 0, 0)
        Me.CbTu_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.CbTu_Ngay.Location = New System.Drawing.Point(74, 38)
        Me.CbTu_Ngay.Name = "CbTu_Ngay"
        Me.CbTu_Ngay.Size = New System.Drawing.Size(94, 24)
        Me.CbTu_Ngay.TabIndex = 1
        Me.CbTu_Ngay.Value = New Date(2008, 7, 3, 0, 0, 0, 0)
        '
        'grbDanh_Muc_Bao_Cao
        '
        Me.grbDanh_Muc_Bao_Cao.Controls.Add(Me.optBao_Cao_Tong_Hop)
        Me.grbDanh_Muc_Bao_Cao.Controls.Add(Me.optTon_Kho_Hai_Quan)
        Me.grbDanh_Muc_Bao_Cao.Controls.Add(Me.optChua_Thong_Quan)
        Me.grbDanh_Muc_Bao_Cao.Controls.Add(Me.optTy_Le_Kiem_Quan)
        Me.grbDanh_Muc_Bao_Cao.Controls.Add(Me.optTy_Le_Thong_Quan)
        Me.grbDanh_Muc_Bao_Cao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbDanh_Muc_Bao_Cao.Location = New System.Drawing.Point(8, 104)
        Me.grbDanh_Muc_Bao_Cao.Name = "grbDanh_Muc_Bao_Cao"
        Me.grbDanh_Muc_Bao_Cao.Size = New System.Drawing.Size(520, 200)
        Me.grbDanh_Muc_Bao_Cao.SupportThemes = False
        Me.grbDanh_Muc_Bao_Cao.TabIndex = 1
        Me.grbDanh_Muc_Bao_Cao.Text = "Danh mục báo cáo"
        '
        'optBao_Cao_Tong_Hop
        '
        Me.optBao_Cao_Tong_Hop.Location = New System.Drawing.Point(24, 32)
        Me.optBao_Cao_Tong_Hop.Name = "optBao_Cao_Tong_Hop"
        Me.optBao_Cao_Tong_Hop.Size = New System.Drawing.Size(448, 24)
        Me.optBao_Cao_Tong_Hop.TabIndex = 0
        Me.optBao_Cao_Tong_Hop.Text = "Tổng hợp sản lượng bưu kiện quốc tế đến"
        '
        'optTon_Kho_Hai_Quan
        '
        Me.optTon_Kho_Hai_Quan.Enabled = False
        Me.optTon_Kho_Hai_Quan.Location = New System.Drawing.Point(24, 152)
        Me.optTon_Kho_Hai_Quan.Name = "optTon_Kho_Hai_Quan"
        Me.optTon_Kho_Hai_Quan.Size = New System.Drawing.Size(344, 32)
        Me.optTon_Kho_Hai_Quan.TabIndex = 4
        Me.optTon_Kho_Hai_Quan.Text = "Lượng bưu gửi tồn trong toàn bộ Kho Hải quan"
        '
        'optChua_Thong_Quan
        '
        Me.optChua_Thong_Quan.Enabled = False
        Me.optChua_Thong_Quan.Location = New System.Drawing.Point(24, 120)
        Me.optChua_Thong_Quan.Name = "optChua_Thong_Quan"
        Me.optChua_Thong_Quan.Size = New System.Drawing.Size(416, 32)
        Me.optChua_Thong_Quan.TabIndex = 3
        Me.optChua_Thong_Quan.Text = "Lượng bưu gửi phi mậu dịch đã mở tờ khai nhưng chưa thông quan"
        '
        'optTy_Le_Kiem_Quan
        '
        Me.optTy_Le_Kiem_Quan.Enabled = False
        Me.optTy_Le_Kiem_Quan.Location = New System.Drawing.Point(24, 96)
        Me.optTy_Le_Kiem_Quan.Name = "optTy_Le_Kiem_Quan"
        Me.optTy_Le_Kiem_Quan.Size = New System.Drawing.Size(312, 24)
        Me.optTy_Le_Kiem_Quan.TabIndex = 2
        Me.optTy_Le_Kiem_Quan.Text = "Tỷ lệ kiểm quan của các bưu gửi phi mậu dịch"
        '
        'optTy_Le_Thong_Quan
        '
        Me.optTy_Le_Thong_Quan.Location = New System.Drawing.Point(24, 64)
        Me.optTy_Le_Thong_Quan.Name = "optTy_Le_Thong_Quan"
        Me.optTy_Le_Thong_Quan.Size = New System.Drawing.Size(432, 24)
        Me.optTy_Le_Thong_Quan.TabIndex = 1
        Me.optTy_Le_Thong_Quan.Text = "Tỷ lệ thông quan của các bưu kiện quốc tế đến"
        '
        'grbTuy_Chon
        '
        Me.grbTuy_Chon.Controls.Add(Me.UltraLabel5)
        Me.grbTuy_Chon.Controls.Add(Me.UltraLabel2)
        Me.grbTuy_Chon.Controls.Add(Me.UltraLabel1)
        Me.grbTuy_Chon.Controls.Add(Me.nudSau)
        Me.grbTuy_Chon.Controls.Add(Me.optSau)
        Me.grbTuy_Chon.Controls.Add(Me.nudDen)
        Me.grbTuy_Chon.Controls.Add(Me.optDen)
        Me.grbTuy_Chon.Controls.Add(Me.nudBang)
        Me.grbTuy_Chon.Controls.Add(Me.optBang)
        Me.grbTuy_Chon.Controls.Add(Me.optTat_Ca)
        Me.grbTuy_Chon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbTuy_Chon.Location = New System.Drawing.Point(8, 312)
        Me.grbTuy_Chon.Name = "grbTuy_Chon"
        Me.grbTuy_Chon.Size = New System.Drawing.Size(520, 112)
        Me.grbTuy_Chon.SupportThemes = False
        Me.grbTuy_Chon.TabIndex = 2
        Me.grbTuy_Chon.Text = "Tuỳ chọn báo cáo"
        '
        'UltraLabel5
        '
        Me.UltraLabel5.Location = New System.Drawing.Point(400, 72)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(56, 16)
        Me.UltraLabel5.TabIndex = 9
        Me.UltraLabel5.Text = "(ngày)"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Location = New System.Drawing.Point(400, 32)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(56, 16)
        Me.UltraLabel2.TabIndex = 3
        Me.UltraLabel2.Text = "(ngày)"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(160, 72)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(56, 16)
        Me.UltraLabel1.TabIndex = 6
        Me.UltraLabel1.Text = "(ngày)"
        '
        'nudSau
        '
        Me.nudSau.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSau.Location = New System.Drawing.Point(320, 72)
        Me.nudSau.Name = "nudSau"
        Me.nudSau.Size = New System.Drawing.Size(72, 22)
        Me.nudSau.TabIndex = 8
        '
        'optSau
        '
        Me.optSau.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSau.Location = New System.Drawing.Point(256, 72)
        Me.optSau.Name = "optSau"
        Me.optSau.Size = New System.Drawing.Size(56, 24)
        Me.optSau.TabIndex = 7
        Me.optSau.Text = "Sau"
        '
        'nudDen
        '
        Me.nudDen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDen.Location = New System.Drawing.Point(80, 72)
        Me.nudDen.Name = "nudDen"
        Me.nudDen.Size = New System.Drawing.Size(72, 22)
        Me.nudDen.TabIndex = 5
        '
        'optDen
        '
        Me.optDen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDen.Location = New System.Drawing.Point(24, 72)
        Me.optDen.Name = "optDen"
        Me.optDen.Size = New System.Drawing.Size(64, 24)
        Me.optDen.TabIndex = 4
        Me.optDen.Text = "Đến"
        '
        'nudBang
        '
        Me.nudBang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudBang.Location = New System.Drawing.Point(320, 32)
        Me.nudBang.Name = "nudBang"
        Me.nudBang.Size = New System.Drawing.Size(72, 22)
        Me.nudBang.TabIndex = 2
        '
        'optBang
        '
        Me.optBang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optBang.Location = New System.Drawing.Point(256, 32)
        Me.optBang.Name = "optBang"
        Me.optBang.Size = New System.Drawing.Size(56, 24)
        Me.optBang.TabIndex = 1
        Me.optBang.Text = "Bằng"
        '
        'optTat_Ca
        '
        Me.optTat_Ca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optTat_Ca.Location = New System.Drawing.Point(24, 32)
        Me.optTat_Ca.Name = "optTat_Ca"
        Me.optTat_Ca.Size = New System.Drawing.Size(120, 24)
        Me.optTat_Ca.TabIndex = 0
        Me.optTat_Ca.Text = "Không xét ngày"
        '
        'btnXem_Bao_Cao
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.btnXem_Bao_Cao.Appearance = Appearance1
        Me.btnXem_Bao_Cao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXem_Bao_Cao.ImageSize = New System.Drawing.Size(18, 18)
        Me.btnXem_Bao_Cao.Location = New System.Drawing.Point(64, 435)
        Me.btnXem_Bao_Cao.Name = "btnXem_Bao_Cao"
        Me.btnXem_Bao_Cao.Size = New System.Drawing.Size(136, 32)
        Me.btnXem_Bao_Cao.TabIndex = 3
        Me.btnXem_Bao_Cao.Text = "Báo cáo &tổng hợp"
        '
        'btnThoat
        '
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.btnThoat.Appearance = Appearance2
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.ImageSize = New System.Drawing.Size(18, 18)
        Me.btnThoat.Location = New System.Drawing.Point(360, 435)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(120, 32)
        Me.btnThoat.TabIndex = 5
        Me.btnThoat.Text = "Th&oát"
        '
        'btnChi_Tiet
        '
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        Me.btnChi_Tiet.Appearance = Appearance3
        Me.btnChi_Tiet.Enabled = False
        Me.btnChi_Tiet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChi_Tiet.ImageSize = New System.Drawing.Size(18, 18)
        Me.btnChi_Tiet.Location = New System.Drawing.Point(216, 435)
        Me.btnChi_Tiet.Name = "btnChi_Tiet"
        Me.btnChi_Tiet.Size = New System.Drawing.Size(128, 32)
        Me.btnChi_Tiet.TabIndex = 4
        Me.btnChi_Tiet.Text = "Báo cáo &chi tiết"
        '
        'Frm_Thong_Ke_Bao_Cao_Buu_Pham_Buu_Kien
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(536, 485)
        Me.Controls.Add(Me.btnChi_Tiet)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnXem_Bao_Cao)
        Me.Controls.Add(Me.grbTuy_Chon)
        Me.Controls.Add(Me.grbDanh_Muc_Bao_Cao)
        Me.Controls.Add(Me.grbThoi_Gian)
        Me.Name = "Frm_Thong_Ke_Bao_Cao_Buu_Pham_Buu_Kien"
        Me.Text = "Báo cáo quản lý dịch vụ Bưu phẩm bưu kiện gửi qua EMS"
        CType(Me.grbThoi_Gian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbThoi_Gian.ResumeLayout(False)
        CType(Me.cbMa_Nuoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbDen_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbTu_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbDanh_Muc_Bao_Cao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDanh_Muc_Bao_Cao.ResumeLayout(False)
        CType(Me.grbTuy_Chon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbTuy_Chon.ResumeLayout(False)
        CType(Me.nudSau, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Khai báo biến toàn Form"
    'Biến kết nối với CSDL
    Private myHuong_Di_Buu_Pham_Quoc_Te_Den As New Huong_Di_Buu_Pham_Quoc_Te_Den(GConnectionString)
    Private myHam_Dung_Chung As New Ham_Dung_Chung
    'Paramete Report
    Private pMenu_Trai As String
    Private pMenu_Phai As String
    Private pTen_Bao_Cao As String
    Private pTu_Ngay_Den_Ngay As String
    Private pNgay_Thang_Nam As String
    Private pTuy_Chon_Bao_Cao As String
    'Thoi gian
    Private myTu_Ngay As Integer
    Private myDen_Ngay As Integer
    Private myMa_Nuoc As String
    Private mySo_Ngay_Yeu_Cau As Integer
    'Chọn loại báo cáo và tuỳ chọn báo cáo
    Private myLoai_Bao_Cao As Integer   '1: Thong quan ; 2: Kiem quan ; 3: Chua thong quan ; 4: Ton kho
    Private myLoai_Tuy_Chon As Integer  '0: Khong xét ngày ; 1: Bằng ; 2: Đến / Sau
    'Đơn vị báo cáo     1: Hà Nội           2: Hồ Chí Minh
    Private myDon_Vi_Bao_Cao As Integer
#End Region

#Region "Tab Control"

#Region "Frm_Thong_Ke_Bao_Cao_Buu_Pham_Buu_Kien_Load"
    Private Sub Frm_Thong_Ke_Bao_Cao_Buu_Pham_Buu_Kien_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Refesh_Form_Load()
    End Sub
#End Region

#Region "btnChi_Tiet_Click"
    Private Sub btnChi_Tiet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChi_Tiet.Click
        Cursor.Current = Cursors.WaitCursor
        myTu_Ngay = myHam_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value)
        myDen_Ngay = myHam_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value)
        myMa_Nuoc = cbMa_Nuoc.Text
        If myTu_Ngay > myDen_Ngay Then
            Cursor.Current = Cursors.Default
            MessageBox.Show("Từ ngày không được phép lớn hơn đến ngày!!!" & vbNewLine & "Mời bạn nhập lại thông tin ngày khai thác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CbTu_Ngay.Select()
            Exit Sub
        End If
        'Gọi các hàm control 
        optTy_Le_Thong_Quan_CheckedChanged(optTy_Le_Thong_Quan, Nothing)
        optTat_Ca_CheckedChanged(optTat_Ca, Nothing)
        'Kiem tra nguoi dung chon chua chon
        If myLoai_Bao_Cao = 0 Or myLoai_Tuy_Chon = -1 Then
            Cursor.Current = Cursors.Default
            MessageBox.Show("Bạn chưa chọn loại báo cáo, hoặc chưa chọn thông tin tuỳ chọn in báo cáo!!!" & vbNewLine & "Mời bạn chọn lại thông tin trên thì mới xem được báo cáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        'Tạo và view báo cáo lên màn hình
        Export_Chi_Tiet_To_Excel()
        myLoai_Bao_Cao = 0
        myLoai_Tuy_Chon = -1
    End Sub
#End Region

#Region "btnThoat_Click"
    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
        Me.Dispose()
    End Sub
#End Region

#Region "btnXem_Bao_Cao_Click"
    Private Sub btnXem_Bao_Cao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXem_Bao_Cao.Click
        Cursor.Current = Cursors.WaitCursor
        myTu_Ngay = myHam_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value)
        myDen_Ngay = myHam_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value)
        myMa_Nuoc = cbMa_Nuoc.Text
        If myTu_Ngay > myDen_Ngay Then
            Cursor.Current = Cursors.Default
            MessageBox.Show("Từ ngày không được phép lớn hơn đến ngày!!!" & vbNewLine & "Mời bạn nhập lại thông tin ngày khai thác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CbTu_Ngay.Select()
            Exit Sub
        End If
        If cbMa_Nuoc.Value Is DBNull.Value Then
            Cursor.Current = Cursors.Default
            MessageBox.Show("Bạn chưa chọn thông tin mã nước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbMa_Nuoc.Select()
            Exit Sub
        End If
        'Gọi các hàm control 
        optBao_Cao_Tong_Hop_CheckedChanged(optBao_Cao_Tong_Hop, Nothing)
        optTat_Ca_CheckedChanged(optTat_Ca, Nothing)
        'Kiem tra nguoi dung chon chua chon
        If myLoai_Bao_Cao = 0 Or myLoai_Tuy_Chon = -1 Then
            Cursor.Current = Cursors.Default
            MessageBox.Show("Bạn chưa chọn loại báo cáo, hoặc chưa chọn thông tin tuỳ chọn in báo cáo!!!" & vbNewLine & "Mời bạn chọn lại thông tin trên thì mới xem được báo cáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        'Tạo và view báo cáo lên màn hình
        Print_Report()
        myLoai_Bao_Cao = 0
        myLoai_Tuy_Chon = -1
    End Sub
#End Region

#Region "optTy_Le_Thong_Quan_CheckedChanged"
    Private Sub optTy_Le_Thong_Quan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optTy_Le_Thong_Quan.CheckedChanged, optTy_Le_Kiem_Quan.CheckedChanged, optChua_Thong_Quan.CheckedChanged, optTon_Kho_Hai_Quan.CheckedChanged
        myLoai_Bao_Cao = Format_Tuy_Chon_Bao_Cao()
    End Sub
#End Region

#Region "optBao_Cao_Tong_Hop_CheckedChanged"
    Private Sub optBao_Cao_Tong_Hop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optBao_Cao_Tong_Hop.CheckedChanged
        myLoai_Bao_Cao = Format_Tuy_Chon_Bao_Cao()
    End Sub
#End Region

#Region "optTat_Ca_CheckedChanged"
    Private Sub optTat_Ca_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optTat_Ca.CheckedChanged, optBang.CheckedChanged, optDen.CheckedChanged, optSau.CheckedChanged
        Enable_Control_Tuy_Chon_Bao_Cao()
        myLoai_Tuy_Chon = Get_Tuy_Chon_Bao_Cao()
    End Sub
#End Region

#End Region

#Region "Hàm người dùng viết"

    'Ứng với mỗi mục báo cáo sẽ có tuỳ chọn tương ứng (các tuỳ chọn khác sẽ mờ đi)
    '1: Tỷ lệ thông quan
    '2: Tỷ lệ kiểm quan
    '3: Lượng bưu gửi PMD đã kiểm hoá nhưng chưa thông quan
    '4: Lượng bưu gửi tồn kho Hải quan
    '5: Báo cáo tổng hợp
#Region "Format_Tuy_Chon_Bao_Cao"
    Private Function Format_Tuy_Chon_Bao_Cao() As Integer
        'Chọn báo cáo Tỷ lệ thông quan hoặc kiểm quan
        If optTy_Le_Thong_Quan.Checked Then
            optTat_Ca.Enabled = True
            optBang.Enabled = True
            optDen.Enabled = True
            If optSau.Checked Then
                optSau.Checked = False
            End If
            optSau.Enabled = False
            optBang.Checked = True
            Return 1
        ElseIf optTy_Le_Kiem_Quan.Checked Then
            optTat_Ca.Enabled = True
            optBang.Enabled = True
            optDen.Enabled = True
            If optSau.Checked Then
                optSau.Checked = False
            End If
            optSau.Enabled = False
            Return 2
            'Chọn báo cáo bưu gửi PMD đã kiểm hoá nhưng chưa thông quan
        ElseIf optChua_Thong_Quan.Checked Then
            optTat_Ca.Enabled = True
            optSau.Enabled = True
            If optBang.Checked Then
                optBang.Checked = False
            End If
            optBang.Enabled = False
            If optDen.Checked Then
                optDen.Checked = False
            End If
            optDen.Enabled = False
            Return 3
            'Chọn báo cáo tồn kho
        ElseIf optTon_Kho_Hai_Quan.Checked Then
            If optTat_Ca.Checked = True Then
                optTat_Ca.Checked = False
            End If
            optTat_Ca.Enabled = False
            If optBang.Checked = True Then
                optBang.Checked = False
            End If
            optBang.Enabled = False
            If optDen.Checked = True Then
                optDen.Checked = False
            End If
            optDen.Enabled = False
            If optSau.Checked = True Then
                optSau.Checked = False
            End If
            optSau.Enabled = False
            Return 4
        ElseIf optBao_Cao_Tong_Hop.Checked = True Then
            If optTat_Ca.Checked = True Then
                optTat_Ca.Checked = False
            End If
            optTat_Ca.Enabled = False
            If optBang.Checked = True Then
                optBang.Checked = False
            End If
            optBang.Enabled = False
            If optDen.Checked = True Then
                optDen.Checked = False
            End If
            optDen.Enabled = False
            If optSau.Checked = True Then
                optSau.Checked = False
            End If
            optSau.Enabled = False
            Return 5
        Else
            Return 0
        End If
    End Function
#End Region

    'Xử lý khi người dùng tích chọn 1 tuỳ chọn cụ thể (các thông tin tuỳ chọn khác sẽ mờ đi)
#Region "Enable_Control_Tuy_Chon_Bao_Cao"
    Private Sub Enable_Control_Tuy_Chon_Bao_Cao()
        If optTat_Ca.Checked Then
            nudBang.Enabled = False
            nudDen.Enabled = False
            nudSau.Enabled = False
        Else
            nudBang.Enabled = optBang.Checked
            nudDen.Enabled = optDen.Checked
            nudSau.Enabled = optSau.Checked
        End If
    End Sub
#End Region

    'Lấy kiểu tuỳ chọn mà người dùng đã chọn để kết xuất báo cáo tương ứng
    '0: Khong xet ngay  ;   1: Bằng ;   2: Đến / Sau
#Region "Get_Tuy_Chon_Bao_Cao"
    Private Function Get_Tuy_Chon_Bao_Cao() As Integer
        If ((myLoai_Bao_Cao = 4) Or (myLoai_Bao_Cao = 5)) Then  'Tong kho và tổng hợp khong can tuy chon bao cao
            Return 0
        End If
        If optTat_Ca.Checked Then
            Return 0
        ElseIf optBang.Checked Then
            Return 1
        ElseIf (optDen.Checked Or optSau.Checked) Then
            Return 2
        Else
            Return -1
        End If
    End Function
#End Region

#Region "Refesh_Form_Load"
    Private Sub Refesh_Form_Load()
        Dim mMa_Nuoc As New Ma_Nuoc(GConnectionString)
        CbTu_Ngay.Value = Now.Date
        CbDen_Ngay.Value = Now.Date
        cbMa_Nuoc.DataSource = mMa_Nuoc.Danh_Sach_Rut_Gon()
        cbMa_Nuoc.DataBind()
        cbMa_Nuoc.LimitToList = True
        If cbMa_Nuoc.Rows.Count > 0 Then
            cbMa_Nuoc.Value = "US"
        End If
        'Khởi tạo giá trị để kiểm tra người dùng chưa chọn đủ thông tin về loại và tuỳ chọn báo cáo
        myLoai_Bao_Cao = 0
        myLoai_Tuy_Chon = -1
        'Gọi các hàm control 
        optBao_Cao_Tong_Hop.Checked = True
        optBao_Cao_Tong_Hop_CheckedChanged(optBao_Cao_Tong_Hop, Nothing)
        'optTy_Le_Thong_Quan.Checked = True
        'optTy_Le_Thong_Quan_CheckedChanged(optTy_Le_Thong_Quan, Nothing)
        'optBang.Checked = True
        optTat_Ca_CheckedChanged(optTat_Ca, Nothing)
    End Sub
#End Region

#Region "Print_Report"
    Private Sub Print_Report()
        'Lay gia tri cho bien So Ngay Yeu Cau
        Gan_Gia_Tri_Vao_Bien_So_Ngay_Yeu_Cau()
        'Xac dinh Don vi khai thac quoc te
        Tim_Don_Vi_In_Bao_Cao()
        'Lay thong tin cho Paramete Tuy_Chon_Bao_Cao
        Lay_Thong_Tin_Cho_Paramete_Tuy_Chon_Bao_Cao()
        'In bao cao tuong ung
        Select Case myLoai_Bao_Cao
            Case 1  'Thong quan
                Bao_Cao_Ty_Le_Thong_Quan()
            Case 2  'Kiem quan
                Bao_Cao_Ty_Le_Kiem_Quan()
            Case 3  'Chua thong quan
                Bao_Cao_San_Luong_Kiem_Hoa_Chua_Thong_Quan()
            Case 4  'Ton kho
                Bao_Cao_San_Luong_Ton_Kho_Hai_Quan()
            Case 5
                Bao_Cao_Tong_Hop_San_Luong_Buu_Kien_Quoc_Te_Den()
        End Select
    End Sub
#End Region

#Region "Export_Chi_Tiet_To_Excel"
    Private Sub Export_Chi_Tiet_To_Excel()
        Dim myDataSet As DataSet
        'Lay gia tri cho bien So Ngay Yeu Cau
        Gan_Gia_Tri_Vao_Bien_So_Ngay_Yeu_Cau()
        'Xac dinh Don vi khai thac quoc te
        'Tim_Don_Vi_In_Bao_Cao()
        'Lay thong tin cho Paramete Tuy_Chon_Bao_Cao
        'Lay_Thong_Tin_Cho_Paramete_Tuy_Chon_Bao_Cao()
        'In bao cao tuong ung
        Select Case myLoai_Bao_Cao
            Case 1  'Thong quan
                myDataSet = myHuong_Di_Buu_Pham_Quoc_Te_Den.Huong_Di_Buu_Pham_Quoc_Te_Den_Danh_Sach_Chua_Thong_Quan_Trong_Khoang_Ngay_Yeu_Cau(myLoai_Tuy_Chon, myTu_Ngay, myDen_Ngay, mySo_Ngay_Yeu_Cau)
                'Open SaveDialog
                With sFileDlg
                    '.InitialDirectory = inPathFile
                    .FileName = "Danh_Sach_Chua_Thong_Quan_Theo_Yeu_Cau"
                    .Title = "Chon ten File"
                    .DefaultExt = "*.xls"
                    .Filter = "Xls (*.xls)|*.xls"
                    .ShowDialog()
                End With

                If sFileDlg.FileName <> "" Then
                    MessageBox.Show("Xin vui lòng chờ một vài phút, chương trình sẽ thực hiện việc xuất dữ liệu yêu cầu ra file excel. Thời gian chờ kết xuất dữ liệu phụ thuộc vào số lượng bản ghi của dữ liệu yêu cầu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Export_To_Excel_From_DataSet(myDataSet, sFileDlg.FileName)
                End If

            Case 2  'Kiem quan
                myDataSet = myHuong_Di_Buu_Pham_Quoc_Te_Den.Huong_Di_Buu_Pham_Quoc_Te_Den_Danh_Sach_Mo_To_Khai_Chua_Kiem_Quan_Trong_Khoang_Ngay_Yeu_Cau(myLoai_Tuy_Chon, myTu_Ngay, myDen_Ngay, mySo_Ngay_Yeu_Cau)
                'Open SaveDialog
                With sFileDlg
                    .FileName = "Danh_Sach_Mo_To_Khai_Chua_Kiem_Quan_Theo_Yeu_Cau"
                    .Title = "Chon ten File"
                    .DefaultExt = "*.xls"
                    .Filter = "Xls (*.xls)|*.xls"
                    .ShowDialog()
                End With

                If sFileDlg.FileName <> "" Then
                    MessageBox.Show("Xin vui lòng chờ một vài phút, chương trình sẽ thực hiện việc xuất dữ liệu yêu cầu ra file excel. Thời gian chờ kết xuất dữ liệu phụ thuộc vào số lượng bản ghi của dữ liệu yêu cầu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Export_To_Excel_From_DataSet(myDataSet, sFileDlg.FileName)
                End If

                myDataSet = myHuong_Di_Buu_Pham_Quoc_Te_Den.Huong_Di_Buu_Pham_Quoc_Te_Den_Danh_Sach_Soi_May_Chua_Kiem_Quan_Trong_Khoang_Ngay_Yeu_Cau(myLoai_Tuy_Chon, myTu_Ngay, myDen_Ngay, mySo_Ngay_Yeu_Cau)
                'Open SaveDialog
                With sFileDlg
                    .FileName = "Danh_Sach_Soi_May_Chua_Kiem_Quan_Theo_Yeu_Cau"
                    .Title = "Chon ten File"
                    .DefaultExt = "*.xls"
                    .Filter = "Xls (*.xls)|*.xls"
                    .ShowDialog()
                End With

                If sFileDlg.FileName <> "" Then
                    MessageBox.Show("Xin vui lòng chờ một vài phút, chương trình sẽ thực hiện việc xuất dữ liệu yêu cầu ra file excel. Thời gian chờ kết xuất dữ liệu phụ thuộc vào số lượng bản ghi của dữ liệu yêu cầu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Export_To_Excel_From_DataSet(myDataSet, sFileDlg.FileName)
                End If

            Case 3  'Kiem Hoa nhưng chua thong quan
                myDataSet = myHuong_Di_Buu_Pham_Quoc_Te_Den.Huong_Di_Buu_Pham_Quoc_Te_Den_Danh_Sach_Mo_To_Khai_Chua_Thong_Quan_Trong_Khoang_Ngay_Yeu_Cau(myLoai_Tuy_Chon, myTu_Ngay, myDen_Ngay, mySo_Ngay_Yeu_Cau)
                'Open SaveDialog
                With sFileDlg
                    .FileName = "Danh_Sach_Da_Kiem_Quan_Chua_Thong_Quan_Theo_Yeu_Cau"
                    .Title = "Chon ten File"
                    .DefaultExt = "*.xls"
                    .Filter = "Xls (*.xls)|*.xls"
                    .ShowDialog()
                End With

                If sFileDlg.FileName <> "" Then
                    MessageBox.Show("Xin vui lòng chờ một vài phút, chương trình sẽ thực hiện việc xuất dữ liệu yêu cầu ra file excel. Thời gian chờ kết xuất dữ liệu phụ thuộc vào số lượng bản ghi của dữ liệu yêu cầu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Export_To_Excel_From_DataSet(myDataSet, sFileDlg.FileName)
                End If
            Case 4  'Ton kho
                MessageBox.Show("Chức năng xuất dữ liệu tồn kho ra file Excel chưa hoàn thiện, mời bạn quay lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Bao_Cao_San_Luong_Ton_Kho_Hai_Quan()
        End Select
    End Sub
#End Region

    'Lay gia tri cho So_Ngay_Yeu_Cau
#Region "Gan_Gia_Tri_Vao_Bien_So_Ngay_Yeu_Cau"
    Private Sub Gan_Gia_Tri_Vao_Bien_So_Ngay_Yeu_Cau()
        Select Case myLoai_Bao_Cao
            Case 1, 2   'Thong quan / Kiem quan
                Select Case myLoai_Tuy_Chon
                    Case 0  'Tat ca
                        mySo_Ngay_Yeu_Cau = 0
                    Case 1  'Bang
                        mySo_Ngay_Yeu_Cau = nudBang.Value
                    Case 2  'Den
                        mySo_Ngay_Yeu_Cau = nudDen.Value
                    Case Else
                        mySo_Ngay_Yeu_Cau = 0
                End Select
            Case 3      'Chua thong quan
                Select Case myLoai_Tuy_Chon
                    Case 0  'Tat ca
                        mySo_Ngay_Yeu_Cau = 0
                    Case 2  'Sau
                        mySo_Ngay_Yeu_Cau = nudSau.Value
                    Case Else
                        mySo_Ngay_Yeu_Cau = 0
                End Select
            Case 4, 5      'Ton kho hoặc tổng hợp
                mySo_Ngay_Yeu_Cau = 0
        End Select
    End Sub
#End Region

    'Tiêu đề báo cáo theo từng đơn vị khai thác QT
#Region "Tim_Don_Vi_In_Bao_Cao"
    Private Sub Tim_Don_Vi_In_Bao_Cao()
        Dim mDanh_Muc_Bc As New Danh_Muc_BC(GConnectionString)
        Dim mDanh_Muc_Bc_Chi_Tiet As New Danh_Muc_BC_Chi_Tiet
        mDanh_Muc_Bc_Chi_Tiet = mDanh_Muc_Bc.Lay(GBuu_Cuc_Khai_Thac)
        If mDanh_Muc_Bc_Chi_Tiet.Ma_Tinh = 100000 Then  'Ha noi
            myDon_Vi_Bao_Cao = 1
        ElseIf mDanh_Muc_Bc_Chi_Tiet.Ma_Tinh = 700000 Then      'HCM
            myDon_Vi_Bao_Cao = 2
        Else        '
            myDon_Vi_Bao_Cao = 3
        End If
    End Sub
#End Region

    'Mục tuỳ chọn báo cáo thể hiện trên báo cáo
#Region "Lay_Thong_Tin_Cho_Paramete_Tuy_Chon_Bao_Cao"
    Private Sub Lay_Thong_Tin_Cho_Paramete_Tuy_Chon_Bao_Cao()
        Select Case myLoai_Bao_Cao
            Case 1      'Thong quan
                Select Case myLoai_Tuy_Chon
                    Case 0      'tất cả
                        'pTuy_Chon_Bao_Cao = ""
                        pTuy_Chon_Bao_Cao = "Nước đến: " + cbMa_Nuoc.Text
                    Case 1      'bằng
                        pTuy_Chon_Bao_Cao = "Nước đến: " + cbMa_Nuoc.Text
                        If mySo_Ngay_Yeu_Cau = 0 Then   'Trong ngày
                            pTuy_Chon_Bao_Cao = pTuy_Chon_Bao_Cao & vbNewLine & "Chỉ tính những bưu phẩm thông quan trong ngày"
                        Else
                            pTuy_Chon_Bao_Cao = pTuy_Chon_Bao_Cao & vbNewLine & "Chỉ tính những bưu phẩm thông quan đúng :  " & mySo_Ngay_Yeu_Cau.ToString & "  ngày, so với ngày xác nhận bưu phẩm quốc tế đến"
                        End If
                    Case 2      'đến
                        pTuy_Chon_Bao_Cao = "Nước đến: " + cbMa_Nuoc.Text
                        If mySo_Ngay_Yeu_Cau = 0 Then   'Trong ngày
                            pTuy_Chon_Bao_Cao = pTuy_Chon_Bao_Cao & vbNewLine & "Chỉ tính những bưu phẩm thông quan trong ngày"
                        Else
                            pTuy_Chon_Bao_Cao = pTuy_Chon_Bao_Cao & vbNewLine & "Chỉ tính những bưu phẩm thông quan đến :  " & mySo_Ngay_Yeu_Cau.ToString & "  ngày, so với ngày xác nhận bưu phẩm quốc tế đến"
                        End If
                End Select
            Case 2      'Kiem quan
                Select Case myLoai_Tuy_Chon
                    Case 0      'tất cả
                        'pTuy_Chon_Bao_Cao = ""
                        pTuy_Chon_Bao_Cao = "Nước đến: " + cbMa_Nuoc.Text
                    Case 1      'bằng
                        pTuy_Chon_Bao_Cao = "Nước đến: " + cbMa_Nuoc.Text
                        If mySo_Ngay_Yeu_Cau = 0 Then   'Trong ngày
                            pTuy_Chon_Bao_Cao = "Chỉ tính những bưu phẩm kiểm quan trong ngày"
                        Else
                            pTuy_Chon_Bao_Cao = "Chỉ tính những bưu phẩm kiểm quan đúng :  " & mySo_Ngay_Yeu_Cau.ToString & "  ngày, so với ngày xác nhận bưu phẩm quốc tế đến"
                        End If
                    Case 2      'đến
                        If mySo_Ngay_Yeu_Cau = 0 Then   'Trong ngày
                            pTuy_Chon_Bao_Cao = pTuy_Chon_Bao_Cao & vbNewLine & "Chỉ tính những bưu phẩm kiểm quan trong ngày"
                        Else
                            pTuy_Chon_Bao_Cao = pTuy_Chon_Bao_Cao & vbNewLine & "Chỉ tính những bưu phẩm kiểm quan đến :  " & mySo_Ngay_Yeu_Cau.ToString & "  ngày, so với ngày xác nhận bưu phẩm quốc tế đến"
                        End If
                End Select
            Case 3      'Chua thong quan
                Select Case myLoai_Tuy_Chon
                    Case 0      'đến thời điểm in báo cáo
                        pTuy_Chon_Bao_Cao = "Nước đến: " + cbMa_Nuoc.Text
                        pTuy_Chon_Bao_Cao = pTuy_Chon_Bao_Cao & vbNewLine & "Tính tất cả các bưu phẩm đã kiểm hoá nhưng chưa thông quan cho đến thời điểm in báo cáo"
                    Case 2      'sau
                        pTuy_Chon_Bao_Cao = "Nước đến: " + cbMa_Nuoc.Text
                        If mySo_Ngay_Yeu_Cau = 0 Then   'Trong ngày
                            pTuy_Chon_Bao_Cao = pTuy_Chon_Bao_Cao & vbNewLine & "Chỉ tính những bưu phẩm đã kiếm hoá nhưng chưa thông quan trong ngày"
                        Else
                            pTuy_Chon_Bao_Cao = pTuy_Chon_Bao_Cao & vbNewLine & "Chỉ tính những bưu phẩm đã kiếm hoá nhưng chưa thông quan sau:  " & mySo_Ngay_Yeu_Cau.ToString & "  ngày, so với ngày kiểm hoá"
                        End If
                End Select
            Case 4     'Ton kho 
                'pTuy_Chon_Bao_Cao = ""
                pTuy_Chon_Bao_Cao = "Nước đến: " + cbMa_Nuoc.Text
            Case 5    'báo cáo tổng hợp
                pTuy_Chon_Bao_Cao = "Nước đến: " + cbMa_Nuoc.Text
        End Select
    End Sub
#End Region

#Region "============== Danh mục báo cáo ============"

#Region "Bao_Cao_Ty_Le_Thong_Quan"
    Private Sub Bao_Cao_Ty_Le_Thong_Quan()
        Dim FrmView As New FrmViewReports
        Dim rptView As New Rpt_Bao_Cao_Buu_Pham_Buu_Kien_Ty_Le_Thong_Quan
        Dim myDataSet As New DataSet
        Dim myTable As New DataTable

        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue

        'Lay du lieu
        myTable = myHuong_Di_Buu_Pham_Quoc_Te_Den.Huong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ty_Le_Thong_Quan_Buu_Pham_Buu_Kien(myLoai_Tuy_Chon, myTu_Ngay, myDen_Ngay, mySo_Ngay_Yeu_Cau, myMa_Nuoc).Tables(0)
        If myTable.Rows.Count = 0 Then
            Cursor.Current = Cursors.Default
            MessageBox.Show("Không có dữ liệu theo yêu cầu báo cáo. Mời bạn kiểm tra lại thông tin về thời gian", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        myTable.TableName = "Buu_Pham_Buu_Kien_Bao_Cao_Thong_Quan"
        myDataSet.Tables.Add(myTable.Copy)

        'Lay gia tri cho paramete
        If myDon_Vi_Bao_Cao = 1 Then        'ha noi
            pMenu_Trai = "CTY CPCPN BƯU ĐIỆN" & vbNewLine & "TRUNG TÂM KHAI THÁC QT HÀ NỘI"
        ElseIf myDon_Vi_Bao_Cao = 2 Then    'hcm
            pMenu_Trai = "CN CTY CPCPN BƯU ĐIỆN" & vbNewLine & "TRUNG TÂM KHAI THÁC QT TPHCM"
        Else    'khac
            pMenu_Trai = ""
        End If

        pMenu_Phai = "MẪU BKQT 02"

        pTen_Bao_Cao = "TỔNG HỢP SẢN LƯỢNG THÔNG QUAN CỦA CÁC BƯU GỬI QUỐC TẾ ĐẾN"

        pTu_Ngay_Den_Ngay = "Thời gian khai thác:  từ ngày " & DateTime.Parse(CbTu_Ngay.Value).ToString("dd/MM/yyyy") & " đến ngày " & DateTime.Parse(CbDen_Ngay.Value).ToString("dd/MM/yyyy")

        If myDon_Vi_Bao_Cao = 1 Then        'ha noi
            pNgay_Thang_Nam = "Hà nội, ngày " & Now.Day.ToString("00") & " tháng " & Now.Month.ToString("00") & " năm " & Now.Year.ToString("00")
        ElseIf myDon_Vi_Bao_Cao = 2 Then    'hcm
            pNgay_Thang_Nam = "TPHCM, ngày " & Now.Day.ToString("00") & " tháng " & Now.Month.ToString("00") & " năm " & Now.Year.ToString("00")
        Else    'khac
            pNgay_Thang_Nam = ""
        End If

        'Add Paramete into report
        pvCollection.Clear()
        _pThamSo.Value = pMenu_Trai
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pMenu_Trai").ApplyCurrentValues(pvCollection)

        pvCollection.Clear()
        _pThamSo.Value = pMenu_Phai
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pMenu_Phai").ApplyCurrentValues(pvCollection)

        pvCollection.Clear()
        _pThamSo.Value = pTen_Bao_Cao
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pTen_Bao_Cao").ApplyCurrentValues(pvCollection)

        pvCollection.Clear()
        _pThamSo.Value = pTu_Ngay_Den_Ngay
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pTu_Ngay_Den_Ngay").ApplyCurrentValues(pvCollection)

        pvCollection.Clear()
        _pThamSo.Value = pTuy_Chon_Bao_Cao
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pTuy_Chon_Bao_Cao").ApplyCurrentValues(pvCollection)

        pvCollection.Clear()
        _pThamSo.Value = pNgay_Thang_Nam
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pNgay_Thang_Nam").ApplyCurrentValues(pvCollection)

        rptView.SetDataSource(myDataSet)
        FrmView.CrystalReportViewer1.ReportSource = rptView
        Cursor.Current = Cursors.Default
        FrmView.ShowDialog()
    End Sub
#End Region

#Region "Bao_Cao_Ty_Le_Kiem_Quan"
    Private Sub Bao_Cao_Ty_Le_Kiem_Quan()
        Dim FrmView As New FrmViewReports
        Dim rptView As New Rpt_Bao_Cao_Ty_Le_Kiem_Quan_Phi_Mau_Dich
        Dim myDataSet As New DataSet
        Dim myTable As New DataTable

        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue

        'Lay du lieu
        myTable = myHuong_Di_Buu_Pham_Quoc_Te_Den.Huong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ty_Le_Kiem_Quan_Hang_Phi_MD(myLoai_Tuy_Chon, myTu_Ngay, myDen_Ngay, mySo_Ngay_Yeu_Cau).Tables(0)
        If myTable.Rows.Count = 0 Then
            Cursor.Current = Cursors.Default
            MessageBox.Show("Không có dữ liệu theo yêu cầu báo cáo. Mời bạn kiểm tra lại thông tin về thời gian", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        myTable.TableName = "Huong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ty_Le_Kiem_Quan_Hang_Phi_MD"
        myDataSet.Tables.Add(myTable.Copy)

        'Lay gia tri cho paramete
        If myDon_Vi_Bao_Cao = 1 Then        'ha noi
            pMenu_Trai = "CTY CPCPN BƯU ĐIỆN" & vbNewLine & "TRUNG TÂM KHAI THÁC QT HÀ NỘI"
        ElseIf myDon_Vi_Bao_Cao = 2 Then    'hcm
            pMenu_Trai = "CN CTY CPCPN BƯU ĐIỆN" & vbNewLine & "TRUNG TÂM KHAI THÁC QT TPHCM"
        Else    'khac
            pMenu_Trai = ""
        End If

        pMenu_Phai = "MẪU BKQT 03"

        pTen_Bao_Cao = "TỔNG HỢP SẢN LƯỢNG KIỂM QUAN CỦA CÁC BƯU GỬI KIỂM HOÁ PHI MẬU DỊCH"

        pTu_Ngay_Den_Ngay = "Thời gian khai thác:  từ ngày " & DateTime.Parse(CbTu_Ngay.Value).ToString("dd/MM/yyyy") & " đến ngày " & DateTime.Parse(CbDen_Ngay.Value).ToString("dd/MM/yyyy")

        If myDon_Vi_Bao_Cao = 1 Then        'ha noi
            pNgay_Thang_Nam = "Hà nội, ngày " & Now.Day.ToString("00") & " tháng " & Now.Month.ToString("00") & " năm " & Now.Year.ToString("00")
        ElseIf myDon_Vi_Bao_Cao = 2 Then    'hcm
            pNgay_Thang_Nam = "TPHCM, ngày " & Now.Day.ToString("00") & " tháng " & Now.Month.ToString("00") & " năm " & Now.Year.ToString("00")
        Else    'khac
            pNgay_Thang_Nam = ""
        End If

        'Add Paramete into report
        pvCollection.Clear()
        _pThamSo.Value = pMenu_Trai
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pMenu_Trai").ApplyCurrentValues(pvCollection)

        pvCollection.Clear()
        _pThamSo.Value = pMenu_Phai
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pMenu_Phai").ApplyCurrentValues(pvCollection)

        pvCollection.Clear()
        _pThamSo.Value = pTen_Bao_Cao
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pTen_Bao_Cao").ApplyCurrentValues(pvCollection)

        pvCollection.Clear()
        _pThamSo.Value = pTu_Ngay_Den_Ngay
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pTu_Ngay_Den_Ngay").ApplyCurrentValues(pvCollection)

        pvCollection.Clear()
        _pThamSo.Value = pTuy_Chon_Bao_Cao
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pTuy_Chon_Bao_Cao").ApplyCurrentValues(pvCollection)

        pvCollection.Clear()
        _pThamSo.Value = pNgay_Thang_Nam
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pNgay_Thang_Nam").ApplyCurrentValues(pvCollection)

        rptView.SetDataSource(myDataSet)
        FrmView.CrystalReportViewer1.ReportSource = rptView
        Cursor.Current = Cursors.Default
        FrmView.ShowDialog()
    End Sub
#End Region

#Region "Bao_Cao_San_Luong_Kiem_Hoa_Chua_Thong_Quan"
    Private Sub Bao_Cao_San_Luong_Kiem_Hoa_Chua_Thong_Quan()
        Dim FrmView As New FrmViewReports
        Dim rptView As New Rpt_Bao_Cao_San_Luong_Kiem_Hoa_Chua_Thong_Quan
        Dim myDataSet As New DataSet
        Dim myTable As New DataTable

        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue

        'Lay du lieu
        myTable = myHuong_Di_Buu_Pham_Quoc_Te_Den.Huong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ty_Le_Mo_To_Khai_Chua_Thong_Quan(myLoai_Tuy_Chon, myTu_Ngay, myDen_Ngay, mySo_Ngay_Yeu_Cau).Tables(0)
        If myTable.Rows.Count = 0 Then
            Cursor.Current = Cursors.Default
            MessageBox.Show("Không có dữ liệu theo yêu cầu báo cáo. Mời bạn kiểm tra lại thông tin về thời gian", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        myTable.TableName = "Huong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ty_Le_Mo_To_Khai_Chua_Thong_Quan"
        myDataSet.Tables.Add(myTable.Copy)

        'Lay gia tri cho paramete
        If myDon_Vi_Bao_Cao = 1 Then        'ha noi
            pMenu_Trai = "CTY CPCPN BƯU ĐIỆN" & vbNewLine & "TRUNG TÂM KHAI THÁC QT HÀ NỘI"
        ElseIf myDon_Vi_Bao_Cao = 2 Then    'hcm
            pMenu_Trai = "CN CTY CPCPN BƯU ĐIỆN" & vbNewLine & "TRUNG TÂM KHAI THÁC QT TPHCM"
        Else    'khac
            pMenu_Trai = ""
        End If

        pMenu_Phai = "MẪU BKQT 04"

        pTen_Bao_Cao = "SẢN LƯỢNG BƯU GỬI PHI MẬU DỊCH ĐÃ MỞ TỜ KHAI NHƯNG CHƯA THÔNG QUAN"

        pTu_Ngay_Den_Ngay = "Thời gian khai thác:  từ ngày " & DateTime.Parse(CbTu_Ngay.Value).ToString("dd/MM/yyyy") & " đến ngày " & DateTime.Parse(CbDen_Ngay.Value).ToString("dd/MM/yyyy")

        If myDon_Vi_Bao_Cao = 1 Then        'ha noi
            pNgay_Thang_Nam = "Hà nội, ngày " & Now.Day.ToString("00") & " tháng " & Now.Month.ToString("00") & " năm " & Now.Year.ToString("00")
        ElseIf myDon_Vi_Bao_Cao = 2 Then    'hcm
            pNgay_Thang_Nam = "TPHCM, ngày " & Now.Day.ToString("00") & " tháng " & Now.Month.ToString("00") & " năm " & Now.Year.ToString("00")
        Else    'khac
            pNgay_Thang_Nam = ""
        End If

        'Add Paramete into report
        pvCollection.Clear()
        _pThamSo.Value = pMenu_Trai
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pMenu_Trai").ApplyCurrentValues(pvCollection)

        pvCollection.Clear()
        _pThamSo.Value = pMenu_Phai
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pMenu_Phai").ApplyCurrentValues(pvCollection)

        pvCollection.Clear()
        _pThamSo.Value = pTen_Bao_Cao
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pTen_Bao_Cao").ApplyCurrentValues(pvCollection)

        pvCollection.Clear()
        _pThamSo.Value = pTu_Ngay_Den_Ngay
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pTu_Ngay_Den_Ngay").ApplyCurrentValues(pvCollection)

        pvCollection.Clear()
        _pThamSo.Value = pTuy_Chon_Bao_Cao
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pTuy_Chon_Bao_Cao").ApplyCurrentValues(pvCollection)

        pvCollection.Clear()
        _pThamSo.Value = pNgay_Thang_Nam
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pNgay_Thang_Nam").ApplyCurrentValues(pvCollection)

        rptView.SetDataSource(myDataSet)
        FrmView.CrystalReportViewer1.ReportSource = rptView
        Cursor.Current = Cursors.Default
        FrmView.ShowDialog()
    End Sub
#End Region

#Region "Bao_Cao_San_Luong_Ton_Kho_Hai_Quan"
    Private Sub Bao_Cao_San_Luong_Ton_Kho_Hai_Quan()
        Dim FrmView As New FrmViewReports
        Dim rptView As New Rpt_Bao_Cao_Ton_Kho_Hai_Quan
        Dim myHuong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ton_Kho_Chi_Tiet As New Huong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ton_Kho_Chi_Tiet
        Dim myDataSet As New DataSet
        Dim myTable As New DataTable

        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue

        'Lay du lieu
        myHuong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ton_Kho_Chi_Tiet = myHuong_Di_Buu_Pham_Quoc_Te_Den.Huong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Tong_Hop_Ton_Toan_Bo_Kho_HQ(myTu_Ngay, myDen_Ngay)

        'Tao ra cac cot cua bang nay
        Dim colWork As DataColumn = New DataColumn("M_Phan_Loai", GetType(String))
        myTable.Columns.Add(colWork)
        colWork = New DataColumn("D_Phan_Loai", GetType(String))
        myTable.Columns.Add(colWork)

        colWork = New DataColumn("M_Ton_Dau_Ky", GetType(Int32))
        myTable.Columns.Add(colWork)
        colWork = New DataColumn("D_Ton_Dau_Ky", GetType(Int32))
        myTable.Columns.Add(colWork)

        colWork = New DataColumn("M_Tong_So_Den", GetType(Int32))
        myTable.Columns.Add(colWork)
        colWork = New DataColumn("D_Tong_So_Den", GetType(Int32))
        myTable.Columns.Add(colWork)

        colWork = New DataColumn("M_Tong_So_Di", GetType(Int32))
        myTable.Columns.Add(colWork)
        colWork = New DataColumn("D_Tong_So_Di", GetType(Int32))
        myTable.Columns.Add(colWork)

        colWork = New DataColumn("M_Ton_Cuoi_Ky", GetType(Int32))
        myTable.Columns.Add(colWork)
        colWork = New DataColumn("D_Ton_Cuoi_Ky", GetType(Int32))
        myTable.Columns.Add(colWork)


        'Them du lieu vao
        Dim row As DataRow = myTable.NewRow()
        row("M_Phan_Loai") = myHuong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ton_Kho_Chi_Tiet.M_Phan_Loai
        row("D_Phan_Loai") = myHuong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ton_Kho_Chi_Tiet.D_Phan_Loai
        row("M_Ton_Dau_Ky") = myHuong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ton_Kho_Chi_Tiet.M_Ton_Dau_Ky
        row("D_Ton_Dau_Ky") = myHuong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ton_Kho_Chi_Tiet.D_Ton_Dau_Ky
        row("M_Tong_So_Den") = myHuong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ton_Kho_Chi_Tiet.M_Tong_So_Den
        row("D_Tong_So_Den") = myHuong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ton_Kho_Chi_Tiet.D_Tong_So_Den
        row("M_Tong_So_Di") = myHuong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ton_Kho_Chi_Tiet.M_Tong_So_Di
        row("D_Tong_So_Di") = myHuong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ton_Kho_Chi_Tiet.D_Tong_So_Di
        row("M_Ton_Cuoi_Ky") = myHuong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ton_Kho_Chi_Tiet.M_Ton_Cuoi_Ky
        row("D_Ton_Cuoi_Ky") = myHuong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ton_Kho_Chi_Tiet.D_Ton_Cuoi_Ky

        myTable.Rows.Add(row)

        myTable.TableName = "Huong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Tong_Hop_Ton_Toan_Bo_Kho_HQ"
        myDataSet.Tables.Add(myTable.Copy)

        'Lay gia tri cho paramete
        If myDon_Vi_Bao_Cao = 1 Then        'ha noi
            pMenu_Trai = "CTY CPCPN BƯU ĐIỆN" & vbNewLine & "TRUNG TÂM KHAI THÁC QT HÀ NỘI"
        ElseIf myDon_Vi_Bao_Cao = 2 Then    'hcm
            pMenu_Trai = "CN CTY CPCPN BƯU ĐIỆN" & vbNewLine & "TRUNG TÂM KHAI THÁC QT TPHCM"
        Else    'khac
            pMenu_Trai = ""
        End If

        pMenu_Phai = "MẪU BKQT 05"

        pTen_Bao_Cao = "BẢNG TỔNG HỢP TỒN KHO HẢI QUAN"

        pTu_Ngay_Den_Ngay = "Kỳ:  từ ngày " & DateTime.Parse(CbTu_Ngay.Value).ToString("dd/MM/yyyy") & " đến ngày " & DateTime.Parse(CbDen_Ngay.Value).ToString("dd/MM/yyyy")

        If myDon_Vi_Bao_Cao = 1 Then        'ha noi
            pNgay_Thang_Nam = "Hà nội, ngày " & Now.Day.ToString("00") & " tháng " & Now.Month.ToString("00") & " năm " & Now.Year.ToString("00")
        ElseIf myDon_Vi_Bao_Cao = 2 Then    'hcm
            pNgay_Thang_Nam = "TPHCM, ngày " & Now.Day.ToString("00") & " tháng " & Now.Month.ToString("00") & " năm " & Now.Year.ToString("00")
        Else    'khac
            pNgay_Thang_Nam = ""
        End If

        'Add Paramete into report
        pvCollection.Clear()
        _pThamSo.Value = pMenu_Trai
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pMenu_Trai").ApplyCurrentValues(pvCollection)

        pvCollection.Clear()
        _pThamSo.Value = pMenu_Phai
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pMenu_Phai").ApplyCurrentValues(pvCollection)

        pvCollection.Clear()
        _pThamSo.Value = pTen_Bao_Cao
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pTen_Bao_Cao").ApplyCurrentValues(pvCollection)

        pvCollection.Clear()
        _pThamSo.Value = pTu_Ngay_Den_Ngay
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pTu_Ngay_Den_Ngay").ApplyCurrentValues(pvCollection)

        pvCollection.Clear()
        _pThamSo.Value = pTuy_Chon_Bao_Cao
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pTuy_Chon_Bao_Cao").ApplyCurrentValues(pvCollection)

        pvCollection.Clear()
        _pThamSo.Value = pNgay_Thang_Nam
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pNgay_Thang_Nam").ApplyCurrentValues(pvCollection)

        rptView.SetDataSource(myDataSet)
        FrmView.CrystalReportViewer1.ReportSource = rptView
        Cursor.Current = Cursors.Default
        FrmView.ShowDialog()
    End Sub
#End Region

#Region "Bao_Cao_Tong_Hop_San_Luong_Buu_Kien_Quoc_Te_Den"
    Private Sub Bao_Cao_Tong_Hop_San_Luong_Buu_Kien_Quoc_Te_Den()
        Dim FrmView As New FrmViewReports
        Dim rptView As New Rpt_Bao_Cao_Tong_Hop_San_Luong_Buu_Kien_Quoc_Te_Den
        Dim myE1_Den As New E1_Den(GConnectionString)
        Dim myDataSet As New DataSet
        Dim myTable As New DataTable

        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue

        'Lay du lieu
        myTable = myE1_Den.E1_Den_Bao_Cao_Buu_Pham_Buu_Kien_Tu_Ngay_Den_Ngay(myTu_Ngay, myDen_Ngay, myMa_Nuoc, GBuu_Cuc_Khai_Thac).Tables(0)

        myTable.TableName = "Buu_Pham_Buu_Kien_Bao_Cao_Tong_Hop"
        myDataSet.Tables.Add(myTable.Copy)

        'Lay gia tri cho paramete
        If myDon_Vi_Bao_Cao = 1 Then        'ha noi
            pMenu_Trai = "CTY CPCPN BƯU ĐIỆN" & vbNewLine & "TRUNG TÂM KHAI THÁC QT HÀ NỘI"
        ElseIf myDon_Vi_Bao_Cao = 2 Then    'hcm
            pMenu_Trai = "CN CTY CPCPN BƯU ĐIỆN" & vbNewLine & "TRUNG TÂM KHAI THÁC QT TPHCM"
        Else    'khac
            pMenu_Trai = ""
        End If

        pMenu_Phai = "MẪU BKQT 01"

        pTen_Bao_Cao = "BẢNG TỔNG HỢP SẢN LƯỢNG BƯU KIỆN QUỐC TẾ ĐẾN"

        pTu_Ngay_Den_Ngay = "Kỳ:  từ ngày " & DateTime.Parse(CbTu_Ngay.Value).ToString("dd/MM/yyyy") & " đến ngày " & DateTime.Parse(CbDen_Ngay.Value).ToString("dd/MM/yyyy")

        If myDon_Vi_Bao_Cao = 1 Then        'ha noi
            pNgay_Thang_Nam = "Hà nội, ngày " & Now.Day.ToString("00") & " tháng " & Now.Month.ToString("00") & " năm " & Now.Year.ToString("00")
        ElseIf myDon_Vi_Bao_Cao = 2 Then    'hcm
            pNgay_Thang_Nam = "TPHCM, ngày " & Now.Day.ToString("00") & " tháng " & Now.Month.ToString("00") & " năm " & Now.Year.ToString("00")
        Else    'khac
            pNgay_Thang_Nam = ""
        End If

        'Add Paramete into report
        pvCollection.Clear()
        _pThamSo.Value = pMenu_Trai
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pMenu_Trai").ApplyCurrentValues(pvCollection)

        pvCollection.Clear()
        _pThamSo.Value = pMenu_Phai
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pMenu_Phai").ApplyCurrentValues(pvCollection)

        pvCollection.Clear()
        _pThamSo.Value = pTen_Bao_Cao
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pTen_Bao_Cao").ApplyCurrentValues(pvCollection)

        pvCollection.Clear()
        _pThamSo.Value = pTu_Ngay_Den_Ngay
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pTu_Ngay_Den_Ngay").ApplyCurrentValues(pvCollection)

        pvCollection.Clear()
        _pThamSo.Value = pTuy_Chon_Bao_Cao
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pTuy_Chon_Bao_Cao").ApplyCurrentValues(pvCollection)

        pvCollection.Clear()
        _pThamSo.Value = pNgay_Thang_Nam
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pNgay_Thang_Nam").ApplyCurrentValues(pvCollection)

        rptView.SetDataSource(myDataSet)
        FrmView.CrystalReportViewer1.ReportSource = rptView
        Cursor.Current = Cursors.Default
        FrmView.ShowDialog()
    End Sub
#End Region

#End Region


#End Region

End Class

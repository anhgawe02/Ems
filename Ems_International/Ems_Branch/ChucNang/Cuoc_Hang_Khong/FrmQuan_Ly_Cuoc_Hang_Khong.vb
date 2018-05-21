Imports System
Imports ADODB
Imports System.IO
Imports System.Windows.Forms
Imports System.Data.OleDb
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Ems_International_Logic.EMS
Imports System.Math
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource

Public Class FrmQuan_Ly_Cuoc_Hang_Khong
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
    Friend WithEvents PrbAccounting As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    Friend WithEvents lbEMS As System.Windows.Forms.Label
    Friend WithEvents btnTao_Du_Lieu As System.Windows.Forms.Button
    Friend WithEvents BtnThoat As System.Windows.Forms.Button
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents optTong_Hop As System.Windows.Forms.RadioButton
    Friend WithEvents optChi_Tiet As System.Windows.Forms.RadioButton
    Friend WithEvents chkNoi_Dia As System.Windows.Forms.CheckBox
    Friend WithEvents chkQuoc_Te As System.Windows.Forms.CheckBox
    Friend WithEvents btnKhoa As System.Windows.Forms.Button
    Friend WithEvents btnMo_Khoa As System.Windows.Forms.Button
    Friend WithEvents cbHang_Van_Chuyen As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents btnXuat_Excel As System.Windows.Forms.Button
    Friend WithEvents optTat_Ca As System.Windows.Forms.RadioButton
    Friend WithEvents optTheo_HVC As System.Windows.Forms.RadioButton
    Friend WithEvents btnNhap_Bang_Cuoc As System.Windows.Forms.Button
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents sFileDlg As System.Windows.Forms.SaveFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmQuan_Ly_Cuoc_Hang_Khong))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Hang_Van_Chuyen", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HVC")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_HVC")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ghi_Chu")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.CbTu_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.CbDen_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.PrbAccounting = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar
        Me.lbEMS = New System.Windows.Forms.Label
        Me.btnTao_Du_Lieu = New System.Windows.Forms.Button
        Me.BtnThoat = New System.Windows.Forms.Button
        Me.btnPreview = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.optTong_Hop = New System.Windows.Forms.RadioButton
        Me.optChi_Tiet = New System.Windows.Forms.RadioButton
        Me.chkNoi_Dia = New System.Windows.Forms.CheckBox
        Me.chkQuoc_Te = New System.Windows.Forms.CheckBox
        Me.btnKhoa = New System.Windows.Forms.Button
        Me.btnMo_Khoa = New System.Windows.Forms.Button
        Me.cbHang_Van_Chuyen = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.btnXuat_Excel = New System.Windows.Forms.Button
        Me.optTat_Ca = New System.Windows.Forms.RadioButton
        Me.optTheo_HVC = New System.Windows.Forms.RadioButton
        Me.btnNhap_Bang_Cuoc = New System.Windows.Forms.Button
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox
        Me.sFileDlg = New System.Windows.Forms.SaveFileDialog
        CType(Me.CbTu_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbDen_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbHang_Van_Chuyen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CbTu_Ngay
        '
        Me.CbTu_Ngay.DateTime = New Date(2008, 7, 3, 0, 0, 0, 0)
        Me.CbTu_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.CbTu_Ngay.Location = New System.Drawing.Point(120, 29)
        Me.CbTu_Ngay.MaskInput = "dd/mm/yyyy"
        Me.CbTu_Ngay.Name = "CbTu_Ngay"
        Me.CbTu_Ngay.Size = New System.Drawing.Size(96, 21)
        Me.CbTu_Ngay.TabIndex = 1
        Me.CbTu_Ngay.Value = New Date(2008, 7, 3, 0, 0, 0, 0)
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(56, 31)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(56, 16)
        Me.UltraLabel4.TabIndex = 0
        Me.UltraLabel4.Text = "Từ ngày"
        '
        'CbDen_Ngay
        '
        Me.CbDen_Ngay.DateTime = New Date(2009, 6, 23, 0, 0, 0, 0)
        Me.CbDen_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.CbDen_Ngay.Location = New System.Drawing.Point(336, 29)
        Me.CbDen_Ngay.MaskInput = "dd/mm/yyyy"
        Me.CbDen_Ngay.Name = "CbDen_Ngay"
        Me.CbDen_Ngay.Size = New System.Drawing.Size(96, 21)
        Me.CbDen_Ngay.TabIndex = 3
        Me.CbDen_Ngay.Value = New Date(2009, 6, 23, 0, 0, 0, 0)
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(264, 31)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel3.TabIndex = 2
        Me.UltraLabel3.Text = "Ðến ngày"
        '
        'PrbAccounting
        '
        Me.PrbAccounting.BorderStyle = Infragistics.Win.UIElementBorderStyle.InsetSoft
        Me.PrbAccounting.Location = New System.Drawing.Point(16, 144)
        Me.PrbAccounting.Maximum = 10000
        Me.PrbAccounting.Name = "PrbAccounting"
        Me.PrbAccounting.Size = New System.Drawing.Size(464, 27)
        Me.PrbAccounting.Step = 1
        Me.PrbAccounting.TabIndex = 9
        Me.PrbAccounting.Text = "[Formatted]"
        '
        'lbEMS
        '
        Me.lbEMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEMS.Location = New System.Drawing.Point(16, 120)
        Me.lbEMS.Name = "lbEMS"
        Me.lbEMS.Size = New System.Drawing.Size(392, 16)
        Me.lbEMS.TabIndex = 8
        Me.lbEMS.Text = "Tiến trình thực hiện"
        '
        'btnTao_Du_Lieu
        '
        Me.btnTao_Du_Lieu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTao_Du_Lieu.Image = CType(resources.GetObject("btnTao_Du_Lieu.Image"), System.Drawing.Image)
        Me.btnTao_Du_Lieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTao_Du_Lieu.Location = New System.Drawing.Point(16, 72)
        Me.btnTao_Du_Lieu.Name = "btnTao_Du_Lieu"
        Me.btnTao_Du_Lieu.Size = New System.Drawing.Size(104, 32)
        Me.btnTao_Du_Lieu.TabIndex = 4
        Me.btnTao_Du_Lieu.Text = "&Tạo dữ liệu"
        '
        'BtnThoat
        '
        Me.BtnThoat.Image = CType(resources.GetObject("BtnThoat.Image"), System.Drawing.Image)
        Me.BtnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnThoat.Location = New System.Drawing.Point(376, 336)
        Me.BtnThoat.Name = "BtnThoat"
        Me.BtnThoat.Size = New System.Drawing.Size(104, 32)
        Me.BtnThoat.TabIndex = 15
        Me.BtnThoat.Text = "&Close"
        '
        'btnPreview
        '
        Me.btnPreview.Image = CType(resources.GetObject("btnPreview.Image"), System.Drawing.Image)
        Me.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPreview.Location = New System.Drawing.Point(16, 336)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(104, 32)
        Me.btnPreview.TabIndex = 12
        Me.btnPreview.Text = "Prei&vew"
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(136, 336)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(104, 32)
        Me.btnPrint.TabIndex = 13
        Me.btnPrint.Text = "&Print"
        '
        'optTong_Hop
        '
        Me.optTong_Hop.Location = New System.Drawing.Point(8, 48)
        Me.optTong_Hop.Name = "optTong_Hop"
        Me.optTong_Hop.Size = New System.Drawing.Size(184, 24)
        Me.optTong_Hop.TabIndex = 2
        Me.optTong_Hop.Text = "Bản kê Tổng hợp"
        '
        'optChi_Tiet
        '
        Me.optChi_Tiet.Location = New System.Drawing.Point(288, 48)
        Me.optChi_Tiet.Name = "optChi_Tiet"
        Me.optChi_Tiet.Size = New System.Drawing.Size(144, 24)
        Me.optChi_Tiet.TabIndex = 3
        Me.optChi_Tiet.Text = "Bản kê Chi tiết"
        '
        'chkNoi_Dia
        '
        Me.chkNoi_Dia.Enabled = False
        Me.chkNoi_Dia.Location = New System.Drawing.Point(8, 16)
        Me.chkNoi_Dia.Name = "chkNoi_Dia"
        Me.chkNoi_Dia.Size = New System.Drawing.Size(176, 24)
        Me.chkNoi_Dia.TabIndex = 0
        Me.chkNoi_Dia.Text = "Hàng không Nội địa"
        '
        'chkQuoc_Te
        '
        Me.chkQuoc_Te.Location = New System.Drawing.Point(288, 16)
        Me.chkQuoc_Te.Name = "chkQuoc_Te"
        Me.chkQuoc_Te.Size = New System.Drawing.Size(160, 24)
        Me.chkQuoc_Te.TabIndex = 1
        Me.chkQuoc_Te.Text = "Hàng không Quốc tế"
        '
        'btnKhoa
        '
        Me.btnKhoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKhoa.Image = CType(resources.GetObject("btnKhoa.Image"), System.Drawing.Image)
        Me.btnKhoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKhoa.Location = New System.Drawing.Point(136, 72)
        Me.btnKhoa.Name = "btnKhoa"
        Me.btnKhoa.Size = New System.Drawing.Size(104, 32)
        Me.btnKhoa.TabIndex = 5
        Me.btnKhoa.Text = "&Khóa SL"
        '
        'btnMo_Khoa
        '
        Me.btnMo_Khoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMo_Khoa.Image = CType(resources.GetObject("btnMo_Khoa.Image"), System.Drawing.Image)
        Me.btnMo_Khoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMo_Khoa.Location = New System.Drawing.Point(256, 72)
        Me.btnMo_Khoa.Name = "btnMo_Khoa"
        Me.btnMo_Khoa.Size = New System.Drawing.Size(104, 32)
        Me.btnMo_Khoa.TabIndex = 6
        Me.btnMo_Khoa.Text = "&Mở khóa SL"
        '
        'cbHang_Van_Chuyen
        '
        Me.cbHang_Van_Chuyen.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance1.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.cbHang_Van_Chuyen.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(67, 0)
        UltraGridColumn2.Header.Caption = "Tên đầy đủ"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(146, 0)
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        UltraGridBand1.Header.Caption = "Đường thư"
        UltraGridBand1.UseRowLayout = True
        Me.cbHang_Van_Chuyen.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance2.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance2.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbHang_Van_Chuyen.DisplayLayout.Override.HeaderAppearance = Appearance2
        Me.cbHang_Van_Chuyen.DisplayMember = "Ten_HVC"
        Me.cbHang_Van_Chuyen.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbHang_Van_Chuyen.Location = New System.Drawing.Point(288, 16)
        Me.cbHang_Van_Chuyen.Name = "cbHang_Van_Chuyen"
        Me.cbHang_Van_Chuyen.Size = New System.Drawing.Size(168, 21)
        Me.cbHang_Van_Chuyen.TabIndex = 2
        Me.cbHang_Van_Chuyen.ValueMember = "HVC"
        '
        'btnXuat_Excel
        '
        Me.btnXuat_Excel.Image = CType(resources.GetObject("btnXuat_Excel.Image"), System.Drawing.Image)
        Me.btnXuat_Excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXuat_Excel.Location = New System.Drawing.Point(256, 336)
        Me.btnXuat_Excel.Name = "btnXuat_Excel"
        Me.btnXuat_Excel.Size = New System.Drawing.Size(104, 32)
        Me.btnXuat_Excel.TabIndex = 14
        Me.btnXuat_Excel.Text = "&Xuất ra Excel"
        Me.btnXuat_Excel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'optTat_Ca
        '
        Me.optTat_Ca.Enabled = False
        Me.optTat_Ca.Location = New System.Drawing.Point(8, 14)
        Me.optTat_Ca.Name = "optTat_Ca"
        Me.optTat_Ca.Size = New System.Drawing.Size(136, 24)
        Me.optTat_Ca.TabIndex = 0
        Me.optTat_Ca.Text = "Tất cả các HVC"
        '
        'optTheo_HVC
        '
        Me.optTheo_HVC.Location = New System.Drawing.Point(176, 14)
        Me.optTheo_HVC.Name = "optTheo_HVC"
        Me.optTheo_HVC.TabIndex = 1
        Me.optTheo_HVC.Text = "Theo từng HVC"
        '
        'btnNhap_Bang_Cuoc
        '
        Me.btnNhap_Bang_Cuoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNhap_Bang_Cuoc.Image = CType(resources.GetObject("btnNhap_Bang_Cuoc.Image"), System.Drawing.Image)
        Me.btnNhap_Bang_Cuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNhap_Bang_Cuoc.Location = New System.Drawing.Point(376, 72)
        Me.btnNhap_Bang_Cuoc.Name = "btnNhap_Bang_Cuoc"
        Me.btnNhap_Bang_Cuoc.Size = New System.Drawing.Size(104, 32)
        Me.btnNhap_Bang_Cuoc.TabIndex = 7
        Me.btnNhap_Bang_Cuoc.Text = "&Bảng Cước"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.optTheo_HVC)
        Me.UltraGroupBox1.Controls.Add(Me.optTat_Ca)
        Me.UltraGroupBox1.Controls.Add(Me.cbHang_Van_Chuyen)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(16, 176)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(464, 56)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 10
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.chkQuoc_Te)
        Me.UltraGroupBox2.Controls.Add(Me.chkNoi_Dia)
        Me.UltraGroupBox2.Controls.Add(Me.optChi_Tiet)
        Me.UltraGroupBox2.Controls.Add(Me.optTong_Hop)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(16, 232)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(464, 80)
        Me.UltraGroupBox2.SupportThemes = False
        Me.UltraGroupBox2.TabIndex = 11
        '
        'FrmQuan_Ly_Cuoc_Hang_Khong
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(496, 397)
        Me.Controls.Add(Me.UltraGroupBox2)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.btnNhap_Bang_Cuoc)
        Me.Controls.Add(Me.btnXuat_Excel)
        Me.Controls.Add(Me.btnKhoa)
        Me.Controls.Add(Me.BtnThoat)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnTao_Du_Lieu)
        Me.Controls.Add(Me.PrbAccounting)
        Me.Controls.Add(Me.lbEMS)
        Me.Controls.Add(Me.CbTu_Ngay)
        Me.Controls.Add(Me.UltraLabel4)
        Me.Controls.Add(Me.CbDen_Ngay)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.btnMo_Khoa)
        Me.Name = "FrmQuan_Ly_Cuoc_Hang_Khong"
        Me.Text = "Tổng hợp quản lý cước hàng không"
        CType(Me.CbTu_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbDen_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbHang_Van_Chuyen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Biến truyền giữa 2 Form"
    Public FrmQL_Cuoc_Hang_Khong_Tu_Ngay As Date
    Public FrmQL_Cuoc_Hang_Khong_Den_Ngay As Date
#End Region

#Region "Biến local của Form"
    Dim myHam_Dung_Chung As New Ham_Dung_Chung
    Dim myAccounting_Cuoc_Hang_Khong As New Accounting_Cuoc_Hang_Khong(GConnectionString)
    Dim myAccounting_Danh_Sach_HVC As New Accounting_Danh_Sach_HVC(GConnectionString)
    Dim myDanh_Muc_Bc As New Danh_Muc_BC(GConnectionString)
    Dim myDanh_Sach_HVC As New Accounting_Danh_Sach_HVC(GConnectionString)
    Dim myNguoi_Dung As New Nguoi_Dung(GConnectionString)
    'Dim aSo_Hieu() As String
#End Region

#Region "FrmQuan_Ly_Cuoc_Hang_Khong_Load"
    Private Sub FrmQuan_Ly_Cuoc_Hang_Khong_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CbTu_Ngay.Value = FrmQL_Cuoc_Hang_Khong_Tu_Ngay
        CbDen_Ngay.Value = FrmQL_Cuoc_Hang_Khong_Den_Ngay
        Load_Data_Combo_Hang_Van_Chuyen()
        optTheo_HVC.Checked = True
        cbHang_Van_Chuyen.Enabled = True
        chkQuoc_Te.Checked = True
        optTong_Hop.Checked = True
        CbTu_Ngay.Select()
    End Sub
#End Region

#Region "TabControl"
#Region "btnTao_Du_Lieu_Click"
    Private Sub btnTao_Du_Lieu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTao_Du_Lieu.Click
        If Kiem_Tra_Thong_Tin_Ngay_Thang() = False Then
            CbTu_Ngay.Select()
            Exit Sub
        End If
        Dim mAcc_Data As New DataTable
        mAcc_Data = myAccounting_Cuoc_Hang_Khong.Accounting_Cuoc_Hang_Khong_Danh_Sach_Da_Chot_SL_Tu_Ngay_Den_Ngay(myHam_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), myHam_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value)).Tables(0)
        If mAcc_Data.Rows.Count > 0 Then
            MessageBox.Show("Đã khóa số liệu trong khoảng thời gian này, bạn không được phép tạo lại dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If MessageBox.Show("Bạn có chắn chắn muốn tạo lại dữ liệu Hàng không ?" & vbNewLine & "Chú ý!!! Nếu đồng ý tất cả dữ liệu cũ sẽ bị xóa bỏ thay bằng dữ liệu mới.", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Dim mData As New DataTable
            Dim mChuyen_Thu_Di As New Chuyen_Thu_Di(GConnectionString)
            Dim mTu_Ngay, mDen_Ngay As Integer
            Dim mKet_Qua As Boolean
            mTu_Ngay = myHam_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value)
            mDen_Ngay = myHam_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value)

            Me.ActiveForm.Cursor.Current = Cursors.WaitCursor

            'Xoa thong tin trong bang Accounting (Tu Ngay -> Den Ngay)
            myAccounting_Cuoc_Hang_Khong.Accounting_Cuoc_Hang_Khong_Xoa_Boi_Tu_Ngay_Den_Ngay(mTu_Ngay, mDen_Ngay)
            'Lấy danh sách chuyến thư cần tạo dữ liệu (Tu Ngay -> Den_Ngay)
            mData = mChuyen_Thu_Di.Chuyen_Thu_Di_Quoc_Te_Danh_Sach_Tu_Ngay_Den_Ngay(mTu_Ngay, mDen_Ngay).Tables(0)
            'Duyệt từng chuyến thư tạo dữ liệu
            mKet_Qua = Tao_Du_Lieu_Hang_Khong(mData, mData.Rows.Count)

            Me.ActiveForm.Cursor.Current = Cursors.Default
            If mKet_Qua Then
                MessageBox.Show("Tạo dữ liệu thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Tạo dữ liệu thất bại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
#End Region
#Region "btnKhoa_Click"
    Private Sub btnKhoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKhoa.Click
        Dim mTu_Ngay, mDen_Ngay As Integer
        mTu_Ngay = myHam_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value)
        mDen_Ngay = myHam_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value)
        If mDen_Ngay < mTu_Ngay Then
            MessageBox.Show("Thời gian không hợp lệ!!!, từ ngày không được lớn hơn đến ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CbTu_Ngay.Select()
        Else
            myAccounting_Cuoc_Hang_Khong.Accounting_Cuoc_Hang_Khong_Cap_Nhat_Khoa_SL_Tu_Ngay_Den_Ngay(mTu_Ngay, mDen_Ngay, True)
            MessageBox.Show("Khóa số liệu thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnKhoa.Enabled = False
            btnMo_Khoa.Enabled = True
        End If
    End Sub
#End Region
#Region "btnMo_Khoa_Click"
    Private Sub btnMo_Khoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMo_Khoa.Click
        Dim mTu_Ngay, mDen_Ngay As Integer
        mTu_Ngay = myHam_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value)
        mDen_Ngay = myHam_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value)
        If mDen_Ngay < mTu_Ngay Then
            MessageBox.Show("Thời gian không hợp lệ!!!, từ ngày không được lớn hơn đến ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CbTu_Ngay.Select()
        Else
            myAccounting_Cuoc_Hang_Khong.Accounting_Cuoc_Hang_Khong_Cap_Nhat_Khoa_SL_Tu_Ngay_Den_Ngay(mTu_Ngay, mDen_Ngay, False)
            MessageBox.Show("Mở khóa số liệu thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnKhoa.Enabled = True
            btnMo_Khoa.Enabled = False
        End If
    End Sub
#End Region
#Region "btnNhap_Bang_Cuoc_Click"
    Private Sub btnNhap_Bang_Cuoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNhap_Bang_Cuoc.Click
        Dim frm As New FrmBang_Cuoc_Hang_Khong
        frm.ShowDialog()
    End Sub
#End Region
#Region "btnPreview_Click"
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        If Kiem_Tra_Thong_Tin_Ngay_Thang() = False Then
            CbTu_Ngay.Select()
            Exit Sub
        End If
        OpenReport(True, 0, myHam_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), myHam_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value))
    End Sub
#End Region
#Region "btnPrint_Click"
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If Kiem_Tra_Thong_Tin_Ngay_Thang() = False Then
            CbTu_Ngay.Select()
            Exit Sub
        End If
        OpenReport(False, 1, myHam_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), myHam_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value))
    End Sub
#End Region
#Region "btnXuat_Excel_Click"
    Private Sub btnXuat_Excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXuat_Excel.Click
        If Kiem_Tra_Thong_Tin_Ngay_Thang() = False Then
            CbTu_Ngay.Select()
            Exit Sub
        End If
        Export_File_Excel(myHam_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), myHam_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value))
    End Sub
#End Region
#Region "BtnThoat_Click"
    Private Sub BtnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnThoat.Click
        Me.Close()
        Me.Dispose()
    End Sub
#End Region
#Region "optTat_Ca_CheckedChanged"
    Private Sub optTat_Ca_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optTat_Ca.CheckedChanged, optTheo_HVC.CheckedChanged
        cbHang_Van_Chuyen.Enabled = optTheo_HVC.Checked
        If optTheo_HVC.Checked Then
            cbHang_Van_Chuyen.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub
#End Region
#Region "CbDen_Ngay_Validated"
    Private Sub CbDen_Ngay_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbDen_Ngay.Validated
        Dim mTu_Ngay, mDen_Ngay As Integer
        mTu_Ngay = myHam_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value)
        mDen_Ngay = myHam_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value)
        If mDen_Ngay >= mTu_Ngay Then
            Dim mData As New DataTable
            mData = myAccounting_Cuoc_Hang_Khong.Accounting_Cuoc_Hang_Khong_Danh_Sach_Tu_Ngay_Den_Ngay(mTu_Ngay, mDen_Ngay).Tables(0)
            If mData.Rows.Count = 0 Then
                btnKhoa.Enabled = False
                btnMo_Khoa.Enabled = False
            Else
                mData = myAccounting_Cuoc_Hang_Khong.Accounting_Cuoc_Hang_Khong_Danh_Sach_Da_Chot_SL_Tu_Ngay_Den_Ngay(mTu_Ngay, mDen_Ngay).Tables(0)
                If mData.Rows.Count > 0 Then
                    btnMo_Khoa.Enabled = True
                    btnKhoa.Enabled = False
                Else
                    btnMo_Khoa.Enabled = False
                    btnKhoa.Enabled = True
                End If
            End If
        Else
            btnKhoa.Enabled = False
            btnMo_Khoa.Enabled = False
        End If
    End Sub
#End Region
#Region "KeyEnter"
    Private Sub CbTu_Ngay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CbTu_Ngay.KeyDown, CbDen_Ngay.KeyDown, cbHang_Van_Chuyen.KeyDown
        If e.KeyValue = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
        End If
    End Sub
#End Region
#End Region

#Region "Ham nguoi dung"
#Region "Tao_Du_Lieu_Hang_Khong"
    Private Function Tao_Du_Lieu_Hang_Khong(ByVal myTable As DataTable, ByVal TongSoBanGhi As Integer) As Boolean
        Try
            Dim i, j, mSo_Chang, mPhan_Loai As Integer
            Dim mCN38 As New CN38(GConnectionString)
            Dim mDanh_Muc_Duong_Bay As New Danh_Muc_Duong_Bay(GConnectionString)
            Dim mDanh_Muc_Chuyen_Bay As New Predes(GConnectionString)

            Dim mCN38_Chi_Tiet As New CN38_Chi_Tiet
            Dim mAccounting_Cuoc_Hang_Khong_Chi_Tiet As New Accounting_Cuoc_Hang_Khong_Chi_Tiet
            Dim mDanh_Muc_Duong_Bay_Chi_Tiet As New Danh_Muc_Duong_Bay_Chi_Tiet
            Dim mDanh_Muc_Chuyen_Bay_Chi_Tiet As New Predes_Flight_Schedules

            PrbAccounting.Maximum = myTable.Rows.Count
            PrbAccounting.Step = 1
            PrbAccounting.Value = 0
            mPhan_Loai = 2
            For i = 0 To TongSoBanGhi - 1
                'Tìm thông tin trong CN38 (theo Id_Chuyen_Thu)
                mCN38_Chi_Tiet = mCN38.Lay(myTable.Rows(i).Item("Id_Chuyen_Thu"))
                If mCN38_Chi_Tiet.Id_Duong_Bay <> "" Then   'Hang khong quoc te
                    mPhan_Loai = 2
                    'Tìm thông tin trong Danh_Muc_Duong_Bay
                    mDanh_Muc_Duong_Bay_Chi_Tiet = mDanh_Muc_Duong_Bay.Lay(mCN38_Chi_Tiet.Id_Duong_Bay)
                    If mDanh_Muc_Duong_Bay_Chi_Tiet.So_hieu <> "" Then
                        Dim aSo_Hieu() As String
                        aSo_Hieu = Lay_Danh_Sach_So_Hieu_Chuyen_Bay_Theo_Tung_Chang_Bay(mDanh_Muc_Duong_Bay_Chi_Tiet.So_hieu)
                        mSo_Chang = aSo_Hieu.Length
                        'Duyệt từng chặng bay
                        For j = 0 To mSo_Chang - 1
                            'Tìm thông tin trong Danh_Muc_Chuyen_Bay
                            mDanh_Muc_Chuyen_Bay_Chi_Tiet = mDanh_Muc_Chuyen_Bay.Get_Flight_Schedule(aSo_Hieu(j))
                            If mDanh_Muc_Chuyen_Bay_Chi_Tiet.From_Country.Trim <> "" Then
                                mPhan_Loai = 2
                            Else
                                mPhan_Loai = 3
                            End If
                            'Lấy thông tin vào biến Accounting_Cuoc_Hang_Khong_Chi_Tiet
                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Id_Duong_Thu = myTable.Rows(i).Item("Id_Duong_Thu")
                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Id_Chuyen_Thu = myTable.Rows(i).Item("Id_Chuyen_Thu")
                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Ngay_Dong = myTable.Rows(i).Item("Ngay_Dong")
                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Ngay_Bay = mCN38_Chi_Tiet.Ngay_Bay
                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.So_Chuyen_Thu = myTable.Rows(i).Item("So_Chuyen_Thu")
                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Loai_Chuyen_Thu = myTable.Rows(i).Item("Loai_Chuyen_Thu")
                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.HVC = mDanh_Muc_Chuyen_Bay_Chi_Tiet.Airlines
                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Nuoc_Xuat_Phat = mDanh_Muc_Chuyen_Bay_Chi_Tiet.From_Country
                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Nuoc_Den = mDanh_Muc_Chuyen_Bay_Chi_Tiet.To_Country
                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.San_Bay_Xuat_Phat = mDanh_Muc_Chuyen_Bay_Chi_Tiet.From_Airport
                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.San_Bay_Den = mDanh_Muc_Chuyen_Bay_Chi_Tiet.To_Airport
                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Tong_So_Tui = myTable.Rows(i).Item("Tong_So_Tui")
                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Khoi_Luong_Tui_Rong = 0
                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Khoi_Luong_EMS = myTable.Rows(i).Item("Tong_KL")
                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Tong_Khoi_Luong = mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Khoi_Luong_EMS + mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Khoi_Luong_Tui_Rong
                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Phan_Loai = mPhan_Loai
                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Ngay_He_Thong = 0
                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Gio_He_Thong = 0
                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Id_Nguoi_Dung = Gid_Nguoi_Dung
                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Chot_SL = False
                            '------------Them doan tin cuoc-----------------------------------
                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Don_Gia_Cuoc = Lay_Don_Gia_Cuoc_Theo_Chang(mAccounting_Cuoc_Hang_Khong_Chi_Tiet.San_Bay_Xuat_Phat, mAccounting_Cuoc_Hang_Khong_Chi_Tiet.San_Bay_Den)
                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Don_Gia_Cuoc_Tui_Rong = 0
                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Tong_Cuoc = Tinh_Tong_Cuoc_Hang_Khong( _
                                                                                mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Khoi_Luong_EMS, _
                                                                                mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Don_Gia_Cuoc, _
                                                                                mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Khoi_Luong_Tui_Rong, _
                                                                                mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Don_Gia_Cuoc_Tui_Rong)
                            'Insert vào bảng dữ liệu
                            myAccounting_Cuoc_Hang_Khong.Accounting_Cuoc_Hang_Khong_Them( _
                                                                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Id_Duong_Thu, _
                                                                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Id_Chuyen_Thu, _
                                                                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Ngay_Dong, _
                                                                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Ngay_Bay, _
                                                                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.So_Chuyen_Thu, _
                                                                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Loai_Chuyen_Thu, _
                                                                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.HVC, _
                                                                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Nuoc_Xuat_Phat, _
                                                                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Nuoc_Den, _
                                                                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.San_Bay_Xuat_Phat, _
                                                                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.San_Bay_Den, _
                                                                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Tong_So_Tui, _
                                                                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Khoi_Luong_Tui_Rong, _
                                                                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Khoi_Luong_EMS, _
                                                                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Tong_Khoi_Luong, _
                                                                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Don_Gia_Cuoc_Tui_Rong, _
                                                                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Don_Gia_Cuoc, _
                                                                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Tong_Cuoc, _
                                                                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Phan_Loai, _
                                                                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Ngay_He_Thong, _
                                                                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Gio_He_Thong, _
                                                                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Id_Nguoi_Dung, _
                                                                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Chot_SL)
                        Next
                    End If
                Else   'Hàng không nội địa
                    If ((myTable.Rows(i).Item("Id_Duong_Thu") = "01009150700915") Or (myTable.Rows(i).Item("Id_Duong_Thu") = "07009150100915")) Then
                        mPhan_Loai = 1
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Id_Duong_Thu = myTable.Rows(i).Item("Id_Duong_Thu")
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Id_Chuyen_Thu = myTable.Rows(i).Item("Id_Chuyen_Thu")
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Ngay_Dong = myTable.Rows(i).Item("Ngay_Dong")
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Ngay_Bay = myTable.Rows(i).Item("Ngay_Dong")
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.So_Chuyen_Thu = myTable.Rows(i).Item("So_Chuyen_Thu")
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Loai_Chuyen_Thu = myTable.Rows(i).Item("Loai_Chuyen_Thu")
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.HVC = ""
                        'If myTable.Rows(i).Item("Id_Duong_Thu") = "01009150700915" Then
                        '    mAccounting_Cuoc_Hang_Khong_Chi_Tiet.HVC = "VN"
                        'Else
                        '    mAccounting_Cuoc_Hang_Khong_Chi_Tiet.HVC = "SG"
                        'End If
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Nuoc_Xuat_Phat = "VN"
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Nuoc_Den = "VN"
                        If myTable.Rows(i).Item("Id_Duong_Thu") = "01009150700915" Then
                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.San_Bay_Xuat_Phat = "HAN"
                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.San_Bay_Den = "SGN"
                        Else
                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.San_Bay_Xuat_Phat = "SGN"
                            mAccounting_Cuoc_Hang_Khong_Chi_Tiet.San_Bay_Den = "HAN"
                        End If
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Tong_So_Tui = myTable.Rows(i).Item("Tong_So_Tui")
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Khoi_Luong_Tui_Rong = 0
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Khoi_Luong_EMS = myTable.Rows(i).Item("Tong_KL")
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Tong_Khoi_Luong = mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Khoi_Luong_EMS + mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Khoi_Luong_Tui_Rong
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Phan_Loai = mPhan_Loai
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Ngay_He_Thong = 0
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Gio_He_Thong = 0
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Id_Nguoi_Dung = Gid_Nguoi_Dung
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Chot_SL = False
                        '------------Them doan tin cuoc-----------------------------------
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Don_Gia_Cuoc = 0
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Don_Gia_Cuoc_Tui_Rong = 0
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Tong_Cuoc = 0
                        'Insert vào bảng dữ liệu
                        myAccounting_Cuoc_Hang_Khong.Accounting_Cuoc_Hang_Khong_Them( _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Id_Duong_Thu, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Id_Chuyen_Thu, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Ngay_Dong, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Ngay_Bay, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.So_Chuyen_Thu, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Loai_Chuyen_Thu, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.HVC, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Nuoc_Xuat_Phat, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Nuoc_Den, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.San_Bay_Xuat_Phat, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.San_Bay_Den, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Tong_So_Tui, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Khoi_Luong_Tui_Rong, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Khoi_Luong_EMS, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Tong_Khoi_Luong, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Don_Gia_Cuoc_Tui_Rong, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Don_Gia_Cuoc, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Tong_Cuoc, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Phan_Loai, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Ngay_He_Thong, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Gio_He_Thong, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Id_Nguoi_Dung, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Chot_SL)
                    Else
                        mPhan_Loai = 3   'Không xác định được chuyến bay - Ghi vào dữ liệu phòng trường hợp bị thiếu
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Id_Duong_Thu = myTable.Rows(i).Item("Id_Duong_Thu")
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Id_Chuyen_Thu = myTable.Rows(i).Item("Id_Chuyen_Thu")
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Ngay_Dong = myTable.Rows(i).Item("Ngay_Dong")
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Ngay_Bay = myTable.Rows(i).Item("Ngay_Dong")
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.So_Chuyen_Thu = myTable.Rows(i).Item("So_Chuyen_Thu")
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Loai_Chuyen_Thu = myTable.Rows(i).Item("Loai_Chuyen_Thu")
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.HVC = ""
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Nuoc_Xuat_Phat = ""
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Nuoc_Den = ""
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.San_Bay_Xuat_Phat = ""
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.San_Bay_Den = ""
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Tong_So_Tui = myTable.Rows(i).Item("Tong_So_Tui")
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Khoi_Luong_Tui_Rong = 0
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Khoi_Luong_EMS = myTable.Rows(i).Item("Tong_KL")
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Tong_Khoi_Luong = mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Khoi_Luong_EMS + mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Khoi_Luong_Tui_Rong
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Phan_Loai = mPhan_Loai
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Ngay_He_Thong = 0
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Gio_He_Thong = 0
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Id_Nguoi_Dung = Gid_Nguoi_Dung
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Chot_SL = False
                        '------------Them doan tin cuoc-----------------------------------
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Don_Gia_Cuoc = 0
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Don_Gia_Cuoc_Tui_Rong = 0
                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Tong_Cuoc = 0
                        'Insert vào bảng dữ liệu
                        myAccounting_Cuoc_Hang_Khong.Accounting_Cuoc_Hang_Khong_Them( _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Id_Duong_Thu, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Id_Chuyen_Thu, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Ngay_Dong, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Ngay_Bay, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.So_Chuyen_Thu, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Loai_Chuyen_Thu, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.HVC, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Nuoc_Xuat_Phat, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Nuoc_Den, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.San_Bay_Xuat_Phat, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.San_Bay_Den, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Tong_So_Tui, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Khoi_Luong_Tui_Rong, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Khoi_Luong_EMS, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Tong_Khoi_Luong, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Don_Gia_Cuoc_Tui_Rong, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Don_Gia_Cuoc, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Tong_Cuoc, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Phan_Loai, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Ngay_He_Thong, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Gio_He_Thong, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Id_Nguoi_Dung, _
                                                                        mAccounting_Cuoc_Hang_Khong_Chi_Tiet.Chot_SL)
                    End If
                End If
                Application.DoEvents()
                PrbAccounting.PerformStep()
                'PrbAccounting.Value = i + 1
                lbEMS.Text = "Đang ghi dữ liệu Hàng không  ( " & PrbAccounting.Value & " / " & PrbAccounting.Maximum & " )"
                lbEMS.Refresh()
            Next i
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function
#End Region
#Region "Kiem_Tra_Thong_Tin_Ngay_Thang"
    Private Function Kiem_Tra_Thong_Tin_Ngay_Thang() As Boolean
        Dim mTu_Ngay, mDen_Ngay As Integer
        mTu_Ngay = myHam_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value)
        mDen_Ngay = myHam_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value)
        If mTu_Ngay > mDen_Ngay Then
            MessageBox.Show("Ngày tháng nhập vào không hợp lệ!!! Mời nhập lại thông tin từ ngày đến ngày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function
#End Region
#Region "Lay_Danh_Sach_So_Hieu_Chuyen_Bay_Theo_Tung_Chang_Bay"
    Private Function Lay_Danh_Sach_So_Hieu_Chuyen_Bay_Theo_Tung_Chang_Bay(ByVal mSo_Hieu As String) As Object
        Dim i, j As Integer
        Dim flight_number(10) As String
        Dim flight As String
        Dim str As String
        i = 0
        flight = ""
        For j = 0 To mSo_Hieu.Length() - 1
            str = mSo_Hieu.Substring(j, 1)
            If str = "/" Then
                flight_number(i) = flight
                i = i + 1
                flight = ""
            Else
                flight = flight + str
            End If
        Next
        flight_number(i) = flight
        ReDim Preserve flight_number(i)
        Return flight_number
    End Function
#End Region
#Region "Lay_Don_Gia_Cuoc_Theo_Chang"
    Private Function Lay_Don_Gia_Cuoc_Theo_Chang(ByVal mXuat_Phat As String, ByVal mDen As String) As Double
        Try
            Dim mAccounting_Bang_Cuoc_Hang_Khong As New Accounting_Bang_Cuoc_Hang_Khong(GConnectionString)
            Dim mDon_Gia_Cuoc As Double
            Dim mId_Cuoc As String = mXuat_Phat.Trim & mDen.Trim
            mDon_Gia_Cuoc = mAccounting_Bang_Cuoc_Hang_Khong.Accounting_Bang_Cuoc_Hang_Khong_Lay(mId_Cuoc).Cuoc
            Return mDon_Gia_Cuoc
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
    End Function
#End Region
#Region "Tinh_Tong_Cuoc_Hang_Khong"
    Private Function Tinh_Tong_Cuoc_Hang_Khong(ByVal mKhoi_Luong_EMS As Integer, ByVal mDon_Gia_Cuoc As Double, ByVal mKhoi_Luong_Tui_Rong As Integer, ByVal mDon_Gia_Cuoc_Tui_Rong As Double) As Double
        Try
            Dim mTong_Cuoc As Double
            Dim mKg As Double
            mKg = Round(mKhoi_Luong_EMS / 1000, 2)
            mTong_Cuoc = Round(mKg * mDon_Gia_Cuoc, 2)
            mKg = Round(mKhoi_Luong_Tui_Rong / 1000, 2)
            mTong_Cuoc = mTong_Cuoc + Round(mKg * mDon_Gia_Cuoc_Tui_Rong, 2)
            Return Round(mTong_Cuoc, 2)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
    End Function
#End Region
#Region "Load_Data_Combo_Hang_Van_Chuyen"
    Private Sub Load_Data_Combo_Hang_Van_Chuyen()
        cbHang_Van_Chuyen.DataSource = myAccounting_Danh_Sach_HVC.Accounting_Danh_Sach_HVC_Danh_Sach()
        cbHang_Van_Chuyen.DataBind()
        cbHang_Van_Chuyen.LimitToList = True
    End Sub
#End Region
#Region "Xac_Dinh_Loai_Bao_Cao"
    Private Function Xac_Dinh_Loai_Bao_Cao() As Integer
        'Tra ve gia tri : XYZ
        'X    :    Tat ca : X = 1        Tung HVC : X = 2
        'Y    :    Noi dia: Y = 1        Quoc te  : Y = 2
        'Z    :    Tong hop:Z = 1        Chi tiet : Z = 2
        If optTat_Ca.Checked Then    'Tat ca (X = 1)
            If chkNoi_Dia.Checked Then    'Noi dia (Y = 1)
                If optTong_Hop.Checked Then     'Tong hop (Z = 1)
                    Return 111
                Else  'Chi tiet (Z = 2)
                    Return 112
                End If
            Else    'Quoc Te (Y = 2)
                If optTong_Hop.Checked Then     'Tong hop (Z = 1)
                    Return 121
                Else  'Chi tiet (Z = 2)
                    Return 122
                End If
            End If
        Else   'Tung HVC (X = 2)
            If chkNoi_Dia.Checked Then    'Noi dia (Y = 1)
                If optTong_Hop.Checked Then     'Tong hop (Z = 1)
                    Return 211
                Else  'Chi tiet (Z = 2)
                    Return 212
                End If
            Else    'Quoc Te (Y = 2)
                If optTong_Hop.Checked Then     'Tong hop (Z = 1)
                    Return 221
                Else  'Chi tiet (Z = 2)
                    Return 222
                End If
            End If
        End If
    End Function
#End Region
#Region "OpenReport"
    Private Sub OpenReport(ByVal mPreview As Boolean, ByVal mSo_Ban As Integer, ByVal mTu_Ngay As Integer, ByVal mDen_Ngay As Integer)
        Select Case Xac_Dinh_Loai_Bao_Cao()
            Case 111
                MessageBox.Show("Báo cáo này chưa hoàn thiện, mời bạn quay lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 112
                MessageBox.Show("Báo cáo này chưa hoàn thiện, mời bạn quay lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 121
                MessageBox.Show("Báo cáo này chưa hoàn thiện, mời bạn quay lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 122
                MessageBox.Show("Báo cáo này chưa hoàn thiện, mời bạn quay lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 211
                MessageBox.Show("Báo cáo này chưa hoàn thiện, mời bạn quay lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 212
                MessageBox.Show("Báo cáo này chưa hoàn thiện, mời bạn quay lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 221  'Báo cáo tổng hợp cho từng HVC (hàng không quốc tế)
                If ((cbHang_Van_Chuyen.Value Is DBNull.Value) Or (cbHang_Van_Chuyen.Value Is Nothing)) Then
                    MessageBox.Show("Bạn chưa chọn hãng vận chuyển!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    cbHang_Van_Chuyen.Select()
                    cbHang_Van_Chuyen.PerformAction(UltraComboAction.Dropdown)
                    Exit Sub
                End If
                Ban_Ke_Tong_Hop_Cuoc_Hang_Khong_Quoc_Te_Theo_HVC(mPreview, mSo_Ban, mTu_Ngay, mDen_Ngay, cbHang_Van_Chuyen.Value)
            Case 222  'Báo cáo chi tiết cho từng HVC (hàng không quốc tế)
                If ((cbHang_Van_Chuyen.Value Is DBNull.Value) Or (cbHang_Van_Chuyen.Value Is Nothing)) Then
                    MessageBox.Show("Bạn chưa chọn hãng vận chuyển!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    cbHang_Van_Chuyen.Select()
                    cbHang_Van_Chuyen.PerformAction(UltraComboAction.Dropdown)
                    Exit Sub
                End If
                Ban_Ke_Chi_Tiet_Cuoc_Hang_Khong_Quoc_Te_Theo_HVC(mPreview, mSo_Ban, mTu_Ngay, mDen_Ngay, cbHang_Van_Chuyen.Value)
        End Select
    End Sub
#End Region
#Region "Export_File_Excel"
    Private Sub Export_File_Excel(ByVal mTu_Ngay As Integer, ByVal mDen_Ngay As Integer)
        Dim mTen_File_Excel As String
        Dim mPathFile As String
        Dim mData As DataSet
        Select Case Xac_Dinh_Loai_Bao_Cao()
            Case 111
                MessageBox.Show("Báo cáo này chưa hoàn thiện, mời bạn quay lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 112
                MessageBox.Show("Báo cáo này chưa hoàn thiện, mời bạn quay lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 121
                MessageBox.Show("Báo cáo này chưa hoàn thiện, mời bạn quay lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 122
                MessageBox.Show("Báo cáo này chưa hoàn thiện, mời bạn quay lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 211
                MessageBox.Show("Báo cáo này chưa hoàn thiện, mời bạn quay lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 212
                MessageBox.Show("Báo cáo này chưa hoàn thiện, mời bạn quay lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 221  'Báo cáo tổng hợp cho từng HVC (hàng không quốc tế)
                If ((cbHang_Van_Chuyen.Value Is DBNull.Value) Or (cbHang_Van_Chuyen.Value Is Nothing)) Then
                    MessageBox.Show("Bạn chưa chọn hãng vận chuyển!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    cbHang_Van_Chuyen.Select()
                    cbHang_Van_Chuyen.PerformAction(UltraComboAction.Dropdown)
                    Exit Sub
                End If
                mTen_File_Excel = cbHang_Van_Chuyen.Value & "_" & mTu_Ngay.ToString & "_" & mDen_Ngay.ToString & "_" & "TongHop"
                mPathFile = OpenDialogExcelFile(mTen_File_Excel)
                If mPathFile <> "" Then
                    mData = myAccounting_Cuoc_Hang_Khong.Accounting_Cuoc_Hang_Khong_Ban_Ke_Tong_Hop_QT_Theo_HVC_Tu_Ngay_Den_Ngay(mTu_Ngay, mDen_Ngay, cbHang_Van_Chuyen.Value)
                    Export_To_Excel_From_DataSet(mData, mPathFile)
                Else
                    MessageBox.Show("Bạn chưa chọn đường dẫn File Excel, việc ghi file đã bị hủy bỏ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case 222  'Báo cáo chi tiết cho từng HVC (hàng không quốc tế)
                If ((cbHang_Van_Chuyen.Value Is DBNull.Value) Or (cbHang_Van_Chuyen.Value Is Nothing)) Then
                    MessageBox.Show("Bạn chưa chọn hãng vận chuyển!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    cbHang_Van_Chuyen.Select()
                    cbHang_Van_Chuyen.PerformAction(UltraComboAction.Dropdown)
                    Exit Sub
                End If
                mTen_File_Excel = cbHang_Van_Chuyen.Value & "_" & mTu_Ngay.ToString & "_" & mDen_Ngay.ToString & "_" & "ChiTiet"
                mPathFile = OpenDialogExcelFile(mTen_File_Excel)
                If mPathFile <> "" Then
                    mData = myAccounting_Cuoc_Hang_Khong.Accounting_Cuoc_Hang_Khong_Ban_Ke_Chi_Tiet_QT_Theo_HVC_Tu_Ngay_Den_Ngay_Xuat_Excel(mTu_Ngay, mDen_Ngay, cbHang_Van_Chuyen.Value)
                    Export_To_Excel_From_DataSet(mData, mPathFile)
                Else
                    MessageBox.Show("Bạn chưa chọn đường dẫn File Excel, việc ghi file đã bị hủy bỏ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
        End Select
    End Sub
#End Region

#Region "=====================Report================="
#Region "Ban_Ke_Tong_Hop_Cuoc_Hang_Khong_Quoc_Te_Theo_HVC"
    Public Function Ban_Ke_Tong_Hop_Cuoc_Hang_Khong_Quoc_Te_Theo_HVC(ByVal mPreview As Boolean, ByVal mSo_Ban As Integer, ByVal mTu_Ngay As Integer, ByVal mDen_Ngay As Integer, ByVal mHVC As String) As Boolean
        Try
            Dim FrmView As New FrmViewReports
            Dim mAccounting_Cuoc_Hang_Khong As New Accounting_Cuoc_Hang_Khong(GConnectionString)

            Dim pvCollection As New ParameterValues
            Dim _pThamSo As New ParameterDiscreteValue
            Dim pMenu_Trai As String
            Dim pMenu_Phai As String
            Dim pTen_Bao_Cao As String
            Dim pThoi_Gian_Bao_Cao As String
            Dim pNgay_Lap As String
            Dim pNguoi_Lap As String

            Dim mReport As New RptBang_Ke_Tong_Hop_Cuoc_Hang_Khong
            Dim mData As DataTable

            Cursor.Current = Cursors.WaitCursor
            'Lấy thông tin chi tiết 
            mData = mAccounting_Cuoc_Hang_Khong.Accounting_Cuoc_Hang_Khong_Ban_Ke_Tong_Hop_QT_Theo_HVC_Tu_Ngay_Den_Ngay(mTu_Ngay, mDen_Ngay, mHVC).Tables(0)
            mData.TableName = "Bang_Ke_Tong_Hop_Cuoc_HK"

            'Lấy giá trị cho Paramete
            pMenu_Trai = "CTY CỔ PHẦN CHUYỂN PHÁT NHANH BƯU ĐIỆN" & vbNewLine & "PHÒNG TÀI CHÍNH KẾ TOÁN"

            If myDanh_Muc_Bc.Lay(GBuu_Cuc_Khai_Thac).Ma_Tinh < 200000 Then  'HANOI
                pMenu_Phai = "TRUNG TÂM KTQT HÀ NỘI"
                pNgay_Lap = "Hà Nội, ngày " & Now.Date.Day.ToString("00") & "/" & Now.Date.Month.ToString("00") & "/" & Now.Date.Year.ToString("0000")
            Else  'HOCHIMINH
                pMenu_Phai = "TRUNG TÂM KTQT HỒ CHÍ MINH"
                pNgay_Lap = "TP HCM, ngày " & Now.Date.Day.ToString("00") & "/" & Now.Date.Month.ToString("00") & "/" & Now.Date.Year.ToString("0000")
            End If

            pTen_Bao_Cao = "BẢNG TỔNG HỢP CƯỚC PHÍ VẬN CHUYỂN HÀNG KHÔNG" & vbNewLine & "QUA HÃNG : " & mHVC & " (" & myDanh_Sach_HVC.Accounting_Danh_Sach_HVC_Lay(mHVC).Ten_HVC & ")"
            pThoi_Gian_Bao_Cao = "Từ ngày: " & myHam_Dung_Chung.ConvertIntToVNDateType(mTu_Ngay) & " đến ngày: " & myHam_Dung_Chung.ConvertIntToVNDateType(mDen_Ngay)

            pNguoi_Lap = "Kế toán Công ty" & vbNewLine & "Người lập" & vbNewLine & vbNewLine & vbNewLine & vbNewLine & vbNewLine & myNguoi_Dung.Lay(Gid_Nguoi_Dung).Ho_Ten

            _pThamSo.Value = pMenu_Trai
            pvCollection.Add(_pThamSo)
            mReport.DataDefinition.ParameterFields("pMenu_Trai").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = pMenu_Phai
            pvCollection.Add(_pThamSo)
            mReport.DataDefinition.ParameterFields("pMenu_Phai").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = pTen_Bao_Cao
            pvCollection.Add(_pThamSo)
            mReport.DataDefinition.ParameterFields("pTen_Bao_Cao").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = pThoi_Gian_Bao_Cao
            pvCollection.Add(_pThamSo)
            mReport.DataDefinition.ParameterFields("pThoi_Gian_Bao_Cao").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = pNgay_Lap
            pvCollection.Add(_pThamSo)
            mReport.DataDefinition.ParameterFields("pNgay_Lap").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = pNguoi_Lap
            pvCollection.Add(_pThamSo)
            mReport.DataDefinition.ParameterFields("pNguoi_Lap").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            mReport.SetDataSource(mData)
            FrmView.CrystalReportViewer1.ReportSource = mReport

            Cursor.Current = Cursors.Default
            If mPreview = True Then
                FrmView.ShowDialog()
            Else
                mReport.PrintToPrinter(mSo_Ban, True, 0, 0)
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region
#Region "Ban_Ke_Chi_Tiet_Cuoc_Hang_Khong_Quoc_Te_Theo_HVC"
    Public Function Ban_Ke_Chi_Tiet_Cuoc_Hang_Khong_Quoc_Te_Theo_HVC(ByVal mPreview As Boolean, ByVal mSo_Ban As Integer, ByVal mTu_Ngay As Integer, ByVal mDen_Ngay As Integer, ByVal mHVC As String) As Boolean
        Try
            Dim FrmView As New FrmViewReports
            Dim mAccounting_Cuoc_Hang_Khong As New Accounting_Cuoc_Hang_Khong(GConnectionString)

            Dim pvCollection As New ParameterValues
            Dim _pThamSo As New ParameterDiscreteValue
            Dim pMenu_Trai As String
            Dim pMenu_Phai As String
            Dim pTen_Bao_Cao As String
            Dim pThoi_Gian_Bao_Cao As String
            Dim pNgay_Lap As String
            Dim pNguoi_Lap As String

            Dim mReport As New RptBang_Ke_Chi_Tiet_Cuoc_Hang_Khong
            Dim mData As DataTable

            Cursor.Current = Cursors.WaitCursor
            'Lấy thông tin chi tiết 
            mData = mAccounting_Cuoc_Hang_Khong.Accounting_Cuoc_Hang_Khong_Ban_Ke_Chi_Tiet_QT_Theo_HVC_Tu_Ngay_Den_Ngay(mTu_Ngay, mDen_Ngay, mHVC).Tables(0)
            mData.TableName = "Bang_Ke_Chi_Tiet_Cuoc_HK_Theo_HVC"

            'Lấy giá trị cho Paramete
            pMenu_Trai = "CTY CỔ PHẦN CHUYỂN PHÁT NHANH BƯU ĐIỆN" & vbNewLine & "PHÒNG TÀI CHÍNH KẾ TOÁN"

            If myDanh_Muc_Bc.Lay(GBuu_Cuc_Khai_Thac).Ma_Tinh < 200000 Then  'HANOI
                pMenu_Phai = "TRUNG TÂM KTQT HÀ NỘI"
                pNgay_Lap = "Hà Nội, ngày " & Now.Date.Day.ToString("00") & "/" & Now.Date.Month.ToString("00") & "/" & Now.Date.Year.ToString("0000")
            Else  'HOCHIMINH
                pMenu_Phai = "TRUNG TÂM KTQT HỒ CHÍ MINH"
                pNgay_Lap = "TP HCM, ngày " & Now.Date.Day.ToString("00") & "/" & Now.Date.Month.ToString("00") & "/" & Now.Date.Year.ToString("0000")
            End If
            pTen_Bao_Cao = "BẢNG KÊ KHỐI LƯỢNG VẬN CHUYỂN HÀNG KHÔNG" & vbNewLine & "QUA HÃNG : " & mHVC & " (" & myDanh_Sach_HVC.Accounting_Danh_Sach_HVC_Lay(mHVC).Ten_HVC & ")"
            pThoi_Gian_Bao_Cao = "Từ ngày: " & myHam_Dung_Chung.ConvertIntToVNDateType(mTu_Ngay) & " đến ngày: " & myHam_Dung_Chung.ConvertIntToVNDateType(mDen_Ngay)

            pNguoi_Lap = "Kế toán Công ty" & vbNewLine & "Người lập" & vbNewLine & vbNewLine & vbNewLine & vbNewLine & vbNewLine & myNguoi_Dung.Lay(Gid_Nguoi_Dung).Ho_Ten

            _pThamSo.Value = pMenu_Trai
            pvCollection.Add(_pThamSo)
            mReport.DataDefinition.ParameterFields("pMenu_Trai").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = pMenu_Phai
            pvCollection.Add(_pThamSo)
            mReport.DataDefinition.ParameterFields("pMenu_Phai").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = pTen_Bao_Cao
            pvCollection.Add(_pThamSo)
            mReport.DataDefinition.ParameterFields("pTen_Bao_Cao").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = pThoi_Gian_Bao_Cao
            pvCollection.Add(_pThamSo)
            mReport.DataDefinition.ParameterFields("pThoi_Gian_Bao_Cao").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = pNgay_Lap
            pvCollection.Add(_pThamSo)
            mReport.DataDefinition.ParameterFields("pNgay_Lap").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = pNguoi_Lap
            pvCollection.Add(_pThamSo)
            mReport.DataDefinition.ParameterFields("pNguoi_Lap").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            mReport.SetDataSource(mData)
            FrmView.CrystalReportViewer1.ReportSource = mReport

            Cursor.Current = Cursors.Default
            If mPreview = True Then
                FrmView.ShowDialog()
            Else
                mReport.PrintToPrinter(mSo_Ban, True, 0, 0)
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region
#End Region
#End Region

#Region "OpenDialogExcelFile"
    Private Function OpenDialogExcelFile(ByVal inFileName As String) As String
        Try
            'Open SaveDialog
            With sFileDlg
                '.InitialDirectory = inPathFile
                .FileName = inFileName
                .Title = "Chon ten File"
                .DefaultExt = "*.xls"
                .Filter = "Xls (*.xls)|*.xls"
                .ShowDialog()
            End With
            'Lay ten file dich theo lua chon cua nguoi dung tu savedialog
            If InStr(sFileDlg.FileName, "\", CompareMethod.Text) <> 0 Then
                Return sFileDlg.FileName
            Else
                Return ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        End Try
    End Function
#End Region

End Class

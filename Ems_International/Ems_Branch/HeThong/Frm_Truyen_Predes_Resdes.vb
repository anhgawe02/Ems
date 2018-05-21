Imports CrystalDecisions.CrystalReports.Engine
Imports Ems_International_Logic.EMS
Imports System.IO
Imports System.IO.File
Imports System.Text
Imports FTP
Public Class Frm_Truyen_Predes_Resdes
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
    Friend WithEvents PrbTien_Trinh As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    Friend WithEvents BtnThoat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents LbThong_Tin As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CbMa_Ca As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CbNgay_Kt As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents lblTien_Trinh As System.Windows.Forms.Label
    Friend WithEvents chk_Truyen_Theo_Ca As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cb_Den_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cb_Tu_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbMa_Ca_Theo_BC As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbBuu_Cuc_Khai_Thac As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents BtnTruyen_EDI As Infragistics.Win.Misc.UltraButton
    Friend WithEvents lblNgay_Truyen As System.Windows.Forms.Label
    Friend WithEvents btnTruyenExcel As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_Truyen_Predes_Resdes))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Ca", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ca_Khai_Thac")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thu_Tu")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ca")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Bc", -1)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Bc_Khai_Thac")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Ca", -1)
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ca_Khai_Thac")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thu_Tu")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ca")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.PrbTien_Trinh = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar
        Me.BtnThoat = New Infragistics.Win.Misc.UltraButton
        Me.BtnTruyen_EDI = New Infragistics.Win.Misc.UltraButton
        Me.LbThong_Tin = New Infragistics.Win.Misc.UltraLabel
        Me.cbMa_Ca_Theo_BC = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbBuu_Cuc_Khai_Thac = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.cb_Den_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.cb_Tu_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.chk_Truyen_Theo_Ca = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.CbMa_Ca = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.CbNgay_Kt = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.lblTien_Trinh = New System.Windows.Forms.Label
        Me.lblNgay_Truyen = New System.Windows.Forms.Label
        Me.btnTruyenExcel = New Infragistics.Win.Misc.UltraButton
        CType(Me.cbMa_Ca_Theo_BC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbBuu_Cuc_Khai_Thac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_Den_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_Tu_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbMa_Ca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbNgay_Kt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrbTien_Trinh
        '
        Me.PrbTien_Trinh.BorderStyle = Infragistics.Win.UIElementBorderStyle.InsetSoft
        Me.PrbTien_Trinh.Location = New System.Drawing.Point(0, 336)
        Me.PrbTien_Trinh.Maximum = 10000
        Me.PrbTien_Trinh.Name = "PrbTien_Trinh"
        Me.PrbTien_Trinh.Size = New System.Drawing.Size(480, 32)
        Me.PrbTien_Trinh.Step = 1
        Me.PrbTien_Trinh.TabIndex = 72
        Me.PrbTien_Trinh.Text = "[Formatted]"
        '
        'BtnThoat
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.BtnThoat.Appearance = Appearance1
        Me.BtnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnThoat.ImageSize = New System.Drawing.Size(30, 25)
        Me.BtnThoat.Location = New System.Drawing.Point(328, 224)
        Me.BtnThoat.Name = "BtnThoat"
        Me.BtnThoat.Size = New System.Drawing.Size(136, 40)
        Me.BtnThoat.TabIndex = 2
        Me.BtnThoat.Text = "Thoát"
        '
        'BtnTruyen_EDI
        '
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.BtnTruyen_EDI.Appearance = Appearance2
        Me.BtnTruyen_EDI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTruyen_EDI.ImageSize = New System.Drawing.Size(30, 25)
        Me.BtnTruyen_EDI.Location = New System.Drawing.Point(16, 224)
        Me.BtnTruyen_EDI.Name = "BtnTruyen_EDI"
        Me.BtnTruyen_EDI.Size = New System.Drawing.Size(136, 40)
        Me.BtnTruyen_EDI.TabIndex = 0
        Me.BtnTruyen_EDI.Text = "Truyền EDI"
        '
        'LbThong_Tin
        '
        Appearance3.FontData.BoldAsString = "True"
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Center
        Me.LbThong_Tin.Appearance = Appearance3
        Me.LbThong_Tin.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.LbThong_Tin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LbThong_Tin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbThong_Tin.Location = New System.Drawing.Point(-1, 6)
        Me.LbThong_Tin.Name = "LbThong_Tin"
        Me.LbThong_Tin.Size = New System.Drawing.Size(480, 64)
        Me.LbThong_Tin.TabIndex = 68
        '
        'cbMa_Ca_Theo_BC
        '
        Me.cbMa_Ca_Theo_BC.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.Caption = "Bưu cục khai thác"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        Appearance4.FontData.BoldAsString = "True"
        UltraGridColumn3.Header.Appearance = Appearance4
        UltraGridColumn3.Header.Caption = "Ca"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 30
        Appearance5.FontData.BoldAsString = "True"
        Appearance5.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn4.Header.Appearance = Appearance5
        UltraGridColumn4.Header.Caption = "Tên ca"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 70
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        UltraGridBand1.SummaryFooterCaption = "Grand Summaries"
        Me.cbMa_Ca_Theo_BC.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance6.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance6.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbMa_Ca_Theo_BC.DisplayLayout.Override.HeaderAppearance = Appearance6
        Me.cbMa_Ca_Theo_BC.DisplayMember = "Ca"
        Me.cbMa_Ca_Theo_BC.LimitToList = True
        Me.cbMa_Ca_Theo_BC.Location = New System.Drawing.Point(128, 120)
        Me.cbMa_Ca_Theo_BC.Name = "cbMa_Ca_Theo_BC"
        Me.cbMa_Ca_Theo_BC.TabIndex = 58
        Me.cbMa_Ca_Theo_BC.ValueMember = "Thu_Tu"
        '
        'UltraLabel5
        '
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UltraLabel5.Location = New System.Drawing.Point(16, 120)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(104, 16)
        Me.UltraLabel5.TabIndex = 59
        Me.UltraLabel5.Text = "Ca kế toán"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(120, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 18)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "&Bưu cục khai thác"
        '
        'cbBuu_Cuc_Khai_Thac
        '
        Me.cbBuu_Cuc_Khai_Thac.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn5.Header.Caption = "Mã bưu cục"
        UltraGridColumn5.Header.VisiblePosition = 0
        UltraGridColumn6.Header.Caption = "Tên bưu cục"
        UltraGridColumn6.Header.VisiblePosition = 1
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn5, UltraGridColumn6})
        Me.cbBuu_Cuc_Khai_Thac.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.cbBuu_Cuc_Khai_Thac.DisplayMember = ""
        Me.cbBuu_Cuc_Khai_Thac.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cbBuu_Cuc_Khai_Thac.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBuu_Cuc_Khai_Thac.Location = New System.Drawing.Point(232, 80)
        Me.cbBuu_Cuc_Khai_Thac.Name = "cbBuu_Cuc_Khai_Thac"
        Me.cbBuu_Cuc_Khai_Thac.TabIndex = 57
        Me.cbBuu_Cuc_Khai_Thac.ValueMember = ""
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(16, 184)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(80, 23)
        Me.UltraLabel3.TabIndex = 54
        Me.UltraLabel3.Text = "Đến Ngày"
        '
        'cb_Den_Ngay
        '
        Me.cb_Den_Ngay.DateTime = New Date(2008, 9, 16, 0, 0, 0, 0)
        Me.cb_Den_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.cb_Den_Ngay.Location = New System.Drawing.Point(128, 184)
        Me.cb_Den_Ngay.Name = "cb_Den_Ngay"
        Me.cb_Den_Ngay.Size = New System.Drawing.Size(100, 21)
        Me.cb_Den_Ngay.TabIndex = 55
        Me.cb_Den_Ngay.Value = New Date(2008, 9, 16, 0, 0, 0, 0)
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(16, 152)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(80, 23)
        Me.UltraLabel4.TabIndex = 52
        Me.UltraLabel4.Text = "Từ Ngày"
        '
        'cb_Tu_Ngay
        '
        Me.cb_Tu_Ngay.DateTime = New Date(2008, 9, 16, 0, 0, 0, 0)
        Me.cb_Tu_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.cb_Tu_Ngay.Location = New System.Drawing.Point(128, 152)
        Me.cb_Tu_Ngay.Name = "cb_Tu_Ngay"
        Me.cb_Tu_Ngay.Size = New System.Drawing.Size(100, 21)
        Me.cb_Tu_Ngay.TabIndex = 53
        Me.cb_Tu_Ngay.Value = New Date(2008, 9, 16, 0, 0, 0, 0)
        '
        'chk_Truyen_Theo_Ca
        '
        Me.chk_Truyen_Theo_Ca.Location = New System.Drawing.Point(256, 112)
        Me.chk_Truyen_Theo_Ca.Name = "chk_Truyen_Theo_Ca"
        Me.chk_Truyen_Theo_Ca.Size = New System.Drawing.Size(115, 25)
        Me.chk_Truyen_Theo_Ca.TabIndex = 51
        Me.chk_Truyen_Theo_Ca.Text = "Truyền Theo Ca"
        '
        'CbMa_Ca
        '
        Me.CbMa_Ca.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn7.Header.VisiblePosition = 0
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.Caption = "Bưu cục khai thác"
        UltraGridColumn8.Header.VisiblePosition = 1
        UltraGridColumn8.Hidden = True
        Appearance7.FontData.BoldAsString = "True"
        UltraGridColumn9.Header.Appearance = Appearance7
        UltraGridColumn9.Header.Caption = "Ca"
        UltraGridColumn9.Header.VisiblePosition = 2
        UltraGridColumn9.Width = 30
        Appearance8.FontData.BoldAsString = "True"
        Appearance8.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn10.Header.Appearance = Appearance8
        UltraGridColumn10.Header.Caption = "Tên ca"
        UltraGridColumn10.Header.VisiblePosition = 3
        UltraGridColumn10.Width = 70
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10})
        UltraGridBand3.SummaryFooterCaption = "Grand Summaries"
        Me.CbMa_Ca.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Appearance9.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance9.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance9.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance9.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.CbMa_Ca.DisplayLayout.Override.HeaderAppearance = Appearance9
        Me.CbMa_Ca.DisplayMember = "Ca"
        Me.CbMa_Ca.LimitToList = True
        Me.CbMa_Ca.Location = New System.Drawing.Point(360, 184)
        Me.CbMa_Ca.Name = "CbMa_Ca"
        Me.CbMa_Ca.Size = New System.Drawing.Size(104, 21)
        Me.CbMa_Ca.TabIndex = 48
        Me.CbMa_Ca.ValueMember = "Thu_Tu"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UltraLabel2.Location = New System.Drawing.Point(256, 184)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(104, 16)
        Me.UltraLabel2.TabIndex = 50
        Me.UltraLabel2.Text = "Ca kế toán"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UltraLabel1.Location = New System.Drawing.Point(256, 152)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(104, 16)
        Me.UltraLabel1.TabIndex = 49
        Me.UltraLabel1.Text = "Ngày kế toán"
        '
        'CbNgay_Kt
        '
        Me.CbNgay_Kt.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.CbNgay_Kt.Location = New System.Drawing.Point(360, 152)
        Me.CbNgay_Kt.Name = "CbNgay_Kt"
        Me.CbNgay_Kt.Size = New System.Drawing.Size(104, 21)
        Me.CbNgay_Kt.TabIndex = 47
        '
        'lblTien_Trinh
        '
        Me.lblTien_Trinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTien_Trinh.Location = New System.Drawing.Point(0, 312)
        Me.lblTien_Trinh.Name = "lblTien_Trinh"
        Me.lblTien_Trinh.Size = New System.Drawing.Size(480, 16)
        Me.lblTien_Trinh.TabIndex = 71
        Me.lblTien_Trinh.Text = "Tiến trình thực hiện"
        '
        'lblNgay_Truyen
        '
        Me.lblNgay_Truyen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNgay_Truyen.Location = New System.Drawing.Point(0, 288)
        Me.lblNgay_Truyen.Name = "lblNgay_Truyen"
        Me.lblNgay_Truyen.Size = New System.Drawing.Size(472, 16)
        Me.lblNgay_Truyen.TabIndex = 73
        Me.lblNgay_Truyen.Text = "Ngày Truyền"
        '
        'btnTruyenExcel
        '
        Appearance10.Image = CType(resources.GetObject("Appearance10.Image"), Object)
        Me.btnTruyenExcel.Appearance = Appearance10
        Me.btnTruyenExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTruyenExcel.ImageSize = New System.Drawing.Size(30, 25)
        Me.btnTruyenExcel.Location = New System.Drawing.Point(160, 224)
        Me.btnTruyenExcel.Name = "btnTruyenExcel"
        Me.btnTruyenExcel.Size = New System.Drawing.Size(160, 40)
        Me.btnTruyenExcel.TabIndex = 74
        Me.btnTruyenExcel.Text = "Truyền Excel"
        '
        'Frm_Truyen_Predes_Resdes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(478, 373)
        Me.Controls.Add(Me.btnTruyenExcel)
        Me.Controls.Add(Me.lblNgay_Truyen)
        Me.Controls.Add(Me.PrbTien_Trinh)
        Me.Controls.Add(Me.LbThong_Tin)
        Me.Controls.Add(Me.lblTien_Trinh)
        Me.Controls.Add(Me.BtnThoat)
        Me.Controls.Add(Me.BtnTruyen_EDI)
        Me.Controls.Add(Me.chk_Truyen_Theo_Ca)
        Me.Controls.Add(Me.CbMa_Ca)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.CbNgay_Kt)
        Me.Controls.Add(Me.cb_Den_Ngay)
        Me.Controls.Add(Me.UltraLabel4)
        Me.Controls.Add(Me.cb_Tu_Ngay)
        Me.Controls.Add(Me.cbMa_Ca_Theo_BC)
        Me.Controls.Add(Me.UltraLabel5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbBuu_Cuc_Khai_Thac)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Name = "Frm_Truyen_Predes_Resdes"
        Me.Text = "Truyền Predes Resdes"
        CType(Me.cbMa_Ca_Theo_BC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbBuu_Cuc_Khai_Thac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_Den_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_Tu_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbMa_Ca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbNgay_Kt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region "Khai báo các biến cục bộ trong Form"
    Dim myColumn As Infragistics.Win.UltraWinGrid.UltraGridColumn = Nothing
    Private myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Dim myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Dim myMa_Ca As New Ma_Ca(GConnectionString)
    Dim myHam_Dung_Chung As New Ham_Dung_Chung
    Dim myE2_Den As New E2_Den(GConnectionString)
    Dim myE2_Di As New E2_Di(GConnectionString)
    Dim myE1_Den As New E1_Den(GConnectionString)
    'Dim myEDI As New EDI(GConnectionString)
    Dim myE1_Di As New E1_Di(GConnectionString)
    Dim myKe_Toan_Ca As New Ke_Toan_Ca(GConnectionString)
    Dim myUtility As New Ems_Utility.Ems_Utility.Ems_MSMQ(GConnectionString)
#End Region

#Region "DataGridMa_Ca"
    Private Sub DataGridMa_Ca()
        Try
            CbMa_Ca.DataSource = myMa_Ca.Lay_Boi_Ma_Bc_Khai_Thac(GBuu_Cuc_Khai_Thac)
            CbMa_Ca.DataBind()
            If CbMa_Ca.Rows.Count > 0 Then
                CbMa_Ca.Value = CbMa_Ca.Rows(0).Cells("Thu_Tu").Value
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "BtnThoat_Click"
    Private Sub BtnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnThoat.Click
        Try
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "FrmKhoaSoLieu_Load"
    Private Sub FrmKhoaSoLieu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Text = "Truyền số liệu Predes, Resdes"
            Dim myMa_Bc_Khai_Thac As New Ma_Bc_Khai_Thac(GConnectionString)
            cbBuu_Cuc_Khai_Thac.DataSource = myMa_Bc_Khai_Thac.Danh_Sach_Login().Tables(0)
            cbBuu_Cuc_Khai_Thac.DataBind()
            If cbBuu_Cuc_Khai_Thac.Rows.Count > 0 Then
                cbBuu_Cuc_Khai_Thac.Value = GBuu_Cuc_Khai_Thac
            End If
            Dim Buu_Cuc_Khai_Thac As Integer = GBuu_Cuc_Khai_Thac
            'cbMa_Ca
            CbMa_Ca.DataSource = myMa_Ca.Lay_Boi_Ma_Bc_Khai_Thac(Buu_Cuc_Khai_Thac)
            CbMa_Ca.DataBind()
            If CbMa_Ca.Rows.Count > 0 Then
                CbMa_Ca.Value = CbMa_Ca.Rows(0).Cells("Thu_Tu").Value
            End If
            'cbMa_Ca_Theo_BC
            cbMa_Ca_Theo_BC.DataSource = myMa_Ca.Lay_Boi_Ma_Bc_Khai_Thac(Buu_Cuc_Khai_Thac)
            cbMa_Ca_Theo_BC.DataBind()
            If cbMa_Ca_Theo_BC.Rows.Count > 0 Then
                cbMa_Ca_Theo_BC.Value = cbMa_Ca_Theo_BC.Rows(0).Cells("Thu_Tu").Value
            End If

            chk_Truyen_Theo_Ca.Checked = False
            cb_Tu_Ngay.Value = Today
            cb_Den_Ngay.Value = Today
            chk_Truyen_Theo_Ca_CheckedChanged(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "OptDu_Lieu_Di_Den_CheckedChanged"
    Private Sub OptDu_Lieu_Di_Den_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "BtnTruyen_EDI_Click"
    Private Sub BtnTruyen_EDI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTruyen_EDI.Click
        Try
            If chk_Truyen_Theo_Ca.Checked = True Then 'Truyền theo ca
                Dim Id_Ca As String
                Dim Ngay_Khai_Thac As Integer
                Dim Ma_Ca As Integer
                Dim Bc_Khai_Thac As Integer
                Bc_Khai_Thac = CInt(cbBuu_Cuc_Khai_Thac.Value)
                Ngay_Khai_Thac = myHam_Dung_Chung.ConvertDateToInt(CbNgay_Kt.Value)
                lblNgay_Truyen.Text = myHam_Dung_Chung.ConvertIntToDate_VN(Ngay_Khai_Thac)
                Ma_Ca = CInt(CbMa_Ca.Value)
                'Lấy mã ca
                Id_Ca = CreateId_Ca(Bc_Khai_Thac, Ngay_Khai_Thac, Ma_Ca)
                'Truyền Predes
                Danh_Sach_Chuyen_Thu_Can_Truyen_Predes_Trong_Ca(Id_Ca)
                'Truyền Resdes
                Danh_Sach_Chuyen_Thu_Can_Truyen_Resdes_Trong_Ca(Id_Ca)
            Else 'Truyền từ ngày đến ngày
                Dim Bc_Khai_Thac As Integer
                Dim Ma_Ca As Integer
                Dim Tu_Ngay As Integer
                Dim Den_Ngay As Integer
                Dim Id_Ca As String
                Dim Ngay_Khai_Thac As Integer
                Bc_Khai_Thac = CInt(cbBuu_Cuc_Khai_Thac.Value)
                Ma_Ca = CInt(cbMa_Ca_Theo_BC.Value)
                Tu_Ngay = myHam_Dung_Chung.ConvertDateToInt(cb_Tu_Ngay.Value)
                Den_Ngay = myHam_Dung_Chung.ConvertDateToInt(cb_Den_Ngay.Value)
                If Tu_Ngay > Den_Ngay Then
                    MessageBox.Show("Giá trị đến ngày không được nhỏ hơn từ ngày!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If
                Ngay_Khai_Thac = Tu_Ngay
                While Ngay_Khai_Thac <= Den_Ngay
                    lblNgay_Truyen.Text = myHam_Dung_Chung.ConvertIntToDate_VN(Ngay_Khai_Thac)
                    'Lấy mã ca
                    Id_Ca = CreateId_Ca(Bc_Khai_Thac, Ngay_Khai_Thac, Ma_Ca)
                    'Truyền Predes
                    Danh_Sach_Chuyen_Thu_Can_Truyen_Predes_Trong_Ca(Id_Ca)
                    'Truyền Resdes
                    Danh_Sach_Chuyen_Thu_Can_Truyen_Resdes_Trong_Ca(Id_Ca)
                    'Cộng thêm 1 ngày
                    Tu_Ngay = myHam_Dung_Chung.AddIntDate(Ngay_Khai_Thac, 1)
                    Ngay_Khai_Thac = Tu_Ngay
                End While
            End If
            lblNgay_Truyen.Text = "Đã truyền xong"
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "CbMa_Ca_ValueChanged"
    Private Sub CbMa_Ca_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbMa_Ca.ValueChanged
        Try
            Dim Id_Ca As String
            Id_Ca = CreateId_Ca(GBuu_Cuc_Khai_Thac, myHam_Dung_Chung.ConvertDateToInt(CbNgay_Kt.Value), CbMa_Ca.Value)
            If myE1_Den.Lay_Boi_Ca_San_Xuat(Id_Ca).Tables(0).Rows.Count = 0 Then
                LbThong_Tin.Text = CbMa_Ca.Text & " Ngày " & DateTime.Parse(CbNgay_Kt.Value).ToString("dd/MM/yyyy") & vbNewLine & " Hiện chưa có dữ liệu"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "FrmKhoaSoLieu_KeyPress"
    Private Sub FrmKhoaSoLieu_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "CbNgay_Kt_ValueChanged"
    Private Sub CbNgay_Kt_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbNgay_Kt.ValueChanged
        Try
            CbMa_Ca_ValueChanged(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "==========Tạo bản tin Predes - Resdes và gửi lên server=========="
    Private isConnectedFtp As Boolean = False
    Private isConnectedOra As Boolean = False
    Private isConnectedSQL As Boolean = False
    Private myPredes As New Predes(GConnectionString)
    Private myEDI As New EDI(GConnectionString)
    Private myChuyen_Thu_Di As New Chuyen_Thu_Di(GConnectionString)
    Private myResdes As New Resdes(GConnectionString)
    Private myChuyen_Thu_Den As New Chuyen_Thu_Den(GConnectionString)
    Private myEdi_MailBox As New EDI_mailbox(GConnectionString)

#Region "Danh_Sach_Chuyen_Thu_Di_Trong_Ca"
    Private Function Danh_Sach_Chuyen_Thu_Can_Truyen_Predes_Trong_Ca(ByVal Id_Ca As String) As Boolean
        'Lấy ra danh sách các chuyến thư đã được đóng F trong ca để tạo bản tin Predes
        Try
            'Hien thong tin tren label Tien trinh
            lblTien_Trinh.Text = ".....Đang tạo dữ liệu PREDES......."
            lblTien_Trinh.Refresh()
            '--------------------------------------------
            Dim m_Ca_San_Xuat As New Ca_San_Xuat(GConnectionString)
            Dim m_Ca_San_Xuat_Chi_Tiet As New Ca_San_Xuat_Chi_Tiet

            Dim m_Predes As New Predes(GConnectionString)
            Dim idx As Integer
            'Tạo bản tin Predes
            Dim m_DataSet_Danh_Sach_Chuyen_Thu As New DataSet
            m_DataSet_Danh_Sach_Chuyen_Thu = myChuyen_Thu_Di.Danh_Sach_Chuyen_Thu_Da_Dong_F_Theo_Ca(Id_Ca)
            'Xu ly Process Bar
            PrbTien_Trinh.Maximum = m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows.Count
            PrbTien_Trinh.Step = 1
            PrbTien_Trinh.Value = 0
            '----------------------------------------
            If m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows.Count > 0 Then
                For idx = 0 To m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows.Count - 1
                    'Khong tao Predes cho duong thu JNE
                    If m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows(idx).Item("Id_Duong_Thu") <> "01009152490230" And m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows(idx).Item("Id_Duong_Thu") <> "07009152490230" Then
                        Dim m_Id_Chuyen_Thu As String
                        m_Id_Chuyen_Thu = m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows(idx).Item("Id_Chuyen_Thu")

                        'Hien thong tin tren label Tien trinh
                        lblTien_Trinh.Text = ".....Đang tạo dữ liệu PREDES.....Id_Chuyen_Thu :  " & m_Id_Chuyen_Thu
                        lblTien_Trinh.Refresh()
                        '--------------------------------------------

                        'Dim m_EDI_detail As EDI_detail

                        If myEDI.Get_EDI(m_Id_Chuyen_Thu).ID_DUONG_THU = "" Then 'Chưa tạo Predes
                            Predes(m_Id_Chuyen_Thu)
                        End If
                    End If
                    'Next process value
                    PrbTien_Trinh.PerformStep()
                    '----------------------------------------
                    'Refresh form
                    Application.DoEvents()
                    '----------------------------------------
                Next
            End If
            'Hien thong tin tren label Tien trinh
            lblTien_Trinh.Text = "Đã tạo xong PREDES.......Đang gửi File Predes lên FTP Server......"
            lblTien_Trinh.Refresh()
            '--------------------------------------------
            'Connect FTP Server
            Dim ftpUp As New FTP.FTPLib.FTP
            'Lấy dữ liệu trong bảng
            Dim m_FTP_Table As New FTP_Table(GConnectionString)
            Dim m_FTP_Table_Chi_Tiet As New FTP_Table_Chi_Tiet
            m_FTP_Table_Chi_Tiet = m_FTP_Table.FTP_Lay_Dong_Dau_Tien

            Dim Ftp_Server As String = m_FTP_Table_Chi_Tiet.SERVER '"192.168.68.9"
            Dim Ftp_Username As String = m_FTP_Table_Chi_Tiet.USERNAME ' "ems"
            Dim Ftp_Password As String = m_FTP_Table_Chi_Tiet.PASSWORD ' "ems"
            Dim Ftp_Upload As String = m_FTP_Table_Chi_Tiet.UPLOAD

            Try
                ftpUp.Connect(Ftp_Server, Ftp_Username, Ftp_Password)
                ftpUp.ChangeDir("\\" + Ftp_Upload)
                isConnectedFtp = True
            Catch ex As Exception
                MessageBox.Show("Kết nối không thành công. Chi tiết: " & ex.Message)
            End Try

            'Lấy ngày khai thác làm thư mục để Move dữ liệu
            Dim m_Folder_Ngay_Khai_Thac As String = m_Ca_San_Xuat.Lay(Id_Ca).Ngay_Khai_Thac.ToString
            'Tạo Folder mới để chứa dữ liệu của ngày khai thác
            Dim m_Source_Path As String = Application.StartupPath & "\PREDES\"
            If Directory.Exists(m_Source_Path) = False Then
                Directory.CreateDirectory(m_Source_Path)
            End If
            'Create Destination_Path
            Dim m_Destination_Path As String = Application.StartupPath & "\PREDES\" & m_Folder_Ngay_Khai_Thac
            If Directory.Exists(m_Destination_Path) = False Then
                Directory.CreateDirectory(m_Destination_Path)
            End If

            'Lấy danh sách các File bản tin đã được tạo ra trên máy và chưa được gửi đi
            Dim m_Predes_UnSending As DataSet = m_Predes.Danh_Sach_Predes_UnSending()
            'Xu ly Process Bar
            PrbTien_Trinh.Maximum = m_Predes_UnSending.Tables(0).Rows.Count
            PrbTien_Trinh.Step = 1
            PrbTien_Trinh.Value = 0
            '----------------------------------------
            If m_Predes_UnSending.Tables(0).Rows.Count > 0 Then
                For idx = 0 To m_Predes_UnSending.Tables(0).Rows.Count - 1
                    Dim File_Name As String = m_Predes_UnSending.Tables(0).Rows(idx).Item("MESSAGE")
                    Dim StrSrcFile As String = m_Source_Path & File_Name
                    'Dim filename As String = myPredes_Unsending.Tables(0).Rows(idx).Item("PREDES")
                    'Dim StrSrcFile As String
                    StrSrcFile = m_Source_Path & "\" & File_Name

                    If File.Exists(StrSrcFile) Then
                        Dim sFileName As String = Path.GetFileName(StrSrcFile)
                        ftpUp.OpenUpload(StrSrcFile, sFileName)
                        While (ftpUp.DoUpload() > 0) 'Upload thành công, upload toàn bộ dữ liệu
                            'Refresh form
                            Application.DoEvents()
                            '----------------------------------------
                        End While
                        'Đẩy dữ liệu thành công thì Move file vào thư mục của ngày hôm trước
                        If Move_File(File_Name, m_Source_Path, m_Destination_Path) = False Then
                            Return False
                        Else
                            'Cập nhật đã truyền đối với chuyến thư
                            Dim m_Id_Chuyen_Thu As String = m_Predes_UnSending.Tables(0).Rows(idx).Item("ID_CHUYEN_THU")
                            Dim m_Id_Duong_Thu As String = m_Predes_UnSending.Tables(0).Rows(idx).Item("ID_DUONG_THU")
                            Dim m_Intref As String = m_Predes_UnSending.Tables(0).Rows(idx).Item("INTREF")
                            Dim m_Ngay As Integer = CInt(m_Predes_UnSending.Tables(0).Rows(idx).Item("NGAY"))
                            Dim m_Gio As Integer = CInt(m_Predes_UnSending.Tables(0).Rows(idx).Item("GIO"))
                            'Update Send = 1
                            m_Predes.PREDES_Cap_Nhat_Them(m_Id_Chuyen_Thu, m_Id_Duong_Thu, m_Intref, m_Ngay, m_Gio, File_Name, 1)
                        End If
                    End If
                    'Next process value
                    PrbTien_Trinh.PerformStep()
                    '----------------------------------------
                    'Refresh form
                    Application.DoEvents()
                    '----------------------------------------
                Next
            End If
            'Hien thong tin tren label Tien trinh
            lblTien_Trinh.Text = "Đã gửi hết các File PREDES......"
            lblTien_Trinh.Refresh()
            '--------------------------------------------
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Function
#End Region

#Region "Danh_Sach_Chuyen_Thu_Den_Trong_Ca"
    Private Function Danh_Sach_Chuyen_Thu_Can_Truyen_Resdes_Trong_Ca(ByVal Id_Ca As String) As Boolean
        'Lấy ra danh sách các chuyến thư đã được đóng F trong ca để tạo bản tin Predes
        Try
            'Hien thong tin tren label Tien trinh
            lblTien_Trinh.Text = ".....Đang tạo dữ liệu RESDES......."
            lblTien_Trinh.Refresh()
            '--------------------------------------------
            Dim m_Ca_San_Xuat As New Ca_San_Xuat(GConnectionString)
            Dim m_Ca_San_Xuat_Chi_Tiet As New Ca_San_Xuat_Chi_Tiet

            Dim m_Resdes As New Resdes(GConnectionString)
            Dim idx As Integer
            'Tạo bản tin Predes
            Dim m_DataSet_Danh_Sach_Chuyen_Thu As New DataSet
            m_DataSet_Danh_Sach_Chuyen_Thu = myChuyen_Thu_Den.Danh_Sach_Chuyen_Thu_Den_Theo_Ca(Id_Ca)
            'Xu ly Process Bar
            PrbTien_Trinh.Maximum = m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows.Count
            PrbTien_Trinh.Step = 1
            PrbTien_Trinh.Value = 0
            '----------------------------------------
            If m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows.Count > 0 Then
                For idx = 0 To m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows.Count - 1
                    Dim m_Id_Chuyen_Thu As String
                    m_Id_Chuyen_Thu = m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows(idx).Item("Id_Chuyen_Thu")

                    'Hien thong tin tren label Tien trinh
                    lblTien_Trinh.Text = ".....Đang tạo dữ liệu RESDES.....Id_Chuyen_Thu :  " & m_Id_Chuyen_Thu
                    lblTien_Trinh.Refresh()
                    '--------------------------------------------

                    'If m_Resdes.res.PREDES_Lay(m_Id_Chuyen_Thu).ID_DUONG_THU = "" Then 'Chưa tạo Predes
                    Resdes(m_Id_Chuyen_Thu)
                    'End If
                    'Next process value
                    PrbTien_Trinh.PerformStep()
                    '----------------------------------------
                    'Refresh form
                    Application.DoEvents()
                    '----------------------------------------
                Next
            End If
            'Hien thong tin tren label Tien trinh
            lblTien_Trinh.Text = "Đã tạo xong RESDES.......Đang gửi File Resdes lên FTP Server......"
            lblTien_Trinh.Refresh()
            '--------------------------------------------
            'Connect FTP Server
            Dim ftpUp As New FTP.FTPLib.FTP
            'Lấy dữ liệu trong bảng
            Dim m_FTP_Table As New FTP_Table(GConnectionString)
            Dim m_FTP_Table_Chi_Tiet As New FTP_Table_Chi_Tiet
            m_FTP_Table_Chi_Tiet = m_FTP_Table.FTP_Lay_Dong_Dau_Tien

            Dim Ftp_Server As String = m_FTP_Table_Chi_Tiet.SERVER '"192.168.68.9"
            Dim Ftp_Username As String = m_FTP_Table_Chi_Tiet.USERNAME ' "ems"
            Dim Ftp_Password As String = m_FTP_Table_Chi_Tiet.PASSWORD ' "ems"
            Dim Ftp_Upload As String = m_FTP_Table_Chi_Tiet.UPLOAD

            Try
                ftpUp.Connect(Ftp_Server, Ftp_Username, Ftp_Password)
                ftpUp.ChangeDir("\\" + Ftp_Upload)
                isConnectedFtp = True
            Catch ex As Exception
                MessageBox.Show("Kết nối không thành công. Chi tiết: " & ex.Message)
            End Try

            'Lấy ngày khai thác làm thư mục để Move dữ liệu
            Dim m_Folder_Ngay_Khai_Thac As String = m_Ca_San_Xuat.Lay(Id_Ca).Ngay_Khai_Thac.ToString
            'Tạo Folder mới để chứa dữ liệu của ngày khai thác
            Dim m_Source_Path As String = Application.StartupPath & "\RESDES\"
            If Directory.Exists(m_Source_Path) = False Then
                Directory.CreateDirectory(m_Source_Path)
            End If
            'Create Destination_Path
            Dim m_Destination_Path As String = Application.StartupPath & "\RESDES\" & m_Folder_Ngay_Khai_Thac
            If Directory.Exists(m_Destination_Path) = False Then
                Directory.CreateDirectory(m_Destination_Path)
            End If

            'Lấy danh sách các File bản tin đã được tạo ra trên máy và chưa được gửi đi
            Dim m_Resdes_UnSending As DataSet = m_Resdes.Danh_Sach_Resdes_UnSending()
            'Xu ly Process Bar
            PrbTien_Trinh.Maximum = m_Resdes_UnSending.Tables(0).Rows.Count
            PrbTien_Trinh.Step = 1
            PrbTien_Trinh.Value = 0
            '----------------------------------------
            If m_Resdes_UnSending.Tables(0).Rows.Count > 0 Then
                For idx = 0 To m_Resdes_UnSending.Tables(0).Rows.Count - 1
                    Dim File_Name As String = m_Resdes_UnSending.Tables(0).Rows(idx).Item("MESSAGE")
                    Dim StrSrcFile As String = m_Source_Path & File_Name
                    'Dim filename As String = myPredes_Unsending.Tables(0).Rows(idx).Item("PREDES")
                    'Dim StrSrcFile As String
                    StrSrcFile = m_Source_Path & "\" & File_Name

                    If File.Exists(StrSrcFile) Then
                        Dim sFileName As String = Path.GetFileName(StrSrcFile)
                        ftpUp.OpenUpload(StrSrcFile, sFileName)
                        While (ftpUp.DoUpload() > 0) 'Upload thành công, upload toàn bộ dữ liệu
                            'Refresh form
                            Application.DoEvents()
                            '----------------------------------------
                        End While
                        'Đẩy dữ liệu thành công thì Move file vào thư mục của ngày hôm trước
                        If Move_File(File_Name, m_Source_Path, m_Destination_Path) = False Then
                            Return False
                        Else
                            'Cập nhật đã truyền đối với chuyến thư
                            Dim m_Id_Chuyen_Thu As String = m_Resdes_UnSending.Tables(0).Rows(idx).Item("ID_CHUYEN_THU")
                            Dim m_Id_Duong_Thu As String = m_Resdes_UnSending.Tables(0).Rows(idx).Item("ID_DUONG_THU")
                            Dim m_Intref As String = m_Resdes_UnSending.Tables(0).Rows(idx).Item("INTREF")
                            Dim m_Ngay As Integer = CInt(m_Resdes_UnSending.Tables(0).Rows(idx).Item("NGAY"))
                            Dim m_Gio As Integer = CInt(m_Resdes_UnSending.Tables(0).Rows(idx).Item("GIO"))
                            'Update Send = 1
                            m_Resdes.RESDES_Cap_Nhat_Them(m_Id_Chuyen_Thu, m_Id_Duong_Thu, m_Intref, m_Ngay, m_Gio, File_Name, 1)
                        End If
                    End If
                    'Next process value
                    PrbTien_Trinh.PerformStep()
                    '----------------------------------------
                    'Refresh form
                    Application.DoEvents()
                    '----------------------------------------
                Next
            End If
            'Hien thong tin tren label Tien trinh
            lblTien_Trinh.Text = "Đã gửi hết các File RESDES......"
            lblTien_Trinh.Refresh()
            '--------------------------------------------
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Function
#End Region

#Region "Tạo bản tin Predes cho từng chuyến thư"
    Private Function Resdes(ByVal Id_Chuyen_Thu As String) As Boolean
        Try
            Dim Chuyen_Thu_Den_Chi_Tiet As New Chuyen_Thu_Den_Chi_Tiet
            Chuyen_Thu_Den_Chi_Tiet = myChuyen_Thu_Den.Lay(Id_Chuyen_Thu)
            'If myResdes.RESDES_Lay(Id_Chuyen_Thu).ID_DUONG_THU <> "" Then 'Đã tạo Predes
            '    'Nếu đã có thì không tạo lại
            '    Exit Function
            'End If

            'Lay nước đóng chuyến thư và IPMC theo id_duong_thu

            Dim sb As System.Text.StringBuilder = New StringBuilder
            Dim myIPMC_MaNC As New IPMC_MaNC
            myIPMC_MaNC = myEdi_MailBox.Get_IPMC_MaNC(Chuyen_Thu_Den_Chi_Tiet.Id_Duong_Thu, "RESDES")

            'Xác định xem nứơc đó có thực hiện việc trao đổi thông tin chuyến thư hay ko.
            Dim myMailBox As New MailBox
            myMailBox = myEdi_MailBox.Get_MailBox(myIPMC_MaNC.Ma_NC)
            'If (myEDI_MAILBOX.EVENT_SEND = 1) Then

            'End If

            If (myMailBox.RESDES_SEND = 1) Then
                Dim myResdes_UNB As New Resdes_UNB
                myResdes_UNB = myResdes.Get_UNB(myMailBox, myMailBox.RESDES_INTREF)
                Dim segs_number As Int32
                'UNB
                'ghi file UNB
                sb.Append("UNB+")
                sb.Append(myResdes_UNB.UNB_S001.ToString())
                sb.Append("+")
                sb.Append(myResdes_UNB.UNB_S002.ToString())
                sb.Append("+")
                sb.Append(myResdes_UNB.UNB_S003.ToString())
                sb.Append("+")
                sb.Append(myResdes_UNB.UNB_S004.ToString())
                sb.Append("+")
                sb.Append(myResdes_UNB.UNB_S005.ToString())
                sb.Append("'")
                segs_number = 1

                'UNH
                Dim myResdes_UNH As New Resdes_UNH
                myResdes_UNH = myResdes.Get_UNH()

                'ghi file UNH
                sb.Append("UNH+")
                sb.Append(myResdes_UNH.UNH_0062.ToString())
                sb.Append("+")
                sb.Append(myResdes_UNH.UNH_S009.ToString())
                sb.Append("'")
                segs_number = segs_number + 1

                'Dispath Information
                Dim myResdes_Dis_Inf As New Resdes_Dispatch_Information
                myResdes_Dis_Inf = myResdes.Get_Resdes_Dispatch_Information(Chuyen_Thu_Den_Chi_Tiet.Id_Chuyen_Thu, myEdi_MailBox)

                'BGM
                Dim myResdes_BGM As New Resdes_BGM
                myResdes_BGM = myResdes.Get_BGM(myResdes_Dis_Inf.Ma_BC_KT, myResdes_Dis_Inf.Ma_BC, myResdes_Dis_Inf.Phan_loai, myResdes_Dis_Inf.Ngay_dong, myResdes_Dis_Inf.So_Chuyen_thu)
                'ghi file BGM
                sb.Append("BGM+")
                sb.Append(myResdes_BGM.BGM_C002.ToString())
                sb.Append("+")
                sb.Append(myResdes_BGM.BGM_1004.ToString())

                If myResdes_BGM.BGM_C507.ToString() <> "" Then
                    sb.Append("+")
                    sb.Append(myResdes_BGM.BGM_C507.ToString())
                End If
                If myResdes_BGM.BGM_1225.ToString() <> "" Then
                    sb.Append("+")
                    sb.Append(myResdes_BGM.BGM_1225.ToString())
                End If
                If myResdes_BGM.BGM_C506.ToString() <> "" Then
                    sb.Append("+")
                    sb.Append(myResdes_BGM.BGM_C506.ToString())
                End If
                If myResdes_BGM.BGM_C507.ToString() <> "" Then
                    sb.Append("+")
                    sb.Append(myResdes_BGM.BGM_C507.ToString())
                End If
                If myResdes_BGM.BGM_4343.ToString() <> "" Then
                    sb.Append("+")
                    sb.Append(myResdes_BGM.BGM_4343.ToString())
                End If
                sb.Append("'")
                segs_number = segs_number + 1

                'PCI(+++CW) : JPKIXAVNSGNBAEM93122001000066() '
                'RFF+ACU:20'
                'DTM+7:0904230957:201'
                Dim m_DataSet_Danh_Sach_E2 As New DataSet
                m_DataSet_Danh_Sach_E2 = myE2_Den.Lay_Boi_Chuyen_Thu_Den(Id_Chuyen_Thu)
                Dim idx As Integer
                For idx = 0 To m_DataSet_Danh_Sach_E2.Tables(0).Rows.Count - 1
                    'GID
                    Dim myResdes_GID As New Resdes_GID
                    myResdes_GID = myResdes.Get_GID()
                    sb.Append("GID+")
                    sb.Append(myResdes_GID.GID_1496.ToString())
                    sb.Append("+")
                    sb.Append(myResdes_GID.GID_C213.ToString())
                    sb.Append("'")
                    segs_number = segs_number + 1

                    Dim myResdes_PCI As New Resdes_PCI
                    'Lay thong tin ma vach tui
                    Dim myE2_Den_Ma_Vach_Tui As New E2_Den_Ma_Vach_Tui(GConnectionString)
                    Dim strMaSoTui As String = myE2_Den_Ma_Vach_Tui.E2_Den_Ma_Vach_Tui_Lay(m_DataSet_Danh_Sach_E2.Tables(0).Rows(idx).Item("Id_E2")).Ma_Vach_Tui
                    '---------------------------------------------------
                    myResdes_PCI = myResdes.Get_PCI(myResdes_Dis_Inf.So_Chuyen_thu, m_DataSet_Danh_Sach_E2.Tables(0).Rows(idx).Item("Tui_so"), m_DataSet_Danh_Sach_E2.Tables(0).Rows(idx).Item("Khoi_Luong_BP"), m_DataSet_Danh_Sach_E2.Tables(0).Rows(idx).Item("Khoi_Luong_Vo_Tui"), myResdes_Dis_Inf.Ma_BC_KT.ToString(), myResdes_Dis_Inf.Ma_BC.ToString(), myResdes_Dis_Inf.Phan_loai, m_DataSet_Danh_Sach_E2.Tables(0).Rows(idx).Item("Ngay_dong"), m_DataSet_Danh_Sach_E2.Tables(0).Rows(idx).Item("Tui_F"), myIPMC_MaNC.Ma_NC.ToString(), strMaSoTui.Trim())
                    sb.Append("PCI+")
                    sb.Append(myResdes_PCI.PCI_4233.ToString())
                    sb.Append("+")
                    sb.Append(myResdes_PCI.PCI_C210.ToString())
                    sb.Append("+")
                    sb.Append(myResdes_PCI.PCI_C506.ToString())
                    sb.Append("'")
                    segs_number = segs_number + 1

                    sb.Append("RFF+ACU:20")
                    sb.Append("'")
                    segs_number = segs_number + 1

                    'DTM
                    Dim myResdes_DTM As New Resdes_DTM
                    myResdes_DTM = myResdes.Get_DTM(myResdes_Dis_Inf.Ngay_dong, myResdes_Dis_Inf.Gio_dong)

                    'ghi file DTM
                    sb.Append("DTM+")
                    sb.Append(myResdes_DTM.DTM_C507.ToString())
                    sb.Append("'")
                    segs_number = segs_number + 1
                Next

                Dim myResdes_UNT As Resdes_UNT
                myResdes_UNT = myResdes.Get_UNT(segs_number, myResdes_UNH.UNH_0062)
                sb.Append("UNT+")
                sb.Append(myResdes_UNT.UNT_0074.ToString())
                sb.Append("+")
                sb.Append(myResdes_UNT.UNT_0062.ToString())
                sb.Append("'")

                Dim myResdes_UNZ As Resdes_UNZ
                myResdes_UNZ = myResdes.Get_UNZ(myResdes_UNB.UNB_S005)
                sb.Append("UNZ+")
                sb.Append(myResdes_UNZ.UNZ_0036.ToString())
                sb.Append("+")
                sb.Append(myResdes_UNZ.UNZ_0020.ToString())
                sb.Append("'")

                Dim file_name As String
                If Id_Chuyen_Thu.IndexOf("CN") > 0 Then
                    file_name = myIPMC_MaNC.Ma_NC.ToString().Trim() & "_RESCPS_" & myResdes_UNZ.UNZ_0020.ToString() & ".txt"
                Else
                    file_name = myIPMC_MaNC.Ma_NC.ToString().Trim() & "_RESDES_" & myResdes_UNZ.UNZ_0020.ToString() & ".txt"
                End If
                Dim path_resdes_dir As String = Application.StartupPath & "\RESDES"
                Dim path_name As String = Application.StartupPath & "\RESDES\" & file_name
                Dim objStreamWriter As StreamWriter
                If Directory.Exists(path_resdes_dir) = False Then
                    Directory.CreateDirectory(path_resdes_dir)
                End If
                objStreamWriter = New StreamWriter(path_name, True, Encoding.ASCII)

                'objStreamWriter = File.AppendText(file_name)

                objStreamWriter.Write(sb.ToString())
                objStreamWriter.Close()
                myEdi_MailBox.Update_EDI_Intref(myIPMC_MaNC.Ma_NC.ToString(), "RESDES")

                myEDI.Add_EDI(Id_Chuyen_Thu, Chuyen_Thu_Den_Chi_Tiet.Id_Duong_Thu, myResdes_UNB.UNB_S005, Int32.Parse(myResdes_UNB.UNB_0017), Int32.Parse(myResdes_UNB.UNB_0019), file_name, "RESDES")

            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        End Try
    End Function
#End Region

#Region "Tạo bản tin Predes cho từng chuyến thư"
    Private Function Predes(ByVal Id_Chuyen_Thu As String) As Boolean
        Try
            Dim Chuyen_Thu_Di_Chi_Tiet As New Chuyen_Thu_Di_Chi_Tiet
            Chuyen_Thu_Di_Chi_Tiet = myChuyen_Thu_Di.Lay(Id_Chuyen_Thu)

            'Tao PREDES - DO TIEN VIET.
            'Kiểm tra xem Predes đã được tạo ra chưa
            'If myPredes.PREDES_Lay(Id_Chuyen_Thu).ID_DUONG_THU <> "" Then 'Đã tạo Predes
            '    'Nếu đã có thì không tạo lại
            '    Exit Function
            'End If

            'Lay nước đóng chuyến thư và IPMC theo id_duong_thu

            Dim sb As System.Text.StringBuilder = New StringBuilder
            Dim myIPMC_MaNC As New IPMC_MaNC
            myIPMC_MaNC = myEdi_MailBox.Get_IPMC_MaNC(Chuyen_Thu_Di_Chi_Tiet.Id_Duong_Thu, "PREDES")

            'Xác định xem nứơc đó có thực hiện việc trao đổi thông tin chuyến thư hay ko.
            Dim myMailBox As New MailBox
            myMailBox = myEdi_MailBox.Get_MailBox(myIPMC_MaNC.Ma_NC)
            'If (myEDI_MAILBOX.EVENT_SEND = 1) Then

            'End If

            If (myMailBox.PREDES_SEND = 1) Then
                'Tao Predes
                'UNB
                Dim myPredes_UNB As New Predes_UNB
                myPredes_UNB = myPredes.Get_UNB(myMailBox, myMailBox.PREDES_INTREF)

                Dim segs_number As Int32
                'UNB
                'ghi file UNB
                sb.Append("UNB+")
                sb.Append(myPredes_UNB.UNB_S001.ToString())
                sb.Append("+")
                sb.Append(myPredes_UNB.UNB_S002.ToString())
                sb.Append("+")
                sb.Append(myPredes_UNB.UNB_S003.ToString())
                sb.Append("+")
                sb.Append(myPredes_UNB.UNB_S004.ToString())
                sb.Append("+")
                sb.Append(myPredes_UNB.UNB_S005.ToString())
                sb.Append("'")
                segs_number = 1

                'UNH
                Dim myPredes_UNH As New Predes_UNH
                myPredes_UNH = myPredes.Get_UNH()

                'ghi file UNH
                sb.Append("UNH+")
                sb.Append(myPredes_UNH.UNH_0062.ToString())
                sb.Append("+")
                sb.Append(myPredes_UNH.UNH_S009.ToString())
                sb.Append("'")
                segs_number = segs_number + 1

                'Dispath Information
                Dim myPredes_Dispatch_Information As New Predes_Dispatch_Information
                myPredes_Dispatch_Information = myPredes.Get_Predes_Dispatch_Information(Chuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu, myEdi_MailBox)

                'BGM
                Dim myPredes_BGM As New Predes_BGM
                myPredes_BGM = myPredes.Get_BGM(myPredes_Dispatch_Information.Ma_BC_KT, myPredes_Dispatch_Information.Ma_BC, myPredes_Dispatch_Information.Phan_loai, myPredes_Dispatch_Information.Ngay_dong, myPredes_Dispatch_Information.So_Chuyen_thu)
                'ghi file BGM
                sb.Append("BGM+")
                sb.Append(myPredes_BGM.BGM_C002.ToString())
                sb.Append("+")
                sb.Append(myPredes_BGM.BGM_1004.ToString())
                sb.Append("+")
                sb.Append(myPredes_BGM.BGM_C507.ToString())
                sb.Append("+")
                sb.Append(myPredes_BGM.BGM_1225.ToString())
                sb.Append("+")
                sb.Append(myPredes_BGM.BGM_C506.ToString())
                sb.Append("+")
                sb.Append(myPredes_BGM.BGM_C507.ToString())
                sb.Append("+")
                sb.Append(myPredes_BGM.BGM_4343.ToString())
                sb.Append("'")
                segs_number = segs_number + 1

                'DTM
                Dim myPredes_DTM As New Predes_DTM
                myPredes_DTM = myPredes.Get_DTM(myPredes_Dispatch_Information.Ngay_dong, myPredes_Dispatch_Information.Gio_dong)

                'ghi file DTM
                sb.Append("DTM+")
                sb.Append(myPredes_DTM.DTM_C507.ToString())
                sb.Append("'")
                segs_number = segs_number + 1

                'Ghi ra file
                'TDT
                Dim myPredes_TDT() As Predes_TDT
                myPredes_TDT = myPredes.Get_TDT(Chuyen_Thu_Di_Chi_Tiet.Id_Duong_Thu, myPredes_Dispatch_Information.Ngay_dong, myPredes_Dispatch_Information.So_Chuyen_thu)

                If myPredes_TDT(0) Is Nothing Then
                    Exit Function
                End If

                Dim ngay As String = myPredes_Dispatch_Information.Ngay_dong
                Dim gio As String = myPredes_Dispatch_Information.Gio_dong
                For i As Integer = 0 To myPredes_TDT.Length - 1
                    sb.Append("TDT+")
                    sb.Append(myPredes_TDT(i).TDT_8051.ToString())
                    sb.Append("+")
                    sb.Append(myPredes_TDT(i).TDT_8028.ToString())
                    sb.Append("+")
                    sb.Append(myPredes_TDT(i).TDT_C220.ToString())
                    sb.Append("+")
                    sb.Append(myPredes_TDT(i).TDT_C222.ToString())
                    sb.Append("+")
                    sb.Append(myPredes_TDT(i).TDT_C228.ToString())
                    sb.Append("+")
                    sb.Append(myPredes_TDT(i).TDT_C040.ToString())
                    sb.Append("'")
                    segs_number = segs_number + 1

                    Dim myPredes_Flight_Schedules As New Predes_Flight_Schedules
                    myPredes_Flight_Schedules = myPredes.Get_Flight_Schedule(myPredes_TDT(i).TDT_8028.ToString())

                    Dim myPredes_LOC As New Predes_LOC

                    myPredes_LOC = myPredes.Get_LOC(myPredes_Flight_Schedules.From_Airport, 5)
                    sb.Append("LOC+")
                    sb.Append(myPredes_LOC.LOC_3227.ToString())
                    sb.Append(":")
                    sb.Append(myPredes_LOC.LOC_3225.ToString())
                    sb.Append(":")
                    sb.Append(myPredes_LOC.LOC_1131.ToString())
                    sb.Append(":")
                    sb.Append(myPredes_LOC.LOC_3055.ToString())
                    sb.Append("'")
                    segs_number = segs_number + 1

                    If (myPredes_TDT.Length - 1 > 0) Then
                        If (i < myPredes_TDT.Length - 1) Then
                            myPredes_LOC = myPredes.Get_LOC(myPredes_Flight_Schedules.To_Airport, 13)
                            sb.Append("LOC+")
                            sb.Append(myPredes_LOC.LOC_3227.ToString())
                            sb.Append(":")
                            sb.Append(myPredes_LOC.LOC_3225.ToString())
                            sb.Append(":")
                            sb.Append(myPredes_LOC.LOC_1131.ToString())
                            sb.Append(":")
                            sb.Append(myPredes_LOC.LOC_3055.ToString())
                            sb.Append("'")
                            segs_number = segs_number + 1
                        Else
                            myPredes_LOC = myPredes.Get_LOC(myPredes_Flight_Schedules.To_Airport, 7)
                            sb.Append("LOC+")
                            sb.Append(myPredes_LOC.LOC_3227.ToString())
                            sb.Append(":")
                            sb.Append(myPredes_LOC.LOC_3225.ToString())
                            sb.Append(":")
                            sb.Append(myPredes_LOC.LOC_1131.ToString())
                            sb.Append(":")
                            sb.Append(myPredes_LOC.LOC_3055.ToString())
                            sb.Append("'")
                            segs_number = segs_number + 1
                        End If
                    Else
                        myPredes_LOC = myPredes.Get_LOC(myPredes_Flight_Schedules.To_Airport, 7)
                        sb.Append("LOC+")
                        sb.Append(myPredes_LOC.LOC_3227.ToString())
                        sb.Append(":")
                        sb.Append(myPredes_LOC.LOC_3225.ToString())
                        sb.Append(":")
                        sb.Append(myPredes_LOC.LOC_1131.ToString())
                        sb.Append(":")
                        sb.Append(myPredes_LOC.LOC_3055.ToString())
                        sb.Append("'")
                        segs_number = segs_number + 1
                    End If

                    Dim myPredes_DTM_Flight As New Predes_DTM_Flight
                    'DTM seg 1 : departure information
                    If (Int32.Parse(gio) > Int32.Parse(myPredes_Flight_Schedules.Dep_Time)) Then
                        Dim frmt As System.IFormatProvider = New System.Globalization.CultureInfo("en-US", True)
                        Dim dt As DateTime = DateTime.ParseExact(((ngay.Substring(4, 2) & "/") + ngay.Substring(6, 2) & "/") + ngay.Substring(2, 2), "MM/dd/yy", frmt)
                        Dim tmp_day As DateTime = dt.AddDays(1)
                        ngay = tmp_day.Year.ToString() + (IIf(Int32.Parse(tmp_day.Month.ToString()) > 9, tmp_day.Month.ToString(), "0" & tmp_day.Month.ToString())) + (IIf(Int32.Parse(tmp_day.Day.ToString()) > 9, tmp_day.Day.ToString(), "0" & tmp_day.Day.ToString()))
                    End If

                    myPredes_DTM_Flight = myPredes.Get_DTM_Flight(ngay, myPredes_Flight_Schedules.Dep_Time, 0, 0, 0)

                    sb.Append("DTM+")
                    sb.Append(myPredes_DTM_Flight.DTM_2005.ToString())
                    sb.Append(":")
                    sb.Append(myPredes_DTM_Flight.DTM_2380.ToString())
                    sb.Append(":")
                    sb.Append(myPredes_DTM_Flight.DTM_2379.ToString())
                    sb.Append("'")
                    segs_number = segs_number + 1

                    'DTM seg 2 : arrival information
                    myPredes_DTM_Flight = myPredes.Get_DTM_Flight(ngay, myPredes_Flight_Schedules.Arr_Time, 1, myPredes_Flight_Schedules.Over_Day, 1)
                    sb.Append("DTM+")
                    sb.Append(myPredes_DTM_Flight.DTM_2005.ToString())
                    sb.Append(":")
                    sb.Append(myPredes_DTM_Flight.DTM_2380.ToString())
                    sb.Append(":")
                    sb.Append(myPredes_DTM_Flight.DTM_2379.ToString())
                    sb.Append("'")
                    segs_number = segs_number + 1
                    gio = myPredes_Flight_Schedules.Arr_Time
                Next

                'Lay cac ban ke E2
                Dim m_DataSet_Danh_Sach_E2 As New DataSet
                m_DataSet_Danh_Sach_E2 = myE2_Di.Lay_Boi_Chuyen_Thu_Di(Id_Chuyen_Thu)
                Dim idx As Integer
                For idx = 0 To m_DataSet_Danh_Sach_E2.Tables(0).Rows.Count - 1
                    'GID
                    Dim myPredes_GID As New Predes_GID
                    myPredes_GID = myPredes.Get_GID()
                    sb.Append("GID+")
                    sb.Append(myPredes_GID.GID_1496.ToString())
                    sb.Append("+")
                    sb.Append(myPredes_GID.GID_C213.ToString())
                    sb.Append("'")
                    segs_number = segs_number + 1

                    Dim myPredes_PCI As New Predes_PCI
                    myPredes_PCI = myPredes.Get_PCI(myPredes_Dispatch_Information.So_Chuyen_thu, m_DataSet_Danh_Sach_E2.Tables(0).Rows(idx).Item("Tui_so"), m_DataSet_Danh_Sach_E2.Tables(0).Rows(idx).Item("Khoi_Luong_BP"), m_DataSet_Danh_Sach_E2.Tables(0).Rows(idx).Item("Khoi_Luong_Vo_Tui"), myPredes_Dispatch_Information.Ma_BC_KT.ToString(), myPredes_Dispatch_Information.Ma_BC.ToString(), myPredes_Dispatch_Information.Phan_loai, m_DataSet_Danh_Sach_E2.Tables(0).Rows(idx).Item("Ngay_dong"), m_DataSet_Danh_Sach_E2.Tables(0).Rows(idx).Item("Tui_F"), myIPMC_MaNC.Ma_NC.ToString())
                    sb.Append("PCI+")
                    sb.Append(myPredes_PCI.PCI_4233.ToString())
                    sb.Append("+")
                    sb.Append(myPredes_PCI.PCI_C210.ToString())
                    sb.Append("+")
                    sb.Append(myPredes_PCI.PCI_C506.ToString())
                    sb.Append("'")
                    segs_number = segs_number + 1

                    If (m_DataSet_Danh_Sach_E2.Tables(0).Rows(idx).Item("Tui_F") = -1) Then
                        sb.Append("FTX+DOC'")
                        segs_number = segs_number + 1
                    End If

                    Dim m_DataSet_Danh_Sach_E1 As New DataSet
                    'Lay E1 cua ban ke E2
                    m_DataSet_Danh_Sach_E1 = myE1_Di.E1_Di_Lay_Boi_E2_Di_KT(m_DataSet_Danh_Sach_E2.Tables(0).Rows(idx).Item("Id_E2"))
                    For i As Integer = 0 To m_DataSet_Danh_Sach_E1.Tables(0).Rows.Count - 1
                        sb.Append("GDS+")
                        sb.Append("1:" & m_DataSet_Danh_Sach_E1.Tables(0).Rows(i).Item("MA_E1"))
                        sb.Append("'")
                        segs_number = segs_number + 1

                        sb.Append("MEA+")
                        sb.Append("WT+AAA+KGM:" & Decimal.Parse(m_DataSet_Danh_Sach_E1.Tables(0).Rows(i).Item("KHOI_LUONG")) / 1000)
                        sb.Append("'")
                        segs_number = segs_number + 1
                    Next
                Next

                Dim myPredes_UNT As Predes_UNT
                myPredes_UNT = myPredes.Get_UNT(segs_number, myPredes_UNH.UNH_0062)
                sb.Append("UNT+")
                sb.Append(myPredes_UNT.UNT_0074.ToString())
                sb.Append("+")
                sb.Append(myPredes_UNT.UNT_0062.ToString())
                sb.Append("'")

                Dim myPredes_UNZ As Predes_UNZ
                myPredes_UNZ = myPredes.Get_UNZ(myPredes_UNB.UNB_S005)
                sb.Append("UNZ+")
                sb.Append(myPredes_UNZ.UNZ_0036.ToString())
                sb.Append("+")
                sb.Append(myPredes_UNZ.UNZ_0020.ToString())
                sb.Append("'")

                Dim file_name As String = myIPMC_MaNC.Ma_NC.ToString().Trim() & "_PREDES_" & myPredes_UNZ.UNZ_0020.ToString() & ".txt"
                Dim path_predes_dir As String = Application.StartupPath & "\PREDES"
                Dim path_name As String = Application.StartupPath & "\PREDES\" & file_name
                Dim objStreamWriter As StreamWriter
                If Directory.Exists(path_predes_dir) = False Then
                    Directory.CreateDirectory(path_predes_dir)
                End If
                objStreamWriter = New StreamWriter(path_name, True, Encoding.ASCII)

                'objStreamWriter = File.AppendText(file_name)

                objStreamWriter.Write(sb.ToString())
                objStreamWriter.Close()
                myEdi_MailBox.Update_EDI_Intref(myIPMC_MaNC.Ma_NC.ToString(), "PREDES")

                myEDI.Add_EDI(Id_Chuyen_Thu, Chuyen_Thu_Di_Chi_Tiet.Id_Duong_Thu, myPredes_UNB.UNB_S005, Int32.Parse(myPredes_UNB.UNB_0017), Int32.Parse(myPredes_UNB.UNB_0019), file_name, "PREDES")
                '            ConnectServer_Click()
            End If
            'Can cu theo id_chuyen_thu de xac dinh duoc id_duong_thu
            'Kiem tra duong thu di theo id_duong_thu, neu id_phan_loai=4 => Di quoc te, thi se duoc tao ra PREDES.
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        End Try

    End Function
#End Region

#Region "Truyền File"
    Private Function FTP_Send_File(ByVal File_Name As String, ByVal Source_Path As String, ByVal Destination_Path As String) As Boolean
        Try
            Dim m_Predes As New Predes(GConnectionString)
            Dim FtpUp As New FTP.FTPLib.FTP
            'Dim filename As String = myPredes_Unsending.Tables(0).Rows(idx).Item("PREDES")
            Dim StrSrcFile As String
            StrSrcFile = Source_Path & "\" & File_Name

            If File.Exists(StrSrcFile) Then
                Dim sFileName As String = Path.GetFileName(StrSrcFile)
                FtpUp.OpenUpload(StrSrcFile, sFileName)
                While (FtpUp.DoUpload() > 0) 'Upload thành công
                    'Đẩy dữ liệu thành công thì Move file vào thư mục của ngày hôm trước
                    If Move_File(File_Name, Source_Path, Destination_Path) = False Then
                        Return False
                    End If
                End While
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function Move_File(ByVal File_Name As String, ByVal Source_Path As String, ByVal Des_Path As String) As Boolean
        'Move File vào thư mục sẵn có
        Try
            Dim FileToMove As String
            Dim MoveLocation As String
            FileToMove = Source_Path & "\" & File_Name
            MoveLocation = Des_Path & "\" & File_Name

            If System.IO.File.Exists(FileToMove) = True Then
                System.IO.File.Move(FileToMove, MoveLocation)
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

#Region "FTP"

    Private Sub ConnectServer_Click()
        'Try
        '    Dim ftpUp As New FTP
        '    Dim ftpDown As New FTP
        '    Dim Ftp_Server As String = "192.168.68.9"
        '    Dim Ftp_Username As String = "ems"
        '    Dim Ftp_Password As String = "ems"
        '    ftpDown.Connect(Ftp_Server, Ftp_Username, Ftp_Password)
        '    ftpUp.Connect(Ftp_Server, Ftp_Username, Ftp_Password)
        '    MessageBox.Show("Kết nối thành công")
        '    isConnectedFtp = True
        'Catch ex As Exception
        '    MessageBox.Show("Kết nối không thành công. Chi tiết: " & ex.Message)
        'End Try
    End Sub
#End Region

#Region "Sử dụng FTP để đẩy File lên Server"
    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Try
    '        'FTP file lên server
    '        Dim myPredes_Unsending As DataSet = myPredes.Get_Predes_UnSending()
    '        Dim idx As Integer
    '        Dim ftpUp As New FTP.FTPLib.FTP
    '        'Lấy dữ liệu trong bảng
    '        Dim m_FTP_Table As New FTP_Table(GConnectionString)
    '        Dim m_FTP_Table_Chi_Tiet As New FTP_Table_Chi_Tiet
    '        m_FTP_Table_Chi_Tiet = m_FTP_Table.FTP_Lay_Dong_Dau_Tien

    '        Dim Ftp_Server As String = m_FTP_Table_Chi_Tiet.SERVER '"192.168.68.9"
    '        Dim Ftp_Username As String = m_FTP_Table_Chi_Tiet.USERNAME ' "ems"
    '        Dim Ftp_Password As String = m_FTP_Table_Chi_Tiet.PASSWORD ' "ems"
    '        Try
    '            ftpUp.Connect(Ftp_Server, Ftp_Username, Ftp_Password)
    '            ftpUp.ChangeDir("\\upload")
    '            isConnectedFtp = True
    '        Catch ex As Exception
    '            MessageBox.Show("Kết nối không thành công. Chi tiết: " & ex.Message)
    '        End Try

    '        For idx = 0 To myPredes_Unsending.Tables(0).Rows.Count - 1
    '            Dim filename As String = myPredes_Unsending.Tables(0).Rows(idx).Item("PREDES")
    '            Dim strSrcFile As String = Application.StartupPath & "\PREDES\" & filename

    '            If File.Exists(strSrcFile) Then
    '                Dim sFileName As String = Path.GetFileName(strSrcFile)
    '                ftpUp.OpenUpload(strSrcFile, sFileName)
    '                While (ftpUp.DoUpload() > 0)

    '                End While
    '            End If
    '            'Đẩy dữ liệu thành công thì Move file vào thư mục của ngày hôm trước
    '        Next
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString)
    '    End Try
    'End Sub
#End Region
#End Region

#Region "==========Truyền lại dữ liệu của toàn bộ ca khai thác=========="
    Private Sub Danh_Sach_Chuyen_Thu_Di_Trong_Ca_Can_Truyen(ByVal Id_Ca As String)
        Try
            'Hien thong tin tren label Tien trinh
            lblTien_Trinh.Text = ".....Đang truyền dữ liệu đóng đi lên Center......."
            lblTien_Trinh.Refresh()
            '--------------------------------------------
            Dim m_Duong_Thu_Di As New Duong_Thu_Di(GConnectionString)
            Dim m_Ca_San_Xuat As New Ca_San_Xuat(GConnectionString)
            Dim m_Ca_San_Xuat_Chi_Tiet As New Ca_San_Xuat_Chi_Tiet
            Dim m_Ham_Dung_Chung As New Ham_Dung_Chung
            Dim idx As Integer
            'Tạo bản tin Predes
            Dim m_DataSet_Danh_Sach_Chuyen_Thu As New DataSet
            m_DataSet_Danh_Sach_Chuyen_Thu = myChuyen_Thu_Di.Danh_Sach_Chuyen_Thu_Da_Dong_F_Theo_Ca(Id_Ca)
            'Xu ly Process Bar
            PrbTien_Trinh.Maximum = m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows.Count
            PrbTien_Trinh.Step = 1
            PrbTien_Trinh.Value = 0
            '----------------------------------------
            If m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows.Count > 0 Then
                'Dim num As Integer = 0
                For idx = 0 To m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows.Count - 1
                    Dim mydataset As New DataSet
                    Dim mytable As New DataTable
                    Dim m_Id_Chuyen_Thu As String
                    Dim m_Ma_Bc As Integer
                    m_Id_Chuyen_Thu = m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows(idx).Item("Id_Chuyen_Thu")
                    m_Ma_Bc = m_Duong_Thu_Di.Lay(m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows(idx).Item("Id_Duong_Thu")).Ma_Bc
                    'Chuyen thu
                    mytable = myChuyen_Thu_Di.Danh_Sach_Chuyen_Thu_Lay_Boi_Id_Chuyen_Thu_Truyen_Lai(m_Id_Chuyen_Thu).Tables(0)
                    mytable.TableName = "Chuyen_Thu"
                    mydataset.Tables.Add(mytable.Copy)
                    'E2_Di
                    mytable = myE2_Di.Danh_Sach_E2_Truyen(m_Id_Chuyen_Thu).Tables(0)
                    mytable.TableName = "E2"
                    mydataset.Tables.Add(mytable.Copy)
                    'E1_Di
                    mytable = myE1_Di.Danh_Sach_E1_Truyen(m_Id_Chuyen_Thu).Tables(0)
                    mytable.TableName = "E1"
                    mydataset.Tables.Add(mytable.Copy)
                    ' truyền dữ liệu
                    myUtility.Dang_Ky_Truyen("Ems_E2", "Branch", "PO", GBuu_Cuc_Khai_Thac, m_Ma_Bc, m_Ham_Dung_Chung.ConvertDateToInt(Now), m_Ham_Dung_Chung.ConvertTimeToInt(Now), "", mydataset)
                    'Next process value
                    PrbTien_Trinh.PerformStep()
                    '----------------------------------------
                    'Refresh form
                    Application.DoEvents()
                    '----------------------------------------
                Next
            End If
            'Hien thong tin tren label Tien trinh
            lblTien_Trinh.Text = "Đã truyền hết dữ liệu đóng đi......"
            lblTien_Trinh.Refresh()
            '--------------------------------------------
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Danh_Sach_Chuyen_Thu_Den_Trong_Ca_Can_Truyen(ByVal Id_Ca As String)
        Try
            'Hien thong tin tren label Tien trinh
            lblTien_Trinh.Text = ".....Đang truyền dữ liệu xác nhận đến lên Center......."
            lblTien_Trinh.Refresh()
            '--------------------------------------------
            Dim m_Duong_Thu_Den As New Duong_Thu_Den(GConnectionString)
            Dim m_Ca_San_Xuat As New Ca_San_Xuat(GConnectionString)
            Dim m_Ca_San_Xuat_Chi_Tiet As New Ca_San_Xuat_Chi_Tiet
            Dim m_Ham_Dung_Chung As New Ham_Dung_Chung
            Dim idx As Integer
            'Tạo bản tin Predes
            Dim m_DataSet_Danh_Sach_Chuyen_Thu As New DataSet
            m_DataSet_Danh_Sach_Chuyen_Thu = myChuyen_Thu_Den.Danh_Sach_Chuyen_Thu_Den_Theo_Ca(Id_Ca)
            'Xu ly Process Bar
            PrbTien_Trinh.Maximum = m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows.Count
            PrbTien_Trinh.Step = 1
            PrbTien_Trinh.Value = 0
            '----------------------------------------
            If m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows.Count > 0 Then
                'Dim num As Integer = 0
                For idx = 0 To m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows.Count - 1
                    Dim mydataset As New DataSet
                    Dim mytable As New DataTable
                    Dim m_Id_Chuyen_Thu As String
                    Dim m_Ma_Bc As Integer
                    m_Id_Chuyen_Thu = m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows(idx).Item("Id_Chuyen_Thu")
                    m_Ma_Bc = m_Duong_Thu_Den.Lay(m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows(idx).Item("Id_Duong_Thu")).Ma_Bc
                    'Chuyến thư
                    mytable = myChuyen_Thu_Den.Danh_Sach_Chuyen_Thu_Lay_Boi_Id_Chuyen_Thu_Truyen(m_Id_Chuyen_Thu).Tables(0)
                    mytable.TableName = "Chuyen_Thu"
                    mydataset.Tables.Add(mytable.Copy)
                    'E2_Den
                    mytable = myE2_Den.Danh_Sach_E2_Truyen(m_Id_Chuyen_Thu).Tables(0)
                    mytable.TableName = "E2"
                    mydataset.Tables.Add(mytable.Copy)
                    'E1_Den
                    mytable = myE1_Den.Danh_Sach_E1_Truyen(m_Id_Chuyen_Thu).Tables(0)
                    mytable.TableName = "E1"
                    mydataset.Tables.Add(mytable.Copy)
                    ' Truyền dữ liệu 
                    myUtility.Dang_Ky_Truyen("Ems_E2_Den", "Branch", "PO", GBuu_Cuc_Khai_Thac, m_Ma_Bc, m_Ham_Dung_Chung.ConvertDateToInt(Now), m_Ham_Dung_Chung.ConvertTimeToInt(Now), "", mydataset)
                    'Next process value
                    PrbTien_Trinh.PerformStep()
                    '----------------------------------------
                    'Refresh form
                    Application.DoEvents()
                    '----------------------------------------
                Next
            End If
            'Hien thong tin tren label Tien trinh
            lblTien_Trinh.Text = "Đã truyền hết dữ liệu xác nhận đến......"
            lblTien_Trinh.Refresh()
            '--------------------------------------------
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region



#Region "--------------------chk_Truyen_Theo_Ca_CheckedChanged--------------------"
    Private Sub chk_Truyen_Theo_Ca_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Truyen_Theo_Ca.CheckedChanged
        If chk_Truyen_Theo_Ca.Checked = True Then
            cb_Tu_Ngay.Enabled = False
            cb_Den_Ngay.Enabled = False
            cbMa_Ca_Theo_BC.Enabled = False

            CbNgay_Kt.Enabled = True
            CbMa_Ca.Enabled = True
        Else
            cb_Tu_Ngay.Enabled = True
            cb_Den_Ngay.Enabled = True
            cbMa_Ca_Theo_BC.Enabled = True

            CbNgay_Kt.Enabled = False
            CbMa_Ca.Enabled = False
        End If
    End Sub
#End Region

#Region "--------------------chk_Truyen_Theo_Ca_CheckedChanged--------------------"
    Private Sub cbBuu_Cuc_Khai_Thac_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbBuu_Cuc_Khai_Thac.ValueChanged
        Try
            Dim Buu_Cuc_Khai_Thac As Integer
            Buu_Cuc_Khai_Thac = CInt(cbBuu_Cuc_Khai_Thac.Value)
            'cbMa_Ca
            CbMa_Ca.DataSource = myMa_Ca.Lay_Boi_Ma_Bc_Khai_Thac(Buu_Cuc_Khai_Thac)
            CbMa_Ca.DataBind()
            If CbMa_Ca.Rows.Count > 0 Then
                CbMa_Ca.Value = CbMa_Ca.Rows(0).Cells("Thu_Tu").Value
            End If
            'cbMa_Ca_Theo_BC
            cbMa_Ca_Theo_BC.DataSource = myMa_Ca.Lay_Boi_Ma_Bc_Khai_Thac(Buu_Cuc_Khai_Thac)
            cbMa_Ca_Theo_BC.DataBind()
            If cbMa_Ca_Theo_BC.Rows.Count > 0 Then
                cbMa_Ca_Theo_BC.Value = cbMa_Ca_Theo_BC.Rows(0).Cells("Thu_Tu").Value
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

    Private Sub btnTruyenExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTruyenExcel.Click
        If chk_Truyen_Theo_Ca.Checked = False Then
            MessageBox.Show("Chỉ cho phép truyền dữ liệu theo ca!!!", "Thông báo", MessageBoxButtons.OK)
            Exit Sub
        End If
        Dim Id_Ca As String
        Dim Ngay_Khai_Thac As Integer
        Dim Ma_Ca As Integer
        Dim Bc_Khai_Thac As Integer
        Bc_Khai_Thac = CInt(cbBuu_Cuc_Khai_Thac.Value)
        Ngay_Khai_Thac = myHam_Dung_Chung.ConvertDateToInt(CbNgay_Kt.Value)
        lblNgay_Truyen.Text = myHam_Dung_Chung.ConvertIntToDate_VN(Ngay_Khai_Thac)
        Ma_Ca = CInt(CbMa_Ca.Value)
        'Lấy mã ca
        Id_Ca = CreateId_Ca(Bc_Khai_Thac, Ngay_Khai_Thac, Ma_Ca)
        'Truyền File excel
        Truyen_Thue_Le_Phi_HQ_Trong_Ca(Id_Ca)
    End Sub

#Region "Truyen Thue Le Phi HQ"
    Private Function Truyen_Thue_Le_Phi_HQ_Trong_Ca(ByVal Id_Ca As String) As Boolean
        'Lấy ra danh sách các E1 đã được đóng đi trong ca và có Thuế Lệ phí HQ
        Try
            'Hien thong tin tren label Tien trinh
            lblTien_Trinh.Text = ".....Đang lấy dữ liệu Thuế Lệ Phí HQ......."
            lblTien_Trinh.Refresh()
            '------------------------------------------------
            Dim mDanhSachE1 As New DataSet
            mDanhSachE1 = myE1_Di.Danh_Sach_E1_Thue_Le_Phi_HQ(Id_Ca)

            If mDanhSachE1 Is Nothing Then
                MessageBox.Show("Không tồn tại dữ liệu!!!", "Thông báo", MessageBoxButtons.OK)
                Exit Function
            End If
            If mDanhSachE1.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("Không tồn tại dữ liệu!!!", "Thông báo", MessageBoxButtons.OK)
                Exit Function
            End If
            '--------------------------------------------       
            lblTien_Trinh.Text = ".....Đang tạo dữ liệu Thuế Lệ Phí HQ......."
            lblTien_Trinh.Refresh()
            Application.DoEvents()
            ExportToExcel(mDanhSachE1, Id_Ca)
            Application.DoEvents()
            'Hien thong tin tren label Tien trinh
            lblTien_Trinh.Text = "Đã tạo xong dữ liệu.......Đang gửi File lên FTP Server......"
            lblTien_Trinh.Refresh()
            Application.DoEvents()
            '--------------------------------------------
            'Connect FTP Server
            Dim ftpUp As New FTP.FTPLib.FTP
            ' Lấy thông tin FTP Server
            'Lấy dữ liệu trong bảng
            Dim m_FTP_Table As New FTP_Table(GConnectionString)
            Dim m_FTP_Table_Chi_Tiet As New FTP_Table_Chi_Tiet
            m_FTP_Table_Chi_Tiet = m_FTP_Table.FTP_Lay_Dong_Dau_Tien

            Dim Ftp_Server As String = "192.168.68.8" 'm_FTP_Table_Chi_Tiet.SERVER  '"192.168.68.9"
            Dim Ftp_Username As String = "edi" 'm_FTP_Table_Chi_Tiet.USERNAME ' "ems"
            Dim Ftp_Password As String = "edi" 'm_FTP_Table_Chi_Tiet.PASSWORD ' "ems"
            Dim Ftp_Upload As String = "" 'm_FTP_Table_Chi_Tiet.UPLOAD
            '
            Try
                ftpUp.Connect(Ftp_Server, Ftp_Username, Ftp_Password)
                ftpUp.ChangeDir("\\" + Ftp_Upload)
                isConnectedFtp = True
            Catch ex As Exception
                MessageBox.Show("Kết nối không thành công. Chi tiết: " & ex.Message)
            End Try

            'Lấy ngày khai thác làm thư mục để Move dữ liệu
            Dim m_Folder_Ngay_Khai_Thac As String = Id_Ca.Substring(6, 8)
            'Tạo Folder mới để chứa dữ liệu của ngày khai thác
            Dim m_Source_Path As String = Application.StartupPath & "\ThueHQ\"
            If Directory.Exists(m_Source_Path) = False Then
                Directory.CreateDirectory(m_Source_Path)
            End If
            'Create Destination_Path
            Dim m_Destination_Path As String = Application.StartupPath & "\ThueHQ\" & m_Folder_Ngay_Khai_Thac
            If Directory.Exists(m_Destination_Path) = False Then
                Directory.CreateDirectory(m_Destination_Path)
            End If
            Dim File_Name As String = Id_Ca & ".xls"
            Dim StrSrcFile As String = m_Source_Path & File_Name
            'Dim StrSrcFile As String
            StrSrcFile = m_Source_Path & "\" & File_Name

            If File.Exists(StrSrcFile) Then
                Dim sFileName As String = Path.GetFileName(StrSrcFile)
                ftpUp.OpenUpload(StrSrcFile, sFileName)
                While (ftpUp.DoUpload() > 0) 'Upload thành công, upload toàn bộ dữ liệu
                    'Refresh form
                    Application.DoEvents()
                    '----------------------------------------
                End While
                'Đẩy dữ liệu thành công thì Move file vào thư mục của ngày hôm trước
                If Move_File(File_Name, m_Source_Path, m_Destination_Path) = False Then
                    Return False
                End If
            End If
            lblTien_Trinh.Text = "Đã gửi File lên FTP Server"
            lblTien_Trinh.Refresh()
            '----------------------------------------
            'Refresh form
            Application.DoEvents()
            '----------------------------------------

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Function

    Private Sub ExportToExcel(ByVal mDataSet As DataSet, ByVal Id_Ca As String)
        Dim strFilePath As String
        strFilePath = Application.StartupPath & "\ThueHQ\" & Id_Ca & ".xls"
        If (Not Directory.Exists(Application.StartupPath & "\ThueHQ")) Then
            Directory.CreateDirectory(Application.StartupPath & "\ThueHQ")
        End If
        ExportToExcelFromDataSet(mDataSet, strFilePath)
    End Sub

    Public Sub ExportToExcelFromDataSet(ByVal mDataSet As DataSet, ByVal mFilePath As String)
        'Extracting from database
        Dim col, row As Integer

        Dim Excel As Object = CreateObject("Excel.Application")
        If Excel Is Nothing Then
            MsgBox("It appears that Excel is not installed on this machine. This operation requires MS Excel to be installed on this machine.", MsgBoxStyle.Critical)
            Return
        End If

        'Export to Excel process
        Try
            Cursor.Current = Cursors.WaitCursor
            With Excel
                .SheetsInNewWorkbook = 1
                .Workbooks.Add()
                .Worksheets(1).Select()

                Dim i As Integer = 1
                For col = 0 To mDataSet.Tables(0).Columns.Count - 1
                    .cells(1, i).value = mDataSet.Tables(0).Columns(col).ColumnName
                    .cells(1, i).EntireRow.Font.Bold = True
                    i += 1
                Next
                i = 2
                Dim k As Integer = 1
                For col = 0 To mDataSet.Tables(0).Columns.Count - 1
                    i = 2
                    For row = 0 To mDataSet.Tables(0).Rows.Count - 1
                        .Cells(i, k).Value = mDataSet.Tables(0).Rows(row).ItemArray(col)
                        i += 1
                    Next
                    k += 1
                Next
                .ActiveCell.Worksheet.SaveAs(mFilePath)
            End With
            System.Runtime.InteropServices.Marshal.ReleaseComObject(Excel)
            Excel = Nothing

        Catch ex As Exception
            MsgBox(ex.Message)
            Cursor.Current = Cursors.Default
        End Try

        ' The excel is created and opened for insert value. We most close this excel using this system
        Dim pro() As Process = System.Diagnostics.Process.GetProcessesByName("EXCEL")
        For Each i As Process In pro
            i.Kill()
        Next
        Cursor.Current = Cursors.Default
        MsgBox("Dữ liệu đã được xuất ra thành công trong file:  '" & mFilePath & "'", MsgBoxStyle.Information)

    End Sub
#End Region
End Class

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports Ems_International_Logic.EMS

Public Class FrmTongHopSanLuong
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
    Friend WithEvents BtnExit As Infragistics.Win.Misc.UltraButton
    Friend WithEvents BtnPrint As Infragistics.Win.Misc.UltraButton
    Friend WithEvents BtnPreview As Infragistics.Win.Misc.UltraButton
    Friend WithEvents LbThong_Tin As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CbTuy_Chon_Bao_Cao As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CbPL_Duong_Thu As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents OptHuyen As System.Windows.Forms.RadioButton
    Friend WithEvents OptPhanLoaiDuongThu As System.Windows.Forms.RadioButton
    Friend WithEvents CbDuong_Thu_Di_Den As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents OptDuong_Thu As System.Windows.Forms.RadioButton
    Friend WithEvents OptTat_Ca As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CbMa_Ca As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CbDen_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CbTu_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents OptNgay_Kt As System.Windows.Forms.RadioButton
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CbNgay_Kt As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents OptCa_kt As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents OptHang_di As System.Windows.Forms.RadioButton
    Friend WithEvents OptHang_Den As System.Windows.Forms.RadioButton
    Friend WithEvents groupDichVu As System.Windows.Forms.GroupBox
    Friend WithEvents optDvuEMS As System.Windows.Forms.RadioButton
    Friend WithEvents optDvuBuuKien As System.Windows.Forms.RadioButton
    Friend WithEvents optDvuTatCa As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmTongHopSanLuong))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Tuy_Chon_Bao_Cao", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bao_Cao")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Bao_Cao")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Phan_Loai")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Phan_Loai")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Duong_Thu_Di_Den", -1)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Duong_Thu")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Phan_Loai")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ip_Truyen")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tinh_Doanh_Thu")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tinh_Cong_Phat")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Ca", -1)
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ca_Khai_Thac")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thu_Tu")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ca")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.LbThong_Tin = New Infragistics.Win.Misc.UltraLabel
        Me.BtnExit = New Infragistics.Win.Misc.UltraButton
        Me.BtnPrint = New Infragistics.Win.Misc.UltraButton
        Me.BtnPreview = New Infragistics.Win.Misc.UltraButton
        Me.CbTuy_Chon_Bao_Cao = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.CbPL_Duong_Thu = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.OptHuyen = New System.Windows.Forms.RadioButton
        Me.OptPhanLoaiDuongThu = New System.Windows.Forms.RadioButton
        Me.CbDuong_Thu_Di_Den = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.OptDuong_Thu = New System.Windows.Forms.RadioButton
        Me.OptTat_Ca = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CbMa_Ca = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.CbDen_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.CbTu_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.OptNgay_Kt = New System.Windows.Forms.RadioButton
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.CbNgay_Kt = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.OptCa_kt = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.OptHang_di = New System.Windows.Forms.RadioButton
        Me.OptHang_Den = New System.Windows.Forms.RadioButton
        Me.groupDichVu = New System.Windows.Forms.GroupBox
        Me.optDvuEMS = New System.Windows.Forms.RadioButton
        Me.optDvuBuuKien = New System.Windows.Forms.RadioButton
        Me.optDvuTatCa = New System.Windows.Forms.RadioButton
        CType(Me.CbTuy_Chon_Bao_Cao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.CbPL_Duong_Thu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbDuong_Thu_Di_Den, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CbMa_Ca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbDen_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbTu_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbNgay_Kt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.groupDichVu.SuspendLayout()
        Me.SuspendLayout()
        '
        'LbThong_Tin
        '
        Me.LbThong_Tin.AccessibleDescription = resources.GetString("LbThong_Tin.AccessibleDescription")
        Me.LbThong_Tin.AccessibleName = resources.GetString("LbThong_Tin.AccessibleName")
        Me.LbThong_Tin.Anchor = CType(resources.GetObject("LbThong_Tin.Anchor"), System.Windows.Forms.AnchorStyles)
        Appearance1.FontData.BoldAsString = resources.GetString("resource.BoldAsString")
        Appearance1.FontData.ItalicAsString = resources.GetString("resource.ItalicAsString")
        Appearance1.FontData.Name = resources.GetString("resource.Name")
        Appearance1.FontData.SizeInPoints = CType(resources.GetObject("resource.SizeInPoints"), Single)
        Appearance1.FontData.StrikeoutAsString = resources.GetString("resource.StrikeoutAsString")
        Appearance1.FontData.UnderlineAsString = resources.GetString("resource.UnderlineAsString")
        Appearance1.TextHAlign = Infragistics.Win.HAlign.Center
        Me.LbThong_Tin.Appearance = Appearance1
        Me.LbThong_Tin.AutoSize = CType(resources.GetObject("LbThong_Tin.AutoSize"), Boolean)
        Me.LbThong_Tin.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.LbThong_Tin.BackgroundImage = CType(resources.GetObject("LbThong_Tin.BackgroundImage"), System.Drawing.Image)
        Me.LbThong_Tin.Dock = CType(resources.GetObject("LbThong_Tin.Dock"), System.Windows.Forms.DockStyle)
        Me.LbThong_Tin.Enabled = CType(resources.GetObject("LbThong_Tin.Enabled"), Boolean)
        Me.LbThong_Tin.Font = CType(resources.GetObject("LbThong_Tin.Font"), System.Drawing.Font)
        Me.LbThong_Tin.ImeMode = CType(resources.GetObject("LbThong_Tin.ImeMode"), System.Windows.Forms.ImeMode)
        Me.LbThong_Tin.Location = CType(resources.GetObject("LbThong_Tin.Location"), System.Drawing.Point)
        Me.LbThong_Tin.Name = "LbThong_Tin"
        Me.LbThong_Tin.RightToLeft = CType(resources.GetObject("LbThong_Tin.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.LbThong_Tin.Size = CType(resources.GetObject("LbThong_Tin.Size"), System.Drawing.Size)
        Me.LbThong_Tin.TabIndex = CType(resources.GetObject("LbThong_Tin.TabIndex"), Integer)
        Me.LbThong_Tin.Text = resources.GetString("LbThong_Tin.Text")
        Me.LbThong_Tin.Visible = CType(resources.GetObject("LbThong_Tin.Visible"), Boolean)
        '
        'BtnExit
        '
        Me.BtnExit.AccessibleDescription = resources.GetString("BtnExit.AccessibleDescription")
        Me.BtnExit.AccessibleName = resources.GetString("BtnExit.AccessibleName")
        Me.BtnExit.Anchor = CType(resources.GetObject("BtnExit.Anchor"), System.Windows.Forms.AnchorStyles)
        Appearance2.FontData.BoldAsString = resources.GetString("resource.BoldAsString1")
        Appearance2.FontData.ItalicAsString = resources.GetString("resource.ItalicAsString1")
        Appearance2.FontData.Name = resources.GetString("resource.Name1")
        Appearance2.FontData.SizeInPoints = CType(resources.GetObject("resource.SizeInPoints1"), Single)
        Appearance2.FontData.StrikeoutAsString = resources.GetString("resource.StrikeoutAsString1")
        Appearance2.FontData.UnderlineAsString = resources.GetString("resource.UnderlineAsString1")
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.BtnExit.Appearance = Appearance2
        Me.BtnExit.AutoSize = CType(resources.GetObject("BtnExit.AutoSize"), Boolean)
        Me.BtnExit.BackgroundImage = CType(resources.GetObject("BtnExit.BackgroundImage"), System.Drawing.Image)
        Me.BtnExit.Dock = CType(resources.GetObject("BtnExit.Dock"), System.Windows.Forms.DockStyle)
        Me.BtnExit.Enabled = CType(resources.GetObject("BtnExit.Enabled"), Boolean)
        Me.BtnExit.Font = CType(resources.GetObject("BtnExit.Font"), System.Drawing.Font)
        Me.BtnExit.ImageSize = New System.Drawing.Size(40, 25)
        Me.BtnExit.ImeMode = CType(resources.GetObject("BtnExit.ImeMode"), System.Windows.Forms.ImeMode)
        Me.BtnExit.Location = CType(resources.GetObject("BtnExit.Location"), System.Drawing.Point)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.RightToLeft = CType(resources.GetObject("BtnExit.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.BtnExit.Size = CType(resources.GetObject("BtnExit.Size"), System.Drawing.Size)
        Me.BtnExit.TabIndex = CType(resources.GetObject("BtnExit.TabIndex"), Integer)
        Me.BtnExit.Text = resources.GetString("BtnExit.Text")
        Me.BtnExit.Visible = CType(resources.GetObject("BtnExit.Visible"), Boolean)
        '
        'BtnPrint
        '
        Me.BtnPrint.AccessibleDescription = resources.GetString("BtnPrint.AccessibleDescription")
        Me.BtnPrint.AccessibleName = resources.GetString("BtnPrint.AccessibleName")
        Me.BtnPrint.Anchor = CType(resources.GetObject("BtnPrint.Anchor"), System.Windows.Forms.AnchorStyles)
        Appearance3.FontData.BoldAsString = resources.GetString("resource.BoldAsString2")
        Appearance3.FontData.ItalicAsString = resources.GetString("resource.ItalicAsString2")
        Appearance3.FontData.Name = resources.GetString("resource.Name2")
        Appearance3.FontData.SizeInPoints = CType(resources.GetObject("resource.SizeInPoints2"), Single)
        Appearance3.FontData.StrikeoutAsString = resources.GetString("resource.StrikeoutAsString2")
        Appearance3.FontData.UnderlineAsString = resources.GetString("resource.UnderlineAsString2")
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Center
        Me.BtnPrint.Appearance = Appearance3
        Me.BtnPrint.AutoSize = CType(resources.GetObject("BtnPrint.AutoSize"), Boolean)
        Me.BtnPrint.BackgroundImage = CType(resources.GetObject("BtnPrint.BackgroundImage"), System.Drawing.Image)
        Me.BtnPrint.Dock = CType(resources.GetObject("BtnPrint.Dock"), System.Windows.Forms.DockStyle)
        Me.BtnPrint.Enabled = CType(resources.GetObject("BtnPrint.Enabled"), Boolean)
        Me.BtnPrint.Font = CType(resources.GetObject("BtnPrint.Font"), System.Drawing.Font)
        Me.BtnPrint.ImageSize = New System.Drawing.Size(40, 25)
        Me.BtnPrint.ImeMode = CType(resources.GetObject("BtnPrint.ImeMode"), System.Windows.Forms.ImeMode)
        Me.BtnPrint.Location = CType(resources.GetObject("BtnPrint.Location"), System.Drawing.Point)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.RightToLeft = CType(resources.GetObject("BtnPrint.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.BtnPrint.Size = CType(resources.GetObject("BtnPrint.Size"), System.Drawing.Size)
        Me.BtnPrint.TabIndex = CType(resources.GetObject("BtnPrint.TabIndex"), Integer)
        Me.BtnPrint.Text = resources.GetString("BtnPrint.Text")
        Me.BtnPrint.Visible = CType(resources.GetObject("BtnPrint.Visible"), Boolean)
        '
        'BtnPreview
        '
        Me.BtnPreview.AccessibleDescription = resources.GetString("BtnPreview.AccessibleDescription")
        Me.BtnPreview.AccessibleName = resources.GetString("BtnPreview.AccessibleName")
        Me.BtnPreview.Anchor = CType(resources.GetObject("BtnPreview.Anchor"), System.Windows.Forms.AnchorStyles)
        Appearance4.FontData.BoldAsString = resources.GetString("resource.BoldAsString3")
        Appearance4.FontData.ItalicAsString = resources.GetString("resource.ItalicAsString3")
        Appearance4.FontData.Name = resources.GetString("resource.Name3")
        Appearance4.FontData.SizeInPoints = CType(resources.GetObject("resource.SizeInPoints3"), Single)
        Appearance4.FontData.StrikeoutAsString = resources.GetString("resource.StrikeoutAsString3")
        Appearance4.FontData.UnderlineAsString = resources.GetString("resource.UnderlineAsString3")
        Appearance4.Image = CType(resources.GetObject("Appearance4.Image"), Object)
        Me.BtnPreview.Appearance = Appearance4
        Me.BtnPreview.AutoSize = CType(resources.GetObject("BtnPreview.AutoSize"), Boolean)
        Me.BtnPreview.BackgroundImage = CType(resources.GetObject("BtnPreview.BackgroundImage"), System.Drawing.Image)
        Me.BtnPreview.Dock = CType(resources.GetObject("BtnPreview.Dock"), System.Windows.Forms.DockStyle)
        Me.BtnPreview.Enabled = CType(resources.GetObject("BtnPreview.Enabled"), Boolean)
        Me.BtnPreview.Font = CType(resources.GetObject("BtnPreview.Font"), System.Drawing.Font)
        Me.BtnPreview.ImageSize = New System.Drawing.Size(40, 25)
        Me.BtnPreview.ImeMode = CType(resources.GetObject("BtnPreview.ImeMode"), System.Windows.Forms.ImeMode)
        Me.BtnPreview.Location = CType(resources.GetObject("BtnPreview.Location"), System.Drawing.Point)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.RightToLeft = CType(resources.GetObject("BtnPreview.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.BtnPreview.Size = CType(resources.GetObject("BtnPreview.Size"), System.Drawing.Size)
        Me.BtnPreview.TabIndex = CType(resources.GetObject("BtnPreview.TabIndex"), Integer)
        Me.BtnPreview.Text = resources.GetString("BtnPreview.Text")
        Me.BtnPreview.Visible = CType(resources.GetObject("BtnPreview.Visible"), Boolean)
        '
        'CbTuy_Chon_Bao_Cao
        '
        Me.CbTuy_Chon_Bao_Cao.AccessibleDescription = resources.GetString("CbTuy_Chon_Bao_Cao.AccessibleDescription")
        Me.CbTuy_Chon_Bao_Cao.AccessibleName = resources.GetString("CbTuy_Chon_Bao_Cao.AccessibleName")
        Me.CbTuy_Chon_Bao_Cao.Anchor = CType(resources.GetObject("CbTuy_Chon_Bao_Cao.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.CbTuy_Chon_Bao_Cao.BackgroundImage = CType(resources.GetObject("CbTuy_Chon_Bao_Cao.BackgroundImage"), System.Drawing.Image)
        Me.CbTuy_Chon_Bao_Cao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridBand1.AddButtonCaption = resources.GetString("UltraGridBand1.AddButtonCaption")
        UltraGridBand1.AddButtonToolTipText = resources.GetString("UltraGridBand1.AddButtonToolTipText")
        UltraGridColumn1.Format = resources.GetString("UltraGridColumn1.Format")
        Appearance5.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn1.Header.Appearance = Appearance5
        UltraGridColumn1.Header.Caption = resources.GetString("resource.Caption")
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.MaskInput = resources.GetString("UltraGridColumn1.MaskInput")
        UltraGridColumn1.NullText = resources.GetString("UltraGridColumn1.NullText")
        UltraGridColumn1.Width = 78
        UltraGridColumn2.Format = resources.GetString("UltraGridColumn2.Format")
        Appearance6.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn2.Header.Appearance = Appearance6
        UltraGridColumn2.Header.Caption = resources.GetString("resource.Caption1")
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.MaskInput = resources.GetString("UltraGridColumn2.MaskInput")
        UltraGridColumn2.NullText = resources.GetString("UltraGridColumn2.NullText")
        UltraGridColumn2.Width = 328
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2})
        UltraGridBand1.SummaryFooterCaption = resources.GetString("UltraGridBand1.SummaryFooterCaption")
        Me.CbTuy_Chon_Bao_Cao.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.CbTuy_Chon_Bao_Cao.DisplayLayout.Override.GroupByRowDescriptionMask = resources.GetString("resource.GroupByRowDescriptionMask")
        Appearance7.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance7.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance7.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance7.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.CbTuy_Chon_Bao_Cao.DisplayLayout.Override.HeaderAppearance = Appearance7
        Me.CbTuy_Chon_Bao_Cao.DisplayLayout.Override.NullText = resources.GetString("resource.NullText")
        Me.CbTuy_Chon_Bao_Cao.DisplayMember = "Ten_Bao_Cao"
        Me.CbTuy_Chon_Bao_Cao.Dock = CType(resources.GetObject("CbTuy_Chon_Bao_Cao.Dock"), System.Windows.Forms.DockStyle)
        Me.CbTuy_Chon_Bao_Cao.Enabled = CType(resources.GetObject("CbTuy_Chon_Bao_Cao.Enabled"), Boolean)
        Me.CbTuy_Chon_Bao_Cao.Font = CType(resources.GetObject("CbTuy_Chon_Bao_Cao.Font"), System.Drawing.Font)
        Me.CbTuy_Chon_Bao_Cao.ImeMode = CType(resources.GetObject("CbTuy_Chon_Bao_Cao.ImeMode"), System.Windows.Forms.ImeMode)
        Me.CbTuy_Chon_Bao_Cao.Location = CType(resources.GetObject("CbTuy_Chon_Bao_Cao.Location"), System.Drawing.Point)
        Me.CbTuy_Chon_Bao_Cao.Name = "CbTuy_Chon_Bao_Cao"
        Me.CbTuy_Chon_Bao_Cao.RightToLeft = CType(resources.GetObject("CbTuy_Chon_Bao_Cao.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.CbTuy_Chon_Bao_Cao.Size = CType(resources.GetObject("CbTuy_Chon_Bao_Cao.Size"), System.Drawing.Size)
        Me.CbTuy_Chon_Bao_Cao.TabIndex = CType(resources.GetObject("CbTuy_Chon_Bao_Cao.TabIndex"), Integer)
        Me.CbTuy_Chon_Bao_Cao.Text = resources.GetString("CbTuy_Chon_Bao_Cao.Text")
        Me.CbTuy_Chon_Bao_Cao.ValueMember = "Ma_Bao_Cao"
        Me.CbTuy_Chon_Bao_Cao.Visible = CType(resources.GetObject("CbTuy_Chon_Bao_Cao.Visible"), Boolean)
        '
        'GroupBox3
        '
        Me.GroupBox3.AccessibleDescription = resources.GetString("GroupBox3.AccessibleDescription")
        Me.GroupBox3.AccessibleName = resources.GetString("GroupBox3.AccessibleName")
        Me.GroupBox3.Anchor = CType(resources.GetObject("GroupBox3.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackgroundImage = CType(resources.GetObject("GroupBox3.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox3.Controls.Add(Me.CbPL_Duong_Thu)
        Me.GroupBox3.Controls.Add(Me.OptHuyen)
        Me.GroupBox3.Controls.Add(Me.OptPhanLoaiDuongThu)
        Me.GroupBox3.Controls.Add(Me.CbDuong_Thu_Di_Den)
        Me.GroupBox3.Controls.Add(Me.OptDuong_Thu)
        Me.GroupBox3.Controls.Add(Me.OptTat_Ca)
        Me.GroupBox3.Dock = CType(resources.GetObject("GroupBox3.Dock"), System.Windows.Forms.DockStyle)
        Me.GroupBox3.Enabled = CType(resources.GetObject("GroupBox3.Enabled"), Boolean)
        Me.GroupBox3.Font = CType(resources.GetObject("GroupBox3.Font"), System.Drawing.Font)
        Me.GroupBox3.ImeMode = CType(resources.GetObject("GroupBox3.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GroupBox3.Location = CType(resources.GetObject("GroupBox3.Location"), System.Drawing.Point)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.RightToLeft = CType(resources.GetObject("GroupBox3.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.GroupBox3.Size = CType(resources.GetObject("GroupBox3.Size"), System.Drawing.Size)
        Me.GroupBox3.TabIndex = CType(resources.GetObject("GroupBox3.TabIndex"), Integer)
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = resources.GetString("GroupBox3.Text")
        Me.GroupBox3.Visible = CType(resources.GetObject("GroupBox3.Visible"), Boolean)
        '
        'CbPL_Duong_Thu
        '
        Me.CbPL_Duong_Thu.AccessibleDescription = resources.GetString("CbPL_Duong_Thu.AccessibleDescription")
        Me.CbPL_Duong_Thu.AccessibleName = resources.GetString("CbPL_Duong_Thu.AccessibleName")
        Me.CbPL_Duong_Thu.Anchor = CType(resources.GetObject("CbPL_Duong_Thu.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.CbPL_Duong_Thu.BackgroundImage = CType(resources.GetObject("CbPL_Duong_Thu.BackgroundImage"), System.Drawing.Image)
        Me.CbPL_Duong_Thu.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridBand2.AddButtonCaption = resources.GetString("UltraGridBand2.AddButtonCaption")
        UltraGridBand2.AddButtonToolTipText = resources.GetString("UltraGridBand2.AddButtonToolTipText")
        UltraGridColumn3.Format = resources.GetString("UltraGridColumn3.Format")
        UltraGridColumn3.Header.Caption = resources.GetString("resource.Caption2")
        UltraGridColumn3.Header.VisiblePosition = 0
        UltraGridColumn3.Hidden = True
        UltraGridColumn3.MaskInput = resources.GetString("UltraGridColumn3.MaskInput")
        UltraGridColumn3.NullText = resources.GetString("UltraGridColumn3.NullText")
        UltraGridColumn4.Format = resources.GetString("UltraGridColumn4.Format")
        UltraGridColumn4.Header.Caption = resources.GetString("resource.Caption3")
        UltraGridColumn4.Header.VisiblePosition = 1
        UltraGridColumn4.MaskInput = resources.GetString("UltraGridColumn4.MaskInput")
        UltraGridColumn4.NullText = resources.GetString("UltraGridColumn4.NullText")
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn3, UltraGridColumn4})
        UltraGridBand2.SummaryFooterCaption = resources.GetString("UltraGridBand2.SummaryFooterCaption")
        Me.CbPL_Duong_Thu.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.CbPL_Duong_Thu.DisplayMember = "Ma_Phan_Loai"
        Me.CbPL_Duong_Thu.Dock = CType(resources.GetObject("CbPL_Duong_Thu.Dock"), System.Windows.Forms.DockStyle)
        Me.CbPL_Duong_Thu.Enabled = CType(resources.GetObject("CbPL_Duong_Thu.Enabled"), Boolean)
        Me.CbPL_Duong_Thu.Font = CType(resources.GetObject("CbPL_Duong_Thu.Font"), System.Drawing.Font)
        Me.CbPL_Duong_Thu.ImeMode = CType(resources.GetObject("CbPL_Duong_Thu.ImeMode"), System.Windows.Forms.ImeMode)
        Me.CbPL_Duong_Thu.Location = CType(resources.GetObject("CbPL_Duong_Thu.Location"), System.Drawing.Point)
        Me.CbPL_Duong_Thu.Name = "CbPL_Duong_Thu"
        Me.CbPL_Duong_Thu.RightToLeft = CType(resources.GetObject("CbPL_Duong_Thu.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.CbPL_Duong_Thu.Size = CType(resources.GetObject("CbPL_Duong_Thu.Size"), System.Drawing.Size)
        Me.CbPL_Duong_Thu.TabIndex = CType(resources.GetObject("CbPL_Duong_Thu.TabIndex"), Integer)
        Me.CbPL_Duong_Thu.Text = resources.GetString("CbPL_Duong_Thu.Text")
        Me.CbPL_Duong_Thu.ValueMember = "Ma_Phan_Loai"
        Me.CbPL_Duong_Thu.Visible = CType(resources.GetObject("CbPL_Duong_Thu.Visible"), Boolean)
        '
        'OptHuyen
        '
        Me.OptHuyen.AccessibleDescription = resources.GetString("OptHuyen.AccessibleDescription")
        Me.OptHuyen.AccessibleName = resources.GetString("OptHuyen.AccessibleName")
        Me.OptHuyen.Anchor = CType(resources.GetObject("OptHuyen.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.OptHuyen.Appearance = CType(resources.GetObject("OptHuyen.Appearance"), System.Windows.Forms.Appearance)
        Me.OptHuyen.BackgroundImage = CType(resources.GetObject("OptHuyen.BackgroundImage"), System.Drawing.Image)
        Me.OptHuyen.CheckAlign = CType(resources.GetObject("OptHuyen.CheckAlign"), System.Drawing.ContentAlignment)
        Me.OptHuyen.Dock = CType(resources.GetObject("OptHuyen.Dock"), System.Windows.Forms.DockStyle)
        Me.OptHuyen.Enabled = CType(resources.GetObject("OptHuyen.Enabled"), Boolean)
        Me.OptHuyen.FlatStyle = CType(resources.GetObject("OptHuyen.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.OptHuyen.Font = CType(resources.GetObject("OptHuyen.Font"), System.Drawing.Font)
        Me.OptHuyen.Image = CType(resources.GetObject("OptHuyen.Image"), System.Drawing.Image)
        Me.OptHuyen.ImageAlign = CType(resources.GetObject("OptHuyen.ImageAlign"), System.Drawing.ContentAlignment)
        Me.OptHuyen.ImageIndex = CType(resources.GetObject("OptHuyen.ImageIndex"), Integer)
        Me.OptHuyen.ImeMode = CType(resources.GetObject("OptHuyen.ImeMode"), System.Windows.Forms.ImeMode)
        Me.OptHuyen.Location = CType(resources.GetObject("OptHuyen.Location"), System.Drawing.Point)
        Me.OptHuyen.Name = "OptHuyen"
        Me.OptHuyen.RightToLeft = CType(resources.GetObject("OptHuyen.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.OptHuyen.Size = CType(resources.GetObject("OptHuyen.Size"), System.Drawing.Size)
        Me.OptHuyen.TabIndex = CType(resources.GetObject("OptHuyen.TabIndex"), Integer)
        Me.OptHuyen.Text = resources.GetString("OptHuyen.Text")
        Me.OptHuyen.TextAlign = CType(resources.GetObject("OptHuyen.TextAlign"), System.Drawing.ContentAlignment)
        Me.OptHuyen.Visible = CType(resources.GetObject("OptHuyen.Visible"), Boolean)
        '
        'OptPhanLoaiDuongThu
        '
        Me.OptPhanLoaiDuongThu.AccessibleDescription = resources.GetString("OptPhanLoaiDuongThu.AccessibleDescription")
        Me.OptPhanLoaiDuongThu.AccessibleName = resources.GetString("OptPhanLoaiDuongThu.AccessibleName")
        Me.OptPhanLoaiDuongThu.Anchor = CType(resources.GetObject("OptPhanLoaiDuongThu.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.OptPhanLoaiDuongThu.Appearance = CType(resources.GetObject("OptPhanLoaiDuongThu.Appearance"), System.Windows.Forms.Appearance)
        Me.OptPhanLoaiDuongThu.BackgroundImage = CType(resources.GetObject("OptPhanLoaiDuongThu.BackgroundImage"), System.Drawing.Image)
        Me.OptPhanLoaiDuongThu.CheckAlign = CType(resources.GetObject("OptPhanLoaiDuongThu.CheckAlign"), System.Drawing.ContentAlignment)
        Me.OptPhanLoaiDuongThu.Dock = CType(resources.GetObject("OptPhanLoaiDuongThu.Dock"), System.Windows.Forms.DockStyle)
        Me.OptPhanLoaiDuongThu.Enabled = CType(resources.GetObject("OptPhanLoaiDuongThu.Enabled"), Boolean)
        Me.OptPhanLoaiDuongThu.FlatStyle = CType(resources.GetObject("OptPhanLoaiDuongThu.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.OptPhanLoaiDuongThu.Font = CType(resources.GetObject("OptPhanLoaiDuongThu.Font"), System.Drawing.Font)
        Me.OptPhanLoaiDuongThu.Image = CType(resources.GetObject("OptPhanLoaiDuongThu.Image"), System.Drawing.Image)
        Me.OptPhanLoaiDuongThu.ImageAlign = CType(resources.GetObject("OptPhanLoaiDuongThu.ImageAlign"), System.Drawing.ContentAlignment)
        Me.OptPhanLoaiDuongThu.ImageIndex = CType(resources.GetObject("OptPhanLoaiDuongThu.ImageIndex"), Integer)
        Me.OptPhanLoaiDuongThu.ImeMode = CType(resources.GetObject("OptPhanLoaiDuongThu.ImeMode"), System.Windows.Forms.ImeMode)
        Me.OptPhanLoaiDuongThu.Location = CType(resources.GetObject("OptPhanLoaiDuongThu.Location"), System.Drawing.Point)
        Me.OptPhanLoaiDuongThu.Name = "OptPhanLoaiDuongThu"
        Me.OptPhanLoaiDuongThu.RightToLeft = CType(resources.GetObject("OptPhanLoaiDuongThu.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.OptPhanLoaiDuongThu.Size = CType(resources.GetObject("OptPhanLoaiDuongThu.Size"), System.Drawing.Size)
        Me.OptPhanLoaiDuongThu.TabIndex = CType(resources.GetObject("OptPhanLoaiDuongThu.TabIndex"), Integer)
        Me.OptPhanLoaiDuongThu.Text = resources.GetString("OptPhanLoaiDuongThu.Text")
        Me.OptPhanLoaiDuongThu.TextAlign = CType(resources.GetObject("OptPhanLoaiDuongThu.TextAlign"), System.Drawing.ContentAlignment)
        Me.OptPhanLoaiDuongThu.Visible = CType(resources.GetObject("OptPhanLoaiDuongThu.Visible"), Boolean)
        '
        'CbDuong_Thu_Di_Den
        '
        Me.CbDuong_Thu_Di_Den.AccessibleDescription = resources.GetString("CbDuong_Thu_Di_Den.AccessibleDescription")
        Me.CbDuong_Thu_Di_Den.AccessibleName = resources.GetString("CbDuong_Thu_Di_Den.AccessibleName")
        Me.CbDuong_Thu_Di_Den.Anchor = CType(resources.GetObject("CbDuong_Thu_Di_Den.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.CbDuong_Thu_Di_Den.BackgroundImage = CType(resources.GetObject("CbDuong_Thu_Di_Den.BackgroundImage"), System.Drawing.Image)
        Me.CbDuong_Thu_Di_Den.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridBand3.AddButtonCaption = resources.GetString("UltraGridBand3.AddButtonCaption")
        UltraGridBand3.AddButtonToolTipText = resources.GetString("UltraGridBand3.AddButtonToolTipText")
        UltraGridColumn5.Format = resources.GetString("UltraGridColumn5.Format")
        UltraGridColumn5.Header.Caption = resources.GetString("resource.Caption4")
        UltraGridColumn5.Header.VisiblePosition = 0
        UltraGridColumn5.Hidden = True
        UltraGridColumn5.MaskInput = resources.GetString("UltraGridColumn5.MaskInput")
        UltraGridColumn5.NullText = resources.GetString("UltraGridColumn5.NullText")
        UltraGridColumn6.Format = resources.GetString("UltraGridColumn6.Format")
        UltraGridColumn6.Header.Caption = resources.GetString("resource.Caption5")
        UltraGridColumn6.Header.VisiblePosition = 3
        UltraGridColumn6.Hidden = True
        UltraGridColumn6.MaskInput = resources.GetString("UltraGridColumn6.MaskInput")
        UltraGridColumn6.NullText = resources.GetString("UltraGridColumn6.NullText")
        Appearance8.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn7.CellAppearance = Appearance8
        UltraGridColumn7.Format = resources.GetString("UltraGridColumn7.Format")
        Appearance9.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn7.Header.Appearance = Appearance9
        UltraGridColumn7.Header.Caption = resources.GetString("resource.Caption6")
        UltraGridColumn7.Header.VisiblePosition = 1
        UltraGridColumn7.MaskInput = resources.GetString("UltraGridColumn7.MaskInput")
        UltraGridColumn7.NullText = resources.GetString("UltraGridColumn7.NullText")
        UltraGridColumn7.Width = 60
        Appearance10.TextHAlign = Infragistics.Win.HAlign.Left
        UltraGridColumn8.CellAppearance = Appearance10
        UltraGridColumn8.Format = resources.GetString("UltraGridColumn8.Format")
        Appearance11.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn8.Header.Appearance = Appearance11
        UltraGridColumn8.Header.Caption = resources.GetString("resource.Caption7")
        UltraGridColumn8.Header.VisiblePosition = 2
        UltraGridColumn8.MaskInput = resources.GetString("UltraGridColumn8.MaskInput")
        UltraGridColumn8.NullText = resources.GetString("UltraGridColumn8.NullText")
        UltraGridColumn8.Width = 120
        UltraGridColumn9.Format = resources.GetString("UltraGridColumn9.Format")
        UltraGridColumn9.Header.Caption = resources.GetString("resource.Caption8")
        UltraGridColumn9.Header.VisiblePosition = 4
        UltraGridColumn9.Hidden = True
        UltraGridColumn9.MaskInput = resources.GetString("UltraGridColumn9.MaskInput")
        UltraGridColumn9.NullText = resources.GetString("UltraGridColumn9.NullText")
        UltraGridColumn10.Format = resources.GetString("UltraGridColumn10.Format")
        UltraGridColumn10.Header.Caption = resources.GetString("resource.Caption9")
        UltraGridColumn10.Header.VisiblePosition = 5
        UltraGridColumn10.Hidden = True
        UltraGridColumn10.MaskInput = resources.GetString("UltraGridColumn10.MaskInput")
        UltraGridColumn10.NullText = resources.GetString("UltraGridColumn10.NullText")
        UltraGridColumn11.Format = resources.GetString("UltraGridColumn11.Format")
        UltraGridColumn11.Header.Caption = resources.GetString("resource.Caption10")
        UltraGridColumn11.Header.VisiblePosition = 6
        UltraGridColumn11.Hidden = True
        UltraGridColumn11.MaskInput = resources.GetString("UltraGridColumn11.MaskInput")
        UltraGridColumn11.NullText = resources.GetString("UltraGridColumn11.NullText")
        UltraGridColumn12.Format = resources.GetString("UltraGridColumn12.Format")
        UltraGridColumn12.Header.Caption = resources.GetString("resource.Caption11")
        UltraGridColumn12.Header.VisiblePosition = 7
        UltraGridColumn12.Hidden = True
        UltraGridColumn12.MaskInput = resources.GetString("UltraGridColumn12.MaskInput")
        UltraGridColumn12.NullText = resources.GetString("UltraGridColumn12.NullText")
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12})
        UltraGridBand3.SummaryFooterCaption = resources.GetString("UltraGridBand3.SummaryFooterCaption")
        Me.CbDuong_Thu_Di_Den.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.CbDuong_Thu_Di_Den.DisplayLayout.Override.GroupByRowDescriptionMask = resources.GetString("resource.GroupByRowDescriptionMask1")
        Appearance12.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance12.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance12.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance12.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.CbDuong_Thu_Di_Den.DisplayLayout.Override.HeaderAppearance = Appearance12
        Me.CbDuong_Thu_Di_Den.DisplayLayout.Override.NullText = resources.GetString("resource.NullText1")
        Me.CbDuong_Thu_Di_Den.DisplayMember = "Ma_BC"
        Me.CbDuong_Thu_Di_Den.Dock = CType(resources.GetObject("CbDuong_Thu_Di_Den.Dock"), System.Windows.Forms.DockStyle)
        Me.CbDuong_Thu_Di_Den.Enabled = CType(resources.GetObject("CbDuong_Thu_Di_Den.Enabled"), Boolean)
        Me.CbDuong_Thu_Di_Den.Font = CType(resources.GetObject("CbDuong_Thu_Di_Den.Font"), System.Drawing.Font)
        Me.CbDuong_Thu_Di_Den.ImeMode = CType(resources.GetObject("CbDuong_Thu_Di_Den.ImeMode"), System.Windows.Forms.ImeMode)
        Me.CbDuong_Thu_Di_Den.Location = CType(resources.GetObject("CbDuong_Thu_Di_Den.Location"), System.Drawing.Point)
        Me.CbDuong_Thu_Di_Den.Name = "CbDuong_Thu_Di_Den"
        Me.CbDuong_Thu_Di_Den.RightToLeft = CType(resources.GetObject("CbDuong_Thu_Di_Den.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.CbDuong_Thu_Di_Den.Size = CType(resources.GetObject("CbDuong_Thu_Di_Den.Size"), System.Drawing.Size)
        Me.CbDuong_Thu_Di_Den.TabIndex = CType(resources.GetObject("CbDuong_Thu_Di_Den.TabIndex"), Integer)
        Me.CbDuong_Thu_Di_Den.Text = resources.GetString("CbDuong_Thu_Di_Den.Text")
        Me.CbDuong_Thu_Di_Den.ValueMember = "Ma_BC"
        Me.CbDuong_Thu_Di_Den.Visible = CType(resources.GetObject("CbDuong_Thu_Di_Den.Visible"), Boolean)
        '
        'OptDuong_Thu
        '
        Me.OptDuong_Thu.AccessibleDescription = resources.GetString("OptDuong_Thu.AccessibleDescription")
        Me.OptDuong_Thu.AccessibleName = resources.GetString("OptDuong_Thu.AccessibleName")
        Me.OptDuong_Thu.Anchor = CType(resources.GetObject("OptDuong_Thu.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.OptDuong_Thu.Appearance = CType(resources.GetObject("OptDuong_Thu.Appearance"), System.Windows.Forms.Appearance)
        Me.OptDuong_Thu.BackgroundImage = CType(resources.GetObject("OptDuong_Thu.BackgroundImage"), System.Drawing.Image)
        Me.OptDuong_Thu.CheckAlign = CType(resources.GetObject("OptDuong_Thu.CheckAlign"), System.Drawing.ContentAlignment)
        Me.OptDuong_Thu.Dock = CType(resources.GetObject("OptDuong_Thu.Dock"), System.Windows.Forms.DockStyle)
        Me.OptDuong_Thu.Enabled = CType(resources.GetObject("OptDuong_Thu.Enabled"), Boolean)
        Me.OptDuong_Thu.FlatStyle = CType(resources.GetObject("OptDuong_Thu.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.OptDuong_Thu.Font = CType(resources.GetObject("OptDuong_Thu.Font"), System.Drawing.Font)
        Me.OptDuong_Thu.Image = CType(resources.GetObject("OptDuong_Thu.Image"), System.Drawing.Image)
        Me.OptDuong_Thu.ImageAlign = CType(resources.GetObject("OptDuong_Thu.ImageAlign"), System.Drawing.ContentAlignment)
        Me.OptDuong_Thu.ImageIndex = CType(resources.GetObject("OptDuong_Thu.ImageIndex"), Integer)
        Me.OptDuong_Thu.ImeMode = CType(resources.GetObject("OptDuong_Thu.ImeMode"), System.Windows.Forms.ImeMode)
        Me.OptDuong_Thu.Location = CType(resources.GetObject("OptDuong_Thu.Location"), System.Drawing.Point)
        Me.OptDuong_Thu.Name = "OptDuong_Thu"
        Me.OptDuong_Thu.RightToLeft = CType(resources.GetObject("OptDuong_Thu.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.OptDuong_Thu.Size = CType(resources.GetObject("OptDuong_Thu.Size"), System.Drawing.Size)
        Me.OptDuong_Thu.TabIndex = CType(resources.GetObject("OptDuong_Thu.TabIndex"), Integer)
        Me.OptDuong_Thu.Text = resources.GetString("OptDuong_Thu.Text")
        Me.OptDuong_Thu.TextAlign = CType(resources.GetObject("OptDuong_Thu.TextAlign"), System.Drawing.ContentAlignment)
        Me.OptDuong_Thu.Visible = CType(resources.GetObject("OptDuong_Thu.Visible"), Boolean)
        '
        'OptTat_Ca
        '
        Me.OptTat_Ca.AccessibleDescription = resources.GetString("OptTat_Ca.AccessibleDescription")
        Me.OptTat_Ca.AccessibleName = resources.GetString("OptTat_Ca.AccessibleName")
        Me.OptTat_Ca.Anchor = CType(resources.GetObject("OptTat_Ca.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.OptTat_Ca.Appearance = CType(resources.GetObject("OptTat_Ca.Appearance"), System.Windows.Forms.Appearance)
        Me.OptTat_Ca.BackgroundImage = CType(resources.GetObject("OptTat_Ca.BackgroundImage"), System.Drawing.Image)
        Me.OptTat_Ca.CheckAlign = CType(resources.GetObject("OptTat_Ca.CheckAlign"), System.Drawing.ContentAlignment)
        Me.OptTat_Ca.Dock = CType(resources.GetObject("OptTat_Ca.Dock"), System.Windows.Forms.DockStyle)
        Me.OptTat_Ca.Enabled = CType(resources.GetObject("OptTat_Ca.Enabled"), Boolean)
        Me.OptTat_Ca.FlatStyle = CType(resources.GetObject("OptTat_Ca.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.OptTat_Ca.Font = CType(resources.GetObject("OptTat_Ca.Font"), System.Drawing.Font)
        Me.OptTat_Ca.Image = CType(resources.GetObject("OptTat_Ca.Image"), System.Drawing.Image)
        Me.OptTat_Ca.ImageAlign = CType(resources.GetObject("OptTat_Ca.ImageAlign"), System.Drawing.ContentAlignment)
        Me.OptTat_Ca.ImageIndex = CType(resources.GetObject("OptTat_Ca.ImageIndex"), Integer)
        Me.OptTat_Ca.ImeMode = CType(resources.GetObject("OptTat_Ca.ImeMode"), System.Windows.Forms.ImeMode)
        Me.OptTat_Ca.Location = CType(resources.GetObject("OptTat_Ca.Location"), System.Drawing.Point)
        Me.OptTat_Ca.Name = "OptTat_Ca"
        Me.OptTat_Ca.RightToLeft = CType(resources.GetObject("OptTat_Ca.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.OptTat_Ca.Size = CType(resources.GetObject("OptTat_Ca.Size"), System.Drawing.Size)
        Me.OptTat_Ca.TabIndex = CType(resources.GetObject("OptTat_Ca.TabIndex"), Integer)
        Me.OptTat_Ca.Text = resources.GetString("OptTat_Ca.Text")
        Me.OptTat_Ca.TextAlign = CType(resources.GetObject("OptTat_Ca.TextAlign"), System.Drawing.ContentAlignment)
        Me.OptTat_Ca.Visible = CType(resources.GetObject("OptTat_Ca.Visible"), Boolean)
        '
        'GroupBox2
        '
        Me.GroupBox2.AccessibleDescription = resources.GetString("GroupBox2.AccessibleDescription")
        Me.GroupBox2.AccessibleName = resources.GetString("GroupBox2.AccessibleName")
        Me.GroupBox2.Anchor = CType(resources.GetObject("GroupBox2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.CbMa_Ca)
        Me.GroupBox2.Controls.Add(Me.UltraLabel3)
        Me.GroupBox2.Controls.Add(Me.CbDen_Ngay)
        Me.GroupBox2.Controls.Add(Me.UltraLabel4)
        Me.GroupBox2.Controls.Add(Me.CbTu_Ngay)
        Me.GroupBox2.Controls.Add(Me.OptNgay_Kt)
        Me.GroupBox2.Controls.Add(Me.UltraLabel2)
        Me.GroupBox2.Controls.Add(Me.UltraLabel1)
        Me.GroupBox2.Controls.Add(Me.CbNgay_Kt)
        Me.GroupBox2.Controls.Add(Me.OptCa_kt)
        Me.GroupBox2.Dock = CType(resources.GetObject("GroupBox2.Dock"), System.Windows.Forms.DockStyle)
        Me.GroupBox2.Enabled = CType(resources.GetObject("GroupBox2.Enabled"), Boolean)
        Me.GroupBox2.Font = CType(resources.GetObject("GroupBox2.Font"), System.Drawing.Font)
        Me.GroupBox2.ImeMode = CType(resources.GetObject("GroupBox2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GroupBox2.Location = CType(resources.GetObject("GroupBox2.Location"), System.Drawing.Point)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = CType(resources.GetObject("GroupBox2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.GroupBox2.Size = CType(resources.GetObject("GroupBox2.Size"), System.Drawing.Size)
        Me.GroupBox2.TabIndex = CType(resources.GetObject("GroupBox2.TabIndex"), Integer)
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = resources.GetString("GroupBox2.Text")
        Me.GroupBox2.Visible = CType(resources.GetObject("GroupBox2.Visible"), Boolean)
        '
        'CbMa_Ca
        '
        Me.CbMa_Ca.AccessibleDescription = resources.GetString("CbMa_Ca.AccessibleDescription")
        Me.CbMa_Ca.AccessibleName = resources.GetString("CbMa_Ca.AccessibleName")
        Me.CbMa_Ca.Anchor = CType(resources.GetObject("CbMa_Ca.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.CbMa_Ca.BackgroundImage = CType(resources.GetObject("CbMa_Ca.BackgroundImage"), System.Drawing.Image)
        Me.CbMa_Ca.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridBand4.AddButtonCaption = resources.GetString("UltraGridBand4.AddButtonCaption")
        UltraGridBand4.AddButtonToolTipText = resources.GetString("UltraGridBand4.AddButtonToolTipText")
        UltraGridColumn13.Format = resources.GetString("UltraGridColumn13.Format")
        UltraGridColumn13.Header.Caption = resources.GetString("resource.Caption12")
        UltraGridColumn13.Header.VisiblePosition = 0
        UltraGridColumn13.Hidden = True
        UltraGridColumn13.MaskInput = resources.GetString("UltraGridColumn13.MaskInput")
        UltraGridColumn13.NullText = resources.GetString("UltraGridColumn13.NullText")
        UltraGridColumn14.Format = resources.GetString("UltraGridColumn14.Format")
        UltraGridColumn14.Header.Caption = resources.GetString("resource.Caption13")
        UltraGridColumn14.Header.VisiblePosition = 1
        UltraGridColumn14.Hidden = True
        UltraGridColumn14.MaskInput = resources.GetString("UltraGridColumn14.MaskInput")
        UltraGridColumn14.NullText = resources.GetString("UltraGridColumn14.NullText")
        UltraGridColumn15.Format = resources.GetString("UltraGridColumn15.Format")
        Appearance13.FontData.BoldAsString = resources.GetString("resource.BoldAsString4")
        Appearance13.FontData.ItalicAsString = resources.GetString("resource.ItalicAsString4")
        Appearance13.FontData.Name = resources.GetString("resource.Name4")
        Appearance13.FontData.SizeInPoints = CType(resources.GetObject("resource.SizeInPoints4"), Single)
        Appearance13.FontData.StrikeoutAsString = resources.GetString("resource.StrikeoutAsString4")
        Appearance13.FontData.UnderlineAsString = resources.GetString("resource.UnderlineAsString4")
        UltraGridColumn15.Header.Appearance = Appearance13
        UltraGridColumn15.Header.Caption = resources.GetString("resource.Caption14")
        UltraGridColumn15.Header.VisiblePosition = 2
        UltraGridColumn15.MaskInput = resources.GetString("UltraGridColumn15.MaskInput")
        UltraGridColumn15.NullText = resources.GetString("UltraGridColumn15.NullText")
        UltraGridColumn15.Width = 30
        UltraGridColumn16.Format = resources.GetString("UltraGridColumn16.Format")
        Appearance14.FontData.BoldAsString = resources.GetString("resource.BoldAsString5")
        Appearance14.FontData.ItalicAsString = resources.GetString("resource.ItalicAsString5")
        Appearance14.FontData.Name = resources.GetString("resource.Name5")
        Appearance14.FontData.SizeInPoints = CType(resources.GetObject("resource.SizeInPoints5"), Single)
        Appearance14.FontData.StrikeoutAsString = resources.GetString("resource.StrikeoutAsString5")
        Appearance14.FontData.UnderlineAsString = resources.GetString("resource.UnderlineAsString5")
        Appearance14.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn16.Header.Appearance = Appearance14
        UltraGridColumn16.Header.Caption = resources.GetString("resource.Caption15")
        UltraGridColumn16.Header.VisiblePosition = 3
        UltraGridColumn16.MaskInput = resources.GetString("UltraGridColumn16.MaskInput")
        UltraGridColumn16.NullText = resources.GetString("UltraGridColumn16.NullText")
        UltraGridColumn16.Width = 70
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16})
        UltraGridBand4.SummaryFooterCaption = resources.GetString("UltraGridBand4.SummaryFooterCaption")
        Me.CbMa_Ca.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.CbMa_Ca.DisplayLayout.Override.GroupByRowDescriptionMask = resources.GetString("resource.GroupByRowDescriptionMask2")
        Appearance15.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance15.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance15.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance15.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.CbMa_Ca.DisplayLayout.Override.HeaderAppearance = Appearance15
        Me.CbMa_Ca.DisplayLayout.Override.NullText = resources.GetString("resource.NullText2")
        Me.CbMa_Ca.DisplayMember = "Ca"
        Me.CbMa_Ca.Dock = CType(resources.GetObject("CbMa_Ca.Dock"), System.Windows.Forms.DockStyle)
        Me.CbMa_Ca.Enabled = CType(resources.GetObject("CbMa_Ca.Enabled"), Boolean)
        Me.CbMa_Ca.Font = CType(resources.GetObject("CbMa_Ca.Font"), System.Drawing.Font)
        Me.CbMa_Ca.ImeMode = CType(resources.GetObject("CbMa_Ca.ImeMode"), System.Windows.Forms.ImeMode)
        Me.CbMa_Ca.LimitToList = True
        Me.CbMa_Ca.Location = CType(resources.GetObject("CbMa_Ca.Location"), System.Drawing.Point)
        Me.CbMa_Ca.Name = "CbMa_Ca"
        Me.CbMa_Ca.RightToLeft = CType(resources.GetObject("CbMa_Ca.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.CbMa_Ca.Size = CType(resources.GetObject("CbMa_Ca.Size"), System.Drawing.Size)
        Me.CbMa_Ca.TabIndex = CType(resources.GetObject("CbMa_Ca.TabIndex"), Integer)
        Me.CbMa_Ca.Text = resources.GetString("CbMa_Ca.Text")
        Me.CbMa_Ca.ValueMember = "Thu_Tu"
        Me.CbMa_Ca.Visible = CType(resources.GetObject("CbMa_Ca.Visible"), Boolean)
        '
        'UltraLabel3
        '
        Me.UltraLabel3.AccessibleDescription = resources.GetString("UltraLabel3.AccessibleDescription")
        Me.UltraLabel3.AccessibleName = resources.GetString("UltraLabel3.AccessibleName")
        Me.UltraLabel3.Anchor = CType(resources.GetObject("UltraLabel3.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.UltraLabel3.AutoSize = CType(resources.GetObject("UltraLabel3.AutoSize"), Boolean)
        Me.UltraLabel3.BackgroundImage = CType(resources.GetObject("UltraLabel3.BackgroundImage"), System.Drawing.Image)
        Me.UltraLabel3.Dock = CType(resources.GetObject("UltraLabel3.Dock"), System.Windows.Forms.DockStyle)
        Me.UltraLabel3.Enabled = CType(resources.GetObject("UltraLabel3.Enabled"), Boolean)
        Me.UltraLabel3.Font = CType(resources.GetObject("UltraLabel3.Font"), System.Drawing.Font)
        Me.UltraLabel3.ImeMode = CType(resources.GetObject("UltraLabel3.ImeMode"), System.Windows.Forms.ImeMode)
        Me.UltraLabel3.Location = CType(resources.GetObject("UltraLabel3.Location"), System.Drawing.Point)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.RightToLeft = CType(resources.GetObject("UltraLabel3.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.UltraLabel3.Size = CType(resources.GetObject("UltraLabel3.Size"), System.Drawing.Size)
        Me.UltraLabel3.TabIndex = CType(resources.GetObject("UltraLabel3.TabIndex"), Integer)
        Me.UltraLabel3.Text = resources.GetString("UltraLabel3.Text")
        Me.UltraLabel3.Visible = CType(resources.GetObject("UltraLabel3.Visible"), Boolean)
        '
        'CbDen_Ngay
        '
        Me.CbDen_Ngay.AccessibleDescription = resources.GetString("CbDen_Ngay.AccessibleDescription")
        Me.CbDen_Ngay.AccessibleName = resources.GetString("CbDen_Ngay.AccessibleName")
        Me.CbDen_Ngay.Anchor = CType(resources.GetObject("CbDen_Ngay.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.CbDen_Ngay.BackgroundImage = CType(resources.GetObject("CbDen_Ngay.BackgroundImage"), System.Drawing.Image)
        Me.CbDen_Ngay.Dock = CType(resources.GetObject("CbDen_Ngay.Dock"), System.Windows.Forms.DockStyle)
        Me.CbDen_Ngay.Enabled = CType(resources.GetObject("CbDen_Ngay.Enabled"), Boolean)
        Me.CbDen_Ngay.Font = CType(resources.GetObject("CbDen_Ngay.Font"), System.Drawing.Font)
        Me.CbDen_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.CbDen_Ngay.ImeMode = CType(resources.GetObject("CbDen_Ngay.ImeMode"), System.Windows.Forms.ImeMode)
        Me.CbDen_Ngay.Location = CType(resources.GetObject("CbDen_Ngay.Location"), System.Drawing.Point)
        Me.CbDen_Ngay.Name = "CbDen_Ngay"
        Me.CbDen_Ngay.RightToLeft = CType(resources.GetObject("CbDen_Ngay.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.CbDen_Ngay.Size = CType(resources.GetObject("CbDen_Ngay.Size"), System.Drawing.Size)
        Me.CbDen_Ngay.TabIndex = CType(resources.GetObject("CbDen_Ngay.TabIndex"), Integer)
        Me.CbDen_Ngay.Visible = CType(resources.GetObject("CbDen_Ngay.Visible"), Boolean)
        '
        'UltraLabel4
        '
        Me.UltraLabel4.AccessibleDescription = resources.GetString("UltraLabel4.AccessibleDescription")
        Me.UltraLabel4.AccessibleName = resources.GetString("UltraLabel4.AccessibleName")
        Me.UltraLabel4.Anchor = CType(resources.GetObject("UltraLabel4.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.UltraLabel4.AutoSize = CType(resources.GetObject("UltraLabel4.AutoSize"), Boolean)
        Me.UltraLabel4.BackgroundImage = CType(resources.GetObject("UltraLabel4.BackgroundImage"), System.Drawing.Image)
        Me.UltraLabel4.Dock = CType(resources.GetObject("UltraLabel4.Dock"), System.Windows.Forms.DockStyle)
        Me.UltraLabel4.Enabled = CType(resources.GetObject("UltraLabel4.Enabled"), Boolean)
        Me.UltraLabel4.Font = CType(resources.GetObject("UltraLabel4.Font"), System.Drawing.Font)
        Me.UltraLabel4.ImeMode = CType(resources.GetObject("UltraLabel4.ImeMode"), System.Windows.Forms.ImeMode)
        Me.UltraLabel4.Location = CType(resources.GetObject("UltraLabel4.Location"), System.Drawing.Point)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.RightToLeft = CType(resources.GetObject("UltraLabel4.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.UltraLabel4.Size = CType(resources.GetObject("UltraLabel4.Size"), System.Drawing.Size)
        Me.UltraLabel4.TabIndex = CType(resources.GetObject("UltraLabel4.TabIndex"), Integer)
        Me.UltraLabel4.Text = resources.GetString("UltraLabel4.Text")
        Me.UltraLabel4.Visible = CType(resources.GetObject("UltraLabel4.Visible"), Boolean)
        '
        'CbTu_Ngay
        '
        Me.CbTu_Ngay.AccessibleDescription = resources.GetString("CbTu_Ngay.AccessibleDescription")
        Me.CbTu_Ngay.AccessibleName = resources.GetString("CbTu_Ngay.AccessibleName")
        Me.CbTu_Ngay.Anchor = CType(resources.GetObject("CbTu_Ngay.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.CbTu_Ngay.BackgroundImage = CType(resources.GetObject("CbTu_Ngay.BackgroundImage"), System.Drawing.Image)
        Me.CbTu_Ngay.DateTime = New Date(2008, 7, 3, 0, 0, 0, 0)
        Me.CbTu_Ngay.Dock = CType(resources.GetObject("CbTu_Ngay.Dock"), System.Windows.Forms.DockStyle)
        Me.CbTu_Ngay.Enabled = CType(resources.GetObject("CbTu_Ngay.Enabled"), Boolean)
        Me.CbTu_Ngay.Font = CType(resources.GetObject("CbTu_Ngay.Font"), System.Drawing.Font)
        Me.CbTu_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.CbTu_Ngay.ImeMode = CType(resources.GetObject("CbTu_Ngay.ImeMode"), System.Windows.Forms.ImeMode)
        Me.CbTu_Ngay.Location = CType(resources.GetObject("CbTu_Ngay.Location"), System.Drawing.Point)
        Me.CbTu_Ngay.Name = "CbTu_Ngay"
        Me.CbTu_Ngay.RightToLeft = CType(resources.GetObject("CbTu_Ngay.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.CbTu_Ngay.Size = CType(resources.GetObject("CbTu_Ngay.Size"), System.Drawing.Size)
        Me.CbTu_Ngay.TabIndex = CType(resources.GetObject("CbTu_Ngay.TabIndex"), Integer)
        Me.CbTu_Ngay.Value = New Date(2008, 7, 3, 0, 0, 0, 0)
        Me.CbTu_Ngay.Visible = CType(resources.GetObject("CbTu_Ngay.Visible"), Boolean)
        '
        'OptNgay_Kt
        '
        Me.OptNgay_Kt.AccessibleDescription = resources.GetString("OptNgay_Kt.AccessibleDescription")
        Me.OptNgay_Kt.AccessibleName = resources.GetString("OptNgay_Kt.AccessibleName")
        Me.OptNgay_Kt.Anchor = CType(resources.GetObject("OptNgay_Kt.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.OptNgay_Kt.Appearance = CType(resources.GetObject("OptNgay_Kt.Appearance"), System.Windows.Forms.Appearance)
        Me.OptNgay_Kt.BackgroundImage = CType(resources.GetObject("OptNgay_Kt.BackgroundImage"), System.Drawing.Image)
        Me.OptNgay_Kt.CheckAlign = CType(resources.GetObject("OptNgay_Kt.CheckAlign"), System.Drawing.ContentAlignment)
        Me.OptNgay_Kt.Dock = CType(resources.GetObject("OptNgay_Kt.Dock"), System.Windows.Forms.DockStyle)
        Me.OptNgay_Kt.Enabled = CType(resources.GetObject("OptNgay_Kt.Enabled"), Boolean)
        Me.OptNgay_Kt.FlatStyle = CType(resources.GetObject("OptNgay_Kt.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.OptNgay_Kt.Font = CType(resources.GetObject("OptNgay_Kt.Font"), System.Drawing.Font)
        Me.OptNgay_Kt.Image = CType(resources.GetObject("OptNgay_Kt.Image"), System.Drawing.Image)
        Me.OptNgay_Kt.ImageAlign = CType(resources.GetObject("OptNgay_Kt.ImageAlign"), System.Drawing.ContentAlignment)
        Me.OptNgay_Kt.ImageIndex = CType(resources.GetObject("OptNgay_Kt.ImageIndex"), Integer)
        Me.OptNgay_Kt.ImeMode = CType(resources.GetObject("OptNgay_Kt.ImeMode"), System.Windows.Forms.ImeMode)
        Me.OptNgay_Kt.Location = CType(resources.GetObject("OptNgay_Kt.Location"), System.Drawing.Point)
        Me.OptNgay_Kt.Name = "OptNgay_Kt"
        Me.OptNgay_Kt.RightToLeft = CType(resources.GetObject("OptNgay_Kt.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.OptNgay_Kt.Size = CType(resources.GetObject("OptNgay_Kt.Size"), System.Drawing.Size)
        Me.OptNgay_Kt.TabIndex = CType(resources.GetObject("OptNgay_Kt.TabIndex"), Integer)
        Me.OptNgay_Kt.Text = resources.GetString("OptNgay_Kt.Text")
        Me.OptNgay_Kt.TextAlign = CType(resources.GetObject("OptNgay_Kt.TextAlign"), System.Drawing.ContentAlignment)
        Me.OptNgay_Kt.Visible = CType(resources.GetObject("OptNgay_Kt.Visible"), Boolean)
        '
        'UltraLabel2
        '
        Me.UltraLabel2.AccessibleDescription = resources.GetString("UltraLabel2.AccessibleDescription")
        Me.UltraLabel2.AccessibleName = resources.GetString("UltraLabel2.AccessibleName")
        Me.UltraLabel2.Anchor = CType(resources.GetObject("UltraLabel2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.UltraLabel2.AutoSize = CType(resources.GetObject("UltraLabel2.AutoSize"), Boolean)
        Me.UltraLabel2.BackgroundImage = CType(resources.GetObject("UltraLabel2.BackgroundImage"), System.Drawing.Image)
        Me.UltraLabel2.Dock = CType(resources.GetObject("UltraLabel2.Dock"), System.Windows.Forms.DockStyle)
        Me.UltraLabel2.Enabled = CType(resources.GetObject("UltraLabel2.Enabled"), Boolean)
        Me.UltraLabel2.Font = CType(resources.GetObject("UltraLabel2.Font"), System.Drawing.Font)
        Me.UltraLabel2.ImeMode = CType(resources.GetObject("UltraLabel2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.UltraLabel2.Location = CType(resources.GetObject("UltraLabel2.Location"), System.Drawing.Point)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.RightToLeft = CType(resources.GetObject("UltraLabel2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.UltraLabel2.Size = CType(resources.GetObject("UltraLabel2.Size"), System.Drawing.Size)
        Me.UltraLabel2.TabIndex = CType(resources.GetObject("UltraLabel2.TabIndex"), Integer)
        Me.UltraLabel2.Text = resources.GetString("UltraLabel2.Text")
        Me.UltraLabel2.Visible = CType(resources.GetObject("UltraLabel2.Visible"), Boolean)
        '
        'UltraLabel1
        '
        Me.UltraLabel1.AccessibleDescription = resources.GetString("UltraLabel1.AccessibleDescription")
        Me.UltraLabel1.AccessibleName = resources.GetString("UltraLabel1.AccessibleName")
        Me.UltraLabel1.Anchor = CType(resources.GetObject("UltraLabel1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.UltraLabel1.AutoSize = CType(resources.GetObject("UltraLabel1.AutoSize"), Boolean)
        Me.UltraLabel1.BackgroundImage = CType(resources.GetObject("UltraLabel1.BackgroundImage"), System.Drawing.Image)
        Me.UltraLabel1.Dock = CType(resources.GetObject("UltraLabel1.Dock"), System.Windows.Forms.DockStyle)
        Me.UltraLabel1.Enabled = CType(resources.GetObject("UltraLabel1.Enabled"), Boolean)
        Me.UltraLabel1.Font = CType(resources.GetObject("UltraLabel1.Font"), System.Drawing.Font)
        Me.UltraLabel1.ImeMode = CType(resources.GetObject("UltraLabel1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.UltraLabel1.Location = CType(resources.GetObject("UltraLabel1.Location"), System.Drawing.Point)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.RightToLeft = CType(resources.GetObject("UltraLabel1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.UltraLabel1.Size = CType(resources.GetObject("UltraLabel1.Size"), System.Drawing.Size)
        Me.UltraLabel1.TabIndex = CType(resources.GetObject("UltraLabel1.TabIndex"), Integer)
        Me.UltraLabel1.Text = resources.GetString("UltraLabel1.Text")
        Me.UltraLabel1.Visible = CType(resources.GetObject("UltraLabel1.Visible"), Boolean)
        '
        'CbNgay_Kt
        '
        Me.CbNgay_Kt.AccessibleDescription = resources.GetString("CbNgay_Kt.AccessibleDescription")
        Me.CbNgay_Kt.AccessibleName = resources.GetString("CbNgay_Kt.AccessibleName")
        Me.CbNgay_Kt.Anchor = CType(resources.GetObject("CbNgay_Kt.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.CbNgay_Kt.BackgroundImage = CType(resources.GetObject("CbNgay_Kt.BackgroundImage"), System.Drawing.Image)
        Me.CbNgay_Kt.Dock = CType(resources.GetObject("CbNgay_Kt.Dock"), System.Windows.Forms.DockStyle)
        Me.CbNgay_Kt.Enabled = CType(resources.GetObject("CbNgay_Kt.Enabled"), Boolean)
        Me.CbNgay_Kt.Font = CType(resources.GetObject("CbNgay_Kt.Font"), System.Drawing.Font)
        Me.CbNgay_Kt.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.CbNgay_Kt.ImeMode = CType(resources.GetObject("CbNgay_Kt.ImeMode"), System.Windows.Forms.ImeMode)
        Me.CbNgay_Kt.Location = CType(resources.GetObject("CbNgay_Kt.Location"), System.Drawing.Point)
        Me.CbNgay_Kt.Name = "CbNgay_Kt"
        Me.CbNgay_Kt.RightToLeft = CType(resources.GetObject("CbNgay_Kt.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.CbNgay_Kt.Size = CType(resources.GetObject("CbNgay_Kt.Size"), System.Drawing.Size)
        Me.CbNgay_Kt.TabIndex = CType(resources.GetObject("CbNgay_Kt.TabIndex"), Integer)
        Me.CbNgay_Kt.Visible = CType(resources.GetObject("CbNgay_Kt.Visible"), Boolean)
        '
        'OptCa_kt
        '
        Me.OptCa_kt.AccessibleDescription = resources.GetString("OptCa_kt.AccessibleDescription")
        Me.OptCa_kt.AccessibleName = resources.GetString("OptCa_kt.AccessibleName")
        Me.OptCa_kt.Anchor = CType(resources.GetObject("OptCa_kt.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.OptCa_kt.Appearance = CType(resources.GetObject("OptCa_kt.Appearance"), System.Windows.Forms.Appearance)
        Me.OptCa_kt.BackgroundImage = CType(resources.GetObject("OptCa_kt.BackgroundImage"), System.Drawing.Image)
        Me.OptCa_kt.CheckAlign = CType(resources.GetObject("OptCa_kt.CheckAlign"), System.Drawing.ContentAlignment)
        Me.OptCa_kt.Dock = CType(resources.GetObject("OptCa_kt.Dock"), System.Windows.Forms.DockStyle)
        Me.OptCa_kt.Enabled = CType(resources.GetObject("OptCa_kt.Enabled"), Boolean)
        Me.OptCa_kt.FlatStyle = CType(resources.GetObject("OptCa_kt.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.OptCa_kt.Font = CType(resources.GetObject("OptCa_kt.Font"), System.Drawing.Font)
        Me.OptCa_kt.Image = CType(resources.GetObject("OptCa_kt.Image"), System.Drawing.Image)
        Me.OptCa_kt.ImageAlign = CType(resources.GetObject("OptCa_kt.ImageAlign"), System.Drawing.ContentAlignment)
        Me.OptCa_kt.ImageIndex = CType(resources.GetObject("OptCa_kt.ImageIndex"), Integer)
        Me.OptCa_kt.ImeMode = CType(resources.GetObject("OptCa_kt.ImeMode"), System.Windows.Forms.ImeMode)
        Me.OptCa_kt.Location = CType(resources.GetObject("OptCa_kt.Location"), System.Drawing.Point)
        Me.OptCa_kt.Name = "OptCa_kt"
        Me.OptCa_kt.RightToLeft = CType(resources.GetObject("OptCa_kt.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.OptCa_kt.Size = CType(resources.GetObject("OptCa_kt.Size"), System.Drawing.Size)
        Me.OptCa_kt.TabIndex = CType(resources.GetObject("OptCa_kt.TabIndex"), Integer)
        Me.OptCa_kt.Text = resources.GetString("OptCa_kt.Text")
        Me.OptCa_kt.TextAlign = CType(resources.GetObject("OptCa_kt.TextAlign"), System.Drawing.ContentAlignment)
        Me.OptCa_kt.Visible = CType(resources.GetObject("OptCa_kt.Visible"), Boolean)
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleDescription = resources.GetString("GroupBox1.AccessibleDescription")
        Me.GroupBox1.AccessibleName = resources.GetString("GroupBox1.AccessibleName")
        Me.GroupBox1.Anchor = CType(resources.GetObject("GroupBox1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.OptHang_di)
        Me.GroupBox1.Controls.Add(Me.OptHang_Den)
        Me.GroupBox1.Dock = CType(resources.GetObject("GroupBox1.Dock"), System.Windows.Forms.DockStyle)
        Me.GroupBox1.Enabled = CType(resources.GetObject("GroupBox1.Enabled"), Boolean)
        Me.GroupBox1.Font = CType(resources.GetObject("GroupBox1.Font"), System.Drawing.Font)
        Me.GroupBox1.ImeMode = CType(resources.GetObject("GroupBox1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GroupBox1.Location = CType(resources.GetObject("GroupBox1.Location"), System.Drawing.Point)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = CType(resources.GetObject("GroupBox1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.GroupBox1.Size = CType(resources.GetObject("GroupBox1.Size"), System.Drawing.Size)
        Me.GroupBox1.TabIndex = CType(resources.GetObject("GroupBox1.TabIndex"), Integer)
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = resources.GetString("GroupBox1.Text")
        Me.GroupBox1.Visible = CType(resources.GetObject("GroupBox1.Visible"), Boolean)
        '
        'OptHang_di
        '
        Me.OptHang_di.AccessibleDescription = resources.GetString("OptHang_di.AccessibleDescription")
        Me.OptHang_di.AccessibleName = resources.GetString("OptHang_di.AccessibleName")
        Me.OptHang_di.Anchor = CType(resources.GetObject("OptHang_di.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.OptHang_di.Appearance = CType(resources.GetObject("OptHang_di.Appearance"), System.Windows.Forms.Appearance)
        Me.OptHang_di.BackgroundImage = CType(resources.GetObject("OptHang_di.BackgroundImage"), System.Drawing.Image)
        Me.OptHang_di.CheckAlign = CType(resources.GetObject("OptHang_di.CheckAlign"), System.Drawing.ContentAlignment)
        Me.OptHang_di.Dock = CType(resources.GetObject("OptHang_di.Dock"), System.Windows.Forms.DockStyle)
        Me.OptHang_di.Enabled = CType(resources.GetObject("OptHang_di.Enabled"), Boolean)
        Me.OptHang_di.FlatStyle = CType(resources.GetObject("OptHang_di.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.OptHang_di.Font = CType(resources.GetObject("OptHang_di.Font"), System.Drawing.Font)
        Me.OptHang_di.Image = CType(resources.GetObject("OptHang_di.Image"), System.Drawing.Image)
        Me.OptHang_di.ImageAlign = CType(resources.GetObject("OptHang_di.ImageAlign"), System.Drawing.ContentAlignment)
        Me.OptHang_di.ImageIndex = CType(resources.GetObject("OptHang_di.ImageIndex"), Integer)
        Me.OptHang_di.ImeMode = CType(resources.GetObject("OptHang_di.ImeMode"), System.Windows.Forms.ImeMode)
        Me.OptHang_di.Location = CType(resources.GetObject("OptHang_di.Location"), System.Drawing.Point)
        Me.OptHang_di.Name = "OptHang_di"
        Me.OptHang_di.RightToLeft = CType(resources.GetObject("OptHang_di.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.OptHang_di.Size = CType(resources.GetObject("OptHang_di.Size"), System.Drawing.Size)
        Me.OptHang_di.TabIndex = CType(resources.GetObject("OptHang_di.TabIndex"), Integer)
        Me.OptHang_di.Text = resources.GetString("OptHang_di.Text")
        Me.OptHang_di.TextAlign = CType(resources.GetObject("OptHang_di.TextAlign"), System.Drawing.ContentAlignment)
        Me.OptHang_di.Visible = CType(resources.GetObject("OptHang_di.Visible"), Boolean)
        '
        'OptHang_Den
        '
        Me.OptHang_Den.AccessibleDescription = resources.GetString("OptHang_Den.AccessibleDescription")
        Me.OptHang_Den.AccessibleName = resources.GetString("OptHang_Den.AccessibleName")
        Me.OptHang_Den.Anchor = CType(resources.GetObject("OptHang_Den.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.OptHang_Den.Appearance = CType(resources.GetObject("OptHang_Den.Appearance"), System.Windows.Forms.Appearance)
        Me.OptHang_Den.BackgroundImage = CType(resources.GetObject("OptHang_Den.BackgroundImage"), System.Drawing.Image)
        Me.OptHang_Den.CheckAlign = CType(resources.GetObject("OptHang_Den.CheckAlign"), System.Drawing.ContentAlignment)
        Me.OptHang_Den.Dock = CType(resources.GetObject("OptHang_Den.Dock"), System.Windows.Forms.DockStyle)
        Me.OptHang_Den.Enabled = CType(resources.GetObject("OptHang_Den.Enabled"), Boolean)
        Me.OptHang_Den.FlatStyle = CType(resources.GetObject("OptHang_Den.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.OptHang_Den.Font = CType(resources.GetObject("OptHang_Den.Font"), System.Drawing.Font)
        Me.OptHang_Den.Image = CType(resources.GetObject("OptHang_Den.Image"), System.Drawing.Image)
        Me.OptHang_Den.ImageAlign = CType(resources.GetObject("OptHang_Den.ImageAlign"), System.Drawing.ContentAlignment)
        Me.OptHang_Den.ImageIndex = CType(resources.GetObject("OptHang_Den.ImageIndex"), Integer)
        Me.OptHang_Den.ImeMode = CType(resources.GetObject("OptHang_Den.ImeMode"), System.Windows.Forms.ImeMode)
        Me.OptHang_Den.Location = CType(resources.GetObject("OptHang_Den.Location"), System.Drawing.Point)
        Me.OptHang_Den.Name = "OptHang_Den"
        Me.OptHang_Den.RightToLeft = CType(resources.GetObject("OptHang_Den.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.OptHang_Den.Size = CType(resources.GetObject("OptHang_Den.Size"), System.Drawing.Size)
        Me.OptHang_Den.TabIndex = CType(resources.GetObject("OptHang_Den.TabIndex"), Integer)
        Me.OptHang_Den.Text = resources.GetString("OptHang_Den.Text")
        Me.OptHang_Den.TextAlign = CType(resources.GetObject("OptHang_Den.TextAlign"), System.Drawing.ContentAlignment)
        Me.OptHang_Den.Visible = CType(resources.GetObject("OptHang_Den.Visible"), Boolean)
        '
        'groupDichVu
        '
        Me.groupDichVu.AccessibleDescription = resources.GetString("groupDichVu.AccessibleDescription")
        Me.groupDichVu.AccessibleName = resources.GetString("groupDichVu.AccessibleName")
        Me.groupDichVu.Anchor = CType(resources.GetObject("groupDichVu.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.groupDichVu.BackgroundImage = CType(resources.GetObject("groupDichVu.BackgroundImage"), System.Drawing.Image)
        Me.groupDichVu.Controls.Add(Me.optDvuEMS)
        Me.groupDichVu.Controls.Add(Me.optDvuBuuKien)
        Me.groupDichVu.Controls.Add(Me.optDvuTatCa)
        Me.groupDichVu.Dock = CType(resources.GetObject("groupDichVu.Dock"), System.Windows.Forms.DockStyle)
        Me.groupDichVu.Enabled = CType(resources.GetObject("groupDichVu.Enabled"), Boolean)
        Me.groupDichVu.Font = CType(resources.GetObject("groupDichVu.Font"), System.Drawing.Font)
        Me.groupDichVu.ImeMode = CType(resources.GetObject("groupDichVu.ImeMode"), System.Windows.Forms.ImeMode)
        Me.groupDichVu.Location = CType(resources.GetObject("groupDichVu.Location"), System.Drawing.Point)
        Me.groupDichVu.Name = "groupDichVu"
        Me.groupDichVu.RightToLeft = CType(resources.GetObject("groupDichVu.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.groupDichVu.Size = CType(resources.GetObject("groupDichVu.Size"), System.Drawing.Size)
        Me.groupDichVu.TabIndex = CType(resources.GetObject("groupDichVu.TabIndex"), Integer)
        Me.groupDichVu.TabStop = False
        Me.groupDichVu.Text = resources.GetString("groupDichVu.Text")
        Me.groupDichVu.Visible = CType(resources.GetObject("groupDichVu.Visible"), Boolean)
        '
        'optDvuEMS
        '
        Me.optDvuEMS.AccessibleDescription = resources.GetString("optDvuEMS.AccessibleDescription")
        Me.optDvuEMS.AccessibleName = resources.GetString("optDvuEMS.AccessibleName")
        Me.optDvuEMS.Anchor = CType(resources.GetObject("optDvuEMS.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.optDvuEMS.Appearance = CType(resources.GetObject("optDvuEMS.Appearance"), System.Windows.Forms.Appearance)
        Me.optDvuEMS.BackgroundImage = CType(resources.GetObject("optDvuEMS.BackgroundImage"), System.Drawing.Image)
        Me.optDvuEMS.CheckAlign = CType(resources.GetObject("optDvuEMS.CheckAlign"), System.Drawing.ContentAlignment)
        Me.optDvuEMS.Dock = CType(resources.GetObject("optDvuEMS.Dock"), System.Windows.Forms.DockStyle)
        Me.optDvuEMS.Enabled = CType(resources.GetObject("optDvuEMS.Enabled"), Boolean)
        Me.optDvuEMS.FlatStyle = CType(resources.GetObject("optDvuEMS.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.optDvuEMS.Font = CType(resources.GetObject("optDvuEMS.Font"), System.Drawing.Font)
        Me.optDvuEMS.Image = CType(resources.GetObject("optDvuEMS.Image"), System.Drawing.Image)
        Me.optDvuEMS.ImageAlign = CType(resources.GetObject("optDvuEMS.ImageAlign"), System.Drawing.ContentAlignment)
        Me.optDvuEMS.ImageIndex = CType(resources.GetObject("optDvuEMS.ImageIndex"), Integer)
        Me.optDvuEMS.ImeMode = CType(resources.GetObject("optDvuEMS.ImeMode"), System.Windows.Forms.ImeMode)
        Me.optDvuEMS.Location = CType(resources.GetObject("optDvuEMS.Location"), System.Drawing.Point)
        Me.optDvuEMS.Name = "optDvuEMS"
        Me.optDvuEMS.RightToLeft = CType(resources.GetObject("optDvuEMS.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.optDvuEMS.Size = CType(resources.GetObject("optDvuEMS.Size"), System.Drawing.Size)
        Me.optDvuEMS.TabIndex = CType(resources.GetObject("optDvuEMS.TabIndex"), Integer)
        Me.optDvuEMS.Text = resources.GetString("optDvuEMS.Text")
        Me.optDvuEMS.TextAlign = CType(resources.GetObject("optDvuEMS.TextAlign"), System.Drawing.ContentAlignment)
        Me.optDvuEMS.Visible = CType(resources.GetObject("optDvuEMS.Visible"), Boolean)
        '
        'optDvuBuuKien
        '
        Me.optDvuBuuKien.AccessibleDescription = resources.GetString("optDvuBuuKien.AccessibleDescription")
        Me.optDvuBuuKien.AccessibleName = resources.GetString("optDvuBuuKien.AccessibleName")
        Me.optDvuBuuKien.Anchor = CType(resources.GetObject("optDvuBuuKien.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.optDvuBuuKien.Appearance = CType(resources.GetObject("optDvuBuuKien.Appearance"), System.Windows.Forms.Appearance)
        Me.optDvuBuuKien.BackgroundImage = CType(resources.GetObject("optDvuBuuKien.BackgroundImage"), System.Drawing.Image)
        Me.optDvuBuuKien.CheckAlign = CType(resources.GetObject("optDvuBuuKien.CheckAlign"), System.Drawing.ContentAlignment)
        Me.optDvuBuuKien.Dock = CType(resources.GetObject("optDvuBuuKien.Dock"), System.Windows.Forms.DockStyle)
        Me.optDvuBuuKien.Enabled = CType(resources.GetObject("optDvuBuuKien.Enabled"), Boolean)
        Me.optDvuBuuKien.FlatStyle = CType(resources.GetObject("optDvuBuuKien.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.optDvuBuuKien.Font = CType(resources.GetObject("optDvuBuuKien.Font"), System.Drawing.Font)
        Me.optDvuBuuKien.Image = CType(resources.GetObject("optDvuBuuKien.Image"), System.Drawing.Image)
        Me.optDvuBuuKien.ImageAlign = CType(resources.GetObject("optDvuBuuKien.ImageAlign"), System.Drawing.ContentAlignment)
        Me.optDvuBuuKien.ImageIndex = CType(resources.GetObject("optDvuBuuKien.ImageIndex"), Integer)
        Me.optDvuBuuKien.ImeMode = CType(resources.GetObject("optDvuBuuKien.ImeMode"), System.Windows.Forms.ImeMode)
        Me.optDvuBuuKien.Location = CType(resources.GetObject("optDvuBuuKien.Location"), System.Drawing.Point)
        Me.optDvuBuuKien.Name = "optDvuBuuKien"
        Me.optDvuBuuKien.RightToLeft = CType(resources.GetObject("optDvuBuuKien.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.optDvuBuuKien.Size = CType(resources.GetObject("optDvuBuuKien.Size"), System.Drawing.Size)
        Me.optDvuBuuKien.TabIndex = CType(resources.GetObject("optDvuBuuKien.TabIndex"), Integer)
        Me.optDvuBuuKien.Text = resources.GetString("optDvuBuuKien.Text")
        Me.optDvuBuuKien.TextAlign = CType(resources.GetObject("optDvuBuuKien.TextAlign"), System.Drawing.ContentAlignment)
        Me.optDvuBuuKien.Visible = CType(resources.GetObject("optDvuBuuKien.Visible"), Boolean)
        '
        'optDvuTatCa
        '
        Me.optDvuTatCa.AccessibleDescription = resources.GetString("optDvuTatCa.AccessibleDescription")
        Me.optDvuTatCa.AccessibleName = resources.GetString("optDvuTatCa.AccessibleName")
        Me.optDvuTatCa.Anchor = CType(resources.GetObject("optDvuTatCa.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.optDvuTatCa.Appearance = CType(resources.GetObject("optDvuTatCa.Appearance"), System.Windows.Forms.Appearance)
        Me.optDvuTatCa.BackgroundImage = CType(resources.GetObject("optDvuTatCa.BackgroundImage"), System.Drawing.Image)
        Me.optDvuTatCa.CheckAlign = CType(resources.GetObject("optDvuTatCa.CheckAlign"), System.Drawing.ContentAlignment)
        Me.optDvuTatCa.Dock = CType(resources.GetObject("optDvuTatCa.Dock"), System.Windows.Forms.DockStyle)
        Me.optDvuTatCa.Enabled = CType(resources.GetObject("optDvuTatCa.Enabled"), Boolean)
        Me.optDvuTatCa.FlatStyle = CType(resources.GetObject("optDvuTatCa.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.optDvuTatCa.Font = CType(resources.GetObject("optDvuTatCa.Font"), System.Drawing.Font)
        Me.optDvuTatCa.Image = CType(resources.GetObject("optDvuTatCa.Image"), System.Drawing.Image)
        Me.optDvuTatCa.ImageAlign = CType(resources.GetObject("optDvuTatCa.ImageAlign"), System.Drawing.ContentAlignment)
        Me.optDvuTatCa.ImageIndex = CType(resources.GetObject("optDvuTatCa.ImageIndex"), Integer)
        Me.optDvuTatCa.ImeMode = CType(resources.GetObject("optDvuTatCa.ImeMode"), System.Windows.Forms.ImeMode)
        Me.optDvuTatCa.Location = CType(resources.GetObject("optDvuTatCa.Location"), System.Drawing.Point)
        Me.optDvuTatCa.Name = "optDvuTatCa"
        Me.optDvuTatCa.RightToLeft = CType(resources.GetObject("optDvuTatCa.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.optDvuTatCa.Size = CType(resources.GetObject("optDvuTatCa.Size"), System.Drawing.Size)
        Me.optDvuTatCa.TabIndex = CType(resources.GetObject("optDvuTatCa.TabIndex"), Integer)
        Me.optDvuTatCa.Text = resources.GetString("optDvuTatCa.Text")
        Me.optDvuTatCa.TextAlign = CType(resources.GetObject("optDvuTatCa.TextAlign"), System.Drawing.ContentAlignment)
        Me.optDvuTatCa.Visible = CType(resources.GetObject("optDvuTatCa.Visible"), Boolean)
        '
        'FrmTongHopSanLuong
        '
        Me.AccessibleDescription = resources.GetString("$this.AccessibleDescription")
        Me.AccessibleName = resources.GetString("$this.AccessibleName")
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleBaseSize = CType(resources.GetObject("$this.AutoScaleBaseSize"), System.Drawing.Size)
        Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"), Boolean)
        Me.AutoScrollMargin = CType(resources.GetObject("$this.AutoScrollMargin"), System.Drawing.Size)
        Me.AutoScrollMinSize = CType(resources.GetObject("$this.AutoScrollMinSize"), System.Drawing.Size)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = CType(resources.GetObject("$this.ClientSize"), System.Drawing.Size)
        Me.ControlBox = False
        Me.Controls.Add(Me.groupDichVu)
        Me.Controls.Add(Me.CbTuy_Chon_Bao_Cao)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.BtnPreview)
        Me.Controls.Add(Me.LbThong_Tin)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.KeyPreview = True
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximizeBox = False
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimizeBox = False
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "FrmTongHopSanLuong"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ShowInTaskbar = False
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        CType(Me.CbTuy_Chon_Bao_Cao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.CbPL_Duong_Thu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbDuong_Thu_Di_Den, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.CbMa_Ca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbDen_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbTu_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbNgay_Kt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.groupDichVu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Khai báo các biến cục bộ trong Form"
    Dim Id_Ca_Ngaycakt As String
    Dim Tu_Ngay_KT As Integer
    Dim Den_Ngay_KT As Integer
    Dim myCaSanXuat As New Ca_San_Xuat(GConnectionString)
    Dim myCaSanXuatChiTiet As New Ca_San_Xuat_Chi_Tiet
    Dim myColumn As Infragistics.Win.UltraWinGrid.UltraGridColumn = Nothing
    Private myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Dim myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Dim myMa_Ca As New Ma_Ca(GConnectionString)
    Dim myham_dung_chung As New Ham_Dung_Chung
    Dim myE2_Den As New E2_Den(GConnectionString)
    Dim myE2_Di As New E2_Di(GConnectionString)
    Dim myE1_Den As New E1_Den(GConnectionString)
    Dim myKe_Toan_Ca As New Ke_Toan_Ca(GConnectionString)
    Dim myDuong_Thu_Den As New Duong_Thu_Den(GConnectionString)
    Dim myDuong_Thu_Di As New Duong_Thu_Di(GConnectionString)
    Dim _pThamSo As New ParameterDiscreteValue
    Dim Rpt_Thoi_Gian As String ' hien thi thoi gian,ca, tu ngay den ngay trong rpt
    Dim Rpt_Menu_Tieu_De As String ' hien thi tieu de bao cao
#End Region

#Region "Tạo bảng Tuỳ chọn báo cáo"
    Private Sub Tuy_Chon_Bao_Cao()
        Try
            'Them moi mot bang
            Dim dataTable As New dataTable("Tuy_Chon_Bao_Cao")

            'Tao ra cac cot cua bang nay
            Dim colWork As DataColumn = New DataColumn("Ma_Bao_Cao", GetType(Integer))
            dataTable.Columns.Add(colWork)
            colWork = New DataColumn("Ten_Bao_Cao", GetType(String))
            dataTable.Columns.Add(colWork)

            'Them du lieu vao
            Dim row As DataRow = dataTable.NewRow()
            row("Ma_Bao_Cao") = 1
            row("Ten_Bao_Cao") = "Tổng hợp sản lượng, doanh thu Theo Túi số"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Ma_Bao_Cao") = 2
            row("Ten_Bao_Cao") = "Tổng hợp sản lượng, doanh thu Theo Chuyến thư"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Ma_Bao_Cao") = 3
            row("Ten_Bao_Cao") = "Tổng hợp sản lượng, doanh thu Theo Đường thư"
            dataTable.Rows.Add(row)

            CbTuy_Chon_Bao_Cao.DataSource = dataTable
            CbTuy_Chon_Bao_Cao.DataBind()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Bảng phân loại đường thư"
    Private Sub Tao_Bang_Phan_Loai_Duong_Thu()
        Dim dataTable As New dataTable("Phan_Loai_Duong_Thu")

        Dim colWork As DataColumn = New DataColumn("Ma_Phan_Loai", GetType(Integer))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Ten_Phan_Loai", GetType(String))
        dataTable.Columns.Add(colWork)

        Dim row As DataRow = dataTable.NewRow()
        row("Ma_Phan_Loai") = "0"
        row("Ten_Phan_Loai") = "Bưu Tá"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Ma_Phan_Loai") = "1"
        row("Ten_Phan_Loai") = "Nội Tỉnh"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Ma_Phan_Loai") = "2"
        row("Ten_Phan_Loai") = "Liên Tỉnh"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Ma_Phan_Loai") = "3"
        row("Ten_Phan_Loai") = "Liền Kề"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Ma_Phan_Loai") = "4"
        row("Ten_Phan_Loai") = "Quốc Tế"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Ma_Phan_Loai") = "5"
        row("Ten_Phan_Loai") = "Lưu Kho"
        dataTable.Rows.Add(row)

        CbPL_Duong_Thu.DataSource = dataTable
        CbPL_Duong_Thu.DataBind()
    End Sub
#End Region

#Region "DataGridMa_Ca"
    Private Sub DataGridMa_Ca()
        Try
            CbMa_Ca.DataSource = myMa_Ca.Lay_Boi_Ma_Bc_Khai_Thac(GBuu_Cuc_Khai_Thac)
            CbMa_Ca.DataBind()
            myCaSanXuatChiTiet = myCaSanXuat.Lay(GId_Ca)
            If GId_Ca <> "" Then
                CbMa_Ca.Value = myCaSanXuatChiTiet.Thu_Tu
                CbNgay_Kt.Value = myCaSanXuatChiTiet.Ngay_Khai_Thac
            Else
                If CbMa_Ca.Rows.Count > 0 Then
                    CbMa_Ca.Value = CbMa_Ca.Rows(0).Cells("Thu_Tu").Value
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "FrmTongHopSanLuong_Load"
    Private Sub FrmTongHopSanLuong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & " ( " & GBuu_Cuc_Khai_Thac & " - " & GTen_Buu_Cuc_Khai_Thac & " )"
        LbThong_Tin.Text = "Tổng hợp sản lượng" & vbNewLine & "Đơn vị Khai Thác : " & GTen_Buu_Cuc_Khai_Thac
        Tuy_Chon_Bao_Cao()
        DataGridMa_Ca()
        OptHang_Den.Checked = True
        OptCa_kt.Checked = True
        OptTat_Ca.Checked = True
        CbTu_Ngay.Value = myham_dung_chung.dBeginMonth(Date.Now)
        CbTu_Ngay.Enabled = False
        CbDen_Ngay.Enabled = False
        OptTat_Ca_CheckedChanged(sender, e)
        BtnPreview.Enabled = False
        BtnPrint.Enabled = False
        Tao_Bang_Phan_Loai_Duong_Thu()
        optDvuTatCa.Checked = True
    End Sub
#End Region

#Region "CbTu_Ngay_AfterExitEditMode"
    Private Sub CbTu_Ngay_AfterExitEditMode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CbTu_Ngay.Value > CbDen_Ngay.Value Then
            CMessageBox.Show("Giá trị Từ ngày không được lớn hơn giá trị đến ngày !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CbTu_Ngay.Focus()
            Exit Sub
        End If
    End Sub
#End Region

#Region "CbDen_Ngay_AfterExitEditMode"
    Private Sub CbDen_Ngay_AfterExitEditMode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CbTu_Ngay.Value > CbDen_Ngay.Value Then
            CMessageBox.Show("Giá trị Đến ngày phải luôn lớn hơn giá trị từ ngày !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CbDen_Ngay.Focus()
            Exit Sub
        End If
    End Sub
#End Region

#Region "OPT CheckedChanged - Các sự kiện CheckedChanged của Option"

#Region "OptHang_Den_CheckedChanged"
    Private Sub OptHang_Den_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptHang_Den.CheckedChanged
        Try
            If OptHang_Den.Checked = True Then
                LbThong_Tin.Text = "Tổng hợp sản lượng hàng đến" & vbNewLine & "Đơn vị Khai Thác : " & GTen_Buu_Cuc_Khai_Thac
                Rpt_Menu_Tieu_De = "THỐNG KÊ SẢN LƯỢNG ĐẾN"
                CbDuong_Thu_Di_Den.DataSource = myDuong_Thu_Den.Lay_Boi_Ma_Bc_Khai_Thac(GBuu_Cuc_Khai_Thac)
                groupDichVu.Enabled = True
            Else
                LbThong_Tin.Text = "Tổng hợp sản lượng hàng đi " & vbNewLine & "Đơn vị Khai Thác : " & GTen_Buu_Cuc_Khai_Thac
                Rpt_Menu_Tieu_De = "THỐNG KÊ SẢN LƯỢNG ĐI"
                CbDuong_Thu_Di_Den.DataSource = myDuong_Thu_Di.Lay_Boi_Ma_Bc_Khai_Thac(GBuu_Cuc_Khai_Thac)
                groupDichVu.Enabled = False
            End If
            'CbDuong_Thu_Di_Den.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "OptCa_kt_CheckedChanged"
    Private Sub OptCa_kt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptCa_kt.CheckedChanged
        Try
            If OptCa_kt.Checked = True Then
                CbNgay_Kt.Enabled = True
                CbMa_Ca.Enabled = True
                'Rpt_Thoi_Gian = "( Ngày kế toán " & myham_dung_chung.ConvertIntToDate(myham_dung_chung.ConvertDateToInt(CbNgay_Kt.Value)) & " Ca " & CbMa_Ca.Value & " )"
                Rpt_Thoi_Gian = "( Ngày kế toán " & DateTime.Parse(CbNgay_Kt.Value).ToString("dd/MM/yyyy") & " Ca " & CbMa_Ca.Value & " )"
                Id_Ca_Ngaycakt = GBuu_Cuc_Khai_Thac & myham_dung_chung.ConvertDateToInt(CbNgay_Kt.Value) & CbMa_Ca.Value
            Else
                CbNgay_Kt.Enabled = False
                CbMa_Ca.Enabled = False
                Rpt_Thoi_Gian = "( Từ ngày " & DateTime.Parse(CbTu_Ngay.Value).ToString("dd/MM/yyyy") & " đến ngày " & DateTime.Parse(CbDen_Ngay.Value).ToString("dd/MM/yyyy") & " )"
                Tu_Ngay_KT = myham_dung_chung.ConvertDateToInt(CbTu_Ngay.Value)
                Den_Ngay_KT = myham_dung_chung.ConvertDateToInt(CbDen_Ngay.Value)
            End If

            If OptTat_Ca.Checked = True And OptNgay_Kt.Checked = True Then 'Tất cả
                groupDichVu.Enabled = True
            Else
                optDvuTatCa.Checked = True
                groupDichVu.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "OptNgay_Kt_CheckedChanged"
    Private Sub OptNgay_Kt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptNgay_Kt.CheckedChanged
        Try
            If OptNgay_Kt.Checked = True Then
                CbTu_Ngay.Enabled = True
                CbDen_Ngay.Enabled = True
                CbTu_Ngay.Value = myham_dung_chung.dBeginMonth(CbTu_Ngay.Value)
                CbDen_Ngay.Value = CbDen_Ngay.Value
            Else
                CbMa_Ca.Value = CbMa_Ca.Value
                CbNgay_Kt.Value = myCaSanXuatChiTiet.Ngay_Khai_Thac
                CbTu_Ngay.Enabled = False
                CbDen_Ngay.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Handles OptTat_Ca.CheckedChanged, OptNoi_Tinh.CheckedChanged, OptBuuTa.CheckedChanged, OptHuyen.CheckedChanged, OptLienKe.CheckedChanged, OptLienTinh.CheckedChanged, OptQuocTe.CheckedChanged"
    Private Sub OptTat_Ca_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptHuyen.CheckedChanged, OptPhanLoaiDuongThu.CheckedChanged, OptDuong_Thu.CheckedChanged, OptTat_Ca.CheckedChanged
        GroupDuongThu_CheckedChanged(sender, e)
    End Sub
#End Region

#Region "GroupDuongThu_CheckedChanged"
    Private Sub GroupDuongThu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            CbDuong_Thu_Di_Den.Enabled = OptDuong_Thu.Checked
            CbPL_Duong_Thu.Enabled = OptPhanLoaiDuongThu.Checked
            CbDuong_Thu_Di_Den.Text = ""
            CbPL_Duong_Thu.Text = ""
            If OptTat_Ca.Checked = True And OptNgay_Kt.Checked = True Then 'Tất cả
                groupDichVu.Enabled = True
            Else
                optDvuTatCa.Checked = True
                groupDichVu.Enabled = False
            End If

            If OptTat_Ca.Checked = True Then 'Tất cả

            ElseIf OptDuong_Thu.Checked = True Then 'Huyện
                'CbDuong_Thu_Di_Den.Enabled = True
            ElseIf OptHuyen.Checked = True Then 'Huyện

            ElseIf OptPhanLoaiDuongThu.Checked = True Then 'Huyện

            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#End Region

#Region "FrmTongHopSanLuong_KeyPress"
    Private Sub FrmTongHopSanLuong_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

#End Region

#Region "BtnExit_Click"
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Close()
    End Sub
#End Region

#Region "Bao_Cao_Den - Tổng hợp Báo cáo đến"
    Private Sub Bao_Cao_Den()
        Dim mydata As DataTable
        Dim RptDenTheoTuiSo As New RptDen_Theo_Tui_So
        Dim RptDenTheoChuyenThu As New RptDen_Theo_Chuyen_Thu
        Dim RptDenTheoDuongThu As New RptDen_Theo_Duong_Thu
        Dim pvCollection As New ParameterValues
        Dim FrmView As New FrmViewReports
        OptHang_Den_CheckedChanged(Nothing, Nothing)
        OptCa_kt_CheckedChanged(Nothing, Nothing)
        'CbTuy_Chon_Bao_Cao_ValueChanged(Nothing, Nothing)
        'Chỉ xử lý phần tổng hợp tất cả các đường thư và tổng hợp theo từng đường thư
        'Chưa xử lý phần tổng hợp theo đường thư nội tỉnh, đường thư tuyến huyện lên
        Try
            If OptTat_Ca.Checked = True Then 'Tất cả
                If OptCa_kt.Checked = True Then ' theo ca kế toán
                    If CbTuy_Chon_Bao_Cao.Value = 1 Then ' Thống kê sản lượng theo Túi Số
                        mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Tui_So(Id_Ca_Ngaycakt)
                    ElseIf CbTuy_Chon_Bao_Cao.Value = 2 Then ' Thống kê sản lượng theo Chuyến Thư
                        mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu(Id_Ca_Ngaycakt)
                    ElseIf CbTuy_Chon_Bao_Cao.Value = 3 Then ' Thống kê sản lượng theo Đường Thư
                        mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu(Id_Ca_Ngaycakt)
                    Else
                        CMessageBox.Show("Bạn chưa chọn loại báo cáo cần in !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CbTuy_Chon_Bao_Cao.Select()
                        Exit Sub
                    End If
                Else
                    If CbTuy_Chon_Bao_Cao.Value = 1 Then ' Thống kê sản lượng theo Túi Số
                        If optDvuTatCa.Checked = True Then
                            mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac)
                        ElseIf optDvuEMS.Checked = True Then
                            mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_EMS(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac)
                        ElseIf optDvuBuuKien.Checked = True Then
                            mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Buu_Kien(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac)
                        End If
                    ElseIf CbTuy_Chon_Bao_Cao.Value = 2 Then ' Thống kê sản lượng theo Chuyến Thư
                        If optDvuTatCa.Checked = True Then
                            mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac)
                        ElseIf optDvuEMS.Checked = True Then
                            mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_EMS(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac)
                        ElseIf optDvuBuuKien.Checked = True Then
                            mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Buu_Kien(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac)
                        End If
                    ElseIf CbTuy_Chon_Bao_Cao.Value = 3 Then ' Thống kê sản lượng theo Đường Thư
                        If optDvuTatCa.Checked = True Then
                            mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac)
                        ElseIf optDvuEMS.Checked = True Then
                            mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_EMS(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac)
                        ElseIf optDvuBuuKien.Checked = True Then
                            mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_Buu_Kien(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac)
                        End If
                    Else
                        CMessageBox.Show("Bạn chưa chọn loại báo cáo cần in !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CbTuy_Chon_Bao_Cao.Select()
                        Exit Sub
                    End If
                End If
            ElseIf OptDuong_Thu.Checked = True Then 'Từng đường thư cụ thể
                'Chọn đường thư
                If CbDuong_Thu_Di_Den.Text = "" Then
                    CMessageBox.Show("Bạn chưa chọn đường thư nào !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CbDuong_Thu_Di_Den.Focus()
                    Exit Sub
                End If
                If OptCa_kt.Checked = True Then ' theo ca kế toán
                    If CbTuy_Chon_Bao_Cao.Value = 1 Then ' Thống kê sản lượng theo Túi Số
                        mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Ma_BC(Id_Ca_Ngaycakt, CbDuong_Thu_Di_Den.Value)
                    ElseIf CbTuy_Chon_Bao_Cao.Value = 2 Then ' Thống kê sản lượng theo Chuyến Thư
                        mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Ma_BC(Id_Ca_Ngaycakt, CbDuong_Thu_Di_Den.Value)
                    ElseIf CbTuy_Chon_Bao_Cao.Value = 3 Then ' Thống kê sản lượng theo Đường Thư
                        mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Ma_BC(Id_Ca_Ngaycakt, CbDuong_Thu_Di_Den.Value)
                    Else
                        CMessageBox.Show("Bạn chưa chọn loại báo cáo cần in !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CbTuy_Chon_Bao_Cao.Select()
                        Exit Sub
                    End If
                Else 'Từ ngày đến ngày
                    If CbTuy_Chon_Bao_Cao.Value = 1 Then ' Thống kê sản lượng theo Túi Số
                        mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Ma_BC(Tu_Ngay_KT, Den_Ngay_KT, CbDuong_Thu_Di_Den.Value, GBuu_Cuc_Khai_Thac)
                    ElseIf CbTuy_Chon_Bao_Cao.Value = 2 Then ' Thống kê sản lượng theo Chuyến Thư
                        mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Ma_BC(Tu_Ngay_KT, Den_Ngay_KT, CbDuong_Thu_Di_Den.Value, GBuu_Cuc_Khai_Thac)
                    ElseIf CbTuy_Chon_Bao_Cao.Value = 3 Then ' Thống kê sản lượng theo Đường Thư
                        mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_Ma_BC(Tu_Ngay_KT, Den_Ngay_KT, CbDuong_Thu_Di_Den.Value, GBuu_Cuc_Khai_Thac)
                    Else
                        CMessageBox.Show("Bạn chưa chọn loại báo cáo cần in !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CbTuy_Chon_Bao_Cao.Select()
                        Exit Sub
                    End If
                End If
            ElseIf OptHuyen.Checked = True Then 'Huyện
                If OptCa_kt.Checked = True Then ' theo ca kế toán
                    If CbTuy_Chon_Bao_Cao.Value = 1 Then ' Thống kê sản lượng theo Túi Số
                        mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Huyen(Id_Ca_Ngaycakt)
                    ElseIf CbTuy_Chon_Bao_Cao.Value = 2 Then ' Thống kê sản lượng theo Chuyến Thư
                        mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Huyen(Id_Ca_Ngaycakt)
                    ElseIf CbTuy_Chon_Bao_Cao.Value = 3 Then ' Thống kê sản lượng theo Đường Thư
                        mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Huyen(Id_Ca_Ngaycakt)
                    Else
                        CMessageBox.Show("Bạn chưa chọn loại báo cáo cần in !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CbTuy_Chon_Bao_Cao.Select()
                        Exit Sub
                    End If
                Else 'Từ ngày đến ngày
                    If CbTuy_Chon_Bao_Cao.Value = 1 Then ' Thống kê sản lượng theo Túi Số
                        mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Huyen(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac)
                    ElseIf CbTuy_Chon_Bao_Cao.Value = 2 Then ' Thống kê sản lượng theo Chuyến Thư
                        mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Huyen(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac)
                    ElseIf CbTuy_Chon_Bao_Cao.Value = 3 Then ' Thống kê sản lượng theo Đường Thư
                        mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_Huyen(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac)
                    Else
                        CMessageBox.Show("Bạn chưa chọn loại báo cáo cần in !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CbTuy_Chon_Bao_Cao.Select()
                        Exit Sub
                    End If
                End If
            ElseIf OptPhanLoaiDuongThu.Checked = True Then 'Huyện
                'Chọn phân loại đường thư
                If CbPL_Duong_Thu.Text = "" Then
                    CMessageBox.Show("Bạn chưa chọn phân loại đường thư nào !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CbDuong_Thu_Di_Den.Focus()
                    Exit Sub
                End If
                If OptCa_kt.Checked = True Then ' theo ca kế toán
                    If CbTuy_Chon_Bao_Cao.Value = 1 Then ' Thống kê sản lượng theo Túi Số
                        mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Tui_So_PL_Duong_Thu(Id_Ca_Ngaycakt, CbPL_Duong_Thu.Value)
                    ElseIf CbTuy_Chon_Bao_Cao.Value = 2 Then ' Thống kê sản lượng theo Chuyến Thư
                        mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_PL_Duong_Thu(Id_Ca_Ngaycakt, CbPL_Duong_Thu.Value)
                    ElseIf CbTuy_Chon_Bao_Cao.Value = 3 Then ' Thống kê sản lượng theo Đường Thư
                        mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_PL_Duong_Thu(Id_Ca_Ngaycakt, CbPL_Duong_Thu.Value)
                    Else
                        CMessageBox.Show("Bạn chưa chọn loại báo cáo cần in !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CbTuy_Chon_Bao_Cao.Select()
                        Exit Sub
                    End If
                Else 'Từ ngày đến ngày
                    If CbTuy_Chon_Bao_Cao.Value = 1 Then ' Thống kê sản lượng theo Túi Số
                        mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_PL_Duong_Thu(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac, CbPL_Duong_Thu.Value)
                    ElseIf CbTuy_Chon_Bao_Cao.Value = 2 Then ' Thống kê sản lượng theo Chuyến Thư
                        mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_PL_Duong_Thu(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac, CbPL_Duong_Thu.Value)
                    ElseIf CbTuy_Chon_Bao_Cao.Value = 3 Then ' Thống kê sản lượng theo Đường Thư
                        mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_PL_Duong_Thu(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac, CbPL_Duong_Thu.Value)
                    Else
                        CMessageBox.Show("Bạn chưa chọn loại báo cáo cần in !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CbTuy_Chon_Bao_Cao.Select()
                        Exit Sub
                    End If
                End If
            End If


            If mydata.Rows.Count > 0 Then ' Nếu có dữ liệu
                If CbTuy_Chon_Bao_Cao.Value = 1 Then ' Tổng hợp theo từng túi số
                    _pThamSo.Value = GLeftMenu
                    pvCollection.Add(_pThamSo)
                    RptDenTheoTuiSo.DataDefinition.ParameterFields("Menu_Trai").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    If OptTat_Ca.Checked = True Then
                        If optDvuTatCa.Checked = True Then
                            _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper
                        ElseIf optDvuEMS.Checked = True Then
                            _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper & "(EMS)"
                        ElseIf optDvuBuuKien.Checked = True Then
                            _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper & "(BUU KIEN)"
                        Else
                            _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper
                        End If
                    Else
                        _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper
                    End If
                    pvCollection.Add(_pThamSo)
                    RptDenTheoTuiSo.DataDefinition.ParameterFields("Menu_Tieu_De").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Grpt_Don_Vi_Khai_Thac
                    pvCollection.Add(_pThamSo)
                    RptDenTheoTuiSo.DataDefinition.ParameterFields("Menu_Don_Vi_Khai_Thac").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Rpt_Thoi_Gian
                    pvCollection.Add(_pThamSo)
                    RptDenTheoTuiSo.DataDefinition.ParameterFields("Menu_Thoi_Gian").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = GTen_Dang_Nhap
                    pvCollection.Add(_pThamSo)
                    RptDenTheoTuiSo.DataDefinition.ParameterFields("Menu_Ten_Dang_Nhap").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = GrptNgay_Thang_Nam
                    pvCollection.Add(_pThamSo)
                    RptDenTheoTuiSo.DataDefinition.ParameterFields("Menu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    RptDenTheoTuiSo.SetDataSource(mydata)
                    FrmView.CrystalReportViewer1.ReportSource = RptDenTheoTuiSo
                ElseIf CbTuy_Chon_Bao_Cao.Value = 2 Then ' Tổng hợp theo Chuyến Thư
                    _pThamSo.Value = GLeftMenu
                    pvCollection.Add(_pThamSo)
                    RptDenTheoChuyenThu.DataDefinition.ParameterFields("Menu_Trai").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    If OptTat_Ca.Checked = True Then
                        If optDvuTatCa.Checked = True Then
                            _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper
                        ElseIf optDvuEMS.Checked = True Then
                            _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper & "(EMS)"
                        ElseIf optDvuBuuKien.Checked = True Then
                            _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper & "(BUU KIEN)"
                        Else
                            _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper
                        End If
                    Else
                        _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper
                    End If
                    pvCollection.Add(_pThamSo)
                    RptDenTheoChuyenThu.DataDefinition.ParameterFields("Menu_Tieu_De").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Grpt_Don_Vi_Khai_Thac
                    pvCollection.Add(_pThamSo)
                    RptDenTheoChuyenThu.DataDefinition.ParameterFields("Menu_Don_Vi_Khai_Thac").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Rpt_Thoi_Gian
                    pvCollection.Add(_pThamSo)
                    RptDenTheoChuyenThu.DataDefinition.ParameterFields("Menu_Thoi_Gian").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = GTen_Dang_Nhap
                    pvCollection.Add(_pThamSo)
                    RptDenTheoChuyenThu.DataDefinition.ParameterFields("Menu_Ten_Dang_Nhap").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = GrptNgay_Thang_Nam
                    pvCollection.Add(_pThamSo)
                    RptDenTheoChuyenThu.DataDefinition.ParameterFields("Menu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()

                    RptDenTheoChuyenThu.SetDataSource(mydata)
                    FrmView.CrystalReportViewer1.ReportSource = RptDenTheoChuyenThu
                ElseIf CbTuy_Chon_Bao_Cao.Value = 3 Then 'Tổng hợp theo đường thư
                    _pThamSo.Value = GLeftMenu
                    pvCollection.Add(_pThamSo)
                    RptDenTheoDuongThu.DataDefinition.ParameterFields("Menu_Trai").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    If OptTat_Ca.Checked = True Then
                        If optDvuTatCa.Checked = True Then
                            _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper
                        ElseIf optDvuEMS.Checked = True Then
                            _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper & "(EMS)"
                        ElseIf optDvuBuuKien.Checked = True Then
                            _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper & "(BUU KIEN)"
                        Else
                            _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper
                        End If
                    Else
                        _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper
                    End If
                    pvCollection.Add(_pThamSo)
                    RptDenTheoDuongThu.DataDefinition.ParameterFields("Menu_Tieu_De").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Grpt_Don_Vi_Khai_Thac
                    pvCollection.Add(_pThamSo)
                    RptDenTheoDuongThu.DataDefinition.ParameterFields("Menu_Don_Vi_Khai_Thac").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Rpt_Thoi_Gian
                    pvCollection.Add(_pThamSo)
                    RptDenTheoDuongThu.DataDefinition.ParameterFields("Menu_Thoi_Gian").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = GTen_Dang_Nhap
                    pvCollection.Add(_pThamSo)
                    RptDenTheoDuongThu.DataDefinition.ParameterFields("Menu_Ten_Dang_Nhap").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = GrptNgay_Thang_Nam
                    pvCollection.Add(_pThamSo)
                    RptDenTheoDuongThu.DataDefinition.ParameterFields("Menu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()

                    RptDenTheoDuongThu.SetDataSource(mydata)
                    FrmView.CrystalReportViewer1.ReportSource = RptDenTheoDuongThu
                End If
                Cursor.Current = Cursors.Default
                FrmView.ShowDialog()
            Else 'Nếu không có dữ liệu
                CMessageBox.Show("Không có thông tin dữ liệu về loại báo cáo này !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Bao_Cao_Di - Tổng hợp Báo cáo đi"
    Private Sub Bao_Cao_Di()
        Dim mydata As DataTable
        Dim rptDiTheoTuiSo As New RptDi_Theo_Tui_So
        Dim RptDiTheoChuyenThu As New RptDi_Theo_Chuyen_Thu
        Dim RptDiTheoDuongThu As New RptDi_Theo_Duong_Thu
        Dim pvCollection As New ParameterValues
        Dim FrmView As New FrmViewReports
        OptHang_Den_CheckedChanged(Nothing, Nothing)
        OptCa_kt_CheckedChanged(Nothing, Nothing)
        'CbTuy_Chon_Bao_Cao_ValueChanged(Nothing, Nothing)
        Try
            If OptTat_Ca.Checked = True Then 'Tất cả
                If OptCa_kt.Checked = True Then ' theo ca kế toán
                    If CbTuy_Chon_Bao_Cao.Value = 1 Then ' Thống kê sản lượng theo Túi Số
                        mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Tui_So(Id_Ca_Ngaycakt)
                    ElseIf CbTuy_Chon_Bao_Cao.Value = 2 Then ' Thống kê sản lượng theo Chuyến Thư
                        mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu(Id_Ca_Ngaycakt)
                    ElseIf CbTuy_Chon_Bao_Cao.Value = 3 Then ' Thống kê sản lượng theo Đường Thư
                        mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu(Id_Ca_Ngaycakt)
                    Else
                        CMessageBox.Show("Bạn chưa chọn loại báo cáo cần in !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CbTuy_Chon_Bao_Cao.Select()
                        Exit Sub
                    End If
                Else
                    If CbTuy_Chon_Bao_Cao.Value = 1 Then ' Thống kê sản lượng theo Túi Số
                        mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac)
                    ElseIf CbTuy_Chon_Bao_Cao.Value = 2 Then ' Thống kê sản lượng theo Chuyến Thư
                        mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac)
                    ElseIf CbTuy_Chon_Bao_Cao.Value = 3 Then ' Thống kê sản lượng theo Đường Thư
                        mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac)
                    Else
                        CMessageBox.Show("Bạn chưa chọn loại báo cáo cần in !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CbTuy_Chon_Bao_Cao.Select()
                        Exit Sub
                    End If
                End If
            ElseIf OptDuong_Thu.Checked = True Then 'Từng đường thư cụ thể
                'Chọn đường thư
                If CbDuong_Thu_Di_Den.Text = "" Then
                    CMessageBox.Show("Bạn chưa chọn đường thư nào !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CbDuong_Thu_Di_Den.Focus()
                    Exit Sub
                End If
                If OptCa_kt.Checked = True Then ' theo ca kế toán
                    If CbTuy_Chon_Bao_Cao.Value = 1 Then ' Thống kê sản lượng theo Túi Số
                        mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Ma_BC(Id_Ca_Ngaycakt, CbDuong_Thu_Di_Den.Value)
                    ElseIf CbTuy_Chon_Bao_Cao.Value = 2 Then ' Thống kê sản lượng theo Chuyến Thư
                        mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Ma_BC(Id_Ca_Ngaycakt, CbDuong_Thu_Di_Den.Value)
                    ElseIf CbTuy_Chon_Bao_Cao.Value = 3 Then ' Thống kê sản lượng theo Đường Thư
                        mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Ma_BC(Id_Ca_Ngaycakt, CbDuong_Thu_Di_Den.Value)
                    Else
                        CMessageBox.Show("Bạn chưa chọn loại báo cáo cần in !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CbTuy_Chon_Bao_Cao.Select()
                        Exit Sub
                    End If
                Else 'Từ ngày đến ngày
                    If CbTuy_Chon_Bao_Cao.Value = 1 Then ' Thống kê sản lượng theo Túi Số
                        mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Ma_BC(Tu_Ngay_KT, Den_Ngay_KT, CbDuong_Thu_Di_Den.Value, GBuu_Cuc_Khai_Thac)
                    ElseIf CbTuy_Chon_Bao_Cao.Value = 2 Then ' Thống kê sản lượng theo Chuyến Thư
                        mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Ma_BC(Tu_Ngay_KT, Den_Ngay_KT, CbDuong_Thu_Di_Den.Value, GBuu_Cuc_Khai_Thac)
                    ElseIf CbTuy_Chon_Bao_Cao.Value = 3 Then ' Thống kê sản lượng theo Đường Thư
                        mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_Ma_BC(Tu_Ngay_KT, Den_Ngay_KT, CbDuong_Thu_Di_Den.Value, GBuu_Cuc_Khai_Thac)
                    Else
                        CMessageBox.Show("Bạn chưa chọn loại báo cáo cần in !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CbTuy_Chon_Bao_Cao.Select()
                        Exit Sub
                    End If
                End If
            ElseIf OptHuyen.Checked = True Then 'Huyện
                If OptCa_kt.Checked = True Then ' theo ca kế toán
                    If CbTuy_Chon_Bao_Cao.Value = 1 Then ' Thống kê sản lượng theo Túi Số
                        mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Huyen(Id_Ca_Ngaycakt)
                    ElseIf CbTuy_Chon_Bao_Cao.Value = 2 Then ' Thống kê sản lượng theo Chuyến Thư
                        mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Huyen(Id_Ca_Ngaycakt)
                    ElseIf CbTuy_Chon_Bao_Cao.Value = 3 Then ' Thống kê sản lượng theo Đường Thư
                        mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Huyen(Id_Ca_Ngaycakt)
                    Else
                        CMessageBox.Show("Bạn chưa chọn loại báo cáo cần in !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CbTuy_Chon_Bao_Cao.Select()
                        Exit Sub
                    End If
                Else 'Từ ngày đến ngày
                    If CbTuy_Chon_Bao_Cao.Value = 1 Then ' Thống kê sản lượng theo Túi Số
                        mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Huyen(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac)
                    ElseIf CbTuy_Chon_Bao_Cao.Value = 2 Then ' Thống kê sản lượng theo Chuyến Thư
                        mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Huyen(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac)
                    ElseIf CbTuy_Chon_Bao_Cao.Value = 3 Then ' Thống kê sản lượng theo Đường Thư
                        mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_Huyen(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac)
                    Else
                        CMessageBox.Show("Bạn chưa chọn loại báo cáo cần in !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CbTuy_Chon_Bao_Cao.Select()
                        Exit Sub
                    End If
                End If
            ElseIf OptPhanLoaiDuongThu.Checked = True Then 'Huyện
                'Chọn phân loại đường thư
                If CbPL_Duong_Thu.Text = "" Then
                    CMessageBox.Show("Bạn chưa chọn phân loại đường thư nào !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CbDuong_Thu_Di_Den.Focus()
                    Exit Sub
                End If
                If OptCa_kt.Checked = True Then ' theo ca kế toán
                    If CbTuy_Chon_Bao_Cao.Value = 1 Then ' Thống kê sản lượng theo Túi Số
                        mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Tui_So_PL_Duong_Thu(Id_Ca_Ngaycakt, CbPL_Duong_Thu.Value)
                    ElseIf CbTuy_Chon_Bao_Cao.Value = 2 Then ' Thống kê sản lượng theo Chuyến Thư
                        mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_PL_Duong_Thu(Id_Ca_Ngaycakt, CbPL_Duong_Thu.Value)
                    ElseIf CbTuy_Chon_Bao_Cao.Value = 3 Then ' Thống kê sản lượng theo Đường Thư
                        mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_PL_Duong_Thu(Id_Ca_Ngaycakt, CbPL_Duong_Thu.Value)
                    Else
                        CMessageBox.Show("Bạn chưa chọn loại báo cáo cần in !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CbTuy_Chon_Bao_Cao.Select()
                        Exit Sub
                    End If
                Else 'Từ ngày đến ngày
                    If CbTuy_Chon_Bao_Cao.Value = 1 Then ' Thống kê sản lượng theo Túi Số
                        mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_PL_Duong_Thu(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac, CbPL_Duong_Thu.Value)
                    ElseIf CbTuy_Chon_Bao_Cao.Value = 2 Then ' Thống kê sản lượng theo Chuyến Thư
                        mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_PL_Duong_Thu(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac, CbPL_Duong_Thu.Value)
                    ElseIf CbTuy_Chon_Bao_Cao.Value = 3 Then ' Thống kê sản lượng theo Đường Thư
                        mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_PL_Duong_Thu(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac, CbPL_Duong_Thu.Value)
                    Else
                        CMessageBox.Show("Bạn chưa chọn loại báo cáo cần in !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CbTuy_Chon_Bao_Cao.Select()
                        Exit Sub
                    End If
                End If
            End If

            If mydata.Rows.Count > 0 Then ' Nếu có dữ liệu
                If CbTuy_Chon_Bao_Cao.Value = 1 Then ' Tổng hợp theo từng túi số
                    _pThamSo.Value = GLeftMenu
                    pvCollection.Add(_pThamSo)
                    rptDiTheoTuiSo.DataDefinition.ParameterFields("Menu_Trai").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper
                    pvCollection.Add(_pThamSo)
                    rptDiTheoTuiSo.DataDefinition.ParameterFields("Menu_Tieu_De").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Grpt_Don_Vi_Khai_Thac
                    pvCollection.Add(_pThamSo)
                    rptDiTheoTuiSo.DataDefinition.ParameterFields("Menu_Don_Vi_Khai_Thac").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Rpt_Thoi_Gian
                    pvCollection.Add(_pThamSo)
                    rptDiTheoTuiSo.DataDefinition.ParameterFields("Menu_Thoi_Gian").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = GTen_Dang_Nhap
                    pvCollection.Add(_pThamSo)
                    rptDiTheoTuiSo.DataDefinition.ParameterFields("Menu_Ten_Dang_Nhap").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = GrptNgay_Thang_Nam
                    pvCollection.Add(_pThamSo)
                    rptDiTheoTuiSo.DataDefinition.ParameterFields("Menu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    rptDiTheoTuiSo.SetDataSource(mydata)
                    FrmView.CrystalReportViewer1.ReportSource = rptDiTheoTuiSo
                ElseIf CbTuy_Chon_Bao_Cao.Value = 2 Then ' Tổng hợp theo Chuyến Thư
                    _pThamSo.Value = GLeftMenu
                    pvCollection.Add(_pThamSo)
                    RptDiTheoChuyenThu.DataDefinition.ParameterFields("Menu_Trai").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper
                    pvCollection.Add(_pThamSo)
                    RptDiTheoChuyenThu.DataDefinition.ParameterFields("Menu_Tieu_De").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Grpt_Don_Vi_Khai_Thac
                    pvCollection.Add(_pThamSo)
                    RptDiTheoChuyenThu.DataDefinition.ParameterFields("Menu_Don_Vi_Khai_Thac").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Rpt_Thoi_Gian
                    pvCollection.Add(_pThamSo)
                    RptDiTheoChuyenThu.DataDefinition.ParameterFields("Menu_Thoi_Gian").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = GTen_Dang_Nhap
                    pvCollection.Add(_pThamSo)
                    RptDiTheoChuyenThu.DataDefinition.ParameterFields("Menu_Ten_Dang_Nhap").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = GrptNgay_Thang_Nam
                    pvCollection.Add(_pThamSo)
                    RptDiTheoChuyenThu.DataDefinition.ParameterFields("Menu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()

                    RptDiTheoChuyenThu.SetDataSource(mydata)
                    FrmView.CrystalReportViewer1.ReportSource = RptDiTheoChuyenThu
                ElseIf CbTuy_Chon_Bao_Cao.Value = 3 Then 'Tổng hợp theo đường thư
                    _pThamSo.Value = GLeftMenu
                    pvCollection.Add(_pThamSo)
                    RptDiTheoDuongThu.DataDefinition.ParameterFields("Menu_Trai").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper
                    pvCollection.Add(_pThamSo)
                    RptDiTheoDuongThu.DataDefinition.ParameterFields("Menu_Tieu_De").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Grpt_Don_Vi_Khai_Thac
                    pvCollection.Add(_pThamSo)
                    RptDiTheoDuongThu.DataDefinition.ParameterFields("Menu_Don_Vi_Khai_Thac").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Rpt_Thoi_Gian
                    pvCollection.Add(_pThamSo)
                    RptDiTheoDuongThu.DataDefinition.ParameterFields("Menu_Thoi_Gian").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = GTen_Dang_Nhap
                    pvCollection.Add(_pThamSo)
                    RptDiTheoDuongThu.DataDefinition.ParameterFields("Menu_Ten_Dang_Nhap").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = GrptNgay_Thang_Nam
                    pvCollection.Add(_pThamSo)
                    RptDiTheoDuongThu.DataDefinition.ParameterFields("Menu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()

                    RptDiTheoDuongThu.SetDataSource(mydata)
                    FrmView.CrystalReportViewer1.ReportSource = RptDiTheoDuongThu
                End If
                Cursor.Current = Cursors.Default
                FrmView.ShowDialog()
            Else 'Nếu không có dữ liệu
                CMessageBox.Show("Không có thông tin dữ liệu về loại báo cáo này !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "BtnPreview_Click"
    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click
        Try
            OptHang_Den_CheckedChanged(sender, e)
            If OptHang_Den.Checked = True Then
                Bao_Cao_Den()
            Else
                Bao_Cao_Di()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "BtnPrint_Click"
    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Try
            BtnPreview_Click(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "CbTuy_Chon_Bao_Cao_RowSelected"
    Private Sub CbTuy_Chon_Bao_Cao_RowSelected(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowSelectedEventArgs) Handles CbTuy_Chon_Bao_Cao.RowSelected
        Try
            BtnPreview.Enabled = True
            BtnPrint.Enabled = True
            If CbTuy_Chon_Bao_Cao.Value = 1 Then
                Rpt_Menu_Tieu_De = Rpt_Menu_Tieu_De & " THEO TÚI SỐ"
            ElseIf CbTuy_Chon_Bao_Cao.Value = 2 Then
                Rpt_Menu_Tieu_De = Rpt_Menu_Tieu_De & " THEO CHUYẾN THƯ"
            ElseIf CbTuy_Chon_Bao_Cao.Value = 3 Then
                Rpt_Menu_Tieu_De = Rpt_Menu_Tieu_De & " THEO ĐƯỜNG THƯ"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

End Class

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports Ems_International_Logic.EMS
#Region "Thống kê báo cáo sản lượng"
Public Class FrmThongKeBaoCao
    Inherits System.Windows.Forms.Form
    Private ConnectionString As String
    Private isQUOCTE As Integer
    Private Menu_Phai As String

    Public Sub New(ByVal _ConnectionString As String)
        ConnectionString = _ConnectionString
    End Sub

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
    Friend WithEvents LbThong_Tin As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CbTuy_Chon_Bao_Cao As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CbDuong_Thu_Di_Den As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents OptTheo_BC As System.Windows.Forms.RadioButton
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
    Friend WithEvents Exp_In_Bao_Cao As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar
    Friend WithEvents BtnExit As Infragistics.Win.Misc.UltraButton
    Friend WithEvents BtnPrint As Infragistics.Win.Misc.UltraButton
    Friend WithEvents BtnPreview As Infragistics.Win.Misc.UltraButton
    Friend WithEvents tabQT As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents PrbTienTrinh As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraExplorerBarGroup1 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup
        Dim UltraExplorerBarItem1 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem2 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem3 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem4 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem5 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem6 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem7 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem8 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmThongKeBaoCao))
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Tuy_Chon_Bao_Cao", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bao_Cao")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Bao_Cao")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Duong_Thu_Di_Den", -1)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Duong_Thu")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Phan_Loai")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ip_Truyen")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tinh_Doanh_Thu")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tinh_Cong_Phat")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Duoc_Truyen")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Ca", -1)
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ca_Khai_Thac")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thu_Tu")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ca")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.LbThong_Tin = New Infragistics.Win.Misc.UltraLabel
        Me.Exp_In_Bao_Cao = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar
        Me.BtnExit = New Infragistics.Win.Misc.UltraButton
        Me.BtnPrint = New Infragistics.Win.Misc.UltraButton
        Me.BtnPreview = New Infragistics.Win.Misc.UltraButton
        Me.CbTuy_Chon_Bao_Cao = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.CbDuong_Thu_Di_Den = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.OptTheo_BC = New System.Windows.Forms.RadioButton
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
        Me.tabQT = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.PrbTienTrinh = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar
        CType(Me.Exp_In_Bao_Cao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbTuy_Chon_Bao_Cao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.CbDuong_Thu_Di_Den, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CbMa_Ca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbDen_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbTu_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbNgay_Kt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tabQT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabQT.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(638, 0)
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(638, 0)
        '
        'LbThong_Tin
        '
        Appearance1.FontData.BoldAsString = "True"
        Appearance1.TextHAlign = Infragistics.Win.HAlign.Center
        Me.LbThong_Tin.Appearance = Appearance1
        Me.LbThong_Tin.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.LbThong_Tin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbThong_Tin.Location = New System.Drawing.Point(0, 32)
        Me.LbThong_Tin.Name = "LbThong_Tin"
        Me.LbThong_Tin.Size = New System.Drawing.Size(640, 72)
        Me.LbThong_Tin.TabIndex = 29
        '
        'Exp_In_Bao_Cao
        '
        Me.Exp_In_Bao_Cao.AcceptsFocus = Infragistics.Win.DefaultableBoolean.True
        Appearance2.BackColor = System.Drawing.SystemColors.Control
        Appearance2.BackColor2 = System.Drawing.SystemColors.Control
        Me.Exp_In_Bao_Cao.Appearance = Appearance2
        Me.Exp_In_Bao_Cao.BorderStyle = Infragistics.Win.UIElementBorderStyle.Dotted
        UltraExplorerBarItem1.Key = "Btn_0"
        UltraExplorerBarItem1.Text = "Xem số liệu cân đối đi và đến"
        UltraExplorerBarItem2.Key = "Btn_1"
        UltraExplorerBarItem2.Text = "Chi tiết E1 chênh lệch mức trọng lượng"
        UltraExplorerBarItem3.Key = "Btn_2"
        UltraExplorerBarItem3.Text = "E1 có chi tiết đến chưa có chi tiết đi"
        UltraExplorerBarItem4.Key = "Btn_3"
        UltraExplorerBarItem4.Text = "E1 có chi tiết đi chưa có chi tiết đến"
        UltraExplorerBarItem5.Key = "Btn_4"
        UltraExplorerBarItem5.Text = "E1 đến nhiều lần trong ca"
        UltraExplorerBarItem6.Key = "Btn_5"
        UltraExplorerBarItem6.Text = "E1 đi nhiều lần trong ca"
        UltraExplorerBarItem7.Key = "Btn_6"
        UltraExplorerBarItem7.Text = "Thống kê chi tiết tồn kho"
        UltraExplorerBarItem7.Visible = False
        UltraExplorerBarItem8.Key = "Btn_7"
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        UltraExplorerBarItem8.Settings.AppearancesLarge.Appearance = Appearance3
        Appearance4.Image = CType(resources.GetObject("Appearance4.Image"), Object)
        UltraExplorerBarItem8.Settings.AppearancesSmall.Appearance = Appearance4
        UltraExplorerBarItem8.Text = "Tổng hợp thông tin chuyến thư, túi số"
        UltraExplorerBarGroup1.Items.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem() {UltraExplorerBarItem1, UltraExplorerBarItem2, UltraExplorerBarItem3, UltraExplorerBarItem4, UltraExplorerBarItem5, UltraExplorerBarItem6, UltraExplorerBarItem7, UltraExplorerBarItem8})
        UltraExplorerBarGroup1.Text = "In báo cáo"
        Me.Exp_In_Bao_Cao.Groups.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup() {UltraExplorerBarGroup1})
        Me.Exp_In_Bao_Cao.GroupSettings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.LargeImagesWithText
        Me.Exp_In_Bao_Cao.ImageSizeLarge = New System.Drawing.Size(25, 25)
        Me.Exp_In_Bao_Cao.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Appearance5.FontData.BoldAsString = "True"
        Appearance5.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(0, Byte))
        Appearance5.Image = CType(resources.GetObject("Appearance5.Image"), Object)
        Me.Exp_In_Bao_Cao.ItemSettings.AppearancesLarge.ActiveAppearance = Appearance5
        Appearance6.FontData.BoldAsString = "True"
        Appearance6.Image = CType(resources.GetObject("Appearance6.Image"), Object)
        Me.Exp_In_Bao_Cao.ItemSettings.AppearancesLarge.Appearance = Appearance6
        Me.Exp_In_Bao_Cao.Location = New System.Drawing.Point(328, 168)
        Me.Exp_In_Bao_Cao.Name = "Exp_In_Bao_Cao"
        Me.Exp_In_Bao_Cao.Size = New System.Drawing.Size(304, 344)
        Me.Exp_In_Bao_Cao.TabIndex = 49
        Me.Exp_In_Bao_Cao.ViewStyle = Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarViewStyle.XPExplorerBar
        '
        'BtnExit
        '
        Appearance7.FontData.BoldAsString = "True"
        Appearance7.Image = CType(resources.GetObject("Appearance7.Image"), Object)
        Me.BtnExit.Appearance = Appearance7
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(544, 120)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(88, 32)
        Me.BtnExit.TabIndex = 48
        Me.BtnExit.Text = "Exit"
        '
        'BtnPrint
        '
        Appearance8.FontData.BoldAsString = "True"
        Appearance8.Image = CType(resources.GetObject("Appearance8.Image"), Object)
        Appearance8.TextHAlign = Infragistics.Win.HAlign.Center
        Me.BtnPrint.Appearance = Appearance8
        Me.BtnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.Location = New System.Drawing.Point(440, 120)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(80, 32)
        Me.BtnPrint.TabIndex = 47
        Me.BtnPrint.Text = "Printer"
        '
        'BtnPreview
        '
        Appearance9.FontData.BoldAsString = "True"
        Appearance9.Image = CType(resources.GetObject("Appearance9.Image"), Object)
        Me.BtnPreview.Appearance = Appearance9
        Me.BtnPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPreview.Location = New System.Drawing.Point(328, 120)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(88, 32)
        Me.BtnPreview.TabIndex = 46
        Me.BtnPreview.Text = "Preview"
        '
        'CbTuy_Chon_Bao_Cao
        '
        Me.CbTuy_Chon_Bao_Cao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance10.FontData.BoldAsString = "True"
        Appearance10.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn1.Header.Appearance = Appearance10
        UltraGridColumn1.Header.Caption = "Mã báo cáo"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.Width = 78
        Appearance11.FontData.BoldAsString = "True"
        Appearance11.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn2.Header.Appearance = Appearance11
        UltraGridColumn2.Header.Caption = "Tên báo cáo"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 328
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2})
        Me.CbTuy_Chon_Bao_Cao.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance12.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance12.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance12.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance12.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.CbTuy_Chon_Bao_Cao.DisplayLayout.Override.HeaderAppearance = Appearance12
        Me.CbTuy_Chon_Bao_Cao.DisplayMember = "Ten_Bao_Cao"
        Me.CbTuy_Chon_Bao_Cao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbTuy_Chon_Bao_Cao.Location = New System.Drawing.Point(8, 424)
        Me.CbTuy_Chon_Bao_Cao.Name = "CbTuy_Chon_Bao_Cao"
        Me.CbTuy_Chon_Bao_Cao.Size = New System.Drawing.Size(312, 23)
        Me.CbTuy_Chon_Bao_Cao.TabIndex = 45
        Me.CbTuy_Chon_Bao_Cao.Text = "Hãy lựa chọn loại báo cáo cần in"
        Me.CbTuy_Chon_Bao_Cao.ValueMember = "Ma_Bao_Cao"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CbDuong_Thu_Di_Den)
        Me.GroupBox3.Controls.Add(Me.OptTheo_BC)
        Me.GroupBox3.Controls.Add(Me.OptTat_Ca)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 328)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(312, 64)
        Me.GroupBox3.TabIndex = 44
        Me.GroupBox3.TabStop = False
        '
        'CbDuong_Thu_Di_Den
        '
        Me.CbDuong_Thu_Di_Den.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn3.Header.VisiblePosition = 0
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        Appearance13.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn5.CellAppearance = Appearance13
        Appearance14.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn5.Header.Appearance = Appearance14
        UltraGridColumn5.Header.Caption = "Đường thư"
        UltraGridColumn5.Header.VisiblePosition = 1
        UltraGridColumn5.Width = 60
        Appearance15.TextHAlign = Infragistics.Win.HAlign.Left
        UltraGridColumn6.CellAppearance = Appearance15
        Appearance16.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn6.Header.Appearance = Appearance16
        UltraGridColumn6.Header.Caption = "Tên đường thư"
        UltraGridColumn6.Header.VisiblePosition = 2
        UltraGridColumn6.Width = 120
        UltraGridColumn7.Header.VisiblePosition = 4
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 5
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 6
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 7
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 8
        UltraGridColumn11.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11})
        Me.CbDuong_Thu_Di_Den.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Appearance17.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance17.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance17.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance17.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.CbDuong_Thu_Di_Den.DisplayLayout.Override.HeaderAppearance = Appearance17
        Me.CbDuong_Thu_Di_Den.DisplayMember = "Ma_BC"
        Me.CbDuong_Thu_Di_Den.Location = New System.Drawing.Point(200, 24)
        Me.CbDuong_Thu_Di_Den.Name = "CbDuong_Thu_Di_Den"
        Me.CbDuong_Thu_Di_Den.Size = New System.Drawing.Size(88, 21)
        Me.CbDuong_Thu_Di_Den.TabIndex = 32
        Me.CbDuong_Thu_Di_Den.ValueMember = "Ma_BC"
        '
        'OptTheo_BC
        '
        Me.OptTheo_BC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptTheo_BC.Location = New System.Drawing.Point(120, 24)
        Me.OptTheo_BC.Name = "OptTheo_BC"
        Me.OptTheo_BC.Size = New System.Drawing.Size(64, 24)
        Me.OptTheo_BC.TabIndex = 31
        Me.OptTheo_BC.Text = "Theo"
        '
        'OptTat_Ca
        '
        Me.OptTat_Ca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptTat_Ca.Location = New System.Drawing.Point(24, 24)
        Me.OptTat_Ca.Name = "OptTat_Ca"
        Me.OptTat_Ca.Size = New System.Drawing.Size(88, 24)
        Me.OptTat_Ca.TabIndex = 30
        Me.OptTat_Ca.Text = "Tất cả"
        '
        'GroupBox2
        '
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
        Me.GroupBox2.Location = New System.Drawing.Point(8, 160)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(312, 144)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        '
        'CbMa_Ca
        '
        Me.CbMa_Ca.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn12.Header.VisiblePosition = 0
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 1
        UltraGridColumn13.Hidden = True
        Appearance18.FontData.BoldAsString = "True"
        UltraGridColumn14.Header.Appearance = Appearance18
        UltraGridColumn14.Header.Caption = "Ca"
        UltraGridColumn14.Header.VisiblePosition = 2
        UltraGridColumn14.Width = 30
        Appearance19.FontData.BoldAsString = "True"
        Appearance19.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn15.Header.Appearance = Appearance19
        UltraGridColumn15.Header.Caption = "Tên ca"
        UltraGridColumn15.Header.VisiblePosition = 3
        UltraGridColumn15.Width = 70
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15})
        Me.CbMa_Ca.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Appearance20.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance20.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance20.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance20.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance20.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.CbMa_Ca.DisplayLayout.Override.HeaderAppearance = Appearance20
        Me.CbMa_Ca.DisplayMember = "Ca"
        Me.CbMa_Ca.LimitToList = True
        Me.CbMa_Ca.Location = New System.Drawing.Point(216, 40)
        Me.CbMa_Ca.Name = "CbMa_Ca"
        Me.CbMa_Ca.Size = New System.Drawing.Size(88, 21)
        Me.CbMa_Ca.TabIndex = 2
        Me.CbMa_Ca.ValueMember = "Thu_Tu"
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Location = New System.Drawing.Point(216, 80)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(80, 16)
        Me.UltraLabel3.TabIndex = 11
        Me.UltraLabel3.Text = "Đến ngày"
        '
        'CbDen_Ngay
        '
        Me.CbDen_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.CbDen_Ngay.Location = New System.Drawing.Point(216, 104)
        Me.CbDen_Ngay.Name = "CbDen_Ngay"
        Me.CbDen_Ngay.Size = New System.Drawing.Size(88, 21)
        Me.CbDen_Ngay.TabIndex = 5
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Location = New System.Drawing.Point(96, 80)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(80, 16)
        Me.UltraLabel4.TabIndex = 9
        Me.UltraLabel4.Text = "Từ ngày"
        '
        'CbTu_Ngay
        '
        Me.CbTu_Ngay.DateTime = New Date(2008, 7, 3, 0, 0, 0, 0)
        Me.CbTu_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.CbTu_Ngay.Location = New System.Drawing.Point(96, 104)
        Me.CbTu_Ngay.Name = "CbTu_Ngay"
        Me.CbTu_Ngay.Size = New System.Drawing.Size(88, 21)
        Me.CbTu_Ngay.TabIndex = 4
        Me.CbTu_Ngay.Value = New Date(2008, 7, 3, 0, 0, 0, 0)
        '
        'OptNgay_Kt
        '
        Me.OptNgay_Kt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptNgay_Kt.Location = New System.Drawing.Point(16, 104)
        Me.OptNgay_Kt.Name = "OptNgay_Kt"
        Me.OptNgay_Kt.Size = New System.Drawing.Size(80, 24)
        Me.OptNgay_Kt.TabIndex = 3
        Me.OptNgay_Kt.Text = "Ngày KT"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Location = New System.Drawing.Point(216, 16)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(80, 16)
        Me.UltraLabel2.TabIndex = 5
        Me.UltraLabel2.Text = "Ca"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(96, 16)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(80, 16)
        Me.UltraLabel1.TabIndex = 4
        Me.UltraLabel1.Text = "Ngày khai thác"
        '
        'CbNgay_Kt
        '
        Me.CbNgay_Kt.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.CbNgay_Kt.Location = New System.Drawing.Point(96, 40)
        Me.CbNgay_Kt.Name = "CbNgay_Kt"
        Me.CbNgay_Kt.Size = New System.Drawing.Size(88, 21)
        Me.CbNgay_Kt.TabIndex = 1
        '
        'OptCa_kt
        '
        Me.OptCa_kt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptCa_kt.Location = New System.Drawing.Point(16, 40)
        Me.OptCa_kt.Name = "OptCa_kt"
        Me.OptCa_kt.Size = New System.Drawing.Size(64, 24)
        Me.OptCa_kt.TabIndex = 0
        Me.OptCa_kt.Text = "Ca KT"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OptHang_di)
        Me.GroupBox1.Controls.Add(Me.OptHang_Den)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 40)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        '
        'OptHang_di
        '
        Me.OptHang_di.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptHang_di.Location = New System.Drawing.Point(192, 8)
        Me.OptHang_di.Name = "OptHang_di"
        Me.OptHang_di.TabIndex = 1
        Me.OptHang_di.Text = "Hàng đi"
        '
        'OptHang_Den
        '
        Me.OptHang_Den.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptHang_Den.Location = New System.Drawing.Point(32, 8)
        Me.OptHang_Den.Name = "OptHang_Den"
        Me.OptHang_Den.TabIndex = 0
        Me.OptHang_Den.Text = "Hàng đến"
        '
        'tabQT
        '
        Me.tabQT.BackColor = System.Drawing.SystemColors.Control
        Me.tabQT.Controls.Add(Me.UltraTabPageControl2)
        Me.tabQT.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tabQT.Controls.Add(Me.UltraTabPageControl1)
        Me.tabQT.Dock = System.Windows.Forms.DockStyle.Top
        Me.tabQT.Location = New System.Drawing.Point(0, 0)
        Me.tabQT.Name = "tabQT"
        Me.tabQT.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tabQT.Size = New System.Drawing.Size(642, 24)
        Me.tabQT.TabIndex = 50
        UltraTab1.Key = "QT"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Quốc Tế Đến"
        UltraTab2.Key = "TN"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Quốc Tế Đi"
        Me.tabQT.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(638, 0)
        '
        'PrbTienTrinh
        '
        Me.PrbTienTrinh.BorderStyle = Infragistics.Win.UIElementBorderStyle.InsetSoft
        Me.PrbTienTrinh.Location = New System.Drawing.Point(48, 304)
        Me.PrbTienTrinh.Maximum = 10000
        Me.PrbTienTrinh.Name = "PrbTienTrinh"
        Me.PrbTienTrinh.Size = New System.Drawing.Size(528, 32)
        Me.PrbTienTrinh.Step = 1
        Me.PrbTienTrinh.TabIndex = 74
        Me.PrbTienTrinh.Text = "[Formatted]"
        Me.PrbTienTrinh.Visible = False
        '
        'FrmThongKeBaoCao
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(642, 519)
        Me.ControlBox = False
        Me.Controls.Add(Me.PrbTienTrinh)
        Me.Controls.Add(Me.tabQT)
        Me.Controls.Add(Me.LbThong_Tin)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.CbTuy_Chon_Bao_Cao)
        Me.Controls.Add(Me.BtnPreview)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.Exp_In_Bao_Cao)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmThongKeBaoCao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cân đối dữ liệu đóng Đi và XN Đến"
        CType(Me.Exp_In_Bao_Cao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbTuy_Chon_Bao_Cao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.CbDuong_Thu_Di_Den, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.CbMa_Ca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbDen_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbTu_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbNgay_Kt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.tabQT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabQT.ResumeLayout(False)
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
    Dim myChuyen_Thu_Den As New Chuyen_Thu_Den(GConnectionString)
    Dim myChuyen_Thu_Di As New Chuyen_Thu_Di(GConnectionString)
    Dim myE2_Den As New E2_Den(GConnectionString)
    Dim myE2_Di As New E2_Di(GConnectionString)
    Dim myE1_Den As New E1_Den(GConnectionString)
    Dim myKe_Toan_Ca As New Ke_Toan_Ca(GConnectionString)
    Dim myKe_Toan_Ca_QT As New Ke_Toan_Ca_QT(GConnectionString)
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
            row("Ten_Bao_Cao") = "Thống kê sản lượng Theo Túi số"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Ma_Bao_Cao") = 2
            row("Ten_Bao_Cao") = "Thống kê sản lượng Theo Chuyến thư"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Ma_Bao_Cao") = 3
            row("Ten_Bao_Cao") = "Thống kê sản lượng Theo Đường thư"
            dataTable.Rows.Add(row)

            'row = dataTable.NewRow
            'row("Ma_Bao_Cao") = 4
            'row("Ten_Bao_Cao") = "Tổng hợp sản lượng đi Quốc tế"
            'dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Ma_Bao_Cao") = 5
            row("Ten_Bao_Cao") = "Tổng hợp sản lượng đi - đến nội địa"
            dataTable.Rows.Add(row)


            'row = dataTable.NewRow
            'row("Ma_Bao_Cao") = 5
            'row("Ten_Bao_Cao") = "Thống kê chi tiết tồn kho"
            'dataTable.Rows.Add(row)

            CbTuy_Chon_Bao_Cao.DataSource = dataTable
            CbTuy_Chon_Bao_Cao.DataBind()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
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

#Region "FrmDoiSoatDiDen_Load"
    Private Sub FrmDoiSoatDiDen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & " ( " & GBuu_Cuc_Khai_Thac & " - " & GTen_Buu_Cuc_Khai_Thac & " )"
        LbThong_Tin.Text = "Cân đối dữ liệu Đi và Dữ liệu Đến" & vbNewLine & "Đơn vị Khai Thác : " & GTen_Buu_Cuc_Khai_Thac
        Tuy_Chon_Bao_Cao()
        DataGridMa_Ca()
        OptHang_Den.Checked = True
        OptCa_kt.Checked = True
        OptTat_Ca.Checked = True
        CbTu_Ngay.Value = myham_dung_chung.dBeginMonth(Date.Now)
        CbTu_Ngay.Enabled = False
        CbDen_Ngay.Enabled = False
        CbDuong_Thu_Di_Den.Enabled = False
        BtnPreview.Enabled = False
        BtnPrint.Enabled = False
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
        Dim rptBaoCaoDenTheoTuiSo As New RptBao_Cao_Den_Theo_Tui_So
        Dim RptBaoCaoDenTheoChuyenThu As New RptBao_Cao_Den_Theo_Chuyen_Thu
        Dim RptBaoCaoDenTheoDuongThu As New RptBao_Cao_Den_Theo_Duong_Thu
        Dim RptBaoCaoDiDenNoiDiaTheoDuongThu As New RptBao_Cao_Di_Den_Noi_Dia_Theo_Duong_Thu
        Dim pvCollection As New ParameterValues
        Dim FrmView As New FrmViewReports

        
        OptHang_Den_CheckedChanged(Nothing, Nothing)
        OptCa_kt_CheckedChanged(Nothing, Nothing)
        'CbTuy_Chon_Bao_Cao_ValueChanged(Nothing, Nothing)
        Try
            If CbTuy_Chon_Bao_Cao.Value = 1 Then ' Thống kê sản lượng theo Túi Số
                If OptCa_kt.Checked = True Then ' theo ca kế toán
                    If OptTat_Ca.Checked = True Then
                        'mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Tui_So(Id_Ca_Ngaycakt)
                        'mydata = myE2_Den.E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_QT(Id_Ca_Ngaycakt, isQUOCTE).Tables(0)
                        mydata = myE2_Den.E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_QT_Loai_CT(Id_Ca_Ngaycakt, isQUOCTE).Tables(0)
                    Else
                        'mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Ma_BC(Id_Ca_Ngaycakt, CbDuong_Thu_Di_Den.Value)
                        'mydata = myE2_Den.E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Ma_BC_QT(Id_Ca_Ngaycakt, CbDuong_Thu_Di_Den.Value, isQUOCTE).Tables(0)
                        mydata = myE2_Den.E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Ma_BC_QT_Loai_CT(Id_Ca_Ngaycakt, CbDuong_Thu_Di_Den.Value, isQUOCTE).Tables(0)
                    End If
                Else ' theo từ ngày --> Đến_ngày Kế toán
                    If OptTat_Ca.Checked = True Then
                        'mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac)
                        'mydata = myE2_Den.E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_QT(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac, isQUOCTE).Tables(0)
                        mydata = myE2_Den.E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_QT_Loai_CT(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac, isQUOCTE).Tables(0)
                    Else
                        'mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Ma_BC(Tu_Ngay_KT, Den_Ngay_KT, CbDuong_Thu_Di_Den.Value, GBuu_Cuc_Khai_Thac)
                        'mydata = myE2_Den.E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Ma_BC_QT(Tu_Ngay_KT, Den_Ngay_KT, CbDuong_Thu_Di_Den.Value, GBuu_Cuc_Khai_Thac, isQUOCTE).Tables(0)
                        mydata = myE2_Den.E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Ma_BC_QT_Loai_CT(Tu_Ngay_KT, Den_Ngay_KT, CbDuong_Thu_Di_Den.Value, GBuu_Cuc_Khai_Thac, isQUOCTE).Tables(0)
                    End If
                End If
            ElseIf CbTuy_Chon_Bao_Cao.Value = 2 Then ' Thống kê sản lượng theo Chuyến Thư
                If OptCa_kt.Checked = True Then
                    If OptTat_Ca.Checked = True Then
                        'mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu(Id_Ca_Ngaycakt)
                        'mydata = myE2_Den.E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_QT(Id_Ca_Ngaycakt, isQUOCTE).Tables(0)
                        mydata = myE2_Den.E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_QT_Loai_CT(Id_Ca_Ngaycakt, isQUOCTE).Tables(0)
                    Else
                        'mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Ma_BC(Id_Ca_Ngaycakt, CbDuong_Thu_Di_Den.Value)
                        'mydata = myE2_Den.E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Ma_BC_QT(Id_Ca_Ngaycakt, CbDuong_Thu_Di_Den.Value, isQUOCTE).Tables(0)
                        mydata = myE2_Den.E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Ma_BC_QT_Loai_CT(Id_Ca_Ngaycakt, CbDuong_Thu_Di_Den.Value, isQUOCTE).Tables(0)
                    End If
                Else
                    If OptTat_Ca.Checked = True Then
                        'mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac)
                        'mydata = myE2_Den.E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_QT(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac, isQUOCTE).Tables(0)
                        mydata = myE2_Den.E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_QT_Loai_CT(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac, isQUOCTE).Tables(0)
                    Else
                        'mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Ma_BC(Tu_Ngay_KT, Den_Ngay_KT, CbDuong_Thu_Di_Den.Value, GBuu_Cuc_Khai_Thac)
                        'mydata = myE2_Den.E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Ma_BC_QT(Tu_Ngay_KT, Den_Ngay_KT, CbDuong_Thu_Di_Den.Value, GBuu_Cuc_Khai_Thac, isQUOCTE).Tables(0)
                        mydata = myE2_Den.E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Ma_BC_QT_Loai_CT(Tu_Ngay_KT, Den_Ngay_KT, CbDuong_Thu_Di_Den.Value, GBuu_Cuc_Khai_Thac, isQUOCTE).Tables(0)
                    End If
                End If
            ElseIf CbTuy_Chon_Bao_Cao.Value = 3 Then ' Thống kê sản lượng theo Đường Thư
                If OptCa_kt.Checked = True Then
                    If OptTat_Ca.Checked = True Then
                        'mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu(Id_Ca_Ngaycakt)
                        mydata = myE2_Den.E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_QT(Id_Ca_Ngaycakt, isQUOCTE).Tables(0)
                    Else
                        'mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Ma_BC(Id_Ca_Ngaycakt, CbDuong_Thu_Di_Den.Value)
                        mydata = myE2_Den.E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Ma_BC_QT(Id_Ca_Ngaycakt, CbDuong_Thu_Di_Den.Value, isQUOCTE).Tables(0)
                    End If
                Else
                    If OptTat_Ca.Checked = True Then
                        'mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac)
                        mydata = myE2_Den.E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_QT(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac, isQUOCTE).Tables(0)
                    Else
                        'mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_Ma_BC(Tu_Ngay_KT, Den_Ngay_KT, CbDuong_Thu_Di_Den.Value, GBuu_Cuc_Khai_Thac)
                        mydata = myE2_Den.E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_Ma_BC_QT(Tu_Ngay_KT, Den_Ngay_KT, CbDuong_Thu_Di_Den.Value, GBuu_Cuc_Khai_Thac, isQUOCTE).Tables(0)
                    End If
                End If
            ElseIf CbTuy_Chon_Bao_Cao.Value = 4 Then
                MessageBox.Show("Báo cáo này chưa hoàn thiện, mời bạn quay lại sau!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            ElseIf CbTuy_Chon_Bao_Cao.Value = 5 Then
                If tabQT.SelectedTab.Key = "QT" And OptHang_Den.Checked Then
                    MessageBox.Show("Báo cáo này không thực hiện với tùy chọn Quốc tế đến - Hàng đến!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                If tabQT.SelectedTab.Key = "TN" And OptHang_di.Checked Then
                    MessageBox.Show("Báo cáo này không thực hiện với tùy chọn Quốc tế đi - Hàng đi!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                'bat dau lay bao cao
                If OptCa_kt.Checked = True Then
                    If OptTat_Ca.Checked = True Then
                        mydata = myE2_Den.E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_QT_Den_Tu_Noi_Dia(Id_Ca_Ngaycakt, isQUOCTE).Tables(0)
                    Else
                        MessageBox.Show("Báo cáo này không thực hiện với tùy chọn từng mã đường thư!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                        'mydata = myE2_Den.E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Ma_BC_QT(Id_Ca_Ngaycakt, CbDuong_Thu_Di_Den.Value, isQUOCTE).Tables(0)
                    End If
                Else
                    If OptTat_Ca.Checked = True Then
                        'mydata = myE2_Den.Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac)
                        mydata = myE2_Den.E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_QT_Den_Tu_Noi_Dia(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac, isQUOCTE).Tables(0)
                    Else
                        MessageBox.Show("Báo cáo này không thực hiện với tùy chọn từng mã đường thư!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                        'mydata = myE2_Den.E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_Ma_BC_QT(Tu_Ngay_KT, Den_Ngay_KT, CbDuong_Thu_Di_Den.Value, GBuu_Cuc_Khai_Thac, isQUOCTE).Tables(0)
                    End If
                End If
            Else
                CMessageBox.Show("Bạn chưa chọn loại báo cáo cần in !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CbTuy_Chon_Bao_Cao.Select()
                Exit Sub
            End If

            If mydata.Rows.Count > 0 Then ' Nếu có dữ liệu
                If CbTuy_Chon_Bao_Cao.Value = 1 Then ' Tổng hợp theo từng túi số
                    _pThamSo.Value = GLeftMenu
                    pvCollection.Add(_pThamSo)
                    rptBaoCaoDenTheoTuiSo.DataDefinition.ParameterFields("Menu_Trai").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper
                    pvCollection.Add(_pThamSo)
                    rptBaoCaoDenTheoTuiSo.DataDefinition.ParameterFields("Menu_Tieu_De").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Grpt_Don_Vi_Khai_Thac
                    pvCollection.Add(_pThamSo)
                    rptBaoCaoDenTheoTuiSo.DataDefinition.ParameterFields("Menu_Don_Vi_Khai_Thac").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Rpt_Thoi_Gian
                    pvCollection.Add(_pThamSo)
                    rptBaoCaoDenTheoTuiSo.DataDefinition.ParameterFields("Menu_Thoi_Gian").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = GHo_Ten 'GTen_Dang_Nhap
                    pvCollection.Add(_pThamSo)
                    rptBaoCaoDenTheoTuiSo.DataDefinition.ParameterFields("Menu_Ten_Dang_Nhap").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = GrptNgay_Thang_Nam
                    pvCollection.Add(_pThamSo)
                    rptBaoCaoDenTheoTuiSo.DataDefinition.ParameterFields("Menu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    'Menu Phai
                    _pThamSo.Value = Menu_Phai
                    pvCollection.Add(_pThamSo)
                    rptBaoCaoDenTheoTuiSo.DataDefinition.ParameterFields("Menu_Phai").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()

                    rptBaoCaoDenTheoTuiSo.SetDataSource(mydata)
                    FrmView.CrystalReportViewer1.ReportSource = rptBaoCaoDenTheoTuiSo
                ElseIf CbTuy_Chon_Bao_Cao.Value = 2 Then ' Tổng hợp theo Chuyến Thư
                    _pThamSo.Value = GLeftMenu
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDenTheoChuyenThu.DataDefinition.ParameterFields("Menu_Trai").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDenTheoChuyenThu.DataDefinition.ParameterFields("Menu_Tieu_De").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Grpt_Don_Vi_Khai_Thac
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDenTheoChuyenThu.DataDefinition.ParameterFields("Menu_Don_Vi_Khai_Thac").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Rpt_Thoi_Gian
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDenTheoChuyenThu.DataDefinition.ParameterFields("Menu_Thoi_Gian").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = GHo_Ten 'GTen_Dang_Nhap
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDenTheoChuyenThu.DataDefinition.ParameterFields("Menu_Ten_Dang_Nhap").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = GrptNgay_Thang_Nam
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDenTheoChuyenThu.DataDefinition.ParameterFields("Menu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()

                    'Menu Phai
                    _pThamSo.Value = Menu_Phai
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDenTheoChuyenThu.DataDefinition.ParameterFields("Menu_Phai").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()

                    RptBaoCaoDenTheoChuyenThu.SetDataSource(mydata)
                    FrmView.CrystalReportViewer1.ReportSource = RptBaoCaoDenTheoChuyenThu
                ElseIf CbTuy_Chon_Bao_Cao.Value = 3 Then 'Tổng hợp theo đường thư
                    _pThamSo.Value = GLeftMenu
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDenTheoDuongThu.DataDefinition.ParameterFields("Menu_Trai").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDenTheoDuongThu.DataDefinition.ParameterFields("Menu_Tieu_De").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Grpt_Don_Vi_Khai_Thac
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDenTheoDuongThu.DataDefinition.ParameterFields("Menu_Don_Vi_Khai_Thac").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Rpt_Thoi_Gian
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDenTheoDuongThu.DataDefinition.ParameterFields("Menu_Thoi_Gian").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = GHo_Ten 'GTen_Dang_Nhap
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDenTheoDuongThu.DataDefinition.ParameterFields("Menu_Ten_Dang_Nhap").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = GrptNgay_Thang_Nam
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDenTheoDuongThu.DataDefinition.ParameterFields("Menu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()

                    'Menu Phai
                    _pThamSo.Value = Menu_Phai
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDenTheoDuongThu.DataDefinition.ParameterFields("Menu_Phai").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()

                    RptBaoCaoDenTheoDuongThu.SetDataSource(mydata)
                    FrmView.CrystalReportViewer1.ReportSource = RptBaoCaoDenTheoDuongThu
                ElseIf CbTuy_Chon_Bao_Cao.Value = 5 Then 'Tổng hợp theo đi đến nội địa
                    _pThamSo.Value = GLeftMenu
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDiDenNoiDiaTheoDuongThu.DataDefinition.ParameterFields("Menu_Trai").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    Rpt_Menu_Tieu_De = "Thống kê sản lượng nội địa đến"
                    _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDiDenNoiDiaTheoDuongThu.DataDefinition.ParameterFields("Menu_Tieu_De").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Grpt_Don_Vi_Khai_Thac
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDiDenNoiDiaTheoDuongThu.DataDefinition.ParameterFields("Menu_Don_Vi_Khai_Thac").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Rpt_Thoi_Gian
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDiDenNoiDiaTheoDuongThu.DataDefinition.ParameterFields("Menu_Thoi_Gian").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = GHo_Ten 'GTen_Dang_Nhap
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDiDenNoiDiaTheoDuongThu.DataDefinition.ParameterFields("Menu_Ten_Dang_Nhap").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = GrptNgay_Thang_Nam
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDiDenNoiDiaTheoDuongThu.DataDefinition.ParameterFields("Menu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()

                    'Menu Phai
                    Menu_Phai = ""
                    _pThamSo.Value = Menu_Phai
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDiDenNoiDiaTheoDuongThu.DataDefinition.ParameterFields("Menu_Phai").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()

                    RptBaoCaoDiDenNoiDiaTheoDuongThu.SetDataSource(mydata)
                    FrmView.CrystalReportViewer1.ReportSource = RptBaoCaoDiDenNoiDiaTheoDuongThu
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
        Dim rptBaoCaoDiTheoTuiSo As New RptBao_Cao_Di_Theo_Tui_So
        Dim RptBaoCaoDiTheoChuyenThu As New RptBao_Cao_Di_Theo_Chuyen_Thu
        Dim RptBaoCaoDiTheoDuongThu As New RptBao_Cao_Di_Theo_Duong_Thu
        Dim RptBaoCaoDiDenNoiDiaTheoDuongThu As New RptBao_Cao_Di_Den_Noi_Dia_Theo_Duong_Thu
        Dim pvCollection As New ParameterValues
        Dim FrmView As New FrmViewReports
        OptHang_Den_CheckedChanged(Nothing, Nothing)
        OptCa_kt_CheckedChanged(Nothing, Nothing)
        'CbTuy_Chon_Bao_Cao_ValueChanged(Nothing, Nothing)
        Try
            If CbTuy_Chon_Bao_Cao.Value = 1 Then ' Thống kê sản lượng theo Túi Số
                If OptCa_kt.Checked = True Then ' theo ca kế toán
                    If OptTat_Ca.Checked = True Then
                        'mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Tui_So(Id_Ca_Ngaycakt)
                        'mydata = myE2_Di.E2_Di_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_QT(Id_Ca_Ngaycakt, isQUOCTE).Tables(0)
                        mydata = myE2_Di.E2_Di_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_QT_Loai_CT(Id_Ca_Ngaycakt, isQUOCTE).Tables(0)
                    Else
                        'mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Ma_BC(Id_Ca_Ngaycakt, CbDuong_Thu_Di_Den.Value)
                        'mydata = myE2_Di.E2_Di_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Ma_BC_QT(Id_Ca_Ngaycakt, CbDuong_Thu_Di_Den.Value, isQUOCTE).Tables(0)
                        mydata = myE2_Di.E2_Di_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Ma_BC_QT_Loai_CT(Id_Ca_Ngaycakt, CbDuong_Thu_Di_Den.Value, isQUOCTE).Tables(0)
                    End If
                Else ' theo từ ngày --> Đến_ngày Kế toán
                    If OptTat_Ca.Checked = True Then
                        'mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac)
                        'mydata = myE2_Di.E2_Di_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_QT(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac, isQUOCTE).Tables(0)
                        mydata = myE2_Di.E2_Di_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_QT_Loai_CT(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac, isQUOCTE).Tables(0)
                    Else
                        'mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Ma_BC(Tu_Ngay_KT, Den_Ngay_KT, CbDuong_Thu_Di_Den.Value, GBuu_Cuc_Khai_Thac)
                        'mydata = myE2_Di.E2_Di_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Ma_BC_QT(Tu_Ngay_KT, Den_Ngay_KT, CbDuong_Thu_Di_Den.Value, GBuu_Cuc_Khai_Thac, isQUOCTE).Tables(0)
                        mydata = myE2_Di.E2_Di_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Ma_BC_QT_Loai_CT(Tu_Ngay_KT, Den_Ngay_KT, CbDuong_Thu_Di_Den.Value, GBuu_Cuc_Khai_Thac, isQUOCTE).Tables(0)
                    End If
                End If
            ElseIf CbTuy_Chon_Bao_Cao.Value = 2 Then ' Thống kê sản lượng theo Chuyến Thư
                If OptCa_kt.Checked = True Then
                    If OptTat_Ca.Checked = True Then
                        'mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu(Id_Ca_Ngaycakt)
                        'mydata = myE2_Di.E2_Di_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_QT(Id_Ca_Ngaycakt, isQUOCTE).Tables(0)
                        mydata = myE2_Di.E2_Di_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_QT_Loai_CT(Id_Ca_Ngaycakt, isQUOCTE).Tables(0)
                    Else
                        'mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Ma_BC(Id_Ca_Ngaycakt, CbDuong_Thu_Di_Den.Value)
                        'mydata = myE2_Di.E2_Di_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Ma_BC_QT(Id_Ca_Ngaycakt, CbDuong_Thu_Di_Den.Value, isQUOCTE).Tables(0)
                        mydata = myE2_Di.E2_Di_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Ma_BC_QT_Loai_CT(Id_Ca_Ngaycakt, CbDuong_Thu_Di_Den.Value, isQUOCTE).Tables(0)
                    End If
                Else
                    If OptTat_Ca.Checked = True Then
                        'mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac)
                        'mydata = myE2_Di.E2_Di_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_QT(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac, isQUOCTE).Tables(0)
                        mydata = myE2_Di.E2_Di_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_QT_Loai_CT(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac, isQUOCTE).Tables(0)
                    Else
                        'mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Ma_BC(Tu_Ngay_KT, Den_Ngay_KT, CbDuong_Thu_Di_Den.Value, GBuu_Cuc_Khai_Thac)
                        'mydata = myE2_Di.E2_Di_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Ma_BC_QT(Tu_Ngay_KT, Den_Ngay_KT, CbDuong_Thu_Di_Den.Value, GBuu_Cuc_Khai_Thac, isQUOCTE).Tables(0)
                        mydata = myE2_Di.E2_Di_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Ma_BC_QT_Loai_CT(Tu_Ngay_KT, Den_Ngay_KT, CbDuong_Thu_Di_Den.Value, GBuu_Cuc_Khai_Thac, isQUOCTE).Tables(0)
                    End If
                End If
            ElseIf CbTuy_Chon_Bao_Cao.Value = 3 Then ' Thống kê sản lượng theo Đường Thư
                If OptCa_kt.Checked = True Then
                    If OptTat_Ca.Checked = True Then
                        'mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu(Id_Ca_Ngaycakt)
                        mydata = myE2_Di.E2_Di_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_QT(Id_Ca_Ngaycakt, isQUOCTE).Tables(0)
                    Else
                        'mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Ma_BC(Id_Ca_Ngaycakt, CbDuong_Thu_Di_Den.Value)
                        mydata = myE2_Di.E2_Di_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Ma_BC_QT(Id_Ca_Ngaycakt, CbDuong_Thu_Di_Den.Value, isQUOCTE).Tables(0)
                    End If
                Else
                    If OptTat_Ca.Checked = True Then
                        'mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac)
                        mydata = myE2_Di.E2_Di_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_QT(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac, isQUOCTE).Tables(0)
                    Else
                        'mydata = myE2_Di.Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_Ma_BC(Tu_Ngay_KT, Den_Ngay_KT, CbDuong_Thu_Di_Den.Value, GBuu_Cuc_Khai_Thac)
                        mydata = myE2_Di.E2_Di_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_Ma_BC_QT(Tu_Ngay_KT, Den_Ngay_KT, CbDuong_Thu_Di_Den.Value, GBuu_Cuc_Khai_Thac, isQUOCTE).Tables(0)
                    End If
                End If
            ElseIf CbTuy_Chon_Bao_Cao.Value = 4 Then
                MessageBox.Show("Báo cáo này chưa hoàn thiện, mời bạn quay lại sau!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            ElseIf CbTuy_Chon_Bao_Cao.Value = 5 Then
                If tabQT.SelectedTab.Key = "QT" And OptHang_Den.Checked Then
                    MessageBox.Show("Báo cáo này không thực hiện với tùy chọn Quốc tế đến - Hàng đến!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                If tabQT.SelectedTab.Key = "TN" And OptHang_di.Checked Then
                    MessageBox.Show("Báo cáo này không thực hiện với tùy chọn Quốc tế đi - Hàng đi!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                'Bat dau lay du lieu
                If OptCa_kt.Checked = True Then
                    If OptTat_Ca.Checked = True Then
                        mydata = myE2_Di.E2_Di_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_QT(Id_Ca_Ngaycakt, isQUOCTE).Tables(0)
                    Else
                        MessageBox.Show("Báo cáo này không thực hiện với tùy chọn từng mã đường thư!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                        'mydata = myE2_Di.E2_Di_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Ma_BC_QT(Id_Ca_Ngaycakt, CbDuong_Thu_Di_Den.Value, isQUOCTE).Tables(0)
                    End If
                Else
                    If OptTat_Ca.Checked = True Then
                        mydata = myE2_Di.E2_Di_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_QT_Di_Noi_Dia(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac, isQUOCTE).Tables(0)
                    Else
                        MessageBox.Show("Báo cáo này không thực hiện với tùy chọn từng mã đường thư!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                        'mydata = myE2_Di.E2_Di_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_Ma_BC_QT(Tu_Ngay_KT, Den_Ngay_KT, CbDuong_Thu_Di_Den.Value, GBuu_Cuc_Khai_Thac, isQUOCTE).Tables(0)
                    End If
                End If
            Else
                CMessageBox.Show("Bạn chưa chọn loại báo cáo cần in !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CbTuy_Chon_Bao_Cao.Select()
                Exit Sub
            End If

            If mydata.Rows.Count > 0 Then ' Nếu có dữ liệu
                If CbTuy_Chon_Bao_Cao.Value = 1 Then ' Tổng hợp theo từng túi số
                    _pThamSo.Value = GLeftMenu
                    pvCollection.Add(_pThamSo)
                    rptBaoCaoDiTheoTuiSo.DataDefinition.ParameterFields("Menu_Trai").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper
                    pvCollection.Add(_pThamSo)
                    rptBaoCaoDiTheoTuiSo.DataDefinition.ParameterFields("Menu_Tieu_De").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Grpt_Don_Vi_Khai_Thac
                    pvCollection.Add(_pThamSo)
                    rptBaoCaoDiTheoTuiSo.DataDefinition.ParameterFields("Menu_Don_Vi_Khai_Thac").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Rpt_Thoi_Gian
                    pvCollection.Add(_pThamSo)
                    rptBaoCaoDiTheoTuiSo.DataDefinition.ParameterFields("Menu_Thoi_Gian").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = GHo_Ten 'GTen_Dang_Nhap
                    pvCollection.Add(_pThamSo)
                    rptBaoCaoDiTheoTuiSo.DataDefinition.ParameterFields("Menu_Ten_Dang_Nhap").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = GrptNgay_Thang_Nam
                    pvCollection.Add(_pThamSo)
                    rptBaoCaoDiTheoTuiSo.DataDefinition.ParameterFields("Menu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()

                    'Menu Phai
                    _pThamSo.Value = Menu_Phai
                    pvCollection.Add(_pThamSo)
                    rptBaoCaoDiTheoTuiSo.DataDefinition.ParameterFields("Menu_Phai").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()

                    rptBaoCaoDiTheoTuiSo.SetDataSource(mydata)
                    FrmView.CrystalReportViewer1.ReportSource = rptBaoCaoDiTheoTuiSo
                ElseIf CbTuy_Chon_Bao_Cao.Value = 2 Then ' Tổng hợp theo Chuyến Thư
                    _pThamSo.Value = GLeftMenu
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDiTheoChuyenThu.DataDefinition.ParameterFields("Menu_Trai").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDiTheoChuyenThu.DataDefinition.ParameterFields("Menu_Tieu_De").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Grpt_Don_Vi_Khai_Thac
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDiTheoChuyenThu.DataDefinition.ParameterFields("Menu_Don_Vi_Khai_Thac").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Rpt_Thoi_Gian
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDiTheoChuyenThu.DataDefinition.ParameterFields("Menu_Thoi_Gian").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = GHo_Ten 'GTen_Dang_Nhap
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDiTheoChuyenThu.DataDefinition.ParameterFields("Menu_Ten_Dang_Nhap").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = GrptNgay_Thang_Nam
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDiTheoChuyenThu.DataDefinition.ParameterFields("Menu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()

                    'Menu Phai
                    _pThamSo.Value = Menu_Phai
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDiTheoChuyenThu.DataDefinition.ParameterFields("Menu_Phai").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()

                    RptBaoCaoDiTheoChuyenThu.SetDataSource(mydata)
                    FrmView.CrystalReportViewer1.ReportSource = RptBaoCaoDiTheoChuyenThu
                ElseIf CbTuy_Chon_Bao_Cao.Value = 3 Then 'Tổng hợp theo đường thư
                    _pThamSo.Value = GLeftMenu
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDiTheoDuongThu.DataDefinition.ParameterFields("Menu_Trai").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDiTheoDuongThu.DataDefinition.ParameterFields("Menu_Tieu_De").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Grpt_Don_Vi_Khai_Thac
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDiTheoDuongThu.DataDefinition.ParameterFields("Menu_Don_Vi_Khai_Thac").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Rpt_Thoi_Gian
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDiTheoDuongThu.DataDefinition.ParameterFields("Menu_Thoi_Gian").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = GHo_Ten 'GTen_Dang_Nhap
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDiTheoDuongThu.DataDefinition.ParameterFields("Menu_Ten_Dang_Nhap").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = GrptNgay_Thang_Nam
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDiTheoDuongThu.DataDefinition.ParameterFields("Menu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()

                    'Menu Phai
                    _pThamSo.Value = Menu_Phai
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDiTheoDuongThu.DataDefinition.ParameterFields("Menu_Phai").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()

                    RptBaoCaoDiTheoDuongThu.SetDataSource(mydata)
                    FrmView.CrystalReportViewer1.ReportSource = RptBaoCaoDiTheoDuongThu
                ElseIf CbTuy_Chon_Bao_Cao.Value = 5 Then 'Tổng hợp theo đi đến nội địa
                    _pThamSo.Value = GLeftMenu
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDiDenNoiDiaTheoDuongThu.DataDefinition.ParameterFields("Menu_Trai").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    Rpt_Menu_Tieu_De = "Thống kê sản lượng đi nội địa"
                    _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDiDenNoiDiaTheoDuongThu.DataDefinition.ParameterFields("Menu_Tieu_De").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Grpt_Don_Vi_Khai_Thac
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDiDenNoiDiaTheoDuongThu.DataDefinition.ParameterFields("Menu_Don_Vi_Khai_Thac").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = Rpt_Thoi_Gian
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDiDenNoiDiaTheoDuongThu.DataDefinition.ParameterFields("Menu_Thoi_Gian").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = GHo_Ten 'GTen_Dang_Nhap
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDiDenNoiDiaTheoDuongThu.DataDefinition.ParameterFields("Menu_Ten_Dang_Nhap").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    _pThamSo.Value = GrptNgay_Thang_Nam
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDiDenNoiDiaTheoDuongThu.DataDefinition.ParameterFields("Menu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()

                    'Menu Phai
                    Menu_Phai = ""
                    _pThamSo.Value = Menu_Phai
                    pvCollection.Add(_pThamSo)
                    RptBaoCaoDiDenNoiDiaTheoDuongThu.DataDefinition.ParameterFields("Menu_Phai").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()

                    RptBaoCaoDiDenNoiDiaTheoDuongThu.SetDataSource(mydata)
                    FrmView.CrystalReportViewer1.ReportSource = RptBaoCaoDiDenNoiDiaTheoDuongThu
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

#Region "FrmDoiSoatDiDen_KeyPress"
    Private Sub FrmDoiSoatDiDen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "OPT CheckedChanged - Các sự kiện CheckedChanged của Option"
#Region "OptHang_Den_CheckedChanged"
    Private Sub OptHang_Den_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptHang_Den.CheckedChanged
        Try
            If OptHang_Den.Checked = True Then
                Rpt_Menu_Tieu_De = "THỐNG KÊ SẢN LƯỢNG ĐẾN"
                CbDuong_Thu_Di_Den.DataSource = myDuong_Thu_Den.Lay_Boi_Ma_Bc_Khai_Thac(GBuu_Cuc_Khai_Thac)
            Else
                Rpt_Menu_Tieu_De = "THỐNG KÊ SẢN LƯỢNG ĐI"
                CbDuong_Thu_Di_Den.DataSource = myDuong_Thu_Di.Lay_Boi_Ma_Bc_Khai_Thac(GBuu_Cuc_Khai_Thac)
            End If
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

#Region "OptTheo_BC_CheckedChanged"
    Private Sub OptTheo_BC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptTheo_BC.CheckedChanged
        Try
            If OptTheo_BC.Checked = True Then
                CbDuong_Thu_Di_Den.Enabled = True
                If CbDuong_Thu_Di_Den.Rows.Count > 0 Then
                    CbDuong_Thu_Di_Den.Value = CbDuong_Thu_Di_Den.Rows(0).Cells("Ma_BC").Value
                End If
            Else
                CbDuong_Thu_Di_Den.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region
#End Region

#Region "BtnE1_Den_Chua_Di_Click - E1 đến chưa đi"
    Private Sub BtnE1_Den_Chua_Di_Click()
        Dim mydata As DataTable
        Dim RptBaoCaoE1DenChuaDi As New RptBao_Cao_E1_Den_Chua_Di
        Dim pvCollection As New ParameterValues
        Dim FrmView As New FrmViewReports
        OptCa_kt_CheckedChanged(Nothing, Nothing)
        OptNgay_Kt_CheckedChanged(Nothing, Nothing)
        Rpt_Menu_Tieu_De = Nothing
        Rpt_Menu_Tieu_De = "BẢNG THỐNG KÊ E1 ĐÃ CÓ CHI TIẾT ĐẾN" & vbNewLine & "NHƯNG CHƯA CÓ CHI TIẾT ĐI"
        Try
            If OptCa_kt.Checked = True Then
                'mydata = myE1_Den.Lay_Boi_Ca_San_Xuat_E1_Den_Chua_Di(Id_Ca_Ngaycakt)
                mydata = myE1_Den.E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Chua_Di_QT(Id_Ca_Ngaycakt, isQUOCTE)
            Else
                'mydata = myE1_Den.Lay_Boi_Ca_San_Xuat_E1_Den_Chua_Di_Tu_Ngay_Den_Ngay(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac)
                mydata = myE1_Den.Lay_Boi_Ca_San_Xuat_E1_Den_Chua_Di_Tu_Ngay_Den_Ngay_QT(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac, isQUOCTE)
            End If
            If mydata.Rows.Count = 0 Then
                CMessageBox.Show("Không có thông tin dữ liệu về loại báo cáo này !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            _pThamSo.Value = GLeftMenu
            pvCollection.Add(_pThamSo)
            RptBaoCaoE1DenChuaDi.DataDefinition.ParameterFields("Menu_Trai").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper
            pvCollection.Add(_pThamSo)
            RptBaoCaoE1DenChuaDi.DataDefinition.ParameterFields("Menu_Tieu_De").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            _pThamSo.Value = Grpt_Don_Vi_Khai_Thac
            pvCollection.Add(_pThamSo)
            RptBaoCaoE1DenChuaDi.DataDefinition.ParameterFields("Menu_Don_Vi_Khai_Thac").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            _pThamSo.Value = Rpt_Thoi_Gian
            pvCollection.Add(_pThamSo)
            RptBaoCaoE1DenChuaDi.DataDefinition.ParameterFields("Menu_Thoi_Gian").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            _pThamSo.Value = GHo_Ten 'GTen_Dang_Nhap
            pvCollection.Add(_pThamSo)
            RptBaoCaoE1DenChuaDi.DataDefinition.ParameterFields("Menu_Ten_Dang_Nhap").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            _pThamSo.Value = GrptNgay_Thang_Nam
            pvCollection.Add(_pThamSo)
            RptBaoCaoE1DenChuaDi.DataDefinition.ParameterFields("Menu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = Menu_Phai
            pvCollection.Add(_pThamSo)
            RptBaoCaoE1DenChuaDi.DataDefinition.ParameterFields("Menu_Phai").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            RptBaoCaoE1DenChuaDi.SetDataSource(mydata)
            FrmView.CrystalReportViewer1.ReportSource = RptBaoCaoE1DenChuaDi
            Cursor.Current = Cursors.Default
            FrmView.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "BtnE1_Di_Chua_Den_Click - E1 đi chưa đến"
    Private Sub BtnE1_Di_Chua_Den_Click()
        Dim mydata As DataTable
        Dim RptBaoCaoE1DiChuaDen As New RptBao_Cao_E1_Di_Chua_Den
        Dim pvCollection As New ParameterValues
        Dim FrmView As New FrmViewReports
        OptCa_kt_CheckedChanged(Nothing, Nothing)
        OptNgay_Kt_CheckedChanged(Nothing, Nothing)
        Rpt_Menu_Tieu_De = Nothing
        Rpt_Menu_Tieu_De = "BẢNG THỐNG KÊ E1 ĐÃ CÓ CHI TIẾT ĐI" & vbNewLine & "NHƯNG CHƯA CÓ CHI TIẾT ĐẾN"
        Try
            If OptCa_kt.Checked = True Then
                'mydata = myE1_Den.Lay_Boi_Ca_San_Xuat_E1_Di_Chua_Den(Id_Ca_Ngaycakt)
                mydata = myE1_Den.Lay_Boi_Ca_San_Xuat_E1_Di_Chua_Den_QT(Id_Ca_Ngaycakt, isQUOCTE)
            Else
                'mydata = myE1_Den.Lay_Boi_Ca_San_Xuat_E1_Di_Chua_Den_Tu_Ngay_Den_Ngay(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac)
                mydata = myE1_Den.Lay_Boi_Ca_San_Xuat_E1_Di_Chua_Den_Tu_Ngay_Den_Ngay_QT(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac, isQUOCTE)
            End If
            If mydata.Rows.Count = 0 Then
                CMessageBox.Show("Không có thông tin dữ liệu về loại báo cáo này !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            _pThamSo.Value = GLeftMenu
            pvCollection.Add(_pThamSo)
            RptBaoCaoE1DiChuaDen.DataDefinition.ParameterFields("Menu_Trai").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper
            pvCollection.Add(_pThamSo)
            RptBaoCaoE1DiChuaDen.DataDefinition.ParameterFields("Menu_Tieu_De").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            _pThamSo.Value = Grpt_Don_Vi_Khai_Thac
            pvCollection.Add(_pThamSo)
            RptBaoCaoE1DiChuaDen.DataDefinition.ParameterFields("Menu_Don_Vi_Khai_Thac").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            _pThamSo.Value = Rpt_Thoi_Gian
            pvCollection.Add(_pThamSo)
            RptBaoCaoE1DiChuaDen.DataDefinition.ParameterFields("Menu_Thoi_Gian").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            _pThamSo.Value = GHo_Ten 'GTen_Dang_Nhap
            pvCollection.Add(_pThamSo)
            RptBaoCaoE1DiChuaDen.DataDefinition.ParameterFields("Menu_Ten_Dang_Nhap").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            _pThamSo.Value = GrptNgay_Thang_Nam
            pvCollection.Add(_pThamSo)
            RptBaoCaoE1DiChuaDen.DataDefinition.ParameterFields("Menu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = Menu_Phai
            pvCollection.Add(_pThamSo)
            RptBaoCaoE1DiChuaDen.DataDefinition.ParameterFields("Menu_Phai").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            RptBaoCaoE1DiChuaDen.SetDataSource(mydata)
            FrmView.CrystalReportViewer1.ReportSource = RptBaoCaoE1DiChuaDen
            Cursor.Current = Cursors.Default
            FrmView.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "BtnE1_Den_Nhieu_Lan_Click - E1 Đến nhiều lần"
    Private Sub BtnE1_Den_Nhieu_Lan_Click()
        Dim mydata As DataTable
        Dim RptBaoCaoE1DenNhieuLan As New RptBao_Cao_E1_Den_Nhieu_Lan
        Dim pvCollection As New ParameterValues
        Dim FrmView As New FrmViewReports
        OptCa_kt_CheckedChanged(Nothing, Nothing)
        OptNgay_Kt_CheckedChanged(Nothing, Nothing)
        Rpt_Menu_Tieu_De = Nothing
        Rpt_Menu_Tieu_De = "BẢNG THỐNG KÊ E1 NHẬP ĐẾN NHIỀU LẦN TRONG CA"
        Try
            If OptCa_kt.Checked = True Then
                'mydata = myE1_Den.Lay_Boi_Ca_San_Xuat_E1_Den_Nhieu_Lan(Id_Ca_Ngaycakt)
                mydata = myE1_Den.Lay_Boi_Ca_San_Xuat_E1_Den_Nhieu_Lan_QT(Id_Ca_Ngaycakt, isQUOCTE)
            Else
                'mydata = myE1_Den.Lay_Boi_Ca_San_Xuat_E1_Den_Nhieu_Lan_Tu_Ngay_Den_Ngay(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac)
                mydata = myE1_Den.Lay_Boi_Ca_San_Xuat_E1_Den_Nhieu_Lan_Tu_Ngay_Den_Ngay_QT(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac, isQUOCTE)
            End If
            If mydata.Rows.Count = 0 Then
                CMessageBox.Show("Không có thông tin dữ liệu về loại báo cáo này !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            _pThamSo.Value = GLeftMenu
            pvCollection.Add(_pThamSo)
            RptBaoCaoE1DenNhieuLan.DataDefinition.ParameterFields("Menu_Trai").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper
            pvCollection.Add(_pThamSo)
            RptBaoCaoE1DenNhieuLan.DataDefinition.ParameterFields("Menu_Tieu_De").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            _pThamSo.Value = Grpt_Don_Vi_Khai_Thac
            pvCollection.Add(_pThamSo)
            RptBaoCaoE1DenNhieuLan.DataDefinition.ParameterFields("Menu_Don_Vi_Khai_Thac").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            _pThamSo.Value = Rpt_Thoi_Gian
            pvCollection.Add(_pThamSo)
            RptBaoCaoE1DenNhieuLan.DataDefinition.ParameterFields("Menu_Thoi_Gian").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            _pThamSo.Value = GHo_Ten 'GTen_Dang_Nhap
            pvCollection.Add(_pThamSo)
            RptBaoCaoE1DenNhieuLan.DataDefinition.ParameterFields("Menu_Ten_Dang_Nhap").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            _pThamSo.Value = GrptNgay_Thang_Nam
            pvCollection.Add(_pThamSo)
            RptBaoCaoE1DenNhieuLan.DataDefinition.ParameterFields("Menu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = Menu_Phai
            pvCollection.Add(_pThamSo)
            RptBaoCaoE1DenNhieuLan.DataDefinition.ParameterFields("Menu_Phai").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            RptBaoCaoE1DenNhieuLan.SetDataSource(mydata)
            FrmView.CrystalReportViewer1.ReportSource = RptBaoCaoE1DenNhieuLan
            Cursor.Current = Cursors.Default
            FrmView.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "BtnE1_Di_Nhieu_Lan_Click - E1 Đi nhiều lần"
    Private Sub BtnE1_Di_Nhieu_Lan_Click()
        Dim mydata As DataTable
        Dim RptBaoCaoE1DenNhieuLan As New RptBao_Cao_E1_Den_Nhieu_Lan ' dung chung 1 report va dataset voi den nhieu lan
        Dim pvCollection As New ParameterValues
        Dim FrmView As New FrmViewReports
        OptCa_kt_CheckedChanged(Nothing, Nothing)
        OptNgay_Kt_CheckedChanged(Nothing, Nothing)
        Rpt_Menu_Tieu_De = Nothing
        Rpt_Menu_Tieu_De = "BẢNG THỐNG KÊ E1 ĐÓNG ĐI NHIỀU LẦN TRONG CA"
        Try
            If OptCa_kt.Checked = True Then
                'mydata = myE1_Den.Lay_Boi_Ca_San_Xuat_E1_Di_Nhieu_Lan(Id_Ca_Ngaycakt)
                mydata = myE1_Den.Lay_Boi_Ca_San_Xuat_E1_Di_Nhieu_Lan_QT(Id_Ca_Ngaycakt, isQUOCTE)
            Else
                'mydata = myE1_Den.Lay_Boi_Ca_San_Xuat_E1_Di_Nhieu_Lan_Tu_Ngay_Den_Ngay(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac)
                mydata = myE1_Den.Lay_Boi_Ca_San_Xuat_E1_Di_Nhieu_Lan_Tu_Ngay_Den_Ngay_QT(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac, isQUOCTE)
            End If
            If mydata.Rows.Count = 0 Then
                CMessageBox.Show("Không có thông tin dữ liệu về loại báo cáo này !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            _pThamSo.Value = GLeftMenu
            pvCollection.Add(_pThamSo)
            RptBaoCaoE1DenNhieuLan.DataDefinition.ParameterFields("Menu_Trai").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper
            pvCollection.Add(_pThamSo)
            RptBaoCaoE1DenNhieuLan.DataDefinition.ParameterFields("Menu_Tieu_De").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            _pThamSo.Value = Grpt_Don_Vi_Khai_Thac
            pvCollection.Add(_pThamSo)
            RptBaoCaoE1DenNhieuLan.DataDefinition.ParameterFields("Menu_Don_Vi_Khai_Thac").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            _pThamSo.Value = Rpt_Thoi_Gian
            pvCollection.Add(_pThamSo)
            RptBaoCaoE1DenNhieuLan.DataDefinition.ParameterFields("Menu_Thoi_Gian").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            _pThamSo.Value = GHo_Ten 'GTen_Dang_Nhap
            pvCollection.Add(_pThamSo)
            RptBaoCaoE1DenNhieuLan.DataDefinition.ParameterFields("Menu_Ten_Dang_Nhap").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            _pThamSo.Value = GrptNgay_Thang_Nam
            pvCollection.Add(_pThamSo)
            RptBaoCaoE1DenNhieuLan.DataDefinition.ParameterFields("Menu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = Menu_Phai
            pvCollection.Add(_pThamSo)
            RptBaoCaoE1DenNhieuLan.DataDefinition.ParameterFields("Menu_Phai").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            RptBaoCaoE1DenNhieuLan.SetDataSource(mydata)
            FrmView.CrystalReportViewer1.ReportSource = RptBaoCaoE1DenNhieuLan 'dung chung 1 report va dataset voi den nhieu lan
            Cursor.Current = Cursors.Default
            FrmView.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "BtnPreview_Can_Doi_Click - Cân đối dữ liệu đi đến"
    Private Sub Btn_Can_Doi_Click()
        Dim Ngay_Khai_Thac As Long
        Dim Ca_Khai_Thac As Long
        Dim mydata As DataTable
        Dim RptBaoCaoCanDoiDiDen As New RptBao_Cao_Can_Doi_Di_Den
        Dim RptBaoCaoCanDoiDiDenTuNgayDenNgay As New RptBao_Cao_Can_Doi_Di_Den_Tu_Ngay_Den_Ngay
        Dim pvCollection As New ParameterValues
        Dim FrmView As New FrmViewReports
        OptCa_kt_CheckedChanged(Nothing, Nothing)
        OptNgay_Kt_CheckedChanged(Nothing, Nothing)
        Rpt_Menu_Tieu_De = Nothing
        Rpt_Menu_Tieu_De = "BẢNG CÂN ĐỐI DỮ LIỆU ĐẾN VÀ DỮ LIỆU ĐÓNG ĐI"

        Try

            If OptCa_kt.Checked = True Then
                Ngay_Khai_Thac = Mid(Id_Ca_Ngaycakt, 7, 8)
                Ca_Khai_Thac = Mid(Id_Ca_Ngaycakt, 15, 1)
                'myE1_Den.Call_Store_E1_Chenh_Lech_KL(Id_Ca_Ngaycakt)
                'Cap nhat du lieu hoac day du lieu vao table Ke_Toan_Ca_QT
                If myKe_Toan_Ca_QT.Ke_Toan_Ca_QT_Cap_Nhat_Them_Can_Doi_Di_Den(Id_Ca_Ngaycakt, isQUOCTE, GBuu_Cuc_Khai_Thac, Ngay_Khai_Thac, Ca_Khai_Thac, False) = -1 Then
                    Exit Sub
                Else
                    mydata = myKe_Toan_Ca_QT.Ke_Toan_Ca_QT_Lay_Boi_Id_Ca_Can_Doi_Di_Den(Id_Ca_Ngaycakt + isQUOCTE.ToString)
                End If
                If mydata.Rows.Count = 0 Then
                    CMessageBox.Show("Không có thông tin dữ liệu về loại báo cáo này !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                _pThamSo.Value = GLeftMenu
                pvCollection.Add(_pThamSo)
                RptBaoCaoCanDoiDiDen.DataDefinition.ParameterFields("Menu_Trai").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()
                _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper
                pvCollection.Add(_pThamSo)
                RptBaoCaoCanDoiDiDen.DataDefinition.ParameterFields("Menu_Tieu_De").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()
                _pThamSo.Value = Grpt_Don_Vi_Khai_Thac
                pvCollection.Add(_pThamSo)
                RptBaoCaoCanDoiDiDen.DataDefinition.ParameterFields("Menu_Don_Vi_Khai_Thac").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()
                _pThamSo.Value = Rpt_Thoi_Gian
                pvCollection.Add(_pThamSo)
                RptBaoCaoCanDoiDiDen.DataDefinition.ParameterFields("Menu_Thoi_Gian").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()
                _pThamSo.Value = GHo_Ten 'GTen_Dang_Nhap
                pvCollection.Add(_pThamSo)
                RptBaoCaoCanDoiDiDen.DataDefinition.ParameterFields("Menu_Ten_Dang_Nhap").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()
                _pThamSo.Value = GrptNgay_Thang_Nam
                pvCollection.Add(_pThamSo)
                RptBaoCaoCanDoiDiDen.DataDefinition.ParameterFields("Menu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()

                _pThamSo.Value = Menu_Phai
                pvCollection.Add(_pThamSo)
                RptBaoCaoCanDoiDiDen.DataDefinition.ParameterFields("Menu_Phai").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()

                RptBaoCaoCanDoiDiDen.SetDataSource(mydata)
                FrmView.CrystalReportViewer1.ReportSource = RptBaoCaoCanDoiDiDen
                Cursor.Current = Cursors.Default
                FrmView.ShowDialog()
            Else
                mydata = myKe_Toan_Ca_QT.Ke_Toan_Ca_QT_Lay_Boi_Id_Ca_Tu_Ngay_Den_Ngay(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac, isQUOCTE)
                If mydata.Rows.Count = 0 Then
                    CMessageBox.Show("Không có thông tin dữ liệu về loại báo cáo này !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                _pThamSo.Value = GLeftMenu
                pvCollection.Add(_pThamSo)
                RptBaoCaoCanDoiDiDenTuNgayDenNgay.DataDefinition.ParameterFields("Menu_Trai").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()
                _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper
                pvCollection.Add(_pThamSo)
                RptBaoCaoCanDoiDiDenTuNgayDenNgay.DataDefinition.ParameterFields("Menu_Tieu_De").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()
                _pThamSo.Value = Grpt_Don_Vi_Khai_Thac
                pvCollection.Add(_pThamSo)
                RptBaoCaoCanDoiDiDenTuNgayDenNgay.DataDefinition.ParameterFields("Menu_Don_Vi_Khai_Thac").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()
                _pThamSo.Value = Rpt_Thoi_Gian
                pvCollection.Add(_pThamSo)
                RptBaoCaoCanDoiDiDenTuNgayDenNgay.DataDefinition.ParameterFields("Menu_Thoi_Gian").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()
                _pThamSo.Value = GHo_Ten 'GTen_Dang_Nhap
                pvCollection.Add(_pThamSo)
                RptBaoCaoCanDoiDiDenTuNgayDenNgay.DataDefinition.ParameterFields("Menu_Ten_Dang_Nhap").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()
                _pThamSo.Value = GrptNgay_Thang_Nam
                pvCollection.Add(_pThamSo)
                RptBaoCaoCanDoiDiDenTuNgayDenNgay.DataDefinition.ParameterFields("Menu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()

                _pThamSo.Value = Menu_Phai
                pvCollection.Add(_pThamSo)
                RptBaoCaoCanDoiDiDenTuNgayDenNgay.DataDefinition.ParameterFields("Menu_Phai").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()

                RptBaoCaoCanDoiDiDenTuNgayDenNgay.SetDataSource(mydata)
                FrmView.CrystalReportViewer1.ReportSource = RptBaoCaoCanDoiDiDenTuNgayDenNgay
                Cursor.Current = Cursors.Default
                FrmView.ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "BtnChenh_Lech_Trlg_Click - E1 chênh lệch trọng lượng"
    Private Sub BtnChenh_Lech_Trlg_Click()
        Dim mydata As DataTable
        Dim RptBaoCaoE1ChenhLechKL As New RptBao_Cao_E1_Chenh_Lech_KL
        Dim pvCollection As New ParameterValues
        Dim FrmView As New FrmViewReports
        OptCa_kt_CheckedChanged(Nothing, Nothing)
        OptNgay_Kt_CheckedChanged(Nothing, Nothing)
        Rpt_Menu_Tieu_De = Nothing
        Rpt_Menu_Tieu_De = "BẢNG THỐNG KÊ E1 CHÊNH LỆCH KHỐI LƯỢNG"
        Try
            If OptCa_kt.Checked = True Then
                'mydata = myE1_Den.Lay_Boi_Ca_San_Xuat_Danh_Sach_E1_Chenh_Lech_KL(Id_Ca_Ngaycakt)
                mydata = myE1_Den.Lay_Boi_Ca_San_Xuat_Danh_Sach_E1_Chenh_Lech_KL_QT(Id_Ca_Ngaycakt, isQUOCTE)
            Else
                'mydata = myE1_Den.Lay_Boi_Ca_San_Xuat_Danh_Sach_E1_Chenh_Lech_KL_Tu_Ngay_Den_Ngay(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac)
                mydata = myE1_Den.Lay_Boi_Ca_San_Xuat_Danh_Sach_E1_Chenh_Lech_KL_Tu_Ngay_Den_Ngay_QT(Tu_Ngay_KT, Den_Ngay_KT, GBuu_Cuc_Khai_Thac, isQUOCTE)
            End If
            If mydata.Rows.Count = 0 Then
                CMessageBox.Show("Không có thông tin dữ liệu về loại báo cáo này !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            _pThamSo.Value = GLeftMenu
            pvCollection.Add(_pThamSo)
            RptBaoCaoE1ChenhLechKL.DataDefinition.ParameterFields("Menu_Trai").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper
            pvCollection.Add(_pThamSo)
            RptBaoCaoE1ChenhLechKL.DataDefinition.ParameterFields("Menu_Tieu_De").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            _pThamSo.Value = Grpt_Don_Vi_Khai_Thac
            pvCollection.Add(_pThamSo)
            RptBaoCaoE1ChenhLechKL.DataDefinition.ParameterFields("Menu_Don_Vi_Khai_Thac").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            _pThamSo.Value = Rpt_Thoi_Gian
            pvCollection.Add(_pThamSo)
            RptBaoCaoE1ChenhLechKL.DataDefinition.ParameterFields("Menu_Thoi_Gian").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            _pThamSo.Value = GHo_Ten 'GTen_Dang_Nhap
            pvCollection.Add(_pThamSo)
            RptBaoCaoE1ChenhLechKL.DataDefinition.ParameterFields("Menu_Ten_Dang_Nhap").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            _pThamSo.Value = GrptNgay_Thang_Nam
            pvCollection.Add(_pThamSo)
            RptBaoCaoE1ChenhLechKL.DataDefinition.ParameterFields("Menu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            'Dang sua nen chua dua gia tri vao menu_phai
            _pThamSo.Value = Menu_Phai
            '_pThamSo.Value = ""
            pvCollection.Add(_pThamSo)
            RptBaoCaoE1ChenhLechKL.DataDefinition.ParameterFields("Menu_Phai").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            RptBaoCaoE1ChenhLechKL.SetDataSource(mydata)
            FrmView.CrystalReportViewer1.ReportSource = RptBaoCaoE1ChenhLechKL
            Cursor.Current = Cursors.Default
            FrmView.ShowDialog()
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

#Region "Exp_In_Bao_Cao_ItemClick"
    Private Sub Exp_In_Bao_Cao_ItemClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinExplorerBar.ItemEventArgs) Handles Exp_In_Bao_Cao.ItemClick
        e.Item.Settings.AppearancesSmall.Appearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.True
        e.Item.Settings.AppearancesSmall.Appearance.FontData.Italic = Infragistics.Win.DefaultableBoolean.True
        Try
            Dim FrmView As New FrmViewReports
            Select Case e.Item.Key
                Case "Btn_0"
                    Btn_Can_Doi_Click()
                Case "Btn_1"
                    BtnChenh_Lech_Trlg_Click()
                Case "Btn_2"
                    BtnE1_Den_Chua_Di_Click()
                Case "Btn_3"
                    BtnE1_Di_Chua_Den_Click()
                Case "Btn_4"
                    BtnE1_Den_Nhieu_Lan_Click()
                Case "Btn_5"
                    BtnE1_Di_Nhieu_Lan_Click()
                Case "Btn_6"

                Case "Btn_7"
                    'Them phan tong hop lai E2 va chuyen thu bi mat 
                    If Tong_Hop_Lai_Thong_Tin_Bi_Mat() = False Then
                        MessageBox.Show("Tổng hợp thông tin thất bại. Vui lòng gọi điện cho người quản trị hệ thống để thông báo về trường hợp này." & vbNewLine & "Nếu bạn không thông báo cho người quản trị thì rất có thể các thông tin về báo cáo sẽ không đầy đủ và chính xác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        If PrbTienTrinh.Visible = True Then
                            PrbTienTrinh.Visible = False
                        End If
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "CbTu_Ngay_AfterExitEditMode"
    Private Sub CbTu_Ngay_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbTu_Ngay.AfterExitEditMode
        Try
            If CbTu_Ngay.Value > CbDen_Ngay.Value Then
                CMessageBox.Show("Giá trị Từ ngày không được lớn hơn giá trị đến ngày !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

#Region "CbTuy_Chon_Bao_Cao_RowSelected"
    Private Sub CbTuy_Chon_Bao_Cao_RowSelected(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowSelectedEventArgs) Handles CbTuy_Chon_Bao_Cao.RowSelected
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

#Region "tabQT_SelectedTabChanged"
    Private Sub tabQT_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles tabQT.SelectedTabChanged
        If e.Tab.Index = 0 Then
            isQUOCTE = 1
            Menu_Phai = "Quốc Tế Đến"
        End If
        If e.Tab.Index = 1 Then
            isQUOCTE = 0
            Menu_Phai = "Quốc Tế Đi"
        End If
    End Sub
#End Region
    
#Region "Module Tổng hợp lại E2 và Chuyến Thư bị mất Id"

#Region "Add New: Tạo mới (Id_Chuyen_Thu,Id_E2,Chuyen_Thu,E2)"

#Region "AddNew_Chuyen_Thu_Den"
    Private Function AddNew_Chuyen_Thu_Den(ByVal Id_Duong_Thu As String, ByVal So_chuyen_thu As Integer, ByVal Date_Create As Integer, ByVal Time_Create As Integer, ByVal Date_Receiver As Integer, ByVal Time_Receiver As Integer, ByVal Loai_Chuyen_Thu As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer) As String
        Try
            Dim mId_Chuyen_Thu As String
            Dim mChuyen_Thu_Den As New Chuyen_Thu_Den(GConnectionString)

            mId_Chuyen_Thu = CreateId_Chuyen_Thu(Id_Duong_Thu, So_chuyen_thu, Date_Create, Loai_Chuyen_Thu)
            mChuyen_Thu_Den.Chuyen_Thu_Den_Cap_Nhat_Them_KT(mId_Chuyen_Thu, Id_Duong_Thu, Id_Ca, Ma_Bc_Khai_Thac, So_chuyen_thu, Date_Create, Time_Create, Date_Receiver, Time_Receiver, _
                                                                0, 0, 0, 0, 0, 0, 0, 0, 0, False, False, False, False)
            Return mId_Chuyen_Thu
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        End Try
    End Function
#End Region

#Region "AddNew_E2_Den"
    Private Function AddNew_E2_Den(ByVal Id_Duong_Thu As String, ByVal So_Chuyen_Thu As Integer, ByVal Tui_So As Integer, ByVal Date_Create As Integer, ByVal Time_Create As Integer, ByVal Date_Receiver As Integer, ByVal Time_Receiver As Integer, ByVal Loai_Chuyen_Thu As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer) As String
        Try
            Dim mChuyen_Thu_Den As New Chuyen_Thu_Den(GConnectionString)
            Dim mId_Chuyen_Thu As String
            Dim mId_E2 As String

            mId_Chuyen_Thu = AddNew_Chuyen_Thu_Den(Id_Duong_Thu, So_Chuyen_Thu, Date_Create, Time_Create, Date_Receiver, Time_Receiver, Loai_Chuyen_Thu, Id_Ca, Ma_Bc_Khai_Thac)

            mId_E2 = CreateId_E2(mId_Chuyen_Thu, Tui_So)
            myE2_Den.E2_Den_Cap_Nhat_Them_KT(mId_E2, Id_Duong_Thu, mId_Chuyen_Thu, Id_Ca, Ma_Bc_Khai_Thac, Date_Create, Time_Create, Date_Receiver, Time_Receiver, Tui_So, _
                                                False, 0, 0, 0, 0, 0, 0, 0, 0, False, False, False)
            Return mId_E2
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        End Try
    End Function
#End Region

#Region "AddNew_Chuyen_Thu_Di"
    Private Function AddNew_Chuyen_Thu_Di(ByVal Id_Duong_Thu As String, ByVal So_chuyen_thu As Integer, ByVal Date_Create As Integer, ByVal Time_Create As Integer, ByVal Date_Receiver As Integer, ByVal Time_Receiver As Integer, ByVal Loai_Chuyen_Thu As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer) As String
        Try
            Dim mId_Chuyen_Thu As String
            Dim mChuyen_Thu_Di As New Chuyen_Thu_Di(GConnectionString)

            mId_Chuyen_Thu = CreateId_Chuyen_Thu(Id_Duong_Thu, So_chuyen_thu, Date_Create, Loai_Chuyen_Thu)
            mChuyen_Thu_Di.Chuyen_Thu_Di_Cap_Nhat_Them_KT(mId_Chuyen_Thu, Id_Duong_Thu, Id_Ca, Ma_Bc_Khai_Thac, So_chuyen_thu, Date_Create, Time_Create, Date_Receiver, Time_Receiver, _
                                                                0, 0, 0, 0, 0, 0, 0, 0, 0, False, False, False, False)
            Return mId_Chuyen_Thu
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        End Try
    End Function
#End Region

#Region "AddNew_E2_Di"
    Private Function AddNew_E2_Di(ByVal Id_Duong_Thu As String, ByVal So_Chuyen_Thu As Integer, ByVal Tui_So As Integer, ByVal Date_Create As Integer, ByVal Time_Create As Integer, ByVal Date_Receiver As Integer, ByVal Time_Receiver As Integer, ByVal Loai_Chuyen_Thu As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer) As String
        Try
            Dim mChuyen_Thu_Di As New Chuyen_Thu_Di(GConnectionString)
            Dim mId_Chuyen_Thu As String
            Dim mId_E2 As String

            mId_Chuyen_Thu = AddNew_Chuyen_Thu_Di(Id_Duong_Thu, So_Chuyen_Thu, Date_Create, Time_Create, Date_Receiver, Time_Receiver, Loai_Chuyen_Thu, Id_Ca, Ma_Bc_Khai_Thac)

            mId_E2 = CreateId_E2(mId_Chuyen_Thu, Tui_So)
            myE2_Di.E2_Di_Cap_Nhat_Them_KT(mId_E2, Id_Duong_Thu, mId_Chuyen_Thu, Id_Ca, Ma_Bc_Khai_Thac, Date_Create, Time_Create, Date_Receiver, Time_Receiver, Tui_So, _
                                                False, 0, 0, 0, 0, 0, 0, 0, 0, False, False, False)
            Return mId_E2
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        End Try
    End Function
#End Region
#End Region

#Region "Tổng hợp thông tin xác nhận đến"

#Region "Tổng hợp E2_Den từ E1_Den"
    Private Sub Tong_Hop_E2_Den_tu_E1_Den(ByVal Id_E2 As String)
        Try
            Dim myE2_Den_Chi_Tiet As New E2_Den_Chi_Tiet
            Dim myE2_Den_TH_E1_Den As New E2_Den_Chi_Tiet

            myE2_Den_Chi_Tiet = myE2_Den.E2_Den_Chi_Tiet_Lay_Boi_Id_E2_KT(Id_E2)
            myE2_Den_TH_E1_Den = myE2_Den.E2_Den_Tong_Hop_Tu_E1_Den_KT(myE2_Den_Chi_Tiet.Id_E2)

            myE2_Den_Chi_Tiet.Tong_So_BP = myE2_Den_TH_E1_Den.Tong_So_BP

            If myE2_Den_Chi_Tiet.Tong_So_BP > 0 Then 'Cập nhật lại thông tin trên E2 nếu tổng số BP>0
                myE2_Den_Chi_Tiet.Tui_F = False
                myE2_Den_Chi_Tiet.Khoi_Luong_Vo_Tui = 340
                myE2_Den_Chi_Tiet.Khoi_Luong_BP = myE2_Den_TH_E1_Den.Khoi_Luong_BP
                myE2_Den_Chi_Tiet.Tong_Cuoc_COD = myE2_Den_TH_E1_Den.Tong_Cuoc_COD
                myE2_Den_Chi_Tiet.Tong_Cuoc_DV = myE2_Den_TH_E1_Den.Tong_Cuoc_DV
                myE2_Den_Chi_Tiet.Tong_Cuoc_Chinh = myE2_Den_TH_E1_Den.Tong_Cuoc_Chinh
                myE2_Den_Chi_Tiet.HH_Phat_Hanh = myE2_Den_TH_E1_Den.HH_Phat_Hanh
                myE2_Den_Chi_Tiet.HH_Phat_Tra = myE2_Den_TH_E1_Den.HH_Phat_Tra
                myE2_Den.E2_Den_Cap_Nhat_Them_KT(myE2_Den_Chi_Tiet.Id_E2, myE2_Den_Chi_Tiet.Id_Duong_Thu, myE2_Den_Chi_Tiet.Id_Chuyen_Thu, myE2_Den_Chi_Tiet.Id_Ca, myE2_Den_Chi_Tiet.Ma_Bc_Khai_Thac, myE2_Den_Chi_Tiet.Ngay_Dong, myE2_Den_Chi_Tiet.Gio_Dong, myE2_Den_Chi_Tiet.Ngay_Nhan, myE2_Den_Chi_Tiet.Gio_Nhan, myE2_Den_Chi_Tiet.Tui_So, myE2_Den_Chi_Tiet.Tui_F, myE2_Den_Chi_Tiet.Tong_So_BP, myE2_Den_Chi_Tiet.Khoi_Luong_Vo_Tui, myE2_Den_Chi_Tiet.Khoi_Luong_BP, myE2_Den_Chi_Tiet.Tong_Cuoc_COD, myE2_Den_Chi_Tiet.Tong_Cuoc_DV, myE2_Den_Chi_Tiet.Tong_Cuoc_Chinh, myE2_Den_Chi_Tiet.HH_Phat_Hanh, myE2_Den_Chi_Tiet.HH_Phat_Tra, myE2_Den_Chi_Tiet.Truyen_Khai_Thac, myE2_Den_Chi_Tiet.Truyen_Doi_Soat, myE2_Den_Chi_Tiet.Chot_SL)
            Else 'Nếu không tồn tại E1-> Xóa
                myE2_Den.Xoa(Id_E2)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Tổng hợp Chuyen_Thu_Den từ E2_Den"
    Private Sub Tong_Hop_Chuyen_Thu_Den_tu_E2_Den(ByVal Id_Chuyen_Thu As String)
        Try
            Dim myChuyen_Thu_Den_Chi_Tiet As New Chuyen_Thu_Den_Chi_Tiet
            Dim myChuyen_Thu_Den_TH_tu_E2_Den As New Chuyen_Thu_Den_Chi_Tiet
            Dim myChuyen_Thu_Den As New Chuyen_Thu_Den(GConnectionString)

            myChuyen_Thu_Den_Chi_Tiet = myChuyen_Thu_Den.Chuyen_Thu_Den_Chi_Tiet_Lay_Boi_Id_Chuyen_Thu_KT(Id_Chuyen_Thu)
            myChuyen_Thu_Den_TH_tu_E2_Den = myChuyen_Thu_Den.Chuyen_Thu_Den_Tong_Hop_Tu_E2_Den_KT(myChuyen_Thu_Den_Chi_Tiet.Id_Chuyen_Thu)

            myChuyen_Thu_Den_Chi_Tiet.Tong_So_Tui = myChuyen_Thu_Den_TH_tu_E2_Den.Tong_So_Tui

            If myChuyen_Thu_Den_Chi_Tiet.Tong_So_Tui > 0 Then 'Nếu tồn tại it nhất 1 bản kê E2 Update lại thông tin trên Chuyến thư
                myChuyen_Thu_Den_Chi_Tiet.Tong_So_BP = myChuyen_Thu_Den_TH_tu_E2_Den.Tong_So_BP
                myChuyen_Thu_Den_Chi_Tiet.Tong_KL = myChuyen_Thu_Den_TH_tu_E2_Den.Tong_KL
                myChuyen_Thu_Den_Chi_Tiet.Tong_KLBP = myChuyen_Thu_Den_TH_tu_E2_Den.Tong_KLBP
                myChuyen_Thu_Den_Chi_Tiet.Tong_Cuoc_COD = myChuyen_Thu_Den_TH_tu_E2_Den.Tong_Cuoc_COD
                myChuyen_Thu_Den_Chi_Tiet.Tong_Cuoc_DV = myChuyen_Thu_Den_TH_tu_E2_Den.Tong_Cuoc_DV
                myChuyen_Thu_Den_Chi_Tiet.Tong_Cuoc = myChuyen_Thu_Den_TH_tu_E2_Den.Tong_Cuoc
                myChuyen_Thu_Den_Chi_Tiet.HH_Phat_Hanh = myChuyen_Thu_Den_TH_tu_E2_Den.HH_Phat_Hanh
                myChuyen_Thu_Den_Chi_Tiet.HH_Phat_Tra = myChuyen_Thu_Den_TH_tu_E2_Den.HH_Phat_Tra
                myChuyen_Thu_Den_Chi_Tiet.Dong_F = myChuyen_Thu_Den_TH_tu_E2_Den.Dong_F
                myChuyen_Thu_Den.Chuyen_Thu_Den_Cap_Nhat_Them_KT(myChuyen_Thu_Den_Chi_Tiet.Id_Chuyen_Thu, myChuyen_Thu_Den_Chi_Tiet.Id_Duong_Thu, myChuyen_Thu_Den_Chi_Tiet.Id_Ca, myChuyen_Thu_Den_Chi_Tiet.Ma_Bc_Khai_Thac, myChuyen_Thu_Den_Chi_Tiet.So_Chuyen_Thu, myChuyen_Thu_Den_Chi_Tiet.Ngay_Dong, myChuyen_Thu_Den_Chi_Tiet.Gio_Dong, myChuyen_Thu_Den_Chi_Tiet.Ngay_Nhan, myChuyen_Thu_Den_Chi_Tiet.Gio_Nhan, myChuyen_Thu_Den_Chi_Tiet.Tong_So_Tui, myChuyen_Thu_Den_Chi_Tiet.Tong_So_BP, myChuyen_Thu_Den_Chi_Tiet.Tong_KL, myChuyen_Thu_Den_Chi_Tiet.Tong_KLBP, myChuyen_Thu_Den_Chi_Tiet.Tong_Cuoc_COD, myChuyen_Thu_Den_Chi_Tiet.Tong_Cuoc_DV, myChuyen_Thu_Den_Chi_Tiet.Tong_Cuoc, myChuyen_Thu_Den_Chi_Tiet.HH_Phat_Hanh, myChuyen_Thu_Den_Chi_Tiet.HH_Phat_Tra, myChuyen_Thu_Den_Chi_Tiet.Dong_F, myChuyen_Thu_Den_Chi_Tiet.Truyen_Khai_Thac, myChuyen_Thu_Den_Chi_Tiet.Truyen_Doi_Soat, myChuyen_Thu_Den_Chi_Tiet.Chot_Sl)
            Else 'Nếu không tồn tại bản kê E2 nào -> Xóa chuyến thư
                myChuyen_Thu_Den.Xoa(Id_Chuyen_Thu)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#End Region

#Region "Tổng hợp thông tin thiết lập đi"

#Region "Tổng hợp E2_Di từ E1_Di"
    Private Sub Tong_Hop_E2_Di_tu_E1_Di(ByVal Id_E2 As String)
        Try
            'Lay_Chi_Tiet_E2_Di_tu_Id_E2(Id_E2)
            Dim myE2_Di_Chi_Tiet As New E2_Di_Chi_Tiet
            Dim myE2_Di_TH_E1_Di As New E2_Di_Chi_Tiet

            'Lấy dữ liệu chi tiết về bản kê E2
            myE2_Di_Chi_Tiet = myE2_Di.E2_Di_Chi_Tiet_Lay_Boi_Id_E2_KT(Id_E2)
            'Lấy dữ liệu tổng hợp về bản kê E2 từ các E1
            myE2_Di_TH_E1_Di = myE2_Di.E2_Di_Tong_Hop_Tu_E1_Di_KT(myE2_Di_Chi_Tiet.Id_E2)

            myE2_Di_Chi_Tiet.Tong_So_BP = myE2_Di_TH_E1_Di.Tong_So_BP

            If myE2_Di_Chi_Tiet.Tong_So_BP > 0 Then 'Cập nhật lại thông tin trên E2 nếu tổng số BP>0
                myE2_Di_Chi_Tiet.Tui_F = False
                myE2_Di_Chi_Tiet.Khoi_Luong_Vo_Tui = 340
                myE2_Di_Chi_Tiet.Khoi_Luong_BP = myE2_Di_TH_E1_Di.Khoi_Luong_BP
                myE2_Di_Chi_Tiet.Tong_Cuoc_COD = myE2_Di_TH_E1_Di.Tong_Cuoc_COD
                myE2_Di_Chi_Tiet.Tong_Cuoc_DV = myE2_Di_TH_E1_Di.Tong_Cuoc_DV
                myE2_Di_Chi_Tiet.Tong_Cuoc_Chinh = myE2_Di_TH_E1_Di.Tong_Cuoc_Chinh
                myE2_Di_Chi_Tiet.HH_Phat_Hanh = myE2_Di_TH_E1_Di.HH_Phat_Hanh
                myE2_Di_Chi_Tiet.HH_Phat_Tra = myE2_Di_TH_E1_Di.HH_Phat_Tra
                'Cập nhật dữ liệu vào bảng E2_Di
                myE2_Di.E2_Di_Cap_Nhat_Them_KT(myE2_Di_Chi_Tiet.Id_E2, _
                                                myE2_Di_Chi_Tiet.Id_Duong_Thu, _
                                                myE2_Di_Chi_Tiet.Id_Chuyen_Thu, _
                                                myE2_Di_Chi_Tiet.Id_Ca, _
                                                myE2_Di_Chi_Tiet.Ma_Bc_Khai_Thac, _
                                                myE2_Di_Chi_Tiet.Ngay_Dong, _
                                                myE2_Di_Chi_Tiet.Gio_Dong, _
                                                myE2_Di_Chi_Tiet.Ngay_Nhan, _
                                                myE2_Di_Chi_Tiet.Gio_Nhan, _
                                                myE2_Di_Chi_Tiet.Tui_So, _
                                                myE2_Di_Chi_Tiet.Tui_F, _
                                                myE2_Di_Chi_Tiet.Tong_So_BP, _
                                                myE2_Di_Chi_Tiet.Khoi_Luong_Vo_Tui, _
                                                myE2_Di_Chi_Tiet.Khoi_Luong_BP, _
                                                myE2_Di_Chi_Tiet.Tong_Cuoc_COD, _
                                                myE2_Di_Chi_Tiet.Tong_Cuoc_DV, _
                                                myE2_Di_Chi_Tiet.Tong_Cuoc_Chinh, _
                                                myE2_Di_Chi_Tiet.HH_Phat_Hanh, _
                                                myE2_Di_Chi_Tiet.HH_Phat_Tra, _
                                                myE2_Di_Chi_Tiet.Truyen_Khai_Thac, _
                                                myE2_Di_Chi_Tiet.Truyen_Doi_Soat, _
                                                myE2_Di_Chi_Tiet.Chot_SL)
            Else 'Nếu không tồn tại E1-> Xóa
                myE2_Di.Xoa(Id_E2)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
#End Region

#Region "Tổng hợp Chuyen_Thu_Di từ E2_Di"
    Private Sub Tong_Hop_Chuyen_Thu_Di_tu_E2_Di(ByVal Id_Chuyen_Thu As String)
        Try
            Dim myChuyen_Thu_Di_Chi_Tiet As New Chuyen_Thu_Di_Chi_Tiet
            Dim myChuyen_Thu_Di_TH_tu_E2_Di As New Chuyen_Thu_Di_Chi_Tiet
            Dim myChuyen_Thu_Di As New Chuyen_Thu_Di(GConnectionString)

            'Lấy dữ liệu chi tiết về chuyến thư
            myChuyen_Thu_Di_Chi_Tiet = myChuyen_Thu_Di.Chuyen_Thu_Di_Chi_Tiet_Lay_Boi_Id_Chuyen_Thu_KT(Id_Chuyen_Thu)
            'Lấy dữ liệu tổng hợp chuyến thư từ các chi tiết E2
            myChuyen_Thu_Di_TH_tu_E2_Di = myChuyen_Thu_Di.Chuyen_Thu_Di_Tong_Hop_Tu_E2_Di_KT(myChuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu)

            myChuyen_Thu_Di_Chi_Tiet.Tong_So_Tui = myChuyen_Thu_Di_TH_tu_E2_Di.Tong_So_Tui

            If myChuyen_Thu_Di_Chi_Tiet.Tong_So_Tui > 0 Then 'Nếu tồn tại it nhất 1 bản kê E2 Update lại thông tin trên Chuyến thư
                myChuyen_Thu_Di_Chi_Tiet.Tong_So_BP = myChuyen_Thu_Di_TH_tu_E2_Di.Tong_So_BP
                myChuyen_Thu_Di_Chi_Tiet.Tong_KL = myChuyen_Thu_Di_TH_tu_E2_Di.Tong_KL
                myChuyen_Thu_Di_Chi_Tiet.Tong_KLBP = myChuyen_Thu_Di_TH_tu_E2_Di.Tong_KLBP
                myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc_COD = myChuyen_Thu_Di_TH_tu_E2_Di.Tong_Cuoc_COD
                myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc_DV = myChuyen_Thu_Di_TH_tu_E2_Di.Tong_Cuoc_DV
                myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc = myChuyen_Thu_Di_TH_tu_E2_Di.Tong_Cuoc
                myChuyen_Thu_Di_Chi_Tiet.HH_Phat_Hanh = myChuyen_Thu_Di_TH_tu_E2_Di.HH_Phat_Hanh
                myChuyen_Thu_Di_Chi_Tiet.HH_Phat_Tra = myChuyen_Thu_Di_TH_tu_E2_Di.HH_Phat_Tra
                myChuyen_Thu_Di_Chi_Tiet.Dong_F = myChuyen_Thu_Di_TH_tu_E2_Di.Dong_F
                myChuyen_Thu_Di.Chuyen_Thu_Di_Cap_Nhat_Them_KT(myChuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Id_Duong_Thu, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Id_Ca, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Ma_Bc_Khai_Thac, _
                                                                myChuyen_Thu_Di_Chi_Tiet.So_Chuyen_Thu, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Ngay_Dong, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Gio_Dong, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Ngay_Nhan, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Gio_Nhan, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Tong_So_Tui, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Tong_So_BP, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Tong_KL, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Tong_KLBP, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc_COD, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc_DV, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc, _
                                                                myChuyen_Thu_Di_Chi_Tiet.HH_Phat_Hanh, _
                                                                myChuyen_Thu_Di_Chi_Tiet.HH_Phat_Tra, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Dong_F, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Truyen_Khai_Thac, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Truyen_Doi_Soat, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Chot_Sl)

            Else 'Nếu không tồn tại bản kê E2 nào -> Xóa chuyến thư
                myChuyen_Thu_Di.Xoa(Id_Chuyen_Thu)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
#End Region

#End Region

#Region "Lấy danh sách các chuyến thư túi số bị mất và thực hiện tổng hợp lại"
    Private Function Tong_Hop_Lai_Thong_Tin_Bi_Mat() As Boolean
        Try
            Dim mDs_Mat_Chuyen_Thu_Tui_So As New Ds_Mat_Chuyen_Thu_Tui_So(GConnectionString)
            Dim mSo_Ngay_Tong_Hop As Integer = 10
            Dim mDen_Ngay As Integer = myham_dung_chung.ConvertDateToInt(Now().Date)
            Dim mTu_Ngay As Integer = myham_dung_chung.MinusIntDate(mDen_Ngay, mSo_Ngay_Tong_Hop)
            Dim mTu_Ngay_Chuyen_Thu As Integer = myham_dung_chung.MinusIntDate(mTu_Ngay, 10)
            Dim myTable As DataTable
            Dim idx As Integer
            Dim curId_E2 As String
            Dim curId_Chuyen_Thu As String
            If MessageBox.Show("Xin vui lòng chờ trong một vài phút, chương trình sẽ tổng hợp lại thông tin chuyến thư & túi số", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.No Then
                Return True
                Exit Function
            End If
            PrbTienTrinh.Visible = True
            Me.ActiveForm.Cursor.Current = Cursors.WaitCursor
            'E2_Den & E2_Di
            'E2_Den
            myTable = myE2_Den.E2_Den_Danh_Sach_Bi_Mat_Id_Lay_Tu_E1_Den(mTu_Ngay, mDen_Ngay).Tables(0)
            'Process Bar
            PrbTienTrinh.Maximum = myTable.Rows.Count
            PrbTienTrinh.Step = 1
            PrbTienTrinh.Value = 0
            If myTable.Rows.Count > 0 Then
                For idx = 0 To myTable.Rows.Count - 1
                    'Process Values Next
                    PrbTienTrinh.PerformStep()
                    'Them moi E2_Den va Chuyen_Thu_Den
                    With myTable.Rows(idx)
                        curId_E2 = AddNew_E2_Den(.Item("Id_Duong_Thu"), .Item("So_Chuyen_Thu"), .Item("Tui_So"), .Item("Ngay_Dong"), .Item("Gio_Dong"), .Item("Ngay_Nhan"), .Item("Gio_Nhan"), .Item("Loai_CT"), .Item("Id_Ca"), .Item("Ma_Bc_Khai_Thac"))
                        curId_Chuyen_Thu = AddNew_Chuyen_Thu_Den(.Item("Id_Duong_Thu"), .Item("So_Chuyen_Thu"), .Item("Ngay_Dong"), .Item("Gio_Dong"), .Item("Ngay_Nhan"), .Item("Gio_Nhan"), .Item("Loai_CT"), .Item("Id_Ca"), .Item("Ma_Bc_Khai_Thac"))
                    End With
                    'Tong hop E2 theo E1, Chuyen_Thu theo E2
                    Tong_Hop_E2_Den_tu_E1_Den(curId_E2)
                    Tong_Hop_Chuyen_Thu_Den_tu_E2_Den(curId_Chuyen_Thu)
                    'THem vao bang Ds_Mat_Chuyen_Thu_Tui_So de quan ly
                    mDs_Mat_Chuyen_Thu_Tui_So.Ds_Mat_Chuyen_Thu_Tui_So_Them(curId_E2, "E2", 0, 0)
                    mDs_Mat_Chuyen_Thu_Tui_So.Ds_Mat_Chuyen_Thu_Tui_So_Them(curId_Chuyen_Thu, "CT", 0, 0)
                    'Thong tin
                    PrbTienTrinh.Text = "Tổng hợp E2 đến  ( " & PrbTienTrinh.Value & " / " & PrbTienTrinh.Maximum & " )"
                    PrbTienTrinh.Refresh()
                    Application.DoEvents()
                Next
            End If
            myTable.Clear()
            'E2_Di
            myTable = myE2_Di.E2_Di_Danh_Sach_Bi_Mat_Id_Lay_Tu_E1_Di(mTu_Ngay, mDen_Ngay).Tables(0)
            'Process Bar
            PrbTienTrinh.Maximum = myTable.Rows.Count
            PrbTienTrinh.Step = 1
            PrbTienTrinh.Value = 0
            If myTable.Rows.Count > 0 Then
                For idx = 0 To myTable.Rows.Count - 1
                    'Process Values Next
                    PrbTienTrinh.PerformStep()
                    'Them moi E2_Den va Chuyen_Thu_Den
                    With myTable.Rows(idx)
                        curId_E2 = AddNew_E2_Di(.Item("Id_Duong_Thu"), .Item("So_Chuyen_Thu"), .Item("Tui_So"), .Item("Ngay_Dong"), .Item("Gio_Dong"), .Item("Ngay_Nhan"), .Item("Gio_Nhan"), .Item("Loai_CT"), .Item("Id_Ca"), .Item("Ma_Bc_Khai_Thac"))
                        curId_Chuyen_Thu = AddNew_Chuyen_Thu_Di(.Item("Id_Duong_Thu"), .Item("So_Chuyen_Thu"), .Item("Ngay_Dong"), .Item("Gio_Dong"), .Item("Ngay_Nhan"), .Item("Gio_Nhan"), .Item("Loai_CT"), .Item("Id_Ca"), .Item("Ma_Bc_Khai_Thac"))
                    End With
                    'Tong hop E2 theo E1, Chuyen_Thu theo E2
                    Tong_Hop_E2_Di_tu_E1_Di(curId_E2)
                    Tong_Hop_Chuyen_Thu_Di_tu_E2_Di(curId_Chuyen_Thu)
                    'THem vao bang Ds_Mat_Chuyen_Thu_Tui_So de quan ly
                    mDs_Mat_Chuyen_Thu_Tui_So.Ds_Mat_Chuyen_Thu_Tui_So_Them(curId_E2, "E2", 0, 0)
                    mDs_Mat_Chuyen_Thu_Tui_So.Ds_Mat_Chuyen_Thu_Tui_So_Them(curId_Chuyen_Thu, "CT", 0, 0)
                    'Thong tin
                    PrbTienTrinh.Text = "Tổng hợp E2 đi  ( " & PrbTienTrinh.Value & " / " & PrbTienTrinh.Maximum & " )"
                    PrbTienTrinh.Refresh()
                    Application.DoEvents()
                Next
            End If
            myTable.Clear()
            'Chuyen_Thu_Den & Chuyen_Thu_Di        
            'Chuyen_Thu_Den
            myTable = myChuyen_Thu_Den.Chuyen_Thu_Den_Danh_Sach_Bi_Mat_Id_Lay_Tu_E2_Den(mTu_Ngay, mTu_Ngay_Chuyen_Thu, mDen_Ngay).Tables(0)
            'Process Bar
            PrbTienTrinh.Maximum = myTable.Rows.Count
            PrbTienTrinh.Step = 1
            PrbTienTrinh.Value = 0
            If myTable.Rows.Count > 0 Then
                For idx = 0 To myTable.Rows.Count - 1
                    'Process Values Next
                    PrbTienTrinh.PerformStep()
                    'Them moi Chuyen_Thu_Den
                    With myTable.Rows(idx)
                        curId_Chuyen_Thu = AddNew_Chuyen_Thu_Den(.Item("Id_Duong_Thu"), .Item("So_Chuyen_Thu"), .Item("Ngay_Dong"), .Item("Gio_Dong"), .Item("Ngay_Nhan"), .Item("Gio_Nhan"), .Item("Loai_CT"), .Item("Id_Ca"), .Item("Ma_Bc_Khai_Thac"))
                    End With
                    'Tong hop Chuyen_Thu theo E2
                    Tong_Hop_Chuyen_Thu_Den_tu_E2_Den(curId_Chuyen_Thu)
                    'Them vao bang Ds_Mat_Chuyen_Thu_Tui_So de quan ly
                    mDs_Mat_Chuyen_Thu_Tui_So.Ds_Mat_Chuyen_Thu_Tui_So_Them(curId_Chuyen_Thu, "CT", 0, 0)
                    'Thong tin
                    PrbTienTrinh.Text = "Tổng hợp chuyến thư đến  ( " & PrbTienTrinh.Value & " / " & PrbTienTrinh.Maximum & " )"
                    PrbTienTrinh.Refresh()
                    Application.DoEvents()
                Next
            End If
            myTable.Clear()
            'Chuyen_Thu_Di
            myTable = myChuyen_Thu_Di.Chuyen_Thu_Di_Danh_Sach_Bi_Mat_Id_Lay_Tu_E2_Di(mTu_Ngay, mDen_Ngay).Tables(0)
            'Process Bar
            PrbTienTrinh.Maximum = myTable.Rows.Count
            PrbTienTrinh.Step = 1
            PrbTienTrinh.Value = 0
            If myTable.Rows.Count > 0 Then
                For idx = 0 To myTable.Rows.Count - 1
                    'Process Values Next
                    PrbTienTrinh.PerformStep()
                    'Them moi Chuyen_Thu_Den
                    With myTable.Rows(idx)
                        curId_Chuyen_Thu = AddNew_Chuyen_Thu_Di(.Item("Id_Duong_Thu"), .Item("So_Chuyen_Thu"), .Item("Ngay_Dong"), .Item("Gio_Dong"), .Item("Ngay_Nhan"), .Item("Gio_Nhan"), .Item("Loai_CT"), .Item("Id_Ca"), .Item("Ma_Bc_Khai_Thac"))
                    End With
                    'Tong hop Chuyen_Thu theo E2
                    Tong_Hop_Chuyen_Thu_Di_tu_E2_Di(curId_Chuyen_Thu)
                    'Them vao bang Ds_Mat_Chuyen_Thu_Tui_So de quan ly
                    mDs_Mat_Chuyen_Thu_Tui_So.Ds_Mat_Chuyen_Thu_Tui_So_Them(curId_Chuyen_Thu, "CT", 0, 0)
                    'Thong tin
                    PrbTienTrinh.Text = "Tổng hợp chuyến thư đi  ( " & PrbTienTrinh.Value & " / " & PrbTienTrinh.Maximum & " )"
                    PrbTienTrinh.Refresh()
                    Application.DoEvents()
                Next
            End If
            Me.ActiveForm.Cursor.Current = Cursors.Default
            PrbTienTrinh.Visible = False
            'Thong bao ket thuc
            MessageBox.Show("Đã thực hiện xong.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function

#End Region

#End Region

End Class
#End Region

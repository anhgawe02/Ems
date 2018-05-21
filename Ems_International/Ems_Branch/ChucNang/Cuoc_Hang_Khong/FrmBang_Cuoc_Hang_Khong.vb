Imports System
Imports ADODB
Imports System.IO
Imports System.Windows.Forms
Imports System.Data.OleDb
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Ems_International_Logic.EMS

Public Class FrmBang_Cuoc_Hang_Khong
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
    Friend WithEvents TabDanh_Muc As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ddSan_Bay As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddHVC As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents Nhap_Cuoc As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents dgBang_Cuoc As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgHVC As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents lblInfo_HVC As System.Windows.Forms.Label
    Friend WithEvents lblInfo_Cuoc As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("San_Bay", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_San_Bay")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Accounting_Bang_Cuoc_Hang_Khong", -1)
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Cuoc_Hang_Khong")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HVC")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("San_Bay_Xuat_Phat")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("San_Bay_Den")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Tui_Rong")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_He_Thong")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_He_Thong")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("HVC", -1)
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HVC")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Accounting_Danh_Sach_HVC", -1)
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HVC")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_HVC")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ghi_Chu", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.lblInfo_Cuoc = New System.Windows.Forms.Label
        Me.Nhap_Cuoc = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Me.ddSan_Bay = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.dgBang_Cuoc = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.lblInfo_HVC = New System.Windows.Forms.Label
        Me.ddHVC = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.dgHVC = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.TabDanh_Muc = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.Nhap_Cuoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddSan_Bay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgBang_Cuoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.ddHVC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgHVC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabDanh_Muc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabDanh_Muc.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.lblInfo_Cuoc)
        Me.UltraTabPageControl1.Controls.Add(Me.Nhap_Cuoc)
        Me.UltraTabPageControl1.Controls.Add(Me.ddSan_Bay)
        Me.UltraTabPageControl1.Controls.Add(Me.dgBang_Cuoc)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(606, 621)
        '
        'lblInfo_Cuoc
        '
        Me.lblInfo_Cuoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo_Cuoc.Location = New System.Drawing.Point(480, 4)
        Me.lblInfo_Cuoc.Name = "lblInfo_Cuoc"
        Me.lblInfo_Cuoc.Size = New System.Drawing.Size(100, 18)
        Me.lblInfo_Cuoc.TabIndex = 9
        Me.lblInfo_Cuoc.Text = "Tổng số:   0"
        '
        'Nhap_Cuoc
        '
        Me.Nhap_Cuoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nhap_Cuoc.Location = New System.Drawing.Point(216, 152)
        Me.Nhap_Cuoc.MaskInput = "nn.nnn"
        Me.Nhap_Cuoc.Name = "Nhap_Cuoc"
        Me.Nhap_Cuoc.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double
        Me.Nhap_Cuoc.Size = New System.Drawing.Size(104, 26)
        Me.Nhap_Cuoc.TabIndex = 7
        Me.Nhap_Cuoc.Visible = False
        '
        'ddSan_Bay
        '
        Me.ddSan_Bay.Cursor = System.Windows.Forms.Cursors.Default
        Appearance1.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddSan_Bay.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.Caption = "Mã sân bay"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1})
        UltraGridBand1.UseRowLayout = True
        Me.ddSan_Bay.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance2.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.ForeColor = System.Drawing.Color.Black
        Appearance2.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddSan_Bay.DisplayLayout.Override.HeaderAppearance = Appearance2
        Me.ddSan_Bay.DisplayMember = ""
        Me.ddSan_Bay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddSan_Bay.Location = New System.Drawing.Point(272, 216)
        Me.ddSan_Bay.Name = "ddSan_Bay"
        Me.ddSan_Bay.Size = New System.Drawing.Size(152, 328)
        Me.ddSan_Bay.TabIndex = 6
        Me.ddSan_Bay.ValueMember = ""
        Me.ddSan_Bay.Visible = False
        '
        'dgBang_Cuoc
        '
        Me.dgBang_Cuoc.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgBang_Cuoc.DisplayLayout.AddNewBox.Prompt = " "
        Appearance3.BackColor = System.Drawing.Color.White
        Appearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgBang_Cuoc.DisplayLayout.Appearance = Appearance3
        UltraGridColumn2.Header.VisiblePosition = 0
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 1
        UltraGridColumn3.Hidden = True
        UltraGridColumn3.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn3.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(115, 0)
        UltraGridColumn3.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn3.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn4.Header.Caption = "Điểm xuất phát"
        UltraGridColumn4.Header.VisiblePosition = 2
        UltraGridColumn4.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn4.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(147, 0)
        UltraGridColumn4.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn4.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn5.Header.Caption = "Điểm đến"
        UltraGridColumn5.Header.VisiblePosition = 3
        UltraGridColumn5.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn5.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn5.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(189, 0)
        UltraGridColumn5.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn5.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn6.Header.Caption = "Đơn giá  cước"
        UltraGridColumn6.Header.VisiblePosition = 4
        UltraGridColumn6.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn6.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(163, 0)
        UltraGridColumn6.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn6.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn7.Header.Caption = "Cước túi rỗng"
        UltraGridColumn7.Header.VisiblePosition = 5
        UltraGridColumn7.Hidden = True
        UltraGridColumn7.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn7.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn7.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn7.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn8.Header.VisiblePosition = 6
        UltraGridColumn8.Hidden = True
        UltraGridColumn8.RowLayoutColumnInfo.OriginX = 26
        UltraGridColumn8.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn8.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn8.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn9.Header.VisiblePosition = 7
        UltraGridColumn9.Hidden = True
        UltraGridColumn9.RowLayoutColumnInfo.OriginX = 28
        UltraGridColumn9.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn9.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn9.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9})
        UltraGridBand2.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand2.UseRowLayout = True
        Me.dgBang_Cuoc.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.dgBang_Cuoc.DisplayLayout.InterBandSpacing = 10
        Me.dgBang_Cuoc.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Me.dgBang_Cuoc.DisplayLayout.Override.CardAreaAppearance = Appearance4
        Me.dgBang_Cuoc.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance5.ForeColor = System.Drawing.Color.Black
        Appearance5.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance5.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgBang_Cuoc.DisplayLayout.Override.HeaderAppearance = Appearance5
        Me.dgBang_Cuoc.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance6.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgBang_Cuoc.DisplayLayout.Override.RowAppearance = Appearance6
        Appearance7.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance7.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgBang_Cuoc.DisplayLayout.Override.RowSelectorAppearance = Appearance7
        Me.dgBang_Cuoc.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgBang_Cuoc.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance8.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance8.ForeColor = System.Drawing.Color.Black
        Me.dgBang_Cuoc.DisplayLayout.Override.SelectedRowAppearance = Appearance8
        Me.dgBang_Cuoc.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgBang_Cuoc.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgBang_Cuoc.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgBang_Cuoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgBang_Cuoc.Location = New System.Drawing.Point(0, 0)
        Me.dgBang_Cuoc.Name = "dgBang_Cuoc"
        Me.dgBang_Cuoc.Size = New System.Drawing.Size(606, 624)
        Me.dgBang_Cuoc.TabIndex = 5
        Me.dgBang_Cuoc.Text = "Chi tiết bảng cước hàng không"
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.lblInfo_HVC)
        Me.UltraTabPageControl5.Controls.Add(Me.ddHVC)
        Me.UltraTabPageControl5.Controls.Add(Me.dgHVC)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(606, 621)
        '
        'lblInfo_HVC
        '
        Me.lblInfo_HVC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo_HVC.Location = New System.Drawing.Point(472, 5)
        Me.lblInfo_HVC.Name = "lblInfo_HVC"
        Me.lblInfo_HVC.Size = New System.Drawing.Size(100, 18)
        Me.lblInfo_HVC.TabIndex = 8
        Me.lblInfo_HVC.Text = "Tổng số:   0"
        '
        'ddHVC
        '
        Me.ddHVC.Cursor = System.Windows.Forms.Cursors.SizeNS
        Appearance9.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddHVC.DisplayLayout.Appearance = Appearance9
        UltraGridColumn10.Header.VisiblePosition = 0
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn10})
        UltraGridBand3.UseRowLayout = True
        Me.ddHVC.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Appearance10.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance10.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance10.ForeColor = System.Drawing.Color.Black
        Appearance10.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddHVC.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.ddHVC.DisplayMember = ""
        Me.ddHVC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddHVC.Location = New System.Drawing.Point(240, 152)
        Me.ddHVC.Name = "ddHVC"
        Me.ddHVC.Size = New System.Drawing.Size(144, 384)
        Me.ddHVC.TabIndex = 7
        Me.ddHVC.Text = "Danh sách HVC"
        Me.ddHVC.ValueMember = ""
        Me.ddHVC.Visible = False
        '
        'dgHVC
        '
        Me.dgHVC.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgHVC.DisplayLayout.AddNewBox.Prompt = " "
        Appearance11.BackColor = System.Drawing.Color.White
        Appearance11.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgHVC.DisplayLayout.Appearance = Appearance11
        UltraGridColumn11.Header.VisiblePosition = 0
        UltraGridColumn11.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn11.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn11.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(88, 0)
        UltraGridColumn11.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn11.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn12.Header.VisiblePosition = 1
        UltraGridColumn12.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn12.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn12.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(246, 0)
        UltraGridColumn12.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn12.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn13.Header.Caption = "Ghi chú"
        UltraGridColumn13.Header.VisiblePosition = 2
        UltraGridColumn13.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn13.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn13.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(193, 0)
        UltraGridColumn13.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn13.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn11, UltraGridColumn12, UltraGridColumn13})
        UltraGridBand4.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand4.UseRowLayout = True
        Me.dgHVC.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.dgHVC.DisplayLayout.InterBandSpacing = 10
        Me.dgHVC.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Me.dgHVC.DisplayLayout.Override.CardAreaAppearance = Appearance12
        Me.dgHVC.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance13.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance13.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance13.ForeColor = System.Drawing.Color.Black
        Appearance13.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance13.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgHVC.DisplayLayout.Override.HeaderAppearance = Appearance13
        Me.dgHVC.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance14.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgHVC.DisplayLayout.Override.RowAppearance = Appearance14
        Appearance15.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance15.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgHVC.DisplayLayout.Override.RowSelectorAppearance = Appearance15
        Me.dgHVC.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgHVC.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance16.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance16.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance16.ForeColor = System.Drawing.Color.Black
        Me.dgHVC.DisplayLayout.Override.SelectedRowAppearance = Appearance16
        Me.dgHVC.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgHVC.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgHVC.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgHVC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgHVC.Location = New System.Drawing.Point(0, 0)
        Me.dgHVC.Name = "dgHVC"
        Me.dgHVC.Size = New System.Drawing.Size(606, 624)
        Me.dgHVC.TabIndex = 6
        Me.dgHVC.Text = "Danh sách Hãng vận chuyển"
        '
        'TabDanh_Muc
        '
        Me.TabDanh_Muc.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.TabDanh_Muc.Controls.Add(Me.UltraTabPageControl1)
        Me.TabDanh_Muc.Controls.Add(Me.UltraTabPageControl5)
        Me.TabDanh_Muc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabDanh_Muc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabDanh_Muc.Location = New System.Drawing.Point(0, 0)
        Me.TabDanh_Muc.Name = "TabDanh_Muc"
        Me.TabDanh_Muc.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.TabDanh_Muc.Size = New System.Drawing.Size(608, 645)
        Me.TabDanh_Muc.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.VisualStudio2005
        Me.TabDanh_Muc.TabIndex = 3
        Me.TabDanh_Muc.TabLayoutStyle = Infragistics.Win.UltraWinTabs.TabLayoutStyle.SingleRowSizeToFit
        Me.TabDanh_Muc.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.TopLeft
        Me.TabDanh_Muc.TabPadding = New System.Drawing.Size(10, 2)
        UltraTab1.Key = "Accounting_Bang_Cuoc_Hang_Khong"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Bảng cước Hàng không"
        UltraTab2.Key = "Accounting_Danh_Sach_HVC"
        UltraTab2.TabPage = Me.UltraTabPageControl5
        UltraTab2.Text = "Danh mục Hãng vận chuyển"
        Me.TabDanh_Muc.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.TabDanh_Muc.TabsPerRow = 5
        Me.TabDanh_Muc.TextOrientation = Infragistics.Win.UltraWinTabs.TextOrientation.Horizontal
        Me.TabDanh_Muc.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2003
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(606, 621)
        '
        'FrmBang_Cuoc_Hang_Khong
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(608, 645)
        Me.Controls.Add(Me.TabDanh_Muc)
        Me.Name = "FrmBang_Cuoc_Hang_Khong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cập nhật Danh mục HVC và bảng cước hàng không"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.Nhap_Cuoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddSan_Bay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgBang_Cuoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.ddHVC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgHVC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabDanh_Muc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabDanh_Muc.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Khai báo biến toàn Form"
    Dim myAccounting_Cuoc_Hang_Khong As New Accounting_Bang_Cuoc_Hang_Khong(GConnectionString)
    Dim myAccounting_Danh_Sach_HVC As New Accounting_Danh_Sach_HVC(GConnectionString)
    Dim i As Integer
    Dim myColumn As Infragistics.Win.UltraWinGrid.UltraGridColumn = Nothing
    Dim myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Dim myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Dim myNextCell As Boolean
    Dim myNextRow As Boolean
    Dim myCellActive As Infragistics.Win.UltraWinGrid.UltraGridCell
    Dim myIsFirst As Boolean = True
#End Region

#Region "FrmBang_Cuoc_Hang_Khong_Load"
    Private Sub FrmBang_Cuoc_Hang_Khong_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dropdown_San_Bay()
            Dropdown_HVC()
            DataGrid_Bang_Cuoc()
            DataGrid_Danh_Sach_HVC()
            TabDanh_Muc.SelectedTab = TabDanh_Muc.Tabs("Accounting_Bang_Cuoc_Hang_Khong")
            Refresh_StatusBar("Accounting_Bang_Cuoc_Hang_Khong")
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "TabDanh_Muc_SelectedTabChanged"
    Private Sub TabDanh_Muc_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles TabDanh_Muc.SelectedTabChanged
        If myIsFirst Then
            myIsFirst = False
            Exit Sub
        End If
        Me.Tag = e.Tab.Key
        'DataGrid_Danh_Muc(Me.Tag)
        Refresh_StatusBar(Me.Tag)
    End Sub
#End Region

#Region "---------------dgHVC------------------"
#Region "dgHVC_InitializeLayout"
    Private Sub dgHVC_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgHVC.InitializeLayout
        Try
            myGridKeyDown = sender
            myGridKeyDown.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
            myGridKeyDown.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
            myGridKeyDown.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
            myGridKeyDown.DisplayLayout.Bands(0).Columns("HVC").ValueList = ddHVC

            myNextCell = True
            myNextRow = True
            myCellActive = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "dgHVC_InitializeTemplateAddRow"
    Private Sub dgHVC_InitializeTemplateAddRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeTemplateAddRowEventArgs) Handles dgHVC.InitializeTemplateAddRow
        myGridKeyDown = sender
        With myGridKeyDown.DisplayLayout.Bands(0)
            .Columns("Ghi_Chu").DefaultCellValue = ""
        End With
    End Sub
#End Region
#Region "dgHVC_AfterExitEditMode"
    Private Sub dgHVC_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgHVC.AfterExitEditMode
        Try
            myGridKeyDown = sender
            If myNextCell = False Then
                Exit Sub
            End If
            'Nếu là dòng rỗng thì không kiểm tra
            If myGridKeyDown.ActiveRow.Cells("HVC").Text = "" And myGridKeyDown.ActiveRow.Cells("Ten_HVC").Text = "" Then
                Exit Sub
            End If
            myNextCell = True
            Select Case myGridKeyDown.ActiveCell.Column.Key
                Case "HVC"
                    If myGridKeyDown.ActiveCell.Text.Trim = "" Then
                        MessageBox.Show("Mã HVC không được để trống!!!", "Lỗi cập nhật danh mục hãng vận chuyển", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        myNextCell = False
                        Exit Sub
                    End If
                    myGridKeyDown.ActiveCell.Value = myGridKeyDown.ActiveCell.Text.ToUpper()
                    ''Nhap moi
                    'If myGridKeyDown.ActiveRow.Cells("HVC").Text.Trim = "" And myGridKeyDown.ActiveRow.Cells("Ten_HVC").Text = "" Then
                    '    If myAccounting_Danh_Sach_HVC.Accounting_Danh_Sach_HVC_Lay(myGridKeyDown.ActiveCell.Text.Trim).Ten_HVC <> "" Then
                    '        MessageBox.Show("Mã HVC này đã tồn tại rồi, bạn không được phép nhập thêm!!!", "Lỗi cập nhật danh mục hãng vận chuyển", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    '        myNextCell = False
                    '        Exit Sub
                    '    End If
                    'End If
                Case "Ten_HVC"
                    If myGridKeyDown.ActiveCell.Text.Trim = "" Then
                        MessageBox.Show("Tên HVC không được để trống!!!", "Lỗi cập nhật danh mục hãng vận chuyển", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        myNextCell = False
                        Exit Sub
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "dgHVC_AfterCellUpdate"
    Private Sub dgHVC_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgHVC.AfterCellUpdate
        Try
            myGridKeyDown = sender
            If myGridKeyDown.ActiveRow.Cells("HVC").Text <> "" And myGridKeyDown.ActiveRow.Cells("Ten_HVC").Text <> "" Then
                AddNewRow(myGridKeyDown)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "dgHVC_BeforeCellUpdate"
    Private Sub dgHVC_BeforeCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles dgHVC.BeforeCellUpdate
        Try
            myGridKeyDown = sender
            myNextCell = True
            If myGridKeyDown.ActiveCell.Column.Key = "HVC" Then
                'Sửa mã HVC đã tồn tại
                If Not e.Cell.Value Is DBNull.Value Then
                    If myAccounting_Danh_Sach_HVC.Accounting_Danh_Sach_HVC_Lay(e.Cell.Value).Ten_HVC <> "" Then
                        MessageBox.Show("Mã HVC này đã được ghi vào cơ sở dữ liệu, vì vậy bạn không được phép sửa mã HVC." & vbNewLine & "Hãy xóa đi và thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        e.Cancel = True
                        myNextCell = False
                        Exit Sub
                    End If
                End If
                'Kiểm tra khi nhập mới
                Dim mHVC As String = e.NewValue
                If myAccounting_Danh_Sach_HVC.Accounting_Danh_Sach_HVC_Lay(mHVC.Trim).Ten_HVC <> "" Then
                    MessageBox.Show("Mã HVC này đã tồn tại rồi, bạn không được phép nhập thêm!!!", "Lỗi cập nhật danh mục hãng vận chuyển", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    e.Cancel = True
                    myNextCell = False
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "dgHVC_AfterRowUpdate"
    Private Sub dgHVC_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgHVC.AfterRowUpdate
        Try
            myGridKeyDown = sender
            myNextRow = True
            'HVC
            If myGridKeyDown.ActiveRow.Cells("HVC").Text.Trim = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu!!!" & vbNewLine & "Chú ý: Mã HVC không được để trống.", " Lỗi cập nhật Danh mục Hãng vận chuyển ")
                'myGridKeyDown.ActiveCell = myGridKeyDown.ActiveRow.Cells("Ma_Hang_Hoa")
                'myGridKeyDown.PerformAction(EnterEditMode, False, False)
                myNextRow = False
                myCellActive = myGridKeyDown.ActiveRow.Cells("HVC")
                Exit Sub
            End If
            'HVC
            If myGridKeyDown.ActiveRow.Cells("Ten_HVC").Text.Trim = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu!!!" & vbNewLine & "Chú ý: Tên Hãng vận chuyển không được để trống.", " Lỗi cập nhật Danh mục Hãng vận chuyển ")
                'myGridKeyDown.ActiveCell = myGridKeyDown.ActiveRow.Cells("Ma_Hang_Hoa")
                'myGridKeyDown.PerformAction(EnterEditMode, False, False)
                myNextRow = False
                myCellActive = myGridKeyDown.ActiveRow.Cells("Ten_HVC")
                Exit Sub
            End If
            myAccounting_Danh_Sach_HVC.Accounting_Danh_Sach_HVC_Cap_Nhat_Them(myGridKeyDown.ActiveRow.Cells("HVC").Text, _
                                                                            myGridKeyDown.ActiveRow.Cells("Ten_HVC").Text, _
                                                                            myGridKeyDown.ActiveRow.Cells("Ghi_Chu").Text)
            Refresh_StatusBar(Me.Tag)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#End Region

#Region "---------------dgBang_Cuoc------------------"
#Region "dgBang_Cuoc_InitializeLayout"
    Private Sub dgBang_Cuoc_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgBang_Cuoc.InitializeLayout
        Try
            myGridKeyDown = sender
            myGridKeyDown.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
            myGridKeyDown.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
            myGridKeyDown.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
            myGridKeyDown.DisplayLayout.Bands(0).Columns("San_Bay_Xuat_Phat").ValueList = ddSan_Bay
            myGridKeyDown.DisplayLayout.Bands(0).Columns("San_Bay_Den").ValueList = ddSan_Bay

            myGridKeyDown.DisplayLayout.Bands(0).Columns("Cuoc").EditorControl = Nhap_Cuoc
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Cuoc").Format = "#0.##0"
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Cuoc").CellAppearance.TextHAlign = HAlign.Right

            myGridKeyDown.DisplayLayout.Bands(0).Columns("Cuoc_Tui_Rong").EditorControl = Nhap_Cuoc
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Cuoc_Tui_Rong").Format = "##.##0"
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Cuoc_Tui_Rong").CellAppearance.TextHAlign = HAlign.Right

            myNextCell = True
            myNextRow = True
            myCellActive = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "dgBang_Cuoc_InitializeTemplateAddRow"
    Private Sub dgBang_Cuoc_InitializeTemplateAddRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeTemplateAddRowEventArgs) Handles dgBang_Cuoc.InitializeTemplateAddRow
        Try
            myGridKeyDown = sender
            With myGridKeyDown.DisplayLayout.Bands(0)
                .Columns("Id_Cuoc_Hang_Khong").DefaultCellValue = ""
                .Columns("HVC").DefaultCellValue = ""
                .Columns("Cuoc_Tui_Rong").DefaultCellValue = 0.0
                .Columns("Ngay_He_Thong").DefaultCellValue = 0
                .Columns("Gio_He_Thong").DefaultCellValue = 0
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "dgBang_Cuoc_AfterExitEditMode"
    Private Sub dgBang_Cuoc_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgBang_Cuoc.AfterExitEditMode
        Try
            myGridKeyDown = sender
            If myNextCell = False Then
                Exit Sub
            End If
            'Nếu là dòng rỗng thì không kiểm tra
            If myGridKeyDown.ActiveRow.Cells("San_Bay_Xuat_Phat").Text = "" And myGridKeyDown.ActiveRow.Cells("San_Bay_Den").Text = "" And myGridKeyDown.ActiveRow.Cells("Cuoc").Value Is DBNull.Value Then
                Exit Sub
            End If
            myNextCell = True
            Select Case myGridKeyDown.ActiveCell.Column.Key
                Case "San_Bay_Xuat_Phat"
                    If myGridKeyDown.ActiveCell.Text.Trim = "" Then
                        MessageBox.Show("Điểm xuất phát không được để trống!!!", "Lỗi cập nhật bảng cước hàng không", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        myNextCell = False
                        Exit Sub
                    End If
                    myGridKeyDown.ActiveCell.Value = myGridKeyDown.ActiveCell.Text.ToUpper()
                    ''Nhap moi
                    'If myGridKeyDown.ActiveRow.Cells("HVC").Text.Trim = "" And myGridKeyDown.ActiveRow.Cells("Ten_HVC").Text = "" Then
                    '    If myAccounting_Danh_Sach_HVC.Accounting_Danh_Sach_HVC_Lay(myGridKeyDown.ActiveCell.Text.Trim).Ten_HVC <> "" Then
                    '        MessageBox.Show("Mã HVC này đã tồn tại rồi, bạn không được phép nhập thêm!!!", "Lỗi cập nhật danh mục hãng vận chuyển", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    '        myNextCell = False
                    '        Exit Sub
                    '    End If
                    'End If
                Case "San_Bay_Den"
                    If myGridKeyDown.ActiveCell.Text.Trim = "" Then
                        MessageBox.Show("Điểm đến không được để trống!!!", "Lỗi cập nhật bảng cước hàng không", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        myNextCell = False
                        Exit Sub
                    End If
                    myGridKeyDown.ActiveCell.Value = myGridKeyDown.ActiveCell.Text.ToUpper()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "dgBang_Cuoc_AfterCellUpdate"
    Private Sub dgBang_Cuoc_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgBang_Cuoc.AfterCellUpdate
        Try
            myGridKeyDown = sender
            If myGridKeyDown.ActiveRow.Cells("San_Bay_Xuat_Phat").Text <> "" And myGridKeyDown.ActiveRow.Cells("San_Bay_Den").Text <> "" Then
                AddNewRow(myGridKeyDown)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "dgBang_Cuoc_BeforeCellUpdate"
    Private Sub dgBang_Cuoc_BeforeCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles dgBang_Cuoc.BeforeCellUpdate
        Try
            Dim mId_Cuoc As String
            myGridKeyDown = sender
            myNextCell = True
            If myGridKeyDown.ActiveCell.Column.Key = "San_Bay_Den" Then
                'Sửa mã HVC đã tồn tại
                If Not e.Cell.Value Is DBNull.Value Then
                    mId_Cuoc = Tao_Id_Bang_Cuoc_Hang_Khong(myGridKeyDown.ActiveRow.Cells("San_Bay_Xuat_Phat").Text, e.Cell.Value)
                    If myAccounting_Cuoc_Hang_Khong.Accounting_Bang_Cuoc_Hang_Khong_Lay(mId_Cuoc).San_Bay_Den <> "" Then
                        MessageBox.Show("Chặng bay này đã được ghi vào cơ sở dữ liệu, vì vậy bạn chỉ được phép sửa cước." & vbNewLine & "Hãy xóa đi và thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        e.Cancel = True
                        myNextCell = False
                        Exit Sub
                    End If
                End If
                'Kiểm tra khi nhập mới
                Dim mSan_Bay_Den As String = e.NewValue
                mId_Cuoc = Tao_Id_Bang_Cuoc_Hang_Khong(myGridKeyDown.ActiveRow.Cells("San_Bay_Xuat_Phat").Text, mSan_Bay_Den)
                If myAccounting_Cuoc_Hang_Khong.Accounting_Bang_Cuoc_Hang_Khong_Lay(mId_Cuoc.Trim).San_Bay_Den <> "" Then
                    MessageBox.Show("Chặng bay này đã tồn tại rồi, bạn không được phép nhập thêm!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    e.Cancel = True
                    myNextCell = False
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "dgBang_Cuoc_AfterRowUpdate"
    Private Sub dgBang_Cuoc_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgBang_Cuoc.AfterRowUpdate
        Try
            myGridKeyDown = sender
            myNextRow = True
            'San_Bay_Xuat_Phat
            If myGridKeyDown.ActiveRow.Cells("San_Bay_Xuat_Phat").Text.Trim = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu!!!" & vbNewLine & "Chú ý: Điểm xuất phát không được để trống.", " Lỗi cập nhật Bảng cước hàng không ")
                'myGridKeyDown.ActiveCell = myGridKeyDown.ActiveRow.Cells("Ma_Hang_Hoa")
                'myGridKeyDown.PerformAction(EnterEditMode, False, False)
                myNextRow = False
                myCellActive = myGridKeyDown.ActiveRow.Cells("San_Bay_Xuat_Phat")
                Exit Sub
            End If
            'San_Bay_Den
            If myGridKeyDown.ActiveRow.Cells("San_Bay_Den").Text.Trim = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu!!!" & vbNewLine & "Chú ý: Điểm đến không được để trống.", " Lỗi cập nhật Bảng cước hàng không ")
                'myGridKeyDown.ActiveCell = myGridKeyDown.ActiveRow.Cells("Ma_Hang_Hoa")
                'myGridKeyDown.PerformAction(EnterEditMode, False, False)
                myNextRow = False
                myCellActive = myGridKeyDown.ActiveRow.Cells("San_Bay_Den")
                Exit Sub
            End If
            'Cuoc
            If Not IsNumeric(myGridKeyDown.ActiveRow.Cells("Cuoc").Value) Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu!!!" & vbNewLine & "Chú ý: Cước phải là một số.", " Lỗi cập nhật Bảng cước hàng không ")
                'myGridKeyDown.ActiveCell = myGridKeyDown.ActiveRow.Cells("Ma_Hang_Hoa")
                'myGridKeyDown.PerformAction(EnterEditMode, False, False)
                myNextRow = False
                myCellActive = myGridKeyDown.ActiveRow.Cells("Cuoc")
                Exit Sub
            End If
            Dim mId_Cuoc As String = Tao_Id_Bang_Cuoc_Hang_Khong(myGridKeyDown.ActiveRow.Cells("San_Bay_Xuat_Phat").Text, myGridKeyDown.ActiveRow.Cells("San_Bay_Den").Text)
            myAccounting_Cuoc_Hang_Khong.Accounting_Bang_Cuoc_Hang_Khong_Cap_Nhat_Them(mId_Cuoc, _
                                                                            myGridKeyDown.ActiveRow.Cells("HVC").Text, _
                                                                            myGridKeyDown.ActiveRow.Cells("San_Bay_Xuat_Phat").Text, _
                                                                            myGridKeyDown.ActiveRow.Cells("San_Bay_Den").Text, _
                                                                            myGridKeyDown.ActiveRow.Cells("Cuoc").Value, _
                                                                            myGridKeyDown.ActiveRow.Cells("Cuoc_Tui_Rong").Value, _
                                                                            myGridKeyDown.ActiveRow.Cells("Ngay_He_Thong").Value, _
                                                                            myGridKeyDown.ActiveRow.Cells("Gio_He_Thong").Value)

            Refresh_StatusBar(Me.Tag)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#End Region

#Region "Grid_KeyDown"
    Private Sub dgHVC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgHVC.KeyDown, dgBang_Cuoc.KeyDown
        Try
            myGridKeyDown = sender
            If myGridKeyDown.ActiveCell Is Nothing Then
                Exit Sub
            End If
            Select Case e.KeyValue
                Case Keys.Enter, Keys.Tab
                    'Kiem tra Cell co Value = Null, khong cho next cell
                    Select Case myGridKeyDown.Name
                        Case "dgBang_Cuoc"
                            If ((myGridKeyDown.ActiveCell.Text = "") And (myGridKeyDown.ActiveCell.Column.Key = "San_Bay_Xuat_Phat" Or myGridKeyDown.ActiveCell.Column.Key = "San_Bay_Den")) Then
                                e.Handled = True
                                myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                                myCell = Nothing
                                Exit Sub
                            End If
                            'If myGridKeyDown.ActiveCell.Column.Key = "Cuoc" And Not IsNumeric(myGridKeyDown.ActiveCell.Value) Then
                            '    e.Handled = True
                            '    myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                            '    myCell = Nothing
                            '    Exit Sub
                            'End If
                        Case "dgHVC"
                            If ((myGridKeyDown.ActiveCell.Text = "") And (myGridKeyDown.ActiveCell.Column.Key = "HVC" Or myGridKeyDown.ActiveCell.Column.Key = "Ten_HVC")) Then
                                e.Handled = True
                                myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                                myCell = Nothing
                                Exit Sub
                            End If
                    End Select
                    'Lay index cua Cell dang Active
                    myCell = myGridKeyDown.ActiveCell
                    'Thoat khoi Cell
                    myGridKeyDown.PerformAction(ExitEditMode, False, False)
                    'Kiem tra neu co van de thi khong cho Next Cell
                    If Not myNextCell Then
                        myGridKeyDown.ActiveCell = myCell
                        e.Handled = True
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                        myNextCell = True
                        Exit Sub
                    End If
                    'Next cell
                    myGridKeyDown.PerformAction(NextCellByTab, False, False)
                    e.Handled = True
                    'Kiem tra neu RowUpdate có vấn đề thì quay trở lại row đang active
                    If Not myNextRow Then
                        myGridKeyDown.ActiveCell = myCellActive
                        myCellActive = Nothing
                        myNextRow = True
                    End If
                    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                Case Keys.F8
                    Select Case myGridKeyDown.Name
                        Case "dgBang_Cuoc"
                            If DeleteRow_Bang_Cuoc() Then
                                Refresh_StatusBar(Me.Tag)
                                e.Handled = True
                            End If
                        Case "dgHVC"
                            If DeleteRow_HVC() Then
                                Refresh_StatusBar(Me.Tag)
                                e.Handled = True
                            End If
                    End Select
                Case Keys.Escape
                    'Select Case myGridKeyDown.Name
                    '    Case "dgBang_Cuoc"
                    '        If myGridKeyDown.ActiveRow.Cells(0).Value Is DBNull.Value Or CInt(myGridKeyDown.ActiveRow.Cells(0).Value) = 0 Then
                    '            myGridKeyDown.ActiveRow.Delete(False)
                    '            myGridKeyDown.Rows.Band.AddNew()
                    '        End If
                    '    Case "dgHVC"
                    '        If myGridKeyDown.ActiveRow.Cells(0).Value Is DBNull.Value Or CInt(myGridKeyDown.ActiveRow.Cells(0).Value) = 0 Then
                    '            myGridKeyDown.ActiveRow.Delete(False)
                    '            myGridKeyDown.Rows.Band.AddNew()
                    '        End If
                    'End Select                  
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Hàm người dùng"
#Region "Dropdown_San_Bay"
    Private Sub Dropdown_San_Bay()
        ddSan_Bay.DataSource = myAccounting_Cuoc_Hang_Khong.Danh_Muc_Chuyen_Bay_Danh_Sach_Ma_San_Bay()
        ddSan_Bay.DataBind()
    End Sub
#End Region
#Region "Dropdown_HVC"
    Private Sub Dropdown_HVC()
        ddHVC.DataSource = myAccounting_Danh_Sach_HVC.Danh_Muc_Chuyen_Bay_Danh_Sach_HVC()
        ddHVC.DataBind()
    End Sub
#End Region
#Region "Refresh_StatusBar"
    Private Sub Refresh_StatusBar(ByVal mTab As String)
        Try
            Dim mThong_Tin As String
            Dim mTong_So As Integer
            Select Case mTab
                Case "Accounting_Bang_Cuoc_Hang_Khong"
                    mThong_Tin = "Tổng số :  "
                    mTong_So = 0
                    For i = 0 To dgBang_Cuoc.Rows.Count - 1
                        If dgBang_Cuoc.Rows(i).Cells("San_Bay_Xuat_Phat").Text <> "" And dgBang_Cuoc.Rows(i).Cells("San_Bay_Den").Text <> "" And IsNumeric(dgBang_Cuoc.Rows(i).Cells("Cuoc").Value) Then
                            mTong_So = mTong_So + 1
                        End If
                    Next
                    lblInfo_Cuoc.Text = mThong_Tin & mTong_So.ToString
                Case "Accounting_Danh_Sach_HVC"
                    mThong_Tin = "Tổng số :  "
                    mTong_So = 0
                    For i = 0 To dgHVC.Rows.Count - 1
                        If dgHVC.Rows(i).Cells("HVC").Text <> "" And dgHVC.Rows(i).Cells("Ten_HVC").Text <> "" Then
                            mTong_So = mTong_So + 1
                        End If
                    Next
                    lblInfo_HVC.Text = mThong_Tin & mTong_So.ToString
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Select Case mTab
                Case "Accounting_Bang_Cuoc_Hang_Khong"
                    lblInfo_Cuoc.Text = "Tổng số :  0"
                Case "Accounting_Danh_Sach_HVC"
                    lblInfo_HVC.Text = "Tổng số :  0"
            End Select
        End Try
    End Sub
#End Region
#Region "DeleteRow_Bang_Cuoc"
    Private Function DeleteRow_Bang_Cuoc() As Boolean
        Try
            If dgBang_Cuoc.ActiveRow Is Nothing Then
                Return False
                Exit Function
            End If
            If dgBang_Cuoc.ActiveRow.Cells("San_Bay_Xuat_Phat").Text <> "" Or dgBang_Cuoc.ActiveRow.Cells("San_Bay_Den").Text <> "" Then
                If MessageBox.Show("Bạn có chắc chắn muốn xóa dòng dữ liệu này không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    Dim mId_Cuoc As String
                    mId_Cuoc = Tao_Id_Bang_Cuoc_Hang_Khong(dgBang_Cuoc.ActiveRow.Cells("San_Bay_Xuat_Phat").Text, dgBang_Cuoc.ActiveRow.Cells("San_Bay_Den").Text)
                    myAccounting_Cuoc_Hang_Khong.Accounting_Bang_Cuoc_Hang_Khong_Xoa(mId_Cuoc)
                    dgBang_Cuoc.ActiveRow.Delete(False)
                End If
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

#End Region
#Region "DeleteRow_HVC"
    Private Function DeleteRow_HVC() As Boolean
        Try
            If dgHVC.ActiveRow Is Nothing Then
                Return False
                Exit Function
            End If
            If dgHVC.ActiveRow.Cells("HVC").Text <> "" Then
                If MessageBox.Show("Bạn có chắc chắn muốn xóa dòng dữ liệu này không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    myAccounting_Danh_Sach_HVC.Accounting_Danh_Sach_HVC_Xoa(dgHVC.ActiveRow.Cells("HVC").Text)
                    dgHVC.ActiveRow.Delete(False)
                End If
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

#End Region
#Region "Tao_Id_Bang_Cuoc_Hang_Khong"
    Private Function Tao_Id_Bang_Cuoc_Hang_Khong(ByVal mSan_Bay_Xuat_Phat As String, ByVal mSan_Bay_Den As String) As String
        Try
            Return mSan_Bay_Xuat_Phat & mSan_Bay_Den
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        End Try
    End Function
#End Region
#Region "DataGrid_Bang_Cuoc"
    Private Sub DataGrid_Bang_Cuoc()
        Try
            dgBang_Cuoc.DataSource = myAccounting_Cuoc_Hang_Khong.Accounting_Bang_Cuoc_Hang_Khong_Danh_Sach()
            dgBang_Cuoc.DataBind()
            dgBang_Cuoc.Rows.Band.AddNew()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "DataGrid_Danh_Sach_HVC"
    Private Sub DataGrid_Danh_Sach_HVC()
        Try
            dgHVC.DataSource = myAccounting_Danh_Sach_HVC.Accounting_Danh_Sach_HVC_Danh_Sach()
            dgHVC.DataBind()
            dgHVC.Rows.Band.AddNew()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region
#Region "-----------------AddNewRow-------------------"
    Private Sub AddNewRow(ByVal sender As Object)
        myGridKeyDown = sender
        If myGridKeyDown.Rows.Count = 0 Then
            myGridKeyDown.Rows.Band.AddNew()
        Else
            If Not myGridKeyDown.ActiveCell Is Nothing Then
                If myGridKeyDown.ActiveCell.Row.HasNextSibling = False Then
                    myGridKeyDown.Rows.Band.AddNew()
                End If
            End If
        End If
    End Sub
#End Region
#End Region

End Class

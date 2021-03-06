Imports System
Imports ADODB
Imports System.IO
Imports System.Windows.Forms
Imports System.Data.OleDb
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports Ems_International_Logic.EMS

Public Class Frm_Tao_Va_In_CN55
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
    Friend WithEvents LbTieu_De As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btnTao_Du_Lieu As Infragistics.Win.Misc.UltraButton
    Friend WithEvents CbTu_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CbDen_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnIn_CN55 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnThoat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents chk27_Tinh As System.Windows.Forms.CheckBox
    Friend WithEvents chkCon_Lai As System.Windows.Forms.CheckBox
    Friend WithEvents dgMa_Nuoc_CN55 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgMa_Bc_CN55 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents chkMa_Nuoc As System.Windows.Forms.CheckBox
    Friend WithEvents cbQuy As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbNam As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbMa_Bc_Khai_Thac As Infragistics.Win.UltraWinGrid.UltraCombo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Bc_Khai_Thac", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Bc_Khai_Thac")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OutBout")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Nam", -1)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nam")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Danh_Muc_Quy_CN55", -1)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Quarter_Id")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Quarter_Name")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Column_1")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Column_2")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Column_3")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Bc_CN55", -1)
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chon")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Bc")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Nuoc_CN55", -1)
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chon")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Nuoc", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_Tao_Va_In_CN55))
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.LbTieu_De = New Infragistics.Win.Misc.UltraLabel
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbMa_Bc_Khai_Thac = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cbNam = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.cbQuy = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.chkMa_Nuoc = New System.Windows.Forms.CheckBox
        Me.dgMa_Bc_CN55 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.dgMa_Nuoc_CN55 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.chkCon_Lai = New System.Windows.Forms.CheckBox
        Me.chk27_Tinh = New System.Windows.Forms.CheckBox
        Me.btnThoat = New Infragistics.Win.Misc.UltraButton
        Me.btnIn_CN55 = New Infragistics.Win.Misc.UltraButton
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.btnTao_Du_Lieu = New Infragistics.Win.Misc.UltraButton
        Me.CbTu_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.CbDen_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.cbMa_Bc_Khai_Thac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbNam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbQuy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMa_Bc_CN55, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMa_Nuoc_CN55, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbTu_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbDen_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbTieu_De
        '
        Appearance1.FontData.BoldAsString = "True"
        Appearance1.TextHAlign = Infragistics.Win.HAlign.Center
        Me.LbTieu_De.Appearance = Appearance1
        Me.LbTieu_De.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.LbTieu_De.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTieu_De.Location = New System.Drawing.Point(0, 0)
        Me.LbTieu_De.Name = "LbTieu_De"
        Me.LbTieu_De.Size = New System.Drawing.Size(536, 64)
        Me.LbTieu_De.TabIndex = 1
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.Label3)
        Me.UltraGroupBox1.Controls.Add(Me.cbMa_Bc_Khai_Thac)
        Me.UltraGroupBox1.Controls.Add(Me.cbNam)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox1.Controls.Add(Me.cbQuy)
        Me.UltraGroupBox1.Controls.Add(Me.chkMa_Nuoc)
        Me.UltraGroupBox1.Controls.Add(Me.dgMa_Bc_CN55)
        Me.UltraGroupBox1.Controls.Add(Me.dgMa_Nuoc_CN55)
        Me.UltraGroupBox1.Controls.Add(Me.chkCon_Lai)
        Me.UltraGroupBox1.Controls.Add(Me.chk27_Tinh)
        Me.UltraGroupBox1.Controls.Add(Me.btnThoat)
        Me.UltraGroupBox1.Controls.Add(Me.btnIn_CN55)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox1.Controls.Add(Me.btnTao_Du_Lieu)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 64)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(536, 344)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(200, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "BC Khai Thác"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbMa_Bc_Khai_Thac
        '
        Me.cbMa_Bc_Khai_Thac.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.cbMa_Bc_Khai_Thac.DisplayLayout.Appearance = Appearance2
        UltraGridColumn1.Header.Caption = "Mã BC Khai Thác"
        UltraGridColumn1.Header.VisiblePosition = 2
        UltraGridColumn2.Header.Caption = "Bưu cục khai Thác"
        UltraGridColumn2.Header.VisiblePosition = 0
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 1
        UltraGridColumn3.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        UltraGridBand1.Header.Caption = "Mã Ðu?ng Thu"
        UltraGridBand1.UseRowLayout = True
        Me.cbMa_Bc_Khai_Thac.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbMa_Bc_Khai_Thac.DisplayLayout.Override.HeaderAppearance = Appearance3
        Me.cbMa_Bc_Khai_Thac.DisplayMember = "Ma_Bc_Khai_Thac"
        Me.cbMa_Bc_Khai_Thac.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMa_Bc_Khai_Thac.Location = New System.Drawing.Point(200, 40)
        Me.cbMa_Bc_Khai_Thac.Name = "cbMa_Bc_Khai_Thac"
        Me.cbMa_Bc_Khai_Thac.Size = New System.Drawing.Size(96, 24)
        Me.cbMa_Bc_Khai_Thac.TabIndex = 16
        Me.cbMa_Bc_Khai_Thac.ValueMember = "Ma_Bc_Khai_Thac"
        '
        'cbNam
        '
        Me.cbNam.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance4.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.cbNam.DisplayLayout.Appearance = Appearance4
        UltraGridColumn4.Header.Caption = "Năm"
        UltraGridColumn4.Header.VisiblePosition = 0
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn4})
        UltraGridBand2.Header.Caption = "Đường thư"
        UltraGridBand2.UseRowLayout = True
        Me.cbNam.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance5.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance5.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbNam.DisplayLayout.Override.HeaderAppearance = Appearance5
        Me.cbNam.DisplayMember = ""
        Me.cbNam.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNam.Location = New System.Drawing.Point(112, 40)
        Me.cbNam.Name = "cbNam"
        Me.cbNam.Size = New System.Drawing.Size(64, 24)
        Me.cbNam.TabIndex = 3
        Me.cbNam.ValueMember = ""
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(112, 16)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(48, 16)
        Me.UltraLabel2.TabIndex = 2
        Me.UltraLabel2.Text = "Năm"
        '
        'cbQuy
        '
        Me.cbQuy.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.cbQuy.DisplayLayout.Appearance = Appearance6
        UltraGridColumn5.Header.VisiblePosition = 0
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.Caption = "Quý"
        UltraGridColumn6.Header.VisiblePosition = 1
        UltraGridColumn7.Header.VisiblePosition = 2
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 3
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 4
        UltraGridColumn9.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9})
        UltraGridBand3.Header.Caption = "Đường thư"
        UltraGridBand3.UseRowLayout = True
        Me.cbQuy.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Appearance7.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance7.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance7.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance7.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbQuy.DisplayLayout.Override.HeaderAppearance = Appearance7
        Me.cbQuy.DisplayMember = "Quarter_Name"
        Me.cbQuy.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbQuy.Location = New System.Drawing.Point(8, 40)
        Me.cbQuy.Name = "cbQuy"
        Me.cbQuy.Size = New System.Drawing.Size(80, 24)
        Me.cbQuy.TabIndex = 1
        Me.cbQuy.ValueMember = "Quarter_Id"
        '
        'chkMa_Nuoc
        '
        Me.chkMa_Nuoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMa_Nuoc.Location = New System.Drawing.Point(8, 80)
        Me.chkMa_Nuoc.Name = "chkMa_Nuoc"
        Me.chkMa_Nuoc.Size = New System.Drawing.Size(128, 24)
        Me.chkMa_Nuoc.TabIndex = 9
        Me.chkMa_Nuoc.Text = "Chọn tất cả"
        '
        'dgMa_Bc_CN55
        '
        Me.dgMa_Bc_CN55.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgMa_Bc_CN55.DisplayLayout.AddNewBox.Prompt = " "
        Appearance8.BackColor = System.Drawing.Color.White
        Appearance8.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgMa_Bc_CN55.DisplayLayout.Appearance = Appearance8
        UltraGridColumn10.Header.Caption = ""
        UltraGridColumn10.Header.VisiblePosition = 0
        UltraGridColumn10.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn10.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn10.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(37, 0)
        UltraGridColumn10.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn10.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn10.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn11.Header.Caption = "Mã Bc"
        UltraGridColumn11.Header.VisiblePosition = 1
        UltraGridColumn11.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn11.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn11.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(61, 0)
        UltraGridColumn11.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn11.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn12.Header.Caption = "Tên bưu cục"
        UltraGridColumn12.Header.VisiblePosition = 3
        UltraGridColumn12.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn12.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn12.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(115, 0)
        UltraGridColumn12.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn12.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn13.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn13.Header.Caption = "Mã Nước"
        UltraGridColumn13.Header.VisiblePosition = 2
        UltraGridColumn13.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn13.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn13.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(68, 0)
        UltraGridColumn13.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn13.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13})
        UltraGridBand4.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand4.UseRowLayout = True
        Me.dgMa_Bc_CN55.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.dgMa_Bc_CN55.DisplayLayout.InterBandSpacing = 10
        Me.dgMa_Bc_CN55.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Me.dgMa_Bc_CN55.DisplayLayout.Override.CardAreaAppearance = Appearance9
        Me.dgMa_Bc_CN55.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance10.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance10.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance10.ForeColor = System.Drawing.Color.Black
        Appearance10.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance10.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgMa_Bc_CN55.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.dgMa_Bc_CN55.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance11.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgMa_Bc_CN55.DisplayLayout.Override.RowAppearance = Appearance11
        Appearance12.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance12.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgMa_Bc_CN55.DisplayLayout.Override.RowSelectorAppearance = Appearance12
        Me.dgMa_Bc_CN55.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgMa_Bc_CN55.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance13.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance13.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance13.ForeColor = System.Drawing.Color.Black
        Me.dgMa_Bc_CN55.DisplayLayout.Override.SelectedRowAppearance = Appearance13
        Me.dgMa_Bc_CN55.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgMa_Bc_CN55.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgMa_Bc_CN55.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMa_Bc_CN55.Location = New System.Drawing.Point(240, 104)
        Me.dgMa_Bc_CN55.Name = "dgMa_Bc_CN55"
        Me.dgMa_Bc_CN55.Size = New System.Drawing.Size(288, 168)
        Me.dgMa_Bc_CN55.TabIndex = 11
        Me.dgMa_Bc_CN55.Text = "Danh mục Bưu cục"
        '
        'dgMa_Nuoc_CN55
        '
        Me.dgMa_Nuoc_CN55.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgMa_Nuoc_CN55.DisplayLayout.AddNewBox.Prompt = " "
        Appearance14.BackColor = System.Drawing.Color.White
        Appearance14.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgMa_Nuoc_CN55.DisplayLayout.Appearance = Appearance14
        UltraGridColumn14.Header.Caption = ""
        UltraGridColumn14.Header.VisiblePosition = 0
        UltraGridColumn14.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(41, 0)
        UltraGridColumn14.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn15.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn15.Header.Caption = "Mã Nước"
        UltraGridColumn15.Header.VisiblePosition = 1
        UltraGridColumn15.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(64, 0)
        UltraGridColumn16.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn16.Header.Caption = "Tên Nước"
        UltraGridColumn16.Header.VisiblePosition = 2
        UltraGridColumn16.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(109, 0)
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn14, UltraGridColumn15, UltraGridColumn16})
        UltraGridBand5.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand5.UseRowLayout = True
        Me.dgMa_Nuoc_CN55.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.dgMa_Nuoc_CN55.DisplayLayout.InterBandSpacing = 10
        Me.dgMa_Nuoc_CN55.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Me.dgMa_Nuoc_CN55.DisplayLayout.Override.CardAreaAppearance = Appearance15
        Me.dgMa_Nuoc_CN55.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance16.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance16.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance16.ForeColor = System.Drawing.Color.Black
        Appearance16.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance16.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgMa_Nuoc_CN55.DisplayLayout.Override.HeaderAppearance = Appearance16
        Me.dgMa_Nuoc_CN55.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance17.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgMa_Nuoc_CN55.DisplayLayout.Override.RowAppearance = Appearance17
        Appearance18.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance18.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgMa_Nuoc_CN55.DisplayLayout.Override.RowSelectorAppearance = Appearance18
        Me.dgMa_Nuoc_CN55.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgMa_Nuoc_CN55.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance19.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance19.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance19.ForeColor = System.Drawing.Color.Black
        Me.dgMa_Nuoc_CN55.DisplayLayout.Override.SelectedRowAppearance = Appearance19
        Me.dgMa_Nuoc_CN55.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgMa_Nuoc_CN55.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgMa_Nuoc_CN55.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMa_Nuoc_CN55.Location = New System.Drawing.Point(8, 104)
        Me.dgMa_Nuoc_CN55.Name = "dgMa_Nuoc_CN55"
        Me.dgMa_Nuoc_CN55.Size = New System.Drawing.Size(224, 168)
        Me.dgMa_Nuoc_CN55.TabIndex = 10
        Me.dgMa_Nuoc_CN55.Text = "Danh mục nước"
        '
        'chkCon_Lai
        '
        Me.chkCon_Lai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCon_Lai.Location = New System.Drawing.Point(8, 296)
        Me.chkCon_Lai.Name = "chkCon_Lai"
        Me.chkCon_Lai.Size = New System.Drawing.Size(128, 24)
        Me.chkCon_Lai.TabIndex = 12
        Me.chkCon_Lai.Text = "Các tỉnh còn lại"
        '
        'chk27_Tinh
        '
        Me.chk27_Tinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk27_Tinh.Location = New System.Drawing.Point(136, 296)
        Me.chk27_Tinh.Name = "chk27_Tinh"
        Me.chk27_Tinh.Size = New System.Drawing.Size(128, 24)
        Me.chk27_Tinh.TabIndex = 13
        Me.chk27_Tinh.Text = "27 tỉnh miền Bắc"
        '
        'btnThoat
        '
        Appearance20.Image = CType(resources.GetObject("Appearance20.Image"), Object)
        Me.btnThoat.Appearance = Appearance20
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.ImageSize = New System.Drawing.Size(19, 19)
        Me.btnThoat.Location = New System.Drawing.Point(432, 288)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(96, 32)
        Me.btnThoat.TabIndex = 15
        Me.btnThoat.Text = "Thoát"
        '
        'btnIn_CN55
        '
        Appearance21.Image = CType(resources.GetObject("Appearance21.Image"), Object)
        Me.btnIn_CN55.Appearance = Appearance21
        Me.btnIn_CN55.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIn_CN55.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnIn_CN55.Location = New System.Drawing.Point(280, 288)
        Me.btnIn_CN55.Name = "btnIn_CN55"
        Me.btnIn_CN55.Size = New System.Drawing.Size(96, 32)
        Me.btnIn_CN55.TabIndex = 14
        Me.btnIn_CN55.Text = "In CN55"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(8, 16)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(80, 16)
        Me.UltraLabel1.TabIndex = 0
        Me.UltraLabel1.Text = "Quý"
        '
        'btnTao_Du_Lieu
        '
        Appearance22.Image = CType(resources.GetObject("Appearance22.Image"), Object)
        Me.btnTao_Du_Lieu.Appearance = Appearance22
        Me.btnTao_Du_Lieu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTao_Du_Lieu.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnTao_Du_Lieu.Location = New System.Drawing.Point(416, 32)
        Me.btnTao_Du_Lieu.Name = "btnTao_Du_Lieu"
        Me.btnTao_Du_Lieu.Size = New System.Drawing.Size(112, 32)
        Me.btnTao_Du_Lieu.TabIndex = 8
        Me.btnTao_Du_Lieu.Text = "Tạo dữ liệu"
        '
        'CbTu_Ngay
        '
        Me.CbTu_Ngay.DateTime = New Date(2008, 7, 3, 0, 0, 0, 0)
        Me.CbTu_Ngay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbTu_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.CbTu_Ngay.Location = New System.Drawing.Point(184, 32)
        Me.CbTu_Ngay.MaskInput = "dd/mm/yyyy"
        Me.CbTu_Ngay.Name = "CbTu_Ngay"
        Me.CbTu_Ngay.Size = New System.Drawing.Size(96, 24)
        Me.CbTu_Ngay.TabIndex = 5
        Me.CbTu_Ngay.Value = New Date(2008, 7, 3, 0, 0, 0, 0)
        Me.CbTu_Ngay.Visible = False
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(184, 8)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(80, 16)
        Me.UltraLabel4.TabIndex = 4
        Me.UltraLabel4.Text = "Từ ngày"
        Me.UltraLabel4.Visible = False
        '
        'CbDen_Ngay
        '
        Me.CbDen_Ngay.DateTime = New Date(2009, 6, 23, 0, 0, 0, 0)
        Me.CbDen_Ngay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbDen_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.CbDen_Ngay.Location = New System.Drawing.Point(296, 32)
        Me.CbDen_Ngay.MaskInput = "dd/mm/yyyy"
        Me.CbDen_Ngay.Name = "CbDen_Ngay"
        Me.CbDen_Ngay.Size = New System.Drawing.Size(88, 24)
        Me.CbDen_Ngay.TabIndex = 7
        Me.CbDen_Ngay.Value = New Date(2009, 6, 23, 0, 0, 0, 0)
        Me.CbDen_Ngay.Visible = False
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(296, 8)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel3.TabIndex = 6
        Me.UltraLabel3.Text = "Ðến ngày"
        Me.UltraLabel3.Visible = False
        '
        'Frm_Tao_Va_In_CN55
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(536, 413)
        Me.Controls.Add(Me.CbTu_Ngay)
        Me.Controls.Add(Me.UltraLabel4)
        Me.Controls.Add(Me.CbDen_Ngay)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.LbTieu_De)
        Me.Name = "Frm_Tao_Va_In_CN55"
        Me.Text = "Thiết lập và in CN55"
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.cbMa_Bc_Khai_Thac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbNam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbQuy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMa_Bc_CN55, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMa_Nuoc_CN55, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbTu_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbDen_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Khai bao bien cua Form"
    Dim myAccounting_Danh_Muc_Quy_CN55 As New Accounting_Danh_Muc_Quy_CN55(GConnectionString)
    Dim myAccounting_Du_Lieu_Quy_CN55 As New Accounting_Du_Lieu_Quy_CN55(GConnectionString)
    Dim myAccounting_Ma_Bc_CN55 As New Accounting_Ma_Bc_CN55(GConnectionString)
    Dim myAccounting_Ma_Nuoc_CN55 As New Accounting_Ma_Nuoc_CN55(GConnectionString)
    Dim myMa_Bc_Khai_Thac As New Ma_Bc_Khai_Thac(GConnectionString)

    Dim myAccounting_Danh_Muc_Quy_CN55_Chi_Tiet As New Accounting_Danh_Muc_Quy_CN55_Chi_Tiet
    Dim myAccounting_Du_Lieu_Quy_CN55_Chi_Tiet As New Accounting_Du_Lieu_Quy_CN55_Chi_Tiet
    Dim myAccounting_Ma_Bc_CN55_Chi_Tiet As New Accounting_Ma_Bc_CN55_Chi_Tiet
    Dim myAccounting_Ma_Nuoc_CN55_Chi_Tiet As New Accounting_Ma_Nuoc_CN55_Chi_Tiet

    Dim myHamdungchung As New Ham_Dung_Chung
#End Region

#Region "Frm_Tao_Va_In_CN55_Load"
    Private Sub Frm_Tao_Va_In_CN55_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LbTieu_De.Text = vbNewLine & "Tách dữ liệu đóng đi 27 tỉnh miền bắc và các tỉnh còn lại."
        'Load du lieu       
        Load_Cb_Nam()
        Load_Danh_Muc_Quy()
        Load_Ma_Bc_Khai_Thac()
        Load_Danh_Muc_Nuoc_CN55()
        Load_Danh_Muc_Buu_Cuc_CN55()
        '----Tu_Ngay
        '----Den_Ngay
        chkMa_Nuoc.Checked = True
    End Sub
#End Region

#Region "TablControl"

#Region "TabControl KeyEnter"
    Private Sub cbQuy_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbQuy.KeyDown, cbNam.KeyDown, CbTu_Ngay.KeyDown, CbDen_Ngay.KeyDown, chk27_Tinh.KeyDown, chkCon_Lai.KeyDown
        If e.KeyValue = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
        End If
    End Sub
#End Region

#Region "btnThoat_Click"
    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
        Me.Dispose()
    End Sub
#End Region

#Region "chkMa_Nuoc_CheckedChanged"
    Private Sub chkMa_Nuoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMa_Nuoc.CheckedChanged
        Dim i As Integer
        Dim j As Integer
        For i = 0 To dgMa_Nuoc_CN55.Rows.Count - 1
            dgMa_Nuoc_CN55.Rows(i).Cells("Chon").Value = chkMa_Nuoc.Checked
            For j = 0 To dgMa_Bc_CN55.Rows.Count - 1
                If dgMa_Bc_CN55.Rows(j).Cells("Ma_Nuoc").Text = dgMa_Nuoc_CN55.Rows(i).Cells("Ma_Nuoc").Text Then
                    dgMa_Bc_CN55.Rows(j).Cells("Chon").Value = dgMa_Nuoc_CN55.Rows(i).Cells("Chon").Value
                End If
            Next
        Next
    End Sub
#End Region

#Region "cbQuy_ValueChanged"
    Private Sub cbQuy_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbQuy.ValueChanged
        Load_Tu_Ngay_Den_Ngay(cbQuy.Value, cbNam.Value)
    End Sub
#End Region

#Region "cbNam_ValueChanged"
    Private Sub cbNam_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbNam.ValueChanged
        Load_Tu_Ngay_Den_Ngay(cbQuy.Value, cbNam.Value)
    End Sub
#End Region

#Region "dgMa_Nuoc_CN55_InitializeLayout"
    Private Sub dgMa_Nuoc_CN55_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgMa_Nuoc_CN55.InitializeLayout
        dgMa_Nuoc_CN55.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        dgMa_Nuoc_CN55.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
        dgMa_Nuoc_CN55.DisplayLayout.Bands(0).Columns("Chon").Style = ColumnStyle.CheckBox
    End Sub
#End Region

#Region "dgMa_Nuoc_CN55_CellChange"
    Private Sub dgMa_Nuoc_CN55_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgMa_Nuoc_CN55.CellChange
        Try
            Dim i As Integer
            If dgMa_Nuoc_CN55.ActiveCell Is Nothing Then
                Exit Sub
            End If
            If e.Cell.Column.Key = "Chon" Then
                For i = 0 To dgMa_Bc_CN55.Rows.Count - 1
                    If dgMa_Bc_CN55.Rows(i).Cells("Ma_Nuoc").Text = dgMa_Nuoc_CN55.ActiveRow.Cells("Ma_Nuoc").Text Then
                        dgMa_Bc_CN55.Rows(i).Cells("Chon").Value = CInt(e.Cell.Text)
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "dgMa_Bc_CN55_InitializeLayout"
    Private Sub dgMa_Bc_CN55_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgMa_Bc_CN55.InitializeLayout
        dgMa_Bc_CN55.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        dgMa_Bc_CN55.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
        dgMa_Bc_CN55.DisplayLayout.Bands(0).Columns("Chon").Style = ColumnStyle.CheckBox
    End Sub
#End Region

#Region "btnTao_Du_Lieu_Click"
    Private Sub btnTao_Du_Lieu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTao_Du_Lieu.Click
        If MessageBox.Show("Bạn có chắc chắn muốn tạo dữ liệu CN55 & CN56 không?" & vbNewLine & "Nếu đồng ý xin vui lòng đợi trong vài phút, dữ liệu sẽ được tạo.", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            FrmThongTinKeToan.ActiveForm.Cursor.Current = Cursors.WaitCursor
            'Tao du lieu
            If Tao_Du_Lieu_CN55() = True Then
                FrmThongTinKeToan.ActiveForm.Cursor.Current = Cursors.Default
                'Thong bao thanh cong
                MessageBox.Show("Dữ liệu đã tạo thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                FrmThongTinKeToan.ActiveForm.Cursor.Current = Cursors.Default
                'Thong bao that bai
                MessageBox.Show("Tạo dữ liệu thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
#End Region

#End Region

#Region "Ham Nguoi Dung"

#Region "Load_Danh_Muc_Quy"
    Private Sub Load_Danh_Muc_Quy()
        Try
            Dim curMonth As Integer
            curMonth = Now().Date.Date.Month
            cbQuy.DataSource = myAccounting_Danh_Muc_Quy_CN55.Accounting_Danh_Muc_Quy_CN55_Danh_Sach()
            cbQuy.DataBind()
            cbQuy.DisplayLayout.Bands(0).Columns("Quarter_Id").SortIndicator = SortIndicator.Ascending
            Select Case curMonth
                Case 1, 2, 3
                    cbQuy.Value = cbQuy.Rows(0).Cells("Quarter_Id").Value
                Case 4, 5, 6
                    cbQuy.Value = cbQuy.Rows(1).Cells("Quarter_Id").Value
                Case 7, 8, 9
                    cbQuy.Value = cbQuy.Rows(2).Cells("Quarter_Id").Value
                Case 10, 11, 12
                    cbQuy.Value = cbQuy.Rows(3).Cells("Quarter_Id").Value
            End Select
            cbQuy.LimitToList = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Load_Danh_Muc_Nuoc_CN55"
    Private Sub Load_Danh_Muc_Nuoc_CN55()
        Try
            dgMa_Nuoc_CN55.DataSource = myAccounting_Ma_Nuoc_CN55.Accounting_Ma_Nuoc_CN55_Danh_Sach()
            dgMa_Nuoc_CN55.DataBind()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Load_Danh_Muc_Buu_Cuc_CN55"
    Private Sub Load_Danh_Muc_Buu_Cuc_CN55()
        Try
            dgMa_Bc_CN55.DataSource = myAccounting_Ma_Bc_CN55.Accounting_Ma_Bc_CN55_Danh_Sach()
            dgMa_Bc_CN55.DataBind()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Load_Tu_Ngay_Den_Ngay"
    Private Sub Load_Tu_Ngay_Den_Ngay(ByVal Quarter_Id As Integer, ByVal Year_Id As Integer)
        Try
            Dim iNgay As Integer
            Dim dNgay As Date
            Select Case Quarter_Id
                Case 1
                    'Tu Ngay
                    iNgay = Year_Id * 10000 + 1 * 100 + 1 * 1
                    dNgay = myHamdungchung.ConvertIntToDate(iNgay)
                    dNgay = myHamdungchung.dBeginMonth(dNgay)
                    CbTu_Ngay.Value = dNgay
                    'Den Ngay
                    iNgay = Year_Id * 10000 + 3 * 100 + 1 * 1
                    dNgay = myHamdungchung.ConvertIntToDate(iNgay)
                    dNgay = myHamdungchung.dEndMonth(dNgay)
                    CbDen_Ngay.Value = dNgay
                Case 2
                    'Tu Ngay
                    iNgay = Year_Id * 10000 + 4 * 100 + 1 * 1
                    dNgay = myHamdungchung.ConvertIntToDate(iNgay)
                    dNgay = myHamdungchung.dBeginMonth(dNgay)
                    CbTu_Ngay.Value = dNgay
                    'Den Ngay
                    iNgay = Year_Id * 10000 + 6 * 100 + 1 * 1
                    dNgay = myHamdungchung.ConvertIntToDate(iNgay)
                    dNgay = myHamdungchung.dEndMonth(dNgay)
                    CbDen_Ngay.Value = dNgay
                Case 3
                    'Tu Ngay
                    iNgay = Year_Id * 10000 + 7 * 100 + 1 * 1
                    dNgay = myHamdungchung.ConvertIntToDate(iNgay)
                    dNgay = myHamdungchung.dBeginMonth(dNgay)
                    CbTu_Ngay.Value = dNgay
                    'Den Ngay
                    iNgay = Year_Id * 10000 + 9 * 100 + 1 * 1
                    dNgay = myHamdungchung.ConvertIntToDate(iNgay)
                    dNgay = myHamdungchung.dEndMonth(dNgay)
                    CbDen_Ngay.Value = dNgay
                Case 4
                    'Tu Ngay
                    iNgay = Year_Id * 10000 + 10 * 100 + 1 * 1
                    dNgay = myHamdungchung.ConvertIntToDate(iNgay)
                    dNgay = myHamdungchung.dBeginMonth(dNgay)
                    CbTu_Ngay.Value = dNgay
                    'Den Ngay
                    iNgay = Year_Id * 10000 + 12 * 100 + 1 * 1
                    dNgay = myHamdungchung.ConvertIntToDate(iNgay)
                    dNgay = myHamdungchung.dEndMonth(dNgay)
                    CbDen_Ngay.Value = dNgay
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Load_Cb_Nam"
    Private Sub Load_Cb_Nam()
        Try
            Dim curYEAR As Integer
            Dim i As Integer
            Dim row As DataRow
            Dim dataTable As New dataTable("Nam")
            Dim colWork As DataColumn = New DataColumn("Nam", GetType(Int32))
            dataTable.Columns.Add(colWork)
            curYEAR = Now().Date.Year - 3
            For i = 0 To 10
                row = dataTable.NewRow()
                row("Nam") = curYEAR + i
                dataTable.Rows.Add(row)
            Next
            'Bin Data
            cbNam.DataSource = dataTable
            cbNam.DataBind()
            cbNam.LimitToList = True
            cbNam.Value = Now().Date.Year
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Load_Ma_Bc_Khai_Thac"
    Private Sub Load_Ma_Bc_Khai_Thac()
        cbMa_Bc_Khai_Thac.DataSource = myMa_Bc_Khai_Thac.Ma_Bc_Khai_Thac_Danh_Sach_QT_Den()
        cbMa_Bc_Khai_Thac.DataBind()
        cbMa_Bc_Khai_Thac.Value = GBuu_Cuc_Khai_Thac
        cbMa_Bc_Khai_Thac.LimitToList = True
    End Sub
#End Region

#Region "Create_Ma_Quy"
    Private Function Create_Ma_Quy(ByVal Year_Id As Integer, ByVal STT_Quy As Integer) As Integer
        Return Year_Id * 100 + STT_Quy
    End Function
#End Region

#End Region

#Region "Tao_Du_Lieu_CN55"
    Private Function Tao_Du_Lieu_CN55() As Boolean
        Try
            Dim Ma_Quy As Integer = Create_Ma_Quy(cbNam.Value, cbQuy.Value)
            Dim i As Integer
            Dim mTu_Ngay_1, mDen_Ngay_1 As Integer
            Dim mTu_Ngay_2, mDen_Ngay_2 As Integer
            Dim mTu_Ngay_3, mDen_Ngay_3 As Integer
            Dim mTu_Ngay, mDen_Ngay As Integer
            Dim mId_Duong_Thu_Den As String
            Dim mTen_Duong_Thu_Den As String
            Dim mMa_Bc_Den As Integer
            Dim mMa_Bc_KT_Den As Integer
            Dim mDuong_Thu_Den As New Duong_Thu_Den(GConnectionString)

            'Xoa du lieu cu
            myAccounting_Du_Lieu_Quy_CN55.Accounting_Du_Lieu_Quy_CN55_Xoa_Boi_Ma_Quy(Ma_Quy)
            'Tao du lieu moi
            For i = 0 To dgMa_Bc_CN55.Rows.Count - 1
                If dgMa_Bc_CN55.Rows(i).Cells("Chon").Value = 1 Then
                    'Chuan bi cac thong tin cho Store lay du lieu
                    mId_Duong_Thu_Den = CreateId_Duong_Thu(dgMa_Bc_CN55.Rows(i).Cells("Ma_Bc").Value, cbMa_Bc_Khai_Thac.Value)
                    mTen_Duong_Thu_Den = mDuong_Thu_Den.Lay(mId_Duong_Thu_Den).Ten_Duong_Thu
                    mMa_Bc_Den = dgMa_Bc_CN55.Rows(i).Cells("Ma_Bc").Value
                    mMa_Bc_KT_Den = cbMa_Bc_Khai_Thac.Value
                    mTu_Ngay = myHamdungchung.ConvertDateToInt(CbTu_Ngay.Value)
                    mDen_Ngay = myHamdungchung.ConvertDateToInt(CbDen_Ngay.Value)
                    Lay_Gioi_Han_Tu_Ngay_Den_Ngay_Cho_3_Cot(cbNam.Value, cbQuy.Value, mTu_Ngay_1, mDen_Ngay_1, mTu_Ngay_2, mDen_Ngay_2, mTu_Ngay_3, mDen_Ngay_3)
                    'Tao du lieu
                    myAccounting_Du_Lieu_Quy_CN55.Accounting_Du_Lieu_Quy_CN55_Tao_Du_Lieu_CN55(Ma_Quy, mId_Duong_Thu_Den, mTen_Duong_Thu_Den, mMa_Bc_Den, mMa_Bc_KT_Den, mTu_Ngay_1, mDen_Ngay_1, mTu_Ngay_2, mDen_Ngay_2, mTu_Ngay_3, mDen_Ngay_3, mTu_Ngay, mDen_Ngay)
                End If
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region

#Region "Lay_Gioi_Han_Tu_Ngay_Den_Ngay_Cho_3_Cot"
    Private Sub Lay_Gioi_Han_Tu_Ngay_Den_Ngay_Cho_3_Cot(ByVal Nam As Integer, ByVal Quy As Integer, ByRef Tu_Ngay_1 As Integer, ByRef Den_Ngay_1 As Integer, ByRef Tu_Ngay_2 As Integer, ByRef Den_Ngay_2 As Integer, ByRef Tu_Ngay_3 As Integer, ByRef Den_Ngay_3 As Integer)
        Dim Tu_Ngay As Integer
        Dim Den_Ngay_Tmp As Date
        Dim i As Integer
        Select Case Quy
            Case 1
                'Colume 1
                '---Tu Ngay 1
                Tu_Ngay_1 = Nam * 10000 + 1 * 100 + 1 * 1
                '---Den Ngay 1
                Den_Ngay_Tmp = myHamdungchung.ConvertIntToDate(Tu_Ngay_1)
                Den_Ngay_Tmp = myHamdungchung.dEndMonth(Den_Ngay_Tmp)
                Den_Ngay_1 = myHamdungchung.ConvertDateToInt(Den_Ngay_Tmp)
                'Colume 2
                '---Tu Ngay 2
                Tu_Ngay_2 = Nam * 10000 + 2 * 100 + 1 * 1
                '---Den Ngay 2
                Den_Ngay_Tmp = myHamdungchung.ConvertIntToDate(Tu_Ngay_2)
                Den_Ngay_Tmp = myHamdungchung.dEndMonth(Den_Ngay_Tmp)
                Den_Ngay_2 = myHamdungchung.ConvertDateToInt(Den_Ngay_Tmp)
                'Colume 3
                '---Tu Ngay 3
                Tu_Ngay_3 = Nam * 10000 + 3 * 100 + 1 * 1
                '---Den Ngay 3
                Den_Ngay_Tmp = myHamdungchung.ConvertIntToDate(Tu_Ngay_3)
                Den_Ngay_Tmp = myHamdungchung.dEndMonth(Den_Ngay_Tmp)
                Den_Ngay_3 = myHamdungchung.ConvertDateToInt(Den_Ngay_Tmp)
            Case 2
                'Colume 1
                '---Tu Ngay 1
                Tu_Ngay_1 = Nam * 10000 + 4 * 100 + 1 * 1
                '---Den Ngay 1
                Den_Ngay_Tmp = myHamdungchung.ConvertIntToDate(Tu_Ngay_1)
                Den_Ngay_Tmp = myHamdungchung.dEndMonth(Den_Ngay_Tmp)
                Den_Ngay_1 = myHamdungchung.ConvertDateToInt(Den_Ngay_Tmp)
                'Colume 2
                '---Tu Ngay 2
                Tu_Ngay_2 = Nam * 10000 + 5 * 100 + 1 * 1
                '---Den Ngay 2
                Den_Ngay_Tmp = myHamdungchung.ConvertIntToDate(Tu_Ngay_2)
                Den_Ngay_Tmp = myHamdungchung.dEndMonth(Den_Ngay_Tmp)
                Den_Ngay_2 = myHamdungchung.ConvertDateToInt(Den_Ngay_Tmp)
                'Colume 3
                '---Tu Ngay 3
                Tu_Ngay_3 = Nam * 10000 + 6 * 100 + 1 * 1
                '---Den Ngay 3
                Den_Ngay_Tmp = myHamdungchung.ConvertIntToDate(Tu_Ngay_3)
                Den_Ngay_Tmp = myHamdungchung.dEndMonth(Den_Ngay_Tmp)
                Den_Ngay_3 = myHamdungchung.ConvertDateToInt(Den_Ngay_Tmp)
            Case 3
                'Colume 1
                '---Tu Ngay 1
                Tu_Ngay_1 = Nam * 10000 + 7 * 100 + 1 * 1
                '---Den Ngay 1
                Den_Ngay_Tmp = myHamdungchung.ConvertIntToDate(Tu_Ngay_1)
                Den_Ngay_Tmp = myHamdungchung.dEndMonth(Den_Ngay_Tmp)
                Den_Ngay_1 = myHamdungchung.ConvertDateToInt(Den_Ngay_Tmp)
                'Colume 2
                '---Tu Ngay 2
                Tu_Ngay_2 = Nam * 10000 + 8 * 100 + 1 * 1
                '---Den Ngay 2
                Den_Ngay_Tmp = myHamdungchung.ConvertIntToDate(Tu_Ngay_2)
                Den_Ngay_Tmp = myHamdungchung.dEndMonth(Den_Ngay_Tmp)
                Den_Ngay_2 = myHamdungchung.ConvertDateToInt(Den_Ngay_Tmp)
                'Colume 3
                '---Tu Ngay 3
                Tu_Ngay_3 = Nam * 10000 + 9 * 100 + 1 * 1
                '---Den Ngay 3
                Den_Ngay_Tmp = myHamdungchung.ConvertIntToDate(Tu_Ngay_3)
                Den_Ngay_Tmp = myHamdungchung.dEndMonth(Den_Ngay_Tmp)
                Den_Ngay_3 = myHamdungchung.ConvertDateToInt(Den_Ngay_Tmp)
            Case 4
                'Colume 1
                '---Tu Ngay 1
                Tu_Ngay_1 = Nam * 10000 + 10 * 100 + 1 * 1
                '---Den Ngay 1
                Den_Ngay_Tmp = myHamdungchung.ConvertIntToDate(Tu_Ngay_1)
                Den_Ngay_Tmp = myHamdungchung.dEndMonth(Den_Ngay_Tmp)
                Den_Ngay_1 = myHamdungchung.ConvertDateToInt(Den_Ngay_Tmp)
                'Colume 2
                '---Tu Ngay 2
                Tu_Ngay_2 = Nam * 10000 + 11 * 100 + 1 * 1
                '---Den Ngay 2
                Den_Ngay_Tmp = myHamdungchung.ConvertIntToDate(Tu_Ngay_2)
                Den_Ngay_Tmp = myHamdungchung.dEndMonth(Den_Ngay_Tmp)
                Den_Ngay_2 = myHamdungchung.ConvertDateToInt(Den_Ngay_Tmp)
                'Colume 3
                '---Tu Ngay 3
                Tu_Ngay_3 = Nam * 10000 + 12 * 100 + 1 * 1
                '---Den Ngay 3
                Den_Ngay_Tmp = myHamdungchung.ConvertIntToDate(Tu_Ngay_3)
                Den_Ngay_Tmp = myHamdungchung.dEndMonth(Den_Ngay_Tmp)
                Den_Ngay_3 = myHamdungchung.ConvertDateToInt(Den_Ngay_Tmp)
        End Select
    End Sub

#End Region

#Region "btnIn_CN55_Click"
    Private Sub btnIn_CN55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIn_CN55.Click
        'Kiem tra xem da chon kieu in chua
        If Not chk27_Tinh.Checked And Not chkCon_Lai.Checked Then
            MessageBox.Show("Bạn chưa chọn in CN55 & CN56 cho 27 tỉnh miền bắc hay các tỉnh còn lại." & vbNewLine & "Mời bạn chọn bằng cách tích vào ô tương ứng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            chk27_Tinh.Select()
            Exit Sub
        End If
        'Kiem tra xem da chon ma nuoc chua
        Dim i, j As Integer
        Dim isChon As Boolean = False
        For i = 0 To dgMa_Nuoc_CN55.Rows.Count - 1
            If CBool(dgMa_Nuoc_CN55.Rows(i).Cells("Chon").Value) = True Then
                isChon = True
                Exit For
            End If
        Next
        If Not isChon Then
            MessageBox.Show("Bạn chưa chọn nước cần in CN55 & CN56. Mời bạn tích vào mã nước cần in trong danh mục nước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        'Ok - Tien hanh in 
        'In 27 tinh
        If chk27_Tinh.Checked Then
            For i = 0 To dgMa_Nuoc_CN55.Rows.Count - 1
                If CBool(dgMa_Nuoc_CN55.Rows(i).Cells("Chon").Value) = True Then
                    For j = 0 To dgMa_Bc_CN55.Rows.Count - 1
                        If dgMa_Bc_CN55.Rows(i).Cells("Ma_Nuoc").Text = dgMa_Nuoc_CN55.Rows(i).Cells("Ma_Nuoc").Text Then
                            'Print CN55 theo ma_bc
                            Print_CN55_Theo_Tung_Ma_Bc(Create_Ma_Quy(cbNam.Value, cbQuy.Value), cbNam.Value, dgMa_Bc_CN55.Rows(j).Cells("Ma_Bc").Text, cbMa_Bc_Khai_Thac.Value, True, dgMa_Nuoc_CN55.Rows(i).Cells("Ten_Nuoc").Text, dgMa_Bc_CN55.Rows(j).Cells("Ten_Bc").Text)
                        End If
                    Next
                    'Print CN56 theo ma_nuoc
                    Print_CN56_Theo_Tung_Ma_Nuoc(Create_Ma_Quy(cbNam.Value, cbQuy.Value), cbNam.Value, dgMa_Nuoc_CN55.Rows(i).Cells("Ma_Nuoc").Text, cbMa_Bc_Khai_Thac.Value, True, dgMa_Nuoc_CN55.Rows(i).Cells("Ten_Nuoc").Text)
                End If
            Next
        End If
        'In cac tinh con lai
        If chkCon_Lai.Checked Then
            For i = 0 To dgMa_Nuoc_CN55.Rows.Count - 1
                If CBool(dgMa_Nuoc_CN55.Rows(i).Cells("Chon").Value) = True Then
                    For j = 0 To dgMa_Bc_CN55.Rows.Count - 1
                        If dgMa_Bc_CN55.Rows(i).Cells("Ma_Nuoc").Text = dgMa_Nuoc_CN55.Rows(i).Cells("Ma_Nuoc").Text Then
                            'Print CN55 theo ma_bc
                            Print_CN55_Theo_Tung_Ma_Bc(Create_Ma_Quy(cbNam.Value, cbQuy.Value), cbNam.Value, dgMa_Bc_CN55.Rows(j).Cells("Ma_Bc").Text, cbMa_Bc_Khai_Thac.Value, False, dgMa_Nuoc_CN55.Rows(i).Cells("Ten_Nuoc").Text, dgMa_Bc_CN55.Rows(j).Cells("Ten_Bc").Text)
                        End If
                    Next
                    'Print CN56 theo ma_nuoc
                    Print_CN56_Theo_Tung_Ma_Nuoc(Create_Ma_Quy(cbNam.Value, cbQuy.Value), cbNam.Value, dgMa_Nuoc_CN55.Rows(i).Cells("Ma_Nuoc").Text, cbMa_Bc_Khai_Thac.Value, False, dgMa_Nuoc_CN55.Rows(i).Cells("Ten_Nuoc").Text)
                End If
            Next
        End If
        'Thong bao ket thuc
        MessageBox.Show("Đã in thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
#End Region

#Region "Print_CN55_Theo_Tung_Ma_Bc"
    Private Sub Print_CN55_Theo_Tung_Ma_Bc(ByVal mMa_Quy As Integer, ByVal mNam As Integer, ByVal mMa_Bc As Integer, ByVal mMa_Bc_Khai_Thac As Integer, ByVal mIs_Mien_Bac As Boolean, ByVal mTen_Nuoc As String, ByVal mTen_Bc As String)
        'Data
        Dim mAccounting_Du_Lieu_Quy_CN55 As New Accounting_Du_Lieu_Quy_CN55(GConnectionString)
        Dim mDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)
        Dim mDataSet As New DataSet
        Dim mTable As New DataTable

        'Report
        Dim FrmView As New FrmViewReports
        Dim rptVIEW As New RptKe_Toan_QT_Ban_Ke_CN55
        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue
        'Parametes
        Dim pTen_Nuoc As String
        Dim pBuu_Cuc_Gui As String
        Dim pBuu_Cuc_Nhan As String
        Dim pQuy As Integer
        Dim pNam As Integer
        Dim pNgay_Bao_Cao As Integer
        Dim pLoai_Ban_Ke As String

        'Lay du lieu chi tiet
        mTable = mAccounting_Du_Lieu_Quy_CN55.Accounting_Du_Lieu_Quy_CN55_Chi_Tiet_To_Print(mMa_Quy, mMa_Bc, mMa_Bc_Khai_Thac, mIs_Mien_Bac).Tables(0)
        'Dat ten table cho phu hop
        mTable.TableName = "Ban_Ke_CN55_Chi_Tiet"
        'Dua vao Dataset
        mDataSet.Tables.Add(mTable.Copy)

        'Lay gia tri cho Parametes
        pTen_Nuoc = mTen_Nuoc
        pvCollection.Clear()
        _pThamSo.Value = pTen_Nuoc
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("pTen_Nuoc").ApplyCurrentValues(pvCollection)

        pBuu_Cuc_Gui = mTen_Bc
        pvCollection.Clear()
        _pThamSo.Value = pBuu_Cuc_Gui
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("pBuu_Cuc_Gui").ApplyCurrentValues(pvCollection)

        Dim mTen_Bc_Khai_Thac As String
        mTen_Bc_Khai_Thac = mDanh_Muc_BC.Lay(cbMa_Bc_Khai_Thac.Value).Ten_Buu_Cuc
        pBuu_Cuc_Nhan = mTen_Bc_Khai_Thac
        pvCollection.Clear()
        _pThamSo.Value = pBuu_Cuc_Nhan
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("pBuu_Cuc_Nhan").ApplyCurrentValues(pvCollection)

        pQuy = cbQuy.Value
        pvCollection.Clear()
        _pThamSo.Value = pQuy.ToString
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("pQuy").ApplyCurrentValues(pvCollection)

        pNam = cbNam.Value
        pvCollection.Clear()
        _pThamSo.Value = pNam.ToString
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("pNam").ApplyCurrentValues(pvCollection)

        pNgay_Bao_Cao = myHamdungchung.ConvertDateToInt(Now().Date)
        pvCollection.Clear()
        _pThamSo.Value = myHamdungchung.ConvertIntToVNDateType(pNgay_Bao_Cao)
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("pNgay_Bao_Cao").ApplyCurrentValues(pvCollection)

        If mIs_Mien_Bac Then
            pLoai_Ban_Ke = "28 Northern Provinces"
        Else
            pLoai_Ban_Ke = ""
        End If
        pvCollection.Clear()
        _pThamSo.Value = pLoai_Ban_Ke
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("pLoai_Ban_Ke").ApplyCurrentValues(pvCollection)

        'Gan DataSource cho report
        rptVIEW.SetDataSource(mDataSet)

        FrmView.CrystalReportViewer1.ReportSource = rptVIEW
        Cursor.Current = Cursors.Default
        FrmView.ShowDialog()
        'If preview = True Then
        '    'Xem tren man hinh
        '    FrmView.ShowDialog()
        'Else
        '    'Dua ra may in
        '    rptVIEW.PrintToPrinter(soban, True, 0, 0)
        'End If
    End Sub
#End Region

#Region "Print_CN56_Theo_Tung_Ma_Nuoc"
    Private Sub Print_CN56_Theo_Tung_Ma_Nuoc(ByVal mMa_Quy As Integer, ByVal mNam As Integer, ByVal mMa_Nuoc As String, ByVal mMa_Bc_Khai_Thac As Integer, ByVal mIs_Mien_Bac As Boolean, ByVal mTen_Nuoc As String)
        'Data
        Dim mAccounting_Du_Lieu_Quy_CN55 As New Accounting_Du_Lieu_Quy_CN55(GConnectionString)
        Dim mDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)
        Dim mDataSet As New DataSet
        Dim mTable As New DataTable

        'Report
        Dim FrmView As New FrmViewReports
        Dim rptVIEW As New RptKe_Toan_QT_Ban_Ke_CN56
        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue
        'Parametes
        Dim pTen_Nuoc As String
        Dim pBuu_Cuc_Gui As String
        Dim pBuu_Cuc_Nhan As String
        Dim pQuy As Integer
        Dim pNam As Integer
        Dim pNgay_Bao_Cao As Integer
        Dim pLoai_Ban_Ke As String

        Dim pTieu_De_Cot_1 As String
        Dim pTieu_De_Cot_2 As String
        Dim pTieu_De_Cot_3 As String

        'Lay du lieu chi tiet
        mTable = mAccounting_Du_Lieu_Quy_CN55.Accounting_Du_Lieu_Quy_CN56_Chi_Tiet_To_Print(mMa_Quy, mMa_Nuoc, mMa_Bc_Khai_Thac, mIs_Mien_Bac).Tables(0)
        'Dat ten table cho phu hop
        mTable.TableName = "Ban_Ke_CN56_Chi_Tiet"
        'Dua vao Dataset
        mDataSet.Tables.Add(mTable.Copy)

        'Lay gia tri cho Parametes
        pTen_Nuoc = mTen_Nuoc
        pvCollection.Clear()
        _pThamSo.Value = pTen_Nuoc
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("pTen_Nuoc").ApplyCurrentValues(pvCollection)

        pQuy = cbQuy.Value
        pvCollection.Clear()
        _pThamSo.Value = pQuy.ToString
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("pQuy").ApplyCurrentValues(pvCollection)

        pNam = cbNam.Value
        pvCollection.Clear()
        _pThamSo.Value = pNam.ToString
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("pNam").ApplyCurrentValues(pvCollection)

        pNgay_Bao_Cao = myHamdungchung.ConvertDateToInt(Now().Date)
        pvCollection.Clear()
        _pThamSo.Value = myHamdungchung.ConvertIntToVNDateType(pNgay_Bao_Cao)
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("pNgay_Bao_Cao").ApplyCurrentValues(pvCollection)

        If mIs_Mien_Bac Then
            pLoai_Ban_Ke = "28 Northern Provinces"
        Else
            pLoai_Ban_Ke = ""
        End If
        pvCollection.Clear()
        _pThamSo.Value = pLoai_Ban_Ke
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("pLoai_Ban_Ke").ApplyCurrentValues(pvCollection)

        myAccounting_Danh_Muc_Quy_CN55_Chi_Tiet = myAccounting_Danh_Muc_Quy_CN55.Accounting_Danh_Muc_Quy_CN55_Lay(cbQuy.Value)
        pTieu_De_Cot_1 = myAccounting_Danh_Muc_Quy_CN55_Chi_Tiet.Column_1
        pvCollection.Clear()
        _pThamSo.Value = pTieu_De_Cot_1
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("pTieu_De_Cot_1").ApplyCurrentValues(pvCollection)

        pTieu_De_Cot_2 = myAccounting_Danh_Muc_Quy_CN55_Chi_Tiet.Column_2
        pvCollection.Clear()
        _pThamSo.Value = pTieu_De_Cot_2
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("pTieu_De_Cot_2").ApplyCurrentValues(pvCollection)

        pTieu_De_Cot_3 = myAccounting_Danh_Muc_Quy_CN55_Chi_Tiet.Column_3
        pvCollection.Clear()
        _pThamSo.Value = pTieu_De_Cot_3
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("pTieu_De_Cot_3").ApplyCurrentValues(pvCollection)

        'Gan DataSource cho report
        rptVIEW.SetDataSource(mDataSet)

        FrmView.CrystalReportViewer1.ReportSource = rptVIEW
        Cursor.Current = Cursors.Default
        FrmView.ShowDialog()
        'If preview = True Then
        '    'Xem tren man hinh
        '    FrmView.ShowDialog()
        'Else
        '    'Dua ra may in
        '    rptVIEW.PrintToPrinter(soban, True, 0, 0)
        'End If
    End Sub
#End Region

End Class

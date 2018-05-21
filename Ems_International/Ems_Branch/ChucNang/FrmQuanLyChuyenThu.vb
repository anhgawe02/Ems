Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Ems_International_Logic.EMS

Public Class FrmQuanLyChuyenThu
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
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btnThongTin As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpTuNgay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents dtpDenNgay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpNgayDinhDang As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents btnTruyen As System.Windows.Forms.Button
    Friend WithEvents chkAll As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbMa_Bc_Khai_Thac As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents tabControl As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents dgE2Den As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraDateTimeEditor1 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents ddLyDoPhat As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents dgE2Di As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents PrbTienTrinhTruyen As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("E2_Den_Tam", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chuyen_Thu")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ma_bc")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Dong")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chuyen_Thu")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_Tui")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_BP")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_KL")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ly_Do", -1)
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Ly_Do")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Ly_Do")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Ly_Do_EN")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("To_Hop_Xu_Ly")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("E2_Den_Tam", -1)
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chuyen_Thu")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Dong")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ma_bc")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chuyen_Thu")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_Tui")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_BP")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_KL")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Bc_Khai_Thac", -1)
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Bc_Khai_Thac")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OutBout")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmQuanLyChuyenThu))
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.dgE2Den = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraDateTimeEditor1 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.ddLyDoPhat = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.dgE2Di = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.dtpNgayDinhDang = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnThongTin = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpTuNgay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.dtpDenNgay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbMa_Bc_Khai_Thac = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.btnTruyen = New System.Windows.Forms.Button
        Me.chkAll = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.tabControl = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.PrbTienTrinhTruyen = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.dgE2Den, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDateTimeEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddLyDoPhat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.dgE2Di, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpNgayDinhDang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.dtpTuNgay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDenNgay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMa_Bc_Khai_Thac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.dgE2Den)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraDateTimeEditor1)
        Me.UltraTabPageControl1.Controls.Add(Me.ddLyDoPhat)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(2, 26)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(684, 412)
        '
        'dgE2Den
        '
        Me.dgE2Den.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgE2Den.DisplayLayout.AddNewBox.Prompt = " "
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgE2Den.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.Caption = "Bưu cục đóng"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.Header.Caption = "Ngày kế toán"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(85, 0)
        UltraGridColumn4.Header.Caption = "Chuyến thư"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(74, 0)
        UltraGridColumn5.Header.Caption = "Tổng túi"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn6.Header.Caption = "Số bưu Phẩm"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(72, 0)
        UltraGridColumn7.Header.Caption = "Khối lượng"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn8.Header.Caption = "Truyền"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8})
        UltraGridBand1.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Both
        UltraGridBand1.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Both
        UltraGridBand1.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        Me.dgE2Den.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.dgE2Den.DisplayLayout.InterBandSpacing = 10
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.dgE2Den.DisplayLayout.Override.CardAreaAppearance = Appearance2
        Me.dgE2Den.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.ForeColor = System.Drawing.Color.Black
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgE2Den.DisplayLayout.Override.HeaderAppearance = Appearance3
        Appearance4.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE2Den.DisplayLayout.Override.RowAppearance = Appearance4
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgE2Den.DisplayLayout.Override.RowSelectorAppearance = Appearance5
        Me.dgE2Den.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgE2Den.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance6.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.dgE2Den.DisplayLayout.Override.SelectedRowAppearance = Appearance6
        Me.dgE2Den.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE2Den.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgE2Den.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgE2Den.Location = New System.Drawing.Point(0, 0)
        Me.dgE2Den.Name = "dgE2Den"
        Me.dgE2Den.Size = New System.Drawing.Size(680, 408)
        Me.dgE2Den.TabIndex = 0
        '
        'UltraDateTimeEditor1
        '
        Me.UltraDateTimeEditor1.DateTime = New Date(2008, 8, 3, 0, 0, 0, 0)
        Me.UltraDateTimeEditor1.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.UltraDateTimeEditor1.Location = New System.Drawing.Point(424, 168)
        Me.UltraDateTimeEditor1.Name = "UltraDateTimeEditor1"
        Me.UltraDateTimeEditor1.Size = New System.Drawing.Size(88, 25)
        Me.UltraDateTimeEditor1.TabIndex = 1
        Me.UltraDateTimeEditor1.Value = New Date(2008, 8, 3, 0, 0, 0, 0)
        Me.UltraDateTimeEditor1.Visible = False
        '
        'ddLyDoPhat
        '
        Me.ddLyDoPhat.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance7.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddLyDoPhat.DisplayLayout.Appearance = Appearance7
        UltraGridColumn9.Header.VisiblePosition = 0
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 1
        UltraGridColumn10.Width = 200
        UltraGridColumn11.Header.VisiblePosition = 2
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 3
        UltraGridColumn12.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12})
        UltraGridBand2.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None
        UltraGridBand2.UseRowLayout = True
        Me.ddLyDoPhat.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance8.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance8.ForeColor = System.Drawing.Color.Black
        Appearance8.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddLyDoPhat.DisplayLayout.Override.HeaderAppearance = Appearance8
        Me.ddLyDoPhat.DisplayMember = ""
        Me.ddLyDoPhat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddLyDoPhat.Location = New System.Drawing.Point(24, 264)
        Me.ddLyDoPhat.Name = "ddLyDoPhat"
        Me.ddLyDoPhat.Size = New System.Drawing.Size(208, 80)
        Me.ddLyDoPhat.TabIndex = 2
        Me.ddLyDoPhat.ValueMember = ""
        Me.ddLyDoPhat.Visible = False
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.dgE2Di)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(684, 412)
        '
        'dgE2Di
        '
        Me.dgE2Di.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgE2Di.DisplayLayout.AddNewBox.Prompt = " "
        Appearance9.BackColor = System.Drawing.Color.White
        Appearance9.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgE2Di.DisplayLayout.Appearance = Appearance9
        UltraGridColumn13.Header.VisiblePosition = 0
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.Caption = "Ngày khai thác"
        UltraGridColumn14.Header.VisiblePosition = 1
        UltraGridColumn14.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(85, 0)
        UltraGridColumn15.Header.Caption = "Bưu cục nhận"
        UltraGridColumn15.Header.VisiblePosition = 2
        UltraGridColumn16.Header.Caption = "Chuyến thư"
        UltraGridColumn16.Header.VisiblePosition = 3
        UltraGridColumn16.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(74, 0)
        UltraGridColumn17.Header.Caption = "Số túi"
        UltraGridColumn17.Header.VisiblePosition = 4
        UltraGridColumn18.Header.Caption = "Số bưu phẩm"
        UltraGridColumn18.Header.VisiblePosition = 5
        UltraGridColumn18.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(72, 0)
        UltraGridColumn19.Header.Caption = "Khối Lượng"
        UltraGridColumn19.Header.VisiblePosition = 6
        UltraGridColumn20.Header.Caption = "Truyền"
        UltraGridColumn20.Header.VisiblePosition = 7
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20})
        UltraGridBand3.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Both
        UltraGridBand3.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Both
        UltraGridBand3.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        Me.dgE2Di.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.dgE2Di.DisplayLayout.InterBandSpacing = 10
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Me.dgE2Di.DisplayLayout.Override.CardAreaAppearance = Appearance10
        Me.dgE2Di.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance11.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance11.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance11.ForeColor = System.Drawing.Color.Black
        Appearance11.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance11.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgE2Di.DisplayLayout.Override.HeaderAppearance = Appearance11
        Appearance12.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE2Di.DisplayLayout.Override.RowAppearance = Appearance12
        Appearance13.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance13.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgE2Di.DisplayLayout.Override.RowSelectorAppearance = Appearance13
        Me.dgE2Di.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgE2Di.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance14.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance14.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance14.ForeColor = System.Drawing.Color.Black
        Me.dgE2Di.DisplayLayout.Override.SelectedRowAppearance = Appearance14
        Me.dgE2Di.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE2Di.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgE2Di.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgE2Di.Location = New System.Drawing.Point(0, 0)
        Me.dgE2Di.Name = "dgE2Di"
        Me.dgE2Di.Size = New System.Drawing.Size(680, 408)
        Me.dgE2Di.TabIndex = 58
        '
        'dtpNgayDinhDang
        '
        Me.dtpNgayDinhDang.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpNgayDinhDang.Location = New System.Drawing.Point(496, -8)
        Me.dtpNgayDinhDang.Name = "dtpNgayDinhDang"
        Me.dtpNgayDinhDang.Size = New System.Drawing.Size(88, 23)
        Me.dtpNgayDinhDang.TabIndex = 8
        Me.dtpNgayDinhDang.Visible = False
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.Label3)
        Me.UltraGroupBox1.Controls.Add(Me.btnThongTin)
        Me.UltraGroupBox1.Controls.Add(Me.Label2)
        Me.UltraGroupBox1.Controls.Add(Me.dtpTuNgay)
        Me.UltraGroupBox1.Controls.Add(Me.dtpDenNgay)
        Me.UltraGroupBox1.Controls.Add(Me.Label1)
        Me.UltraGroupBox1.Controls.Add(Me.cbMa_Bc_Khai_Thac)
        Me.UltraGroupBox1.Controls.Add(Me.btnTruyen)
        Me.UltraGroupBox1.Controls.Add(Me.dtpNgayDinhDang)
        Me.UltraGroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(672, 64)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.Text = "Thông tin ngày khai thác"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(256, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "BC Khai Thác"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnThongTin
        '
        Me.btnThongTin.Location = New System.Drawing.Point(448, 24)
        Me.btnThongTin.Name = "btnThongTin"
        Me.btnThongTin.Size = New System.Drawing.Size(104, 23)
        Me.btnThongTin.TabIndex = 3
        Me.btnThongTin.Text = "Lấy thông tin"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(112, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Đến"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpTuNgay
        '
        Me.dtpTuNgay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpTuNgay.Location = New System.Drawing.Point(8, 24)
        Me.dtpTuNgay.Name = "dtpTuNgay"
        Me.dtpTuNgay.Size = New System.Drawing.Size(96, 23)
        Me.dtpTuNgay.TabIndex = 0
        '
        'dtpDenNgay
        '
        Me.dtpDenNgay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpDenNgay.Location = New System.Drawing.Point(152, 24)
        Me.dtpDenNgay.Name = "dtpDenNgay"
        Me.dtpDenNgay.Size = New System.Drawing.Size(96, 23)
        Me.dtpDenNgay.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Từ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbMa_Bc_Khai_Thac
        '
        Me.cbMa_Bc_Khai_Thac.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance15.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.cbMa_Bc_Khai_Thac.DisplayLayout.Appearance = Appearance15
        UltraGridColumn21.Header.Caption = "Mã BC Khai Thác"
        UltraGridColumn21.Header.VisiblePosition = 2
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.Caption = "Tên BC Khai Thác"
        UltraGridColumn22.Header.VisiblePosition = 0
        UltraGridColumn23.Header.VisiblePosition = 1
        UltraGridColumn23.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn21, UltraGridColumn22, UltraGridColumn23})
        UltraGridBand4.Header.Caption = "Mã Ðu?ng Thu"
        Me.cbMa_Bc_Khai_Thac.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Appearance16.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance16.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance16.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance16.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbMa_Bc_Khai_Thac.DisplayLayout.Override.HeaderAppearance = Appearance16
        Me.cbMa_Bc_Khai_Thac.DisplayMember = "Ma_Bc_Khai_Thac"
        Me.cbMa_Bc_Khai_Thac.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMa_Bc_Khai_Thac.Location = New System.Drawing.Point(336, 24)
        Me.cbMa_Bc_Khai_Thac.Name = "cbMa_Bc_Khai_Thac"
        Me.cbMa_Bc_Khai_Thac.Size = New System.Drawing.Size(96, 21)
        Me.cbMa_Bc_Khai_Thac.TabIndex = 2
        Me.cbMa_Bc_Khai_Thac.ValueMember = "Ma_Bc_Khai_Thac"
        '
        'btnTruyen
        '
        Me.btnTruyen.Location = New System.Drawing.Point(560, 24)
        Me.btnTruyen.Name = "btnTruyen"
        Me.btnTruyen.Size = New System.Drawing.Size(104, 23)
        Me.btnTruyen.TabIndex = 4
        Me.btnTruyen.Text = "Truyền dữ liệu"
        '
        'chkAll
        '
        Appearance17.FontData.BoldAsString = "True"
        Me.chkAll.Appearance = Appearance17
        Me.chkAll.Location = New System.Drawing.Point(576, 520)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(96, 16)
        Me.chkAll.TabIndex = 70
        Me.chkAll.Text = "Chọn tất cả"
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tabControl.Controls.Add(Me.UltraTabPageControl1)
        Me.tabControl.Controls.Add(Me.UltraTabPageControl2)
        Me.tabControl.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabControl.Location = New System.Drawing.Point(0, 72)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tabControl.Size = New System.Drawing.Size(688, 440)
        Me.tabControl.TabIndex = 71
        Me.tabControl.TabLayoutStyle = Infragistics.Win.UltraWinTabs.TabLayoutStyle.SingleRowSizeToFit
        UltraTab1.Key = "0"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Chuyến Thư Đến"
        UltraTab2.Key = "1"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Chuyến Thư Đi"
        Me.tabControl.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(684, 412)
        '
        'PrbTienTrinhTruyen
        '
        Me.PrbTienTrinhTruyen.BorderStyle = Infragistics.Win.UIElementBorderStyle.InsetSoft
        Me.PrbTienTrinhTruyen.Location = New System.Drawing.Point(8, 520)
        Me.PrbTienTrinhTruyen.Maximum = 10000
        Me.PrbTienTrinhTruyen.Name = "PrbTienTrinhTruyen"
        Me.PrbTienTrinhTruyen.Size = New System.Drawing.Size(528, 32)
        Me.PrbTienTrinhTruyen.Step = 1
        Me.PrbTienTrinhTruyen.TabIndex = 72
        Me.PrbTienTrinhTruyen.Text = "[Formatted]"
        '
        'FrmQuanLyChuyenThu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(682, 559)
        Me.Controls.Add(Me.PrbTienTrinhTruyen)
        Me.Controls.Add(Me.tabControl)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.chkAll)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmQuanLyChuyenThu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản Lý Chuyến Thư"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.dgE2Den, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDateTimeEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddLyDoPhat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.dgE2Di, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpNgayDinhDang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.dtpTuNgay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDenNgay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMa_Bc_Khai_Thac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim myUtility As New Ems_Utility.Ems_Utility.Ems_MSMQ(GConnectionString)
    Dim myChuyen_Thu_Di As New Chuyen_Thu_Di(GConnectionString)
    Dim myChuyen_Thu_Den As New Chuyen_Thu_Den(GConnectionString)
    Dim myE1_Di As New E1_Di(GConnectionString)
    Dim myE1_Den As New E1_Den(GConnectionString)
    Dim myCODDi As New COD_Di(GConnectionString)
    Dim myMa_Bc_Khai_Thac As New Ma_Bc_Khai_Thac(GConnectionString)
    Dim myTrang_Thai As New Trang_Thai(GConnectionString)
    Dim myDuong_Thu_Den As New Duong_Thu_Den(GConnectionString)
    Dim myE2_Di As New E2_Di(GConnectionString)
    Dim myE2_Den As New E2_Den(GConnectionString)
    Dim myDuong_Thu_Di As New Duong_Thu_Di(GConnectionString)

    Dim myDuong_Thu_Di_Chi_Tiet As New Duong_Thu_Di_Chi_Tiet
    Dim myDuong_Thu_Den_Chi_Tiet As New Duong_Thu_Den_Chi_Tiet
    Dim myTab As Boolean
    Dim myHamDungChung As Ham_Dung_Chung

    Private Sub FrmQuanLyChuyenThu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpTuNgay.Value = Now.AddDays(-5)
        dtpDenNgay.Value = Now
        dtpTuNgay.Select()
    End Sub

    Private Sub tabControl_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles tabControl.SelectedTabChanged
        Dim i As Integer
        If e.Tab.Index = 0 Then
            myTab = False
            chkAll.Checked = False
            For i = 0 To dgE2Den.Rows.Count - 1
                dgE2Den.Rows(i).Cells("Truyen").Value = chkAll.Checked
            Next
            cbMa_Bc_Khai_Thac.DataSource = myMa_Bc_Khai_Thac.Danh_Sach
            cbMa_Bc_Khai_Thac.DataBind()
        End If
        If e.Tab.Index = 1 Then
            myTab = True
            For i = 0 To dgE2Di.Rows.Count - 1
                dgE2Di.Rows(i).Cells("Truyen").Value = chkAll.Checked
            Next
            'cbMa_Bc_Khai_Thac.Text = ""
            cbMa_Bc_Khai_Thac.DataSource = myMa_Bc_Khai_Thac.Danh_Sach
            cbMa_Bc_Khai_Thac.DataBind()
        End If
    End Sub
    Private Sub btnThongTin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThongTin.Click
        chkAll.Checked = False
        Dim TuNgay As Integer = myHamDungChung.ConvertDateToInt(dtpTuNgay.Value)
        Dim DenNgay As Integer = myHamDungChung.ConvertDateToInt(dtpDenNgay.Value)
        If cbMa_Bc_Khai_Thac.Text <> "" Then
            dgE2Den.DataSource = myChuyen_Thu_Den.Danh_Sach_Chuyen_Thu_Tu_Ngay_Den_Ngay(cbMa_Bc_Khai_Thac.Value, TuNgay, DenNgay)
            dgE2Den.DataBind()

            dgE2Di.DataSource = myChuyen_Thu_Di.Danh_Sach_Chuyen_Thu_Tu_Ngay_Den_Ngay_QlyChuyenThu(cbMa_Bc_Khai_Thac.Value, TuNgay, DenNgay)
            dgE2Di.DataBind()
        Else
            CMessageBox.Show("Bạn chưa chọn bưu cục khai thác")

            Exit Sub
        End If
    End Sub
    Private Sub btnTruyen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTruyen.Click
        Dim Row_Check As Integer
        Dim i As Integer
        If myTab Then  'Chuyen thu di
            If dgE2Di.Rows.Count = 0 Then
                MessageBox.Show("Không có dữ liệu truyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Row_Check = 0
            For i = 0 To dgE2Di.Rows.Count - 1
                If dgE2Di.Rows(i).Cells("Truyen").Value = True Then
                    Row_Check = Row_Check + 1
                End If
            Next
            If Row_Check = 0 Then
                MessageBox.Show("Bạn chưa chọn chuyến thư cần truyền. " & vbNewLine & "Hãy tích vào ô truyền tương ứng với chuyến thư trong danh mà bạn muốn truyền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If Row_Check = dgE2Di.Rows.Count Then
                If (MessageBox.Show("Nếu bạn đồng ý tất cả dữ liệu trong danh sách sẽ được truyền hết", "Thông báo", MessageBoxButtons.OKCancel) = DialogResult.Cancel) Then
                    Exit Sub
                End If
            End If
        Else 'chuyen thu den
            If dgE2Den.Rows.Count = 0 Then
                MessageBox.Show("Không có dữ liệu truyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Row_Check = 0
            For i = 0 To dgE2Den.Rows.Count - 1
                If dgE2Den.Rows(i).Cells("Truyen").Value = True Then
                    Row_Check = Row_Check + 1
                End If
            Next
            If Row_Check = 0 Then
                MessageBox.Show("Bạn chưa chọn chuyến thư cần truyền. " & vbNewLine & "Hãy tích vào ô truyền tương ứng với chuyến thư trong danh mà bạn muốn truyền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If Row_Check = dgE2Den.Rows.Count Then
                If (MessageBox.Show("Nếu bạn đồng ý tất cả dữ liệu trong danh sách sẽ được truyền hết", "Thông báo", MessageBoxButtons.OKCancel) = DialogResult.Cancel) Then
                    Exit Sub
                End If
            End If
        End If
        'Process Bar
        Me.ActiveForm.Cursor.Current = Cursors.WaitCursor
        PrbTienTrinhTruyen.Maximum = Row_Check
        PrbTienTrinhTruyen.Step = 1
        PrbTienTrinhTruyen.Value = 0
        'If (chkAll.Checked = True) Then
        '    If (MessageBox.Show("Nếu bạn đồng ý dữ liệu về chuyến thư sẽ được truyền hết", "Thông tin truyền", MessageBoxButtons.OKCancel) = DialogResult.Cancel) Then
        '        Exit Sub
        '    End If
        'End If
        Dim myDate As Date
        myDate = Now
        'Dim i As Integer
        Dim myId_Duong_Thu As String
        Dim myId_Chuyen_Thu As String
        Dim TuNgay As Integer = myHamDungChung.ConvertDateToInt(dtpTuNgay.Value)
        Dim DenNgay As Integer = myHamDungChung.ConvertDateToInt(dtpDenNgay.Value)
        Dim myIdChuyenThu As String
        If myTab = True Then 'Truyền thông tin đi
            Try
                Dim num As Integer = 0
                Dim OK As Boolean = False
                For i = 0 To dgE2Di.Rows.Count - 1
                    If dgE2Di.Rows(i).Cells("Truyen").Value = True Then
                        PrbTienTrinhTruyen.PerformStep()
                        myDate = DateAdd(DateInterval.Minute, 1, myDate)
                        Dim mydataset As New DataSet
                        Dim mytable As New DataTable
                        OK = True
                        'Chuyen thu
                        mytable = myChuyen_Thu_Di.Danh_Sach_Chuyen_Thu_Lay_Boi_Id_Chuyen_Thu_Truyen_Lai(dgE2Di.Rows(i).Cells("Id_Chuyen_Thu").Text).Tables(0)
                        mytable.TableName = "Chuyen_Thu"
                        mydataset.Tables.Add(mytable.Copy)
                        'E2_Di
                        mytable = myE2_Di.Danh_Sach_E2_Truyen(dgE2Di.Rows(i).Cells("Id_Chuyen_Thu").Text).Tables(0)
                        mytable.TableName = "E2"
                        mydataset.Tables.Add(mytable.Copy)
                        'E1_Di
                        mytable = myE1_Di.Danh_Sach_E1_Truyen(dgE2Di.Rows(i).Cells("Id_Chuyen_Thu").Text).Tables(0)
                        mytable.TableName = "E1"
                        mydataset.Tables.Add(mytable.Copy)
                        ' truyền dữ liệu thay GBuu_Cuc_Khai_Thac bằng cmbBuu_Cuc_Khai_Thac để không phải đăng nhập lại vào các account khác nhau
                        'myUtility.Dang_Ky_Truyen("Ems_E2", "Branch", "PO", GBuu_Cuc_Khai_Thac, dgE2Di.Rows(i).Cells("ma_bc").Text, myHamDungChung.ConvertDateToInt(Now), myHamDungChung.ConvertTimeToInt(myDate), "", mydataset)
                        myUtility.Dang_Ky_Truyen("Ems_E2", "Branch", "PO", Convert.ToInt32(cbMa_Bc_Khai_Thac.Value), dgE2Di.Rows(i).Cells("ma_bc").Text, myHamDungChung.ConvertDateToInt(Now), myHamDungChung.ConvertTimeToInt(myDate), "", mydataset)
                        num = num + Convert.ToInt32(dgE2Di.Rows(i).Cells("Tong_So_BP").Text)
                    End If
                    PrbTienTrinhTruyen.Text = "( " & PrbTienTrinhTruyen.Value & "  /  " & PrbTienTrinhTruyen.Maximum & " )"
                    Application.DoEvents()
                Next
                Me.ActiveForm.Cursor.Current = Cursors.Default
                If OK Then
                    CMessageBox.Show(Convert.ToString(num) + " Bưu phẩm đã được truyền thành công.", "Thông báo", MessageBoxButtons.OK)
                    For i = 0 To dgE2Di.Rows.Count - 1
                        dgE2Di.Rows(i).Cells("Truyen").Value = False
                    Next
                    If (chkAll.Checked = True) Then
                        chkAll.Checked = False
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else ' Truyền thông tin đến
            Try
                Dim num As Integer = 0
                Dim OK As Boolean = False
                For i = 0 To dgE2Den.Rows.Count - 1
                    If dgE2Den.Rows(i).Cells("Truyen").Value = True Then
                        PrbTienTrinhTruyen.PerformStep()
                        myDate = DateAdd(DateInterval.Minute, 1, myDate)
                        Dim mydataset As New DataSet
                        Dim mytable As New DataTable
                        OK = True
                        'Chuyen_Thu_Den
                        mytable = myChuyen_Thu_Den.Danh_Sach_Chuyen_Thu_Lay_Boi_Id_Chuyen_Thu_Truyen(dgE2Den.Rows(i).Cells("Id_Chuyen_Thu").Text).Tables(0)
                        mytable.TableName = "Chuyen_Thu"
                        mydataset.Tables.Add(mytable.Copy)
                        'E2_Den
                        mytable = myE2_Den.Danh_Sach_E2_Truyen(dgE2Den.Rows(i).Cells("Id_Chuyen_Thu").Text).Tables(0)
                        mytable.TableName = "E2"
                        mydataset.Tables.Add(mytable.Copy)
                        'E1_Den
                        mytable = myE1_Den.Danh_Sach_E1_Truyen(dgE2Den.Rows(i).Cells("Id_Chuyen_Thu").Text).Tables(0)
                        mytable.TableName = "E1"
                        mydataset.Tables.Add(mytable.Copy)
                        ' Truyền dữ liệu 
                        myUtility.Dang_Ky_Truyen("Ems_E2_Den", "Branch", "PO", Convert.ToInt32(cbMa_Bc_Khai_Thac.Value), dgE2Den.Rows(i).Cells("ma_bc").Text, myHamDungChung.ConvertDateToInt(Now), myHamDungChung.ConvertTimeToInt(myDate), "", mydataset)
                        num = num + Convert.ToInt32(dgE2Den.Rows(i).Cells("Tong_So_BP").Text)
                    End If
                    PrbTienTrinhTruyen.Text = "( " & PrbTienTrinhTruyen.Value & "  /  " & PrbTienTrinhTruyen.Maximum & " )"
                    Application.DoEvents()
                Next
                Me.ActiveForm.Cursor.Current = Cursors.Default
                If OK Then
                    CMessageBox.Show(Convert.ToString(num) + " Bưu phẩm đã được truyền thành công.", "Thông báo", MessageBoxButtons.OK)
                    For i = 0 To dgE2Den.Rows.Count - 1
                        dgE2Den.Rows(i).Cells("Truyen").Value = False
                    Next
                    If (chkAll.Checked = True) Then
                        chkAll.Checked = False
                    End If

                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
    Private Sub chkAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAll.CheckedChanged
        Dim i As Integer
        If myTab = True Then
            For i = 0 To dgE2Di.Rows.Count - 1
                dgE2Di.Rows(i).Cells("Truyen").Value = chkAll.Checked
            Next
        Else
            For i = 0 To dgE2Den.Rows.Count - 1
                dgE2Den.Rows(i).Cells("Truyen").Value = chkAll.Checked
            Next
        End If
    End Sub

#Region "Combo_KeyDown"
    Private Sub Combo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpTuNgay.KeyDown, dtpDenNgay.KeyDown, cbMa_Bc_Khai_Thac.KeyDown
        Select Case e.KeyValue
            Case 13 'Key Enter
                Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
            Case 37 'Key Left

            Case Else
        End Select
    End Sub
#End Region

#Region "FrmQuanLyChuyenThu_KeyPress"
    Private Sub FrmQuanLyChuyenThu_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
            End If
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region




End Class

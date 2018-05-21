Imports Ems_International_Logic.EMS
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports System.Diagnostics
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Math

Public Class FrmIn_Nhan_E4_Label
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
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents chkALL As System.Windows.Forms.CheckBox
    Friend WithEvents dtpNgay_KT As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents btnIn_Nhan_E4 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnThong_Tin As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnThoat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents cbLoai_DL As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents opt1 As System.Windows.Forms.RadioButton
    Friend WithEvents opt2 As System.Windows.Forms.RadioButton
    Friend WithEvents opt3 As System.Windows.Forms.RadioButton
    Friend WithEvents opt4 As System.Windows.Forms.RadioButton
    Friend WithEvents opt6 As System.Windows.Forms.RadioButton
    Friend WithEvents opt5 As System.Windows.Forms.RadioButton
    Friend WithEvents opt7 As System.Windows.Forms.RadioButton
    Friend WithEvents opt8 As System.Windows.Forms.RadioButton
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents dgDanh_Sach_In_E4 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents mnuMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuTimKiem As System.Windows.Forms.MenuItem
    Friend WithEvents btnPreview As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("E2_Di", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E2")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chon")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Dong")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Gui")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Nhan")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Buu_Cuc_Gui")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Buu_Cuc_Nhan")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chuyen_Thu")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tui_So")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_BP")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong_BP")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tui_F")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Tui_Thu")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Loai_Du_Lieu", -1)
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Phan_Loai")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Phan_Loai")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmIn_Nhan_E4_Label))
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.dtpNgay_KT = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.btnIn_Nhan_E4 = New Infragistics.Win.Misc.UltraButton
        Me.dgDanh_Sach_In_E4 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.chkALL = New System.Windows.Forms.CheckBox
        Me.btnThong_Tin = New Infragistics.Win.Misc.UltraButton
        Me.btnThoat = New Infragistics.Win.Misc.UltraButton
        Me.cbLoai_DL = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.opt7 = New System.Windows.Forms.RadioButton
        Me.opt8 = New System.Windows.Forms.RadioButton
        Me.opt3 = New System.Windows.Forms.RadioButton
        Me.opt4 = New System.Windows.Forms.RadioButton
        Me.opt1 = New System.Windows.Forms.RadioButton
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.opt2 = New System.Windows.Forms.RadioButton
        Me.Button6 = New System.Windows.Forms.Button
        Me.opt6 = New System.Windows.Forms.RadioButton
        Me.opt5 = New System.Windows.Forms.RadioButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.lblInfo = New System.Windows.Forms.Label
        Me.mnuMenu = New System.Windows.Forms.ContextMenu
        Me.mnuTimKiem = New System.Windows.Forms.MenuItem
        Me.btnPreview = New Infragistics.Win.Misc.UltraButton
        CType(Me.dtpNgay_KT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDanh_Sach_In_E4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbLoai_DL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(664, 12)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(104, 14)
        Me.UltraLabel4.TabIndex = 0
        Me.UltraLabel4.Text = "Ngày đóng"
        '
        'dtpNgay_KT
        '
        Me.dtpNgay_KT.DateTime = New Date(2008, 9, 9, 0, 0, 0, 0)
        Me.dtpNgay_KT.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgay_KT.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpNgay_KT.Location = New System.Drawing.Point(664, 32)
        Me.dtpNgay_KT.Name = "dtpNgay_KT"
        Me.dtpNgay_KT.Size = New System.Drawing.Size(112, 23)
        Me.dtpNgay_KT.TabIndex = 1
        Me.dtpNgay_KT.Value = New Date(2008, 9, 9, 0, 0, 0, 0)
        '
        'btnIn_Nhan_E4
        '
        Me.btnIn_Nhan_E4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIn_Nhan_E4.Location = New System.Drawing.Point(664, 464)
        Me.btnIn_Nhan_E4.Name = "btnIn_Nhan_E4"
        Me.btnIn_Nhan_E4.Size = New System.Drawing.Size(112, 32)
        Me.btnIn_Nhan_E4.TabIndex = 8
        Me.btnIn_Nhan_E4.Text = "&In nhãn E4"
        '
        'dgDanh_Sach_In_E4
        '
        Me.dgDanh_Sach_In_E4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgDanh_Sach_In_E4.DisplayLayout.AddNewBox.Prompt = " "
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgDanh_Sach_In_E4.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn1.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn1.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn1.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn2.Header.Caption = "Chọn"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn2.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(48, 0)
        UltraGridColumn2.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn2.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance2.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn3.Header.Appearance = Appearance2
        UltraGridColumn3.Header.Caption = "Ngày đóng"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn3.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(97, 0)
        UltraGridColumn3.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn3.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn4.Header.Caption = "BC Gửi"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn4.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(68, 0)
        UltraGridColumn4.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn4.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn5.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True
        UltraGridColumn5.Header.Caption = "BC Nhận"
        UltraGridColumn5.Header.VisiblePosition = 5
        UltraGridColumn5.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn5.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn5.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(68, 0)
        UltraGridColumn5.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn5.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn6.Header.VisiblePosition = 6
        UltraGridColumn6.Hidden = True
        UltraGridColumn6.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn6.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn6.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn6.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn7.Header.VisiblePosition = 7
        UltraGridColumn7.Hidden = True
        UltraGridColumn7.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn7.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn7.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn7.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn8.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn8.Header.Appearance = Appearance3
        UltraGridColumn8.Header.Caption = "Chuyến thư"
        UltraGridColumn8.Header.VisiblePosition = 4
        UltraGridColumn8.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn8.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn8.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(74, 0)
        UltraGridColumn8.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn8.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance4.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn9.Header.Appearance = Appearance4
        UltraGridColumn9.Header.Caption = "Túi số"
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn9.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn9.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(56, 0)
        UltraGridColumn9.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn9.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance5.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn10.Header.Appearance = Appearance5
        UltraGridColumn10.Header.Caption = "Tổng số"
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn10.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn10.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(72, 0)
        UltraGridColumn10.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn10.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance6.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn11.Header.Appearance = Appearance6
        UltraGridColumn11.Header.Caption = "Khối lượng túi"
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn11.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn11.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(87, 0)
        UltraGridColumn11.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn11.RowLayoutColumnInfo.SpanY = 2
        Appearance7.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn12.Header.Appearance = Appearance7
        UltraGridColumn12.Header.Caption = "Túi F"
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn12.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn12.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(44, 0)
        UltraGridColumn12.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn12.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn13.Header.Caption = "Mã vạch túi"
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn13.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn13.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(252, 0)
        UltraGridColumn13.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn13.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13})
        UltraGridBand1.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Both
        UltraGridBand1.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Both
        UltraGridBand1.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand1.UseRowLayout = True
        Me.dgDanh_Sach_In_E4.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.dgDanh_Sach_In_E4.DisplayLayout.InterBandSpacing = 10
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Me.dgDanh_Sach_In_E4.DisplayLayout.Override.CardAreaAppearance = Appearance8
        Me.dgDanh_Sach_In_E4.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance9.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance9.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance9.ForeColor = System.Drawing.Color.Black
        Appearance9.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance9.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgDanh_Sach_In_E4.DisplayLayout.Override.HeaderAppearance = Appearance9
        Appearance10.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDanh_Sach_In_E4.DisplayLayout.Override.RowAppearance = Appearance10
        Appearance11.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance11.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgDanh_Sach_In_E4.DisplayLayout.Override.RowSelectorAppearance = Appearance11
        Me.dgDanh_Sach_In_E4.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgDanh_Sach_In_E4.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance12.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance12.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance12.ForeColor = System.Drawing.Color.Black
        Me.dgDanh_Sach_In_E4.DisplayLayout.Override.SelectedRowAppearance = Appearance12
        Me.dgDanh_Sach_In_E4.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDanh_Sach_In_E4.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgDanh_Sach_In_E4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDanh_Sach_In_E4.Location = New System.Drawing.Point(0, 32)
        Me.dgDanh_Sach_In_E4.Name = "dgDanh_Sach_In_E4"
        Me.dgDanh_Sach_In_E4.Size = New System.Drawing.Size(656, 544)
        Me.dgDanh_Sach_In_E4.TabIndex = 11
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(200, 10)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(296, 23)
        Me.UltraLabel1.TabIndex = 12
        Me.UltraLabel1.Text = "DANH SÁCH TÚI GÓI CHỜ IN NHÃN E4"
        '
        'chkALL
        '
        Me.chkALL.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkALL.Location = New System.Drawing.Point(16, 7)
        Me.chkALL.Name = "chkALL"
        Me.chkALL.TabIndex = 10
        Me.chkALL.Text = "Chọn tất cả"
        '
        'btnThong_Tin
        '
        Me.btnThong_Tin.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThong_Tin.Location = New System.Drawing.Point(664, 112)
        Me.btnThong_Tin.Name = "btnThong_Tin"
        Me.btnThong_Tin.Size = New System.Drawing.Size(112, 32)
        Me.btnThong_Tin.TabIndex = 6
        Me.btnThong_Tin.Text = "&Hiển thị dữ liệu"
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Location = New System.Drawing.Point(664, 536)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(112, 32)
        Me.btnThoat.TabIndex = 9
        Me.btnThoat.Text = "&Thoát"
        '
        'cbLoai_DL
        '
        Me.cbLoai_DL.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn14.Header.Caption = ""
        UltraGridColumn14.Header.VisiblePosition = 0
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.Caption = ""
        UltraGridColumn15.Header.VisiblePosition = 1
        UltraGridColumn15.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(121, 0)
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn14, UltraGridColumn15})
        UltraGridBand2.UseRowLayout = True
        Me.cbLoai_DL.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.cbLoai_DL.DisplayMember = "Ten_Phan_Loai"
        Me.cbLoai_DL.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLoai_DL.Location = New System.Drawing.Point(664, 83)
        Me.cbLoai_DL.Name = "cbLoai_DL"
        Me.cbLoai_DL.Size = New System.Drawing.Size(112, 23)
        Me.cbLoai_DL.TabIndex = 5
        Me.cbLoai_DL.ValueMember = "Id_Phan_Loai"
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(664, 64)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(104, 14)
        Me.UltraLabel3.TabIndex = 4
        Me.UltraLabel3.Text = "Chọn loại dữ liệu"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.opt7)
        Me.UltraGroupBox1.Controls.Add(Me.opt8)
        Me.UltraGroupBox1.Controls.Add(Me.opt3)
        Me.UltraGroupBox1.Controls.Add(Me.opt4)
        Me.UltraGroupBox1.Controls.Add(Me.opt1)
        Me.UltraGroupBox1.Controls.Add(Me.Button7)
        Me.UltraGroupBox1.Controls.Add(Me.Button8)
        Me.UltraGroupBox1.Controls.Add(Me.Button3)
        Me.UltraGroupBox1.Controls.Add(Me.Button4)
        Me.UltraGroupBox1.Controls.Add(Me.Button5)
        Me.UltraGroupBox1.Controls.Add(Me.opt2)
        Me.UltraGroupBox1.Controls.Add(Me.Button6)
        Me.UltraGroupBox1.Controls.Add(Me.opt6)
        Me.UltraGroupBox1.Controls.Add(Me.opt5)
        Me.UltraGroupBox1.Controls.Add(Me.Button1)
        Me.UltraGroupBox1.Controls.Add(Me.Button2)
        Me.UltraGroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Appearance13.ForeColor = System.Drawing.Color.Red
        Me.UltraGroupBox1.HeaderAppearance = Appearance13
        Me.UltraGroupBox1.Location = New System.Drawing.Point(664, 192)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(112, 272)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 7
        Me.UltraGroupBox1.Text = "Chọn thứ tự stick bắt đầu in E4"
        '
        'opt7
        '
        Me.opt7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt7.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.opt7.Location = New System.Drawing.Point(16, 224)
        Me.opt7.Name = "opt7"
        Me.opt7.Size = New System.Drawing.Size(32, 24)
        Me.opt7.TabIndex = 6
        Me.opt7.Text = "7"
        '
        'opt8
        '
        Me.opt8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt8.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.opt8.Location = New System.Drawing.Point(64, 224)
        Me.opt8.Name = "opt8"
        Me.opt8.Size = New System.Drawing.Size(32, 24)
        Me.opt8.TabIndex = 7
        Me.opt8.Text = "8"
        '
        'opt3
        '
        Me.opt3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.opt3.Location = New System.Drawing.Point(16, 112)
        Me.opt3.Name = "opt3"
        Me.opt3.Size = New System.Drawing.Size(32, 24)
        Me.opt3.TabIndex = 2
        Me.opt3.Text = "3"
        '
        'opt4
        '
        Me.opt4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.opt4.Location = New System.Drawing.Point(64, 112)
        Me.opt4.Name = "opt4"
        Me.opt4.Size = New System.Drawing.Size(32, 24)
        Me.opt4.TabIndex = 3
        Me.opt4.Text = "4"
        '
        'opt1
        '
        Me.opt1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.opt1.Location = New System.Drawing.Point(16, 56)
        Me.opt1.Name = "opt1"
        Me.opt1.Size = New System.Drawing.Size(32, 24)
        Me.opt1.TabIndex = 0
        Me.opt1.Text = "1"
        '
        'Button7
        '
        Me.Button7.Enabled = False
        Me.Button7.Location = New System.Drawing.Point(56, 208)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(48, 56)
        Me.Button7.TabIndex = 15
        '
        'Button8
        '
        Me.Button8.Enabled = False
        Me.Button8.Location = New System.Drawing.Point(8, 208)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(48, 56)
        Me.Button8.TabIndex = 14
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(8, 96)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(48, 56)
        Me.Button3.TabIndex = 10
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(56, 96)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(48, 56)
        Me.Button4.TabIndex = 11
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.Location = New System.Drawing.Point(8, 40)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(48, 56)
        Me.Button5.TabIndex = 8
        '
        'opt2
        '
        Me.opt2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.opt2.Location = New System.Drawing.Point(64, 56)
        Me.opt2.Name = "opt2"
        Me.opt2.Size = New System.Drawing.Size(32, 24)
        Me.opt2.TabIndex = 1
        Me.opt2.Text = "2"
        '
        'Button6
        '
        Me.Button6.Enabled = False
        Me.Button6.Location = New System.Drawing.Point(56, 40)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(48, 56)
        Me.Button6.TabIndex = 9
        '
        'opt6
        '
        Me.opt6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt6.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.opt6.Location = New System.Drawing.Point(64, 168)
        Me.opt6.Name = "opt6"
        Me.opt6.Size = New System.Drawing.Size(32, 24)
        Me.opt6.TabIndex = 5
        Me.opt6.Text = "6"
        '
        'opt5
        '
        Me.opt5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt5.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.opt5.Location = New System.Drawing.Point(16, 168)
        Me.opt5.Name = "opt5"
        Me.opt5.Size = New System.Drawing.Size(32, 24)
        Me.opt5.TabIndex = 4
        Me.opt5.Text = "5"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(8, 152)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 56)
        Me.Button1.TabIndex = 12
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(56, 152)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 56)
        Me.Button2.TabIndex = 13
        '
        'lblInfo
        '
        Me.lblInfo.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblInfo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(255, Byte), CType(128, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(664, 149)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(112, 40)
        Me.lblInfo.TabIndex = 13
        Me.lblInfo.Text = "Label1"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mnuMenu
        '
        Me.mnuMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuTimKiem})
        '
        'mnuTimKiem
        '
        Me.mnuTimKiem.Index = 0
        Me.mnuTimKiem.Text = "Tìm kiếm"
        '
        'btnPreview
        '
        Me.btnPreview.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.Location = New System.Drawing.Point(664, 500)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(112, 32)
        Me.btnPreview.TabIndex = 14
        Me.btnPreview.Text = "&Xem màn hình"
        '
        'FrmIn_Nhan_E4_Label
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.cbLoai_DL)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnThong_Tin)
        Me.Controls.Add(Me.dgDanh_Sach_In_E4)
        Me.Controls.Add(Me.chkALL)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.btnIn_Nhan_E4)
        Me.Controls.Add(Me.UltraLabel4)
        Me.Controls.Add(Me.dtpNgay_KT)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmIn_Nhan_E4_Label"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmIn_Nhan_E4_Label"
        CType(Me.dtpNgay_KT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDanh_Sach_In_E4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbLoai_DL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Khai báo biến toàn form"
    Dim myE2_Di As New E2_Di(GConnectionString)
    Dim myQLTGND_E2_Di As New QLTGND_E2_Di(GConnectionString)
    Dim myHam_Dung_Chung As New Ham_Dung_Chung
    Dim FrmTK As FrmTimKiemDanhMuc = Nothing
    Dim myColumn As Infragistics.Win.UltraWinGrid.UltraGridColumn = Nothing
    Dim myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Dim myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
#End Region

#Region "TabControl"
#Region "FrmIn_Nhan_E4_Label_Load"
    Private Sub FrmIn_Nhan_E4_Label_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Quản lý In nhãn E4"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MaximizeBox = False
        Load_Data()
        btnThong_Tin_Click(btnThong_Tin, Nothing)
        Refresh_Info()
        opt1.Checked = True
    End Sub
#End Region
#Region "btnThong_Tin_Click"
    Private Sub btnThong_Tin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThong_Tin.Click
        Try
            If dtpNgay_KT.Value > Now.Date Then
                MessageBox.Show("Ngày đóng chọn để lấy danh sách túi gói không được lớn hơn ngày hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtpNgay_KT.Select()
                Exit Sub
            End If
            'If myHam_Dung_Chung.ConvertDateToInt(dtpNgay_KT.Value) < myHam_Dung_Chung.MinusIntDate(myHam_Dung_Chung.ConvertDateToInt(Now.Date), 1) Then
            '    MessageBox.Show("Ngày đóng chọn để lấy danh sách túi gói không được nhỏ hơn ngày hiện tại quá 1 ngày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    dtpNgay_KT.Select()
            '    Exit Sub
            'End If
            If cbLoai_DL.Value Is DBNull.Value Then
                MessageBox.Show("Bạn phải chọn loại dữ liệu cần hiển thị thông tin trong danh sách loại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cbLoai_DL.Select()
                Exit Sub
            End If
            Dim mData As DataTable
            Select Case cbLoai_DL.Value
                Case 1  'Chưa in
                    mData = myE2_Di.QLTGND_Danh_Sach_Tui_Goi_Theo_Ngay_Dong_Chua_In_E4_Label(myHam_Dung_Chung.ConvertDateToInt(dtpNgay_KT.Value)).Tables(0)
                Case 2  'Đã in
                    mData = myE2_Di.QLTGND_Danh_Sach_Tui_Goi_Theo_Ngay_Dong_Da_In_E4_Label(myHam_Dung_Chung.ConvertDateToInt(dtpNgay_KT.Value)).Tables(0)
                Case 3  'Tất cả
                    mData = myE2_Di.QLTGND_Danh_Sach_Tat_Ca_Tui_Goi_Theo_Ngay_Dong(myHam_Dung_Chung.ConvertDateToInt(dtpNgay_KT.Value)).Tables(0)
            End Select
            If mData.Rows.Count = 0 Then
                MessageBox.Show("Không có dữ liệu theo yêu cầu, kiểm tra lại thông tin ngày đóng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            dgDanh_Sach_In_E4.DataSource = mData
            dgDanh_Sach_In_E4.DataBind()
            Refresh_Info()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "chkALL_CheckedChanged"
    Private Sub chkALL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkALL.CheckedChanged
        Try
            Dim idx As Integer
            For idx = 0 To dgDanh_Sach_In_E4.Rows.Count - 1
                myGridKeyDown.Rows(idx).Cells("Chon").Value = chkALL.Checked
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "btnIn_Nhan_E4_Click"
    Private Sub btnIn_Nhan_E4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIn_Nhan_E4.Click
        Dim idx As Integer
        Dim mE2_Di_Chi_Tiet As New E2_Di_Chi_Tiet
        Dim mQLTGND_E2_Di_Chi_Tiet As New QLTGND_E2_Di_Chi_Tiet
        Try
            If In_Nhan_E4_Label_Theo_E2_Duoc_Chon() Then
                Cursor.Current = Cursors.WaitCursor
                For idx = 0 To dgDanh_Sach_In_E4.Rows.Count - 1
                    If dgDanh_Sach_In_E4.Rows(idx).Cells("Chon").Value Then
                        'Lay thong tin trong E2_Di
                        mE2_Di_Chi_Tiet = myE2_Di.Lay(dgDanh_Sach_In_E4.Rows(idx).Cells("Id_E2").Text)
                        'Neu co thong tin E2_Di
                        If mE2_Di_Chi_Tiet.Id_E2 <> "" Then
                            'Truyen vao bien
                            mQLTGND_E2_Di_Chi_Tiet.Id_E2 = mE2_Di_Chi_Tiet.Id_E2
                            mQLTGND_E2_Di_Chi_Tiet.Id_Giao_Nhan = ""
                            mQLTGND_E2_Di_Chi_Tiet.Id_Tui_Thu = dgDanh_Sach_In_E4.Rows(idx).Cells("Id_Tui_Thu").Text
                            mQLTGND_E2_Di_Chi_Tiet.STT = 0
                            mQLTGND_E2_Di_Chi_Tiet.Truyen_Khai_Thac = 0
                            mQLTGND_E2_Di_Chi_Tiet.Truyen_Doi_Soat = 1   'cập nhật là đã in nhãn rồi
                            mQLTGND_E2_Di_Chi_Tiet.Chot_SL = 0
                            mQLTGND_E2_Di_Chi_Tiet.Ngay_He_Thong = myHam_Dung_Chung.ConvertDateToInt(Now.Date())
                            mQLTGND_E2_Di_Chi_Tiet.Gio_He_Thong = myHam_Dung_Chung.ConvertTimeToInt(Now.Date())
                            'Cap nhat vao bang QLTGND_E2_Di
                            myQLTGND_E2_Di.QLTGND_E2_Di_Cap_Nhat_Them(mQLTGND_E2_Di_Chi_Tiet.Id_E2, mQLTGND_E2_Di_Chi_Tiet.Id_Giao_Nhan, mQLTGND_E2_Di_Chi_Tiet.Id_Tui_Thu, mQLTGND_E2_Di_Chi_Tiet.STT, mQLTGND_E2_Di_Chi_Tiet.Truyen_Khai_Thac, mQLTGND_E2_Di_Chi_Tiet.Truyen_Doi_Soat, mQLTGND_E2_Di_Chi_Tiet.Chot_SL, mQLTGND_E2_Di_Chi_Tiet.Ngay_He_Thong, mQLTGND_E2_Di_Chi_Tiet.Gio_He_Thong)
                            dgDanh_Sach_In_E4.Rows(idx).Cells("Chon").Value = False
                            dgDanh_Sach_In_E4.ActiveRow = dgDanh_Sach_In_E4.Rows(idx)
                        End If
                    End If
                    'Application.DoEvents()
                Next
                Cursor.Current = Cursors.Default
                MessageBox.Show("Quá trình in và cập nhật túi gói đã hoàn tất!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "btnPreview_Click"
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Dim idx As Integer
        Dim mE2_Di_Chi_Tiet As New E2_Di_Chi_Tiet
        Dim mQLTGND_E2_Di_Chi_Tiet As New QLTGND_E2_Di_Chi_Tiet
        Try
            If Preview_Nhan_E4_Label_Theo_E2_Duoc_Chon() Then
                Cursor.Current = Cursors.WaitCursor
                For idx = 0 To dgDanh_Sach_In_E4.Rows.Count - 1
                    If dgDanh_Sach_In_E4.Rows(idx).Cells("Chon").Value Then
                        'Lay thong tin trong E2_Di
                        mE2_Di_Chi_Tiet = myE2_Di.Lay(dgDanh_Sach_In_E4.Rows(idx).Cells("Id_E2").Text)
                        'Neu co thong tin E2_Di
                        If mE2_Di_Chi_Tiet.Id_E2 <> "" Then
                            'Truyen vao bien
                            mQLTGND_E2_Di_Chi_Tiet.Id_E2 = mE2_Di_Chi_Tiet.Id_E2
                            mQLTGND_E2_Di_Chi_Tiet.Id_Giao_Nhan = ""
                            mQLTGND_E2_Di_Chi_Tiet.Id_Tui_Thu = dgDanh_Sach_In_E4.Rows(idx).Cells("Id_Tui_Thu").Text
                            mQLTGND_E2_Di_Chi_Tiet.STT = 0
                            mQLTGND_E2_Di_Chi_Tiet.Truyen_Khai_Thac = 0
                            mQLTGND_E2_Di_Chi_Tiet.Truyen_Doi_Soat = 0
                            mQLTGND_E2_Di_Chi_Tiet.Chot_SL = 0
                            mQLTGND_E2_Di_Chi_Tiet.Ngay_He_Thong = myHam_Dung_Chung.ConvertDateToInt(Now.Date())
                            mQLTGND_E2_Di_Chi_Tiet.Gio_He_Thong = myHam_Dung_Chung.ConvertTimeToInt(Now.Date())
                            'Cap nhat vao bang QLTGND_E2_Di
                            myQLTGND_E2_Di.QLTGND_E2_Di_Cap_Nhat_Them(mQLTGND_E2_Di_Chi_Tiet.Id_E2, mQLTGND_E2_Di_Chi_Tiet.Id_Giao_Nhan, mQLTGND_E2_Di_Chi_Tiet.Id_Tui_Thu, mQLTGND_E2_Di_Chi_Tiet.STT, mQLTGND_E2_Di_Chi_Tiet.Truyen_Khai_Thac, mQLTGND_E2_Di_Chi_Tiet.Truyen_Doi_Soat, mQLTGND_E2_Di_Chi_Tiet.Chot_SL, mQLTGND_E2_Di_Chi_Tiet.Ngay_He_Thong, mQLTGND_E2_Di_Chi_Tiet.Gio_He_Thong)
                            dgDanh_Sach_In_E4.Rows(idx).Cells("Chon").Value = False
                            dgDanh_Sach_In_E4.ActiveRow = dgDanh_Sach_In_E4.Rows(idx)
                        End If
                    End If
                    'Application.DoEvents()
                Next
                Cursor.Current = Cursors.Default
                MessageBox.Show("Quá trình in và cập nhật túi gói đã hoàn tất!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "btnThoat_Click"
    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Try
            Me.Close()
            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "opt1_CheckedChanged"
    Private Sub opt1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opt1.CheckedChanged
        Try

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "---------------dgDanh_Sach_In_E4-------------"
#Region "dgDanh_Sach_In_E4_InitializeLayout"
    Private Sub dgDanh_Sach_In_E4_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgDanh_Sach_In_E4.InitializeLayout
        Dim idx As Integer
        myGridKeyDown = sender
        Try
            myGridKeyDown.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
            myGridKeyDown.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
            myGridKeyDown.DisplayLayout.Override.AllowAddNew = AllowAddNew.No

            myGridKeyDown.DisplayLayout.Bands(0).Columns("Chon").Style = ColumnStyle.CheckBox
            'myGridKeyDown.DisplayLayout.Bands(0).Columns("Ngay_Dong").MaskInput = "dd/MM/yyyy"
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Ngay_Dong").Format = "dd/MM/yyyy"
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Bc_Gui").CellAppearance.TextHAlign = HAlign.Right
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Bc_Nhan").CellAppearance.TextHAlign = HAlign.Right
            myGridKeyDown.DisplayLayout.Bands(0).Columns("So_Chuyen_Thu").CellAppearance.TextHAlign = HAlign.Right
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Tui_So").CellAppearance.TextHAlign = HAlign.Right
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Tong_So_BP").CellAppearance.TextHAlign = HAlign.Right
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Khoi_Luong_BP").CellAppearance.TextHAlign = HAlign.Right
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Tui_F").Style = ColumnStyle.CheckBox
            For idx = 0 To myGridKeyDown.DisplayLayout.Bands(0).Columns.Count - 1
                myGridKeyDown.DisplayLayout.Bands(0).Columns(idx).CellActivation = Activation.ActivateOnly
            Next
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Chon").CellActivation = Activation.AllowEdit
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "dgDanh_Sach_In_E4_MouseDown"
    Private Sub dgDanh_Sach_In_E4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgDanh_Sach_In_E4.MouseDown
        Try
            myGridKeyDown = sender
            If e.Button = MouseButtons.Right Then
                Dim oHeaderUI As Infragistics.Win.UltraWinGrid.HeaderUIElement
                Dim oUIElement As Infragistics.Win.UIElement
                Dim point As point = New point(e.X, e.Y)

                oUIElement = Me.myGridKeyDown.DisplayLayout.UIElement.ElementFromPoint(point)
                If oUIElement Is Nothing Then Exit Sub
                oUIElement = oUIElement.GetAncestor(GetType(Infragistics.Win.UltraWinGrid.HeaderUIElement))
                If oUIElement Is Nothing Then
                    Return
                End If
                If Not oUIElement.GetType() Is GetType(Infragistics.Win.UltraWinGrid.HeaderUIElement) Then Exit Sub
                oHeaderUI = oUIElement
                Dim oColHeader As Infragistics.Win.UltraWinGrid.ColumnHeader = Nothing
                Me.myColumn = Nothing
                oColHeader = oHeaderUI.SelectableItem
                Me.myColumn = oColHeader.Column
                If Me.myColumn Is Nothing Then Exit Sub

                Me.mnuMenu.Show(Me.myGridKeyDown, point)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "dgDanh_Sach_In_E4_KeyDown"
    Private Sub dgDanh_Sach_In_E4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgDanh_Sach_In_E4.KeyDown
        Try

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#End Region
#End Region

#Region "Hàm người dùng"
#Region "Refresh_Info"
    Private Sub Refresh_Info()
        Dim idx As Integer
        Dim mTong_So As Integer
        Try
            lblInfo.Text = ""
            mTong_So = 0
            For idx = 0 To dgDanh_Sach_In_E4.Rows.Count - 1
                If dgDanh_Sach_In_E4.Rows(idx).Cells("Id_Tui_Thu").Text <> "" Then
                    mTong_So += 1
                End If
            Next
            If mTong_So = 0 Then
                lblInfo.Text = ""
            Else
                lblInfo.Text = mTong_So.ToString & " (Túi)"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblInfo.Text = ""
        End Try
    End Sub
#End Region
#Region "Load_Data"
    Private Sub Load_Data()
        Try
            dtpNgay_KT.Value = Now.Date()

            'Them moi mot bang
            Dim dataTable As New dataTable("Loai_Du_Lieu")
            'Tao ra cac cot cua bang nay
            Dim colWork As DataColumn = New DataColumn("Id_Phan_Loai", GetType(Int32))
            dataTable.Columns.Add(colWork)
            colWork = New DataColumn("Ten_Phan_Loai", GetType(String))
            dataTable.Columns.Add(colWork)
            'Them du lieu vao
            Dim row As DataRow
            row = dataTable.NewRow()
            row("Id_Phan_Loai") = 1
            row("Ten_Phan_Loai") = "Chưa in"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow()
            row("Id_Phan_Loai") = 2
            row("Ten_Phan_Loai") = "Đã in"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow()
            row("Id_Phan_Loai") = 3
            row("Ten_Phan_Loai") = "Tất cả"
            dataTable.Rows.Add(row)

            cbLoai_DL.DataSource = dataTable
            cbLoai_DL.DataBind()
            cbLoai_DL.Value = 1
            cbLoai_DL.LimitToList = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "-----------------------Search-----------------------"
    Private Sub mnuTimKiem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTimKiem.Click
        If Me.FrmTK Is Nothing Then
            Me.FrmTK = New FrmTimKiemDanhMuc
        End If
        Me.FrmTK.ShowMe(Me, myGridKeyDown, "")
    End Sub

    Private Function Match(ByVal userString As String, ByVal cellValue As String) As Boolean
        If userString.Length > cellValue.Length Then
            Match = False
            Exit Function
        ElseIf userString.Length = cellValue.Length Then
            If userString.ToLower = cellValue.ToLower Then Match = True Else Match = False
            Exit Function
        Else
            Dim i As Integer
            For i = 0 To (cellValue.Length - userString.Length) - 0
                If userString.ToLower = cellValue.ToLower.Substring(i, userString.Length) Then
                    Match = True
                    Exit Function
                End If
            Next
            Match = False
            Exit Function
        End If
    End Function
    Private Function MatchText(ByVal _myGrid As Infragistics.Win.UltraWinGrid.UltraGrid, ByVal oRow As Infragistics.Win.UltraWinGrid.UltraGridRow, ByVal _myString As String) As Boolean
        If oRow Is Nothing Then
            MatchText = False
            Exit Function
        End If
        Dim oCol As Infragistics.Win.UltraWinGrid.UltraGridColumn
        Dim strCellValue As String = ""
        For Each oCol In _myGrid.DisplayLayout.Bands(0).Columns
            If Not oRow.Cells(oCol.Key).Value Is System.DBNull.Value Then
                If Me.Match(_myString, oRow.Cells(oCol.Key).Value) Then
                    MatchText = True
                    Me.myColumn = oCol
                    Exit Function
                End If
            End If
        Next
    End Function
    Public Sub Search(ByVal _myGrid As Infragistics.Win.UltraWinGrid.UltraGrid, ByVal _myString As String)
        Dim oRow As Infragistics.Win.UltraWinGrid.UltraGridRow
        oRow = _myGrid.ActiveRow
        If oRow Is Nothing Then oRow = _myGrid.GetRow(Infragistics.Win.UltraWinGrid.ChildRow.First)

        While Not oRow Is Nothing
            oRow = oRow.GetSibling(Infragistics.Win.UltraWinGrid.SiblingRow.Next)
            If Me.MatchText(_myGrid, oRow, _myString) Then
                _myGrid.ActiveRow = oRow
                If Not Me.myColumn Is Nothing Then
                    _myGrid.ActiveCell = oRow.Cells(Me.myColumn.Key)
                    _myGrid.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.ActivateCell, False, False)
                    oRow.Appearance.ForeColor = Color.Blue
                End If
                Exit Sub
            End If
        End While
        oRow = _myGrid.GetRow(Infragistics.Win.UltraWinGrid.ChildRow.First)
        While Not oRow Is Nothing
            If Me.MatchText(_myGrid, oRow, _myString) Then
                _myGrid.ActiveRow = oRow
                If Not Me.myColumn Is Nothing Then
                    _myGrid.ActiveCell = oRow.Cells(Me.myColumn.Key)
                    _myGrid.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.ActivateCell, False, False)
                    oRow.Appearance.ForeColor = Color.Blue
                End If
                Exit Sub
            End If
            oRow = oRow.GetSibling(Infragistics.Win.UltraWinGrid.SiblingRow.Next)
        End While
        CMessageBox.Show("Đã tìm kiếm hết danh sách rồi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None)

    End Sub
#End Region
#Region "In_Nhan_E4_Label_Theo_E2_Duoc_Chon"
    Private Function In_Nhan_E4_Label_Theo_E2_Duoc_Chon() As Boolean
        'Dim idx As Integer
        Dim mDataE2InE4 As DataTable
        Try
            mDataE2InE4 = Tao_Bang_In_E4()
            If mDataE2InE4 Is Nothing Then
                Return False
                Exit Function
            Else
                If In_Nhan_E4_Label_8Label_KhoA4(mDataE2InE4, False, "") Then
                    opt1.Checked = True
                    Return True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region
#Region "Preview_Nhan_E4_Label_Theo_E2_Duoc_Chon"
    Private Function Preview_Nhan_E4_Label_Theo_E2_Duoc_Chon() As Boolean
        'Dim idx As Integer
        Dim mDataE2InE4 As DataTable
        Try
            mDataE2InE4 = Tao_Bang_In_E4()
            If mDataE2InE4 Is Nothing Then
                Return False
                Exit Function
            Else
                If In_Nhan_E4_Label_8Label_KhoA4(mDataE2InE4, True, "") Then
                    opt1.Checked = True
                    Return True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region
#Region "Tao_Bang_In_E4"
    Private Function Tao_Bang_In_E4() As DataTable
        Try
            Dim dataTable As New dataTable("Danh_Sach_Tui_In_Nhan_E4_Label")
            'Tao ra cac cot cua bang nay
            Dim colWork As DataColumn = New DataColumn("STT", GetType(Int32))
            dataTable.Columns.Add(colWork)
            colWork = New DataColumn("Id_Tui_Thu", GetType(String))
            dataTable.Columns.Add(colWork)
            colWork = New DataColumn("Ngay_Dong", GetType(String))
            dataTable.Columns.Add(colWork)
            colWork = New DataColumn("Buu_Cuc_Gui", GetType(String))
            dataTable.Columns.Add(colWork)
            colWork = New DataColumn("Buu_Cuc_Nhan", GetType(String))
            dataTable.Columns.Add(colWork)
            colWork = New DataColumn("So_Chuyen_Thu", GetType(String))
            dataTable.Columns.Add(colWork)
            colWork = New DataColumn("Tui_So", GetType(String))
            dataTable.Columns.Add(colWork)
            colWork = New DataColumn("Tong_So_BP", GetType(Int32))
            dataTable.Columns.Add(colWork)
            colWork = New DataColumn("Khoi_Luong_BP", GetType(Int32))
            dataTable.Columns.Add(colWork)
            colWork = New DataColumn("Tui_F", GetType(String))
            dataTable.Columns.Add(colWork)

            'Them du lieu vao
            Dim mTong_So_Dong_Chon As Integer
            Dim mSo_Dong_Can_Them_Vao As Integer
            Dim idx As Integer
            Dim row As DataRow
            'Kiem tra vi tri bat dau in de insert so dong tuong ung vao datatable
            If opt1.Checked Then
                mSo_Dong_Can_Them_Vao = 0
            ElseIf opt2.Checked Then
                mSo_Dong_Can_Them_Vao = 1
            ElseIf opt3.Checked Then
                mSo_Dong_Can_Them_Vao = 2
            ElseIf opt4.Checked Then
                mSo_Dong_Can_Them_Vao = 3
            ElseIf opt5.Checked Then
                mSo_Dong_Can_Them_Vao = 4
            ElseIf opt6.Checked Then
                mSo_Dong_Can_Them_Vao = 5
            ElseIf opt7.Checked Then
                mSo_Dong_Can_Them_Vao = 6
            ElseIf opt8.Checked Then
                mSo_Dong_Can_Them_Vao = 7
            End If
            If mSo_Dong_Can_Them_Vao > 0 Then
                For idx = 0 To mSo_Dong_Can_Them_Vao - 1
                    row = dataTable.NewRow()
                    row("STT") = 0
                    row("Id_Tui_Thu") = ""
                    row("Ngay_Dong") = ""
                    row("Buu_Cuc_Gui") = ""
                    row("Buu_Cuc_Nhan") = ""
                    row("So_Chuyen_Thu") = ""
                    row("Tui_So") = ""
                    row("Tong_So_BP") = 0
                    row("Khoi_Luong_BP") = 0
                    row("Tui_F") = ""
                    dataTable.Rows.Add(row)
                Next
            End If
            mTong_So_Dong_Chon = 0
            Dim mNgay_Dong As Date
            For idx = 0 To dgDanh_Sach_In_E4.Rows.Count - 1
                If dgDanh_Sach_In_E4.Rows(idx).Cells("Chon").Value Then
                    mTong_So_Dong_Chon += 1
                    row = dataTable.NewRow()
                    row("STT") = 0
                    row("Id_Tui_Thu") = dgDanh_Sach_In_E4.Rows(idx).Cells("Id_Tui_Thu").Text
                    mNgay_Dong = dgDanh_Sach_In_E4.Rows(idx).Cells("Ngay_Dong").Value
                    row("Ngay_Dong") = mNgay_Dong.ToString("dd/MM/yyyy")
                    row("Buu_Cuc_Gui") = dgDanh_Sach_In_E4.Rows(idx).Cells("Buu_Cuc_Gui").Text
                    row("Buu_Cuc_Nhan") = dgDanh_Sach_In_E4.Rows(idx).Cells("Buu_Cuc_Nhan").Text
                    row("So_Chuyen_Thu") = dgDanh_Sach_In_E4.Rows(idx).Cells("So_Chuyen_Thu").Text
                    row("Tui_So") = dgDanh_Sach_In_E4.Rows(idx).Cells("Tui_So").Text
                    row("Tong_So_BP") = dgDanh_Sach_In_E4.Rows(idx).Cells("Tong_So_BP").Value
                    row("Khoi_Luong_BP") = dgDanh_Sach_In_E4.Rows(idx).Cells("Khoi_Luong_BP").Value
                    row("Tui_F") = IIf(dgDanh_Sach_In_E4.Rows(idx).Cells("Tui_F").Value = True, "F", "")
                    dataTable.Rows.Add(row)
                End If
            Next
            If mTong_So_Dong_Chon = 0 Then
                MessageBox.Show("Bạn chưa chọn túi cần in nhãn E4 trong danh sách!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return Nothing
            Else
                Return dataTable
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function
#End Region

#End Region

End Class

Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports Ems_International_Logic.EMS
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports System.Diagnostics
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Math
Imports System.IO
Imports System.IO.File
Imports System.Text

Public Class FrmXem_ChiTiet_BC37
    Inherits System.Windows.Forms.Form
#Region "Contructor"
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
    End Sub
    Public Sub New(ByVal BC37_ID As String, ByVal bKey As Byte, ByVal isDetail As Boolean, ByRef Params As DataRow)
        MyBase.New()
        InitializeComponent()
        str_BC37_ID = BC37_ID
        _isDetail = isDetail
        _Key = bKey
        _Params = Params
        If (bKey = 3) Then
            Me.Text = "Xem chi tiết BC37 đi"
        ElseIf (bKey = 4) Then
            Me.Text = "Xem chi tiết BC37 đến"
        End If

    End Sub
#End Region
#Region " Windows Form Designer generated code "



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
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cbNgayDong As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txtSo_Chuyen_Thu As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtTong_So_Tui As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtTong_So_BP As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtSo_Hieu_BC37 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtTong_Khoi_Luong As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblDot As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbl_BC_Nhan As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbl_BC_Gui As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblNgay As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dgGiaoTuiDi As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents txtMa_Bc_Gui As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtMa_Bc_Nhan As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtDot_Giao_Nhan As Infragistics.Win.UltraWinEditors.UltraTextEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E2")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Dong")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chuyen_Thu")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tui_So")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_BP")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong_Vo_Tui")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong_BP")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmXem_ChiTiet_BC37))
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox
        Me.dgGiaoTuiDi = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox
        Me.txtDot_Giao_Nhan = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtMa_Bc_Nhan = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtMa_Bc_Gui = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel
        Me.txtSo_Hieu_BC37 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lblDot = New Infragistics.Win.Misc.UltraLabel
        Me.lbl_BC_Nhan = New Infragistics.Win.Misc.UltraLabel
        Me.lbl_BC_Gui = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.txtTong_Khoi_Luong = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.txtTong_So_BP = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.txtTong_So_Tui = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.txtSo_Chuyen_Thu = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.cbNgayDong = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.lblNgay = New Infragistics.Win.Misc.UltraLabel
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.dgGiaoTuiDi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.txtDot_Giao_Nhan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMa_Bc_Nhan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMa_Bc_Gui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSo_Hieu_BC37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTong_Khoi_Luong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTong_So_BP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTong_So_Tui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSo_Chuyen_Thu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbNgayDong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.dgGiaoTuiDi)
        Me.UltraGroupBox2.ForeColor = System.Drawing.SystemColors.Control
        Appearance1.FontData.BoldAsString = "True"
        Appearance1.ForeColor = System.Drawing.Color.Black
        Appearance1.TextHAlign = Infragistics.Win.HAlign.Center
        Me.UltraGroupBox2.HeaderAppearance = Appearance1
        Me.UltraGroupBox2.Location = New System.Drawing.Point(0, 128)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(760, 456)
        Me.UltraGroupBox2.SupportThemes = False
        Me.UltraGroupBox2.TabIndex = 1
        Me.UltraGroupBox2.Text = "Danh sách túi gói"
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'dgGiaoTuiDi
        '
        Me.dgGiaoTuiDi.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance2.BackColor = System.Drawing.Color.White
        Me.dgGiaoTuiDi.DisplayLayout.Appearance = Appearance2
        UltraGridColumn1.Header.Caption = "E2"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.Header.Caption = "Bưu cục khai thác"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.Header.Caption = "Ngày đóng"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.Header.Caption = "Số chuyến thư"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.Header.Caption = "Túi số"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn6.Header.Caption = "Tổng số bưu phẩm"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn7.Header.Caption = "Khối lượng vỏ túi"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn8.Header.Caption = "Khối lượng bưu phẩm"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8})
        Me.dgGiaoTuiDi.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Me.dgGiaoTuiDi.DisplayLayout.Override.CardAreaAppearance = Appearance3
        Me.dgGiaoTuiDi.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Appearance4.BackColor = System.Drawing.Color.FromArgb(CType(175, Byte), CType(192, Byte), CType(130, Byte))
        Appearance4.BackColor2 = System.Drawing.Color.FromArgb(CType(99, Byte), CType(122, Byte), CType(68, Byte))
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance4.FontData.BoldAsString = "True"
        Appearance4.FontData.Name = "Arial"
        Appearance4.FontData.SizeInPoints = 10.0!
        Appearance4.ForeColor = System.Drawing.Color.White
        Appearance4.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgGiaoTuiDi.DisplayLayout.Override.HeaderAppearance = Appearance4
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(175, Byte), CType(192, Byte), CType(130, Byte))
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(99, Byte), CType(122, Byte), CType(68, Byte))
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgGiaoTuiDi.DisplayLayout.Override.RowSelectorAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(251, Byte), CType(230, Byte), CType(148, Byte))
        Appearance6.BackColor2 = System.Drawing.Color.FromArgb(CType(238, Byte), CType(149, Byte), CType(21, Byte))
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgGiaoTuiDi.DisplayLayout.Override.SelectedRowAppearance = Appearance6
        Me.dgGiaoTuiDi.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.dgGiaoTuiDi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgGiaoTuiDi.Location = New System.Drawing.Point(2, 18)
        Me.dgGiaoTuiDi.Name = "dgGiaoTuiDi"
        Me.dgGiaoTuiDi.Size = New System.Drawing.Size(756, 436)
        Me.dgGiaoTuiDi.TabIndex = 10
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Controls.Add(Me.txtDot_Giao_Nhan)
        Me.UltraGroupBox4.Controls.Add(Me.txtMa_Bc_Nhan)
        Me.UltraGroupBox4.Controls.Add(Me.txtMa_Bc_Gui)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel8)
        Me.UltraGroupBox4.Controls.Add(Me.txtSo_Hieu_BC37)
        Me.UltraGroupBox4.Controls.Add(Me.lblDot)
        Me.UltraGroupBox4.Controls.Add(Me.lbl_BC_Nhan)
        Me.UltraGroupBox4.Controls.Add(Me.lbl_BC_Gui)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox4.Controls.Add(Me.txtTong_Khoi_Luong)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox4.Controls.Add(Me.txtTong_So_BP)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox4.Controls.Add(Me.txtTong_So_Tui)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox4.Controls.Add(Me.txtSo_Chuyen_Thu)
        Me.UltraGroupBox4.Controls.Add(Me.cbNgayDong)
        Me.UltraGroupBox4.Controls.Add(Me.lblNgay)
        Me.UltraGroupBox4.ForeColor = System.Drawing.SystemColors.ControlText
        Appearance7.FontData.BoldAsString = "True"
        Appearance7.ForeColor = System.Drawing.Color.Black
        Appearance7.TextHAlign = Infragistics.Win.HAlign.Center
        Me.UltraGroupBox4.HeaderAppearance = Appearance7
        Me.UltraGroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(760, 120)
        Me.UltraGroupBox4.SupportThemes = False
        Me.UltraGroupBox4.TabIndex = 2
        Me.UltraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'txtDot_Giao_Nhan
        '
        Appearance8.TextHAlign = Infragistics.Win.HAlign.Right
        Me.txtDot_Giao_Nhan.Appearance = Appearance8
        Me.txtDot_Giao_Nhan.Location = New System.Drawing.Point(656, 40)
        Me.txtDot_Giao_Nhan.Name = "txtDot_Giao_Nhan"
        Me.txtDot_Giao_Nhan.Size = New System.Drawing.Size(88, 21)
        Me.txtDot_Giao_Nhan.TabIndex = 4
        Me.txtDot_Giao_Nhan.Text = "1"
        '
        'txtMa_Bc_Nhan
        '
        Me.txtMa_Bc_Nhan.Location = New System.Drawing.Point(544, 40)
        Me.txtMa_Bc_Nhan.Name = "txtMa_Bc_Nhan"
        Me.txtMa_Bc_Nhan.Size = New System.Drawing.Size(96, 21)
        Me.txtMa_Bc_Nhan.TabIndex = 3
        '
        'txtMa_Bc_Gui
        '
        Me.txtMa_Bc_Gui.Location = New System.Drawing.Point(432, 40)
        Me.txtMa_Bc_Gui.Name = "txtMa_Bc_Gui"
        Me.txtMa_Bc_Gui.Size = New System.Drawing.Size(96, 21)
        Me.txtMa_Bc_Gui.TabIndex = 2
        '
        'UltraLabel8
        '
        Appearance9.FontData.BoldAsString = "True"
        Me.UltraLabel8.Appearance = Appearance9
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.BackColor = System.Drawing.Color.White
        Me.UltraLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UltraLabel8.Location = New System.Drawing.Point(72, 16)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(177, 21)
        Me.UltraLabel8.TabIndex = 32
        Me.UltraLabel8.Text = "Mã vạch số hiệu BC37"
        '
        'txtSo_Hieu_BC37
        '
        Appearance10.BackColor = System.Drawing.Color.White
        Appearance10.ForeColor = System.Drawing.Color.Green
        Appearance10.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance10.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.txtSo_Hieu_BC37.Appearance = Appearance10
        Me.txtSo_Hieu_BC37.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSo_Hieu_BC37.Location = New System.Drawing.Point(8, 40)
        Me.txtSo_Hieu_BC37.Multiline = True
        Me.txtSo_Hieu_BC37.Name = "txtSo_Hieu_BC37"
        Me.txtSo_Hieu_BC37.Size = New System.Drawing.Size(304, 72)
        Me.txtSo_Hieu_BC37.TabIndex = 0
        '
        'lblDot
        '
        Me.lblDot.AutoSize = True
        Me.lblDot.BackColor = System.Drawing.Color.White
        Me.lblDot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDot.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDot.Location = New System.Drawing.Point(656, 24)
        Me.lblDot.Name = "lblDot"
        Me.lblDot.Size = New System.Drawing.Size(48, 14)
        Me.lblDot.TabIndex = 30
        Me.lblDot.Text = "Đợt giao"
        '
        'lbl_BC_Nhan
        '
        Me.lbl_BC_Nhan.AutoSize = True
        Me.lbl_BC_Nhan.BackColor = System.Drawing.Color.White
        Me.lbl_BC_Nhan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BC_Nhan.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbl_BC_Nhan.Location = New System.Drawing.Point(544, 24)
        Me.lbl_BC_Nhan.Name = "lbl_BC_Nhan"
        Me.lbl_BC_Nhan.Size = New System.Drawing.Size(76, 14)
        Me.lbl_BC_Nhan.TabIndex = 28
        Me.lbl_BC_Nhan.Text = "Bưu cục nhận"
        '
        'lbl_BC_Gui
        '
        Me.lbl_BC_Gui.AutoSize = True
        Me.lbl_BC_Gui.BackColor = System.Drawing.Color.White
        Me.lbl_BC_Gui.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BC_Gui.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbl_BC_Gui.Location = New System.Drawing.Point(432, 24)
        Me.lbl_BC_Gui.Name = "lbl_BC_Gui"
        Me.lbl_BC_Gui.Size = New System.Drawing.Size(66, 14)
        Me.lbl_BC_Gui.TabIndex = 27
        Me.lbl_BC_Gui.Text = "Bưu cục gửi"
        '
        'UltraLabel4
        '
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.BackColor = System.Drawing.Color.White
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UltraLabel4.Location = New System.Drawing.Point(656, 72)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(88, 14)
        Me.UltraLabel4.TabIndex = 26
        Me.UltraLabel4.Text = "Tổng khối lượng "
        '
        'txtTong_Khoi_Luong
        '
        Appearance11.TextHAlign = Infragistics.Win.HAlign.Right
        Me.txtTong_Khoi_Luong.Appearance = Appearance11
        Me.txtTong_Khoi_Luong.Location = New System.Drawing.Point(656, 88)
        Me.txtTong_Khoi_Luong.Name = "txtTong_Khoi_Luong"
        Me.txtTong_Khoi_Luong.Size = New System.Drawing.Size(88, 21)
        Me.txtTong_Khoi_Luong.TabIndex = 8
        Me.txtTong_Khoi_Luong.Text = "0"
        '
        'UltraLabel3
        '
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.BackColor = System.Drawing.Color.White
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UltraLabel3.Location = New System.Drawing.Point(544, 72)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(65, 14)
        Me.UltraLabel3.TabIndex = 24
        Me.UltraLabel3.Text = "Tổng số BP"
        '
        'txtTong_So_BP
        '
        Appearance12.TextHAlign = Infragistics.Win.HAlign.Right
        Me.txtTong_So_BP.Appearance = Appearance12
        Me.txtTong_So_BP.Location = New System.Drawing.Point(544, 88)
        Me.txtTong_So_BP.Name = "txtTong_So_BP"
        Me.txtTong_So_BP.Size = New System.Drawing.Size(96, 21)
        Me.txtTong_So_BP.TabIndex = 7
        Me.txtTong_So_BP.Text = "0"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.BackColor = System.Drawing.Color.White
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UltraLabel2.Location = New System.Drawing.Point(432, 72)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(62, 14)
        Me.UltraLabel2.TabIndex = 22
        Me.UltraLabel2.Text = "Tổng số túi"
        '
        'txtTong_So_Tui
        '
        Appearance13.TextHAlign = Infragistics.Win.HAlign.Right
        Me.txtTong_So_Tui.Appearance = Appearance13
        Me.txtTong_So_Tui.Location = New System.Drawing.Point(432, 88)
        Me.txtTong_So_Tui.Name = "txtTong_So_Tui"
        Me.txtTong_So_Tui.Size = New System.Drawing.Size(96, 21)
        Me.txtTong_So_Tui.TabIndex = 6
        Me.txtTong_So_Tui.Text = "0"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.BackColor = System.Drawing.Color.White
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UltraLabel1.Location = New System.Drawing.Point(328, 72)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(79, 14)
        Me.UltraLabel1.TabIndex = 20
        Me.UltraLabel1.Text = "Số chuyến thư"
        '
        'txtSo_Chuyen_Thu
        '
        Appearance14.TextHAlign = Infragistics.Win.HAlign.Right
        Me.txtSo_Chuyen_Thu.Appearance = Appearance14
        Me.txtSo_Chuyen_Thu.Location = New System.Drawing.Point(328, 88)
        Me.txtSo_Chuyen_Thu.Name = "txtSo_Chuyen_Thu"
        Me.txtSo_Chuyen_Thu.Size = New System.Drawing.Size(88, 21)
        Me.txtSo_Chuyen_Thu.TabIndex = 5
        Me.txtSo_Chuyen_Thu.Text = "0"
        '
        'cbNgayDong
        '
        Me.cbNgayDong.DateTime = New Date(2008, 9, 9, 0, 0, 0, 0)
        Me.cbNgayDong.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.cbNgayDong.Location = New System.Drawing.Point(328, 40)
        Me.cbNgayDong.Name = "cbNgayDong"
        Me.cbNgayDong.Size = New System.Drawing.Size(88, 21)
        Me.cbNgayDong.TabIndex = 1
        Me.cbNgayDong.Value = New Date(2008, 9, 9, 0, 0, 0, 0)
        '
        'lblNgay
        '
        Me.lblNgay.AutoSize = True
        Me.lblNgay.BackColor = System.Drawing.Color.White
        Me.lblNgay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNgay.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNgay.Location = New System.Drawing.Point(328, 24)
        Me.lblNgay.Name = "lblNgay"
        Me.lblNgay.Size = New System.Drawing.Size(61, 14)
        Me.lblNgay.TabIndex = 16
        Me.lblNgay.Text = "Ngày nhận"
        '
        'FrmXem_ChiTiet_BC37
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(762, 582)
        Me.Controls.Add(Me.UltraGroupBox4)
        Me.Controls.Add(Me.UltraGroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmXem_ChiTiet_BC37"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Xem chi tiết BC37 đến"
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.dgGiaoTuiDi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        CType(Me.txtDot_Giao_Nhan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMa_Bc_Nhan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMa_Bc_Gui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSo_Hieu_BC37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTong_Khoi_Luong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTong_So_BP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTong_So_Tui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSo_Chuyen_Thu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbNgayDong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Khai bao bien trong Form"
    Dim _isDetail As Boolean
    Dim _Key As Byte
    Dim str_BC37_ID As String
    Dim _Params As DataRow
    Dim str_SelectCommand As String
#End Region

    Private Sub FrmNhap_Thay_The_BC37_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbNgayDong.Value = _Params("Ngay_Dong")
        txtMa_Bc_Gui.Text = _Params("Buu_Cuc_Dong").ToString()
        txtMa_Bc_Nhan.Text = _Params("Buu_Cuc_Nhan").ToString()
        txtDot_Giao_Nhan.Text = _Params("Ma_Dot_Giao_Nhan").ToString()
        txtSo_Chuyen_Thu.Text = _Params("So_Hieu_Chuyen_Thu").ToString()
        txtTong_So_Tui.Text = _Params("So_Luong_Tui").ToString()
        txtTong_So_BP.Text = _Params("Tong_So_BP").ToString()
        txtTong_Khoi_Luong.Text = _Params("Khoi_Luong").ToString()
        txtSo_Hieu_BC37.Text = _Params("BC37_ID").ToString()
        LoadDataSource(str_BC37_ID)
    End Sub

    Private Sub LoadDataSource(ByVal BC37_ID As String)
        Try
            SelectCommand(str_SelectCommand, str_BC37_ID)
            Dim conn As New SqlConnection(GConnectionString)
            conn.Open()
            Dim myDataSource As New DataTable("dtsource")
            Dim myCMD As New SqlCommand(str_SelectCommand, conn)
            Dim myDA As New SqlDataAdapter(myCMD)
            myDA.Fill(myDataSource)
            dgGiaoTuiDi.DataSource = myDataSource
            dgGiaoTuiDi.DataBind()
            conn.Close()
        Catch ex As Exception
            CMessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SelectCommand(ByRef str_SelectCMD As String, ByVal str_BC37_ID As String)
        If (_Key = 3) Then
            str_SelectCMD = "select tui.Id_E2,tui.Ma_Bc_Khai_Thac,convert(varchar(15),dbo.ConvertIntToDate(tui.Ngay_Dong),103) as Ngay_Dong,tui.So_Chuyen_Thu,tui.Tui_So,tui.Tong_So_BP,tui.Khoi_Luong_Vo_Tui,tui.Khoi_Luong_BP " & _
"from QLTGND_POSTBAG_DI tui where tui.Id_Chuyen_Thu = " & str_BC37_ID
        ElseIf (_Key = 4) Then
            str_SelectCMD = "select tui.Id_E2,tui.Ma_Bc_Khai_Thac,convert(varchar(15),dbo.ConvertIntToDate(tui.Ngay_Dong),103) as Ngay_Dong,tui.So_Chuyen_Thu,tui.Tui_So,tui.Tong_So_BP,tui.Khoi_Luong_Vo_Tui,tui.Khoi_Luong_BP " & _
"from QLTGND_POSTBAG_DEN tui where tui.Id_Chuyen_Thu =" & str_BC37_ID
        End If
    End Sub
    Private Sub GeneralDataSchema()
        If (_Key = 3) Then

        ElseIf (_Key = 4) Then

        End If
    End Sub

    Private Sub FrmXem_ChiTiet_BC37_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
End Class

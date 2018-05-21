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

Public Class FrmNhap_Thay_The_BC37
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
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cbMa_Bc_Nhan As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbMa_Bc_Gui As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbNgayDong As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnThem_Du_Lieu As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtSo_Chuyen_Thu As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtTong_So_Tui As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtTong_So_BP As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbDot_Giao As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtSo_Hieu_BC37 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtTong_Khoi_Luong As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents chkChuyen_Tiep As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Dot_Giao", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("DuongThuDi", -1)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Bc_Khai_Thac")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IsPO")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("DuongThuDi", -1)
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chang")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Tuyen")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Goc")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Bc_Goc")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Dich")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Bc_Dich")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cap_Bc_Dich")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Di")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Den")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("STT")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmNhap_Thay_The_BC37))
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox
        Me.chkChuyen_Tiep = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel
        Me.txtSo_Hieu_BC37 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel
        Me.cbDot_Giao = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.txtTong_Khoi_Luong = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.txtTong_So_BP = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.txtTong_So_Tui = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.txtSo_Chuyen_Thu = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.cbMa_Bc_Nhan = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cbMa_Bc_Gui = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cbNgayDong = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.btnThem_Du_Lieu = New Infragistics.Win.Misc.UltraButton
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.txtSo_Hieu_BC37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDot_Giao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTong_Khoi_Luong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTong_So_BP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTong_So_Tui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSo_Chuyen_Thu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMa_Bc_Nhan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMa_Bc_Gui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbNgayDong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Controls.Add(Me.chkChuyen_Tiep)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel8)
        Me.UltraGroupBox4.Controls.Add(Me.txtSo_Hieu_BC37)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel7)
        Me.UltraGroupBox4.Controls.Add(Me.cbDot_Giao)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel6)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel5)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox4.Controls.Add(Me.txtTong_Khoi_Luong)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox4.Controls.Add(Me.txtTong_So_BP)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox4.Controls.Add(Me.txtTong_So_Tui)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox4.Controls.Add(Me.txtSo_Chuyen_Thu)
        Me.UltraGroupBox4.Controls.Add(Me.cbMa_Bc_Nhan)
        Me.UltraGroupBox4.Controls.Add(Me.cbMa_Bc_Gui)
        Me.UltraGroupBox4.Controls.Add(Me.cbNgayDong)
        Me.UltraGroupBox4.Controls.Add(Me.btnThem_Du_Lieu)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel9)
        Me.UltraGroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox4.ForeColor = System.Drawing.SystemColors.ControlText
        Appearance1.FontData.BoldAsString = "True"
        Appearance1.ForeColor = System.Drawing.Color.Black
        Appearance1.TextHAlign = Infragistics.Win.HAlign.Center
        Me.UltraGroupBox4.HeaderAppearance = Appearance1
        Me.UltraGroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(538, 192)
        Me.UltraGroupBox4.SupportThemes = False
        Me.UltraGroupBox4.TabIndex = 0
        Me.UltraGroupBox4.Text = "Thông tin BC37 - Nhập thay thế"
        Me.UltraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'chkChuyen_Tiep
        '
        Appearance2.FontData.BoldAsString = "True"
        Me.chkChuyen_Tiep.Appearance = Appearance2
        Me.chkChuyen_Tiep.BackColor = System.Drawing.Color.White
        Me.chkChuyen_Tiep.Location = New System.Drawing.Point(408, 24)
        Me.chkChuyen_Tiep.Name = "chkChuyen_Tiep"
        Me.chkChuyen_Tiep.Size = New System.Drawing.Size(112, 24)
        Me.chkChuyen_Tiep.TabIndex = 33
        Me.chkChuyen_Tiep.Text = "Là chuyển tiếp"
        Me.chkChuyen_Tiep.Visible = False
        '
        'UltraLabel8
        '
        Appearance3.FontData.BoldAsString = "True"
        Me.UltraLabel8.Appearance = Appearance3
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.BackColor = System.Drawing.Color.White
        Me.UltraLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UltraLabel8.Location = New System.Drawing.Point(8, 24)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(177, 21)
        Me.UltraLabel8.TabIndex = 32
        Me.UltraLabel8.Text = "Mã vạch số hiệu BC37"
        '
        'txtSo_Hieu_BC37
        '
        Appearance4.BackColor = System.Drawing.Color.White
        Appearance4.ForeColor = System.Drawing.Color.Green
        Appearance4.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance4.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.txtSo_Hieu_BC37.Appearance = Appearance4
        Me.txtSo_Hieu_BC37.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSo_Hieu_BC37.Location = New System.Drawing.Point(8, 48)
        Me.txtSo_Hieu_BC37.Multiline = True
        Me.txtSo_Hieu_BC37.Name = "txtSo_Hieu_BC37"
        Me.txtSo_Hieu_BC37.Size = New System.Drawing.Size(520, 32)
        Me.txtSo_Hieu_BC37.TabIndex = 0
        '
        'UltraLabel7
        '
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.BackColor = System.Drawing.Color.White
        Me.UltraLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UltraLabel7.Location = New System.Drawing.Point(344, 96)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel7.TabIndex = 30
        Me.UltraLabel7.Text = "Đợt giao"
        '
        'cbDot_Giao
        '
        Appearance5.TextHAlign = Infragistics.Win.HAlign.Right
        Me.cbDot_Giao.Appearance = Appearance5
        Me.cbDot_Giao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.cbDot_Giao.DisplayLayout.Appearance = Appearance6
        Appearance7.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn1.CellAppearance = Appearance7
        Appearance8.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn1.Header.Appearance = Appearance8
        UltraGridColumn1.Header.Caption = "Mã đợt giao"
        UltraGridColumn1.Header.VisiblePosition = 0
        Appearance9.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn2.Header.Appearance = Appearance9
        UltraGridColumn2.Header.Caption = "Tên đợt giao"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 250
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2})
        UltraGridBand1.Header.Caption = "Mã Đường Thư"
        Me.cbDot_Giao.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance10.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance10.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance10.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance10.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbDot_Giao.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.cbDot_Giao.DisplayMember = ""
        Me.cbDot_Giao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDot_Giao.LimitToList = True
        Me.cbDot_Giao.Location = New System.Drawing.Point(344, 112)
        Me.cbDot_Giao.Name = "cbDot_Giao"
        Me.cbDot_Giao.Size = New System.Drawing.Size(96, 21)
        Me.cbDot_Giao.TabIndex = 4
        Me.cbDot_Giao.ValueMember = ""
        '
        'UltraLabel6
        '
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.BackColor = System.Drawing.Color.White
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UltraLabel6.Location = New System.Drawing.Point(240, 96)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(76, 14)
        Me.UltraLabel6.TabIndex = 28
        Me.UltraLabel6.Text = "Bưu cục nhận"
        '
        'UltraLabel5
        '
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.BackColor = System.Drawing.Color.White
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UltraLabel5.Location = New System.Drawing.Point(112, 96)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(66, 14)
        Me.UltraLabel5.TabIndex = 27
        Me.UltraLabel5.Text = "Bưu cục gửi"
        '
        'UltraLabel4
        '
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.BackColor = System.Drawing.Color.White
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UltraLabel4.Location = New System.Drawing.Point(344, 144)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(98, 14)
        Me.UltraLabel4.TabIndex = 26
        Me.UltraLabel4.Text = "Tổng khối lượng  :"
        '
        'txtTong_Khoi_Luong
        '
        Appearance11.TextHAlign = Infragistics.Win.HAlign.Right
        Me.txtTong_Khoi_Luong.Appearance = Appearance11
        Me.txtTong_Khoi_Luong.Location = New System.Drawing.Point(344, 160)
        Me.txtTong_Khoi_Luong.Name = "txtTong_Khoi_Luong"
        Me.txtTong_Khoi_Luong.Size = New System.Drawing.Size(96, 21)
        Me.txtTong_Khoi_Luong.TabIndex = 8
        Me.txtTong_Khoi_Luong.Text = "0"
        '
        'UltraLabel3
        '
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.BackColor = System.Drawing.Color.White
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UltraLabel3.Location = New System.Drawing.Point(232, 144)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(65, 14)
        Me.UltraLabel3.TabIndex = 24
        Me.UltraLabel3.Text = "Tổng số BP"
        '
        'txtTong_So_BP
        '
        Appearance12.TextHAlign = Infragistics.Win.HAlign.Right
        Me.txtTong_So_BP.Appearance = Appearance12
        Me.txtTong_So_BP.Location = New System.Drawing.Point(232, 160)
        Me.txtTong_So_BP.Name = "txtTong_So_BP"
        Me.txtTong_So_BP.Size = New System.Drawing.Size(104, 21)
        Me.txtTong_So_BP.TabIndex = 7
        Me.txtTong_So_BP.Text = "0"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.BackColor = System.Drawing.Color.White
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UltraLabel2.Location = New System.Drawing.Point(112, 144)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(62, 14)
        Me.UltraLabel2.TabIndex = 22
        Me.UltraLabel2.Text = "Tổng số túi"
        '
        'txtTong_So_Tui
        '
        Appearance13.TextHAlign = Infragistics.Win.HAlign.Right
        Me.txtTong_So_Tui.Appearance = Appearance13
        Me.txtTong_So_Tui.Location = New System.Drawing.Point(112, 160)
        Me.txtTong_So_Tui.Name = "txtTong_So_Tui"
        Me.txtTong_So_Tui.Size = New System.Drawing.Size(112, 21)
        Me.txtTong_So_Tui.TabIndex = 6
        Me.txtTong_So_Tui.Text = "0"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.BackColor = System.Drawing.Color.White
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UltraLabel1.Location = New System.Drawing.Point(8, 144)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(79, 14)
        Me.UltraLabel1.TabIndex = 20
        Me.UltraLabel1.Text = "Số chuyến thư"
        '
        'txtSo_Chuyen_Thu
        '
        Appearance14.TextHAlign = Infragistics.Win.HAlign.Right
        Me.txtSo_Chuyen_Thu.Appearance = Appearance14
        Me.txtSo_Chuyen_Thu.Location = New System.Drawing.Point(8, 160)
        Me.txtSo_Chuyen_Thu.Name = "txtSo_Chuyen_Thu"
        Me.txtSo_Chuyen_Thu.Size = New System.Drawing.Size(96, 21)
        Me.txtSo_Chuyen_Thu.TabIndex = 5
        Me.txtSo_Chuyen_Thu.Text = "0"
        '
        'cbMa_Bc_Nhan
        '
        Appearance15.TextHAlign = Infragistics.Win.HAlign.Right
        Me.cbMa_Bc_Nhan.Appearance = Appearance15
        Me.cbMa_Bc_Nhan.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance16.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.cbMa_Bc_Nhan.DisplayLayout.Appearance = Appearance16
        UltraGridColumn3.Header.Caption = "Mã bưu cục"
        UltraGridColumn3.Header.VisiblePosition = 0
        UltraGridColumn4.Header.Caption = "Tên bưu cục"
        UltraGridColumn4.Header.VisiblePosition = 1
        UltraGridColumn4.Width = 250
        UltraGridColumn5.Header.VisiblePosition = 2
        UltraGridColumn5.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn3, UltraGridColumn4, UltraGridColumn5})
        UltraGridBand2.Header.Caption = "Mã Đường Thư"
        Me.cbMa_Bc_Nhan.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Appearance17.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance17.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance17.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance17.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbMa_Bc_Nhan.DisplayLayout.Override.HeaderAppearance = Appearance17
        Me.cbMa_Bc_Nhan.DisplayMember = "Ma_Bc_Khai_Thac"
        Me.cbMa_Bc_Nhan.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMa_Bc_Nhan.Location = New System.Drawing.Point(232, 112)
        Me.cbMa_Bc_Nhan.Name = "cbMa_Bc_Nhan"
        Me.cbMa_Bc_Nhan.Size = New System.Drawing.Size(104, 21)
        Me.cbMa_Bc_Nhan.TabIndex = 3
        Me.cbMa_Bc_Nhan.ValueMember = "Ma_Bc_Khai_Thac"
        '
        'cbMa_Bc_Gui
        '
        Appearance18.TextHAlign = Infragistics.Win.HAlign.Right
        Me.cbMa_Bc_Gui.Appearance = Appearance18
        Me.cbMa_Bc_Gui.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbMa_Bc_Gui.Cursor = System.Windows.Forms.Cursors.IBeam
        Appearance19.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.cbMa_Bc_Gui.DisplayLayout.Appearance = Appearance19
        Appearance20.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn6.Header.Appearance = Appearance20
        UltraGridColumn6.Header.VisiblePosition = 0
        UltraGridColumn6.Hidden = True
        Appearance21.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn7.Header.Appearance = Appearance21
        UltraGridColumn7.Header.VisiblePosition = 1
        UltraGridColumn7.Hidden = True
        Appearance22.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn8.Header.Appearance = Appearance22
        UltraGridColumn8.Header.Caption = "Mã bưu cục"
        UltraGridColumn8.Header.VisiblePosition = 2
        Appearance23.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn9.Header.Appearance = Appearance23
        UltraGridColumn9.Header.Caption = "Tên bưu cục"
        UltraGridColumn9.Header.VisiblePosition = 3
        UltraGridColumn9.Width = 250
        Appearance24.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn10.Header.Appearance = Appearance24
        UltraGridColumn10.Header.VisiblePosition = 4
        UltraGridColumn10.Hidden = True
        Appearance25.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn11.Header.Appearance = Appearance25
        UltraGridColumn11.Header.VisiblePosition = 5
        UltraGridColumn11.Hidden = True
        Appearance26.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn12.Header.Appearance = Appearance26
        UltraGridColumn12.Header.VisiblePosition = 6
        UltraGridColumn12.Hidden = True
        Appearance27.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn13.Header.Appearance = Appearance27
        UltraGridColumn13.Header.VisiblePosition = 7
        UltraGridColumn13.Hidden = True
        Appearance28.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn14.Header.Appearance = Appearance28
        UltraGridColumn14.Header.VisiblePosition = 8
        UltraGridColumn14.Hidden = True
        Appearance29.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn15.Header.Appearance = Appearance29
        UltraGridColumn15.Header.VisiblePosition = 9
        UltraGridColumn15.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15})
        UltraGridBand3.Header.Caption = "Mã Đường Thư"
        Me.cbMa_Bc_Gui.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Appearance30.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance30.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance30.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance30.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance30.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbMa_Bc_Gui.DisplayLayout.Override.HeaderAppearance = Appearance30
        Me.cbMa_Bc_Gui.DisplayMember = "Ma_Bc_Goc"
        Me.cbMa_Bc_Gui.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMa_Bc_Gui.Location = New System.Drawing.Point(112, 112)
        Me.cbMa_Bc_Gui.Name = "cbMa_Bc_Gui"
        Me.cbMa_Bc_Gui.Size = New System.Drawing.Size(112, 21)
        Me.cbMa_Bc_Gui.TabIndex = 2
        Me.cbMa_Bc_Gui.ValueMember = "Ma_Bc_Goc"
        '
        'cbNgayDong
        '
        Me.cbNgayDong.DateTime = New Date(2008, 9, 9, 0, 0, 0, 0)
        Me.cbNgayDong.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.cbNgayDong.Location = New System.Drawing.Point(8, 112)
        Me.cbNgayDong.Name = "cbNgayDong"
        Me.cbNgayDong.Size = New System.Drawing.Size(99, 21)
        Me.cbNgayDong.TabIndex = 1
        Me.cbNgayDong.Value = New Date(2008, 9, 9, 0, 0, 0, 0)
        '
        'btnThem_Du_Lieu
        '
        Me.btnThem_Du_Lieu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem_Du_Lieu.Location = New System.Drawing.Point(448, 104)
        Me.btnThem_Du_Lieu.Name = "btnThem_Du_Lieu"
        Me.btnThem_Du_Lieu.Size = New System.Drawing.Size(80, 80)
        Me.btnThem_Du_Lieu.TabIndex = 9
        Me.btnThem_Du_Lieu.Text = "Chấp nhận"
        '
        'UltraLabel9
        '
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.BackColor = System.Drawing.Color.White
        Me.UltraLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UltraLabel9.Location = New System.Drawing.Point(8, 96)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(61, 14)
        Me.UltraLabel9.TabIndex = 16
        Me.UltraLabel9.Text = "Ngày nhận"
        '
        'FrmNhap_Thay_The_BC37
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(538, 192)
        Me.Controls.Add(Me.UltraGroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmNhap_Thay_The_BC37"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Xác nhận đến - Nhập thay thế BC37"
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        CType(Me.txtSo_Hieu_BC37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDot_Giao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTong_Khoi_Luong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTong_So_BP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTong_So_Tui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSo_Chuyen_Thu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMa_Bc_Nhan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMa_Bc_Gui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbNgayDong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Khai bao bien trong Form"
    Dim myColumn As Infragistics.Win.UltraWinGrid.UltraGridColumn = Nothing
    Dim myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Dim myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Dim myMa_Bc_Khai_Thac As New Ma_Bc_Khai_Thac(GConnectionString)
    Dim myMa_Bc_Khai_Thac_Chi_Tiet As New Ma_Bc_Khai_Thac_Chi_Tiet

    Dim myQLTGND_TUYEN_VC As New QLTGND_TUYEN_VC(GConnectionString)
    Dim myQLTGND_TUYEN_VC_Chi_Tiet As New QLTGND_TUYEN_VC_Chi_Tiet
    Dim myQLTGND_CHANG_VC As New QLTGND_CHANG_VC(GConnectionString)
    Dim myQLTGND_CHANG_VC_Chi_Tiet As New QLTGND_CHANG_VC_Chi_Tiet

    Dim myQLTGND_POSTBAG_DEN As New QLTGND_POSTBAG_DEN(GConnectionString)
    Dim myQLTGND_POSTBAG_DEN_Chi_Tiet As New QLTGND_POSTBAG_DEN_Chi_Tiet
    Dim myQLTGND_BC37_DEN As New QLTGND_BC37_DEN(GConnectionString)
    Dim myQLTGND_BC37_DEN_Chi_Tiet As New QLTGND_BC37_DEN_Chi_Tiet

    Public myId_Tuyen_VC As Integer
    Public myMa_Bc_Gui As Integer
    Public myMa_Bc_Nhan As Integer
    Public myBC37_ID As String
    Public myIsOK As Boolean
#End Region

    Private Sub FrmNhap_Thay_The_BC37_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbNgayDong.DateTime = Today
        txtSo_Hieu_BC37.Text = myBC37_ID
        myIsOK = False
        Load_Ma_Buu_Cuc()
        Tao_Bang_Dot_Giao()
        Me.ActiveControl = Me.txtSo_Hieu_BC37
        If txtSo_Hieu_BC37.Text.Trim <> "" Then
            txtSo_Hieu_BC37_Validated(txtSo_Hieu_BC37, Nothing)
            cbNgayDong.Focus()
        Else
            txtSo_Hieu_BC37.Focus()
        End If
    End Sub

    Private Sub Load_Ma_Buu_Cuc()
        cbMa_Bc_Gui.DataSource = myQLTGND_CHANG_VC.QLTGND_CHANG_VC_Danh_Sach_Theo_Tuyen(myId_Tuyen_VC).Tables(0)
        cbMa_Bc_Gui.DataBind()
        If cbMa_Bc_Gui.Rows.Count > 0 Then
            cbMa_Bc_Gui.Value = cbMa_Bc_Gui.Rows(0).Cells("Ma_Bc_Goc").Value
        End If
        cbMa_Bc_Nhan.DataSource = myMa_Bc_Khai_Thac.Danh_Sach.Tables(0)
        cbMa_Bc_Nhan.DataBind()
        If cbMa_Bc_Nhan.Rows.Count > 0 Then
            cbMa_Bc_Nhan.Value = GBuu_Cuc_Khai_Thac
        End If
    End Sub

#Region "Tạo bảng Đợt giao"
    Private Sub Tao_Bang_Dot_Giao()
        Dim dataTable As New dataTable("Dot_Giao")
        Dim i As Integer
        Dim colWork As DataColumn = New DataColumn("Ma", GetType(Integer))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Ten", GetType(String))
        dataTable.Columns.Add(colWork)

        Dim row As DataRow = dataTable.NewRow()
        For i = 1 To 10
            row = dataTable.NewRow
            row("Ma") = i
            row("Ten") = "Đợt " + i.ToString()
            dataTable.Rows.Add(row)
        Next

        cbDot_Giao.DataSource = dataTable
        cbDot_Giao.DataBind()
        cbDot_Giao.Value = 1
    End Sub
#End Region

    Private Sub FrmNhap_Thay_The_BC37_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyValue
                Case Keys.Enter, Keys.Tab
                    Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
                Case Keys.F1

                Case Keys.F2

                Case Keys.Escape

            End Select
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub txtSo_Chuyen_Thu_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSo_Chuyen_Thu.Validated
        If IsNumeric(txtSo_Chuyen_Thu.Text) = False Then
            txtSo_Chuyen_Thu.Text = 0
        End If
    End Sub

    Private Sub txtTong_So_Tui_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTong_So_Tui.Validated
        If IsNumeric(txtTong_So_Tui.Text) = False Then
            txtTong_So_Tui.Text = 0
        End If
    End Sub

    Private Sub txtTong_So_BP_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTong_So_BP.ValueChanged
        If IsNumeric(txtTong_So_BP.Text) = False Then
            txtTong_So_BP.Text = 0
        End If
    End Sub

    Private Sub txtTong_Khoi_Luong_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTong_Khoi_Luong.Validated
        If IsNumeric(txtTong_Khoi_Luong.Text) = False Then
            txtTong_Khoi_Luong.Text = 0
        End If
    End Sub

    Private Sub btnThem_Du_Lieu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem_Du_Lieu.Click
        Try
            'Kiểm tra thông tin nhập vào
            If cbMa_Bc_Gui.Value Is Nothing Then
                If cbMa_Bc_Gui.Text <> "" Then
                    If (MessageBox.Show("Mã bưu cục bạn chọn không tồn tại trong danh sách" & vbNewLine & "Bạn có muốn chọn mã này không?" & vbNewLine & "Chọn YES để đồng ý hoặc NO để chọn lại", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                        cbMa_Bc_Gui.Value = cbMa_Bc_Gui.Text
                    Else
                        Exit Sub
                    End If
                Else
                    MessageBox.Show("Mã bưu cục gửi nhập vào không hợp lệ" & vbNewLine & "Bạn hãy nhập lại mã bưu cục gửi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    cbMa_Bc_Gui.Focus()
                    Exit Sub
                End If
            End If
            'kiểm tra định dạng dữ liệu mã bc gửi
            If IsNumeric(cbMa_Bc_Gui.Value) Then
                If Convert.ToInt32(cbMa_Bc_Gui.Value) > 999999 Or Convert.ToInt32(cbMa_Bc_Gui.Value) < 100000 Then
                    MessageBox.Show("Mã bưu cục phải là số có 6 chữ số" & vbNewLine & "Bạn hãy nhập lại mã bưu cục gửi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    cbMa_Bc_Gui.Focus()
                    Exit Sub
                End If
            Else
                MessageBox.Show("Mã bưu cục phải là số có 6 chữ số" & vbNewLine & "Bạn hãy nhập lại mã bưu cục gửi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cbMa_Bc_Gui.Focus()
                Exit Sub
            End If
            ' kiểm tra mã bc nhận
            If cbMa_Bc_Nhan.Value Is Nothing Then
                If cbMa_Bc_Nhan.Text <> "" Then
                    If (MessageBox.Show("Mã bưu cục bạn chọn không tồn tại trong danh sách" & vbNewLine & "Bạn có muốn chọn mã này không?" & vbNewLine & "Chọn YES để đồng ý hoặc NO để chọn lại", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                        cbMa_Bc_Nhan.Value = cbMa_Bc_Nhan.Text
                    Else
                        Exit Sub
                    End If
                Else
                    MessageBox.Show("Mã bưu cục nhận không hợp lệ" & vbNewLine & "Bạn hãy nhập lại mã bưu cục nhận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    cbMa_Bc_Nhan.Focus()
                    Exit Sub
                End If
            End If
            'kiểm tra định dạng mã bc nhận
            If IsNumeric(cbMa_Bc_Gui.Value) Then
                If Convert.ToInt32(cbMa_Bc_Nhan.Value) > 999999 Or Convert.ToInt32(cbMa_Bc_Nhan.Value) < 100000 Then
                    MessageBox.Show("Mã bưu cục phải là số có 6 chữ số" & vbNewLine & "Bạn hãy nhập lại mã bưu cục gửi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    cbMa_Bc_Nhan.Focus()
                    Exit Sub
                End If
            Else
                MessageBox.Show("Mã bưu cục phải là số có 6 chữ số" & vbNewLine & "Bạn hãy nhập lại mã bưu cục gửi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cbMa_Bc_Nhan.Focus()
                Exit Sub
            End If

            If cbDot_Giao.Value Is Nothing Then
                MessageBox.Show("Bạn chưa đợt giao", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cbDot_Giao.Focus()
                Exit Sub
            End If

            If txtSo_Chuyen_Thu.Text.Length = 0 Or txtSo_Chuyen_Thu.Text = "0" Then
                MessageBox.Show("Bạn chưa nhập số chuyến thư", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtSo_Chuyen_Thu.Focus()
                Exit Sub
            ElseIf IsNumeric(txtSo_Chuyen_Thu.Text) = False Then
                MessageBox.Show("Số chuyến thư phải là kiểu số nguyên, xin hãy kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtSo_Chuyen_Thu.Focus()
                Exit Sub
            End If
            If txtTong_So_Tui.Text.Length = 0 Or txtTong_So_Tui.Text = "0" Then
                MessageBox.Show("Bạn chưa nhập tổng số túi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtTong_So_Tui.Focus()
                Exit Sub
            ElseIf IsNumeric(txtTong_So_Tui.Text) = False Then
                MessageBox.Show("Tổng số túi phải là kiểu số nguyên, xin hãy kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtTong_So_Tui.Focus()
                Exit Sub
            End If
            If txtTong_So_BP.Text.Length = 0 Or txtTong_So_BP.Text = "0" Then
                MessageBox.Show("Bạn chưa nhập tổng số bưu phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtTong_So_BP.Focus()
                Exit Sub
            ElseIf IsNumeric(txtTong_So_BP.Text) = False Then
                MessageBox.Show("Tổng số bưu phẩm phải là kiểu số nguyên, hãy kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtTong_So_BP.Focus()
                Exit Sub
            End If
            If txtTong_Khoi_Luong.Text.Length = 0 Or txtTong_Khoi_Luong.Text = "0" Then
                MessageBox.Show("Bạn chưa nhập tổng khối lượng bưu phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtTong_Khoi_Luong.Focus()
                Exit Sub
            ElseIf IsNumeric(txtTong_Khoi_Luong.Text) = False Then
                MessageBox.Show("Tổng khối lượng phải là kiểu số nguyên, xin hãy kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtTong_Khoi_Luong.Focus()
                Exit Sub
            End If
            If (cbMa_Bc_Gui.Value.ToString.Trim() = cbMa_Bc_Nhan.Value.ToString.Trim) Then
                MessageBox.Show("Mã bưu cục gửi và mã bưu cục đích không được phép giống nhau." & vbNewLine & "Bạn hãy kiểm tra lại", "Canh bao", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            'Nếu không bắn mã vạch thì tự sinh ID BC37
            txtSo_Hieu_BC37.Text = Create_BC37_ID(CInt(cbMa_Bc_Gui.Value), CInt(cbMa_Bc_Nhan.Value), Ham_Dung_Chung.ConvertDateToInt(cbNgayDong.Value), CInt(cbDot_Giao.Value))

            myQLTGND_TUYEN_VC_Chi_Tiet = myQLTGND_TUYEN_VC.QLTGND_TUYEN_VC_Lay(myId_Tuyen_VC)
            myQLTGND_CHANG_VC_Chi_Tiet = myQLTGND_CHANG_VC.QLTGND_CHANG_VC_Lay_Theo_BC_Goc_Dich(CInt(cbMa_Bc_Gui.Value), CInt(cbMa_Bc_Nhan.Value), myId_Tuyen_VC)
            With myQLTGND_BC37_DEN_Chi_Tiet
                .BC37_ID = txtSo_Hieu_BC37.Text.Trim
                .Chot_SL = False
                .Da_In = False
                .Dot_Giao = CInt(cbDot_Giao.Value)
                .Gio_Giao = Ham_Dung_Chung.ConvertTimeToInt(Date.Now)
                .Gio_He_Thong = Ham_Dung_Chung.ConvertTimeToInt(Date.Now)
                .Gio_Lap = Ham_Dung_Chung.ConvertTimeToInt(Date.Now)
                .Id_Ca = GId_Ca
                .Ma_Bc = CInt(cbMa_Bc_Gui.Value)
                .Ma_Bc_Khai_Thac = GBuu_Cuc_Khai_Thac
                .Id_Duong_Thu = CreateId_Duong_Thu(.Ma_Bc, .Ma_Bc_Khai_Thac)
                .Id_Nguoi_Dung = Gid_Nguoi_Dung
                .MAIL_ROUTE_ID = myId_Tuyen_VC
                .Ngay_Giao = Ham_Dung_Chung.ConvertDateToInt(cbNgayDong.Value)
                .Ngay_He_Thong = Ham_Dung_Chung.ConvertDateToInt(Date.Now)
                .Ngay_Lap = Ham_Dung_Chung.ConvertDateToInt(Date.Now)
                .PARTNER_ID = myQLTGND_TUYEN_VC_Chi_Tiet.PARTNER_ID.ToString
                .So_Chuyen_Thu = CInt(txtSo_Chuyen_Thu.Text)
                .Tong_So_Tui = CInt(txtTong_So_Tui.Text)
                .Tong_So_BP = CInt(txtTong_So_BP.Text)
                .Tong_KL = CInt(txtTong_Khoi_Luong.Text)
                .Tong_KLBP = CInt(txtTong_Khoi_Luong.Text)
                .Trang_Thai = Trang_Thai_Dang_Xac_Nhan
                .TRANSPORT_TYPE_ID = myQLTGND_TUYEN_VC_Chi_Tiet.TRANSPORT_TYPE_ID.ToString
                .TRANSPORT_NUMBER = myQLTGND_TUYEN_VC_Chi_Tiet.TRANSPORT_TYPE_ID.ToString
                .Truyen_Khai_Thac = 0
            End With
            'ghi dữ liệu vào qltgnd_bc37_den
            myQLTGND_BC37_DEN.QLTGND_BC37_DEN_Cap_Nhat_Them(myQLTGND_BC37_DEN_Chi_Tiet.BC37_ID, _
                myQLTGND_BC37_DEN_Chi_Tiet.Id_Duong_Thu, _
                myQLTGND_BC37_DEN_Chi_Tiet.Id_Ca, _
                myQLTGND_BC37_DEN_Chi_Tiet.Ma_Bc_Khai_Thac, _
                myQLTGND_BC37_DEN_Chi_Tiet.Ma_Bc, _
                myQLTGND_BC37_DEN_Chi_Tiet.Ngay_Lap, _
                myQLTGND_BC37_DEN_Chi_Tiet.Gio_Lap, _
                myQLTGND_BC37_DEN_Chi_Tiet.Dot_Giao, _
                myQLTGND_BC37_DEN_Chi_Tiet.Ngay_Giao, _
                myQLTGND_BC37_DEN_Chi_Tiet.Gio_Giao, _
                myQLTGND_BC37_DEN_Chi_Tiet.So_Chuyen_Thu, _
                myQLTGND_BC37_DEN_Chi_Tiet.Tong_So_Tui, _
                myQLTGND_BC37_DEN_Chi_Tiet.Tong_So_BP, _
                myQLTGND_BC37_DEN_Chi_Tiet.Tong_KL, _
                myQLTGND_BC37_DEN_Chi_Tiet.Tong_KLBP, _
                myQLTGND_BC37_DEN_Chi_Tiet.Id_Nguoi_Dung, _
                myQLTGND_BC37_DEN_Chi_Tiet.Ngay_He_Thong, _
                myQLTGND_BC37_DEN_Chi_Tiet.Gio_He_Thong, _
                myQLTGND_BC37_DEN_Chi_Tiet.Da_In, _
                myQLTGND_BC37_DEN_Chi_Tiet.Chot_SL, _
                myQLTGND_BC37_DEN_Chi_Tiet.Truyen_Khai_Thac, _
                myQLTGND_BC37_DEN_Chi_Tiet.Trang_Thai, _
                myQLTGND_BC37_DEN_Chi_Tiet.TRANSPORT_TYPE_ID, _
                myQLTGND_BC37_DEN_Chi_Tiet.TRANSPORT_NUMBER, _
                myQLTGND_BC37_DEN_Chi_Tiet.PARTNER_ID, _
                myQLTGND_BC37_DEN_Chi_Tiet.MAIL_ROUTE_ID, _
                Kiem_Tra_Qua_Giang(CInt(cbMa_Bc_Nhan.Value), GBuu_Cuc_Khai_Thac))
            myIsOK = True
            Me.Close()
            'Load data
            'Load_GiaoTuiDi(myQLTGND_BC37_DEN_Chi_Tiet.BC37_ID)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            myIsOK = False
        End Try
    End Sub

    Private Sub txtSo_Hieu_BC37_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSo_Hieu_BC37.Validated
        Dim myCodeBC37 As String
        myCodeBC37 = txtSo_Hieu_BC37.Text.Trim.ToUpper
        If myCodeBC37.Length = 0 Then
            Exit Sub
        End If
        Dim myDycryptBarCode As New DycryptBarCode.bc37code(myCodeBC37)
        If (myDycryptBarCode.NgayLapBC37 <> "") Then
            cbNgayDong.Value = CDate(myDycryptBarCode.NgayLapBC37)
            cbMa_Bc_Gui.Value = myDycryptBarCode.MaBuuCucGui
            cbMa_Bc_Nhan.Value = myDycryptBarCode.MaBuuCucNhan
            cbDot_Giao.Value = myDycryptBarCode.SoChuyenThu
        Else
            MessageBox.Show("Mã BC37 không hợp lệ bạn hãy nhập chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtSo_Hieu_BC37.Focus()
            txtSo_Hieu_BC37.SelectAll()
        End If

    End Sub

    Private Sub FrmNhap_Thay_The_BC37_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

    End Sub

    Private Sub txtSo_Hieu_BC37_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSo_Hieu_BC37.ValueChanged

    End Sub
End Class

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

Public Class FrmEventViewer
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
    Friend WithEvents chkMa_Bc_Khai_Thac As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkBo_Phan As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkDoi_Tuong As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkNgay As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents btnLoad As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnExit As Infragistics.Win.Misc.UltraButton
    Friend WithEvents grbThong_Tin As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents dtpTu_Ngay As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgChi_Tiet As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dtpDen_Ngay As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbMa_Bc_Khai_Thac As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbBo_Phan As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbDoi_Tuong As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents grbChi_Tiet_Event As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtInfo As System.Windows.Forms.TextBox
    Friend WithEvents btnPrint As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnClose As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEventViewer))
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Doi_Tuong", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Doi_Tuong")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Doi_Tuong")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Bo_Phan", -1)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bo_Phan")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Bo_Phan")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Bc_Khai_Thac", -1)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Bc_Khai_Thac")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OutBout")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Event_Viewer", -1)
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Log_Id")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Bc_Khai_Thac")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Su_Kien")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Bo_Phan")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Doi_Tuong")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Sever")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Sever")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nhan_Vien")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Nhan_Vien")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ip_May_Tinh")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chi_Tiet_Truoc")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chi_Tiet_Sau")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_He_Thong")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_He_Thong")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Xem_Chi_Tiet")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.grbThong_Tin = New Infragistics.Win.Misc.UltraGroupBox
        Me.grbChi_Tiet_Event = New Infragistics.Win.Misc.UltraGroupBox
        Me.btnClose = New Infragistics.Win.Misc.UltraButton
        Me.btnPrint = New Infragistics.Win.Misc.UltraButton
        Me.txtInfo = New System.Windows.Forms.TextBox
        Me.cbDoi_Tuong = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cbBo_Phan = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cbMa_Bc_Khai_Thac = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.dgChi_Tiet = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpDen_Ngay = New System.Windows.Forms.DateTimePicker
        Me.dtpTu_Ngay = New System.Windows.Forms.DateTimePicker
        Me.btnExit = New Infragistics.Win.Misc.UltraButton
        Me.btnLoad = New Infragistics.Win.Misc.UltraButton
        Me.chkNgay = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkDoi_Tuong = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkBo_Phan = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkMa_Bc_Khai_Thac = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        CType(Me.grbThong_Tin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbThong_Tin.SuspendLayout()
        CType(Me.grbChi_Tiet_Event, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbChi_Tiet_Event.SuspendLayout()
        CType(Me.cbDoi_Tuong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbBo_Phan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMa_Bc_Khai_Thac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgChi_Tiet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbThong_Tin
        '
        Me.grbThong_Tin.Controls.Add(Me.grbChi_Tiet_Event)
        Me.grbThong_Tin.Controls.Add(Me.cbDoi_Tuong)
        Me.grbThong_Tin.Controls.Add(Me.cbBo_Phan)
        Me.grbThong_Tin.Controls.Add(Me.cbMa_Bc_Khai_Thac)
        Me.grbThong_Tin.Controls.Add(Me.dgChi_Tiet)
        Me.grbThong_Tin.Controls.Add(Me.Label1)
        Me.grbThong_Tin.Controls.Add(Me.Label2)
        Me.grbThong_Tin.Controls.Add(Me.dtpDen_Ngay)
        Me.grbThong_Tin.Controls.Add(Me.dtpTu_Ngay)
        Me.grbThong_Tin.Controls.Add(Me.btnExit)
        Me.grbThong_Tin.Controls.Add(Me.btnLoad)
        Me.grbThong_Tin.Controls.Add(Me.chkNgay)
        Me.grbThong_Tin.Controls.Add(Me.chkDoi_Tuong)
        Me.grbThong_Tin.Controls.Add(Me.chkBo_Phan)
        Me.grbThong_Tin.Controls.Add(Me.chkMa_Bc_Khai_Thac)
        Me.grbThong_Tin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbThong_Tin.Location = New System.Drawing.Point(0, 8)
        Me.grbThong_Tin.Name = "grbThong_Tin"
        Me.grbThong_Tin.Size = New System.Drawing.Size(792, 560)
        Me.grbThong_Tin.SupportThemes = False
        Me.grbThong_Tin.TabIndex = 0
        Me.grbThong_Tin.Text = "System Event Viewer"
        '
        'grbChi_Tiet_Event
        '
        Me.grbChi_Tiet_Event.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.grbChi_Tiet_Event.Controls.Add(Me.btnClose)
        Me.grbChi_Tiet_Event.Controls.Add(Me.btnPrint)
        Me.grbChi_Tiet_Event.Controls.Add(Me.txtInfo)
        Me.grbChi_Tiet_Event.ForeColor = System.Drawing.SystemColors.ControlText
        Appearance1.BorderColor = System.Drawing.Color.Transparent
        Appearance1.FontData.BoldAsString = "True"
        Appearance1.ForeColor = System.Drawing.Color.Red
        Me.grbChi_Tiet_Event.HeaderAppearance = Appearance1
        Me.grbChi_Tiet_Event.HeaderBorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.grbChi_Tiet_Event.Location = New System.Drawing.Point(128, 160)
        Me.grbChi_Tiet_Event.Name = "grbChi_Tiet_Event"
        Me.grbChi_Tiet_Event.Size = New System.Drawing.Size(504, 360)
        Me.grbChi_Tiet_Event.SupportThemes = False
        Me.grbChi_Tiet_Event.TabIndex = 18
        Me.grbChi_Tiet_Event.Text = "Thông tin chi tiết của Event :"
        Me.grbChi_Tiet_Event.Visible = False
        '
        'btnClose
        '
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.btnClose.Appearance = Appearance2
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ImageSize = New System.Drawing.Size(18, 18)
        Me.btnClose.Location = New System.Drawing.Point(264, 320)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(88, 32)
        Me.btnClose.TabIndex = 20
        Me.btnClose.Text = "&Close"
        '
        'btnPrint
        '
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        Me.btnPrint.Appearance = Appearance3
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnPrint.Location = New System.Drawing.Point(152, 320)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(88, 32)
        Me.btnPrint.TabIndex = 19
        Me.btnPrint.Text = "&Print"
        '
        'txtInfo
        '
        Me.txtInfo.BackColor = System.Drawing.Color.Bisque
        Me.txtInfo.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfo.ForeColor = System.Drawing.Color.Navy
        Me.txtInfo.Location = New System.Drawing.Point(8, 24)
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.Size = New System.Drawing.Size(488, 288)
        Me.txtInfo.TabIndex = 18
        Me.txtInfo.Text = ""
        '
        'cbDoi_Tuong
        '
        Me.cbDoi_Tuong.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance4.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.cbDoi_Tuong.DisplayLayout.Appearance = Appearance4
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.Caption = "Đối tượng"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2})
        UltraGridBand1.Header.Caption = "Đường thư"
        Me.cbDoi_Tuong.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance5.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance5.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbDoi_Tuong.DisplayLayout.Override.HeaderAppearance = Appearance5
        Me.cbDoi_Tuong.DisplayMember = "Ten_Doi_Tuong"
        Me.cbDoi_Tuong.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDoi_Tuong.Location = New System.Drawing.Point(584, 72)
        Me.cbDoi_Tuong.Name = "cbDoi_Tuong"
        Me.cbDoi_Tuong.Size = New System.Drawing.Size(64, 22)
        Me.cbDoi_Tuong.TabIndex = 16
        Me.cbDoi_Tuong.ValueMember = "Ma_Doi_Tuong"
        '
        'cbBo_Phan
        '
        Me.cbBo_Phan.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.cbBo_Phan.DisplayLayout.Appearance = Appearance6
        UltraGridColumn3.Header.VisiblePosition = 0
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.Caption = "Bộ phận"
        UltraGridColumn4.Header.VisiblePosition = 1
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn3, UltraGridColumn4})
        UltraGridBand2.Header.Caption = "Đường thư"
        Me.cbBo_Phan.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Appearance7.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance7.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance7.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance7.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbBo_Phan.DisplayLayout.Override.HeaderAppearance = Appearance7
        Me.cbBo_Phan.DisplayMember = "Ten_Bo_Phan"
        Me.cbBo_Phan.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBo_Phan.Location = New System.Drawing.Point(336, 72)
        Me.cbBo_Phan.Name = "cbBo_Phan"
        Me.cbBo_Phan.Size = New System.Drawing.Size(136, 22)
        Me.cbBo_Phan.TabIndex = 15
        Me.cbBo_Phan.ValueMember = "Ma_Bo_Phan"
        '
        'cbMa_Bc_Khai_Thac
        '
        Me.cbMa_Bc_Khai_Thac.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.cbMa_Bc_Khai_Thac.DisplayLayout.Appearance = Appearance8
        UltraGridColumn5.Header.Caption = "Mã bưu cục"
        UltraGridColumn5.Header.VisiblePosition = 0
        UltraGridColumn6.Header.Caption = "Tên bưu cục"
        UltraGridColumn6.Header.VisiblePosition = 1
        UltraGridColumn7.Header.VisiblePosition = 2
        UltraGridColumn7.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn5, UltraGridColumn6, UltraGridColumn7})
        UltraGridBand3.Header.Caption = "Đường thư"
        Me.cbMa_Bc_Khai_Thac.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Appearance9.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance9.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance9.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance9.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbMa_Bc_Khai_Thac.DisplayLayout.Override.HeaderAppearance = Appearance9
        Me.cbMa_Bc_Khai_Thac.DisplayMember = "Ma_Bc_Khai_Thac"
        Me.cbMa_Bc_Khai_Thac.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMa_Bc_Khai_Thac.Location = New System.Drawing.Point(144, 72)
        Me.cbMa_Bc_Khai_Thac.Name = "cbMa_Bc_Khai_Thac"
        Me.cbMa_Bc_Khai_Thac.Size = New System.Drawing.Size(96, 22)
        Me.cbMa_Bc_Khai_Thac.TabIndex = 14
        Me.cbMa_Bc_Khai_Thac.ValueMember = "Ma_Bc_Khai_Thac"
        '
        'dgChi_Tiet
        '
        Me.dgChi_Tiet.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgChi_Tiet.DisplayLayout.AddNewBox.Prompt = " "
        Appearance10.BackColor = System.Drawing.Color.White
        Appearance10.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgChi_Tiet.DisplayLayout.Appearance = Appearance10
        UltraGridColumn8.Header.VisiblePosition = 0
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.Caption = "Mã BCKT"
        UltraGridColumn9.Header.VisiblePosition = 1
        UltraGridColumn9.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn9.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn9.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(77, 0)
        UltraGridColumn9.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn9.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn10.Header.Caption = "Tên Bc Khai Thác"
        UltraGridColumn10.Header.VisiblePosition = 2
        UltraGridColumn10.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn10.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn10.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn10.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn11.Header.Caption = "Sự kiện"
        UltraGridColumn11.Header.VisiblePosition = 3
        UltraGridColumn11.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn11.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn11.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(67, 0)
        UltraGridColumn11.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn11.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn12.Header.Caption = "Bộ phận"
        UltraGridColumn12.Header.VisiblePosition = 4
        UltraGridColumn12.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn12.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn12.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(115, 0)
        UltraGridColumn12.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn12.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn13.Header.Caption = "Đối tượng"
        UltraGridColumn13.Header.VisiblePosition = 5
        UltraGridColumn13.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn13.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn13.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(66, 0)
        UltraGridColumn13.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn13.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn14.Format = "dd/MM/yyyy"
        UltraGridColumn14.Header.Caption = "Ngày"
        UltraGridColumn14.Header.VisiblePosition = 6
        UltraGridColumn14.MaskInput = ""
        UltraGridColumn14.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn14.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn14.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(85, 0)
        UltraGridColumn14.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn14.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn15.Header.Caption = "Giờ"
        UltraGridColumn15.Header.VisiblePosition = 7
        UltraGridColumn15.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn15.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn15.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(59, 0)
        UltraGridColumn15.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn15.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn16.Header.Caption = "Mã NV"
        UltraGridColumn16.Header.VisiblePosition = 8
        UltraGridColumn16.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn16.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn16.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(48, 0)
        UltraGridColumn16.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn16.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn17.Header.Caption = "Tên nhân viên"
        UltraGridColumn17.Header.VisiblePosition = 9
        UltraGridColumn17.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn17.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn17.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(121, 0)
        UltraGridColumn17.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn17.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn18.Header.Caption = "Ip máy tính"
        UltraGridColumn18.Header.VisiblePosition = 10
        UltraGridColumn18.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn18.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn18.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn18.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn19.Header.Caption = "Chi tiết trước"
        UltraGridColumn19.Header.VisiblePosition = 11
        UltraGridColumn19.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn19.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn19.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(240, 0)
        UltraGridColumn19.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn19.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn20.Header.Caption = "Chi tiết sau"
        UltraGridColumn20.Header.VisiblePosition = 12
        UltraGridColumn20.RowLayoutColumnInfo.OriginX = 24
        UltraGridColumn20.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn20.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(215, 0)
        UltraGridColumn20.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn20.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn21.Header.VisiblePosition = 13
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.VisiblePosition = 14
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always
        Appearance11.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn23.CellAppearance = Appearance11
        UltraGridColumn23.Header.Caption = ""
        UltraGridColumn23.Header.VisiblePosition = 15
        UltraGridColumn23.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn23.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn23.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(72, 0)
        UltraGridColumn23.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn23.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn23.ShowInkButton = Infragistics.Win.ShowInkButton.Always
        UltraGridColumn23.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23})
        UltraGridBand4.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Both
        UltraGridBand4.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Both
        UltraGridBand4.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand4.UseRowLayout = True
        Me.dgChi_Tiet.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.dgChi_Tiet.DisplayLayout.InterBandSpacing = 10
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Me.dgChi_Tiet.DisplayLayout.Override.CardAreaAppearance = Appearance12
        Me.dgChi_Tiet.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance13.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance13.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance13.ForeColor = System.Drawing.Color.Black
        Appearance13.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance13.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgChi_Tiet.DisplayLayout.Override.HeaderAppearance = Appearance13
        Appearance14.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgChi_Tiet.DisplayLayout.Override.RowAppearance = Appearance14
        Appearance15.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance15.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgChi_Tiet.DisplayLayout.Override.RowSelectorAppearance = Appearance15
        Me.dgChi_Tiet.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgChi_Tiet.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance16.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance16.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance16.ForeColor = System.Drawing.Color.Black
        Me.dgChi_Tiet.DisplayLayout.Override.SelectedRowAppearance = Appearance16
        Me.dgChi_Tiet.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgChi_Tiet.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgChi_Tiet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgChi_Tiet.Location = New System.Drawing.Point(8, 112)
        Me.dgChi_Tiet.Name = "dgChi_Tiet"
        Me.dgChi_Tiet.Size = New System.Drawing.Size(776, 440)
        Me.dgChi_Tiet.TabIndex = 13
        Me.dgChi_Tiet.Text = "Event Viewer List"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(144, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Từ ngày"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(352, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Đến ngày"
        '
        'dtpDen_Ngay
        '
        Me.dtpDen_Ngay.CustomFormat = "dd/MM/yyyy"
        Me.dtpDen_Ngay.Enabled = False
        Me.dtpDen_Ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDen_Ngay.Location = New System.Drawing.Point(424, 32)
        Me.dtpDen_Ngay.Name = "dtpDen_Ngay"
        Me.dtpDen_Ngay.Size = New System.Drawing.Size(96, 21)
        Me.dtpDen_Ngay.TabIndex = 4
        '
        'dtpTu_Ngay
        '
        Me.dtpTu_Ngay.CustomFormat = "dd/MM/yyyy"
        Me.dtpTu_Ngay.Enabled = False
        Me.dtpTu_Ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTu_Ngay.Location = New System.Drawing.Point(208, 32)
        Me.dtpTu_Ngay.Name = "dtpTu_Ngay"
        Me.dtpTu_Ngay.Size = New System.Drawing.Size(104, 21)
        Me.dtpTu_Ngay.TabIndex = 2
        '
        'btnExit
        '
        Appearance17.Image = CType(resources.GetObject("Appearance17.Image"), Object)
        Me.btnExit.Appearance = Appearance17
        Me.btnExit.ImageSize = New System.Drawing.Size(18, 18)
        Me.btnExit.Location = New System.Drawing.Point(672, 64)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(112, 32)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "&Exit"
        '
        'btnLoad
        '
        Appearance18.Image = CType(resources.GetObject("Appearance18.Image"), Object)
        Me.btnLoad.Appearance = Appearance18
        Me.btnLoad.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnLoad.Location = New System.Drawing.Point(672, 24)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(112, 32)
        Me.btnLoad.TabIndex = 11
        Me.btnLoad.Text = "&Xem Log"
        '
        'chkNgay
        '
        Me.chkNgay.Location = New System.Drawing.Point(16, 33)
        Me.chkNgay.Name = "chkNgay"
        Me.chkNgay.Size = New System.Drawing.Size(104, 20)
        Me.chkNgay.TabIndex = 0
        Me.chkNgay.Text = "Ngày sự kiện"
        '
        'chkDoi_Tuong
        '
        Me.chkDoi_Tuong.Location = New System.Drawing.Point(496, 75)
        Me.chkDoi_Tuong.Name = "chkDoi_Tuong"
        Me.chkDoi_Tuong.Size = New System.Drawing.Size(80, 20)
        Me.chkDoi_Tuong.TabIndex = 9
        Me.chkDoi_Tuong.Text = "Đối tượng"
        '
        'chkBo_Phan
        '
        Me.chkBo_Phan.Location = New System.Drawing.Point(256, 75)
        Me.chkBo_Phan.Name = "chkBo_Phan"
        Me.chkBo_Phan.Size = New System.Drawing.Size(72, 20)
        Me.chkBo_Phan.TabIndex = 7
        Me.chkBo_Phan.Text = "Bộ phận"
        '
        'chkMa_Bc_Khai_Thac
        '
        Me.chkMa_Bc_Khai_Thac.Location = New System.Drawing.Point(16, 75)
        Me.chkMa_Bc_Khai_Thac.Name = "chkMa_Bc_Khai_Thac"
        Me.chkMa_Bc_Khai_Thac.TabIndex = 5
        Me.chkMa_Bc_Khai_Thac.Text = "Mã Bc Khai Thác"
        '
        'FrmEventViewer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.Add(Me.grbThong_Tin)
        Me.Name = "FrmEventViewer"
        Me.Text = "Ems International System Event Viewer"
        CType(Me.grbThong_Tin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbThong_Tin.ResumeLayout(False)
        CType(Me.grbChi_Tiet_Event, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbChi_Tiet_Event.ResumeLayout(False)
        CType(Me.cbDoi_Tuong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbBo_Phan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMa_Bc_Khai_Thac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgChi_Tiet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Khai báo biến toàn form"
    Dim myMa_Bc_Khai_Thac As New Ma_Bc_Khai_Thac(GConnectionString)
    Dim myEvent_Viewer As New Event_Viewer(GConnectionString)
    Dim myDuong_Thu_Den As New Duong_Thu_Den(GConnectionString)
    Dim myDuong_Thu_Di As New Duong_Thu_Di(GConnectionString)
    Dim myDanh_Muc_Bc As New Danh_Muc_BC(GConnectionString)
    Dim myHam_Dung_Chung As New Ham_Dung_Chung
    Dim myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Dim myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
#End Region

#Region "Form Load"
    Private Sub FrmEventViewer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            chkNgay.Checked = True
            chkMa_Bc_Khai_Thac.Checked = False
            chkDoi_Tuong.Checked = False
            chkBo_Phan.Checked = False
            chkNgay_CheckedChanged(chkNgay, e)
            chkMa_Bc_Khai_Thac_CheckedChanged(chkNgay, e)
            chkDoi_Tuong_CheckedChanged(chkNgay, e)
            chkBo_Phan_CheckedChanged(chkNgay, e)
            Load_Data()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Các hàm người dùng viết"

#Region "Lấy dữ liệu cho các đối tượng trên form"
    Private Sub Load_Data()
        Try
            'Ngay
            dtpTu_Ngay.Value = Now().Date
            dtpDen_Ngay.Value = Now().Date
            'Bo_Phan
            Load_Data_Cbo_Bo_Phan()
            'Doi_Tuong
            Load_Data_Cbo_Doi_Tuong()
            'Ma_Bc_Khai_Thac
            Load_Data_Cbo_Ma_Bc_Khai_Thac()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Load dữ liệu cho Combo Bộ phận"
    Private Sub Load_Data_Cbo_Bo_Phan()
        Try
            'Them moi mot bang
            Dim dataTable As New dataTable("Bo_Phan")

            'Tao ra cac cot cua bang nay
            Dim colWork As DataColumn = New DataColumn("Ma_Bo_Phan", GetType(Int32))
            dataTable.Columns.Add(colWork)
            colWork = New DataColumn("Ten_Bo_Phan", GetType(String))
            dataTable.Columns.Add(colWork)

            'Them du lieu vao
            Dim row As DataRow = dataTable.NewRow()
            row("Ma_Bo_Phan") = 1
            row("Ten_Bo_Phan") = "Xác nhận đến"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Ma_Bo_Phan") = 2
            row("Ten_Bo_Phan") = "Thiết lập đi"
            dataTable.Rows.Add(row)

            cbBo_Phan.DataSource = dataTable
            cbBo_Phan.DataBind()
            'cbBo_Phan.LimitToList = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Load dữ liệu cho Combo Đối tượng"
    Private Sub Load_Data_Cbo_Doi_Tuong()
        Try
            'Them moi mot bang
            Dim dataTable As New dataTable("Doi_Tuong")

            'Tao ra cac cot cua bang nay
            Dim colWork As DataColumn = New DataColumn("Ma_Doi_Tuong", GetType(Int32))
            dataTable.Columns.Add(colWork)
            colWork = New DataColumn("Ten_Doi_Tuong", GetType(String))
            dataTable.Columns.Add(colWork)

            'Them du lieu vao
            Dim row As DataRow = dataTable.NewRow()
            row("Ma_Doi_Tuong") = 1
            row("Ten_Doi_Tuong") = "E1"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Ma_Doi_Tuong") = 2
            row("Ten_Doi_Tuong") = "E2"
            dataTable.Rows.Add(row)

            cbDoi_Tuong.DataSource = dataTable
            cbDoi_Tuong.DataBind()
            'cbDoi_Tuong.LimitToList = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Load dữ liệu cho Combo Mã bưu cục khai thác"
    Private Sub Load_Data_Cbo_Ma_Bc_Khai_Thac()
        Try
            cbMa_Bc_Khai_Thac.DataSource = myMa_Bc_Khai_Thac.Danh_Sach().Tables(0)
            cbMa_Bc_Khai_Thac.DataBind()
            'cbMa_Bc_Khai_Thac.LimitToList = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Kiem Tra Kieu Tim Kiem"
    Private Function Xac_Dinh_Kieu_Tim_Kiem() As Integer
        Try
            Dim mIs_Ngay As Byte
            Dim mIs_Ma_Bc_Khai_Thac As Byte
            Dim mIs_Bo_Phan As Byte
            Dim mIs_Doi_Tuong As Byte
            'Kiem tra Kieu tim kiem
            If chkNgay.Checked And dtpTu_Ngay.Text <> "" And dtpDen_Ngay.Text <> "" Then
                mIs_Ngay = 1
            Else
                mIs_Ngay = 0
            End If
            If chkMa_Bc_Khai_Thac.Checked And cbMa_Bc_Khai_Thac.Text <> "" Then
                mIs_Ma_Bc_Khai_Thac = 1
            Else
                mIs_Ma_Bc_Khai_Thac = 0
            End If
            If chkDoi_Tuong.Checked And cbDoi_Tuong.Text <> "" Then
                mIs_Doi_Tuong = 1
            Else
                mIs_Doi_Tuong = 0
            End If
            If chkBo_Phan.Checked And cbBo_Phan.Text <> "" Then
                mIs_Bo_Phan = 1
            Else
                mIs_Bo_Phan = 0
            End If
            Return mIs_Ma_Bc_Khai_Thac * 8 + mIs_Bo_Phan * 4 + mIs_Doi_Tuong * 2 + mIs_Ngay * 1
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
    End Function

#End Region

#End Region

#Region "Tab Control"

#Region "chkNgay_CheckedChanged"
    Private Sub chkNgay_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkNgay.CheckedChanged
        dtpTu_Ngay.Enabled = chkNgay.Checked
        dtpDen_Ngay.Enabled = chkNgay.Checked
    End Sub
#End Region

#Region "chkMa_Bc_Khai_Thac_CheckedChanged"
    Private Sub chkMa_Bc_Khai_Thac_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkMa_Bc_Khai_Thac.CheckedChanged
        cbMa_Bc_Khai_Thac.Enabled = chkMa_Bc_Khai_Thac.Checked
        If chkMa_Bc_Khai_Thac.Checked Then
            If Not cbMa_Bc_Khai_Thac.IsDroppedDown Then
                cbMa_Bc_Khai_Thac.ToggleDropdown()
            End If
        Else
            cbMa_Bc_Khai_Thac.Text = ""
        End If
    End Sub
#End Region

#Region "chkDoi_Tuong_CheckedChanged"
    Private Sub chkDoi_Tuong_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDoi_Tuong.CheckedChanged
        cbDoi_Tuong.Enabled = chkDoi_Tuong.Checked
        If chkDoi_Tuong.Checked Then
            If Not cbDoi_Tuong.IsDroppedDown Then
                cbDoi_Tuong.ToggleDropdown()
            End If
        Else
            cbDoi_Tuong.Text = ""
        End If
    End Sub
#End Region

#Region "chkBo_Phan_CheckedChanged"
    Private Sub chkBo_Phan_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkBo_Phan.CheckedChanged
        cbBo_Phan.Enabled = chkBo_Phan.Checked
        If chkBo_Phan.Checked Then
            If Not cbBo_Phan.IsDroppedDown Then
                cbBo_Phan.ToggleDropdown()
            End If
        Else
            cbBo_Phan.Text = ""
        End If
    End Sub
#End Region

#Region "btnExit_Click"
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
        Me.Dispose()
    End Sub
#End Region

#Region "btnLoad_Click"
    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        'Kiem tra du lieu nguoi dung nhap vao co hop le khong
        If chkNgay.Checked Then
            If dtpTu_Ngay.Value > dtpDen_Ngay.Value Then
                MessageBox.Show("Ngày nhập vào không hợp lệ. Từ ngày không được lớn hơn đến ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                dtpTu_Ngay.Select()
                Exit Sub
            End If
        End If
        Dim mKieu_Tim_Kiem As Integer
        mKieu_Tim_Kiem = Xac_Dinh_Kieu_Tim_Kiem()
        If mKieu_Tim_Kiem = 0 Then
            MessageBox.Show("Bạn phải chọn ít nhất một điều kiện để lọc thông tin nhật ký.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            Dim mChi_Tiet As New DataTable
            mChi_Tiet = myEvent_Viewer.Event_Viewer_Danh_Sach_Tim_Kiem(mKieu_Tim_Kiem, cbMa_Bc_Khai_Thac.Value, cbBo_Phan.Value, cbDoi_Tuong.Value, myHam_Dung_Chung.ConvertDateToInt(dtpTu_Ngay.Value), myHam_Dung_Chung.ConvertDateToInt(dtpDen_Ngay.Value)).Tables(0)
            dgChi_Tiet.DataSource = mChi_Tiet
            dgChi_Tiet.DataBind()
            If mChi_Tiet.Rows.Count = 0 Then
                MessageBox.Show("Không có dữ liệu nhật ký.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
#End Region

#Region "dgChi_Tiet_InitializeLayout"
    Private Sub dgChi_Tiet_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgChi_Tiet.InitializeLayout
        myGridKeyDown = sender
        myGridKeyDown.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        myGridKeyDown.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
        Dim idx As Integer
        For idx = 0 To myGridKeyDown.DisplayLayout.Bands(0).Columns.Count - 1
            myGridKeyDown.DisplayLayout.Bands(0).Columns(idx).CellActivation = Activation.ActivateOnly
        Next
    End Sub
#End Region

#Region "dgChi_Tiet_KeyDown"
    Private Sub dgChi_Tiet_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgChi_Tiet.KeyDown
        Try
            myGridKeyDown = sender
            If myGridKeyDown.ActiveCell Is Nothing Then
                Exit Sub
            End If
            'Kiem tra cac loai Keys
            Select Case e.KeyValue
                Case Keys.Enter
                    myGridKeyDown.PerformAction(NextCellByTab, False, False)
                    e.Handled = True
                    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                Case Keys.Right
                    If myGridKeyDown.ActiveCell.Activation = Activation.AllowEdit Then
                        If myGridKeyDown.ActiveCell.Text <> "" And myGridKeyDown.ActiveCell.SelStart = myGridKeyDown.ActiveCell.Text.Length Then
                            e.Handled = False
                            myGridKeyDown.PerformAction(EnterEditMode, False, False)
                            myGridKeyDown.PerformAction(NextCellByTab, False, True)
                        End If
                    Else
                        e.Handled = False
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                        myGridKeyDown.PerformAction(NextCellByTab, False, True)
                    End If
                Case Keys.Left
                    If myGridKeyDown.ActiveCell.Activation = Activation.AllowEdit Then
                        If myGridKeyDown.ActiveCell.Text = "" Or myGridKeyDown.ActiveCell.SelStart = 0 Then
                            e.Handled = False
                            myGridKeyDown.PerformAction(EnterEditMode, False, False)
                            myGridKeyDown.PerformAction(PrevCellByTab, False, True)
                        End If
                    Else
                        e.Handled = False
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                        myGridKeyDown.PerformAction(PrevCellByTab, False, True)
                    End If
                Case Keys.Up
                    If myGridKeyDown.ActiveCell.Activation = Activation.AllowEdit Then
                        If myGridKeyDown.ActiveRow.Index > 0 Then
                            myCell = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index - 1).Cells(myGridKeyDown.ActiveCell.Column.Key)
                            myGridKeyDown.ActiveCell = myCell
                            myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                        End If
                    Else
                        myCell = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index - 1).Cells(myGridKeyDown.ActiveCell.Column.Key)
                        myGridKeyDown.ActiveCell = myCell
                        myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                    End If
                Case Keys.Down
                    If myGridKeyDown.ActiveRow.Index < myGridKeyDown.Rows.Count - 1 Then
                        myCell = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index + 1).Cells(myGridKeyDown.ActiveCell.Column.Key)
                        myGridKeyDown.ActiveCell = myCell
                        myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                    End If
            End Select
        Catch ex As Exception
            ' Call the exception handler
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Phần chi tiết từng Event"

#Region "dgChi_Tiet_ClickCellButton"
    Private Sub dgChi_Tiet_ClickCellButton(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgChi_Tiet.ClickCellButton
        Try
            myGridKeyDown = sender
            If myGridKeyDown.ActiveRow.Cells("Log_Id").Text = "" Or myGridKeyDown.ActiveRow.Cells("Log_Id").Value Is DBNull.Value Then
                Exit Sub
            Else
                Dim mLog_Id As Integer
                Dim mSu_Kien As String
                Dim mDoi_Tuong As String
                Dim mEvent_Viewer_Chi_Tiet As New Event_Viewer_Chi_Tiet
                mLog_Id = myGridKeyDown.ActiveRow.Cells("Log_Id").Value
                mSu_Kien = myGridKeyDown.ActiveRow.Cells("Su_Kien").Text
                mDoi_Tuong = myGridKeyDown.ActiveRow.Cells("Doi_Tuong").Text
                '                mEvent_Viewer_Chi_Tiet = myEvent_Viewer.Event_Viewer_Lay(mLog_Id)
                grbChi_Tiet_Event.Visible = True
                grbChi_Tiet_Event.Text = "Thông tin chi tiết của Event : " & mLog_Id.ToString & ".         Loại sự kiện:   " & mSu_Kien & "   " & mDoi_Tuong
                Select Case mDoi_Tuong.Trim
                    Case "E1"
                        'Dinh dang:  
                        '============== Thông tin E1 ========================
                        '           + Ngày/Giờ sự kiện:
                        '           + Ip máy tính:
                        '           + Nhân viên: 
                        '           + Số hiệu E1:
                        '           + BC Khai Thác: (Ma + Ten)
                        '           + Đường thư:
                        '           + Ngày/Giờ đóng:
                        '           + Chuyến thư: (So_CT + Loai_CT)
                        '           + Túi số:
                        'Thong tin truoc            Thong tin sau   
                        '----------------------------------------------------
                        '           + Phân loại:
                        '           + Khối lượng:
                        'Ngay Gio Su Kien
                        Dim mNgay_Gio_Su_Kien As String = myGridKeyDown.ActiveRow.Cells("Ngay_Sever").Text & "    " & myGridKeyDown.ActiveRow.Cells("Gio_Sever").Text
                        'Ip May Tinh
                        Dim mIp_May_Tinh As String = myGridKeyDown.ActiveRow.Cells("Ip_May_Tinh").Text
                        'Ten Nhan Vien
                        Dim mNhan_Vien As String = myGridKeyDown.ActiveRow.Cells("Ten_Nhan_Vien").Text
                        'Ma E1
                        Dim mMa_E1 As String = Cut_Txt_To_Field(myGridKeyDown.ActiveRow.Cells("Chi_Tiet_Truoc").Text, "_", 6)
                        'Buu Cuc Khai Thac
                        Dim mBC_Khai_Thac As String = myGridKeyDown.ActiveRow.Cells("Ma_Bc_Khai_Thac").Text
                        'Bo Phan
                        Dim mBo_Phan As String
                        If myGridKeyDown.ActiveRow.Cells("Bo_Phan").Text = "Xac Nhan Den" Then
                            mBo_Phan = "Xác nhận đến"
                        Else
                            mBo_Phan = "Thiết lập đi"
                        End If
                        'Duong_Thu
                        Dim mDuong_Thu As String
                        Dim mId_Duong_Thu As String
                        If myGridKeyDown.ActiveRow.Cells("Bo_Phan").Text = "Xac Nhan Den" Then   'Xac nhan den
                            mId_Duong_Thu = Cut_Txt_To_Field(myGridKeyDown.ActiveRow.Cells("Chi_Tiet_Truoc").Text, "_", 1)
                            Dim mMa_Bc As Integer
                            mMa_Bc = myDuong_Thu_Den.Lay(mId_Duong_Thu).Ma_Bc
                            mDuong_Thu = mMa_Bc.ToString & " - " & myDanh_Muc_Bc.Lay(mMa_Bc).Ten_Buu_Cuc
                        Else  'Thiet lap di
                            mId_Duong_Thu = Cut_Txt_To_Field(myGridKeyDown.ActiveRow.Cells("Chi_Tiet_Truoc").Text, "_", 1)
                            Dim mMa_Bc As Integer
                            mMa_Bc = myDuong_Thu_Di.Lay(mId_Duong_Thu).Ma_Bc
                            mDuong_Thu = mMa_Bc.ToString & " - " & myDanh_Muc_Bc.Lay(mMa_Bc).Ten_Buu_Cuc
                        End If
                        'Ngay Gio Dong
                        Dim mNgay_Dong As String = myHam_Dung_Chung.ConvertIntToVNDateType(Cut_Txt_To_Field(myGridKeyDown.ActiveRow.Cells("Chi_Tiet_Truoc").Text, "_", 2))
                        'Chuyen Thu
                        Dim mChuyen_Thu As String = Cut_Txt_To_Field(myGridKeyDown.ActiveRow.Cells("Chi_Tiet_Truoc").Text, "_", 4) & " - " & Cut_Txt_To_Field(myGridKeyDown.ActiveRow.Cells("Chi_Tiet_Truoc").Text, "_", 3)
                        'Tui So
                        Dim mTui_So As String = Cut_Txt_To_Field(myGridKeyDown.ActiveRow.Cells("Chi_Tiet_Truoc").Text, "_", 5)
                        'Phan Loai
                        Dim mPhan_Loai_Truoc As String = Cut_Txt_To_Field(myGridKeyDown.ActiveRow.Cells("Chi_Tiet_Truoc").Text, "_", 8)
                        Dim mPhan_Loai_Sau As String = Cut_Txt_To_Field(myGridKeyDown.ActiveRow.Cells("Chi_Tiet_Sau").Text, "_", 8)
                        'Khoi_Luong
                        Dim mKhoi_Luong_Truoc As String = Cut_Txt_To_Field(myGridKeyDown.ActiveRow.Cells("Chi_Tiet_Truoc").Text, "_", 7)
                        Dim mKhoi_Luong_Sau As String = Cut_Txt_To_Field(myGridKeyDown.ActiveRow.Cells("Chi_Tiet_Sau").Text, "_", 7)
                        'Thong tin 
                        txtInfo.Text = vbNewLine & _
                                       "====================== Thông tin E1 ======================" & vbNewLine & _
                                       LSet("    + Ngày/Giờ sự kiện:", 35) & mNgay_Gio_Su_Kien & vbNewLine & _
                                       LSet("    + Ip máy tính:", 30) & mIp_May_Tinh & vbNewLine & _
                                       LSet("    + Nhân viên:", 30) & mNhan_Vien & vbNewLine & _
                                       LSet("    + Số hiệu E1:", 30) & mMa_E1 & vbNewLine & _
                                       LSet("    + BC Khai Thác:", 30) & mBC_Khai_Thac & vbNewLine & _
                                       LSet("    + Bộ phận:", 30) & mBo_Phan & vbNewLine & _
                                       LSet("    + Đường thư:", 30) & mDuong_Thu & vbNewLine & _
                                       LSet("    + Ngày đóng:", 30) & mNgay_Dong & vbNewLine & _
                                       LSet("    + Chuyến thư:", 30) & mChuyen_Thu & vbNewLine & _
                                       LSet("    + Túi số:", 30) & mTui_So & vbNewLine & _
                                       LSet(" ", 21) & RSet("Thông tin trước", 15) & RSet("Thông tin sau", 22) & vbNewLine & _
                                       "----------------------------------------------------------" & vbNewLine & _
                                       LSet("    + Phân loại:", 21) & RSet(mPhan_Loai_Truoc, 15) & RSet(mPhan_Loai_Sau, 22) & vbNewLine & _
                                       LSet("    + Khối lượng:", 21) & RSet(mKhoi_Luong_Truoc, 15) & RSet(mKhoi_Luong_Sau, 22) & vbNewLine
                    Case "E2"
                        'Dinh dang:  
                        '============== Thông tin E2 ========================
                        '           + Ngày sự kiện:
                        '           + Giờ sự kiện:
                        '           + Ip máy tính:
                        '           + Nhân viên:                         
                        '           + BC Khai Thác: (Ma + Ten)
                        'Thong tin truoc            Thong tin sau   
                        '----------------------------------------------------
                        '           + Đường thư:
                        '           + Ngày/Giờ đóng:
                        '           + Chuyến thư: (So_CT + Loai_CT)
                        '           + Túi số:
                        '           + Tổng số E1:
                        '           + Tổng khối lượng:
                        'Thong tin 
                        'Ngay Gio Su Kien
                        Dim mNgay_Gio_Su_Kien As String = myGridKeyDown.ActiveRow.Cells("Ngay_Sever").Text & "    " & myGridKeyDown.ActiveRow.Cells("Gio_Sever").Text
                        'Ip May Tinh
                        Dim mIp_May_Tinh As String = myGridKeyDown.ActiveRow.Cells("Ip_May_Tinh").Text
                        'Ten Nhan Vien
                        Dim mNhan_Vien As String = myGridKeyDown.ActiveRow.Cells("Ten_Nhan_Vien").Text
                        'Buu Cuc Khai Thac
                        Dim mBC_Khai_Thac As String = myGridKeyDown.ActiveRow.Cells("Ma_Bc_Khai_Thac").Text
                        'Bo Phan
                        Dim mBo_Phan As String
                        If myGridKeyDown.ActiveRow.Cells("Bo_Phan").Text = "Xac Nhan Den" Then
                            mBo_Phan = "Xác nhận đến"
                        Else
                            mBo_Phan = "Thiết lập đi"
                        End If
                        'Duong_Thu
                        Dim mDuong_Thu_Truoc As String = Cut_Txt_To_Field(myGridKeyDown.ActiveRow.Cells("Chi_Tiet_Truoc").Text, "_", 1)
                        Dim mDuong_Thu_Sau As String = Cut_Txt_To_Field(myGridKeyDown.ActiveRow.Cells("Chi_Tiet_Sau").Text, "_", 1)
                        'If myGridKeyDown.ActiveRow.Cells("Bo_Phan").Text = "Xac Nhan Den" Then   'Xac nhan den
                        '    'Duong_Thu_Truoc
                        '    mId_Duong_Thu = Cut_Txt_To_Field(myGridKeyDown.ActiveRow.Cells("Chi_Tiet_Truoc").Text, "_", 1)
                        '    mMa_Bc = myDuong_Thu_Den.Lay(mId_Duong_Thu).Ma_Bc
                        '    mDuong_Thu_Truoc = mMa_Bc.ToString & " - " & myDanh_Muc_Bc.Lay(mMa_Bc).Ten_Buu_Cuc
                        '    'Duong_Thu_Sau
                        '    mId_Duong_Thu = Cut_Txt_To_Field(myGridKeyDown.ActiveRow.Cells("Chi_Tiet_Sau").Text, "_", 1)
                        '    mMa_Bc = myDuong_Thu_Den.Lay(mId_Duong_Thu).Ma_Bc
                        '    mDuong_Thu_Sau = mMa_Bc.ToString & " - " & myDanh_Muc_Bc.Lay(mMa_Bc).Ten_Buu_Cuc
                        'Else  'Thiet lap di
                        '    'Duong_Thu_Truoc
                        '    mId_Duong_Thu = Cut_Txt_To_Field(myGridKeyDown.ActiveRow.Cells("Chi_Tiet_Truoc").Text, "_", 1)
                        '    mMa_Bc = myDuong_Thu_Di.Lay(mId_Duong_Thu).Ma_Bc
                        '    mDuong_Thu_Truoc = mMa_Bc.ToString & " - " & myDanh_Muc_Bc.Lay(mMa_Bc).Ten_Buu_Cuc
                        '    'Duong_Thu_Sau
                        '    mId_Duong_Thu = Cut_Txt_To_Field(myGridKeyDown.ActiveRow.Cells("Chi_Tiet_Sau").Text, "_", 1)
                        '    mMa_Bc = myDuong_Thu_Di.Lay(mId_Duong_Thu).Ma_Bc
                        '    mDuong_Thu_Sau = mMa_Bc.ToString & " - " & myDanh_Muc_Bc.Lay(mMa_Bc).Ten_Buu_Cuc
                        'End If
                        'Ngay Dong
                        '--------Truoc
                        Dim mNgay_Dong_Truoc As String = myHam_Dung_Chung.ConvertIntToVNDateType(Cut_Txt_To_Field(myGridKeyDown.ActiveRow.Cells("Chi_Tiet_Truoc").Text, "_", 2))
                        '--------Sau
                        Dim mNgay_Dong_Sau_Tmp As String = Cut_Txt_To_Field(myGridKeyDown.ActiveRow.Cells("Chi_Tiet_Sau").Text, "_", 2)
                        Dim mNgay_Dong_Sau As String
                        If mNgay_Dong_Sau_Tmp = "" Or Not IsNumeric(mNgay_Dong_Sau_Tmp) Then
                            mNgay_Dong_Sau = mNgay_Dong_Sau_Tmp
                        Else
                            mNgay_Dong_Sau = myHam_Dung_Chung.ConvertIntToVNDateType(mNgay_Dong_Sau_Tmp)
                        End If
                        'Chuyen Thu
                        '--------Truoc
                        Dim mChuyen_Thu_Truoc As String = Cut_Txt_To_Field(myGridKeyDown.ActiveRow.Cells("Chi_Tiet_Truoc").Text, "_", 4) & " - " & Cut_Txt_To_Field(myGridKeyDown.ActiveRow.Cells("Chi_Tiet_Truoc").Text, "_", 3)
                        '--------Sau
                        Dim mChuyen_Thu_Sau As String = Cut_Txt_To_Field(myGridKeyDown.ActiveRow.Cells("Chi_Tiet_Sau").Text, "_", 4) & " - " & Cut_Txt_To_Field(myGridKeyDown.ActiveRow.Cells("Chi_Tiet_Sau").Text, "_", 3)
                        'Tui So
                        '--------Truoc
                        Dim mTui_So_Truoc As String = Cut_Txt_To_Field(myGridKeyDown.ActiveRow.Cells("Chi_Tiet_Truoc").Text, "_", 5)
                        '--------Sau
                        Dim mTui_So_Sau As String = Cut_Txt_To_Field(myGridKeyDown.ActiveRow.Cells("Chi_Tiet_Sau").Text, "_", 5)
                        'Tong So
                        '--------Truoc
                        Dim mTong_So_Truoc As String = Cut_Txt_To_Field(myGridKeyDown.ActiveRow.Cells("Chi_Tiet_Truoc").Text, "_", 6)
                        '--------Sau
                        Dim mTong_So_Sau As String = Cut_Txt_To_Field(myGridKeyDown.ActiveRow.Cells("Chi_Tiet_Sau").Text, "_", 6)
                        'Khoi_Luong
                        '--------Truoc
                        Dim mKhoi_Luong_Truoc As String = Cut_Txt_To_Field(myGridKeyDown.ActiveRow.Cells("Chi_Tiet_Truoc").Text, "_", 7)
                        '--------Sau
                        Dim mKhoi_Luong_Sau As String = Cut_Txt_To_Field(myGridKeyDown.ActiveRow.Cells("Chi_Tiet_Sau").Text, "_", 7)
                        txtInfo.Text = vbNewLine & _
                                       "====================== Thông tin E2 ======================" & vbNewLine & _
                                       LSet("+ Ngày/Giờ sự kiện:", 35) & mNgay_Gio_Su_Kien & vbNewLine & _
                                       LSet("+ Ip máy tính:", 35) & mIp_May_Tinh & vbNewLine & _
                                       LSet("+ Nhân viên:", 35) & mNhan_Vien & vbNewLine & _
                                       LSet("+ BC Khai Thác:", 35) & mBC_Khai_Thac & vbNewLine & _
                                       LSet("+ Bộ phận:", 35) & mBo_Phan & vbNewLine & _
                                       LSet(" ", 21) & RSet("Thông tin trước", 15) & RSet("Thông tin sau", 22) & vbNewLine & _
                                       "----------------------------------------------------------" & vbNewLine & _
                                       LSet("+ Đường thư:", 21) & RSet(mDuong_Thu_Truoc, 15) & RSet(mDuong_Thu_Sau, 22) & vbNewLine & _
                                       LSet("+ Ngày đóng:", 21) & RSet(mNgay_Dong_Truoc, 15) & RSet(mNgay_Dong_Sau, 22) & vbNewLine & _
                                       LSet("+ Chuyến thư:", 21) & RSet(mChuyen_Thu_Truoc, 15) & RSet(mChuyen_Thu_Sau, 22) & vbNewLine & _
                                       LSet("+ Túi số:", 21) & RSet(mTui_So_Truoc, 15) & RSet(mTui_So_Sau, 22) & vbNewLine & _
                                       LSet("+ Tổng số E1:", 21) & RSet(mTong_So_Truoc, 15) & RSet(mTong_So_Sau, 22) & vbNewLine & _
                                       LSet("+ Khối lượng:", 21) & RSet(mKhoi_Luong_Truoc, 15) & RSet(mKhoi_Luong_Sau, 22)

                End Select
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "btnClose_Click"
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        grbChi_Tiet_Event.Visible = False
    End Sub
#End Region

#Region "btnPrint_Click"
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        MessageBox.Show("Chức năng này chưa sử dụng được, mời bạn quay lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
#End Region

#End Region

#End Region

End Class

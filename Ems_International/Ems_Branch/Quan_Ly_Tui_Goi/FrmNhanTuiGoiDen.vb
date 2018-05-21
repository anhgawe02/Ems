Imports ADODB
Imports System.IO
Imports System.Windows.Forms
Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports CrystalDecisions.Shared
Imports System
Imports CrystalDecisions.CrystalReports.Engine
Imports Ems_International_Logic.EMS
Public Class FrmNhanTuiGoiDen
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnKet_Thuc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtMaVachTui As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtMaVachBC37 As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents btnBat_Dau As Infragistics.Win.Misc.UltraButton
    Friend WithEvents dgNhanTuiDen As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnLuu_Tam As Infragistics.Win.Misc.UltraButton
    Friend WithEvents lbThongTin As System.Windows.Forms.Label
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmNhanTuiGoiDen))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("E2Di", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_TT_TUI_THU")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_TUI_THU", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_DUONG_THU")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_CHUYEN_THU")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MA_BC_GUI")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MA_BC_NHAN")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CHUYEN_THU")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TUI_SO")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KHOI_LUONG")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KHOI_LUONG_QD")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TONG_SO_BP")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NGAY_DONG")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GIO_DONG")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LOAI_TUI_THU")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NGAY_XN_DEN")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GIO_XN_DEN")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("E2Di", -1)
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_TT_TUI_THU")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_TUI_THU")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_DUONG_THU")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_CHUYEN_THU")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MA_BC_GUI")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MA_BC_NHAN")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CHUYEN_THU")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TUI_SO")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KHOI_LUONG")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KHOI_LUONG_QD")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TONG_SO_BP")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NGAY_DONG")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GIO_DONG")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LOAI_TUI_THU")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NGAY_XN_DEN")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GIO_XN_DEN")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.BtnExit = New Infragistics.Win.Misc.UltraButton
        Me.btnKet_Thuc = New Infragistics.Win.Misc.UltraButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnLuu_Tam = New Infragistics.Win.Misc.UltraButton
        Me.txtMaVachTui = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.txtMaVachBC37 = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.btnBat_Dau = New Infragistics.Win.Misc.UltraButton
        Me.dgNhanTuiDen = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbThongTin = New System.Windows.Forms.Label
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        CType(Me.dgNhanTuiDen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnExit
        '
        Appearance1.FontData.BoldAsString = "True"
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.BtnExit.Appearance = Appearance1
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(640, 111)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(120, 32)
        Me.BtnExit.TabIndex = 18
        Me.BtnExit.Text = "Thoát"
        '
        'btnKet_Thuc
        '
        Appearance2.FontData.BoldAsString = "True"
        Me.btnKet_Thuc.Appearance = Appearance2
        Me.btnKet_Thuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKet_Thuc.Location = New System.Drawing.Point(640, 76)
        Me.btnKet_Thuc.Name = "btnKet_Thuc"
        Me.btnKet_Thuc.Size = New System.Drawing.Size(120, 32)
        Me.btnKet_Thuc.TabIndex = 17
        Me.btnKet_Thuc.Text = "Kết thúc nhận túi"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(13, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 24)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Mã vạch cổ túi "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(13, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Mã vạch BC37  "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLuu_Tam
        '
        Appearance3.FontData.BoldAsString = "True"
        Me.btnLuu_Tam.Appearance = Appearance3
        Me.btnLuu_Tam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLuu_Tam.Location = New System.Drawing.Point(640, 42)
        Me.btnLuu_Tam.Name = "btnLuu_Tam"
        Me.btnLuu_Tam.Size = New System.Drawing.Size(120, 32)
        Me.btnLuu_Tam.TabIndex = 2
        Me.btnLuu_Tam.Text = "Lưu tạm thời"
        '
        'txtMaVachTui
        '
        Appearance4.BackColor = System.Drawing.Color.Red
        Appearance4.FontData.BoldAsString = "True"
        Appearance4.FontData.Name = "Arial"
        Appearance4.FontData.SizeInPoints = 14.0!
        Appearance4.ForeColor = System.Drawing.Color.White
        Me.txtMaVachTui.Appearance = Appearance4
        Me.txtMaVachTui.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtMaVachTui.InputMask = "999999999999AAA99999999999999"
        Me.txtMaVachTui.Location = New System.Drawing.Point(120, 112)
        Me.txtMaVachTui.Name = "txtMaVachTui"
        Me.txtMaVachTui.Size = New System.Drawing.Size(464, 29)
        Me.txtMaVachTui.TabIndex = 16
        '
        'txtMaVachBC37
        '
        Appearance5.BackColor = System.Drawing.Color.Red
        Appearance5.FontData.BoldAsString = "True"
        Appearance5.FontData.Name = "Arial"
        Appearance5.FontData.SizeInPoints = 14.0!
        Appearance5.ForeColor = System.Drawing.Color.White
        Me.txtMaVachBC37.Appearance = Appearance5
        Me.txtMaVachBC37.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.String
        Me.txtMaVachBC37.InputMask = "9999999999999999999999999999"
        Me.txtMaVachBC37.Location = New System.Drawing.Point(120, 8)
        Me.txtMaVachBC37.Name = "txtMaVachBC37"
        Me.txtMaVachBC37.Size = New System.Drawing.Size(464, 29)
        Me.txtMaVachBC37.TabIndex = 1
        '
        'btnBat_Dau
        '
        Appearance6.FontData.BoldAsString = "True"
        Me.btnBat_Dau.Appearance = Appearance6
        Me.btnBat_Dau.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBat_Dau.Location = New System.Drawing.Point(640, 7)
        Me.btnBat_Dau.Name = "btnBat_Dau"
        Me.btnBat_Dau.Size = New System.Drawing.Size(120, 32)
        Me.btnBat_Dau.TabIndex = 75
        Me.btnBat_Dau.Text = "&Bắt đầu nhận túi"
        '
        'dgNhanTuiDen
        '
        Me.dgNhanTuiDen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgNhanTuiDen.DisplayLayout.AddNewBox.Prompt = " "
        Appearance7.BackColor = System.Drawing.Color.White
        Appearance7.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgNhanTuiDen.DisplayLayout.Appearance = Appearance7
        UltraGridBand1.CardSettings.ShowCaption = False
        UltraGridColumn1.Header.Caption = "Id TT Túi Thư"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(81, 0)
        UltraGridColumn2.Header.Caption = "Id Túi Thư"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(238, 0)
        UltraGridColumn3.Header.Caption = "Id Đường Thư"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.Header.Caption = "Id Chuyến Thư"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.Header.Caption = "Mã BC Gửi"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn6.Header.Caption = "Mã BC Nhận"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn7.Header.Caption = "Chuyến Thư"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn8.Header.Caption = "Túi Số"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn9.Header.Caption = "Khối Lượng"
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn10.Header.Caption = "Khối Lượng QĐ"
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn11.Header.Caption = "Tổng Số BP"
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn12.Header.Caption = "Ngày Đóng"
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn13.Header.Caption = "Giờ Đóng"
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn14.Header.Caption = "Loại Túi Thư"
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16})
        UltraGridBand1.Header.Caption = "Danh sách E1 trong bản kê E2"
        Appearance8.ImageVAlign = Infragistics.Win.VAlign.Bottom
        UltraGridBand1.Override.RowSelectorAppearance = Appearance8
        UltraGridBand1.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand1.UseRowLayout = True
        Me.dgNhanTuiDen.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.dgNhanTuiDen.DisplayLayout.InterBandSpacing = 10
        Me.dgNhanTuiDen.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Me.dgNhanTuiDen.DisplayLayout.Override.CardAreaAppearance = Appearance9
        Me.dgNhanTuiDen.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance10.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance10.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance10.ForeColor = System.Drawing.Color.Black
        Appearance10.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance10.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgNhanTuiDen.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.dgNhanTuiDen.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Appearance11.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgNhanTuiDen.DisplayLayout.Override.RowAppearance = Appearance11
        Appearance12.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance12.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.dgNhanTuiDen.DisplayLayout.Override.RowSelectorAppearance = Appearance12
        Me.dgNhanTuiDen.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgNhanTuiDen.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance13.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance13.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance13.ForeColor = System.Drawing.Color.Black
        Me.dgNhanTuiDen.DisplayLayout.Override.SelectedRowAppearance = Appearance13
        Me.dgNhanTuiDen.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgNhanTuiDen.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgNhanTuiDen.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.ExtendedAutoDrag
        Me.dgNhanTuiDen.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgNhanTuiDen.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgNhanTuiDen.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgNhanTuiDen.Location = New System.Drawing.Point(432, 168)
        Me.dgNhanTuiDen.Name = "dgNhanTuiDen"
        Me.dgNhanTuiDen.Size = New System.Drawing.Size(336, 352)
        Me.dgNhanTuiDen.TabIndex = 19
        Me.dgNhanTuiDen.Text = "Danh sách nhận túi gói đến"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(400, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 18)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Bưu cục nhận :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(228, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Bưu cục gửi :"
        '
        'lbThongTin
        '
        Me.lbThongTin.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.lbThongTin.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbThongTin.ForeColor = System.Drawing.Color.White
        Me.lbThongTin.Location = New System.Drawing.Point(120, 39)
        Me.lbThongTin.Name = "lbThongTin"
        Me.lbThongTin.Size = New System.Drawing.Size(464, 72)
        Me.lbThongTin.TabIndex = 76
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UltraGrid1.DisplayLayout.AddNewBox.Prompt = " "
        Appearance14.BackColor = System.Drawing.Color.White
        Appearance14.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.UltraGrid1.DisplayLayout.Appearance = Appearance14
        UltraGridBand2.CardSettings.ShowCaption = False
        UltraGridColumn17.Header.Caption = "Id TT Túi Thư"
        UltraGridColumn17.Header.VisiblePosition = 0
        UltraGridColumn17.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(81, 0)
        UltraGridColumn18.Header.Caption = "Id Túi Thư"
        UltraGridColumn18.Header.VisiblePosition = 1
        UltraGridColumn18.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(238, 0)
        UltraGridColumn19.Header.Caption = "Id Đường Thư"
        UltraGridColumn19.Header.VisiblePosition = 2
        UltraGridColumn20.Header.Caption = "Id Chuyến Thư"
        UltraGridColumn20.Header.VisiblePosition = 3
        UltraGridColumn21.Header.Caption = "Mã BC Gửi"
        UltraGridColumn21.Header.VisiblePosition = 4
        UltraGridColumn22.Header.Caption = "Mã BC Nhận"
        UltraGridColumn22.Header.VisiblePosition = 5
        UltraGridColumn23.Header.Caption = "Chuyến Thư"
        UltraGridColumn23.Header.VisiblePosition = 6
        UltraGridColumn24.Header.Caption = "Túi Số"
        UltraGridColumn24.Header.VisiblePosition = 7
        UltraGridColumn25.Header.Caption = "Khối Lượng"
        UltraGridColumn25.Header.VisiblePosition = 8
        UltraGridColumn26.Header.Caption = "Khối Lượng QĐ"
        UltraGridColumn26.Header.VisiblePosition = 9
        UltraGridColumn27.Header.Caption = "Tổng Số BP"
        UltraGridColumn27.Header.VisiblePosition = 10
        UltraGridColumn28.Header.Caption = "Ngày Đóng"
        UltraGridColumn28.Header.VisiblePosition = 11
        UltraGridColumn29.Header.Caption = "Giờ Đóng"
        UltraGridColumn29.Header.VisiblePosition = 12
        UltraGridColumn30.Header.Caption = "Loại Túi Thư"
        UltraGridColumn30.Header.VisiblePosition = 13
        UltraGridColumn31.Header.VisiblePosition = 14
        UltraGridColumn32.Header.VisiblePosition = 15
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32})
        UltraGridBand2.Header.Caption = "Danh sách E1 trong bản kê E2"
        Appearance15.ImageVAlign = Infragistics.Win.VAlign.Bottom
        UltraGridBand2.Override.RowSelectorAppearance = Appearance15
        UltraGridBand2.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand2.UseRowLayout = True
        Me.UltraGrid1.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.UltraGrid1.DisplayLayout.InterBandSpacing = 10
        Me.UltraGrid1.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Me.UltraGrid1.DisplayLayout.Override.CardAreaAppearance = Appearance16
        Me.UltraGrid1.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance17.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance17.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance17.ForeColor = System.Drawing.Color.Black
        Appearance17.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance17.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.UltraGrid1.DisplayLayout.Override.HeaderAppearance = Appearance17
        Me.UltraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Appearance18.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.UltraGrid1.DisplayLayout.Override.RowAppearance = Appearance18
        Appearance19.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance19.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.UltraGrid1.DisplayLayout.Override.RowSelectorAppearance = Appearance19
        Me.UltraGrid1.DisplayLayout.Override.RowSelectorWidth = 12
        Me.UltraGrid1.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance20.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance20.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance20.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance20.ForeColor = System.Drawing.Color.Black
        Me.UltraGrid1.DisplayLayout.Override.SelectedRowAppearance = Appearance20
        Me.UltraGrid1.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.UltraGrid1.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.UltraGrid1.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.ExtendedAutoDrag
        Me.UltraGrid1.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.UltraGrid1.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.UltraGrid1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGrid1.Location = New System.Drawing.Point(8, 168)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(408, 352)
        Me.UltraGrid1.TabIndex = 77
        Me.UltraGrid1.Text = "Danh sách nhận túi gói đến"
        '
        'FrmNhanTuiGoiDen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(776, 526)
        Me.Controls.Add(Me.UltraGrid1)
        Me.Controls.Add(Me.lbThongTin)
        Me.Controls.Add(Me.dgNhanTuiDen)
        Me.Controls.Add(Me.btnBat_Dau)
        Me.Controls.Add(Me.txtMaVachBC37)
        Me.Controls.Add(Me.txtMaVachTui)
        Me.Controls.Add(Me.btnLuu_Tam)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.btnKet_Thuc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Name = "FrmNhanTuiGoiDen"
        Me.Text = "FrmNhanTuiGoiDen"
        CType(Me.dgNhanTuiDen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " ---------Khai bao bien trong form--------------- "
    Dim myORC_Receptacle As New ORA_Receptacle(GOracleConnectionString_E_Receptacle)
    Dim myDot_Giao_Nhan_Chi_Tiet As New ORA_TT_Giao_Nhan_Chi_Tiet
    Dim myDanhSachTuiThu As DataTable
    Dim myNgayNhan As Integer
    Dim myGioNhan As Integer
    Dim myHam_Dung_Chung As New Ham_Dung_Chung
    Dim myColumn As Infragistics.Win.UltraWinGrid.UltraGridColumn = Nothing
    Dim myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Dim myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Dim myKeys As New ModifyRegistry
#End Region

#Region " ------------------Form Load--------------"
    Private Sub FrmNhanTuiGoiDen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Chức năng nhận túi gói nội địa"
        Me.CenterToScreen()
        Me.ControlBox = True
        Me.MaximizeBox = False
        Init_Form()
    End Sub
#End Region

#Region "Init_Form"
    Private Sub Init_Form()
        myDot_Giao_Nhan_Chi_Tiet = New ORA_TT_Giao_Nhan_Chi_Tiet
        myDanhSachTuiThu = New DataTable
        txtMaVachTui.InputMask = "999999999999AAA99999999999999"
        txtMaVachTui.Text = ""
        txtMaVachTui.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        txtMaVachBC37.InputMask = "9999999999999999999999999999"
        txtMaVachBC37.Text = ""
        txtMaVachBC37.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask

        Enable_Control(True)
        txtMaVachBC37.Focus()

    End Sub
#End Region

    Private Sub txtMaVachBC37_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMaVachBC37.KeyDown
        Try
            If e.KeyValue = Keys.Enter Or e.KeyValue = Keys.Tab Then
                Dim mStatus As Integer
                mStatus = Kiem_Tra_Thong_Tin_Truoc_Khi_Tao_Dot_Nhan_Den()

                Select Case mStatus
                    Case 1 ' dot giao nhan chua hoan tat, lay dc thong tin tui thu 
                        If Lay_Danh_Sach_Tui_Tren_Oracle_Vao_Bien(txtMaVachBC37.Text) = False Then
                            MessageBox.Show("Lỗi lấy thông tin túi gói thuộc đợt giao nhận !!! Kiểm tra lại kết nối với máy chủ Oracle", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        End If
                    Case 2   'da hoan tat khong lay dc thong tin 
                        MessageBox.Show("Đợt giao nhận này đã hoàn tất!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    Case Else   'Lỗi kết nối
                        'MessageBox.Show("Lỗi không tạo được đợt giao túi gói!!! Kiểm tra kết nối với máy chủ Oracle.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                End Select
                'Sua lai cho nay chi load nhung tui da co trang thai xac nhan den
                DataGrid_Thong_Tin_Tui_Thu(myDot_Giao_Nhan_Chi_Tiet.ID_GIAO_NHAN)
                Enable_Control(False)
                btnBat_Dau.Focus()
            End If
        Catch ex As Exception
            Console.Write(ex.ToString)
        End Try
    End Sub

#Region " ------------------btnBat_Dau_Click----------------------------"
    Private Sub btnBat_Dau_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBat_Dau.Click
        Dim mTT_Tui_Thu_Chi_Tiet As New ORA_TT_Tui_Thu_Chi_Tiet
        txtMaVachTui.SelectAll()
        txtMaVachTui.Focus()
    End Sub
#End Region

#Region "-------------txtMaVachTui_KeyDown-----------------"
    Private Sub txtMaVachTui_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMaVachTui.KeyDown
        If e.KeyValue = Keys.Enter Or e.KeyValue = Keys.Tab Then
            Dim mThong_Tin_Tui_Nhan_Ve As New ORA_TT_Tui_Thu_Chi_Tiet
            Dim mTrang_Thai_TSL As Integer = 0
            If Kiem_Tra_Ma_Vach_Tui_Hop_Le(txtMaVachTui.Text, mThong_Tin_Tui_Nhan_Ve) Then
                '================================================
                ' Kiem tra TSL
                Dim myE2DenTam As New E2_Den_Tam(GConnectionString)
                Dim myE1DenTam As New E1_Den_Tam(GConnectionString)
                Dim dtE2DenTam As DataTable
                Dim dtE1DenTam As DataTable
                Dim mId_E2 As String = ""
                Dim mTong_So As Integer = 0

                dtE2DenTam = myE2DenTam.Lay_Boi_Chuyen_Thu_Den_Tam(mThong_Tin_Tui_Nhan_Ve.ID_CHUYEN_THU).Tables(0)
                mTrang_Thai_TSL = 0
                For Each mRow As DataRow In dtE2DenTam.Rows
                    If mRow.Item("Tui_So") = mThong_Tin_Tui_Nhan_Ve.TUI_SO Then
                        mTrang_Thai_TSL = 1
                        mId_E2 = mRow.Item("Id_E2")
                        mTong_So = mRow.Item("Tong_So_BP")
                        Exit For
                    End If
                Next
                If mTrang_Thai_TSL = 1 And mId_E2 <> "" Then
                    dtE1DenTam = myE1DenTam.Lay_Boi_E2_Den_Tam(mId_E2).Tables(0)
                    If dtE1DenTam.Rows.Count >= mTong_So Then
                        mTrang_Thai_TSL = 2
                    End If
                End If
                '================================================
                ' cap nhat trang thai TSL 
                If Not myORC_Receptacle.er_tt_tsl_tui_thu(mThong_Tin_Tui_Nhan_Ve.ID_TT_TUI_THU, mTrang_Thai_TSL) Then
                    MessageBox.Show("Lỗi cập nhật trạng thái truyền số liệu!!! Kiểm tra kết nối với máy chủ Oracle", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtMaVachTui.Focus()
                    txtMaVachTui.SelectionStart = 0
                    txtMaVachTui.SelectionLength = txtMaVachTui.Text.Length
                    Exit Sub
                Else 'cap nhat thanh cong
                    myNgayNhan = myHam_Dung_Chung.ConvertDateToInt(Now.Date)
                    myGioNhan = Convert.ToInt32(Now.Hour.ToString("00") & Now.Minute.ToString("00"))
                    'cap nhat thogn tin tui
                    Dim mStatus As Integer
                    mStatus = myORC_Receptacle.er_tui_thu_cap_nhat_tt_nhan(mThong_Tin_Tui_Nhan_Ve.ID_GIAO_NHAN, mThong_Tin_Tui_Nhan_Ve.ID_TT_TUI_THU, mThong_Tin_Tui_Nhan_Ve.ID_TUI_THU, myNgayNhan, myGioNhan)
                    Select Case mStatus
                        Case 0
                            ' khong ket noi duoc
                            MessageBox.Show("Không kết nối được với máy chủ Oracle", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            txtMaVachTui.Focus()
                            txtMaVachTui.SelectionStart = 0
                            txtMaVachTui.SelectionLength = txtMaVachTui.Text.Length
                            Exit Sub
                        Case 2
                            'da hoan tat nhan ko duoc cap nhat
                            MessageBox.Show("Đợt nhận túi này đã hoàn tất, không được cập nhật ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            txtMaVachTui.Focus()
                            txtMaVachTui.SelectionStart = 0
                            txtMaVachTui.SelectionLength = txtMaVachTui.Text.Length
                            Exit Sub
                        Case 1    ' 1 la ok 
                            'Ghi vao luoi
                            AddNewRow(mThong_Tin_Tui_Nhan_Ve)
                            txtMaVachTui.Text = ""
                            txtMaVachTui.Focus()
                            txtMaVachTui.SelectionStart = 0
                            txtMaVachTui.SelectionLength = txtMaVachTui.Text.Length
                        Case Else
                            MessageBox.Show("Không kết nối được với máy chủ Oracle", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                    End Select
                End If
            Else
                txtMaVachTui.Focus()
                txtMaVachTui.SelectionStart = 0
                txtMaVachTui.SelectionLength = txtMaVachTui.Text.Length
            End If
        End If
    End Sub
#End Region

#Region "------------dgNhanTuiDen_InitializeLayout---------"
    Private Sub dgNhanTuiDen_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgNhanTuiDen.InitializeLayout
        myGridKeyDown = sender
        myGridKeyDown.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        myGridKeyDown.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
        myGridKeyDown.DisplayLayout.Override.AllowAddNew = AllowAddNew.Yes
        myGridKeyDown.DisplayLayout.Bands(0).Columns("ID_TT_TUI_THU").Hidden = True
        myGridKeyDown.DisplayLayout.Bands(0).Columns("ID_DUONG_THU").Hidden = True
        myGridKeyDown.DisplayLayout.Bands(0).Columns("ID_CHUYEN_THU").Hidden = True
        myGridKeyDown.DisplayLayout.Bands(0).Columns("ID_GIAO_NHAN").Hidden = True
        myGridKeyDown.DisplayLayout.Bands(0).Columns("NGAY_XN_DEN").Hidden = True
        myGridKeyDown.DisplayLayout.Bands(0).Columns("GIO_XN_DEN").Hidden = True
        myGridKeyDown.DisplayLayout.Bands(0).Columns("LOAI_TUI_THU").Hidden = True
    End Sub
#End Region

    Private Sub btnLuu_Tam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLuu_Tam.Click
        Ket_Thuc_Dot_Giao_Nhan(False)
    End Sub

#Region "-----------KeyEnter---------------------"
    Private Sub CbBCGui_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyValue
            Case Keys.Enter 'Key Enter
                Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
            Case Else
        End Select
    End Sub
#End Region

#Region "------------ KeyDown -------------------"
    Private Sub dgNhanTuiDen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgNhanTuiDen.KeyDown
        If e.KeyValue = Keys.F8 Then
            If dgNhanTuiDen.ActiveRow Is DBNull.Value Or dgNhanTuiDen.ActiveRow Is DBNull.Value Then
                Exit Sub
            End If
            If dgNhanTuiDen.ActiveRow.Cells("ID_TUI_THU").Text <> "" Then
                If MessageBox.Show("Bạn có chắc chắn muốn xóa dòng dữ liệu này không?", "Cảnh báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    Dim mStatus As Integer = 0
                    Dim mdatatable As DataTable = myORC_Receptacle.er_lay_tt_giao_nhan(myDot_Giao_Nhan_Chi_Tiet.ID_GIAO_NHAN, myDot_Giao_Nhan_Chi_Tiet.MA_BC_NHAN, ORA_Receptacle_Ham_Dung_Chung.GLa_Nhan_Tui, mStatus).Tables(0)
                    If mStatus = 2 Then
                        MessageBox.Show("Đợt giao nhận này đã hòa tất nhận, bạn không được quyền xóa túi gói trong đợt.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    If mStatus = 0 Then
                        MessageBox.Show("Có lỗi xảy ra khi kết nối với máy chủ Oracle. Kiểm tra lại kết nối với máy chủ Oracle", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    'myORC_Receptacle.er_tt_tui_thu_xoa(Convert.ToInt32(dgNhanTuiDen.ActiveRow.Cells("ID_TT_TUI_THU").Text), dgNhanTuiDen.ActiveRow.Cells("ID_TUI_THU").Text, myDot_Giao_Nhan_Chi_Tiet.ID_GIAO_NHAN)
                    'cap nhat lai thong tin nhan tui

                    mStatus = myORC_Receptacle.er_tui_thu_cap_nhat_tt_nhan(myDot_Giao_Nhan_Chi_Tiet.ID_GIAO_NHAN, dgNhanTuiDen.ActiveRow.Cells("ID_TT_TUI_THU").Text, dgNhanTuiDen.ActiveRow.Cells("ID_TUI_THU").Text, 0, 0)
                    Select Case mStatus
                        Case 0
                            ' khong ket noi duoc, 'da hoan tat nhan ko duoc cap nhat
                            MessageBox.Show("Đợt giao nhận đã hoàn tất , không thể xóa túi gói", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        Case 2
                            ' khong ket noi duoc, 'da hoan tat nhan ko duoc cap nhat
                            MessageBox.Show("Đợt nhận túi này đã hoàn tất, không được cập nhật ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        Case 1  ' 1 la ok 
                            MessageBox.Show("Đã xóa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Case Else
                            MessageBox.Show("Không kết nối được với máy chủ Oracle", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                    End Select
                    dgNhanTuiDen.ActiveRow.Delete(False)
                    'MessageBox.Show("Đã xóa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Refresh_Tong_So_Dong()
                End If
            End If
        End If
    End Sub
#End Region

#Region "-----------------------AddNewRow-----------------------"
    Private Sub AddNewRow(ByVal mThong_Tin_Tui_Chi_Tiet As ORA_TT_Tui_Thu_Chi_Tiet)
        Try
            myGridKeyDown = dgNhanTuiDen
            myGridKeyDown.Rows.Band.AddNew()
            Dim mLastRow As Integer = myGridKeyDown.Rows.Count - 1
            myGridKeyDown.Rows(mLastRow).Cells("ID_TT_TUI_THU").Value = mThong_Tin_Tui_Chi_Tiet.ID_TT_TUI_THU
            myGridKeyDown.Rows(mLastRow).Cells("ID_TUI_THU").Value = mThong_Tin_Tui_Chi_Tiet.ID_TUI_THU
            myGridKeyDown.Rows(mLastRow).Cells("ID_DUONG_THU").Value = mThong_Tin_Tui_Chi_Tiet.ID_DUONG_THU
            myGridKeyDown.Rows(mLastRow).Cells("ID_CHUYEN_THU").Value = mThong_Tin_Tui_Chi_Tiet.ID_CHUYEN_THU
            myGridKeyDown.Rows(mLastRow).Cells("ID_GIAO_NHAN").Value = mThong_Tin_Tui_Chi_Tiet.ID_GIAO_NHAN
            myGridKeyDown.Rows(mLastRow).Cells("MA_BC_GUI").Value = mThong_Tin_Tui_Chi_Tiet.MA_BC_GUI
            myGridKeyDown.Rows(mLastRow).Cells("MA_BC_NHAN").Value = mThong_Tin_Tui_Chi_Tiet.MA_BC_NHAN
            myGridKeyDown.Rows(mLastRow).Cells("CHUYEN_THU").Value = mThong_Tin_Tui_Chi_Tiet.CHUYEN_THU
            myGridKeyDown.Rows(mLastRow).Cells("TUI_SO").Value = mThong_Tin_Tui_Chi_Tiet.TUI_SO
            myGridKeyDown.Rows(mLastRow).Cells("KHOI_LUONG").Value = mThong_Tin_Tui_Chi_Tiet.KHOI_LUONG
            myGridKeyDown.Rows(mLastRow).Cells("KHOI_LUONG_QD").Value = mThong_Tin_Tui_Chi_Tiet.KHOI_LUONG_QD
            myGridKeyDown.Rows(mLastRow).Cells("TONG_SO_BP").Value = mThong_Tin_Tui_Chi_Tiet.TONG_SO_BP
            myGridKeyDown.Rows(mLastRow).Cells("NGAY_DONG").Value = mThong_Tin_Tui_Chi_Tiet.NGAY_DONG
            myGridKeyDown.Rows(mLastRow).Cells("GIO_DONG").Value = mThong_Tin_Tui_Chi_Tiet.GIO_DONG
            myGridKeyDown.Rows(mLastRow).Cells("LOAI_TUI_THU").Value = mThong_Tin_Tui_Chi_Tiet.LOAI_TUI_THU
            myGridKeyDown.Rows(mLastRow).Cells("NGAY_XN_DEN").Value = myNgayNhan
            myGridKeyDown.Rows(mLastRow).Cells("GIO_XN_DEN").Value = myGioNhan
            Refresh_Tong_So_Dong()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "-------------Refresh_Tong_So_Dong------------------"
    Private Sub Refresh_Tong_So_Dong()
        dgNhanTuiDen.Text = "Danh sách nhận túi gói đến (Tổng số: " & dgNhanTuiDen.Rows.Count.ToString & " túi)"
    End Sub
#End Region

#Region "-------------------Kiem_Tra_Ma_Vach_Tui_Hop_Le-------------------------"
    Private Function Kiem_Tra_Ma_Vach_Tui_Hop_Le(ByVal mMa_Vach_Tui As String, ByRef mThong_Tin_Tui_Thu As ORA_TT_Tui_Thu_Chi_Tiet) As Boolean
        Dim mTimThay As Boolean = False
        'Kiem tra xem co thong tin tren may chu Oracle khong
        For Each mRow As DataRow In myDanhSachTuiThu.Rows
            If mRow.Item("Id_Tui_Thu") = mMa_Vach_Tui Then
                mTimThay = True
                mThong_Tin_Tui_Thu.ID_TT_TUI_THU = mRow.Item("ID_TT_TUI_THU")
                mThong_Tin_Tui_Thu.ID_TUI_THU = mRow.Item("ID_TUI_THU")
                mThong_Tin_Tui_Thu.ID_DUONG_THU = mRow.Item("ID_DUONG_THU")
                mThong_Tin_Tui_Thu.ID_CHUYEN_THU = mRow.Item("ID_CHUYEN_THU")
                mThong_Tin_Tui_Thu.ID_GIAO_NHAN = mRow.Item("ID_GIAO_NHAN")
                mThong_Tin_Tui_Thu.MA_BC_GUI = mRow.Item("MA_BC_GUI")
                mThong_Tin_Tui_Thu.MA_BC_NHAN = mRow.Item("MA_BC_NHAN")
                mThong_Tin_Tui_Thu.CHUYEN_THU = mRow.Item("CHUYEN_THU")
                mThong_Tin_Tui_Thu.TUI_SO = mRow.Item("TUI_SO")
                mThong_Tin_Tui_Thu.KHOI_LUONG = mRow.Item("KHOI_LUONG")
                mThong_Tin_Tui_Thu.KHOI_LUONG_QD = mRow.Item("KHOI_LUONG_QD")
                mThong_Tin_Tui_Thu.TONG_SO_BP = mRow.Item("TONG_SO_BP")
                'mThong_Tin_Tui_Thu.CUOC_EMS = mRow.Item("CUOC_EMS")
                'mThong_Tin_Tui_Thu.CUOC_DV = mRow.Item("CUOC_DV")
                mThong_Tin_Tui_Thu.NGAY_DONG = mRow.Item("NGAY_DONG")
                mThong_Tin_Tui_Thu.GIO_DONG = mRow.Item("GIO_DONG")
                mThong_Tin_Tui_Thu.LOAI_TUI_THU = mRow.Item("LOAI_TUI_THU")
                'mThong_Tin_Tui_Thu.LOAI_XAC_NHAN = mRow.Item("LOAI_XAC_NHAN")
                'Return True
                Exit For
                'Exit Function
            End If
        Next
        If mTimThay = False Then
            MessageBox.Show("Không có thông tin túi gói này trong đợt giao nhận trên máy chủ Oracle", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            mThong_Tin_Tui_Thu = New ORA_TT_Tui_Thu_Chi_Tiet
            Return False
            Exit Function
        End If
        'Kiem tra trung du lieu trong ban ke
        Dim mSo_Dong As Integer
        Dim mId_E2 As String
        Try
            For Each mRow As UltraGridRow In dgNhanTuiDen.Rows
                If mRow.Cells("Id_Tui_Thu").Text = mMa_Vach_Tui Then
                    MessageBox.Show("Túi này đã có trong bản kê, bạn không đươc phép nhập thêm.", "Lỗi thêm túi gói vào đợt giao nhận", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    mThong_Tin_Tui_Thu = New ORA_TT_Tui_Thu_Chi_Tiet
                    Return False
                    Exit For
                    Exit Function
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        Return True
    End Function
#End Region

#Region "------------Enable_Control------------------"
    Private Sub Enable_Control(ByVal mBolCotrol As Boolean)
        txtMaVachBC37.Enabled = mBolCotrol
        BtnExit.Enabled = mBolCotrol

        btnBat_Dau.Enabled = Not mBolCotrol
        btnLuu_Tam.Enabled = Not mBolCotrol
        btnKet_Thuc.Enabled = Not mBolCotrol
        dgNhanTuiDen.Enabled = Not mBolCotrol
        txtMaVachTui.Enabled = Not mBolCotrol
    End Sub
#End Region

#Region "-------------Lay_Danh_Sach_Tui_Tren_Oracle_Vao_Bien-----------------"
    Private Function Lay_Danh_Sach_Tui_Tren_Oracle_Vao_Bien(ByVal mId_Giao_Nhan As String) As Boolean
        Dim mStatus As Double = 0
        Try
            myDanhSachTuiThu = myORC_Receptacle.er_lay_tui_thu_giao_nhan(mId_Giao_Nhan, GBuu_Cuc_Khai_Thac, ORA_Receptacle_Ham_Dung_Chung.GLa_Nhan_Tui, mStatus).Tables(0)
        Catch ex As Exception
            Return False
        End Try
        Select Case mStatus
            Case 0
                Return False
            Case 1
                Return True
        End Select
    End Function
#End Region

#Region "------------------DataGrid_Thong_Tin_Tui_Thu--------------"
    Private Function DataGrid_Thong_Tin_Tui_Thu(ByVal mId_Giao_Nhan As String) As Boolean
        Dim mStatus As Double = 0
        Dim mDatatable As DataTable = myORC_Receptacle.er_lay_tui_thu_da_nhan(mId_Giao_Nhan, GBuu_Cuc_Khai_Thac, mStatus).Tables(0)
        If mStatus = 0 Then
            MessageBox.Show("Lỗi không load được dữ liệu trên lưới!!! Kiểm tra kết nối với máy chủ ORACLE", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
            Exit Function
        End If
        dgNhanTuiDen.DataSource = mDatatable
        dgNhanTuiDen.DataBind()
        Refresh_Tong_So_Dong()
        Return True
    End Function
#End Region

#Region "Kiem_Tra_Thong_Tin_Truoc_Khi_Tao_Dot_Nhan_Den"
    Private Function Kiem_Tra_Thong_Tin_Truoc_Khi_Tao_Dot_Nhan_Den() As Integer
        'Kiem tra dot giao nhan 
        Dim mDatatable As DataTable
        Dim mStatus As Integer
        'mDatatable = myORC_Receptacle.er_lay_tt_giao_nhan(myDot_Giao_Nhan_Chi_Tiet.ID_GIAO_NHAN, GBuu_Cuc_Khai_Thac, ORA_Receptacle_Ham_Dung_Chung.GLa_Nhan_Tui, mStatus).Tables(0)
        myDot_Giao_Nhan_Chi_Tiet.ID_GIAO_NHAN = txtMaVachBC37.Text
        mDatatable = myORC_Receptacle.er_lay_tt_giao_nhan(myDot_Giao_Nhan_Chi_Tiet.ID_GIAO_NHAN, GBuu_Cuc_Khai_Thac, ORA_Receptacle_Ham_Dung_Chung.GLa_Nhan_Tui, mStatus).Tables(0)
        Select Case mStatus
            Case 0
                MessageBox.Show("Lỗi không lấy được thông tin đợt giao túi!!! Kiểm tra lại kết nối với máy chủ Oracle", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                myDot_Giao_Nhan_Chi_Tiet = New ORA_TT_Giao_Nhan_Chi_Tiet
                Return 0
                Exit Function
            Case 1  'lay duoc thong tin
                If mDatatable.Rows.Count > 0 Then   'Da ton tai
                    myDot_Giao_Nhan_Chi_Tiet.ID_DOI_TAC = mDatatable.Rows(0).Item("ID_DOI_TAC")
                    myDot_Giao_Nhan_Chi_Tiet.ID_PHUONG_TIEN = mDatatable.Rows(0).Item("ID_PHUONG_TIEN")
                    myDot_Giao_Nhan_Chi_Tiet.LOAI_GIAO_NHAN = mDatatable.Rows(0).Item("LOAI_GIAO_NHAN")
                    myDot_Giao_Nhan_Chi_Tiet.MA_BC_KHAI_THAC = mDatatable.Rows(0).Item("MA_BC_KHAI_THAC")
                    myDot_Giao_Nhan_Chi_Tiet.NGAY_GIAO = mDatatable.Rows(0).Item("NGAY_GIAO")
                    myDot_Giao_Nhan_Chi_Tiet.GIO_GIAO = mDatatable.Rows(0).Item("GIO_GIAO")
                    myDot_Giao_Nhan_Chi_Tiet.DOT_GIAO = mDatatable.Rows(0).Item("DOT_GIAO")
                    myDot_Giao_Nhan_Chi_Tiet.MA_BC_NHAN = mDatatable.Rows(0).Item("MA_BC_NHAN")

                    lbThongTin.Text = " Ngày giao nhận : " & myDot_Giao_Nhan_Chi_Tiet.NGAY_GIAO & "- Mã BC gửi: " & myDot_Giao_Nhan_Chi_Tiet.MA_BC_KHAI_THAC & " - Mã BC nhận : " & myDot_Giao_Nhan_Chi_Tiet.MA_BC_NHAN & "- Đợt giao nhận : " & myDot_Giao_Nhan_Chi_Tiet.DOT_GIAO & "- Id đối tác : " & myDot_Giao_Nhan_Chi_Tiet.ID_DOI_TAC & " - Id phương tiện : " & myDot_Giao_Nhan_Chi_Tiet.ID_PHUONG_TIEN
                    Return 1
                    Exit Function
                Else
                    MessageBox.Show("Không tìm thấy đợt giao nhận này!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    myDot_Giao_Nhan_Chi_Tiet = New ORA_TT_Giao_Nhan_Chi_Tiet
                    lbThongTin.Text = "Không tìm thấy đợt giao nhận này!!!"
                    txtMaVachBC37.SelectAll()
                    txtMaVachBC37.Focus()
                    Return 3
                    Exit Function
                End If
            Case 2  'Dot da hoan tat khong duoc mo
                MessageBox.Show("Đợt giao túi này đã hoàn tất giao, vì vậy không được phép mở!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                myDot_Giao_Nhan_Chi_Tiet = New ORA_TT_Giao_Nhan_Chi_Tiet
                Return 2
                Exit Function
            Case Else
        End Select
        Return True
    End Function
#End Region

#Region "Refresh_Thong_Tin_Tren_Form_Khi_Ket_Thuc"
    Private Sub Refresh_Thong_Tin_Tren_Form_Khi_Ket_Thuc()
        myDot_Giao_Nhan_Chi_Tiet = New ORA_TT_Giao_Nhan_Chi_Tiet
        DataGrid_Thong_Tin_Tui_Thu("")
        Enable_Control(True)
        txtMaVachBC37.Text = ""
        txtMaVachTui.Text = ""
        myDanhSachTuiThu = New DataTable
        txtMaVachBC37.Focus()
        txtMaVachBC37.SelectAll()
    End Sub
#End Region

#Region "Ket_Thuc_Dot_Giao_Nhan"
    Private Sub Ket_Thuc_Dot_Giao_Nhan(ByVal mIs_Ket_Thuc As Boolean)
        Try
            Dim mStatus As Integer = 0
            'Khong có thông tin trong đợt giao túi gói
            If dgNhanTuiDen.Rows.Count = 0 Then
                Refresh_Thong_Tin_Tren_Form_Khi_Ket_Thuc()
            Else  'Có thông tin
                If Not myDot_Giao_Nhan_Chi_Tiet Is Nothing Then
                    'Hoan tat dot nhan tui
                    If mIs_Ket_Thuc Then
                        mStatus = myORC_Receptacle.er_tt_giao_nhan_hoan_tat_nhan(myDot_Giao_Nhan_Chi_Tiet.ID_GIAO_NHAN)
                        If mStatus = 0 Then   'Không cập nhật được
                            MessageBox.Show("Xảy ra lỗi trong quá trình hoàn tất và kết thúc đợt giao nhận!!! Kiểm tra kết nối với máy chủ Oracle và thử làm lại thao tác này.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        End If
                    End If
                    'OK => Thiết lập lại đối tượng trên form
                    Refresh_Thong_Tin_Tren_Form_Khi_Ket_Thuc()
                Else
                    MessageBox.Show("Lỗi không ghi được đợt giao túi gói!!! Phát sinh lỗi này hãy báo ngay cho người quản trị vì đây có thể là lỗi phát sinh do lập trình viên.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

    Private Sub btnKet_Thuc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKet_Thuc.Click
        Ket_Thuc_Dot_Giao_Nhan(True)
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class


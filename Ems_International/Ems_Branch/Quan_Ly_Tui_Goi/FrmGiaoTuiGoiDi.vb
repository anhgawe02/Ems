Imports System
Imports ADODB
Imports System.IO
Imports System.Windows.Forms
Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports Ems_International_Logic.EMS
Public Class FrmGiaoTuiGoiDi
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
    Friend WithEvents dgGiaoTuiDi As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbDoi_Tac As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbPhuong_Tien As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents CbBCGui As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbBCNhan As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents btnKet_Thuc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnXoa As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnBat_Dau As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtMaVachTui As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDot_Giao As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpNgay_Giao As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents btnLuu_Tam As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtSo_Ban As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnIn_Bc37 As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmGiaoTuiGoiDi))
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("E2Di", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_TT_TUI_THU")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_TUI_THU")
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
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("cbPhuong_Tien", -1)
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Loai_Phuong_Tien")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Loai_Phuong_Tien")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Hieu")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Doi_Tac", -1)
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Doi_Tac")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Doi_Tac")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("cbBCNhan", -1)
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MA_BC_NHAN")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TEN_BUU_CUC")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("cbBC_Gui", -1)
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BC_Gui")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Buu_Cuc")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.btnKet_Thuc = New Infragistics.Win.Misc.UltraButton
        Me.btnXoa = New Infragistics.Win.Misc.UltraButton
        Me.BtnExit = New Infragistics.Win.Misc.UltraButton
        Me.dgGiaoTuiDi = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.Label5 = New System.Windows.Forms.Label
        Me.cbPhuong_Tien = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cbDoi_Tac = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbBCNhan = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.CbBCGui = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.btnBat_Dau = New Infragistics.Win.Misc.UltraButton
        Me.txtMaVachTui = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.txtDot_Giao = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtpNgay_Giao = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnLuu_Tam = New Infragistics.Win.Misc.UltraButton
        Me.txtSo_Ban = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnIn_Bc37 = New Infragistics.Win.Misc.UltraButton
        CType(Me.dgGiaoTuiDi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbPhuong_Tien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDoi_Tac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbBCNhan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbBCGui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDot_Giao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpNgay_Giao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSo_Ban, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnKet_Thuc
        '
        Appearance1.FontData.BoldAsString = "True"
        Me.btnKet_Thuc.Appearance = Appearance1
        Me.btnKet_Thuc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKet_Thuc.Location = New System.Drawing.Point(699, 80)
        Me.btnKet_Thuc.Name = "btnKet_Thuc"
        Me.btnKet_Thuc.Size = New System.Drawing.Size(128, 32)
        Me.btnKet_Thuc.TabIndex = 16
        Me.btnKet_Thuc.Text = "&Kết thúc đợt giao"
        '
        'btnXoa
        '
        Appearance2.FontData.BoldAsString = "True"
        Me.btnXoa.Appearance = Appearance2
        Me.btnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.Location = New System.Drawing.Point(520, 448)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(104, 40)
        Me.btnXoa.TabIndex = 17
        Me.btnXoa.Text = "Xóa thông tin"
        Me.btnXoa.Visible = False
        '
        'BtnExit
        '
        Appearance3.FontData.BoldAsString = "True"
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        Me.BtnExit.Appearance = Appearance3
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(632, 448)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(104, 40)
        Me.BtnExit.TabIndex = 18
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.Visible = False
        '
        'dgGiaoTuiDi
        '
        Me.dgGiaoTuiDi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgGiaoTuiDi.DisplayLayout.AddNewBox.Prompt = " "
        Appearance4.BackColor = System.Drawing.Color.White
        Appearance4.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgGiaoTuiDi.DisplayLayout.Appearance = Appearance4
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
        Appearance5.ImageVAlign = Infragistics.Win.VAlign.Bottom
        UltraGridBand1.Override.RowSelectorAppearance = Appearance5
        UltraGridBand1.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand1.UseRowLayout = True
        Me.dgGiaoTuiDi.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.dgGiaoTuiDi.DisplayLayout.InterBandSpacing = 10
        Me.dgGiaoTuiDi.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Me.dgGiaoTuiDi.DisplayLayout.Override.CardAreaAppearance = Appearance6
        Me.dgGiaoTuiDi.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance7.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance7.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance7.ForeColor = System.Drawing.Color.Black
        Appearance7.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance7.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgGiaoTuiDi.DisplayLayout.Override.HeaderAppearance = Appearance7
        Me.dgGiaoTuiDi.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Appearance8.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgGiaoTuiDi.DisplayLayout.Override.RowAppearance = Appearance8
        Appearance9.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance9.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.dgGiaoTuiDi.DisplayLayout.Override.RowSelectorAppearance = Appearance9
        Me.dgGiaoTuiDi.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgGiaoTuiDi.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance10.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance10.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance10.ForeColor = System.Drawing.Color.Black
        Me.dgGiaoTuiDi.DisplayLayout.Override.SelectedRowAppearance = Appearance10
        Me.dgGiaoTuiDi.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgGiaoTuiDi.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgGiaoTuiDi.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.ExtendedAutoDrag
        Me.dgGiaoTuiDi.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgGiaoTuiDi.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgGiaoTuiDi.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgGiaoTuiDi.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgGiaoTuiDi.Location = New System.Drawing.Point(0, 117)
        Me.dgGiaoTuiDi.Name = "dgGiaoTuiDi"
        Me.dgGiaoTuiDi.Size = New System.Drawing.Size(832, 456)
        Me.dgGiaoTuiDi.TabIndex = 15
        Me.dgGiaoTuiDi.Text = "Danh sách giao túi gói đi"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(8, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 24)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Mã Vạch Túi:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbPhuong_Tien
        '
        Me.cbPhuong_Tien.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn17.Header.VisiblePosition = 0
        UltraGridColumn18.Header.VisiblePosition = 1
        UltraGridColumn19.Header.VisiblePosition = 2
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn17, UltraGridColumn18, UltraGridColumn19})
        Me.cbPhuong_Tien.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Appearance11.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance11.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance11.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance11.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbPhuong_Tien.DisplayLayout.Override.HeaderAppearance = Appearance11
        Me.cbPhuong_Tien.DisplayMember = ""
        Me.cbPhuong_Tien.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPhuong_Tien.Location = New System.Drawing.Point(552, 48)
        Me.cbPhuong_Tien.Name = "cbPhuong_Tien"
        Me.cbPhuong_Tien.Size = New System.Drawing.Size(144, 25)
        Me.cbPhuong_Tien.TabIndex = 11
        Me.cbPhuong_Tien.ValueMember = ""
        '
        'cbDoi_Tac
        '
        Me.cbDoi_Tac.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn20.Header.VisiblePosition = 0
        UltraGridColumn21.Header.VisiblePosition = 1
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn20, UltraGridColumn21})
        Me.cbDoi_Tac.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Appearance12.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance12.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance12.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance12.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbDoi_Tac.DisplayLayout.Override.HeaderAppearance = Appearance12
        Me.cbDoi_Tac.DisplayMember = ""
        Me.cbDoi_Tac.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDoi_Tac.Location = New System.Drawing.Point(264, 48)
        Me.cbDoi_Tac.Name = "cbDoi_Tac"
        Me.cbDoi_Tac.Size = New System.Drawing.Size(176, 25)
        Me.cbDoi_Tac.TabIndex = 9
        Me.cbDoi_Tac.ValueMember = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(448, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 24)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Phương tiện V.C"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(192, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Đối tác V.C"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(448, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Bưu cục nhận"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bưu cục gửi"
        '
        'cbBCNhan
        '
        Me.cbBCNhan.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn22.Header.VisiblePosition = 0
        UltraGridColumn23.Header.VisiblePosition = 1
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn22, UltraGridColumn23})
        Me.cbBCNhan.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Appearance13.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance13.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance13.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance13.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbBCNhan.DisplayLayout.Override.HeaderAppearance = Appearance13
        Me.cbBCNhan.DisplayMember = ""
        Me.cbBCNhan.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBCNhan.Location = New System.Drawing.Point(552, 16)
        Me.cbBCNhan.Name = "cbBCNhan"
        Me.cbBCNhan.Size = New System.Drawing.Size(144, 25)
        Me.cbBCNhan.TabIndex = 5
        Me.cbBCNhan.ValueMember = ""
        '
        'CbBCGui
        '
        Me.CbBCGui.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn24.Header.VisiblePosition = 0
        UltraGridColumn25.Header.VisiblePosition = 1
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn24, UltraGridColumn25})
        Me.CbBCGui.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Appearance14.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance14.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance14.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance14.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.CbBCGui.DisplayLayout.Override.HeaderAppearance = Appearance14
        Me.CbBCGui.DisplayMember = "Ten_Buu_Cuc"
        Me.CbBCGui.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbBCGui.Location = New System.Drawing.Point(264, 16)
        Me.CbBCGui.Name = "CbBCGui"
        Me.CbBCGui.Size = New System.Drawing.Size(176, 25)
        Me.CbBCGui.TabIndex = 3
        Me.CbBCGui.ValueMember = "BC_Gui"
        '
        'btnBat_Dau
        '
        Appearance15.FontData.BoldAsString = "True"
        Me.btnBat_Dau.Appearance = Appearance15
        Me.btnBat_Dau.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBat_Dau.Location = New System.Drawing.Point(699, 16)
        Me.btnBat_Dau.Name = "btnBat_Dau"
        Me.btnBat_Dau.Size = New System.Drawing.Size(128, 32)
        Me.btnBat_Dau.TabIndex = 12
        Me.btnBat_Dau.Text = "&Bắt đầu đợt giao"
        '
        'txtMaVachTui
        '
        Appearance16.BackColor = System.Drawing.Color.Red
        Appearance16.FontData.BoldAsString = "True"
        Appearance16.FontData.Name = "Arial"
        Appearance16.FontData.SizeInPoints = 14.0!
        Appearance16.ForeColor = System.Drawing.Color.White
        Me.txtMaVachTui.Appearance = Appearance16
        Me.txtMaVachTui.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtMaVachTui.InputMask = "999999999999AAA99999999999999"
        Me.txtMaVachTui.Location = New System.Drawing.Point(96, 80)
        Me.txtMaVachTui.Name = "txtMaVachTui"
        Me.txtMaVachTui.Size = New System.Drawing.Size(360, 29)
        Me.txtMaVachTui.TabIndex = 14
        '
        'txtDot_Giao
        '
        Me.txtDot_Giao.Location = New System.Drawing.Point(80, 48)
        Me.txtDot_Giao.MaxValue = 99
        Me.txtDot_Giao.MinValue = 1
        Me.txtDot_Giao.Name = "txtDot_Giao"
        Me.txtDot_Giao.PromptChar = Microsoft.VisualBasic.ChrW(32)
        Me.txtDot_Giao.Size = New System.Drawing.Size(104, 23)
        Me.txtDot_Giao.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.txtDot_Giao.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 24)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Đợt giao"
        '
        'dtpNgay_Giao
        '
        Me.dtpNgay_Giao.DateTime = New Date(2008, 7, 3, 0, 0, 0, 0)
        Me.dtpNgay_Giao.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgay_Giao.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpNgay_Giao.Location = New System.Drawing.Point(80, 16)
        Me.dtpNgay_Giao.MaskInput = "dd/mm/yyyy"
        Me.dtpNgay_Giao.Name = "dtpNgay_Giao"
        Me.dtpNgay_Giao.Size = New System.Drawing.Size(104, 25)
        Me.dtpNgay_Giao.TabIndex = 1
        Me.dtpNgay_Giao.Value = New Date(2008, 7, 3, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Ngày giao"
        '
        'btnLuu_Tam
        '
        Appearance17.FontData.BoldAsString = "True"
        Me.btnLuu_Tam.Appearance = Appearance17
        Me.btnLuu_Tam.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLuu_Tam.Location = New System.Drawing.Point(699, 48)
        Me.btnLuu_Tam.Name = "btnLuu_Tam"
        Me.btnLuu_Tam.Size = New System.Drawing.Size(128, 32)
        Me.btnLuu_Tam.TabIndex = 19
        Me.btnLuu_Tam.Text = "&Lưu tạm thời"
        '
        'txtSo_Ban
        '
        Me.txtSo_Ban.Location = New System.Drawing.Point(512, 83)
        Me.txtSo_Ban.MaxValue = 9
        Me.txtSo_Ban.MinValue = 1
        Me.txtSo_Ban.Name = "txtSo_Ban"
        Me.txtSo_Ban.PromptChar = Microsoft.VisualBasic.ChrW(32)
        Me.txtSo_Ban.Size = New System.Drawing.Size(104, 23)
        Me.txtSo_Ban.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.txtSo_Ban.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(464, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Số bản"
        '
        'btnIn_Bc37
        '
        Appearance18.FontData.BoldAsString = "True"
        Me.btnIn_Bc37.Appearance = Appearance18
        Me.btnIn_Bc37.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIn_Bc37.Location = New System.Drawing.Point(624, 80)
        Me.btnIn_Bc37.Name = "btnIn_Bc37"
        Me.btnIn_Bc37.Size = New System.Drawing.Size(72, 32)
        Me.btnIn_Bc37.TabIndex = 22
        Me.btnIn_Bc37.Text = "&In BC37"
        '
        'FrmGiaoTuiGoiDi
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(832, 573)
        Me.Controls.Add(Me.cbDoi_Tac)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnIn_Bc37)
        Me.Controls.Add(Me.txtSo_Ban)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnLuu_Tam)
        Me.Controls.Add(Me.dtpNgay_Giao)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDot_Giao)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtMaVachTui)
        Me.Controls.Add(Me.btnBat_Dau)
        Me.Controls.Add(Me.cbBCNhan)
        Me.Controls.Add(Me.CbBCGui)
        Me.Controls.Add(Me.btnKet_Thuc)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.dgGiaoTuiDi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbPhuong_Tien)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmGiaoTuiGoiDi"
        Me.Text = "FrmGiaoTuiGoiDi"
        CType(Me.dgGiaoTuiDi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbPhuong_Tien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDoi_Tac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbBCNhan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbBCGui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDot_Giao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpNgay_Giao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSo_Ban, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Khai bao bien trong Form"
    Dim myORC_Receptacle As New ORA_Receptacle(GOracleConnectionString_E_Receptacle)
    Dim myHam_Dung_Chung As New Ham_Dung_Chung
    Dim myColumn As Infragistics.Win.UltraWinGrid.UltraGridColumn = Nothing
    Dim myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Dim myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Dim myKeys As New ModifyRegistry
    Dim myDot_Giao_Nhan_Chi_Tiet As New ORA_TT_Giao_Nhan_Chi_Tiet
    Dim myNgay_Regitry As Integer
#End Region

#Region "Form Load"
    Private Sub FrmGiaoTuiGoiDi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Chức năng giao túi gói đi nội địa"
        Me.CenterToScreen()
        Me.ControlBox = True
        Me.MaximizeBox = False
        Init_Form()
    End Sub
#End Region
#Region "Validated "
    Private Sub CbBCGui_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbBCGui.Validated
        Load_CBo_BC_Nhan()
        Get_STT_Dot_Giao()
    End Sub
    Private Sub cbBCNhan_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbBCNhan.Validated
        Get_STT_Dot_Giao()
        Load_CBo_Doi_Tac()
    End Sub
    Private Sub cbDoi_Tac_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDoi_Tac.Validated
        Load_CBo_Phuong_Tien()
    End Sub
#End Region
#Region "GotFocus"
    'Private Sub cbBCNhan_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbBCNhan.GotFocus
    '    Dim mSender As UltraCombo
    '    mSender = sender
    '    mSender.ToggleDropdown()
    'End Sub
#End Region
#Region "btnBat_Dau_Click"
    Private Sub btnBat_Dau_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBat_Dau.Click
        Dim mStatus As Integer
        mStatus = Kiem_Tra_Thong_Tin_Truoc_Khi_Tao_Dot_Giao_Di(False)

        Select Case mStatus
            Case 10
                Exit Sub
            Case 0   'Lỗi kết nối
                'MessageBox.Show("Lỗi không tạo được đợt giao túi gói!!! Kiểm tra kết nối với máy chủ Oracle.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Case 1   'Đã tồn tại
                DataGrid_Thong_Tin_Tui_Thu(myDot_Giao_Nhan_Chi_Tiet.ID_GIAO_NHAN)
            Case 3   'Tạo mới
                'Trường hợp chưa tồn tại => Them moi dot giao nhan
                If DataGrid_Thong_Tin_Tui_Thu(myDot_Giao_Nhan_Chi_Tiet.ID_GIAO_NHAN) Then
                    Select Case myORC_Receptacle.er_tt_giao_nhan_them(myDot_Giao_Nhan_Chi_Tiet)
                        Case 0
                            MessageBox.Show("Lỗi không tạo được đợt giao túi gói!!! Kiểm tra kết nối với máy chủ Oracle.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        Case 3
                            MessageBox.Show("Đợt giao túi này đã hoàn tất giao, vì vậy không được phép mở!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                    End Select
                End If
            Case 2   'Đã tồn tại và hoàn tất không được mở
                MessageBox.Show("Lỗi không tạo được đợt giao túi gói!!! Kiểm tra kết nối với máy chủ Oracle.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Case Else   'Lỗi kết nối
                MessageBox.Show("Lỗi không tạo được đợt giao túi gói!!! Kiểm tra kết nối với máy chủ Oracle.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
        End Select
        Enable_Control(False)
        txtMaVachTui.Focus()
    End Sub
#End Region
#Region "btnLuu_Tam_Click"
    Private Sub btnLuu_Tam_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLuu_Tam.Click
        Ket_Thuc_Dot_Giao_Nhan(False)
    End Sub
#End Region
#Region "btnKet_Thuc_Click"
    Private Sub btnKet_Thuc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKet_Thuc.Click
        Try
            Ket_Thuc_Dot_Giao_Nhan(True)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "txtMaVachTui_KeyDown"
    Private Sub txtMaVachTui_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMaVachTui.KeyDown
        If e.KeyValue = Keys.Enter Or e.KeyValue = Keys.Tab Then
            Dim mChuyen_Thu_Di As New Chuyen_Thu_Di(GConnectionString)
            Dim mQLTG_E2_Di As New QLTGND_E2_Di(GConnectionString)
            Dim mE2_Di_Chi_Tiet As New E2_Di_Chi_Tiet
            If Kiem_Tra_Ma_Vach_Tui_Hop_Le(txtMaVachTui.Text, mE2_Di_Chi_Tiet) Then
                'Cap nhat len may chu ORCL
                Dim mTT_Tui_Thu_Chi_Tiet As New ORA_TT_Tui_Thu_Chi_Tiet
                mTT_Tui_Thu_Chi_Tiet.ID_TT_TUI_THU = 0
                mTT_Tui_Thu_Chi_Tiet.ID_TUI_THU = txtMaVachTui.Text
                If mE2_Di_Chi_Tiet.Id_Duong_Thu.Length > 12 Then
                    mTT_Tui_Thu_Chi_Tiet.ID_DUONG_THU = Convert.ToDouble(mE2_Di_Chi_Tiet.Id_Duong_Thu.Substring(1, 6) & mE2_Di_Chi_Tiet.Id_Duong_Thu.Substring(8, 6))
                Else
                    mTT_Tui_Thu_Chi_Tiet.ID_DUONG_THU = Convert.ToDouble(mE2_Di_Chi_Tiet.Id_Duong_Thu)
                End If
                mTT_Tui_Thu_Chi_Tiet.ID_CHUYEN_THU = mE2_Di_Chi_Tiet.Id_Chuyen_Thu
                mTT_Tui_Thu_Chi_Tiet.ID_GIAO_NHAN = myDot_Giao_Nhan_Chi_Tiet.ID_GIAO_NHAN
                mTT_Tui_Thu_Chi_Tiet.MA_BC_GUI = mE2_Di_Chi_Tiet.Ma_Bc_Khai_Thac
                mTT_Tui_Thu_Chi_Tiet.MA_BC_NHAN = Convert.ToInt32(txtMaVachTui.Text.Substring(6, 6))
                mTT_Tui_Thu_Chi_Tiet.CHUYEN_THU = mChuyen_Thu_Di.Lay(mE2_Di_Chi_Tiet.Id_Chuyen_Thu).So_Chuyen_Thu
                mTT_Tui_Thu_Chi_Tiet.TUI_SO = mE2_Di_Chi_Tiet.Tui_So
                mTT_Tui_Thu_Chi_Tiet.KHOI_LUONG = mE2_Di_Chi_Tiet.Khoi_Luong_BP + mE2_Di_Chi_Tiet.Khoi_Luong_Vo_Tui
                mTT_Tui_Thu_Chi_Tiet.KHOI_LUONG_QD = mQLTG_E2_Di.QLTGND_E2_Di_Lay_Tong_Khoi_Luong_QD_Tu_E1_Di(mE2_Di_Chi_Tiet.Id_E2) + mE2_Di_Chi_Tiet.Khoi_Luong_Vo_Tui
                mTT_Tui_Thu_Chi_Tiet.TONG_SO_BP = mE2_Di_Chi_Tiet.Tong_So_BP
                mTT_Tui_Thu_Chi_Tiet.CUOC_EMS = 0
                mTT_Tui_Thu_Chi_Tiet.CUOC_DV = 0
                mTT_Tui_Thu_Chi_Tiet.NGAY_DONG = mE2_Di_Chi_Tiet.Ngay_Dong
                mTT_Tui_Thu_Chi_Tiet.GIO_DONG = mE2_Di_Chi_Tiet.Gio_Dong
                mTT_Tui_Thu_Chi_Tiet.LOAI_TUI_THU = 0
                mTT_Tui_Thu_Chi_Tiet.LOAI_XAC_NHAN = ORA_Receptacle_Ham_Dung_Chung.GLa_Giao_Tui
                Select Case myORC_Receptacle.er_tt_tui_thu_them(mTT_Tui_Thu_Chi_Tiet)
                    Case 0
                        MessageBox.Show("Xảy ra lỗi trong quá trình thêm túi gói vào đợt giao nhận!!!" & "Kiểm tra kết nối với máy chủ Oracle", "Lỗi thêm túi gói vào đợt giao nhận", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtMaVachTui.Focus()
                        txtMaVachTui.SelectionStart = 0
                        txtMaVachTui.SelectionLength = txtMaVachTui.Text.Length
                        Exit Sub
                    Case 2
                        MessageBox.Show("Túi này đã có trong bản kê, bạn không đươc phép nhập thêm.", "Lỗi thêm túi gói vào đợt giao nhận", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtMaVachTui.Focus()
                        txtMaVachTui.SelectionStart = 0
                        txtMaVachTui.SelectionLength = txtMaVachTui.Text.Length
                    Case 3
                        MessageBox.Show("Xảy ra lỗi trong quá trình thêm túi gói vào đợt giao nhận!!!" & "Có thể đợt giao nhận đã bị đóng vì một lý do nào đó", "Lỗi thêm túi gói vào đợt giao nhận", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtMaVachTui.Focus()
                        txtMaVachTui.SelectionStart = 0
                        txtMaVachTui.SelectionLength = txtMaVachTui.Text.Length
                        Exit Sub
                    Case 4
                        MessageBox.Show("Túi này đã có trong bản kê, bạn không đươc phép nhập thêm.", "Lỗi thêm túi gói vào đợt giao nhận", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtMaVachTui.Focus()
                        txtMaVachTui.SelectionStart = 0
                        txtMaVachTui.SelectionLength = txtMaVachTui.Text.Length
                        Exit Sub
                    Case Else  '=1 la OK
                End Select
                'Ghi vao luoi
                AddNewRow(mTT_Tui_Thu_Chi_Tiet)
                txtMaVachTui.Text = ""
                txtMaVachTui.Focus()
                txtMaVachTui.SelectionStart = 0
                txtMaVachTui.SelectionLength = txtMaVachTui.Text.Length
            Else
                txtMaVachTui.Focus()
                txtMaVachTui.SelectionStart = 0
                txtMaVachTui.SelectionLength = txtMaVachTui.Text.Length
            End If
        End If
    End Sub
#End Region
#Region "dgGiaoTuiDi_InitializeLayout"
    Private Sub dgGiaoTuiDi_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgGiaoTuiDi.InitializeLayout
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

#Region "Ham nguoi dung"
#Region "Load_Cbo_BC_Gui"
    Private Sub Load_Cbo_BC_Gui()
        'Them moi mot bang
        Dim dataTable As New dataTable("cbBC_Gui")
        'Tao ra cac cot cua bang nay
        Dim colWork As DataColumn = New DataColumn("BC_Gui", GetType(Integer))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Ten_Buu_Cuc", GetType(String))
        dataTable.Columns.Add(colWork)
        'Them du lieu vao
        Dim row As DataRow = dataTable.NewRow()
        row("BC_Gui") = GBuu_Cuc_Khai_Thac
        row("Ten_Buu_Cuc") = GTen_Buu_Cuc_Khai_Thac
        dataTable.Rows.Add(row)
        CbBCGui.DataSource = dataTable
        CbBCGui.DataBind()
        'CbBCGui.LimitToList = True
        CbBCGui.Value = CbBCGui.Rows(0).Cells("BC_Gui").Value
        CbBCGui.Text = CbBCGui.Rows(0).Cells("Ten_Buu_Cuc").Value
    End Sub
#End Region
#Region "Load_CBo_BC_Nhan"
    Private Sub Load_CBo_BC_Nhan()
        If CbBCGui.Value Is Nothing Or CbBCGui.Value Is DBNull.Value Then
            cbBCNhan.DataSource = myORC_Receptacle.er_BC_nhan_BC_Khai_thac(0)
        Else
            cbBCNhan.DataSource = myORC_Receptacle.er_BC_nhan_BC_Khai_thac(CbBCGui.Value)
        End If
        cbBCNhan.DataBind()
        cbBCNhan.ValueMember = "MA_BC_NHAN"
        cbBCNhan.DisplayMember = "TEN_BUU_CUC"
        If cbBCNhan.Rows.Count > 0 Then
            cbBCNhan.Value = cbBCNhan.Rows(0).Cells("MA_BC_NHAN").Value
        End If
    End Sub
#End Region
#Region "Load_CBo_Phuong_Tien"
    Private Sub Load_CBo_Phuong_Tien()
        If CbBCGui.Value Is Nothing Or CbBCGui.Value Is DBNull.Value Or cbDoi_Tac.Value Is Nothing Or cbDoi_Tac.Value Is DBNull.Value Then
            cbPhuong_Tien.DataSource = myORC_Receptacle.er_phuong_tien_buu_cuc_doi_tac(0, 0)
        Else
            cbPhuong_Tien.DataSource = myORC_Receptacle.er_phuong_tien_buu_cuc_doi_tac(CbBCGui.Value, cbDoi_Tac.Value)
        End If
        cbPhuong_Tien.DataBind()
        cbPhuong_Tien.ValueMember = "Id_Loai_Phuong_Tien"
        cbPhuong_Tien.DisplayMember = "Loai_Phuong_Tien"
    End Sub
#End Region
#Region "Load_CBo_Doi_Tac"
    Private Sub Load_CBo_Doi_Tac()
        If CbBCGui.Value Is Nothing Or CbBCGui.Value Is DBNull.Value Or cbBCNhan.Value Is Nothing Or cbBCNhan.Value Is DBNull.Value Then
            cbDoi_Tac.DataSource = myORC_Receptacle.er_doi_tac_theo_ma_buu_cuc(0, 0)
        Else
            cbDoi_Tac.DataSource = myORC_Receptacle.er_doi_tac_theo_ma_buu_cuc(CbBCGui.Value, cbBCNhan.Value)
        End If
        cbDoi_Tac.DataBind()
        cbDoi_Tac.ValueMember = "Id_Doi_Tac"
        cbDoi_Tac.DisplayMember = "Ten_Doi_Tac"
    End Sub
#End Region
#Region "Init_Form"
    Private Sub Init_Form()
        myDot_Giao_Nhan_Chi_Tiet = New ORA_TT_Giao_Nhan_Chi_Tiet
        dtpNgay_Giao.Value = Now.Date()
        dtpNgay_Giao.ReadOnly = True
        ''Lấy ngày giao từ regitry - Nếu chưa có thì bằng ngày giao hiện tại
        'myNgay_Regitry = IIf(myKeys.Doc("ORA_Ngay_Giao") Is Nothing Or myKeys.Doc("ORA_Ngay_Giao") = "", myHam_Dung_Chung.ConvertDateToInt(dtpNgay_Giao.Value), Convert.ToInt32(myKeys.Doc("ORA_Ngay_Giao")))
        'If (myKeys.Doc("ORA_Ngay_Giao") Is Nothing Or myKeys.Doc("ORA_Ngay_Giao") = "") Then
        '    'Ghi lại thông tin ngày giao này vào regitry
        '    myKeys.Ghi("ORA_Ngay_Giao", Convert.ToString(myNgay_Regitry))
        'End If
        ''Kiểm tra nếu ngày giao hiện tại khác với ngày giao trong regitry thì đưa đợt giao về 1
        ''Nếu vẫn thuộc ngày giao hiện tại thì tăng lên 1
        'If myNgay_Regitry = myHam_Dung_Chung.ConvertDateToInt(dtpNgay_Giao.Value) Then   'thuộc ngày giao hiện tại
        '    txtDot_Giao.Value = IIf(myKeys.Doc("ORA_STT_Dot_Giao") Is Nothing Or myKeys.Doc("ORA_STT_Dot_Giao") = "", 1, Convert.ToInt32(myKeys.Doc("ORA_STT_Dot_Giao")) + 1)
        'Else   'Sang ngày mới (ngay_regitry <> ngay_giao_hien_tai) => đưa STT đợt giao về 1 
        '    txtDot_Giao.Value = 1
        '    myNgay_Regitry = myHam_Dung_Chung.ConvertDateToInt(dtpNgay_Giao.Value)
        '    myKeys.Ghi("ORA_Ngay_Giao", Convert.ToString(myNgay_Regitry))
        'End If
        txtSo_Ban.Value = IIf(myKeys.Doc("ORA_So_Ban_BC37") Is Nothing Or myKeys.Doc("ORA_So_Ban_BC37") = "", 1, Convert.ToInt32(myKeys.Doc("ORA_So_Ban_BC37")))
        Load_Cbo_BC_Gui()
        CbBCGui_Validated(CbBCGui, Nothing)
        txtMaVachTui.InputMask = "999999999999AAA99999999999999"
        txtMaVachTui.Text = ""
        txtMaVachTui.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Enable_Control(True)
        cbBCNhan.Select()
        cbBCNhan.ToggleDropdown()
    End Sub
#End Region
#Region "Refresh_Thong_Tin_Tren_Form_Khi_Ket_Thuc"
    Private Sub Refresh_Thong_Tin_Tren_Form_Khi_Ket_Thuc()
        myDot_Giao_Nhan_Chi_Tiet = New ORA_TT_Giao_Nhan_Chi_Tiet
        dtpNgay_Giao.Value = Now.Date()
        'txtDot_Giao.Value = IIf(myKeys.Doc("ORA_STT_Dot_Giao") Is Nothing Or myKeys.Doc("ORA_STT_Dot_Giao") = "", 1, Convert.ToInt32(myKeys.Doc("ORA_STT_Dot_Giao")) + 1)
        txtSo_Ban.Value = IIf(myKeys.Doc("ORA_So_Ban_BC37") Is Nothing Or myKeys.Doc("ORA_So_Ban_BC37") = "", 1, Convert.ToInt32(myKeys.Doc("ORA_So_Ban_BC37")))
        Enable_Control(True)
        CbBCGui_Validated(CbBCGui, Nothing)
        txtMaVachTui.Text = ""
        DataGrid_Thong_Tin_Tui_Thu("")
        cbBCNhan.Focus()
    End Sub
#End Region
#Region "Enable_Control"
    Private Sub Enable_Control(ByVal mBolCotrol As Boolean)
        txtDot_Giao.Enabled = mBolCotrol
        CbBCGui.Enabled = mBolCotrol
        cbBCNhan.Enabled = mBolCotrol
        cbPhuong_Tien.Enabled = mBolCotrol
        cbDoi_Tac.Enabled = mBolCotrol
        btnBat_Dau.Enabled = mBolCotrol

        txtMaVachTui.Enabled = Not mBolCotrol
        btnKet_Thuc.Enabled = Not mBolCotrol
        btnLuu_Tam.Enabled = Not mBolCotrol
        'txtSo_Ban.Enabled = Not mBolCotrol
        dgGiaoTuiDi.Enabled = Not mBolCotrol
    End Sub
#End Region
#Region "Kiem_Tra_Thong_Tin_Truoc_Khi_Tao_Dot_Giao_Di"
    Private Function Kiem_Tra_Thong_Tin_Truoc_Khi_Tao_Dot_Giao_Di(ByVal mIsPrint As Boolean) As Integer
        If CbBCGui.Value Is Nothing Or CbBCGui.Value Is DBNull.Value Then
            MessageBox.Show("Thông tin mã bưu cục gửi không hợp lệ!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CbBCGui.Focus()
            Return 10
            Exit Function
        End If
        If cbBCNhan.Value Is Nothing Or cbBCNhan.Value Is DBNull.Value Then
            MessageBox.Show("Thông tin mã bưu cục nhận không hợp lệ!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbBCNhan.Focus()
            Return 10
            Exit Function
        End If
        If cbDoi_Tac.Value Is Nothing Or cbDoi_Tac.Value Is DBNull.Value Then
            MessageBox.Show("Thông tin đối tác không hợp lệ!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbDoi_Tac.Focus()
            Return 10
            Exit Function
        End If
        If cbPhuong_Tien.Value Is Nothing Or cbPhuong_Tien.Value Is DBNull.Value Then
            MessageBox.Show("Thông tin phương tiện vận chuyển không hợp lệ!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbPhuong_Tien.Focus()
            Return 10
            Exit Function
        End If
        'Kiem tra dot giao nhan 
        myDot_Giao_Nhan_Chi_Tiet.ID_GIAO_NHAN = ORA_Receptacle_Ham_Dung_Chung.Create_Id_Giao_Nhan(CbBCGui.Value, cbBCNhan.Value, myHam_Dung_Chung.ConvertDateToInt(Now.Date()), cbDoi_Tac.Value, txtDot_Giao.Value)
        Dim mDatatable As DataTable
        Dim mStatus As Integer
        mDatatable = myORC_Receptacle.er_lay_tt_giao_nhan(myDot_Giao_Nhan_Chi_Tiet.ID_GIAO_NHAN, CbBCGui.Value, ORA_Receptacle_Ham_Dung_Chung.GLa_Giao_Tui, mStatus).Tables(0)
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
                    Return 1
                    Exit Function
                Else   'chua ton tai = tao moi
                    myDot_Giao_Nhan_Chi_Tiet.ID_DOI_TAC = cbDoi_Tac.Value
                    myDot_Giao_Nhan_Chi_Tiet.ID_PHUONG_TIEN = cbPhuong_Tien.Value
                    myDot_Giao_Nhan_Chi_Tiet.LOAI_GIAO_NHAN = ORA_Receptacle_Ham_Dung_Chung.GLa_Giao_Tui
                    myDot_Giao_Nhan_Chi_Tiet.MA_BC_KHAI_THAC = CbBCGui.Value
                    myDot_Giao_Nhan_Chi_Tiet.NGAY_GIAO = myHam_Dung_Chung.ConvertDateToInt(dtpNgay_Giao.Value)
                    myDot_Giao_Nhan_Chi_Tiet.GIO_GIAO = myHam_Dung_Chung.ConvertTimeToInt(Now())
                    myDot_Giao_Nhan_Chi_Tiet.DOT_GIAO = txtDot_Giao.Value
                    myDot_Giao_Nhan_Chi_Tiet.MA_BC_NHAN = cbBCNhan.Value
                    Return 3
                    Exit Function
                End If
            Case 2  'Dot da hoan tat khong duoc mo
                'MessageBox.Show("Đợt giao túi này đã hoàn tất giao, vì vậy không được phép mở!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If Not mIsPrint Then
                    myDot_Giao_Nhan_Chi_Tiet = New ORA_TT_Giao_Nhan_Chi_Tiet
                End If
                Return 2
                Exit Function
            Case Else
        End Select
        Return True
    End Function
#End Region
#Region "KeyEnter"
    Private Sub CbBCGui_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CbBCGui.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter 'Key Enter
                cbBCNhan.Select()
                cbBCNhan.ToggleDropdown()
            Case Else
        End Select
    End Sub
    Private Sub cbBCNhan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbBCNhan.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter 'Key Enter
                txtDot_Giao.Select()
                txtDot_Giao.SelectAll()
            Case Else
        End Select
    End Sub

    Private Sub cbDoi_Tac_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbDoi_Tac.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter 'Key Enter
                cbPhuong_Tien.Select()
                cbPhuong_Tien.ToggleDropdown()
            Case Else
        End Select
    End Sub

    Private Sub cbPhuong_Tien_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbPhuong_Tien.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter 'Key Enter
                btnBat_Dau.Select()
            Case Else
        End Select
    End Sub

    Private Sub txtDot_Giao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDot_Giao.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter 'Key Enter
                cbDoi_Tac.Select()
                cbDoi_Tac.ToggleDropdown()
            Case Else
        End Select
    End Sub

    Private Sub txtSo_Ban_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSo_Ban.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter 'Key Enter
                btnIn_Bc37.Select()
            Case Else
        End Select
    End Sub
#End Region
#Region "DataGrid_Thong_Tin_Tui_Thu"
    Private Function DataGrid_Thong_Tin_Tui_Thu(ByVal mId_Giao_Nhan As String) As Boolean
        Dim mStatus As Double = 0
        Dim mDatatable As DataTable = myORC_Receptacle.er_lay_tui_thu_giao_nhan(mId_Giao_Nhan, CbBCGui.Value, ORA_Receptacle_Ham_Dung_Chung.GLa_Giao_Tui, mStatus).Tables(0)
        If mStatus = 0 Then
            MessageBox.Show("Lỗi không load được dữ liệu trên lưới!!! Kiểm tra kết nối với máy chủ ORACLE", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
            Exit Function
        End If
        dgGiaoTuiDi.DataSource = mDatatable
        dgGiaoTuiDi.DataBind()
        Refresh_Tong_So_Dong()
        Return True
    End Function
#End Region
#Region "Kiem_Tra_Ma_Vach_Tui_Hop_Le"
    Private Function Kiem_Tra_Ma_Vach_Tui_Hop_Le(ByVal mMa_Vach_Tui As String, ByRef mE2_Di_Chi_Tiet As E2_Di_Chi_Tiet) As Boolean
        Dim mQLTGND_E2_Di As New QLTGND_E2_Di(GConnectionString)
        Dim mE2_Di As New E2_Di(GConnectionString)
        Dim mQLTGND_E2_Di_Chi_Tiet As New QLTGND_E2_Di_Chi_Tiet
        Dim mSo_Dong As Integer
        Dim mId_E2 As String
        Try
            mId_E2 = mQLTGND_E2_Di.QLTGND_E2_Di_Lay_Id_E2_Theo_Ma_Vach_Tui(mMa_Vach_Tui, mSo_Dong)
            If mSo_Dong = 0 Then
                MessageBox.Show("Không tìm thấy túi từ mã vạch túi này, túi này không tồn tại vì vậy bạn không thể giao đi!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                mE2_Di_Chi_Tiet = Nothing
                Return False
            ElseIf mSo_Dong = 1 Then
                mE2_Di_Chi_Tiet = mE2_Di.Lay(mId_E2)
                mQLTGND_E2_Di_Chi_Tiet = mQLTGND_E2_Di.QLTGND_E2_Di_Lay(mId_E2)
                'For Each mRow As UltraGridRow In dgGiaoTuiDi.Rows
                '    If mRow.Cells("Id_Tui_Thu").Text = mQLTGND_E2_Di_Chi_Tiet.Id_Tui_Thu Then
                '        MessageBox.Show("Túi này đã có trong bản kê, bạn không đươc phép nhập thêm.", "Lỗi thêm túi gói vào đợt giao nhận", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                '        Return False
                '        Exit For
                '    End If
                'Next
                Return True
            Else
                MessageBox.Show("Có 2 túi cùng chung 1 mã vạch này!!! Bạn không thể giao mã vạch túi này đi, hãy kiểm tra lại hoặc báo cho người quản trị về lỗi này", "Cảnh báo nguy hiểm", MessageBoxButtons.OK, MessageBoxIcon.Error)
                mE2_Di_Chi_Tiet = Nothing
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region
#Region "AddNewRow"
    Private Sub AddNewRow(ByVal mThong_Tin_Tui_Chi_Tiet As ORA_TT_Tui_Thu_Chi_Tiet)
        Try
            myGridKeyDown = dgGiaoTuiDi
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
            myGridKeyDown.Rows(mLastRow).Cells("NGAY_XN_DEN").Value = 0
            myGridKeyDown.Rows(mLastRow).Cells("GIO_XN_DEN").Value = 0
            Refresh_Tong_So_Dong()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Ket_Thuc_Dot_Giao_Nhan"
    Private Sub Ket_Thuc_Dot_Giao_Nhan(ByVal mIs_Ket_Thuc As Boolean)
        Try
            Dim mStatus As Integer = 0
            'Khong có thông tin trong đợt giao túi gói
            If dgGiaoTuiDi.Rows.Count = 0 Then
                If MessageBox.Show("Không có túi nào trong đợt giao túi này, vì vậy không thể lưu." & "Nếu bạn muốn đóng đợt giao nhận này lại thì đợt giao nhận sẽ được xóa bỏ trên máy chủ Oracle, vì đây là đợt giao túi gói không có túi gói nào.", "Cảnh báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    If myDot_Giao_Nhan_Chi_Tiet.ID_GIAO_NHAN <> "" Then
                        mStatus = myORC_Receptacle.er_tt_giao_nhan_xoa(myDot_Giao_Nhan_Chi_Tiet.ID_GIAO_NHAN)
                        Select Case mStatus
                            Case 0
                                MessageBox.Show("Chưa xóa được đợt giao nhận này!!! Kiểm tra lại kết nối với máy chủ Oracle và thử làm lại thao tác này.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Exit Sub
                            Case 1

                            Case 2
                                MessageBox.Show("Đợt giao nhận này đã hoàn tất giao, không thể xóa!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Case 3
                                MessageBox.Show("Vẫn còn túi gói thuộc đợt giao nhận này, không thể xóa!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End Select
                        Refresh_Thong_Tin_Tren_Form_Khi_Ket_Thuc()
                    End If
                End If
            Else  'Có thông tin
                If Not myDot_Giao_Nhan_Chi_Tiet Is Nothing Then
                    mStatus = myORC_Receptacle.er_tt_giao_nhan_them(myDot_Giao_Nhan_Chi_Tiet)
                    Select Case mStatus
                        Case 0
                            MessageBox.Show("Lỗi không ghi được đợt giao túi gói!!! Kiểm tra kết nối với máy chủ Oracle.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        Case 3
                            MessageBox.Show("Đợt giao túi này đã hoàn tất giao, vì vậy không được phép ghi đè!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                    End Select
                    'Hoan tat dot giao tui
                    If mIs_Ket_Thuc Then
                        mStatus = myORC_Receptacle.er_tt_giao_nhan_hoan_tat_giao(myDot_Giao_Nhan_Chi_Tiet.ID_GIAO_NHAN)
                        If mStatus = 0 Then   'Không cập nhật được
                            MessageBox.Show("Xảy ra lỗi trong quá trình hoàn tất và kết thúc đợt giao nhận!!! Kiểm tra kết nối với máy chủ Oracle và thử làm lại thao tác này.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        End If
                        Ban_Ke_BC37_Tong_Hop(myDot_Giao_Nhan_Chi_Tiet.ID_GIAO_NHAN, cbPhuong_Tien.Text, CbBCGui.Value, CbBCGui.Text, cbBCNhan.Value, cbBCNhan.Text, False, IIf(txtSo_Ban.Value Is DBNull.Value, 1, txtSo_Ban.Value))
                    End If
                    'OK => Ghi regitry và thiết lập lại đối tượng trên form
                    myKeys.Ghi("ORA_STT_Dot_Giao", Convert.ToString(txtDot_Giao.Value))
                    myKeys.Ghi("ORA_So_Ban_BC37", Convert.ToString(txtSo_Ban.Value))
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
#Region "Refresh_Tong_So_Dong"
    Private Sub Refresh_Tong_So_Dong()
        dgGiaoTuiDi.Text = "Danh sách giao túi gói đi (Tổng số: " & dgGiaoTuiDi.Rows.Count.ToString & " túi)"
    End Sub
#End Region
#End Region

    Private Sub txtMaVachTui_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMaVachTui.GotFocus
        txtMaVachTui.SelectionStart = 0
        txtMaVachTui.SelectionLength = txtMaVachTui.Text.Length
    End Sub

    Private Sub dgGiaoTuiDi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgGiaoTuiDi.KeyDown
        If e.KeyValue = Keys.F8 Then
            If dgGiaoTuiDi.ActiveRow Is DBNull.Value Or dgGiaoTuiDi.ActiveRow Is DBNull.Value Then
                Exit Sub
            End If
            If dgGiaoTuiDi.ActiveRow.Cells("ID_TUI_THU").Text <> "" Then
                If MessageBox.Show("Bạn có chắc chắn muốn xóa dòng dữ liệu này không?", "Cảnh báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    Dim mStatus As Integer = 0
                    Dim mdatatable As DataTable = myORC_Receptacle.er_lay_tt_giao_nhan(myDot_Giao_Nhan_Chi_Tiet.ID_GIAO_NHAN, myDot_Giao_Nhan_Chi_Tiet.MA_BC_KHAI_THAC, ORA_Receptacle_Ham_Dung_Chung.GLa_Giao_Tui, mStatus).Tables(0)
                    If mStatus = 2 Then
                        MessageBox.Show("Đợt giao nhận này đã hòa tất giao, bạn không được quyền xóa túi gói trong đợt.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    If mStatus = 0 Then
                        MessageBox.Show("Có lỗi xảy ra khi kết nối với máy chủ Oracle. Kiểm tra lại kết nối với máy chủ Oracle", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    myORC_Receptacle.er_tt_tui_thu_xoa(Convert.ToInt32(dgGiaoTuiDi.ActiveRow.Cells("ID_TT_TUI_THU").Text), dgGiaoTuiDi.ActiveRow.Cells("ID_TUI_THU").Text, myDot_Giao_Nhan_Chi_Tiet.ID_GIAO_NHAN)
                    dgGiaoTuiDi.ActiveRow.Delete(False)
                    MessageBox.Show("Đã xóa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Refresh_Tong_So_Dong()
                End If
            End If
        End If
    End Sub

    Private Sub btnIn_Bc37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIn_Bc37.Click
        Dim mStatus As Integer
        Try
            mStatus = Kiem_Tra_Thong_Tin_Truoc_Khi_Tao_Dot_Giao_Di(True)
            Select Case mStatus
                Case 10
                    Exit Sub
                Case 0   'Lỗi kết nối
                    'MessageBox.Show("Lỗi không lấy được thông tin đợt giao túi gói!!! Kiểm tra kết nối với máy chủ Oracle.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                Case 1   'Đã tồn tại chưa hoàn tất chưa được in
                    MessageBox.Show("Đợt giao túi gói này chưa hoàn tất giao!!! Vì vậy không được phép in BC37 tổng hợp." & vbNewLine & "Bạn phải mở lại đợt giao túi gói này và thực hiện kết thúc giao.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                Case 2   'Đã tồn tại và hoàn tất được phép in
                    'In BC37   
                    Ban_Ke_BC37_Tong_Hop(myDot_Giao_Nhan_Chi_Tiet.ID_GIAO_NHAN, cbPhuong_Tien.Text, CbBCGui.Value, CbBCGui.Text, cbBCNhan.Value, cbBCNhan.Text, False, IIf(txtSo_Ban.Value Is DBNull.Value, 1, txtSo_Ban.Value))
                Case 3  'khong co du lieu
                    MessageBox.Show("Không có dữ liệu theo yêu cầu!!! Kiểm tra lại thông tin đượt giao và bưu cục nhận.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtDot_Giao.Select()
                    txtDot_Giao.SelectAll()
                    Exit Sub
                Case Else   'Lỗi kết nối
                    MessageBox.Show("Lỗi không lấy được thông tin đợt giao túi gói!!! Kiểm tra kết nối với máy chủ Oracle.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region "Get_STT_Dot_Giao"
    Private Sub Get_STT_Dot_Giao()
        Try
            If ((CbBCGui.Value Is DBNull.Value) Or (cbBCNhan.Value Is DBNull.Value)) Then
                Exit Sub
            End If
            Dim STT As Integer
            Dim mStatus As Integer
            STT = myORC_Receptacle.er_dot_giao_max_theo_ngay(CbBCGui.Value, cbBCNhan.Value, myHam_Dung_Chung.ConvertDateToInt(dtpNgay_Giao.Value), mStatus)
            Select Case mStatus
                Case 0
                    MessageBox.Show("Lỗi không lấy được đợt giao trong ngày theo tuyến vận chuyển!!! Kiểm tra kết nối với máy chủ Oracle" & vbNewLine & "Bạn vẫn có thể tiếp tục bằng cách nhập tay số thứ tự đợt giao nhận vào chương trình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtDot_Giao.Value = IIf(myKeys.Doc("ORA_STT_Dot_Giao") Is Nothing Or myKeys.Doc("ORA_STT_Dot_Giao") = "", 1, Convert.ToInt32(myKeys.Doc("ORA_STT_Dot_Giao")) + 1)
                Case 1  'có đợt giao trước đó rồi
                    txtDot_Giao.Value = STT + 1
                Case 2  'chưa có đợt giao nào trong ngày
                    txtDot_Giao.Value = STT + 1
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDot_Giao.Value = IIf(myKeys.Doc("ORA_STT_Dot_Giao") Is Nothing Or myKeys.Doc("ORA_STT_Dot_Giao") = "", 1, Convert.ToInt32(myKeys.Doc("ORA_STT_Dot_Giao")) + 1)
        End Try
    End Sub
#End Region

    'Private Sub txtSo_Ban_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSo_Ban.LostFocus
    '    txtSo_Ban.SelectAll()
    'End Sub

    'Private Sub cbDoi_Tac_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDoi_Tac.LostFocus
    '    Dim mSender As UltraCombo
    '    mSender = sender
    '    mSender.ToggleDropdown()
    'End Sub

    'Private Sub cbPhuong_Tien_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbPhuong_Tien.LostFocus
    '    Dim mSender As UltraCombo
    '    mSender = sender
    '    mSender.ToggleDropdown()
    'End Sub

    'Private Sub cbBCNhan_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbBCNhan.LostFocus
    '    Dim mSender As UltraCombo
    '    mSender = sender
    '    mSender.ToggleDropdown()
    'End Sub


    Private Sub txtMaVachTui_MaskChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinMaskedEdit.MaskChangedEventArgs) Handles txtMaVachTui.MaskChanged

    End Sub
End Class

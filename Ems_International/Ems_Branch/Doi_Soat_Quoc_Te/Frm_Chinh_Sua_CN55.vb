Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports System.Data
Imports System.Data.OracleClient
Imports System.Data.SqlClient
Imports System.Math
Imports Ems_International_Logic.EMS
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Microsoft.Office

Public Class Frm_Chinh_Sua_CN55
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
    Friend WithEvents lblCN56 As System.Windows.Forms.Label
    Friend WithEvents chkMa_Bc_Khai_Thac As System.Windows.Forms.CheckBox
    Friend WithEvents chkNuoc_Thanh_Toan As System.Windows.Forms.CheckBox
    Friend WithEvents btnThoat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cb_Nam As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cb_Quy As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cb_Thang As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents opt_Nam As System.Windows.Forms.RadioButton
    Friend WithEvents opt_Quy As System.Windows.Forms.RadioButton
    Friend WithEvents opt_Thang As System.Windows.Forms.RadioButton
    Friend WithEvents group_Thoi_Gian As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents chk_Duong_Thu As System.Windows.Forms.CheckBox
    Friend WithEvents gridCN55 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnPrint As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnLoad As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cb_Ma_Bc_Khai_Thac As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cb_Ma_Nuoc As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cb_Duong_Thu As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cb_Phan_Loai As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents group_Vi_Tri As Infragistics.Win.Misc.UltraGroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_Chinh_Sua_CN55))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("DSQT_CN56", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_CN56")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thang")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Quy")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nam")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc_Duong_Thu")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc_Thanh_Toan")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Thanh_Toan")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IMPC_Thanh_Toan")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nuoc_Gui")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Bc_Gui")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nuoc_Nhan")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Bc_Nhan")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SL_Chuyen_Thu")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Luong_D")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong_D")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Luong_M")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong_M")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Luong_R")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong_R")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Luong_OPS")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong_OPS")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong_Vo_Tui")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Theo_SL")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Theo_KL")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_VCMBND")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Hang_Khong")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Khac")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tien_Te")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Doanh_Thu_D")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Doanh_Thu_M")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Doanh_Thu")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Doanh_Thu_VND")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Hang_Van_Chuyen")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ghi_Chu")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("I_O")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chot_SL")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_He_Thong")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_He_Thong")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Nam", -1)
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nam")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Quy", -1)
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Quy")
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Thang", -1)
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thang")
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Phan_Loai", -1)
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phan_Loai")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Phan_Loai")
        Me.lblCN56 = New System.Windows.Forms.Label
        Me.btnPrint = New Infragistics.Win.Misc.UltraButton
        Me.btnLoad = New Infragistics.Win.Misc.UltraButton
        Me.chkMa_Bc_Khai_Thac = New System.Windows.Forms.CheckBox
        Me.chkNuoc_Thanh_Toan = New System.Windows.Forms.CheckBox
        Me.btnThoat = New Infragistics.Win.Misc.UltraButton
        Me.gridCN55 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.cb_Nam = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cb_Quy = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cb_Thang = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.opt_Nam = New System.Windows.Forms.RadioButton
        Me.opt_Quy = New System.Windows.Forms.RadioButton
        Me.opt_Thang = New System.Windows.Forms.RadioButton
        Me.group_Thoi_Gian = New Infragistics.Win.Misc.UltraGroupBox
        Me.group_Vi_Tri = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.chk_Duong_Thu = New System.Windows.Forms.CheckBox
        Me.cb_Ma_Bc_Khai_Thac = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cb_Ma_Nuoc = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cb_Duong_Thu = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cb_Phan_Loai = New Infragistics.Win.UltraWinGrid.UltraCombo
        CType(Me.gridCN55, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_Nam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_Quy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_Thang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.group_Thoi_Gian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_Thoi_Gian.SuspendLayout()
        CType(Me.group_Vi_Tri, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_Vi_Tri.SuspendLayout()
        CType(Me.cb_Ma_Bc_Khai_Thac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_Ma_Nuoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_Duong_Thu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_Phan_Loai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCN56
        '
        Me.lblCN56.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCN56.Location = New System.Drawing.Point(528, 548)
        Me.lblCN56.Name = "lblCN56"
        Me.lblCN56.Size = New System.Drawing.Size(256, 14)
        Me.lblCN56.TabIndex = 31
        Me.lblCN56.Text = "0 / 0"
        Me.lblCN56.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnPrint
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.btnPrint.Appearance = Appearance1
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(424, 96)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(88, 32)
        Me.btnPrint.TabIndex = 28
        Me.btnPrint.Text = "In CN55"
        '
        'btnLoad
        '
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.btnLoad.Appearance = Appearance2
        Me.btnLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(216, 96)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(88, 32)
        Me.btnLoad.TabIndex = 27
        Me.btnLoad.Text = "Load"
        '
        'chkMa_Bc_Khai_Thac
        '
        Me.chkMa_Bc_Khai_Thac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMa_Bc_Khai_Thac.Location = New System.Drawing.Point(160, 16)
        Me.chkMa_Bc_Khai_Thac.Name = "chkMa_Bc_Khai_Thac"
        Me.chkMa_Bc_Khai_Thac.Size = New System.Drawing.Size(120, 16)
        Me.chkMa_Bc_Khai_Thac.TabIndex = 24
        Me.chkMa_Bc_Khai_Thac.Text = "Mã Bc Khai thác"
        '
        'chkNuoc_Thanh_Toan
        '
        Me.chkNuoc_Thanh_Toan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNuoc_Thanh_Toan.Location = New System.Drawing.Point(296, 16)
        Me.chkNuoc_Thanh_Toan.Name = "chkNuoc_Thanh_Toan"
        Me.chkNuoc_Thanh_Toan.Size = New System.Drawing.Size(85, 16)
        Me.chkNuoc_Thanh_Toan.TabIndex = 22
        Me.chkNuoc_Thanh_Toan.Text = "Mã nước"
        '
        'btnThoat
        '
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        Me.btnThoat.Appearance = Appearance3
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Location = New System.Drawing.Point(640, 96)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(88, 32)
        Me.btnThoat.TabIndex = 29
        Me.btnThoat.Text = "Th&oát"
        '
        'gridCN55
        '
        Me.gridCN55.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.gridCN55.DisplayLayout.AddNewBox.Prompt = " "
        Appearance4.BackColor = System.Drawing.Color.White
        Appearance4.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.gridCN55.DisplayLayout.Appearance = Appearance4
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn1.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn1.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn1.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn2.Header.Caption = "Tháng"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn2.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(45, 0)
        UltraGridColumn2.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn2.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn3.Header.Caption = "Quý"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn3.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(45, 0)
        UltraGridColumn3.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn3.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn4.Header.Caption = "Năm"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn4.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(44, 0)
        UltraGridColumn4.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn4.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridColumn5.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn5.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn5.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn5.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn6.Header.Caption = "Mã đường thư"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn6.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn6.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn6.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn6.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn7.Header.Caption = "Mã nước"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn7.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn7.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(56, 0)
        UltraGridColumn7.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn7.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn8.Header.Caption = "Mã bưu cục"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn8.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn8.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(71, 0)
        UltraGridColumn8.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn8.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn9.Header.Caption = "Mã IMPC"
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn9.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn9.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(54, 0)
        UltraGridColumn9.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn9.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn10.Header.Caption = "Đơn vị"
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Hidden = True
        UltraGridColumn10.RowLayoutColumnInfo.OriginX = 30
        UltraGridColumn10.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn10.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn10.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn11.Header.Caption = "Nước gửi"
        UltraGridColumn11.Header.VisiblePosition = 11
        UltraGridColumn11.Hidden = True
        UltraGridColumn11.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn11.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn11.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(55, 0)
        UltraGridColumn11.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn11.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn12.Header.Caption = "Bc gửi"
        UltraGridColumn12.Header.VisiblePosition = 13
        UltraGridColumn12.Hidden = True
        UltraGridColumn12.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn12.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn12.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn12.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn13.Header.Caption = "Nước nhận"
        UltraGridColumn13.Header.VisiblePosition = 14
        UltraGridColumn13.Hidden = True
        UltraGridColumn13.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn13.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn13.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn13.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn14.Header.Caption = "Bc nhận"
        UltraGridColumn14.Header.VisiblePosition = 15
        UltraGridColumn14.Hidden = True
        UltraGridColumn14.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn14.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn14.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn14.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn15.Header.Caption = "Tổng CT"
        UltraGridColumn15.Header.VisiblePosition = 16
        UltraGridColumn15.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn15.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn15.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(57, 0)
        UltraGridColumn15.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn15.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn16.Header.Caption = "Tổng số D"
        UltraGridColumn16.Header.VisiblePosition = 17
        UltraGridColumn16.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn16.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn16.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(65, 0)
        UltraGridColumn16.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn16.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn17.Header.Caption = "Khối lượng D"
        UltraGridColumn17.Header.VisiblePosition = 18
        UltraGridColumn17.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn17.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn17.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(74, 0)
        UltraGridColumn17.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn17.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn18.Header.Caption = "Tổng số M"
        UltraGridColumn18.Header.VisiblePosition = 19
        UltraGridColumn18.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn18.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn18.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(68, 0)
        UltraGridColumn18.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn18.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn19.Header.Caption = "Khối lượng M"
        UltraGridColumn19.Header.VisiblePosition = 20
        UltraGridColumn19.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn19.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn19.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(77, 0)
        UltraGridColumn19.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn19.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn20.Header.Caption = "Tổng số R"
        UltraGridColumn20.Header.VisiblePosition = 21
        UltraGridColumn20.RowLayoutColumnInfo.OriginX = 24
        UltraGridColumn20.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn20.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(64, 0)
        UltraGridColumn20.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn20.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn21.Header.Caption = "Khối lượng R"
        UltraGridColumn21.Header.VisiblePosition = 22
        UltraGridColumn21.RowLayoutColumnInfo.OriginX = 26
        UltraGridColumn21.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn21.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(73, 0)
        UltraGridColumn21.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn21.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn22.Header.Caption = "Tổng số OPS"
        UltraGridColumn22.Header.VisiblePosition = 23
        UltraGridColumn22.RowLayoutColumnInfo.OriginX = 28
        UltraGridColumn22.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn22.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(76, 0)
        UltraGridColumn22.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn22.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn23.Header.Caption = "Khối lượng OPS"
        UltraGridColumn23.Header.VisiblePosition = 24
        UltraGridColumn23.RowLayoutColumnInfo.OriginX = 30
        UltraGridColumn23.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn23.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(84, 0)
        UltraGridColumn23.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn23.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn24.Header.Caption = "KL vỏ túi"
        UltraGridColumn24.Header.VisiblePosition = 25
        UltraGridColumn24.Hidden = True
        UltraGridColumn24.RowLayoutColumnInfo.OriginX = 50
        UltraGridColumn24.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn24.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn24.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn25.Header.Caption = "Cước theo SL"
        UltraGridColumn25.Header.VisiblePosition = 26
        UltraGridColumn25.RowLayoutColumnInfo.OriginX = 32
        UltraGridColumn25.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn25.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(80, 0)
        UltraGridColumn25.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn25.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn26.Header.Caption = "Cước theo KL"
        UltraGridColumn26.Header.VisiblePosition = 27
        UltraGridColumn26.RowLayoutColumnInfo.OriginX = 34
        UltraGridColumn26.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn26.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(76, 0)
        UltraGridColumn26.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn26.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn27.Header.Caption = "Cước VCMBND"
        UltraGridColumn27.Header.VisiblePosition = 28
        UltraGridColumn27.RowLayoutColumnInfo.OriginX = 36
        UltraGridColumn27.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn27.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(83, 0)
        UltraGridColumn27.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn27.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn28.Header.Caption = "Cước HK"
        UltraGridColumn28.Header.VisiblePosition = 29
        UltraGridColumn28.RowLayoutColumnInfo.OriginX = 38
        UltraGridColumn28.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn28.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(60, 0)
        UltraGridColumn28.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn28.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn29.Header.VisiblePosition = 30
        UltraGridColumn29.Hidden = True
        UltraGridColumn29.RowLayoutColumnInfo.OriginX = 60
        UltraGridColumn29.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn29.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn29.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn30.Header.Caption = "Mã tiền tệ"
        UltraGridColumn30.Header.VisiblePosition = 12
        UltraGridColumn30.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn30.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn30.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(62, 0)
        UltraGridColumn30.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn30.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn31.Header.Caption = "Cước D"
        UltraGridColumn31.Header.VisiblePosition = 31
        UltraGridColumn31.Hidden = True
        UltraGridColumn31.RowLayoutColumnInfo.OriginX = 42
        UltraGridColumn31.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn31.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn31.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn32.Header.Caption = "Cước M"
        UltraGridColumn32.Header.VisiblePosition = 32
        UltraGridColumn32.Hidden = True
        UltraGridColumn32.RowLayoutColumnInfo.OriginX = 44
        UltraGridColumn32.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn32.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn32.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn33.Header.Caption = "Tổng cước"
        UltraGridColumn33.Header.VisiblePosition = 33
        UltraGridColumn33.RowLayoutColumnInfo.OriginX = 40
        UltraGridColumn33.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn33.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(70, 0)
        UltraGridColumn33.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn33.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn34.Header.Caption = "Tổng cước VNĐ"
        UltraGridColumn34.Header.VisiblePosition = 34
        UltraGridColumn34.RowLayoutColumnInfo.OriginX = 42
        UltraGridColumn34.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn34.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(90, 0)
        UltraGridColumn34.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn34.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn35.Header.Caption = "HVC"
        UltraGridColumn35.Header.VisiblePosition = 35
        UltraGridColumn35.RowLayoutColumnInfo.OriginX = 44
        UltraGridColumn35.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn35.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn35.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn36.Header.Caption = "Ghi chú"
        UltraGridColumn36.Header.VisiblePosition = 10
        UltraGridColumn36.Hidden = True
        UltraGridColumn36.RowLayoutColumnInfo.OriginX = 32
        UltraGridColumn36.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn36.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn36.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn37.Header.VisiblePosition = 36
        UltraGridColumn37.Hidden = True
        UltraGridColumn37.RowLayoutColumnInfo.OriginX = 72
        UltraGridColumn37.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn37.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn37.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn38.Header.VisiblePosition = 37
        UltraGridColumn38.Hidden = True
        UltraGridColumn38.RowLayoutColumnInfo.OriginX = 74
        UltraGridColumn38.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn38.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn38.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn39.Header.VisiblePosition = 38
        UltraGridColumn39.Hidden = True
        UltraGridColumn39.RowLayoutColumnInfo.OriginX = 76
        UltraGridColumn39.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn39.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn39.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn40.Header.VisiblePosition = 39
        UltraGridColumn40.Hidden = True
        UltraGridColumn40.RowLayoutColumnInfo.OriginX = 78
        UltraGridColumn40.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn40.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn40.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40})
        UltraGridBand1.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand1.UseRowLayout = True
        Me.gridCN55.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.gridCN55.DisplayLayout.InterBandSpacing = 10
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Me.gridCN55.DisplayLayout.Override.CardAreaAppearance = Appearance5
        Me.gridCN55.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance6.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance6.ForeColor = System.Drawing.Color.Black
        Appearance6.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.gridCN55.DisplayLayout.Override.HeaderAppearance = Appearance6
        Me.gridCN55.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance7.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.gridCN55.DisplayLayout.Override.RowAppearance = Appearance7
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance8.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.gridCN55.DisplayLayout.Override.RowSelectorAppearance = Appearance8
        Me.gridCN55.DisplayLayout.Override.RowSelectorWidth = 12
        Me.gridCN55.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance9.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance9.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance9.ForeColor = System.Drawing.Color.Black
        Me.gridCN55.DisplayLayout.Override.SelectedRowAppearance = Appearance9
        Me.gridCN55.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.gridCN55.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.gridCN55.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridCN55.Location = New System.Drawing.Point(0, 136)
        Me.gridCN55.Name = "gridCN55"
        Me.gridCN55.Size = New System.Drawing.Size(792, 400)
        Me.gridCN55.TabIndex = 30
        Me.gridCN55.Text = "CN55"
        '
        'cb_Nam
        '
        Me.cb_Nam.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn41.Header.Caption = "Năm"
        UltraGridColumn41.Header.VisiblePosition = 0
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn41})
        Me.cb_Nam.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.cb_Nam.DisplayMember = ""
        Me.cb_Nam.Location = New System.Drawing.Point(80, 80)
        Me.cb_Nam.Name = "cb_Nam"
        Me.cb_Nam.Size = New System.Drawing.Size(96, 21)
        Me.cb_Nam.TabIndex = 74
        Me.cb_Nam.ValueMember = ""
        '
        'cb_Quy
        '
        Me.cb_Quy.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn42.Header.Caption = "Quý"
        UltraGridColumn42.Header.VisiblePosition = 0
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn42})
        Me.cb_Quy.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.cb_Quy.DisplayMember = ""
        Me.cb_Quy.Location = New System.Drawing.Point(80, 48)
        Me.cb_Quy.Name = "cb_Quy"
        Me.cb_Quy.Size = New System.Drawing.Size(96, 21)
        Me.cb_Quy.TabIndex = 73
        Me.cb_Quy.ValueMember = ""
        '
        'cb_Thang
        '
        Me.cb_Thang.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn43.Header.Caption = "Tháng"
        UltraGridColumn43.Header.VisiblePosition = 0
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn43})
        Me.cb_Thang.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.cb_Thang.DisplayMember = ""
        Me.cb_Thang.Location = New System.Drawing.Point(80, 16)
        Me.cb_Thang.Name = "cb_Thang"
        Me.cb_Thang.Size = New System.Drawing.Size(96, 21)
        Me.cb_Thang.TabIndex = 72
        Me.cb_Thang.ValueMember = ""
        '
        'opt_Nam
        '
        Me.opt_Nam.Location = New System.Drawing.Point(8, 80)
        Me.opt_Nam.Name = "opt_Nam"
        Me.opt_Nam.Size = New System.Drawing.Size(64, 24)
        Me.opt_Nam.TabIndex = 71
        Me.opt_Nam.Text = "Năm"
        '
        'opt_Quy
        '
        Me.opt_Quy.Location = New System.Drawing.Point(8, 48)
        Me.opt_Quy.Name = "opt_Quy"
        Me.opt_Quy.Size = New System.Drawing.Size(64, 24)
        Me.opt_Quy.TabIndex = 70
        Me.opt_Quy.Text = "Quý"
        '
        'opt_Thang
        '
        Me.opt_Thang.Location = New System.Drawing.Point(8, 16)
        Me.opt_Thang.Name = "opt_Thang"
        Me.opt_Thang.Size = New System.Drawing.Size(64, 24)
        Me.opt_Thang.TabIndex = 69
        Me.opt_Thang.Text = "Tháng"
        '
        'group_Thoi_Gian
        '
        Me.group_Thoi_Gian.Controls.Add(Me.opt_Thang)
        Me.group_Thoi_Gian.Controls.Add(Me.opt_Quy)
        Me.group_Thoi_Gian.Controls.Add(Me.opt_Nam)
        Me.group_Thoi_Gian.Controls.Add(Me.cb_Thang)
        Me.group_Thoi_Gian.Controls.Add(Me.cb_Quy)
        Me.group_Thoi_Gian.Controls.Add(Me.cb_Nam)
        Me.group_Thoi_Gian.Location = New System.Drawing.Point(16, 16)
        Me.group_Thoi_Gian.Name = "group_Thoi_Gian"
        Me.group_Thoi_Gian.Size = New System.Drawing.Size(184, 112)
        Me.group_Thoi_Gian.SupportThemes = False
        Me.group_Thoi_Gian.TabIndex = 75
        Me.group_Thoi_Gian.Text = "Thời gian"
        '
        'group_Vi_Tri
        '
        Me.group_Vi_Tri.Controls.Add(Me.cb_Phan_Loai)
        Me.group_Vi_Tri.Controls.Add(Me.cb_Duong_Thu)
        Me.group_Vi_Tri.Controls.Add(Me.cb_Ma_Nuoc)
        Me.group_Vi_Tri.Controls.Add(Me.UltraLabel1)
        Me.group_Vi_Tri.Controls.Add(Me.chk_Duong_Thu)
        Me.group_Vi_Tri.Controls.Add(Me.chkMa_Bc_Khai_Thac)
        Me.group_Vi_Tri.Controls.Add(Me.chkNuoc_Thanh_Toan)
        Me.group_Vi_Tri.Controls.Add(Me.cb_Ma_Bc_Khai_Thac)
        Me.group_Vi_Tri.Location = New System.Drawing.Point(208, 16)
        Me.group_Vi_Tri.Name = "group_Vi_Tri"
        Me.group_Vi_Tri.Size = New System.Drawing.Size(568, 72)
        Me.group_Vi_Tri.SupportThemes = False
        Me.group_Vi_Tri.TabIndex = 76
        Me.group_Vi_Tri.Text = "Vị trí"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(8, 24)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(112, 16)
        Me.UltraLabel1.TabIndex = 30
        Me.UltraLabel1.Text = "Phân Loại"
        '
        'chk_Duong_Thu
        '
        Me.chk_Duong_Thu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Duong_Thu.Location = New System.Drawing.Point(416, 16)
        Me.chk_Duong_Thu.Name = "chk_Duong_Thu"
        Me.chk_Duong_Thu.Size = New System.Drawing.Size(85, 16)
        Me.chk_Duong_Thu.TabIndex = 26
        Me.chk_Duong_Thu.Text = "Đường Thư"
        '
        'cb_Ma_Bc_Khai_Thac
        '
        Me.cb_Ma_Bc_Khai_Thac.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cb_Ma_Bc_Khai_Thac.DisplayMember = ""
        Me.cb_Ma_Bc_Khai_Thac.Location = New System.Drawing.Point(160, 40)
        Me.cb_Ma_Bc_Khai_Thac.Name = "cb_Ma_Bc_Khai_Thac"
        Me.cb_Ma_Bc_Khai_Thac.Size = New System.Drawing.Size(108, 21)
        Me.cb_Ma_Bc_Khai_Thac.TabIndex = 77
        Me.cb_Ma_Bc_Khai_Thac.ValueMember = ""
        '
        'cb_Ma_Nuoc
        '
        Me.cb_Ma_Nuoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cb_Ma_Nuoc.DisplayMember = ""
        Me.cb_Ma_Nuoc.Location = New System.Drawing.Point(296, 40)
        Me.cb_Ma_Nuoc.Name = "cb_Ma_Nuoc"
        Me.cb_Ma_Nuoc.Size = New System.Drawing.Size(108, 21)
        Me.cb_Ma_Nuoc.TabIndex = 78
        Me.cb_Ma_Nuoc.ValueMember = ""
        '
        'cb_Duong_Thu
        '
        Me.cb_Duong_Thu.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cb_Duong_Thu.DisplayMember = ""
        Me.cb_Duong_Thu.Location = New System.Drawing.Point(416, 40)
        Me.cb_Duong_Thu.Name = "cb_Duong_Thu"
        Me.cb_Duong_Thu.Size = New System.Drawing.Size(108, 21)
        Me.cb_Duong_Thu.TabIndex = 79
        Me.cb_Duong_Thu.ValueMember = ""
        '
        'cb_Phan_Loai
        '
        Me.cb_Phan_Loai.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cb_Phan_Loai.DataMember = Nothing
        UltraGridColumn44.Header.Caption = "Phân Loại"
        UltraGridColumn44.Header.VisiblePosition = 0
        UltraGridColumn45.Header.Caption = "Tên Phân Loại"
        UltraGridColumn45.Header.VisiblePosition = 1
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn44, UltraGridColumn45})
        Me.cb_Phan_Loai.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.cb_Phan_Loai.DisplayMember = "Ten_Phan_Loai"
        Me.cb_Phan_Loai.Location = New System.Drawing.Point(8, 40)
        Me.cb_Phan_Loai.Name = "cb_Phan_Loai"
        Me.cb_Phan_Loai.Size = New System.Drawing.Size(108, 21)
        Me.cb_Phan_Loai.TabIndex = 80
        Me.cb_Phan_Loai.ValueMember = "Phan_Loai"
        '
        'Frm_Chinh_Sua_CN55
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.group_Vi_Tri)
        Me.Controls.Add(Me.group_Thoi_Gian)
        Me.Controls.Add(Me.lblCN56)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.gridCN55)
        Me.Name = "Frm_Chinh_Sua_CN55"
        Me.Text = "Chỉnh sửa CN55"
        CType(Me.gridCN55, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_Nam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_Quy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_Thang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.group_Thoi_Gian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_Thoi_Gian.ResumeLayout(False)
        CType(Me.group_Vi_Tri, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_Vi_Tri.ResumeLayout(False)
        CType(Me.cb_Ma_Bc_Khai_Thac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_Ma_Nuoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_Duong_Thu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_Phan_Loai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim myHam_Dung_Chung As New Ham_Dung_Chung

    Private Function LoadForm() As Boolean
        Try
            'Thời gian
            Tao_Bang_Thang()
            Tao_Bang_Quy()
            Tao_Bang_Nam()
            'Loại báo cáo
            Tao_Bang_Phan_Loai()
            'Lựa chọn báo cáo

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        End Try
    End Function

    Private Sub Tao_Bang_Thang()
        Dim dataTable As New dataTable

        Dim colWork As DataColumn = New DataColumn("Thang", GetType(Integer))
        dataTable.Columns.Add(colWork)

        Dim row As DataRow = dataTable.NewRow()
        row("Thang") = 1
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Thang") = 2
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Thang") = 3
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Thang") = 4
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Thang") = 5
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Thang") = 6
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Thang") = 7
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Thang") = 8
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Thang") = 9
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Thang") = 10
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Thang") = 11
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Thang") = 12
        dataTable.Rows.Add(row)

        cb_Thang.DataSource = dataTable
        cb_Thang.DataBind()

        cb_Thang.Value = getMonthFromDate(myHam_Dung_Chung.ConvertDateToInt(Today))
        cb_Thang.Text = getMonthFromDate(myHam_Dung_Chung.ConvertDateToInt(Today))
    End Sub

    Private Sub Tao_Bang_Quy()
        Dim dataTable As New dataTable

        Dim colWork As DataColumn = New DataColumn("Quy", GetType(Integer))
        dataTable.Columns.Add(colWork)

        Dim row As DataRow = dataTable.NewRow()
        row("Quy") = 1
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Quy") = 2
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Quy") = 3
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Quy") = 4
        dataTable.Rows.Add(row)

        cb_Quy.DataSource = dataTable
        cb_Quy.DataBind()

        cb_Quy.Value = getQuarterFromDate(myHam_Dung_Chung.ConvertDateToInt(Today))
        cb_Quy.Text = getQuarterFromDate(myHam_Dung_Chung.ConvertDateToInt(Today))
    End Sub

    Private Sub Tao_Bang_Nam()
        Dim dataTable As New dataTable

        Dim colWork As DataColumn = New DataColumn("Nam", GetType(Integer))
        dataTable.Columns.Add(colWork)

        Dim row As DataRow = dataTable.NewRow()
        row("Nam") = 2009
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Nam") = 2010
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Nam") = 2011
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Nam") = 2012
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Nam") = 2013
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Nam") = 2014
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Nam") = 2015
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Nam") = 2016
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Nam") = 2017
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Nam") = 2018
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Nam") = 2019
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Nam") = 2020
        dataTable.Rows.Add(row)

        cb_Nam.DataSource = dataTable
        cb_Nam.DataBind()

        cb_Nam.Value = getYearFromDate(myHam_Dung_Chung.ConvertDateToInt(Today))
        cb_Nam.Text = getYearFromDate(myHam_Dung_Chung.ConvertDateToInt(Today))
    End Sub

    Private Sub Tao_Bang_Phan_Loai()
        Dim dataTable As New dataTable

        Dim colWork As DataColumn = New DataColumn("Phan_Loai", GetType(Integer))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Ten_Phan_Loai", GetType(String))
        dataTable.Columns.Add(colWork)

        Dim row As DataRow = dataTable.NewRow()
        row("Phan_Loai") = 1
        row("Ten_Phan_Loai") = "Quốc Tế Đến"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Phan_Loai") = 2
        row("Ten_Phan_Loai") = "Quốc Tế Đi"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Phan_Loai") = 3
        row("Ten_Phan_Loai") = "Quá Giang"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Phan_Loai") = 4
        row("Ten_Phan_Loai") = "Hàng Không"
        dataTable.Rows.Add(row)

        cb_Phan_Loai.DataSource = dataTable
        cb_Phan_Loai.DataBind()

        cb_Phan_Loai.Value = 1
        cb_Phan_Loai.Text = "Quốc Tế Đến"
    End Sub

    Private Sub LoadData()
        'Load Ma_Bc_Khai_Thac

        'Load Mã Nước

        'Load Đường Thư
    End Sub

    Private Sub Load_Ma_Nuoc(ByVal Phan_Loai As Integer, ByVal Ma_Bc_Khai_Thac As Integer)

    End Sub

    Private Sub Load_Duong_Thu(ByVal Phan_Loai As Integer, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Nuoc As String)

    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

    End Sub

    Private Function OpenReport(ByVal Loai_Bao_Cao As Integer, ByVal Preview As Boolean, ByVal So_Ban As Integer)

    End Function

    Private Sub gridCN55_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles gridCN55.InitializeLayout

    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        Try

            EnableControl(True)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            EnableControl(False)
        End Try
    End Sub

    Private Sub EnableControl(ByVal OpenCN55 As Boolean)
        group_Thoi_Gian.Enabled = Not OpenCN55
        group_Vi_Tri.Enabled = Not OpenCN55
        If OpenCN55 Then
            btnLoad.Text = "UnLoad"
        Else
            btnLoad.Text = "Load"
        End If
    End Sub
End Class

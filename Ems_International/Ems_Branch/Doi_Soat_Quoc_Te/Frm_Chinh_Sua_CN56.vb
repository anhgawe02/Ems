Public Class Frm_Chinh_Sua_CN56
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
    Friend WithEvents dgCN56 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents nYEAR As System.Windows.Forms.NumericUpDown
    Friend WithEvents nMonth As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbMa_Nuoc As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents optThang As System.Windows.Forms.RadioButton
    Friend WithEvents optQuy As System.Windows.Forms.RadioButton
    Friend WithEvents chkNuoc_Thanh_Toan As System.Windows.Forms.CheckBox
    Friend WithEvents chkMa_Bc_Khai_Thac As System.Windows.Forms.CheckBox
    Friend WithEvents btnThong_Tin As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnIn As Infragistics.Win.Misc.UltraButton
    Friend WithEvents GrpThietLapThamSo As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents chkNam As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkQuy As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkThang As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents nQuater As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbMa_Bc_Khai_Thac As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents btnThoat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents lblCN56 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
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
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_Chinh_Sua_CN56))
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.dgCN56 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.nYEAR = New System.Windows.Forms.NumericUpDown
        Me.nMonth = New System.Windows.Forms.NumericUpDown
        Me.nQuater = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbMa_Nuoc = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.btnThoat = New Infragistics.Win.Misc.UltraButton
        Me.optThang = New System.Windows.Forms.RadioButton
        Me.optQuy = New System.Windows.Forms.RadioButton
        Me.chkNuoc_Thanh_Toan = New System.Windows.Forms.CheckBox
        Me.cbMa_Bc_Khai_Thac = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.chkMa_Bc_Khai_Thac = New System.Windows.Forms.CheckBox
        Me.btnThong_Tin = New Infragistics.Win.Misc.UltraButton
        Me.btnIn = New Infragistics.Win.Misc.UltraButton
        Me.GrpThietLapThamSo = New Infragistics.Win.Misc.UltraExpandableGroupBox
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
        Me.chkThang = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkQuy = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkNam = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.lblCN56 = New System.Windows.Forms.Label
        CType(Me.dgCN56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nYEAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nQuater, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMa_Nuoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMa_Bc_Khai_Thac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrpThietLapThamSo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpThietLapThamSo.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgCN56
        '
        Me.dgCN56.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.dgCN56.DisplayLayout.AddNewBox.Prompt = " "
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgCN56.DisplayLayout.Appearance = Appearance1
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
        Me.dgCN56.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.dgCN56.DisplayLayout.InterBandSpacing = 10
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.dgCN56.DisplayLayout.Override.CardAreaAppearance = Appearance2
        Me.dgCN56.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.ForeColor = System.Drawing.Color.Black
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgCN56.DisplayLayout.Override.HeaderAppearance = Appearance3
        Me.dgCN56.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance4.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgCN56.DisplayLayout.Override.RowAppearance = Appearance4
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgCN56.DisplayLayout.Override.RowSelectorAppearance = Appearance5
        Me.dgCN56.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgCN56.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance6.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.dgCN56.DisplayLayout.Override.SelectedRowAppearance = Appearance6
        Me.dgCN56.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgCN56.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgCN56.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgCN56.Location = New System.Drawing.Point(0, 64)
        Me.dgCN56.Name = "dgCN56"
        Me.dgCN56.Size = New System.Drawing.Size(792, 480)
        Me.dgCN56.TabIndex = 14
        Me.dgCN56.Text = "Danh mục CN56"
        '
        'nYEAR
        '
        Me.nYEAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nYEAR.Location = New System.Drawing.Point(3, 32)
        Me.nYEAR.Maximum = New Decimal(New Integer() {2020, 0, 0, 0})
        Me.nYEAR.Minimum = New Decimal(New Integer() {2008, 0, 0, 0})
        Me.nYEAR.Name = "nYEAR"
        Me.nYEAR.Size = New System.Drawing.Size(56, 21)
        Me.nYEAR.TabIndex = 1
        Me.nYEAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nYEAR.Value = New Decimal(New Integer() {2008, 0, 0, 0})
        '
        'nMonth
        '
        Me.nMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nMonth.Location = New System.Drawing.Point(63, 32)
        Me.nMonth.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nMonth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nMonth.Name = "nMonth"
        Me.nMonth.Size = New System.Drawing.Size(64, 21)
        Me.nMonth.TabIndex = 3
        Me.nMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nMonth.Value = New Decimal(New Integer() {12, 0, 0, 0})
        '
        'nQuater
        '
        Me.nQuater.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nQuater.Location = New System.Drawing.Point(131, 32)
        Me.nQuater.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.nQuater.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nQuater.Name = "nQuater"
        Me.nQuater.Size = New System.Drawing.Size(48, 21)
        Me.nQuater.TabIndex = 5
        Me.nQuater.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nQuater.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Năm"
        '
        'cbMa_Nuoc
        '
        Me.cbMa_Nuoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMa_Nuoc.Location = New System.Drawing.Point(183, 31)
        Me.cbMa_Nuoc.Name = "cbMa_Nuoc"
        Me.cbMa_Nuoc.Size = New System.Drawing.Size(101, 23)
        Me.cbMa_Nuoc.TabIndex = 7
        '
        'btnThoat
        '
        Appearance7.Image = CType(resources.GetObject("Appearance7.Image"), Object)
        Me.btnThoat.Appearance = Appearance7
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Location = New System.Drawing.Point(712, 21)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(80, 32)
        Me.btnThoat.TabIndex = 13
        Me.btnThoat.Text = "Th&oát"
        '
        'optThang
        '
        Me.optThang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optThang.Location = New System.Drawing.Point(63, 8)
        Me.optThang.Name = "optThang"
        Me.optThang.Size = New System.Drawing.Size(64, 24)
        Me.optThang.TabIndex = 2
        Me.optThang.Text = "Tháng"
        '
        'optQuy
        '
        Me.optQuy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optQuy.Location = New System.Drawing.Point(131, 8)
        Me.optQuy.Name = "optQuy"
        Me.optQuy.Size = New System.Drawing.Size(48, 24)
        Me.optQuy.TabIndex = 4
        Me.optQuy.Text = "Quý"
        '
        'chkNuoc_Thanh_Toan
        '
        Me.chkNuoc_Thanh_Toan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNuoc_Thanh_Toan.Location = New System.Drawing.Point(183, 12)
        Me.chkNuoc_Thanh_Toan.Name = "chkNuoc_Thanh_Toan"
        Me.chkNuoc_Thanh_Toan.Size = New System.Drawing.Size(85, 16)
        Me.chkNuoc_Thanh_Toan.TabIndex = 6
        Me.chkNuoc_Thanh_Toan.Text = "Mã nước"
        '
        'cbMa_Bc_Khai_Thac
        '
        Me.cbMa_Bc_Khai_Thac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMa_Bc_Khai_Thac.Location = New System.Drawing.Point(289, 30)
        Me.cbMa_Bc_Khai_Thac.Name = "cbMa_Bc_Khai_Thac"
        Me.cbMa_Bc_Khai_Thac.Size = New System.Drawing.Size(112, 23)
        Me.cbMa_Bc_Khai_Thac.TabIndex = 9
        '
        'chkMa_Bc_Khai_Thac
        '
        Me.chkMa_Bc_Khai_Thac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMa_Bc_Khai_Thac.Location = New System.Drawing.Point(289, 12)
        Me.chkMa_Bc_Khai_Thac.Name = "chkMa_Bc_Khai_Thac"
        Me.chkMa_Bc_Khai_Thac.Size = New System.Drawing.Size(120, 16)
        Me.chkMa_Bc_Khai_Thac.TabIndex = 8
        Me.chkMa_Bc_Khai_Thac.Text = "Mã Bc Khai thác"
        '
        'btnThong_Tin
        '
        Appearance8.Image = CType(resources.GetObject("Appearance8.Image"), Object)
        Me.btnThong_Tin.Appearance = Appearance8
        Me.btnThong_Tin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThong_Tin.Location = New System.Drawing.Point(544, 21)
        Me.btnThong_Tin.Name = "btnThong_Tin"
        Me.btnThong_Tin.Size = New System.Drawing.Size(88, 32)
        Me.btnThong_Tin.TabIndex = 11
        Me.btnThong_Tin.Text = "Thông tin"
        '
        'btnIn
        '
        Appearance9.Image = CType(resources.GetObject("Appearance9.Image"), Object)
        Me.btnIn.Appearance = Appearance9
        Me.btnIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIn.Location = New System.Drawing.Point(632, 21)
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(80, 32)
        Me.btnIn.TabIndex = 12
        Me.btnIn.Text = "In CN56"
        '
        'GrpThietLapThamSo
        '
        Me.GrpThietLapThamSo.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.GrpThietLapThamSo.Expanded = False
        Me.GrpThietLapThamSo.ExpandedSize = New System.Drawing.Size(128, 478)
        Me.GrpThietLapThamSo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpThietLapThamSo.Location = New System.Drawing.Point(408, 18)
        Me.GrpThietLapThamSo.Name = "GrpThietLapThamSo"
        Me.GrpThietLapThamSo.Size = New System.Drawing.Size(128, 33)
        Me.GrpThietLapThamSo.SupportThemes = False
        Me.GrpThietLapThamSo.TabIndex = 10
        Me.GrpThietLapThamSo.Text = "Thiết Lập     Tham Số"
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.chkThang)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.chkQuy)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.chkNam)
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(217, 177)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel2.Visible = False
        '
        'chkThang
        '
        Me.chkThang.Location = New System.Drawing.Point(8, 56)
        Me.chkThang.Name = "chkThang"
        Me.chkThang.Size = New System.Drawing.Size(88, 20)
        Me.chkThang.TabIndex = 2
        Me.chkThang.Text = "Tháng"
        '
        'chkQuy
        '
        Me.chkQuy.Location = New System.Drawing.Point(8, 32)
        Me.chkQuy.Name = "chkQuy"
        Me.chkQuy.Size = New System.Drawing.Size(88, 20)
        Me.chkQuy.TabIndex = 1
        Me.chkQuy.Text = "Quý"
        '
        'chkNam
        '
        Me.chkNam.Location = New System.Drawing.Point(8, 8)
        Me.chkNam.Name = "chkNam"
        Me.chkNam.Size = New System.Drawing.Size(88, 20)
        Me.chkNam.TabIndex = 0
        Me.chkNam.Text = "Năm"
        '
        'lblCN56
        '
        Me.lblCN56.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCN56.Location = New System.Drawing.Point(528, 552)
        Me.lblCN56.Name = "lblCN56"
        Me.lblCN56.Size = New System.Drawing.Size(256, 14)
        Me.lblCN56.TabIndex = 15
        Me.lblCN56.Text = "0 / 0"
        Me.lblCN56.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Frm_Chinh_Sua_CN56
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.Add(Me.lblCN56)
        Me.Controls.Add(Me.GrpThietLapThamSo)
        Me.Controls.Add(Me.btnIn)
        Me.Controls.Add(Me.btnThong_Tin)
        Me.Controls.Add(Me.cbMa_Bc_Khai_Thac)
        Me.Controls.Add(Me.chkMa_Bc_Khai_Thac)
        Me.Controls.Add(Me.nYEAR)
        Me.Controls.Add(Me.cbMa_Nuoc)
        Me.Controls.Add(Me.nMonth)
        Me.Controls.Add(Me.chkNuoc_Thanh_Toan)
        Me.Controls.Add(Me.optQuy)
        Me.Controls.Add(Me.optThang)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nQuater)
        Me.Controls.Add(Me.dgCN56)
        Me.Name = "Frm_Chinh_Sua_CN56"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chỉnh sửa , cân đối thông tin CN56"
        CType(Me.dgCN56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nYEAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nQuater, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMa_Nuoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMa_Bc_Khai_Thac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrpThietLapThamSo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpThietLapThamSo.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Khai báo biến toàn Form"
    Dim myIsOpen As Boolean
#End Region

#Region "Tab Control"
#Region "Frm_Chinh_Sua_CN56_Load"
    Private Sub Frm_Chinh_Sua_CN56_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Refresh_Form()
    End Sub
#End Region
#Region "optThang_CheckedChanged"
    Private Sub optThang_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optThang.CheckedChanged
        nMonth.Enabled = optThang.Checked
    End Sub
#End Region
#Region "optQuy_CheckedChanged"
    Private Sub optQuy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optQuy.CheckedChanged
        nQuater.Enabled = optQuy.Checked
    End Sub
#End Region
#Region "chkMa_Bc_Khai_Thac_CheckedChanged"
    Private Sub chkMa_Bc_Khai_Thac_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMa_Bc_Khai_Thac.CheckedChanged
        cbMa_Bc_Khai_Thac.Enabled = chkMa_Bc_Khai_Thac.Checked
    End Sub
#End Region
#Region "chkNuoc_Thanh_Toan_CheckedChanged"
    Private Sub chkNuoc_Thanh_Toan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNuoc_Thanh_Toan.CheckedChanged
        cbMa_Nuoc.Enabled = chkNuoc_Thanh_Toan.Checked
    End Sub
#End Region
#Region "btnThong_Tin_Click"
    Private Sub btnThong_Tin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThong_Tin.Click
        If myIsOpen = False Then
            btnThong_Tin.Text = "&Làm lại"
        Else
            btnThong_Tin.Text = "&Thông tin"
        End If
        Enable_Control(myIsOpen)
        myIsOpen = Not myIsOpen
    End Sub
#End Region
#Region "btnIn_Click"
    Private Sub btnIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIn.Click
        If myIsOpen = True Then
            btnThong_Tin_Click(btnThong_Tin, Nothing)
        End If
        Dim Frm As New Frm_In_CN56
        Frm.ShowDialog()
    End Sub
#End Region
#Region "btnThoat_Click"
    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
        Me.Dispose()
    End Sub
#End Region
#End Region

#Region "Hàm dùng chung"
#Region "KeyEnter"
    Private Sub nYEAR_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nYEAR.KeyDown, optQuy.KeyDown, nQuater.KeyDown, optThang.KeyDown, nMonth.KeyDown, chkMa_Bc_Khai_Thac.KeyDown, cbMa_Bc_Khai_Thac.KeyDown, chkNuoc_Thanh_Toan.KeyDown, cbMa_Nuoc.KeyDown
        If e.KeyValue = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
        End If
    End Sub
#End Region
#End Region

#Region "Hàm người dùng"
#Region "Refresh_Form"
    Private Sub Refresh_Form()
        nYEAR.Value = Now.Year
        nYEAR.Select()
        optThang.Checked = True
        optThang_CheckedChanged(optThang, Nothing)
        optQuy.Checked = False
        optQuy_CheckedChanged(optQuy, Nothing)
        chkMa_Bc_Khai_Thac.Checked = False
        chkMa_Bc_Khai_Thac_CheckedChanged(chkMa_Bc_Khai_Thac, Nothing)
        chkNuoc_Thanh_Toan.Checked = False
        chkNuoc_Thanh_Toan_CheckedChanged(chkNuoc_Thanh_Toan, Nothing)
        dgCN56.Enabled = False
        lblCN56.Text = "0 / 0"
        lblCN56.Enabled = False
        myIsOpen = False
    End Sub
#End Region
#Region "Enable_Control"
    Private Sub Enable_Control(ByVal bolControl As Boolean)
        nYEAR.Enabled = bolControl
        optThang.Enabled = bolControl
        nMonth.Enabled = bolControl
        optQuy.Enabled = bolControl
        nQuater.Enabled = bolControl
        chkMa_Bc_Khai_Thac.Enabled = bolControl
        cbMa_Bc_Khai_Thac.Enabled = bolControl
        chkNuoc_Thanh_Toan.Enabled = bolControl
        cbMa_Nuoc.Enabled = bolControl
        dgCN56.Enabled = Not bolControl
        lblCN56.Enabled = Not bolControl
    End Sub
#End Region
#End Region



End Class

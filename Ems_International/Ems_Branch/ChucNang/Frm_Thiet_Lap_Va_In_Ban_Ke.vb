Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Ems_International_Logic.EMS
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Public Class Frm_Thiet_Lap_Va_In_Ban_Ke
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
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Tab_InBanKe As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents BtnExit As Infragistics.Win.Misc.UltraButton
    Friend WithEvents BtnPrint As Infragistics.Win.Misc.UltraButton
    Friend WithEvents BtnPreview As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Grid_BV2 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents cbLoai_Chuyen_Thu As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbChuyenThuDi As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbDuongThuDi As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbNgayDong As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnThem As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnXoa As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cbDot As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbChuyenBay As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraCombo1 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraCombo2 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraCombo3 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraDateTimeEditor1 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Group_Lua_Chon As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraCheckEditor1 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraTextEditor1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTextEditor2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraCheckEditor2 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraTextEditor3 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraCheckEditor3 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraTextEditor4 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraCheckEditor4 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraCombo4 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraCombo5 As Infragistics.Win.UltraWinGrid.UltraCombo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Dot_Bay", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dot")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("LoaiChuyenThuDi", -1)
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Loai")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Loai")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ChuyenThuDi", -1)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chuyen_Thu")
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("DuongThuDi", -1)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Duong_Thu")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Phan_Loai")
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_Thiet_Lap_Va_In_Ban_Ke))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("LoaiChuyenThuDi", -1)
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Loai")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Loai")
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ChuyenThuDi", -1)
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chuyen_Thu")
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("DuongThuDi", -1)
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Duong_Thu")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Phan_Loai")
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Dot_Bay", -1)
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dot")
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.cbDot = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cbChuyenBay = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.btnXoa = New Infragistics.Win.Misc.UltraButton
        Me.btnThem = New Infragistics.Win.Misc.UltraButton
        Me.cbLoai_Chuyen_Thu = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel
        Me.cbChuyenThuDi = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cbDuongThuDi = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.cbNgayDong = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.Grid_BV2 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.Tab_InBanKe = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.BtnExit = New Infragistics.Win.Misc.UltraButton
        Me.BtnPrint = New Infragistics.Win.Misc.UltraButton
        Me.BtnPreview = New Infragistics.Win.Misc.UltraButton
        Me.UltraCombo1 = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraCombo2 = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraCombo3 = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraDateTimeEditor1 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel
        Me.Group_Lua_Chon = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraCheckEditor1 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.UltraTextEditor1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraTextEditor2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraCheckEditor2 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.UltraTextEditor3 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraCheckEditor3 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.UltraTextEditor4 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraCheckEditor4 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraCombo4 = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraCombo5 = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.cbDot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbChuyenBay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbLoai_Chuyen_Thu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbChuyenThuDi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDuongThuDi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbNgayDong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid_BV2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.Tab_InBanKe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_InBanKe.SuspendLayout()
        CType(Me.UltraCombo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraCombo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraCombo3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDateTimeEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group_Lua_Chon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group_Lua_Chon.SuspendLayout()
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraCombo4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraCombo5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel5)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel2)
        Me.UltraTabPageControl1.Controls.Add(Me.cbDot)
        Me.UltraTabPageControl1.Controls.Add(Me.cbChuyenBay)
        Me.UltraTabPageControl1.Controls.Add(Me.btnXoa)
        Me.UltraTabPageControl1.Controls.Add(Me.btnThem)
        Me.UltraTabPageControl1.Controls.Add(Me.cbLoai_Chuyen_Thu)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel9)
        Me.UltraTabPageControl1.Controls.Add(Me.cbChuyenThuDi)
        Me.UltraTabPageControl1.Controls.Add(Me.cbDuongThuDi)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel4)
        Me.UltraTabPageControl1.Controls.Add(Me.cbNgayDong)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel3)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel1)
        Me.UltraTabPageControl1.Controls.Add(Me.Grid_BV2)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(2, 24)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(484, 422)
        '
        'UltraLabel5
        '
        Me.UltraLabel5.Location = New System.Drawing.Point(144, 8)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(83, 23)
        Me.UltraLabel5.TabIndex = 2
        Me.UltraLabel5.Text = "Đợt Bay"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Location = New System.Drawing.Point(16, 80)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(83, 23)
        Me.UltraLabel2.TabIndex = 4
        Me.UltraLabel2.Text = "Chuyến Bay"
        '
        'cbDot
        '
        Me.cbDot.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn1.Header.Caption = "Đợt"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1})
        Me.cbDot.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.cbDot.DisplayMember = ""
        Me.cbDot.Location = New System.Drawing.Point(144, 40)
        Me.cbDot.Name = "cbDot"
        Me.cbDot.TabIndex = 3
        Me.cbDot.ValueMember = ""
        '
        'cbChuyenBay
        '
        Me.cbChuyenBay.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbChuyenBay.DisplayMember = ""
        Me.cbChuyenBay.Location = New System.Drawing.Point(16, 112)
        Me.cbChuyenBay.Name = "cbChuyenBay"
        Me.cbChuyenBay.TabIndex = 5
        Me.cbChuyenBay.ValueMember = ""
        '
        'btnXoa
        '
        Me.btnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.Location = New System.Drawing.Point(368, 16)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(64, 48)
        Me.btnXoa.TabIndex = 13
        Me.btnXoa.Text = "Xóa"
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Location = New System.Drawing.Point(280, 16)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(64, 48)
        Me.btnThem.TabIndex = 12
        Me.btnThem.Text = "Thêm"
        '
        'cbLoai_Chuyen_Thu
        '
        Me.cbLoai_Chuyen_Thu.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbLoai_Chuyen_Thu.Cursor = System.Windows.Forms.Cursors.IBeam
        UltraGridColumn2.Header.Caption = "Mã Loại"
        UltraGridColumn2.Header.VisiblePosition = 0
        UltraGridColumn2.Width = 55
        UltraGridColumn3.Header.Caption = "Tên Loại"
        UltraGridColumn3.Header.VisiblePosition = 1
        UltraGridColumn3.Width = 83
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn2, UltraGridColumn3})
        UltraGridBand2.Header.Caption = "Chuyến Thư Đi"
        Me.cbLoai_Chuyen_Thu.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.cbLoai_Chuyen_Thu.DisplayMember = ""
        Me.cbLoai_Chuyen_Thu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLoai_Chuyen_Thu.Location = New System.Drawing.Point(240, 112)
        Me.cbLoai_Chuyen_Thu.Name = "cbLoai_Chuyen_Thu"
        Me.cbLoai_Chuyen_Thu.Size = New System.Drawing.Size(48, 21)
        Me.cbLoai_Chuyen_Thu.TabIndex = 9
        Me.cbLoai_Chuyen_Thu.ValueMember = ""
        '
        'UltraLabel9
        '
        Me.UltraLabel9.Location = New System.Drawing.Point(240, 88)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(48, 23)
        Me.UltraLabel9.TabIndex = 8
        Me.UltraLabel9.Text = "&Loại CT"
        '
        'cbChuyenThuDi
        '
        Me.cbChuyenThuDi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn4.Header.Caption = "Chuyến Thư"
        UltraGridColumn4.Header.VisiblePosition = 0
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn4})
        UltraGridBand3.Header.Caption = "Chuyến Thư Đi"
        Me.cbChuyenThuDi.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.cbChuyenThuDi.DisplayMember = ""
        Me.cbChuyenThuDi.Location = New System.Drawing.Point(296, 112)
        Me.cbChuyenThuDi.Name = "cbChuyenThuDi"
        Me.cbChuyenThuDi.Size = New System.Drawing.Size(64, 21)
        Me.cbChuyenThuDi.TabIndex = 11
        Me.cbChuyenThuDi.ValueMember = ""
        '
        'cbDuongThuDi
        '
        Me.cbDuongThuDi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbDuongThuDi.Cursor = System.Windows.Forms.Cursors.IBeam
        UltraGridColumn5.Header.Caption = "Mã Bưu Cục"
        UltraGridColumn5.Header.VisiblePosition = 0
        UltraGridColumn6.Header.Caption = "Tên Bưu Cục"
        UltraGridColumn6.Header.VisiblePosition = 1
        UltraGridColumn7.Header.VisiblePosition = 2
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.Caption = "Phân Loại Đường Thư"
        UltraGridColumn8.Header.VisiblePosition = 3
        UltraGridColumn8.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8})
        UltraGridBand4.Header.Caption = "Mã Đường Thư"
        Me.cbDuongThuDi.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.cbDuongThuDi.DisplayMember = ""
        Me.cbDuongThuDi.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDuongThuDi.Location = New System.Drawing.Point(128, 112)
        Me.cbDuongThuDi.Name = "cbDuongThuDi"
        Me.cbDuongThuDi.Size = New System.Drawing.Size(104, 21)
        Me.cbDuongThuDi.TabIndex = 7
        Me.cbDuongThuDi.ValueMember = ""
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Location = New System.Drawing.Point(16, 16)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(83, 23)
        Me.UltraLabel4.TabIndex = 0
        Me.UltraLabel4.Text = "&Ngày Đóng E2"
        '
        'cbNgayDong
        '
        Me.cbNgayDong.DateTime = New Date(2008, 9, 9, 0, 0, 0, 0)
        Me.cbNgayDong.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.cbNgayDong.Location = New System.Drawing.Point(16, 40)
        Me.cbNgayDong.Name = "cbNgayDong"
        Me.cbNgayDong.Size = New System.Drawing.Size(99, 21)
        Me.cbNgayDong.TabIndex = 1
        Me.cbNgayDong.Value = New Date(2008, 9, 9, 0, 0, 0, 0)
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Location = New System.Drawing.Point(296, 88)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(72, 23)
        Me.UltraLabel3.TabIndex = 10
        Me.UltraLabel3.Text = "&Chuyến Thư"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(128, 88)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(89, 23)
        Me.UltraLabel1.TabIndex = 6
        Me.UltraLabel1.Text = "Đường T&hư"
        '
        'Grid_BV2
        '
        Me.Grid_BV2.DataMember = Nothing
        Me.Grid_BV2.Location = New System.Drawing.Point(8, 144)
        Me.Grid_BV2.Name = "Grid_BV2"
        Me.Grid_BV2.Size = New System.Drawing.Size(472, 264)
        Me.Grid_BV2.TabIndex = 14
        Me.Grid_BV2.Text = "BV2"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel11)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel12)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraCombo4)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraCombo5)
        Me.UltraTabPageControl2.Controls.Add(Me.Group_Lua_Chon)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraCombo1)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel6)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraCombo2)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraCombo3)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel7)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraDateTimeEditor1)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel8)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel10)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(484, 422)
        '
        'Tab_InBanKe
        '
        Me.Tab_InBanKe.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.Tab_InBanKe.Controls.Add(Me.UltraTabPageControl1)
        Me.Tab_InBanKe.Controls.Add(Me.UltraTabPageControl2)
        Me.Tab_InBanKe.Location = New System.Drawing.Point(8, 16)
        Me.Tab_InBanKe.Name = "Tab_InBanKe"
        Me.Tab_InBanKe.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.Tab_InBanKe.Size = New System.Drawing.Size(488, 448)
        Me.Tab_InBanKe.TabIndex = 0
        UltraTab1.Key = "Thiet_Lap_Va_In_BV2"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Thiết Lập và In BV2"
        UltraTab2.Key = "In_Ban_Ke"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "In Bản Kê"
        Me.Tab_InBanKe.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(484, 422)
        '
        'BtnExit
        '
        Appearance1.FontData.BoldAsString = "True"
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.BtnExit.Appearance = Appearance1
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(312, 472)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(88, 32)
        Me.BtnExit.TabIndex = 6
        Me.BtnExit.Text = "Exit"
        '
        'BtnPrint
        '
        Appearance2.FontData.BoldAsString = "True"
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Appearance2.TextHAlign = Infragistics.Win.HAlign.Center
        Me.BtnPrint.Appearance = Appearance2
        Me.BtnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.Location = New System.Drawing.Point(216, 472)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(80, 32)
        Me.BtnPrint.TabIndex = 5
        Me.BtnPrint.Text = "Printer"
        '
        'BtnPreview
        '
        Appearance3.FontData.BoldAsString = "True"
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        Me.BtnPreview.Appearance = Appearance3
        Me.BtnPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPreview.Location = New System.Drawing.Point(112, 472)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(88, 32)
        Me.BtnPreview.TabIndex = 4
        Me.BtnPreview.Text = "Preview"
        '
        'UltraCombo1
        '
        Me.UltraCombo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.UltraCombo1.Cursor = System.Windows.Forms.Cursors.IBeam
        UltraGridColumn9.Header.Caption = "Mã Loại"
        UltraGridColumn9.Header.VisiblePosition = 0
        UltraGridColumn9.Width = 55
        UltraGridColumn10.Header.Caption = "Tên Loại"
        UltraGridColumn10.Header.VisiblePosition = 1
        UltraGridColumn10.Width = 83
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn9, UltraGridColumn10})
        UltraGridBand5.Header.Caption = "Chuyến Thư Đi"
        Me.UltraCombo1.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.UltraCombo1.DisplayMember = ""
        Me.UltraCombo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraCombo1.Location = New System.Drawing.Point(256, 104)
        Me.UltraCombo1.Name = "UltraCombo1"
        Me.UltraCombo1.Size = New System.Drawing.Size(48, 21)
        Me.UltraCombo1.TabIndex = 17
        Me.UltraCombo1.ValueMember = ""
        '
        'UltraLabel6
        '
        Me.UltraLabel6.Location = New System.Drawing.Point(256, 80)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(48, 23)
        Me.UltraLabel6.TabIndex = 16
        Me.UltraLabel6.Text = "&Loại CT"
        '
        'UltraCombo2
        '
        Me.UltraCombo2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn11.Header.Caption = "Chuyến Thư"
        UltraGridColumn11.Header.VisiblePosition = 0
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn11})
        UltraGridBand6.Header.Caption = "Chuyến Thư Đi"
        Me.UltraCombo2.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.UltraCombo2.DisplayMember = ""
        Me.UltraCombo2.Location = New System.Drawing.Point(312, 104)
        Me.UltraCombo2.Name = "UltraCombo2"
        Me.UltraCombo2.Size = New System.Drawing.Size(64, 21)
        Me.UltraCombo2.TabIndex = 19
        Me.UltraCombo2.ValueMember = ""
        '
        'UltraCombo3
        '
        Me.UltraCombo3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.UltraCombo3.Cursor = System.Windows.Forms.Cursors.IBeam
        UltraGridColumn12.Header.Caption = "Mã Bưu Cục"
        UltraGridColumn12.Header.VisiblePosition = 0
        UltraGridColumn13.Header.Caption = "Tên Bưu Cục"
        UltraGridColumn13.Header.VisiblePosition = 1
        UltraGridColumn14.Header.VisiblePosition = 2
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.Caption = "Phân Loại Đường Thư"
        UltraGridColumn15.Header.VisiblePosition = 3
        UltraGridColumn15.Hidden = True
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15})
        UltraGridBand7.Header.Caption = "Mã Đường Thư"
        Me.UltraCombo3.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.UltraCombo3.DisplayMember = ""
        Me.UltraCombo3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraCombo3.Location = New System.Drawing.Point(144, 104)
        Me.UltraCombo3.Name = "UltraCombo3"
        Me.UltraCombo3.Size = New System.Drawing.Size(104, 21)
        Me.UltraCombo3.TabIndex = 15
        Me.UltraCombo3.ValueMember = ""
        '
        'UltraLabel7
        '
        Me.UltraLabel7.Location = New System.Drawing.Point(16, 16)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(83, 23)
        Me.UltraLabel7.TabIndex = 12
        Me.UltraLabel7.Text = "&Ngày Đóng E2"
        '
        'UltraDateTimeEditor1
        '
        Me.UltraDateTimeEditor1.DateTime = New Date(2008, 9, 9, 0, 0, 0, 0)
        Me.UltraDateTimeEditor1.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.UltraDateTimeEditor1.Location = New System.Drawing.Point(16, 40)
        Me.UltraDateTimeEditor1.Name = "UltraDateTimeEditor1"
        Me.UltraDateTimeEditor1.Size = New System.Drawing.Size(99, 21)
        Me.UltraDateTimeEditor1.TabIndex = 13
        Me.UltraDateTimeEditor1.Value = New Date(2008, 9, 9, 0, 0, 0, 0)
        '
        'UltraLabel8
        '
        Me.UltraLabel8.Location = New System.Drawing.Point(312, 80)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(72, 23)
        Me.UltraLabel8.TabIndex = 18
        Me.UltraLabel8.Text = "&Chuyến Thư"
        '
        'UltraLabel10
        '
        Me.UltraLabel10.Location = New System.Drawing.Point(144, 80)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(89, 23)
        Me.UltraLabel10.TabIndex = 14
        Me.UltraLabel10.Text = "Đường T&hư"
        '
        'Group_Lua_Chon
        '
        Me.Group_Lua_Chon.Controls.Add(Me.UltraTextEditor4)
        Me.Group_Lua_Chon.Controls.Add(Me.UltraCheckEditor4)
        Me.Group_Lua_Chon.Controls.Add(Me.UltraTextEditor3)
        Me.Group_Lua_Chon.Controls.Add(Me.UltraCheckEditor3)
        Me.Group_Lua_Chon.Controls.Add(Me.UltraTextEditor2)
        Me.Group_Lua_Chon.Controls.Add(Me.UltraCheckEditor2)
        Me.Group_Lua_Chon.Controls.Add(Me.UltraTextEditor1)
        Me.Group_Lua_Chon.Controls.Add(Me.UltraCheckEditor1)
        Me.Group_Lua_Chon.Location = New System.Drawing.Point(16, 152)
        Me.Group_Lua_Chon.Name = "Group_Lua_Chon"
        Me.Group_Lua_Chon.Size = New System.Drawing.Size(416, 192)
        Me.Group_Lua_Chon.SupportThemes = False
        Me.Group_Lua_Chon.TabIndex = 20
        Me.Group_Lua_Chon.Text = "Lựa Chọn"
        '
        'UltraCheckEditor1
        '
        Me.UltraCheckEditor1.Location = New System.Drawing.Point(24, 40)
        Me.UltraCheckEditor1.Name = "UltraCheckEditor1"
        Me.UltraCheckEditor1.Size = New System.Drawing.Size(216, 20)
        Me.UltraCheckEditor1.TabIndex = 0
        Me.UltraCheckEditor1.Text = "Bản Kê gửi HQ Bưu Điện"
        '
        'UltraTextEditor1
        '
        Me.UltraTextEditor1.Location = New System.Drawing.Point(288, 40)
        Me.UltraTextEditor1.Name = "UltraTextEditor1"
        Me.UltraTextEditor1.Size = New System.Drawing.Size(100, 21)
        Me.UltraTextEditor1.TabIndex = 1
        Me.UltraTextEditor1.Text = "UltraTextEditor1"
        '
        'UltraTextEditor2
        '
        Me.UltraTextEditor2.Location = New System.Drawing.Point(288, 72)
        Me.UltraTextEditor2.Name = "UltraTextEditor2"
        Me.UltraTextEditor2.Size = New System.Drawing.Size(100, 21)
        Me.UltraTextEditor2.TabIndex = 3
        Me.UltraTextEditor2.Text = "UltraTextEditor2"
        '
        'UltraCheckEditor2
        '
        Me.UltraCheckEditor2.Location = New System.Drawing.Point(24, 72)
        Me.UltraCheckEditor2.Name = "UltraCheckEditor2"
        Me.UltraCheckEditor2.Size = New System.Drawing.Size(216, 20)
        Me.UltraCheckEditor2.TabIndex = 2
        Me.UltraCheckEditor2.Text = "Phiếu Giao Nhận Túi Thư"
        '
        'UltraTextEditor3
        '
        Me.UltraTextEditor3.Location = New System.Drawing.Point(288, 112)
        Me.UltraTextEditor3.Name = "UltraTextEditor3"
        Me.UltraTextEditor3.Size = New System.Drawing.Size(100, 21)
        Me.UltraTextEditor3.TabIndex = 5
        Me.UltraTextEditor3.Text = "UltraTextEditor3"
        '
        'UltraCheckEditor3
        '
        Me.UltraCheckEditor3.Location = New System.Drawing.Point(24, 112)
        Me.UltraCheckEditor3.Name = "UltraCheckEditor3"
        Me.UltraCheckEditor3.Size = New System.Drawing.Size(216, 20)
        Me.UltraCheckEditor3.TabIndex = 4
        Me.UltraCheckEditor3.Text = "Phiếu Giao Nhận Túi Gói Thư"
        '
        'UltraTextEditor4
        '
        Me.UltraTextEditor4.Location = New System.Drawing.Point(288, 152)
        Me.UltraTextEditor4.Name = "UltraTextEditor4"
        Me.UltraTextEditor4.Size = New System.Drawing.Size(100, 21)
        Me.UltraTextEditor4.TabIndex = 7
        Me.UltraTextEditor4.Text = "UltraTextEditor4"
        '
        'UltraCheckEditor4
        '
        Me.UltraCheckEditor4.Location = New System.Drawing.Point(24, 152)
        Me.UltraCheckEditor4.Name = "UltraCheckEditor4"
        Me.UltraCheckEditor4.Size = New System.Drawing.Size(216, 20)
        Me.UltraCheckEditor4.TabIndex = 6
        Me.UltraCheckEditor4.Text = "Airmail Manifest"
        '
        'UltraLabel11
        '
        Me.UltraLabel11.Location = New System.Drawing.Point(144, 8)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(83, 23)
        Me.UltraLabel11.TabIndex = 21
        Me.UltraLabel11.Text = "Đợt Bay"
        '
        'UltraLabel12
        '
        Me.UltraLabel12.Location = New System.Drawing.Point(264, 8)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(83, 23)
        Me.UltraLabel12.TabIndex = 23
        Me.UltraLabel12.Text = "Chuyến Bay"
        '
        'UltraCombo4
        '
        Me.UltraCombo4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn16.Header.Caption = "Đợt"
        UltraGridColumn16.Header.VisiblePosition = 0
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn16})
        Me.UltraCombo4.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.UltraCombo4.DisplayMember = ""
        Me.UltraCombo4.Location = New System.Drawing.Point(144, 40)
        Me.UltraCombo4.Name = "UltraCombo4"
        Me.UltraCombo4.TabIndex = 22
        Me.UltraCombo4.ValueMember = ""
        '
        'UltraCombo5
        '
        Me.UltraCombo5.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.UltraCombo5.DisplayMember = ""
        Me.UltraCombo5.Location = New System.Drawing.Point(264, 40)
        Me.UltraCombo5.Name = "UltraCombo5"
        Me.UltraCombo5.TabIndex = 24
        Me.UltraCombo5.ValueMember = ""
        '
        'Frm_Thiet_Lap_Va_In_Ban_Ke
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(504, 509)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.BtnPreview)
        Me.Controls.Add(Me.Tab_InBanKe)
        Me.Name = "Frm_Thiet_Lap_Va_In_Ban_Ke"
        Me.Text = "Thiết Lập và In Bản Kê"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.cbDot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbChuyenBay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbLoai_Chuyen_Thu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbChuyenThuDi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDuongThuDi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbNgayDong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid_BV2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.Tab_InBanKe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_InBanKe.ResumeLayout(False)
        CType(Me.UltraCombo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraCombo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraCombo3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDateTimeEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group_Lua_Chon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group_Lua_Chon.ResumeLayout(False)
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraCombo4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraCombo5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region "Khai báo biến"
    Dim myNgay_E2 As Integer
    Dim myDot As Integer
    Dim myHam_Dung_Chung As New Ham_Dung_Chung

    Dim myDanh_Muc_Duong_Bay As New Danh_Muc_Duong_Bay(GConnectionString)
#End Region

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub LoadData_BV2(ByVal Ngay_E2 As Integer, ByVal Dot As Integer)
        Grid_BV2.DataSource = ""
        Grid_BV2.DataBind()
    End Sub

    Private Sub Tao_Bang_Dot()
        Dim dataTable As New dataTable("Dot_Bay")

        'Tao ra cac cot cua bang nay
        Dim colWork As DataColumn = New DataColumn("Dot", GetType(Int32))
        dataTable.Columns.Add(colWork)

        'Them du lieu vao
        Dim row As DataRow = dataTable.NewRow()

        row("Dot") = 1
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Dot") = 2
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Dot") = 3
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Dot") = 4
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Dot") = 5
        dataTable.Rows.Add(row)
    End Sub

    Private Sub LoadData_Chuyen_Bay()
        'Danh sách các chuyến bay đầu tiên theo từng đường bay
        cbChuyenBay.DataSource = ""
        cbChuyenBay.DataBind()
    End Sub

    Private Sub cbDot_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDot.Validated
        'Hiển thị danh sách các chuyến thư thuộc đợt bay trong ngày
        myNgay_E2 = myHam_Dung_Chung.ConvertDateToInt(cbNgayDong.Value)
        myDot = CInt(SetNullValue(cbDot.Text, "0"))
        LoadData_BV2(myNgay_E2, myDot)
    End Sub

    Private Sub Frm_Thiet_Lap_Va_In_Ban_Ke_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbNgayDong.DateTime = Now.Date
        Tao_Bang_Dot()

    End Sub

    Private Sub btnThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click

    End Sub

    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        'Xóa dữ liệu trong bảng BV2
    End Sub

    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click

    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click

    End Sub
End Class

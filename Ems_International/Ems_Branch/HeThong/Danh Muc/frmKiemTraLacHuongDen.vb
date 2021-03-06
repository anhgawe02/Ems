Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Ems_International_Logic.EMS

Public Class frmKiemTraLacHuongDen
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
    Friend WithEvents tabMain As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents cbxBuuCucKhaiThac As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents gridDuongThuDen As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents tbxIdDuongThu As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents gridDanhMucHuongChuyen As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents chkCheckAll As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents btnTaoMoiDanhSach As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cbxFill As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents pbarCheckAll As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    Friend WithEvents lblDuongThuInfor As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Fill", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Fill")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("DuongThuDen", -1)
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nc")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IPMC")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Duong_Thu")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Phan_Loai")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tinh_Doanh_Thu")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tinh_Cong_Phat")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Duoc_Truyen")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Su_Dung")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chuyen_Tiep")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Bc_Khai_Thac", -1)
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Bc_Khai_Thac")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OutBout")
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Danh_Muc_Huong_Den", -1)
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Huong_Chuyen")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phan_Loai")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dung_Huong")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ghi_Chu")
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.lblDuongThuInfor = New Infragistics.Win.Misc.UltraLabel
        Me.cbxFill = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.btnTaoMoiDanhSach = New Infragistics.Win.Misc.UltraButton
        Me.chkCheckAll = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.tbxIdDuongThu = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.gridDuongThuDen = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.cbxBuuCucKhaiThac = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.gridDanhMucHuongChuyen = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.pbarCheckAll = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar
        Me.tabMain = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.btnExit = New System.Windows.Forms.Button
        CType(Me.cbxFill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbxIdDuongThu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDuongThuDen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxBuuCucKhaiThac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDanhMucHuongChuyen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(412, 0)
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(412, 0)
        '
        'lblDuongThuInfor
        '
        Appearance1.TextHAlign = Infragistics.Win.HAlign.Center
        Me.lblDuongThuInfor.Appearance = Appearance1
        Me.lblDuongThuInfor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuongThuInfor.Location = New System.Drawing.Point(432, 8)
        Me.lblDuongThuInfor.Name = "lblDuongThuInfor"
        Me.lblDuongThuInfor.Size = New System.Drawing.Size(368, 16)
        Me.lblDuongThuInfor.TabIndex = 12
        Me.lblDuongThuInfor.Text = "Đường thư: 100915"
        '
        'cbxFill
        '
        Me.cbxFill.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn1.Header.Caption = "Mã"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1})
        Me.cbxFill.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.cbxFill.DisplayMember = ""
        Me.cbxFill.Location = New System.Drawing.Point(488, 32)
        Me.cbxFill.Name = "cbxFill"
        Me.cbxFill.Size = New System.Drawing.Size(88, 21)
        Me.cbxFill.TabIndex = 10
        Me.cbxFill.ValueMember = ""
        '
        'btnTaoMoiDanhSach
        '
        Me.btnTaoMoiDanhSach.Location = New System.Drawing.Point(584, 32)
        Me.btnTaoMoiDanhSach.Name = "btnTaoMoiDanhSach"
        Me.btnTaoMoiDanhSach.Size = New System.Drawing.Size(112, 23)
        Me.btnTaoMoiDanhSach.TabIndex = 9
        Me.btnTaoMoiDanhSach.Text = "Tạo mới danh sách"
        '
        'chkCheckAll
        '
        Me.chkCheckAll.Location = New System.Drawing.Point(704, 32)
        Me.chkCheckAll.Name = "chkCheckAll"
        Me.chkCheckAll.Size = New System.Drawing.Size(80, 20)
        Me.chkCheckAll.TabIndex = 8
        Me.chkCheckAll.Text = "Chọn tất cả"
        '
        'tbxIdDuongThu
        '
        Me.tbxIdDuongThu.Location = New System.Drawing.Point(632, 96)
        Me.tbxIdDuongThu.Name = "tbxIdDuongThu"
        Me.tbxIdDuongThu.Size = New System.Drawing.Size(112, 21)
        Me.tbxIdDuongThu.TabIndex = 7
        Me.tbxIdDuongThu.Text = "Id Duong Thu"
        Me.tbxIdDuongThu.Visible = False
        '
        'gridDuongThuDen
        '
        Me.gridDuongThuDen.Cursor = System.Windows.Forms.Cursors.Hand
        UltraGridColumn2.Header.VisiblePosition = 0
        UltraGridColumn2.Hidden = True
        UltraGridColumn2.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn2.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn2.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn2.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn3.Header.Caption = "Mã nước"
        UltraGridColumn3.Header.VisiblePosition = 1
        UltraGridColumn3.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn3.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(66, 0)
        UltraGridColumn3.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn3.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn4.Header.VisiblePosition = 2
        UltraGridColumn4.Hidden = True
        UltraGridColumn4.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn4.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn4.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn4.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn5.Header.Caption = "Đường Thư"
        UltraGridColumn5.Header.VisiblePosition = 3
        UltraGridColumn5.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn5.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn5.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(86, 0)
        UltraGridColumn5.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn5.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn6.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(86, 0)
        UltraGridColumn6.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn6.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn7.Header.Caption = "Tên đường thư"
        UltraGridColumn7.Header.VisiblePosition = 4
        UltraGridColumn7.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn7.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn7.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(175, 0)
        UltraGridColumn7.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn7.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn8.Header.VisiblePosition = 6
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 7
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 8
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 9
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 10
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 11
        UltraGridColumn13.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13})
        UltraGridBand2.UseRowLayout = True
        Me.gridDuongThuDen.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.gridDuongThuDen.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        Me.gridDuongThuDen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridDuongThuDen.Location = New System.Drawing.Point(8, 56)
        Me.gridDuongThuDen.Name = "gridDuongThuDen"
        Me.gridDuongThuDen.Size = New System.Drawing.Size(416, 472)
        Me.gridDuongThuDen.TabIndex = 2
        Me.gridDuongThuDen.Text = "Danh sách đường thư đến"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(8, 8)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.TabIndex = 1
        Me.UltraLabel1.Text = "Bưu cục khai thác"
        '
        'cbxBuuCucKhaiThac
        '
        Me.cbxBuuCucKhaiThac.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn14.Header.Caption = "Bưu cục khai thác"
        UltraGridColumn14.Header.VisiblePosition = 0
        UltraGridColumn15.Header.VisiblePosition = 1
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 2
        UltraGridColumn16.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn14, UltraGridColumn15, UltraGridColumn16})
        UltraGridBand3.UseRowLayout = True
        Me.cbxBuuCucKhaiThac.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.cbxBuuCucKhaiThac.DisplayMember = ""
        Me.cbxBuuCucKhaiThac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxBuuCucKhaiThac.Location = New System.Drawing.Point(120, 8)
        Me.cbxBuuCucKhaiThac.Name = "cbxBuuCucKhaiThac"
        Me.cbxBuuCucKhaiThac.Size = New System.Drawing.Size(184, 21)
        Me.cbxBuuCucKhaiThac.TabIndex = 0
        Me.cbxBuuCucKhaiThac.ValueMember = ""
        '
        'gridDanhMucHuongChuyen
        '
        UltraGridColumn17.Header.VisiblePosition = 0
        UltraGridColumn17.Hidden = True
        UltraGridColumn17.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn17.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn17.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn17.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn18.Header.VisiblePosition = 1
        UltraGridColumn18.Hidden = True
        UltraGridColumn18.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn18.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn18.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn18.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn19.Header.VisiblePosition = 3
        UltraGridColumn19.Hidden = True
        UltraGridColumn19.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn19.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn19.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn19.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn20.Header.Caption = "Mã Nước"
        UltraGridColumn20.Header.VisiblePosition = 4
        UltraGridColumn20.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn20.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn20.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(68, 0)
        UltraGridColumn20.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn20.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn21.Header.Caption = "Mã tỉnh"
        UltraGridColumn21.Header.VisiblePosition = 2
        UltraGridColumn21.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn21.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn21.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(81, 0)
        UltraGridColumn21.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn21.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn22.Header.Caption = "Đúng Hướng"
        UltraGridColumn22.Header.VisiblePosition = 5
        UltraGridColumn22.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn22.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn22.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(80, 0)
        UltraGridColumn22.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn22.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn23.Header.Caption = "Ghi Chú"
        UltraGridColumn23.Header.VisiblePosition = 6
        UltraGridColumn23.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn23.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn23.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(234, 0)
        UltraGridColumn23.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn23.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23})
        UltraGridBand4.Header.Caption = "Danh mục hướng đến"
        UltraGridBand4.UseRowLayout = True
        Me.gridDanhMucHuongChuyen.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.gridDanhMucHuongChuyen.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        Me.gridDanhMucHuongChuyen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridDanhMucHuongChuyen.Location = New System.Drawing.Point(432, 56)
        Me.gridDanhMucHuongChuyen.Name = "gridDanhMucHuongChuyen"
        Me.gridDanhMucHuongChuyen.Size = New System.Drawing.Size(352, 472)
        Me.gridDanhMucHuongChuyen.TabIndex = 3
        Me.gridDanhMucHuongChuyen.Text = "Danh sách hướng chuyển"
        '
        'pbarCheckAll
        '
        Me.pbarCheckAll.Location = New System.Drawing.Point(432, 56)
        Me.pbarCheckAll.Name = "pbarCheckAll"
        Me.pbarCheckAll.Size = New System.Drawing.Size(352, 23)
        Me.pbarCheckAll.TabIndex = 11
        Me.pbarCheckAll.Text = "[Formatted]"
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tabMain.Controls.Add(Me.UltraTabPageControl1)
        Me.tabMain.Controls.Add(Me.UltraTabPageControl2)
        Me.tabMain.Location = New System.Drawing.Point(8, 32)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tabMain.Size = New System.Drawing.Size(416, 24)
        Me.tabMain.TabButtonStyle = Infragistics.Win.UIElementButtonStyle.Flat
        Me.tabMain.TabIndex = 0
        UltraTab1.Key = "pageTrongNuoc"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Đường thư trong nước"
        UltraTab2.Key = "pageQuocTe"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Đường thư quốc tế"
        Me.tabMain.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(412, 0)
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(432, 32)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(56, 16)
        Me.UltraLabel2.TabIndex = 13
        Me.UltraLabel2.Text = "Hiển thị"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(704, 536)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Thoát"
        '
        'frmKiemTraLacHuongDen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.tabMain)
        Me.Controls.Add(Me.gridDuongThuDen)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.cbxBuuCucKhaiThac)
        Me.Controls.Add(Me.lblDuongThuInfor)
        Me.Controls.Add(Me.cbxFill)
        Me.Controls.Add(Me.btnTaoMoiDanhSach)
        Me.Controls.Add(Me.chkCheckAll)
        Me.Controls.Add(Me.gridDanhMucHuongChuyen)
        Me.Controls.Add(Me.pbarCheckAll)
        Me.Controls.Add(Me.tbxIdDuongThu)
        Me.Name = "frmKiemTraLacHuongDen"
        Me.Text = "Danh mục hướng chuyển đến"
        CType(Me.cbxFill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbxIdDuongThu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDuongThuDen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxBuuCucKhaiThac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDanhMucHuongChuyen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Declaration"
    Dim myDanhMucHuongDen As New Danh_Muc_Huong_Den(GConnectionString)
#End Region

#Region "Form control event"
    Private Sub frmKiemTraLacHuong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) _
            Handles MyBase.Load
        LoadForm()
    End Sub
    Private Sub cbxBuuCucKhaiThac_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) _
            Handles cbxBuuCucKhaiThac.InitializeLayout
        'cbxBuuCucKhaiThac.LimitToList = True

    End Sub

    ''' Buu cuc khai thac thay doi -> Load lai danh sach duong thu den
    Private Sub cbxBuuCucKhaiThac_RowSelected(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowSelectedEventArgs) _
            Handles cbxBuuCucKhaiThac.RowSelected
        ' Load danh sach duong thu den
        Try
            If cbxBuuCucKhaiThac.Text = "" Then
                Return
            End If
            Dim _Ma_Bc_Khai_Thac As Integer = 0

            _Ma_Bc_Khai_Thac = CInt(cbxBuuCucKhaiThac.Text)
            If _Ma_Bc_Khai_Thac <> 0 Then
                LoadDuongThuDen(_Ma_Bc_Khai_Thac)
            Else
                LoadDuongThuDen(0)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    ''' Duong thu den after row active: Load danh muc huong chuyen theo duong thu
    Private Sub gridDuongThuDen_AfterRowActived(ByVal sender As Object, ByVal e As System.EventArgs) _
            Handles gridDuongThuDen.AfterRowActivate
        ' Load  fill
        LoadDanhMucHuongDen("", _
                            cbxFill.Text.Trim, _
                            IIf(tabMain.ActiveTab.Key = "pageTrongNuoc", True, False))
        chkCheckAll.Checked = False
        ' Get ID_Duong_Thu
        Dim mID_Duong_Thu As String = String.Empty
        mID_Duong_Thu = gridDuongThuDen.ActiveRow.Cells("ID_Duong_Thu").Text
        tbxIdDuongThu.Text = mID_Duong_Thu

        LoadDanhMucHuongDen(tbxIdDuongThu.Text.Trim, _
                            cbxFill.Text.Trim, _
                            IIf(tabMain.ActiveTab.Key = "pageTrongNuoc", True, False))
        LoadDuongThuInfor()

    End Sub

    ''' Tao moi danh sach huong chuyen neu chua co mot chi tiet nao
    Private Sub btnTaoMoiDanhSach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
            Handles btnTaoMoiDanhSach.Click
        chkCheckAll.Checked = False
        Dim _Id_Duong_Thu As String = String.Empty
        _Id_Duong_Thu = tbxIdDuongThu.Text.Trim
        If _Id_Duong_Thu = String.Empty Then
            Return
        End If

        ' Kiem tra xem da ton tai du lieu chua
        If myDanhMucHuongDen.Danh_Muc_Huong_Den_Danh_Sach_Lay_Boi_ID_Duong_Thu(_Id_Duong_Thu).Tables(0).Rows.Count > 0 Then
            If (MessageBox.Show("Đã có dữ liệu hướng chuyển cho đường thư này!" & vbNewLine & _
                            "Bạn có muốn tạo lại không???", _
                            "Thông báo", _
                            MessageBoxButtons.YesNo, _
                            MessageBoxIcon.Question, _
                            MessageBoxDefaultButton.Button2) _
                            = DialogResult.Yes) Then
                ' Xoa du lieu cu
                myDanhMucHuongDen.Danh_Muc_Huong_Den_Xoa_Boi_Id_Duong_Thu(_Id_Duong_Thu)
                ' Load lai grid
                LoadDanhMucHuongDen(_Id_Duong_Thu, _
                                    cbxFill.Text.Trim, _
                                    IIf(tabMain.ActiveTab.Key = "pageTrongNuoc", True, False))
            Else
                Return
            End If
        End If

        ' Lay duong thu den chi tiet
        Dim mDuongThuDen As New Duong_Thu_Den(GConnectionString)
        Dim mDuongThuDenChiTiet As New Duong_Thu_Den_Chi_Tiet
        mDuongThuDenChiTiet = mDuongThuDen.Lay(_Id_Duong_Thu)
        If tabMain.ActiveTab.Key = "pageTrongNuoc" Then
            ThemMaTinhVaoHuongChuyen(_Id_Duong_Thu)
        Else
            ThemMaNuocVaoHuongChuyen(_Id_Duong_Thu)
        End If
    End Sub

    ''' Check all or uncheck all
    Private Sub chkCheckAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
            Handles chkCheckAll.CheckedChanged
        If chkCheckAll.Checked Then
            chkCheckAll.Text = "Bỏ chọn tất cả"
        Else
            chkCheckAll.Text = "Chọn tất cả"
        End If

        If gridDanhMucHuongChuyen.Rows.Count = 0 Then
            Return
        End If

        pbarCheckAll.BringToFront()
        pbarCheckAll.Visible = True
        Dim mGridRowCount As Integer = 0
        mGridRowCount = gridDanhMucHuongChuyen.Rows.Count
        pbarCheckAll.Maximum = mGridRowCount
        pbarCheckAll.Text = "( " & pbarCheckAll.Value & "  /  " & pbarCheckAll.Maximum & " )"
        pbarCheckAll.Step = 1
        pbarCheckAll.Value = 0
        Me.ActiveForm.Cursor.Current = Cursors.WaitCursor

        For i As Integer = 0 To mGridRowCount - 1
            Me.ActiveForm.Cursor.Current = Cursors.WaitCursor
            pbarCheckAll.PerformStep()
            pbarCheckAll.Text = "( " & pbarCheckAll.Value & "  /  " & pbarCheckAll.Maximum & " )"
            Application.DoEvents()
            ' add to grid
            ' Lay chi Chi tiet huong den
            Dim mDanhMucHuongDenChiTiet As New Danh_Muc_Huong_Den_Chi_Tiet
            With mDanhMucHuongDenChiTiet
                .ID_Duong_Thu = gridDanhMucHuongChuyen.Rows(i).Cells("Id_Duong_Thu").Text
                .Phan_Loai = CInt(gridDanhMucHuongChuyen.Rows(i).Cells("Phan_Loai").Text)
                .Ma_Nuoc = gridDanhMucHuongChuyen.Rows(i).Cells("Ma_Nuoc").Text
                .Ma_Tinh = CInt(gridDanhMucHuongChuyen.Rows(i).Cells("Ma_Tinh").Text)
                .ID_Huong_Chuyen = gridDanhMucHuongChuyen.Rows(i).Cells("Id_Huong_Chuyen").Text
                .Dung_Huong = chkCheckAll.Checked ' Cap nhat the check chkCheckAll
                .Ghi_Chu = gridDanhMucHuongChuyen.Rows(i).Cells("Ghi_Chu").Text
            End With
            ' Update to grid
            gridDanhMucHuongChuyen.Rows(i).Cells("Dung_Huong").Value = CBool(chkCheckAll.Checked)
            ' update to database
            myDanhMucHuongDen.Danh_Muc_Huong_Den_Cap_Nhat_Them(mDanhMucHuongDenChiTiet.ID_Huong_Chuyen, _
                                                            mDanhMucHuongDenChiTiet.ID_Duong_Thu, _
                                                            mDanhMucHuongDenChiTiet.Phan_Loai, _
                                                            mDanhMucHuongDenChiTiet.Ma_Nuoc, _
                                                            mDanhMucHuongDenChiTiet.Ma_Tinh, _
                                                            mDanhMucHuongDenChiTiet.Dung_Huong, _
                                                            mDanhMucHuongDenChiTiet.Ghi_Chu)
        Next
        ActiveForm.Cursor.Current = Cursors.Default
        pbarCheckAll.SendToBack()
        pbarCheckAll.Visible = False
    End Sub


    Private Sub gridDanhMucHuongChuyen_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) _
            Handles gridDanhMucHuongChuyen.AfterCellUpdate
        ' add to grid
        ' Lay chi Chi tiet huong den
        If Not CheckActiveRow() Then
            Return
        End If
        Dim mDanhMucHuongDenChiTiet As New Danh_Muc_Huong_Den_Chi_Tiet
        With mDanhMucHuongDenChiTiet
            .ID_Duong_Thu = gridDanhMucHuongChuyen.ActiveRow.Cells("Id_Duong_Thu").Text
            .Phan_Loai = CInt(gridDanhMucHuongChuyen.ActiveRow.Cells("Phan_Loai").Text)
            .Ma_Nuoc = gridDanhMucHuongChuyen.ActiveRow.Cells("Ma_Nuoc").Text
            .Ma_Tinh = CInt(gridDanhMucHuongChuyen.ActiveRow.Cells("Ma_Tinh").Text)
            .ID_Huong_Chuyen = gridDanhMucHuongChuyen.ActiveRow.Cells("Id_Huong_Chuyen").Text
            .Dung_Huong = CBool(gridDanhMucHuongChuyen.ActiveRow.Cells("Dung_Huong").Value)
            .Ghi_Chu = gridDanhMucHuongChuyen.ActiveRow.Cells("Ghi_Chu").Text
        End With

        ' update to database
        myDanhMucHuongDen.Danh_Muc_Huong_Den_Cap_Nhat_Them(mDanhMucHuongDenChiTiet.ID_Huong_Chuyen, _
                                                        mDanhMucHuongDenChiTiet.ID_Duong_Thu, _
                                                        mDanhMucHuongDenChiTiet.Phan_Loai, _
                                                        mDanhMucHuongDenChiTiet.Ma_Nuoc, _
                                                        mDanhMucHuongDenChiTiet.Ma_Tinh, _
                                                        mDanhMucHuongDenChiTiet.Dung_Huong, _
                                                        mDanhMucHuongDenChiTiet.Ghi_Chu)
    End Sub

    Private Sub cbxFill_RowSelected(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowSelectedEventArgs) _
            Handles cbxFill.RowSelected
        LoadDanhMucHuongDen(tbxIdDuongThu.Text.Trim, _
                            cbxFill.Text.Trim, _
                            IIf(tabMain.ActiveTab.Key = "pageTrongNuoc", True, False))
        If cbxFill.Text = "Tất cả" Then
            btnTaoMoiDanhSach.Enabled = True
        Else
            btnTaoMoiDanhSach.Enabled = False
        End If
    End Sub

    Private Sub tabMain_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) _
            Handles tabMain.SelectedTabChanged
        If cbxBuuCucKhaiThac.Text.Trim = "" Then
            Return
        End If
        LoadDuongThuDen(CInt(cbxBuuCucKhaiThac.Text.Trim))

        LoadDanhMucHuongDen(tbxIdDuongThu.Text.Trim, _
                                    cbxFill.Text.Trim, _
                                    IIf(tabMain.ActiveTab.Key = "pageTrongNuoc", True, False))

        lblDuongThuInfor.Text = ""
    End Sub

    ''' grid danh muc huong chuyen init layout: do not allow edit
    Private Sub gridDanhMucHuongChuyen_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles gridDanhMucHuongChuyen.InitializeLayout
        gridDanhMucHuongChuyen.DisplayLayout.Bands(0).Columns("Ma_Tinh").CellActivation = Activation.ActivateOnly
        gridDanhMucHuongChuyen.DisplayLayout.Bands(0).Columns("Ma_Nuoc").CellActivation = Activation.ActivateOnly

        gridDanhMucHuongChuyen.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        gridDanhMucHuongChuyen.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue

        gridDanhMucHuongChuyen.DisplayLayout.Bands(0).Columns("Id_Huong_Chuyen").Hidden = True
        gridDanhMucHuongChuyen.DisplayLayout.Bands(0).Columns("Id_Duong_Thu").Hidden = True

        If tabMain.ActiveTab.Key = "pageTrongNuoc" Then
            gridDanhMucHuongChuyen.DisplayLayout.Bands(0).Columns("Ma_Tinh").Hidden = False
            gridDanhMucHuongChuyen.DisplayLayout.Bands(0).Columns("Ma_Nuoc").Hidden = True
        Else
            gridDanhMucHuongChuyen.DisplayLayout.Bands(0).Columns("Ma_Tinh").Hidden = True
            gridDanhMucHuongChuyen.DisplayLayout.Bands(0).Columns("Ma_Nuoc").Hidden = False
        End If
    End Sub

    ''' grid duong thu den init layout: do not allow edit
    Private Sub gridDuongThuDen_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles gridDuongThuDen.InitializeLayout
        gridDuongThuDen.DisplayLayout.Bands(0).Columns("Ma_Bc").CellActivation = Activation.ActivateOnly
        gridDuongThuDen.DisplayLayout.Bands(0).Columns("Ten_Duong_Thu").CellActivation = Activation.ActivateOnly

        gridDuongThuDen.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.SandyBrown
        gridDuongThuDen.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.YellowGreen

        If tabMain.ActiveTab.Key = "pageTrongNuoc" Then
            gridDuongThuDen.DisplayLayout.Bands(0).Columns("Ma_Nc").Hidden = True
            gridDuongThuDen.DisplayLayout.Bands(0).Columns("IPMC").Hidden = True
        Else
            gridDuongThuDen.DisplayLayout.Bands(0).Columns("Ma_Nc").Hidden = False
            gridDuongThuDen.DisplayLayout.Bands(0).Columns("IPMC").Hidden = False
        End If
    End Sub
#End Region

#Region "Common function"
    ''' Load form method
    Private Sub LoadForm()
        ' Load data to cbxMa_Bc_Khai_Thac
        LoadBuuCucKhaiThac()
        LoadFill()
    End Sub

    ''' Load danh sach buu cuc khai thac
    Private Sub LoadBuuCucKhaiThac()
        Dim mMa_Bc_Khai_Thac As New Ma_Bc_Khai_Thac(GConnectionString)
        cbxBuuCucKhaiThac.DataSource = mMa_Bc_Khai_Thac.Danh_Sach()
        cbxBuuCucKhaiThac.DataBind()
        cbxBuuCucKhaiThac.ValueMember = "Ma_Bc_Khai_Thac"
        cbxBuuCucKhaiThac.DisplayMember = "Ma_Bc_Khai_Thac"

        cbxBuuCucKhaiThac.Value = GBuu_Cuc_Khai_Thac
        cbxBuuCucKhaiThac.Text = GBuu_Cuc_Khai_Thac
    End Sub

    ''' Load danh sach duong thu den
    Private Sub LoadDuongThuDen(ByVal _Ma_Bc_Khai_Thac As Integer)
        Dim mDuongThuDen As New Duong_Thu_Den(GConnectionString)
        If tabMain.ActiveTab.Key = "pageTrongNuoc" Then
            gridDuongThuDen.DataSource = mDuongThuDen.Danh_Sach_Duong_Thu_Trong_Nuoc(_Ma_Bc_Khai_Thac)
        Else
            gridDuongThuDen.DataSource = mDuongThuDen.Danh_Sach_Duong_Thu_Quoc_Te(_Ma_Bc_Khai_Thac)
        End If

        gridDuongThuDen.DataBind()
    End Sub

    ''' Load danh sach cac trang thai fill theo huong chuyen den
    Private Sub LoadFill()
        Dim mdt As New DataTable("Fill")

        Dim colWork As DataColumn = New DataColumn("Ma_Fill", GetType(String))
        mdt.Columns.Add(colWork)

        Dim row As DataRow = mdt.NewRow()
        row("Ma_Fill") = "Tất cả"
        mdt.Rows.Add(row)

        row = mdt.NewRow
        row("Ma_Fill") = "Đúng hướng"
        mdt.Rows.Add(row)

        row = mdt.NewRow
        row("Ma_Fill") = "Lạc hướng"
        mdt.Rows.Add(row)

        cbxFill.DataSource = mdt
        cbxFill.DataBind()

        cbxFill.Value = cbxFill.Rows(0).Cells("Ma_Fill").Text
        cbxFill.Text = cbxFill.Rows(0).Cells("Ma_Fill").Text
    End Sub

    ''' Load thong tin ve duong thu hien hanh
    Private Sub LoadDuongThuInfor()
        lblDuongThuInfor.Text = "Hướng chuyển đường thư : " & _
                        gridDuongThuDen.ActiveRow.Cells("Ma_Bc").Text & _
                        "  (" & gridDuongThuDen.ActiveRow.Cells("Ten_Duong_Thu").Text & ")"
    End Sub

    ''' Load danh muc huong den theo id duong thu
    Private Sub LoadDanhMucHuongDen(ByVal _ID_Duong_Thu As String, ByVal _Ma_Fill As String, ByVal isTrongNuoc As Boolean)
        If gridDuongThuDen.Rows.Count = 0 Then
            _ID_Duong_Thu = ""
        End If

        Dim mdt As New DataTable
        mdt = myDanhMucHuongDen.Danh_Muc_Huong_Den_Danh_Sach_Lay_Boi_ID_Duong_Thu(_ID_Duong_Thu).Tables(0)

        Dim mdtFill As New DataView
        mdtFill = mdt.DefaultView
        Select Case cbxFill.Text
            Case "Tất cả"
                If tabMain.ActiveTab.Key = "pageTrongNuoc" Then
                    mdtFill.RowFilter = " Ma_Tinh > 0"
                Else
                    mdtFill.RowFilter = " Ma_Tinh = 0"
                End If
            Case "Đúng hướng"
                If tabMain.ActiveTab.Key = "pageTrongNuoc" Then
                    mdtFill.RowFilter = "Dung_Huong <> 0 And Ma_Tinh > 0"
                Else
                    mdtFill.RowFilter = "Dung_Huong <> 0 And Ma_Tinh = 0"
                End If

            Case "Lạc hướng"
                If tabMain.ActiveTab.Key = "pageTrongNuoc" Then
                    mdtFill.RowFilter = "Dung_Huong = 0 And Ma_Tinh > 0"
                Else
                    mdtFill.RowFilter = "Dung_Huong = 0 And Ma_Tinh = 0"
                End If
        End Select

        gridDanhMucHuongChuyen.DataSource = mdtFill
        gridDanhMucHuongChuyen.DataBind()
        gridDanhMucHuongChuyen.Refresh()
    End Sub



    ''' Them danh sach ma tinh (tat ca) vao danh muc huong chuyen theo duong thu
    Private Sub ThemMaTinhVaoHuongChuyen(ByVal _ID_Duong_Thu As String)
        Try
            ' Load Ma Tinh
            Dim mMaTinh As New Ma_Tinh(GConnectionString)
            Dim mDsMaTinh As New DataSet
            mDsMaTinh = mMaTinh.Danh_Sach()
            ' Tim ma tinh theo duong thu
            Dim mMa_Bc As New Danh_Muc_BC(GConnectionString)
            Dim mDuongThuDen As New Duong_Thu_Den(GConnectionString)
            Dim mMaBcChiTiet As New Danh_Muc_BC_Chi_Tiet
            mMaBcChiTiet = mMa_Bc.Lay(mDuongThuDen.Lay(_ID_Duong_Thu).Ma_Bc)

            pbarCheckAll.BringToFront()
            pbarCheckAll.Visible = True
            pbarCheckAll.Maximum = mDsMaTinh.Tables(0).Rows.Count
            pbarCheckAll.Text = "( " & pbarCheckAll.Value & "  /  " & pbarCheckAll.Maximum & " )"
            pbarCheckAll.Step = 1
            pbarCheckAll.Value = 0
            Me.ActiveForm.Cursor.Current = Cursors.WaitCursor

            For i As Integer = 0 To mDsMaTinh.Tables(0).Rows.Count - 1
                Me.ActiveForm.Cursor.Current = Cursors.WaitCursor
                pbarCheckAll.PerformStep()
                pbarCheckAll.Text = "( " & pbarCheckAll.Value & "  /  " & pbarCheckAll.Maximum & " )"

                Application.DoEvents()
                ' add to grid
                ' Lay chi tiet
                Dim mDanhMucHuongDenChiTiet As New Danh_Muc_Huong_Den_Chi_Tiet
                With mDanhMucHuongDenChiTiet
                    .ID_Duong_Thu = _ID_Duong_Thu
                    .Phan_Loai = 0
                    .Ma_Nuoc = "VN"
                    .Ma_Tinh = CInt(mDsMaTinh.Tables(0).Rows(i).Item("Ma_Tinh"))
                    .ID_Huong_Chuyen = CreateIdHuongChuyen(.ID_Duong_Thu, .Ma_Nuoc, .Ma_Tinh)
                    If mMaBcChiTiet.Ma_Tinh = .Ma_Tinh Then
                        .Dung_Huong = True
                    Else
                        .Dung_Huong = False
                    End If
                    .Ghi_Chu = ""
                End With

                gridDanhMucHuongChuyen.Rows.Band.AddNew()
                With gridDanhMucHuongChuyen.Rows(gridDanhMucHuongChuyen.Rows.Count - 1)
                    .Cells("Id_Huong_Chuyen").Value = mDanhMucHuongDenChiTiet.ID_Huong_Chuyen
                    .Cells("Id_Duong_Thu").Value = mDanhMucHuongDenChiTiet.ID_Duong_Thu
                    .Cells("Phan_Loai").Value = mDanhMucHuongDenChiTiet.Phan_Loai
                    .Cells("Ma_Nuoc").Value = mDanhMucHuongDenChiTiet.Ma_Nuoc
                    .Cells("Ma_Tinh").Value = mDanhMucHuongDenChiTiet.Ma_Tinh.ToString
                    .Cells("Dung_Huong").Value = mDanhMucHuongDenChiTiet.Dung_Huong
                    .Cells("Ghi_Chu").Value = mDanhMucHuongDenChiTiet.Ghi_Chu
                End With

                ' Add to database
                myDanhMucHuongDen.Danh_Muc_Huong_Den_Cap_Nhat_Them(mDanhMucHuongDenChiTiet.ID_Huong_Chuyen, _
                                                                mDanhMucHuongDenChiTiet.ID_Duong_Thu, _
                                                                mDanhMucHuongDenChiTiet.Phan_Loai, _
                                                                mDanhMucHuongDenChiTiet.Ma_Nuoc, _
                                                                mDanhMucHuongDenChiTiet.Ma_Tinh, _
                                                                mDanhMucHuongDenChiTiet.Dung_Huong, _
                                                                mDanhMucHuongDenChiTiet.Ghi_Chu)
            Next

            ActiveForm.Cursor.Current = Cursors.Default
            pbarCheckAll.SendToBack()
            pbarCheckAll.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    ''' Them danh sach ma nuoc (tat ca) vao danh muc huong chuyen theo duong thu
    Private Sub ThemMaNuocVaoHuongChuyen(ByVal _ID_Duong_Thu As String)
        ' Load Ma Nuoc
        Dim mMaNuoc As New Ma_Nuoc(GConnectionString)
        Dim mDsMaNuoc As New DataSet
        mDsMaNuoc = mMaNuoc.Danh_Sach()
        ' Tim ma nuoc theo duong thu
        Dim mMa_Bc As New Danh_Muc_BC(GConnectionString)
        Dim mDuongThuDen As New Duong_Thu_Den(GConnectionString)
        Dim mMaBcChiTiet As New Danh_Muc_BC_Chi_Tiet
        mMaBcChiTiet = mMa_Bc.Lay(mDuongThuDen.Lay(_ID_Duong_Thu).Ma_Bc)

        pbarCheckAll.BringToFront()
        pbarCheckAll.Visible = True
        pbarCheckAll.Maximum = mDsMaNuoc.Tables(0).Rows.Count
        pbarCheckAll.Text = "( " & pbarCheckAll.Value & "  /  " & pbarCheckAll.Maximum & " )"
        pbarCheckAll.Step = 1
        pbarCheckAll.Value = 0
        Me.ActiveForm.Cursor.Current = Cursors.WaitCursor

        For i As Integer = 0 To mDsMaNuoc.Tables(0).Rows.Count - 1
            Me.ActiveForm.Cursor.Current = Cursors.WaitCursor
            pbarCheckAll.PerformStep()
            pbarCheckAll.Text = "( " & pbarCheckAll.Value & "  /  " & pbarCheckAll.Maximum & " )"

            Application.DoEvents()
            ' add to grid
            ' Lay chi Chi tiet huong den
            Dim mDanhMucHuongDenChiTiet As New Danh_Muc_Huong_Den_Chi_Tiet
            With mDanhMucHuongDenChiTiet
                .ID_Duong_Thu = _ID_Duong_Thu
                .Phan_Loai = 0
                .Ma_Nuoc = mDsMaNuoc.Tables(0).Rows(i).Item("Ma_Nuoc")
                .Ma_Tinh = 0
                .ID_Huong_Chuyen = CreateIdHuongChuyen(.ID_Duong_Thu, .Ma_Nuoc, .Ma_Tinh)
                If (mMaBcChiTiet.Ma_Nc = .Ma_Nuoc) Or (.Ma_Nuoc = "VN") Then
                    .Dung_Huong = True
                Else
                    .Dung_Huong = False
                End If
                .Ghi_Chu = ""
            End With

            gridDanhMucHuongChuyen.Rows.Band.AddNew()
            With gridDanhMucHuongChuyen.Rows(gridDanhMucHuongChuyen.Rows.Count - 1)
                .Cells("Id_Huong_Chuyen").Value = mDanhMucHuongDenChiTiet.ID_Huong_Chuyen
                .Cells("Id_Duong_Thu").Value = mDanhMucHuongDenChiTiet.ID_Duong_Thu
                .Cells("Phan_Loai").Value = mDanhMucHuongDenChiTiet.Phan_Loai
                .Cells("Ma_Nuoc").Value = mDanhMucHuongDenChiTiet.Ma_Nuoc
                .Cells("Ma_Tinh").Value = mDanhMucHuongDenChiTiet.Ma_Tinh.ToString
                .Cells("Dung_Huong").Value = mDanhMucHuongDenChiTiet.Dung_Huong
                .Cells("Ghi_Chu").Value = mDanhMucHuongDenChiTiet.Ghi_Chu
            End With

            ' Add to database
            myDanhMucHuongDen.Danh_Muc_Huong_Den_Cap_Nhat_Them(mDanhMucHuongDenChiTiet.ID_Huong_Chuyen, _
                                                            mDanhMucHuongDenChiTiet.ID_Duong_Thu, _
                                                            mDanhMucHuongDenChiTiet.Phan_Loai, _
                                                            mDanhMucHuongDenChiTiet.Ma_Nuoc, _
                                                            mDanhMucHuongDenChiTiet.Ma_Tinh, _
                                                            mDanhMucHuongDenChiTiet.Dung_Huong, _
                                                            mDanhMucHuongDenChiTiet.Ghi_Chu)
        Next
        ActiveForm.Cursor.Current = Cursors.Default
        pbarCheckAll.SendToBack()
        pbarCheckAll.Visible = False
    End Sub

    Private Function CheckActiveRow() As Boolean
        If gridDanhMucHuongChuyen.ActiveRow.Cells("Id_Duong_Thu").Text = "" Then
            Return False
        End If
        If gridDanhMucHuongChuyen.ActiveRow.Cells("Id_Huong_Chuyen").Text = "" Then
            Return False
        End If
        If gridDanhMucHuongChuyen.ActiveRow.Cells("Phan_Loai").Text = "" Then
            Return False
        End If
        If gridDanhMucHuongChuyen.ActiveRow.Cells("Ma_Nuoc").Text = "" Then
            Return False
        End If
        If gridDanhMucHuongChuyen.ActiveRow.Cells("Ma_Tinh").Text = "" Then
            Return False
        End If
        If gridDanhMucHuongChuyen.ActiveRow.Cells("Dung_Huong").Text = "" Then
            Return False
        End If
        Return True
    End Function
#End Region

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
        Dispose()
    End Sub
End Class

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

Public Class Frm_Tim_Kiem_To_Khai
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
    Friend WithEvents CbTu_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CbDen_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnTimToKhai As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnThoat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dgToKhaiHaiQuanXuat As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents txtMaE1 As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtSo_To_Khai As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents cbLoai_To_Khai As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents ddKieu_Kiem_Hoa As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents txtTong_So As Infragistics.Win.UltraWinEditors.UltraTextEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_Tim_Kiem_To_Khai))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("To_Khai_Hai_Quan_Xuat", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Mo_To_Khai")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_To_Khai")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Khai", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Khai")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Kieu_Kiem_Hoa")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_TKHQ")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_To_Khai")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_Ma_E1")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tri_Gia_Nguyen_Te")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Thue_Suat")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Thue_Vat")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nguoi_Khai")
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
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Kieu_Kiem_Hoa", -1)
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Loai")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Loai")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Kieu_Kiem_Hoa", -1)
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Loai")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Loai")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.btnTimToKhai = New Infragistics.Win.Misc.UltraButton
        Me.dgToKhaiHaiQuanXuat = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.btnThoat = New Infragistics.Win.Misc.UltraButton
        Me.CbTu_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.CbDen_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        Me.txtTong_So = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtMaE1 = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.txtSo_To_Khai = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.cbLoai_To_Khai = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.ddKieu_Kiem_Hoa = New Infragistics.Win.UltraWinGrid.UltraDropDown
        CType(Me.dgToKhaiHaiQuanXuat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbTu_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbDen_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTong_So, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbLoai_To_Khai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddKieu_Kiem_Hoa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTimToKhai
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.btnTimToKhai.Appearance = Appearance1
        Me.btnTimToKhai.Location = New System.Drawing.Point(568, 16)
        Me.btnTimToKhai.Name = "btnTimToKhai"
        Me.btnTimToKhai.Size = New System.Drawing.Size(88, 32)
        Me.btnTimToKhai.TabIndex = 10
        Me.btnTimToKhai.Text = "&Tìm kiếm"
        '
        'dgToKhaiHaiQuanXuat
        '
        Me.dgToKhaiHaiQuanXuat.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.dgToKhaiHaiQuanXuat.DisplayLayout.AddNewBox.Prompt = " "
        Appearance2.BackColor = System.Drawing.Color.White
        Appearance2.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgToKhaiHaiQuanXuat.DisplayLayout.Appearance = Appearance2
        UltraGridColumn1.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance3.TextVAlign = Infragistics.Win.VAlign.Middle
        UltraGridColumn1.CellAppearance = Appearance3
        UltraGridColumn1.Header.Caption = ""
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn1.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(74, 0)
        UltraGridColumn1.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn1.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn1.ShowInkButton = Infragistics.Win.ShowInkButton.Always
        UltraGridColumn1.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn2.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn2.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn2.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn2.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn3.Header.Caption = "Ngày khai"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.MaskInput = "dd/mm/yyyy"
        UltraGridColumn3.RowLayoutColumnInfo.OriginX = 24
        UltraGridColumn3.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(87, 0)
        UltraGridColumn3.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn3.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn4.Header.Caption = "Giờ khai"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.RowLayoutColumnInfo.OriginX = 26
        UltraGridColumn4.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(70, 0)
        UltraGridColumn4.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn4.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn5.Header.Caption = "Loại tờ khai"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.RowLayoutColumnInfo.OriginX = 28
        UltraGridColumn5.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn5.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(148, 0)
        UltraGridColumn5.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn5.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn6.Header.Caption = "Số tờ khai"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.RowLayoutColumnInfo.OriginX = 30
        UltraGridColumn6.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(74, 0)
        UltraGridColumn6.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn6.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn7.RowLayoutColumnInfo.OriginX = 32
        UltraGridColumn7.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn7.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn7.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn8.Header.Caption = "Tổng số kiện"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.RowLayoutColumnInfo.OriginX = 34
        UltraGridColumn8.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn8.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(82, 0)
        UltraGridColumn8.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn8.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn9.Header.Caption = "Khối lượng"
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.RowLayoutColumnInfo.OriginX = 36
        UltraGridColumn9.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn9.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(79, 0)
        UltraGridColumn9.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn9.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn10.Header.Caption = "Trị giá VNĐ"
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Hidden = True
        UltraGridColumn10.RowLayoutColumnInfo.OriginX = 38
        UltraGridColumn10.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn10.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(84, 0)
        UltraGridColumn10.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn10.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn11.Header.Caption = "Thuế NK"
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Hidden = True
        UltraGridColumn11.RowLayoutColumnInfo.OriginX = 40
        UltraGridColumn11.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn11.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(81, 0)
        UltraGridColumn11.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn11.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn12.Header.Caption = "Thuế VAT"
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Hidden = True
        UltraGridColumn12.RowLayoutColumnInfo.OriginX = 42
        UltraGridColumn12.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn12.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(81, 0)
        UltraGridColumn12.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn12.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn13.Header.Caption = "Người lập tờ khai"
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.RowLayoutColumnInfo.OriginX = 46
        UltraGridColumn13.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn13.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(127, 0)
        UltraGridColumn13.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn13.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13})
        UltraGridBand1.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand1.UseRowLayout = True
        Me.dgToKhaiHaiQuanXuat.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.dgToKhaiHaiQuanXuat.DisplayLayout.InterBandSpacing = 10
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Me.dgToKhaiHaiQuanXuat.DisplayLayout.Override.CardAreaAppearance = Appearance4
        Me.dgToKhaiHaiQuanXuat.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance5.ForeColor = System.Drawing.Color.Black
        Appearance5.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance5.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgToKhaiHaiQuanXuat.DisplayLayout.Override.HeaderAppearance = Appearance5
        Me.dgToKhaiHaiQuanXuat.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance6.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgToKhaiHaiQuanXuat.DisplayLayout.Override.RowAppearance = Appearance6
        Appearance7.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance7.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgToKhaiHaiQuanXuat.DisplayLayout.Override.RowSelectorAppearance = Appearance7
        Me.dgToKhaiHaiQuanXuat.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgToKhaiHaiQuanXuat.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance8.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance8.ForeColor = System.Drawing.Color.Black
        Me.dgToKhaiHaiQuanXuat.DisplayLayout.Override.SelectedRowAppearance = Appearance8
        Me.dgToKhaiHaiQuanXuat.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgToKhaiHaiQuanXuat.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgToKhaiHaiQuanXuat.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgToKhaiHaiQuanXuat.Location = New System.Drawing.Point(4, 56)
        Me.dgToKhaiHaiQuanXuat.Name = "dgToKhaiHaiQuanXuat"
        Me.dgToKhaiHaiQuanXuat.Size = New System.Drawing.Size(784, 424)
        Me.dgToKhaiHaiQuanXuat.TabIndex = 12
        Me.dgToKhaiHaiQuanXuat.Text = "Danh sách tờ khai hải quan"
        '
        'btnThoat
        '
        Appearance9.Image = CType(resources.GetObject("Appearance9.Image"), Object)
        Me.btnThoat.Appearance = Appearance9
        Me.btnThoat.Location = New System.Drawing.Point(696, 16)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(88, 32)
        Me.btnThoat.TabIndex = 11
        Me.btnThoat.Text = "Th&oát"
        '
        'CbTu_Ngay
        '
        Me.CbTu_Ngay.DateTime = New Date(2008, 7, 3, 0, 0, 0, 0)
        Me.CbTu_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.CbTu_Ngay.Location = New System.Drawing.Point(8, 27)
        Me.CbTu_Ngay.MaskInput = "dd/mm/yyyy"
        Me.CbTu_Ngay.Name = "CbTu_Ngay"
        Me.CbTu_Ngay.Size = New System.Drawing.Size(88, 21)
        Me.CbTu_Ngay.TabIndex = 1
        Me.CbTu_Ngay.Value = New Date(2008, 7, 3, 0, 0, 0, 0)
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(8, 8)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(80, 16)
        Me.UltraLabel4.TabIndex = 0
        Me.UltraLabel4.Text = "Từ ngày"
        '
        'CbDen_Ngay
        '
        Me.CbDen_Ngay.DateTime = New Date(2009, 6, 23, 0, 0, 0, 0)
        Me.CbDen_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.CbDen_Ngay.Location = New System.Drawing.Point(104, 27)
        Me.CbDen_Ngay.MaskInput = "dd/mm/yyyy"
        Me.CbDen_Ngay.Name = "CbDen_Ngay"
        Me.CbDen_Ngay.Size = New System.Drawing.Size(88, 21)
        Me.CbDen_Ngay.TabIndex = 3
        Me.CbDen_Ngay.Value = New Date(2009, 6, 23, 0, 0, 0, 0)
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(104, 8)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel3.TabIndex = 2
        Me.UltraLabel3.Text = "Ðến ngày"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(200, 8)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel1.TabIndex = 4
        Me.UltraLabel1.Text = "Mã &E1"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(416, 8)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel2.TabIndex = 8
        Me.UltraLabel2.Text = "Loại tờ khai"
        '
        'UltraLabel5
        '
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(336, 8)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel5.TabIndex = 6
        Me.UltraLabel5.Text = "&Số tờ khai"
        '
        'UltraLabel6
        '
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(608, 488)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel6.TabIndex = 13
        Me.UltraLabel6.Text = "Tổng số"
        '
        'txtTong_So
        '
        Appearance10.TextHAlign = Infragistics.Win.HAlign.Right
        Me.txtTong_So.Appearance = Appearance10
        Me.txtTong_So.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTong_So.Location = New System.Drawing.Point(680, 484)
        Me.txtTong_So.Name = "txtTong_So"
        Appearance11.TextHAlign = Infragistics.Win.HAlign.Right
        Me.txtTong_So.NullTextAppearance = Appearance11
        Me.txtTong_So.ReadOnly = True
        Me.txtTong_So.Size = New System.Drawing.Size(104, 24)
        Me.txtTong_So.TabIndex = 14
        Me.txtTong_So.Text = "0"
        '
        'txtMaE1
        '
        Appearance12.BackColor = System.Drawing.Color.Red
        Appearance12.FontData.BoldAsString = "True"
        Appearance12.ForeColor = System.Drawing.Color.White
        Me.txtMaE1.Appearance = Appearance12
        Me.txtMaE1.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtMaE1.InputMask = "aaaaaaaaaaaaa"
        Me.txtMaE1.Location = New System.Drawing.Point(200, 28)
        Appearance13.FontData.BoldAsString = "True"
        Me.txtMaE1.MaskLiteralsAppearance = Appearance13
        Me.txtMaE1.Name = "txtMaE1"
        Me.txtMaE1.Size = New System.Drawing.Size(120, 20)
        Me.txtMaE1.TabIndex = 5
        '
        'txtSo_To_Khai
        '
        Appearance14.BackColor = System.Drawing.Color.Red
        Appearance14.FontData.BoldAsString = "True"
        Appearance14.ForeColor = System.Drawing.Color.White
        Me.txtSo_To_Khai.Appearance = Appearance14
        Me.txtSo_To_Khai.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtSo_To_Khai.InputMask = "999999"
        Me.txtSo_To_Khai.Location = New System.Drawing.Point(336, 28)
        Me.txtSo_To_Khai.Name = "txtSo_To_Khai"
        Me.txtSo_To_Khai.Size = New System.Drawing.Size(64, 20)
        Me.txtSo_To_Khai.TabIndex = 7
        '
        'cbLoai_To_Khai
        '
        Me.cbLoai_To_Khai.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn14.Header.Caption = "Mã loại"
        UltraGridColumn14.Header.VisiblePosition = 0
        UltraGridColumn14.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(47, 0)
        UltraGridColumn15.Header.Caption = "Loại kiểm hoá"
        UltraGridColumn15.Header.VisiblePosition = 1
        UltraGridColumn15.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(157, 0)
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn14, UltraGridColumn15})
        UltraGridBand2.UseRowLayout = True
        Me.cbLoai_To_Khai.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.cbLoai_To_Khai.DisplayMember = "Ten_Loai"
        Me.cbLoai_To_Khai.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLoai_To_Khai.Location = New System.Drawing.Point(416, 27)
        Me.cbLoai_To_Khai.Name = "cbLoai_To_Khai"
        Me.cbLoai_To_Khai.Size = New System.Drawing.Size(136, 21)
        Me.cbLoai_To_Khai.TabIndex = 9
        Me.cbLoai_To_Khai.ValueMember = "Ma_Loai"
        '
        'ddKieu_Kiem_Hoa
        '
        Me.ddKieu_Kiem_Hoa.Cursor = System.Windows.Forms.Cursors.Default
        Appearance15.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddKieu_Kiem_Hoa.DisplayLayout.Appearance = Appearance15
        UltraGridColumn16.Header.VisiblePosition = 0
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 1
        UltraGridColumn17.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(175, 0)
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn16, UltraGridColumn17})
        UltraGridBand3.UseRowLayout = True
        Me.ddKieu_Kiem_Hoa.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Appearance16.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance16.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance16.ForeColor = System.Drawing.Color.Black
        Appearance16.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddKieu_Kiem_Hoa.DisplayLayout.Override.HeaderAppearance = Appearance16
        Me.ddKieu_Kiem_Hoa.DisplayMember = "Ten_Loai"
        Me.ddKieu_Kiem_Hoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddKieu_Kiem_Hoa.Location = New System.Drawing.Point(136, 160)
        Me.ddKieu_Kiem_Hoa.Name = "ddKieu_Kiem_Hoa"
        Me.ddKieu_Kiem_Hoa.Size = New System.Drawing.Size(208, 96)
        Me.ddKieu_Kiem_Hoa.TabIndex = 15
        Me.ddKieu_Kiem_Hoa.Text = "Tiền tệ"
        Me.ddKieu_Kiem_Hoa.ValueMember = "Ma_Loai"
        Me.ddKieu_Kiem_Hoa.Visible = False
        '
        'Frm_Tim_Kiem_To_Khai
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 517)
        Me.Controls.Add(Me.ddKieu_Kiem_Hoa)
        Me.Controls.Add(Me.cbLoai_To_Khai)
        Me.Controls.Add(Me.txtSo_To_Khai)
        Me.Controls.Add(Me.txtMaE1)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.CbTu_Ngay)
        Me.Controls.Add(Me.UltraLabel4)
        Me.Controls.Add(Me.CbDen_Ngay)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnTimToKhai)
        Me.Controls.Add(Me.UltraLabel5)
        Me.Controls.Add(Me.UltraLabel6)
        Me.Controls.Add(Me.txtTong_So)
        Me.Controls.Add(Me.dgToKhaiHaiQuanXuat)
        Me.Name = "Frm_Tim_Kiem_To_Khai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tìm kiếm tờ khai hải quan"
        CType(Me.dgToKhaiHaiQuanXuat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbTu_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbDen_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTong_So, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbLoai_To_Khai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddKieu_Kiem_Hoa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "------------Khai bao bien cho Form---------"
    Dim myToKhaiHaiQuanXuat As New To_Khai_Hai_Quan_Xuat(GConnectionString)
    Dim myHam_Dung_Chung As New Ham_Dung_Chung
#End Region

#Region "-------------Form Load--------------"
    Private Sub Frm_Tim_Kiem_To_Khai_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mDataTmp As New DataTable
        CbTu_Ngay.Value = myHam_Dung_Chung.ConvertIntToDate(myHam_Dung_Chung.MinusIntDate(myHam_Dung_Chung.ConvertDateToInt(Now.Date), GSo_Ngay_E1_Duoc_Trung))
        CbDen_Ngay.Value = Now.Date
        Tao_Bang_Phan_Loai_Kiem_Hoa()
        mDataTmp = myToKhaiHaiQuanXuat.To_Khai_Hai_Quan_Xuat_Danh_Sach_Tim_Kiem(1, myHam_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), myHam_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), "", 0, "").Tables(0)
        DataGrid_To_Khai(mDataTmp)
        txtMaE1.Select()
    End Sub
#End Region

#Region "------------Form Close------------"
    Private Sub Frm_Tim_Kiem_To_Khai_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        'GFrm_Is_Tim_Kiem = False
    End Sub
#End Region

#Region "-----------Tab Control Got_Focus-----------"
    Private Sub CbTu_Ngay_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbTu_Ngay.GotFocus
        CbTu_Ngay.SelectionStart = 0
        CbTu_Ngay.SelectionLength = CbTu_Ngay.Text.Length
    End Sub

    Private Sub CbDen_Ngay_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbDen_Ngay.GotFocus
        CbDen_Ngay.SelectionStart = 0
        CbDen_Ngay.SelectionLength = CbDen_Ngay.Text.Length
    End Sub

    Private Sub txtMaE1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMaE1.GotFocus
        txtMaE1.SelectionStart = 0
        txtMaE1.SelectionLength = txtMaE1.Text.Length
    End Sub

    Private Sub txtSo_To_Khai_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSo_To_Khai.GotFocus
        txtSo_To_Khai.SelectionStart = 0
        txtSo_To_Khai.SelectionLength = txtSo_To_Khai.Text.Length
    End Sub
#End Region

#Region "-------------Tab Control KeyDown-------------"
    Private Sub CbDen_Ngay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CbDen_Ngay.KeyDown, cbLoai_To_Khai.KeyDown, CbTu_Ngay.KeyDown
        If e.KeyValue = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
        End If
    End Sub

#Region "------------txtMaE1_KeyDown--------"
    Private Sub txtMaE1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMaE1.KeyDown
        If e.KeyValue = Keys.Enter Then
            btnTimToKhai.Select()
        End If
    End Sub
#End Region
#End Region

#Region "-------------Tab Control ---------------"
#Region "------------btnTimToKhai_Click--------"
    Private Sub btnTimToKhai_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTimToKhai.Click
        Dim mDataTmp As New DataTable
        Dim iKieu As Integer
        Dim iMa_E1 As Byte
        Dim iLoai_To_Khai As Byte
        Dim iSo_To_Khai As Byte
        'txtMa_E1
        If txtMaE1.Text <> "" Then
            iMa_E1 = 1
        Else
            iMa_E1 = 0
        End If
        'cbLoai_To_Khai
        If cbLoai_To_Khai.Text <> "" Then
            iLoai_To_Khai = 1
        Else
            iLoai_To_Khai = 0
        End If
        'txtSo_To_Khai
        If txtSo_To_Khai.Text <> "" Then
            iSo_To_Khai = 1
        Else
            iSo_To_Khai = 0
        End If
        iKieu = iSo_To_Khai * 1 + iLoai_To_Khai * 2 + iMa_E1 * 4
        If iKieu = 0 Then
            MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtMaE1.Select()
            Exit Sub
        End If
        mDataTmp = myToKhaiHaiQuanXuat.To_Khai_Hai_Quan_Xuat_Danh_Sach_Tim_Kiem(iKieu, myHam_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), myHam_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), txtMaE1.Text, IIf(cbLoai_To_Khai.Value Is DBNull.Value, 0, cbLoai_To_Khai.Value), txtSo_To_Khai.Text).Tables(0)
        DataGrid_To_Khai(mDataTmp)
        If dgToKhaiHaiQuanXuat.Rows.Count > 0 Then
            dgToKhaiHaiQuanXuat.Select()
            dgToKhaiHaiQuanXuat.ActiveCell = dgToKhaiHaiQuanXuat.Rows(0).Cells("Mo_To_Khai")
            dgToKhaiHaiQuanXuat.PerformAction(EnterEditMode, False, False)
        Else
            MessageBox.Show("Không tìm thấy tờ khai nào thoả mãn điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK)
            txtMaE1.Select()
        End If
    End Sub
#End Region

#Region "------------btnThoat_Click-------------"
    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
        Me.Dispose()
    End Sub
#End Region

#Region "-----------txtSo_To_Khai_Validated------------"
    Private Sub txtSo_To_Khai_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSo_To_Khai.Validated
        If txtSo_To_Khai.Text <> "" Then
            txtSo_To_Khai.Text = Format_So_TKHQ(CInt(txtSo_To_Khai.Text))
        End If
    End Sub
#End Region

#Region "-------------dgToKhaiHaiQuanXuat----------"
#Region "--------------dgToKhaiHaiQuanXuat_InitializeLayout------------"
    Private Sub dgToKhaiHaiQuanXuat_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgToKhaiHaiQuanXuat.InitializeLayout
        Dim i As Integer
        dgToKhaiHaiQuanXuat.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        dgToKhaiHaiQuanXuat.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
        dgToKhaiHaiQuanXuat.DisplayLayout.Bands(0).Columns("Kieu_Kiem_Hoa").Style = ColumnStyle.DropDownValidate
        dgToKhaiHaiQuanXuat.DisplayLayout.Bands(0).Columns("Kieu_Kiem_Hoa").ValueList = ddKieu_Kiem_Hoa

        For i = 0 To dgToKhaiHaiQuanXuat.DisplayLayout.Bands(0).Columns.Count - 1
            dgToKhaiHaiQuanXuat.DisplayLayout.Bands(0).Columns(i).CellActivation = Activation.ActivateOnly
        Next

        txtTong_So.Text = dgToKhaiHaiQuanXuat.Rows.Count
        '        dgToKhaiHaiQuanXuat.DisplayLayout.Bands(0).Columns(0).CellActivation = Activation.AllowEdit
    End Sub
#End Region

#Region "-------------dgToKhaiHaiQuanXuat_ClickCellButton-----------"
    Private Sub dgToKhaiHaiQuanXuat_ClickCellButton(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgToKhaiHaiQuanXuat.ClickCellButton
        If dgToKhaiHaiQuanXuat.ActiveRow.Cells("Ma_To_Khai").Text = "" Then
            Exit Sub
        End If
        If GPost_Office = 2 Then
            Dim frmToKhai As New Frm_Lap_To_Khai_Hang_Xuat_HCM
            'Lay thong tin de mo to khai
            frmToKhai.GFrm_Is_Tim_Kiem = True
            frmToKhai.GFrm_Ma_To_Khai = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Ma_To_Khai").Text
            frmToKhai.GFrm_Ngay_Dang_Ky = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Ngay_Khai").Value
            frmToKhai.GFrm_Kieu_Kiem_Hoa = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Kieu_Kiem_Hoa").Value
            frmToKhai.GFrm_So_To_Khai = CInt(dgToKhaiHaiQuanXuat.ActiveRow.Cells("So_TKHQ").Text)
            frmToKhai.ShowDialog()
        Else
            Dim frmToKhai As New Frm_Lap_To_Khai_Hang_Xuat
            'Lay thong tin de mo to khai
            frmToKhai.GFrm_Is_Tim_Kiem = True
            frmToKhai.GFrm_Ma_To_Khai = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Ma_To_Khai").Text
            frmToKhai.GFrm_Ngay_Dang_Ky = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Ngay_Khai").Value
            frmToKhai.GFrm_Kieu_Kiem_Hoa = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Kieu_Kiem_Hoa").Value
            frmToKhai.GFrm_So_To_Khai = CInt(dgToKhaiHaiQuanXuat.ActiveRow.Cells("So_TKHQ").Text)
            frmToKhai.ShowDialog()
        End If
        
    End Sub
#End Region

#End Region

#End Region

#Region "-------------Ham nguoi dung-------------"
#Region "-----------------Tạo bảng phân loại kiểm hoá-------------------"
    Private Sub Tao_Bang_Phan_Loai_Kiem_Hoa()
        'Co 3 he thong to khai tuong ung voi 3 loai sau
        '---1. Loai = 5: So to khai hang vien tro
        '---2. Loai = 9: So to khai hang xuat khau
        '---3. Loai = con lai: So to khai hang nhap khau

        'Them moi mot bang
        Dim dataTable As New dataTable("Loai_Kiem_Hoa")

        'Tao ra cac cot cua bang nay
        Dim colWork As DataColumn = New DataColumn("Ma_Loai", GetType(Int32))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Ten_Loai", GetType(String))
        dataTable.Columns.Add(colWork)

        'A. ------------- SO TO KHAI HANG NHAP KHAU
        'Them du lieu vao
        Dim row As DataRow
        '0.--------Tai lieu (D)                 ---- Inlist (HQ01 + HQ02)
        'row = dataTable.NewRow
        'row("Ma_Loai") = 0
        'row("Ten_Loai") = "Tài liệu"
        'dataTable.Rows.Add(row)

        ''1.--------Hang Hoa (M) soi may         ---- Inlist (HQ01 + HQ02)
        'row = dataTable.NewRow
        'row("Ma_Loai") = 1
        'row("Ten_Loai") = "Soi máy"
        'dataTable.Rows.Add(row)

        ''2.--------Hang PMD co thue (M)         ---- To khai HQ02    
        'row = dataTable.NewRow
        'row("Ma_Loai") = 2
        'row("Ten_Loai") = "Có thuế"
        'dataTable.Rows.Add(row)

        ''3.--------Hang chuyen hoan             ---- Inlist (HQ01 + HQ02)
        'row = dataTable.NewRow
        'row("Ma_Loai") = 3
        'row("Ten_Loai") = "Chuyển hoàn"
        'dataTable.Rows.Add(row)

        ''----------Hang mien kiem (Dai su quan, Lanh su quan)
        ''4.--------Hang mien kiem (M)           ---- Inlist (HQ01 + HQ02)
        'row = dataTable.NewRow
        'row("Ma_Loai") = 4
        'row("Ten_Loai") = "Miễn kiểm"
        'dataTable.Rows.Add(row)

        ''B. ------------- SO TO KHAI HANG VIEN TRO
        ''5.--------Hàng viện trợ                ---- Inlist (HQ01 + HQ02)
        'row = dataTable.NewRow
        'row("Ma_Loai") = 5
        'row("Ten_Loai") = "Viện trợ"
        'dataTable.Rows.Add(row)

        '''Hang mo kiem tinh thue = 0(chuyen loai)        
        ''6.--------Hang mau dich (M)            ---- Inlist (HQ01 + HQ02)
        'row = dataTable.NewRow
        'row("Ma_Loai") = 6
        'row("Ten_Loai") = "Mở kiểm không thuế"
        'dataTable.Rows.Add(row)

        ''7.--------Hang hanh ly & mien thue (mo kiem nhung khong khai thue)
        'row = dataTable.NewRow
        'row("Ma_Loai") = 7
        'row("Ten_Loai") = "Hành lý & miễn thuế"
        'dataTable.Rows.Add(row)

        'C. ------------- SO TO KHAI HANG XUAT KHAU
        '9.--------Hang QT chuyen hoan và hàng VN xuất đi QT
        row = dataTable.NewRow
        row("Ma_Loai") = 9
        row("Ten_Loai") = "Hàng xuất đi QT"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Ma_Loai") = 10
        row("Ten_Loai") = "Hàng chuyển hoàn đi Q.Tế"
        dataTable.Rows.Add(row)

        'Load Data
        cbLoai_To_Khai.DataSource = dataTable
        cbLoai_To_Khai.DataBind()
        cbLoai_To_Khai.Value = 9

        ddKieu_Kiem_Hoa.DataSource = dataTable
        ddKieu_Kiem_Hoa.DataBind()
    End Sub
#End Region

#Region "---------------DataGrid_To_Khai--------------"
    Private Sub DataGrid_To_Khai(ByVal mData As DataTable)
        dgToKhaiHaiQuanXuat.DataSource = mData
        dgToKhaiHaiQuanXuat.DataBind()
    End Sub
#End Region

#End Region

    Private Sub txtMaE1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMaE1.LostFocus
        txtMaE1.Text = txtMaE1.Text.ToUpper
    End Sub

    Private Sub txtMaE1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMaE1.Validated
        If txtMaE1.Text.Trim <> "" Then
            If txtMaE1.Text.Trim.Length < 6 Then
                MessageBox.Show("Thông tin mã E1 không hợp lệ, phải nhập tối thiểu là 6 ký tự!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtMaE1.Select()
            End If
        End If
    End Sub

    Private Sub txtSo_To_Khai_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSo_To_Khai.KeyDown
        If e.KeyValue = Keys.Enter Then
            btnTimToKhai.Select()
        End If
    End Sub

End Class

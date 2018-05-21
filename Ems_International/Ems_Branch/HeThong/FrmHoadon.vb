Imports Ems_International_Logic.EMS
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction

Public Class FrmHoadon
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
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents dgHoaDon As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ddKhach_Hang As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents dtpdenngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtptungay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Khach_Hang", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_KH")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Khach_Hang")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Khoi_Tao")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Ket_Thuc")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dien_Thoai")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fax")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Email")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_So_Thue")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vat")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khach_Hang_Toan_Quoc")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Khai_Thac")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Hoa_Don", -1)
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Hoa_Don")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Seri")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Hoa_Don")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_KH")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Khach_Hang")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_So_Thue")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Xuat")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Nop")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gia_Tri")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vat")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Kieu_Thanh_Toan")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Da_Tra")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ghi_Chu")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.Button1 = New System.Windows.Forms.Button
        Me.dtpdenngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtptungay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label3 = New System.Windows.Forms.Label
        Me.ddKhach_Hang = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.dgHoaDon = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.dtpdenngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtptungay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddKhach_Hang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgHoaDon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.Button1)
        Me.UltraTabPageControl1.Controls.Add(Me.dtpdenngay)
        Me.UltraTabPageControl1.Controls.Add(Me.Label4)
        Me.UltraTabPageControl1.Controls.Add(Me.dtptungay)
        Me.UltraTabPageControl1.Controls.Add(Me.Label3)
        Me.UltraTabPageControl1.Controls.Add(Me.ddKhach_Hang)
        Me.UltraTabPageControl1.Controls.Add(Me.dgHoaDon)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(2, 24)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1180, 446)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(712, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 24)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        '
        'dtpdenngay
        '
        Me.dtpdenngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpdenngay.Location = New System.Drawing.Point(600, 16)
        Me.dtpdenngay.Name = "dtpdenngay"
        Me.dtpdenngay.Size = New System.Drawing.Size(89, 21)
        Me.dtpdenngay.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label4.Location = New System.Drawing.Point(536, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Đến ngày"
        '
        'dtptungay
        '
        Me.dtptungay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtptungay.Location = New System.Drawing.Point(424, 16)
        Me.dtptungay.Name = "dtptungay"
        Me.dtptungay.Size = New System.Drawing.Size(89, 21)
        Me.dtptungay.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label3.Location = New System.Drawing.Point(360, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Từ Ngày"
        '
        'ddKhach_Hang
        '
        Me.ddKhach_Hang.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance1.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddKhach_Hang.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12})
        Me.ddKhach_Hang.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance2.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.ForeColor = System.Drawing.Color.Black
        Appearance2.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddKhach_Hang.DisplayLayout.Override.HeaderAppearance = Appearance2
        Me.ddKhach_Hang.DisplayMember = "Ma_KH"
        Me.ddKhach_Hang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddKhach_Hang.Location = New System.Drawing.Point(200, 168)
        Me.ddKhach_Hang.Name = "ddKhach_Hang"
        Me.ddKhach_Hang.Size = New System.Drawing.Size(208, 128)
        Me.ddKhach_Hang.TabIndex = 5
        Me.ddKhach_Hang.ValueMember = "Ma_KH"
        Me.ddKhach_Hang.Visible = False
        '
        'dgHoaDon
        '
        Me.dgHoaDon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgHoaDon.DisplayLayout.AddNewBox.Prompt = " "
        Appearance3.BackColor = System.Drawing.Color.White
        Appearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgHoaDon.DisplayLayout.Appearance = Appearance3
        UltraGridColumn13.Header.VisiblePosition = 13
        UltraGridColumn13.Hidden = True
        Appearance4.TextHAlign = Infragistics.Win.HAlign.Left
        UltraGridColumn14.Header.Appearance = Appearance4
        UltraGridColumn14.Header.Caption = "Số Seri"
        UltraGridColumn14.Header.VisiblePosition = 0
        UltraGridColumn14.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn14.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn14.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn14.MaskInput = "AA/####A"
        UltraGridColumn14.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn14.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn14.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn14.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn15.Header.Caption = "Số hóa đơn"
        UltraGridColumn15.Header.VisiblePosition = 1
        UltraGridColumn15.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn15.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn15.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn15.MaskInput = ""
        UltraGridColumn15.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn15.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn15.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn15.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn16.Header.Caption = "Mã khách hàng"
        UltraGridColumn16.Header.VisiblePosition = 5
        UltraGridColumn16.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn16.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn16.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn16.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn17.Header.Caption = "Tên khách hàng"
        UltraGridColumn17.Header.VisiblePosition = 2
        UltraGridColumn17.Hidden = True
        UltraGridColumn17.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn17.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn17.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn17.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn18.Header.Caption = "Ðịa chỉ"
        UltraGridColumn18.Header.VisiblePosition = 3
        UltraGridColumn18.Hidden = True
        UltraGridColumn18.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn18.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn18.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn18.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn19.Header.Caption = "Mã số thuế"
        UltraGridColumn19.Header.VisiblePosition = 4
        UltraGridColumn19.MaskInput = ""
        UltraGridColumn19.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn19.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn19.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn19.RowLayoutColumnInfo.SpanY = 2
        Appearance5.Tag = New Date(CType(0, Long))
        UltraGridColumn20.CellButtonAppearance = Appearance5
        UltraGridColumn20.Format = ""
        UltraGridColumn20.Header.Caption = "Ngày xuất"
        UltraGridColumn20.Header.VisiblePosition = 6
        UltraGridColumn20.MaskInput = ""
        UltraGridColumn20.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn20.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn20.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn20.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn21.Header.Caption = "Ngày nộp"
        UltraGridColumn21.Header.VisiblePosition = 7
        UltraGridColumn21.MaskInput = ""
        UltraGridColumn21.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn21.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn21.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn21.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn22.Header.Caption = "Giá trị"
        UltraGridColumn22.Header.VisiblePosition = 8
        UltraGridColumn22.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn22.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn22.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn22.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn23.Header.VisiblePosition = 9
        UltraGridColumn23.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn23.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn23.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn23.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn24.Header.Caption = "Kiểu thanh toán"
        UltraGridColumn24.Header.VisiblePosition = 10
        UltraGridColumn24.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn24.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn24.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn24.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn25.Header.Caption = "Ðã trả"
        UltraGridColumn25.Header.VisiblePosition = 11
        UltraGridColumn25.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn25.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn25.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn25.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn26.Header.Caption = "Ghi chú"
        UltraGridColumn26.Header.VisiblePosition = 12
        UltraGridColumn26.RowLayoutColumnInfo.OriginX = 24
        UltraGridColumn26.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn26.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn26.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26})
        UltraGridBand2.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand2.UseRowLayout = True
        Me.dgHoaDon.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.dgHoaDon.DisplayLayout.InterBandSpacing = 10
        Me.dgHoaDon.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Me.dgHoaDon.DisplayLayout.Override.CardAreaAppearance = Appearance6
        Me.dgHoaDon.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance7.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance7.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance7.ForeColor = System.Drawing.Color.Black
        Appearance7.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance7.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgHoaDon.DisplayLayout.Override.HeaderAppearance = Appearance7
        Me.dgHoaDon.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance8.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgHoaDon.DisplayLayout.Override.RowAppearance = Appearance8
        Appearance9.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance9.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgHoaDon.DisplayLayout.Override.RowSelectorAppearance = Appearance9
        Me.dgHoaDon.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgHoaDon.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance10.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance10.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance10.ForeColor = System.Drawing.Color.Black
        Me.dgHoaDon.DisplayLayout.Override.SelectedRowAppearance = Appearance10
        Me.dgHoaDon.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgHoaDon.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgHoaDon.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.dgHoaDon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgHoaDon.Location = New System.Drawing.Point(16, 64)
        Me.dgHoaDon.Name = "dgHoaDon"
        Me.dgHoaDon.Size = New System.Drawing.Size(1008, 376)
        Me.dgHoaDon.TabIndex = 4
        Me.dgHoaDon.Text = "Hóa Ðon"
        Me.dgHoaDon.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChange
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 32)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(1184, 472)
        Me.UltraTabControl1.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Hóa Ðon"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1180, 446)
        '
        'UltraDataSource1
        '
        Me.UltraDataSource1.Band.Key = "Nguoi_Dung"
        '
        'FrmHoadon
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1040, 501)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Name = "FrmHoadon"
        Me.Text = "FrmHoadon"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.dtpdenngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtptungay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddKhach_Hang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgHoaDon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim myhamdungchung As New Ham_Dung_Chung
    Dim myHoa_Don As New Hoa_Don(GConnectionString)
    Dim mydata As DataTable
    Dim mychucnang As New Chuc_Nang(GConnectionString)
    Dim myKhachHang As New Khach_Hang(GConnectionString)
    Dim mykhachhangchitiet As New Khach_Hang_Chi_Tiet
    Dim myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    
    Private mycell As Infragistics.Win.UltraWinGrid.UltraGridCell

    Private Sub FrmHoadon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DatagridBinding()
        DataDropKhach_Hang()

        dtptungay.Value = CDate(Date.Now)
        dtpdenngay.Value = myhamdungchung.dEndMonth(Date.Now)

    End Sub
    Private Sub DatagridBinding()
        dgHoaDon.DataSource = myHoa_Don.Danh_Sach_Lay_Theo_Ngay(myhamdungchung.ConvertDateToInt(dtptungay.Value), myhamdungchung.ConvertDateToInt(dtpdenngay.Value))
        dgHoaDon.DataBind()
        dgHoaDon.Rows.Band.AddNew()
    End Sub

    Private Sub DataDropKhach_Hang()
        ddKhach_Hang.DataSource = myKhachHang.Danh_Sach.Tables(0)
        ddKhach_Hang.DataBind()
    End Sub


    Private Sub dgNguoiDung_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgHoaDon.InitializeLayout
        With dgHoaDon.DisplayLayout
            .Bands(0).Columns("Ma_KH").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Ma_KH").ValueList = ddKhach_Hang
        End With
    End Sub

    Private Sub dgHoaDon_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgHoaDon.KeyDown
        If e.KeyValue < Keys.Space And e.KeyValue <> Keys.Enter Then Exit Sub
        myGridKeyDown = sender
        If Not mycell Is Nothing Then
            e.Handled = True
            myGridKeyDown.ActiveCell = mycell
            myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
            mycell = Nothing
        End If
        Select Case e.KeyValue
            Case Keys.Right
                mycell = Nothing
                myGridKeyDown.PerformAction(ExitEditMode, False, False)
                e.Handled = True
                myGridKeyDown.PerformAction(EnterEditModeAndDropdown, False, False)
            Case Keys.Enter
                myGridKeyDown.PerformAction(ExitEditMode, False, False)
                myGridKeyDown.PerformAction(NextCellByTab, False, False)
                e.Handled = True
                myGridKeyDown.PerformAction(EnterEditMode, False, False)
            Case Keys.F8
                DeleteRow()
                e.Handled = True
        End Select
    End Sub
    Private Sub DeleteRow()
        If dgHoaDon.Rows(dgHoaDon.ActiveRow.Index).Cells("So_Seri").Text.Length <> 0 Then
            If MessageBox.Show("Bạn có thực sự muốn xóa mã này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                myHoa_Don.Xoa_boi_So_Seri(dgHoaDon.Rows(dgHoaDon.ActiveRow.Index).Cells("So_Seri").Text)
                dgHoaDon.ActiveRow.Delete(False)
                CMessageBox.Show("Đã xóa thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub dgHoaDon_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgHoaDon.AfterRowUpdate
        'Kiểm tra việc nhập vào các row
        If dgHoaDon.Rows(dgHoaDon.ActiveRow.Index).Cells("So_Seri").Text = "" Then
            Exit Sub
        End If
        If dgHoaDon.Rows(dgHoaDon.ActiveRow.Index).Cells("So_Hoa_Don").Text = "" Then
            Exit Sub
        End If
        If dgHoaDon.Rows(dgHoaDon.ActiveRow.Index).Cells("Ma_KH").Text = "" Then
            Exit Sub
        End If
        If dgHoaDon.Rows(dgHoaDon.ActiveRow.Index).Cells("Ma_So_Thue").Text = "" Then
            Exit Sub
        End If
        If dgHoaDon.Rows(dgHoaDon.ActiveRow.Index).Cells("Ngay_Xuat").Text.Length = 0 Then
            Exit Sub
        End If
        If dgHoaDon.Rows(dgHoaDon.ActiveRow.Index).Cells("Ngay_Nop").Text.Length = 0 Then
            Exit Sub
        End If
        If dgHoaDon.Rows(dgHoaDon.ActiveRow.Index).Cells("Gia_Tri").Text.Length = 0 Then
            Exit Sub
        End If
        If dgHoaDon.Rows(dgHoaDon.ActiveRow.Index).Cells("Vat").Text.Length = 0 Then
            Exit Sub
        End If
        If dgHoaDon.Rows(dgHoaDon.ActiveRow.Index).Cells("Kieu_Thanh_Toan").Text.Length = 0 Then
            Exit Sub
        End If
        If dgHoaDon.Rows(dgHoaDon.ActiveRow.Index).Cells("Da_Tra").Text.Length = 0 Then
            Exit Sub
        End If
        If dgHoaDon.Rows(dgHoaDon.ActiveRow.Index).Cells("Ghi_Chu").Text = "" Then
            Exit Sub
        End If

        Dim Id_Hoa_Don As String
        Id_Hoa_Don = CreateId_Hoa_Don(dgHoaDon.Rows(dgHoaDon.ActiveRow.Index).Cells("So_Seri").Text, dgHoaDon.Rows(dgHoaDon.ActiveRow.Index).Cells("So_Hoa_Don").Text)
        mykhachhangchitiet = myKhachHang.Lay(dgHoaDon.Rows(dgHoaDon.ActiveRow.Index).Cells("Ma_KH").Value)
        If dgHoaDon.Rows(dgHoaDon.ActiveRow.Index).Cells("Ma_KH").Text <> "" Then
            'Update hoa don
            myHoa_Don.Cap_Nhat_Them(Id_Hoa_Don, dgHoaDon.Rows(dgHoaDon.ActiveRow.Index).Cells("So_Seri").Text, dgHoaDon.Rows(dgHoaDon.ActiveRow.Index).Cells("So_Hoa_Don").Text, mykhachhangchitiet.Ten_Khach_Hang, dgHoaDon.Rows(dgHoaDon.ActiveRow.Index).Cells("Dia_Chi").Text, dgHoaDon.Rows(dgHoaDon.ActiveRow.Index).Cells("Ma_So_Thue").Text, dgHoaDon.Rows(dgHoaDon.ActiveRow.Index).Cells("Ma_KH").Value, Ham_Dung_Chung.ConvertDateToInt(dgHoaDon.Rows(dgHoaDon.ActiveRow.Index).Cells("Ngay_Xuat").Value), Ham_Dung_Chung.ConvertDateToInt(dgHoaDon.Rows(dgHoaDon.ActiveRow.Index).Cells("Ngay_Nop").Value), dgHoaDon.Rows(dgHoaDon.ActiveRow.Index).Cells("Gia_Tri").Text, dgHoaDon.Rows(dgHoaDon.ActiveRow.Index).Cells("Vat").Text, dgHoaDon.Rows(dgHoaDon.ActiveRow.Index).Cells("Kieu_Thanh_Toan").Text, dgHoaDon.Rows(dgHoaDon.ActiveRow.Index).Cells("Da_Tra").Value, dgHoaDon.Rows(dgHoaDon.ActiveRow.Index).Cells("Ghi_Chu").Text)
        End If
    End Sub
    Private Sub AddNewRow(ByVal sender As Object)
        myGridKeyDown = sender
        'If myGridKeyDown.Rows.Count > 0 Then
        '    If myGridKeyDown.Rows(myGridKeyDown.Rows.Count - 1).HasNextSibling = False Then
        '        myGridKeyDown.Rows.Band.AddNew()
        '    End If
        'End If
        If Not myGridKeyDown.ActiveCell Is Nothing Then
            If myGridKeyDown.ActiveCell.Row.HasNextSibling = False Then
                myGridKeyDown.Rows.Band.AddNew()
            End If
        End If
    End Sub
    Private Sub dgHoaDon_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgHoaDon.AfterCellUpdate
        If e.Cell.Row.Cells("So_Seri").IsActiveCell Then
            AddNewRow(sender)
            If dgHoaDon.Rows(dgHoaDon.ActiveRow.Index).Cells("Da_Tra").Value Is System.DBNull.Value Then
                dgHoaDon.Rows(dgHoaDon.ActiveRow.Index).Cells("Da_Tra").Value = False
            End If
        End If
    End Sub

    Private Sub dgHoaDon_BeforeExitEditMode(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeExitEditModeEventArgs) Handles dgHoaDon.BeforeExitEditMode
        Select Case dgHoaDon.ActiveCell.Column.Key
            Case "So_Hoa_Don"
                If dgHoaDon.ActiveCell.Text.Length = 0 Then
                    MessageBox.Show("Ko de trong So hoa don", "Thong bao")
                    mycell = dgHoaDon.ActiveCell
                    Exit Sub
                End If
        End Select
    End Sub

    Private Sub UltraDataSource1_CellDataRequested(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinDataSource.CellDataRequestedEventArgs) Handles UltraDataSource1.CellDataRequested

    End Sub

    Private Sub dgHoaDon_BeforeCellDeactivate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dgHoaDon.BeforeCellDeactivate
        myGridKeyDown = sender
        If Not mycell Is Nothing Then
            e.Cancel = True
            myGridKeyDown.ActiveCell = mycell
            myGridKeyDown.PerformAction( _
                Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode _
              , False _
              , False)
            mycell = Nothing
        End If
    End Sub

    Private Sub ddKhach_Hang_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles ddKhach_Hang.InitializeLayout

    End Sub

    Private Sub UltraTabPageControl1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles UltraTabPageControl1.Paint

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DatagridBinding()
    End Sub

End Class


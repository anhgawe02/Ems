Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Ems_International_Logic.EMS
Public Class FrmDinhVi
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMaE1 As System.Windows.Forms.TextBox
    Friend WithEvents btnDinhVi As System.Windows.Forms.Button
    Friend WithEvents dgDinhVi As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgChiTiet As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dtpNgayDinhDang As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Trang_Thai", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Trang_Thai")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Trang_Thai")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_E1")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Trang_Thai")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Chi_Tiet", -1)
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Dong")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Dong")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Goc")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Tra")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chuyen_Thu")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tui_So", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.dgDinhVi = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.txtMaE1 = New System.Windows.Forms.TextBox
        Me.btnDinhVi = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgChiTiet = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.dtpNgayDinhDang = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        CType(Me.dgDinhVi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgChiTiet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpNgayDinhDang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgDinhVi
        '
        Me.dgDinhVi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgDinhVi.DisplayLayout.AddNewBox.Prompt = " "
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgDinhVi.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.EditorControl = Me.dtpNgayDinhDang
        UltraGridColumn1.Header.Caption = "Ngày"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn1.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(97, 0)
        UltraGridColumn1.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn1.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn2.Header.Caption = "Giờ"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn2.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn2.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn2.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn3.Header.Caption = "Mã E1"
        UltraGridColumn3.Header.VisiblePosition = 3
        UltraGridColumn3.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn3.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn3.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn3.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn4.Header.Caption = "MABC"
        UltraGridColumn4.Header.VisiblePosition = 2
        UltraGridColumn4.MaskInput = ""
        UltraGridColumn4.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn4.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(116, 0)
        UltraGridColumn4.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn4.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn5.Header.Caption = "Trạng Thái"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn5.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn5.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn5.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5})
        UltraGridBand1.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand1.UseRowLayout = True
        Me.dgDinhVi.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.dgDinhVi.DisplayLayout.InterBandSpacing = 10
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.dgDinhVi.DisplayLayout.Override.CardAreaAppearance = Appearance2
        Me.dgDinhVi.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.ForeColor = System.Drawing.Color.Black
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgDinhVi.DisplayLayout.Override.HeaderAppearance = Appearance3
        Me.dgDinhVi.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance4.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDinhVi.DisplayLayout.Override.RowAppearance = Appearance4
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgDinhVi.DisplayLayout.Override.RowSelectorAppearance = Appearance5
        Me.dgDinhVi.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgDinhVi.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance6.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.dgDinhVi.DisplayLayout.Override.SelectedRowAppearance = Appearance6
        Me.dgDinhVi.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDinhVi.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgDinhVi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDinhVi.Location = New System.Drawing.Point(0, 280)
        Me.dgDinhVi.Name = "dgDinhVi"
        Me.dgDinhVi.Size = New System.Drawing.Size(816, 288)
        Me.dgDinhVi.TabIndex = 5
        '
        'txtMaE1
        '
        Me.txtMaE1.Location = New System.Drawing.Point(72, 0)
        Me.txtMaE1.Name = "txtMaE1"
        Me.txtMaE1.Size = New System.Drawing.Size(144, 20)
        Me.txtMaE1.TabIndex = 6
        Me.txtMaE1.Text = ""
        '
        'btnDinhVi
        '
        Me.btnDinhVi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDinhVi.ForeColor = System.Drawing.Color.Black
        Me.btnDinhVi.Location = New System.Drawing.Point(216, 0)
        Me.btnDinhVi.Name = "btnDinhVi"
        Me.btnDinhVi.Size = New System.Drawing.Size(144, 24)
        Me.btnDinhVi.TabIndex = 7
        Me.btnDinhVi.Text = "Định Vị"
        Me.btnDinhVi.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Mã  E1"
        '
        'dgChiTiet
        '
        Me.dgChiTiet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgChiTiet.DisplayLayout.AddNewBox.Prompt = " "
        Appearance7.BackColor = System.Drawing.Color.White
        Appearance7.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgChiTiet.DisplayLayout.Appearance = Appearance7
        UltraGridColumn6.EditorControl = Me.dtpNgayDinhDang
        UltraGridColumn6.Header.Caption = "Ngày đóng"
        UltraGridColumn6.Header.VisiblePosition = 0
        UltraGridColumn7.Header.Caption = "Giờ đóng"
        UltraGridColumn7.Header.VisiblePosition = 1
        UltraGridColumn8.Header.Caption = "BC Nhận"
        UltraGridColumn8.Header.VisiblePosition = 2
        UltraGridColumn9.Header.Caption = "BC Trả"
        UltraGridColumn9.Header.VisiblePosition = 3
        UltraGridColumn10.Header.Caption = "Khối Lượng"
        UltraGridColumn10.Header.VisiblePosition = 4
        UltraGridColumn11.Header.Caption = "Chuyến Thư"
        UltraGridColumn11.Header.VisiblePosition = 5
        UltraGridColumn12.Header.Caption = "Túi Số"
        UltraGridColumn12.Header.VisiblePosition = 6
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12})
        UltraGridBand2.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand2.UseRowLayout = True
        Me.dgChiTiet.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.dgChiTiet.DisplayLayout.InterBandSpacing = 10
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Me.dgChiTiet.DisplayLayout.Override.CardAreaAppearance = Appearance8
        Me.dgChiTiet.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance9.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance9.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance9.ForeColor = System.Drawing.Color.Black
        Appearance9.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance9.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgChiTiet.DisplayLayout.Override.HeaderAppearance = Appearance9
        Me.dgChiTiet.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance10.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgChiTiet.DisplayLayout.Override.RowAppearance = Appearance10
        Appearance11.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance11.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgChiTiet.DisplayLayout.Override.RowSelectorAppearance = Appearance11
        Me.dgChiTiet.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgChiTiet.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance12.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance12.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance12.ForeColor = System.Drawing.Color.Black
        Me.dgChiTiet.DisplayLayout.Override.SelectedRowAppearance = Appearance12
        Me.dgChiTiet.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgChiTiet.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgChiTiet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgChiTiet.Location = New System.Drawing.Point(0, 24)
        Me.dgChiTiet.Name = "dgChiTiet"
        Me.dgChiTiet.Size = New System.Drawing.Size(816, 256)
        Me.dgChiTiet.TabIndex = 9
        Me.dgChiTiet.Text = "Định Vi Bưu Phẩm"
        '
        'dtpNgayDinhDang
        '
        Me.dtpNgayDinhDang.DateTime = New Date(2008, 8, 3, 0, 0, 0, 0)
        Me.dtpNgayDinhDang.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpNgayDinhDang.Location = New System.Drawing.Point(696, 256)
        Me.dtpNgayDinhDang.Name = "dtpNgayDinhDang"
        Me.dtpNgayDinhDang.Size = New System.Drawing.Size(88, 21)
        Me.dtpNgayDinhDang.TabIndex = 56
        Me.dtpNgayDinhDang.Value = New Date(2008, 8, 3, 0, 0, 0, 0)
        Me.dtpNgayDinhDang.Visible = False
        '
        'FrmDinhVi
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(816, 573)
        Me.Controls.Add(Me.dtpNgayDinhDang)
        Me.Controls.Add(Me.dgChiTiet)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDinhVi)
        Me.Controls.Add(Me.txtMaE1)
        Me.Controls.Add(Me.dgDinhVi)
        Me.Name = "FrmDinhVi"
        Me.Text = "Định Vị Bưu Phẩm"
        CType(Me.dgDinhVi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgChiTiet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpNgayDinhDang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim myTrangThai As New Trang_Thai(GConnectionString)
    Dim myE1_Di As New E1_Di(GConnectionString)

    Private Sub dgDuongthuden_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgDinhVi.InitializeLayout
        dgDinhVi.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        dgDinhVi.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
    End Sub
    Private Sub FrmDinhVi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDinhVi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDinhVi.Click
        Dim Ngay As Integer = Ham_Dung_Chung.ConvertDateToInt(Date.Now)
        Dim Ngay_Before As Integer = Ngay - 180
        Dim Ngay_After As Integer = Ngay + 10
        dgDinhVi.DataSource = myTrangThai.Danh_Sach_Lay_Boi_Ma_E1(txtMaE1.Text.Trim(), Ngay_Before, Ngay_After)
        dgDinhVi.DataBind()
        dgChiTiet.Text = "Chi tiết phát bưu phẩm mã số: " + "'" + txtMaE1.Text.ToUpper + "'"

        dgChiTiet.DataSource = myE1_Di.Danh_Sach_Lay_Boi_Ma_E1(txtMaE1.Text.Trim(), Ngay_Before, Ngay_After)
        dgChiTiet.DataBind()
    End Sub
End Class

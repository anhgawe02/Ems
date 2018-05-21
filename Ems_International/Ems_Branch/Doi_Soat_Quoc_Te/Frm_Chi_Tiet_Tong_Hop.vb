
'Project:Đối soát quốc tế
'Detail: Quản lý chi tiết các trạng thái tổng hợp dữ liệu
'1:Chi tiết tổng hợp theo ca khai thác: các trạng thái tổng hợp
'2:Chi tiết tổng hợp theo tháng
'
'
Public Class Frm_Chi_Tiet_Tong_Hop
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
    Friend WithEvents group_Ngay_Ca_Khai_Thac As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cb_Den_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cb_Tu_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents opt_Khoang_Thoi_Gian As System.Windows.Forms.RadioButton
    Friend WithEvents opt_Theo_Ca As System.Windows.Forms.RadioButton
    Friend WithEvents CbNgay_Kt As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents CbMa_Ca As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents grid_DSQT_Thong_Tin_Ke_Toan_Ca As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents BtnThoat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btn_Tong_Hop_QT_Den As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Ca", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ca_Khai_Thac")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thu_Tu")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ca")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_Chi_Tiet_Tong_Hop))
        Me.group_Ngay_Ca_Khai_Thac = New Infragistics.Win.Misc.UltraGroupBox
        Me.cb_Den_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.cb_Tu_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.opt_Khoang_Thoi_Gian = New System.Windows.Forms.RadioButton
        Me.opt_Theo_Ca = New System.Windows.Forms.RadioButton
        Me.CbNgay_Kt = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.CbMa_Ca = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.grid_DSQT_Thong_Tin_Ke_Toan_Ca = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.BtnThoat = New Infragistics.Win.Misc.UltraButton
        Me.btn_Tong_Hop_QT_Den = New Infragistics.Win.Misc.UltraButton
        CType(Me.group_Ngay_Ca_Khai_Thac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_Ngay_Ca_Khai_Thac.SuspendLayout()
        CType(Me.cb_Den_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_Tu_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbNgay_Kt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbMa_Ca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_DSQT_Thong_Tin_Ke_Toan_Ca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'group_Ngay_Ca_Khai_Thac
        '
        Me.group_Ngay_Ca_Khai_Thac.Controls.Add(Me.cb_Den_Ngay)
        Me.group_Ngay_Ca_Khai_Thac.Controls.Add(Me.UltraLabel4)
        Me.group_Ngay_Ca_Khai_Thac.Controls.Add(Me.cb_Tu_Ngay)
        Me.group_Ngay_Ca_Khai_Thac.Controls.Add(Me.UltraLabel3)
        Me.group_Ngay_Ca_Khai_Thac.Controls.Add(Me.opt_Khoang_Thoi_Gian)
        Me.group_Ngay_Ca_Khai_Thac.Controls.Add(Me.opt_Theo_Ca)
        Me.group_Ngay_Ca_Khai_Thac.Controls.Add(Me.CbNgay_Kt)
        Me.group_Ngay_Ca_Khai_Thac.Controls.Add(Me.CbMa_Ca)
        Me.group_Ngay_Ca_Khai_Thac.Controls.Add(Me.UltraLabel2)
        Me.group_Ngay_Ca_Khai_Thac.Controls.Add(Me.UltraLabel1)
        Me.group_Ngay_Ca_Khai_Thac.Location = New System.Drawing.Point(8, 8)
        Me.group_Ngay_Ca_Khai_Thac.Name = "group_Ngay_Ca_Khai_Thac"
        Me.group_Ngay_Ca_Khai_Thac.Size = New System.Drawing.Size(360, 136)
        Me.group_Ngay_Ca_Khai_Thac.SupportThemes = False
        Me.group_Ngay_Ca_Khai_Thac.TabIndex = 57
        Me.group_Ngay_Ca_Khai_Thac.Text = "Ngày Ca Khai Thác"
        '
        'cb_Den_Ngay
        '
        Me.cb_Den_Ngay.DateTime = New Date(2011, 6, 13, 0, 0, 0, 0)
        Me.cb_Den_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.cb_Den_Ngay.Location = New System.Drawing.Point(248, 104)
        Me.cb_Den_Ngay.Name = "cb_Den_Ngay"
        Me.cb_Den_Ngay.Size = New System.Drawing.Size(96, 21)
        Me.cb_Den_Ngay.TabIndex = 60
        Me.cb_Den_Ngay.Value = New Date(2011, 6, 13, 0, 0, 0, 0)
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UltraLabel4.Location = New System.Drawing.Point(248, 80)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(80, 16)
        Me.UltraLabel4.TabIndex = 61
        Me.UltraLabel4.Text = "Đến Ngày"
        '
        'cb_Tu_Ngay
        '
        Me.cb_Tu_Ngay.DateTime = New Date(2011, 6, 13, 0, 0, 0, 0)
        Me.cb_Tu_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.cb_Tu_Ngay.Location = New System.Drawing.Point(136, 104)
        Me.cb_Tu_Ngay.Name = "cb_Tu_Ngay"
        Me.cb_Tu_Ngay.Size = New System.Drawing.Size(96, 21)
        Me.cb_Tu_Ngay.TabIndex = 58
        Me.cb_Tu_Ngay.Value = New Date(2011, 6, 13, 0, 0, 0, 0)
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UltraLabel3.Location = New System.Drawing.Point(136, 80)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(80, 16)
        Me.UltraLabel3.TabIndex = 59
        Me.UltraLabel3.Text = "Từ Ngày"
        '
        'opt_Khoang_Thoi_Gian
        '
        Me.opt_Khoang_Thoi_Gian.Location = New System.Drawing.Point(8, 104)
        Me.opt_Khoang_Thoi_Gian.Name = "opt_Khoang_Thoi_Gian"
        Me.opt_Khoang_Thoi_Gian.Size = New System.Drawing.Size(120, 24)
        Me.opt_Khoang_Thoi_Gian.TabIndex = 57
        Me.opt_Khoang_Thoi_Gian.Text = "Khoảng Thời Gian"
        '
        'opt_Theo_Ca
        '
        Me.opt_Theo_Ca.Location = New System.Drawing.Point(8, 48)
        Me.opt_Theo_Ca.Name = "opt_Theo_Ca"
        Me.opt_Theo_Ca.Size = New System.Drawing.Size(120, 24)
        Me.opt_Theo_Ca.TabIndex = 56
        Me.opt_Theo_Ca.Text = "Ca Khai Thác"
        '
        'CbNgay_Kt
        '
        Me.CbNgay_Kt.DateTime = New Date(2011, 6, 13, 0, 0, 0, 0)
        Me.CbNgay_Kt.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.CbNgay_Kt.Location = New System.Drawing.Point(136, 48)
        Me.CbNgay_Kt.Name = "CbNgay_Kt"
        Me.CbNgay_Kt.Size = New System.Drawing.Size(96, 21)
        Me.CbNgay_Kt.TabIndex = 51
        Me.CbNgay_Kt.Value = New Date(2011, 6, 13, 0, 0, 0, 0)
        '
        'CbMa_Ca
        '
        Me.CbMa_Ca.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.Caption = "Bưu cục khai thác"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        Appearance1.FontData.BoldAsString = "True"
        UltraGridColumn3.Header.Appearance = Appearance1
        UltraGridColumn3.Header.Caption = "Ca"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 30
        Appearance2.FontData.BoldAsString = "True"
        Appearance2.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn4.Header.Appearance = Appearance2
        UltraGridColumn4.Header.Caption = "Tên ca"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 70
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        UltraGridBand1.SummaryFooterCaption = "Grand Summaries"
        Me.CbMa_Ca.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.CbMa_Ca.DisplayLayout.Override.HeaderAppearance = Appearance3
        Me.CbMa_Ca.DisplayMember = "Ca"
        Me.CbMa_Ca.LimitToList = True
        Me.CbMa_Ca.Location = New System.Drawing.Point(248, 48)
        Me.CbMa_Ca.Name = "CbMa_Ca"
        Me.CbMa_Ca.Size = New System.Drawing.Size(96, 21)
        Me.CbMa_Ca.TabIndex = 52
        Me.CbMa_Ca.ValueMember = "Thu_Tu"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UltraLabel2.Location = New System.Drawing.Point(248, 24)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel2.TabIndex = 54
        Me.UltraLabel2.Text = "Ca kế toán"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UltraLabel1.Location = New System.Drawing.Point(136, 24)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(80, 16)
        Me.UltraLabel1.TabIndex = 53
        Me.UltraLabel1.Text = "Ngày kế toán"
        '
        'grid_DSQT_Thong_Tin_Ke_Toan_Ca
        '
        Me.grid_DSQT_Thong_Tin_Ke_Toan_Ca.Location = New System.Drawing.Point(8, 152)
        Me.grid_DSQT_Thong_Tin_Ke_Toan_Ca.Name = "grid_DSQT_Thong_Tin_Ke_Toan_Ca"
        Me.grid_DSQT_Thong_Tin_Ke_Toan_Ca.Size = New System.Drawing.Size(768, 376)
        Me.grid_DSQT_Thong_Tin_Ke_Toan_Ca.TabIndex = 58
        Me.grid_DSQT_Thong_Tin_Ke_Toan_Ca.Text = "Thông Tin Kế Toán Ca"
        '
        'BtnThoat
        '
        Appearance4.Image = CType(resources.GetObject("Appearance4.Image"), Object)
        Me.BtnThoat.Appearance = Appearance4
        Me.BtnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnThoat.ImageSize = New System.Drawing.Size(30, 25)
        Me.BtnThoat.Location = New System.Drawing.Point(560, 24)
        Me.BtnThoat.Name = "BtnThoat"
        Me.BtnThoat.Size = New System.Drawing.Size(152, 40)
        Me.BtnThoat.TabIndex = 60
        Me.BtnThoat.Text = "Thoát"
        '
        'btn_Tong_Hop_QT_Den
        '
        Me.btn_Tong_Hop_QT_Den.Location = New System.Drawing.Point(392, 24)
        Me.btn_Tong_Hop_QT_Den.Name = "btn_Tong_Hop_QT_Den"
        Me.btn_Tong_Hop_QT_Den.Size = New System.Drawing.Size(152, 40)
        Me.btn_Tong_Hop_QT_Den.TabIndex = 59
        Me.btn_Tong_Hop_QT_Den.Text = "Xem"
        '
        'Frm_Chi_Tiet_Tong_Hop
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.BtnThoat)
        Me.Controls.Add(Me.btn_Tong_Hop_QT_Den)
        Me.Controls.Add(Me.grid_DSQT_Thong_Tin_Ke_Toan_Ca)
        Me.Controls.Add(Me.group_Ngay_Ca_Khai_Thac)
        Me.Name = "Frm_Chi_Tiet_Tong_Hop"
        Me.Text = "Chi Tiết Tổng Hợp"
        CType(Me.group_Ngay_Ca_Khai_Thac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_Ngay_Ca_Khai_Thac.ResumeLayout(False)
        CType(Me.cb_Den_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_Tu_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbNgay_Kt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbMa_Ca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_DSQT_Thong_Tin_Ke_Toan_Ca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class

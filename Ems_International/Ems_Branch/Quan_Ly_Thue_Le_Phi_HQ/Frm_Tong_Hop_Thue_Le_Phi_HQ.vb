Imports System
Imports ADODB
Imports System.IO
Imports System.Windows.Forms
Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports Ems_International_Logic.EMS

Public Class Frm_Tong_Hop_Thue_Le_Phi_HQ
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
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtpDen_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtpTu_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btnThoat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnPrint As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnPreview As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnExcel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents optTat_Ca_Cac_Tinh As System.Windows.Forms.RadioButton
    Friend WithEvents optTheo_Tinh As System.Windows.Forms.RadioButton
    Friend WithEvents optTat_Ca_Duong_Thu_Buu_Ta As System.Windows.Forms.RadioButton
    Friend WithEvents optTheo_Duong_Thu As System.Windows.Forms.RadioButton
    Friend WithEvents cbMa_Tinh As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbMa_Duong_Thu As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents optTong_Hop_Thue_Le_Phi As System.Windows.Forms.RadioButton
    Friend WithEvents optBuu_Pham_Da_Thu_Tien_Theo_Ngay_Dong As System.Windows.Forms.RadioButton
    Friend WithEvents optBuu_Pham_Da_Thu_Tien_Theo_Ngay_Thu As System.Windows.Forms.RadioButton
    Friend WithEvents optBuu_Pham_Chua_Thu_Tien_Theo_Ngay_Dong As System.Windows.Forms.RadioButton
    Friend WithEvents sFileDlg As System.Windows.Forms.SaveFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Tinh_Theo_Duong_Thu", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Tinh")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khu_Vuc")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thoa_Thuan")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Duong_Thu", -1)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Duong_Thu")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_Tong_Hop_Thue_Le_Phi_HQ))
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.dtpDen_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        Me.dtpTu_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.optBuu_Pham_Da_Thu_Tien_Theo_Ngay_Thu = New System.Windows.Forms.RadioButton
        Me.optBuu_Pham_Chua_Thu_Tien_Theo_Ngay_Dong = New System.Windows.Forms.RadioButton
        Me.optBuu_Pham_Da_Thu_Tien_Theo_Ngay_Dong = New System.Windows.Forms.RadioButton
        Me.optTong_Hop_Thue_Le_Phi = New System.Windows.Forms.RadioButton
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox
        Me.cbMa_Tinh = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cbMa_Duong_Thu = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.optTheo_Duong_Thu = New System.Windows.Forms.RadioButton
        Me.optTat_Ca_Duong_Thu_Buu_Ta = New System.Windows.Forms.RadioButton
        Me.optTheo_Tinh = New System.Windows.Forms.RadioButton
        Me.optTat_Ca_Cac_Tinh = New System.Windows.Forms.RadioButton
        Me.btnThoat = New Infragistics.Win.Misc.UltraButton
        Me.btnPrint = New Infragistics.Win.Misc.UltraButton
        Me.btnPreview = New Infragistics.Win.Misc.UltraButton
        Me.btnExcel = New Infragistics.Win.Misc.UltraButton
        Me.sFileDlg = New System.Windows.Forms.SaveFileDialog
        CType(Me.dtpDen_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTu_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.cbMa_Tinh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMa_Duong_Thu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraLabel5
        '
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(224, 36)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel5.TabIndex = 2
        Me.UltraLabel5.Text = "Ðến ngày"
        '
        'dtpDen_Ngay
        '
        Me.dtpDen_Ngay.DateTime = New Date(2009, 2, 9, 0, 0, 0, 0)
        Me.dtpDen_Ngay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDen_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpDen_Ngay.Location = New System.Drawing.Point(296, 32)
        Me.dtpDen_Ngay.Name = "dtpDen_Ngay"
        Me.dtpDen_Ngay.Size = New System.Drawing.Size(104, 24)
        Me.dtpDen_Ngay.TabIndex = 3
        Me.dtpDen_Ngay.Value = New Date(2009, 2, 9, 0, 0, 0, 0)
        '
        'UltraLabel6
        '
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(16, 36)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel6.TabIndex = 0
        Me.UltraLabel6.Text = "Từ ngày"
        '
        'dtpTu_Ngay
        '
        Me.dtpTu_Ngay.DateTime = New Date(2008, 7, 3, 0, 0, 0, 0)
        Me.dtpTu_Ngay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTu_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpTu_Ngay.Location = New System.Drawing.Point(88, 32)
        Me.dtpTu_Ngay.Name = "dtpTu_Ngay"
        Me.dtpTu_Ngay.Size = New System.Drawing.Size(104, 24)
        Me.dtpTu_Ngay.TabIndex = 1
        Me.dtpTu_Ngay.Value = New Date(2008, 7, 3, 0, 0, 0, 0)
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.optBuu_Pham_Da_Thu_Tien_Theo_Ngay_Thu)
        Me.UltraGroupBox1.Controls.Add(Me.optBuu_Pham_Chua_Thu_Tien_Theo_Ngay_Dong)
        Me.UltraGroupBox1.Controls.Add(Me.optBuu_Pham_Da_Thu_Tien_Theo_Ngay_Dong)
        Me.UltraGroupBox1.Controls.Add(Me.optTong_Hop_Thue_Le_Phi)
        Me.UltraGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox1.Location = New System.Drawing.Point(16, 16)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(504, 176)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.Text = "Danh mục báo cáo"
        '
        'optBuu_Pham_Da_Thu_Tien_Theo_Ngay_Thu
        '
        Me.optBuu_Pham_Da_Thu_Tien_Theo_Ngay_Thu.Location = New System.Drawing.Point(16, 128)
        Me.optBuu_Pham_Da_Thu_Tien_Theo_Ngay_Thu.Name = "optBuu_Pham_Da_Thu_Tien_Theo_Ngay_Thu"
        Me.optBuu_Pham_Da_Thu_Tien_Theo_Ngay_Thu.Size = New System.Drawing.Size(472, 24)
        Me.optBuu_Pham_Da_Thu_Tien_Theo_Ngay_Thu.TabIndex = 3
        Me.optBuu_Pham_Da_Thu_Tien_Theo_Ngay_Thu.Text = "Bảng kê bưu phẩm đã thu tiền thuế và lệ phí (theo ngày thu)"
        '
        'optBuu_Pham_Chua_Thu_Tien_Theo_Ngay_Dong
        '
        Me.optBuu_Pham_Chua_Thu_Tien_Theo_Ngay_Dong.Location = New System.Drawing.Point(16, 96)
        Me.optBuu_Pham_Chua_Thu_Tien_Theo_Ngay_Dong.Name = "optBuu_Pham_Chua_Thu_Tien_Theo_Ngay_Dong"
        Me.optBuu_Pham_Chua_Thu_Tien_Theo_Ngay_Dong.Size = New System.Drawing.Size(472, 24)
        Me.optBuu_Pham_Chua_Thu_Tien_Theo_Ngay_Dong.TabIndex = 2
        Me.optBuu_Pham_Chua_Thu_Tien_Theo_Ngay_Dong.Text = "Bảng kê bưu phẩm chưa thu tiền thuế và lệ phí (theo ngày đóng chuyến thư)"
        '
        'optBuu_Pham_Da_Thu_Tien_Theo_Ngay_Dong
        '
        Me.optBuu_Pham_Da_Thu_Tien_Theo_Ngay_Dong.Location = New System.Drawing.Point(16, 64)
        Me.optBuu_Pham_Da_Thu_Tien_Theo_Ngay_Dong.Name = "optBuu_Pham_Da_Thu_Tien_Theo_Ngay_Dong"
        Me.optBuu_Pham_Da_Thu_Tien_Theo_Ngay_Dong.Size = New System.Drawing.Size(472, 24)
        Me.optBuu_Pham_Da_Thu_Tien_Theo_Ngay_Dong.TabIndex = 1
        Me.optBuu_Pham_Da_Thu_Tien_Theo_Ngay_Dong.Text = "Bảng kê bưu phẩm đã thu tiền thuế và lệ phí (theo ngày đóng chuyến thư)"
        '
        'optTong_Hop_Thue_Le_Phi
        '
        Me.optTong_Hop_Thue_Le_Phi.Location = New System.Drawing.Point(16, 32)
        Me.optTong_Hop_Thue_Le_Phi.Name = "optTong_Hop_Thue_Le_Phi"
        Me.optTong_Hop_Thue_Le_Phi.Size = New System.Drawing.Size(400, 24)
        Me.optTong_Hop_Thue_Le_Phi.TabIndex = 0
        Me.optTong_Hop_Thue_Le_Phi.Text = "Bảng kê tổng hợp thuế và các loại lệ phí Hải quan"
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.cbMa_Tinh)
        Me.UltraGroupBox2.Controls.Add(Me.cbMa_Duong_Thu)
        Me.UltraGroupBox2.Controls.Add(Me.optTheo_Duong_Thu)
        Me.UltraGroupBox2.Controls.Add(Me.optTat_Ca_Duong_Thu_Buu_Ta)
        Me.UltraGroupBox2.Controls.Add(Me.optTheo_Tinh)
        Me.UltraGroupBox2.Controls.Add(Me.optTat_Ca_Cac_Tinh)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel5)
        Me.UltraGroupBox2.Controls.Add(Me.dtpDen_Ngay)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel6)
        Me.UltraGroupBox2.Controls.Add(Me.dtpTu_Ngay)
        Me.UltraGroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox2.Location = New System.Drawing.Point(16, 200)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(504, 176)
        Me.UltraGroupBox2.SupportThemes = False
        Me.UltraGroupBox2.TabIndex = 1
        Me.UltraGroupBox2.Text = "Tuỳ chọn báo cáo"
        '
        'cbMa_Tinh
        '
        Me.cbMa_Tinh.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn1.Header.Caption = "Mã tỉnh"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.Header.Caption = "Tên tỉnh"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.Header.Caption = "Khu vực"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.Caption = "Thoả thuận"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        Me.cbMa_Tinh.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance1.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance1.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance1.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance1.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbMa_Tinh.DisplayLayout.Override.HeaderAppearance = Appearance1
        Me.cbMa_Tinh.DisplayMember = "Ten_Tinh"
        Me.cbMa_Tinh.Location = New System.Drawing.Point(296, 84)
        Me.cbMa_Tinh.Name = "cbMa_Tinh"
        Me.cbMa_Tinh.Size = New System.Drawing.Size(192, 24)
        Me.cbMa_Tinh.TabIndex = 6
        Me.cbMa_Tinh.ValueMember = "Ma_Tinh"
        '
        'cbMa_Duong_Thu
        '
        Me.cbMa_Duong_Thu.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn5.Header.VisiblePosition = 0
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.Caption = "Đường thư"
        UltraGridColumn6.Header.VisiblePosition = 1
        UltraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(226, 0)
        UltraGridColumn7.Header.VisiblePosition = 2
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 3
        UltraGridColumn8.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8})
        UltraGridBand2.UseRowLayout = True
        Me.cbMa_Duong_Thu.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance2.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance2.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbMa_Duong_Thu.DisplayLayout.Override.HeaderAppearance = Appearance2
        Me.cbMa_Duong_Thu.DisplayMember = "Ten_Duong_Thu"
        Me.cbMa_Duong_Thu.Location = New System.Drawing.Point(296, 128)
        Me.cbMa_Duong_Thu.Name = "cbMa_Duong_Thu"
        Me.cbMa_Duong_Thu.Size = New System.Drawing.Size(192, 24)
        Me.cbMa_Duong_Thu.TabIndex = 9
        Me.cbMa_Duong_Thu.ValueMember = "Id_Duong_Thu"
        '
        'optTheo_Duong_Thu
        '
        Me.optTheo_Duong_Thu.Location = New System.Drawing.Point(160, 124)
        Me.optTheo_Duong_Thu.Name = "optTheo_Duong_Thu"
        Me.optTheo_Duong_Thu.Size = New System.Drawing.Size(136, 32)
        Me.optTheo_Duong_Thu.TabIndex = 8
        Me.optTheo_Duong_Thu.Text = "Theo từng đường thư bưu tá nội bộ"
        '
        'optTat_Ca_Duong_Thu_Buu_Ta
        '
        Me.optTat_Ca_Duong_Thu_Buu_Ta.Location = New System.Drawing.Point(16, 124)
        Me.optTat_Ca_Duong_Thu_Buu_Ta.Name = "optTat_Ca_Duong_Thu_Buu_Ta"
        Me.optTat_Ca_Duong_Thu_Buu_Ta.Size = New System.Drawing.Size(128, 32)
        Me.optTat_Ca_Duong_Thu_Buu_Ta.TabIndex = 7
        Me.optTat_Ca_Duong_Thu_Buu_Ta.Text = "Tất cả các đường thư bưu tá nội bộ"
        '
        'optTheo_Tinh
        '
        Me.optTheo_Tinh.Location = New System.Drawing.Point(160, 84)
        Me.optTheo_Tinh.Name = "optTheo_Tinh"
        Me.optTheo_Tinh.Size = New System.Drawing.Size(128, 24)
        Me.optTheo_Tinh.TabIndex = 5
        Me.optTheo_Tinh.Text = "Theo từng tỉnh"
        '
        'optTat_Ca_Cac_Tinh
        '
        Me.optTat_Ca_Cac_Tinh.Location = New System.Drawing.Point(16, 84)
        Me.optTat_Ca_Cac_Tinh.Name = "optTat_Ca_Cac_Tinh"
        Me.optTat_Ca_Cac_Tinh.Size = New System.Drawing.Size(128, 24)
        Me.optTat_Ca_Cac_Tinh.TabIndex = 4
        Me.optTat_Ca_Cac_Tinh.Text = "Tất cả các tỉnh"
        '
        'btnThoat
        '
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        Me.btnThoat.Appearance = Appearance3
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnThoat.Location = New System.Drawing.Point(392, 392)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(104, 40)
        Me.btnThoat.TabIndex = 5
        Me.btnThoat.Text = "&Thoát"
        '
        'btnPrint
        '
        Appearance4.Image = CType(resources.GetObject("Appearance4.Image"), Object)
        Me.btnPrint.Appearance = Appearance4
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnPrint.Location = New System.Drawing.Point(32, 392)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(104, 40)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "&In ra       máy in"
        '
        'btnPreview
        '
        Appearance5.Image = CType(resources.GetObject("Appearance5.Image"), Object)
        Appearance5.ImageHAlign = Infragistics.Win.HAlign.Left
        Appearance5.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnPreview.Appearance = Appearance5
        Me.btnPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnPreview.Location = New System.Drawing.Point(152, 392)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(104, 40)
        Me.btnPreview.TabIndex = 3
        Me.btnPreview.Text = "&Xem trên màn hình"
        '
        'btnExcel
        '
        Appearance6.Image = CType(resources.GetObject("Appearance6.Image"), Object)
        Appearance6.ImageHAlign = Infragistics.Win.HAlign.Left
        Appearance6.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnExcel.Appearance = Appearance6
        Me.btnExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcel.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnExcel.Location = New System.Drawing.Point(272, 392)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(104, 40)
        Me.btnExcel.TabIndex = 4
        Me.btnExcel.Text = "Xuất ra &Excel"
        '
        'Frm_Tong_Hop_Thue_Le_Phi_HQ
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(536, 461)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.UltraGroupBox2)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Name = "Frm_Tong_Hop_Thue_Le_Phi_HQ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Báo cáo - Tổng hợp thuế và lệ phí hải quan"
        CType(Me.dtpDen_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTu_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.cbMa_Tinh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMa_Duong_Thu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Khai_Báo_Biến_Toàn_Form"
    Private myE1_No_Le_Phi_HQ As New E1_No_Le_Phi_HQ(GConnectionString)
    Private myE1_Thu_No_Le_Phi_HQ As New E1_Thu_No_Le_Phi_HQ(GConnectionString)
    Private myMa_Tinh As New Ma_Tinh(GConnectionString)
    Private myDuong_Thu_Buu_Ta_Noi_Bo As New Duong_Thu_Buu_Ta_Noi_Bo(GConnectionString)
    Private myDuong_Thu_Di As New Duong_Thu_Di(GConnectionString)
    Private myDanh_Muc_Bc As New Danh_Muc_BC(GConnectionString)
    Private myHam_Dung_Chung As New Ham_Dung_Chung
    Private myTu_Ngay As Integer
    Private myDen_Ngay As Integer
    Private myLoai_Bao_Cao As Integer
    Private myTuy_Chon_Bao_Cao As Integer
    Private myMa_Tinh_Chi_Nhanh As Integer
    Private myDon_Vi As Integer
#End Region

#Region "Frm_Tong_Hop_Thue_Le_Phi_HQ_Load"
    Private Sub Frm_Tong_Hop_Thue_Le_Phi_HQ_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Init_Form()
    End Sub
#End Region

#Region "Hàm_Người_Dùng_Viết"
#Region "Init_Form"
    Private Sub Init_Form()
        dtpTu_Ngay.Value = Now.Date()
        dtpDen_Ngay.Value = Now.Date()
        GetMaTinh()
        GetMaDuongThu()
        optTong_Hop_Thue_Le_Phi.Checked = True
        optTat_Ca_Cac_Tinh.Checked = True
        cbMa_Tinh.Enabled = False
        cbMa_Duong_Thu.Enabled = False
    End Sub
#End Region
#Region "GetMaTinh"
    Private Sub GetMaTinh()
        Dim TblDanh_Sach_Tinh As New DataTable
        TblDanh_Sach_Tinh = myMa_Tinh.Hai_Quan_Ma_Tinh_Lay_Theo_Ma_Bc_Khai_Thac(GBuu_Cuc_Khai_Thac).Tables(0)
        cbMa_Tinh.DataSource = TblDanh_Sach_Tinh
        cbMa_Tinh.DataBind()
        'cbMa_Tinh.Value = TblDanh_Sach_Tinh.Rows(0).Item("Ma_Tinh")
        'cbMa_Tinh.LimitToList = True
    End Sub
#End Region
#Region "GetMaDuongThu"
    Private Sub GetMaDuongThu()
        Dim TblDuong_Thu_Buu_Ta_Noi_Bo As New DataTable
        TblDuong_Thu_Buu_Ta_Noi_Bo = myDuong_Thu_Buu_Ta_Noi_Bo.Duong_Thu_Buu_Ta_Noi_Bo_Danh_Sach_Rut_Gon_Lay_Boi_Ma_Bc_Khai_Thac(GBuu_Cuc_Khai_Thac).Tables(0)
        cbMa_Duong_Thu.DataSource = TblDuong_Thu_Buu_Ta_Noi_Bo
        cbMa_Duong_Thu.DataBind()
        'cbMa_Tinh.Value = TblDanh_Sach_Tinh.Rows(0).Item("Ma_Tinh")
        'cbMa_Duong_Thu.LimitToList = True
    End Sub
#End Region
#Region "Kiem_Tra_Loai_Bao_Cao"
    Private Function Kiem_Tra_Loai_Bao_Cao() As Integer
        'Tổng hợp thuế và lệ phí
        If optTong_Hop_Thue_Le_Phi.Checked Then
            Return 1
        End If
        'Bưu phẩm đã thu tiền theo ngày đóng
        If optBuu_Pham_Da_Thu_Tien_Theo_Ngay_Dong.Checked Then
            Return 2
        End If
        'Bưu phẩm chưa thu tiền theo ngày đóng
        If optBuu_Pham_Chua_Thu_Tien_Theo_Ngay_Dong.Checked Then
            Return 3
        End If
        'Bưu phẩm đã thu tiền theo ngày thu
        If optBuu_Pham_Da_Thu_Tien_Theo_Ngay_Thu.Checked Then
            Return 4
        End If
    End Function
#End Region
#Region "Kiem_Tra_Tuy_Chon_Bao_Cao"
    Private Function Kiem_Tra_Tuy_Chon_Bao_Cao() As Integer
        'Tất cả các tỉnh
        If optTat_Ca_Cac_Tinh.Checked Then
            myDon_Vi = 2
            Return 11
        End If
        'Theo từng tỉnh
        If optTheo_Tinh.Checked Then
            myDon_Vi = 2
            Return 12
        End If
        'Tất cả các đường thư bưu tá
        If optTat_Ca_Duong_Thu_Buu_Ta.Checked Then
            myDon_Vi = 1
            Return 21
        End If
        'Theo từng đường thư bưu tá
        If optTheo_Duong_Thu.Checked Then
            myDon_Vi = 1
            Return 22
        End If
    End Function
#End Region
#Region "Lay_Thong_Tin_Va_Kiem_Tra_Tu_Ngay_Den_Ngay"
    Private Function Lay_Thong_Tin_Va_Kiem_Tra_Tu_Ngay_Den_Ngay() As Boolean
        myTu_Ngay = myHam_Dung_Chung.ConvertDateToInt(dtpTu_Ngay.Value)
        myDen_Ngay = myHam_Dung_Chung.ConvertDateToInt(dtpDen_Ngay.Value)
        If myTu_Ngay > myDen_Ngay Then
            MessageBox.Show("Thông tin từ ngày đến ngày không hợp lệ. Từ ngày không được phép lớn hơn đến ngày.", "Lỗi nhập thông tin tuỳ chọn báo cáo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpTu_Ngay.Select()
            Return False
        End If
        Return True
    End Function
#End Region
#Region "Ban_Ke_Buu_Pham_Thu_Tien"
    Private Sub Ban_Ke_Buu_Pham_Thu_Tien(ByVal mPreview As Boolean)
        Dim myTable As New DataTable
        Dim RptBan_Ke_Buu_Pham_Thu_Tien As ReportClass
        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue
        Dim FrmView As New FrmViewReports
        Dim pMenu_Trai As String
        Dim pMenu_Phai As String
        Dim pNgay_Thang_Nam As String
        Dim pDon_Vi_Khai_Thac As String
        Dim pTen_Bao_Cao As String
        Dim pNguoi_Lap_Bieu As String
        Dim pTruong_Don_Vi As String
        Dim pTu_Ngay_Den_Ngay As String
        Dim pMenu_Don_Vi_Bao_Cao As String
        Dim pTieu_De_Cot As String

        'Lay du lieu chi tiet cho bao cao
        Select Case myLoai_Bao_Cao
            Case 2      'da thu theo ngay dong
                Select Case myTuy_Chon_Bao_Cao
                    Case 11, 21     'tat ca cac tinh - tat ca cac duong thu buu ta noi bo
                        myTable = myE1_No_Le_Phi_HQ.E1_No_Le_Phi_HQ_Ban_Ke_Da_Thu_Theo_Ngay_Dong_Tu_Ngay_Den_Ngay(myDon_Vi, myTu_Ngay, myDen_Ngay, GBuu_Cuc_Khai_Thac).Tables(0)
                    Case 12     'Theo tung tinh
                        myTable = myE1_No_Le_Phi_HQ.E1_No_Le_Phi_HQ_Ban_Ke_Da_Thu_Theo_Ngay_Dong_Tu_Ngay_Den_Ngay_Theo_Tung_Don_Vi(myDon_Vi, myTu_Ngay, myDen_Ngay, GBuu_Cuc_Khai_Thac, cbMa_Tinh.Value, "").Tables(0)
                    Case 22     'Theo tung duong thu buu ta noi bo
                        myTable = myE1_No_Le_Phi_HQ.E1_No_Le_Phi_HQ_Ban_Ke_Da_Thu_Theo_Ngay_Dong_Tu_Ngay_Den_Ngay_Theo_Tung_Don_Vi(myDon_Vi, myTu_Ngay, myDen_Ngay, GBuu_Cuc_Khai_Thac, 0, cbMa_Duong_Thu.Value).Tables(0)
                End Select
            Case 3      'chua thu theo ngay dong
                Select Case myTuy_Chon_Bao_Cao
                    Case 11, 21     'tat ca cac tinh - tat ca cac duong thu buu ta noi bo
                        myTable = myE1_No_Le_Phi_HQ.E1_No_Le_Phi_HQ_Ban_Ke_Chua_Thu_Theo_Ngay_Dong_Tu_Ngay_Den_Ngay(myDon_Vi, myTu_Ngay, myDen_Ngay, GBuu_Cuc_Khai_Thac).Tables(0)
                    Case 12     'Theo tung tinh
                        myTable = myE1_No_Le_Phi_HQ.E1_No_Le_Phi_HQ_Ban_Ke_Chua_Thu_Theo_Ngay_Dong_Tu_Ngay_Den_Ngay_Theo_Tung_Don_Vi(myDon_Vi, myTu_Ngay, myDen_Ngay, GBuu_Cuc_Khai_Thac, cbMa_Tinh.Value, "").Tables(0)
                    Case 22     'Theo tung duong thu buu ta noi bo
                        myTable = myE1_No_Le_Phi_HQ.E1_No_Le_Phi_HQ_Ban_Ke_Chua_Thu_Theo_Ngay_Dong_Tu_Ngay_Den_Ngay_Theo_Tung_Don_Vi(myDon_Vi, myTu_Ngay, myDen_Ngay, GBuu_Cuc_Khai_Thac, 0, cbMa_Duong_Thu.Value).Tables(0)
                End Select
            Case 4      'da thu theo ngay thu
                Select Case myTuy_Chon_Bao_Cao
                    Case 11, 21     'tat ca cac tinh - tat ca cac duong thu buu ta noi bo
                        myTable = myE1_No_Le_Phi_HQ.E1_No_Le_Phi_HQ_Ban_Ke_Da_Thu_Theo_Ngay_Thu_Tu_Ngay_Den_Ngay(myDon_Vi, myTu_Ngay, myDen_Ngay, GBuu_Cuc_Khai_Thac).Tables(0)
                    Case 12     'Theo tung tinh
                        myTable = myE1_No_Le_Phi_HQ.E1_No_Le_Phi_HQ_Ban_Ke_Da_Thu_Theo_Ngay_Thu_Tu_Ngay_Den_Ngay_Theo_Tung_Don_Vi(myDon_Vi, myTu_Ngay, myDen_Ngay, GBuu_Cuc_Khai_Thac, cbMa_Tinh.Value, "").Tables(0)
                    Case 22     'Theo tung duong thu buu ta noi bo
                        myTable = myE1_No_Le_Phi_HQ.E1_No_Le_Phi_HQ_Ban_Ke_Da_Thu_Theo_Ngay_Thu_Tu_Ngay_Den_Ngay_Theo_Tung_Don_Vi(myDon_Vi, myTu_Ngay, myDen_Ngay, GBuu_Cuc_Khai_Thac, 0, cbMa_Duong_Thu.Value).Tables(0)
                End Select
        End Select

        'Kiem tra neu khong co ban ghi thi thoat
        If myTable.Rows.Count = 0 Then
            CMessageBox.Show("Không có thông tin dữ liệu về bản kê này !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        'Tiep tuc thuc hien neu co du lieu
        Select Case myTuy_Chon_Bao_Cao
            Case 11, 21     'tat ca
                RptBan_Ke_Buu_Pham_Thu_Tien = New RptBan_Ke_Buu_Pham_Thu_Tien
            Case 12, 22     'theo tung don vi
                RptBan_Ke_Buu_Pham_Thu_Tien = New rptBan_Ke_Buu_Pham_Thu_Tien_Theo_Tung_Don_Vi
        End Select
        'Thong tin chi tiet
        myTable.TableName = "Ban_Ke_Chi_Tiet_Buu_Pham_Thu_Tien"
        'Thong tin header va footer dua vao thong qua Paramete
        myMa_Tinh_Chi_Nhanh = myDanh_Muc_Bc.Lay(GBuu_Cuc_Khai_Thac).Ma_Tinh
        '=======Menu Trai 
        pMenu_Trai = "CÔNG TY CP CHUYỂN PHÁT NHANH BƯU ĐIỆN"
        If myMa_Tinh_Chi_Nhanh = 100000 Then  'ha noi
            pMenu_Trai = pMenu_Trai & vbNewLine & "KHAI THÁC QUỐC TẾ NỘI BÀI - HÀ NỘI"
        ElseIf myMa_Tinh_Chi_Nhanh = 700000 Then   'ho chi minh
            pMenu_Trai = pMenu_Trai & vbNewLine & "CHI NHÁNH TẠI TP. HỒ CHÍ MINH"
        Else  'khong xac dinh
            pMenu_Trai = pMenu_Trai & vbNewLine & "KHAI THÁC QUỐC TẾ"
        End If
        _pThamSo.Value = pMenu_Trai
        pvCollection.Add(_pThamSo)
        RptBan_Ke_Buu_Pham_Thu_Tien.DataDefinition.ParameterFields("pMenu_Trai").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        '=======Don_Vi 
        pDon_Vi_Khai_Thac = "ĐƠN VỊ: KIỂM HOÁ EMS"
        _pThamSo.Value = pDon_Vi_Khai_Thac
        pvCollection.Add(_pThamSo)
        RptBan_Ke_Buu_Pham_Thu_Tien.DataDefinition.ParameterFields("pDon_Vi_Khai_Thac").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        '=======Menu_Phai 
        pMenu_Phai = "CỘNG HOÀ XÃ HỘI CHỦ NGHĨA VIỆT NAM" & vbNewLine & "ĐỘC LẬP - TỰ DO - HẠNH PHÚC"
        _pThamSo.Value = pMenu_Phai
        pvCollection.Add(_pThamSo)
        RptBan_Ke_Buu_Pham_Thu_Tien.DataDefinition.ParameterFields("pMenu_Phai").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        '=======Ngay_Thang_Nam 
        If myMa_Tinh_Chi_Nhanh = 100000 Then  'ha noi
            pNgay_Thang_Nam = "Hà Nội, ngày " & Now.Day.ToString("00") & " tháng " & Now.Month.ToString("00") & " năm " & Now.Year.ToString("0000")
        ElseIf myMa_Tinh_Chi_Nhanh = 700000 Then   'ho chi minh
            pNgay_Thang_Nam = "Thành phố Hồ Chí Minh, ngày " & Now.Day.ToString("00") & " tháng " & Now.Month.ToString("00") & " năm " & Now.Year.ToString("0000")
        Else  'khong xac dinh
            pNgay_Thang_Nam = "Ngày " & Now.Day.ToString("00") & " tháng " & Now.Month.ToString("00") & " năm " & Now.Year.ToString("0000")
        End If
        _pThamSo.Value = pNgay_Thang_Nam
        pvCollection.Add(_pThamSo)
        RptBan_Ke_Buu_Pham_Thu_Tien.DataDefinition.ParameterFields("pNgay_Thang_Nam").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        '=======Ten_Bao_Cao  & Tieu de cot
        Select Case myLoai_Bao_Cao
            Case 1   'tong hop thue va le phi
                pTen_Bao_Cao = "BẢN KÊ TỔNG HỢP THUẾ HẢI QUAN VÀ CÁC LOẠI LỆ PHÍ (EMS)"
                pTieu_De_Cot = ""
            Case 2  'buu pham da thu theo ngay dong
                pTen_Bao_Cao = "BẢN KÊ BƯU PHẨM ĐÃ THU TIỀN THUẾ VÀ CÁC LOẠI LỆ PHÍ HQ (Theo ngày đóng)"
                pTieu_De_Cot = "Tổng tiền" & vbNewLine & "(đã thu)"
            Case 3  'buu pham chua thu theo ngay dong
                pTen_Bao_Cao = "BẢN KÊ BƯU PHẨM CHƯA THU TIỀN THUẾ VÀ CÁC LOẠI LỆ PHÍ HQ (Theo ngày đóng)"
                pTieu_De_Cot = "Tổng tiền" & vbNewLine & "(phải thu)"
            Case 4  'buu pham da thu theo ngay thu
                pTen_Bao_Cao = "BẢN KÊ BƯU PHẨM ĐÃ THU TIỀN THUẾ VÀ CÁC LOẠI LỆ PHÍ HQ (Theo ngày thu)"
                pTieu_De_Cot = "Tổng tiền" & vbNewLine & "(đã thu)"
        End Select
        _pThamSo.Value = pTieu_De_Cot
        pvCollection.Add(_pThamSo)
        RptBan_Ke_Buu_Pham_Thu_Tien.DataDefinition.ParameterFields("pTieu_De_Cot").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        _pThamSo.Value = pTen_Bao_Cao
        pvCollection.Add(_pThamSo)
        RptBan_Ke_Buu_Pham_Thu_Tien.DataDefinition.ParameterFields("pTen_Bao_Cao").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        '=======Tu ngay Den ngay
        pTu_Ngay_Den_Ngay = "Từ ngày   " & DateTime.Parse(dtpTu_Ngay.Value).ToString("dd/MM/yyyy") & "   đến ngày   " & DateTime.Parse(dtpDen_Ngay.Value).ToString("dd/MM/yyyy")
        _pThamSo.Value = pTu_Ngay_Den_Ngay
        pvCollection.Add(_pThamSo)
        RptBan_Ke_Buu_Pham_Thu_Tien.DataDefinition.ParameterFields("pTu_Ngay_Den_Ngay").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        '=======Mnu_Don_Vi_Bao_Cao
        Select Case myTuy_Chon_Bao_Cao
            Case 11     'Tat ca cac tinh
                pMenu_Don_Vi_Bao_Cao = "Tất cả các tỉnh"
            Case 12     'Theo tung tinh
                Dim mMa_Tinh As Integer = cbMa_Tinh.Value
                pMenu_Don_Vi_Bao_Cao = mMa_Tinh.ToString("000000") & " - " & myMa_Tinh.Lay(mMa_Tinh).Ten_Tinh
            Case 21     'Tat ca cac duong thu buu ta noi bo
                pMenu_Don_Vi_Bao_Cao = "Tất cả các đường thư bưu tá nội bộ"
            Case 22     'Theo tung duong thu buu ta noi bo
                pMenu_Don_Vi_Bao_Cao = cbMa_Duong_Thu.Text
        End Select
        _pThamSo.Value = pMenu_Don_Vi_Bao_Cao
        pvCollection.Add(_pThamSo)
        RptBan_Ke_Buu_Pham_Thu_Tien.DataDefinition.ParameterFields("pMenu_Don_Vi_Bao_Cao").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        '=======Nguoi_Lap_Bieu
        pNguoi_Lap_Bieu = GHo_Ten
        _pThamSo.Value = pNguoi_Lap_Bieu
        pvCollection.Add(_pThamSo)
        RptBan_Ke_Buu_Pham_Thu_Tien.DataDefinition.ParameterFields("pNguoi_Lap_Bieu").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        '=======Truong_Don_Vi 
        If myMa_Tinh_Chi_Nhanh = 100000 Then  'ha noi
            pTruong_Don_Vi = "Trần Thị Hương"
        ElseIf myMa_Tinh_Chi_Nhanh = 700000 Then   'ho chi minh
            pTruong_Don_Vi = "Phạm Ngọc Minh"
        Else  'khong xac dinh
            pTruong_Don_Vi = ""
        End If
        _pThamSo.Value = pTruong_Don_Vi
        pvCollection.Add(_pThamSo)
        RptBan_Ke_Buu_Pham_Thu_Tien.DataDefinition.ParameterFields("pTruong_Don_Vi").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        RptBan_Ke_Buu_Pham_Thu_Tien.SetDataSource(myTable)
        FrmView.CrystalReportViewer1.ReportSource = RptBan_Ke_Buu_Pham_Thu_Tien
        Cursor.Current = Cursors.Default
        'Bat dau in
        If mPreview = True Then
            FrmView.ShowDialog()
        Else
            RptBan_Ke_Buu_Pham_Thu_Tien.PrintToPrinter(1, True, 0, 0)
        End If

    End Sub
#End Region
#Region "Ban_Ke_Tong_Hop_Thue_Le_Phi_HQ"
    Private Sub Ban_Ke_Tong_Hop_Thue_Le_Phi_HQ(ByVal mPreview As Boolean)
        Dim myTable As New DataTable
        Dim RptBan_Ke_Tong_Hop As New rptTong_Hop_Thue_Va_Le_Phi
        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue
        Dim FrmView As New FrmViewReports
        Dim pMenu_Trai As String
        Dim pMenu_Phai As String
        Dim pNgay_Thang_Nam As String
        Dim pDon_Vi_Khai_Thac As String
        Dim pTen_Bao_Cao As String
        Dim pNguoi_Lap_Bieu As String
        Dim pTruong_Don_Vi As String
        Dim pTu_Ngay_Den_Ngay As String

        'Lay du lieu chi tiet cho bao cao
        myTable = myE1_No_Le_Phi_HQ.E1_No_Le_Phi_HQ_Ban_Ke_Tong_Hop_Thue_Le_Phi_HQ_Tu_Ngay_Den_Ngay(myDon_Vi, myTu_Ngay, myDen_Ngay, GBuu_Cuc_Khai_Thac).Tables(0)

        'Kiem tra neu khong co ban ghi thi thoat
        If myTable.Rows.Count = 0 Then
            CMessageBox.Show("Không có thông tin dữ liệu về bản kê này !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        'Tiep tuc thuc hien neu co du lieu        
        'Thong tin chi tiet
        myTable.TableName = "Ban_Ke_Tong_Hop_Thue_Le_Phi_Hai_Quan"
        'Thong tin header va footer dua vao thong qua Paramete
        myMa_Tinh_Chi_Nhanh = myDanh_Muc_Bc.Lay(GBuu_Cuc_Khai_Thac).Ma_Tinh
        '=======Menu Trai 
        pMenu_Trai = "CÔNG TY CP CHUYỂN PHÁT NHANH BƯU ĐIỆN"
        If myMa_Tinh_Chi_Nhanh = 100000 Then  'ha noi
            pMenu_Trai = pMenu_Trai & vbNewLine & "KHAI THÁC QUỐC TẾ NỘI BÀI - HÀ NỘI"
        ElseIf myMa_Tinh_Chi_Nhanh = 700000 Then   'ho chi minh
            pMenu_Trai = pMenu_Trai & vbNewLine & "CHI NHÁNH TẠI TP. HỒ CHÍ MINH"
        Else  'khong xac dinh
            pMenu_Trai = pMenu_Trai & vbNewLine & "KHAI THÁC QUỐC TẾ"
        End If
        _pThamSo.Value = pMenu_Trai
        pvCollection.Add(_pThamSo)
        RptBan_Ke_Tong_Hop.DataDefinition.ParameterFields("pMenu_Trai").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        '=======Don_Vi 
        pDon_Vi_Khai_Thac = "ĐƠN VỊ: KIỂM HOÁ EMS"
        _pThamSo.Value = pDon_Vi_Khai_Thac
        pvCollection.Add(_pThamSo)
        RptBan_Ke_Tong_Hop.DataDefinition.ParameterFields("pDon_Vi_Khai_Thac").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        '=======Menu_Phai 
        pMenu_Phai = "CỘNG HOÀ XÃ HỘI CHỦ NGHĨA VIỆT NAM" & vbNewLine & "ĐỘC LẬP - TỰ DO - HẠNH PHÚC"
        _pThamSo.Value = pMenu_Phai
        pvCollection.Add(_pThamSo)
        RptBan_Ke_Tong_Hop.DataDefinition.ParameterFields("pMenu_Phai").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        '=======Ngay_Thang_Nam 
        If myMa_Tinh_Chi_Nhanh = 100000 Then  'ha noi
            pNgay_Thang_Nam = "Hà Nội, ngày " & Now.Day.ToString("00") & " tháng " & Now.Month.ToString("00") & " năm " & Now.Year.ToString("0000")
        ElseIf myMa_Tinh_Chi_Nhanh = 700000 Then   'ho chi minh
            pNgay_Thang_Nam = "Thành phố Hồ Chí Minh, ngày " & Now.Day.ToString("00") & " tháng " & Now.Month.ToString("00") & " năm " & Now.Year.ToString("0000")
        Else  'khong xac dinh
            pNgay_Thang_Nam = "Ngày " & Now.Day.ToString("00") & " tháng " & Now.Month.ToString("00") & " năm " & Now.Year.ToString("0000")
        End If
        _pThamSo.Value = pNgay_Thang_Nam
        pvCollection.Add(_pThamSo)
        RptBan_Ke_Tong_Hop.DataDefinition.ParameterFields("pNgay_Thang_Nam").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        '=======Ten_Bao_Cao  
        Select Case myLoai_Bao_Cao
            Case 1   'tong hop thue va le phi
                pTen_Bao_Cao = "BẢN KÊ TỔNG HỢP THUẾ HẢI QUAN VÀ CÁC LOẠI LỆ PHÍ (EMS)"
            Case 2  'buu pham da thu theo ngay dong
                pTen_Bao_Cao = "BẢN KÊ BƯU PHẨM ĐÃ THU TIỀN THUẾ VÀ CÁC LOẠI LỆ PHÍ HQ (Theo ngày đóng)"
            Case 3  'buu pham chua thu theo ngay dong
                pTen_Bao_Cao = "BẢN KÊ BƯU PHẨM CHƯA THU TIỀN THUẾ VÀ CÁC LOẠI LỆ PHÍ HQ (Theo ngày đóng)"
            Case 4  'buu pham da thu theo ngay thu
                pTen_Bao_Cao = "BẢN KÊ BƯU PHẨM ĐÃ THU TIỀN THUẾ VÀ CÁC LOẠI LỆ PHÍ HQ (Theo ngày thu)"
        End Select

        _pThamSo.Value = pTen_Bao_Cao
        pvCollection.Add(_pThamSo)
        RptBan_Ke_Tong_Hop.DataDefinition.ParameterFields("pTen_Bao_Cao").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        '=======Tu ngay Den ngay
        pTu_Ngay_Den_Ngay = "Từ ngày   " & DateTime.Parse(dtpTu_Ngay.Value).ToString("dd/MM/yyyy") & "   đến ngày   " & DateTime.Parse(dtpDen_Ngay.Value).ToString("dd/MM/yyyy")
        _pThamSo.Value = pTu_Ngay_Den_Ngay
        pvCollection.Add(_pThamSo)
        RptBan_Ke_Tong_Hop.DataDefinition.ParameterFields("pTu_Ngay_Den_Ngay").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        '=======Nguoi_Lap_Bieu
        pNguoi_Lap_Bieu = GHo_Ten
        _pThamSo.Value = pNguoi_Lap_Bieu
        pvCollection.Add(_pThamSo)
        RptBan_Ke_Tong_Hop.DataDefinition.ParameterFields("pNguoi_Lap_Bieu").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        '=======Truong_Don_Vi 
        If myMa_Tinh_Chi_Nhanh = 100000 Then  'ha noi
            pTruong_Don_Vi = "Trần Thị Hương"
        ElseIf myMa_Tinh_Chi_Nhanh = 700000 Then   'ho chi minh
            pTruong_Don_Vi = "Phạm Ngọc Minh"
        Else  'khong xac dinh
            pTruong_Don_Vi = ""
        End If
        _pThamSo.Value = pTruong_Don_Vi
        pvCollection.Add(_pThamSo)
        RptBan_Ke_Tong_Hop.DataDefinition.ParameterFields("pTruong_Don_Vi").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        RptBan_Ke_Tong_Hop.SetDataSource(myTable)
        FrmView.CrystalReportViewer1.ReportSource = RptBan_Ke_Tong_Hop
        Cursor.Current = Cursors.Default
        'Bat dau in
        If mPreview = True Then
            FrmView.ShowDialog()
        Else
            RptBan_Ke_Tong_Hop.PrintToPrinter(1, True, 0, 0)
        End If

    End Sub
#End Region
#Region "Get_Data_Export"
    Private Function Get_Data_Export() As DataSet
        Dim myDataSet As New DataSet
        Try
            Select Case myLoai_Bao_Cao
                Case 1
                    myDataSet = myE1_No_Le_Phi_HQ.E1_No_Le_Phi_HQ_Ban_Ke_Tong_Hop_Thue_Le_Phi_HQ_Tu_Ngay_Den_Ngay(myDon_Vi, myTu_Ngay, myDen_Ngay, GBuu_Cuc_Khai_Thac)
                Case 2      'da thu theo ngay dong
                    Select Case myTuy_Chon_Bao_Cao
                        Case 11, 21     'tat ca cac tinh - tat ca cac duong thu buu ta noi bo
                            myDataSet = myE1_No_Le_Phi_HQ.E1_No_Le_Phi_HQ_Ban_Ke_Da_Thu_Theo_Ngay_Dong_Tu_Ngay_Den_Ngay_Xuat_Ra_Excel(myDon_Vi, myTu_Ngay, myDen_Ngay, GBuu_Cuc_Khai_Thac)
                        Case 12     'Theo tung tinh
                            myDataSet = myE1_No_Le_Phi_HQ.E1_No_Le_Phi_HQ_Ban_Ke_Da_Thu_Theo_Ngay_Dong_Tu_Ngay_Den_Ngay_Theo_Tung_Don_Vi_Xuat_Ra_Excel(myDon_Vi, myTu_Ngay, myDen_Ngay, GBuu_Cuc_Khai_Thac, cbMa_Tinh.Value, "")
                        Case 22     'Theo tung duong thu buu ta noi bo
                            myDataSet = myE1_No_Le_Phi_HQ.E1_No_Le_Phi_HQ_Ban_Ke_Da_Thu_Theo_Ngay_Dong_Tu_Ngay_Den_Ngay_Theo_Tung_Don_Vi_Xuat_Ra_Excel(myDon_Vi, myTu_Ngay, myDen_Ngay, GBuu_Cuc_Khai_Thac, 0, cbMa_Duong_Thu.Value)
                    End Select
                Case 3      'chua thu theo ngay dong
                    Select Case myTuy_Chon_Bao_Cao
                        Case 11, 21     'tat ca cac tinh - tat ca cac duong thu buu ta noi bo
                            myDataSet = myE1_No_Le_Phi_HQ.E1_No_Le_Phi_HQ_Ban_Ke_Chua_Thu_Theo_Ngay_Dong_Tu_Ngay_Den_Ngay_Xuat_Ra_Excel(myDon_Vi, myTu_Ngay, myDen_Ngay, GBuu_Cuc_Khai_Thac)
                        Case 12     'Theo tung tinh
                            myDataSet = myE1_No_Le_Phi_HQ.E1_No_Le_Phi_HQ_Ban_Ke_Chua_Thu_Theo_Ngay_Dong_Tu_Ngay_Den_Ngay_Theo_Tung_Don_Vi_Xuat_Ra_Excel(myDon_Vi, myTu_Ngay, myDen_Ngay, GBuu_Cuc_Khai_Thac, cbMa_Tinh.Value, "")
                        Case 22     'Theo tung duong thu buu ta noi bo
                            myDataSet = myE1_No_Le_Phi_HQ.E1_No_Le_Phi_HQ_Ban_Ke_Chua_Thu_Theo_Ngay_Dong_Tu_Ngay_Den_Ngay_Theo_Tung_Don_Vi_Xuat_Ra_Excel(myDon_Vi, myTu_Ngay, myDen_Ngay, GBuu_Cuc_Khai_Thac, 0, cbMa_Duong_Thu.Value)
                    End Select
                Case 4      'da thu theo ngay thu
                    Select Case myTuy_Chon_Bao_Cao
                        Case 11, 21     'tat ca cac tinh - tat ca cac duong thu buu ta noi bo
                            myDataSet = myE1_No_Le_Phi_HQ.E1_No_Le_Phi_HQ_Ban_Ke_Da_Thu_Theo_Ngay_Thu_Tu_Ngay_Den_Ngay_Xuat_Ra_Excel(myDon_Vi, myTu_Ngay, myDen_Ngay, GBuu_Cuc_Khai_Thac)
                        Case 12     'Theo tung tinh
                            myDataSet = myE1_No_Le_Phi_HQ.E1_No_Le_Phi_HQ_Ban_Ke_Da_Thu_Theo_Ngay_Thu_Tu_Ngay_Den_Ngay_Theo_Tung_Don_Vi_Xuat_Ra_Excel(myDon_Vi, myTu_Ngay, myDen_Ngay, GBuu_Cuc_Khai_Thac, cbMa_Tinh.Value, "")
                        Case 22     'Theo tung duong thu buu ta noi bo
                            myDataSet = myE1_No_Le_Phi_HQ.E1_No_Le_Phi_HQ_Ban_Ke_Da_Thu_Theo_Ngay_Thu_Tu_Ngay_Den_Ngay_Theo_Tung_Don_Vi_Xuat_Ra_Excel(myDon_Vi, myTu_Ngay, myDen_Ngay, GBuu_Cuc_Khai_Thac, 0, cbMa_Duong_Thu.Value)
                    End Select
            End Select
            Return myDataSet
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
#End Region
#End Region

#Region "Tab_Control"
    '============Danh muc bao cao
#Region "optTong_Hop_Thue_Le_Phi_CheckedChanged"
    Private Sub optTong_Hop_Thue_Le_Phi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optTong_Hop_Thue_Le_Phi.CheckedChanged
        If optTheo_Tinh.Checked Then
            optTat_Ca_Cac_Tinh.Checked = True
        End If
        If optTheo_Duong_Thu.Checked Then
            optTat_Ca_Duong_Thu_Buu_Ta.Checked = True
        End If
    End Sub
#End Region

    '============Tuy chon bao cao
#Region "optTat_Ca_Cac_Tinh_CheckedChanged"
    Private Sub optTat_Ca_Cac_Tinh_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optTat_Ca_Cac_Tinh.CheckedChanged
        If optTat_Ca_Cac_Tinh.Checked Then
            cbMa_Tinh.Enabled = False
            cbMa_Duong_Thu.Enabled = False
        End If
    End Sub
#End Region
#Region "optTheo_Tinh_CheckedChanged"
    Private Sub optTheo_Tinh_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optTheo_Tinh.CheckedChanged
        If optTheo_Tinh.Checked Then
            If optTong_Hop_Thue_Le_Phi.Checked Then
                MessageBox.Show("Báo cáo tổng hợp không áp dụng theo từng tỉnh. Mời bạn chọn mục theo tất cả các tỉnh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                optTat_Ca_Cac_Tinh.Checked = True
            End If
        End If
        cbMa_Tinh.Enabled = optTheo_Tinh.Checked
        If Not cbMa_Tinh.IsDroppedDown Then
            cbMa_Tinh.PerformAction(Infragistics.Win.UltraWinGrid.UltraComboAction.ToggleDropdown)
        End If
    End Sub
#End Region
#Region "optTat_Ca_Duong_Thu_Buu_Ta_CheckedChanged"
    Private Sub optTat_Ca_Duong_Thu_Buu_Ta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optTat_Ca_Duong_Thu_Buu_Ta.CheckedChanged
        If optTat_Ca_Duong_Thu_Buu_Ta.Checked Then
            cbMa_Tinh.Enabled = False
            cbMa_Duong_Thu.Enabled = False
        End If
    End Sub
#End Region
#Region "optTheo_Duong_Thu_CheckedChanged"
    Private Sub optTheo_Duong_Thu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optTheo_Duong_Thu.CheckedChanged
        If optTheo_Duong_Thu.Checked Then
            If optTong_Hop_Thue_Le_Phi.Checked Then
                MessageBox.Show("Báo cáo tổng hợp không áp dụng theo từng đường thư bưu tá nội bộ. Mời bạn chọn mục theo tất cả các đường thư.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                optTat_Ca_Duong_Thu_Buu_Ta.Checked = True
            End If
        End If
        cbMa_Duong_Thu.Enabled = optTheo_Duong_Thu.Checked
        If Not cbMa_Duong_Thu.IsDroppedDown Then
            cbMa_Duong_Thu.PerformAction(Infragistics.Win.UltraWinGrid.UltraComboAction.ToggleDropdown)
        End If
    End Sub
#End Region

#Region "dtpTu_Ngay_GotFocus"
    Private Sub dtpTu_Ngay_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpTu_Ngay.GotFocus
        dtpTu_Ngay.SelectionStart = 0
        dtpTu_Ngay.SelectionLength = dtpTu_Ngay.Text.Length
    End Sub
#End Region
#Region "dtpDen_Ngay_GotFocus"
    Private Sub dtpDen_Ngay_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDen_Ngay.GotFocus
        dtpDen_Ngay.SelectionStart = 0
        dtpDen_Ngay.SelectionLength = dtpDen_Ngay.Text.Length
    End Sub
#End Region

#Region "btnPrint_Click"
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            If Not Lay_Thong_Tin_Va_Kiem_Tra_Tu_Ngay_Den_Ngay() Then
                Exit Sub
            End If
            myLoai_Bao_Cao = Kiem_Tra_Loai_Bao_Cao()
            myTuy_Chon_Bao_Cao = Kiem_Tra_Tuy_Chon_Bao_Cao()
            Select Case myLoai_Bao_Cao
                Case 1      'Tong hop thue va le phi
                    Ban_Ke_Tong_Hop_Thue_Le_Phi_HQ(False)
                Case 2, 3, 4    'Da thu tien (ngay dong + ngay thu) & chua thu tien theo nagy dong
                    Ban_Ke_Buu_Pham_Thu_Tien(False)
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "btnPreview_Click"
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            If Not Lay_Thong_Tin_Va_Kiem_Tra_Tu_Ngay_Den_Ngay() Then
                Exit Sub
            End If
            myLoai_Bao_Cao = Kiem_Tra_Loai_Bao_Cao()
            myTuy_Chon_Bao_Cao = Kiem_Tra_Tuy_Chon_Bao_Cao()
            Select Case myLoai_Bao_Cao
                Case 1      'Tong hop thue va le phi
                    Ban_Ke_Tong_Hop_Thue_Le_Phi_HQ(True)
                Case 2, 3, 4    'Da thu tien (ngay dong + ngay thu) & chua thu tien theo nagy dong
                    Ban_Ke_Buu_Pham_Thu_Tien(True)
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "btnExcel_Click"
    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Try
            If Not Lay_Thong_Tin_Va_Kiem_Tra_Tu_Ngay_Den_Ngay() Then
                Exit Sub
            End If
            myLoai_Bao_Cao = Kiem_Tra_Loai_Bao_Cao()
            myTuy_Chon_Bao_Cao = Kiem_Tra_Tuy_Chon_Bao_Cao()
            Dim strFilePath As String
            Dim mDataSet As New DataSet
            'Open SaveDialog
            With sFileDlg
                .Title = "Chon ten File"
                .DefaultExt = "*.xls"
                .Filter = "Xls (*.xls)|*.xls"
                .ShowDialog()
            End With
            If sFileDlg.FileName <> "" Then
                strFilePath = sFileDlg.FileName
                mDataSet = Get_Data_Export()
                If mDataSet.Tables(0).Rows.Count <= 0 Then  'khong co du lieu
                    MessageBox.Show("Không có dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else  'co du lieu
                    Export_To_Excel_From_DataSet(mDataSet, strFilePath)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "btnThoat_Click"
    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
        Me.Dispose()
    End Sub
#End Region

#End Region

#Region "Tab_Control_KeyEnter"
    Private Sub dtpTu_Ngay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpTu_Ngay.KeyDown, dtpDen_Ngay.KeyDown, optTong_Hop_Thue_Le_Phi.KeyDown, optBuu_Pham_Da_Thu_Tien_Theo_Ngay_Dong.KeyDown, optBuu_Pham_Chua_Thu_Tien_Theo_Ngay_Dong.KeyDown, optBuu_Pham_Da_Thu_Tien_Theo_Ngay_Thu.KeyDown, optTat_Ca_Cac_Tinh.KeyDown, optTheo_Tinh.KeyDown, optTat_Ca_Duong_Thu_Buu_Ta.KeyDown, optTheo_Duong_Thu.KeyDown
        Select Case e.KeyValue
            Case 13 'Key Enter
                Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
            Case 37 'Key Left

            Case Else
        End Select
    End Sub
#End Region

    
End Class

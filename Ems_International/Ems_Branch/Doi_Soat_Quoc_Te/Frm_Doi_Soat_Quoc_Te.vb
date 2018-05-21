Imports Ems_International_Logic.EMS
Imports System.IO

Public Class Frm_Doi_Soat_Quoc_Te
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
    Friend WithEvents Menu_Danh_Muc As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_Danh_Muc_Doi_Soat As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_Danh_Muc_Cuoc As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_Cuoc_Quoc_Te_Den As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_Cuoc_Quoc_Te_Di As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_Cuoc_Qua_Giang_HongKong As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_Cuoc_Qua_Giang_Singapore As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_Cuoc_Qua_Giang_JNE As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_Cuoc_Hang_Khong As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_Thoat As System.Windows.Forms.MenuItem
    Friend WithEvents MainMenuDSQT As System.Windows.Forms.MainMenu
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_Tong_Hop_QT_Den As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btn_Tong_Hop_QT_Di As Infragistics.Win.Misc.UltraButton
    Friend WithEvents lbl_Trang_Thai As System.Windows.Forms.Label
    Friend WithEvents CbMa_Ca As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CbNgay_Kt As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents BtnThoat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents opt_Theo_Ca As System.Windows.Forms.RadioButton
    Friend WithEvents opt_Khoang_Thoi_Gian As System.Windows.Forms.RadioButton
    Friend WithEvents cb_Tu_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cb_Den_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents group_Ngay_Ca_Khai_Thac As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btn_Bao_Cao_Doanh_Thu_QT_Di As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btn_Bao_Cao_Doanh_Thu_QT_Den As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btn_Khoa_So_Lieu_QT_Den As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btn_Khoa_So_Lieu_QT_Di As Infragistics.Win.Misc.UltraButton
    Friend WithEvents menu_Bao_Cao As System.Windows.Forms.MenuItem
    Friend WithEvents Progress_E1 As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    Friend WithEvents progress_Chuyen_Thu As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    Friend WithEvents progress_Ca_San_Xuat As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    Friend WithEvents chk_Tong_Hop_Ca_Con_Thieu As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Ca", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ca_Khai_Thac")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thu_Tu")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ca")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_Doi_Soat_Quoc_Te))
        Me.MainMenuDSQT = New System.Windows.Forms.MainMenu
        Me.Menu_Danh_Muc = New System.Windows.Forms.MenuItem
        Me.Menu_Danh_Muc_Doi_Soat = New System.Windows.Forms.MenuItem
        Me.Menu_Danh_Muc_Cuoc = New System.Windows.Forms.MenuItem
        Me.Menu_Cuoc_Quoc_Te_Den = New System.Windows.Forms.MenuItem
        Me.Menu_Cuoc_Quoc_Te_Di = New System.Windows.Forms.MenuItem
        Me.Menu_Cuoc_Qua_Giang_HongKong = New System.Windows.Forms.MenuItem
        Me.Menu_Cuoc_Qua_Giang_Singapore = New System.Windows.Forms.MenuItem
        Me.Menu_Cuoc_Qua_Giang_JNE = New System.Windows.Forms.MenuItem
        Me.Menu_Cuoc_Hang_Khong = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.Menu_Thoat = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.menu_Bao_Cao = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.progress_Ca_San_Xuat = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar
        Me.progress_Chuyen_Thu = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar
        Me.Progress_E1 = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar
        Me.btn_Khoa_So_Lieu_QT_Di = New Infragistics.Win.Misc.UltraButton
        Me.btn_Khoa_So_Lieu_QT_Den = New Infragistics.Win.Misc.UltraButton
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
        Me.BtnThoat = New Infragistics.Win.Misc.UltraButton
        Me.lbl_Trang_Thai = New System.Windows.Forms.Label
        Me.btn_Bao_Cao_Doanh_Thu_QT_Di = New Infragistics.Win.Misc.UltraButton
        Me.btn_Bao_Cao_Doanh_Thu_QT_Den = New Infragistics.Win.Misc.UltraButton
        Me.btn_Tong_Hop_QT_Di = New Infragistics.Win.Misc.UltraButton
        Me.btn_Tong_Hop_QT_Den = New Infragistics.Win.Misc.UltraButton
        Me.chk_Tong_Hop_Ca_Con_Thieu = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.Panel1.SuspendLayout()
        CType(Me.group_Ngay_Ca_Khai_Thac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_Ngay_Ca_Khai_Thac.SuspendLayout()
        CType(Me.cb_Den_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_Tu_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbNgay_Kt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbMa_Ca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenuDSQT
        '
        Me.MainMenuDSQT.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Menu_Danh_Muc, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4})
        '
        'Menu_Danh_Muc
        '
        Me.Menu_Danh_Muc.Index = 0
        Me.Menu_Danh_Muc.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Menu_Danh_Muc_Doi_Soat, Me.Menu_Danh_Muc_Cuoc, Me.MenuItem5, Me.Menu_Thoat})
        Me.Menu_Danh_Muc.Text = CType(configurationAppSettings.GetValue("Menu_Danh_Muc.Text", GetType(System.String)), String)
        '
        'Menu_Danh_Muc_Doi_Soat
        '
        Me.Menu_Danh_Muc_Doi_Soat.Index = 0
        Me.Menu_Danh_Muc_Doi_Soat.Text = "Danh Mục Đối Soát"
        '
        'Menu_Danh_Muc_Cuoc
        '
        Me.Menu_Danh_Muc_Cuoc.Index = 1
        Me.Menu_Danh_Muc_Cuoc.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Menu_Cuoc_Quoc_Te_Den, Me.Menu_Cuoc_Quoc_Te_Di, Me.Menu_Cuoc_Qua_Giang_HongKong, Me.Menu_Cuoc_Qua_Giang_Singapore, Me.Menu_Cuoc_Qua_Giang_JNE, Me.Menu_Cuoc_Hang_Khong})
        Me.Menu_Danh_Muc_Cuoc.Text = "Danh Mục Cước"
        '
        'Menu_Cuoc_Quoc_Te_Den
        '
        Me.Menu_Cuoc_Quoc_Te_Den.Index = 0
        Me.Menu_Cuoc_Quoc_Te_Den.Text = "Quốc Tế Đến"
        '
        'Menu_Cuoc_Quoc_Te_Di
        '
        Me.Menu_Cuoc_Quoc_Te_Di.Index = 1
        Me.Menu_Cuoc_Quoc_Te_Di.Text = "Quốc Tế Đi"
        '
        'Menu_Cuoc_Qua_Giang_HongKong
        '
        Me.Menu_Cuoc_Qua_Giang_HongKong.Index = 2
        Me.Menu_Cuoc_Qua_Giang_HongKong.Text = "Quá Giang HongKong"
        '
        'Menu_Cuoc_Qua_Giang_Singapore
        '
        Me.Menu_Cuoc_Qua_Giang_Singapore.Index = 3
        Me.Menu_Cuoc_Qua_Giang_Singapore.Text = "Quá Giang Singapore"
        '
        'Menu_Cuoc_Qua_Giang_JNE
        '
        Me.Menu_Cuoc_Qua_Giang_JNE.Index = 4
        Me.Menu_Cuoc_Qua_Giang_JNE.Text = "Quá Giang JNE"
        '
        'Menu_Cuoc_Hang_Khong
        '
        Me.Menu_Cuoc_Hang_Khong.Index = 5
        Me.Menu_Cuoc_Hang_Khong.Text = "Hàng Không"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 2
        Me.MenuItem5.Text = "-"
        '
        'Menu_Thoat
        '
        Me.Menu_Thoat.Index = 3
        Me.Menu_Thoat.Text = "Thoát"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem14, Me.MenuItem15})
        Me.MenuItem2.Text = "Đối Soát Sản Lượng"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 0
        Me.MenuItem13.Text = "Tổng Hợp Sản Lượng"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 1
        Me.MenuItem14.Text = "Tổng Hợp CN55"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 2
        Me.MenuItem15.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem16, Me.MenuItem17, Me.MenuItem18})
        Me.MenuItem15.Text = "Tính Cước"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 0
        Me.MenuItem16.Text = "Quốc Tế Đến"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 1
        Me.MenuItem17.Text = "Quốc Tế Đi"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 2
        Me.MenuItem18.Text = "Quá Giang"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menu_Bao_Cao})
        Me.MenuItem3.Text = "Thống Kê Báo Cáo"
        '
        'menu_Bao_Cao
        '
        Me.menu_Bao_Cao.Index = 0
        Me.menu_Bao_Cao.Text = "Báo cáo đối soát"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem19, Me.MenuItem20})
        Me.MenuItem4.Text = "Trợ Giúp"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 0
        Me.MenuItem19.Text = "Trợ Giúp"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 1
        Me.MenuItem20.Text = "About"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.progress_Ca_San_Xuat)
        Me.Panel1.Controls.Add(Me.progress_Chuyen_Thu)
        Me.Panel1.Controls.Add(Me.Progress_E1)
        Me.Panel1.Controls.Add(Me.btn_Khoa_So_Lieu_QT_Di)
        Me.Panel1.Controls.Add(Me.btn_Khoa_So_Lieu_QT_Den)
        Me.Panel1.Controls.Add(Me.group_Ngay_Ca_Khai_Thac)
        Me.Panel1.Controls.Add(Me.BtnThoat)
        Me.Panel1.Controls.Add(Me.lbl_Trang_Thai)
        Me.Panel1.Controls.Add(Me.btn_Bao_Cao_Doanh_Thu_QT_Di)
        Me.Panel1.Controls.Add(Me.btn_Bao_Cao_Doanh_Thu_QT_Den)
        Me.Panel1.Controls.Add(Me.btn_Tong_Hop_QT_Di)
        Me.Panel1.Controls.Add(Me.btn_Tong_Hop_QT_Den)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(696, 393)
        Me.Panel1.TabIndex = 0
        '
        'progress_Ca_San_Xuat
        '
        Appearance1.FontData.BoldAsString = "True"
        Appearance1.FontData.SizeInPoints = 12.0!
        Me.progress_Ca_San_Xuat.Appearance = Appearance1
        Me.progress_Ca_San_Xuat.Location = New System.Drawing.Point(8, 248)
        Me.progress_Ca_San_Xuat.Name = "progress_Ca_San_Xuat"
        Me.progress_Ca_San_Xuat.Size = New System.Drawing.Size(680, 40)
        Me.progress_Ca_San_Xuat.TabIndex = 63
        Me.progress_Ca_San_Xuat.Text = "[Formatted]"
        '
        'progress_Chuyen_Thu
        '
        Appearance2.FontData.BoldAsString = "True"
        Appearance2.FontData.SizeInPoints = 10.0!
        Me.progress_Chuyen_Thu.Appearance = Appearance2
        Me.progress_Chuyen_Thu.Location = New System.Drawing.Point(8, 296)
        Me.progress_Chuyen_Thu.Name = "progress_Chuyen_Thu"
        Me.progress_Chuyen_Thu.Size = New System.Drawing.Size(680, 40)
        Me.progress_Chuyen_Thu.TabIndex = 62
        Me.progress_Chuyen_Thu.Text = "[Formatted]"
        '
        'Progress_E1
        '
        Appearance3.FontData.SizeInPoints = 10.0!
        Me.Progress_E1.Appearance = Appearance3
        Me.Progress_E1.Location = New System.Drawing.Point(8, 344)
        Me.Progress_E1.Name = "Progress_E1"
        Me.Progress_E1.Size = New System.Drawing.Size(680, 40)
        Me.Progress_E1.TabIndex = 61
        Me.Progress_E1.Text = "[Formatted]"
        '
        'btn_Khoa_So_Lieu_QT_Di
        '
        Me.btn_Khoa_So_Lieu_QT_Di.Location = New System.Drawing.Point(536, 48)
        Me.btn_Khoa_So_Lieu_QT_Di.Name = "btn_Khoa_So_Lieu_QT_Di"
        Me.btn_Khoa_So_Lieu_QT_Di.Size = New System.Drawing.Size(152, 32)
        Me.btn_Khoa_So_Lieu_QT_Di.TabIndex = 60
        Me.btn_Khoa_So_Lieu_QT_Di.Text = "Khóa Số Liệu Quốc Tế Đi"
        '
        'btn_Khoa_So_Lieu_QT_Den
        '
        Me.btn_Khoa_So_Lieu_QT_Den.Location = New System.Drawing.Point(376, 48)
        Me.btn_Khoa_So_Lieu_QT_Den.Name = "btn_Khoa_So_Lieu_QT_Den"
        Me.btn_Khoa_So_Lieu_QT_Den.Size = New System.Drawing.Size(152, 32)
        Me.btn_Khoa_So_Lieu_QT_Den.TabIndex = 59
        Me.btn_Khoa_So_Lieu_QT_Den.Text = "Khóa Số Liệu Quốc Tế Đến"
        '
        'group_Ngay_Ca_Khai_Thac
        '
        Me.group_Ngay_Ca_Khai_Thac.Controls.Add(Me.chk_Tong_Hop_Ca_Con_Thieu)
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
        Me.group_Ngay_Ca_Khai_Thac.Size = New System.Drawing.Size(360, 168)
        Me.group_Ngay_Ca_Khai_Thac.SupportThemes = False
        Me.group_Ngay_Ca_Khai_Thac.TabIndex = 56
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
        Appearance4.FontData.BoldAsString = "True"
        UltraGridColumn3.Header.Appearance = Appearance4
        UltraGridColumn3.Header.Caption = "Ca"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 30
        Appearance5.FontData.BoldAsString = "True"
        Appearance5.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn4.Header.Appearance = Appearance5
        UltraGridColumn4.Header.Caption = "Tên ca"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 70
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        UltraGridBand1.SummaryFooterCaption = "Grand Summaries"
        Me.CbMa_Ca.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance6.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance6.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.CbMa_Ca.DisplayLayout.Override.HeaderAppearance = Appearance6
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
        'BtnThoat
        '
        Appearance7.Image = CType(resources.GetObject("Appearance7.Image"), Object)
        Me.BtnThoat.Appearance = Appearance7
        Me.BtnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnThoat.ImageSize = New System.Drawing.Size(30, 25)
        Me.BtnThoat.Location = New System.Drawing.Point(376, 136)
        Me.BtnThoat.Name = "BtnThoat"
        Me.BtnThoat.Size = New System.Drawing.Size(312, 40)
        Me.BtnThoat.TabIndex = 55
        Me.BtnThoat.Text = "Thoát"
        '
        'lbl_Trang_Thai
        '
        Me.lbl_Trang_Thai.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Trang_Thai.Location = New System.Drawing.Point(8, 184)
        Me.lbl_Trang_Thai.Name = "lbl_Trang_Thai"
        Me.lbl_Trang_Thai.Size = New System.Drawing.Size(680, 56)
        Me.lbl_Trang_Thai.TabIndex = 5
        Me.lbl_Trang_Thai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Bao_Cao_Doanh_Thu_QT_Di
        '
        Me.btn_Bao_Cao_Doanh_Thu_QT_Di.Location = New System.Drawing.Point(536, 88)
        Me.btn_Bao_Cao_Doanh_Thu_QT_Di.Name = "btn_Bao_Cao_Doanh_Thu_QT_Di"
        Me.btn_Bao_Cao_Doanh_Thu_QT_Di.Size = New System.Drawing.Size(152, 40)
        Me.btn_Bao_Cao_Doanh_Thu_QT_Di.TabIndex = 3
        Me.btn_Bao_Cao_Doanh_Thu_QT_Di.Text = "Báo Cáo Doanh Thu Quốc Tế Đi"
        '
        'btn_Bao_Cao_Doanh_Thu_QT_Den
        '
        Me.btn_Bao_Cao_Doanh_Thu_QT_Den.Location = New System.Drawing.Point(376, 88)
        Me.btn_Bao_Cao_Doanh_Thu_QT_Den.Name = "btn_Bao_Cao_Doanh_Thu_QT_Den"
        Me.btn_Bao_Cao_Doanh_Thu_QT_Den.Size = New System.Drawing.Size(152, 40)
        Me.btn_Bao_Cao_Doanh_Thu_QT_Den.TabIndex = 2
        Me.btn_Bao_Cao_Doanh_Thu_QT_Den.Text = "Báo Cáo Doanh Thu Quốc Tế Đến"
        '
        'btn_Tong_Hop_QT_Di
        '
        Me.btn_Tong_Hop_QT_Di.Location = New System.Drawing.Point(536, 8)
        Me.btn_Tong_Hop_QT_Di.Name = "btn_Tong_Hop_QT_Di"
        Me.btn_Tong_Hop_QT_Di.Size = New System.Drawing.Size(152, 32)
        Me.btn_Tong_Hop_QT_Di.TabIndex = 1
        Me.btn_Tong_Hop_QT_Di.Text = "Tổng Hợp Quốc Tế Đi"
        '
        'btn_Tong_Hop_QT_Den
        '
        Me.btn_Tong_Hop_QT_Den.Location = New System.Drawing.Point(376, 8)
        Me.btn_Tong_Hop_QT_Den.Name = "btn_Tong_Hop_QT_Den"
        Me.btn_Tong_Hop_QT_Den.Size = New System.Drawing.Size(152, 32)
        Me.btn_Tong_Hop_QT_Den.TabIndex = 0
        Me.btn_Tong_Hop_QT_Den.Text = "Tổng Hợp Quốc Tế Đến"
        '
        'chk_Tong_Hop_Ca_Con_Thieu
        '
        Me.chk_Tong_Hop_Ca_Con_Thieu.Location = New System.Drawing.Point(8, 136)
        Me.chk_Tong_Hop_Ca_Con_Thieu.Name = "chk_Tong_Hop_Ca_Con_Thieu"
        Me.chk_Tong_Hop_Ca_Con_Thieu.Size = New System.Drawing.Size(192, 24)
        Me.chk_Tong_Hop_Ca_Con_Thieu.TabIndex = 62
        Me.chk_Tong_Hop_Ca_Con_Thieu.Text = "Tổng Hợp Ca Còn Thiếu"
        '
        'Frm_Doi_Soat_Quoc_Te
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(696, 393)
        Me.Controls.Add(Me.Panel1)
        Me.Menu = Me.MainMenuDSQT
        Me.Name = "Frm_Doi_Soat_Quoc_Te"
        Me.Text = "Đối Soát Quốc Tế"
        Me.Panel1.ResumeLayout(False)
        CType(Me.group_Ngay_Ca_Khai_Thac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_Ngay_Ca_Khai_Thac.ResumeLayout(False)
        CType(Me.cb_Den_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_Tu_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbNgay_Kt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbMa_Ca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim myMa_Ca As New Ma_Ca(GConnectionString)

#Region "==================Quốc Tế Đến======================"
#Region "=================btn_Tong_Hop_QT_Den_Click========================"
    Private Sub btn_Tong_Hop_QT_Den_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Tong_Hop_QT_Den.Click
        Dim Ma_Bc_Khai_Thac As Integer
        Ma_Bc_Khai_Thac = Tim_Buu_Cuc_Khai_Thac_QT(True) 'Tìm bưu cục khai thác quốc tế đến
        If Ma_Bc_Khai_Thac = 0 Then
            MessageBox.Show("Không tồn tại bưu cục khai thác nào thỏa mãn yêu cầu", "Thông báo", MessageBoxButtons.OK)
            Exit Sub
        End If
        'Kiểm tra thông tin bưu cục khai thác đăng nhập 
        Dim m_DSQT_Danh_Muc_Bc_Khai_Thac As New DSQT_Danh_Muc_Bc_Khai_Thac(GConnectionString)
        Dim m_DSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet As New DSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet
        m_DSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet = m_DSQT_Danh_Muc_Bc_Khai_Thac.DSQT_Danh_Muc_Bc_Khai_Thac_Lay(Ma_Bc_Khai_Thac)
        If m_DSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet.IMPC = "" Then
            MessageBox.Show("Bạn không được phép tổng hợp sản lượng quốc tế đến cho bưu cục này!!!", "Thông báo", MessageBoxButtons.OK)
            Exit Sub
        End If
        If m_DSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet.Quoc_Te_Den = False Then 'là bưu cục quốc tế đi trong này
            MessageBox.Show("Bạn không được phép tổng hợp sản lượng quốc tế đến cho bưu cục này!!!", "Thông báo", MessageBoxButtons.OK)
            Exit Sub
        End If
        'Lấy thông tin
        Dim Buu_Cuc_Khai_Thac As Integer
        Dim Ngay_Khai_Thac As Integer

        'Lấy Id_Ca khai thác cần tổng hợp quốc tế đến
        Dim m_Ca_San_Xuat As New Ca_San_Xuat(GConnectionString)
        Dim Id_Ca As String
        If opt_Khoang_Thoi_Gian.Checked = True Then
            'Lấy danh sách các ca có trong khoảng thời gian
            Dim m_Ham_Dung_Chung As New Ham_Dung_Chung
            Dim Tu_Ngay As Integer
            Dim Den_Ngay As Integer
            Tu_Ngay = m_Ham_Dung_Chung.ConvertDateToInt(cb_Tu_Ngay.DateTime)
            Den_Ngay = m_Ham_Dung_Chung.ConvertDateToInt(cb_Den_Ngay.DateTime)
            If Tu_Ngay > Den_Ngay Then
                MessageBox.Show("Khoảng thời gian không có thật!!!", "Thông báo", MessageBoxButtons.OK)
                cb_Tu_Ngay.Focus()
                Exit Sub
            End If
            Dim ds_Ca_San_Xuat As New DataSet
            ds_Ca_San_Xuat = m_Ca_San_Xuat.Ca_San_Xuat_Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac_Tu_Ngay_Den_Ngay(Ma_Bc_Khai_Thac, Tu_Ngay, Den_Ngay)
            Dim Tong_So_Ca_San_Xuat As Integer
            Tong_So_Ca_San_Xuat = ds_Ca_San_Xuat.Tables(0).Rows.Count
            If Tong_So_Ca_San_Xuat = 0 Then
                MessageBox.Show("Không tồn tại ca sản xuất nào trong khoảng thời gian này!!!", "Thông báo", MessageBoxButtons.OK)
                cb_Tu_Ngay.Focus()
                Exit Sub
            End If
            Dim idx As Integer
            ActiveForm.Cursor.Current = Cursors.WaitCursor
            progress_Ca_San_Xuat.Maximum = Tong_So_Ca_San_Xuat
            progress_Ca_San_Xuat.Text = "( " & progress_Chuyen_Thu.Value & "  /  " & progress_Chuyen_Thu.Maximum & " )"
            progress_Ca_San_Xuat.Step = 1
            progress_Ca_San_Xuat.Value = 0
            For idx = 0 To Tong_So_Ca_San_Xuat - 1
                ActiveForm.Cursor.Current = Cursors.WaitCursor
                progress_Ca_San_Xuat.PerformStep()
                progress_Ca_San_Xuat.Text = "( " & progress_Ca_San_Xuat.Value & "  /  " & progress_Ca_San_Xuat.Maximum & " )"
                progress_Ca_San_Xuat.Update()
                Application.DoEvents()
                Id_Ca = ds_Ca_San_Xuat.Tables(0).Rows(idx).Item("Id_Ca")
                'Kiểm tra điều kiện trước khi tổng hợp dữ liệu
                Dim Da_Tong_Hop As Boolean = False
                Dim Da_Chot_So_Lieu As Boolean = False

                Dim m_DSQT_Thong_Tin_Ke_Toan_Ca As New DSQT_Thong_Tin_Ke_Toan_Ca(GConnectionString)
                Dim m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet As New DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet
                m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet = m_DSQT_Thong_Tin_Ke_Toan_Ca.DSQT_Thong_Tin_Ke_Toan_Ca_Lay_Chi_Tiet_Tong_Hop_Gan_Nhat_Theo_Ca(Id_Ca)
                If m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Id_Ke_Toan <> "" Then
                    Da_Tong_Hop = True
                    If m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Chot_SL = True Then
                        Da_Chot_So_Lieu = True
                    Else
                        Da_Chot_So_Lieu = False
                    End If
                Else
                    Da_Tong_Hop = False
                    Da_Chot_So_Lieu = False
                End If

                If Da_Tong_Hop = True Then
                    If chk_Tong_Hop_Ca_Con_Thieu.Checked = True Then 'Không tiếp tục với những ca đã có dữ liệu
                        GoTo Ca_Tiep_Theo
                    End If
                    'Tìm xem số liệu tổng hợp lần gần đây nhất xem đã được chốt chưa
                    If Da_Chot_So_Lieu = True Then
                        MessageBox.Show("Số liệu đã được chốt bạn không thể tổng hợp lại số liệu được!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        GoTo Ca_Tiep_Theo
                    End If
                    If MessageBox.Show("Số liệu ca khai thác này đã được tổng hợp!!!" & vbNewLine & "Bạn có muốn tổng hợp lại số liệu không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                        GoTo Ca_Tiep_Theo
                    End If
                End If

                If Da_Tong_Hop = True Then 'Nếu cho phép tổng hợp lại số liệu
                    'Xóa dữ liệu đã tổng hợp trong bảng DSQT_E1_Quoc_Te_Den
                    lbl_Trang_Thai.Text = "Đang xóa dữ liệu tổng hợp cũ (" & Ma_Bc_Khai_Thac & ")"
                    'Xóa trong bảng E1
                    Application.DoEvents()
                    Dim m_DSQT_E1_Quoc_Te_Den As New DSQT_E1_Quoc_Te_Den(GConnectionString)
                    m_DSQT_E1_Quoc_Te_Den.DSQT_E1_Quoc_Te_Den_Xoa_Theo_Ca_Khai_Thac(Id_Ca)
                    Application.DoEvents()
                    'Xóa trong bảng CN55
                    Dim m_DSQT_CN55 As New DSQT_CN55(GConnectionString)
                    m_DSQT_CN55.DSQT_CN55_Xoa_Theo_Ca_Khai_Thac(Id_Ca)
                    Application.DoEvents()
                End If


                'Tổng hợp dữ liệu
                lbl_Trang_Thai.Text = "Đang tổng hợp dữ liệu ca " & ds_Ca_San_Xuat.Tables(0).Rows(idx).Item("Thu_Tu") & " " & m_Ham_Dung_Chung.ConvertIntToDate_VN(CInt(ds_Ca_San_Xuat.Tables(0).Rows(idx).Item("Ngay_Khai_Thac")))
                If Tong_Hop_Quoc_Te_Den_Theo_Ca(Id_Ca, Ma_Bc_Khai_Thac) = False Then
                    MessageBox.Show("Tổng hợp số liệu lỗi!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If
Ca_Tiep_Theo:
            Next
            lbl_Trang_Thai.Text = "Tổng hợp dữ liệu quốc tế (" & Ma_Bc_Khai_Thac & ") đến thành công"
        Else
            Id_Ca = get_Id_Ca(Ma_Bc_Khai_Thac)
            'Kiểm tra điều kiện trước khi tổng hợp dữ liệu
            Dim Da_Tong_Hop As Boolean = False
            Dim Da_Chot_So_Lieu As Boolean = False

            Dim m_DSQT_Thong_Tin_Ke_Toan_Ca As New DSQT_Thong_Tin_Ke_Toan_Ca(GConnectionString)
            Dim m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet As New DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet
            m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet = m_DSQT_Thong_Tin_Ke_Toan_Ca.DSQT_Thong_Tin_Ke_Toan_Ca_Lay_Chi_Tiet_Tong_Hop_Gan_Nhat_Theo_Ca(Id_Ca)
            If m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Id_Ke_Toan <> "" Then
                Da_Tong_Hop = True
                If m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Chot_SL = True Then
                    Da_Chot_So_Lieu = True
                Else
                    Da_Chot_So_Lieu = False
                End If
            Else
                Da_Tong_Hop = False
                Da_Chot_So_Lieu = False
            End If

            If Da_Tong_Hop = True Then
                'Tìm xem số liệu tổng hợp lần gần đây nhất xem đã được chốt chưa
                If Da_Chot_So_Lieu = True Then
                    MessageBox.Show("Số liệu đã được chốt bạn không thể tổng hợp lại số liệu được!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If
                If MessageBox.Show("Số liệu ca khai thác này đã được tổng hợp!!!" & vbNewLine & "Bạn có muốn tổng hợp lại số liệu không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Exit Sub
                End If
            End If

            If Da_Tong_Hop = True Then 'Nếu cho phép tổng hợp lại số liệu
                'Xóa dữ liệu đã tổng hợp trong bảng DSQT_E1_Quoc_Te_Den
                lbl_Trang_Thai.Text = "Đang xóa dữ liệu tổng hợp cũ (" & Ma_Bc_Khai_Thac & ")"
                'Xóa trong bảng E1
                Application.DoEvents()
                Dim m_DSQT_E1_Quoc_Te_Den As New DSQT_E1_Quoc_Te_Den(GConnectionString)
                m_DSQT_E1_Quoc_Te_Den.DSQT_E1_Quoc_Te_Den_Xoa_Theo_Ca_Khai_Thac(Id_Ca)
                Application.DoEvents()
                'Xóa trong bảng CN55
                Dim m_DSQT_CN55 As New DSQT_CN55(GConnectionString)
                m_DSQT_CN55.DSQT_CN55_Xoa_Theo_Ca_Khai_Thac(Id_Ca)
                Application.DoEvents()
            End If

            'Tổng hợp dữ liệu
            lbl_Trang_Thai.Text = "Đang tổng hợp dữ liệu (" & Ma_Bc_Khai_Thac & ")"
            If Tong_Hop_Quoc_Te_Den_Theo_Ca(Id_Ca, Ma_Bc_Khai_Thac) = False Then
                MessageBox.Show("Tổng hợp số liệu lỗi!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
            lbl_Trang_Thai.Text = "Tổng hợp dữ liệu quốc tế (" & Ma_Bc_Khai_Thac & ") đến thành công"
        End If
        progress_Ca_San_Xuat.Value = 0
        ActiveForm.Cursor.Current = Cursors.Default
    End Sub

#End Region

#Region "----------get_Id_Ca-------------"
    Private Function get_Id_Ca(ByVal Ma_Bc_Khai_Thac As Integer) As String
        Dim myHam_Dung_Chung As New Ham_Dung_Chung
        Return Ma_Bc_Khai_Thac & myHam_Dung_Chung.ConvertDateToInt(CbNgay_Kt.DateTime) & CbMa_Ca.Value
    End Function
#End Region

#Region "--------------------Tong_Hop_Quoc_Te_Den_Theo_Ca--------------------"
    Private Function Tong_Hop_Quoc_Te_Den_Theo_Ca(ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer) As Boolean
        Try
            'Lấy dữ liệu quốc tế đến theo ca
            Dim m_E1_Den As New E1_Den(GConnectionString)
            Dim m_E1_Den_Chi_Tiet As New E1_Den_Chi_Tiet
            Dim m_DSQT_E1_Quoc_Te_Den As New DSQT_E1_Quoc_Te_Den(GConnectionString)
            Dim m_DSQT_E1_Quoc_Te_Den_Chi_Tiet As New DSQT_E1_Quoc_Te_Den_Chi_Tiet
            Dim m_E2_Den As New E2_Den(GConnectionString)
            'Lấy dữ liệu sử dụng chung cho tất cả các dòng

            Dim m_Chuyen_Thu_Den As New Chuyen_Thu_Den(GConnectionString)
            Dim ds_Chuyen_Thu_Den As New DataSet
            'Lấy danh sách chuyến thư quốc tế đến
            ds_Chuyen_Thu_Den = m_Chuyen_Thu_Den.Danh_Sach_Chuyen_Thu_Den_Theo_Ca(Id_Ca)
            Dim Tong_So_Chuyen_Thu As Integer
            Tong_So_Chuyen_Thu = ds_Chuyen_Thu_Den.Tables(0).Rows.Count
            If Tong_So_Chuyen_Thu = 0 Then
                MessageBox.Show("Ca khai thác này không tồn tại bưu phẩm nào!!!" & vbNewLine & "Bạn hãy kiểm tra lại thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Return True
            End If
            '==========================
            Dim m_Ca_San_Xuat As New Ca_San_Xuat(GConnectionString)
            Dim m_Ca_San_Xuat_Chi_Tiet As New Ca_San_Xuat_Chi_Tiet
            m_Ca_San_Xuat_Chi_Tiet = m_Ca_San_Xuat.Lay(Id_Ca)
            Dim Ngay_Khai_Thac As Integer
            Dim Ca_Khai_Thac As Integer
            Ngay_Khai_Thac = m_Ca_San_Xuat_Chi_Tiet.Ngay_Khai_Thac
            Ca_Khai_Thac = m_Ca_San_Xuat_Chi_Tiet.Thu_Tu
            'Lấy thông tin vào bảng DSQT_Thong_Tin_Ke_Toan_Ca
            Dim m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet As New DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet
            Dim m_DSQT_Thong_Tin_Ke_Toan_Ca As New DSQT_Thong_Tin_Ke_Toan_Ca(GConnectionString)
            Dim STT_Max As Integer
            STT_Max = m_DSQT_Thong_Tin_Ke_Toan_Ca.DSQT_Thong_Tin_Ke_Toan_Ca_Lay_Chi_Tiet_Tong_Hop_Gan_Nhat_Theo_Ca(Id_Ca).STT
            'Lấy trạng thái đã được cập nhật theo ca
            m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Id_Ke_Toan = Create_Id_DSQT_Thong_Tin_Ke_Toan_Ca(Id_Ca, STT_Max + 1)
            m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Id_Ca = Id_Ca
            m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Ma_Trang_Thai = 0 'bắt đầu tổng hợp -> lỗi
            m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.STT = STT_Max + 1
            m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Ma_Bc_Khai_Thac = Ma_Bc_Khai_Thac
            m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Ngay_Khai_Thac = Ngay_Khai_Thac
            m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Ca_Khai_Thac = Ca_Khai_Thac
            m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Tong_So_Chuyen_Thu = 0
            m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Tong_So_E2 = 0
            m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Tong_So_BP_D = 0
            m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Tong_So_BP_M = 0
            m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Khoi_Luong_BP_D = 0
            m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Khoi_Luong_BP_M = 0
            m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Chi_Tiet_Trang_Thai = ""
            m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Ngay_He_Thong = 0
            m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Gio_He_Thong = 0
            m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Id_Nguoi_Dung = Gid_Nguoi_Dung
            m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Ghi_Chu = ""
            m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Chot_SL = False
            'Cập nhật trạng thái mới
            If Cap_Nhat_DSQT_Thong_Tin_Ke_Toan_Ca(m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet) = False Then
                Return False
            End If
            '=================== Biến dùng cho toàn ca khai thác=============
            Dim Tong_So_E2 As Integer = 0
            Dim Tong_So_BP_D As Integer = 0
            Dim Tong_So_BP_M As Integer = 0
            Dim Khoi_Luong_BP_D As Integer = 0
            Dim Khoi_Luong_BP_M As Integer = 0
            '===========================
            ActiveForm.Cursor.Current = Cursors.WaitCursor
            progress_Chuyen_Thu.Maximum = Tong_So_Chuyen_Thu
            progress_Chuyen_Thu.Text = "( " & progress_Chuyen_Thu.Value & "  /  " & progress_Chuyen_Thu.Maximum & " )"
            progress_Chuyen_Thu.Step = 1
            progress_Chuyen_Thu.Value = 0
            Dim i As Integer
            For i = 0 To Tong_So_Chuyen_Thu - 1
                ActiveForm.Cursor.Current = Cursors.WaitCursor
                progress_Chuyen_Thu.PerformStep()
                progress_Chuyen_Thu.Text = "( " & progress_Chuyen_Thu.Value & "  /  " & progress_Chuyen_Thu.Maximum & " )"
                Application.DoEvents()
                'Lấy chi tiết chuyến thư
                '============Biến dùng cho chuyến thư chính=================
                Dim Id_Chuyen_Thu As String
                Dim Loai_Chuyen_Thu As String
                Dim m_Duong_Thu_Den As New Duong_Thu_Den(GConnectionString)
                Dim m_Chuyen_Thu_Den_Chi_Tiet As New Chuyen_Thu_Den_Chi_Tiet
                Dim Id_Duong_Thu As String
                Dim Ma_Bc As Integer
                Id_Duong_Thu = ds_Chuyen_Thu_Den.Tables(0).Rows(i).Item("Id_Duong_Thu")
                Ma_Bc = m_Duong_Thu_Den.Lay(Id_Duong_Thu).Ma_Bc
                Id_Chuyen_Thu = ds_Chuyen_Thu_Den.Tables(0).Rows(i).Item("Id_Chuyen_Thu")
                Loai_Chuyen_Thu = Id_Chuyen_Thu.Substring(Id_Chuyen_Thu.Length - 2, 2) 'Lấy loại chuyến thư
                m_Chuyen_Thu_Den_Chi_Tiet = m_Chuyen_Thu_Den.Lay(Id_Chuyen_Thu)
                'Lấy chi tiết ca khai thác

                'Lấy danh sách các nước nhận bưu phẩm có trong chuyến thư
                Dim m_Danh_Muc_Bc As New Danh_Muc_BC(GConnectionString)
                Dim ds_Nuoc_Nhan As New DataSet
                Dim Tong_So_Nuoc_Nhan As Integer
                Dim Ma_Nuoc_Duong_Thu As String
                Ma_Nuoc_Duong_Thu = m_Danh_Muc_Bc.Lay(Ma_Bc).Ma_Nc
                '=============================================
                If Ma_Nuoc_Duong_Thu <> "VN" Then 'Không tính toán với đường thư có mã nước là VN
                    'Lấy chi tiết nước nhận có trong chuyến thư
                    ds_Nuoc_Nhan = m_E1_Den.E1_Den_Danh_Sach_Nuoc_Nhan_Lay_Boi_Id_Chuyen_Thu(Id_Chuyen_Thu)
                    Tong_So_Nuoc_Nhan = ds_Nuoc_Nhan.Tables(0).Rows.Count
                    If Tong_So_Nuoc_Nhan = 0 Then
                        GoTo Chuyen_Thu_Tiep_Theo
                    End If
                    Dim j As Integer
                    Progress_E1.Maximum = m_Chuyen_Thu_Den_Chi_Tiet.Tong_So_BP
                    Progress_E1.Text = "( " & Progress_E1.Value & "  /  " & Progress_E1.Maximum & " )"
                    Progress_E1.Step = 1
                    Progress_E1.Value = 0
                    For j = 0 To Tong_So_Nuoc_Nhan - 1
                        Dim Nuoc_Nhan As String
                        Dim Tong_So As Integer
                        Nuoc_Nhan = ds_Nuoc_Nhan.Tables(0).Rows(j).Item("Nuoc_Nhan")
                        Tong_So = CInt(ds_Nuoc_Nhan.Tables(0).Rows(j).Item("Tong_So"))
                        '===============================================================
                        Dim Ma_Nuoc_Thanh_Toan As String = ""
                        Dim Ma_Bc_Thanh_Toan As Integer = 0
                        Dim IMPC_Thanh_Toan As String = ""
                        Dim m_DSQT_Danh_Muc_Bc_Quoc_Te As New DSQT_Danh_Muc_Bc_Quoc_Te(GConnectionString)
                        If Ma_Nuoc_Duong_Thu = Nuoc_Nhan Then 'đúng hướng
                            Ma_Nuoc_Thanh_Toan = Ma_Nuoc_Duong_Thu
                            Ma_Bc_Thanh_Toan = Ma_Bc 'Tim_Ma_Bc_Thanh_Toan(Ma_Nuoc_Thanh_Toan)
                            IMPC_Thanh_Toan = m_DSQT_Danh_Muc_Bc_Quoc_Te.DSQT_Danh_Muc_Bc_Quoc_Te_Lay(Ma_Bc_Thanh_Toan).IMPC
                        Else 'sai hướng
                            Ma_Nuoc_Thanh_Toan = Nuoc_Nhan
                            Ma_Bc_Thanh_Toan = Tim_Ma_Bc_Thanh_Toan(Ma_Nuoc_Thanh_Toan) 'Tìm Mã bưu cục thanh toán theo mã nước thanh toán
                            IMPC_Thanh_Toan = m_DSQT_Danh_Muc_Bc_Quoc_Te.DSQT_Danh_Muc_Bc_Quoc_Te_Lay(Ma_Bc_Thanh_Toan).IMPC
                        End If
                        '===============================================================
                        'Danh sách E1 theo chuyến thư, nước nhận
                        Dim ds_E1 As New DataSet
                        ds_E1 = m_E1_Den.E1_Den_Danh_Sach_Lay_Boi_Id_Chuyen_Thu_Nuoc_Nhan(Id_Chuyen_Thu, Nuoc_Nhan, Ma_Nuoc_Duong_Thu)
                        Dim idx As Integer
                        '======================Biến sử dụng trong từng nước thanh toán
                        Dim So_Luong_D As Integer = 0
                        Dim Khoi_Luong_D As Integer = 0
                        Dim So_Luong_M As Integer = 0
                        Dim Khoi_Luong_M As Integer = 0
                        Dim So_Luong_R As Integer = 0
                        Dim Khoi_Luong_R As Integer = 0
                        Dim So_Luong_OPS As Integer = 0
                        Dim Khoi_Luong_OPS As Integer = 0

                        Dim Cuoc_Theo_SL As Double = 0
                        Dim Cuoc_Theo_KL As Double = 0
                        Dim Cuoc_VCMBND As Double = 0
                        Dim Cuoc_Hang_Khong As Double = 0
                        Dim Khoi_Luong_Vo_Tui As Integer = 0

                        Dim Cuoc_Khac As Double = 0
                        Dim Doanh_Thu_D As Double = 0
                        Dim Doanh_Thu_M As Double = 0
                        Dim Tong_Doanh_Thu As Double = 0

                        Dim Ma_Tien_Te As String = ""
                        '==================================================
                        'Cập nhật DSQT_E1_Quoc_Te_Den
                        For idx = 0 To Tong_So - 1
                            ActiveForm.Cursor.Current = Cursors.WaitCursor
                            Progress_E1.PerformStep()
                            Progress_E1.Text = "( " & Progress_E1.Value & "  /  " & Progress_E1.Maximum & " )"
                            Progress_E1.Show()
                            Application.DoEvents()
                            'Cập nhật DSQT_E1_Quoc_Te_Den
                            Dim Id_E1 As String
                            Id_E1 = ds_E1.Tables(0).Rows(idx).Item("Id_E1")
                            m_E1_Den_Chi_Tiet = m_E1_Den.Lay(Id_E1)

                            'Lấy chi tiết DSQT_E1_Quoc_Te_Den
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Id_E1 = m_E1_Den_Chi_Tiet.Id_E1
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Id_Duong_Thu = m_E1_Den_Chi_Tiet.Id_Duong_Thu
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.IMPC = m_DSQT_Danh_Muc_Bc_Quoc_Te.DSQT_Danh_Muc_Bc_Quoc_Te_Lay(Ma_Bc).IMPC
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Ma_Bc = Ma_Bc
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Noi_Gui = m_DSQT_Danh_Muc_Bc_Quoc_Te.DSQT_Danh_Muc_Bc_Quoc_Te_Lay(Ma_Bc).Ma_Vung
                            Dim m_Danh_Muc_Bc_Chi_Tiet As New Danh_Muc_BC_Chi_Tiet
                            m_Danh_Muc_Bc_Chi_Tiet = m_Danh_Muc_Bc.Lay(m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Ma_Bc)
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Ma_Nuoc_Duong_Thu = Ma_Nuoc_Duong_Thu
                            '---------------------Default----------------------
                            'Thông tin về đơn vị thanh toán tạm thời lấy mặc định
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Ma_Nuoc_Thanh_Toan = Ma_Nuoc_Thanh_Toan
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Ma_Bc_Thanh_Toan = Ma_Bc_Thanh_Toan
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.IMPC_Thanh_Toan = IMPC_Thanh_Toan
                            'Phân loại thanh toán: D/M (có thể phụ thuộc vào loại chuyến thư hoặc do quy định về D/M của từng nước)
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Phan_Loai_Thanh_Toan = m_E1_Den_Chi_Tiet.Phan_Loai 'Tạm thời tính bằng phân loại của bưu gửi
                            '----------------------------------------------------
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Id_Chuyen_Thu = m_E1_Den_Chi_Tiet.Id_Chuyen_Thu
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Loai_Chuyen_Thu = Loai_Chuyen_Thu
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.So_Chuyen_Thu = m_Chuyen_Thu_Den_Chi_Tiet.So_Chuyen_Thu
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Id_E2 = m_E1_Den_Chi_Tiet.Id_E2
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Tui_So = m_E2_Den.Lay(m_E1_Den_Chi_Tiet.Id_E2).Tui_So
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Id_Ca = m_E1_Den_Chi_Tiet.Id_Ca
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Ngay_Khai_Thac = Ngay_Khai_Thac
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Ca_Khai_Thac = Ca_Khai_Thac
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Ma_Bc_Khai_Thac = m_E1_Den_Chi_Tiet.Ma_Bc_Khai_Thac
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Ma_E1 = m_E1_Den_Chi_Tiet.Ma_E1
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Ngay_Dong = m_E1_Den_Chi_Tiet.Ngay_Dong
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Gio_Dong = m_E1_Den_Chi_Tiet.Gio_Dong
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Ngay_Nhan = m_E1_Den_Chi_Tiet.Ngay_Nhan
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Gio_Nhan = m_E1_Den_Chi_Tiet.Gio_Nhan
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Ma_Bc_Goc = m_E1_Den_Chi_Tiet.Ma_Bc_Goc
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Ma_Bc_Tra = m_E1_Den_Chi_Tiet.Ma_Bc_Tra
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Nuoc_Nhan = m_E1_Den_Chi_Tiet.Nuoc_Nhan
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Nuoc_Tra = m_E1_Den_Chi_Tiet.Nuoc_Tra
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Khoi_Luong = m_E1_Den_Chi_Tiet.Khoi_Luong
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Phan_Loai = m_E1_Den_Chi_Tiet.Phan_Loai
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Loai_Hang_Hoa = m_E1_Den_Chi_Tiet.Loai_Hang_Hoa
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Khoi_Luong_QD = m_E1_Den_Chi_Tiet.Khoi_Luong_QD
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Loai = m_E1_Den_Chi_Tiet.Loai
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.STT = m_E1_Den_Chi_Tiet.STT
                            '---------------------Default----------------------
                            'Tính cước phát quốc tế đến
                            Dim m_DSQT_Cuoc_Quoc_Te_Den_Chi_Tiet As New DSQT_Cuoc_Phat_QT_Den_Chi_Tiet
                            Dim m_DSQT_Cuoc_Quoc_Te_Den As New DSQT_Cuoc_Phat_QT_Den(GConnectionString)
                            Dim Id_Dot As String
                            'Lấy Id_Dot
                            Dim m_DSQT_Danh_Muc_Dot As New DSQT_Danh_Muc_Dot(GConnectionString)
                            Id_Dot = m_DSQT_Danh_Muc_Dot.DSQT_Danh_Muc_Dot_Lay_Theo_Ngay_Dong_Ten_Doi_Tuong(m_E1_Den_Chi_Tiet.Ngay_Dong, "DSQT_Cuoc_Phat_QT_Den").Id_Dot
                            If Id_Dot = "" Then 'Nếu không tìm thấy đợt tính cước
                                m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Cuoc_Theo_SL = 0
                                m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Cuoc_Theo_KL = 0
                                m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Cuoc_Khac = 0
                                m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Cuoc_VCMBND = 0
                                m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Ma_Tien_Te = "VND"
                                m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Tong_Doanh_Thu = 0
                                m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Tong_Doanh_Thu_VND = 0
                            Else
                                m_DSQT_Cuoc_Quoc_Te_Den_Chi_Tiet = m_DSQT_Cuoc_Quoc_Te_Den.DSQT_Cuoc_Phat_QT_Den_Lay(Create_Id_Cuoc(m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Ma_Nuoc_Thanh_Toan, Id_Dot))
                                If m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Phan_Loai_Thanh_Toan = "D" Then
                                    m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Cuoc_Theo_SL = m_DSQT_Cuoc_Quoc_Te_Den_Chi_Tiet.Cuoc_BP_D
                                Else
                                    m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Cuoc_Theo_SL = m_DSQT_Cuoc_Quoc_Te_Den_Chi_Tiet.Cuoc_BP_M
                                End If
                                m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Cuoc_Theo_KL = (m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Khoi_Luong / 1000) * m_DSQT_Cuoc_Quoc_Te_Den_Chi_Tiet.Cuoc
                                m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Cuoc_Khac = 0
                                m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Cuoc_VCMBND = m_DSQT_Cuoc_Quoc_Te_Den_Chi_Tiet.Cuoc_VCMBND
                                m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Ma_Tien_Te = m_DSQT_Cuoc_Quoc_Te_Den_Chi_Tiet.Ma_Tien_Te
                                m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Tong_Doanh_Thu = m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Cuoc_Theo_SL + m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Cuoc_Theo_KL
                                'Lấy tỷ giá với VND
                                Dim Ty_Gia_VND As Integer
                                Ty_Gia_VND = 20850
                                m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Tong_Doanh_Thu_VND = CInt(m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Tong_Doanh_Thu * Ty_Gia_VND)
                            End If
                            '----------------------------------------------------
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Id_Nguoi_Dung = Gid_Nguoi_Dung 'Người dùng tổng hợp
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Id_Trang_Thai = m_E1_Den_Chi_Tiet.Id_Trang_Thai
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Ghi_Chu = m_E1_Den_Chi_Tiet.Ghi_Chu
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Ngay_He_Thong = 0
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Gio_He_Thong = 0
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Chot_SL = False
                            m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Id_Dich_Vu = Get_Id_Dich_Vu(m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Ma_E1)
                            'Cập nhật vào bảng DSQT_E1_Quoc_Te_Den
                            If Cap_Nhat_DSQT_E1_Quoc_Te_Den(m_DSQT_E1_Quoc_Te_Den_Chi_Tiet) = False Then
                                MessageBox.Show("Có lỗi xảy ra trong quá trình lấy số liệu quốc tế đến!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                ActiveForm.Cursor.Current = Cursors.Default
                                Return False
                                '    End If
                            End If
                            'Tính tổng theo từng chuyến thư                        
                            If m_E1_Den_Chi_Tiet.Loai = 1 Then 'sự vụ->không tính cước
                                So_Luong_OPS = So_Luong_OPS + 1
                                Khoi_Luong_OPS = Khoi_Luong_OPS + m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Khoi_Luong
                            Else
                                If m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Nuoc_Nhan = "VN" Then 'Chuyển hoàn -> không tính cước
                                    So_Luong_R = So_Luong_R + 1
                                    Khoi_Luong_R = Khoi_Luong_R + m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Khoi_Luong
                                Else 'Không phải chuyển hoàn -> tính cước
                                    If m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Phan_Loai_Thanh_Toan = "D" Then
                                        So_Luong_D = So_Luong_D + 1
                                        Khoi_Luong_D = Khoi_Luong_D + m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Khoi_Luong
                                        Doanh_Thu_D = Doanh_Thu_D + m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Cuoc_Theo_SL
                                        'Tính toàn ca khai thác
                                        Tong_So_BP_D = Tong_So_BP_D + 1
                                        Khoi_Luong_BP_D = Khoi_Luong_BP_D + m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Khoi_Luong
                                    Else
                                        So_Luong_M = So_Luong_M + 1
                                        Khoi_Luong_M = Khoi_Luong_M + m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Khoi_Luong
                                        Doanh_Thu_M = Doanh_Thu_M + m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Cuoc_Theo_SL
                                        'Tính toàn ca khai thác
                                        Tong_So_BP_M = Tong_So_BP_M + 1
                                        Khoi_Luong_BP_M = Khoi_Luong_BP_M + m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Khoi_Luong
                                    End If
                                    Cuoc_Theo_SL = Cuoc_Theo_SL + m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Cuoc_Theo_SL
                                    Cuoc_Theo_KL = Cuoc_Theo_KL + m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Cuoc_Theo_KL
                                    Cuoc_VCMBND = Cuoc_VCMBND + m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Cuoc_VCMBND
                                    Cuoc_Hang_Khong = 0
                                    Cuoc_Khac = 0
                                End If
                            End If
                            Khoi_Luong_Vo_Tui = 0
                            Ma_Tien_Te = m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Ma_Tien_Te
                        Next
                        Tong_Doanh_Thu = Cuoc_Theo_SL + Cuoc_Theo_KL + Cuoc_Khac
                        'Lấy chi tiết CN55
                        Dim m_DSQT_CN55 As New DSQT_CN55(GConnectionString)
                        Dim m_DSQT_CN55_Chi_Tiet As New DSQT_CN55_Chi_Tiet
                        m_DSQT_CN55_Chi_Tiet.Id_CN55 = Create_Id_CN55(Id_Chuyen_Thu, Ma_Nuoc_Thanh_Toan)
                        m_DSQT_CN55_Chi_Tiet.Thang = getMonthFromDate(m_Chuyen_Thu_Den_Chi_Tiet.Ngay_Dong)
                        m_DSQT_CN55_Chi_Tiet.Quy = getQuarterFromDate(m_Chuyen_Thu_Den_Chi_Tiet.Ngay_Dong)
                        m_DSQT_CN55_Chi_Tiet.Nam = getYearFromDate(m_Chuyen_Thu_Den_Chi_Tiet.Ngay_Dong)
                        m_DSQT_CN55_Chi_Tiet.Id_Duong_Thu = m_Chuyen_Thu_Den_Chi_Tiet.Id_Duong_Thu
                        m_DSQT_CN55_Chi_Tiet.Ma_Nuoc_Duong_Thu = Ma_Nuoc_Duong_Thu
                        m_DSQT_CN55_Chi_Tiet.Ma_Nuoc_Thanh_Toan = Ma_Nuoc_Thanh_Toan
                        m_DSQT_CN55_Chi_Tiet.Ma_Bc_Thanh_Toan = Ma_Bc_Thanh_Toan
                        m_DSQT_CN55_Chi_Tiet.IMPC_Thanh_Toan = IMPC_Thanh_Toan
                        m_DSQT_CN55_Chi_Tiet.Ma_Bc_Khai_Thac = Ma_Bc_Khai_Thac
                        m_DSQT_CN55_Chi_Tiet.Ngay_Dong = m_Chuyen_Thu_Den_Chi_Tiet.Ngay_Dong
                        m_DSQT_CN55_Chi_Tiet.Id_Chuyen_Thu = m_Chuyen_Thu_Den_Chi_Tiet.Id_Chuyen_Thu
                        m_DSQT_CN55_Chi_Tiet.Loai_Chuyen_Thu = Loai_Chuyen_Thu
                        m_DSQT_CN55_Chi_Tiet.So_Chuyen_Thu = m_Chuyen_Thu_Den_Chi_Tiet.So_Chuyen_Thu
                        m_DSQT_CN55_Chi_Tiet.Nuoc_Gui = Ma_Nuoc_Duong_Thu
                        m_DSQT_CN55_Chi_Tiet.Bc_Gui = Ma_Bc
                        m_DSQT_CN55_Chi_Tiet.IMPC_Gui = IMPC_Thanh_Toan
                        m_DSQT_CN55_Chi_Tiet.Id_Ca = Id_Ca
                        m_DSQT_CN55_Chi_Tiet.Ngay_Khai_Thac = Ngay_Khai_Thac
                        m_DSQT_CN55_Chi_Tiet.Ca_Khai_Thac = Ca_Khai_Thac
                        m_DSQT_CN55_Chi_Tiet.Nuoc_Nhan = Ma_Nuoc_Thanh_Toan
                        m_DSQT_CN55_Chi_Tiet.Bc_Nhan = Ma_Bc_Thanh_Toan
                        m_DSQT_CN55_Chi_Tiet.IMPC_Nhan = IMPC_Thanh_Toan
                        m_DSQT_CN55_Chi_Tiet.So_Luong_D = So_Luong_D
                        m_DSQT_CN55_Chi_Tiet.Khoi_Luong_D = Khoi_Luong_D
                        m_DSQT_CN55_Chi_Tiet.So_Luong_M = So_Luong_M
                        m_DSQT_CN55_Chi_Tiet.Khoi_Luong_M = Khoi_Luong_M
                        m_DSQT_CN55_Chi_Tiet.So_Luong_R = So_Luong_R
                        m_DSQT_CN55_Chi_Tiet.Khoi_Luong_R = Khoi_Luong_R
                        m_DSQT_CN55_Chi_Tiet.So_Luong_OPS = So_Luong_OPS
                        m_DSQT_CN55_Chi_Tiet.Khoi_Luong_OPS = Khoi_Luong_OPS
                        m_DSQT_CN55_Chi_Tiet.Khoi_Luong_Vo_Tui = Khoi_Luong_Vo_Tui
                        m_DSQT_CN55_Chi_Tiet.Cuoc_Theo_SL = Cuoc_Theo_SL
                        m_DSQT_CN55_Chi_Tiet.Cuoc_Theo_KL = Cuoc_Theo_KL
                        m_DSQT_CN55_Chi_Tiet.Cuoc_VCMBND = Cuoc_VCMBND
                        m_DSQT_CN55_Chi_Tiet.Cuoc_Hang_Khong = Cuoc_Hang_Khong
                        m_DSQT_CN55_Chi_Tiet.Cuoc_Khac = Cuoc_Khac
                        m_DSQT_CN55_Chi_Tiet.Ma_Tien_Te = IIf(Ma_Tien_Te = "", "VND", Ma_Tien_Te)
                        m_DSQT_CN55_Chi_Tiet.Doanh_Thu_D = Doanh_Thu_D
                        m_DSQT_CN55_Chi_Tiet.Doanh_Thu_M = Doanh_Thu_M
                        m_DSQT_CN55_Chi_Tiet.Tong_Doanh_Thu = Tong_Doanh_Thu
                        m_DSQT_CN55_Chi_Tiet.Tong_Doanh_Thu_VND = 0
                        m_DSQT_CN55_Chi_Tiet.Hang_Van_Chuyen = ""
                        m_DSQT_CN55_Chi_Tiet.Ghi_Chu = ""
                        m_DSQT_CN55_Chi_Tiet.I_O = 1
                        m_DSQT_CN55_Chi_Tiet.Chot_SL = False
                        m_DSQT_CN55_Chi_Tiet.Ngay_He_Thong = 0
                        m_DSQT_CN55_Chi_Tiet.Gio_He_Thong = 0
                        'Cập nhật CN55
                        If Cap_Nhat_DSQT_CN55(m_DSQT_CN55_Chi_Tiet) = False Then
                            MessageBox.Show("Có lỗi xảy ra trong quá trình lấy số liệu quốc tế đến!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            ActiveForm.Cursor.Current = Cursors.Default
                            Return False
                        End If

                        'Cập nhật lại trạng thái = 0
                        So_Luong_D = 0
                        Khoi_Luong_D = 0
                        So_Luong_M = 0
                        Khoi_Luong_M = 0
                        So_Luong_R = 0
                        Khoi_Luong_R = 0
                        So_Luong_OPS = 0
                        Khoi_Luong_OPS = 0
                        Khoi_Luong_Vo_Tui = 0
                        Cuoc_Theo_SL = 0
                        Cuoc_Theo_KL = 0
                        Cuoc_VCMBND = 0
                        Cuoc_Hang_Khong = 0
                        Cuoc_Khac = 0
                        Ma_Tien_Te = ""
                        Doanh_Thu_D = 0
                        Doanh_Thu_M = 0
                        Tong_Doanh_Thu = 0
                    Next
                End If
Chuyen_Thu_Tiep_Theo:
                Progress_E1.Value = 0
            Next
            m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Ma_Trang_Thai = 1 'Tổng hợp thành công
            m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Tong_So_Chuyen_Thu = Tong_So_Chuyen_Thu
            m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Tong_So_E2 = Tong_So_E2
            m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Tong_So_BP_D = Tong_So_BP_D
            m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Tong_So_BP_M = Tong_So_BP_M
            m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Khoi_Luong_BP_D = Khoi_Luong_BP_D
            m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Khoi_Luong_BP_M = Khoi_Luong_BP_M
            m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Chi_Tiet_Trang_Thai = ""
            'Cập nhật trạng thái mới
            If Cap_Nhat_DSQT_Thong_Tin_Ke_Toan_Ca(m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet) = False Then
                Return False
            End If
            progress_Chuyen_Thu.Value = 0
            ActiveForm.Cursor.Current = Cursors.Default
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        End Try
    End Function
#End Region

#Region "------------------Tim_Ma_Bc_Thanh_Toan----------------"
    Private Function Tim_Ma_Bc_Thanh_Toan(ByVal Ma_Nuoc As String) As Integer
        Dim m_DSQT_Danh_Muc_Bc_Quoc_Te As New DSQT_Danh_Muc_Bc_Quoc_Te(GConnectionString)
        Return m_DSQT_Danh_Muc_Bc_Quoc_Te.DSQT_Danh_Muc_Bc_Quoc_Te_Lay_Theo_Ma_Nuoc_Thanh_Toan(Ma_Nuoc).Ma_Bc
    End Function
#End Region

#Region "----------------Cap_Nhat_DSQT_E1_Quoc_Te_Den----------------------"
    Private Function Cap_Nhat_DSQT_E1_Quoc_Te_Den(ByVal m_DSQT_E1_Quoc_Te_Den_Chi_Tiet As DSQT_E1_Quoc_Te_Den_Chi_Tiet)
        Try
            Dim m_DSQT_E1_Quoc_Te_Den As New DSQT_E1_Quoc_Te_Den(GConnectionString)
            If m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Id_E1 <> "" Then
                m_DSQT_E1_Quoc_Te_Den.DSQT_E1_Quoc_Te_Den_Cap_Nhat_Them(m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Id_E1, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Id_Duong_Thu, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Ma_Bc, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Noi_Gui, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.IMPC, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Ma_Nuoc_Duong_Thu, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Ma_Nuoc_Thanh_Toan, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Ma_Bc_Thanh_Toan, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.IMPC_Thanh_Toan, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Phan_Loai_Thanh_Toan, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Id_Chuyen_Thu, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Loai_Chuyen_Thu, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.So_Chuyen_Thu, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Id_E2, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Tui_So, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Id_Ca, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Ngay_Khai_Thac, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Ca_Khai_Thac, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Ma_Bc_Khai_Thac, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Ma_E1, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Ngay_Dong, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Gio_Dong, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Ngay_Nhan, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Gio_Nhan, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Ma_Bc_Goc, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Ma_Bc_Tra, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Nuoc_Nhan, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Nuoc_Tra, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Khoi_Luong, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Phan_Loai, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Loai_Hang_Hoa, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Khoi_Luong_QD, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Loai, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.STT, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Cuoc_Theo_SL, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Cuoc_Theo_KL, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Cuoc_Khac, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Cuoc_VCMBND, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Ma_Tien_Te, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Tong_Doanh_Thu, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Tong_Doanh_Thu_VND, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Id_Nguoi_Dung, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Id_Trang_Thai, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Ghi_Chu, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Ngay_He_Thong, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Gio_He_Thong, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Chot_SL, _
                                                                        m_DSQT_E1_Quoc_Te_Den_Chi_Tiet.Id_Dich_Vu)
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        End Try
    End Function
#End Region

#Region "----------Cap_Nhat_DSQT_CN55-----------------"
    Private Function Cap_Nhat_DSQT_CN55(ByVal m_DSQT_CN55_Chi_Tiet As DSQT_CN55_Chi_Tiet) As Boolean
        Dim m_DSQT_CN55 As New DSQT_CN55(GConnectionString)
        m_DSQT_CN55.DSQT_CN55_Cap_Nhat_Them(m_DSQT_CN55_Chi_Tiet.Id_CN55, _
                                            m_DSQT_CN55_Chi_Tiet.Thang, _
                                            m_DSQT_CN55_Chi_Tiet.Quy, _
                                            m_DSQT_CN55_Chi_Tiet.Nam, _
                                            m_DSQT_CN55_Chi_Tiet.Id_Duong_Thu, _
                                            m_DSQT_CN55_Chi_Tiet.Ma_Nuoc_Duong_Thu, _
                                            m_DSQT_CN55_Chi_Tiet.Ma_Nuoc_Thanh_Toan, _
                                            m_DSQT_CN55_Chi_Tiet.Ma_Bc_Thanh_Toan, _
                                            m_DSQT_CN55_Chi_Tiet.IMPC_Thanh_Toan, _
                                            m_DSQT_CN55_Chi_Tiet.Id_Ca, _
                                            m_DSQT_CN55_Chi_Tiet.Ngay_Khai_Thac, _
                                            m_DSQT_CN55_Chi_Tiet.Ca_Khai_Thac, _
                                            m_DSQT_CN55_Chi_Tiet.Ma_Bc_Khai_Thac, _
                                            m_DSQT_CN55_Chi_Tiet.Ngay_Dong, _
                                            m_DSQT_CN55_Chi_Tiet.Id_Chuyen_Thu, _
                                            m_DSQT_CN55_Chi_Tiet.Loai_Chuyen_Thu, _
                                            m_DSQT_CN55_Chi_Tiet.So_Chuyen_Thu, _
                                            m_DSQT_CN55_Chi_Tiet.Nuoc_Gui, _
                                            m_DSQT_CN55_Chi_Tiet.Bc_Gui, _
                                            m_DSQT_CN55_Chi_Tiet.IMPC_Gui, _
                                            m_DSQT_CN55_Chi_Tiet.Nuoc_Nhan, _
                                            m_DSQT_CN55_Chi_Tiet.Bc_Nhan, _
                                            m_DSQT_CN55_Chi_Tiet.IMPC_Nhan, _
                                            m_DSQT_CN55_Chi_Tiet.So_Luong_D, _
                                            m_DSQT_CN55_Chi_Tiet.Khoi_Luong_D, _
                                            m_DSQT_CN55_Chi_Tiet.So_Luong_M, _
                                            m_DSQT_CN55_Chi_Tiet.Khoi_Luong_M, _
                                            m_DSQT_CN55_Chi_Tiet.So_Luong_R, _
                                            m_DSQT_CN55_Chi_Tiet.Khoi_Luong_R, _
                                            m_DSQT_CN55_Chi_Tiet.So_Luong_OPS, _
                                            m_DSQT_CN55_Chi_Tiet.Khoi_Luong_OPS, _
                                            m_DSQT_CN55_Chi_Tiet.Khoi_Luong_Vo_Tui, _
                                            m_DSQT_CN55_Chi_Tiet.Cuoc_Theo_SL, _
                                            m_DSQT_CN55_Chi_Tiet.Cuoc_Theo_KL, _
                                            m_DSQT_CN55_Chi_Tiet.Cuoc_VCMBND, _
                                            m_DSQT_CN55_Chi_Tiet.Cuoc_Hang_Khong, _
                                            m_DSQT_CN55_Chi_Tiet.Cuoc_Khac, _
                                            m_DSQT_CN55_Chi_Tiet.Ma_Tien_Te, _
                                            m_DSQT_CN55_Chi_Tiet.Doanh_Thu_D, _
                                            m_DSQT_CN55_Chi_Tiet.Doanh_Thu_M, _
                                            m_DSQT_CN55_Chi_Tiet.Tong_Doanh_Thu, _
                                            m_DSQT_CN55_Chi_Tiet.Tong_Doanh_Thu_VND, _
                                            m_DSQT_CN55_Chi_Tiet.Hang_Van_Chuyen, _
                                            m_DSQT_CN55_Chi_Tiet.Ghi_Chu, _
                                            m_DSQT_CN55_Chi_Tiet.I_O, _
                                            m_DSQT_CN55_Chi_Tiet.Chot_SL, _
                                            m_DSQT_CN55_Chi_Tiet.Ngay_He_Thong, _
                                            m_DSQT_CN55_Chi_Tiet.Gio_He_Thong)
        Return True
    End Function
#End Region

#Region "--------------------Cap_Nhat_DSQT_Thong_Tin_Ke_Toan_Ca-------------------"
    Private Function Cap_Nhat_DSQT_Thong_Tin_Ke_Toan_Ca(ByVal m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet As DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet) As Boolean
        Try
            Dim m_DSQT_Thong_Tin_Ke_Toan_Ca As New DSQT_Thong_Tin_Ke_Toan_Ca(GConnectionString)
            m_DSQT_Thong_Tin_Ke_Toan_Ca.DSQT_Thong_Tin_Ke_Toan_Ca_Cap_Nhat_Them(m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Id_Ke_Toan, _
                                                                                m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Id_Ca, _
                                                                                m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Ma_Trang_Thai, _
                                                                                m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.STT, _
                                                                                m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Ma_Bc_Khai_Thac, _
                                                                                m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Ngay_Khai_Thac, _
                                                                                m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Ca_Khai_Thac, _
                                                                                m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Tong_So_Chuyen_Thu, _
                                                                                m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Tong_So_E2, _
                                                                                m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Tong_So_BP_D, _
                                                                                m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Tong_So_BP_M, _
                                                                                m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Khoi_Luong_BP_D, _
                                                                                m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Khoi_Luong_BP_M, _
                                                                                m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Chi_Tiet_Trang_Thai, _
                                                                                m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Ngay_He_Thong, _
                                                                                m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Gio_He_Thong, _
                                                                                m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Id_Nguoi_Dung, _
                                                                                m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Ghi_Chu, _
                                                                                m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Chot_SL)
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        End Try

    End Function
#End Region

#Region "-------------btn_Bao_Cao_Doanh_Thu_QT_Den_Click-------------"
    Private Sub btn_Bao_Cao_Doanh_Thu_QT_Den_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Bao_Cao_Doanh_Thu_QT_Den.Click
        Dim Ma_Bc_Khai_Thac As Integer
        Ma_Bc_Khai_Thac = Tim_Buu_Cuc_Khai_Thac_QT(True)
        If Ma_Bc_Khai_Thac = 0 Then
            MessageBox.Show("Không tồn tại bưu cục khai thác nào thỏa mãn yêu cầu", "Thông báo", MessageBoxButtons.OK)
            Exit Sub
        End If

        Dim Tu_Ngay As Integer
        Dim Den_Ngay As Integer
        If opt_Khoang_Thoi_Gian.Checked = True Then
            Dim m_Ham_Dung_Chung As New Ham_Dung_Chung
            Tu_Ngay = m_Ham_Dung_Chung.ConvertDateToInt(cb_Tu_Ngay.DateTime)
            Den_Ngay = m_Ham_Dung_Chung.ConvertDateToInt(cb_Den_Ngay.DateTime)
            If Tu_Ngay > Den_Ngay Then
                MessageBox.Show("Khoảng thời gian này không tồn tại!!!", "Thông báo", MessageBoxButtons.OK)
                cb_Tu_Ngay.Focus()
                Exit Sub
            End If
            Dim mKe_Toan_Cong_Ty As Boolean = False
            Dim mTat_Ca As Boolean = True
            Dim mPreview As Boolean = True
            Dim mSo_Ban As Integer = 1
            Bao_Cao_Doanh_Thu_Tung_Nuoc_Theo_Ngay_Dong(mKe_Toan_Cong_Ty, mTat_Ca, Ma_Bc_Khai_Thac, Tu_Ngay, Den_Ngay, mPreview, mSo_Ban)
        Else
            MessageBox.Show("Lựa chọn không phù hợp!!!", "Thông báo", MessageBoxButtons.OK)
            Exit Sub
        End If
    End Sub
#End Region

#Region "-------------btn_Khoa_So_Lieu_QT_Den_Click-------------"
    Private Sub btn_Khoa_So_Lieu_QT_Den_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Khoa_So_Lieu_QT_Den.Click
        Dim Ma_Bc_Khai_Thac As Integer
        Ma_Bc_Khai_Thac = Tim_Buu_Cuc_Khai_Thac_QT(True)
        If Ma_Bc_Khai_Thac = 0 Then
            MessageBox.Show("Không tồn tại bưu cục khai thác nào thỏa mãn yêu cầu", "Thông báo", MessageBoxButtons.OK)
            Exit Sub
        End If

        Dim m_DSQT_Danh_Muc_Bc_Khai_Thac As New DSQT_Danh_Muc_Bc_Khai_Thac(GConnectionString)
        Dim m_DSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet As New DSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet
        m_DSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet = m_DSQT_Danh_Muc_Bc_Khai_Thac.DSQT_Danh_Muc_Bc_Khai_Thac_Lay(Ma_Bc_Khai_Thac)
        If m_DSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet.IMPC = "" Then
            MessageBox.Show("Bạn không được phép khóa số liệu đối soát cho bưu cục này!!!", "Thông báo", MessageBoxButtons.OK)
            Exit Sub
        End If
        If m_DSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet.Quoc_Te_Den = False Then 'là bưu cục quốc tế đi trong này
            MessageBox.Show("Bạn không được phép khóa số liệu đối soát cho bưu cục này!!!", "Thông báo", MessageBoxButtons.OK)
            Exit Sub
        End If
        'Lấy thông tin
        Dim Buu_Cuc_Khai_Thac As Integer
        Dim Ngay_Khai_Thac As Integer

        'Lấy Id_Ca khai thác cần tổng hợp quốc tế đến
        Dim m_Ca_San_Xuat As New Ca_San_Xuat(GConnectionString)
        Dim Id_Ca As String
        If opt_Khoang_Thoi_Gian.Checked = True Then
            MessageBox.Show("Bạn chỉ được phép khóa số liêu từng ca!!!", "Thông báo", MessageBoxButtons.OK)
            Exit Sub
        End If

        Id_Ca = get_Id_Ca(Ma_Bc_Khai_Thac)
        'Kiểm tra thông tin kế toán ca đã được tổng hợp gần nhất
        Dim m_DSQT_Thong_Tin_Ke_Toan_Ca As New DSQT_Thong_Tin_Ke_Toan_Ca(GConnectionString)
        Dim m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet As New DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet
        m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet = m_DSQT_Thong_Tin_Ke_Toan_Ca.DSQT_Thong_Tin_Ke_Toan_Ca_Lay_Chi_Tiet_Tong_Hop_Gan_Nhat_Theo_Ca(Id_Ca)
        If m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Id_Ke_Toan <> "" Then
            MessageBox.Show("Ca khai thác này chưa được tổng hợp số liệu!!!", "Thông báo", MessageBoxButtons.OK)
            Exit Sub
        Else
            If m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Chot_SL = True Then
                MessageBox.Show("Ca khai thác này đã được khóa số liệu!!!", "Thông báo", MessageBoxButtons.OK)
                Exit Sub
            End If
            m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Chot_SL = True
            'Cập nhật Thông tin kế toán ca chi tiết
            If Cap_Nhat_DSQT_Thong_Tin_Ke_Toan_Ca(m_DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet) Then
                MessageBox.Show("Khóa số liệu thành công!!!", "Thông báo", MessageBoxButtons.OK)
                Exit Sub
            Else
                MessageBox.Show("Khóa số liệu lỗi!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
    End Sub
#End Region
#End Region

#Region "===============Hàm dùng chung======================"
#Region "-------------Create_Id_DSQT_Thong_Tin_Ke_Toan_Ca-----------------"
    Public Function Create_Id_DSQT_Thong_Tin_Ke_Toan_Ca(ByVal Id_Ca As String, ByVal STT As Integer) As String
        Return Id_Ca & STT.ToString("00000")
    End Function
#End Region

#Region "----------------Create_Id_CN55--------------------"
    Public Function Create_Id_CN55(ByVal Id_Chuyen_Thu As String, ByVal Ma_Nuoc_Thanh_Toan As String) As String
        Return Id_Chuyen_Thu + Ma_Nuoc_Thanh_Toan
    End Function
#End Region

#Region "----------------Tim_Buu_Cuc_Khai_Thac_QT--------------------"
    Private Function Tim_Buu_Cuc_Khai_Thac_QT(ByVal Quoc_Te_Den As Boolean) As Integer
        Try
            'Tìm bưu cục khai thác quốc tế đến trong database
            Dim ds As New DataSet
            Dim m_Ma_Bc_Khai_Thac As New Ma_Bc_Khai_Thac(GConnectionString)
            ds = m_Ma_Bc_Khai_Thac.Danh_Sach
            Dim Tong_So_Bc As Integer = 0
            Tong_So_Bc = ds.Tables(0).Rows.Count
            If Tong_So_Bc = 0 Then
                Return 0
            End If
            Dim i As Integer
            For i = 0 To Tong_So_Bc - 1
                Dim Ma_Bc_Khai_Thac As Integer
                Ma_Bc_Khai_Thac = CInt(ds.Tables(0).Rows(i).Item("Ma_Bc_Khai_Thac"))
                'Tìm bưu cục khai thác quốc tế đến
                Dim m_DSQT_Danh_Muc_Bc_Khai_Thac As New DSQT_Danh_Muc_Bc_Khai_Thac(GConnectionString)
                Dim m_DSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet As New DSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet
                'Lấy chi tiết bưu cục khai thác quốc tế
                m_DSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet = m_DSQT_Danh_Muc_Bc_Khai_Thac.DSQT_Danh_Muc_Bc_Khai_Thac_Lay(Ma_Bc_Khai_Thac)
                If Quoc_Te_Den = True Then
                    If m_DSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet.Quoc_Te_Den = True Then 'Quốc tế đến
                        Return m_DSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet.Ma_Bc_Khai_Thac
                    End If
                Else
                    If m_DSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet.Quoc_Te_Den = False Then 'Quốc tế đi
                        Return m_DSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet.Ma_Bc_Khai_Thac
                    End If
                End If
            Next
            Return 0
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Function
#End Region

#Region "---------------Create_Id_Cuoc------------------"
    Private Function Create_Id_Cuoc(ByVal mMa_Nuoc As String, ByVal mId_Dot As String) As String
        Try
            Return mMa_Nuoc & "_" & mId_Dot
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        End Try
    End Function
#End Region
#End Region

#Region "==================Control Menu====================="
    Private Sub Menu_Cuoc_Quoc_Te_Den_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Cuoc_Quoc_Te_Den.Click
        Dim Frm As New Frm_Cuoc_Quoc_Te_Den
        Frm.ShowInTaskbar = False
        Frm.ShowDialog()
    End Sub

    Private Sub Menu_Cuoc_Quoc_Te_Di_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Cuoc_Quoc_Te_Di.Click
        Dim Frm As New Frm_Cuoc_Quoc_Te_Di
        Frm.ShowInTaskbar = False
        Frm.ShowDialog()
    End Sub

    Private Sub Menu_Cuoc_Qua_Giang_HongKong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Cuoc_Qua_Giang_HongKong.Click
        Dim Frm As New Frm_Cuoc_Qua_Giang_Qua_HK
        Frm.ShowInTaskbar = False
        Frm.ShowDialog()
    End Sub

    Private Sub Menu_Cuoc_Qua_Giang_Singapore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Cuoc_Qua_Giang_Singapore.Click
        Dim Frm As New Frm_Cuoc_Qua_Giang_Qua_SIN
        Frm.ShowInTaskbar = False
        Frm.ShowDialog()
    End Sub

    Private Sub Menu_Cuoc_Qua_Giang_JNE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Cuoc_Qua_Giang_JNE.Click
        Dim Frm As New Frm_Cuoc_Qua_Giang_Qua_JNE
        Frm.ShowInTaskbar = False
        Frm.ShowDialog()
    End Sub

    Private Sub Menu_Cuoc_Hang_Khong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Cuoc_Hang_Khong.Click
        MessageBox.Show("Chức năng này chưa hoàn thiện!!!", "Thông báo", MessageBoxButtons.OK)
    End Sub

    Private Sub Menu_Danh_Muc_Doi_Soat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Danh_Muc_Doi_Soat.Click
        Dim Frm As New Frm_Danh_Muc_Doi_Soat
        Frm.ShowInTaskbar = False
        Frm.ShowDialog()
    End Sub

    Private Sub menu_Bao_Cao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_Bao_Cao.Click
        Me.Hide()
        Dim Frm As New Frm_Bao_Cao_Doi_Soat_QT
        Frm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Menu_Thoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Thoat.Click
        Application.Exit()
    End Sub
#End Region

#Region "===============Form Control======================"
    Private Sub BtnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnThoat.Click
        Close()
        Dispose()
    End Sub

    Private Sub Frm_Doi_Soat_Quoc_Te_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CbNgay_Kt.DateTime = Today
        cb_Tu_Ngay.DateTime = Today
        cb_Den_Ngay.DateTime = Today

        CbMa_Ca.DataSource = myMa_Ca.Lay_Boi_Ma_Bc_Khai_Thac(GBuu_Cuc_Khai_Thac)
        CbMa_Ca.DataBind()
        If CbMa_Ca.Rows.Count > 0 Then
            CbMa_Ca.Value = CbMa_Ca.Rows(0).Cells("Thu_Tu").Value
        End If
        opt_Theo_Ca.Checked = True
    End Sub

    Private Sub opt_Theo_Ca_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opt_Theo_Ca.CheckedChanged
        EnableControlCaKhaiThac()
    End Sub

    Private Sub opt_Khoang_Thoi_Gian_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opt_Khoang_Thoi_Gian.CheckedChanged
        EnableControlCaKhaiThac()
    End Sub

    Private Sub EnableControlCaKhaiThac()
        If opt_Khoang_Thoi_Gian.Checked = True Then
            cb_Tu_Ngay.Enabled = True
            cb_Den_Ngay.Enabled = True

            CbNgay_Kt.Enabled = False
            CbMa_Ca.Enabled = False

            chk_Tong_Hop_Ca_Con_Thieu.Enabled = True
        Else
            cb_Tu_Ngay.Enabled = False
            cb_Den_Ngay.Enabled = False

            CbNgay_Kt.Enabled = True
            CbMa_Ca.Enabled = True

            chk_Tong_Hop_Ca_Con_Thieu.Enabled = False
        End If
    End Sub
#End Region

#Region "==================Quốc Tế Đi======================"
    Private Sub btn_Tong_Hop_QT_Di_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Tong_Hop_QT_Di.Click
        MessageBox.Show("Chức năng này chưa hoàn thiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Exit Sub
    End Sub

    Private Sub btn_Khoa_So_Lieu_QT_Di_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Khoa_So_Lieu_QT_Di.Click
        MessageBox.Show("Chức năng này chưa hoàn thiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Exit Sub
    End Sub

    Private Sub btn_Bao_Cao_Doanh_Thu_QT_Di_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Bao_Cao_Doanh_Thu_QT_Di.Click
        MessageBox.Show("Chức năng này chưa hoàn thiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Exit Sub
    End Sub
#End Region



End Class

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports Ems_International_Logic.EMS

Public Class FrmBao_Cao_E_Shipping
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
    Friend WithEvents grbThoi_Gian As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CbTu_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents grbDanh_Muc_Bao_Cao As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btnThoat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents optBao_Cao_Tong_Hop_3 As System.Windows.Forms.RadioButton
    Friend WithEvents optBao_Cao_Tong_Hop_2 As System.Windows.Forms.RadioButton
    Friend WithEvents optBao_Cao_Tong_Hop_1 As System.Windows.Forms.RadioButton
    Friend WithEvents optDanh_Sach_Gui_Call_Center As System.Windows.Forms.RadioButton
    Friend WithEvents grbTuy_Chon As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents optTat_Ca As System.Windows.Forms.RadioButton
    Friend WithEvents btnTimKiem As System.Windows.Forms.Button
    Friend WithEvents optDau_Ma_E As System.Windows.Forms.RadioButton
    Friend WithEvents optDau_ma_C As System.Windows.Forms.RadioButton
    Friend WithEvents sFileDlg As System.Windows.Forms.SaveFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmBao_Cao_E_Shipping))
        Me.grbThoi_Gian = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.CbTu_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.grbDanh_Muc_Bao_Cao = New Infragistics.Win.Misc.UltraGroupBox
        Me.optBao_Cao_Tong_Hop_3 = New System.Windows.Forms.RadioButton
        Me.optBao_Cao_Tong_Hop_2 = New System.Windows.Forms.RadioButton
        Me.optBao_Cao_Tong_Hop_1 = New System.Windows.Forms.RadioButton
        Me.optDanh_Sach_Gui_Call_Center = New System.Windows.Forms.RadioButton
        Me.btnThoat = New Infragistics.Win.Misc.UltraButton
        Me.btnPreview = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnExcel = New System.Windows.Forms.Button
        Me.grbTuy_Chon = New Infragistics.Win.Misc.UltraGroupBox
        Me.optDau_Ma_E = New System.Windows.Forms.RadioButton
        Me.optDau_ma_C = New System.Windows.Forms.RadioButton
        Me.optTat_Ca = New System.Windows.Forms.RadioButton
        Me.btnTimKiem = New System.Windows.Forms.Button
        Me.sFileDlg = New System.Windows.Forms.SaveFileDialog
        CType(Me.grbThoi_Gian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbThoi_Gian.SuspendLayout()
        CType(Me.CbTu_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbDanh_Muc_Bao_Cao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDanh_Muc_Bao_Cao.SuspendLayout()
        CType(Me.grbTuy_Chon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbTuy_Chon.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbThoi_Gian
        '
        Me.grbThoi_Gian.Controls.Add(Me.UltraLabel4)
        Me.grbThoi_Gian.Controls.Add(Me.CbTu_Ngay)
        Me.grbThoi_Gian.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbThoi_Gian.Location = New System.Drawing.Point(16, 8)
        Me.grbThoi_Gian.Name = "grbThoi_Gian"
        Me.grbThoi_Gian.Size = New System.Drawing.Size(416, 80)
        Me.grbThoi_Gian.SupportThemes = False
        Me.grbThoi_Gian.TabIndex = 0
        Me.grbThoi_Gian.Text = "Thông tin ngày khai thác"
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Location = New System.Drawing.Point(72, 40)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(120, 16)
        Me.UltraLabel4.TabIndex = 0
        Me.UltraLabel4.Text = "Ngày khai thác"
        '
        'CbTu_Ngay
        '
        Me.CbTu_Ngay.DateTime = New Date(2008, 7, 3, 0, 0, 0, 0)
        Me.CbTu_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.CbTu_Ngay.Location = New System.Drawing.Point(200, 36)
        Me.CbTu_Ngay.Name = "CbTu_Ngay"
        Me.CbTu_Ngay.Size = New System.Drawing.Size(120, 24)
        Me.CbTu_Ngay.TabIndex = 1
        Me.CbTu_Ngay.Value = New Date(2008, 7, 3, 0, 0, 0, 0)
        '
        'grbDanh_Muc_Bao_Cao
        '
        Me.grbDanh_Muc_Bao_Cao.Controls.Add(Me.optBao_Cao_Tong_Hop_3)
        Me.grbDanh_Muc_Bao_Cao.Controls.Add(Me.optBao_Cao_Tong_Hop_2)
        Me.grbDanh_Muc_Bao_Cao.Controls.Add(Me.optBao_Cao_Tong_Hop_1)
        Me.grbDanh_Muc_Bao_Cao.Controls.Add(Me.optDanh_Sach_Gui_Call_Center)
        Me.grbDanh_Muc_Bao_Cao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbDanh_Muc_Bao_Cao.Location = New System.Drawing.Point(16, 96)
        Me.grbDanh_Muc_Bao_Cao.Name = "grbDanh_Muc_Bao_Cao"
        Me.grbDanh_Muc_Bao_Cao.Size = New System.Drawing.Size(416, 168)
        Me.grbDanh_Muc_Bao_Cao.SupportThemes = False
        Me.grbDanh_Muc_Bao_Cao.TabIndex = 1
        Me.grbDanh_Muc_Bao_Cao.Text = "Danh mục báo cáo"
        '
        'optBao_Cao_Tong_Hop_3
        '
        Me.optBao_Cao_Tong_Hop_3.Enabled = False
        Me.optBao_Cao_Tong_Hop_3.Location = New System.Drawing.Point(24, 120)
        Me.optBao_Cao_Tong_Hop_3.Name = "optBao_Cao_Tong_Hop_3"
        Me.optBao_Cao_Tong_Hop_3.Size = New System.Drawing.Size(344, 32)
        Me.optBao_Cao_Tong_Hop_3.TabIndex = 3
        Me.optBao_Cao_Tong_Hop_3.Text = "Báo cáo tổng hợp 3"
        '
        'optBao_Cao_Tong_Hop_2
        '
        Me.optBao_Cao_Tong_Hop_2.Enabled = False
        Me.optBao_Cao_Tong_Hop_2.Location = New System.Drawing.Point(24, 88)
        Me.optBao_Cao_Tong_Hop_2.Name = "optBao_Cao_Tong_Hop_2"
        Me.optBao_Cao_Tong_Hop_2.Size = New System.Drawing.Size(328, 32)
        Me.optBao_Cao_Tong_Hop_2.TabIndex = 2
        Me.optBao_Cao_Tong_Hop_2.Text = "Báo cáo tổng hợp 2"
        '
        'optBao_Cao_Tong_Hop_1
        '
        Me.optBao_Cao_Tong_Hop_1.Enabled = False
        Me.optBao_Cao_Tong_Hop_1.Location = New System.Drawing.Point(24, 64)
        Me.optBao_Cao_Tong_Hop_1.Name = "optBao_Cao_Tong_Hop_1"
        Me.optBao_Cao_Tong_Hop_1.Size = New System.Drawing.Size(312, 24)
        Me.optBao_Cao_Tong_Hop_1.TabIndex = 1
        Me.optBao_Cao_Tong_Hop_1.Text = "Báo cáo tổng hợp 1"
        '
        'optDanh_Sach_Gui_Call_Center
        '
        Me.optDanh_Sach_Gui_Call_Center.Checked = True
        Me.optDanh_Sach_Gui_Call_Center.Location = New System.Drawing.Point(24, 32)
        Me.optDanh_Sach_Gui_Call_Center.Name = "optDanh_Sach_Gui_Call_Center"
        Me.optDanh_Sach_Gui_Call_Center.Size = New System.Drawing.Size(344, 24)
        Me.optDanh_Sach_Gui_Call_Center.TabIndex = 0
        Me.optDanh_Sach_Gui_Call_Center.TabStop = True
        Me.optDanh_Sach_Gui_Call_Center.Text = "Danh sách chi tiết các bưu phẩm đóng đi các tỉnh"
        '
        'btnThoat
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.btnThoat.Appearance = Appearance1
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Location = New System.Drawing.Point(351, 376)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(72, 32)
        Me.btnThoat.TabIndex = 5
        Me.btnThoat.Text = "Th&oát"
        '
        'btnPreview
        '
        Me.btnPreview.Image = CType(resources.GetObject("btnPreview.Image"), System.Drawing.Image)
        Me.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPreview.Location = New System.Drawing.Point(132, 376)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(72, 32)
        Me.btnPreview.TabIndex = 3
        Me.btnPreview.Text = "    Prei&vew"
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(205, 376)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(72, 32)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.Text = "    &Print"
        '
        'btnExcel
        '
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Image)
        Me.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcel.Location = New System.Drawing.Point(24, 376)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(107, 32)
        Me.btnExcel.TabIndex = 2
        Me.btnExcel.Text = "&Export To Excel"
        Me.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grbTuy_Chon
        '
        Me.grbTuy_Chon.Controls.Add(Me.optDau_Ma_E)
        Me.grbTuy_Chon.Controls.Add(Me.optDau_ma_C)
        Me.grbTuy_Chon.Controls.Add(Me.optTat_Ca)
        Me.grbTuy_Chon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbTuy_Chon.Location = New System.Drawing.Point(16, 272)
        Me.grbTuy_Chon.Name = "grbTuy_Chon"
        Me.grbTuy_Chon.Size = New System.Drawing.Size(416, 72)
        Me.grbTuy_Chon.SupportThemes = False
        Me.grbTuy_Chon.TabIndex = 6
        Me.grbTuy_Chon.Text = "Tuỳ chọn báo cáo"
        '
        'optDau_Ma_E
        '
        Me.optDau_Ma_E.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDau_Ma_E.Location = New System.Drawing.Point(296, 32)
        Me.optDau_Ma_E.Name = "optDau_Ma_E"
        Me.optDau_Ma_E.Size = New System.Drawing.Size(96, 24)
        Me.optDau_Ma_E.TabIndex = 4
        Me.optDau_Ma_E.Text = "Ems thường"
        '
        'optDau_ma_C
        '
        Me.optDau_ma_C.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDau_ma_C.Location = New System.Drawing.Point(144, 32)
        Me.optDau_ma_C.Name = "optDau_ma_C"
        Me.optDau_ma_C.Size = New System.Drawing.Size(120, 24)
        Me.optDau_ma_C.TabIndex = 1
        Me.optDau_ma_C.Text = "Ems Economy"
        '
        'optTat_Ca
        '
        Me.optTat_Ca.Checked = True
        Me.optTat_Ca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optTat_Ca.Location = New System.Drawing.Point(24, 32)
        Me.optTat_Ca.Name = "optTat_Ca"
        Me.optTat_Ca.Size = New System.Drawing.Size(96, 24)
        Me.optTat_Ca.TabIndex = 0
        Me.optTat_Ca.TabStop = True
        Me.optTat_Ca.Text = "Tất cả"
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Image = CType(resources.GetObject("btnTimKiem.Image"), System.Drawing.Image)
        Me.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTimKiem.Location = New System.Drawing.Point(278, 376)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(72, 32)
        Me.btnTimKiem.TabIndex = 7
        Me.btnTimKiem.Text = "   Tra cứu"
        '
        'FrmBao_Cao_E_Shipping
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(448, 429)
        Me.Controls.Add(Me.btnTimKiem)
        Me.Controls.Add(Me.grbTuy_Chon)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.grbDanh_Muc_Bao_Cao)
        Me.Controls.Add(Me.grbThoi_Gian)
        Me.Name = "FrmBao_Cao_E_Shipping"
        Me.Text = "Báo cáo vận đơn điện tử E_Shipping"
        CType(Me.grbThoi_Gian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbThoi_Gian.ResumeLayout(False)
        CType(Me.CbTu_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbDanh_Muc_Bao_Cao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDanh_Muc_Bao_Cao.ResumeLayout(False)
        CType(Me.grbTuy_Chon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbTuy_Chon.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Khai báo biến toàn Form"
    'Biến kết nối với CSDL
    'Private myE1_Den_E_E_Shipping As New E1_Den_E_Shipping(GConnectionString)
    Private myE1_Di As New E1_Di(GConnectionString)
    Private myHam_Dung_Chung As New Ham_Dung_Chung
    'Paramete Report
    Private pMenu_Trai As String
    Private pMenu_Phai As String
    Private pTen_Bao_Cao As String
    Private pTu_Ngay_Den_Ngay As String
    Private pNgay_Thang_Nam As String
    Private pTuy_Chon_Bao_Cao As String
    Private pTong_EMS As Integer
    Private pTong_EMS_Economy As Integer
    'Thoi gian
    Private myTu_Ngay As Integer
    Private myDen_Ngay As Integer
    'Đơn vị báo cáo     1: Hà Nội           2: Hồ Chí Minh
    Private myDon_Vi_Bao_Cao As Integer
#End Region

#Region "TabControl"
#Region "FrmBao_Cao_E_Shipping_Load"
    Private Sub FrmBao_Cao_E_Shipping_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Refesh_Form_Load()
    End Sub
#End Region
#Region "btnExcel_Click"
    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        If Kiem_Tra_Thoi_Gian_Bao_Cao() Then
            'In bao cao tuong ung
            If optDanh_Sach_Gui_Call_Center.Checked Then
                Export_Danh_Sach_Dong_Di_Tinh_To_Excel()
            ElseIf optBao_Cao_Tong_Hop_1.Checked Then
                MessageBox.Show("Chức năng này chưa hoàn chỉnh , mời ban quay lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf optBao_Cao_Tong_Hop_2.Checked Then
                MessageBox.Show("Chức năng này chưa hoàn chỉnh , mời ban quay lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf optBao_Cao_Tong_Hop_3.Checked Then
                MessageBox.Show("Chức năng này chưa hoàn chỉnh , mời ban quay lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
#End Region
#Region "btnPreview_Click"
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        If Kiem_Tra_Thoi_Gian_Bao_Cao() Then
            Print_Report(True)
        End If
    End Sub
#End Region
#Region "btnPrint_Click"
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If Kiem_Tra_Thoi_Gian_Bao_Cao() Then
            If Print_Report(False) = True Then
                MessageBox.Show("Đã in thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
#End Region
#Region "btnThoat_Click"
    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
        Me.Dispose()
    End Sub
#End Region
#End Region

#Region "Hàm người dùng"
#Region "Refesh_Form_Load"
    Private Sub Refesh_Form_Load()
        CbTu_Ngay.Value = Now.Date
    End Sub
#End Region
    'Tiêu đề báo cáo theo từng đơn vị khai thác QT
#Region "Tim_Don_Vi_In_Bao_Cao"
    Private Sub Tim_Don_Vi_In_Bao_Cao()
        Dim mDanh_Muc_Bc As New Danh_Muc_BC(GConnectionString)
        Dim mDanh_Muc_Bc_Chi_Tiet As New Danh_Muc_BC_Chi_Tiet
        mDanh_Muc_Bc_Chi_Tiet = mDanh_Muc_Bc.Lay(GBuu_Cuc_Khai_Thac)
        If mDanh_Muc_Bc_Chi_Tiet.Ma_Tinh = 100000 Then  'Ha noi
            myDon_Vi_Bao_Cao = 1
        ElseIf mDanh_Muc_Bc_Chi_Tiet.Ma_Tinh = 700000 Then      'HCM
            myDon_Vi_Bao_Cao = 2
        Else        '
            myDon_Vi_Bao_Cao = 3
        End If
    End Sub
#End Region

#Region "Danh_Sach_Buu_Pham_Gui_Call_Center"
    Private Sub Danh_Sach_Buu_Pham_Gui_Call_Center(ByVal mPreview As Boolean)
        Dim FrmView As New FrmViewReports
        Dim rptView As New Rpt_Danh_Sach_Buu_Pham_Di_Cac_Tinh_Gui_Call_Center
        Dim myDataSet As New DataSet
        Dim myTable As New DataTable

        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue

        'Lay du lieu
        If optTat_Ca.Checked Then
            myTable = myE1_Di.E1_Di_Lay_Danh_Sach_Dong_Di_Tinh_Gui_Call_Center(GBuu_Cuc_Khai_Thac, myTu_Ngay, myDen_Ngay, 1).Tables(0)
            If myDon_Vi_Bao_Cao = 1 Then ' ha noi
                pTen_Bao_Cao = "DANH SÁCH TẤT CẢ BƯU PHẨM QUỐC TẾ ĐI CÁC TỈNH"
            ElseIf myDon_Vi_Bao_Cao = 2 Then   'hcm
                pTen_Bao_Cao = "DANH SÁCH TẤT CẢ BƯU PHẨM QUỐC TẾ ĐI CÁC TỈNH VÀ CÁC HUYỆN NGOẠI THÀNH"
            Else
                pTen_Bao_Cao = "DANH SÁCH TẤT CẢ BƯU PHẨM QUỐC TẾ ĐI CÁC TỈNH"
            End If
        ElseIf optDau_ma_C.Checked Then
            myTable = myE1_Di.E1_Di_Lay_Danh_Sach_Dong_Di_Tinh_Gui_Call_Center(GBuu_Cuc_Khai_Thac, myTu_Ngay, myDen_Ngay, 2).Tables(0)
            If myDon_Vi_Bao_Cao = 1 Then ' ha noi
                pTen_Bao_Cao = "DANH SÁCH BƯU PHẨM EMS ECONOMY ĐI CÁC TỈNH"
            ElseIf myDon_Vi_Bao_Cao = 2 Then   'hcm
                pTen_Bao_Cao = "DANH SÁCH BƯU PHẨM EMS ECONOMY ĐI CÁC TỈNH VÀ CÁC HUYỆN NGOẠI THÀNH"
            Else
                pTen_Bao_Cao = "DANH SÁCH BƯU PHẨM EMS ECONOMY ĐI CÁC TỈNH"
            End If
        ElseIf optDau_Ma_E.Checked Then
            myTable = myE1_Di.E1_Di_Lay_Danh_Sach_Dong_Di_Tinh_Gui_Call_Center(GBuu_Cuc_Khai_Thac, myTu_Ngay, myDen_Ngay, 3).Tables(0)
            If myDon_Vi_Bao_Cao = 1 Then ' ha noi
                pTen_Bao_Cao = "DANH SÁCH BƯU PHẨM EMS QUỐC TẾ ĐI CÁC TỈNH"
            ElseIf myDon_Vi_Bao_Cao = 2 Then   'hcm
                pTen_Bao_Cao = "DANH SÁCH BƯU PHẨM EMS QUỐC TẾ ĐI CÁC TỈNH VÀ CÁC HUYỆN NGOẠI THÀNH"
            Else
                pTen_Bao_Cao = "DANH SÁCH BƯU PHẨM EMS QUỐC TẾ ĐI CÁC TỈNH"
            End If
        End If

        If myTable.Rows.Count = 0 Then
            Cursor.Current = Cursors.Default
            MessageBox.Show("Không có dữ liệu theo yêu cầu báo cáo. Mời bạn kiểm tra lại thông tin về thời gian", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        myTable.TableName = "E1_Di_Lay_Danh_Sach_Dong_Di_Tinh_Gui_Call_Center"
        myDataSet.Tables.Add(myTable.Copy)

        'Lay gia tri cho paramete
        Dim idx As Integer
        pTong_EMS = 0
        pTong_EMS_Economy = 0
        For idx = 0 To myTable.Rows.Count - 1
            If Trim(myTable.Rows(idx).Item("Ma_E1")) <> "" Then
                If Trim(myTable.Rows(idx).Item("Ma_C1")) <> "" Then
                    pTong_EMS_Economy = pTong_EMS_Economy + 1
                Else
                    pTong_EMS = pTong_EMS + 1
                End If
            End If
        Next

        If myDon_Vi_Bao_Cao = 1 Then        'ha noi
            pMenu_Trai = "CTY CPCPN BƯU ĐIỆN" & vbNewLine & "TRUNG TÂM KHAI THÁC QT HÀ NỘI"
        ElseIf myDon_Vi_Bao_Cao = 2 Then    'hcm
            pMenu_Trai = "CN CTY CPCPN BƯU ĐIỆN" & vbNewLine & "TRUNG TÂM KHAI THÁC QT TPHCM"
        Else    'khac
            pMenu_Trai = ""
        End If
        pMenu_Phai = ""

        pTu_Ngay_Den_Ngay = "Ngày khai thác:  " & DateTime.Parse(CbTu_Ngay.Value).ToString("dd/MM/yyyy")

        If myDon_Vi_Bao_Cao = 1 Then        'ha noi
            pNgay_Thang_Nam = "Hà nội, ngày " & Now.Day.ToString("00") & " tháng " & Now.Month.ToString("00") & " năm " & Now.Year.ToString("00")
        ElseIf myDon_Vi_Bao_Cao = 2 Then    'hcm
            pNgay_Thang_Nam = "TPHCM, ngày " & Now.Day.ToString("00") & " tháng " & Now.Month.ToString("00") & " năm " & Now.Year.ToString("00")
        Else    'khac
            pNgay_Thang_Nam = ""
        End If

        'Add Paramete into report
        pvCollection.Clear()
        _pThamSo.Value = pTong_EMS
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pTong_EMS").ApplyCurrentValues(pvCollection)

        pvCollection.Clear()
        _pThamSo.Value = pTong_EMS_Economy
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pTong_EMS_Economy").ApplyCurrentValues(pvCollection)

        pvCollection.Clear()
        _pThamSo.Value = pMenu_Trai
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pMenu_Trai").ApplyCurrentValues(pvCollection)

        pvCollection.Clear()
        _pThamSo.Value = pMenu_Phai
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pMenu_Phai").ApplyCurrentValues(pvCollection)

        pvCollection.Clear()
        _pThamSo.Value = pTen_Bao_Cao
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pTen_Bao_Cao").ApplyCurrentValues(pvCollection)

        pvCollection.Clear()
        _pThamSo.Value = pTu_Ngay_Den_Ngay
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pTu_Ngay_Den_Ngay").ApplyCurrentValues(pvCollection)

        pvCollection.Clear()
        _pThamSo.Value = pNgay_Thang_Nam
        pvCollection.Add(_pThamSo)
        rptView.DataDefinition.ParameterFields("pNgay_Thang_Nam").ApplyCurrentValues(pvCollection)

        rptView.SetDataSource(myDataSet)
        FrmView.CrystalReportViewer1.ReportSource = rptView
        Cursor.Current = Cursors.Default
        If mPreview Then
            FrmView.ShowDialog()
        Else
            rptView.PrintToPrinter(1, False, 0, 0)
        End If
    End Sub
#End Region

#Region "Kiem_Tra_Thoi_Gian_Bao_Cao"
    Private Function Kiem_Tra_Thoi_Gian_Bao_Cao() As Boolean
        Try
            myTu_Ngay = myHam_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value)
            myDen_Ngay = myTu_Ngay
            'If myTu_Ngay > myDen_Ngay Then
            '    MessageBox.Show("Chú ý, thông tin thời gian khác thác không hợp lệ!!!" & vbNewLine & "Từ ngày không được lớn hơn đến ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Return False
            '    Exit Function
            'End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region

#Region "Export_Danh_Sach_Dong_Di_Tinh_To_Excel"
    Private Sub Export_Danh_Sach_Dong_Di_Tinh_To_Excel()
        Dim myDataSet As DataSet
        'Lay du lieu
        If optTat_Ca.Checked Then
            myDataSet = myE1_Di.E1_Di_Lay_Danh_Sach_Dong_Di_Tinh_Gui_Call_Center(GBuu_Cuc_Khai_Thac, myTu_Ngay, myDen_Ngay, 1)
        ElseIf optDau_ma_C.Checked Then
            myDataSet = myE1_Di.E1_Di_Lay_Danh_Sach_Dong_Di_Tinh_Gui_Call_Center(GBuu_Cuc_Khai_Thac, myTu_Ngay, myDen_Ngay, 2)
        ElseIf optDau_Ma_E.Checked Then
            myDataSet = myE1_Di.E1_Di_Lay_Danh_Sach_Dong_Di_Tinh_Gui_Call_Center(GBuu_Cuc_Khai_Thac, myTu_Ngay, myDen_Ngay, 3)
        End If

        'Open SaveDialog
        With sFileDlg
            If optTat_Ca.Checked Then
                .FileName = "Danh_Sach_Tat_Ca_Dong_Di_Tinh_" & myTu_Ngay.ToString("00000000")
            ElseIf optDau_ma_C.Checked Then
                .FileName = "Danh_Sach_EMS_Economy_Dong_Di_Tinh_" & myTu_Ngay.ToString("00000000")
            ElseIf optDau_Ma_E.Checked Then
                .FileName = "Danh_Sach_EMS_Dong_Di_Tinh_" & myTu_Ngay.ToString("00000000")
            End If
            .Title = "Chon ten File"
            .DefaultExt = "*.xls"
            .Filter = "Xls (*.xls)|*.xls"
            .ShowDialog()
        End With

        If sFileDlg.FileName <> "" Then
            MessageBox.Show("Xin vui lòng chờ một vài phút, chương trình sẽ thực hiện việc xuất dữ liệu yêu cầu ra file excel. Thời gian chờ kết xuất dữ liệu phụ thuộc vào số lượng bản ghi của dữ liệu yêu cầu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Export_To_Excel_From_DataSet(myDataSet, sFileDlg.FileName)
        End If
    End Sub
#End Region

#End Region

#Region "Print_Report"
    Private Function Print_Report(ByVal mPreview As Boolean) As Boolean
        Try
            'Xac dinh Don vi khai thac quoc te
            Tim_Don_Vi_In_Bao_Cao()
            'In bao cao tuong ung
            If optDanh_Sach_Gui_Call_Center.Checked Then
                Danh_Sach_Buu_Pham_Gui_Call_Center(mPreview)
            ElseIf optBao_Cao_Tong_Hop_1.Checked Then
                MessageBox.Show("Chức năng này chưa hoàn chỉnh , mời ban quay lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf optBao_Cao_Tong_Hop_2.Checked Then
                MessageBox.Show("Chức năng này chưa hoàn chỉnh , mời ban quay lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf optBao_Cao_Tong_Hop_3.Checked Then
                MessageBox.Show("Chức năng này chưa hoàn chỉnh , mời ban quay lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        
    End Function
#End Region


#Region "btnTimKiem_Click"
    Private Sub btnTimKiem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimKiem.Click
        MessageBox.Show("Chức năng này chưa hoàn thiện, mời bạn quay lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
#End Region
   
End Class

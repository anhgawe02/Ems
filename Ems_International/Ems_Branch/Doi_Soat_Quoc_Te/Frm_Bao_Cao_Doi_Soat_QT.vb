Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports System.Data
Imports System.Data.OracleClient
Imports System.Data.SqlClient
Imports System.Math
Imports Ems_International_Logic.EMS
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Microsoft.Office

Public Class Frm_Bao_Cao_Doi_Soat_QT
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
    Friend WithEvents opt_Khoang_Thoi_Gian As System.Windows.Forms.RadioButton
    Friend WithEvents cb_Den_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cb_Tu_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents opt_Thang As System.Windows.Forms.RadioButton
    Friend WithEvents opt_Quy As System.Windows.Forms.RadioButton
    Friend WithEvents opt_Nam As System.Windows.Forms.RadioButton
    Friend WithEvents cb_Thang As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cb_Quy As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cb_Nam As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents group_Thoi_Gian As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents BtnThoat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents opt_Hang_Khong As System.Windows.Forms.RadioButton
    Friend WithEvents opt_Qua_Giang As System.Windows.Forms.RadioButton
    Friend WithEvents opt_Quoc_Te_Den As System.Windows.Forms.RadioButton
    Friend WithEvents opt_Quoc_Te_Di As System.Windows.Forms.RadioButton
    Friend WithEvents opt_Lua_Chon_Bao_Cao As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btnPrint As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnPreview As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cb_Duong_Thu_Qua_Giang As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents opt_Doanh_Thu As System.Windows.Forms.RadioButton
    Friend WithEvents group_Phan_Loai_Doanh_Thu As Infragistics.Win.Misc.UltraGroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Nam", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nam")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Quy", -1)
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Quy")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Thang", -1)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thang")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_Bao_Cao_Doi_Soat_QT))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.group_Thoi_Gian = New Infragistics.Win.Misc.UltraGroupBox
        Me.cb_Nam = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cb_Quy = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cb_Thang = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cb_Den_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.cb_Tu_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.opt_Nam = New System.Windows.Forms.RadioButton
        Me.opt_Quy = New System.Windows.Forms.RadioButton
        Me.opt_Khoang_Thoi_Gian = New System.Windows.Forms.RadioButton
        Me.opt_Thang = New System.Windows.Forms.RadioButton
        Me.BtnThoat = New Infragistics.Win.Misc.UltraButton
        Me.group_Phan_Loai_Doanh_Thu = New Infragistics.Win.Misc.UltraGroupBox
        Me.cb_Duong_Thu_Qua_Giang = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.opt_Hang_Khong = New System.Windows.Forms.RadioButton
        Me.opt_Qua_Giang = New System.Windows.Forms.RadioButton
        Me.opt_Quoc_Te_Den = New System.Windows.Forms.RadioButton
        Me.opt_Quoc_Te_Di = New System.Windows.Forms.RadioButton
        Me.opt_Lua_Chon_Bao_Cao = New Infragistics.Win.Misc.UltraGroupBox
        Me.opt_Doanh_Thu = New System.Windows.Forms.RadioButton
        Me.btnPrint = New Infragistics.Win.Misc.UltraButton
        Me.btnPreview = New Infragistics.Win.Misc.UltraButton
        CType(Me.group_Thoi_Gian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_Thoi_Gian.SuspendLayout()
        CType(Me.cb_Nam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_Quy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_Thang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_Den_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_Tu_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.group_Phan_Loai_Doanh_Thu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_Phan_Loai_Doanh_Thu.SuspendLayout()
        CType(Me.cb_Duong_Thu_Qua_Giang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.opt_Lua_Chon_Bao_Cao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.opt_Lua_Chon_Bao_Cao.SuspendLayout()
        Me.SuspendLayout()
        '
        'group_Thoi_Gian
        '
        Me.group_Thoi_Gian.Controls.Add(Me.cb_Nam)
        Me.group_Thoi_Gian.Controls.Add(Me.cb_Quy)
        Me.group_Thoi_Gian.Controls.Add(Me.cb_Thang)
        Me.group_Thoi_Gian.Controls.Add(Me.cb_Den_Ngay)
        Me.group_Thoi_Gian.Controls.Add(Me.UltraLabel4)
        Me.group_Thoi_Gian.Controls.Add(Me.cb_Tu_Ngay)
        Me.group_Thoi_Gian.Controls.Add(Me.UltraLabel3)
        Me.group_Thoi_Gian.Controls.Add(Me.opt_Nam)
        Me.group_Thoi_Gian.Controls.Add(Me.opt_Quy)
        Me.group_Thoi_Gian.Controls.Add(Me.opt_Khoang_Thoi_Gian)
        Me.group_Thoi_Gian.Controls.Add(Me.opt_Thang)
        Me.group_Thoi_Gian.Location = New System.Drawing.Point(16, 8)
        Me.group_Thoi_Gian.Name = "group_Thoi_Gian"
        Me.group_Thoi_Gian.Size = New System.Drawing.Size(416, 176)
        Me.group_Thoi_Gian.SupportThemes = False
        Me.group_Thoi_Gian.TabIndex = 0
        Me.group_Thoi_Gian.Text = "Thời gian báo cáo"
        '
        'cb_Nam
        '
        Me.cb_Nam.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn1.Header.Caption = "Năm"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1})
        Me.cb_Nam.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.cb_Nam.DisplayMember = ""
        Me.cb_Nam.Location = New System.Drawing.Point(184, 144)
        Me.cb_Nam.Name = "cb_Nam"
        Me.cb_Nam.Size = New System.Drawing.Size(96, 21)
        Me.cb_Nam.TabIndex = 68
        Me.cb_Nam.ValueMember = ""
        '
        'cb_Quy
        '
        Me.cb_Quy.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn2.Header.Caption = "Quý"
        UltraGridColumn2.Header.VisiblePosition = 0
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn2})
        Me.cb_Quy.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.cb_Quy.DisplayMember = ""
        Me.cb_Quy.Location = New System.Drawing.Point(184, 112)
        Me.cb_Quy.Name = "cb_Quy"
        Me.cb_Quy.Size = New System.Drawing.Size(96, 21)
        Me.cb_Quy.TabIndex = 67
        Me.cb_Quy.ValueMember = ""
        '
        'cb_Thang
        '
        Me.cb_Thang.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn3.Header.Caption = "Tháng"
        UltraGridColumn3.Header.VisiblePosition = 0
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn3})
        Me.cb_Thang.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.cb_Thang.DisplayMember = ""
        Me.cb_Thang.Location = New System.Drawing.Point(184, 80)
        Me.cb_Thang.Name = "cb_Thang"
        Me.cb_Thang.Size = New System.Drawing.Size(96, 21)
        Me.cb_Thang.TabIndex = 66
        Me.cb_Thang.ValueMember = ""
        '
        'cb_Den_Ngay
        '
        Me.cb_Den_Ngay.DateTime = New Date(2011, 6, 13, 0, 0, 0, 0)
        Me.cb_Den_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.cb_Den_Ngay.Location = New System.Drawing.Point(296, 48)
        Me.cb_Den_Ngay.Name = "cb_Den_Ngay"
        Me.cb_Den_Ngay.Size = New System.Drawing.Size(96, 21)
        Me.cb_Den_Ngay.TabIndex = 64
        Me.cb_Den_Ngay.Value = New Date(2011, 6, 13, 0, 0, 0, 0)
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UltraLabel4.Location = New System.Drawing.Point(296, 24)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(80, 16)
        Me.UltraLabel4.TabIndex = 65
        Me.UltraLabel4.Text = "Đến Ngày"
        '
        'cb_Tu_Ngay
        '
        Me.cb_Tu_Ngay.DateTime = New Date(2011, 6, 13, 0, 0, 0, 0)
        Me.cb_Tu_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.cb_Tu_Ngay.Location = New System.Drawing.Point(184, 48)
        Me.cb_Tu_Ngay.Name = "cb_Tu_Ngay"
        Me.cb_Tu_Ngay.Size = New System.Drawing.Size(96, 21)
        Me.cb_Tu_Ngay.TabIndex = 62
        Me.cb_Tu_Ngay.Value = New Date(2011, 6, 13, 0, 0, 0, 0)
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UltraLabel3.Location = New System.Drawing.Point(184, 24)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(80, 16)
        Me.UltraLabel3.TabIndex = 63
        Me.UltraLabel3.Text = "Từ Ngày"
        '
        'opt_Nam
        '
        Me.opt_Nam.Location = New System.Drawing.Point(24, 144)
        Me.opt_Nam.Name = "opt_Nam"
        Me.opt_Nam.Size = New System.Drawing.Size(120, 24)
        Me.opt_Nam.TabIndex = 61
        Me.opt_Nam.Text = "Năm"
        '
        'opt_Quy
        '
        Me.opt_Quy.Location = New System.Drawing.Point(24, 112)
        Me.opt_Quy.Name = "opt_Quy"
        Me.opt_Quy.Size = New System.Drawing.Size(120, 24)
        Me.opt_Quy.TabIndex = 60
        Me.opt_Quy.Text = "Quý"
        '
        'opt_Khoang_Thoi_Gian
        '
        Me.opt_Khoang_Thoi_Gian.Location = New System.Drawing.Point(24, 48)
        Me.opt_Khoang_Thoi_Gian.Name = "opt_Khoang_Thoi_Gian"
        Me.opt_Khoang_Thoi_Gian.Size = New System.Drawing.Size(120, 24)
        Me.opt_Khoang_Thoi_Gian.TabIndex = 59
        Me.opt_Khoang_Thoi_Gian.Text = "Khoảng Thời Gian"
        '
        'opt_Thang
        '
        Me.opt_Thang.Location = New System.Drawing.Point(24, 80)
        Me.opt_Thang.Name = "opt_Thang"
        Me.opt_Thang.Size = New System.Drawing.Size(120, 24)
        Me.opt_Thang.TabIndex = 58
        Me.opt_Thang.Text = "Tháng"
        '
        'BtnThoat
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.BtnThoat.Appearance = Appearance1
        Me.BtnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnThoat.ImageSize = New System.Drawing.Size(30, 25)
        Me.BtnThoat.Location = New System.Drawing.Point(680, 512)
        Me.BtnThoat.Name = "BtnThoat"
        Me.BtnThoat.Size = New System.Drawing.Size(88, 40)
        Me.BtnThoat.TabIndex = 56
        Me.BtnThoat.Text = "Thoát"
        '
        'group_Phan_Loai_Doanh_Thu
        '
        Me.group_Phan_Loai_Doanh_Thu.Controls.Add(Me.cb_Duong_Thu_Qua_Giang)
        Me.group_Phan_Loai_Doanh_Thu.Controls.Add(Me.opt_Hang_Khong)
        Me.group_Phan_Loai_Doanh_Thu.Controls.Add(Me.opt_Qua_Giang)
        Me.group_Phan_Loai_Doanh_Thu.Controls.Add(Me.opt_Quoc_Te_Den)
        Me.group_Phan_Loai_Doanh_Thu.Controls.Add(Me.opt_Quoc_Te_Di)
        Me.group_Phan_Loai_Doanh_Thu.Location = New System.Drawing.Point(16, 192)
        Me.group_Phan_Loai_Doanh_Thu.Name = "group_Phan_Loai_Doanh_Thu"
        Me.group_Phan_Loai_Doanh_Thu.Size = New System.Drawing.Size(416, 176)
        Me.group_Phan_Loai_Doanh_Thu.SupportThemes = False
        Me.group_Phan_Loai_Doanh_Thu.TabIndex = 57
        Me.group_Phan_Loai_Doanh_Thu.Text = "Phân Loại Doanh Thu"
        '
        'cb_Duong_Thu_Qua_Giang
        '
        Me.cb_Duong_Thu_Qua_Giang.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cb_Duong_Thu_Qua_Giang.DisplayMember = ""
        Me.cb_Duong_Thu_Qua_Giang.Location = New System.Drawing.Point(160, 104)
        Me.cb_Duong_Thu_Qua_Giang.Name = "cb_Duong_Thu_Qua_Giang"
        Me.cb_Duong_Thu_Qua_Giang.Size = New System.Drawing.Size(176, 21)
        Me.cb_Duong_Thu_Qua_Giang.TabIndex = 69
        Me.cb_Duong_Thu_Qua_Giang.Text = "Lựa chọn đường thư quá giang"
        Me.cb_Duong_Thu_Qua_Giang.ValueMember = ""
        '
        'opt_Hang_Khong
        '
        Me.opt_Hang_Khong.Location = New System.Drawing.Point(16, 144)
        Me.opt_Hang_Khong.Name = "opt_Hang_Khong"
        Me.opt_Hang_Khong.Size = New System.Drawing.Size(120, 24)
        Me.opt_Hang_Khong.TabIndex = 65
        Me.opt_Hang_Khong.Text = "Hàng Không"
        '
        'opt_Qua_Giang
        '
        Me.opt_Qua_Giang.Location = New System.Drawing.Point(16, 104)
        Me.opt_Qua_Giang.Name = "opt_Qua_Giang"
        Me.opt_Qua_Giang.Size = New System.Drawing.Size(120, 24)
        Me.opt_Qua_Giang.TabIndex = 64
        Me.opt_Qua_Giang.Text = "Quá Giang"
        '
        'opt_Quoc_Te_Den
        '
        Me.opt_Quoc_Te_Den.Location = New System.Drawing.Point(16, 32)
        Me.opt_Quoc_Te_Den.Name = "opt_Quoc_Te_Den"
        Me.opt_Quoc_Te_Den.Size = New System.Drawing.Size(120, 24)
        Me.opt_Quoc_Te_Den.TabIndex = 63
        Me.opt_Quoc_Te_Den.Text = "Quốc Tế Đến"
        '
        'opt_Quoc_Te_Di
        '
        Me.opt_Quoc_Te_Di.Location = New System.Drawing.Point(16, 64)
        Me.opt_Quoc_Te_Di.Name = "opt_Quoc_Te_Di"
        Me.opt_Quoc_Te_Di.Size = New System.Drawing.Size(120, 24)
        Me.opt_Quoc_Te_Di.TabIndex = 62
        Me.opt_Quoc_Te_Di.Text = "Quốc Tế Đi"
        '
        'opt_Lua_Chon_Bao_Cao
        '
        Me.opt_Lua_Chon_Bao_Cao.Controls.Add(Me.opt_Doanh_Thu)
        Me.opt_Lua_Chon_Bao_Cao.Location = New System.Drawing.Point(440, 16)
        Me.opt_Lua_Chon_Bao_Cao.Name = "opt_Lua_Chon_Bao_Cao"
        Me.opt_Lua_Chon_Bao_Cao.Size = New System.Drawing.Size(328, 352)
        Me.opt_Lua_Chon_Bao_Cao.SupportThemes = False
        Me.opt_Lua_Chon_Bao_Cao.TabIndex = 58
        Me.opt_Lua_Chon_Bao_Cao.Text = "Lựa chọn báo cáo"
        '
        'opt_Doanh_Thu
        '
        Me.opt_Doanh_Thu.Location = New System.Drawing.Point(16, 32)
        Me.opt_Doanh_Thu.Name = "opt_Doanh_Thu"
        Me.opt_Doanh_Thu.Size = New System.Drawing.Size(120, 24)
        Me.opt_Doanh_Thu.TabIndex = 64
        Me.opt_Doanh_Thu.Text = "Doanh Thu"
        '
        'btnPrint
        '
        Appearance2.FontData.BoldAsString = "True"
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Appearance2.TextHAlign = Infragistics.Win.HAlign.Center
        Me.btnPrint.Appearance = Appearance2
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnPrint.ImageSize = New System.Drawing.Size(40, 25)
        Me.btnPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPrint.Location = New System.Drawing.Point(576, 512)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(96, 40)
        Me.btnPrint.TabIndex = 116
        Me.btnPrint.Text = "Print"
        '
        'btnPreview
        '
        Appearance3.FontData.BoldAsString = "True"
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        Me.btnPreview.Appearance = Appearance3
        Me.btnPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnPreview.ImageSize = New System.Drawing.Size(40, 25)
        Me.btnPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPreview.Location = New System.Drawing.Point(448, 512)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(112, 40)
        Me.btnPreview.TabIndex = 115
        Me.btnPreview.Text = "Preview"
        '
        'Frm_Bao_Cao_Doi_Soat_QT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(784, 566)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.opt_Lua_Chon_Bao_Cao)
        Me.Controls.Add(Me.group_Phan_Loai_Doanh_Thu)
        Me.Controls.Add(Me.group_Thoi_Gian)
        Me.Controls.Add(Me.BtnThoat)
        Me.Name = "Frm_Bao_Cao_Doi_Soat_QT"
        Me.Text = "Thống kê báo cáo"
        CType(Me.group_Thoi_Gian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_Thoi_Gian.ResumeLayout(False)
        CType(Me.cb_Nam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_Quy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_Thang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_Den_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_Tu_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.group_Phan_Loai_Doanh_Thu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_Phan_Loai_Doanh_Thu.ResumeLayout(False)
        CType(Me.cb_Duong_Thu_Qua_Giang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.opt_Lua_Chon_Bao_Cao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.opt_Lua_Chon_Bao_Cao.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim myHam_Dung_Chung As New Ham_Dung_Chung
    Private Sub BtnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnThoat.Click
        Close()
        Dispose()
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        OpenReport(True, 1)
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        OpenReport(False, 1)
    End Sub

    Private Function OpenReport(ByVal Preview As Boolean, ByVal So_Ban As Integer) As Boolean
        Try

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        End Try
    End Function

    Private Sub Frm_Bao_Cao_Doi_Soat_QT_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If LoadForm() = False Then
            MessageBox.Show("Load Form lỗi!!!", "Thông báo", MessageBoxButtons.OK)
            Close()
            Dispose()
        End If
    End Sub

    Private Function LoadForm() As Boolean
        Try
            'Thời gian
            cb_Tu_Ngay.DateTime = Today
            cb_Den_Ngay.DateTime = Today
            Tao_Bang_Thang()
            Tao_Bang_Quy()
            Tao_Bang_Nam()
            'Loại báo cáo
            opt_Quoc_Te_Den.Checked = True

            'Lựa chọn báo cáo

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        End Try
    End Function

    Private Sub Tao_Bang_Thang()
        Dim dataTable As New dataTable

        Dim colWork As DataColumn = New DataColumn("Thang", GetType(Integer))
        dataTable.Columns.Add(colWork)

        Dim row As DataRow = dataTable.NewRow()
        row("Thang") = 1
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Thang") = 2
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Thang") = 3
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Thang") = 4
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Thang") = 5
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Thang") = 6
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Thang") = 7
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Thang") = 8
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Thang") = 9
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Thang") = 10
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Thang") = 11
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Thang") = 12
        dataTable.Rows.Add(row)

        cb_Thang.DataSource = dataTable
        cb_Thang.DataBind()

        cb_Thang.Value = getMonthFromDate(myHam_Dung_Chung.ConvertDateToInt(Today))
        cb_Thang.Text = getMonthFromDate(myHam_Dung_Chung.ConvertDateToInt(Today))
    End Sub

    Private Sub Tao_Bang_Quy()
        Dim dataTable As New dataTable

        Dim colWork As DataColumn = New DataColumn("Quy", GetType(Integer))
        dataTable.Columns.Add(colWork)

        Dim row As DataRow = dataTable.NewRow()
        row("Quy") = 1
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Quy") = 2
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Quy") = 3
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Quy") = 4
        dataTable.Rows.Add(row)

        cb_Quy.DataSource = dataTable
        cb_Quy.DataBind()

        cb_Quy.Value = getQuarterFromDate(myHam_Dung_Chung.ConvertDateToInt(Today))
        cb_Quy.Text = getQuarterFromDate(myHam_Dung_Chung.ConvertDateToInt(Today))
    End Sub

    Private Sub Tao_Bang_Nam()
        Dim dataTable As New dataTable

        Dim colWork As DataColumn = New DataColumn("Nam", GetType(Integer))
        dataTable.Columns.Add(colWork)

        Dim row As DataRow = dataTable.NewRow()
        row("Nam") = 2009
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Nam") = 2010
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Nam") = 2011
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Nam") = 2012
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Nam") = 2013
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Nam") = 2014
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Nam") = 2015
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Nam") = 2016
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Nam") = 2017
        dataTable.Rows.Add(row)

        cb_Nam.DataSource = dataTable
        cb_Nam.DataBind()


        cb_Nam.Value = getYearFromDate(myHam_Dung_Chung.ConvertDateToInt(Today))
        cb_Nam.Text = getYearFromDate(myHam_Dung_Chung.ConvertDateToInt(Today))
    End Sub

    Private Sub Tao_Bang_Duong_Thu_Qua_Giang()

    End Sub

    Private Function EnableReport() As Boolean

    End Function

    Private Function ChooseReport() As Integer
        'Lựa chọn loại báo cáo phù hợp
    End Function

    Private Sub opt_Khoang_Thoi_Gian_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opt_Khoang_Thoi_Gian.CheckedChanged, opt_Thang.CheckedChanged, opt_Quy.CheckedChanged, opt_Nam.CheckedChanged
        EnableTime()
    End Sub

    Private Sub EnableTime()
        If opt_Khoang_Thoi_Gian.Checked = True Then
            cb_Tu_Ngay.Enabled = True
            cb_Den_Ngay.Enabled = True
            cb_Thang.Enabled = False
            cb_Quy.Enabled = False
            cb_Nam.Enabled = False
        ElseIf opt_Thang.Checked = True Then
            cb_Tu_Ngay.Enabled = False
            cb_Den_Ngay.Enabled = False
            cb_Thang.Enabled = True
            cb_Quy.Enabled = False
            cb_Nam.Enabled = True
        ElseIf opt_Quy.Checked = True Then
            cb_Tu_Ngay.Enabled = False
            cb_Den_Ngay.Enabled = False
            cb_Thang.Enabled = False
            cb_Quy.Enabled = True
            cb_Nam.Enabled = True
        ElseIf opt_Nam.Checked = True Then
            cb_Tu_Ngay.Enabled = False
            cb_Den_Ngay.Enabled = False
            cb_Thang.Enabled = False
            cb_Quy.Enabled = False
            cb_Nam.Enabled = True
        Else
            cb_Tu_Ngay.Enabled = False
            cb_Den_Ngay.Enabled = False
            cb_Thang.Enabled = False
            cb_Quy.Enabled = False
            cb_Nam.Enabled = False
        End If
    End Sub

    Private Sub EnableCategory()
        If opt_Quoc_Te_Den.Checked = True Then
            cb_Duong_Thu_Qua_Giang.Enabled = False
        ElseIf opt_Quoc_Te_Di.Checked = True Then
            cb_Duong_Thu_Qua_Giang.Enabled = False
        ElseIf opt_Qua_Giang.Checked = True Then
            cb_Duong_Thu_Qua_Giang.Enabled = True
        ElseIf opt_Hang_Khong.Checked = True Then
            cb_Duong_Thu_Qua_Giang.Enabled = False
        Else
            cb_Duong_Thu_Qua_Giang.Enabled = False
        End If
    End Sub

    Private Sub opt_Quoc_Te_Den_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opt_Quoc_Te_Den.CheckedChanged, opt_Quoc_Te_Di.CheckedChanged, opt_Qua_Giang.CheckedChanged, opt_Hang_Khong.CheckedChanged
        EnableCategory()
    End Sub
End Class

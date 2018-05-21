Imports System.IO
Imports Ems_International_Logic.EMS
Public Class FrmDichVuDuLieu
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
    Friend WithEvents utSLPH As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents btnThoatSaoLuu As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCapNhatSaoLuu As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents chkSchedule As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents btnSchedule As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtSchedule As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents gbThuMuc As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFileName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnChonThuMuc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtDest As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btnChonPhucHoi As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtSourceFile As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnCapNhatPhucHoi As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnThoatPhucHoi As Infragistics.Win.Misc.UltraButton
    Friend WithEvents fbdThuMucSaoLuuDL As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents chk_BC37 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_E2 As System.Windows.Forms.CheckBox
    Friend WithEvents txt_BC37 As System.Windows.Forms.TextBox
    Friend WithEvents chk_E4 As System.Windows.Forms.CheckBox
    Friend WithEvents txt_E4 As System.Windows.Forms.TextBox
    Friend WithEvents txt_E2 As System.Windows.Forms.TextBox
    Friend WithEvents chk_BV10 As System.Windows.Forms.CheckBox
    Friend WithEvents txt_BV10 As System.Windows.Forms.TextBox
    Friend WithEvents chk_CN35 As System.Windows.Forms.CheckBox
    Friend WithEvents txt_CN35 As System.Windows.Forms.TextBox
    Friend WithEvents btnSelect_All As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnBC37 As System.Windows.Forms.Button
    Friend WithEvents btnCN35 As System.Windows.Forms.Button
    Friend WithEvents btnBV10 As System.Windows.Forms.Button
    Friend WithEvents btnE4 As System.Windows.Forms.Button
    Friend WithEvents btnE2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmDichVuDuLieu))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.btnThoatSaoLuu = New Infragistics.Win.Misc.UltraButton
        Me.btnCapNhatSaoLuu = New Infragistics.Win.Misc.UltraButton
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.chkSchedule = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.btnSchedule = New Infragistics.Win.Misc.UltraButton
        Me.txtSchedule = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.gbThuMuc = New Infragistics.Win.Misc.UltraGroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtFileName = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.btnChonThuMuc = New Infragistics.Win.Misc.UltraButton
        Me.txtDest = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox
        Me.btnChonPhucHoi = New Infragistics.Win.Misc.UltraButton
        Me.txtSourceFile = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.btnCapNhatPhucHoi = New Infragistics.Win.Misc.UltraButton
        Me.btnThoatPhucHoi = New Infragistics.Win.Misc.UltraButton
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.btnE2 = New System.Windows.Forms.Button
        Me.btnE4 = New System.Windows.Forms.Button
        Me.btnBV10 = New System.Windows.Forms.Button
        Me.btnCN35 = New System.Windows.Forms.Button
        Me.btnBC37 = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnSelect_All = New System.Windows.Forms.Button
        Me.chk_CN35 = New System.Windows.Forms.CheckBox
        Me.txt_CN35 = New System.Windows.Forms.TextBox
        Me.chk_BV10 = New System.Windows.Forms.CheckBox
        Me.txt_BV10 = New System.Windows.Forms.TextBox
        Me.chk_E2 = New System.Windows.Forms.CheckBox
        Me.txt_E2 = New System.Windows.Forms.TextBox
        Me.chk_E4 = New System.Windows.Forms.CheckBox
        Me.txt_E4 = New System.Windows.Forms.TextBox
        Me.chk_BC37 = New System.Windows.Forms.CheckBox
        Me.txt_BC37 = New System.Windows.Forms.TextBox
        Me.utSLPH = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.fbdThuMucSaoLuuDL = New System.Windows.Forms.FolderBrowserDialog
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.txtSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbThuMuc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbThuMuc.SuspendLayout()
        CType(Me.txtFileName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.txtSourceFile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.utSLPH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utSLPH.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.btnThoatSaoLuu)
        Me.UltraTabPageControl1.Controls.Add(Me.btnCapNhatSaoLuu)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl1.Controls.Add(Me.gbThuMuc)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(540, 268)
        '
        'btnThoatSaoLuu
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.btnThoatSaoLuu.Appearance = Appearance1
        Me.btnThoatSaoLuu.Location = New System.Drawing.Point(274, 224)
        Me.btnThoatSaoLuu.Name = "btnThoatSaoLuu"
        Me.btnThoatSaoLuu.Size = New System.Drawing.Size(88, 32)
        Me.btnThoatSaoLuu.TabIndex = 1
        Me.btnThoatSaoLuu.Text = "Thoát"
        '
        'btnCapNhatSaoLuu
        '
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.btnCapNhatSaoLuu.Appearance = Appearance2
        Me.btnCapNhatSaoLuu.Location = New System.Drawing.Point(180, 224)
        Me.btnCapNhatSaoLuu.Name = "btnCapNhatSaoLuu"
        Me.btnCapNhatSaoLuu.Size = New System.Drawing.Size(88, 32)
        Me.btnCapNhatSaoLuu.TabIndex = 0
        Me.btnCapNhatSaoLuu.Text = "Cập nhật"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.chkSchedule)
        Me.UltraGroupBox1.Controls.Add(Me.btnSchedule)
        Me.UltraGroupBox1.Controls.Add(Me.txtSchedule)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(8, 112)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(528, 96)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 1
        '
        'chkSchedule
        '
        Me.chkSchedule.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSchedule.Location = New System.Drawing.Point(8, 16)
        Me.chkSchedule.Name = "chkSchedule"
        Me.chkSchedule.Size = New System.Drawing.Size(112, 20)
        Me.chkSchedule.TabIndex = 0
        Me.chkSchedule.Text = "Lập lịch sao lưu"
        '
        'btnSchedule
        '
        Me.btnSchedule.Location = New System.Drawing.Point(432, 40)
        Me.btnSchedule.Name = "btnSchedule"
        Me.btnSchedule.Size = New System.Drawing.Size(56, 24)
        Me.btnSchedule.TabIndex = 2
        Me.btnSchedule.Text = "..."
        '
        'txtSchedule
        '
        Me.txtSchedule.Location = New System.Drawing.Point(8, 40)
        Me.txtSchedule.Multiline = True
        Me.txtSchedule.Name = "txtSchedule"
        Me.txtSchedule.Size = New System.Drawing.Size(416, 48)
        Me.txtSchedule.TabIndex = 1
        '
        'gbThuMuc
        '
        Me.gbThuMuc.Controls.Add(Me.Label1)
        Me.gbThuMuc.Controls.Add(Me.txtFileName)
        Me.gbThuMuc.Controls.Add(Me.btnChonThuMuc)
        Me.gbThuMuc.Controls.Add(Me.txtDest)
        Me.gbThuMuc.Location = New System.Drawing.Point(8, 8)
        Me.gbThuMuc.Name = "gbThuMuc"
        Me.gbThuMuc.Size = New System.Drawing.Size(528, 96)
        Me.gbThuMuc.SupportThemes = False
        Me.gbThuMuc.TabIndex = 0
        Me.gbThuMuc.Text = "Thư mục sao lưu"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "File dữ liệu"
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(88, 48)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(224, 21)
        Me.txtFileName.TabIndex = 2
        '
        'btnChonThuMuc
        '
        Me.btnChonThuMuc.Location = New System.Drawing.Point(432, 24)
        Me.btnChonThuMuc.Name = "btnChonThuMuc"
        Me.btnChonThuMuc.Size = New System.Drawing.Size(56, 24)
        Me.btnChonThuMuc.TabIndex = 3
        Me.btnChonThuMuc.Text = "..."
        '
        'txtDest
        '
        Me.txtDest.Location = New System.Drawing.Point(8, 24)
        Me.txtDest.Name = "txtDest"
        Me.txtDest.Size = New System.Drawing.Size(416, 21)
        Me.txtDest.TabIndex = 0
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox2)
        Me.UltraTabPageControl2.Controls.Add(Me.btnCapNhatPhucHoi)
        Me.UltraTabPageControl2.Controls.Add(Me.btnThoatPhucHoi)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(540, 268)
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.btnChonPhucHoi)
        Me.UltraGroupBox2.Controls.Add(Me.txtSourceFile)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(7, 8)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(528, 200)
        Me.UltraGroupBox2.SupportThemes = False
        Me.UltraGroupBox2.TabIndex = 1
        Me.UltraGroupBox2.Text = "File dữ liệu phục hồi"
        '
        'btnChonPhucHoi
        '
        Me.btnChonPhucHoi.Location = New System.Drawing.Point(432, 24)
        Me.btnChonPhucHoi.Name = "btnChonPhucHoi"
        Me.btnChonPhucHoi.Size = New System.Drawing.Size(56, 24)
        Me.btnChonPhucHoi.TabIndex = 3
        Me.btnChonPhucHoi.Text = "..."
        '
        'txtSourceFile
        '
        Me.txtSourceFile.Location = New System.Drawing.Point(8, 24)
        Me.txtSourceFile.Multiline = True
        Me.txtSourceFile.Name = "txtSourceFile"
        Me.txtSourceFile.Size = New System.Drawing.Size(416, 168)
        Me.txtSourceFile.TabIndex = 2
        '
        'btnCapNhatPhucHoi
        '
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        Me.btnCapNhatPhucHoi.Appearance = Appearance3
        Me.btnCapNhatPhucHoi.Location = New System.Drawing.Point(176, 224)
        Me.btnCapNhatPhucHoi.Name = "btnCapNhatPhucHoi"
        Me.btnCapNhatPhucHoi.Size = New System.Drawing.Size(88, 32)
        Me.btnCapNhatPhucHoi.TabIndex = 38
        Me.btnCapNhatPhucHoi.Text = "Cập nhật"
        '
        'btnThoatPhucHoi
        '
        Appearance4.Image = CType(resources.GetObject("Appearance4.Image"), Object)
        Me.btnThoatPhucHoi.Appearance = Appearance4
        Me.btnThoatPhucHoi.Location = New System.Drawing.Point(272, 224)
        Me.btnThoatPhucHoi.Name = "btnThoatPhucHoi"
        Me.btnThoatPhucHoi.Size = New System.Drawing.Size(88, 32)
        Me.btnThoatPhucHoi.TabIndex = 39
        Me.btnThoatPhucHoi.Text = "Thoát"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.btnE2)
        Me.UltraTabPageControl3.Controls.Add(Me.btnE4)
        Me.UltraTabPageControl3.Controls.Add(Me.btnBV10)
        Me.UltraTabPageControl3.Controls.Add(Me.btnCN35)
        Me.UltraTabPageControl3.Controls.Add(Me.btnBC37)
        Me.UltraTabPageControl3.Controls.Add(Me.btnDelete)
        Me.UltraTabPageControl3.Controls.Add(Me.btnSelect_All)
        Me.UltraTabPageControl3.Controls.Add(Me.chk_CN35)
        Me.UltraTabPageControl3.Controls.Add(Me.txt_CN35)
        Me.UltraTabPageControl3.Controls.Add(Me.chk_BV10)
        Me.UltraTabPageControl3.Controls.Add(Me.txt_BV10)
        Me.UltraTabPageControl3.Controls.Add(Me.chk_E2)
        Me.UltraTabPageControl3.Controls.Add(Me.txt_E2)
        Me.UltraTabPageControl3.Controls.Add(Me.chk_E4)
        Me.UltraTabPageControl3.Controls.Add(Me.txt_E4)
        Me.UltraTabPageControl3.Controls.Add(Me.chk_BC37)
        Me.UltraTabPageControl3.Controls.Add(Me.txt_BC37)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(2, 24)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(540, 268)
        '
        'btnE2
        '
        Me.btnE2.Enabled = False
        Me.btnE2.Location = New System.Drawing.Point(424, 72)
        Me.btnE2.Name = "btnE2"
        Me.btnE2.Size = New System.Drawing.Size(48, 24)
        Me.btnE2.TabIndex = 16
        Me.btnE2.Text = "..."
        '
        'btnE4
        '
        Me.btnE4.Enabled = False
        Me.btnE4.Location = New System.Drawing.Point(424, 104)
        Me.btnE4.Name = "btnE4"
        Me.btnE4.Size = New System.Drawing.Size(48, 24)
        Me.btnE4.TabIndex = 15
        Me.btnE4.Text = "..."
        '
        'btnBV10
        '
        Me.btnBV10.Enabled = False
        Me.btnBV10.Location = New System.Drawing.Point(424, 136)
        Me.btnBV10.Name = "btnBV10"
        Me.btnBV10.Size = New System.Drawing.Size(48, 24)
        Me.btnBV10.TabIndex = 14
        Me.btnBV10.Text = "..."
        '
        'btnCN35
        '
        Me.btnCN35.Enabled = False
        Me.btnCN35.Location = New System.Drawing.Point(424, 168)
        Me.btnCN35.Name = "btnCN35"
        Me.btnCN35.Size = New System.Drawing.Size(48, 24)
        Me.btnCN35.TabIndex = 13
        Me.btnCN35.Text = "..."
        '
        'btnBC37
        '
        Me.btnBC37.Enabled = False
        Me.btnBC37.Location = New System.Drawing.Point(424, 40)
        Me.btnBC37.Name = "btnBC37"
        Me.btnBC37.Size = New System.Drawing.Size(48, 24)
        Me.btnBC37.TabIndex = 12
        Me.btnBC37.Text = "..."
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(288, 216)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 32)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Xoá dữ liệu"
        '
        'btnSelect_All
        '
        Me.btnSelect_All.Location = New System.Drawing.Point(176, 216)
        Me.btnSelect_All.Name = "btnSelect_All"
        Me.btnSelect_All.Size = New System.Drawing.Size(75, 32)
        Me.btnSelect_All.TabIndex = 10
        Me.btnSelect_All.Text = "+"
        '
        'chk_CN35
        '
        Me.chk_CN35.Location = New System.Drawing.Point(56, 168)
        Me.chk_CN35.Name = "chk_CN35"
        Me.chk_CN35.TabIndex = 9
        Me.chk_CN35.Text = "Dữ liệu CN35"
        '
        'txt_CN35
        '
        Me.txt_CN35.Enabled = False
        Me.txt_CN35.Location = New System.Drawing.Point(176, 168)
        Me.txt_CN35.Name = "txt_CN35"
        Me.txt_CN35.Size = New System.Drawing.Size(224, 20)
        Me.txt_CN35.TabIndex = 8
        Me.txt_CN35.Text = "C:\EMS_INTERNATIONAL\CN35\*.*"
        '
        'chk_BV10
        '
        Me.chk_BV10.Location = New System.Drawing.Point(56, 136)
        Me.chk_BV10.Name = "chk_BV10"
        Me.chk_BV10.TabIndex = 7
        Me.chk_BV10.Text = "Dữ liệu BV10"
        '
        'txt_BV10
        '
        Me.txt_BV10.Enabled = False
        Me.txt_BV10.Location = New System.Drawing.Point(176, 136)
        Me.txt_BV10.Name = "txt_BV10"
        Me.txt_BV10.Size = New System.Drawing.Size(224, 20)
        Me.txt_BV10.TabIndex = 6
        Me.txt_BV10.Text = "C:\EMS_INTERNATIONAL\BV10\*.*"
        '
        'chk_E2
        '
        Me.chk_E2.Location = New System.Drawing.Point(56, 72)
        Me.chk_E2.Name = "chk_E2"
        Me.chk_E2.TabIndex = 5
        Me.chk_E2.Text = "Dữ liệu E2"
        '
        'txt_E2
        '
        Me.txt_E2.Enabled = False
        Me.txt_E2.Location = New System.Drawing.Point(176, 72)
        Me.txt_E2.Name = "txt_E2"
        Me.txt_E2.Size = New System.Drawing.Size(224, 20)
        Me.txt_E2.TabIndex = 4
        Me.txt_E2.Text = "C:\EMS_INTERNATIONAL\E2\*.*"
        '
        'chk_E4
        '
        Me.chk_E4.Location = New System.Drawing.Point(56, 104)
        Me.chk_E4.Name = "chk_E4"
        Me.chk_E4.TabIndex = 3
        Me.chk_E4.Text = "Dữ liệu E4"
        '
        'txt_E4
        '
        Me.txt_E4.Enabled = False
        Me.txt_E4.Location = New System.Drawing.Point(176, 104)
        Me.txt_E4.Name = "txt_E4"
        Me.txt_E4.Size = New System.Drawing.Size(224, 20)
        Me.txt_E4.TabIndex = 2
        Me.txt_E4.Text = "C:\EMS_INTERNATIONAL\E4\*.*"
        '
        'chk_BC37
        '
        Me.chk_BC37.Location = New System.Drawing.Point(56, 40)
        Me.chk_BC37.Name = "chk_BC37"
        Me.chk_BC37.TabIndex = 1
        Me.chk_BC37.Text = "Dữ liệu BC37"
        '
        'txt_BC37
        '
        Me.txt_BC37.Enabled = False
        Me.txt_BC37.Location = New System.Drawing.Point(176, 40)
        Me.txt_BC37.Name = "txt_BC37"
        Me.txt_BC37.Size = New System.Drawing.Size(224, 20)
        Me.txt_BC37.TabIndex = 0
        Me.txt_BC37.Text = "C:\EMS_INTERNATIONAL\BC37\*.*"
        '
        'utSLPH
        '
        Me.utSLPH.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utSLPH.Controls.Add(Me.UltraTabPageControl1)
        Me.utSLPH.Controls.Add(Me.UltraTabPageControl2)
        Me.utSLPH.Controls.Add(Me.UltraTabPageControl3)
        Me.utSLPH.Dock = System.Windows.Forms.DockStyle.Fill
        Me.utSLPH.Location = New System.Drawing.Point(0, 0)
        Me.utSLPH.Name = "utSLPH"
        Me.utSLPH.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utSLPH.Size = New System.Drawing.Size(544, 294)
        Me.utSLPH.TabIndex = 1
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Sao lưu dữ liệu"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Phục hồi dữ liệu"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Dọn dẹp dữ liệu"
        Me.utSLPH.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(540, 268)
        '
        'fbdThuMucSaoLuuDL
        '
        Me.fbdThuMucSaoLuuDL.Description = "Chọn thư mục chứa file sao lưu dữ liệu"
        '
        'FrmDichVuDuLieu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(544, 294)
        Me.Controls.Add(Me.utSLPH)
        Me.Name = "FrmDichVuDuLieu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dịch vụ dữ liệu"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.txtSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbThuMuc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbThuMuc.ResumeLayout(False)
        CType(Me.txtFileName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.txtSourceFile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.utSLPH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utSLPH.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private m_iBackupType As Integer
    Private m_iFreqType As Integer
    Private m_iFreqInterval As Integer
    Private m_iFreqRecurrenceFactor As Integer
    Private m_iFreqSubDayInterval As Integer
    Private m_iFreqSubDayType As Integer
    Private m_iActiveStartDate As Integer
    Private m_iActiveEndDate As Integer
    Private m_iActiveStartTime As Integer
    Private m_iActiveEndTime As Integer
    Dim mySaoLuu As Lap_Lich = New Lap_Lich(GConnectionString)
    Dim myData As DataTable
    Public Function TestConn() As Boolean
        Try
            ' Query database
            Dim myGiamGia As New Giam_Gia(GConnectionString)
            Return True
        Catch ex As Exception
            Return False
        Finally
        End Try
    End Function
    
    Private Function KhongHopLe() As Boolean
        With Me
            If .txtDest.Text = "" Then
                CMessageBox.Show("Thư mục chứa tệp sao lưu chưa được xác định !!!", "Bạn phải chọn thư mục trước khi thực hiện", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return True
            End If
            If .txtFileName.Text = "" Then
                CMessageBox.Show("Tệp sao lưu chưa được xác định !!!", "Bạn phải xác định tệp sao lưu trước khi thực hiện", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return True
            End If
            If .txtSchedule.Text = "" And .chkSchedule.Checked Then
                CMessageBox.Show("Chưa xác lập kế hoạch sao lưu !!!", "Bạn cần thiết lập kế hoạch sao lưu trước", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return True
            End If
            If Not Directory.Exists((Me.txtDest.Text.Trim())) Then
                CMessageBox.Show("Thư mục không tồn tại !!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return True
            End If
        End With
        Return False
    End Function
    Private Sub btnChonThuMuc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChonThuMuc.Click
        If Me.fbdThuMucSaoLuuDL.ShowDialog = DialogResult.OK Then
            Me.txtDest.Text = Me.fbdThuMucSaoLuuDL.SelectedPath
        Else
            Me.txtDest.Text = ""
        End If
    End Sub

    Private Sub btnCapNhatSaoLuu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapNhatSaoLuu.Click
        If Not TestConn() Then
            CMessageBox.Show("Không thể kết nối đến CSDL Database !!!", "Bạn hãy kiểm tra lại máy chủ hoặc đường mạng.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If KhongHopLe() Then
            Exit Sub
        End If
        If chkSchedule.Checked Then
            mySaoLuu.LAP_LICH_SAO_LUU(m_iFreqType, m_iFreqInterval, m_iFreqRecurrenceFactor, m_iFreqSubDayType, m_iFreqSubDayInterval, m_iActiveStartDate, m_iActiveEndDate, m_iActiveStartTime, m_iActiveEndTime, txtDest.Text.Trim, txtFileName.Text.Trim)
        End If
        CMessageBox.Show("Kế hoạch sao lưu đã được thiết lập thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub btnSchedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSchedule.Click
        Dim frm As New FrmLichSaoLuu
        frm.ShowDialog()
        If frm.OKPressed Then
            With frm
                m_iFreqType = .FreqType
                m_iFreqInterval = .FreqInterval
                m_iFreqRecurrenceFactor = .FreqRecurrenceFactor
                m_iFreqSubDayInterval = .FreqSubDayInterval
                m_iFreqSubDayType = .FreqSubDayType
                m_iActiveStartDate = .ActiveStartDate
                m_iActiveEndDate = .ActiveEndDate
                m_iActiveStartTime = .ActiveStartTime
                m_iActiveEndTime = .ActiveEndTime
                txtSchedule.Text = .ScheduleString
            End With
        End If
    End Sub

    Private Sub chkSchedule_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSchedule.CheckedChanged
        btnSchedule.Enabled = Me.chkSchedule.Checked
    End Sub
    Private Function DieuKhienTrong() As Boolean
        With Me
            If .txtSourceFile.Text = "" Then
                CMessageBox.Show("Bạn phải vào tệp dữ liệu nguồn !!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                .txtSourceFile.Focus()
                Return True
            End If
        End With
        Return False
    End Function

    Private Sub btnCapNhatPhucHoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapNhatPhucHoi.Click
        Try
            If Not TestConn() Then
                CMessageBox.Show("Không thể kết nối đến CSDL !!!", "Bạn hãy kiểm tra lại máy chủ hoặc đường mạng.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If CMessageBox.Show("Dữ liệu hiện tải sẽ được thay bằng dữ liệu mới từ file backup", "Bạn có chắc chắn muốn thực hiện phục hồi dữ liệu không ???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Exit Sub
                Return
            End If

            If DieuKhienTrong() Then
                Return
            End If
            mySaoLuu.Phuc_Hoi_Du_Lieu("Ems_Branch", txtSourceFile.Text.Trim)

        Catch ex As Exception
            CMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnChonPhucHoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChonPhucHoi.Click
        Dim openFiledialog As New openFiledialog
        openFiledialog.InitialDirectory = "D:\"
        openFiledialog.ShowDialog()
        Me.txtSourceFile.Text = openFiledialog.FileName
    End Sub

    Private Sub btnThoatPhucHoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoatPhucHoi.Click
        Close()
    End Sub

    Private Sub btnThoatSaoLuu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoatSaoLuu.Click
        Close()
    End Sub

#Region "Don dep du lieu tam tren may Local"
#Region "Check ALL"
    Private Sub ControlCheckALL(ByVal isCheck As Boolean)
        chk_BC37.Checked = isCheck
        chk_E2.Checked = isCheck
        chk_E4.Checked = isCheck
        chk_BV10.Checked = isCheck
        chk_CN35.Checked = isCheck
    End Sub
#End Region
#Region "Refresh Textbox"
    Private Sub RefreshTEXTBOX()
        txt_BC37.Text = "C:\EMS_INTERNATIONAL\BC37\*.ink"
        txt_E2.Text = "C:\EMS_INTERNATIONAL\E2\*.ink"
        txt_E4.Text = "C:\EMS_INTERNATIONAL\E4\*.ink"
        txt_BV10.Text = "C:\EMS_INTERNATIONAL\BV10\*.ink"
        txt_CN35.Text = "C:\EMS_INTERNATIONAL\CN35\*.ink"
    End Sub
#End Region
#Region "Delete Data Temp"
    Private Sub Delete_ALL_File()
        If chk_BC37.Checked Then Delete_File(txt_BC37.Text)
        If chk_E2.Checked Then Delete_File(txt_E2.Text)
        If chk_E4.Checked Then Delete_File(txt_E4.Text)
        If chk_BV10.Checked Then Delete_File(txt_BV10.Text)
        If chk_CN35.Checked Then Delete_File(txt_CN35.Text)
        MsgBox("Đã xoá dữ liệu tạm thành công", MsgBoxStyle.Information, "Thông báo")
    End Sub

    Private Sub Delete_File(ByVal strPATH As String)
        Shell("CMD /C del " & strPATH, vbHide)
    End Sub
#End Region
#End Region

    Private Sub utSLPH_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles utSLPH.SelectedTabChanged
        Select Case e.Tab.Index
            Case 0  'Sao luu
            Case 1  'Phuc hoi
            Case 2  'Don dep
                RefreshTEXTBOX()
                ControlCheckALL(True)
                btnSelect_All.Text = "&Bỏ chọn"
        End Select
    End Sub

    Private Sub btnSelect_All_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect_All.Click
        If btnSelect_All.Text = "&Bỏ chọn" Then
            ControlCheckALL(False)
            btnSelect_All.Text = "&Chọn tất cả"
        Else
            ControlCheckALL(True)
            btnSelect_All.Text = "&Bỏ chọn"
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Delete_ALL_File()
    End Sub
End Class

Imports System
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports Ems_International_Logic.EMS

'Imports Ems_Utility.Ems_Utility

Public Class frmBaoCaoBC37
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
    Friend WithEvents cbMa_Buu_Cuc_KT As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbCa_San_Xuat As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbPhuong_Tien_VC As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents panel_Top As System.Windows.Forms.Panel
    Friend WithEvents panel_main As System.Windows.Forms.Panel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnXem_Du_Lieu As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnXem_Bao_Cao As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnIn_Bao_Cao As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnThoat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbBao_Cao As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbDot_Giao_Nhan As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents calTuNgay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents calDenNgay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents btnXuat_Excel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents gridExcExp As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
    Friend WithEvents dgBaoCao_BC37_TH As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbTuyen_VC As Infragistics.Win.UltraWinGrid.UltraCombo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmBaoCaoBC37))
        Me.cbMa_Buu_Cuc_KT = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cbCa_San_Xuat = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cbPhuong_Tien_VC = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.btnXem_Du_Lieu = New Infragistics.Win.Misc.UltraButton
        Me.btnXem_Bao_Cao = New Infragistics.Win.Misc.UltraButton
        Me.panel_Top = New System.Windows.Forms.Panel
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel
        Me.cbTuyen_VC = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.btnXuat_Excel = New Infragistics.Win.Misc.UltraButton
        Me.calDenNgay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.calTuNgay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel
        Me.cbDot_Giao_Nhan = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        Me.cbBao_Cao = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.btnIn_Bao_Cao = New Infragistics.Win.Misc.UltraButton
        Me.btnThoat = New Infragistics.Win.Misc.UltraButton
        Me.panel_main = New System.Windows.Forms.Panel
        Me.dgBaoCao_BC37_TH = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.gridExcExp = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
        CType(Me.cbMa_Buu_Cuc_KT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCa_San_Xuat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbPhuong_Tien_VC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_Top.SuspendLayout()
        CType(Me.cbTuyen_VC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.calDenNgay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.calTuNgay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDot_Giao_Nhan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbBao_Cao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_main.SuspendLayout()
        CType(Me.dgBaoCao_BC37_TH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbMa_Buu_Cuc_KT
        '
        Me.cbMa_Buu_Cuc_KT.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbMa_Buu_Cuc_KT.DisplayMember = ""
        Me.cbMa_Buu_Cuc_KT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMa_Buu_Cuc_KT.Location = New System.Drawing.Point(88, 64)
        Me.cbMa_Buu_Cuc_KT.Name = "cbMa_Buu_Cuc_KT"
        Me.cbMa_Buu_Cuc_KT.Size = New System.Drawing.Size(264, 24)
        Me.cbMa_Buu_Cuc_KT.TabIndex = 3
        Me.cbMa_Buu_Cuc_KT.ValueMember = ""
        '
        'cbCa_San_Xuat
        '
        Me.cbCa_San_Xuat.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbCa_San_Xuat.DisplayMember = ""
        Me.cbCa_San_Xuat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cbCa_San_Xuat.Location = New System.Drawing.Point(456, 8)
        Me.cbCa_San_Xuat.Name = "cbCa_San_Xuat"
        Me.cbCa_San_Xuat.Size = New System.Drawing.Size(168, 23)
        Me.cbCa_San_Xuat.TabIndex = 4
        Me.cbCa_San_Xuat.ValueMember = ""
        '
        'cbPhuong_Tien_VC
        '
        Me.cbPhuong_Tien_VC.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbPhuong_Tien_VC.DisplayMember = ""
        Me.cbPhuong_Tien_VC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPhuong_Tien_VC.Location = New System.Drawing.Point(456, 64)
        Me.cbPhuong_Tien_VC.Name = "cbPhuong_Tien_VC"
        Me.cbPhuong_Tien_VC.Size = New System.Drawing.Size(168, 24)
        Me.cbPhuong_Tien_VC.TabIndex = 6
        Me.cbPhuong_Tien_VC.ValueMember = ""
        '
        'btnXem_Du_Lieu
        '
        Me.btnXem_Du_Lieu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXem_Du_Lieu.Location = New System.Drawing.Point(632, 8)
        Me.btnXem_Du_Lieu.Name = "btnXem_Du_Lieu"
        Me.btnXem_Du_Lieu.Size = New System.Drawing.Size(88, 32)
        Me.btnXem_Du_Lieu.TabIndex = 7
        Me.btnXem_Du_Lieu.Text = "Xem dữ liệu"
        '
        'btnXem_Bao_Cao
        '
        Me.btnXem_Bao_Cao.Enabled = False
        Me.btnXem_Bao_Cao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXem_Bao_Cao.Location = New System.Drawing.Point(720, 8)
        Me.btnXem_Bao_Cao.Name = "btnXem_Bao_Cao"
        Me.btnXem_Bao_Cao.Size = New System.Drawing.Size(96, 32)
        Me.btnXem_Bao_Cao.TabIndex = 8
        Me.btnXem_Bao_Cao.Text = "Xem báo cáo"
        '
        'panel_Top
        '
        Me.panel_Top.Controls.Add(Me.UltraLabel9)
        Me.panel_Top.Controls.Add(Me.cbTuyen_VC)
        Me.panel_Top.Controls.Add(Me.btnXuat_Excel)
        Me.panel_Top.Controls.Add(Me.calDenNgay)
        Me.panel_Top.Controls.Add(Me.calTuNgay)
        Me.panel_Top.Controls.Add(Me.UltraLabel7)
        Me.panel_Top.Controls.Add(Me.cbDot_Giao_Nhan)
        Me.panel_Top.Controls.Add(Me.UltraLabel6)
        Me.panel_Top.Controls.Add(Me.cbBao_Cao)
        Me.panel_Top.Controls.Add(Me.UltraLabel5)
        Me.panel_Top.Controls.Add(Me.UltraLabel3)
        Me.panel_Top.Controls.Add(Me.UltraLabel4)
        Me.panel_Top.Controls.Add(Me.UltraLabel2)
        Me.panel_Top.Controls.Add(Me.UltraLabel1)
        Me.panel_Top.Controls.Add(Me.cbMa_Buu_Cuc_KT)
        Me.panel_Top.Controls.Add(Me.btnXem_Du_Lieu)
        Me.panel_Top.Controls.Add(Me.cbPhuong_Tien_VC)
        Me.panel_Top.Controls.Add(Me.btnXem_Bao_Cao)
        Me.panel_Top.Controls.Add(Me.cbCa_San_Xuat)
        Me.panel_Top.Controls.Add(Me.btnIn_Bao_Cao)
        Me.panel_Top.Controls.Add(Me.btnThoat)
        Me.panel_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_Top.Location = New System.Drawing.Point(0, 0)
        Me.panel_Top.Name = "panel_Top"
        Me.panel_Top.Size = New System.Drawing.Size(884, 96)
        Me.panel_Top.TabIndex = 9
        '
        'UltraLabel9
        '
        Appearance1.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance1.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.UltraLabel9.Appearance = Appearance1
        Me.UltraLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(208, 104)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel9.TabIndex = 24
        Me.UltraLabel9.Text = "Tuyến VC"
        Me.UltraLabel9.Visible = False
        '
        'cbTuyen_VC
        '
        Me.cbTuyen_VC.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbTuyen_VC.DisplayMember = ""
        Me.cbTuyen_VC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTuyen_VC.Location = New System.Drawing.Point(200, 96)
        Me.cbTuyen_VC.Name = "cbTuyen_VC"
        Me.cbTuyen_VC.Size = New System.Drawing.Size(112, 24)
        Me.cbTuyen_VC.TabIndex = 23
        Me.cbTuyen_VC.ValueMember = ""
        Me.cbTuyen_VC.Visible = False
        '
        'btnXuat_Excel
        '
        Me.btnXuat_Excel.Enabled = False
        Me.btnXuat_Excel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXuat_Excel.Location = New System.Drawing.Point(632, 48)
        Me.btnXuat_Excel.Name = "btnXuat_Excel"
        Me.btnXuat_Excel.Size = New System.Drawing.Size(88, 32)
        Me.btnXuat_Excel.TabIndex = 9
        Me.btnXuat_Excel.Text = "Xuất Excel"
        '
        'calDenNgay
        '
        Me.calDenNgay.DateTime = New Date(2008, 9, 9, 0, 0, 0, 0)
        Me.calDenNgay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.calDenNgay.Location = New System.Drawing.Point(256, 8)
        Me.calDenNgay.Name = "calDenNgay"
        Me.calDenNgay.Size = New System.Drawing.Size(96, 21)
        Me.calDenNgay.TabIndex = 1
        Me.calDenNgay.Value = New Date(2008, 9, 9, 0, 0, 0, 0)
        '
        'calTuNgay
        '
        Me.calTuNgay.DateTime = New Date(2008, 9, 9, 0, 0, 0, 0)
        Me.calTuNgay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.calTuNgay.Location = New System.Drawing.Point(88, 8)
        Me.calTuNgay.Name = "calTuNgay"
        Me.calTuNgay.Size = New System.Drawing.Size(88, 21)
        Me.calTuNgay.TabIndex = 0
        Me.calTuNgay.Value = New Date(2008, 9, 9, 0, 0, 0, 0)
        '
        'UltraLabel7
        '
        Appearance2.TextHAlign = Infragistics.Win.HAlign.Right
        Appearance2.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.UltraLabel7.Appearance = Appearance2
        Me.UltraLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(360, 40)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(88, 16)
        Me.UltraLabel7.TabIndex = 17
        Me.UltraLabel7.Text = "Đợt giao nhận"
        '
        'cbDot_Giao_Nhan
        '
        Me.cbDot_Giao_Nhan.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbDot_Giao_Nhan.DisplayMember = ""
        Me.cbDot_Giao_Nhan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDot_Giao_Nhan.Location = New System.Drawing.Point(456, 32)
        Me.cbDot_Giao_Nhan.Name = "cbDot_Giao_Nhan"
        Me.cbDot_Giao_Nhan.Size = New System.Drawing.Size(168, 24)
        Me.cbDot_Giao_Nhan.TabIndex = 5
        Me.cbDot_Giao_Nhan.ValueMember = ""
        '
        'UltraLabel6
        '
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance3.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.UltraLabel6.Appearance = Appearance3
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(8, 40)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(56, 16)
        Me.UltraLabel6.TabIndex = 15
        Me.UltraLabel6.Text = "Báo cáo"
        '
        'cbBao_Cao
        '
        Me.cbBao_Cao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbBao_Cao.DisplayMember = ""
        Me.cbBao_Cao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBao_Cao.Location = New System.Drawing.Point(88, 32)
        Me.cbBao_Cao.Name = "cbBao_Cao"
        Me.cbBao_Cao.Size = New System.Drawing.Size(264, 24)
        Me.cbBao_Cao.TabIndex = 2
        Me.cbBao_Cao.ValueMember = ""
        '
        'UltraLabel5
        '
        Appearance4.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.UltraLabel5.Appearance = Appearance4
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(184, 8)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel5.TabIndex = 13
        Me.UltraLabel5.Text = "Đến ngày"
        '
        'UltraLabel3
        '
        Appearance5.TextHAlign = Infragistics.Win.HAlign.Right
        Appearance5.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.UltraLabel3.Appearance = Appearance5
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(352, 72)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel3.TabIndex = 12
        Me.UltraLabel3.Text = "PT vận chuyển"
        '
        'UltraLabel4
        '
        Appearance6.TextHAlign = Infragistics.Win.HAlign.Right
        Appearance6.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.UltraLabel4.Appearance = Appearance6
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(368, 8)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(80, 16)
        Me.UltraLabel4.TabIndex = 11
        Me.UltraLabel4.Text = "Ca sản xuất"
        '
        'UltraLabel2
        '
        Appearance7.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.UltraLabel2.Appearance = Appearance7
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(8, 8)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(56, 16)
        Me.UltraLabel2.TabIndex = 10
        Me.UltraLabel2.Text = "Từ ngày"
        '
        'UltraLabel1
        '
        Appearance8.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance8.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.UltraLabel1.Appearance = Appearance8
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(8, 72)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(80, 16)
        Me.UltraLabel1.TabIndex = 9
        Me.UltraLabel1.Text = "Bưu cục KT"
        '
        'btnIn_Bao_Cao
        '
        Me.btnIn_Bao_Cao.Enabled = False
        Me.btnIn_Bao_Cao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIn_Bao_Cao.Location = New System.Drawing.Point(720, 48)
        Me.btnIn_Bao_Cao.Name = "btnIn_Bao_Cao"
        Me.btnIn_Bao_Cao.Size = New System.Drawing.Size(96, 32)
        Me.btnIn_Bao_Cao.TabIndex = 10
        Me.btnIn_Bao_Cao.Text = "In báo cáo"
        '
        'btnThoat
        '
        Me.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Location = New System.Drawing.Point(816, 8)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(56, 72)
        Me.btnThoat.TabIndex = 11
        Me.btnThoat.Text = "Thoát  (ESC)"
        '
        'panel_main
        '
        Me.panel_main.Controls.Add(Me.dgBaoCao_BC37_TH)
        Me.panel_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_main.Location = New System.Drawing.Point(0, 96)
        Me.panel_main.Name = "panel_main"
        Me.panel_main.Size = New System.Drawing.Size(884, 466)
        Me.panel_main.TabIndex = 10
        '
        'dgBaoCao_BC37_TH
        '
        Me.dgBaoCao_BC37_TH.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance9.BackColor = System.Drawing.Color.White
        Me.dgBaoCao_BC37_TH.DisplayLayout.Appearance = Appearance9
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Me.dgBaoCao_BC37_TH.DisplayLayout.Override.CardAreaAppearance = Appearance10
        Me.dgBaoCao_BC37_TH.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Appearance11.BackColor = System.Drawing.Color.FromArgb(CType(175, Byte), CType(192, Byte), CType(130, Byte))
        Appearance11.BackColor2 = System.Drawing.Color.FromArgb(CType(99, Byte), CType(122, Byte), CType(68, Byte))
        Appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance11.FontData.BoldAsString = "True"
        Appearance11.FontData.Name = "Arial"
        Appearance11.FontData.SizeInPoints = 10.0!
        Appearance11.ForeColor = System.Drawing.Color.White
        Appearance11.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgBaoCao_BC37_TH.DisplayLayout.Override.HeaderAppearance = Appearance11
        Appearance12.BackColor = System.Drawing.Color.FromArgb(CType(175, Byte), CType(192, Byte), CType(130, Byte))
        Appearance12.BackColor2 = System.Drawing.Color.FromArgb(CType(99, Byte), CType(122, Byte), CType(68, Byte))
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgBaoCao_BC37_TH.DisplayLayout.Override.RowSelectorAppearance = Appearance12
        Appearance13.BackColor = System.Drawing.Color.FromArgb(CType(251, Byte), CType(230, Byte), CType(148, Byte))
        Appearance13.BackColor2 = System.Drawing.Color.FromArgb(CType(238, Byte), CType(149, Byte), CType(21, Byte))
        Appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgBaoCao_BC37_TH.DisplayLayout.Override.SelectedRowAppearance = Appearance13
        Me.dgBaoCao_BC37_TH.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.dgBaoCao_BC37_TH.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgBaoCao_BC37_TH.Location = New System.Drawing.Point(0, 0)
        Me.dgBaoCao_BC37_TH.Name = "dgBaoCao_BC37_TH"
        Me.dgBaoCao_BC37_TH.Size = New System.Drawing.Size(884, 466)
        Me.dgBaoCao_BC37_TH.TabIndex = 0
        '
        'frmBaoCaoBC37
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnThoat
        Me.ClientSize = New System.Drawing.Size(884, 562)
        Me.Controls.Add(Me.panel_main)
        Me.Controls.Add(Me.panel_Top)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmBaoCaoBC37"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Báo cáo BC37"
        CType(Me.cbMa_Buu_Cuc_KT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCa_San_Xuat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbPhuong_Tien_VC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_Top.ResumeLayout(False)
        CType(Me.cbTuyen_VC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.calDenNgay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.calTuNgay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDot_Giao_Nhan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbBao_Cao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_main.ResumeLayout(False)
        CType(Me.dgBaoCao_BC37_TH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region "Khai bao bien trong Form"
    Dim myCa_San_Xuat As New Ma_Ca(GConnectionString)
    Dim myMa_Bc_Khai_Thac As New Ma_Bc_Khai_Thac(GConnectionString)
    Dim myPhuong_Tien_VC As New QLTGND_TRANSPORT_TYPE(GConnectionString)
    'Dim myDataBC As New DataTable("BaoCao_BC37")
    Dim myDataBC37_TH As New DataTable("BaoCao_BC37TH")
    Dim myTuyen_VC As New QLTGND_TUYEN_VC(GConnectionString)
    Dim meStatusBC As Boolean = True
#End Region
#Region "Load dữ liệu combo"
    Private Sub Load_Danh_Muc()
        Try
            'Load danh muc tuyen van chuyen
            Dim myTuyenVC As New dataTable
            Dim sName As String() = {"Ten_Tuyen"}
            Dim sCaption As String() = {"Tuyến vận chuyển"}
            myTuyenVC = myTuyen_VC.QLTGND_TUYEN_VC_Danh_Sach().Tables(0)
            ValidCombo(cbTuyen_VC, myTuyenVC, sName, sCaption, "Ten_Tuyen", "Id_Tuyen")
            cbTuyen_VC.DisplayLayout.Bands(0).Columns("Ten_Tuyen").Width = cbTuyen_VC.Width
            'Id_Tuyen    Id_Tuyen_Char        Ten_Tuyen Id_Dot      Ma_Tinh_Goc_Char Ma_Tinh_Dich_Char Ma_Tinh_Goc Ma_Tinh_Dich Id_Huong
            'Load danh muc buu cuc khai thac
            Dim myBCKT_source As New dataTable
            myBCKT_source = myMa_Bc_Khai_Thac.Danh_Sach().Tables(0)
            Dim drBCKT_row As DataRow
            drBCKT_row = myBCKT_source.NewRow()
            drBCKT_row("Ten_Bc_Khai_Thac") = "--Tất cả--"
            drBCKT_row("Ma_Bc_Khai_Thac") = "000000"
            'drBCKT_row("IsPO") = "0"
            myBCKT_source.Rows.Add(drBCKT_row)
            Dim sNameBCKT As String() = {"Ma_Bc_Khai_Thac", "Ten_Bc_Khai_Thac"}
            Dim sCaptionBCKT As String() = {"Mã BC", "Tên BC"}
            ValidCombo(cbMa_Buu_Cuc_KT, myBCKT_source, sNameBCKT, sCaptionBCKT, "Ten_Bc_Khai_Thac", "Ma_Bc_Khai_Thac")
            'cbMa_Buu_Cuc_KT.DataSource = myBCKT_source
            'cbMa_Buu_Cuc_KT.DisplayLayout.Bands(0).Columns("IsPO").Hidden = True
            'cbMa_Buu_Cuc_KT.DisplayLayout.Bands(0).Columns("Ma_Bc_Khai_Thac").Header.Caption = "Mã BC"
            'cbMa_Buu_Cuc_KT.DisplayLayout.Bands(0).Columns("Ten_Bc_Khai_Thac").Header.Caption = "Tên BC"
            'cbMa_Buu_Cuc_KT.ValueMember = "Ma_Bc_Khai_Thac"
            'cbMa_Buu_Cuc_KT.DisplayMember = "Ten_Bc_Khai_Thac"
            'cbMa_Buu_Cuc_KT.Value = GBuu_Cuc_Khai_Thac
            cbMa_Buu_Cuc_KT.DisplayLayout.Bands(0).Columns("Ma_Bc_Khai_Thac").Width = 80
            cbMa_Buu_Cuc_KT.DisplayLayout.Bands(0).Columns("Ten_Bc_Khai_Thac").Width = cbMa_Buu_Cuc_KT.Width - 80
            'Load danh muc ca san xuat
            Load_Ca_San_Xuat(GBuu_Cuc_Khai_Thac)
            'Load danh muc phương tiện vận chuyển
            Dim myPTVC As New dataTable
            myPTVC = myPhuong_Tien_VC.QLTGND_TRANSPORT_TYPE_Danh_Sach().Tables(0)
            Dim drPTVC As DataRow
            drPTVC = myPTVC.NewRow()
            drPTVC("Name") = "--Tất cả--"
            drPTVC("ID") = "0"
            drPTVC("IS_LOCK") = "0"
            myPTVC.Rows.Add(drPTVC)
            Dim sNamePTVC As String() = {"NAME"}
            Dim sCaptionPTVC As String() = {"Tên PT"}
            ValidCombo(cbPhuong_Tien_VC, myPTVC, sNamePTVC, sCaptionPTVC, "NAME", "ID")

            'cbPhuong_Tien_VC.DataSource = myPTVC
            'cbPhuong_Tien_VC.DisplayMember = "Name"
            'cbPhuong_Tien_VC.ValueMember = "ID"
            'cbPhuong_Tien_VC.DisplayLayout.Bands(0).Columns("Name").Header.Caption = "Tên PT"
            'cbPhuong_Tien_VC.DisplayLayout.Bands(0).Columns("ID").Hidden = True
            'cbPhuong_Tien_VC.DisplayLayout.Bands(0).Columns("IS_LOCK").Hidden = True
            cbPhuong_Tien_VC.DisplayLayout.Bands(0).Columns("NAME").Width = cbPhuong_Tien_VC.Width
            'Load đợt giao nhận
            Tao_Bang_Dot_Giao()
            'Load bang bao cao
            Dim dataTable As New dataTable("Bao_Cao")
            Dim i As Integer
            Dim colWork As DataColumn = New DataColumn("Ma_BC", GetType(Integer))
            dataTable.Columns.Add(colWork)
            colWork = New DataColumn("Ten_BC", GetType(String))
            dataTable.Columns.Add(colWork)
            'Add list report
            Dim row_BCDi As DataRow = dataTable.NewRow()
            row_BCDi("Ma_BC") = 1
            row_BCDi("Ten_BC") = "THỐNG KÊ BC37 ĐI"
            dataTable.Rows.Add(row_BCDi)
            Dim row_BCDen As DataRow = dataTable.NewRow()
            row_BCDen("Ma_BC") = 2
            row_BCDen("Ten_BC") = "THỐNG KÊ BC37 ĐẾN"
            dataTable.Rows.Add(row_BCDen)
            Dim row_BCDiTH As DataRow = dataTable.NewRow()
            row_BCDiTH("Ma_BC") = 3
            row_BCDiTH("Ten_BC") = "THỐNG KÊ BC37 ĐI TỔNG HỢP"
            dataTable.Rows.Add(row_BCDiTH)
            Dim row_BCDenTH As DataRow = dataTable.NewRow()
            row_BCDenTH("Ma_BC") = 4
            row_BCDenTH("Ten_BC") = "THỐNG KÊ BC37 ĐẾN TỔNG HỢP"
            dataTable.Rows.Add(row_BCDenTH)
            cbBao_Cao.DataSource = dataTable
            cbBao_Cao.DataBind()
            cbBao_Cao.DisplayMember = "Ten_BC"
            cbBao_Cao.ValueMember = "Ma_BC"
            cbBao_Cao.DisplayLayout.Bands(0).Columns("Ma_BC").Hidden = True
            cbBao_Cao.DisplayLayout.Bands(0).Columns("Ten_BC").Header.Caption = "Tên báo cáo"
            cbBao_Cao.DisplayLayout.Bands(0).Columns("Ten_BC").Width = cbBao_Cao.Width
        Catch ex As Exception
            MessageBox.Show(ex.Message & "\nNếu gặp lỗi này bạn hãy thông báo với người quản trị", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region "Tạo bảng Đợt giao"
    Private Sub Tao_Bang_Dot_Giao()
        Dim dataTable As New dataTable("Dot_Giao")
        Dim i As Integer
        Dim colWork As DataColumn = New DataColumn("Ma", GetType(Integer))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Ten", GetType(String))
        dataTable.Columns.Add(colWork)

        Dim row As DataRow = dataTable.NewRow()
        For i = 0 To 20
            row = dataTable.NewRow
            If (i = 0) Then
                row("Ma") = 0
                row("Ten") = "--Tất cả--"
            Else
                row("Ma") = i
                row("Ten") = "Đợt " + i.ToString()
            End If
            dataTable.Rows.Add(row)
        Next

        cbDot_Giao_Nhan.DataSource = dataTable
        cbDot_Giao_Nhan.DataBind()
        cbDot_Giao_Nhan.DisplayMember = "Ten"
        cbDot_Giao_Nhan.ValueMember = "Ma"
        cbDot_Giao_Nhan.DisplayLayout.Bands(0).Columns("Ma").Hidden = True
        cbDot_Giao_Nhan.DisplayLayout.Bands(0).Columns("Ten").Header.Caption = "Tên đợt"
        cbDot_Giao_Nhan.DisplayLayout.Bands(0).Columns("Ten").Width = cbDot_Giao_Nhan.Width
    End Sub
#End Region

    Private Sub Load_Ca_San_Xuat(ByVal intMa_BC_KT As Integer)
        Dim myCaSanXuat As New DataTable
        Dim drcasx As DataRow

        myCaSanXuat = myCa_San_Xuat.Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac(intMa_BC_KT).Tables(0)
        drcasx = myCaSanXuat.NewRow()
        drcasx("Ca_Khai_Thac") = "0"
        drcasx("Ma_Bc_Khai_Thac") = intMa_BC_KT
        drcasx("Thu_Tu") = "0"
        drcasx("Ca") = "Tất cả"
        myCaSanXuat.Rows.Add(drcasx)
        cbCa_San_Xuat.DataSource = myCaSanXuat
        cbCa_San_Xuat.DisplayLayout.Bands(0).Columns("Ca_Khai_Thac").Hidden = True
        cbCa_San_Xuat.DisplayLayout.Bands(0).Columns("Ma_Bc_Khai_Thac").Hidden = True
        cbCa_San_Xuat.DisplayLayout.Bands(0).Columns("Thu_Tu").Hidden = True
        cbCa_San_Xuat.DisplayLayout.Bands(0).Columns("Ca").Header.Caption = "Tên ca SX"
        cbCa_San_Xuat.DisplayMember = "Ca"
        cbCa_San_Xuat.ValueMember = "Ca_Khai_Thac"
        cbCa_San_Xuat.DisplayLayout.Bands(0).Columns("Ca").Width = cbCa_San_Xuat.Width
    End Sub
#End Region
    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub btnXem_Du_Lieu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXem_Du_Lieu.Click
        'kiểm tra báo cáo đang lấy
        'kiểm tra báo cáo đang lấy
        If (meStatusBC = True) Then
            If Not (cbBao_Cao.Value Is Nothing) Then
                If (cbBao_Cao.Value.ToString() = "1" Or cbBao_Cao.Value.ToString() = "2") Then
                    Dim UltraGridBand_cus As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
                    Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tuyen_Duong_Thu")
                    Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Buu_Cuc_Dong")
                    Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Buu_Cuc_Nhan")
                    Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Dong")
                    Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Dot_Giao_Nhan")
                    Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Hieu_Chuyen_Thu")
                    Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Hieu_Tui")
                    Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong")
                    UltraGridColumn9.Header.Caption = "Đường thư"
                    UltraGridColumn9.Header.VisiblePosition = 0
                    UltraGridColumn10.Header.Caption = "BC gửi"
                    UltraGridColumn10.Header.VisiblePosition = 1
                    UltraGridColumn10.Width = 153
                    UltraGridColumn11.Header.Caption = "BC nhận"
                    UltraGridColumn11.Header.VisiblePosition = 2
                    UltraGridColumn11.Width = 120
                    UltraGridColumn12.Header.Caption = "Ngày"
                    UltraGridColumn12.Header.VisiblePosition = 3
                    UltraGridColumn13.Header.Caption = "Đợt giao"
                    UltraGridColumn13.Header.VisiblePosition = 4
                    UltraGridColumn14.Header.Caption = "SCT"
                    UltraGridColumn14.Header.VisiblePosition = 5
                    UltraGridColumn15.Header.Caption = "Túi số"
                    UltraGridColumn15.Header.VisiblePosition = 6
                    UltraGridColumn16.Header.Caption = "Khối lượng"
                    UltraGridColumn16.Header.VisiblePosition = 7
                    UltraGridBand_cus.Columns.AddRange(New Object() {UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16})
                    'Infragistics.Win.UltraWinGrid.UltraGridOverride.WrapHeaderText

                    dgBaoCao_BC37_TH.DisplayLayout.BandsSerializer.Add(UltraGridBand_cus)
                ElseIf (cbBao_Cao.Value.ToString() = "3" Or cbBao_Cao.Value.ToString() = "4") Then
                    Dim UltraGridBand_cus As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
                    Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tuyen_Duong_Thu")
                    Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Buu_Cuc_Dong")
                    Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Buu_Cuc_Nhan")
                    Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Dong")
                    Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Dot_Giao_Nhan")
                    Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Hieu_Chuyen_Thu")
                    Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Luong_Tui")
                    Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong")
                    Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("XemChiTiet", 0)
                    Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chuyen_Thu")
                    Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_BP")
                    Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BC37_ID")
                    UltraGridColumn9.Header.Caption = "Đường thư"
                    UltraGridColumn9.Header.VisiblePosition = 0
                    UltraGridColumn10.Header.Caption = "BC gửi"
                    UltraGridColumn10.Header.VisiblePosition = 1
                    UltraGridColumn10.Width = 153
                    UltraGridColumn11.Header.Caption = "BC nhận"
                    UltraGridColumn11.Header.VisiblePosition = 2
                    UltraGridColumn11.Width = 120
                    UltraGridColumn12.Header.Caption = "Ngày"
                    UltraGridColumn12.Header.VisiblePosition = 3
                    UltraGridColumn13.Header.Caption = "Đợt giao"
                    UltraGridColumn13.Header.VisiblePosition = 4
                    UltraGridColumn14.Header.Caption = "SCT"
                    UltraGridColumn14.Header.VisiblePosition = 5
                    UltraGridColumn15.Header.Caption = "Số lượng túi"
                    UltraGridColumn15.Header.VisiblePosition = 6
                    UltraGridColumn16.Header.Caption = "Khối lượng"
                    UltraGridColumn16.Header.VisiblePosition = 7
                    UltraGridColumn17.Header.Caption = "Xem"
                    UltraGridColumn17.Header.VisiblePosition = 8
                    UltraGridColumn17.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
                    UltraGridColumn18.Header.VisiblePosition = 9
                    UltraGridColumn18.Hidden = True
                    UltraGridColumn19.Header.VisiblePosition = 10
                    UltraGridColumn19.Hidden = True
                    UltraGridColumn20.Header.VisiblePosition = 11
                    UltraGridColumn20.Hidden = True
                    UltraGridBand_cus.Columns.AddRange(New Object() {UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20})
                    dgBaoCao_BC37_TH.DisplayLayout.BandsSerializer.Add(UltraGridBand_cus)
                End If
                
                'gọi Sub lấy dữ liệu báo cáo tại đây'
                LayDuLieuBaoCao()
                'Hiển thị dữ liệu ra grid bao cao 

                'Ẩn hiện control khi thay đổi nguồn dữ liệu
                If Not (myDataBC37_TH Is Nothing) Then
                    If (myDataBC37_TH.Rows.Count > 0) Then
                        dgBaoCao_BC37_TH.DataSource = myDataBC37_TH
                        'ẩn control
                        changeStatusButton(True)
                        changeStatusControl(False)
                    Else

                        'reset column datasource myDataBC37_TH
                        changeStatusButton(False)
                        MessageBox.Show("Không có dữ liệu tương ứng với điều kiện báo cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        myDataBC37_TH.Clear()
                        myDataBC37_TH.Columns.Clear()
                    End If
                End If
            Else
                MessageBox.Show("Bạn phải chọn báo cáo cần xem", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cbBao_Cao.Focus()
            End If
        Else
            changeStatusButton(False)
            changeStatusControl(True)

        End If
    End Sub
    Private Sub changeStatusButton(ByVal bstatus As Boolean)
        btnIn_Bao_Cao.Enabled = bstatus
        btnXem_Bao_Cao.Enabled = bstatus
        btnXuat_Excel.Enabled = bstatus
    End Sub
    Private Sub changeStatusControl(ByVal mestatus As Boolean)
        meStatusBC = mestatus
        cbPhuong_Tien_VC.Enabled = mestatus
        cbCa_San_Xuat.Enabled = mestatus
        cbDot_Giao_Nhan.Enabled = mestatus
        cbMa_Buu_Cuc_KT.Enabled = mestatus
        calDenNgay.Enabled = mestatus
        calTuNgay.Enabled = mestatus
        cbBao_Cao.Enabled = mestatus
        If (mestatus) Then
            If Not (myDataBC37_TH Is Nothing) And myDataBC37_TH.Rows.Count() > 0 Then
                'reset column datasource myDataBC37_TH
                myDataBC37_TH.Clear()
                myDataBC37_TH.Columns.Clear()
                dgBaoCao_BC37_TH.DataSource = Nothing
            End If
            btnXem_Du_Lieu.Text = "Xem dữ liệu"

        Else : btnXem_Du_Lieu.Text = "Tiếp tục"
        End If
    End Sub
    Function ThayDoiDieuKien(ByVal strBC As String) As String
        Dim strWhere As String
        Dim TuNgay As Date
        Dim DenNgay As Date
        TuNgay = CDate(calTuNgay.Value)
        DenNgay = CDate(calDenNgay.Value)
        strWhere = " where Ngay_Giao >= " & Ham_Dung_Chung.ConvertDateToInt(TuNgay).ToString() & " and Ngay_Giao <= " & Ham_Dung_Chung.ConvertDateToInt(DenNgay).ToString()
        If Not (cbMa_Buu_Cuc_KT.Value Is Nothing) And CStr(cbMa_Buu_Cuc_KT.Value) <> "0" Then
            If (strBC = "1" Or strBC = "3") Then
                strWhere &= " and bc37.Ma_Bc_Khai_Thac = " & CStr(cbMa_Buu_Cuc_KT.Value)
            ElseIf (strBC = "2" Or strBC = "4") Then
                strWhere &= " and bc37.Ma_Bc = " & CStr(cbMa_Buu_Cuc_KT.Value)
            End If
        End If
        'them bao cao khac
        If (strBC = "1" Or strBC = "3" Or strBC = "2" Or strBC = "4") Then
            If Not (cbCa_San_Xuat.Value Is Nothing) And CStr(cbCa_San_Xuat.Value) <> "0" Then
                strWhere &= " and Ca_Khai_Thac = " & CStr(cbCa_San_Xuat.Value)
            End If
            If Not (cbDot_Giao_Nhan.Value Is Nothing) And CStr(cbDot_Giao_Nhan.Value) <> "0" Then
                strWhere &= " and bc37.Dot_Giao = " & CStr(cbDot_Giao_Nhan.Value)
            End If
            If Not (cbPhuong_Tien_VC.Value Is Nothing) And CStr(cbPhuong_Tien_VC.Value) <> "0" Then
                strWhere &= " and bc37.TRANSPORT_TYPE_ID = " & CStr(cbPhuong_Tien_VC.Value)
            End If
        End If
        Return strWhere
    End Function
    Private Sub LayDuLieuBaoCao()
        Dim selectBC As String
        If (cbBao_Cao.Value.ToString() = "1") Then
            selectBC = "select Ten_Tuyen as Tuyen_Duong_Thu,bc37.Ma_Bc_Khai_Thac as Buu_Cuc_Dong,bc37.Ma_Bc as Buu_Cuc_Nhan,convert(varchar(15),dbo.ConvertIntToDate(bc37.Ngay_Lap),103) as Ngay_Dong, " & _
            "Dot_Giao as Ma_Dot_Giao_Nhan,bc37.So_Chuyen_Thu as So_Hieu_Chuyen_Thu, Tui_So as So_Hieu_Tui,isnull(Khoi_Luong_Vo_Tui,0) + isnull(Khoi_Luong_BP,0) as Khoi_Luong " & _
            "from QLTGND_BC37_DI bc37 inner join QLTGND_POSTBAG_DI tui on " & _
            "bc37.BC37_ID = tui.Id_BC37 inner join QLTGND_TUYEN_VC tuyen on bc37.Mail_Route_ID=tuyen.Id_Tuyen " & _
            "inner join Ca_San_Xuat ca on bc37.Id_Ca = Ca.Id_Ca " & ThayDoiDieuKien(cbBao_Cao.Value.ToString())

        ElseIf (cbBao_Cao.Value.ToString() = "2") Then
            selectBC = "select Ten_Tuyen as Tuyen_Duong_Thu,bc37.Ma_Bc as Buu_Cuc_Dong,bc37.Ma_Bc_Khai_Thac as Buu_Cuc_Nhan,convert(varchar(15),dbo.ConvertIntToDate(bc37.Ngay_Giao),103) as Ngay_Dong, " & _
            "Dot_Giao as Ma_Dot_Giao_Nhan,bc37.So_Chuyen_Thu as So_Hieu_Chuyen_Thu, Tui_So as So_Hieu_Tui,isnull(Khoi_Luong_Vo_Tui,0) + isnull(Khoi_Luong_BP,0) as Khoi_Luong " & _
            "from QLTGND_BC37_DEN bc37 inner join QLTGND_POSTBAG_DEN tui on " & _
            "bc37.BC37_ID = tui.Id_BC37 inner join QLTGND_TUYEN_VC tuyen on bc37.Mail_Route_ID=tuyen.Id_Tuyen " & _
            "inner join Ca_San_Xuat ca on bc37.Id_Ca = Ca.Id_Ca " & ThayDoiDieuKien(cbBao_Cao.Value.ToString())
        ElseIf (cbBao_Cao.Value.ToString() = "3") Then
            selectBC = "select '' as Id_Chuyen_Thu,Ten_Tuyen as Tuyen_Duong_Thu,bc37.Ma_Bc_Khai_Thac as Buu_Cuc_Dong,bc37.Ma_Bc as Buu_Cuc_Nhan,convert(varchar(15),dbo.ConvertIntToDate(Ngay_Giao),103) as Ngay_Dong, " & _
            " Dot_Giao as Ma_Dot_Giao_Nhan,bc37.So_Chuyen_Thu as So_Hieu_Chuyen_Thu,count(tui.Id_Tui_Thu) as So_Luong_Tui,sum(isnull(Khoi_Luong_Vo_Tui,0) + isnull(Khoi_Luong_BP,0)) as Khoi_Luong, bc37.Tong_So_BP,bc37.BC37_ID " & _
            " from QLTGND_BC37_DI bc37 inner join QLTGND_POSTBAG_DI tui on " & _
            " bc37.BC37_ID = tui.Id_BC37 inner join QLTGND_TUYEN_VC tuyen on bc37.Mail_Route_ID=tuyen.Id_Tuyen " & _
            "inner join Ca_San_Xuat ca on bc37.Id_Ca = Ca.Id_Ca " & ThayDoiDieuKien(cbBao_Cao.Value.ToString()) & " group by Ten_Tuyen,bc37.Ma_Bc_Khai_Thac,bc37.Ma_Bc,Ngay_Giao,Dot_Giao,bc37.So_Chuyen_Thu, bc37.Tong_So_BP,bc37.BC37_ID "
        ElseIf (cbBao_Cao.Value.ToString() = "4") Then
            selectBC = "select '' as Id_Chuyen_Thu,Ten_Tuyen as Tuyen_Duong_Thu,bc37.Ma_Bc as Buu_Cuc_Dong,BC37.Ma_Bc_Khai_Thac as Buu_Cuc_Nhan,convert(varchar(15),dbo.ConvertIntToDate(Ngay_Giao),103) as Ngay_Dong, " & _
            " Dot_Giao as Ma_Dot_Giao_Nhan,bc37.So_Chuyen_Thu as So_Hieu_Chuyen_Thu,count(tui.Id_Tui_Thu) as So_Luong_Tui,sum(isnull(Khoi_Luong_Vo_Tui,0) + isnull(Khoi_Luong_BP,0)) as Khoi_Luong, bc37.Tong_So_BP,bc37.BC37_ID " & _
            " from QLTGND_BC37_DEN bc37 inner join QLTGND_POSTBAG_DEN tui on " & _
            " bc37.BC37_ID = tui.Id_BC37 inner join QLTGND_TUYEN_VC tuyen on bc37.Mail_Route_ID=tuyen.Id_Tuyen " & _
            "inner join Ca_San_Xuat ca on bc37.Id_Ca = Ca.Id_Ca " & ThayDoiDieuKien(cbBao_Cao.Value.ToString()) & " group by Ten_Tuyen,bc37.Ma_Bc_Khai_Thac,bc37.Ma_Bc,Ngay_Giao,Dot_Giao,bc37.So_Chuyen_Thu, bc37.Tong_So_BP,bc37.BC37_ID "
        End If
        Try

            ' Tạo đối tượng connection và command
            Dim myConnection As SqlConnection = New SqlConnection(GConnectionString)
            Dim myCommand As SqlCommand = New SqlCommand(selectBC, myConnection)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            ' Sử dụng Store Procedure
            myCommand.CommandType = CommandType.Text
            ' Thêm các Parameters vào thủ tục
            myConnection.Open()
            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myDataBC37_TH)
            myConnection.Close()
            myConnection.Dispose()
        Catch ex As Exception
            Console.Write(ex.ToString)
        End Try

    End Sub
    Private Sub btnXem_Bao_Cao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXem_Bao_Cao.Click

        If ((cbBao_Cao.Value.ToString() = "1") Or (cbBao_Cao.Value.ToString() = "2") Or (cbBao_Cao.Value.ToString() = "3") Or (cbBao_Cao.Value.ToString() = "4")) Then
            Dim paramName() As String = {"pBuu_Cuc_Khai_Thac", "pPTVC", "pDot_Giao_Nhan", "pCa_San_Xuat", "pTu_Ngay", "pDen_Ngay", "TIEU_DE_BAO_CAO"}
            Dim paramValue() As Object = {cbMa_Buu_Cuc_KT.Value, cbPhuong_Tien_VC.Text, cbDot_Giao_Nhan.Text, cbCa_San_Xuat.Text, calTuNgay.Value, calDenNgay.Value, cbBao_Cao.Text}
            Ban_Ke_BC37_Tong_Hop(myDataBC37_TH, True, 1, paramName, paramValue)

        End If


    End Sub

    Private Sub btnIn_Bao_Cao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIn_Bao_Cao.Click

        If ((cbBao_Cao.Value.ToString() = "1") Or (cbBao_Cao.Value.ToString() = "2") Or (cbBao_Cao.Value.ToString() = "3") Or (cbBao_Cao.Value.ToString() = "4")) Then
            Dim paramName() As String = {"pBuu_Cuc_Khai_Thac", "pPTVC", "pDot_Giao_Nhan", "pCa_San_Xuat", "pTu_Ngay", "pDen_Ngay", "TIEU_DE_BAO_CAO"}
            Dim paramValue() As Object = {cbMa_Buu_Cuc_KT.Value, cbPhuong_Tien_VC.Text, cbDot_Giao_Nhan.Text, cbCa_San_Xuat.Text, calTuNgay.Value, calDenNgay.Value, cbBao_Cao.Text}
            Ban_Ke_BC37_Tong_Hop(myDataBC37_TH, False, 1, paramName, paramValue)
        End If

    End Sub

    Private Sub frmBaoCaoBC37_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Danh_Muc()

        calTuNgay.Value = Date.Now
        calDenNgay.Value = Date.Now
        'tự động complet tham số hệ thống
        If (cbCa_San_Xuat.Value Is Nothing) Then
            cbCa_San_Xuat.Value = 0
        End If
        If (cbDot_Giao_Nhan.Value Is Nothing) Then
            cbDot_Giao_Nhan.Value = 0
        End If
        If (cbPhuong_Tien_VC.Value Is Nothing) Then
            cbPhuong_Tien_VC.Value = 0
        End If
        cbBao_Cao.Focus()
    End Sub

    Private Sub cbMa_Buu_Cuc_KT_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMa_Buu_Cuc_KT.Validated

        If (cbMa_Buu_Cuc_KT.Value Is Nothing) Then
            Return
        End If

        Dim intMa_BC_KT As Integer

        intMa_BC_KT = Convert.ToInt32(cbMa_Buu_Cuc_KT.Value)
        Load_Ca_San_Xuat(intMa_BC_KT)

    End Sub

#Region "------------Thong_Ke_BC37_DenDi_ChiTiet------------"
    Public Sub Ban_Ke_BC37_Tong_Hop(ByVal myTable As DataTable, ByVal Preview As Boolean, ByVal So_Ban As Integer, ByVal paramName() As String, ByVal paramValue() As Object)

        Dim FrmView As New FrmViewReports
        Dim rptBC37DenDiCT As New rptThongKeBC37DenDi_QLTG
        Dim rptBC37DenDiTH As New rptThongKeBC37DenDi_TH_QLTG
        Dim mStatus As Integer
        'Gán DataSource cho report        

        If (FrmView.setParam(paramName, paramValue)) Then
            If ((cbBao_Cao.Value.ToString() = "1") Or (cbBao_Cao.Value.ToString() = "2")) Then
                FrmView.CrystalReportViewer1.ReportSource = rptBC37DenDiCT
                rptBC37DenDiCT.SetDataSource(myTable)
            ElseIf ((cbBao_Cao.Value.ToString() = "3") Or (cbBao_Cao.Value.ToString() = "4")) Then
                FrmView.CrystalReportViewer1.ReportSource = rptBC37DenDiTH
                rptBC37DenDiTH.SetDataSource(myTable)
            End If
        End If

        'Cursor.Current = Cursors.Default
        If Preview = True Then
            'Xem trên màn hình
            FrmView.ShowDialog()
        Else
            'Đưa ra máy in
            rptBC37DenDiCT.PrintToPrinter(So_Ban, True, 0, 0)
        End If
    End Sub
#End Region
    Private Sub btnXuat_Excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXuat_Excel.Click
        Dim tenfile As String
        'dim wrb as new WorkBook
        tenfile = Application.StartupPath() + "\\reportTemp\\ReportBC37" & DateTime.Now.ToString("yyyy.MM.dd.hh.mm.ss") & ".xls"
        DataSetToExcel(myDataBC37_TH, tenfile, cbBao_Cao.Text)
        'gridExcExp.Export(dgBaoCao_BC37_TH, tenfile)
        Process.Start(tenfile)
        
    End Sub

    Sub DataSetToExcel(ByVal dsExport As DataTable, ByVal path As String, ByVal tableName As String)
        If (path = String.Empty) Then
            Return
        End If
        Dim SWriter As New StreamWriter(path)
        Dim str As String
        Dim colspan As Integer = 0
        For i As Integer = 0 To dgBaoCao_BC37_TH.DisplayLayout.Bands(0).Columns.Count - 1
            If Not dgBaoCao_BC37_TH.DisplayLayout.Bands(0).Columns(i).Hidden And dgBaoCao_BC37_TH.DisplayLayout.Bands(0).Columns(i).IsBound Then
                colspan += 1
            End If
        Next
        'Ghi tiêu đề báo cáo
        str &= "<Table ><TR><TD align='center' style='font-size:18px' colspan=" & Convert.ToString(colspan) & ">" & tableName & "</TD></tr>"
        'Ghi các tham số

        str &= " <TR> <TD></TD><TD></TD> <TD align='left' colspan=" & Convert.ToString(colspan - 2) & ">" & "Từ ngày " & CDate(calTuNgay.Value).ToString("dd/MM/yyyy") & " đến ngày " & CDate(calDenNgay.Value).ToString("dd/MM/yyyy") & "</td> </tr>"
        str &= " <TR> <TD></TD><TD></TD> <TD align='left' colspan=" & Convert.ToString(colspan - 2) & ">" & "Ca sản xuất: " & cbCa_San_Xuat.Text & "</td> </tr>"
        str &= " <TR> <TD></TD><TD></TD> <TD align='left' colspan=" & Convert.ToString(colspan - 2) & ">" & "Đợt giao nhận " & cbDot_Giao_Nhan.Text & "</td> </tr>"
        str &= " <TR> <TD></TD><TD></TD> <TD align='left' colspan=" & Convert.ToString(colspan - 2) & ">" & "Phương tiện vận chuyển " & cbPhuong_Tien_VC.Text & "</td> </tr>"
        'ghi tiêu đề cột
        For Each DBCol As Infragistics.Win.UltraWinGrid.UltraGridColumn In dgBaoCao_BC37_TH.DisplayLayout.Bands(0).Columns 'dsExport.Columns
            If Not DBCol.Hidden And DBCol.IsBound Then
                str &= "<TD bgcolor='#D1DAA7'>" & DBCol.Header.Caption & "</TD>"
            End If
        Next
        str &= "</TR>"
        'ghi dữ liệu từng dòng
        For Each DBRow As Infragistics.Win.UltraWinGrid.UltraGridRow In dgBaoCao_BC37_TH.Rows 'dsExport.Rows
            str &= "<TR border=1>"
            For Each DBCol As Infragistics.Win.UltraWinGrid.UltraGridColumn In dgBaoCao_BC37_TH.DisplayLayout.Bands(0).Columns
                If Not DBCol.Hidden And DBCol.IsBound Then
                    str &= "<TD>" & Convert.ToString(dgBaoCao_BC37_TH.Rows(DBRow.Index).Cells(DBCol.Key).Value) & "</TD>"
                End If
            Next
            str &= "</TR>"
        Next
        str &= "</TABLE>"
        SWriter.WriteLine(str)
        SWriter.Flush()
        SWriter.Close()

    End Sub
    Private Sub cbBao_Cao_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbBao_Cao.ValueChanged
        'Dim myUtility As New Ems_MSMQ(GConnectionString)
        'myUtility.Dang_Ky_Truyen("EMS_CUOC_QT", "BRANCH", "PO", GBuu_Cuc_Khai_Thac, "Ma BC_Dich as Integer", Ham_Dung_Chung.ConvertDateToInt(Now), Ham_Dung_Chung.ConvertTimeToInt(Now), "", "Dataset_Source")
        'myUtility.Truyen()
    End Sub

    Private Sub cbMa_Buu_Cuc_KT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbMa_Buu_Cuc_KT.KeyDown
        If (e.KeyCode = Keys.KeyCode.Enter) Then
            cbCa_San_Xuat.Focus()
        End If
    End Sub

    Private Sub calTuNgay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles calTuNgay.KeyDown
        If (e.KeyCode = Keys.KeyCode.Enter) Then
            calDenNgay.Focus()
        End If
    End Sub

    Private Sub calDenNgay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles calDenNgay.KeyDown
        If (e.KeyCode = Keys.KeyCode.Enter) Then
            cbBao_Cao.Focus()
        End If
    End Sub

    Private Sub cbCa_San_Xuat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbCa_San_Xuat.KeyDown
        If (e.KeyCode = Keys.KeyCode.Enter) Then
            cbDot_Giao_Nhan.Focus()
        End If
    End Sub

    Private Sub cbPhuong_Tien_VC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbPhuong_Tien_VC.KeyDown
        If (e.KeyCode = Keys.KeyCode.Enter) Then
            btnXem_Du_Lieu.Focus()
        End If
    End Sub

    Private Sub cbDot_Giao_Nhan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbDot_Giao_Nhan.KeyDown
        If (e.KeyCode = Keys.KeyCode.Enter) Then
            cbPhuong_Tien_VC.Focus()
        End If
    End Sub

    Private Sub cbBao_Cao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbBao_Cao.KeyDown
        If (e.KeyCode = Keys.KeyCode.Enter) Then
            If (cbBao_Cao.Value Is Nothing) Then
                MessageBox.Show("Bạn phải chọn 1 báo cáo muốn xem", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cbBao_Cao.PerformAction(Infragistics.Win.UltraWinGrid.UltraComboAction.Dropdown)
            Else
                cbMa_Buu_Cuc_KT.Focus()
            End If

        End If
    End Sub

    Private Sub calDenNgay_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles calDenNgay.Enter
        calDenNgay.SelectAll()
    End Sub

    Private Sub calTuNgay_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles calTuNgay.Enter
        calTuNgay.SelectAll()
    End Sub

    Private Sub dgBaoCao_BC37_TH_ClickCellButton(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgBaoCao_BC37_TH.ClickCellButton
        Dim introw = e.Cell.Row.Index
        Dim Params As DataRow
        Params = myDataBC37_TH.Rows(introw)
        ' = {myDataBC37_TH.Rows(introw)("Ngay_Dong"), myDataBC37_TH.Rows(introw).Cells("Buu_Cuc_Dong").Value, dgBaoCao_BC37_TH.Rows(introw).Cells("Buu_Cuc_Nhan").Value, dgBaoCao_BC37_TH.Rows(introw).Cells("Ma_Dot_Giao_Nhan").Value, dgBaoCao_BC37_TH.Rows(introw).Cells("So_Hieu_Chuyen_Thu").Value, dgBaoCao_BC37_TH.Rows(introw).Cells("So_Luong_Tui").Value, dgBaoCao_BC37_TH.Rows(introw).Cells("Tong_So_BP").Value, dgBaoCao_BC37_TH.Rows(introw).Cells("Khoi_Luong").Value, dgBaoCao_BC37_TH.Rows(introw).Cells("BC37_ID").Value}
        If cbBao_Cao.Value.ToString() = "3" Then
            Dim ID_BC37_Di As Int32
            Dim frmDi As New FrmXem_ChiTiet_BC37(dgBaoCao_BC37_TH.Rows(introw).Cells("Id_Chuyen_Thu").Value.ToString(), 3, True, Params)
            frmDi.ShowDialog()
        ElseIf cbBao_Cao.Value.ToString() = "4" Then
            Dim ID_BC37_Den As Int32
            Dim frmDen As New FrmXem_ChiTiet_BC37(dgBaoCao_BC37_TH.Rows(introw).Cells("Id_Chuyen_Thu").Value.ToString(), 4, True, Params)
            frmDen.ShowDialog()
        End If
    End Sub

    Private Sub dgBaoCao_BC37_TH_InitializeRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles dgBaoCao_BC37_TH.InitializeRow
        If CStr(cbBao_Cao.Value) = "3" Or CStr(cbBao_Cao.Value) = "4" Then
            'e.Row.Cells("xemchitiet").Value = "Xem..."
        End If
    End Sub
End Class

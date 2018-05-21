Imports Ems_International_Logic
Imports System.Drawing.Printing


Public Class FrmThietLapThamSoHeThong
    Inherits System.Windows.Forms.Form
    Dim myKeys As New ModifyRegistry
    Dim myPrint As New Ems_Printer

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
    Friend WithEvents GrbSoNgayE1Trung As System.Windows.Forms.GroupBox
    Friend WithEvents lblSoNgayE1trung As System.Windows.Forms.Label
    Friend WithEvents txtSongaykiemtrae1trung As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grbThietlapcauhinhin As System.Windows.Forms.GroupBox
    Friend WithEvents grbCauhinhinkim As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtInbc37 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtInE2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtInE4 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtMayTinhE4 As System.Windows.Forms.TextBox
    Friend WithEvents txtMayTinhE2 As System.Windows.Forms.TextBox
    Friend WithEvents txtMayInE4 As System.Windows.Forms.TextBox
    Friend WithEvents txtMayInE2 As System.Windows.Forms.TextBox
    Friend WithEvents txtMayInBC37 As System.Windows.Forms.TextBox
    Friend WithEvents txtMayTinhBC37 As System.Windows.Forms.TextBox
    Friend WithEvents Grp_SuaCuoc As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Sua_Cuoc_Chinh As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_Sua_Cuoc_DV As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_Sua_Cuoc_E1 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents rdbTypePrint2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbTypePrint1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtTrongLuongE1Max As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents chk_In_HQ_Buu_Dien As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents Grp_Thiet_Lap_In_Ban_Ke As System.Windows.Forms.GroupBox
    Friend WithEvents chk_In_Ban_Ke_BV10_Theo_Ngay_Dong As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_In_Bv10_To_Text_Second As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_In_E2_To_Text_Second As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_In_BC37_To_Text_Second As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txt_So_Dong_Trong_Trang_In_Ban_Ke_E2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_So_Dong_Trong_Trang_In_Ban_Ke_BC37 As System.Windows.Forms.TextBox
    Friend WithEvents txt_So_Dong_Trong_Trang_In_Ban_Ke_BV10 As System.Windows.Forms.TextBox
    Friend WithEvents Tab_Control As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Group_Thiet_Lap_In_Ban_Ke_Moi As System.Windows.Forms.GroupBox
    Friend WithEvents rdbInkim As System.Windows.Forms.RadioButton
    Friend WithEvents rdbInlaser As System.Windows.Forms.RadioButton
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GrbCN38 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbTypePrint2_CN38 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbTypePrint1_CN38 As System.Windows.Forms.RadioButton
    Friend WithEvents txtInCN38 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtMayInCN38 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtMayTinhCN38 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents rdbInkimCN38 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbInlaserCN38 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtInCN35 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPrinter As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtServer As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_May_Tinh_In_BV10_QT_Di As System.Windows.Forms.TextBox
    Friend WithEvents txt_May_In_BV10_QT_Di As System.Windows.Forms.TextBox
    Friend WithEvents txt_Thu_Muc_In_BV10_QT_Di As System.Windows.Forms.TextBox
    Friend WithEvents rdb_In_Kim_BV10_QT_Di As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_In_Laser_BV10_QT_Di As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_In_Truc_Tiep_BV10_QT_Di As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_In_Tren_Server_BV10_QT_Di As System.Windows.Forms.RadioButton
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents rdb_In_Kim_BV10_Trong_Nuoc As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_In_Laser_BV10_Trong_Nuoc As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_In_Truc_Tiep_BV10_Trong_Nuoc As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_In_Tren_Server_BV10_Trong_Nuoc As System.Windows.Forms.RadioButton
    Friend WithEvents txt_Thu_Muc_In_BV10_Trong_Nuoc As System.Windows.Forms.TextBox
    Friend WithEvents txt_May_Tinh_In_BV10_Trong_Nuoc As System.Windows.Forms.TextBox
    Friend WithEvents txt_May_In_BV10_Trong_Nuoc As System.Windows.Forms.TextBox
    Friend WithEvents Group_Thiet_Lap_In_Kim_BV10_QT_Di As System.Windows.Forms.GroupBox
    Friend WithEvents Group_Thiet_Lap_In_BV10Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc As System.Windows.Forms.GroupBox
    Friend WithEvents Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc As System.Windows.Forms.GroupBox
    Friend WithEvents Group_Thiet_Lap_In_BV10Group_Thiet_Lap_In_Kim_BV10_QT_Di As System.Windows.Forms.GroupBox
    Friend WithEvents bntinE4 As System.Windows.Forms.Button
    Friend WithEvents txtmayinE4NEW As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents chkInE4_New As System.Windows.Forms.CheckBox
    Friend WithEvents Printer As System.Windows.Forms.PrintDialog
    Friend WithEvents chkE4 As System.Windows.Forms.CheckBox
    Friend WithEvents grbInE4NEW As Infragistics.Win.Misc.UltraGroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.Group_Thiet_Lap_In_Ban_Ke_Moi = New System.Windows.Forms.GroupBox
        Me.chk_In_Bv10_To_Text_Second = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chk_In_E2_To_Text_Second = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.Label24 = New System.Windows.Forms.Label
        Me.txt_So_Dong_Trong_Trang_In_Ban_Ke_E2 = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.chk_In_BC37_To_Text_Second = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.Label26 = New System.Windows.Forms.Label
        Me.txt_So_Dong_Trong_Trang_In_Ban_Ke_BV10 = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txt_So_Dong_Trong_Trang_In_Ban_Ke_BC37 = New System.Windows.Forms.TextBox
        Me.Grp_Thiet_Lap_In_Ban_Ke = New System.Windows.Forms.GroupBox
        Me.chk_In_Ban_Ke_BV10_Theo_Ngay_Dong = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chk_In_HQ_Buu_Dien = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.Grp_SuaCuoc = New System.Windows.Forms.GroupBox
        Me.chk_Sua_Cuoc_E1 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chk_Sua_Cuoc_DV = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chk_Sua_Cuoc_Chinh = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.GrbSoNgayE1Trung = New System.Windows.Forms.GroupBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtTrongLuongE1Max = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSongaykiemtrae1trung = New System.Windows.Forms.TextBox
        Me.lblSoNgayE1trung = New System.Windows.Forms.Label
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.Group_Thiet_Lap_In_BV10Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc = New System.Windows.Forms.GroupBox
        Me.Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc = New System.Windows.Forms.GroupBox
        Me.rdb_In_Truc_Tiep_BV10_Trong_Nuoc = New System.Windows.Forms.RadioButton
        Me.rdb_In_Tren_Server_BV10_Trong_Nuoc = New System.Windows.Forms.RadioButton
        Me.txt_May_Tinh_In_BV10_Trong_Nuoc = New System.Windows.Forms.TextBox
        Me.txt_May_In_BV10_Trong_Nuoc = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.txt_Thu_Muc_In_BV10_Trong_Nuoc = New System.Windows.Forms.TextBox
        Me.rdb_In_Kim_BV10_Trong_Nuoc = New System.Windows.Forms.RadioButton
        Me.rdb_In_Laser_BV10_Trong_Nuoc = New System.Windows.Forms.RadioButton
        Me.grbThietlapcauhinhin = New System.Windows.Forms.GroupBox
        Me.grbCauhinhinkim = New System.Windows.Forms.GroupBox
        Me.grbInE4NEW = New Infragistics.Win.Misc.UltraGroupBox
        Me.chkE4 = New System.Windows.Forms.CheckBox
        Me.bntinE4 = New System.Windows.Forms.Button
        Me.txtmayinE4NEW = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.rdbTypePrint2 = New System.Windows.Forms.RadioButton
        Me.rdbTypePrint1 = New System.Windows.Forms.RadioButton
        Me.txtMayInE4 = New System.Windows.Forms.TextBox
        Me.txtMayInE2 = New System.Windows.Forms.TextBox
        Me.txtMayInBC37 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtMayTinhE4 = New System.Windows.Forms.TextBox
        Me.txtMayTinhE2 = New System.Windows.Forms.TextBox
        Me.txtMayTinhBC37 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtInE4 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtInE2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtInbc37 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.chkInE4_New = New System.Windows.Forms.CheckBox
        Me.rdbInkim = New System.Windows.Forms.RadioButton
        Me.rdbInlaser = New System.Windows.Forms.RadioButton
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.Group_Thiet_Lap_In_BV10Group_Thiet_Lap_In_Kim_BV10_QT_Di = New System.Windows.Forms.GroupBox
        Me.Group_Thiet_Lap_In_Kim_BV10_QT_Di = New System.Windows.Forms.GroupBox
        Me.rdb_In_Truc_Tiep_BV10_QT_Di = New System.Windows.Forms.RadioButton
        Me.rdb_In_Tren_Server_BV10_QT_Di = New System.Windows.Forms.RadioButton
        Me.txt_May_Tinh_In_BV10_QT_Di = New System.Windows.Forms.TextBox
        Me.txt_May_In_BV10_QT_Di = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txt_Thu_Muc_In_BV10_QT_Di = New System.Windows.Forms.TextBox
        Me.rdb_In_Kim_BV10_QT_Di = New System.Windows.Forms.RadioButton
        Me.rdb_In_Laser_BV10_QT_Di = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GrbCN38 = New System.Windows.Forms.GroupBox
        Me.rdbTypePrint2_CN38 = New System.Windows.Forms.RadioButton
        Me.rdbTypePrint1_CN38 = New System.Windows.Forms.RadioButton
        Me.txtInCN38 = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtMayInCN38 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtMayTinhCN38 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.rdbInkimCN38 = New System.Windows.Forms.RadioButton
        Me.rdbInlaserCN38 = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtInCN35 = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtPrinter = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtServer = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label5 = New System.Windows.Forms.Label
        Me.Tab_Control = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.Printer = New System.Windows.Forms.PrintDialog
        Me.UltraTabPageControl1.SuspendLayout()
        Me.Group_Thiet_Lap_In_Ban_Ke_Moi.SuspendLayout()
        Me.Grp_Thiet_Lap_In_Ban_Ke.SuspendLayout()
        Me.Grp_SuaCuoc.SuspendLayout()
        Me.GrbSoNgayE1Trung.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        Me.Group_Thiet_Lap_In_BV10Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc.SuspendLayout()
        Me.Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc.SuspendLayout()
        Me.grbThietlapcauhinhin.SuspendLayout()
        Me.grbCauhinhinkim.SuspendLayout()
        CType(Me.grbInE4NEW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbInE4NEW.SuspendLayout()
        CType(Me.txtmayinE4NEW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        Me.Group_Thiet_Lap_In_BV10Group_Thiet_Lap_In_Kim_BV10_QT_Di.SuspendLayout()
        Me.Group_Thiet_Lap_In_Kim_BV10_QT_Di.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GrbCN38.SuspendLayout()
        CType(Me.txtMayInCN38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMayTinhCN38, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtPrinter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtServer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tab_Control, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_Control.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.Group_Thiet_Lap_In_Ban_Ke_Moi)
        Me.UltraTabPageControl1.Controls.Add(Me.Grp_Thiet_Lap_In_Ban_Ke)
        Me.UltraTabPageControl1.Controls.Add(Me.Grp_SuaCuoc)
        Me.UltraTabPageControl1.Controls.Add(Me.GrbSoNgayE1Trung)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(586, 462)
        '
        'Group_Thiet_Lap_In_Ban_Ke_Moi
        '
        Me.Group_Thiet_Lap_In_Ban_Ke_Moi.Controls.Add(Me.chk_In_Bv10_To_Text_Second)
        Me.Group_Thiet_Lap_In_Ban_Ke_Moi.Controls.Add(Me.chk_In_E2_To_Text_Second)
        Me.Group_Thiet_Lap_In_Ban_Ke_Moi.Controls.Add(Me.Label24)
        Me.Group_Thiet_Lap_In_Ban_Ke_Moi.Controls.Add(Me.txt_So_Dong_Trong_Trang_In_Ban_Ke_E2)
        Me.Group_Thiet_Lap_In_Ban_Ke_Moi.Controls.Add(Me.Label25)
        Me.Group_Thiet_Lap_In_Ban_Ke_Moi.Controls.Add(Me.chk_In_BC37_To_Text_Second)
        Me.Group_Thiet_Lap_In_Ban_Ke_Moi.Controls.Add(Me.Label26)
        Me.Group_Thiet_Lap_In_Ban_Ke_Moi.Controls.Add(Me.txt_So_Dong_Trong_Trang_In_Ban_Ke_BV10)
        Me.Group_Thiet_Lap_In_Ban_Ke_Moi.Controls.Add(Me.Label22)
        Me.Group_Thiet_Lap_In_Ban_Ke_Moi.Controls.Add(Me.txt_So_Dong_Trong_Trang_In_Ban_Ke_BC37)
        Me.Group_Thiet_Lap_In_Ban_Ke_Moi.Location = New System.Drawing.Point(256, 112)
        Me.Group_Thiet_Lap_In_Ban_Ke_Moi.Name = "Group_Thiet_Lap_In_Ban_Ke_Moi"
        Me.Group_Thiet_Lap_In_Ban_Ke_Moi.Size = New System.Drawing.Size(320, 152)
        Me.Group_Thiet_Lap_In_Ban_Ke_Moi.TabIndex = 4
        Me.Group_Thiet_Lap_In_Ban_Ke_Moi.TabStop = False
        Me.Group_Thiet_Lap_In_Ban_Ke_Moi.Text = "Thiết Lập In bản kê Mới (In Kim)"
        '
        'chk_In_Bv10_To_Text_Second
        '
        Me.chk_In_Bv10_To_Text_Second.Location = New System.Drawing.Point(8, 120)
        Me.chk_In_Bv10_To_Text_Second.Name = "chk_In_Bv10_To_Text_Second"
        Me.chk_In_Bv10_To_Text_Second.TabIndex = 24
        Me.chk_In_Bv10_To_Text_Second.Text = "Bản Kê BV10 Mới"
        '
        'chk_In_E2_To_Text_Second
        '
        Me.chk_In_E2_To_Text_Second.Location = New System.Drawing.Point(8, 56)
        Me.chk_In_E2_To_Text_Second.Name = "chk_In_E2_To_Text_Second"
        Me.chk_In_E2_To_Text_Second.Size = New System.Drawing.Size(112, 20)
        Me.chk_In_E2_To_Text_Second.TabIndex = 23
        Me.chk_In_E2_To_Text_Second.Text = "Bản Kê E2 Mới"
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(272, 56)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(32, 16)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "Dòng"
        '
        'txt_So_Dong_Trong_Trang_In_Ban_Ke_E2
        '
        Me.txt_So_Dong_Trong_Trang_In_Ban_Ke_E2.Location = New System.Drawing.Point(136, 56)
        Me.txt_So_Dong_Trong_Trang_In_Ban_Ke_E2.Name = "txt_So_Dong_Trong_Trang_In_Ban_Ke_E2"
        Me.txt_So_Dong_Trong_Trang_In_Ban_Ke_E2.Size = New System.Drawing.Size(128, 20)
        Me.txt_So_Dong_Trong_Trang_In_Ban_Ke_E2.TabIndex = 1
        Me.txt_So_Dong_Trong_Trang_In_Ban_Ke_E2.Text = ""
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(136, 24)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(136, 23)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Số Dòng Trên Một Trang"
        '
        'chk_In_BC37_To_Text_Second
        '
        Me.chk_In_BC37_To_Text_Second.Location = New System.Drawing.Point(8, 88)
        Me.chk_In_BC37_To_Text_Second.Name = "chk_In_BC37_To_Text_Second"
        Me.chk_In_BC37_To_Text_Second.TabIndex = 25
        Me.chk_In_BC37_To_Text_Second.Text = "Bản Kê BC37 Mới"
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(272, 120)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(32, 16)
        Me.Label26.TabIndex = 8
        Me.Label26.Text = "Dòng"
        '
        'txt_So_Dong_Trong_Trang_In_Ban_Ke_BV10
        '
        Me.txt_So_Dong_Trong_Trang_In_Ban_Ke_BV10.Location = New System.Drawing.Point(136, 120)
        Me.txt_So_Dong_Trong_Trang_In_Ban_Ke_BV10.Name = "txt_So_Dong_Trong_Trang_In_Ban_Ke_BV10"
        Me.txt_So_Dong_Trong_Trang_In_Ban_Ke_BV10.Size = New System.Drawing.Size(128, 20)
        Me.txt_So_Dong_Trong_Trang_In_Ban_Ke_BV10.TabIndex = 7
        Me.txt_So_Dong_Trong_Trang_In_Ban_Ke_BV10.Text = ""
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(272, 88)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(32, 16)
        Me.Label22.TabIndex = 5
        Me.Label22.Text = "Dòng"
        '
        'txt_So_Dong_Trong_Trang_In_Ban_Ke_BC37
        '
        Me.txt_So_Dong_Trong_Trang_In_Ban_Ke_BC37.Location = New System.Drawing.Point(136, 88)
        Me.txt_So_Dong_Trong_Trang_In_Ban_Ke_BC37.Name = "txt_So_Dong_Trong_Trang_In_Ban_Ke_BC37"
        Me.txt_So_Dong_Trong_Trang_In_Ban_Ke_BC37.Size = New System.Drawing.Size(128, 20)
        Me.txt_So_Dong_Trong_Trang_In_Ban_Ke_BC37.TabIndex = 4
        Me.txt_So_Dong_Trong_Trang_In_Ban_Ke_BC37.Text = ""
        '
        'Grp_Thiet_Lap_In_Ban_Ke
        '
        Me.Grp_Thiet_Lap_In_Ban_Ke.Controls.Add(Me.chk_In_Ban_Ke_BV10_Theo_Ngay_Dong)
        Me.Grp_Thiet_Lap_In_Ban_Ke.Controls.Add(Me.chk_In_HQ_Buu_Dien)
        Me.Grp_Thiet_Lap_In_Ban_Ke.Location = New System.Drawing.Point(256, 16)
        Me.Grp_Thiet_Lap_In_Ban_Ke.Name = "Grp_Thiet_Lap_In_Ban_Ke"
        Me.Grp_Thiet_Lap_In_Ban_Ke.Size = New System.Drawing.Size(320, 88)
        Me.Grp_Thiet_Lap_In_Ban_Ke.TabIndex = 3
        Me.Grp_Thiet_Lap_In_Ban_Ke.TabStop = False
        Me.Grp_Thiet_Lap_In_Ban_Ke.Text = "Thiết Lập In bản kê"
        '
        'chk_In_Ban_Ke_BV10_Theo_Ngay_Dong
        '
        Me.chk_In_Ban_Ke_BV10_Theo_Ngay_Dong.Location = New System.Drawing.Point(16, 56)
        Me.chk_In_Ban_Ke_BV10_Theo_Ngay_Dong.Name = "chk_In_Ban_Ke_BV10_Theo_Ngay_Dong"
        Me.chk_In_Ban_Ke_BV10_Theo_Ngay_Dong.Size = New System.Drawing.Size(184, 20)
        Me.chk_In_Ban_Ke_BV10_Theo_Ngay_Dong.TabIndex = 1
        Me.chk_In_Ban_Ke_BV10_Theo_Ngay_Dong.Text = "In bản kê BV10 theo Ngày Đóng"
        '
        'chk_In_HQ_Buu_Dien
        '
        Me.chk_In_HQ_Buu_Dien.Location = New System.Drawing.Point(16, 24)
        Me.chk_In_HQ_Buu_Dien.Name = "chk_In_HQ_Buu_Dien"
        Me.chk_In_HQ_Buu_Dien.Size = New System.Drawing.Size(168, 20)
        Me.chk_In_HQ_Buu_Dien.TabIndex = 0
        Me.chk_In_HQ_Buu_Dien.Text = "In bản kê Hải Quan Bưu Điện"
        '
        'Grp_SuaCuoc
        '
        Me.Grp_SuaCuoc.Controls.Add(Me.chk_Sua_Cuoc_E1)
        Me.Grp_SuaCuoc.Controls.Add(Me.chk_Sua_Cuoc_DV)
        Me.Grp_SuaCuoc.Controls.Add(Me.chk_Sua_Cuoc_Chinh)
        Me.Grp_SuaCuoc.Location = New System.Drawing.Point(8, 112)
        Me.Grp_SuaCuoc.Name = "Grp_SuaCuoc"
        Me.Grp_SuaCuoc.Size = New System.Drawing.Size(240, 152)
        Me.Grp_SuaCuoc.TabIndex = 2
        Me.Grp_SuaCuoc.TabStop = False
        Me.Grp_SuaCuoc.Text = "Thiết Lập Sửa cước"
        '
        'chk_Sua_Cuoc_E1
        '
        Me.chk_Sua_Cuoc_E1.Location = New System.Drawing.Point(16, 88)
        Me.chk_Sua_Cuoc_E1.Name = "chk_Sua_Cuoc_E1"
        Me.chk_Sua_Cuoc_E1.Size = New System.Drawing.Size(144, 20)
        Me.chk_Sua_Cuoc_E1.TabIndex = 2
        Me.chk_Sua_Cuoc_E1.Text = "Cho phép sửa cước E1"
        '
        'chk_Sua_Cuoc_DV
        '
        Me.chk_Sua_Cuoc_DV.Location = New System.Drawing.Point(16, 56)
        Me.chk_Sua_Cuoc_DV.Name = "chk_Sua_Cuoc_DV"
        Me.chk_Sua_Cuoc_DV.Size = New System.Drawing.Size(168, 20)
        Me.chk_Sua_Cuoc_DV.TabIndex = 1
        Me.chk_Sua_Cuoc_DV.Text = "Cho phép sửa cước dịch vụ"
        '
        'chk_Sua_Cuoc_Chinh
        '
        Me.chk_Sua_Cuoc_Chinh.Location = New System.Drawing.Point(16, 24)
        Me.chk_Sua_Cuoc_Chinh.Name = "chk_Sua_Cuoc_Chinh"
        Me.chk_Sua_Cuoc_Chinh.Size = New System.Drawing.Size(160, 20)
        Me.chk_Sua_Cuoc_Chinh.TabIndex = 0
        Me.chk_Sua_Cuoc_Chinh.Text = "Cho phép sửa cước chính"
        '
        'GrbSoNgayE1Trung
        '
        Me.GrbSoNgayE1Trung.Controls.Add(Me.Label17)
        Me.GrbSoNgayE1Trung.Controls.Add(Me.txtTrongLuongE1Max)
        Me.GrbSoNgayE1Trung.Controls.Add(Me.Label18)
        Me.GrbSoNgayE1Trung.Controls.Add(Me.Label1)
        Me.GrbSoNgayE1Trung.Controls.Add(Me.txtSongaykiemtrae1trung)
        Me.GrbSoNgayE1Trung.Controls.Add(Me.lblSoNgayE1trung)
        Me.GrbSoNgayE1Trung.Location = New System.Drawing.Point(8, 16)
        Me.GrbSoNgayE1Trung.Name = "GrbSoNgayE1Trung"
        Me.GrbSoNgayE1Trung.Size = New System.Drawing.Size(240, 88)
        Me.GrbSoNgayE1Trung.TabIndex = 0
        Me.GrbSoNgayE1Trung.TabStop = False
        Me.GrbSoNgayE1Trung.Text = "Thiết lâp Kiểm Tra E1"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(176, 56)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(24, 16)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "g"
        '
        'txtTrongLuongE1Max
        '
        Me.txtTrongLuongE1Max.Location = New System.Drawing.Point(112, 56)
        Me.txtTrongLuongE1Max.Name = "txtTrongLuongE1Max"
        Me.txtTrongLuongE1Max.Size = New System.Drawing.Size(56, 20)
        Me.txtTrongLuongE1Max.TabIndex = 4
        Me.txtTrongLuongE1Max.Text = ""
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(8, 56)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 23)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "Trọng lượng tối đa"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(176, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ngày"
        '
        'txtSongaykiemtrae1trung
        '
        Me.txtSongaykiemtrae1trung.Location = New System.Drawing.Point(112, 24)
        Me.txtSongaykiemtrae1trung.Name = "txtSongaykiemtrae1trung"
        Me.txtSongaykiemtrae1trung.Size = New System.Drawing.Size(56, 20)
        Me.txtSongaykiemtrae1trung.TabIndex = 1
        Me.txtSongaykiemtrae1trung.Text = ""
        '
        'lblSoNgayE1trung
        '
        Me.lblSoNgayE1trung.Location = New System.Drawing.Point(8, 24)
        Me.lblSoNgayE1trung.Name = "lblSoNgayE1trung"
        Me.lblSoNgayE1trung.Size = New System.Drawing.Size(96, 23)
        Me.lblSoNgayE1trung.TabIndex = 0
        Me.lblSoNgayE1trung.Text = "Số ngày kiểm tra"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.Group_Thiet_Lap_In_BV10Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc)
        Me.UltraTabPageControl2.Controls.Add(Me.grbThietlapcauhinhin)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(2, 24)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(586, 462)
        '
        'Group_Thiet_Lap_In_BV10Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc
        '
        Me.Group_Thiet_Lap_In_BV10Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc.Controls.Add(Me.Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc)
        Me.Group_Thiet_Lap_In_BV10Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc.Controls.Add(Me.rdb_In_Kim_BV10_Trong_Nuoc)
        Me.Group_Thiet_Lap_In_BV10Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc.Controls.Add(Me.rdb_In_Laser_BV10_Trong_Nuoc)
        Me.Group_Thiet_Lap_In_BV10Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc.Location = New System.Drawing.Point(10, 312)
        Me.Group_Thiet_Lap_In_BV10Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc.Name = "Group_Thiet_Lap_In_BV10Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc"
        Me.Group_Thiet_Lap_In_BV10Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc.Size = New System.Drawing.Size(566, 144)
        Me.Group_Thiet_Lap_In_BV10Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc.TabIndex = 11
        Me.Group_Thiet_Lap_In_BV10Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc.TabStop = False
        Me.Group_Thiet_Lap_In_BV10Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc.Text = "Nhập thông tin máy in BV10"
        '
        'Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc
        '
        Me.Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc.Controls.Add(Me.rdb_In_Truc_Tiep_BV10_Trong_Nuoc)
        Me.Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc.Controls.Add(Me.rdb_In_Tren_Server_BV10_Trong_Nuoc)
        Me.Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc.Controls.Add(Me.txt_May_Tinh_In_BV10_Trong_Nuoc)
        Me.Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc.Controls.Add(Me.txt_May_In_BV10_Trong_Nuoc)
        Me.Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc.Controls.Add(Me.Label23)
        Me.Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc.Controls.Add(Me.Label27)
        Me.Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc.Controls.Add(Me.Label28)
        Me.Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc.Controls.Add(Me.txt_Thu_Muc_In_BV10_Trong_Nuoc)
        Me.Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc.Location = New System.Drawing.Point(8, 48)
        Me.Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc.Name = "Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc"
        Me.Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc.Size = New System.Drawing.Size(552, 88)
        Me.Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc.TabIndex = 9
        Me.Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc.TabStop = False
        Me.Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc.Text = "Thông số máy in kim"
        '
        'rdb_In_Truc_Tiep_BV10_Trong_Nuoc
        '
        Me.rdb_In_Truc_Tiep_BV10_Trong_Nuoc.Location = New System.Drawing.Point(192, 24)
        Me.rdb_In_Truc_Tiep_BV10_Trong_Nuoc.Name = "rdb_In_Truc_Tiep_BV10_Trong_Nuoc"
        Me.rdb_In_Truc_Tiep_BV10_Trong_Nuoc.Size = New System.Drawing.Size(144, 16)
        Me.rdb_In_Truc_Tiep_BV10_Trong_Nuoc.TabIndex = 18
        Me.rdb_In_Truc_Tiep_BV10_Trong_Nuoc.Text = "In trực tiếp trên máy tính"
        '
        'rdb_In_Tren_Server_BV10_Trong_Nuoc
        '
        Me.rdb_In_Tren_Server_BV10_Trong_Nuoc.Checked = True
        Me.rdb_In_Tren_Server_BV10_Trong_Nuoc.Location = New System.Drawing.Point(8, 24)
        Me.rdb_In_Tren_Server_BV10_Trong_Nuoc.Name = "rdb_In_Tren_Server_BV10_Trong_Nuoc"
        Me.rdb_In_Tren_Server_BV10_Trong_Nuoc.Size = New System.Drawing.Size(96, 16)
        Me.rdb_In_Tren_Server_BV10_Trong_Nuoc.TabIndex = 17
        Me.rdb_In_Tren_Server_BV10_Trong_Nuoc.TabStop = True
        Me.rdb_In_Tren_Server_BV10_Trong_Nuoc.Text = "In trên Server"
        '
        'txt_May_Tinh_In_BV10_Trong_Nuoc
        '
        Me.txt_May_Tinh_In_BV10_Trong_Nuoc.Location = New System.Drawing.Point(256, 56)
        Me.txt_May_Tinh_In_BV10_Trong_Nuoc.Name = "txt_May_Tinh_In_BV10_Trong_Nuoc"
        Me.txt_May_Tinh_In_BV10_Trong_Nuoc.Size = New System.Drawing.Size(96, 20)
        Me.txt_May_Tinh_In_BV10_Trong_Nuoc.TabIndex = 11
        Me.txt_May_Tinh_In_BV10_Trong_Nuoc.Text = ""
        '
        'txt_May_In_BV10_Trong_Nuoc
        '
        Me.txt_May_In_BV10_Trong_Nuoc.Location = New System.Drawing.Point(424, 56)
        Me.txt_May_In_BV10_Trong_Nuoc.Name = "txt_May_In_BV10_Trong_Nuoc"
        Me.txt_May_In_BV10_Trong_Nuoc.Size = New System.Drawing.Size(112, 20)
        Me.txt_May_In_BV10_Trong_Nuoc.TabIndex = 12
        Me.txt_May_In_BV10_Trong_Nuoc.Text = ""
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(192, 56)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(61, 16)
        Me.Label23.TabIndex = 21
        Me.Label23.Text = "Máy tính/IP"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(8, 56)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(91, 16)
        Me.Label27.TabIndex = 17
        Me.Label27.Text = "Thư mục in BV10"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(360, 56)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(60, 16)
        Me.Label28.TabIndex = 22
        Me.Label28.Text = "Tên máy in"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_Thu_Muc_In_BV10_Trong_Nuoc
        '
        Me.txt_Thu_Muc_In_BV10_Trong_Nuoc.Enabled = False
        Me.txt_Thu_Muc_In_BV10_Trong_Nuoc.Location = New System.Drawing.Point(104, 56)
        Me.txt_Thu_Muc_In_BV10_Trong_Nuoc.Name = "txt_Thu_Muc_In_BV10_Trong_Nuoc"
        Me.txt_Thu_Muc_In_BV10_Trong_Nuoc.Size = New System.Drawing.Size(80, 20)
        Me.txt_Thu_Muc_In_BV10_Trong_Nuoc.TabIndex = 10
        Me.txt_Thu_Muc_In_BV10_Trong_Nuoc.Text = ""
        '
        'rdb_In_Kim_BV10_Trong_Nuoc
        '
        Me.rdb_In_Kim_BV10_Trong_Nuoc.Location = New System.Drawing.Point(200, 24)
        Me.rdb_In_Kim_BV10_Trong_Nuoc.Name = "rdb_In_Kim_BV10_Trong_Nuoc"
        Me.rdb_In_Kim_BV10_Trong_Nuoc.Size = New System.Drawing.Size(120, 16)
        Me.rdb_In_Kim_BV10_Trong_Nuoc.TabIndex = 8
        Me.rdb_In_Kim_BV10_Trong_Nuoc.Text = "In kim"
        '
        'rdb_In_Laser_BV10_Trong_Nuoc
        '
        Me.rdb_In_Laser_BV10_Trong_Nuoc.Checked = True
        Me.rdb_In_Laser_BV10_Trong_Nuoc.Location = New System.Drawing.Point(16, 24)
        Me.rdb_In_Laser_BV10_Trong_Nuoc.Name = "rdb_In_Laser_BV10_Trong_Nuoc"
        Me.rdb_In_Laser_BV10_Trong_Nuoc.Size = New System.Drawing.Size(96, 16)
        Me.rdb_In_Laser_BV10_Trong_Nuoc.TabIndex = 7
        Me.rdb_In_Laser_BV10_Trong_Nuoc.TabStop = True
        Me.rdb_In_Laser_BV10_Trong_Nuoc.Text = "In laser"
        '
        'grbThietlapcauhinhin
        '
        Me.grbThietlapcauhinhin.Controls.Add(Me.grbCauhinhinkim)
        Me.grbThietlapcauhinhin.Controls.Add(Me.rdbInkim)
        Me.grbThietlapcauhinhin.Controls.Add(Me.rdbInlaser)
        Me.grbThietlapcauhinhin.Location = New System.Drawing.Point(8, 8)
        Me.grbThietlapcauhinhin.Name = "grbThietlapcauhinhin"
        Me.grbThietlapcauhinhin.Size = New System.Drawing.Size(568, 296)
        Me.grbThietlapcauhinhin.TabIndex = 1
        Me.grbThietlapcauhinhin.TabStop = False
        Me.grbThietlapcauhinhin.Text = "Thiết lập cấu hình in bản kê (Quốc Tế Đến)"
        '
        'grbCauhinhinkim
        '
        Me.grbCauhinhinkim.Controls.Add(Me.grbInE4NEW)
        Me.grbCauhinhinkim.Controls.Add(Me.rdbTypePrint2)
        Me.grbCauhinhinkim.Controls.Add(Me.rdbTypePrint1)
        Me.grbCauhinhinkim.Controls.Add(Me.txtMayInE4)
        Me.grbCauhinhinkim.Controls.Add(Me.txtMayInE2)
        Me.grbCauhinhinkim.Controls.Add(Me.txtMayInBC37)
        Me.grbCauhinhinkim.Controls.Add(Me.Label10)
        Me.grbCauhinhinkim.Controls.Add(Me.Label11)
        Me.grbCauhinhinkim.Controls.Add(Me.Label12)
        Me.grbCauhinhinkim.Controls.Add(Me.txtMayTinhE4)
        Me.grbCauhinhinkim.Controls.Add(Me.txtMayTinhE2)
        Me.grbCauhinhinkim.Controls.Add(Me.txtMayTinhBC37)
        Me.grbCauhinhinkim.Controls.Add(Me.Label7)
        Me.grbCauhinhinkim.Controls.Add(Me.Label8)
        Me.grbCauhinhinkim.Controls.Add(Me.Label9)
        Me.grbCauhinhinkim.Controls.Add(Me.txtInE4)
        Me.grbCauhinhinkim.Controls.Add(Me.Label4)
        Me.grbCauhinhinkim.Controls.Add(Me.txtInE2)
        Me.grbCauhinhinkim.Controls.Add(Me.Label3)
        Me.grbCauhinhinkim.Controls.Add(Me.txtInbc37)
        Me.grbCauhinhinkim.Controls.Add(Me.Label2)
        Me.grbCauhinhinkim.Controls.Add(Me.chkInE4_New)
        Me.grbCauhinhinkim.Location = New System.Drawing.Point(8, 48)
        Me.grbCauhinhinkim.Name = "grbCauhinhinkim"
        Me.grbCauhinhinkim.Size = New System.Drawing.Size(552, 240)
        Me.grbCauhinhinkim.TabIndex = 2
        Me.grbCauhinhinkim.TabStop = False
        Me.grbCauhinhinkim.Text = "Nhập các thông số cho máy in kim"
        '
        'grbInE4NEW
        '
        Me.grbInE4NEW.Controls.Add(Me.chkE4)
        Me.grbInE4NEW.Controls.Add(Me.bntinE4)
        Me.grbInE4NEW.Controls.Add(Me.txtmayinE4NEW)
        Me.grbInE4NEW.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbInE4NEW.Location = New System.Drawing.Point(8, 184)
        Me.grbInE4NEW.Name = "grbInE4NEW"
        Me.grbInE4NEW.Size = New System.Drawing.Size(536, 48)
        Me.grbInE4NEW.SupportThemes = False
        Me.grbInE4NEW.TabIndex = 17
        '
        'chkE4
        '
        Me.chkE4.Location = New System.Drawing.Point(352, 8)
        Me.chkE4.Name = "chkE4"
        Me.chkE4.Size = New System.Drawing.Size(112, 32)
        Me.chkE4.TabIndex = 14
        Me.chkE4.Text = "Kết nối trực tiếp với máy in"
        '
        'bntinE4
        '
        Me.bntinE4.Location = New System.Drawing.Point(472, 16)
        Me.bntinE4.Name = "bntinE4"
        Me.bntinE4.Size = New System.Drawing.Size(56, 24)
        Me.bntinE4.TabIndex = 13
        Me.bntinE4.Text = "..."
        '
        'txtmayinE4NEW
        '
        Me.txtmayinE4NEW.Location = New System.Drawing.Point(8, 16)
        Me.txtmayinE4NEW.Name = "txtmayinE4NEW"
        Me.txtmayinE4NEW.Size = New System.Drawing.Size(336, 21)
        Me.txtmayinE4NEW.TabIndex = 12
        '
        'rdbTypePrint2
        '
        Me.rdbTypePrint2.Location = New System.Drawing.Point(200, 24)
        Me.rdbTypePrint2.Name = "rdbTypePrint2"
        Me.rdbTypePrint2.Size = New System.Drawing.Size(144, 16)
        Me.rdbTypePrint2.TabIndex = 16
        Me.rdbTypePrint2.Text = "In trực tiếp trên máy tính"
        '
        'rdbTypePrint1
        '
        Me.rdbTypePrint1.Checked = True
        Me.rdbTypePrint1.Location = New System.Drawing.Point(16, 24)
        Me.rdbTypePrint1.Name = "rdbTypePrint1"
        Me.rdbTypePrint1.Size = New System.Drawing.Size(96, 16)
        Me.rdbTypePrint1.TabIndex = 15
        Me.rdbTypePrint1.TabStop = True
        Me.rdbTypePrint1.Text = "In trên Server"
        '
        'txtMayInE4
        '
        Me.txtMayInE4.Location = New System.Drawing.Point(432, 120)
        Me.txtMayInE4.Name = "txtMayInE4"
        Me.txtMayInE4.Size = New System.Drawing.Size(104, 20)
        Me.txtMayInE4.TabIndex = 9
        Me.txtMayInE4.Text = ""
        '
        'txtMayInE2
        '
        Me.txtMayInE2.Location = New System.Drawing.Point(432, 88)
        Me.txtMayInE2.Name = "txtMayInE2"
        Me.txtMayInE2.Size = New System.Drawing.Size(104, 20)
        Me.txtMayInE2.TabIndex = 6
        Me.txtMayInE2.Text = ""
        '
        'txtMayInBC37
        '
        Me.txtMayInBC37.Location = New System.Drawing.Point(432, 48)
        Me.txtMayInBC37.Name = "txtMayInBC37"
        Me.txtMayInBC37.Size = New System.Drawing.Size(104, 20)
        Me.txtMayInBC37.TabIndex = 3
        Me.txtMayInBC37.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(368, 118)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 24)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Tên máy in"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(368, 86)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 24)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Tên máy in"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(368, 46)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 24)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Tên máy in"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMayTinhE4
        '
        Me.txtMayTinhE4.Location = New System.Drawing.Point(264, 120)
        Me.txtMayTinhE4.Name = "txtMayTinhE4"
        Me.txtMayTinhE4.Size = New System.Drawing.Size(96, 20)
        Me.txtMayTinhE4.TabIndex = 8
        Me.txtMayTinhE4.Text = ""
        '
        'txtMayTinhE2
        '
        Me.txtMayTinhE2.Location = New System.Drawing.Point(264, 88)
        Me.txtMayTinhE2.Name = "txtMayTinhE2"
        Me.txtMayTinhE2.Size = New System.Drawing.Size(96, 20)
        Me.txtMayTinhE2.TabIndex = 5
        Me.txtMayTinhE2.Text = ""
        '
        'txtMayTinhBC37
        '
        Me.txtMayTinhBC37.Location = New System.Drawing.Point(264, 48)
        Me.txtMayTinhBC37.Name = "txtMayTinhBC37"
        Me.txtMayTinhBC37.Size = New System.Drawing.Size(96, 20)
        Me.txtMayTinhBC37.TabIndex = 2
        Me.txtMayTinhBC37.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(200, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Máy tính/IP"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(200, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Máy tính/IP"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(200, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 16)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Máy tính/IP"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtInE4
        '
        Me.txtInE4.Enabled = False
        Me.txtInE4.Location = New System.Drawing.Point(112, 120)
        Me.txtInE4.Name = "txtInE4"
        Me.txtInE4.Size = New System.Drawing.Size(80, 20)
        Me.txtInE4.TabIndex = 7
        Me.txtInE4.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Thư mục in E4"
        '
        'txtInE2
        '
        Me.txtInE2.Enabled = False
        Me.txtInE2.Location = New System.Drawing.Point(112, 88)
        Me.txtInE2.Name = "txtInE2"
        Me.txtInE2.Size = New System.Drawing.Size(80, 20)
        Me.txtInE2.TabIndex = 4
        Me.txtInE2.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Thư mục in E2"
        '
        'txtInbc37
        '
        Me.txtInbc37.Enabled = False
        Me.txtInbc37.Location = New System.Drawing.Point(112, 48)
        Me.txtInbc37.Name = "txtInbc37"
        Me.txtInbc37.Size = New System.Drawing.Size(80, 20)
        Me.txtInbc37.TabIndex = 1
        Me.txtInbc37.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Thư mục in BC37"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkInE4_New
        '
        Me.chkInE4_New.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInE4_New.Location = New System.Drawing.Point(16, 160)
        Me.chkInE4_New.Name = "chkInE4_New"
        Me.chkInE4_New.Size = New System.Drawing.Size(160, 16)
        Me.chkInE4_New.TabIndex = 15
        Me.chkInE4_New.Text = "In nhãn E4 mới"
        '
        'rdbInkim
        '
        Me.rdbInkim.Location = New System.Drawing.Point(208, 24)
        Me.rdbInkim.Name = "rdbInkim"
        Me.rdbInkim.Size = New System.Drawing.Size(120, 16)
        Me.rdbInkim.TabIndex = 1
        Me.rdbInkim.Text = "Chọn in kim"
        '
        'rdbInlaser
        '
        Me.rdbInlaser.Checked = True
        Me.rdbInlaser.Location = New System.Drawing.Point(24, 24)
        Me.rdbInlaser.Name = "rdbInlaser"
        Me.rdbInlaser.Size = New System.Drawing.Size(96, 16)
        Me.rdbInlaser.TabIndex = 0
        Me.rdbInlaser.TabStop = True
        Me.rdbInlaser.Text = "Chọn in laser"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.Group_Thiet_Lap_In_BV10Group_Thiet_Lap_In_Kim_BV10_QT_Di)
        Me.UltraTabPageControl3.Controls.Add(Me.GroupBox2)
        Me.UltraTabPageControl3.Controls.Add(Me.GroupBox1)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(586, 462)
        '
        'Group_Thiet_Lap_In_BV10Group_Thiet_Lap_In_Kim_BV10_QT_Di
        '
        Me.Group_Thiet_Lap_In_BV10Group_Thiet_Lap_In_Kim_BV10_QT_Di.Controls.Add(Me.Group_Thiet_Lap_In_Kim_BV10_QT_Di)
        Me.Group_Thiet_Lap_In_BV10Group_Thiet_Lap_In_Kim_BV10_QT_Di.Controls.Add(Me.rdb_In_Kim_BV10_QT_Di)
        Me.Group_Thiet_Lap_In_BV10Group_Thiet_Lap_In_Kim_BV10_QT_Di.Controls.Add(Me.rdb_In_Laser_BV10_QT_Di)
        Me.Group_Thiet_Lap_In_BV10Group_Thiet_Lap_In_Kim_BV10_QT_Di.Location = New System.Drawing.Point(8, 232)
        Me.Group_Thiet_Lap_In_BV10Group_Thiet_Lap_In_Kim_BV10_QT_Di.Name = "Group_Thiet_Lap_In_BV10Group_Thiet_Lap_In_Kim_BV10_QT_Di"
        Me.Group_Thiet_Lap_In_BV10Group_Thiet_Lap_In_Kim_BV10_QT_Di.Size = New System.Drawing.Size(568, 144)
        Me.Group_Thiet_Lap_In_BV10Group_Thiet_Lap_In_Kim_BV10_QT_Di.TabIndex = 10
        Me.Group_Thiet_Lap_In_BV10Group_Thiet_Lap_In_Kim_BV10_QT_Di.TabStop = False
        Me.Group_Thiet_Lap_In_BV10Group_Thiet_Lap_In_Kim_BV10_QT_Di.Text = "Nhập thông tin máy in BV10"
        '
        'Group_Thiet_Lap_In_Kim_BV10_QT_Di
        '
        Me.Group_Thiet_Lap_In_Kim_BV10_QT_Di.Controls.Add(Me.rdb_In_Truc_Tiep_BV10_QT_Di)
        Me.Group_Thiet_Lap_In_Kim_BV10_QT_Di.Controls.Add(Me.rdb_In_Tren_Server_BV10_QT_Di)
        Me.Group_Thiet_Lap_In_Kim_BV10_QT_Di.Controls.Add(Me.txt_May_Tinh_In_BV10_QT_Di)
        Me.Group_Thiet_Lap_In_Kim_BV10_QT_Di.Controls.Add(Me.txt_May_In_BV10_QT_Di)
        Me.Group_Thiet_Lap_In_Kim_BV10_QT_Di.Controls.Add(Me.Label15)
        Me.Group_Thiet_Lap_In_Kim_BV10_QT_Di.Controls.Add(Me.Label16)
        Me.Group_Thiet_Lap_In_Kim_BV10_QT_Di.Controls.Add(Me.Label14)
        Me.Group_Thiet_Lap_In_Kim_BV10_QT_Di.Controls.Add(Me.txt_Thu_Muc_In_BV10_QT_Di)
        Me.Group_Thiet_Lap_In_Kim_BV10_QT_Di.Location = New System.Drawing.Point(8, 48)
        Me.Group_Thiet_Lap_In_Kim_BV10_QT_Di.Name = "Group_Thiet_Lap_In_Kim_BV10_QT_Di"
        Me.Group_Thiet_Lap_In_Kim_BV10_QT_Di.Size = New System.Drawing.Size(552, 88)
        Me.Group_Thiet_Lap_In_Kim_BV10_QT_Di.TabIndex = 9
        Me.Group_Thiet_Lap_In_Kim_BV10_QT_Di.TabStop = False
        Me.Group_Thiet_Lap_In_Kim_BV10_QT_Di.Text = "Thông số máy in kim"
        '
        'rdb_In_Truc_Tiep_BV10_QT_Di
        '
        Me.rdb_In_Truc_Tiep_BV10_QT_Di.Location = New System.Drawing.Point(192, 24)
        Me.rdb_In_Truc_Tiep_BV10_QT_Di.Name = "rdb_In_Truc_Tiep_BV10_QT_Di"
        Me.rdb_In_Truc_Tiep_BV10_QT_Di.Size = New System.Drawing.Size(144, 16)
        Me.rdb_In_Truc_Tiep_BV10_QT_Di.TabIndex = 18
        Me.rdb_In_Truc_Tiep_BV10_QT_Di.Text = "In trực tiếp trên máy tính"
        '
        'rdb_In_Tren_Server_BV10_QT_Di
        '
        Me.rdb_In_Tren_Server_BV10_QT_Di.Checked = True
        Me.rdb_In_Tren_Server_BV10_QT_Di.Location = New System.Drawing.Point(8, 24)
        Me.rdb_In_Tren_Server_BV10_QT_Di.Name = "rdb_In_Tren_Server_BV10_QT_Di"
        Me.rdb_In_Tren_Server_BV10_QT_Di.Size = New System.Drawing.Size(96, 16)
        Me.rdb_In_Tren_Server_BV10_QT_Di.TabIndex = 17
        Me.rdb_In_Tren_Server_BV10_QT_Di.TabStop = True
        Me.rdb_In_Tren_Server_BV10_QT_Di.Text = "In trên Server"
        '
        'txt_May_Tinh_In_BV10_QT_Di
        '
        Me.txt_May_Tinh_In_BV10_QT_Di.Location = New System.Drawing.Point(256, 56)
        Me.txt_May_Tinh_In_BV10_QT_Di.Name = "txt_May_Tinh_In_BV10_QT_Di"
        Me.txt_May_Tinh_In_BV10_QT_Di.Size = New System.Drawing.Size(96, 20)
        Me.txt_May_Tinh_In_BV10_QT_Di.TabIndex = 11
        Me.txt_May_Tinh_In_BV10_QT_Di.Text = ""
        '
        'txt_May_In_BV10_QT_Di
        '
        Me.txt_May_In_BV10_QT_Di.Location = New System.Drawing.Point(424, 56)
        Me.txt_May_In_BV10_QT_Di.Name = "txt_May_In_BV10_QT_Di"
        Me.txt_May_In_BV10_QT_Di.Size = New System.Drawing.Size(112, 20)
        Me.txt_May_In_BV10_QT_Di.TabIndex = 12
        Me.txt_May_In_BV10_QT_Di.Text = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(192, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 16)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Máy tính/IP"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 56)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 16)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "Thư mục in BV10"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(360, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 16)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Tên máy in"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_Thu_Muc_In_BV10_QT_Di
        '
        Me.txt_Thu_Muc_In_BV10_QT_Di.Enabled = False
        Me.txt_Thu_Muc_In_BV10_QT_Di.Location = New System.Drawing.Point(104, 56)
        Me.txt_Thu_Muc_In_BV10_QT_Di.Name = "txt_Thu_Muc_In_BV10_QT_Di"
        Me.txt_Thu_Muc_In_BV10_QT_Di.Size = New System.Drawing.Size(80, 20)
        Me.txt_Thu_Muc_In_BV10_QT_Di.TabIndex = 10
        Me.txt_Thu_Muc_In_BV10_QT_Di.Text = ""
        '
        'rdb_In_Kim_BV10_QT_Di
        '
        Me.rdb_In_Kim_BV10_QT_Di.Location = New System.Drawing.Point(200, 24)
        Me.rdb_In_Kim_BV10_QT_Di.Name = "rdb_In_Kim_BV10_QT_Di"
        Me.rdb_In_Kim_BV10_QT_Di.Size = New System.Drawing.Size(120, 16)
        Me.rdb_In_Kim_BV10_QT_Di.TabIndex = 8
        Me.rdb_In_Kim_BV10_QT_Di.Text = "In kim"
        '
        'rdb_In_Laser_BV10_QT_Di
        '
        Me.rdb_In_Laser_BV10_QT_Di.Checked = True
        Me.rdb_In_Laser_BV10_QT_Di.Location = New System.Drawing.Point(16, 24)
        Me.rdb_In_Laser_BV10_QT_Di.Name = "rdb_In_Laser_BV10_QT_Di"
        Me.rdb_In_Laser_BV10_QT_Di.Size = New System.Drawing.Size(96, 16)
        Me.rdb_In_Laser_BV10_QT_Di.TabIndex = 7
        Me.rdb_In_Laser_BV10_QT_Di.TabStop = True
        Me.rdb_In_Laser_BV10_QT_Di.Text = "In laser"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GrbCN38)
        Me.GroupBox2.Controls.Add(Me.rdbInkimCN38)
        Me.GroupBox2.Controls.Add(Me.rdbInlaserCN38)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 80)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(568, 144)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nhập thông tin máy in CN38"
        '
        'GrbCN38
        '
        Me.GrbCN38.Controls.Add(Me.rdbTypePrint2_CN38)
        Me.GrbCN38.Controls.Add(Me.rdbTypePrint1_CN38)
        Me.GrbCN38.Controls.Add(Me.txtInCN38)
        Me.GrbCN38.Controls.Add(Me.Label19)
        Me.GrbCN38.Controls.Add(Me.txtMayInCN38)
        Me.GrbCN38.Controls.Add(Me.txtMayTinhCN38)
        Me.GrbCN38.Controls.Add(Me.Label21)
        Me.GrbCN38.Controls.Add(Me.Label20)
        Me.GrbCN38.Location = New System.Drawing.Point(8, 48)
        Me.GrbCN38.Name = "GrbCN38"
        Me.GrbCN38.Size = New System.Drawing.Size(552, 88)
        Me.GrbCN38.TabIndex = 9
        Me.GrbCN38.TabStop = False
        Me.GrbCN38.Text = "Thông số máy in kim"
        '
        'rdbTypePrint2_CN38
        '
        Me.rdbTypePrint2_CN38.Location = New System.Drawing.Point(192, 24)
        Me.rdbTypePrint2_CN38.Name = "rdbTypePrint2_CN38"
        Me.rdbTypePrint2_CN38.Size = New System.Drawing.Size(144, 16)
        Me.rdbTypePrint2_CN38.TabIndex = 18
        Me.rdbTypePrint2_CN38.Text = "In trực tiếp trên máy tính"
        '
        'rdbTypePrint1_CN38
        '
        Me.rdbTypePrint1_CN38.Checked = True
        Me.rdbTypePrint1_CN38.Location = New System.Drawing.Point(8, 24)
        Me.rdbTypePrint1_CN38.Name = "rdbTypePrint1_CN38"
        Me.rdbTypePrint1_CN38.Size = New System.Drawing.Size(96, 16)
        Me.rdbTypePrint1_CN38.TabIndex = 17
        Me.rdbTypePrint1_CN38.TabStop = True
        Me.rdbTypePrint1_CN38.Text = "In trên Server"
        '
        'txtInCN38
        '
        Me.txtInCN38.Enabled = False
        Me.txtInCN38.Location = New System.Drawing.Point(104, 56)
        Me.txtInCN38.Name = "txtInCN38"
        Me.txtInCN38.Size = New System.Drawing.Size(80, 20)
        Me.txtInCN38.TabIndex = 8
        Me.txtInCN38.Text = ""
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(8, 56)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(92, 16)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "Thư mục in CN38"
        '
        'txtMayInCN38
        '
        Me.txtMayInCN38.Location = New System.Drawing.Point(424, 56)
        Me.txtMayInCN38.Name = "txtMayInCN38"
        Me.txtMayInCN38.Size = New System.Drawing.Size(112, 21)
        Me.txtMayInCN38.TabIndex = 10
        '
        'txtMayTinhCN38
        '
        Me.txtMayTinhCN38.Location = New System.Drawing.Point(256, 56)
        Me.txtMayTinhCN38.Name = "txtMayTinhCN38"
        Me.txtMayTinhCN38.Size = New System.Drawing.Size(96, 21)
        Me.txtMayTinhCN38.TabIndex = 9
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(192, 56)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(70, 16)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "Máy tính/IP"
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(360, 56)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(67, 16)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "Tên máy in"
        '
        'rdbInkimCN38
        '
        Me.rdbInkimCN38.Location = New System.Drawing.Point(200, 24)
        Me.rdbInkimCN38.Name = "rdbInkimCN38"
        Me.rdbInkimCN38.Size = New System.Drawing.Size(120, 16)
        Me.rdbInkimCN38.TabIndex = 8
        Me.rdbInkimCN38.Text = "In kim"
        '
        'rdbInlaserCN38
        '
        Me.rdbInlaserCN38.Checked = True
        Me.rdbInlaserCN38.Location = New System.Drawing.Point(16, 24)
        Me.rdbInlaserCN38.Name = "rdbInlaserCN38"
        Me.rdbInlaserCN38.Size = New System.Drawing.Size(96, 16)
        Me.rdbInlaserCN38.TabIndex = 7
        Me.rdbInlaserCN38.TabStop = True
        Me.rdbInlaserCN38.Text = "In laser"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtInCN35)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtPrinter)
        Me.GroupBox1.Controls.Add(Me.txtServer)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 56)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nhập thông tin máy in CN35 (In Kim)"
        '
        'txtInCN35
        '
        Me.txtInCN35.Enabled = False
        Me.txtInCN35.Location = New System.Drawing.Point(112, 24)
        Me.txtInCN35.Name = "txtInCN35"
        Me.txtInCN35.Size = New System.Drawing.Size(80, 20)
        Me.txtInCN35.TabIndex = 1
        Me.txtInCN35.Text = ""
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(16, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 24)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Thư mục in CN35"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(369, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Tên máy in"
        '
        'txtPrinter
        '
        Me.txtPrinter.Location = New System.Drawing.Point(432, 24)
        Me.txtPrinter.Name = "txtPrinter"
        Me.txtPrinter.Size = New System.Drawing.Size(104, 21)
        Me.txtPrinter.TabIndex = 3
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(264, 24)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(96, 21)
        Me.txtServer.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(199, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Máy tính/IP"
        '
        'Tab_Control
        '
        Me.Tab_Control.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.Tab_Control.Controls.Add(Me.UltraTabPageControl1)
        Me.Tab_Control.Controls.Add(Me.UltraTabPageControl2)
        Me.Tab_Control.Controls.Add(Me.UltraTabPageControl3)
        Me.Tab_Control.Location = New System.Drawing.Point(10, 0)
        Me.Tab_Control.Name = "Tab_Control"
        Me.Tab_Control.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.Tab_Control.Size = New System.Drawing.Size(590, 488)
        Me.Tab_Control.TabIndex = 5
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Thiết Lập Chính"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Thiết Lập In (Bản Kê Đi Trong Nước)"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Thiết Lập In (Bản Kê Đi Quốc Tế)"
        Me.Tab_Control.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(586, 462)
        '
        'FrmThietLapThamSoHeThong
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(608, 493)
        Me.Controls.Add(Me.Tab_Control)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmThietLapThamSoHeThong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thiết  lập tham số hệ thống"
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.Group_Thiet_Lap_In_Ban_Ke_Moi.ResumeLayout(False)
        Me.Grp_Thiet_Lap_In_Ban_Ke.ResumeLayout(False)
        Me.Grp_SuaCuoc.ResumeLayout(False)
        Me.GrbSoNgayE1Trung.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.Group_Thiet_Lap_In_BV10Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc.ResumeLayout(False)
        Me.Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc.ResumeLayout(False)
        Me.grbThietlapcauhinhin.ResumeLayout(False)
        Me.grbCauhinhinkim.ResumeLayout(False)
        CType(Me.grbInE4NEW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbInE4NEW.ResumeLayout(False)
        CType(Me.txtmayinE4NEW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        Me.Group_Thiet_Lap_In_BV10Group_Thiet_Lap_In_Kim_BV10_QT_Di.ResumeLayout(False)
        Me.Group_Thiet_Lap_In_Kim_BV10_QT_Di.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GrbCN38.ResumeLayout(False)
        CType(Me.txtMayInCN38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMayTinhCN38, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.txtPrinter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtServer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tab_Control, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_Control.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "--------------SetKeys + GetKeys--------------"
    Private Sub SetKeys()
        myKeys.Ghi("GSo_Ngay_E1_Duoc_Trung", IIf(txtSongaykiemtrae1trung.Text <> "", txtSongaykiemtrae1trung.Text, 0))
        myKeys.Ghi("GTrong_Luong_E1_Max", IIf(txtTrongLuongE1Max.Text <> "", txtTrongLuongE1Max.Text, 0))

        myKeys.Ghi("GIn_Kim_QT_Den", rdbInkim.Checked)
        myKeys.Ghi("GIn_Laser_QT_Den", rdbInlaser.Checked)

        myKeys.Ghi("GKieu_In_Map", rdbTypePrint1.Checked)

        myKeys.Ghi("GThu_Muc_In_BC37_QT_Den", txtInbc37.Text)

        myKeys.Ghi("GThu_Muc_In_E2_QT_Den", txtInE2.Text)
        myKeys.Ghi("GThu_Muc_In_E4_QT_Den", txtInE4.Text)

        myKeys.Ghi("GThu_Muc_In_CN35_QT_Di", txtInCN35.Text)
        myKeys.Ghi("GTen_May_Tinh_CN35", txtServer.Text)
        myKeys.Ghi("GTen_May_In_CN35", txtPrinter.Text)

        myKeys.Ghi("GTen_May_Tinh_BC37", txtMayTinhBC37.Text)
        myKeys.Ghi("GTen_May_In_BC37", txtMayInBC37.Text)

        myKeys.Ghi("GTen_May_Tinh_E4", txtMayTinhE4.Text)
        myKeys.Ghi("GTen_May_In_E4", txtMayInE4.Text)

        myKeys.Ghi("GTen_May_Tinh_E2", txtMayTinhE2.Text)
        myKeys.Ghi("GTen_May_In_E2", txtMayInE2.Text)

        'Them phan in CN38-------------------------------------
        'Kieu in ( laser   ;  kim)
        myKeys.Ghi("GIn_Kim_QT_Di_CN38", rdbInkimCN38.Checked)
        myKeys.Ghi("GIn_Laser_QT_Di_CN38", rdbInlaserCN38.Checked)
        'Kieu in ( server   ;   truc tiep)
        myKeys.Ghi("GKieu_In_Map_CN38", rdbTypePrint1_CN38.Checked)
        'Thu muc in tren server
        myKeys.Ghi("GThu_Muc_In_CN38_QT_Di", txtInCN38.Text)
        'Thong tin may in truc tiep
        myKeys.Ghi("GTen_May_Tinh_CN38", txtMayTinhCN38.Text)
        myKeys.Ghi("GTen_May_In_CN38", txtMayInCN38.Text)
        '-----------------------------------------------------

        'Cho phép sửa cước
        myKeys.Ghi("GSua_Cuoc_Chinh", chk_Sua_Cuoc_Chinh.Checked)
        myKeys.Ghi("GSua_Cuoc_DV", chk_Sua_Cuoc_Chinh.Checked)
        myKeys.Ghi("GSua_Cuoc_E1", chk_Sua_Cuoc_Chinh.Checked)
        '-----------------------------------------------------
        'In bản kê Hải quan bưu điện
        myKeys.Ghi("GIn_Ban_Ke_HQ_Buu_Dien", chk_In_HQ_Buu_Dien.Checked)
        'In bản kê BV10 theo ngày đóng
        myKeys.Ghi("GIn_Ban_Ke_BV10_Theo_Ngay_Dong", chk_In_Ban_Ke_BV10_Theo_Ngay_Dong.Checked)
        '-----------------------------------------------------
        'In bản kê E2 theo mẫu mới
        myKeys.Ghi("GIn_Ban_Ke_E2_To_Text_Second", chk_In_E2_To_Text_Second.Checked)
        'In bản kê BC37 theo mẫu mới
        myKeys.Ghi("GIn_Ban_Ke_BC37_To_Text_Second", chk_In_BC37_To_Text_Second.Checked)
        'In bản kê BV10 theo mẫu mới
        myKeys.Ghi("GIn_Ban_Ke_BV10_To_Text_Second", chk_In_Bv10_To_Text_Second.Checked)

        '----------------------------------------------------------------------
        'Số dòng trên một trang in E2
        myKeys.Ghi("GSo_Dong_Trong_Trang_In_Ban_Ke_E2", IIf(txt_So_Dong_Trong_Trang_In_Ban_Ke_E2.Text <> "", txt_So_Dong_Trong_Trang_In_Ban_Ke_E2.Text, 40))
        'Số dòng trên một trang in BC37
        myKeys.Ghi("GSo_Dong_Trong_Trang_In_Ban_Ke_BC37", IIf(txt_So_Dong_Trong_Trang_In_Ban_Ke_BC37.Text <> "", txt_So_Dong_Trong_Trang_In_Ban_Ke_BC37.Text, 39))
        'Số dòng trên một trang in BV10
        myKeys.Ghi("GSo_Dong_Trong_Trang_In_Ban_Ke_BV10", IIf(txt_So_Dong_Trong_Trang_In_Ban_Ke_BV10.Text <> "", txt_So_Dong_Trong_Trang_In_Ban_Ke_BV10.Text, 39))

        '-------------------------------------------------------------
        'Thiết lập In bản kê BV10 quốc tế đi
        myKeys.Ghi("GIn_Kim_BV10_QT_Di", rdb_In_Kim_BV10_QT_Di.Checked)
        myKeys.Ghi("GIn_Tren_Server_BV10_QT_Di", rdb_In_Tren_Server_BV10_QT_Di.Checked)
        myKeys.Ghi("GThu_Muc_In_BV10_QT_Di", txt_Thu_Muc_In_BV10_QT_Di.Text)
        myKeys.Ghi("GMay_Tinh_In_BV10_QT_Di", txt_May_Tinh_In_BV10_QT_Di.Text)
        myKeys.Ghi("GMay_In_BV10_QT_Di", txt_May_In_BV10_QT_Di.Text)

        'Thiết lập In bản kê BV10 trong nước
        myKeys.Ghi("GIn_Kim_BV10_Trong_Nuoc", rdb_In_Kim_BV10_Trong_Nuoc.Checked)
        myKeys.Ghi("GIn_Tren_Server_BV10_Trong_Nuoc", rdb_In_Tren_Server_BV10_Trong_Nuoc.Checked)
        myKeys.Ghi("GThu_Muc_In_BV10_Trong_Nuoc", txt_Thu_Muc_In_BV10_Trong_Nuoc.Text)
        myKeys.Ghi("GMay_Tinh_In_BV10_Trong_Nuoc", txt_May_Tinh_In_BV10_Trong_Nuoc.Text)
        myKeys.Ghi("GMay_In_BV10_Trong_Nuoc", txt_May_In_BV10_Trong_Nuoc.Text)

        'In E4 New
        myKeys.Ghi("KieuInE4New", IIf(chkInE4_New.Checked, "1", "0"))
        myKeys.Ghi("TenMayInE4New", txtmayinE4NEW.Text)
    End Sub

    Private Sub GetKeys()
        GSo_Ngay_E1_Duoc_Trung = IIf(myKeys.Doc("GSo_Ngay_E1_Duoc_Trung") Is Nothing Or myKeys.Doc("GSo_Ngay_E1_Duoc_Trung") = "", "0", myKeys.Doc("GSo_Ngay_E1_Duoc_Trung"))
        GTrong_Luong_E1_Max = IIf(myKeys.Doc("GTrong_Luong_E1_Max") Is Nothing Or myKeys.Doc("GTrong_Luong_E1_Max") = "", "0", myKeys.Doc("GTrong_Luong_E1_Max"))
        GThu_Muc_In_BC37_QT_Den = IIf(myKeys.Doc("GThu_Muc_In_BC37_QT_Den") Is Nothing Or myKeys.Doc("GThu_Muc_In_BC37_QT_Den") = "", "", CStr(myKeys.Doc("GThu_Muc_In_BC37_QT_Den")))
        GThu_Muc_In_BV10_QT_Den = IIf(myKeys.Doc("GThu_Muc_In_BV10_QT_Den") Is Nothing Or myKeys.Doc("GThu_Muc_In_BV10_QT_Den") = "", "", CStr(myKeys.Doc("GThu_Muc_In_BV10_QT_Den")))
        GThu_Muc_In_E4_QT_Den = IIf(myKeys.Doc("GThu_Muc_In_E4_QT_Den") Is Nothing Or myKeys.Doc("GThu_Muc_In_E4_QT_Den") = "", "", CStr(myKeys.Doc("GThu_Muc_In_E4_QT_Den")))
        GThu_Muc_In_E2_QT_Den = IIf(myKeys.Doc("GThu_Muc_In_E2_QT_Den") Is Nothing Or myKeys.Doc("GThu_Muc_In_E2_QT_Den") = "", "", CStr(myKeys.Doc("GThu_Muc_In_E2_QT_Den")))

        rdbInkim.Checked = IIf(myKeys.Doc("GIn_Kim_QT_Den") Is Nothing Or myKeys.Doc("GIn_Kim_QT_Den") = "", "False", myKeys.Doc("GIn_Kim_QT_Den"))
        rdbInlaser.Checked = IIf(myKeys.Doc("GIn_Laser_QT_Den") Is Nothing Or myKeys.Doc("GIn_Laser_QT_Den") = "", "False", myKeys.Doc("GIn_Laser_QT_Den"))

        rdbTypePrint1.Checked = IIf(myKeys.Doc("GKieu_In_Map") Is Nothing Or myKeys.Doc("GKieu_In_Map") = "", "False", myKeys.Doc("GKieu_In_Map"))
        GKieu_In_Map = rdbTypePrint1.Checked

        GIn_Laser_QT_Den = rdbInlaser.Checked
        GIn_Kim_QT_Den = rdbInkim.Checked

        GThu_Muc_In_CN35_QT_Di = IIf(myKeys.Doc("GThu_Muc_In_CN35_QT_Di") Is Nothing Or myKeys.Doc("GThu_Muc_In_CN35_QT_Di") = "", "", CStr(myKeys.Doc("GThu_Muc_In_CN35_QT_Di")))
        GTen_May_Tinh_CN35 = IIf(myKeys.Doc("GTen_May_Tinh_CN35") Is Nothing Or myKeys.Doc("GTen_May_Tinh_CN35") = "", "", CStr(myKeys.Doc("GTen_May_Tinh_CN35")))
        GTen_May_In_CN35 = IIf(myKeys.Doc("GTen_May_In_CN35") Is Nothing Or myKeys.Doc("GTen_May_In_CN35") = "", "", CStr(myKeys.Doc("GTen_May_In_CN35")))

        GTen_May_Tinh_BC37 = IIf(myKeys.Doc("GTen_May_Tinh_BC37") Is Nothing Or myKeys.Doc("GTen_May_Tinh_BC37") = "", "", CStr(myKeys.Doc("GTen_May_Tinh_BC37")))
        GTen_May_In_BC37 = IIf(myKeys.Doc("GTen_May_In_BC37") Is Nothing Or myKeys.Doc("GTen_May_In_BC37") = "", "", CStr(myKeys.Doc("GTen_May_In_BC37")))

        GTen_May_Tinh_BV10 = IIf(myKeys.Doc("GTen_May_Tinh_BV10") Is Nothing Or myKeys.Doc("GTen_May_Tinh_BV10") = "", "", CStr(myKeys.Doc("GTen_May_Tinh_BV10")))
        GTen_May_In_BV10 = IIf(myKeys.Doc("GTen_May_In_BV10") Is Nothing Or myKeys.Doc("GTen_May_In_BV10") = "", "", CStr(myKeys.Doc("GTen_May_In_BV10")))

        GTen_May_Tinh_E2 = IIf(myKeys.Doc("GTen_May_Tinh_E2") Is Nothing Or myKeys.Doc("GTen_May_Tinh_E2") = "", "", CStr(myKeys.Doc("GTen_May_Tinh_E2")))
        GTen_May_In_E2 = IIf(myKeys.Doc("GTen_May_In_E2") Is Nothing Or myKeys.Doc("GTen_May_In_E2") = "", "", CStr(myKeys.Doc("GTen_May_In_E2")))

        GTen_May_Tinh_E4 = IIf(myKeys.Doc("GTen_May_Tinh_E4") Is Nothing Or myKeys.Doc("GTen_May_Tinh_E4") = "", "", CStr(myKeys.Doc("GTen_May_Tinh_E4")))
        GTen_May_In_E4 = IIf(myKeys.Doc("GTen_May_In_E4") Is Nothing Or myKeys.Doc("GTen_May_In_E4") = "", "", CStr(myKeys.Doc("GTen_May_In_E4")))

        'Them phan in CN38
        rdbInkimCN38.Checked = IIf(myKeys.Doc("GIn_Kim_QT_Di_CN38") Is Nothing Or myKeys.Doc("GIn_Kim_QT_Di_CN38") = "", "False", myKeys.Doc("GIn_Kim_QT_Di_CN38"))
        rdbInlaserCN38.Checked = IIf(myKeys.Doc("GIn_Laser_QT_Di_CN38") Is Nothing Or myKeys.Doc("GIn_Laser_QT_Di_CN38") = "", "False", myKeys.Doc("GIn_Laser_QT_Di_CN38"))
        rdbTypePrint1_CN38.Checked = IIf(myKeys.Doc("GKieu_In_Map_CN38") Is Nothing Or myKeys.Doc("GKieu_In_Map_CN38") = "", "False", myKeys.Doc("GKieu_In_Map_CN38"))

        GThu_Muc_In_CN38_QT_Di = IIf(myKeys.Doc("GThu_Muc_In_CN38_QT_Di") Is Nothing Or myKeys.Doc("GThu_Muc_In_CN38_QT_Di") = "", "", CStr(myKeys.Doc("GThu_Muc_In_CN38_QT_Di")))
        GTen_May_Tinh_CN38 = IIf(myKeys.Doc("GTen_May_Tinh_CN38") Is Nothing Or myKeys.Doc("GTen_May_Tinh_CN38") = "", "", CStr(myKeys.Doc("GTen_May_Tinh_CN38")))
        GTen_May_In_CN38 = IIf(myKeys.Doc("GTen_May_In_CN38") Is Nothing Or myKeys.Doc("GTen_May_In_CN38") = "", "", CStr(myKeys.Doc("GTen_May_In_CN38")))

        GIn_Laser_QT_Di_CN38 = rdbInlaserCN38.Checked
        GIn_Kim_QT_Di_CN38 = rdbInkimCN38.Checked
        GKieu_In_Map_CN38 = rdbTypePrint1_CN38.Checked


        'Cho phép sửa cước
        gSua_Cuoc_Chinh = IIf(myKeys.Doc("GSua_Cuoc_Chinh") Is Nothing Or myKeys.Doc("GSua_Cuoc_Chinh") = "", "False", CStr(myKeys.Doc("GSua_Cuoc_Chinh")))
        gSua_Cuoc_DV = IIf(myKeys.Doc("GSua_Cuoc_DV") Is Nothing Or myKeys.Doc("GSua_Cuoc_DV") = "", "False", CStr(myKeys.Doc("GSua_Cuoc_DV")))
        gSua_Cuoc_E1 = IIf(myKeys.Doc("GSua_Cuoc_E1") Is Nothing Or myKeys.Doc("GSua_Cuoc_E1") = "", "False", CStr(myKeys.Doc("GSua_Cuoc_E1")))

        '----------------------------------------------------------------------
        'In bản kê Hải quan bưu điện
        GIn_Ban_Ke_HQ_Buu_Dien = IIf(myKeys.Doc("GIn_Ban_Ke_HQ_Buu_Dien") Is Nothing Or myKeys.Doc("GIn_Ban_Ke_HQ_Buu_Dien") = "", "False", CStr(myKeys.Doc("GIn_Ban_Ke_HQ_Buu_Dien")))
        'In bản kê BV10 theo ngày đóng
        GIn_Ban_Ke_BV10_Theo_Ngay_Dong = IIf(myKeys.Doc("GIn_Ban_Ke_BV10_Theo_Ngay_Dong") Is Nothing Or myKeys.Doc("GIn_Ban_Ke_BV10_Theo_Ngay_Dong") = "", "False", CStr(myKeys.Doc("GIn_Ban_Ke_BV10_Theo_Ngay_Dong")))
        '-----------------------------------------------------
        'In bản kê E2 theo mẫu mới
        GIn_Ban_Ke_E2_To_Text_Second = IIf(myKeys.Doc("GIn_Ban_Ke_E2_To_Text_Second") Is Nothing Or myKeys.Doc("GIn_Ban_Ke_E2_To_Text_Second") = "", "False", CStr(myKeys.Doc("GIn_Ban_Ke_E2_To_Text_Second")))
        'In bản kê BV10 theo mẫu mới
        GIn_Ban_Ke_BV10_To_Text_Second = IIf(myKeys.Doc("GIn_Ban_Ke_BV10_To_Text_Second") Is Nothing Or myKeys.Doc("GIn_Ban_Ke_BV10_To_Text_Second") = "", "False", CStr(myKeys.Doc("GIn_Ban_Ke_BV10_To_Text_Second")))
        'In bản kê BC37 theo mẫu mới
        GIn_Ban_Ke_BC37_To_Text_Second = IIf(myKeys.Doc("GIn_Ban_Ke_BC37_To_Text_Second") Is Nothing Or myKeys.Doc("GIn_Ban_Ke_BC37_To_Text_Second") = "", "False", CStr(myKeys.Doc("GIn_Ban_Ke_BC37_To_Text_Second")))

        '----------------------------------------------------------------------
        'Số dòng trên một trang in E2
        GSo_Dong_Trong_Trang_In_Ban_Ke_E2 = IIf(myKeys.Doc("GSo_Dong_Trong_Trang_In_Ban_Ke_E2") Is Nothing Or myKeys.Doc("GSo_Dong_Trong_Trang_In_Ban_Ke_E2") = "", "40", myKeys.Doc("GSo_Dong_Trong_Trang_In_Ban_Ke_E2"))
        'Số dòng trên một trang in BC37
        GSo_Dong_Trong_Trang_In_Ban_Ke_BC37 = IIf(myKeys.Doc("GSo_Dong_Trong_Trang_In_Ban_Ke_BC37") Is Nothing Or myKeys.Doc("GSo_Dong_Trong_Trang_In_Ban_Ke_BC37") = "", "39", myKeys.Doc("GSo_Dong_Trong_Trang_In_Ban_Ke_BC37"))
        'Số dòng trên một trang in BV10
        GSo_Dong_Trong_Trang_In_Ban_Ke_BV10 = IIf(myKeys.Doc("GSo_Dong_Trong_Trang_In_Ban_Ke_BV10") Is Nothing Or myKeys.Doc("GSo_Dong_Trong_Trang_In_Ban_Ke_BV10") = "", "39", myKeys.Doc("GSo_Dong_Trong_Trang_In_Ban_Ke_BV10"))

        '------------------------------------------------------------------
        'Thiết lập in bản kê BV10 quốc tế đi
        GIn_Kim_BV10_QT_Di = IIf(myKeys.Doc("GIn_Kim_BV10_QT_Di") Is Nothing Or myKeys.Doc("GIn_Kim_BV10_QT_Di") = "", "False", myKeys.Doc("GIn_Kim_BV10_QT_Di"))
        GIn_Tren_Server_BV10_QT_Di = IIf(myKeys.Doc("GIn_Tren_Server_BV10_QT_Di") Is Nothing Or myKeys.Doc("GIn_Tren_Server_BV10_QT_Di") = "", "False", myKeys.Doc("GIn_Tren_Server_BV10_QT_Di"))
        GThu_Muc_In_BV10_QT_Di = IIf(myKeys.Doc("GThu_Muc_In_BV10_QT_Di") Is Nothing Or myKeys.Doc("GThu_Muc_In_BV10_QT_Di") = "", "", myKeys.Doc("GThu_Muc_In_BV10_QT_Di"))
        GMay_Tinh_In_BV10_QT_Di = IIf(myKeys.Doc("GMay_Tinh_In_BV10_QT_Di") Is Nothing Or myKeys.Doc("GMay_Tinh_In_BV10_QT_Di") = "", "", myKeys.Doc("GMay_Tinh_In_BV10_QT_Di"))
        GMay_In_BV10_QT_Di = IIf(myKeys.Doc("GMay_In_BV10_QT_Di") Is Nothing Or myKeys.Doc("GMay_In_BV10_QT_Di") = "", "", myKeys.Doc("GMay_In_BV10_QT_Di"))
        '------------------------------------------------------------------
        'Thiết lập in bản kê BV10 trong nước
        GIn_Kim_BV10_Trong_Nuoc = IIf(myKeys.Doc("GIn_Kim_BV10_Trong_Nuoc") Is Nothing Or myKeys.Doc("GIn_Kim_BV10_Trong_Nuoc") = "", "False", myKeys.Doc("GIn_Kim_BV10_Trong_Nuoc"))
        GIn_Tren_Server_BV10_Trong_Nuoc = IIf(myKeys.Doc("GIn_Tren_Server_BV10_Trong_Nuoc") Is Nothing Or myKeys.Doc("GIn_Tren_Server_BV10_Trong_Nuoc") = "", "False", myKeys.Doc("GIn_Tren_Server_BV10_Trong_Nuoc"))
        GThu_Muc_In_BV10_Trong_Nuoc = IIf(myKeys.Doc("GThu_Muc_In_BV10_Trong_Nuoc") Is Nothing Or myKeys.Doc("GThu_Muc_In_BV10_Trong_Nuoc") = "", "", myKeys.Doc("GThu_Muc_In_BV10_Trong_Nuoc"))
        GMay_Tinh_In_BV10_Trong_Nuoc = IIf(myKeys.Doc("GMay_Tinh_In_BV10_Trong_Nuoc") Is Nothing Or myKeys.Doc("GMay_Tinh_In_BV10_Trong_Nuoc") = "", "", myKeys.Doc("GMay_Tinh_In_BV10_Trong_Nuoc"))
        GMay_In_BV10_Trong_Nuoc = IIf(myKeys.Doc("GMay_In_BV10_Trong_Nuoc") Is Nothing Or myKeys.Doc("GMay_In_BV10_Trong_Nuoc") = "", "", myKeys.Doc("GMay_In_BV10_Trong_Nuoc"))

        'In E4
        GKieu_In_E4_New = IIf(myKeys.Doc("KieuInE4New") Is Nothing Or myKeys.Doc("KieuInE4New") = "", False, IIf(myKeys.Doc("KieuInE4New") = "1", True, False))
        GTen_May_In_E4_New = IIf(myKeys.Doc("TenMayInE4New") Is Nothing Or myKeys.Doc("TenMayInE4New") = "", "", myKeys.Doc("TenMayInE4New"))
    End Sub
#End Region

#Region "--------------FrmThietLapThamSoHeThong_Load--------------"
    Private Sub FrmThietLapThamSoHeThong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetKeys()
        txtInbc37.Text = GThu_Muc_In_BC37_QT_Den

        txtInE2.Text = GThu_Muc_In_E2_QT_Den
        txtInE4.Text = GThu_Muc_In_E4_QT_Den

        txtInCN35.Text = GThu_Muc_In_CN35_QT_Di

        txtSongaykiemtrae1trung.Text = GSo_Ngay_E1_Duoc_Trung
        txtTrongLuongE1Max.Text = GTrong_Luong_E1_Max

        rdbInlaser.Checked = GIn_Laser_QT_Den
        rdbInkim.Checked = GIn_Kim_QT_Den

        rdbTypePrint1.Checked = GKieu_In_Map
        rdbTypePrint2.Checked = Not GKieu_In_Map

        rdbTypePrint1_CheckedChanged(rdbTypePrint1, e)
        rdbTypePrint2_CheckedChanged(rdbTypePrint2, e)

        txtServer.Text = GTen_May_Tinh_CN35
        txtPrinter.Text = GTen_May_In_CN35

        txtMayTinhBC37.Text = GTen_May_Tinh_BC37
        txtMayInBC37.Text = GTen_May_In_BC37

        txtMayTinhE2.Text = GTen_May_Tinh_E2
        txtMayInE2.Text = GTen_May_In_E2

        txtMayTinhE4.Text = GTen_May_Tinh_E4
        txtMayInE4.Text = GTen_May_In_E4

        'Them phan in CN38
        rdbInlaserCN38.Checked = GIn_Laser_QT_Di_CN38
        rdbInkimCN38.Checked = GIn_Kim_QT_Di_CN38
        rdbTypePrint1_CN38.Checked = GKieu_In_Map_CN38
        rdbTypePrint2_CN38.Checked = Not GKieu_In_Map_CN38

        rdbTypePrint1_CN38_CheckedChanged(rdbTypePrint1_CN38, e)
        rdbTypePrint2_CN38_CheckedChanged(rdbTypePrint2_CN38, e)

        txtInCN38.Text = GThu_Muc_In_CN38_QT_Di
        txtMayTinhCN38.Text = GTen_May_Tinh_CN38
        txtMayInCN38.Text = GTen_May_In_CN38

        'Thiết lập thông tin sửa cước
        chk_Sua_Cuoc_Chinh.Checked = gSua_Cuoc_Chinh
        chk_Sua_Cuoc_DV.Checked = gSua_Cuoc_DV
        chk_Sua_Cuoc_E1.Checked = gSua_Cuoc_E1

        'In bản kê HQ bưu điện
        chk_In_HQ_Buu_Dien.Checked = GIn_Ban_Ke_HQ_Buu_Dien
        chk_In_Ban_Ke_BV10_Theo_Ngay_Dong.Checked = GIn_Ban_Ke_BV10_Theo_Ngay_Dong

        chk_In_E2_To_Text_Second.Checked = GIn_Ban_Ke_E2_To_Text_Second
        chk_In_BC37_To_Text_Second.Checked = GIn_Ban_Ke_BC37_To_Text_Second
        chk_In_Bv10_To_Text_Second.Checked = GIn_Ban_Ke_BV10_To_Text_Second

        'Số dòng trên một trang in bản kê
        txt_So_Dong_Trong_Trang_In_Ban_Ke_E2.Text = GSo_Dong_Trong_Trang_In_Ban_Ke_E2
        txt_So_Dong_Trong_Trang_In_Ban_Ke_BC37.Text = GSo_Dong_Trong_Trang_In_Ban_Ke_BC37
        txt_So_Dong_Trong_Trang_In_Ban_Ke_BV10.Text = GSo_Dong_Trong_Trang_In_Ban_Ke_BV10

        'Chưa sử dụng BV10 mới
        chk_In_Bv10_To_Text_Second.Enabled = False
        txt_So_Dong_Trong_Trang_In_Ban_Ke_BV10.Enabled = False

        'Thiết lập in bản kê BV10 quốc tế đi
        rdb_In_Kim_BV10_QT_Di.Checked = GIn_Kim_BV10_QT_Di
        rdb_In_Tren_Server_BV10_QT_Di.Checked = GIn_Tren_Server_BV10_QT_Di
        txt_Thu_Muc_In_BV10_QT_Di.Text = GThu_Muc_In_BV10_QT_Di
        txt_May_Tinh_In_BV10_QT_Di.Text = GMay_Tinh_In_BV10_QT_Di
        txt_May_In_BV10_QT_Di.Text = GMay_In_BV10_QT_Di

        'Thiết lập in bản kê BV10 Trong nước
        rdb_In_Kim_BV10_Trong_Nuoc.Checked = GIn_Kim_BV10_Trong_Nuoc
        rdb_In_Tren_Server_BV10_Trong_Nuoc.Checked = GIn_Tren_Server_BV10_Trong_Nuoc
        txt_Thu_Muc_In_BV10_Trong_Nuoc.Text = GThu_Muc_In_BV10_Trong_Nuoc
        txt_May_Tinh_In_BV10_Trong_Nuoc.Text = GMay_Tinh_In_BV10_Trong_Nuoc
        txt_May_In_BV10_Trong_Nuoc.Text = GMay_In_BV10_Trong_Nuoc

        'In E4 New
        chkInE4_New.Checked = IIf(myKeys.Doc("KieuInE4New") Is Nothing Or myKeys.Doc("KieuInE4New") = "", False, IIf(myKeys.Doc("KieuInE4New") = "1", True, False))
        chkInE4_New_CheckedChanged(chkInE4_New, Nothing)

        txtmayinE4NEW.Text = IIf(myKeys.Doc("TenMayInE4New") Is Nothing Or myKeys.Doc("TenMayInE4New") = "", "", myKeys.Doc("TenMayInE4New"))
    End Sub
#End Region

#Region "--------------radiobutton_CheckedChanged--------------"
    Private Sub rdbInlaser_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbInlaser.CheckedChanged
        If (rdbInlaser.Checked = True) Then
            grbCauhinhinkim.Enabled = False
        Else
            grbCauhinhinkim.Enabled = True
        End If
    End Sub

    Private Sub rdbInkim_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbInkim.CheckedChanged
        If (rdbInkim.Checked = True) Then
            grbCauhinhinkim.Enabled = True
        Else
            grbCauhinhinkim.Enabled = False
        End If
    End Sub
#End Region

#Region "--------------FrmThietLapThamSoHeThong_Closing--------------"
    Private Sub FrmThietLapThamSoHeThong_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        SetKeys()
        GetKeys()
    End Sub
#End Region

#Region "---------------Check_Box_CheckedChanged---------------"
    Private Sub rdbTypePrint1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbTypePrint1.CheckedChanged
        If rdbTypePrint1.Checked = True Then
            txtInbc37.Enabled = True
            txtInE2.Enabled = True
            txtInE4.Enabled = True
            txtInCN35.Enabled = True
            txtInbc37.Focus()
        Else
            txtInbc37.Enabled = False
            txtInE2.Enabled = False
            txtInE4.Enabled = False
            txtInCN35.Enabled = False
        End If
    End Sub

    Private Sub rdbTypePrint2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbTypePrint2.CheckedChanged
        If rdbTypePrint2.Checked = True Then
            txtMayTinhBC37.Enabled = True
            txtMayInBC37.Enabled = True
            txtMayTinhE2.Enabled = True
            txtMayInE2.Enabled = True
            txtMayTinhE4.Enabled = True
            txtMayInE4.Enabled = True
            txtServer.Enabled = True
            txtPrinter.Enabled = True
            txtMayTinhBC37.Focus()
        Else
            txtMayTinhBC37.Enabled = False
            txtMayInBC37.Enabled = False
            txtMayTinhE2.Enabled = False
            txtMayInE2.Enabled = False
            txtMayTinhE4.Enabled = False
            txtMayInE4.Enabled = False
            txtServer.Enabled = False
            txtPrinter.Enabled = False
        End If
    End Sub

    Private Sub rdbTypePrint1_CN38_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbTypePrint1_CN38.CheckedChanged
        If rdbTypePrint1_CN38.Checked = True Then
            txtInCN38.Enabled = True
            txtMayTinhCN38.Enabled = False
            txtMayInCN38.Enabled = False
            txtInCN38.Select()
        Else
            txtInCN38.Enabled = False
            txtMayTinhCN38.Enabled = True
            txtMayInCN38.Enabled = True
            txtMayTinhCN38.Select()
        End If
    End Sub

    Private Sub rdbInlaserCN38_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbInlaserCN38.CheckedChanged
        GrbCN38.Enabled = Not rdbInlaserCN38.Checked
    End Sub

    Private Sub rdbTypePrint2_CN38_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbTypePrint2_CN38.CheckedChanged
        If rdbTypePrint2_CN38.Checked = True Then
            txtInCN38.Enabled = False
            txtMayTinhCN38.Enabled = True
            txtMayInCN38.Enabled = True
            txtMayTinhCN38.Select()
        Else
            txtInCN38.Enabled = True
            txtMayTinhCN38.Enabled = False
            txtMayInCN38.Enabled = False
            txtInCN38.Select()
        End If
    End Sub
#End Region

#Region "---------------KeyDown: Enter---------------"
    Private Sub txtServer_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then txtPrinter.Focus()
    End Sub

    Private Sub txtInbc37_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtInbc37.KeyDown
        If e.KeyCode = Keys.Enter Then txtInE2.Focus()
    End Sub

    Private Sub txtMayTinhBC37_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMayTinhBC37.KeyDown
        If e.KeyCode = Keys.Enter Then txtMayInBC37.Focus()
    End Sub

    Private Sub txtMayInBC37_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMayInBC37.KeyDown
        If e.KeyCode = Keys.Enter Then txtMayTinhE2.Focus()
    End Sub

    Private Sub txtInE2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtInE2.KeyDown
        If e.KeyCode = Keys.Enter Then txtInE4.Focus()
    End Sub

    Private Sub txtMayTinhE2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMayTinhE2.KeyDown
        If e.KeyCode = Keys.Enter Then txtMayInE2.Focus()
    End Sub

    Private Sub txtMayInE2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMayInE2.KeyDown
        If e.KeyCode = Keys.Enter Then txtMayTinhE4.Focus()
    End Sub

    Private Sub txtInE4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtInE4.KeyDown
        'If e.KeyCode = Keys.Enter Then txtInbv10.Focus()
    End Sub

    Private Sub txtMayTinhE4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMayTinhE4.KeyDown
        If e.KeyCode = Keys.Enter Then txtMayInE4.Focus()
    End Sub

    Private Sub txtMayInE4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMayInE4.KeyDown
        'If e.KeyCode = Keys.Enter Then txtMayTinhBV10.Focus()
    End Sub

    Private Sub txtInCN35_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then txtServer.Focus()
    End Sub

    Private Sub txtInbv10_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then txtInCN35.Focus()
    End Sub

    Private Sub txtMayTinhBV10_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'If e.KeyCode = Keys.Enter Then txtMayInBV10.Focus()
    End Sub

    Private Sub txtMayInBV10_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then txtServer.Focus()
    End Sub

    Private Sub txtMayTinhCN38_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then txtMayInCN38.Select()
    End Sub
#End Region

#Region "---------------Thiết lập in bản kê Mới---------------"
    Private Sub chk_In_E2_To_Text_Second_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_In_E2_To_Text_Second.CheckedChanged
        txt_So_Dong_Trong_Trang_In_Ban_Ke_E2.Enabled = chk_In_E2_To_Text_Second.Checked
    End Sub

    Private Sub chk_In_BC37_To_Text_Second_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_In_BC37_To_Text_Second.CheckedChanged
        txt_So_Dong_Trong_Trang_In_Ban_Ke_BC37.Enabled = chk_In_BC37_To_Text_Second.Checked
    End Sub

    Private Sub chk_In_Bv10_To_Text_Second_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_In_Bv10_To_Text_Second.CheckedChanged
        txt_So_Dong_Trong_Trang_In_Ban_Ke_BV10.Enabled = chk_In_Bv10_To_Text_Second.Checked
    End Sub
#End Region

#Region "---------------Thiết lập in bản kê BV10 Quốc tế đi---------------"
    Private Sub rdb_In_Laser_BV10_QT_Di_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_In_Laser_BV10_QT_Di.CheckedChanged
        Thiet_Lap_In_BV10_QT_Di()
    End Sub

    Private Sub rdb_In_Kim_BV10_QT_Di_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_In_Kim_BV10_QT_Di.CheckedChanged
        Thiet_Lap_In_BV10_QT_Di()
    End Sub

    Private Sub rdb_In_Tren_Server_BV10_QT_Di_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_In_Tren_Server_BV10_QT_Di.CheckedChanged
        Thiet_Lap_In_BV10_QT_Di()
    End Sub

    Private Sub rdb_In_Truc_Tiep_BV10_QT_Di_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_In_Truc_Tiep_BV10_QT_Di.CheckedChanged
        Thiet_Lap_In_BV10_QT_Di()
    End Sub

    Private Sub Thiet_Lap_In_BV10_QT_Di()
        If rdb_In_Kim_BV10_QT_Di.Checked = True Then
            Group_Thiet_Lap_In_Kim_BV10_QT_Di.Enabled = True
            txt_Thu_Muc_In_BV10_QT_Di.Enabled = rdb_In_Tren_Server_BV10_QT_Di.Checked

            txt_May_Tinh_In_BV10_QT_Di.Enabled = Not rdb_In_Tren_Server_BV10_QT_Di.Checked
            txt_May_In_BV10_QT_Di.Enabled = Not rdb_In_Tren_Server_BV10_QT_Di.Checked
        Else
            Group_Thiet_Lap_In_Kim_BV10_QT_Di.Enabled = False
        End If
    End Sub
#End Region

#Region "---------------Thiết lập in bản kê BV10 Trong nước---------------"
    Private Sub rdb_In_Laser_BV10_Trong_Nuoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_In_Laser_BV10_Trong_Nuoc.CheckedChanged
        Thiet_Lap_In_BV10_Trong_Nuoc()
    End Sub

    Private Sub rdb_In_Kim_BV10_Trong_Nuoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_In_Kim_BV10_Trong_Nuoc.CheckedChanged
        Thiet_Lap_In_BV10_Trong_Nuoc()
    End Sub

    Private Sub rdb_In_Tren_Server_BV10_Trong_Nuoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_In_Tren_Server_BV10_Trong_Nuoc.CheckedChanged
        Thiet_Lap_In_BV10_Trong_Nuoc()
    End Sub

    Private Sub rdb_In_Truc_Tiep_BV10_Trong_Nuoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_In_Truc_Tiep_BV10_Trong_Nuoc.CheckedChanged
        Thiet_Lap_In_BV10_Trong_Nuoc()
    End Sub

    Private Sub Thiet_Lap_In_BV10_Trong_Nuoc()
        If rdb_In_Kim_BV10_Trong_Nuoc.Checked = True Then
            Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc.Enabled = True
            txt_Thu_Muc_In_BV10_Trong_Nuoc.Enabled = rdb_In_Tren_Server_BV10_Trong_Nuoc.Checked

            txt_May_Tinh_In_BV10_Trong_Nuoc.Enabled = Not rdb_In_Tren_Server_BV10_Trong_Nuoc.Checked
            txt_May_In_BV10_Trong_Nuoc.Enabled = Not rdb_In_Tren_Server_BV10_Trong_Nuoc.Checked
        Else
            Group_Thiet_Lap_In_Kim_BV10_Trong_Nuoc.Enabled = False
        End If
    End Sub
#End Region

    Private Sub bntinE4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntinE4.Click
        Try
            Dim ps As New PrinterSettings
            Printer.PrinterSettings = ps
            If Me.Printer.ShowDialog = DialogResult.OK Then
                myKeys.Ghi("mayinE4NEW", Printer.PrinterSettings.PrinterName)
                txtmayinE4NEW.Text = Printer.PrinterSettings.PrinterName
                If chkE4.Checked Then
                    'myPrint.AddCustomPaperSize(txtmayinE4.Text, "Ems_E4", 133.0F, 63.0F)
                    myPrint.AddCustomPaperSize(txtmayinE4NEW.Text, "Ems_E4", 77.0F, 127.0F)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub chkInE4_New_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkInE4_New.CheckedChanged
        txtInE4.Enabled = Not chkInE4_New.Checked
        txtMayInE4.Enabled = Not chkInE4_New.Checked
        txtMayTinhE4.Enabled = Not chkInE4_New.Checked
        grbInE4NEW.Enabled = chkInE4_New.Checked
    End Sub

    Private Sub chkE4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkE4.CheckedChanged

    End Sub
End Class

Public Class FrmVaoCa
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
    Friend WithEvents _FrmVaoCaUnpinnedTabAreaLeft As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _FrmVaoCaUnpinnedTabAreaRight As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _FrmVaoCaUnpinnedTabAreaTop As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _FrmVaoCaUnpinnedTabAreaBottom As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _FrmVaoCaAutoHideControl As Infragistics.Win.UltraWinDock.AutoHideControl
    Friend WithEvents Task_Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnDesktop As Infragistics.Win.Misc.UltraButton
    Friend WithEvents SeperatorDoc As System.Windows.Forms.GroupBox
    Friend WithEvents lblClock As System.Windows.Forms.Label
    Friend WithEvents btnDongY As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnThoat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblPhongBan As System.Windows.Forms.Label
    Friend WithEvents lblNguoiDung As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTimeLogin As System.Windows.Forms.Label
    Friend WithEvents CalendarView As Calendar.MyCalendar.Calendar
    Friend WithEvents Clock As System.Windows.Forms.PictureBox
    Friend WithEvents ExplorerBarMenu As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar
    Friend WithEvents statusBar As Infragistics.Win.UltraWinStatusBar.UltraStatusBar
    Friend WithEvents UltraDockManager1 As Infragistics.Win.UltraWinDock.UltraDockManager
    Friend WithEvents TimeClock As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmVaoCa))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraExplorerBarGroup1 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup
        Dim UltraExplorerBarItem1 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem2 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem3 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem4 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem5 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem6 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem7 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarGroup2 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup
        Dim UltraExplorerBarItem8 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem9 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem10 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem11 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem12 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem13 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem14 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem15 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarGroup3 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup
        Dim UltraExplorerBarItem16 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem17 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarGroup4 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup
        Dim UltraExplorerBarItem18 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarGroup5 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup
        Dim UltraExplorerBarItem19 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem20 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem21 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarGroup6 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup
        Dim UltraExplorerBarItem22 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem23 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem24 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraStatusPanel1 As Infragistics.Win.UltraWinStatusBar.UltraStatusPanel = New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel
        Dim UltraStatusPanel2 As Infragistics.Win.UltraWinStatusBar.UltraStatusPanel = New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel
        Dim UltraStatusPanel3 As Infragistics.Win.UltraWinStatusBar.UltraStatusPanel = New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel
        Me._FrmVaoCaUnpinnedTabAreaLeft = New Infragistics.Win.UltraWinDock.UnpinnedTabArea
        Me._FrmVaoCaUnpinnedTabAreaRight = New Infragistics.Win.UltraWinDock.UnpinnedTabArea
        Me._FrmVaoCaUnpinnedTabAreaTop = New Infragistics.Win.UltraWinDock.UnpinnedTabArea
        Me._FrmVaoCaUnpinnedTabAreaBottom = New Infragistics.Win.UltraWinDock.UnpinnedTabArea
        Me._FrmVaoCaAutoHideControl = New Infragistics.Win.UltraWinDock.AutoHideControl
        Me.Task_Panel1 = New System.Windows.Forms.Panel
        Me.btnDesktop = New Infragistics.Win.Misc.UltraButton
        Me.SeperatorDoc = New System.Windows.Forms.GroupBox
        Me.lblClock = New System.Windows.Forms.Label
        Me.btnDongY = New Infragistics.Win.Misc.UltraButton
        Me.btnThoat = New Infragistics.Win.Misc.UltraButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblPhongBan = New System.Windows.Forms.Label
        Me.lblNguoiDung = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.lblTimeLogin = New System.Windows.Forms.Label
        Me.CalendarView = New Calendar.MyCalendar.Calendar
        Me.Clock = New System.Windows.Forms.PictureBox
        Me.ExplorerBarMenu = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar
        Me.statusBar = New Infragistics.Win.UltraWinStatusBar.UltraStatusBar
        Me.UltraDockManager1 = New Infragistics.Win.UltraWinDock.UltraDockManager(Me.components)
        Me.TimeClock = New System.Windows.Forms.Timer(Me.components)
        Me.Task_Panel1.SuspendLayout()
        CType(Me.ExplorerBarMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_FrmVaoCaUnpinnedTabAreaLeft
        '
        Me._FrmVaoCaUnpinnedTabAreaLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me._FrmVaoCaUnpinnedTabAreaLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FrmVaoCaUnpinnedTabAreaLeft.Location = New System.Drawing.Point(0, 0)
        Me._FrmVaoCaUnpinnedTabAreaLeft.Name = "_FrmVaoCaUnpinnedTabAreaLeft"
        Me._FrmVaoCaUnpinnedTabAreaLeft.Owner = Me.UltraDockManager1
        Me._FrmVaoCaUnpinnedTabAreaLeft.Size = New System.Drawing.Size(0, 537)
        Me._FrmVaoCaUnpinnedTabAreaLeft.TabIndex = 0
        '
        '_FrmVaoCaUnpinnedTabAreaRight
        '
        Me._FrmVaoCaUnpinnedTabAreaRight.Dock = System.Windows.Forms.DockStyle.Right
        Me._FrmVaoCaUnpinnedTabAreaRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FrmVaoCaUnpinnedTabAreaRight.Location = New System.Drawing.Point(791, 0)
        Me._FrmVaoCaUnpinnedTabAreaRight.Name = "_FrmVaoCaUnpinnedTabAreaRight"
        Me._FrmVaoCaUnpinnedTabAreaRight.Owner = Me.UltraDockManager1
        Me._FrmVaoCaUnpinnedTabAreaRight.Size = New System.Drawing.Size(0, 537)
        Me._FrmVaoCaUnpinnedTabAreaRight.TabIndex = 1
        '
        '_FrmVaoCaUnpinnedTabAreaTop
        '
        Me._FrmVaoCaUnpinnedTabAreaTop.Dock = System.Windows.Forms.DockStyle.Top
        Me._FrmVaoCaUnpinnedTabAreaTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FrmVaoCaUnpinnedTabAreaTop.Location = New System.Drawing.Point(0, 0)
        Me._FrmVaoCaUnpinnedTabAreaTop.Name = "_FrmVaoCaUnpinnedTabAreaTop"
        Me._FrmVaoCaUnpinnedTabAreaTop.Owner = Me.UltraDockManager1
        Me._FrmVaoCaUnpinnedTabAreaTop.Size = New System.Drawing.Size(791, 0)
        Me._FrmVaoCaUnpinnedTabAreaTop.TabIndex = 2
        '
        '_FrmVaoCaUnpinnedTabAreaBottom
        '
        Me._FrmVaoCaUnpinnedTabAreaBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._FrmVaoCaUnpinnedTabAreaBottom.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FrmVaoCaUnpinnedTabAreaBottom.Location = New System.Drawing.Point(0, 537)
        Me._FrmVaoCaUnpinnedTabAreaBottom.Name = "_FrmVaoCaUnpinnedTabAreaBottom"
        Me._FrmVaoCaUnpinnedTabAreaBottom.Owner = Me.UltraDockManager1
        Me._FrmVaoCaUnpinnedTabAreaBottom.Size = New System.Drawing.Size(791, 0)
        Me._FrmVaoCaUnpinnedTabAreaBottom.TabIndex = 3
        '
        '_FrmVaoCaAutoHideControl
        '
        Me._FrmVaoCaAutoHideControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FrmVaoCaAutoHideControl.Location = New System.Drawing.Point(0, 0)
        Me._FrmVaoCaAutoHideControl.Name = "_FrmVaoCaAutoHideControl"
        Me._FrmVaoCaAutoHideControl.Owner = Me.UltraDockManager1
        Me._FrmVaoCaAutoHideControl.TabIndex = 4
        '
        'Task_Panel1
        '
        Me.Task_Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Task_Panel1.Controls.Add(Me.btnDesktop)
        Me.Task_Panel1.Controls.Add(Me.SeperatorDoc)
        Me.Task_Panel1.Controls.Add(Me.lblClock)
        Me.Task_Panel1.Controls.Add(Me.btnDongY)
        Me.Task_Panel1.Controls.Add(Me.btnThoat)
        Me.Task_Panel1.Controls.Add(Me.GroupBox2)
        Me.Task_Panel1.Controls.Add(Me.PictureBox1)
        Me.Task_Panel1.Controls.Add(Me.lblPhongBan)
        Me.Task_Panel1.Controls.Add(Me.lblNguoiDung)
        Me.Task_Panel1.Controls.Add(Me.PictureBox3)
        Me.Task_Panel1.Controls.Add(Me.PictureBox2)
        Me.Task_Panel1.Controls.Add(Me.lblTimeLogin)
        Me.Task_Panel1.Controls.Add(Me.CalendarView)
        Me.Task_Panel1.Controls.Add(Me.Clock)
        Me.Task_Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Task_Panel1.DockPadding.Left = 65
        Me.Task_Panel1.Location = New System.Drawing.Point(558, 0)
        Me.Task_Panel1.Name = "Task_Panel1"
        Me.Task_Panel1.Size = New System.Drawing.Size(233, 537)
        Me.Task_Panel1.TabIndex = 6
        '
        'btnDesktop
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.btnDesktop.Appearance = Appearance1
        Me.btnDesktop.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.btnDesktop.Location = New System.Drawing.Point(42, 408)
        Me.btnDesktop.Name = "btnDesktop"
        Me.btnDesktop.Size = New System.Drawing.Size(149, 41)
        Me.btnDesktop.TabIndex = 44
        Me.btnDesktop.Text = "Hiện Desktop"
        '
        'SeperatorDoc
        '
        Me.SeperatorDoc.BackColor = System.Drawing.Color.SlateGray
        Me.SeperatorDoc.Location = New System.Drawing.Point(0, -937)
        Me.SeperatorDoc.Name = "SeperatorDoc"
        Me.SeperatorDoc.Size = New System.Drawing.Size(1, 2571)
        Me.SeperatorDoc.TabIndex = 43
        Me.SeperatorDoc.TabStop = False
        '
        'lblClock
        '
        Me.lblClock.BackColor = System.Drawing.Color.Transparent
        Me.lblClock.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblClock.Location = New System.Drawing.Point(31, 231)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(168, 31)
        Me.lblClock.TabIndex = 1
        Me.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDongY
        '
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.btnDongY.Appearance = Appearance2
        Me.btnDongY.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.btnDongY.Location = New System.Drawing.Point(42, 447)
        Me.btnDongY.Name = "btnDongY"
        Me.btnDongY.Size = New System.Drawing.Size(149, 42)
        Me.btnDongY.TabIndex = 5
        Me.btnDongY.Text = "Đổi người dùng"
        '
        'btnThoat
        '
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        Me.btnThoat.Appearance = Appearance3
        Me.btnThoat.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.btnThoat.Location = New System.Drawing.Point(42, 489)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(149, 39)
        Me.btnThoat.TabIndex = 6
        Me.btnThoat.Text = "Thoát"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(9, 400)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(234, 4)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 360)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'lblPhongBan
        '
        Me.lblPhongBan.BackColor = System.Drawing.Color.Transparent
        Me.lblPhongBan.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.lblPhongBan.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPhongBan.Location = New System.Drawing.Point(47, 360)
        Me.lblPhongBan.Name = "lblPhongBan"
        Me.lblPhongBan.Size = New System.Drawing.Size(186, 41)
        Me.lblPhongBan.TabIndex = 4
        Me.lblPhongBan.Text = "Phòng Kinh tế kế hoạch"
        '
        'lblNguoiDung
        '
        Me.lblNguoiDung.BackColor = System.Drawing.Color.Transparent
        Me.lblNguoiDung.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.lblNguoiDung.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblNguoiDung.Location = New System.Drawing.Point(47, 280)
        Me.lblNguoiDung.Name = "lblNguoiDung"
        Me.lblNguoiDung.Size = New System.Drawing.Size(177, 41)
        Me.lblNguoiDung.TabIndex = 2
        Me.lblNguoiDung.Text = "Nguyễn Thị Quỳnh Nga"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(9, 320)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(28, 34)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 39
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(9, 280)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 38
        Me.PictureBox2.TabStop = False
        '
        'lblTimeLogin
        '
        Me.lblTimeLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeLogin.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.lblTimeLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTimeLogin.Location = New System.Drawing.Point(47, 320)
        Me.lblTimeLogin.Name = "lblTimeLogin"
        Me.lblTimeLogin.Size = New System.Drawing.Size(186, 30)
        Me.lblTimeLogin.TabIndex = 3
        Me.lblTimeLogin.Text = "Login lúc: 11:01 PM"
        '
        'CalendarView
        '
        Me.CalendarView.AdjustImageLocation = New System.Drawing.Point(0, 0)
        Me.CalendarView.BtnShape = Calendar.MyCalendar.emunType.BtnShape.Rectangle
        Me.CalendarView.BtnStyle = Calendar.MyCalendar.emunType.XPStyle.Default
        Me.CalendarView.ColorSystem = True
        Me.CalendarView.Location = New System.Drawing.Point(71, 8)
        Me.CalendarView.Name = "CalendarView"
        Me.CalendarView.Ngaylamviec = New Date(2007, 2, 24, 10, 14, 22, 948)
        Me.CalendarView.Size = New System.Drawing.Size(90, 115)
        Me.CalendarView.TabIndex = 0
        '
        'Clock
        '
        Me.Clock.BackColor = System.Drawing.Color.Transparent
        Me.Clock.Image = CType(resources.GetObject("Clock.Image"), System.Drawing.Image)
        Me.Clock.Location = New System.Drawing.Point(71, 136)
        Me.Clock.Name = "Clock"
        Me.Clock.Size = New System.Drawing.Size(90, 90)
        Me.Clock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Clock.TabIndex = 34
        Me.Clock.TabStop = False
        '
        'ExplorerBarMenu
        '
        Me.ExplorerBarMenu.AcceptsFocus = Infragistics.Win.DefaultableBoolean.True
        Me.ExplorerBarMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExplorerBarMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.ExplorerBarMenu.Font = New System.Drawing.Font("Tahoma", 8.0!)
        UltraExplorerBarGroup1.Expanded = False
        UltraExplorerBarItem1.Key = "HT1"
        UltraExplorerBarItem1.Text = "Xác nhận ca"
        UltraExplorerBarItem2.Key = "HT2"
        UltraExplorerBarItem2.Text = "Các bảng danh mục"
        UltraExplorerBarItem3.Key = "HT3"
        UltraExplorerBarItem3.Text = "Các bảng danh mục cước"
        UltraExplorerBarItem4.Key = "HT4"
        UltraExplorerBarItem4.Text = "Thông tin người dùng"
        UltraExplorerBarItem5.Key = "HT5"
        UltraExplorerBarItem5.Text = "Quản lý người dùng"
        UltraExplorerBarItem6.Key = "HT6"
        UltraExplorerBarItem6.Text = "Thông tin hệ thống"
        UltraExplorerBarItem7.Key = "HT7"
        UltraExplorerBarItem7.Text = "Dịch vụ dữ liệu"
        UltraExplorerBarGroup1.Items.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem() {UltraExplorerBarItem1, UltraExplorerBarItem2, UltraExplorerBarItem3, UltraExplorerBarItem4, UltraExplorerBarItem5, UltraExplorerBarItem6, UltraExplorerBarItem7})
        UltraExplorerBarGroup1.Text = "Hệ thống"
        UltraExplorerBarGroup2.Expanded = False
        UltraExplorerBarItem8.Key = "KT1"
        UltraExplorerBarItem8.Text = "Xác nhận đến"
        UltraExplorerBarItem9.Key = "KT2"
        UltraExplorerBarItem9.Text = "Lập bản kê E2 đi"
        UltraExplorerBarItem10.Key = "KT3"
        UltraExplorerBarItem10.Text = "Sửa chữa E1"
        UltraExplorerBarItem11.Key = "KT4"
        UltraExplorerBarItem11.Text = "Sửa chữa E2 đi"
        UltraExplorerBarItem12.Key = "KT8"
        UltraExplorerBarItem12.Text = "Sửa chữa E2 đến"
        UltraExplorerBarItem13.Key = "KT5"
        UltraExplorerBarItem13.Text = "Đối soát đi - đến"
        UltraExplorerBarItem14.Key = "KT6"
        UltraExplorerBarItem14.Text = "Khóa số liệu"
        UltraExplorerBarItem15.Key = "KT7"
        UltraExplorerBarItem15.Text = "Phát hàng trả tiền"
        UltraExplorerBarGroup2.Items.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem() {UltraExplorerBarItem8, UltraExplorerBarItem9, UltraExplorerBarItem10, UltraExplorerBarItem11, UltraExplorerBarItem12, UltraExplorerBarItem13, UltraExplorerBarItem14, UltraExplorerBarItem15})
        UltraExplorerBarGroup2.Text = "Khai thác"
        UltraExplorerBarGroup3.Expanded = False
        UltraExplorerBarItem16.Key = "BP1"
        UltraExplorerBarItem16.Text = "Nhập bưu phẩm đã phát được"
        UltraExplorerBarItem17.Key = "BP2"
        UltraExplorerBarItem17.Text = "Nhập báo phát tuyển sinh"
        UltraExplorerBarGroup3.Items.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem() {UltraExplorerBarItem16, UltraExplorerBarItem17})
        UltraExplorerBarGroup3.Text = "Báo phát"
        UltraExplorerBarGroup4.Expanded = False
        UltraExplorerBarItem18.Key = "TK1"
        UltraExplorerBarItem18.Text = "Tìm kiếm E1"
        UltraExplorerBarGroup4.Items.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem() {UltraExplorerBarItem18})
        UltraExplorerBarGroup4.Text = "Tìm kiếm"
        UltraExplorerBarGroup5.Expanded = False
        UltraExplorerBarItem19.Key = "BC1"
        UltraExplorerBarItem19.Text = "Tổng hợp sản lượng"
        UltraExplorerBarItem20.Key = "BC2"
        UltraExplorerBarItem20.Text = "Báo cáo về COD"
        UltraExplorerBarItem21.Key = "BC3"
        UltraExplorerBarItem21.Text = "Báo cáo về doanh thu"
        UltraExplorerBarGroup5.Items.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem() {UltraExplorerBarItem19, UltraExplorerBarItem20, UltraExplorerBarItem21})
        UltraExplorerBarGroup5.Text = "Thống kê - Báo cáo"
        UltraExplorerBarGroup6.Expanded = False
        UltraExplorerBarItem22.Key = "TG1"
        UltraExplorerBarItem22.Text = "Cập nhật chương trình mới"
        UltraExplorerBarItem23.Key = "TG2"
        UltraExplorerBarItem23.Text = "Hướng dẫn sử dụng"
        UltraExplorerBarItem24.Key = "TG3"
        UltraExplorerBarItem24.Text = "Giới thiệu chương trình"
        UltraExplorerBarGroup6.Items.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem() {UltraExplorerBarItem22, UltraExplorerBarItem23, UltraExplorerBarItem24})
        UltraExplorerBarGroup6.Text = "Trợ giúp"
        Me.ExplorerBarMenu.Groups.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup() {UltraExplorerBarGroup1, UltraExplorerBarGroup2, UltraExplorerBarGroup3, UltraExplorerBarGroup4, UltraExplorerBarGroup5, UltraExplorerBarGroup6})
        Appearance4.FontData.BoldAsString = "True"
        Appearance4.FontData.Name = "Tahoma"
        Appearance4.FontData.SizeInPoints = 9.0!
        Me.ExplorerBarMenu.GroupSettings.AppearancesSmall.Appearance = Appearance4
        Me.ExplorerBarMenu.GroupSettings.ItemAreaInnerMargins.Left = 0
        Me.ExplorerBarMenu.GroupSettings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.SmallImagesWithText
        Me.ExplorerBarMenu.GroupSpacing = 10
        Me.ExplorerBarMenu.ImageTransparentColor = System.Drawing.SystemColors.ControlLightLight
        Me.ExplorerBarMenu.ItemSettings.MaxLines = 5
        Me.ExplorerBarMenu.Location = New System.Drawing.Point(0, 0)
        Me.ExplorerBarMenu.Margins.Bottom = 8
        Me.ExplorerBarMenu.Margins.Left = 8
        Me.ExplorerBarMenu.Margins.Right = 8
        Me.ExplorerBarMenu.Margins.Top = 8
        Me.ExplorerBarMenu.Name = "ExplorerBarMenu"
        Me.ExplorerBarMenu.Size = New System.Drawing.Size(248, 537)
        Me.ExplorerBarMenu.TabIndex = 5
        Me.ExplorerBarMenu.ViewStyle = Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarViewStyle.XP
        '
        'statusBar
        '
        Me.statusBar.Location = New System.Drawing.Point(0, 537)
        Me.statusBar.Name = "statusBar"
        UltraStatusPanel1.Text = "Caps lock:"
        UltraStatusPanel1.Width = 210
        UltraStatusPanel2.Text = "Num Lock:"
        UltraStatusPanel2.Width = 406
        UltraStatusPanel3.Text = "Scroll Lock:"
        UltraStatusPanel3.Width = 176
        Me.statusBar.Panels.AddRange(New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel() {UltraStatusPanel1, UltraStatusPanel2, UltraStatusPanel3})
        Me.statusBar.Size = New System.Drawing.Size(791, 30)
        Me.statusBar.TabIndex = 7
        '
        'UltraDockManager1
        '
        Me.UltraDockManager1.HostControl = Me
        Me.UltraDockManager1.WindowStyle = Infragistics.Win.UltraWinDock.WindowStyle.VisualStudio2005
        '
        'TimeClock
        '
        Me.TimeClock.Interval = 1000
        '
        'FrmVaoCa
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(791, 567)
        Me.Controls.Add(Me._FrmVaoCaAutoHideControl)
        Me.Controls.Add(Me.Task_Panel1)
        Me.Controls.Add(Me.ExplorerBarMenu)
        Me.Controls.Add(Me._FrmVaoCaUnpinnedTabAreaTop)
        Me.Controls.Add(Me._FrmVaoCaUnpinnedTabAreaBottom)
        Me.Controls.Add(Me._FrmVaoCaUnpinnedTabAreaLeft)
        Me.Controls.Add(Me._FrmVaoCaUnpinnedTabAreaRight)
        Me.Controls.Add(Me.statusBar)
        Me.Name = "FrmVaoCa"
        Me.Text = "FrmVaoCa"
        Me.Task_Panel1.ResumeLayout(False)
        CType(Me.ExplorerBarMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmVaoCa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

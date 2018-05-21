Option Explicit On 
Imports Infragistics.Win.UltraWinExplorerBar
Imports System.IO
Imports Ems_International_Logic.EMS
Public Class FrmMain
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
    Friend WithEvents TimeClock As System.Windows.Forms.Timer
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
    Friend WithEvents _FrmMainUnpinnedTabAreaLeft As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _FrmMainUnpinnedTabAreaRight As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _FrmMainUnpinnedTabAreaTop As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _FrmMainUnpinnedTabAreaBottom As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _FrmMainAutoHideControl As Infragistics.Win.UltraWinDock.AutoHideControl
    Friend WithEvents UltraDockManager1 As Infragistics.Win.UltraWinDock.UltraDockManager
    Friend WithEvents statusBar As Infragistics.Win.UltraWinStatusBar.UltraStatusBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmMain))
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
        Dim UltraExplorerBarItem8 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem9 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem10 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem11 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem12 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem13 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem14 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem15 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarGroup2 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup
        Dim UltraExplorerBarItem16 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem17 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem18 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem19 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem20 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem21 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem22 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem23 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem24 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem25 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarGroup3 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup
        Dim UltraExplorerBarItem26 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem27 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem28 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem29 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem30 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem31 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem32 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem33 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem34 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem35 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem36 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarGroup4 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup
        Dim UltraExplorerBarItem37 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem38 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem39 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem40 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem41 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem42 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarGroup5 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup
        Dim UltraExplorerBarItem43 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem44 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem45 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem46 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem47 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem48 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem49 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem50 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarGroup6 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup
        Dim UltraExplorerBarItem51 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem52 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarGroup7 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup
        Dim UltraExplorerBarItem53 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem54 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarGroup8 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup
        Dim UltraExplorerBarItem55 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem56 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem57 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarGroup9 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup
        Dim UltraExplorerBarItem58 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem59 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarGroup10 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup
        Dim UltraExplorerBarItem60 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem61 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem62 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem63 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem64 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem65 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem66 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarGroup11 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup
        Dim UltraExplorerBarItem67 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarGroup12 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup
        Dim UltraExplorerBarItem68 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem69 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim UltraExplorerBarItem70 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraStatusPanel1 As Infragistics.Win.UltraWinStatusBar.UltraStatusPanel = New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel
        Dim UltraStatusPanel2 As Infragistics.Win.UltraWinStatusBar.UltraStatusPanel = New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel
        Dim UltraStatusPanel3 As Infragistics.Win.UltraWinStatusBar.UltraStatusPanel = New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel
        Me.TimeClock = New System.Windows.Forms.Timer(Me.components)
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
        Me.lblTimeLogin = New System.Windows.Forms.Label
        Me.CalendarView = New Calendar.MyCalendar.Calendar
        Me.Clock = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.ExplorerBarMenu = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar
        Me.statusBar = New Infragistics.Win.UltraWinStatusBar.UltraStatusBar
        Me._FrmMainUnpinnedTabAreaLeft = New Infragistics.Win.UltraWinDock.UnpinnedTabArea
        Me.UltraDockManager1 = New Infragistics.Win.UltraWinDock.UltraDockManager(Me.components)
        Me._FrmMainUnpinnedTabAreaRight = New Infragistics.Win.UltraWinDock.UnpinnedTabArea
        Me._FrmMainUnpinnedTabAreaTop = New Infragistics.Win.UltraWinDock.UnpinnedTabArea
        Me._FrmMainUnpinnedTabAreaBottom = New Infragistics.Win.UltraWinDock.UnpinnedTabArea
        Me._FrmMainAutoHideControl = New Infragistics.Win.UltraWinDock.AutoHideControl
        Me.Task_Panel1.SuspendLayout()
        CType(Me.ExplorerBarMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimeClock
        '
        Me.TimeClock.Interval = 1000
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
        Me.Task_Panel1.Controls.Add(Me.lblTimeLogin)
        Me.Task_Panel1.Controls.Add(Me.CalendarView)
        Me.Task_Panel1.Controls.Add(Me.Clock)
        Me.Task_Panel1.Controls.Add(Me.PictureBox2)
        Me.Task_Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Task_Panel1.DockPadding.Left = 52
        Me.Task_Panel1.Location = New System.Drawing.Point(594, 0)
        Me.Task_Panel1.Name = "Task_Panel1"
        Me.Task_Panel1.Size = New System.Drawing.Size(200, 543)
        Me.Task_Panel1.TabIndex = 3
        '
        'btnDesktop
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.btnDesktop.Appearance = Appearance1
        Me.btnDesktop.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.btnDesktop.Location = New System.Drawing.Point(36, 440)
        Me.btnDesktop.Name = "btnDesktop"
        Me.btnDesktop.Size = New System.Drawing.Size(128, 32)
        Me.btnDesktop.TabIndex = 44
        Me.btnDesktop.Text = "&Hiện Desktop"
        '
        'SeperatorDoc
        '
        Me.SeperatorDoc.BackColor = System.Drawing.Color.SlateGray
        Me.SeperatorDoc.Location = New System.Drawing.Point(0, -729)
        Me.SeperatorDoc.Name = "SeperatorDoc"
        Me.SeperatorDoc.Size = New System.Drawing.Size(1, 2000)
        Me.SeperatorDoc.TabIndex = 43
        Me.SeperatorDoc.TabStop = False
        '
        'lblClock
        '
        Me.lblClock.BackColor = System.Drawing.Color.Transparent
        Me.lblClock.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblClock.Location = New System.Drawing.Point(32, 232)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(144, 24)
        Me.lblClock.TabIndex = 1
        Me.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDongY
        '
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.btnDongY.Appearance = Appearance2
        Me.btnDongY.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.btnDongY.Location = New System.Drawing.Point(36, 464)
        Me.btnDongY.Name = "btnDongY"
        Me.btnDongY.Size = New System.Drawing.Size(128, 32)
        Me.btnDongY.TabIndex = 5
        Me.btnDongY.Text = "&Đổi người dùng"
        '
        'btnThoat
        '
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        Me.btnThoat.Appearance = Appearance3
        Me.btnThoat.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.btnThoat.Location = New System.Drawing.Point(36, 496)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(128, 31)
        Me.btnThoat.TabIndex = 6
        Me.btnThoat.Text = "&Thoát"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(8, 416)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 3)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 376)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'lblPhongBan
        '
        Me.lblPhongBan.BackColor = System.Drawing.Color.Transparent
        Me.lblPhongBan.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.lblPhongBan.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPhongBan.Location = New System.Drawing.Point(40, 376)
        Me.lblPhongBan.Name = "lblPhongBan"
        Me.lblPhongBan.Size = New System.Drawing.Size(160, 32)
        Me.lblPhongBan.TabIndex = 4
        Me.lblPhongBan.Text = "Phòng Kinh tế kế hoạch"
        '
        'lblNguoiDung
        '
        Me.lblNguoiDung.BackColor = System.Drawing.Color.Transparent
        Me.lblNguoiDung.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.lblNguoiDung.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblNguoiDung.Location = New System.Drawing.Point(40, 344)
        Me.lblNguoiDung.Name = "lblNguoiDung"
        Me.lblNguoiDung.Size = New System.Drawing.Size(152, 32)
        Me.lblNguoiDung.TabIndex = 2
        Me.lblNguoiDung.Text = "Nguyễn Thị Quỳnh Nga"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(8, 312)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 27)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 39
        Me.PictureBox3.TabStop = False
        '
        'lblTimeLogin
        '
        Me.lblTimeLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeLogin.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.lblTimeLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTimeLogin.Location = New System.Drawing.Point(40, 312)
        Me.lblTimeLogin.Name = "lblTimeLogin"
        Me.lblTimeLogin.Size = New System.Drawing.Size(160, 24)
        Me.lblTimeLogin.TabIndex = 3
        Me.lblTimeLogin.Text = "Login lúc: 11:01 PM"
        '
        'CalendarView
        '
        Me.CalendarView.AdjustImageLocation = New System.Drawing.Point(0, 0)
        Me.CalendarView.BtnShape = Calendar.MyCalendar.emunType.BtnShape.Rectangle
        Me.CalendarView.BtnStyle = Calendar.MyCalendar.emunType.XPStyle.Default
        Me.CalendarView.ColorSystem = True
        Me.CalendarView.Location = New System.Drawing.Point(60, 16)
        Me.CalendarView.Name = "CalendarView"
        Me.CalendarView.Ngaylamviec = New Date(2007, 2, 24, 10, 14, 22, 948)
        Me.CalendarView.Size = New System.Drawing.Size(80, 112)
        Me.CalendarView.TabIndex = 0
        '
        'Clock
        '
        Me.Clock.BackColor = System.Drawing.Color.Transparent
        Me.Clock.Image = CType(resources.GetObject("Clock.Image"), System.Drawing.Image)
        Me.Clock.Location = New System.Drawing.Point(64, 144)
        Me.Clock.Name = "Clock"
        Me.Clock.Size = New System.Drawing.Size(72, 72)
        Me.Clock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Clock.TabIndex = 34
        Me.Clock.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(8, 344)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 38
        Me.PictureBox2.TabStop = False
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
        UltraExplorerBarItem2.Key = "HT9"
        UltraExplorerBarItem2.Text = "Thiết lập tham số hệ thống"
        UltraExplorerBarItem3.Key = "HT2"
        UltraExplorerBarItem3.Text = "Các bảng danh mục"
        UltraExplorerBarItem4.Key = "HT3"
        UltraExplorerBarItem4.Text = "Các bảng danh mục cước"
        UltraExplorerBarItem5.Key = "HT4"
        UltraExplorerBarItem5.Text = "Thông tin người dùng"
        UltraExplorerBarItem6.Key = "HT5"
        UltraExplorerBarItem6.Text = "Quản lý người dùng"
        UltraExplorerBarItem7.Key = "HT6"
        UltraExplorerBarItem7.Text = "Cấu hình in"
        UltraExplorerBarItem8.Key = "HT7"
        UltraExplorerBarItem8.Text = "Dịch vụ dữ liệu"
        UltraExplorerBarItem9.Key = "HT8"
        UltraExplorerBarItem9.Text = "Cấu hình cơ sở dữ liệu"
        UltraExplorerBarItem10.Key = "HT10"
        UltraExplorerBarItem10.Text = "Nhập tỷ giá"
        UltraExplorerBarItem11.Key = "HT11"
        UltraExplorerBarItem11.Text = "Khóa Số Liệu"
        UltraExplorerBarItem12.Key = "HT12"
        UltraExplorerBarItem12.Text = "Nhật ký Hệ thống"
        UltraExplorerBarItem13.Key = "HT13"
        UltraExplorerBarItem13.Text = "Truyền Predes, Resdes"
        UltraExplorerBarItem14.Key = "HT14"
        UltraExplorerBarItem14.Text = "Danh Mục Hướng Đến"
        UltraExplorerBarItem15.Key = "HT15"
        UltraExplorerBarItem15.Text = "Danh Mục Hướng Đi"
        UltraExplorerBarGroup1.Items.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem() {UltraExplorerBarItem1, UltraExplorerBarItem2, UltraExplorerBarItem3, UltraExplorerBarItem4, UltraExplorerBarItem5, UltraExplorerBarItem6, UltraExplorerBarItem7, UltraExplorerBarItem8, UltraExplorerBarItem9, UltraExplorerBarItem10, UltraExplorerBarItem11, UltraExplorerBarItem12, UltraExplorerBarItem13, UltraExplorerBarItem14, UltraExplorerBarItem15})
        UltraExplorerBarGroup1.Text = "Hệ thống"
        UltraExplorerBarItem16.Key = "KT1"
        UltraExplorerBarItem16.Text = "Xác nhận đến"
        UltraExplorerBarItem17.Key = "KT2"
        UltraExplorerBarItem17.Text = "Lập bản kê E2 đi"
        UltraExplorerBarItem18.Key = "INB001"
        UltraExplorerBarItem18.Text = "Nhận dữ liệu IPS"
        UltraExplorerBarItem19.Key = "KT3"
        UltraExplorerBarItem19.Text = "Sửa chữa E1"
        UltraExplorerBarItem20.Key = "KT4"
        UltraExplorerBarItem20.Text = "Sửa chữa E2 đi"
        UltraExplorerBarItem21.Key = "KT8"
        UltraExplorerBarItem21.Text = "Sửa chữa E2 đến"
        UltraExplorerBarItem22.Key = "KT5"
        UltraExplorerBarItem22.Text = "Đối soát đi - đến"
        UltraExplorerBarItem23.Key = "KT6"
        UltraExplorerBarItem23.Text = "Khóa số liệu"
        UltraExplorerBarItem24.Key = "BC1"
        UltraExplorerBarItem24.Text = "Tổng hợp sản lượng"
        UltraExplorerBarItem25.Key = "BC3"
        UltraExplorerBarItem25.Text = "Báo cáo về doanh thu"
        UltraExplorerBarGroup2.Items.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem() {UltraExplorerBarItem16, UltraExplorerBarItem17, UltraExplorerBarItem18, UltraExplorerBarItem19, UltraExplorerBarItem20, UltraExplorerBarItem21, UltraExplorerBarItem22, UltraExplorerBarItem23, UltraExplorerBarItem24, UltraExplorerBarItem25})
        UltraExplorerBarGroup2.Key = "QT_DEN"
        UltraExplorerBarGroup2.Text = "Quốc Tế Đến"
        UltraExplorerBarItem26.Key = "QT1"
        UltraExplorerBarItem26.Text = "Xác Nhận Đến"
        UltraExplorerBarItem27.Key = "QT2"
        UltraExplorerBarItem27.Text = "Thiết Lập Đi"
        UltraExplorerBarItem28.Key = "QT3"
        UltraExplorerBarItem28.Text = "Thống kê - Báo cáo"
        UltraExplorerBarItem29.Key = "QT6"
        UltraExplorerBarItem29.Text = "Sửa chữa E1"
        UltraExplorerBarItem30.Key = "QT4"
        UltraExplorerBarItem30.Text = "Sửa chữa bản kê E2 đi"
        UltraExplorerBarItem31.Key = "QT5"
        UltraExplorerBarItem31.Text = "Sửa chữa bản kê E2 đến"
        UltraExplorerBarItem32.Key = "QT7"
        UltraExplorerBarItem32.Text = "In Giấy Biên nhận đối với đường thư bưu tá nội bộ"
        UltraExplorerBarItem33.Key = "QT8"
        UltraExplorerBarItem33.Text = "Tạo vận đơn điện tử"
        UltraExplorerBarItem34.Key = "QT9"
        UltraExplorerBarItem34.Text = "Tổng hợp báo cáo EMS Economy"
        UltraExplorerBarItem35.Key = "QT10"
        UltraExplorerBarItem35.Text = "Quản lý E1 chuyển mã"
        UltraExplorerBarItem36.Key = "OUT001"
        UltraExplorerBarItem36.Text = "Nhận dữ liệu từ IPS"
        UltraExplorerBarItem36.ToolTipText = "Import dữ liệu từ IPS"
        UltraExplorerBarGroup3.Items.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem() {UltraExplorerBarItem26, UltraExplorerBarItem27, UltraExplorerBarItem28, UltraExplorerBarItem29, UltraExplorerBarItem30, UltraExplorerBarItem31, UltraExplorerBarItem32, UltraExplorerBarItem33, UltraExplorerBarItem34, UltraExplorerBarItem35, UltraExplorerBarItem36})
        UltraExplorerBarGroup3.Key = "QT_DI"
        UltraExplorerBarGroup3.Text = "Quốc Tế Đi"
        UltraExplorerBarItem37.Key = "QLTG0"
        UltraExplorerBarItem37.Text = "Lập và In BC37 giao đi"
        UltraExplorerBarItem37.ToolTipText = "Lập và In BC37 giao đi"
        UltraExplorerBarItem38.Key = "QLTG1"
        UltraExplorerBarItem38.Text = "Giao - Nhận túi gói"
        UltraExplorerBarItem38.ToolTipText = "Giao - Nhận túi gói"
        UltraExplorerBarItem39.Key = "QLTG5"
        UltraExplorerBarItem39.Text = "Quản lý BC37 Đến - Đi"
        UltraExplorerBarItem39.ToolTipText = "Quản lý BC37 Đến - Đi"
        UltraExplorerBarItem40.Key = "QLTG2"
        UltraExplorerBarItem40.Text = "Quản lý Danh mục"
        UltraExplorerBarItem40.ToolTipText = "Quản lý Danh mục"
        UltraExplorerBarItem41.Key = "QLTG3"
        UltraExplorerBarItem41.Text = "In nhãn cố túi (8 label)"
        UltraExplorerBarItem41.ToolTipText = "In nhãn cố túi (8 label)"
        UltraExplorerBarItem42.Key = "QLTG4"
        UltraExplorerBarItem42.Text = "Báo cáo BC37"
        UltraExplorerBarItem42.ToolTipText = "Báo cáo BC37"
        UltraExplorerBarGroup4.Items.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem() {UltraExplorerBarItem37, UltraExplorerBarItem38, UltraExplorerBarItem39, UltraExplorerBarItem40, UltraExplorerBarItem41, UltraExplorerBarItem42})
        UltraExplorerBarGroup4.Key = "QLTG"
        UltraExplorerBarGroup4.Text = "Quản lý túi gói nội địa"
        UltraExplorerBarItem43.Key = "CN1"
        UltraExplorerBarItem43.Text = "Quản lý chuyến thư"
        UltraExplorerBarItem44.Key = "CN2"
        UltraExplorerBarItem44.Text = "Báo cáo thuế và lệ phí HQ"
        UltraExplorerBarItem45.Key = "CN3"
        UltraExplorerBarItem45.Text = "Kế toán Quốc tế"
        UltraExplorerBarItem46.Key = "CN6"
        UltraExplorerBarItem46.Text = "Thiết lập và in CN56"
        UltraExplorerBarItem47.Key = "CN4"
        UltraExplorerBarItem47.Text = "Bản kê A1"
        UltraExplorerBarItem48.Key = "CN5"
        UltraExplorerBarItem48.Text = "Thiết Lập và In Bản Kê BV2"
        UltraExplorerBarItem49.Key = "CN7"
        UltraExplorerBarItem49.Text = "Báo cáo quản lý kho Hải quan"
        UltraExplorerBarItem50.Key = "CN8"
        UltraExplorerBarItem50.Text = "Bản kê A1 Nội Bài"
        UltraExplorerBarGroup5.Items.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem() {UltraExplorerBarItem43, UltraExplorerBarItem44, UltraExplorerBarItem45, UltraExplorerBarItem46, UltraExplorerBarItem47, UltraExplorerBarItem48, UltraExplorerBarItem49, UltraExplorerBarItem50})
        UltraExplorerBarGroup5.Text = "Chức năng"
        UltraExplorerBarGroup6.Expanded = False
        UltraExplorerBarItem51.Key = "BP1"
        UltraExplorerBarItem51.Text = "Nhập bưu phẩm đã phát được"
        UltraExplorerBarItem52.Key = "BP2"
        UltraExplorerBarItem52.Text = "Nhập báo phát tuyển sinh"
        UltraExplorerBarGroup6.Items.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem() {UltraExplorerBarItem51, UltraExplorerBarItem52})
        UltraExplorerBarGroup6.Text = "Báo phát"
        UltraExplorerBarGroup7.Expanded = False
        UltraExplorerBarItem53.Key = "TK1"
        UltraExplorerBarItem53.Text = "Tìm kiếm E1"
        UltraExplorerBarItem54.Key = "TK2"
        UltraExplorerBarItem54.Text = "Định vị bưu phẩm"
        UltraExplorerBarGroup7.Items.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem() {UltraExplorerBarItem53, UltraExplorerBarItem54})
        UltraExplorerBarGroup7.Text = "Tìm kiếm"
        UltraExplorerBarGroup8.Expanded = False
        UltraExplorerBarItem55.Key = "TG1"
        UltraExplorerBarItem55.Text = "Cập nhật chương trình mới"
        UltraExplorerBarItem56.Key = "TG2"
        UltraExplorerBarItem56.Text = "Hướng dẫn sử dụng"
        UltraExplorerBarItem57.Key = "TG3"
        UltraExplorerBarItem57.Text = "Giới thiệu chương trình"
        UltraExplorerBarGroup8.Items.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem() {UltraExplorerBarItem55, UltraExplorerBarItem56, UltraExplorerBarItem57})
        UltraExplorerBarGroup8.Text = "Trợ giúp"
        UltraExplorerBarGroup9.Expanded = False
        UltraExplorerBarItem58.Key = "HQ1"
        UltraExplorerBarItem58.Text = "Nhập thông tin thu nợ"
        UltraExplorerBarItem59.Key = "HQ2"
        UltraExplorerBarItem59.Text = "Báo cáo - Tổng hợp"
        UltraExplorerBarGroup9.Items.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem() {UltraExplorerBarItem58, UltraExplorerBarItem59})
        UltraExplorerBarGroup9.Key = "HQ"
        UltraExplorerBarGroup9.Text = "Quản lý thu nợ Hải quan"
        UltraExplorerBarGroup10.Expanded = False
        UltraExplorerBarItem60.Key = "DSQT1"
        UltraExplorerBarItem60.Text = "Danh Mục Đối Soát"
        UltraExplorerBarItem61.Key = "DSQT2"
        UltraExplorerBarItem61.Text = "Cước Quốc Tế Đến"
        UltraExplorerBarItem62.Key = "DSQT3"
        UltraExplorerBarItem62.Text = "Cước Quốc Tế Đi"
        UltraExplorerBarItem63.Key = "DSQT4"
        UltraExplorerBarItem63.Text = "Cước Quá Giang HongKong"
        UltraExplorerBarItem64.Key = "DSQT5"
        UltraExplorerBarItem64.Text = "Cước Quá Giang Singapore"
        UltraExplorerBarItem65.Key = "DSQT6"
        UltraExplorerBarItem65.Text = "Cước Quá Giang JNE"
        UltraExplorerBarItem66.Key = "DSQT7"
        UltraExplorerBarItem66.Text = "Đối Soát Quốc Tế"
        UltraExplorerBarGroup10.Items.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem() {UltraExplorerBarItem60, UltraExplorerBarItem61, UltraExplorerBarItem62, UltraExplorerBarItem63, UltraExplorerBarItem64, UltraExplorerBarItem65, UltraExplorerBarItem66})
        UltraExplorerBarGroup10.Key = "DSQT"
        UltraExplorerBarGroup10.Text = "Đối Soát Quốc Tế"
        UltraExplorerBarGroup11.Expanded = False
        UltraExplorerBarItem67.Key = "BPBK1"
        UltraExplorerBarItem67.Text = "Thống Kê Báo Cáo"
        UltraExplorerBarGroup11.Items.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem() {UltraExplorerBarItem67})
        UltraExplorerBarGroup11.Key = "BPBK"
        UltraExplorerBarGroup11.Text = "Bưu Kiện Bưu Phẩm"
        UltraExplorerBarGroup11.Visible = False
        UltraExplorerBarItem68.Key = "KH1"
        UltraExplorerBarItem68.Text = "Lập tờ khai hàng xuất khẩu"
        UltraExplorerBarItem69.Key = "KH2"
        UltraExplorerBarItem69.Text = "Tìm kiếm Tờ khai"
        UltraExplorerBarItem70.Key = "KH3"
        UltraExplorerBarItem70.Text = "Sửa chữa tờ khai hàng xuất"
        UltraExplorerBarGroup12.Items.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem() {UltraExplorerBarItem68, UltraExplorerBarItem69, UltraExplorerBarItem70})
        UltraExplorerBarGroup12.Key = "KH"
        UltraExplorerBarGroup12.Text = "Kiểm hóa Hàng xuất khẩu"
        Me.ExplorerBarMenu.Groups.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup() {UltraExplorerBarGroup1, UltraExplorerBarGroup2, UltraExplorerBarGroup3, UltraExplorerBarGroup4, UltraExplorerBarGroup5, UltraExplorerBarGroup6, UltraExplorerBarGroup7, UltraExplorerBarGroup8, UltraExplorerBarGroup9, UltraExplorerBarGroup10, UltraExplorerBarGroup11, UltraExplorerBarGroup12})
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
        Me.ExplorerBarMenu.Size = New System.Drawing.Size(213, 543)
        Me.ExplorerBarMenu.TabIndex = 2
        Me.ExplorerBarMenu.ViewStyle = Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarViewStyle.XP
        '
        'statusBar
        '
        Me.statusBar.Location = New System.Drawing.Point(0, 543)
        Me.statusBar.Name = "statusBar"
        UltraStatusPanel1.Text = "Caps lock:"
        UltraStatusPanel1.Width = 210
        UltraStatusPanel2.Text = "Num Lock:"
        UltraStatusPanel2.Width = 406
        UltraStatusPanel3.Text = "Scroll Lock:"
        UltraStatusPanel3.Width = 176
        Me.statusBar.Panels.AddRange(New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel() {UltraStatusPanel1, UltraStatusPanel2, UltraStatusPanel3})
        Me.statusBar.Size = New System.Drawing.Size(794, 25)
        Me.statusBar.TabIndex = 4
        '
        '_FrmMainUnpinnedTabAreaLeft
        '
        Me._FrmMainUnpinnedTabAreaLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me._FrmMainUnpinnedTabAreaLeft.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FrmMainUnpinnedTabAreaLeft.Location = New System.Drawing.Point(0, 0)
        Me._FrmMainUnpinnedTabAreaLeft.Name = "_FrmMainUnpinnedTabAreaLeft"
        Me._FrmMainUnpinnedTabAreaLeft.Owner = Me.UltraDockManager1
        Me._FrmMainUnpinnedTabAreaLeft.Size = New System.Drawing.Size(0, 543)
        Me._FrmMainUnpinnedTabAreaLeft.TabIndex = 5
        '
        'UltraDockManager1
        '
        Me.UltraDockManager1.HostControl = Me
        Me.UltraDockManager1.WindowStyle = Infragistics.Win.UltraWinDock.WindowStyle.VisualStudio2005
        '
        '_FrmMainUnpinnedTabAreaRight
        '
        Me._FrmMainUnpinnedTabAreaRight.Dock = System.Windows.Forms.DockStyle.Right
        Me._FrmMainUnpinnedTabAreaRight.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FrmMainUnpinnedTabAreaRight.Location = New System.Drawing.Point(794, 0)
        Me._FrmMainUnpinnedTabAreaRight.Name = "_FrmMainUnpinnedTabAreaRight"
        Me._FrmMainUnpinnedTabAreaRight.Owner = Me.UltraDockManager1
        Me._FrmMainUnpinnedTabAreaRight.Size = New System.Drawing.Size(0, 543)
        Me._FrmMainUnpinnedTabAreaRight.TabIndex = 6
        '
        '_FrmMainUnpinnedTabAreaTop
        '
        Me._FrmMainUnpinnedTabAreaTop.Dock = System.Windows.Forms.DockStyle.Top
        Me._FrmMainUnpinnedTabAreaTop.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FrmMainUnpinnedTabAreaTop.Location = New System.Drawing.Point(0, 0)
        Me._FrmMainUnpinnedTabAreaTop.Name = "_FrmMainUnpinnedTabAreaTop"
        Me._FrmMainUnpinnedTabAreaTop.Owner = Me.UltraDockManager1
        Me._FrmMainUnpinnedTabAreaTop.Size = New System.Drawing.Size(794, 0)
        Me._FrmMainUnpinnedTabAreaTop.TabIndex = 7
        '
        '_FrmMainUnpinnedTabAreaBottom
        '
        Me._FrmMainUnpinnedTabAreaBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._FrmMainUnpinnedTabAreaBottom.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FrmMainUnpinnedTabAreaBottom.Location = New System.Drawing.Point(0, 543)
        Me._FrmMainUnpinnedTabAreaBottom.Name = "_FrmMainUnpinnedTabAreaBottom"
        Me._FrmMainUnpinnedTabAreaBottom.Owner = Me.UltraDockManager1
        Me._FrmMainUnpinnedTabAreaBottom.Size = New System.Drawing.Size(794, 0)
        Me._FrmMainUnpinnedTabAreaBottom.TabIndex = 8
        '
        '_FrmMainAutoHideControl
        '
        Me._FrmMainAutoHideControl.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FrmMainAutoHideControl.Location = New System.Drawing.Point(0, 0)
        Me._FrmMainAutoHideControl.Name = "_FrmMainAutoHideControl"
        Me._FrmMainAutoHideControl.Owner = Me.UltraDockManager1
        Me._FrmMainAutoHideControl.TabIndex = 9
        '
        'FrmMain
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(794, 568)
        Me.Controls.Add(Me.ExplorerBarMenu)
        Me.Controls.Add(Me.Task_Panel1)
        Me.Controls.Add(Me._FrmMainAutoHideControl)
        Me.Controls.Add(Me._FrmMainUnpinnedTabAreaTop)
        Me.Controls.Add(Me._FrmMainUnpinnedTabAreaBottom)
        Me.Controls.Add(Me._FrmMainUnpinnedTabAreaLeft)
        Me.Controls.Add(Me._FrmMainUnpinnedTabAreaRight)
        Me.Controls.Add(Me.statusBar)
        Me.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EMS"
        Me.Task_Panel1.ResumeLayout(False)
        CType(Me.ExplorerBarMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim myKeys As New ModifyRegistry


    Private handHour As New cHands
    Private handMinute As New cHands
    Private handSecond As New cHands
    Private center = New PointF(36, 36)
    Private GroupBar As UltraExplorerBarGroup
    Private ItemBar As UltraExplorerBarItem

    Private myData As DataTable
    Private Declare Function GetWindowLong Lib "user32" Alias "GetWindowLongA" (ByVal hwnd As Long, ByVal nIndex As Long) As Long
    Private Declare Function SetWindowLong Lib "user32" Alias "SetWindowLongA" (ByVal hwnd As Long, ByVal nIndex As Long, ByVal dwNewLong As Long) As Long
    Private Const GWL_STYLE = (-16)
    Private Const WS_SYSMENU = &H80000
    Private Declare Sub keybd_event Lib "user32.dll" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Long, ByVal dwExtraInfo As Long)
    Const VK_LWIN = &H5C&
    Const VK_D = &H44&
    Const KEYEVENTF_KEYUP = &H2
    Dim myNguoi_Dung As New Nguoi_Dung(GConnectionString)
    Dim myNguoi_Dung_Chi_Tiet As New Nguoi_Dung_Chi_Tiet
    Dim myPhan_Quyen As New Phan_Quyen(GConnectionString)
    Dim myHam_Dung_Chung As New Ham_Dung_Chung
    'Dim myProcess As New System.Diagnostics.Process
    Private Sub RunClock()
        Dim p As New System.Drawing.Point
        p.X = 0
        p.Y = 0
        Me.Location = p
        Dim sTimeLogin As String
        sTimeLogin = Now.ToShortTimeString
        Me.CalendarView.Ngaylamviec = Now

        '--------------------

        'Khởi tạo Clock
        handHour.setAngle(0, center)
        handMinute.setAngle(0, center)
        handSecond.setAngle(0, center)
        initclock()

        Me.TimeClock.Enabled = True
    End Sub
    Private Sub Thay_Doi_Cua_So()
        Me.Location = New Point((Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - Me.Height) / 2)
    End Sub

    Private Sub GetKeys()
        Dim frm As New FrmThietLapThamSoHeThong
        GSo_Ngay_E1_Duoc_Trung = IIf(myKeys.Doc("GSo_Ngay_E1_Duoc_Trung") Is Nothing Or myKeys.Doc("GSo_Ngay_E1_Duoc_Trung") = "", "0", myKeys.Doc("GSo_Ngay_E1_Duoc_Trung"))
        GTrong_Luong_E1_Max = IIf(myKeys.Doc("GTrong_Luong_E1_Max") Is Nothing Or myKeys.Doc("GTrong_Luong_E1_Max") = "", "0", myKeys.Doc("GTrong_Luong_E1_Max"))
        GThu_Muc_In_BC37_QT_Den = IIf(myKeys.Doc("GThu_Muc_In_BC37_QT_Den") Is Nothing Or myKeys.Doc("GThu_Muc_In_BC37_QT_Den") = "", "", CStr(myKeys.Doc("GThu_Muc_In_BC37_QT_Den")))
        GThu_Muc_In_BV10_QT_Den = IIf(myKeys.Doc("GThu_Muc_In_BV10_QT_Den") Is Nothing Or myKeys.Doc("GThu_Muc_In_BV10_QT_Den") = "", "", CStr(myKeys.Doc("GThu_Muc_In_BV10_QT_Den")))
        GThu_Muc_In_E4_QT_Den = IIf(myKeys.Doc("GThu_Muc_In_E4_QT_Den") Is Nothing Or myKeys.Doc("GThu_Muc_In_E4_QT_Den") = "", "", CStr(myKeys.Doc("GThu_Muc_In_E4_QT_Den")))
        GThu_Muc_In_E2_QT_Den = IIf(myKeys.Doc("GThu_Muc_In_E2_QT_Den") Is Nothing Or myKeys.Doc("GThu_Muc_In_E2_QT_Den") = "", "", CStr(myKeys.Doc("GThu_Muc_In_E2_QT_Den")))

        frm.rdbInkim.Checked = IIf(myKeys.Doc("GIn_Kim_QT_Den") Is Nothing Or myKeys.Doc("GIn_Kim_QT_Den") = "", "False", myKeys.Doc("GIn_Kim_QT_Den"))
        frm.rdbInlaser.Checked = IIf(myKeys.Doc("GIn_Laser_QT_Den") Is Nothing Or myKeys.Doc("GIn_Laser_QT_Den") = "", "False", myKeys.Doc("GIn_Laser_QT_Den"))
        GIn_Laser_QT_Den = frm.rdbInlaser.Checked
        GIn_Kim_QT_Den = frm.rdbInkim.Checked

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
    End Sub

    Private Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim lStyle As Long
        lStyle = GetWindowLong(Me.Handle.ToInt64, GWL_STYLE) Or WS_SYSMENU
        SetWindowLong(Me.Handle.ToInt64, GWL_STYLE, lStyle)
        Dim myscreen As Screen
        myscreen = Screen.PrimaryScreen
        'If myscreen.Bounds.Width = 1024 Then
        '    btnDesktop.Location = New Point(36, 504)
        '    btnDongY.Location = New Point(36, 536)
        '    btnThoat.Location = New Point(36, 568)
        'End If
        Dim i, j As Integer
        If Now.Hour >= 13 Then
            lblClock.Text = (Now.Hour - 12).ToString & ":" & IIf(Now.Minute.ToString().Length = 1, "0" & Now.Minute.ToString(), Now.Minute.ToString()) & ":" & IIf(Now.Second.ToString().Length = 1, "0" & Now.Second.ToString(), Now.Second.ToString()) & " PM"
        Else
            lblClock.Text = (Now.Hour).ToString & ":" & IIf(Now.Minute.ToString().Length = 1, "0" & Now.Minute.ToString(), Now.Minute.ToString()) & ":" & IIf(Now.Second.ToString().Length = 1, "0" & Now.Second.ToString(), Now.Second.ToString()) & " AM"
        End If
        If Now.Hour >= 13 Then
            lblTimeLogin.Text = "Đăng nhập lúc: " & (Now.Hour - 12).ToString("00") & ":" & Now.Minute.ToString("00") & " PM"
        Else
            lblTimeLogin.Text = "Đăng nhập lúc: " & (Now.Hour).ToString("00") & ":" & Now.Minute.ToString("00") & " AM"
        End If

        If GPhien_Ban <> GPhien_Ban_DataBase Then 'Phiên bản của chương trình không đúng với phiên bản đang được sử dụng
            For Each GroupBar In ExplorerBarMenu.Groups
                GroupBar.Expanded = False
                For Each ItemBar In GroupBar.Items
                    Select Case ItemBar.Key
                        Case "TK1", "TK2" 'Các bảng danh mục, kết nối DataBase
                            ItemBar.Visible = True
                        Case Else
                            ItemBar.Visible = False
                    End Select
                Next
            Next
        Else 'Sử dụng đúng phiên bản
            'Phân quyền
            myData = myPhan_Quyen.Lay_Boi_Nguoi_Dung(Gid_Nguoi_Dung).Tables(0)
            For Each GroupBar In ExplorerBarMenu.Groups
                GroupBar.Expanded = False
                For Each ItemBar In GroupBar.Items
                    ItemBar.Visible = False
                Next
            Next
            For Each GroupBar In ExplorerBarMenu.Groups
                For Each ItemBar In GroupBar.Items
                    For j = 0 To myData.Rows.Count - 1
                        If (ItemBar.Key = Convert.ToString(myData.Rows(j).Item("Id_Chuc_Nang")).Trim) And (Convert.ToBoolean(myData.Rows(j).Item("Su_Dung")) = True) Then
                            Select Case Convert.ToString(myData.Rows(j).Item("Id_Chuc_Nang")).Trim
                                Case "HT2", "HT12"  'Các bảng danh mục, kết nối DataBase, Event Viewer
                                    If GTen_Dang_Nhap.ToUpper = "ADMIN" Then
                                        ItemBar.Visible = True
                                    End If
                                Case "CN8"
                                    If GOutBout <> 1 Then
                                        ItemBar.Visible = True
                                    Else
                                        ItemBar.Visible = False
                                    End If
                                Case "BKBP1"
                                    'Hiển thị trong 100914,700914
                                    If GBuu_Cuc_Khai_Thac = 100914 Or GBuu_Cuc_Khai_Thac = 700914 Then
                                        ItemBar.Visible = True
                                    End If
                                    'Case "DSQT7"
                                    'If GTen_Dang_Nhap.ToUpper = "ADMIN" Then
                                    'ItemBar.Visible = True
                                    'End If
                                Case Else
                                    ItemBar.Visible = True
                            End Select
                        End If
                    Next
                Next
            Next
        End If

        'Chạy Test
        For Each GroupBar In ExplorerBarMenu.Groups
            For Each ItemBar In GroupBar.Items
                Select Case ItemBar.Key
                    Case "BKBP1"
                        'Hiển thị trong 100914,700914
                        If GBuu_Cuc_Khai_Thac = 100914 Or GBuu_Cuc_Khai_Thac = 700914 Then
                            ItemBar.Visible = True
                        End If
                        'Case "DSQT7"
                        'If GTen_Dang_Nhap.ToUpper = "ADMIN" Then
                        'ItemBar.Visible = True
                        ' End If
                        'Case Else
                        '    ItemBar.Visible = True
                End Select
            Next
        Next
        RunClock()
        Thay_Doi_Cua_So()
        GLeftMenu = "TỔNG CÔNG TY BƯU CHÍNH VIỆT NAM" & vbNewLine & "Bưu cục: " & GTen_Buu_Cuc_Khai_Thac
        Grpt_Don_Vi_Khai_Thac = "Đơn vị khai thác : " & GBuu_Cuc_Khai_Thac & " ( " & GTen_Buu_Cuc_Khai_Thac & " )"
        GrptNgay_Thang_Nam = myHam_Dung_Chung.ConvertIntToDate_VN(myHam_Dung_Chung.ConvertDateToInt(Now().Date))
        '
        GetKeys()
        ' Co cho phep Kiem tra lac huong 
        Dim mMa_Bc_Khai_Thac As New Ma_Bc_Khai_Thac(GConnectionString)
        If mMa_Bc_Khai_Thac.Kiem_Tra_Huong_Chuyen(GBuu_Cuc_Khai_Thac) Then
            GKiem_Tra_Lac_Huong = True
        End If
    End Sub

    Private Sub TimeClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeClock.Tick
        If Now.Hour >= 13 Then
            lblClock.Text = (Now.Hour - 12).ToString & ":" & IIf(Now.Minute.ToString().Length = 1, "0" & Now.Minute.ToString(), Now.Minute.ToString()) & ":" & IIf(Now.Second.ToString().Length = 1, "0" & Now.Second.ToString(), Now.Second.ToString()) & " PM"
        Else
            lblClock.Text = (Now.Hour).ToString & ":" & IIf(Now.Minute.ToString().Length = 1, "0" & Now.Minute.ToString(), Now.Minute.ToString()) & ":" & IIf(Now.Second.ToString().Length = 1, "0" & Now.Second.ToString(), Now.Second.ToString()) & " AM"
        End If
        Clock.Invalidate()
    End Sub
#Region "Draw Clock"
    Private Sub clock_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Clock.Paint
        ' Draw the face
        '
        'drawFace(e.Graphics)

        'Set the hands
        '
        handHour.setAngle((360 / 12) * Val(Format(Now, "HH") + Val(Format(Now, "mm")) / 60), center)
        handMinute.setAngle(6 * Val(Format(Now, "mm") + Val(Format(Now, "ss")) / 60), center)
        handSecond.setAngle(6 * Val(Format(Now, "ss")), center)

        ' Draw the hands
        '
        handHour.draw(e.Graphics)
        handMinute.draw(e.Graphics)
        handSecond.draw(e.Graphics)
    End Sub
    Private Sub initclock()

        'Me.ClientSize = New Size(100, 100)

        'Xây dựng tọa độ kim giờ
        Dim drawHour As Point() = {New Point(Int(Clock.Width / 2) + 2, Int(Clock.Height / 2)), _
                                   New Point(Int(Clock.Width / 2), 19), _
                                   New Point(Int(Clock.Width / 2) - 2, 36), _
                                   New Point(Int(Clock.Width / 2), 36 + 2), _
                                   New Point(Int(Clock.Width / 2) + 2, Int(Clock.Height / 2))}

        handHour.Path.AddLines(drawHour)
        handHour.filled = True

        'Xây dựng tọa độ kim phút
        Dim drawMinute As Point() = {New Point(Int(Clock.Width / 2) + 2, Int(Clock.Height / 2)), _
                                     New Point(Int(Clock.Width / 2), 12), _
                                     New Point(Int(Clock.Width / 2) - 2, 36), _
                                     New Point(Int(Clock.Width / 2), Int(Clock.Height / 2) + 2), _
                                     New Point(Int(Clock.Width / 2) + 2, Int(Clock.Height / 2))}

        handMinute.Path.AddLines(drawMinute)
        handMinute.filled = True


        'Xây dựng tọa độ kim giây
        '
        handSecond.Path.AddLine(center, New PointF(Int(Clock.Width / 2), 15))
    End Sub
#End Region

    Private Sub btnDesktop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesktop.Click

        keybd_event(VK_LWIN, 0, 0, 0)
        keybd_event(VK_D, 0, 0, 0)
        keybd_event(VK_D, 0, KEYEVENTF_KEYUP, 0)
        keybd_event(VK_LWIN, 0, KEYEVENTF_KEYUP, 0)
    End Sub

    Private Sub btnDongY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDongY.Click
        Me.Dispose()
        Me.Close()
        Dim frm As New FrmLogin
        frm.ShowDialog()
    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        'Kiểm tra các thông sô:nếu thỏa mãn đầy đủ thì mới có thể thoát được
        Dim Frm As New FrmCheck
        Frm.ShowDialog()
        If Frm.myreturn Then
            If CMessageBox.Show("Bạn có chắc chắn muốn thoát không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                Close()
            End If
        Else
            CMessageBox.Show("Bạn chưa thể thoát được chương trình, bạn cần phải chỉnh lại các lỗi theo chức năng kiểm tra !!!")
        End If
    End Sub
    Private Sub ExplorerBarMenu_ItemClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinExplorerBar.ItemEventArgs) Handles ExplorerBarMenu.ItemClick
        e.Item.Settings.AppearancesSmall.Appearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.False
        e.Item.Settings.AppearancesSmall.Appearance.FontData.Italic = Infragistics.Win.DefaultableBoolean.True
        Select Case e.Item.Key
            'Hệ Thống
        Case "HT1"
                Dim Frm As New FrmXacNhanCa
                Frm.ShowDialog()
            Case "HT2"
                Dim Frm As New FrmCacBangDanhMuc
                Frm.ShowDialog()
            Case "HT3"
                Dim Frm As New FrmCacBangDanhMucCuoc
                Frm.ShowDialog()
            Case "HT4"
                Dim Frm As New FrmThongTinNguoiDung
                Frm.ShowDialog()
            Case "HT5"
                Dim Frm As New FrmQuanLyNguoiDung
                Frm.ShowDialog()
            Case "HT6"
                Dim Frm As New FrmThongTinHeThong
                Frm.ShowDialog()
            Case "HT7"
                Dim Frm As New FrmDichVuDuLieu
                Frm.ShowDialog()
            Case "HT8"
                Dim Frm As New FrmCauHinhCoSoDuLieu
                Frm.ShowDialog()
            Case "HT9"
                Dim Frm As New FrmThietLapThamSoHeThong
                Frm.ShowDialog()
            Case "HT10"
                Dim Frm As New FrmNhapTyGia
                Frm.ShowDialog()
            Case "HT11"
                Dim Frm As New FrmKhoaSoLieu
                Frm.ShowDialog()
            Case "HT12"
                Dim Frm As New FrmEventViewer
                frm.ShowDialog()
            Case "HT13"
                Dim Frm As New Frm_Truyen_Predes_Resdes
                Frm.ShowDialog()
            Case "HT14"
                Try
                    Dim Frm As New frmKiemTraLacHuongDen
                    Frm.ShowDialog()
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try

            Case "HT15"
                Try
                    Dim Frm As New frmKiemTraLacHuongDi
                    Frm.ShowDialog()
                    ' =================================================================
                    'Khai thác
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try
            Case "KT1"
                Dim Frm As New FrmXacNhanE2Den
                Frm.ShowDialog()
            Case "KT2"
                Dim Frm As New FrmThietLapE2Di
                Frm.ShowDialog()
            Case "KT3"
                Dim Frm As New FrmSuaChuaE1
                Frm.ShowDialog()
            Case "KT4"
                Dim Frm As New FrmSuaChuaE2
                Frm.ShowDialog()
            Case "KT5"
                Dim Frm As New FrmDoiSoatDiDen
                Frm.ShowDialog()
            Case "KT6"
                Dim Frm As New FrmKhoaSoLieu
                Frm.ShowDialog()
                'Case "KT7"
                '    Dim Frm As New FrmCOD 'FrmTruyenE2
                '    Frm.ShowDialog()
            Case "KT8"
                Dim Frm As New FrmSuaChuaE2Den
                Frm.ShowDialog()
            Case "INB001"
                Dim frm As New FrmXacNhanE2Den_INB001
                frm.ShowDialog()
                'Quốc Tế Đi
            Case "OUT001"
                Dim frm As New FrmThietLapDi_Out001
                frm.ShowDialog()
            Case "QT1"
                Dim Frm As New FrmXacNhanDen
                Frm.ShowDialog()
            Case "QT2"
                Dim Frm As New FrmThietLapDi
                Frm.ShowDialog()
            Case "QT3"
                Dim Frm As New FrmThongKeBaoCao
                Frm.ShowDialog()
            Case "QT4"
                Dim Frm As New FrmSuaChuaE2_OutBout
                frm.ShowDialog()
            Case "QT5"
                Dim Frm As New FrmSuaChuaE2Den_OutBout
                frm.ShowDialog()
            Case "QT6"
                Dim Frm As New FrmSuaChuaE1
                frm.ShowDialog()
            Case "QT7"
                Dim Frm As New FrmInGiayBienNhan
                Frm.ShowDialog()
            Case "QT8"
                Dim Frm As New Frm_Ems_Shipping
                Frm.ShowDialog()
            Case "QT9"
                Dim Frm As New FrmBao_Cao_E_Shipping
                Frm.ShowDialog()
            Case "QT10"
                Dim Frm As New frmThongKeE1ChuyenDauMa
                Frm.ShowDialog()
            Case "TK1"
                Dim Frm As New FrmTimKiemE1
                Frm.ShowDialog()
            Case "TK2"
                Dim Frm As New FrmDinhVi
                Frm.ShowDialog()
            Case "BP1"
                Dim Frm As New FrmBaoPhat
                Frm.ShowDialog()

            Case "BC1"
                Dim Frm As New FrmTongHopSanLuong
                Frm.ShowDialog()
            Case "BC2"
                Dim Frm As New FrmBaoCaoCOD
                Frm.ShowDialog()
            Case "BC3"
                Dim Frm As New FrmTongHopDoanhThu
                Frm.ShowDialog()

            Case "TG1" 'Caaoh nhật chương trình
                Dim MyFile As New FileInfo(Application.StartupPath & "\Ems_Update.exe")
                If MyFile.Exists Then
                    Directory.SetCurrentDirectory(Application.StartupPath)
                    Dim myProcess As Process = New Process
                    myProcess.StartInfo.FileName = "Ems_Update.exe"
                    myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
                    myProcess.StartInfo.CreateNoWindow = True
                    myProcess.Start()
                    myProcess.Close()
                    Application.Exit()
                Else
                    MessageBox.Show("Không tồn tại file cập nhật chương trình!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Case "TG2"
                Dim frm As New FrmHuongDanSuDung
                frm.ShowDialog()
            Case "TG3" 'Giới thiệu chương trình   
                Dim Frm As New FrmGioiThieuChuongTrinh
                Frm.ShowDialog()
                'Dim Frm As New Frm_Chinh_Sua_CN56
                'frm.ShowDialog()

                'Chức năng
            Case "CN1"
                Dim Frm As New FrmQuanLyChuyenThu
                Frm.ShowDialog()
            Case "CN2"
                Dim Frm As New frmBaoCaoHaiQuan
                Frm.ShowDialog()
            Case "CN3"
                Dim Frm As New FrmThongTinKeToan
                Frm.ShowDialog()
            Case "CN4"
                Dim Frm As New FrmBan_Ke_A1
                Frm.ShowDialog()
            Case "CN5"
                Dim Frm As New Frm_Thiet_Lap_Va_In_Ban_Ke
                Frm.ShowDialog()
            Case "CN6"
                Dim Frm As New Frm_Tao_Va_In_CN55
                Frm.ShowDialog()
            Case "CN7"
                Dim Frm As New Frm_Bao_Cao_Quan_Ly_Kho_Hai_Quan
                Frm.ShowDialog()
            Case "CN8"
                Dim Frm As New FrmBan_Ke_A1_Noi_Bai
                Frm.ShowDialog()

                'Quản lý thu nợ Hải quan
            Case "HQ1"
                Dim Frm As New Frm_Quan_Ly_Thu_No_Hai_Quan
                Frm.ShowDialog()
            Case "HQ2"
                Dim Frm As New Frm_Tong_Hop_Thue_Le_Phi_HQ
                Frm.ShowDialog()
                '===================
                'Đối soát quốc tế
            Case "DSQT1"
                Dim Frm As New Frm_Danh_Muc_Doi_Soat
                Frm.ShowDialog()
            Case "DSQT2"
                Dim Frm As New Frm_Cuoc_Quoc_Te_Den
                Frm.ShowDialog()
            Case "DSQT3"
                Dim Frm As New Frm_Cuoc_Quoc_Te_Di
                Frm.ShowDialog()
            Case "DSQT4"
                Dim Frm As New Frm_Cuoc_Qua_Giang_Qua_HK
                Frm.ShowDialog()
            Case "DSQT5"
                Dim Frm As New Frm_Cuoc_Qua_Giang_Qua_SIN
                Frm.ShowDialog()
            Case "DSQT6"
                Dim Frm As New Frm_Cuoc_Qua_Giang_Qua_JNE
                Frm.ShowDialog()
            Case "DSQT7"
                Dim Frm As New Frm_Doi_Soat_Quoc_Te
                Frm.ShowDialog()
                '=========================
                'Bưu phẩm bưu kiện
            Case "BPBK1"
                Dim Frm As New Frm_Thong_Ke_Bao_Cao_Buu_Pham_Buu_Kien
                Frm.ShowDialog()
                '===========================
                'Kiểm hóa hàng xuất khẩu
            Case "KH1"
                If GBuu_Cuc_Khai_Thac.ToString().Substring(0, 1) = "7" Then
                    GPost_Office = 2
                    Dim Frm As New Frm_Lap_To_Khai_Hang_Xuat_HCM
                    Frm.ShowDialog()
                Else
                    GPost_Office = 1
                    Dim Frm As New Frm_Lap_To_Khai_Hang_Xuat
                    Frm.ShowDialog()
                End If
            Case "KH2"
                Dim Frm As New Frm_Tim_Kiem_To_Khai
                Frm.ShowDialog()
            Case "KH3"
                Dim Frm As New Frm_Sua_Chua_To_Khai
                Frm.ShowDialog()
                'Quản lý túi gói nội địa
            Case "QLTG0"
                Dim frm As New FrmIn_BC37_Tap_Trung
                frm.ShowDialog()
            Case "QLTG1"
                Dim frm As New FrmMonitor_Tuyen_Giao_BC37
                frm.ShowDialog()
            Case "QLTG2"
                Dim frm As New FrmDuLieu
                frm.ShowDialog()
            Case "QLTG3"
                Dim frm As New FrmIn_Nhan_E4_Label
                frm.ShowDialog()
            Case "QLTG4"
                Dim frm As New frmBaoCaoBC37
                frm.ShowDialog()
            Case "QLTG5"
                Dim frm As New FrmQuan_Ly_BC37_Den_Di
                frm.ShowDialog()

        End Select
        e.Item.Settings.AppearancesSmall.Appearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.False
        e.Item.Settings.AppearancesSmall.Appearance.FontData.Italic = Infragistics.Win.DefaultableBoolean.False
    End Sub

    Private Sub FrmMain_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        statusBar.Panels(0).Text = "Caps Lock: No"
        statusBar.Panels(1).Text = "Num Lock: No"
        statusBar.Panels(2).Text = "Scroll Lock: No"
        Select Case e.KeyCode
            Case Keys.CapsLock
                statusBar.Panels(0).Text = "Caps Lock: Yes"
            Case Keys.NumLock
                statusBar.Panels(1).Text = "Num Lock: Yes"
            Case Keys.Scroll
                statusBar.Panels(2).Text = "Scroll Lock: Yes"
        End Select

    End Sub

    Private Sub FrmMain_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Kiểm tra xem điều kiện có đủ ko đê cho phép đóng cửa sổ
    End Sub

    Private Sub ExplorerBarMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExplorerBarMenu.Click

    End Sub
End Class

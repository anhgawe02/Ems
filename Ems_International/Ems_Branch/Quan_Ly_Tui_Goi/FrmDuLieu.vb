Imports System.Net.Dns
Imports System.Collections
Imports Ems_International_Logic.EMS
Public Class FrmDuLieu
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
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton3 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents tabControl As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents cbMaBcKhaiThac As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents dgChangVC As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgTuyenVC As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents prgRead As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    Friend WithEvents prbPTVC As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    Friend WithEvents dgPhuongTienVC As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraButton4 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents prbDTVC As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    Friend WithEvents dgDoiTacVC As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents btnDuongThu As Infragistics.Win.Misc.UltraButton
    Friend WithEvents prbDuongThu As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    Friend WithEvents dgRoadMap As Infragistics.Win.UltraWinGrid.UltraGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Bc_Khai_Thac", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Bc_Khai_Thac")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IsPO")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("HienThi", -1)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Tuyen")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Tuyen_Char")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Tuyen", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Dot")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh_Goc_Char")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh_Dich_Char")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh_Goc")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh_Dich")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Huong")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("HienThi", -1)
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chang")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Tuyen")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Goc")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Bc_Goc")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Dich")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Bc_Dich", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cap_Bc_Dich")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Di")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Den")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("STT")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("HienThi", -1)
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NAME")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IS_LOCK")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("HienThi", -1)
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PARTNER_CODE")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ADDRESS")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PHONE_NUMBER")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TAX")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ACCOUNT_NUMBER")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BANK_NAME")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NAME_OF_PC")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CONTACT_PHONE_NUMBER")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_NUMBER")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_WHERE")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_DATE")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PO_ID_CONTACT")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NAME")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NAME_PARTNER")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Duong_Thu", -1)
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PO_CODE_1")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PO_CODE_2")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NAME_1")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NAME_2")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LONGITUDE_EAST")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LONGITUDE_WEST")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LATITUDE_NORTH")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LATITUDE_SOUTH")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("COMMENTS")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NAME")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TYPE")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmDuLieu))
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.prgRead = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar
        Me.cbMaBcKhaiThac = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.dgTuyenVC = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.dgChangVC = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.dgPhuongTienVC = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.prbPTVC = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar
        Me.UltraButton3 = New Infragistics.Win.Misc.UltraButton
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.prbDTVC = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar
        Me.dgDoiTacVC = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraButton4 = New Infragistics.Win.Misc.UltraButton
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.prbDuongThu = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar
        Me.btnDuongThu = New Infragistics.Win.Misc.UltraButton
        Me.dgRoadMap = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.tabControl = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.cbMaBcKhaiThac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgTuyenVC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgChangVC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.dgPhuongTienVC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.dgDoiTacVC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.dgRoadMap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.prgRead)
        Me.UltraTabPageControl1.Controls.Add(Me.cbMaBcKhaiThac)
        Me.UltraTabPageControl1.Controls.Add(Me.dgTuyenVC)
        Me.UltraTabPageControl1.Controls.Add(Me.dgChangVC)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraButton1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 25)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(772, 532)
        '
        'prgRead
        '
        Me.prgRead.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.prgRead.Location = New System.Drawing.Point(4, 28)
        Me.prgRead.Name = "prgRead"
        Me.prgRead.Size = New System.Drawing.Size(766, 20)
        Me.prgRead.Step = 100
        Me.prgRead.TabIndex = 26
        Me.prgRead.Text = "[Formatted]"
        '
        'cbMaBcKhaiThac
        '
        Me.cbMaBcKhaiThac.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn1.Header.Caption = "Mã bưu cục"
        UltraGridColumn1.Header.VisiblePosition = 1
        UltraGridColumn1.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn1.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(110, 0)
        UltraGridColumn1.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn1.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn2.Header.Caption = "Tên bưu cục"
        UltraGridColumn2.Header.VisiblePosition = 0
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        UltraGridBand1.UseRowLayout = True
        Me.cbMaBcKhaiThac.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance1.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance1.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance1.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance1.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbMaBcKhaiThac.DisplayLayout.Override.HeaderAppearance = Appearance1
        Me.cbMaBcKhaiThac.DisplayMember = "Ten_Bc_Khai_Thac"
        Me.cbMaBcKhaiThac.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMaBcKhaiThac.Location = New System.Drawing.Point(8, 4)
        Me.cbMaBcKhaiThac.Name = "cbMaBcKhaiThac"
        Me.cbMaBcKhaiThac.Size = New System.Drawing.Size(178, 21)
        Me.cbMaBcKhaiThac.TabIndex = 25
        Me.cbMaBcKhaiThac.ValueMember = "Ma_Bc_Khai_Thac"
        '
        'dgTuyenVC
        '
        Me.dgTuyenVC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgTuyenVC.DisplayLayout.AddNewBox.Prompt = " "
        Appearance2.BackColor = System.Drawing.Color.White
        Appearance2.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgTuyenVC.DisplayLayout.Appearance = Appearance2
        UltraGridBand2.CardSettings.ShowCaption = False
        UltraGridColumn4.Header.VisiblePosition = 0
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 1
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.Caption = "Tên tuyến"
        UltraGridColumn6.Header.VisiblePosition = 2
        UltraGridColumn7.Header.Caption = "Đợt"
        UltraGridColumn7.Header.VisiblePosition = 3
        UltraGridColumn8.Header.Caption = "Ký hiệu tỉnh gốc"
        UltraGridColumn8.Header.VisiblePosition = 4
        UltraGridColumn9.Header.Caption = "Ký hiệu tỉnh đích"
        UltraGridColumn9.Header.VisiblePosition = 5
        UltraGridColumn10.Header.Caption = "Mã tỉnh gốc"
        UltraGridColumn10.Header.VisiblePosition = 6
        UltraGridColumn11.Header.Caption = "Mã tỉnh đích"
        UltraGridColumn11.Header.VisiblePosition = 7
        UltraGridColumn12.Header.Caption = "Hướng"
        UltraGridColumn12.Header.VisiblePosition = 8
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12})
        UltraGridBand2.Header.Caption = "Danh sách E1 trong bản kê E2"
        Appearance3.ImageVAlign = Infragistics.Win.VAlign.Bottom
        UltraGridBand2.Override.RowSelectorAppearance = Appearance3
        UltraGridBand2.Override.RowSelectorWidth = 20
        UltraGridBand2.UseRowLayout = True
        Me.dgTuyenVC.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.dgTuyenVC.DisplayLayout.InterBandSpacing = 10
        Me.dgTuyenVC.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Me.dgTuyenVC.DisplayLayout.Override.CardAreaAppearance = Appearance4
        Me.dgTuyenVC.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance5.ForeColor = System.Drawing.Color.Black
        Appearance5.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance5.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgTuyenVC.DisplayLayout.Override.HeaderAppearance = Appearance5
        Me.dgTuyenVC.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Appearance6.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTuyenVC.DisplayLayout.Override.RowAppearance = Appearance6
        Appearance7.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance7.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.dgTuyenVC.DisplayLayout.Override.RowSelectorAppearance = Appearance7
        Me.dgTuyenVC.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgTuyenVC.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance8.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance8.ForeColor = System.Drawing.Color.Black
        Me.dgTuyenVC.DisplayLayout.Override.SelectedRowAppearance = Appearance8
        Me.dgTuyenVC.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgTuyenVC.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgTuyenVC.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.ExtendedAutoDrag
        Me.dgTuyenVC.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTuyenVC.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgTuyenVC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgTuyenVC.Location = New System.Drawing.Point(8, 50)
        Me.dgTuyenVC.Name = "dgTuyenVC"
        Me.dgTuyenVC.Size = New System.Drawing.Size(378, 480)
        Me.dgTuyenVC.TabIndex = 23
        Me.dgTuyenVC.Text = "Tuyến vận chuyển"
        '
        'dgChangVC
        '
        Me.dgChangVC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgChangVC.DisplayLayout.AddNewBox.Prompt = " "
        Appearance9.BackColor = System.Drawing.Color.White
        Appearance9.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgChangVC.DisplayLayout.Appearance = Appearance9
        UltraGridBand3.CardSettings.ShowCaption = False
        UltraGridColumn13.Header.VisiblePosition = 0
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 1
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.Caption = "Bc gốc"
        UltraGridColumn15.Header.VisiblePosition = 2
        UltraGridColumn16.Header.Caption = "Tên Bc gốc"
        UltraGridColumn16.Header.VisiblePosition = 3
        UltraGridColumn17.Header.Caption = "Bc đích"
        UltraGridColumn17.Header.VisiblePosition = 4
        UltraGridColumn18.Header.Caption = "Tên Bc đích"
        UltraGridColumn18.Header.VisiblePosition = 5
        UltraGridColumn19.Header.Caption = "Cấp Bc đích"
        UltraGridColumn19.Header.VisiblePosition = 6
        UltraGridColumn20.Header.Caption = "Giờ đi"
        UltraGridColumn20.Header.VisiblePosition = 7
        UltraGridColumn21.Header.Caption = "Giờ đến"
        UltraGridColumn21.Header.VisiblePosition = 8
        UltraGridColumn22.Header.VisiblePosition = 9
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22})
        UltraGridBand3.Header.Caption = "Danh sách E1 trong bản kê E2"
        Appearance10.ImageVAlign = Infragistics.Win.VAlign.Bottom
        UltraGridBand3.Override.RowSelectorAppearance = Appearance10
        UltraGridBand3.Override.RowSelectorWidth = 20
        UltraGridBand3.UseRowLayout = True
        Me.dgChangVC.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.dgChangVC.DisplayLayout.InterBandSpacing = 10
        Me.dgChangVC.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Me.dgChangVC.DisplayLayout.Override.CardAreaAppearance = Appearance11
        Me.dgChangVC.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance12.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance12.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance12.ForeColor = System.Drawing.Color.Black
        Appearance12.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance12.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgChangVC.DisplayLayout.Override.HeaderAppearance = Appearance12
        Me.dgChangVC.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Appearance13.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgChangVC.DisplayLayout.Override.RowAppearance = Appearance13
        Appearance14.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance14.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.dgChangVC.DisplayLayout.Override.RowSelectorAppearance = Appearance14
        Me.dgChangVC.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgChangVC.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance15.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance15.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance15.ForeColor = System.Drawing.Color.Black
        Me.dgChangVC.DisplayLayout.Override.SelectedRowAppearance = Appearance15
        Me.dgChangVC.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgChangVC.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgChangVC.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.ExtendedAutoDrag
        Me.dgChangVC.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgChangVC.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgChangVC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgChangVC.Location = New System.Drawing.Point(388, 50)
        Me.dgChangVC.Name = "dgChangVC"
        Me.dgChangVC.Size = New System.Drawing.Size(382, 480)
        Me.dgChangVC.TabIndex = 22
        Me.dgChangVC.Text = "Chặng vận chuyển"
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(188, 0)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(584, 28)
        Me.UltraButton1.TabIndex = 0
        Me.UltraButton1.Text = "Lấy dữ liệu"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.dgPhuongTienVC)
        Me.UltraTabPageControl3.Controls.Add(Me.prbPTVC)
        Me.UltraTabPageControl3.Controls.Add(Me.UltraButton3)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(772, 532)
        '
        'dgPhuongTienVC
        '
        Me.dgPhuongTienVC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgPhuongTienVC.DisplayLayout.AddNewBox.Prompt = " "
        Appearance16.BackColor = System.Drawing.Color.White
        Appearance16.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgPhuongTienVC.DisplayLayout.Appearance = Appearance16
        UltraGridBand4.CardSettings.ShowCaption = False
        UltraGridColumn23.Header.VisiblePosition = 0
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.Header.Caption = "Tên phương tiện"
        UltraGridColumn24.Header.VisiblePosition = 1
        UltraGridColumn25.Header.VisiblePosition = 2
        UltraGridColumn25.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn23, UltraGridColumn24, UltraGridColumn25})
        UltraGridBand4.Header.Caption = "Danh sách E1 trong bản kê E2"
        Appearance17.ImageVAlign = Infragistics.Win.VAlign.Bottom
        UltraGridBand4.Override.RowSelectorAppearance = Appearance17
        UltraGridBand4.Override.RowSelectorWidth = 20
        UltraGridBand4.UseRowLayout = True
        Me.dgPhuongTienVC.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.dgPhuongTienVC.DisplayLayout.InterBandSpacing = 10
        Me.dgPhuongTienVC.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Me.dgPhuongTienVC.DisplayLayout.Override.CardAreaAppearance = Appearance18
        Me.dgPhuongTienVC.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance19.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance19.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance19.ForeColor = System.Drawing.Color.Black
        Appearance19.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance19.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgPhuongTienVC.DisplayLayout.Override.HeaderAppearance = Appearance19
        Me.dgPhuongTienVC.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Appearance20.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgPhuongTienVC.DisplayLayout.Override.RowAppearance = Appearance20
        Appearance21.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance21.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.dgPhuongTienVC.DisplayLayout.Override.RowSelectorAppearance = Appearance21
        Me.dgPhuongTienVC.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgPhuongTienVC.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance22.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance22.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance22.ForeColor = System.Drawing.Color.Black
        Me.dgPhuongTienVC.DisplayLayout.Override.SelectedRowAppearance = Appearance22
        Me.dgPhuongTienVC.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgPhuongTienVC.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgPhuongTienVC.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.ExtendedAutoDrag
        Me.dgPhuongTienVC.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgPhuongTienVC.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgPhuongTienVC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgPhuongTienVC.Location = New System.Drawing.Point(16, 64)
        Me.dgPhuongTienVC.Name = "dgPhuongTienVC"
        Me.dgPhuongTienVC.Size = New System.Drawing.Size(752, 440)
        Me.dgPhuongTienVC.TabIndex = 29
        Me.dgPhuongTienVC.Text = "Phương tiện vận chuyển"
        '
        'prbPTVC
        '
        Me.prbPTVC.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.prbPTVC.Location = New System.Drawing.Point(8, 40)
        Me.prbPTVC.Name = "prbPTVC"
        Me.prbPTVC.Size = New System.Drawing.Size(760, 20)
        Me.prbPTVC.Step = 100
        Me.prbPTVC.TabIndex = 28
        Me.prbPTVC.Text = "[Formatted]"
        '
        'UltraButton3
        '
        Me.UltraButton3.Location = New System.Drawing.Point(8, 8)
        Me.UltraButton3.Name = "UltraButton3"
        Me.UltraButton3.Size = New System.Drawing.Size(760, 32)
        Me.UltraButton3.TabIndex = 0
        Me.UltraButton3.Text = "Lấy dữ liệu"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.prbDTVC)
        Me.UltraTabPageControl4.Controls.Add(Me.dgDoiTacVC)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraButton4)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(772, 532)
        '
        'prbDTVC
        '
        Me.prbDTVC.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.prbDTVC.Location = New System.Drawing.Point(10, 34)
        Me.prbDTVC.Name = "prbDTVC"
        Me.prbDTVC.Size = New System.Drawing.Size(758, 20)
        Me.prbDTVC.Step = 100
        Me.prbDTVC.TabIndex = 31
        Me.prbDTVC.Text = "[Formatted]"
        '
        'dgDoiTacVC
        '
        Me.dgDoiTacVC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgDoiTacVC.DisplayLayout.AddNewBox.Prompt = " "
        Appearance23.BackColor = System.Drawing.Color.White
        Appearance23.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgDoiTacVC.DisplayLayout.Appearance = Appearance23
        UltraGridBand5.CardSettings.ShowCaption = False
        UltraGridColumn26.Header.VisiblePosition = 0
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.Header.Caption = "Mã đối tác"
        UltraGridColumn27.Header.VisiblePosition = 1
        UltraGridColumn28.Header.Caption = "Địa chỉ"
        UltraGridColumn28.Header.VisiblePosition = 3
        UltraGridColumn29.Header.Caption = "Điện thoại"
        UltraGridColumn29.Header.VisiblePosition = 4
        UltraGridColumn30.Header.Caption = "Thuế"
        UltraGridColumn30.Header.VisiblePosition = 5
        UltraGridColumn31.Header.Caption = "Số tk"
        UltraGridColumn31.Header.VisiblePosition = 6
        UltraGridColumn32.Header.Caption = "Ngân hàng"
        UltraGridColumn32.Header.VisiblePosition = 7
        UltraGridColumn33.Header.Caption = "Tên Cty"
        UltraGridColumn33.Header.VisiblePosition = 8
        UltraGridColumn34.Header.Caption = "Điện thoại liên hệ"
        UltraGridColumn34.Header.VisiblePosition = 9
        UltraGridColumn35.Header.VisiblePosition = 10
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.Header.VisiblePosition = 11
        UltraGridColumn36.Hidden = True
        UltraGridColumn37.Header.VisiblePosition = 12
        UltraGridColumn37.Hidden = True
        UltraGridColumn38.Header.Caption = "PO"
        UltraGridColumn38.Header.VisiblePosition = 13
        UltraGridColumn39.Header.Caption = "Tên phương tiện"
        UltraGridColumn39.Header.VisiblePosition = 2
        UltraGridColumn40.Header.Caption = "Tên đối tác"
        UltraGridColumn40.Header.VisiblePosition = 14
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40})
        UltraGridBand5.Header.Caption = "Danh sách E1 trong bản kê E2"
        Appearance24.ImageVAlign = Infragistics.Win.VAlign.Bottom
        UltraGridBand5.Override.RowSelectorAppearance = Appearance24
        UltraGridBand5.Override.RowSelectorWidth = 20
        UltraGridBand5.UseRowLayout = True
        Me.dgDoiTacVC.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.dgDoiTacVC.DisplayLayout.InterBandSpacing = 10
        Me.dgDoiTacVC.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Me.dgDoiTacVC.DisplayLayout.Override.CardAreaAppearance = Appearance25
        Me.dgDoiTacVC.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance26.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance26.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance26.ForeColor = System.Drawing.Color.Black
        Appearance26.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance26.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgDoiTacVC.DisplayLayout.Override.HeaderAppearance = Appearance26
        Me.dgDoiTacVC.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Appearance27.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDoiTacVC.DisplayLayout.Override.RowAppearance = Appearance27
        Appearance28.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance28.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.dgDoiTacVC.DisplayLayout.Override.RowSelectorAppearance = Appearance28
        Me.dgDoiTacVC.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgDoiTacVC.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance29.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance29.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance29.ForeColor = System.Drawing.Color.Black
        Me.dgDoiTacVC.DisplayLayout.Override.SelectedRowAppearance = Appearance29
        Me.dgDoiTacVC.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgDoiTacVC.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgDoiTacVC.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.ExtendedAutoDrag
        Me.dgDoiTacVC.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDoiTacVC.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgDoiTacVC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDoiTacVC.Location = New System.Drawing.Point(0, 56)
        Me.dgDoiTacVC.Name = "dgDoiTacVC"
        Me.dgDoiTacVC.Size = New System.Drawing.Size(776, 480)
        Me.dgDoiTacVC.TabIndex = 30
        Me.dgDoiTacVC.Text = "Đối tác vận chuyển"
        '
        'UltraButton4
        '
        Me.UltraButton4.Location = New System.Drawing.Point(8, 2)
        Me.UltraButton4.Name = "UltraButton4"
        Me.UltraButton4.Size = New System.Drawing.Size(762, 32)
        Me.UltraButton4.TabIndex = 0
        Me.UltraButton4.Text = "Lấy dữ liệu"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.prbDuongThu)
        Me.UltraTabPageControl2.Controls.Add(Me.btnDuongThu)
        Me.UltraTabPageControl2.Controls.Add(Me.dgRoadMap)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(772, 532)
        '
        'prbDuongThu
        '
        Me.prbDuongThu.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.prbDuongThu.Location = New System.Drawing.Point(8, 40)
        Me.prbDuongThu.Name = "prbDuongThu"
        Me.prbDuongThu.Size = New System.Drawing.Size(760, 20)
        Me.prbDuongThu.Step = 100
        Me.prbDuongThu.TabIndex = 32
        Me.prbDuongThu.Text = "[Formatted]"
        '
        'btnDuongThu
        '
        Me.btnDuongThu.Location = New System.Drawing.Point(8, 8)
        Me.btnDuongThu.Name = "btnDuongThu"
        Me.btnDuongThu.Size = New System.Drawing.Size(760, 32)
        Me.btnDuongThu.TabIndex = 31
        Me.btnDuongThu.Text = "Lấy dữ liệu"
        '
        'dgRoadMap
        '
        Me.dgRoadMap.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgRoadMap.DisplayLayout.AddNewBox.Prompt = " "
        Appearance30.BackColor = System.Drawing.Color.White
        Appearance30.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance30.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgRoadMap.DisplayLayout.Appearance = Appearance30
        UltraGridBand6.CardSettings.ShowCaption = False
        UltraGridColumn41.Header.VisiblePosition = 0
        UltraGridColumn42.Header.Caption = "Mã 1"
        UltraGridColumn42.Header.VisiblePosition = 1
        UltraGridColumn43.Header.Caption = "Mã 2"
        UltraGridColumn43.Header.VisiblePosition = 2
        UltraGridColumn44.Header.Caption = "Tên 1"
        UltraGridColumn44.Header.VisiblePosition = 3
        UltraGridColumn45.Header.Caption = "Tên 2"
        UltraGridColumn45.Header.VisiblePosition = 4
        UltraGridColumn46.Header.VisiblePosition = 5
        UltraGridColumn46.Hidden = True
        UltraGridColumn47.Header.VisiblePosition = 6
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.Header.VisiblePosition = 7
        UltraGridColumn48.Hidden = True
        UltraGridColumn49.Header.VisiblePosition = 8
        UltraGridColumn49.Hidden = True
        UltraGridColumn50.Header.VisiblePosition = 9
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.Header.VisiblePosition = 10
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.Header.VisiblePosition = 11
        UltraGridColumn52.Hidden = True
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52})
        UltraGridBand6.Header.Caption = "iD"
        UltraGridBand6.Hidden = True
        Appearance31.ImageVAlign = Infragistics.Win.VAlign.Bottom
        UltraGridBand6.Override.RowSelectorAppearance = Appearance31
        UltraGridBand6.Override.RowSelectorWidth = 20
        UltraGridBand6.UseRowLayout = True
        Me.dgRoadMap.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.dgRoadMap.DisplayLayout.InterBandSpacing = 10
        Me.dgRoadMap.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance32.BackColor = System.Drawing.Color.Transparent
        Me.dgRoadMap.DisplayLayout.Override.CardAreaAppearance = Appearance32
        Me.dgRoadMap.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance33.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance33.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance33.ForeColor = System.Drawing.Color.Black
        Appearance33.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance33.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgRoadMap.DisplayLayout.Override.HeaderAppearance = Appearance33
        Me.dgRoadMap.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Appearance34.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgRoadMap.DisplayLayout.Override.RowAppearance = Appearance34
        Appearance35.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance35.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.dgRoadMap.DisplayLayout.Override.RowSelectorAppearance = Appearance35
        Me.dgRoadMap.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgRoadMap.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance36.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance36.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance36.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance36.ForeColor = System.Drawing.Color.Black
        Me.dgRoadMap.DisplayLayout.Override.SelectedRowAppearance = Appearance36
        Me.dgRoadMap.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgRoadMap.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgRoadMap.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.ExtendedAutoDrag
        Me.dgRoadMap.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgRoadMap.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgRoadMap.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgRoadMap.Location = New System.Drawing.Point(10, 64)
        Me.dgRoadMap.Name = "dgRoadMap"
        Me.dgRoadMap.Size = New System.Drawing.Size(752, 464)
        Me.dgRoadMap.TabIndex = 30
        Me.dgRoadMap.Text = "Đường thư"
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tabControl.Controls.Add(Me.UltraTabPageControl1)
        Me.tabControl.Controls.Add(Me.UltraTabPageControl3)
        Me.tabControl.Controls.Add(Me.UltraTabPageControl4)
        Me.tabControl.Controls.Add(Me.UltraTabPageControl2)
        Me.tabControl.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabControl.Location = New System.Drawing.Point(8, 8)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tabControl.Size = New System.Drawing.Size(776, 560)
        Me.tabControl.TabIndex = 72
        Me.tabControl.TabLayoutStyle = Infragistics.Win.UltraWinTabs.TabLayoutStyle.SingleRowSizeToFit
        UltraTab1.Key = "0"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Tuyến vận chuyển"
        UltraTab2.Key = "2"
        UltraTab2.TabPage = Me.UltraTabPageControl3
        UltraTab2.Text = "Phương tiện vận chuyển"
        UltraTab3.Key = "3"
        UltraTab3.TabPage = Me.UltraTabPageControl4
        UltraTab3.Text = "Đối tác vận chuyển"
        UltraTab4.Key = "1"
        UltraTab4.TabPage = Me.UltraTabPageControl2
        UltraTab4.Text = "Hướng vận chuyển"
        Me.tabControl.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3, UltraTab4})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(772, 532)
        '
        'FrmDuLieu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.Add(Me.tabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmDuLieu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh sách"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.cbMaBcKhaiThac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTuyenVC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgChangVC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.dgPhuongTienVC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.dgDoiTacVC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.dgRoadMap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim myString As String = ""
    Dim myQLTGND_APILink As New QLTGND_APILink(GConnectionString)
    Dim myTuyen_VC As New QLTGND_TUYEN_VC(GConnectionString)
    Dim myTuyen_VC_Chi_Tiet As New QLTGND_TUYEN_VC_Chi_Tiet
    Dim myChang_VC As New QLTGND_CHANG_VC(GConnectionString)
    Dim myChang_VC_Chi_Tiet As New QLTGND_CHANG_VC_Chi_Tiet
    Dim myLoai_Phuong_Tien_VC As New QLTGND_TRANSPORT_TYPE(GConnectionString)
    Dim myLoai_Phuong_Tien_VC_Chi_Tiet As New QLTGND_TRANSPORT_TYPE_Chi_Tiet
    Dim myDoi_Tac_VC As New QLTGND_PARTNER(GConnectionString)
    Dim myDoi_Tac_Vc_Chi_Tiet As New QLTGND_PARTNER_Chi_Tiet
    Dim myMa_Bc_Khai_Thac As New Ma_Bc_Khai_Thac(GConnectionString)
    Dim myQLTGND_PARTNER As New QLTGND_PARTNER(GConnectionString)
    Dim myQLTGND_PARTNER_Chi_Tiet As New QLTGND_PARTNER_Chi_Tiet
    'Dim myQLTGND_TRANSPORT_INFO As New QLTGND_TRANSPORT_INFO(GConnectionString)
    'Dim myQLTGND_TRANSPORT_INFO_Chi_Tiet As New QLTGND_TRANSPORT_INFO_Chi_Tiet
    Dim myQLTGND_ROAD_MAP As New QLTGND_ROAD_MAP(GConnectionString)
    Dim myQLTGND_ROAD_MAP_Chi_Tiet As New QLTGND_ROAD_MAP_Chi_Tiet


    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
      
        prgRead.Minimum = 1
        prgRead.Maximum = 100
        prgRead.Step = 1
        prgRead.Value = 1

        Dim myString1 As String = ""
        Dim myString2 As String = ""

        '' Tao bang CHANG VC
        Dim dataTable As New dataTable("Chang_Van_Chuyen")
        'Tao ra cac cot cua bang nay
        Dim colWork As DataColumn = New DataColumn("Id_Chang", GetType(Int32))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Id_Tuyen", GetType(Int32))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Ma_Bc_Goc", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Ten_Bc_Goc", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Ma_Bc_Dich", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Ten_Bc_Dich", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Cap_Bc_Dich", GetType(Int32))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Gio_Di", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Gio_Den", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("STT", GetType(Int32))
        dataTable.Columns.Add(colWork)
        prgRead.PerformStep()

        '' Tao bang TUYEN VC
        Dim dataTable2 As New dataTable("Tuyen_Van_Chuyen")
        'Tao ra cac cot cua bang nay
        Dim colWork2 As DataColumn = New DataColumn("Id_Tuyen", GetType(Int32))
        dataTable2.Columns.Add(colWork2)
        colWork2 = New DataColumn("Id_Tuyen_Char", GetType(String))
        dataTable2.Columns.Add(colWork2)
        colWork2 = New DataColumn("Ten_Tuyen", GetType(String))
        dataTable2.Columns.Add(colWork2)
        colWork2 = New DataColumn("Id_Dot", GetType(String))
        dataTable2.Columns.Add(colWork2)
        colWork2 = New DataColumn("Ma_Tinh_Goc_Char", GetType(String))
        dataTable2.Columns.Add(colWork2)
        colWork2 = New DataColumn("Ma_Tinh_Dich_Char", GetType(String))
        dataTable2.Columns.Add(colWork2)
        colWork2 = New DataColumn("Ma_Tinh_Goc", GetType(String))
        dataTable2.Columns.Add(colWork2)
        colWork2 = New DataColumn("Ma_Tinh_Dich", GetType(String))
        dataTable2.Columns.Add(colWork2)
        colWork2 = New DataColumn("Id_Huong", GetType(String))
        dataTable2.Columns.Add(colWork2)
        colWork2 = New DataColumn("ROUD_MAP_ID", GetType(String))
        dataTable2.Columns.Add(colWork2)
        colWork2 = New DataColumn("TYPE", GetType(String))
        dataTable2.Columns.Add(colWork2)
        colWork2 = New DataColumn("PROVINCE", GetType(String))
        dataTable2.Columns.Add(colWork2)
        colWork2 = New DataColumn("PARTNER_ID", GetType(String))
        dataTable2.Columns.Add(colWork2)
        colWork2 = New DataColumn("TRANSPORT_TYPE_ID", GetType(String))
        dataTable2.Columns.Add(colWork2)

        '' CHANG VAN CHUYEN
        myString1 = Liet_Ke_Chang_Van_Chuyen(Convert.ToString(cbMaBcKhaiThac.Value), "")
        Dim strArr() As String
        Dim n As Integer = 0
        strArr = myString1.Split("|")
        If myString1.Split("|")(0) = "00" Then
            n = strArr.Length - 3
            For i As Integer = 3 To strArr.Length - 1
                Try
                    Dim row As DataRow = dataTable.NewRow()
                    'row("Id_Chang") = IIf(strArr(i).Split("^")(0) = "", 0, strArr(i).Split("^")(0))
                    row("Id_Tuyen") = IIf(strArr(i).Split("^")(1) = "", 0, strArr(i).Split("^")(1))

                    row("Ma_Bc_Goc") = IIf(strArr(i).Split("^")(2) = "", 0, strArr(i).Split("^")(2))
                    row("Ten_Bc_Goc") = IIf(strArr(i).Split("^")(3) = "", 0, strArr(i).Split("^")(3))
                    row("Ma_Bc_Dich") = Convert.ToString(cbMaBcKhaiThac.Value)
                    row("Ten_Bc_Dich") = cbMaBcKhaiThac.Text.Trim

                    row("Cap_Bc_Dich") = IIf(strArr(i).Split("^")(4) = "", 0, strArr(i).Split("^")(4))
                    row("Gio_Di") = IIf(strArr(i).Split("^")(5) = "", 0, strArr(i).Split("^")(5))
                    row("Gio_Den") = IIf(strArr(i).Split("^")(6) = "", 0, strArr(i).Split("^")(6))
                    row("STT") = IIf(strArr(i).Split("^")(7) = "", 0, strArr(i).Split("^")(7))
                    dataTable.Rows.Add(row)

                    Dim row1 As DataRow = dataTable.NewRow()
                    'row("Id_Chang") = IIf(strArr(i).Split("^")(0) = "", 0, strArr(i).Split("^")(0))
                    row1("Id_Tuyen") = IIf(strArr(i).Split("^")(1) = "", 0, strArr(i).Split("^")(1))

                    row1("Ma_Bc_Goc") = Convert.ToString(cbMaBcKhaiThac.Value)
                    row1("Ten_Bc_Goc") = cbMaBcKhaiThac.Text.Trim
                    row1("Ma_Bc_Dich") = IIf(strArr(i).Split("^")(2) = "", 0, strArr(i).Split("^")(2))
                    row1("Ten_Bc_Dich") = IIf(strArr(i).Split("^")(3) = "", 0, strArr(i).Split("^")(3))

                    row1("Cap_Bc_Dich") = IIf(strArr(i).Split("^")(4) = "", 0, strArr(i).Split("^")(4))
                    row1("Gio_Di") = IIf(strArr(i).Split("^")(5) = "", 0, strArr(i).Split("^")(5))
                    row1("Gio_Den") = IIf(strArr(i).Split("^")(6) = "", 0, strArr(i).Split("^")(6))
                    row1("STT") = IIf(strArr(i).Split("^")(7) = "", 0, strArr(i).Split("^")(7))
                    dataTable.Rows.Add(row1)
                Catch ex As Exception
                    Console.Write(ex.ToString)
                End Try
            Next
            prgRead.Value = 50
            '' TUYEN VAN CHUYEN
            myString2 = Liet_Ke_Tuyen_Duong_Thu_Theo_Ma_BC(Convert.ToString(cbMaBcKhaiThac.Value))
            Dim strArr1() As String
            Dim m As Integer = 0
            strArr1 = myString2.Split("|")
            If myString2.Split("|")(0) = "00" Then
                m = strArr1.Length - 3
                For i As Integer = 3 To strArr1.Length - 1
                    Try
                        Dim row As DataRow = dataTable2.NewRow()
                        row("Id_Tuyen") = IIf(strArr1(i).Split("^")(0) = "", 0, strArr1(i).Split("^")(0))
                        row("Id_Tuyen_Char") = IIf(strArr1(i).Split("^")(1) = "", 0, strArr1(i).Split("^")(1))
                        row("Ten_Tuyen") = IIf(strArr1(i).Split("^")(2) = "", 0, strArr1(i).Split("^")(2))
                        row("Id_Dot") = IIf(strArr1(i).Split("^")(3) = "", 0, strArr1(i).Split("^")(3))
                        row("Ma_Tinh_Goc") = IIf(strArr1(i).Split("^")(4) = "", 0, strArr1(i).Split("^")(4))
                        row("Ma_Tinh_Dich") = IIf(strArr1(i).Split("^")(5) = "", 0, strArr1(i).Split("^")(5))
                        row("Ma_Tinh_Goc_Char") = IIf(strArr1(i).Split("^")(6) = "", 0, strArr1(i).Split("^")(6))
                        row("Ma_Tinh_Dich_Char") = IIf(strArr1(i).Split("^")(7) = "", 0, strArr1(i).Split("^")(7))
                        row("Id_Huong") = IIf(strArr1(i).Split("^")(8) = "", 0, strArr1(i).Split("^")(8))

                        row("PARTNER_ID") = IIf(strArr1(i).Split("^")(9) = "", 0, strArr1(i).Split("^")(9))
                        row("TRANSPORT_TYPE_ID") = IIf(strArr1(i).Split("^")(10) = "", 0, strArr1(i).Split("^")(10))
                        row("ROUD_MAP_ID") = IIf(strArr1(i).Split("^")(11) = "", 0, strArr1(i).Split("^")(11))
                        row("TYPE") = IIf(strArr1(i).Split("^")(12) = "", 0, strArr1(i).Split("^")(12))
                        row("PROVINCE") = IIf(strArr1(i).Split("^")(13) = "", 0, strArr1(i).Split("^")(13))

                        dataTable2.Rows.Add(row)


                    Catch ex As Exception
                        Console.Write(ex.ToString)
                    End Try
                Next
                prgRead.Value = 100
            Else
                MessageBox.Show(myString2.Split("|")(1), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


            If MessageBox.Show("Dữ liệu lấy về:" + vbNewLine + "- Chặng vận chuyển: " + Convert.ToString(n) + " bản ghi." + vbNewLine + "- Tuyến vận chuyển: " + Convert.ToString(m) + " bản ghi." + vbNewLine + "Bạn có muốn cập nhật không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then  '' Đồng ý thì xóa
                ''Xoa Chang VC
                myChang_VC.QLTGND_CHANG_VC_XOA_THEO_MABC(Convert.ToString(cbMaBcKhaiThac.Value))
                For i As Integer = 0 To dataTable.Rows.Count - 1
                    Try
                        '   myChang_VC_Chi_Tiet.Id_Chang = IIf(dataTable.Rows(i)("Id_Chang").Tostring() = "", 0, dataTable.Rows(i)("Id_Chang").Tostring())
                        myChang_VC_Chi_Tiet.Id_Tuyen = IIf(dataTable.Rows(i)("Id_Tuyen").Tostring() = "", 0, dataTable.Rows(i)("Id_Tuyen").Tostring())
                        myChang_VC_Chi_Tiet.Ma_Bc_Goc = IIf(dataTable.Rows(i)("Ma_Bc_Goc").Tostring() = "", 0, dataTable.Rows(i)("Ma_Bc_Goc").Tostring())
                        myChang_VC_Chi_Tiet.Ten_Bc_Goc = IIf(dataTable.Rows(i)("Ten_Bc_Goc").Tostring() = "", 0, dataTable.Rows(i)("Ten_Bc_Goc").Tostring())
                        myChang_VC_Chi_Tiet.Ma_Bc_Dich = IIf(dataTable.Rows(i)("Ma_Bc_Dich").Tostring() = "", 0, dataTable.Rows(i)("Ma_Bc_Dich").Tostring())
                        myChang_VC_Chi_Tiet.Ten_Bc_Dich = IIf(dataTable.Rows(i)("Ten_Bc_Dich").Tostring() = "", 0, dataTable.Rows(i)("Ten_Bc_Dich").Tostring())
                        myChang_VC_Chi_Tiet.Cap_Bc_Dich = IIf(dataTable.Rows(i)("Cap_Bc_Dich").Tostring() = "", 0, dataTable.Rows(i)("Cap_Bc_Dich").Tostring())

                        If dataTable.Rows(i)("Gio_Di").Tostring() = "" Then
                            myChang_VC_Chi_Tiet.Gio_Di = 0
                        Else
                            myChang_VC_Chi_Tiet.Gio_Di = Ham_Dung_Chung.ConvertTimeToInt(dataTable.Rows(i)("Gio_Di").Tostring())
                        End If

                        If dataTable.Rows(i)("Gio_Den").Tostring() = "" Then
                            myChang_VC_Chi_Tiet.Gio_Den = 0
                        Else
                            myChang_VC_Chi_Tiet.Gio_Den = Ham_Dung_Chung.ConvertTimeToInt(dataTable.Rows(i)("Gio_Den").Tostring())
                        End If
                        myChang_VC_Chi_Tiet.STT = IIf(dataTable.Rows(i)("STT").Tostring(), 0, dataTable.Rows(i)("STT").Tostring())

                        myChang_VC.QLTGND_CHANG_VC_Cap_Nhat(myChang_VC_Chi_Tiet.Id_Tuyen, myChang_VC_Chi_Tiet.Ma_Bc_Goc, myChang_VC_Chi_Tiet.Ten_Bc_Goc, myChang_VC_Chi_Tiet.Ma_Bc_Dich, myChang_VC_Chi_Tiet.Ten_Bc_Dich, myChang_VC_Chi_Tiet.Cap_Bc_Dich, myChang_VC_Chi_Tiet.Gio_Di, myChang_VC_Chi_Tiet.Gio_Den, myChang_VC_Chi_Tiet.STT)
                        prgRead.PerformStep()
                    Catch ex As Exception
                        Console.Write(ex.ToString)
                    End Try
                Next
                ''Xoa Tuyen VC
                myTuyen_VC.QLTGND_TUYEN_VC_XOA_THEO_MABC(Convert.ToString(cbMaBcKhaiThac.Value))
                Try
                    For i As Integer = 0 To dataTable2.Rows.Count - 1
                        myTuyen_VC_Chi_Tiet.Id_Tuyen = IIf(dataTable2.Rows(i)("Id_Tuyen").Tostring() = "", 0, dataTable2.Rows(i)("Id_Tuyen").Tostring())
                        myTuyen_VC_Chi_Tiet.Id_Tuyen_Char = IIf(dataTable2.Rows(i)("Id_Tuyen_Char").Tostring() = "", 0, dataTable2.Rows(i)("Id_Tuyen_Char").Tostring())
                        myTuyen_VC_Chi_Tiet.Ten_Tuyen = IIf(dataTable2.Rows(i)("Ten_Tuyen").Tostring() = "", 0, dataTable2.Rows(i)("Ten_Tuyen").Tostring())
                        myTuyen_VC_Chi_Tiet.Id_Dot = IIf(dataTable2.Rows(i)("Id_Dot").Tostring() = "", 0, dataTable2.Rows(i)("Id_Dot").Tostring())
                        myTuyen_VC_Chi_Tiet.Ma_Tinh_Goc_Char = IIf(dataTable2.Rows(i)("Ma_Tinh_Goc_Char").Tostring() = "", 0, dataTable2.Rows(i)("Ma_Tinh_Goc_Char").Tostring())
                        myTuyen_VC_Chi_Tiet.Ma_Tinh_Dich_Char = IIf(dataTable2.Rows(i)("Ma_Tinh_Dich_Char").Tostring() = "", 0, dataTable2.Rows(i)("Ma_Tinh_Dich_Char").Tostring())
                        myTuyen_VC_Chi_Tiet.Ma_Tinh_Goc = IIf(dataTable2.Rows(i)("Ma_Tinh_Goc").Tostring() = "", 0, dataTable2.Rows(i)("Ma_Tinh_Goc").Tostring())
                        myTuyen_VC_Chi_Tiet.Ma_Tinh_Dich = IIf(dataTable2.Rows(i)("Ma_Tinh_Dich").Tostring() = "", 0, dataTable2.Rows(i)("Ma_Tinh_Dich").Tostring())
                        myTuyen_VC_Chi_Tiet.Id_Huong = IIf(dataTable2.Rows(i)("Id_Huong").Tostring() = "", 0, dataTable2.Rows(i)("Id_Huong").Tostring())

                        myTuyen_VC_Chi_Tiet.ROUD_MAP_ID = IIf(dataTable2.Rows(i)("ROUD_MAP_ID").Tostring() = "", 0, dataTable2.Rows(i)("ROUD_MAP_ID").Tostring())
                        myTuyen_VC_Chi_Tiet.TYPE = IIf(dataTable2.Rows(i)("TYPE").Tostring() = "", 0, dataTable2.Rows(i)("TYPE").Tostring())
                        myTuyen_VC_Chi_Tiet.PROVINCE = IIf(dataTable2.Rows(i)("PROVINCE").Tostring() = "", 0, dataTable2.Rows(i)("PROVINCE").Tostring())
                        myTuyen_VC_Chi_Tiet.PARTNER_ID = IIf(dataTable2.Rows(i)("PARTNER_ID").Tostring() = "", 0, dataTable2.Rows(i)("PARTNER_ID").Tostring())
                        myTuyen_VC_Chi_Tiet.TRANSPORT_TYPE_ID = IIf(dataTable2.Rows(i)("TRANSPORT_TYPE_ID").Tostring() = "", 0, dataTable2.Rows(i)("TRANSPORT_TYPE_ID").Tostring())


                        myTuyen_VC.QLTGND_TUYEN_VC_Cap_Nhat_Them(myTuyen_VC_Chi_Tiet.Id_Tuyen, myTuyen_VC_Chi_Tiet.Id_Tuyen_Char, myTuyen_VC_Chi_Tiet.Ten_Tuyen, myTuyen_VC_Chi_Tiet.Id_Dot, myTuyen_VC_Chi_Tiet.Ma_Tinh_Goc_Char, myTuyen_VC_Chi_Tiet.Ma_Tinh_Dich_Char, myTuyen_VC_Chi_Tiet.Ma_Tinh_Goc, myTuyen_VC_Chi_Tiet.Ma_Tinh_Dich, myTuyen_VC_Chi_Tiet.Id_Huong, myTuyen_VC_Chi_Tiet.ROUD_MAP_ID, myTuyen_VC_Chi_Tiet.TYPE, myTuyen_VC_Chi_Tiet.PROVINCE, myTuyen_VC_Chi_Tiet.PARTNER_ID, myTuyen_VC_Chi_Tiet.TRANSPORT_TYPE_ID)
                    Next
                Catch ex As Exception
                    Console.Write(ex.ToString)
                End Try

                MessageBox.Show("Cập nhật thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dgChangVC.DataSource = dataTable
                dgChangVC.DataBind()
                dgTuyenVC.DataSource = dataTable2
                dgTuyenVC.DataBind()

                '' Danh mục chặng vận chuyển.
                '' Bind_Tuyen_Van_Chuyen(cbMaBcKhaiThac.Text.Trim)
            End If

        Else
        MessageBox.Show(myString1.Split("|")(1), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
  
    Private Sub UltraButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton3.Click
        prbPTVC.Minimum = 1

        prbPTVC.Step = 1
        prbPTVC.Value = 1

        Dim myString As String = ""
        Dim dataTable As New dataTable("Phuong_Tien_Van_Chuyen")
        'Tao ra cac cot cua bang nay
        Dim colWork As DataColumn = New DataColumn("ID", GetType(Int32))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("NAME", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("IS_LOCK", GetType(Int32))
        dataTable.Columns.Add(colWork)
        prbPTVC.PerformStep()
        myString = Liet_Ke_Loai_Phuong_Tien_Van_Chuyen()
        prbPTVC.PerformStep()
        Dim strArr() As String
        Dim n As Integer = 0
        strArr = myString.Split("|")
        If myString.Split("|")(0) = "00" Then
            n = strArr.Length - 3
            prbPTVC.Maximum = n
            For i As Integer = 3 To strArr.Length - 1
                Try
                    Dim row As DataRow = dataTable.NewRow()
                    row("ID") = IIf(strArr(i).Split("^")(0) = "", 0, strArr(i).Split("^")(0))
                    row("NAME") = IIf(strArr(i).Split("^")(1) = "", 0, strArr(i).Split("^")(1))
                    row("IS_LOCK") = IIf(strArr(i).Split("^")(2) = "", 0, strArr(i).Split("^")(2))
                    dataTable.Rows.Add(row)
                    prbPTVC.Value = n
                Catch ex As Exception
                    Console.Write(ex.ToString)
                End Try
            Next
            If MessageBox.Show("Có " + n.ToString + " bản ghi bạn có muốn cập nhật không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                myLoai_Phuong_Tien_VC.QLTGND_TRANSPORT_TYPE_Xoa()
                For i As Integer = 0 To dataTable.Rows.Count - 1
                    Try
                        myLoai_Phuong_Tien_VC_Chi_Tiet.ID = IIf(dataTable.Rows(i)("ID").ToString() = "", 0, dataTable.Rows(i)("ID").ToString())
                        myLoai_Phuong_Tien_VC_Chi_Tiet.NAME = dataTable.Rows(i)("NAME").ToString()
                        myLoai_Phuong_Tien_VC_Chi_Tiet.IS_LOCK = IIf(dataTable.Rows(i)("IS_LOCK").ToString() = "", 0, dataTable.Rows(i)("IS_LOCK").ToString())

                        myLoai_Phuong_Tien_VC.QLTGND_TRANSPORT_TYPE_Cap_Nhat_Them(myLoai_Phuong_Tien_VC_Chi_Tiet.ID, myLoai_Phuong_Tien_VC_Chi_Tiet.NAME, myLoai_Phuong_Tien_VC_Chi_Tiet.IS_LOCK)
                        prbPTVC.PerformStep()
                    Catch ex As Exception
                        Console.Write(ex.ToString)
                    End Try
                Next
                MessageBox.Show("Cập nhật thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dgPhuongTienVC.DataSource = dataTable
                dgPhuongTienVC.DataBind()
              
            End If

        Else
            MessageBox.Show(myString.Split("|")(1), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
    Private Sub UltraButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton4.Click
        prbDTVC.Minimum = 1

        prbDTVC.Step = 1
        prbDTVC.Value = 1

        Dim myString As String = ""
        Dim dataTable As New dataTable("Doi_Tac_VC")
        'Tao ra cac cot cua bang nay
        Dim colWork As DataColumn = New DataColumn("ID", GetType(Int32))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("PARTNER_CODE", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("ADDRESS", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("PHONE_NUMBER", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("TAX", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("ACCOUNT_NUMBER", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("BANK_NAME", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("NAME_OF_PC", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("CONTACT_PHONE_NUMBER", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("ID_NUMBER", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("ID_WHERE", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("ID_DATE", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("PO_ID_CONTACT", GetType(Integer))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("NAME", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("NAME_PARTNER", GetType(String))
        dataTable.Columns.Add(colWork)
        prbDTVC.PerformStep()

        myString = Liet_Ke_Doi_Tac_Van_Chuyen()
        prbDTVC.PerformStep()
        Dim strArr() As String
        Dim n As Integer = 0
        strArr = myString.Split("|")
        If myString.Split("|")(0) = "00" Then
            n = strArr.Length - 3
            prbDTVC.Maximum = n
            For i As Integer = 3 To strArr.Length - 1
                Try
                    Dim row As DataRow = dataTable.NewRow()
                    row("ID") = IIf(strArr(i).Split("^")(0) = "", 0, strArr(i).Split("^")(0))
                    row("PARTNER_CODE") = IIf(strArr(i).Split("^")(1) = "", 0, strArr(i).Split("^")(1))
                    row("ADDRESS") = IIf(strArr(i).Split("^")(2) = "", 0, strArr(i).Split("^")(2))
                    row("PHONE_NUMBER") = IIf(strArr(i).Split("^")(3) = "", 0, strArr(i).Split("^")(3))
                    row("TAX") = IIf(strArr(i).Split("^")(4) = "", 0, strArr(i).Split("^")(4))
                    row("ACCOUNT_NUMBER") = IIf(strArr(i).Split("^")(5) = "", 0, strArr(i).Split("^")(5))
                    row("BANK_NAME") = IIf(strArr(i).Split("^")(6) = "", 0, strArr(i).Split("^")(6))
                    row("NAME_OF_PC") = IIf(strArr(i).Split("^")(7) = "", 0, strArr(i).Split("^")(7))
                    row("CONTACT_PHONE_NUMBER") = IIf(strArr(i).Split("^")(8) = "", 0, strArr(i).Split("^")(8))
                    row("ID_NUMBER") = IIf(strArr(i).Split("^")(9) = "", 0, strArr(i).Split("^")(9))
                    row("ID_WHERE") = IIf(strArr(i).Split("^")(10) = "", 0, strArr(i).Split("^")(10))
                    row("ID_DATE") = IIf(strArr(i).Split("^")(11) = "", 0, strArr(i).Split("^")(11))
                    row("PO_ID_CONTACT") = IIf(strArr(i).Split("^")(12) = "", 0, strArr(i).Split("^")(12))
                    row("NAME") = IIf(strArr(i).Split("^")(13) = "", 0, strArr(i).Split("^")(13))
                    row("NAME_PARTNER") = IIf(strArr(i).Split("^")(14) = "", 0, strArr(i).Split("^")(14))
                    dataTable.Rows.Add(row)
                    prbDTVC.Value = n
                Catch ex As Exception
                    Console.Write("Bản ghi lỗi: " + i.ToString)
                End Try
            Next
            If MessageBox.Show("Có " + n.ToString + " bản ghi bạn có muốn cập nhật không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                For i As Integer = 3 To dataTable.Rows.Count - 1
                    Try


                        myDoi_Tac_Vc_Chi_Tiet.ID = IIf(dataTable.Rows(i)("ID").ToString() = "", 0, dataTable.Rows(i)("ID").ToString())

                        myDoi_Tac_Vc_Chi_Tiet.PARTNER_CODE = IIf(dataTable.Rows(i)("PARTNER_CODE").ToString() = "", 0, dataTable.Rows(i)("PARTNER_CODE").ToString())
                        myDoi_Tac_Vc_Chi_Tiet.ADDRESS = IIf(dataTable.Rows(i)("ADDRESS").ToString() = "", 0, dataTable.Rows(i)("ADDRESS").ToString())
                        myDoi_Tac_Vc_Chi_Tiet.PHONE_NUMBER = IIf(dataTable.Rows(i)("PHONE_NUMBER").ToString() = "", 0, dataTable.Rows(i)("PHONE_NUMBER").ToString())
                        myDoi_Tac_Vc_Chi_Tiet.TAX = IIf(dataTable.Rows(i)("TAX").ToString() = "", 0, dataTable.Rows(i)("TAX").ToString())
                        myDoi_Tac_Vc_Chi_Tiet.ACCOUNT_NUMBER = IIf(dataTable.Rows(i)("ACCOUNT_NUMBER").ToString() = "", 0, dataTable.Rows(i)("ACCOUNT_NUMBER").ToString())
                        myDoi_Tac_Vc_Chi_Tiet.BANK_NAME = IIf(dataTable.Rows(i)("BANK_NAME").ToString() = "", 0, dataTable.Rows(i)("BANK_NAME").ToString())
                        myDoi_Tac_Vc_Chi_Tiet.NAME_OF_PC = IIf(dataTable.Rows(i)("NAME_OF_PC").ToString() = "", 0, dataTable.Rows(i)("NAME_OF_PC").ToString())
                        myDoi_Tac_Vc_Chi_Tiet.CONTACT_PHONE_NUMBER = IIf(dataTable.Rows(i)("CONTACT_PHONE_NUMBER").ToString() = "", 0, dataTable.Rows(i)("CONTACT_PHONE_NUMBER").ToString())
                        myDoi_Tac_Vc_Chi_Tiet.ID_NUMBER = IIf(dataTable.Rows(i)("ID_NUMBER").ToString() = "", 0, dataTable.Rows(i)("ID_NUMBER").ToString())
                        myDoi_Tac_Vc_Chi_Tiet.ID_WHERE = IIf(dataTable.Rows(i)("ID_WHERE").ToString() = "", 0, dataTable.Rows(i)("ID_WHERE").ToString())
                        myDoi_Tac_Vc_Chi_Tiet.ID_DATE = IIf(dataTable.Rows(i)("ID_DATE").ToString() = "", 0, dataTable.Rows(i)("ID_DATE").ToString())
                        myDoi_Tac_Vc_Chi_Tiet.PO_ID_CONTACT = IIf(dataTable.Rows(i)("PO_ID_CONTACT").ToString() = "", 0, dataTable.Rows(i)("PO_ID_CONTACT").ToString())
                        myDoi_Tac_Vc_Chi_Tiet.NAME = IIf(dataTable.Rows(i)("NAME").ToString() = "", 0, dataTable.Rows(i)("NAME").ToString())
                        myDoi_Tac_Vc_Chi_Tiet.NAME_PARTNER = IIf(dataTable.Rows(i)("NAME_PARTNER").ToString() = "", 0, dataTable.Rows(i)("NAME_PARTNER").ToString())

                        myDoi_Tac_VC.QLTGND_PARTNER_Cap_Nhat_Them(myDoi_Tac_Vc_Chi_Tiet.ID, myDoi_Tac_Vc_Chi_Tiet.PARTNER_CODE, myDoi_Tac_Vc_Chi_Tiet.ADDRESS, myDoi_Tac_Vc_Chi_Tiet.PHONE_NUMBER, myDoi_Tac_Vc_Chi_Tiet.TAX, myDoi_Tac_Vc_Chi_Tiet.ACCOUNT_NUMBER, myDoi_Tac_Vc_Chi_Tiet.BANK_NAME, myDoi_Tac_Vc_Chi_Tiet.NAME_OF_PC, myDoi_Tac_Vc_Chi_Tiet.CONTACT_PHONE_NUMBER, myDoi_Tac_Vc_Chi_Tiet.ID_NUMBER, myDoi_Tac_Vc_Chi_Tiet.ID_WHERE, myDoi_Tac_Vc_Chi_Tiet.ID_DATE, myDoi_Tac_Vc_Chi_Tiet.PO_ID_CONTACT, myDoi_Tac_Vc_Chi_Tiet.NAME, myDoi_Tac_Vc_Chi_Tiet.NAME_PARTNER)

                    Catch ex As Exception
                        Console.Write(ex.ToString)
                    End Try
                Next
                MessageBox.Show("Cập nhật thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dgDoiTacVC.DataSource = dataTable
                dgDoiTacVC.DataBind()

            End If
        Else
            MessageBox.Show(myString.Split("|")(1), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
    Private Sub FrmDuLieu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbMaBcKhaiThac.DataSource = myMa_Bc_Khai_Thac.Danh_Sach
        cbMaBcKhaiThac.DataBind()

        cbMaBcKhaiThac.Value = GBuu_Cuc_Khai_Thac

        
    End Sub
    Private Sub dgChangVC_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgChangVC.AfterCellActivate
        Dim Id_Tuyen As String = dgChangVC.Rows(dgChangVC.ActiveRow.Index).Cells("Id_Tuyen").Text
        dgTuyenVC.DataSource = myTuyen_VC.QLTGND_TUYEN_VC_Danh_Sach_Theo_Id_Tuyen(Id_Tuyen)
        dgTuyenVC.DataBind()
    End Sub

#Region "BCM1500 BO"
    'Private Sub btnPTVCDT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPTVCDT.Click
    '    prbPTVCDT.Minimum = 1
    '    prbPTVCDT.Maximum = 100
    '    prbPTVCDT.Step = 1
    '    prbPTVCDT.Value = 1

    '    Dim myString As String = ""
    '    Dim dataTable As New dataTable("Phuong_Tien_Van_Chuyen_Doi_Tac")
    '    'Tao ra cac cot cua bang nay
    '    Dim colWork As DataColumn = New DataColumn("ID", GetType(Int32))
    '    dataTable.Columns.Add(colWork)
    '    colWork = New DataColumn("PARTNER_ID", GetType(Int32))
    '    dataTable.Columns.Add(colWork)
    '    colWork = New DataColumn("TRANSPORT_TYPE_ID", GetType(Int32))
    '    dataTable.Columns.Add(colWork)
    '    colWork = New DataColumn("MAIL_ROUTER_ID", GetType(Int32))
    '    dataTable.Columns.Add(colWork)

    '    colWork = New DataColumn("START_TIME", GetType(String))
    '    dataTable.Columns.Add(colWork)
    '    colWork = New DataColumn("END_TIME", GetType(String))
    '    dataTable.Columns.Add(colWork)
    '    colWork = New DataColumn("FROM_ADDRESS", GetType(String))
    '    dataTable.Columns.Add(colWork)
    '    colWork = New DataColumn("TO_ADDRESS", GetType(String))

    '    dataTable.Columns.Add(colWork)

    '    prbPTVC.PerformStep()
    '    myString = Liet_Ke_Thong_Tin_Van_Chuyen_Cua_Doi_Tac(Convert.ToString(cbDoi_Tac.Value))
    '    prbPTVCDT.PerformStep()
    '    Dim strArr() As String
    '    Dim n As Integer = 0
    '    strArr = myString.Split("|")
    '    If myString.Split("|")(0) = "00" Then
    '        n = strArr.Length - 3

    '        For i As Integer = 3 To strArr.Length - 1
    '            Try
    '                Dim row As DataRow = dataTable.NewRow()

    '                row("ID") = IIf(strArr(i).Split("^")(0) = "", 0, strArr(i).Split("^")(0))
    '                row("PARTNER_ID") = IIf(strArr(i).Split("^")(1) = "", 0, strArr(i).Split("^")(1))
    '                row("TRANSPORT_TYPE_ID") = IIf(strArr(i).Split("^")(2) = "", 0, strArr(i).Split("^")(2))
    '                row("MAIL_ROUTER_ID") = IIf(strArr(i).Split("^")(3) = "", 0, strArr(i).Split("^")(3))

    '                row("START_TIME") = IIf(strArr(i).Split("^")(4) = "", 0, strArr(i).Split("^")(4))
    '                row("END_TIME") = IIf(strArr(i).Split("^")(5) = "", 0, strArr(i).Split("^")(5))
    '                row("FROM_ADDRESS") = IIf(strArr(i).Split("^")(6) = "", 0, strArr(i).Split("^")(6))
    '                row("TO_ADDRESS") = IIf(strArr(i).Split("^")(7) = "", 0, strArr(i).Split("^")(7))

    '                dataTable.Rows.Add(row)
    '                prbPTVCDT.PerformStep()
    '            Catch ex As Exception
    '                Console.Write(ex.ToString)
    '            End Try
    '        Next
    '        If MessageBox.Show("Có " + n.ToString + " bản ghi bạn có muốn cập nhật không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '            '    myLoai_Phuong_Tien_VC.QLTGND_TRANSPORT_TYPE_Xoa()
    '            For i As Integer = 0 To dataTable.Rows.Count - 1
    '                Try
    '                    If IsNumeric(strArr(i).Split("^")(0)) Then
    '                        myQLTGND_TRANSPORT_INFO_Chi_Tiet.Id = IIf(dataTable.Rows(i)("ID").ToString() = "", 0, dataTable.Rows(i)("ID").ToString())
    '                    Else
    '                        MessageBox.Show("Lỗi không đúng định dạng", "Thông báo", MessageBoxButtons.OKCancel)
    '                        Exit Sub
    '                    End If

    '                    If IsNumeric(strArr(i).Split("^")(1)) Then
    '                        myQLTGND_TRANSPORT_INFO_Chi_Tiet.Partner_Id = IIf(dataTable.Rows(i)("Partner_Id").ToString() = "", 0, dataTable.Rows(i)("Partner_Id").ToString())
    '                    Else
    '                        MessageBox.Show("Lỗi không đúng định dạng", "Thông báo", MessageBoxButtons.OKCancel)
    '                        Exit Sub
    '                    End If

    '                    If IsNumeric(strArr(i).Split("^")(2)) Then
    '                        myQLTGND_TRANSPORT_INFO_Chi_Tiet.Transport_Type_Id = IIf(dataTable.Rows(i)("Transport_Type_Id").ToString() = "", 0, dataTable.Rows(i)("Transport_Type_Id").ToString())
    '                    Else
    '                        MessageBox.Show("Lỗi không đúng định dạng", "Thông báo", MessageBoxButtons.OKCancel)
    '                        Exit Sub
    '                    End If

    '                    If IsNumeric(strArr(i).Split("^")(3)) Then
    '                        myQLTGND_TRANSPORT_INFO_Chi_Tiet.Mail_Router_Id = IIf(dataTable.Rows(i)("Mail_Router_Id").ToString() = "", 0, dataTable.Rows(i)("Mail_Router_Id").ToString())
    '                    Else
    '                        MessageBox.Show("Lỗi không đúng định dạng", "Thông báo", MessageBoxButtons.OKCancel)
    '                        Exit Sub
    '                    End If

    '                    myQLTGND_TRANSPORT_INFO_Chi_Tiet.Start_Time = IIf(dataTable.Rows(i)("PARTNER_CODE").ToString() = "", 0, dataTable.Rows(i)("PARTNER_CODE").ToString())
    '                    myQLTGND_TRANSPORT_INFO_Chi_Tiet.End_Time = IIf(dataTable.Rows(i)("ADDRESS").ToString() = "", 0, dataTable.Rows(i)("ADDRESS").ToString())
    '                    myQLTGND_TRANSPORT_INFO_Chi_Tiet.From_Address = IIf(dataTable.Rows(i)("PHONE_NUMBER").ToString() = "", 0, dataTable.Rows(i)("PHONE_NUMBER").ToString())
    '                    myQLTGND_TRANSPORT_INFO_Chi_Tiet.To_Address = IIf(dataTable.Rows(i)("TAX").ToString() = "", 0, dataTable.Rows(i)("TAX").ToString())
    '                    myQLTGND_TRANSPORT_INFO.QLTGND_TRANSPORT_INFO_Cap_Nhat_Them(myQLTGND_TRANSPORT_INFO_Chi_Tiet.Id, myQLTGND_TRANSPORT_INFO_Chi_Tiet.Partner_Id, myQLTGND_TRANSPORT_INFO_Chi_Tiet.Transport_Type_Id, myQLTGND_TRANSPORT_INFO_Chi_Tiet.Mail_Router_Id, myQLTGND_TRANSPORT_INFO_Chi_Tiet.Start_Time, myQLTGND_TRANSPORT_INFO_Chi_Tiet.End_Time, myQLTGND_TRANSPORT_INFO_Chi_Tiet.From_Address, myQLTGND_TRANSPORT_INFO_Chi_Tiet.To_Address)

    '                    prbPTVCDT.PerformStep()
    '                Catch ex As Exception
    '                    Console.Write(ex.ToString)
    '                End Try
    '            Next
    '            MessageBox.Show("Cập nhật thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            dgPhuongTienVC.DataSource = dataTable
    '            dgPhuongTienVC.DataBind()
    '            prbPTVCDT.PerformStep()
    '            prbPTVCDT.Value = 100
    '        End If

    '    Else
    '        MessageBox.Show(myString.Split("|")(1), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    'End Sub
#End Region

    Private Sub btnDuongThu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDuongThu.Click
        prbDuongThu.Minimum = 1

        prbDuongThu.Step = 1
        prbDuongThu.Value = 1

        Dim myReString As String = ""
        Dim dataTable As New dataTable("Duong_Thu")
        Dim myString As String = ""

        'Tao ra cac cot cua bang nay
        Dim colWork As DataColumn = New DataColumn("AMND_STATE", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("ID", GetType(Int32))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("PO_CODE_1", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("PO_CODE_2", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("NAME_1", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("NAME_2", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("LONGITUDE_EAST", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("LONGITUDE_WEST", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("LATITUDE_NORTH", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("LATITUDE_SOUTH", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("COMMENTS", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("TYPE", GetType(String))
        dataTable.Columns.Add(colWork)

        myString = Liet_Ke_Duong_Thu()

        Dim strArr() As String
        Dim n As Integer = 0
        strArr = myString.Split("|")
        If myString.Split("|")(0) = "00" Then
            n = strArr.Length - 3
            prbDuongThu.Maximum = n
            For i As Integer = 3 To strArr.Length - 1
                Try
                    'Them du lieu vao
                    Dim row As DataRow = dataTable.NewRow()
                    row("AMND_STATE") = IIf(strArr(i).Split("^")(0) = "", 0, strArr(i).Split("^")(0))
                    row("ID") = IIf(strArr(i).Split("^")(1) = "", 0, strArr(i).Split("^")(1))
                    row("PO_CODE_1") = IIf(strArr(i).Split("^")(2) = "", 0, strArr(i).Split("^")(2))
                    row("PO_CODE_2") = IIf(strArr(i).Split("^")(3) = "", 0, strArr(i).Split("^")(3))
                    row("NAME_1") = IIf(strArr(i).Split("^")(4) = "", 0, strArr(i).Split("^")(4))
                    row("NAME_2") = IIf(strArr(i).Split("^")(5) = "", 0, strArr(i).Split("^")(5))
                    row("LONGITUDE_EAST") = IIf(strArr(i).Split("^")(6) = "", 0, strArr(i).Split("^")(6))
                    row("LONGITUDE_WEST") = IIf(strArr(i).Split("^")(7) = "", 0, strArr(i).Split("^")(7))
                    row("LATITUDE_NORTH") = IIf(strArr(i).Split("^")(8) = "", 0, strArr(i).Split("^")(8))
                    row("LATITUDE_SOUTH") = IIf(strArr(i).Split("^")(9) = "", 0, strArr(i).Split("^")(9))
                    row("COMMENTS") = IIf(strArr(i).Split("^")(10) = "", 0, strArr(i).Split("^")(10))
                    row("TYPE") = IIf(strArr(i).Split("^")(11) = "", 0, strArr(i).Split("^")(11))
                    dataTable.Rows.Add(row)
                    prbDuongThu.Value = n
                Catch ex As Exception
                    Console.Write(ex.ToString)
                End Try
            Next
            If MessageBox.Show("Có " + n.ToString + " bản ghi bạn có muốn cập nhật không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                'myLoai_Phuong_Tien_VC.QLTGND_TRANSPORT_TYPE_Xoa()
                For i As Integer = 0 To dataTable.Rows.Count - 1
                    Try
                        myQLTGND_ROAD_MAP_Chi_Tiet.Id = IIf(dataTable.Rows(i)("ID").ToString() = "", 0, dataTable.Rows(i)("ID").ToString())
                        myQLTGND_ROAD_MAP_Chi_Tiet.PO_CODE_1 = IIf(dataTable.Rows(i)("PO_CODE_1").ToString() = "", 0, dataTable.Rows(i)("PO_CODE_1").ToString())
                        myQLTGND_ROAD_MAP_Chi_Tiet.PO_CODE_2 = IIf(dataTable.Rows(i)("PO_CODE_2").ToString() = "", 0, dataTable.Rows(i)("PO_CODE_2").ToString())
                        myQLTGND_ROAD_MAP_Chi_Tiet.NAME_1 = IIf(dataTable.Rows(i)("NAME_1").ToString() = "", 0, dataTable.Rows(i)("NAME_1").ToString())
                        myQLTGND_ROAD_MAP_Chi_Tiet.NAME_2 = IIf(dataTable.Rows(i)("NAME_2").ToString() = "", 0, dataTable.Rows(i)("NAME_2").ToString())

                        myQLTGND_ROAD_MAP_Chi_Tiet.LATITUDE_NORTH = IIf(dataTable.Rows(i)("LATITUDE_NORTH").ToString() = "", 0, dataTable.Rows(i)("LATITUDE_NORTH").ToString())
                        myQLTGND_ROAD_MAP_Chi_Tiet.LATITUDE_SOUTH = IIf(dataTable.Rows(i)("LATITUDE_SOUTH").ToString() = "", 0, dataTable.Rows(i)("LATITUDE_SOUTH").ToString())
                        myQLTGND_ROAD_MAP_Chi_Tiet.LONGITUDE_EAST = IIf(dataTable.Rows(i)("LONGITUDE_EAST").ToString() = "", 0, dataTable.Rows(i)("LONGITUDE_EAST").ToString())
                        myQLTGND_ROAD_MAP_Chi_Tiet.LONGITUDE_WEST = IIf(dataTable.Rows(i)("LONGITUDE_WEST").ToString() = "", 0, dataTable.Rows(i)("LONGITUDE_WEST").ToString())

                        myQLTGND_ROAD_MAP_Chi_Tiet.COMMENTS = IIf(dataTable.Rows(i)("COMMENTS").ToString() = "", 0, dataTable.Rows(i)("COMMENTS").ToString())
                        myQLTGND_ROAD_MAP_Chi_Tiet.TYPE = IIf(dataTable.Rows(i)("TYPE").ToString() = "", 0, dataTable.Rows(i)("TYPE").ToString())
                        
                        myQLTGND_ROAD_MAP.QLTGND_ROAD_MAP_Cap_Nhat_Them(myQLTGND_ROAD_MAP_Chi_Tiet.Id, myQLTGND_ROAD_MAP_Chi_Tiet.PO_CODE_1, myQLTGND_ROAD_MAP_Chi_Tiet.PO_CODE_2, myQLTGND_ROAD_MAP_Chi_Tiet.NAME_1, myQLTGND_ROAD_MAP_Chi_Tiet.NAME_2, myQLTGND_ROAD_MAP_Chi_Tiet.LONGITUDE_EAST, myQLTGND_ROAD_MAP_Chi_Tiet.LONGITUDE_WEST, myQLTGND_ROAD_MAP_Chi_Tiet.LATITUDE_NORTH, myQLTGND_ROAD_MAP_Chi_Tiet.LATITUDE_SOUTH, myQLTGND_ROAD_MAP_Chi_Tiet.COMMENTS, "0", myQLTGND_ROAD_MAP_Chi_Tiet.TYPE)

                        prbDuongThu.PerformStep()
                    Catch ex As Exception
                        Console.Write(ex.ToString)
                    End Try
                Next
                MessageBox.Show("Cập nhật thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dgRoadMap.DataSource = dataTable
                dgRoadMap.DataBind()
            End If
        Else
            MessageBox.Show(myString.Split("|")(1), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub dgTuyenVC_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgTuyenVC.AfterCellActivate

        Dim Id_Tuyen As String = dgTuyenVC.Rows(dgTuyenVC.ActiveRow.Index).Cells("Id_Tuyen").Text
        dgChangVC.DataSource = myChang_VC.QLTGND_CHANG_VC_Danh_Sach_Theo_Tuyen(Id_Tuyen)
        dgChangVC.DataBind()
    End Sub

    Private Sub tabControl_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles TabControl.SelectedTabChanged
        If e.Tab.Key = 0 Then
            dgTuyenVC.DataSource = myTuyen_VC.QLTGND_TUYEN_VC_Danh_Sach()
            dgTuyenVC.DataBind()
            dgChangVC.DataSource = myChang_VC.QLTGND_CHANG_VC_Danh_Sach()
            dgChangVC.DataBind()
        End If
        If e.Tab.Key = 1 Then
            dgRoadMap.DataSource = myQLTGND_ROAD_MAP.QLTGND_ROAD_MAP_Danh_Sach()
            dgRoadMap.DataBind()
        End If
        If e.Tab.Key = 2 Then
            dgPhuongTienVC.DataSource = myLoai_Phuong_Tien_VC.QLTGND_TRANSPORT_TYPE_Danh_Sach()
            dgPhuongTienVC.DataBind()
        End If
        If e.Tab.Key = 3 Then
            dgDoiTacVC.DataSource = myDoi_Tac_VC.QLTGND_PARTNER_Danh_Sach()
            dgDoiTacVC.DataBind()
        End If
    End Sub
    Private Sub cbMaBcKhaiThac_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMaBcKhaiThac.Validated
        If cbMaBcKhaiThac.Text <> "" Then
            dgTuyenVC.DataSource = myTuyen_VC.QLTGND_TUYEN_VC_Danh_Sach
            dgTuyenVC.DataBind()
            dgChangVC.DataSource = myChang_VC.QLTGND_CHANG_VC_Danh_Sach_Theo_Ma_Bc_Dich(cbMaBcKhaiThac.Value)
            dgChangVC.DataSource = myChang_VC.QLTGND_CHANG_VC_Danh_Sach_Theo_Ma_Bc_Goc(cbMaBcKhaiThac.Value)
            dgChangVC.DataBind()
        End If
    End Sub
End Class

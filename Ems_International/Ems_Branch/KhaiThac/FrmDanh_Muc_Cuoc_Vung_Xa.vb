Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Ems_International_Logic.EMS

Public Class FrmDanh_Muc_Cuoc_Vung_Xa
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
    Friend WithEvents dgCuoc_Vung_Xa As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents CbNuoc As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents BtnTim As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Cuoc_Vung_Xa", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vung_Duoi")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vung_Tren")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Cuoc_Vung_Xa")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tu_Ngay")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Den_Ngay")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Nuoc", -1)
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Nuoc")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Khu_Vuc")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.dgCuoc_Vung_Xa = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.CbNuoc = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.BtnTim = New Infragistics.Win.Misc.UltraButton
        CType(Me.dgCuoc_Vung_Xa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbNuoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgCuoc_Vung_Xa
        '
        Me.dgCuoc_Vung_Xa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgCuoc_Vung_Xa.DisplayLayout.AddNewBox.Prompt = " "
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgCuoc_Vung_Xa.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.Caption = "Mã Nước"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.Header.Caption = "Vùng Dưới"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.Header.Caption = "Vùng Trên"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.Header.Caption = "Cước"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7})
        UltraGridBand1.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Both
        UltraGridBand1.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Both
        UltraGridBand1.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand1.UseRowLayout = True
        Me.dgCuoc_Vung_Xa.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.dgCuoc_Vung_Xa.DisplayLayout.InterBandSpacing = 10
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.dgCuoc_Vung_Xa.DisplayLayout.Override.CardAreaAppearance = Appearance2
        Me.dgCuoc_Vung_Xa.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.ForeColor = System.Drawing.Color.Black
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgCuoc_Vung_Xa.DisplayLayout.Override.HeaderAppearance = Appearance3
        Me.dgCuoc_Vung_Xa.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance4.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgCuoc_Vung_Xa.DisplayLayout.Override.RowAppearance = Appearance4
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgCuoc_Vung_Xa.DisplayLayout.Override.RowSelectorAppearance = Appearance5
        Me.dgCuoc_Vung_Xa.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgCuoc_Vung_Xa.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance6.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.dgCuoc_Vung_Xa.DisplayLayout.Override.SelectedRowAppearance = Appearance6
        Me.dgCuoc_Vung_Xa.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgCuoc_Vung_Xa.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgCuoc_Vung_Xa.ExitEditModeOnLeave = False
        Me.dgCuoc_Vung_Xa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgCuoc_Vung_Xa.Location = New System.Drawing.Point(0, 40)
        Me.dgCuoc_Vung_Xa.Name = "dgCuoc_Vung_Xa"
        Me.dgCuoc_Vung_Xa.Size = New System.Drawing.Size(408, 280)
        Me.dgCuoc_Vung_Xa.TabIndex = 66
        Me.dgCuoc_Vung_Xa.Text = "Cước vùng xa"
        '
        'CbNuoc
        '
        Me.CbNuoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn8.Case = Infragistics.Win.UltraWinGrid.Case.Upper
        Appearance7.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn8.CellAppearance = Appearance7
        Appearance8.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn8.Header.Appearance = Appearance8
        UltraGridColumn8.Header.Caption = "Mã nước"
        UltraGridColumn8.Header.VisiblePosition = 0
        UltraGridColumn8.Width = 80
        Appearance9.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn9.Header.Appearance = Appearance9
        UltraGridColumn9.Header.Caption = "Tên nước"
        UltraGridColumn9.Header.VisiblePosition = 1
        UltraGridColumn9.Width = 120
        Appearance10.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn10.Header.Appearance = Appearance10
        UltraGridColumn10.Header.Caption = "Mã khu vực"
        UltraGridColumn10.Header.VisiblePosition = 2
        UltraGridColumn10.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn8, UltraGridColumn9, UltraGridColumn10})
        Me.CbNuoc.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Appearance11.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance11.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance11.ForeColor = System.Drawing.Color.Black
        Appearance11.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance11.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.CbNuoc.DisplayLayout.Override.HeaderAppearance = Appearance11
        Appearance12.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(255, Byte))
        Me.CbNuoc.DisplayLayout.Override.SelectedCellAppearance = Appearance12
        Me.CbNuoc.DisplayMember = ""
        Me.CbNuoc.LimitToList = True
        Me.CbNuoc.Location = New System.Drawing.Point(112, 8)
        Me.CbNuoc.Name = "CbNuoc"
        Me.CbNuoc.Size = New System.Drawing.Size(88, 21)
        Me.CbNuoc.TabIndex = 67
        Me.CbNuoc.Text = "VN"
        Me.CbNuoc.ValueMember = ""
        '
        'BtnTim
        '
        Me.BtnTim.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTim.Location = New System.Drawing.Point(208, 8)
        Me.BtnTim.Name = "BtnTim"
        Me.BtnTim.Size = New System.Drawing.Size(80, 24)
        Me.BtnTim.TabIndex = 68
        Me.BtnTim.Text = "Tìm"
        '
        'FrmDanh_Muc_Cuoc_Vung_Xa
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(408, 318)
        Me.Controls.Add(Me.BtnTim)
        Me.Controls.Add(Me.CbNuoc)
        Me.Controls.Add(Me.dgCuoc_Vung_Xa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmDanh_Muc_Cuoc_Vung_Xa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh mục cước vùng xa"
        CType(Me.dgCuoc_Vung_Xa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbNuoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Khai báo các biến trong form"
    Dim myColumn As Infragistics.Win.UltraWinGrid.UltraGridColumn = Nothing
    Private myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Dim myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Dim myNuoc As New Ma_Nuoc(GConnectionString)
    Dim myCuoc_Vung_Xa As New Cuoc_Vung_Xa(GConnectionString)
#End Region

#Region "Hien thi trong form"
    Private Sub FrmHoadon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub DatagridBinding()
        dgCuoc_Vung_Xa.DataSource = myCuoc_Vung_Xa.Lay_Boi_Ma_Nuoc(CbNuoc.Text).Tables(0)
        dgCuoc_Vung_Xa.DataBind()
    End Sub
#End Region

#Region "Hien_Thi_Ma_Cac_Nuoc"
    Private Sub Hien_Thi_Ma_Cac_Nuoc()
        Try
            CbNuoc.DataSource = myNuoc.Danh_Sach.Tables(0)
            CbNuoc.DataBind()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Danh_Muc_Cuoc_Vung_Xa_Load"
    Private Sub Danh_Muc_Cuoc_Vung_Xa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Hien_Thi_Ma_Cac_Nuoc()
        CbNuoc.Text = "VN"
        DatagridBinding()
    End Sub
#End Region

#Region "BtnTim_Click"
    Private Sub BtnTim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTim.Click
        DatagridBinding()
    End Sub
#End Region

#Region "dgCuoc_Vung_Xa_InitializeLayout"
    Private Sub dgCuoc_Vung_Xa_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgCuoc_Vung_Xa.InitializeLayout

    End Sub
#End Region

End Class

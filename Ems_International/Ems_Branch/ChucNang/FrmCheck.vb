Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Ems_International_Logic.EMS
Public Class FrmCheck
    Inherits System.Windows.Forms.Form
    Dim myChuyenthudi As New Chuyen_Thu_Di(GConnectionString)
    'Dim myIpDuongthu As New Ip_Duong_Thu(GConnectionString)
    Dim myDuongThu As New Duong_Thu_Di(GConnectionString)
    Public myreturn As Boolean = False
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgChuyenthuDiChuaF As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents lbl_CanhBao As Infragistics.Win.Misc.UltraLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Chuyen_Thu_Chua_F", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chuyen_Thu")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dong_F")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.dgChuyenthuDiChuaF = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.lbl_CanhBao = New Infragistics.Win.Misc.UltraLabel
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgChuyenthuDiChuaF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(0, 48)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(640, 200)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgChuyenthuDiChuaF)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(632, 174)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Danh sách chuyến thư đi chưa đóng túi F"
        '
        'dgChuyenthuDiChuaF
        '
        Me.dgChuyenthuDiChuaF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgChuyenthuDiChuaF.DisplayLayout.AddNewBox.Prompt = " "
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgChuyenthuDiChuaF.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance2.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn1.Header.Appearance = Appearance2
        UltraGridColumn1.Header.Caption = "Đường thư"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn2.Header.Appearance = Appearance3
        UltraGridColumn2.Header.Caption = "Số chuyến thư"
        UltraGridColumn2.Header.VisiblePosition = 1
        Appearance4.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn3.Header.Appearance = Appearance4
        UltraGridColumn3.Header.Caption = "Đóng túi F"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        UltraGridBand1.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand1.UseRowLayout = True
        Me.dgChuyenthuDiChuaF.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.dgChuyenthuDiChuaF.DisplayLayout.InterBandSpacing = 10
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Me.dgChuyenthuDiChuaF.DisplayLayout.Override.CardAreaAppearance = Appearance5
        Me.dgChuyenthuDiChuaF.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance6.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance6.ForeColor = System.Drawing.Color.Black
        Appearance6.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgChuyenthuDiChuaF.DisplayLayout.Override.HeaderAppearance = Appearance6
        Me.dgChuyenthuDiChuaF.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance7.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgChuyenthuDiChuaF.DisplayLayout.Override.RowAppearance = Appearance7
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance8.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgChuyenthuDiChuaF.DisplayLayout.Override.RowSelectorAppearance = Appearance8
        Me.dgChuyenthuDiChuaF.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgChuyenthuDiChuaF.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance9.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance9.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance9.ForeColor = System.Drawing.Color.Black
        Me.dgChuyenthuDiChuaF.DisplayLayout.Override.SelectedRowAppearance = Appearance9
        Me.dgChuyenthuDiChuaF.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgChuyenthuDiChuaF.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgChuyenthuDiChuaF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgChuyenthuDiChuaF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgChuyenthuDiChuaF.Location = New System.Drawing.Point(0, 0)
        Me.dgChuyenthuDiChuaF.Name = "dgChuyenthuDiChuaF"
        Me.dgChuyenthuDiChuaF.Size = New System.Drawing.Size(632, 174)
        Me.dgChuyenthuDiChuaF.TabIndex = 6
        Me.dgChuyenthuDiChuaF.Text = "Chuyến thư đi chưa đóng túi F"
        '
        'lbl_CanhBao
        '
        Me.lbl_CanhBao.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CanhBao.Location = New System.Drawing.Point(24, 8)
        Me.lbl_CanhBao.Name = "lbl_CanhBao"
        Me.lbl_CanhBao.Size = New System.Drawing.Size(592, 32)
        Me.lbl_CanhBao.TabIndex = 2
        Me.lbl_CanhBao.Text = "Nếu không Đóng F cho chuyến thư, dữ liệu sẽ không được truyền lên!!!"
        '
        'FrmCheck
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(640, 245)
        Me.Controls.Add(Me.lbl_CanhBao)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FrmCheck"
        Me.Text = "Kiểm tra lỗi"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgChuyenthuDiChuaF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "DataGrid"
    Private Sub DataGrid_ChuyenthuDiChuaF()
        dgChuyenthuDiChuaF.DataSource = myChuyenthudi.Chuyen_Thu_Di_Chua_Dong_F(GId_Ca).Tables(0)
        dgChuyenthuDiChuaF.DataBind()
    End Sub
#End Region
#Region "Form load"
    Private Sub FrmCheck_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGrid_ChuyenthuDiChuaF()
        If dgChuyenthuDiChuaF.Rows.Count = 0 Then
            myreturn = True
            Close()
        End If
    End Sub
#End Region
End Class

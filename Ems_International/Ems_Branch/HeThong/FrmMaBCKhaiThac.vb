Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Ems_International_Logic.EMS
Public Class FrmMaBCKhaiThac
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
    Friend WithEvents dgMabckt As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ddMaBc As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents mnuMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuTimKiem As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Bc_Khai_Thac", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Bc_Khai_Thac", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Dm_Bc", -1)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_BC")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Buu_Cuc")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.dgMabckt = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.ddMaBc = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.mnuMenu = New System.Windows.Forms.ContextMenu
        Me.mnuTimKiem = New System.Windows.Forms.MenuItem
        CType(Me.dgMabckt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddMaBc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgMabckt
        '
        Me.dgMabckt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgMabckt.DisplayLayout.AddNewBox.Prompt = " "
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgMabckt.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.Caption = "Mã BC Khai Thác"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.MaskInput = "999999"
        UltraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(99, 0)
        UltraGridColumn2.Header.Caption = "Tên BC Khai Thác"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(106, 0)
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2})
        UltraGridBand1.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand1.UseRowLayout = True
        Me.dgMabckt.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.dgMabckt.DisplayLayout.InterBandSpacing = 10
        Me.dgMabckt.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.dgMabckt.DisplayLayout.Override.CardAreaAppearance = Appearance2
        Me.dgMabckt.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.ForeColor = System.Drawing.Color.Black
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgMabckt.DisplayLayout.Override.HeaderAppearance = Appearance3
        Me.dgMabckt.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance4.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgMabckt.DisplayLayout.Override.RowAppearance = Appearance4
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgMabckt.DisplayLayout.Override.RowSelectorAppearance = Appearance5
        Me.dgMabckt.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgMabckt.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance6.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.dgMabckt.DisplayLayout.Override.SelectedRowAppearance = Appearance6
        Me.dgMabckt.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgMabckt.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgMabckt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMabckt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMabckt.Location = New System.Drawing.Point(0, 0)
        Me.dgMabckt.Name = "dgMabckt"
        Me.dgMabckt.Size = New System.Drawing.Size(376, 273)
        Me.dgMabckt.TabIndex = 7
        Me.dgMabckt.Text = "Mã bưu cục khai thác"
        '
        'ddMaBc
        '
        Me.ddMaBc.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance7.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddMaBc.DisplayLayout.Appearance = Appearance7
        UltraGridColumn3.Header.Caption = "Mã BC"
        UltraGridColumn3.Header.VisiblePosition = 0
        UltraGridColumn4.Header.Caption = "Tên BC"
        UltraGridColumn4.Header.VisiblePosition = 1
        UltraGridColumn5.Header.Caption = "Mã Tỉnh"
        UltraGridColumn5.Header.VisiblePosition = 2
        UltraGridColumn5.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn3, UltraGridColumn4, UltraGridColumn5})
        Me.ddMaBc.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance8.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance8.ForeColor = System.Drawing.Color.Black
        Appearance8.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddMaBc.DisplayLayout.Override.HeaderAppearance = Appearance8
        Me.ddMaBc.DisplayMember = ""
        Me.ddMaBc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddMaBc.Location = New System.Drawing.Point(104, 96)
        Me.ddMaBc.Name = "ddMaBc"
        Me.ddMaBc.Size = New System.Drawing.Size(200, 128)
        Me.ddMaBc.TabIndex = 41
        Me.ddMaBc.ValueMember = ""
        Me.ddMaBc.Visible = False
        '
        'mnuMenu
        '
        Me.mnuMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuTimKiem})
        '
        'mnuTimKiem
        '
        Me.mnuTimKiem.Index = 0
        Me.mnuTimKiem.Text = "Tìm kiếm"
        '
        'FrmMaBCKhaiThac
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(376, 273)
        Me.Controls.Add(Me.ddMaBc)
        Me.Controls.Add(Me.dgMabckt)
        Me.Name = "FrmMaBCKhaiThac"
        Me.Text = "Mã Bưu Cục Khai Thác"
        CType(Me.dgMabckt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddMaBc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Private myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Dim myDanhMuc As New Danh_Muc_BC(GConnectionString)
    Dim myMabckt As New Ma_Bc_Khai_Thac(GConnectionString)
    Dim myColumn As Infragistics.Win.UltraWinGrid.UltraGridColumn = Nothing
    Private Sub dgMabckt_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgMabckt.InitializeLayout
        dgMabckt.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        dgMabckt.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
        dgMabckt.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
        With dgMabckt.DisplayLayout
            .Bands(0).Columns("Ma_Bc_Khai_Thac").Style = ColumnStyle.DropDownValidate
            .Bands(0).Columns("Ma_Bc_Khai_Thac").ValueList = ddMaBc
        End With
    End Sub
    Private Sub dgMabckt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgMabckt.KeyDown
        If e.KeyValue < Keys.Space And e.KeyValue <> Keys.Enter Then Exit Sub
        myGridKeyDown = sender
        If Not myCell Is Nothing Then
            e.Handled = True
            myGridKeyDown.ActiveCell = myCell
            myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
            myCell = Nothing
        End If
        Select Case e.KeyValue
            Case Keys.Right
                myCell = Nothing
                myGridKeyDown.PerformAction(ExitEditMode, False, False)
                e.Handled = True
                myGridKeyDown.PerformAction(EnterEditModeAndDropdown, False, False)
            Case Keys.Enter
                myGridKeyDown.PerformAction(ExitEditMode, False, False)
                myGridKeyDown.PerformAction(NextCellByTab, False, False)
                e.Handled = True
                myGridKeyDown.PerformAction(EnterEditMode, False, False)
            Case Keys.F8
                e.Handled = True
            Case Keys.F1
        End Select
    End Sub
    Private Sub FrmMaBCKhaiThac_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGrid_Mabckt()
        ddMaBc.DataSource = myDanhMuc.Danh_Sach_Rut_Gon()
        ddMaBc.DataBind()
    End Sub
    Private Sub AddNewRow(ByVal sender As Object)
        myGridKeyDown = sender
        If Not myGridKeyDown.ActiveCell Is Nothing Then
            If myGridKeyDown.ActiveCell.Row.HasNextSibling = False Then
                myGridKeyDown.Rows.Band.AddNew()
            End If
        End If
    End Sub
    Private Sub DataGrid_Mabckt()
        dgMabckt.DataSource = myMabckt.Danh_Sach.Tables(0)
        dgMabckt.DataBind()
        dgMabckt.Rows.Band.AddNew()
    End Sub
    Private Sub dgMabckt_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgMabckt.AfterCellUpdate
        If e.Cell.Row.Cells("Ma_Bc_Khai_Thac").IsActiveCell Then
            AddNewRow(sender)
        End If
    End Sub
    Private Sub dgMabckt_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgMabckt.AfterExitEditMode
        Select Case dgMabckt.ActiveCell.Column.Key
            Case "Ma_Bc_Khai_Thac"
                If dgMabckt.ActiveCell.Text <> "" Then
                    If myMabckt.Chk_Ma_Bc_Khai_Thac(dgMabckt.Rows(dgMabckt.ActiveRow.Index).Cells("Ma_Bc_Khai_Thac").Text) = True And dgMabckt.Rows(dgMabckt.ActiveRow.Index).Cells("Ten_Bc_Khai_Thac").Text = "" Then
                        CMessageBox.Show("Mã BC Khai Thác này đã tồn tại trong bảng.", " Thông báo ")
                        myCell = dgMabckt.ActiveCell
                        Exit Sub
                    End If
                    dgMabckt.Rows(dgMabckt.ActiveRow.Index).Cells("Ten_Bc_Khai_Thac").Value = myDanhMuc.Lay(dgMabckt.Rows(dgMabckt.ActiveRow.Index).Cells("Ma_Bc_Khai_Thac").Text).Ten_Buu_Cuc
                End If
        End Select
    End Sub
    Private Sub dgMabckt_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgMabckt.AfterRowUpdate
        If dgMabckt.Rows(dgMabckt.ActiveRow.Index).Cells("Ma_Bc_Khai_Thac").Text = "" And dgMabckt.Rows(dgMabckt.ActiveRow.Index).Cells("Ten_Bc_Khai_Thac").Text = "" Then
            Exit Sub
        Else
            If dgMabckt.Rows(dgMabckt.ActiveRow.Index).Cells("Ma_Bc_Khai_Thac").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Mã Bưu Cục Khai Thác" & vbNewLine & " Mã Bc Khai Thác không được để trống.", " Thông báo ")
                Exit Sub
            End If

            If dgMabckt.Rows(dgMabckt.ActiveRow.Index).Cells("Ten_Bc_Khai_Thac").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Mã Bưu Cục Khai Thác." & vbNewLine & " Tên Bc Khai Thác không được để trống.", " Thông báo ")
                Exit Sub
            End If
        End If
        If dgMabckt.Rows(dgMabckt.ActiveRow.Index).Cells("Ma_Bc_Khai_Thac").Text <> "" And dgMabckt.Rows(dgMabckt.ActiveRow.Index).Cells("Ten_Bc_Khai_Thac").Text <> "" Then
            myMabckt.Cap_Nhat_Them(Convert.ToInt32(dgMabckt.Rows(dgMabckt.ActiveRow.Index).Cells("Ma_Bc_Khai_Thac").Text), dgMabckt.Rows(dgMabckt.ActiveRow.Index).Cells("Ten_Bc_Khai_Thac").Text, dgMabckt.Rows(dgMabckt.ActiveRow.Index).Cells("OutBout").Value)
        End If
    End Sub
    Private Sub dgMabckt_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgMabckt.MouseDown
        myGridKeyDown = sender
        If e.Button = MouseButtons.Right Then
            Dim oHeaderUI As Infragistics.Win.UltraWinGrid.HeaderUIElement
            Dim oUIElement As Infragistics.Win.UIElement
            Dim point As point = New point(e.X, e.Y)

            oUIElement = Me.myGridKeyDown.DisplayLayout.UIElement.ElementFromPoint(point)
            If oUIElement Is Nothing Then Exit Sub
            oUIElement = oUIElement.GetAncestor(GetType(Infragistics.Win.UltraWinGrid.HeaderUIElement))
            If oUIElement Is Nothing Then
                Return
            End If
            If Not oUIElement.GetType() Is GetType(Infragistics.Win.UltraWinGrid.HeaderUIElement) Then Exit Sub
            oHeaderUI = oUIElement
            Dim oColHeader As Infragistics.Win.UltraWinGrid.ColumnHeader = Nothing
            Me.myColumn = Nothing
            oColHeader = oHeaderUI.SelectableItem
            Me.myColumn = oColHeader.Column
            If Me.myColumn Is Nothing Then Exit Sub

            Me.mnuMenu.Show(Me.myGridKeyDown, point)
        End If
    End Sub
End Class

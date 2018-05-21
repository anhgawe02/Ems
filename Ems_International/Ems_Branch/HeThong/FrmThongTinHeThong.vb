Imports System.Text
Imports System.IO
Imports System.Collections
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Public Class FrmThongTinHeThong
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
    Friend WithEvents txtPass As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dgHeThong As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents txtIp As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Thong_Tin_He_Thong", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("May_In_E2", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("In_E1_Tha_Chu")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("In_E2_Tha_Chu")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("May_In_BC37")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("In_BC37_Tha_Chu")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("In_BC01_Tha_Chu")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.txtIp = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.txtPass = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.dgHeThong = New Infragistics.Win.UltraWinGrid.UltraGrid
        CType(Me.txtPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgHeThong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIp
        '
        Me.txtIp.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtIp.InputMask = "###.###.###.###"
        Me.txtIp.Location = New System.Drawing.Point(77, 166)
        Me.txtIp.Name = "txtIp"
        Me.txtIp.Size = New System.Drawing.Size(120, 22)
        Me.txtIp.TabIndex = 22
        Me.txtIp.Text = "..."
        Me.txtIp.Visible = False
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(259, 145)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(211, 24)
        Me.txtPass.TabIndex = 21
        Me.txtPass.Visible = False
        '
        'dgHeThong
        '
        Me.dgHeThong.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgHeThong.DisplayLayout.AddNewBox.Prompt = " "
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgHeThong.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.Caption = "Máy In E2"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn1.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(98, 0)
        UltraGridColumn1.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn1.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn2.Header.Caption = "In E1 Thả Chữ"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn2.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn2.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn2.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn3.Header.Caption = "In E2 Thả Chữ"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn3.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn3.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn3.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn4.Header.Caption = "Máy In BC37"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn4.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn4.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn4.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn5.Header.Caption = "In BC37 Thả Chữ"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn5.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn5.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn5.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn6.Header.Caption = "In BC01 Thả Chữ"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn6.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn6.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn6.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6})
        UltraGridBand1.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand1.UseRowLayout = True
        Me.dgHeThong.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.dgHeThong.DisplayLayout.InterBandSpacing = 10
        Me.dgHeThong.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.dgHeThong.DisplayLayout.Override.CardAreaAppearance = Appearance2
        Me.dgHeThong.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.ForeColor = System.Drawing.Color.Black
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgHeThong.DisplayLayout.Override.HeaderAppearance = Appearance3
        Me.dgHeThong.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance4.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgHeThong.DisplayLayout.Override.RowAppearance = Appearance4
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgHeThong.DisplayLayout.Override.RowSelectorAppearance = Appearance5
        Me.dgHeThong.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgHeThong.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance6.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.dgHeThong.DisplayLayout.Override.SelectedRowAppearance = Appearance6
        Me.dgHeThong.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgHeThong.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgHeThong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgHeThong.Location = New System.Drawing.Point(10, 9)
        Me.dgHeThong.Name = "dgHeThong"
        Me.dgHeThong.Size = New System.Drawing.Size(710, 296)
        Me.dgHeThong.TabIndex = 5
        Me.dgHeThong.Text = "Thông tin hệ thống"
        '
        'FrmThongTinHeThong
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(728, 313)
        Me.Controls.Add(Me.txtIp)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.dgHeThong)
        Me.MaximizeBox = False
        Me.Name = "FrmThongTinHeThong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thông tin hệ thống"
        CType(Me.txtPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgHeThong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Dim myColumn As Infragistics.Win.UltraWinGrid.UltraGridColumn = Nothing
    Private myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Dim myKeys As New ModifyRegistry
#Region "-----------------------Tao_Bang-----------------------"
    Private Sub Tao_Bang()
        Dim str As String
        Dim dataTable As New dataTable("Thong_Tin_He_Thong")
        'Tao ra cac cot cua bang nay           
        Dim colWork As DataColumn = New DataColumn("May_In_E2", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("In_E2_Tha_Chu", GetType(Boolean))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("In_E1_Tha_Chu", GetType(Boolean))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("May_In_BC37", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("In_BC37_Tha_Chu", GetType(Boolean))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("In_BC01_Tha_Chu", GetType(Boolean))
        dataTable.Columns.Add(colWork)
        'Them du lieu vao
        Dim row As DataRow = dataTable.NewRow()
        Try
            If Not myKeys.Doc("InE1ThaChu") Is Nothing Then
                str = myKeys.Doc("InE1ThaChu")
                row("In_E1_Tha_Chu") = str
                str = myKeys.Doc("MayInE2")
                row("May_In_E2") = str
                str = myKeys.Doc("InE2ThaChu")
                row("In_E2_Tha_Chu") = str
                str = myKeys.Doc("MayInBC37")
                row("May_In_BC37") = str
                str = myKeys.Doc("InBC37ThaChu")
                row("In_BC37_Tha_Chu") = str
                str = myKeys.Doc("InBC01ThaChu")
                row("In_BC01_Tha_Chu") = str
                dataTable.Rows.Add(row)
            Else
                row("In_E2_Tha_Chu") = False
                row("May_In_E2") = ""
                row("In_E1_Tha_Chu") = False
                row("May_In_BC37") = ""
                row("In_BC37_Tha_Chu") = False
                row("In_BC01_Tha_Chu") = False
                

                dataTable.Rows.Add(row)
            End If
            dgHeThong.DataSource = dataTable
            dgHeThong.DataBind()
        Catch ex As Exception
            row("In_E2_Tha_Chu") = False
            row("May_In_E2") = ""
            row("In_E1_Tha_Chu") = False
            row("May_In_BC37") = ""
            row("In_BC37_Tha_Chu") = False
            row("In_BC01_Tha_Chu") = False
            dataTable.Rows.Add(row)
            dgHeThong.DataSource = dataTable
            dgHeThong.DataBind()
        End Try
    End Sub
#End Region
    
    Private Sub FrmThongTinHeThong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tao_Bang()
    End Sub

    Private Sub dgHeThong_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgHeThong.InitializeLayout
        dgHeThong.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgHeThong.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
    End Sub
    Private Sub dgHeThong_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgHeThong.KeyDown
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
    Private Sub dgHeThong_BeforeCellDeactivate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dgHeThong.BeforeCellDeactivate
        myGridKeyDown = sender
        If Not myCell Is Nothing Then
            e.Cancel = True
            myGridKeyDown.ActiveCell = myCell
            myGridKeyDown.PerformAction( _
                Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode _
              , False _
              , False)
            myCell = Nothing
        End If
    End Sub
    Private Sub dgHeThong_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgHeThong.AfterExitEditMode
        Select Case dgHeThong.ActiveCell.Column.Key
            'Case "Ten_Dang_Nhap"
            '    If dgHeThong.ActiveCell.Text.Length = 0 Then
            '        CMessageBox.Show("Tên đăng nhập không được để trống !!!", "Thông báo")
            '        Exit Sub
            '        myCell = dgHeThong.ActiveCell
            '    End If
            'Case "Mat_Khau"
            '    If dgHeThong.ActiveCell.Text.Length = 0 Then
            '        CMessageBox.Show("Mật khẩu không được để trống !!!", "Thông báo")
            '        Exit Sub
            '        myCell = dgHeThong.ActiveCell
            '    End If
            'Case "Ten_Co_So_Du_Lieu"
            '    If dgHeThong.ActiveCell.Text.Length = 0 Then
            '        CMessageBox.Show("Phải điền tên cơ sở dữ liệu vào !!!", "Thông báo")
            '        Exit Sub
            '        myCell = dgHeThong.ActiveCell
            '    End If
        End Select
    End Sub

    Private Sub dgHeThong_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgHeThong.AfterCellUpdate
        myKeys.Ghi("InE1ThaChu", dgHeThong.Rows(0).Cells("In_E1_Tha_Chu").Text)
        GInE1ThaChu = dgHeThong.Rows(0).Cells("In_E1_Tha_Chu").Text

        myKeys.Ghi("MayInE2", dgHeThong.Rows(0).Cells("May_In_E2").Text)
        GMayInE2 = dgHeThong.Rows(0).Cells("May_In_E2").Text

        myKeys.Ghi("InE2ThaChu", dgHeThong.Rows(0).Cells("In_E2_Tha_Chu").Text)
        GInE2ThaChu = dgHeThong.Rows(0).Cells("In_E2_Tha_Chu").Text

        myKeys.Ghi("MayInBC37", dgHeThong.Rows(0).Cells("May_In_BC37").Text)
        GMayInBC37 = dgHeThong.Rows(0).Cells("May_In_BC37").Text

        myKeys.Ghi("InBC37ThaChu", dgHeThong.Rows(0).Cells("In_BC37_Tha_Chu").Text)
        GInBC37ThaChu = dgHeThong.Rows(0).Cells("In_BC37_Tha_Chu").Text

        myKeys.Ghi("InBC01ThaChu", dgHeThong.Rows(0).Cells("In_BC01_Tha_Chu").Text)
        GInBC01ThaChu = dgHeThong.Rows(0).Cells("In_BC01_Tha_Chu").Text

        
    End Sub
End Class

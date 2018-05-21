Imports Ems_International_Logic.EMS
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Public Class FrmThongTinNguoiDung
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
    Friend WithEvents dgNguoiDung As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents txtPass As Infragistics.Win.UltraWinEditors.UltraTextEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Nguoi_Dung", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Nguoi_Dung")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Dang_Nhap")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Mat_khau")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ho_Ten")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chuc_Vu")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dien_Thoai")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Email")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Admin")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.dgNguoiDung = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.txtPass = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        CType(Me.dgNguoiDung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgNguoiDung
        '
        Me.dgNguoiDung.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.dgNguoiDung.DisplayLayout.AddNewBox.Prompt = " "
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgNguoiDung.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.Caption = "Tên đăng nhập"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.EditorControl = Me.txtPass
        UltraGridColumn3.Header.Caption = "Mật khẩu"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.MaskInput = ""
        UltraGridColumn4.Header.Caption = "Họ tên"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.Header.Caption = "Chức vụ"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn6.Header.Caption = "Điện thoại"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8})
        UltraGridBand1.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand1.UseRowLayout = True
        Me.dgNguoiDung.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.dgNguoiDung.DisplayLayout.InterBandSpacing = 10
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.dgNguoiDung.DisplayLayout.Override.CardAreaAppearance = Appearance2
        Me.dgNguoiDung.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.ForeColor = System.Drawing.Color.Black
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgNguoiDung.DisplayLayout.Override.HeaderAppearance = Appearance3
        Me.dgNguoiDung.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance4.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgNguoiDung.DisplayLayout.Override.RowAppearance = Appearance4
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgNguoiDung.DisplayLayout.Override.RowSelectorAppearance = Appearance5
        Me.dgNguoiDung.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgNguoiDung.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance6.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.dgNguoiDung.DisplayLayout.Override.SelectedRowAppearance = Appearance6
        Me.dgNguoiDung.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgNguoiDung.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgNguoiDung.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgNguoiDung.Location = New System.Drawing.Point(8, 8)
        Me.dgNguoiDung.Name = "dgNguoiDung"
        Me.dgNguoiDung.Size = New System.Drawing.Size(600, 144)
        Me.dgNguoiDung.TabIndex = 6
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(220, 68)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(176, 21)
        Me.txtPass.TabIndex = 21
        Me.txtPass.Visible = False
        '
        'FrmThongTinNguoiDung
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(616, 157)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.dgNguoiDung)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmThongTinNguoiDung"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thay đổi thông tin bản thân"
        CType(Me.dgNguoiDung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim myNguoiDung As New Nguoi_Dung(GConnectionString)
    Dim myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Dim myColumn As Infragistics.Win.UltraWinGrid.UltraGridColumn = Nothing
    Private myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Private Sub FrmThongTinNguoiDung_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgNguoiDung.DataSource = myNguoiDung.Lay_Boi_Mot_Nguoi(Gid_Nguoi_Dung).Tables(0)
        dgNguoiDung.DataBind()
    End Sub

    Private Sub dgNguoiDung_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgNguoiDung.InitializeLayout
        dgNguoiDung.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgNguoiDung.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
    End Sub

    Private Sub dgNguoiDung_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgNguoiDung.KeyDown
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

    Private Sub dgNguoiDung_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgNguoiDung.AfterExitEditMode
        Select Case dgNguoiDung.ActiveCell.Column.Key
            Case "Ten_Dang_Nhap"
                If dgNguoiDung.ActiveCell.Text.Length = 0 Then
                    CMessageBox.Show("Tên đăng nhập không được để trống !!!", "Thông báo")
                    Exit Sub
                    myCell = dgNguoiDung.ActiveCell
                End If
            Case "Mat_Khau"
                If dgNguoiDung.ActiveCell.Text.Length = 0 Then
                    CMessageBox.Show("Mật khẩu không được để trống !!!", "Thông báo")
                    Exit Sub
                    myCell = dgNguoiDung.ActiveCell
                End If
            Case "Ho_Ten"
                If dgNguoiDung.ActiveCell.Text.Length = 0 Then
                    CMessageBox.Show("Phải điền họ tên vào !!!", "Thông báo")
                    Exit Sub
                    myCell = dgNguoiDung.ActiveCell
                End If
        End Select
    End Sub

    Private Sub dgNguoiDung_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgNguoiDung.AfterCellUpdate
        If dgNguoiDung.Rows(dgNguoiDung.ActiveRow.Index).Cells("Ten_Dang_Nhap").Text = "" Then
            Exit Sub
        End If
        If dgNguoiDung.Rows(dgNguoiDung.ActiveRow.Index).Cells("Mat_Khau").Text = "" Then
            Exit Sub
        End If
        If dgNguoiDung.Rows(dgNguoiDung.ActiveRow.Index).Cells("Ho_Ten").Text = "" Then
            Exit Sub
        End If
        If dgNguoiDung.Rows(dgNguoiDung.ActiveRow.Index).Cells("Ten_Dang_Nhap").Text <> "" Then
            'Cap nhat, them moi nguoi dung
            myNguoiDung.Cap_Nhat(Convert.ToInt32(IIf(dgNguoiDung.Rows(dgNguoiDung.ActiveRow.Index).Cells("Id_Nguoi_Dung").Text = "", "0", dgNguoiDung.Rows(dgNguoiDung.ActiveRow.Index).Cells("Id_Nguoi_Dung").Text)), dgNguoiDung.Rows(dgNguoiDung.ActiveRow.Index).Cells("Ten_Dang_Nhap").Text, dgNguoiDung.Rows(dgNguoiDung.ActiveRow.Index).Cells("Mat_Khau").Text, dgNguoiDung.Rows(dgNguoiDung.ActiveRow.Index).Cells("Ho_Ten").Text, dgNguoiDung.Rows(dgNguoiDung.ActiveRow.Index).Cells("Chuc_Vu").Text, dgNguoiDung.Rows(dgNguoiDung.ActiveRow.Index).Cells("Dien_Thoai").Text, dgNguoiDung.Rows(dgNguoiDung.ActiveRow.Index).Cells("Email").Text, dgNguoiDung.Rows(dgNguoiDung.ActiveRow.Index).Cells("Admin").Value)
        End If
    End Sub

    Private Sub dgNguoiDung_BeforeCellDeactivate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dgNguoiDung.BeforeCellDeactivate
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
End Class

Imports Ems_International_Logic.EMS
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Public Class FrmQuanLyNguoiDung
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
    Friend WithEvents treeQuyen As Infragistics.Win.UltraWinTree.UltraTree
    Friend WithEvents txtPass As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents chkAll As Infragistics.Win.UltraWinEditors.UltraCheckEditor
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
        Dim Override1 As Infragistics.Win.UltraWinTree.Override = New Infragistics.Win.UltraWinTree.Override
        Me.txtPass = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.dgNguoiDung = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.treeQuyen = New Infragistics.Win.UltraWinTree.UltraTree
        Me.chkAll = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        CType(Me.txtPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgNguoiDung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.treeQuyen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(312, 0)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(176, 21)
        Me.txtPass.TabIndex = 20
        Me.txtPass.Visible = False
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
        UltraGridColumn8.Header.Caption = "Quản trị tuyệt đối"
        UltraGridColumn8.Header.VisiblePosition = 7
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
        Me.dgNguoiDung.Size = New System.Drawing.Size(600, 481)
        Me.dgNguoiDung.TabIndex = 5
        Me.dgNguoiDung.Text = "Danh sách người sử dụng"
        '
        'treeQuyen
        '
        Me.treeQuyen.Location = New System.Drawing.Point(624, 8)
        Me.treeQuyen.Name = "treeQuyen"
        Override1.SelectionType = Infragistics.Win.UltraWinTree.SelectType.Single
        Me.treeQuyen.Override = Override1
        Me.treeQuyen.Size = New System.Drawing.Size(192, 456)
        Me.treeQuyen.TabIndex = 6
        '
        'chkAll
        '
        Me.chkAll.Location = New System.Drawing.Point(624, 472)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.TabIndex = 72
        Me.chkAll.Text = "Chọn tất cả"
        '
        'FrmQuanLyNguoiDung
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(824, 501)
        Me.Controls.Add(Me.chkAll)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.treeQuyen)
        Me.Controls.Add(Me.dgNguoiDung)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmQuanLyNguoiDung"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý người sử dụng"
        CType(Me.txtPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgNguoiDung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.treeQuyen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim myNguoiDung As New Nguoi_Dung(GConnectionString)
    Dim myChucNang As New Chuc_Nang(GConnectionString)
    Dim myPhanQuyen As New Phan_Quyen(GConnectionString)
    Dim myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Dim myColumn As Infragistics.Win.UltraWinGrid.UltraGridColumn = Nothing
    Dim i, j As Integer
    Dim myData As DataTable
    Dim myDataChucNang As DataTable
    Private myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Private Sub DataGridBinding()
        dgNguoiDung.DataSource = myNguoiDung.Danh_Sach.Tables(0)
        dgNguoiDung.DataBind()
        dgNguoiDung.Rows.Band.AddNew()
    End Sub
    Private Sub FrmQuanLyNguoiDung_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Xet_Lai_Quyen_Han_Tat_Ca() 'Xét lại quyền hạn tất cả
        DataGridBinding()
        myData = myChucNang.Danh_Sach.Tables(0)
        'dgNguoiDung.Tag = True
    End Sub

    Private Sub Xet_Lai_Quyen_Han_Tat_Ca()
        Try
            'Duyệt toàn bộ người dùng
            Dim myDataSet As New DataSet
            myDataSet = myNguoiDung.Danh_Sach
            Dim mySoNguoiDung As Integer
            mySoNguoiDung = SetNullValue(myDataSet.Tables(0).Rows.Count, 0)
            If mySoNguoiDung > 0 Then
                Dim i As Integer
                'Xét lại quyền hạn cho người dùng
                For i = 0 To mySoNguoiDung - 1
                    Dim myId_Nguoi_Dung As Integer
                    myId_Nguoi_Dung = CInt(myDataSet.Tables(0).Rows(i).Item("Id_Nguoi_Dung"))
                    myNguoiDung.Xet_Lai_Quyen_Han(myId_Nguoi_Dung)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub DeleteRow()
        If dgNguoiDung.Rows(dgNguoiDung.ActiveRow.Index).Cells("Ten_Dang_Nhap").Text.Length <> 0 Then
            If MessageBox.Show("Bạn có thực sự muốn xóa mã này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                myNguoiDung.Xoa_Boi_Ten_Dang_Nhap(dgNguoiDung.Rows(dgNguoiDung.ActiveRow.Index).Cells("Ten_Dang_Nhap").Text)
                dgNguoiDung.ActiveRow.Delete(False)
                CMessageBox.Show("Đã xóa thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub dgNguoiDung_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgNguoiDung.InitializeLayout
        dgNguoiDung.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgNguoiDung.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
        dgNguoiDung.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
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
                DeleteRow()
                e.Handled = True
            Case Keys.F1
        End Select
    End Sub
    Private Sub AddNewRow(ByVal sender As Object)
        myGridKeyDown = sender
        If myGridKeyDown.Rows.Count > 0 Then
            If myGridKeyDown.Rows(myGridKeyDown.Rows.Count - 1).HasNextSibling = False Then
                myGridKeyDown.Rows.Band.AddNew()
            End If
        End If
        If Not myGridKeyDown.ActiveCell Is Nothing Then
            If myGridKeyDown.ActiveCell.Row.HasNextSibling = False Then
                myGridKeyDown.Rows.Band.AddNew()
            End If
        End If


    End Sub
    Private Sub dgNguoiDung_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgNguoiDung.AfterCellUpdate
        If e.Cell.Row.Cells("Ten_Dang_Nhap").IsActiveCell Then
            AddNewRow(sender)
        End If
    End Sub
    Private Function MatchText(ByVal _myGrid As Infragistics.Win.UltraWinGrid.UltraGrid, ByVal oRow As Infragistics.Win.UltraWinGrid.UltraGridRow, ByVal _myString As String) As Boolean
        If oRow Is Nothing Then
            MatchText = False
            Exit Function
        End If
        Dim oCol As Infragistics.Win.UltraWinGrid.UltraGridColumn
        Dim strCellValue As String = ""
        For Each oCol In _myGrid.DisplayLayout.Bands(0).Columns
            If Not oRow.Cells(oCol.Key).Value Is System.DBNull.Value Then
                If Me.Match(_myString, oRow.Cells(oCol.Key).Value) Then
                    MatchText = True
                    Me.myColumn = oCol
                    Exit Function
                End If
            End If
        Next
    End Function
    Private Function Match(ByVal userString As String, ByVal cellValue As String) As Boolean
        If userString.Length > cellValue.Length Then
            Match = False
            Exit Function
        ElseIf userString.Length = cellValue.Length Then
            If userString.ToLower = cellValue.ToLower Then Match = True Else Match = False
            Exit Function
        Else
            Dim i As Integer
            For i = 0 To (cellValue.Length - userString.Length) - 0
                If userString.ToLower = cellValue.ToLower.Substring(i, userString.Length) Then
                    Match = True
                    Exit Function
                End If
            Next
            Match = False
            Exit Function
        End If
    End Function
    Public Sub Search(ByVal _myGrid As Infragistics.Win.UltraWinGrid.UltraGrid, ByVal _myString As String)
        Dim oRow As Infragistics.Win.UltraWinGrid.UltraGridRow
        oRow = _myGrid.ActiveRow
        If oRow Is Nothing Then oRow = _myGrid.GetRow(Infragistics.Win.UltraWinGrid.ChildRow.First)

        While Not oRow Is Nothing
            oRow = oRow.GetSibling(Infragistics.Win.UltraWinGrid.SiblingRow.Next)
            If Me.MatchText(_myGrid, oRow, _myString) Then
                _myGrid.ActiveRow.Delete(False)
                _myGrid.ActiveRow = oRow
                If Not Me.myColumn Is Nothing Then
                    _myGrid.ActiveCell = oRow.Cells(Me.myColumn.Key)
                    _myGrid.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.ActivateCell, False, False)
                End If
                Exit Sub
            End If
        End While
        oRow = _myGrid.GetRow(Infragistics.Win.UltraWinGrid.ChildRow.First)
        While Not oRow Is Nothing
            If Me.MatchText(_myGrid, oRow, _myString) Then
                _myGrid.ActiveRow.Delete(False)
                _myGrid.ActiveRow = oRow
                If Not Me.myColumn Is Nothing Then
                    _myGrid.ActiveCell = oRow.Cells(Me.myColumn.Key)
                    _myGrid.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.ActivateCell, False, False)
                End If
                Exit Sub
            End If
            oRow = oRow.GetSibling(Infragistics.Win.UltraWinGrid.SiblingRow.Next)
        End While

    End Sub
    Private Sub dgNguoiDung_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgNguoiDung.AfterExitEditMode
        Try
            Select Case dgNguoiDung.ActiveCell.Column.Key
                Case "Ten_Dang_Nhap"
                    If dgNguoiDung.ActiveCell.Text = "" Then
                        MessageBox.Show("Tên đăng nhập không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        myCell = dgNguoiDung.ActiveCell
                        Exit Sub
                    End If
                Case "Mat_khau"
                    If dgNguoiDung.ActiveCell.Text = "" Then
                        MessageBox.Show("Mật khẩu đăng nhập không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        myCell = dgNguoiDung.ActiveCell
                        Exit Sub
                    End If
                Case "Ho_Ten"
                    If dgNguoiDung.ActiveCell.Text = "" Then
                        MessageBox.Show("Họ tên người dùng sẽ in trên các báo cáo, vì vậy không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        myCell = dgNguoiDung.ActiveCell
                        Exit Sub
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub dgNguoiDung_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgNguoiDung.AfterRowUpdate
        If dgNguoiDung.ActiveRow.Cells("Ten_Dang_Nhap").Text = "" Then
            Exit Sub
        End If
        If dgNguoiDung.ActiveRow.Cells("Mat_Khau").Text = "" Then
            Exit Sub
        End If
        If dgNguoiDung.ActiveRow.Cells("Ho_Ten").Text = "" Then
            Exit Sub
        End If
        'Cap nhat, them moi nguoi dung
        myNguoiDung.Cap_Nhat_Them(Convert.ToInt32(IIf(dgNguoiDung.Rows(dgNguoiDung.ActiveRow.Index).Cells("Id_Nguoi_Dung").Text = "", "0", dgNguoiDung.Rows(dgNguoiDung.ActiveRow.Index).Cells("Id_Nguoi_Dung").Text)), dgNguoiDung.Rows(dgNguoiDung.ActiveRow.Index).Cells("Ten_Dang_Nhap").Text, dgNguoiDung.Rows(dgNguoiDung.ActiveRow.Index).Cells("Mat_Khau").Text, dgNguoiDung.Rows(dgNguoiDung.ActiveRow.Index).Cells("Ho_Ten").Text, dgNguoiDung.Rows(dgNguoiDung.ActiveRow.Index).Cells("Chuc_Vu").Text, dgNguoiDung.Rows(dgNguoiDung.ActiveRow.Index).Cells("Dien_Thoai").Text, dgNguoiDung.Rows(dgNguoiDung.ActiveRow.Index).Cells("Email").Text, dgNguoiDung.Rows(dgNguoiDung.ActiveRow.Index).Cells("Admin").Value)
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
    Private Sub Build_Tree(ByVal Ten_Dang_Nhap As String)
        Dim myNode As Infragistics.Win.UltraWinTree.UltraTreeNode
        Dim myChild As Infragistics.Win.UltraWinTree.UltraTreeNode
        myNode = treeQuyen.Nodes.Add("HT", "Hệ thống")
        myDataChucNang = myNguoiDung.Danh_Sach_Chuc_Nang(Ten_Dang_Nhap, "Hệ thống").Tables(0)
        For i = 0 To myDataChucNang.Rows.Count - 1
            myChild = myNode.Nodes.Add(myDataChucNang.Rows(i).Item("Id_Chuc_Nang"), myDataChucNang.Rows(i).Item("Ten_Chuc_Nang"))
            myChild.Override.NodeStyle = Infragistics.Win.UltraWinTree.NodeStyle.CheckBox
            If Convert.ToBoolean(myDataChucNang.Rows(i).Item("Su_Dung")) Then
                myChild.CheckedState = CheckState.Checked
            Else
                myChild.CheckedState = CheckState.Unchecked
            End If

        Next
        myNode = treeQuyen.Nodes.Add("KT", "Quốc Tế Đến")
        myDataChucNang = myNguoiDung.Danh_Sach_Chuc_Nang(Ten_Dang_Nhap, "Quốc Tế Đến").Tables(0)
        For i = 0 To myDataChucNang.Rows.Count - 1
            myChild = myNode.Nodes.Add(myDataChucNang.Rows(i).Item("Id_Chuc_Nang"), myDataChucNang.Rows(i).Item("Ten_Chuc_Nang"))
            myChild.Override.NodeStyle = Infragistics.Win.UltraWinTree.NodeStyle.CheckBox
            If Convert.ToBoolean(myDataChucNang.Rows(i).Item("Su_Dung")) Then
                myChild.CheckedState = CheckState.Checked
            Else
                myChild.CheckedState = CheckState.Unchecked
            End If
        Next
        myNode = treeQuyen.Nodes.Add("QT_DI", "Quốc Tế Đi")
        myDataChucNang = myNguoiDung.Danh_Sach_Chuc_Nang(Ten_Dang_Nhap, "Quốc Tế Đi").Tables(0)
        For i = 0 To myDataChucNang.Rows.Count - 1
            myChild = myNode.Nodes.Add(myDataChucNang.Rows(i).Item("Id_Chuc_Nang"), myDataChucNang.Rows(i).Item("Ten_Chuc_Nang"))
            myChild.Override.NodeStyle = Infragistics.Win.UltraWinTree.NodeStyle.CheckBox
            If Convert.ToBoolean(myDataChucNang.Rows(i).Item("Su_Dung")) Then
                myChild.CheckedState = CheckState.Checked
            Else
                myChild.CheckedState = CheckState.Unchecked
            End If
        Next
        myNode = treeQuyen.Nodes.Add("CN", "Chức năng")
        myDataChucNang = myNguoiDung.Danh_Sach_Chuc_Nang(Ten_Dang_Nhap, "Chức năng").Tables(0)
        For i = 0 To myDataChucNang.Rows.Count - 1
            myChild = myNode.Nodes.Add(myDataChucNang.Rows(i).Item("Id_Chuc_Nang"), myDataChucNang.Rows(i).Item("Ten_Chuc_Nang"))
            myChild.Override.NodeStyle = Infragistics.Win.UltraWinTree.NodeStyle.CheckBox
            If Convert.ToBoolean(myDataChucNang.Rows(i).Item("Su_Dung")) Then
                myChild.CheckedState = CheckState.Checked
            Else
                myChild.CheckedState = CheckState.Unchecked
            End If
        Next
        myNode = treeQuyen.Nodes.Add("BP", "Báo phát")
        myDataChucNang = myNguoiDung.Danh_Sach_Chuc_Nang(Ten_Dang_Nhap, "Báo phát").Tables(0)
        For i = 0 To myDataChucNang.Rows.Count - 1
            myChild = myNode.Nodes.Add(myDataChucNang.Rows(i).Item("Id_Chuc_Nang"), myDataChucNang.Rows(i).Item("Ten_Chuc_Nang"))
            myChild.Override.NodeStyle = Infragistics.Win.UltraWinTree.NodeStyle.CheckBox
            If Convert.ToBoolean(myDataChucNang.Rows(i).Item("Su_Dung")) Then
                myChild.CheckedState = CheckState.Checked
            Else
                myChild.CheckedState = CheckState.Unchecked
            End If
        Next
        myNode = treeQuyen.Nodes.Add("BC", "Thống kê - Báo cáo")
        myDataChucNang = myNguoiDung.Danh_Sach_Chuc_Nang(Ten_Dang_Nhap, "Thống kê - Báo cáo").Tables(0)
        For i = 0 To myDataChucNang.Rows.Count - 1
            myChild = myNode.Nodes.Add(myDataChucNang.Rows(i).Item("Id_Chuc_Nang"), myDataChucNang.Rows(i).Item("Ten_Chuc_Nang"))
            myChild.Override.NodeStyle = Infragistics.Win.UltraWinTree.NodeStyle.CheckBox
            If Convert.ToBoolean(myDataChucNang.Rows(i).Item("Su_Dung")) Then
                myChild.CheckedState = CheckState.Checked
            Else
                myChild.CheckedState = CheckState.Unchecked
            End If
        Next
        myNode = treeQuyen.Nodes.Add("TK", "Tìm kiếm")
        myDataChucNang = myNguoiDung.Danh_Sach_Chuc_Nang(Ten_Dang_Nhap, "Tìm kiếm").Tables(0)
        For i = 0 To myDataChucNang.Rows.Count - 1
            myChild = myNode.Nodes.Add(myDataChucNang.Rows(i).Item("Id_Chuc_Nang"), myDataChucNang.Rows(i).Item("Ten_Chuc_Nang"))
            myChild.Override.NodeStyle = Infragistics.Win.UltraWinTree.NodeStyle.CheckBox
            If Convert.ToBoolean(myDataChucNang.Rows(i).Item("Su_Dung")) Then
                myChild.CheckedState = CheckState.Checked
            Else
                myChild.CheckedState = CheckState.Unchecked
            End If
        Next
        myNode = treeQuyen.Nodes.Add("TG", "Trợ giúp")
        myDataChucNang = myNguoiDung.Danh_Sach_Chuc_Nang(Ten_Dang_Nhap, "Trợ giúp").Tables(0)
        For i = 0 To myDataChucNang.Rows.Count - 1
            myChild = myNode.Nodes.Add(myDataChucNang.Rows(i).Item("Id_Chuc_Nang"), myDataChucNang.Rows(i).Item("Ten_Chuc_Nang"))
            myChild.Override.NodeStyle = Infragistics.Win.UltraWinTree.NodeStyle.CheckBox
            If Convert.ToBoolean(myDataChucNang.Rows(i).Item("Su_Dung")) Then
                myChild.CheckedState = CheckState.Checked
            Else
                myChild.CheckedState = CheckState.Unchecked
            End If
        Next
        myNode = treeQuyen.Nodes.Add("HQ", "Quản lý thu nợ Hải quan")
        myDataChucNang = myNguoiDung.Danh_Sach_Chuc_Nang(Ten_Dang_Nhap, "Quản lý thu nợ Hải quan").Tables(0)
        For i = 0 To myDataChucNang.Rows.Count - 1
            myChild = myNode.Nodes.Add(myDataChucNang.Rows(i).Item("Id_Chuc_Nang"), myDataChucNang.Rows(i).Item("Ten_Chuc_Nang"))
            myChild.Override.NodeStyle = Infragistics.Win.UltraWinTree.NodeStyle.CheckBox
            If Convert.ToBoolean(myDataChucNang.Rows(i).Item("Su_Dung")) Then
                myChild.CheckedState = CheckState.Checked
            Else
                myChild.CheckedState = CheckState.Unchecked
            End If
        Next
        myNode = treeQuyen.Nodes.Add("DSQT", "Đối Soát Quốc Tế")
        myDataChucNang = myNguoiDung.Danh_Sach_Chuc_Nang(Ten_Dang_Nhap, "Đối Soát").Tables(0)
        For i = 0 To myDataChucNang.Rows.Count - 1
            myChild = myNode.Nodes.Add(myDataChucNang.Rows(i).Item("Id_Chuc_Nang"), myDataChucNang.Rows(i).Item("Ten_Chuc_Nang"))
            myChild.Override.NodeStyle = Infragistics.Win.UltraWinTree.NodeStyle.CheckBox
            If Convert.ToBoolean(myDataChucNang.Rows(i).Item("Su_Dung")) Then
                myChild.CheckedState = CheckState.Checked
            Else
                myChild.CheckedState = CheckState.Unchecked
            End If
        Next
        myNode = treeQuyen.Nodes.Add("KH", "Kiểm hóa Hàng xuất khẩu")
        myDataChucNang = myNguoiDung.Danh_Sach_Chuc_Nang(Ten_Dang_Nhap, "Kiểm hóa Xuất khẩu").Tables(0)
        For i = 0 To myDataChucNang.Rows.Count - 1
            myChild = myNode.Nodes.Add(myDataChucNang.Rows(i).Item("Id_Chuc_Nang"), myDataChucNang.Rows(i).Item("Ten_Chuc_Nang"))
            myChild.Override.NodeStyle = Infragistics.Win.UltraWinTree.NodeStyle.CheckBox
            If Convert.ToBoolean(myDataChucNang.Rows(i).Item("Su_Dung")) Then
                myChild.CheckedState = CheckState.Checked
            Else
                myChild.CheckedState = CheckState.Unchecked
            End If
        Next
        myNode = treeQuyen.Nodes.Add("QLTG", "Quản lý túi gói nội địa")
        myDataChucNang = myNguoiDung.Danh_Sach_Chuc_Nang(Ten_Dang_Nhap, "Quản lý túi gói").Tables(0)
        For i = 0 To myDataChucNang.Rows.Count - 1
            myChild = myNode.Nodes.Add(myDataChucNang.Rows(i).Item("Id_Chuc_Nang"), myDataChucNang.Rows(i).Item("Ten_Chuc_Nang"))
            myChild.Override.NodeStyle = Infragistics.Win.UltraWinTree.NodeStyle.CheckBox
            If Convert.ToBoolean(myDataChucNang.Rows(i).Item("Su_Dung")) Then
                myChild.CheckedState = CheckState.Checked
            Else
                myChild.CheckedState = CheckState.Unchecked
            End If
        Next
    End Sub

    Private Sub dgNguoiDung_BeforeRowActivate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgNguoiDung.BeforeRowActivate
        'If treeQuyen.Nodes.Count > 0 Then
        '    For i = 0 To treeQuyen.Nodes.Count - 1
        '        For j = 0 To treeQuyen.Nodes(i).Nodes.Count - 1
        '            If Not dgNguoiDung.ActiveRow Is Nothing Then
        '                myPhanQuyen.Cap_Nhat_Boi_Nguoi_Dung_Va_Chuc_Nang(Convert.ToInt32(dgNguoiDung.Rows(dgNguoiDung.ActiveRow.Index).Cells("Id_Nguoi_Dung").Text), treeQuyen.Nodes(i).Nodes(j).Key, treeQuyen.Nodes(i).Nodes(j).CheckedState)
        '            End If
        '        Next
        '    Next
        'End If
    End Sub


    Private Sub dgNguoiDung_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgNguoiDung.AfterRowActivate

        treeQuyen.Nodes.Clear()
        If dgNguoiDung.ActiveRow Is Nothing Then
            Exit Sub
        End If
        Build_Tree(dgNguoiDung.Rows(dgNguoiDung.ActiveRow.Index).Cells("Ten_Dang_Nhap").Text)
    End Sub

    Private Sub treeQuyen_AfterSelect(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTree.SelectEventArgs) Handles treeQuyen.AfterSelect

    End Sub

    Private Sub treeQuyen_AfterCheck(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinTree.NodeEventArgs) Handles treeQuyen.AfterCheck
        myPhanQuyen.Cap_Nhat_Boi_Nguoi_Dung_Va_Chuc_Nang(dgNguoiDung.Rows(dgNguoiDung.ActiveRow.Index).Cells("Ten_Dang_Nhap").Text, e.TreeNode.Key, e.TreeNode.CheckedState)
    End Sub

    Private Sub txtPass_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPass.ValueChanged

    End Sub

    Private Sub txtPass_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPass.Validated

    End Sub

    Private Sub chkAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAll.CheckedChanged
        Try
            If dgNguoiDung.ActiveRow.Cells("Ten_Dang_Nhap").Text = "" Or dgNguoiDung.ActiveRow.Cells("Ten_Dang_Nhap").Value Is DBNull.Value Then
                MessageBox.Show("Bạn chưa chọn người dùng nào để phân quyền." & vbNewLine & "Mời bạn chọn người dùng trong danh sách rồi mới tiến hành phân quyền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Dim mId_Nguoi_Dung As Integer
            'Lay Id_Nguoi_Dung voi mat khau da ma hoa
            mId_Nguoi_Dung = myNguoiDung.Lay_Boi_Ten_Dang_Nhap(dgNguoiDung.Rows(dgNguoiDung.ActiveRow.Index).Cells("Ten_Dang_Nhap").Text, Encrypt(dgNguoiDung.Rows(dgNguoiDung.ActiveRow.Index).Cells("Mat_Khau").Text, "cpcpnems")).Id_Nguoi_Dung
            'Neu khong tim thay thi lay theo mat khau khong ma hoa
            If mId_Nguoi_Dung = 0 Then
                mId_Nguoi_Dung = myNguoiDung.Lay_Boi_Ten_Dang_Nhap(dgNguoiDung.Rows(dgNguoiDung.ActiveRow.Index).Cells("Ten_Dang_Nhap").Text, dgNguoiDung.Rows(dgNguoiDung.ActiveRow.Index).Cells("Mat_Khau").Text).Id_Nguoi_Dung
            End If
            'Cap nhat quyen theo check
            myPhanQuyen.Cap_Nhat_Tat_Ca(mId_Nguoi_Dung, chkAll.Checked)
            'Buil lai tree view
            treeQuyen.Nodes.Clear()
            Build_Tree(dgNguoiDung.Rows(dgNguoiDung.ActiveRow.Index).Cells("Ten_Dang_Nhap").Text)
            treeQuyen.ExpandAll(Infragistics.Win.UltraWinTree.ExpandAllType.OnlyNodesWithChildren)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region "--------------------dgNguoiDung_BeforeCellUpdate-------------------"
    Private Sub dgNguoiDung_BeforeCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles dgNguoiDung.BeforeCellUpdate
        myGridKeyDown = sender
        '        dgNguoiDung.Tag = True
        'Neu la tao moi thi thoat
        If myGridKeyDown.ActiveRow.Cells("Id_Nguoi_Dung").Value Is DBNull.Value Then
            Exit Sub
        End If
        'Chi xu ly voi column Ten_Dang_Nhap va Mat_Khau
        If myGridKeyDown.ActiveCell.Column.Key.ToUpper <> "TEN_DANG_NHAP" And myGridKeyDown.ActiveCell.Column.Key.ToUpper <> "MAT_KHAU" Then
            Exit Sub
        End If
        'Neu khong thay doi thi thoat
        If (myGridKeyDown.ActiveRow.Cells("Ten_Dang_Nhap").Text = myGridKeyDown.ActiveRow.Cells("Ten_Dang_Nhap").Value) And (myGridKeyDown.ActiveRow.Cells("Mat_Khau").Text = myGridKeyDown.ActiveRow.Cells("Mat_Khau").Value) Then
            Exit Sub
        End If
        'Chi xu ly doi voi nguoi dung da ton tai
        If myNguoiDung.Lay(myGridKeyDown.ActiveRow.Cells("Id_Nguoi_Dung").Value).Ten_Dang_Nhap <> "" Then
            MessageBox.Show("Người dùng này đã tồn tại, bạn không được phép sửa thông tin tên đăng nhập và mật khẩu." & vbNewLine & "Nếu muốn sửa thông tin bạn phải vào chức năng thông tin người dùng để sửa.", "Thông báo", MessageBoxButtons.OK)
            'Gan bien = False de khong cho Next Cell
            '           dgNguoiDung.Tag = False
            e.Cancel = True
            Exit Sub
        End If
    End Sub
#End Region

End Class

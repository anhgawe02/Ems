Public Class FrmTinh_Hang_Nhe
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
    Friend WithEvents txtDai As System.Windows.Forms.TextBox
    Friend WithEvents txtRong As System.Windows.Forms.TextBox
    Friend WithEvents txtCao As System.Windows.Forms.TextBox
    Friend WithEvents txtKet_Qua As System.Windows.Forms.TextBox
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents BtnKet_Qua As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.txtDai = New System.Windows.Forms.TextBox
        Me.txtRong = New System.Windows.Forms.TextBox
        Me.txtCao = New System.Windows.Forms.TextBox
        Me.txtKet_Qua = New System.Windows.Forms.TextBox
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.BtnKet_Qua = New Infragistics.Win.Misc.UltraButton
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        Me.SuspendLayout()
        '
        'txtDai
        '
        Me.txtDai.Location = New System.Drawing.Point(16, 56)
        Me.txtDai.Name = "txtDai"
        Me.txtDai.Size = New System.Drawing.Size(80, 20)
        Me.txtDai.TabIndex = 0
        Me.txtDai.Text = ""
        '
        'txtRong
        '
        Me.txtRong.Location = New System.Drawing.Point(128, 56)
        Me.txtRong.Name = "txtRong"
        Me.txtRong.Size = New System.Drawing.Size(96, 20)
        Me.txtRong.TabIndex = 1
        Me.txtRong.Text = ""
        '
        'txtCao
        '
        Me.txtCao.Location = New System.Drawing.Point(256, 56)
        Me.txtCao.Name = "txtCao"
        Me.txtCao.Size = New System.Drawing.Size(80, 20)
        Me.txtCao.TabIndex = 2
        Me.txtCao.Text = ""
        '
        'txtKet_Qua
        '
        Me.txtKet_Qua.Location = New System.Drawing.Point(112, 136)
        Me.txtKet_Qua.Name = "txtKet_Qua"
        Me.txtKet_Qua.Size = New System.Drawing.Size(128, 20)
        Me.txtKet_Qua.TabIndex = 4
        Me.txtKet_Qua.Text = ""
        '
        'UltraLabel1
        '
        Appearance1.FontData.BoldAsString = "True"
        Appearance1.TextHAlign = Infragistics.Win.HAlign.Center
        Me.UltraLabel1.Appearance = Appearance1
        Me.UltraLabel1.Location = New System.Drawing.Point(8, 8)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(336, 24)
        Me.UltraLabel1.TabIndex = 8
        Me.UltraLabel1.Text = "Công thức tính hàng nhẹ"
        '
        'BtnKet_Qua
        '
        Me.BtnKet_Qua.Location = New System.Drawing.Point(112, 96)
        Me.BtnKet_Qua.Name = "BtnKet_Qua"
        Me.BtnKet_Qua.Size = New System.Drawing.Size(128, 24)
        Me.BtnKet_Qua.TabIndex = 3
        Me.BtnKet_Qua.Text = "Kết quả"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Location = New System.Drawing.Point(256, 40)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(80, 16)
        Me.UltraLabel2.TabIndex = 7
        Me.UltraLabel2.Text = "chiều cao"
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Location = New System.Drawing.Point(136, 40)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(80, 16)
        Me.UltraLabel3.TabIndex = 6
        Me.UltraLabel3.Text = "chiều rộng"
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Location = New System.Drawing.Point(16, 40)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(80, 16)
        Me.UltraLabel4.TabIndex = 5
        Me.UltraLabel4.Text = "chiều dài"
        '
        'UltraLabel5
        '
        Appearance2.FontData.BoldAsString = "True"
        Me.UltraLabel5.Appearance = Appearance2
        Me.UltraLabel5.Location = New System.Drawing.Point(248, 136)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(56, 16)
        Me.UltraLabel5.TabIndex = 9
        Me.UltraLabel5.Text = "Gram"
        '
        'UltraLabel6
        '
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Right
        Me.UltraLabel6.HotTrackAppearance = Appearance3
        Me.UltraLabel6.Location = New System.Drawing.Point(16, 136)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(88, 16)
        Me.UltraLabel6.TabIndex = 10
        Me.UltraLabel6.Text = "Khối lượng QĐ="
        '
        'FrmTinh_Hang_Nhe
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(352, 164)
        Me.Controls.Add(Me.UltraLabel6)
        Me.Controls.Add(Me.UltraLabel5)
        Me.Controls.Add(Me.UltraLabel4)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.BtnKet_Qua)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.txtKet_Qua)
        Me.Controls.Add(Me.txtCao)
        Me.Controls.Add(Me.txtRong)
        Me.Controls.Add(Me.txtDai)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTinh_Hang_Nhe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tính hàng nhẹ"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmTinh_Hang_Nhe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDai.Text = 0
        txtRong.Text = 0
        txtCao.Text = 0
        txtKet_Qua.Text = 0
    End Sub

    Private Sub btnKet_Qua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKet_Qua.Click
        txtKet_Qua.Text = (txtDai.Text * txtRong.Text * txtCao.Text / 6000) * 1000
    End Sub

    Private Sub txtDai_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDai.Validated
        If IsNumeric(txtDai.Text) = False Then
            MessageBox.Show("Chỉ được phép nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDai.Select()
            Exit Sub
        End If
    End Sub

    Private Sub txtRong_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRong.Validated
        If IsNumeric(txtRong.Text) = False Then
            MessageBox.Show("Chỉ được phép nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRong.Select()
            Exit Sub
        End If
    End Sub

    Private Sub txtCao_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCao.Validated
        If IsNumeric(txtCao.Text) = False Then
            MessageBox.Show("Chỉ được phép nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCao.Select()
            Exit Sub
        End If
    End Sub

    Private Sub FrmTinh_Hang_Nhe_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class

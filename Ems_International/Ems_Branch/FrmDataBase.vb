Imports System.Text
Imports System.IO
'Imports System.Management
Imports System.Collections
Public Class FrmDataBase
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
    Friend WithEvents btnThoat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDongY As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtData As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtPass As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtUser As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtServer As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmDataBase))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.btnThoat = New Infragistics.Win.Misc.UltraButton
        Me.btnDongY = New Infragistics.Win.Misc.UltraButton
        Me.txtData = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtPass = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtUser = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtServer = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.txtData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtServer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnThoat
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.btnThoat.Appearance = Appearance1
        Me.btnThoat.Location = New System.Drawing.Point(188, 138)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(106, 37)
        Me.btnThoat.TabIndex = 25
        Me.btnThoat.Text = "Thoát"
        '
        'btnDongY
        '
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.btnDongY.Appearance = Appearance2
        Me.btnDongY.Location = New System.Drawing.Point(73, 138)
        Me.btnDongY.Name = "btnDongY"
        Me.btnDongY.Size = New System.Drawing.Size(106, 37)
        Me.btnDongY.TabIndex = 24
        Me.btnDongY.Text = "Đồng ý"
        '
        'txtData
        '
        Me.txtData.Location = New System.Drawing.Point(137, 91)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(211, 24)
        Me.txtData.TabIndex = 21
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(137, 63)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(211, 24)
        Me.txtPass.TabIndex = 19
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(137, 36)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(211, 24)
        Me.txtUser.TabIndex = 17
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(137, 8)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(211, 24)
        Me.txtServer.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 27)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Tên cơ sở dữ liệu"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(12, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 26)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Mật khẩu"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 27)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Tên đăng nhập"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 27)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Địa chỉ máy chủ"
        '
        'FrmDataBase
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(360, 182)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnDongY)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtServer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDataBase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cấu hình cơ sở dữ liệu"
        CType(Me.txtData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtServer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmDataBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim str As String
        Dim objFileStream As StreamReader
        'Dim file As FileInfo
        If File.Exists("config.ini") Then
            objFileStream = File.OpenText("config.ini")
            str = Decrypt(objFileStream.ReadLine, "cpcpnems")
            txtServer.Text = str

            str = Decrypt(objFileStream.ReadLine, "cpcpnems")
            txtUser.Text = str

            str = Decrypt(objFileStream.ReadLine, "cpcpnems")
            txtPass.Text = str

            str = Decrypt(objFileStream.ReadLine, "cpcpnems")
            txtData.Text = str


            objFileStream.Close()
        End If
        'txtMaMay.Text = GetHDDSerial(0)
        txtServer.Focus()
    End Sub

    Private Sub btnDongY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDongY.Click
        'Dim objStreamW As StreamWriter
        'objStreamW = File.CreateText("config.ini")
        'objStreamW.WriteLine(Encrypt(txtServer.Text, "cpcpnems"))
        'objStreamW.WriteLine(Encrypt(txtUser.Text, "cpcpnems"))
        'objStreamW.WriteLine(Encrypt(txtPass.Text, "cpcpnems"))
        'objStreamW.WriteLine(Encrypt(txtData.Text, "cpcpnems"))
        ''objStreamW.WriteLine(Encrypt(txtMaMay.Text, "cpcpnems"))        
        'objStreamW.Close()
        MsgBox("Cập nhật thành công!")
        Close()
    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Close()
    End Sub
End Class

Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports Ems_International_Logic.EMS
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports System.Diagnostics
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Math

Public Class test
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
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents fbdThuMucSaoLuuDL As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents txtTest As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnTest As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.fbdThuMucSaoLuuDL = New System.Windows.Forms.FolderBrowserDialog
        Me.txtTest = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.btnTest = New Infragistics.Win.Misc.UltraButton
        CType(Me.txtTest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fbdThuMucSaoLuuDL
        '
        Me.fbdThuMucSaoLuuDL.Description = "chon duong dan"
        '
        'txtTest
        '
        Me.txtTest.Location = New System.Drawing.Point(80, 80)
        Me.txtTest.Name = "txtTest"
        Me.txtTest.Size = New System.Drawing.Size(100, 21)
        Me.txtTest.TabIndex = 0
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(88, 136)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(72, 24)
        Me.btnTest.TabIndex = 1
        Me.btnTest.Text = "Test"
        '
        'test
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(472, 269)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.txtTest)
        Me.Name = "test"
        Me.Text = "Chạy thử chương trình"
        CType(Me.txtTest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

#Region "Test"
    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click
        Dim myHam_Dung_Chung As New Ham_Dung_Chung
        Dim Ky_Tu_Kiem_Tra As String
        'Ky_Tu_Kiem_Tra = Asc(txtTest.Text.Substring(0, 1))
        'MessageBox.Show(Ky_Tu_Kiem_Tra, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Kiểm tra thông tin về mã e1
        If myHam_Dung_Chung.Check_E1(txtTest.Text.ToUpper) = False Then
            MessageBox.Show("Số hiệu này không có thật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
#End Region

End Class

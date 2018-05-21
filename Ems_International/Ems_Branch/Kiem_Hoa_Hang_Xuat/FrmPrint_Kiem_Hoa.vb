Imports Ems_International_Logic.EMS
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine

Public Class FrmPrint_Kiem_Hoa
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
    Friend WithEvents rptViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents picPrint As Infragistics.Win.UltraWinEditors.UltraPictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmPrint_Kiem_Hoa))
        Me.rptViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog
        Me.picPrint = New Infragistics.Win.UltraWinEditors.UltraPictureBox
        Me.SuspendLayout()
        '
        'rptViewer
        '
        Me.rptViewer.ActiveViewIndex = -1
        Me.rptViewer.BackColor = System.Drawing.SystemColors.Control
        Me.rptViewer.DisplayBackgroundEdge = False
        Me.rptViewer.DisplayGroupTree = False
        Me.rptViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rptViewer.Location = New System.Drawing.Point(0, 0)
        Me.rptViewer.Name = "rptViewer"
        Me.rptViewer.ReportSource = Nothing
        Me.rptViewer.ShowCloseButton = False
        Me.rptViewer.ShowGotoPageButton = False
        Me.rptViewer.ShowGroupTreeButton = False
        Me.rptViewer.ShowPrintButton = False
        Me.rptViewer.ShowRefreshButton = False
        Me.rptViewer.ShowTextSearchButton = False
        Me.rptViewer.Size = New System.Drawing.Size(791, 565)
        Me.rptViewer.TabIndex = 1
        '
        'picPrint
        '
        Me.picPrint.BorderShadowColor = System.Drawing.Color.Empty
        Me.picPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picPrint.Image = CType(resources.GetObject("picPrint.Image"), Object)
        Me.picPrint.Location = New System.Drawing.Point(168, 0)
        Me.picPrint.Name = "picPrint"
        Me.picPrint.Size = New System.Drawing.Size(24, 24)
        Me.picPrint.TabIndex = 2
        '
        'FrmPrint_Kiem_Hoa
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(791, 565)
        Me.Controls.Add(Me.picPrint)
        Me.Controls.Add(Me.rptViewer)
        Me.MinimizeBox = False
        Me.Name = "FrmPrint_Kiem_Hoa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "In Báo Cáo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Bien report"
    Public GSo_Ban_In_To_Khai As Integer
    Private myReportPrint As ReportClass
    'Private mySo_Ban As Integer
#End Region

    Private Sub FrmPrint_Kiem_Hoa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '        myReportPrint = Me.rptViewer.ReportSource
    End Sub

    Private Sub FrmPrint_Kiem_Hoa_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Windows.Forms.Keys.PageUp Then
            Me.rptViewer.ShowPreviousPage()
        ElseIf e.KeyCode = Windows.Forms.Keys.PageDown Then
            Me.rptViewer.ShowNextPage()
        ElseIf e.KeyCode = Windows.Forms.Keys.Home Then
            Me.rptViewer.ShowFirstPage()
        ElseIf e.KeyCode = Windows.Forms.Keys.End Then
            Me.rptViewer.ShowLastPage()
        ElseIf e.KeyCode >= Windows.Forms.Keys.D0 And e.KeyCode <= Windows.Forms.Keys.D9 Then
            Me.rptViewer.ShowNthPage(e.KeyCode - 48)
        End If
    End Sub

    Private Sub picPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPrint.Click
        'Dim frmSo_Ban As New FrmNhap_So_Luong_Ban_In
        'frmSo_Ban.ShowDialog()
        'If gSo_Ban_In_Kiem_Hoa = 0 Then
        '    gSo_Ban_In_Kiem_Hoa = 2
        '    Exit Sub
        'End If
        myReportPrint.PrintOptions.PrinterDuplex = PrinterDuplex.Default
        myReportPrint.PrintToPrinter(GSo_Ban_In_To_Khai, True, 0, 0)
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub rptViewer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles rptViewer.Load
        myReportPrint = Me.rptViewer.ReportSource
    End Sub
End Class

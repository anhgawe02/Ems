Imports Ems_International_Logic.EMS
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine

Public Class E4in
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtE2id As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtE2id = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(72, 168)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 64)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        '
        'txtE2id
        '
        Me.txtE2id.Location = New System.Drawing.Point(72, 104)
        Me.txtE2id.Name = "txtE2id"
        Me.txtE2id.Size = New System.Drawing.Size(192, 20)
        Me.txtE2id.TabIndex = 1
        Me.txtE2id.Text = "1009161000002008082616050001002"
        '
        'E4in
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.txtE2id)
        Me.Controls.Add(Me.Button1)
        Me.Name = "E4in"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "E4in"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim myE2_di As New E2_Di(GConnectionString)
    Dim mytable As New DataTable

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        mytable = myE2_di.E4(txtE2id.Text).Tables(0)
        Dim pvcollection As New ParameterValues
        Dim p_thamso As New ParameterDiscreteValue
        Dim myMa_Bc_Khai_Thac As New Ma_Bc_Khai_Thac(GConnectionString)
        Dim myDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)


        Dim FrmView As New FrmViewReports
        Dim rptE4 As New RptE4innhan

        Dim Ma_Bc_Khai_Thac As Integer = myE2_di.Lay(txtE2id.Text).Ma_Bc_Khai_Thac
        Dim Ma_Bc As Integer = Convert.ToInt32(txtE2id.Text.Substring(6, 6))
        ''T?/From
        p_thamso.Value = Ma_Bc_Khai_Thac.ToString + "-" + myMa_Bc_Khai_Thac.Lay(Ma_Bc_Khai_Thac).Ten_Bc_Khai_Thac
        pvcollection.Add(p_thamso)
        rptE4.DataDefinition.ParameterFields("Ma_Bc_Khai_Thac").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()
        ''G?i d?n
        p_thamso.Value = Ma_Bc.ToString + "-" + myDanh_Muc_BC.Lay(Ma_Bc).Ten_Buu_Cuc
        pvcollection.Add(p_thamso)
        rptE4.DataDefinition.ParameterFields("Ma_Bc").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        rptE4.SetDataSource(mytable)
        FrmView.CrystalReportViewer1.ReportSource = rptE4
        Cursor.Current = Cursors.Default
        FrmView.ShowDialog()

    End Sub
End Class

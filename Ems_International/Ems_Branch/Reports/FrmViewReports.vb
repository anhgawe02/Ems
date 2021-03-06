Imports Ems_International_Logic.EMS
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Public Class FrmViewReports
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
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Nothing
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(792, 573)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'FrmViewReports
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "FrmViewReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "In báo cáo"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim myData As DataTable
    Private Sub FrmViewReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    ''' <summary>
    ''' Gán giá trị tham số và giá trị cho các tham số trong report
    ''' </summary>
    '''<param name="paramName">Mảng string tên các tham số trên report.</param>
    '''<param name="paramValue">Mảng object giá trị tương ứng với các tham số trên.</param>
    '''<returns>True: Gán thành công False: Có lỗi gán dữ liệu, có thể là do số lượng paramName khác số lượng paramValue</returns>
    Function setParam(ByVal paramName As String(), ByVal paramValue As Object()) As Boolean

        If (paramValue.Length = paramName.Length) Then

            Dim paramFields As New ParameterFields
            For i As Integer = 0 To paramValue.Length - 1

                Dim prmter As New ParameterField
                prmter.ParameterFieldName = paramName(i)
                Dim disParam As New ParameterDiscreteValue
                disParam.Value = paramValue(i)
                prmter.CurrentValues.Add(disParam)
                paramFields.Add(prmter)
            Next
            CrystalReportViewer1.ParameterFieldInfo = paramFields
            Return True
        Else
            Return False
        End If
    End Function

End Class

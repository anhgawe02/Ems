Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Ems_International_Logic.EMS


Public Class Check

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
    Friend WithEvents dtpDenNgay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpTuNgay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dtpDenNgay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpTuNgay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label2 = New System.Windows.Forms.Label
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.dtpDenNgay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTuNgay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpDenNgay
        '
        Me.dtpDenNgay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpDenNgay.Location = New System.Drawing.Point(360, 48)
        Me.dtpDenNgay.Name = "dtpDenNgay"
        Me.dtpDenNgay.Size = New System.Drawing.Size(89, 21)
        Me.dtpDenNgay.TabIndex = 64
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label1.Location = New System.Drawing.Point(280, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "đến ngày"
        '
        'dtpTuNgay
        '
        Me.dtpTuNgay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpTuNgay.Location = New System.Drawing.Point(176, 56)
        Me.dtpTuNgay.Name = "dtpTuNgay"
        Me.dtpTuNgay.Size = New System.Drawing.Size(89, 21)
        Me.dtpTuNgay.TabIndex = 62
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label2.Location = New System.Drawing.Point(112, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Ngày gửi"
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(280, 176)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.TabIndex = 66
        Me.UltraButton1.Text = "UltraButton1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(176, 96)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(104, 20)
        Me.TextBox1.TabIndex = 67
        Me.TextBox1.Text = "550000100000"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(112, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 68
        Me.Button1.Text = "Button1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(208, 288)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 69
        Me.Button2.Text = "Button2"
        '
        'Check
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(608, 350)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.dtpDenNgay)
        Me.Controls.Add(Me.dtpTuNgay)
        Me.Name = "Check"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check"
        CType(Me.dtpDenNgay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTuNgay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim mybaophat As New Bao_Phat(GConnectionString)
    Dim myTable As DataTable


    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        myTable = mybaophat.Thong_Ke_EMS_Khong_Nhap_Bao_Phat(TextBox1.Text, Ham_Dung_Chung.ConvertDateToInt(dtpTuNgay.Value), Ham_Dung_Chung.ConvertDateToInt(dtpDenNgay.Value)).Tables(0)
        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue
        Dim FrmView As New FrmViewReports
        Dim rptthongkekhongnhapBP As New RptThong_Ke_Khong_Nhap_BP

        _pThamSo.Value = GHo_Ten
        pvCollection.Add(_pThamSo)
        rptthongkekhongnhapBP.DataDefinition.ParameterFields("Nguoi_Lap").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        _pThamSo.Value = "Từ ngày " & dtpTuNgay.Text & " đến ngày " & dtpDenNgay.Text
        pvCollection.Add(_pThamSo)
        rptthongkekhongnhapBP.DataDefinition.ParameterFields("Ngay_Phat_Hanh").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()


        rptthongkekhongnhapBP.SetDataSource(myTable)
        FrmView.CrystalReportViewer1.ReportSource = rptthongkekhongnhapBP
        Cursor.Current = Cursors.Default
        FrmView.ShowDialog()


    End Sub

    Private Sub Check_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpTuNgay.Value = Ham_Dung_Chung.dBeginMonth(Now)
        dtpDenNgay.Value = Ham_Dung_Chung.dEndMonth(Now)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
    Private Sub hi()
        'Dim myNuoc As New Ma_Nuoc(GConnectionString)
        'Dim mydata As DataSet
        'mydata = myNuoc.Danh_Sach
        'Dim myreport As New Danh_Sach_Nuoc
        'myreport.SetDataSource(mydata.Tables(0))
        'Dim pvCollection As New ParameterValues
        'Dim _pThamSo As New ParameterDiscreteValue

        '_pThamSo.Value = "Thu cai nao"
        'pvCollection.Add(_pThamSo)
        'myreport.DataDefinition.ParameterFields("gigido").ApplyCurrentValues(pvCollection)
        'pvCollection.Clear()

        '_pThamSo.Value = "chán như con gián"
        'pvCollection.Add(_pThamSo)
        'myreport.DataDefinition.ParameterFields("channghe").ApplyCurrentValues(pvCollection)
        'pvCollection.Clear()

        'Dim FrmView As New FrmViewReports
        'FrmView.CrystalReportViewer1.ReportSource = myreport
        'Cursor.Current = Cursors.Default
        'FrmView.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CMessageBox.Show("chan nhu con gian")
        Ban_Ke_E2_Di("10091550106302008100811", True, 1, 1)
    End Sub
End Class

Imports System.IO
Imports System.Data.OracleClient
Imports Ems_International_Logic.EMS
Public Class FrmCapNhatChuongTrinh
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
    Friend WithEvents prgBar As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    Friend WithEvents btnThoat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btTESTcode As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TestOracle As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnTest As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCapNhatChuongTrinh))
        Me.prgBar = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar
        Me.btnThoat = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.btTESTcode = New Infragistics.Win.Misc.UltraButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.TestOracle = New Infragistics.Win.Misc.UltraButton
        Me.btnTest = New Infragistics.Win.Misc.UltraButton
        Me.SuspendLayout()
        '
        'prgBar
        '
        Me.prgBar.Enabled = False
        Me.prgBar.Location = New System.Drawing.Point(16, 64)
        Me.prgBar.Name = "prgBar"
        Me.prgBar.PercentFormat = ""
        Me.prgBar.Size = New System.Drawing.Size(392, 23)
        Me.prgBar.Step = 1
        Me.prgBar.Style = Infragistics.Win.UltraWinProgressBar.ProgressBarStyle.Segmented
        Me.prgBar.TabIndex = 0
        Me.prgBar.Text = "[Formatted]"
        '
        'btnThoat
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.btnThoat.Appearance = Appearance1
        Me.btnThoat.Location = New System.Drawing.Point(168, 224)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(88, 32)
        Me.btnThoat.TabIndex = 10
        Me.btnThoat.Text = "Thoát"
        '
        'UltraButton1
        '
        Me.UltraButton1.Enabled = False
        Me.UltraButton1.Location = New System.Drawing.Point(232, 0)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(96, 48)
        Me.UltraButton1.TabIndex = 11
        Me.UltraButton1.Text = "UltraButton1"
        '
        'btTESTcode
        '
        Me.btTESTcode.Location = New System.Drawing.Point(272, 224)
        Me.btTESTcode.Name = "btTESTcode"
        Me.btTESTcode.Size = New System.Drawing.Size(104, 32)
        Me.btTESTcode.TabIndex = 12
        Me.btTESTcode.Text = "TestE2-CN38"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(304, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Button1"
        '
        'TestOracle
        '
        Me.TestOracle.Enabled = False
        Me.TestOracle.Location = New System.Drawing.Point(24, 120)
        Me.TestOracle.Name = "TestOracle"
        Me.TestOracle.Size = New System.Drawing.Size(112, 23)
        Me.TestOracle.TabIndex = 14
        Me.TestOracle.Text = "TEST ORACLE"
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(56, 168)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(144, 32)
        Me.btnTest.TabIndex = 15
        Me.btnTest.Text = "Bật Form Test"
        '
        'FrmCapNhatChuongTrinh
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(424, 273)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.TestOracle)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btTESTcode)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.prgBar)
        Me.MaximizeBox = False
        Me.Name = "FrmCapNhatChuongTrinh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cập nhật chương trình"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim myProcess As New System.Diagnostics.Process
    Dim ReaderThread As System.Threading.Thread
    Private Sub Reader()
        prgBar.PerformStep()
        Threading.Thread.Sleep(10)
    End Sub
    Private Sub FrmCapNhatChuongTrinh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ReaderThread = New System.Threading.Thread(AddressOf Reader)
        ReaderThread.IsBackground = True
        ReaderThread.Name = "Reader"

        ReaderThread.Start()
        If File.Exists("RunSql.bat") Then
            Dim startCmd As ProcessStartInfo
            startCmd = New ProcessStartInfo("RunSql.bat")
            startCmd.WindowStyle = ProcessWindowStyle.Hidden
            startCmd.UseShellExecute = True
            myProcess = Process.Start(startCmd)

        End If

        If GUserAdmin = True Then
            btnTest.Enabled = True
        Else
            btnTest.Enabled = False
        End If
    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Close()
        'Ban_Ke_Bao_Cao_Hai_Quan(100915200901121)
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Dim frm As New FrmSuaChuaE2Den_OutBout
        frm.ShowDialog()
    End Sub


    Private Sub btTESTcode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTESTcode.Click
        Dim a As New Thu
        a.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Frm As New FrmQuanLyChuyenThu
        Frm.ShowDialog()
    End Sub

    Private Sub TestOracle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestOracle.Click

        'Dim a As New E1I1_Oracle("Provider=OraOLEDB.Oracle;CONNECTSTRING=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.68.26)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=tuyennv))); uid=ems;pwd=ems;")
        'a.update_test() '

        'Dim Str_Connect_Oracle As String
        'Dim Connect_Oracle_EMSKHAITHAC As ADODB.Connection
        'Dim Comm As ADODB.Command
        'Dim Prm As ADODB.Parameter
        'Dim cuoc As Long
        ''Str_Connect_Oracle = "Provider=OraOLEDB.Oracle;Password=ems;Persist Security Info=True;User ID=ems;Data Source=192.168.68.26"
        'Str_Connect_Oracle = "Provider=OraOLEDB.Oracle;CONNECTSTRING=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.68.26)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=tuyennv))); uid=ems;pwd=ems;"
        'Comm = New ADODB.Command
        'Connect_Oracle_EMSKHAITHAC = New ADODB.Connection
        ''Connect_Oracle_EMSKHAITHAC = New OracleConnection
        'Connect_Oracle_EMSKHAITHAC.Open(Str_Connect_Oracle)
        'Comm.ActiveConnection = Connect_Oracle_EMSKHAITHAC
        'Comm.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        'Comm.CommandText = "Insert_Table_Test"
        'Prm = Comm.CreateParameter("v_ngay", ADODB.DataTypeEnum.adNumeric, ADODB.ParameterDirectionEnum.adParamInput, 10, 10)
        'Comm.Parameters.Append(Prm)
        'Prm = Comm.CreateParameter("v_thang", ADODB.DataTypeEnum.adNumeric, ADODB.ParameterDirectionEnum.adParamInput, 10, 20)
        'Comm.Parameters.Append(Prm)
        'Prm = Comm.CreateParameter("v_nam", ADODB.DataTypeEnum.adNumeric, ADODB.ParameterDirectionEnum.adParamInput, 10, 30)
        'Comm.Parameters.Append(Prm)
        'Comm.Execute()

        'Comm = Nothing
        'Prm = Nothing
        'Connect_Oracle_EMSKHAITHAC.Close()
        'Dim myOracleConnection As New OracleConnection("User Id=ems;Password=ems;Data Source=TUYENNV")
        'myOracleConnection.Open()
        'Dim myOracleTransaction As OracleTransaction = myOracleConnection.BeginTransaction()

        'Dim myOracleCommand As new OracleCommand = myOracleConnection.CreateCommand()
        'Dim myOracleCommand As New OracleCommand
        'myOracleCommand.CommandText = "INSERT INTO TABLE_TEST (NGAY,THANG,NAM) VALUES (0, 1,2)"
        'myOracleCommand.ExecuteNonQuery()
        'myOracleTransaction.Commit()
        'myOracleConnection.Close()
    End Sub

    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click
        Dim Frm As New test
        Frm.ShowDialog()
    End Sub
End Class

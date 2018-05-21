'Ngày tạo: 08/07/08
'Người tạo: Nguyễn Bằng
Imports System.Web.Services
Public Class FrmGioiThieuChuongTrinh
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
    Friend WithEvents Panel As System.Windows.Forms.Panel
    Friend WithEvents tmrScroll As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Panel = New System.Windows.Forms.Panel
        Me.tmrScroll = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel
        '
        Me.Panel.Controls.Add(Me.Button1)
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(314, 279)
        Me.Panel.TabIndex = 0
        '
        'tmrScroll
        '
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(160, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        '
        'FrmGioiThieuChuongTrinh
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(314, 279)
        Me.Controls.Add(Me.Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGioiThieuChuongTrinh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Giới thiệu chương trình"
        Me.Panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Enum Pos As Integer
        X
        Y
    End Enum

    Private Structure Lines
        Dim Label As Label
        Dim PosInArray As Byte
    End Structure
    Private _Text As String
    Private _AutoSize As Boolean
    Private TextToScroll(1) As Lines
    Private MaxLines As Byte = CByte((Me.height / 15) + 2)
    Private _Delay As Integer = 20
    Private _BorderStyle As System.Windows.Forms.BorderStyle = BorderStyle.None
    Private _TextAlign As System.Drawing.ContentAlignment = ContentAlignment.MiddleCenter
    Private _OffSet As Integer = 5
    Private FontSize As Integer = 15
    Private Sub FrmGioiThieuChuongTrinh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel.Dock = DockStyle.Fill
        If _Text = "" Then _Text = "Chương trình EMS khai thác phiên bản 1.2" & vbCrLf & "Được phát triển bởi phòng CNTT - EMS" & vbCrLf & _
        "Đỗ Tiến Việt (PM) - 0913226191 - vietdt@ems.com.vn" & vbCrLf & _
        "Nguyễn Bằng - 0912742207 - bangnguyen@ems.com.vn" & vbCrLf & _
        "Đỗ Quốc Khánh - 0945081981 - khanhdq@ems.com.vn" & vbCrLf & _
        "Trần Quang Đô - 0914822868 - donq@ems.com.vn" & vbCrLf & _
        "Nguyễn Văn Tuyến - 0912506604 - tuyennt@ems.com.vn" & vbCrLf & _
        "Nguyễn Đức Trung - 0913567696 - trungnd@ems.com.vn" & vbCrLf & _
        "Vũ Hồng Dương - 0913364064 - duongnd@ems.com.vn" & vbCrLf & _
        "Nguyễn Hoàng Anh - 01696900969 - anhnh@ems.com.vn" & vbCrLf & _
        "Đinh Quang Trung - 0912262243 - trungdq@ems.com.vn" & vbCrLf & _
        "Công ty cổ phần Chuyển Phát Nhanh Bưu Điện" & vbCrLf & _
        "Số 1 - Tân Xuân - Xuân Đỉnh - Từ Liêm - Hà Nội"
        Loadtext()
        tmrScroll.Interval = _Delay
        tmrScroll.Enabled = True
    End Sub
    Private Sub Loadtext()
        Dim LL As Byte
        If MaxLines > UBound(_Text.Split(Chr(13))) Then LL = UBound(_Text.Split(Chr(13))) _
        Else LL = MaxLines
        ReDim TextToScroll(LL)
        For x As Byte = 0 To LL
            Dim Lbl As New Label
            Lbl.Location = New System.Drawing.Point(0, Panel.Height + (x * 15))
            Lbl.Size = New System.Drawing.Size(Panel.Width, 15)
            Lbl.TextAlign = ContentAlignment.MiddleCenter
            Lbl.ForeColor = Color.Black
            Lbl.Tag = x
            Lbl.Visible = False
            Lbl.TextAlign = _TextAlign
            AddHandler Lbl.MouseEnter, AddressOf Panel_MouseEnter
            AddHandler Lbl.MouseLeave, AddressOf Panel_MouseLeave
            Panel.Controls.Add(Lbl)
            TextToScroll(x) = New Lines
            TextToScroll(x).Label = Lbl
            TextToScroll(x).PosInArray = x

        Next
        Call FixFontSize()
    End Sub
    Private Sub FixFontSize()
        Dim Factor As Byte = 0
        Select Case Me.Font.Size
            Case 12 To 15
                Factor = 1.1
            Case Else
                Factor = 0.9
        End Select
        For x As Byte = 0 To UBound(TextToScroll)
            Try
                TextToScroll(x).Label.Height = CInt(Me.Font.Height * Factor)
                TextToScroll(x).Label.Top = Panel.Height + (x * CInt(Me.Font.Height * Factor))
            Catch ex As Exception
            End Try
        Next
    End Sub

    Private Sub tmrScroll_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrScroll.Tick
        Dim lblMsg As Lines
        Dim index As Byte = 0
        For Each lblMsg In TextToScroll
            Application.DoEvents()
            '------------------ Adjust the Text ---------------------------
            lblMsg.Label.Text = _Text.Split(Chr(13))(index).ToString.Trim
            If index > UBound(_Text.Split(Chr(13))) Then index = 0 _
            Else index += 1
            '--------------------------------------------------------------
            If lblMsg.Label.Top > lblMsg.Label.Height - 35 Then
                lblMsg.Label.Top = lblMsg.Label.Top - 1
            Else
                lblMsg.Label.Top = Panel.Height
            End If
            Application.DoEvents()
            lblMsg.Label.TextAlign = _TextAlign
            lblMsg.Label.AutoSize = _AutoSize
            lblMsg.Label.BackColor = Me.BackColor
            lblMsg.Label.Left = _OffSet
            lblMsg.Label.Visible = True
            Select Case lblMsg.Label.Top
                Case -15 To -7
                    lblMsg.Label.ForeColor = Color.Gainsboro
                Case -6 To -3
                    lblMsg.Label.ForeColor = Color.LightGray
                Case -2 To 0
                    lblMsg.Label.ForeColor = Color.Silver
                Case 1 To 3
                    lblMsg.Label.ForeColor = Color.DarkGray
                Case 4 To 7
                    lblMsg.Label.ForeColor = Color.Gray
                Case 8 To 11
                    lblMsg.Label.ForeColor = Color.DimGray


                Case Panel.Height - 31 To Panel.Height - 28
                    lblMsg.Label.ForeColor = Color.DimGray
                Case Panel.Height - 27 To Panel.Height - 24
                    lblMsg.Label.ForeColor = Color.Gray
                Case Panel.Height - 23 To Panel.Height - 20
                    lblMsg.Label.ForeColor = Color.DarkGray
                Case Panel.Height - 19 To Panel.Height - 17
                    lblMsg.Label.ForeColor = Color.Silver
                Case Panel.Height - 16 To Panel.Height - 13
                    lblMsg.Label.ForeColor = Color.LightGray
                Case Panel.Height - 12 To Panel.Height
                    lblMsg.Label.ForeColor = Color.Gainsboro
                Case Else
                    lblMsg.Label.ForeColor = Me.ForeColor
            End Select
        Next
        tmrScroll.Interval = _Delay
    End Sub

    Private Sub Panel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel.Paint

    End Sub

    Private Sub Panel_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel.MouseEnter
        tmrScroll.Enabled = False
    End Sub

    Private Sub Panel_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel.MouseLeave
        tmrScroll.Enabled = True
    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim aaa As New API_ESHIPPING.Service

        Dim myAPI As New E1_USPS.E1_MAP


    End Sub
End Class

Imports System.IO
Imports System.Drawing.Printing
Imports System.Security.Cryptography
Imports System
Imports System.Data
Imports System.Data.SqlClient


Public Class Frm_Update
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
    Friend WithEvents lbl_Thong_Tin As System.Windows.Forms.Label
    Friend WithEvents btn_Cap_Nhat As System.Windows.Forms.Button
    Friend WithEvents ProgressBar As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    Friend WithEvents Group_Local As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Group_Server As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btn_Duong_Dan_Local As System.Windows.Forms.Button
    Friend WithEvents txt_Duong_Dan_Local As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Duong_Dan_Local As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbl_Duong_Dan_Server As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btn_Duong_Dan_Server As System.Windows.Forms.Button
    Friend WithEvents txt_Duong_Dan_Server As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents FolderBrowserDialog2 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Gio_Cap_Nhat As System.Windows.Forms.Label
    Friend WithEvents lbl_Ngay_Cap_Nhat As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_Ip_Server As System.Windows.Forms.Label
    Friend WithEvents lbl_Gio_Cap_Nhat_Server As System.Windows.Forms.Label
    Friend WithEvents lbl_Ngay_Cap_Nhat_Server As System.Windows.Forms.Label
    Friend WithEvents lbl_Phien_Ban_Server As System.Windows.Forms.Label
    Friend WithEvents lbl_Phien_Ban_Local As System.Windows.Forms.Label
    Friend WithEvents lbl_ip_Local As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lbl_Thong_Tin = New System.Windows.Forms.Label
        Me.btn_Cap_Nhat = New System.Windows.Forms.Button
        Me.ProgressBar = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar
        Me.btn_Duong_Dan_Local = New System.Windows.Forms.Button
        Me.txt_Duong_Dan_Local = New System.Windows.Forms.TextBox
        Me.Group_Local = New Infragistics.Win.Misc.UltraGroupBox
        Me.lbl_Duong_Dan_Local = New Infragistics.Win.Misc.UltraLabel
        Me.Group_Server = New Infragistics.Win.Misc.UltraGroupBox
        Me.lbl_Duong_Dan_Server = New Infragistics.Win.Misc.UltraLabel
        Me.btn_Duong_Dan_Server = New System.Windows.Forms.Button
        Me.txt_Duong_Dan_Server = New System.Windows.Forms.TextBox
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl_ip_Local = New System.Windows.Forms.Label
        Me.lbl_Gio_Cap_Nhat = New System.Windows.Forms.Label
        Me.lbl_Ngay_Cap_Nhat = New System.Windows.Forms.Label
        Me.lbl_Phien_Ban_Local = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_Ip_Server = New System.Windows.Forms.Label
        Me.lbl_Gio_Cap_Nhat_Server = New System.Windows.Forms.Label
        Me.lbl_Ngay_Cap_Nhat_Server = New System.Windows.Forms.Label
        Me.lbl_Phien_Ban_Server = New System.Windows.Forms.Label
        CType(Me.Group_Local, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group_Local.SuspendLayout()
        CType(Me.Group_Server, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group_Server.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Thong_Tin
        '
        Me.lbl_Thong_Tin.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Thong_Tin.Location = New System.Drawing.Point(10, 10)
        Me.lbl_Thong_Tin.Name = "lbl_Thong_Tin"
        Me.lbl_Thong_Tin.Size = New System.Drawing.Size(650, 40)
        Me.lbl_Thong_Tin.TabIndex = 121
        Me.lbl_Thong_Tin.Text = "Cập nhật chương trình EMS International"
        Me.lbl_Thong_Tin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_Cap_Nhat
        '
        Me.btn_Cap_Nhat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cap_Nhat.Location = New System.Drawing.Point(10, 330)
        Me.btn_Cap_Nhat.Name = "btn_Cap_Nhat"
        Me.btn_Cap_Nhat.Size = New System.Drawing.Size(80, 35)
        Me.btn_Cap_Nhat.TabIndex = 123
        Me.btn_Cap_Nhat.Text = "Cập Nhật"
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(100, 330)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(560, 35)
        Me.ProgressBar.TabIndex = 124
        Me.ProgressBar.Text = "[Formatted]"
        '
        'btn_Duong_Dan_Local
        '
        Me.btn_Duong_Dan_Local.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Duong_Dan_Local.Location = New System.Drawing.Point(285, 155)
        Me.btn_Duong_Dan_Local.Name = "btn_Duong_Dan_Local"
        Me.btn_Duong_Dan_Local.Size = New System.Drawing.Size(30, 25)
        Me.btn_Duong_Dan_Local.TabIndex = 125
        Me.btn_Duong_Dan_Local.Text = "..."
        '
        'txt_Duong_Dan_Local
        '
        Me.txt_Duong_Dan_Local.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Duong_Dan_Local.Location = New System.Drawing.Point(10, 155)
        Me.txt_Duong_Dan_Local.Name = "txt_Duong_Dan_Local"
        Me.txt_Duong_Dan_Local.Size = New System.Drawing.Size(270, 22)
        Me.txt_Duong_Dan_Local.TabIndex = 128
        Me.txt_Duong_Dan_Local.Text = ""
        '
        'Group_Local
        '
        Me.Group_Local.Controls.Add(Me.Label2)
        Me.Group_Local.Controls.Add(Me.lbl_ip_Local)
        Me.Group_Local.Controls.Add(Me.lbl_Gio_Cap_Nhat)
        Me.Group_Local.Controls.Add(Me.lbl_Ngay_Cap_Nhat)
        Me.Group_Local.Controls.Add(Me.lbl_Phien_Ban_Local)
        Me.Group_Local.Controls.Add(Me.lbl_Duong_Dan_Local)
        Me.Group_Local.Controls.Add(Me.btn_Duong_Dan_Local)
        Me.Group_Local.Controls.Add(Me.txt_Duong_Dan_Local)
        Me.Group_Local.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Group_Local.Location = New System.Drawing.Point(10, 60)
        Me.Group_Local.Name = "Group_Local"
        Me.Group_Local.Size = New System.Drawing.Size(325, 260)
        Me.Group_Local.SupportThemes = False
        Me.Group_Local.TabIndex = 129
        Me.Group_Local.Text = "Thông Tin Local"
        '
        'lbl_Duong_Dan_Local
        '
        Me.lbl_Duong_Dan_Local.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Duong_Dan_Local.Location = New System.Drawing.Point(10, 190)
        Me.lbl_Duong_Dan_Local.Name = "lbl_Duong_Dan_Local"
        Me.lbl_Duong_Dan_Local.Size = New System.Drawing.Size(300, 55)
        Me.lbl_Duong_Dan_Local.TabIndex = 129
        '
        'Group_Server
        '
        Me.Group_Server.Controls.Add(Me.Label1)
        Me.Group_Server.Controls.Add(Me.lbl_Ip_Server)
        Me.Group_Server.Controls.Add(Me.lbl_Gio_Cap_Nhat_Server)
        Me.Group_Server.Controls.Add(Me.lbl_Ngay_Cap_Nhat_Server)
        Me.Group_Server.Controls.Add(Me.lbl_Phien_Ban_Server)
        Me.Group_Server.Controls.Add(Me.lbl_Duong_Dan_Server)
        Me.Group_Server.Controls.Add(Me.btn_Duong_Dan_Server)
        Me.Group_Server.Controls.Add(Me.txt_Duong_Dan_Server)
        Me.Group_Server.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Group_Server.Location = New System.Drawing.Point(340, 60)
        Me.Group_Server.Name = "Group_Server"
        Me.Group_Server.Size = New System.Drawing.Size(325, 260)
        Me.Group_Server.SupportThemes = False
        Me.Group_Server.TabIndex = 130
        Me.Group_Server.Text = "Thông Tin Server"
        '
        'lbl_Duong_Dan_Server
        '
        Me.lbl_Duong_Dan_Server.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Duong_Dan_Server.Location = New System.Drawing.Point(10, 190)
        Me.lbl_Duong_Dan_Server.Name = "lbl_Duong_Dan_Server"
        Me.lbl_Duong_Dan_Server.Size = New System.Drawing.Size(300, 55)
        Me.lbl_Duong_Dan_Server.TabIndex = 132
        '
        'btn_Duong_Dan_Server
        '
        Me.btn_Duong_Dan_Server.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Duong_Dan_Server.Location = New System.Drawing.Point(285, 150)
        Me.btn_Duong_Dan_Server.Name = "btn_Duong_Dan_Server"
        Me.btn_Duong_Dan_Server.Size = New System.Drawing.Size(30, 25)
        Me.btn_Duong_Dan_Server.TabIndex = 130
        Me.btn_Duong_Dan_Server.Text = "..."
        '
        'txt_Duong_Dan_Server
        '
        Me.txt_Duong_Dan_Server.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Duong_Dan_Server.Location = New System.Drawing.Point(10, 150)
        Me.txt_Duong_Dan_Server.Name = "txt_Duong_Dan_Server"
        Me.txt_Duong_Dan_Server.Size = New System.Drawing.Size(270, 22)
        Me.txt_Duong_Dan_Server.TabIndex = 131
        Me.txt_Duong_Dan_Server.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 25)
        Me.Label2.TabIndex = 142
        Me.Label2.Text = "Ip Local:"
        '
        'lbl_ip_Local
        '
        Me.lbl_ip_Local.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ip_Local.Location = New System.Drawing.Point(80, 115)
        Me.lbl_ip_Local.Name = "lbl_ip_Local"
        Me.lbl_ip_Local.Size = New System.Drawing.Size(230, 25)
        Me.lbl_ip_Local.TabIndex = 141
        '
        'lbl_Gio_Cap_Nhat
        '
        Me.lbl_Gio_Cap_Nhat.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Gio_Cap_Nhat.Location = New System.Drawing.Point(10, 85)
        Me.lbl_Gio_Cap_Nhat.Name = "lbl_Gio_Cap_Nhat"
        Me.lbl_Gio_Cap_Nhat.Size = New System.Drawing.Size(300, 25)
        Me.lbl_Gio_Cap_Nhat.TabIndex = 140
        Me.lbl_Gio_Cap_Nhat.Text = "Cập Nhật Giờ"
        '
        'lbl_Ngay_Cap_Nhat
        '
        Me.lbl_Ngay_Cap_Nhat.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Ngay_Cap_Nhat.Location = New System.Drawing.Point(10, 55)
        Me.lbl_Ngay_Cap_Nhat.Name = "lbl_Ngay_Cap_Nhat"
        Me.lbl_Ngay_Cap_Nhat.Size = New System.Drawing.Size(300, 25)
        Me.lbl_Ngay_Cap_Nhat.TabIndex = 139
        Me.lbl_Ngay_Cap_Nhat.Text = "Cập Nhật Ngày"
        '
        'lbl_Phien_Ban_Local
        '
        Me.lbl_Phien_Ban_Local.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Phien_Ban_Local.Location = New System.Drawing.Point(10, 25)
        Me.lbl_Phien_Ban_Local.Name = "lbl_Phien_Ban_Local"
        Me.lbl_Phien_Ban_Local.Size = New System.Drawing.Size(300, 25)
        Me.lbl_Phien_Ban_Local.TabIndex = 138
        Me.lbl_Phien_Ban_Local.Text = "Phiên Bản Hiện Tại"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 25)
        Me.Label1.TabIndex = 141
        Me.Label1.Text = "Ip Server:"
        '
        'lbl_Ip_Server
        '
        Me.lbl_Ip_Server.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Ip_Server.Location = New System.Drawing.Point(80, 115)
        Me.lbl_Ip_Server.Name = "lbl_Ip_Server"
        Me.lbl_Ip_Server.Size = New System.Drawing.Size(230, 25)
        Me.lbl_Ip_Server.TabIndex = 140
        '
        'lbl_Gio_Cap_Nhat_Server
        '
        Me.lbl_Gio_Cap_Nhat_Server.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Gio_Cap_Nhat_Server.Location = New System.Drawing.Point(10, 85)
        Me.lbl_Gio_Cap_Nhat_Server.Name = "lbl_Gio_Cap_Nhat_Server"
        Me.lbl_Gio_Cap_Nhat_Server.Size = New System.Drawing.Size(300, 25)
        Me.lbl_Gio_Cap_Nhat_Server.TabIndex = 139
        Me.lbl_Gio_Cap_Nhat_Server.Text = "Cập Nhật  Giờ"
        '
        'lbl_Ngay_Cap_Nhat_Server
        '
        Me.lbl_Ngay_Cap_Nhat_Server.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Ngay_Cap_Nhat_Server.Location = New System.Drawing.Point(10, 55)
        Me.lbl_Ngay_Cap_Nhat_Server.Name = "lbl_Ngay_Cap_Nhat_Server"
        Me.lbl_Ngay_Cap_Nhat_Server.Size = New System.Drawing.Size(300, 25)
        Me.lbl_Ngay_Cap_Nhat_Server.TabIndex = 138
        Me.lbl_Ngay_Cap_Nhat_Server.Text = "Cập Nhật Ngày"
        '
        'lbl_Phien_Ban_Server
        '
        Me.lbl_Phien_Ban_Server.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Phien_Ban_Server.Location = New System.Drawing.Point(10, 25)
        Me.lbl_Phien_Ban_Server.Name = "lbl_Phien_Ban_Server"
        Me.lbl_Phien_Ban_Server.Size = New System.Drawing.Size(300, 25)
        Me.lbl_Phien_Ban_Server.TabIndex = 137
        Me.lbl_Phien_Ban_Server.Text = "Phiên Bản Trên Máy Chủ"
        '
        'Frm_Update
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(672, 373)
        Me.Controls.Add(Me.Group_Server)
        Me.Controls.Add(Me.Group_Local)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.btn_Cap_Nhat)
        Me.Controls.Add(Me.lbl_Thong_Tin)
        Me.Name = "Frm_Update"
        Me.Text = "Cập nhật chương trình"
        CType(Me.Group_Local, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group_Local.ResumeLayout(False)
        CType(Me.Group_Server, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group_Server.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim myRegistry As New ModifyRegistry
    Dim GConnectionString As String
    

#Region "-----------------------Frm_Update_Load-----------------------"
    Private Sub Frm_Update_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Hien_Thi_Thong_Tin()
    End Sub
#End Region

#Region "-----------------------Hien_Thi_Thong_Tin-----------------------"
    Private Sub Hien_Thi_Thong_Tin()
        'Thông tin Server
        Dim m_Thong_Tin_Server As String = ""
        m_Thong_Tin_Server = ""
        Cau_Hinh_Database()
        Dim m_Dataset As New DataSet
        m_Dataset = Thong_Tin_Noi_Bo_Danh_Sach()


        Dim m_Ip_Cap_Nhat As String
        Dim m_Duong_Dan_Cap_Nhat As String
        Dim m_Ngay_Cap_Nhat As Date
        Dim m_Gio_Cap_Nhat As String

        Dim myTham_So_He_Thong As New Tham_So_He_Thong(GConnectionString)
        Dim myTham_So_He_Thong_Chi_Tiet As New Tham_So_He_Thong_Chi_Tiet

        m_Ip_Cap_Nhat = myTham_So_He_Thong.Tham_So_He_Thong_Lay("Ip_Cap_Nhat").Gia_Tri
        m_Duong_Dan_Cap_Nhat = myTham_So_He_Thong.Tham_So_He_Thong_Lay("Duong_Dan_Cap_Nhat").Gia_Tri
        m_Ngay_Cap_Nhat = ConvertIntToDate(CInt(myTham_So_He_Thong.Tham_So_He_Thong_Lay("Ngay_Cap_Nhat").Gia_Tri)).ToString("dd/MM/yyyy")
        m_Gio_Cap_Nhat = ConvertIntToTime(CInt(myTham_So_He_Thong.Tham_So_He_Thong_Lay("Gio_Cap_Nhat").Gia_Tri))

        If m_Dataset.Tables(0).Rows.Count > 0 Then
            lbl_Phien_Ban_Server.Text = "Phiên Bản Trên Server Là     : " & m_Dataset.Tables(0).Rows(0).Item("Phien_Ban")
            lbl_Ngay_Cap_Nhat_Server.Text = "Ngày Cập Nhật    : " & m_Ngay_Cap_Nhat
            lbl_Gio_Cap_Nhat_Server.Text = "Giờ Cập Nhật     : " & m_Gio_Cap_Nhat
            lbl_Ip_Server.Text = m_Ip_Cap_Nhat

            txt_Duong_Dan_Server.Text = "\\" & m_Ip_Cap_Nhat & "\" & m_Duong_Dan_Cap_Nhat
            lbl_Duong_Dan_Server.Text = "\\" & m_Ip_Cap_Nhat & "\" & m_Duong_Dan_Cap_Nhat
        Else
            lbl_Phien_Ban_Server.Text = "Phiên Bản Trên Server Là     :  Không xác định"
            lbl_Ngay_Cap_Nhat_Server.Text = "Ngày Cập Nhật    : " & m_Ngay_Cap_Nhat
            lbl_Gio_Cap_Nhat_Server.Text = "Giờ Cập Nhật     : " & m_Gio_Cap_Nhat
            lbl_Ip_Server.Text = m_Ip_Cap_Nhat

            txt_Duong_Dan_Server.Text = "\\" & m_Ip_Cap_Nhat & "\" & m_Duong_Dan_Cap_Nhat
            lbl_Duong_Dan_Server.Text = "\\" & m_Ip_Cap_Nhat & "\" & m_Duong_Dan_Cap_Nhat
        End If

        'Thông tin Local
        Dim Ip_Address_Local As System.Net.IPHostEntry = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName)
        Dim m_Ip_Local As String
        m_Ip_Local = Ip_Address_Local.AddressList.GetValue(0).ToString

        If myRegistry.Doc("Phien_Ban_EMS_International") = "" Then
            lbl_Phien_Ban_Local.Text = "Phiên Bản Hiện Tại Là     : Không xác định"
            lbl_Ngay_Cap_Nhat.Text = "Ngày Cập Nhật : Không xác định"
            lbl_Gio_Cap_Nhat.Text = "Giờ Cập Nhật  : Không xác định"
            lbl_ip_Local.Text = m_Ip_Local
        Else
            lbl_Phien_Ban_Local.Text = "Phiên Bản Hiện Tại Là     : " & myRegistry.Doc("Phien_Ban_EMS_International")
            lbl_Ngay_Cap_Nhat.Text = "Ngày Cập Nhật : " & myRegistry.Doc("Ngay_Cap_Nhat_EMS_International")
            lbl_Gio_Cap_Nhat.Text = "Giờ Cập Nhật  : " & myRegistry.Doc("Gio_Cap_Nhat_EMS_International")
            lbl_ip_Local.Text = m_Ip_Local
        End If

        Dim m_Duong_Dan_Local As String
        If myRegistry.Doc("Duong_Dan_EMS_International") = "" Then
            m_Duong_Dan_Local = "C:\Program Files\EMS\EMS_International"
        Else
            m_Duong_Dan_Local = myRegistry.Doc("Duong_Dan_EMS_International")
        End If
        lbl_Duong_Dan_Local.Text = m_Duong_Dan_Local
        txt_Duong_Dan_Local.Text = m_Duong_Dan_Local
    End Sub
#End Region

#Region "--------------------Cau_Hinh_Database--------------------"
    Public Function Cau_Hinh_Database() As Boolean
        Dim myRegistry As New ModifyRegistry
        If myRegistry.Doc("IpDataBase") Is Nothing Then
            Exit Function
        End If
        Dim str As String

        If Not myRegistry.Doc("IpDataBase") Is Nothing Then
            str = myRegistry.Doc("IpDataBase")
            GConnectionString = "Server = " & str & ";"

            str = myRegistry.Doc("NameDataBase")
            GConnectionString = GConnectionString & "database=" & str & ";"

            str = myRegistry.Doc("UserDataBase")
            GConnectionString = GConnectionString & "uid=" & str & ";"
            'uid = str

            str = Decrypt(myRegistry.Doc("PassDataBase"), "cpcpnems")
            GConnectionString = GConnectionString & "pwd=" & str
            Return True
        Else
            MessageBox.Show("Không tồn tại kết nối tới cơ sở dữ liệu !!! Liên hệ với người quản trị hệ thống để nhận lại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If
        Return True
    End Function
#End Region

#Region "--------------------Decrypt--------------------"
    'The function used to decrypt the text
    Public Function Decrypt(ByVal strText As String, ByVal sDecrKey As String) As String
        Dim byKey() As Byte = {}
        'Co the thay doi phan IV() nay, tuong tu cho Encrypt.
        Dim IV() As Byte = {&H11, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF}
        Dim inputByteArray(strText.Length) As Byte

        Try
            byKey = System.Text.Encoding.UTF8.GetBytes(sDecrKey)
            Dim des As New DESCryptoServiceProvider
            inputByteArray = Convert.FromBase64String(strText)
            Dim ms As New MemoryStream
            Dim cs As New CryptoStream(ms, des.CreateDecryptor(byKey, IV), CryptoStreamMode.Write)
            cs.Write(inputByteArray, 0, inputByteArray.Length)
            cs.FlushFinalBlock()
            Dim encoding As System.Text.Encoding = System.Text.Encoding.UTF8

            Return encoding.GetString(ms.ToArray())

        Catch ex As Exception
            Return ex.Message
        End Try

    End Function
#End Region

#Region "--------------------Thong_Tin_Noi_Bo_Danh_Sach--------------------"
    Public Function Thong_Tin_Noi_Bo_Danh_Sach() As DataSet
        Dim MyCommand As SqlCommand = New SqlCommand
        MyCommand.CommandText = "Thong_Tin_Noi_Bo_Danh_Sach"
        MyCommand.CommandType = CommandType.StoredProcedure
        Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
        Dim MyDataSet As New DataSet

        Dim MyConnection As New SqlConnection(GConnectionString)
        MyCommand.Connection = MyConnection

        Try

            'Define the parameters
            MyConnection.Open()
            Adapter.Fill(MyDataSet)

            Return MyDataSet

        Catch ex As Exception
            Console.Write(ex.ToString)
        Finally
            'Close the connection and Dispose.
            MyConnection.Close()
            MyCommand.Dispose()
            Adapter.Dispose()
        End Try
    End Function
#End Region

#Region "-----------------------btn_Duong_Dan_Local_Click-----------------------"
    Private Sub btn_Duong_Dan_Local_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Duong_Dan_Local.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            Dim astrFileNames() As String = Directory.GetFiles(FolderBrowserDialog1.SelectedPath)
            Dim strFile As String
            Dim Found As Boolean = False
            For Each strFile In astrFileNames
                If strFile.EndsWith("Ems_Customer.exe") Then
                    Found = True
                End If
            Next
            txt_Duong_Dan_Local.Text = FolderBrowserDialog1.SelectedPath
            lbl_Duong_Dan_Local.Text = txt_Duong_Dan_Local.Text
            myRegistry.Ghi("Duong_Dan_EMS_International", txt_Duong_Dan_Local.Text.Trim)
        End If
    End Sub
#End Region

#Region "-----------------------btn_Duong_Dan_Server_Click-----------------------"
    Private Sub btn_Duong_Dan_Server_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Duong_Dan_Server.Click
        Dim objFolderDialog As New FolderBrowserDialog
        '===== Pass object as Parameter and get Selected network folder
        'txtPath.Text = GetNetworkFolders(objFolderDialog)

        If FolderBrowserDialog2.ShowDialog = DialogResult.OK Then
            Dim astrFileNames() As String = Directory.GetFiles(FolderBrowserDialog2.SelectedPath)
            Dim strFile As String
            Dim Found As Boolean = False
            For Each strFile In astrFileNames
                If strFile.EndsWith("Ems_Customer.exe") Then
                    Found = True
                End If
            Next
            txt_Duong_Dan_Server.Text = FolderBrowserDialog2.SelectedPath
            lbl_Duong_Dan_Server.Text = txt_Duong_Dan_Server.Text
            myRegistry.Ghi("Duong_Dan_Cap_Nhat_Server", txt_Duong_Dan_Server.Text.Trim)
        End If
    End Sub
#End Region

#Region "-----------------------btn_Cap_Nhat_Click-----------------------"
    Private Sub btn_Cap_Nhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cap_Nhat.Click
        Try
            'Kiểm tra đầy đủ thông tin
            If txt_Duong_Dan_Local.Text = "" Then
                MessageBox.Show("Bạn chưa xác định đường dẫn của chương trình!!!", "Thông Báo", MessageBoxButtons.OK)
                txt_Duong_Dan_Local.Focus()
                Exit Sub
            End If

            If txt_Duong_Dan_Server.Text = "" Then
                MessageBox.Show("Bạn chưa xác định đường dẫn của chương trình trên Server!!!", "Thông Báo", MessageBoxButtons.OK)
                txt_Duong_Dan_Server.Focus()
                Exit Sub
            End If

            Dim SourcePath As String
            Dim DestinationPath As String
            DestinationPath = txt_Duong_Dan_Local.Text.Trim
            SourcePath = txt_Duong_Dan_Server.Text.Trim

            'Check Destination Directory
            If Not Directory.Exists(DestinationPath) Then
                MessageBox.Show("Thư mục: " & DestinationPath & " không tồn tại!!!")
                Exit Sub
            End If
            'Check Source Directory
            If Not Directory.Exists(SourcePath) Then
                MessageBox.Show("Thư mục: " & SourcePath & " không tồn tại trên máy chủ!!!")
                Exit Sub
            End If

            'Cập nhật
            Dim Tong_So_File As Integer
            Tong_So_File = System.IO.Directory.GetFiles(SourcePath).Length()

            If MessageBox.Show("Khi cập nhật chương trình sẽ copy đè tất cả các file trùng tên trong thư mục đích!!!" & vbNewLine & _
                                "      Bạn phải đóng chương trình EMS_International trước khi cập nhật!!!" & vbNewLine & _
                                "                      Bạn có muốn tiếp tục không???", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Exit Sub
            End If

            'Copy Directory
            If CopyDirectory(Tong_So_File, SourcePath, DestinationPath, True) Then
                Dim m_Dataset As New DataSet
                m_Dataset = Thong_Tin_Noi_Bo_Danh_Sach()
                Dim Phien_Ban_Server As Double
                Phien_Ban_Server = m_Dataset.Tables(0).Rows(0).Item("Phien_Ban")

                'Cập nhật Registry
                myRegistry.Ghi("Phien_Ban_EMS_International", Phien_Ban_Server.ToString("0.0"))
                myRegistry.Ghi("Ngay_Cap_Nhat_EMS_International", Now.Date.ToString("dd/MM/yyyy"))
                myRegistry.Ghi("Gio_Cap_Nhat_EMS_International", Now.Hour.ToString("00") & ":" & Now.Minute.ToString("00"))
                myRegistry.Ghi("Duong_Dan_EMS_International", DestinationPath)

                'Refresh Form
                Hien_Thi_Thong_Tin()
                If MessageBox.Show("Cập Nhật Thành Công!!!" & vbNewLine & _
                                "Bạn có muốn thoát không???", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    Close()
                    Dispose()
                    Exit Sub
                End If
            Else
                MessageBox.Show("Cập Nhật Lỗi!!!", "Thông Báo", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "--------------------CopyDirectory--------------------"
    Private Function CopyDirectory(ByVal SumaryFiles As Integer, ByVal SourcePath As String, ByVal DestPath As String, Optional ByVal Overwrite As Boolean = False) As Boolean
        Dim SourceDir As DirectoryInfo = New DirectoryInfo(SourcePath)
        Dim DestDir As DirectoryInfo = New DirectoryInfo(DestPath)

        If SourceDir.Exists Then
            ' if destination SubDir's parent SubDir does not exist throw an exception
            If Not DestDir.Parent.Exists Then
                Throw New DirectoryNotFoundException _
                    ("Thư mục đích không tồn tại : " + DestDir.Parent.FullName)
                Return False
            End If

            If Not DestDir.Exists Then
                DestDir.Create()
            End If

            Me.ActiveForm.Cursor.Current = Cursors.WaitCursor
            ProgressBar.Maximum = SumaryFiles
            ProgressBar.Text = "( " & ProgressBar.Value & "  /  " & ProgressBar.Maximum & " )"
            ProgressBar.Step = 1
            ProgressBar.Value = 0

            ' copy all the files of the current directory
            Dim ChildFile As FileInfo
            For Each ChildFile In SourceDir.GetFiles()
                ProgressBar.PerformStep()
                ProgressBar.Text = "( " & ProgressBar.Value & "  /  " & ProgressBar.Maximum & " )"
                Application.DoEvents()
                If ChildFile.Name <> "EMS_Customer_Update.exe" And ChildFile.Name <> "EMS_Customer_Update" Then
                    If Overwrite Then
                        ChildFile.CopyTo(Path.Combine(DestDir.FullName, ChildFile.Name), True)
                    Else
                        If Not File.Exists(Path.Combine(DestDir.FullName, ChildFile.Name)) Then
                            ChildFile.CopyTo(Path.Combine(DestDir.FullName, ChildFile.Name), False)
                        End If
                    End If
                End If
            Next
            ActiveForm.Cursor.Current = Cursors.Default
            ProgressBar.Value = 0
            ProgressBar.Text = ""

            Return True
            'Do not copy all the sub-directories by recursively calling this same routine
            'Dim SubDir As DirectoryInfo
            'For Each SubDir In SourceDir.GetDirectories()
            'CopyDirectory(SubDir.FullName, Path.Combine(DestDir.FullName, _
            '    SubDir.Name), Overwrite)
            'Next
        Else
            Throw New DirectoryNotFoundException("Thư mục nguồn không tồn tại : " + SourceDir.FullName)
            Return False
        End If
    End Function
#End Region

#Region "--------------------Convert Date, Time--------------------"
    Public Shared Function ConvertIntToDate(ByVal myDate As Integer) As Date
        If myDate.ToString.Length <> 8 Then
            Return Now.Date
        End If
        Return Convert.ToDateTime(myDate.ToString.Substring(4, 2) + "/" + myDate.ToString.Substring(6, 2) + "/" + myDate.ToString.Substring(0, 4))
    End Function

    Public Shared Function ConvertIntToTime(ByVal myTime As Integer) As String
        If myTime.ToString.Length = 3 Then
            Return "0" + myTime.ToString.Substring(0, 1) + ":" + myTime.ToString.Substring(1, 2)
        End If
        If myTime.ToString.Length = 4 Then
            Return myTime.ToString.Substring(0, 2) + ":" + myTime.ToString.Substring(2, 2)
        End If
        Return "00:00"
    End Function

    Public Shared Function ConvertTimeToInt(ByVal myTime As String) As Integer
        Return Convert.ToInt32(myTime.Replace(":", ""))
    End Function

    Public Shared Function ConvertDateToInt(ByVal myDate As Date) As Integer
        Return myDate.Year * 10000 + myDate.Month * 100 + myDate.Day
    End Function

#End Region
End Class

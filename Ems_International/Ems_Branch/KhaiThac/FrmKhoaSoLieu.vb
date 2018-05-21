Imports CrystalDecisions.CrystalReports.Engine
Imports Ems_International_Logic.EMS
Imports System.IO
Imports System.IO.File
Imports System.Text
Imports FTP
Imports EASendMail
Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization

#Region "Khoá số liệu"
Public Class FrmKhoaSoLieu
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
    Friend WithEvents LbThong_Tin As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CbMa_Ca As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CbNgay_Kt As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents OptDu_Lieu_Di_Den As System.Windows.Forms.RadioButton
    Friend WithEvents OptDu_Lieu_Di As System.Windows.Forms.RadioButton
    Friend WithEvents OptDu_Lieu_Den As System.Windows.Forms.RadioButton
    Friend WithEvents BtnKhoa_So_Lieu As Infragistics.Win.Misc.UltraButton
    Friend WithEvents BtnMo_Khoa_So_Lieu As Infragistics.Win.Misc.UltraButton
    Friend WithEvents BtnThoat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents PrbTien_Trinh As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    Friend WithEvents lblTien_Trinh As System.Windows.Forms.Label
    Friend WithEvents chkTruyen_EDI As System.Windows.Forms.CheckBox
    Friend WithEvents btnSend_Mail As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmKhoaSoLieu))
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Ca", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ca_Khai_Thac")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thu_Tu")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ca")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.LbThong_Tin = New Infragistics.Win.Misc.UltraLabel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.BtnThoat = New Infragistics.Win.Misc.UltraButton
        Me.BtnMo_Khoa_So_Lieu = New Infragistics.Win.Misc.UltraButton
        Me.BtnKhoa_So_Lieu = New Infragistics.Win.Misc.UltraButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.chkTruyen_EDI = New System.Windows.Forms.CheckBox
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.OptDu_Lieu_Den = New System.Windows.Forms.RadioButton
        Me.OptDu_Lieu_Di = New System.Windows.Forms.RadioButton
        Me.OptDu_Lieu_Di_Den = New System.Windows.Forms.RadioButton
        Me.CbMa_Ca = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.CbNgay_Kt = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.PrbTien_Trinh = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar
        Me.lblTien_Trinh = New System.Windows.Forms.Label
        Me.btnSend_Mail = New Infragistics.Win.Misc.UltraButton
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.CbMa_Ca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbNgay_Kt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbThong_Tin
        '
        Appearance1.FontData.BoldAsString = "True"
        Appearance1.TextHAlign = Infragistics.Win.HAlign.Center
        Me.LbThong_Tin.Appearance = Appearance1
        Me.LbThong_Tin.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.LbThong_Tin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LbThong_Tin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbThong_Tin.Location = New System.Drawing.Point(0, 0)
        Me.LbThong_Tin.Name = "LbThong_Tin"
        Me.LbThong_Tin.Size = New System.Drawing.Size(560, 64)
        Me.LbThong_Tin.TabIndex = 42
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnSend_Mail)
        Me.Panel2.Controls.Add(Me.BtnThoat)
        Me.Panel2.Controls.Add(Me.BtnMo_Khoa_So_Lieu)
        Me.Panel2.Controls.Add(Me.BtnKhoa_So_Lieu)
        Me.Panel2.Location = New System.Drawing.Point(312, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(240, 264)
        Me.Panel2.TabIndex = 47
        '
        'BtnThoat
        '
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.BtnThoat.Appearance = Appearance2
        Me.BtnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnThoat.ImageSize = New System.Drawing.Size(30, 25)
        Me.BtnThoat.Location = New System.Drawing.Point(32, 208)
        Me.BtnThoat.Name = "BtnThoat"
        Me.BtnThoat.Size = New System.Drawing.Size(176, 40)
        Me.BtnThoat.TabIndex = 2
        Me.BtnThoat.Text = "Thoát"
        '
        'BtnMo_Khoa_So_Lieu
        '
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        Me.BtnMo_Khoa_So_Lieu.Appearance = Appearance3
        Me.BtnMo_Khoa_So_Lieu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMo_Khoa_So_Lieu.ImageSize = New System.Drawing.Size(30, 25)
        Me.BtnMo_Khoa_So_Lieu.Location = New System.Drawing.Point(32, 80)
        Me.BtnMo_Khoa_So_Lieu.Name = "BtnMo_Khoa_So_Lieu"
        Me.BtnMo_Khoa_So_Lieu.Size = New System.Drawing.Size(176, 40)
        Me.BtnMo_Khoa_So_Lieu.TabIndex = 1
        Me.BtnMo_Khoa_So_Lieu.Text = "Mở khoá số liệu"
        '
        'BtnKhoa_So_Lieu
        '
        Appearance4.Image = CType(resources.GetObject("Appearance4.Image"), Object)
        Me.BtnKhoa_So_Lieu.Appearance = Appearance4
        Me.BtnKhoa_So_Lieu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKhoa_So_Lieu.ImageSize = New System.Drawing.Size(30, 25)
        Me.BtnKhoa_So_Lieu.Location = New System.Drawing.Point(32, 16)
        Me.BtnKhoa_So_Lieu.Name = "BtnKhoa_So_Lieu"
        Me.BtnKhoa_So_Lieu.Size = New System.Drawing.Size(176, 40)
        Me.BtnKhoa_So_Lieu.TabIndex = 0
        Me.BtnKhoa_So_Lieu.Text = "Khoá số liệu"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.chkTruyen_EDI)
        Me.Panel1.Controls.Add(Me.UltraGroupBox1)
        Me.Panel1.Controls.Add(Me.CbMa_Ca)
        Me.Panel1.Controls.Add(Me.UltraLabel2)
        Me.Panel1.Controls.Add(Me.UltraLabel1)
        Me.Panel1.Controls.Add(Me.CbNgay_Kt)
        Me.Panel1.Location = New System.Drawing.Point(0, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(304, 264)
        Me.Panel1.TabIndex = 48
        '
        'chkTruyen_EDI
        '
        Me.chkTruyen_EDI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTruyen_EDI.Location = New System.Drawing.Point(208, 16)
        Me.chkTruyen_EDI.Name = "chkTruyen_EDI"
        Me.chkTruyen_EDI.Size = New System.Drawing.Size(88, 64)
        Me.chkTruyen_EDI.TabIndex = 52
        Me.chkTruyen_EDI.Text = "Truyền PREDES/  RESDES"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.OptDu_Lieu_Den)
        Me.UltraGroupBox1.Controls.Add(Me.OptDu_Lieu_Di)
        Me.UltraGroupBox1.Controls.Add(Me.OptDu_Lieu_Di_Den)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(8, 88)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(288, 160)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 51
        '
        'OptDu_Lieu_Den
        '
        Me.OptDu_Lieu_Den.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptDu_Lieu_Den.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.OptDu_Lieu_Den.Location = New System.Drawing.Point(32, 120)
        Me.OptDu_Lieu_Den.Name = "OptDu_Lieu_Den"
        Me.OptDu_Lieu_Den.Size = New System.Drawing.Size(192, 24)
        Me.OptDu_Lieu_Den.TabIndex = 3
        Me.OptDu_Lieu_Den.Text = "Toàn bộ dữ liệu XN Đến"
        '
        'OptDu_Lieu_Di
        '
        Me.OptDu_Lieu_Di.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptDu_Lieu_Di.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.OptDu_Lieu_Di.Location = New System.Drawing.Point(32, 68)
        Me.OptDu_Lieu_Di.Name = "OptDu_Lieu_Di"
        Me.OptDu_Lieu_Di.Size = New System.Drawing.Size(192, 24)
        Me.OptDu_Lieu_Di.TabIndex = 2
        Me.OptDu_Lieu_Di.Text = "Toàn bộ dữ liệu đóng Đi"
        '
        'OptDu_Lieu_Di_Den
        '
        Me.OptDu_Lieu_Di_Den.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptDu_Lieu_Di_Den.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.OptDu_Lieu_Di_Den.Location = New System.Drawing.Point(32, 16)
        Me.OptDu_Lieu_Di_Den.Name = "OptDu_Lieu_Di_Den"
        Me.OptDu_Lieu_Di_Den.Size = New System.Drawing.Size(192, 24)
        Me.OptDu_Lieu_Di_Den.TabIndex = 1
        Me.OptDu_Lieu_Di_Den.Text = "Toàn bộ dữ liệu Đi - Đến"
        '
        'CbMa_Ca
        '
        Me.CbMa_Ca.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.Caption = "Bưu cục khai thác"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        Appearance5.FontData.BoldAsString = "True"
        UltraGridColumn3.Header.Appearance = Appearance5
        UltraGridColumn3.Header.Caption = "Ca"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 30
        Appearance6.FontData.BoldAsString = "True"
        Appearance6.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn4.Header.Appearance = Appearance6
        UltraGridColumn4.Header.Caption = "Tên ca"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 70
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        UltraGridBand1.SummaryFooterCaption = "Grand Summaries"
        Me.CbMa_Ca.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance7.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance7.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance7.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance7.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.CbMa_Ca.DisplayLayout.Override.HeaderAppearance = Appearance7
        Me.CbMa_Ca.DisplayMember = "Ca"
        Me.CbMa_Ca.LimitToList = True
        Me.CbMa_Ca.Location = New System.Drawing.Point(104, 56)
        Me.CbMa_Ca.Name = "CbMa_Ca"
        Me.CbMa_Ca.Size = New System.Drawing.Size(88, 21)
        Me.CbMa_Ca.TabIndex = 48
        Me.CbMa_Ca.ValueMember = "Thu_Tu"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UltraLabel2.Location = New System.Drawing.Point(16, 56)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(88, 16)
        Me.UltraLabel2.TabIndex = 50
        Me.UltraLabel2.Text = "Ca kế toán"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UltraLabel1.Location = New System.Drawing.Point(16, 16)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(88, 16)
        Me.UltraLabel1.TabIndex = 49
        Me.UltraLabel1.Text = "Ngày kế toán"
        '
        'CbNgay_Kt
        '
        Me.CbNgay_Kt.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.CbNgay_Kt.Location = New System.Drawing.Point(104, 16)
        Me.CbNgay_Kt.Name = "CbNgay_Kt"
        Me.CbNgay_Kt.Size = New System.Drawing.Size(88, 21)
        Me.CbNgay_Kt.TabIndex = 47
        '
        'PrbTien_Trinh
        '
        Me.PrbTien_Trinh.BorderStyle = Infragistics.Win.UIElementBorderStyle.InsetSoft
        Me.PrbTien_Trinh.Location = New System.Drawing.Point(0, 360)
        Me.PrbTien_Trinh.Maximum = 10000
        Me.PrbTien_Trinh.Name = "PrbTien_Trinh"
        Me.PrbTien_Trinh.Size = New System.Drawing.Size(552, 32)
        Me.PrbTien_Trinh.Step = 1
        Me.PrbTien_Trinh.TabIndex = 67
        Me.PrbTien_Trinh.Text = "[Formatted]"
        '
        'lblTien_Trinh
        '
        Me.lblTien_Trinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTien_Trinh.Location = New System.Drawing.Point(0, 336)
        Me.lblTien_Trinh.Name = "lblTien_Trinh"
        Me.lblTien_Trinh.Size = New System.Drawing.Size(544, 16)
        Me.lblTien_Trinh.TabIndex = 66
        Me.lblTien_Trinh.Text = "Tiến trình thực hiện"
        '
        'btnSend_Mail
        '
        Me.btnSend_Mail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend_Mail.ImageSize = New System.Drawing.Size(30, 25)
        Me.btnSend_Mail.Location = New System.Drawing.Point(31, 144)
        Me.btnSend_Mail.Name = "btnSend_Mail"
        Me.btnSend_Mail.Size = New System.Drawing.Size(176, 40)
        Me.btnSend_Mail.TabIndex = 3
        Me.btnSend_Mail.Text = "Gửi mail số liệu QT đến"
        '
        'FrmKhoaSoLieu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(554, 407)
        Me.Controls.Add(Me.PrbTien_Trinh)
        Me.Controls.Add(Me.lblTien_Trinh)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LbThong_Tin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "FrmKhoaSoLieu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Khoá dữ liệu"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.CbMa_Ca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbNgay_Kt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Khai báo các biến cục bộ trong Form"
    Dim Id_Ca_Ngaycakt As String
    Dim myColumn As Infragistics.Win.UltraWinGrid.UltraGridColumn = Nothing
    Private myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Dim myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Dim myMa_Ca As New Ma_Ca(GConnectionString)
    Dim myham_dung_chung As New Ham_Dung_Chung
    Dim myE2_Den As New E2_Den(GConnectionString)
    Dim myE2_Di As New E2_Di(GConnectionString)
    Dim myE1_Den As New E1_Den(GConnectionString)
    'Dim myEDI As New EDI(GConnectionString)
    Dim myE1_Di As New E1_Di(GConnectionString)
    Dim myKe_Toan_Ca As New Ke_Toan_Ca(GConnectionString)
    Dim myUtility As New Ems_Utility.Ems_Utility.Ems_MSMQ(GConnectionString)
#End Region

#Region "DataGridMa_Ca"
    Private Sub DataGridMa_Ca()
        Try
            CbMa_Ca.DataSource = myMa_Ca.Lay_Boi_Ma_Bc_Khai_Thac(GBuu_Cuc_Khai_Thac)
            CbMa_Ca.DataBind()
            If CbMa_Ca.Rows.Count > 0 Then
                CbMa_Ca.Value = CbMa_Ca.Rows(0).Cells("Thu_Tu").Value
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "BtnThoat_Click"
    Private Sub BtnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnThoat.Click
        Try
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "FrmKhoaSoLieu_Load"
    Private Sub FrmKhoaSoLieu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Text = "Khóa số liệu - " & GTen_Buu_Cuc_Khai_Thac & "(" & GBuu_Cuc_Khai_Thac & ")"
            DataGridMa_Ca()
            Id_Ca_Ngaycakt = GBuu_Cuc_Khai_Thac & myham_dung_chung.ConvertDateToInt(CbNgay_Kt.Value) & CbMa_Ca.Value
            chkTruyen_EDI.Checked = True
            OptDu_Lieu_Di_Den.Checked = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "OptDu_Lieu_Di_Den_CheckedChanged"
    Private Sub OptDu_Lieu_Di_Den_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptDu_Lieu_Di_Den.CheckedChanged
        Try


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Khoa_Du_Lieu_Di_Va_Den"
    Private Sub Khoa_Du_Lieu_Di_Va_Den()
        Try
            'Khoá số liệu đến của ca kế toán
            myE1_Den.Chot_SL_E1_Den(Id_Ca_Ngaycakt, True)
            'Khoá số liệu đi của ca kế toán
            myE1_Den.Chot_SL_E1_Di(Id_Ca_Ngaycakt, True)
            'Khoá số liệu bảng Ke_Toan_Ca
            myKe_Toan_Ca.Chot_SL(Id_Ca_Ngaycakt, True)

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Khoa_Du_Lieu_Di"
    Private Sub Khoa_Du_Lieu_Di()
        Try
            'Khoá số liệu đi của ca kế toán
            myE1_Den.Chot_SL_E1_Di(Id_Ca_Ngaycakt, True)

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Khoa_Du_Lieu_Den"
    Private Sub Khoa_Du_Lieu_Den()
        Try
            'Khoá số liệu đến của ca kế toán
            myE1_Den.Chot_SL_E1_Den(Id_Ca_Ngaycakt, True)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Lay_Du_Lieu_Quoc_Te_Den_Vao_Bang_Huong_Di_Buu_Pham"
    Private Sub Lay_Du_Lieu_Quoc_Te_Den_Vao_Bang_Huong_Di_Buu_Pham(ByVal mId_Ca_Ngaycakt As String)
        Dim mHuong_Di_Buu_Pham_Quoc_Te_Den As New Huong_Di_Buu_Pham_Quoc_Te_Den(GConnectionString)
        Dim idx As Integer
        Dim m_DataSet_Danh_Sach_E1_Quoc_Te_Den As New DataTable
        Dim mId_Chi_Tiet As String
        Try
            'Lay du lieu quoc te den
            m_DataSet_Danh_Sach_E1_Quoc_Te_Den = myE1_Den.E1_Den_Danh_Sach_Quoc_Te_Den_Lay_Boi_Id_Ca(mId_Ca_Ngaycakt).Tables(0)

            'Hien thong tin tren label Tien trinh
            lblTien_Trinh.Text = ".....Đang lọc dữ liệu Quốc tế đến.....(Tổng số: " & m_DataSet_Danh_Sach_E1_Quoc_Te_Den.Rows.Count.ToString & " bưu phẩm)"
            lblTien_Trinh.Refresh()

            'Xu ly Process Bar
            PrbTien_Trinh.Maximum = m_DataSet_Danh_Sach_E1_Quoc_Te_Den.Rows.Count
            PrbTien_Trinh.Step = 1
            PrbTien_Trinh.Value = 0

            'Bat dau duyet va insert vao bang HUONG_DI_BUU_PHAM
            If m_DataSet_Danh_Sach_E1_Quoc_Te_Den.Rows.Count > 0 Then
                Me.ActiveForm.Cursor.Current = Cursors.WaitCursor
                For idx = 0 To m_DataSet_Danh_Sach_E1_Quoc_Te_Den.Rows.Count - 1
                    With m_DataSet_Danh_Sach_E1_Quoc_Te_Den.Rows(idx)
                        mId_Chi_Tiet = Create_Id_Chi_Tiet_Huong_Di_Buu_Pham(.Item("Ma_E1"), mId_Ca_Ngaycakt)
                        mHuong_Di_Buu_Pham_Quoc_Te_Den.Huong_Di_Buu_Pham_Quoc_Te_Den_Cap_Nhat_Them(mId_Chi_Tiet, _
                                                                                                    .Item("Ma_E1"), _
                                                                                                    .Item("Nuoc_Nhan"), _
                                                                                                    .Item("Phan_Loai"), _
                                                                                                    .Item("Khoi_Luong"), _
                                                                                                    .Item("Ngay_Dong"), _
                                                                                                    .Item("Id_E1"), _
                                                                                                    .Item("Ngay_Den"), _
                                                                                                    .Item("Gio_Den"), _
                                                                                                    True, _
                                                                                                    "", 0, 0, False, _
                                                                                                    "", 0, 0, False, "", 0, 0, False, _
                                                                                                    "", 0, 0, False, "", 0, 0, False, _
                                                                                                    "", 0, 0, False, "", 0, 0, False, _
                                                                                                    "", 0, 0, False, "", 0, 0, False, _
                                                                                                    "", 0, 0, False, "", 0, 0, False, _
                                                                                                    "", _
                                                                                                    0, _
                                                                                                    0, _
                                                                                                    0, _
                                                                                                    0, _
                                                                                                    0, _
                                                                                                    0, _
                                                                                                    0)
                    End With
                    'Next process value
                    PrbTien_Trinh.PerformStep()
                    '----------------------------------------
                    'Refresh form
                    Application.DoEvents()
                    '----------------------------------------
                Next
                Me.ActiveForm.Cursor.Current = Cursors.Default
                'Hien thong tin tren label Tien trinh
                lblTien_Trinh.Text = "Đã lọc xong dữ liệu Quốc tế đến !!!"
                lblTien_Trinh.Refresh()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Function Create_Id_Chi_Tiet_Huong_Di_Buu_Pham(ByVal Ma_E1 As String, ByVal Id_Ca As String) As String
        Dim str As String
        str = Id_Ca.Substring(6, 4)
        Return Ma_E1 & str
    End Function
#End Region

#Region "Mo_Khoa_Du_Lieu_Di_Va_Den"
    Private Sub Mo_Khoa_Du_Lieu_Di_Va_Den()
        Try
            'Mở Khoá số liệu đến của ca kế toán
            myE1_Den.Chot_SL_E1_Den(Id_Ca_Ngaycakt, False)
            'Mở Khoá số liệu đi của ca kế toán
            myE1_Den.Chot_SL_E1_Di(Id_Ca_Ngaycakt, False)
            'Mở Khoá số liệu bảng Ke_Toan_Ca
            myKe_Toan_Ca.Chot_SL(Id_Ca_Ngaycakt, False)

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Mo_Khoa_Du_Lieu_Di"
    Private Sub Mo_Khoa_Du_Lieu_Di()
        Try
            'Mở Khoá số liệu đi của ca kế toán
            myE1_Den.Chot_SL_E1_Di(Id_Ca_Ngaycakt, False)

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Mo_Khoa_Du_Lieu_Den"
    Private Sub Mo_Khoa_Du_Lieu_Den()
        Try
            'Mở Khoá số liệu đến của ca kế toán
            myE1_Den.Chot_SL_E1_Den(Id_Ca_Ngaycakt, False)

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "BtnKhoa_So_Lieu_Click"
    Private Sub BtnKhoa_So_Lieu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKhoa_So_Lieu.Click
        Id_Ca_Ngaycakt = GBuu_Cuc_Khai_Thac & myham_dung_chung.ConvertDateToInt(CbNgay_Kt.Value) & CbMa_Ca.Value
        Try
            If MessageBox.Show("Bạn có thực sự muốn khoá số liệu " & CbMa_Ca.Text & " Ngày " & DateTime.Parse(CbNgay_Kt.Value).ToString("dd/MM/yyyy") & " không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                If OptDu_Lieu_Di_Den.Checked = True Then
                    Khoa_Du_Lieu_Di_Va_Den()
                    LbThong_Tin.Text = CbMa_Ca.Text & " Ngày " & DateTime.Parse(CbNgay_Kt.Value).ToString("dd/MM/yyyy") & " đã khoá toàn bộ số liệu Đi và đến"
                    BtnKhoa_So_Lieu.Enabled = False
                    BtnMo_Khoa_So_Lieu.Enabled = True
                    'Nếu là bưu cục khai thác quốc tế đến thì thực hiện tạo dữ liệu Huong_Di_Buu_Pham
                    If (GOutBout = 0) Then
                        Lay_Du_Lieu_Quoc_Te_Den_Vao_Bang_Huong_Di_Buu_Pham(Id_Ca_Ngaycakt)
                        'Gui mail cho A1 danh sach hang den - yeu cau moi ngay 01/01/2013
                        'Tao_Du_Lieu_Hang_Den_Gui_Email(Id_Ca_Ngaycakt)
                    End If
                    If chkTruyen_EDI.Checked Then
                        Danh_Sach_Chuyen_Thu_Can_Truyen_Predes_Trong_Ca(Id_Ca_Ngaycakt)
                        Danh_Sach_Chuyen_Thu_Can_Truyen_Resdes_Trong_Ca(Id_Ca_Ngaycakt)
                    End If
                    Danh_Sach_Chuyen_Thu_Di_Trong_Ca_Can_Truyen(Id_Ca_Ngaycakt)
                    Danh_Sach_Chuyen_Thu_Den_Trong_Ca_Can_Truyen(Id_Ca_Ngaycakt)
                ElseIf OptDu_Lieu_Di.Checked = True Then
                    Khoa_Du_Lieu_Di()
                    LbThong_Tin.Text = CbMa_Ca.Text & " Ngày " & DateTime.Parse(CbNgay_Kt.Value).ToString("dd/MM/yyyy") & " đã khoá số liệu đi"
                    BtnKhoa_So_Lieu.Enabled = False
                    BtnMo_Khoa_So_Lieu.Enabled = True
                    If chkTruyen_EDI.Checked Then
                        Danh_Sach_Chuyen_Thu_Can_Truyen_Predes_Trong_Ca(Id_Ca_Ngaycakt)
                    End If
                    Danh_Sach_Chuyen_Thu_Di_Trong_Ca_Can_Truyen(Id_Ca_Ngaycakt)
                ElseIf OptDu_Lieu_Den.Checked = True Then
                    Khoa_Du_Lieu_Den()
                    LbThong_Tin.Text = CbMa_Ca.Text & " Ngày " & DateTime.Parse(CbNgay_Kt.Value).ToString("dd/MM/yyyy") & " đã khoá số liệu đến"
                    BtnKhoa_So_Lieu.Enabled = False
                    BtnMo_Khoa_So_Lieu.Enabled = True
                    'Nếu là bưu cục khai thác quốc tế đến thì thực hiện tạo dữ liệu Huong_Di_Buu_Pham
                    If (GOutBout = 0) Then
                        Lay_Du_Lieu_Quoc_Te_Den_Vao_Bang_Huong_Di_Buu_Pham(Id_Ca_Ngaycakt)
                    End If
                    '-------------------------------------------------
                    If chkTruyen_EDI.Checked Then
                        Danh_Sach_Chuyen_Thu_Can_Truyen_Resdes_Trong_Ca(Id_Ca_Ngaycakt)
                    End If
                    Danh_Sach_Chuyen_Thu_Den_Trong_Ca_Can_Truyen(Id_Ca_Ngaycakt)
                End If
                'Hien thong tin khi hoan tat                
                lblTien_Trinh.Text = "Quá trình khoá, tạo bản tin và truyền số liệu đã hoàn tất."
                lblTien_Trinh.Refresh()
                '-----------------------------------------------
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "BtnMo_Khoa_So_Lieu_Click"
    Private Sub BtnMo_Khoa_So_Lieu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMo_Khoa_So_Lieu.Click
        Id_Ca_Ngaycakt = GBuu_Cuc_Khai_Thac & myham_dung_chung.ConvertDateToInt(CbNgay_Kt.Value) & CbMa_Ca.Value
        Try
            If MessageBox.Show("Bạn có thực sự muốn mở khoá số liệu " & CbMa_Ca.Text & " Ngày " & DateTime.Parse(CbNgay_Kt.Value).ToString("dd/MM/yyyy") & " không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                If OptDu_Lieu_Di_Den.Checked = True Then
                    Mo_Khoa_Du_Lieu_Di_Va_Den()
                    LbThong_Tin.Text = CbMa_Ca.Text & " Ngày " & DateTime.Parse(CbNgay_Kt.Value).ToString("dd/MM/yyyy") & vbNewLine & " đã mở khoá toàn bộ số liệu Đi và đến"
                    BtnKhoa_So_Lieu.Enabled = True
                    BtnMo_Khoa_So_Lieu.Enabled = False
                ElseIf OptDu_Lieu_Di.Checked = True Then
                    Mo_Khoa_Du_Lieu_Di()
                    LbThong_Tin.Text = CbMa_Ca.Text & " Ngày " & DateTime.Parse(CbNgay_Kt.Value).ToString("dd/MM/yyyy") & vbNewLine & " đã mở khoá số liệu đi"
                    BtnKhoa_So_Lieu.Enabled = True
                    BtnMo_Khoa_So_Lieu.Enabled = False
                ElseIf OptDu_Lieu_Den.Checked = True Then
                    Mo_Khoa_Du_Lieu_Den()
                    LbThong_Tin.Text = CbMa_Ca.Text & " Ngày " & DateTime.Parse(CbNgay_Kt.Value).ToString("dd/MM/yyyy") & vbNewLine & " đã mở khoá số liệu đến"
                    BtnKhoa_So_Lieu.Enabled = True
                    BtnMo_Khoa_So_Lieu.Enabled = False
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "CbMa_Ca_ValueChanged"
    Private Sub CbMa_Ca_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbMa_Ca.ValueChanged
        Try
            Id_Ca_Ngaycakt = GBuu_Cuc_Khai_Thac & myham_dung_chung.ConvertDateToInt(CbNgay_Kt.Value) & CbMa_Ca.Value
            If myE1_Den.Lay_Boi_Ca_San_Xuat(Id_Ca_Ngaycakt).Tables(0).Rows.Count > 0 Then
                Dim m_Tong_So_Den_Da_Chot_SL As Integer
                Dim m_Tong_So_Di_Da_Chot_SL As Integer
                m_Tong_So_Den_Da_Chot_SL = myE1_Den.Kiem_Tra_E1_Den_Da_Chot_SL_Chua(Id_Ca_Ngaycakt)
                m_Tong_So_Di_Da_Chot_SL = myE1_Den.Kiem_Tra_E1_Di_Da_Chot_SL_Chua(Id_Ca_Ngaycakt)
                'm_Tong_So_Den_Da_Chot_SL = myE1_Den.Kiem_Tra_E1_Den_Da_Chot_SL_Chua(Id_Ca_Ngaycakt)
                'Lay_Boi_Ca_San_Xuat()
                If m_Tong_So_Den_Da_Chot_SL > 0 And m_Tong_So_Di_Da_Chot_SL > 0 Then
                    LbThong_Tin.Text = CbMa_Ca.Text & " Ngày " & DateTime.Parse(CbNgay_Kt.Value).ToString("dd/MM/yyyy") & vbNewLine & " đã chốt toàn bộ số liệu Đi và đến"
                    BtnKhoa_So_Lieu.Enabled = False
                    BtnMo_Khoa_So_Lieu.Enabled = True
                ElseIf m_Tong_So_Den_Da_Chot_SL > 0 And m_Tong_So_Di_Da_Chot_SL = 0 Then
                    LbThong_Tin.Text = CbMa_Ca.Text & " Ngày " & DateTime.Parse(CbNgay_Kt.Value).ToString("dd/MM/yyyy") & vbNewLine & " đã chốt số liệu Đến" & vbNewLine & "nhưng chưa chốt số liệu Đi"
                    BtnKhoa_So_Lieu.Enabled = True
                    BtnMo_Khoa_So_Lieu.Enabled = True
                ElseIf m_Tong_So_Den_Da_Chot_SL > 0 And m_Tong_So_Di_Da_Chot_SL = 0 Then
                    LbThong_Tin.Text = CbMa_Ca.Text & " Ngày " & DateTime.Parse(CbNgay_Kt.Value).ToString("dd/MM/yyyy") & vbNewLine & " đã chốt số liệu Đi" & vbNewLine & "nhưng chưa chốt số liệu Đến"
                    BtnKhoa_So_Lieu.Enabled = True
                    BtnMo_Khoa_So_Lieu.Enabled = True
                Else
                    LbThong_Tin.Text = CbMa_Ca.Text & " Ngày " & DateTime.Parse(CbNgay_Kt.Value).ToString("dd/MM/yyyy") & vbNewLine & " chưa chốt số liệu đi đến"
                    BtnKhoa_So_Lieu.Enabled = True
                    BtnMo_Khoa_So_Lieu.Enabled = False
                End If
            Else
                LbThong_Tin.Text = CbMa_Ca.Text & " Ngày " & DateTime.Parse(CbNgay_Kt.Value).ToString("dd/MM/yyyy") & vbNewLine & " Hiện chưa có dữ liệu"
                BtnKhoa_So_Lieu.Enabled = False
                BtnMo_Khoa_So_Lieu.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "FrmKhoaSoLieu_KeyPress"
    Private Sub FrmKhoaSoLieu_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "CbNgay_Kt_ValueChanged"
    Private Sub CbNgay_Kt_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbNgay_Kt.ValueChanged
        Try
            CbMa_Ca_ValueChanged(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "==========Tạo bản tin Predes - Resdes và gửi lên server=========="
    Private isConnectedFtp As Boolean = False
    Private isConnectedOra As Boolean = False
    Private isConnectedSQL As Boolean = False
    Private myPredes As New Predes(GConnectionString)
    Private myEDI As New EDI(GConnectionString)
    Private myChuyen_Thu_Di As New Chuyen_Thu_Di(GConnectionString)
    Private myResdes As New Resdes(GConnectionString)
    Private myChuyen_Thu_Den As New Chuyen_Thu_Den(GConnectionString)
    Private myEdi_MailBox As New EDI_mailbox(GConnectionString)

#Region "Danh_Sach_Chuyen_Thu_Di_Trong_Ca"
    Private Function Danh_Sach_Chuyen_Thu_Can_Truyen_Predes_Trong_Ca(ByVal Id_Ca As String) As Boolean
        'Lấy ra danh sách các chuyến thư đã được đóng F trong ca để tạo bản tin Predes
        Try
            'Hien thong tin tren label Tien trinh
            lblTien_Trinh.Text = ".....Đang tạo dữ liệu PREDES......."
            lblTien_Trinh.Refresh()
            '--------------------------------------------
            Dim m_Ca_San_Xuat As New Ca_San_Xuat(GConnectionString)
            Dim m_Ca_San_Xuat_Chi_Tiet As New Ca_San_Xuat_Chi_Tiet

            Dim m_Predes As New Predes(GConnectionString)
            Dim idx As Integer
            'Tạo bản tin Predes
            Dim m_DataSet_Danh_Sach_Chuyen_Thu As New DataSet
            m_DataSet_Danh_Sach_Chuyen_Thu = myChuyen_Thu_Di.Danh_Sach_Chuyen_Thu_Da_Dong_F_Theo_Ca(Id_Ca)
            'Xu ly Process Bar
            PrbTien_Trinh.Maximum = m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows.Count
            PrbTien_Trinh.Step = 1
            PrbTien_Trinh.Value = 0
            '----------------------------------------
            If m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows.Count > 0 Then
                For idx = 0 To m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows.Count - 1
                    'Khong tao Predes cho duong thu JNE
                    If m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows(idx).Item("Id_Duong_Thu") <> "01009152490230" And m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows(idx).Item("Id_Duong_Thu") <> "07009152490230" Then
                        Dim m_Id_Chuyen_Thu As String
                        m_Id_Chuyen_Thu = m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows(idx).Item("Id_Chuyen_Thu")

                        'Hien thong tin tren label Tien trinh
                        lblTien_Trinh.Text = ".....Đang tạo dữ liệu PREDES.....Id_Chuyen_Thu :   " & m_Id_Chuyen_Thu
                        lblTien_Trinh.Refresh()

                        'Dim m_EDI_detail As EDI_detail

                        If myEDI.Get_EDI(m_Id_Chuyen_Thu).ID_DUONG_THU = "" Then 'Chưa tạo Predes
                            Predes(m_Id_Chuyen_Thu)
                        End If
                    End If
                    'Next process value
                    PrbTien_Trinh.PerformStep()
                    '----------------------------------------
                    'Refresh form
                    Application.DoEvents()
                    '----------------------------------------
                Next
            End If
            'Hien thong tin tren label Tien trinh
            lblTien_Trinh.Text = "Đã tạo xong PREDES.......Đang gửi File Predes lên FTP Server......"
            lblTien_Trinh.Refresh()
            '--------------------------------------------
            'Connect FTP Server
            Dim ftpUp As New FTP.FTPLib.FTP
            'Lấy dữ liệu trong bảng
            Dim m_FTP_Table As New FTP_Table(GConnectionString)
            Dim m_FTP_Table_Chi_Tiet As New FTP_Table_Chi_Tiet
            m_FTP_Table_Chi_Tiet = m_FTP_Table.FTP_Lay_Dong_Dau_Tien

            Dim Ftp_Server As String = m_FTP_Table_Chi_Tiet.SERVER '"192.168.68.9"
            Dim Ftp_Username As String = m_FTP_Table_Chi_Tiet.USERNAME ' "ems"
            Dim Ftp_Password As String = m_FTP_Table_Chi_Tiet.PASSWORD ' "ems"
            Dim Ftp_Upload As String = m_FTP_Table_Chi_Tiet.UPLOAD

            Try
                ftpUp.Connect(Ftp_Server, Ftp_Username, Ftp_Password)
                ftpUp.ChangeDir("\\" + Ftp_Upload)
                isConnectedFtp = True
            Catch ex As Exception
                MessageBox.Show("Kết nối không thành công. Chi tiết: " & ex.Message)
            End Try

            'Lấy ngày khai thác làm thư mục để Move dữ liệu
            Dim m_Folder_Ngay_Khai_Thac As String = m_Ca_San_Xuat.Lay(Id_Ca).Ngay_Khai_Thac.ToString
            'Tạo Folder mới để chứa dữ liệu của ngày khai thác
            Dim m_Source_Path As String = Application.StartupPath & "\PREDES\"
            If Directory.Exists(m_Source_Path) = False Then
                Directory.CreateDirectory(m_Source_Path)
            End If
            'Create Destination_Path
            Dim m_Destination_Path As String = Application.StartupPath & "\PREDES\" & m_Folder_Ngay_Khai_Thac
            If Directory.Exists(m_Destination_Path) = False Then
                Directory.CreateDirectory(m_Destination_Path)
            End If

            'Lấy danh sách các File bản tin đã được tạo ra trên máy và chưa được gửi đi
            Dim m_Predes_UnSending As DataSet = m_Predes.Danh_Sach_Predes_UnSending()
            'Xu ly Process Bar
            PrbTien_Trinh.Maximum = m_Predes_UnSending.Tables(0).Rows.Count
            PrbTien_Trinh.Step = 1
            PrbTien_Trinh.Value = 0
            '----------------------------------------
            If m_Predes_UnSending.Tables(0).Rows.Count > 0 Then
                For idx = 0 To m_Predes_UnSending.Tables(0).Rows.Count - 1
                    Dim File_Name As String = m_Predes_UnSending.Tables(0).Rows(idx).Item("MESSAGE")
                    Dim StrSrcFile As String = m_Source_Path & File_Name
                    'Dim filename As String = myPredes_Unsending.Tables(0).Rows(idx).Item("PREDES")
                    'Dim StrSrcFile As String
                    StrSrcFile = m_Source_Path & "\" & File_Name

                    If File.Exists(StrSrcFile) Then
                        Dim sFileName As String = Path.GetFileName(StrSrcFile)
                        ftpUp.OpenUpload(StrSrcFile, sFileName)
                        While (ftpUp.DoUpload() > 0) 'Upload thành công, upload toàn bộ dữ liệu
                            'Refresh form
                            Application.DoEvents()
                            '----------------------------------------
                        End While
                        'Đẩy dữ liệu thành công thì Move file vào thư mục của ngày hôm trước
                        If Move_File(File_Name, m_Source_Path, m_Destination_Path) = False Then
                            Return False
                        Else
                            'Cập nhật đã truyền đối với chuyến thư
                            Dim m_Id_Chuyen_Thu As String = m_Predes_UnSending.Tables(0).Rows(idx).Item("ID_CHUYEN_THU")
                            Dim m_Id_Duong_Thu As String = m_Predes_UnSending.Tables(0).Rows(idx).Item("ID_DUONG_THU")
                            Dim m_Intref As String = m_Predes_UnSending.Tables(0).Rows(idx).Item("INTREF")
                            Dim m_Ngay As Integer = CInt(m_Predes_UnSending.Tables(0).Rows(idx).Item("NGAY"))
                            Dim m_Gio As Integer = CInt(m_Predes_UnSending.Tables(0).Rows(idx).Item("GIO"))
                            'Update Send = 1
                            m_Predes.PREDES_Cap_Nhat_Them(m_Id_Chuyen_Thu, m_Id_Duong_Thu, m_Intref, m_Ngay, m_Gio, File_Name, 1)
                        End If
                    End If
                    'Next process value
                    PrbTien_Trinh.PerformStep()
                    '----------------------------------------
                    'Refresh form
                    Application.DoEvents()
                    '----------------------------------------
                Next
            End If
            'Hien thong tin tren label Tien trinh
            lblTien_Trinh.Text = "Đã gửi hết các File PREDES......"
            lblTien_Trinh.Refresh()
            '--------------------------------------------
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Function
#End Region

#Region "Danh_Sach_Chuyen_Thu_Den_Trong_Ca"
    Private Function Danh_Sach_Chuyen_Thu_Can_Truyen_Resdes_Trong_Ca(ByVal Id_Ca As String) As Boolean
        'Lấy ra danh sách các chuyến thư đã được đóng F trong ca để tạo bản tin Predes
        Try
            'Hien thong tin tren label Tien trinh
            lblTien_Trinh.Text = ".....Đang tạo dữ liệu RESDES......."
            lblTien_Trinh.Refresh()
            '--------------------------------------------
            Dim m_Ca_San_Xuat As New Ca_San_Xuat(GConnectionString)
            Dim m_Ca_San_Xuat_Chi_Tiet As New Ca_San_Xuat_Chi_Tiet

            Dim m_Resdes As New Resdes(GConnectionString)
            Dim idx As Integer
            'Tạo bản tin Predes
            Dim m_DataSet_Danh_Sach_Chuyen_Thu As New DataSet
            m_DataSet_Danh_Sach_Chuyen_Thu = myChuyen_Thu_Den.Danh_Sach_Chuyen_Thu_Den_Theo_Ca(Id_Ca)
            'Xu ly Process Bar
            PrbTien_Trinh.Maximum = m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows.Count
            PrbTien_Trinh.Step = 1
            PrbTien_Trinh.Value = 0
            '----------------------------------------
            If m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows.Count > 0 Then
                For idx = 0 To m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows.Count - 1
                    Dim m_Id_Chuyen_Thu As String
                    m_Id_Chuyen_Thu = m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows(idx).Item("Id_Chuyen_Thu")

                    'Hien thong tin tren label Tien trinh
                    lblTien_Trinh.Text = ".....Đang tạo dữ liệu RESDES.....Id_Chuyen_Thu :   " & m_Id_Chuyen_Thu
                    lblTien_Trinh.Refresh()

                    'If m_Resdes.res.PREDES_Lay(m_Id_Chuyen_Thu).ID_DUONG_THU = "" Then 'Chưa tạo Predes
                    Resdes(m_Id_Chuyen_Thu)
                    'End If
                    'Next process value
                    PrbTien_Trinh.PerformStep()
                    '----------------------------------------
                    'Refresh form
                    Application.DoEvents()
                    '----------------------------------------
                Next
            End If
            'Hien thong tin tren label Tien trinh
            lblTien_Trinh.Text = "Đã tạo xong RESDES.......Đang gửi File Resdes lên FTP Server......"
            lblTien_Trinh.Refresh()
            '--------------------------------------------
            'Connect FTP Server
            Dim ftpUp As New FTP.FTPLib.FTP
            'Lấy dữ liệu trong bảng
            Dim m_FTP_Table As New FTP_Table(GConnectionString)
            Dim m_FTP_Table_Chi_Tiet As New FTP_Table_Chi_Tiet
            m_FTP_Table_Chi_Tiet = m_FTP_Table.FTP_Lay_Dong_Dau_Tien

            Dim Ftp_Server As String = m_FTP_Table_Chi_Tiet.SERVER '"192.168.68.9"
            Dim Ftp_Username As String = m_FTP_Table_Chi_Tiet.USERNAME ' "ems"
            Dim Ftp_Password As String = m_FTP_Table_Chi_Tiet.PASSWORD ' "ems"
            Dim Ftp_Upload As String = m_FTP_Table_Chi_Tiet.UPLOAD

            Try
                ftpUp.Connect(Ftp_Server, Ftp_Username, Ftp_Password)
                ftpUp.ChangeDir("\\" + Ftp_Upload)
                isConnectedFtp = True
            Catch ex As Exception
                MessageBox.Show("Kết nối không thành công. Chi tiết: " & ex.Message)
            End Try

            'Lấy ngày khai thác làm thư mục để Move dữ liệu
            Dim m_Folder_Ngay_Khai_Thac As String = m_Ca_San_Xuat.Lay(Id_Ca).Ngay_Khai_Thac.ToString
            'Tạo Folder mới để chứa dữ liệu của ngày khai thác
            Dim m_Source_Path As String = Application.StartupPath & "\RESDES\"
            If Directory.Exists(m_Source_Path) = False Then
                Directory.CreateDirectory(m_Source_Path)
            End If
            'Create Destination_Path
            Dim m_Destination_Path As String = Application.StartupPath & "\RESDES\" & m_Folder_Ngay_Khai_Thac
            If Directory.Exists(m_Destination_Path) = False Then
                Directory.CreateDirectory(m_Destination_Path)
            End If

            'Lấy danh sách các File bản tin đã được tạo ra trên máy và chưa được gửi đi
            Dim m_Resdes_UnSending As DataSet = m_Resdes.Danh_Sach_Resdes_UnSending()
            'Xu ly Process Bar
            PrbTien_Trinh.Maximum = m_Resdes_UnSending.Tables(0).Rows.Count
            PrbTien_Trinh.Step = 1
            PrbTien_Trinh.Value = 0
            '----------------------------------------
            If m_Resdes_UnSending.Tables(0).Rows.Count > 0 Then
                For idx = 0 To m_Resdes_UnSending.Tables(0).Rows.Count - 1
                    Dim File_Name As String = m_Resdes_UnSending.Tables(0).Rows(idx).Item("MESSAGE")
                    Dim StrSrcFile As String = m_Source_Path & File_Name
                    'Dim filename As String = myPredes_Unsending.Tables(0).Rows(idx).Item("PREDES")
                    'Dim StrSrcFile As String
                    StrSrcFile = m_Source_Path & "\" & File_Name

                    If File.Exists(StrSrcFile) Then
                        Dim sFileName As String = Path.GetFileName(StrSrcFile)
                        ftpUp.OpenUpload(StrSrcFile, sFileName)
                        While (ftpUp.DoUpload() > 0) 'Upload thành công, upload toàn bộ dữ liệu
                            'Refresh form
                            Application.DoEvents()
                            '----------------------------------------
                        End While
                        'Đẩy dữ liệu thành công thì Move file vào thư mục của ngày hôm trước
                        If Move_File(File_Name, m_Source_Path, m_Destination_Path) = False Then
                            Return False
                        Else
                            'Cập nhật đã truyền đối với chuyến thư
                            Dim m_Id_Chuyen_Thu As String = m_Resdes_UnSending.Tables(0).Rows(idx).Item("ID_CHUYEN_THU")
                            Dim m_Id_Duong_Thu As String = m_Resdes_UnSending.Tables(0).Rows(idx).Item("ID_DUONG_THU")
                            Dim m_Intref As String = m_Resdes_UnSending.Tables(0).Rows(idx).Item("INTREF")
                            Dim m_Ngay As Integer = CInt(m_Resdes_UnSending.Tables(0).Rows(idx).Item("NGAY"))
                            Dim m_Gio As Integer = CInt(m_Resdes_UnSending.Tables(0).Rows(idx).Item("GIO"))
                            'Update Send = 1
                            m_Resdes.RESDES_Cap_Nhat_Them(m_Id_Chuyen_Thu, m_Id_Duong_Thu, m_Intref, m_Ngay, m_Gio, File_Name, 1)
                        End If
                    End If
                    'Next process value
                    PrbTien_Trinh.PerformStep()
                    '----------------------------------------
                    'Refresh form
                    Application.DoEvents()
                    '----------------------------------------
                Next
            End If
            'Hien thong tin tren label Tien trinh
            lblTien_Trinh.Text = "Đã gửi hết các File RESDES......"
            lblTien_Trinh.Refresh()
            '--------------------------------------------
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Function
#End Region

#Region "Tạo bản tin Predes cho từng chuyến thư"
    Private Function Resdes(ByVal Id_Chuyen_Thu As String) As Boolean
        Try
            Dim Chuyen_Thu_Den_Chi_Tiet As New Chuyen_Thu_Den_Chi_Tiet
            Chuyen_Thu_Den_Chi_Tiet = myChuyen_Thu_Den.Lay(Id_Chuyen_Thu)
            'If myResdes.RESDES_Lay(Id_Chuyen_Thu).ID_DUONG_THU <> "" Then 'Đã tạo Predes
            '    'Nếu đã có thì không tạo lại
            '    Exit Function
            'End If

            'Lay nước đóng chuyến thư và IPMC theo id_duong_thu

            Dim sb As System.Text.StringBuilder = New StringBuilder
            Dim myIPMC_MaNC As New IPMC_MaNC
            myIPMC_MaNC = myEdi_MailBox.Get_IPMC_MaNC(Chuyen_Thu_Den_Chi_Tiet.Id_Duong_Thu, "RESDES")

            'Xác định xem nứơc đó có thực hiện việc trao đổi thông tin chuyến thư hay ko.
            Dim myMailBox As New MailBox
            myMailBox = myEdi_MailBox.Get_MailBox(myIPMC_MaNC.Ma_NC)
            'If (myEDI_MAILBOX.EVENT_SEND = 1) Then

            'End If

            If (myMailBox.RESDES_SEND = 1) Then
                Dim myResdes_UNB As New Resdes_UNB
                myResdes_UNB = myResdes.Get_UNB(myMailBox, myMailBox.RESDES_INTREF)
                Dim segs_number As Int32
                'UNB
                'ghi file UNB
                sb.Append("UNB+")
                sb.Append(myResdes_UNB.UNB_S001.ToString())
                sb.Append("+")
                sb.Append(myResdes_UNB.UNB_S002.ToString())
                sb.Append("+")
                sb.Append(myResdes_UNB.UNB_S003.ToString())
                sb.Append("+")
                sb.Append(myResdes_UNB.UNB_S004.ToString())
                sb.Append("+")
                sb.Append(myResdes_UNB.UNB_S005.ToString())
                sb.Append("'")
                segs_number = 1

                'UNH
                Dim myResdes_UNH As New Resdes_UNH
                myResdes_UNH = myResdes.Get_UNH()

                'ghi file UNH
                sb.Append("UNH+")
                sb.Append(myResdes_UNH.UNH_0062.ToString())
                sb.Append("+")
                sb.Append(myResdes_UNH.UNH_S009.ToString())
                sb.Append("'")
                segs_number = segs_number + 1

                'Dispath Information
                Dim myResdes_Dis_Inf As New Resdes_Dispatch_Information
                myResdes_Dis_Inf = myResdes.Get_Resdes_Dispatch_Information(Chuyen_Thu_Den_Chi_Tiet.Id_Chuyen_Thu, myEdi_MailBox)

                'BGM
                Dim myResdes_BGM As New Resdes_BGM
                myResdes_BGM = myResdes.Get_BGM(myResdes_Dis_Inf.Ma_BC_KT, myResdes_Dis_Inf.Ma_BC, myResdes_Dis_Inf.Phan_loai, myResdes_Dis_Inf.Ngay_dong, myResdes_Dis_Inf.So_Chuyen_thu)
                'ghi file BGM
                sb.Append("BGM+")
                sb.Append(myResdes_BGM.BGM_C002.ToString())
                sb.Append("+")
                sb.Append(myResdes_BGM.BGM_1004.ToString())

                If myResdes_BGM.BGM_C507.ToString() <> "" Then
                    sb.Append("+")
                    sb.Append(myResdes_BGM.BGM_C507.ToString())
                End If
                If myResdes_BGM.BGM_1225.ToString() <> "" Then
                    sb.Append("+")
                    sb.Append(myResdes_BGM.BGM_1225.ToString())
                End If
                If myResdes_BGM.BGM_C506.ToString() <> "" Then
                    sb.Append("+")
                    sb.Append(myResdes_BGM.BGM_C506.ToString())
                End If
                If myResdes_BGM.BGM_C507.ToString() <> "" Then
                    sb.Append("+")
                    sb.Append(myResdes_BGM.BGM_C507.ToString())
                End If
                If myResdes_BGM.BGM_4343.ToString() <> "" Then
                    sb.Append("+")
                    sb.Append(myResdes_BGM.BGM_4343.ToString())
                End If
                sb.Append("'")
                segs_number = segs_number + 1

                'PCI(+++CW) : JPKIXAVNSGNBAEM93122001000066() '
                'RFF+ACU:20'
                'DTM+7:0904230957:201'
                Dim m_DataSet_Danh_Sach_E2 As New DataSet
                m_DataSet_Danh_Sach_E2 = myE2_Den.Lay_Boi_Chuyen_Thu_Den(Id_Chuyen_Thu)
                Dim idx As Integer
                For idx = 0 To m_DataSet_Danh_Sach_E2.Tables(0).Rows.Count - 1
                    'GID
                    Dim myResdes_GID As New Resdes_GID
                    myResdes_GID = myResdes.Get_GID()
                    sb.Append("GID+")
                    sb.Append(myResdes_GID.GID_1496.ToString())
                    sb.Append("+")
                    sb.Append(myResdes_GID.GID_C213.ToString())
                    sb.Append("'")
                    segs_number = segs_number + 1

                    Dim myResdes_PCI As New Resdes_PCI
                    'Lay thong tin ma vach tui
                    Dim myE2_Den_Ma_Vach_Tui As New E2_Den_Ma_Vach_Tui(GConnectionString)
                    Dim strMaSoTui As String = myE2_Den_Ma_Vach_Tui.E2_Den_Ma_Vach_Tui_Lay(m_DataSet_Danh_Sach_E2.Tables(0).Rows(idx).Item("Id_E2")).Ma_Vach_Tui
                    '---------------------------------------------------
                    myResdes_PCI = myResdes.Get_PCI(myResdes_Dis_Inf.So_Chuyen_thu, m_DataSet_Danh_Sach_E2.Tables(0).Rows(idx).Item("Tui_so"), m_DataSet_Danh_Sach_E2.Tables(0).Rows(idx).Item("Khoi_Luong_BP"), m_DataSet_Danh_Sach_E2.Tables(0).Rows(idx).Item("Khoi_Luong_Vo_Tui"), myResdes_Dis_Inf.Ma_BC_KT.ToString(), myResdes_Dis_Inf.Ma_BC.ToString(), myResdes_Dis_Inf.Phan_loai, m_DataSet_Danh_Sach_E2.Tables(0).Rows(idx).Item("Ngay_dong"), m_DataSet_Danh_Sach_E2.Tables(0).Rows(idx).Item("Tui_F"), myIPMC_MaNC.Ma_NC.ToString(), strMaSoTui.Trim())
                    sb.Append("PCI+")
                    sb.Append(myResdes_PCI.PCI_4233.ToString())
                    sb.Append("+")
                    sb.Append(myResdes_PCI.PCI_C210.ToString())
                    sb.Append("+")
                    sb.Append(myResdes_PCI.PCI_C506.ToString())
                    sb.Append("'")
                    segs_number = segs_number + 1

                    sb.Append("RFF+ACU:20")
                    sb.Append("'")
                    segs_number = segs_number + 1

                    'DTM
                    Dim myResdes_DTM As New Resdes_DTM
                    myResdes_DTM = myResdes.Get_DTM(myResdes_Dis_Inf.Ngay_dong, myResdes_Dis_Inf.Gio_dong)

                    'ghi file DTM
                    sb.Append("DTM+")
                    sb.Append(myResdes_DTM.DTM_C507.ToString())
                    sb.Append("'")
                    segs_number = segs_number + 1
                Next

                Dim myResdes_UNT As Resdes_UNT
                myResdes_UNT = myResdes.Get_UNT(segs_number, myResdes_UNH.UNH_0062)
                sb.Append("UNT+")
                sb.Append(myResdes_UNT.UNT_0074.ToString())
                sb.Append("+")
                sb.Append(myResdes_UNT.UNT_0062.ToString())
                sb.Append("'")

                Dim myResdes_UNZ As Resdes_UNZ
                myResdes_UNZ = myResdes.Get_UNZ(myResdes_UNB.UNB_S005)
                sb.Append("UNZ+")
                sb.Append(myResdes_UNZ.UNZ_0036.ToString())
                sb.Append("+")
                sb.Append(myResdes_UNZ.UNZ_0020.ToString())
                sb.Append("'")

                'Dim file_name As String = Id_Chuyen_Thu.Trim.PadRight(2) & "_" & myIPMC_MaNC.Ma_NC.ToString().Trim() & "_RESDES_" & myResdes_UNZ.UNZ_0020.ToString() & ".txt"

                Dim file_name As String
                If Id_Chuyen_Thu.IndexOf("CN") > 0 Then
                    file_name = myIPMC_MaNC.Ma_NC.ToString().Trim() & "_RESCPS_" & myResdes_UNZ.UNZ_0020.ToString() & ".txt"
                Else
                    file_name = myIPMC_MaNC.Ma_NC.ToString().Trim() & "_RESDES_" & myResdes_UNZ.UNZ_0020.ToString() & ".txt"
                End If

                Dim path_resdes_dir As String = Application.StartupPath & "\RESDES"
                Dim path_name As String = Application.StartupPath & "\RESDES\" & file_name
                Dim objStreamWriter As StreamWriter
                If Directory.Exists(path_resdes_dir) = False Then
                    Directory.CreateDirectory(path_resdes_dir)
                End If
                objStreamWriter = New StreamWriter(path_name, True, Encoding.ASCII)

                'objStreamWriter = File.AppendText(file_name)

                objStreamWriter.Write(sb.ToString())
                objStreamWriter.Close()
                myEdi_MailBox.Update_EDI_Intref(myIPMC_MaNC.Ma_NC.ToString(), "RESDES")

                myEDI.Add_EDI(Id_Chuyen_Thu, Chuyen_Thu_Den_Chi_Tiet.Id_Duong_Thu, myResdes_UNB.UNB_S005, Int32.Parse(myResdes_UNB.UNB_0017), Int32.Parse(myResdes_UNB.UNB_0019), file_name, "RESDES")

            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        End Try
    End Function
#End Region

#Region "Tạo bản tin Predes cho từng chuyến thư"
    Private Function Predes(ByVal Id_Chuyen_Thu As String) As Boolean
        Try
            Dim Chuyen_Thu_Di_Chi_Tiet As New Chuyen_Thu_Di_Chi_Tiet
            Chuyen_Thu_Di_Chi_Tiet = myChuyen_Thu_Di.Lay(Id_Chuyen_Thu)

            'Tao PREDES - DO TIEN VIET.
            'Kiểm tra xem Predes đã được tạo ra chưa
            'If myPredes.PREDES_Lay(Id_Chuyen_Thu).ID_DUONG_THU <> "" Then 'Đã tạo Predes
            '    'Nếu đã có thì không tạo lại
            '    Exit Function
            'End If

            'Lay nước đóng chuyến thư và IPMC theo id_duong_thu

            Dim sb As System.Text.StringBuilder = New StringBuilder
            Dim myIPMC_MaNC As New IPMC_MaNC
            myIPMC_MaNC = myEdi_MailBox.Get_IPMC_MaNC(Chuyen_Thu_Di_Chi_Tiet.Id_Duong_Thu, "PREDES")

            'Xác định xem nứơc đó có thực hiện việc trao đổi thông tin chuyến thư hay ko.
            Dim myMailBox As New MailBox
            myMailBox = myEdi_MailBox.Get_MailBox(myIPMC_MaNC.Ma_NC)
            'If (myEDI_MAILBOX.EVENT_SEND = 1) Then

            'End If

            If (myMailBox.PREDES_SEND = 1) Then
                'Tao Predes
                'UNB
                Dim myPredes_UNB As New Predes_UNB
                myPredes_UNB = myPredes.Get_UNB(myMailBox, myMailBox.PREDES_INTREF)

                Dim segs_number As Int32
                'UNB
                'ghi file UNB
                sb.Append("UNB+")
                sb.Append(myPredes_UNB.UNB_S001.ToString())
                sb.Append("+")
                sb.Append(myPredes_UNB.UNB_S002.ToString())
                sb.Append("+")
                sb.Append(myPredes_UNB.UNB_S003.ToString())
                sb.Append("+")
                sb.Append(myPredes_UNB.UNB_S004.ToString())
                sb.Append("+")
                sb.Append(myPredes_UNB.UNB_S005.ToString())
                sb.Append("'")
                segs_number = 1

                'UNH
                Dim myPredes_UNH As New Predes_UNH
                myPredes_UNH = myPredes.Get_UNH()

                'ghi file UNH
                sb.Append("UNH+")
                sb.Append(myPredes_UNH.UNH_0062.ToString())
                sb.Append("+")
                sb.Append(myPredes_UNH.UNH_S009.ToString())
                sb.Append("'")
                segs_number = segs_number + 1

                'Dispath Information
                Dim myPredes_Dispatch_Information As New Predes_Dispatch_Information
                myPredes_Dispatch_Information = myPredes.Get_Predes_Dispatch_Information(Chuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu, myEdi_MailBox)

                'BGM
                Dim myPredes_BGM As New Predes_BGM
                myPredes_BGM = myPredes.Get_BGM(myPredes_Dispatch_Information.Ma_BC_KT, myPredes_Dispatch_Information.Ma_BC, myPredes_Dispatch_Information.Phan_loai, myPredes_Dispatch_Information.Ngay_dong, myPredes_Dispatch_Information.So_Chuyen_thu)
                'ghi file BGM
                sb.Append("BGM+")
                sb.Append(myPredes_BGM.BGM_C002.ToString())
                sb.Append("+")
                sb.Append(myPredes_BGM.BGM_1004.ToString())
                sb.Append("+")
                sb.Append(myPredes_BGM.BGM_C507.ToString())
                sb.Append("+")
                sb.Append(myPredes_BGM.BGM_1225.ToString())
                sb.Append("+")
                sb.Append(myPredes_BGM.BGM_C506.ToString())
                sb.Append("+")
                sb.Append(myPredes_BGM.BGM_C507.ToString())
                sb.Append("+")
                sb.Append(myPredes_BGM.BGM_4343.ToString())
                sb.Append("'")
                segs_number = segs_number + 1

                'DTM
                Dim myPredes_DTM As New Predes_DTM
                myPredes_DTM = myPredes.Get_DTM(myPredes_Dispatch_Information.Ngay_dong, myPredes_Dispatch_Information.Gio_dong)

                'ghi file DTM
                sb.Append("DTM+")
                sb.Append(myPredes_DTM.DTM_C507.ToString())
                sb.Append("'")
                segs_number = segs_number + 1

                'Ghi ra file
                'TDT
                Dim myPredes_TDT() As Predes_TDT
                myPredes_TDT = myPredes.Get_TDT(Chuyen_Thu_Di_Chi_Tiet.Id_Duong_Thu, myPredes_Dispatch_Information.Ngay_dong, myPredes_Dispatch_Information.So_Chuyen_thu)

                If myPredes_TDT(0) Is Nothing Then
                    Exit Function
                End If

                Dim ngay As String = myPredes_Dispatch_Information.Ngay_dong
                Dim gio As String = myPredes_Dispatch_Information.Gio_dong
                For i As Integer = 0 To myPredes_TDT.Length - 1
                    sb.Append("TDT+")
                    sb.Append(myPredes_TDT(i).TDT_8051.ToString())
                    sb.Append("+")
                    sb.Append(myPredes_TDT(i).TDT_8028.ToString())
                    sb.Append("+")
                    sb.Append(myPredes_TDT(i).TDT_C220.ToString())
                    sb.Append("+")
                    sb.Append(myPredes_TDT(i).TDT_C222.ToString())
                    sb.Append("+")
                    sb.Append(myPredes_TDT(i).TDT_C228.ToString())
                    sb.Append("+")
                    sb.Append(myPredes_TDT(i).TDT_C040.ToString())
                    sb.Append("'")
                    segs_number = segs_number + 1

                    Dim myPredes_Flight_Schedules As New Predes_Flight_Schedules
                    myPredes_Flight_Schedules = myPredes.Get_Flight_Schedule(myPredes_TDT(i).TDT_8028.ToString())

                    Dim myPredes_LOC As New Predes_LOC

                    myPredes_LOC = myPredes.Get_LOC(myPredes_Flight_Schedules.From_Airport, 5)
                    sb.Append("LOC+")
                    sb.Append(myPredes_LOC.LOC_3227.ToString())
                    sb.Append(":")
                    sb.Append(myPredes_LOC.LOC_3225.ToString())
                    sb.Append(":")
                    sb.Append(myPredes_LOC.LOC_1131.ToString())
                    sb.Append(":")
                    sb.Append(myPredes_LOC.LOC_3055.ToString())
                    sb.Append("'")
                    segs_number = segs_number + 1

                    If (myPredes_TDT.Length - 1 > 0) Then
                        If (i < myPredes_TDT.Length - 1) Then
                            myPredes_LOC = myPredes.Get_LOC(myPredes_Flight_Schedules.To_Airport, 13)
                            sb.Append("LOC+")
                            sb.Append(myPredes_LOC.LOC_3227.ToString())
                            sb.Append(":")
                            sb.Append(myPredes_LOC.LOC_3225.ToString())
                            sb.Append(":")
                            sb.Append(myPredes_LOC.LOC_1131.ToString())
                            sb.Append(":")
                            sb.Append(myPredes_LOC.LOC_3055.ToString())
                            sb.Append("'")
                            segs_number = segs_number + 1
                        Else
                            myPredes_LOC = myPredes.Get_LOC(myPredes_Flight_Schedules.To_Airport, 7)
                            sb.Append("LOC+")
                            sb.Append(myPredes_LOC.LOC_3227.ToString())
                            sb.Append(":")
                            sb.Append(myPredes_LOC.LOC_3225.ToString())
                            sb.Append(":")
                            sb.Append(myPredes_LOC.LOC_1131.ToString())
                            sb.Append(":")
                            sb.Append(myPredes_LOC.LOC_3055.ToString())
                            sb.Append("'")
                            segs_number = segs_number + 1
                        End If
                    Else
                        myPredes_LOC = myPredes.Get_LOC(myPredes_Flight_Schedules.To_Airport, 7)
                        sb.Append("LOC+")
                        sb.Append(myPredes_LOC.LOC_3227.ToString())
                        sb.Append(":")
                        sb.Append(myPredes_LOC.LOC_3225.ToString())
                        sb.Append(":")
                        sb.Append(myPredes_LOC.LOC_1131.ToString())
                        sb.Append(":")
                        sb.Append(myPredes_LOC.LOC_3055.ToString())
                        sb.Append("'")
                        segs_number = segs_number + 1
                    End If

                    Dim myPredes_DTM_Flight As New Predes_DTM_Flight
                    'DTM seg 1 : departure information
                    If (Int32.Parse(gio) > Int32.Parse(myPredes_Flight_Schedules.Dep_Time)) Then
                        Dim frmt As System.IFormatProvider = New System.Globalization.CultureInfo("en-US", True)
                        Dim dt As DateTime = DateTime.ParseExact(((ngay.Substring(4, 2) & "/") + ngay.Substring(6, 2) & "/") + ngay.Substring(2, 2), "MM/dd/yy", frmt)
                        Dim tmp_day As DateTime = dt.AddDays(1)
                        ngay = tmp_day.Year.ToString() + (IIf(Int32.Parse(tmp_day.Month.ToString()) > 9, tmp_day.Month.ToString(), "0" & tmp_day.Month.ToString())) + (IIf(Int32.Parse(tmp_day.Day.ToString()) > 9, tmp_day.Day.ToString(), "0" & tmp_day.Day.ToString()))
                    End If

                    myPredes_DTM_Flight = myPredes.Get_DTM_Flight(ngay, myPredes_Flight_Schedules.Dep_Time, 0, 0, 0)

                    sb.Append("DTM+")
                    sb.Append(myPredes_DTM_Flight.DTM_2005.ToString())
                    sb.Append(":")
                    sb.Append(myPredes_DTM_Flight.DTM_2380.ToString())
                    sb.Append(":")
                    sb.Append(myPredes_DTM_Flight.DTM_2379.ToString())
                    sb.Append("'")
                    segs_number = segs_number + 1

                    'DTM seg 2 : arrival information
                    myPredes_DTM_Flight = myPredes.Get_DTM_Flight(ngay, myPredes_Flight_Schedules.Arr_Time, 1, myPredes_Flight_Schedules.Over_Day, 1)
                    sb.Append("DTM+")
                    sb.Append(myPredes_DTM_Flight.DTM_2005.ToString())
                    sb.Append(":")
                    sb.Append(myPredes_DTM_Flight.DTM_2380.ToString())
                    sb.Append(":")
                    sb.Append(myPredes_DTM_Flight.DTM_2379.ToString())
                    sb.Append("'")
                    segs_number = segs_number + 1
                    gio = myPredes_Flight_Schedules.Arr_Time
                Next

                'Lay cac ban ke E2
                Dim m_DataSet_Danh_Sach_E2 As New DataSet
                m_DataSet_Danh_Sach_E2 = myE2_Di.Lay_Boi_Chuyen_Thu_Di(Id_Chuyen_Thu)
                Dim idx As Integer
                For idx = 0 To m_DataSet_Danh_Sach_E2.Tables(0).Rows.Count - 1
                    'GID
                    Dim myPredes_GID As New Predes_GID
                    myPredes_GID = myPredes.Get_GID()
                    sb.Append("GID+")
                    sb.Append(myPredes_GID.GID_1496.ToString())
                    sb.Append("+")
                    sb.Append(myPredes_GID.GID_C213.ToString())
                    sb.Append("'")
                    segs_number = segs_number + 1

                    Dim myPredes_PCI As New Predes_PCI
                    myPredes_PCI = myPredes.Get_PCI(myPredes_Dispatch_Information.So_Chuyen_thu, m_DataSet_Danh_Sach_E2.Tables(0).Rows(idx).Item("Tui_so"), m_DataSet_Danh_Sach_E2.Tables(0).Rows(idx).Item("Khoi_Luong_BP"), m_DataSet_Danh_Sach_E2.Tables(0).Rows(idx).Item("Khoi_Luong_Vo_Tui"), myPredes_Dispatch_Information.Ma_BC_KT.ToString(), myPredes_Dispatch_Information.Ma_BC.ToString(), myPredes_Dispatch_Information.Phan_loai, m_DataSet_Danh_Sach_E2.Tables(0).Rows(idx).Item("Ngay_dong"), m_DataSet_Danh_Sach_E2.Tables(0).Rows(idx).Item("Tui_F"), myIPMC_MaNC.Ma_NC.ToString())
                    sb.Append("PCI+")
                    sb.Append(myPredes_PCI.PCI_4233.ToString())
                    sb.Append("+")
                    sb.Append(myPredes_PCI.PCI_C210.ToString())
                    sb.Append("+")
                    sb.Append(myPredes_PCI.PCI_C506.ToString())
                    sb.Append("'")
                    segs_number = segs_number + 1

                    If (m_DataSet_Danh_Sach_E2.Tables(0).Rows(idx).Item("Tui_F") = -1) Then
                        sb.Append("FTX+DOC'")
                        segs_number = segs_number + 1
                    End If

                    Dim m_DataSet_Danh_Sach_E1 As New DataSet
                    'Lay E1 cua ban ke E2
                    m_DataSet_Danh_Sach_E1 = myE1_Di.E1_Di_Lay_Boi_E2_Di_KT(m_DataSet_Danh_Sach_E2.Tables(0).Rows(idx).Item("Id_E2"))
                    For i As Integer = 0 To m_DataSet_Danh_Sach_E1.Tables(0).Rows.Count - 1
                        sb.Append("GDS+")
                        sb.Append("1:" & m_DataSet_Danh_Sach_E1.Tables(0).Rows(i).Item("MA_E1"))
                        sb.Append("'")
                        segs_number = segs_number + 1

                        sb.Append("MEA+")
                        sb.Append("WT+AAA+KGM:" & Decimal.Parse(m_DataSet_Danh_Sach_E1.Tables(0).Rows(i).Item("KHOI_LUONG")) / 1000)
                        sb.Append("'")
                        segs_number = segs_number + 1
                    Next
                Next

                Dim myPredes_UNT As Predes_UNT
                myPredes_UNT = myPredes.Get_UNT(segs_number, myPredes_UNH.UNH_0062)
                sb.Append("UNT+")
                sb.Append(myPredes_UNT.UNT_0074.ToString())
                sb.Append("+")
                sb.Append(myPredes_UNT.UNT_0062.ToString())
                sb.Append("'")

                Dim myPredes_UNZ As Predes_UNZ
                myPredes_UNZ = myPredes.Get_UNZ(myPredes_UNB.UNB_S005)
                sb.Append("UNZ+")
                sb.Append(myPredes_UNZ.UNZ_0036.ToString())
                sb.Append("+")
                sb.Append(myPredes_UNZ.UNZ_0020.ToString())
                sb.Append("'")

                Dim file_name As String = myIPMC_MaNC.Ma_NC.ToString().Trim() & "_PREDES_" & myPredes_UNZ.UNZ_0020.ToString() & ".txt"
                Dim path_predes_dir As String = Application.StartupPath & "\PREDES"
                Dim path_name As String = Application.StartupPath & "\PREDES\" & file_name
                Dim objStreamWriter As StreamWriter
                If Directory.Exists(path_predes_dir) = False Then
                    Directory.CreateDirectory(path_predes_dir)
                End If
                objStreamWriter = New StreamWriter(path_name, True, Encoding.ASCII)

                'objStreamWriter = File.AppendText(file_name)

                objStreamWriter.Write(sb.ToString())
                objStreamWriter.Close()
                myEdi_MailBox.Update_EDI_Intref(myIPMC_MaNC.Ma_NC.ToString(), "PREDES")

                myEDI.Add_EDI(Id_Chuyen_Thu, Chuyen_Thu_Di_Chi_Tiet.Id_Duong_Thu, myPredes_UNB.UNB_S005, Int32.Parse(myPredes_UNB.UNB_0017), Int32.Parse(myPredes_UNB.UNB_0019), file_name, "PREDES")
                '            ConnectServer_Click()
            End If
            'Can cu theo id_chuyen_thu de xac dinh duoc id_duong_thu
            'Kiem tra duong thu di theo id_duong_thu, neu id_phan_loai=4 => Di quoc te, thi se duoc tao ra PREDES.
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        End Try

    End Function
#End Region

#Region "Truyền File"
    Private Function FTP_Send_File(ByVal File_Name As String, ByVal Source_Path As String, ByVal Destination_Path As String) As Boolean
        Try
            Dim m_Predes As New Predes(GConnectionString)
            Dim FtpUp As New FTP.FTPLib.FTP
            'Dim filename As String = myPredes_Unsending.Tables(0).Rows(idx).Item("PREDES")
            Dim StrSrcFile As String
            StrSrcFile = Source_Path & "\" & File_Name

            If File.Exists(StrSrcFile) Then
                Dim sFileName As String = Path.GetFileName(StrSrcFile)
                FtpUp.OpenUpload(StrSrcFile, sFileName)
                While (FtpUp.DoUpload() > 0) 'Upload thành công
                    'Đẩy dữ liệu thành công thì Move file vào thư mục của ngày hôm trước
                    If Move_File(File_Name, Source_Path, Destination_Path) = False Then
                        Return False
                    End If
                End While
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function Move_File(ByVal File_Name As String, ByVal Source_Path As String, ByVal Des_Path As String) As Boolean
        'Move File vào thư mục sẵn có
        Try
            Dim FileToMove As String
            Dim MoveLocation As String
            FileToMove = Source_Path & "\" & File_Name
            MoveLocation = Des_Path & "\" & File_Name

            If System.IO.File.Exists(FileToMove) = True Then
                System.IO.File.Move(FileToMove, MoveLocation)
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

#Region "FTP"

    Private Sub ConnectServer_Click()
        'Try
        '    Dim ftpUp As New FTP
        '    Dim ftpDown As New FTP
        '    Dim Ftp_Server As String = "192.168.68.9"
        '    Dim Ftp_Username As String = "ems"
        '    Dim Ftp_Password As String = "ems"
        '    ftpDown.Connect(Ftp_Server, Ftp_Username, Ftp_Password)
        '    ftpUp.Connect(Ftp_Server, Ftp_Username, Ftp_Password)
        '    MessageBox.Show("Kết nối thành công")
        '    isConnectedFtp = True
        'Catch ex As Exception
        '    MessageBox.Show("Kết nối không thành công. Chi tiết: " & ex.Message)
        'End Try
    End Sub
#End Region

#Region "Sử dụng FTP để đẩy File lên Server"
    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Try
    '        'FTP file lên server
    '        Dim myPredes_Unsending As DataSet = myPredes.Get_Predes_UnSending()
    '        Dim idx As Integer
    '        Dim ftpUp As New FTP.FTPLib.FTP
    '        'Lấy dữ liệu trong bảng
    '        Dim m_FTP_Table As New FTP_Table(GConnectionString)
    '        Dim m_FTP_Table_Chi_Tiet As New FTP_Table_Chi_Tiet
    '        m_FTP_Table_Chi_Tiet = m_FTP_Table.FTP_Lay_Dong_Dau_Tien

    '        Dim Ftp_Server As String = m_FTP_Table_Chi_Tiet.SERVER '"192.168.68.9"
    '        Dim Ftp_Username As String = m_FTP_Table_Chi_Tiet.USERNAME ' "ems"
    '        Dim Ftp_Password As String = m_FTP_Table_Chi_Tiet.PASSWORD ' "ems"
    '        Try
    '            ftpUp.Connect(Ftp_Server, Ftp_Username, Ftp_Password)
    '            ftpUp.ChangeDir("\\upload")
    '            isConnectedFtp = True
    '        Catch ex As Exception
    '            MessageBox.Show("Kết nối không thành công. Chi tiết: " & ex.Message)
    '        End Try

    '        For idx = 0 To myPredes_Unsending.Tables(0).Rows.Count - 1
    '            Dim filename As String = myPredes_Unsending.Tables(0).Rows(idx).Item("PREDES")
    '            Dim strSrcFile As String = Application.StartupPath & "\PREDES\" & filename

    '            If File.Exists(strSrcFile) Then
    '                Dim sFileName As String = Path.GetFileName(strSrcFile)
    '                ftpUp.OpenUpload(strSrcFile, sFileName)
    '                While (ftpUp.DoUpload() > 0)

    '                End While
    '            End If
    '            'Đẩy dữ liệu thành công thì Move file vào thư mục của ngày hôm trước
    '        Next
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString)
    '    End Try
    'End Sub
#End Region
#End Region

#Region "==========Truyền lại dữ liệu của toàn bộ ca khai thác=========="
    Private Sub Danh_Sach_Chuyen_Thu_Di_Trong_Ca_Can_Truyen(ByVal Id_Ca As String)
        Try
            'Hien thong tin tren label Tien trinh
            lblTien_Trinh.Text = ".....Đang truyền dữ liệu đóng đi lên Center......."
            lblTien_Trinh.Refresh()
            '--------------------------------------------
            Dim m_Duong_Thu_Di As New Duong_Thu_Di(GConnectionString)
            Dim m_Ca_San_Xuat As New Ca_San_Xuat(GConnectionString)
            Dim m_Ca_San_Xuat_Chi_Tiet As New Ca_San_Xuat_Chi_Tiet
            Dim m_Ham_Dung_Chung As New Ham_Dung_Chung
            Dim idx As Integer
            'Tạo bản tin Predes
            Dim m_DataSet_Danh_Sach_Chuyen_Thu As New DataSet
            m_DataSet_Danh_Sach_Chuyen_Thu = myChuyen_Thu_Di.Danh_Sach_Chuyen_Thu_Da_Dong_F_Theo_Ca(Id_Ca)
            'Xu ly Process Bar
            PrbTien_Trinh.Maximum = m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows.Count
            PrbTien_Trinh.Step = 1
            PrbTien_Trinh.Value = 0
            '----------------------------------------
            If m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows.Count > 0 Then
                'Dim num As Integer = 0
                For idx = 0 To m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows.Count - 1
                    Dim mydataset As New DataSet
                    Dim mytable As New DataTable
                    Dim m_Id_Chuyen_Thu As String
                    Dim m_Ma_Bc As Integer
                    m_Id_Chuyen_Thu = m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows(idx).Item("Id_Chuyen_Thu")

                    'Hien thong tin tren label Tien trinh
                    lblTien_Trinh.Text = ".....Đang truyền dữ liệu đóng đi lên Center.....Id_Chuyen_Thu :  " & m_Id_Chuyen_Thu
                    lblTien_Trinh.Refresh()
                    '--------------------------------------------

                    m_Ma_Bc = m_Duong_Thu_Di.Lay(m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows(idx).Item("Id_Duong_Thu")).Ma_Bc
                    'Chuyen thu
                    mytable = myChuyen_Thu_Di.Danh_Sach_Chuyen_Thu_Lay_Boi_Id_Chuyen_Thu_Truyen_Lai(m_Id_Chuyen_Thu).Tables(0)
                    mytable.TableName = "Chuyen_Thu"
                    mydataset.Tables.Add(mytable.Copy)
                    'E2_Di
                    mytable = myE2_Di.Danh_Sach_E2_Truyen(m_Id_Chuyen_Thu).Tables(0)
                    mytable.TableName = "E2"
                    mydataset.Tables.Add(mytable.Copy)
                    'E1_Di
                    mytable = myE1_Di.Danh_Sach_E1_Truyen(m_Id_Chuyen_Thu).Tables(0)
                    mytable.TableName = "E1"
                    mydataset.Tables.Add(mytable.Copy)
                    ' truyền dữ liệu
                    myUtility.Dang_Ky_Truyen("Ems_E2", "Branch", "PO", GBuu_Cuc_Khai_Thac, m_Ma_Bc, m_Ham_Dung_Chung.ConvertDateToInt(Now), m_Ham_Dung_Chung.ConvertTimeToInt(Now), "", mydataset)
                    'Next process value
                    PrbTien_Trinh.PerformStep()
                    '----------------------------------------
                    'Refresh form
                    Application.DoEvents()
                    '----------------------------------------
                Next
            End If
            'Hien thong tin tren label Tien trinh
            lblTien_Trinh.Text = "Đã truyền hết dữ liệu đóng đi......"
            lblTien_Trinh.Refresh()
            '--------------------------------------------
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Danh_Sach_Chuyen_Thu_Den_Trong_Ca_Can_Truyen(ByVal Id_Ca As String)
        Try
            'Hien thong tin tren label Tien trinh
            lblTien_Trinh.Text = ".....Đang truyền dữ liệu xác nhận đến lên Center......."
            lblTien_Trinh.Refresh()
            '--------------------------------------------
            Dim m_Duong_Thu_Den As New Duong_Thu_Den(GConnectionString)
            Dim m_Ca_San_Xuat As New Ca_San_Xuat(GConnectionString)
            Dim m_Ca_San_Xuat_Chi_Tiet As New Ca_San_Xuat_Chi_Tiet
            Dim m_Ham_Dung_Chung As New Ham_Dung_Chung
            Dim idx As Integer
            'Tạo bản tin Predes
            Dim m_DataSet_Danh_Sach_Chuyen_Thu As New DataSet
            m_DataSet_Danh_Sach_Chuyen_Thu = myChuyen_Thu_Den.Danh_Sach_Chuyen_Thu_Den_Theo_Ca(Id_Ca)
            'Xu ly Process Bar
            PrbTien_Trinh.Maximum = m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows.Count
            PrbTien_Trinh.Step = 1
            PrbTien_Trinh.Value = 0
            '----------------------------------------
            If m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows.Count > 0 Then
                'Dim num As Integer = 0
                For idx = 0 To m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows.Count - 1
                    Dim mydataset As New DataSet
                    Dim mytable As New DataTable
                    Dim m_Id_Chuyen_Thu As String
                    Dim m_Ma_Bc As Integer
                    m_Id_Chuyen_Thu = m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows(idx).Item("Id_Chuyen_Thu")

                    'Hien thong tin tren label Tien trinh
                    lblTien_Trinh.Text = ".....Đang truyền dữ liệu xác nhận đến lên Center.....Id_Chuyen_Thu :  " & m_Id_Chuyen_Thu
                    lblTien_Trinh.Refresh()
                    '--------------------------------------------

                    m_Ma_Bc = m_Duong_Thu_Den.Lay(m_DataSet_Danh_Sach_Chuyen_Thu.Tables(0).Rows(idx).Item("Id_Duong_Thu")).Ma_Bc
                    'Chuyến thư
                    mytable = myChuyen_Thu_Den.Danh_Sach_Chuyen_Thu_Lay_Boi_Id_Chuyen_Thu_Truyen(m_Id_Chuyen_Thu).Tables(0)
                    mytable.TableName = "Chuyen_Thu"
                    mydataset.Tables.Add(mytable.Copy)
                    'E2_Den
                    mytable = myE2_Den.Danh_Sach_E2_Truyen(m_Id_Chuyen_Thu).Tables(0)
                    mytable.TableName = "E2"
                    mydataset.Tables.Add(mytable.Copy)
                    'E1_Den
                    mytable = myE1_Den.Danh_Sach_E1_Truyen(m_Id_Chuyen_Thu).Tables(0)
                    mytable.TableName = "E1"
                    mydataset.Tables.Add(mytable.Copy)
                    ' Truyền dữ liệu 
                    myUtility.Dang_Ky_Truyen("Ems_E2_Den", "Branch", "PO", GBuu_Cuc_Khai_Thac, m_Ma_Bc, m_Ham_Dung_Chung.ConvertDateToInt(Now), m_Ham_Dung_Chung.ConvertTimeToInt(Now), "", mydataset)
                    'Next process value
                    PrbTien_Trinh.PerformStep()
                    '----------------------------------------
                    'Refresh form
                    Application.DoEvents()
                    '----------------------------------------
                Next
            End If
            'Hien thong tin tren label Tien trinh
            lblTien_Trinh.Text = "Đã truyền hết dữ liệu xác nhận đến......"
            lblTien_Trinh.Refresh()
            '--------------------------------------------
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "===========Tao du lieu hang den gui Email cho A1 - yeu cau moi ngay 01/01/2013=========="
#Region "btnSend_Mail_Click"
    Private Sub btnSend_Mail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend_Mail.Click
        Tao_Du_Lieu_Hang_Den_Gui_Email(Id_Ca_Ngaycakt)
    End Sub
#End Region
#Region "Tao_Du_Lieu_Hang_Den_Gui_Email"
    Private Sub Tao_Du_Lieu_Hang_Den_Gui_Email(ByVal mId_Ca As String)
        Try
            Dim mE1_Den As New E1_Den(GConnectionString)
            Dim mData As New DataTable
            Dim idx As Integer
            Dim str As String
            mData = mE1_Den.E1_Den_Danh_Sach_Hang_Den_Gui_Email_Theo_Id_Ca(mId_Ca).Tables(0)
            If mData.Rows.Count = 0 Then
                Exit Sub
            End If
            Dim file_name As String = "EMS" & mId_Ca.Substring(0, mId_Ca.Length - 1) & ".txt"
            Dim path_dir As String = Application.StartupPath & "\SendEmail"
            Dim path_name As String = Application.StartupPath & "\SendEmail\" & file_name
            Dim objStreamWriter As StreamWriter
            If Directory.Exists(path_dir) = False Then
                Directory.CreateDirectory(path_dir)
            End If
            objStreamWriter = New StreamWriter(path_name, False, Encoding.ASCII)

            'objStreamWriter = File.AppendText(file_name)
            str = "Ma_E1" & vbTab
            str = str & "Khoi_Luong" & vbTab
            str = str & "Nguoi_Nhan" & vbTab
            str = str & "Dia_Chi_Nhan" & vbTab
            str = str & "Ma_Tinh_Tra" & vbTab
            str = str & "Phan_Loai"
            objStreamWriter.WriteLine(str)
            For idx = 0 To mData.Rows.Count - 1
                str = mData.Rows(idx).Item("Ma_E1") & vbTab
                str = str & mData.Rows(idx).Item("Khoi_Luong") & vbTab
                str = str & mData.Rows(idx).Item("Nguoi_Nhan") & vbTab
                str = str & mData.Rows(idx).Item("Dia_Chi_Nhan") & vbTab
                str = str & mData.Rows(idx).Item("Ma_Tinh_Tra") & vbTab
                str = str & mData.Rows(idx).Item("Phan_Loai")
                objStreamWriter.WriteLine(str)
            Next
            objStreamWriter.Close()
            str = mId_Ca.Substring(6, 8)
            str = myham_dung_chung.ConvertIntToVNDateType(CInt(str))
            SendEmailUseYahooMail(path_name, str)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "SendEmailUseYahooMail"
    Private Sub SendEmailUseYahooMail(ByVal strFileAtt As String, ByVal strNgay As String)
        Dim Ds As New DataSet
        Dim strTo, strFrom, strNameFrom, strBody, strSub, strSmtp, strCC, strUser, strPass As String

        Ds = ReadConfig(Application.StartupPath + "\\Config.ftp")

        Dim oRows As DataRow() = Ds.Tables("tbl_Config").[Select]("ParaName='SEND_FROM'")
        If oRows.Length > 0 Then
            strFrom = oRows(0)("ParaValue").ToString()
        End If

        oRows = Ds.Tables("tbl_Config").[Select]("ParaName='NAME_FROM'")
        If oRows.Length > 0 Then
            strNameFrom = oRows(0)("ParaValue").ToString()
        End If

        oRows = Ds.Tables("tbl_Config").[Select]("ParaName='SEND_TO'")
        If oRows.Length > 0 Then
            strTo = oRows(0)("ParaValue").ToString()
        End If

        oRows = Ds.Tables("tbl_Config").[Select]("ParaName='CC_TO'")
        If oRows.Length > 0 Then
            strCC = oRows(0)("ParaValue").ToString()
        End If

        oRows = Ds.Tables("tbl_Config").[Select]("ParaName='USER'")
        If oRows.Length > 0 Then
            strUser = oRows(0)("ParaValue").ToString()
        End If

        oRows = Ds.Tables("tbl_Config").[Select]("ParaName='PASS'")
        If oRows.Length > 0 Then
            strPass = oRows(0)("ParaValue").ToString()
        End If

        oRows = Ds.Tables("tbl_Config").[Select]("ParaName='SUBJECT'")
        If oRows.Length > 0 Then
            strSub = oRows(0)("ParaValue").ToString()
            strSub = strSub & " " & strNgay
        End If

        oRows = Ds.Tables("tbl_Config").[Select]("ParaName='BODY'")
        If oRows.Length > 0 Then
            strBody = oRows(0)("ParaValue").ToString()
            strBody = strBody & " " & strNgay
        End If

        oRows = Ds.Tables("tbl_Config").[Select]("ParaName='SMTP'")
        If oRows.Length > 0 Then
            strSmtp = oRows(0)("ParaValue").ToString()
        End If

        Dim oMail As New SmtpMail("ES-AA1141023508-00919-5AAEC214295D654645E2B1C542DBB8E2")
        Dim oSmtp As New SmtpClient
        Dim From As New EASendMail.MailAddress(strNameFrom, strFrom)
        Dim SendTo As New EASendMail.AddressCollection(strTo)
        Dim CCTo As New EASendMail.AddressCollection(strCC)


        ' Your Yahoo email address
        oMail.From = From

        ' Set recipient email address, please change it to yours
        oMail.To = SendTo

        oMail.Cc = CCTo

        ' Set email subject
        oMail.Subject = strSub

        ' Set email body
        oMail.TextBody = strBody


        If File.Exists(strFileAtt) Then
            'Dim mAttach As New EASendMail.Attachment
            'mAttach.Load(strFileAtt)
            oMail.AddAttachment(strFileAtt)
        End If

        ' Yahoo SMTP server address
        Dim oServer As New SmtpServer(strSmtp)

        ' For example: your email is "myid@yahoo.com", then the user should be "myid@yahoo.com"
        oServer.User = strUser
        oServer.Password = strPass

        ' Because yahoo deploys SMTP server on 465 port with direct SSL connection.
        ' So we should change the port to 465.
        oServer.Port = 465

        ' detect SSL/TLS type automatically
        oServer.ConnectType = SmtpConnectType.ConnectSSLAuto

        Try
            oSmtp.SendMail(oServer, oMail)
            MessageBox.Show("email was sent successfully!", "Send email", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ep As Exception
            MessageBox.Show("failed to send email with the following error:" & vbNewLine & ep.Message, "Send mail", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "ReadConfig"
    Private Function ReadConfig(ByVal configFilePath As String) As DataSet
        Try
            Dim ds As New DataSet
            ds.ReadXml(configFilePath)
            Return ds
        Catch ex As Exception
            MessageBox.Show("Can not read file config", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function
#End Region
#End Region

End Class

#End Region

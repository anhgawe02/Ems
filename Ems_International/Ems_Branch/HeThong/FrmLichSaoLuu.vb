Imports Ems_International_Logic.EMS
Public Class FrmLichSaoLuu
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
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents dtpEndDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents dtpStartDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents rdEndDate As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rdNoEndDate As System.Windows.Forms.RadioButton
    Friend WithEvents gbThuMuc As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nudFreq As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboUnit As System.Windows.Forms.ComboBox
    Friend WithEvents btnCapNhat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents nudDate As System.Windows.Forms.NumericUpDown
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cboPhutGio As System.Windows.Forms.ComboBox
    Friend WithEvents nudEvery As System.Windows.Forms.NumericUpDown
    Friend WithEvents dtpTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents rdOnce As System.Windows.Forms.RadioButton
    Friend WithEvents rdEvery As System.Windows.Forms.RadioButton
    Friend WithEvents lblStartTime As System.Windows.Forms.Label
    Friend WithEvents dtpStartTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEndTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblEndTime As System.Windows.Forms.Label
    Friend WithEvents cboDay As System.Windows.Forms.ComboBox
    Friend WithEvents btnThoat As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmLichSaoLuu))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox
        Me.dtpEndDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.dtpStartDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.rdEndDate = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.rdNoEndDate = New System.Windows.Forms.RadioButton
        Me.gbThuMuc = New Infragistics.Win.Misc.UltraGroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.nudFreq = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboUnit = New System.Windows.Forms.ComboBox
        Me.btnCapNhat = New Infragistics.Win.Misc.UltraButton
        Me.nudDate = New System.Windows.Forms.NumericUpDown
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.cboPhutGio = New System.Windows.Forms.ComboBox
        Me.nudEvery = New System.Windows.Forms.NumericUpDown
        Me.dtpTime = New System.Windows.Forms.DateTimePicker
        Me.rdOnce = New System.Windows.Forms.RadioButton
        Me.rdEvery = New System.Windows.Forms.RadioButton
        Me.lblStartTime = New System.Windows.Forms.Label
        Me.dtpStartTime = New System.Windows.Forms.DateTimePicker
        Me.dtpEndTime = New System.Windows.Forms.DateTimePicker
        Me.lblEndTime = New System.Windows.Forms.Label
        Me.cboDay = New System.Windows.Forms.ComboBox
        Me.btnThoat = New Infragistics.Win.Misc.UltraButton
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.dtpEndDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbThuMuc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbThuMuc.SuspendLayout()
        CType(Me.nudFreq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.nudEvery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.dtpEndDate)
        Me.UltraGroupBox2.Controls.Add(Me.dtpStartDate)
        Me.UltraGroupBox2.Controls.Add(Me.rdEndDate)
        Me.UltraGroupBox2.Controls.Add(Me.Label4)
        Me.UltraGroupBox2.Controls.Add(Me.rdNoEndDate)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(6, 196)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(496, 112)
        Me.UltraGroupBox2.SupportThemes = False
        Me.UltraGroupBox2.TabIndex = 10
        Me.UltraGroupBox2.Text = "Thời gian hiệu lực"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.DateTime = New Date(2005, 1, 7, 0, 0, 0, 0)
        Me.dtpEndDate.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpEndDate.Location = New System.Drawing.Point(384, 24)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(96, 21)
        Me.dtpEndDate.TabIndex = 3
        Me.dtpEndDate.Value = New Date(2005, 1, 7, 0, 0, 0, 0)
        '
        'dtpStartDate
        '
        Me.dtpStartDate.DateTime = New Date(2005, 1, 7, 0, 0, 0, 0)
        Me.dtpStartDate.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpStartDate.Location = New System.Drawing.Point(120, 24)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(96, 21)
        Me.dtpStartDate.TabIndex = 1
        Me.dtpStartDate.Value = New Date(2005, 1, 7, 0, 0, 0, 0)
        '
        'rdEndDate
        '
        Me.rdEndDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdEndDate.Location = New System.Drawing.Point(274, 32)
        Me.rdEndDate.Name = "rdEndDate"
        Me.rdEndDate.TabIndex = 2
        Me.rdEndDate.Text = "Kết thúc ngày:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Bắt đầu ngày:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rdNoEndDate
        '
        Me.rdNoEndDate.Checked = True
        Me.rdNoEndDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdNoEndDate.Location = New System.Drawing.Point(274, 56)
        Me.rdNoEndDate.Name = "rdNoEndDate"
        Me.rdNoEndDate.Size = New System.Drawing.Size(192, 24)
        Me.rdNoEndDate.TabIndex = 4
        Me.rdNoEndDate.TabStop = True
        Me.rdNoEndDate.Text = "Không giới hạn ngày kết thúc "
        '
        'gbThuMuc
        '
        Me.gbThuMuc.Controls.Add(Me.Label2)
        Me.gbThuMuc.Controls.Add(Me.nudFreq)
        Me.gbThuMuc.Controls.Add(Me.Label1)
        Me.gbThuMuc.Location = New System.Drawing.Point(7, 4)
        Me.gbThuMuc.Name = "gbThuMuc"
        Me.gbThuMuc.Size = New System.Drawing.Size(496, 64)
        Me.gbThuMuc.SupportThemes = False
        Me.gbThuMuc.TabIndex = 8
        Me.gbThuMuc.Text = "Tần suất thực hiện"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(328, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ngày/lần"
        '
        'nudFreq
        '
        Me.nudFreq.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudFreq.ForeColor = System.Drawing.Color.Navy
        Me.nudFreq.Location = New System.Drawing.Point(264, 24)
        Me.nudFreq.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudFreq.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudFreq.Name = "nudFreq"
        Me.nudFreq.Size = New System.Drawing.Size(56, 22)
        Me.nudFreq.TabIndex = 1
        Me.nudFreq.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Thực hiện sao lưu cơ sỡ dữ liệu với tần suất:"
        '
        'cboUnit
        '
        Me.cboUnit.Items.AddRange(New Object() {"Ngày", "Tuần", "Tháng"})
        Me.cboUnit.Location = New System.Drawing.Point(7, 316)
        Me.cboUnit.Name = "cboUnit"
        Me.cboUnit.Size = New System.Drawing.Size(121, 21)
        Me.cboUnit.TabIndex = 13
        Me.cboUnit.Visible = False
        '
        'btnCapNhat
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.btnCapNhat.Appearance = Appearance1
        Me.btnCapNhat.Location = New System.Drawing.Point(311, 316)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(88, 32)
        Me.btnCapNhat.TabIndex = 11
        Me.btnCapNhat.Text = "Cập nhật"
        '
        'nudDate
        '
        Me.nudDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDate.Location = New System.Drawing.Point(87, 316)
        Me.nudDate.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.nudDate.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudDate.Name = "nudDate"
        Me.nudDate.Size = New System.Drawing.Size(104, 23)
        Me.nudDate.TabIndex = 14
        Me.nudDate.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudDate.Visible = False
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.cboPhutGio)
        Me.UltraGroupBox1.Controls.Add(Me.nudEvery)
        Me.UltraGroupBox1.Controls.Add(Me.dtpTime)
        Me.UltraGroupBox1.Controls.Add(Me.rdOnce)
        Me.UltraGroupBox1.Controls.Add(Me.rdEvery)
        Me.UltraGroupBox1.Controls.Add(Me.lblStartTime)
        Me.UltraGroupBox1.Controls.Add(Me.dtpStartTime)
        Me.UltraGroupBox1.Controls.Add(Me.dtpEndTime)
        Me.UltraGroupBox1.Controls.Add(Me.lblEndTime)
        Me.UltraGroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.UltraGroupBox1.Location = New System.Drawing.Point(6, 76)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(496, 112)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 9
        Me.UltraGroupBox1.Text = "Thời gian thực thi"
        '
        'cboPhutGio
        '
        Me.cboPhutGio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPhutGio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPhutGio.Items.AddRange(New Object() {"Phút", "Giờ"})
        Me.cboPhutGio.Location = New System.Drawing.Point(200, 48)
        Me.cboPhutGio.Name = "cboPhutGio"
        Me.cboPhutGio.Size = New System.Drawing.Size(68, 22)
        Me.cboPhutGio.TabIndex = 4
        '
        'nudEvery
        '
        Me.nudEvery.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudEvery.ForeColor = System.Drawing.Color.Navy
        Me.nudEvery.Location = New System.Drawing.Point(160, 48)
        Me.nudEvery.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nudEvery.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudEvery.Name = "nudEvery"
        Me.nudEvery.Size = New System.Drawing.Size(44, 22)
        Me.nudEvery.TabIndex = 3
        Me.nudEvery.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'dtpTime
        '
        Me.dtpTime.CalendarForeColor = System.Drawing.Color.Navy
        Me.dtpTime.CustomFormat = "HH:mm"
        Me.dtpTime.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpTime.Location = New System.Drawing.Point(160, 24)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.ShowUpDown = True
        Me.dtpTime.Size = New System.Drawing.Size(112, 22)
        Me.dtpTime.TabIndex = 1
        '
        'rdOnce
        '
        Me.rdOnce.Checked = True
        Me.rdOnce.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdOnce.Location = New System.Drawing.Point(8, 24)
        Me.rdOnce.Name = "rdOnce"
        Me.rdOnce.Size = New System.Drawing.Size(156, 24)
        Me.rdOnce.TabIndex = 0
        Me.rdOnce.TabStop = True
        Me.rdOnce.Text = "Thực hiện 1 lần vào lúc: "
        '
        'rdEvery
        '
        Me.rdEvery.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdEvery.Location = New System.Drawing.Point(8, 48)
        Me.rdEvery.Name = "rdEvery"
        Me.rdEvery.Size = New System.Drawing.Size(156, 24)
        Me.rdEvery.TabIndex = 2
        Me.rdEvery.Text = "Thực hiện vào mỗi:"
        '
        'lblStartTime
        '
        Me.lblStartTime.BackColor = System.Drawing.Color.Transparent
        Me.lblStartTime.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartTime.Location = New System.Drawing.Point(288, 48)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(76, 24)
        Me.lblStartTime.TabIndex = 5
        Me.lblStartTime.Text = "Bắt đầu lúc:"
        Me.lblStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpStartTime
        '
        Me.dtpStartTime.CalendarForeColor = System.Drawing.Color.Navy
        Me.dtpStartTime.CustomFormat = "HH:mm"
        Me.dtpStartTime.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpStartTime.Location = New System.Drawing.Point(368, 48)
        Me.dtpStartTime.Name = "dtpStartTime"
        Me.dtpStartTime.ShowUpDown = True
        Me.dtpStartTime.Size = New System.Drawing.Size(76, 22)
        Me.dtpStartTime.TabIndex = 6
        '
        'dtpEndTime
        '
        Me.dtpEndTime.CalendarForeColor = System.Drawing.Color.Navy
        Me.dtpEndTime.CustomFormat = "HH:mm"
        Me.dtpEndTime.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEndTime.Location = New System.Drawing.Point(368, 80)
        Me.dtpEndTime.Name = "dtpEndTime"
        Me.dtpEndTime.ShowUpDown = True
        Me.dtpEndTime.Size = New System.Drawing.Size(76, 22)
        Me.dtpEndTime.TabIndex = 8
        '
        'lblEndTime
        '
        Me.lblEndTime.BackColor = System.Drawing.Color.Transparent
        Me.lblEndTime.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndTime.Location = New System.Drawing.Point(288, 80)
        Me.lblEndTime.Name = "lblEndTime"
        Me.lblEndTime.Size = New System.Drawing.Size(76, 24)
        Me.lblEndTime.TabIndex = 7
        Me.lblEndTime.Text = "Kết thúc lúc:"
        Me.lblEndTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboDay
        '
        Me.cboDay.Items.AddRange(New Object() {"Thứ hai", "Thứ ba", "Thứ tư", "Thứ năm", "Thứ sáu", "Thứ bẩy", "Chủ nhật"})
        Me.cboDay.Location = New System.Drawing.Point(143, 316)
        Me.cboDay.Name = "cboDay"
        Me.cboDay.Size = New System.Drawing.Size(121, 21)
        Me.cboDay.TabIndex = 15
        Me.cboDay.Visible = False
        '
        'btnThoat
        '
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.btnThoat.Appearance = Appearance2
        Me.btnThoat.Location = New System.Drawing.Point(407, 316)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(88, 32)
        Me.btnThoat.TabIndex = 12
        Me.btnThoat.Text = "Thoát"
        '
        'FrmLichSaoLuu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(508, 353)
        Me.Controls.Add(Me.UltraGroupBox2)
        Me.Controls.Add(Me.gbThuMuc)
        Me.Controls.Add(Me.cboUnit)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.nudDate)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.cboDay)
        Me.Controls.Add(Me.btnThoat)
        Me.Name = "FrmLichSaoLuu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thiết lập lịch sao lưu"
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.dtpEndDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpStartDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbThuMuc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbThuMuc.ResumeLayout(False)
        CType(Me.nudFreq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.nudEvery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region " Private data members "
    Private m_bOK As Boolean
    Private m_iFreqType As Integer
    Private m_iFreqInterval As Integer
    Private m_iFreqRecurrenceFactor As Integer
    Private m_iFreqSubDayType As Integer
    Private m_iFreqSubDayInterval As Integer
    Private m_iActiveStartDate As Integer
    Private m_iActiveEndDate As Integer
    Private m_iActiveStartTime As Integer
    Private m_iActiveEndTime As Integer
    Private m_sScheduleString As String
#End Region
#Region " Private user subs and functions "
    Private Function Date2Int(ByVal dDate As DateTime) As Integer
        Dim sDate As String = dDate.Year.ToString
        If dDate.Month < 10 Then
            sDate += "0" + dDate.Month.ToString
        Else
            sDate += dDate.Month.ToString
        End If
        If dDate.Day < 10 Then
            sDate += "0" + dDate.Day.ToString
        Else
            sDate += dDate.Day.ToString
        End If
        Return Int(sDate)
    End Function
    Private Function Time2Int(ByVal tTime As TimeSpan) As Integer
        Dim sTime As String = tTime.Hours.ToString
        If tTime.Minutes < 10 Then
            sTime += "0" + tTime.Minutes.ToString
        Else
            sTime += tTime.Minutes.ToString
        End If
        If tTime.Seconds < 10 Then
            sTime += "0" + tTime.Seconds.ToString
        Else
            sTime += tTime.Seconds.ToString
        End If
        Return Int(sTime)
    End Function
    Private Function Interval2Day() As String
        Select Case Me.cboDay.SelectedIndex
            Case 0 'T2
                Return "T2"
            Case 1 'T3 
                Return "T3"
            Case 2 'T4
                Return "T4"
            Case 3 'T5
                Return "T5"
            Case 4 'T6
                Return "T6"
            Case 5 'T7
                Return "T7"
            Case 6 'CN
                Return "CN"
        End Select
    End Function
    Private Function GetFreqType() As Integer
        Select Case Me.cboUnit.SelectedIndex
            Case 0
                Return 4
            Case 1
                Return 8
            Case 2
                Return 16
        End Select
    End Function
    Private Function GetFreqSubDayType() As Integer
        If Me.rdOnce.Checked Then
            Return 1    ' Thuc hien 1 lan vao luc may gio trong ngay
        Else
            Select Case Me.cboPhutGio.SelectedIndex
                Case 0
                    Return 4    ' Thuc hien nhieu lan vao theo khoang thoi gian la PHUT
                Case 1
                    Return 8    ' Thuc hien nhieu lan vao theo khoang thoi gian la GIO
            End Select
        End If
    End Function
    Private Function GetFreqSubDayInterval() As Integer
        If Me.rdEvery.Checked Then
            Return Me.nudEvery.Value
        Else
            Return 0
        End If
    End Function
    Private Function GetFreqRecurrenceFactor(ByVal iFreqType As Integer) As Integer
        Select Case iFreqType
            Case 8, 16, 32
                Return nudFreq.Value
            Case Else
                Return 0
        End Select
    End Function
    Private Function GetFreqInterval(ByVal iFreqType As Integer) As Integer
        Select Case iFreqType
            Case 4
                Return nudFreq.Value
            Case 8
                Select Case Me.cboDay.SelectedIndex
                    Case 0 'T2
                        Return 2
                    Case 1 'T3 
                        Return 4
                    Case 2 'T4
                        Return 8
                    Case 3 'T5
                        Return 16
                    Case 4 'T6
                        Return 32
                    Case 5 'T7
                        Return 64
                    Case 6 'CN
                        Return 1
                End Select
            Case 16
                Return nudDate.Value
            Case Else
                Return 0
        End Select
    End Function
    Private Function GetScheduleString(ByVal iFreqType As Integer, _
                                       ByVal dDate As DateTime, _
                                       ByVal tTime As TimeSpan, _
                                       ByVal iFreqInterval As Integer, _
                                       ByVal iFreqRecurrenceFactor As Integer) As String
        Dim s As String
        Select Case iFreqType
            Case 4
                s = "Thực hiện " & iFreqInterval.ToString & " ngày/lần. Vào lúc " & tTime.ToString & ". Bắt đầu: " & Format(dDate, "dd/MM/yyyy")
            Case 8
                s = "Thực hiện " & iFreqRecurrenceFactor.ToString & " tuần/lần." & " " & _
                    "Vào lúc " & tTime.ToString & " - Thứ " & Interval2Day() & " hàng tuần. " & _
                    ". Bắt đầu: " & Format(dDate, "dd/MM/yyyy")
            Case 16
                s = "Thực hiện " & iFreqRecurrenceFactor.ToString & " tuần/lần." & " " & _
                    "Vào lúc " & tTime.ToString & " - Ngày " & iFreqInterval & " hàng tháng. " & _
                    ". Bắt đầu: " & Format(dDate, "dd/MM/yyyy")
        End Select
        Return s
    End Function
#End Region

#Region " Public readonly properties "
    Public ReadOnly Property FreqType() As Integer
        Get
            Return m_iFreqType
        End Get
    End Property
    Public ReadOnly Property FreqInterval() As Integer
        Get
            Return m_iFreqInterval
        End Get
    End Property
    Public ReadOnly Property FreqRecurrenceFactor() As Integer
        Get
            Return m_iFreqRecurrenceFactor
        End Get
    End Property
    Public ReadOnly Property FreqSubDayType() As Integer
        Get
            Return m_iFreqSubDayType
        End Get
    End Property
    Public ReadOnly Property FreqSubDayInterval() As Integer
        Get
            Return m_iFreqSubDayInterval
        End Get
    End Property
    Public ReadOnly Property ActiveStartDate() As Integer
        Get
            Return m_iActiveStartDate
        End Get
    End Property
    Public ReadOnly Property ActiveEndDate() As Integer
        Get
            Return m_iActiveEndDate
        End Get
    End Property
    Public ReadOnly Property ActiveStartTime() As Integer
        Get
            Return m_iActiveStartTime
        End Get
    End Property
    Public ReadOnly Property ActiveEndTime() As Integer
        Get
            Return m_iActiveEndTime
        End Get
    End Property
    Public ReadOnly Property OKPressed() As Integer
        Get
            Return m_bOK
        End Get
    End Property
    Public ReadOnly Property ScheduleString() As String
        Get
            Return m_sScheduleString
        End Get
    End Property
#End Region
    
    Public Function TestConn() As Boolean
        Try
            ' Query database

            Return True
        Catch ex As Exception
            Return False
        Finally
        End Try
    End Function
    Private Sub FrmLichSaoLuu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not TestConn() Then
            CMessageBox.Show("Không thể kết nối đến CSDL Database", "Bạn hãy kiểm tra lại máy chủ hoặc đường mạng.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
        End If


        With Me
            .dtpStartDate.Value = Now
            .dtpEndDate.Value = Now
            .dtpTime.Value = Now
            .dtpStartTime.Value = Now
            .dtpEndTime.Value = Now
            .cboUnit.SelectedIndex = 0
            .cboPhutGio.SelectedIndex = 0
        End With
    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        m_bOK = False
        Me.m_sScheduleString = ""
        Me.Close()
    End Sub

    
    Private Sub btnCapNhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapNhat.Click
        Try
            Dim sDailyFreq As String
            Dim sStartEndDate As String

            With Me
                .m_iFreqType = .GetFreqType
                .m_iFreqInterval = .GetFreqInterval(.m_iFreqType)
                .m_iFreqSubDayType = .GetFreqSubDayType()
                .m_iFreqSubDayInterval = .GetFreqSubDayInterval()
                .m_iFreqRecurrenceFactor = .GetFreqRecurrenceFactor(.m_iFreqType)
                .m_iActiveStartDate = .Date2Int(.dtpStartDate.Value)
                If Me.rdOnce.Checked Then
                    .m_iActiveStartTime = .Time2Int(.dtpTime.Value.TimeOfDay)
                    sDailyFreq = "Thực hiện 1 lần duy nhất vào lúc: " & .dtpTime.Value.TimeOfDay.ToString & "."
                Else
                    .m_iActiveStartTime = .Time2Int(.dtpStartTime.Value.TimeOfDay)
                    sDailyFreq = "Thực hiện vào mỗi " & .m_iFreqSubDayInterval & " " & .cboPhutGio.Text & " một lần."
                End If
                If Me.rdEndDate.Checked Then
                    .m_iActiveEndDate = .Date2Int(.dtpEndDate.Value)
                    sStartEndDate = "Thời gian bắt đầu lúc: " & .dtpStartDate.Text & ". Kết thúc lúc: " & .dtpEndDate.Text & "."
                Else
                    .m_iActiveEndDate = 99991231
                    sStartEndDate = "Thời gian bắt đầu lúc: " & .dtpStartDate.Text & ". Không giới hạn ngày kết thúc."
                End If

                .m_sScheduleString = "Thực hiện sao lưu dữ liệu " & Me.nudFreq.Value & " ngày/lần. " & sDailyFreq & sStartEndDate
                '.m_sScheduleString = GetScheduleString(m_iFreqType, dtpStartDate.Value, .dtpTime.Value.TimeOfDay, m_iFreqInterval, m_iFreqRecurrenceFactor)
                .m_bOK = True
                .Close()
            End With
        Catch ex As Exception
            CMessageBox.Show("Bạn chưa nhập thông tin về [Ngày bắt đầu thực thi]", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.dtpStartDate.Focus()
        End Try
    End Sub
End Class

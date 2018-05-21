Imports Ems_International_Logic.EMS
Public Class FrmCaKeToan
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
    Friend WithEvents btnChap_Nhan As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents dtpNgayKhaiThac As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents cbCa As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCaKeToan))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ca", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ca_Khai_Thac")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ca")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thu_Tu")
        Me.btnChap_Nhan = New Infragistics.Win.Misc.UltraButton
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.dtpNgayKhaiThac = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.cbCa = New Infragistics.Win.UltraWinGrid.UltraCombo
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.dtpNgayKhaiThac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnChap_Nhan
        '
        Me.btnChap_Nhan.AccessibleDescription = resources.GetString("btnChap_Nhan.AccessibleDescription")
        Me.btnChap_Nhan.AccessibleName = resources.GetString("btnChap_Nhan.AccessibleName")
        Me.btnChap_Nhan.Anchor = CType(resources.GetObject("btnChap_Nhan.Anchor"), System.Windows.Forms.AnchorStyles)
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.btnChap_Nhan.Appearance = Appearance1
        Me.btnChap_Nhan.AutoSize = CType(resources.GetObject("btnChap_Nhan.AutoSize"), Boolean)
        Me.btnChap_Nhan.BackgroundImage = CType(resources.GetObject("btnChap_Nhan.BackgroundImage"), System.Drawing.Image)
        Me.btnChap_Nhan.Dock = CType(resources.GetObject("btnChap_Nhan.Dock"), System.Windows.Forms.DockStyle)
        Me.btnChap_Nhan.Enabled = CType(resources.GetObject("btnChap_Nhan.Enabled"), Boolean)
        Me.btnChap_Nhan.Font = CType(resources.GetObject("btnChap_Nhan.Font"), System.Drawing.Font)
        Me.btnChap_Nhan.ImeMode = CType(resources.GetObject("btnChap_Nhan.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnChap_Nhan.Location = CType(resources.GetObject("btnChap_Nhan.Location"), System.Drawing.Point)
        Me.btnChap_Nhan.Name = "btnChap_Nhan"
        Me.btnChap_Nhan.RightToLeft = CType(resources.GetObject("btnChap_Nhan.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnChap_Nhan.Size = CType(resources.GetObject("btnChap_Nhan.Size"), System.Drawing.Size)
        Me.btnChap_Nhan.TabIndex = CType(resources.GetObject("btnChap_Nhan.TabIndex"), Integer)
        Me.btnChap_Nhan.Text = resources.GetString("btnChap_Nhan.Text")
        Me.btnChap_Nhan.Visible = CType(resources.GetObject("btnChap_Nhan.Visible"), Boolean)
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.AccessibleDescription = resources.GetString("UltraGroupBox1.AccessibleDescription")
        Me.UltraGroupBox1.AccessibleName = resources.GetString("UltraGroupBox1.AccessibleName")
        Me.UltraGroupBox1.Anchor = CType(resources.GetObject("UltraGroupBox1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox1.BackgroundImage = CType(resources.GetObject("UltraGroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox1.Controls.Add(Me.dtpNgayKhaiThac)
        Me.UltraGroupBox1.Controls.Add(Me.cbCa)
        Me.UltraGroupBox1.Dock = CType(resources.GetObject("UltraGroupBox1.Dock"), System.Windows.Forms.DockStyle)
        Me.UltraGroupBox1.Enabled = CType(resources.GetObject("UltraGroupBox1.Enabled"), Boolean)
        Me.UltraGroupBox1.Font = CType(resources.GetObject("UltraGroupBox1.Font"), System.Drawing.Font)
        Me.UltraGroupBox1.ImeMode = CType(resources.GetObject("UltraGroupBox1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.UltraGroupBox1.Location = CType(resources.GetObject("UltraGroupBox1.Location"), System.Drawing.Point)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.RightToLeft = CType(resources.GetObject("UltraGroupBox1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.UltraGroupBox1.Size = CType(resources.GetObject("UltraGroupBox1.Size"), System.Drawing.Size)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = CType(resources.GetObject("UltraGroupBox1.TabIndex"), Integer)
        Me.UltraGroupBox1.Text = resources.GetString("UltraGroupBox1.Text")
        Me.UltraGroupBox1.Visible = CType(resources.GetObject("UltraGroupBox1.Visible"), Boolean)
        '
        'UltraLabel2
        '
        Me.UltraLabel2.AccessibleDescription = resources.GetString("UltraLabel2.AccessibleDescription")
        Me.UltraLabel2.AccessibleName = resources.GetString("UltraLabel2.AccessibleName")
        Me.UltraLabel2.Anchor = CType(resources.GetObject("UltraLabel2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.UltraLabel2.AutoSize = CType(resources.GetObject("UltraLabel2.AutoSize"), Boolean)
        Me.UltraLabel2.BackgroundImage = CType(resources.GetObject("UltraLabel2.BackgroundImage"), System.Drawing.Image)
        Me.UltraLabel2.Dock = CType(resources.GetObject("UltraLabel2.Dock"), System.Windows.Forms.DockStyle)
        Me.UltraLabel2.Enabled = CType(resources.GetObject("UltraLabel2.Enabled"), Boolean)
        Me.UltraLabel2.Font = CType(resources.GetObject("UltraLabel2.Font"), System.Drawing.Font)
        Me.UltraLabel2.ImeMode = CType(resources.GetObject("UltraLabel2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.UltraLabel2.Location = CType(resources.GetObject("UltraLabel2.Location"), System.Drawing.Point)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.RightToLeft = CType(resources.GetObject("UltraLabel2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.UltraLabel2.Size = CType(resources.GetObject("UltraLabel2.Size"), System.Drawing.Size)
        Me.UltraLabel2.TabIndex = CType(resources.GetObject("UltraLabel2.TabIndex"), Integer)
        Me.UltraLabel2.Text = resources.GetString("UltraLabel2.Text")
        Me.UltraLabel2.Visible = CType(resources.GetObject("UltraLabel2.Visible"), Boolean)
        '
        'UltraLabel1
        '
        Me.UltraLabel1.AccessibleDescription = resources.GetString("UltraLabel1.AccessibleDescription")
        Me.UltraLabel1.AccessibleName = resources.GetString("UltraLabel1.AccessibleName")
        Me.UltraLabel1.Anchor = CType(resources.GetObject("UltraLabel1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.UltraLabel1.AutoSize = CType(resources.GetObject("UltraLabel1.AutoSize"), Boolean)
        Me.UltraLabel1.BackgroundImage = CType(resources.GetObject("UltraLabel1.BackgroundImage"), System.Drawing.Image)
        Me.UltraLabel1.Dock = CType(resources.GetObject("UltraLabel1.Dock"), System.Windows.Forms.DockStyle)
        Me.UltraLabel1.Enabled = CType(resources.GetObject("UltraLabel1.Enabled"), Boolean)
        Me.UltraLabel1.Font = CType(resources.GetObject("UltraLabel1.Font"), System.Drawing.Font)
        Me.UltraLabel1.ImeMode = CType(resources.GetObject("UltraLabel1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.UltraLabel1.Location = CType(resources.GetObject("UltraLabel1.Location"), System.Drawing.Point)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.RightToLeft = CType(resources.GetObject("UltraLabel1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.UltraLabel1.Size = CType(resources.GetObject("UltraLabel1.Size"), System.Drawing.Size)
        Me.UltraLabel1.TabIndex = CType(resources.GetObject("UltraLabel1.TabIndex"), Integer)
        Me.UltraLabel1.Text = resources.GetString("UltraLabel1.Text")
        Me.UltraLabel1.Visible = CType(resources.GetObject("UltraLabel1.Visible"), Boolean)
        '
        'dtpNgayKhaiThac
        '
        Me.dtpNgayKhaiThac.AccessibleDescription = resources.GetString("dtpNgayKhaiThac.AccessibleDescription")
        Me.dtpNgayKhaiThac.AccessibleName = resources.GetString("dtpNgayKhaiThac.AccessibleName")
        Me.dtpNgayKhaiThac.Anchor = CType(resources.GetObject("dtpNgayKhaiThac.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.dtpNgayKhaiThac.BackgroundImage = CType(resources.GetObject("dtpNgayKhaiThac.BackgroundImage"), System.Drawing.Image)
        Me.dtpNgayKhaiThac.Dock = CType(resources.GetObject("dtpNgayKhaiThac.Dock"), System.Windows.Forms.DockStyle)
        Me.dtpNgayKhaiThac.Enabled = CType(resources.GetObject("dtpNgayKhaiThac.Enabled"), Boolean)
        Me.dtpNgayKhaiThac.Font = CType(resources.GetObject("dtpNgayKhaiThac.Font"), System.Drawing.Font)
        Me.dtpNgayKhaiThac.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpNgayKhaiThac.ImeMode = CType(resources.GetObject("dtpNgayKhaiThac.ImeMode"), System.Windows.Forms.ImeMode)
        Me.dtpNgayKhaiThac.Location = CType(resources.GetObject("dtpNgayKhaiThac.Location"), System.Drawing.Point)
        Me.dtpNgayKhaiThac.Name = "dtpNgayKhaiThac"
        Me.dtpNgayKhaiThac.RightToLeft = CType(resources.GetObject("dtpNgayKhaiThac.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.dtpNgayKhaiThac.Size = CType(resources.GetObject("dtpNgayKhaiThac.Size"), System.Drawing.Size)
        Me.dtpNgayKhaiThac.TabIndex = CType(resources.GetObject("dtpNgayKhaiThac.TabIndex"), Integer)
        Me.dtpNgayKhaiThac.Visible = CType(resources.GetObject("dtpNgayKhaiThac.Visible"), Boolean)
        '
        'cbCa
        '
        Me.cbCa.AccessibleDescription = resources.GetString("cbCa.AccessibleDescription")
        Me.cbCa.AccessibleName = resources.GetString("cbCa.AccessibleName")
        Me.cbCa.Anchor = CType(resources.GetObject("cbCa.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cbCa.BackgroundImage = CType(resources.GetObject("cbCa.BackgroundImage"), System.Drawing.Image)
        Me.cbCa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridBand1.AddButtonCaption = resources.GetString("UltraGridBand1.AddButtonCaption")
        UltraGridBand1.AddButtonToolTipText = resources.GetString("UltraGridBand1.AddButtonToolTipText")
        UltraGridColumn1.Format = resources.GetString("UltraGridColumn1.Format")
        UltraGridColumn1.Header.Caption = resources.GetString("resource.Caption")
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.MaskInput = resources.GetString("UltraGridColumn1.MaskInput")
        UltraGridColumn1.NullText = resources.GetString("UltraGridColumn1.NullText")
        UltraGridColumn2.Format = resources.GetString("UltraGridColumn2.Format")
        UltraGridColumn2.Header.Caption = resources.GetString("resource.Caption1")
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn2.MaskInput = resources.GetString("UltraGridColumn2.MaskInput")
        UltraGridColumn2.NullText = resources.GetString("UltraGridColumn2.NullText")
        UltraGridColumn3.Format = resources.GetString("UltraGridColumn3.Format")
        UltraGridColumn3.Header.Caption = resources.GetString("resource.Caption2")
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.MaskInput = resources.GetString("UltraGridColumn3.MaskInput")
        UltraGridColumn3.NullText = resources.GetString("UltraGridColumn3.NullText")
        UltraGridColumn4.Format = resources.GetString("UltraGridColumn4.Format")
        UltraGridColumn4.Header.Caption = resources.GetString("resource.Caption3")
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn4.MaskInput = resources.GetString("UltraGridColumn4.MaskInput")
        UltraGridColumn4.NullText = resources.GetString("UltraGridColumn4.NullText")
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        UltraGridBand1.SummaryFooterCaption = resources.GetString("UltraGridBand1.SummaryFooterCaption")
        Me.cbCa.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.cbCa.DisplayMember = "Ca"
        Me.cbCa.Dock = CType(resources.GetObject("cbCa.Dock"), System.Windows.Forms.DockStyle)
        Me.cbCa.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cbCa.Enabled = CType(resources.GetObject("cbCa.Enabled"), Boolean)
        Me.cbCa.Font = CType(resources.GetObject("cbCa.Font"), System.Drawing.Font)
        Me.cbCa.ImeMode = CType(resources.GetObject("cbCa.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cbCa.Location = CType(resources.GetObject("cbCa.Location"), System.Drawing.Point)
        Me.cbCa.Name = "cbCa"
        Me.cbCa.RightToLeft = CType(resources.GetObject("cbCa.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.cbCa.Size = CType(resources.GetObject("cbCa.Size"), System.Drawing.Size)
        Me.cbCa.TabIndex = CType(resources.GetObject("cbCa.TabIndex"), Integer)
        Me.cbCa.Text = resources.GetString("cbCa.Text")
        Me.cbCa.ValueMember = "Thu_Tu"
        Me.cbCa.Visible = CType(resources.GetObject("cbCa.Visible"), Boolean)
        '
        'FrmCaKeToan
        '
        Me.AccessibleDescription = resources.GetString("$this.AccessibleDescription")
        Me.AccessibleName = resources.GetString("$this.AccessibleName")
        Me.AutoScaleBaseSize = CType(resources.GetObject("$this.AutoScaleBaseSize"), System.Drawing.Size)
        Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"), Boolean)
        Me.AutoScrollMargin = CType(resources.GetObject("$this.AutoScrollMargin"), System.Drawing.Size)
        Me.AutoScrollMinSize = CType(resources.GetObject("$this.AutoScrollMinSize"), System.Drawing.Size)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = CType(resources.GetObject("$this.ClientSize"), System.Drawing.Size)
        Me.ControlBox = False
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.btnChap_Nhan)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximizeBox = False
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimizeBox = False
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "FrmCaKeToan"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.dtpNgayKhaiThac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Khai báo biến"
    Dim myCa As New Ma_Ca(GConnectionString)
    Dim myCaSanXuat As New Ca_San_Xuat(GConnectionString)
    Dim myCaSanXuatChiTiet As New Ca_San_Xuat_Chi_Tiet
    Dim Ham_Dung_Chung As New Ham_Dung_Chung
#End Region


    Private Sub DataGridBinding()
        If myCaSanXuatChiTiet.Ngay_Khai_Thac = 0 Then
            dtpNgayKhaiThac.Value = Date.Now
        Else
            dtpNgayKhaiThac.Value = Ham_Dung_Chung.ConvertIntToDate(myCaSanXuatChiTiet.Ngay_Khai_Thac)
        End If
        cbCa.DataSource = myCa.Lay_Boi_Ma_Bc_Khai_Thac(GBuu_Cuc_Khai_Thac)
        cbCa.DataBind()
        If cbCa.Rows.Count > 0 Then
            cbCa.Value = myCaSanXuatChiTiet.Thu_Tu
        Else
            CMessageBox.Show("Không tồn tại loại ca làm việc cho bưu cục " & GBuu_Cuc_Khai_Thac & vbNewLine & "Hãy nhập loại ca làm việc cho bưu cục ở mục Mã ca", "Thông báo")
            Dim FrmDanhMuc As New FrmCacBangDanhMuc
            FrmDanhMuc.ShowDialog()
            DataGridBinding()
        End If
    End Sub

    Private Sub FrmCaKeToan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myCaSanXuatChiTiet = myCaSanXuat.Lay(GId_Ca)
        DataGridBinding()
    End Sub

    Private Sub btnChap_Nhan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChap_Nhan.Click
        Dim DateNow As Integer
        DateNow = Ham_Dung_Chung.ConvertDateToInt(Now.Date)
        If (DateNow < Ham_Dung_Chung.ConvertDateToInt(dtpNgayKhaiThac.Value)) Then
            CMessageBox.Show("Ngày khai thác không thể lớn hơn hệ thống")
            Exit Sub
        End If
        GId_Ca = CreateId_Ca(GBuu_Cuc_Khai_Thac, CInt(Ham_Dung_Chung.ConvertDateToInt(dtpNgayKhaiThac.Value)), CInt(cbCa.Value))
        'Kiểm tra Ngày ca khai thác thực sự có tồn tại không
        If myCaSanXuat.Ca_San_Xuat_Kiem_Tra(GBuu_Cuc_Khai_Thac, Ham_Dung_Chung.ConvertDateToInt(dtpNgayKhaiThac.Value), cbCa.Value) = False Then
            CMessageBox.Show("Ngày và ca khai thác này không tồn tại !" & vbNewLine & "Xin mời chọn ngày hoặc ca khai thác khác.", "Thông báo")
            '            Close()
            Exit Sub
        End If

        If GId_Ca = 0 Or GId_Ca Is Nothing Then
            CMessageBox.Show("Bạn nhập ngày hoặc ca khai thác không đúng định dạng !", "Thông báo")
            Exit Sub
        Else
            Me.Close()
            Me.Dispose()
        End If
    End Sub

End Class

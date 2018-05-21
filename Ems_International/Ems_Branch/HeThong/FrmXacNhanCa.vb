Imports Ems_International_Logic.EMS
Public Class FrmXacNhanCa
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbCa As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents dtpNgayKhaiThac As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpTuNgay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTuGio As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtDenGio As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents btnCaMoi As Infragistics.Win.Misc.UltraButton
    Friend WithEvents dtpDenNgay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents btnHieuChinhCa As Infragistics.Win.Misc.UltraButton
    Friend WithEvents PrbTien_Trinh As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    Friend WithEvents lblTien_Trinh As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmXacNhanCa))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ca", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ca_Khai_Thac")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ca")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thu_Tu")
        Me.Label4 = New System.Windows.Forms.Label
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.btnHieuChinhCa = New Infragistics.Win.Misc.UltraButton
        Me.btnCaMoi = New Infragistics.Win.Misc.UltraButton
        Me.txtDenGio = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.txtTuGio = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpDenNgay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpTuNgay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpNgayKhaiThac = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.cbCa = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.Label6 = New System.Windows.Forms.Label
        Me.PrbTien_Trinh = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar
        Me.lblTien_Trinh = New System.Windows.Forms.Label
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.dtpDenNgay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTuNgay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpNgayKhaiThac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(162, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 26)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Xác nhận ca"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.btnHieuChinhCa)
        Me.UltraGroupBox1.Controls.Add(Me.btnCaMoi)
        Me.UltraGroupBox1.Controls.Add(Me.txtDenGio)
        Me.UltraGroupBox1.Controls.Add(Me.txtTuGio)
        Me.UltraGroupBox1.Controls.Add(Me.Label7)
        Me.UltraGroupBox1.Controls.Add(Me.Label5)
        Me.UltraGroupBox1.Controls.Add(Me.dtpDenNgay)
        Me.UltraGroupBox1.Controls.Add(Me.Label3)
        Me.UltraGroupBox1.Controls.Add(Me.dtpTuNgay)
        Me.UltraGroupBox1.Controls.Add(Me.Label2)
        Me.UltraGroupBox1.Controls.Add(Me.Label1)
        Me.UltraGroupBox1.Controls.Add(Me.dtpNgayKhaiThac)
        Me.UltraGroupBox1.Controls.Add(Me.cbCa)
        Me.UltraGroupBox1.Controls.Add(Me.Label6)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 48)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(452, 184)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 48
        Me.UltraGroupBox1.Text = "Thông tin xác nhận"
        '
        'btnHieuChinhCa
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.btnHieuChinhCa.Appearance = Appearance1
        Me.btnHieuChinhCa.Location = New System.Drawing.Point(264, 136)
        Me.btnHieuChinhCa.Name = "btnHieuChinhCa"
        Me.btnHieuChinhCa.Size = New System.Drawing.Size(142, 32)
        Me.btnHieuChinhCa.TabIndex = 62
        Me.btnHieuChinhCa.Text = "Hiệu chỉnh ca hiện tại"
        '
        'btnCaMoi
        '
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.btnCaMoi.Appearance = Appearance2
        Me.btnCaMoi.Location = New System.Drawing.Point(40, 136)
        Me.btnCaMoi.Name = "btnCaMoi"
        Me.btnCaMoi.Size = New System.Drawing.Size(208, 32)
        Me.btnCaMoi.TabIndex = 61
        Me.btnCaMoi.Text = "Kết thúc ca hiện tại && tạo ca mới"
        '
        'txtDenGio
        '
        Me.txtDenGio.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtDenGio.InputMask = "##:##"
        Me.txtDenGio.Location = New System.Drawing.Point(312, 88)
        Me.txtDenGio.Name = "txtDenGio"
        Me.txtDenGio.TabIndex = 60
        Me.txtDenGio.Text = ":"
        '
        'txtTuGio
        '
        Me.txtTuGio.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtTuGio.InputMask = "##:##"
        Me.txtTuGio.Location = New System.Drawing.Point(312, 56)
        Me.txtTuGio.Name = "txtTuGio"
        Me.txtTuGio.TabIndex = 59
        Me.txtTuGio.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(224, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 18)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Giờ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(224, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 18)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Giờ"
        '
        'dtpDenNgay
        '
        Me.dtpDenNgay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpDenNgay.Location = New System.Drawing.Point(128, 88)
        Me.dtpDenNgay.Name = "dtpDenNgay"
        Me.dtpDenNgay.Size = New System.Drawing.Size(88, 21)
        Me.dtpDenNgay.TabIndex = 56
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 18)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Đến ngày"
        '
        'dtpTuNgay
        '
        Me.dtpTuNgay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpTuNgay.Location = New System.Drawing.Point(128, 56)
        Me.dtpTuNgay.Name = "dtpTuNgay"
        Me.dtpTuNgay.Size = New System.Drawing.Size(88, 21)
        Me.dtpTuNgay.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 18)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Từ ngày"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(224, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Ca khai thác"
        '
        'dtpNgayKhaiThac
        '
        Me.dtpNgayKhaiThac.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpNgayKhaiThac.Location = New System.Drawing.Point(128, 24)
        Me.dtpNgayKhaiThac.Name = "dtpNgayKhaiThac"
        Me.dtpNgayKhaiThac.Size = New System.Drawing.Size(88, 21)
        Me.dtpNgayKhaiThac.TabIndex = 51
        '
        'cbCa
        '
        Me.cbCa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.Caption = "Mã bưu cục"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.Caption = "Ca khai thác"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        Me.cbCa.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.cbCa.DisplayMember = "Ca"
        Me.cbCa.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cbCa.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCa.Location = New System.Drawing.Point(312, 24)
        Me.cbCa.Name = "cbCa"
        Me.cbCa.Size = New System.Drawing.Size(104, 21)
        Me.cbCa.TabIndex = 50
        Me.cbCa.ValueMember = "Ca_Khai_Thac"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 18)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Ngày khai thác"
        '
        'PrbTien_Trinh
        '
        Me.PrbTien_Trinh.BorderStyle = Infragistics.Win.UIElementBorderStyle.InsetSoft
        Me.PrbTien_Trinh.Location = New System.Drawing.Point(8, 260)
        Me.PrbTien_Trinh.Maximum = 10000
        Me.PrbTien_Trinh.Name = "PrbTien_Trinh"
        Me.PrbTien_Trinh.Size = New System.Drawing.Size(456, 32)
        Me.PrbTien_Trinh.Step = 1
        Me.PrbTien_Trinh.TabIndex = 69
        Me.PrbTien_Trinh.Text = "[Formatted]"
        '
        'lblTien_Trinh
        '
        Me.lblTien_Trinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTien_Trinh.Location = New System.Drawing.Point(8, 244)
        Me.lblTien_Trinh.Name = "lblTien_Trinh"
        Me.lblTien_Trinh.Size = New System.Drawing.Size(456, 16)
        Me.lblTien_Trinh.TabIndex = 68
        Me.lblTien_Trinh.Text = "Tiến trình thực hiện truyền lại dữ liệu ca khai thác khi tạo ca mới"
        '
        'FrmXacNhanCa
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(472, 301)
        Me.Controls.Add(Me.PrbTien_Trinh)
        Me.Controls.Add(Me.lblTien_Trinh)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmXacNhanCa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Xác nhận ca"
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.dtpDenNgay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTuNgay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpNgayKhaiThac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public GId_Ca_Lien_Truoc As String
    Dim myCa As New Ma_Ca(GConnectionString)
    Dim myCaSanXuat As New Ca_San_Xuat(GConnectionString)
    Dim myCaSanXuatChiTiet As New Ca_San_Xuat_Chi_Tiet
    Dim Ham_Dung_Chung As New Ham_Dung_Chung
    Dim myChuyen_Thu_Di As New Chuyen_Thu_Di(GConnectionString)
    Dim myChuyen_Thu_Den As New Chuyen_Thu_Den(GConnectionString)
    Dim myE2_Den As New E2_Den(GConnectionString)
    Dim myE2_Di As New E2_Di(GConnectionString)
    Dim myE1_Den As New E1_Den(GConnectionString)
    Dim myE1_Di As New E1_Di(GConnectionString)
    Dim myUtility As New Ems_Utility.Ems_Utility.Ems_MSMQ(GConnectionString)


    Private Sub DataGridBinding()
        cbCa.DataSource = myCa.Lay_Boi_Ma_Bc_Khai_Thac(GBuu_Cuc_Khai_Thac)
        cbCa.DataBind()
        If cbCa.Rows.Count > 0 Then
            cbCa.Value = cbCa.Rows(0).Cells(0).Value
        Else
            CMessageBox.Show("Không tồn tại loại ca làm việc cho bưu cục " & GBuu_Cuc_Khai_Thac & vbNewLine & "Hãy nhập loại ca làm việc cho bưu cục ở mục Mã ca", "Thông báo")
            Dim FrmDanhMuc As New FrmCacBangDanhMuc
            FrmDanhMuc.ShowDialog()
            DataGridBinding()
        End If
    End Sub
    Private Sub FrmXacNhanCa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridBinding()
        If GLan_Dau_Tien Then
            btnHieuChinhCa.Enabled = False
            btnCaMoi.Enabled = True
        Else
            btnHieuChinhCa.Enabled = True
            btnCaMoi.Enabled = True
        End If
        myCaSanXuatChiTiet = myCaSanXuat.Lay(GId_Ca)
        If myCaSanXuatChiTiet.Id_Ca.Trim <> "" Then
            dtpNgayKhaiThac.Value = Ham_Dung_Chung.ConvertIntToDate(myCaSanXuatChiTiet.Ngay_Khai_Thac)
            cbCa.Value = myCaSanXuatChiTiet.Ca_Khai_Thac
            dtpTuNgay.Value = Ham_Dung_Chung.ConvertIntToDate(myCaSanXuatChiTiet.Tu_Ngay)
            dtpDenNgay.Value = Ham_Dung_Chung.ConvertIntToDate(myCaSanXuatChiTiet.Den_Ngay)
            txtTuGio.Text = Ham_Dung_Chung.ConvertIntToTime(myCaSanXuatChiTiet.Tu_Gio)
            txtDenGio.Text = Ham_Dung_Chung.ConvertIntToTime(myCaSanXuatChiTiet.Den_Gio)
        Else
            myCaSanXuatChiTiet = myCaSanXuat.Lay_Boi_Ma_Bc_Khai_Thac_Dang_Su_Dung(GBuu_Cuc_Khai_Thac)
            If myCaSanXuatChiTiet.Id_Ca.Trim <> "" Then
                dtpNgayKhaiThac.Value = Ham_Dung_Chung.ConvertIntToDate(myCaSanXuatChiTiet.Ngay_Khai_Thac)
                cbCa.Value = myCaSanXuatChiTiet.Ca_Khai_Thac
                dtpTuNgay.Value = Ham_Dung_Chung.ConvertIntToDate(myCaSanXuatChiTiet.Tu_Ngay)
                dtpDenNgay.Value = Ham_Dung_Chung.ConvertIntToDate(myCaSanXuatChiTiet.Den_Ngay)
                txtTuGio.Text = Ham_Dung_Chung.ConvertIntToTime(myCaSanXuatChiTiet.Tu_Gio)
                txtDenGio.Text = Ham_Dung_Chung.ConvertIntToTime(myCaSanXuatChiTiet.Den_Gio)
            End If
        End If
        dtpNgayKhaiThac.Focus()
    End Sub
    Private Function Kiem_Tra_Dieu_Kien_Logic() As Boolean
        If Ham_Dung_Chung.ConvertIntToDate(Ham_Dung_Chung.ConvertDateToInt(dtpTuNgay.Value), Ham_Dung_Chung.ConvertTimeToInt(txtTuGio.Value)) > Ham_Dung_Chung.ConvertIntToDate(Ham_Dung_Chung.ConvertDateToInt(dtpDenNgay.Value), Ham_Dung_Chung.ConvertTimeToInt(txtDenGio.Value)) Then
            Return False
        End If
        Return True
    End Function

    Private Sub btnCaMoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCaMoi.Click
        Try
            If txtTuGio.Text.Length <> 5 Then
                CMessageBox.Show("Sai định dạng từ giờ !!!")
                txtTuGio.Focus()
                Exit Sub
            End If
            If txtDenGio.Text.Length <> 5 Then
                CMessageBox.Show("Sai định dạng đến giờ !!!")
                txtDenGio.Focus()
                Exit Sub
            End If
            If Ham_Dung_Chung.ConvertDateToInt(dtpNgayKhaiThac.Value) <> Ham_Dung_Chung.ConvertDateToInt(Now) Then
                CMessageBox.Show("Tạo mới 1 ca làm việc thì ca đó phải có ngày khai thác là ngày hiện tại", "Thông báo")
                Exit Sub
            End If
            If Kiem_Tra_Dieu_Kien_Logic() = False Then
                CMessageBox.Show("Hãy kiểm tra lại tính logic của các thông tin về thời gian !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            myCaSanXuatChiTiet = myCaSanXuat.Lay(GBuu_Cuc_Khai_Thac.ToString & Ham_Dung_Chung.ConvertDateToInt(dtpNgayKhaiThac.Value).ToString & cbCa.Rows(cbCa.ActiveRow.Index).Cells("Thu_Tu").Text)
            If myCaSanXuatChiTiet.Ca_Khai_Thac <> 0 And myCaSanXuatChiTiet.Ma_Bc_Khai_Thac <> 0 And myCaSanXuatChiTiet.Ngay_Khai_Thac <> 0 Then
                CMessageBox.Show("Ngày khai thác và ca làm việc đã trùng với một ca trước đó !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If Ham_Dung_Chung.ConvertIntToDate(Ham_Dung_Chung.ConvertDateToInt(dtpTuNgay.Value), Ham_Dung_Chung.ConvertTimeToInt(txtTuGio.Value)) > Ham_Dung_Chung.ConvertIntToDate(Ham_Dung_Chung.ConvertDateToInt(Now), Ham_Dung_Chung.ConvertTimeToInt(Now)) Or Ham_Dung_Chung.ConvertIntToDate(Ham_Dung_Chung.ConvertDateToInt(Now), Ham_Dung_Chung.ConvertTimeToInt(Now)) > Ham_Dung_Chung.ConvertIntToDate(Ham_Dung_Chung.ConvertDateToInt(dtpDenNgay.Value), Ham_Dung_Chung.ConvertTimeToInt(txtDenGio.Value)) Then
                CMessageBox.Show("Ngày giờ hiện tại phải thuộc khoảng từ ngày đến ngày!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If CMessageBox.Show("Bạn có thực sự muốn kết thúc ca hiện tại để xác lập ca làm việc mới ???" & vbNewLine & "Hãy chờ trong một vài phút, chương trình sẽ thực hiện truyền lại toàn bộ số liệu của ca khai thác trước đó và tạo ca khai thác mới.", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.ActiveForm.Cursor.Current = Cursors.WaitCursor
                'Xóa dữ liệu trong bảng thông tin truyền trong khoảng thời gian 10 ngày trở về trước
                Dim myThong_Tin_Truyen As New Thong_Tin_Truyen(GConnectionString)
                Dim myHam_Dung_Chung As New Ham_Dung_Chung
                myThong_Tin_Truyen.Xoa_Tu_Ngay_Den_Ngay(myHam_Dung_Chung.MinusIntDate(myHam_Dung_Chung.ConvertDateToInt(Now), 5), myHam_Dung_Chung.ConvertDateToInt(Now))
                'Truyền lại dữ liệu
                Danh_Sach_Chuyen_Thu_Den_Trong_Ca_Can_Truyen(GId_Ca_Lien_Truoc)
                Me.ActiveForm.Cursor.Current = Cursors.WaitCursor
                Danh_Sach_Chuyen_Thu_Di_Trong_Ca_Can_Truyen(GId_Ca_Lien_Truoc)
                Me.ActiveForm.Cursor.Current = Cursors.Default

                'Kết thúc ca cũ và tạo ca mới
                myCaSanXuat.Cap_Nhat_Them(GBuu_Cuc_Khai_Thac.ToString & Ham_Dung_Chung.ConvertDateToInt(dtpNgayKhaiThac.Value).ToString & cbCa.Rows(cbCa.ActiveRow.Index).Cells("Thu_Tu").Text, GBuu_Cuc_Khai_Thac, Ham_Dung_Chung.ConvertDateToInt(dtpNgayKhaiThac.Value), Convert.ToInt32(cbCa.Value), Ham_Dung_Chung.ConvertDateToInt(dtpTuNgay.Value), Ham_Dung_Chung.ConvertTimeToInt(txtTuGio.Text), Ham_Dung_Chung.ConvertDateToInt(dtpDenNgay.Value), Ham_Dung_Chung.ConvertTimeToInt(txtDenGio.Text), True, Convert.ToInt32(cbCa.Rows(cbCa.ActiveRow.Index).Cells("Thu_Tu").Value))
                'Hien thong tin tren label Tien trinh
                lblTien_Trinh.Text = "Truyền dữ liệu và tạo ca mới thành công!!!"
                lblTien_Trinh.Refresh()

                GId_Ca = GBuu_Cuc_Khai_Thac.ToString & Ham_Dung_Chung.ConvertDateToInt(dtpNgayKhaiThac.Value).ToString & cbCa.Value
                CMessageBox.Show("Đã thêm mới ca thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnHieuChinhCa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHieuChinhCa.Click
        Try
            myCaSanXuatChiTiet = myCaSanXuat.Lay(GId_Ca)
            If myCaSanXuatChiTiet.Id_Ca.Trim <> "" Then
                If Ham_Dung_Chung.ConvertDateToInt(dtpNgayKhaiThac.Value) <> myCaSanXuatChiTiet.Ngay_Khai_Thac Then
                    CMessageBox.Show("Không được hiệu chỉnh ngày khai thác !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    dtpNgayKhaiThac.Value = Ham_Dung_Chung.ConvertIntToDate(myCaSanXuatChiTiet.Ngay_Khai_Thac)
                    Exit Sub
                End If
            Else
                CMessageBox.Show("Không tồn tại ca nào để hiệu chỉnh !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            'Không cho phép hiệu chỉnh thứ tự ca
            If myCaSanXuatChiTiet.Thu_Tu <> Convert.ToInt32(cbCa.Rows(cbCa.ActiveRow.Index).Cells("Thu_Tu").Text) Then
                CMessageBox.Show("Không được hiệu chỉnh mã ca khai thác !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If txtTuGio.Text.Length <> 5 Then
                CMessageBox.Show("Sai định dạng từ giờ !!!")
                txtTuGio.Focus()
                Exit Sub
            End If
            If txtDenGio.Text.Length <> 5 Then
                CMessageBox.Show("Sai định dạng đến giờ !!!")
                txtDenGio.Focus()
                Exit Sub
            End If
            If Kiem_Tra_Dieu_Kien_Logic() = False Then
                CMessageBox.Show("Hãy kiểm tra lại tính logic của các thông tin về thời gian !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            myCaSanXuat.Cap_Nhat(GId_Ca, GBuu_Cuc_Khai_Thac, Ham_Dung_Chung.ConvertDateToInt(dtpNgayKhaiThac.Value), Convert.ToInt32(cbCa.Value), Ham_Dung_Chung.ConvertDateToInt(dtpTuNgay.Value), Ham_Dung_Chung.ConvertTimeToInt(txtTuGio.Text), Ham_Dung_Chung.ConvertDateToInt(dtpDenNgay.Value), Ham_Dung_Chung.ConvertTimeToInt(txtDenGio.Text), True, Convert.ToInt32(cbCa.Rows(cbCa.ActiveRow.Index).Cells("Thu_Tu").Text))
            CMessageBox.Show("Đã cập nhật ca thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub dtpNgayKhaiThac_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpNgayKhaiThac.Validated
        dtpTuNgay.Value = dtpNgayKhaiThac.Value
        dtpDenNgay.Value = dtpNgayKhaiThac.Value
    End Sub

    Private Sub dtpNgayKhaiThac_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpNgayKhaiThac.ValueChanged
        dtpTuNgay.Value = dtpNgayKhaiThac.Value
        dtpDenNgay.Value = dtpNgayKhaiThac.Value
    End Sub


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
                    lblTien_Trinh.Text = "...Đang truyền dữ liệu đóng đi lên Center... :  " & m_Id_Chuyen_Thu
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
            Me.ActiveForm.Cursor.Current = Cursors.Default
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
                    lblTien_Trinh.Text = "...Đang truyền dữ liệu xác nhận đến lên Center...:  " & m_Id_Chuyen_Thu
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
            Me.ActiveForm.Cursor.Current = Cursors.Default
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

End Class

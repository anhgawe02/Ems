Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Ems_International_Logic.EMS
Public Class FrmNhapTyGia
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
    Friend WithEvents btnThoat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbNgayThang As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtTygia As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnCapNhat As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmNhapTyGia))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.btnThoat = New Infragistics.Win.Misc.UltraButton
        Me.btnCapNhat = New Infragistics.Win.Misc.UltraButton
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.cbNgayThang = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel
        Me.txtTygia = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        CType(Me.cbNgayThang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnThoat
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.btnThoat.Appearance = Appearance1
        Me.btnThoat.Location = New System.Drawing.Point(144, 128)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(88, 32)
        Me.btnThoat.TabIndex = 3
        Me.btnThoat.Text = "Thoát"
        '
        'btnCapNhat
        '
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.btnCapNhat.Appearance = Appearance2
        Me.btnCapNhat.Location = New System.Drawing.Point(48, 128)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(88, 32)
        Me.btnCapNhat.TabIndex = 2
        Me.btnCapNhat.Text = "Cập nhật"
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Location = New System.Drawing.Point(24, 32)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.TabIndex = 38
        Me.UltraLabel4.Text = "Ngày Tháng"
        '
        'cbNgayThang
        '
        Me.cbNgayThang.DateTime = New Date(2008, 9, 16, 0, 0, 0, 0)
        Me.cbNgayThang.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.cbNgayThang.Location = New System.Drawing.Point(144, 32)
        Me.cbNgayThang.Name = "cbNgayThang"
        Me.cbNgayThang.Size = New System.Drawing.Size(104, 21)
        Me.cbNgayThang.TabIndex = 0
        Me.cbNgayThang.Value = New Date(2008, 9, 16, 0, 0, 0, 0)
        '
        'UltraLabel11
        '
        Me.UltraLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(-94, 123)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(82, 23)
        Me.UltraLabel11.TabIndex = 105
        Me.UltraLabel11.Text = "Mã Số Túi"
        '
        'txtTygia
        '
        Me.txtTygia.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtTygia.InputMask = "99999"
        Me.txtTygia.Location = New System.Drawing.Point(144, 64)
        Me.txtTygia.Name = "txtTygia"
        Me.txtTygia.Size = New System.Drawing.Size(104, 20)
        Me.txtTygia.TabIndex = 1
        '
        'UltraLabel6
        '
        Me.UltraLabel6.Location = New System.Drawing.Point(24, 64)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(88, 23)
        Me.UltraLabel6.TabIndex = 106
        Me.UltraLabel6.Text = "Tỷ giá"
        '
        'FrmNhapTyGia
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(280, 173)
        Me.Controls.Add(Me.txtTygia)
        Me.Controls.Add(Me.UltraLabel6)
        Me.Controls.Add(Me.UltraLabel11)
        Me.Controls.Add(Me.UltraLabel4)
        Me.Controls.Add(Me.cbNgayThang)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Name = "FrmNhapTyGia"
        Me.Text = "Nhập tỷ giá USD"
        CType(Me.cbNgayThang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Khai báo"
    Dim myTy_Gia As New Ty_Gia(GConnectionString)
    Dim myHam_Dung_Chung As New Ham_Dung_Chung
#End Region

#Region "FrmNhapTyGia_Load"
    Private Sub FrmNhapTyGia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbNgayThang.Value = Today
        'Lấy tỷ giá của ngày gần nhất vào ô tỷ giá
        Dim myTy_Gia_Hom_Nay As Integer
        myTy_Gia_Hom_Nay = myTy_Gia.Lay_Ty_Gia_Theo_Ngay_Gan_Nhat(myHam_Dung_Chung.ConvertDateToInt(cbNgayThang.Value))
        txtTygia.Text = myTy_Gia_Hom_Nay
        txtTygia.Focus()
    End Sub
#End Region

#Region "Cập nhật tỷ giá"
    Private Sub btnCapNhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapNhat.Click
        Try
            'Không cập nhật tỷ giá cho ngày khác với ngày hiện tại
            If myHam_Dung_Chung.ConvertDateToInt(cbNgayThang.Value) <> myHam_Dung_Chung.ConvertDateToInt(Today) Then 'Nếu là ngày hôm trước
                If GUserAdmin = False Then 'Không phải là quản trị tuyệt đối
                    MessageBox.Show("Bạn chỉ có thể nhập tỷ giá cho ngày hôm nay!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    cbNgayThang.Focus()
                    Exit Sub
                Else 'Là quản trị tuyệt đối
                    If MessageBox.Show("Bạn không nên cập nhật lại tỷ giá cho ngày không phải là ngày hôm nay!!!" & vbNewLine & _
                                        "             Bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            'Kiểm tra xem tỷ giá nếu chênh lệch quá lớn thì cảnh báo
            'Lấy tỷ giá ngày gần nhất
            If txtTygia.Text <> "" Then
                Dim myToDay As Integer
                Dim myTy_Gia_Gan_Nhat As Integer
                Dim myTy_Gia_Hom_Nay As Integer
                myToDay = myHam_Dung_Chung.ConvertDateToInt(cbNgayThang.Value)
                myTy_Gia_Hom_Nay = CInt(txtTygia.Text)
                If (myTy_Gia_Hom_Nay > 50000) Or (myTy_Gia_Hom_Nay < 5000) Then 'Nếu tỷ giá quá lớn hoặc quá nhỏ
                    MessageBox.Show("Bạn nhập tỷ giá quá lớn hoặc quá nhỏ!!!" & vbNewLine & "Bạn hãy nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtTygia.Select()
                    Exit Sub
                Else
                    If myTy_Gia.Lay(myToDay).Ty_Gia = 0 Then 'Chưa có tỷ giá
                        myTy_Gia_Gan_Nhat = myTy_Gia.Lay_Ty_Gia_Theo_Ngay_Gan_Nhat(myToDay)
                        If (myTy_Gia_Hom_Nay - myTy_Gia_Gan_Nhat > 10000) Or (myTy_Gia_Gan_Nhat - myTy_Gia_Hom_Nay > 10000) Then
                            If MessageBox.Show("Tỷ giá nhập chênh lệch quá lớn với tỷ giá cũ" & vbNewLine & "Bạn có muốn nhập lại không???", _
                                                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                                txtTygia.Select()
                                Exit Sub
                            End If
                        End If
                    End If

                    myTy_Gia.Cap_Nhat_Them(myToDay, myTy_Gia_Hom_Nay)
                    If MessageBox.Show("  Đã cập nhật tỷ giá!" & vbNewLine & "Bạn có muốn thoát không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                        Close()
                    End If
                End If
            Else
                    MessageBox.Show("Bạn chưa nhập tỷ giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtTygia.Select()
                    Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "btnThoat_Click"
    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Close()
    End Sub
#End Region

#Region "cbNgayThang_AfterExitEditMode"
    Private Sub cbNgayThang_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbNgayThang.AfterExitEditMode
        txtTygia.Text = myTy_Gia.Lay_Ty_Gia_Theo_Ngay_Gan_Nhat(myHam_Dung_Chung.ConvertDateToInt(cbNgayThang.Value))
    End Sub
#End Region

#Region "KeyDown: SelectNextControl"
    Private Sub cbNgayThang_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbNgayThang.KeyDown, txtTygia.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter 'Key Enter
                Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
            Case Else
        End Select
    End Sub

    Private Sub btnCapNhat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnCapNhat.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter 'Key Enter
                Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
            Case Else
        End Select
    End Sub
#End Region

End Class

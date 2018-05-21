Imports Ems_International_Logic.EMS
Imports Infragistics.Win.UltraWinGrid
Public Class FrmTimKiemDanhMuc
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
    Friend WithEvents btnDongY As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTimKiem As Infragistics.Win.UltraWinEditors.UltraTextEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmTimKiemDanhMuc))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.btnThoat = New Infragistics.Win.Misc.UltraButton
        Me.btnDongY = New Infragistics.Win.Misc.UltraButton
        Me.txtTimKiem = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label6 = New System.Windows.Forms.Label
        CType(Me.txtTimKiem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnThoat
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.btnThoat.Appearance = Appearance1
        Me.btnThoat.Location = New System.Drawing.Point(328, 16)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(88, 32)
        Me.btnThoat.TabIndex = 37
        Me.btnThoat.Text = "Thoát"
        '
        'btnDongY
        '
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.btnDongY.Appearance = Appearance2
        Me.btnDongY.Location = New System.Drawing.Point(232, 16)
        Me.btnDongY.Name = "btnDongY"
        Me.btnDongY.Size = New System.Drawing.Size(88, 32)
        Me.btnDongY.TabIndex = 36
        Me.btnDongY.Text = "Đồng ý"
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Location = New System.Drawing.Point(80, 24)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(144, 21)
        Me.txtTimKiem.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 18)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Từ cần tìm"
        '
        'FrmTimKiemDanhMuc
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 70)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnDongY)
        Me.Controls.Add(Me.txtTimKiem)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTimKiemDanhMuc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tìm kiếm danh mục"
        CType(Me.txtTimKiem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim myForm As FrmCacBangDanhMucCuoc
    Dim myFormDM As FrmCacBangDanhMuc
    Dim myFormThietLapE2Di As FrmThietLapE2Di
    Dim myFormThietLapE2Den As FrmXacNhanE2Den
    Dim myFormThietLapDi As FrmThietLapDi
    Dim myFormThietLapDen As FrmXacNhanDen
    Dim myFormThongTinKeToan As FrmThongTinKeToan
    Dim myFormQuanLyThuNo As Frm_Quan_Ly_Thu_No_Hai_Quan
    Dim myFormLapToKhaiHangXuat As Frm_Lap_To_Khai_Hang_Xuat
    Dim myFrmInNhanE4Label As FrmIn_Nhan_E4_Label
    Dim myGrid As Infragistics.Win.UltraWinGrid.UltraGrid
    Dim myName As String
    Dim myString As String
    Public Sub ShowMe(ByVal _myForm As Windows.Forms.Form, ByVal _myGrid As Infragistics.Win.UltraWinGrid.UltraGrid, ByVal _myString As String)
        If _myForm.Name = "FrmCacBangDanhMuc" Then
            myFormDM = _myForm
        End If
        If _myForm.Name = "FrmCacBangDanhMucCuoc" Then
            myForm = _myForm
        End If
        If _myForm.Name = "FrmThietLapE2Di" Then
            myFormThietLapE2Di = _myForm
        End If
        If _myForm.Name = "FrmXacNhanE2Den" Then
            myFormThietLapE2Den = _myForm
        End If
        'Outbound
        If _myForm.Name = "FrmThietLapDi" Then
            myFormThietLapDi = _myForm
        End If
        If _myForm.Name = "FrmXacNhanDen" Then
            myFormThietLapDen = _myForm
        End If
        If _myForm.Name = "FrmThongTinKeToan" Then
            myFormThongTinKeToan = _myForm
        End If
        If _myForm.Name = "Frm_Quan_Ly_Thu_No_Hai_Quan" Then
            myFormQuanLyThuNo = _myForm
        End If
        If _myForm.Name = "Frm_Lap_To_Khai_Hang_Xuat" Then
            myFormLapToKhaiHangXuat = _myForm
        End If
        If _myForm.Name = "FrmIn_Nhan_E4_Label" Then
            myFrmInNhanE4Label = _myForm
        End If
        myName = _myForm.Name
        myString = _myString
        myGrid = _myGrid
        Me.KeyPreview = True
        Me.TopMost = True
        Me.Show()
        Me.BringToFront()
    End Sub
    Private Sub FrmTimKiemDanhMuc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDongY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDongY.Click
        If myName = "FrmCacBangDanhMuc" Then
            myFormDM.Search(myGrid, txtTimKiem.Text)
        End If
        If myName = "FrmThietLapE2Di" Then
            myFormThietLapE2Di.Search(myGrid, txtTimKiem.Text)
        End If
        If myName = "FrmCacBangDanhMucCuoc" Then
            myForm.Search(myGrid, txtTimKiem.Text)
        End If
        If myName = "FrmXacNhanE2Den" Then
            myFormThietLapE2Den.Search(myGrid, txtTimKiem.Text)
        End If
        'Outbound
        If myName = "FrmThietLapDi" Then
            myFormThietLapDi.Search(myGrid, txtTimKiem.Text)
        End If
        If myName = "FrmXacNhanDen" Then
            myFormThietLapDen.Search(myGrid, txtTimKiem.Text)
        End If
        If myName = "FrmThongTinKeToan" Then
            myFormThongTinKeToan.Search(myGrid, txtTimKiem.Text)
        End If
        If myName = "Frm_Quan_Ly_Thu_No_Hai_Quan" Then
            myFormQuanLyThuNo.Search(myGrid, txtTimKiem.Text)
        End If
        If myName = "Frm_Lap_To_Khai_Hang_Xuat" Then
            myFormLapToKhaiHangXuat.Search(myGrid, txtTimKiem.Text)
        End If
        If myName = "FrmIn_Nhan_E4_Label" Then
            myFrmInNhanE4Label.Search(myGrid, txtTimKiem.Text)
        End If
    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Hide()
    End Sub

    Private Sub FrmTimKiemDanhMuc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Enter Then
            btnDongY_Click(sender, e)
        End If
        If e.KeyValue = Keys.Escape Then Me.Hide()
        'If myForm.Name = "FrmCacBangDanhMuc" Then
        'End If
        'If myForm.Name = "FrmCacBangDanhMucCuoc" Then
        '    If e.KeyValue = Keys.Enter Then myForm.Search(myGrid, txtTimKiem.Text)
        '    If e.KeyValue = Keys.Escape Then Me.Hide()
        'End If

    End Sub
End Class

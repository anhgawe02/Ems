Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Ems_International_Logic.EMS
Public Class FrmSuaChuaE2_OutBout
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpNgayKeToan As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txtGioKhaiThacCanSua As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents dtpNgayKhaiThacCanSua As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents gbCanSua As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents dtpNgayKeToanSua As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtGioKhaiThacSua As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents dtpNgayKhaiThacSua As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents btnSua As Infragistics.Win.Misc.UltraButton
    Friend WithEvents lblCanSua As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblSua As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbDuongThuCanSua As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbTuiSoCanSua As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbCaKeToanCanSua As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbChuyenThuSua As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbTuiSoSua As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbDuongThuSua As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbCaKeToanSua As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents btnXoaE2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cbChuyenThuCanSua As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents btnSuaE2Loi As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cbPhanLoaiSua As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbPhanLoaiCanSua As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label10 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Chuyen_Thu_Di", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chuyen_Thu")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chuyen_Thu")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ca_San_Xuat", -1)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ca_Khai_Thac")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thu_Tu")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Duong_Thu_Di", -1)
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Duong_Thu")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Phan_Loai")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tinh_Doanh_Thu")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tinh_Cong_Phat")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Duoc_Truyen")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Tui", -1)
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tui_So")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ca_San_Xuat", -1)
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ca_Khai_Thac")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thu_Tu")
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Duong_Thu_Di", -1)
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Duong_Thu")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Phan_Loai")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tinh_Doanh_Thu")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tinh_Cong_Phat")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Duoc_Truyen")
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Tui", -1)
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tui_So")
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Chuyen_Thu_Di", -1)
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chuyen_Thu")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chuyen_Thu")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.gbCanSua = New Infragistics.Win.Misc.UltraGroupBox
        Me.cbPhanLoaiCanSua = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.Label10 = New System.Windows.Forms.Label
        Me.cbChuyenThuCanSua = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.btnSuaE2Loi = New Infragistics.Win.Misc.UltraButton
        Me.cbCaKeToanCanSua = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cbDuongThuCanSua = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.lblCanSua = New Infragistics.Win.Misc.UltraLabel
        Me.btnXoaE2 = New Infragistics.Win.Misc.UltraButton
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpNgayKeToan = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtGioKhaiThacCanSua = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpNgayKhaiThacCanSua = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbTuiSoCanSua = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.cbPhanLoaiSua = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.Label11 = New System.Windows.Forms.Label
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.cbCaKeToanSua = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cbDuongThuSua = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cbTuiSoSua = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cbChuyenThuSua = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.lblSua = New Infragistics.Win.Misc.UltraLabel
        Me.btnSua = New Infragistics.Win.Misc.UltraButton
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.dtpNgayKeToanSua = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtGioKhaiThacSua = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.Label22 = New System.Windows.Forms.Label
        Me.dtpNgayKhaiThacSua = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label23 = New System.Windows.Forms.Label
        CType(Me.gbCanSua, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCanSua.SuspendLayout()
        CType(Me.cbPhanLoaiCanSua, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbChuyenThuCanSua, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCaKeToanCanSua, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDuongThuCanSua, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpNgayKeToan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpNgayKhaiThacCanSua, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTuiSoCanSua, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.cbPhanLoaiSua, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCaKeToanSua, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDuongThuSua, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTuiSoSua, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbChuyenThuSua, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpNgayKeToanSua, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpNgayKhaiThacSua, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbCanSua
        '
        Me.gbCanSua.Controls.Add(Me.cbPhanLoaiCanSua)
        Me.gbCanSua.Controls.Add(Me.Label10)
        Me.gbCanSua.Controls.Add(Me.cbChuyenThuCanSua)
        Me.gbCanSua.Controls.Add(Me.btnSuaE2Loi)
        Me.gbCanSua.Controls.Add(Me.cbCaKeToanCanSua)
        Me.gbCanSua.Controls.Add(Me.cbDuongThuCanSua)
        Me.gbCanSua.Controls.Add(Me.lblCanSua)
        Me.gbCanSua.Controls.Add(Me.btnXoaE2)
        Me.gbCanSua.Controls.Add(Me.Label9)
        Me.gbCanSua.Controls.Add(Me.Label8)
        Me.gbCanSua.Controls.Add(Me.Label7)
        Me.gbCanSua.Controls.Add(Me.Label3)
        Me.gbCanSua.Controls.Add(Me.dtpNgayKeToan)
        Me.gbCanSua.Controls.Add(Me.Label2)
        Me.gbCanSua.Controls.Add(Me.txtGioKhaiThacCanSua)
        Me.gbCanSua.Controls.Add(Me.Label5)
        Me.gbCanSua.Controls.Add(Me.dtpNgayKhaiThacCanSua)
        Me.gbCanSua.Controls.Add(Me.Label6)
        Me.gbCanSua.Controls.Add(Me.cbTuiSoCanSua)
        Me.gbCanSua.Location = New System.Drawing.Point(8, 48)
        Me.gbCanSua.Name = "gbCanSua"
        Me.gbCanSua.Size = New System.Drawing.Size(360, 352)
        Me.gbCanSua.SupportThemes = False
        Me.gbCanSua.TabIndex = 2
        '
        'cbPhanLoaiCanSua
        '
        Me.cbPhanLoaiCanSua.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbPhanLoaiCanSua.DisplayMember = ""
        Me.cbPhanLoaiCanSua.Location = New System.Drawing.Point(120, 152)
        Me.cbPhanLoaiCanSua.Name = "cbPhanLoaiCanSua"
        Me.cbPhanLoaiCanSua.Size = New System.Drawing.Size(64, 21)
        Me.cbPhanLoaiCanSua.TabIndex = 14
        Me.cbPhanLoaiCanSua.ValueMember = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(120, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 18)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "Phân Loại"
        '
        'cbChuyenThuCanSua
        '
        Me.cbChuyenThuCanSua.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn1.Header.Caption = "ID Chuyến Thư"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.Caption = "Số Chuyến Thư"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 101
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2})
        Me.cbChuyenThuCanSua.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.cbChuyenThuCanSua.DisplayMember = "So_Chuyen_Thu"
        Me.cbChuyenThuCanSua.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbChuyenThuCanSua.Location = New System.Drawing.Point(200, 152)
        Me.cbChuyenThuCanSua.Name = "cbChuyenThuCanSua"
        Me.cbChuyenThuCanSua.Size = New System.Drawing.Size(80, 21)
        Me.cbChuyenThuCanSua.TabIndex = 15
        Me.cbChuyenThuCanSua.ValueMember = "So_Chuyen_Thu"
        '
        'btnSuaE2Loi
        '
        Me.btnSuaE2Loi.Location = New System.Drawing.Point(184, 288)
        Me.btnSuaE2Loi.Name = "btnSuaE2Loi"
        Me.btnSuaE2Loi.Size = New System.Drawing.Size(160, 48)
        Me.btnSuaE2Loi.TabIndex = 1
        Me.btnSuaE2Loi.Text = "Sửa bản kê E2 lỗi"
        '
        'cbCaKeToanCanSua
        '
        Me.cbCaKeToanCanSua.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn3.Header.Caption = "Ca Khai Thác"
        UltraGridColumn3.Header.VisiblePosition = 0
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.Caption = "Mã BC Khai Thac"
        UltraGridColumn4.Header.VisiblePosition = 1
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.Caption = "Ca Kế Toán"
        UltraGridColumn5.Header.VisiblePosition = 2
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn3, UltraGridColumn4, UltraGridColumn5})
        Me.cbCaKeToanCanSua.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.cbCaKeToanCanSua.DisplayMember = "Thu_Tu"
        Me.cbCaKeToanCanSua.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCaKeToanCanSua.Location = New System.Drawing.Point(112, 96)
        Me.cbCaKeToanCanSua.Name = "cbCaKeToanCanSua"
        Me.cbCaKeToanCanSua.Size = New System.Drawing.Size(72, 21)
        Me.cbCaKeToanCanSua.TabIndex = 9
        Me.cbCaKeToanCanSua.ValueMember = "Thu_Tu"
        '
        'cbDuongThuCanSua
        '
        Me.cbDuongThuCanSua.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn6.Header.Caption = "ID Đường Thư"
        UltraGridColumn6.Header.VisiblePosition = 0
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.Caption = "Tên Đường Thư"
        UltraGridColumn7.Header.VisiblePosition = 1
        UltraGridColumn8.Header.Caption = "Mã BC Khai Thác"
        UltraGridColumn8.Header.VisiblePosition = 2
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.Caption = "Mã BC"
        UltraGridColumn9.Header.VisiblePosition = 3
        UltraGridColumn10.Header.Caption = "ID Phân Loại"
        UltraGridColumn10.Header.VisiblePosition = 4
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 5
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 6
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 7
        UltraGridColumn13.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13})
        Me.cbDuongThuCanSua.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.cbDuongThuCanSua.DisplayMember = "Ma_Bc"
        Me.cbDuongThuCanSua.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDuongThuCanSua.Location = New System.Drawing.Point(16, 152)
        Me.cbDuongThuCanSua.Name = "cbDuongThuCanSua"
        Me.cbDuongThuCanSua.Size = New System.Drawing.Size(88, 21)
        Me.cbDuongThuCanSua.TabIndex = 13
        Me.cbDuongThuCanSua.ValueMember = "Id_Duong_Thu"
        '
        'lblCanSua
        '
        Appearance1.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(192, Byte))
        Appearance1.FontData.BoldAsString = "True"
        Me.lblCanSua.Appearance = Appearance1
        Me.lblCanSua.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCanSua.Location = New System.Drawing.Point(8, 184)
        Me.lblCanSua.Name = "lblCanSua"
        Me.lblCanSua.Size = New System.Drawing.Size(336, 96)
        Me.lblCanSua.TabIndex = 0
        '
        'btnXoaE2
        '
        Me.btnXoaE2.Location = New System.Drawing.Point(8, 288)
        Me.btnXoaE2.Name = "btnXoaE2"
        Me.btnXoaE2.Size = New System.Drawing.Size(160, 48)
        Me.btnXoaE2.TabIndex = 2
        Me.btnXoaE2.Text = "Xóa bản kê E2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(304, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 18)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Túi số"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(208, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 18)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Chuyến thư"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 18)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Đường thư"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(112, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Ca khai thác"
        '
        'dtpNgayKeToan
        '
        Me.dtpNgayKeToan.DateTime = New Date(2008, 7, 8, 0, 0, 0, 0)
        Me.dtpNgayKeToan.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpNgayKeToan.Location = New System.Drawing.Point(16, 96)
        Me.dtpNgayKeToan.Name = "dtpNgayKeToan"
        Me.dtpNgayKeToan.Size = New System.Drawing.Size(88, 21)
        Me.dtpNgayKeToan.TabIndex = 8
        Me.dtpNgayKeToan.Value = New Date(2008, 7, 8, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ngày khai thác"
        '
        'txtGioKhaiThacCanSua
        '
        Me.txtGioKhaiThacCanSua.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtGioKhaiThacCanSua.InputMask = "hh:mm"
        Me.txtGioKhaiThacCanSua.Location = New System.Drawing.Point(112, 40)
        Me.txtGioKhaiThacCanSua.Name = "txtGioKhaiThacCanSua"
        Me.txtGioKhaiThacCanSua.Size = New System.Drawing.Size(48, 20)
        Me.txtGioKhaiThacCanSua.TabIndex = 3
        Me.txtGioKhaiThacCanSua.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(112, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Giờ"
        '
        'dtpNgayKhaiThacCanSua
        '
        Me.dtpNgayKhaiThacCanSua.DateTime = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpNgayKhaiThacCanSua.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpNgayKhaiThacCanSua.FormatString = ""
        Me.dtpNgayKhaiThacCanSua.Location = New System.Drawing.Point(16, 40)
        Me.dtpNgayKhaiThacCanSua.MaskInput = ""
        Me.dtpNgayKhaiThacCanSua.Name = "dtpNgayKhaiThacCanSua"
        Me.dtpNgayKhaiThacCanSua.Size = New System.Drawing.Size(88, 21)
        Me.dtpNgayKhaiThacCanSua.TabIndex = 2
        Me.dtpNgayKhaiThacCanSua.Value = Nothing
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Ngày E2"
        '
        'cbTuiSoCanSua
        '
        Me.cbTuiSoCanSua.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn14.Header.Caption = "Túi Số"
        UltraGridColumn14.Header.VisiblePosition = 0
        UltraGridColumn14.Width = 61
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn14})
        Me.cbTuiSoCanSua.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.cbTuiSoCanSua.DisplayMember = "Tui_So"
        Me.cbTuiSoCanSua.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTuiSoCanSua.Location = New System.Drawing.Point(304, 152)
        Me.cbTuiSoCanSua.Name = "cbTuiSoCanSua"
        Me.cbTuiSoCanSua.Size = New System.Drawing.Size(40, 21)
        Me.cbTuiSoCanSua.TabIndex = 16
        Me.cbTuiSoCanSua.ValueMember = "Tui_So"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(96, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 26)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Thông tin cần sửa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(480, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Thông tin sửa"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.cbPhanLoaiSua)
        Me.UltraGroupBox1.Controls.Add(Me.Label11)
        Me.UltraGroupBox1.Controls.Add(Me.UltraButton1)
        Me.UltraGroupBox1.Controls.Add(Me.cbCaKeToanSua)
        Me.UltraGroupBox1.Controls.Add(Me.cbDuongThuSua)
        Me.UltraGroupBox1.Controls.Add(Me.cbTuiSoSua)
        Me.UltraGroupBox1.Controls.Add(Me.cbChuyenThuSua)
        Me.UltraGroupBox1.Controls.Add(Me.lblSua)
        Me.UltraGroupBox1.Controls.Add(Me.btnSua)
        Me.UltraGroupBox1.Controls.Add(Me.Label17)
        Me.UltraGroupBox1.Controls.Add(Me.Label18)
        Me.UltraGroupBox1.Controls.Add(Me.Label19)
        Me.UltraGroupBox1.Controls.Add(Me.Label20)
        Me.UltraGroupBox1.Controls.Add(Me.dtpNgayKeToanSua)
        Me.UltraGroupBox1.Controls.Add(Me.Label21)
        Me.UltraGroupBox1.Controls.Add(Me.txtGioKhaiThacSua)
        Me.UltraGroupBox1.Controls.Add(Me.Label22)
        Me.UltraGroupBox1.Controls.Add(Me.dtpNgayKhaiThacSua)
        Me.UltraGroupBox1.Controls.Add(Me.Label23)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(376, 48)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(360, 352)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 3
        '
        'cbPhanLoaiSua
        '
        Me.cbPhanLoaiSua.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbPhanLoaiSua.DisplayMember = ""
        Me.cbPhanLoaiSua.Location = New System.Drawing.Point(120, 152)
        Me.cbPhanLoaiSua.Name = "cbPhanLoaiSua"
        Me.cbPhanLoaiSua.Size = New System.Drawing.Size(64, 21)
        Me.cbPhanLoaiSua.TabIndex = 11
        Me.cbPhanLoaiSua.ValueMember = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(120, 128)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 18)
        Me.Label11.TabIndex = 70
        Me.Label11.Text = "Phân Loại"
        '
        'UltraButton1
        '
        Appearance2.ImageAlpha = Infragistics.Win.Alpha.UseAlphaLevel
        Me.UltraButton1.Appearance = Appearance2
        Me.UltraButton1.Location = New System.Drawing.Point(184, 288)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(168, 48)
        Me.UltraButton1.TabIndex = 15
        Me.UltraButton1.Text = "Thoát"
        '
        'cbCaKeToanSua
        '
        Me.cbCaKeToanSua.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn15.Header.Caption = "Ca Khai Thác"
        UltraGridColumn15.Header.VisiblePosition = 0
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.Caption = "Mã BC Khai Thac"
        UltraGridColumn16.Header.VisiblePosition = 1
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.Caption = "Ca Kế Toán"
        UltraGridColumn17.Header.VisiblePosition = 2
        UltraGridColumn17.Width = 69
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn15, UltraGridColumn16, UltraGridColumn17})
        Me.cbCaKeToanSua.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.cbCaKeToanSua.DisplayMember = "Thu_Tu"
        Me.cbCaKeToanSua.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCaKeToanSua.Location = New System.Drawing.Point(112, 96)
        Me.cbCaKeToanSua.Name = "cbCaKeToanSua"
        Me.cbCaKeToanSua.Size = New System.Drawing.Size(72, 21)
        Me.cbCaKeToanSua.TabIndex = 7
        Me.cbCaKeToanSua.ValueMember = "Thu_Tu"
        '
        'cbDuongThuSua
        '
        Me.cbDuongThuSua.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn18.Header.Caption = "ID Đường Thư"
        UltraGridColumn18.Header.VisiblePosition = 0
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.Caption = "Tên Đường Thư"
        UltraGridColumn19.Header.VisiblePosition = 1
        UltraGridColumn20.Header.Caption = "Mã BC Khai Thác"
        UltraGridColumn20.Header.VisiblePosition = 2
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.Caption = "Mã BC"
        UltraGridColumn21.Header.VisiblePosition = 3
        UltraGridColumn22.Header.Caption = "ID Phân Loại"
        UltraGridColumn22.Header.VisiblePosition = 4
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.Header.VisiblePosition = 5
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.Header.VisiblePosition = 6
        UltraGridColumn24.Hidden = True
        UltraGridColumn25.Header.VisiblePosition = 7
        UltraGridColumn25.Hidden = True
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25})
        Me.cbDuongThuSua.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.cbDuongThuSua.DisplayMember = "Ma_Bc"
        Me.cbDuongThuSua.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDuongThuSua.Location = New System.Drawing.Point(16, 152)
        Me.cbDuongThuSua.Name = "cbDuongThuSua"
        Me.cbDuongThuSua.Size = New System.Drawing.Size(88, 21)
        Me.cbDuongThuSua.TabIndex = 10
        Me.cbDuongThuSua.ValueMember = "Id_Duong_Thu"
        '
        'cbTuiSoSua
        '
        Me.cbTuiSoSua.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn26.Header.Caption = "Túi Số"
        UltraGridColumn26.Header.VisiblePosition = 0
        UltraGridColumn26.Width = 64
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn26})
        Me.cbTuiSoSua.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.cbTuiSoSua.DisplayMember = "Tui_So"
        Me.cbTuiSoSua.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTuiSoSua.Location = New System.Drawing.Point(304, 152)
        Me.cbTuiSoSua.Name = "cbTuiSoSua"
        Me.cbTuiSoSua.Size = New System.Drawing.Size(48, 21)
        Me.cbTuiSoSua.TabIndex = 13
        Me.cbTuiSoSua.ValueMember = "Tui_So"
        '
        'cbChuyenThuSua
        '
        Me.cbChuyenThuSua.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn27.Header.Caption = "ID Chuyến Thư"
        UltraGridColumn27.Header.VisiblePosition = 0
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.Caption = "Số Chuyến Thư"
        UltraGridColumn28.Header.VisiblePosition = 1
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn27, UltraGridColumn28})
        Me.cbChuyenThuSua.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.cbChuyenThuSua.DisplayMember = "So_Chuyen_Thu"
        Me.cbChuyenThuSua.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbChuyenThuSua.Location = New System.Drawing.Point(200, 152)
        Me.cbChuyenThuSua.Name = "cbChuyenThuSua"
        Me.cbChuyenThuSua.Size = New System.Drawing.Size(72, 21)
        Me.cbChuyenThuSua.TabIndex = 12
        Me.cbChuyenThuSua.ValueMember = "So_Chuyen_Thu"
        '
        'lblSua
        '
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(192, Byte))
        Appearance3.FontData.BoldAsString = "True"
        Me.lblSua.Appearance = Appearance3
        Me.lblSua.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSua.Location = New System.Drawing.Point(12, 184)
        Me.lblSua.Name = "lblSua"
        Me.lblSua.Size = New System.Drawing.Size(336, 96)
        Me.lblSua.TabIndex = 15
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(8, 288)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(160, 48)
        Me.btnSua.TabIndex = 14
        Me.btnSua.Text = "Sửa "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(312, 128)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(38, 18)
        Me.Label17.TabIndex = 69
        Me.Label17.Text = "Túi số"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(200, 128)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 18)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "Chuyến thư"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(16, 128)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 18)
        Me.Label19.TabIndex = 8
        Me.Label19.Text = "Đường thư"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(112, 72)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 18)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "Ca khai thác"
        '
        'dtpNgayKeToanSua
        '
        Me.dtpNgayKeToanSua.DateTime = New Date(2008, 7, 8, 0, 0, 0, 0)
        Me.dtpNgayKeToanSua.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpNgayKeToanSua.FormatString = ""
        Me.dtpNgayKeToanSua.Location = New System.Drawing.Point(16, 96)
        Me.dtpNgayKeToanSua.MaskInput = ""
        Me.dtpNgayKeToanSua.Name = "dtpNgayKeToanSua"
        Me.dtpNgayKeToanSua.Size = New System.Drawing.Size(88, 21)
        Me.dtpNgayKeToanSua.TabIndex = 6
        Me.dtpNgayKeToanSua.Value = New Date(2008, 7, 8, 0, 0, 0, 0)
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(16, 72)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(86, 18)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "Ngày khai thác"
        '
        'txtGioKhaiThacSua
        '
        Me.txtGioKhaiThacSua.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtGioKhaiThacSua.InputMask = "hh:mm"
        Me.txtGioKhaiThacSua.Location = New System.Drawing.Point(112, 40)
        Me.txtGioKhaiThacSua.Name = "txtGioKhaiThacSua"
        Me.txtGioKhaiThacSua.Size = New System.Drawing.Size(48, 20)
        Me.txtGioKhaiThacSua.TabIndex = 3
        Me.txtGioKhaiThacSua.Text = ":"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(112, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(23, 18)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "Giờ"
        '
        'dtpNgayKhaiThacSua
        '
        Me.dtpNgayKhaiThacSua.DateTime = New Date(2008, 7, 8, 0, 0, 0, 0)
        Me.dtpNgayKhaiThacSua.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpNgayKhaiThacSua.FormatString = ""
        Me.dtpNgayKhaiThacSua.Location = New System.Drawing.Point(16, 40)
        Me.dtpNgayKhaiThacSua.MaskInput = ""
        Me.dtpNgayKhaiThacSua.Name = "dtpNgayKhaiThacSua"
        Me.dtpNgayKhaiThacSua.Size = New System.Drawing.Size(88, 21)
        Me.dtpNgayKhaiThacSua.TabIndex = 2
        Me.dtpNgayKhaiThacSua.Value = New Date(2008, 7, 8, 0, 0, 0, 0)
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(16, 16)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(50, 18)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Ngày E2"
        '
        'FrmSuaChuaE2_OutBout
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(743, 412)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.gbCanSua)
        Me.KeyPreview = True
        Me.Name = "FrmSuaChuaE2_OutBout"
        Me.Text = "Sửa chữa bản kê E2 (Chiều đi)"
        CType(Me.gbCanSua, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCanSua.ResumeLayout(False)
        CType(Me.cbPhanLoaiCanSua, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbChuyenThuCanSua, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCaKeToanCanSua, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDuongThuCanSua, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpNgayKeToan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpNgayKhaiThacCanSua, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTuiSoCanSua, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.cbPhanLoaiSua, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCaKeToanSua, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDuongThuSua, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTuiSoSua, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbChuyenThuSua, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpNgayKeToanSua, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpNgayKhaiThacSua, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Khai Bao"
    Dim myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Dim myMa_Ca As New Ma_Ca(GConnectionString)
    Dim myE2_Di As New E2_Di(GConnectionString)
    Dim myE2_Di_Chi_Tiet As New E2_Di_Chi_Tiet
    Dim myE1_Di As New E1_Di(GConnectionString)
    Dim myE1_Di_Chi_Tiet As New E1_Di_Chi_Tiet
    Dim myDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)
    Dim myMa_Nuoc As New Ma_Nuoc(GConnectionString)
    Dim myDuong_Thu_Di As New Duong_Thu_Di(GConnectionString)
    Dim myChuyen_Thu_Di As New Chuyen_Thu_Di(GConnectionString)
    Dim myChuyen_Thu_Di_Chi_Tiet As New Chuyen_Thu_Di_Chi_Tiet
    Dim myHamdungchung As New Ham_Dung_Chung
    Dim myNguoi_Dung As New Nguoi_Dung(GConnectionString)
    Dim myCa_San_Xuat As New Ca_San_Xuat(GConnectionString)
#End Region
#Region "Tạo bảng Phân loại chuyến thư"
    Private Sub Tao_Bang_Phan_Loai_Chuyen_Thu()
        Dim dataTable As New DataTable("Phan_Loai_Chuyen_Thu")

        Dim colWork As DataColumn = New DataColumn("Ma_Loai", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Ten_Loai", GetType(String))
        dataTable.Columns.Add(colWork)

        Dim row As DataRow = dataTable.NewRow()
        row("Ma_Loai") = "EA"
        row("Ten_Loai") = "Mix A"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Ma_Loai") = "ED"
        row("Ten_Loai") = "Document"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Ma_Loai") = "EM"
        row("Ten_Loai") = "Machasnim"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Ma_Loai") = "EN"
        row("Ten_Loai") = "Mix"
        dataTable.Rows.Add(row)

        cbPhanLoaiCanSua.DataSource = dataTable
        cbPhanLoaiCanSua.DataBind()
        cbPhanLoaiCanSua.Text = "ED"
        cbPhanLoaiSua.DataSource = dataTable
        cbPhanLoaiSua.DataBind()
        cbPhanLoaiSua.Text = "ED"

    End Sub
#End Region
#Region "FORM LOAD"
    Private Sub FrmSuaChuaE2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpNgayKhaiThacCanSua.Value = DateTime.Now
        dtpNgayKhaiThacSua.Value = DateTime.Now
        txtGioKhaiThacCanSua.Enabled = False
        cbCaKeToanCanSua.Enabled = False
        dtpNgayKeToan.Enabled = False
        DuongThuCanSua_DataBind()
        DuongThuSua_DataBind()
        cbDuongThuCanSua.LimitToList = True
        cbDuongThuSua.LimitToList = True
        Tao_Bang_Phan_Loai_Chuyen_Thu()
        dtpNgayKhaiThacCanSua.Select()
    End Sub
    Private Sub Load_Control()
        cbCaKeToanCanSua.Text = ""
        cbChuyenThuCanSua.Text = ""
        cbDuongThuCanSua.Text = ""
        cbTuiSoCanSua.Text = ""
        cbPhanLoaiCanSua.Text = ""
        txtGioKhaiThacCanSua.Text = ""


        cbCaKeToanSua.Text = ""

        cbChuyenThuSua.Text = ""
        cbDuongThuSua.Text = ""
        cbTuiSoSua.Text = ""
        cbPhanLoaiSua.Text = ""

        txtGioKhaiThacSua.Text = ""
    End Sub
#End Region

#Region "THONG TIN CAN SUA"
    Private Sub ResetControl()

        txtGioKhaiThacCanSua.Text = ""
        cbDuongThuCanSua.Text = ""
        cbChuyenThuCanSua.Text = ""
        cbTuiSoCanSua.Text = ""


        txtGioKhaiThacSua.Text = ""
        cbDuongThuSua.Text = ""
        cbChuyenThuSua.Text = ""
        cbTuiSoSua.Text = ""
    End Sub
    Private Sub DuongThuCanSua_DataBind()
        cbDuongThuCanSua.DataSource = myDuong_Thu_Di.Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac(GBuu_Cuc_Khai_Thac).Tables(0)
        cbDuongThuCanSua.DataBind()
    End Sub

    Private Sub cbPhanLoaiCanSua_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbPhanLoaiCanSua.Validated
        If cbDuongThuCanSua.Text = "" Then Exit Sub
        Dim Id_Duong_Thu As String = myDuong_Thu_Di.Select_Id_Duong_Thu_Di(GBuu_Cuc_Khai_Thac, Convert.ToInt32(cbDuongThuCanSua.Text))
        Dim Ngay_Khai_Thac As Integer = Ham_Dung_Chung.ConvertDateToInt(dtpNgayKhaiThacCanSua.Value)
        Dim Id_Phan_Loai As Integer = myDuong_Thu_Di.Lay(Id_Duong_Thu).Id_Phan_Loai
        If (cbDuongThuCanSua.Text = "") Then
            CMessageBox.Show("Bạn chưa chọn thông tin về đường thư")
            cbPhanLoaiCanSua.Text = ""
            cbDuongThuCanSua.Focus()
            Exit Sub
        End If
        If (cbPhanLoaiCanSua.Text = "") Then
            CMessageBox.Show("Bạn phải chọn thông tin về loại chuyến thư")
            cbPhanLoaiCanSua.Focus()
            Exit Sub
        End If
        Dim myStart_Date As Integer
        Dim myEnd_Date As Integer
        'If Id_Phan_Loai = 0 Then  'Đường Thư Bưu Tá: Chuyến Thư tăng theo Ngày
        '    myStart_Date = (Ngay_Khai_Thac \ 100) * 100
        '    myEnd_Date = (Ngay_Khai_Thac \ 100) * 100 + 99
        'ElseIf Id_Phan_Loai = 1 Then  'Đường Thư Nội Tỉnh: Chuyến Thư tăng theo Tháng
        '    myStart_Date = (Ngay_Khai_Thac \ 100) * 100
        '    myEnd_Date = (Ngay_Khai_Thac \ 100) * 100 + 99
        'Else : Id_Phan_Loai = 2 Or Id_Phan_Loai = 3 Or Id_Phan_Loai = 4 'Đường Thư Liên Tỉnh,Liền kề, Quốc tê: Chuyến Thư tăng theo Năm
        '    myStart_Date = (Ngay_Khai_Thac \ 10000) * 10000
        '    myEnd_Date = (Ngay_Khai_Thac \ 10000) * 10000 + 9999
        'End If
        myStart_Date = (Ngay_Khai_Thac \ 10000) * 10000
        myEnd_Date = (Ngay_Khai_Thac \ 10000) * 10000 + 9999
        Dim Phan_Loai_Chuyen_Thu As String = cbPhanLoaiCanSua.Text
        '''   cbChuyenThuCanSua bind
        cbChuyenThuCanSua.DataSource = myChuyen_Thu_Di.Danh_Sach_Chuyen_Thu_DiQT(Id_Duong_Thu, myStart_Date, myEnd_Date, Phan_Loai_Chuyen_Thu).Tables(0)

        cbChuyenThuCanSua.DataBind()
        '''   cbChuyenThuSua bind
        cbChuyenThuSua.DataSource = myChuyen_Thu_Di.Danh_Sach_Chuyen_Thu_DiQT(Id_Duong_Thu, myStart_Date, myEnd_Date, Phan_Loai_Chuyen_Thu).Tables(0)
        cbChuyenThuSua.DataBind()
        cbPhanLoaiSua.Value = cbPhanLoaiCanSua.Value
        cbPhanLoaiSua.Text = cbPhanLoaiCanSua.Text
    End Sub
    Private Sub ChuyenThuCanSua_DataBind()
        Dim Id_Duong_Thu As String = myDuong_Thu_Di.Select_Id_Duong_Thu_Di(GBuu_Cuc_Khai_Thac, Convert.ToInt32(cbDuongThuCanSua.Text))
        Dim Ngay_Khai_Thac As Integer = Ham_Dung_Chung.ConvertDateToInt(dtpNgayKhaiThacCanSua.Value)
        Dim Id_Phan_Loai As Integer = myDuong_Thu_Di.Lay(Id_Duong_Thu).Id_Phan_Loai
        Dim myStart_Date As Integer
        Dim myEnd_Date As Integer
        'If Id_Phan_Loai = 0 Then  'Đường Thư Bưu Tá: Chuyến Thư tăng theo Ngày
        '    myStart_Date = (Ngay_Khai_Thac \ 100) * 100
        '    myEnd_Date = (Ngay_Khai_Thac \ 100) * 100 + 99
        'ElseIf Id_Phan_Loai = 1 Then  'Đường Thư Nội Tỉnh: Chuyến Thư tăng theo Tháng
        '    myStart_Date = (Ngay_Khai_Thac \ 100) * 100
        '    myEnd_Date = (Ngay_Khai_Thac \ 100) * 100 + 99
        'Else : Id_Phan_Loai = 2 Or Id_Phan_Loai = 3 Or Id_Phan_Loai = 4 'Đường Thư Liên Tỉnh,Liền kề, Quốc tê: Chuyến Thư tăng theo Năm
        '    myStart_Date = (Ngay_Khai_Thac \ 10000) * 10000
        '    myEnd_Date = (Ngay_Khai_Thac \ 10000) * 10000 + 9999
        'End If
        myStart_Date = (Ngay_Khai_Thac \ 10000) * 10000
        myEnd_Date = (Ngay_Khai_Thac \ 10000) * 10000 + 9999
        Dim Phan_Loai_Chuyen_Thu As String = cbPhanLoaiCanSua.Text
        cbChuyenThuCanSua.DataSource = myChuyen_Thu_Di.Danh_Sach_Chuyen_Thu_DiQT(Id_Duong_Thu, myStart_Date, myEnd_Date, Phan_Loai_Chuyen_Thu)
        cbChuyenThuCanSua.DataBind()
    End Sub

    Private Sub cbDuongThuCanSua_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDuongThuCanSua.Validated
        If (cbDuongThuCanSua.Text = "") Then
            CMessageBox.Show("Bạn chưa chọn bưu cục nhận chuyến thư ", "Thiếu thông tin về dường thư đóng đi")
            UltraButton1.Focus()
        ElseIf cbDuongThuCanSua.Text <> "" Then
            Dim Id_Duong_Thu As String = myDuong_Thu_Di.Select_Id_Duong_Thu_Di(GBuu_Cuc_Khai_Thac, Convert.ToInt32(cbDuongThuCanSua.Text))
            If Id_Duong_Thu Is Nothing Then
                CMessageBox.Show("Không tồn tại đường thư này bạn phải vào bảng Đường Thư Đi để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cbDuongThuCanSua.Text = ""
                cbDuongThuCanSua.Select()
                Exit Sub
            End If
            '   cbChuyenThuCanSua bind
            'ChuyenThuCanSua_DataBind()
            '''   cbChuyenThuSua bind
            'ChuyenThuSua_DataBind()
            '''   lblCanSua
            Dim Ngay_Khai_Thac As Integer = Ham_Dung_Chung.ConvertDateToInt(dtpNgayKhaiThacCanSua.Value)
            Dim Id_Phan_Loai As Integer = myDuong_Thu_Di.Lay(Id_Duong_Thu).Id_Phan_Loai
            Dim myStart_Date As Integer
            Dim myEnd_Date As Integer
            'If Id_Phan_Loai = 0 Then  'Đường Thư Bưu Tá: Chuyến Thư tăng theo Ngày
            '    myStart_Date = (Ngay_Khai_Thac \ 100) * 100
            '    myEnd_Date = (Ngay_Khai_Thac \ 100) * 100 + 99
            'ElseIf Id_Phan_Loai = 1 Then  'Đường Thư Nội Tỉnh: Chuyến Thư tăng theo Tháng
            '    myStart_Date = (Ngay_Khai_Thac \ 100) * 100
            '    myEnd_Date = (Ngay_Khai_Thac \ 100) * 100 + 99
            'Else : Id_Phan_Loai = 2 Or Id_Phan_Loai = 3 Or Id_Phan_Loai = 4 'Đường Thư Liên Tỉnh,Liền kề, Quốc tê: Chuyến Thư tăng theo Năm
            '    myStart_Date = (Ngay_Khai_Thac \ 10000) * 10000
            '    myEnd_Date = (Ngay_Khai_Thac \ 10000) * 10000 + 9999
            'End If
            myStart_Date = (Ngay_Khai_Thac \ 10000) * 10000
            myEnd_Date = (Ngay_Khai_Thac \ 10000) * 10000 + 9999
            Dim Tong_So_E2 As String = myChuyen_Thu_Di.Lay_Tong_E2_E1_Theo_Id_Duong_Thu(Id_Duong_Thu, myStart_Date, myEnd_Date).Tong_So_Tui
            Dim Tong_So_E1 As String = myChuyen_Thu_Di.Lay_Tong_E2_E1_Theo_Id_Duong_Thu(Id_Duong_Thu, myStart_Date, myEnd_Date).Tong_So_BP
            Dim Tong_KLBP As String = myChuyen_Thu_Di.Lay_Tong_E2_E1_Theo_Id_Duong_Thu(Id_Duong_Thu, myStart_Date, myEnd_Date).Tong_KLBP
            lblCanSua.Text = "                 Chưa điền đầy đủ dữ liệu" & vbNewLine & "BC khai thác: " & GTen_Buu_Cuc_Khai_Thac & vbNewLine & "Tổng E2: " & Tong_So_E2 & ";  Tổng E1: " & Tong_So_E1 & ";  Trọng luợng: " & Tong_KLBP
        End If
        cbDuongThuSua.Value = cbDuongThuCanSua.Value
        cbDuongThuSua.Text = cbDuongThuCanSua.Text
        cbPhanLoaiCanSua.Text = "ED"

    End Sub

    Private Sub dtpNgayKhaiThacCanSua_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpNgayKhaiThacCanSua.Validated
        dtpNgayKhaiThacSua.DateTime = dtpNgayKhaiThacCanSua.DateTime
        dtpNgayKhaiThacSua.Value = dtpNgayKhaiThacCanSua.Value
        dtpNgayKhaiThacSua.Text = dtpNgayKhaiThacCanSua.Text
    End Sub

    Private Sub cbChuyenThuCanSua_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbChuyenThuCanSua.Validated
        If cbDuongThuCanSua.Text <> "" And cbChuyenThuCanSua.Text <> "" Then
            ''TuiSoCanSua DataBind
            Dim Id_Duong_Thu As String = myDuong_Thu_Di.Select_Id_Duong_Thu_Di(GBuu_Cuc_Khai_Thac, Convert.ToInt32(cbDuongThuCanSua.Text))
            ''Kiem tra su ton tai cua chuyen thu
            Dim Id_Phan_Loai As Integer = myDuong_Thu_Di.Lay(Id_Duong_Thu).Id_Phan_Loai
            Dim Ngay_Dong As Integer = Ham_Dung_Chung.ConvertDateToInt(dtpNgayKhaiThacCanSua.Value)
            Dim myStart_Date As Integer
            Dim myEnd_Date As Integer
            'If Id_Phan_Loai = 0 Then  'Đường Thư Bưu Tá: Chuyến Thư tăng theo Ngày
            '    myStart_Date = (Ngay_Dong \ 100) * 100
            '    myEnd_Date = (Ngay_Dong \ 100) * 100 + 99
            'ElseIf Id_Phan_Loai = 1 Then  'Đường Thư Nội Tỉnh: Chuyến Thư tăng theo Tháng
            '    myStart_Date = (Ngay_Dong \ 100) * 100
            '    myEnd_Date = (Ngay_Dong \ 100) * 100 + 99
            'Else : Id_Phan_Loai = 2 Or Id_Phan_Loai = 3 Or Id_Phan_Loai = 4 'Đường Thư Liên Tỉnh,Liền kề, Quốc tê: Chuyến Thư tăng theo Năm
            '    myStart_Date = (Ngay_Dong \ 10000) * 10000
            '    myEnd_Date = (Ngay_Dong \ 10000) * 10000 + 9999
            'End If
            myStart_Date = (Ngay_Dong \ 10000) * 10000
            myEnd_Date = (Ngay_Dong \ 10000) * 10000 + 9999
            'Dim chk_Id_Chuyen_thu As Boolean = myChuyen_Thu_Di.IsExist_Chuyen_Thu_Di(Id_Duong_Thu, cbChuyenThuCanSua.Text, myStart_Date, myEnd_Date)
            Dim chk_Id_Chuyen_thu As Boolean = myChuyen_Thu_Di.IsExist_Chuyen_Thu_Di_Theo_Loai_Chuyen_Thu(Id_Duong_Thu, cbChuyenThuCanSua.Text, myStart_Date, myEnd_Date, cbPhanLoaiCanSua.Text)
            If chk_Id_Chuyen_thu = True Then
                cbChuyenThuSua.Value = cbChuyenThuCanSua.Value
                'Dim Id_Chuyen_Thu As String = myChuyen_Thu_Di.Lay_Id_Chuyen_Thu(Id_Duong_Thu, myStart_Date, myEnd_Date, Convert.ToInt32(cbChuyenThuCanSua.Text)).Id_Chuyen_Thu
                Dim Id_Chuyen_Thu As String = myChuyen_Thu_Di.Chuyen_Thu_Di_Chi_Tiet_Lay_Boi_Duong_Thu_Di_Ngay_So_Chuyen_Thu_Loai_Chuyen_Thu_KT(Id_Duong_Thu, myStart_Date, myEnd_Date, cbChuyenThuCanSua.Text, cbPhanLoaiCanSua.Text).Id_Chuyen_Thu
                'cbTuiSoCanSua
                cbTuiSoCanSua.DataSource = myE2_Di.Danh_Sach_Tui_So(Id_Chuyen_Thu)
                cbTuiSoCanSua.DataBind()
                If cbTuiSoCanSua.Rows.Count = 0 Then
                    cbTuiSoCanSua.Value = Nothing
                End If
                'cbTuiSoSua
                cbTuiSoSua.DataSource = myE2_Di.Danh_Sach_Tui_So(Id_Chuyen_Thu)
                cbTuiSoSua.DataBind()
                'Dim Tong_So_E2 As String = myChuyen_Thu_Di.Lay_Tong_E2_E1_Theo_Chuyen_Thu(Id_Duong_Thu, myStart_Date, myEnd_Date, cbChuyenThuCanSua.Value).Tong_So_Tui
                'Dim Tong_So_E1 As String = myChuyen_Thu_Di.Lay_Tong_E2_E1_Theo_Chuyen_Thu(Id_Duong_Thu, myStart_Date, myEnd_Date, cbChuyenThuCanSua.Value).Tong_So_BP
                'Dim Tong_KLBP As String = myChuyen_Thu_Di.Lay_Tong_E2_E1_Theo_Chuyen_Thu(Id_Duong_Thu, myStart_Date, myEnd_Date, cbChuyenThuCanSua.Value).Tong_KLBP
                Dim Tong_So_E2 As String = myChuyen_Thu_Di.Chuyen_Thu_Di_Lay_Tong_E2_E1_Theo_Chuyen_Thu_QT(Id_Duong_Thu, myStart_Date, myEnd_Date, cbChuyenThuCanSua.Value, cbPhanLoaiCanSua.Text).Tong_So_Tui
                Dim Tong_So_E1 As String = myChuyen_Thu_Di.Chuyen_Thu_Di_Lay_Tong_E2_E1_Theo_Chuyen_Thu_QT(Id_Duong_Thu, myStart_Date, myEnd_Date, cbChuyenThuCanSua.Value, cbPhanLoaiCanSua.Text).Tong_So_BP
                Dim Tong_KLBP As String = myChuyen_Thu_Di.Chuyen_Thu_Di_Lay_Tong_E2_E1_Theo_Chuyen_Thu_QT(Id_Duong_Thu, myStart_Date, myEnd_Date, cbChuyenThuCanSua.Value, cbPhanLoaiCanSua.Text).Tong_KLBP
                '' lblCanSua
                lblCanSua.Text = ""
                lblCanSua.Text = "                 Chưa điền đầy đủ dữ liệu" & vbNewLine & "BC khai thác: " & GTen_Buu_Cuc_Khai_Thac & vbNewLine & "Tổng E2: " & Tong_So_E2 & ";  Tổng E1: " & Tong_So_E1 & ";  Trọng luợng: " & Tong_KLBP
            Else
                CMessageBox.Show("Chuyến thư này không tồn tại, bạn hãy kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cbChuyenThuCanSua.Text = ""
                cbPhanLoaiSua.Text = ""
                cbTuiSoCanSua.Text = ""
                cbChuyenThuCanSua.Select()
                Exit Sub
            End If
            cbChuyenThuSua.Value = cbChuyenThuCanSua.Value
            cbChuyenThuSua.Text = cbChuyenThuCanSua.Text
        ElseIf (cbChuyenThuSua.Text = "") Then
            CMessageBox.Show("Chưa có thông tin về chuyến thư", "Thiếu thông tin về chuyến thư ")
            cbDuongThuCanSua.Focus()
        End If

    End Sub
    Private Sub cbTuiSoCanSua_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTuiSoCanSua.Validated
        If cbTuiSoCanSua.Text <> "" And cbChuyenThuCanSua.Text <> "" And cbDuongThuCanSua.Text <> "" Then
            Dim Id_Duong_Thu As String = myDuong_Thu_Di.Select_Id_Duong_Thu_Di(GBuu_Cuc_Khai_Thac, Convert.ToInt32(cbDuongThuCanSua.Text))
            '' Khai báo
            Dim Ngay_Khai_Thac As Integer = myHamdungchung.ConvertDateToInt(dtpNgayKhaiThacCanSua.Value)
            Dim Id_Phan_Loai As Integer = myDuong_Thu_Di.Lay(Id_Duong_Thu).Id_Phan_Loai
            Dim myStart_Date As Integer
            Dim myEnd_Date As Integer
            'If Id_Phan_Loai = 0 Then  'Đường Thư Bưu Tá: Chuyến Thư tăng theo Ngày
            '    myStart_Date = (Ngay_Khai_Thac \ 100) * 100
            '    myEnd_Date = (Ngay_Khai_Thac \ 100) * 100 + 99
            'ElseIf Id_Phan_Loai = 1 Then  'Đường Thư Nội Tỉnh: Chuyến Thư tăng theo Tháng
            '    myStart_Date = (Ngay_Khai_Thac \ 100) * 100
            '    myEnd_Date = (Ngay_Khai_Thac \ 100) * 100 + 99
            'Else : Id_Phan_Loai = 2 Or Id_Phan_Loai = 3 Or Id_Phan_Loai = 4 'Đường Thư Liên Tỉnh,Liền kề, Quốc tê: Chuyến Thư tăng theo Năm
            '    myStart_Date = (Ngay_Khai_Thac \ 10000) * 10000
            '    myEnd_Date = (Ngay_Khai_Thac \ 10000) * 10000 + 9999
            'End If
            myStart_Date = (Ngay_Khai_Thac \ 10000) * 10000
            myEnd_Date = (Ngay_Khai_Thac \ 10000) * 10000 + 9999
            'Dim Id_Chuyen_Thu As String = myChuyen_Thu_Di.Lay_Id_Chuyen_Thu(Id_Duong_Thu, myStart_Date, myEnd_Date, cbChuyenThuCanSua.Value).Id_Chuyen_Thu
            Dim Id_Chuyen_Thu As String = myChuyen_Thu_Di.Chuyen_Thu_Di_Chi_Tiet_Lay_Boi_Duong_Thu_Di_Ngay_So_Chuyen_Thu_Loai_Chuyen_Thu_KT(Id_Duong_Thu, myStart_Date, myEnd_Date, cbChuyenThuCanSua.Value, cbPhanLoaiCanSua.Value).Id_Chuyen_Thu

            Dim Tui_So As Integer = cbTuiSoCanSua.Value
            Dim Chk_Id_E2 As Boolean = myE2_Di.IsExist_E2_Di(Id_Chuyen_Thu, Tui_So)
            If Chk_Id_E2 = False Then
                CMessageBox.Show("Túi số không tồn tại bạn hãy xem lai thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cbTuiSoCanSua.Text = ""
                cbTuiSoSua.Select()
                Exit Sub
            End If
            Dim Tong_So_E1 As String = myE2_Di.Lay_TT_E1(Id_Chuyen_Thu, Tui_So).Tong_So_BP
            Dim Khoi_Luong As Integer = myE2_Di.Lay_TT_E1(Id_Chuyen_Thu, Tui_So).Khoi_Luong_BP
            Dim Id_Ca As String = myE2_Di.Lay_TT_E1(Id_Chuyen_Thu, Tui_So).Id_Ca
            Dim Gio_Dong As Integer = myE2_Di.Lay_TT_E1(Id_Chuyen_Thu, Tui_So).Gio_Dong
            Dim Id_E2 As String = myE2_Di.Lay_TT_E1(Id_Chuyen_Thu, Tui_So).Id_E2
            Dim Ngay_Dong As Integer = myE2_Di.Lay_TT_E1(Id_Chuyen_Thu, Tui_So).Ngay_Dong
            Dim Ten_Dang_Nhap As String = myNguoi_Dung.Lay(myE1_Di.Lay_Id_Nguoi_Dung(Id_E2)).Ten_Dang_Nhap
            ''
            dtpNgayKeToan.DateTime = Ham_Dung_Chung.ConvertIntToDate(myCa_San_Xuat.Lay(Id_Ca).Ngay_Khai_Thac)
            dtpNgayKeToanSua.DateTime = Ham_Dung_Chung.ConvertIntToDate(myCa_San_Xuat.Lay(Id_Ca).Ngay_Khai_Thac)
            dtpNgayKhaiThacCanSua.DateTime = Ham_Dung_Chung.ConvertIntToDate(Ngay_Dong)
            dtpNgayKhaiThacSua.DateTime = Ham_Dung_Chung.ConvertIntToDate(Ngay_Dong) 'dtpNgayKhaiThacCanSua.DateTime
            '' cbCaKeToanCanSua
            cbCaKeToanCanSua.DataSource = myCa_San_Xuat.Danh_Sach_Lay_Boi_Id_Ca(Id_Ca).Tables(0)
            cbCaKeToanCanSua.DataBind()
            If cbCaKeToanCanSua.Rows.Count <> 0 Then
                cbCaKeToanCanSua.Value = cbCaKeToanCanSua.Rows(0).Cells("Thu_Tu").Value
                cbCaKeToanCanSua.Text = cbCaKeToanCanSua.Rows(0).Cells("Thu_Tu").Value
            End If
            '' cbCaKeToanSua
            cbCaKeToanSua.DataSource = myCa_San_Xuat.Danh_Sach_Kt(Ngay_Khai_Thac, GBuu_Cuc_Khai_Thac).Tables(0)
            cbCaKeToanSua.DataBind()
            If cbCaKeToanSua.Rows.Count <> 0 Then
                cbCaKeToanSua.Value = cbCaKeToanSua.Rows(0).Cells("Thu_Tu").Value
                'cbCaKeToanSua.Text = cbCaKeToanSua.Rows(0).Cells("Thu_Tu").Value
            End If
            cbCaKeToanSua.Value = cbCaKeToanCanSua.Value
            cbCaKeToanSua.Text = cbCaKeToanCanSua.Text
            dtpNgayKhaiThacSua.Value = dtpNgayKhaiThacCanSua.Value
            ''
            txtGioKhaiThacCanSua.Value = Gio_Dong.ToString("0000")
            txtGioKhaiThacSua.Value = txtGioKhaiThacCanSua.Value
            txtGioKhaiThacSua.Text = txtGioKhaiThacCanSua.Text
            '' lblCanSua
            lblCanSua.Text = ""
            lblCanSua.Text = "                 " & vbNewLine & "BC khai thác: " & GTen_Buu_Cuc_Khai_Thac & vbNewLine & "Tổng E1: " & Tong_So_E1 & ";  Trọng Lượng: " & Khoi_Luong & vbNewLine & Ten_Dang_Nhap.ToUpper & vbNewLine & Ham_Dung_Chung.ConvertIntToVNDateType(Ngay_Dong) & " " & Ham_Dung_Chung.ConvertIntToTime(Gio_Dong)
            '' lblSua
            lblSua.Text = ""
            lblSua.Text = "                 " & vbNewLine & "BC khai thác: " & GTen_Buu_Cuc_Khai_Thac & vbNewLine & "Tổng E1: " & Tong_So_E1 & "; Trọng Lượng: " & Khoi_Luong & vbNewLine & Ten_Dang_Nhap.ToUpper & vbNewLine & Ham_Dung_Chung.ConvertIntToVNDateType(Ngay_Dong) & " " & Ham_Dung_Chung.ConvertIntToTime(Gio_Dong)
        ElseIf (cbTuiSoCanSua.Text = "") Then
            CMessageBox.Show("Chưa có thông tin về chuyến thư", "Thiếu thông tin về chuyến thư ")
            cbDuongThuCanSua.Focus()
        End If
        cbTuiSoSua.Value = cbTuiSoCanSua.Value
        cbTuiSoSua.Text = cbTuiSoCanSua.Text
        dtpNgayKhaiThacSua.Select()
    End Sub

    Private Sub txtGioKhaiThacCanSua_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGioKhaiThacCanSua.ValueChanged
        txtGioKhaiThacSua.Value = txtGioKhaiThacCanSua.Value
        txtGioKhaiThacSua.Text = txtGioKhaiThacCanSua.Text
    End Sub

    Private Sub dtpNgayKeToan_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpNgayKeToan.ValueChanged
        dtpNgayKeToanSua.DateTime = dtpNgayKeToan.DateTime
        dtpNgayKeToanSua.Value = dtpNgayKeToan.Value
        dtpNgayKeToanSua.Text = dtpNgayKeToan.Text
    End Sub
#End Region

#Region "THONG TIN SUA"
    Private Sub DuongThuSua_DataBind()
        cbDuongThuSua.DataSource = myDuong_Thu_Di.Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac(GBuu_Cuc_Khai_Thac).Tables(0)
        cbDuongThuSua.DataBind()
    End Sub
    Private Sub cbChuyenThuSua_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbChuyenThuSua.Validated
        If cbDuongThuSua.Text <> "" And cbChuyenThuSua.Text <> "" Then
            ''TuiSosua DataBind
            Dim Id_Duong_Thu As String = myDuong_Thu_Di.Select_Id_Duong_Thu_Di(GBuu_Cuc_Khai_Thac, Convert.ToInt32(cbDuongThuSua.Text))
            ''Kiem tra su ton tai cua chuyen thu
            Dim Id_Phan_Loai As Integer = myDuong_Thu_Di.Lay(Id_Duong_Thu).Id_Phan_Loai
            Dim Ngay_Dong As Integer = Ham_Dung_Chung.ConvertDateToInt(dtpNgayKhaiThacSua.Value)
            Dim myStart_Date As Integer
            Dim myEnd_Date As Integer
            'If Id_Phan_Loai = 0 Then  'Đường Thư Bưu Tá: Chuyến Thư tăng theo Ngày
            '    myStart_Date = (Ngay_Dong \ 100) * 100
            '    myEnd_Date = (Ngay_Dong \ 100) * 100 + 99
            'ElseIf Id_Phan_Loai = 1 Then  'Đường Thư Nội Tỉnh: Chuyến Thư tăng theo Tháng
            '    myStart_Date = (Ngay_Dong \ 100) * 100
            '    myEnd_Date = (Ngay_Dong \ 100) * 100 + 99
            'Else : Id_Phan_Loai = 2 Or Id_Phan_Loai = 3 Or Id_Phan_Loai = 4 'Đường Thư Liên Tỉnh,Liền kề, Quốc tê: Chuyến Thư tăng theo Năm
            '    myStart_Date = (Ngay_Dong \ 10000) * 10000
            '    myEnd_Date = (Ngay_Dong \ 10000) * 10000 + 9999
            'End If
            myStart_Date = (Ngay_Dong \ 10000) * 10000
            myEnd_Date = (Ngay_Dong \ 10000) * 10000 + 9999
            'Dim chk_Id_Chuyen_thu As Boolean = myChuyen_Thu_Di.IsExist_Chuyen_Thu_Di(Id_Duong_Thu, cbChuyenThusua.Text, myStart_Date, myEnd_Date)
            Dim chk_Id_Chuyen_thu As Boolean = myChuyen_Thu_Di.IsExist_Chuyen_Thu_Di_Theo_Loai_Chuyen_Thu(Id_Duong_Thu, cbChuyenThuSua.Text, myStart_Date, myEnd_Date, cbPhanLoaiSua.Text)
            If chk_Id_Chuyen_thu = True Then
                cbChuyenThuSua.Value = cbChuyenThuSua.Value
                'Dim Id_Chuyen_Thu As String = myChuyen_Thu_Di.Lay_Id_Chuyen_Thu(Id_Duong_Thu, myStart_Date, myEnd_Date, Convert.ToInt32(cbChuyenThusua.Text)).Id_Chuyen_Thu
                Dim Id_Chuyen_Thu As String = myChuyen_Thu_Di.Chuyen_Thu_Di_Chi_Tiet_Lay_Boi_Duong_Thu_Di_Ngay_So_Chuyen_Thu_Loai_Chuyen_Thu_KT(Id_Duong_Thu, myStart_Date, myEnd_Date, cbChuyenThuSua.Text, cbPhanLoaiSua.Text).Id_Chuyen_Thu
                'cbTuiSosua
                cbTuiSoSua.DataSource = myE2_Di.Danh_Sach_Tui_So(Id_Chuyen_Thu)
                cbTuiSoSua.DataBind()
                If cbTuiSoSua.Rows.Count = 0 Then
                    cbTuiSoSua.Value = Nothing
                End If
                'cbTuiSoSua
                cbTuiSoSua.DataSource = myE2_Di.Danh_Sach_Tui_So(Id_Chuyen_Thu)
                cbTuiSoSua.DataBind()
                'Dim Tong_So_E2 As String = myChuyen_Thu_Di.Lay_Tong_E2_E1_Theo_Chuyen_Thu(Id_Duong_Thu, myStart_Date, myEnd_Date, cbChuyenThusua.Value).Tong_So_Tui
                'Dim Tong_So_E1 As String = myChuyen_Thu_Di.Lay_Tong_E2_E1_Theo_Chuyen_Thu(Id_Duong_Thu, myStart_Date, myEnd_Date, cbChuyenThusua.Value).Tong_So_BP
                'Dim Tong_KLBP As String = myChuyen_Thu_Di.Lay_Tong_E2_E1_Theo_Chuyen_Thu(Id_Duong_Thu, myStart_Date, myEnd_Date, cbChuyenThusua.Value).Tong_KLBP
                Dim Tong_So_E2 As String = myChuyen_Thu_Di.Chuyen_Thu_Di_Lay_Tong_E2_E1_Theo_Chuyen_Thu_QT(Id_Duong_Thu, myStart_Date, myEnd_Date, cbChuyenThuSua.Value, cbPhanLoaiSua.Text).Tong_So_Tui
                Dim Tong_So_E1 As String = myChuyen_Thu_Di.Chuyen_Thu_Di_Lay_Tong_E2_E1_Theo_Chuyen_Thu_QT(Id_Duong_Thu, myStart_Date, myEnd_Date, cbChuyenThuSua.Value, cbPhanLoaiSua.Text).Tong_So_BP
                Dim Tong_KLBP As String = myChuyen_Thu_Di.Chuyen_Thu_Di_Lay_Tong_E2_E1_Theo_Chuyen_Thu_QT(Id_Duong_Thu, myStart_Date, myEnd_Date, cbChuyenThuSua.Value, cbPhanLoaiSua.Text).Tong_KLBP
                '' lblsua
                lblSua.Text = ""
                lblSua.Text = "                 Chưa điền đầy đủ dữ liệu" & vbNewLine & "BC khai thác: " & GTen_Buu_Cuc_Khai_Thac & vbNewLine & "Tổng E2: " & Tong_So_E2 & ";  Tổng E1: " & Tong_So_E1 & ";  Trọng luợng: " & Tong_KLBP
            Else
                If MessageBox.Show("Chuyến thư này không tồn tai, có phải bạn muốn tạo chuyến thư mới không???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                    lblSua.Text = ""
                    lblSua.Text = "                 Chưa điền đầy đủ dữ liệu" & vbNewLine & "BC khai thác: " & GTen_Buu_Cuc_Khai_Thac & vbNewLine & "Tổng E2: 0 ;  Tổng E1: 0 ;  Trọng luợng: 0"
                Else
                    cbChuyenThuSua.Text = ""
                    cbPhanLoaiSua.Text = ""
                    cbTuiSoSua.Text = ""
                    cbPhanLoaiSua.Select()
                    Exit Sub
                End If
            End If
        ElseIf (cbChuyenThuSua.Text = "") Then
                CMessageBox.Show("Chưa có thông tin về chuyến thư", "Thiếu thông tin về chuyến thư ")
            cbDuongThuSua.Focus()
        End If
    End Sub
    Private Sub ChuyenThuSua_DataBind()
        Dim Id_Duong_Thu_Sua As String = myDuong_Thu_Di.Select_Id_Duong_Thu_Di(GBuu_Cuc_Khai_Thac, Convert.ToInt32(cbDuongThuSua.Text))
        Dim Ngay_Khai_Thac_Sua As Integer = Ham_Dung_Chung.ConvertDateToInt(dtpNgayKhaiThacSua.Value)
        Dim Id_Phan_Loai As Integer = myDuong_Thu_Di.Lay(Id_Duong_Thu_Sua).Id_Phan_Loai
        Dim myStart_Date As Integer
        Dim myEnd_Date As Integer
        'If Id_Phan_Loai = 0 Then  'Đường Thư Bưu Tá: Chuyến Thư tăng theo Ngày
        '    myStart_Date = (Ngay_Khai_Thac_Sua \ 100) * 100
        '    myEnd_Date = (Ngay_Khai_Thac_Sua \ 100) * 100 + 99
        'ElseIf Id_Phan_Loai = 1 Then  'Đường Thư Nội Tỉnh: Chuyến Thư tăng theo Tháng
        '    myStart_Date = (Ngay_Khai_Thac_Sua \ 100) * 100
        '    myEnd_Date = (Ngay_Khai_Thac_Sua \ 100) * 100 + 99
        'Else : Id_Phan_Loai = 2 Or Id_Phan_Loai = 3 Or Id_Phan_Loai = 4 'Đường Thư Liên Tỉnh,Liền kề, Quốc tê: Chuyến Thư tăng theo Năm
        '    myStart_Date = (Ngay_Khai_Thac_Sua \ 10000) * 10000
        '    myEnd_Date = (Ngay_Khai_Thac_Sua \ 10000) * 10000 + 9999
        'End If
        myStart_Date = (Ngay_Khai_Thac_Sua \ 10000) * 10000
        myEnd_Date = (Ngay_Khai_Thac_Sua \ 10000) * 10000 + 9999
        cbChuyenThuSua.DataSource = myChuyen_Thu_Di.Danh_Sach_Chuyen_Thu(Id_Duong_Thu_Sua, myStart_Date, myEnd_Date).Tables(0)
        cbChuyenThuSua.DataBind()
    End Sub
    Private Sub cbDuongThuSua_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDuongThuSua.Validated
        If (cbDuongThuSua.Text = "") Then
            CMessageBox.Show("Bạn chưa chọn bưu cục nhận chuyến thư ", "Thiếu thông tin về đường thư đóng đi")
            UltraButton1.Focus()
        ElseIf cbDuongThuSua.Text <> "" Then
            Dim Id_Duong_Thu As String = myDuong_Thu_Di.Select_Id_Duong_Thu_Di(GBuu_Cuc_Khai_Thac, Convert.ToInt32(cbDuongThuSua.Text))
            If Id_Duong_Thu Is Nothing Then
                CMessageBox.Show("Không tồn tại đường thư này bạn phải vào bảng Đường Thư Đi để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cbDuongThuSua.Text = ""
                cbDuongThuSua.Select()
                Exit Sub
            End If
            '   cbChuyenThusua bind
            'ChuyenThusua_DataBind()
            '''   cbChuyenThuSua bind
            'ChuyenThuSua_DataBind()
            '''   lblsua
            Dim Ngay_Khai_Thac As Integer = Ham_Dung_Chung.ConvertDateToInt(dtpNgayKhaiThacSua.Value)
            Dim Id_Phan_Loai As Integer = myDuong_Thu_Di.Lay(Id_Duong_Thu).Id_Phan_Loai
            Dim myStart_Date As Integer
            Dim myEnd_Date As Integer
            'If Id_Phan_Loai = 0 Then  'Đường Thư Bưu Tá: Chuyến Thư tăng theo Ngày
            '    myStart_Date = (Ngay_Khai_Thac \ 100) * 100
            '    myEnd_Date = (Ngay_Khai_Thac \ 100) * 100 + 99
            'ElseIf Id_Phan_Loai = 1 Then  'Đường Thư Nội Tỉnh: Chuyến Thư tăng theo Tháng
            '    myStart_Date = (Ngay_Khai_Thac \ 100) * 100
            '    myEnd_Date = (Ngay_Khai_Thac \ 100) * 100 + 99
            'Else : Id_Phan_Loai = 2 Or Id_Phan_Loai = 3 Or Id_Phan_Loai = 4 'Đường Thư Liên Tỉnh,Liền kề, Quốc tê: Chuyến Thư tăng theo Năm
            '    myStart_Date = (Ngay_Khai_Thac \ 10000) * 10000
            '    myEnd_Date = (Ngay_Khai_Thac \ 10000) * 10000 + 9999
            'End If
            myStart_Date = (Ngay_Khai_Thac \ 10000) * 10000
            myEnd_Date = (Ngay_Khai_Thac \ 10000) * 10000 + 9999
            Dim Tong_So_E2 As String = myChuyen_Thu_Di.Lay_Tong_E2_E1_Theo_Id_Duong_Thu(Id_Duong_Thu, myStart_Date, myEnd_Date).Tong_So_Tui
            Dim Tong_So_E1 As String = myChuyen_Thu_Di.Lay_Tong_E2_E1_Theo_Id_Duong_Thu(Id_Duong_Thu, myStart_Date, myEnd_Date).Tong_So_BP
            Dim Tong_KLBP As String = myChuyen_Thu_Di.Lay_Tong_E2_E1_Theo_Id_Duong_Thu(Id_Duong_Thu, myStart_Date, myEnd_Date).Tong_KLBP
            lblSua.Text = "                 Chưa điền đầy đủ dữ liệu" & vbNewLine & "BC khai thác: " & GTen_Buu_Cuc_Khai_Thac & vbNewLine & "Tổng E2: " & Tong_So_E2 & ";  Tổng E1: " & Tong_So_E1 & ";  Trọng luợng: " & Tong_KLBP
        End If
        'If cbDuongThuSua.Text <> "" Then
        '    Dim Id_Duong_Thu_Sua As String = GBuu_Cuc_Khai_Thac.ToString + cbDuongThuSua.Text
        '    If Id_Duong_Thu_Sua Is Nothing Then
        '        CMessageBox.Show("Không tồn tại đường thư này bạn phải vào bảng Đường Thư Đi để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        cbDuongThuSua.Text = ""
        '        cbDuongThuSua.Select()
        '        Exit Sub
        '    End If
        '    'cbChuyenThuSua bind
        '    ChuyenThuSua_DataBind()
        '    '' lblCanSua
        '    Dim Ngay_Khai_Thac_Sua As Integer = myHamdungchung.ConvertDateToInt(dtpNgayKhaiThacSua.Value)
        '    Dim Id_Phan_Loai As Integer = myDuong_Thu_Di.Lay(Id_Duong_Thu_Sua).Id_Phan_Loai
        '    Dim myStart_Date As Integer
        '    Dim myEnd_Date As Integer
        '    If Id_Phan_Loai = 0 Then  'Đường Thư Bưu Tá: Chuyến Thư tăng theo Ngày
        '        myStart_Date = (Ngay_Khai_Thac_Sua \ 100) * 100
        '        myEnd_Date = (Ngay_Khai_Thac_Sua \ 100) * 100 + 99
        '    ElseIf Id_Phan_Loai = 1 Then  'Đường Thư Nội Tỉnh: Chuyến Thư tăng theo Tháng
        '        myStart_Date = (Ngay_Khai_Thac_Sua \ 100) * 100
        '        myEnd_Date = (Ngay_Khai_Thac_Sua \ 100) * 100 + 99
        '    Else : Id_Phan_Loai = 2 Or Id_Phan_Loai = 3 Or Id_Phan_Loai = 4 'Đường Thư Liên Tỉnh,Liền kề, Quốc tê: Chuyến Thư tăng theo Năm
        '        myStart_Date = (Ngay_Khai_Thac_Sua \ 10000) * 10000
        '        myEnd_Date = (Ngay_Khai_Thac_Sua \ 10000) * 10000 + 9999
        '    End If
        '    Dim Tong_So_E2 As String = myChuyen_Thu_Di.Lay_Tong_E2_E1_Theo_Id_Duong_Thu(Id_Duong_Thu_Sua, myStart_Date, myEnd_Date).Tong_So_Tui
        '    Dim Tong_So_E1 As String = myChuyen_Thu_Di.Lay_Tong_E2_E1_Theo_Id_Duong_Thu(Id_Duong_Thu_Sua, myStart_Date, myEnd_Date).Tong_So_BP
        '    Dim Tong_KLBP As String = myChuyen_Thu_Di.Lay_Tong_E2_E1_Theo_Id_Duong_Thu(Id_Duong_Thu_Sua, myStart_Date, myEnd_Date).Tong_KLBP
        '    'lblSua
        '    lblSua.Text = "                 Chưa điền đầy đủ dữ liệu" & vbNewLine & "BC khai thác: " & GTen_Buu_Cuc_Khai_Thac & vbNewLine & "Tổng E2: " & Tong_So_E2 & ";  Tổng số E1: " & Tong_So_E1 & ";  Trọng luợng: " & Tong_KLBP
        'End If
    End Sub
    Private Sub TuiSoSua_DataBind()
        'Dim Id_Duong_Thu As String = cbDuongThuSua.Text + GBuu_Cuc_Khai_Thac.ToString
        'Dim Id_Duong_Thu As String = myDuong_Thu_Di.Select_Id_Duong_Thu_Di(GBuu_Cuc_Khai_Thac.ToString, cbDuongThuSua.Text)
        'Dim Id_Chuyen_Thu As String = myChuyen_Thu_Di.Lay_Id_Chuyen_Thu(Id_Duong_Thu, myHamdungchung.ConvertDateToInt(dtpNgayKhaiThacSua.DateTime), cbChuyenThuSua.Value).Id_Chuyen_Thu
        'cbTuiSoSua.DataSource = myE2_Di.Danh_Sach_Tui_So(Id_Chuyen_Thu).Tables(0)
        'cbTuiSoSua.DataBind()
    End Sub
    Private Sub cbTuiSoSua_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTuiSoSua.Validated
        If cbTuiSoSua.Text <> "" And cbChuyenThuSua.Text <> "" And cbDuongThuSua.Text <> "" Then
            Dim Id_Duong_Thu As String = myDuong_Thu_Di.Select_Id_Duong_Thu_Di(GBuu_Cuc_Khai_Thac, Convert.ToInt32(cbDuongThuSua.Text))
            '' Khai báo
            Dim Ngay_Khai_Thac As Integer = myHamdungchung.ConvertDateToInt(dtpNgayKhaiThacSua.Value)
            Dim Id_Phan_Loai As Integer = myDuong_Thu_Di.Lay(Id_Duong_Thu).Id_Phan_Loai
            Dim myStart_Date As Integer
            Dim myEnd_Date As Integer
            'If Id_Phan_Loai = 0 Then  'Đường Thư Bưu Tá: Chuyến Thư tăng theo Ngày
            '    myStart_Date = (Ngay_Khai_Thac \ 100) * 100
            '    myEnd_Date = (Ngay_Khai_Thac \ 100) * 100 + 99
            'ElseIf Id_Phan_Loai = 1 Then  'Đường Thư Nội Tỉnh: Chuyến Thư tăng theo Tháng
            '    myStart_Date = (Ngay_Khai_Thac \ 100) * 100
            '    myEnd_Date = (Ngay_Khai_Thac \ 100) * 100 + 99
            'Else : Id_Phan_Loai = 2 Or Id_Phan_Loai = 3 Or Id_Phan_Loai = 4 'Đường Thư Liên Tỉnh,Liền kề, Quốc tê: Chuyến Thư tăng theo Năm
            '    myStart_Date = (Ngay_Khai_Thac \ 10000) * 10000
            '    myEnd_Date = (Ngay_Khai_Thac \ 10000) * 10000 + 9999
            'End If
            myStart_Date = (Ngay_Khai_Thac \ 10000) * 10000
            myEnd_Date = (Ngay_Khai_Thac \ 10000) * 10000 + 9999
            'Dim Id_Chuyen_Thu As String = myChuyen_Thu_Di.Lay_Id_Chuyen_Thu(Id_Duong_Thu, myStart_Date, myEnd_Date, cbChuyenThusua.Value).Id_Chuyen_Thu
            Dim Id_Chuyen_Thu As String = myChuyen_Thu_Di.Chuyen_Thu_Di_Chi_Tiet_Lay_Boi_Duong_Thu_Di_Ngay_So_Chuyen_Thu_Loai_Chuyen_Thu_KT(Id_Duong_Thu, myStart_Date, myEnd_Date, cbChuyenThuSua.Value, cbPhanLoaiSua.Value).Id_Chuyen_Thu

            Dim Tui_So As Integer = cbTuiSoSua.Value
           
            Dim Tong_So_E1 As String = myE2_Di.Lay_TT_E1(Id_Chuyen_Thu, Tui_So).Tong_So_BP
            Dim Khoi_Luong As Integer = myE2_Di.Lay_TT_E1(Id_Chuyen_Thu, Tui_So).Khoi_Luong_BP
            Dim Id_Ca As String = myE2_Di.Lay_TT_E1(Id_Chuyen_Thu, Tui_So).Id_Ca
            Dim Gio_Dong As Integer = myE2_Di.Lay_TT_E1(Id_Chuyen_Thu, Tui_So).Gio_Dong
            Dim Id_E2 As String = myE2_Di.Lay_TT_E1(Id_Chuyen_Thu, Tui_So).Id_E2
            Dim Ngay_Dong As Integer = myE2_Di.Lay_TT_E1(Id_Chuyen_Thu, Tui_So).Ngay_Dong
            Dim Ten_Dang_Nhap As String = myNguoi_Dung.Lay(myE1_Di.Lay_Id_Nguoi_Dung(Id_E2)).Ten_Dang_Nhap
            
            '' lblSua
            lblSua.Text = ""
            lblSua.Text = "                 " & vbNewLine & "BC khai thác: " & GTen_Buu_Cuc_Khai_Thac & vbNewLine & "Tổng E1: " & Tong_So_E1 & "; Trọng Lượng: " & Khoi_Luong & vbNewLine & Ten_Dang_Nhap.ToUpper & vbNewLine & Ham_Dung_Chung.ConvertIntToVNDateType(Ngay_Dong) & " " & Ham_Dung_Chung.ConvertIntToTime(Gio_Dong)
        ElseIf (cbTuiSoSua.Text = "") Then
            CMessageBox.Show("Chưa có thông tin về chuyến thư", "Thiếu thông tin về chuyến thư ")
            cbDuongThuSua.Focus()
        End If
    End Sub
#End Region

#Region "XOA"
    Private Sub btnXoaE1E2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoaE2.Click
        If cbDuongThuCanSua.Text = "" Or cbChuyenThuCanSua.Text = "" Or cbTuiSoCanSua.Text = "" Then
            CMessageBox.Show("Dữ liệu chưa đầy đủ, bạn hãy kiểm tra lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim Id_Duong_Thu As String = myDuong_Thu_Di.Select_Id_Duong_Thu_Di(GBuu_Cuc_Khai_Thac, Convert.ToInt32(cbDuongThuCanSua.Text))
        If Id_Duong_Thu Is Nothing Then
            CMessageBox.Show("Không tồn tại đường thư này bạn phải vào bảng Đường Thư Đi để cập nhật,", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        'Ngay dong
        Dim Ngay_Dong As Integer = Ham_Dung_Chung.ConvertDateToInt(dtpNgayKhaiThacCanSua.Value)
        Dim myStart_Date As Integer
        Dim myEnd_Date As Integer
        ''If Id_Phan_Loai = 0 Then  'Đường Thư Bưu Tá: Chuyến Thư tăng theo Ngày
        ''    myStart_Date = (Ngay_Khai_Thac \ 100) * 100
        ''    myEnd_Date = (Ngay_Khai_Thac \ 100) * 100 + 99
        ''ElseIf Id_Phan_Loai = 1 Then  'Đường Thư Nội Tỉnh: Chuyến Thư tăng theo Tháng
        ''    myStart_Date = (Ngay_Khai_Thac \ 100) * 100
        ''    myEnd_Date = (Ngay_Khai_Thac \ 100) * 100 + 99
        ''Else : Id_Phan_Loai = 2 Or Id_Phan_Loai = 3 Or Id_Phan_Loai = 4 'Đường Thư Liên Tỉnh,Liền kề, Quốc tê: Chuyến Thư tăng theo Năm
        ''    myStart_Date = (Ngay_Khai_Thac \ 10000) * 10000
        ''    myEnd_Date = (Ngay_Khai_Thac \ 10000) * 10000 + 9999
        ''End If
        'Coi tat ca deu tang theo NAM
        myStart_Date = (Ngay_Dong \ 10000) * 10000
        myEnd_Date = (Ngay_Dong \ 10000) * 10000 + 9999
        Dim Id_Chuyen_Thu As String = myChuyen_Thu_Di.Lay_Id_Chuyen_Thu(Id_Duong_Thu, myStart_Date, myEnd_Date, cbChuyenThuCanSua.Value).Id_Chuyen_Thu
        ''Sua lai theo dac thu tren EMS - QUOC TE - By TRUNGDQ - 2008/12/10
        'Dim Id_Chuyen_Thu As String = myChuyen_Thu_Di.Lay_Id_Chuyen_Thu_QT(Id_Duong_Thu, Ngay_Dong, cbChuyenThuCanSua.Value).Id_Chuyen_Thu
        Dim Tui_So As Integer = cbTuiSoCanSua.Value
        Dim Id_E2 As String = myE2_Di.Lay_TT_E1(Id_Chuyen_Thu, Tui_So).Id_E2
        Dim Gio As Integer = myHamdungchung.ConvertTimeToInt(txtGioKhaiThacCanSua.Value)
        Dim Ca_Ke_Toan As Integer = cbCaKeToanCanSua.Value
        Dim Ngay_Ke_Toan As Integer = myHamdungchung.ConvertDateToInt(dtpNgayKeToan.Value)
        Dim Id_Ca As String = myCa_San_Xuat.Lay_Id_Ca(GBuu_Cuc_Khai_Thac, Ngay_Ke_Toan, Ca_Ke_Toan).Id_Ca
        Dim Str As String = "Bạn có đồng ý xoá tờ E2:" & vbNewLine & "Ngày:" & Ham_Dung_Chung.ConvertIntToVNDateType(Ngay_Dong) & vbNewLine & "Đường thư: " & cbDuongThuCanSua.Text & vbNewLine & "Chuyến thư: " & cbChuyenThuCanSua.Text & vbNewLine & "Túi số: " & cbTuiSoCanSua.Text
        'Kiem tra chot SL
        If myE2_Di.Lay(Id_E2).Chot_SL Then
            MessageBox.Show("Chuyến thư này đã được chốt số liệu, bạn không thể xoá tờ E2 này." & vbNewLine & "Hãy liên hệ với trưởng ca để mở chốt số liệu, sau đó bạn mới có thể xoá được tờ E2 này", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        'Thong bao xoa
        If MessageBox.Show(Str, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            'Them phan Ghi Log (Chuan bi du lieu) ========================================
            Dim myBo_Phan As Integer = 2  'Thiet lap di
            Dim myChi_Tiet_Truoc As String   'Chi tiet truoc khi xoa E2
            Dim myChi_Tiet_Sau As String     'Chi tiet sau khi xoa E2
            Dim myE2_Di_Chi_Tiet_Ghi_Log As New E2_Di_Chi_Tiet  'Thong tin chi tiet cua E2 se xoa
            myE2_Di_Chi_Tiet_Ghi_Log = myE2_Di.Lay(Id_E2)
            'Tao chi tiet truoc
            myChi_Tiet_Truoc = Mdl_Event_Viewer.Event_Viewer_Create_Chi_Tiet_E2(myE2_Di_Chi_Tiet_Ghi_Log.Id_Duong_Thu, myE2_Di_Chi_Tiet_Ghi_Log.Ngay_Dong, cbPhanLoaiCanSua.Value, cbChuyenThuCanSua.Text, cbTuiSoCanSua.Text, myE2_Di_Chi_Tiet_Ghi_Log.Tong_So_BP, myE2_Di_Chi_Tiet_Ghi_Log.Khoi_Luong_BP)
            'Tao chi tiet sau
            myChi_Tiet_Sau = ""
            '============================================================================== 

            myE2_Di.Xoa(Id_E2)
            myE1_Di.Xoa_Tui(Id_E2)
            'myE2_Di.Xoa_Chuyen_Thu(Id_Chuyen_Thu)
            myChuyen_Thu_Di.Hieu_Chinh(Id_Chuyen_Thu, True)

            'xoa du lieu truyen (trong den_tam)
            Dim myE2_Den_Tam As New E2_Den_Tam(GConnectionString)
            Dim myE1_Den_Tam As New E1_Den_Tam(GConnectionString)
            myE2_Den_Tam.Xoa(Id_E2)
            myE1_Den_Tam.Xoa_Tui(Id_E2)

            'Them phan Ghi Log (Ghi Du lieu Log )==========================================
            'Ghi vao Log
            Mdl_Event_Viewer.Event_Viewer_Delete_E2(myBo_Phan, myChi_Tiet_Truoc, myChi_Tiet_Sau)
            '==============================================================================

            CMessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
#End Region

#Region "SUA"
    Private Sub btnSua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua.Click
        'Kiem tra thong tin nhap vao tren form
        If cbDuongThuSua.Text = "" Or cbChuyenThuSua.Text = "" Or cbTuiSoSua.Text = "" Or cbPhanLoaiSua.Text = "" Then
            CMessageBox.Show("Dữ liệu chữa đầy đủ, bạn hãy kiểm tra lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbDuongThuSua.Select()
            Exit Sub
        End If
        'Kiem tra gio dong da nhap hop le chua
        If Me.txtGioKhaiThacSua.Value = "" Or Me.txtGioKhaiThacSua.Value = Nothing Or Me.txtGioKhaiThacSua.Value Is System.DBNull.Value Then
            CMessageBox.Show("Giờ đóng nhập vào không hợp lệ. Mời bạn nhập lại giờ đóng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtGioKhaiThacSua.Select()
            Exit Sub
        End If
        '------------------------
        Dim myStart_Date As Integer
        Dim myEnd_Date As Integer
        '------------------------
        'LAY THONG TIN CAN SUA
        Dim Ngay_Dong_Can_Sua As Integer = myHamdungchung.ConvertDateToInt(Me.dtpNgayKhaiThacCanSua.Value)
        Dim Gio_Dong_Can_Sua As Integer = myHamdungchung.ConvertTimeToInt(Me.txtGioKhaiThacCanSua.Value)
        Dim Ngay_Khai_Thac_Can_Sua As Integer = myHamdungchung.ConvertDateToInt(Me.dtpNgayKeToan.Value)
        Dim Ca_Khai_Thac_Can_Sua As Integer = CInt(Me.cbCaKeToanCanSua.Text)
        Dim Id_Duong_Thu_Can_Sua As String = CreateId_Duong_Thu(GBuu_Cuc_Khai_Thac.ToString, cbDuongThuCanSua.Text)
        'Coi tat ca deu tang theo NAM
        myStart_Date = (Ngay_Dong_Can_Sua \ 10000) * 10000
        myEnd_Date = (Ngay_Dong_Can_Sua \ 10000) * 10000 + 9999
        Dim So_Chuyen_Thu_Can_Sua As Integer = CInt(Me.cbChuyenThuCanSua.Text)
        Dim Loai_Chuyen_Thu_Can_Sua As String = Me.cbPhanLoaiCanSua.Text
        Dim Id_Ca_Can_Sua As String = myCa_San_Xuat.Lay_Id_Ca(GBuu_Cuc_Khai_Thac, Ngay_Khai_Thac_Can_Sua, Ca_Khai_Thac_Can_Sua).Id_Ca
        'Chuyen thu can sua
        Dim Id_Chuyen_Thu_Can_Sua As String = myChuyen_Thu_Di.Chuyen_Thu_Di_Chi_Tiet_Lay_Boi_Duong_Thu_Di_Ngay_So_Chuyen_Thu_Loai_Chuyen_Thu_KT(Id_Duong_Thu_Can_Sua, myStart_Date, myEnd_Date, So_Chuyen_Thu_Can_Sua, Loai_Chuyen_Thu_Can_Sua).Id_Chuyen_Thu
        Dim MyChuyen_Thu_Di_Chi_Tiet_Can_Sua As New Chuyen_Thu_Di_Chi_Tiet
        MyChuyen_Thu_Di_Chi_Tiet_Can_Sua = myChuyen_Thu_Di.Lay(Id_Chuyen_Thu_Can_Sua)
        'E2 Can Sua
        Dim Tui_So_Can_Sua As Integer = CInt(Me.cbTuiSoCanSua.Text)
        Dim Id_E2_Can_Sua As String = CreateId_E2(Id_Chuyen_Thu_Can_Sua, Tui_So_Can_Sua)
        Dim myE2_Di_Chi_Tiet_Can_Sua As New E2_Di_Chi_Tiet
        myE2_Di_Chi_Tiet_Can_Sua = myE2_Di.Lay(Id_E2_Can_Sua)
        '------------------------

        'LAY THONG TIN SUA
        Dim Ngay_Dong_Sua As Integer = myHamdungchung.ConvertDateToInt(Me.dtpNgayKhaiThacSua.Value)
        Dim Gio_Dong_Sua As Integer = myHamdungchung.ConvertTimeToInt(Me.txtGioKhaiThacSua.Value)
        Dim Ngay_Khai_Thac_Sua As Integer = myHamdungchung.ConvertDateToInt(Me.dtpNgayKeToanSua.Value)
        Dim Ca_Khai_Thac_Sua As Integer = CInt(Me.cbCaKeToanSua.Text)
        Dim Id_Duong_Thu_Sua As String = CreateId_Duong_Thu(GBuu_Cuc_Khai_Thac.ToString, cbDuongThuSua.Text)
        Dim So_Chuyen_Thu_Sua As Integer = CInt(Me.cbChuyenThuSua.Text)
        Dim Loai_Chuyen_Thu_Sua As String = Me.cbPhanLoaiSua.Text
        Dim Id_Ca_Sua As String = myCa_San_Xuat.Lay_Id_Ca(GBuu_Cuc_Khai_Thac, Ngay_Khai_Thac_Sua, Ca_Khai_Thac_Sua).Id_Ca
        'Chuyen thu sua
        myStart_Date = (Ngay_Dong_Sua \ 10000) * 10000
        myEnd_Date = (Ngay_Dong_Sua \ 10000) * 10000 + 9999
        Dim Id_Chuyen_Thu_Sua As String = myChuyen_Thu_Di.Chuyen_Thu_Di_Chi_Tiet_Lay_Boi_Duong_Thu_Di_Ngay_So_Chuyen_Thu_Loai_Chuyen_Thu_KT(Id_Duong_Thu_Sua, myStart_Date, myEnd_Date, So_Chuyen_Thu_Sua, Loai_Chuyen_Thu_Sua).Id_Chuyen_Thu
        'E2 Sua
        Dim Tui_So_Sua As Integer = CInt(Me.cbTuiSoSua.Text)
        Dim Id_E2_Sua As String = CreateId_E2(Id_Chuyen_Thu_Sua, Tui_So_Sua)
        '------------------------

        'Them phan Ghi Log (Chuan bi du lieu) ========================================
        Dim myBo_Phan As Integer = 2  'Thiet lap di
        Dim myChi_Tiet_Truoc As String   'Chi tiet truoc khi sua E2
        Dim myChi_Tiet_Sau As String     'Chi tiet sau khi sua E2
        'Tao chi tiet truoc
        myChi_Tiet_Truoc = Mdl_Event_Viewer.Event_Viewer_Create_Chi_Tiet_E2(Id_Duong_Thu_Can_Sua, Ngay_Dong_Can_Sua, Loai_Chuyen_Thu_Can_Sua, So_Chuyen_Thu_Can_Sua, Tui_So_Can_Sua, myE2_Di_Chi_Tiet_Can_Sua.Tong_So_BP, myE2_Di_Chi_Tiet_Can_Sua.Khoi_Luong_BP)
        'Tao chi tiet sau
        myChi_Tiet_Sau = Mdl_Event_Viewer.Event_Viewer_Create_Chi_Tiet_E2(Id_Duong_Thu_Sua, Ngay_Dong_Sua, Loai_Chuyen_Thu_Sua, So_Chuyen_Thu_Sua, Tui_So_Sua, myE2_Di_Chi_Tiet_Can_Sua.Tong_So_BP, myE2_Di_Chi_Tiet_Can_Sua.Khoi_Luong_BP)
        '============================================================================== 

        'Kiem tra cac truong hop khong thuc hien duoc viec sua chua
        '1a. Kiem tra Chot so hoac da dong F lieu tren E2 thi khong cho phep sua
        If myE2_Di_Chi_Tiet_Can_Sua.Chot_SL = True Then
            CMessageBox.Show("Ðã chốt số liệu, bạn không thể sửa túi này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbTuiSoCanSua.Select()
            Exit Sub
        End If
        If myE2_Di_Chi_Tiet_Can_Sua.Tui_F = True Then
            CMessageBox.Show("Túi đã đóng F, bạn không thể sửa túi này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbTuiSoCanSua.Select()
            Exit Sub
        End If
        '1b. Tui Da ton tai , khong cho phep thu hien
        If Id_E2_Can_Sua.Trim <> Id_E2_Sua.Trim And myE2_Di.Lay(Id_E2_Sua).Id_Chuyen_Thu <> "" Then
            CMessageBox.Show("Túi này đã tồn tại, bạn không thể sửa thông tin sang túi này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbTuiSoSua.Select()
            Exit Sub
        End If
        '2. Kiem tra duong thu co ton tai khong
        If myDuong_Thu_Di.Lay(Id_Duong_Thu_Can_Sua).Ma_Bc_Khai_Thac = 0 Or myDuong_Thu_Di.Lay(Id_Duong_Thu_Sua).Ma_Bc_Khai_Thac = 0 Then
            CMessageBox.Show("Không tồn tại đường thư này bạn phải vào bảng Đường Thư Đến để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbDuongThuSua.Select()
            Exit Sub
        End If
        '3. Kiem tra ngay ke toan khong duoc phep nho hon ngay dong
        If Ngay_Dong_Sua > Ngay_Khai_Thac_Sua Then
            If MessageBox.Show("Ngày đóng E2 không được lớn hơn ngày khai thác, trừ trường hợp làm ca 3. Nếu sửa túi có thể sẽ dẫn đến sai sót!!!" & vbNewLine & "Bạn có thực sự muốn sửa không?  Chọn Yes để tiếp tục, chọn No để sửa lại thông tin ngày đóng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                dtpNgayKhaiThacSua.Focus()
                Exit Sub
            End If
        End If
        '4. Kiem tra ca khai thac cua thong tin moi da ton tai chua
        If Id_Ca_Sua.Trim = "" Then
            CMessageBox.Show("Thông tin sửa không hợp lệ. Không tồn tại ca khai thác này." & vbNewLine & "Mời bạn nhập lại thông tin ca khai thác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbCaKeToanSua.Select()
            Exit Sub
        End If
        '5. Kiem tra chuyen thu da dong F chua
        If myChuyen_Thu_Di.Lay(Id_Chuyen_Thu_Can_Sua).Dong_F = True Then
            If MessageBox.Show("Chú ý, chuyến thư này đã đóng F, nếu sửa túi có thể sẽ dẫn đến sai sót!!!" & vbNewLine & "Bạn có thực sự muốn sửa không?  Chọn Yes để tiếp tục, chọn No để nhập lại thông tin sửa đổi", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                cbDuongThuSua.Select()
                Exit Sub
            End If
        End If
        'Noi dung Thong bao sua doi
        Dim Str As String = "   Bạn có muốn cập nhập bản kê:" & vbNewLine & "Ngày: " & Ham_Dung_Chung.ConvertIntToVNDateType(Ngay_Dong_Can_Sua) & " , Giờ: " & Ham_Dung_Chung.ConvertIntToTime(Gio_Dong_Can_Sua) & vbNewLine & "Ngày kt: " & Ham_Dung_Chung.ConvertIntToVNDateType(Ngay_Khai_Thac_Can_Sua) & ", Ca kt: " & Ca_Khai_Thac_Can_Sua & vbNewLine & "Đường thư: " & cbDuongThuCanSua.Text & ", chuyến thư: " & So_Chuyen_Thu_Can_Sua & ", loại chuyến thư: " & Loai_Chuyen_Thu_Can_Sua & ", túi số: " & Tui_So_Can_Sua & "." & vbNewLine & vbNewLine & "   Với thông tin mới là:" & vbNewLine & "Ngày: " & Ham_Dung_Chung.ConvertIntToVNDateType(Ngay_Dong_Sua) & " , Giờ: " & Ham_Dung_Chung.ConvertIntToTime(Gio_Dong_Sua) & vbNewLine & "Ngày kt: " & Ham_Dung_Chung.ConvertIntToVNDateType(Ngay_Khai_Thac_Sua) & ", Ca kt: " & Ca_Khai_Thac_Sua & vbNewLine & "Đường thư: " & cbDuongThuSua.Text & ", chuyến thư: " & So_Chuyen_Thu_Sua & ", loại chuyến thư: " & Loai_Chuyen_Thu_Sua & ", túi số: " & Tui_So_Sua & "."
        Dim isChuyen_Thu_Moi As Boolean
        'Thay doi Id_Chuyen_Thu
        If Id_Duong_Thu_Can_Sua <> Id_Duong_Thu_Sua Or Ngay_Dong_Can_Sua <> Ngay_Dong_Sua Or Loai_Chuyen_Thu_Can_Sua <> Loai_Chuyen_Thu_Sua Or So_Chuyen_Thu_Can_Sua <> So_Chuyen_Thu_Sua Then
            'Kiem tra chuyen thu da ton tai chua
            'If myChuyen_Thu_Di.Lay(Id_Chuyen_Thu_Sua).Id_Duong_Thu <> "" And myChuyen_Thu_Di.Chuyen_Thu_Di_Tong_Hop_Tu_E2_Di_KT(Id_Chuyen_Thu_Can_Sua).Tong_So_Tui > 1 Then 'Neu da ton tai
            If myChuyen_Thu_Di.Lay(Id_Chuyen_Thu_Sua).Id_Duong_Thu <> "" Then 'Neu da ton tai
                isChuyen_Thu_Moi = False
                'Kiem tra trang thai chuyen thu (da chot_sl hoac da dong F)
                If (myChuyen_Thu_Di.Lay(Id_Chuyen_Thu_Sua).Chot_Sl = True Or myChuyen_Thu_Di.Lay(Id_Chuyen_Thu_Sua).Dong_F = True) Then
                    CMessageBox.Show("Chuyến thư đã đóng F hoặc đã chốt số liệu, bạn không thể sửa túi vào chuyến thư này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            Else   'Neu chua ton tai chuyen thu thi tao moi
                isChuyen_Thu_Moi = True
            End If
        End If
        If MessageBox.Show(Str, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If isChuyen_Thu_Moi = True Then
                Id_Chuyen_Thu_Sua = CreateId_Chuyen_Thu(Id_Duong_Thu_Sua, So_Chuyen_Thu_Sua, Ngay_Dong_Sua, Loai_Chuyen_Thu_Sua)
                myChuyen_Thu_Di.Cap_Nhat_Them(Id_Chuyen_Thu_Sua, Id_Duong_Thu_Sua, Id_Ca_Sua, GBuu_Cuc_Khai_Thac, So_Chuyen_Thu_Sua, Ngay_Dong_Sua, Gio_Dong_Sua, myE2_Di_Chi_Tiet_Can_Sua.Ngay_Nhan, myE2_Di_Chi_Tiet_Can_Sua.Gio_Nhan, 0, 0, 0, 0, 0, 0, 0, 0, 0, myE2_Di_Chi_Tiet_Can_Sua.Tui_F, myE2_Di_Chi_Tiet_Can_Sua.Truyen_Khai_Thac, myE2_Di_Chi_Tiet_Can_Sua.Truyen_Doi_Soat, myE2_Di_Chi_Tiet_Can_Sua.Ngay_He_Thong, myE2_Di_Chi_Tiet_Can_Sua.Chot_SL)
            End If
            'Cap nhat E2
            Id_E2_Sua = CreateId_E2(Id_Chuyen_Thu_Sua, Tui_So_Sua)
            myE2_Di.E2_Di_Cap_Nhat_Id_E2_Sua(Id_E2_Can_Sua, Id_E2_Sua, Id_Duong_Thu_Can_Sua, Id_Duong_Thu_Sua, Id_Chuyen_Thu_Can_Sua, Id_Chuyen_Thu_Sua, Id_Ca_Sua, Ngay_Dong_Sua, Gio_Dong_Sua, Tui_So_Sua)
            'Cap nhat E1
            myE1_Di.Cap_Nhat_Id_E1(Id_E2_Can_Sua, Id_E2_Sua, Id_Duong_Thu_Can_Sua, Id_Duong_Thu_Sua, Id_Chuyen_Thu_Can_Sua, Id_Chuyen_Thu_Sua, Id_Ca_Can_Sua, Id_Ca_Sua, Ngay_Dong_Can_Sua, Ngay_Dong_Sua, Gio_Dong_Can_Sua, Gio_Dong_Sua)
            'Hieu chinh lai thong tin chuyen thu can sua
            myChuyen_Thu_Di.Hieu_Chinh(Id_Chuyen_Thu_Can_Sua, True)
            'Hieu chinh thong tin chuyen thu sua
            myChuyen_Thu_Di.Hieu_Chinh(Id_Chuyen_Thu_Sua, True)

            'Them phan Ghi Log (Ghi Du lieu Log )==========================================
            'Ghi vao Log
            Mdl_Event_Viewer.Event_Viewer_Edit_E2(myBo_Phan, myChi_Tiet_Truoc, myChi_Tiet_Sau)
            '==============================================================================

            'Thong bao ket qua khi ket thuc
            CMessageBox.Show("Ðã cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            dtpNgayKhaiThacSua.Select()
            Exit Sub
        End If
        ResetControl()
    End Sub
#End Region

#Region "BTN Sua E2 Loi"
    Private Sub btnSuaE2Loi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuaE2Loi.Click
        If cbDuongThuCanSua.Text = "" Or cbChuyenThuCanSua.Text = "" Or cbTuiSoCanSua.Text = "" Then
            CMessageBox.Show("Dữ liệu chưa đầy đủ, bạn hãy kiểm tra lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim Id_Duong_Thu As String = myDuong_Thu_Di.Select_Id_Duong_Thu_Di(GBuu_Cuc_Khai_Thac, Convert.ToInt32(cbDuongThuCanSua.Text))
        '' Kiểm tra sự tồn tại của Đường Thư.
        If Id_Duong_Thu Is Nothing Then
            CMessageBox.Show("Không tồn tại đường thư này bạn phải vào bảng Đường Thư Đi để cập nhật !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim Ngay_Khai_Thac As Integer = myHamdungchung.ConvertDateToInt(dtpNgayKhaiThacCanSua.Value)
        Dim Gio As Integer = myHamdungchung.ConvertTimeToInt(txtGioKhaiThacCanSua.Value)
        Dim Id_Phan_Loai As Integer = myDuong_Thu_Di.Lay(Id_Duong_Thu).Id_Phan_Loai
        Dim myStart_Date As Integer
        Dim myEnd_Date As Integer
        'If Id_Phan_Loai = 0 Then  'Đường Thư Bưu Tá: Chuyến Thư tăng theo Ngày
        '    myStart_Date = (Ngay_Khai_Thac \ 100) * 100
        '    myEnd_Date = (Ngay_Khai_Thac \ 100) * 100 + 99
        'ElseIf Id_Phan_Loai = 1 Then  'Đường Thư Nội Tỉnh: Chuyến Thư tăng theo Tháng
        '    myStart_Date = (Ngay_Khai_Thac \ 100) * 100
        '    myEnd_Date = (Ngay_Khai_Thac \ 100) * 100 + 99
        'Else : Id_Phan_Loai = 2 Or Id_Phan_Loai = 3 Or Id_Phan_Loai = 4 'Đường Thư Liên Tỉnh,Liền kề, Quốc tê: Chuyến Thư tăng theo Năm
        '    myStart_Date = (Ngay_Khai_Thac \ 10000) * 10000
        '    myEnd_Date = (Ngay_Khai_Thac \ 10000) * 10000 + 9999
        'End If
        myStart_Date = (Ngay_Khai_Thac \ 10000) * 10000
        myEnd_Date = (Ngay_Khai_Thac \ 10000) * 10000 + 9999
        Dim Id_Chuyen_Thu As String = myChuyen_Thu_Di.Chuyen_Thu_Di_Chi_Tiet_Lay_Boi_Duong_Thu_Di_Ngay_So_Chuyen_Thu_Loai_Chuyen_Thu_KT(Id_Duong_Thu, myStart_Date, myEnd_Date, cbChuyenThuCanSua.Value, cbPhanLoaiCanSua.Value).Id_Chuyen_Thu
        Dim Tui_So As Integer = cbTuiSoCanSua.Value
        Dim Id_E2 As String = myE2_Di.Lay_TT_E1(Id_Chuyen_Thu, Tui_So).Id_E2
        Dim Chk As Boolean = myE2_Di.E2_Di_Kiem_Tra(Id_Chuyen_Thu, Tui_So)

        If Chk = True Then 'Nếu bản kê bị lỗi: tổng số = 0
            Dim Tong_So_BP As Integer = myE1_Di.E1_Di_Kiem_Tra_Loi_KT(Id_E2)
            If Tong_So_BP > 0 Then 'Bản kê không lỗi
                If MessageBox.Show("Bản kê E2: " & vbNewLine & "Ngày:" & Ham_Dung_Chung.ConvertIntToVNDateType(Ngay_Khai_Thac) & vbNewLine & "Đường thư: " & cbDuongThuCanSua.Text & ", Chuyến thư: " & cbChuyenThuCanSua.Text & ", Túi số: " & cbTuiSoCanSua.Text & vbNewLine & " Có tổng số: " & Tong_So_BP & " Bưu phẩm" & vbNewLine & " Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Tong_Hop_E2_Di_tu_E1_Di(Id_E2)
                    Tong_Hop_Chuyen_Thu_Di_tu_E2_Di(Id_Chuyen_Thu)
                    CMessageBox.Show("Đã sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else 'Bản kê lỗi
                Dim Str As String = "Bản kê E2: " & vbNewLine & "Ngày:" & Ham_Dung_Chung.ConvertIntToVNDateType(Ngay_Khai_Thac) & vbNewLine & "Đường thư: " & cbDuongThuCanSua.Text & ", Chuyến thư: " & cbChuyenThuCanSua.Text & ", Túi số: " & cbTuiSoCanSua.Text & vbNewLine & " Không tồn tại bưu phẩm nào." & vbNewLine & " Bạn có muốn xóa không?"
                If MessageBox.Show(Str, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Tong_Hop_E2_Di_tu_E1_Di(Id_E2)
                    Tong_Hop_Chuyen_Thu_Di_tu_E2_Di(Id_Chuyen_Thu)
                    CMessageBox.Show("Tờ E2 này không có dữ liệu, đã xoá thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            MessageBox.Show("Bản kê E2 này không bị lỗi!!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        End If
    End Sub
#Region "Tổng hợp E2_Di từ E1_Di"
    Private Sub Tong_Hop_E2_Di_tu_E1_Di(ByVal Id_E2 As String)
        'Lay_Chi_Tiet_E2_Di_tu_Id_E2(Id_E2)
        Dim myE2_Di_Chi_Tiet As New E2_Di_Chi_Tiet
        Dim myE2_Di_TH_E1_Di As New E2_Di_Chi_Tiet

        myE2_Di_Chi_Tiet = myE2_Di.E2_Di_Chi_Tiet_Lay_Boi_Id_E2_KT(Id_E2)
        myE2_Di_TH_E1_Di = myE2_Di.E2_Di_Tong_Hop_Tu_E1_Di_KT(myE2_Di_Chi_Tiet.Id_E2)

        myE2_Di_Chi_Tiet.Tui_F = CBool(False)
        myE2_Di_Chi_Tiet.Tong_So_BP = myE2_Di_TH_E1_Di.Tong_So_BP

        If myE2_Di_Chi_Tiet.Tong_So_BP > 0 Then 'Cập nhật lại thông tin trên E2 nếu tổng số BP>0
            'If txtTrongluongTui.Text <> "" Then
            '    myE2_Di_Chi_Tiet.Khoi_Luong_Vo_Tui = CInt(Trim(txtTrongluongTui.Value))
            'Else
            myE2_Di_Chi_Tiet.Khoi_Luong_Vo_Tui = 100
            'End If
            myE2_Di_Chi_Tiet.Khoi_Luong_BP = myE2_Di_TH_E1_Di.Khoi_Luong_BP
            myE2_Di_Chi_Tiet.Tong_Cuoc_COD = myE2_Di_TH_E1_Di.Tong_Cuoc_COD
            myE2_Di_Chi_Tiet.Tong_Cuoc_DV = myE2_Di_TH_E1_Di.Tong_Cuoc_DV
            myE2_Di_Chi_Tiet.Tong_Cuoc_Chinh = myE2_Di_TH_E1_Di.Tong_Cuoc_Chinh
            myE2_Di_Chi_Tiet.HH_Phat_Hanh = myE2_Di_TH_E1_Di.HH_Phat_Hanh
            myE2_Di_Chi_Tiet.HH_Phat_Tra = myE2_Di_TH_E1_Di.HH_Phat_Tra
            myE2_Di.E2_Di_Cap_Nhat_Them_KT(myE2_Di_Chi_Tiet.Id_E2, myE2_Di_Chi_Tiet.Id_Duong_Thu, myE2_Di_Chi_Tiet.Id_Chuyen_Thu, myE2_Di_Chi_Tiet.Id_Ca, myE2_Di_Chi_Tiet.Ma_Bc_Khai_Thac, myE2_Di_Chi_Tiet.Ngay_Dong, myE2_Di_Chi_Tiet.Gio_Dong, myE2_Di_Chi_Tiet.Ngay_Nhan, myE2_Di_Chi_Tiet.Gio_Nhan, myE2_Di_Chi_Tiet.Tui_So, myE2_Di_Chi_Tiet.Tui_F, myE2_Di_Chi_Tiet.Tong_So_BP, myE2_Di_Chi_Tiet.Khoi_Luong_Vo_Tui, myE2_Di_Chi_Tiet.Khoi_Luong_BP, myE2_Di_Chi_Tiet.Tong_Cuoc_COD, myE2_Di_Chi_Tiet.Tong_Cuoc_DV, myE2_Di_Chi_Tiet.Tong_Cuoc_Chinh, myE2_Di_Chi_Tiet.HH_Phat_Hanh, myE2_Di_Chi_Tiet.HH_Phat_Tra, myE2_Di_Chi_Tiet.Truyen_Khai_Thac, myE2_Di_Chi_Tiet.Truyen_Doi_Soat, myE2_Di_Chi_Tiet.Chot_SL)
        Else 'Nếu không tồn tại E1-> Xóa
            myE2_Di.Xoa(Id_E2)
        End If
    End Sub
#End Region

#Region "Tổng hợp Chuyen_Thu_Di từ E2_Di"
    Private Sub Tong_Hop_Chuyen_Thu_Di_tu_E2_Di(ByVal Id_Chuyen_Thu As String)
        Dim myChuyen_Thu_Di_Chi_Tiet As New Chuyen_Thu_Di_Chi_Tiet
        Dim myChuyen_Thu_Di_TH_tu_E2_Di As New Chuyen_Thu_Di_Chi_Tiet

        myChuyen_Thu_Di_Chi_Tiet = myChuyen_Thu_Di.Chuyen_Thu_Di_Chi_Tiet_Lay_Boi_Id_Chuyen_Thu_KT(Id_Chuyen_Thu)
        myChuyen_Thu_Di_TH_tu_E2_Di = myChuyen_Thu_Di.Chuyen_Thu_Di_Tong_Hop_Tu_E2_Di_KT(myChuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu)

        myChuyen_Thu_Di_Chi_Tiet.Tong_So_Tui = myChuyen_Thu_Di_TH_tu_E2_Di.Tong_So_Tui

        If myChuyen_Thu_Di_Chi_Tiet.Tong_So_Tui > 0 Then 'Nếu tồn tại it nhất 1 bản kê E2 Update lại thông tin trên Chuyến thư
            myChuyen_Thu_Di_Chi_Tiet.Tong_So_BP = myChuyen_Thu_Di_TH_tu_E2_Di.Tong_So_BP
            myChuyen_Thu_Di_Chi_Tiet.Tong_KL = myChuyen_Thu_Di_TH_tu_E2_Di.Tong_KL
            myChuyen_Thu_Di_Chi_Tiet.Tong_KLBP = myChuyen_Thu_Di_TH_tu_E2_Di.Tong_KLBP
            myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc_COD = myChuyen_Thu_Di_TH_tu_E2_Di.Tong_Cuoc_COD
            myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc_DV = myChuyen_Thu_Di_TH_tu_E2_Di.Tong_Cuoc_DV
            myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc = myChuyen_Thu_Di_TH_tu_E2_Di.Tong_Cuoc
            myChuyen_Thu_Di_Chi_Tiet.HH_Phat_Hanh = myChuyen_Thu_Di_TH_tu_E2_Di.HH_Phat_Hanh
            myChuyen_Thu_Di_Chi_Tiet.HH_Phat_Tra = myChuyen_Thu_Di_TH_tu_E2_Di.HH_Phat_Tra
            myChuyen_Thu_Di_Chi_Tiet.Dong_F = myChuyen_Thu_Di_TH_tu_E2_Di.Dong_F
            myChuyen_Thu_Di.Chuyen_Thu_Di_Cap_Nhat_Them_KT(myChuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu, myChuyen_Thu_Di_Chi_Tiet.Id_Duong_Thu, myChuyen_Thu_Di_Chi_Tiet.Id_Ca, myChuyen_Thu_Di_Chi_Tiet.Ma_Bc_Khai_Thac, myChuyen_Thu_Di_Chi_Tiet.So_Chuyen_Thu, myChuyen_Thu_Di_Chi_Tiet.Ngay_Dong, myChuyen_Thu_Di_Chi_Tiet.Gio_Dong, myChuyen_Thu_Di_Chi_Tiet.Ngay_Nhan, myChuyen_Thu_Di_Chi_Tiet.Gio_Nhan, myChuyen_Thu_Di_Chi_Tiet.Tong_So_Tui, myChuyen_Thu_Di_Chi_Tiet.Tong_So_BP, myChuyen_Thu_Di_Chi_Tiet.Tong_KL, myChuyen_Thu_Di_Chi_Tiet.Tong_KLBP, myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc_COD, myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc_DV, myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc, myChuyen_Thu_Di_Chi_Tiet.HH_Phat_Hanh, myChuyen_Thu_Di_Chi_Tiet.HH_Phat_Tra, myChuyen_Thu_Di_Chi_Tiet.Dong_F, myChuyen_Thu_Di_Chi_Tiet.Truyen_Khai_Thac, myChuyen_Thu_Di_Chi_Tiet.Truyen_Doi_Soat, myChuyen_Thu_Di_Chi_Tiet.Chot_Sl)
        Else 'Nếu không tồn tại bản kê E2 nào -> Xóa chuyến thư
            myChuyen_Thu_Di.Xoa(Id_Chuyen_Thu)
        End If
    End Sub
#End Region
#End Region

#Region "THOAT"
    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Me.Close()
    End Sub
#End Region

    Private Sub FrmSuaChuaE2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Select Case Asc(e.KeyChar)
            Case 13
                Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
            Case Else
        End Select
    End Sub

    'Private Sub FrmSuaChuaE2_OutBout_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
    '    dtpNgayKhaiThacCanSua.Focus()
    'End Sub

    Private Sub dtpNgayKeToan_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpNgayKeToan.Validated
        dtpNgayKeToanSua.DateTime = dtpNgayKeToan.DateTime
        dtpNgayKeToanSua.Value = dtpNgayKeToan.Value
        dtpNgayKeToanSua.Text = dtpNgayKeToan.Text
    End Sub

    Private Sub txtGioKhaiThacCanSua_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGioKhaiThacCanSua.Validated
        txtGioKhaiThacSua.Value = txtGioKhaiThacCanSua.Value
        txtGioKhaiThacSua.Text = txtGioKhaiThacCanSua.Text
    End Sub

    Private Sub cbPhanLoaiSua_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbPhanLoaiSua.Validated
        Dim Id_Duong_Thu As String = myDuong_Thu_Di.Select_Id_Duong_Thu_Di(GBuu_Cuc_Khai_Thac, Convert.ToInt32(cbDuongThuSua.Text))
        Dim Ngay_Khai_Thac As Integer = Ham_Dung_Chung.ConvertDateToInt(dtpNgayKhaiThacSua.Value)
        Dim Id_Phan_Loai As Integer = myDuong_Thu_Di.Lay(Id_Duong_Thu).Id_Phan_Loai
        If (cbDuongThuSua.Text = "") Then
            CMessageBox.Show("Bạn chưa chọn thông tin về đường thư")
            cbPhanLoaiSua.Text = ""
            cbDuongThuSua.Focus()
            Exit Sub
        End If
        If (cbPhanLoaiSua.Text = "") Then
            CMessageBox.Show("Bạn phải chọn thông tin về loại chuyến thư")
            cbPhanLoaiSua.Focus()
            Exit Sub
        End If
        Dim myStart_Date As Integer
        Dim myEnd_Date As Integer
        'If Id_Phan_Loai = 0 Then  'Đường Thư Bưu Tá: Chuyến Thư tăng theo Ngày
        '    myStart_Date = (Ngay_Khai_Thac \ 100) * 100
        '    myEnd_Date = (Ngay_Khai_Thac \ 100) * 100 + 99
        'ElseIf Id_Phan_Loai = 1 Then  'Đường Thư Nội Tỉnh: Chuyến Thư tăng theo Tháng
        '    myStart_Date = (Ngay_Khai_Thac \ 100) * 100
        '    myEnd_Date = (Ngay_Khai_Thac \ 100) * 100 + 99
        'Else : Id_Phan_Loai = 2 Or Id_Phan_Loai = 3 Or Id_Phan_Loai = 4 'Đường Thư Liên Tỉnh,Liền kề, Quốc tê: Chuyến Thư tăng theo Năm
        '    myStart_Date = (Ngay_Khai_Thac \ 10000) * 10000
        '    myEnd_Date = (Ngay_Khai_Thac \ 10000) * 10000 + 9999
        'End If
        myStart_Date = (Ngay_Khai_Thac \ 10000) * 10000
        myEnd_Date = (Ngay_Khai_Thac \ 10000) * 10000 + 9999
        Dim Phan_Loai_Chuyen_Thu As String = cbPhanLoaiSua.Text
        '''   cbChuyenThuSua bind
        cbChuyenThuSua.DataSource = myChuyen_Thu_Di.Danh_Sach_Chuyen_Thu_DiQT(Id_Duong_Thu, myStart_Date, myEnd_Date, Phan_Loai_Chuyen_Thu).Tables(0)
        cbChuyenThuSua.DataBind()
    End Sub

    
    Private Sub cbCaKeToanCanSua_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbCaKeToanCanSua.Validated
        cbCaKeToanSua.Value = cbCaKeToanCanSua.Value
        cbCaKeToanSua.Text = cbCaKeToanCanSua.Text
    End Sub
End Class

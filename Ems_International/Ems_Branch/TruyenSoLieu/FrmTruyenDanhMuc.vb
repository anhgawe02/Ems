Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Ems_International_Logic.EMS
Imports Ems_Utility.Ems_Utility
Public Class FrmTruyenDanhMuc
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
    Friend WithEvents btnTruyen As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkAll As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents dgDuongThu As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ddPhanLoai As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents cbDichVu As Infragistics.Win.UltraWinGrid.UltraCombo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmTruyenDanhMuc))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Duong_Thu", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Duong_Thu")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Phan_Loai")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ip_Truyen")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chon")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Phan_Loai", -1)
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Phan_Loai")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Phan_Loai")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Dich_Vu", -1)
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Dich_Vu_Truyen")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Dich_Vu")
        Me.btnThoat = New Infragistics.Win.Misc.UltraButton
        Me.btnTruyen = New Infragistics.Win.Misc.UltraButton
        Me.dgDuongThu = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.Label2 = New System.Windows.Forms.Label
        Me.chkAll = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.ddPhanLoai = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.cbDichVu = New Infragistics.Win.UltraWinGrid.UltraCombo
        CType(Me.dgDuongThu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddPhanLoai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDichVu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnThoat
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.btnThoat.Appearance = Appearance1
        Me.btnThoat.Location = New System.Drawing.Point(244, 376)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(105, 37)
        Me.btnThoat.TabIndex = 109
        Me.btnThoat.Text = "Thoát"
        '
        'btnTruyen
        '
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.btnTruyen.Appearance = Appearance2
        Me.btnTruyen.Location = New System.Drawing.Point(359, 376)
        Me.btnTruyen.Name = "btnTruyen"
        Me.btnTruyen.Size = New System.Drawing.Size(125, 37)
        Me.btnTruyen.TabIndex = 108
        Me.btnTruyen.Text = "Truyền số liệu"
        '
        'dgDuongThu
        '
        Me.dgDuongThu.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgDuongThu.DisplayLayout.AddNewBox.Prompt = " "
        Appearance3.BackColor = System.Drawing.Color.White
        Appearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgDuongThu.DisplayLayout.Appearance = Appearance3
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.Caption = "Tên đường thư"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn2.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(211, 0)
        UltraGridColumn2.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn2.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.Caption = "Mã bưu cục"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn4.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn4.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn4.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn5.Header.Caption = "Loại đường thư"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn5.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn5.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn5.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn6.Header.Caption = "IP truyền"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn6.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn6.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn6.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn7.Header.Caption = "Chọn"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn7.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn7.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(44, 0)
        UltraGridColumn7.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn7.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7})
        UltraGridBand1.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand1.UseRowLayout = True
        Me.dgDuongThu.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.dgDuongThu.DisplayLayout.InterBandSpacing = 10
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Me.dgDuongThu.DisplayLayout.Override.CardAreaAppearance = Appearance4
        Me.dgDuongThu.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance5.ForeColor = System.Drawing.Color.Black
        Appearance5.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance5.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgDuongThu.DisplayLayout.Override.HeaderAppearance = Appearance5
        Me.dgDuongThu.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance6.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDuongThu.DisplayLayout.Override.RowAppearance = Appearance6
        Appearance7.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance7.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgDuongThu.DisplayLayout.Override.RowSelectorAppearance = Appearance7
        Me.dgDuongThu.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgDuongThu.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance8.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance8.ForeColor = System.Drawing.Color.Black
        Me.dgDuongThu.DisplayLayout.Override.SelectedRowAppearance = Appearance8
        Me.dgDuongThu.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDuongThu.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgDuongThu.Location = New System.Drawing.Point(10, 62)
        Me.dgDuongThu.Name = "dgDuongThu"
        Me.dgDuongThu.Size = New System.Drawing.Size(710, 259)
        Me.dgDuongThu.TabIndex = 106
        Me.dgDuongThu.Text = "Danh sách các bưu cục cần truyền"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(160, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 22)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Chọn danh mục"
        '
        'chkAll
        '
        Me.chkAll.Location = New System.Drawing.Point(24, 332)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(134, 23)
        Me.chkAll.TabIndex = 110
        Me.chkAll.Text = "Chọn tất"
        '
        'ddPhanLoai
        '
        Me.ddPhanLoai.Cursor = System.Windows.Forms.Cursors.Default
        Appearance9.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddPhanLoai.DisplayLayout.Appearance = Appearance9
        UltraGridColumn8.Header.Caption = "Phân loại"
        UltraGridColumn8.Header.VisiblePosition = 0
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.Caption = "Loại đường thư"
        UltraGridColumn9.Header.VisiblePosition = 1
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn8, UltraGridColumn9})
        UltraGridBand2.UseRowLayout = True
        Me.ddPhanLoai.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Appearance10.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance10.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance10.ForeColor = System.Drawing.Color.Black
        Appearance10.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddPhanLoai.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.ddPhanLoai.DisplayMember = "Ten_Phan_Loai"
        Me.ddPhanLoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddPhanLoai.Location = New System.Drawing.Point(149, 136)
        Me.ddPhanLoai.Name = "ddPhanLoai"
        Me.ddPhanLoai.Size = New System.Drawing.Size(432, 148)
        Me.ddPhanLoai.TabIndex = 111
        Me.ddPhanLoai.ValueMember = "Id_Phan_Loai"
        Me.ddPhanLoai.Visible = False
        '
        'cbDichVu
        '
        Me.cbDichVu.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn10.Header.Caption = "Dịch vụ"
        UltraGridColumn10.Header.VisiblePosition = 0
        UltraGridColumn11.Header.Caption = "Tên dịch vụ"
        UltraGridColumn11.Header.VisiblePosition = 1
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn10, UltraGridColumn11})
        Me.cbDichVu.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.cbDichVu.DisplayMember = "Ten_Dich_Vu"
        Me.cbDichVu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDichVu.Location = New System.Drawing.Point(280, 16)
        Me.cbDichVu.Name = "cbDichVu"
        Me.cbDichVu.Size = New System.Drawing.Size(288, 25)
        Me.cbDichVu.TabIndex = 112
        Me.cbDichVu.ValueMember = "Id_Dich_Vu_Truyen"
        '
        'FrmTruyenDanhMuc
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(729, 421)
        Me.Controls.Add(Me.cbDichVu)
        Me.Controls.Add(Me.ddPhanLoai)
        Me.Controls.Add(Me.chkAll)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnTruyen)
        Me.Controls.Add(Me.dgDuongThu)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTruyenDanhMuc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Truyền danh mục"
        CType(Me.dgDuongThu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddPhanLoai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDichVu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "-----------------------Tao_Bang_Id_Phan_Loai-----------------------"
    Private Sub Tao_Bang_Id_Phan_Loai()

        'Them moi mot bang
        Dim dataTable As New DataTable("Phan_Loai")

        'Tao ra cac cot cua bang nay
        Dim colWork As DataColumn = New DataColumn("Id_Phan_Loai", GetType(Int32))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Ten_Phan_Loai", GetType(String))
        dataTable.Columns.Add(colWork)


        'Them du lieu vao
        Dim row As DataRow = dataTable.NewRow()
        row("Id_Phan_Loai") = 0
        row("Ten_Phan_Loai") = "Bưu tá"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Id_Phan_Loai") = 1
        row("Ten_Phan_Loai") = "Nội tỉnh"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Id_Phan_Loai") = 3
        row("Ten_Phan_Loai") = "Liên tỉnh"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Id_Phan_Loai") = 2
        row("Ten_Phan_Loai") = "Liền kề"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Id_Phan_Loai") = 4
        row("Ten_Phan_Loai") = "Quốc tế"
        dataTable.Rows.Add(row)

        ddPhanLoai.DataSource = dataTable
        ddPhanLoai.DataBind()


    End Sub
#End Region
    Public Ten_Bang As String = "" 'Tên bảng cần truyền
    Dim myDuongThu As New Ems_International_Logic.EMS.Duong_Thu_Di(GConnectionString)
    Dim myCuoc_Dv_COD As New Cuoc_Dv_COD(GConnectionString)
    Dim myCuoc_Dv_Cong_Them As New Cuoc_Dv_Cong_Them(GConnectionString)
    'Dim myCuoc_Dv_Gia_Tang As New Cuoc_Dv_Gia_Tang(GConnectionString)
    Dim myCuoc_Dv_Khai_Gia As New Cuoc_Dv_Khai_Gia(GConnectionString)
    Dim myCuoc_Phat As New Cuoc_Phat(GConnectionString)
    Dim myCuoc_PPXD_Vat As New Cuoc_PPXD_Vat(GConnectionString)
    Dim myCuoc_QT As New Cuoc_QT(GConnectionString)
    Dim myCuoc_TN As New Cuoc_TN(GConnectionString)
    Dim myCuoc_TN_TT As New Cuoc_TN_TT(GConnectionString)
    Dim myCuoc_Vung_Xa As New Cuoc_Vung_Xa(GConnectionString)
    Dim myDanh_Muc_BC As New Ems_International_Logic.EMS.Danh_Muc_BC(GConnectionString)
    Dim myDich_Vu As New Dich_Vu(GConnectionString)
    Dim myGiam_Gia As New Giam_Gia(GConnectionString)
    Dim myKhu_Vuc_QT As New Khu_Vuc_QT(GConnectionString)
    Dim myKhu_Vuc_TN As New Khu_Vuc_TN(GConnectionString)
    Dim myKhuyen_Mai As New Khuyen_Mai(GConnectionString)
    Dim myLy_Do As New Ly_Do(GConnectionString)
    Dim myMa_Don_Vi As New Ma_Don_Vi(GConnectionString)
    Dim myMa_Nuoc As New Ma_Nuoc(GConnectionString)
    Dim myMa_Tinh As New Ma_Tinh(GConnectionString)
    Dim myXu_Ly As New Xu_Ly(GConnectionString)
    Dim myDichVu As New Dich_Vu_Truyen(GConnectionString)
    Dim myUtility As New Ems_MSMQ(GConnectionString)
    Dim myDataSet As New DataSet
    Private Sub FrmTruyenDanhMuc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tao_Bang_Id_Phan_Loai()
        myDichVu = New Dich_Vu_Truyen(GConnectionString)
        cbDichVu.DataSource = myDichVu.Danh_Sach.Tables(0)
        cbDichVu.DataBind()
        dgDuongThu.DataSource = myDuongThu.Danh_Sach_Noi_Tinh_Chon()
        dgDuongThu.DataBind()
    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Close()
    End Sub


    Private Sub dgDuongThu_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgDuongThu.InitializeLayout
        dgDuongThu.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgDuongThu.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
        With dgDuongThu.DisplayLayout
            .Bands(0).Columns("Id_Phan_Loai").Style = ColumnStyle.DropDownValidate
            .Bands(0).Columns("Id_Phan_Loai").ValueList = ddPhanLoai
        End With
    End Sub

    Private Sub btnTruyen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTruyen.Click
        Dim i As Integer
        For i = 0 To dgDuongThu.Rows.Count - 1
            If dgDuongThu.Rows(i).Cells("Chon").Value = True Then
                Select Case cbDichVu.Value
                    Case "Ems_Cuoc_QT"
                        myDataSet = myCuoc_QT.Danh_Sach
                        myDataSet.Tables(0).TableName = "EMS_CUOC_QT"
                        myUtility.Dang_Ky_Truyen("EMS_CUOC_QT", "BRANCH", "PO", GBuu_Cuc_Khai_Thac, dgDuongThu.Rows(i).Cells("Ma_Bc").Value, Ham_Dung_Chung.ConvertDateToInt(Now), Ham_Dung_Chung.ConvertTimeToInt(Now), "", myDataSet)
                        myUtility.Truyen()
                End Select
            End If
        Next
    End Sub

    Private Sub chkAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAll.CheckedChanged
        Dim i As Integer
        For i = 0 To dgDuongThu.Rows.Count - 1
            dgDuongThu.Rows(i).Cells("Chon").Value = chkAll.Checked
        Next
    End Sub
End Class

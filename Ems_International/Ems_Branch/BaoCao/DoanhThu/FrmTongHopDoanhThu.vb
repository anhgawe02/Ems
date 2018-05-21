Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports Ems_International_Logic.EMS
Public Class FrmTongHopDoanhThu
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CbTuy_Chon_Bao_Cao As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CbDen_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CbTu_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents BtnExit As Infragistics.Win.Misc.UltraButton
    Friend WithEvents BtnPrint As Infragistics.Win.Misc.UltraButton
    Friend WithEvents BtnPreview As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Tuy_Chon_Bao_Cao", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bao_Cao")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Bao_Cao")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmTongHopDoanhThu))
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.LbThong_Tin = New Infragistics.Win.Misc.UltraLabel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CbTuy_Chon_Bao_Cao = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.CbDen_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.CbTu_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.BtnExit = New Infragistics.Win.Misc.UltraButton
        Me.BtnPrint = New Infragistics.Win.Misc.UltraButton
        Me.BtnPreview = New Infragistics.Win.Misc.UltraButton
        Me.Panel1.SuspendLayout()
        CType(Me.CbTuy_Chon_Bao_Cao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbDen_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbTu_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
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
        Me.LbThong_Tin.Size = New System.Drawing.Size(488, 48)
        Me.LbThong_Tin.TabIndex = 89
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CbTuy_Chon_Bao_Cao)
        Me.Panel1.Controls.Add(Me.UltraLabel3)
        Me.Panel1.Controls.Add(Me.CbDen_Ngay)
        Me.Panel1.Controls.Add(Me.UltraLabel4)
        Me.Panel1.Controls.Add(Me.CbTu_Ngay)
        Me.Panel1.Location = New System.Drawing.Point(2, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(328, 184)
        Me.Panel1.TabIndex = 94
        '
        'CbTuy_Chon_Bao_Cao
        '
        Me.CbTuy_Chon_Bao_Cao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance2.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn1.Header.Appearance = Appearance2
        UltraGridColumn1.Header.Caption = "Mã báo cáo"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.Width = 78
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn2.Header.Appearance = Appearance3
        UltraGridColumn2.Header.Caption = "Tên báo cáo"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 313
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2})
        UltraGridBand1.SummaryFooterCaption = "Grand Summaries"
        Me.CbTuy_Chon_Bao_Cao.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance4.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance4.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance4.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance4.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.CbTuy_Chon_Bao_Cao.DisplayLayout.Override.HeaderAppearance = Appearance4
        Me.CbTuy_Chon_Bao_Cao.DisplayMember = "Ten_Bao_Cao"
        Me.CbTuy_Chon_Bao_Cao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CbTuy_Chon_Bao_Cao.Location = New System.Drawing.Point(8, 80)
        Me.CbTuy_Chon_Bao_Cao.Name = "CbTuy_Chon_Bao_Cao"
        Me.CbTuy_Chon_Bao_Cao.Size = New System.Drawing.Size(312, 23)
        Me.CbTuy_Chon_Bao_Cao.TabIndex = 98
        Me.CbTuy_Chon_Bao_Cao.Text = "Hãy lựa chọn loại báo cáo cần in"
        Me.CbTuy_Chon_Bao_Cao.ValueMember = "Ma_Bao_Cao"
        '
        'UltraLabel3
        '
        Me.UltraLabel3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UltraLabel3.Location = New System.Drawing.Point(168, 24)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(56, 16)
        Me.UltraLabel3.TabIndex = 97
        Me.UltraLabel3.Text = "Đến ngày"
        '
        'CbDen_Ngay
        '
        Me.CbDen_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.CbDen_Ngay.Location = New System.Drawing.Point(232, 24)
        Me.CbDen_Ngay.Name = "CbDen_Ngay"
        Me.CbDen_Ngay.Size = New System.Drawing.Size(88, 21)
        Me.CbDen_Ngay.TabIndex = 95
        '
        'UltraLabel4
        '
        Me.UltraLabel4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UltraLabel4.Location = New System.Drawing.Point(8, 24)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(48, 16)
        Me.UltraLabel4.TabIndex = 96
        Me.UltraLabel4.Text = "Từ ngày"
        '
        'CbTu_Ngay
        '
        Me.CbTu_Ngay.DateTime = New Date(2008, 7, 3, 0, 0, 0, 0)
        Me.CbTu_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.CbTu_Ngay.Location = New System.Drawing.Point(64, 24)
        Me.CbTu_Ngay.Name = "CbTu_Ngay"
        Me.CbTu_Ngay.Size = New System.Drawing.Size(88, 21)
        Me.CbTu_Ngay.TabIndex = 94
        Me.CbTu_Ngay.Value = New Date(2008, 7, 3, 0, 0, 0, 0)
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BtnExit)
        Me.Panel2.Controls.Add(Me.BtnPrint)
        Me.Panel2.Controls.Add(Me.BtnPreview)
        Me.Panel2.Location = New System.Drawing.Point(328, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(152, 184)
        Me.Panel2.TabIndex = 95
        '
        'BtnExit
        '
        Appearance5.FontData.BoldAsString = "True"
        Appearance5.Image = CType(resources.GetObject("Appearance5.Image"), Object)
        Me.BtnExit.Appearance = Appearance5
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.BtnExit.ImageSize = New System.Drawing.Size(40, 25)
        Me.BtnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnExit.Location = New System.Drawing.Point(8, 120)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(136, 40)
        Me.BtnExit.TabIndex = 95
        Me.BtnExit.Text = "Exit"
        '
        'BtnPrint
        '
        Appearance6.FontData.BoldAsString = "True"
        Appearance6.Image = CType(resources.GetObject("Appearance6.Image"), Object)
        Appearance6.TextHAlign = Infragistics.Win.HAlign.Center
        Me.BtnPrint.Appearance = Appearance6
        Me.BtnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.BtnPrint.ImageSize = New System.Drawing.Size(40, 25)
        Me.BtnPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnPrint.Location = New System.Drawing.Point(8, 64)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(136, 40)
        Me.BtnPrint.TabIndex = 94
        Me.BtnPrint.Text = "Printer"
        '
        'BtnPreview
        '
        Appearance7.FontData.BoldAsString = "True"
        Appearance7.Image = CType(resources.GetObject("Appearance7.Image"), Object)
        Me.BtnPreview.Appearance = Appearance7
        Me.BtnPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.BtnPreview.ImageSize = New System.Drawing.Size(40, 25)
        Me.BtnPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnPreview.Location = New System.Drawing.Point(8, 8)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(136, 40)
        Me.BtnPreview.TabIndex = 93
        Me.BtnPreview.Text = "Preview"
        '
        'FrmTongHopDoanhThu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(482, 235)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LbThong_Tin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTongHopDoanhThu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tổng Hợp Doanh Thu"
        Me.Panel1.ResumeLayout(False)
        CType(Me.CbTuy_Chon_Bao_Cao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbDen_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbTu_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Khai báo các biến cục bộ trong Form"
    Dim Tu_Ngay_KT As Integer
    Dim Den_Ngay_KT As Integer
    Dim myColumn As Infragistics.Win.UltraWinGrid.UltraGridColumn = Nothing
    Private myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Dim myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Dim myham_dung_chung As New Ham_Dung_Chung
    Dim myE1_Di As New E1_Di(GConnectionString)
    Dim myDoanh_Thu_HHDL_Chi_Tiet As New Doanh_Thu_HHDL_Chi_Tiet
    Dim myDoanh_Thu_PhatSinh_Chi_Tiet As New Doanh_Thu_Phat_Sinh_Chi_Tiet
    Dim myHHDL_CP_Tu_Ngay_Den_Ngay As New HHDL_CP_Tu_Ngay_Den_Ngay
    Dim _pThamSo As New ParameterDiscreteValue
    Dim Rpt_Thoi_Gian As String ' hien thi thoi gian,ca, tu ngay den ngay trong rpt
    Dim Rpt_Menu_Tieu_De As String ' hien thi tieu de bao cao
#End Region

#Region "Tạo bảng Tuỳ chọn báo cáo"
    Private Sub Tuy_Chon_Bao_Cao()
        Try
            'Them moi mot bang
            Dim dataTable As New dataTable("Tuy_Chon_Bao_Cao")

            'Tao ra cac cot cua bang nay
            Dim colWork As DataColumn = New DataColumn("Ma_Bao_Cao", GetType(Integer))
            dataTable.Columns.Add(colWork)
            colWork = New DataColumn("Ten_Bao_Cao", GetType(String))
            dataTable.Columns.Add(colWork)

            'Them du lieu vao
            Dim row As DataRow = dataTable.NewRow()
            row("Ma_Bao_Cao") = 0
            row("Ten_Bao_Cao") = "Tổng hợp Doanh thu Hoa Hồng Đại Lý"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Ma_Bao_Cao") = 1
            row("Ten_Bao_Cao") = "Tổng hợp Doanh thu Phát sinh"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Ma_Bao_Cao") = 2
            row("Ten_Bao_Cao") = "Tổng hợp Hoa hống đại lý"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Ma_Bao_Cao") = 3
            row("Ten_Bao_Cao") = "Tổng hợp Doanh Thu Liên Tỉnh Liền Kề"
            dataTable.Rows.Add(row)

            CbTuy_Chon_Bao_Cao.DataSource = dataTable
            CbTuy_Chon_Bao_Cao.DataBind()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

    Private Sub FrmTongHopDoanhThu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tuy_Chon_Bao_Cao()
        Rpt_Menu_Tieu_De = "BẢNG XÁC NHẬN SẢN LƯỢNG, DOANH THU, HOA HỒNG ĐẠI LÝ DỊCH VỤ CHUYỂN PHÁT NHANH"
        BtnPreview.Enabled = False
        BtnPrint.Enabled = False
        CbTu_Ngay.Value = myham_dung_chung.dBeginMonth(Date.Now)
    End Sub
    Private Sub Doanh_Thu_HH_DL_Tu_Ngay_Den_Ngay()
        Dim mydata As DataTable
        Dim Tu_Ngay As Integer
        Dim Den_ngay As Integer
        Dim RptDoanhThuHHDLTuNgayDenNgay As New RptDoanh_Thu_HH_DL_Tu_Ngay_Den_Ngay
        Rpt_Thoi_Gian = "Từ ngày " & CbTu_Ngay.Text & " đến ngày " & CbDen_Ngay.Text
        Dim pvCollection As New ParameterValues
        Dim FrmView As New FrmViewReports
        Try

            Tu_Ngay = myham_dung_chung.ConvertDateToInt(CbTu_Ngay.Value)
            Den_ngay = myham_dung_chung.ConvertDateToInt(CbDen_Ngay.Value)
            myDoanh_Thu_HHDL_Chi_Tiet = myE1_Di.Lay_Doanh_Thu_HHDL_Tu_Ngay_Den_Ngay(GBuu_Cuc_Khai_Thac, Tu_Ngay, Den_ngay)

            _pThamSo.Value = GLeftMenu.ToUpper
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Menu_Trai").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Menu_Tieu_De").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            _pThamSo.Value = Rpt_Thoi_Gian
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Menu_Thoi_Gian").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            _pThamSo.Value = GTen_Dang_Nhap
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Menu_Ten_Dang_Nhap").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = GrptNgay_Thang_Nam
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Menu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = GTen_Buu_Cuc_Khai_Thac
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Menu_Ten_BC_Khai_Thac").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.HH_PH_NT
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("HH_PH_NT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.HH_PH_LT
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("HH_PH_LT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.HH_PH_QT
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("HH_PH_QT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_NT
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_NT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_NT
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_NT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.Doanh_Thu_NT
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Doanh_Thu_NT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_NT_TT
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_NT_TT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_NT_TT
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_NT_TT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.Doanh_Thu_NT_TT
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Doanh_Thu_NT_TT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_LTLK
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_LTLK").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_LTLK
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_LTLK").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.Doanh_Thu_LTLK
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Doanh_Thu_LTLK").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_LT
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_LT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_LT
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_LT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.Doanh_Thu_LT
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Doanh_Thu_LT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_TTLTLK
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_TTLTLK").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_TTLTLK
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_TTLTLK").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.Doanh_Thu_TTLTLK
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Doanh_Thu_TTLTLK").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_TTLT
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_TTLT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_TTLT
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_TTLT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.Doanh_Thu_TTLT
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Doanh_Thu_TTLT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_QT
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_QT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_QT
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_QT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.Doanh_Thu_QT
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Doanh_Thu_QT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_CH
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_CH").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_CH
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_CH").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.Doanh_Thu_CH
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Doanh_Thu_CH").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_LTLK_TN_Duoi_2Kg
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_LTLK_TN_Duoi_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_LTLK_TN_Duoi_2Kg
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_LTLK_TN_Duoi_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.HH_Phat_Tra_LTLK_TN_Duoi_2Kg
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("HH_Phat_Tra_LTLK_TN_Duoi_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_LTLK_TN_Tren_2Kg
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_LTLK_TN_Tren_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_LTLK_TN_Tren_2Kg
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_LTLK_TN_Tren_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_LTLK_TN_Tren_2Kg_QD
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_LTLK_TN_Tren_2Kg_QD").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_TTLT_TN_Tren_2Kg_QD
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_TTLT_TN_Tren_2Kg_QD").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.HH_Phat_Tra_LTLK_TN_Tren_2Kg
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("HH_Phat_Tra_LTLK_TN_Tren_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()


            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_LT_TN_Duoi_2Kg
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_LT_TN_Duoi_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_LT_TN_Duoi_2Kg
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_LT_TN_Duoi_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.HH_Phat_Tra_LT_TN_Duoi_2Kg
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("HH_Phat_Tra_LT_TN_Duoi_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_LT_TN_Tren_2Kg
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_LT_TN_Tren_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_LT_TN_Tren_2Kg
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_LT_TN_Tren_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_LT_TN_Tren_2Kg_QD
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_LT_TN_Tren_2Kg_QD").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.HH_Phat_Tra_LT_TN_Tren_2Kg
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("HH_Phat_Tra_LT_TN_Tren_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()


            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_TTLTLK_TN_Duoi_2Kg
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_TTLTLK_TN_Duoi_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_TTLTLK_TN_Duoi_2Kg
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_TTLTLK_TN_Duoi_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.HH_Phat_Tra_TTLTLK_TN_Duoi_2Kg
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("HH_Phat_Tra_TTLTLK_TN_Duoi_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_TTLTLK_TN_Tren_2Kg
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_TTLTLK_TN_Tren_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_TTLTLK_TN_Tren_2Kg
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_TTLTLK_TN_Tren_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_TTLTLK_TN_Tren_2Kg_QD
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_TTLTLK_TN_Tren_2Kg_QD").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.HH_Phat_Tra_TTLTLK_TN_Tren_2Kg
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("HH_Phat_Tra_TTLTLK_TN_Tren_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_TTLT_TN_Duoi_2Kg
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_TTLT_TN_Duoi_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_TTLT_TN_Duoi_2Kg
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_TTLT_TN_Duoi_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.HH_Phat_Tra_TTLT_TN_Duoi_2Kg
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("HH_Phat_Tra_TTLT_TN_Duoi_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_TTLT_TN_Tren_2Kg
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_TTLT_TN_Tren_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_TTLT_TN_Tren_2Kg
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_TTLT_TN_Tren_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_TTLT_TN_Tren_2Kg_QD
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_TTLT_TN_Tren_2Kg_QD").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.HH_Phat_Tra_TTLT_TN_Tren_2Kg
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("HH_Phat_Tra_TTLT_TN_Tren_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()


            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_QT_Duoi_5Kg
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_QT_Duoi_5Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_QT_Duoi_5Kg
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_QT_Duoi_5Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.HH_Phat_Tra_QT_Duoi_5Kg
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("HH_Phat_Tra_QT_Duoi_5Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_QT_Tren_5Kg
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_QT_Tren_5Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_QT_Tren_5Kg
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_QT_Tren_5Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_QT_Tren_5Kg_QD
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_QT_Tren_5Kg_QD").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_HHDL_Chi_Tiet.HH_Phat_Tra_QT_Tren_5Kg
            pvCollection.Add(_pThamSo)
            RptDoanhThuHHDLTuNgayDenNgay.DataDefinition.ParameterFields("HH_Phat_Tra_QT_Tren_5Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            RptDoanhThuHHDLTuNgayDenNgay.SetDataSource(myDoanh_Thu_HHDL_Chi_Tiet)
            FrmView.CrystalReportViewer1.ReportSource = RptDoanhThuHHDLTuNgayDenNgay
            Cursor.Current = Cursors.Default
            FrmView.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Doanh_Thu_Phat_Sinh_Tu_Ngay_Den_Ngay()
        Dim mydata As DataTable
        Dim Tu_Ngay As Integer
        Dim Den_ngay As Integer
        Dim RptDoanhThuPhatSinhTuNgayDenNgay As New RptDoanh_Thu_Phat_Sinh_Tu_Ngay_Den_Ngay
        Rpt_Thoi_Gian = "Từ ngày " & CbTu_Ngay.Text & " đến ngày " & CbDen_Ngay.Text
        Dim pvCollection As New ParameterValues
        Dim FrmView As New FrmViewReports
        Try

            Tu_Ngay = myham_dung_chung.ConvertDateToInt(CbTu_Ngay.Value)
            Den_ngay = myham_dung_chung.ConvertDateToInt(CbDen_Ngay.Value)
            myDoanh_Thu_PhatSinh_Chi_Tiet = myE1_Di.Lay_Doanh_Thu_Phat_Sinh_Tu_Ngay_Den_Ngay(GBuu_Cuc_Khai_Thac, Tu_Ngay, Den_ngay)

            _pThamSo.Value = GLeftMenu.ToUpper
            pvCollection.Add(_pThamSo)
            RptDoanhThuPhatSinhTuNgayDenNgay.DataDefinition.ParameterFields("Menu_Trai").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper
            pvCollection.Add(_pThamSo)
            RptDoanhThuPhatSinhTuNgayDenNgay.DataDefinition.ParameterFields("Menu_Tieu_De").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            _pThamSo.Value = Rpt_Thoi_Gian
            pvCollection.Add(_pThamSo)
            RptDoanhThuPhatSinhTuNgayDenNgay.DataDefinition.ParameterFields("Menu_Thoi_Gian").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            _pThamSo.Value = GTen_Dang_Nhap
            pvCollection.Add(_pThamSo)
            RptDoanhThuPhatSinhTuNgayDenNgay.DataDefinition.ParameterFields("Menu_Ten_Dang_Nhap").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = GrptNgay_Thang_Nam
            pvCollection.Add(_pThamSo)
            RptDoanhThuPhatSinhTuNgayDenNgay.DataDefinition.ParameterFields("Menu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = GTen_Buu_Cuc_Khai_Thac
            pvCollection.Add(_pThamSo)
            RptDoanhThuPhatSinhTuNgayDenNgay.DataDefinition.ParameterFields("Menu_Ten_BC_Khai_Thac").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_PhatSinh_Chi_Tiet.HH_PH_NT
            pvCollection.Add(_pThamSo)
            RptDoanhThuPhatSinhTuNgayDenNgay.DataDefinition.ParameterFields("HH_PH_NT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_PhatSinh_Chi_Tiet.HH_PH_LT
            pvCollection.Add(_pThamSo)
            RptDoanhThuPhatSinhTuNgayDenNgay.DataDefinition.ParameterFields("HH_PH_LT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_PhatSinh_Chi_Tiet.HH_PH_QT
            pvCollection.Add(_pThamSo)
            RptDoanhThuPhatSinhTuNgayDenNgay.DataDefinition.ParameterFields("HH_PH_QT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_PhatSinh_Chi_Tiet.San_Luong_NT
            pvCollection.Add(_pThamSo)
            RptDoanhThuPhatSinhTuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_NT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_PhatSinh_Chi_Tiet.Trong_Luong_NT
            pvCollection.Add(_pThamSo)
            RptDoanhThuPhatSinhTuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_NT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_PhatSinh_Chi_Tiet.Doanh_Thu_NT
            pvCollection.Add(_pThamSo)
            RptDoanhThuPhatSinhTuNgayDenNgay.DataDefinition.ParameterFields("Doanh_Thu_NT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_PhatSinh_Chi_Tiet.San_Luong_NT_TT
            pvCollection.Add(_pThamSo)
            RptDoanhThuPhatSinhTuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_NT_TT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_PhatSinh_Chi_Tiet.Trong_Luong_NT_TT
            pvCollection.Add(_pThamSo)
            RptDoanhThuPhatSinhTuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_NT_TT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_PhatSinh_Chi_Tiet.Doanh_Thu_NT_TT
            pvCollection.Add(_pThamSo)
            RptDoanhThuPhatSinhTuNgayDenNgay.DataDefinition.ParameterFields("Doanh_Thu_NT_TT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_PhatSinh_Chi_Tiet.San_Luong_LTLK
            pvCollection.Add(_pThamSo)
            RptDoanhThuPhatSinhTuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_LTLK").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_PhatSinh_Chi_Tiet.Trong_Luong_LTLK
            pvCollection.Add(_pThamSo)
            RptDoanhThuPhatSinhTuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_LTLK").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_PhatSinh_Chi_Tiet.Doanh_Thu_LTLK
            pvCollection.Add(_pThamSo)
            RptDoanhThuPhatSinhTuNgayDenNgay.DataDefinition.ParameterFields("Doanh_Thu_LTLK").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_PhatSinh_Chi_Tiet.San_Luong_LT
            pvCollection.Add(_pThamSo)
            RptDoanhThuPhatSinhTuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_LT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_PhatSinh_Chi_Tiet.Trong_Luong_LT
            pvCollection.Add(_pThamSo)
            RptDoanhThuPhatSinhTuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_LT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_PhatSinh_Chi_Tiet.Doanh_Thu_LT
            pvCollection.Add(_pThamSo)
            RptDoanhThuPhatSinhTuNgayDenNgay.DataDefinition.ParameterFields("Doanh_Thu_LT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_PhatSinh_Chi_Tiet.San_Luong_TTLTLK
            pvCollection.Add(_pThamSo)
            RptDoanhThuPhatSinhTuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_TTLTLK").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_PhatSinh_Chi_Tiet.Trong_Luong_TTLTLK
            pvCollection.Add(_pThamSo)
            RptDoanhThuPhatSinhTuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_TTLTLK").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_PhatSinh_Chi_Tiet.Doanh_Thu_TTLTLK
            pvCollection.Add(_pThamSo)
            RptDoanhThuPhatSinhTuNgayDenNgay.DataDefinition.ParameterFields("Doanh_Thu_TTLTLK").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_PhatSinh_Chi_Tiet.San_Luong_TTLT
            pvCollection.Add(_pThamSo)
            RptDoanhThuPhatSinhTuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_TTLT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_PhatSinh_Chi_Tiet.Trong_Luong_TTLT
            pvCollection.Add(_pThamSo)
            RptDoanhThuPhatSinhTuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_TTLT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_PhatSinh_Chi_Tiet.Doanh_Thu_TTLT
            pvCollection.Add(_pThamSo)
            RptDoanhThuPhatSinhTuNgayDenNgay.DataDefinition.ParameterFields("Doanh_Thu_TTLT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_PhatSinh_Chi_Tiet.San_Luong_QT
            pvCollection.Add(_pThamSo)
            RptDoanhThuPhatSinhTuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_QT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_PhatSinh_Chi_Tiet.Trong_Luong_QT
            pvCollection.Add(_pThamSo)
            RptDoanhThuPhatSinhTuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_QT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_PhatSinh_Chi_Tiet.Doanh_Thu_QT
            pvCollection.Add(_pThamSo)
            RptDoanhThuPhatSinhTuNgayDenNgay.DataDefinition.ParameterFields("Doanh_Thu_QT").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_PhatSinh_Chi_Tiet.San_Luong_CH
            pvCollection.Add(_pThamSo)
            RptDoanhThuPhatSinhTuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_CH").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_PhatSinh_Chi_Tiet.Trong_Luong_CH
            pvCollection.Add(_pThamSo)
            RptDoanhThuPhatSinhTuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_CH").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myDoanh_Thu_PhatSinh_Chi_Tiet.Doanh_Thu_CH
            pvCollection.Add(_pThamSo)
            RptDoanhThuPhatSinhTuNgayDenNgay.DataDefinition.ParameterFields("Doanh_Thu_CH").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()


            RptDoanhThuPhatSinhTuNgayDenNgay.SetDataSource(myDoanh_Thu_PhatSinh_Chi_Tiet)
            FrmView.CrystalReportViewer1.ReportSource = RptDoanhThuPhatSinhTuNgayDenNgay
            Cursor.Current = Cursors.Default
            FrmView.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub HH_DL_CP_Tu_Ngay_Den_Ngay()
        Dim mydata As DataTable
        Dim Tu_Ngay As Integer
        Dim Den_ngay As Integer
        Dim RptHHDL_Cong_Phat_TuNgayDenNgay As New RptHH_DL_CP_Tu_Ngay_Den_Ngay
        Rpt_Thoi_Gian = "Từ ngày " & CbTu_Ngay.Text & " đến ngày " & CbDen_Ngay.Text
        Dim pvCollection As New ParameterValues
        Dim FrmView As New FrmViewReports
        Try

            Tu_Ngay = myham_dung_chung.ConvertDateToInt(CbTu_Ngay.Value)
            Den_ngay = myham_dung_chung.ConvertDateToInt(CbDen_Ngay.Value)
            myHHDL_CP_Tu_Ngay_Den_Ngay = myE1_Di.Lay_HHDL_CP_Tu_Ngay_Den_Ngay(GBuu_Cuc_Khai_Thac, Tu_Ngay, Den_ngay)

            _pThamSo.Value = GLeftMenu.ToUpper
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("Menu_Trai").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            _pThamSo.Value = Rpt_Menu_Tieu_De.ToUpper
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("Menu_Tieu_De").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            _pThamSo.Value = Rpt_Thoi_Gian
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("Menu_Thoi_Gian").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            _pThamSo.Value = GTen_Dang_Nhap
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("Menu_Ten_Dang_Nhap").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = GrptNgay_Thang_Nam
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("Menu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = GTen_Buu_Cuc_Khai_Thac
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("Menu_Ten_BC_Khai_Thac").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.San_Luong_LTLK_TN_Duoi_2Kg
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_LTLK_TN_Duoi_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.Trong_Luong_LTLK_TN_Duoi_2Kg
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_LTLK_TN_Duoi_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.HH_Phat_Tra_LTLK_TN_Duoi_2Kg
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("HH_Phat_Tra_LTLK_TN_Duoi_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.San_Luong_LTLK_TN_Tren_2Kg
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_LTLK_TN_Tren_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.Trong_Luong_LTLK_TN_Tren_2Kg
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_LTLK_TN_Tren_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.Trong_Luong_LTLK_TN_Tren_2Kg_QD
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_LTLK_TN_Tren_2Kg_QD").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.Trong_Luong_TTLT_TN_Tren_2Kg_QD
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_TTLT_TN_Tren_2Kg_QD").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.HH_Phat_Tra_LTLK_TN_Tren_2Kg
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("HH_Phat_Tra_LTLK_TN_Tren_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()


            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.San_Luong_LT_TN_Duoi_2Kg
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_LT_TN_Duoi_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.Trong_Luong_LT_TN_Duoi_2Kg
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_LT_TN_Duoi_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.HH_Phat_Tra_LT_TN_Duoi_2Kg
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("HH_Phat_Tra_LT_TN_Duoi_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.San_Luong_LT_TN_Tren_2Kg
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_LT_TN_Tren_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.Trong_Luong_LT_TN_Tren_2Kg
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_LT_TN_Tren_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.Trong_Luong_LT_TN_Tren_2Kg_QD
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_LT_TN_Tren_2Kg_QD").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.HH_Phat_Tra_LT_TN_Tren_2Kg
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("HH_Phat_Tra_LT_TN_Tren_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()


            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.San_Luong_TTLTLK_TN_Duoi_2Kg
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_TTLTLK_TN_Duoi_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.Trong_Luong_TTLTLK_TN_Duoi_2Kg
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_TTLTLK_TN_Duoi_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.HH_Phat_Tra_TTLTLK_TN_Duoi_2Kg
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("HH_Phat_Tra_TTLTLK_TN_Duoi_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.San_Luong_TTLTLK_TN_Tren_2Kg
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_TTLTLK_TN_Tren_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.Trong_Luong_TTLTLK_TN_Tren_2Kg
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_TTLTLK_TN_Tren_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.Trong_Luong_TTLTLK_TN_Tren_2Kg_QD
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_TTLTLK_TN_Tren_2Kg_QD").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.HH_Phat_Tra_TTLTLK_TN_Tren_2Kg
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("HH_Phat_Tra_TTLTLK_TN_Tren_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.San_Luong_TTLT_TN_Duoi_2Kg
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_TTLT_TN_Duoi_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.Trong_Luong_TTLT_TN_Duoi_2Kg
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_TTLT_TN_Duoi_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.HH_Phat_Tra_TTLT_TN_Duoi_2Kg
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("HH_Phat_Tra_TTLT_TN_Duoi_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.San_Luong_TTLT_TN_Tren_2Kg
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_TTLT_TN_Tren_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.Trong_Luong_TTLT_TN_Tren_2Kg
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_TTLT_TN_Tren_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.Trong_Luong_TTLT_TN_Tren_2Kg_QD
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_TTLT_TN_Tren_2Kg_QD").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.HH_Phat_Tra_TTLT_TN_Tren_2Kg
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("HH_Phat_Tra_TTLT_TN_Tren_2Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()


            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.San_Luong_QT_Duoi_5Kg
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_QT_Duoi_5Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.Trong_Luong_QT_Duoi_5Kg
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_QT_Duoi_5Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.HH_Phat_Tra_QT_Duoi_5Kg
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("HH_Phat_Tra_QT_Duoi_5Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.San_Luong_QT_Tren_5Kg
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("San_Luong_QT_Tren_5Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.Trong_Luong_QT_Tren_5Kg
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_QT_Tren_5Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.Trong_Luong_QT_Tren_5Kg_QD
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("Trong_Luong_QT_Tren_5Kg_QD").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = myHHDL_CP_Tu_Ngay_Den_Ngay.HH_Phat_Tra_QT_Tren_5Kg
            pvCollection.Add(_pThamSo)
            RptHHDL_Cong_Phat_TuNgayDenNgay.DataDefinition.ParameterFields("HH_Phat_Tra_QT_Tren_5Kg").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            RptHHDL_Cong_Phat_TuNgayDenNgay.SetDataSource(myHHDL_CP_Tu_Ngay_Den_Ngay)
            FrmView.CrystalReportViewer1.ReportSource = RptHHDL_Cong_Phat_TuNgayDenNgay
            Cursor.Current = Cursors.Default
            FrmView.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Doanh_Thu_Lien_Tinh_Lien_Ke()
        Dim myData As New DataSet
        Dim Tu_Ngay As Integer
        Dim Den_ngay As Integer
        Dim pvCollection As New ParameterValues
        Dim myE1_Di As New E1_Di(GConnectionString)
        Dim myE1_Den As New E1_Den(GConnectionString)
        Dim myReport As New RptEMS_Lien_Tinh_Lien_Ke
        Dim FrmView As New FrmViewReports
        Try
            Tu_Ngay = myham_dung_chung.ConvertDateToInt(CbTu_Ngay.Value)
            Den_ngay = myham_dung_chung.ConvertDateToInt(CbDen_Ngay.Value)

            _pThamSo.Value = "Từ ngày " + Ham_Dung_Chung.ConvertIntToVNDateType(Tu_Ngay) + " đến ngày " + Ham_Dung_Chung.ConvertIntToVNDateType(Den_ngay)
            pvCollection.Add(_pThamSo)
            myReport.DataDefinition.ParameterFields("Ngay_Thang").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = "Bưu điện Tỉnh / Thành Phố " + GTen_Buu_Cuc_Khai_Thac
            pvCollection.Add(_pThamSo)
            myReport.DataDefinition.ParameterFields("Buu_Dien_Tinh").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            myData = myE1_Di.Doanh_Thu_Lien_Tinh_Lien_Ke(GBuu_Cuc_Khai_Thac, Tu_Ngay, Den_ngay)
            myData.Tables(0).TableName = "EMS_Lien_Tinh_Lien_Ke"
            myReport.SetDataSource(myData)

            FrmView.CrystalReportViewer1.ReportSource = myReport
            Cursor.Current = Cursors.Default
            FrmView.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click
        Dim number As Integer
        number = CbTuy_Chon_Bao_Cao.Value
        Try
            Select Case number
                Case 0
                    Doanh_Thu_HH_DL_Tu_Ngay_Den_Ngay()
                Case 1
                    Doanh_Thu_Phat_Sinh_Tu_Ngay_Den_Ngay()
                Case 2
                    HH_DL_CP_Tu_Ngay_Den_Ngay()
                Case 3
                    Doanh_Thu_Lien_Tinh_Lien_Ke()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Close()
    End Sub

    Private Sub CbTuy_Chon_Bao_Cao_RowSelected(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowSelectedEventArgs) Handles CbTuy_Chon_Bao_Cao.RowSelected
        BtnPreview.Enabled = True
        BtnPrint.Enabled = True
        LbThong_Tin.Text = CbTuy_Chon_Bao_Cao.Text
    End Sub
End Class

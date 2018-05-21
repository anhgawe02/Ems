Imports Ems_International_Logic.EMS
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Public Class FrmBaoCaoCOD
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
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpTuNgay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents dtpDenNgay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents btnDongY As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents bntreport As Infragistics.Win.Misc.UltraButton
    Friend WithEvents dtpngaygui As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents dtpngayden As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents bntBaocaodiCOD As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Denngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Tungay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmBaoCaoCOD))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.btnDongY = New Infragistics.Win.Misc.UltraButton
        Me.dtpDenNgay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpTuNgay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label2 = New System.Windows.Forms.Label
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.bntreport = New Infragistics.Win.Misc.UltraButton
        Me.dtpngayden = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtpngaygui = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label3 = New System.Windows.Forms.Label
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.bntBaocaodiCOD = New Infragistics.Win.Misc.UltraButton
        Me.Denngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Tungay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.dtpDenNgay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTuNgay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.dtpngayden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpngaygui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.Denngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tungay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.btnDongY)
        Me.UltraTabPageControl1.Controls.Add(Me.dtpDenNgay)
        Me.UltraTabPageControl1.Controls.Add(Me.Label1)
        Me.UltraTabPageControl1.Controls.Add(Me.dtpTuNgay)
        Me.UltraTabPageControl1.Controls.Add(Me.Label2)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(644, 78)
        '
        'btnDongY
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.btnDongY.Appearance = Appearance1
        Me.btnDongY.Location = New System.Drawing.Point(368, 8)
        Me.btnDongY.Name = "btnDongY"
        Me.btnDongY.Size = New System.Drawing.Size(120, 24)
        Me.btnDongY.TabIndex = 97
        Me.btnDongY.Text = "Đồng ý"
        '
        'dtpDenNgay
        '
        Me.dtpDenNgay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpDenNgay.Location = New System.Drawing.Point(264, 8)
        Me.dtpDenNgay.Name = "dtpDenNgay"
        Me.dtpDenNgay.Size = New System.Drawing.Size(89, 21)
        Me.dtpDenNgay.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label1.Location = New System.Drawing.Point(208, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "đến ngày"
        '
        'dtpTuNgay
        '
        Me.dtpTuNgay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpTuNgay.Location = New System.Drawing.Point(112, 8)
        Me.dtpTuNgay.Name = "dtpTuNgay"
        Me.dtpTuNgay.Size = New System.Drawing.Size(89, 21)
        Me.dtpTuNgay.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label2.Location = New System.Drawing.Point(56, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Ngày gửi"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.bntreport)
        Me.UltraTabPageControl2.Controls.Add(Me.dtpngayden)
        Me.UltraTabPageControl2.Controls.Add(Me.Label4)
        Me.UltraTabPageControl2.Controls.Add(Me.dtpngaygui)
        Me.UltraTabPageControl2.Controls.Add(Me.Label3)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(644, 78)
        '
        'bntreport
        '
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.bntreport.Appearance = Appearance2
        Me.bntreport.Location = New System.Drawing.Point(384, 24)
        Me.bntreport.Name = "bntreport"
        Me.bntreport.Size = New System.Drawing.Size(120, 24)
        Me.bntreport.TabIndex = 98
        Me.bntreport.Text = "Báo cáo"
        '
        'dtpngayden
        '
        Me.dtpngayden.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpngayden.Location = New System.Drawing.Point(264, 24)
        Me.dtpngayden.Name = "dtpngayden"
        Me.dtpngayden.Size = New System.Drawing.Size(89, 21)
        Me.dtpngayden.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label4.Location = New System.Drawing.Point(200, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "đến ngày"
        '
        'dtpngaygui
        '
        Me.dtpngaygui.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpngaygui.Location = New System.Drawing.Point(88, 24)
        Me.dtpngaygui.Name = "dtpngaygui"
        Me.dtpngaygui.Size = New System.Drawing.Size(89, 21)
        Me.dtpngaygui.TabIndex = 59
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label3.Location = New System.Drawing.Point(24, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Ngày gửi"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.Label6)
        Me.UltraTabPageControl3.Controls.Add(Me.Label5)
        Me.UltraTabPageControl3.Controls.Add(Me.bntBaocaodiCOD)
        Me.UltraTabPageControl3.Controls.Add(Me.Denngay)
        Me.UltraTabPageControl3.Controls.Add(Me.Tungay)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(2, 24)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(644, 78)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label6.Location = New System.Drawing.Point(224, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 101
        Me.Label6.Text = "đến ngày"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label5.Location = New System.Drawing.Point(24, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 16)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "Ngày gửi"
        '
        'bntBaocaodiCOD
        '
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        Me.bntBaocaodiCOD.Appearance = Appearance3
        Me.bntBaocaodiCOD.Location = New System.Drawing.Point(448, 32)
        Me.bntBaocaodiCOD.Name = "bntBaocaodiCOD"
        Me.bntBaocaodiCOD.Size = New System.Drawing.Size(176, 32)
        Me.bntBaocaodiCOD.TabIndex = 99
        Me.bntBaocaodiCOD.Text = "Báo chiều đi của dv COD"
        '
        'Denngay
        '
        Me.Denngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.Denngay.Location = New System.Drawing.Point(288, 32)
        Me.Denngay.Name = "Denngay"
        Me.Denngay.Size = New System.Drawing.Size(89, 21)
        Me.Denngay.TabIndex = 62
        '
        'Tungay
        '
        Me.Tungay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.Tungay.Location = New System.Drawing.Point(88, 32)
        Me.Tungay.Name = "Tungay"
        Me.Tungay.Size = New System.Drawing.Size(89, 21)
        Me.Tungay.TabIndex = 60
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Location = New System.Drawing.Point(8, 8)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(648, 104)
        Me.UltraTabControl1.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Thống kê nhận bưu gửi"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Thống kê bưu gửi COD đến phát"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Báo cáo chiều đi của dịch vụ COD"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(644, 78)
        '
        'FrmBaoCaoCOD
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(659, 117)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBaoCaoCOD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Báo cáo thống kê COD"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.dtpDenNgay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTuNgay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.dtpngayden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpngaygui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.Denngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tungay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim myCODDen As New COD_Den(GConnectionString)
    Dim myCODDi As New COD_Di(GConnectionString)
    'Dim myBuuCuc As New Danh_Muc_BC(GConnectionString)
    Dim myTable As DataTable
    Private Sub btnDongY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDongY.Click
        myTable = myCODDi.Thong_Ke_Nhan_Buu_Gui(Ham_Dung_Chung.ConvertDateToInt(dtpTuNgay.Value), Ham_Dung_Chung.ConvertDateToInt(dtpDenNgay.Value)).Tables(0)
        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue

        Dim FrmView As New FrmViewReports
        Dim rptCODDiThongKeGui As New rptCOD_Di_Thong_Ke_Nhan_Buu_Gui

        _pThamSo.Value = GBuu_Cuc_Khai_Thac.ToString + GTen_Buu_Cuc_Khai_Thac
        pvCollection.Add(_pThamSo)
        rptCODDiThongKeGui.DataDefinition.ParameterFields("Buu_Cuc_Goc").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        _pThamSo.Value = "Từ ngày " & dtpTuNgay.Text & " đến ngày " & dtpDenNgay.Text
        pvCollection.Add(_pThamSo)
        rptCODDiThongKeGui.DataDefinition.ParameterFields("Ngay_Thang").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        _pThamSo.Value = GHo_Ten
        pvCollection.Add(_pThamSo)
        rptCODDiThongKeGui.DataDefinition.ParameterFields("Nguoi_Lap").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()


        rptCODDiThongKeGui.SetDataSource(myTable)
        FrmView.CrystalReportViewer1.ReportSource = rptCODDiThongKeGui
        Cursor.Current = Cursors.Default
        FrmView.ShowDialog()
    End Sub

    Private Sub FrmBaoCaoCOD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpTuNgay.Value = Ham_Dung_Chung.dBeginMonth(Now)
        dtpDenNgay.Value = Ham_Dung_Chung.dEndMonth(Now)
        dtpngaygui.Value = Ham_Dung_Chung.dBeginMonth(Now)
        dtpngayden.Value = Ham_Dung_Chung.dEndMonth(Now)
        Tungay.Value = Ham_Dung_Chung.dBeginMonth(Now)
        Denngay.Value = Ham_Dung_Chung.dBeginMonth(Now)

    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntreport.Click
        myTable = myCODDen.COD_Den_Thong_Ke_Phat(Ham_Dung_Chung.ConvertDateToInt(dtpngaygui.Value), Ham_Dung_Chung.ConvertDateToInt(dtpngayden.Value)).Tables(0)
        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue

        Dim FrmView As New FrmViewReports
        Dim rptCODDenthongkephat As New rptCOD_Den_Thong_Ke_Phat

        _pThamSo.Value = GBuu_Cuc_Khai_Thac.ToString + GTen_Buu_Cuc_Khai_Thac
        pvCollection.Add(_pThamSo)
        rptCODDenthongkephat.DataDefinition.ParameterFields("Buu_Cuc_Goc").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        _pThamSo.Value = "Từ ngày " & dtpngaygui.Text & " đến ngày " & dtpngayden.Text
        pvCollection.Add(_pThamSo)
        rptCODDenthongkephat.DataDefinition.ParameterFields("Ngay_Thang").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        _pThamSo.Value = GHo_Ten
        pvCollection.Add(_pThamSo)
        rptCODDenthongkephat.DataDefinition.ParameterFields("Nguoi_Lap").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()


        rptCODDenthongkephat.SetDataSource(myTable)
        FrmView.CrystalReportViewer1.ReportSource = rptCODDenthongkephat
        Cursor.Current = Cursors.Default
        FrmView.ShowDialog()
    End Sub

    Private Sub UltraButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntBaocaodiCOD.Click
        myTable = myCODDi.COD_Di_Bao_Cao(Ham_Dung_Chung.ConvertDateToInt(Tungay.Value), Ham_Dung_Chung.ConvertDateToInt(Denngay.Value)).Tables(0)
        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue

        Dim FrmView As New FrmViewReports
        Dim rptCODDiBaoCao As New RptCOD_Di_Bao_Cao

        _pThamSo.Value = GBuu_Cuc_Khai_Thac.ToString + GTen_Buu_Cuc_Khai_Thac
        pvCollection.Add(_pThamSo)
        rptCODDiBaoCao.DataDefinition.ParameterFields("Buu_Cuc_Goc").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        _pThamSo.Value = "Từ ngày" & Tungay.Text & "Đến ngày" & Denngay.Text
        pvCollection.Add(_pThamSo)
        rptCODDiBaoCao.DataDefinition.ParameterFields("Ngay_Thang").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        _pThamSo.Value = GHo_Ten
        pvCollection.Add(_pThamSo)
        rptCODDiBaoCao.DataDefinition.ParameterFields("Nguoi_Lap").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        rptCODDiBaoCao.SetDataSource(myTable)
        FrmView.CrystalReportViewer1.ReportSource = rptCODDiBaoCao
        Cursor.Current = Cursors.Default
        FrmView.ShowDialog()

    End Sub
End Class

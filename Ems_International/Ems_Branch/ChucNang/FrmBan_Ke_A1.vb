Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Ems_International_Logic.EMS
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Public Class FrmBan_Ke_A1
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
    Friend WithEvents BtnExit As Infragistics.Win.Misc.UltraButton
    Friend WithEvents BtnPrint As Infragistics.Win.Misc.UltraButton
    Friend WithEvents BtnPreview As Infragistics.Win.Misc.UltraButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CbNgay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents lblStartTime As System.Windows.Forms.Label
    Friend WithEvents lblEndTime As System.Windows.Forms.Label
    Friend WithEvents txtEndTime As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtStartTime As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmBan_Ke_A1))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.BtnExit = New Infragistics.Win.Misc.UltraButton
        Me.BtnPrint = New Infragistics.Win.Misc.UltraButton
        Me.BtnPreview = New Infragistics.Win.Misc.UltraButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtEndTime = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.txtStartTime = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.lblStartTime = New System.Windows.Forms.Label
        Me.lblEndTime = New System.Windows.Forms.Label
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.CbNgay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.GroupBox1.SuspendLayout()
        CType(Me.CbNgay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnExit
        '
        Appearance1.FontData.BoldAsString = "True"
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.BtnExit.Appearance = Appearance1
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(272, 168)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(88, 32)
        Me.BtnExit.TabIndex = 3
        Me.BtnExit.Text = "Exit"
        '
        'BtnPrint
        '
        Appearance2.FontData.BoldAsString = "True"
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Appearance2.TextHAlign = Infragistics.Win.HAlign.Center
        Me.BtnPrint.Appearance = Appearance2
        Me.BtnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.Location = New System.Drawing.Point(176, 168)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(80, 32)
        Me.BtnPrint.TabIndex = 2
        Me.BtnPrint.Text = "Printer"
        '
        'BtnPreview
        '
        Appearance3.FontData.BoldAsString = "True"
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        Me.BtnPreview.Appearance = Appearance3
        Me.BtnPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPreview.Location = New System.Drawing.Point(72, 168)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(88, 32)
        Me.BtnPreview.TabIndex = 1
        Me.BtnPreview.Text = "Preview"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEndTime)
        Me.GroupBox1.Controls.Add(Me.txtStartTime)
        Me.GroupBox1.Controls.Add(Me.lblStartTime)
        Me.GroupBox1.Controls.Add(Me.lblEndTime)
        Me.GroupBox1.Controls.Add(Me.UltraLabel4)
        Me.GroupBox1.Controls.Add(Me.CbNgay)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 126)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nhập thông tin về thời gian"
        '
        'txtEndTime
        '
        Me.txtEndTime.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtEndTime.InputMask = "##:##"
        Me.txtEndTime.Location = New System.Drawing.Point(264, 80)
        Me.txtEndTime.Name = "txtEndTime"
        Me.txtEndTime.Size = New System.Drawing.Size(80, 22)
        Me.txtEndTime.TabIndex = 5
        Me.txtEndTime.Text = ":"
        '
        'txtStartTime
        '
        Me.txtStartTime.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtStartTime.InputMask = "##:##"
        Me.txtStartTime.Location = New System.Drawing.Point(112, 80)
        Me.txtStartTime.Name = "txtStartTime"
        Me.txtStartTime.Size = New System.Drawing.Size(64, 22)
        Me.txtStartTime.TabIndex = 3
        Me.txtStartTime.Text = ":"
        '
        'lblStartTime
        '
        Me.lblStartTime.BackColor = System.Drawing.Color.Transparent
        Me.lblStartTime.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartTime.Location = New System.Drawing.Point(16, 80)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(76, 24)
        Me.lblStartTime.TabIndex = 2
        Me.lblStartTime.Text = "Từ giờ:"
        Me.lblStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEndTime
        '
        Me.lblEndTime.BackColor = System.Drawing.Color.Transparent
        Me.lblEndTime.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndTime.Location = New System.Drawing.Point(208, 80)
        Me.lblEndTime.Name = "lblEndTime"
        Me.lblEndTime.Size = New System.Drawing.Size(76, 24)
        Me.lblEndTime.TabIndex = 4
        Me.lblEndTime.Text = "Đến giờ:"
        Me.lblEndTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(16, 36)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel4.TabIndex = 0
        Me.UltraLabel4.Text = "Ngày khai thác"
        '
        'CbNgay
        '
        Me.CbNgay.DateTime = New Date(2008, 7, 3, 0, 0, 0, 0)
        Me.CbNgay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.CbNgay.Location = New System.Drawing.Point(112, 32)
        Me.CbNgay.Name = "CbNgay"
        Me.CbNgay.Size = New System.Drawing.Size(96, 24)
        Me.CbNgay.TabIndex = 1
        Me.CbNgay.Value = New Date(2008, 7, 3, 0, 0, 0, 0)
        '
        'FrmBan_Ke_A1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(432, 213)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.BtnPreview)
        Me.Name = "FrmBan_Ke_A1"
        Me.Text = "In bản kê A1"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.CbNgay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Khai báo biến"
    Dim myKeys As New ModifyRegistry

    Dim myStartTime As Integer
    Dim myEndTime As Integer

    Dim myDate As Integer

    Dim myHam_Dung_Chung As New Ham_Dung_Chung

    Dim myE1_Den As New E1_Den(GConnectionString)
    Dim myE1_Di As New E1_Di(GConnectionString)
#End Region

#Region "From Load"
    Private Sub FrmBan_Ke_A1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetKeys()
        CbNgay.Value = Today
        txtStartTime.Value = myHam_Dung_Chung.ConvertIntToTime(myStartTime)
        txtEndTime.Value = myHam_Dung_Chung.ConvertIntToTime(myEndTime)
    End Sub
#End Region

#Region "Form Close"
    Private Sub FrmBan_Ke_A1_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        SetKeys()
    End Sub
#End Region

#Region "Set, Get Registry"
    Private Sub SetKeys()
        myKeys.Ghi("Ban_Ke_A1_Start_Time", txtStartTime.Text)
        myKeys.Ghi("Ban_Ke_A1_End_Time", txtEndTime.Text)
    End Sub

    Private Sub GetKeys()
        myStartTime = myHam_Dung_Chung.ConvertTimeToInt(IIf(myKeys.Doc("Ban_Ke_A1_Start_Time") Is Nothing Or myKeys.Doc("Ban_Ke_A1_Start_Time") = "", "07:00", myKeys.Doc("Ban_Ke_A1_Start_Time")))
        myEndTime = myHam_Dung_Chung.ConvertTimeToInt(IIf(myKeys.Doc("Ban_Ke_A1_End_Time") Is Nothing Or myKeys.Doc("Ban_Ke_A1_End_Time") = "", "12:00", myKeys.Doc("Ban_Ke_A1_End_Time")))
    End Sub
#End Region

#Region "----------Preview----------"
    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click
        Try
            'Lấy thông số về thời gian
            myDate = myHam_Dung_Chung.ConvertDateToInt(CbNgay.Value)
            myStartTime = myHam_Dung_Chung.ConvertTimeToInt(txtStartTime.Value)
            myEndTime = myHam_Dung_Chung.ConvertTimeToInt(txtEndTime.Value)

            Select Case GOutBout
                Case 0 'Quốc tế đến
                    Ban_Ke_A1_Den(True, myDate, myStartTime, myEndTime)
                Case 1 'Quốc tế đi
                    Ban_Ke_A1_Di(True, myDate, myStartTime, myEndTime)
                Case 2 ' Hải quan
                    MessageBox.Show("Không thể in được bản kê A1 cho phân loại bưu cục khai thác là hải quan!!!")
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

#End Region

#Region "----------Print-----------"
    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Try
            'Lấy thông số về thời gian
            myDate = myHam_Dung_Chung.ConvertDateToInt(CbNgay.Value)
            myStartTime = myHam_Dung_Chung.ConvertTimeToInt(txtStartTime.Value)
            myEndTime = myHam_Dung_Chung.ConvertTimeToInt(txtEndTime.Value)

            If GOutBout = 1 Then 'Quốc tế đi
                Ban_Ke_A1_Di(False, myDate, myStartTime, myEndTime)
            ElseIf GOutBout = 0 Then 'Quốc tế đến
                Ban_Ke_A1_Den(False, myDate, myStartTime, myEndTime)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "--------Exit------------"
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Close()
    End Sub
#End Region

#Region "Bản kê A1 Đến: quốc tế đến"
    Private Sub Ban_Ke_A1_Den(ByVal isPreview As Boolean, ByVal Ngay_Khai_Thac As Integer, ByVal Tu_Gio As Integer, ByVal Den_Gio As Integer)
        'Bản kê A2 bưu phẩm quốc tế đến (Tài liệu)
        'Ngày khai thác: 
        'Từ giờ - đến giờ

        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue
        Dim FrmView As New FrmViewReports
        Dim rptBan_ke_A1_Quoc_Te_Den_KT As New rptBan_ke_A1_Quoc_Te_Den 'Tên báo cáo
        Dim myData As DataSet

        'Dim myTable As New DataTable("E1_Di_Ban_Ke_A1_Quoc_Te_Den")
        'myTable = myE1_Di.E1_Di_Ban_Ke_A1_Quoc_Te_Den(GBuu_Cuc_Khai_Thac, Ngay_Khai_Thac, Tu_Gio, Den_Gio).Tables(0)

        'Ngày Tháng
        _pThamSo.Value = myHam_Dung_Chung.ConvertIntToVNDateType(Ngay_Khai_Thac).ToString
        pvCollection.Add(_pThamSo)
        rptBan_ke_A1_Quoc_Te_Den_KT.DataDefinition.ParameterFields("Ngay_Khai_Thac").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()
        'Từ Giờ
        _pThamSo.Value = myHam_Dung_Chung.ConvertIntToTime(Tu_Gio).ToString
        pvCollection.Add(_pThamSo)
        rptBan_ke_A1_Quoc_Te_Den_KT.DataDefinition.ParameterFields("Tu_Gio").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()
        'Đến Giờ
        _pThamSo.Value = myHam_Dung_Chung.ConvertIntToTime(Den_Gio).ToString
        pvCollection.Add(_pThamSo)
        rptBan_ke_A1_Quoc_Te_Den_KT.DataDefinition.ParameterFields("Den_Gio").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        ''Bưu cục khai thác
        _pThamSo.Value = GBuu_Cuc_Khai_Thac.ToString & " - " & GTen_Buu_Cuc_Khai_Thac
        pvCollection.Add(_pThamSo)
        rptBan_ke_A1_Quoc_Te_Den_KT.DataDefinition.ParameterFields("Buu_Cuc_Khai_Thac").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        'Tên bưu cục khai thác
        _pThamSo.Value = GTen_Buu_Cuc_Khai_Thac
        pvCollection.Add(_pThamSo)
        rptBan_ke_A1_Quoc_Te_Den_KT.DataDefinition.ParameterFields("Ten_Bc_Khai_Thac").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        'Người sử dụng
        Dim myNguoi_Dung As New Nguoi_Dung(GConnectionString)
        _pThamSo.Value = myNguoi_Dung.Lay(Gid_Nguoi_Dung).Ho_Ten.ToString
        pvCollection.Add(_pThamSo)
        rptBan_ke_A1_Quoc_Te_Den_KT.DataDefinition.ParameterFields("Nguoi_Su_Dung").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        'Ngày Tháng
        _pThamSo.Value = myHam_Dung_Chung.ConvertIntToDate_VN(Ngay_Khai_Thac).ToString
        pvCollection.Add(_pThamSo)
        rptBan_ke_A1_Quoc_Te_Den_KT.DataDefinition.ParameterFields("Ngay_Khai_Thac_VN").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        'myData.Tables.Add(myTable.Copy)
        myData = myE1_Di.E1_Di_Ban_Ke_A1_Quoc_Te_Den(GBuu_Cuc_Khai_Thac, Ngay_Khai_Thac, Tu_Gio, Den_Gio)
        If myData.Tables(0).Rows.Count = 0 Then
            MessageBox.Show("Không có dữ liệu trong khoảng thời gian này", "Thông báo")
            CbNgay.Focus()
        Else
            rptBan_ke_A1_Quoc_Te_Den_KT.SetDataSource(myData)
            FrmView.CrystalReportViewer1.ReportSource = rptBan_ke_A1_Quoc_Te_Den_KT
            Cursor.Current = Cursors.Default
            If isPreview = True Then
                FrmView.ShowDialog()
            Else
                rptBan_ke_A1_Quoc_Te_Den_KT.PrintToPrinter(1, True, 0, 0)
            End If
        End If
    End Sub
#End Region

#Region "Bản kê A1 Đi: Quốc tế đi"
    Private Sub Ban_Ke_A1_Di(ByVal isPreview As Boolean, ByVal Ngay_Khai_Thac As Integer, ByVal Tu_Gio As Integer, ByVal Den_Gio As Integer)
        'Bản kê A2 bưu phẩm quốc tế đi (Tài liệu)
        'Ngày khai thác: 
        'Từ giờ - đến giờ

        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue
        Dim FrmView As New FrmViewReports
        Dim rptBan_ke_A1_Quoc_Te_Di_KT As New rptBan_ke_A1_Quoc_Te_Di 'Tên báo cáo
        Dim myData As DataSet

        'Dim myTable As New DataTable("E1_Di_Ban_Ke_A1_Quoc_Te_Den")
        'myTable = myE1_Di.E1_Di_Ban_Ke_A1_Quoc_Te_Den(GBuu_Cuc_Khai_Thac, Ngay_Khai_Thac, Tu_Gio, Den_Gio).Tables(0)

        'Ngày Tháng
        _pThamSo.Value = myHam_Dung_Chung.ConvertIntToVNDateType(Ngay_Khai_Thac).ToString
        pvCollection.Add(_pThamSo)
        rptBan_ke_A1_Quoc_Te_Di_KT.DataDefinition.ParameterFields("Ngay_Khai_Thac").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()
        'Từ Giờ
        _pThamSo.Value = myHam_Dung_Chung.ConvertIntToTime(Tu_Gio).ToString
        pvCollection.Add(_pThamSo)
        rptBan_ke_A1_Quoc_Te_Di_KT.DataDefinition.ParameterFields("Tu_Gio").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()
        'Đến Giờ
        _pThamSo.Value = myHam_Dung_Chung.ConvertIntToTime(Den_Gio).ToString
        pvCollection.Add(_pThamSo)
        rptBan_ke_A1_Quoc_Te_Di_KT.DataDefinition.ParameterFields("Den_Gio").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        ''Bưu cục khai thác
        _pThamSo.Value = GBuu_Cuc_Khai_Thac.ToString & " - " & GTen_Buu_Cuc_Khai_Thac
        pvCollection.Add(_pThamSo)
        rptBan_ke_A1_Quoc_Te_Di_KT.DataDefinition.ParameterFields("Buu_Cuc_Khai_Thac").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        'Tên bưu cục khai thác
        _pThamSo.Value = GTen_Buu_Cuc_Khai_Thac
        pvCollection.Add(_pThamSo)
        rptBan_ke_A1_Quoc_Te_Di_KT.DataDefinition.ParameterFields("Ten_Bc_Khai_Thac").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        'Người sử dụng
        Dim myNguoi_Dung As New Nguoi_Dung(GConnectionString)
        _pThamSo.Value = myNguoi_Dung.Lay(Gid_Nguoi_Dung).Ho_Ten.ToString
        pvCollection.Add(_pThamSo)
        rptBan_ke_A1_Quoc_Te_Di_KT.DataDefinition.ParameterFields("Nguoi_Su_Dung").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        'Ngày Tháng
        _pThamSo.Value = myHam_Dung_Chung.ConvertIntToDate_VN(Ngay_Khai_Thac).ToString
        pvCollection.Add(_pThamSo)
        rptBan_ke_A1_Quoc_Te_Di_KT.DataDefinition.ParameterFields("Ngay_Khai_Thac_VN").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        'myData.Tables.Add(myTable.Copy)
        myData = myE1_Di.E1_Di_Ban_Ke_A1_Quoc_Te_Di(GBuu_Cuc_Khai_Thac, Ngay_Khai_Thac, Tu_Gio, Den_Gio)
        If myData.Tables(0).Rows.Count = 0 Then
            MessageBox.Show("Không có dữ liệu trong khoảng thời gian này", "Thông báo")
            CbNgay.Focus()
        Else
            rptBan_ke_A1_Quoc_Te_Di_KT.SetDataSource(myData)
            FrmView.CrystalReportViewer1.ReportSource = rptBan_ke_A1_Quoc_Te_Di_KT
            Cursor.Current = Cursors.Default
            If isPreview = True Then
                FrmView.ShowDialog()
            Else
                rptBan_ke_A1_Quoc_Te_Di_KT.PrintToPrinter(1, True, 0, 0)
            End If
        End If
    End Sub
#End Region

End Class

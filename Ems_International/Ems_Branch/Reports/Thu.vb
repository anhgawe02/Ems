Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Ems_International_Logic.EMS
Public Class Thu
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
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents chk As System.Windows.Forms.CheckBox
    Friend WithEvents txtE2 As System.Windows.Forms.TextBox
    Friend WithEvents btnBc01 As System.Windows.Forms.Button
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtBanKe As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtDEN As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtB = New System.Windows.Forms.TextBox
        Me.btnProcess = New System.Windows.Forms.Button
        Me.txtE2 = New System.Windows.Forms.TextBox
        Me.chk = New System.Windows.Forms.CheckBox
        Me.btnBc01 = New System.Windows.Forms.Button
        Me.txt2 = New System.Windows.Forms.TextBox
        Me.txtBanKe = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.txtDEN = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(56, 8)
        Me.txtB.Name = "txtB"
        Me.txtB.TabIndex = 43
        Me.txtB.Text = "EE130383981VN"
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(512, 8)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.TabIndex = 44
        Me.btnProcess.Text = "&B"
        '
        'txtE2
        '
        Me.txtE2.Location = New System.Drawing.Point(272, 8)
        Me.txtE2.Name = "txtE2"
        Me.txtE2.Size = New System.Drawing.Size(224, 20)
        Me.txtE2.TabIndex = 45
        Me.txtE2.Text = "1009161000002008080916580001002"
        '
        'chk
        '
        Me.chk.Location = New System.Drawing.Point(200, 8)
        Me.chk.Name = "chk"
        Me.chk.Size = New System.Drawing.Size(64, 16)
        Me.chk.TabIndex = 46
        Me.chk.Text = "In E2"
        '
        'btnBc01
        '
        Me.btnBc01.Location = New System.Drawing.Point(176, 48)
        Me.btnBc01.Name = "btnBc01"
        Me.btnBc01.TabIndex = 48
        Me.btnBc01.Text = "Bc01"
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(56, 48)
        Me.txt2.Name = "txt2"
        Me.txt2.TabIndex = 47
        Me.txt2.Text = "30F88810002303"
        '
        'txtBanKe
        '
        Me.txtBanKe.Location = New System.Drawing.Point(296, 48)
        Me.txtBanKe.Name = "txtBanKe"
        Me.txtBanKe.TabIndex = 49
        Me.txtBanKe.Text = "010091522208302009021336ED"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(408, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "Bản Kê E2 Đi"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(408, 80)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 23)
        Me.Button2.TabIndex = 52
        Me.Button2.Text = "Bản Kê E2 Đến"
        '
        'txtDEN
        '
        Me.txtDEN.Location = New System.Drawing.Point(296, 80)
        Me.txtDEN.Name = "txtDEN"
        Me.txtDEN.TabIndex = 51
        Me.txtDEN.Text = "7009161009162008081409470305001"
        '
        'Thu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(631, 422)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtDEN)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtBanKe)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txtE2)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.btnBc01)
        Me.Controls.Add(Me.chk)
        Me.Controls.Add(Me.btnProcess)
        Me.Name = "Thu"
        Me.Text = "Execution"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim myData As DataTable
    Dim myReport As New rptE1
    Dim myrptE2 As New rptE2
    Dim myrptHoa_Don As New rptHoaDonBc01
    Dim myE1_Di As New E1_Di(GConnectionString)
    Dim i, j, rawKind As Integer
    Dim myObject As Object
    Dim myToaDoIn As New Toa_Do_In(GConnectionString)
    Private Function GetField(ByVal obj As Object, ByVal fieldName As String) As Object
        Dim fi As System.Reflection.FieldInfo
        fi = obj.GetType().GetField(fieldName, Reflection.BindingFlags.Instance Or Reflection.BindingFlags.Public Or Reflection.BindingFlags.NonPublic)
        Return fi.GetValue(obj)
    End Function

    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        
        If chk.Checked Then
            Dim myE1_Di As New E1_Di(GConnectionString)
            Dim FrmView As New FrmViewReports
            myData = myE1_Di.E1_Di_Hoa_Don(txtB.Text).Tables(0)
            myReport.SetDataSource(myData)
            Dim printDoc As New System.Drawing.Printing.PrintDocument
            For i = 0 To printDoc.PrinterSettings.PaperSizes.Count - 1
                If printDoc.PrinterSettings.PaperSizes(i).PaperName = "E1" Then
                    rawKind = Convert.ToInt32(GetField(printDoc.PrinterSettings.PaperSizes(i), "kind"))
                    myObject = printDoc.PrinterSettings.PaperSizes(i)
                End If
            Next
            Dim thucai As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim rpInvoice As ReportClass
            rpInvoice = myReport
            rpInvoice.PrintOptions.PaperSize = rawKind
            Dim myTable As DataTable = myToaDoIn.Danh_Sach_Lay_Boi_Kho_Giay("E1").Tables(0)
            For i = 0 To myTable.Rows.Count - 1
                rpInvoice.ReportDefinition.ReportObjects(myTable.Rows(i).Item("Ten_Doi_Tuong")).Top = Convert.ToInt32(myTable.Rows(i).Item("Toa_Do_Top"))
                rpInvoice.ReportDefinition.ReportObjects(myTable.Rows(i).Item("Ten_Doi_Tuong")).left = Convert.ToInt32(myTable.Rows(i).Item("Toa_Do_Left"))
            Next
            FrmView.CrystalReportViewer1.ReportSource = rpInvoice
            'FrmView.CrystalReportViewer1.
            Cursor.Current = Cursors.Default
            FrmView.ShowDialog()
        Else
            Dim myNguoi_Dung As New Nguoi_Dung(GConnectionString)
            Dim myE2_Di As New E2_Di(GConnectionString)
            Dim myE2_Di_ChiTiet As New E2_Di_Chi_Tiet
            Dim Id_E2 As String = txtE2.Text
            Dim pvCollection As New ParameterValues
            Dim _pThamSo As New ParameterDiscreteValue

            Dim FrmView As New FrmViewReports
            Dim myHamdungchung As New Ham_Dung_Chung
            Dim myData As DataSet
            Dim myChuyen_Thu_Di As New Chuyen_Thu_Di(GConnectionString)
            Dim myMa_Bc_Khai_Thac As New Ma_Bc_Khai_Thac(GConnectionString)
            Dim myDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)
            Dim Ma_Bc_Khai_Thac As Integer = myE2_Di.Lay(Id_E2).Ma_Bc_Khai_Thac
            Dim Ten_Dang_Nhap As String = myNguoi_Dung.Lay(myE1_Di.Lay_Id_Nguoi_Dung(Id_E2)).Ten_Dang_Nhap
            Dim Id_Duong_Thu As String = myE2_Di.Lay(Id_E2).Id_Duong_Thu
            Dim Id_Chuyen_Thu As String = myE2_Di.Lay(Id_E2).Id_Chuyen_Thu
            Dim Tui_So As Integer = myE2_Di.Lay(Id_E2).Tui_So
            Dim Ma_Bc As Integer = Convert.ToInt32(Id_E2.Substring(6, 6))
            Dim Ngay_Thang As Integer = myE2_Di.Lay(Id_E2).Ngay_Dong
            Dim Gio As String = myHamdungchung.ConvertIntToTime(myE2_Di.Lay(Id_E2).Gio_Dong)


            ''Từ/From
            _pThamSo.Value = Ma_Bc_Khai_Thac.ToString + "-" + myMa_Bc_Khai_Thac.Lay(Ma_Bc_Khai_Thac).Ten_Bc_Khai_Thac
            pvCollection.Add(_pThamSo)
            myrptE2.DataDefinition.ParameterFields("Ma_Bc_Khai_Thac").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            ''Chuyến thư
            _pThamSo.Value = myChuyen_Thu_Di.Lay(Id_Chuyen_Thu).So_Chuyen_Thu
            pvCollection.Add(_pThamSo)
            myrptE2.DataDefinition.ParameterFields("Chuyen_Thu").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            ''Túi số
            _pThamSo.Value = Tui_So
            pvCollection.Add(_pThamSo)
            myrptE2.DataDefinition.ParameterFields("Tui_So").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            ''Gửi đến
            _pThamSo.Value = Ma_Bc.ToString + "-" + myDanh_Muc_BC.Lay(Ma_Bc).Ten_Buu_Cuc
            pvCollection.Add(_pThamSo)
            myrptE2.DataDefinition.ParameterFields("Ma_Bc").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            ''Giờ
            _pThamSo.Value = Gio
            pvCollection.Add(_pThamSo)
            myrptE2.DataDefinition.ParameterFields("Gio").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            ''Ngày Tháng
            _pThamSo.Value = myHamdungchung.ConvertIntToVNDateType(Ngay_Thang)
            pvCollection.Add(_pThamSo)
            myrptE2.DataDefinition.ParameterFields("Ngay_Thang").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            ''Họ tên
            _pThamSo.Value = Ten_Dang_Nhap
            pvCollection.Add(_pThamSo)
            myrptE2.DataDefinition.ParameterFields("Ho_Ten").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            myData = myE2_Di.E2_Di_Ban_Ke(Id_E2)
            myrptE2.SetDataSource(myData)
            Dim printDoc As New System.Drawing.Printing.PrintDocument
            For i = 0 To printDoc.PrinterSettings.PaperSizes.Count - 1
                If printDoc.PrinterSettings.PaperSizes(i).PaperName = "E2" Then
                    rawKind = Convert.ToInt32(GetField(printDoc.PrinterSettings.PaperSizes(i), "kind"))
                    myObject = printDoc.PrinterSettings.PaperSizes(i)
                End If
            Next
            Dim thucai As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim rpInvoice As ReportClass
            rpInvoice = myrptE2
            rpInvoice.PrintOptions.PaperSize = rawKind
            Dim myTable As DataTable = myToaDoIn.Danh_Sach_Lay_Boi_Kho_Giay("E2").Tables(0)
            For i = 0 To myTable.Rows.Count - 1
                rpInvoice.ReportDefinition.ReportObjects(myTable.Rows(i).Item("Ten_Doi_Tuong")).Top = Convert.ToInt32(myTable.Rows(i).Item("Toa_Do_Top"))
                rpInvoice.ReportDefinition.ReportObjects(myTable.Rows(i).Item("Ten_Doi_Tuong")).left = Convert.ToInt32(myTable.Rows(i).Item("Toa_Do_Left"))
            Next
            FrmView.CrystalReportViewer1.ReportSource = rpInvoice
            Cursor.Current = Cursors.Default
            FrmView.ShowDialog()
        End If
    End Sub

    Private Sub chk_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk.CheckedChanged
        If chk.Checked Then
            chk.Text = "in E1"
        Else
            chk.Text = "in E2"
        End If
    End Sub
    Private Sub btnBc01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBc01.Click
        Dim myNumber As New ConvertNumberToString
        Dim myHoa_Don As New Hoa_Don(GConnectionString)
        Dim FrmView As New FrmViewReports
        myData = myHoa_Don.In_Hoa_Don(txt2.Text).Tables(0)

        For i = 0 To myData.Rows.Count - 1
            Dim TaxTemp As String = ""
            For j = 0 To Convert.ToString(myData.Rows(i).Item("Ma_So_Thue")).Length - 1
                If Convert.ToString(myData.Rows(i).Item("Ma_So_Thue")).Chars(j).ToString.Trim <> "" Then
                    TaxTemp = TaxTemp & Convert.ToString(myData.Rows(i).Item("Ma_So_Thue")).Chars(j) + "   "
                End If
            Next
            myData.Rows(i).Item("Ma_So_Thue") = TaxTemp
            myData.Rows(i).Item("Gia_Tri") = Convert.ToInt64(myData.Rows(i).Item("Gia_Tri"))
            myData.Rows(i).Item("Vat") = Convert.ToInt64(myData.Rows(i).Item("Vat"))
            myData.Rows(i).Item("Total") = Convert.ToInt64(myData.Rows(i).Item("Total"))
            myNumber.Number = Convert.ToInt64(myData.Rows(i).Item("Total"))
            myData.Rows(i).Item("InWord") = myNumber.StringNumber & "đồng chẵn"
        Next
        Dim printDoc As New System.Drawing.Printing.PrintDocument
        For i = 0 To printDoc.PrinterSettings.PaperSizes.Count - 1
            If printDoc.PrinterSettings.PaperSizes(i).PaperName = "HoaDon" Then
                rawKind = Convert.ToInt32(GetField(printDoc.PrinterSettings.PaperSizes(i), "kind"))
                myObject = printDoc.PrinterSettings.PaperSizes(i)
            End If
        Next

        Dim thucai As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim rpInvoice As ReportClass
        rpInvoice = myrptHoa_Don
        rpInvoice.PrintOptions.PaperSize = rawKind
        Dim myTable As DataTable = myToaDoIn.Danh_Sach_Lay_Boi_Kho_Giay("BC01").Tables(0)
        For i = 0 To myTable.Rows.Count - 1
            rpInvoice.ReportDefinition.ReportObjects(myTable.Rows(i).Item("Ten_Doi_Tuong")).Top = Convert.ToInt32(myTable.Rows(i).Item("Toa_Do_Top"))
            rpInvoice.ReportDefinition.ReportObjects(myTable.Rows(i).Item("Ten_Doi_Tuong")).left = Convert.ToInt32(myTable.Rows(i).Item("Toa_Do_Left"))
        Next
        FrmView.CrystalReportViewer1.ReportSource = rpInvoice
        myrptHoa_Don.SetDataSource(myData)
        Cursor.Current = Cursors.Default
        FrmView.ShowDialog()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Ban_Ke_E2_Di(txtBanKe.Text, True, 1, 1)
        'Dim aa As New In_CN38_TEXT
        'Ban_Ke_E2_Di_Despatch_3Cot(txtBanKe.Text, True, 1)
        'aa.Ban_Ke_E2_Di_To_Text(txtBanKe.Text, False, 1)
        'Ban_Ke_CN38(txtBanKe.Text, True, 1)
        'Common.La_Nhan_E4(txtBanKe.Text, True)
        'Dim aa As New Common.In_BC37_To_Text
        'aa.WriteBC37TEXT(txtBanKe.Text, False, 1)
        'Dim aa As New RptCN35innhan
        'Dim frm As New FrmViewReports
        'frm.CrystalReportViewer1.ReportSource = aa
        'frm.ShowDialog()
        'Common.In_Nhan_CN35(txtBanKe.Text, True, 1)
        'Common.WriteCN35TEXT(txtBanKe.Text, True, 1)
        'Common.Ban_Ke_Ke_Toan_EMS_Chieu_Den(20090101, 20090131, True, 1)
        'Common.Ban_Ke_Ke_Toan_EMS_Chieu_Di(20090101, 20090131, True, 1)       

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Ban_Ke_E2_Den(txtDEN.Text, True, 1)
    End Sub
End Class

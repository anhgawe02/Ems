Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Ems_International_Logic.EMS
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Public Class FrmBan_Ke_A1_Noi_Bai
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
    Friend WithEvents optTai_Lieu As System.Windows.Forms.RadioButton
    Friend WithEvents optHang_Hoa As System.Windows.Forms.RadioButton
    Friend WithEvents optChuyen_Tiep As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.BtnExit = New Infragistics.Win.Misc.UltraButton
        Me.BtnPrint = New Infragistics.Win.Misc.UltraButton
        Me.BtnPreview = New Infragistics.Win.Misc.UltraButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.optHang_Hoa = New System.Windows.Forms.RadioButton
        Me.optTai_Lieu = New System.Windows.Forms.RadioButton
        Me.txtEndTime = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.txtStartTime = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.lblStartTime = New System.Windows.Forms.Label
        Me.lblEndTime = New System.Windows.Forms.Label
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.CbNgay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.optChuyen_Tiep = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.CbNgay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnExit
        '
        Appearance1.FontData.BoldAsString = "True"
        Me.BtnExit.Appearance = Appearance1
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(272, 208)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(88, 32)
        Me.BtnExit.TabIndex = 3
        Me.BtnExit.Text = "Exit"
        '
        'BtnPrint
        '
        Appearance2.FontData.BoldAsString = "True"
        Appearance2.TextHAlign = Infragistics.Win.HAlign.Center
        Me.BtnPrint.Appearance = Appearance2
        Me.BtnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.Location = New System.Drawing.Point(176, 208)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(80, 32)
        Me.BtnPrint.TabIndex = 2
        Me.BtnPrint.Text = "Printer"
        '
        'BtnPreview
        '
        Appearance3.FontData.BoldAsString = "True"
        Me.BtnPreview.Appearance = Appearance3
        Me.BtnPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPreview.Location = New System.Drawing.Point(72, 208)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(88, 32)
        Me.BtnPreview.TabIndex = 1
        Me.BtnPreview.Text = "Preview"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optChuyen_Tiep)
        Me.GroupBox1.Controls.Add(Me.optHang_Hoa)
        Me.GroupBox1.Controls.Add(Me.optTai_Lieu)
        Me.GroupBox1.Controls.Add(Me.txtEndTime)
        Me.GroupBox1.Controls.Add(Me.txtStartTime)
        Me.GroupBox1.Controls.Add(Me.lblStartTime)
        Me.GroupBox1.Controls.Add(Me.lblEndTime)
        Me.GroupBox1.Controls.Add(Me.UltraLabel4)
        Me.GroupBox1.Controls.Add(Me.CbNgay)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 168)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nhập thông tin về thời gian"
        '
        'optHang_Hoa
        '
        Me.optHang_Hoa.Location = New System.Drawing.Point(144, 128)
        Me.optHang_Hoa.Name = "optHang_Hoa"
        Me.optHang_Hoa.TabIndex = 7
        Me.optHang_Hoa.Text = "Hàng hóa"
        '
        'optTai_Lieu
        '
        Me.optTai_Lieu.Checked = True
        Me.optTai_Lieu.Location = New System.Drawing.Point(40, 128)
        Me.optTai_Lieu.Name = "optTai_Lieu"
        Me.optTai_Lieu.TabIndex = 6
        Me.optTai_Lieu.TabStop = True
        Me.optTai_Lieu.Text = "Tài liệu"
        '
        'txtEndTime
        '
        Me.txtEndTime.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtEndTime.Enabled = False
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
        Me.txtStartTime.Enabled = False
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
        Me.lblStartTime.Enabled = False
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
        Me.lblEndTime.Enabled = False
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
        'optChuyen_Tiep
        '
        Me.optChuyen_Tiep.Location = New System.Drawing.Point(256, 128)
        Me.optChuyen_Tiep.Name = "optChuyen_Tiep"
        Me.optChuyen_Tiep.TabIndex = 8
        Me.optChuyen_Tiep.Text = "Chuyển tiếp"
        '
        'FrmBan_Ke_A1_Noi_Bai
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(432, 261)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.BtnPreview)
        Me.Name = "FrmBan_Ke_A1_Noi_Bai"
        Me.Text = "In bản kê A1"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.CbNgay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Khai báo biến"
    Dim myStartTime As Integer
    Dim myEndTime As Integer
    Dim myDate As Integer
    Dim myHam_Dung_Chung As New Ham_Dung_Chung
    Dim myKieu As Integer
#End Region

#Region "From Load"
    Private Sub FrmBan_Ke_A1_Noi_Bai_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CbNgay.Value = Today
        'txtStartTime.Value = myHam_Dung_Chung.ConvertIntToTime(myStartTime)
        'txtEndTime.Value = myHam_Dung_Chung.ConvertIntToTime(myEndTime)
    End Sub
#End Region

#Region "----------Preview----------"
    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click
        Try
            'Lấy thông số về thời gian
            myDate = myHam_Dung_Chung.ConvertDateToInt(CbNgay.Value)
            'myStartTime = myHam_Dung_Chung.ConvertTimeToInt(txtStartTime.Value)
            'myEndTime = myHam_Dung_Chung.ConvertTimeToInt(txtEndTime.Value)
            If optTai_Lieu.Checked Then   'Tai lieu
                myKieu = 0
            ElseIf optHang_Hoa.Checked Then     'Hang hoa
                myKieu = 1
            Else        'Chuyen tiep
                myKieu = 2
            End If
            Ban_Ke_A1_3Cot(True, myDate, myKieu)
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
            'myStartTime = myHam_Dung_Chung.ConvertTimeToInt(txtStartTime.Value)
            'myEndTime = myHam_Dung_Chung.ConvertTimeToInt(txtEndTime.Value)
            If optTai_Lieu.Checked Then   'Tai lieu
                myKieu = 0
            ElseIf optHang_Hoa.Checked Then     'Hang hoa
                myKieu = 1
            Else        'Chuyen tiep
                myKieu = 2
            End If
            Ban_Ke_A1_3Cot(False, myDate, myKieu)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "--------Exit------------"
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
        Me.Dispose()
    End Sub
#End Region

#Region "------------Bản Kê A1 in 3 cột------------"
    Public Sub Ban_Ke_A1_3Cot(ByVal isPreview As Boolean, ByVal Ngay_Khai_Thac As Integer, ByVal Kieu As Integer)
        Dim myE1_Di As New E1_Di(GConnectionString)
        Dim FrmView As New FrmViewReports
        Dim rptVIEW As New RptBan_Ke_A1_3cot
        Dim myDataSet As New DataSet
        Dim myTable As New DataTable
        Dim myTableCot1 As New DataTable
        Dim myTableCot2 As New DataTable
        Dim myTableCot3 As New DataTable
        Dim myTableAll As New DataTable("Ban_Ke_A1_Noi_Bai")

        Dim idx As Integer

        Dim pTong_So_BP As Integer
        Dim pTen_Bao_Cao As String
        Dim pBuu_Cuc_Khai_Thac As String
        Dim pNgay_Khai_Thac As String
        Dim pNgay_Thang_Nam As String
        Dim pTen_Nguoi_Dung As String

        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue

        'Lay du lieu
        myTable = myE1_Di.E1_Di_Ban_Ke_A1_3_Cot(GBuu_Cuc_Khai_Thac, Ngay_Khai_Thac, Kieu).Tables(0)
        'Kiem tra xem co du lieu khong
        If myTable.Rows.Count = 0 Then
            MsgBox("Không có dữ liệu cho bản kê này", MsgBoxStyle.Information, "Thông báo")
            Exit Sub
        End If
        '------------------------
        'Them cac field cho cac bang du lieu tuong ung voi tung cot tren trang in
        'Column 1 - 2 - 3 (Field: STT)
        Dim colSTT As DataColumn
        colSTT = New DataColumn("STT", GetType(String))
        myTableCot1.Columns.Add(colSTT)
        colSTT = New DataColumn("STT", GetType(String))
        myTableCot2.Columns.Add(colSTT)
        colSTT = New DataColumn("STT", GetType(String))
        myTableCot3.Columns.Add(colSTT)

        'Column 1 - 2 - 3 (Field: Ma_E1)
        Dim colMa_E1 As DataColumn
        colMa_E1 = New DataColumn("Ma_E1", GetType(String))
        myTableCot1.Columns.Add(colMa_E1)
        colMa_E1 = New DataColumn("Ma_E1", GetType(String))
        myTableCot2.Columns.Add(colMa_E1)
        colMa_E1 = New DataColumn("Ma_E1", GetType(String))
        myTableCot3.Columns.Add(colMa_E1)

        'Column 1 - 2 - 3 (Field: Tui_So)
        Dim colHuong_Chuyen As DataColumn
        colHuong_Chuyen = New DataColumn("Huong_Chuyen", GetType(String))
        myTableCot1.Columns.Add(colHuong_Chuyen)
        colHuong_Chuyen = New DataColumn("Huong_Chuyen", GetType(String))
        myTableCot2.Columns.Add(colHuong_Chuyen)
        colHuong_Chuyen = New DataColumn("Huong_Chuyen", GetType(String))
        myTableCot3.Columns.Add(colHuong_Chuyen)

        'All
        Dim colALL As DataColumn
        colALL = New DataColumn("STT_Cot_1", GetType(Integer))
        myTableAll.Columns.Add(colALL)
        colALL = New DataColumn("Ma_E1_Cot_1", GetType(String))
        myTableAll.Columns.Add(colALL)
        colALL = New DataColumn("Huong_Chuyen_Cot_1", GetType(String))
        myTableAll.Columns.Add(colALL)

        colALL = New DataColumn("STT_Cot_2", GetType(Integer))
        myTableAll.Columns.Add(colALL)
        colALL = New DataColumn("Ma_E1_Cot_2", GetType(String))
        myTableAll.Columns.Add(colALL)
        colALL = New DataColumn("Huong_Chuyen_Cot_2", GetType(String))
        myTableAll.Columns.Add(colALL)

        colALL = New DataColumn("STT_Cot_3", GetType(Integer))
        myTableAll.Columns.Add(colALL)
        colALL = New DataColumn("Ma_E1_Cot_3", GetType(String))
        myTableAll.Columns.Add(colALL)
        colALL = New DataColumn("Huong_Chuyen_Cot_3", GetType(String))
        myTableAll.Columns.Add(colALL)

        'Bat dau phan xu ly dan trang in
        Dim i, j, k As Integer      'i: index of all data  ;  j: index of only data per page  ;  k: index of colume
        Dim myRowCol As DataRow
        Dim myRowCol1 As DataRow
        Dim myRowCol2 As DataRow
        Dim myRowCol3 As DataRow
        Dim myRowColALL As DataRow
        Dim myPageTotal As Integer
        Dim myRowPerPage As Integer
        Dim mySoDongCon As Integer
        Dim mySoDongCan As Integer

        Const MaxRowPerPage As Integer = 30   'So dong toi da tren 1 trang in        
        'Lay tong so dong du lieu
        pTong_So_BP = myTable.Rows.Count
        'Lay tong so dong du lieu toi da tren 1 trang in
        myRowPerPage = MaxRowPerPage * 3
        'Tinh tong so trang can in
        If ((pTong_So_BP Mod myRowPerPage) <> 0) Then
            myPageTotal = pTong_So_BP \ myRowPerPage + 1
        Else
            myPageTotal = pTong_So_BP \ myRowPerPage
        End If
        'Khoi tao gia tri ban dau
        mySoDongCon = pTong_So_BP
        j = 1
        'Duyet Data
        For i = 0 To pTong_So_BP - 1
            'Tinh toan so dong can in va so dong con lai
            If j = 1 Then
                If mySoDongCon > myRowPerPage Then
                    mySoDongCan = MaxRowPerPage
                    mySoDongCon = mySoDongCon - myRowPerPage
                Else
                    If ((mySoDongCon Mod 3) <> 0) Then
                        mySoDongCan = mySoDongCon \ 3 + 1
                    Else
                        mySoDongCan = mySoDongCon \ 3
                    End If
                End If
            End If
            'Input data into table
            'Kiem tra xem se ghi vao Colunm nao
            If (j < (mySoDongCan * 1 + 1)) Then 'Col 1
                k = 1
            ElseIf (j < (mySoDongCan * 2 + 1)) Then 'Col 2
                k = 2
            Else  'Col 3
                k = 3
            End If
            Select Case k
                Case 1
                    myRowCol1 = myTableCot1.NewRow()
                    myRowCol1("STT") = (i + 1)
                    myRowCol1("Ma_E1") = myTable.Rows(i).Item("Ma_E1")
                    myRowCol1("Huong_Chuyen") = myTable.Rows(i).Item("Huong_Chuyen")
                    myTableCot1.Rows.Add(myRowCol1)
                Case 2
                    myRowCol2 = myTableCot2.NewRow()
                    myRowCol2("STT") = (i + 1)
                    myRowCol2("Ma_E1") = myTable.Rows(i).Item("Ma_E1")
                    myRowCol2("Huong_Chuyen") = myTable.Rows(i).Item("Huong_Chuyen")
                    myTableCot2.Rows.Add(myRowCol2)
                Case 3
                    myRowCol3 = myTableCot3.NewRow()
                    myRowCol3("STT") = (i + 1)
                    myRowCol3("Ma_E1") = myTable.Rows(i).Item("Ma_E1")
                    myRowCol3("Huong_Chuyen") = myTable.Rows(i).Item("Huong_Chuyen")
                    myTableCot3.Rows.Add(myRowCol3)
            End Select
            'Kiem tra het trang
            If j = mySoDongCan * 3 Then
                j = 1
            Else
                j = j + 1
            End If
        Next

        'Doc du lieu tu 3 bang va ghi vao bang ALL
        For i = 0 To myTableCot1.Rows.Count - 1
            'New Row
            myRowColALL = myTableAll.NewRow()

            'Cot 1
            myRowColALL("STT_Cot_1") = myTableCot1.Rows(i).Item("STT")
            myRowColALL("Ma_E1_Cot_1") = myTableCot1.Rows(i).Item("Ma_E1")
            myRowColALL("Huong_Chuyen_Cot_1") = myTableCot1.Rows(i).Item("Huong_Chuyen")

            'Cot 2
            If i <= myTableCot2.Rows.Count - 1 Then
                myRowColALL("STT_Cot_2") = myTableCot2.Rows(i).Item("STT")
                myRowColALL("Ma_E1_Cot_2") = myTableCot2.Rows(i).Item("Ma_E1")
                myRowColALL("Huong_Chuyen_Cot_2") = myTableCot2.Rows(i).Item("Huong_Chuyen")
            Else
                myRowColALL("STT_Cot_2") = 0
                myRowColALL("Ma_E1_Cot_2") = " "
                myRowColALL("Huong_Chuyen_Cot_2") = " "
            End If

            'Cot 3
            If i <= myTableCot3.Rows.Count - 1 Then
                myRowColALL("STT_Cot_3") = myTableCot3.Rows(i).Item("STT")
                myRowColALL("Ma_E1_Cot_3") = myTableCot3.Rows(i).Item("Ma_E1")
                myRowColALL("Huong_Chuyen_Cot_3") = myTableCot3.Rows(i).Item("Huong_Chuyen")
            Else
                myRowColALL("STT_Cot_3") = 0
                myRowColALL("Ma_E1_Cot_3") = " "
                myRowColALL("Huong_Chuyen_Cot_3") = " "
            End If

            'Executive New Row
            myTableAll.Rows.Add(myRowColALL)
        Next i

        pvCollection.Clear()
        _pThamSo.Value = pTong_So_BP
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("pTong_So_BP").ApplyCurrentValues(pvCollection)

        If optTai_Lieu.Checked Then
            pTen_Bao_Cao = "BẢN KÊ TÀI LIỆU ĐẾN VÀ ĐI EMS QUỐC TẾ"
        ElseIf optHang_Hoa.Checked Then
            pTen_Bao_Cao = "BẢN KÊ HÀNG HÓA ĐẾN EMS QUỐC TẾ"
        Else
            pTen_Bao_Cao = "BẢN KÊ HÀNG HÓA CHUYỂN TIẾP ĐI TPHCM"
        End If
        pvCollection.Clear()
        _pThamSo.Value = pTen_Bao_Cao
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("pTen_Bao_Cao").ApplyCurrentValues(pvCollection)

        pBuu_Cuc_Khai_Thac = GBuu_Cuc_Khai_Thac & " - " & GTen_Buu_Cuc_Khai_Thac
        pvCollection.Clear()
        _pThamSo.Value = pBuu_Cuc_Khai_Thac
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("pBuu_Cuc_Khai_Thac").ApplyCurrentValues(pvCollection)

        pNgay_Khai_Thac = myHam_Dung_Chung.ConvertIntToVNDateType(Ngay_Khai_Thac)
        pvCollection.Clear()
        _pThamSo.Value = pNgay_Khai_Thac
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("pNgay_Khai_Thac").ApplyCurrentValues(pvCollection)

        pNgay_Thang_Nam = "Trung tâm KTQT, " & myHam_Dung_Chung.ConvertIntToDate_VN(myHam_Dung_Chung.ConvertDateToInt(Now.Date))
        pvCollection.Clear()
        _pThamSo.Value = pNgay_Thang_Nam
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("pNgay_Thang_Nam").ApplyCurrentValues(pvCollection)

        Dim myNguoi_Dung As New Nguoi_Dung(GConnectionString)
        pTen_Nguoi_Dung = myNguoi_Dung.Lay(Gid_Nguoi_Dung).Ho_Ten
        pvCollection.Clear()
        _pThamSo.Value = pTen_Nguoi_Dung
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("pTen_Nguoi_Dung").ApplyCurrentValues(pvCollection)


        'Dua vao Dataset
        myDataSet.Tables.Add(myTableAll.Copy)

        'Gan DataSource cho report
        rptVIEW.SetDataSource(myDataSet)
        'Truyen rptCN38 vao rptView cua form viewReport
        FrmView.CrystalReportViewer1.ReportSource = rptVIEW
        Cursor.Current = Cursors.Default
        If isPreview = True Then
            'Xem tren man hinh
            FrmView.ShowDialog()
        Else
            'Dua ra may in
            rptVIEW.PrintToPrinter(1, True, 0, 0)
        End If
    End Sub
#End Region

End Class

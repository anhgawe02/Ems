Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Math
Imports Ems_International_Logic.EMS
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Module Cmd_Ban_ke_E2_Di_Receptacle
    Private Const nLeftMar As String = "   "   'Dieu chinh toa do trang in
#Region "Ban_Ke_E2_Di_Receptacle "
    Public Sub Ban_Ke_E2_Di_Receptacle(ByVal Id_E2 As String, ByVal Preview As Boolean, ByVal Soban As Integer, ByVal quocte As Integer, ByVal IsNDD_EMS As Boolean)
        Dim myE2_Di As New E2_Di(GConnectionString)
        Dim myE1_Di As New E1_Di(GConnectionString)
        Dim myE2_Di_ChiTiet As New E2_Di_Chi_Tiet
        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue
        Dim myNguoi_Dung As New Nguoi_Dung(GConnectionString)
        Dim FrmView As New FrmViewReports
        Dim rptE2_Receptacle As New RptE2_Di_Receptacle
        Dim myHamdungchung As New Ham_Dung_Chung
        Dim myData As DataSet
        Dim myData_SHCT As DataSet
        Dim myDataTK As DataSet
        Dim myChuyen_Thu_Di As New Chuyen_Thu_Di(GConnectionString)
        Dim myMa_Bc_Khai_Thac As New Ma_Bc_Khai_Thac(GConnectionString)
        Dim myDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)
        Dim myNumber As New ConvertNumberToString
        Dim myDuong_Thu_Di As New Duong_Thu_Di(GConnectionString)
        Dim myMa_Nuoc As New Ma_Nuoc(GConnectionString)
        Dim Id_Duong_Thu As String = myE2_Di.Lay(Id_E2).Id_Duong_Thu
        Dim Phan_Loai As Integer = myDuong_Thu_Di.Lay(Id_Duong_Thu).Id_Phan_Loai
        Dim Ma_Bc_Khai_Thac As Integer = myDuong_Thu_Di.Lay(Id_Duong_Thu).Ma_Bc_Khai_Thac
        Dim Id_Chuyen_Thu As String = myE2_Di.Lay(Id_E2).Id_Chuyen_Thu
        Dim Tong_So_BP_CT As Integer = myChuyen_Thu_Di.Lay(Id_Chuyen_Thu).Tong_So_BP

        Dim Ma_Bc As Integer = myDuong_Thu_Di.Lay(Id_Duong_Thu).Ma_Bc
        Dim myCN38 As New CN38(GConnectionString)
        Dim MyDanhmucduongbay As New Danh_Muc_Duong_Bay(GConnectionString)
        'Dim Ngay_Thang As Integer = myCN38.Lay((myE2_Di.Lay(Id_E2).Id_Chuyen_Thu)).Ngay_Bay
        Dim Ngay_Thang As Integer = myE2_Di.Lay(Id_E2).Ngay_Dong
        Dim i, j, k, T, BP, Tong_HH As Integer
        Dim Gio As String = myHamdungchung.ConvertIntToTime(myE2_Di.Lay(Id_E2).Gio_Dong)
        Dim F As Boolean = myE2_Di.Lay(Id_E2).Tui_F
        Dim Tong_So_BP As Integer = myE2_Di.Lay(Id_E2).Tong_So_BP
        Dim Nuoc_Nhan As String
        Dim Despatch_ID, Chuyen_bay, Ten_Duong_Thu As String
        Dim my_Ma_Bc_Duong_Thu_Di As Integer = myDuong_Thu_Di.Lay(Id_Duong_Thu).Ma_Bc
        Dim IPMC As String = myDanh_Muc_BC.Lay(my_Ma_Bc_Duong_Thu_Di).IPMC
        Dim Ma_Nuoc As String = myDanh_Muc_BC.Lay(my_Ma_Bc_Duong_Thu_Di).Ma_Nc
        Dim Ten_Nuoc As String = myMa_Nuoc.Lay(Ma_Nuoc).Ten_Nuoc
        Dim Ma_Bc_Goc As Integer
        Dim Ma_Mc_Tra As Integer
        Dim So_Luong_M, So_Luong_D As Integer
        Dim Khoi_Luong_BP As String = "(" & Convert.ToString(Convert.ToInt32(myE2_Di.Lay(Id_E2).Khoi_Luong_BP) / 1000) + "  Kg)"
        Dim Khoi_Luong_VoTui As Integer = myE2_Di.Lay(Id_E2).Khoi_Luong_Vo_Tui
        Dim Tong_Khoi_LuongBanKe As String = Convert.ToString(Convert.ToInt32(myE2_Di.Lay(Id_E2).Khoi_Luong_BP + myE2_Di.Lay(Id_E2).Khoi_Luong_Vo_Tui) / 1000)
        Dim Loai_D_M As String = ""
        So_Luong_D = myE1_Di.Danh_Sach_E1_Loai_D_M(Id_E2).So_Luong_D
        So_Luong_M = myE1_Di.Danh_Sach_E1_Loai_D_M(Id_E2).So_Luong_M
        If (So_Luong_D > 0) And (So_Luong_M > 0) Then
            Loai_D_M = Convert.ToString(So_Luong_D) + "D : " + Convert.ToString(So_Luong_M) + "M"
        ElseIf (So_Luong_D = 0) Then
            Loai_D_M = Convert.ToString(So_Luong_M) + "M"

        ElseIf (So_Luong_M = 0) Then
            Loai_D_M = Convert.ToString(So_Luong_D) + "D"
        End If


        myNumber.Number = Tong_So_BP
        T = 0
        BP = 0
        Tong_HH = 0
        ''Tên bưu cục khai thác

        _pThamSo.Value = myMa_Bc_Khai_Thac.Lay(Ma_Bc_Khai_Thac).Ten_Bc_Khai_Thac
        pvCollection.Add(_pThamSo)
        rptE2_Receptacle.DataDefinition.ParameterFields("Ten_Bc_Khai_Thac").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        ''đến/To Ma_Bc
        _pThamSo.Value = myDuong_Thu_Di.Lay(Id_Duong_Thu).Ten_Duong_Thu
        pvCollection.Add(_pThamSo)
        rptE2_Receptacle.DataDefinition.ParameterFields("Ten_Duong_Thu").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()
        ''Chuyến thư
        _pThamSo.Value = myChuyen_Thu_Di.Lay(Id_Chuyen_Thu).So_Chuyen_Thu
        pvCollection.Add(_pThamSo)
        rptE2_Receptacle.DataDefinition.ParameterFields("Chuyen_Thu").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        ''Ngày Tháng
        _pThamSo.Value = myHamdungchung.ConvertIntToVNDateType(Ngay_Thang)
        pvCollection.Add(_pThamSo)
        rptE2_Receptacle.DataDefinition.ParameterFields("Ngay_Thang").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        ''Tổng Số BP        
        Dim Tong_So_BP_chu As String = CStr(Tong_So_BP) & " : " & Loai_D_M & " " & Khoi_Luong_BP
        _pThamSo.Value = Tong_So_BP_chu
        pvCollection.Add(_pThamSo)
        rptE2_Receptacle.DataDefinition.ParameterFields("Tong_So_BP").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        ''NDD  
        Dim NDD_EMS As String = "" 'CStr(Tong_So_BP)
        NDD_EMS = IIf(IsNDD_EMS, "NDD", "")
        _pThamSo.Value = NDD_EMS
        pvCollection.Add(_pThamSo)
        rptE2_Receptacle.DataDefinition.ParameterFields("NDD_EMS").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        myData = myE2_Di.E2_Di_Ban_Ke_Receptacle(Id_E2)
        myData.Tables(0).TableName = "E2_Di_Ban_Ke_Receptacle"

        Dim myTable As New DataTable
        If quocte = 1 Then
            myData_SHCT = myE2_Di.So_hieu_chuyen_thu(Id_E2)
            myData_SHCT.Tables(0).TableName = "So_hieu_chuyen_thu"
            myData.Tables.Add(myData_SHCT.Tables(0).Copy)
            myTable = myData_SHCT.Tables(0)
        End If


        ''Despatch_ID
        Despatch_ID = Convert.ToString(myTable.Rows(0).Item(0)) + Convert.ToString(myTable.Rows(0).Item(1)) + _
                      "A" + Convert.ToString(myTable.Rows(0).Item(4)) + Convert.ToString(myTable.Rows(0).Item(2)) + _
                       Convert.ToString(Convert.ToInt32(myTable.Rows(0).Item(3)).ToString("0000"))
        _pThamSo.Value = Despatch_ID
        pvCollection.Add(_pThamSo)
        If quocte = 1 Then
            rptE2_Receptacle.DataDefinition.ParameterFields("Despatch_ID").ApplyCurrentValues(pvCollection)
        End If
        pvCollection.Clear()
        'Chuyen_bay
        'Chuyen_bay = nvert.ToString(myTable.Rows(0).Item(6))
        Chuyen_bay = MyDanhmucduongbay.Lay(myCN38.Lay(Id_Chuyen_Thu).Id_Duong_Bay).So_hieu
        _pThamSo.Value = Chuyen_bay
        pvCollection.Add(_pThamSo)
        If quocte = 1 Then
            rptE2_Receptacle.DataDefinition.ParameterFields("Chuyen_bay").ApplyCurrentValues(pvCollection)
        End If
        pvCollection.Clear()

        ''Ten_Nuoc
        _pThamSo.Value = Ten_Nuoc
        pvCollection.Add(_pThamSo)
        If quocte = 1 Then
            rptE2_Receptacle.DataDefinition.ParameterFields("Ten_Nuoc").ApplyCurrentValues(pvCollection)
        End If
        pvCollection.Clear()

        'Tong_Khoi_LuongBanKe()
        'Dim Tong_Khoi_LuongBanKe As String = Convert.ToString(Convert.ToInt32(myE2_Di.Lay(Id_E2).Khoi_Luong_BP + myE2_Di.Lay(Id_E2).Khoi_Luong_Vo_Tui) / 1000)
        _pThamSo.Value = Tong_Khoi_LuongBanKe
        pvCollection.Add(_pThamSo)
        If quocte = 1 Then
            rptE2_Receptacle.DataDefinition.ParameterFields("Tong_Khoi_LuongBanKe").ApplyCurrentValues(pvCollection)
        End If
        pvCollection.Clear()




        rptE2_Receptacle.SetDataSource(myData)
        FrmView.CrystalReportViewer1.ReportSource = rptE2_Receptacle
        Cursor.Current = Cursors.Default
        If Preview = True Then
            FrmView.ShowDialog()
        Else
            rptE2_Receptacle.PrintToPrinter(Soban, True, 0, 0)
        End If
    End Sub
#End Region
#Region "Ban_Ke_E2_Di_Receptacle_tmp "
    Public Sub Ban_Ke_E2_Di_tmp(ByVal Id_E2 As String, ByVal Preview As Boolean, ByVal Soban As Integer, ByVal quocte As Integer)
        Dim myChuyenThuDi As New Chuyen_Thu_Di(GConnectionString)
        Dim myE2_Di As New E2_Di(GConnectionString)
        Dim myE1_Di As New E1_Di(GConnectionString)
        Dim FrmView As New FrmViewReports
        Dim Id_Chuyen_Thu As String = myE2_Di.Lay(Id_E2).Id_Chuyen_Thu

        Dim rptVIEW As New RptE2_Di_Receptacle_tmp
        Dim myDataSet As New DataSet
        Dim myTable1 As New DataTable
        Dim myTable2 As New DataTable
        Dim mydata As New DataTable

        Dim idx As Integer
        Dim So_Luong_D As Integer = 0
        Dim So_Luong_M As Integer = 0
        Dim Tong_So_BP As String

        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue
        'Lay du lieu
        myTable1 = myE2_Di.E2_Di_Ban_Ke_Receptacle(Id_E2).Tables(0)
        myTable1.TableName = "E2_Di_Ban_Ke_Receptacle"

        myTable2 = myE2_Di.E2_Di_Ban_Ke_Receptacle_header(Id_E2, Id_Chuyen_Thu).Tables(0)
        myTable2.TableName = "E2_Di_Ban_Ke_Receptacle_header"
        'Tong_KLBP = myTable1.Rows(0).Item("Tong_KLBP") / 1000
        Dim Tong_KLBP As Double = Convert.ToDouble(myTable2.Rows(0).Item("Tong_Khoi_Luong_Bp")) / 1000
        Dim Loai_D_M As String = ""
        So_Luong_D = myE1_Di.Danh_Sach_E1_Loai_D_M(Id_E2).So_Luong_D
        So_Luong_M = myE1_Di.Danh_Sach_E1_Loai_D_M(Id_E2).So_Luong_M
        If (So_Luong_D > 0) And (So_Luong_M > 0) Then
            Loai_D_M = Convert.ToString(So_Luong_D) + "D : " + Convert.ToString(So_Luong_M) + "M"
        ElseIf (So_Luong_D = 0) Then
            Loai_D_M = Convert.ToString(So_Luong_M) + "M"
        ElseIf (So_Luong_M = 0) Then
            Loai_D_M = Convert.ToString(So_Luong_D) + "D"
        End If
        Tong_So_BP = (So_Luong_D + So_Luong_M) & " : " & Loai_D_M & " (" & Tong_KLBP.ToString("##0.##0") & " kg)"
        pvCollection.Clear()
        _pThamSo.Value = Tong_So_BP
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("Tong_So_BP").ApplyCurrentValues(pvCollection)

        'Dua vao Dataset
        myDataSet.Tables.Add(myTable1.Copy)
        myDataSet.Tables.Add(myTable2.Copy)

        'Gan DataSource cho report
        rptVIEW.SetDataSource(myDataSet)
        'Truyen rptCN38 vao rptView cua form viewReport
        FrmView.CrystalReportViewer1.ReportSource = rptVIEW
        Cursor.Current = Cursors.Default
        If Preview = True Then
            'Xem tren man hinh
            FrmView.ShowDialog()
        Else
            'Dua ra may in
            rptVIEW.PrintToPrinter(Soban, True, 0, 0)
        End If
    End Sub
#End Region
#Region "Bản Kê E2 Đến Khai thác"
    Public Sub Ban_Ke_E2_Den_KhaiThac(ByVal Id_E2 As String, ByVal Preview As Boolean, ByVal Soban As Integer)
        Dim myE2_Den As New E2_Den(GConnectionString)
        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue
        Dim FrmView As New FrmViewReports
        Dim rptE2_Ban_ke As New RptE2_Den_Ban_Ke_KT
        Dim myHamdungchung As New Ham_Dung_Chung
        Dim myData As DataSet
        Dim Id_Chuyen_Thu As String = myE2_Den.Lay(Id_E2).Id_Chuyen_Thu
        Dim mytable2 As New dataTable("E2_Den_Ban_Ke_KhaiThac_header")
        mytable2 = myE2_Den.E2_Den_Ban_Ke_KhaiThac_header(Id_E2, Id_Chuyen_Thu).Tables(0)
        Dim F As Boolean = mytable2.Rows(0).Item("Tui_F")
        Dim ngay_dong As Integer = mytable2.Rows(0).Item("Ngay_Dong")
        ''Ngày Tháng
        _pThamSo.Value = myHamdungchung.ConvertIntToVNDateType(ngay_dong)
        pvCollection.Add(_pThamSo)
        rptE2_Ban_ke.DataDefinition.ParameterFields("ngay_dong").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()
        ''Tieu_De
        _pThamSo.Value = "CÁC BƯU GỬI XÁC NHẬN ĐẾN"
        pvCollection.Add(_pThamSo)
        rptE2_Ban_ke.DataDefinition.ParameterFields("Tieu_De").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()
        ''mã bưu cục khai thác
        _pThamSo.Value = Convert.ToString(mytable2.Rows(0).Item("Ma_Bc_Khai_Thac")) + "-" + Convert.ToString(mytable2.Rows(0).Item("Ten_bc_khai_thac"))
        pvCollection.Add(_pThamSo)
        rptE2_Ban_ke.DataDefinition.ParameterFields("Ma_Bc_Khai_Thac").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        ''Từ/From
        _pThamSo.Value = Convert.ToString(mytable2.Rows(0).Item("Ma_Bc")) + "-" + Convert.ToString(mytable2.Rows(0).Item("Ten_Bc"))
        pvCollection.Add(_pThamSo)
        rptE2_Ban_ke.DataDefinition.ParameterFields("TenBC_KT").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        ''Đến/To

        _pThamSo.Value = Convert.ToString(mytable2.Rows(0).Item("Ma_Bc_Khai_Thac")) + "-" + Convert.ToString(mytable2.Rows(0).Item("Ten_bc_khai_thac"))
        pvCollection.Add(_pThamSo)
        rptE2_Ban_ke.DataDefinition.ParameterFields("ma_bc").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()


        Dim mytable1 As New dataTable("E2_Den_Ban_Ke_KhaiThac_TongKet_F")
        mytable1 = myE2_Den.E2_Den_Ban_Ke_KhaiThac_TongKet_F(Id_Chuyen_Thu).Tables(0)
        If F = True Then
            Dim tuiso, tong_sl, sl1, sl2, k As Integer
            Dim Khoiluong, Khoi_Luong1, Khoi_Luong2, Hoa_Hong1, Hoa_Hong2 As Integer
            Dim TuiF As Boolean
            Dim Tong_Ket_CT As String = ""
            For k = 0 To mytable1.Rows.Count - 1
                tuiso = mytable1.Rows(k).Item("Tui_So")
                sl1 = mytable1.Rows(k).Item("San_Luong1")
                sl2 = mytable1.Rows(k).Item("San_Luong2")
                tong_sl = sl1 + sl2
                Khoi_Luong1 = mytable1.Rows(k).Item("Khoi_Luong1") 'IIf(mytable1.Rows(k).Item("Khoi_Luong1") = null, 0, mytable1.Rows(k).Item("Khoi_Luong1"))
                Khoi_Luong2 = mytable1.Rows(k).Item("Khoi_Luong2")
                Khoiluong = Khoi_Luong1 + Khoi_Luong2
                Hoa_Hong1 = mytable1.Rows(k).Item("Hoa_Hong1")
                Hoa_Hong2 = mytable1.Rows(k).Item("Hoa_Hong2")
                TuiF = mytable1.Rows(k).Item("Tui_F")

                Tong_Ket_CT += nLeftMar & LSet(tuiso, 6) & LSet(tong_sl, 7) & LSet(Khoiluong.ToString("##0.000"), 11) & _
                LSet(sl1, 7) & LSet(Khoi_Luong1.ToString("##0.000"), 7) & LSet(Hoa_Hong1, 7) & Space(1) & _
                LSet(sl2, 7) & LSet(Khoi_Luong2.ToString("##0.000"), 7) & LSet(Hoa_Hong2, 7) & RSet(IIf(TuiF, "1", "0"), 2) + vbNewLine
            Next
            _pThamSo.Value = Tong_Ket_CT
            pvCollection.Add(_pThamSo)
            rptE2_Ban_ke.DataDefinition.ParameterFields("Tong_Ket_Chuyen_Thu").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            ''Tổng kết chuyến thư.        
            Dim myTable_TK As New dataTable("E2_Den_Ban_Ke_TK")
            'Tao ra cac cot cua bang nay
            Dim col As DataColumn = New DataColumn("Tong_Ket_F", GetType(String))
            myTable_TK.Columns.Add(col)
            Dim row As DataRow = myTable_TK.NewRow()
            row("Tong_Ket_F") = Tong_Ket_CT
            myTable_TK.Rows.Add(row)

            Dim tuyen As String
            tuyen = myTable_TK.Rows(0).Item("Tong_Ket_F")

        Else
            _pThamSo.Value = ""
            pvCollection.Add(_pThamSo)
            rptE2_Ban_ke.DataDefinition.ParameterFields("Chan_Trang_Tui_F").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = ""
            pvCollection.Add(_pThamSo)
            rptE2_Ban_ke.DataDefinition.ParameterFields("Tong_Ket_Chuyen_Thu").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            ''Tổng kết chuyến thư.        
            Dim myTable_TK As New dataTable("E2_Den_Ban_Ke_TK")
            'Tao ra cac cot cua bang nay
            Dim col As DataColumn = New DataColumn("Tong_Ket_F", GetType(String))
            myTable_TK.Columns.Add(col)
            Dim row As DataRow = myTable_TK.NewRow()
            row("Tong_Ket_F") = "chan ngeh"
            myTable_TK.Rows.Add(row)
            myTable_TK.TableName = "E2_Den_Ban_Ke_TK"
            Dim tuyen As String
            tuyen = myTable_TK.Rows(0).Item("Tong_Ket_F")
        End If
        Dim dataTable As New dataTable("Tong_Ket")
        myData = myE2_Den.E2_Den_Ban_Ke(Id_E2)
        'myData.Tables.Add(mytable1.Copy)
        myData.Tables.Add(mytable2.Copy)
        myData.Tables.Add(dataTable.Copy)
        rptE2_Ban_ke.SetDataSource(myData)
        FrmView.CrystalReportViewer1.ReportSource = rptE2_Ban_ke
        Cursor.Current = Cursors.Default
        If Preview = True Then
            FrmView.ShowDialog()
        Else
            rptE2_Ban_ke.PrintToPrinter(Soban, True, 0, 0)
        End If
    End Sub
#End Region

#Region "Bản Kê E2 Đi Khai thác"
    Public Sub Ban_Ke_E2_Di_KhaiThac(ByVal Id_E2 As String, ByVal Preview As Boolean, ByVal Soban As Integer)
        Dim myE2_Di As New E2_Di(GConnectionString)
        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue
        Dim FrmView As New FrmViewReports
        Dim rptE2_Ban_ke As New RptE2_Den_Ban_Ke_KT
        Dim myHamdungchung As New Ham_Dung_Chung
        Dim myData As DataSet
        Dim Id_Chuyen_Thu As String = myE2_Di.Lay(Id_E2).Id_Chuyen_Thu
        Dim mytable2 As New dataTable("E2_Den_Ban_Ke_KhaiThac_header")
        mytable2 = myE2_Di.E2_Di_Ban_Ke_Khai_Thac_header(Id_E2, Id_Chuyen_Thu).Tables(0)
        Dim F As Boolean = mytable2.Rows(0).Item("Tui_F")
        Dim ngay_dong As Integer = mytable2.Rows(0).Item("Ngay_Dong")
        ''Ngày Tháng
        _pThamSo.Value = myHamdungchung.ConvertIntToVNDateType(ngay_dong)
        pvCollection.Add(_pThamSo)
        rptE2_Ban_ke.DataDefinition.ParameterFields("ngay_dong").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()
        ''Tieu_De
        _pThamSo.Value = "CÁC BƯU GỬI ĐƯỢC GỬI ĐI/ ITEMS TO BE SENT"
        pvCollection.Add(_pThamSo)
        rptE2_Ban_ke.DataDefinition.ParameterFields("Tieu_De").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        ''Từ/From
        _pThamSo.Value = Convert.ToString(mytable2.Rows(0).Item("Ten_bc_khai_thac"))
        pvCollection.Add(_pThamSo)
        rptE2_Ban_ke.DataDefinition.ParameterFields("TenBC_KT").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        ''Đến/To

        _pThamSo.Value = Convert.ToString(mytable2.Rows(0).Item("Ten_Bc"))
        pvCollection.Add(_pThamSo)
        rptE2_Ban_ke.DataDefinition.ParameterFields("ma_bc").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()


        ''Bưu cục khai thác
        _pThamSo.Value = Convert.ToString(mytable2.Rows(0).Item("Ma_Bc_Khai_Thac")) + "-" + Convert.ToString(mytable2.Rows(0).Item("Ten_bc_khai_thac"))
        pvCollection.Add(_pThamSo)
        rptE2_Ban_ke.DataDefinition.ParameterFields("Ma_Bc_Khai_Thac").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()



        Dim mytable1 As New dataTable("E2_Den_Ban_Ke_KhaiThac_TongKet_F")
        mytable1 = myE2_Di.E2_Di_Ban_Ke_KhaiThac_TongKet_F(Id_Chuyen_Thu).Tables(0)
        If F = True Then
            'Dim KETLUAN As String = ""
            'KETLUAN = nLeftMar & padC("BẢN TỔNG KẾT CHUYẾN THƯ", 60) & vbNewLine & _
            '                       nLeftMar & "BƯU CỤC GỬI:   " & mytable2.Rows(0).Item("ma_bc_khai_thac") & vbNewLine & _
            '                       nLeftMar & "BƯU CỤC NHẬN:   " & mytable2.Rows(0).Item("ma_bc") & vbNewLine & _
            '                       nLeftMar & "CHUYỂN THƯ:   " & mytable2.Rows(0).Item("so_chuyen_thu") & vbNewLine & vbNewLine & _
            '                       nLeftMar & LSet("TUISO", 6) & LSet("TONGSO", 7) & LSet("KHOILUONG", 9) & padC("BUU PHAM > 5KG", 21) & Space(1) & padC("BUU PHAM < 5KG", 21) & vbNewLine & _
            '                       nLeftMar & Space(34) & LSet("SL", 7) & LSet("KL", 7) & LSet("CP", 7) & Space(1) & LSet("SL", 7) & LSet("KL", 7) & LSet("CP", 7)
            '_pThamSo.Value = KETLUAN
            'pvCollection.Add(_pThamSo)
            'rptE2_Ban_ke.DataDefinition.ParameterFields("Chan_Trang_Tui_F").ApplyCurrentValues(pvCollection)
            'pvCollection.Clear()

            Dim tuiso, tong_sl, sl1, sl2, k As Integer
            Dim Khoiluong, Khoi_Luong1, Khoi_Luong2, Hoa_Hong1, Hoa_Hong2 As Integer
            Dim TuiF As Boolean
            Dim Tong_Ket_CT As String = ""
            For k = 0 To mytable1.Rows.Count - 1
                tuiso = mytable1.Rows(k).Item("Tui_So")
                sl1 = mytable1.Rows(k).Item("San_Luong1")
                sl2 = mytable1.Rows(k).Item("San_Luong2")
                tong_sl = sl1 + sl2
                Khoi_Luong1 = mytable1.Rows(k).Item("Khoi_Luong1") 'IIf(mytable1.Rows(k).Item("Khoi_Luong1") = null, 0, mytable1.Rows(k).Item("Khoi_Luong1"))
                Khoi_Luong2 = mytable1.Rows(k).Item("Khoi_Luong2")
                Khoiluong = Khoi_Luong1 + Khoi_Luong2
                Hoa_Hong1 = mytable1.Rows(k).Item("Hoa_Hong1")
                Hoa_Hong2 = mytable1.Rows(k).Item("Hoa_Hong2")
                TuiF = mytable1.Rows(k).Item("Tui_F")

                Tong_Ket_CT += nLeftMar & LSet(tuiso, 6) & LSet(tong_sl, 7) & LSet(Khoiluong.ToString("##0.000"), 11) & _
                LSet(sl1, 7) & LSet(Khoi_Luong1.ToString("##0.000"), 7) & LSet(Hoa_Hong1, 7) & Space(1) & _
                LSet(sl2, 7) & LSet(Khoi_Luong2.ToString("##0.000"), 7) & LSet(Hoa_Hong2, 7) & RSet(IIf(TuiF, "1", "0"), 2) + vbNewLine
            Next
            _pThamSo.Value = "Tong_Ket_CT"
            pvCollection.Add(_pThamSo)
            rptE2_Ban_ke.DataDefinition.ParameterFields("Tong_Ket_Chuyen_Thu").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            ''Tổng kết chuyến thư.        
            Dim myTable_TK As New dataTable("E2_Den_Ban_Ke_TK")
            'Tao ra cac cot cua bang nay
            Dim col As DataColumn = New DataColumn("Tong_Ket_F", GetType(String))
            myTable_TK.Columns.Add(col)
            Dim row As DataRow = myTable_TK.NewRow()
            row("Tong_Ket_F") = Tong_Ket_CT
            myTable_TK.Rows.Add(row)

            Dim tuyen As String
            tuyen = myTable_TK.Rows(0).Item("Tong_Ket_F")

        Else
            _pThamSo.Value = ""
            pvCollection.Add(_pThamSo)
            rptE2_Ban_ke.DataDefinition.ParameterFields("Chan_Trang_Tui_F").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = ""
            pvCollection.Add(_pThamSo)
            rptE2_Ban_ke.DataDefinition.ParameterFields("Tong_Ket_Chuyen_Thu").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            ''Tổng kết chuyến thư.        
            Dim myTable_TK As New dataTable("E2_Den_Ban_Ke_TK")
            'Tao ra cac cot cua bang nay
            Dim col As DataColumn = New DataColumn("Tong_Ket_F", GetType(String))
            myTable_TK.Columns.Add(col)
            Dim row As DataRow = myTable_TK.NewRow()
            row("Tong_Ket_F") = "chan ngeh"
            myTable_TK.Rows.Add(row)
            myTable_TK.TableName = "E2_Den_Ban_Ke_TK"
            Dim tuyen As String
            tuyen = myTable_TK.Rows(0).Item("Tong_Ket_F")
        End If
        Dim dataTable As New dataTable("Tong_Ket")
        myData = myE2_Di.E2_Di_Ban_Ke_KhaiThac(Id_E2)
        'myData.Tables.Add(mytable1.Copy)
        myData.Tables.Add(mytable2.Copy)
        myData.Tables.Add(dataTable.Copy)
        rptE2_Ban_ke.SetDataSource(myData)
        FrmView.CrystalReportViewer1.ReportSource = rptE2_Ban_ke
        Cursor.Current = Cursors.Default
        If Preview = True Then
            FrmView.ShowDialog()
        Else
            rptE2_Ban_ke.PrintToPrinter(Soban, True, 0, 0)
        End If
    End Sub
#End Region

#Region "Bản Kê Báo cáo hải quan"
    Public Sub Ban_Ke_Bao_Cao_Hai_Quan(ByVal Id_Ca As String, ByVal Preview As Boolean)
        Dim myE1_Di As New E1_Di(GConnectionString)
        Dim myCa_San_Xuat As New Ca_San_Xuat(GConnectionString)
        Dim myHamdungchung As New Ham_Dung_Chung
        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue
        Dim FrmView As New FrmViewReports
        Dim rptE1_Bao_Cao_Hai_Quan As New Rpt_HaiQuanBuuDien
        Dim myData As DataSet
        Dim mytable As New DataTable("E1_Bao_Cao_Hai_Quan")
        Try
            mytable = myE1_Di.E1_Di_Bao_Cao_Hai_Quan(Id_Ca).Tables(0)
            ''Ngày Tháng
            '_pThamSo.Value = myHamdungchung.ConvertIntToVNDateType(ngay_dong)
            _pThamSo.Value = myHamdungchung.ConvertIntToVNDateType(myCa_San_Xuat.Lay(Id_Ca).Ngay_Khai_Thac)
            pvCollection.Add(_pThamSo)
            rptE1_Bao_Cao_Hai_Quan.DataDefinition.ParameterFields("Ngay_Khai_Thac").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            '''ca khai thác
            _pThamSo.Value = Right(Id_Ca, 1)
            pvCollection.Add(_pThamSo)
            rptE1_Bao_Cao_Hai_Quan.DataDefinition.ParameterFields("Ca_Khai_Thac").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            '''ca khai thác            
            _pThamSo.Value = GTen_Dang_Nhap
            pvCollection.Add(_pThamSo)
            rptE1_Bao_Cao_Hai_Quan.DataDefinition.ParameterFields("Nhan_Vien").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            rptE1_Bao_Cao_Hai_Quan.SetDataSource(mytable)
            FrmView.CrystalReportViewer1.ReportSource = rptE1_Bao_Cao_Hai_Quan

            Cursor.Current = Cursors.Default
            If Preview = True Then
                FrmView.ShowDialog()
            Else
                rptE1_Bao_Cao_Hai_Quan.PrintToPrinter(1, True, 0, 0)
            End If
        Catch ex As Exception
            CMessageBox.Show("Có lỗi xảy ra " & ex.ToString)
        End Try
    End Sub
#End Region
End Module

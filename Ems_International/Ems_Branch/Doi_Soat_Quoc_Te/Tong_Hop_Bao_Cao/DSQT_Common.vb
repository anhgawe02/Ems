Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports System.Data
Imports System.Data.OracleClient
Imports System.Data.SqlClient
Imports System.Math
Imports Ems_International_Logic.EMS
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Microsoft.Office

Module DSQT_Common
#Region "----------Khai báo biến toàn cục----------"
    Public gDSQT_Menu_Trai As String
    Public gDSQT_Menu_Phai As String
    Public gDSQT_Menu_Don_Vi As String
    Public gDSQT_Menu_Ten_Bao_Cao As String
    Public gDSQT_Menu_Thoi_Gian As String
    Public gDSQT_Menu_Ghi_Chu As String
    Public gDSQT_Menu_Ngay_Thang_Nam As String
    Public gDSQT_Menu_Nguoi_Bao_Cao As String
    Public gDSQT_Menu_Ten_Truong_Don_Vi As String
    Public gDSQT_Menu_Lanh_Dao As String
    Private myHam_Dung_Chung As New Ham_Dung_Chung

#End Region

#Region "Bao_Cao_Doanh_Thu_Tung_Nuoc_Theo_Ngay_Dong"
    Public Function Bao_Cao_Doanh_Thu_Tung_Nuoc_Theo_Ngay_Dong(ByVal mKe_Toan_Cong_Ty As Boolean, ByVal mTat_Ca As Boolean, ByVal mMa_Bc_Khai_Thac As Integer, ByVal mTu_Ngay As Integer, ByVal mDen_Ngay As Integer, ByVal mPreview As Boolean, ByVal mSo_Ban As Integer) As Boolean
        Try
            Dim mDSQT_CN55 As New DSQT_CN55(GConnectionString)
            Dim mDSQT_Danh_Muc_Bc_Khai_Thac As New DSQT_Danh_Muc_Bc_Khai_Thac(GConnectionString)
            Dim mNguoi_Dung As New Nguoi_Dung(GConnectionString)
            Dim FrmView As New Frm_DSQT_ViewReports
            Dim rptVIEW As New rptDSQT_Bao_Cao_Tong_Hop_Doanh_Thu
            Dim myDataSet As New DataSet
            Dim myTable As New DataTable

            Dim pvCollection As New ParameterValues
            Dim _pThamSo As New ParameterDiscreteValue

            'Lay du lieu
            myTable = mDSQT_CN55.DSQT_CN55_Bao_Cao_Doanh_Thu_Tung_Nuoc_Theo_Ngay_Dong(mTat_Ca, mMa_Bc_Khai_Thac, mTu_Ngay, mDen_Ngay).Tables(0)
            If myTable.Rows.Count = 0 Then
                MessageBox.Show("Không có dữ liệu!!!", "Thông báo", MessageBoxButtons.OK)
                Return True
            End If
            'Dat ten table cho phu hop
            myTable.TableName = "Bao_Cao_Doanh_Thu"
            'Dua vao Dataset
            myDataSet.Tables.Add(myTable.Copy)

            'Menu Trai
            gDSQT_Menu_Trai = "Công ty cổ phần Chuyển phát nhanh Bưu điện"
            pvCollection.Clear()
            _pThamSo.Value = gDSQT_Menu_Trai
            pvCollection.Add(_pThamSo)
            rptVIEW.DataDefinition.ParameterFields("pMenu_Trai").ApplyCurrentValues(pvCollection)

            'Tu ngay den ngay
            gDSQT_Menu_Thoi_Gian = "Ngày đóng chuyến thư:  Từ " & Ham_Dung_Chung.ConvertIntToDate_VN(mTu_Ngay) & " Đến " & Ham_Dung_Chung.ConvertIntToDate_VN(mDen_Ngay)
            pvCollection.Clear()
            _pThamSo.Value = gDSQT_Menu_Thoi_Gian
            pvCollection.Add(_pThamSo)
            rptVIEW.DataDefinition.ParameterFields("pMenu_Thoi_Gian").ApplyCurrentValues(pvCollection)

            'Ngay tao bao cao
            gDSQT_Menu_Ngay_Thang_Nam = "Ngày " & Now.Day().ToString("00") & " Tháng " & Now.Month().ToString("00") & " Năm " & Now.Year().ToString("0000")
            pvCollection.Clear()
            _pThamSo.Value = gDSQT_Menu_Ngay_Thang_Nam
            pvCollection.Add(_pThamSo)
            rptVIEW.DataDefinition.ParameterFields("pMenu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)

            'Ten don vi in bao cao (HCM, HA NOI)
            If mKe_Toan_Cong_Ty = True Then   'Báo cáo cho kế toán
                gDSQT_Menu_Don_Vi = "Phòng Tài chính kế toán"
                If mTat_Ca = False Then
                    gDSQT_Menu_Phai = ""
                Else
                    gDSQT_Menu_Phai = mDSQT_Danh_Muc_Bc_Khai_Thac.DSQT_Danh_Muc_Bc_Khai_Thac_Lay(mMa_Bc_Khai_Thac).Ten_Tren_Bao_Cao
                End If
            Else   'báo cáo cho khai thác
                gDSQT_Menu_Don_Vi = mDSQT_Danh_Muc_Bc_Khai_Thac.DSQT_Danh_Muc_Bc_Khai_Thac_Lay(mMa_Bc_Khai_Thac).Ten_Tren_Bao_Cao
                gDSQT_Menu_Phai = ""
            End If
            pvCollection.Clear()
            _pThamSo.Value = gDSQT_Menu_Don_Vi
            pvCollection.Add(_pThamSo)
            rptVIEW.DataDefinition.ParameterFields("pMenu_Don_Vi").ApplyCurrentValues(pvCollection)

            pvCollection.Clear()
            _pThamSo.Value = gDSQT_Menu_Phai
            pvCollection.Add(_pThamSo)
            rptVIEW.DataDefinition.ParameterFields("pMenu_Phai").ApplyCurrentValues(pvCollection)

            'Tieu de bao cao
            gDSQT_Menu_Ten_Bao_Cao = "BẢN KÊ SẢN LƯỢNG, DOANH THU CƯỚC ĐẦU CUỐI"
            pvCollection.Clear()
            _pThamSo.Value = gDSQT_Menu_Ten_Bao_Cao
            pvCollection.Add(_pThamSo)
            rptVIEW.DataDefinition.ParameterFields("pMenu_Ten_Bao_Cao").ApplyCurrentValues(pvCollection)

            'Ghi chú
            gDSQT_Menu_Ghi_Chu = ""
            pvCollection.Clear()
            _pThamSo.Value = gDSQT_Menu_Ghi_Chu
            pvCollection.Add(_pThamSo)
            rptVIEW.DataDefinition.ParameterFields("pMenu_Ghi_Chu").ApplyCurrentValues(pvCollection)

            'Người báo cáo
            gDSQT_Menu_Nguoi_Bao_Cao = GHo_Ten
            pvCollection.Clear()
            _pThamSo.Value = gDSQT_Menu_Ghi_Chu
            pvCollection.Add(_pThamSo)
            rptVIEW.DataDefinition.ParameterFields("pMenu_Nguoi_Bao_Cao").ApplyCurrentValues(pvCollection)

            'Trưởng đơn vị báo cáo
            If mKe_Toan_Cong_Ty = True Then
                gDSQT_Menu_Ten_Truong_Don_Vi = "Vũ Thị Mai Hồng"
            Else
                gDSQT_Menu_Ten_Truong_Don_Vi = mDSQT_Danh_Muc_Bc_Khai_Thac.DSQT_Danh_Muc_Bc_Khai_Thac_Lay(mMa_Bc_Khai_Thac).Truong_Don_Vi
            End If
            pvCollection.Clear()
            _pThamSo.Value = gDSQT_Menu_Ten_Truong_Don_Vi
            pvCollection.Add(_pThamSo)
            rptVIEW.DataDefinition.ParameterFields("pMenu_Ten_Truong_Don_Vi").ApplyCurrentValues(pvCollection)

            'Lãnh đạo
            If mKe_Toan_Cong_Ty = True Then
                gDSQT_Menu_Lanh_Dao = "Tổng Giám đốc" & vbNewLine & vbNewLine & vbNewLine & "Đặng Thị Bích Hòa"
            Else
                gDSQT_Menu_Lanh_Dao = ""
            End If
            pvCollection.Clear()
            _pThamSo.Value = gDSQT_Menu_Lanh_Dao
            pvCollection.Add(_pThamSo)
            rptVIEW.DataDefinition.ParameterFields("pMenu_Lanh_Dao").ApplyCurrentValues(pvCollection)

            'Gan DataSource cho report
            rptVIEW.SetDataSource(myDataSet)
            'Truyen rptCN38 vao rptView cua form viewReport
            FrmView.CrystalReportViewer1.ReportSource = rptVIEW
            Cursor.Current = Cursors.Default
            If mPreview = True Then
                'Xem tren man hinh
                FrmView.ShowDialog()
            Else
                'Dua ra may in
                rptVIEW.PrintToPrinter(mSo_Ban, True, 0, 0)
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region
#Region "Bao_Cao_Doanh_Thu_Tung_Nuoc_Theo_Ngay_Khai_Thac"
    Public Function Bao_Cao_Doanh_Thu_Tung_Nuoc_Theo_Ngay_Khai_Thac(ByVal mKe_Toan_Cong_Ty As Boolean, ByVal mTat_Ca As Boolean, ByVal mMa_Bc_Khai_Thac As Integer, ByVal mTu_Ngay As Integer, ByVal mDen_Ngay As Integer, ByVal mPreview As Boolean, ByVal mSo_Ban As Integer) As Boolean
        Try
            Dim mDSQT_CN55 As New DSQT_CN55(GConnectionString)
            Dim mDSQT_Danh_Muc_Bc_Khai_Thac As New DSQT_Danh_Muc_Bc_Khai_Thac(GConnectionString)
            Dim mNguoi_Dung As New Nguoi_Dung(GConnectionString)
            Dim FrmView As New Frm_DSQT_ViewReports
            Dim rptVIEW As New rptDSQT_Bao_Cao_Tong_Hop_Doanh_Thu
            Dim myDataSet As New DataSet
            Dim myTable As New DataTable

            Dim pvCollection As New ParameterValues
            Dim _pThamSo As New ParameterDiscreteValue

            'Lay du lieu
            myTable = mDSQT_CN55.DSQT_CN55_Bao_Cao_Doanh_Thu_Tung_Nuoc_Theo_Ngay_Khai_Thac(mTat_Ca, mMa_Bc_Khai_Thac, mTu_Ngay, mDen_Ngay).Tables(0)
            'Dat ten table cho phu hop
            myTable.TableName = "Bao_Cao_Doanh_Thu"
            'Dua vao Dataset
            myDataSet.Tables.Add(myTable.Copy)

            'Menu Trai
            gDSQT_Menu_Trai = "Công ty cổ phần Chuyển phát nhanh Bưu điện"
            pvCollection.Clear()
            _pThamSo.Value = gDSQT_Menu_Trai
            pvCollection.Add(_pThamSo)
            rptVIEW.DataDefinition.ParameterFields("pMenu_Trai").ApplyCurrentValues(pvCollection)

            'Tu ngay den ngay
            gDSQT_Menu_Thoi_Gian = "Ngày khai thác:  Từ " & Ham_Dung_Chung.ConvertIntToDate_VN(mTu_Ngay) & " Đến " & Ham_Dung_Chung.ConvertIntToDate_VN(mDen_Ngay)
            pvCollection.Clear()
            _pThamSo.Value = gDSQT_Menu_Thoi_Gian
            pvCollection.Add(_pThamSo)
            rptVIEW.DataDefinition.ParameterFields("pMenu_Thoi_Gian").ApplyCurrentValues(pvCollection)

            'Ngay tao bao cao
            gDSQT_Menu_Ngay_Thang_Nam = "Ngày " & Now.Day().ToString("00") & " Tháng " & Now.Month().ToString("00") & " Năm " & Now.Year().ToString("0000")
            pvCollection.Clear()
            _pThamSo.Value = gDSQT_Menu_Ngay_Thang_Nam
            pvCollection.Add(_pThamSo)
            rptVIEW.DataDefinition.ParameterFields("pMenu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)

            'Ten don vi in bao cao (HCM, HA NOI)
            If mKe_Toan_Cong_Ty = True Then   'Báo cáo cho kế toán
                gDSQT_Menu_Don_Vi = "Phòng Tài chính kế toán"
                If mTat_Ca = False Then
                    gDSQT_Menu_Phai = ""
                Else
                    gDSQT_Menu_Phai = mDSQT_Danh_Muc_Bc_Khai_Thac.DSQT_Danh_Muc_Bc_Khai_Thac_Lay(mMa_Bc_Khai_Thac).Ten_Tren_Bao_Cao
                End If
            Else   'báo cáo cho khai thác
                gDSQT_Menu_Don_Vi = mDSQT_Danh_Muc_Bc_Khai_Thac.DSQT_Danh_Muc_Bc_Khai_Thac_Lay(mMa_Bc_Khai_Thac).Ten_Tren_Bao_Cao
                gDSQT_Menu_Phai = ""
            End If
            pvCollection.Clear()
            _pThamSo.Value = gDSQT_Menu_Don_Vi
            pvCollection.Add(_pThamSo)
            rptVIEW.DataDefinition.ParameterFields("pMenu_Don_Vi").ApplyCurrentValues(pvCollection)

            pvCollection.Clear()
            _pThamSo.Value = gDSQT_Menu_Phai
            pvCollection.Add(_pThamSo)
            rptVIEW.DataDefinition.ParameterFields("pMenu_Phai").ApplyCurrentValues(pvCollection)

            'Tieu de bao cao
            gDSQT_Menu_Ten_Bao_Cao = "BẢN KÊ SẢN LƯỢNG, DOANH THU CƯỚC ĐẦU CUỐI"
            pvCollection.Clear()
            _pThamSo.Value = gDSQT_Menu_Ten_Bao_Cao
            pvCollection.Add(_pThamSo)
            rptVIEW.DataDefinition.ParameterFields("pMenu_Ten_Bao_Cao").ApplyCurrentValues(pvCollection)

            'Ghi chú
            gDSQT_Menu_Ghi_Chu = ""
            pvCollection.Clear()
            _pThamSo.Value = gDSQT_Menu_Ghi_Chu
            pvCollection.Add(_pThamSo)
            rptVIEW.DataDefinition.ParameterFields("pMenu_Ghi_Chu").ApplyCurrentValues(pvCollection)

            'Người báo cáo
            gDSQT_Menu_Nguoi_Bao_Cao = GHo_Ten
            pvCollection.Clear()
            _pThamSo.Value = gDSQT_Menu_Ghi_Chu
            pvCollection.Add(_pThamSo)
            rptVIEW.DataDefinition.ParameterFields("pMenu_Nguoi_Bao_Cao").ApplyCurrentValues(pvCollection)

            'Trưởng đơn vị báo cáo
            If mKe_Toan_Cong_Ty = True Then
                gDSQT_Menu_Ten_Truong_Don_Vi = "Vũ Thị Mai Hồng"
            Else
                gDSQT_Menu_Ten_Truong_Don_Vi = mDSQT_Danh_Muc_Bc_Khai_Thac.DSQT_Danh_Muc_Bc_Khai_Thac_Lay(mMa_Bc_Khai_Thac).Truong_Don_Vi
            End If
            pvCollection.Clear()
            _pThamSo.Value = gDSQT_Menu_Ten_Truong_Don_Vi
            pvCollection.Add(_pThamSo)
            rptVIEW.DataDefinition.ParameterFields("pMenu_Ten_Truong_Don_Vi").ApplyCurrentValues(pvCollection)

            'Lãnh đạo
            If mKe_Toan_Cong_Ty = True Then
                gDSQT_Menu_Lanh_Dao = "Tổng Giám đốc" & vbNewLine & vbNewLine & vbNewLine & "Đặng Thị Bích Hòa"
            Else
                gDSQT_Menu_Lanh_Dao = ""
            End If
            pvCollection.Clear()
            _pThamSo.Value = gDSQT_Menu_Lanh_Dao
            pvCollection.Add(_pThamSo)
            rptVIEW.DataDefinition.ParameterFields("pMenu_Lanh_Dao").ApplyCurrentValues(pvCollection)

            'Gan DataSource cho report
            rptVIEW.SetDataSource(myDataSet)
            'Truyen rptCN38 vao rptView cua form viewReport
            FrmView.CrystalReportViewer1.ReportSource = rptVIEW
            Cursor.Current = Cursors.Default
            If mPreview = True Then
                'Xem tren man hinh
                FrmView.ShowDialog()
            Else
                'Dua ra may in
                rptVIEW.PrintToPrinter(mSo_Ban, True, 0, 0)
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region

#Region "Bao_Cao_Doanh_Thu_Cuoc_VCMBND_Theo_Nam"
    Public Function Bao_Cao_Doanh_Thu_Cuoc_VCMBND_Theo_Nam(ByVal mKe_Toan_Cong_Ty As Boolean, ByVal mTat_Ca As Boolean, ByVal mMa_Bc_Khai_Thac As Integer, ByVal mNam As Integer, ByVal mPreview As Boolean, ByVal mSo_Ban As Integer) As Boolean
        Try
            Dim mDSQT_CN56 As New DSQT_CN56(GConnectionString)
            Dim mDSQT_Danh_Muc_Bc_Khai_Thac As New DSQT_Danh_Muc_Bc_Khai_Thac(GConnectionString)
            Dim mNguoi_Dung As New Nguoi_Dung(GConnectionString)
            Dim FrmView As New Frm_DSQT_ViewReports
            Dim rptVIEW As New rptDSQT_Bao_Cao_Tong_Hop_Doanh_Thu_Cuoc_VCMBND_Theo_Nam
            Dim myDataSet As New DataSet
            Dim myTable As New DataTable

            Dim pvCollection As New ParameterValues
            Dim _pThamSo As New ParameterDiscreteValue

            'Lay ngay cuoi cung cua Nam
            Dim mNgay_Ty_Gia As Integer
            mNgay_Ty_Gia = myHam_Dung_Chung.ConvertDateToInt(DSQT_Common.LastDayOfYear(mNam))

            'Lay du lieu
            myTable = mDSQT_CN56.DSQT_CN56_Bao_Cao_Doanh_Thu_Cuoc_VCMBND_Theo_Nam(mTat_Ca, mMa_Bc_Khai_Thac, mNam, mNgay_Ty_Gia).Tables(0)
            'Dat ten table cho phu hop
            myTable.TableName = "Bao_Cao_Doanh_Thu_Cuoc_VCMBND"
            'Dua vao Dataset
            myDataSet.Tables.Add(myTable.Copy)

            'Menu Trai
            gDSQT_Menu_Trai = "Công ty cổ phần Chuyển phát nhanh Bưu điện"
            pvCollection.Clear()
            _pThamSo.Value = gDSQT_Menu_Trai
            pvCollection.Add(_pThamSo)
            rptVIEW.DataDefinition.ParameterFields("pMenu_Trai").ApplyCurrentValues(pvCollection)

            'Tu ngay den ngay
            gDSQT_Menu_Thoi_Gian = "Năm  " & mNam
            pvCollection.Clear()
            _pThamSo.Value = gDSQT_Menu_Thoi_Gian
            pvCollection.Add(_pThamSo)
            rptVIEW.DataDefinition.ParameterFields("pMenu_Thoi_Gian").ApplyCurrentValues(pvCollection)

            'Ngay tao bao cao
            gDSQT_Menu_Ngay_Thang_Nam = "Ngày " & Now.Day().ToString("00") & " Tháng " & Now.Month().ToString("00") & " Năm " & Now.Year().ToString("0000")
            pvCollection.Clear()
            _pThamSo.Value = gDSQT_Menu_Ngay_Thang_Nam
            pvCollection.Add(_pThamSo)
            rptVIEW.DataDefinition.ParameterFields("pMenu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)

            'Ten don vi in bao cao (HCM, HA NOI)
            If mKe_Toan_Cong_Ty = True Then   'Báo cáo cho kế toán
                gDSQT_Menu_Don_Vi = "Phòng Tài chính kế toán"
                If mTat_Ca = False Then
                    gDSQT_Menu_Phai = ""
                Else
                    gDSQT_Menu_Phai = mDSQT_Danh_Muc_Bc_Khai_Thac.DSQT_Danh_Muc_Bc_Khai_Thac_Lay(mMa_Bc_Khai_Thac).Ten_Tren_Bao_Cao
                End If
            Else   'báo cáo cho khai thác
                gDSQT_Menu_Don_Vi = mDSQT_Danh_Muc_Bc_Khai_Thac.DSQT_Danh_Muc_Bc_Khai_Thac_Lay(mMa_Bc_Khai_Thac).Ten_Tren_Bao_Cao
                gDSQT_Menu_Phai = ""
            End If
            pvCollection.Clear()
            _pThamSo.Value = gDSQT_Menu_Don_Vi
            pvCollection.Add(_pThamSo)
            rptVIEW.DataDefinition.ParameterFields("pMenu_Don_Vi").ApplyCurrentValues(pvCollection)

            pvCollection.Clear()
            _pThamSo.Value = gDSQT_Menu_Phai
            pvCollection.Add(_pThamSo)
            rptVIEW.DataDefinition.ParameterFields("pMenu_Phai").ApplyCurrentValues(pvCollection)

            'Tieu de bao cao
            gDSQT_Menu_Ten_Bao_Cao = "BẢNG KÊ DOANH THU CƯỚC VCMBNĐ"
            pvCollection.Clear()
            _pThamSo.Value = gDSQT_Menu_Ten_Bao_Cao
            pvCollection.Add(_pThamSo)
            rptVIEW.DataDefinition.ParameterFields("pMenu_Ten_Bao_Cao").ApplyCurrentValues(pvCollection)

            'Ghi chú
            gDSQT_Menu_Ghi_Chu = ""
            pvCollection.Clear()
            _pThamSo.Value = gDSQT_Menu_Ghi_Chu
            pvCollection.Add(_pThamSo)
            rptVIEW.DataDefinition.ParameterFields("pMenu_Ghi_Chu").ApplyCurrentValues(pvCollection)

            'Người báo cáo
            gDSQT_Menu_Nguoi_Bao_Cao = GHo_Ten
            pvCollection.Clear()
            _pThamSo.Value = gDSQT_Menu_Ghi_Chu
            pvCollection.Add(_pThamSo)
            rptVIEW.DataDefinition.ParameterFields("pMenu_Nguoi_Bao_Cao").ApplyCurrentValues(pvCollection)

            ''Trưởng đơn vị báo cáo
            'If mKe_Toan_Cong_Ty = True Then
            '    gDSQT_Menu_Ten_Truong_Don_Vi = "Vũ Thị Mai Hồng"
            'Else
            '    gDSQT_Menu_Ten_Truong_Don_Vi = mDSQT_Danh_Muc_Bc_Khai_Thac.DSQT_Danh_Muc_Bc_Khai_Thac_Lay(mMa_Bc_Khai_Thac).Truong_Don_Vi
            'End If
            'pvCollection.Clear()
            '_pThamSo.Value = gDSQT_Menu_Ten_Truong_Don_Vi
            'pvCollection.Add(_pThamSo)
            'rptVIEW.DataDefinition.ParameterFields("pMenu_Ten_Truong_Don_Vi").ApplyCurrentValues(pvCollection)

            ''Lãnh đạo
            'If mKe_Toan_Cong_Ty = True Then
            '    gDSQT_Menu_Lanh_Dao = "Tổng Giám đốc" & vbNewLine & vbNewLine & vbNewLine & "Đặng Thị Bích Hòa"
            'Else
            '    gDSQT_Menu_Lanh_Dao = ""
            'End If
            'pvCollection.Clear()
            '_pThamSo.Value = gDSQT_Menu_Lanh_Dao
            'pvCollection.Add(_pThamSo)
            'rptVIEW.DataDefinition.ParameterFields("pMenu_Lanh_Dao").ApplyCurrentValues(pvCollection)

            'Gan DataSource cho report
            rptVIEW.SetDataSource(myDataSet)
            'Truyen DATA vao rptView cua form viewReport
            FrmView.CrystalReportViewer1.ReportSource = rptVIEW
            Cursor.Current = Cursors.Default
            If mPreview = True Then
                'Xem tren man hinh
                FrmView.ShowDialog()
            Else
                'Dua ra may in
                rptVIEW.PrintToPrinter(mSo_Ban, True, 0, 0)
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region

#Region "------------Date------------------"
    Public Function getDayFromDate(ByVal IntDate As Integer) As Integer
        If IntDate.ToString.Length <> 8 Then
            Return 0
        Else
            Return CInt(IntDate.ToString.Substring(6, 2))
        End If
    End Function
    Public Function getMonthFromDate(ByVal IntDate As Integer) As Integer
        If IntDate.ToString.Length <> 8 Then
            Return 0
        Else
            Return CInt(IntDate.ToString.Substring(4, 2))
        End If
    End Function
    Public Function getYearFromDate(ByVal IntDate As Integer) As Integer
        If IntDate.ToString.Length <> 8 Then
            Return 0
        Else
            Return CInt(IntDate.ToString.Substring(0, 4))
        End If
    End Function
    Public Function getQuarterFromDate(ByVal IntDate As Integer) As Integer
        If IntDate.ToString.Length <> 8 Then
            Return 0
        Else
            Select Case getMonthFromDate(IntDate)
                Case 1, 2, 3
                    Return 1
                Case 4, 5, 6
                    Return 2
                Case 7, 8, 9
                    Return 3
                Case 10, 11, 12
                    Return 4
                Case Else
                    Return 0
            End Select
        End If
    End Function
    Public Function LastDayOfYear(ByVal dYear As Integer) As Date
        Dim time As New DateTime((dYear + 1), 1, 1)
        Return time.AddDays(-1)
    End Function
#End Region

#Region "------------Get_Id_Dich_Vu------------------"
    Public Function Get_Id_Dich_Vu(ByVal Ma_E1 As String) As String
        Dim mPrefix As String
        mPrefix = Ma_E1.Substring(0, 1).ToUpper
        Select Case mPrefix
            Case "E"
                Return "E"
            Case "C"
                Return "C"
            Case Else
                Return "E"
        End Select
    End Function
#End Region

End Module

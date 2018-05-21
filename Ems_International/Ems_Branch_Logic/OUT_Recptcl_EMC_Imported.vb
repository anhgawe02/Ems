Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
    '*******************************************************
    ' Mỗi thuộc tính của lớp INB_Recptcl_Imported_Chi_Tiet
    ' tương ứng với mộ trường của bảng INB_Recptcl_Imported trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class OUT_Recptcl_EMC_Imported_Info_Detail
        Public RecptclId As String
        Public OrigOfficeCd As String
        Public DestOfficeCd As String
        Public Total_ItemWeigh As Double
        Public ClassCd As String
        Public SubclassCd As String
        Public OrigCountryCd As String
        Public Id_E2 As String
        Public So_Hieu_chuyen_bay As String
        Public Ngay_Dong As Integer
        Public IPSDate As DateTime
        Public Ngay_He_Thong As Integer
        Public Total_Item As Integer
        Public DestCountryCd As String
        Public Ngay_Bay As Integer
        Public DepartureDate As DateTime
        Public CloseDate As DateTime
        Public Id_Chuyen_Thu As String
        Public Id_Ca As String
    End Class
    Public Class OUT_Recptcl_EMC_Imported
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
        Public Function Lay(ByVal myRecptclId As String) As OUT_Recptcl_EMC_Imported_Info_Detail
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("OUT_Recptcl_EMC_Imported_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                ' Thêm các Parameters vào thủ tục            
                Dim pRecptclId As SqlParameter = New SqlParameter("@RecptclId", SqlDbType.VarChar, 31)
                pRecptclId.Value = myRecptclId
                myCommand.Parameters.Add(pRecptclId)

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_E2)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 18)
                pId_Ca.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Ca)

                Dim pOrigCountryCd As SqlParameter = New SqlParameter("@OrigCountryCd", SqlDbType.VarChar, 2)
                pOrigCountryCd.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pOrigCountryCd)

                Dim pDestCountryCd As SqlParameter = New SqlParameter("@DestCountryCd", SqlDbType.VarChar, 2)
                pDestCountryCd.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDestCountryCd)

                Dim pDestOfficeCd As SqlParameter = New SqlParameter("@DestOfficeCd", SqlDbType.VarChar, 7)
                pDestOfficeCd.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDestOfficeCd)

                Dim pOrigOfficeCd As SqlParameter = New SqlParameter("@OrigOfficeCd", SqlDbType.VarChar, 7)
                pOrigOfficeCd.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pOrigOfficeCd)

                Dim pClassCd As SqlParameter = New SqlParameter("@ClassCd", SqlDbType.VarChar, 2)
                pClassCd.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pClassCd)

                Dim pSubclassCd As SqlParameter = New SqlParameter("@SubclassCd", SqlDbType.VarChar, 2)
                pSubclassCd.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSubclassCd)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int)
                pNgay_Dong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_Dong)

                Dim pNgay_Bay As SqlParameter = New SqlParameter("@Ngay_Bay", SqlDbType.Int)
                pNgay_Bay.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_Bay)

                Dim pIPSDate As SqlParameter = New SqlParameter("@IPSDate", SqlDbType.DateTime)
                pIPSDate.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pIPSDate)

                Dim pTotal_Item As SqlParameter = New SqlParameter("@Total_Item", SqlDbType.Int, 4)
                pTotal_Item.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTotal_Item)

                Dim pTotal_Weigh As SqlParameter = New SqlParameter("@Total_ItemWeigh", SqlDbType.Float)
                pTotal_Weigh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTotal_Weigh)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pSo_hieu_chuyen_bay As SqlParameter = New SqlParameter("@So_hieu_chuyen_bay", SqlDbType.NVarChar, 50)
                pSo_hieu_chuyen_bay.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSo_hieu_chuyen_bay)

                Dim pCloseDate As SqlParameter = New SqlParameter("@CloseDate", SqlDbType.DateTime)
                pCloseDate.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCloseDate)

                Dim pDepartureDate As SqlParameter = New SqlParameter("@DepartureDate", SqlDbType.DateTime)
                pDepartureDate.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDepartureDate)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myOUT_Recptcl_EMC_Imported_Info_Detail As OUT_Recptcl_EMC_Imported_Info_Detail = New OUT_Recptcl_EMC_Imported_Info_Detail
                myOUT_Recptcl_EMC_Imported_Info_Detail.RecptclId = myRecptclId
                myOUT_Recptcl_EMC_Imported_Info_Detail.Id_E2 = pId_E2.Value
                myOUT_Recptcl_EMC_Imported_Info_Detail.Ngay_Dong = pNgay_Dong.Value
                myOUT_Recptcl_EMC_Imported_Info_Detail.IPSDate = pIPSDate.Value
                myOUT_Recptcl_EMC_Imported_Info_Detail.OrigCountryCd = pOrigCountryCd.Value
                myOUT_Recptcl_EMC_Imported_Info_Detail.DestOfficeCd = pDestOfficeCd.Value
                myOUT_Recptcl_EMC_Imported_Info_Detail.OrigOfficeCd = pOrigOfficeCd.Value
                myOUT_Recptcl_EMC_Imported_Info_Detail.ClassCd = pClassCd.Value
                myOUT_Recptcl_EMC_Imported_Info_Detail.SubclassCd = pSubclassCd.Value
                myOUT_Recptcl_EMC_Imported_Info_Detail.Ngay_He_Thong = pNgay_He_Thong.Value
                myOUT_Recptcl_EMC_Imported_Info_Detail.So_Hieu_chuyen_bay = pSo_hieu_chuyen_bay.Value
                myOUT_Recptcl_EMC_Imported_Info_Detail.Total_Item = pTotal_Item.Value
                myOUT_Recptcl_EMC_Imported_Info_Detail.Total_ItemWeigh = pTotal_Weigh.Value
                myOUT_Recptcl_EMC_Imported_Info_Detail.Ngay_Bay = pNgay_Bay.Value
                myOUT_Recptcl_EMC_Imported_Info_Detail.DestCountryCd = pDestCountryCd.Value
                myOUT_Recptcl_EMC_Imported_Info_Detail.CloseDate = pCloseDate.Value
                myOUT_Recptcl_EMC_Imported_Info_Detail.DepartureDate = pDepartureDate.Value
                myOUT_Recptcl_EMC_Imported_Info_Detail.Id_Ca = pId_Ca.Value
                myOUT_Recptcl_EMC_Imported_Info_Detail.Id_Chuyen_Thu = pId_Chuyen_Thu.Value
                Return myOUT_Recptcl_EMC_Imported_Info_Detail
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
        Public Sub OUT_Recptcl_EMC_Imported_Cap_Nhat_Da_Xac_Nhan(ByVal Id_E2 As String, ByVal CloseDate As DateTime, ByVal Ngay_Dong As Integer, ByVal So_Hieu_Chuyen_Bay As String, ByVal myRecptclId As String, ByVal DepartureDate As DateTime, ByVal Ngay_Bay As Integer, ByVal Id_Ca As String, ByVal Id_Chuyen_Thu As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("OUT_Recptcl_EMC_Imported_Cap_Nhat_Da_Xac_Nhan", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pRecptclId As SqlParameter = New SqlParameter("@RecptclId", SqlDbType.VarChar, 31)
                pRecptclId.Value = myRecptclId
                myCommand.Parameters.Add(pRecptclId)

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)

                Dim pCloseDate As SqlParameter = New SqlParameter("@CloseDate", SqlDbType.DateTime)
                pCloseDate.Value = CloseDate
                myCommand.Parameters.Add(pCloseDate)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 4)
                pNgay_Dong.Value = Ngay_Dong
                myCommand.Parameters.Add(pNgay_Dong)

                Dim pDepartureDate As SqlParameter = New SqlParameter("@DepartureDate", SqlDbType.DateTime)
                pDepartureDate.Value = DepartureDate
                myCommand.Parameters.Add(pDepartureDate)

                Dim pNgay_Bay As SqlParameter = New SqlParameter("@Ngay_Bay", SqlDbType.Int, 4)
                pNgay_Bay.Value = Ngay_Bay
                myCommand.Parameters.Add(pNgay_Bay)

                Dim pSo_hieu_chuyen_bay As SqlParameter = New SqlParameter("@So_hieu_chuyen_bay", SqlDbType.NVarChar, 50)
                pSo_hieu_chuyen_bay.Value = So_Hieu_Chuyen_Bay
                myCommand.Parameters.Add(pSo_hieu_chuyen_bay)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 50)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 50)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
        Public Sub OUT_E1_Di_Tam_Insert_To_E1_Di_IPS(ByVal Id_Chuyen_Thu As String, ByVal Id_E2 As String, ByVal Id_ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Recptclid As String, ByVal Ngay_Dong As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("OUT_E1_Di_Tam_Insert_To_E1_Di_IPS", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)

                Dim pRecptclid As SqlParameter = New SqlParameter("@Recptclid", SqlDbType.VarChar, 31)
                pRecptclid.Value = Recptclid
                myCommand.Parameters.Add(pRecptclid)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 12)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 12)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 4)
                pNgay_Dong.Value = Ngay_Dong
                myCommand.Parameters.Add(pNgay_Dong)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myCommand.CommandTimeout = 20000
                myAdapter.Fill(myDataSet, "OUT_E1_Di_Tam_Insert_To_E1_Di_IPS")
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
    End Class
End Namespace

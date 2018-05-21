
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "INB_Recptcl_Imported_Info_Detail"
    '*******************************************************
    ' Mỗi thuộc tính của lớp INB_Recptcl_Imported_Chi_Tiet
    ' tương ứng với mộ trường của bảng INB_Recptcl_Imported trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class INB_Recptcl_Imported_Info_Detail
        Public RecptclId As String
        Public OrigOfficeCd As String
        Public DestOfficeCd As String
        Public Total_ItemWeigh As String
        Public ClassCd As String
        Public SubclassCd As String
        Public OrigCountryCd As String
        Public Id_E2 As String
        Public So_Hieu_chuyen_bay As String
        Public Ngay_Dong As DateTime
        Public IPSDate As DateTime
        Public Ngay_He_Thong As Integer
        Public Total_Item As Integer
    End Class
#End Region
#Region "INB_Recptcl_Imported"
    Public Class INB_Recptcl_Imported
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "E1_Den_Tam_Insert_To_E1_Den_Le_Phi_HQ_KT_IPS"
        ' Ngày tạo: 15/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy dữ liệu truyền về: Insert dữ liệu từ bảng tạm (E1_Den_Tam) sang bảng chính (Tmp_E1_Den),bang le phi
        ' Input: Id_E2, Id_Ca, Ma_Bc_Khai_Thac
        Public Sub E1_Den_Tam_Insert_To_E1_Den_Le_Phi_HQ_KT_IPS(ByVal Id_Chuyen_Thu As String, ByVal Id_E2 As String, ByVal Id_ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Recptclid As String, ByVal Ngay_Dong As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Tam_Insert_To_E1_Den_Le_Phi_HQ_KT_IPS", myConnection)
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
                myAdapter.Fill(myDataSet, "E1_Den_Tam_Insert_To_E1_Den_Le_Phi_HQ_KT")
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region
        Public Function Lay(ByVal myRecptclId As String) As INB_Recptcl_Imported_Info_Detail
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("INB_Recptcl_Imported_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                ' Thêm các Parameters vào thủ tục            
                Dim pRecptclId As SqlParameter = New SqlParameter("@RecptclId", SqlDbType.VarChar, 31)
                pRecptclId.Value = myRecptclId
                myCommand.Parameters.Add(pRecptclId)

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_E2)

                Dim pOrigCountryCd As SqlParameter = New SqlParameter("@OrigCountryCd", SqlDbType.VarChar, 2)
                pOrigCountryCd.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pOrigCountryCd)

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

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.DateTime)
                pNgay_Dong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_Dong)

                Dim pIPSDate As SqlParameter = New SqlParameter("@IPSDate", SqlDbType.DateTime)
                pIPSDate.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pIPSDate)

                Dim pTotal_Item As SqlParameter = New SqlParameter("@Total_Item", SqlDbType.Int, 4)
                pTotal_Item.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTotal_Item)

                Dim pTotal_Weigh As SqlParameter = New SqlParameter("@Total_Weigh", SqlDbType.Float, 4)
                pTotal_Weigh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTotal_Weigh)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pSo_hieu_chuyen_bay As SqlParameter = New SqlParameter("@So_hieu_chuyen_bay", SqlDbType.NVarChar, 50)
                pSo_hieu_chuyen_bay.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSo_hieu_chuyen_bay)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myINB_Recptcl_Imported_Info_Detail As INB_Recptcl_Imported_Info_Detail = New INB_Recptcl_Imported_Info_Detail
                myINB_Recptcl_Imported_Info_Detail.RecptclId = myRecptclId
                myINB_Recptcl_Imported_Info_Detail.Id_E2 = pId_E2.Value
                myINB_Recptcl_Imported_Info_Detail.Ngay_Dong = pNgay_Dong.Value
                myINB_Recptcl_Imported_Info_Detail.IPSDate = pIPSDate.Value
                myINB_Recptcl_Imported_Info_Detail.OrigCountryCd = pOrigCountryCd.Value
                myINB_Recptcl_Imported_Info_Detail.DestOfficeCd = pDestOfficeCd.Value
                myINB_Recptcl_Imported_Info_Detail.OrigOfficeCd = pOrigOfficeCd.Value
                myINB_Recptcl_Imported_Info_Detail.ClassCd = pClassCd.Value
                myINB_Recptcl_Imported_Info_Detail.SubclassCd = pSubclassCd.Value
                myINB_Recptcl_Imported_Info_Detail.Ngay_He_Thong = pNgay_He_Thong.Value
                myINB_Recptcl_Imported_Info_Detail.So_Hieu_chuyen_bay = pSo_hieu_chuyen_bay.Value
                myINB_Recptcl_Imported_Info_Detail.Total_Item = pTotal_Item.Value
                myINB_Recptcl_Imported_Info_Detail.Total_ItemWeigh = pTotal_Weigh.Value
                Return myINB_Recptcl_Imported_Info_Detail
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function

        Public Sub INB_Recptcl_Imported_Cap_Nhat_Da_Xac_Nhan(ByVal Id_E2 As String, ByVal Ngay_Dong As DateTime, ByVal So_Hieu_Chuyen_Bay As String, ByVal myRecptclId As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("INB_Recptcl_Imported_Cap_Nhat_Da_Xac_Nhan", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pRecptclId As SqlParameter = New SqlParameter("@RecptclId", SqlDbType.VarChar, 31)
                pRecptclId.Value = myRecptclId
                myCommand.Parameters.Add(pRecptclId)

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.DateTime, 4)
                pNgay_Dong.Value = Ngay_Dong
                myCommand.Parameters.Add(pNgay_Dong)

                Dim pSo_hieu_chuyen_bay As SqlParameter = New SqlParameter("@So_hieu_chuyen_bay", SqlDbType.NVarChar, 50)
                pSo_hieu_chuyen_bay.Value = So_Hieu_Chuyen_Bay
                myCommand.Parameters.Add(pSo_hieu_chuyen_bay)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub

        Public Function ImportItemINB_Lay_Boi_RecptclID(ByVal RecptclID As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("ImportItemINB_Lay_Boi_RecptclID", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pRecptclID As SqlParameter = New SqlParameter("@RecptclID", SqlDbType.VarChar, 31)
                pRecptclID.Value = RecptclID
                myCommand.Parameters.Add(pRecptclID)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "ImportItemINB_Lay_Boi_RecptclID")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function

    End Class
#End Region
End Namespace


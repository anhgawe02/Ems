
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "Accounting_Du_Lieu_Quy_CN55_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop Accounting_Du_Lieu_Quy_CN55_Chi_Tiet
    'Tuong ung voi moi truong trong bang Accounting_Du_Lieu_Quy_CN55 trong co so du lieu
    '***********************************************************
    Public Class Accounting_Du_Lieu_Quy_CN55_Chi_Tiet
        Public Id_Chi_Tiet As String
        Public Ma_Quy As Integer
        Public Id_Duong_Thu_Den As String
        Public Ten_Duong_Thu_Den As String
        Public Ma_Bc_Den As Integer
        Public Ma_Bc_KT_Den As Integer
        Public Ngay_Dong As Integer
        Public So_CT_Den As Integer
        Public Loai_CT_Den As String
        Public Ma_Bc_Tra As Integer
        Public SL_D_Col_1 As Integer
        Public SL_M_Col_1 As Integer
        Public SL_D_Col_2 As Integer
        Public SL_M_Col_2 As Integer
        Public SL_D_Col_3 As Integer
        Public SL_M_Col_3 As Integer
        Public Ghi_Chu As String
        Public Is_Mien_Bac As Boolean
    End Class
#End Region

#Region "Accounting_Du_Lieu_Quy_CN55"
    Public Class Accounting_Du_Lieu_Quy_CN55
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "Accounting_Du_Lieu_Quy_CN55_Cap_Nhat"
        Public Function Accounting_Du_Lieu_Quy_CN55_Cap_Nhat(ByVal Id_Chi_Tiet As String, ByVal Ma_Quy As Integer, ByVal Id_Duong_Thu_Den As String, ByVal Ten_Duong_Thu_Den As String, ByVal Ma_Bc_Den As Integer, ByVal Ma_Bc_KT_Den As Integer, ByVal Ngay_Dong As Integer, ByVal So_CT_Den As Integer, ByVal Loai_CT_Den As String, ByVal Ma_Bc_Tra As Integer, ByVal SL_D_Col_1 As Integer, ByVal SL_M_Col_1 As Integer, ByVal SL_D_Col_2 As Integer, ByVal SL_M_Col_2 As Integer, ByVal SL_D_Col_3 As Integer, ByVal SL_M_Col_3 As Integer, ByVal Ghi_Chu As String, ByVal Is_Mien_Bac As Boolean) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Du_Lieu_Quy_CN55_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myAccounting_Du_Lieu_Quy_CN55_Chi_Tiet As New Accounting_Du_Lieu_Quy_CN55_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Chi_Tiet As SqlParameter = New SqlParameter("@Id_Chi_Tiet", SqlDbType.VarChar, 35)
                pId_Chi_Tiet.Value = Id_Chi_Tiet
                MyCommand.Parameters.Add(pId_Chi_Tiet)

                Dim pMa_Quy As SqlParameter = New SqlParameter("@Ma_Quy", SqlDbType.Int, 0)
                pMa_Quy.Value = Ma_Quy
                MyCommand.Parameters.Add(pMa_Quy)

                Dim pId_Duong_Thu_Den As SqlParameter = New SqlParameter("@Id_Duong_Thu_Den", SqlDbType.VarChar, 14)
                pId_Duong_Thu_Den.Value = Id_Duong_Thu_Den
                MyCommand.Parameters.Add(pId_Duong_Thu_Den)

                Dim pTen_Duong_Thu_Den As SqlParameter = New SqlParameter("@Ten_Duong_Thu_Den", SqlDbType.NVarChar, 150)
                pTen_Duong_Thu_Den.Value = Ten_Duong_Thu_Den
                MyCommand.Parameters.Add(pTen_Duong_Thu_Den)

                Dim pMa_Bc_Den As SqlParameter = New SqlParameter("@Ma_Bc_Den", SqlDbType.Int, 0)
                pMa_Bc_Den.Value = Ma_Bc_Den
                MyCommand.Parameters.Add(pMa_Bc_Den)

                Dim pMa_Bc_KT_Den As SqlParameter = New SqlParameter("@Ma_Bc_KT_Den", SqlDbType.Int, 0)
                pMa_Bc_KT_Den.Value = Ma_Bc_KT_Den
                MyCommand.Parameters.Add(pMa_Bc_KT_Den)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 0)
                pNgay_Dong.Value = Ngay_Dong
                MyCommand.Parameters.Add(pNgay_Dong)

                Dim pSo_CT_Den As SqlParameter = New SqlParameter("@So_CT_Den", SqlDbType.Int, 0)
                pSo_CT_Den.Value = So_CT_Den
                MyCommand.Parameters.Add(pSo_CT_Den)

                Dim pLoai_CT_Den As SqlParameter = New SqlParameter("@Loai_CT_Den", SqlDbType.VarChar, 2)
                pLoai_CT_Den.Value = Loai_CT_Den
                MyCommand.Parameters.Add(pLoai_CT_Den)

                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 0)
                pMa_Bc_Tra.Value = Ma_Bc_Tra
                MyCommand.Parameters.Add(pMa_Bc_Tra)

                Dim pSL_D_Col_1 As SqlParameter = New SqlParameter("@SL_D_Col_1", SqlDbType.Int, 0)
                pSL_D_Col_1.Value = SL_D_Col_1
                MyCommand.Parameters.Add(pSL_D_Col_1)

                Dim pSL_M_Col_1 As SqlParameter = New SqlParameter("@SL_M_Col_1", SqlDbType.Int, 0)
                pSL_M_Col_1.Value = SL_M_Col_1
                MyCommand.Parameters.Add(pSL_M_Col_1)

                Dim pSL_D_Col_2 As SqlParameter = New SqlParameter("@SL_D_Col_2", SqlDbType.Int, 0)
                pSL_D_Col_2.Value = SL_D_Col_2
                MyCommand.Parameters.Add(pSL_D_Col_2)

                Dim pSL_M_Col_2 As SqlParameter = New SqlParameter("@SL_M_Col_2", SqlDbType.Int, 0)
                pSL_M_Col_2.Value = SL_M_Col_2
                MyCommand.Parameters.Add(pSL_M_Col_2)

                Dim pSL_D_Col_3 As SqlParameter = New SqlParameter("@SL_D_Col_3", SqlDbType.Int, 0)
                pSL_D_Col_3.Value = SL_D_Col_3
                MyCommand.Parameters.Add(pSL_D_Col_3)

                Dim pSL_M_Col_3 As SqlParameter = New SqlParameter("@SL_M_Col_3", SqlDbType.Int, 0)
                pSL_M_Col_3.Value = SL_M_Col_3
                MyCommand.Parameters.Add(pSL_M_Col_3)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 50)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pIs_Mien_Bac As SqlParameter = New SqlParameter("@Is_Mien_Bac", SqlDbType.Bit, 0)
                pIs_Mien_Bac.Value = Is_Mien_Bac
                MyCommand.Parameters.Add(pIs_Mien_Bac)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()

                Return numRows
                'Return numRows

            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)

            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()

            End Try
        End Function

#End Region

#Region "Accounting_Du_Lieu_Quy_CN55_Cap_Nhat_Them"
        Public Function Accounting_Du_Lieu_Quy_CN55_Cap_Nhat_Them(ByVal Id_Chi_Tiet As String, ByVal Ma_Quy As Integer, ByVal Id_Duong_Thu_Den As String, ByVal Ten_Duong_Thu_Den As String, ByVal Ma_Bc_Den As Integer, ByVal Ma_Bc_KT_Den As Integer, ByVal Ngay_Dong As Integer, ByVal So_CT_Den As Integer, ByVal Loai_CT_Den As String, ByVal Ma_Bc_Tra As Integer, ByVal SL_D_Col_1 As Integer, ByVal SL_M_Col_1 As Integer, ByVal SL_D_Col_2 As Integer, ByVal SL_M_Col_2 As Integer, ByVal SL_D_Col_3 As Integer, ByVal SL_M_Col_3 As Integer, ByVal Ghi_Chu As String, ByVal Is_Mien_Bac As Boolean) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Du_Lieu_Quy_CN55_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myAccounting_Du_Lieu_Quy_CN55_Chi_Tiet As New Accounting_Du_Lieu_Quy_CN55_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Chi_Tiet As SqlParameter = New SqlParameter("@Id_Chi_Tiet", SqlDbType.VarChar, 35)
                pId_Chi_Tiet.Value = Id_Chi_Tiet
                MyCommand.Parameters.Add(pId_Chi_Tiet)

                Dim pMa_Quy As SqlParameter = New SqlParameter("@Ma_Quy", SqlDbType.Int, 0)
                pMa_Quy.Value = Ma_Quy
                MyCommand.Parameters.Add(pMa_Quy)

                Dim pId_Duong_Thu_Den As SqlParameter = New SqlParameter("@Id_Duong_Thu_Den", SqlDbType.VarChar, 14)
                pId_Duong_Thu_Den.Value = Id_Duong_Thu_Den
                MyCommand.Parameters.Add(pId_Duong_Thu_Den)

                Dim pTen_Duong_Thu_Den As SqlParameter = New SqlParameter("@Ten_Duong_Thu_Den", SqlDbType.NVarChar, 150)
                pTen_Duong_Thu_Den.Value = Ten_Duong_Thu_Den
                MyCommand.Parameters.Add(pTen_Duong_Thu_Den)

                Dim pMa_Bc_Den As SqlParameter = New SqlParameter("@Ma_Bc_Den", SqlDbType.Int, 0)
                pMa_Bc_Den.Value = Ma_Bc_Den
                MyCommand.Parameters.Add(pMa_Bc_Den)

                Dim pMa_Bc_KT_Den As SqlParameter = New SqlParameter("@Ma_Bc_KT_Den", SqlDbType.Int, 0)
                pMa_Bc_KT_Den.Value = Ma_Bc_KT_Den
                MyCommand.Parameters.Add(pMa_Bc_KT_Den)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 0)
                pNgay_Dong.Value = Ngay_Dong
                MyCommand.Parameters.Add(pNgay_Dong)

                Dim pSo_CT_Den As SqlParameter = New SqlParameter("@So_CT_Den", SqlDbType.Int, 0)
                pSo_CT_Den.Value = So_CT_Den
                MyCommand.Parameters.Add(pSo_CT_Den)

                Dim pLoai_CT_Den As SqlParameter = New SqlParameter("@Loai_CT_Den", SqlDbType.VarChar, 2)
                pLoai_CT_Den.Value = Loai_CT_Den
                MyCommand.Parameters.Add(pLoai_CT_Den)

                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 0)
                pMa_Bc_Tra.Value = Ma_Bc_Tra
                MyCommand.Parameters.Add(pMa_Bc_Tra)

                Dim pSL_D_Col_1 As SqlParameter = New SqlParameter("@SL_D_Col_1", SqlDbType.Int, 0)
                pSL_D_Col_1.Value = SL_D_Col_1
                MyCommand.Parameters.Add(pSL_D_Col_1)

                Dim pSL_M_Col_1 As SqlParameter = New SqlParameter("@SL_M_Col_1", SqlDbType.Int, 0)
                pSL_M_Col_1.Value = SL_M_Col_1
                MyCommand.Parameters.Add(pSL_M_Col_1)

                Dim pSL_D_Col_2 As SqlParameter = New SqlParameter("@SL_D_Col_2", SqlDbType.Int, 0)
                pSL_D_Col_2.Value = SL_D_Col_2
                MyCommand.Parameters.Add(pSL_D_Col_2)

                Dim pSL_M_Col_2 As SqlParameter = New SqlParameter("@SL_M_Col_2", SqlDbType.Int, 0)
                pSL_M_Col_2.Value = SL_M_Col_2
                MyCommand.Parameters.Add(pSL_M_Col_2)

                Dim pSL_D_Col_3 As SqlParameter = New SqlParameter("@SL_D_Col_3", SqlDbType.Int, 0)
                pSL_D_Col_3.Value = SL_D_Col_3
                MyCommand.Parameters.Add(pSL_D_Col_3)

                Dim pSL_M_Col_3 As SqlParameter = New SqlParameter("@SL_M_Col_3", SqlDbType.Int, 0)
                pSL_M_Col_3.Value = SL_M_Col_3
                MyCommand.Parameters.Add(pSL_M_Col_3)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 50)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pIs_Mien_Bac As SqlParameter = New SqlParameter("@Is_Mien_Bac", SqlDbType.Bit, 0)
                pIs_Mien_Bac.Value = Is_Mien_Bac
                MyCommand.Parameters.Add(pIs_Mien_Bac)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()

                Return numRows
                'Return numRows

            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)

            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()

            End Try
        End Function

#End Region

#Region "Accounting_Du_Lieu_Quy_CN55_Danh_Sach"

        Public Function Accounting_Du_Lieu_Quy_CN55_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Id_Chi_Tiet
            ' Ma_Quy
            ' Id_Duong_Thu_Den
            ' Ten_Duong_Thu_Den
            ' Ma_Bc_Den
            ' Ma_Bc_KT_Den
            ' Ngay_Dong
            ' So_CT_Den
            ' Loai_CT_Den
            ' Ma_Bc_Tra
            ' SL_D_Col_1
            ' SL_M_Col_1
            ' SL_D_Col_2
            ' SL_M_Col_2
            ' SL_D_Col_3
            ' SL_M_Col_3
            ' Ghi_Chu
            ' Is_Mien_Bac


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Du_Lieu_Quy_CN55_Danh_Sach"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters


                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                adapter.Fill(MyDataSet)

                Return MyDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                adapter.Dispose()
            End Try
        End Function
#End Region

#Region "Accounting_Du_Lieu_Quy_CN55_Lay"
        Public Function Accounting_Du_Lieu_Quy_CN55_Lay(ByVal Id_Chi_Tiet As String) As Accounting_Du_Lieu_Quy_CN55_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Du_Lieu_Quy_CN55_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myAccounting_Du_Lieu_Quy_CN55_Chi_Tiet As New Accounting_Du_Lieu_Quy_CN55_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Chi_Tiet As SqlParameter = New SqlParameter("@Id_Chi_Tiet", SqlDbType.VarChar, 35)
                pId_Chi_Tiet.Value = Id_Chi_Tiet
                MyCommand.Parameters.Add(pId_Chi_Tiet)

                Dim pMa_Quy As SqlParameter = New SqlParameter("@Ma_Quy", SqlDbType.Int, 0)
                pMa_Quy.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Quy)

                Dim pId_Duong_Thu_Den As SqlParameter = New SqlParameter("@Id_Duong_Thu_Den", SqlDbType.VarChar, 14)
                pId_Duong_Thu_Den.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Duong_Thu_Den)

                Dim pTen_Duong_Thu_Den As SqlParameter = New SqlParameter("@Ten_Duong_Thu_Den", SqlDbType.NVarChar, 150)
                pTen_Duong_Thu_Den.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTen_Duong_Thu_Den)

                Dim pMa_Bc_Den As SqlParameter = New SqlParameter("@Ma_Bc_Den", SqlDbType.Int, 0)
                pMa_Bc_Den.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc_Den)

                Dim pMa_Bc_KT_Den As SqlParameter = New SqlParameter("@Ma_Bc_KT_Den", SqlDbType.Int, 0)
                pMa_Bc_KT_Den.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc_KT_Den)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 0)
                pNgay_Dong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Dong)

                Dim pSo_CT_Den As SqlParameter = New SqlParameter("@So_CT_Den", SqlDbType.Int, 0)
                pSo_CT_Den.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSo_CT_Den)

                Dim pLoai_CT_Den As SqlParameter = New SqlParameter("@Loai_CT_Den", SqlDbType.VarChar, 2)
                pLoai_CT_Den.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pLoai_CT_Den)

                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 0)
                pMa_Bc_Tra.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc_Tra)

                Dim pSL_D_Col_1 As SqlParameter = New SqlParameter("@SL_D_Col_1", SqlDbType.Int, 0)
                pSL_D_Col_1.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSL_D_Col_1)

                Dim pSL_M_Col_1 As SqlParameter = New SqlParameter("@SL_M_Col_1", SqlDbType.Int, 0)
                pSL_M_Col_1.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSL_M_Col_1)

                Dim pSL_D_Col_2 As SqlParameter = New SqlParameter("@SL_D_Col_2", SqlDbType.Int, 0)
                pSL_D_Col_2.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSL_D_Col_2)

                Dim pSL_M_Col_2 As SqlParameter = New SqlParameter("@SL_M_Col_2", SqlDbType.Int, 0)
                pSL_M_Col_2.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSL_M_Col_2)

                Dim pSL_D_Col_3 As SqlParameter = New SqlParameter("@SL_D_Col_3", SqlDbType.Int, 0)
                pSL_D_Col_3.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSL_D_Col_3)

                Dim pSL_M_Col_3 As SqlParameter = New SqlParameter("@SL_M_Col_3", SqlDbType.Int, 0)
                pSL_M_Col_3.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSL_M_Col_3)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 50)
                pGhi_Chu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pIs_Mien_Bac As SqlParameter = New SqlParameter("@Is_Mien_Bac", SqlDbType.Bit, 0)
                pIs_Mien_Bac.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pIs_Mien_Bac)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myAccounting_Du_Lieu_Quy_CN55_Chi_Tiet.Id_Chi_Tiet = Id_Chi_Tiet
                myAccounting_Du_Lieu_Quy_CN55_Chi_Tiet.Ma_Quy = pMa_Quy.Value
                myAccounting_Du_Lieu_Quy_CN55_Chi_Tiet.Id_Duong_Thu_Den = pId_Duong_Thu_Den.Value
                myAccounting_Du_Lieu_Quy_CN55_Chi_Tiet.Ten_Duong_Thu_Den = pTen_Duong_Thu_Den.Value
                myAccounting_Du_Lieu_Quy_CN55_Chi_Tiet.Ma_Bc_Den = pMa_Bc_Den.Value
                myAccounting_Du_Lieu_Quy_CN55_Chi_Tiet.Ma_Bc_KT_Den = pMa_Bc_KT_Den.Value
                myAccounting_Du_Lieu_Quy_CN55_Chi_Tiet.Ngay_Dong = pNgay_Dong.Value
                myAccounting_Du_Lieu_Quy_CN55_Chi_Tiet.So_CT_Den = pSo_CT_Den.Value
                myAccounting_Du_Lieu_Quy_CN55_Chi_Tiet.Loai_CT_Den = pLoai_CT_Den.Value
                myAccounting_Du_Lieu_Quy_CN55_Chi_Tiet.Ma_Bc_Tra = pMa_Bc_Tra.Value
                myAccounting_Du_Lieu_Quy_CN55_Chi_Tiet.SL_D_Col_1 = pSL_D_Col_1.Value
                myAccounting_Du_Lieu_Quy_CN55_Chi_Tiet.SL_M_Col_1 = pSL_M_Col_1.Value
                myAccounting_Du_Lieu_Quy_CN55_Chi_Tiet.SL_D_Col_2 = pSL_D_Col_2.Value
                myAccounting_Du_Lieu_Quy_CN55_Chi_Tiet.SL_M_Col_2 = pSL_M_Col_2.Value
                myAccounting_Du_Lieu_Quy_CN55_Chi_Tiet.SL_D_Col_3 = pSL_D_Col_3.Value
                myAccounting_Du_Lieu_Quy_CN55_Chi_Tiet.SL_M_Col_3 = pSL_M_Col_3.Value
                myAccounting_Du_Lieu_Quy_CN55_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value
                myAccounting_Du_Lieu_Quy_CN55_Chi_Tiet.Is_Mien_Bac = pIs_Mien_Bac.Value

                Return myAccounting_Du_Lieu_Quy_CN55_Chi_Tiet
                'Return myAccounting_Du_Lieu_Quy_CN55_Chi_Tiet

            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)

            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()

            End Try
        End Function

#End Region

#Region "Accounting_Du_Lieu_Quy_CN55_Them"
        Public Function Accounting_Du_Lieu_Quy_CN55_Them(ByVal Id_Chi_Tiet As String, ByVal Ma_Quy As Integer, ByVal Id_Duong_Thu_Den As String, ByVal Ten_Duong_Thu_Den As String, ByVal Ma_Bc_Den As Integer, ByVal Ma_Bc_KT_Den As Integer, ByVal Ngay_Dong As Integer, ByVal So_CT_Den As Integer, ByVal Loai_CT_Den As String, ByVal Ma_Bc_Tra As Integer, ByVal SL_D_Col_1 As Integer, ByVal SL_M_Col_1 As Integer, ByVal SL_D_Col_2 As Integer, ByVal SL_M_Col_2 As Integer, ByVal SL_D_Col_3 As Integer, ByVal SL_M_Col_3 As Integer, ByVal Ghi_Chu As String, ByVal Is_Mien_Bac As Boolean) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Du_Lieu_Quy_CN55_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myAccounting_Du_Lieu_Quy_CN55_Chi_Tiet As New Accounting_Du_Lieu_Quy_CN55_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Chi_Tiet As SqlParameter = New SqlParameter("@Id_Chi_Tiet", SqlDbType.VarChar, 35)
                pId_Chi_Tiet.Value = Id_Chi_Tiet
                MyCommand.Parameters.Add(pId_Chi_Tiet)

                Dim pMa_Quy As SqlParameter = New SqlParameter("@Ma_Quy", SqlDbType.Int, 0)
                pMa_Quy.Value = Ma_Quy
                MyCommand.Parameters.Add(pMa_Quy)

                Dim pId_Duong_Thu_Den As SqlParameter = New SqlParameter("@Id_Duong_Thu_Den", SqlDbType.VarChar, 14)
                pId_Duong_Thu_Den.Value = Id_Duong_Thu_Den
                MyCommand.Parameters.Add(pId_Duong_Thu_Den)

                Dim pTen_Duong_Thu_Den As SqlParameter = New SqlParameter("@Ten_Duong_Thu_Den", SqlDbType.NVarChar, 150)
                pTen_Duong_Thu_Den.Value = Ten_Duong_Thu_Den
                MyCommand.Parameters.Add(pTen_Duong_Thu_Den)

                Dim pMa_Bc_Den As SqlParameter = New SqlParameter("@Ma_Bc_Den", SqlDbType.Int, 0)
                pMa_Bc_Den.Value = Ma_Bc_Den
                MyCommand.Parameters.Add(pMa_Bc_Den)

                Dim pMa_Bc_KT_Den As SqlParameter = New SqlParameter("@Ma_Bc_KT_Den", SqlDbType.Int, 0)
                pMa_Bc_KT_Den.Value = Ma_Bc_KT_Den
                MyCommand.Parameters.Add(pMa_Bc_KT_Den)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 0)
                pNgay_Dong.Value = Ngay_Dong
                MyCommand.Parameters.Add(pNgay_Dong)

                Dim pSo_CT_Den As SqlParameter = New SqlParameter("@So_CT_Den", SqlDbType.Int, 0)
                pSo_CT_Den.Value = So_CT_Den
                MyCommand.Parameters.Add(pSo_CT_Den)

                Dim pLoai_CT_Den As SqlParameter = New SqlParameter("@Loai_CT_Den", SqlDbType.VarChar, 2)
                pLoai_CT_Den.Value = Loai_CT_Den
                MyCommand.Parameters.Add(pLoai_CT_Den)

                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 0)
                pMa_Bc_Tra.Value = Ma_Bc_Tra
                MyCommand.Parameters.Add(pMa_Bc_Tra)

                Dim pSL_D_Col_1 As SqlParameter = New SqlParameter("@SL_D_Col_1", SqlDbType.Int, 0)
                pSL_D_Col_1.Value = SL_D_Col_1
                MyCommand.Parameters.Add(pSL_D_Col_1)

                Dim pSL_M_Col_1 As SqlParameter = New SqlParameter("@SL_M_Col_1", SqlDbType.Int, 0)
                pSL_M_Col_1.Value = SL_M_Col_1
                MyCommand.Parameters.Add(pSL_M_Col_1)

                Dim pSL_D_Col_2 As SqlParameter = New SqlParameter("@SL_D_Col_2", SqlDbType.Int, 0)
                pSL_D_Col_2.Value = SL_D_Col_2
                MyCommand.Parameters.Add(pSL_D_Col_2)

                Dim pSL_M_Col_2 As SqlParameter = New SqlParameter("@SL_M_Col_2", SqlDbType.Int, 0)
                pSL_M_Col_2.Value = SL_M_Col_2
                MyCommand.Parameters.Add(pSL_M_Col_2)

                Dim pSL_D_Col_3 As SqlParameter = New SqlParameter("@SL_D_Col_3", SqlDbType.Int, 0)
                pSL_D_Col_3.Value = SL_D_Col_3
                MyCommand.Parameters.Add(pSL_D_Col_3)

                Dim pSL_M_Col_3 As SqlParameter = New SqlParameter("@SL_M_Col_3", SqlDbType.Int, 0)
                pSL_M_Col_3.Value = SL_M_Col_3
                MyCommand.Parameters.Add(pSL_M_Col_3)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 50)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pIs_Mien_Bac As SqlParameter = New SqlParameter("@Is_Mien_Bac", SqlDbType.Bit, 0)
                pIs_Mien_Bac.Value = Is_Mien_Bac
                MyCommand.Parameters.Add(pIs_Mien_Bac)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()

                Return numRows
                'Return numRows

            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)

            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()

            End Try
        End Function

#End Region

#Region "Accounting_Du_Lieu_Quy_CN55_Xoa"
        Public Function Accounting_Du_Lieu_Quy_CN55_Xoa(ByVal Id_Chi_Tiet As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Du_Lieu_Quy_CN55_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myAccounting_Du_Lieu_Quy_CN55_Chi_Tiet As New Accounting_Du_Lieu_Quy_CN55_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Chi_Tiet As SqlParameter = New SqlParameter("@Id_Chi_Tiet", SqlDbType.VarChar, 35)
                pId_Chi_Tiet.Value = Id_Chi_Tiet
                MyCommand.Parameters.Add(pId_Chi_Tiet)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()

                Return numRows
                'Return numRows

            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)

            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()

            End Try
        End Function

#End Region

#Region "Accounting_Du_Lieu_Quy_CN55_Tao_Du_Lieu_CN55"
        Public Function Accounting_Du_Lieu_Quy_CN55_Tao_Du_Lieu_CN55(ByVal ma_Quy As Integer, ByVal id_Duong_Thu_Den As String, ByVal ten_Duong_Thu_Den As String, ByVal ma_Bc_Den As Integer, ByVal ma_Bc_KT_Den As Integer, ByVal tu_Ngay_1 As Integer, ByVal den_Ngay_1 As Integer, ByVal tu_Ngay_2 As Integer, ByVal den_Ngay_2 As Integer, ByVal tu_Ngay_3 As Integer, ByVal den_Ngay_3 As Integer, ByVal tu_Ngay As Integer, ByVal den_Ngay As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Du_Lieu_Quy_CN55_Tao_Du_Lieu_CN55"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Ma_Quy", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Quy))
                MyCommand.Parameters.Add(New SqlParameter("@Id_Duong_Thu_Den", SqlDbType.VarChar, 14, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_Duong_Thu_Den))
                MyCommand.Parameters.Add(New SqlParameter("@Ten_Duong_Thu_Den", SqlDbType.NVarChar, 150, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, ten_Duong_Thu_Den))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc_Den", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Bc_Den))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc_KT_Den", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Bc_KT_Den))
                MyCommand.Parameters.Add(New SqlParameter("@Tu_Ngay_1", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, tu_Ngay_1))
                MyCommand.Parameters.Add(New SqlParameter("@Den_Ngay_1", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, den_Ngay_1))
                MyCommand.Parameters.Add(New SqlParameter("@Tu_Ngay_2", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, tu_Ngay_2))
                MyCommand.Parameters.Add(New SqlParameter("@Den_Ngay_2", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, den_Ngay_2))
                MyCommand.Parameters.Add(New SqlParameter("@Tu_Ngay_3", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, tu_Ngay_3))
                MyCommand.Parameters.Add(New SqlParameter("@Den_Ngay_3", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, den_Ngay_3))
                MyCommand.Parameters.Add(New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, tu_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Den_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, den_Ngay))

                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()
                MyCommand.CommandTimeout = 20000

                numRows = MyCommand.ExecuteNonQuery()
                Return numRows
                'return the number of rows affected
            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)

            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()

            End Try
        End Function

#End Region

#Region "Accounting_Du_Lieu_Quy_CN55_Xoa_Boi_Ma_Quy"
        Public Function Accounting_Du_Lieu_Quy_CN55_Xoa_Boi_Ma_Quy(ByVal ma_Quy As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Du_Lieu_Quy_CN55_Xoa_Boi_Ma_Quy"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Ma_Quy", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Quy))

                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                Return numRows
                'return the number of rows affected
            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)

            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()

            End Try
        End Function

#End Region

#Region "Accounting_Du_Lieu_Quy_CN55_Chi_Tiet_To_Print"

        Public Function Accounting_Du_Lieu_Quy_CN55_Chi_Tiet_To_Print(ByVal ma_Quy As Integer, ByVal ma_Bc_Den As Integer, ByVal ma_Bc_KT_Den As Integer, ByVal is_Mien_Bac As Boolean) As DataSet

            ' The procedure returns these columns:
            ' Ngay_Dong
            ' So_CT_Den
            ' Loai_CT_Den
            ' So_Luong_D
            ' So_Luong_M
            ' Ghi_Chu


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Du_Lieu_Quy_CN55_Chi_Tiet_To_Print"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Ma_Quy", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Quy))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc_Den", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Bc_Den))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc_KT_Den", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Bc_KT_Den))
                MyCommand.Parameters.Add(New SqlParameter("@Is_Mien_Bac", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, is_Mien_Bac))

                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                adapter.Fill(MyDataSet)

                Return MyDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                adapter.Dispose()
            End Try
        End Function
#End Region

#Region "Accounting_Du_Lieu_Quy_CN56_Chi_Tiet_To_Print"

        Public Function Accounting_Du_Lieu_Quy_CN56_Chi_Tiet_To_Print(ByVal ma_Quy As Integer, ByVal ma_Nuoc As String, ByVal ma_Bc_KT_Den As Integer, ByVal is_Mien_Bac As Boolean) As DataSet

            ' The procedure returns these columns:
            ' Ma_Bc_Den
            ' Ten_Duong_Thu_Den
            ' Loai_CT_Den
            ' Ma_Bc_KT_Den
            ' Ten_Ma_Bc_KT_Den
            ' SL_D_Col_1
            ' SL_M_Col_1
            ' SL_D_Col_2
            ' SL_M_Col_2
            ' SL_D_Col_3
            ' SL_M_Col_3


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Du_Lieu_Quy_CN56_Chi_Tiet_To_Print"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Ma_Quy", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Quy))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, ma_Nuoc))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc_KT_Den", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Bc_KT_Den))
                MyCommand.Parameters.Add(New SqlParameter("@Is_Mien_Bac", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, is_Mien_Bac))

                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                adapter.Fill(MyDataSet)

                Return MyDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                adapter.Dispose()
            End Try
        End Function
#End Region

    End Class
#End Region
End Namespace


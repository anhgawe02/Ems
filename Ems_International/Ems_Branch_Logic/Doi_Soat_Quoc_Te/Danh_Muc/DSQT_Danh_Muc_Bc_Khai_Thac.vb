
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "DSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop DSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet
    'Tuong ung voi moi truong trong bang DSQT_Danh_Muc_Bc_Khai_Thac trong co so du lieu
    '***********************************************************
    Public Class DSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet
        Public Ma_Bc_Khai_Thac As Integer
        Public Ten_Buu_Cuc As String
        Public Ma_Nuoc As String
        Public Ma_Vung As String
        Public IMPC As String
        Public Phan_Loai As Integer
        Public Quoc_Te_Den As Boolean
        Public Ghi_Chu As String
        Public Truong_Don_Vi As String
        Public Ten_Tren_Bao_Cao As String
    End Class
#End Region

#Region "DSQT_Danh_Muc_Bc_Khai_Thac"
    Public Class DSQT_Danh_Muc_Bc_Khai_Thac
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "DSQT_Danh_Muc_Bc_Khai_Thac_Cap_Nhat"
        Public Function DSQT_Danh_Muc_Bc_Khai_Thac_Cap_Nhat(ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ten_Buu_Cuc As String, ByVal Ma_Nuoc As String, ByVal Ma_Vung As String, ByVal IMPC As String, ByVal Phan_Loai As Integer, ByVal Quoc_Te_Den As Boolean, ByVal Ghi_Chu As String, ByVal Truong_Don_Vi As String, ByVal Ten_Tren_Bao_Cao As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Bc_Khai_Thac_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet As New DSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pTen_Buu_Cuc As SqlParameter = New SqlParameter("@Ten_Buu_Cuc", SqlDbType.NVarChar, 100)
                pTen_Buu_Cuc.Value = Ten_Buu_Cuc
                MyCommand.Parameters.Add(pTen_Buu_Cuc)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pMa_Vung As SqlParameter = New SqlParameter("@Ma_Vung", SqlDbType.VarChar, 3)
                pMa_Vung.Value = Ma_Vung
                MyCommand.Parameters.Add(pMa_Vung)

                Dim pIMPC As SqlParameter = New SqlParameter("@IMPC", SqlDbType.VarChar, 6)
                pIMPC.Value = IMPC
                MyCommand.Parameters.Add(pIMPC)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.Int, 0)
                pPhan_Loai.Value = Phan_Loai
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pQuoc_Te_Den As SqlParameter = New SqlParameter("@Quoc_Te_Den", SqlDbType.Bit, 0)
                pQuoc_Te_Den.Value = Quoc_Te_Den
                MyCommand.Parameters.Add(pQuoc_Te_Den)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pTruong_Don_Vi As SqlParameter = New SqlParameter("@Truong_Don_Vi", SqlDbType.NVarChar, 50)
                pTruong_Don_Vi.Value = Truong_Don_Vi
                MyCommand.Parameters.Add(pTruong_Don_Vi)

                Dim pTen_Tren_Bao_Cao As SqlParameter = New SqlParameter("@Ten_Tren_Bao_Cao", SqlDbType.NVarChar, 200)
                pTen_Tren_Bao_Cao.Value = Ten_Tren_Bao_Cao
                MyCommand.Parameters.Add(pTen_Tren_Bao_Cao)


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

#Region "DSQT_Danh_Muc_Bc_Khai_Thac_Cap_Nhat_Them"
        Public Function DSQT_Danh_Muc_Bc_Khai_Thac_Cap_Nhat_Them(ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ten_Buu_Cuc As String, ByVal Ma_Nuoc As String, ByVal Ma_Vung As String, ByVal IMPC As String, ByVal Phan_Loai As Integer, ByVal Quoc_Te_Den As Boolean, ByVal Ghi_Chu As String, ByVal Truong_Don_Vi As String, ByVal Ten_Tren_Bao_Cao As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Bc_Khai_Thac_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet As New DSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pTen_Buu_Cuc As SqlParameter = New SqlParameter("@Ten_Buu_Cuc", SqlDbType.NVarChar, 100)
                pTen_Buu_Cuc.Value = Ten_Buu_Cuc
                MyCommand.Parameters.Add(pTen_Buu_Cuc)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pMa_Vung As SqlParameter = New SqlParameter("@Ma_Vung", SqlDbType.VarChar, 3)
                pMa_Vung.Value = Ma_Vung
                MyCommand.Parameters.Add(pMa_Vung)

                Dim pIMPC As SqlParameter = New SqlParameter("@IMPC", SqlDbType.VarChar, 6)
                pIMPC.Value = IMPC
                MyCommand.Parameters.Add(pIMPC)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.Int, 0)
                pPhan_Loai.Value = Phan_Loai
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pQuoc_Te_Den As SqlParameter = New SqlParameter("@Quoc_Te_Den", SqlDbType.Bit, 0)
                pQuoc_Te_Den.Value = Quoc_Te_Den
                MyCommand.Parameters.Add(pQuoc_Te_Den)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pTruong_Don_Vi As SqlParameter = New SqlParameter("@Truong_Don_Vi", SqlDbType.NVarChar, 50)
                pTruong_Don_Vi.Value = Truong_Don_Vi
                MyCommand.Parameters.Add(pTruong_Don_Vi)

                Dim pTen_Tren_Bao_Cao As SqlParameter = New SqlParameter("@Ten_Tren_Bao_Cao", SqlDbType.NVarChar, 200)
                pTen_Tren_Bao_Cao.Value = Ten_Tren_Bao_Cao
                MyCommand.Parameters.Add(pTen_Tren_Bao_Cao)


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


#Region "DSQT_Danh_Muc_Bc_Khai_Thac_Danh_Sach"

        Public Function DSQT_Danh_Muc_Bc_Khai_Thac_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Ma_Bc_Khai_Thac
            ' Ten_Buu_Cuc
            ' Ma_Nuoc
            ' Ma_Vung
            ' IMPC
            ' Phan_Loai
            ' Quoc_Te_Den
            ' Ghi_Chu
            ' Truong_Don_Vi
            ' Ten_Tren_Bao_Cao


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Bc_Khai_Thac_Danh_Sach"
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

#Region "DSQT_Danh_Muc_Bc_Khai_Thac_Lay"
        Public Function DSQT_Danh_Muc_Bc_Khai_Thac_Lay(ByVal Ma_Bc_Khai_Thac As Integer) As DSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Bc_Khai_Thac_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet As New DSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pTen_Buu_Cuc As SqlParameter = New SqlParameter("@Ten_Buu_Cuc", SqlDbType.NVarChar, 100)
                pTen_Buu_Cuc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTen_Buu_Cuc)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pMa_Vung As SqlParameter = New SqlParameter("@Ma_Vung", SqlDbType.VarChar, 3)
                pMa_Vung.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Vung)

                Dim pIMPC As SqlParameter = New SqlParameter("@IMPC", SqlDbType.VarChar, 6)
                pIMPC.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pIMPC)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.Int, 0)
                pPhan_Loai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pQuoc_Te_Den As SqlParameter = New SqlParameter("@Quoc_Te_Den", SqlDbType.Bit, 0)
                pQuoc_Te_Den.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pQuoc_Te_Den)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
                pGhi_Chu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pTruong_Don_Vi As SqlParameter = New SqlParameter("@Truong_Don_Vi", SqlDbType.NVarChar, 50)
                pTruong_Don_Vi.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTruong_Don_Vi)

                Dim pTen_Tren_Bao_Cao As SqlParameter = New SqlParameter("@Ten_Tren_Bao_Cao", SqlDbType.NVarChar, 200)
                pTen_Tren_Bao_Cao.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTen_Tren_Bao_Cao)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myDSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet.Ma_Bc_Khai_Thac = Ma_Bc_Khai_Thac
                myDSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet.Ten_Buu_Cuc = pTen_Buu_Cuc.Value
                myDSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet.Ma_Nuoc = pMa_Nuoc.Value
                myDSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet.Ma_Vung = pMa_Vung.Value
                myDSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet.IMPC = pIMPC.Value
                myDSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet.Phan_Loai = pPhan_Loai.Value
                myDSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet.Quoc_Te_Den = pQuoc_Te_Den.Value
                myDSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value
                myDSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet.Truong_Don_Vi = pTruong_Don_Vi.Value
                myDSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet.Ten_Tren_Bao_Cao = pTen_Tren_Bao_Cao.Value

                Return myDSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet
                'Return myDSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet

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

#Region "DSQT_Danh_Muc_Bc_Khai_Thac_Them"
        Public Function DSQT_Danh_Muc_Bc_Khai_Thac_Them(ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ten_Buu_Cuc As String, ByVal Ma_Nuoc As String, ByVal Ma_Vung As String, ByVal IMPC As String, ByVal Phan_Loai As Integer, ByVal Quoc_Te_Den As Boolean, ByVal Ghi_Chu As String, ByVal Truong_Don_Vi As String, ByVal Ten_Tren_Bao_Cao As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Bc_Khai_Thac_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet As New DSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pTen_Buu_Cuc As SqlParameter = New SqlParameter("@Ten_Buu_Cuc", SqlDbType.NVarChar, 100)
                pTen_Buu_Cuc.Value = Ten_Buu_Cuc
                MyCommand.Parameters.Add(pTen_Buu_Cuc)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pMa_Vung As SqlParameter = New SqlParameter("@Ma_Vung", SqlDbType.VarChar, 3)
                pMa_Vung.Value = Ma_Vung
                MyCommand.Parameters.Add(pMa_Vung)

                Dim pIMPC As SqlParameter = New SqlParameter("@IMPC", SqlDbType.VarChar, 6)
                pIMPC.Value = IMPC
                MyCommand.Parameters.Add(pIMPC)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.Int, 0)
                pPhan_Loai.Value = Phan_Loai
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pQuoc_Te_Den As SqlParameter = New SqlParameter("@Quoc_Te_Den", SqlDbType.Bit, 0)
                pQuoc_Te_Den.Value = Quoc_Te_Den
                MyCommand.Parameters.Add(pQuoc_Te_Den)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pTruong_Don_Vi As SqlParameter = New SqlParameter("@Truong_Don_Vi", SqlDbType.NVarChar, 50)
                pTruong_Don_Vi.Value = Truong_Don_Vi
                MyCommand.Parameters.Add(pTruong_Don_Vi)

                Dim pTen_Tren_Bao_Cao As SqlParameter = New SqlParameter("@Ten_Tren_Bao_Cao", SqlDbType.NVarChar, 200)
                pTen_Tren_Bao_Cao.Value = Ten_Tren_Bao_Cao
                MyCommand.Parameters.Add(pTen_Tren_Bao_Cao)


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

#Region "DSQT_Danh_Muc_Bc_Khai_Thac_Xoa"
        Public Function DSQT_Danh_Muc_Bc_Khai_Thac_Xoa(ByVal Ma_Bc_Khai_Thac As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Bc_Khai_Thac_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet As New DSQT_Danh_Muc_Bc_Khai_Thac_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)


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


    End Class
#End Region
End Namespace


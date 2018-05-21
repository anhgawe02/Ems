
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "DSQT_Danh_Muc_Tien_Te_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop DSQT_Danh_Muc_Tien_Te_Chi_Tiet
    'Tuong ung voi moi truong trong bang DSQT_Danh_Muc_Tien_Te trong co so du lieu
    '***********************************************************
    Public Class DSQT_Danh_Muc_Tien_Te_Chi_Tiet
        Public Ma_Tien_Te As String
        Public Ten_Tien_Te As String
        Public Ghi_Chu As String
    End Class
#End Region

#Region "DSQT_Danh_Muc_Tien_Te"
    Public Class DSQT_Danh_Muc_Tien_Te
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "DSQT_Danh_Muc_Tien_Te_Cap_Nhat"
        Public Function DSQT_Danh_Muc_Tien_Te_Cap_Nhat(ByVal Ma_Tien_Te As String, ByVal Ten_Tien_Te As String, ByVal Ghi_Chu As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Tien_Te_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Danh_Muc_Tien_Te_Chi_Tiet As New DSQT_Danh_Muc_Tien_Te_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_Tien_Te As SqlParameter = New SqlParameter("@Ma_Tien_Te", SqlDbType.VarChar, 5)
                pMa_Tien_Te.Value = Ma_Tien_Te
                MyCommand.Parameters.Add(pMa_Tien_Te)

                Dim pTen_Tien_Te As SqlParameter = New SqlParameter("@Ten_Tien_Te", SqlDbType.VarChar, 100)
                pTen_Tien_Te.Value = Ten_Tien_Te
                MyCommand.Parameters.Add(pTen_Tien_Te)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 500)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)


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

#Region "DSQT_Danh_Muc_Tien_Te_Cap_Nhat_Them"
        Public Function DSQT_Danh_Muc_Tien_Te_Cap_Nhat_Them(ByVal Ma_Tien_Te As String, ByVal Ten_Tien_Te As String, ByVal Ghi_Chu As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Tien_Te_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Danh_Muc_Tien_Te_Chi_Tiet As New DSQT_Danh_Muc_Tien_Te_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_Tien_Te As SqlParameter = New SqlParameter("@Ma_Tien_Te", SqlDbType.VarChar, 5)
                pMa_Tien_Te.Value = Ma_Tien_Te
                MyCommand.Parameters.Add(pMa_Tien_Te)

                Dim pTen_Tien_Te As SqlParameter = New SqlParameter("@Ten_Tien_Te", SqlDbType.VarChar, 100)
                pTen_Tien_Te.Value = Ten_Tien_Te
                MyCommand.Parameters.Add(pTen_Tien_Te)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 500)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)


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


#Region "DSQT_Danh_Muc_Tien_Te_Danh_Sach"

        Public Function DSQT_Danh_Muc_Tien_Te_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Ma_Tien_Te
            ' Ten_Tien_Te
            ' Ghi_Chu


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Tien_Te_Danh_Sach"
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

#Region "DSQT_Danh_Muc_Tien_Te_Lay"
        Public Function DSQT_Danh_Muc_Tien_Te_Lay(ByVal Ma_Tien_Te As String) As DSQT_Danh_Muc_Tien_Te_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Tien_Te_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Danh_Muc_Tien_Te_Chi_Tiet As New DSQT_Danh_Muc_Tien_Te_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_Tien_Te As SqlParameter = New SqlParameter("@Ma_Tien_Te", SqlDbType.VarChar, 5)
                pMa_Tien_Te.Value = Ma_Tien_Te
                MyCommand.Parameters.Add(pMa_Tien_Te)

                Dim pTen_Tien_Te As SqlParameter = New SqlParameter("@Ten_Tien_Te", SqlDbType.VarChar, 100)
                pTen_Tien_Te.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTen_Tien_Te)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 500)
                pGhi_Chu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGhi_Chu)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myDSQT_Danh_Muc_Tien_Te_Chi_Tiet.Ma_Tien_Te = Ma_Tien_Te
                myDSQT_Danh_Muc_Tien_Te_Chi_Tiet.Ten_Tien_Te = pTen_Tien_Te.Value
                myDSQT_Danh_Muc_Tien_Te_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value

                Return myDSQT_Danh_Muc_Tien_Te_Chi_Tiet
                'Return myDSQT_Danh_Muc_Tien_Te_Chi_Tiet

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

#Region "DSQT_Danh_Muc_Tien_Te_Them"
        Public Function DSQT_Danh_Muc_Tien_Te_Them(ByVal Ma_Tien_Te As String, ByVal Ten_Tien_Te As String, ByVal Ghi_Chu As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Tien_Te_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Danh_Muc_Tien_Te_Chi_Tiet As New DSQT_Danh_Muc_Tien_Te_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_Tien_Te As SqlParameter = New SqlParameter("@Ma_Tien_Te", SqlDbType.VarChar, 5)
                pMa_Tien_Te.Value = Ma_Tien_Te
                MyCommand.Parameters.Add(pMa_Tien_Te)

                Dim pTen_Tien_Te As SqlParameter = New SqlParameter("@Ten_Tien_Te", SqlDbType.VarChar, 100)
                pTen_Tien_Te.Value = Ten_Tien_Te
                MyCommand.Parameters.Add(pTen_Tien_Te)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 500)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)


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

#Region "DSQT_Danh_Muc_Tien_Te_Xoa"
        Public Function DSQT_Danh_Muc_Tien_Te_Xoa(ByVal Ma_Tien_Te As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Tien_Te_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Danh_Muc_Tien_Te_Chi_Tiet As New DSQT_Danh_Muc_Tien_Te_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_Tien_Te As SqlParameter = New SqlParameter("@Ma_Tien_Te", SqlDbType.VarChar, 5)
                pMa_Tien_Te.Value = Ma_Tien_Te
                MyCommand.Parameters.Add(pMa_Tien_Te)


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


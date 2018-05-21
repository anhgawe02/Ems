
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "Accounting_Ma_Nuoc_CN55_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop Accounting_Ma_Nuoc_CN55_Chi_Tiet
    'Tuong ung voi moi truong trong bang Accounting_Ma_Nuoc_CN55 trong co so du lieu
    '***********************************************************
    Public Class Accounting_Ma_Nuoc_CN55_Chi_Tiet
        Public Ma_Nuoc As String
        Public Ten_Nuoc As String
    End Class
#End Region

#Region "Accounting_Ma_Nuoc_CN55"
    Public Class Accounting_Ma_Nuoc_CN55
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "Accounting_Ma_Nuoc_CN55_Cap_Nhat"
        Public Function Accounting_Ma_Nuoc_CN55_Cap_Nhat(ByVal Ma_Nuoc As String, ByVal Ten_Nuoc As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Ma_Nuoc_CN55_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myAccounting_Ma_Nuoc_CN55_Chi_Tiet As New Accounting_Ma_Nuoc_CN55_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pTen_Nuoc As SqlParameter = New SqlParameter("@Ten_Nuoc", SqlDbType.NVarChar, 50)
                pTen_Nuoc.Value = Ten_Nuoc
                MyCommand.Parameters.Add(pTen_Nuoc)


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

#Region "Accounting_Ma_Nuoc_CN55_Cap_Nhat_Them"
        Public Function Accounting_Ma_Nuoc_CN55_Cap_Nhat_Them(ByVal Ma_Nuoc As String, ByVal Ten_Nuoc As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Ma_Nuoc_CN55_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myAccounting_Ma_Nuoc_CN55_Chi_Tiet As New Accounting_Ma_Nuoc_CN55_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pTen_Nuoc As SqlParameter = New SqlParameter("@Ten_Nuoc", SqlDbType.NVarChar, 50)
                pTen_Nuoc.Value = Ten_Nuoc
                MyCommand.Parameters.Add(pTen_Nuoc)


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


#Region "Accounting_Ma_Nuoc_CN55_Danh_Sach"

        Public Function Accounting_Ma_Nuoc_CN55_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Ma_Nuoc
            ' Ten_Nuoc


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Ma_Nuoc_CN55_Danh_Sach"
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

#Region "Accounting_Ma_Nuoc_CN55_Lay"
        Public Function Accounting_Ma_Nuoc_CN55_Lay(ByVal Ma_Nuoc As String) As Accounting_Ma_Nuoc_CN55_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Ma_Nuoc_CN55_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myAccounting_Ma_Nuoc_CN55_Chi_Tiet As New Accounting_Ma_Nuoc_CN55_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pTen_Nuoc As SqlParameter = New SqlParameter("@Ten_Nuoc", SqlDbType.NVarChar, 50)
                pTen_Nuoc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTen_Nuoc)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myAccounting_Ma_Nuoc_CN55_Chi_Tiet.Ma_Nuoc = Ma_Nuoc
                myAccounting_Ma_Nuoc_CN55_Chi_Tiet.Ten_Nuoc = pTen_Nuoc.Value

                Return myAccounting_Ma_Nuoc_CN55_Chi_Tiet
                'Return myAccounting_Ma_Nuoc_CN55_Chi_Tiet

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

#Region "Accounting_Ma_Nuoc_CN55_Them"
        Public Function Accounting_Ma_Nuoc_CN55_Them(ByVal Ma_Nuoc As String, ByVal Ten_Nuoc As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Ma_Nuoc_CN55_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myAccounting_Ma_Nuoc_CN55_Chi_Tiet As New Accounting_Ma_Nuoc_CN55_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pTen_Nuoc As SqlParameter = New SqlParameter("@Ten_Nuoc", SqlDbType.NVarChar, 50)
                pTen_Nuoc.Value = Ten_Nuoc
                MyCommand.Parameters.Add(pTen_Nuoc)


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

#Region "Accounting_Ma_Nuoc_CN55_Xoa"
        Public Function Accounting_Ma_Nuoc_CN55_Xoa(ByVal Ma_Nuoc As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Ma_Nuoc_CN55_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myAccounting_Ma_Nuoc_CN55_Chi_Tiet As New Accounting_Ma_Nuoc_CN55_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                MyCommand.Parameters.Add(pMa_Nuoc)


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


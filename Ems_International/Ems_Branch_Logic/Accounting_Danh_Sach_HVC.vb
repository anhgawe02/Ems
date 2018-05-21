
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "Accounting_Danh_Sach_HVC_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop Accounting_Danh_Sach_HVC_Chi_Tiet
    'Tuong ung voi moi truong trong bang Accounting_Danh_Sach_HVC trong co so du lieu
    '***********************************************************
    Public Class Accounting_Danh_Sach_HVC_Chi_Tiet
        Public HVC As String
        Public Ten_HVC As String
        Public Ghi_Chu As String
    End Class
#End Region

#Region "Accounting_Danh_Sach_HVC"
    Public Class Accounting_Danh_Sach_HVC
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "Accounting_Danh_Sach_HVC_Cap_Nhat_Them"
        Public Function Accounting_Danh_Sach_HVC_Cap_Nhat_Them(ByVal HVC As String, ByVal Ten_HVC As String, ByVal Ghi_Chu As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Danh_Sach_HVC_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myAccounting_Danh_Sach_HVC_Chi_Tiet As New Accounting_Danh_Sach_HVC_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pHVC As SqlParameter = New SqlParameter("@HVC", SqlDbType.VarChar, 50)
                pHVC.Value = HVC
                MyCommand.Parameters.Add(pHVC)

                Dim pTen_HVC As SqlParameter = New SqlParameter("@Ten_HVC", SqlDbType.NVarChar, 200)
                pTen_HVC.Value = Ten_HVC
                MyCommand.Parameters.Add(pTen_HVC)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
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


#Region "Accounting_Danh_Sach_HVC_Danh_Sach"

        Public Function Accounting_Danh_Sach_HVC_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' HVC
            ' Ten_HVC
            ' Ghi_Chu


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Danh_Sach_HVC_Danh_Sach"
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

#Region "Accounting_Danh_Sach_HVC_Lay"
        Public Function Accounting_Danh_Sach_HVC_Lay(ByVal HVC As String) As Accounting_Danh_Sach_HVC_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Danh_Sach_HVC_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myAccounting_Danh_Sach_HVC_Chi_Tiet As New Accounting_Danh_Sach_HVC_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pHVC As SqlParameter = New SqlParameter("@HVC", SqlDbType.VarChar, 50)
                pHVC.Value = HVC
                MyCommand.Parameters.Add(pHVC)

                Dim pTen_HVC As SqlParameter = New SqlParameter("@Ten_HVC", SqlDbType.NVarChar, 200)
                pTen_HVC.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTen_HVC)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
                pGhi_Chu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGhi_Chu)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myAccounting_Danh_Sach_HVC_Chi_Tiet.HVC = HVC
                myAccounting_Danh_Sach_HVC_Chi_Tiet.Ten_HVC = pTen_HVC.Value
                myAccounting_Danh_Sach_HVC_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value

                Return myAccounting_Danh_Sach_HVC_Chi_Tiet
                'Return myAccounting_Danh_Sach_HVC_Chi_Tiet

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

#Region "Accounting_Danh_Sach_HVC_Xoa"
        Public Function Accounting_Danh_Sach_HVC_Xoa(ByVal HVC As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Danh_Sach_HVC_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myAccounting_Danh_Sach_HVC_Chi_Tiet As New Accounting_Danh_Sach_HVC_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pHVC As SqlParameter = New SqlParameter("@HVC", SqlDbType.VarChar, 50)
                pHVC.Value = HVC
                MyCommand.Parameters.Add(pHVC)


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

#Region "Danh_Muc_Chuyen_Bay_Danh_Sach_HVC"

        Public Function Danh_Muc_Chuyen_Bay_Danh_Sach_HVC() As DataSet

            ' The procedure returns these columns:
            ' HVC


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Chuyen_Bay_Danh_Sach_HVC"
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

    End Class
#End Region
End Namespace


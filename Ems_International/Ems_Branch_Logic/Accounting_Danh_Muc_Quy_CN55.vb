
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "Accounting_Danh_Muc_Quy_CN55_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop Accounting_Danh_Muc_Quy_CN55_Chi_Tiet
    'Tuong ung voi moi truong trong bang Accounting_Danh_Muc_Quy_CN55 trong co so du lieu
    '***********************************************************
    Public Class Accounting_Danh_Muc_Quy_CN55_Chi_Tiet
        Public Quarter_Id As Integer
        Public Quarter_Name As String
        Public Column_1 As String
        Public Column_2 As String
        Public Column_3 As String
    End Class
#End Region

#Region "Accounting_Danh_Muc_Quy_CN55"
    Public Class Accounting_Danh_Muc_Quy_CN55
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "Accounting_Danh_Muc_Quy_CN55_Cap_Nhat"
        Public Function Accounting_Danh_Muc_Quy_CN55_Cap_Nhat(ByVal Quarter_Id As Integer, ByVal Quarter_Name As String, ByVal Column_1 As String, ByVal Column_2 As String, ByVal Column_3 As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Danh_Muc_Quy_CN55_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myAccounting_Danh_Muc_Quy_CN55_Chi_Tiet As New Accounting_Danh_Muc_Quy_CN55_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pQuarter_Id As SqlParameter = New SqlParameter("@Quarter_Id", SqlDbType.Int, 0)
                pQuarter_Id.Value = Quarter_Id
                MyCommand.Parameters.Add(pQuarter_Id)

                Dim pQuarter_Name As SqlParameter = New SqlParameter("@Quarter_Name", SqlDbType.NVarChar, 50)
                pQuarter_Name.Value = Quarter_Name
                MyCommand.Parameters.Add(pQuarter_Name)

                Dim pColumn_1 As SqlParameter = New SqlParameter("@Column_1", SqlDbType.VarChar, 10)
                pColumn_1.Value = Column_1
                MyCommand.Parameters.Add(pColumn_1)

                Dim pColumn_2 As SqlParameter = New SqlParameter("@Column_2", SqlDbType.VarChar, 10)
                pColumn_2.Value = Column_2
                MyCommand.Parameters.Add(pColumn_2)

                Dim pColumn_3 As SqlParameter = New SqlParameter("@Column_3", SqlDbType.VarChar, 10)
                pColumn_3.Value = Column_3
                MyCommand.Parameters.Add(pColumn_3)


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

#Region "Accounting_Danh_Muc_Quy_CN55_Cap_Nhat_Them"
        Public Function Accounting_Danh_Muc_Quy_CN55_Cap_Nhat_Them(ByVal Quarter_Id As Integer, ByVal Quarter_Name As String, ByVal Column_1 As String, ByVal Column_2 As String, ByVal Column_3 As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Danh_Muc_Quy_CN55_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myAccounting_Danh_Muc_Quy_CN55_Chi_Tiet As New Accounting_Danh_Muc_Quy_CN55_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pQuarter_Id As SqlParameter = New SqlParameter("@Quarter_Id", SqlDbType.Int, 0)
                pQuarter_Id.Value = Quarter_Id
                MyCommand.Parameters.Add(pQuarter_Id)

                Dim pQuarter_Name As SqlParameter = New SqlParameter("@Quarter_Name", SqlDbType.NVarChar, 50)
                pQuarter_Name.Value = Quarter_Name
                MyCommand.Parameters.Add(pQuarter_Name)

                Dim pColumn_1 As SqlParameter = New SqlParameter("@Column_1", SqlDbType.VarChar, 10)
                pColumn_1.Value = Column_1
                MyCommand.Parameters.Add(pColumn_1)

                Dim pColumn_2 As SqlParameter = New SqlParameter("@Column_2", SqlDbType.VarChar, 10)
                pColumn_2.Value = Column_2
                MyCommand.Parameters.Add(pColumn_2)

                Dim pColumn_3 As SqlParameter = New SqlParameter("@Column_3", SqlDbType.VarChar, 10)
                pColumn_3.Value = Column_3
                MyCommand.Parameters.Add(pColumn_3)


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


#Region "Accounting_Danh_Muc_Quy_CN55_Danh_Sach"

        Public Function Accounting_Danh_Muc_Quy_CN55_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Quarter_Id
            ' Quarter_Name
            ' Column_1
            ' Column_2
            ' Column_3


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Danh_Muc_Quy_CN55_Danh_Sach"
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

#Region "Accounting_Danh_Muc_Quy_CN55_Lay"
        Public Function Accounting_Danh_Muc_Quy_CN55_Lay(ByVal Quarter_Id As Integer) As Accounting_Danh_Muc_Quy_CN55_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Danh_Muc_Quy_CN55_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myAccounting_Danh_Muc_Quy_CN55_Chi_Tiet As New Accounting_Danh_Muc_Quy_CN55_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pQuarter_Id As SqlParameter = New SqlParameter("@Quarter_Id", SqlDbType.Int, 0)
                pQuarter_Id.Value = Quarter_Id
                MyCommand.Parameters.Add(pQuarter_Id)

                Dim pQuarter_Name As SqlParameter = New SqlParameter("@Quarter_Name", SqlDbType.NVarChar, 50)
                pQuarter_Name.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pQuarter_Name)

                Dim pColumn_1 As SqlParameter = New SqlParameter("@Column_1", SqlDbType.VarChar, 10)
                pColumn_1.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pColumn_1)

                Dim pColumn_2 As SqlParameter = New SqlParameter("@Column_2", SqlDbType.VarChar, 10)
                pColumn_2.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pColumn_2)

                Dim pColumn_3 As SqlParameter = New SqlParameter("@Column_3", SqlDbType.VarChar, 10)
                pColumn_3.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pColumn_3)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myAccounting_Danh_Muc_Quy_CN55_Chi_Tiet.Quarter_Id = Quarter_Id
                myAccounting_Danh_Muc_Quy_CN55_Chi_Tiet.Quarter_Name = pQuarter_Name.Value
                myAccounting_Danh_Muc_Quy_CN55_Chi_Tiet.Column_1 = pColumn_1.Value
                myAccounting_Danh_Muc_Quy_CN55_Chi_Tiet.Column_2 = pColumn_2.Value
                myAccounting_Danh_Muc_Quy_CN55_Chi_Tiet.Column_3 = pColumn_3.Value

                Return myAccounting_Danh_Muc_Quy_CN55_Chi_Tiet
                'Return myAccounting_Danh_Muc_Quy_CN55_Chi_Tiet

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

#Region "Accounting_Danh_Muc_Quy_CN55_Them"
        Public Function Accounting_Danh_Muc_Quy_CN55_Them(ByVal Quarter_Id As Integer, ByVal Quarter_Name As String, ByVal Column_1 As String, ByVal Column_2 As String, ByVal Column_3 As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Danh_Muc_Quy_CN55_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myAccounting_Danh_Muc_Quy_CN55_Chi_Tiet As New Accounting_Danh_Muc_Quy_CN55_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pQuarter_Id As SqlParameter = New SqlParameter("@Quarter_Id", SqlDbType.Int, 0)
                pQuarter_Id.Value = Quarter_Id
                MyCommand.Parameters.Add(pQuarter_Id)

                Dim pQuarter_Name As SqlParameter = New SqlParameter("@Quarter_Name", SqlDbType.NVarChar, 50)
                pQuarter_Name.Value = Quarter_Name
                MyCommand.Parameters.Add(pQuarter_Name)

                Dim pColumn_1 As SqlParameter = New SqlParameter("@Column_1", SqlDbType.VarChar, 10)
                pColumn_1.Value = Column_1
                MyCommand.Parameters.Add(pColumn_1)

                Dim pColumn_2 As SqlParameter = New SqlParameter("@Column_2", SqlDbType.VarChar, 10)
                pColumn_2.Value = Column_2
                MyCommand.Parameters.Add(pColumn_2)

                Dim pColumn_3 As SqlParameter = New SqlParameter("@Column_3", SqlDbType.VarChar, 10)
                pColumn_3.Value = Column_3
                MyCommand.Parameters.Add(pColumn_3)


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

#Region "Accounting_Danh_Muc_Quy_CN55_Xoa"
        Public Function Accounting_Danh_Muc_Quy_CN55_Xoa(ByVal Quarter_Id As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Danh_Muc_Quy_CN55_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myAccounting_Danh_Muc_Quy_CN55_Chi_Tiet As New Accounting_Danh_Muc_Quy_CN55_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pQuarter_Id As SqlParameter = New SqlParameter("@Quarter_Id", SqlDbType.Int, 0)
                pQuarter_Id.Value = Quarter_Id
                MyCommand.Parameters.Add(pQuarter_Id)


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


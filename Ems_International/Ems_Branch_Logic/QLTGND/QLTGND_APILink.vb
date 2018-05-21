Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.IO
Imports System.Net.Dns
Imports System.Collections
Imports Ems_International_Logic

Namespace EMS
#Region "QLTGND_APILink_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop QLTGND_APILink_Chi_Tiet
    'Tuong ung voi moi truong trong bang QLTGND_APILink trong co so du lieu
    '***********************************************************
    Public Class QLTGND_APILink_Chi_Tiet
        Public Id As Integer
        Public API_Link As String
        Public UserName As String
        Public Password As String
    End Class
#End Region

#Region "QLTGND_APILink"
    Public Class QLTGND_APILink

        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "QLTGND_APILink_Cap_Nhat_Them"
        Public Function QLTGND_APILink_Cap_Nhat_Them(ByVal Id As Integer, ByVal API_Link As String, ByVal UserName As String, ByVal Password As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_APILink_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_APILink_Chi_Tiet As New QLTGND_APILink_Chi_Tiet
            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId As SqlParameter = New SqlParameter("@Id", SqlDbType.Int, 0)
                pId.Value = Id
                MyCommand.Parameters.Add(pId)

                Dim pAPI_Link As SqlParameter = New SqlParameter("@API_Link", SqlDbType.VarChar, 300)
                pAPI_Link.Value = API_Link
                MyCommand.Parameters.Add(pAPI_Link)

                Dim pUserName As SqlParameter = New SqlParameter("@UserName", SqlDbType.VarChar, 50)
                pUserName.Value = UserName
                MyCommand.Parameters.Add(pUserName)

                Dim pPassword As SqlParameter = New SqlParameter("@Password", SqlDbType.VarChar, 50)
                pPassword.Value = Password
                MyCommand.Parameters.Add(pPassword)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()

                Return numRows
                'Return numRows

            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)
                Return Nothing

            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()

            End Try
        End Function

#End Region

#Region "QLTGND_APILink_Danh_Sach"

        Public Function QLTGND_APILink_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Id
            ' API_Link
            ' UserName
            ' Password


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_APILink_Danh_Sach"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection
            Try
                'Define the parameters


                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                Adapter.Fill(MyDataSet)

                Return MyDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
                Return Nothing
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                Adapter.Dispose()
            End Try
        End Function
#End Region

#Region "QLTGND_APILink_Lay"
        Public Function QLTGND_APILink_Lay() As QLTGND_APILink_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_APILink_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_APILink_Chi_Tiet As New QLTGND_APILink_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters               

                Dim pAPI_Link As SqlParameter = New SqlParameter("@API_Link", SqlDbType.VarChar, 300)
                pAPI_Link.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pAPI_Link)

                Dim pUserName As SqlParameter = New SqlParameter("@UserName", SqlDbType.VarChar, 50)
                pUserName.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pUserName)

                Dim pPassword As SqlParameter = New SqlParameter("@Password", SqlDbType.VarChar, 50)
                pPassword.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPassword)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myQLTGND_APILink_Chi_Tiet.API_Link = pAPI_Link.Value
                myQLTGND_APILink_Chi_Tiet.UserName = pUserName.Value
                myQLTGND_APILink_Chi_Tiet.Password = pPassword.Value

                Return myQLTGND_APILink_Chi_Tiet
                'Return myQLTGND_APILink_Chi_Tiet

            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)
                Return Nothing

            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()

            End Try
        End Function

#End Region

#Region "QLTGND_APILink_Xoa"
        Public Function QLTGND_APILink_Xoa(ByVal Id As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_APILink_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_APILink_Chi_Tiet As New QLTGND_APILink_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId As SqlParameter = New SqlParameter("@Id", SqlDbType.Int, 0)
                pId.Value = Id
                MyCommand.Parameters.Add(pId)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()

                Return numRows
                'Return numRows

            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)
                Return Nothing

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



Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "QLTGND_MAIL_TRIP_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop QLTGND_MAIL_TRIP_Chi_Tiet
    'Tuong ung voi moi truong trong bang QLTGND_MAIL_TRIP trong co so du lieu
    '***********************************************************
    Public Class QLTGND_MAIL_TRIP_Chi_Tiet
        Public ID As Integer
        Public STARTING_PO_ID As Integer
        Public DESTINATION_PO_ID As Integer
        Public MAIL_TRIP_TYPE As String
        Public YEAR As String
        Public MAIL_TRIP_NUMBER As String
        Public OUTGOING_DATE As DateTime
        Public STATUS As String
        Public MAIL_ROUTE_ID As Integer
        Public INCOMING_DATE As DateTime
    End Class
#End Region

#Region "QLTGND_MAIL_TRIP"
    Public Class QLTGND_MAIL_TRIP
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "QLTGND_MAIL_TRIP_Cap_Nhat_Them"
        Public Function QLTGND_MAIL_TRIP_Cap_Nhat_Them(ByVal ID As Integer, ByVal STARTING_PO_ID As Integer, ByVal DESTINATION_PO_ID As Integer, ByVal MAIL_TRIP_TYPE As String, ByVal YEAR As String, ByVal MAIL_TRIP_NUMBER As String, ByVal OUTGOING_DATE As DateTime, ByVal STATUS As String, ByVal MAIL_ROUTE_ID As Integer, ByVal INCOMING_DATE As DateTime) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_MAIL_TRIP_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myQLTGND_MAIL_TRIP_Chi_Tiet As New QLTGND_MAIL_TRIP_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pID As SqlParameter = New SqlParameter("@ID", SqlDbType.Int, 0)
                pID.Value = ID
                MyCommand.Parameters.Add(pID)

                Dim pSTARTING_PO_ID As SqlParameter = New SqlParameter("@STARTING_PO_ID", SqlDbType.Int, 0)
                pSTARTING_PO_ID.Value = STARTING_PO_ID
                MyCommand.Parameters.Add(pSTARTING_PO_ID)

                Dim pDESTINATION_PO_ID As SqlParameter = New SqlParameter("@DESTINATION_PO_ID", SqlDbType.Int, 0)
                pDESTINATION_PO_ID.Value = DESTINATION_PO_ID
                MyCommand.Parameters.Add(pDESTINATION_PO_ID)

                Dim pMAIL_TRIP_TYPE As SqlParameter = New SqlParameter("@MAIL_TRIP_TYPE", SqlDbType.VarChar, 1)
                pMAIL_TRIP_TYPE.Value = MAIL_TRIP_TYPE
                MyCommand.Parameters.Add(pMAIL_TRIP_TYPE)

                Dim pYEAR As SqlParameter = New SqlParameter("@YEAR", SqlDbType.VarChar, 4)
                pYEAR.Value = YEAR
                MyCommand.Parameters.Add(pYEAR)

                Dim pMAIL_TRIP_NUMBER As SqlParameter = New SqlParameter("@MAIL_TRIP_NUMBER", SqlDbType.VarChar, 4)
                pMAIL_TRIP_NUMBER.Value = MAIL_TRIP_NUMBER
                MyCommand.Parameters.Add(pMAIL_TRIP_NUMBER)

                Dim pOUTGOING_DATE As SqlParameter = New SqlParameter("@OUTGOING_DATE", SqlDbType.DateTime, 0)
                pOUTGOING_DATE.Value = OUTGOING_DATE
                MyCommand.Parameters.Add(pOUTGOING_DATE)

                Dim pSTATUS As SqlParameter = New SqlParameter("@STATUS", SqlDbType.VarChar, 1)
                pSTATUS.Value = STATUS
                MyCommand.Parameters.Add(pSTATUS)

                Dim pMAIL_ROUTE_ID As SqlParameter = New SqlParameter("@MAIL_ROUTE_ID", SqlDbType.Int, 0)
                pMAIL_ROUTE_ID.Value = MAIL_ROUTE_ID
                MyCommand.Parameters.Add(pMAIL_ROUTE_ID)

                Dim pINCOMING_DATE As SqlParameter = New SqlParameter("@INCOMING_DATE", SqlDbType.DateTime, 0)
                pINCOMING_DATE.Value = INCOMING_DATE
                MyCommand.Parameters.Add(pINCOMING_DATE)


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


#Region "QLTGND_MAIL_TRIP_Danh_Sach"

        Public Function QLTGND_MAIL_TRIP_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' ID
            ' STARTING_PO_ID
            ' DESTINATION_PO_ID
            ' MAIL_TRIP_TYPE
            ' YEAR
            ' MAIL_TRIP_NUMBER
            ' OUTGOING_DATE
            ' STATUS
            ' MAIL_ROUTE_ID
            ' INCOMING_DATE


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_MAIL_TRIP_Danh_Sach"
            MyCommand.CommandType = CommandType.StoredProcedure
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

#Region "QLTGND_MAIL_TRIP_Lay"
        Public Function QLTGND_MAIL_TRIP_Lay(ByVal ID As Integer) As QLTGND_MAIL_TRIP_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_MAIL_TRIP_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myQLTGND_MAIL_TRIP_Chi_Tiet As New QLTGND_MAIL_TRIP_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pID As SqlParameter = New SqlParameter("@ID", SqlDbType.Int, 0)
                pID.Value = ID
                MyCommand.Parameters.Add(pID)

                Dim pSTARTING_PO_ID As SqlParameter = New SqlParameter("@STARTING_PO_ID", SqlDbType.Int, 0)
                pSTARTING_PO_ID.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSTARTING_PO_ID)

                Dim pDESTINATION_PO_ID As SqlParameter = New SqlParameter("@DESTINATION_PO_ID", SqlDbType.Int, 0)
                pDESTINATION_PO_ID.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDESTINATION_PO_ID)

                Dim pMAIL_TRIP_TYPE As SqlParameter = New SqlParameter("@MAIL_TRIP_TYPE", SqlDbType.VarChar, 1)
                pMAIL_TRIP_TYPE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMAIL_TRIP_TYPE)

                Dim pYEAR As SqlParameter = New SqlParameter("@YEAR", SqlDbType.VarChar, 4)
                pYEAR.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pYEAR)

                Dim pMAIL_TRIP_NUMBER As SqlParameter = New SqlParameter("@MAIL_TRIP_NUMBER", SqlDbType.VarChar, 4)
                pMAIL_TRIP_NUMBER.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMAIL_TRIP_NUMBER)

                Dim pOUTGOING_DATE As SqlParameter = New SqlParameter("@OUTGOING_DATE", SqlDbType.DateTime, 0)
                pOUTGOING_DATE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pOUTGOING_DATE)

                Dim pSTATUS As SqlParameter = New SqlParameter("@STATUS", SqlDbType.VarChar, 1)
                pSTATUS.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSTATUS)

                Dim pMAIL_ROUTE_ID As SqlParameter = New SqlParameter("@MAIL_ROUTE_ID", SqlDbType.Int, 0)
                pMAIL_ROUTE_ID.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMAIL_ROUTE_ID)

                Dim pINCOMING_DATE As SqlParameter = New SqlParameter("@INCOMING_DATE", SqlDbType.DateTime, 0)
                pINCOMING_DATE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pINCOMING_DATE)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myQLTGND_MAIL_TRIP_Chi_Tiet.ID = ID
                myQLTGND_MAIL_TRIP_Chi_Tiet.STARTING_PO_ID = pSTARTING_PO_ID.Value
                myQLTGND_MAIL_TRIP_Chi_Tiet.DESTINATION_PO_ID = pDESTINATION_PO_ID.Value
                myQLTGND_MAIL_TRIP_Chi_Tiet.MAIL_TRIP_TYPE = pMAIL_TRIP_TYPE.Value
                myQLTGND_MAIL_TRIP_Chi_Tiet.YEAR = pYEAR.Value
                myQLTGND_MAIL_TRIP_Chi_Tiet.MAIL_TRIP_NUMBER = pMAIL_TRIP_NUMBER.Value
                myQLTGND_MAIL_TRIP_Chi_Tiet.OUTGOING_DATE = pOUTGOING_DATE.Value
                myQLTGND_MAIL_TRIP_Chi_Tiet.STATUS = pSTATUS.Value
                myQLTGND_MAIL_TRIP_Chi_Tiet.MAIL_ROUTE_ID = pMAIL_ROUTE_ID.Value
                myQLTGND_MAIL_TRIP_Chi_Tiet.INCOMING_DATE = pINCOMING_DATE.Value

                Return myQLTGND_MAIL_TRIP_Chi_Tiet
                'Return myQLTGND_MAIL_TRIP_Chi_Tiet

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

#Region "QLTGND_MAIL_TRIP_Xoa"
        Public Function QLTGND_MAIL_TRIP_Xoa(ByVal ID As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_MAIL_TRIP_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myQLTGND_MAIL_TRIP_Chi_Tiet As New QLTGND_MAIL_TRIP_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pID As SqlParameter = New SqlParameter("@ID", SqlDbType.Int, 0)
                pID.Value = ID
                MyCommand.Parameters.Add(pID)


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


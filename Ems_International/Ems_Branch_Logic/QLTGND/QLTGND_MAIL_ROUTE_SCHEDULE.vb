
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "QLTGND_MAIL_ROUTE_SCHEDULE_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop QLTGND_MAIL_ROUTE_SCHEDULE_Chi_Tiet
    'Tuong ung voi moi truong trong bang QLTGND_MAIL_ROUTE_SCHEDULE trong co so du lieu
    '***********************************************************
    Public Class QLTGND_MAIL_ROUTE_SCHEDULE_Chi_Tiet
        Public ID As Integer
        Public MAIL_ROUNTE_ID As Integer
        Public MAIL_ROUNTE_DETAIL_ID As Integer
        Public OUTGOING_TIME As DateTime
        Public INCOMING_TIME As DateTime
        Public TRANSPORT_TYPE As Integer
        Public WAY As String
        Public FROM_TIME_MINING_PROVINCE As DateTime
        Public FROM_TIME_EXPECTED As DateTime
        Public FROM_TIME_MINING_INTERCITY As DateTime
        Public FROM_TIME_MOVE_PROVICE As DateTime
        Public TIME_TOTAL As String
        Public TO_TIME_MINING_PROVINCE As DateTime
        Public TO_TIME_MOVE_PROVICE As DateTime
    End Class
#End Region

#Region "QLTGND_MAIL_ROUTE_SCHEDULE"
    Public Class QLTGND_MAIL_ROUTE_SCHEDULE
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "QLTGND_MAIL_ROUTE_SCHEDULE_Cap_Nhat_Them"
        Public Function QLTGND_MAIL_ROUTE_SCHEDULE_Cap_Nhat_Them(ByVal ID As Integer, ByVal MAIL_ROUNTE_ID As Integer, ByVal MAIL_ROUNTE_DETAIL_ID As Integer, ByVal OUTGOING_TIME As DateTime, ByVal INCOMING_TIME As DateTime, ByVal TRANSPORT_TYPE As Integer, ByVal WAY As String, ByVal FROM_TIME_MINING_PROVINCE As DateTime, ByVal FROM_TIME_EXPECTED As DateTime, ByVal FROM_TIME_MINING_INTERCITY As DateTime, ByVal FROM_TIME_MOVE_PROVICE As DateTime, ByVal TIME_TOTAL As String, ByVal TO_TIME_MINING_PROVINCE As DateTime, ByVal TO_TIME_MOVE_PROVICE As DateTime) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_MAIL_ROUTE_SCHEDULE_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myQLTGND_MAIL_ROUTE_SCHEDULE_Chi_Tiet As New QLTGND_MAIL_ROUTE_SCHEDULE_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pID As SqlParameter = New SqlParameter("@ID", SqlDbType.Int, 0)
                pID.Value = ID
                MyCommand.Parameters.Add(pID)

                Dim pMAIL_ROUNTE_ID As SqlParameter = New SqlParameter("@MAIL_ROUNTE_ID", SqlDbType.Int, 0)
                pMAIL_ROUNTE_ID.Value = MAIL_ROUNTE_ID
                MyCommand.Parameters.Add(pMAIL_ROUNTE_ID)

                Dim pMAIL_ROUNTE_DETAIL_ID As SqlParameter = New SqlParameter("@MAIL_ROUNTE_DETAIL_ID", SqlDbType.Int, 0)
                pMAIL_ROUNTE_DETAIL_ID.Value = MAIL_ROUNTE_DETAIL_ID
                MyCommand.Parameters.Add(pMAIL_ROUNTE_DETAIL_ID)

                Dim pOUTGOING_TIME As SqlParameter = New SqlParameter("@OUTGOING_TIME", SqlDbType.DateTime, 0)
                pOUTGOING_TIME.Value = OUTGOING_TIME
                MyCommand.Parameters.Add(pOUTGOING_TIME)

                Dim pINCOMING_TIME As SqlParameter = New SqlParameter("@INCOMING_TIME", SqlDbType.DateTime, 0)
                pINCOMING_TIME.Value = INCOMING_TIME
                MyCommand.Parameters.Add(pINCOMING_TIME)

                Dim pTRANSPORT_TYPE As SqlParameter = New SqlParameter("@TRANSPORT_TYPE", SqlDbType.Int, 0)
                pTRANSPORT_TYPE.Value = TRANSPORT_TYPE
                MyCommand.Parameters.Add(pTRANSPORT_TYPE)

                Dim pWAY As SqlParameter = New SqlParameter("@WAY", SqlDbType.VarChar, 1)
                pWAY.Value = WAY
                MyCommand.Parameters.Add(pWAY)

                Dim pFROM_TIME_MINING_PROVINCE As SqlParameter = New SqlParameter("@FROM_TIME_MINING_PROVINCE", SqlDbType.DateTime, 0)
                pFROM_TIME_MINING_PROVINCE.Value = FROM_TIME_MINING_PROVINCE
                MyCommand.Parameters.Add(pFROM_TIME_MINING_PROVINCE)

                Dim pFROM_TIME_EXPECTED As SqlParameter = New SqlParameter("@FROM_TIME_EXPECTED", SqlDbType.DateTime, 0)
                pFROM_TIME_EXPECTED.Value = FROM_TIME_EXPECTED
                MyCommand.Parameters.Add(pFROM_TIME_EXPECTED)

                Dim pFROM_TIME_MINING_INTERCITY As SqlParameter = New SqlParameter("@FROM_TIME_MINING_INTERCITY", SqlDbType.DateTime, 0)
                pFROM_TIME_MINING_INTERCITY.Value = FROM_TIME_MINING_INTERCITY
                MyCommand.Parameters.Add(pFROM_TIME_MINING_INTERCITY)

                Dim pFROM_TIME_MOVE_PROVICE As SqlParameter = New SqlParameter("@FROM_TIME_MOVE_PROVICE", SqlDbType.DateTime, 0)
                pFROM_TIME_MOVE_PROVICE.Value = FROM_TIME_MOVE_PROVICE
                MyCommand.Parameters.Add(pFROM_TIME_MOVE_PROVICE)

                Dim pTIME_TOTAL As SqlParameter = New SqlParameter("@TIME_TOTAL", SqlDbType.VarChar, 40)
                pTIME_TOTAL.Value = TIME_TOTAL
                MyCommand.Parameters.Add(pTIME_TOTAL)

                Dim pTO_TIME_MINING_PROVINCE As SqlParameter = New SqlParameter("@TO_TIME_MINING_PROVINCE", SqlDbType.DateTime, 0)
                pTO_TIME_MINING_PROVINCE.Value = TO_TIME_MINING_PROVINCE
                MyCommand.Parameters.Add(pTO_TIME_MINING_PROVINCE)

                Dim pTO_TIME_MOVE_PROVICE As SqlParameter = New SqlParameter("@TO_TIME_MOVE_PROVICE", SqlDbType.DateTime, 0)
                pTO_TIME_MOVE_PROVICE.Value = TO_TIME_MOVE_PROVICE
                MyCommand.Parameters.Add(pTO_TIME_MOVE_PROVICE)


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


#Region "QLTGND_MAIL_ROUTE_SCHEDULE_Danh_Sach"

        Public Function QLTGND_MAIL_ROUTE_SCHEDULE_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' ID
            ' MAIL_ROUNTE_ID
            ' MAIL_ROUNTE_DETAIL_ID
            ' OUTGOING_TIME
            ' INCOMING_TIME
            ' TRANSPORT_TYPE
            ' WAY
            ' FROM_TIME_MINING_PROVINCE
            ' FROM_TIME_EXPECTED
            ' FROM_TIME_MINING_INTERCITY
            ' FROM_TIME_MOVE_PROVICE
            ' TIME_TOTAL
            ' TO_TIME_MINING_PROVINCE
            ' TO_TIME_MOVE_PROVICE


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_MAIL_ROUTE_SCHEDULE_Danh_Sach"
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

#Region "QLTGND_MAIL_ROUTE_SCHEDULE_Lay"
        Public Function QLTGND_MAIL_ROUTE_SCHEDULE_Lay(ByVal ID As Integer) As QLTGND_MAIL_ROUTE_SCHEDULE_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_MAIL_ROUTE_SCHEDULE_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myQLTGND_MAIL_ROUTE_SCHEDULE_Chi_Tiet As New QLTGND_MAIL_ROUTE_SCHEDULE_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pID As SqlParameter = New SqlParameter("@ID", SqlDbType.Int, 0)
                pID.Value = ID
                MyCommand.Parameters.Add(pID)

                Dim pMAIL_ROUNTE_ID As SqlParameter = New SqlParameter("@MAIL_ROUNTE_ID", SqlDbType.Int, 0)
                pMAIL_ROUNTE_ID.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMAIL_ROUNTE_ID)

                Dim pMAIL_ROUNTE_DETAIL_ID As SqlParameter = New SqlParameter("@MAIL_ROUNTE_DETAIL_ID", SqlDbType.Int, 0)
                pMAIL_ROUNTE_DETAIL_ID.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMAIL_ROUNTE_DETAIL_ID)

                Dim pOUTGOING_TIME As SqlParameter = New SqlParameter("@OUTGOING_TIME", SqlDbType.DateTime, 0)
                pOUTGOING_TIME.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pOUTGOING_TIME)

                Dim pINCOMING_TIME As SqlParameter = New SqlParameter("@INCOMING_TIME", SqlDbType.DateTime, 0)
                pINCOMING_TIME.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pINCOMING_TIME)

                Dim pTRANSPORT_TYPE As SqlParameter = New SqlParameter("@TRANSPORT_TYPE", SqlDbType.Int, 0)
                pTRANSPORT_TYPE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTRANSPORT_TYPE)

                Dim pWAY As SqlParameter = New SqlParameter("@WAY", SqlDbType.VarChar, 1)
                pWAY.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pWAY)

                Dim pFROM_TIME_MINING_PROVINCE As SqlParameter = New SqlParameter("@FROM_TIME_MINING_PROVINCE", SqlDbType.DateTime, 0)
                pFROM_TIME_MINING_PROVINCE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pFROM_TIME_MINING_PROVINCE)

                Dim pFROM_TIME_EXPECTED As SqlParameter = New SqlParameter("@FROM_TIME_EXPECTED", SqlDbType.DateTime, 0)
                pFROM_TIME_EXPECTED.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pFROM_TIME_EXPECTED)

                Dim pFROM_TIME_MINING_INTERCITY As SqlParameter = New SqlParameter("@FROM_TIME_MINING_INTERCITY", SqlDbType.DateTime, 0)
                pFROM_TIME_MINING_INTERCITY.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pFROM_TIME_MINING_INTERCITY)

                Dim pFROM_TIME_MOVE_PROVICE As SqlParameter = New SqlParameter("@FROM_TIME_MOVE_PROVICE", SqlDbType.DateTime, 0)
                pFROM_TIME_MOVE_PROVICE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pFROM_TIME_MOVE_PROVICE)

                Dim pTIME_TOTAL As SqlParameter = New SqlParameter("@TIME_TOTAL", SqlDbType.VarChar, 40)
                pTIME_TOTAL.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTIME_TOTAL)

                Dim pTO_TIME_MINING_PROVINCE As SqlParameter = New SqlParameter("@TO_TIME_MINING_PROVINCE", SqlDbType.DateTime, 0)
                pTO_TIME_MINING_PROVINCE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTO_TIME_MINING_PROVINCE)

                Dim pTO_TIME_MOVE_PROVICE As SqlParameter = New SqlParameter("@TO_TIME_MOVE_PROVICE", SqlDbType.DateTime, 0)
                pTO_TIME_MOVE_PROVICE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTO_TIME_MOVE_PROVICE)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myQLTGND_MAIL_ROUTE_SCHEDULE_Chi_Tiet.ID = ID
                myQLTGND_MAIL_ROUTE_SCHEDULE_Chi_Tiet.MAIL_ROUNTE_ID = pMAIL_ROUNTE_ID.Value
                myQLTGND_MAIL_ROUTE_SCHEDULE_Chi_Tiet.MAIL_ROUNTE_DETAIL_ID = pMAIL_ROUNTE_DETAIL_ID.Value
                myQLTGND_MAIL_ROUTE_SCHEDULE_Chi_Tiet.OUTGOING_TIME = pOUTGOING_TIME.Value
                myQLTGND_MAIL_ROUTE_SCHEDULE_Chi_Tiet.INCOMING_TIME = pINCOMING_TIME.Value
                myQLTGND_MAIL_ROUTE_SCHEDULE_Chi_Tiet.TRANSPORT_TYPE = pTRANSPORT_TYPE.Value
                myQLTGND_MAIL_ROUTE_SCHEDULE_Chi_Tiet.WAY = pWAY.Value
                myQLTGND_MAIL_ROUTE_SCHEDULE_Chi_Tiet.FROM_TIME_MINING_PROVINCE = pFROM_TIME_MINING_PROVINCE.Value
                myQLTGND_MAIL_ROUTE_SCHEDULE_Chi_Tiet.FROM_TIME_EXPECTED = pFROM_TIME_EXPECTED.Value
                myQLTGND_MAIL_ROUTE_SCHEDULE_Chi_Tiet.FROM_TIME_MINING_INTERCITY = pFROM_TIME_MINING_INTERCITY.Value
                myQLTGND_MAIL_ROUTE_SCHEDULE_Chi_Tiet.FROM_TIME_MOVE_PROVICE = pFROM_TIME_MOVE_PROVICE.Value
                myQLTGND_MAIL_ROUTE_SCHEDULE_Chi_Tiet.TIME_TOTAL = pTIME_TOTAL.Value
                myQLTGND_MAIL_ROUTE_SCHEDULE_Chi_Tiet.TO_TIME_MINING_PROVINCE = pTO_TIME_MINING_PROVINCE.Value
                myQLTGND_MAIL_ROUTE_SCHEDULE_Chi_Tiet.TO_TIME_MOVE_PROVICE = pTO_TIME_MOVE_PROVICE.Value

                Return myQLTGND_MAIL_ROUTE_SCHEDULE_Chi_Tiet
                'Return myQLTGND_MAIL_ROUTE_SCHEDULE_Chi_Tiet

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

#Region "QLTGND_MAIL_ROUTE_SCHEDULE_Xoa"
        Public Function QLTGND_MAIL_ROUTE_SCHEDULE_Xoa(ByVal ID As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_MAIL_ROUTE_SCHEDULE_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myQLTGND_MAIL_ROUTE_SCHEDULE_Chi_Tiet As New QLTGND_MAIL_ROUTE_SCHEDULE_Chi_Tiet

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


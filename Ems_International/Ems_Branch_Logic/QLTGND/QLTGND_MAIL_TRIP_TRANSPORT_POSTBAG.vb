
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet
    'Tuong ung voi moi truong trong bang QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG trong co so du lieu
    '***********************************************************
    Public Class QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet
        Public ID As Integer
        Public POST_BAG_INDEX As String
        Public FROM_PO_ID As String
        Public TO_PO_ID As String
        Public MAIL_TRIP_TYPE As String
        Public SERVICE_ID As String
        Public YEAR As String
        Public MAIL_TRIP_NUMBER As String
        Public STATUS As String
        Public BC37_INDEX As String
        Public BC37_FROM_PO_ID As String
        Public BC37_DATE As DateTime
        Public BC37_TO_PO_ID As String
        Public TRANSPORT_TYPE_ID As String
        Public BC37_ORDER As String
        Public CONFIRM_USER As String
        Public CONFIRM_PO_ID As String
        Public CREATE_USER As String
        Public CREATE_PO_ID As String
        Public CONFIRM_DATE As DateTime
        Public POST_BAG_ID As String
        Public BC37_ID As String
        Public TRANSPORT_NUMBER As String
        Public WAY_TYPE As Integer
        Public MAIL_ROUTE_ID As Integer
        Public PARTNER_ID As Integer
        Public ID_CA As Integer
        Public DATE_CA As DateTime
    End Class
#End Region

#Region "QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG"
    Public Class QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Cap_Nhat_Them"
        Public Function QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Cap_Nhat_Them(ByVal ID As Integer, ByVal POST_BAG_INDEX As String, ByVal FROM_PO_ID As String, ByVal TO_PO_ID As String, ByVal MAIL_TRIP_TYPE As String, ByVal SERVICE_ID As String, ByVal YEAR As String, ByVal MAIL_TRIP_NUMBER As String, ByVal STATUS As String, ByVal BC37_INDEX As String, ByVal BC37_FROM_PO_ID As String, ByVal BC37_DATE As DateTime, ByVal BC37_TO_PO_ID As String, ByVal TRANSPORT_TYPE_ID As String, ByVal BC37_ORDER As String, ByVal CONFIRM_USER As String, ByVal CONFIRM_PO_ID As String, ByVal CREATE_USER As String, ByVal CREATE_PO_ID As String, ByVal CONFIRM_DATE As DateTime, ByVal POST_BAG_ID As String, ByVal BC37_ID As String, ByVal TRANSPORT_NUMBER As String, ByVal WAY_TYPE As Integer, ByVal MAIL_ROUTE_ID As Integer, ByVal PARTNER_ID As Integer, ByVal ID_CA As Integer, ByVal DATE_CA As DateTime) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet As New QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pID As SqlParameter = New SqlParameter("@ID", SqlDbType.Int, 0)
                pID.Value = ID
                MyCommand.Parameters.Add(pID)

                Dim pPOST_BAG_INDEX As SqlParameter = New SqlParameter("@POST_BAG_INDEX", SqlDbType.NVarChar, 10)
                pPOST_BAG_INDEX.Value = POST_BAG_INDEX
                MyCommand.Parameters.Add(pPOST_BAG_INDEX)

                Dim pFROM_PO_ID As SqlParameter = New SqlParameter("@FROM_PO_ID", SqlDbType.NVarChar, 10)
                pFROM_PO_ID.Value = FROM_PO_ID
                MyCommand.Parameters.Add(pFROM_PO_ID)

                Dim pTO_PO_ID As SqlParameter = New SqlParameter("@TO_PO_ID", SqlDbType.NVarChar, 10)
                pTO_PO_ID.Value = TO_PO_ID
                MyCommand.Parameters.Add(pTO_PO_ID)

                Dim pMAIL_TRIP_TYPE As SqlParameter = New SqlParameter("@MAIL_TRIP_TYPE", SqlDbType.NVarChar, 15)
                pMAIL_TRIP_TYPE.Value = MAIL_TRIP_TYPE
                MyCommand.Parameters.Add(pMAIL_TRIP_TYPE)

                Dim pSERVICE_ID As SqlParameter = New SqlParameter("@SERVICE_ID", SqlDbType.NVarChar, 20)
                pSERVICE_ID.Value = SERVICE_ID
                MyCommand.Parameters.Add(pSERVICE_ID)

                Dim pYEAR As SqlParameter = New SqlParameter("@YEAR", SqlDbType.NVarChar, 8)
                pYEAR.Value = YEAR
                MyCommand.Parameters.Add(pYEAR)

                Dim pMAIL_TRIP_NUMBER As SqlParameter = New SqlParameter("@MAIL_TRIP_NUMBER", SqlDbType.NVarChar, 10)
                pMAIL_TRIP_NUMBER.Value = MAIL_TRIP_NUMBER
                MyCommand.Parameters.Add(pMAIL_TRIP_NUMBER)

                Dim pSTATUS As SqlParameter = New SqlParameter("@STATUS", SqlDbType.NVarChar, 5)
                pSTATUS.Value = STATUS
                MyCommand.Parameters.Add(pSTATUS)

                Dim pBC37_INDEX As SqlParameter = New SqlParameter("@BC37_INDEX", SqlDbType.NVarChar, 10)
                pBC37_INDEX.Value = BC37_INDEX
                MyCommand.Parameters.Add(pBC37_INDEX)

                Dim pBC37_FROM_PO_ID As SqlParameter = New SqlParameter("@BC37_FROM_PO_ID", SqlDbType.NVarChar, 6)
                pBC37_FROM_PO_ID.Value = BC37_FROM_PO_ID
                MyCommand.Parameters.Add(pBC37_FROM_PO_ID)

                Dim pBC37_DATE As SqlParameter = New SqlParameter("@BC37_DATE", SqlDbType.DateTime, 0)
                pBC37_DATE.Value = BC37_DATE
                MyCommand.Parameters.Add(pBC37_DATE)

                Dim pBC37_TO_PO_ID As SqlParameter = New SqlParameter("@BC37_TO_PO_ID", SqlDbType.NVarChar, 6)
                pBC37_TO_PO_ID.Value = BC37_TO_PO_ID
                MyCommand.Parameters.Add(pBC37_TO_PO_ID)

                Dim pTRANSPORT_TYPE_ID As SqlParameter = New SqlParameter("@TRANSPORT_TYPE_ID", SqlDbType.NVarChar, 6)
                pTRANSPORT_TYPE_ID.Value = TRANSPORT_TYPE_ID
                MyCommand.Parameters.Add(pTRANSPORT_TYPE_ID)

                Dim pBC37_ORDER As SqlParameter = New SqlParameter("@BC37_ORDER", SqlDbType.NVarChar, 10)
                pBC37_ORDER.Value = BC37_ORDER
                MyCommand.Parameters.Add(pBC37_ORDER)

                Dim pCONFIRM_USER As SqlParameter = New SqlParameter("@CONFIRM_USER", SqlDbType.NVarChar, 150)
                pCONFIRM_USER.Value = CONFIRM_USER
                MyCommand.Parameters.Add(pCONFIRM_USER)

                Dim pCONFIRM_PO_ID As SqlParameter = New SqlParameter("@CONFIRM_PO_ID", SqlDbType.NVarChar, 50)
                pCONFIRM_PO_ID.Value = CONFIRM_PO_ID
                MyCommand.Parameters.Add(pCONFIRM_PO_ID)

                Dim pCREATE_USER As SqlParameter = New SqlParameter("@CREATE_USER", SqlDbType.NVarChar, 150)
                pCREATE_USER.Value = CREATE_USER
                MyCommand.Parameters.Add(pCREATE_USER)

                Dim pCREATE_PO_ID As SqlParameter = New SqlParameter("@CREATE_PO_ID", SqlDbType.NVarChar, 50)
                pCREATE_PO_ID.Value = CREATE_PO_ID
                MyCommand.Parameters.Add(pCREATE_PO_ID)

                Dim pCONFIRM_DATE As SqlParameter = New SqlParameter("@CONFIRM_DATE", SqlDbType.DateTime, 0)
                pCONFIRM_DATE.Value = CONFIRM_DATE
                MyCommand.Parameters.Add(pCONFIRM_DATE)

                Dim pPOST_BAG_ID As SqlParameter = New SqlParameter("@POST_BAG_ID", SqlDbType.VarChar, 30)
                pPOST_BAG_ID.Value = POST_BAG_ID
                MyCommand.Parameters.Add(pPOST_BAG_ID)

                Dim pBC37_ID As SqlParameter = New SqlParameter("@BC37_ID", SqlDbType.VarChar, 18)
                pBC37_ID.Value = BC37_ID
                MyCommand.Parameters.Add(pBC37_ID)

                Dim pTRANSPORT_NUMBER As SqlParameter = New SqlParameter("@TRANSPORT_NUMBER", SqlDbType.NVarChar, 30)
                pTRANSPORT_NUMBER.Value = TRANSPORT_NUMBER
                MyCommand.Parameters.Add(pTRANSPORT_NUMBER)

                Dim pWAY_TYPE As SqlParameter = New SqlParameter("@WAY_TYPE", SqlDbType.Int, 0)
                pWAY_TYPE.Value = WAY_TYPE
                MyCommand.Parameters.Add(pWAY_TYPE)

                Dim pMAIL_ROUTE_ID As SqlParameter = New SqlParameter("@MAIL_ROUTE_ID", SqlDbType.Int, 0)
                pMAIL_ROUTE_ID.Value = MAIL_ROUTE_ID
                MyCommand.Parameters.Add(pMAIL_ROUTE_ID)

                Dim pPARTNER_ID As SqlParameter = New SqlParameter("@PARTNER_ID", SqlDbType.Int, 0)
                pPARTNER_ID.Value = PARTNER_ID
                MyCommand.Parameters.Add(pPARTNER_ID)

                Dim pID_CA As SqlParameter = New SqlParameter("@ID_CA", SqlDbType.Int, 0)
                pID_CA.Value = ID_CA
                MyCommand.Parameters.Add(pID_CA)

                Dim pDATE_CA As SqlParameter = New SqlParameter("@DATE_CA", SqlDbType.DateTime, 0)
                pDATE_CA.Value = DATE_CA
                MyCommand.Parameters.Add(pDATE_CA)

                Dim pnumRows As SqlParameter = New SqlParameter("@numRows", SqlDbType.Int, 0)
                pnumRows.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pnumRows)

                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()
                MyCommand.ExecuteNonQuery()
                MyConnection.Close()
                MyConnection.Dispose()

                Return pnumRows.Value
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


#Region "QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Danh_Sach"

        Public Function QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' ID
            ' POST_BAG_INDEX
            ' FROM_PO_ID
            ' TO_PO_ID
            ' MAIL_TRIP_TYPE
            ' SERVICE_ID
            ' YEAR
            ' MAIL_TRIP_NUMBER
            ' STATUS
            ' BC37_INDEX
            ' BC37_FROM_PO_ID
            ' BC37_DATE
            ' BC37_TO_PO_ID
            ' TRANSPORT_TYPE_ID
            ' BC37_ORDER
            ' CONFIRM_USER
            ' CONFIRM_PO_ID
            ' CREATE_USER
            ' CREATE_PO_ID
            ' CONFIRM_DATE
            ' POST_BAG_ID
            ' BC37_ID
            ' TRANSPORT_NUMBER


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Danh_Sach"
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

#Region "QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Danh_Sach_Theo_BC37_ID_Truyen"

        Public Function QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Danh_Sach_Theo_BC37_ID_Truyen(ByVal BC37_ID As String, ByVal WAY_TYPE As Integer) As DataSet

            ' The procedure returns these columns:
            ' ID
            ' POST_BAG_INDEX
            ' FROM_PO_ID
            ' TO_PO_ID
            ' MAIL_TRIP_TYPE
            ' SERVICE_ID
            ' YEAR
            ' MAIL_TRIP_NUMBER
            ' STATUS
            ' BC37_INDEX
            ' BC37_FROM_PO_ID
            ' BC37_DATE
            ' BC37_TO_PO_ID
            ' TRANSPORT_TYPE_ID
            ' BC37_ORDER
            ' CONFIRM_USER
            ' CONFIRM_PO_ID
            ' CREATE_USER
            ' CREATE_PO_ID
            ' CONFIRM_DATE
            ' POST_BAG_ID
            ' BC37_ID
            ' pTRANSPORT_NUMBER


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Danh_Sach_Theo_BC37_ID_Truyen"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters
                Dim pBC37_ID As SqlParameter = New SqlParameter("@BC37_ID", SqlDbType.NVarChar, 18)
                pBC37_ID.Value = BC37_ID
                MyCommand.Parameters.Add(pBC37_ID)

                Dim pWAY_TYPE As SqlParameter = New SqlParameter("@WAY_TYPE", SqlDbType.Int, 4)
                pWAY_TYPE.Value = WAY_TYPE
                MyCommand.Parameters.Add(pWAY_TYPE)

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

#Region "QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Lay"
        Public Function QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Lay(ByVal ID As Integer) As QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet As New QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pID As SqlParameter = New SqlParameter("@ID", SqlDbType.Int, 0)
                pID.Value = ID
                MyCommand.Parameters.Add(pID)

                Dim pPOST_BAG_INDEX As SqlParameter = New SqlParameter("@POST_BAG_INDEX", SqlDbType.NVarChar, 10)
                pPOST_BAG_INDEX.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPOST_BAG_INDEX)

                Dim pFROM_PO_ID As SqlParameter = New SqlParameter("@FROM_PO_ID", SqlDbType.NVarChar, 10)
                pFROM_PO_ID.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pFROM_PO_ID)

                Dim pTO_PO_ID As SqlParameter = New SqlParameter("@TO_PO_ID", SqlDbType.NVarChar, 10)
                pTO_PO_ID.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTO_PO_ID)

                Dim pMAIL_TRIP_TYPE As SqlParameter = New SqlParameter("@MAIL_TRIP_TYPE", SqlDbType.NVarChar, 15)
                pMAIL_TRIP_TYPE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMAIL_TRIP_TYPE)

                Dim pSERVICE_ID As SqlParameter = New SqlParameter("@SERVICE_ID", SqlDbType.NVarChar, 20)
                pSERVICE_ID.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSERVICE_ID)

                Dim pYEAR As SqlParameter = New SqlParameter("@YEAR", SqlDbType.NVarChar, 8)
                pYEAR.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pYEAR)

                Dim pMAIL_TRIP_NUMBER As SqlParameter = New SqlParameter("@MAIL_TRIP_NUMBER", SqlDbType.NVarChar, 10)
                pMAIL_TRIP_NUMBER.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMAIL_TRIP_NUMBER)

                Dim pSTATUS As SqlParameter = New SqlParameter("@STATUS", SqlDbType.NVarChar, 5)
                pSTATUS.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSTATUS)

                Dim pBC37_INDEX As SqlParameter = New SqlParameter("@BC37_INDEX", SqlDbType.NVarChar, 10)
                pBC37_INDEX.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pBC37_INDEX)

                Dim pBC37_FROM_PO_ID As SqlParameter = New SqlParameter("@BC37_FROM_PO_ID", SqlDbType.NVarChar, 6)
                pBC37_FROM_PO_ID.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pBC37_FROM_PO_ID)

                Dim pBC37_DATE As SqlParameter = New SqlParameter("@BC37_DATE", SqlDbType.DateTime, 0)
                pBC37_DATE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pBC37_DATE)

                Dim pBC37_TO_PO_ID As SqlParameter = New SqlParameter("@BC37_TO_PO_ID", SqlDbType.NVarChar, 6)
                pBC37_TO_PO_ID.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pBC37_TO_PO_ID)

                Dim pTRANSPORT_TYPE_ID As SqlParameter = New SqlParameter("@TRANSPORT_TYPE_ID", SqlDbType.NVarChar, 6)
                pTRANSPORT_TYPE_ID.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTRANSPORT_TYPE_ID)

                Dim pBC37_ORDER As SqlParameter = New SqlParameter("@BC37_ORDER", SqlDbType.NVarChar, 10)
                pBC37_ORDER.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pBC37_ORDER)

                Dim pCONFIRM_USER As SqlParameter = New SqlParameter("@CONFIRM_USER", SqlDbType.NVarChar, 150)
                pCONFIRM_USER.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCONFIRM_USER)

                Dim pCONFIRM_PO_ID As SqlParameter = New SqlParameter("@CONFIRM_PO_ID", SqlDbType.NVarChar, 50)
                pCONFIRM_PO_ID.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCONFIRM_PO_ID)

                Dim pCREATE_USER As SqlParameter = New SqlParameter("@CREATE_USER", SqlDbType.NVarChar, 150)
                pCREATE_USER.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCREATE_USER)

                Dim pCREATE_PO_ID As SqlParameter = New SqlParameter("@CREATE_PO_ID", SqlDbType.NVarChar, 50)
                pCREATE_PO_ID.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCREATE_PO_ID)

                Dim pCONFIRM_DATE As SqlParameter = New SqlParameter("@CONFIRM_DATE", SqlDbType.DateTime, 0)
                pCONFIRM_DATE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCONFIRM_DATE)

                Dim pPOST_BAG_ID As SqlParameter = New SqlParameter("@POST_BAG_ID", SqlDbType.VarChar, 30)
                pPOST_BAG_ID.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPOST_BAG_ID)

                Dim pBC37_ID As SqlParameter = New SqlParameter("@BC37_ID", SqlDbType.VarChar, 18)
                pBC37_ID.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pBC37_ID)

                Dim pTRANSPORT_NUMBER As SqlParameter = New SqlParameter("@TRANSPORT_NUMBER", SqlDbType.NVarChar, 30)
                pTRANSPORT_NUMBER.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTRANSPORT_NUMBER)

                Dim pWAY_TYPE As SqlParameter = New SqlParameter("@WAY_TYPE", SqlDbType.Int, 0)
                pWAY_TYPE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pWAY_TYPE)

                Dim pMAIL_ROUTE_ID As SqlParameter = New SqlParameter("@MAIL_ROUTE_ID", SqlDbType.Int, 0)
                pMAIL_ROUTE_ID.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMAIL_ROUTE_ID)

                Dim pPARTNER_ID As SqlParameter = New SqlParameter("@PARTNER_ID", SqlDbType.Int, 0)
                pPARTNER_ID.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPARTNER_ID)

                Dim pID_CA As SqlParameter = New SqlParameter("@ID_CA", SqlDbType.Int, 0)
                pID_CA.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pID_CA)

                Dim pDATE_CA As SqlParameter = New SqlParameter("@DATE_CA", SqlDbType.DateTime, 0)
                pDATE_CA.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDATE_CA)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.ID = ID
                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.POST_BAG_INDEX = pPOST_BAG_INDEX.Value
                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.FROM_PO_ID = pFROM_PO_ID.Value
                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.TO_PO_ID = pTO_PO_ID.Value
                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.MAIL_TRIP_TYPE = pMAIL_TRIP_TYPE.Value
                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.SERVICE_ID = pSERVICE_ID.Value
                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.YEAR = pYEAR.Value
                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.MAIL_TRIP_NUMBER = pMAIL_TRIP_NUMBER.Value
                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.STATUS = pSTATUS.Value
                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.BC37_INDEX = pBC37_INDEX.Value
                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.BC37_FROM_PO_ID = pBC37_FROM_PO_ID.Value
                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.BC37_DATE = pBC37_DATE.Value
                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.BC37_TO_PO_ID = pBC37_TO_PO_ID.Value
                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.TRANSPORT_TYPE_ID = pTRANSPORT_TYPE_ID.Value
                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.BC37_ORDER = pBC37_ORDER.Value
                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.CONFIRM_USER = pCONFIRM_USER.Value
                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.CONFIRM_PO_ID = pCONFIRM_PO_ID.Value
                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.CREATE_USER = pCREATE_USER.Value
                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.CREATE_PO_ID = pCREATE_PO_ID.Value
                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.CONFIRM_DATE = pCONFIRM_DATE.Value
                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.POST_BAG_ID = pPOST_BAG_ID.Value
                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.BC37_ID = pBC37_ID.Value
                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.TRANSPORT_NUMBER = pTRANSPORT_NUMBER.Value
                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.WAY_TYPE = pWAY_TYPE.Value
                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.MAIL_ROUTE_ID = pMAIL_ROUTE_ID.Value
                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.PARTNER_ID = pPARTNER_ID.Value
                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.ID_CA = pID_CA.Value
                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.DATE_CA = pDATE_CA.Value

                Return myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet
                'Return myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet

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

#Region "QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Xoa"
        Public Function QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Xoa(ByVal ID As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet As New QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet

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

#Region "Hieu_Chinh"

        Public Sub TRANSPORT_POSTBAG_Hieu_Chinh(ByVal BC37_ID As String, ByVal Chieu_Di As Integer, ByVal Ma_Bc_Khai_Thac As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Hieu_Chinh", myConnection)
                myCommand.CommandTimeout = 20000
                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pBC37_ID As SqlParameter = New SqlParameter("@BC37_ID", SqlDbType.VarChar, 18)
                pBC37_ID.Value = BC37_ID
                myCommand.Parameters.Add(pBC37_ID)

                Dim pChieu_Di As SqlParameter = New SqlParameter("@Chieu_Di", SqlDbType.Int, 4)
                pChieu_Di.Value = Chieu_Di
                myCommand.Parameters.Add(pChieu_Di)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Sub
#End Region
    End Class
#End Region
End Namespace


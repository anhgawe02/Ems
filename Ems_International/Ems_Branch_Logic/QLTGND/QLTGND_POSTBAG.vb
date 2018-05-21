
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "QLTGND_POSTBAG_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop QLTGND_POSTBAG_Chi_Tiet
    'Tuong ung voi moi truong trong bang QLTGND_POSTBAG trong co so du lieu
    '***********************************************************
    Public Class QLTGND_POSTBAG_Chi_Tiet
        Public POST_BAG_ID As String
        Public POST_BAG_INDEX As Integer
        Public POST_BAG_TYPE As Integer
        Public FROM_PO_CODE As String
        Public TO_PO_CODE As String
        Public MAIL_TRIP_NUMBER As Integer
        Public MAIL_TRIP_TYPE As String
        Public SERVICE_CODE As String
        Public F As Integer
        Public WEIGHT As Double
        Public STATUS As String
        Public QUANTITY As Integer
        Public TRANSPORT_TYPE As String
        Public PACKAGING_TIME As DateTime
        Public PACKAGING_USER As String
        Public PACKAGING_MACHINE As String
        Public OPENING_MACHINE As String
        Public INCOMING_DATE As DateTime
        Public CASE_WEIGHT As Double
        Public BC37_ID As String
        Public IS_PRINTER As Integer
        Public BC37_DATE As DateTime
        Public OPENING_USER As String
        Public IS_DISCRETE As Integer
        Public IS_DELIVERY_ROUTE As Integer
        Public YEAR As String
        Public OPENING_TIME As DateTime
        Public TRUYEN_DU_LIEU As Integer
        Public DELIVERY As String
    End Class
#End Region

#Region "QLTGND_POSTBAG"
    Public Class QLTGND_POSTBAG
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "QLTGND_POSTBAG_Cap_Nhat_Them"
        Public Function QLTGND_POSTBAG_Cap_Nhat_Them(ByVal POST_BAG_ID As String, ByVal POST_BAG_INDEX As Integer, ByVal POST_BAG_TYPE As Integer, ByVal FROM_PO_CODE As String, ByVal TO_PO_CODE As String, ByVal MAIL_TRIP_NUMBER As Integer, ByVal MAIL_TRIP_TYPE As String, ByVal SERVICE_CODE As String, ByVal F As Integer, ByVal WEIGHT As Double, ByVal STATUS As String, ByVal QUANTITY As Integer, ByVal TRANSPORT_TYPE As String, ByVal PACKAGING_TIME As DateTime, ByVal PACKAGING_USER As String, ByVal PACKAGING_MACHINE As String, ByVal OPENING_MACHINE As String, ByVal INCOMING_DATE As DateTime, ByVal CASE_WEIGHT As Double, ByVal BC37_ID As String, ByVal IS_PRINTER As Integer, ByVal BC37_DATE As DateTime, ByVal OPENING_USER As String, ByVal IS_DISCRETE As Integer, ByVal IS_DELIVERY_ROUTE As Integer, ByVal YEAR As String, ByVal OPENING_TIME As DateTime, ByVal TRUYEN_DU_LIEU As Integer, ByVal DELIVERY As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_POSTBAG_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_POSTBAG_Chi_Tiet As New QLTGND_POSTBAG_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pPOST_BAG_ID As SqlParameter = New SqlParameter("@POST_BAG_ID", SqlDbType.VarChar, 30)
                pPOST_BAG_ID.Value = POST_BAG_ID
                MyCommand.Parameters.Add(pPOST_BAG_ID)

                Dim pPOST_BAG_INDEX As SqlParameter = New SqlParameter("@POST_BAG_INDEX", SqlDbType.Int, 0)
                pPOST_BAG_INDEX.Value = POST_BAG_INDEX
                MyCommand.Parameters.Add(pPOST_BAG_INDEX)

                Dim pPOST_BAG_TYPE As SqlParameter = New SqlParameter("@POST_BAG_TYPE", SqlDbType.Int, 0)
                pPOST_BAG_TYPE.Value = POST_BAG_TYPE
                MyCommand.Parameters.Add(pPOST_BAG_TYPE)

                Dim pFROM_PO_CODE As SqlParameter = New SqlParameter("@FROM_PO_CODE", SqlDbType.NVarChar, 32)
                pFROM_PO_CODE.Value = FROM_PO_CODE
                MyCommand.Parameters.Add(pFROM_PO_CODE)

                Dim pTO_PO_CODE As SqlParameter = New SqlParameter("@TO_PO_CODE", SqlDbType.NVarChar, 32)
                pTO_PO_CODE.Value = TO_PO_CODE
                MyCommand.Parameters.Add(pTO_PO_CODE)

                Dim pMAIL_TRIP_NUMBER As SqlParameter = New SqlParameter("@MAIL_TRIP_NUMBER", SqlDbType.Int, 0)
                pMAIL_TRIP_NUMBER.Value = MAIL_TRIP_NUMBER
                MyCommand.Parameters.Add(pMAIL_TRIP_NUMBER)

                Dim pMAIL_TRIP_TYPE As SqlParameter = New SqlParameter("@MAIL_TRIP_TYPE", SqlDbType.NVarChar, 3)
                pMAIL_TRIP_TYPE.Value = MAIL_TRIP_TYPE
                MyCommand.Parameters.Add(pMAIL_TRIP_TYPE)

                Dim pSERVICE_CODE As SqlParameter = New SqlParameter("@SERVICE_CODE", SqlDbType.NVarChar, 2)
                pSERVICE_CODE.Value = SERVICE_CODE
                MyCommand.Parameters.Add(pSERVICE_CODE)

                Dim pF As SqlParameter = New SqlParameter("@F", SqlDbType.Int, 0)
                pF.Value = F
                MyCommand.Parameters.Add(pF)

                Dim pWEIGHT As SqlParameter = New SqlParameter("@WEIGHT", SqlDbType.Float, 0)
                pWEIGHT.Value = WEIGHT
                MyCommand.Parameters.Add(pWEIGHT)

                Dim pSTATUS As SqlParameter = New SqlParameter("@STATUS", SqlDbType.NVarChar, 1)
                pSTATUS.Value = STATUS
                MyCommand.Parameters.Add(pSTATUS)

                Dim pQUANTITY As SqlParameter = New SqlParameter("@QUANTITY", SqlDbType.Int, 0)
                pQUANTITY.Value = QUANTITY
                MyCommand.Parameters.Add(pQUANTITY)

                Dim pTRANSPORT_TYPE As SqlParameter = New SqlParameter("@TRANSPORT_TYPE", SqlDbType.NVarChar, 50)
                pTRANSPORT_TYPE.Value = TRANSPORT_TYPE
                MyCommand.Parameters.Add(pTRANSPORT_TYPE)

                Dim pPACKAGING_TIME As SqlParameter = New SqlParameter("@PACKAGING_TIME", SqlDbType.DateTime, 0)
                pPACKAGING_TIME.Value = PACKAGING_TIME
                MyCommand.Parameters.Add(pPACKAGING_TIME)

                Dim pPACKAGING_USER As SqlParameter = New SqlParameter("@PACKAGING_USER", SqlDbType.NVarChar, 300)
                pPACKAGING_USER.Value = PACKAGING_USER
                MyCommand.Parameters.Add(pPACKAGING_USER)

                Dim pPACKAGING_MACHINE As SqlParameter = New SqlParameter("@PACKAGING_MACHINE", SqlDbType.NVarChar, 50)
                pPACKAGING_MACHINE.Value = PACKAGING_MACHINE
                MyCommand.Parameters.Add(pPACKAGING_MACHINE)

                Dim pOPENING_MACHINE As SqlParameter = New SqlParameter("@OPENING_MACHINE", SqlDbType.NVarChar, 50)
                pOPENING_MACHINE.Value = OPENING_MACHINE
                MyCommand.Parameters.Add(pOPENING_MACHINE)

                Dim pINCOMING_DATE As SqlParameter = New SqlParameter("@INCOMING_DATE", SqlDbType.DateTime, 0)
                pINCOMING_DATE.Value = INCOMING_DATE
                MyCommand.Parameters.Add(pINCOMING_DATE)

                Dim pCASE_WEIGHT As SqlParameter = New SqlParameter("@CASE_WEIGHT", SqlDbType.Float, 0)
                pCASE_WEIGHT.Value = CASE_WEIGHT
                MyCommand.Parameters.Add(pCASE_WEIGHT)

                Dim pBC37_ID As SqlParameter = New SqlParameter("@BC37_ID", SqlDbType.NVarChar, 18)
                pBC37_ID.Value = BC37_ID
                MyCommand.Parameters.Add(pBC37_ID)

                Dim pIS_PRINTER As SqlParameter = New SqlParameter("@IS_PRINTER", SqlDbType.Int, 0)
                pIS_PRINTER.Value = IS_PRINTER
                MyCommand.Parameters.Add(pIS_PRINTER)

                Dim pBC37_DATE As SqlParameter = New SqlParameter("@BC37_DATE", SqlDbType.DateTime, 0)
                pBC37_DATE.Value = BC37_DATE
                MyCommand.Parameters.Add(pBC37_DATE)

                Dim pOPENING_USER As SqlParameter = New SqlParameter("@OPENING_USER", SqlDbType.NVarChar, 200)
                pOPENING_USER.Value = OPENING_USER
                MyCommand.Parameters.Add(pOPENING_USER)

                Dim pIS_DISCRETE As SqlParameter = New SqlParameter("@IS_DISCRETE", SqlDbType.Int, 0)
                pIS_DISCRETE.Value = IS_DISCRETE
                MyCommand.Parameters.Add(pIS_DISCRETE)

                Dim pIS_DELIVERY_ROUTE As SqlParameter = New SqlParameter("@IS_DELIVERY_ROUTE", SqlDbType.Int, 0)
                pIS_DELIVERY_ROUTE.Value = IS_DELIVERY_ROUTE
                MyCommand.Parameters.Add(pIS_DELIVERY_ROUTE)

                Dim pYEAR As SqlParameter = New SqlParameter("@YEAR", SqlDbType.VarChar, 8)
                pYEAR.Value = YEAR
                MyCommand.Parameters.Add(pYEAR)

                Dim pOPENING_TIME As SqlParameter = New SqlParameter("@OPENING_TIME", SqlDbType.DateTime, 0)
                pOPENING_TIME.Value = OPENING_TIME
                MyCommand.Parameters.Add(pOPENING_TIME)

                Dim pTRUYEN_DU_LIEU As SqlParameter = New SqlParameter("@TRUYEN_DU_LIEU", SqlDbType.Int, 0)
                pTRUYEN_DU_LIEU.Value = TRUYEN_DU_LIEU
                MyCommand.Parameters.Add(pTRUYEN_DU_LIEU)

                Dim pDELIVERY As SqlParameter = New SqlParameter("@DELIVERY", SqlDbType.VarChar, 1)
                pDELIVERY.Value = DELIVERY
                MyCommand.Parameters.Add(pDELIVERY)


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


#Region "QLTGND_POSTBAG_Danh_Sach"

        Public Function QLTGND_POSTBAG_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' POST_BAG_ID
            ' POST_BAG_INDEX
            ' POST_BAG_TYPE
            ' FROM_PO_CODE
            ' TO_PO_CODE
            ' MAIL_TRIP_NUMBER
            ' MAIL_TRIP_TYPE
            ' SERVICE_CODE
            ' F
            ' WEIGHT
            ' STATUS
            ' QUANTITY
            ' TRANSPORT_TYPE
            ' PACKAGING_TIME
            ' PACKAGING_USER
            ' PACKAGING_MACHINE
            ' OPENING_MACHINE
            ' INCOMING_DATE
            ' CASE_WEIGHT
            ' BC37_ID
            ' IS_PRINTER
            ' BC37_DATE
            ' OPENING_USER
            ' IS_DISCRETE
            ' IS_DELIVERY_ROUTE
            ' YEAR
            ' OPENING_TIME
            ' TRUYEN_DU_LIEU


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_POSTBAG_Danh_Sach"
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

#Region "QLTGND_POSTBAG_Danh_Sach_Theo_BC37_ID_Truyen"

        Public Function QLTGND_POSTBAG_Danh_Sach_Theo_BC37_ID_Truyen(ByVal BC37_ID As String) As DataSet

            ' The procedure returns these columns:
            ' POST_BAG_ID
            ' POST_BAG_INDEX
            ' POST_BAG_TYPE
            ' FROM_PO_CODE
            ' TO_PO_CODE
            ' MAIL_TRIP_NUMBER
            ' MAIL_TRIP_TYPE
            ' SERVICE_CODE
            ' F
            ' WEIGHT
            ' STATUS
            ' QUANTITY
            ' TRANSPORT_TYPE
            ' PACKAGING_TIME
            ' PACKAGING_USER
            ' PACKAGING_MACHINE
            ' OPENING_MACHINE
            ' INCOMING_DATE
            ' CASE_WEIGHT
            ' BC37_ID
            ' IS_PRINTER
            ' BC37_DATE
            ' OPENING_USER
            ' IS_DISCRETE
            ' IS_DELIVERY_ROUTE
            ' YEAR
            ' OPENING_TIME
            ' TRUYEN_DU_LIEU


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_POSTBAG_Danh_Sach_Theo_BC37_ID_Truyen"
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

#Region "QLTGND_POSTBAG_Lay"
        Public Function QLTGND_POSTBAG_Lay(ByVal POST_BAG_ID As String) As QLTGND_POSTBAG_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_POSTBAG_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_POSTBAG_Chi_Tiet As New QLTGND_POSTBAG_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pPOST_BAG_ID As SqlParameter = New SqlParameter("@POST_BAG_ID", SqlDbType.VarChar, 30)
                pPOST_BAG_ID.Value = POST_BAG_ID
                MyCommand.Parameters.Add(pPOST_BAG_ID)

                Dim pPOST_BAG_INDEX As SqlParameter = New SqlParameter("@POST_BAG_INDEX", SqlDbType.Int, 0)
                pPOST_BAG_INDEX.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPOST_BAG_INDEX)

                Dim pPOST_BAG_TYPE As SqlParameter = New SqlParameter("@POST_BAG_TYPE", SqlDbType.Int, 0)
                pPOST_BAG_TYPE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPOST_BAG_TYPE)

                Dim pFROM_PO_CODE As SqlParameter = New SqlParameter("@FROM_PO_CODE", SqlDbType.NVarChar, 32)
                pFROM_PO_CODE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pFROM_PO_CODE)

                Dim pTO_PO_CODE As SqlParameter = New SqlParameter("@TO_PO_CODE", SqlDbType.NVarChar, 32)
                pTO_PO_CODE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTO_PO_CODE)

                Dim pMAIL_TRIP_NUMBER As SqlParameter = New SqlParameter("@MAIL_TRIP_NUMBER", SqlDbType.Int, 0)
                pMAIL_TRIP_NUMBER.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMAIL_TRIP_NUMBER)

                Dim pMAIL_TRIP_TYPE As SqlParameter = New SqlParameter("@MAIL_TRIP_TYPE", SqlDbType.NVarChar, 3)
                pMAIL_TRIP_TYPE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMAIL_TRIP_TYPE)

                Dim pSERVICE_CODE As SqlParameter = New SqlParameter("@SERVICE_CODE", SqlDbType.NVarChar, 2)
                pSERVICE_CODE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSERVICE_CODE)

                Dim pF As SqlParameter = New SqlParameter("@F", SqlDbType.Int, 0)
                pF.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pF)

                Dim pWEIGHT As SqlParameter = New SqlParameter("@WEIGHT", SqlDbType.Float, 0)
                pWEIGHT.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pWEIGHT)

                Dim pSTATUS As SqlParameter = New SqlParameter("@STATUS", SqlDbType.NVarChar, 1)
                pSTATUS.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSTATUS)

                Dim pQUANTITY As SqlParameter = New SqlParameter("@QUANTITY", SqlDbType.Int, 0)
                pQUANTITY.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pQUANTITY)

                Dim pTRANSPORT_TYPE As SqlParameter = New SqlParameter("@TRANSPORT_TYPE", SqlDbType.NVarChar, 50)
                pTRANSPORT_TYPE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTRANSPORT_TYPE)

                Dim pPACKAGING_TIME As SqlParameter = New SqlParameter("@PACKAGING_TIME", SqlDbType.DateTime, 0)
                pPACKAGING_TIME.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPACKAGING_TIME)

                Dim pPACKAGING_USER As SqlParameter = New SqlParameter("@PACKAGING_USER", SqlDbType.NVarChar, 300)
                pPACKAGING_USER.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPACKAGING_USER)

                Dim pPACKAGING_MACHINE As SqlParameter = New SqlParameter("@PACKAGING_MACHINE", SqlDbType.NVarChar, 50)
                pPACKAGING_MACHINE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPACKAGING_MACHINE)

                Dim pOPENING_MACHINE As SqlParameter = New SqlParameter("@OPENING_MACHINE", SqlDbType.NVarChar, 50)
                pOPENING_MACHINE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pOPENING_MACHINE)

                Dim pINCOMING_DATE As SqlParameter = New SqlParameter("@INCOMING_DATE", SqlDbType.DateTime, 0)
                pINCOMING_DATE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pINCOMING_DATE)

                Dim pCASE_WEIGHT As SqlParameter = New SqlParameter("@CASE_WEIGHT", SqlDbType.Float, 0)
                pCASE_WEIGHT.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCASE_WEIGHT)

                Dim pBC37_ID As SqlParameter = New SqlParameter("@BC37_ID", SqlDbType.NVarChar, 18)
                pBC37_ID.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pBC37_ID)

                Dim pIS_PRINTER As SqlParameter = New SqlParameter("@IS_PRINTER", SqlDbType.Int, 0)
                pIS_PRINTER.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pIS_PRINTER)

                Dim pBC37_DATE As SqlParameter = New SqlParameter("@BC37_DATE", SqlDbType.DateTime, 0)
                pBC37_DATE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pBC37_DATE)

                Dim pOPENING_USER As SqlParameter = New SqlParameter("@OPENING_USER", SqlDbType.NVarChar, 200)
                pOPENING_USER.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pOPENING_USER)

                Dim pIS_DISCRETE As SqlParameter = New SqlParameter("@IS_DISCRETE", SqlDbType.Int, 0)
                pIS_DISCRETE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pIS_DISCRETE)

                Dim pIS_DELIVERY_ROUTE As SqlParameter = New SqlParameter("@IS_DELIVERY_ROUTE", SqlDbType.Int, 0)
                pIS_DELIVERY_ROUTE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pIS_DELIVERY_ROUTE)

                Dim pYEAR As SqlParameter = New SqlParameter("@YEAR", SqlDbType.VarChar, 8)
                pYEAR.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pYEAR)

                Dim pOPENING_TIME As SqlParameter = New SqlParameter("@OPENING_TIME", SqlDbType.DateTime, 0)
                pOPENING_TIME.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pOPENING_TIME)

                Dim pTRUYEN_DU_LIEU As SqlParameter = New SqlParameter("@TRUYEN_DU_LIEU", SqlDbType.Int, 0)
                pTRUYEN_DU_LIEU.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTRUYEN_DU_LIEU)

                Dim pDELIVERY As SqlParameter = New SqlParameter("@DELIVERY", SqlDbType.VarChar, 1)
                pDELIVERY.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDELIVERY)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myQLTGND_POSTBAG_Chi_Tiet.POST_BAG_ID = POST_BAG_ID
                myQLTGND_POSTBAG_Chi_Tiet.POST_BAG_INDEX = pPOST_BAG_INDEX.Value
                myQLTGND_POSTBAG_Chi_Tiet.POST_BAG_TYPE = pPOST_BAG_TYPE.Value
                myQLTGND_POSTBAG_Chi_Tiet.FROM_PO_CODE = pFROM_PO_CODE.Value
                myQLTGND_POSTBAG_Chi_Tiet.TO_PO_CODE = pTO_PO_CODE.Value
                myQLTGND_POSTBAG_Chi_Tiet.MAIL_TRIP_NUMBER = pMAIL_TRIP_NUMBER.Value
                myQLTGND_POSTBAG_Chi_Tiet.MAIL_TRIP_TYPE = pMAIL_TRIP_TYPE.Value
                myQLTGND_POSTBAG_Chi_Tiet.SERVICE_CODE = pSERVICE_CODE.Value
                myQLTGND_POSTBAG_Chi_Tiet.F = pF.Value
                myQLTGND_POSTBAG_Chi_Tiet.WEIGHT = pWEIGHT.Value
                myQLTGND_POSTBAG_Chi_Tiet.STATUS = pSTATUS.Value
                myQLTGND_POSTBAG_Chi_Tiet.QUANTITY = pQUANTITY.Value
                myQLTGND_POSTBAG_Chi_Tiet.TRANSPORT_TYPE = pTRANSPORT_TYPE.Value
                myQLTGND_POSTBAG_Chi_Tiet.PACKAGING_TIME = pPACKAGING_TIME.Value
                myQLTGND_POSTBAG_Chi_Tiet.PACKAGING_USER = pPACKAGING_USER.Value
                myQLTGND_POSTBAG_Chi_Tiet.PACKAGING_MACHINE = pPACKAGING_MACHINE.Value
                myQLTGND_POSTBAG_Chi_Tiet.OPENING_MACHINE = pOPENING_MACHINE.Value
                myQLTGND_POSTBAG_Chi_Tiet.INCOMING_DATE = pINCOMING_DATE.Value
                myQLTGND_POSTBAG_Chi_Tiet.CASE_WEIGHT = pCASE_WEIGHT.Value
                myQLTGND_POSTBAG_Chi_Tiet.BC37_ID = pBC37_ID.Value
                myQLTGND_POSTBAG_Chi_Tiet.IS_PRINTER = pIS_PRINTER.Value
                myQLTGND_POSTBAG_Chi_Tiet.BC37_DATE = pBC37_DATE.Value
                myQLTGND_POSTBAG_Chi_Tiet.OPENING_USER = pOPENING_USER.Value
                myQLTGND_POSTBAG_Chi_Tiet.IS_DISCRETE = pIS_DISCRETE.Value
                myQLTGND_POSTBAG_Chi_Tiet.IS_DELIVERY_ROUTE = pIS_DELIVERY_ROUTE.Value
                myQLTGND_POSTBAG_Chi_Tiet.YEAR = pYEAR.Value
                myQLTGND_POSTBAG_Chi_Tiet.OPENING_TIME = pOPENING_TIME.Value
                myQLTGND_POSTBAG_Chi_Tiet.TRUYEN_DU_LIEU = pTRUYEN_DU_LIEU.Value
                myQLTGND_POSTBAG_Chi_Tiet.DELIVERY = pDELIVERY.Value

                Return myQLTGND_POSTBAG_Chi_Tiet
                'Return myQLTGND_POSTBAG_Chi_Tiet

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

#Region "QLTGND_POSTBAG_Xoa"
        Public Function QLTGND_POSTBAG_Xoa(ByVal POST_BAG_ID As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_POSTBAG_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_POSTBAG_Chi_Tiet As New QLTGND_POSTBAG_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pPOST_BAG_ID As SqlParameter = New SqlParameter("@POST_BAG_ID", SqlDbType.VarChar, 30)
                pPOST_BAG_ID.Value = POST_BAG_ID
                MyCommand.Parameters.Add(pPOST_BAG_ID)


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

#Region "QLTGND_POSTBAG_Cap_Nhat_Lai_Trang_Thai_Truyen"
        Public Function QLTGND_POSTBAG_Cap_Nhat_Lai_Trang_Thai_Truyen(ByVal BC37_ID As String, ByVal Trang_Thai As Integer) As Boolean
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim strSQL As String
            Try
                strSQL = "Update QLTGND_POSTBAG Set TRUYEN_DU_LIEU = " & Trang_Thai.ToString & " Where BC37_ID = '" & BC37_ID & "'"
                myCommand = New SqlCommand(strSQL, myConnection)

                myConnection.Open()
                myCommand.CommandType = CommandType.Text
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Return True
            Catch ex As Exception
                myConnection.Close()
                myConnection.Dispose()
                Return False
            End Try
        End Function
#End Region

    End Class
#End Region
End Namespace


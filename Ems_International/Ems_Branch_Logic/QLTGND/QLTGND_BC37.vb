
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "QLTGND_BC37_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop QLTGND_BC37_Chi_Tiet
    'Tuong ung voi moi truong trong bang QLTGND_BC37 trong co so du lieu
    '***********************************************************
    Public Class QLTGND_BC37_Chi_Tiet
        Public BC37_ID As String
        Public FROM_PO_CODE As String
        Public TO_PO_CODE As String
        Public TRANSPORT_TYPE As String
        Public BC37_DATE As DateTime
        Public CREATE_USER As String
        Public CREATE_PO_CODE As String
        Public STATUS As String
        Public MAILTRIP_NUMBER As String
        Public BC37_INDEX As Integer
        Public CONFIRM_USER As String
        Public CONFIRM_DATE As DateTime
        Public CONFIRM_PO_CODE As String
        Public TRUYEN_DU_LIEU As Integer
        Public MAIL_ROUTE_ID As Integer
        Public TOTAL_WEIGHT As Integer
        Public TOTAL_QUANTITY As Integer
        Public DELIVERY As String
        Public LAST_PO_CODE As String
        Public NEXT_PO_CODE As String
        Public NUMBER_OF_BAGS_1 As Integer
        Public NUMBER_OF_BAGS_2 As Integer
    End Class
#End Region

#Region "QLTGND_BC37"
    Public Class QLTGND_BC37
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "QLTGND_BC37_Cap_Nhat_Them"
        Public Function QLTGND_BC37_Cap_Nhat_Them(ByVal BC37_ID As String, ByVal FROM_PO_CODE As String, ByVal TO_PO_CODE As String, ByVal TRANSPORT_TYPE As String, ByVal BC37_DATE As DateTime, ByVal CREATE_USER As String, ByVal CREATE_PO_CODE As String, ByVal STATUS As String, ByVal MAILTRIP_NUMBER As String, ByVal BC37_INDEX As Integer, ByVal CONFIRM_USER As String, ByVal CONFIRM_DATE As DateTime, ByVal CONFIRM_PO_CODE As String, ByVal TRUYEN_DU_LIEU As Integer, ByVal MAIL_ROUTE_ID As Integer, ByVal TOTAL_WEIGHT As Integer, ByVal TOTAL_QUANTITY As Integer, ByVal DELIVERY As String, ByVal LAST_PO_CODE As String, ByVal NEXT_PO_CODE As String, ByVal NUMBER_OF_BAGS_1 As Integer, ByVal NUMBER_OF_BAGS_2 As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_BC37_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_BC37_Chi_Tiet As New QLTGND_BC37_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pBC37_ID As SqlParameter = New SqlParameter("@BC37_ID", SqlDbType.NVarChar, 18)
                pBC37_ID.Value = BC37_ID
                MyCommand.Parameters.Add(pBC37_ID)

                Dim pFROM_PO_CODE As SqlParameter = New SqlParameter("@FROM_PO_CODE", SqlDbType.NVarChar, 32)
                pFROM_PO_CODE.Value = FROM_PO_CODE
                MyCommand.Parameters.Add(pFROM_PO_CODE)

                Dim pTO_PO_CODE As SqlParameter = New SqlParameter("@TO_PO_CODE", SqlDbType.NVarChar, 32)
                pTO_PO_CODE.Value = TO_PO_CODE
                MyCommand.Parameters.Add(pTO_PO_CODE)

                Dim pTRANSPORT_TYPE As SqlParameter = New SqlParameter("@TRANSPORT_TYPE", SqlDbType.NVarChar, 50)
                pTRANSPORT_TYPE.Value = TRANSPORT_TYPE
                MyCommand.Parameters.Add(pTRANSPORT_TYPE)

                Dim pBC37_DATE As SqlParameter = New SqlParameter("@BC37_DATE", SqlDbType.DateTime, 0)
                pBC37_DATE.Value = BC37_DATE
                MyCommand.Parameters.Add(pBC37_DATE)

                Dim pCREATE_USER As SqlParameter = New SqlParameter("@CREATE_USER", SqlDbType.NVarChar, 200)
                pCREATE_USER.Value = CREATE_USER
                MyCommand.Parameters.Add(pCREATE_USER)

                Dim pCREATE_PO_CODE As SqlParameter = New SqlParameter("@CREATE_PO_CODE", SqlDbType.NVarChar, 32)
                pCREATE_PO_CODE.Value = CREATE_PO_CODE
                MyCommand.Parameters.Add(pCREATE_PO_CODE)

                Dim pSTATUS As SqlParameter = New SqlParameter("@STATUS", SqlDbType.NVarChar, 1)
                pSTATUS.Value = STATUS
                MyCommand.Parameters.Add(pSTATUS)

                Dim pMAILTRIP_NUMBER As SqlParameter = New SqlParameter("@MAILTRIP_NUMBER", SqlDbType.NVarChar, 60)
                pMAILTRIP_NUMBER.Value = MAILTRIP_NUMBER
                MyCommand.Parameters.Add(pMAILTRIP_NUMBER)

                Dim pBC37_INDEX As SqlParameter = New SqlParameter("@BC37_INDEX", SqlDbType.Int, 0)
                pBC37_INDEX.Value = BC37_INDEX
                MyCommand.Parameters.Add(pBC37_INDEX)

                Dim pCONFIRM_USER As SqlParameter = New SqlParameter("@CONFIRM_USER", SqlDbType.NVarChar, 150)
                pCONFIRM_USER.Value = CONFIRM_USER
                MyCommand.Parameters.Add(pCONFIRM_USER)

                Dim pCONFIRM_DATE As SqlParameter = New SqlParameter("@CONFIRM_DATE", SqlDbType.DateTime, 0)
                pCONFIRM_DATE.Value = CONFIRM_DATE
                MyCommand.Parameters.Add(pCONFIRM_DATE)

                Dim pCONFIRM_PO_CODE As SqlParameter = New SqlParameter("@CONFIRM_PO_CODE", SqlDbType.NVarChar, 10)
                pCONFIRM_PO_CODE.Value = CONFIRM_PO_CODE
                MyCommand.Parameters.Add(pCONFIRM_PO_CODE)

                Dim pTRUYEN_DU_LIEU As SqlParameter = New SqlParameter("@TRUYEN_DU_LIEU", SqlDbType.Int, 0)
                pTRUYEN_DU_LIEU.Value = TRUYEN_DU_LIEU
                MyCommand.Parameters.Add(pTRUYEN_DU_LIEU)

                Dim pMAIL_ROUTE_ID As SqlParameter = New SqlParameter("@MAIL_ROUTE_ID", SqlDbType.Int, 0)
                pMAIL_ROUTE_ID.Value = MAIL_ROUTE_ID
                MyCommand.Parameters.Add(pMAIL_ROUTE_ID)

                Dim pTOTAL_WEIGHT As SqlParameter = New SqlParameter("@TOTAL_WEIGHT", SqlDbType.Int, 0)
                pTOTAL_WEIGHT.Value = TOTAL_WEIGHT
                MyCommand.Parameters.Add(pTOTAL_WEIGHT)

                Dim pTOTAL_QUANTITY As SqlParameter = New SqlParameter("@TOTAL_QUANTITY", SqlDbType.Int, 0)
                pTOTAL_QUANTITY.Value = TOTAL_QUANTITY
                MyCommand.Parameters.Add(pTOTAL_QUANTITY)

                Dim pDELIVERY As SqlParameter = New SqlParameter("@DELIVERY", SqlDbType.NVarChar, 1)
                pDELIVERY.Value = DELIVERY
                MyCommand.Parameters.Add(pDELIVERY)

                Dim pLAST_PO_CODE As SqlParameter = New SqlParameter("@LAST_PO_CODE", SqlDbType.VarChar, 6)
                pLAST_PO_CODE.Value = LAST_PO_CODE
                MyCommand.Parameters.Add(pLAST_PO_CODE)

                Dim pNEXT_PO_CODE As SqlParameter = New SqlParameter("@NEXT_PO_CODE", SqlDbType.VarChar, 6)
                pNEXT_PO_CODE.Value = NEXT_PO_CODE
                MyCommand.Parameters.Add(pNEXT_PO_CODE)

                Dim pNUMBER_OF_BAGS_1 As SqlParameter = New SqlParameter("@NUMBER_OF_BAGS_1", SqlDbType.Int, 4)
                pNUMBER_OF_BAGS_1.Value = NUMBER_OF_BAGS_1
                MyCommand.Parameters.Add(pNUMBER_OF_BAGS_1)

                Dim pNUMBER_OF_BAGS_2 As SqlParameter = New SqlParameter("@NUMBER_OF_BAGS_2", SqlDbType.Int, 4)
                pNUMBER_OF_BAGS_2.Value = NUMBER_OF_BAGS_2
                MyCommand.Parameters.Add(pNUMBER_OF_BAGS_2)

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


#Region "QLTGND_BC37_Danh_Sach"

        Public Function QLTGND_BC37_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' BC37_ID
            ' FROM_PO_CODE
            ' TO_PO_CODE
            ' TRANSPORT_TYPE
            ' BC37_DATE
            ' CREATE_USER
            ' CREATE_PO_CODE
            ' STATUS
            ' MAILTRIP_NUMBER
            ' BC37_INDEX
            ' CONFIRM_USER
            ' CONFIRM_DATE
            ' CONFIRM_PO_CODE
            ' TRUYEN_DU_LIEU
            ' MAIL_ROUTE_ID
            ' TOTAL_WEIGHT
            ' TOTAL_QUANTITY
            ' DELIVERY


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_BC37_Danh_Sach"
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

#Region "QLTGND_BC37_Danh_Sach"

        Public Function QLTGND_BC37_Danh_Sach_BC37_Theo_Trang_Thai_Truyen(ByVal Truyen_Du_Lieu As Integer) As DataSet

            ' The procedure returns these columns:
            ' BC37_ID
            ' FROM_PO_CODE
            ' TO_PO_CODE
            ' TRANSPORT_TYPE
            ' BC37_DATE
            ' CREATE_USER
            ' CREATE_PO_CODE
            ' STATUS
            ' MAILTRIP_NUMBER
            ' BC37_INDEX
            ' CONFIRM_USER
            ' CONFIRM_DATE
            ' CONFIRM_PO_CODE
            ' TRUYEN_DU_LIEU
            ' MAIL_ROUTE_ID
            ' TOTAL_WEIGHT
            ' TOTAL_QUANTITY
            ' DELIVERY


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_BC37_Danh_Sach_BC37_Theo_Trang_Thai_Truyen"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters
                Dim pTruyen_Du_Lieu As SqlParameter = New SqlParameter("@Truyen_Du_Lieu", SqlDbType.Int, 0)
                pTruyen_Du_Lieu.Value = Truyen_Du_Lieu
                MyCommand.Parameters.Add(pTruyen_Du_Lieu)

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

#Region "QLTGND_BC37_Danh_Sach"

        Public Function QLTGND_BC37_Danh_Sach_Theo_Id_Tuyen_Ngay(ByVal Id_Tuyen As Integer, ByVal Ngay As Integer) As DataSet

            ' The procedure returns these columns:
            ' BC37_ID
            ' FROM_PO_CODE
            ' TO_PO_CODE
            ' TRANSPORT_TYPE
            ' BC37_DATE
            ' CREATE_USER
            ' CREATE_PO_CODE
            ' STATUS
            ' MAILTRIP_NUMBER
            ' BC37_INDEX
            ' CONFIRM_USER
            ' CONFIRM_DATE
            ' CONFIRM_PO_CODE
            ' TRUYEN_DU_LIEU
            ' MAIL_ROUTE_ID
            ' TOTAL_WEIGHT
            ' TOTAL_QUANTITY
            ' DELIVERY


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_BC37_Danh_Sach_Theo_Id_Tuyen_Ngay"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters
                Dim pId_Tuyen As SqlParameter = New SqlParameter("@Id_Tuyen", SqlDbType.Int, 4)
                pId_Tuyen.Value = Id_Tuyen
                MyCommand.Parameters.Add(pId_Tuyen)

                Dim pNgay As SqlParameter = New SqlParameter("@Ngay", SqlDbType.Int, 4)
                pNgay.Value = Ngay
                MyCommand.Parameters.Add(pNgay)

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

#Region "QLTGND_BC37_Lay"
        Public Function QLTGND_BC37_Lay(ByVal BC37_ID As String) As QLTGND_BC37_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_BC37_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_BC37_Chi_Tiet As New QLTGND_BC37_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pBC37_ID As SqlParameter = New SqlParameter("@BC37_ID", SqlDbType.NVarChar, 18)
                pBC37_ID.Value = BC37_ID
                MyCommand.Parameters.Add(pBC37_ID)

                Dim pFROM_PO_CODE As SqlParameter = New SqlParameter("@FROM_PO_CODE", SqlDbType.NVarChar, 32)
                pFROM_PO_CODE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pFROM_PO_CODE)

                Dim pTO_PO_CODE As SqlParameter = New SqlParameter("@TO_PO_CODE", SqlDbType.NVarChar, 32)
                pTO_PO_CODE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTO_PO_CODE)

                Dim pTRANSPORT_TYPE As SqlParameter = New SqlParameter("@TRANSPORT_TYPE", SqlDbType.NVarChar, 50)
                pTRANSPORT_TYPE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTRANSPORT_TYPE)

                Dim pBC37_DATE As SqlParameter = New SqlParameter("@BC37_DATE", SqlDbType.DateTime, 0)
                pBC37_DATE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pBC37_DATE)

                Dim pCREATE_USER As SqlParameter = New SqlParameter("@CREATE_USER", SqlDbType.NVarChar, 200)
                pCREATE_USER.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCREATE_USER)

                Dim pCREATE_PO_CODE As SqlParameter = New SqlParameter("@CREATE_PO_CODE", SqlDbType.NVarChar, 32)
                pCREATE_PO_CODE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCREATE_PO_CODE)

                Dim pSTATUS As SqlParameter = New SqlParameter("@STATUS", SqlDbType.NVarChar, 1)
                pSTATUS.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSTATUS)

                Dim pMAILTRIP_NUMBER As SqlParameter = New SqlParameter("@MAILTRIP_NUMBER", SqlDbType.NVarChar, 60)
                pMAILTRIP_NUMBER.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMAILTRIP_NUMBER)

                Dim pBC37_INDEX As SqlParameter = New SqlParameter("@BC37_INDEX", SqlDbType.Int, 0)
                pBC37_INDEX.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pBC37_INDEX)

                Dim pCONFIRM_USER As SqlParameter = New SqlParameter("@CONFIRM_USER", SqlDbType.NVarChar, 150)
                pCONFIRM_USER.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCONFIRM_USER)

                Dim pCONFIRM_DATE As SqlParameter = New SqlParameter("@CONFIRM_DATE", SqlDbType.DateTime, 0)
                pCONFIRM_DATE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCONFIRM_DATE)

                Dim pCONFIRM_PO_CODE As SqlParameter = New SqlParameter("@CONFIRM_PO_CODE", SqlDbType.NVarChar, 10)
                pCONFIRM_PO_CODE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCONFIRM_PO_CODE)

                Dim pTRUYEN_DU_LIEU As SqlParameter = New SqlParameter("@TRUYEN_DU_LIEU", SqlDbType.Int, 0)
                pTRUYEN_DU_LIEU.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTRUYEN_DU_LIEU)

                Dim pMAIL_ROUTE_ID As SqlParameter = New SqlParameter("@MAIL_ROUTE_ID", SqlDbType.Int, 0)
                pMAIL_ROUTE_ID.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMAIL_ROUTE_ID)

                Dim pTOTAL_WEIGHT As SqlParameter = New SqlParameter("@TOTAL_WEIGHT", SqlDbType.Int, 0)
                pTOTAL_WEIGHT.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTOTAL_WEIGHT)

                Dim pTOTAL_QUANTITY As SqlParameter = New SqlParameter("@TOTAL_QUANTITY", SqlDbType.Int, 0)
                pTOTAL_QUANTITY.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTOTAL_QUANTITY)

                Dim pDELIVERY As SqlParameter = New SqlParameter("@DELIVERY", SqlDbType.NVarChar, 1)
                pDELIVERY.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDELIVERY)

                Dim pLAST_PO_CODE As SqlParameter = New SqlParameter("@LAST_PO_CODE", SqlDbType.VarChar, 6)
                pLAST_PO_CODE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pLAST_PO_CODE)

                Dim pNEXT_PO_CODE As SqlParameter = New SqlParameter("@NEXT_PO_CODE", SqlDbType.VarChar, 6)
                pNEXT_PO_CODE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNEXT_PO_CODE)

                Dim pNUMBER_OF_BAGS_1 As SqlParameter = New SqlParameter("@NUMBER_OF_BAGS_1", SqlDbType.Int, 4)
                pNUMBER_OF_BAGS_1.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNUMBER_OF_BAGS_1)

                Dim pNUMBER_OF_BAGS_2 As SqlParameter = New SqlParameter("@NUMBER_OF_BAGS_2", SqlDbType.Int, 4)
                pNUMBER_OF_BAGS_2.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNUMBER_OF_BAGS_2)

                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myQLTGND_BC37_Chi_Tiet.BC37_ID = BC37_ID
                myQLTGND_BC37_Chi_Tiet.FROM_PO_CODE = pFROM_PO_CODE.Value
                myQLTGND_BC37_Chi_Tiet.TO_PO_CODE = pTO_PO_CODE.Value
                myQLTGND_BC37_Chi_Tiet.TRANSPORT_TYPE = pTRANSPORT_TYPE.Value
                myQLTGND_BC37_Chi_Tiet.BC37_DATE = pBC37_DATE.Value
                myQLTGND_BC37_Chi_Tiet.CREATE_USER = pCREATE_USER.Value
                myQLTGND_BC37_Chi_Tiet.CREATE_PO_CODE = pCREATE_PO_CODE.Value
                myQLTGND_BC37_Chi_Tiet.STATUS = pSTATUS.Value
                myQLTGND_BC37_Chi_Tiet.MAILTRIP_NUMBER = pMAILTRIP_NUMBER.Value
                myQLTGND_BC37_Chi_Tiet.BC37_INDEX = pBC37_INDEX.Value
                myQLTGND_BC37_Chi_Tiet.CONFIRM_USER = pCONFIRM_USER.Value
                myQLTGND_BC37_Chi_Tiet.CONFIRM_DATE = pCONFIRM_DATE.Value
                myQLTGND_BC37_Chi_Tiet.CONFIRM_PO_CODE = pCONFIRM_PO_CODE.Value
                myQLTGND_BC37_Chi_Tiet.TRUYEN_DU_LIEU = pTRUYEN_DU_LIEU.Value
                myQLTGND_BC37_Chi_Tiet.MAIL_ROUTE_ID = pMAIL_ROUTE_ID.Value
                myQLTGND_BC37_Chi_Tiet.TOTAL_WEIGHT = pTOTAL_WEIGHT.Value
                myQLTGND_BC37_Chi_Tiet.TOTAL_QUANTITY = pTOTAL_QUANTITY.Value
                myQLTGND_BC37_Chi_Tiet.DELIVERY = pDELIVERY.Value
                myQLTGND_BC37_Chi_Tiet.LAST_PO_CODE = pLAST_PO_CODE.Value
                myQLTGND_BC37_Chi_Tiet.NEXT_PO_CODE = pNEXT_PO_CODE.Value
                myQLTGND_BC37_Chi_Tiet.NUMBER_OF_BAGS_1 = pNUMBER_OF_BAGS_1.Value
                myQLTGND_BC37_Chi_Tiet.NUMBER_OF_BAGS_2 = pNUMBER_OF_BAGS_2.Value

                Return myQLTGND_BC37_Chi_Tiet
                'Return myQLTGND_BC37_Chi_Tiet

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

#Region "QLTGND_BC37_Xoa"
        Public Function QLTGND_BC37_Xoa(ByVal BC37_ID As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_BC37_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_BC37_Chi_Tiet As New QLTGND_BC37_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pBC37_ID As SqlParameter = New SqlParameter("@BC37_ID", SqlDbType.NVarChar, 18)
                pBC37_ID.Value = BC37_ID
                MyCommand.Parameters.Add(pBC37_ID)


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

        Public Sub QLTGND_BC37_Hieu_Chinh(ByVal BC37_ID As String, ByVal Chieu_Di As Integer, ByVal Ma_Bc_Khai_Thac As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("QLTGND_BC37_Hieu_Chinh", myConnection)
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

#Region "QLTGND_BC37_Cap_Nhat_Lai_Trang_Thai_Truyen"
        Public Function QLTGND_BC37_Cap_Nhat_Lai_Trang_Thai_Truyen(ByVal BC37_ID As String, ByVal Trang_Thai As Integer) As Boolean
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim strSQL As String
            Try
                strSQL = "Update QLTGND_BC37 Set TRUYEN_DU_LIEU = " & Trang_Thai.ToString & " Where BC37_ID = '" & BC37_ID & "'"
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


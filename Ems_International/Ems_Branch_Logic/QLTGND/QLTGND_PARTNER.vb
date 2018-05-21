
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "QLTGND_PARTNER_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop QLTGND_PARTNER_Chi_Tiet
    'Tuong ung voi moi truong trong bang QLTGND_PARTNER trong co so du lieu
    '***********************************************************
    Public Class QLTGND_PARTNER_Chi_Tiet
        Public ID As Integer
        Public PARTNER_CODE As String
        Public ADDRESS As String
        Public PHONE_NUMBER As String
        Public TAX As String
        Public ACCOUNT_NUMBER As String
        Public BANK_NAME As String
        Public NAME_OF_PC As String
        Public CONTACT_PHONE_NUMBER As String
        Public ID_NUMBER As String
        Public ID_WHERE As String
        Public ID_DATE As DateTime
        Public PO_ID_CONTACT As Integer
        Public NAME As String
        Public NAME_PARTNER As String
    End Class
#End Region

#Region "QLTGND_PARTNER"
    Public Class QLTGND_PARTNER
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "QLTGND_PARTNER_Cap_Nhat_Them"
        Public Function QLTGND_PARTNER_Cap_Nhat_Them(ByVal ID As Integer, ByVal PARTNER_CODE As String, ByVal ADDRESS As String, ByVal PHONE_NUMBER As String, ByVal TAX As String, ByVal ACCOUNT_NUMBER As String, ByVal BANK_NAME As String, ByVal NAME_OF_PC As String, ByVal CONTACT_PHONE_NUMBER As String, ByVal ID_NUMBER As String, ByVal ID_WHERE As String, ByVal ID_DATE As DateTime, ByVal PO_ID_CONTACT As Integer, ByVal NAME As String, ByVal NAME_PARTNER As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_PARTNER_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_PARTNER_Chi_Tiet As New QLTGND_PARTNER_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pID As SqlParameter = New SqlParameter("@ID", SqlDbType.Int, 0)
                pID.Value = ID
                MyCommand.Parameters.Add(pID)

                Dim pPARTNER_CODE As SqlParameter = New SqlParameter("@PARTNER_CODE", SqlDbType.VarChar, 32)
                pPARTNER_CODE.Value = PARTNER_CODE
                MyCommand.Parameters.Add(pPARTNER_CODE)

                Dim pADDRESS As SqlParameter = New SqlParameter("@ADDRESS", SqlDbType.NVarChar, 255)
                pADDRESS.Value = ADDRESS
                MyCommand.Parameters.Add(pADDRESS)

                Dim pPHONE_NUMBER As SqlParameter = New SqlParameter("@PHONE_NUMBER", SqlDbType.VarChar, 12)
                pPHONE_NUMBER.Value = PHONE_NUMBER
                MyCommand.Parameters.Add(pPHONE_NUMBER)

                Dim pTAX As SqlParameter = New SqlParameter("@TAX", SqlDbType.VarChar, 30)
                pTAX.Value = TAX
                MyCommand.Parameters.Add(pTAX)

                Dim pACCOUNT_NUMBER As SqlParameter = New SqlParameter("@ACCOUNT_NUMBER", SqlDbType.VarChar, 30)
                pACCOUNT_NUMBER.Value = ACCOUNT_NUMBER
                MyCommand.Parameters.Add(pACCOUNT_NUMBER)

                Dim pBANK_NAME As SqlParameter = New SqlParameter("@BANK_NAME", SqlDbType.NVarChar, 100)
                pBANK_NAME.Value = BANK_NAME
                MyCommand.Parameters.Add(pBANK_NAME)

                Dim pNAME_OF_PC As SqlParameter = New SqlParameter("@NAME_OF_PC", SqlDbType.NVarChar, 100)
                pNAME_OF_PC.Value = NAME_OF_PC
                MyCommand.Parameters.Add(pNAME_OF_PC)

                Dim pCONTACT_PHONE_NUMBER As SqlParameter = New SqlParameter("@CONTACT_PHONE_NUMBER", SqlDbType.NVarChar, 255)
                pCONTACT_PHONE_NUMBER.Value = CONTACT_PHONE_NUMBER
                MyCommand.Parameters.Add(pCONTACT_PHONE_NUMBER)

                Dim pID_NUMBER As SqlParameter = New SqlParameter("@ID_NUMBER", SqlDbType.VarChar, 10)
                pID_NUMBER.Value = ID_NUMBER
                MyCommand.Parameters.Add(pID_NUMBER)

                Dim pID_WHERE As SqlParameter = New SqlParameter("@ID_WHERE", SqlDbType.NVarChar, 50)
                pID_WHERE.Value = ID_WHERE
                MyCommand.Parameters.Add(pID_WHERE)

                Dim pID_DATE As SqlParameter = New SqlParameter("@ID_DATE", SqlDbType.DateTime, 0)
                pID_DATE.Value = ID_DATE
                MyCommand.Parameters.Add(pID_DATE)

                Dim pPO_ID_CONTACT As SqlParameter = New SqlParameter("@PO_ID_CONTACT", SqlDbType.Int, 0)
                pPO_ID_CONTACT.Value = PO_ID_CONTACT
                MyCommand.Parameters.Add(pPO_ID_CONTACT)

                Dim pNAME As SqlParameter = New SqlParameter("@NAME", SqlDbType.NVarChar, 200)
                pNAME.Value = NAME
                MyCommand.Parameters.Add(pNAME)

                Dim pNAME_PARTNER As SqlParameter = New SqlParameter("@NAME_PARTNER", SqlDbType.NVarChar, 200)
                pNAME_PARTNER.Value = NAME_PARTNER
                MyCommand.Parameters.Add(pNAME_PARTNER)


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


#Region "QLTGND_PARTNER_Danh_Sach"

        Public Function QLTGND_PARTNER_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' ID
            ' PARTNER_CODE
            ' ADDRESS
            ' PHONE_NUMBER
            ' TAX
            ' ACCOUNT_NUMBER
            ' BANK_NAME
            ' NAME_OF_PC
            ' CONTACT_PHONE_NUMBER
            ' ID_NUMBER
            ' ID_WHERE
            ' ID_DATE
            ' PO_ID_CONTACT
            ' NAME
            ' NAME_PARTNER


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_PARTNER_Danh_Sach"
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

#Region "QLTGND_PARTNER_Lay"
        Public Function QLTGND_PARTNER_Lay(ByVal ID As Integer) As QLTGND_PARTNER_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_PARTNER_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_PARTNER_Chi_Tiet As New QLTGND_PARTNER_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pID As SqlParameter = New SqlParameter("@ID", SqlDbType.Int, 0)
                pID.Value = ID
                MyCommand.Parameters.Add(pID)

                Dim pPARTNER_CODE As SqlParameter = New SqlParameter("@PARTNER_CODE", SqlDbType.VarChar, 32)
                pPARTNER_CODE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPARTNER_CODE)

                Dim pADDRESS As SqlParameter = New SqlParameter("@ADDRESS", SqlDbType.NVarChar, 255)
                pADDRESS.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pADDRESS)

                Dim pPHONE_NUMBER As SqlParameter = New SqlParameter("@PHONE_NUMBER", SqlDbType.VarChar, 12)
                pPHONE_NUMBER.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPHONE_NUMBER)

                Dim pTAX As SqlParameter = New SqlParameter("@TAX", SqlDbType.VarChar, 30)
                pTAX.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTAX)

                Dim pACCOUNT_NUMBER As SqlParameter = New SqlParameter("@ACCOUNT_NUMBER", SqlDbType.VarChar, 30)
                pACCOUNT_NUMBER.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pACCOUNT_NUMBER)

                Dim pBANK_NAME As SqlParameter = New SqlParameter("@BANK_NAME", SqlDbType.NVarChar, 100)
                pBANK_NAME.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pBANK_NAME)

                Dim pNAME_OF_PC As SqlParameter = New SqlParameter("@NAME_OF_PC", SqlDbType.NVarChar, 100)
                pNAME_OF_PC.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNAME_OF_PC)

                Dim pCONTACT_PHONE_NUMBER As SqlParameter = New SqlParameter("@CONTACT_PHONE_NUMBER", SqlDbType.NVarChar, 255)
                pCONTACT_PHONE_NUMBER.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCONTACT_PHONE_NUMBER)

                Dim pID_NUMBER As SqlParameter = New SqlParameter("@ID_NUMBER", SqlDbType.VarChar, 10)
                pID_NUMBER.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pID_NUMBER)

                Dim pID_WHERE As SqlParameter = New SqlParameter("@ID_WHERE", SqlDbType.NVarChar, 50)
                pID_WHERE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pID_WHERE)

                Dim pID_DATE As SqlParameter = New SqlParameter("@ID_DATE", SqlDbType.DateTime, 0)
                pID_DATE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pID_DATE)

                Dim pPO_ID_CONTACT As SqlParameter = New SqlParameter("@PO_ID_CONTACT", SqlDbType.Int, 0)
                pPO_ID_CONTACT.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPO_ID_CONTACT)

                Dim pNAME As SqlParameter = New SqlParameter("@NAME", SqlDbType.NVarChar, 200)
                pNAME.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNAME)

                Dim pNAME_PARTNER As SqlParameter = New SqlParameter("@NAME_PARTNER", SqlDbType.NVarChar, 200)
                pNAME_PARTNER.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNAME_PARTNER)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myQLTGND_PARTNER_Chi_Tiet.ID = ID
                myQLTGND_PARTNER_Chi_Tiet.PARTNER_CODE = pPARTNER_CODE.Value
                myQLTGND_PARTNER_Chi_Tiet.ADDRESS = pADDRESS.Value
                myQLTGND_PARTNER_Chi_Tiet.PHONE_NUMBER = pPHONE_NUMBER.Value
                myQLTGND_PARTNER_Chi_Tiet.TAX = pTAX.Value
                myQLTGND_PARTNER_Chi_Tiet.ACCOUNT_NUMBER = pACCOUNT_NUMBER.Value
                myQLTGND_PARTNER_Chi_Tiet.BANK_NAME = pBANK_NAME.Value
                myQLTGND_PARTNER_Chi_Tiet.NAME_OF_PC = pNAME_OF_PC.Value
                myQLTGND_PARTNER_Chi_Tiet.CONTACT_PHONE_NUMBER = pCONTACT_PHONE_NUMBER.Value
                myQLTGND_PARTNER_Chi_Tiet.ID_NUMBER = pID_NUMBER.Value
                myQLTGND_PARTNER_Chi_Tiet.ID_WHERE = pID_WHERE.Value
                myQLTGND_PARTNER_Chi_Tiet.ID_DATE = pID_DATE.Value
                myQLTGND_PARTNER_Chi_Tiet.PO_ID_CONTACT = pPO_ID_CONTACT.Value
                myQLTGND_PARTNER_Chi_Tiet.NAME = pNAME.Value
                myQLTGND_PARTNER_Chi_Tiet.NAME_PARTNER = pNAME_PARTNER.Value

                Return myQLTGND_PARTNER_Chi_Tiet
                'Return myQLTGND_PARTNER_Chi_Tiet

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

#Region "QLTGND_PARTNER_Xoa"
        Public Function QLTGND_PARTNER_Xoa(ByVal ID As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_PARTNER_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_PARTNER_Chi_Tiet As New QLTGND_PARTNER_Chi_Tiet

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


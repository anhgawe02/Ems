
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "QLTGND_P_O_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop QLTGND_P_O_Chi_Tiet
    'Tuong ung voi moi truong trong bang QLTGND_P_O trong co so du lieu
    '***********************************************************
    Public Class QLTGND_P_O_Chi_Tiet
        Public ID As Integer
        Public NAME As String
        Public PO_CODE As String
        Public COUNTRY As String
        Public PARENT_ID As Integer
        Public PO_LEVEL As String
        Public PO_ACCOUNT As String
        Public EX_PARAM As String
        Public PO_ADDRESS As String
        Public PO_PHONE As String
        Public PO_FAX_NO As String
        Public IS_LOCK As String
        Public DETAIL As String
        Public LOCATION As String
    End Class
#End Region

#Region "QLTGND_P_O"
    Public Class QLTGND_P_O
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "QLTGND_P_O_Cap_Nhat_Them"
        Public Function QLTGND_P_O_Cap_Nhat_Them(ByVal ID As Integer, ByVal NAME As String, ByVal PO_CODE As String, ByVal COUNTRY As String, ByVal PARENT_ID As Integer, ByVal PO_LEVEL As String, ByVal PO_ACCOUNT As String, ByVal EX_PARAM As String, ByVal PO_ADDRESS As String, ByVal PO_PHONE As String, ByVal PO_FAX_NO As String, ByVal IS_LOCK As String, ByVal DETAIL As String, ByVal LOCATION As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_P_O_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myQLTGND_P_O_Chi_Tiet As New QLTGND_P_O_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pID As SqlParameter = New SqlParameter("@ID", SqlDbType.Int, 0)
                pID.Value = ID
                MyCommand.Parameters.Add(pID)

                Dim pNAME As SqlParameter = New SqlParameter("@NAME", SqlDbType.NVarChar, 255)
                pNAME.Value = NAME
                MyCommand.Parameters.Add(pNAME)

                Dim pPO_CODE As SqlParameter = New SqlParameter("@PO_CODE", SqlDbType.VarChar, 32)
                pPO_CODE.Value = PO_CODE
                MyCommand.Parameters.Add(pPO_CODE)

                Dim pCOUNTRY As SqlParameter = New SqlParameter("@COUNTRY", SqlDbType.NVarChar, 50)
                pCOUNTRY.Value = COUNTRY
                MyCommand.Parameters.Add(pCOUNTRY)

                Dim pPARENT_ID As SqlParameter = New SqlParameter("@PARENT_ID", SqlDbType.Int, 0)
                pPARENT_ID.Value = PARENT_ID
                MyCommand.Parameters.Add(pPARENT_ID)

                Dim pPO_LEVEL As SqlParameter = New SqlParameter("@PO_LEVEL", SqlDbType.VarChar, 6)
                pPO_LEVEL.Value = PO_LEVEL
                MyCommand.Parameters.Add(pPO_LEVEL)

                Dim pPO_ACCOUNT As SqlParameter = New SqlParameter("@PO_ACCOUNT", SqlDbType.VarChar, 20)
                pPO_ACCOUNT.Value = PO_ACCOUNT
                MyCommand.Parameters.Add(pPO_ACCOUNT)

                Dim pEX_PARAM As SqlParameter = New SqlParameter("@EX_PARAM", SqlDbType.NVarChar, 6)
                pEX_PARAM.Value = EX_PARAM
                MyCommand.Parameters.Add(pEX_PARAM)

                Dim pPO_ADDRESS As SqlParameter = New SqlParameter("@PO_ADDRESS", SqlDbType.NVarChar, 255)
                pPO_ADDRESS.Value = PO_ADDRESS
                MyCommand.Parameters.Add(pPO_ADDRESS)

                Dim pPO_PHONE As SqlParameter = New SqlParameter("@PO_PHONE", SqlDbType.VarChar, 32)
                pPO_PHONE.Value = PO_PHONE
                MyCommand.Parameters.Add(pPO_PHONE)

                Dim pPO_FAX_NO As SqlParameter = New SqlParameter("@PO_FAX_NO", SqlDbType.VarChar, 32)
                pPO_FAX_NO.Value = PO_FAX_NO
                MyCommand.Parameters.Add(pPO_FAX_NO)

                Dim pIS_LOCK As SqlParameter = New SqlParameter("@IS_LOCK", SqlDbType.VarChar, 1)
                pIS_LOCK.Value = IS_LOCK
                MyCommand.Parameters.Add(pIS_LOCK)

                Dim pDETAIL As SqlParameter = New SqlParameter("@DETAIL", SqlDbType.NVarChar, 255)
                pDETAIL.Value = DETAIL
                MyCommand.Parameters.Add(pDETAIL)

                Dim pLOCATION As SqlParameter = New SqlParameter("@LOCATION", SqlDbType.NVarChar, 32)
                pLOCATION.Value = LOCATION
                MyCommand.Parameters.Add(pLOCATION)


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


#Region "QLTGND_P_O_Danh_Sach"

        Public Function QLTGND_P_O_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' ID
            ' NAME
            ' PO_CODE
            ' COUNTRY
            ' PARENT_ID
            ' PO_LEVEL
            ' PO_ACCOUNT
            ' EX_PARAM
            ' PO_ADDRESS
            ' PO_PHONE
            ' PO_FAX_NO
            ' IS_LOCK
            ' DETAIL
            ' LOCATION


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_P_O_Danh_Sach"
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

#Region "QLTGND_P_O_Lay"
        Public Function QLTGND_P_O_Lay(ByVal ID As Integer) As QLTGND_P_O_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_P_O_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myQLTGND_P_O_Chi_Tiet As New QLTGND_P_O_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pID As SqlParameter = New SqlParameter("@ID", SqlDbType.Int, 0)
                pID.Value = ID
                MyCommand.Parameters.Add(pID)

                Dim pNAME As SqlParameter = New SqlParameter("@NAME", SqlDbType.NVarChar, 255)
                pNAME.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNAME)

                Dim pPO_CODE As SqlParameter = New SqlParameter("@PO_CODE", SqlDbType.VarChar, 32)
                pPO_CODE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPO_CODE)

                Dim pCOUNTRY As SqlParameter = New SqlParameter("@COUNTRY", SqlDbType.NVarChar, 50)
                pCOUNTRY.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCOUNTRY)

                Dim pPARENT_ID As SqlParameter = New SqlParameter("@PARENT_ID", SqlDbType.Int, 0)
                pPARENT_ID.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPARENT_ID)

                Dim pPO_LEVEL As SqlParameter = New SqlParameter("@PO_LEVEL", SqlDbType.VarChar, 6)
                pPO_LEVEL.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPO_LEVEL)

                Dim pPO_ACCOUNT As SqlParameter = New SqlParameter("@PO_ACCOUNT", SqlDbType.VarChar, 20)
                pPO_ACCOUNT.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPO_ACCOUNT)

                Dim pEX_PARAM As SqlParameter = New SqlParameter("@EX_PARAM", SqlDbType.NVarChar, 6)
                pEX_PARAM.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pEX_PARAM)

                Dim pPO_ADDRESS As SqlParameter = New SqlParameter("@PO_ADDRESS", SqlDbType.NVarChar, 255)
                pPO_ADDRESS.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPO_ADDRESS)

                Dim pPO_PHONE As SqlParameter = New SqlParameter("@PO_PHONE", SqlDbType.VarChar, 32)
                pPO_PHONE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPO_PHONE)

                Dim pPO_FAX_NO As SqlParameter = New SqlParameter("@PO_FAX_NO", SqlDbType.VarChar, 32)
                pPO_FAX_NO.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPO_FAX_NO)

                Dim pIS_LOCK As SqlParameter = New SqlParameter("@IS_LOCK", SqlDbType.VarChar, 1)
                pIS_LOCK.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pIS_LOCK)

                Dim pDETAIL As SqlParameter = New SqlParameter("@DETAIL", SqlDbType.NVarChar, 255)
                pDETAIL.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDETAIL)

                Dim pLOCATION As SqlParameter = New SqlParameter("@LOCATION", SqlDbType.NVarChar, 32)
                pLOCATION.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pLOCATION)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myQLTGND_P_O_Chi_Tiet.ID = ID
                myQLTGND_P_O_Chi_Tiet.NAME = pNAME.Value
                myQLTGND_P_O_Chi_Tiet.PO_CODE = pPO_CODE.Value
                myQLTGND_P_O_Chi_Tiet.COUNTRY = pCOUNTRY.Value
                myQLTGND_P_O_Chi_Tiet.PARENT_ID = pPARENT_ID.Value
                myQLTGND_P_O_Chi_Tiet.PO_LEVEL = pPO_LEVEL.Value
                myQLTGND_P_O_Chi_Tiet.PO_ACCOUNT = pPO_ACCOUNT.Value
                myQLTGND_P_O_Chi_Tiet.EX_PARAM = pEX_PARAM.Value
                myQLTGND_P_O_Chi_Tiet.PO_ADDRESS = pPO_ADDRESS.Value
                myQLTGND_P_O_Chi_Tiet.PO_PHONE = pPO_PHONE.Value
                myQLTGND_P_O_Chi_Tiet.PO_FAX_NO = pPO_FAX_NO.Value
                myQLTGND_P_O_Chi_Tiet.IS_LOCK = pIS_LOCK.Value
                myQLTGND_P_O_Chi_Tiet.DETAIL = pDETAIL.Value
                myQLTGND_P_O_Chi_Tiet.LOCATION = pLOCATION.Value

                Return myQLTGND_P_O_Chi_Tiet
                'Return myQLTGND_P_O_Chi_Tiet

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

#Region "QLTGND_P_O_Xoa"
        Public Function QLTGND_P_O_Xoa(ByVal ID As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_P_O_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myQLTGND_P_O_Chi_Tiet As New QLTGND_P_O_Chi_Tiet

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


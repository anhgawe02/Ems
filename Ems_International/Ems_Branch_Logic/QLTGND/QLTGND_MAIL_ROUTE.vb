
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "QLTGND_MAIL_ROUTE_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop QLTGND_MAIL_ROUTE_Chi_Tiet
    'Tuong ung voi moi truong trong bang QLTGND_MAIL_ROUTE trong co so du lieu
    '***********************************************************
    Public Class QLTGND_MAIL_ROUTE_Chi_Tiet
        Public ID As Integer
        Public FROM_PROVINCE_ID As Integer
        Public TO_PROVINCE_ID As Integer
        Public MAIL_ROUNTER_CODE As Integer
        Public NAME As String
        Public TRANSPORT_TYPE_ID As Integer
    End Class
#End Region

#Region "QLTGND_MAIL_ROUTE"
    Public Class QLTGND_MAIL_ROUTE
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "QLTGND_MAIL_ROUTE_Cap_Nhat_Them"
        Public Function QLTGND_MAIL_ROUTE_Cap_Nhat_Them(ByVal ID As Integer, ByVal FROM_PROVINCE_ID As Integer, ByVal TO_PROVINCE_ID As Integer, ByVal MAIL_ROUNTER_CODE As Integer, ByVal NAME As String, ByVal TRANSPORT_TYPE_ID As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_MAIL_ROUTE_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myQLTGND_MAIL_ROUTE_Chi_Tiet As New QLTGND_MAIL_ROUTE_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pID As SqlParameter = New SqlParameter("@ID", SqlDbType.Int, 0)
                pID.Value = ID
                MyCommand.Parameters.Add(pID)

                Dim pFROM_PROVINCE_ID As SqlParameter = New SqlParameter("@FROM_PROVINCE_ID", SqlDbType.Int, 0)
                pFROM_PROVINCE_ID.Value = FROM_PROVINCE_ID
                MyCommand.Parameters.Add(pFROM_PROVINCE_ID)

                Dim pTO_PROVINCE_ID As SqlParameter = New SqlParameter("@TO_PROVINCE_ID", SqlDbType.Int, 0)
                pTO_PROVINCE_ID.Value = TO_PROVINCE_ID
                MyCommand.Parameters.Add(pTO_PROVINCE_ID)

                Dim pMAIL_ROUNTER_CODE As SqlParameter = New SqlParameter("@MAIL_ROUNTER_CODE", SqlDbType.Int, 0)
                pMAIL_ROUNTER_CODE.Value = MAIL_ROUNTER_CODE
                MyCommand.Parameters.Add(pMAIL_ROUNTER_CODE)

                Dim pNAME As SqlParameter = New SqlParameter("@NAME", SqlDbType.NVarChar, 150)
                pNAME.Value = NAME
                MyCommand.Parameters.Add(pNAME)

                Dim pTRANSPORT_TYPE_ID As SqlParameter = New SqlParameter("@TRANSPORT_TYPE_ID", SqlDbType.Int, 0)
                pTRANSPORT_TYPE_ID.Value = TRANSPORT_TYPE_ID
                MyCommand.Parameters.Add(pTRANSPORT_TYPE_ID)


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


#Region "QLTGND_MAIL_ROUTE_Danh_Sach"

        Public Function QLTGND_MAIL_ROUTE_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' ID
            ' FROM_PROVINCE_ID
            ' TO_PROVINCE_ID
            ' MAIL_ROUNTER_CODE
            ' NAME
            ' TRANSPORT_TYPE_ID


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_MAIL_ROUTE_Danh_Sach"
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

#Region "QLTGND_MAIL_ROUTE_Lay"
        Public Function QLTGND_MAIL_ROUTE_Lay(ByVal ID As Integer) As QLTGND_MAIL_ROUTE_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_MAIL_ROUTE_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myQLTGND_MAIL_ROUTE_Chi_Tiet As New QLTGND_MAIL_ROUTE_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pID As SqlParameter = New SqlParameter("@ID", SqlDbType.Int, 0)
                pID.Value = ID
                MyCommand.Parameters.Add(pID)

                Dim pFROM_PROVINCE_ID As SqlParameter = New SqlParameter("@FROM_PROVINCE_ID", SqlDbType.Int, 0)
                pFROM_PROVINCE_ID.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pFROM_PROVINCE_ID)

                Dim pTO_PROVINCE_ID As SqlParameter = New SqlParameter("@TO_PROVINCE_ID", SqlDbType.Int, 0)
                pTO_PROVINCE_ID.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTO_PROVINCE_ID)

                Dim pMAIL_ROUNTER_CODE As SqlParameter = New SqlParameter("@MAIL_ROUNTER_CODE", SqlDbType.Int, 0)
                pMAIL_ROUNTER_CODE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMAIL_ROUNTER_CODE)

                Dim pNAME As SqlParameter = New SqlParameter("@NAME", SqlDbType.NVarChar, 150)
                pNAME.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNAME)

                Dim pTRANSPORT_TYPE_ID As SqlParameter = New SqlParameter("@TRANSPORT_TYPE_ID", SqlDbType.Int, 0)
                pTRANSPORT_TYPE_ID.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTRANSPORT_TYPE_ID)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myQLTGND_MAIL_ROUTE_Chi_Tiet.ID = ID
                myQLTGND_MAIL_ROUTE_Chi_Tiet.FROM_PROVINCE_ID = pFROM_PROVINCE_ID.Value
                myQLTGND_MAIL_ROUTE_Chi_Tiet.TO_PROVINCE_ID = pTO_PROVINCE_ID.Value
                myQLTGND_MAIL_ROUTE_Chi_Tiet.MAIL_ROUNTER_CODE = pMAIL_ROUNTER_CODE.Value
                myQLTGND_MAIL_ROUTE_Chi_Tiet.NAME = pNAME.Value
                myQLTGND_MAIL_ROUTE_Chi_Tiet.TRANSPORT_TYPE_ID = pTRANSPORT_TYPE_ID.Value

                Return myQLTGND_MAIL_ROUTE_Chi_Tiet
                'Return myQLTGND_MAIL_ROUTE_Chi_Tiet

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

#Region "QLTGND_MAIL_ROUTE_Xoa"
        Public Function QLTGND_MAIL_ROUTE_Xoa(ByVal ID As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_MAIL_ROUTE_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myQLTGND_MAIL_ROUTE_Chi_Tiet As New QLTGND_MAIL_ROUTE_Chi_Tiet

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


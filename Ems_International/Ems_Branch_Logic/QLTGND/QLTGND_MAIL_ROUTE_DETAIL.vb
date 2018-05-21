
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "QLTGND_MAIL_ROUTE_DETAIL_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop QLTGND_MAIL_ROUTE_DETAIL_Chi_Tiet
    'Tuong ung voi moi truong trong bang QLTGND_MAIL_ROUTE_DETAIL trong co so du lieu
    '***********************************************************
    Public Class QLTGND_MAIL_ROUTE_DETAIL_Chi_Tiet
        Public ID As Integer
        Public MAIL_ROUNTER_ID As Integer
        Public PO_INDEX As Integer
        Public PO_ID As Integer
    End Class
#End Region

#Region "QLTGND_MAIL_ROUTE_DETAIL"
    Public Class QLTGND_MAIL_ROUTE_DETAIL
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "QLTGND_MAIL_ROUTE_DETAIL_Cap_Nhat_Them"
        Public Function QLTGND_MAIL_ROUTE_DETAIL_Cap_Nhat_Them(ByVal ID As Integer, ByVal MAIL_ROUNTER_ID As Integer, ByVal PO_INDEX As Integer, ByVal PO_ID As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_MAIL_ROUTE_DETAIL_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myQLTGND_MAIL_ROUTE_DETAIL_Chi_Tiet As New QLTGND_MAIL_ROUTE_DETAIL_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pID As SqlParameter = New SqlParameter("@ID", SqlDbType.Int, 0)
                pID.Value = ID
                MyCommand.Parameters.Add(pID)

                Dim pMAIL_ROUNTER_ID As SqlParameter = New SqlParameter("@MAIL_ROUNTER_ID", SqlDbType.Int, 0)
                pMAIL_ROUNTER_ID.Value = MAIL_ROUNTER_ID
                MyCommand.Parameters.Add(pMAIL_ROUNTER_ID)

                Dim pPO_INDEX As SqlParameter = New SqlParameter("@PO_INDEX", SqlDbType.Int, 0)
                pPO_INDEX.Value = PO_INDEX
                MyCommand.Parameters.Add(pPO_INDEX)

                Dim pPO_ID As SqlParameter = New SqlParameter("@PO_ID", SqlDbType.Int, 0)
                pPO_ID.Value = PO_ID
                MyCommand.Parameters.Add(pPO_ID)


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


#Region "QLTGND_MAIL_ROUTE_DETAIL_Danh_Sach"

        Public Function QLTGND_MAIL_ROUTE_DETAIL_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' ID
            ' MAIL_ROUNTER_ID
            ' PO_INDEX
            ' PO_ID


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_MAIL_ROUTE_DETAIL_Danh_Sach"
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

#Region "QLTGND_MAIL_ROUTE_DETAIL_Lay"
        Public Function QLTGND_MAIL_ROUTE_DETAIL_Lay(ByVal ID As Integer) As QLTGND_MAIL_ROUTE_DETAIL_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_MAIL_ROUTE_DETAIL_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myQLTGND_MAIL_ROUTE_DETAIL_Chi_Tiet As New QLTGND_MAIL_ROUTE_DETAIL_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pID As SqlParameter = New SqlParameter("@ID", SqlDbType.Int, 0)
                pID.Value = ID
                MyCommand.Parameters.Add(pID)

                Dim pMAIL_ROUNTER_ID As SqlParameter = New SqlParameter("@MAIL_ROUNTER_ID", SqlDbType.Int, 0)
                pMAIL_ROUNTER_ID.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMAIL_ROUNTER_ID)

                Dim pPO_INDEX As SqlParameter = New SqlParameter("@PO_INDEX", SqlDbType.Int, 0)
                pPO_INDEX.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPO_INDEX)

                Dim pPO_ID As SqlParameter = New SqlParameter("@PO_ID", SqlDbType.Int, 0)
                pPO_ID.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPO_ID)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myQLTGND_MAIL_ROUTE_DETAIL_Chi_Tiet.ID = ID
                myQLTGND_MAIL_ROUTE_DETAIL_Chi_Tiet.MAIL_ROUNTER_ID = pMAIL_ROUNTER_ID.Value
                myQLTGND_MAIL_ROUTE_DETAIL_Chi_Tiet.PO_INDEX = pPO_INDEX.Value
                myQLTGND_MAIL_ROUTE_DETAIL_Chi_Tiet.PO_ID = pPO_ID.Value

                Return myQLTGND_MAIL_ROUTE_DETAIL_Chi_Tiet
                'Return myQLTGND_MAIL_ROUTE_DETAIL_Chi_Tiet

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

#Region "QLTGND_MAIL_ROUTE_DETAIL_Xoa"
        Public Function QLTGND_MAIL_ROUTE_DETAIL_Xoa(ByVal ID As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_MAIL_ROUTE_DETAIL_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myQLTGND_MAIL_ROUTE_DETAIL_Chi_Tiet As New QLTGND_MAIL_ROUTE_DETAIL_Chi_Tiet

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


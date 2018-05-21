
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "QLTGND_TRANSPORT_TYPE_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop QLTGND_TRANSPORT_TYPE_Chi_Tiet
    'Tuong ung voi moi truong trong bang QLTGND_TRANSPORT_TYPE trong co so du lieu
    '***********************************************************
    Public Class QLTGND_TRANSPORT_TYPE_Chi_Tiet
        Public ID As Integer
        Public NAME As String
        Public IS_LOCK As String
    End Class
#End Region

#Region "QLTGND_TRANSPORT_TYPE"
    Public Class QLTGND_TRANSPORT_TYPE
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "QLTGND_TRANSPORT_TYPE_Cap_Nhat_Them"
        Public Function QLTGND_TRANSPORT_TYPE_Cap_Nhat_Them(ByVal ID As Integer, ByVal NAME As String, ByVal IS_LOCK As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_TRANSPORT_TYPE_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_TRANSPORT_TYPE_Chi_Tiet As New QLTGND_TRANSPORT_TYPE_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pID As SqlParameter = New SqlParameter("@ID", SqlDbType.Int, 0)
                pID.Value = ID
                MyCommand.Parameters.Add(pID)

                Dim pNAME As SqlParameter = New SqlParameter("@NAME", SqlDbType.NVarChar, 100)
                pNAME.Value = NAME
                MyCommand.Parameters.Add(pNAME)

                Dim pIS_LOCK As SqlParameter = New SqlParameter("@IS_LOCK", SqlDbType.NVarChar, 50)
                pIS_LOCK.Value = IS_LOCK
                MyCommand.Parameters.Add(pIS_LOCK)


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


#Region "QLTGND_TRANSPORT_TYPE_Danh_Sach"

        Public Function QLTGND_TRANSPORT_TYPE_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' ID
            ' NAME
            ' IS_LOCK


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_TRANSPORT_TYPE_Danh_Sach"
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

#Region "QLTGND_TRANSPORT_TYPE_Lay"
        Public Function QLTGND_TRANSPORT_TYPE_Lay(ByVal ID As Integer) As QLTGND_TRANSPORT_TYPE_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_TRANSPORT_TYPE_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_TRANSPORT_TYPE_Chi_Tiet As New QLTGND_TRANSPORT_TYPE_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pID As SqlParameter = New SqlParameter("@ID", SqlDbType.Int, 0)
                pID.Value = ID
                MyCommand.Parameters.Add(pID)

                Dim pNAME As SqlParameter = New SqlParameter("@NAME", SqlDbType.NVarChar, 100)
                pNAME.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNAME)

                Dim pIS_LOCK As SqlParameter = New SqlParameter("@IS_LOCK", SqlDbType.NVarChar, 50)
                pIS_LOCK.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pIS_LOCK)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myQLTGND_TRANSPORT_TYPE_Chi_Tiet.ID = ID
                myQLTGND_TRANSPORT_TYPE_Chi_Tiet.NAME = pNAME.Value
                myQLTGND_TRANSPORT_TYPE_Chi_Tiet.IS_LOCK = pIS_LOCK.Value

                Return myQLTGND_TRANSPORT_TYPE_Chi_Tiet
                'Return myQLTGND_TRANSPORT_TYPE_Chi_Tiet

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

#Region "QLTGND_TRANSPORT_TYPE_Xoa"
        Public Function QLTGND_TRANSPORT_TYPE_Xoa(ByVal ID As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_TRANSPORT_TYPE_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_TRANSPORT_TYPE_Chi_Tiet As New QLTGND_TRANSPORT_TYPE_Chi_Tiet

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

#Region "QLTGND_TRANSPORT_TYPE_XOA"
        ' Ngày tạo: 27/6/08
        ' Input: mae1
        ' Output: true or false
        Public Function QLTGND_TRANSPORT_TYPE_XOA() As String
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim ReturnValue As String
            myCommand = New SqlCommand("Delete From QLTGND_TRANSPORT_TYPE", myConnection)
            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, "", myCommand.ExecuteScalar)
            myConnection.Close()
            myConnection.Dispose()
            Return ReturnValue
        End Function
#End Region
    End Class
#End Region
End Namespace


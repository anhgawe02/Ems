
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "QLTGND_TRANSPORT_INFO_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop QLTGND_TRANSPORT_INFO_Chi_Tiet
    'Tuong ung voi moi truong trong bang QLTGND_TRANSPORT_INFO trong co so du lieu
    '***********************************************************
    Public Class QLTGND_TRANSPORT_INFO_Chi_Tiet
        Public Id As Integer
        Public Partner_Id As Integer
        Public Transport_Type_Id As Integer
        Public Mail_Router_Id As Integer
        Public Start_Time As String
        Public End_Time As String
        Public From_Address As String
        Public To_Address As String
    End Class
#End Region

#Region "QLTGND_TRANSPORT_INFO"
    Public Class QLTGND_TRANSPORT_INFO
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "QLTGND_TRANSPORT_INFO_Cap_Nhat_Them"
        Public Function QLTGND_TRANSPORT_INFO_Cap_Nhat_Them(ByVal Id As Integer, ByVal Partner_Id As Integer, ByVal Transport_Type_Id As Integer, ByVal Mail_Router_Id As Integer, ByVal Start_Time As String, ByVal End_Time As String, ByVal From_Address As String, ByVal To_Address As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_TRANSPORT_INFO_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myQLTGND_TRANSPORT_INFO_Chi_Tiet As New QLTGND_TRANSPORT_INFO_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId As SqlParameter = New SqlParameter("@Id", SqlDbType.Int, 0)
                pId.Value = Id
                MyCommand.Parameters.Add(pId)

                Dim pPartner_Id As SqlParameter = New SqlParameter("@Partner_Id", SqlDbType.Int, 0)
                pPartner_Id.Value = Partner_Id
                MyCommand.Parameters.Add(pPartner_Id)

                Dim pTransport_Type_Id As SqlParameter = New SqlParameter("@Transport_Type_Id", SqlDbType.Int, 0)
                pTransport_Type_Id.Value = Transport_Type_Id
                MyCommand.Parameters.Add(pTransport_Type_Id)

                Dim pMail_Router_Id As SqlParameter = New SqlParameter("@Mail_Router_Id", SqlDbType.Int, 0)
                pMail_Router_Id.Value = Mail_Router_Id
                MyCommand.Parameters.Add(pMail_Router_Id)

                Dim pStart_Time As SqlParameter = New SqlParameter("@Start_Time", SqlDbType.VarChar, 10)
                pStart_Time.Value = Start_Time
                MyCommand.Parameters.Add(pStart_Time)

                Dim pEnd_Time As SqlParameter = New SqlParameter("@End_Time", SqlDbType.VarChar, 10)
                pEnd_Time.Value = End_Time
                MyCommand.Parameters.Add(pEnd_Time)

                Dim pFrom_Address As SqlParameter = New SqlParameter("@From_Address", SqlDbType.NVarChar, 100)
                pFrom_Address.Value = From_Address
                MyCommand.Parameters.Add(pFrom_Address)

                Dim pTo_Address As SqlParameter = New SqlParameter("@To_Address", SqlDbType.NVarChar, 100)
                pTo_Address.Value = To_Address
                MyCommand.Parameters.Add(pTo_Address)


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


#Region "QLTGND_TRANSPORT_INFO_Danh_Sach"

        Public Function QLTGND_TRANSPORT_INFO_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Id
            ' Partner_Id
            ' Transport_Type_Id
            ' Mail_Router_Id
            ' Start_Time
            ' End_Time
            ' From_Address
            ' To_Address


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_TRANSPORT_INFO_Danh_Sach"
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

#Region "QLTGND_TRANSPORT_INFO_Lay"
        Public Function QLTGND_TRANSPORT_INFO_Lay(ByVal Id As Integer) As QLTGND_TRANSPORT_INFO_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_TRANSPORT_INFO_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myQLTGND_TRANSPORT_INFO_Chi_Tiet As New QLTGND_TRANSPORT_INFO_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId As SqlParameter = New SqlParameter("@Id", SqlDbType.Int, 0)
                pId.Value = Id
                MyCommand.Parameters.Add(pId)

                Dim pPartner_Id As SqlParameter = New SqlParameter("@Partner_Id", SqlDbType.Int, 0)
                pPartner_Id.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPartner_Id)

                Dim pTransport_Type_Id As SqlParameter = New SqlParameter("@Transport_Type_Id", SqlDbType.Int, 0)
                pTransport_Type_Id.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTransport_Type_Id)

                Dim pMail_Router_Id As SqlParameter = New SqlParameter("@Mail_Router_Id", SqlDbType.Int, 0)
                pMail_Router_Id.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMail_Router_Id)

                Dim pStart_Time As SqlParameter = New SqlParameter("@Start_Time", SqlDbType.VarChar, 10)
                pStart_Time.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pStart_Time)

                Dim pEnd_Time As SqlParameter = New SqlParameter("@End_Time", SqlDbType.VarChar, 10)
                pEnd_Time.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pEnd_Time)

                Dim pFrom_Address As SqlParameter = New SqlParameter("@From_Address", SqlDbType.NVarChar, 100)
                pFrom_Address.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pFrom_Address)

                Dim pTo_Address As SqlParameter = New SqlParameter("@To_Address", SqlDbType.NVarChar, 100)
                pTo_Address.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTo_Address)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myQLTGND_TRANSPORT_INFO_Chi_Tiet.Id = Id
                myQLTGND_TRANSPORT_INFO_Chi_Tiet.Partner_Id = pPartner_Id.Value
                myQLTGND_TRANSPORT_INFO_Chi_Tiet.Transport_Type_Id = pTransport_Type_Id.Value
                myQLTGND_TRANSPORT_INFO_Chi_Tiet.Mail_Router_Id = pMail_Router_Id.Value
                myQLTGND_TRANSPORT_INFO_Chi_Tiet.Start_Time = pStart_Time.Value
                myQLTGND_TRANSPORT_INFO_Chi_Tiet.End_Time = pEnd_Time.Value
                myQLTGND_TRANSPORT_INFO_Chi_Tiet.From_Address = pFrom_Address.Value
                myQLTGND_TRANSPORT_INFO_Chi_Tiet.To_Address = pTo_Address.Value

                Return myQLTGND_TRANSPORT_INFO_Chi_Tiet
                'Return myQLTGND_TRANSPORT_INFO_Chi_Tiet

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

#Region "QLTGND_TRANSPORT_INFO_Xoa"
        Public Function QLTGND_TRANSPORT_INFO_Xoa(ByVal Id As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_TRANSPORT_INFO_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myQLTGND_TRANSPORT_INFO_Chi_Tiet As New QLTGND_TRANSPORT_INFO_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId As SqlParameter = New SqlParameter("@Id", SqlDbType.Int, 0)
                pId.Value = Id
                MyCommand.Parameters.Add(pId)


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


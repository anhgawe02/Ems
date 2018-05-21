
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "QLTGND_HUONG_VC_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop QLTGND_HUONG_VC_Chi_Tiet
    'Tuong ung voi moi truong trong bang QLTGND_HUONG_VC trong co so du lieu
    '***********************************************************
    Public Class QLTGND_HUONG_VC_Chi_Tiet
        Public Id_Huong As Integer
        Public Ten_Huong As String
    End Class
#End Region

#Region "QLTGND_HUONG_VC"
    Public Class QLTGND_HUONG_VC
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "QLTGND_Huong_VC_Cap_Nhat_Them"
        Public Function QLTGND_Huong_VC_Cap_Nhat_Them(ByVal Id_Huong As Integer, ByVal Ten_Huong As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_Huong_VC_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_HUONG_VC_Chi_Tiet As New QLTGND_HUONG_VC_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Huong As SqlParameter = New SqlParameter("@Id_Huong", SqlDbType.Int, 0)
                pId_Huong.Value = Id_Huong
                MyCommand.Parameters.Add(pId_Huong)

                Dim pTen_Huong As SqlParameter = New SqlParameter("@Ten_Huong", SqlDbType.NVarChar, 100)
                pTen_Huong.Value = Ten_Huong
                MyCommand.Parameters.Add(pTen_Huong)


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


#Region "QLTGND_Huong_VC_Danh_Sach"

        Public Function QLTGND_Huong_VC_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Id_Huong
            ' Ten_Huong


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_Huong_VC_Danh_Sach"
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

#Region "QLTGND_Huong_VC_Lay"
        Public Function QLTGND_Huong_VC_Lay(ByVal Id_Huong As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_Huong_VC_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_HUONG_VC_Chi_Tiet As New QLTGND_HUONG_VC_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Huong As SqlParameter = New SqlParameter("@Id_Huong", SqlDbType.Int, 0)
                pId_Huong.Value = Id_Huong
                MyCommand.Parameters.Add(pId_Huong)

                Dim pTen_Huong As SqlParameter = New SqlParameter("@Ten_Huong", SqlDbType.NVarChar, 100)
                pTen_Huong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTen_Huong)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myQLTGND_HUONG_VC_Chi_Tiet.Id_Huong = Id_Huong
                myQLTGND_HUONG_VC_Chi_Tiet.Ten_Huong = pTen_Huong.Value

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

#Region "QLTGND_Huong_VC_Xoa"
        Public Function QLTGND_Huong_VC_Xoa(ByVal Id_Huong As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_Huong_VC_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_HUONG_VC_Chi_Tiet As New QLTGND_HUONG_VC_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Huong As SqlParameter = New SqlParameter("@Id_Huong", SqlDbType.Int, 0)
                pId_Huong.Value = Id_Huong
                MyCommand.Parameters.Add(pId_Huong)


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


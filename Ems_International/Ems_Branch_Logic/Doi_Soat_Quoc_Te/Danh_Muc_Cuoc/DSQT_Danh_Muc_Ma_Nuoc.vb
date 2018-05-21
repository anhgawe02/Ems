
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "DSQT_Danh_Muc_Ma_Nuoc_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop DSQT_Danh_Muc_Ma_Nuoc_Chi_Tiet
    'Tuong ung voi moi truong trong bang DSQT_Danh_Muc_Ma_Nuoc trong co so du lieu
    '***********************************************************
    Public Class DSQT_Danh_Muc_Ma_Nuoc_Chi_Tiet
        Public Ma_Nuoc As String
        Public Ten_Nuoc As String
        Public Ma_Khu_Vuc As String
    End Class
#End Region

#Region "DSQT_Danh_Muc_Ma_Nuoc"
    Public Class DSQT_Danh_Muc_Ma_Nuoc
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "DSQT_Danh_Muc_Ma_Nuoc_Cap_Nhat"
        Public Function DSQT_Danh_Muc_Ma_Nuoc_Cap_Nhat(ByVal Ma_Nuoc As String, ByVal Ten_Nuoc As String, ByVal Ma_Khu_Vuc As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Ma_Nuoc_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Danh_Muc_Ma_Nuoc_Chi_Tiet As New DSQT_Danh_Muc_Ma_Nuoc_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pTen_Nuoc As SqlParameter = New SqlParameter("@Ten_Nuoc", SqlDbType.NVarChar, 100)
                pTen_Nuoc.Value = Ten_Nuoc
                MyCommand.Parameters.Add(pTen_Nuoc)

                Dim pMa_Khu_Vuc As SqlParameter = New SqlParameter("@Ma_Khu_Vuc", SqlDbType.VarChar, 10)
                pMa_Khu_Vuc.Value = Ma_Khu_Vuc
                MyCommand.Parameters.Add(pMa_Khu_Vuc)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()

                Return numRows
                'Return numRows

            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)

            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()

            End Try
        End Function

#End Region

#Region "DSQT_Danh_Muc_Ma_Nuoc_Cap_Nhat_Them"
        Public Function DSQT_Danh_Muc_Ma_Nuoc_Cap_Nhat_Them(ByVal Ma_Nuoc As String, ByVal Ten_Nuoc As String, ByVal Ma_Khu_Vuc As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Ma_Nuoc_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Danh_Muc_Ma_Nuoc_Chi_Tiet As New DSQT_Danh_Muc_Ma_Nuoc_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pTen_Nuoc As SqlParameter = New SqlParameter("@Ten_Nuoc", SqlDbType.NVarChar, 100)
                pTen_Nuoc.Value = Ten_Nuoc
                MyCommand.Parameters.Add(pTen_Nuoc)

                Dim pMa_Khu_Vuc As SqlParameter = New SqlParameter("@Ma_Khu_Vuc", SqlDbType.VarChar, 10)
                pMa_Khu_Vuc.Value = Ma_Khu_Vuc
                MyCommand.Parameters.Add(pMa_Khu_Vuc)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()

                Return numRows
                'Return numRows

            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)

            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()

            End Try
        End Function

#End Region


#Region "DSQT_Danh_Muc_Ma_Nuoc_Danh_Sach"

        Public Function DSQT_Danh_Muc_Ma_Nuoc_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Ma_Nuoc
            ' Ten_Nuoc
            ' Ma_Khu_Vuc


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Ma_Nuoc_Danh_Sach"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters


                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                adapter.Fill(MyDataSet)

                Return MyDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                adapter.Dispose()
            End Try
        End Function
#End Region


#Region "DSQT_Danh_Muc_Ma_Nuoc_Danh_Sach_Rut_Gon"

        Public Function DSQT_Danh_Muc_Ma_Nuoc_Danh_Sach_Rut_Gon() As DataSet

            ' The procedure returns these columns:
            ' Ma_Nuoc
            ' Ten_Nuoc


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Ma_Nuoc_Danh_Sach_Rut_Gon"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters


                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                adapter.Fill(MyDataSet)

                Return MyDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                adapter.Dispose()
            End Try
        End Function
#End Region

#Region "DSQT_Danh_Muc_Ma_Nuoc_Lay"
        Public Function DSQT_Danh_Muc_Ma_Nuoc_Lay(ByVal Ma_Nuoc As String) As DSQT_Danh_Muc_Ma_Nuoc_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Ma_Nuoc_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Danh_Muc_Ma_Nuoc_Chi_Tiet As New DSQT_Danh_Muc_Ma_Nuoc_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pTen_Nuoc As SqlParameter = New SqlParameter("@Ten_Nuoc", SqlDbType.NVarChar, 100)
                pTen_Nuoc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTen_Nuoc)

                Dim pMa_Khu_Vuc As SqlParameter = New SqlParameter("@Ma_Khu_Vuc", SqlDbType.VarChar, 10)
                pMa_Khu_Vuc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Khu_Vuc)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myDSQT_Danh_Muc_Ma_Nuoc_Chi_Tiet.Ma_Nuoc = Ma_Nuoc
                myDSQT_Danh_Muc_Ma_Nuoc_Chi_Tiet.Ten_Nuoc = pTen_Nuoc.Value
                myDSQT_Danh_Muc_Ma_Nuoc_Chi_Tiet.Ma_Khu_Vuc = pMa_Khu_Vuc.Value

                Return myDSQT_Danh_Muc_Ma_Nuoc_Chi_Tiet
                'Return myDSQT_Danh_Muc_Ma_Nuoc_Chi_Tiet

            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)

            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()

            End Try
        End Function

#End Region

#Region "DSQT_Danh_Muc_Ma_Nuoc_Them"
        Public Function DSQT_Danh_Muc_Ma_Nuoc_Them(ByVal Ma_Nuoc As String, ByVal Ten_Nuoc As String, ByVal Ma_Khu_Vuc As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Ma_Nuoc_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Danh_Muc_Ma_Nuoc_Chi_Tiet As New DSQT_Danh_Muc_Ma_Nuoc_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pTen_Nuoc As SqlParameter = New SqlParameter("@Ten_Nuoc", SqlDbType.NVarChar, 100)
                pTen_Nuoc.Value = Ten_Nuoc
                MyCommand.Parameters.Add(pTen_Nuoc)

                Dim pMa_Khu_Vuc As SqlParameter = New SqlParameter("@Ma_Khu_Vuc", SqlDbType.VarChar, 10)
                pMa_Khu_Vuc.Value = Ma_Khu_Vuc
                MyCommand.Parameters.Add(pMa_Khu_Vuc)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()

                Return numRows
                'Return numRows

            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)

            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()

            End Try
        End Function

#End Region

#Region "DSQT_Danh_Muc_Ma_Nuoc_Xoa"
        Public Function DSQT_Danh_Muc_Ma_Nuoc_Xoa(ByVal Ma_Nuoc As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Ma_Nuoc_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Danh_Muc_Ma_Nuoc_Chi_Tiet As New DSQT_Danh_Muc_Ma_Nuoc_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                MyCommand.Parameters.Add(pMa_Nuoc)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()

                Return numRows
                'Return numRows

            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)

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


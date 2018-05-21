
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "DSQT_Danh_Muc_Bc_Quoc_Te_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop DSQT_Danh_Muc_Bc_Quoc_Te_Chi_Tiet
    'Tuong ung voi moi truong trong bang DSQT_Danh_Muc_Bc_Quoc_Te trong co so du lieu
    '***********************************************************
    Public Class DSQT_Danh_Muc_Bc_Quoc_Te_Chi_Tiet
        Public Ma_Bc As Integer
        Public Ten_Bc As String
        Public Ma_Nuoc As String
        Public Ma_Vung As String
        Public IMPC As String
        Public Thanh_Toan As Boolean
    End Class
#End Region

#Region "DSQT_Danh_Muc_Bc_Quoc_Te"
    Public Class DSQT_Danh_Muc_Bc_Quoc_Te
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "DSQT_Danh_Muc_Bc_Quoc_Te_Cap_Nhat"
        Public Function DSQT_Danh_Muc_Bc_Quoc_Te_Cap_Nhat(ByVal Ma_Bc As Integer, ByVal Ten_Bc As String, ByVal Ma_Nuoc As String, ByVal Ma_Vung As String, ByVal IMPC As String, ByVal Thanh_Toan As Boolean) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Bc_Quoc_Te_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Danh_Muc_Bc_Quoc_Te_Chi_Tiet As New DSQT_Danh_Muc_Bc_Quoc_Te_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 0)
                pMa_Bc.Value = Ma_Bc
                MyCommand.Parameters.Add(pMa_Bc)

                Dim pTen_Bc As SqlParameter = New SqlParameter("@Ten_Bc", SqlDbType.NVarChar, 50)
                pTen_Bc.Value = Ten_Bc
                MyCommand.Parameters.Add(pTen_Bc)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pMa_Vung As SqlParameter = New SqlParameter("@Ma_Vung", SqlDbType.VarChar, 3)
                pMa_Vung.Value = Ma_Vung
                MyCommand.Parameters.Add(pMa_Vung)

                Dim pIMPC As SqlParameter = New SqlParameter("@IMPC", SqlDbType.VarChar, 6)
                pIMPC.Value = IMPC
                MyCommand.Parameters.Add(pIMPC)

                Dim pThanh_Toan As SqlParameter = New SqlParameter("@Thanh_Toan", SqlDbType.Bit, 0)
                pThanh_Toan.Value = Thanh_Toan
                MyCommand.Parameters.Add(pThanh_Toan)


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

#Region "DSQT_Danh_Muc_Bc_Quoc_Te_Cap_Nhat_Them"
        Public Function DSQT_Danh_Muc_Bc_Quoc_Te_Cap_Nhat_Them(ByVal Ma_Bc As Integer, ByVal Ten_Bc As String, ByVal Ma_Nuoc As String, ByVal Ma_Vung As String, ByVal IMPC As String, ByVal Thanh_Toan As Boolean) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Bc_Quoc_Te_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Danh_Muc_Bc_Quoc_Te_Chi_Tiet As New DSQT_Danh_Muc_Bc_Quoc_Te_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 0)
                pMa_Bc.Value = Ma_Bc
                MyCommand.Parameters.Add(pMa_Bc)

                Dim pTen_Bc As SqlParameter = New SqlParameter("@Ten_Bc", SqlDbType.NVarChar, 50)
                pTen_Bc.Value = Ten_Bc
                MyCommand.Parameters.Add(pTen_Bc)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pMa_Vung As SqlParameter = New SqlParameter("@Ma_Vung", SqlDbType.VarChar, 3)
                pMa_Vung.Value = Ma_Vung
                MyCommand.Parameters.Add(pMa_Vung)

                Dim pIMPC As SqlParameter = New SqlParameter("@IMPC", SqlDbType.VarChar, 6)
                pIMPC.Value = IMPC
                MyCommand.Parameters.Add(pIMPC)

                Dim pThanh_Toan As SqlParameter = New SqlParameter("@Thanh_Toan", SqlDbType.Bit, 0)
                pThanh_Toan.Value = Thanh_Toan
                MyCommand.Parameters.Add(pThanh_Toan)


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

#Region "DSQT_Danh_Muc_Bc_Quoc_Te_Danh_Sach"

        Public Function DSQT_Danh_Muc_Bc_Quoc_Te_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Ma_Bc
            ' Ten_Bc
            ' Ma_Nuoc
            ' Ma_Vung
            ' IMPC
            ' Thanh_Toan


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Bc_Quoc_Te_Danh_Sach"
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
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                Adapter.Dispose()
            End Try
        End Function
#End Region

#Region "DSQT_Danh_Muc_Bc_Quoc_Te_Lay"
        Public Function DSQT_Danh_Muc_Bc_Quoc_Te_Lay(ByVal Ma_Bc As Integer) As DSQT_Danh_Muc_Bc_Quoc_Te_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Bc_Quoc_Te_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Danh_Muc_Bc_Quoc_Te_Chi_Tiet As New DSQT_Danh_Muc_Bc_Quoc_Te_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 0)
                pMa_Bc.Value = Ma_Bc
                MyCommand.Parameters.Add(pMa_Bc)

                Dim pTen_Bc As SqlParameter = New SqlParameter("@Ten_Bc", SqlDbType.NVarChar, 50)
                pTen_Bc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTen_Bc)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pMa_Vung As SqlParameter = New SqlParameter("@Ma_Vung", SqlDbType.VarChar, 3)
                pMa_Vung.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Vung)

                Dim pIMPC As SqlParameter = New SqlParameter("@IMPC", SqlDbType.VarChar, 6)
                pIMPC.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pIMPC)

                Dim pThanh_Toan As SqlParameter = New SqlParameter("@Thanh_Toan", SqlDbType.Bit, 0)
                pThanh_Toan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThanh_Toan)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myDSQT_Danh_Muc_Bc_Quoc_Te_Chi_Tiet.Ten_Bc = pTen_Bc.Value
                myDSQT_Danh_Muc_Bc_Quoc_Te_Chi_Tiet.Ma_Nuoc = pMa_Nuoc.Value
                myDSQT_Danh_Muc_Bc_Quoc_Te_Chi_Tiet.Ma_Vung = pMa_Vung.Value
                myDSQT_Danh_Muc_Bc_Quoc_Te_Chi_Tiet.IMPC = pIMPC.Value
                myDSQT_Danh_Muc_Bc_Quoc_Te_Chi_Tiet.Thanh_Toan = pThanh_Toan.Value

                Return myDSQT_Danh_Muc_Bc_Quoc_Te_Chi_Tiet
                'Return myDSQT_Danh_Muc_Bc_Quoc_Te_Chi_Tiet

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

#Region "DSQT_Danh_Muc_Bc_Quoc_Te_Them"
        Public Function DSQT_Danh_Muc_Bc_Quoc_Te_Them(ByVal Ma_Bc As Integer, ByVal Ten_Bc As String, ByVal Ma_Nuoc As String, ByVal Ma_Vung As String, ByVal IMPC As String, ByVal Thanh_Toan As Boolean) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Bc_Quoc_Te_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Danh_Muc_Bc_Quoc_Te_Chi_Tiet As New DSQT_Danh_Muc_Bc_Quoc_Te_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 0)
                pMa_Bc.Value = Ma_Bc
                MyCommand.Parameters.Add(pMa_Bc)

                Dim pTen_Bc As SqlParameter = New SqlParameter("@Ten_Bc", SqlDbType.NVarChar, 50)
                pTen_Bc.Value = Ten_Bc
                MyCommand.Parameters.Add(pTen_Bc)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pMa_Vung As SqlParameter = New SqlParameter("@Ma_Vung", SqlDbType.VarChar, 3)
                pMa_Vung.Value = Ma_Vung
                MyCommand.Parameters.Add(pMa_Vung)

                Dim pIMPC As SqlParameter = New SqlParameter("@IMPC", SqlDbType.VarChar, 6)
                pIMPC.Value = IMPC
                MyCommand.Parameters.Add(pIMPC)

                Dim pThanh_Toan As SqlParameter = New SqlParameter("@Thanh_Toan", SqlDbType.Bit, 0)
                pThanh_Toan.Value = Thanh_Toan
                MyCommand.Parameters.Add(pThanh_Toan)


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

#Region "DSQT_Danh_Muc_Bc_Quoc_Te_Xoa"
        Public Function DSQT_Danh_Muc_Bc_Quoc_Te_Xoa(ByVal Ma_Bc As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Bc_Quoc_Te_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Danh_Muc_Bc_Quoc_Te_Chi_Tiet As New DSQT_Danh_Muc_Bc_Quoc_Te_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 0)
                pMa_Bc.Value = Ma_Bc
                MyCommand.Parameters.Add(pMa_Bc)


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

#Region "DSQT_Danh_Muc_Bc_Quoc_Te_Lay_Theo_Ma_Nuoc_Thanh_Toan"
        Public Function DSQT_Danh_Muc_Bc_Quoc_Te_Lay_Theo_Ma_Nuoc_Thanh_Toan(ByVal Ma_Nuoc As String) As DSQT_Danh_Muc_Bc_Quoc_Te_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Bc_Quoc_Te_Lay_Theo_Ma_Nuoc_Thanh_Toan"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Danh_Muc_Bc_Quoc_Te_Chi_Tiet As New DSQT_Danh_Muc_Bc_Quoc_Te_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters
                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 0)
                pMa_Bc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc)

                Dim pTen_Bc As SqlParameter = New SqlParameter("@Ten_Bc", SqlDbType.NVarChar, 50)
                pTen_Bc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTen_Bc)

                Dim pMa_Vung As SqlParameter = New SqlParameter("@Ma_Vung", SqlDbType.VarChar, 3)
                pMa_Vung.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Vung)

                Dim pIMPC As SqlParameter = New SqlParameter("@IMPC", SqlDbType.VarChar, 6)
                pIMPC.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pIMPC)

                Dim pThanh_Toan As SqlParameter = New SqlParameter("@Thanh_Toan", SqlDbType.Bit, 0)
                pThanh_Toan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThanh_Toan)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myDSQT_Danh_Muc_Bc_Quoc_Te_Chi_Tiet.Ma_Bc = pMa_Bc.Value
                myDSQT_Danh_Muc_Bc_Quoc_Te_Chi_Tiet.Ten_Bc = pTen_Bc.Value
                myDSQT_Danh_Muc_Bc_Quoc_Te_Chi_Tiet.Ma_Nuoc = Ma_Nuoc
                myDSQT_Danh_Muc_Bc_Quoc_Te_Chi_Tiet.Ma_Vung = pMa_Vung.Value
                myDSQT_Danh_Muc_Bc_Quoc_Te_Chi_Tiet.IMPC = pIMPC.Value
                myDSQT_Danh_Muc_Bc_Quoc_Te_Chi_Tiet.Thanh_Toan = pThanh_Toan.Value

                Return myDSQT_Danh_Muc_Bc_Quoc_Te_Chi_Tiet
                'Return myDSQT_Danh_Muc_Bc_Quoc_Te_Chi_Tiet

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


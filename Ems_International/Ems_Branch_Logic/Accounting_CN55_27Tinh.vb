
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "Accounting_CN55_27Tinh_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop Accounting_CN55_27Tinh_Chi_Tiet
    'Tuong ung voi moi truong trong bang Accounting_CN55_27Tinh trong co so du lieu
    '***********************************************************
    Public Class Accounting_CN55_27Tinh_Chi_Tiet
        Public Id As Integer
        Public Ten_Tinh As String
        Public Ma_Bc_Bat_Dau As Integer
        Public Ma_Bc_Ket_Thuc As Integer
        Public Khu_Vuc As Integer
    End Class
#End Region

#Region "Accounting_CN55_27Tinh"
    Public Class Accounting_CN55_27Tinh
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "Accounting_CN55_27Tinh_Cap_Nhat"
        Public Function Accounting_CN55_27Tinh_Cap_Nhat(ByVal Id As Integer, ByVal Ten_Tinh As String, ByVal Ma_Bc_Bat_Dau As Integer, ByVal Ma_Bc_Ket_Thuc As Integer, ByVal Khu_Vuc As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_CN55_27Tinh_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myAccounting_CN55_27Tinh_Chi_Tiet As New Accounting_CN55_27Tinh_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId As SqlParameter = New SqlParameter("@Id", SqlDbType.Int, 0)
                pId.Value = Id
                MyCommand.Parameters.Add(pId)

                Dim pTen_Tinh As SqlParameter = New SqlParameter("@Ten_Tinh", SqlDbType.NVarChar, 100)
                pTen_Tinh.Value = Ten_Tinh
                MyCommand.Parameters.Add(pTen_Tinh)

                Dim pMa_Bc_Bat_Dau As SqlParameter = New SqlParameter("@Ma_Bc_Bat_Dau", SqlDbType.Int, 0)
                pMa_Bc_Bat_Dau.Value = Ma_Bc_Bat_Dau
                MyCommand.Parameters.Add(pMa_Bc_Bat_Dau)

                Dim pMa_Bc_Ket_Thuc As SqlParameter = New SqlParameter("@Ma_Bc_Ket_Thuc", SqlDbType.Int, 0)
                pMa_Bc_Ket_Thuc.Value = Ma_Bc_Ket_Thuc
                MyCommand.Parameters.Add(pMa_Bc_Ket_Thuc)

                Dim pKhu_Vuc As SqlParameter = New SqlParameter("@Khu_Vuc", SqlDbType.Int, 0)
                pKhu_Vuc.Value = Khu_Vuc
                MyCommand.Parameters.Add(pKhu_Vuc)


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

#Region "Accounting_CN55_27Tinh_Cap_Nhat_Them"
        Public Function Accounting_CN55_27Tinh_Cap_Nhat_Them(ByVal Id As Integer, ByVal Ten_Tinh As String, ByVal Ma_Bc_Bat_Dau As Integer, ByVal Ma_Bc_Ket_Thuc As Integer, ByVal Khu_Vuc As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_CN55_27Tinh_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myAccounting_CN55_27Tinh_Chi_Tiet As New Accounting_CN55_27Tinh_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId As SqlParameter = New SqlParameter("@Id", SqlDbType.Int, 0)
                pId.Value = Id
                MyCommand.Parameters.Add(pId)

                Dim pTen_Tinh As SqlParameter = New SqlParameter("@Ten_Tinh", SqlDbType.NVarChar, 100)
                pTen_Tinh.Value = Ten_Tinh
                MyCommand.Parameters.Add(pTen_Tinh)

                Dim pMa_Bc_Bat_Dau As SqlParameter = New SqlParameter("@Ma_Bc_Bat_Dau", SqlDbType.Int, 0)
                pMa_Bc_Bat_Dau.Value = Ma_Bc_Bat_Dau
                MyCommand.Parameters.Add(pMa_Bc_Bat_Dau)

                Dim pMa_Bc_Ket_Thuc As SqlParameter = New SqlParameter("@Ma_Bc_Ket_Thuc", SqlDbType.Int, 0)
                pMa_Bc_Ket_Thuc.Value = Ma_Bc_Ket_Thuc
                MyCommand.Parameters.Add(pMa_Bc_Ket_Thuc)

                Dim pKhu_Vuc As SqlParameter = New SqlParameter("@Khu_Vuc", SqlDbType.Int, 0)
                pKhu_Vuc.Value = Khu_Vuc
                MyCommand.Parameters.Add(pKhu_Vuc)


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


#Region "Accounting_CN55_27Tinh_Danh_Sach"

        Public Function Accounting_CN55_27Tinh_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Id
            ' Ten_Tinh
            ' Ma_Bc_Bat_Dau
            ' Ma_Bc_Ket_Thuc
            ' Khu_Vuc


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_CN55_27Tinh_Danh_Sach"
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

#Region "Accounting_CN55_27Tinh_Lay"
        Public Function Accounting_CN55_27Tinh_Lay(ByVal Id As Integer) As Accounting_CN55_27Tinh_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_CN55_27Tinh_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myAccounting_CN55_27Tinh_Chi_Tiet As New Accounting_CN55_27Tinh_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId As SqlParameter = New SqlParameter("@Id", SqlDbType.Int, 0)
                pId.Value = Id
                MyCommand.Parameters.Add(pId)

                Dim pTen_Tinh As SqlParameter = New SqlParameter("@Ten_Tinh", SqlDbType.NVarChar, 100)
                pTen_Tinh.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTen_Tinh)

                Dim pMa_Bc_Bat_Dau As SqlParameter = New SqlParameter("@Ma_Bc_Bat_Dau", SqlDbType.Int, 0)
                pMa_Bc_Bat_Dau.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc_Bat_Dau)

                Dim pMa_Bc_Ket_Thuc As SqlParameter = New SqlParameter("@Ma_Bc_Ket_Thuc", SqlDbType.Int, 0)
                pMa_Bc_Ket_Thuc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc_Ket_Thuc)

                Dim pKhu_Vuc As SqlParameter = New SqlParameter("@Khu_Vuc", SqlDbType.Int, 0)
                pKhu_Vuc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pKhu_Vuc)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myAccounting_CN55_27Tinh_Chi_Tiet.Id = Id
                myAccounting_CN55_27Tinh_Chi_Tiet.Ten_Tinh = pTen_Tinh.Value
                myAccounting_CN55_27Tinh_Chi_Tiet.Ma_Bc_Bat_Dau = pMa_Bc_Bat_Dau.Value
                myAccounting_CN55_27Tinh_Chi_Tiet.Ma_Bc_Ket_Thuc = pMa_Bc_Ket_Thuc.Value
                myAccounting_CN55_27Tinh_Chi_Tiet.Khu_Vuc = pKhu_Vuc.Value

                Return myAccounting_CN55_27Tinh_Chi_Tiet
                'Return myAccounting_CN55_27Tinh_Chi_Tiet

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

#Region "Accounting_CN55_27Tinh_Them"
        Public Function Accounting_CN55_27Tinh_Them(ByVal Ten_Tinh As String, ByVal Ma_Bc_Bat_Dau As Integer, ByVal Ma_Bc_Ket_Thuc As Integer, ByVal Khu_Vuc As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_CN55_27Tinh_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myAccounting_CN55_27Tinh_Chi_Tiet As New Accounting_CN55_27Tinh_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pTen_Tinh As SqlParameter = New SqlParameter("@Ten_Tinh", SqlDbType.NVarChar, 100)
                pTen_Tinh.Value = Ten_Tinh
                MyCommand.Parameters.Add(pTen_Tinh)

                Dim pMa_Bc_Bat_Dau As SqlParameter = New SqlParameter("@Ma_Bc_Bat_Dau", SqlDbType.Int, 0)
                pMa_Bc_Bat_Dau.Value = Ma_Bc_Bat_Dau
                MyCommand.Parameters.Add(pMa_Bc_Bat_Dau)

                Dim pMa_Bc_Ket_Thuc As SqlParameter = New SqlParameter("@Ma_Bc_Ket_Thuc", SqlDbType.Int, 0)
                pMa_Bc_Ket_Thuc.Value = Ma_Bc_Ket_Thuc
                MyCommand.Parameters.Add(pMa_Bc_Ket_Thuc)

                Dim pKhu_Vuc As SqlParameter = New SqlParameter("@Khu_Vuc", SqlDbType.Int, 0)
                pKhu_Vuc.Value = Khu_Vuc
                MyCommand.Parameters.Add(pKhu_Vuc)

                Dim pId As SqlParameter = New SqlParameter("@Id", SqlDbType.Int, 0)
                pId.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                'myAccounting_CN55_27Tinh_Chi_Tiet.Ten_Tinh = Id
                myAccounting_CN55_27Tinh_Chi_Tiet.Ma_Bc_Bat_Dau = Ten_Tinh
                myAccounting_CN55_27Tinh_Chi_Tiet.Ma_Bc_Ket_Thuc = Ma_Bc_Bat_Dau
                myAccounting_CN55_27Tinh_Chi_Tiet.Khu_Vuc = Ma_Bc_Ket_Thuc
                myAccounting_CN55_27Tinh_Chi_Tiet.Id = pKhu_Vuc.Value

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

#Region "Accounting_CN55_27Tinh_Xoa"
        Public Function Accounting_CN55_27Tinh_Xoa(ByVal Id As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_CN55_27Tinh_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myAccounting_CN55_27Tinh_Chi_Tiet As New Accounting_CN55_27Tinh_Chi_Tiet

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


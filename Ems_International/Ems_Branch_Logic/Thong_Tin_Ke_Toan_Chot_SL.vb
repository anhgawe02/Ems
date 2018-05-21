
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "Thong_Tin_Ke_Toan_Chot_SL_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop Thong_Tin_Ke_Toan_Chot_SL_Chi_Tiet
    'Tuong ung voi moi truong trong bang Thong_Tin_Ke_Toan_Chot_SL trong co so du lieu
    '***********************************************************
    Public Class Thong_Tin_Ke_Toan_Chot_SL_Chi_Tiet
        Public Id_Thang As String
        Public Phan_Loai As Integer
        Public Chot_SL As Boolean
    End Class
#End Region

#Region "Thong_Tin_Ke_Toan_Chot_SL"
    Public Class Thong_Tin_Ke_Toan_Chot_SL
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "Thong_Tin_Ke_Toan_Chot_SL_Cap_Nhat"
        Public Function Thong_Tin_Ke_Toan_Chot_SL_Cap_Nhat(ByVal Id_Thang As String, ByVal Phan_Loai As Integer, ByVal Chot_SL As Boolean) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Thong_Tin_Ke_Toan_Chot_SL_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myThong_Tin_Ke_Toan_Chot_SL_Chi_Tiet As New Thong_Tin_Ke_Toan_Chot_SL_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Thang As SqlParameter = New SqlParameter("@Id_Thang", SqlDbType.VarChar, 10)
                pId_Thang.Value = Id_Thang
                MyCommand.Parameters.Add(pId_Thang)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.Int, 0)
                pPhan_Loai.Value = Phan_Loai
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 0)
                pChot_SL.Value = Chot_SL
                MyCommand.Parameters.Add(pChot_SL)


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

#Region "Thong_Tin_Ke_Toan_Chot_SL_Cap_Nhat_Them"
        Public Function Thong_Tin_Ke_Toan_Chot_SL_Cap_Nhat_Them(ByVal Id_Thang As String, ByVal Phan_Loai As Integer, ByVal Chot_SL As Boolean) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Thong_Tin_Ke_Toan_Chot_SL_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myThong_Tin_Ke_Toan_Chot_SL_Chi_Tiet As New Thong_Tin_Ke_Toan_Chot_SL_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Thang As SqlParameter = New SqlParameter("@Id_Thang", SqlDbType.VarChar, 10)
                pId_Thang.Value = Id_Thang
                MyCommand.Parameters.Add(pId_Thang)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.Int, 0)
                pPhan_Loai.Value = Phan_Loai
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 0)
                pChot_SL.Value = Chot_SL
                MyCommand.Parameters.Add(pChot_SL)


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


#Region "Thong_Tin_Ke_Toan_Chot_SL_Danh_Sach"

        Public Function Thong_Tin_Ke_Toan_Chot_SL_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Id_Thang
            ' Phan_Loai
            ' Chot_SL


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Thong_Tin_Ke_Toan_Chot_SL_Danh_Sach"
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

#Region "Thong_Tin_Ke_Toan_Chot_SL_Lay"
        Public Function Thong_Tin_Ke_Toan_Chot_SL_Lay(ByVal Id_Thang As String) As Thong_Tin_Ke_Toan_Chot_SL_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Thong_Tin_Ke_Toan_Chot_SL_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myThong_Tin_Ke_Toan_Chot_SL_Chi_Tiet As New Thong_Tin_Ke_Toan_Chot_SL_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Thang As SqlParameter = New SqlParameter("@Id_Thang", SqlDbType.VarChar, 10)
                pId_Thang.Value = Id_Thang
                MyCommand.Parameters.Add(pId_Thang)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.Int, 0)
                pPhan_Loai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 0)
                pChot_SL.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pChot_SL)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myThong_Tin_Ke_Toan_Chot_SL_Chi_Tiet.Id_Thang = Id_Thang
                myThong_Tin_Ke_Toan_Chot_SL_Chi_Tiet.Phan_Loai = pPhan_Loai.Value
                myThong_Tin_Ke_Toan_Chot_SL_Chi_Tiet.Chot_SL = pChot_SL.Value

                Return myThong_Tin_Ke_Toan_Chot_SL_Chi_Tiet
                'Return myThong_Tin_Ke_Toan_Chot_SL_Chi_Tiet

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

#Region "Thong_Tin_Ke_Toan_Chot_SL_Them"
        Public Function Thong_Tin_Ke_Toan_Chot_SL_Them(ByVal Id_Thang As String, ByVal Phan_Loai As Integer, ByVal Chot_SL As Boolean) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Thong_Tin_Ke_Toan_Chot_SL_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myThong_Tin_Ke_Toan_Chot_SL_Chi_Tiet As New Thong_Tin_Ke_Toan_Chot_SL_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Thang As SqlParameter = New SqlParameter("@Id_Thang", SqlDbType.VarChar, 10)
                pId_Thang.Value = Id_Thang
                MyCommand.Parameters.Add(pId_Thang)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.Int, 0)
                pPhan_Loai.Value = Phan_Loai
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 0)
                pChot_SL.Value = Chot_SL
                MyCommand.Parameters.Add(pChot_SL)


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

#Region "Thong_Tin_Ke_Toan_Chot_SL_Xoa"
        Public Function Thong_Tin_Ke_Toan_Chot_SL_Xoa(ByVal Id_Thang As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Thong_Tin_Ke_Toan_Chot_SL_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myThong_Tin_Ke_Toan_Chot_SL_Chi_Tiet As New Thong_Tin_Ke_Toan_Chot_SL_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Thang As SqlParameter = New SqlParameter("@Id_Thang", SqlDbType.VarChar, 10)
                pId_Thang.Value = Id_Thang
                MyCommand.Parameters.Add(pId_Thang)


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


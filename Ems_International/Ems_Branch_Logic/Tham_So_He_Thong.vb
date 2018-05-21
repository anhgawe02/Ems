
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "Tham_So_He_Thong_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop Tham_So_He_Thong_Chi_Tiet
    'Tuong ung voi moi truong trong bang Tham_So_He_Thong trong co so du lieu
    '***********************************************************
    Public Class Tham_So_He_Thong_Chi_Tiet
        Public Tham_So As String
        Public Gia_Tri As String
        Public Kieu_Gia_Tri As Integer
        Public Ghi_Chu As String
    End Class
#End Region

#Region "Tham_So_He_Thong"
    Public Class Tham_So_He_Thong
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "Tham_So_He_Thong_Cap_Nhat"
        Public Function Tham_So_He_Thong_Cap_Nhat(ByVal Tham_So As String, ByVal Gia_Tri As String, ByVal Kieu_Gia_Tri As Integer, ByVal Ghi_Chu As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Tham_So_He_Thong_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myTham_So_He_Thong_Chi_Tiet As New Tham_So_He_Thong_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pTham_So As SqlParameter = New SqlParameter("@Tham_So", SqlDbType.VarChar, 30)
                pTham_So.Value = Tham_So
                MyCommand.Parameters.Add(pTham_So)

                Dim pGia_Tri As SqlParameter = New SqlParameter("@Gia_Tri", SqlDbType.VarChar, 100)
                pGia_Tri.Value = Gia_Tri
                MyCommand.Parameters.Add(pGia_Tri)

                Dim pKieu_Gia_Tri As SqlParameter = New SqlParameter("@Kieu_Gia_Tri", SqlDbType.Int, 0)
                pKieu_Gia_Tri.Value = Kieu_Gia_Tri
                MyCommand.Parameters.Add(pKieu_Gia_Tri)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)


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

#Region "Tham_So_He_Thong_Cap_Nhat_Them"
        Public Function Tham_So_He_Thong_Cap_Nhat_Them(ByVal Tham_So As String, ByVal Gia_Tri As String, ByVal Kieu_Gia_Tri As Integer, ByVal Ghi_Chu As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Tham_So_He_Thong_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myTham_So_He_Thong_Chi_Tiet As New Tham_So_He_Thong_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pTham_So As SqlParameter = New SqlParameter("@Tham_So", SqlDbType.VarChar, 30)
                pTham_So.Value = Tham_So
                MyCommand.Parameters.Add(pTham_So)

                Dim pGia_Tri As SqlParameter = New SqlParameter("@Gia_Tri", SqlDbType.VarChar, 100)
                pGia_Tri.Value = Gia_Tri
                MyCommand.Parameters.Add(pGia_Tri)

                Dim pKieu_Gia_Tri As SqlParameter = New SqlParameter("@Kieu_Gia_Tri", SqlDbType.Int, 0)
                pKieu_Gia_Tri.Value = Kieu_Gia_Tri
                MyCommand.Parameters.Add(pKieu_Gia_Tri)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)


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

#Region "Tham_So_He_Thong_Danh_Sach"

        Public Function Tham_So_He_Thong_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Tham_So
            ' Gia_Tri
            ' Kieu_Gia_Tri
            ' Ghi_Chu


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Tham_So_He_Thong_Danh_Sach"
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

#Region "Tham_So_He_Thong_Lay"
        Public Function Tham_So_He_Thong_Lay(ByVal Tham_So As String) As Tham_So_He_Thong_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Tham_So_He_Thong_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myTham_So_He_Thong_Chi_Tiet As New Tham_So_He_Thong_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pTham_So As SqlParameter = New SqlParameter("@Tham_So", SqlDbType.VarChar, 30)
                pTham_So.Value = Tham_So
                MyCommand.Parameters.Add(pTham_So)

                Dim pGia_Tri As SqlParameter = New SqlParameter("@Gia_Tri", SqlDbType.VarChar, 100)
                pGia_Tri.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGia_Tri)

                Dim pKieu_Gia_Tri As SqlParameter = New SqlParameter("@Kieu_Gia_Tri", SqlDbType.Int, 0)
                pKieu_Gia_Tri.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pKieu_Gia_Tri)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
                pGhi_Chu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGhi_Chu)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myTham_So_He_Thong_Chi_Tiet.Gia_Tri = pGia_Tri.Value
                myTham_So_He_Thong_Chi_Tiet.Kieu_Gia_Tri = pKieu_Gia_Tri.Value
                myTham_So_He_Thong_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value

                Return myTham_So_He_Thong_Chi_Tiet
                'Return myTham_So_He_Thong_Chi_Tiet

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

#Region "Tham_So_He_Thong_Them"
        Public Function Tham_So_He_Thong_Them(ByVal Tham_So As String, ByVal Gia_Tri As String, ByVal Kieu_Gia_Tri As Integer, ByVal Ghi_Chu As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Tham_So_He_Thong_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myTham_So_He_Thong_Chi_Tiet As New Tham_So_He_Thong_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pTham_So As SqlParameter = New SqlParameter("@Tham_So", SqlDbType.VarChar, 30)
                pTham_So.Value = Tham_So
                MyCommand.Parameters.Add(pTham_So)

                Dim pGia_Tri As SqlParameter = New SqlParameter("@Gia_Tri", SqlDbType.VarChar, 100)
                pGia_Tri.Value = Gia_Tri
                MyCommand.Parameters.Add(pGia_Tri)

                Dim pKieu_Gia_Tri As SqlParameter = New SqlParameter("@Kieu_Gia_Tri", SqlDbType.Int, 0)
                pKieu_Gia_Tri.Value = Kieu_Gia_Tri
                MyCommand.Parameters.Add(pKieu_Gia_Tri)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)


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

#Region "Tham_So_He_Thong_Xoa"
        Public Function Tham_So_He_Thong_Xoa(ByVal Tham_So As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Tham_So_He_Thong_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myTham_So_He_Thong_Chi_Tiet As New Tham_So_He_Thong_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pTham_So As SqlParameter = New SqlParameter("@Tham_So", SqlDbType.VarChar, 30)
                pTham_So.Value = Tham_So
                MyCommand.Parameters.Add(pTham_So)


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



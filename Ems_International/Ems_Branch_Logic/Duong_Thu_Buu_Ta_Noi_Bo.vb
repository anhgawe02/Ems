
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "Duong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop Duong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet
    'Tuong ung voi moi truong trong bang Duong_Thu_Buu_Ta_Noi_Bo trong co so du lieu
    '***********************************************************
    Public Class Duong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet
        Public Id_Duong_Thu As String
        Public Ten_Duong_Thu As String
        Public Ma_Bc_Khai_Thac As Integer
        Public Ma_Bc As Integer
        Public Ma_Tinh As Integer
        Public Phan_Loai As Integer
        Public Ghi_Chu As String
    End Class
#End Region

#Region "Duong_Thu_Buu_Ta_Noi_Bo"
    Public Class Duong_Thu_Buu_Ta_Noi_Bo
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "Duong_Thu_Buu_Ta_Noi_Bo_Cap_Nhat"
        Public Function Duong_Thu_Buu_Ta_Noi_Bo_Cap_Nhat(ByVal Id_Duong_Thu As String, ByVal Ten_Duong_Thu As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Bc As Integer, ByVal Ma_Tinh As Integer, ByVal Phan_Loai As Integer, ByVal Ghi_Chu As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Duong_Thu_Buu_Ta_Noi_Bo_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDuong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet As New Duong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pTen_Duong_Thu As SqlParameter = New SqlParameter("@Ten_Duong_Thu", SqlDbType.NVarChar, 50)
                pTen_Duong_Thu.Value = Ten_Duong_Thu
                MyCommand.Parameters.Add(pTen_Duong_Thu)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 0)
                pMa_Bc.Value = Ma_Bc
                MyCommand.Parameters.Add(pMa_Bc)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 0)
                pMa_Tinh.Value = Ma_Tinh
                MyCommand.Parameters.Add(pMa_Tinh)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.Int, 0)
                pPhan_Loai.Value = Phan_Loai
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 50)
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

#Region "Duong_Thu_Buu_Ta_Noi_Bo_Cap_Nhat_Them"
        Public Function Duong_Thu_Buu_Ta_Noi_Bo_Cap_Nhat_Them(ByVal Id_Duong_Thu As String, ByVal Ten_Duong_Thu As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Bc As Integer, ByVal Ma_Tinh As Integer, ByVal Phan_Loai As Integer, ByVal Ghi_Chu As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Duong_Thu_Buu_Ta_Noi_Bo_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDuong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet As New Duong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pTen_Duong_Thu As SqlParameter = New SqlParameter("@Ten_Duong_Thu", SqlDbType.NVarChar, 50)
                pTen_Duong_Thu.Value = Ten_Duong_Thu
                MyCommand.Parameters.Add(pTen_Duong_Thu)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 0)
                pMa_Bc.Value = Ma_Bc
                MyCommand.Parameters.Add(pMa_Bc)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 0)
                pMa_Tinh.Value = Ma_Tinh
                MyCommand.Parameters.Add(pMa_Tinh)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.Int, 0)
                pPhan_Loai.Value = Phan_Loai
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 50)
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

#Region "Duong_Thu_Buu_Ta_Noi_Bo_Danh_Sach"

        Public Function Duong_Thu_Buu_Ta_Noi_Bo_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Id_Duong_Thu
            ' Ten_Duong_Thu
            ' Ma_Bc_Khai_Thac
            ' Ma_Bc
            ' Ma_Tinh
            ' Phan_Loai
            ' Ghi_Chu


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Duong_Thu_Buu_Ta_Noi_Bo_Danh_Sach"
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

#Region "Duong_Thu_Buu_Ta_Noi_Bo_Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac"

        Public Function Duong_Thu_Buu_Ta_Noi_Bo_Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac(ByVal Ma_Bc_Khai_Thac As Integer) As DataSet

            ' The procedure returns these columns:
            ' Id_Duong_Thu
            ' Ten_Duong_Thu
            ' Ma_Bc_Khai_Thac
            ' Ma_Bc
            ' Ma_Tinh
            ' Phan_Loai
            ' Ghi_Chu


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Duong_Thu_Buu_Ta_Noi_Bo_Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)


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

#Region "Duong_Thu_Buu_Ta_Noi_Bo_Danh_Sach_Rut_Gon_Lay_Boi_Ma_Bc_Khai_Thac"

        Public Function Duong_Thu_Buu_Ta_Noi_Bo_Danh_Sach_Rut_Gon_Lay_Boi_Ma_Bc_Khai_Thac(ByVal Ma_Bc_Khai_Thac As Integer) As DataSet

            ' The procedure returns these columns:
            ' Id_Duong_Thu
            ' Ten_Duong_Thu = Ma_Bc + '-' + Ten_Duong_Thu
            ' Ma_Bc_Khai_Thac
            ' Ma_Bc            


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Duong_Thu_Buu_Ta_Noi_Bo_Danh_Sach_Rut_Gon_Lay_Boi_Ma_Bc_Khai_Thac"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)


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

#Region "Duong_Thu_Buu_Ta_Noi_Bo_Lay"
        Public Function Duong_Thu_Buu_Ta_Noi_Bo_Lay(ByVal Id_Duong_Thu As String) As Duong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Duong_Thu_Buu_Ta_Noi_Bo_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDuong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet As New Duong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pTen_Duong_Thu As SqlParameter = New SqlParameter("@Ten_Duong_Thu", SqlDbType.NVarChar, 50)
                pTen_Duong_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTen_Duong_Thu)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 0)
                pMa_Bc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 0)
                pMa_Tinh.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Tinh)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.Int, 0)
                pPhan_Loai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 50)
                pGhi_Chu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGhi_Chu)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myDuong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet.Id_Duong_Thu = Id_Duong_Thu
                myDuong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet.Ten_Duong_Thu = pTen_Duong_Thu.Value
                myDuong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet.Ma_Bc_Khai_Thac = pMa_Bc_Khai_Thac.Value
                myDuong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet.Ma_Bc = pMa_Bc.Value
                myDuong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet.Ma_Tinh = pMa_Tinh.Value
                myDuong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet.Phan_Loai = pPhan_Loai.Value
                myDuong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value

                Return myDuong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet
                'Return myDuong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet

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

#Region "Duong_Thu_Buu_Ta_Noi_Bo_Them"
        Public Function Duong_Thu_Buu_Ta_Noi_Bo_Them(ByVal Id_Duong_Thu As String, ByVal Ten_Duong_Thu As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Bc As Integer, ByVal Ma_Tinh As Integer, ByVal Phan_Loai As Integer, ByVal Ghi_Chu As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Duong_Thu_Buu_Ta_Noi_Bo_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDuong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet As New Duong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pTen_Duong_Thu As SqlParameter = New SqlParameter("@Ten_Duong_Thu", SqlDbType.NVarChar, 50)
                pTen_Duong_Thu.Value = Ten_Duong_Thu
                MyCommand.Parameters.Add(pTen_Duong_Thu)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 0)
                pMa_Bc.Value = Ma_Bc
                MyCommand.Parameters.Add(pMa_Bc)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 0)
                pMa_Tinh.Value = Ma_Tinh
                MyCommand.Parameters.Add(pMa_Tinh)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.Int, 0)
                pPhan_Loai.Value = Phan_Loai
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 50)
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

#Region "Duong_Thu_Buu_Ta_Noi_Bo_Xoa"
        Public Function Duong_Thu_Buu_Ta_Noi_Bo_Xoa(ByVal Id_Duong_Thu As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Duong_Thu_Buu_Ta_Noi_Bo_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDuong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet As New Duong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pId_Duong_Thu)


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


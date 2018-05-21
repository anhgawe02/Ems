
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "Ds_Mat_Chuyen_Thu_Tui_So_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop Ds_Mat_Chuyen_Thu_Tui_So_Chi_Tiet
    'Tuong ung voi moi truong trong bang Ds_Mat_Chuyen_Thu_Tui_So trong co so du lieu
    '***********************************************************
    Public Class Ds_Mat_Chuyen_Thu_Tui_So_Chi_Tiet
        Public Id_Mat As String
        Public Loai As String
        Public Ngay_He_Thong As Integer
        Public Gio_He_Thong As Integer
    End Class
#End Region

#Region "Ds_Mat_Chuyen_Thu_Tui_So"
    Public Class Ds_Mat_Chuyen_Thu_Tui_So
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "Ds_Mat_Chuyen_Thu_Tui_So_Cap_Nhat"
        Public Function Ds_Mat_Chuyen_Thu_Tui_So_Cap_Nhat(ByVal Id_Mat As String, ByVal Loai As String, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Ds_Mat_Chuyen_Thu_Tui_So_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDs_Mat_Chuyen_Thu_Tui_So_Chi_Tiet As New Ds_Mat_Chuyen_Thu_Tui_So_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Mat As SqlParameter = New SqlParameter("@Id_Mat", SqlDbType.VarChar, 50)
                pId_Mat.Value = Id_Mat
                MyCommand.Parameters.Add(pId_Mat)

                Dim pLoai As SqlParameter = New SqlParameter("@Loai", SqlDbType.Char, 10)
                pLoai.Value = Loai
                MyCommand.Parameters.Add(pLoai)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Value = Ngay_He_Thong
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Value = Gio_He_Thong
                MyCommand.Parameters.Add(pGio_He_Thong)


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

#Region "Ds_Mat_Chuyen_Thu_Tui_So_Cap_Nhat_Them"
        Public Function Ds_Mat_Chuyen_Thu_Tui_So_Cap_Nhat_Them(ByVal Id_Mat As String, ByVal Loai As String, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Ds_Mat_Chuyen_Thu_Tui_So_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDs_Mat_Chuyen_Thu_Tui_So_Chi_Tiet As New Ds_Mat_Chuyen_Thu_Tui_So_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Mat As SqlParameter = New SqlParameter("@Id_Mat", SqlDbType.VarChar, 50)
                pId_Mat.Value = Id_Mat
                MyCommand.Parameters.Add(pId_Mat)

                Dim pLoai As SqlParameter = New SqlParameter("@Loai", SqlDbType.Char, 10)
                pLoai.Value = Loai
                MyCommand.Parameters.Add(pLoai)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Value = Ngay_He_Thong
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Value = Gio_He_Thong
                MyCommand.Parameters.Add(pGio_He_Thong)


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


#Region "Ds_Mat_Chuyen_Thu_Tui_So_Danh_Sach"

        Public Function Ds_Mat_Chuyen_Thu_Tui_So_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Id_Mat
            ' Loai
            ' Ngay_He_Thong
            ' Gio_He_Thong


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Ds_Mat_Chuyen_Thu_Tui_So_Danh_Sach"
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

#Region "Ds_Mat_Chuyen_Thu_Tui_So_Lay"
        Public Function Ds_Mat_Chuyen_Thu_Tui_So_Lay(ByVal Id_Mat As String) As Ds_Mat_Chuyen_Thu_Tui_So_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Ds_Mat_Chuyen_Thu_Tui_So_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDs_Mat_Chuyen_Thu_Tui_So_Chi_Tiet As New Ds_Mat_Chuyen_Thu_Tui_So_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Mat As SqlParameter = New SqlParameter("@Id_Mat", SqlDbType.VarChar, 50)
                pId_Mat.Value = Id_Mat
                MyCommand.Parameters.Add(pId_Mat)

                Dim pLoai As SqlParameter = New SqlParameter("@Loai", SqlDbType.Char, 10)
                pLoai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pLoai)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_He_Thong)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myDs_Mat_Chuyen_Thu_Tui_So_Chi_Tiet.Id_Mat = Id_Mat
                myDs_Mat_Chuyen_Thu_Tui_So_Chi_Tiet.Loai = pLoai.Value
                myDs_Mat_Chuyen_Thu_Tui_So_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myDs_Mat_Chuyen_Thu_Tui_So_Chi_Tiet.Gio_He_Thong = pGio_He_Thong.Value

                Return myDs_Mat_Chuyen_Thu_Tui_So_Chi_Tiet
                'Return myDs_Mat_Chuyen_Thu_Tui_So_Chi_Tiet

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

#Region "Ds_Mat_Chuyen_Thu_Tui_So_Them"
        Public Function Ds_Mat_Chuyen_Thu_Tui_So_Them(ByVal Id_Mat As String, ByVal Loai As String, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Ds_Mat_Chuyen_Thu_Tui_So_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDs_Mat_Chuyen_Thu_Tui_So_Chi_Tiet As New Ds_Mat_Chuyen_Thu_Tui_So_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Mat As SqlParameter = New SqlParameter("@Id_Mat", SqlDbType.VarChar, 50)
                pId_Mat.Value = Id_Mat
                MyCommand.Parameters.Add(pId_Mat)

                Dim pLoai As SqlParameter = New SqlParameter("@Loai", SqlDbType.Char, 10)
                pLoai.Value = Loai
                MyCommand.Parameters.Add(pLoai)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Value = Ngay_He_Thong
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Value = Gio_He_Thong
                MyCommand.Parameters.Add(pGio_He_Thong)


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

#Region "Ds_Mat_Chuyen_Thu_Tui_So_Xoa"
        Public Function Ds_Mat_Chuyen_Thu_Tui_So_Xoa(ByVal Id_Mat As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Ds_Mat_Chuyen_Thu_Tui_So_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDs_Mat_Chuyen_Thu_Tui_So_Chi_Tiet As New Ds_Mat_Chuyen_Thu_Tui_So_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Mat As SqlParameter = New SqlParameter("@Id_Mat", SqlDbType.VarChar, 50)
                pId_Mat.Value = Id_Mat
                MyCommand.Parameters.Add(pId_Mat)


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


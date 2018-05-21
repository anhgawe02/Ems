
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "E2_Den_Ma_Vach_Tui_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop E2_Den_Ma_Vach_Tui_Chi_Tiet
    'Tuong ung voi moi truong trong bang E2_Den_Ma_Vach_Tui trong co so du lieu
    '***********************************************************
    Public Class E2_Den_Ma_Vach_Tui_Chi_Tiet
        Public Id_E2 As String
        Public Ma_Vach_Tui As String
        Public Ngay_He_Thong As Integer
        Public Gio_He_Thong As Integer
    End Class
#End Region

#Region "E2_Den_Ma_Vach_Tui"
    Public Class E2_Den_Ma_Vach_Tui
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "E2_Den_Ma_Vach_Tui_Cap_Nhat_Them"
        Public Function E2_Den_Ma_Vach_Tui_Cap_Nhat_Them(ByVal Id_E2 As String, ByVal Ma_Vach_Tui As String, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E2_Den_Ma_Vach_Tui_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myE2_Den_Ma_Vach_Tui_Chi_Tiet As New E2_Den_Ma_Vach_Tui_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                MyCommand.Parameters.Add(pId_E2)

                Dim pMa_Vach_Tui As SqlParameter = New SqlParameter("@Ma_Vach_Tui", SqlDbType.VarChar, 30)
                pMa_Vach_Tui.Value = Ma_Vach_Tui
                MyCommand.Parameters.Add(pMa_Vach_Tui)

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


#Region "E2_Den_Ma_Vach_Tui_Danh_Sach"

        Public Function E2_Den_Ma_Vach_Tui_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Id_E2
            ' Ma_Vach_Tui
            ' Ngay_He_Thong
            ' Gio_He_Thong


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E2_Den_Ma_Vach_Tui_Danh_Sach"
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

#Region "E2_Den_Ma_Vach_Tui_Lay"
        Public Function E2_Den_Ma_Vach_Tui_Lay(ByVal Id_E2 As String) As E2_Den_Ma_Vach_Tui_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E2_Den_Ma_Vach_Tui_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myE2_Den_Ma_Vach_Tui_Chi_Tiet As New E2_Den_Ma_Vach_Tui_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                MyCommand.Parameters.Add(pId_E2)

                Dim pMa_Vach_Tui As SqlParameter = New SqlParameter("@Ma_Vach_Tui", SqlDbType.VarChar, 30)
                pMa_Vach_Tui.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Vach_Tui)

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
                myE2_Den_Ma_Vach_Tui_Chi_Tiet.Id_E2 = Id_E2
                myE2_Den_Ma_Vach_Tui_Chi_Tiet.Ma_Vach_Tui = pMa_Vach_Tui.Value
                myE2_Den_Ma_Vach_Tui_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myE2_Den_Ma_Vach_Tui_Chi_Tiet.Gio_He_Thong = pGio_He_Thong.Value

                Return myE2_Den_Ma_Vach_Tui_Chi_Tiet
                'Return myE2_Den_Ma_Vach_Tui_Chi_Tiet

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

#Region "E2_Den_Ma_Vach_Tui_Xoa"
        Public Function E2_Den_Ma_Vach_Tui_Xoa(ByVal Id_E2 As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E2_Den_Ma_Vach_Tui_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myE2_Den_Ma_Vach_Tui_Chi_Tiet As New E2_Den_Ma_Vach_Tui_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                MyCommand.Parameters.Add(pId_E2)


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


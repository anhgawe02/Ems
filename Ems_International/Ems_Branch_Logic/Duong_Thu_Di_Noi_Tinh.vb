Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Math
Namespace EMS
#Region "Duong_Thu_Di_Noi_Tinh_Chi_Tiet"
    Public Class Duong_Thu_Di_Noi_Tinh_Chi_Tiet
        '*******************************************************
        ' Mỗi thuộc tính của lớp Duong_Thu_Di_Noi_Tinh_Chi_Tiet
        ' tương ứng với mộ trường của bảng Duong_Thu_Di_Noi_Tinh trong cơ sở dữ liệu SQL
        '
        '*******************************************************
        Public Id_Duong_Thu As String
        Public Ten_Duong_Thu As String
        Public Ma_Bc_Khai_Thac As Decimal
        Public Ma_Bc As Decimal
        Public Ma_Tinh As Decimal
        Public Phan_Loai_Duong_Thu As Decimal
    End Class
#End Region

#Region "Duong_Thu_Di_Noi_Tinh"
    Public Class Duong_Thu_Di_Noi_Tinh
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "Duong_Thu_Di_Noi_Tinh_Cap_Nhat"
        Public Function Duong_Thu_Di_Noi_Tinh_Cap_Nhat(ByVal id_Duong_Thu As String, ByVal ten_Duong_Thu As String, ByVal ma_Bc_Khai_Thac As Integer, ByVal ma_Bc As Integer, ByVal ma_Tinh As Integer, ByVal phan_Loai_Duong_Thu As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Duong_Thu_Di_Noi_Tinh_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_Duong_Thu))
                MyCommand.Parameters.Add(New SqlParameter("@Ten_Duong_Thu", SqlDbType.VarChar, 50, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, ten_Duong_Thu))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Bc_Khai_Thac))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Bc))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Tinh", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Tinh))
                MyCommand.Parameters.Add(New SqlParameter("@Phan_Loai_Duong_Thu", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, phan_Loai_Duong_Thu))

                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                Return numRows
                'return the number of rows affected
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

#Region "Duong_Thu_Di_Noi_Tinh_Cap_Nhat_Them"
        Public Function Duong_Thu_Di_Noi_Tinh_Cap_Nhat_Them(ByVal id_Duong_Thu As String, ByVal ten_Duong_Thu As String, ByVal ma_Bc_Khai_Thac As Integer, ByVal ma_Bc As Integer, ByVal ma_Tinh As Integer, ByVal phan_Loai_Duong_Thu As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Duong_Thu_Di_Noi_Tinh_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_Duong_Thu))
                MyCommand.Parameters.Add(New SqlParameter("@Ten_Duong_Thu", SqlDbType.VarChar, 50, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, ten_Duong_Thu))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Bc_Khai_Thac))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Bc))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Tinh", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Tinh))
                MyCommand.Parameters.Add(New SqlParameter("@Phan_Loai_Duong_Thu", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, phan_Loai_Duong_Thu))

                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                Return numRows
                'return the number of rows affected
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

#Region "Duong_Thu_Di_Noi_Tinh_Danh_Sach"

        Public Function Duong_Thu_Di_Noi_Tinh_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Id_Duong_Thu
            ' Ten_Duong_Thu
            ' Ma_Bc_Khai_Thac
            ' Ma_Bc
            ' Ma_Tinh
            ' Phan_Loai_Duong_Thu


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Duong_Thu_Di_Noi_Tinh_Danh_Sach"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
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

#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Duong_Thu_Di_Noi_Tinh
        ' Input: Id_Duong_Thu
        ' Output: Duong_Thu_Di_Chi_Tiet
        Public Function Lay(ByVal Id_Duong_Thu As String) As Duong_Thu_Di_Noi_Tinh_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Duong_Thu_Di_Noi_Tinh_Lay_Chi_Tiet", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pTen_Duong_Thu As SqlParameter = New SqlParameter("@Ten_Duong_Thu", SqlDbType.NVarChar, 150)
                pTen_Duong_Thu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTen_Duong_Thu)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 4)
                pMa_Bc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 4)
                pMa_Tinh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Tinh)

                Dim pPhan_Loai_Duong_Thu As SqlParameter = New SqlParameter("@Phan_Loai_Duong_Thu", SqlDbType.Int, 4)
                pPhan_Loai_Duong_Thu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pPhan_Loai_Duong_Thu)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myDuong_Thu_Di_Noi_Tinh_Chi_Tiet As New Duong_Thu_Di_Noi_Tinh_Chi_Tiet
                
                With myDuong_Thu_Di_Noi_Tinh_Chi_Tiet
                    .Id_Duong_Thu = Id_Duong_Thu
                    .Ten_Duong_Thu = pTen_Duong_Thu.Value
                    .Ma_Bc_Khai_Thac = pMa_Bc_Khai_Thac.Value
                    .Ma_Bc = pMa_Bc.Value
                    .Ma_Tinh = pMa_Tinh.Value
                    .Phan_Loai_Duong_Thu = pPhan_Loai_Duong_Thu.Value
                End With
                Return myDuong_Thu_Di_Noi_Tinh_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Duong_Thu_Di_Noi_Tinh_Lay"

        Public Function Duong_Thu_Di_Noi_Tinh_Lay(ByVal id_Duong_Thu As String) As DataSet

            ' The procedure returns these columns:
            ' Id_Duong_Thu
            ' Ten_Duong_Thu
            ' Ma_Bc_Khai_Thac
            ' Ma_Bc
            ' Ma_Tinh
            ' Phan_Loai_Duong_Thu


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Duong_Thu_Di_Noi_Tinh_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_Duong_Thu))

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

#Region "Duong_Thu_Di_Noi_Tinh_Lay_Boi_Ma_Bc"

        'Public Function Duong_Thu_Di_Noi_Tinh_Lay_Boi_Ma_Bc(ByVal Ma_Bc As Integer) As Duong_Thu_Di_Noi_Tinh_Chi_Tiet

        '    ' The procedure returns these columns:
        '    ' Id_Duong_Thu
        '    ' Ten_Duong_Thu
        '    ' Ma_Bc_Khai_Thac
        '    ' Ma_Bc
        '    ' Ma_Tinh
        '    ' Phan_Loai_Duong_Thu


        '    Dim MyCommand As SqlCommand = New SqlCommand
        '    MyCommand.CommandText = "Duong_Thu_Di_Noi_Tinh_Lay"
        '    MyCommand.CommandType = CommandType.StoredProcedure
        '    Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
        '    Dim myDuong_Thu_Di_Noi_Tinh_Chi_Tiet As New Duong_Thu_Di_Noi_Tinh_Chi_Tiet


        '    Dim MyConnection As New SqlConnection(ConnectionString)
        '    MyCommand.Connection = MyConnection

        '    Try


        '        'Define the parameters

        '        MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc", SqlDbType.Int, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, Ma_Bc))
        '        'MyCommand.Parameters.Add(New SqlParameter("@Phan_Loai_Duong_Thu", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, phan_Loai_Duong_Thu))

        '        'Fill the dataset using the connection string from the db base class
        '        MyConnection.Open()
        '        'adapter.Fill(MyDataSet)
        '        MyCommand.ExecuteNonQuery()
        '        With myDuong_Thu_Di_Noi_Tinh_Chi_Tiet
        '            .Id_Duong_Thu = pId_Duong_Thu.value

        '        End With
        '        Return myDuong_Thu_Di_Noi_Tinh_Chi_Tiet

        '    Catch ex As Exception
        '        Console.Write(ex.ToString)
        '    Finally
        '        'Close the connection and Dispose.
        '        MyConnection.Close()
        '        MyCommand.Dispose()
        '        adapter.Dispose()
        '    End Try
        'End Function
#End Region

#Region "Duong_Thu_Di_Noi_Tinh_Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac"

        Public Function Duong_Thu_Di_Noi_Tinh_Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac(ByVal Ma_Bc_Khai_Thac As Integer) As DataSet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Duong_Thu_Di_Noi_Tinh_Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim myDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, Ma_Bc_Khai_Thac))

                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                adapter.Fill(myDataSet)
                'MyCommand.ExecuteNonQuery()
                Return myDataSet

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

#Region "Duong_Thu_Di_Noi_Tinh_Them"
        Public Function Duong_Thu_Di_Noi_Tinh_Them(ByVal id_Duong_Thu As String, ByVal ten_Duong_Thu As String, ByVal ma_Bc_Khai_Thac As Integer, ByVal ma_Bc As Integer, ByVal ma_Tinh As Integer, ByVal phan_Loai_Duong_Thu As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Duong_Thu_Di_Noi_Tinh_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_Duong_Thu))
                MyCommand.Parameters.Add(New SqlParameter("@Ten_Duong_Thu", SqlDbType.VarChar, 50, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, ten_Duong_Thu))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Bc_Khai_Thac))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Bc))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Tinh", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Tinh))
                MyCommand.Parameters.Add(New SqlParameter("@Phan_Loai_Duong_Thu", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, phan_Loai_Duong_Thu))

                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                Return numRows
                'return the number of rows affected
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

#Region "Duong_Thu_Di_Noi_Tinh_Xoa"
        Public Function Duong_Thu_Di_Noi_Tinh_Xoa(ByVal id_Duong_Thu As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Duong_Thu_Di_Noi_Tinh_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_Duong_Thu))

                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                Return numRows
                'return the number of rows affected
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

#Region "Duong_Thu_Di_Noi_Tinh_Danh_Sach_Lay_Boi_Ma_Tinh"

        Public Function Duong_Thu_Di_Noi_Tinh_Danh_Sach_Lay_Boi_Ma_Tinh(ByVal Ma_Tinh As Integer) As DataSet

            ' The procedure returns these columns:
            ' Id_Duong_Thu
            ' Ten_Duong_Thu
            ' Ma_Bc_Khai_Thac
            ' Ma_Bc
            ' Ma_Tinh
            ' Phan_Loai_Duong_Thu


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Duong_Thu_Di_Noi_Tinh_Danh_Sach_Lay_Boi_Ma_Tinh"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try

                'Define the parameters
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Tinh", SqlDbType.Int, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, Ma_Tinh))

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

#Region "Duong_Thu_Di_Noi_Tinh_Danh_Sach_Lay_Boi_Ma_Tinh_Phan_Loai_Duong_Thu"

        Public Function Duong_Thu_Di_Noi_Tinh_Danh_Sach_Lay_Boi_Ma_Tinh_Phan_Loai_Duong_Thu(ByVal Ma_Tinh As Integer, ByVal Phan_Loai_Duong_Thu As Integer) As DataSet

            ' The procedure returns these columns:
            ' Id_Duong_Thu
            ' Ten_Duong_Thu
            ' Ma_Bc_Khai_Thac
            ' Ma_Bc
            ' Ma_Tinh
            ' Phan_Loai_Duong_Thu


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Duong_Thu_Di_Noi_Tinh_Danh_Sach_Lay_Boi_Ma_Tinh_Phan_Loai_Duong_Thu"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try

                'Define the parameters
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Tinh", SqlDbType.Int, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, Ma_Tinh))
                MyCommand.Parameters.Add(New SqlParameter("@Phan_Loai_Duong_Thu", SqlDbType.Int, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, Phan_Loai_Duong_Thu))

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

#Region "Duong_Thu_Di_Noi_Tinh_Danh_Sach_Lay_Boi_Ma_Tinh_Noi_Ngoai_Thanh"

        Public Function Duong_Thu_Di_Noi_Tinh_Danh_Sach_Lay_Boi_Ma_Tinh_Noi_Ngoai_Thanh(ByVal Ma_Tinh As Integer) As DataSet

            ' The procedure returns these columns:
            ' Id_Duong_Thu
            ' Ten_Duong_Thu
            ' Ma_Bc_Khai_Thac
            ' Ma_Bc
            ' Ma_Tinh
            ' Phan_Loai_Duong_Thu


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Duong_Thu_Di_Noi_Tinh_Danh_Sach_Lay_Boi_Ma_Tinh_Noi_Ngoai_Thanh"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try

                'Define the parameters
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Tinh", SqlDbType.Int, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, Ma_Tinh))

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
    End Class
#End Region
End Namespace



Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "Danh_Muc_Huong_Den_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop Danh_Muc_Huong_Den_Chi_Tiet
    'Tuong ung voi moi truong trong bang Danh_Muc_Huong_Den trong co so du lieu
    '***********************************************************
    Public Class Danh_Muc_Huong_Den_Chi_Tiet
        Public ID_Huong_Chuyen As String
        Public ID_Duong_Thu As String
        Public Phan_Loai As Integer
        Public Ma_Nuoc As String
        Public Ma_Tinh As Integer
        Public Dung_Huong As Boolean
        Public Ghi_Chu As String
    End Class
#End Region

#Region "Danh_Muc_Huong_Den"
    Public Class Danh_Muc_Huong_Den
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "Danh_Muc_Huong_Den_Cap_Nhat"
        Public Function Danh_Muc_Huong_Den_Cap_Nhat(ByVal ID_Huong_Chuyen As String, ByVal ID_Duong_Thu As String, ByVal Phan_Loai As Integer, ByVal Ma_Nuoc As String, ByVal Ma_Tinh As Integer, ByVal Dung_Huong As Boolean, ByVal Ghi_Chu As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Huong_Den_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDanh_Muc_Huong_Den_Chi_Tiet As New Danh_Muc_Huong_Den_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pID_Huong_Chuyen As SqlParameter = New SqlParameter("@ID_Huong_Chuyen", SqlDbType.VarChar, 25)
                pID_Huong_Chuyen.Value = ID_Huong_Chuyen
                MyCommand.Parameters.Add(pID_Huong_Chuyen)

                Dim pID_Duong_Thu As SqlParameter = New SqlParameter("@ID_Duong_Thu", SqlDbType.VarChar, 14)
                pID_Duong_Thu.Value = ID_Duong_Thu
                MyCommand.Parameters.Add(pID_Duong_Thu)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.Int, 0)
                pPhan_Loai.Value = Phan_Loai
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 0)
                pMa_Tinh.Value = Ma_Tinh
                MyCommand.Parameters.Add(pMa_Tinh)

                Dim pDung_Huong As SqlParameter = New SqlParameter("@Dung_Huong", SqlDbType.Bit, 0)
                pDung_Huong.Value = Dung_Huong
                MyCommand.Parameters.Add(pDung_Huong)

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

#Region "Danh_Muc_Huong_Den_Cap_Nhat_Them"
        Public Function Danh_Muc_Huong_Den_Cap_Nhat_Them(ByVal ID_Huong_Chuyen As String, ByVal ID_Duong_Thu As String, ByVal Phan_Loai As Integer, ByVal Ma_Nuoc As String, ByVal Ma_Tinh As Integer, ByVal Dung_Huong As Boolean, ByVal Ghi_Chu As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Huong_Den_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDanh_Muc_Huong_Den_Chi_Tiet As New Danh_Muc_Huong_Den_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pID_Huong_Chuyen As SqlParameter = New SqlParameter("@ID_Huong_Chuyen", SqlDbType.VarChar, 25)
                pID_Huong_Chuyen.Value = ID_Huong_Chuyen
                MyCommand.Parameters.Add(pID_Huong_Chuyen)

                Dim pID_Duong_Thu As SqlParameter = New SqlParameter("@ID_Duong_Thu", SqlDbType.VarChar, 14)
                pID_Duong_Thu.Value = ID_Duong_Thu
                MyCommand.Parameters.Add(pID_Duong_Thu)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.Int, 0)
                pPhan_Loai.Value = Phan_Loai
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 0)
                pMa_Tinh.Value = Ma_Tinh
                MyCommand.Parameters.Add(pMa_Tinh)

                Dim pDung_Huong As SqlParameter = New SqlParameter("@Dung_Huong", SqlDbType.Bit, 0)
                pDung_Huong.Value = Dung_Huong
                MyCommand.Parameters.Add(pDung_Huong)

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

#Region "Danh_Muc_Huong_Den_Danh_Sach"

        Public Function Danh_Muc_Huong_Den_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' ID_Huong_Chuyen
            ' ID_Duong_Thu
            ' Phan_Loai
            ' Ma_Nuoc
            ' Ma_Tinh
            ' Dung_Huong
            ' Ghi_Chu


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Huong_Den_Danh_Sach"
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

        ''' Danh sach huong den lay boi Id duong thu
        Public Function Danh_Muc_Huong_Den_Danh_Sach_Lay_Boi_ID_Duong_Thu(ByVal Id_Duong_Thu As String) As DataSet

            ' The procedure returns these columns:
            ' ID_Huong_Chuyen
            ' ID_Duong_Thu
            ' Phan_Loai
            ' Ma_Nuoc
            ' Ma_Tinh
            ' Dung_Huong
            ' Ghi_Chu


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Huong_Den_Danh_Sach_Lay_Boi_Id_Duong_Thu"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters
                Dim pID_Duong_Thu As SqlParameter = New SqlParameter("@ID_Duong_Thu", SqlDbType.VarChar, 14)
                pID_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pID_Duong_Thu)


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

        ''' Danh sach huong den lay boi Id duong thu
        Public Function Danh_Muc_Huong_Den_Danh_Sach_Ma_Tinh_Lay_Boi_ID_Duong_Thu(ByVal Id_Duong_Thu As String) As DataSet

            ' The procedure returns these columns:
            ' ID_Huong_Chuyen
            ' ID_Duong_Thu
            ' Phan_Loai
            ' Ma_Nuoc
            ' Ma_Tinh
            ' Dung_Huong
            ' Ghi_Chu


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Huong_Den_Danh_Sach_Ma_Tinh_Lay_Boi_ID_Duong_Thu"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters
                Dim pID_Duong_Thu As SqlParameter = New SqlParameter("@ID_Duong_Thu", SqlDbType.VarChar, 14)
                pID_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pID_Duong_Thu)


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

        ''' Danh sach huong den lay boi Id duong thu
        Public Function Danh_Muc_Huong_Den_Danh_Sach_Ma_Nuoc_Lay_Boi_ID_Duong_Thu(ByVal Id_Duong_Thu As String) As DataSet

            ' The procedure returns these columns:
            ' ID_Huong_Chuyen
            ' ID_Duong_Thu
            ' Phan_Loai
            ' Ma_Nuoc
            ' Ma_Tinh
            ' Dung_Huong
            ' Ghi_Chu


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Huong_Den_Danh_Sach_Ma_Nuoc_Lay_Boi_ID_Duong_Thu"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters
                Dim pID_Duong_Thu As SqlParameter = New SqlParameter("@ID_Duong_Thu", SqlDbType.VarChar, 14)
                pID_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pID_Duong_Thu)


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

#Region "Danh_Muc_Huong_Den_Lay"
        Public Function Danh_Muc_Huong_Den_Lay(ByVal ID_Huong_Chuyen As String) As Danh_Muc_Huong_Den_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Huong_Den_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDanh_Muc_Huong_Den_Chi_Tiet As New Danh_Muc_Huong_Den_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pID_Huong_Chuyen As SqlParameter = New SqlParameter("@ID_Huong_Chuyen", SqlDbType.VarChar, 25)
                pID_Huong_Chuyen.Value = ID_Huong_Chuyen
                MyCommand.Parameters.Add(pID_Huong_Chuyen)

                Dim pID_Duong_Thu As SqlParameter = New SqlParameter("@ID_Duong_Thu", SqlDbType.VarChar, 14)
                pID_Duong_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pID_Duong_Thu)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.Int, 0)
                pPhan_Loai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 0)
                pMa_Tinh.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Tinh)

                Dim pDung_Huong As SqlParameter = New SqlParameter("@Dung_Huong", SqlDbType.Bit, 0)
                pDung_Huong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDung_Huong)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
                pGhi_Chu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGhi_Chu)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myDanh_Muc_Huong_Den_Chi_Tiet.ID_Huong_Chuyen = pID_Huong_Chuyen.Value
                myDanh_Muc_Huong_Den_Chi_Tiet.ID_Duong_Thu = pID_Duong_Thu.Value
                myDanh_Muc_Huong_Den_Chi_Tiet.Phan_Loai = pPhan_Loai.Value
                myDanh_Muc_Huong_Den_Chi_Tiet.Ma_Nuoc = pMa_Nuoc.Value
                myDanh_Muc_Huong_Den_Chi_Tiet.Ma_Tinh = pMa_Tinh.Value
                myDanh_Muc_Huong_Den_Chi_Tiet.Dung_Huong = pDung_Huong.Value
                myDanh_Muc_Huong_Den_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value
                myDanh_Muc_Huong_Den_Chi_Tiet.ID_Duong_Thu = pID_Duong_Thu.Value
                myDanh_Muc_Huong_Den_Chi_Tiet.Phan_Loai = pPhan_Loai.Value
                myDanh_Muc_Huong_Den_Chi_Tiet.Ma_Nuoc = pMa_Nuoc.Value
                myDanh_Muc_Huong_Den_Chi_Tiet.Ma_Tinh = pMa_Tinh.Value
                myDanh_Muc_Huong_Den_Chi_Tiet.Dung_Huong = pDung_Huong.Value
                myDanh_Muc_Huong_Den_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value

                Return myDanh_Muc_Huong_Den_Chi_Tiet
                'Return myDanh_Muc_Huong_Den_Chi_Tiet

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

#Region "Danh_Muc_Huong_Den_Them"
        Public Function Danh_Muc_Huong_Den_Them(ByVal ID_Huong_Chuyen As String, ByVal ID_Duong_Thu As String, ByVal Phan_Loai As Integer, ByVal Ma_Nuoc As String, ByVal Ma_Tinh As Integer, ByVal Dung_Huong As Boolean, ByVal Ghi_Chu As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Huong_Den_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDanh_Muc_Huong_Den_Chi_Tiet As New Danh_Muc_Huong_Den_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pID_Huong_Chuyen As SqlParameter = New SqlParameter("@ID_Huong_Chuyen", SqlDbType.VarChar, 25)
                pID_Huong_Chuyen.Value = ID_Huong_Chuyen
                MyCommand.Parameters.Add(pID_Huong_Chuyen)

                Dim pID_Duong_Thu As SqlParameter = New SqlParameter("@ID_Duong_Thu", SqlDbType.VarChar, 14)
                pID_Duong_Thu.Value = ID_Duong_Thu
                MyCommand.Parameters.Add(pID_Duong_Thu)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.Int, 0)
                pPhan_Loai.Value = Phan_Loai
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 0)
                pMa_Tinh.Value = Ma_Tinh
                MyCommand.Parameters.Add(pMa_Tinh)

                Dim pDung_Huong As SqlParameter = New SqlParameter("@Dung_Huong", SqlDbType.Bit, 0)
                pDung_Huong.Value = Dung_Huong
                MyCommand.Parameters.Add(pDung_Huong)

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

#Region "Danh_Muc_Huong_Den_Xoa"
        Public Function Danh_Muc_Huong_Den_Xoa(ByVal ID_Huong_Chuyen As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Huong_Den_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDanh_Muc_Huong_Den_Chi_Tiet As New Danh_Muc_Huong_Den_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pID_Huong_Chuyen As SqlParameter = New SqlParameter("@ID_Huong_Chuyen", SqlDbType.VarChar, 25)
                pID_Huong_Chuyen.Value = ID_Huong_Chuyen
                MyCommand.Parameters.Add(pID_Huong_Chuyen)


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

        ''' Xoa danh muc huong den theo Id_Duong_Thu
        Public Function Danh_Muc_Huong_Den_Xoa_Boi_Id_Duong_Thu(ByVal Id_Duong_Thu As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Huong_Den_Xoa_Boi_Id_Duong_Thu"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDanh_Muc_Huong_Den_Chi_Tiet As New Danh_Muc_Huong_Den_Chi_Tiet

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


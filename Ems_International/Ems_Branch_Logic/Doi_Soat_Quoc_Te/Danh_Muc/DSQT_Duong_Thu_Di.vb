
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "DSQT_Duong_Thu_Di_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop DSQT_Duong_Thu_Di_Chi_Tiet
    'Tuong ung voi moi truong trong bang DSQT_Duong_Thu_Di trong co so du lieu
    '***********************************************************
    Public Class DSQT_Duong_Thu_Di_Chi_Tiet
        Public Id_Duong_Thu As String
        Public Ma_Bc_Khai_Thac As Integer
        Public Ma_Bc As Integer
        Public Ten_Duong_Thu As String
        Public Ma_Nuoc As String
        Public Ma_Vung As String
        Public IMPC As String
        Public Phan_Loai As Integer
        Public Id_Duong_Bay As String
        Public Ghi_Chu As String
    End Class
#End Region

#Region "DSQT_Duong_Thu_Di"
    Public Class DSQT_Duong_Thu_Di
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "DSQT_Duong_Thu_Di_Cap_Nhat"
        Public Function DSQT_Duong_Thu_Di_Cap_Nhat(ByVal Id_Duong_Thu As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Bc As Integer, ByVal Ten_Duong_Thu As String, ByVal Ma_Nuoc As String, ByVal Ma_Vung As String, ByVal IMPC As String, ByVal Phan_Loai As Integer, ByVal Id_Duong_Bay As String, ByVal Ghi_Chu As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Duong_Thu_Di_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Duong_Thu_Di_Chi_Tiet As New DSQT_Duong_Thu_Di_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 0)
                pMa_Bc.Value = Ma_Bc
                MyCommand.Parameters.Add(pMa_Bc)

                Dim pTen_Duong_Thu As SqlParameter = New SqlParameter("@Ten_Duong_Thu", SqlDbType.NVarChar, 100)
                pTen_Duong_Thu.Value = Ten_Duong_Thu
                MyCommand.Parameters.Add(pTen_Duong_Thu)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pMa_Vung As SqlParameter = New SqlParameter("@Ma_Vung", SqlDbType.VarChar, 3)
                pMa_Vung.Value = Ma_Vung
                MyCommand.Parameters.Add(pMa_Vung)

                Dim pIMPC As SqlParameter = New SqlParameter("@IMPC", SqlDbType.VarChar, 6)
                pIMPC.Value = IMPC
                MyCommand.Parameters.Add(pIMPC)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.Int, 0)
                pPhan_Loai.Value = Phan_Loai
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pId_Duong_Bay As SqlParameter = New SqlParameter("@Id_Duong_Bay", SqlDbType.VarChar, 50)
                pId_Duong_Bay.Value = Id_Duong_Bay
                MyCommand.Parameters.Add(pId_Duong_Bay)

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

#Region "DSQT_Duong_Thu_Di_Cap_Nhat_Them"
        Public Function DSQT_Duong_Thu_Di_Cap_Nhat_Them(ByVal Id_Duong_Thu As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Bc As Integer, ByVal Ten_Duong_Thu As String, ByVal Ma_Nuoc As String, ByVal Ma_Vung As String, ByVal IMPC As String, ByVal Phan_Loai As Integer, ByVal Id_Duong_Bay As String, ByVal Ghi_Chu As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Duong_Thu_Di_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Duong_Thu_Di_Chi_Tiet As New DSQT_Duong_Thu_Di_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 0)
                pMa_Bc.Value = Ma_Bc
                MyCommand.Parameters.Add(pMa_Bc)

                Dim pTen_Duong_Thu As SqlParameter = New SqlParameter("@Ten_Duong_Thu", SqlDbType.NVarChar, 100)
                pTen_Duong_Thu.Value = Ten_Duong_Thu
                MyCommand.Parameters.Add(pTen_Duong_Thu)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pMa_Vung As SqlParameter = New SqlParameter("@Ma_Vung", SqlDbType.VarChar, 3)
                pMa_Vung.Value = Ma_Vung
                MyCommand.Parameters.Add(pMa_Vung)

                Dim pIMPC As SqlParameter = New SqlParameter("@IMPC", SqlDbType.VarChar, 6)
                pIMPC.Value = IMPC
                MyCommand.Parameters.Add(pIMPC)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.Int, 0)
                pPhan_Loai.Value = Phan_Loai
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pId_Duong_Bay As SqlParameter = New SqlParameter("@Id_Duong_Bay", SqlDbType.VarChar, 50)
                pId_Duong_Bay.Value = Id_Duong_Bay
                MyCommand.Parameters.Add(pId_Duong_Bay)

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


#Region "DSQT_Duong_Thu_Di_Danh_Sach"

        Public Function DSQT_Duong_Thu_Di_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Id_Duong_Thu
            ' Ma_Bc_Khai_Thac
            ' Ma_Bc
            ' Ten_Duong_Thu
            ' Ma_Nuoc
            ' Ma_Vung
            ' IMPC
            ' Phan_Loai
            ' Id_Duong_Bay
            ' Ghi_Chu


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Duong_Thu_Di_Danh_Sach"
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


#Region "DSQT_Duong_Thu_Di_Danh_Sach_Quoc_Te_Di"

        Public Function DSQT_Duong_Thu_Di_Danh_Sach_Quoc_Te_Di() As DataSet

            ' The procedure returns these columns:
            ' Id_Duong_Thu
            ' Ma_Bc_Khai_Thac
            ' Ma_Bc
            ' Ten_Duong_Thu
            ' Ma_Nuoc
            ' Ma_Vung
            ' IMPC
            ' Phan_Loai
            ' Id_Duong_Bay
            ' Ghi_Chu


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Duong_Thu_Di_Danh_Sach_Quoc_Te_Di"
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


#Region "DSQT_Duong_Thu_Di_Danh_Sach_Theo_Ma_Nuoc"

        Public Function DSQT_Duong_Thu_Di_Danh_Sach_Theo_Ma_Nuoc(ByVal Ma_Nuoc As String) As DataSet

            ' The procedure returns these columns:
            ' Id_Duong_Thu
            ' Ma_Bc_Khai_Thac
            ' Ma_Bc
            ' Ten_Duong_Thu
            ' Ma_Nuoc
            ' Ma_Vung
            ' IMPC
            ' Phan_Loai
            ' Id_Duong_Bay
            ' Ghi_Chu


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Duong_Thu_Di_Danh_Sach_Theo_Ma_Nuoc"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                MyCommand.Parameters.Add(pMa_Nuoc)


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

#Region "DSQT_Duong_Thu_Di_Lay"
        Public Function DSQT_Duong_Thu_Di_Lay(ByVal Id_Duong_Thu As String) As DSQT_Duong_Thu_Di_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Duong_Thu_Di_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Duong_Thu_Di_Chi_Tiet As New DSQT_Duong_Thu_Di_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 0)
                pMa_Bc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc)

                Dim pTen_Duong_Thu As SqlParameter = New SqlParameter("@Ten_Duong_Thu", SqlDbType.NVarChar, 100)
                pTen_Duong_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTen_Duong_Thu)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pMa_Vung As SqlParameter = New SqlParameter("@Ma_Vung", SqlDbType.VarChar, 3)
                pMa_Vung.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Vung)

                Dim pIMPC As SqlParameter = New SqlParameter("@IMPC", SqlDbType.VarChar, 6)
                pIMPC.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pIMPC)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.Int, 0)
                pPhan_Loai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pId_Duong_Bay As SqlParameter = New SqlParameter("@Id_Duong_Bay", SqlDbType.VarChar, 50)
                pId_Duong_Bay.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Duong_Bay)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
                pGhi_Chu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGhi_Chu)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myDSQT_Duong_Thu_Di_Chi_Tiet.Id_Duong_Thu = Id_Duong_Thu
                myDSQT_Duong_Thu_Di_Chi_Tiet.Ma_Bc_Khai_Thac = pMa_Bc_Khai_Thac.Value
                myDSQT_Duong_Thu_Di_Chi_Tiet.Ma_Bc = pMa_Bc.Value
                myDSQT_Duong_Thu_Di_Chi_Tiet.Ten_Duong_Thu = pTen_Duong_Thu.Value
                myDSQT_Duong_Thu_Di_Chi_Tiet.Ma_Nuoc = pMa_Nuoc.Value
                myDSQT_Duong_Thu_Di_Chi_Tiet.Ma_Vung = pMa_Vung.Value
                myDSQT_Duong_Thu_Di_Chi_Tiet.IMPC = pIMPC.Value
                myDSQT_Duong_Thu_Di_Chi_Tiet.Phan_Loai = pPhan_Loai.Value
                myDSQT_Duong_Thu_Di_Chi_Tiet.Id_Duong_Bay = pId_Duong_Bay.Value
                myDSQT_Duong_Thu_Di_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value

                Return myDSQT_Duong_Thu_Di_Chi_Tiet
                'Return myDSQT_Duong_Thu_Di_Chi_Tiet

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

#Region "DSQT_Duong_Thu_Di_Them"
        Public Function DSQT_Duong_Thu_Di_Them(ByVal Id_Duong_Thu As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Bc As Integer, ByVal Ten_Duong_Thu As String, ByVal Ma_Nuoc As String, ByVal Ma_Vung As String, ByVal IMPC As String, ByVal Phan_Loai As Integer, ByVal Id_Duong_Bay As String, ByVal Ghi_Chu As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Duong_Thu_Di_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Duong_Thu_Di_Chi_Tiet As New DSQT_Duong_Thu_Di_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 0)
                pMa_Bc.Value = Ma_Bc
                MyCommand.Parameters.Add(pMa_Bc)

                Dim pTen_Duong_Thu As SqlParameter = New SqlParameter("@Ten_Duong_Thu", SqlDbType.NVarChar, 100)
                pTen_Duong_Thu.Value = Ten_Duong_Thu
                MyCommand.Parameters.Add(pTen_Duong_Thu)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pMa_Vung As SqlParameter = New SqlParameter("@Ma_Vung", SqlDbType.VarChar, 3)
                pMa_Vung.Value = Ma_Vung
                MyCommand.Parameters.Add(pMa_Vung)

                Dim pIMPC As SqlParameter = New SqlParameter("@IMPC", SqlDbType.VarChar, 6)
                pIMPC.Value = IMPC
                MyCommand.Parameters.Add(pIMPC)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.Int, 0)
                pPhan_Loai.Value = Phan_Loai
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pId_Duong_Bay As SqlParameter = New SqlParameter("@Id_Duong_Bay", SqlDbType.VarChar, 50)
                pId_Duong_Bay.Value = Id_Duong_Bay
                MyCommand.Parameters.Add(pId_Duong_Bay)

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

#Region "DSQT_Duong_Thu_Di_Xoa"
        Public Function DSQT_Duong_Thu_Di_Xoa(ByVal Id_Duong_Thu As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Duong_Thu_Di_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Duong_Thu_Di_Chi_Tiet As New DSQT_Duong_Thu_Di_Chi_Tiet

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


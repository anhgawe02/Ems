
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "DSQT_Cuoc_Phat_QT_Di_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop DSQT_Cuoc_Phat_QT_Di_Chi_Tiet
    'Tuong ung voi moi truong trong bang DSQT_Cuoc_Phat_QT_Di trong co so du lieu
    '***********************************************************
    Public Class DSQT_Cuoc_Phat_QT_Di_Chi_Tiet
        Public Id_Cuoc As String
        Public Ma_Nuoc As String
        Public Cuoc_BP_D As Double
        Public Cuoc_BP_M As Double
        Public Khoi_Luong As Integer
        Public Cuoc As Double
        Public Cuoc_VCMBND As Double
        Public Id_Dot As String
        Public Ma_Tien_Te As String
        Public Ma_Tien_Te_VCMBND As String
    End Class
#End Region

#Region "DSQT_Cuoc_Phat_QT_Di"
    Public Class DSQT_Cuoc_Phat_QT_Di
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "DSQT_Cuoc_Phat_QT_Di_Cap_Nhat"
        Public Function DSQT_Cuoc_Phat_QT_Di_Cap_Nhat(ByVal Id_Cuoc As String, ByVal Ma_Nuoc As String, ByVal Cuoc_BP_D As Double, ByVal Cuoc_BP_M As Double, ByVal Khoi_Luong As Integer, ByVal Cuoc As Double, ByVal Cuoc_VCMBND As Double, ByVal Id_Dot As String, ByVal Ma_Tien_Te As String, ByVal Ma_Tien_Te_VCMBND As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Cuoc_Phat_QT_Di_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Cuoc_Phat_QT_Di_Chi_Tiet As New DSQT_Cuoc_Phat_QT_Di_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Cuoc As SqlParameter = New SqlParameter("@Id_Cuoc", SqlDbType.VarChar, 52)
                pId_Cuoc.Value = Id_Cuoc
                MyCommand.Parameters.Add(pId_Cuoc)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 50)
                pMa_Nuoc.Value = Ma_Nuoc
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pCuoc_BP_D As SqlParameter = New SqlParameter("@Cuoc_BP_D", SqlDbType.Float, 0)
                pCuoc_BP_D.Value = Cuoc_BP_D
                MyCommand.Parameters.Add(pCuoc_BP_D)

                Dim pCuoc_BP_M As SqlParameter = New SqlParameter("@Cuoc_BP_M", SqlDbType.Float, 0)
                pCuoc_BP_M.Value = Cuoc_BP_M
                MyCommand.Parameters.Add(pCuoc_BP_M)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 0)
                pKhoi_Luong.Value = Khoi_Luong
                MyCommand.Parameters.Add(pKhoi_Luong)

                Dim pCuoc As SqlParameter = New SqlParameter("@Cuoc", SqlDbType.Float, 0)
                pCuoc.Value = Cuoc
                MyCommand.Parameters.Add(pCuoc)

                Dim pCuoc_VCMBND As SqlParameter = New SqlParameter("@Cuoc_VCMBND", SqlDbType.Float, 0)
                pCuoc_VCMBND.Value = Cuoc_VCMBND
                MyCommand.Parameters.Add(pCuoc_VCMBND)

                Dim pId_Dot As SqlParameter = New SqlParameter("@Id_Dot", SqlDbType.VarChar, 50)
                pId_Dot.Value = Id_Dot
                MyCommand.Parameters.Add(pId_Dot)

                Dim pMa_Tien_Te As SqlParameter = New SqlParameter("@Ma_Tien_Te", SqlDbType.VarChar, 5)
                pMa_Tien_Te.Value = Ma_Tien_Te
                MyCommand.Parameters.Add(pMa_Tien_Te)

                Dim pMa_Tien_Te_VCMBND As SqlParameter = New SqlParameter("@Ma_Tien_Te_VCMBND", SqlDbType.VarChar, 5)
                pMa_Tien_Te_VCMBND.Value = Ma_Tien_Te_VCMBND
                MyCommand.Parameters.Add(pMa_Tien_Te_VCMBND)


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

#Region "DSQT_Cuoc_Phat_QT_Di_Cap_Nhat_Them"
        Public Function DSQT_Cuoc_Phat_QT_Di_Cap_Nhat_Them(ByVal Id_Cuoc As String, ByVal Ma_Nuoc As String, ByVal Cuoc_BP_D As Double, ByVal Cuoc_BP_M As Double, ByVal Khoi_Luong As Integer, ByVal Cuoc As Double, ByVal Cuoc_VCMBND As Double, ByVal Id_Dot As String, ByVal Ma_Tien_Te As String, ByVal Ma_Tien_Te_VCMBND As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Cuoc_Phat_QT_Di_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Cuoc_Phat_QT_Di_Chi_Tiet As New DSQT_Cuoc_Phat_QT_Di_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Cuoc As SqlParameter = New SqlParameter("@Id_Cuoc", SqlDbType.VarChar, 52)
                pId_Cuoc.Value = Id_Cuoc
                MyCommand.Parameters.Add(pId_Cuoc)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 50)
                pMa_Nuoc.Value = Ma_Nuoc
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pCuoc_BP_D As SqlParameter = New SqlParameter("@Cuoc_BP_D", SqlDbType.Float, 0)
                pCuoc_BP_D.Value = Cuoc_BP_D
                MyCommand.Parameters.Add(pCuoc_BP_D)

                Dim pCuoc_BP_M As SqlParameter = New SqlParameter("@Cuoc_BP_M", SqlDbType.Float, 0)
                pCuoc_BP_M.Value = Cuoc_BP_M
                MyCommand.Parameters.Add(pCuoc_BP_M)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 0)
                pKhoi_Luong.Value = Khoi_Luong
                MyCommand.Parameters.Add(pKhoi_Luong)

                Dim pCuoc As SqlParameter = New SqlParameter("@Cuoc", SqlDbType.Float, 0)
                pCuoc.Value = Cuoc
                MyCommand.Parameters.Add(pCuoc)

                Dim pCuoc_VCMBND As SqlParameter = New SqlParameter("@Cuoc_VCMBND", SqlDbType.Float, 0)
                pCuoc_VCMBND.Value = Cuoc_VCMBND
                MyCommand.Parameters.Add(pCuoc_VCMBND)

                Dim pId_Dot As SqlParameter = New SqlParameter("@Id_Dot", SqlDbType.VarChar, 50)
                pId_Dot.Value = Id_Dot
                MyCommand.Parameters.Add(pId_Dot)

                Dim pMa_Tien_Te As SqlParameter = New SqlParameter("@Ma_Tien_Te", SqlDbType.VarChar, 5)
                pMa_Tien_Te.Value = Ma_Tien_Te
                MyCommand.Parameters.Add(pMa_Tien_Te)

                Dim pMa_Tien_Te_VCMBND As SqlParameter = New SqlParameter("@Ma_Tien_Te_VCMBND", SqlDbType.VarChar, 5)
                pMa_Tien_Te_VCMBND.Value = Ma_Tien_Te_VCMBND
                MyCommand.Parameters.Add(pMa_Tien_Te_VCMBND)


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


#Region "DSQT_Cuoc_Phat_QT_Di_Danh_Sach"

        Public Function DSQT_Cuoc_Phat_QT_Di_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Id_Cuoc
            ' Ma_Nuoc
            ' Cuoc_BP_D
            ' Cuoc_BP_M
            ' Khoi_Luong
            ' Cuoc
            ' Cuoc_VCMBND
            ' Id_Dot
            ' Ma_Tien_Te
            ' Ma_Tien_Te_VCMBND


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Cuoc_Phat_QT_Di_Danh_Sach"
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


#Region "DSQT_Cuoc_Phat_QT_Di_Danh_Sach_Theo_Id_Dot"

        Public Function DSQT_Cuoc_Phat_QT_Di_Danh_Sach_Theo_Id_Dot(ByVal Id_Dot As String) As DataSet

            ' The procedure returns these columns:
            ' Id_Cuoc
            ' Ma_Nuoc
            ' Cuoc_BP_D
            ' Cuoc_BP_M
            ' Khoi_Luong
            ' Cuoc
            ' Cuoc_VCMBND
            ' Id_Dot
            ' Ma_Tien_Te
            ' Ma_Tien_Te_VCMBND


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Cuoc_Phat_QT_Di_Danh_Sach_Theo_Id_Dot"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pId_Dot As SqlParameter = New SqlParameter("@Id_Dot", SqlDbType.VarChar, 50)
                pId_Dot.Value = Id_Dot
                MyCommand.Parameters.Add(pId_Dot)


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

#Region "DSQT_Cuoc_Phat_QT_Di_Lay"
        Public Function DSQT_Cuoc_Phat_QT_Di_Lay(ByVal Id_Cuoc As String) As DSQT_Cuoc_Phat_QT_Di_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Cuoc_Phat_QT_Di_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Cuoc_Phat_QT_Di_Chi_Tiet As New DSQT_Cuoc_Phat_QT_Di_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Cuoc As SqlParameter = New SqlParameter("@Id_Cuoc", SqlDbType.VarChar, 52)
                pId_Cuoc.Value = Id_Cuoc
                MyCommand.Parameters.Add(pId_Cuoc)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 50)
                pMa_Nuoc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pCuoc_BP_D As SqlParameter = New SqlParameter("@Cuoc_BP_D", SqlDbType.Float, 0)
                pCuoc_BP_D.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCuoc_BP_D)

                Dim pCuoc_BP_M As SqlParameter = New SqlParameter("@Cuoc_BP_M", SqlDbType.Float, 0)
                pCuoc_BP_M.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCuoc_BP_M)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 0)
                pKhoi_Luong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pKhoi_Luong)

                Dim pCuoc As SqlParameter = New SqlParameter("@Cuoc", SqlDbType.Float, 0)
                pCuoc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCuoc)

                Dim pCuoc_VCMBND As SqlParameter = New SqlParameter("@Cuoc_VCMBND", SqlDbType.Float, 0)
                pCuoc_VCMBND.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCuoc_VCMBND)

                Dim pId_Dot As SqlParameter = New SqlParameter("@Id_Dot", SqlDbType.VarChar, 50)
                pId_Dot.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Dot)

                Dim pMa_Tien_Te As SqlParameter = New SqlParameter("@Ma_Tien_Te", SqlDbType.VarChar, 5)
                pMa_Tien_Te.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Tien_Te)

                Dim pMa_Tien_Te_VCMBND As SqlParameter = New SqlParameter("@Ma_Tien_Te_VCMBND", SqlDbType.VarChar, 5)
                pMa_Tien_Te_VCMBND.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Tien_Te_VCMBND)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myDSQT_Cuoc_Phat_QT_Di_Chi_Tiet.Id_Cuoc = Id_Cuoc
                myDSQT_Cuoc_Phat_QT_Di_Chi_Tiet.Ma_Nuoc = pMa_Nuoc.Value
                myDSQT_Cuoc_Phat_QT_Di_Chi_Tiet.Cuoc_BP_D = pCuoc_BP_D.Value
                myDSQT_Cuoc_Phat_QT_Di_Chi_Tiet.Cuoc_BP_M = pCuoc_BP_M.Value
                myDSQT_Cuoc_Phat_QT_Di_Chi_Tiet.Khoi_Luong = pKhoi_Luong.Value
                myDSQT_Cuoc_Phat_QT_Di_Chi_Tiet.Cuoc = pCuoc.Value
                myDSQT_Cuoc_Phat_QT_Di_Chi_Tiet.Cuoc_VCMBND = pCuoc_VCMBND.Value
                myDSQT_Cuoc_Phat_QT_Di_Chi_Tiet.Id_Dot = pId_Dot.Value
                myDSQT_Cuoc_Phat_QT_Di_Chi_Tiet.Ma_Tien_Te = pMa_Tien_Te.Value
                myDSQT_Cuoc_Phat_QT_Di_Chi_Tiet.Ma_Tien_Te_VCMBND = pMa_Tien_Te_VCMBND.Value

                Return myDSQT_Cuoc_Phat_QT_Di_Chi_Tiet
                'Return myDSQT_Cuoc_Phat_QT_Di_Chi_Tiet

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

#Region "DSQT_Cuoc_Phat_QT_Di_Them"
        Public Function DSQT_Cuoc_Phat_QT_Di_Them(ByVal Id_Cuoc As String, ByVal Ma_Nuoc As String, ByVal Cuoc_BP_D As Double, ByVal Cuoc_BP_M As Double, ByVal Khoi_Luong As Integer, ByVal Cuoc As Double, ByVal Cuoc_VCMBND As Double, ByVal Id_Dot As String, ByVal Ma_Tien_Te As String, ByVal Ma_Tien_Te_VCMBND As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Cuoc_Phat_QT_Di_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Cuoc_Phat_QT_Di_Chi_Tiet As New DSQT_Cuoc_Phat_QT_Di_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Cuoc As SqlParameter = New SqlParameter("@Id_Cuoc", SqlDbType.VarChar, 52)
                pId_Cuoc.Value = Id_Cuoc
                MyCommand.Parameters.Add(pId_Cuoc)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 50)
                pMa_Nuoc.Value = Ma_Nuoc
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pCuoc_BP_D As SqlParameter = New SqlParameter("@Cuoc_BP_D", SqlDbType.Float, 0)
                pCuoc_BP_D.Value = Cuoc_BP_D
                MyCommand.Parameters.Add(pCuoc_BP_D)

                Dim pCuoc_BP_M As SqlParameter = New SqlParameter("@Cuoc_BP_M", SqlDbType.Float, 0)
                pCuoc_BP_M.Value = Cuoc_BP_M
                MyCommand.Parameters.Add(pCuoc_BP_M)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 0)
                pKhoi_Luong.Value = Khoi_Luong
                MyCommand.Parameters.Add(pKhoi_Luong)

                Dim pCuoc As SqlParameter = New SqlParameter("@Cuoc", SqlDbType.Float, 0)
                pCuoc.Value = Cuoc
                MyCommand.Parameters.Add(pCuoc)

                Dim pCuoc_VCMBND As SqlParameter = New SqlParameter("@Cuoc_VCMBND", SqlDbType.Float, 0)
                pCuoc_VCMBND.Value = Cuoc_VCMBND
                MyCommand.Parameters.Add(pCuoc_VCMBND)

                Dim pId_Dot As SqlParameter = New SqlParameter("@Id_Dot", SqlDbType.VarChar, 50)
                pId_Dot.Value = Id_Dot
                MyCommand.Parameters.Add(pId_Dot)

                Dim pMa_Tien_Te As SqlParameter = New SqlParameter("@Ma_Tien_Te", SqlDbType.VarChar, 5)
                pMa_Tien_Te.Value = Ma_Tien_Te
                MyCommand.Parameters.Add(pMa_Tien_Te)

                Dim pMa_Tien_Te_VCMBND As SqlParameter = New SqlParameter("@Ma_Tien_Te_VCMBND", SqlDbType.VarChar, 5)
                pMa_Tien_Te_VCMBND.Value = Ma_Tien_Te_VCMBND
                MyCommand.Parameters.Add(pMa_Tien_Te_VCMBND)


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

#Region "DSQT_Cuoc_Phat_QT_Di_Xoa"
        Public Function DSQT_Cuoc_Phat_QT_Di_Xoa(ByVal Id_Cuoc As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Cuoc_Phat_QT_Di_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Cuoc_Phat_QT_Di_Chi_Tiet As New DSQT_Cuoc_Phat_QT_Di_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Cuoc As SqlParameter = New SqlParameter("@Id_Cuoc", SqlDbType.VarChar, 52)
                pId_Cuoc.Value = Id_Cuoc
                MyCommand.Parameters.Add(pId_Cuoc)


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



Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "DSQT_Cuoc_QG_HongKongPost_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop DSQT_Cuoc_QG_HongKongPost_Chi_Tiet
    'Tuong ung voi moi truong trong bang DSQT_Cuoc_QG_HongKongPost trong co so du lieu
    '***********************************************************
    Public Class DSQT_Cuoc_QG_HongKongPost_Chi_Tiet
        Public Id_Cuoc As String
        Public Ma_Nuoc As String
        Public Ma_Vung As String
        Public Cuoc_Qua_Giang As Double
        Public Cuoc_HC As Double
        Public Cuoc_BP_M As Double
        Public Cuoc_BP_D As Double
        Public Khoi_Luong As Integer
        Public Id_Dot As String
        Public Ghi_Chu As String
        Public Ma_Tien_Te As String
    End Class
#End Region

#Region "DSQT_Cuoc_QG_HongKongPost"
    Public Class DSQT_Cuoc_QG_HongKongPost
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "DSQT_Cuoc_QG_HongKongPost_Cap_Nhat"
        Public Function DSQT_Cuoc_QG_HongKongPost_Cap_Nhat(ByVal Id_Cuoc As String, ByVal Ma_Nuoc As String, ByVal Ma_Vung As String, ByVal Cuoc_Qua_Giang As Double, ByVal Cuoc_HC As Double, ByVal Cuoc_BP_M As Double, ByVal Cuoc_BP_D As Double, ByVal Khoi_Luong As Integer, ByVal Id_Dot As String, ByVal Ghi_Chu As String, ByVal Ma_Tien_Te As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Cuoc_QG_HongKongPost_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Cuoc_QG_HongKongPost_Chi_Tiet As New DSQT_Cuoc_QG_HongKongPost_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Cuoc As SqlParameter = New SqlParameter("@Id_Cuoc", SqlDbType.VarChar, 70)
                pId_Cuoc.Value = Id_Cuoc
                MyCommand.Parameters.Add(pId_Cuoc)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pMa_Vung As SqlParameter = New SqlParameter("@Ma_Vung", SqlDbType.VarChar, 3)
                pMa_Vung.Value = Ma_Vung
                MyCommand.Parameters.Add(pMa_Vung)

                Dim pCuoc_Qua_Giang As SqlParameter = New SqlParameter("@Cuoc_Qua_Giang", SqlDbType.Float, 0)
                pCuoc_Qua_Giang.Value = Cuoc_Qua_Giang
                MyCommand.Parameters.Add(pCuoc_Qua_Giang)

                Dim pCuoc_HC As SqlParameter = New SqlParameter("@Cuoc_HC", SqlDbType.Float, 0)
                pCuoc_HC.Value = Cuoc_HC
                MyCommand.Parameters.Add(pCuoc_HC)

                Dim pCuoc_BP_M As SqlParameter = New SqlParameter("@Cuoc_BP_M", SqlDbType.Float, 0)
                pCuoc_BP_M.Value = Cuoc_BP_M
                MyCommand.Parameters.Add(pCuoc_BP_M)

                Dim pCuoc_BP_D As SqlParameter = New SqlParameter("@Cuoc_BP_D", SqlDbType.Float, 0)
                pCuoc_BP_D.Value = Cuoc_BP_D
                MyCommand.Parameters.Add(pCuoc_BP_D)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 0)
                pKhoi_Luong.Value = Khoi_Luong
                MyCommand.Parameters.Add(pKhoi_Luong)

                Dim pId_Dot As SqlParameter = New SqlParameter("@Id_Dot", SqlDbType.VarChar, 50)
                pId_Dot.Value = Id_Dot
                MyCommand.Parameters.Add(pId_Dot)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 50)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pMa_Tien_Te As SqlParameter = New SqlParameter("@Ma_Tien_Te", SqlDbType.VarChar, 5)
                pMa_Tien_Te.Value = Ma_Tien_Te
                MyCommand.Parameters.Add(pMa_Tien_Te)


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

#Region "DSQT_Cuoc_QG_HongKongPost_Cap_Nhat_Them"
        Public Function DSQT_Cuoc_QG_HongKongPost_Cap_Nhat_Them(ByVal Id_Cuoc As String, ByVal Ma_Nuoc As String, ByVal Ma_Vung As String, ByVal Cuoc_Qua_Giang As Double, ByVal Cuoc_HC As Double, ByVal Cuoc_BP_M As Double, ByVal Cuoc_BP_D As Double, ByVal Khoi_Luong As Integer, ByVal Id_Dot As String, ByVal Ghi_Chu As String, ByVal Ma_Tien_Te As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Cuoc_QG_HongKongPost_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Cuoc_QG_HongKongPost_Chi_Tiet As New DSQT_Cuoc_QG_HongKongPost_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Cuoc As SqlParameter = New SqlParameter("@Id_Cuoc", SqlDbType.VarChar, 70)
                pId_Cuoc.Value = Id_Cuoc
                MyCommand.Parameters.Add(pId_Cuoc)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pMa_Vung As SqlParameter = New SqlParameter("@Ma_Vung", SqlDbType.VarChar, 3)
                pMa_Vung.Value = Ma_Vung
                MyCommand.Parameters.Add(pMa_Vung)

                Dim pCuoc_Qua_Giang As SqlParameter = New SqlParameter("@Cuoc_Qua_Giang", SqlDbType.Float, 0)
                pCuoc_Qua_Giang.Value = Cuoc_Qua_Giang
                MyCommand.Parameters.Add(pCuoc_Qua_Giang)

                Dim pCuoc_HC As SqlParameter = New SqlParameter("@Cuoc_HC", SqlDbType.Float, 0)
                pCuoc_HC.Value = Cuoc_HC
                MyCommand.Parameters.Add(pCuoc_HC)

                Dim pCuoc_BP_M As SqlParameter = New SqlParameter("@Cuoc_BP_M", SqlDbType.Float, 0)
                pCuoc_BP_M.Value = Cuoc_BP_M
                MyCommand.Parameters.Add(pCuoc_BP_M)

                Dim pCuoc_BP_D As SqlParameter = New SqlParameter("@Cuoc_BP_D", SqlDbType.Float, 0)
                pCuoc_BP_D.Value = Cuoc_BP_D
                MyCommand.Parameters.Add(pCuoc_BP_D)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 0)
                pKhoi_Luong.Value = Khoi_Luong
                MyCommand.Parameters.Add(pKhoi_Luong)

                Dim pId_Dot As SqlParameter = New SqlParameter("@Id_Dot", SqlDbType.VarChar, 50)
                pId_Dot.Value = Id_Dot
                MyCommand.Parameters.Add(pId_Dot)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 50)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pMa_Tien_Te As SqlParameter = New SqlParameter("@Ma_Tien_Te", SqlDbType.VarChar, 5)
                pMa_Tien_Te.Value = Ma_Tien_Te
                MyCommand.Parameters.Add(pMa_Tien_Te)


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


#Region "DSQT_Cuoc_QG_HongKongPost_Danh_Sach"

        Public Function DSQT_Cuoc_QG_HongKongPost_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Id_Cuoc
            ' Ma_Nuoc
            ' Ma_Vung
            ' Cuoc_Qua_Giang
            ' Cuoc_HC
            ' Cuoc_BP_M
            ' Cuoc_BP_D
            ' Khoi_Luong
            ' Id_Dot
            ' Ghi_Chu
            ' Ma_Tien_Te


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Cuoc_QG_HongKongPost_Danh_Sach"
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


#Region "DSQT_Cuoc_QG_HongKongPost_Danh_Sach_Theo_Id_Dot"

        Public Function DSQT_Cuoc_QG_HongKongPost_Danh_Sach_Theo_Id_Dot(ByVal Id_Dot As String) As DataSet

            ' The procedure returns these columns:
            ' Id_Cuoc
            ' Ma_Nuoc
            ' Ma_Vung
            ' Cuoc_Qua_Giang
            ' Cuoc_HC
            ' Cuoc_BP_M
            ' Cuoc_BP_D
            ' Khoi_Luong
            ' Id_Dot
            ' Ghi_Chu
            ' Ma_Tien_Te


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Cuoc_QG_HongKongPost_Danh_Sach_Theo_Id_Dot"
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

#Region "DSQT_Cuoc_QG_HongKongPost_Lay"
        Public Function DSQT_Cuoc_QG_HongKongPost_Lay(ByVal Id_Cuoc As String) As DSQT_Cuoc_QG_HongKongPost_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Cuoc_QG_HongKongPost_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Cuoc_QG_HongKongPost_Chi_Tiet As New DSQT_Cuoc_QG_HongKongPost_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Cuoc As SqlParameter = New SqlParameter("@Id_Cuoc", SqlDbType.VarChar, 70)
                pId_Cuoc.Value = Id_Cuoc
                MyCommand.Parameters.Add(pId_Cuoc)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pMa_Vung As SqlParameter = New SqlParameter("@Ma_Vung", SqlDbType.VarChar, 3)
                pMa_Vung.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Vung)

                Dim pCuoc_Qua_Giang As SqlParameter = New SqlParameter("@Cuoc_Qua_Giang", SqlDbType.Float, 0)
                pCuoc_Qua_Giang.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCuoc_Qua_Giang)

                Dim pCuoc_HC As SqlParameter = New SqlParameter("@Cuoc_HC", SqlDbType.Float, 0)
                pCuoc_HC.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCuoc_HC)

                Dim pCuoc_BP_M As SqlParameter = New SqlParameter("@Cuoc_BP_M", SqlDbType.Float, 0)
                pCuoc_BP_M.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCuoc_BP_M)

                Dim pCuoc_BP_D As SqlParameter = New SqlParameter("@Cuoc_BP_D", SqlDbType.Float, 0)
                pCuoc_BP_D.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCuoc_BP_D)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 0)
                pKhoi_Luong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pKhoi_Luong)

                Dim pId_Dot As SqlParameter = New SqlParameter("@Id_Dot", SqlDbType.VarChar, 50)
                pId_Dot.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Dot)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 50)
                pGhi_Chu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pMa_Tien_Te As SqlParameter = New SqlParameter("@Ma_Tien_Te", SqlDbType.VarChar, 5)
                pMa_Tien_Te.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Tien_Te)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myDSQT_Cuoc_QG_HongKongPost_Chi_Tiet.Id_Cuoc = Id_Cuoc
                myDSQT_Cuoc_QG_HongKongPost_Chi_Tiet.Ma_Nuoc = pMa_Nuoc.Value
                myDSQT_Cuoc_QG_HongKongPost_Chi_Tiet.Ma_Vung = pMa_Vung.Value
                myDSQT_Cuoc_QG_HongKongPost_Chi_Tiet.Cuoc_Qua_Giang = pCuoc_Qua_Giang.Value
                myDSQT_Cuoc_QG_HongKongPost_Chi_Tiet.Cuoc_HC = pCuoc_HC.Value
                myDSQT_Cuoc_QG_HongKongPost_Chi_Tiet.Cuoc_BP_M = pCuoc_BP_M.Value
                myDSQT_Cuoc_QG_HongKongPost_Chi_Tiet.Cuoc_BP_D = pCuoc_BP_D.Value
                myDSQT_Cuoc_QG_HongKongPost_Chi_Tiet.Khoi_Luong = pKhoi_Luong.Value
                myDSQT_Cuoc_QG_HongKongPost_Chi_Tiet.Id_Dot = pId_Dot.Value
                myDSQT_Cuoc_QG_HongKongPost_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value
                myDSQT_Cuoc_QG_HongKongPost_Chi_Tiet.Ma_Tien_Te = pMa_Tien_Te.Value

                Return myDSQT_Cuoc_QG_HongKongPost_Chi_Tiet
                'Return myDSQT_Cuoc_QG_HongKongPost_Chi_Tiet

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

#Region "DSQT_Cuoc_QG_HongKongPost_Them"
        Public Function DSQT_Cuoc_QG_HongKongPost_Them(ByVal Id_Cuoc As String, ByVal Ma_Nuoc As String, ByVal Ma_Vung As String, ByVal Cuoc_Qua_Giang As Double, ByVal Cuoc_HC As Double, ByVal Cuoc_BP_M As Double, ByVal Cuoc_BP_D As Double, ByVal Khoi_Luong As Integer, ByVal Id_Dot As String, ByVal Ghi_Chu As String, ByVal Ma_Tien_Te As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Cuoc_QG_HongKongPost_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Cuoc_QG_HongKongPost_Chi_Tiet As New DSQT_Cuoc_QG_HongKongPost_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Cuoc As SqlParameter = New SqlParameter("@Id_Cuoc", SqlDbType.VarChar, 70)
                pId_Cuoc.Value = Id_Cuoc
                MyCommand.Parameters.Add(pId_Cuoc)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pMa_Vung As SqlParameter = New SqlParameter("@Ma_Vung", SqlDbType.VarChar, 3)
                pMa_Vung.Value = Ma_Vung
                MyCommand.Parameters.Add(pMa_Vung)

                Dim pCuoc_Qua_Giang As SqlParameter = New SqlParameter("@Cuoc_Qua_Giang", SqlDbType.Float, 0)
                pCuoc_Qua_Giang.Value = Cuoc_Qua_Giang
                MyCommand.Parameters.Add(pCuoc_Qua_Giang)

                Dim pCuoc_HC As SqlParameter = New SqlParameter("@Cuoc_HC", SqlDbType.Float, 0)
                pCuoc_HC.Value = Cuoc_HC
                MyCommand.Parameters.Add(pCuoc_HC)

                Dim pCuoc_BP_M As SqlParameter = New SqlParameter("@Cuoc_BP_M", SqlDbType.Float, 0)
                pCuoc_BP_M.Value = Cuoc_BP_M
                MyCommand.Parameters.Add(pCuoc_BP_M)

                Dim pCuoc_BP_D As SqlParameter = New SqlParameter("@Cuoc_BP_D", SqlDbType.Float, 0)
                pCuoc_BP_D.Value = Cuoc_BP_D
                MyCommand.Parameters.Add(pCuoc_BP_D)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 0)
                pKhoi_Luong.Value = Khoi_Luong
                MyCommand.Parameters.Add(pKhoi_Luong)

                Dim pId_Dot As SqlParameter = New SqlParameter("@Id_Dot", SqlDbType.VarChar, 50)
                pId_Dot.Value = Id_Dot
                MyCommand.Parameters.Add(pId_Dot)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 50)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pMa_Tien_Te As SqlParameter = New SqlParameter("@Ma_Tien_Te", SqlDbType.VarChar, 5)
                pMa_Tien_Te.Value = Ma_Tien_Te
                MyCommand.Parameters.Add(pMa_Tien_Te)


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

#Region "DSQT_Cuoc_QG_HongKongPost_Xoa"
        Public Function DSQT_Cuoc_QG_HongKongPost_Xoa(ByVal Id_Cuoc As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Cuoc_QG_HongKongPost_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Cuoc_QG_HongKongPost_Chi_Tiet As New DSQT_Cuoc_QG_HongKongPost_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Cuoc As SqlParameter = New SqlParameter("@Id_Cuoc", SqlDbType.VarChar, 70)
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


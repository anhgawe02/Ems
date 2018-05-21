
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "DSQT_Danh_Muc_Dot_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop DSQT_Danh_Muc_Dot_Chi_Tiet
    'Tuong ung voi moi truong trong bang DSQT_Danh_Muc_Dot trong co so du lieu
    '***********************************************************
    Public Class DSQT_Danh_Muc_Dot_Chi_Tiet
        Public Id_Dot As String
        Public Dot As Integer
        Public Ten_Dot As String
        Public Ten_Doi_Tuong As String
        Public Ngay_Bat_Dau As Integer
        Public Ngay_Ket_Thuc As Integer
        Public Ghi_Chu As String
        Public Ma_Tien_Te As String
    End Class
#End Region

#Region "DSQT_Danh_Muc_Dot"
    Public Class DSQT_Danh_Muc_Dot
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "DSQT_Danh_Muc_Dot_Cap_Nhat"
        Public Function DSQT_Danh_Muc_Dot_Cap_Nhat(ByVal Id_Dot As String, ByVal Dot As Integer, ByVal Ten_Dot As String, ByVal Ten_Doi_Tuong As String, ByVal Ngay_Bat_Dau As Integer, ByVal Ngay_Ket_Thuc As Integer, ByVal Ghi_Chu As String, ByVal Ma_Tien_Te As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Dot_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Danh_Muc_Dot_Chi_Tiet As New DSQT_Danh_Muc_Dot_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Dot As SqlParameter = New SqlParameter("@Id_Dot", SqlDbType.VarChar, 50)
                pId_Dot.Value = Id_Dot
                MyCommand.Parameters.Add(pId_Dot)

                Dim pDot As SqlParameter = New SqlParameter("@Dot", SqlDbType.Int, 0)
                pDot.Value = Dot
                MyCommand.Parameters.Add(pDot)

                Dim pTen_Dot As SqlParameter = New SqlParameter("@Ten_Dot", SqlDbType.VarChar, 200)
                pTen_Dot.Value = Ten_Dot
                MyCommand.Parameters.Add(pTen_Dot)

                Dim pTen_Doi_Tuong As SqlParameter = New SqlParameter("@Ten_Doi_Tuong", SqlDbType.VarChar, 45)
                pTen_Doi_Tuong.Value = Ten_Doi_Tuong
                MyCommand.Parameters.Add(pTen_Doi_Tuong)

                Dim pNgay_Bat_Dau As SqlParameter = New SqlParameter("@Ngay_Bat_Dau", SqlDbType.Int, 0)
                pNgay_Bat_Dau.Value = Ngay_Bat_Dau
                MyCommand.Parameters.Add(pNgay_Bat_Dau)

                Dim pNgay_Ket_Thuc As SqlParameter = New SqlParameter("@Ngay_Ket_Thuc", SqlDbType.Int, 0)
                pNgay_Ket_Thuc.Value = Ngay_Ket_Thuc
                MyCommand.Parameters.Add(pNgay_Ket_Thuc)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
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

#Region "DSQT_Danh_Muc_Dot_Cap_Nhat_Them"
        Public Function DSQT_Danh_Muc_Dot_Cap_Nhat_Them(ByVal Id_Dot As String, ByVal Dot As Integer, ByVal Ten_Dot As String, ByVal Ten_Doi_Tuong As String, ByVal Ngay_Bat_Dau As Integer, ByVal Ngay_Ket_Thuc As Integer, ByVal Ghi_Chu As String, ByVal Ma_Tien_Te As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Dot_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Danh_Muc_Dot_Chi_Tiet As New DSQT_Danh_Muc_Dot_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Dot As SqlParameter = New SqlParameter("@Id_Dot", SqlDbType.VarChar, 50)
                pId_Dot.Value = Id_Dot
                MyCommand.Parameters.Add(pId_Dot)

                Dim pDot As SqlParameter = New SqlParameter("@Dot", SqlDbType.Int, 0)
                pDot.Value = Dot
                MyCommand.Parameters.Add(pDot)

                Dim pTen_Dot As SqlParameter = New SqlParameter("@Ten_Dot", SqlDbType.VarChar, 200)
                pTen_Dot.Value = Ten_Dot
                MyCommand.Parameters.Add(pTen_Dot)

                Dim pTen_Doi_Tuong As SqlParameter = New SqlParameter("@Ten_Doi_Tuong", SqlDbType.VarChar, 45)
                pTen_Doi_Tuong.Value = Ten_Doi_Tuong
                MyCommand.Parameters.Add(pTen_Doi_Tuong)

                Dim pNgay_Bat_Dau As SqlParameter = New SqlParameter("@Ngay_Bat_Dau", SqlDbType.Int, 0)
                pNgay_Bat_Dau.Value = Ngay_Bat_Dau
                MyCommand.Parameters.Add(pNgay_Bat_Dau)

                Dim pNgay_Ket_Thuc As SqlParameter = New SqlParameter("@Ngay_Ket_Thuc", SqlDbType.Int, 0)
                pNgay_Ket_Thuc.Value = Ngay_Ket_Thuc
                MyCommand.Parameters.Add(pNgay_Ket_Thuc)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
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

#Region "DSQT_Danh_Muc_Dot_Danh_Sach"

        Public Function DSQT_Danh_Muc_Dot_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Id_Dot
            ' Dot
            ' Ten_Dot
            ' Ten_Doi_Tuong
            ' Ngay_Bat_Dau
            ' Ngay_Ket_Thuc
            ' Ghi_Chu


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Dot_Danh_Sach"
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

#Region "DSQT_Danh_Muc_Dot_Lay"
        Public Function DSQT_Danh_Muc_Dot_Lay(ByVal Id_Dot As String) As DSQT_Danh_Muc_Dot_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Dot_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Danh_Muc_Dot_Chi_Tiet As New DSQT_Danh_Muc_Dot_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Dot As SqlParameter = New SqlParameter("@Id_Dot", SqlDbType.VarChar, 50)
                pId_Dot.Value = Id_Dot
                MyCommand.Parameters.Add(pId_Dot)

                Dim pDot As SqlParameter = New SqlParameter("@Dot", SqlDbType.Int, 0)
                pDot.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDot)

                Dim pTen_Dot As SqlParameter = New SqlParameter("@Ten_Dot", SqlDbType.VarChar, 200)
                pTen_Dot.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTen_Dot)

                Dim pTen_Doi_Tuong As SqlParameter = New SqlParameter("@Ten_Doi_Tuong", SqlDbType.VarChar, 45)
                pTen_Doi_Tuong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTen_Doi_Tuong)

                Dim pNgay_Bat_Dau As SqlParameter = New SqlParameter("@Ngay_Bat_Dau", SqlDbType.Int, 0)
                pNgay_Bat_Dau.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Bat_Dau)

                Dim pNgay_Ket_Thuc As SqlParameter = New SqlParameter("@Ngay_Ket_Thuc", SqlDbType.Int, 0)
                pNgay_Ket_Thuc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Ket_Thuc)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
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
                myDSQT_Danh_Muc_Dot_Chi_Tiet.Id_Dot = Id_Dot
                myDSQT_Danh_Muc_Dot_Chi_Tiet.Dot = pDot.Value
                myDSQT_Danh_Muc_Dot_Chi_Tiet.Ten_Dot = pTen_Dot.Value
                myDSQT_Danh_Muc_Dot_Chi_Tiet.Ten_Doi_Tuong = pTen_Doi_Tuong.Value
                myDSQT_Danh_Muc_Dot_Chi_Tiet.Ngay_Bat_Dau = pNgay_Bat_Dau.Value
                myDSQT_Danh_Muc_Dot_Chi_Tiet.Ngay_Ket_Thuc = pNgay_Ket_Thuc.Value
                myDSQT_Danh_Muc_Dot_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value
                myDSQT_Danh_Muc_Dot_Chi_Tiet.Ma_Tien_Te = pMa_Tien_Te.Value

                Return myDSQT_Danh_Muc_Dot_Chi_Tiet
                'Return myDSQT_Danh_Muc_Dot_Chi_Tiet

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

#Region "DSQT_Danh_Muc_Dot_Them"
        Public Function DSQT_Danh_Muc_Dot_Them(ByVal Id_Dot As String, ByVal Dot As Integer, ByVal Ten_Dot As String, ByVal Ten_Doi_Tuong As String, ByVal Ngay_Bat_Dau As Integer, ByVal Ngay_Ket_Thuc As Integer, ByVal Ghi_Chu As String, ByVal Ma_Tien_Te As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Dot_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Danh_Muc_Dot_Chi_Tiet As New DSQT_Danh_Muc_Dot_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Dot As SqlParameter = New SqlParameter("@Id_Dot", SqlDbType.VarChar, 50)
                pId_Dot.Value = Id_Dot
                MyCommand.Parameters.Add(pId_Dot)

                Dim pDot As SqlParameter = New SqlParameter("@Dot", SqlDbType.Int, 0)
                pDot.Value = Dot
                MyCommand.Parameters.Add(pDot)

                Dim pTen_Dot As SqlParameter = New SqlParameter("@Ten_Dot", SqlDbType.VarChar, 200)
                pTen_Dot.Value = Ten_Dot
                MyCommand.Parameters.Add(pTen_Dot)

                Dim pTen_Doi_Tuong As SqlParameter = New SqlParameter("@Ten_Doi_Tuong", SqlDbType.VarChar, 45)
                pTen_Doi_Tuong.Value = Ten_Doi_Tuong
                MyCommand.Parameters.Add(pTen_Doi_Tuong)

                Dim pNgay_Bat_Dau As SqlParameter = New SqlParameter("@Ngay_Bat_Dau", SqlDbType.Int, 0)
                pNgay_Bat_Dau.Value = Ngay_Bat_Dau
                MyCommand.Parameters.Add(pNgay_Bat_Dau)

                Dim pNgay_Ket_Thuc As SqlParameter = New SqlParameter("@Ngay_Ket_Thuc", SqlDbType.Int, 0)
                pNgay_Ket_Thuc.Value = Ngay_Ket_Thuc
                MyCommand.Parameters.Add(pNgay_Ket_Thuc)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
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

#Region "DSQT_Danh_Muc_Dot_Xoa"
        Public Function DSQT_Danh_Muc_Dot_Xoa(ByVal Id_Dot As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Dot_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Danh_Muc_Dot_Chi_Tiet As New DSQT_Danh_Muc_Dot_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Dot As SqlParameter = New SqlParameter("@Id_Dot", SqlDbType.VarChar, 50)
                pId_Dot.Value = Id_Dot
                MyCommand.Parameters.Add(pId_Dot)


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

#Region "DSQT_Danh_Muc_Dot_Danh_Sach_Lay_Theo_Ten_Doi_Tuong"

        Public Function DSQT_Danh_Muc_Dot_Danh_Sach_Lay_Theo_Ten_Doi_Tuong(ByVal Ten_Doi_Tuong As String) As DataSet

            ' The procedure returns these columns:
            ' Id_Dot
            ' Dot
            ' Ten_Dot
            ' Ten_Doi_Tuong
            ' Ngay_Bat_Dau
            ' Ngay_Ket_Thuc
            ' Ghi_Chu


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Dot_Danh_Sach_Lay_Theo_Ten_Doi_Tuong"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pTen_Doi_Tuong As SqlParameter = New SqlParameter("@Ten_Doi_Tuong", SqlDbType.VarChar, 45)
                pTen_Doi_Tuong.Value = Ten_Doi_Tuong
                MyCommand.Parameters.Add(pTen_Doi_Tuong)


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

#Region "DSQT_Danh_Muc_Dot_Lay_Dot_Lon_Nhat_Theo_Ten_Doi_Tuong"
        Public Function DSQT_Danh_Muc_Dot_Lay_Dot_Lon_Nhat_Theo_Ten_Doi_Tuong(ByVal Ten_Doi_Tuong As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Dot_Lay_Dot_Lon_Nhat_Theo_Ten_Doi_Tuong"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Danh_Muc_Dot_Chi_Tiet As New DSQT_Danh_Muc_Dot_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pTen_Doi_Tuong As SqlParameter = New SqlParameter("@Ten_Doi_Tuong", SqlDbType.VarChar, 45)
                pTen_Doi_Tuong.Value = Ten_Doi_Tuong
                MyCommand.Parameters.Add(pTen_Doi_Tuong)

                Dim pMax_Dot As SqlParameter = New SqlParameter("@Max_Dot", SqlDbType.Int, 0)
                pMax_Dot.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMax_Dot)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values               

                Return pMax_Dot.Value
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

#Region "DSQT_Danh_Muc_Dot_Lay_Dot_Lien_Truoc_Dot_Lon_Nhat_Theo_Ten_Doi_Tuong"
        Public Function DSQT_Danh_Muc_Dot_Lay_Dot_Lien_Truoc_Dot_Lon_Nhat_Theo_Ten_Doi_Tuong(ByVal Ten_Doi_Tuong As String, ByVal Max_Dot As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Dot_Lay_Dot_Lien_Truoc_Dot_Lon_Nhat_Theo_Ten_Doi_Tuong"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Danh_Muc_Dot_Chi_Tiet As New DSQT_Danh_Muc_Dot_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pTen_Doi_Tuong As SqlParameter = New SqlParameter("@Ten_Doi_Tuong", SqlDbType.VarChar, 45)
                pTen_Doi_Tuong.Value = Ten_Doi_Tuong
                MyCommand.Parameters.Add(pTen_Doi_Tuong)

                Dim pMax_Dot As SqlParameter = New SqlParameter("@Max_Dot", SqlDbType.Int, 0)
                pMax_Dot.Value = Max_Dot
                MyCommand.Parameters.Add(pMax_Dot)

                Dim pDot_Lien_Truoc As SqlParameter = New SqlParameter("@Dot_Lien_Truoc", SqlDbType.Int, 0)
                pDot_Lien_Truoc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDot_Lien_Truoc)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values               

                Return pDot_Lien_Truoc.Value
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

#Region "DSQT_Danh_Muc_Dot_Lay_Theo_Ngay_Ten_Doi_Tuong"
        Public Function DSQT_Danh_Muc_Dot_Lay_Theo_Ngay_Dong_Ten_Doi_Tuong(ByVal Ngay_Dong As Integer, ByVal Ten_Doi_Tuong As String) As DSQT_Danh_Muc_Dot_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Danh_Muc_Dot_Lay_Theo_Ngay_Dong_Ten_Doi_Tuong"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Danh_Muc_Dot_Chi_Tiet As New DSQT_Danh_Muc_Dot_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters
                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 0)
                pNgay_Dong.Value = Ngay_Dong
                MyCommand.Parameters.Add(pNgay_Dong)

                Dim pTen_Doi_Tuong As SqlParameter = New SqlParameter("@Ten_Doi_Tuong", SqlDbType.VarChar, 45)
                pTen_Doi_Tuong.Value = Ten_Doi_Tuong
                MyCommand.Parameters.Add(pTen_Doi_Tuong)

                Dim pId_Dot As SqlParameter = New SqlParameter("@Id_Dot", SqlDbType.VarChar, 50)
                pId_Dot.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Dot)

                Dim pDot As SqlParameter = New SqlParameter("@Dot", SqlDbType.Int, 0)
                pDot.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDot)

                Dim pTen_Dot As SqlParameter = New SqlParameter("@Ten_Dot", SqlDbType.VarChar, 200)
                pTen_Dot.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTen_Dot)

                Dim pNgay_Bat_Dau As SqlParameter = New SqlParameter("@Ngay_Bat_Dau", SqlDbType.Int, 0)
                pNgay_Bat_Dau.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Bat_Dau)

                Dim pNgay_Ket_Thuc As SqlParameter = New SqlParameter("@Ngay_Ket_Thuc", SqlDbType.Int, 0)
                pNgay_Ket_Thuc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Ket_Thuc)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
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
                myDSQT_Danh_Muc_Dot_Chi_Tiet.Id_Dot = pId_Dot.Value
                myDSQT_Danh_Muc_Dot_Chi_Tiet.Dot = pDot.Value
                myDSQT_Danh_Muc_Dot_Chi_Tiet.Ten_Dot = pTen_Dot.Value
                myDSQT_Danh_Muc_Dot_Chi_Tiet.Ten_Doi_Tuong = Ten_Doi_Tuong
                myDSQT_Danh_Muc_Dot_Chi_Tiet.Ngay_Bat_Dau = pNgay_Bat_Dau.Value
                myDSQT_Danh_Muc_Dot_Chi_Tiet.Ngay_Ket_Thuc = pNgay_Ket_Thuc.Value
                myDSQT_Danh_Muc_Dot_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value
                myDSQT_Danh_Muc_Dot_Chi_Tiet.Ma_Tien_Te = pMa_Tien_Te.Value

                Return myDSQT_Danh_Muc_Dot_Chi_Tiet
                'Return myDSQT_Danh_Muc_Dot_Chi_Tiet

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


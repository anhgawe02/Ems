
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "QLTGND_E2_Den_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop QLTGND_E2_Den_Chi_Tiet
    'Tuong ung voi moi truong trong bang QLTGND_E2_Den trong co so du lieu
    '***********************************************************
    Public Class QLTGND_E2_Den_Chi_Tiet
        Public Id_E2 As String
        Public Id_Giao_Nhan As String
        Public Id_Tui_Thu As String
        Public STT As Integer
        Public Truyen_Khai_Thac As Boolean
        Public Truyen_Doi_Soat As Boolean
        Public Chot_SL As Boolean
        Public Ngay_He_Thong As Integer
        Public Gio_He_Thong As Integer
    End Class
#End Region

#Region "QLTGND_E2_Den"
    Public Class QLTGND_E2_Den
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "QLTGND_E2_Den_Cap_Nhat_Them"
        Public Function QLTGND_E2_Den_Cap_Nhat_Them(ByVal Id_E2 As String, ByVal Id_Giao_Nhan As String, ByVal Id_Tui_Thu As String, ByVal STT As Integer, ByVal Truyen_Khai_Thac As Boolean, ByVal Truyen_Doi_Soat As Boolean, ByVal Chot_SL As Boolean, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_E2_Den_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_E2_Den_Chi_Tiet As New QLTGND_E2_Den_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                MyCommand.Parameters.Add(pId_E2)

                Dim pId_Giao_Nhan As SqlParameter = New SqlParameter("@Id_Giao_Nhan", SqlDbType.VarChar, 20)
                pId_Giao_Nhan.Value = Id_Giao_Nhan
                MyCommand.Parameters.Add(pId_Giao_Nhan)

                Dim pId_Tui_Thu As SqlParameter = New SqlParameter("@Id_Tui_Thu", SqlDbType.VarChar, 39)
                pId_Tui_Thu.Value = Id_Tui_Thu
                MyCommand.Parameters.Add(pId_Tui_Thu)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Value = STT
                MyCommand.Parameters.Add(pSTT)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 0)
                pTruyen_Khai_Thac.Value = Truyen_Khai_Thac
                MyCommand.Parameters.Add(pTruyen_Khai_Thac)

                Dim pTruyen_Doi_Soat As SqlParameter = New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 0)
                pTruyen_Doi_Soat.Value = Truyen_Doi_Soat
                MyCommand.Parameters.Add(pTruyen_Doi_Soat)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 0)
                pChot_SL.Value = Chot_SL
                MyCommand.Parameters.Add(pChot_SL)

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
#Region "QLTGND_E2_Den_Danh_Sach"

        Public Function QLTGND_E2_Den_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Id_E2
            ' Id_Giao_Nhan
            ' Id_Tui_Thu
            ' STT
            ' Truyen_Khai_Thac
            ' Truyen_Doi_Soat
            ' Chot_SL
            ' Ngay_He_Thong
            ' Gio_He_Thong


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_E2_Den_Danh_Sach"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
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
#End Region
#Region "QLTGND_E2_Den_Lay"
        Public Function QLTGND_E2_Den_Lay(ByVal Id_E2 As String) As QLTGND_E2_Den_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_E2_Den_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_E2_Den_Chi_Tiet As New QLTGND_E2_Den_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                MyCommand.Parameters.Add(pId_E2)

                Dim pId_Giao_Nhan As SqlParameter = New SqlParameter("@Id_Giao_Nhan", SqlDbType.VarChar, 20)
                pId_Giao_Nhan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Giao_Nhan)

                Dim pId_Tui_Thu As SqlParameter = New SqlParameter("@Id_Tui_Thu", SqlDbType.VarChar, 39)
                pId_Tui_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Tui_Thu)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSTT)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 0)
                pTruyen_Khai_Thac.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTruyen_Khai_Thac)

                Dim pTruyen_Doi_Soat As SqlParameter = New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 0)
                pTruyen_Doi_Soat.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTruyen_Doi_Soat)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 0)
                pChot_SL.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pChot_SL)

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
                myQLTGND_E2_Den_Chi_Tiet.Id_E2 = Id_E2
                myQLTGND_E2_Den_Chi_Tiet.Id_Giao_Nhan = pId_Giao_Nhan.Value
                myQLTGND_E2_Den_Chi_Tiet.Id_Tui_Thu = pId_Tui_Thu.Value
                myQLTGND_E2_Den_Chi_Tiet.STT = pSTT.Value
                myQLTGND_E2_Den_Chi_Tiet.Truyen_Khai_Thac = pTruyen_Khai_Thac.Value
                myQLTGND_E2_Den_Chi_Tiet.Truyen_Doi_Soat = pTruyen_Doi_Soat.Value
                myQLTGND_E2_Den_Chi_Tiet.Chot_SL = pChot_SL.Value
                myQLTGND_E2_Den_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myQLTGND_E2_Den_Chi_Tiet.Gio_He_Thong = pGio_He_Thong.Value

                Return myQLTGND_E2_Den_Chi_Tiet
                'Return myQLTGND_E2_Den_Chi_Tiet

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
#Region "QLTGND_E2_Den_Xoa"
        Public Function QLTGND_E2_Den_Xoa(ByVal Id_E2 As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_E2_Den_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_E2_Den_Chi_Tiet As New QLTGND_E2_Den_Chi_Tiet

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

#Region "QLTGND_E2_Den_Lay_Id_E2_Theo_Ma_Vach_Tui"
        Public Function QLTGND_E2_Den_Lay_Id_E2_Theo_Ma_Vach_Tui(ByVal Id_Tui_Thu As String, ByRef So_Dong As Integer) As String
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_E2_Den_Lay_Id_E2_Theo_Ma_Vach_Tui"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Tui_Thu As SqlParameter = New SqlParameter("@Id_Tui_Thu", SqlDbType.VarChar, 39)
                pId_Tui_Thu.Value = Id_Tui_Thu
                MyCommand.Parameters.Add(pId_Tui_Thu)

                Dim pSo_Dong As SqlParameter = New SqlParameter("@So_Dong", SqlDbType.Int, 0)
                pSo_Dong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSo_Dong)

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_E2)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                So_Dong = pSo_Dong.Value

                Return pId_E2.Value
                'Return numRows

            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)
                Return Nothing

            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()

            End Try
        End Function

#End Region
#Region "QLTGND_E2_Den_Lay_Tong_Khoi_Luong_QD_Tu_E1_Di"
        Public Function QLTGND_E2_Den_Lay_Tong_Khoi_Luong_QD_Tu_E1_Di(ByVal Id_E2 As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_E2_Den_Lay_Tong_Khoi_Luong_QD_Tu_E1_Di"
            MyCommand.CommandType = CommandType.StoredProcedure

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                MyCommand.Parameters.Add(pId_E2)

                Dim pKhoi_Luong_QD As SqlParameter = New SqlParameter("@Khoi_Luong_QD", SqlDbType.Int, 0)
                pKhoi_Luong_QD.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pKhoi_Luong_QD)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                Return pKhoi_Luong_QD.Value
                'Return numRows

            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)
                Return 0

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


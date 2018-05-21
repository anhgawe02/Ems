
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "Accounting_Bang_Cuoc_Hang_Khong_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop Accounting_Bang_Cuoc_Hang_Khong_Chi_Tiet
    'Tuong ung voi moi truong trong bang Accounting_Bang_Cuoc_Hang_Khong trong co so du lieu
    '***********************************************************
    Public Class Accounting_Bang_Cuoc_Hang_Khong_Chi_Tiet
        Public Id_Cuoc_Hang_Khong As String
        Public HVC As String
        Public San_Bay_Xuat_Phat As String
        Public San_Bay_Den As String
        Public Cuoc As Double
        Public Cuoc_Tui_Rong As Double
        Public Ngay_He_Thong As Integer
        Public Gio_He_Thong As Integer
    End Class
#End Region

#Region "Accounting_Bang_Cuoc_Hang_Khong"
    Public Class Accounting_Bang_Cuoc_Hang_Khong
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "Accounting_Bang_Cuoc_Hang_Khong_Cap_Nhat_Them"
        Public Function Accounting_Bang_Cuoc_Hang_Khong_Cap_Nhat_Them(ByVal Id_Cuoc_Hang_Khong As String, ByVal HVC As String, ByVal San_Bay_Xuat_Phat As String, ByVal San_Bay_Den As String, ByVal Cuoc As Double, ByVal Cuoc_Tui_Rong As Double, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Bang_Cuoc_Hang_Khong_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myAccounting_Bang_Cuoc_Hang_Khong_Chi_Tiet As New Accounting_Bang_Cuoc_Hang_Khong_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Cuoc_Hang_Khong As SqlParameter = New SqlParameter("@Id_Cuoc_Hang_Khong", SqlDbType.VarChar, 20)
                pId_Cuoc_Hang_Khong.Value = Id_Cuoc_Hang_Khong
                MyCommand.Parameters.Add(pId_Cuoc_Hang_Khong)

                Dim pHVC As SqlParameter = New SqlParameter("@HVC", SqlDbType.VarChar, 50)
                pHVC.Value = HVC
                MyCommand.Parameters.Add(pHVC)

                Dim pSan_Bay_Xuat_Phat As SqlParameter = New SqlParameter("@San_Bay_Xuat_Phat", SqlDbType.VarChar, 10)
                pSan_Bay_Xuat_Phat.Value = San_Bay_Xuat_Phat
                MyCommand.Parameters.Add(pSan_Bay_Xuat_Phat)

                Dim pSan_Bay_Den As SqlParameter = New SqlParameter("@San_Bay_Den", SqlDbType.VarChar, 10)
                pSan_Bay_Den.Value = San_Bay_Den
                MyCommand.Parameters.Add(pSan_Bay_Den)

                Dim pCuoc As SqlParameter = New SqlParameter("@Cuoc", SqlDbType.Float, 0)
                pCuoc.Value = Cuoc
                MyCommand.Parameters.Add(pCuoc)

                Dim pCuoc_Tui_Rong As SqlParameter = New SqlParameter("@Cuoc_Tui_Rong", SqlDbType.Float, 0)
                pCuoc_Tui_Rong.Value = Cuoc_Tui_Rong
                MyCommand.Parameters.Add(pCuoc_Tui_Rong)

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


#Region "Accounting_Bang_Cuoc_Hang_Khong_Danh_Sach"

        Public Function Accounting_Bang_Cuoc_Hang_Khong_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Id_Cuoc_Hang_Khong
            ' HVC
            ' San_Bay_Xuat_Phat
            ' San_Bay_Den
            ' Cuoc
            ' Ngay_He_Thong
            ' Gio_He_Thong


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Bang_Cuoc_Hang_Khong_Danh_Sach"
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

#Region "Accounting_Bang_Cuoc_Hang_Khong_Lay"
        Public Function Accounting_Bang_Cuoc_Hang_Khong_Lay(ByVal Id_Cuoc_Hang_Khong As String) As Accounting_Bang_Cuoc_Hang_Khong_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Bang_Cuoc_Hang_Khong_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myAccounting_Bang_Cuoc_Hang_Khong_Chi_Tiet As New Accounting_Bang_Cuoc_Hang_Khong_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Cuoc_Hang_Khong As SqlParameter = New SqlParameter("@Id_Cuoc_Hang_Khong", SqlDbType.VarChar, 20)
                pId_Cuoc_Hang_Khong.Value = Id_Cuoc_Hang_Khong
                MyCommand.Parameters.Add(pId_Cuoc_Hang_Khong)

                Dim pHVC As SqlParameter = New SqlParameter("@HVC", SqlDbType.VarChar, 50)
                pHVC.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pHVC)

                Dim pSan_Bay_Xuat_Phat As SqlParameter = New SqlParameter("@San_Bay_Xuat_Phat", SqlDbType.VarChar, 10)
                pSan_Bay_Xuat_Phat.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSan_Bay_Xuat_Phat)

                Dim pSan_Bay_Den As SqlParameter = New SqlParameter("@San_Bay_Den", SqlDbType.VarChar, 10)
                pSan_Bay_Den.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSan_Bay_Den)

                Dim pCuoc As SqlParameter = New SqlParameter("@Cuoc", SqlDbType.Float, 0)
                pCuoc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCuoc)

                Dim pCuoc_Tui_Rong As SqlParameter = New SqlParameter("@Cuoc_Tui_Rong", SqlDbType.Float, 0)
                pCuoc_Tui_Rong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCuoc_Tui_Rong)

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
                myAccounting_Bang_Cuoc_Hang_Khong_Chi_Tiet.Id_Cuoc_Hang_Khong = Id_Cuoc_Hang_Khong
                myAccounting_Bang_Cuoc_Hang_Khong_Chi_Tiet.HVC = pHVC.Value
                myAccounting_Bang_Cuoc_Hang_Khong_Chi_Tiet.San_Bay_Xuat_Phat = pSan_Bay_Xuat_Phat.Value
                myAccounting_Bang_Cuoc_Hang_Khong_Chi_Tiet.San_Bay_Den = pSan_Bay_Den.Value
                myAccounting_Bang_Cuoc_Hang_Khong_Chi_Tiet.Cuoc = pCuoc.Value
                myAccounting_Bang_Cuoc_Hang_Khong_Chi_Tiet.Cuoc_Tui_Rong = pCuoc_Tui_Rong.Value
                myAccounting_Bang_Cuoc_Hang_Khong_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myAccounting_Bang_Cuoc_Hang_Khong_Chi_Tiet.Gio_He_Thong = pGio_He_Thong.Value

                Return myAccounting_Bang_Cuoc_Hang_Khong_Chi_Tiet
                'Return myAccounting_Bang_Cuoc_Hang_Khong_Chi_Tiet

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

#Region "Accounting_Bang_Cuoc_Hang_Khong_Xoa"
        Public Function Accounting_Bang_Cuoc_Hang_Khong_Xoa(ByVal Id_Cuoc_Hang_Khong As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Bang_Cuoc_Hang_Khong_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myAccounting_Bang_Cuoc_Hang_Khong_Chi_Tiet As New Accounting_Bang_Cuoc_Hang_Khong_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Cuoc_Hang_Khong As SqlParameter = New SqlParameter("@Id_Cuoc_Hang_Khong", SqlDbType.VarChar, 20)
                pId_Cuoc_Hang_Khong.Value = Id_Cuoc_Hang_Khong
                MyCommand.Parameters.Add(pId_Cuoc_Hang_Khong)


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

#Region "Danh_Muc_Chuyen_Bay_Danh_Sach_Ma_San_Bay"

        Public Function Danh_Muc_Chuyen_Bay_Danh_Sach_Ma_San_Bay() As DataSet

            ' The procedure returns these columns:
            ' Ma_San_Bay


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Chuyen_Bay_Danh_Sach_Ma_San_Bay"
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

    End Class
#End Region
End Namespace


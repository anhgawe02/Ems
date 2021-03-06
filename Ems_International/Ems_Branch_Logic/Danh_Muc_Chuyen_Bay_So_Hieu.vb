
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "Danh_Muc_Chuyen_Bay_So_Hieu_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop Danh_Muc_Chuyen_Bay_So_Hieu_Chi_Tiet
    'Tuong ung voi moi truong trong bang Danh_Muc_Chuyen_Bay_So_Hieu trong co so du lieu
    '***********************************************************
    Public Class Danh_Muc_Chuyen_Bay_So_Hieu_Chi_Tiet
        Public Id_So_Hieu As String
        Public So_Hieu As String
        Public Hang_Hang_Khong As String
        Public Nuoc_Xuat_Phat As String
        Public San_Bay_Xuat_Phat As String
        Public Gio_Xuat_Phat As String
        Public Nuoc_Den As String
        Public San_Bay_Den As String
        Public Gio_Den As String
        Public Qua_Ngay As Boolean
        Public Ghi_Chu As String
        Public Quy_Luat As Integer
        Public Thu_2 As Boolean
        Public Thu_3 As Boolean
        Public Thu_4 As Boolean
        Public Thu_5 As Boolean
        Public Thu_6 As Boolean
        Public Thu_7 As Boolean
        Public Chu_Nhat As Boolean
    End Class
#End Region

#Region "Danh_Muc_Chuyen_Bay_So_Hieu"
    Public Class Danh_Muc_Chuyen_Bay_So_Hieu
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "Danh_Muc_Chuyen_Bay_So_Hieu_Cap_Nhat"
        Public Function Danh_Muc_Chuyen_Bay_So_Hieu_Cap_Nhat(ByVal Id_So_Hieu As String, ByVal So_Hieu As String, ByVal Hang_Hang_Khong As String, ByVal Nuoc_Xuat_Phat As String, ByVal San_Bay_Xuat_Phat As String, ByVal Gio_Xuat_Phat As String, ByVal Nuoc_Den As String, ByVal San_Bay_Den As String, ByVal Gio_Den As String, ByVal Qua_Ngay As Boolean, ByVal Ghi_Chu As String, ByVal Quy_Luat As Integer, ByVal Thu_2 As Boolean, ByVal Thu_3 As Boolean, ByVal Thu_4 As Boolean, ByVal Thu_5 As Boolean, ByVal Thu_6 As Boolean, ByVal Thu_7 As Boolean, ByVal Chu_Nhat As Boolean) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Chuyen_Bay_So_Hieu_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDanh_Muc_Chuyen_Bay_So_Hieu_Chi_Tiet As New Danh_Muc_Chuyen_Bay_So_Hieu_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_So_Hieu As SqlParameter = New SqlParameter("@Id_So_Hieu", SqlDbType.VarChar, 30)
                pId_So_Hieu.Value = Id_So_Hieu
                MyCommand.Parameters.Add(pId_So_Hieu)

                Dim pSo_Hieu As SqlParameter = New SqlParameter("@So_Hieu", SqlDbType.VarChar, 6)
                pSo_Hieu.Value = So_Hieu
                MyCommand.Parameters.Add(pSo_Hieu)

                Dim pHang_Hang_Khong As SqlParameter = New SqlParameter("@Hang_Hang_Khong", SqlDbType.VarChar, 20)
                pHang_Hang_Khong.Value = Hang_Hang_Khong
                MyCommand.Parameters.Add(pHang_Hang_Khong)

                Dim pNuoc_Xuat_Phat As SqlParameter = New SqlParameter("@Nuoc_Xuat_Phat", SqlDbType.VarChar, 2)
                pNuoc_Xuat_Phat.Value = Nuoc_Xuat_Phat
                MyCommand.Parameters.Add(pNuoc_Xuat_Phat)

                Dim pSan_Bay_Xuat_Phat As SqlParameter = New SqlParameter("@San_Bay_Xuat_Phat", SqlDbType.VarChar, 10)
                pSan_Bay_Xuat_Phat.Value = San_Bay_Xuat_Phat
                MyCommand.Parameters.Add(pSan_Bay_Xuat_Phat)

                Dim pGio_Xuat_Phat As SqlParameter = New SqlParameter("@Gio_Xuat_Phat", SqlDbType.VarChar, 4)
                pGio_Xuat_Phat.Value = Gio_Xuat_Phat
                MyCommand.Parameters.Add(pGio_Xuat_Phat)

                Dim pNuoc_Den As SqlParameter = New SqlParameter("@Nuoc_Den", SqlDbType.VarChar, 2)
                pNuoc_Den.Value = Nuoc_Den
                MyCommand.Parameters.Add(pNuoc_Den)

                Dim pSan_Bay_Den As SqlParameter = New SqlParameter("@San_Bay_Den", SqlDbType.VarChar, 10)
                pSan_Bay_Den.Value = San_Bay_Den
                MyCommand.Parameters.Add(pSan_Bay_Den)

                Dim pGio_Den As SqlParameter = New SqlParameter("@Gio_Den", SqlDbType.VarChar, 4)
                pGio_Den.Value = Gio_Den
                MyCommand.Parameters.Add(pGio_Den)

                Dim pQua_Ngay As SqlParameter = New SqlParameter("@Qua_Ngay", SqlDbType.Bit, 0)
                pQua_Ngay.Value = Qua_Ngay
                MyCommand.Parameters.Add(pQua_Ngay)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 50)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pQuy_Luat As SqlParameter = New SqlParameter("@Quy_Luat", SqlDbType.Int, 0)
                pQuy_Luat.Value = Quy_Luat
                MyCommand.Parameters.Add(pQuy_Luat)

                Dim pThu_2 As SqlParameter = New SqlParameter("@Thu_2", SqlDbType.Bit, 0)
                pThu_2.Value = Thu_2
                MyCommand.Parameters.Add(pThu_2)

                Dim pThu_3 As SqlParameter = New SqlParameter("@Thu_3", SqlDbType.Bit, 0)
                pThu_3.Value = Thu_3
                MyCommand.Parameters.Add(pThu_3)

                Dim pThu_4 As SqlParameter = New SqlParameter("@Thu_4", SqlDbType.Bit, 0)
                pThu_4.Value = Thu_4
                MyCommand.Parameters.Add(pThu_4)

                Dim pThu_5 As SqlParameter = New SqlParameter("@Thu_5", SqlDbType.Bit, 0)
                pThu_5.Value = Thu_5
                MyCommand.Parameters.Add(pThu_5)

                Dim pThu_6 As SqlParameter = New SqlParameter("@Thu_6", SqlDbType.Bit, 0)
                pThu_6.Value = Thu_6
                MyCommand.Parameters.Add(pThu_6)

                Dim pThu_7 As SqlParameter = New SqlParameter("@Thu_7", SqlDbType.Bit, 0)
                pThu_7.Value = Thu_7
                MyCommand.Parameters.Add(pThu_7)

                Dim pChu_Nhat As SqlParameter = New SqlParameter("@Chu_Nhat", SqlDbType.Bit, 0)
                pChu_Nhat.Value = Chu_Nhat
                MyCommand.Parameters.Add(pChu_Nhat)


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

#Region "Danh_Muc_Chuyen_Bay_So_Hieu_Cap_Nhat_Them"
        Public Function Danh_Muc_Chuyen_Bay_So_Hieu_Cap_Nhat_Them(ByVal Id_So_Hieu As String, ByVal So_Hieu As String, ByVal Hang_Hang_Khong As String, ByVal Nuoc_Xuat_Phat As String, ByVal San_Bay_Xuat_Phat As String, ByVal Gio_Xuat_Phat As String, ByVal Nuoc_Den As String, ByVal San_Bay_Den As String, ByVal Gio_Den As String, ByVal Qua_Ngay As Boolean, ByVal Ghi_Chu As String, ByVal Quy_Luat As Integer, ByVal Thu_2 As Boolean, ByVal Thu_3 As Boolean, ByVal Thu_4 As Boolean, ByVal Thu_5 As Boolean, ByVal Thu_6 As Boolean, ByVal Thu_7 As Boolean, ByVal Chu_Nhat As Boolean) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Chuyen_Bay_So_Hieu_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDanh_Muc_Chuyen_Bay_So_Hieu_Chi_Tiet As New Danh_Muc_Chuyen_Bay_So_Hieu_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_So_Hieu As SqlParameter = New SqlParameter("@Id_So_Hieu", SqlDbType.VarChar, 30)
                pId_So_Hieu.Value = Id_So_Hieu
                MyCommand.Parameters.Add(pId_So_Hieu)

                Dim pSo_Hieu As SqlParameter = New SqlParameter("@So_Hieu", SqlDbType.VarChar, 6)
                pSo_Hieu.Value = So_Hieu
                MyCommand.Parameters.Add(pSo_Hieu)

                Dim pHang_Hang_Khong As SqlParameter = New SqlParameter("@Hang_Hang_Khong", SqlDbType.VarChar, 20)
                pHang_Hang_Khong.Value = Hang_Hang_Khong
                MyCommand.Parameters.Add(pHang_Hang_Khong)

                Dim pNuoc_Xuat_Phat As SqlParameter = New SqlParameter("@Nuoc_Xuat_Phat", SqlDbType.VarChar, 2)
                pNuoc_Xuat_Phat.Value = Nuoc_Xuat_Phat
                MyCommand.Parameters.Add(pNuoc_Xuat_Phat)

                Dim pSan_Bay_Xuat_Phat As SqlParameter = New SqlParameter("@San_Bay_Xuat_Phat", SqlDbType.VarChar, 10)
                pSan_Bay_Xuat_Phat.Value = San_Bay_Xuat_Phat
                MyCommand.Parameters.Add(pSan_Bay_Xuat_Phat)

                Dim pGio_Xuat_Phat As SqlParameter = New SqlParameter("@Gio_Xuat_Phat", SqlDbType.VarChar, 4)
                pGio_Xuat_Phat.Value = Gio_Xuat_Phat
                MyCommand.Parameters.Add(pGio_Xuat_Phat)

                Dim pNuoc_Den As SqlParameter = New SqlParameter("@Nuoc_Den", SqlDbType.VarChar, 2)
                pNuoc_Den.Value = Nuoc_Den
                MyCommand.Parameters.Add(pNuoc_Den)

                Dim pSan_Bay_Den As SqlParameter = New SqlParameter("@San_Bay_Den", SqlDbType.VarChar, 10)
                pSan_Bay_Den.Value = San_Bay_Den
                MyCommand.Parameters.Add(pSan_Bay_Den)

                Dim pGio_Den As SqlParameter = New SqlParameter("@Gio_Den", SqlDbType.VarChar, 4)
                pGio_Den.Value = Gio_Den
                MyCommand.Parameters.Add(pGio_Den)

                Dim pQua_Ngay As SqlParameter = New SqlParameter("@Qua_Ngay", SqlDbType.Bit, 0)
                pQua_Ngay.Value = Qua_Ngay
                MyCommand.Parameters.Add(pQua_Ngay)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 50)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pQuy_Luat As SqlParameter = New SqlParameter("@Quy_Luat", SqlDbType.Int, 0)
                pQuy_Luat.Value = Quy_Luat
                MyCommand.Parameters.Add(pQuy_Luat)

                Dim pThu_2 As SqlParameter = New SqlParameter("@Thu_2", SqlDbType.Bit, 0)
                pThu_2.Value = Thu_2
                MyCommand.Parameters.Add(pThu_2)

                Dim pThu_3 As SqlParameter = New SqlParameter("@Thu_3", SqlDbType.Bit, 0)
                pThu_3.Value = Thu_3
                MyCommand.Parameters.Add(pThu_3)

                Dim pThu_4 As SqlParameter = New SqlParameter("@Thu_4", SqlDbType.Bit, 0)
                pThu_4.Value = Thu_4
                MyCommand.Parameters.Add(pThu_4)

                Dim pThu_5 As SqlParameter = New SqlParameter("@Thu_5", SqlDbType.Bit, 0)
                pThu_5.Value = Thu_5
                MyCommand.Parameters.Add(pThu_5)

                Dim pThu_6 As SqlParameter = New SqlParameter("@Thu_6", SqlDbType.Bit, 0)
                pThu_6.Value = Thu_6
                MyCommand.Parameters.Add(pThu_6)

                Dim pThu_7 As SqlParameter = New SqlParameter("@Thu_7", SqlDbType.Bit, 0)
                pThu_7.Value = Thu_7
                MyCommand.Parameters.Add(pThu_7)

                Dim pChu_Nhat As SqlParameter = New SqlParameter("@Chu_Nhat", SqlDbType.Bit, 0)
                pChu_Nhat.Value = Chu_Nhat
                MyCommand.Parameters.Add(pChu_Nhat)


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


#Region "Danh_Muc_Chuyen_Bay_So_Hieu_Danh_Sach"

        Public Function Danh_Muc_Chuyen_Bay_So_Hieu_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Id_So_Hieu
            ' So_Hieu
            ' Hang_Hang_Khong
            ' Nuoc_Xuat_Phat
            ' San_Bay_Xuat_Phat
            ' Gio_Xuat_Phat
            ' Nuoc_Den
            ' San_Bay_Den
            ' Gio_Den
            ' Qua_Ngay
            ' Ghi_Chu
            ' Quy_Luat
            ' Thu_2
            ' Thu_3
            ' Thu_4
            ' Thu_5
            ' Thu_6
            ' Thu_7
            ' Chu_Nhat


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Chuyen_Bay_So_Hieu_Danh_Sach"
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

#Region "Danh_Muc_Chuyen_Bay_So_Hieu_Lay"
        Public Function Danh_Muc_Chuyen_Bay_So_Hieu_Lay(ByVal Id_So_Hieu As String) As Danh_Muc_Chuyen_Bay_So_Hieu_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Chuyen_Bay_So_Hieu_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDanh_Muc_Chuyen_Bay_So_Hieu_Chi_Tiet As New Danh_Muc_Chuyen_Bay_So_Hieu_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_So_Hieu As SqlParameter = New SqlParameter("@Id_So_Hieu", SqlDbType.VarChar, 30)
                pId_So_Hieu.Value = Id_So_Hieu
                MyCommand.Parameters.Add(pId_So_Hieu)

                Dim pSo_Hieu As SqlParameter = New SqlParameter("@So_Hieu", SqlDbType.VarChar, 6)
                pSo_Hieu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSo_Hieu)

                Dim pHang_Hang_Khong As SqlParameter = New SqlParameter("@Hang_Hang_Khong", SqlDbType.VarChar, 20)
                pHang_Hang_Khong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pHang_Hang_Khong)

                Dim pNuoc_Xuat_Phat As SqlParameter = New SqlParameter("@Nuoc_Xuat_Phat", SqlDbType.VarChar, 2)
                pNuoc_Xuat_Phat.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNuoc_Xuat_Phat)

                Dim pSan_Bay_Xuat_Phat As SqlParameter = New SqlParameter("@San_Bay_Xuat_Phat", SqlDbType.VarChar, 10)
                pSan_Bay_Xuat_Phat.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSan_Bay_Xuat_Phat)

                Dim pGio_Xuat_Phat As SqlParameter = New SqlParameter("@Gio_Xuat_Phat", SqlDbType.VarChar, 4)
                pGio_Xuat_Phat.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Xuat_Phat)

                Dim pNuoc_Den As SqlParameter = New SqlParameter("@Nuoc_Den", SqlDbType.VarChar, 2)
                pNuoc_Den.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNuoc_Den)

                Dim pSan_Bay_Den As SqlParameter = New SqlParameter("@San_Bay_Den", SqlDbType.VarChar, 10)
                pSan_Bay_Den.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSan_Bay_Den)

                Dim pGio_Den As SqlParameter = New SqlParameter("@Gio_Den", SqlDbType.VarChar, 4)
                pGio_Den.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Den)

                Dim pQua_Ngay As SqlParameter = New SqlParameter("@Qua_Ngay", SqlDbType.Bit, 0)
                pQua_Ngay.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pQua_Ngay)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 50)
                pGhi_Chu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pQuy_Luat As SqlParameter = New SqlParameter("@Quy_Luat", SqlDbType.Int, 0)
                pQuy_Luat.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pQuy_Luat)

                Dim pThu_2 As SqlParameter = New SqlParameter("@Thu_2", SqlDbType.Bit, 0)
                pThu_2.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThu_2)

                Dim pThu_3 As SqlParameter = New SqlParameter("@Thu_3", SqlDbType.Bit, 0)
                pThu_3.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThu_3)

                Dim pThu_4 As SqlParameter = New SqlParameter("@Thu_4", SqlDbType.Bit, 0)
                pThu_4.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThu_4)

                Dim pThu_5 As SqlParameter = New SqlParameter("@Thu_5", SqlDbType.Bit, 0)
                pThu_5.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThu_5)

                Dim pThu_6 As SqlParameter = New SqlParameter("@Thu_6", SqlDbType.Bit, 0)
                pThu_6.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThu_6)

                Dim pThu_7 As SqlParameter = New SqlParameter("@Thu_7", SqlDbType.Bit, 0)
                pThu_7.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThu_7)

                Dim pChu_Nhat As SqlParameter = New SqlParameter("@Chu_Nhat", SqlDbType.Bit, 0)
                pChu_Nhat.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pChu_Nhat)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myDanh_Muc_Chuyen_Bay_So_Hieu_Chi_Tiet.Id_So_Hieu = Id_So_Hieu
                myDanh_Muc_Chuyen_Bay_So_Hieu_Chi_Tiet.So_Hieu = pSo_Hieu.Value
                myDanh_Muc_Chuyen_Bay_So_Hieu_Chi_Tiet.Hang_Hang_Khong = pHang_Hang_Khong.Value
                myDanh_Muc_Chuyen_Bay_So_Hieu_Chi_Tiet.Nuoc_Xuat_Phat = pNuoc_Xuat_Phat.Value
                myDanh_Muc_Chuyen_Bay_So_Hieu_Chi_Tiet.San_Bay_Xuat_Phat = pSan_Bay_Xuat_Phat.Value
                myDanh_Muc_Chuyen_Bay_So_Hieu_Chi_Tiet.Gio_Xuat_Phat = pGio_Xuat_Phat.Value
                myDanh_Muc_Chuyen_Bay_So_Hieu_Chi_Tiet.Nuoc_Den = pNuoc_Den.Value
                myDanh_Muc_Chuyen_Bay_So_Hieu_Chi_Tiet.San_Bay_Den = pSan_Bay_Den.Value
                myDanh_Muc_Chuyen_Bay_So_Hieu_Chi_Tiet.Gio_Den = pGio_Den.Value
                myDanh_Muc_Chuyen_Bay_So_Hieu_Chi_Tiet.Qua_Ngay = pQua_Ngay.Value
                myDanh_Muc_Chuyen_Bay_So_Hieu_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value
                myDanh_Muc_Chuyen_Bay_So_Hieu_Chi_Tiet.Quy_Luat = pQuy_Luat.Value
                myDanh_Muc_Chuyen_Bay_So_Hieu_Chi_Tiet.Thu_2 = pThu_2.Value
                myDanh_Muc_Chuyen_Bay_So_Hieu_Chi_Tiet.Thu_3 = pThu_3.Value
                myDanh_Muc_Chuyen_Bay_So_Hieu_Chi_Tiet.Thu_4 = pThu_4.Value
                myDanh_Muc_Chuyen_Bay_So_Hieu_Chi_Tiet.Thu_5 = pThu_5.Value
                myDanh_Muc_Chuyen_Bay_So_Hieu_Chi_Tiet.Thu_6 = pThu_6.Value
                myDanh_Muc_Chuyen_Bay_So_Hieu_Chi_Tiet.Thu_7 = pThu_7.Value
                myDanh_Muc_Chuyen_Bay_So_Hieu_Chi_Tiet.Chu_Nhat = pChu_Nhat.Value

                Return myDanh_Muc_Chuyen_Bay_So_Hieu_Chi_Tiet
                'Return myDanh_Muc_Chuyen_Bay_So_Hieu_Chi_Tiet

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

#Region "Danh_Muc_Chuyen_Bay_So_Hieu_Them"
        Public Function Danh_Muc_Chuyen_Bay_So_Hieu_Them(ByVal Id_So_Hieu As String, ByVal So_Hieu As String, ByVal Hang_Hang_Khong As String, ByVal Nuoc_Xuat_Phat As String, ByVal San_Bay_Xuat_Phat As String, ByVal Gio_Xuat_Phat As String, ByVal Nuoc_Den As String, ByVal San_Bay_Den As String, ByVal Gio_Den As String, ByVal Qua_Ngay As Boolean, ByVal Ghi_Chu As String, ByVal Quy_Luat As Integer, ByVal Thu_2 As Boolean, ByVal Thu_3 As Boolean, ByVal Thu_4 As Boolean, ByVal Thu_5 As Boolean, ByVal Thu_6 As Boolean, ByVal Thu_7 As Boolean, ByVal Chu_Nhat As Boolean) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Chuyen_Bay_So_Hieu_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDanh_Muc_Chuyen_Bay_So_Hieu_Chi_Tiet As New Danh_Muc_Chuyen_Bay_So_Hieu_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_So_Hieu As SqlParameter = New SqlParameter("@Id_So_Hieu", SqlDbType.VarChar, 30)
                pId_So_Hieu.Value = Id_So_Hieu
                MyCommand.Parameters.Add(pId_So_Hieu)

                Dim pSo_Hieu As SqlParameter = New SqlParameter("@So_Hieu", SqlDbType.VarChar, 6)
                pSo_Hieu.Value = So_Hieu
                MyCommand.Parameters.Add(pSo_Hieu)

                Dim pHang_Hang_Khong As SqlParameter = New SqlParameter("@Hang_Hang_Khong", SqlDbType.VarChar, 20)
                pHang_Hang_Khong.Value = Hang_Hang_Khong
                MyCommand.Parameters.Add(pHang_Hang_Khong)

                Dim pNuoc_Xuat_Phat As SqlParameter = New SqlParameter("@Nuoc_Xuat_Phat", SqlDbType.VarChar, 2)
                pNuoc_Xuat_Phat.Value = Nuoc_Xuat_Phat
                MyCommand.Parameters.Add(pNuoc_Xuat_Phat)

                Dim pSan_Bay_Xuat_Phat As SqlParameter = New SqlParameter("@San_Bay_Xuat_Phat", SqlDbType.VarChar, 10)
                pSan_Bay_Xuat_Phat.Value = San_Bay_Xuat_Phat
                MyCommand.Parameters.Add(pSan_Bay_Xuat_Phat)

                Dim pGio_Xuat_Phat As SqlParameter = New SqlParameter("@Gio_Xuat_Phat", SqlDbType.VarChar, 4)
                pGio_Xuat_Phat.Value = Gio_Xuat_Phat
                MyCommand.Parameters.Add(pGio_Xuat_Phat)

                Dim pNuoc_Den As SqlParameter = New SqlParameter("@Nuoc_Den", SqlDbType.VarChar, 2)
                pNuoc_Den.Value = Nuoc_Den
                MyCommand.Parameters.Add(pNuoc_Den)

                Dim pSan_Bay_Den As SqlParameter = New SqlParameter("@San_Bay_Den", SqlDbType.VarChar, 10)
                pSan_Bay_Den.Value = San_Bay_Den
                MyCommand.Parameters.Add(pSan_Bay_Den)

                Dim pGio_Den As SqlParameter = New SqlParameter("@Gio_Den", SqlDbType.VarChar, 4)
                pGio_Den.Value = Gio_Den
                MyCommand.Parameters.Add(pGio_Den)

                Dim pQua_Ngay As SqlParameter = New SqlParameter("@Qua_Ngay", SqlDbType.Bit, 0)
                pQua_Ngay.Value = Qua_Ngay
                MyCommand.Parameters.Add(pQua_Ngay)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 50)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pQuy_Luat As SqlParameter = New SqlParameter("@Quy_Luat", SqlDbType.Int, 0)
                pQuy_Luat.Value = Quy_Luat
                MyCommand.Parameters.Add(pQuy_Luat)

                Dim pThu_2 As SqlParameter = New SqlParameter("@Thu_2", SqlDbType.Bit, 0)
                pThu_2.Value = Thu_2
                MyCommand.Parameters.Add(pThu_2)

                Dim pThu_3 As SqlParameter = New SqlParameter("@Thu_3", SqlDbType.Bit, 0)
                pThu_3.Value = Thu_3
                MyCommand.Parameters.Add(pThu_3)

                Dim pThu_4 As SqlParameter = New SqlParameter("@Thu_4", SqlDbType.Bit, 0)
                pThu_4.Value = Thu_4
                MyCommand.Parameters.Add(pThu_4)

                Dim pThu_5 As SqlParameter = New SqlParameter("@Thu_5", SqlDbType.Bit, 0)
                pThu_5.Value = Thu_5
                MyCommand.Parameters.Add(pThu_5)

                Dim pThu_6 As SqlParameter = New SqlParameter("@Thu_6", SqlDbType.Bit, 0)
                pThu_6.Value = Thu_6
                MyCommand.Parameters.Add(pThu_6)

                Dim pThu_7 As SqlParameter = New SqlParameter("@Thu_7", SqlDbType.Bit, 0)
                pThu_7.Value = Thu_7
                MyCommand.Parameters.Add(pThu_7)

                Dim pChu_Nhat As SqlParameter = New SqlParameter("@Chu_Nhat", SqlDbType.Bit, 0)
                pChu_Nhat.Value = Chu_Nhat
                MyCommand.Parameters.Add(pChu_Nhat)


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

#Region "Danh_Muc_Chuyen_Bay_So_Hieu_Xoa"
        Public Function Danh_Muc_Chuyen_Bay_So_Hieu_Xoa(ByVal Id_So_Hieu As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Chuyen_Bay_So_Hieu_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDanh_Muc_Chuyen_Bay_So_Hieu_Chi_Tiet As New Danh_Muc_Chuyen_Bay_So_Hieu_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_So_Hieu As SqlParameter = New SqlParameter("@Id_So_Hieu", SqlDbType.VarChar, 30)
                pId_So_Hieu.Value = Id_So_Hieu
                MyCommand.Parameters.Add(pId_So_Hieu)


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

#Region "Danh_Muc_Chuyen_Bay_So_Hieu_Lay_Danh_Sach_San_Bay"

        Public Function Danh_Muc_Chuyen_Bay_So_Hieu_Lay_Danh_Sach_San_Bay() As DataSet

            ' The procedure returns these columns:
            ' Ma_Nuoc
            ' Ma_San_Bay


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Chuyen_Bay_So_Hieu_Lay_Danh_Sach_San_Bay"
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

#Region "Danh_Muc_Chuyen_Bay_So_Hieu_Lay_Ma_Nuoc_Theo_Ma_San_Bay"

        Public Function Danh_Muc_Chuyen_Bay_So_Hieu_Lay_Ma_Nuoc_Theo_Ma_San_Bay(ByVal ma_San_Bay As String) As DataSet

            ' The procedure returns these columns:
            ' Ma_Nuoc


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Chuyen_Bay_So_Hieu_Lay_Ma_Nuoc_Theo_Ma_San_Bay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Ma_San_Bay", SqlDbType.VarChar, 3, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, ma_San_Bay))

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

#Region "Danh_Muc_Chuyen_Bay_So_Hieu_Cap_Nhat_Id_So_Hieu_Moi"
        Public Function Danh_Muc_Chuyen_Bay_So_Hieu_Cap_Nhat_Id_So_Hieu_Moi(ByVal id_So_Hieu_Moi As String, ByVal id_So_Hieu As String, ByVal so_Hieu As String, ByVal hang_Hang_Khong As String, ByVal nuoc_Xuat_Phat As String, ByVal san_Bay_Xuat_Phat As String, ByVal gio_Xuat_Phat As String, ByVal nuoc_Den As String, ByVal san_Bay_Den As String, ByVal gio_Den As String, ByVal qua_Ngay As Boolean, ByVal ghi_Chu As String, ByVal quy_Luat As Integer, ByVal thu_2 As Boolean, ByVal thu_3 As Boolean, ByVal thu_4 As Boolean, ByVal thu_5 As Boolean, ByVal thu_6 As Boolean, ByVal thu_7 As Boolean, ByVal chu_Nhat As Boolean) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Chuyen_Bay_So_Hieu_Cap_Nhat_Id_So_Hieu_Moi"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_So_Hieu_Moi", SqlDbType.VarChar, 30, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_So_Hieu_Moi))
                MyCommand.Parameters.Add(New SqlParameter("@Id_So_Hieu", SqlDbType.VarChar, 30, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_So_Hieu))
                MyCommand.Parameters.Add(New SqlParameter("@So_Hieu", SqlDbType.VarChar, 6, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, so_Hieu))
                MyCommand.Parameters.Add(New SqlParameter("@Hang_Hang_Khong", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, hang_Hang_Khong))
                MyCommand.Parameters.Add(New SqlParameter("@Nuoc_Xuat_Phat", SqlDbType.VarChar, 2, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, nuoc_Xuat_Phat))
                MyCommand.Parameters.Add(New SqlParameter("@San_Bay_Xuat_Phat", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, san_Bay_Xuat_Phat))
                MyCommand.Parameters.Add(New SqlParameter("@Gio_Xuat_Phat", SqlDbType.VarChar, 4, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, gio_Xuat_Phat))
                MyCommand.Parameters.Add(New SqlParameter("@Nuoc_Den", SqlDbType.VarChar, 2, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, nuoc_Den))
                MyCommand.Parameters.Add(New SqlParameter("@San_Bay_Den", SqlDbType.VarChar, 10, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, san_Bay_Den))
                MyCommand.Parameters.Add(New SqlParameter("@Gio_Den", SqlDbType.VarChar, 4, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, gio_Den))
                MyCommand.Parameters.Add(New SqlParameter("@Qua_Ngay", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, qua_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 50, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, ghi_Chu))
                MyCommand.Parameters.Add(New SqlParameter("@Quy_Luat", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, quy_Luat))
                MyCommand.Parameters.Add(New SqlParameter("@Thu_2", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, thu_2))
                MyCommand.Parameters.Add(New SqlParameter("@Thu_3", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, thu_3))
                MyCommand.Parameters.Add(New SqlParameter("@Thu_4", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, thu_4))
                MyCommand.Parameters.Add(New SqlParameter("@Thu_5", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, thu_5))
                MyCommand.Parameters.Add(New SqlParameter("@Thu_6", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, thu_6))
                MyCommand.Parameters.Add(New SqlParameter("@Thu_7", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, thu_7))
                MyCommand.Parameters.Add(New SqlParameter("@Chu_Nhat", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, chu_Nhat))

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

    End Class
#End Region
End Namespace


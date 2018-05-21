
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "Accounting_Cuoc_Hang_Khong_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop Accounting_Cuoc_Hang_Khong_Chi_Tiet
    'Tuong ung voi moi truong trong bang Accounting_Cuoc_Hang_Khong trong co so du lieu
    '***********************************************************
    Public Class Accounting_Cuoc_Hang_Khong_Chi_Tiet
        Public Id As Integer
        Public Id_Duong_Thu As String
        Public Id_Chuyen_Thu As String
        Public Ngay_Dong As Integer
        Public Ngay_Bay As Integer
        Public So_Chuyen_Thu As Integer
        Public Loai_Chuyen_Thu As String
        Public HVC As String
        Public Nuoc_Xuat_Phat As String
        Public Nuoc_Den As String
        Public San_Bay_Xuat_Phat As String
        Public San_Bay_Den As String
        Public Tong_So_Tui As Integer
        Public Khoi_Luong_Tui_Rong As Integer
        Public Khoi_Luong_EMS As Integer
        Public Tong_Khoi_Luong As Integer
        Public Don_Gia_Cuoc_Tui_Rong As Double
        Public Don_Gia_Cuoc As Double
        Public Tong_Cuoc As Double
        Public Phan_Loai As Integer
        Public Ngay_He_Thong As Integer
        Public Gio_He_Thong As Integer
        Public Id_Nguoi_Dung As Integer
        Public Chot_SL As Boolean
    End Class
#End Region

#Region "Accounting_Cuoc_Hang_Khong"
    Public Class Accounting_Cuoc_Hang_Khong
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub


#Region "Accounting_Cuoc_Hang_Khong_Danh_Sach"

        Public Function Accounting_Cuoc_Hang_Khong_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Id
            ' Id_Duong_Thu
            ' Id_Chuyen_Thu
            ' Ngay_Dong
            ' So_Chuyen_Thu
            ' Loai_Chuyen_Thu
            ' HVC
            ' Nuoc_Xuat_Phat
            ' Nuoc_Den
            ' San_Bay_Xuat_Phat
            ' San_Bay_Den
            ' Tong_So_Tui
            ' Khoi_Luong_Tui_Rong
            ' Khoi_Luong_EMS
            ' Tong_Khoi_Luong
            ' Don_Gia_Cuoc
            ' Tong_Cuoc
            ' Phan_Loai
            ' Ngay_He_Thong
            ' Gio_He_Thong
            ' Id_Nguoi_Dung
            ' Chot_SL


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Cuoc_Hang_Khong_Danh_Sach"
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

#Region "Accounting_Cuoc_Hang_Khong_Danh_Sach_Tu_Ngay_Den_Ngay"

        Public Function Accounting_Cuoc_Hang_Khong_Danh_Sach_Tu_Ngay_Den_Ngay(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer) As DataSet

            ' The procedure returns these columns:
            ' Id
            ' Id_Duong_Thu
            ' Id_Chuyen_Thu
            ' Ngay_Dong
            ' Ngay_Bay
            ' So_Chuyen_Thu
            ' Loai_Chuyen_Thu
            ' HVC
            ' Nuoc_Xuat_Phat
            ' Nuoc_Den
            ' San_Bay_Xuat_Phat
            ' San_Bay_Den
            ' Tong_So_Tui
            ' Khoi_Luong_Tui_Rong
            ' Khoi_Luong_EMS
            ' Tong_Khoi_Luong
            ' Don_Gia_Cuoc
            ' Tong_Cuoc
            ' Phan_Loai
            ' Ngay_He_Thong
            ' Gio_He_Thong
            ' Id_Nguoi_Dung
            ' Chot_SL


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Cuoc_Hang_Khong_Danh_Sach_Tu_Ngay_Den_Ngay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0)
                pTu_Ngay.Value = Tu_Ngay
                MyCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 0)
                pDen_Ngay.Value = Den_Ngay
                MyCommand.Parameters.Add(pDen_Ngay)


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

#Region "Accounting_Cuoc_Hang_Khong_Lay"
        Public Function Accounting_Cuoc_Hang_Khong_Lay(ByVal Id As Integer) As Accounting_Cuoc_Hang_Khong_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Cuoc_Hang_Khong_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myAccounting_Cuoc_Hang_Khong_Chi_Tiet As New Accounting_Cuoc_Hang_Khong_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId As SqlParameter = New SqlParameter("@Id", SqlDbType.Int, 0)
                pId.Value = Id
                MyCommand.Parameters.Add(pId)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 0)
                pNgay_Dong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Dong)

                Dim pNgay_Bay As SqlParameter = New SqlParameter("@Ngay_Bay", SqlDbType.Int, 0)
                pNgay_Bay.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Bay)

                Dim pSo_Chuyen_Thu As SqlParameter = New SqlParameter("@So_Chuyen_Thu", SqlDbType.Int, 0)
                pSo_Chuyen_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSo_Chuyen_Thu)

                Dim pLoai_Chuyen_Thu As SqlParameter = New SqlParameter("@Loai_Chuyen_Thu", SqlDbType.VarChar, 2)
                pLoai_Chuyen_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pLoai_Chuyen_Thu)

                Dim pHVC As SqlParameter = New SqlParameter("@HVC", SqlDbType.VarChar, 50)
                pHVC.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pHVC)

                Dim pNuoc_Xuat_Phat As SqlParameter = New SqlParameter("@Nuoc_Xuat_Phat", SqlDbType.VarChar, 2)
                pNuoc_Xuat_Phat.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNuoc_Xuat_Phat)

                Dim pNuoc_Den As SqlParameter = New SqlParameter("@Nuoc_Den", SqlDbType.VarChar, 2)
                pNuoc_Den.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNuoc_Den)

                Dim pSan_Bay_Xuat_Phat As SqlParameter = New SqlParameter("@San_Bay_Xuat_Phat", SqlDbType.VarChar, 50)
                pSan_Bay_Xuat_Phat.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSan_Bay_Xuat_Phat)

                Dim pSan_Bay_Den As SqlParameter = New SqlParameter("@San_Bay_Den", SqlDbType.VarChar, 50)
                pSan_Bay_Den.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSan_Bay_Den)

                Dim pTong_So_Tui As SqlParameter = New SqlParameter("@Tong_So_Tui", SqlDbType.Int, 0)
                pTong_So_Tui.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTong_So_Tui)

                Dim pKhoi_Luong_Tui_Rong As SqlParameter = New SqlParameter("@Khoi_Luong_Tui_Rong", SqlDbType.Int, 0)
                pKhoi_Luong_Tui_Rong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pKhoi_Luong_Tui_Rong)

                Dim pKhoi_Luong_EMS As SqlParameter = New SqlParameter("@Khoi_Luong_EMS", SqlDbType.Int, 0)
                pKhoi_Luong_EMS.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pKhoi_Luong_EMS)

                Dim pTong_Khoi_Luong As SqlParameter = New SqlParameter("@Tong_Khoi_Luong", SqlDbType.Int, 0)
                pTong_Khoi_Luong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTong_Khoi_Luong)

                Dim pDon_Gia_Cuoc_Tui_Rong As SqlParameter = New SqlParameter("@Don_Gia_Cuoc_Tui_Rong", SqlDbType.Float, 0)
                pDon_Gia_Cuoc_Tui_Rong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDon_Gia_Cuoc_Tui_Rong)

                Dim pDon_Gia_Cuoc As SqlParameter = New SqlParameter("@Don_Gia_Cuoc", SqlDbType.Float, 0)
                pDon_Gia_Cuoc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDon_Gia_Cuoc)

                Dim pTong_Cuoc As SqlParameter = New SqlParameter("@Tong_Cuoc", SqlDbType.Float, 0)
                pTong_Cuoc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTong_Cuoc)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.Int, 0)
                pPhan_Loai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_He_Thong)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0)
                pId_Nguoi_Dung.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 0)
                pChot_SL.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pChot_SL)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myAccounting_Cuoc_Hang_Khong_Chi_Tiet.Id = Id
                myAccounting_Cuoc_Hang_Khong_Chi_Tiet.Id_Duong_Thu = pId_Duong_Thu.Value
                myAccounting_Cuoc_Hang_Khong_Chi_Tiet.Id_Chuyen_Thu = pId_Chuyen_Thu.Value
                myAccounting_Cuoc_Hang_Khong_Chi_Tiet.Ngay_Dong = pNgay_Dong.Value
                myAccounting_Cuoc_Hang_Khong_Chi_Tiet.Ngay_Bay = pNgay_Bay.Value
                myAccounting_Cuoc_Hang_Khong_Chi_Tiet.So_Chuyen_Thu = pSo_Chuyen_Thu.Value
                myAccounting_Cuoc_Hang_Khong_Chi_Tiet.Loai_Chuyen_Thu = pLoai_Chuyen_Thu.Value
                myAccounting_Cuoc_Hang_Khong_Chi_Tiet.HVC = pHVC.Value
                myAccounting_Cuoc_Hang_Khong_Chi_Tiet.Nuoc_Xuat_Phat = pNuoc_Xuat_Phat.Value
                myAccounting_Cuoc_Hang_Khong_Chi_Tiet.Nuoc_Den = pNuoc_Den.Value
                myAccounting_Cuoc_Hang_Khong_Chi_Tiet.San_Bay_Xuat_Phat = pSan_Bay_Xuat_Phat.Value
                myAccounting_Cuoc_Hang_Khong_Chi_Tiet.San_Bay_Den = pSan_Bay_Den.Value
                myAccounting_Cuoc_Hang_Khong_Chi_Tiet.Tong_So_Tui = pTong_So_Tui.Value
                myAccounting_Cuoc_Hang_Khong_Chi_Tiet.Khoi_Luong_Tui_Rong = pKhoi_Luong_Tui_Rong.Value
                myAccounting_Cuoc_Hang_Khong_Chi_Tiet.Khoi_Luong_EMS = pKhoi_Luong_EMS.Value
                myAccounting_Cuoc_Hang_Khong_Chi_Tiet.Tong_Khoi_Luong = pTong_Khoi_Luong.Value
                myAccounting_Cuoc_Hang_Khong_Chi_Tiet.Don_Gia_Cuoc_Tui_Rong = pDon_Gia_Cuoc_Tui_Rong.Value
                myAccounting_Cuoc_Hang_Khong_Chi_Tiet.Don_Gia_Cuoc = pDon_Gia_Cuoc.Value
                myAccounting_Cuoc_Hang_Khong_Chi_Tiet.Tong_Cuoc = pTong_Cuoc.Value
                myAccounting_Cuoc_Hang_Khong_Chi_Tiet.Phan_Loai = pPhan_Loai.Value
                myAccounting_Cuoc_Hang_Khong_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myAccounting_Cuoc_Hang_Khong_Chi_Tiet.Gio_He_Thong = pGio_He_Thong.Value
                myAccounting_Cuoc_Hang_Khong_Chi_Tiet.Id_Nguoi_Dung = pId_Nguoi_Dung.Value
                myAccounting_Cuoc_Hang_Khong_Chi_Tiet.Chot_SL = pChot_SL.Value

                Return myAccounting_Cuoc_Hang_Khong_Chi_Tiet
                'Return myAccounting_Cuoc_Hang_Khong_Chi_Tiet

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

#Region "Accounting_Cuoc_Hang_Khong_Them"
        Public Function Accounting_Cuoc_Hang_Khong_Them(ByVal Id_Duong_Thu As String, ByVal Id_Chuyen_Thu As String, ByVal Ngay_Dong As Integer, ByVal Ngay_Bay As Integer, ByVal So_Chuyen_Thu As Integer, ByVal Loai_Chuyen_Thu As String, ByVal HVC As String, ByVal Nuoc_Xuat_Phat As String, ByVal Nuoc_Den As String, ByVal San_Bay_Xuat_Phat As String, ByVal San_Bay_Den As String, ByVal Tong_So_Tui As Integer, ByVal Khoi_Luong_Tui_Rong As Integer, ByVal Khoi_Luong_EMS As Integer, ByVal Tong_Khoi_Luong As Integer, ByVal Don_Gia_Cuoc_Tui_Rong As Double, ByVal Don_Gia_Cuoc As Double, ByVal Tong_Cuoc As Double, ByVal Phan_Loai As Integer, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Chot_SL As Boolean) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Cuoc_Hang_Khong_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myAccounting_Cuoc_Hang_Khong_Chi_Tiet As New Accounting_Cuoc_Hang_Khong_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                MyCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 0)
                pNgay_Dong.Value = Ngay_Dong
                MyCommand.Parameters.Add(pNgay_Dong)

                Dim pNgay_Bay As SqlParameter = New SqlParameter("@Ngay_Bay", SqlDbType.Int, 0)
                pNgay_Bay.Value = Ngay_Bay
                MyCommand.Parameters.Add(pNgay_Bay)

                Dim pSo_Chuyen_Thu As SqlParameter = New SqlParameter("@So_Chuyen_Thu", SqlDbType.Int, 0)
                pSo_Chuyen_Thu.Value = So_Chuyen_Thu
                MyCommand.Parameters.Add(pSo_Chuyen_Thu)

                Dim pLoai_Chuyen_Thu As SqlParameter = New SqlParameter("@Loai_Chuyen_Thu", SqlDbType.VarChar, 2)
                pLoai_Chuyen_Thu.Value = Loai_Chuyen_Thu
                MyCommand.Parameters.Add(pLoai_Chuyen_Thu)

                Dim pHVC As SqlParameter = New SqlParameter("@HVC", SqlDbType.VarChar, 50)
                pHVC.Value = HVC
                MyCommand.Parameters.Add(pHVC)

                Dim pNuoc_Xuat_Phat As SqlParameter = New SqlParameter("@Nuoc_Xuat_Phat", SqlDbType.VarChar, 2)
                pNuoc_Xuat_Phat.Value = Nuoc_Xuat_Phat
                MyCommand.Parameters.Add(pNuoc_Xuat_Phat)

                Dim pNuoc_Den As SqlParameter = New SqlParameter("@Nuoc_Den", SqlDbType.VarChar, 2)
                pNuoc_Den.Value = Nuoc_Den
                MyCommand.Parameters.Add(pNuoc_Den)

                Dim pSan_Bay_Xuat_Phat As SqlParameter = New SqlParameter("@San_Bay_Xuat_Phat", SqlDbType.VarChar, 50)
                pSan_Bay_Xuat_Phat.Value = San_Bay_Xuat_Phat
                MyCommand.Parameters.Add(pSan_Bay_Xuat_Phat)

                Dim pSan_Bay_Den As SqlParameter = New SqlParameter("@San_Bay_Den", SqlDbType.VarChar, 50)
                pSan_Bay_Den.Value = San_Bay_Den
                MyCommand.Parameters.Add(pSan_Bay_Den)

                Dim pTong_So_Tui As SqlParameter = New SqlParameter("@Tong_So_Tui", SqlDbType.Int, 0)
                pTong_So_Tui.Value = Tong_So_Tui
                MyCommand.Parameters.Add(pTong_So_Tui)

                Dim pKhoi_Luong_Tui_Rong As SqlParameter = New SqlParameter("@Khoi_Luong_Tui_Rong", SqlDbType.Int, 0)
                pKhoi_Luong_Tui_Rong.Value = Khoi_Luong_Tui_Rong
                MyCommand.Parameters.Add(pKhoi_Luong_Tui_Rong)

                Dim pKhoi_Luong_EMS As SqlParameter = New SqlParameter("@Khoi_Luong_EMS", SqlDbType.Int, 0)
                pKhoi_Luong_EMS.Value = Khoi_Luong_EMS
                MyCommand.Parameters.Add(pKhoi_Luong_EMS)

                Dim pTong_Khoi_Luong As SqlParameter = New SqlParameter("@Tong_Khoi_Luong", SqlDbType.Int, 0)
                pTong_Khoi_Luong.Value = Tong_Khoi_Luong
                MyCommand.Parameters.Add(pTong_Khoi_Luong)

                Dim pDon_Gia_Cuoc_Tui_Rong As SqlParameter = New SqlParameter("@Don_Gia_Cuoc_Tui_Rong", SqlDbType.Float, 0)
                pDon_Gia_Cuoc_Tui_Rong.Value = Don_Gia_Cuoc_Tui_Rong
                MyCommand.Parameters.Add(pDon_Gia_Cuoc_Tui_Rong)

                Dim pDon_Gia_Cuoc As SqlParameter = New SqlParameter("@Don_Gia_Cuoc", SqlDbType.Float, 0)
                pDon_Gia_Cuoc.Value = Don_Gia_Cuoc
                MyCommand.Parameters.Add(pDon_Gia_Cuoc)

                Dim pTong_Cuoc As SqlParameter = New SqlParameter("@Tong_Cuoc", SqlDbType.Float, 0)
                pTong_Cuoc.Value = Tong_Cuoc
                MyCommand.Parameters.Add(pTong_Cuoc)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.Int, 0)
                pPhan_Loai.Value = Phan_Loai
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Value = Ngay_He_Thong
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Value = Gio_He_Thong
                MyCommand.Parameters.Add(pGio_He_Thong)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                MyCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 0)
                pChot_SL.Value = Chot_SL
                MyCommand.Parameters.Add(pChot_SL)

                Dim pId As SqlParameter = New SqlParameter("@Id", SqlDbType.Int, 0)
                pId.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId)


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

#Region "Accounting_Cuoc_Hang_Khong_Xoa"
        Public Function Accounting_Cuoc_Hang_Khong_Xoa(ByVal Id As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Cuoc_Hang_Khong_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myAccounting_Cuoc_Hang_Khong_Chi_Tiet As New Accounting_Cuoc_Hang_Khong_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId As SqlParameter = New SqlParameter("@Id", SqlDbType.Int, 0)
                pId.Value = Id
                MyCommand.Parameters.Add(pId)


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

#Region "Accounting_Cuoc_Hang_Khong_Xoa_Boi_Tu_Ngay_Den_Ngay"
        Public Function Accounting_Cuoc_Hang_Khong_Xoa_Boi_Tu_Ngay_Den_Ngay(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Cuoc_Hang_Khong_Xoa_Boi_Tu_Ngay_Den_Ngay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myAccounting_Cuoc_Hang_Khong_Chi_Tiet As New Accounting_Cuoc_Hang_Khong_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0)
                pTu_Ngay.Value = Tu_Ngay
                MyCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 0)
                pDen_Ngay.Value = Den_Ngay
                MyCommand.Parameters.Add(pDen_Ngay)


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

#Region "Accounting_Cuoc_Hang_Khong_Danh_Sach_Da_Chot_SL_Tu_Ngay_Den_Ngay"

        Public Function Accounting_Cuoc_Hang_Khong_Danh_Sach_Da_Chot_SL_Tu_Ngay_Den_Ngay(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer) As DataSet

            ' The procedure returns these columns:
            ' Id
            ' Id_Duong_Thu
            ' Id_Chuyen_Thu
            ' Ngay_Dong
            ' So_Chuyen_Thu
            ' Loai_Chuyen_Thu
            ' HVC
            ' Nuoc_Xuat_Phat
            ' Nuoc_Den
            ' San_Bay_Xuat_Phat
            ' San_Bay_Den
            ' Tong_So_Tui
            ' Khoi_Luong_Tui_Rong
            ' Khoi_Luong_EMS
            ' Tong_Khoi_Luong
            ' Don_Gia_Cuoc
            ' Tong_Cuoc
            ' Phan_Loai
            ' Ngay_He_Thong
            ' Gio_He_Thong
            ' Id_Nguoi_Dung
            ' Chot_SL


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Cuoc_Hang_Khong_Danh_Sach_Da_Chot_SL_Tu_Ngay_Den_Ngay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0)
                pTu_Ngay.Value = Tu_Ngay
                MyCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 0)
                pDen_Ngay.Value = Den_Ngay
                MyCommand.Parameters.Add(pDen_Ngay)


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

#Region "Accounting_Cuoc_Hang_Khong_Cap_Nhat_Khoa_SL_Tu_Ngay_Den_Ngay"
        Public Function Accounting_Cuoc_Hang_Khong_Cap_Nhat_Khoa_SL_Tu_Ngay_Den_Ngay(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal Chot_SL As Boolean) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Cuoc_Hang_Khong_Cap_Nhat_Khoa_SL_Tu_Ngay_Den_Ngay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myAccounting_Cuoc_Hang_Khong_Chi_Tiet As New Accounting_Cuoc_Hang_Khong_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0)
                pTu_Ngay.Value = Tu_Ngay
                MyCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 0)
                pDen_Ngay.Value = Den_Ngay
                MyCommand.Parameters.Add(pDen_Ngay)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 0)
                pChot_SL.Value = Chot_SL
                MyCommand.Parameters.Add(pChot_SL)


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

#Region "Accounting_Cuoc_Hang_Khong_Ban_Ke_Tong_Hop_QT_Theo_HVC_Tu_Ngay_Den_Ngay"

        Public Function Accounting_Cuoc_Hang_Khong_Ban_Ke_Tong_Hop_QT_Theo_HVC_Tu_Ngay_Den_Ngay(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal HVC As String) As DataSet

            ' The procedure returns these columns:
            ' Hanh_Trinh
            ' Tong_So_Tui
            ' Trong_Luong
            ' Don_Gia
            ' Tong_Tien


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Cuoc_Hang_Khong_Ban_Ke_Tong_Hop_QT_Theo_HVC_Tu_Ngay_Den_Ngay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0)
                pTu_Ngay.Value = Tu_Ngay
                MyCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 0)
                pDen_Ngay.Value = Den_Ngay
                MyCommand.Parameters.Add(pDen_Ngay)

                Dim pHVC As SqlParameter = New SqlParameter("@HVC", SqlDbType.VarChar, 50)
                pHVC.Value = HVC
                MyCommand.Parameters.Add(pHVC)


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

#Region "Accounting_Cuoc_Hang_Khong_Ban_Ke_Chi_Tiet_QT_Theo_HVC_Tu_Ngay_Den_Ngay"

        Public Function Accounting_Cuoc_Hang_Khong_Ban_Ke_Chi_Tiet_QT_Theo_HVC_Tu_Ngay_Den_Ngay(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal HVC As String) As DataSet

            ' The procedure returns these columns:
            ' Buu_Cuc_Gui
            ' Buu_Cuc_Nhan
            ' Ngay_Dong
            ' Ngay_Bay
            ' So_Chuyen_Thu
            ' Loai_Chuyen_Thu
            ' Tong_So_Tui
            ' KL_Tui_Rong
            ' KL_EMS
            ' Tong_KL


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Cuoc_Hang_Khong_Ban_Ke_Chi_Tiet_QT_Theo_HVC_Tu_Ngay_Den_Ngay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0)
                pTu_Ngay.Value = Tu_Ngay
                MyCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 0)
                pDen_Ngay.Value = Den_Ngay
                MyCommand.Parameters.Add(pDen_Ngay)

                Dim pHVC As SqlParameter = New SqlParameter("@HVC", SqlDbType.VarChar, 50)
                pHVC.Value = HVC
                MyCommand.Parameters.Add(pHVC)


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

#Region "Accounting_Cuoc_Hang_Khong_Ban_Ke_Chi_Tiet_QT_Theo_HVC_Tu_Ngay_Den_Ngay_Xuat_Excel"

        Public Function Accounting_Cuoc_Hang_Khong_Ban_Ke_Chi_Tiet_QT_Theo_HVC_Tu_Ngay_Den_Ngay_Xuat_Excel(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal HVC As String) As DataSet

            ' The procedure returns these columns:
            ' Buu_Cuc_Gui
            ' Buu_Cuc_Nhan
            ' Ngay_Dong
            ' Ngay_Bay
            ' So_Chuyen_Thu
            ' Loai_Chuyen_Thu
            ' Tong_So_Tui
            ' KL_Tui_Rong
            ' KL_EMS
            ' Tong_KL


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Cuoc_Hang_Khong_Ban_Ke_Chi_Tiet_QT_Theo_HVC_Tu_Ngay_Den_Ngay_Xuat_Excel"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0)
                pTu_Ngay.Value = Tu_Ngay
                MyCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 0)
                pDen_Ngay.Value = Den_Ngay
                MyCommand.Parameters.Add(pDen_Ngay)

                Dim pHVC As SqlParameter = New SqlParameter("@HVC", SqlDbType.VarChar, 50)
                pHVC.Value = HVC
                MyCommand.Parameters.Add(pHVC)


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

    End Class
#End Region
End Namespace


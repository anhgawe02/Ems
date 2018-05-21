
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet
    'Tuong ung voi moi truong trong bang DSQT_Thong_Tin_Ke_Toan_Ca trong co so du lieu
    '***********************************************************
    Public Class DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet
        Public Id_Ke_Toan As String
        Public Id_Ca As String
        Public Ma_Trang_Thai As Integer
        Public STT As Integer
        Public Ma_Bc_Khai_Thac As Integer
        Public Ngay_Khai_Thac As Integer
        Public Ca_Khai_Thac As Integer
        Public Tong_So_Chuyen_Thu As Integer
        Public Tong_So_E2 As Integer
        Public Tong_So_BP_D As Integer
        Public Tong_So_BP_M As Integer
        Public Khoi_Luong_BP_D As Integer
        Public Khoi_Luong_BP_M As Integer
        Public Chi_Tiet_Trang_Thai As String
        Public Ngay_He_Thong As Integer
        Public Gio_He_Thong As Integer
        Public Id_Nguoi_Dung As Integer
        Public Ghi_Chu As String
        Public Chot_SL As Boolean
    End Class
#End Region

#Region "DSQT_Thong_Tin_Ke_Toan_Ca"
    Public Class DSQT_Thong_Tin_Ke_Toan_Ca
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "DSQT_Thong_Tin_Ke_Toan_Ca_Cap_Nhat"
        Public Function DSQT_Thong_Tin_Ke_Toan_Ca_Cap_Nhat(ByVal Id_Ke_Toan As String, ByVal Id_Ca As String, ByVal Ma_Trang_Thai As Integer, ByVal STT As Integer, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ngay_Khai_Thac As Integer, ByVal Ca_Khai_Thac As Integer, ByVal Tong_So_Chuyen_Thu As Integer, ByVal Tong_So_E2 As Integer, ByVal Tong_So_BP_D As Integer, ByVal Tong_So_BP_M As Integer, ByVal Khoi_Luong_BP_D As Integer, ByVal Khoi_Luong_BP_M As Integer, ByVal Chi_Tiet_Trang_Thai As String, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Ghi_Chu As String, ByVal Chot_SL As Boolean) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Thong_Tin_Ke_Toan_Ca_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet As New DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Ke_Toan As SqlParameter = New SqlParameter("@Id_Ke_Toan", SqlDbType.VarChar, 25)
                pId_Ke_Toan.Value = Id_Ke_Toan
                MyCommand.Parameters.Add(pId_Ke_Toan)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                MyCommand.Parameters.Add(pId_Ca)

                Dim pMa_Trang_Thai As SqlParameter = New SqlParameter("@Ma_Trang_Thai", SqlDbType.Int, 0)
                pMa_Trang_Thai.Value = Ma_Trang_Thai
                MyCommand.Parameters.Add(pMa_Trang_Thai)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Value = STT
                MyCommand.Parameters.Add(pSTT)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pNgay_Khai_Thac As SqlParameter = New SqlParameter("@Ngay_Khai_Thac", SqlDbType.Int, 0)
                pNgay_Khai_Thac.Value = Ngay_Khai_Thac
                MyCommand.Parameters.Add(pNgay_Khai_Thac)

                Dim pCa_Khai_Thac As SqlParameter = New SqlParameter("@Ca_Khai_Thac", SqlDbType.Int, 0)
                pCa_Khai_Thac.Value = Ca_Khai_Thac
                MyCommand.Parameters.Add(pCa_Khai_Thac)

                Dim pTong_So_Chuyen_Thu As SqlParameter = New SqlParameter("@Tong_So_Chuyen_Thu", SqlDbType.Int, 0)
                pTong_So_Chuyen_Thu.Value = Tong_So_Chuyen_Thu
                MyCommand.Parameters.Add(pTong_So_Chuyen_Thu)

                Dim pTong_So_E2 As SqlParameter = New SqlParameter("@Tong_So_E2", SqlDbType.Int, 0)
                pTong_So_E2.Value = Tong_So_E2
                MyCommand.Parameters.Add(pTong_So_E2)

                Dim pTong_So_BP_D As SqlParameter = New SqlParameter("@Tong_So_BP_D", SqlDbType.Int, 0)
                pTong_So_BP_D.Value = Tong_So_BP_D
                MyCommand.Parameters.Add(pTong_So_BP_D)

                Dim pTong_So_BP_M As SqlParameter = New SqlParameter("@Tong_So_BP_M", SqlDbType.Int, 0)
                pTong_So_BP_M.Value = Tong_So_BP_M
                MyCommand.Parameters.Add(pTong_So_BP_M)

                Dim pKhoi_Luong_BP_D As SqlParameter = New SqlParameter("@Khoi_Luong_BP_D", SqlDbType.Int, 0)
                pKhoi_Luong_BP_D.Value = Khoi_Luong_BP_D
                MyCommand.Parameters.Add(pKhoi_Luong_BP_D)

                Dim pKhoi_Luong_BP_M As SqlParameter = New SqlParameter("@Khoi_Luong_BP_M", SqlDbType.Int, 0)
                pKhoi_Luong_BP_M.Value = Khoi_Luong_BP_M
                MyCommand.Parameters.Add(pKhoi_Luong_BP_M)

                Dim pChi_Tiet_Trang_Thai As SqlParameter = New SqlParameter("@Chi_Tiet_Trang_Thai", SqlDbType.VarChar, 200)
                pChi_Tiet_Trang_Thai.Value = Chi_Tiet_Trang_Thai
                MyCommand.Parameters.Add(pChi_Tiet_Trang_Thai)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Value = Ngay_He_Thong
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Value = Gio_He_Thong
                MyCommand.Parameters.Add(pGio_He_Thong)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                MyCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 500)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

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

#Region "DSQT_Thong_Tin_Ke_Toan_Ca_Cap_Nhat_Them"
        Public Function DSQT_Thong_Tin_Ke_Toan_Ca_Cap_Nhat_Them(ByVal Id_Ke_Toan As String, ByVal Id_Ca As String, ByVal Ma_Trang_Thai As Integer, ByVal STT As Integer, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ngay_Khai_Thac As Integer, ByVal Ca_Khai_Thac As Integer, ByVal Tong_So_Chuyen_Thu As Integer, ByVal Tong_So_E2 As Integer, ByVal Tong_So_BP_D As Integer, ByVal Tong_So_BP_M As Integer, ByVal Khoi_Luong_BP_D As Integer, ByVal Khoi_Luong_BP_M As Integer, ByVal Chi_Tiet_Trang_Thai As String, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Ghi_Chu As String, ByVal Chot_SL As Boolean) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Thong_Tin_Ke_Toan_Ca_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet As New DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Ke_Toan As SqlParameter = New SqlParameter("@Id_Ke_Toan", SqlDbType.VarChar, 25)
                pId_Ke_Toan.Value = Id_Ke_Toan
                MyCommand.Parameters.Add(pId_Ke_Toan)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                MyCommand.Parameters.Add(pId_Ca)

                Dim pMa_Trang_Thai As SqlParameter = New SqlParameter("@Ma_Trang_Thai", SqlDbType.Int, 0)
                pMa_Trang_Thai.Value = Ma_Trang_Thai
                MyCommand.Parameters.Add(pMa_Trang_Thai)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Value = STT
                MyCommand.Parameters.Add(pSTT)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pNgay_Khai_Thac As SqlParameter = New SqlParameter("@Ngay_Khai_Thac", SqlDbType.Int, 0)
                pNgay_Khai_Thac.Value = Ngay_Khai_Thac
                MyCommand.Parameters.Add(pNgay_Khai_Thac)

                Dim pCa_Khai_Thac As SqlParameter = New SqlParameter("@Ca_Khai_Thac", SqlDbType.Int, 0)
                pCa_Khai_Thac.Value = Ca_Khai_Thac
                MyCommand.Parameters.Add(pCa_Khai_Thac)

                Dim pTong_So_Chuyen_Thu As SqlParameter = New SqlParameter("@Tong_So_Chuyen_Thu", SqlDbType.Int, 0)
                pTong_So_Chuyen_Thu.Value = Tong_So_Chuyen_Thu
                MyCommand.Parameters.Add(pTong_So_Chuyen_Thu)

                Dim pTong_So_E2 As SqlParameter = New SqlParameter("@Tong_So_E2", SqlDbType.Int, 0)
                pTong_So_E2.Value = Tong_So_E2
                MyCommand.Parameters.Add(pTong_So_E2)

                Dim pTong_So_BP_D As SqlParameter = New SqlParameter("@Tong_So_BP_D", SqlDbType.Int, 0)
                pTong_So_BP_D.Value = Tong_So_BP_D
                MyCommand.Parameters.Add(pTong_So_BP_D)

                Dim pTong_So_BP_M As SqlParameter = New SqlParameter("@Tong_So_BP_M", SqlDbType.Int, 0)
                pTong_So_BP_M.Value = Tong_So_BP_M
                MyCommand.Parameters.Add(pTong_So_BP_M)

                Dim pKhoi_Luong_BP_D As SqlParameter = New SqlParameter("@Khoi_Luong_BP_D", SqlDbType.Int, 0)
                pKhoi_Luong_BP_D.Value = Khoi_Luong_BP_D
                MyCommand.Parameters.Add(pKhoi_Luong_BP_D)

                Dim pKhoi_Luong_BP_M As SqlParameter = New SqlParameter("@Khoi_Luong_BP_M", SqlDbType.Int, 0)
                pKhoi_Luong_BP_M.Value = Khoi_Luong_BP_M
                MyCommand.Parameters.Add(pKhoi_Luong_BP_M)

                Dim pChi_Tiet_Trang_Thai As SqlParameter = New SqlParameter("@Chi_Tiet_Trang_Thai", SqlDbType.VarChar, 200)
                pChi_Tiet_Trang_Thai.Value = Chi_Tiet_Trang_Thai
                MyCommand.Parameters.Add(pChi_Tiet_Trang_Thai)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Value = Ngay_He_Thong
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Value = Gio_He_Thong
                MyCommand.Parameters.Add(pGio_He_Thong)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                MyCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 500)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

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


#Region "DSQT_Thong_Tin_Ke_Toan_Ca_Danh_Sach"

        Public Function DSQT_Thong_Tin_Ke_Toan_Ca_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Id_Ke_Toan
            ' Id_Ca
            ' Ma_Trang_Thai
            ' STT
            ' Ma_Bc_Khai_Thac
            ' Ngay_Khai_Thac
            ' Ca_Khai_Thac
            ' Tong_So_Chuyen_Thu
            ' Tong_So_E2
            ' Tong_So_BP_D
            ' Tong_So_BP_M
            ' Khoi_Luong_BP_D
            ' Khoi_Luong_BP_M
            ' Chi_Tiet_Trang_Thai
            ' Ngay_He_Thong
            ' Gio_He_Thong
            ' Id_Nguoi_Dung
            ' Ghi_Chu
            ' Chot_SL


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Thong_Tin_Ke_Toan_Ca_Danh_Sach"
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

#Region "DSQT_Thong_Tin_Ke_Toan_Ca_Lay"
        Public Function DSQT_Thong_Tin_Ke_Toan_Ca_Lay(ByVal Id_Ke_Toan As String) As DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Thong_Tin_Ke_Toan_Ca_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet As New DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Ke_Toan As SqlParameter = New SqlParameter("@Id_Ke_Toan", SqlDbType.VarChar, 25)
                pId_Ke_Toan.Value = Id_Ke_Toan
                MyCommand.Parameters.Add(pId_Ke_Toan)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Ca)

                Dim pMa_Trang_Thai As SqlParameter = New SqlParameter("@Ma_Trang_Thai", SqlDbType.Int, 0)
                pMa_Trang_Thai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Trang_Thai)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSTT)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pNgay_Khai_Thac As SqlParameter = New SqlParameter("@Ngay_Khai_Thac", SqlDbType.Int, 0)
                pNgay_Khai_Thac.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Khai_Thac)

                Dim pCa_Khai_Thac As SqlParameter = New SqlParameter("@Ca_Khai_Thac", SqlDbType.Int, 0)
                pCa_Khai_Thac.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCa_Khai_Thac)

                Dim pTong_So_Chuyen_Thu As SqlParameter = New SqlParameter("@Tong_So_Chuyen_Thu", SqlDbType.Int, 0)
                pTong_So_Chuyen_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTong_So_Chuyen_Thu)

                Dim pTong_So_E2 As SqlParameter = New SqlParameter("@Tong_So_E2", SqlDbType.Int, 0)
                pTong_So_E2.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTong_So_E2)

                Dim pTong_So_BP_D As SqlParameter = New SqlParameter("@Tong_So_BP_D", SqlDbType.Int, 0)
                pTong_So_BP_D.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTong_So_BP_D)

                Dim pTong_So_BP_M As SqlParameter = New SqlParameter("@Tong_So_BP_M", SqlDbType.Int, 0)
                pTong_So_BP_M.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTong_So_BP_M)

                Dim pKhoi_Luong_BP_D As SqlParameter = New SqlParameter("@Khoi_Luong_BP_D", SqlDbType.Int, 0)
                pKhoi_Luong_BP_D.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pKhoi_Luong_BP_D)

                Dim pKhoi_Luong_BP_M As SqlParameter = New SqlParameter("@Khoi_Luong_BP_M", SqlDbType.Int, 0)
                pKhoi_Luong_BP_M.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pKhoi_Luong_BP_M)

                Dim pChi_Tiet_Trang_Thai As SqlParameter = New SqlParameter("@Chi_Tiet_Trang_Thai", SqlDbType.VarChar, 200)
                pChi_Tiet_Trang_Thai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pChi_Tiet_Trang_Thai)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_He_Thong)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0)
                pId_Nguoi_Dung.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 500)
                pGhi_Chu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 0)
                pChot_SL.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pChot_SL)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Id_Ca = pId_Ca.Value
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Ma_Trang_Thai = pId_Ca.Value
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.STT = pId_Ca.Value
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Ma_Bc_Khai_Thac = pId_Ca.Value
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Ngay_Khai_Thac = pId_Ca.Value
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Ca_Khai_Thac = pId_Ca.Value
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Tong_So_Chuyen_Thu = pId_Ca.Value
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Tong_So_E2 = pId_Ca.Value
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Tong_So_BP_D = pId_Ca.Value
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Tong_So_BP_M = pId_Ca.Value
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Khoi_Luong_BP_D = pId_Ca.Value
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Khoi_Luong_BP_M = pId_Ca.Value
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Chi_Tiet_Trang_Thai = pId_Ca.Value
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Ngay_He_Thong = pId_Ca.Value
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Gio_He_Thong = pId_Ca.Value
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Id_Nguoi_Dung = pId_Ca.Value
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Ghi_Chu = pId_Ca.Value
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Chot_SL = pId_Ca.Value

                Return myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet
                'Return myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet

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

#Region "DSQT_Thong_Tin_Ke_Toan_Ca_Them"
        Public Function DSQT_Thong_Tin_Ke_Toan_Ca_Them(ByVal Id_Ke_Toan As String, ByVal Id_Ca As String, ByVal Ma_Trang_Thai As Integer, ByVal STT As Integer, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ngay_Khai_Thac As Integer, ByVal Ca_Khai_Thac As Integer, ByVal Tong_So_Chuyen_Thu As Integer, ByVal Tong_So_E2 As Integer, ByVal Tong_So_BP_D As Integer, ByVal Tong_So_BP_M As Integer, ByVal Khoi_Luong_BP_D As Integer, ByVal Khoi_Luong_BP_M As Integer, ByVal Chi_Tiet_Trang_Thai As String, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Ghi_Chu As String, ByVal Chot_SL As Boolean) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Thong_Tin_Ke_Toan_Ca_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet As New DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Ke_Toan As SqlParameter = New SqlParameter("@Id_Ke_Toan", SqlDbType.VarChar, 25)
                pId_Ke_Toan.Value = Id_Ke_Toan
                MyCommand.Parameters.Add(pId_Ke_Toan)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                MyCommand.Parameters.Add(pId_Ca)

                Dim pMa_Trang_Thai As SqlParameter = New SqlParameter("@Ma_Trang_Thai", SqlDbType.Int, 0)
                pMa_Trang_Thai.Value = Ma_Trang_Thai
                MyCommand.Parameters.Add(pMa_Trang_Thai)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Value = STT
                MyCommand.Parameters.Add(pSTT)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pNgay_Khai_Thac As SqlParameter = New SqlParameter("@Ngay_Khai_Thac", SqlDbType.Int, 0)
                pNgay_Khai_Thac.Value = Ngay_Khai_Thac
                MyCommand.Parameters.Add(pNgay_Khai_Thac)

                Dim pCa_Khai_Thac As SqlParameter = New SqlParameter("@Ca_Khai_Thac", SqlDbType.Int, 0)
                pCa_Khai_Thac.Value = Ca_Khai_Thac
                MyCommand.Parameters.Add(pCa_Khai_Thac)

                Dim pTong_So_Chuyen_Thu As SqlParameter = New SqlParameter("@Tong_So_Chuyen_Thu", SqlDbType.Int, 0)
                pTong_So_Chuyen_Thu.Value = Tong_So_Chuyen_Thu
                MyCommand.Parameters.Add(pTong_So_Chuyen_Thu)

                Dim pTong_So_E2 As SqlParameter = New SqlParameter("@Tong_So_E2", SqlDbType.Int, 0)
                pTong_So_E2.Value = Tong_So_E2
                MyCommand.Parameters.Add(pTong_So_E2)

                Dim pTong_So_BP_D As SqlParameter = New SqlParameter("@Tong_So_BP_D", SqlDbType.Int, 0)
                pTong_So_BP_D.Value = Tong_So_BP_D
                MyCommand.Parameters.Add(pTong_So_BP_D)

                Dim pTong_So_BP_M As SqlParameter = New SqlParameter("@Tong_So_BP_M", SqlDbType.Int, 0)
                pTong_So_BP_M.Value = Tong_So_BP_M
                MyCommand.Parameters.Add(pTong_So_BP_M)

                Dim pKhoi_Luong_BP_D As SqlParameter = New SqlParameter("@Khoi_Luong_BP_D", SqlDbType.Int, 0)
                pKhoi_Luong_BP_D.Value = Khoi_Luong_BP_D
                MyCommand.Parameters.Add(pKhoi_Luong_BP_D)

                Dim pKhoi_Luong_BP_M As SqlParameter = New SqlParameter("@Khoi_Luong_BP_M", SqlDbType.Int, 0)
                pKhoi_Luong_BP_M.Value = Khoi_Luong_BP_M
                MyCommand.Parameters.Add(pKhoi_Luong_BP_M)

                Dim pChi_Tiet_Trang_Thai As SqlParameter = New SqlParameter("@Chi_Tiet_Trang_Thai", SqlDbType.VarChar, 200)
                pChi_Tiet_Trang_Thai.Value = Chi_Tiet_Trang_Thai
                MyCommand.Parameters.Add(pChi_Tiet_Trang_Thai)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Value = Ngay_He_Thong
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Value = Gio_He_Thong
                MyCommand.Parameters.Add(pGio_He_Thong)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                MyCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 500)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

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

#Region "DSQT_Thong_Tin_Ke_Toan_Ca_Xoa"
        Public Function DSQT_Thong_Tin_Ke_Toan_Ca_Xoa(ByVal Id_Ke_Toan As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Thong_Tin_Ke_Toan_Ca_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet As New DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Ke_Toan As SqlParameter = New SqlParameter("@Id_Ke_Toan", SqlDbType.VarChar, 25)
                pId_Ke_Toan.Value = Id_Ke_Toan
                MyCommand.Parameters.Add(pId_Ke_Toan)


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

#Region "DSQT_Thong_Tin_Ke_Toan_Ca_Danh_Sach_Theo_Id_Ca"

        Public Function DSQT_Thong_Tin_Ke_Toan_Ca_Danh_Sach_Theo_Id_Ca(ByVal Id_Ca As String) As DataSet

            ' The procedure returns these columns:
            ' Id_Ke_Toan
            ' Id_Ca
            ' Ma_Trang_Thai
            ' STT
            ' Ma_Bc_Khai_Thac
            ' Ngay_Khai_Thac
            ' Ca_Khai_Thac
            ' Tong_So_Chuyen_Thu
            ' Tong_So_E2
            ' Tong_So_BP_D
            ' Tong_So_BP_M
            ' Khoi_Luong_BP_D
            ' Khoi_Luong_BP_M
            ' Chi_Tiet_Trang_Thai
            ' Ngay_He_Thong
            ' Gio_He_Thong
            ' Id_Nguoi_Dung
            ' Ghi_Chu
            ' Chot_SL


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Thong_Tin_Ke_Toan_Ca_Danh_Sach_Theo_Id_Ca"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                MyCommand.Parameters.Add(pId_Ca)

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

#Region "DSQT_Thong_Tin_Ke_Toan_Ca_Lay_Chi_Tiet_Tong_Hop_Gan_Nhat_Theo_Ca"
        Public Function DSQT_Thong_Tin_Ke_Toan_Ca_Lay_Chi_Tiet_Tong_Hop_Gan_Nhat_Theo_Ca(ByVal Id_Ca As String) As DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Thong_Tin_Ke_Toan_Ca_Lay_Chi_Tiet_Tong_Hop_Gan_Nhat_Theo_Ca"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet As New DSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                MyCommand.Parameters.Add(pId_Ca)

                Dim pId_Ke_Toan As SqlParameter = New SqlParameter("@Id_Ke_Toan", SqlDbType.VarChar, 25)
                pId_Ke_Toan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Ke_Toan)

                Dim pMa_Trang_Thai As SqlParameter = New SqlParameter("@Ma_Trang_Thai", SqlDbType.Int, 0)
                pMa_Trang_Thai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Trang_Thai)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSTT)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pNgay_Khai_Thac As SqlParameter = New SqlParameter("@Ngay_Khai_Thac", SqlDbType.Int, 0)
                pNgay_Khai_Thac.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Khai_Thac)

                Dim pCa_Khai_Thac As SqlParameter = New SqlParameter("@Ca_Khai_Thac", SqlDbType.Int, 0)
                pCa_Khai_Thac.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCa_Khai_Thac)

                Dim pTong_So_Chuyen_Thu As SqlParameter = New SqlParameter("@Tong_So_Chuyen_Thu", SqlDbType.Int, 0)
                pTong_So_Chuyen_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTong_So_Chuyen_Thu)

                Dim pTong_So_E2 As SqlParameter = New SqlParameter("@Tong_So_E2", SqlDbType.Int, 0)
                pTong_So_E2.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTong_So_E2)

                Dim pTong_So_BP_D As SqlParameter = New SqlParameter("@Tong_So_BP_D", SqlDbType.Int, 0)
                pTong_So_BP_D.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTong_So_BP_D)

                Dim pTong_So_BP_M As SqlParameter = New SqlParameter("@Tong_So_BP_M", SqlDbType.Int, 0)
                pTong_So_BP_M.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTong_So_BP_M)

                Dim pKhoi_Luong_BP_D As SqlParameter = New SqlParameter("@Khoi_Luong_BP_D", SqlDbType.Int, 0)
                pKhoi_Luong_BP_D.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pKhoi_Luong_BP_D)

                Dim pKhoi_Luong_BP_M As SqlParameter = New SqlParameter("@Khoi_Luong_BP_M", SqlDbType.Int, 0)
                pKhoi_Luong_BP_M.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pKhoi_Luong_BP_M)

                Dim pChi_Tiet_Trang_Thai As SqlParameter = New SqlParameter("@Chi_Tiet_Trang_Thai", SqlDbType.VarChar, 200)
                pChi_Tiet_Trang_Thai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pChi_Tiet_Trang_Thai)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_He_Thong)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0)
                pId_Nguoi_Dung.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 500)
                pGhi_Chu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 0)
                pChot_SL.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pChot_SL)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Id_Ke_Toan = pId_Ke_Toan.Value
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Id_Ca = Id_Ca
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Ma_Trang_Thai = pMa_Trang_Thai.Value
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.STT = pSTT.Value
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Ma_Bc_Khai_Thac = pMa_Bc_Khai_Thac.Value
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Ngay_Khai_Thac = pNgay_Khai_Thac.Value
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Ca_Khai_Thac = pCa_Khai_Thac.Value
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Tong_So_Chuyen_Thu = pTong_So_Chuyen_Thu.Value
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Tong_So_E2 = pTong_So_E2.Value
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Tong_So_BP_D = pTong_So_BP_D.Value
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Tong_So_BP_M = pTong_So_BP_M.Value
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Khoi_Luong_BP_D = pKhoi_Luong_BP_D.Value
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Khoi_Luong_BP_M = pKhoi_Luong_BP_M.Value
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Chi_Tiet_Trang_Thai = pChi_Tiet_Trang_Thai.Value
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Gio_He_Thong = pGio_He_Thong.Value
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Id_Nguoi_Dung = pId_Nguoi_Dung.Value
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value
                myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet.Chot_SL = pChot_SL.Value

                Return myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet
                'Return myDSQT_Thong_Tin_Ke_Toan_Ca_Chi_Tiet

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



Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "DSQT_E1_Quoc_Te_Den_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop DSQT_E1_Quoc_Te_Den_Chi_Tiet
    'Tuong ung voi moi truong trong bang DSQT_E1_Quoc_Te_Den trong co so du lieu
    '***********************************************************
    Public Class DSQT_E1_Quoc_Te_Den_Chi_Tiet
        Public Id_E1 As String
        Public Id_Duong_Thu As String
        Public Ma_Bc As Integer
        Public Noi_Gui As String
        Public IMPC As String
        Public Ma_Nuoc_Duong_Thu As String
        Public Ma_Nuoc_Thanh_Toan As String
        Public Ma_Bc_Thanh_Toan As Integer
        Public IMPC_Thanh_Toan As String
        Public Phan_Loai_Thanh_Toan As String
        Public Id_Chuyen_Thu As String
        Public Loai_Chuyen_Thu As String
        Public So_Chuyen_Thu As Integer
        Public Id_E2 As String
        Public Tui_So As Integer
        Public Id_Ca As String
        Public Ngay_Khai_Thac As Integer
        Public Ca_Khai_Thac As Integer
        Public Ma_Bc_Khai_Thac As Integer
        Public Ma_E1 As String
        Public Ngay_Dong As Integer
        Public Gio_Dong As Integer
        Public Ngay_Nhan As Integer
        Public Gio_Nhan As Integer
        Public Ma_Bc_Goc As Integer
        Public Ma_Bc_Tra As Integer
        Public Nuoc_Nhan As String
        Public Nuoc_Tra As String
        Public Khoi_Luong As Integer
        Public Phan_Loai As String
        Public Loai_Hang_Hoa As Integer
        Public Khoi_Luong_QD As Integer
        Public Loai As Integer
        Public STT As Integer
        Public Cuoc_Theo_SL As Double
        Public Cuoc_Theo_KL As Double
        Public Cuoc_Khac As Double
        Public Cuoc_VCMBND As Double
        Public Ma_Tien_Te As String
        Public Tong_Doanh_Thu As Double
        Public Tong_Doanh_Thu_VND As Integer
        Public Id_Nguoi_Dung As Integer
        Public Id_Trang_Thai As Integer
        Public Ghi_Chu As String
        Public Ngay_He_Thong As Integer
        Public Gio_He_Thong As Integer
        Public Chot_SL As Boolean
        Public Id_Dich_Vu As String
    End Class
#End Region

#Region "DSQT_E1_Quoc_Te_Den"
    Public Class DSQT_E1_Quoc_Te_Den
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "DSQT_E1_Quoc_Te_Den_Cap_Nhat"
        Public Function DSQT_E1_Quoc_Te_Den_Cap_Nhat(ByVal Id_E1 As String, ByVal Id_Duong_Thu As String, ByVal Ma_Bc As Integer, ByVal Noi_Gui As String, ByVal IMPC As String, ByVal Ma_Nuoc_Duong_Thu As String, ByVal Ma_Nuoc_Thanh_Toan As String, ByVal Ma_Bc_Thanh_Toan As Integer, ByVal IMPC_Thanh_Toan As String, ByVal Phan_Loai_Thanh_Toan As String, ByVal Id_Chuyen_Thu As String, ByVal Loai_Chuyen_Thu As String, ByVal So_Chuyen_Thu As Integer, ByVal Id_E2 As String, ByVal Tui_So As Integer, ByVal Id_Ca As String, ByVal Ngay_Khai_Thac As Integer, ByVal Ca_Khai_Thac As Integer, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_E1 As String, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Ma_Bc_Goc As Integer, ByVal Ma_Bc_Tra As Integer, ByVal Nuoc_Nhan As String, ByVal Nuoc_Tra As String, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal Loai_Hang_Hoa As Integer, ByVal Khoi_Luong_QD As Integer, ByVal Loai As Integer, ByVal STT As Integer, ByVal Cuoc_Theo_SL As Double, ByVal Cuoc_Theo_KL As Double, ByVal Cuoc_Khac As Double, ByVal Cuoc_VCMBND As Double, ByVal Ma_Tien_Te As String, ByVal Tong_Doanh_Thu As Double, ByVal Tong_Doanh_Thu_VND As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Id_Trang_Thai As Integer, ByVal Ghi_Chu As String, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer, ByVal Chot_SL As Boolean, ByVal Id_Dich_Vu As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_E1_Quoc_Te_Den_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_E1_Quoc_Te_Den_Chi_Tiet As New DSQT_E1_Quoc_Te_Den_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                MyCommand.Parameters.Add(pId_E1)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 0)
                pMa_Bc.Value = Ma_Bc
                MyCommand.Parameters.Add(pMa_Bc)

                Dim pNoi_Gui As SqlParameter = New SqlParameter("@Noi_Gui", SqlDbType.VarChar, 3)
                pNoi_Gui.Value = Noi_Gui
                MyCommand.Parameters.Add(pNoi_Gui)

                Dim pIMPC As SqlParameter = New SqlParameter("@IMPC", SqlDbType.VarChar, 6)
                pIMPC.Value = IMPC
                MyCommand.Parameters.Add(pIMPC)

                Dim pMa_Nuoc_Duong_Thu As SqlParameter = New SqlParameter("@Ma_Nuoc_Duong_Thu", SqlDbType.VarChar, 2)
                pMa_Nuoc_Duong_Thu.Value = Ma_Nuoc_Duong_Thu
                MyCommand.Parameters.Add(pMa_Nuoc_Duong_Thu)

                Dim pMa_Nuoc_Thanh_Toan As SqlParameter = New SqlParameter("@Ma_Nuoc_Thanh_Toan", SqlDbType.VarChar, 2)
                pMa_Nuoc_Thanh_Toan.Value = Ma_Nuoc_Thanh_Toan
                MyCommand.Parameters.Add(pMa_Nuoc_Thanh_Toan)

                Dim pMa_Bc_Thanh_Toan As SqlParameter = New SqlParameter("@Ma_Bc_Thanh_Toan", SqlDbType.Int, 0)
                pMa_Bc_Thanh_Toan.Value = Ma_Bc_Thanh_Toan
                MyCommand.Parameters.Add(pMa_Bc_Thanh_Toan)

                Dim pIMPC_Thanh_Toan As SqlParameter = New SqlParameter("@IMPC_Thanh_Toan", SqlDbType.VarChar, 6)
                pIMPC_Thanh_Toan.Value = IMPC_Thanh_Toan
                MyCommand.Parameters.Add(pIMPC_Thanh_Toan)

                Dim pPhan_Loai_Thanh_Toan As SqlParameter = New SqlParameter("@Phan_Loai_Thanh_Toan", SqlDbType.VarChar, 1)
                pPhan_Loai_Thanh_Toan.Value = Phan_Loai_Thanh_Toan
                MyCommand.Parameters.Add(pPhan_Loai_Thanh_Toan)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                MyCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pLoai_Chuyen_Thu As SqlParameter = New SqlParameter("@Loai_Chuyen_Thu", SqlDbType.VarChar, 2)
                pLoai_Chuyen_Thu.Value = Loai_Chuyen_Thu
                MyCommand.Parameters.Add(pLoai_Chuyen_Thu)

                Dim pSo_Chuyen_Thu As SqlParameter = New SqlParameter("@So_Chuyen_Thu", SqlDbType.Int, 0)
                pSo_Chuyen_Thu.Value = So_Chuyen_Thu
                MyCommand.Parameters.Add(pSo_Chuyen_Thu)

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                MyCommand.Parameters.Add(pId_E2)

                Dim pTui_So As SqlParameter = New SqlParameter("@Tui_So", SqlDbType.Int, 0)
                pTui_So.Value = Tui_So
                MyCommand.Parameters.Add(pTui_So)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                MyCommand.Parameters.Add(pId_Ca)

                Dim pNgay_Khai_Thac As SqlParameter = New SqlParameter("@Ngay_Khai_Thac", SqlDbType.Int, 0)
                pNgay_Khai_Thac.Value = Ngay_Khai_Thac
                MyCommand.Parameters.Add(pNgay_Khai_Thac)

                Dim pCa_Khai_Thac As SqlParameter = New SqlParameter("@Ca_Khai_Thac", SqlDbType.Int, 0)
                pCa_Khai_Thac.Value = Ca_Khai_Thac
                MyCommand.Parameters.Add(pCa_Khai_Thac)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                MyCommand.Parameters.Add(pMa_E1)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 0)
                pNgay_Dong.Value = Ngay_Dong
                MyCommand.Parameters.Add(pNgay_Dong)

                Dim pGio_Dong As SqlParameter = New SqlParameter("@Gio_Dong", SqlDbType.Int, 0)
                pGio_Dong.Value = Gio_Dong
                MyCommand.Parameters.Add(pGio_Dong)

                Dim pNgay_Nhan As SqlParameter = New SqlParameter("@Ngay_Nhan", SqlDbType.Int, 0)
                pNgay_Nhan.Value = Ngay_Nhan
                MyCommand.Parameters.Add(pNgay_Nhan)

                Dim pGio_Nhan As SqlParameter = New SqlParameter("@Gio_Nhan", SqlDbType.Int, 0)
                pGio_Nhan.Value = Gio_Nhan
                MyCommand.Parameters.Add(pGio_Nhan)

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 0)
                pMa_Bc_Goc.Value = Ma_Bc_Goc
                MyCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 0)
                pMa_Bc_Tra.Value = Ma_Bc_Tra
                MyCommand.Parameters.Add(pMa_Bc_Tra)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Value = Nuoc_Nhan
                MyCommand.Parameters.Add(pNuoc_Nhan)

                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2)
                pNuoc_Tra.Value = Nuoc_Tra
                MyCommand.Parameters.Add(pNuoc_Tra)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 0)
                pKhoi_Luong.Value = Khoi_Luong
                MyCommand.Parameters.Add(pKhoi_Luong)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.VarChar, 1)
                pPhan_Loai.Value = Phan_Loai
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pLoai_Hang_Hoa As SqlParameter = New SqlParameter("@Loai_Hang_Hoa", SqlDbType.Int, 0)
                pLoai_Hang_Hoa.Value = Loai_Hang_Hoa
                MyCommand.Parameters.Add(pLoai_Hang_Hoa)

                Dim pKhoi_Luong_QD As SqlParameter = New SqlParameter("@Khoi_Luong_QD", SqlDbType.Int, 0)
                pKhoi_Luong_QD.Value = Khoi_Luong_QD
                MyCommand.Parameters.Add(pKhoi_Luong_QD)

                Dim pLoai As SqlParameter = New SqlParameter("@Loai", SqlDbType.Int, 0)
                pLoai.Value = Loai
                MyCommand.Parameters.Add(pLoai)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Value = STT
                MyCommand.Parameters.Add(pSTT)

                Dim pCuoc_Theo_SL As SqlParameter = New SqlParameter("@Cuoc_Theo_SL", SqlDbType.Float, 0)
                pCuoc_Theo_SL.Value = Cuoc_Theo_SL
                MyCommand.Parameters.Add(pCuoc_Theo_SL)

                Dim pCuoc_Theo_KL As SqlParameter = New SqlParameter("@Cuoc_Theo_KL", SqlDbType.Float, 0)
                pCuoc_Theo_KL.Value = Cuoc_Theo_KL
                MyCommand.Parameters.Add(pCuoc_Theo_KL)

                Dim pCuoc_Khac As SqlParameter = New SqlParameter("@Cuoc_Khac", SqlDbType.Float, 0)
                pCuoc_Khac.Value = Cuoc_Khac
                MyCommand.Parameters.Add(pCuoc_Khac)

                Dim pCuoc_VCMBND As SqlParameter = New SqlParameter("@Cuoc_VCMBND", SqlDbType.Float, 0)
                pCuoc_VCMBND.Value = Cuoc_VCMBND
                MyCommand.Parameters.Add(pCuoc_VCMBND)

                Dim pMa_Tien_Te As SqlParameter = New SqlParameter("@Ma_Tien_Te", SqlDbType.VarChar, 5)
                pMa_Tien_Te.Value = Ma_Tien_Te
                MyCommand.Parameters.Add(pMa_Tien_Te)

                Dim pTong_Doanh_Thu As SqlParameter = New SqlParameter("@Tong_Doanh_Thu", SqlDbType.Float, 0)
                pTong_Doanh_Thu.Value = Tong_Doanh_Thu
                MyCommand.Parameters.Add(pTong_Doanh_Thu)

                Dim pTong_Doanh_Thu_VND As SqlParameter = New SqlParameter("@Tong_Doanh_Thu_VND", SqlDbType.Int, 0)
                pTong_Doanh_Thu_VND.Value = Tong_Doanh_Thu_VND
                MyCommand.Parameters.Add(pTong_Doanh_Thu_VND)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                MyCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.Int, 0)
                pId_Trang_Thai.Value = Id_Trang_Thai
                MyCommand.Parameters.Add(pId_Trang_Thai)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 200)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Value = Ngay_He_Thong
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Value = Gio_He_Thong
                MyCommand.Parameters.Add(pGio_He_Thong)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 0)
                pChot_SL.Value = Chot_SL
                MyCommand.Parameters.Add(pChot_SL)

                Dim pId_Dich_Vu As SqlParameter = New SqlParameter("@Id_Dich_Vu", SqlDbType.VarChar, 1)
                pId_Dich_Vu.Value = Id_Dich_Vu
                MyCommand.Parameters.Add(pId_Dich_Vu)


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

#Region "DSQT_E1_Quoc_Te_Den_Cap_Nhat_Them"
        Public Function DSQT_E1_Quoc_Te_Den_Cap_Nhat_Them(ByVal Id_E1 As String, ByVal Id_Duong_Thu As String, ByVal Ma_Bc As Integer, ByVal Noi_Gui As String, ByVal IMPC As String, ByVal Ma_Nuoc_Duong_Thu As String, ByVal Ma_Nuoc_Thanh_Toan As String, ByVal Ma_Bc_Thanh_Toan As Integer, ByVal IMPC_Thanh_Toan As String, ByVal Phan_Loai_Thanh_Toan As String, ByVal Id_Chuyen_Thu As String, ByVal Loai_Chuyen_Thu As String, ByVal So_Chuyen_Thu As Integer, ByVal Id_E2 As String, ByVal Tui_So As Integer, ByVal Id_Ca As String, ByVal Ngay_Khai_Thac As Integer, ByVal Ca_Khai_Thac As Integer, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_E1 As String, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Ma_Bc_Goc As Integer, ByVal Ma_Bc_Tra As Integer, ByVal Nuoc_Nhan As String, ByVal Nuoc_Tra As String, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal Loai_Hang_Hoa As Integer, ByVal Khoi_Luong_QD As Integer, ByVal Loai As Integer, ByVal STT As Integer, ByVal Cuoc_Theo_SL As Double, ByVal Cuoc_Theo_KL As Double, ByVal Cuoc_Khac As Double, ByVal Cuoc_VCMBND As Double, ByVal Ma_Tien_Te As String, ByVal Tong_Doanh_Thu As Double, ByVal Tong_Doanh_Thu_VND As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Id_Trang_Thai As Integer, ByVal Ghi_Chu As String, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer, ByVal Chot_SL As Boolean, ByVal Id_Dich_Vu As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_E1_Quoc_Te_Den_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_E1_Quoc_Te_Den_Chi_Tiet As New DSQT_E1_Quoc_Te_Den_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                MyCommand.Parameters.Add(pId_E1)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 0)
                pMa_Bc.Value = Ma_Bc
                MyCommand.Parameters.Add(pMa_Bc)

                Dim pNoi_Gui As SqlParameter = New SqlParameter("@Noi_Gui", SqlDbType.VarChar, 3)
                pNoi_Gui.Value = Noi_Gui
                MyCommand.Parameters.Add(pNoi_Gui)

                Dim pIMPC As SqlParameter = New SqlParameter("@IMPC", SqlDbType.VarChar, 6)
                pIMPC.Value = IMPC
                MyCommand.Parameters.Add(pIMPC)

                Dim pMa_Nuoc_Duong_Thu As SqlParameter = New SqlParameter("@Ma_Nuoc_Duong_Thu", SqlDbType.VarChar, 2)
                pMa_Nuoc_Duong_Thu.Value = Ma_Nuoc_Duong_Thu
                MyCommand.Parameters.Add(pMa_Nuoc_Duong_Thu)

                Dim pMa_Nuoc_Thanh_Toan As SqlParameter = New SqlParameter("@Ma_Nuoc_Thanh_Toan", SqlDbType.VarChar, 2)
                pMa_Nuoc_Thanh_Toan.Value = Ma_Nuoc_Thanh_Toan
                MyCommand.Parameters.Add(pMa_Nuoc_Thanh_Toan)

                Dim pMa_Bc_Thanh_Toan As SqlParameter = New SqlParameter("@Ma_Bc_Thanh_Toan", SqlDbType.Int, 0)
                pMa_Bc_Thanh_Toan.Value = Ma_Bc_Thanh_Toan
                MyCommand.Parameters.Add(pMa_Bc_Thanh_Toan)

                Dim pIMPC_Thanh_Toan As SqlParameter = New SqlParameter("@IMPC_Thanh_Toan", SqlDbType.VarChar, 6)
                pIMPC_Thanh_Toan.Value = IMPC_Thanh_Toan
                MyCommand.Parameters.Add(pIMPC_Thanh_Toan)

                Dim pPhan_Loai_Thanh_Toan As SqlParameter = New SqlParameter("@Phan_Loai_Thanh_Toan", SqlDbType.VarChar, 1)
                pPhan_Loai_Thanh_Toan.Value = Phan_Loai_Thanh_Toan
                MyCommand.Parameters.Add(pPhan_Loai_Thanh_Toan)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                MyCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pLoai_Chuyen_Thu As SqlParameter = New SqlParameter("@Loai_Chuyen_Thu", SqlDbType.VarChar, 2)
                pLoai_Chuyen_Thu.Value = Loai_Chuyen_Thu
                MyCommand.Parameters.Add(pLoai_Chuyen_Thu)

                Dim pSo_Chuyen_Thu As SqlParameter = New SqlParameter("@So_Chuyen_Thu", SqlDbType.Int, 0)
                pSo_Chuyen_Thu.Value = So_Chuyen_Thu
                MyCommand.Parameters.Add(pSo_Chuyen_Thu)

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                MyCommand.Parameters.Add(pId_E2)

                Dim pTui_So As SqlParameter = New SqlParameter("@Tui_So", SqlDbType.Int, 0)
                pTui_So.Value = Tui_So
                MyCommand.Parameters.Add(pTui_So)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                MyCommand.Parameters.Add(pId_Ca)

                Dim pNgay_Khai_Thac As SqlParameter = New SqlParameter("@Ngay_Khai_Thac", SqlDbType.Int, 0)
                pNgay_Khai_Thac.Value = Ngay_Khai_Thac
                MyCommand.Parameters.Add(pNgay_Khai_Thac)

                Dim pCa_Khai_Thac As SqlParameter = New SqlParameter("@Ca_Khai_Thac", SqlDbType.Int, 0)
                pCa_Khai_Thac.Value = Ca_Khai_Thac
                MyCommand.Parameters.Add(pCa_Khai_Thac)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                MyCommand.Parameters.Add(pMa_E1)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 0)
                pNgay_Dong.Value = Ngay_Dong
                MyCommand.Parameters.Add(pNgay_Dong)

                Dim pGio_Dong As SqlParameter = New SqlParameter("@Gio_Dong", SqlDbType.Int, 0)
                pGio_Dong.Value = Gio_Dong
                MyCommand.Parameters.Add(pGio_Dong)

                Dim pNgay_Nhan As SqlParameter = New SqlParameter("@Ngay_Nhan", SqlDbType.Int, 0)
                pNgay_Nhan.Value = Ngay_Nhan
                MyCommand.Parameters.Add(pNgay_Nhan)

                Dim pGio_Nhan As SqlParameter = New SqlParameter("@Gio_Nhan", SqlDbType.Int, 0)
                pGio_Nhan.Value = Gio_Nhan
                MyCommand.Parameters.Add(pGio_Nhan)

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 0)
                pMa_Bc_Goc.Value = Ma_Bc_Goc
                MyCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 0)
                pMa_Bc_Tra.Value = Ma_Bc_Tra
                MyCommand.Parameters.Add(pMa_Bc_Tra)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Value = Nuoc_Nhan
                MyCommand.Parameters.Add(pNuoc_Nhan)

                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2)
                pNuoc_Tra.Value = Nuoc_Tra
                MyCommand.Parameters.Add(pNuoc_Tra)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 0)
                pKhoi_Luong.Value = Khoi_Luong
                MyCommand.Parameters.Add(pKhoi_Luong)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.VarChar, 1)
                pPhan_Loai.Value = Phan_Loai
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pLoai_Hang_Hoa As SqlParameter = New SqlParameter("@Loai_Hang_Hoa", SqlDbType.Int, 0)
                pLoai_Hang_Hoa.Value = Loai_Hang_Hoa
                MyCommand.Parameters.Add(pLoai_Hang_Hoa)

                Dim pKhoi_Luong_QD As SqlParameter = New SqlParameter("@Khoi_Luong_QD", SqlDbType.Int, 0)
                pKhoi_Luong_QD.Value = Khoi_Luong_QD
                MyCommand.Parameters.Add(pKhoi_Luong_QD)

                Dim pLoai As SqlParameter = New SqlParameter("@Loai", SqlDbType.Int, 0)
                pLoai.Value = Loai
                MyCommand.Parameters.Add(pLoai)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Value = STT
                MyCommand.Parameters.Add(pSTT)

                Dim pCuoc_Theo_SL As SqlParameter = New SqlParameter("@Cuoc_Theo_SL", SqlDbType.Float, 0)
                pCuoc_Theo_SL.Value = Cuoc_Theo_SL
                MyCommand.Parameters.Add(pCuoc_Theo_SL)

                Dim pCuoc_Theo_KL As SqlParameter = New SqlParameter("@Cuoc_Theo_KL", SqlDbType.Float, 0)
                pCuoc_Theo_KL.Value = Cuoc_Theo_KL
                MyCommand.Parameters.Add(pCuoc_Theo_KL)

                Dim pCuoc_Khac As SqlParameter = New SqlParameter("@Cuoc_Khac", SqlDbType.Float, 0)
                pCuoc_Khac.Value = Cuoc_Khac
                MyCommand.Parameters.Add(pCuoc_Khac)

                Dim pCuoc_VCMBND As SqlParameter = New SqlParameter("@Cuoc_VCMBND", SqlDbType.Float, 0)
                pCuoc_VCMBND.Value = Cuoc_VCMBND
                MyCommand.Parameters.Add(pCuoc_VCMBND)

                Dim pMa_Tien_Te As SqlParameter = New SqlParameter("@Ma_Tien_Te", SqlDbType.VarChar, 5)
                pMa_Tien_Te.Value = Ma_Tien_Te
                MyCommand.Parameters.Add(pMa_Tien_Te)

                Dim pTong_Doanh_Thu As SqlParameter = New SqlParameter("@Tong_Doanh_Thu", SqlDbType.Float, 0)
                pTong_Doanh_Thu.Value = Tong_Doanh_Thu
                MyCommand.Parameters.Add(pTong_Doanh_Thu)

                Dim pTong_Doanh_Thu_VND As SqlParameter = New SqlParameter("@Tong_Doanh_Thu_VND", SqlDbType.Int, 0)
                pTong_Doanh_Thu_VND.Value = Tong_Doanh_Thu_VND
                MyCommand.Parameters.Add(pTong_Doanh_Thu_VND)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                MyCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.Int, 0)
                pId_Trang_Thai.Value = Id_Trang_Thai
                MyCommand.Parameters.Add(pId_Trang_Thai)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 200)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Value = Ngay_He_Thong
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Value = Gio_He_Thong
                MyCommand.Parameters.Add(pGio_He_Thong)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 0)
                pChot_SL.Value = Chot_SL
                MyCommand.Parameters.Add(pChot_SL)

                Dim pId_Dich_Vu As SqlParameter = New SqlParameter("@Id_Dich_Vu", SqlDbType.VarChar, 1)
                pId_Dich_Vu.Value = Id_Dich_Vu
                MyCommand.Parameters.Add(pId_Dich_Vu)


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


#Region "DSQT_E1_Quoc_Te_Den_Danh_Sach"

        Public Function DSQT_E1_Quoc_Te_Den_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Id_E1
            ' Id_Duong_Thu
            ' Ma_Bc
            ' Noi_Gui
            ' IMPC
            ' Ma_Nuoc_Duong_Thu
            ' Ma_Nuoc_Thanh_Toan
            ' Ma_Bc_Thanh_Toan
            ' IMPC_Thanh_Toan
            ' Phan_Loai_Thanh_Toan
            ' Id_Chuyen_Thu
            ' Loai_Chuyen_Thu
            ' So_Chuyen_Thu
            ' Id_E2
            ' Tui_So
            ' Id_Ca
            ' Ngay_Khai_Thac
            ' Ca_Khai_Thac
            ' Ma_Bc_Khai_Thac
            ' Ma_E1
            ' Ngay_Dong
            ' Gio_Dong
            ' Ngay_Nhan
            ' Gio_Nhan
            ' Ma_Bc_Goc
            ' Ma_Bc_Tra
            ' Nuoc_Nhan
            ' Nuoc_Tra
            ' Khoi_Luong
            ' Phan_Loai
            ' Loai_Hang_Hoa
            ' Khoi_Luong_QD
            ' Loai
            ' STT
            ' Cuoc_Theo_SL
            ' Cuoc_Theo_KL
            ' Cuoc_Khac
            ' Cuoc_VCMBND
            ' Ma_Tien_Te
            ' Tong_Doanh_Thu
            ' Tong_Doanh_Thu_VND
            ' Id_Nguoi_Dung
            ' Id_Trang_Thai
            ' Ghi_Chu
            ' Ngay_He_Thong
            ' Gio_He_Thong
            ' Chot_SL


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_E1_Quoc_Te_Den_Danh_Sach"
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

#Region "DSQT_E1_Quoc_Te_Den_Lay"
        Public Function DSQT_E1_Quoc_Te_Den_Lay(ByVal Id_E1 As String) As DSQT_E1_Quoc_Te_Den_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_E1_Quoc_Te_Den_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_E1_Quoc_Te_Den_Chi_Tiet As New DSQT_E1_Quoc_Te_Den_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                MyCommand.Parameters.Add(pId_E1)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 0)
                pMa_Bc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc)

                Dim pNoi_Gui As SqlParameter = New SqlParameter("@Noi_Gui", SqlDbType.VarChar, 3)
                pNoi_Gui.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNoi_Gui)

                Dim pIMPC As SqlParameter = New SqlParameter("@IMPC", SqlDbType.VarChar, 6)
                pIMPC.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pIMPC)

                Dim pMa_Nuoc_Duong_Thu As SqlParameter = New SqlParameter("@Ma_Nuoc_Duong_Thu", SqlDbType.VarChar, 2)
                pMa_Nuoc_Duong_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Nuoc_Duong_Thu)

                Dim pMa_Nuoc_Thanh_Toan As SqlParameter = New SqlParameter("@Ma_Nuoc_Thanh_Toan", SqlDbType.VarChar, 2)
                pMa_Nuoc_Thanh_Toan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Nuoc_Thanh_Toan)

                Dim pMa_Bc_Thanh_Toan As SqlParameter = New SqlParameter("@Ma_Bc_Thanh_Toan", SqlDbType.Int, 0)
                pMa_Bc_Thanh_Toan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc_Thanh_Toan)

                Dim pIMPC_Thanh_Toan As SqlParameter = New SqlParameter("@IMPC_Thanh_Toan", SqlDbType.VarChar, 6)
                pIMPC_Thanh_Toan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pIMPC_Thanh_Toan)

                Dim pPhan_Loai_Thanh_Toan As SqlParameter = New SqlParameter("@Phan_Loai_Thanh_Toan", SqlDbType.VarChar, 1)
                pPhan_Loai_Thanh_Toan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPhan_Loai_Thanh_Toan)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pLoai_Chuyen_Thu As SqlParameter = New SqlParameter("@Loai_Chuyen_Thu", SqlDbType.VarChar, 2)
                pLoai_Chuyen_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pLoai_Chuyen_Thu)

                Dim pSo_Chuyen_Thu As SqlParameter = New SqlParameter("@So_Chuyen_Thu", SqlDbType.Int, 0)
                pSo_Chuyen_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSo_Chuyen_Thu)

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_E2)

                Dim pTui_So As SqlParameter = New SqlParameter("@Tui_So", SqlDbType.Int, 0)
                pTui_So.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTui_So)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Ca)

                Dim pNgay_Khai_Thac As SqlParameter = New SqlParameter("@Ngay_Khai_Thac", SqlDbType.Int, 0)
                pNgay_Khai_Thac.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Khai_Thac)

                Dim pCa_Khai_Thac As SqlParameter = New SqlParameter("@Ca_Khai_Thac", SqlDbType.Int, 0)
                pCa_Khai_Thac.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCa_Khai_Thac)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_E1)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 0)
                pNgay_Dong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Dong)

                Dim pGio_Dong As SqlParameter = New SqlParameter("@Gio_Dong", SqlDbType.Int, 0)
                pGio_Dong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Dong)

                Dim pNgay_Nhan As SqlParameter = New SqlParameter("@Ngay_Nhan", SqlDbType.Int, 0)
                pNgay_Nhan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Nhan)

                Dim pGio_Nhan As SqlParameter = New SqlParameter("@Gio_Nhan", SqlDbType.Int, 0)
                pGio_Nhan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Nhan)

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 0)
                pMa_Bc_Goc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 0)
                pMa_Bc_Tra.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc_Tra)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNuoc_Nhan)

                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2)
                pNuoc_Tra.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNuoc_Tra)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 0)
                pKhoi_Luong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pKhoi_Luong)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.VarChar, 1)
                pPhan_Loai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pLoai_Hang_Hoa As SqlParameter = New SqlParameter("@Loai_Hang_Hoa", SqlDbType.Int, 0)
                pLoai_Hang_Hoa.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pLoai_Hang_Hoa)

                Dim pKhoi_Luong_QD As SqlParameter = New SqlParameter("@Khoi_Luong_QD", SqlDbType.Int, 0)
                pKhoi_Luong_QD.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pKhoi_Luong_QD)

                Dim pLoai As SqlParameter = New SqlParameter("@Loai", SqlDbType.Int, 0)
                pLoai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pLoai)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSTT)

                Dim pCuoc_Theo_SL As SqlParameter = New SqlParameter("@Cuoc_Theo_SL", SqlDbType.Float, 0)
                pCuoc_Theo_SL.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCuoc_Theo_SL)

                Dim pCuoc_Theo_KL As SqlParameter = New SqlParameter("@Cuoc_Theo_KL", SqlDbType.Float, 0)
                pCuoc_Theo_KL.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCuoc_Theo_KL)

                Dim pCuoc_Khac As SqlParameter = New SqlParameter("@Cuoc_Khac", SqlDbType.Float, 0)
                pCuoc_Khac.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCuoc_Khac)

                Dim pCuoc_VCMBND As SqlParameter = New SqlParameter("@Cuoc_VCMBND", SqlDbType.Float, 0)
                pCuoc_VCMBND.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCuoc_VCMBND)

                Dim pMa_Tien_Te As SqlParameter = New SqlParameter("@Ma_Tien_Te", SqlDbType.VarChar, 5)
                pMa_Tien_Te.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Tien_Te)

                Dim pTong_Doanh_Thu As SqlParameter = New SqlParameter("@Tong_Doanh_Thu", SqlDbType.Float, 0)
                pTong_Doanh_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTong_Doanh_Thu)

                Dim pTong_Doanh_Thu_VND As SqlParameter = New SqlParameter("@Tong_Doanh_Thu_VND", SqlDbType.Int, 0)
                pTong_Doanh_Thu_VND.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTong_Doanh_Thu_VND)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0)
                pId_Nguoi_Dung.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.Int, 0)
                pId_Trang_Thai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Trang_Thai)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 200)
                pGhi_Chu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_He_Thong)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 0)
                pChot_SL.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pChot_SL)

                Dim pId_Dich_Vu As SqlParameter = New SqlParameter("@Id_Dich_Vu", SqlDbType.VarChar, 1)
                pId_Dich_Vu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Dich_Vu)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Id_Duong_Thu = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Ma_Bc = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Noi_Gui = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.IMPC = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Ma_Nuoc_Duong_Thu = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Ma_Nuoc_Thanh_Toan = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Ma_Bc_Thanh_Toan = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.IMPC_Thanh_Toan = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Phan_Loai_Thanh_Toan = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Id_Chuyen_Thu = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Loai_Chuyen_Thu = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.So_Chuyen_Thu = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Id_E2 = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Tui_So = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Id_Ca = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Ngay_Khai_Thac = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Ca_Khai_Thac = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Ma_Bc_Khai_Thac = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Ma_E1 = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Ngay_Dong = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Gio_Dong = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Ngay_Nhan = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Gio_Nhan = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Ma_Bc_Goc = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Ma_Bc_Tra = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Nuoc_Nhan = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Nuoc_Tra = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Khoi_Luong = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Phan_Loai = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Loai_Hang_Hoa = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Khoi_Luong_QD = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Loai = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.STT = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Cuoc_Theo_SL = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Cuoc_Theo_KL = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Cuoc_Khac = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Cuoc_VCMBND = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Ma_Tien_Te = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Tong_Doanh_Thu = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Tong_Doanh_Thu_VND = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Id_Nguoi_Dung = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Id_Trang_Thai = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Ghi_Chu = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Ngay_He_Thong = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Gio_He_Thong = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Chot_SL = pId_Duong_Thu.Value
                myDSQT_E1_Quoc_Te_Den_Chi_Tiet.Id_Dich_Vu = pId_Dich_Vu.Value

                Return myDSQT_E1_Quoc_Te_Den_Chi_Tiet
                'Return myDSQT_E1_Quoc_Te_Den_Chi_Tiet

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

#Region "DSQT_E1_Quoc_Te_Den_Them"
        Public Function DSQT_E1_Quoc_Te_Den_Them(ByVal Id_E1 As String, ByVal Id_Duong_Thu As String, ByVal Ma_Bc As Integer, ByVal Noi_Gui As String, ByVal IMPC As String, ByVal Ma_Nuoc_Duong_Thu As String, ByVal Ma_Nuoc_Thanh_Toan As String, ByVal Ma_Bc_Thanh_Toan As Integer, ByVal IMPC_Thanh_Toan As String, ByVal Phan_Loai_Thanh_Toan As String, ByVal Id_Chuyen_Thu As String, ByVal Loai_Chuyen_Thu As String, ByVal So_Chuyen_Thu As Integer, ByVal Id_E2 As String, ByVal Tui_So As Integer, ByVal Id_Ca As String, ByVal Ngay_Khai_Thac As Integer, ByVal Ca_Khai_Thac As Integer, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_E1 As String, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Ma_Bc_Goc As Integer, ByVal Ma_Bc_Tra As Integer, ByVal Nuoc_Nhan As String, ByVal Nuoc_Tra As String, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal Loai_Hang_Hoa As Integer, ByVal Khoi_Luong_QD As Integer, ByVal Loai As Integer, ByVal STT As Integer, ByVal Cuoc_Theo_SL As Double, ByVal Cuoc_Theo_KL As Double, ByVal Cuoc_Khac As Double, ByVal Cuoc_VCMBND As Double, ByVal Ma_Tien_Te As String, ByVal Tong_Doanh_Thu As Double, ByVal Tong_Doanh_Thu_VND As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Id_Trang_Thai As Integer, ByVal Ghi_Chu As String, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer, ByVal Chot_SL As Boolean, ByVal Id_Dich_Vu As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_E1_Quoc_Te_Den_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_E1_Quoc_Te_Den_Chi_Tiet As New DSQT_E1_Quoc_Te_Den_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                MyCommand.Parameters.Add(pId_E1)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 0)
                pMa_Bc.Value = Ma_Bc
                MyCommand.Parameters.Add(pMa_Bc)

                Dim pNoi_Gui As SqlParameter = New SqlParameter("@Noi_Gui", SqlDbType.VarChar, 3)
                pNoi_Gui.Value = Noi_Gui
                MyCommand.Parameters.Add(pNoi_Gui)

                Dim pIMPC As SqlParameter = New SqlParameter("@IMPC", SqlDbType.VarChar, 6)
                pIMPC.Value = IMPC
                MyCommand.Parameters.Add(pIMPC)

                Dim pMa_Nuoc_Duong_Thu As SqlParameter = New SqlParameter("@Ma_Nuoc_Duong_Thu", SqlDbType.VarChar, 2)
                pMa_Nuoc_Duong_Thu.Value = Ma_Nuoc_Duong_Thu
                MyCommand.Parameters.Add(pMa_Nuoc_Duong_Thu)

                Dim pMa_Nuoc_Thanh_Toan As SqlParameter = New SqlParameter("@Ma_Nuoc_Thanh_Toan", SqlDbType.VarChar, 2)
                pMa_Nuoc_Thanh_Toan.Value = Ma_Nuoc_Thanh_Toan
                MyCommand.Parameters.Add(pMa_Nuoc_Thanh_Toan)

                Dim pMa_Bc_Thanh_Toan As SqlParameter = New SqlParameter("@Ma_Bc_Thanh_Toan", SqlDbType.Int, 0)
                pMa_Bc_Thanh_Toan.Value = Ma_Bc_Thanh_Toan
                MyCommand.Parameters.Add(pMa_Bc_Thanh_Toan)

                Dim pIMPC_Thanh_Toan As SqlParameter = New SqlParameter("@IMPC_Thanh_Toan", SqlDbType.VarChar, 6)
                pIMPC_Thanh_Toan.Value = IMPC_Thanh_Toan
                MyCommand.Parameters.Add(pIMPC_Thanh_Toan)

                Dim pPhan_Loai_Thanh_Toan As SqlParameter = New SqlParameter("@Phan_Loai_Thanh_Toan", SqlDbType.VarChar, 1)
                pPhan_Loai_Thanh_Toan.Value = Phan_Loai_Thanh_Toan
                MyCommand.Parameters.Add(pPhan_Loai_Thanh_Toan)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                MyCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pLoai_Chuyen_Thu As SqlParameter = New SqlParameter("@Loai_Chuyen_Thu", SqlDbType.VarChar, 2)
                pLoai_Chuyen_Thu.Value = Loai_Chuyen_Thu
                MyCommand.Parameters.Add(pLoai_Chuyen_Thu)

                Dim pSo_Chuyen_Thu As SqlParameter = New SqlParameter("@So_Chuyen_Thu", SqlDbType.Int, 0)
                pSo_Chuyen_Thu.Value = So_Chuyen_Thu
                MyCommand.Parameters.Add(pSo_Chuyen_Thu)

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                MyCommand.Parameters.Add(pId_E2)

                Dim pTui_So As SqlParameter = New SqlParameter("@Tui_So", SqlDbType.Int, 0)
                pTui_So.Value = Tui_So
                MyCommand.Parameters.Add(pTui_So)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                MyCommand.Parameters.Add(pId_Ca)

                Dim pNgay_Khai_Thac As SqlParameter = New SqlParameter("@Ngay_Khai_Thac", SqlDbType.Int, 0)
                pNgay_Khai_Thac.Value = Ngay_Khai_Thac
                MyCommand.Parameters.Add(pNgay_Khai_Thac)

                Dim pCa_Khai_Thac As SqlParameter = New SqlParameter("@Ca_Khai_Thac", SqlDbType.Int, 0)
                pCa_Khai_Thac.Value = Ca_Khai_Thac
                MyCommand.Parameters.Add(pCa_Khai_Thac)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                MyCommand.Parameters.Add(pMa_E1)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 0)
                pNgay_Dong.Value = Ngay_Dong
                MyCommand.Parameters.Add(pNgay_Dong)

                Dim pGio_Dong As SqlParameter = New SqlParameter("@Gio_Dong", SqlDbType.Int, 0)
                pGio_Dong.Value = Gio_Dong
                MyCommand.Parameters.Add(pGio_Dong)

                Dim pNgay_Nhan As SqlParameter = New SqlParameter("@Ngay_Nhan", SqlDbType.Int, 0)
                pNgay_Nhan.Value = Ngay_Nhan
                MyCommand.Parameters.Add(pNgay_Nhan)

                Dim pGio_Nhan As SqlParameter = New SqlParameter("@Gio_Nhan", SqlDbType.Int, 0)
                pGio_Nhan.Value = Gio_Nhan
                MyCommand.Parameters.Add(pGio_Nhan)

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 0)
                pMa_Bc_Goc.Value = Ma_Bc_Goc
                MyCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 0)
                pMa_Bc_Tra.Value = Ma_Bc_Tra
                MyCommand.Parameters.Add(pMa_Bc_Tra)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Value = Nuoc_Nhan
                MyCommand.Parameters.Add(pNuoc_Nhan)

                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2)
                pNuoc_Tra.Value = Nuoc_Tra
                MyCommand.Parameters.Add(pNuoc_Tra)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 0)
                pKhoi_Luong.Value = Khoi_Luong
                MyCommand.Parameters.Add(pKhoi_Luong)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.VarChar, 1)
                pPhan_Loai.Value = Phan_Loai
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pLoai_Hang_Hoa As SqlParameter = New SqlParameter("@Loai_Hang_Hoa", SqlDbType.Int, 0)
                pLoai_Hang_Hoa.Value = Loai_Hang_Hoa
                MyCommand.Parameters.Add(pLoai_Hang_Hoa)

                Dim pKhoi_Luong_QD As SqlParameter = New SqlParameter("@Khoi_Luong_QD", SqlDbType.Int, 0)
                pKhoi_Luong_QD.Value = Khoi_Luong_QD
                MyCommand.Parameters.Add(pKhoi_Luong_QD)

                Dim pLoai As SqlParameter = New SqlParameter("@Loai", SqlDbType.Int, 0)
                pLoai.Value = Loai
                MyCommand.Parameters.Add(pLoai)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Value = STT
                MyCommand.Parameters.Add(pSTT)

                Dim pCuoc_Theo_SL As SqlParameter = New SqlParameter("@Cuoc_Theo_SL", SqlDbType.Float, 0)
                pCuoc_Theo_SL.Value = Cuoc_Theo_SL
                MyCommand.Parameters.Add(pCuoc_Theo_SL)

                Dim pCuoc_Theo_KL As SqlParameter = New SqlParameter("@Cuoc_Theo_KL", SqlDbType.Float, 0)
                pCuoc_Theo_KL.Value = Cuoc_Theo_KL
                MyCommand.Parameters.Add(pCuoc_Theo_KL)

                Dim pCuoc_Khac As SqlParameter = New SqlParameter("@Cuoc_Khac", SqlDbType.Float, 0)
                pCuoc_Khac.Value = Cuoc_Khac
                MyCommand.Parameters.Add(pCuoc_Khac)

                Dim pCuoc_VCMBND As SqlParameter = New SqlParameter("@Cuoc_VCMBND", SqlDbType.Float, 0)
                pCuoc_VCMBND.Value = Cuoc_VCMBND
                MyCommand.Parameters.Add(pCuoc_VCMBND)

                Dim pMa_Tien_Te As SqlParameter = New SqlParameter("@Ma_Tien_Te", SqlDbType.VarChar, 5)
                pMa_Tien_Te.Value = Ma_Tien_Te
                MyCommand.Parameters.Add(pMa_Tien_Te)

                Dim pTong_Doanh_Thu As SqlParameter = New SqlParameter("@Tong_Doanh_Thu", SqlDbType.Float, 0)
                pTong_Doanh_Thu.Value = Tong_Doanh_Thu
                MyCommand.Parameters.Add(pTong_Doanh_Thu)

                Dim pTong_Doanh_Thu_VND As SqlParameter = New SqlParameter("@Tong_Doanh_Thu_VND", SqlDbType.Int, 0)
                pTong_Doanh_Thu_VND.Value = Tong_Doanh_Thu_VND
                MyCommand.Parameters.Add(pTong_Doanh_Thu_VND)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                MyCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.Int, 0)
                pId_Trang_Thai.Value = Id_Trang_Thai
                MyCommand.Parameters.Add(pId_Trang_Thai)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 200)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Value = Ngay_He_Thong
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Value = Gio_He_Thong
                MyCommand.Parameters.Add(pGio_He_Thong)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 0)
                pChot_SL.Value = Chot_SL
                MyCommand.Parameters.Add(pChot_SL)

                Dim pId_Dich_Vu As SqlParameter = New SqlParameter("@Id_Dich_Vu", SqlDbType.VarChar, 1)
                pId_Dich_Vu.Value = Id_Dich_Vu
                MyCommand.Parameters.Add(pId_Dich_Vu)


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

#Region "DSQT_E1_Quoc_Te_Den_Xoa"
        Public Function DSQT_E1_Quoc_Te_Den_Xoa(ByVal Id_E1 As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_E1_Quoc_Te_Den_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_E1_Quoc_Te_Den_Chi_Tiet As New DSQT_E1_Quoc_Te_Den_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                MyCommand.Parameters.Add(pId_E1)


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

#Region "DSQT_E1_Quoc_Te_Den_Danh_Sach_Chuyen_Thu_Theo_Ca_Khai_Thac"

        Public Function DSQT_E1_Quoc_Te_Den_Danh_Sach_Chuyen_Thu_Theo_Ca_Khai_Thac(ByVal Id_Ca As String) As DataSet

            ' The procedure returns these columns:
            ' Id_E1
            ' Id_Duong_Thu
            ' Ma_Bc
            ' Noi_Gui
            ' IMPC
            ' Ma_Nuoc_Duong_Thu
            ' Ma_Nuoc_Thanh_Toan
            ' Ma_Bc_Thanh_Toan
            ' IMPC_Thanh_Toan
            ' Phan_Loai_Thanh_Toan
            ' Id_Chuyen_Thu
            ' Loai_Chuyen_Thu
            ' So_Chuyen_Thu
            ' Id_E2
            ' Tui_So
            ' Id_Ca
            ' Ma_Bc_Khai_Thac
            ' Ma_E1
            ' Ngay_Dong
            ' Gio_Dong
            ' Ngay_Nhan
            ' Gio_Nhan
            ' Ma_Bc_Goc
            ' Ma_Bc_Tra
            ' Nuoc_Nhan
            ' Nuoc_Tra
            ' Khoi_Luong
            ' Phan_Loai
            ' Loai_Hang_Hoa
            ' Khoi_Luong_QD
            ' Loai
            ' STT
            ' Cuoc_Theo_SL
            ' Cuoc_Theo_KL
            ' Cuoc_Khac
            ' Cuoc_VCMBND
            ' Ma_Tien_Te
            ' Tong_Doanh_Thu
            ' Tong_Doanh_Thu_VND
            ' Id_Nguoi_Dung
            ' Id_Trang_Thai
            ' Ghi_Chu
            ' Ngay_He_Thong
            ' Gio_He_Thong
            ' Chot_SL


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_E1_Quoc_Te_Den_Danh_Sach_Chuyen_Thu_Theo_Ca_Khai_Thac"
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

#Region "DSQT_E1_Quoc_Te_Den_Danh_Sach_Theo_Chuyen_Thu_Ca_Khai_Thac"

        Public Function DSQT_E1_Quoc_Te_Den_Danh_Sach_Theo_Chuyen_Thu_Ca_Khai_Thac(ByVal Id_Chuyen_Thu As String, ByVal Id_Ca As String) As DataSet

            ' The procedure returns these columns:
            ' Id_E1
            ' Id_Duong_Thu
            ' Ma_Bc
            ' Noi_Gui
            ' IMPC
            ' Ma_Nuoc_Duong_Thu
            ' Ma_Nuoc_Thanh_Toan
            ' Ma_Bc_Thanh_Toan
            ' IMPC_Thanh_Toan
            ' Phan_Loai_Thanh_Toan
            ' Id_Chuyen_Thu
            ' Loai_Chuyen_Thu
            ' So_Chuyen_Thu
            ' Id_E2
            ' Tui_So
            ' Id_Ca
            ' Ma_Bc_Khai_Thac
            ' Ma_E1
            ' Ngay_Dong
            ' Gio_Dong
            ' Ngay_Nhan
            ' Gio_Nhan
            ' Ma_Bc_Goc
            ' Ma_Bc_Tra
            ' Nuoc_Nhan
            ' Nuoc_Tra
            ' Khoi_Luong
            ' Phan_Loai
            ' Loai_Hang_Hoa
            ' Khoi_Luong_QD
            ' Loai
            ' STT
            ' Cuoc_Theo_SL
            ' Cuoc_Theo_KL
            ' Cuoc_Khac
            ' Cuoc_VCMBND
            ' Ma_Tien_Te
            ' Tong_Doanh_Thu
            ' Tong_Doanh_Thu_VND
            ' Id_Nguoi_Dung
            ' Id_Trang_Thai
            ' Ghi_Chu
            ' Ngay_He_Thong
            ' Gio_He_Thong
            ' Chot_SL


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_E1_Quoc_Te_Den_Danh_Sach_Theo_Chuyen_Thu_Ca_Khai_Thac"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters
                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                MyCommand.Parameters.Add(pId_Chuyen_Thu)

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

#Region "DSQT_E1_Quoc_Te_Den_Xoa_Theo_Ca_Khai_Thac"
        Public Function DSQT_E1_Quoc_Te_Den_Xoa_Theo_Ca_Khai_Thac(ByVal Id_Ca As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_E1_Quoc_Te_Den_Xoa_Theo_Ca_Khai_Thac"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_E1_Quoc_Te_Den_Chi_Tiet As New DSQT_E1_Quoc_Te_Den_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                MyCommand.Parameters.Add(pId_Ca)


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


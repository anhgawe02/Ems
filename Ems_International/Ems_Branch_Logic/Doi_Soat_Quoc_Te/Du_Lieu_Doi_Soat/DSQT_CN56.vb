
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "DSQT_CN56_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop DSQT_CN56_Chi_Tiet
    'Tuong ung voi moi truong trong bang DSQT_CN56 trong co so du lieu
    '***********************************************************
    Public Class DSQT_CN56_Chi_Tiet
        Public Id_CN56 As String
        Public Thang As Integer
        Public Quy As Integer
        Public Nam As Integer
        Public Id_Duong_Thu As String
        Public Ma_Nuoc_Duong_Thu As String
        Public Ma_Nuoc_Thanh_Toan As String
        Public Ma_Bc_Thanh_Toan As Integer
        Public IMPC_Thanh_Toan As String
        Public Ma_Bc_Khai_Thac As Integer
        Public Nuoc_Gui As String
        Public Bc_Gui As Integer
        Public Nuoc_Nhan As String
        Public Bc_Nhan As Integer
        Public SL_Chuyen_Thu As Integer
        Public So_Luong_D As Integer
        Public Khoi_Luong_D As Integer
        Public So_Luong_M As Integer
        Public Khoi_Luong_M As Integer
        Public So_Luong_R As Integer
        Public Khoi_Luong_R As Integer
        Public So_Luong_OPS As Integer
        Public Khoi_Luong_OPS As Integer
        Public Khoi_Luong_Vo_Tui As Integer
        Public Cuoc_Theo_SL As Double
        Public Cuoc_Theo_KL As Double
        Public Cuoc_VCMBND As Double
        Public Cuoc_Hang_Khong As Double
        Public Cuoc_Khac As Double
        Public Ma_Tien_Te As String
        Public Doanh_Thu_D As Double
        Public Doanh_Thu_M As Double
        Public Tong_Doanh_Thu As Double
        Public Tong_Doanh_Thu_VND As Integer
        Public Hang_Van_Chuyen As String
        Public Ghi_Chu As String
        Public I_O As Integer
        Public Chot_SL As Boolean
        Public Ngay_He_Thong As Integer
        Public Gio_He_Thong As Integer
    End Class
#End Region

#Region "DSQT_CN56"
    Public Class DSQT_CN56
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "DSQT_CN56_Cap_Nhat"
        Public Function DSQT_CN56_Cap_Nhat(ByVal Id_CN56 As String, ByVal Thang As Integer, ByVal Quy As Integer, ByVal Nam As Integer, ByVal Id_Duong_Thu As String, ByVal Ma_Nuoc_Duong_Thu As String, ByVal Ma_Nuoc_Thanh_Toan As String, ByVal Ma_Bc_Thanh_Toan As Integer, ByVal IMPC_Thanh_Toan As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Nuoc_Gui As String, ByVal Bc_Gui As Integer, ByVal Nuoc_Nhan As String, ByVal Bc_Nhan As Integer, ByVal SL_Chuyen_Thu As Integer, ByVal So_Luong_D As Integer, ByVal Khoi_Luong_D As Integer, ByVal So_Luong_M As Integer, ByVal Khoi_Luong_M As Integer, ByVal So_Luong_R As Integer, ByVal Khoi_Luong_R As Integer, ByVal So_Luong_OPS As Integer, ByVal Khoi_Luong_OPS As Integer, ByVal Khoi_Luong_Vo_Tui As Integer, ByVal Cuoc_Theo_SL As Double, ByVal Cuoc_Theo_KL As Double, ByVal Cuoc_VCMBND As Double, ByVal Cuoc_Hang_Khong As Double, ByVal Cuoc_Khac As Double, ByVal Ma_Tien_Te As String, ByVal Doanh_Thu_D As Double, ByVal Doanh_Thu_M As Double, ByVal Tong_Doanh_Thu As Double, ByVal Tong_Doanh_Thu_VND As Integer, ByVal Hang_Van_Chuyen As String, ByVal Ghi_Chu As String, ByVal I_O As Integer, ByVal Chot_SL As Boolean, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_CN56_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_CN56_Chi_Tiet As New DSQT_CN56_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_CN56 As SqlParameter = New SqlParameter("@Id_CN56", SqlDbType.VarChar, 50)
                pId_CN56.Value = Id_CN56
                MyCommand.Parameters.Add(pId_CN56)

                Dim pThang As SqlParameter = New SqlParameter("@Thang", SqlDbType.Int, 0)
                pThang.Value = Thang
                MyCommand.Parameters.Add(pThang)

                Dim pQuy As SqlParameter = New SqlParameter("@Quy", SqlDbType.Int, 0)
                pQuy.Value = Quy
                MyCommand.Parameters.Add(pQuy)

                Dim pNam As SqlParameter = New SqlParameter("@Nam", SqlDbType.Int, 0)
                pNam.Value = Nam
                MyCommand.Parameters.Add(pNam)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pId_Duong_Thu)

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

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pNuoc_Gui As SqlParameter = New SqlParameter("@Nuoc_Gui", SqlDbType.VarChar, 2)
                pNuoc_Gui.Value = Nuoc_Gui
                MyCommand.Parameters.Add(pNuoc_Gui)

                Dim pBc_Gui As SqlParameter = New SqlParameter("@Bc_Gui", SqlDbType.Int, 0)
                pBc_Gui.Value = Bc_Gui
                MyCommand.Parameters.Add(pBc_Gui)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Value = Nuoc_Nhan
                MyCommand.Parameters.Add(pNuoc_Nhan)

                Dim pBc_Nhan As SqlParameter = New SqlParameter("@Bc_Nhan", SqlDbType.Int, 0)
                pBc_Nhan.Value = Bc_Nhan
                MyCommand.Parameters.Add(pBc_Nhan)

                Dim pSL_Chuyen_Thu As SqlParameter = New SqlParameter("@SL_Chuyen_Thu", SqlDbType.Int, 0)
                pSL_Chuyen_Thu.Value = SL_Chuyen_Thu
                MyCommand.Parameters.Add(pSL_Chuyen_Thu)

                Dim pSo_Luong_D As SqlParameter = New SqlParameter("@So_Luong_D", SqlDbType.Int, 0)
                pSo_Luong_D.Value = So_Luong_D
                MyCommand.Parameters.Add(pSo_Luong_D)

                Dim pKhoi_Luong_D As SqlParameter = New SqlParameter("@Khoi_Luong_D", SqlDbType.Int, 0)
                pKhoi_Luong_D.Value = Khoi_Luong_D
                MyCommand.Parameters.Add(pKhoi_Luong_D)

                Dim pSo_Luong_M As SqlParameter = New SqlParameter("@So_Luong_M", SqlDbType.Int, 0)
                pSo_Luong_M.Value = So_Luong_M
                MyCommand.Parameters.Add(pSo_Luong_M)

                Dim pKhoi_Luong_M As SqlParameter = New SqlParameter("@Khoi_Luong_M", SqlDbType.Int, 0)
                pKhoi_Luong_M.Value = Khoi_Luong_M
                MyCommand.Parameters.Add(pKhoi_Luong_M)

                Dim pSo_Luong_R As SqlParameter = New SqlParameter("@So_Luong_R", SqlDbType.Int, 0)
                pSo_Luong_R.Value = So_Luong_R
                MyCommand.Parameters.Add(pSo_Luong_R)

                Dim pKhoi_Luong_R As SqlParameter = New SqlParameter("@Khoi_Luong_R", SqlDbType.Int, 0)
                pKhoi_Luong_R.Value = Khoi_Luong_R
                MyCommand.Parameters.Add(pKhoi_Luong_R)

                Dim pSo_Luong_OPS As SqlParameter = New SqlParameter("@So_Luong_OPS", SqlDbType.Int, 0)
                pSo_Luong_OPS.Value = So_Luong_OPS
                MyCommand.Parameters.Add(pSo_Luong_OPS)

                Dim pKhoi_Luong_OPS As SqlParameter = New SqlParameter("@Khoi_Luong_OPS", SqlDbType.Int, 0)
                pKhoi_Luong_OPS.Value = Khoi_Luong_OPS
                MyCommand.Parameters.Add(pKhoi_Luong_OPS)

                Dim pKhoi_Luong_Vo_Tui As SqlParameter = New SqlParameter("@Khoi_Luong_Vo_Tui", SqlDbType.Int, 0)
                pKhoi_Luong_Vo_Tui.Value = Khoi_Luong_Vo_Tui
                MyCommand.Parameters.Add(pKhoi_Luong_Vo_Tui)

                Dim pCuoc_Theo_SL As SqlParameter = New SqlParameter("@Cuoc_Theo_SL", SqlDbType.Float, 0)
                pCuoc_Theo_SL.Value = Cuoc_Theo_SL
                MyCommand.Parameters.Add(pCuoc_Theo_SL)

                Dim pCuoc_Theo_KL As SqlParameter = New SqlParameter("@Cuoc_Theo_KL", SqlDbType.Float, 0)
                pCuoc_Theo_KL.Value = Cuoc_Theo_KL
                MyCommand.Parameters.Add(pCuoc_Theo_KL)

                Dim pCuoc_VCMBND As SqlParameter = New SqlParameter("@Cuoc_VCMBND", SqlDbType.Float, 0)
                pCuoc_VCMBND.Value = Cuoc_VCMBND
                MyCommand.Parameters.Add(pCuoc_VCMBND)

                Dim pCuoc_Hang_Khong As SqlParameter = New SqlParameter("@Cuoc_Hang_Khong", SqlDbType.Float, 0)
                pCuoc_Hang_Khong.Value = Cuoc_Hang_Khong
                MyCommand.Parameters.Add(pCuoc_Hang_Khong)

                Dim pCuoc_Khac As SqlParameter = New SqlParameter("@Cuoc_Khac", SqlDbType.Float, 0)
                pCuoc_Khac.Value = Cuoc_Khac
                MyCommand.Parameters.Add(pCuoc_Khac)

                Dim pMa_Tien_Te As SqlParameter = New SqlParameter("@Ma_Tien_Te", SqlDbType.VarChar, 5)
                pMa_Tien_Te.Value = Ma_Tien_Te
                MyCommand.Parameters.Add(pMa_Tien_Te)

                Dim pDoanh_Thu_D As SqlParameter = New SqlParameter("@Doanh_Thu_D", SqlDbType.Float, 0)
                pDoanh_Thu_D.Value = Doanh_Thu_D
                MyCommand.Parameters.Add(pDoanh_Thu_D)

                Dim pDoanh_Thu_M As SqlParameter = New SqlParameter("@Doanh_Thu_M", SqlDbType.Float, 0)
                pDoanh_Thu_M.Value = Doanh_Thu_M
                MyCommand.Parameters.Add(pDoanh_Thu_M)

                Dim pTong_Doanh_Thu As SqlParameter = New SqlParameter("@Tong_Doanh_Thu", SqlDbType.Float, 0)
                pTong_Doanh_Thu.Value = Tong_Doanh_Thu
                MyCommand.Parameters.Add(pTong_Doanh_Thu)

                Dim pTong_Doanh_Thu_VND As SqlParameter = New SqlParameter("@Tong_Doanh_Thu_VND", SqlDbType.Int, 0)
                pTong_Doanh_Thu_VND.Value = Tong_Doanh_Thu_VND
                MyCommand.Parameters.Add(pTong_Doanh_Thu_VND)

                Dim pHang_Van_Chuyen As SqlParameter = New SqlParameter("@Hang_Van_Chuyen", SqlDbType.VarChar, 50)
                pHang_Van_Chuyen.Value = Hang_Van_Chuyen
                MyCommand.Parameters.Add(pHang_Van_Chuyen)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 100)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pI_O As SqlParameter = New SqlParameter("@I_O", SqlDbType.Int, 0)
                pI_O.Value = I_O
                MyCommand.Parameters.Add(pI_O)

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

#Region "DSQT_CN56_Cap_Nhat_Them"
        Public Function DSQT_CN56_Cap_Nhat_Them(ByVal Id_CN56 As String, ByVal Thang As Integer, ByVal Quy As Integer, ByVal Nam As Integer, ByVal Id_Duong_Thu As String, ByVal Ma_Nuoc_Duong_Thu As String, ByVal Ma_Nuoc_Thanh_Toan As String, ByVal Ma_Bc_Thanh_Toan As Integer, ByVal IMPC_Thanh_Toan As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Nuoc_Gui As String, ByVal Bc_Gui As Integer, ByVal Nuoc_Nhan As String, ByVal Bc_Nhan As Integer, ByVal SL_Chuyen_Thu As Integer, ByVal So_Luong_D As Integer, ByVal Khoi_Luong_D As Integer, ByVal So_Luong_M As Integer, ByVal Khoi_Luong_M As Integer, ByVal So_Luong_R As Integer, ByVal Khoi_Luong_R As Integer, ByVal So_Luong_OPS As Integer, ByVal Khoi_Luong_OPS As Integer, ByVal Khoi_Luong_Vo_Tui As Integer, ByVal Cuoc_Theo_SL As Double, ByVal Cuoc_Theo_KL As Double, ByVal Cuoc_VCMBND As Double, ByVal Cuoc_Hang_Khong As Double, ByVal Cuoc_Khac As Double, ByVal Ma_Tien_Te As String, ByVal Doanh_Thu_D As Double, ByVal Doanh_Thu_M As Double, ByVal Tong_Doanh_Thu As Double, ByVal Tong_Doanh_Thu_VND As Integer, ByVal Hang_Van_Chuyen As String, ByVal Ghi_Chu As String, ByVal I_O As Integer, ByVal Chot_SL As Boolean, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_CN56_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_CN56_Chi_Tiet As New DSQT_CN56_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_CN56 As SqlParameter = New SqlParameter("@Id_CN56", SqlDbType.VarChar, 50)
                pId_CN56.Value = Id_CN56
                MyCommand.Parameters.Add(pId_CN56)

                Dim pThang As SqlParameter = New SqlParameter("@Thang", SqlDbType.Int, 0)
                pThang.Value = Thang
                MyCommand.Parameters.Add(pThang)

                Dim pQuy As SqlParameter = New SqlParameter("@Quy", SqlDbType.Int, 0)
                pQuy.Value = Quy
                MyCommand.Parameters.Add(pQuy)

                Dim pNam As SqlParameter = New SqlParameter("@Nam", SqlDbType.Int, 0)
                pNam.Value = Nam
                MyCommand.Parameters.Add(pNam)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pId_Duong_Thu)

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

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pNuoc_Gui As SqlParameter = New SqlParameter("@Nuoc_Gui", SqlDbType.VarChar, 2)
                pNuoc_Gui.Value = Nuoc_Gui
                MyCommand.Parameters.Add(pNuoc_Gui)

                Dim pBc_Gui As SqlParameter = New SqlParameter("@Bc_Gui", SqlDbType.Int, 0)
                pBc_Gui.Value = Bc_Gui
                MyCommand.Parameters.Add(pBc_Gui)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Value = Nuoc_Nhan
                MyCommand.Parameters.Add(pNuoc_Nhan)

                Dim pBc_Nhan As SqlParameter = New SqlParameter("@Bc_Nhan", SqlDbType.Int, 0)
                pBc_Nhan.Value = Bc_Nhan
                MyCommand.Parameters.Add(pBc_Nhan)

                Dim pSL_Chuyen_Thu As SqlParameter = New SqlParameter("@SL_Chuyen_Thu", SqlDbType.Int, 0)
                pSL_Chuyen_Thu.Value = SL_Chuyen_Thu
                MyCommand.Parameters.Add(pSL_Chuyen_Thu)

                Dim pSo_Luong_D As SqlParameter = New SqlParameter("@So_Luong_D", SqlDbType.Int, 0)
                pSo_Luong_D.Value = So_Luong_D
                MyCommand.Parameters.Add(pSo_Luong_D)

                Dim pKhoi_Luong_D As SqlParameter = New SqlParameter("@Khoi_Luong_D", SqlDbType.Int, 0)
                pKhoi_Luong_D.Value = Khoi_Luong_D
                MyCommand.Parameters.Add(pKhoi_Luong_D)

                Dim pSo_Luong_M As SqlParameter = New SqlParameter("@So_Luong_M", SqlDbType.Int, 0)
                pSo_Luong_M.Value = So_Luong_M
                MyCommand.Parameters.Add(pSo_Luong_M)

                Dim pKhoi_Luong_M As SqlParameter = New SqlParameter("@Khoi_Luong_M", SqlDbType.Int, 0)
                pKhoi_Luong_M.Value = Khoi_Luong_M
                MyCommand.Parameters.Add(pKhoi_Luong_M)

                Dim pSo_Luong_R As SqlParameter = New SqlParameter("@So_Luong_R", SqlDbType.Int, 0)
                pSo_Luong_R.Value = So_Luong_R
                MyCommand.Parameters.Add(pSo_Luong_R)

                Dim pKhoi_Luong_R As SqlParameter = New SqlParameter("@Khoi_Luong_R", SqlDbType.Int, 0)
                pKhoi_Luong_R.Value = Khoi_Luong_R
                MyCommand.Parameters.Add(pKhoi_Luong_R)

                Dim pSo_Luong_OPS As SqlParameter = New SqlParameter("@So_Luong_OPS", SqlDbType.Int, 0)
                pSo_Luong_OPS.Value = So_Luong_OPS
                MyCommand.Parameters.Add(pSo_Luong_OPS)

                Dim pKhoi_Luong_OPS As SqlParameter = New SqlParameter("@Khoi_Luong_OPS", SqlDbType.Int, 0)
                pKhoi_Luong_OPS.Value = Khoi_Luong_OPS
                MyCommand.Parameters.Add(pKhoi_Luong_OPS)

                Dim pKhoi_Luong_Vo_Tui As SqlParameter = New SqlParameter("@Khoi_Luong_Vo_Tui", SqlDbType.Int, 0)
                pKhoi_Luong_Vo_Tui.Value = Khoi_Luong_Vo_Tui
                MyCommand.Parameters.Add(pKhoi_Luong_Vo_Tui)

                Dim pCuoc_Theo_SL As SqlParameter = New SqlParameter("@Cuoc_Theo_SL", SqlDbType.Float, 0)
                pCuoc_Theo_SL.Value = Cuoc_Theo_SL
                MyCommand.Parameters.Add(pCuoc_Theo_SL)

                Dim pCuoc_Theo_KL As SqlParameter = New SqlParameter("@Cuoc_Theo_KL", SqlDbType.Float, 0)
                pCuoc_Theo_KL.Value = Cuoc_Theo_KL
                MyCommand.Parameters.Add(pCuoc_Theo_KL)

                Dim pCuoc_VCMBND As SqlParameter = New SqlParameter("@Cuoc_VCMBND", SqlDbType.Float, 0)
                pCuoc_VCMBND.Value = Cuoc_VCMBND
                MyCommand.Parameters.Add(pCuoc_VCMBND)

                Dim pCuoc_Hang_Khong As SqlParameter = New SqlParameter("@Cuoc_Hang_Khong", SqlDbType.Float, 0)
                pCuoc_Hang_Khong.Value = Cuoc_Hang_Khong
                MyCommand.Parameters.Add(pCuoc_Hang_Khong)

                Dim pCuoc_Khac As SqlParameter = New SqlParameter("@Cuoc_Khac", SqlDbType.Float, 0)
                pCuoc_Khac.Value = Cuoc_Khac
                MyCommand.Parameters.Add(pCuoc_Khac)

                Dim pMa_Tien_Te As SqlParameter = New SqlParameter("@Ma_Tien_Te", SqlDbType.VarChar, 5)
                pMa_Tien_Te.Value = Ma_Tien_Te
                MyCommand.Parameters.Add(pMa_Tien_Te)

                Dim pDoanh_Thu_D As SqlParameter = New SqlParameter("@Doanh_Thu_D", SqlDbType.Float, 0)
                pDoanh_Thu_D.Value = Doanh_Thu_D
                MyCommand.Parameters.Add(pDoanh_Thu_D)

                Dim pDoanh_Thu_M As SqlParameter = New SqlParameter("@Doanh_Thu_M", SqlDbType.Float, 0)
                pDoanh_Thu_M.Value = Doanh_Thu_M
                MyCommand.Parameters.Add(pDoanh_Thu_M)

                Dim pTong_Doanh_Thu As SqlParameter = New SqlParameter("@Tong_Doanh_Thu", SqlDbType.Float, 0)
                pTong_Doanh_Thu.Value = Tong_Doanh_Thu
                MyCommand.Parameters.Add(pTong_Doanh_Thu)

                Dim pTong_Doanh_Thu_VND As SqlParameter = New SqlParameter("@Tong_Doanh_Thu_VND", SqlDbType.Int, 0)
                pTong_Doanh_Thu_VND.Value = Tong_Doanh_Thu_VND
                MyCommand.Parameters.Add(pTong_Doanh_Thu_VND)

                Dim pHang_Van_Chuyen As SqlParameter = New SqlParameter("@Hang_Van_Chuyen", SqlDbType.VarChar, 50)
                pHang_Van_Chuyen.Value = Hang_Van_Chuyen
                MyCommand.Parameters.Add(pHang_Van_Chuyen)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 100)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pI_O As SqlParameter = New SqlParameter("@I_O", SqlDbType.Int, 0)
                pI_O.Value = I_O
                MyCommand.Parameters.Add(pI_O)

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


#Region "DSQT_CN56_Danh_Sach"

        Public Function DSQT_CN56_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Id_CN56
            ' Thang
            ' Quy
            ' Nam
            ' Id_Duong_Thu
            ' Ma_Nuoc_Duong_Thu
            ' Ma_Nuoc_Thanh_Toan
            ' Ma_Bc_Thanh_Toan
            ' IMPC_Thanh_Toan
            ' Ma_Bc_Khai_Thac
            ' Nuoc_Gui
            ' Bc_Gui
            ' Nuoc_Nhan
            ' Bc_Nhan
            ' SL_Chuyen_Thu
            ' So_Luong_D
            ' Khoi_Luong_D
            ' So_Luong_M
            ' Khoi_Luong_M
            ' So_Luong_R
            ' Khoi_Luong_R
            ' So_Luong_OPS
            ' Khoi_Luong_OPS
            ' Khoi_Luong_Vo_Tui
            ' Cuoc_Theo_SL
            ' Cuoc_Theo_KL
            ' Cuoc_VCMBND
            ' Cuoc_Hang_Khong
            ' Cuoc_Khac
            ' Ma_Tien_Te
            ' Doanh_Thu_D
            ' Doanh_Thu_M
            ' Tong_Doanh_Thu
            ' Tong_Doanh_Thu_VND
            ' Hang_Van_Chuyen
            ' Ghi_Chu
            ' I_O
            ' Chot_SL
            ' Ngay_He_Thong
            ' Gio_He_Thong


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_CN56_Danh_Sach"
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

#Region "DSQT_CN56_Lay"
        Public Function DSQT_CN56_Lay(ByVal Id_CN56 As String) As DSQT_CN56_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_CN56_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_CN56_Chi_Tiet As New DSQT_CN56_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_CN56 As SqlParameter = New SqlParameter("@Id_CN56", SqlDbType.VarChar, 50)
                pId_CN56.Value = Id_CN56
                MyCommand.Parameters.Add(pId_CN56)

                Dim pThang As SqlParameter = New SqlParameter("@Thang", SqlDbType.Int, 0)
                pThang.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThang)

                Dim pQuy As SqlParameter = New SqlParameter("@Quy", SqlDbType.Int, 0)
                pQuy.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pQuy)

                Dim pNam As SqlParameter = New SqlParameter("@Nam", SqlDbType.Int, 0)
                pNam.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNam)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Duong_Thu)

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

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pNuoc_Gui As SqlParameter = New SqlParameter("@Nuoc_Gui", SqlDbType.VarChar, 2)
                pNuoc_Gui.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNuoc_Gui)

                Dim pBc_Gui As SqlParameter = New SqlParameter("@Bc_Gui", SqlDbType.Int, 0)
                pBc_Gui.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pBc_Gui)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNuoc_Nhan)

                Dim pBc_Nhan As SqlParameter = New SqlParameter("@Bc_Nhan", SqlDbType.Int, 0)
                pBc_Nhan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pBc_Nhan)

                Dim pSL_Chuyen_Thu As SqlParameter = New SqlParameter("@SL_Chuyen_Thu", SqlDbType.Int, 0)
                pSL_Chuyen_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSL_Chuyen_Thu)

                Dim pSo_Luong_D As SqlParameter = New SqlParameter("@So_Luong_D", SqlDbType.Int, 0)
                pSo_Luong_D.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSo_Luong_D)

                Dim pKhoi_Luong_D As SqlParameter = New SqlParameter("@Khoi_Luong_D", SqlDbType.Int, 0)
                pKhoi_Luong_D.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pKhoi_Luong_D)

                Dim pSo_Luong_M As SqlParameter = New SqlParameter("@So_Luong_M", SqlDbType.Int, 0)
                pSo_Luong_M.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSo_Luong_M)

                Dim pKhoi_Luong_M As SqlParameter = New SqlParameter("@Khoi_Luong_M", SqlDbType.Int, 0)
                pKhoi_Luong_M.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pKhoi_Luong_M)

                Dim pSo_Luong_R As SqlParameter = New SqlParameter("@So_Luong_R", SqlDbType.Int, 0)
                pSo_Luong_R.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSo_Luong_R)

                Dim pKhoi_Luong_R As SqlParameter = New SqlParameter("@Khoi_Luong_R", SqlDbType.Int, 0)
                pKhoi_Luong_R.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pKhoi_Luong_R)

                Dim pSo_Luong_OPS As SqlParameter = New SqlParameter("@So_Luong_OPS", SqlDbType.Int, 0)
                pSo_Luong_OPS.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSo_Luong_OPS)

                Dim pKhoi_Luong_OPS As SqlParameter = New SqlParameter("@Khoi_Luong_OPS", SqlDbType.Int, 0)
                pKhoi_Luong_OPS.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pKhoi_Luong_OPS)

                Dim pKhoi_Luong_Vo_Tui As SqlParameter = New SqlParameter("@Khoi_Luong_Vo_Tui", SqlDbType.Int, 0)
                pKhoi_Luong_Vo_Tui.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pKhoi_Luong_Vo_Tui)

                Dim pCuoc_Theo_SL As SqlParameter = New SqlParameter("@Cuoc_Theo_SL", SqlDbType.Float, 0)
                pCuoc_Theo_SL.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCuoc_Theo_SL)

                Dim pCuoc_Theo_KL As SqlParameter = New SqlParameter("@Cuoc_Theo_KL", SqlDbType.Float, 0)
                pCuoc_Theo_KL.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCuoc_Theo_KL)

                Dim pCuoc_VCMBND As SqlParameter = New SqlParameter("@Cuoc_VCMBND", SqlDbType.Float, 0)
                pCuoc_VCMBND.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCuoc_VCMBND)

                Dim pCuoc_Hang_Khong As SqlParameter = New SqlParameter("@Cuoc_Hang_Khong", SqlDbType.Float, 0)
                pCuoc_Hang_Khong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCuoc_Hang_Khong)

                Dim pCuoc_Khac As SqlParameter = New SqlParameter("@Cuoc_Khac", SqlDbType.Float, 0)
                pCuoc_Khac.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCuoc_Khac)

                Dim pMa_Tien_Te As SqlParameter = New SqlParameter("@Ma_Tien_Te", SqlDbType.VarChar, 5)
                pMa_Tien_Te.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Tien_Te)

                Dim pDoanh_Thu_D As SqlParameter = New SqlParameter("@Doanh_Thu_D", SqlDbType.Float, 0)
                pDoanh_Thu_D.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDoanh_Thu_D)

                Dim pDoanh_Thu_M As SqlParameter = New SqlParameter("@Doanh_Thu_M", SqlDbType.Float, 0)
                pDoanh_Thu_M.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDoanh_Thu_M)

                Dim pTong_Doanh_Thu As SqlParameter = New SqlParameter("@Tong_Doanh_Thu", SqlDbType.Float, 0)
                pTong_Doanh_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTong_Doanh_Thu)

                Dim pTong_Doanh_Thu_VND As SqlParameter = New SqlParameter("@Tong_Doanh_Thu_VND", SqlDbType.Int, 0)
                pTong_Doanh_Thu_VND.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTong_Doanh_Thu_VND)

                Dim pHang_Van_Chuyen As SqlParameter = New SqlParameter("@Hang_Van_Chuyen", SqlDbType.VarChar, 50)
                pHang_Van_Chuyen.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pHang_Van_Chuyen)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 100)
                pGhi_Chu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pI_O As SqlParameter = New SqlParameter("@I_O", SqlDbType.Int, 0)
                pI_O.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pI_O)

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
                myDSQT_CN56_Chi_Tiet.Id_CN56 = Id_CN56
                myDSQT_CN56_Chi_Tiet.Thang = pThang.Value
                myDSQT_CN56_Chi_Tiet.Quy = pQuy.Value
                myDSQT_CN56_Chi_Tiet.Nam = pNam.Value
                myDSQT_CN56_Chi_Tiet.Id_Duong_Thu = pId_Duong_Thu.Value
                myDSQT_CN56_Chi_Tiet.Ma_Nuoc_Duong_Thu = pMa_Nuoc_Duong_Thu.Value
                myDSQT_CN56_Chi_Tiet.Ma_Nuoc_Thanh_Toan = pMa_Nuoc_Thanh_Toan.Value
                myDSQT_CN56_Chi_Tiet.Ma_Bc_Thanh_Toan = pMa_Bc_Thanh_Toan.Value
                myDSQT_CN56_Chi_Tiet.IMPC_Thanh_Toan = pIMPC_Thanh_Toan.Value
                myDSQT_CN56_Chi_Tiet.Ma_Bc_Khai_Thac = pMa_Bc_Khai_Thac.Value
                myDSQT_CN56_Chi_Tiet.Nuoc_Gui = pNuoc_Gui.Value
                myDSQT_CN56_Chi_Tiet.Bc_Gui = pBc_Gui.Value
                myDSQT_CN56_Chi_Tiet.Nuoc_Nhan = pNuoc_Nhan.Value
                myDSQT_CN56_Chi_Tiet.Bc_Nhan = pBc_Nhan.Value
                myDSQT_CN56_Chi_Tiet.SL_Chuyen_Thu = pSL_Chuyen_Thu.Value
                myDSQT_CN56_Chi_Tiet.So_Luong_D = pSo_Luong_D.Value
                myDSQT_CN56_Chi_Tiet.Khoi_Luong_D = pKhoi_Luong_D.Value
                myDSQT_CN56_Chi_Tiet.So_Luong_M = pSo_Luong_M.Value
                myDSQT_CN56_Chi_Tiet.Khoi_Luong_M = pKhoi_Luong_M.Value
                myDSQT_CN56_Chi_Tiet.So_Luong_R = pSo_Luong_R.Value
                myDSQT_CN56_Chi_Tiet.Khoi_Luong_R = pKhoi_Luong_R.Value
                myDSQT_CN56_Chi_Tiet.So_Luong_OPS = pSo_Luong_OPS.Value
                myDSQT_CN56_Chi_Tiet.Khoi_Luong_OPS = pKhoi_Luong_OPS.Value
                myDSQT_CN56_Chi_Tiet.Khoi_Luong_Vo_Tui = pKhoi_Luong_Vo_Tui.Value
                myDSQT_CN56_Chi_Tiet.Cuoc_Theo_SL = pCuoc_Theo_SL.Value
                myDSQT_CN56_Chi_Tiet.Cuoc_Theo_KL = pCuoc_Theo_KL.Value
                myDSQT_CN56_Chi_Tiet.Cuoc_VCMBND = pCuoc_VCMBND.Value
                myDSQT_CN56_Chi_Tiet.Cuoc_Hang_Khong = pCuoc_Hang_Khong.Value
                myDSQT_CN56_Chi_Tiet.Cuoc_Khac = pCuoc_Khac.Value
                myDSQT_CN56_Chi_Tiet.Ma_Tien_Te = pMa_Tien_Te.Value
                myDSQT_CN56_Chi_Tiet.Doanh_Thu_D = pDoanh_Thu_D.Value
                myDSQT_CN56_Chi_Tiet.Doanh_Thu_M = pDoanh_Thu_M.Value
                myDSQT_CN56_Chi_Tiet.Tong_Doanh_Thu = pTong_Doanh_Thu.Value
                myDSQT_CN56_Chi_Tiet.Tong_Doanh_Thu_VND = pTong_Doanh_Thu_VND.Value
                myDSQT_CN56_Chi_Tiet.Hang_Van_Chuyen = pHang_Van_Chuyen.Value
                myDSQT_CN56_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value
                myDSQT_CN56_Chi_Tiet.I_O = pI_O.Value
                myDSQT_CN56_Chi_Tiet.Chot_SL = pChot_SL.Value
                myDSQT_CN56_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myDSQT_CN56_Chi_Tiet.Gio_He_Thong = pGio_He_Thong.Value
                myDSQT_CN56_Chi_Tiet.Thang = pThang.Value
                myDSQT_CN56_Chi_Tiet.Quy = pQuy.Value
                myDSQT_CN56_Chi_Tiet.Nam = pNam.Value
                myDSQT_CN56_Chi_Tiet.Id_Duong_Thu = pId_Duong_Thu.Value
                myDSQT_CN56_Chi_Tiet.Ma_Nuoc_Duong_Thu = pMa_Nuoc_Duong_Thu.Value
                myDSQT_CN56_Chi_Tiet.Ma_Nuoc_Thanh_Toan = pMa_Nuoc_Thanh_Toan.Value
                myDSQT_CN56_Chi_Tiet.Ma_Bc_Thanh_Toan = pMa_Bc_Thanh_Toan.Value
                myDSQT_CN56_Chi_Tiet.IMPC_Thanh_Toan = pIMPC_Thanh_Toan.Value
                myDSQT_CN56_Chi_Tiet.Ma_Bc_Khai_Thac = pMa_Bc_Khai_Thac.Value
                myDSQT_CN56_Chi_Tiet.Nuoc_Gui = pNuoc_Gui.Value
                myDSQT_CN56_Chi_Tiet.Bc_Gui = pBc_Gui.Value
                myDSQT_CN56_Chi_Tiet.Nuoc_Nhan = pNuoc_Nhan.Value
                myDSQT_CN56_Chi_Tiet.Bc_Nhan = pBc_Nhan.Value
                myDSQT_CN56_Chi_Tiet.SL_Chuyen_Thu = pSL_Chuyen_Thu.Value
                myDSQT_CN56_Chi_Tiet.So_Luong_D = pSo_Luong_D.Value
                myDSQT_CN56_Chi_Tiet.Khoi_Luong_D = pKhoi_Luong_D.Value
                myDSQT_CN56_Chi_Tiet.So_Luong_M = pSo_Luong_M.Value
                myDSQT_CN56_Chi_Tiet.Khoi_Luong_M = pKhoi_Luong_M.Value
                myDSQT_CN56_Chi_Tiet.So_Luong_R = pSo_Luong_R.Value
                myDSQT_CN56_Chi_Tiet.Khoi_Luong_R = pKhoi_Luong_R.Value
                myDSQT_CN56_Chi_Tiet.So_Luong_OPS = pSo_Luong_OPS.Value
                myDSQT_CN56_Chi_Tiet.Khoi_Luong_OPS = pKhoi_Luong_OPS.Value
                myDSQT_CN56_Chi_Tiet.Khoi_Luong_Vo_Tui = pKhoi_Luong_Vo_Tui.Value
                myDSQT_CN56_Chi_Tiet.Cuoc_Theo_SL = pCuoc_Theo_SL.Value
                myDSQT_CN56_Chi_Tiet.Cuoc_Theo_KL = pCuoc_Theo_KL.Value
                myDSQT_CN56_Chi_Tiet.Cuoc_VCMBND = pCuoc_VCMBND.Value
                myDSQT_CN56_Chi_Tiet.Cuoc_Hang_Khong = pCuoc_Hang_Khong.Value
                myDSQT_CN56_Chi_Tiet.Cuoc_Khac = pCuoc_Khac.Value
                myDSQT_CN56_Chi_Tiet.Ma_Tien_Te = pMa_Tien_Te.Value
                myDSQT_CN56_Chi_Tiet.Doanh_Thu_D = pDoanh_Thu_D.Value
                myDSQT_CN56_Chi_Tiet.Doanh_Thu_M = pDoanh_Thu_M.Value
                myDSQT_CN56_Chi_Tiet.Tong_Doanh_Thu = pTong_Doanh_Thu.Value
                myDSQT_CN56_Chi_Tiet.Tong_Doanh_Thu_VND = pTong_Doanh_Thu_VND.Value
                myDSQT_CN56_Chi_Tiet.Hang_Van_Chuyen = pHang_Van_Chuyen.Value
                myDSQT_CN56_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value
                myDSQT_CN56_Chi_Tiet.I_O = pI_O.Value
                myDSQT_CN56_Chi_Tiet.Chot_SL = pChot_SL.Value
                myDSQT_CN56_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myDSQT_CN56_Chi_Tiet.Gio_He_Thong = pGio_He_Thong.Value

                Return myDSQT_CN56_Chi_Tiet
                'Return myDSQT_CN56_Chi_Tiet

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

#Region "DSQT_CN56_Them"
        Public Function DSQT_CN56_Them(ByVal Id_CN56 As String, ByVal Thang As Integer, ByVal Quy As Integer, ByVal Nam As Integer, ByVal Id_Duong_Thu As String, ByVal Ma_Nuoc_Duong_Thu As String, ByVal Ma_Nuoc_Thanh_Toan As String, ByVal Ma_Bc_Thanh_Toan As Integer, ByVal IMPC_Thanh_Toan As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Nuoc_Gui As String, ByVal Bc_Gui As Integer, ByVal Nuoc_Nhan As String, ByVal Bc_Nhan As Integer, ByVal SL_Chuyen_Thu As Integer, ByVal So_Luong_D As Integer, ByVal Khoi_Luong_D As Integer, ByVal So_Luong_M As Integer, ByVal Khoi_Luong_M As Integer, ByVal So_Luong_R As Integer, ByVal Khoi_Luong_R As Integer, ByVal So_Luong_OPS As Integer, ByVal Khoi_Luong_OPS As Integer, ByVal Khoi_Luong_Vo_Tui As Integer, ByVal Cuoc_Theo_SL As Double, ByVal Cuoc_Theo_KL As Double, ByVal Cuoc_VCMBND As Double, ByVal Cuoc_Hang_Khong As Double, ByVal Cuoc_Khac As Double, ByVal Ma_Tien_Te As String, ByVal Doanh_Thu_D As Double, ByVal Doanh_Thu_M As Double, ByVal Tong_Doanh_Thu As Double, ByVal Tong_Doanh_Thu_VND As Integer, ByVal Hang_Van_Chuyen As String, ByVal Ghi_Chu As String, ByVal I_O As Integer, ByVal Chot_SL As Boolean, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_CN56_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_CN56_Chi_Tiet As New DSQT_CN56_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_CN56 As SqlParameter = New SqlParameter("@Id_CN56", SqlDbType.VarChar, 50)
                pId_CN56.Value = Id_CN56
                MyCommand.Parameters.Add(pId_CN56)

                Dim pThang As SqlParameter = New SqlParameter("@Thang", SqlDbType.Int, 0)
                pThang.Value = Thang
                MyCommand.Parameters.Add(pThang)

                Dim pQuy As SqlParameter = New SqlParameter("@Quy", SqlDbType.Int, 0)
                pQuy.Value = Quy
                MyCommand.Parameters.Add(pQuy)

                Dim pNam As SqlParameter = New SqlParameter("@Nam", SqlDbType.Int, 0)
                pNam.Value = Nam
                MyCommand.Parameters.Add(pNam)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pId_Duong_Thu)

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

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pNuoc_Gui As SqlParameter = New SqlParameter("@Nuoc_Gui", SqlDbType.VarChar, 2)
                pNuoc_Gui.Value = Nuoc_Gui
                MyCommand.Parameters.Add(pNuoc_Gui)

                Dim pBc_Gui As SqlParameter = New SqlParameter("@Bc_Gui", SqlDbType.Int, 0)
                pBc_Gui.Value = Bc_Gui
                MyCommand.Parameters.Add(pBc_Gui)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Value = Nuoc_Nhan
                MyCommand.Parameters.Add(pNuoc_Nhan)

                Dim pBc_Nhan As SqlParameter = New SqlParameter("@Bc_Nhan", SqlDbType.Int, 0)
                pBc_Nhan.Value = Bc_Nhan
                MyCommand.Parameters.Add(pBc_Nhan)

                Dim pSL_Chuyen_Thu As SqlParameter = New SqlParameter("@SL_Chuyen_Thu", SqlDbType.Int, 0)
                pSL_Chuyen_Thu.Value = SL_Chuyen_Thu
                MyCommand.Parameters.Add(pSL_Chuyen_Thu)

                Dim pSo_Luong_D As SqlParameter = New SqlParameter("@So_Luong_D", SqlDbType.Int, 0)
                pSo_Luong_D.Value = So_Luong_D
                MyCommand.Parameters.Add(pSo_Luong_D)

                Dim pKhoi_Luong_D As SqlParameter = New SqlParameter("@Khoi_Luong_D", SqlDbType.Int, 0)
                pKhoi_Luong_D.Value = Khoi_Luong_D
                MyCommand.Parameters.Add(pKhoi_Luong_D)

                Dim pSo_Luong_M As SqlParameter = New SqlParameter("@So_Luong_M", SqlDbType.Int, 0)
                pSo_Luong_M.Value = So_Luong_M
                MyCommand.Parameters.Add(pSo_Luong_M)

                Dim pKhoi_Luong_M As SqlParameter = New SqlParameter("@Khoi_Luong_M", SqlDbType.Int, 0)
                pKhoi_Luong_M.Value = Khoi_Luong_M
                MyCommand.Parameters.Add(pKhoi_Luong_M)

                Dim pSo_Luong_R As SqlParameter = New SqlParameter("@So_Luong_R", SqlDbType.Int, 0)
                pSo_Luong_R.Value = So_Luong_R
                MyCommand.Parameters.Add(pSo_Luong_R)

                Dim pKhoi_Luong_R As SqlParameter = New SqlParameter("@Khoi_Luong_R", SqlDbType.Int, 0)
                pKhoi_Luong_R.Value = Khoi_Luong_R
                MyCommand.Parameters.Add(pKhoi_Luong_R)

                Dim pSo_Luong_OPS As SqlParameter = New SqlParameter("@So_Luong_OPS", SqlDbType.Int, 0)
                pSo_Luong_OPS.Value = So_Luong_OPS
                MyCommand.Parameters.Add(pSo_Luong_OPS)

                Dim pKhoi_Luong_OPS As SqlParameter = New SqlParameter("@Khoi_Luong_OPS", SqlDbType.Int, 0)
                pKhoi_Luong_OPS.Value = Khoi_Luong_OPS
                MyCommand.Parameters.Add(pKhoi_Luong_OPS)

                Dim pKhoi_Luong_Vo_Tui As SqlParameter = New SqlParameter("@Khoi_Luong_Vo_Tui", SqlDbType.Int, 0)
                pKhoi_Luong_Vo_Tui.Value = Khoi_Luong_Vo_Tui
                MyCommand.Parameters.Add(pKhoi_Luong_Vo_Tui)

                Dim pCuoc_Theo_SL As SqlParameter = New SqlParameter("@Cuoc_Theo_SL", SqlDbType.Float, 0)
                pCuoc_Theo_SL.Value = Cuoc_Theo_SL
                MyCommand.Parameters.Add(pCuoc_Theo_SL)

                Dim pCuoc_Theo_KL As SqlParameter = New SqlParameter("@Cuoc_Theo_KL", SqlDbType.Float, 0)
                pCuoc_Theo_KL.Value = Cuoc_Theo_KL
                MyCommand.Parameters.Add(pCuoc_Theo_KL)

                Dim pCuoc_VCMBND As SqlParameter = New SqlParameter("@Cuoc_VCMBND", SqlDbType.Float, 0)
                pCuoc_VCMBND.Value = Cuoc_VCMBND
                MyCommand.Parameters.Add(pCuoc_VCMBND)

                Dim pCuoc_Hang_Khong As SqlParameter = New SqlParameter("@Cuoc_Hang_Khong", SqlDbType.Float, 0)
                pCuoc_Hang_Khong.Value = Cuoc_Hang_Khong
                MyCommand.Parameters.Add(pCuoc_Hang_Khong)

                Dim pCuoc_Khac As SqlParameter = New SqlParameter("@Cuoc_Khac", SqlDbType.Float, 0)
                pCuoc_Khac.Value = Cuoc_Khac
                MyCommand.Parameters.Add(pCuoc_Khac)

                Dim pMa_Tien_Te As SqlParameter = New SqlParameter("@Ma_Tien_Te", SqlDbType.VarChar, 5)
                pMa_Tien_Te.Value = Ma_Tien_Te
                MyCommand.Parameters.Add(pMa_Tien_Te)

                Dim pDoanh_Thu_D As SqlParameter = New SqlParameter("@Doanh_Thu_D", SqlDbType.Float, 0)
                pDoanh_Thu_D.Value = Doanh_Thu_D
                MyCommand.Parameters.Add(pDoanh_Thu_D)

                Dim pDoanh_Thu_M As SqlParameter = New SqlParameter("@Doanh_Thu_M", SqlDbType.Float, 0)
                pDoanh_Thu_M.Value = Doanh_Thu_M
                MyCommand.Parameters.Add(pDoanh_Thu_M)

                Dim pTong_Doanh_Thu As SqlParameter = New SqlParameter("@Tong_Doanh_Thu", SqlDbType.Float, 0)
                pTong_Doanh_Thu.Value = Tong_Doanh_Thu
                MyCommand.Parameters.Add(pTong_Doanh_Thu)

                Dim pTong_Doanh_Thu_VND As SqlParameter = New SqlParameter("@Tong_Doanh_Thu_VND", SqlDbType.Int, 0)
                pTong_Doanh_Thu_VND.Value = Tong_Doanh_Thu_VND
                MyCommand.Parameters.Add(pTong_Doanh_Thu_VND)

                Dim pHang_Van_Chuyen As SqlParameter = New SqlParameter("@Hang_Van_Chuyen", SqlDbType.VarChar, 50)
                pHang_Van_Chuyen.Value = Hang_Van_Chuyen
                MyCommand.Parameters.Add(pHang_Van_Chuyen)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 100)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pI_O As SqlParameter = New SqlParameter("@I_O", SqlDbType.Int, 0)
                pI_O.Value = I_O
                MyCommand.Parameters.Add(pI_O)

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

#Region "DSQT_CN56_Xoa"
        Public Function DSQT_CN56_Xoa(ByVal Id_CN56 As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_CN56_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_CN56_Chi_Tiet As New DSQT_CN56_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_CN56 As SqlParameter = New SqlParameter("@Id_CN56", SqlDbType.VarChar, 50)
                pId_CN56.Value = Id_CN56
                MyCommand.Parameters.Add(pId_CN56)


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

#Region "DSQT_CN56_Bao_Cao_Doanh_Thu_Cuoc_VCMBND_Theo_Nam"

        Public Function DSQT_CN56_Bao_Cao_Doanh_Thu_Cuoc_VCMBND_Theo_Nam(ByVal Tat_Ca As Boolean, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Nam As Integer, ByVal Ngay_Ty_Gia As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ma_Nuoc
            ' Ten_Nuoc
            ' Khoi_Luong_Q1
            ' Khoi_Luong_Q2
            ' Khoi_Luong_Q3
            ' Khoi_Luong_Q4
            ' Cuoc_VCMBND_Q1
            ' Cuoc_VCMBND_Q2
            ' Cuoc_VCMBND_Q3
            ' Cuoc_VCMBND_Q4
            ' Tong_Nguyen_Te
            ' Tong_VND


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_CN56_Bao_Cao_Doanh_Thu_Cuoc_VCMBND_Theo_Nam"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pTat_Ca As SqlParameter = New SqlParameter("@Tat_Ca", SqlDbType.Bit, 0)
                pTat_Ca.Value = Tat_Ca
                MyCommand.Parameters.Add(pTat_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pNam As SqlParameter = New SqlParameter("@Nam", SqlDbType.Int, 0)
                pNam.Value = Nam
                MyCommand.Parameters.Add(pNam)

                Dim pNgay_Ty_Gia As SqlParameter = New SqlParameter("@Ngay_Ty_Gia", SqlDbType.Int, 0)
                pNgay_Ty_Gia.Value = Ngay_Ty_Gia
                MyCommand.Parameters.Add(pNgay_Ty_Gia)


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


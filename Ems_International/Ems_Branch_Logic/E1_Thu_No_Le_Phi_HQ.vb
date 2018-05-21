
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "E1_Thu_No_Le_Phi_HQ_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop E1_Thu_No_Le_Phi_HQ_Chi_Tiet
    'Tuong ung voi moi truong trong bang E1_Thu_No_Le_Phi_HQ trong co so du lieu
    '***********************************************************
    Public Class E1_Thu_No_Le_Phi_HQ_Chi_Tiet
        Public Id_E1 As String
        Public Id_E2 As String
        Public Id_Chuyen_Thu As String
        Public Id_Duong_Thu As String
        Public Ma_Bc_Khai_Thac As Integer
        Public Ngay_Dong As Integer
        Public Gio_Dong As Integer
        Public Ma_Tinh As Integer
        Public Don_Vi As Integer
        Public STT As Integer
        Public Nuoc_Nhan As String
        Public Ma_Bc_Nhan As Integer
        Public Ma_E1 As String
        Public Nuoc_Tra As String
        Public Ma_Bc_Tra As Integer
        Public Khoi_Luong As Integer
        Public Phan_Loai As String
        Public Gia_Tri_Hang As Integer
        Public Ma_KH As String
        Public Nguoi_Gui As String
        Public Nguoi_Nhan As String
        Public Dia_Chi_Gui As String
        Public Dia_Chi_Nhan As String
        Public Dien_Thoai_Gui As String
        Public Dien_Thoai_Nhan As String
        Public Ghi_Chu As String
        Public Ngay_Den_VN As Integer
        Public Id_Nguoi_Dung As Integer
        Public So_TKHQ As String
        Public So_Bien_Lai As String
        Public Thue_NK As Integer
        Public Thue_VAT As Integer
        Public Thue_Dac_Biet As Integer
        Public Thue_Tieu_Thu As Integer
        Public Thue_Qua_Tang As Integer
        Public Thue_Han_Ngach As Integer
        Public Thue_Uu_Dai As Integer
        Public Tong_Thue As Integer
        Public Le_Phi_HQ As Integer
        Public Le_Phi_VH As Integer
        Public Le_Phi_YT As Integer
        Public Le_Phi_DV As Integer
        Public Le_Phi_TV As Integer
        Public Le_Phi_Khac As Integer
        Public Tong_Le_Phi As Integer
        Public Tong_Thue_Le_Phi As Integer
        Public Chot_SL As Boolean
        Public Da_Truyen As Boolean
        Public Ngay_He_Thong As Integer
        Public Gio_He_Thong As Integer
        Public Thu_Lan_1 As Integer
        Public Ngay_Thu_1 As Integer
        Public Thu_Lan_2 As Integer
        Public Ngay_Thu_2 As Integer
        Public Ly_Do_CH As Integer
        Public Co_Thu As Boolean
    End Class
#End Region

#Region "E1_Thu_No_Le_Phi_HQ"
    Public Class E1_Thu_No_Le_Phi_HQ
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "E1_Thu_No_Le_Phi_HQ_Cap_Nhat"
        Public Function E1_Thu_No_Le_Phi_HQ_Cap_Nhat(ByVal Id_E1 As String, ByVal Id_E2 As String, ByVal Id_Chuyen_Thu As String, ByVal Id_Duong_Thu As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Ma_Tinh As Integer, ByVal Don_Vi As Integer, ByVal STT As Integer, ByVal Nuoc_Nhan As String, ByVal Ma_Bc_Nhan As Integer, ByVal Ma_E1 As String, ByVal Nuoc_Tra As String, ByVal Ma_Bc_Tra As Integer, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal Gia_Tri_Hang As Integer, ByVal Ma_KH As String, ByVal Nguoi_Gui As String, ByVal Nguoi_Nhan As String, ByVal Dia_Chi_Gui As String, ByVal Dia_Chi_Nhan As String, ByVal Dien_Thoai_Gui As String, ByVal Dien_Thoai_Nhan As String, ByVal Ghi_Chu As String, ByVal Ngay_Den_VN As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal So_TKHQ As String, ByVal So_Bien_Lai As String, ByVal Thue_NK As Integer, ByVal Thue_VAT As Integer, ByVal Thue_Dac_Biet As Integer, ByVal Thue_Tieu_Thu As Integer, ByVal Thue_Qua_Tang As Integer, ByVal Thue_Han_Ngach As Integer, ByVal Thue_Uu_Dai As Integer, ByVal Tong_Thue As Integer, ByVal Le_Phi_HQ As Integer, ByVal Le_Phi_VH As Integer, ByVal Le_Phi_YT As Integer, ByVal Le_Phi_DV As Integer, ByVal Le_Phi_TV As Integer, ByVal Le_Phi_Khac As Integer, ByVal Tong_Le_Phi As Integer, ByVal Tong_Thue_Le_Phi As Integer, ByVal Chot_SL As Boolean, ByVal Da_Truyen As Boolean, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer, ByVal Thu_Lan_1 As Integer, ByVal Ngay_Thu_1 As Integer, ByVal Thu_Lan_2 As Integer, ByVal Ngay_Thu_2 As Integer, ByVal Ly_Do_CH As Integer, ByVal Co_Thu As Boolean) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Thu_No_Le_Phi_HQ_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myE1_Thu_No_Le_Phi_HQ_Chi_Tiet As New E1_Thu_No_Le_Phi_HQ_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                MyCommand.Parameters.Add(pId_E1)

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                MyCommand.Parameters.Add(pId_E2)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                MyCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 0)
                pNgay_Dong.Value = Ngay_Dong
                MyCommand.Parameters.Add(pNgay_Dong)

                Dim pGio_Dong As SqlParameter = New SqlParameter("@Gio_Dong", SqlDbType.Int, 0)
                pGio_Dong.Value = Gio_Dong
                MyCommand.Parameters.Add(pGio_Dong)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 0)
                pMa_Tinh.Value = Ma_Tinh
                MyCommand.Parameters.Add(pMa_Tinh)

                Dim pDon_Vi As SqlParameter = New SqlParameter("@Don_Vi", SqlDbType.Int, 0)
                pDon_Vi.Value = Don_Vi
                MyCommand.Parameters.Add(pDon_Vi)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Value = STT
                MyCommand.Parameters.Add(pSTT)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Value = Nuoc_Nhan
                MyCommand.Parameters.Add(pNuoc_Nhan)

                Dim pMa_Bc_Nhan As SqlParameter = New SqlParameter("@Ma_Bc_Nhan", SqlDbType.Int, 0)
                pMa_Bc_Nhan.Value = Ma_Bc_Nhan
                MyCommand.Parameters.Add(pMa_Bc_Nhan)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                MyCommand.Parameters.Add(pMa_E1)

                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2)
                pNuoc_Tra.Value = Nuoc_Tra
                MyCommand.Parameters.Add(pNuoc_Tra)

                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 0)
                pMa_Bc_Tra.Value = Ma_Bc_Tra
                MyCommand.Parameters.Add(pMa_Bc_Tra)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 0)
                pKhoi_Luong.Value = Khoi_Luong
                MyCommand.Parameters.Add(pKhoi_Luong)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.VarChar, 1)
                pPhan_Loai.Value = Phan_Loai
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pGia_Tri_Hang As SqlParameter = New SqlParameter("@Gia_Tri_Hang", SqlDbType.Int, 0)
                pGia_Tri_Hang.Value = Gia_Tri_Hang
                MyCommand.Parameters.Add(pGia_Tri_Hang)

                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Value = Ma_KH
                MyCommand.Parameters.Add(pMa_KH)

                Dim pNguoi_Gui As SqlParameter = New SqlParameter("@Nguoi_Gui", SqlDbType.NVarChar, 100)
                pNguoi_Gui.Value = Nguoi_Gui
                MyCommand.Parameters.Add(pNguoi_Gui)

                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.NVarChar, 100)
                pNguoi_Nhan.Value = Nguoi_Nhan
                MyCommand.Parameters.Add(pNguoi_Nhan)

                Dim pDia_Chi_Gui As SqlParameter = New SqlParameter("@Dia_Chi_Gui", SqlDbType.NVarChar, 200)
                pDia_Chi_Gui.Value = Dia_Chi_Gui
                MyCommand.Parameters.Add(pDia_Chi_Gui)

                Dim pDia_Chi_Nhan As SqlParameter = New SqlParameter("@Dia_Chi_Nhan", SqlDbType.NVarChar, 200)
                pDia_Chi_Nhan.Value = Dia_Chi_Nhan
                MyCommand.Parameters.Add(pDia_Chi_Nhan)

                Dim pDien_Thoai_Gui As SqlParameter = New SqlParameter("@Dien_Thoai_Gui", SqlDbType.NVarChar, 50)
                pDien_Thoai_Gui.Value = Dien_Thoai_Gui
                MyCommand.Parameters.Add(pDien_Thoai_Gui)

                Dim pDien_Thoai_Nhan As SqlParameter = New SqlParameter("@Dien_Thoai_Nhan", SqlDbType.NVarChar, 50)
                pDien_Thoai_Nhan.Value = Dien_Thoai_Nhan
                MyCommand.Parameters.Add(pDien_Thoai_Nhan)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pNgay_Den_VN As SqlParameter = New SqlParameter("@Ngay_Den_VN", SqlDbType.Int, 0)
                pNgay_Den_VN.Value = Ngay_Den_VN
                MyCommand.Parameters.Add(pNgay_Den_VN)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                MyCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pSo_TKHQ As SqlParameter = New SqlParameter("@So_TKHQ", SqlDbType.VarChar, 20)
                pSo_TKHQ.Value = So_TKHQ
                MyCommand.Parameters.Add(pSo_TKHQ)

                Dim pSo_Bien_Lai As SqlParameter = New SqlParameter("@So_Bien_Lai", SqlDbType.VarChar, 20)
                pSo_Bien_Lai.Value = So_Bien_Lai
                MyCommand.Parameters.Add(pSo_Bien_Lai)

                Dim pThue_NK As SqlParameter = New SqlParameter("@Thue_NK", SqlDbType.Int, 0)
                pThue_NK.Value = Thue_NK
                MyCommand.Parameters.Add(pThue_NK)

                Dim pThue_VAT As SqlParameter = New SqlParameter("@Thue_VAT", SqlDbType.Int, 0)
                pThue_VAT.Value = Thue_VAT
                MyCommand.Parameters.Add(pThue_VAT)

                Dim pThue_Dac_Biet As SqlParameter = New SqlParameter("@Thue_Dac_Biet", SqlDbType.Int, 0)
                pThue_Dac_Biet.Value = Thue_Dac_Biet
                MyCommand.Parameters.Add(pThue_Dac_Biet)

                Dim pThue_Tieu_Thu As SqlParameter = New SqlParameter("@Thue_Tieu_Thu", SqlDbType.Int, 0)
                pThue_Tieu_Thu.Value = Thue_Tieu_Thu
                MyCommand.Parameters.Add(pThue_Tieu_Thu)

                Dim pThue_Qua_Tang As SqlParameter = New SqlParameter("@Thue_Qua_Tang", SqlDbType.Int, 0)
                pThue_Qua_Tang.Value = Thue_Qua_Tang
                MyCommand.Parameters.Add(pThue_Qua_Tang)

                Dim pThue_Han_Ngach As SqlParameter = New SqlParameter("@Thue_Han_Ngach", SqlDbType.Int, 0)
                pThue_Han_Ngach.Value = Thue_Han_Ngach
                MyCommand.Parameters.Add(pThue_Han_Ngach)

                Dim pThue_Uu_Dai As SqlParameter = New SqlParameter("@Thue_Uu_Dai", SqlDbType.Int, 0)
                pThue_Uu_Dai.Value = Thue_Uu_Dai
                MyCommand.Parameters.Add(pThue_Uu_Dai)

                Dim pTong_Thue As SqlParameter = New SqlParameter("@Tong_Thue", SqlDbType.Int, 0)
                pTong_Thue.Value = Tong_Thue
                MyCommand.Parameters.Add(pTong_Thue)

                Dim pLe_Phi_HQ As SqlParameter = New SqlParameter("@Le_Phi_HQ", SqlDbType.Int, 0)
                pLe_Phi_HQ.Value = Le_Phi_HQ
                MyCommand.Parameters.Add(pLe_Phi_HQ)

                Dim pLe_Phi_VH As SqlParameter = New SqlParameter("@Le_Phi_VH", SqlDbType.Int, 0)
                pLe_Phi_VH.Value = Le_Phi_VH
                MyCommand.Parameters.Add(pLe_Phi_VH)

                Dim pLe_Phi_YT As SqlParameter = New SqlParameter("@Le_Phi_YT", SqlDbType.Int, 0)
                pLe_Phi_YT.Value = Le_Phi_YT
                MyCommand.Parameters.Add(pLe_Phi_YT)

                Dim pLe_Phi_DV As SqlParameter = New SqlParameter("@Le_Phi_DV", SqlDbType.Int, 0)
                pLe_Phi_DV.Value = Le_Phi_DV
                MyCommand.Parameters.Add(pLe_Phi_DV)

                Dim pLe_Phi_TV As SqlParameter = New SqlParameter("@Le_Phi_TV", SqlDbType.Int, 0)
                pLe_Phi_TV.Value = Le_Phi_TV
                MyCommand.Parameters.Add(pLe_Phi_TV)

                Dim pLe_Phi_Khac As SqlParameter = New SqlParameter("@Le_Phi_Khac", SqlDbType.Int, 0)
                pLe_Phi_Khac.Value = Le_Phi_Khac
                MyCommand.Parameters.Add(pLe_Phi_Khac)

                Dim pTong_Le_Phi As SqlParameter = New SqlParameter("@Tong_Le_Phi", SqlDbType.Int, 0)
                pTong_Le_Phi.Value = Tong_Le_Phi
                MyCommand.Parameters.Add(pTong_Le_Phi)

                Dim pTong_Thue_Le_Phi As SqlParameter = New SqlParameter("@Tong_Thue_Le_Phi", SqlDbType.Int, 0)
                pTong_Thue_Le_Phi.Value = Tong_Thue_Le_Phi
                MyCommand.Parameters.Add(pTong_Thue_Le_Phi)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 0)
                pChot_SL.Value = Chot_SL
                MyCommand.Parameters.Add(pChot_SL)

                Dim pDa_Truyen As SqlParameter = New SqlParameter("@Da_Truyen", SqlDbType.Bit, 0)
                pDa_Truyen.Value = Da_Truyen
                MyCommand.Parameters.Add(pDa_Truyen)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Value = Ngay_He_Thong
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Value = Gio_He_Thong
                MyCommand.Parameters.Add(pGio_He_Thong)

                Dim pThu_Lan_1 As SqlParameter = New SqlParameter("@Thu_Lan_1", SqlDbType.Int, 0)
                pThu_Lan_1.Value = Thu_Lan_1
                MyCommand.Parameters.Add(pThu_Lan_1)

                Dim pNgay_Thu_1 As SqlParameter = New SqlParameter("@Ngay_Thu_1", SqlDbType.Int, 0)
                pNgay_Thu_1.Value = Ngay_Thu_1
                MyCommand.Parameters.Add(pNgay_Thu_1)

                Dim pThu_Lan_2 As SqlParameter = New SqlParameter("@Thu_Lan_2", SqlDbType.Int, 0)
                pThu_Lan_2.Value = Thu_Lan_2
                MyCommand.Parameters.Add(pThu_Lan_2)

                Dim pNgay_Thu_2 As SqlParameter = New SqlParameter("@Ngay_Thu_2", SqlDbType.Int, 0)
                pNgay_Thu_2.Value = Ngay_Thu_2
                MyCommand.Parameters.Add(pNgay_Thu_2)

                Dim pLy_Do_CH As SqlParameter = New SqlParameter("@Ly_Do_CH", SqlDbType.Int, 0)
                pLy_Do_CH.Value = Ly_Do_CH
                MyCommand.Parameters.Add(pLy_Do_CH)

                Dim pCo_Thu As SqlParameter = New SqlParameter("@Co_Thu", SqlDbType.Bit, 0)
                pCo_Thu.Value = Co_Thu
                MyCommand.Parameters.Add(pCo_Thu)


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

#Region "E1_Thu_No_Le_Phi_HQ_Cap_Nhat_Them"
        Public Function E1_Thu_No_Le_Phi_HQ_Cap_Nhat_Them(ByVal Id_E1 As String, ByVal Id_E2 As String, ByVal Id_Chuyen_Thu As String, ByVal Id_Duong_Thu As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Ma_Tinh As Integer, ByVal Don_Vi As Integer, ByVal STT As Integer, ByVal Nuoc_Nhan As String, ByVal Ma_Bc_Nhan As Integer, ByVal Ma_E1 As String, ByVal Nuoc_Tra As String, ByVal Ma_Bc_Tra As Integer, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal Gia_Tri_Hang As Integer, ByVal Ma_KH As String, ByVal Nguoi_Gui As String, ByVal Nguoi_Nhan As String, ByVal Dia_Chi_Gui As String, ByVal Dia_Chi_Nhan As String, ByVal Dien_Thoai_Gui As String, ByVal Dien_Thoai_Nhan As String, ByVal Ghi_Chu As String, ByVal Ngay_Den_VN As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal So_TKHQ As String, ByVal So_Bien_Lai As String, ByVal Thue_NK As Integer, ByVal Thue_VAT As Integer, ByVal Thue_Dac_Biet As Integer, ByVal Thue_Tieu_Thu As Integer, ByVal Thue_Qua_Tang As Integer, ByVal Thue_Han_Ngach As Integer, ByVal Thue_Uu_Dai As Integer, ByVal Tong_Thue As Integer, ByVal Le_Phi_HQ As Integer, ByVal Le_Phi_VH As Integer, ByVal Le_Phi_YT As Integer, ByVal Le_Phi_DV As Integer, ByVal Le_Phi_TV As Integer, ByVal Le_Phi_Khac As Integer, ByVal Tong_Le_Phi As Integer, ByVal Tong_Thue_Le_Phi As Integer, ByVal Chot_SL As Boolean, ByVal Da_Truyen As Boolean, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer, ByVal Thu_Lan_1 As Integer, ByVal Ngay_Thu_1 As Integer, ByVal Thu_Lan_2 As Integer, ByVal Ngay_Thu_2 As Integer, ByVal Ly_Do_CH As Integer, ByVal Co_Thu As Boolean) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Thu_No_Le_Phi_HQ_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myE1_Thu_No_Le_Phi_HQ_Chi_Tiet As New E1_Thu_No_Le_Phi_HQ_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                MyCommand.Parameters.Add(pId_E1)

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                MyCommand.Parameters.Add(pId_E2)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                MyCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 0)
                pNgay_Dong.Value = Ngay_Dong
                MyCommand.Parameters.Add(pNgay_Dong)

                Dim pGio_Dong As SqlParameter = New SqlParameter("@Gio_Dong", SqlDbType.Int, 0)
                pGio_Dong.Value = Gio_Dong
                MyCommand.Parameters.Add(pGio_Dong)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 0)
                pMa_Tinh.Value = Ma_Tinh
                MyCommand.Parameters.Add(pMa_Tinh)

                Dim pDon_Vi As SqlParameter = New SqlParameter("@Don_Vi", SqlDbType.Int, 0)
                pDon_Vi.Value = Don_Vi
                MyCommand.Parameters.Add(pDon_Vi)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Value = STT
                MyCommand.Parameters.Add(pSTT)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Value = Nuoc_Nhan
                MyCommand.Parameters.Add(pNuoc_Nhan)

                Dim pMa_Bc_Nhan As SqlParameter = New SqlParameter("@Ma_Bc_Nhan", SqlDbType.Int, 0)
                pMa_Bc_Nhan.Value = Ma_Bc_Nhan
                MyCommand.Parameters.Add(pMa_Bc_Nhan)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                MyCommand.Parameters.Add(pMa_E1)

                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2)
                pNuoc_Tra.Value = Nuoc_Tra
                MyCommand.Parameters.Add(pNuoc_Tra)

                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 0)
                pMa_Bc_Tra.Value = Ma_Bc_Tra
                MyCommand.Parameters.Add(pMa_Bc_Tra)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 0)
                pKhoi_Luong.Value = Khoi_Luong
                MyCommand.Parameters.Add(pKhoi_Luong)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.VarChar, 1)
                pPhan_Loai.Value = Phan_Loai
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pGia_Tri_Hang As SqlParameter = New SqlParameter("@Gia_Tri_Hang", SqlDbType.Int, 0)
                pGia_Tri_Hang.Value = Gia_Tri_Hang
                MyCommand.Parameters.Add(pGia_Tri_Hang)

                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Value = Ma_KH
                MyCommand.Parameters.Add(pMa_KH)

                Dim pNguoi_Gui As SqlParameter = New SqlParameter("@Nguoi_Gui", SqlDbType.NVarChar, 100)
                pNguoi_Gui.Value = Nguoi_Gui
                MyCommand.Parameters.Add(pNguoi_Gui)

                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.NVarChar, 100)
                pNguoi_Nhan.Value = Nguoi_Nhan
                MyCommand.Parameters.Add(pNguoi_Nhan)

                Dim pDia_Chi_Gui As SqlParameter = New SqlParameter("@Dia_Chi_Gui", SqlDbType.NVarChar, 200)
                pDia_Chi_Gui.Value = Dia_Chi_Gui
                MyCommand.Parameters.Add(pDia_Chi_Gui)

                Dim pDia_Chi_Nhan As SqlParameter = New SqlParameter("@Dia_Chi_Nhan", SqlDbType.NVarChar, 200)
                pDia_Chi_Nhan.Value = Dia_Chi_Nhan
                MyCommand.Parameters.Add(pDia_Chi_Nhan)

                Dim pDien_Thoai_Gui As SqlParameter = New SqlParameter("@Dien_Thoai_Gui", SqlDbType.NVarChar, 50)
                pDien_Thoai_Gui.Value = Dien_Thoai_Gui
                MyCommand.Parameters.Add(pDien_Thoai_Gui)

                Dim pDien_Thoai_Nhan As SqlParameter = New SqlParameter("@Dien_Thoai_Nhan", SqlDbType.NVarChar, 50)
                pDien_Thoai_Nhan.Value = Dien_Thoai_Nhan
                MyCommand.Parameters.Add(pDien_Thoai_Nhan)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pNgay_Den_VN As SqlParameter = New SqlParameter("@Ngay_Den_VN", SqlDbType.Int, 0)
                pNgay_Den_VN.Value = Ngay_Den_VN
                MyCommand.Parameters.Add(pNgay_Den_VN)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                MyCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pSo_TKHQ As SqlParameter = New SqlParameter("@So_TKHQ", SqlDbType.VarChar, 20)
                pSo_TKHQ.Value = So_TKHQ
                MyCommand.Parameters.Add(pSo_TKHQ)

                Dim pSo_Bien_Lai As SqlParameter = New SqlParameter("@So_Bien_Lai", SqlDbType.VarChar, 20)
                pSo_Bien_Lai.Value = So_Bien_Lai
                MyCommand.Parameters.Add(pSo_Bien_Lai)

                Dim pThue_NK As SqlParameter = New SqlParameter("@Thue_NK", SqlDbType.Int, 0)
                pThue_NK.Value = Thue_NK
                MyCommand.Parameters.Add(pThue_NK)

                Dim pThue_VAT As SqlParameter = New SqlParameter("@Thue_VAT", SqlDbType.Int, 0)
                pThue_VAT.Value = Thue_VAT
                MyCommand.Parameters.Add(pThue_VAT)

                Dim pThue_Dac_Biet As SqlParameter = New SqlParameter("@Thue_Dac_Biet", SqlDbType.Int, 0)
                pThue_Dac_Biet.Value = Thue_Dac_Biet
                MyCommand.Parameters.Add(pThue_Dac_Biet)

                Dim pThue_Tieu_Thu As SqlParameter = New SqlParameter("@Thue_Tieu_Thu", SqlDbType.Int, 0)
                pThue_Tieu_Thu.Value = Thue_Tieu_Thu
                MyCommand.Parameters.Add(pThue_Tieu_Thu)

                Dim pThue_Qua_Tang As SqlParameter = New SqlParameter("@Thue_Qua_Tang", SqlDbType.Int, 0)
                pThue_Qua_Tang.Value = Thue_Qua_Tang
                MyCommand.Parameters.Add(pThue_Qua_Tang)

                Dim pThue_Han_Ngach As SqlParameter = New SqlParameter("@Thue_Han_Ngach", SqlDbType.Int, 0)
                pThue_Han_Ngach.Value = Thue_Han_Ngach
                MyCommand.Parameters.Add(pThue_Han_Ngach)

                Dim pThue_Uu_Dai As SqlParameter = New SqlParameter("@Thue_Uu_Dai", SqlDbType.Int, 0)
                pThue_Uu_Dai.Value = Thue_Uu_Dai
                MyCommand.Parameters.Add(pThue_Uu_Dai)

                Dim pTong_Thue As SqlParameter = New SqlParameter("@Tong_Thue", SqlDbType.Int, 0)
                pTong_Thue.Value = Tong_Thue
                MyCommand.Parameters.Add(pTong_Thue)

                Dim pLe_Phi_HQ As SqlParameter = New SqlParameter("@Le_Phi_HQ", SqlDbType.Int, 0)
                pLe_Phi_HQ.Value = Le_Phi_HQ
                MyCommand.Parameters.Add(pLe_Phi_HQ)

                Dim pLe_Phi_VH As SqlParameter = New SqlParameter("@Le_Phi_VH", SqlDbType.Int, 0)
                pLe_Phi_VH.Value = Le_Phi_VH
                MyCommand.Parameters.Add(pLe_Phi_VH)

                Dim pLe_Phi_YT As SqlParameter = New SqlParameter("@Le_Phi_YT", SqlDbType.Int, 0)
                pLe_Phi_YT.Value = Le_Phi_YT
                MyCommand.Parameters.Add(pLe_Phi_YT)

                Dim pLe_Phi_DV As SqlParameter = New SqlParameter("@Le_Phi_DV", SqlDbType.Int, 0)
                pLe_Phi_DV.Value = Le_Phi_DV
                MyCommand.Parameters.Add(pLe_Phi_DV)

                Dim pLe_Phi_TV As SqlParameter = New SqlParameter("@Le_Phi_TV", SqlDbType.Int, 0)
                pLe_Phi_TV.Value = Le_Phi_TV
                MyCommand.Parameters.Add(pLe_Phi_TV)

                Dim pLe_Phi_Khac As SqlParameter = New SqlParameter("@Le_Phi_Khac", SqlDbType.Int, 0)
                pLe_Phi_Khac.Value = Le_Phi_Khac
                MyCommand.Parameters.Add(pLe_Phi_Khac)

                Dim pTong_Le_Phi As SqlParameter = New SqlParameter("@Tong_Le_Phi", SqlDbType.Int, 0)
                pTong_Le_Phi.Value = Tong_Le_Phi
                MyCommand.Parameters.Add(pTong_Le_Phi)

                Dim pTong_Thue_Le_Phi As SqlParameter = New SqlParameter("@Tong_Thue_Le_Phi", SqlDbType.Int, 0)
                pTong_Thue_Le_Phi.Value = Tong_Thue_Le_Phi
                MyCommand.Parameters.Add(pTong_Thue_Le_Phi)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 0)
                pChot_SL.Value = Chot_SL
                MyCommand.Parameters.Add(pChot_SL)

                Dim pDa_Truyen As SqlParameter = New SqlParameter("@Da_Truyen", SqlDbType.Bit, 0)
                pDa_Truyen.Value = Da_Truyen
                MyCommand.Parameters.Add(pDa_Truyen)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Value = Ngay_He_Thong
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Value = Gio_He_Thong
                MyCommand.Parameters.Add(pGio_He_Thong)

                Dim pThu_Lan_1 As SqlParameter = New SqlParameter("@Thu_Lan_1", SqlDbType.Int, 0)
                pThu_Lan_1.Value = Thu_Lan_1
                MyCommand.Parameters.Add(pThu_Lan_1)

                Dim pNgay_Thu_1 As SqlParameter = New SqlParameter("@Ngay_Thu_1", SqlDbType.Int, 0)
                pNgay_Thu_1.Value = Ngay_Thu_1
                MyCommand.Parameters.Add(pNgay_Thu_1)

                Dim pThu_Lan_2 As SqlParameter = New SqlParameter("@Thu_Lan_2", SqlDbType.Int, 0)
                pThu_Lan_2.Value = Thu_Lan_2
                MyCommand.Parameters.Add(pThu_Lan_2)

                Dim pNgay_Thu_2 As SqlParameter = New SqlParameter("@Ngay_Thu_2", SqlDbType.Int, 0)
                pNgay_Thu_2.Value = Ngay_Thu_2
                MyCommand.Parameters.Add(pNgay_Thu_2)

                Dim pLy_Do_CH As SqlParameter = New SqlParameter("@Ly_Do_CH", SqlDbType.Int, 0)
                pLy_Do_CH.Value = Ly_Do_CH
                MyCommand.Parameters.Add(pLy_Do_CH)

                Dim pCo_Thu As SqlParameter = New SqlParameter("@Co_Thu", SqlDbType.Bit, 0)
                pCo_Thu.Value = Co_Thu
                MyCommand.Parameters.Add(pCo_Thu)


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

#Region "E1_Thu_No_Le_Phi_HQ_Danh_Sach"

        Public Function E1_Thu_No_Le_Phi_HQ_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Id_E1
            ' Id_E2
            ' Id_Chuyen_Thu
            ' Id_Duong_Thu
            ' Ma_Bc_Khai_Thac
            ' Ngay_Dong
            ' Gio_Dong
            ' Ma_Tinh
            ' Don_Vi
            ' STT
            ' Nuoc_Nhan
            ' Ma_Bc_Nhan
            ' Ma_E1
            ' Nuoc_Tra
            ' Ma_Bc_Tra
            ' Khoi_Luong
            ' Phan_Loai
            ' Gia_Tri_Hang
            ' Ma_KH
            ' Nguoi_Gui
            ' Nguoi_Nhan
            ' Dia_Chi_Gui
            ' Dia_Chi_Nhan
            ' Dien_Thoai_Gui
            ' Dien_Thoai_Nhan
            ' Ghi_Chu
            ' Ngay_Den_VN
            ' Id_Nguoi_Dung
            ' So_TKHQ
            ' So_Bien_Lai
            ' Thue_NK
            ' Thue_VAT
            ' Thue_Dac_Biet
            ' Thue_Tieu_Thu
            ' Thue_Qua_Tang
            ' Thue_Han_Ngach
            ' Thue_Uu_Dai
            ' Tong_Thue
            ' Le_Phi_HQ
            ' Le_Phi_VH
            ' Le_Phi_YT
            ' Le_Phi_DV
            ' Le_Phi_TV
            ' Le_Phi_Khac
            ' Tong_Le_Phi
            ' Tong_Thue_Le_Phi
            ' Chot_SL
            ' Da_Truyen
            ' Ngay_He_Thong
            ' Gio_He_Thong
            ' Thu_Lan_1
            ' Ngay_Thu_1
            ' Thu_Lan_2
            ' Ngay_Thu_2
            ' Ly_Do_CH
            ' Co_Thu


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Thu_No_Le_Phi_HQ_Danh_Sach"
            MyCommand.CommandType = CommandType.StoredProcedure
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

#Region "E1_Thu_No_Le_Phi_HQ_Lay"
        Public Function E1_Thu_No_Le_Phi_HQ_Lay(ByVal Id_E1 As String) As E1_Thu_No_Le_Phi_HQ_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Thu_No_Le_Phi_HQ_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myE1_Thu_No_Le_Phi_HQ_Chi_Tiet As New E1_Thu_No_Le_Phi_HQ_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                MyCommand.Parameters.Add(pId_E1)

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_E2)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 0)
                pNgay_Dong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Dong)

                Dim pGio_Dong As SqlParameter = New SqlParameter("@Gio_Dong", SqlDbType.Int, 0)
                pGio_Dong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Dong)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 0)
                pMa_Tinh.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Tinh)

                Dim pDon_Vi As SqlParameter = New SqlParameter("@Don_Vi", SqlDbType.Int, 0)
                pDon_Vi.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDon_Vi)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSTT)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNuoc_Nhan)

                Dim pMa_Bc_Nhan As SqlParameter = New SqlParameter("@Ma_Bc_Nhan", SqlDbType.Int, 0)
                pMa_Bc_Nhan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc_Nhan)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_E1)

                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2)
                pNuoc_Tra.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNuoc_Tra)

                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 0)
                pMa_Bc_Tra.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc_Tra)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 0)
                pKhoi_Luong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pKhoi_Luong)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.VarChar, 1)
                pPhan_Loai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pGia_Tri_Hang As SqlParameter = New SqlParameter("@Gia_Tri_Hang", SqlDbType.Int, 0)
                pGia_Tri_Hang.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGia_Tri_Hang)

                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_KH)

                Dim pNguoi_Gui As SqlParameter = New SqlParameter("@Nguoi_Gui", SqlDbType.NVarChar, 100)
                pNguoi_Gui.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNguoi_Gui)

                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.NVarChar, 100)
                pNguoi_Nhan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNguoi_Nhan)

                Dim pDia_Chi_Gui As SqlParameter = New SqlParameter("@Dia_Chi_Gui", SqlDbType.NVarChar, 200)
                pDia_Chi_Gui.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDia_Chi_Gui)

                Dim pDia_Chi_Nhan As SqlParameter = New SqlParameter("@Dia_Chi_Nhan", SqlDbType.NVarChar, 200)
                pDia_Chi_Nhan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDia_Chi_Nhan)

                Dim pDien_Thoai_Gui As SqlParameter = New SqlParameter("@Dien_Thoai_Gui", SqlDbType.NVarChar, 50)
                pDien_Thoai_Gui.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDien_Thoai_Gui)

                Dim pDien_Thoai_Nhan As SqlParameter = New SqlParameter("@Dien_Thoai_Nhan", SqlDbType.NVarChar, 50)
                pDien_Thoai_Nhan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDien_Thoai_Nhan)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
                pGhi_Chu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pNgay_Den_VN As SqlParameter = New SqlParameter("@Ngay_Den_VN", SqlDbType.Int, 0)
                pNgay_Den_VN.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Den_VN)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0)
                pId_Nguoi_Dung.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pSo_TKHQ As SqlParameter = New SqlParameter("@So_TKHQ", SqlDbType.VarChar, 20)
                pSo_TKHQ.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSo_TKHQ)

                Dim pSo_Bien_Lai As SqlParameter = New SqlParameter("@So_Bien_Lai", SqlDbType.VarChar, 20)
                pSo_Bien_Lai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSo_Bien_Lai)

                Dim pThue_NK As SqlParameter = New SqlParameter("@Thue_NK", SqlDbType.Int, 0)
                pThue_NK.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThue_NK)

                Dim pThue_VAT As SqlParameter = New SqlParameter("@Thue_VAT", SqlDbType.Int, 0)
                pThue_VAT.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThue_VAT)

                Dim pThue_Dac_Biet As SqlParameter = New SqlParameter("@Thue_Dac_Biet", SqlDbType.Int, 0)
                pThue_Dac_Biet.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThue_Dac_Biet)

                Dim pThue_Tieu_Thu As SqlParameter = New SqlParameter("@Thue_Tieu_Thu", SqlDbType.Int, 0)
                pThue_Tieu_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThue_Tieu_Thu)

                Dim pThue_Qua_Tang As SqlParameter = New SqlParameter("@Thue_Qua_Tang", SqlDbType.Int, 0)
                pThue_Qua_Tang.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThue_Qua_Tang)

                Dim pThue_Han_Ngach As SqlParameter = New SqlParameter("@Thue_Han_Ngach", SqlDbType.Int, 0)
                pThue_Han_Ngach.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThue_Han_Ngach)

                Dim pThue_Uu_Dai As SqlParameter = New SqlParameter("@Thue_Uu_Dai", SqlDbType.Int, 0)
                pThue_Uu_Dai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThue_Uu_Dai)

                Dim pTong_Thue As SqlParameter = New SqlParameter("@Tong_Thue", SqlDbType.Int, 0)
                pTong_Thue.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTong_Thue)

                Dim pLe_Phi_HQ As SqlParameter = New SqlParameter("@Le_Phi_HQ", SqlDbType.Int, 0)
                pLe_Phi_HQ.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pLe_Phi_HQ)

                Dim pLe_Phi_VH As SqlParameter = New SqlParameter("@Le_Phi_VH", SqlDbType.Int, 0)
                pLe_Phi_VH.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pLe_Phi_VH)

                Dim pLe_Phi_YT As SqlParameter = New SqlParameter("@Le_Phi_YT", SqlDbType.Int, 0)
                pLe_Phi_YT.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pLe_Phi_YT)

                Dim pLe_Phi_DV As SqlParameter = New SqlParameter("@Le_Phi_DV", SqlDbType.Int, 0)
                pLe_Phi_DV.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pLe_Phi_DV)

                Dim pLe_Phi_TV As SqlParameter = New SqlParameter("@Le_Phi_TV", SqlDbType.Int, 0)
                pLe_Phi_TV.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pLe_Phi_TV)

                Dim pLe_Phi_Khac As SqlParameter = New SqlParameter("@Le_Phi_Khac", SqlDbType.Int, 0)
                pLe_Phi_Khac.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pLe_Phi_Khac)

                Dim pTong_Le_Phi As SqlParameter = New SqlParameter("@Tong_Le_Phi", SqlDbType.Int, 0)
                pTong_Le_Phi.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTong_Le_Phi)

                Dim pTong_Thue_Le_Phi As SqlParameter = New SqlParameter("@Tong_Thue_Le_Phi", SqlDbType.Int, 0)
                pTong_Thue_Le_Phi.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTong_Thue_Le_Phi)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 0)
                pChot_SL.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pChot_SL)

                Dim pDa_Truyen As SqlParameter = New SqlParameter("@Da_Truyen", SqlDbType.Bit, 0)
                pDa_Truyen.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDa_Truyen)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_He_Thong)

                Dim pThu_Lan_1 As SqlParameter = New SqlParameter("@Thu_Lan_1", SqlDbType.Int, 0)
                pThu_Lan_1.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThu_Lan_1)

                Dim pNgay_Thu_1 As SqlParameter = New SqlParameter("@Ngay_Thu_1", SqlDbType.Int, 0)
                pNgay_Thu_1.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Thu_1)

                Dim pThu_Lan_2 As SqlParameter = New SqlParameter("@Thu_Lan_2", SqlDbType.Int, 0)
                pThu_Lan_2.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThu_Lan_2)

                Dim pNgay_Thu_2 As SqlParameter = New SqlParameter("@Ngay_Thu_2", SqlDbType.Int, 0)
                pNgay_Thu_2.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Thu_2)

                Dim pLy_Do_CH As SqlParameter = New SqlParameter("@Ly_Do_CH", SqlDbType.Int, 0)
                pLy_Do_CH.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pLy_Do_CH)

                Dim pCo_Thu As SqlParameter = New SqlParameter("@Co_Thu", SqlDbType.Bit, 0)
                pCo_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCo_Thu)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Id_E1 = Id_E1
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Id_E2 = pId_E2.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Id_Chuyen_Thu = pId_Chuyen_Thu.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Id_Duong_Thu = pId_Duong_Thu.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Ma_Bc_Khai_Thac = pMa_Bc_Khai_Thac.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Ngay_Dong = pNgay_Dong.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Gio_Dong = pGio_Dong.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Ma_Tinh = pMa_Tinh.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Don_Vi = pDon_Vi.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.STT = pSTT.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Nuoc_Nhan = pNuoc_Nhan.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Ma_Bc_Nhan = pMa_Bc_Nhan.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Ma_E1 = pMa_E1.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Nuoc_Tra = pNuoc_Tra.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Ma_Bc_Tra = pMa_Bc_Tra.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Khoi_Luong = pKhoi_Luong.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Phan_Loai = pPhan_Loai.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Gia_Tri_Hang = pGia_Tri_Hang.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Ma_KH = pMa_KH.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Nguoi_Gui = pNguoi_Gui.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Nguoi_Nhan = pNguoi_Nhan.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Dia_Chi_Gui = pDia_Chi_Gui.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Dia_Chi_Nhan = pDia_Chi_Nhan.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Dien_Thoai_Gui = pDien_Thoai_Gui.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Dien_Thoai_Nhan = pDien_Thoai_Nhan.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Ngay_Den_VN = pNgay_Den_VN.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Id_Nguoi_Dung = pId_Nguoi_Dung.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.So_TKHQ = pSo_TKHQ.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.So_Bien_Lai = pSo_Bien_Lai.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Thue_NK = pThue_NK.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Thue_VAT = pThue_VAT.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Thue_Dac_Biet = pThue_Dac_Biet.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Thue_Tieu_Thu = pThue_Tieu_Thu.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Thue_Qua_Tang = pThue_Qua_Tang.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Thue_Han_Ngach = pThue_Han_Ngach.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Thue_Uu_Dai = pThue_Uu_Dai.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Tong_Thue = pTong_Thue.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Le_Phi_HQ = pLe_Phi_HQ.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Le_Phi_VH = pLe_Phi_VH.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Le_Phi_YT = pLe_Phi_YT.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Le_Phi_DV = pLe_Phi_DV.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Le_Phi_TV = pLe_Phi_TV.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Le_Phi_Khac = pLe_Phi_Khac.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Tong_Le_Phi = pTong_Le_Phi.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Tong_Thue_Le_Phi = pTong_Thue_Le_Phi.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Chot_SL = pChot_SL.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Da_Truyen = pDa_Truyen.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Gio_He_Thong = pGio_He_Thong.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Thu_Lan_1 = pThu_Lan_1.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Ngay_Thu_1 = pNgay_Thu_1.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Thu_Lan_2 = pThu_Lan_2.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Ngay_Thu_2 = pNgay_Thu_2.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Ly_Do_CH = pLy_Do_CH.Value
                myE1_Thu_No_Le_Phi_HQ_Chi_Tiet.Co_Thu = pCo_Thu.Value

                Return myE1_Thu_No_Le_Phi_HQ_Chi_Tiet
                'Return myE1_Thu_No_Le_Phi_HQ_Chi_Tiet

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

#Region "E1_Thu_No_Le_Phi_HQ_Them"
        Public Function E1_Thu_No_Le_Phi_HQ_Them(ByVal Id_E1 As String, ByVal Id_E2 As String, ByVal Id_Chuyen_Thu As String, ByVal Id_Duong_Thu As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Ma_Tinh As Integer, ByVal Don_Vi As Integer, ByVal STT As Integer, ByVal Nuoc_Nhan As String, ByVal Ma_Bc_Nhan As Integer, ByVal Ma_E1 As String, ByVal Nuoc_Tra As String, ByVal Ma_Bc_Tra As Integer, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal Gia_Tri_Hang As Integer, ByVal Ma_KH As String, ByVal Nguoi_Gui As String, ByVal Nguoi_Nhan As String, ByVal Dia_Chi_Gui As String, ByVal Dia_Chi_Nhan As String, ByVal Dien_Thoai_Gui As String, ByVal Dien_Thoai_Nhan As String, ByVal Ghi_Chu As String, ByVal Ngay_Den_VN As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal So_TKHQ As String, ByVal So_Bien_Lai As String, ByVal Thue_NK As Integer, ByVal Thue_VAT As Integer, ByVal Thue_Dac_Biet As Integer, ByVal Thue_Tieu_Thu As Integer, ByVal Thue_Qua_Tang As Integer, ByVal Thue_Han_Ngach As Integer, ByVal Thue_Uu_Dai As Integer, ByVal Tong_Thue As Integer, ByVal Le_Phi_HQ As Integer, ByVal Le_Phi_VH As Integer, ByVal Le_Phi_YT As Integer, ByVal Le_Phi_DV As Integer, ByVal Le_Phi_TV As Integer, ByVal Le_Phi_Khac As Integer, ByVal Tong_Le_Phi As Integer, ByVal Tong_Thue_Le_Phi As Integer, ByVal Chot_SL As Boolean, ByVal Da_Truyen As Boolean, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer, ByVal Thu_Lan_1 As Integer, ByVal Ngay_Thu_1 As Integer, ByVal Thu_Lan_2 As Integer, ByVal Ngay_Thu_2 As Integer, ByVal Ly_Do_CH As Integer, ByVal Co_Thu As Boolean) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Thu_No_Le_Phi_HQ_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myE1_Thu_No_Le_Phi_HQ_Chi_Tiet As New E1_Thu_No_Le_Phi_HQ_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                MyCommand.Parameters.Add(pId_E1)

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                MyCommand.Parameters.Add(pId_E2)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                MyCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 0)
                pNgay_Dong.Value = Ngay_Dong
                MyCommand.Parameters.Add(pNgay_Dong)

                Dim pGio_Dong As SqlParameter = New SqlParameter("@Gio_Dong", SqlDbType.Int, 0)
                pGio_Dong.Value = Gio_Dong
                MyCommand.Parameters.Add(pGio_Dong)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 0)
                pMa_Tinh.Value = Ma_Tinh
                MyCommand.Parameters.Add(pMa_Tinh)

                Dim pDon_Vi As SqlParameter = New SqlParameter("@Don_Vi", SqlDbType.Int, 0)
                pDon_Vi.Value = Don_Vi
                MyCommand.Parameters.Add(pDon_Vi)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Value = STT
                MyCommand.Parameters.Add(pSTT)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Value = Nuoc_Nhan
                MyCommand.Parameters.Add(pNuoc_Nhan)

                Dim pMa_Bc_Nhan As SqlParameter = New SqlParameter("@Ma_Bc_Nhan", SqlDbType.Int, 0)
                pMa_Bc_Nhan.Value = Ma_Bc_Nhan
                MyCommand.Parameters.Add(pMa_Bc_Nhan)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                MyCommand.Parameters.Add(pMa_E1)

                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2)
                pNuoc_Tra.Value = Nuoc_Tra
                MyCommand.Parameters.Add(pNuoc_Tra)

                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 0)
                pMa_Bc_Tra.Value = Ma_Bc_Tra
                MyCommand.Parameters.Add(pMa_Bc_Tra)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 0)
                pKhoi_Luong.Value = Khoi_Luong
                MyCommand.Parameters.Add(pKhoi_Luong)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.VarChar, 1)
                pPhan_Loai.Value = Phan_Loai
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pGia_Tri_Hang As SqlParameter = New SqlParameter("@Gia_Tri_Hang", SqlDbType.Int, 0)
                pGia_Tri_Hang.Value = Gia_Tri_Hang
                MyCommand.Parameters.Add(pGia_Tri_Hang)

                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Value = Ma_KH
                MyCommand.Parameters.Add(pMa_KH)

                Dim pNguoi_Gui As SqlParameter = New SqlParameter("@Nguoi_Gui", SqlDbType.NVarChar, 100)
                pNguoi_Gui.Value = Nguoi_Gui
                MyCommand.Parameters.Add(pNguoi_Gui)

                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.NVarChar, 100)
                pNguoi_Nhan.Value = Nguoi_Nhan
                MyCommand.Parameters.Add(pNguoi_Nhan)

                Dim pDia_Chi_Gui As SqlParameter = New SqlParameter("@Dia_Chi_Gui", SqlDbType.NVarChar, 200)
                pDia_Chi_Gui.Value = Dia_Chi_Gui
                MyCommand.Parameters.Add(pDia_Chi_Gui)

                Dim pDia_Chi_Nhan As SqlParameter = New SqlParameter("@Dia_Chi_Nhan", SqlDbType.NVarChar, 200)
                pDia_Chi_Nhan.Value = Dia_Chi_Nhan
                MyCommand.Parameters.Add(pDia_Chi_Nhan)

                Dim pDien_Thoai_Gui As SqlParameter = New SqlParameter("@Dien_Thoai_Gui", SqlDbType.NVarChar, 50)
                pDien_Thoai_Gui.Value = Dien_Thoai_Gui
                MyCommand.Parameters.Add(pDien_Thoai_Gui)

                Dim pDien_Thoai_Nhan As SqlParameter = New SqlParameter("@Dien_Thoai_Nhan", SqlDbType.NVarChar, 50)
                pDien_Thoai_Nhan.Value = Dien_Thoai_Nhan
                MyCommand.Parameters.Add(pDien_Thoai_Nhan)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pNgay_Den_VN As SqlParameter = New SqlParameter("@Ngay_Den_VN", SqlDbType.Int, 0)
                pNgay_Den_VN.Value = Ngay_Den_VN
                MyCommand.Parameters.Add(pNgay_Den_VN)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                MyCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pSo_TKHQ As SqlParameter = New SqlParameter("@So_TKHQ", SqlDbType.VarChar, 20)
                pSo_TKHQ.Value = So_TKHQ
                MyCommand.Parameters.Add(pSo_TKHQ)

                Dim pSo_Bien_Lai As SqlParameter = New SqlParameter("@So_Bien_Lai", SqlDbType.VarChar, 20)
                pSo_Bien_Lai.Value = So_Bien_Lai
                MyCommand.Parameters.Add(pSo_Bien_Lai)

                Dim pThue_NK As SqlParameter = New SqlParameter("@Thue_NK", SqlDbType.Int, 0)
                pThue_NK.Value = Thue_NK
                MyCommand.Parameters.Add(pThue_NK)

                Dim pThue_VAT As SqlParameter = New SqlParameter("@Thue_VAT", SqlDbType.Int, 0)
                pThue_VAT.Value = Thue_VAT
                MyCommand.Parameters.Add(pThue_VAT)

                Dim pThue_Dac_Biet As SqlParameter = New SqlParameter("@Thue_Dac_Biet", SqlDbType.Int, 0)
                pThue_Dac_Biet.Value = Thue_Dac_Biet
                MyCommand.Parameters.Add(pThue_Dac_Biet)

                Dim pThue_Tieu_Thu As SqlParameter = New SqlParameter("@Thue_Tieu_Thu", SqlDbType.Int, 0)
                pThue_Tieu_Thu.Value = Thue_Tieu_Thu
                MyCommand.Parameters.Add(pThue_Tieu_Thu)

                Dim pThue_Qua_Tang As SqlParameter = New SqlParameter("@Thue_Qua_Tang", SqlDbType.Int, 0)
                pThue_Qua_Tang.Value = Thue_Qua_Tang
                MyCommand.Parameters.Add(pThue_Qua_Tang)

                Dim pThue_Han_Ngach As SqlParameter = New SqlParameter("@Thue_Han_Ngach", SqlDbType.Int, 0)
                pThue_Han_Ngach.Value = Thue_Han_Ngach
                MyCommand.Parameters.Add(pThue_Han_Ngach)

                Dim pThue_Uu_Dai As SqlParameter = New SqlParameter("@Thue_Uu_Dai", SqlDbType.Int, 0)
                pThue_Uu_Dai.Value = Thue_Uu_Dai
                MyCommand.Parameters.Add(pThue_Uu_Dai)

                Dim pTong_Thue As SqlParameter = New SqlParameter("@Tong_Thue", SqlDbType.Int, 0)
                pTong_Thue.Value = Tong_Thue
                MyCommand.Parameters.Add(pTong_Thue)

                Dim pLe_Phi_HQ As SqlParameter = New SqlParameter("@Le_Phi_HQ", SqlDbType.Int, 0)
                pLe_Phi_HQ.Value = Le_Phi_HQ
                MyCommand.Parameters.Add(pLe_Phi_HQ)

                Dim pLe_Phi_VH As SqlParameter = New SqlParameter("@Le_Phi_VH", SqlDbType.Int, 0)
                pLe_Phi_VH.Value = Le_Phi_VH
                MyCommand.Parameters.Add(pLe_Phi_VH)

                Dim pLe_Phi_YT As SqlParameter = New SqlParameter("@Le_Phi_YT", SqlDbType.Int, 0)
                pLe_Phi_YT.Value = Le_Phi_YT
                MyCommand.Parameters.Add(pLe_Phi_YT)

                Dim pLe_Phi_DV As SqlParameter = New SqlParameter("@Le_Phi_DV", SqlDbType.Int, 0)
                pLe_Phi_DV.Value = Le_Phi_DV
                MyCommand.Parameters.Add(pLe_Phi_DV)

                Dim pLe_Phi_TV As SqlParameter = New SqlParameter("@Le_Phi_TV", SqlDbType.Int, 0)
                pLe_Phi_TV.Value = Le_Phi_TV
                MyCommand.Parameters.Add(pLe_Phi_TV)

                Dim pLe_Phi_Khac As SqlParameter = New SqlParameter("@Le_Phi_Khac", SqlDbType.Int, 0)
                pLe_Phi_Khac.Value = Le_Phi_Khac
                MyCommand.Parameters.Add(pLe_Phi_Khac)

                Dim pTong_Le_Phi As SqlParameter = New SqlParameter("@Tong_Le_Phi", SqlDbType.Int, 0)
                pTong_Le_Phi.Value = Tong_Le_Phi
                MyCommand.Parameters.Add(pTong_Le_Phi)

                Dim pTong_Thue_Le_Phi As SqlParameter = New SqlParameter("@Tong_Thue_Le_Phi", SqlDbType.Int, 0)
                pTong_Thue_Le_Phi.Value = Tong_Thue_Le_Phi
                MyCommand.Parameters.Add(pTong_Thue_Le_Phi)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 0)
                pChot_SL.Value = Chot_SL
                MyCommand.Parameters.Add(pChot_SL)

                Dim pDa_Truyen As SqlParameter = New SqlParameter("@Da_Truyen", SqlDbType.Bit, 0)
                pDa_Truyen.Value = Da_Truyen
                MyCommand.Parameters.Add(pDa_Truyen)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Value = Ngay_He_Thong
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Value = Gio_He_Thong
                MyCommand.Parameters.Add(pGio_He_Thong)

                Dim pThu_Lan_1 As SqlParameter = New SqlParameter("@Thu_Lan_1", SqlDbType.Int, 0)
                pThu_Lan_1.Value = Thu_Lan_1
                MyCommand.Parameters.Add(pThu_Lan_1)

                Dim pNgay_Thu_1 As SqlParameter = New SqlParameter("@Ngay_Thu_1", SqlDbType.Int, 0)
                pNgay_Thu_1.Value = Ngay_Thu_1
                MyCommand.Parameters.Add(pNgay_Thu_1)

                Dim pThu_Lan_2 As SqlParameter = New SqlParameter("@Thu_Lan_2", SqlDbType.Int, 0)
                pThu_Lan_2.Value = Thu_Lan_2
                MyCommand.Parameters.Add(pThu_Lan_2)

                Dim pNgay_Thu_2 As SqlParameter = New SqlParameter("@Ngay_Thu_2", SqlDbType.Int, 0)
                pNgay_Thu_2.Value = Ngay_Thu_2
                MyCommand.Parameters.Add(pNgay_Thu_2)

                Dim pLy_Do_CH As SqlParameter = New SqlParameter("@Ly_Do_CH", SqlDbType.Int, 0)
                pLy_Do_CH.Value = Ly_Do_CH
                MyCommand.Parameters.Add(pLy_Do_CH)

                Dim pCo_Thu As SqlParameter = New SqlParameter("@Co_Thu", SqlDbType.Bit, 0)
                pCo_Thu.Value = Co_Thu
                MyCommand.Parameters.Add(pCo_Thu)


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

#Region "E1_Thu_No_Le_Phi_HQ_Xoa"
        Public Function E1_Thu_No_Le_Phi_HQ_Xoa(ByVal Id_E1 As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Thu_No_Le_Phi_HQ_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myE1_Thu_No_Le_Phi_HQ_Chi_Tiet As New E1_Thu_No_Le_Phi_HQ_Chi_Tiet

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

#Region "E1_Thu_No_Le_Phi_HQ_Cap_Nhat_Them_Trang_Thai_Chuyen_Hoan_Tu_E1_Di_Chuyen_Hoan"
        Public Function E1_Thu_No_Le_Phi_HQ_Cap_Nhat_Them_Trang_Thai_Chuyen_Hoan_Tu_E1_Di_Chuyen_Hoan(ByVal Id_E1 As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Thu_No_Le_Phi_HQ_Cap_Nhat_Them_Trang_Thai_Chuyen_Hoan_Tu_E1_Di_Chuyen_Hoan"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myE1_Thu_No_Le_Phi_HQ_Chi_Tiet As New E1_Thu_No_Le_Phi_HQ_Chi_Tiet

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

#Region "E1_Thu_No_Le_Phi_HQ_Xoa_Bo_Trang_Thai_Chuyen_Hoan_Tu_E1_Xuat_Chuyen_Hoan"
        Public Function E1_Thu_No_Le_Phi_HQ_Xoa_Bo_Trang_Thai_Chuyen_Hoan_Tu_E1_Xuat_Chuyen_Hoan(ByVal Id_E1 As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Thu_No_Le_Phi_HQ_Xoa_Bo_Trang_Thai_Chuyen_Hoan_Tu_E1_Xuat_Chuyen_Hoan"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myE1_Thu_No_Le_Phi_HQ_Chi_Tiet As New E1_Thu_No_Le_Phi_HQ_Chi_Tiet

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

#Region "E1_Thu_No_Le_Phi_HQ_Danh_Sach_Theo_Id_E1_Chuyen_Hoan"

        Public Function E1_Thu_No_Le_Phi_HQ_Danh_Sach_Theo_Id_E1_Chuyen_Hoan(ByVal Id_E1 As String) As DataSet

            ' The procedure returns these columns:
            ' Co_Thu
            ' Id_E1
            ' Ma_E1
            ' Ngay_Dong
            ' Gio_Dong
            ' Ma_Duong_Thu
            ' So_Chuyen_Thu
            ' Tui_So
            ' Ma_Tinh
            ' Khoi_Luong


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Thu_No_Le_Phi_HQ_Danh_Sach_Theo_Id_E1_Chuyen_Hoan"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                MyCommand.Parameters.Add(pId_E1)


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

#Region "E1_Thu_No_Le_Phi_HQ_Kiem_Tra_Trang_Thai_Chuyen_Hoan_Theo_Id_E1"
        Public Function E1_Thu_No_Le_Phi_HQ_Kiem_Tra_Trang_Thai_Chuyen_Hoan_Theo_Id_E1(ByVal Id_E1 As String) As Boolean
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Thu_No_Le_Phi_HQ_Kiem_Tra_Trang_Thai_Chuyen_Hoan_Theo_Id_E1"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myE1_Thu_No_Le_Phi_HQ_Chi_Tiet As New E1_Thu_No_Le_Phi_HQ_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try

                'Define the parameters

                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                MyCommand.Parameters.Add(pId_E1)

                Dim pIsValid As SqlParameter = New SqlParameter("@IsValid", SqlDbType.Bit, 0)
                pIsValid.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pIsValid)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()
                MyCommand.ExecuteNonQuery()

                Return pIsValid.Value
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

#Region "E1_Thu_No_Le_Phi_HQ_Danh_Sach_Thu_No_Theo_Ngay_Thu_Duong_Thu_Buu_Ta_Noi_Bo"

        Public Function E1_Thu_No_Le_Phi_HQ_Danh_Sach_Thu_No_Theo_Ngay_Thu_Duong_Thu_Buu_Ta_Noi_Bo(ByVal Ngay_Thu As Integer, ByVal Id_Duong_Thu As String) As DataSet

            ' The procedure returns these columns:
            ' Chon
            ' Id_E1
            ' Id_E2
            ' Id_Chuyen_Thu
            ' Id_Duong_Thu
            ' Ma_Bc_Khai_Thac
            ' Ngay_Dong
            ' Gio_Dong
            ' Ma_Tinh
            ' Don_Vi
            ' STT
            ' Nuoc_Nhan
            ' Ma_Bc_Nhan
            ' Ma_E1
            ' Nuoc_Tra
            ' Ma_Bc_Tra
            ' Khoi_Luong
            ' Phan_Loai
            ' Gia_Tri_Hang
            ' Ma_KH
            ' Nguoi_Gui
            ' Nguoi_Nhan
            ' Dia_Chi_Gui
            ' Dia_Chi_Nhan
            ' Dien_Thoai_Gui
            ' Dien_Thoai_Nhan
            ' Ghi_Chu
            ' Ngay_Den_VN
            ' Id_Nguoi_Dung
            ' So_TKHQ
            ' So_Bien_Lai
            ' Thue_NK
            ' Thue_VAT
            ' Thue_Dac_Biet
            ' Thue_Tieu_Thu
            ' Thue_Qua_Tang
            ' Thue_Han_Ngach
            ' Thue_Uu_Dai
            ' Tong_Thue
            ' Le_Phi_HQ
            ' Le_Phi_VH
            ' Le_Phi_YT
            ' Le_Phi_DV
            ' Le_Phi_TV
            ' Le_Phi_Khac
            ' Tong_Le_Phi
            ' Tong_Thue_Le_Phi
            ' Chot_SL
            ' Da_Truyen
            ' Ngay_He_Thong
            ' Gio_He_Thong
            ' Thu_Lan_1
            ' Ngay_Thu_1
            ' Thu_Lan_2
            ' Ngay_Thu_2
            ' Ly_Do_CH
            ' Co_Thu
            ' So_Chuyen_Thu
            ' Tui_So
            ' Tong_Tien_Thu


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Thu_No_Le_Phi_HQ_Danh_Sach_Thu_No_Theo_Ngay_Thu_Duong_Thu_Buu_Ta_Noi_Bo"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pNgay_Thu As SqlParameter = New SqlParameter("@Ngay_Thu", SqlDbType.Int, 0)
                pNgay_Thu.Value = Ngay_Thu
                MyCommand.Parameters.Add(pNgay_Thu)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pId_Duong_Thu)


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

#Region "E1_Thu_No_Le_Phi_HQ_Danh_Sach_Thu_No_Tu_Ngay_Den_Ngay_Theo_Duong_Thu_Buu_Ta_Noi_Bo"

        Public Function E1_Thu_No_Le_Phi_HQ_Danh_Sach_Thu_No_Tu_Ngay_Den_Ngay_Theo_Duong_Thu_Buu_Ta_Noi_Bo(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal Id_Duong_Thu As String) As DataSet

            ' The procedure returns these columns:
            ' Chon
            ' Id_E1
            ' Id_E2
            ' Id_Chuyen_Thu
            ' Id_Duong_Thu
            ' Ma_Bc_Khai_Thac
            ' Ngay_Dong
            ' Gio_Dong
            ' Ma_Tinh
            ' Don_Vi
            ' STT
            ' Nuoc_Nhan
            ' Ma_Bc_Nhan
            ' Ma_E1
            ' Nuoc_Tra
            ' Ma_Bc_Tra
            ' Khoi_Luong
            ' Phan_Loai
            ' Gia_Tri_Hang
            ' Ma_KH
            ' Nguoi_Gui
            ' Nguoi_Nhan
            ' Dia_Chi_Gui
            ' Dia_Chi_Nhan
            ' Dien_Thoai_Gui
            ' Dien_Thoai_Nhan
            ' Ghi_Chu
            ' Ngay_Den_VN
            ' Id_Nguoi_Dung
            ' So_TKHQ
            ' So_Bien_Lai
            ' Thue_NK
            ' Thue_VAT
            ' Thue_Dac_Biet
            ' Thue_Tieu_Thu
            ' Thue_Qua_Tang
            ' Thue_Han_Ngach
            ' Thue_Uu_Dai
            ' Tong_Thue
            ' Le_Phi_HQ
            ' Le_Phi_VH
            ' Le_Phi_YT
            ' Le_Phi_DV
            ' Le_Phi_TV
            ' Le_Phi_Khac
            ' Tong_Le_Phi
            ' Tong_Thue_Le_Phi
            ' Chot_SL
            ' Da_Truyen
            ' Ngay_He_Thong
            ' Gio_He_Thong
            ' Thu_Lan_1
            ' Ngay_Thu_1
            ' Thu_Lan_2
            ' Ngay_Thu_2
            ' Ly_Do_CH
            ' Co_Thu
            ' So_Chuyen_Thu
            ' Tui_So
            ' Tong_Tien_Thu


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Thu_No_Le_Phi_HQ_Danh_Sach_Thu_No_Tu_Ngay_Den_Ngay_Theo_Duong_Thu_Buu_Ta_Noi_Bo"
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

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pId_Duong_Thu)


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

#Region "E1_Thu_No_Le_Phi_HQ_Danh_Sach_Thu_No_Theo_Ngay_Thu_Ma_Tinh"

        Public Function E1_Thu_No_Le_Phi_HQ_Danh_Sach_Thu_No_Theo_Ngay_Thu_Ma_Tinh(ByVal Ngay_Thu As Integer, ByVal Ma_Tinh As Integer) As DataSet

            ' The procedure returns these columns:
            ' Chon
            ' Id_E1
            ' Id_E2
            ' Id_Chuyen_Thu
            ' Id_Duong_Thu
            ' Ma_Bc_Khai_Thac
            ' Ngay_Dong
            ' Gio_Dong
            ' Ma_Tinh
            ' Don_Vi
            ' STT
            ' Nuoc_Nhan
            ' Ma_Bc_Nhan
            ' Ma_E1
            ' Nuoc_Tra
            ' Ma_Bc_Tra
            ' Khoi_Luong
            ' Phan_Loai
            ' Gia_Tri_Hang
            ' Ma_KH
            ' Nguoi_Gui
            ' Nguoi_Nhan
            ' Dia_Chi_Gui
            ' Dia_Chi_Nhan
            ' Dien_Thoai_Gui
            ' Dien_Thoai_Nhan
            ' Ghi_Chu
            ' Ngay_Den_VN
            ' Id_Nguoi_Dung
            ' So_TKHQ
            ' So_Bien_Lai
            ' Thue_NK
            ' Thue_VAT
            ' Thue_Dac_Biet
            ' Thue_Tieu_Thu
            ' Thue_Qua_Tang
            ' Thue_Han_Ngach
            ' Thue_Uu_Dai
            ' Tong_Thue
            ' Le_Phi_HQ
            ' Le_Phi_VH
            ' Le_Phi_YT
            ' Le_Phi_DV
            ' Le_Phi_TV
            ' Le_Phi_Khac
            ' Tong_Le_Phi
            ' Tong_Thue_Le_Phi
            ' Chot_SL
            ' Da_Truyen
            ' Ngay_He_Thong
            ' Gio_He_Thong
            ' Thu_Lan_1
            ' Ngay_Thu_1
            ' Thu_Lan_2
            ' Ngay_Thu_2
            ' Ly_Do_CH
            ' Co_Thu
            ' So_Chuyen_Thu
            ' Tui_So
            ' Tong_Tien_Thu


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Thu_No_Le_Phi_HQ_Danh_Sach_Thu_No_Theo_Ngay_Thu_Ma_Tinh"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pNgay_Thu As SqlParameter = New SqlParameter("@Ngay_Thu", SqlDbType.Int, 0)
                pNgay_Thu.Value = Ngay_Thu
                MyCommand.Parameters.Add(pNgay_Thu)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 0)
                pMa_Tinh.Value = Ma_Tinh
                MyCommand.Parameters.Add(pMa_Tinh)


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

#Region "E1_Thu_No_Le_Phi_HQ_Danh_Sach_Thu_No_Tu_Ngay_Den_Ngay_Theo_Ma_Tinh"

        Public Function E1_Thu_No_Le_Phi_HQ_Danh_Sach_Thu_No_Tu_Ngay_Den_Ngay_Theo_Ma_Tinh(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal Ma_Tinh As Integer) As DataSet

            ' The procedure returns these columns:
            ' Chon
            ' Id_E1
            ' Id_E2
            ' Id_Chuyen_Thu
            ' Id_Duong_Thu
            ' Ma_Bc_Khai_Thac
            ' Ngay_Dong
            ' Gio_Dong
            ' Ma_Tinh
            ' Don_Vi
            ' STT
            ' Nuoc_Nhan
            ' Ma_Bc_Nhan
            ' Ma_E1
            ' Nuoc_Tra
            ' Ma_Bc_Tra
            ' Khoi_Luong
            ' Phan_Loai
            ' Gia_Tri_Hang
            ' Ma_KH
            ' Nguoi_Gui
            ' Nguoi_Nhan
            ' Dia_Chi_Gui
            ' Dia_Chi_Nhan
            ' Dien_Thoai_Gui
            ' Dien_Thoai_Nhan
            ' Ghi_Chu
            ' Ngay_Den_VN
            ' Id_Nguoi_Dung
            ' So_TKHQ
            ' So_Bien_Lai
            ' Thue_NK
            ' Thue_VAT
            ' Thue_Dac_Biet
            ' Thue_Tieu_Thu
            ' Thue_Qua_Tang
            ' Thue_Han_Ngach
            ' Thue_Uu_Dai
            ' Tong_Thue
            ' Le_Phi_HQ
            ' Le_Phi_VH
            ' Le_Phi_YT
            ' Le_Phi_DV
            ' Le_Phi_TV
            ' Le_Phi_Khac
            ' Tong_Le_Phi
            ' Tong_Thue_Le_Phi
            ' Chot_SL
            ' Da_Truyen
            ' Ngay_He_Thong
            ' Gio_He_Thong
            ' Thu_Lan_1
            ' Ngay_Thu_1
            ' Thu_Lan_2
            ' Ngay_Thu_2
            ' Ly_Do_CH
            ' Co_Thu
            ' So_Chuyen_Thu
            ' Tui_So
            ' Tong_Tien_Thu


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Thu_No_Le_Phi_HQ_Danh_Sach_Thu_No_Tu_Ngay_Den_Ngay_Theo_Ma_Tinh"
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

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 0)
                pMa_Tinh.Value = Ma_Tinh
                MyCommand.Parameters.Add(pMa_Tinh)


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

#Region "E1_Thu_No_Le_Phi_HQ_Cap_Nhat_Ngay_Thu_So_Tien_Thu"
        Public Function E1_Thu_No_Le_Phi_HQ_Cap_Nhat_Ngay_Thu_So_Tien_Thu(ByVal Id_E1 As String, ByVal Thu_Lan_1 As Integer, ByVal Ngay_Thu_1 As Integer, ByVal Thu_Lan_2 As Integer, ByVal Ngay_Thu_2 As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Thu_No_Le_Phi_HQ_Cap_Nhat_Ngay_Thu_So_Tien_Thu"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myE1_Thu_No_Le_Phi_HQ_Chi_Tiet As New E1_Thu_No_Le_Phi_HQ_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                MyCommand.Parameters.Add(pId_E1)

                Dim pThu_Lan_1 As SqlParameter = New SqlParameter("@Thu_Lan_1", SqlDbType.Int, 0)
                pThu_Lan_1.Value = Thu_Lan_1
                MyCommand.Parameters.Add(pThu_Lan_1)

                Dim pNgay_Thu_1 As SqlParameter = New SqlParameter("@Ngay_Thu_1", SqlDbType.Int, 0)
                pNgay_Thu_1.Value = Ngay_Thu_1
                MyCommand.Parameters.Add(pNgay_Thu_1)

                Dim pThu_Lan_2 As SqlParameter = New SqlParameter("@Thu_Lan_2", SqlDbType.Int, 0)
                pThu_Lan_2.Value = Thu_Lan_2
                MyCommand.Parameters.Add(pThu_Lan_2)

                Dim pNgay_Thu_2 As SqlParameter = New SqlParameter("@Ngay_Thu_2", SqlDbType.Int, 0)
                pNgay_Thu_2.Value = Ngay_Thu_2
                MyCommand.Parameters.Add(pNgay_Thu_2)


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

#Region "E1_Thu_No_Le_Phi_HQ_Danh_Sach_Thu_No_Tu_Ngay_Den_Ngay_Theo_Duong_Thu_Buu_Ta_Noi_Bo_Ma_E1"

        Public Function E1_Thu_No_Le_Phi_HQ_Danh_Sach_Thu_No_Tu_Ngay_Den_Ngay_Theo_Duong_Thu_Buu_Ta_Noi_Bo_Ma_E1(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal Id_Duong_Thu As String, ByVal Ma_E1 As String) As DataSet

            ' The procedure returns these columns:
            ' Chon
            ' Id_E1
            ' Id_E2
            ' Id_Chuyen_Thu
            ' Id_Duong_Thu
            ' Ma_Bc_Khai_Thac
            ' Ngay_Dong
            ' Gio_Dong
            ' Ma_Tinh
            ' Don_Vi
            ' STT
            ' Nuoc_Nhan
            ' Ma_Bc_Nhan
            ' Ma_E1
            ' Nuoc_Tra
            ' Ma_Bc_Tra
            ' Khoi_Luong
            ' Phan_Loai
            ' Gia_Tri_Hang
            ' Ma_KH
            ' Nguoi_Gui
            ' Nguoi_Nhan
            ' Dia_Chi_Gui
            ' Dia_Chi_Nhan
            ' Dien_Thoai_Gui
            ' Dien_Thoai_Nhan
            ' Ghi_Chu
            ' Ngay_Den_VN
            ' Id_Nguoi_Dung
            ' So_TKHQ
            ' So_Bien_Lai
            ' Thue_NK
            ' Thue_VAT
            ' Thue_Dac_Biet
            ' Thue_Tieu_Thu
            ' Thue_Qua_Tang
            ' Thue_Han_Ngach
            ' Thue_Uu_Dai
            ' Tong_Thue
            ' Le_Phi_HQ
            ' Le_Phi_VH
            ' Le_Phi_YT
            ' Le_Phi_DV
            ' Le_Phi_TV
            ' Le_Phi_Khac
            ' Tong_Le_Phi
            ' Tong_Thue_Le_Phi
            ' Chot_SL
            ' Da_Truyen
            ' Ngay_He_Thong
            ' Gio_He_Thong
            ' Thu_Lan_1
            ' Ngay_Thu_1
            ' Thu_Lan_2
            ' Ngay_Thu_2
            ' Ly_Do_CH
            ' Co_Thu
            ' So_Chuyen_Thu
            ' Tui_So
            ' Tong_Tien_Thu


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Thu_No_Le_Phi_HQ_Danh_Sach_Thu_No_Tu_Ngay_Den_Ngay_Theo_Duong_Thu_Buu_Ta_Noi_Bo_Ma_E1"
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

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 14)
                pMa_E1.Value = Ma_E1
                MyCommand.Parameters.Add(pMa_E1)


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


#Region "E1_Thu_No_Le_Phi_HQ_Danh_Sach_Thu_No_Tu_Ngay_Den_Ngay_Theo_Ma_Tinh_Ma_E1"

        Public Function E1_Thu_No_Le_Phi_HQ_Danh_Sach_Thu_No_Tu_Ngay_Den_Ngay_Theo_Ma_Tinh_Ma_E1(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal Ma_Tinh As Integer, ByVal Ma_E1 As String) As DataSet

            ' The procedure returns these columns:
            ' Chon
            ' Id_E1
            ' Id_E2
            ' Id_Chuyen_Thu
            ' Id_Duong_Thu
            ' Ma_Bc_Khai_Thac
            ' Ngay_Dong
            ' Gio_Dong
            ' Ma_Tinh
            ' Don_Vi
            ' STT
            ' Nuoc_Nhan
            ' Ma_Bc_Nhan
            ' Ma_E1
            ' Nuoc_Tra
            ' Ma_Bc_Tra
            ' Khoi_Luong
            ' Phan_Loai
            ' Gia_Tri_Hang
            ' Ma_KH
            ' Nguoi_Gui
            ' Nguoi_Nhan
            ' Dia_Chi_Gui
            ' Dia_Chi_Nhan
            ' Dien_Thoai_Gui
            ' Dien_Thoai_Nhan
            ' Ghi_Chu
            ' Ngay_Den_VN
            ' Id_Nguoi_Dung
            ' So_TKHQ
            ' So_Bien_Lai
            ' Thue_NK
            ' Thue_VAT
            ' Thue_Dac_Biet
            ' Thue_Tieu_Thu
            ' Thue_Qua_Tang
            ' Thue_Han_Ngach
            ' Thue_Uu_Dai
            ' Tong_Thue
            ' Le_Phi_HQ
            ' Le_Phi_VH
            ' Le_Phi_YT
            ' Le_Phi_DV
            ' Le_Phi_TV
            ' Le_Phi_Khac
            ' Tong_Le_Phi
            ' Tong_Thue_Le_Phi
            ' Chot_SL
            ' Da_Truyen
            ' Ngay_He_Thong
            ' Gio_He_Thong
            ' Thu_Lan_1
            ' Ngay_Thu_1
            ' Thu_Lan_2
            ' Ngay_Thu_2
            ' Ly_Do_CH
            ' Co_Thu
            ' So_Chuyen_Thu
            ' Tui_So
            ' Tong_Tien_Thu


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Thu_No_Le_Phi_HQ_Danh_Sach_Thu_No_Tu_Ngay_Den_Ngay_Theo_Ma_Tinh_Ma_E1"
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

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 0)
                pMa_Tinh.Value = Ma_Tinh
                MyCommand.Parameters.Add(pMa_Tinh)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 14)
                pMa_E1.Value = Ma_E1
                MyCommand.Parameters.Add(pMa_E1)


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


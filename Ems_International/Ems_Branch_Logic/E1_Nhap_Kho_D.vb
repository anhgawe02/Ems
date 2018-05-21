

Imports System
Imports System.Data
Imports System.Data.SqlClient

Namespace EMS
#Region "E1_Nhap_Kho_D_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop E1_Nhap_Kho_D_Chi_Tiet
    'Tuong ung voi moi truong trong bang E1_Nhap_Kho_D trong co so du lieu
    '***********************************************************
    Public Class E1_Nhap_Kho_D_Chi_Tiet
        Public Id_E1 As String
        Public Ma_The_Kho As String
        Public Id_Duong_Thu As String
        Public Id_Chuyen_Thu As String
        Public Id_E2 As String
        Public Ma_Kho As Integer
        Public Ma_E1 As String
        Public Ngay_Dong As Integer
        Public Gio_Dong As Integer
        Public Nuoc_Nhan As String
        Public Nuoc_Tra As String
        Public Ma_Bc_Nhan As Integer
        Public Ma_Bc_Tra As Integer
        Public Khoi_Luong As Integer
        Public Phan_Loai As String
        Public Gia_Tri_Hang As Integer
        Public STT As Integer
        Public Ngay_Nhan As Integer
        Public Gio_Nhan As Integer
        Public Ma_KH As String
        Public Nguoi_Gui As String
        Public Nguoi_Nhan As String
        Public Dia_Chi_Gui As String
        Public Dia_Chi_Nhan As String
        Public Dien_Thoai_Gui As String
        Public Dien_Thoai_Nhan As String
        Public So_TKHQ As String
        Public So_Bien_Lai As String
        Public Le_Phi_HQ As Integer
        Public Thue_NK As Integer
        Public Thue_VAT As Integer
        Public Thue_Dac_Biet As Integer
        Public Thue_Tieu_Thu As Integer
        Public Thue_Qua_Tang As Integer
        Public Thue_Han_Ngach As Integer
        Public Thue_Uu_Dai As Integer
        Public Tong_Thue As Integer
        Public Ma_Ly_Do As Integer
        Public Id_Nguoi_Dung As Integer
        Public Ghi_Chu As String
        Public Ngay_He_Thong As Integer
        Public Gio_He_Thong As Integer
        Public Id_Ky_Han As String
        Public Da_Truyen As Boolean
        Public Chot_SL As Boolean
        Public Ma_To_Khai As String
    End Class
#End Region

#Region "E1_Nhap_Kho_D"
    Public Class E1_Nhap_Kho_D
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "E1_Nhap_Kho_D_Cap_Nhat"
        Public Function E1_Nhap_Kho_D_Cap_Nhat(ByVal Id_E1 As String, ByVal Ma_The_Kho As String, ByVal Id_Duong_Thu As String, ByVal Id_Chuyen_Thu As String, ByVal Id_E2 As String, ByVal Ma_Kho As Integer, ByVal Ma_E1 As String, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Nuoc_Nhan As String, ByVal Nuoc_Tra As String, ByVal Ma_Bc_Nhan As Integer, ByVal Ma_Bc_Tra As Integer, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal Gia_Tri_Hang As Integer, ByVal STT As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Ma_KH As String, ByVal Nguoi_Gui As String, ByVal Nguoi_Nhan As String, ByVal Dia_Chi_Gui As String, ByVal Dia_Chi_Nhan As String, ByVal Dien_Thoai_Gui As String, ByVal Dien_Thoai_Nhan As String, ByVal So_TKHQ As String, ByVal So_Bien_Lai As String, ByVal Le_Phi_HQ As Integer, ByVal Thue_NK As Integer, ByVal Thue_VAT As Integer, ByVal Thue_Dac_Biet As Integer, ByVal Thue_Tieu_Thu As Integer, ByVal Thue_Qua_Tang As Integer, ByVal Thue_Han_Ngach As Integer, ByVal Thue_Uu_Dai As Integer, ByVal Tong_Thue As Integer, ByVal Ma_Ly_Do As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Ghi_Chu As String, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer, ByVal Id_Ky_Han As String, ByVal Da_Truyen As Boolean, ByVal Chot_SL As Boolean, ByVal Ma_To_Khai As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Nhap_Kho_D_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                MyCommand.Parameters.Add(pId_E1)

                Dim pMa_The_Kho As SqlParameter = New SqlParameter("@Ma_The_Kho", SqlDbType.VarChar, 27)
                pMa_The_Kho.Value = Ma_The_Kho
                MyCommand.Parameters.Add(pMa_The_Kho)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                MyCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                MyCommand.Parameters.Add(pId_E2)

                Dim pMa_Kho As SqlParameter = New SqlParameter("@Ma_Kho", SqlDbType.Int, 0)
                pMa_Kho.Value = Ma_Kho
                MyCommand.Parameters.Add(pMa_Kho)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                MyCommand.Parameters.Add(pMa_E1)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 0)
                pNgay_Dong.Value = Ngay_Dong
                MyCommand.Parameters.Add(pNgay_Dong)

                Dim pGio_Dong As SqlParameter = New SqlParameter("@Gio_Dong", SqlDbType.Int, 0)
                pGio_Dong.Value = Gio_Dong
                MyCommand.Parameters.Add(pGio_Dong)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Value = Nuoc_Nhan
                MyCommand.Parameters.Add(pNuoc_Nhan)

                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2)
                pNuoc_Tra.Value = Nuoc_Tra
                MyCommand.Parameters.Add(pNuoc_Tra)

                Dim pMa_Bc_Nhan As SqlParameter = New SqlParameter("@Ma_Bc_Nhan", SqlDbType.Int, 0)
                pMa_Bc_Nhan.Value = Ma_Bc_Nhan
                MyCommand.Parameters.Add(pMa_Bc_Nhan)

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

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Value = STT
                MyCommand.Parameters.Add(pSTT)

                Dim pNgay_Nhan As SqlParameter = New SqlParameter("@Ngay_Nhan", SqlDbType.Int, 0)
                pNgay_Nhan.Value = Ngay_Nhan
                MyCommand.Parameters.Add(pNgay_Nhan)

                Dim pGio_Nhan As SqlParameter = New SqlParameter("@Gio_Nhan", SqlDbType.Int, 0)
                pGio_Nhan.Value = Gio_Nhan
                MyCommand.Parameters.Add(pGio_Nhan)

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

                Dim pSo_TKHQ As SqlParameter = New SqlParameter("@So_TKHQ", SqlDbType.VarChar, 20)
                pSo_TKHQ.Value = So_TKHQ
                MyCommand.Parameters.Add(pSo_TKHQ)

                Dim pSo_Bien_Lai As SqlParameter = New SqlParameter("@So_Bien_Lai", SqlDbType.VarChar, 20)
                pSo_Bien_Lai.Value = So_Bien_Lai
                MyCommand.Parameters.Add(pSo_Bien_Lai)

                Dim pLe_Phi_HQ As SqlParameter = New SqlParameter("@Le_Phi_HQ", SqlDbType.Int, 0)
                pLe_Phi_HQ.Value = Le_Phi_HQ
                MyCommand.Parameters.Add(pLe_Phi_HQ)

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

                Dim pMa_Ly_Do As SqlParameter = New SqlParameter("@Ma_Ly_Do", SqlDbType.Int, 0)
                pMa_Ly_Do.Value = Ma_Ly_Do
                MyCommand.Parameters.Add(pMa_Ly_Do)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                MyCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Value = Ngay_He_Thong
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Value = Gio_He_Thong
                MyCommand.Parameters.Add(pGio_He_Thong)

                Dim pId_Ky_Han As SqlParameter = New SqlParameter("@Id_Ky_Han", SqlDbType.VarChar, 15)
                pId_Ky_Han.Value = Id_Ky_Han
                MyCommand.Parameters.Add(pId_Ky_Han)

                Dim pDa_Truyen As SqlParameter = New SqlParameter("@Da_Truyen", SqlDbType.Bit, 0)
                pDa_Truyen.Value = Da_Truyen
                MyCommand.Parameters.Add(pDa_Truyen)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 0)
                pChot_SL.Value = Chot_SL
                MyCommand.Parameters.Add(pChot_SL)

                Dim pMa_To_Khai As SqlParameter = New SqlParameter("@Ma_To_Khai", SqlDbType.VarChar, 20)
                pMa_To_Khai.Value = Ma_To_Khai
                MyCommand.Parameters.Add(pMa_To_Khai)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()

                'Return numRows
                Return numRows

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

#Region "E1_Nhap_Kho_D_Cap_Nhat_Them"
        Public Function E1_Nhap_Kho_D_Cap_Nhat_Them(ByVal Id_E1 As String, ByVal Ma_The_Kho As String, ByVal Id_Duong_Thu As String, ByVal Id_Chuyen_Thu As String, ByVal Id_E2 As String, ByVal Ma_Kho As Integer, ByVal Ma_E1 As String, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Nuoc_Nhan As String, ByVal Nuoc_Tra As String, ByVal Ma_Bc_Nhan As Integer, ByVal Ma_Bc_Tra As Integer, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal Gia_Tri_Hang As Integer, ByVal STT As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Ma_KH As String, ByVal Nguoi_Gui As String, ByVal Nguoi_Nhan As String, ByVal Dia_Chi_Gui As String, ByVal Dia_Chi_Nhan As String, ByVal Dien_Thoai_Gui As String, ByVal Dien_Thoai_Nhan As String, ByVal So_TKHQ As String, ByVal So_Bien_Lai As String, ByVal Le_Phi_HQ As Integer, ByVal Thue_NK As Integer, ByVal Thue_VAT As Integer, ByVal Thue_Dac_Biet As Integer, ByVal Thue_Tieu_Thu As Integer, ByVal Thue_Qua_Tang As Integer, ByVal Thue_Han_Ngach As Integer, ByVal Thue_Uu_Dai As Integer, ByVal Tong_Thue As Integer, ByVal Ma_Ly_Do As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Ghi_Chu As String, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer, ByVal Id_Ky_Han As String, ByVal Da_Truyen As Boolean, ByVal Chot_SL As Boolean, ByVal Ma_To_Khai As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Nhap_Kho_D_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                MyCommand.Parameters.Add(pId_E1)

                Dim pMa_The_Kho As SqlParameter = New SqlParameter("@Ma_The_Kho", SqlDbType.VarChar, 27)
                pMa_The_Kho.Value = Ma_The_Kho
                MyCommand.Parameters.Add(pMa_The_Kho)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                MyCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                MyCommand.Parameters.Add(pId_E2)

                Dim pMa_Kho As SqlParameter = New SqlParameter("@Ma_Kho", SqlDbType.Int, 0)
                pMa_Kho.Value = Ma_Kho
                MyCommand.Parameters.Add(pMa_Kho)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                MyCommand.Parameters.Add(pMa_E1)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 0)
                pNgay_Dong.Value = Ngay_Dong
                MyCommand.Parameters.Add(pNgay_Dong)

                Dim pGio_Dong As SqlParameter = New SqlParameter("@Gio_Dong", SqlDbType.Int, 0)
                pGio_Dong.Value = Gio_Dong
                MyCommand.Parameters.Add(pGio_Dong)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Value = Nuoc_Nhan
                MyCommand.Parameters.Add(pNuoc_Nhan)

                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2)
                pNuoc_Tra.Value = Nuoc_Tra
                MyCommand.Parameters.Add(pNuoc_Tra)

                Dim pMa_Bc_Nhan As SqlParameter = New SqlParameter("@Ma_Bc_Nhan", SqlDbType.Int, 0)
                pMa_Bc_Nhan.Value = Ma_Bc_Nhan
                MyCommand.Parameters.Add(pMa_Bc_Nhan)

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

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Value = STT
                MyCommand.Parameters.Add(pSTT)

                Dim pNgay_Nhan As SqlParameter = New SqlParameter("@Ngay_Nhan", SqlDbType.Int, 0)
                pNgay_Nhan.Value = Ngay_Nhan
                MyCommand.Parameters.Add(pNgay_Nhan)

                Dim pGio_Nhan As SqlParameter = New SqlParameter("@Gio_Nhan", SqlDbType.Int, 0)
                pGio_Nhan.Value = Gio_Nhan
                MyCommand.Parameters.Add(pGio_Nhan)

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

                Dim pSo_TKHQ As SqlParameter = New SqlParameter("@So_TKHQ", SqlDbType.VarChar, 20)
                pSo_TKHQ.Value = So_TKHQ
                MyCommand.Parameters.Add(pSo_TKHQ)

                Dim pSo_Bien_Lai As SqlParameter = New SqlParameter("@So_Bien_Lai", SqlDbType.VarChar, 20)
                pSo_Bien_Lai.Value = So_Bien_Lai
                MyCommand.Parameters.Add(pSo_Bien_Lai)

                Dim pLe_Phi_HQ As SqlParameter = New SqlParameter("@Le_Phi_HQ", SqlDbType.Int, 0)
                pLe_Phi_HQ.Value = Le_Phi_HQ
                MyCommand.Parameters.Add(pLe_Phi_HQ)

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

                Dim pMa_Ly_Do As SqlParameter = New SqlParameter("@Ma_Ly_Do", SqlDbType.Int, 0)
                pMa_Ly_Do.Value = Ma_Ly_Do
                MyCommand.Parameters.Add(pMa_Ly_Do)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                MyCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Value = Ngay_He_Thong
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Value = Gio_He_Thong
                MyCommand.Parameters.Add(pGio_He_Thong)

                Dim pId_Ky_Han As SqlParameter = New SqlParameter("@Id_Ky_Han", SqlDbType.VarChar, 15)
                pId_Ky_Han.Value = Id_Ky_Han
                MyCommand.Parameters.Add(pId_Ky_Han)

                Dim pDa_Truyen As SqlParameter = New SqlParameter("@Da_Truyen", SqlDbType.Bit, 0)
                pDa_Truyen.Value = Da_Truyen
                MyCommand.Parameters.Add(pDa_Truyen)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 0)
                pChot_SL.Value = Chot_SL
                MyCommand.Parameters.Add(pChot_SL)

                Dim pMa_To_Khai As SqlParameter = New SqlParameter("@Ma_To_Khai", SqlDbType.VarChar, 20)
                pMa_To_Khai.Value = Ma_To_Khai
                MyCommand.Parameters.Add(pMa_To_Khai)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()

                'Return numRows
                Return numRows

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


#Region "E1_Nhap_Kho_D_Danh_Sach"
        Public Function E1_Nhap_Kho_D_Danh_Sach() As DataSet
            ' The procedure returns these columns:
            ' Id_E1
            ' Ma_The_Kho
            ' Id_Duong_Thu
            ' Id_Chuyen_Thu
            ' Id_E2
            ' Ma_Kho
            ' Ma_E1
            ' Ngay_Dong
            ' Gio_Dong
            ' Nuoc_Nhan
            ' Nuoc_Tra
            ' Ma_Bc_Nhan
            ' Ma_Bc_Tra
            ' Khoi_Luong
            ' Phan_Loai
            ' Gia_Tri_Hang
            ' STT
            ' Ngay_Nhan
            ' Gio_Nhan
            ' Ma_KH
            ' Nguoi_Gui
            ' Nguoi_Nhan
            ' Dia_Chi_Gui
            ' Dia_Chi_Nhan
            ' Dien_Thoai_Gui
            ' Dien_Thoai_Nhan
            ' So_TKHQ
            ' So_Bien_Lai
            ' Le_Phi_HQ
            ' Thue_NK
            ' Thue_VAT
            ' Thue_Dac_Biet
            ' Thue_Tieu_Thu
            ' Thue_Qua_Tang
            ' Thue_Han_Ngach
            ' Thue_Uu_Dai
            ' Tong_Thue
            ' Ma_Ly_Do
            ' Id_Nguoi_Dung
            ' Ghi_Chu
            ' Ngay_He_Thong
            ' Gio_He_Thong
            ' Id_Ky_Han
            ' Da_Truyen
            ' Chot_SL
            ' Ma_To_Khai


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Nhap_Kho_D_Danh_Sach"
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


#Region "E1_Nhap_Kho_D_Danh_Sach_Chua_Kiem_Hoa_Theo_Ngay"
        Public Function E1_Nhap_Kho_D_Danh_Sach_Chua_Kiem_Hoa_Theo_Ngay(ByVal Ngay_Nhan As Integer, ByVal Ma_Kho As Integer) As DataSet
            ' The procedure returns these columns:
            ' Id_E1
            ' Ma_The_Kho
            ' Id_Duong_Thu
            ' Id_Chuyen_Thu
            ' Id_E2
            ' Ma_Kho
            ' Ma_E1
            ' Ngay_Dong
            ' Gio_Dong
            ' Nuoc_Nhan
            ' Nuoc_Tra
            ' Ma_Bc_Nhan
            ' Ma_Bc_Tra
            ' Khoi_Luong
            ' Phan_Loai
            ' Gia_Tri_Hang
            ' STT
            ' Ngay_Nhan
            ' Gio_Nhan
            ' Ma_KH
            ' Nguoi_Gui
            ' Nguoi_Nhan
            ' Dia_Chi_Gui
            ' Dia_Chi_Nhan
            ' Dien_Thoai_Gui
            ' Dien_Thoai_Nhan
            ' So_TKHQ
            ' So_Bien_Lai
            ' Le_Phi_HQ
            ' Thue_NK
            ' Thue_VAT
            ' Thue_Dac_Biet
            ' Thue_Tieu_Thu
            ' Thue_Qua_Tang
            ' Thue_Han_Ngach
            ' Thue_Uu_Dai
            ' Tong_Thue
            ' Ma_Ly_Do
            ' Id_Nguoi_Dung
            ' Ghi_Chu
            ' Ngay_He_Thong
            ' Gio_He_Thong
            ' Id_Ky_Han
            ' Da_Truyen
            ' Chot_SL


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Nhap_Kho_D_Danh_Sach_Chua_Kiem_Hoa_Theo_Ngay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try

                'Define the parameters

                Dim pNgay_Nhan As SqlParameter = New SqlParameter("@Ngay_Nhan", SqlDbType.Int, 0)
                pNgay_Nhan.Value = Ngay_Nhan
                MyCommand.Parameters.Add(pNgay_Nhan)

                Dim pMa_Kho As SqlParameter = New SqlParameter("@Ma_Kho", SqlDbType.Int, 0)
                pMa_Kho.Value = Ma_Kho
                MyCommand.Parameters.Add(pMa_Kho)


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

#Region "E1_Nhap_Kho_D_Lay"
        Public Function E1_Nhap_Kho_D_Lay(ByVal Id_E1 As String) As E1_Nhap_Kho_D_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Nhap_Kho_D_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myE1_Nhap_Kho_D_Chi_Tiet As New E1_Nhap_Kho_D_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                MyCommand.Parameters.Add(pId_E1)

                Dim pMa_The_Kho As SqlParameter = New SqlParameter("@Ma_The_Kho", SqlDbType.VarChar, 27)
                pMa_The_Kho.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_The_Kho)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_E2)

                Dim pMa_Kho As SqlParameter = New SqlParameter("@Ma_Kho", SqlDbType.Int, 0)
                pMa_Kho.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Kho)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_E1)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 0)
                pNgay_Dong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Dong)

                Dim pGio_Dong As SqlParameter = New SqlParameter("@Gio_Dong", SqlDbType.Int, 0)
                pGio_Dong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Dong)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNuoc_Nhan)

                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2)
                pNuoc_Tra.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNuoc_Tra)

                Dim pMa_Bc_Nhan As SqlParameter = New SqlParameter("@Ma_Bc_Nhan", SqlDbType.Int, 0)
                pMa_Bc_Nhan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc_Nhan)

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

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSTT)

                Dim pNgay_Nhan As SqlParameter = New SqlParameter("@Ngay_Nhan", SqlDbType.Int, 0)
                pNgay_Nhan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Nhan)

                Dim pGio_Nhan As SqlParameter = New SqlParameter("@Gio_Nhan", SqlDbType.Int, 0)
                pGio_Nhan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Nhan)

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

                Dim pSo_TKHQ As SqlParameter = New SqlParameter("@So_TKHQ", SqlDbType.VarChar, 20)
                pSo_TKHQ.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSo_TKHQ)

                Dim pSo_Bien_Lai As SqlParameter = New SqlParameter("@So_Bien_Lai", SqlDbType.VarChar, 20)
                pSo_Bien_Lai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSo_Bien_Lai)

                Dim pLe_Phi_HQ As SqlParameter = New SqlParameter("@Le_Phi_HQ", SqlDbType.Int, 0)
                pLe_Phi_HQ.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pLe_Phi_HQ)

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

                Dim pMa_Ly_Do As SqlParameter = New SqlParameter("@Ma_Ly_Do", SqlDbType.Int, 0)
                pMa_Ly_Do.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Ly_Do)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0)
                pId_Nguoi_Dung.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
                pGhi_Chu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_He_Thong)

                Dim pId_Ky_Han As SqlParameter = New SqlParameter("@Id_Ky_Han", SqlDbType.VarChar, 15)
                pId_Ky_Han.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Ky_Han)

                Dim pDa_Truyen As SqlParameter = New SqlParameter("@Da_Truyen", SqlDbType.Bit, 0)
                pDa_Truyen.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDa_Truyen)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 0)
                pChot_SL.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pChot_SL)

                Dim pMa_To_Khai As SqlParameter = New SqlParameter("@Ma_To_Khai", SqlDbType.VarChar, 20)
                pMa_To_Khai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_To_Khai)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myE1_Nhap_Kho_D_Chi_Tiet.Id_E1 = Id_E1
                myE1_Nhap_Kho_D_Chi_Tiet.Ma_The_Kho = pMa_The_Kho.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Id_Duong_Thu = pId_Duong_Thu.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Id_Chuyen_Thu = pId_Chuyen_Thu.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Id_E2 = pId_E2.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Ma_Kho = pMa_Kho.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Ma_E1 = pMa_E1.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Ngay_Dong = pNgay_Dong.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Gio_Dong = pGio_Dong.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Nuoc_Nhan = pNuoc_Nhan.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Nuoc_Tra = pNuoc_Tra.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Ma_Bc_Nhan = pMa_Bc_Nhan.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Ma_Bc_Tra = pMa_Bc_Tra.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Khoi_Luong = pKhoi_Luong.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Phan_Loai = pPhan_Loai.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Gia_Tri_Hang = pGia_Tri_Hang.Value
                myE1_Nhap_Kho_D_Chi_Tiet.STT = pSTT.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Ngay_Nhan = pNgay_Nhan.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Gio_Nhan = pGio_Nhan.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Ma_KH = pMa_KH.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Nguoi_Gui = pNguoi_Gui.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Nguoi_Nhan = pNguoi_Nhan.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Dia_Chi_Gui = pDia_Chi_Gui.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Dia_Chi_Nhan = pDia_Chi_Nhan.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Dien_Thoai_Gui = pDien_Thoai_Gui.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Dien_Thoai_Nhan = pDien_Thoai_Nhan.Value
                myE1_Nhap_Kho_D_Chi_Tiet.So_TKHQ = pSo_TKHQ.Value
                myE1_Nhap_Kho_D_Chi_Tiet.So_Bien_Lai = pSo_Bien_Lai.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Le_Phi_HQ = pLe_Phi_HQ.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Thue_NK = pThue_NK.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Thue_VAT = pThue_VAT.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Thue_Dac_Biet = pThue_Dac_Biet.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Thue_Tieu_Thu = pThue_Tieu_Thu.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Thue_Qua_Tang = pThue_Qua_Tang.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Thue_Han_Ngach = pThue_Han_Ngach.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Thue_Uu_Dai = pThue_Uu_Dai.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Tong_Thue = pTong_Thue.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Ma_Ly_Do = pMa_Ly_Do.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Id_Nguoi_Dung = pId_Nguoi_Dung.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Gio_He_Thong = pGio_He_Thong.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Id_Ky_Han = pId_Ky_Han.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Da_Truyen = pDa_Truyen.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Chot_SL = pChot_SL.Value
                myE1_Nhap_Kho_D_Chi_Tiet.Ma_To_Khai = pMa_To_Khai.Value

                Return myE1_Nhap_Kho_D_Chi_Tiet
                'Return myE1_Nhap_Kho_D_Chi_Tiet

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

#Region "E1_Nhap_Kho_D_Them"
        Public Function E1_Nhap_Kho_D_Them(ByVal Id_E1 As String, ByVal Ma_The_Kho As String, ByVal Id_Duong_Thu As String, ByVal Id_Chuyen_Thu As String, ByVal Id_E2 As String, ByVal Ma_Kho As Integer, ByVal Ma_E1 As String, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Nuoc_Nhan As String, ByVal Nuoc_Tra As String, ByVal Ma_Bc_Nhan As Integer, ByVal Ma_Bc_Tra As Integer, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal Gia_Tri_Hang As Integer, ByVal STT As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Ma_KH As String, ByVal Nguoi_Gui As String, ByVal Nguoi_Nhan As String, ByVal Dia_Chi_Gui As String, ByVal Dia_Chi_Nhan As String, ByVal Dien_Thoai_Gui As String, ByVal Dien_Thoai_Nhan As String, ByVal So_TKHQ As String, ByVal So_Bien_Lai As String, ByVal Le_Phi_HQ As Integer, ByVal Thue_NK As Integer, ByVal Thue_VAT As Integer, ByVal Thue_Dac_Biet As Integer, ByVal Thue_Tieu_Thu As Integer, ByVal Thue_Qua_Tang As Integer, ByVal Thue_Han_Ngach As Integer, ByVal Thue_Uu_Dai As Integer, ByVal Tong_Thue As Integer, ByVal Ma_Ly_Do As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Ghi_Chu As String, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer, ByVal Id_Ky_Han As String, ByVal Da_Truyen As Boolean, ByVal Chot_SL As Boolean, ByVal Ma_To_Khai As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Nhap_Kho_D_Them"
            MyCommand.CommandType = CommandType.StoredProcedure

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                MyCommand.Parameters.Add(pId_E1)

                Dim pMa_The_Kho As SqlParameter = New SqlParameter("@Ma_The_Kho", SqlDbType.VarChar, 27)
                pMa_The_Kho.Value = Ma_The_Kho
                MyCommand.Parameters.Add(pMa_The_Kho)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                MyCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                MyCommand.Parameters.Add(pId_E2)

                Dim pMa_Kho As SqlParameter = New SqlParameter("@Ma_Kho", SqlDbType.Int, 0)
                pMa_Kho.Value = Ma_Kho
                MyCommand.Parameters.Add(pMa_Kho)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                MyCommand.Parameters.Add(pMa_E1)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 0)
                pNgay_Dong.Value = Ngay_Dong
                MyCommand.Parameters.Add(pNgay_Dong)

                Dim pGio_Dong As SqlParameter = New SqlParameter("@Gio_Dong", SqlDbType.Int, 0)
                pGio_Dong.Value = Gio_Dong
                MyCommand.Parameters.Add(pGio_Dong)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Value = Nuoc_Nhan
                MyCommand.Parameters.Add(pNuoc_Nhan)

                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2)
                pNuoc_Tra.Value = Nuoc_Tra
                MyCommand.Parameters.Add(pNuoc_Tra)

                Dim pMa_Bc_Nhan As SqlParameter = New SqlParameter("@Ma_Bc_Nhan", SqlDbType.Int, 0)
                pMa_Bc_Nhan.Value = Ma_Bc_Nhan
                MyCommand.Parameters.Add(pMa_Bc_Nhan)

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

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Value = STT
                MyCommand.Parameters.Add(pSTT)

                Dim pNgay_Nhan As SqlParameter = New SqlParameter("@Ngay_Nhan", SqlDbType.Int, 0)
                pNgay_Nhan.Value = Ngay_Nhan
                MyCommand.Parameters.Add(pNgay_Nhan)

                Dim pGio_Nhan As SqlParameter = New SqlParameter("@Gio_Nhan", SqlDbType.Int, 0)
                pGio_Nhan.Value = Gio_Nhan
                MyCommand.Parameters.Add(pGio_Nhan)

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

                Dim pSo_TKHQ As SqlParameter = New SqlParameter("@So_TKHQ", SqlDbType.VarChar, 20)
                pSo_TKHQ.Value = So_TKHQ
                MyCommand.Parameters.Add(pSo_TKHQ)

                Dim pSo_Bien_Lai As SqlParameter = New SqlParameter("@So_Bien_Lai", SqlDbType.VarChar, 20)
                pSo_Bien_Lai.Value = So_Bien_Lai
                MyCommand.Parameters.Add(pSo_Bien_Lai)

                Dim pLe_Phi_HQ As SqlParameter = New SqlParameter("@Le_Phi_HQ", SqlDbType.Int, 0)
                pLe_Phi_HQ.Value = Le_Phi_HQ
                MyCommand.Parameters.Add(pLe_Phi_HQ)

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

                Dim pMa_Ly_Do As SqlParameter = New SqlParameter("@Ma_Ly_Do", SqlDbType.Int, 0)
                pMa_Ly_Do.Value = Ma_Ly_Do
                MyCommand.Parameters.Add(pMa_Ly_Do)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                MyCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Value = Ngay_He_Thong
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Value = Gio_He_Thong
                MyCommand.Parameters.Add(pGio_He_Thong)

                Dim pId_Ky_Han As SqlParameter = New SqlParameter("@Id_Ky_Han", SqlDbType.VarChar, 15)
                pId_Ky_Han.Value = Id_Ky_Han
                MyCommand.Parameters.Add(pId_Ky_Han)

                Dim pDa_Truyen As SqlParameter = New SqlParameter("@Da_Truyen", SqlDbType.Bit, 0)
                pDa_Truyen.Value = Da_Truyen
                MyCommand.Parameters.Add(pDa_Truyen)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 0)
                pChot_SL.Value = Chot_SL
                MyCommand.Parameters.Add(pChot_SL)

                Dim pMa_To_Khai As SqlParameter = New SqlParameter("@Ma_To_Khai", SqlDbType.VarChar, 20)
                pMa_To_Khai.Value = Ma_To_Khai
                MyCommand.Parameters.Add(pMa_To_Khai)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()

                'Return numRows
                Return numRows

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

#Region "E1_Nhap_Kho_D_Xoa"
        Public Function E1_Nhap_Kho_D_Xoa(ByVal Id_E1 As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Nhap_Kho_D_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure

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

                'Return numRows
                Return numRows

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


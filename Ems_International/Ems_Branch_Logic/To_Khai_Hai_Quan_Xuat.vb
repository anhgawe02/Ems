
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "To_Khai_Hai_Quan_Xuat_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop To_Khai_Hai_Quan_Xuat_Chi_Tiet
    'Tuong ung voi moi truong trong bang To_Khai_Hai_Quan_Xuat trong co so du lieu
    '***********************************************************
    Public Class To_Khai_Hai_Quan_Xuat_Chi_Tiet
        Public Ma_To_Khai As String
        Public So_TKHQ As String
        Public Ngay_Khai As Integer
        Public Gio_Khai As Integer
        Public So_To_Khai_HQ_Cap As String
        Public Luong As Integer
        Public Nguoi_Duoc_Uy_Quyen As String
        Public Can_Bo_Kiem_Tra As String
        Public Can_Bo_Tinh_Thue As String
        Public Can_Bo_Xac_Nhan As String
        Public Nguoi_Gui As String
        Public Dia_Chi_Gui As String
        Public Dien_Thoai_Gui As String
        Public CMT_Gui As String
        Public CMT_Ngay_Gui As Integer
        Public Nuoc_Gui As String
        Public Nguoi_Nhan As String
        Public Dia_Chi_Nhan As String
        Public Dien_Thoai_Nhan As String
        Public CMT_Nhan As String
        Public CMT_Ngay_Nhan As Integer
        Public Nuoc_Nhan As String
        Public IsPrint As Boolean
        Public IsPhuLuc As Boolean
        Public IsOpen As Boolean
        Public Kieu_Kiem_Hoa As Integer
        Public Giay_To_Kem_Theo As String
        Public Tong_So_Tui As Integer
        Public Tong_Khoi_Luong As Double
        Public Tong_So_Kien As Integer
        Public Ngay_CN38 As Integer
        Public Ghi_Chu As String
        Public Thong_Tin_Tai_Lieu As String
        Public IsQua_Tang As Boolean
        Public IsHang_Mau As Boolean
        Public IsPay As Boolean
        Public IsPayTax As Boolean
        Public Cuoc_Van_Chuyen As Double
        Public Ma_Tien_Te As String
        Public Ty_Gia As Double
        Public Cuoc_Van_Chuyen_VN As Double
        Public Tri_So_Van_Chuyen As Double
        Public Tien_Qua_Tang As Double
        Public Le_Phi_HQ As Double
        Public Tri_Gia_Nguyen_Te As Double
        Public Tong_Thue_Suat As Double
        Public Tong_Thue_Vat As Double
        Public Ty_Gia_USD As Double
        Public Id_Phan_Loai As Integer
        Public Ma_Tien_Te_HQ As String
        Public Id_Duong_Thu As String
        Public Ip_May_Tinh As String
        Public Ban_So As Integer
        Public Truyen_So_Lieu As Boolean
        Public Ngay_He_Thong As Integer
        Public Gio_He_Thong As Integer
        Public Chot_SL As Boolean
    End Class
#End Region

#Region "To_Khai_Hai_Quan_Xuat"
    Public Class To_Khai_Hai_Quan_Xuat
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "To_Khai_Hai_Quan_Xuat_Cap_Nhat"
        Public Function To_Khai_Hai_Quan_Xuat_Cap_Nhat(ByVal Ma_To_Khai As String, ByVal So_TKHQ As String, ByVal Ngay_Khai As Integer, ByVal Gio_Khai As Integer, ByVal So_To_Khai_HQ_Cap As String, ByVal Luong As Integer, ByVal Nguoi_Duoc_Uy_Quyen As String, ByVal Can_Bo_Kiem_Tra As String, ByVal Can_Bo_Tinh_Thue As String, ByVal Can_Bo_Xac_Nhan As String, ByVal Nguoi_Gui As String, ByVal Dia_Chi_Gui As String, ByVal Dien_Thoai_Gui As String, ByVal CMT_Gui As String, ByVal CMT_Ngay_Gui As Integer, ByVal Nuoc_Gui As String, ByVal Nguoi_Nhan As String, ByVal Dia_Chi_Nhan As String, ByVal Dien_Thoai_Nhan As String, ByVal CMT_Nhan As String, ByVal CMT_Ngay_Nhan As Integer, ByVal Nuoc_Nhan As String, ByVal IsPrint As Boolean, ByVal IsPhuLuc As Boolean, ByVal IsOpen As Boolean, ByVal Kieu_Kiem_Hoa As Integer, ByVal Giay_To_Kem_Theo As String, ByVal Tong_So_Tui As Integer, ByVal Tong_Khoi_Luong As Double, ByVal Tong_So_Kien As Integer, ByVal Ngay_CN38 As Integer, ByVal Ghi_Chu As String, ByVal Thong_Tin_Tai_Lieu As String, ByVal IsQua_Tang As Boolean, ByVal IsHang_Mau As Boolean, ByVal IsPay As Boolean, ByVal IsPayTax As Boolean, ByVal Cuoc_Van_Chuyen As Double, ByVal Ma_Tien_Te As String, ByVal Ty_Gia As Double, ByVal Cuoc_Van_Chuyen_VN As Double, ByVal Tri_So_Van_Chuyen As Double, ByVal Tien_Qua_Tang As Double, ByVal Le_Phi_HQ As Double, ByVal Tri_Gia_Nguyen_Te As Double, ByVal Tong_Thue_Suat As Double, ByVal Tong_Thue_Vat As Double, ByVal Ty_Gia_USD As Double, ByVal Id_Phan_Loai As Integer, ByVal Ma_Tien_Te_HQ As String, ByVal Id_Duong_Thu As String, ByVal Ip_May_Tinh As String, ByVal Ban_So As Integer, ByVal Truyen_So_Lieu As Boolean, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer, ByVal Chot_SL As Boolean) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "To_Khai_Hai_Quan_Xuat_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myTo_Khai_Hai_Quan_Xuat_Chi_Tiet As New To_Khai_Hai_Quan_Xuat_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_To_Khai As SqlParameter = New SqlParameter("@Ma_To_Khai", SqlDbType.VarChar, 20)
                pMa_To_Khai.Value = Ma_To_Khai
                MyCommand.Parameters.Add(pMa_To_Khai)

                Dim pSo_TKHQ As SqlParameter = New SqlParameter("@So_TKHQ", SqlDbType.VarChar, 20)
                pSo_TKHQ.Value = So_TKHQ
                MyCommand.Parameters.Add(pSo_TKHQ)

                Dim pNgay_Khai As SqlParameter = New SqlParameter("@Ngay_Khai", SqlDbType.Int, 0)
                pNgay_Khai.Value = Ngay_Khai
                MyCommand.Parameters.Add(pNgay_Khai)

                Dim pGio_Khai As SqlParameter = New SqlParameter("@Gio_Khai", SqlDbType.Int, 0)
                pGio_Khai.Value = Gio_Khai
                MyCommand.Parameters.Add(pGio_Khai)

                Dim pSo_To_Khai_HQ_Cap As SqlParameter = New SqlParameter("@So_To_Khai_HQ_Cap", SqlDbType.VarChar, 20)
                pSo_To_Khai_HQ_Cap.Value = So_To_Khai_HQ_Cap
                MyCommand.Parameters.Add(pSo_To_Khai_HQ_Cap)

                Dim pLuong As SqlParameter = New SqlParameter("@Luong", SqlDbType.Int, 0)
                pLuong.Value = Luong
                MyCommand.Parameters.Add(pLuong)

                Dim pNguoi_Duoc_Uy_Quyen As SqlParameter = New SqlParameter("@Nguoi_Duoc_Uy_Quyen", SqlDbType.NVarChar, 50)
                pNguoi_Duoc_Uy_Quyen.Value = Nguoi_Duoc_Uy_Quyen
                MyCommand.Parameters.Add(pNguoi_Duoc_Uy_Quyen)

                Dim pCan_Bo_Kiem_Tra As SqlParameter = New SqlParameter("@Can_Bo_Kiem_Tra", SqlDbType.NVarChar, 50)
                pCan_Bo_Kiem_Tra.Value = Can_Bo_Kiem_Tra
                MyCommand.Parameters.Add(pCan_Bo_Kiem_Tra)

                Dim pCan_Bo_Tinh_Thue As SqlParameter = New SqlParameter("@Can_Bo_Tinh_Thue", SqlDbType.NVarChar, 50)
                pCan_Bo_Tinh_Thue.Value = Can_Bo_Tinh_Thue
                MyCommand.Parameters.Add(pCan_Bo_Tinh_Thue)

                Dim pCan_Bo_Xac_Nhan As SqlParameter = New SqlParameter("@Can_Bo_Xac_Nhan", SqlDbType.NVarChar, 50)
                pCan_Bo_Xac_Nhan.Value = Can_Bo_Xac_Nhan
                MyCommand.Parameters.Add(pCan_Bo_Xac_Nhan)

                Dim pNguoi_Gui As SqlParameter = New SqlParameter("@Nguoi_Gui", SqlDbType.NVarChar, 50)
                pNguoi_Gui.Value = Nguoi_Gui
                MyCommand.Parameters.Add(pNguoi_Gui)

                Dim pDia_Chi_Gui As SqlParameter = New SqlParameter("@Dia_Chi_Gui", SqlDbType.NVarChar, 100)
                pDia_Chi_Gui.Value = Dia_Chi_Gui
                MyCommand.Parameters.Add(pDia_Chi_Gui)

                Dim pDien_Thoai_Gui As SqlParameter = New SqlParameter("@Dien_Thoai_Gui", SqlDbType.NVarChar, 100)
                pDien_Thoai_Gui.Value = Dien_Thoai_Gui
                MyCommand.Parameters.Add(pDien_Thoai_Gui)

                Dim pCMT_Gui As SqlParameter = New SqlParameter("@CMT_Gui", SqlDbType.VarChar, 20)
                pCMT_Gui.Value = CMT_Gui
                MyCommand.Parameters.Add(pCMT_Gui)

                Dim pCMT_Ngay_Gui As SqlParameter = New SqlParameter("@CMT_Ngay_Gui", SqlDbType.Int, 0)
                pCMT_Ngay_Gui.Value = CMT_Ngay_Gui
                MyCommand.Parameters.Add(pCMT_Ngay_Gui)

                Dim pNuoc_Gui As SqlParameter = New SqlParameter("@Nuoc_Gui", SqlDbType.VarChar, 50)
                pNuoc_Gui.Value = Nuoc_Gui
                MyCommand.Parameters.Add(pNuoc_Gui)

                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.NVarChar, 50)
                pNguoi_Nhan.Value = Nguoi_Nhan
                MyCommand.Parameters.Add(pNguoi_Nhan)

                Dim pDia_Chi_Nhan As SqlParameter = New SqlParameter("@Dia_Chi_Nhan", SqlDbType.NVarChar, 100)
                pDia_Chi_Nhan.Value = Dia_Chi_Nhan
                MyCommand.Parameters.Add(pDia_Chi_Nhan)

                Dim pDien_Thoai_Nhan As SqlParameter = New SqlParameter("@Dien_Thoai_Nhan", SqlDbType.NVarChar, 100)
                pDien_Thoai_Nhan.Value = Dien_Thoai_Nhan
                MyCommand.Parameters.Add(pDien_Thoai_Nhan)

                Dim pCMT_Nhan As SqlParameter = New SqlParameter("@CMT_Nhan", SqlDbType.VarChar, 20)
                pCMT_Nhan.Value = CMT_Nhan
                MyCommand.Parameters.Add(pCMT_Nhan)

                Dim pCMT_Ngay_Nhan As SqlParameter = New SqlParameter("@CMT_Ngay_Nhan", SqlDbType.Int, 0)
                pCMT_Ngay_Nhan.Value = CMT_Ngay_Nhan
                MyCommand.Parameters.Add(pCMT_Ngay_Nhan)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 50)
                pNuoc_Nhan.Value = Nuoc_Nhan
                MyCommand.Parameters.Add(pNuoc_Nhan)

                Dim pIsPrint As SqlParameter = New SqlParameter("@IsPrint", SqlDbType.Bit, 0)
                pIsPrint.Value = IsPrint
                MyCommand.Parameters.Add(pIsPrint)

                Dim pIsPhuLuc As SqlParameter = New SqlParameter("@IsPhuLuc", SqlDbType.Bit, 0)
                pIsPhuLuc.Value = IsPhuLuc
                MyCommand.Parameters.Add(pIsPhuLuc)

                Dim pIsOpen As SqlParameter = New SqlParameter("@IsOpen", SqlDbType.Bit, 0)
                pIsOpen.Value = IsOpen
                MyCommand.Parameters.Add(pIsOpen)

                Dim pKieu_Kiem_Hoa As SqlParameter = New SqlParameter("@Kieu_Kiem_Hoa", SqlDbType.Int, 0)
                pKieu_Kiem_Hoa.Value = Kieu_Kiem_Hoa
                MyCommand.Parameters.Add(pKieu_Kiem_Hoa)

                Dim pGiay_To_Kem_Theo As SqlParameter = New SqlParameter("@Giay_To_Kem_Theo", SqlDbType.NVarChar, 100)
                pGiay_To_Kem_Theo.Value = Giay_To_Kem_Theo
                MyCommand.Parameters.Add(pGiay_To_Kem_Theo)

                Dim pTong_So_Tui As SqlParameter = New SqlParameter("@Tong_So_Tui", SqlDbType.Int, 0)
                pTong_So_Tui.Value = Tong_So_Tui
                MyCommand.Parameters.Add(pTong_So_Tui)

                Dim pTong_Khoi_Luong As SqlParameter = New SqlParameter("@Tong_Khoi_Luong", SqlDbType.Float, 0)
                pTong_Khoi_Luong.Value = Tong_Khoi_Luong
                MyCommand.Parameters.Add(pTong_Khoi_Luong)

                Dim pTong_So_Kien As SqlParameter = New SqlParameter("@Tong_So_Kien", SqlDbType.Int, 0)
                pTong_So_Kien.Value = Tong_So_Kien
                MyCommand.Parameters.Add(pTong_So_Kien)

                Dim pNgay_CN38 As SqlParameter = New SqlParameter("@Ngay_CN38", SqlDbType.Int, 0)
                pNgay_CN38.Value = Ngay_CN38
                MyCommand.Parameters.Add(pNgay_CN38)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 100)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pThong_Tin_Tai_Lieu As SqlParameter = New SqlParameter("@Thong_Tin_Tai_Lieu", SqlDbType.NVarChar, 200)
                pThong_Tin_Tai_Lieu.Value = Thong_Tin_Tai_Lieu
                MyCommand.Parameters.Add(pThong_Tin_Tai_Lieu)

                Dim pIsQua_Tang As SqlParameter = New SqlParameter("@IsQua_Tang", SqlDbType.Bit, 0)
                pIsQua_Tang.Value = IsQua_Tang
                MyCommand.Parameters.Add(pIsQua_Tang)

                Dim pIsHang_Mau As SqlParameter = New SqlParameter("@IsHang_Mau", SqlDbType.Bit, 0)
                pIsHang_Mau.Value = IsHang_Mau
                MyCommand.Parameters.Add(pIsHang_Mau)

                Dim pIsPay As SqlParameter = New SqlParameter("@IsPay", SqlDbType.Bit, 0)
                pIsPay.Value = IsPay
                MyCommand.Parameters.Add(pIsPay)

                Dim pIsPayTax As SqlParameter = New SqlParameter("@IsPayTax", SqlDbType.Bit, 0)
                pIsPayTax.Value = IsPayTax
                MyCommand.Parameters.Add(pIsPayTax)

                Dim pCuoc_Van_Chuyen As SqlParameter = New SqlParameter("@Cuoc_Van_Chuyen", SqlDbType.Float, 0)
                pCuoc_Van_Chuyen.Value = Cuoc_Van_Chuyen
                MyCommand.Parameters.Add(pCuoc_Van_Chuyen)

                Dim pMa_Tien_Te As SqlParameter = New SqlParameter("@Ma_Tien_Te", SqlDbType.VarChar, 5)
                pMa_Tien_Te.Value = Ma_Tien_Te
                MyCommand.Parameters.Add(pMa_Tien_Te)

                Dim pTy_Gia As SqlParameter = New SqlParameter("@Ty_Gia", SqlDbType.Float, 0)
                pTy_Gia.Value = Ty_Gia
                MyCommand.Parameters.Add(pTy_Gia)

                Dim pCuoc_Van_Chuyen_VN As SqlParameter = New SqlParameter("@Cuoc_Van_Chuyen_VN", SqlDbType.Float, 0)
                pCuoc_Van_Chuyen_VN.Value = Cuoc_Van_Chuyen_VN
                MyCommand.Parameters.Add(pCuoc_Van_Chuyen_VN)

                Dim pTri_So_Van_Chuyen As SqlParameter = New SqlParameter("@Tri_So_Van_Chuyen", SqlDbType.Float, 0)
                pTri_So_Van_Chuyen.Value = Tri_So_Van_Chuyen
                MyCommand.Parameters.Add(pTri_So_Van_Chuyen)

                Dim pTien_Qua_Tang As SqlParameter = New SqlParameter("@Tien_Qua_Tang", SqlDbType.Float, 0)
                pTien_Qua_Tang.Value = Tien_Qua_Tang
                MyCommand.Parameters.Add(pTien_Qua_Tang)

                Dim pLe_Phi_HQ As SqlParameter = New SqlParameter("@Le_Phi_HQ", SqlDbType.Float, 0)
                pLe_Phi_HQ.Value = Le_Phi_HQ
                MyCommand.Parameters.Add(pLe_Phi_HQ)

                Dim pTri_Gia_Nguyen_Te As SqlParameter = New SqlParameter("@Tri_Gia_Nguyen_Te", SqlDbType.Float, 0)
                pTri_Gia_Nguyen_Te.Value = Tri_Gia_Nguyen_Te
                MyCommand.Parameters.Add(pTri_Gia_Nguyen_Te)

                Dim pTong_Thue_Suat As SqlParameter = New SqlParameter("@Tong_Thue_Suat", SqlDbType.Float, 0)
                pTong_Thue_Suat.Value = Tong_Thue_Suat
                MyCommand.Parameters.Add(pTong_Thue_Suat)

                Dim pTong_Thue_Vat As SqlParameter = New SqlParameter("@Tong_Thue_Vat", SqlDbType.Float, 0)
                pTong_Thue_Vat.Value = Tong_Thue_Vat
                MyCommand.Parameters.Add(pTong_Thue_Vat)

                Dim pTy_Gia_USD As SqlParameter = New SqlParameter("@Ty_Gia_USD", SqlDbType.Float, 0)
                pTy_Gia_USD.Value = Ty_Gia_USD
                MyCommand.Parameters.Add(pTy_Gia_USD)

                Dim pId_Phan_Loai As SqlParameter = New SqlParameter("@Id_Phan_Loai", SqlDbType.Int, 0)
                pId_Phan_Loai.Value = Id_Phan_Loai
                MyCommand.Parameters.Add(pId_Phan_Loai)

                Dim pMa_Tien_Te_HQ As SqlParameter = New SqlParameter("@Ma_Tien_Te_HQ", SqlDbType.VarChar, 5)
                pMa_Tien_Te_HQ.Value = Ma_Tien_Te_HQ
                MyCommand.Parameters.Add(pMa_Tien_Te_HQ)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pIp_May_Tinh As SqlParameter = New SqlParameter("@Ip_May_Tinh", SqlDbType.VarChar, 15)
                pIp_May_Tinh.Value = Ip_May_Tinh
                MyCommand.Parameters.Add(pIp_May_Tinh)

                Dim pBan_So As SqlParameter = New SqlParameter("@Ban_So", SqlDbType.Int, 0)
                pBan_So.Value = Ban_So
                MyCommand.Parameters.Add(pBan_So)

                Dim pTruyen_So_Lieu As SqlParameter = New SqlParameter("@Truyen_So_Lieu", SqlDbType.Bit, 0)
                pTruyen_So_Lieu.Value = Truyen_So_Lieu
                MyCommand.Parameters.Add(pTruyen_So_Lieu)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Value = Ngay_He_Thong
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Value = Gio_He_Thong
                MyCommand.Parameters.Add(pGio_He_Thong)

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

#Region "To_Khai_Hai_Quan_Xuat_Cap_Nhat_Them"
        Public Function To_Khai_Hai_Quan_Xuat_Cap_Nhat_Them(ByVal Ma_To_Khai As String, ByVal So_TKHQ As String, ByVal Ngay_Khai As Integer, ByVal Gio_Khai As Integer, ByVal So_To_Khai_HQ_Cap As String, ByVal Luong As Integer, ByVal Nguoi_Duoc_Uy_Quyen As String, ByVal Can_Bo_Kiem_Tra As String, ByVal Can_Bo_Tinh_Thue As String, ByVal Can_Bo_Xac_Nhan As String, ByVal Nguoi_Gui As String, ByVal Dia_Chi_Gui As String, ByVal Dien_Thoai_Gui As String, ByVal CMT_Gui As String, ByVal CMT_Ngay_Gui As Integer, ByVal Nuoc_Gui As String, ByVal Nguoi_Nhan As String, ByVal Dia_Chi_Nhan As String, ByVal Dien_Thoai_Nhan As String, ByVal CMT_Nhan As String, ByVal CMT_Ngay_Nhan As Integer, ByVal Nuoc_Nhan As String, ByVal IsPrint As Boolean, ByVal IsPhuLuc As Boolean, ByVal IsOpen As Boolean, ByVal Kieu_Kiem_Hoa As Integer, ByVal Giay_To_Kem_Theo As String, ByVal Tong_So_Tui As Integer, ByVal Tong_Khoi_Luong As Double, ByVal Tong_So_Kien As Integer, ByVal Ngay_CN38 As Integer, ByVal Ghi_Chu As String, ByVal Thong_Tin_Tai_Lieu As String, ByVal IsQua_Tang As Boolean, ByVal IsHang_Mau As Boolean, ByVal IsPay As Boolean, ByVal IsPayTax As Boolean, ByVal Cuoc_Van_Chuyen As Double, ByVal Ma_Tien_Te As String, ByVal Ty_Gia As Double, ByVal Cuoc_Van_Chuyen_VN As Double, ByVal Tri_So_Van_Chuyen As Double, ByVal Tien_Qua_Tang As Double, ByVal Le_Phi_HQ As Double, ByVal Tri_Gia_Nguyen_Te As Double, ByVal Tong_Thue_Suat As Double, ByVal Tong_Thue_Vat As Double, ByVal Ty_Gia_USD As Double, ByVal Id_Phan_Loai As Integer, ByVal Ma_Tien_Te_HQ As String, ByVal Id_Duong_Thu As String, ByVal Ip_May_Tinh As String, ByVal Ban_So As Integer, ByVal Truyen_So_Lieu As Boolean, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer, ByVal Chot_SL As Boolean) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "To_Khai_Hai_Quan_Xuat_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myTo_Khai_Hai_Quan_Xuat_Chi_Tiet As New To_Khai_Hai_Quan_Xuat_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_To_Khai As SqlParameter = New SqlParameter("@Ma_To_Khai", SqlDbType.VarChar, 20)
                pMa_To_Khai.Value = Ma_To_Khai
                MyCommand.Parameters.Add(pMa_To_Khai)

                Dim pSo_TKHQ As SqlParameter = New SqlParameter("@So_TKHQ", SqlDbType.VarChar, 20)
                pSo_TKHQ.Value = So_TKHQ
                MyCommand.Parameters.Add(pSo_TKHQ)

                Dim pNgay_Khai As SqlParameter = New SqlParameter("@Ngay_Khai", SqlDbType.Int, 0)
                pNgay_Khai.Value = Ngay_Khai
                MyCommand.Parameters.Add(pNgay_Khai)

                Dim pGio_Khai As SqlParameter = New SqlParameter("@Gio_Khai", SqlDbType.Int, 0)
                pGio_Khai.Value = Gio_Khai
                MyCommand.Parameters.Add(pGio_Khai)

                Dim pSo_To_Khai_HQ_Cap As SqlParameter = New SqlParameter("@So_To_Khai_HQ_Cap", SqlDbType.VarChar, 20)
                pSo_To_Khai_HQ_Cap.Value = So_To_Khai_HQ_Cap
                MyCommand.Parameters.Add(pSo_To_Khai_HQ_Cap)

                Dim pLuong As SqlParameter = New SqlParameter("@Luong", SqlDbType.Int, 0)
                pLuong.Value = Luong
                MyCommand.Parameters.Add(pLuong)

                Dim pNguoi_Duoc_Uy_Quyen As SqlParameter = New SqlParameter("@Nguoi_Duoc_Uy_Quyen", SqlDbType.NVarChar, 50)
                pNguoi_Duoc_Uy_Quyen.Value = Nguoi_Duoc_Uy_Quyen
                MyCommand.Parameters.Add(pNguoi_Duoc_Uy_Quyen)

                Dim pCan_Bo_Kiem_Tra As SqlParameter = New SqlParameter("@Can_Bo_Kiem_Tra", SqlDbType.NVarChar, 50)
                pCan_Bo_Kiem_Tra.Value = Can_Bo_Kiem_Tra
                MyCommand.Parameters.Add(pCan_Bo_Kiem_Tra)

                Dim pCan_Bo_Tinh_Thue As SqlParameter = New SqlParameter("@Can_Bo_Tinh_Thue", SqlDbType.NVarChar, 50)
                pCan_Bo_Tinh_Thue.Value = Can_Bo_Tinh_Thue
                MyCommand.Parameters.Add(pCan_Bo_Tinh_Thue)

                Dim pCan_Bo_Xac_Nhan As SqlParameter = New SqlParameter("@Can_Bo_Xac_Nhan", SqlDbType.NVarChar, 50)
                pCan_Bo_Xac_Nhan.Value = Can_Bo_Xac_Nhan
                MyCommand.Parameters.Add(pCan_Bo_Xac_Nhan)

                Dim pNguoi_Gui As SqlParameter = New SqlParameter("@Nguoi_Gui", SqlDbType.NVarChar, 50)
                pNguoi_Gui.Value = Nguoi_Gui
                MyCommand.Parameters.Add(pNguoi_Gui)

                Dim pDia_Chi_Gui As SqlParameter = New SqlParameter("@Dia_Chi_Gui", SqlDbType.NVarChar, 100)
                pDia_Chi_Gui.Value = Dia_Chi_Gui
                MyCommand.Parameters.Add(pDia_Chi_Gui)

                Dim pDien_Thoai_Gui As SqlParameter = New SqlParameter("@Dien_Thoai_Gui", SqlDbType.NVarChar, 100)
                pDien_Thoai_Gui.Value = Dien_Thoai_Gui
                MyCommand.Parameters.Add(pDien_Thoai_Gui)

                Dim pCMT_Gui As SqlParameter = New SqlParameter("@CMT_Gui", SqlDbType.VarChar, 20)
                pCMT_Gui.Value = CMT_Gui
                MyCommand.Parameters.Add(pCMT_Gui)

                Dim pCMT_Ngay_Gui As SqlParameter = New SqlParameter("@CMT_Ngay_Gui", SqlDbType.Int, 0)
                pCMT_Ngay_Gui.Value = CMT_Ngay_Gui
                MyCommand.Parameters.Add(pCMT_Ngay_Gui)

                Dim pNuoc_Gui As SqlParameter = New SqlParameter("@Nuoc_Gui", SqlDbType.VarChar, 50)
                pNuoc_Gui.Value = Nuoc_Gui
                MyCommand.Parameters.Add(pNuoc_Gui)

                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.NVarChar, 50)
                pNguoi_Nhan.Value = Nguoi_Nhan
                MyCommand.Parameters.Add(pNguoi_Nhan)

                Dim pDia_Chi_Nhan As SqlParameter = New SqlParameter("@Dia_Chi_Nhan", SqlDbType.NVarChar, 100)
                pDia_Chi_Nhan.Value = Dia_Chi_Nhan
                MyCommand.Parameters.Add(pDia_Chi_Nhan)

                Dim pDien_Thoai_Nhan As SqlParameter = New SqlParameter("@Dien_Thoai_Nhan", SqlDbType.NVarChar, 100)
                pDien_Thoai_Nhan.Value = Dien_Thoai_Nhan
                MyCommand.Parameters.Add(pDien_Thoai_Nhan)

                Dim pCMT_Nhan As SqlParameter = New SqlParameter("@CMT_Nhan", SqlDbType.VarChar, 20)
                pCMT_Nhan.Value = CMT_Nhan
                MyCommand.Parameters.Add(pCMT_Nhan)

                Dim pCMT_Ngay_Nhan As SqlParameter = New SqlParameter("@CMT_Ngay_Nhan", SqlDbType.Int, 0)
                pCMT_Ngay_Nhan.Value = CMT_Ngay_Nhan
                MyCommand.Parameters.Add(pCMT_Ngay_Nhan)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 50)
                pNuoc_Nhan.Value = Nuoc_Nhan
                MyCommand.Parameters.Add(pNuoc_Nhan)

                Dim pIsPrint As SqlParameter = New SqlParameter("@IsPrint", SqlDbType.Bit, 0)
                pIsPrint.Value = IsPrint
                MyCommand.Parameters.Add(pIsPrint)

                Dim pIsPhuLuc As SqlParameter = New SqlParameter("@IsPhuLuc", SqlDbType.Bit, 0)
                pIsPhuLuc.Value = IsPhuLuc
                MyCommand.Parameters.Add(pIsPhuLuc)

                Dim pIsOpen As SqlParameter = New SqlParameter("@IsOpen", SqlDbType.Bit, 0)
                pIsOpen.Value = IsOpen
                MyCommand.Parameters.Add(pIsOpen)

                Dim pKieu_Kiem_Hoa As SqlParameter = New SqlParameter("@Kieu_Kiem_Hoa", SqlDbType.Int, 0)
                pKieu_Kiem_Hoa.Value = Kieu_Kiem_Hoa
                MyCommand.Parameters.Add(pKieu_Kiem_Hoa)

                Dim pGiay_To_Kem_Theo As SqlParameter = New SqlParameter("@Giay_To_Kem_Theo", SqlDbType.NVarChar, 100)
                pGiay_To_Kem_Theo.Value = Giay_To_Kem_Theo
                MyCommand.Parameters.Add(pGiay_To_Kem_Theo)

                Dim pTong_So_Tui As SqlParameter = New SqlParameter("@Tong_So_Tui", SqlDbType.Int, 0)
                pTong_So_Tui.Value = Tong_So_Tui
                MyCommand.Parameters.Add(pTong_So_Tui)

                Dim pTong_Khoi_Luong As SqlParameter = New SqlParameter("@Tong_Khoi_Luong", SqlDbType.Float, 0)
                pTong_Khoi_Luong.Value = Tong_Khoi_Luong
                MyCommand.Parameters.Add(pTong_Khoi_Luong)

                Dim pTong_So_Kien As SqlParameter = New SqlParameter("@Tong_So_Kien", SqlDbType.Int, 0)
                pTong_So_Kien.Value = Tong_So_Kien
                MyCommand.Parameters.Add(pTong_So_Kien)

                Dim pNgay_CN38 As SqlParameter = New SqlParameter("@Ngay_CN38", SqlDbType.Int, 0)
                pNgay_CN38.Value = Ngay_CN38
                MyCommand.Parameters.Add(pNgay_CN38)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 100)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pThong_Tin_Tai_Lieu As SqlParameter = New SqlParameter("@Thong_Tin_Tai_Lieu", SqlDbType.NVarChar, 200)
                pThong_Tin_Tai_Lieu.Value = Thong_Tin_Tai_Lieu
                MyCommand.Parameters.Add(pThong_Tin_Tai_Lieu)

                Dim pIsQua_Tang As SqlParameter = New SqlParameter("@IsQua_Tang", SqlDbType.Bit, 0)
                pIsQua_Tang.Value = IsQua_Tang
                MyCommand.Parameters.Add(pIsQua_Tang)

                Dim pIsHang_Mau As SqlParameter = New SqlParameter("@IsHang_Mau", SqlDbType.Bit, 0)
                pIsHang_Mau.Value = IsHang_Mau
                MyCommand.Parameters.Add(pIsHang_Mau)

                Dim pIsPay As SqlParameter = New SqlParameter("@IsPay", SqlDbType.Bit, 0)
                pIsPay.Value = IsPay
                MyCommand.Parameters.Add(pIsPay)

                Dim pIsPayTax As SqlParameter = New SqlParameter("@IsPayTax", SqlDbType.Bit, 0)
                pIsPayTax.Value = IsPayTax
                MyCommand.Parameters.Add(pIsPayTax)

                Dim pCuoc_Van_Chuyen As SqlParameter = New SqlParameter("@Cuoc_Van_Chuyen", SqlDbType.Float, 0)
                pCuoc_Van_Chuyen.Value = Cuoc_Van_Chuyen
                MyCommand.Parameters.Add(pCuoc_Van_Chuyen)

                Dim pMa_Tien_Te As SqlParameter = New SqlParameter("@Ma_Tien_Te", SqlDbType.VarChar, 5)
                pMa_Tien_Te.Value = Ma_Tien_Te
                MyCommand.Parameters.Add(pMa_Tien_Te)

                Dim pTy_Gia As SqlParameter = New SqlParameter("@Ty_Gia", SqlDbType.Float, 0)
                pTy_Gia.Value = Ty_Gia
                MyCommand.Parameters.Add(pTy_Gia)

                Dim pCuoc_Van_Chuyen_VN As SqlParameter = New SqlParameter("@Cuoc_Van_Chuyen_VN", SqlDbType.Float, 0)
                pCuoc_Van_Chuyen_VN.Value = Cuoc_Van_Chuyen_VN
                MyCommand.Parameters.Add(pCuoc_Van_Chuyen_VN)

                Dim pTri_So_Van_Chuyen As SqlParameter = New SqlParameter("@Tri_So_Van_Chuyen", SqlDbType.Float, 0)
                pTri_So_Van_Chuyen.Value = Tri_So_Van_Chuyen
                MyCommand.Parameters.Add(pTri_So_Van_Chuyen)

                Dim pTien_Qua_Tang As SqlParameter = New SqlParameter("@Tien_Qua_Tang", SqlDbType.Float, 0)
                pTien_Qua_Tang.Value = Tien_Qua_Tang
                MyCommand.Parameters.Add(pTien_Qua_Tang)

                Dim pLe_Phi_HQ As SqlParameter = New SqlParameter("@Le_Phi_HQ", SqlDbType.Float, 0)
                pLe_Phi_HQ.Value = Le_Phi_HQ
                MyCommand.Parameters.Add(pLe_Phi_HQ)

                Dim pTri_Gia_Nguyen_Te As SqlParameter = New SqlParameter("@Tri_Gia_Nguyen_Te", SqlDbType.Float, 0)
                pTri_Gia_Nguyen_Te.Value = Tri_Gia_Nguyen_Te
                MyCommand.Parameters.Add(pTri_Gia_Nguyen_Te)

                Dim pTong_Thue_Suat As SqlParameter = New SqlParameter("@Tong_Thue_Suat", SqlDbType.Float, 0)
                pTong_Thue_Suat.Value = Tong_Thue_Suat
                MyCommand.Parameters.Add(pTong_Thue_Suat)

                Dim pTong_Thue_Vat As SqlParameter = New SqlParameter("@Tong_Thue_Vat", SqlDbType.Float, 0)
                pTong_Thue_Vat.Value = Tong_Thue_Vat
                MyCommand.Parameters.Add(pTong_Thue_Vat)

                Dim pTy_Gia_USD As SqlParameter = New SqlParameter("@Ty_Gia_USD", SqlDbType.Float, 0)
                pTy_Gia_USD.Value = Ty_Gia_USD
                MyCommand.Parameters.Add(pTy_Gia_USD)

                Dim pId_Phan_Loai As SqlParameter = New SqlParameter("@Id_Phan_Loai", SqlDbType.Int, 0)
                pId_Phan_Loai.Value = Id_Phan_Loai
                MyCommand.Parameters.Add(pId_Phan_Loai)

                Dim pMa_Tien_Te_HQ As SqlParameter = New SqlParameter("@Ma_Tien_Te_HQ", SqlDbType.VarChar, 5)
                pMa_Tien_Te_HQ.Value = Ma_Tien_Te_HQ
                MyCommand.Parameters.Add(pMa_Tien_Te_HQ)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pIp_May_Tinh As SqlParameter = New SqlParameter("@Ip_May_Tinh", SqlDbType.VarChar, 15)
                pIp_May_Tinh.Value = Ip_May_Tinh
                MyCommand.Parameters.Add(pIp_May_Tinh)

                Dim pBan_So As SqlParameter = New SqlParameter("@Ban_So", SqlDbType.Int, 0)
                pBan_So.Value = Ban_So
                MyCommand.Parameters.Add(pBan_So)

                Dim pTruyen_So_Lieu As SqlParameter = New SqlParameter("@Truyen_So_Lieu", SqlDbType.Bit, 0)
                pTruyen_So_Lieu.Value = Truyen_So_Lieu
                MyCommand.Parameters.Add(pTruyen_So_Lieu)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Value = Ngay_He_Thong
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Value = Gio_He_Thong
                MyCommand.Parameters.Add(pGio_He_Thong)

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

#Region "To_Khai_Hai_Quan_Xuat_Danh_Sach"

        Public Function To_Khai_Hai_Quan_Xuat_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Ma_To_Khai
            ' So_TKHQ
            ' Ngay_Khai
            ' Gio_Khai
            ' So_To_Khai_HQ_Cap
            ' Luong
            ' Nguoi_Duoc_Uy_Quyen
            ' Can_Bo_Kiem_Tra
            ' Can_Bo_Tinh_Thue
            ' Can_Bo_Xac_Nhan
            ' Nguoi_Gui
            ' Dia_Chi_Gui
            ' Dien_Thoai_Gui
            ' CMT_Gui
            ' CMT_Ngay_Gui
            ' Nuoc_Gui
            ' Nguoi_Nhan
            ' Dia_Chi_Nhan
            ' Dien_Thoai_Nhan
            ' CMT_Nhan
            ' CMT_Ngay_Nhan
            ' Nuoc_Nhan
            ' IsPrint
            ' IsPhuLuc
            ' IsOpen
            ' Kieu_Kiem_Hoa
            ' Giay_To_Kem_Theo
            ' Tong_So_Tui
            ' Tong_Khoi_Luong
            ' Tong_So_Kien
            ' Ngay_CN38
            ' Ghi_Chu
            ' Thong_Tin_Tai_Lieu
            ' IsQua_Tang
            ' IsHang_Mau
            ' IsPay
            ' IsPayTax
            ' Cuoc_Van_Chuyen
            ' Ma_Tien_Te
            ' Ty_Gia
            ' Cuoc_Van_Chuyen_VN
            ' Tri_So_Van_Chuyen
            ' Tien_Qua_Tang
            ' Le_Phi_HQ
            ' Tri_Gia_Nguyen_Te
            ' Tong_Thue_Suat
            ' Tong_Thue_Vat
            ' Ty_Gia_USD
            ' Id_Phan_Loai
            ' Ma_Tien_Te_HQ
            ' Id_Duong_Thu
            ' Ip_May_Tinh
            ' Ban_So
            ' Truyen_So_Lieu
            ' Ngay_He_Thong
            ' Gio_He_Thong
            ' Chot_SL


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "To_Khai_Hai_Quan_Xuat_Danh_Sach"
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

#Region "To_Khai_Hai_Quan_Xuat_Lay"
        Public Function To_Khai_Hai_Quan_Xuat_Lay(ByVal Ma_To_Khai As String) As To_Khai_Hai_Quan_Xuat_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "To_Khai_Hai_Quan_Xuat_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myTo_Khai_Hai_Quan_Xuat_Chi_Tiet As New To_Khai_Hai_Quan_Xuat_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_To_Khai As SqlParameter = New SqlParameter("@Ma_To_Khai", SqlDbType.VarChar, 20)
                pMa_To_Khai.Value = Ma_To_Khai
                MyCommand.Parameters.Add(pMa_To_Khai)

                Dim pSo_TKHQ As SqlParameter = New SqlParameter("@So_TKHQ", SqlDbType.VarChar, 20)
                pSo_TKHQ.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSo_TKHQ)

                Dim pNgay_Khai As SqlParameter = New SqlParameter("@Ngay_Khai", SqlDbType.Int, 0)
                pNgay_Khai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Khai)

                Dim pGio_Khai As SqlParameter = New SqlParameter("@Gio_Khai", SqlDbType.Int, 0)
                pGio_Khai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Khai)

                Dim pSo_To_Khai_HQ_Cap As SqlParameter = New SqlParameter("@So_To_Khai_HQ_Cap", SqlDbType.VarChar, 20)
                pSo_To_Khai_HQ_Cap.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSo_To_Khai_HQ_Cap)

                Dim pLuong As SqlParameter = New SqlParameter("@Luong", SqlDbType.Int, 0)
                pLuong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pLuong)

                Dim pNguoi_Duoc_Uy_Quyen As SqlParameter = New SqlParameter("@Nguoi_Duoc_Uy_Quyen", SqlDbType.NVarChar, 50)
                pNguoi_Duoc_Uy_Quyen.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNguoi_Duoc_Uy_Quyen)

                Dim pCan_Bo_Kiem_Tra As SqlParameter = New SqlParameter("@Can_Bo_Kiem_Tra", SqlDbType.NVarChar, 50)
                pCan_Bo_Kiem_Tra.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCan_Bo_Kiem_Tra)

                Dim pCan_Bo_Tinh_Thue As SqlParameter = New SqlParameter("@Can_Bo_Tinh_Thue", SqlDbType.NVarChar, 50)
                pCan_Bo_Tinh_Thue.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCan_Bo_Tinh_Thue)

                Dim pCan_Bo_Xac_Nhan As SqlParameter = New SqlParameter("@Can_Bo_Xac_Nhan", SqlDbType.NVarChar, 50)
                pCan_Bo_Xac_Nhan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCan_Bo_Xac_Nhan)

                Dim pNguoi_Gui As SqlParameter = New SqlParameter("@Nguoi_Gui", SqlDbType.NVarChar, 50)
                pNguoi_Gui.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNguoi_Gui)

                Dim pDia_Chi_Gui As SqlParameter = New SqlParameter("@Dia_Chi_Gui", SqlDbType.NVarChar, 100)
                pDia_Chi_Gui.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDia_Chi_Gui)

                Dim pDien_Thoai_Gui As SqlParameter = New SqlParameter("@Dien_Thoai_Gui", SqlDbType.NVarChar, 100)
                pDien_Thoai_Gui.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDien_Thoai_Gui)

                Dim pCMT_Gui As SqlParameter = New SqlParameter("@CMT_Gui", SqlDbType.VarChar, 20)
                pCMT_Gui.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCMT_Gui)

                Dim pCMT_Ngay_Gui As SqlParameter = New SqlParameter("@CMT_Ngay_Gui", SqlDbType.Int, 0)
                pCMT_Ngay_Gui.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCMT_Ngay_Gui)

                Dim pNuoc_Gui As SqlParameter = New SqlParameter("@Nuoc_Gui", SqlDbType.VarChar, 50)
                pNuoc_Gui.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNuoc_Gui)

                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.NVarChar, 50)
                pNguoi_Nhan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNguoi_Nhan)

                Dim pDia_Chi_Nhan As SqlParameter = New SqlParameter("@Dia_Chi_Nhan", SqlDbType.NVarChar, 100)
                pDia_Chi_Nhan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDia_Chi_Nhan)

                Dim pDien_Thoai_Nhan As SqlParameter = New SqlParameter("@Dien_Thoai_Nhan", SqlDbType.NVarChar, 100)
                pDien_Thoai_Nhan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDien_Thoai_Nhan)

                Dim pCMT_Nhan As SqlParameter = New SqlParameter("@CMT_Nhan", SqlDbType.VarChar, 20)
                pCMT_Nhan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCMT_Nhan)

                Dim pCMT_Ngay_Nhan As SqlParameter = New SqlParameter("@CMT_Ngay_Nhan", SqlDbType.Int, 0)
                pCMT_Ngay_Nhan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCMT_Ngay_Nhan)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 50)
                pNuoc_Nhan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNuoc_Nhan)

                Dim pIsPrint As SqlParameter = New SqlParameter("@IsPrint", SqlDbType.Bit, 0)
                pIsPrint.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pIsPrint)

                Dim pIsPhuLuc As SqlParameter = New SqlParameter("@IsPhuLuc", SqlDbType.Bit, 0)
                pIsPhuLuc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pIsPhuLuc)

                Dim pIsOpen As SqlParameter = New SqlParameter("@IsOpen", SqlDbType.Bit, 0)
                pIsOpen.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pIsOpen)

                Dim pKieu_Kiem_Hoa As SqlParameter = New SqlParameter("@Kieu_Kiem_Hoa", SqlDbType.Int, 0)
                pKieu_Kiem_Hoa.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pKieu_Kiem_Hoa)

                Dim pGiay_To_Kem_Theo As SqlParameter = New SqlParameter("@Giay_To_Kem_Theo", SqlDbType.NVarChar, 100)
                pGiay_To_Kem_Theo.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGiay_To_Kem_Theo)

                Dim pTong_So_Tui As SqlParameter = New SqlParameter("@Tong_So_Tui", SqlDbType.Int, 0)
                pTong_So_Tui.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTong_So_Tui)

                Dim pTong_Khoi_Luong As SqlParameter = New SqlParameter("@Tong_Khoi_Luong", SqlDbType.Float, 0)
                pTong_Khoi_Luong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTong_Khoi_Luong)

                Dim pTong_So_Kien As SqlParameter = New SqlParameter("@Tong_So_Kien", SqlDbType.Int, 0)
                pTong_So_Kien.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTong_So_Kien)

                Dim pNgay_CN38 As SqlParameter = New SqlParameter("@Ngay_CN38", SqlDbType.Int, 0)
                pNgay_CN38.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_CN38)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 100)
                pGhi_Chu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pThong_Tin_Tai_Lieu As SqlParameter = New SqlParameter("@Thong_Tin_Tai_Lieu", SqlDbType.NVarChar, 200)
                pThong_Tin_Tai_Lieu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThong_Tin_Tai_Lieu)

                Dim pIsQua_Tang As SqlParameter = New SqlParameter("@IsQua_Tang", SqlDbType.Bit, 0)
                pIsQua_Tang.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pIsQua_Tang)

                Dim pIsHang_Mau As SqlParameter = New SqlParameter("@IsHang_Mau", SqlDbType.Bit, 0)
                pIsHang_Mau.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pIsHang_Mau)

                Dim pIsPay As SqlParameter = New SqlParameter("@IsPay", SqlDbType.Bit, 0)
                pIsPay.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pIsPay)

                Dim pIsPayTax As SqlParameter = New SqlParameter("@IsPayTax", SqlDbType.Bit, 0)
                pIsPayTax.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pIsPayTax)

                Dim pCuoc_Van_Chuyen As SqlParameter = New SqlParameter("@Cuoc_Van_Chuyen", SqlDbType.Float, 0)
                pCuoc_Van_Chuyen.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCuoc_Van_Chuyen)

                Dim pMa_Tien_Te As SqlParameter = New SqlParameter("@Ma_Tien_Te", SqlDbType.VarChar, 5)
                pMa_Tien_Te.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Tien_Te)

                Dim pTy_Gia As SqlParameter = New SqlParameter("@Ty_Gia", SqlDbType.Float, 0)
                pTy_Gia.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTy_Gia)

                Dim pCuoc_Van_Chuyen_VN As SqlParameter = New SqlParameter("@Cuoc_Van_Chuyen_VN", SqlDbType.Float, 0)
                pCuoc_Van_Chuyen_VN.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCuoc_Van_Chuyen_VN)

                Dim pTri_So_Van_Chuyen As SqlParameter = New SqlParameter("@Tri_So_Van_Chuyen", SqlDbType.Float, 0)
                pTri_So_Van_Chuyen.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTri_So_Van_Chuyen)

                Dim pTien_Qua_Tang As SqlParameter = New SqlParameter("@Tien_Qua_Tang", SqlDbType.Float, 0)
                pTien_Qua_Tang.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTien_Qua_Tang)

                Dim pLe_Phi_HQ As SqlParameter = New SqlParameter("@Le_Phi_HQ", SqlDbType.Float, 0)
                pLe_Phi_HQ.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pLe_Phi_HQ)

                Dim pTri_Gia_Nguyen_Te As SqlParameter = New SqlParameter("@Tri_Gia_Nguyen_Te", SqlDbType.Float, 0)
                pTri_Gia_Nguyen_Te.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTri_Gia_Nguyen_Te)

                Dim pTong_Thue_Suat As SqlParameter = New SqlParameter("@Tong_Thue_Suat", SqlDbType.Float, 0)
                pTong_Thue_Suat.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTong_Thue_Suat)

                Dim pTong_Thue_Vat As SqlParameter = New SqlParameter("@Tong_Thue_Vat", SqlDbType.Float, 0)
                pTong_Thue_Vat.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTong_Thue_Vat)

                Dim pTy_Gia_USD As SqlParameter = New SqlParameter("@Ty_Gia_USD", SqlDbType.Float, 0)
                pTy_Gia_USD.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTy_Gia_USD)

                Dim pId_Phan_Loai As SqlParameter = New SqlParameter("@Id_Phan_Loai", SqlDbType.Int, 0)
                pId_Phan_Loai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Phan_Loai)

                Dim pMa_Tien_Te_HQ As SqlParameter = New SqlParameter("@Ma_Tien_Te_HQ", SqlDbType.VarChar, 5)
                pMa_Tien_Te_HQ.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Tien_Te_HQ)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pIp_May_Tinh As SqlParameter = New SqlParameter("@Ip_May_Tinh", SqlDbType.VarChar, 15)
                pIp_May_Tinh.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pIp_May_Tinh)

                Dim pBan_So As SqlParameter = New SqlParameter("@Ban_So", SqlDbType.Int, 0)
                pBan_So.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pBan_So)

                Dim pTruyen_So_Lieu As SqlParameter = New SqlParameter("@Truyen_So_Lieu", SqlDbType.Bit, 0)
                pTruyen_So_Lieu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTruyen_So_Lieu)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_He_Thong)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 0)
                pChot_SL.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pChot_SL)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_To_Khai = Ma_To_Khai
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.So_TKHQ = pSo_TKHQ.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ngay_Khai = pNgay_Khai.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Gio_Khai = pGio_Khai.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.So_To_Khai_HQ_Cap = pSo_To_Khai_HQ_Cap.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Luong = pLuong.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Nguoi_Duoc_Uy_Quyen = pNguoi_Duoc_Uy_Quyen.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Can_Bo_Kiem_Tra = pCan_Bo_Kiem_Tra.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Can_Bo_Tinh_Thue = pCan_Bo_Tinh_Thue.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Can_Bo_Xac_Nhan = pCan_Bo_Xac_Nhan.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Nguoi_Gui = pNguoi_Gui.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Dia_Chi_Gui = pDia_Chi_Gui.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Dien_Thoai_Gui = pDien_Thoai_Gui.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.CMT_Gui = pCMT_Gui.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.CMT_Ngay_Gui = pCMT_Ngay_Gui.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Nuoc_Gui = pNuoc_Gui.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Nguoi_Nhan = pNguoi_Nhan.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Dia_Chi_Nhan = pDia_Chi_Nhan.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Dien_Thoai_Nhan = pDien_Thoai_Nhan.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.CMT_Nhan = pCMT_Nhan.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.CMT_Ngay_Nhan = pCMT_Ngay_Nhan.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Nuoc_Nhan = pNuoc_Nhan.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsPrint = pIsPrint.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsPhuLuc = pIsPhuLuc.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsOpen = pIsOpen.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Kieu_Kiem_Hoa = pKieu_Kiem_Hoa.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Giay_To_Kem_Theo = pGiay_To_Kem_Theo.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tong_So_Tui = pTong_So_Tui.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tong_Khoi_Luong = pTong_Khoi_Luong.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tong_So_Kien = pTong_So_Kien.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ngay_CN38 = pNgay_CN38.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Thong_Tin_Tai_Lieu = pThong_Tin_Tai_Lieu.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsQua_Tang = pIsQua_Tang.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsHang_Mau = pIsHang_Mau.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsPay = pIsPay.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsPayTax = pIsPayTax.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Cuoc_Van_Chuyen = pCuoc_Van_Chuyen.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_Tien_Te = pMa_Tien_Te.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ty_Gia = pTy_Gia.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Cuoc_Van_Chuyen_VN = pCuoc_Van_Chuyen_VN.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tri_So_Van_Chuyen = pTri_So_Van_Chuyen.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tien_Qua_Tang = pTien_Qua_Tang.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Le_Phi_HQ = pLe_Phi_HQ.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tri_Gia_Nguyen_Te = pTri_Gia_Nguyen_Te.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tong_Thue_Suat = pTong_Thue_Suat.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tong_Thue_Vat = pTong_Thue_Vat.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ty_Gia_USD = pTy_Gia_USD.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Id_Phan_Loai = pId_Phan_Loai.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_Tien_Te_HQ = pMa_Tien_Te_HQ.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Id_Duong_Thu = pId_Duong_Thu.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ip_May_Tinh = pIp_May_Tinh.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ban_So = pBan_So.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Truyen_So_Lieu = pTruyen_So_Lieu.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Gio_He_Thong = pGio_He_Thong.Value
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Chot_SL = pChot_SL.Value

                Return myTo_Khai_Hai_Quan_Xuat_Chi_Tiet
                'Return myTo_Khai_Hai_Quan_Xuat_Chi_Tiet

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


#Region "To_Khai_Hai_Quan_Xuat_Kiem_Tra_Tai_Lieu"

        Public Function To_Khai_Hai_Quan_Xuat_Kiem_Tra_Tai_Lieu(ByVal ngay_khai As Integer, ByVal CMT_gui As String) As DataSet

            ' The procedure returns these columns:
            ' So_To_Khai


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "To_Khai_Hai_Quan_Xuat_Kiem_Tra_Tai_Lieu"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Ngay_khai", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ngay_khai))
                MyCommand.Parameters.Add(New SqlParameter("@CMT_gui", SqlDbType.VarChar, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, CMT_gui))


                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                MyCommand.CommandTimeout = 20000
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


#Region "To_Khai_Hai_Quan_Xuat_Update_Tai_Lieu"
        Public Function To_Khai_Hai_Quan_Xuat_Update_Tai_Lieu(ByVal ngay_khai As Integer, ByVal CMT_gui As String, ByVal Tong_khoi_luong As Double, ByVal Tong_so_tui As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "To_Khai_Hai_Quan_Xuat_Update_Tai_Lieu"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myTo_Khai_Hai_Quan_Xuat_Chi_Tiet As New To_Khai_Hai_Quan_Xuat_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pNgay_khai As SqlParameter = New SqlParameter("@Ngay_khai", SqlDbType.VarChar, 20)
                pNgay_khai.Value = ngay_khai
                MyCommand.Parameters.Add(pNgay_khai)

                Dim pCMT_gui As SqlParameter = New SqlParameter("@CMT_gui", SqlDbType.VarChar, 20)
                pCMT_gui.Value = CMT_gui
                MyCommand.Parameters.Add(pCMT_gui)

                Dim pTong_khoi_luong As SqlParameter = New SqlParameter("@Tong_khoi_luong", SqlDbType.Int, 0)
                pTong_khoi_luong.Value = Tong_khoi_luong
                MyCommand.Parameters.Add(pTong_khoi_luong)

                Dim pTong_so_tui As SqlParameter = New SqlParameter("@Tong_so_tui", SqlDbType.Int, 0)
                pTong_so_tui.Value = Tong_so_tui
                MyCommand.Parameters.Add(pTong_so_tui)


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




#Region "To_Khai_Hai_Quan_Xuat_Them"
        Public Function To_Khai_Hai_Quan_Xuat_Them(ByVal Ma_To_Khai As String, ByVal So_TKHQ As String, ByVal Ngay_Khai As Integer, ByVal Gio_Khai As Integer, ByVal So_To_Khai_HQ_Cap As String, ByVal Luong As Integer, ByVal Nguoi_Duoc_Uy_Quyen As String, ByVal Can_Bo_Kiem_Tra As String, ByVal Can_Bo_Tinh_Thue As String, ByVal Can_Bo_Xac_Nhan As String, ByVal Nguoi_Gui As String, ByVal Dia_Chi_Gui As String, ByVal Dien_Thoai_Gui As String, ByVal CMT_Gui As String, ByVal CMT_Ngay_Gui As Integer, ByVal Nuoc_Gui As String, ByVal Nguoi_Nhan As String, ByVal Dia_Chi_Nhan As String, ByVal Dien_Thoai_Nhan As String, ByVal CMT_Nhan As String, ByVal CMT_Ngay_Nhan As Integer, ByVal Nuoc_Nhan As String, ByVal IsPrint As Boolean, ByVal IsPhuLuc As Boolean, ByVal IsOpen As Boolean, ByVal Kieu_Kiem_Hoa As Integer, ByVal Giay_To_Kem_Theo As String, ByVal Tong_So_Tui As Integer, ByVal Tong_Khoi_Luong As Double, ByVal Tong_So_Kien As Integer, ByVal Ngay_CN38 As Integer, ByVal Ghi_Chu As String, ByVal Thong_Tin_Tai_Lieu As String, ByVal IsQua_Tang As Boolean, ByVal IsHang_Mau As Boolean, ByVal IsPay As Boolean, ByVal IsPayTax As Boolean, ByVal Cuoc_Van_Chuyen As Double, ByVal Ma_Tien_Te As String, ByVal Ty_Gia As Double, ByVal Cuoc_Van_Chuyen_VN As Double, ByVal Tri_So_Van_Chuyen As Double, ByVal Tien_Qua_Tang As Double, ByVal Le_Phi_HQ As Double, ByVal Tri_Gia_Nguyen_Te As Double, ByVal Tong_Thue_Suat As Double, ByVal Tong_Thue_Vat As Double, ByVal Ty_Gia_USD As Double, ByVal Id_Phan_Loai As Integer, ByVal Ma_Tien_Te_HQ As String, ByVal Id_Duong_Thu As String, ByVal Ip_May_Tinh As String, ByVal Ban_So As Integer, ByVal Truyen_So_Lieu As Boolean, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer, ByVal Chot_SL As Boolean) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "To_Khai_Hai_Quan_Xuat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myTo_Khai_Hai_Quan_Xuat_Chi_Tiet As New To_Khai_Hai_Quan_Xuat_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_To_Khai As SqlParameter = New SqlParameter("@Ma_To_Khai", SqlDbType.VarChar, 20)
                pMa_To_Khai.Value = Ma_To_Khai
                MyCommand.Parameters.Add(pMa_To_Khai)

                Dim pSo_TKHQ As SqlParameter = New SqlParameter("@So_TKHQ", SqlDbType.VarChar, 20)
                pSo_TKHQ.Value = So_TKHQ
                MyCommand.Parameters.Add(pSo_TKHQ)

                Dim pNgay_Khai As SqlParameter = New SqlParameter("@Ngay_Khai", SqlDbType.Int, 0)
                pNgay_Khai.Value = Ngay_Khai
                MyCommand.Parameters.Add(pNgay_Khai)

                Dim pGio_Khai As SqlParameter = New SqlParameter("@Gio_Khai", SqlDbType.Int, 0)
                pGio_Khai.Value = Gio_Khai
                MyCommand.Parameters.Add(pGio_Khai)

                Dim pSo_To_Khai_HQ_Cap As SqlParameter = New SqlParameter("@So_To_Khai_HQ_Cap", SqlDbType.VarChar, 20)
                pSo_To_Khai_HQ_Cap.Value = So_To_Khai_HQ_Cap
                MyCommand.Parameters.Add(pSo_To_Khai_HQ_Cap)

                Dim pLuong As SqlParameter = New SqlParameter("@Luong", SqlDbType.Int, 0)
                pLuong.Value = Luong
                MyCommand.Parameters.Add(pLuong)

                Dim pNguoi_Duoc_Uy_Quyen As SqlParameter = New SqlParameter("@Nguoi_Duoc_Uy_Quyen", SqlDbType.NVarChar, 50)
                pNguoi_Duoc_Uy_Quyen.Value = Nguoi_Duoc_Uy_Quyen
                MyCommand.Parameters.Add(pNguoi_Duoc_Uy_Quyen)

                Dim pCan_Bo_Kiem_Tra As SqlParameter = New SqlParameter("@Can_Bo_Kiem_Tra", SqlDbType.NVarChar, 50)
                pCan_Bo_Kiem_Tra.Value = Can_Bo_Kiem_Tra
                MyCommand.Parameters.Add(pCan_Bo_Kiem_Tra)

                Dim pCan_Bo_Tinh_Thue As SqlParameter = New SqlParameter("@Can_Bo_Tinh_Thue", SqlDbType.NVarChar, 50)
                pCan_Bo_Tinh_Thue.Value = Can_Bo_Tinh_Thue
                MyCommand.Parameters.Add(pCan_Bo_Tinh_Thue)

                Dim pCan_Bo_Xac_Nhan As SqlParameter = New SqlParameter("@Can_Bo_Xac_Nhan", SqlDbType.NVarChar, 50)
                pCan_Bo_Xac_Nhan.Value = Can_Bo_Xac_Nhan
                MyCommand.Parameters.Add(pCan_Bo_Xac_Nhan)

                Dim pNguoi_Gui As SqlParameter = New SqlParameter("@Nguoi_Gui", SqlDbType.NVarChar, 50)
                pNguoi_Gui.Value = Nguoi_Gui
                MyCommand.Parameters.Add(pNguoi_Gui)

                Dim pDia_Chi_Gui As SqlParameter = New SqlParameter("@Dia_Chi_Gui", SqlDbType.NVarChar, 100)
                pDia_Chi_Gui.Value = Dia_Chi_Gui
                MyCommand.Parameters.Add(pDia_Chi_Gui)

                Dim pDien_Thoai_Gui As SqlParameter = New SqlParameter("@Dien_Thoai_Gui", SqlDbType.NVarChar, 100)
                pDien_Thoai_Gui.Value = Dien_Thoai_Gui
                MyCommand.Parameters.Add(pDien_Thoai_Gui)

                Dim pCMT_Gui As SqlParameter = New SqlParameter("@CMT_Gui", SqlDbType.VarChar, 20)
                pCMT_Gui.Value = CMT_Gui
                MyCommand.Parameters.Add(pCMT_Gui)

                Dim pCMT_Ngay_Gui As SqlParameter = New SqlParameter("@CMT_Ngay_Gui", SqlDbType.Int, 0)
                pCMT_Ngay_Gui.Value = CMT_Ngay_Gui
                MyCommand.Parameters.Add(pCMT_Ngay_Gui)

                Dim pNuoc_Gui As SqlParameter = New SqlParameter("@Nuoc_Gui", SqlDbType.VarChar, 50)
                pNuoc_Gui.Value = Nuoc_Gui
                MyCommand.Parameters.Add(pNuoc_Gui)

                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.NVarChar, 50)
                pNguoi_Nhan.Value = Nguoi_Nhan
                MyCommand.Parameters.Add(pNguoi_Nhan)

                Dim pDia_Chi_Nhan As SqlParameter = New SqlParameter("@Dia_Chi_Nhan", SqlDbType.NVarChar, 100)
                pDia_Chi_Nhan.Value = Dia_Chi_Nhan
                MyCommand.Parameters.Add(pDia_Chi_Nhan)

                Dim pDien_Thoai_Nhan As SqlParameter = New SqlParameter("@Dien_Thoai_Nhan", SqlDbType.NVarChar, 100)
                pDien_Thoai_Nhan.Value = Dien_Thoai_Nhan
                MyCommand.Parameters.Add(pDien_Thoai_Nhan)

                Dim pCMT_Nhan As SqlParameter = New SqlParameter("@CMT_Nhan", SqlDbType.VarChar, 20)
                pCMT_Nhan.Value = CMT_Nhan
                MyCommand.Parameters.Add(pCMT_Nhan)

                Dim pCMT_Ngay_Nhan As SqlParameter = New SqlParameter("@CMT_Ngay_Nhan", SqlDbType.Int, 0)
                pCMT_Ngay_Nhan.Value = CMT_Ngay_Nhan
                MyCommand.Parameters.Add(pCMT_Ngay_Nhan)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 50)
                pNuoc_Nhan.Value = Nuoc_Nhan
                MyCommand.Parameters.Add(pNuoc_Nhan)

                Dim pIsPrint As SqlParameter = New SqlParameter("@IsPrint", SqlDbType.Bit, 0)
                pIsPrint.Value = IsPrint
                MyCommand.Parameters.Add(pIsPrint)

                Dim pIsPhuLuc As SqlParameter = New SqlParameter("@IsPhuLuc", SqlDbType.Bit, 0)
                pIsPhuLuc.Value = IsPhuLuc
                MyCommand.Parameters.Add(pIsPhuLuc)

                Dim pIsOpen As SqlParameter = New SqlParameter("@IsOpen", SqlDbType.Bit, 0)
                pIsOpen.Value = IsOpen
                MyCommand.Parameters.Add(pIsOpen)

                Dim pKieu_Kiem_Hoa As SqlParameter = New SqlParameter("@Kieu_Kiem_Hoa", SqlDbType.Int, 0)
                pKieu_Kiem_Hoa.Value = Kieu_Kiem_Hoa
                MyCommand.Parameters.Add(pKieu_Kiem_Hoa)

                Dim pGiay_To_Kem_Theo As SqlParameter = New SqlParameter("@Giay_To_Kem_Theo", SqlDbType.NVarChar, 100)
                pGiay_To_Kem_Theo.Value = Giay_To_Kem_Theo
                MyCommand.Parameters.Add(pGiay_To_Kem_Theo)

                Dim pTong_So_Tui As SqlParameter = New SqlParameter("@Tong_So_Tui", SqlDbType.Int, 0)
                pTong_So_Tui.Value = Tong_So_Tui
                MyCommand.Parameters.Add(pTong_So_Tui)

                Dim pTong_Khoi_Luong As SqlParameter = New SqlParameter("@Tong_Khoi_Luong", SqlDbType.Float, 0)
                pTong_Khoi_Luong.Value = Tong_Khoi_Luong
                MyCommand.Parameters.Add(pTong_Khoi_Luong)

                Dim pTong_So_Kien As SqlParameter = New SqlParameter("@Tong_So_Kien", SqlDbType.Int, 0)
                pTong_So_Kien.Value = Tong_So_Kien
                MyCommand.Parameters.Add(pTong_So_Kien)

                Dim pNgay_CN38 As SqlParameter = New SqlParameter("@Ngay_CN38", SqlDbType.Int, 0)
                pNgay_CN38.Value = Ngay_CN38
                MyCommand.Parameters.Add(pNgay_CN38)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 100)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pThong_Tin_Tai_Lieu As SqlParameter = New SqlParameter("@Thong_Tin_Tai_Lieu", SqlDbType.NVarChar, 200)
                pThong_Tin_Tai_Lieu.Value = Thong_Tin_Tai_Lieu
                MyCommand.Parameters.Add(pThong_Tin_Tai_Lieu)

                Dim pIsQua_Tang As SqlParameter = New SqlParameter("@IsQua_Tang", SqlDbType.Bit, 0)
                pIsQua_Tang.Value = IsQua_Tang
                MyCommand.Parameters.Add(pIsQua_Tang)

                Dim pIsHang_Mau As SqlParameter = New SqlParameter("@IsHang_Mau", SqlDbType.Bit, 0)
                pIsHang_Mau.Value = IsHang_Mau
                MyCommand.Parameters.Add(pIsHang_Mau)

                Dim pIsPay As SqlParameter = New SqlParameter("@IsPay", SqlDbType.Bit, 0)
                pIsPay.Value = IsPay
                MyCommand.Parameters.Add(pIsPay)

                Dim pIsPayTax As SqlParameter = New SqlParameter("@IsPayTax", SqlDbType.Bit, 0)
                pIsPayTax.Value = IsPayTax
                MyCommand.Parameters.Add(pIsPayTax)

                Dim pCuoc_Van_Chuyen As SqlParameter = New SqlParameter("@Cuoc_Van_Chuyen", SqlDbType.Float, 0)
                pCuoc_Van_Chuyen.Value = Cuoc_Van_Chuyen
                MyCommand.Parameters.Add(pCuoc_Van_Chuyen)

                Dim pMa_Tien_Te As SqlParameter = New SqlParameter("@Ma_Tien_Te", SqlDbType.VarChar, 5)
                pMa_Tien_Te.Value = Ma_Tien_Te
                MyCommand.Parameters.Add(pMa_Tien_Te)

                Dim pTy_Gia As SqlParameter = New SqlParameter("@Ty_Gia", SqlDbType.Float, 0)
                pTy_Gia.Value = Ty_Gia
                MyCommand.Parameters.Add(pTy_Gia)

                Dim pCuoc_Van_Chuyen_VN As SqlParameter = New SqlParameter("@Cuoc_Van_Chuyen_VN", SqlDbType.Float, 0)
                pCuoc_Van_Chuyen_VN.Value = Cuoc_Van_Chuyen_VN
                MyCommand.Parameters.Add(pCuoc_Van_Chuyen_VN)

                Dim pTri_So_Van_Chuyen As SqlParameter = New SqlParameter("@Tri_So_Van_Chuyen", SqlDbType.Float, 0)
                pTri_So_Van_Chuyen.Value = Tri_So_Van_Chuyen
                MyCommand.Parameters.Add(pTri_So_Van_Chuyen)

                Dim pTien_Qua_Tang As SqlParameter = New SqlParameter("@Tien_Qua_Tang", SqlDbType.Float, 0)
                pTien_Qua_Tang.Value = Tien_Qua_Tang
                MyCommand.Parameters.Add(pTien_Qua_Tang)

                Dim pLe_Phi_HQ As SqlParameter = New SqlParameter("@Le_Phi_HQ", SqlDbType.Float, 0)
                pLe_Phi_HQ.Value = Le_Phi_HQ
                MyCommand.Parameters.Add(pLe_Phi_HQ)

                Dim pTri_Gia_Nguyen_Te As SqlParameter = New SqlParameter("@Tri_Gia_Nguyen_Te", SqlDbType.Float, 0)
                pTri_Gia_Nguyen_Te.Value = Tri_Gia_Nguyen_Te
                MyCommand.Parameters.Add(pTri_Gia_Nguyen_Te)

                Dim pTong_Thue_Suat As SqlParameter = New SqlParameter("@Tong_Thue_Suat", SqlDbType.Float, 0)
                pTong_Thue_Suat.Value = Tong_Thue_Suat
                MyCommand.Parameters.Add(pTong_Thue_Suat)

                Dim pTong_Thue_Vat As SqlParameter = New SqlParameter("@Tong_Thue_Vat", SqlDbType.Float, 0)
                pTong_Thue_Vat.Value = Tong_Thue_Vat
                MyCommand.Parameters.Add(pTong_Thue_Vat)

                Dim pTy_Gia_USD As SqlParameter = New SqlParameter("@Ty_Gia_USD", SqlDbType.Float, 0)
                pTy_Gia_USD.Value = Ty_Gia_USD
                MyCommand.Parameters.Add(pTy_Gia_USD)

                Dim pId_Phan_Loai As SqlParameter = New SqlParameter("@Id_Phan_Loai", SqlDbType.Int, 0)
                pId_Phan_Loai.Value = Id_Phan_Loai
                MyCommand.Parameters.Add(pId_Phan_Loai)

                Dim pMa_Tien_Te_HQ As SqlParameter = New SqlParameter("@Ma_Tien_Te_HQ", SqlDbType.VarChar, 5)
                pMa_Tien_Te_HQ.Value = Ma_Tien_Te_HQ
                MyCommand.Parameters.Add(pMa_Tien_Te_HQ)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pIp_May_Tinh As SqlParameter = New SqlParameter("@Ip_May_Tinh", SqlDbType.VarChar, 15)
                pIp_May_Tinh.Value = Ip_May_Tinh
                MyCommand.Parameters.Add(pIp_May_Tinh)

                Dim pBan_So As SqlParameter = New SqlParameter("@Ban_So", SqlDbType.Int, 0)
                pBan_So.Value = Ban_So
                MyCommand.Parameters.Add(pBan_So)

                Dim pTruyen_So_Lieu As SqlParameter = New SqlParameter("@Truyen_So_Lieu", SqlDbType.Bit, 0)
                pTruyen_So_Lieu.Value = Truyen_So_Lieu
                MyCommand.Parameters.Add(pTruyen_So_Lieu)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Value = Ngay_He_Thong
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Value = Gio_He_Thong
                MyCommand.Parameters.Add(pGio_He_Thong)

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

#Region "To_Khai_Hai_Quan_Xuat_Xoa"
        Public Function To_Khai_Hai_Quan_Xuat_Xoa(ByVal Ma_To_Khai As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "To_Khai_Hai_Quan_Xuat_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myTo_Khai_Hai_Quan_Xuat_Chi_Tiet As New To_Khai_Hai_Quan_Xuat_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_To_Khai As SqlParameter = New SqlParameter("@Ma_To_Khai", SqlDbType.VarChar, 20)
                pMa_To_Khai.Value = Ma_To_Khai
                MyCommand.Parameters.Add(pMa_To_Khai)


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

#Region "To_Khai_Hai_Quan_Xuat_Lay_Danh_Sach_So_TK"

        Public Function To_Khai_Hai_Quan_Xuat_Lay_Danh_Sach_So_TK(ByVal tu_Ngay As Integer, ByVal den_Ngay As Integer, ByVal loai_Kiem_Hoa As Integer) As DataSet

            ' The procedure returns these columns:
            ' So_To_Khai


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "To_Khai_Hai_Quan_Xuat_Lay_Danh_Sach_So_TK"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, tu_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Den_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, den_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Loai_Kiem_Hoa", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, loai_Kiem_Hoa))

                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                MyCommand.CommandTimeout = 20000
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
#Region "To_Khai_Hai_Quan_Xuat_Cap_Nhat_Trang_Thai_IsOpen"
        Public Function To_Khai_Hai_Quan_Xuat_Cap_Nhat_Trang_Thai_IsOpen(ByVal Ma_To_Khai As String, ByVal IsOpen As Boolean) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "To_Khai_Hai_Quan_Xuat_Cap_Nhat_Trang_Thai_IsOpen"
            MyCommand.CommandType = CommandType.StoredProcedure

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_To_Khai As SqlParameter = New SqlParameter("@Ma_To_Khai", SqlDbType.VarChar, 20)
                pMa_To_Khai.Value = Ma_To_Khai
                MyCommand.Parameters.Add(pMa_To_Khai)

                Dim pIsOpen As SqlParameter = New SqlParameter("@IsOpen", SqlDbType.Bit, 0)
                pIsOpen.Value = IsOpen
                MyCommand.Parameters.Add(pIsOpen)

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
#Region "To_Khai_Hai_Quan_Xuat_Cap_Nhat_Trang_Thai_IsPrint"
        Public Function To_Khai_Hai_Quan_Xuat_Cap_Nhat_Trang_Thai_IsPrint(ByVal Ma_To_Khai As String, ByVal IsPrint As Boolean) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "To_Khai_Hai_Quan_Xuat_Cap_Nhat_Trang_Thai_IsPrint"
            MyCommand.CommandType = CommandType.StoredProcedure

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_To_Khai As SqlParameter = New SqlParameter("@Ma_To_Khai", SqlDbType.VarChar, 20)
                pMa_To_Khai.Value = Ma_To_Khai
                MyCommand.Parameters.Add(pMa_To_Khai)

                Dim pIsPrint As SqlParameter = New SqlParameter("@IsPrint", SqlDbType.Bit, 0)
                pIsPrint.Value = IsPrint
                MyCommand.Parameters.Add(pIsPrint)

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
#Region "To_Khai_Hai_Quan_Xuat_Tao_So_TK_Moi"
        Public Function To_Khai_Hai_Quan_Xuat_Tao_So_TK_Moi(ByVal tu_Ngay As Integer, ByVal den_Ngay As Integer, ByVal kieu_Kiem_Hoa As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "To_Khai_Hai_Quan_Xuat_Tao_So_TK_Moi"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, tu_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Den_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, den_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Kieu_Kiem_Hoa", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, kieu_Kiem_Hoa))
                MyCommand.Parameters.Add(New SqlParameter("@So_TK", SqlDbType.Int, 0, ParameterDirection.Output, True, 10, 0, "", DataRowVersion.Current, DBNull.Value))

                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()
                MyCommand.CommandTimeout = 20000
                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                Return CType(MyCommand.Parameters(3).Value, Integer)
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
#Region "To_Khai_Hai_Quan_Xuat_Tao_So_TK_Moi_Bang"
        Public Function To_Khai_Hai_Quan_Xuat_Tao_So_TK_Moi_Bang(ByVal tu_Ngay As Integer, ByVal den_Ngay As Integer, ByVal kieu_Kiem_Hoa As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "To_Khai_Hai_Quan_Xuat_Tao_So_TK_Moi_Bang"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, tu_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Den_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, den_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Kieu_Kiem_Hoa", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, kieu_Kiem_Hoa))
                MyCommand.Parameters.Add(New SqlParameter("@So_TK", SqlDbType.Int, 0, ParameterDirection.Output, True, 10, 0, "", DataRowVersion.Current, DBNull.Value))

                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()
                MyCommand.CommandTimeout = 20000
                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                Return CType(MyCommand.Parameters(3).Value, Integer)
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
#Region "To_Khai_Hai_Quan_Xuat_Lay_Boi_Ma_To_Khai_In_To_Khai"

        Public Function To_Khai_Hai_Quan_Xuat_Lay_Boi_Ma_To_Khai_In_To_Khai(ByVal Ma_To_Khai As String) As DataSet

            ' The procedure returns these columns:
            ' Ma_To_Khai
            ' So_TKHQ
            ' Ngay_Khai
            ' So_To_Khai_HQ_Cap
            ' Nguoi_Duoc_Uy_Quyen
            ' Nguoi_Gui
            ' Dia_Chi_Gui
            ' Nguoi_Nhan
            ' Dia_Chi_Nhan
            ' IsPrint
            ' IsPhuLuc
            ' Giay_To_Kem_Theo
            ' Tong_So_Tui
            ' Tong_Khoi_Luong
            ' Ngay_CN38
            ' Ghi_Chu
            ' Thong_Tin_Tai_Lieu
            ' IsOpen


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "To_Khai_Hai_Quan_Xuat_Lay_Boi_Ma_To_Khai_In_To_Khai"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pMa_To_Khai As SqlParameter = New SqlParameter("@Ma_To_Khai", SqlDbType.VarChar, 20)
                pMa_To_Khai.Value = Ma_To_Khai
                MyCommand.Parameters.Add(pMa_To_Khai)


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
#Region "To_Khai_Hai_Quan_Xuat_Lay_Thong_Tin_Chi_Tiet_In_To_Khai"

        Public Function To_Khai_Hai_Quan_Xuat_Lay_Thong_Tin_Chi_Tiet_In_To_Khai(ByVal Ma_To_Khai As String) As DataSet

            ' The procedure returns these columns:
            ' STT
            ' Ma_E1
            ' Khoi_Luong
            ' Nguoi_Gui
            ' Dia_Chi_Gui
            ' Nguoi_Nhan
            ' Dia_Chi_Nhan
            ' Ten_Hang_Hoa
            ' Xuat_Xu
            ' Luong_Hang
            ' Don_Vi_Tinh


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "To_Khai_Hai_Quan_Xuat_Lay_Thong_Tin_Chi_Tiet_In_To_Khai"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pMa_To_Khai As SqlParameter = New SqlParameter("@Ma_To_Khai", SqlDbType.VarChar, 20)
                pMa_To_Khai.Value = Ma_To_Khai
                MyCommand.Parameters.Add(pMa_To_Khai)


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

#Region "To_Khai_Hai_Quan_Xuat_Danh_Sach_Tim_Kiem"

        Public Function To_Khai_Hai_Quan_Xuat_Danh_Sach_Tim_Kiem(ByVal kieu_Tim_Kiem As Integer, ByVal tu_Ngay As Integer, ByVal den_Ngay As Integer, ByVal ma_E1 As String, ByVal kieu_Kiem_Hoa As Integer, ByVal so_TKHQ As String) As DataSet

            ' The procedure returns these columns:
            ' Ma_To_Khai
            ' Ngay_Khai
            ' Gio_Khai
            ' Kieu_Kiem_Hoa
            ' So_TKHQ
            ' So_To_Khai
            ' Tong_So_Ma_E1
            ' Khoi_Luong
            ' Tri_Gia_Nguyen_Te
            ' Tong_Thue_Suat
            ' Tong_Thue_Vat
            ' Nguoi_Khai


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "To_Khai_Hai_Quan_Xuat_Danh_Sach_Tim_Kiem"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Kieu_Tim_Kiem", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, kieu_Tim_Kiem))
                MyCommand.Parameters.Add(New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, tu_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Den_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, den_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, ma_E1))
                MyCommand.Parameters.Add(New SqlParameter("@Kieu_Kiem_Hoa", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, kieu_Kiem_Hoa))
                MyCommand.Parameters.Add(New SqlParameter("@So_TKHQ", SqlDbType.VarChar, 6, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, so_TKHQ))

                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                MyCommand.CommandTimeout = 20000
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
#Region "To_Khai_Hai_Quan_Xuat_Danh_Sach_Sua_Chua_To_Khai"

        Public Function To_Khai_Hai_Quan_Xuat_Danh_Sach_Sua_Chua_To_Khai(ByVal Kieu_Tim_Kiem As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal Ma_E1 As String, ByVal Kieu_Kiem_Hoa As Integer, ByVal So_TKHQ As String) As DataSet

            ' The procedure returns these columns:
            ' Ma_To_Khai
            ' So_TKHQ
            ' Ngay_Khai
            ' Gio_Khai
            ' So_To_Khai_HQ_Cap
            ' Luong
            ' Nguoi_Duoc_Uy_Quyen
            ' Can_Bo_Kiem_Tra
            ' Can_Bo_Tinh_Thue
            ' Can_Bo_Xac_Nhan
            ' Nguoi_Gui
            ' Dia_Chi_Gui
            ' Dien_Thoai_Gui
            ' CMT_Gui
            ' CMT_Ngay_Gui
            ' Nuoc_Gui
            ' Nguoi_Nhan
            ' Dia_Chi_Nhan
            ' Dien_Thoai_Nhan
            ' CMT_Nhan
            ' CMT_Ngay_Nhan
            ' Nuoc_Nhan
            ' IsPrint
            ' IsPhuLuc
            ' IsOpen
            ' Kieu_Kiem_Hoa
            ' Giay_To_Kem_Theo
            ' Tong_So_Tui
            ' Tong_Khoi_Luong
            ' Tong_So_Kien
            ' Ngay_CN38
            ' Ghi_Chu
            ' Thong_Tin_Tai_Lieu
            ' IsQua_Tang
            ' IsHang_Mau
            ' IsPay
            ' IsPayTax
            ' Cuoc_Van_Chuyen
            ' Ma_Tien_Te
            ' Ty_Gia
            ' Cuoc_Van_Chuyen_VN
            ' Tri_So_Van_Chuyen
            ' Tien_Qua_Tang
            ' Le_Phi_HQ
            ' Tri_Gia_Nguyen_Te
            ' Tong_Thue_Suat
            ' Tong_Thue_Vat
            ' Ty_Gia_USD
            ' Id_Phan_Loai
            ' Ma_Tien_Te_HQ
            ' Id_Duong_Thu
            ' Ip_May_Tinh
            ' Ban_So
            ' Truyen_So_Lieu
            ' Ngay_He_Thong
            ' Gio_He_Thong
            ' Chot_SL


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "To_Khai_Hai_Quan_Xuat_Danh_Sach_Sua_Chua_To_Khai"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pKieu_Tim_Kiem As SqlParameter = New SqlParameter("@Kieu_Tim_Kiem", SqlDbType.Int, 0)
                pKieu_Tim_Kiem.Value = Kieu_Tim_Kiem
                MyCommand.Parameters.Add(pKieu_Tim_Kiem)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0)
                pTu_Ngay.Value = Tu_Ngay
                MyCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 0)
                pDen_Ngay.Value = Den_Ngay
                MyCommand.Parameters.Add(pDen_Ngay)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                MyCommand.Parameters.Add(pMa_E1)

                Dim pKieu_Kiem_Hoa As SqlParameter = New SqlParameter("@Kieu_Kiem_Hoa", SqlDbType.Int, 0)
                pKieu_Kiem_Hoa.Value = Kieu_Kiem_Hoa
                MyCommand.Parameters.Add(pKieu_Kiem_Hoa)

                Dim pSo_TKHQ As SqlParameter = New SqlParameter("@So_TKHQ", SqlDbType.VarChar, 6)
                pSo_TKHQ.Value = So_TKHQ
                MyCommand.Parameters.Add(pSo_TKHQ)


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


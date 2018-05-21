
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "E1_Den_E_Shipping_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop E1_Den_E_Shipping_Chi_Tiet
    'Tuong ung voi moi truong trong bang E1_Den_E_Shipping trong co so du lieu
    '***********************************************************
    Public Class E1_Den_E_Shipping_Chi_Tiet
        Public Id_E1 As String
        Public Id_Duong_Thu As String
        Public Id_Chuyen_Thu As String
        Public Id_E2 As String
        Public Id_Ca As String
        Public Ma_Bc_Khai_Thac As Integer
        Public Ma_Quay As Integer
        Public Ma_E1 As String
        Public Ngay_Phat_Hanh As Integer
        Public Gio_Phat_Hanh As Integer
        Public Ngay_Dong As Integer
        Public Gio_Dong As Integer
        Public Ngay_Nhan As Integer
        Public Gio_Nhan As Integer
        Public Ma_Don_Vi As String
        Public Ma_Bc_Goc As Integer
        Public Ma_Bc_Tra As Integer
        Public Nuoc_Nhan As String
        Public Nuoc_Tra As String
        Public Khoi_Luong As Integer
        Public Phan_Loai As String
        Public Loai_Hang_Hoa As Integer
        Public Khoi_Luong_QD As Integer
        Public Loai As Integer
        Public Dv_Cong_Them As String
        Public Dv_Gia_Tang As String
        Public PPXD As Double
        Public Cuoc_PPXD As Integer
        Public PostCode As String
        Public Cuoc_PPVX As Integer
        Public VAT As Double
        Public COD As Boolean
        Public Gia_Tri_Hang As Integer
        Public Cuoc_COD As Integer
        Public Cuoc_DV As Integer
        Public Cuoc_Chinh As Integer
        Public Cuoc_Giam As Integer
        Public Cuoc_E1 As Integer
        Public Kien_So As Integer
        Public STT As Integer
        Public Ma_KH As String
        Public Nguoi_Gui As String
        Public Nguoi_Nhan As String
        Public Dia_Chi_Gui As String
        Public Dia_Chi_Nhan As String
        Public Dien_Thoai_Gui As String
        Public Dien_Thoai_Nhan As String
        Public HH_Phat_Hanh As Integer
        Public HH_Phat_Tra As Integer
        Public Ma_Bc_CH As Integer
        Public Id_Nguoi_Dung As Integer
        Public Id_Trang_Thai As Integer
        Public Ghi_Chu As String
        Public Truyen_Khai_Thac As Boolean
        Public Truyen_Doi_Soat As Boolean
        Public Ngay_He_Thong As Integer
        Public Gio_He_Thong As Integer
        Public Chot_SL As Boolean
        Public Ma_E1_E_Shipping As String
        Public Id_E1_E_Shipping As String
        Public Id_E1_Thay_The As String
    End Class
#End Region

#Region "E1_Den_E_Shipping"
    Public Class E1_Den_E_Shipping
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "E1_Den_E_Shipping_Cap_Nhat"
        Public Function E1_Den_E_Shipping_Cap_Nhat(ByVal Id_E1 As String, ByVal Id_Duong_Thu As String, ByVal Id_Chuyen_Thu As String, ByVal Id_E2 As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Quay As Integer, ByVal Ma_E1 As String, ByVal Ngay_Phat_Hanh As Integer, ByVal Gio_Phat_Hanh As Integer, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Ma_Don_Vi As String, ByVal Ma_Bc_Goc As Integer, ByVal Ma_Bc_Tra As Integer, ByVal Nuoc_Nhan As String, ByVal Nuoc_Tra As String, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal Loai_Hang_Hoa As Integer, ByVal Khoi_Luong_QD As Integer, ByVal Loai As Integer, ByVal Dv_Cong_Them As String, ByVal Dv_Gia_Tang As String, ByVal PPXD As Double, ByVal Cuoc_PPXD As Integer, ByVal PostCode As String, ByVal Cuoc_PPVX As Integer, ByVal VAT As Double, ByVal COD As Boolean, ByVal Gia_Tri_Hang As Integer, ByVal Cuoc_COD As Integer, ByVal Cuoc_DV As Integer, ByVal Cuoc_Chinh As Integer, ByVal Cuoc_Giam As Integer, ByVal Cuoc_E1 As Integer, ByVal Kien_So As Integer, ByVal STT As Integer, ByVal Ma_KH As String, ByVal Nguoi_Gui As String, ByVal Nguoi_Nhan As String, ByVal Dia_Chi_Gui As String, ByVal Dia_Chi_Nhan As String, ByVal Dien_Thoai_Gui As String, ByVal Dien_Thoai_Nhan As String, ByVal HH_Phat_Hanh As Integer, ByVal HH_Phat_Tra As Integer, ByVal Ma_Bc_CH As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Id_Trang_Thai As Integer, ByVal Ghi_Chu As String, ByVal Truyen_Khai_Thac As Boolean, ByVal Truyen_Doi_Soat As Boolean, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer, ByVal Chot_SL As Boolean, ByVal Ma_E1_E_Shipping As String, ByVal Id_E1_E_Shipping As String, ByVal Id_E1_Thay_The As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Den_E_Shipping_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myE1_Den_E_Shipping_Chi_Tiet As New E1_Den_E_Shipping_Chi_Tiet

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

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                MyCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                MyCommand.Parameters.Add(pId_E2)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                MyCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Quay As SqlParameter = New SqlParameter("@Ma_Quay", SqlDbType.Int, 0)
                pMa_Quay.Value = Ma_Quay
                MyCommand.Parameters.Add(pMa_Quay)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                MyCommand.Parameters.Add(pMa_E1)

                Dim pNgay_Phat_Hanh As SqlParameter = New SqlParameter("@Ngay_Phat_Hanh", SqlDbType.Int, 0)
                pNgay_Phat_Hanh.Value = Ngay_Phat_Hanh
                MyCommand.Parameters.Add(pNgay_Phat_Hanh)

                Dim pGio_Phat_Hanh As SqlParameter = New SqlParameter("@Gio_Phat_Hanh", SqlDbType.Int, 0)
                pGio_Phat_Hanh.Value = Gio_Phat_Hanh
                MyCommand.Parameters.Add(pGio_Phat_Hanh)

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

                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
                pMa_Don_Vi.Value = Ma_Don_Vi
                MyCommand.Parameters.Add(pMa_Don_Vi)

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

                Dim pDv_Cong_Them As SqlParameter = New SqlParameter("@Dv_Cong_Them", SqlDbType.VarChar, 50)
                pDv_Cong_Them.Value = Dv_Cong_Them
                MyCommand.Parameters.Add(pDv_Cong_Them)

                Dim pDv_Gia_Tang As SqlParameter = New SqlParameter("@Dv_Gia_Tang", SqlDbType.VarChar, 50)
                pDv_Gia_Tang.Value = Dv_Gia_Tang
                MyCommand.Parameters.Add(pDv_Gia_Tang)

                Dim pPPXD As SqlParameter = New SqlParameter("@PPXD", SqlDbType.Float, 0)
                pPPXD.Value = PPXD
                MyCommand.Parameters.Add(pPPXD)

                Dim pCuoc_PPXD As SqlParameter = New SqlParameter("@Cuoc_PPXD", SqlDbType.Int, 0)
                pCuoc_PPXD.Value = Cuoc_PPXD
                MyCommand.Parameters.Add(pCuoc_PPXD)

                Dim pPostCode As SqlParameter = New SqlParameter("@PostCode", SqlDbType.VarChar, 50)
                pPostCode.Value = PostCode
                MyCommand.Parameters.Add(pPostCode)

                Dim pCuoc_PPVX As SqlParameter = New SqlParameter("@Cuoc_PPVX", SqlDbType.Int, 0)
                pCuoc_PPVX.Value = Cuoc_PPVX
                MyCommand.Parameters.Add(pCuoc_PPVX)

                Dim pVAT As SqlParameter = New SqlParameter("@VAT", SqlDbType.Float, 0)
                pVAT.Value = VAT
                MyCommand.Parameters.Add(pVAT)

                Dim pCOD As SqlParameter = New SqlParameter("@COD", SqlDbType.Bit, 0)
                pCOD.Value = COD
                MyCommand.Parameters.Add(pCOD)

                Dim pGia_Tri_Hang As SqlParameter = New SqlParameter("@Gia_Tri_Hang", SqlDbType.Int, 0)
                pGia_Tri_Hang.Value = Gia_Tri_Hang
                MyCommand.Parameters.Add(pGia_Tri_Hang)

                Dim pCuoc_COD As SqlParameter = New SqlParameter("@Cuoc_COD", SqlDbType.Int, 0)
                pCuoc_COD.Value = Cuoc_COD
                MyCommand.Parameters.Add(pCuoc_COD)

                Dim pCuoc_DV As SqlParameter = New SqlParameter("@Cuoc_DV", SqlDbType.Int, 0)
                pCuoc_DV.Value = Cuoc_DV
                MyCommand.Parameters.Add(pCuoc_DV)

                Dim pCuoc_Chinh As SqlParameter = New SqlParameter("@Cuoc_Chinh", SqlDbType.Int, 0)
                pCuoc_Chinh.Value = Cuoc_Chinh
                MyCommand.Parameters.Add(pCuoc_Chinh)

                Dim pCuoc_Giam As SqlParameter = New SqlParameter("@Cuoc_Giam", SqlDbType.Int, 0)
                pCuoc_Giam.Value = Cuoc_Giam
                MyCommand.Parameters.Add(pCuoc_Giam)

                Dim pCuoc_E1 As SqlParameter = New SqlParameter("@Cuoc_E1", SqlDbType.Int, 0)
                pCuoc_E1.Value = Cuoc_E1
                MyCommand.Parameters.Add(pCuoc_E1)

                Dim pKien_So As SqlParameter = New SqlParameter("@Kien_So", SqlDbType.Int, 0)
                pKien_So.Value = Kien_So
                MyCommand.Parameters.Add(pKien_So)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Value = STT
                MyCommand.Parameters.Add(pSTT)

                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Value = Ma_KH
                MyCommand.Parameters.Add(pMa_KH)

                Dim pNguoi_Gui As SqlParameter = New SqlParameter("@Nguoi_Gui", SqlDbType.VarChar, 100)
                pNguoi_Gui.Value = Nguoi_Gui
                MyCommand.Parameters.Add(pNguoi_Gui)

                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.VarChar, 100)
                pNguoi_Nhan.Value = Nguoi_Nhan
                MyCommand.Parameters.Add(pNguoi_Nhan)

                Dim pDia_Chi_Gui As SqlParameter = New SqlParameter("@Dia_Chi_Gui", SqlDbType.VarChar, 200)
                pDia_Chi_Gui.Value = Dia_Chi_Gui
                MyCommand.Parameters.Add(pDia_Chi_Gui)

                Dim pDia_Chi_Nhan As SqlParameter = New SqlParameter("@Dia_Chi_Nhan", SqlDbType.VarChar, 200)
                pDia_Chi_Nhan.Value = Dia_Chi_Nhan
                MyCommand.Parameters.Add(pDia_Chi_Nhan)

                Dim pDien_Thoai_Gui As SqlParameter = New SqlParameter("@Dien_Thoai_Gui", SqlDbType.VarChar, 50)
                pDien_Thoai_Gui.Value = Dien_Thoai_Gui
                MyCommand.Parameters.Add(pDien_Thoai_Gui)

                Dim pDien_Thoai_Nhan As SqlParameter = New SqlParameter("@Dien_Thoai_Nhan", SqlDbType.VarChar, 50)
                pDien_Thoai_Nhan.Value = Dien_Thoai_Nhan
                MyCommand.Parameters.Add(pDien_Thoai_Nhan)

                Dim pHH_Phat_Hanh As SqlParameter = New SqlParameter("@HH_Phat_Hanh", SqlDbType.Int, 0)
                pHH_Phat_Hanh.Value = HH_Phat_Hanh
                MyCommand.Parameters.Add(pHH_Phat_Hanh)

                Dim pHH_Phat_Tra As SqlParameter = New SqlParameter("@HH_Phat_Tra", SqlDbType.Int, 0)
                pHH_Phat_Tra.Value = HH_Phat_Tra
                MyCommand.Parameters.Add(pHH_Phat_Tra)

                Dim pMa_Bc_CH As SqlParameter = New SqlParameter("@Ma_Bc_CH", SqlDbType.Int, 0)
                pMa_Bc_CH.Value = Ma_Bc_CH
                MyCommand.Parameters.Add(pMa_Bc_CH)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                MyCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.Int, 0)
                pId_Trang_Thai.Value = Id_Trang_Thai
                MyCommand.Parameters.Add(pId_Trang_Thai)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 200)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 0)
                pTruyen_Khai_Thac.Value = Truyen_Khai_Thac
                MyCommand.Parameters.Add(pTruyen_Khai_Thac)

                Dim pTruyen_Doi_Soat As SqlParameter = New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 0)
                pTruyen_Doi_Soat.Value = Truyen_Doi_Soat
                MyCommand.Parameters.Add(pTruyen_Doi_Soat)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Value = Ngay_He_Thong
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Value = Gio_He_Thong
                MyCommand.Parameters.Add(pGio_He_Thong)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 0)
                pChot_SL.Value = Chot_SL
                MyCommand.Parameters.Add(pChot_SL)

                Dim pMa_E1_E_Shipping As SqlParameter = New SqlParameter("@Ma_E1_E_Shipping", SqlDbType.VarChar, 13)
                pMa_E1_E_Shipping.Value = Ma_E1_E_Shipping
                MyCommand.Parameters.Add(pMa_E1_E_Shipping)

                Dim pId_E1_E_Shipping As SqlParameter = New SqlParameter("@Id_E1_E_Shipping", SqlDbType.VarChar, 48)
                pId_E1_E_Shipping.Value = Id_E1_E_Shipping
                MyCommand.Parameters.Add(pId_E1_E_Shipping)

                Dim pId_E1_Thay_The As SqlParameter = New SqlParameter("@Id_E1_Thay_The", SqlDbType.VarChar, 48)
                pId_E1_Thay_The.Value = Id_E1_Thay_The
                MyCommand.Parameters.Add(pId_E1_Thay_The)


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

#Region "E1_Den_E_Shipping_Cap_Nhat_Them"
        Public Function E1_Den_E_Shipping_Cap_Nhat_Them(ByVal Id_E1 As String, ByVal Id_Duong_Thu As String, ByVal Id_Chuyen_Thu As String, ByVal Id_E2 As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Quay As Integer, ByVal Ma_E1 As String, ByVal Ngay_Phat_Hanh As Integer, ByVal Gio_Phat_Hanh As Integer, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Ma_Don_Vi As String, ByVal Ma_Bc_Goc As Integer, ByVal Ma_Bc_Tra As Integer, ByVal Nuoc_Nhan As String, ByVal Nuoc_Tra As String, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal Loai_Hang_Hoa As Integer, ByVal Khoi_Luong_QD As Integer, ByVal Loai As Integer, ByVal Dv_Cong_Them As String, ByVal Dv_Gia_Tang As String, ByVal PPXD As Double, ByVal Cuoc_PPXD As Integer, ByVal PostCode As String, ByVal Cuoc_PPVX As Integer, ByVal VAT As Double, ByVal COD As Boolean, ByVal Gia_Tri_Hang As Integer, ByVal Cuoc_COD As Integer, ByVal Cuoc_DV As Integer, ByVal Cuoc_Chinh As Integer, ByVal Cuoc_Giam As Integer, ByVal Cuoc_E1 As Integer, ByVal Kien_So As Integer, ByVal STT As Integer, ByVal Ma_KH As String, ByVal Nguoi_Gui As String, ByVal Nguoi_Nhan As String, ByVal Dia_Chi_Gui As String, ByVal Dia_Chi_Nhan As String, ByVal Dien_Thoai_Gui As String, ByVal Dien_Thoai_Nhan As String, ByVal HH_Phat_Hanh As Integer, ByVal HH_Phat_Tra As Integer, ByVal Ma_Bc_CH As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Id_Trang_Thai As Integer, ByVal Ghi_Chu As String, ByVal Truyen_Khai_Thac As Boolean, ByVal Truyen_Doi_Soat As Boolean, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer, ByVal Chot_SL As Boolean, ByVal Ma_E1_E_Shipping As String, ByVal Id_E1_E_Shipping As String, ByVal Id_E1_Thay_The As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Den_E_Shipping_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myE1_Den_E_Shipping_Chi_Tiet As New E1_Den_E_Shipping_Chi_Tiet

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

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                MyCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                MyCommand.Parameters.Add(pId_E2)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                MyCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Quay As SqlParameter = New SqlParameter("@Ma_Quay", SqlDbType.Int, 0)
                pMa_Quay.Value = Ma_Quay
                MyCommand.Parameters.Add(pMa_Quay)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                MyCommand.Parameters.Add(pMa_E1)

                Dim pNgay_Phat_Hanh As SqlParameter = New SqlParameter("@Ngay_Phat_Hanh", SqlDbType.Int, 0)
                pNgay_Phat_Hanh.Value = Ngay_Phat_Hanh
                MyCommand.Parameters.Add(pNgay_Phat_Hanh)

                Dim pGio_Phat_Hanh As SqlParameter = New SqlParameter("@Gio_Phat_Hanh", SqlDbType.Int, 0)
                pGio_Phat_Hanh.Value = Gio_Phat_Hanh
                MyCommand.Parameters.Add(pGio_Phat_Hanh)

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

                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
                pMa_Don_Vi.Value = Ma_Don_Vi
                MyCommand.Parameters.Add(pMa_Don_Vi)

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

                Dim pDv_Cong_Them As SqlParameter = New SqlParameter("@Dv_Cong_Them", SqlDbType.VarChar, 50)
                pDv_Cong_Them.Value = Dv_Cong_Them
                MyCommand.Parameters.Add(pDv_Cong_Them)

                Dim pDv_Gia_Tang As SqlParameter = New SqlParameter("@Dv_Gia_Tang", SqlDbType.VarChar, 50)
                pDv_Gia_Tang.Value = Dv_Gia_Tang
                MyCommand.Parameters.Add(pDv_Gia_Tang)

                Dim pPPXD As SqlParameter = New SqlParameter("@PPXD", SqlDbType.Float, 0)
                pPPXD.Value = PPXD
                MyCommand.Parameters.Add(pPPXD)

                Dim pCuoc_PPXD As SqlParameter = New SqlParameter("@Cuoc_PPXD", SqlDbType.Int, 0)
                pCuoc_PPXD.Value = Cuoc_PPXD
                MyCommand.Parameters.Add(pCuoc_PPXD)

                Dim pPostCode As SqlParameter = New SqlParameter("@PostCode", SqlDbType.VarChar, 50)
                pPostCode.Value = PostCode
                MyCommand.Parameters.Add(pPostCode)

                Dim pCuoc_PPVX As SqlParameter = New SqlParameter("@Cuoc_PPVX", SqlDbType.Int, 0)
                pCuoc_PPVX.Value = Cuoc_PPVX
                MyCommand.Parameters.Add(pCuoc_PPVX)

                Dim pVAT As SqlParameter = New SqlParameter("@VAT", SqlDbType.Float, 0)
                pVAT.Value = VAT
                MyCommand.Parameters.Add(pVAT)

                Dim pCOD As SqlParameter = New SqlParameter("@COD", SqlDbType.Bit, 0)
                pCOD.Value = COD
                MyCommand.Parameters.Add(pCOD)

                Dim pGia_Tri_Hang As SqlParameter = New SqlParameter("@Gia_Tri_Hang", SqlDbType.Int, 0)
                pGia_Tri_Hang.Value = Gia_Tri_Hang
                MyCommand.Parameters.Add(pGia_Tri_Hang)

                Dim pCuoc_COD As SqlParameter = New SqlParameter("@Cuoc_COD", SqlDbType.Int, 0)
                pCuoc_COD.Value = Cuoc_COD
                MyCommand.Parameters.Add(pCuoc_COD)

                Dim pCuoc_DV As SqlParameter = New SqlParameter("@Cuoc_DV", SqlDbType.Int, 0)
                pCuoc_DV.Value = Cuoc_DV
                MyCommand.Parameters.Add(pCuoc_DV)

                Dim pCuoc_Chinh As SqlParameter = New SqlParameter("@Cuoc_Chinh", SqlDbType.Int, 0)
                pCuoc_Chinh.Value = Cuoc_Chinh
                MyCommand.Parameters.Add(pCuoc_Chinh)

                Dim pCuoc_Giam As SqlParameter = New SqlParameter("@Cuoc_Giam", SqlDbType.Int, 0)
                pCuoc_Giam.Value = Cuoc_Giam
                MyCommand.Parameters.Add(pCuoc_Giam)

                Dim pCuoc_E1 As SqlParameter = New SqlParameter("@Cuoc_E1", SqlDbType.Int, 0)
                pCuoc_E1.Value = Cuoc_E1
                MyCommand.Parameters.Add(pCuoc_E1)

                Dim pKien_So As SqlParameter = New SqlParameter("@Kien_So", SqlDbType.Int, 0)
                pKien_So.Value = Kien_So
                MyCommand.Parameters.Add(pKien_So)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Value = STT
                MyCommand.Parameters.Add(pSTT)

                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Value = Ma_KH
                MyCommand.Parameters.Add(pMa_KH)

                Dim pNguoi_Gui As SqlParameter = New SqlParameter("@Nguoi_Gui", SqlDbType.VarChar, 100)
                pNguoi_Gui.Value = Nguoi_Gui
                MyCommand.Parameters.Add(pNguoi_Gui)

                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.VarChar, 100)
                pNguoi_Nhan.Value = Nguoi_Nhan
                MyCommand.Parameters.Add(pNguoi_Nhan)

                Dim pDia_Chi_Gui As SqlParameter = New SqlParameter("@Dia_Chi_Gui", SqlDbType.VarChar, 200)
                pDia_Chi_Gui.Value = Dia_Chi_Gui
                MyCommand.Parameters.Add(pDia_Chi_Gui)

                Dim pDia_Chi_Nhan As SqlParameter = New SqlParameter("@Dia_Chi_Nhan", SqlDbType.VarChar, 200)
                pDia_Chi_Nhan.Value = Dia_Chi_Nhan
                MyCommand.Parameters.Add(pDia_Chi_Nhan)

                Dim pDien_Thoai_Gui As SqlParameter = New SqlParameter("@Dien_Thoai_Gui", SqlDbType.VarChar, 50)
                pDien_Thoai_Gui.Value = Dien_Thoai_Gui
                MyCommand.Parameters.Add(pDien_Thoai_Gui)

                Dim pDien_Thoai_Nhan As SqlParameter = New SqlParameter("@Dien_Thoai_Nhan", SqlDbType.VarChar, 50)
                pDien_Thoai_Nhan.Value = Dien_Thoai_Nhan
                MyCommand.Parameters.Add(pDien_Thoai_Nhan)

                Dim pHH_Phat_Hanh As SqlParameter = New SqlParameter("@HH_Phat_Hanh", SqlDbType.Int, 0)
                pHH_Phat_Hanh.Value = HH_Phat_Hanh
                MyCommand.Parameters.Add(pHH_Phat_Hanh)

                Dim pHH_Phat_Tra As SqlParameter = New SqlParameter("@HH_Phat_Tra", SqlDbType.Int, 0)
                pHH_Phat_Tra.Value = HH_Phat_Tra
                MyCommand.Parameters.Add(pHH_Phat_Tra)

                Dim pMa_Bc_CH As SqlParameter = New SqlParameter("@Ma_Bc_CH", SqlDbType.Int, 0)
                pMa_Bc_CH.Value = Ma_Bc_CH
                MyCommand.Parameters.Add(pMa_Bc_CH)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                MyCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.Int, 0)
                pId_Trang_Thai.Value = Id_Trang_Thai
                MyCommand.Parameters.Add(pId_Trang_Thai)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 200)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 0)
                pTruyen_Khai_Thac.Value = Truyen_Khai_Thac
                MyCommand.Parameters.Add(pTruyen_Khai_Thac)

                Dim pTruyen_Doi_Soat As SqlParameter = New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 0)
                pTruyen_Doi_Soat.Value = Truyen_Doi_Soat
                MyCommand.Parameters.Add(pTruyen_Doi_Soat)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Value = Ngay_He_Thong
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Value = Gio_He_Thong
                MyCommand.Parameters.Add(pGio_He_Thong)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 0)
                pChot_SL.Value = Chot_SL
                MyCommand.Parameters.Add(pChot_SL)

                Dim pMa_E1_E_Shipping As SqlParameter = New SqlParameter("@Ma_E1_E_Shipping", SqlDbType.VarChar, 13)
                pMa_E1_E_Shipping.Value = Ma_E1_E_Shipping
                MyCommand.Parameters.Add(pMa_E1_E_Shipping)

                Dim pId_E1_E_Shipping As SqlParameter = New SqlParameter("@Id_E1_E_Shipping", SqlDbType.VarChar, 48)
                pId_E1_E_Shipping.Value = Id_E1_E_Shipping
                MyCommand.Parameters.Add(pId_E1_E_Shipping)

                Dim pId_E1_Thay_The As SqlParameter = New SqlParameter("@Id_E1_Thay_The", SqlDbType.VarChar, 48)
                pId_E1_Thay_The.Value = Id_E1_Thay_The
                MyCommand.Parameters.Add(pId_E1_Thay_The)


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

#Region "E1_Den_E_Shipping_Bao_Cao_Gui_Call_Center_Tu_Ngay_Den_Ngay"

        Public Function E1_Den_E_Shipping_Bao_Cao_Gui_Call_Center_Tu_Ngay_Den_Ngay(ByVal Ma_Bc_Khai_Thac As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ma_CP1
            ' Ma_Bc_Tra
            ' Khoi_Luong
            ' Phan_Loai
            ' Nguoi_Nhan
            ' Dia_Chi_Nhan
            ' Dien_Thoai_Nhan
            ' Ghi_Chu
            ' Ma_E1
            ' Ngay_Khai_Thac


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Den_E_Shipping_Bao_Cao_Gui_Call_Center_Tu_Ngay_Den_Ngay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

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

#Region "E1_Den_E_Shipping_Danh_Sach"

        Public Function E1_Den_E_Shipping_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Id_E1
            ' Id_Duong_Thu
            ' Id_Chuyen_Thu
            ' Id_E2
            ' Id_Ca
            ' Ma_Bc_Khai_Thac
            ' Ma_Quay
            ' Ma_E1
            ' Ngay_Phat_Hanh
            ' Gio_Phat_Hanh
            ' Ngay_Dong
            ' Gio_Dong
            ' Ngay_Nhan
            ' Gio_Nhan
            ' Ma_Don_Vi
            ' Ma_Bc_Goc
            ' Ma_Bc_Tra
            ' Nuoc_Nhan
            ' Nuoc_Tra
            ' Khoi_Luong
            ' Phan_Loai
            ' Loai_Hang_Hoa
            ' Khoi_Luong_QD
            ' Loai
            ' Dv_Cong_Them
            ' Dv_Gia_Tang
            ' PPXD
            ' Cuoc_PPXD
            ' PostCode
            ' Cuoc_PPVX
            ' VAT
            ' COD
            ' Gia_Tri_Hang
            ' Cuoc_COD
            ' Cuoc_DV
            ' Cuoc_Chinh
            ' Cuoc_Giam
            ' Cuoc_E1
            ' Kien_So
            ' STT
            ' Ma_KH
            ' Nguoi_Gui
            ' Nguoi_Nhan
            ' Dia_Chi_Gui
            ' Dia_Chi_Nhan
            ' Dien_Thoai_Gui
            ' Dien_Thoai_Nhan
            ' HH_Phat_Hanh
            ' HH_Phat_Tra
            ' Ma_Bc_CH
            ' Id_Nguoi_Dung
            ' Id_Trang_Thai
            ' Ghi_Chu
            ' Truyen_Khai_Thac
            ' Truyen_Doi_Soat
            ' Ngay_He_Thong
            ' Gio_He_Thong
            ' Chot_SL
            ' Ma_E1_E_Shipping
            ' Id_E1_E_Shipping
            ' Id_E1_Thay_The


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Den_E_Shipping_Danh_Sach"
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

#Region "E1_Den_E_Shipping_Lay"
        Public Function E1_Den_E_Shipping_Lay(ByVal Id_E1 As String) As E1_Den_E_Shipping_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Den_E_Shipping_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myE1_Den_E_Shipping_Chi_Tiet As New E1_Den_E_Shipping_Chi_Tiet

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

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_E2)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Quay As SqlParameter = New SqlParameter("@Ma_Quay", SqlDbType.Int, 0)
                pMa_Quay.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Quay)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_E1)

                Dim pNgay_Phat_Hanh As SqlParameter = New SqlParameter("@Ngay_Phat_Hanh", SqlDbType.Int, 0)
                pNgay_Phat_Hanh.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Phat_Hanh)

                Dim pGio_Phat_Hanh As SqlParameter = New SqlParameter("@Gio_Phat_Hanh", SqlDbType.Int, 0)
                pGio_Phat_Hanh.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Phat_Hanh)

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

                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
                pMa_Don_Vi.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Don_Vi)

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

                Dim pDv_Cong_Them As SqlParameter = New SqlParameter("@Dv_Cong_Them", SqlDbType.VarChar, 50)
                pDv_Cong_Them.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDv_Cong_Them)

                Dim pDv_Gia_Tang As SqlParameter = New SqlParameter("@Dv_Gia_Tang", SqlDbType.VarChar, 50)
                pDv_Gia_Tang.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDv_Gia_Tang)

                Dim pPPXD As SqlParameter = New SqlParameter("@PPXD", SqlDbType.Float, 0)
                pPPXD.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPPXD)

                Dim pCuoc_PPXD As SqlParameter = New SqlParameter("@Cuoc_PPXD", SqlDbType.Int, 0)
                pCuoc_PPXD.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCuoc_PPXD)

                Dim pPostCode As SqlParameter = New SqlParameter("@PostCode", SqlDbType.VarChar, 50)
                pPostCode.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPostCode)

                Dim pCuoc_PPVX As SqlParameter = New SqlParameter("@Cuoc_PPVX", SqlDbType.Int, 0)
                pCuoc_PPVX.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCuoc_PPVX)

                Dim pVAT As SqlParameter = New SqlParameter("@VAT", SqlDbType.Float, 0)
                pVAT.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pVAT)

                Dim pCOD As SqlParameter = New SqlParameter("@COD", SqlDbType.Bit, 0)
                pCOD.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCOD)

                Dim pGia_Tri_Hang As SqlParameter = New SqlParameter("@Gia_Tri_Hang", SqlDbType.Int, 0)
                pGia_Tri_Hang.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGia_Tri_Hang)

                Dim pCuoc_COD As SqlParameter = New SqlParameter("@Cuoc_COD", SqlDbType.Int, 0)
                pCuoc_COD.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCuoc_COD)

                Dim pCuoc_DV As SqlParameter = New SqlParameter("@Cuoc_DV", SqlDbType.Int, 0)
                pCuoc_DV.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCuoc_DV)

                Dim pCuoc_Chinh As SqlParameter = New SqlParameter("@Cuoc_Chinh", SqlDbType.Int, 0)
                pCuoc_Chinh.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCuoc_Chinh)

                Dim pCuoc_Giam As SqlParameter = New SqlParameter("@Cuoc_Giam", SqlDbType.Int, 0)
                pCuoc_Giam.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCuoc_Giam)

                Dim pCuoc_E1 As SqlParameter = New SqlParameter("@Cuoc_E1", SqlDbType.Int, 0)
                pCuoc_E1.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCuoc_E1)

                Dim pKien_So As SqlParameter = New SqlParameter("@Kien_So", SqlDbType.Int, 0)
                pKien_So.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pKien_So)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSTT)

                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_KH)

                Dim pNguoi_Gui As SqlParameter = New SqlParameter("@Nguoi_Gui", SqlDbType.VarChar, 100)
                pNguoi_Gui.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNguoi_Gui)

                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.VarChar, 100)
                pNguoi_Nhan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNguoi_Nhan)

                Dim pDia_Chi_Gui As SqlParameter = New SqlParameter("@Dia_Chi_Gui", SqlDbType.VarChar, 200)
                pDia_Chi_Gui.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDia_Chi_Gui)

                Dim pDia_Chi_Nhan As SqlParameter = New SqlParameter("@Dia_Chi_Nhan", SqlDbType.VarChar, 200)
                pDia_Chi_Nhan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDia_Chi_Nhan)

                Dim pDien_Thoai_Gui As SqlParameter = New SqlParameter("@Dien_Thoai_Gui", SqlDbType.VarChar, 50)
                pDien_Thoai_Gui.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDien_Thoai_Gui)

                Dim pDien_Thoai_Nhan As SqlParameter = New SqlParameter("@Dien_Thoai_Nhan", SqlDbType.VarChar, 50)
                pDien_Thoai_Nhan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDien_Thoai_Nhan)

                Dim pHH_Phat_Hanh As SqlParameter = New SqlParameter("@HH_Phat_Hanh", SqlDbType.Int, 0)
                pHH_Phat_Hanh.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pHH_Phat_Hanh)

                Dim pHH_Phat_Tra As SqlParameter = New SqlParameter("@HH_Phat_Tra", SqlDbType.Int, 0)
                pHH_Phat_Tra.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pHH_Phat_Tra)

                Dim pMa_Bc_CH As SqlParameter = New SqlParameter("@Ma_Bc_CH", SqlDbType.Int, 0)
                pMa_Bc_CH.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc_CH)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0)
                pId_Nguoi_Dung.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.Int, 0)
                pId_Trang_Thai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Trang_Thai)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 200)
                pGhi_Chu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 0)
                pTruyen_Khai_Thac.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTruyen_Khai_Thac)

                Dim pTruyen_Doi_Soat As SqlParameter = New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 0)
                pTruyen_Doi_Soat.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTruyen_Doi_Soat)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_He_Thong)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 0)
                pChot_SL.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pChot_SL)

                Dim pMa_E1_E_Shipping As SqlParameter = New SqlParameter("@Ma_E1_E_Shipping", SqlDbType.VarChar, 13)
                pMa_E1_E_Shipping.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_E1_E_Shipping)

                Dim pId_E1_E_Shipping As SqlParameter = New SqlParameter("@Id_E1_E_Shipping", SqlDbType.VarChar, 48)
                pId_E1_E_Shipping.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_E1_E_Shipping)

                Dim pId_E1_Thay_The As SqlParameter = New SqlParameter("@Id_E1_Thay_The", SqlDbType.VarChar, 48)
                pId_E1_Thay_The.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_E1_Thay_The)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myE1_Den_E_Shipping_Chi_Tiet.Id_E1 = Id_E1
                myE1_Den_E_Shipping_Chi_Tiet.Id_Duong_Thu = pId_Duong_Thu.Value
                myE1_Den_E_Shipping_Chi_Tiet.Id_Chuyen_Thu = pId_Chuyen_Thu.Value
                myE1_Den_E_Shipping_Chi_Tiet.Id_E2 = pId_E2.Value
                myE1_Den_E_Shipping_Chi_Tiet.Id_Ca = pId_Ca.Value
                myE1_Den_E_Shipping_Chi_Tiet.Ma_Bc_Khai_Thac = pMa_Bc_Khai_Thac.Value
                myE1_Den_E_Shipping_Chi_Tiet.Ma_Quay = pMa_Quay.Value
                myE1_Den_E_Shipping_Chi_Tiet.Ma_E1 = pMa_E1.Value
                myE1_Den_E_Shipping_Chi_Tiet.Ngay_Phat_Hanh = pNgay_Phat_Hanh.Value
                myE1_Den_E_Shipping_Chi_Tiet.Gio_Phat_Hanh = pGio_Phat_Hanh.Value
                myE1_Den_E_Shipping_Chi_Tiet.Ngay_Dong = pNgay_Dong.Value
                myE1_Den_E_Shipping_Chi_Tiet.Gio_Dong = pGio_Dong.Value
                myE1_Den_E_Shipping_Chi_Tiet.Ngay_Nhan = pNgay_Nhan.Value
                myE1_Den_E_Shipping_Chi_Tiet.Gio_Nhan = pGio_Nhan.Value
                myE1_Den_E_Shipping_Chi_Tiet.Ma_Don_Vi = pMa_Don_Vi.Value
                myE1_Den_E_Shipping_Chi_Tiet.Ma_Bc_Goc = pMa_Bc_Goc.Value
                myE1_Den_E_Shipping_Chi_Tiet.Ma_Bc_Tra = pMa_Bc_Tra.Value
                myE1_Den_E_Shipping_Chi_Tiet.Nuoc_Nhan = pNuoc_Nhan.Value
                myE1_Den_E_Shipping_Chi_Tiet.Nuoc_Tra = pNuoc_Tra.Value
                myE1_Den_E_Shipping_Chi_Tiet.Khoi_Luong = pKhoi_Luong.Value
                myE1_Den_E_Shipping_Chi_Tiet.Phan_Loai = pPhan_Loai.Value
                myE1_Den_E_Shipping_Chi_Tiet.Loai_Hang_Hoa = pLoai_Hang_Hoa.Value
                myE1_Den_E_Shipping_Chi_Tiet.Khoi_Luong_QD = pKhoi_Luong_QD.Value
                myE1_Den_E_Shipping_Chi_Tiet.Loai = pLoai.Value
                myE1_Den_E_Shipping_Chi_Tiet.Dv_Cong_Them = pDv_Cong_Them.Value
                myE1_Den_E_Shipping_Chi_Tiet.Dv_Gia_Tang = pDv_Gia_Tang.Value
                myE1_Den_E_Shipping_Chi_Tiet.PPXD = pPPXD.Value
                myE1_Den_E_Shipping_Chi_Tiet.Cuoc_PPXD = pCuoc_PPXD.Value
                myE1_Den_E_Shipping_Chi_Tiet.PostCode = pPostCode.Value
                myE1_Den_E_Shipping_Chi_Tiet.Cuoc_PPVX = pCuoc_PPVX.Value
                myE1_Den_E_Shipping_Chi_Tiet.VAT = pVAT.Value
                myE1_Den_E_Shipping_Chi_Tiet.COD = pCOD.Value
                myE1_Den_E_Shipping_Chi_Tiet.Gia_Tri_Hang = pGia_Tri_Hang.Value
                myE1_Den_E_Shipping_Chi_Tiet.Cuoc_COD = pCuoc_COD.Value
                myE1_Den_E_Shipping_Chi_Tiet.Cuoc_DV = pCuoc_DV.Value
                myE1_Den_E_Shipping_Chi_Tiet.Cuoc_Chinh = pCuoc_Chinh.Value
                myE1_Den_E_Shipping_Chi_Tiet.Cuoc_Giam = pCuoc_Giam.Value
                myE1_Den_E_Shipping_Chi_Tiet.Cuoc_E1 = pCuoc_E1.Value
                myE1_Den_E_Shipping_Chi_Tiet.Kien_So = pKien_So.Value
                myE1_Den_E_Shipping_Chi_Tiet.STT = pSTT.Value
                myE1_Den_E_Shipping_Chi_Tiet.Ma_KH = pMa_KH.Value
                myE1_Den_E_Shipping_Chi_Tiet.Nguoi_Gui = pNguoi_Gui.Value
                myE1_Den_E_Shipping_Chi_Tiet.Nguoi_Nhan = pNguoi_Nhan.Value
                myE1_Den_E_Shipping_Chi_Tiet.Dia_Chi_Gui = pDia_Chi_Gui.Value
                myE1_Den_E_Shipping_Chi_Tiet.Dia_Chi_Nhan = pDia_Chi_Nhan.Value
                myE1_Den_E_Shipping_Chi_Tiet.Dien_Thoai_Gui = pDien_Thoai_Gui.Value
                myE1_Den_E_Shipping_Chi_Tiet.Dien_Thoai_Nhan = pDien_Thoai_Nhan.Value
                myE1_Den_E_Shipping_Chi_Tiet.HH_Phat_Hanh = pHH_Phat_Hanh.Value
                myE1_Den_E_Shipping_Chi_Tiet.HH_Phat_Tra = pHH_Phat_Tra.Value
                myE1_Den_E_Shipping_Chi_Tiet.Ma_Bc_CH = pMa_Bc_CH.Value
                myE1_Den_E_Shipping_Chi_Tiet.Id_Nguoi_Dung = pId_Nguoi_Dung.Value
                myE1_Den_E_Shipping_Chi_Tiet.Id_Trang_Thai = pId_Trang_Thai.Value
                myE1_Den_E_Shipping_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value
                myE1_Den_E_Shipping_Chi_Tiet.Truyen_Khai_Thac = pTruyen_Khai_Thac.Value
                myE1_Den_E_Shipping_Chi_Tiet.Truyen_Doi_Soat = pTruyen_Doi_Soat.Value
                myE1_Den_E_Shipping_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myE1_Den_E_Shipping_Chi_Tiet.Gio_He_Thong = pGio_He_Thong.Value
                myE1_Den_E_Shipping_Chi_Tiet.Chot_SL = pChot_SL.Value
                myE1_Den_E_Shipping_Chi_Tiet.Ma_E1_E_Shipping = pMa_E1_E_Shipping.Value
                myE1_Den_E_Shipping_Chi_Tiet.Id_E1_E_Shipping = pId_E1_E_Shipping.Value
                myE1_Den_E_Shipping_Chi_Tiet.Id_E1_Thay_The = pId_E1_Thay_The.Value

                Return myE1_Den_E_Shipping_Chi_Tiet
                'Return myE1_Den_E_Shipping_Chi_Tiet

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

#Region "E1_Den_E_Shipping_Them"
        Public Function E1_Den_E_Shipping_Them(ByVal Id_E1 As String, ByVal Id_Duong_Thu As String, ByVal Id_Chuyen_Thu As String, ByVal Id_E2 As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Quay As Integer, ByVal Ma_E1 As String, ByVal Ngay_Phat_Hanh As Integer, ByVal Gio_Phat_Hanh As Integer, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Ma_Don_Vi As String, ByVal Ma_Bc_Goc As Integer, ByVal Ma_Bc_Tra As Integer, ByVal Nuoc_Nhan As String, ByVal Nuoc_Tra As String, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal Loai_Hang_Hoa As Integer, ByVal Khoi_Luong_QD As Integer, ByVal Loai As Integer, ByVal Dv_Cong_Them As String, ByVal Dv_Gia_Tang As String, ByVal PPXD As Double, ByVal Cuoc_PPXD As Integer, ByVal PostCode As String, ByVal Cuoc_PPVX As Integer, ByVal VAT As Double, ByVal COD As Boolean, ByVal Gia_Tri_Hang As Integer, ByVal Cuoc_COD As Integer, ByVal Cuoc_DV As Integer, ByVal Cuoc_Chinh As Integer, ByVal Cuoc_Giam As Integer, ByVal Cuoc_E1 As Integer, ByVal Kien_So As Integer, ByVal STT As Integer, ByVal Ma_KH As String, ByVal Nguoi_Gui As String, ByVal Nguoi_Nhan As String, ByVal Dia_Chi_Gui As String, ByVal Dia_Chi_Nhan As String, ByVal Dien_Thoai_Gui As String, ByVal Dien_Thoai_Nhan As String, ByVal HH_Phat_Hanh As Integer, ByVal HH_Phat_Tra As Integer, ByVal Ma_Bc_CH As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Id_Trang_Thai As Integer, ByVal Ghi_Chu As String, ByVal Truyen_Khai_Thac As Boolean, ByVal Truyen_Doi_Soat As Boolean, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer, ByVal Chot_SL As Boolean, ByVal Ma_E1_E_Shipping As String, ByVal Id_E1_E_Shipping As String, ByVal Id_E1_Thay_The As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Den_E_Shipping_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myE1_Den_E_Shipping_Chi_Tiet As New E1_Den_E_Shipping_Chi_Tiet

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

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                MyCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                MyCommand.Parameters.Add(pId_E2)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                MyCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Quay As SqlParameter = New SqlParameter("@Ma_Quay", SqlDbType.Int, 0)
                pMa_Quay.Value = Ma_Quay
                MyCommand.Parameters.Add(pMa_Quay)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                MyCommand.Parameters.Add(pMa_E1)

                Dim pNgay_Phat_Hanh As SqlParameter = New SqlParameter("@Ngay_Phat_Hanh", SqlDbType.Int, 0)
                pNgay_Phat_Hanh.Value = Ngay_Phat_Hanh
                MyCommand.Parameters.Add(pNgay_Phat_Hanh)

                Dim pGio_Phat_Hanh As SqlParameter = New SqlParameter("@Gio_Phat_Hanh", SqlDbType.Int, 0)
                pGio_Phat_Hanh.Value = Gio_Phat_Hanh
                MyCommand.Parameters.Add(pGio_Phat_Hanh)

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

                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
                pMa_Don_Vi.Value = Ma_Don_Vi
                MyCommand.Parameters.Add(pMa_Don_Vi)

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

                Dim pDv_Cong_Them As SqlParameter = New SqlParameter("@Dv_Cong_Them", SqlDbType.VarChar, 50)
                pDv_Cong_Them.Value = Dv_Cong_Them
                MyCommand.Parameters.Add(pDv_Cong_Them)

                Dim pDv_Gia_Tang As SqlParameter = New SqlParameter("@Dv_Gia_Tang", SqlDbType.VarChar, 50)
                pDv_Gia_Tang.Value = Dv_Gia_Tang
                MyCommand.Parameters.Add(pDv_Gia_Tang)

                Dim pPPXD As SqlParameter = New SqlParameter("@PPXD", SqlDbType.Float, 0)
                pPPXD.Value = PPXD
                MyCommand.Parameters.Add(pPPXD)

                Dim pCuoc_PPXD As SqlParameter = New SqlParameter("@Cuoc_PPXD", SqlDbType.Int, 0)
                pCuoc_PPXD.Value = Cuoc_PPXD
                MyCommand.Parameters.Add(pCuoc_PPXD)

                Dim pPostCode As SqlParameter = New SqlParameter("@PostCode", SqlDbType.VarChar, 50)
                pPostCode.Value = PostCode
                MyCommand.Parameters.Add(pPostCode)

                Dim pCuoc_PPVX As SqlParameter = New SqlParameter("@Cuoc_PPVX", SqlDbType.Int, 0)
                pCuoc_PPVX.Value = Cuoc_PPVX
                MyCommand.Parameters.Add(pCuoc_PPVX)

                Dim pVAT As SqlParameter = New SqlParameter("@VAT", SqlDbType.Float, 0)
                pVAT.Value = VAT
                MyCommand.Parameters.Add(pVAT)

                Dim pCOD As SqlParameter = New SqlParameter("@COD", SqlDbType.Bit, 0)
                pCOD.Value = COD
                MyCommand.Parameters.Add(pCOD)

                Dim pGia_Tri_Hang As SqlParameter = New SqlParameter("@Gia_Tri_Hang", SqlDbType.Int, 0)
                pGia_Tri_Hang.Value = Gia_Tri_Hang
                MyCommand.Parameters.Add(pGia_Tri_Hang)

                Dim pCuoc_COD As SqlParameter = New SqlParameter("@Cuoc_COD", SqlDbType.Int, 0)
                pCuoc_COD.Value = Cuoc_COD
                MyCommand.Parameters.Add(pCuoc_COD)

                Dim pCuoc_DV As SqlParameter = New SqlParameter("@Cuoc_DV", SqlDbType.Int, 0)
                pCuoc_DV.Value = Cuoc_DV
                MyCommand.Parameters.Add(pCuoc_DV)

                Dim pCuoc_Chinh As SqlParameter = New SqlParameter("@Cuoc_Chinh", SqlDbType.Int, 0)
                pCuoc_Chinh.Value = Cuoc_Chinh
                MyCommand.Parameters.Add(pCuoc_Chinh)

                Dim pCuoc_Giam As SqlParameter = New SqlParameter("@Cuoc_Giam", SqlDbType.Int, 0)
                pCuoc_Giam.Value = Cuoc_Giam
                MyCommand.Parameters.Add(pCuoc_Giam)

                Dim pCuoc_E1 As SqlParameter = New SqlParameter("@Cuoc_E1", SqlDbType.Int, 0)
                pCuoc_E1.Value = Cuoc_E1
                MyCommand.Parameters.Add(pCuoc_E1)

                Dim pKien_So As SqlParameter = New SqlParameter("@Kien_So", SqlDbType.Int, 0)
                pKien_So.Value = Kien_So
                MyCommand.Parameters.Add(pKien_So)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Value = STT
                MyCommand.Parameters.Add(pSTT)

                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Value = Ma_KH
                MyCommand.Parameters.Add(pMa_KH)

                Dim pNguoi_Gui As SqlParameter = New SqlParameter("@Nguoi_Gui", SqlDbType.VarChar, 100)
                pNguoi_Gui.Value = Nguoi_Gui
                MyCommand.Parameters.Add(pNguoi_Gui)

                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.VarChar, 100)
                pNguoi_Nhan.Value = Nguoi_Nhan
                MyCommand.Parameters.Add(pNguoi_Nhan)

                Dim pDia_Chi_Gui As SqlParameter = New SqlParameter("@Dia_Chi_Gui", SqlDbType.VarChar, 200)
                pDia_Chi_Gui.Value = Dia_Chi_Gui
                MyCommand.Parameters.Add(pDia_Chi_Gui)

                Dim pDia_Chi_Nhan As SqlParameter = New SqlParameter("@Dia_Chi_Nhan", SqlDbType.VarChar, 200)
                pDia_Chi_Nhan.Value = Dia_Chi_Nhan
                MyCommand.Parameters.Add(pDia_Chi_Nhan)

                Dim pDien_Thoai_Gui As SqlParameter = New SqlParameter("@Dien_Thoai_Gui", SqlDbType.VarChar, 50)
                pDien_Thoai_Gui.Value = Dien_Thoai_Gui
                MyCommand.Parameters.Add(pDien_Thoai_Gui)

                Dim pDien_Thoai_Nhan As SqlParameter = New SqlParameter("@Dien_Thoai_Nhan", SqlDbType.VarChar, 50)
                pDien_Thoai_Nhan.Value = Dien_Thoai_Nhan
                MyCommand.Parameters.Add(pDien_Thoai_Nhan)

                Dim pHH_Phat_Hanh As SqlParameter = New SqlParameter("@HH_Phat_Hanh", SqlDbType.Int, 0)
                pHH_Phat_Hanh.Value = HH_Phat_Hanh
                MyCommand.Parameters.Add(pHH_Phat_Hanh)

                Dim pHH_Phat_Tra As SqlParameter = New SqlParameter("@HH_Phat_Tra", SqlDbType.Int, 0)
                pHH_Phat_Tra.Value = HH_Phat_Tra
                MyCommand.Parameters.Add(pHH_Phat_Tra)

                Dim pMa_Bc_CH As SqlParameter = New SqlParameter("@Ma_Bc_CH", SqlDbType.Int, 0)
                pMa_Bc_CH.Value = Ma_Bc_CH
                MyCommand.Parameters.Add(pMa_Bc_CH)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                MyCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.Int, 0)
                pId_Trang_Thai.Value = Id_Trang_Thai
                MyCommand.Parameters.Add(pId_Trang_Thai)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 200)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 0)
                pTruyen_Khai_Thac.Value = Truyen_Khai_Thac
                MyCommand.Parameters.Add(pTruyen_Khai_Thac)

                Dim pTruyen_Doi_Soat As SqlParameter = New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 0)
                pTruyen_Doi_Soat.Value = Truyen_Doi_Soat
                MyCommand.Parameters.Add(pTruyen_Doi_Soat)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Value = Ngay_He_Thong
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Value = Gio_He_Thong
                MyCommand.Parameters.Add(pGio_He_Thong)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 0)
                pChot_SL.Value = Chot_SL
                MyCommand.Parameters.Add(pChot_SL)

                Dim pMa_E1_E_Shipping As SqlParameter = New SqlParameter("@Ma_E1_E_Shipping", SqlDbType.VarChar, 13)
                pMa_E1_E_Shipping.Value = Ma_E1_E_Shipping
                MyCommand.Parameters.Add(pMa_E1_E_Shipping)

                Dim pId_E1_E_Shipping As SqlParameter = New SqlParameter("@Id_E1_E_Shipping", SqlDbType.VarChar, 48)
                pId_E1_E_Shipping.Value = Id_E1_E_Shipping
                MyCommand.Parameters.Add(pId_E1_E_Shipping)

                Dim pId_E1_Thay_The As SqlParameter = New SqlParameter("@Id_E1_Thay_The", SqlDbType.VarChar, 48)
                pId_E1_Thay_The.Value = Id_E1_Thay_The
                MyCommand.Parameters.Add(pId_E1_Thay_The)


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

#Region "E1_Den_E_Shipping_Xoa"
        Public Function E1_Den_E_Shipping_Xoa(ByVal Id_E1 As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Den_E_Shipping_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myE1_Den_E_Shipping_Chi_Tiet As New E1_Den_E_Shipping_Chi_Tiet

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


    End Class
#End Region
End Namespace


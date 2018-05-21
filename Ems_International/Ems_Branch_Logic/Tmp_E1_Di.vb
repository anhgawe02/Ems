
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Math
Namespace EMS
#Region "Tmp_E1_Di_Chi_Tiet"
    '*******************************************************
    ' M?i thu?c tính c?a l?p E1_Di_Chi_Tiet
    ' tuong ?ng v?i m? tru?ng c?a b?ng E1_Di trong co s? d? li?u
    '
    '*******************************************************
    Public Class Tmp_E1_Di_Chi_Tiet
        Public Id_E1 As String ' SSSSSSRRRRRRDDDDBBBYYYYMMDDHHMMEEXXXXXXXXXVNQQQQ
        Public Id_Duong_Thu As String ' Ðu?ng thu dóng di
        Public Id_Chuyen_Thu As String ' Id chuy?n thu dóng di
        Public Id_E2 As String ' Id E2 dóng di
        Public Id_Ca As String ' Ca s?n xu?t
        Public Ma_Bc_Khai_Thac As Integer ' Mã buu c?c khai thác BP
        Public Ma_Quay As Integer ' Mã qu?y giao d?ch
        Public Ma_E1 As String
        Public Ngay_Phat_Hanh As Integer ' Ngày ch?p nh?n BP
        Public Gio_Phat_Hanh As Integer ' Gi? ch?p nh?p BP
        Public Ngay_Dong As Integer ' Ngày dóng BP
        Public Gio_Dong As Integer ' Gi? dóng BP
        Public Ngay_Nhan As Integer
        Public Gio_Nhan As Integer
        Public Ma_Don_Vi As String ' Mã d?ch v?
        Public Ma_Bc_Goc As Integer ' Mã buu c?c ch?p nh?n buu ph?m (có th? là mã d?u t?nh)
        Public Ma_Bc_Tra As Integer ' Mã buu c?c phát tr? buu ph?m (Có th? là mã d?u t?nh)
        Public Nuoc_Nhan As String ' Nu?c ch?p nh?n buu ph?m
        Public Nuoc_Tra As String ' Nu?c phát tr? BP
        Public Khoi_Luong As Integer
        Public Phan_Loai As String ' Phân lo?i buu ph?m (D,M)
        Public Loai_Hang_Hoa As Integer ' 0:Hàng bình thu?ng,1: hàng nh?,2: hàng c?ng k?nh
        Public Khoi_Luong_QD As Integer ' Kh?i lu?ng quy d?i c?a BP: s? d?ng trong tru?ng h?p là hàng nh?
        Public Loai As Integer
        Public Dv_Cong_Them As String ' Li?t kê các d?ch v? c?ng thêm du?c s? dung, ngan cách b?i d?u ','
        Public Dv_Gia_Tang As String ' Li?t kê các d?ch v? gia tang du?c s? dung, ngan cách b?i d?u ','
        Public PPXD As Double ' Ph? phí xang d?u (%)
        Public Cuoc_PPXD As Integer ' Cu?c ph? phí xang d?u
        Public PostCode As String ' Mã vùng c?a noi phát tr? BP d?i v?i BP di qu?c t? (Tính cu?c Vùng xa)
        Public Cuoc_PPVX As Integer ' Cu?c ph? phí vùng xa
        Public VAT As Double ' Thu? VAT
        Public COD As Boolean ' D?ch v? COD
        Public Gia_Tri_Hang As Integer ' Giá tr? hàng hóa du?c khai (Tính cu?c COD, cu?c khai giá)
        Public Cuoc_COD As Integer ' Cu?c d?ch v? COD
        Public Cuoc_DV As Integer ' Cu?c d?ch v?= Cu?c d?ch v? c?ng thêm + Cu?c d?ch v? gia tang
        Public Cuoc_Chinh As Integer ' Cu?c chính= Cu?c co s? + cu?c ph? phí xang d?u + Cu?c ph? phí vùng xa
        Public Cuoc_Giam As Integer ' Giá tr? cu?c du?c gi?m do các chính sách gi?m giá, khuy?n m?i
        Public Cuoc_E1 As Integer ' Cu?c ghi trên E1
        Public Kien_So As Integer ' Ki?n s? (S? d?ng cho Hàng 1 V?n don)
        Public STT As Integer ' S? th? t? trong b?n kê E2
        Public Ma_KH As String
        Public Nguoi_Gui As String
        Public Nguoi_Nhan As String
        Public Dia_Chi_Gui As String
        Public Dia_Chi_Nhan As String
        Public Dien_Thoai_Gui As String
        Public Dien_Thoai_Nhan As String
        Public HH_Phat_Hanh As Integer ' Hoa h?ng d?i lý ph?n công ch?p nh?n BP
        Public HH_Phat_Tra As Integer ' Hoa h?ng d?i lý ph?n công phát tr? BP
        Public Ma_Bc_CH As Integer ' Mã buu c?c, noi chuy?n hoàn v? buu c?c g?c
        Public Id_Nguoi_Dung As Integer
        Public Id_Trang_Thai As Integer
        Public Ghi_Chu As String
        Public Truyen_Khai_Thac As Boolean ' Truy?n d? li?u khai thác
        Public Truyen_Doi_Soat As Boolean ' Truy?n d? li?u d?i soát sau khi dã cân d?i ca
        Public Ngay_He_Thong As Integer
        Public Chot_SL As Boolean ' Ch?t s? li?u sau khi dã cân d?i ca
    End Class
#End Region
#Region "E1_Di"
    Public Class Tmp_E1_Di
        '        Private ConnectionString As String
        '        Public Sub New(ByVal _ConnectionString As String)
        '            ConnectionString = _ConnectionString
        '        End Sub
        '#Region "Lay"
        '        ' Ngày t?o: 15/6/08
        '        ' Ngu?i t?o: Nguy?n B?ng
        '        ' N?i dung: L?y thông tin t? b?ng E1_Di
        '        ' Input: Id_E1
        '        ' Output: E1_Di_Chi_Tiet
        '        Public Function Lay(ByVal Id_E1 As String) As E1_Di_Chi_Tiet
        '            Try
        '                ' T?o d?i tu?ng connection và command
        '                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
        '                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Lay", myConnection)

        '                ' S? d?ng Store Procedure
        '                myCommand.CommandType = CommandType.StoredProcedure
        '                ' Thêm các Parameters vào th? t?c            
        '                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
        '                pId_E1.Value = Id_E1
        '                myCommand.Parameters.Add(pId_E1)

        '                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
        '                pId_Duong_Thu.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pId_Duong_Thu)

        '                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
        '                pId_Chuyen_Thu.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pId_Chuyen_Thu)

        '                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
        '                pId_E2.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pId_E2)

        '                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
        '                pId_Ca.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pId_Ca)

        '                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
        '                pMa_Bc_Khai_Thac.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

        '                Dim pMa_Quay As SqlParameter = New SqlParameter("@Ma_Quay", SqlDbType.Int, 4)
        '                pMa_Quay.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pMa_Quay)

        '                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
        '                pMa_E1.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pMa_E1)

        '                Dim pNgay_Phat_Hanh As SqlParameter = New SqlParameter("@Ngay_Phat_Hanh", SqlDbType.Int, 4)
        '                pNgay_Phat_Hanh.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pNgay_Phat_Hanh)

        '                Dim pGio_Phat_Hanh As SqlParameter = New SqlParameter("@Gio_Phat_Hanh", SqlDbType.Int, 4)
        '                pGio_Phat_Hanh.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pGio_Phat_Hanh)

        '                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 4)
        '                pNgay_Dong.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pNgay_Dong)

        '                Dim pGio_Dong As SqlParameter = New SqlParameter("@Gio_Dong", SqlDbType.Int, 4)
        '                pGio_Dong.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pGio_Dong)

        '                Dim pNgay_Nhan As SqlParameter = New SqlParameter("@Ngay_Nhan", SqlDbType.Int, 4)
        '                pNgay_Nhan.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pNgay_Nhan)

        '                Dim pGio_Nhan As SqlParameter = New SqlParameter("@Gio_Nhan", SqlDbType.Int, 4)
        '                pGio_Nhan.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pGio_Nhan)

        '                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
        '                pMa_Don_Vi.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pMa_Don_Vi)

        '                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 4)
        '                pMa_Bc_Goc.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pMa_Bc_Goc)

        '                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 4)
        '                pMa_Bc_Tra.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pMa_Bc_Tra)

        '                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
        '                pNuoc_Nhan.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pNuoc_Nhan)

        '                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2)
        '                pNuoc_Tra.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pNuoc_Tra)

        '                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
        '                pKhoi_Luong.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pKhoi_Luong)

        '                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.VarChar, 1)
        '                pPhan_Loai.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pPhan_Loai)

        '                Dim pLoai_Hang_Hoa As SqlParameter = New SqlParameter("@Loai_Hang_Hoa", SqlDbType.Int, 4)
        '                pLoai_Hang_Hoa.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pLoai_Hang_Hoa)

        '                Dim pKhoi_Luong_QD As SqlParameter = New SqlParameter("@Khoi_Luong_QD", SqlDbType.Int, 4)
        '                pKhoi_Luong_QD.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pKhoi_Luong_QD)

        '                Dim pLoai As SqlParameter = New SqlParameter("@Loai", SqlDbType.Int, 4)
        '                pLoai.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pLoai)

        '                Dim pDv_Cong_Them As SqlParameter = New SqlParameter("@Dv_Cong_Them", SqlDbType.VarChar, 50)
        '                pDv_Cong_Them.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pDv_Cong_Them)

        '                Dim pDv_Gia_Tang As SqlParameter = New SqlParameter("@Dv_Gia_Tang", SqlDbType.VarChar, 50)
        '                pDv_Gia_Tang.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pDv_Gia_Tang)

        '                Dim pPPXD As SqlParameter = New SqlParameter("@PPXD", SqlDbType.Float)
        '                pPPXD.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pPPXD)

        '                Dim pCuoc_PPXD As SqlParameter = New SqlParameter("@Cuoc_PPXD", SqlDbType.Int, 4)
        '                pCuoc_PPXD.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pCuoc_PPXD)

        '                Dim pPostCode As SqlParameter = New SqlParameter("@PostCode", SqlDbType.VarChar, 50)
        '                pPostCode.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pPostCode)

        '                Dim pCuoc_PPVX As SqlParameter = New SqlParameter("@Cuoc_PPVX", SqlDbType.Int, 4)
        '                pCuoc_PPVX.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pCuoc_PPVX)

        '                Dim pVAT As SqlParameter = New SqlParameter("@VAT", SqlDbType.Float)
        '                pVAT.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pVAT)

        '                Dim pCOD As SqlParameter = New SqlParameter("@COD", SqlDbType.Bit, 1)
        '                pCOD.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pCOD)

        '                Dim pGia_Tri_Hang As SqlParameter = New SqlParameter("@Gia_Tri_Hang", SqlDbType.Int, 4)
        '                pGia_Tri_Hang.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pGia_Tri_Hang)

        '                Dim pCuoc_COD As SqlParameter = New SqlParameter("@Cuoc_COD", SqlDbType.Int, 4)
        '                pCuoc_COD.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pCuoc_COD)

        '                Dim pCuoc_DV As SqlParameter = New SqlParameter("@Cuoc_DV", SqlDbType.Int, 4)
        '                pCuoc_DV.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pCuoc_DV)

        '                Dim pCuoc_Chinh As SqlParameter = New SqlParameter("@Cuoc_Chinh", SqlDbType.Int, 4)
        '                pCuoc_Chinh.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pCuoc_Chinh)

        '                Dim pCuoc_Giam As SqlParameter = New SqlParameter("@Cuoc_Giam", SqlDbType.Int, 4)
        '                pCuoc_Giam.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pCuoc_Giam)

        '                Dim pCuoc_E1 As SqlParameter = New SqlParameter("@Cuoc_E1", SqlDbType.Int, 4)
        '                pCuoc_E1.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pCuoc_E1)

        '                Dim pKien_So As SqlParameter = New SqlParameter("@Kien_So", SqlDbType.Int, 4)
        '                pKien_So.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pKien_So)

        '                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 4)
        '                pSTT.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pSTT)

        '                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
        '                pMa_KH.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pMa_KH)

        '                Dim pNguoi_Gui As SqlParameter = New SqlParameter("@Nguoi_Gui", SqlDbType.VarChar, 100)
        '                pNguoi_Gui.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pNguoi_Gui)

        '                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.VarChar, 100)
        '                pNguoi_Nhan.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pNguoi_Nhan)

        '                Dim pDia_Chi_Gui As SqlParameter = New SqlParameter("@Dia_Chi_Gui", SqlDbType.VarChar, 200)
        '                pDia_Chi_Gui.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pDia_Chi_Gui)

        '                Dim pDia_Chi_Nhan As SqlParameter = New SqlParameter("@Dia_Chi_Nhan", SqlDbType.VarChar, 200)
        '                pDia_Chi_Nhan.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pDia_Chi_Nhan)

        '                Dim pDien_Thoai_Gui As SqlParameter = New SqlParameter("@Dien_Thoai_Gui", SqlDbType.VarChar, 50)
        '                pDien_Thoai_Gui.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pDien_Thoai_Gui)

        '                Dim pDien_Thoai_Nhan As SqlParameter = New SqlParameter("@Dien_Thoai_Nhan", SqlDbType.VarChar, 50)
        '                pDien_Thoai_Nhan.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pDien_Thoai_Nhan)

        '                Dim pHH_Phat_Hanh As SqlParameter = New SqlParameter("@HH_Phat_Hanh", SqlDbType.Int, 4)
        '                pHH_Phat_Hanh.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pHH_Phat_Hanh)

        '                Dim pHH_Phat_Tra As SqlParameter = New SqlParameter("@HH_Phat_Tra", SqlDbType.Int, 4)
        '                pHH_Phat_Tra.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pHH_Phat_Tra)

        '                Dim pMa_Bc_CH As SqlParameter = New SqlParameter("@Ma_Bc_CH", SqlDbType.Int, 4)
        '                pMa_Bc_CH.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pMa_Bc_CH)

        '                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 4)
        '                pId_Nguoi_Dung.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pId_Nguoi_Dung)

        '                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.Int, 4)
        '                pId_Trang_Thai.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pId_Trang_Thai)

        '                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 200)
        '                pGhi_Chu.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pGhi_Chu)

        '                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
        '                pTruyen_Khai_Thac.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pTruyen_Khai_Thac)

        '                Dim pTruyen_Doi_Soat As SqlParameter = New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 1)
        '                pTruyen_Doi_Soat.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pTruyen_Doi_Soat)

        '                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
        '                pNgay_He_Thong.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pNgay_He_Thong)

        '                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 1)
        '                pChot_SL.Direction = ParameterDirection.Output
        '                myCommand.Parameters.Add(pChot_SL)

        '                myConnection.Open()
        '                myCommand.ExecuteNonQuery()
        '                myConnection.Close()
        '                Dim myE1_Di_Chi_Tiet As E1_Di_Chi_Tiet = New E1_Di_Chi_Tiet
        '                myE1_Di_Chi_Tiet.Id_E1 = Id_E1
        '                myE1_Di_Chi_Tiet.Id_Duong_Thu = pId_Duong_Thu.Value
        '                myE1_Di_Chi_Tiet.Id_Chuyen_Thu = pId_Chuyen_Thu.Value
        '                myE1_Di_Chi_Tiet.Id_E2 = pId_E2.Value
        '                myE1_Di_Chi_Tiet.Id_Ca = pId_Ca.Value
        '                myE1_Di_Chi_Tiet.Ma_Bc_Khai_Thac = pMa_Bc_Khai_Thac.Value
        '                myE1_Di_Chi_Tiet.Ma_Quay = pMa_Quay.Value
        '                myE1_Di_Chi_Tiet.Ma_E1 = pMa_E1.Value
        '                myE1_Di_Chi_Tiet.Ngay_Phat_Hanh = pNgay_Phat_Hanh.Value
        '                myE1_Di_Chi_Tiet.Gio_Phat_Hanh = pGio_Phat_Hanh.Value
        '                myE1_Di_Chi_Tiet.Ngay_Dong = pNgay_Dong.Value
        '                myE1_Di_Chi_Tiet.Gio_Dong = pGio_Dong.Value
        '                myE1_Di_Chi_Tiet.Ngay_Nhan = pNgay_Nhan.Value
        '                myE1_Di_Chi_Tiet.Gio_Nhan = pGio_Nhan.Value
        '                myE1_Di_Chi_Tiet.Ma_Don_Vi = pMa_Don_Vi.Value
        '                myE1_Di_Chi_Tiet.Ma_Bc_Goc = pMa_Bc_Goc.Value
        '                myE1_Di_Chi_Tiet.Ma_Bc_Tra = pMa_Bc_Tra.Value
        '                myE1_Di_Chi_Tiet.Nuoc_Nhan = pNuoc_Nhan.Value
        '                myE1_Di_Chi_Tiet.Nuoc_Tra = pNuoc_Tra.Value
        '                myE1_Di_Chi_Tiet.Khoi_Luong = pKhoi_Luong.Value
        '                myE1_Di_Chi_Tiet.Phan_Loai = pPhan_Loai.Value
        '                myE1_Di_Chi_Tiet.Loai_Hang_Hoa = pLoai_Hang_Hoa.Value
        '                myE1_Di_Chi_Tiet.Khoi_Luong_QD = pKhoi_Luong_QD.Value
        '                myE1_Di_Chi_Tiet.Loai = pLoai.Value
        '                myE1_Di_Chi_Tiet.Dv_Cong_Them = pDv_Cong_Them.Value
        '                myE1_Di_Chi_Tiet.Dv_Gia_Tang = pDv_Gia_Tang.Value
        '                myE1_Di_Chi_Tiet.PPXD = pPPXD.Value
        '                myE1_Di_Chi_Tiet.Cuoc_PPXD = pCuoc_PPXD.Value
        '                myE1_Di_Chi_Tiet.PostCode = pPostCode.Value
        '                myE1_Di_Chi_Tiet.Cuoc_PPVX = pCuoc_PPVX.Value
        '                myE1_Di_Chi_Tiet.VAT = pVAT.Value
        '                myE1_Di_Chi_Tiet.COD = pCOD.Value
        '                myE1_Di_Chi_Tiet.Gia_Tri_Hang = pGia_Tri_Hang.Value
        '                myE1_Di_Chi_Tiet.Cuoc_COD = pCuoc_COD.Value
        '                myE1_Di_Chi_Tiet.Cuoc_DV = pCuoc_DV.Value
        '                myE1_Di_Chi_Tiet.Cuoc_Chinh = pCuoc_Chinh.Value
        '                myE1_Di_Chi_Tiet.Cuoc_Giam = pCuoc_Giam.Value
        '                myE1_Di_Chi_Tiet.Cuoc_E1 = pCuoc_E1.Value
        '                myE1_Di_Chi_Tiet.Kien_So = pKien_So.Value
        '                myE1_Di_Chi_Tiet.STT = pSTT.Value
        '                myE1_Di_Chi_Tiet.Ma_KH = pMa_KH.Value
        '                myE1_Di_Chi_Tiet.Nguoi_Gui = pNguoi_Gui.Value
        '                myE1_Di_Chi_Tiet.Nguoi_Nhan = pNguoi_Nhan.Value
        '                myE1_Di_Chi_Tiet.Dia_Chi_Gui = pDia_Chi_Gui.Value
        '                myE1_Di_Chi_Tiet.Dia_Chi_Nhan = pDia_Chi_Nhan.Value
        '                myE1_Di_Chi_Tiet.Dien_Thoai_Gui = pDien_Thoai_Gui.Value
        '                myE1_Di_Chi_Tiet.Dien_Thoai_Nhan = pDien_Thoai_Nhan.Value
        '                myE1_Di_Chi_Tiet.HH_Phat_Hanh = pHH_Phat_Hanh.Value
        '                myE1_Di_Chi_Tiet.HH_Phat_Tra = pHH_Phat_Tra.Value
        '                myE1_Di_Chi_Tiet.Ma_Bc_CH = pMa_Bc_CH.Value
        '                myE1_Di_Chi_Tiet.Id_Nguoi_Dung = pId_Nguoi_Dung.Value
        '                myE1_Di_Chi_Tiet.Id_Trang_Thai = pId_Trang_Thai.Value
        '                myE1_Di_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value
        '                myE1_Di_Chi_Tiet.Truyen_Khai_Thac = pTruyen_Khai_Thac.Value
        '                myE1_Di_Chi_Tiet.Truyen_Doi_Soat = pTruyen_Doi_Soat.Value
        '                myE1_Di_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
        '                myE1_Di_Chi_Tiet.Chot_SL = pChot_SL.Value
        '                Return myE1_Di_Chi_Tiet
        '            Catch ex As Exception
        '                Console.Write(ex.ToString)

        '            End Try
        '        End Function
        '#End Region
        '#Region "Them"
        '        ' Ngày t?o: 15/6/08
        '        ' Ngu?i t?o: Nguy?n B?ng
        '        ' N?i dung: Thêm d? li?u vào b?ng E1_Di
        '        ' Input:  Id_Duong_Thu, Id_Chuyen_Thu, Id_E2, Id_Ca, Ma_Bc_Khai_Thac, Ma_Quay, Ma_E1, Ngay_Phat_Hanh, Gio_Phat_Hanh, Ngay_Dong, Gio_Dong, Ngay_Nhan, Gio_Nhan, Ma_Don_Vi, Ma_Bc_Goc, Ma_Bc_Tra, Nuoc_Nhan, Nuoc_Tra, Khoi_Luong, Phan_Loai, Loai_Hang_Hoa, Khoi_Luong_QD, Loai, Dv_Cong_Them, Dv_Gia_Tang, PPXD, Cuoc_PPXD, PostCode, Cuoc_PPVX, VAT, COD, Gia_Tri_Hang, Cuoc_COD, Cuoc_DV, Cuoc_Chinh, Cuoc_Giam, Cuoc_E1, Kien_So, STT, Ma_KH, Nguoi_Gui, Nguoi_Nhan, Dia_Chi_Gui, Dia_Chi_Nhan, Dien_Thoai_Gui, Dien_Thoai_Nhan, HH_Phat_Hanh, HH_Phat_Tra, Ma_Bc_CH, Id_Nguoi_Dung, Id_Trang_Thai, Ghi_Chu, Truyen_Khai_Thac, Truyen_Doi_Soat, Ngay_He_Thong, Chot_SL,
        '        ' Output: 
        '        Public Sub Them(ByVal Id_Duong_Thu As String, ByVal Id_Chuyen_Thu As String, ByVal Id_E2 As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Quay As Integer, ByVal Ma_E1 As String, ByVal Ngay_Phat_Hanh As Integer, ByVal Gio_Phat_Hanh As Integer, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Ma_Don_Vi As String, ByVal Ma_Bc_Goc As Integer, ByVal Ma_Bc_Tra As Integer, ByVal Nuoc_Nhan As String, ByVal Nuoc_Tra As String, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal Loai_Hang_Hoa As Integer, ByVal Khoi_Luong_QD As Integer, ByVal Loai As Integer, ByVal Dv_Cong_Them As String, ByVal Dv_Gia_Tang As String, ByVal PPXD As Double, ByVal Cuoc_PPXD As Integer, ByVal PostCode As String, ByVal Cuoc_PPVX As Integer, ByVal VAT As Double, ByVal COD As Boolean, ByVal Gia_Tri_Hang As Integer, ByVal Cuoc_COD As Integer, ByVal Cuoc_DV As Integer, ByVal Cuoc_Chinh As Integer, ByVal Cuoc_Giam As Integer, ByVal Cuoc_E1 As Integer, ByVal Kien_So As Integer, ByVal STT As Integer, ByVal Ma_KH As String, ByVal Nguoi_Gui As String, ByVal Nguoi_Nhan As String, ByVal Dia_Chi_Gui As String, ByVal Dia_Chi_Nhan As String, ByVal Dien_Thoai_Gui As String, ByVal Dien_Thoai_Nhan As String, ByVal HH_Phat_Hanh As Integer, ByVal HH_Phat_Tra As Integer, ByVal Ma_Bc_CH As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Id_Trang_Thai As Integer, ByVal Ghi_Chu As String, ByVal Truyen_Khai_Thac As Boolean, ByVal Truyen_Doi_Soat As Boolean, ByVal Ngay_He_Thong As Integer, ByVal Chot_SL As Boolean)
        '            Try
        '                ' T?o d?i tu?ng connection và command
        '                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
        '                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Them", myConnection)

        '                ' S? d?ng Store Procedure
        '                myCommand.CommandType = CommandType.StoredProcedure
        '                ' Thêm các Parameters vào th? t?c
        '                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
        '                pId_Duong_Thu.Value = Id_Duong_Thu
        '                myCommand.Parameters.Add(pId_Duong_Thu)

        '                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
        '                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
        '                myCommand.Parameters.Add(pId_Chuyen_Thu)

        '                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
        '                pId_E2.Value = Id_E2
        '                myCommand.Parameters.Add(pId_E2)

        '                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
        '                pId_Ca.Value = Id_Ca
        '                myCommand.Parameters.Add(pId_Ca)

        '                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
        '                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
        '                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

        '                Dim pMa_Quay As SqlParameter = New SqlParameter("@Ma_Quay", SqlDbType.Int, 4)
        '                pMa_Quay.Value = Ma_Quay
        '                myCommand.Parameters.Add(pMa_Quay)

        '                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
        '                pMa_E1.Value = Ma_E1
        '                myCommand.Parameters.Add(pMa_E1)

        '                Dim pNgay_Phat_Hanh As SqlParameter = New SqlParameter("@Ngay_Phat_Hanh", SqlDbType.Int, 4)
        '                pNgay_Phat_Hanh.Value = Ngay_Phat_Hanh
        '                myCommand.Parameters.Add(pNgay_Phat_Hanh)

        '                Dim pGio_Phat_Hanh As SqlParameter = New SqlParameter("@Gio_Phat_Hanh", SqlDbType.Int, 4)
        '                pGio_Phat_Hanh.Value = Gio_Phat_Hanh
        '                myCommand.Parameters.Add(pGio_Phat_Hanh)

        '                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 4)
        '                pNgay_Dong.Value = Ngay_Dong
        '                myCommand.Parameters.Add(pNgay_Dong)

        '                Dim pGio_Dong As SqlParameter = New SqlParameter("@Gio_Dong", SqlDbType.Int, 4)
        '                pGio_Dong.Value = Gio_Dong
        '                myCommand.Parameters.Add(pGio_Dong)

        '                Dim pNgay_Nhan As SqlParameter = New SqlParameter("@Ngay_Nhan", SqlDbType.Int, 4)
        '                pNgay_Nhan.Value = Ngay_Nhan
        '                myCommand.Parameters.Add(pNgay_Nhan)

        '                Dim pGio_Nhan As SqlParameter = New SqlParameter("@Gio_Nhan", SqlDbType.Int, 4)
        '                pGio_Nhan.Value = Gio_Nhan
        '                myCommand.Parameters.Add(pGio_Nhan)

        '                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
        '                pMa_Don_Vi.Value = Ma_Don_Vi
        '                myCommand.Parameters.Add(pMa_Don_Vi)

        '                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 4)
        '                pMa_Bc_Goc.Value = Ma_Bc_Goc
        '                myCommand.Parameters.Add(pMa_Bc_Goc)

        '                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 4)
        '                pMa_Bc_Tra.Value = Ma_Bc_Tra
        '                myCommand.Parameters.Add(pMa_Bc_Tra)

        '                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
        '                pNuoc_Nhan.Value = Nuoc_Nhan
        '                myCommand.Parameters.Add(pNuoc_Nhan)

        '                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2)
        '                pNuoc_Tra.Value = Nuoc_Tra
        '                myCommand.Parameters.Add(pNuoc_Tra)

        '                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
        '                pKhoi_Luong.Value = Khoi_Luong
        '                myCommand.Parameters.Add(pKhoi_Luong)

        '                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.VarChar, 1)
        '                pPhan_Loai.Value = Phan_Loai
        '                myCommand.Parameters.Add(pPhan_Loai)

        '                Dim pLoai_Hang_Hoa As SqlParameter = New SqlParameter("@Loai_Hang_Hoa", SqlDbType.Int, 4)
        '                pLoai_Hang_Hoa.Value = Loai_Hang_Hoa
        '                myCommand.Parameters.Add(pLoai_Hang_Hoa)

        '                Dim pKhoi_Luong_QD As SqlParameter = New SqlParameter("@Khoi_Luong_QD", SqlDbType.Int, 4)
        '                pKhoi_Luong_QD.Value = Khoi_Luong_QD
        '                myCommand.Parameters.Add(pKhoi_Luong_QD)

        '                Dim pLoai As SqlParameter = New SqlParameter("@Loai", SqlDbType.Int, 4)
        '                pLoai.Value = Loai
        '                myCommand.Parameters.Add(pLoai)

        '                Dim pDv_Cong_Them As SqlParameter = New SqlParameter("@Dv_Cong_Them", SqlDbType.VarChar, 50)
        '                pDv_Cong_Them.Value = Dv_Cong_Them
        '                myCommand.Parameters.Add(pDv_Cong_Them)

        '                Dim pDv_Gia_Tang As SqlParameter = New SqlParameter("@Dv_Gia_Tang", SqlDbType.VarChar, 50)
        '                pDv_Gia_Tang.Value = Dv_Gia_Tang
        '                myCommand.Parameters.Add(pDv_Gia_Tang)

        '                Dim pPPXD As SqlParameter = New SqlParameter("@PPXD", SqlDbType.Float)
        '                pPPXD.Value = PPXD
        '                myCommand.Parameters.Add(pPPXD)

        '                Dim pCuoc_PPXD As SqlParameter = New SqlParameter("@Cuoc_PPXD", SqlDbType.Int, 4)
        '                pCuoc_PPXD.Value = Cuoc_PPXD
        '                myCommand.Parameters.Add(pCuoc_PPXD)

        '                Dim pPostCode As SqlParameter = New SqlParameter("@PostCode", SqlDbType.VarChar, 50)
        '                pPostCode.Value = PostCode
        '                myCommand.Parameters.Add(pPostCode)

        '                Dim pCuoc_PPVX As SqlParameter = New SqlParameter("@Cuoc_PPVX", SqlDbType.Int, 4)
        '                pCuoc_PPVX.Value = Cuoc_PPVX
        '                myCommand.Parameters.Add(pCuoc_PPVX)

        '                Dim pVAT As SqlParameter = New SqlParameter("@VAT", SqlDbType.Float)
        '                pVAT.Value = VAT
        '                myCommand.Parameters.Add(pVAT)

        '                Dim pCOD As SqlParameter = New SqlParameter("@COD", SqlDbType.Bit, 1)
        '                pCOD.Value = COD
        '                myCommand.Parameters.Add(pCOD)

        '                Dim pGia_Tri_Hang As SqlParameter = New SqlParameter("@Gia_Tri_Hang", SqlDbType.Int, 4)
        '                pGia_Tri_Hang.Value = Gia_Tri_Hang
        '                myCommand.Parameters.Add(pGia_Tri_Hang)

        '                Dim pCuoc_COD As SqlParameter = New SqlParameter("@Cuoc_COD", SqlDbType.Int, 4)
        '                pCuoc_COD.Value = Cuoc_COD
        '                myCommand.Parameters.Add(pCuoc_COD)

        '                Dim pCuoc_DV As SqlParameter = New SqlParameter("@Cuoc_DV", SqlDbType.Int, 4)
        '                pCuoc_DV.Value = Cuoc_DV
        '                myCommand.Parameters.Add(pCuoc_DV)

        '                Dim pCuoc_Chinh As SqlParameter = New SqlParameter("@Cuoc_Chinh", SqlDbType.Int, 4)
        '                pCuoc_Chinh.Value = Cuoc_Chinh
        '                myCommand.Parameters.Add(pCuoc_Chinh)

        '                Dim pCuoc_Giam As SqlParameter = New SqlParameter("@Cuoc_Giam", SqlDbType.Int, 4)
        '                pCuoc_Giam.Value = Cuoc_Giam
        '                myCommand.Parameters.Add(pCuoc_Giam)

        '                Dim pCuoc_E1 As SqlParameter = New SqlParameter("@Cuoc_E1", SqlDbType.Int, 4)
        '                pCuoc_E1.Value = Cuoc_E1
        '                myCommand.Parameters.Add(pCuoc_E1)

        '                Dim pKien_So As SqlParameter = New SqlParameter("@Kien_So", SqlDbType.Int, 4)
        '                pKien_So.Value = Kien_So
        '                myCommand.Parameters.Add(pKien_So)

        '                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 4)
        '                pSTT.Value = STT
        '                myCommand.Parameters.Add(pSTT)

        '                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
        '                pMa_KH.Value = Ma_KH
        '                myCommand.Parameters.Add(pMa_KH)

        '                Dim pNguoi_Gui As SqlParameter = New SqlParameter("@Nguoi_Gui", SqlDbType.VarChar, 100)
        '                pNguoi_Gui.Value = Nguoi_Gui
        '                myCommand.Parameters.Add(pNguoi_Gui)

        '                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.VarChar, 100)
        '                pNguoi_Nhan.Value = Nguoi_Nhan
        '                myCommand.Parameters.Add(pNguoi_Nhan)

        '                Dim pDia_Chi_Gui As SqlParameter = New SqlParameter("@Dia_Chi_Gui", SqlDbType.VarChar, 200)
        '                pDia_Chi_Gui.Value = Dia_Chi_Gui
        '                myCommand.Parameters.Add(pDia_Chi_Gui)

        '                Dim pDia_Chi_Nhan As SqlParameter = New SqlParameter("@Dia_Chi_Nhan", SqlDbType.VarChar, 200)
        '                pDia_Chi_Nhan.Value = Dia_Chi_Nhan
        '                myCommand.Parameters.Add(pDia_Chi_Nhan)

        '                Dim pDien_Thoai_Gui As SqlParameter = New SqlParameter("@Dien_Thoai_Gui", SqlDbType.VarChar, 50)
        '                pDien_Thoai_Gui.Value = Dien_Thoai_Gui
        '                myCommand.Parameters.Add(pDien_Thoai_Gui)

        '                Dim pDien_Thoai_Nhan As SqlParameter = New SqlParameter("@Dien_Thoai_Nhan", SqlDbType.VarChar, 50)
        '                pDien_Thoai_Nhan.Value = Dien_Thoai_Nhan
        '                myCommand.Parameters.Add(pDien_Thoai_Nhan)

        '                Dim pHH_Phat_Hanh As SqlParameter = New SqlParameter("@HH_Phat_Hanh", SqlDbType.Int, 4)
        '                pHH_Phat_Hanh.Value = HH_Phat_Hanh
        '                myCommand.Parameters.Add(pHH_Phat_Hanh)

        '                Dim pHH_Phat_Tra As SqlParameter = New SqlParameter("@HH_Phat_Tra", SqlDbType.Int, 4)
        '                pHH_Phat_Tra.Value = HH_Phat_Tra
        '                myCommand.Parameters.Add(pHH_Phat_Tra)

        '                Dim pMa_Bc_CH As SqlParameter = New SqlParameter("@Ma_Bc_CH", SqlDbType.Int, 4)
        '                pMa_Bc_CH.Value = Ma_Bc_CH
        '                myCommand.Parameters.Add(pMa_Bc_CH)

        '                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 4)
        '                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
        '                myCommand.Parameters.Add(pId_Nguoi_Dung)

        '                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.Int, 4)
        '                pId_Trang_Thai.Value = Id_Trang_Thai
        '                myCommand.Parameters.Add(pId_Trang_Thai)

        '                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 200)
        '                pGhi_Chu.Value = Ghi_Chu
        '                myCommand.Parameters.Add(pGhi_Chu)

        '                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
        '                pTruyen_Khai_Thac.Value = Truyen_Khai_Thac
        '                myCommand.Parameters.Add(pTruyen_Khai_Thac)

        '                Dim pTruyen_Doi_Soat As SqlParameter = New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 1)
        '                pTruyen_Doi_Soat.Value = Truyen_Doi_Soat
        '                myCommand.Parameters.Add(pTruyen_Doi_Soat)

        '                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
        '                pNgay_He_Thong.Value = Ngay_He_Thong
        '                myCommand.Parameters.Add(pNgay_He_Thong)

        '                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 1)
        '                pChot_SL.Value = Chot_SL
        '                myCommand.Parameters.Add(pChot_SL)


        '                myConnection.Open()
        '                myCommand.ExecuteNonQuery()
        '                myConnection.Close()
        '            Catch ex As Exception
        '                Console.Write(ex.ToString)

        '            End Try
        '        End Sub
        '#End Region
        '#Region "Cap_Nhat"
        '        ' Ngày t?o: 15/6/08
        '        ' Ngu?i t?o: Nguy?n B?ng
        '        ' N?i dung: C?p nh?t d? li?u vào b?ng E1_Di
        '        ' Input: Id_E1,  Id_Duong_Thu , Id_Chuyen_Thu , Id_E2 , Id_Ca , Ma_Bc_Khai_Thac , Ma_Quay , Ma_E1 , Ngay_Phat_Hanh , Gio_Phat_Hanh , Ngay_Dong , Gio_Dong , Ngay_Nhan , Gio_Nhan , Ma_Don_Vi , Ma_Bc_Goc , Ma_Bc_Tra , Nuoc_Nhan , Nuoc_Tra , Khoi_Luong , Phan_Loai , Loai_Hang_Hoa , Khoi_Luong_QD , Loai , Dv_Cong_Them , Dv_Gia_Tang , PPXD , Cuoc_PPXD , PostCode , Cuoc_PPVX , VAT , COD , Gia_Tri_Hang , Cuoc_COD , Cuoc_DV , Cuoc_Chinh , Cuoc_Giam , Cuoc_E1 , Kien_So , STT , Ma_KH , Nguoi_Gui , Nguoi_Nhan , Dia_Chi_Gui , Dia_Chi_Nhan , Dien_Thoai_Gui , Dien_Thoai_Nhan , HH_Phat_Hanh , HH_Phat_Tra , Ma_Bc_CH , Id_Nguoi_Dung , Id_Trang_Thai , Ghi_Chu , Truyen_Khai_Thac , Truyen_Doi_Soat , Ngay_He_Thong , Chot_SL ,
        '        ' Output: 
        '        Public Sub Cap_Nhat(ByVal Id_E1 As String, ByVal Id_Duong_Thu As String, ByVal Id_Chuyen_Thu As String, ByVal Id_E2 As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Quay As Integer, ByVal Ma_E1 As String, ByVal Ngay_Phat_Hanh As Integer, ByVal Gio_Phat_Hanh As Integer, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Ma_Don_Vi As String, ByVal Ma_Bc_Goc As Integer, ByVal Ma_Bc_Tra As Integer, ByVal Nuoc_Nhan As String, ByVal Nuoc_Tra As String, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal Loai_Hang_Hoa As Integer, ByVal Khoi_Luong_QD As Integer, ByVal Loai As Integer, ByVal Dv_Cong_Them As String, ByVal Dv_Gia_Tang As String, ByVal PPXD As Double, ByVal Cuoc_PPXD As Integer, ByVal PostCode As String, ByVal Cuoc_PPVX As Integer, ByVal VAT As Double, ByVal COD As Boolean, ByVal Gia_Tri_Hang As Integer, ByVal Cuoc_COD As Integer, ByVal Cuoc_DV As Integer, ByVal Cuoc_Chinh As Integer, ByVal Cuoc_Giam As Integer, ByVal Cuoc_E1 As Integer, ByVal Kien_So As Integer, ByVal STT As Integer, ByVal Ma_KH As String, ByVal Nguoi_Gui As String, ByVal Nguoi_Nhan As String, ByVal Dia_Chi_Gui As String, ByVal Dia_Chi_Nhan As String, ByVal Dien_Thoai_Gui As String, ByVal Dien_Thoai_Nhan As String, ByVal HH_Phat_Hanh As Integer, ByVal HH_Phat_Tra As Integer, ByVal Ma_Bc_CH As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Id_Trang_Thai As Integer, ByVal Ghi_Chu As String, ByVal Truyen_Khai_Thac As Boolean, ByVal Truyen_Doi_Soat As Boolean, ByVal Ngay_He_Thong As Integer, ByVal Chot_SL As Boolean)
        '            Try
        '                ' T?o d?i tu?ng connection và command
        '                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
        '                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Cap_Nhat", myConnection)

        '                ' S? d?ng Store Procedure
        '                myCommand.CommandType = CommandType.StoredProcedure
        '                ' Thêm các Parameters vào th? t?c
        '                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
        '                pId_E1.Value = Id_E1
        '                myCommand.Parameters.Add(pId_E1)

        '                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
        '                pId_Duong_Thu.Value = Id_Duong_Thu
        '                myCommand.Parameters.Add(pId_Duong_Thu)

        '                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
        '                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
        '                myCommand.Parameters.Add(pId_Chuyen_Thu)

        '                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
        '                pId_E2.Value = Id_E2
        '                myCommand.Parameters.Add(pId_E2)

        '                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
        '                pId_Ca.Value = Id_Ca
        '                myCommand.Parameters.Add(pId_Ca)

        '                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
        '                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
        '                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

        '                Dim pMa_Quay As SqlParameter = New SqlParameter("@Ma_Quay", SqlDbType.Int, 4)
        '                pMa_Quay.Value = Ma_Quay
        '                myCommand.Parameters.Add(pMa_Quay)

        '                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
        '                pMa_E1.Value = Ma_E1
        '                myCommand.Parameters.Add(pMa_E1)

        '                Dim pNgay_Phat_Hanh As SqlParameter = New SqlParameter("@Ngay_Phat_Hanh", SqlDbType.Int, 4)
        '                pNgay_Phat_Hanh.Value = Ngay_Phat_Hanh
        '                myCommand.Parameters.Add(pNgay_Phat_Hanh)

        '                Dim pGio_Phat_Hanh As SqlParameter = New SqlParameter("@Gio_Phat_Hanh", SqlDbType.Int, 4)
        '                pGio_Phat_Hanh.Value = Gio_Phat_Hanh
        '                myCommand.Parameters.Add(pGio_Phat_Hanh)

        '                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 4)
        '                pNgay_Dong.Value = Ngay_Dong
        '                myCommand.Parameters.Add(pNgay_Dong)

        '                Dim pGio_Dong As SqlParameter = New SqlParameter("@Gio_Dong", SqlDbType.Int, 4)
        '                pGio_Dong.Value = Gio_Dong
        '                myCommand.Parameters.Add(pGio_Dong)

        '                Dim pNgay_Nhan As SqlParameter = New SqlParameter("@Ngay_Nhan", SqlDbType.Int, 4)
        '                pNgay_Nhan.Value = Ngay_Nhan
        '                myCommand.Parameters.Add(pNgay_Nhan)

        '                Dim pGio_Nhan As SqlParameter = New SqlParameter("@Gio_Nhan", SqlDbType.Int, 4)
        '                pGio_Nhan.Value = Gio_Nhan
        '                myCommand.Parameters.Add(pGio_Nhan)

        '                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
        '                pMa_Don_Vi.Value = Ma_Don_Vi
        '                myCommand.Parameters.Add(pMa_Don_Vi)

        '                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 4)
        '                pMa_Bc_Goc.Value = Ma_Bc_Goc
        '                myCommand.Parameters.Add(pMa_Bc_Goc)

        '                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 4)
        '                pMa_Bc_Tra.Value = Ma_Bc_Tra
        '                myCommand.Parameters.Add(pMa_Bc_Tra)

        '                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
        '                pNuoc_Nhan.Value = Nuoc_Nhan
        '                myCommand.Parameters.Add(pNuoc_Nhan)

        '                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2)
        '                pNuoc_Tra.Value = Nuoc_Tra
        '                myCommand.Parameters.Add(pNuoc_Tra)

        '                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
        '                pKhoi_Luong.Value = Khoi_Luong
        '                myCommand.Parameters.Add(pKhoi_Luong)

        '                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.VarChar, 1)
        '                pPhan_Loai.Value = Phan_Loai
        '                myCommand.Parameters.Add(pPhan_Loai)

        '                Dim pLoai_Hang_Hoa As SqlParameter = New SqlParameter("@Loai_Hang_Hoa", SqlDbType.Int, 4)
        '                pLoai_Hang_Hoa.Value = Loai_Hang_Hoa
        '                myCommand.Parameters.Add(pLoai_Hang_Hoa)

        '                Dim pKhoi_Luong_QD As SqlParameter = New SqlParameter("@Khoi_Luong_QD", SqlDbType.Int, 4)
        '                pKhoi_Luong_QD.Value = Khoi_Luong_QD
        '                myCommand.Parameters.Add(pKhoi_Luong_QD)

        '                Dim pLoai As SqlParameter = New SqlParameter("@Loai", SqlDbType.Int, 4)
        '                pLoai.Value = Loai
        '                myCommand.Parameters.Add(pLoai)

        '                Dim pDv_Cong_Them As SqlParameter = New SqlParameter("@Dv_Cong_Them", SqlDbType.VarChar, 50)
        '                pDv_Cong_Them.Value = Dv_Cong_Them
        '                myCommand.Parameters.Add(pDv_Cong_Them)

        '                Dim pDv_Gia_Tang As SqlParameter = New SqlParameter("@Dv_Gia_Tang", SqlDbType.VarChar, 50)
        '                pDv_Gia_Tang.Value = Dv_Gia_Tang
        '                myCommand.Parameters.Add(pDv_Gia_Tang)

        '                Dim pPPXD As SqlParameter = New SqlParameter("@PPXD", SqlDbType.Float)
        '                pPPXD.Value = PPXD
        '                myCommand.Parameters.Add(pPPXD)

        '                Dim pCuoc_PPXD As SqlParameter = New SqlParameter("@Cuoc_PPXD", SqlDbType.Int, 4)
        '                pCuoc_PPXD.Value = Cuoc_PPXD
        '                myCommand.Parameters.Add(pCuoc_PPXD)

        '                Dim pPostCode As SqlParameter = New SqlParameter("@PostCode", SqlDbType.VarChar, 50)
        '                pPostCode.Value = PostCode
        '                myCommand.Parameters.Add(pPostCode)

        '                Dim pCuoc_PPVX As SqlParameter = New SqlParameter("@Cuoc_PPVX", SqlDbType.Int, 4)
        '                pCuoc_PPVX.Value = Cuoc_PPVX
        '                myCommand.Parameters.Add(pCuoc_PPVX)

        '                Dim pVAT As SqlParameter = New SqlParameter("@VAT", SqlDbType.Float)
        '                pVAT.Value = VAT
        '                myCommand.Parameters.Add(pVAT)

        '                Dim pCOD As SqlParameter = New SqlParameter("@COD", SqlDbType.Bit, 1)
        '                pCOD.Value = COD
        '                myCommand.Parameters.Add(pCOD)

        '                Dim pGia_Tri_Hang As SqlParameter = New SqlParameter("@Gia_Tri_Hang", SqlDbType.Int, 4)
        '                pGia_Tri_Hang.Value = Gia_Tri_Hang
        '                myCommand.Parameters.Add(pGia_Tri_Hang)

        '                Dim pCuoc_COD As SqlParameter = New SqlParameter("@Cuoc_COD", SqlDbType.Int, 4)
        '                pCuoc_COD.Value = Cuoc_COD
        '                myCommand.Parameters.Add(pCuoc_COD)

        '                Dim pCuoc_DV As SqlParameter = New SqlParameter("@Cuoc_DV", SqlDbType.Int, 4)
        '                pCuoc_DV.Value = Cuoc_DV
        '                myCommand.Parameters.Add(pCuoc_DV)

        '                Dim pCuoc_Chinh As SqlParameter = New SqlParameter("@Cuoc_Chinh", SqlDbType.Int, 4)
        '                pCuoc_Chinh.Value = Cuoc_Chinh
        '                myCommand.Parameters.Add(pCuoc_Chinh)

        '                Dim pCuoc_Giam As SqlParameter = New SqlParameter("@Cuoc_Giam", SqlDbType.Int, 4)
        '                pCuoc_Giam.Value = Cuoc_Giam
        '                myCommand.Parameters.Add(pCuoc_Giam)

        '                Dim pCuoc_E1 As SqlParameter = New SqlParameter("@Cuoc_E1", SqlDbType.Int, 4)
        '                pCuoc_E1.Value = Cuoc_E1
        '                myCommand.Parameters.Add(pCuoc_E1)

        '                Dim pKien_So As SqlParameter = New SqlParameter("@Kien_So", SqlDbType.Int, 4)
        '                pKien_So.Value = Kien_So
        '                myCommand.Parameters.Add(pKien_So)

        '                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 4)
        '                pSTT.Value = STT
        '                myCommand.Parameters.Add(pSTT)

        '                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
        '                pMa_KH.Value = Ma_KH
        '                myCommand.Parameters.Add(pMa_KH)

        '                Dim pNguoi_Gui As SqlParameter = New SqlParameter("@Nguoi_Gui", SqlDbType.VarChar, 100)
        '                pNguoi_Gui.Value = Nguoi_Gui
        '                myCommand.Parameters.Add(pNguoi_Gui)

        '                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.VarChar, 100)
        '                pNguoi_Nhan.Value = Nguoi_Nhan
        '                myCommand.Parameters.Add(pNguoi_Nhan)

        '                Dim pDia_Chi_Gui As SqlParameter = New SqlParameter("@Dia_Chi_Gui", SqlDbType.VarChar, 200)
        '                pDia_Chi_Gui.Value = Dia_Chi_Gui
        '                myCommand.Parameters.Add(pDia_Chi_Gui)

        '                Dim pDia_Chi_Nhan As SqlParameter = New SqlParameter("@Dia_Chi_Nhan", SqlDbType.VarChar, 200)
        '                pDia_Chi_Nhan.Value = Dia_Chi_Nhan
        '                myCommand.Parameters.Add(pDia_Chi_Nhan)

        '                Dim pDien_Thoai_Gui As SqlParameter = New SqlParameter("@Dien_Thoai_Gui", SqlDbType.VarChar, 50)
        '                pDien_Thoai_Gui.Value = Dien_Thoai_Gui
        '                myCommand.Parameters.Add(pDien_Thoai_Gui)

        '                Dim pDien_Thoai_Nhan As SqlParameter = New SqlParameter("@Dien_Thoai_Nhan", SqlDbType.VarChar, 50)
        '                pDien_Thoai_Nhan.Value = Dien_Thoai_Nhan
        '                myCommand.Parameters.Add(pDien_Thoai_Nhan)

        '                Dim pHH_Phat_Hanh As SqlParameter = New SqlParameter("@HH_Phat_Hanh", SqlDbType.Int, 4)
        '                pHH_Phat_Hanh.Value = HH_Phat_Hanh
        '                myCommand.Parameters.Add(pHH_Phat_Hanh)

        '                Dim pHH_Phat_Tra As SqlParameter = New SqlParameter("@HH_Phat_Tra", SqlDbType.Int, 4)
        '                pHH_Phat_Tra.Value = HH_Phat_Tra
        '                myCommand.Parameters.Add(pHH_Phat_Tra)

        '                Dim pMa_Bc_CH As SqlParameter = New SqlParameter("@Ma_Bc_CH", SqlDbType.Int, 4)
        '                pMa_Bc_CH.Value = Ma_Bc_CH
        '                myCommand.Parameters.Add(pMa_Bc_CH)

        '                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 4)
        '                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
        '                myCommand.Parameters.Add(pId_Nguoi_Dung)

        '                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.Int, 4)
        '                pId_Trang_Thai.Value = Id_Trang_Thai
        '                myCommand.Parameters.Add(pId_Trang_Thai)

        '                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 200)
        '                pGhi_Chu.Value = Ghi_Chu
        '                myCommand.Parameters.Add(pGhi_Chu)

        '                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
        '                pTruyen_Khai_Thac.Value = Truyen_Khai_Thac
        '                myCommand.Parameters.Add(pTruyen_Khai_Thac)

        '                Dim pTruyen_Doi_Soat As SqlParameter = New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 1)
        '                pTruyen_Doi_Soat.Value = Truyen_Doi_Soat
        '                myCommand.Parameters.Add(pTruyen_Doi_Soat)

        '                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
        '                pNgay_He_Thong.Value = Ngay_He_Thong
        '                myCommand.Parameters.Add(pNgay_He_Thong)

        '                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 1)
        '                pChot_SL.Value = Chot_SL
        '                myCommand.Parameters.Add(pChot_SL)


        '                myConnection.Open()
        '                myCommand.ExecuteNonQuery()
        '                myConnection.Close()
        '            Catch ex As Exception
        '                Console.Write(ex.ToString)
        '            End Try
        '        End Sub
        '#End Region
        '#Region "Cap_Nhat"
        '        ' Ngày t?o: 15/6/08
        '        ' Ngu?i t?o: Nguy?n B?ng
        '        ' N?i dung: C?p nh?t d? li?u vào b?ng E1_Di
        '        ' Input: d?i tu?ng thu?c l?p E1_Di_Chi_Tiet
        '        ' Output: 
        '        Public Sub Cap_Nhat(ByVal myE1_Di_Chi_Tiet As E1_Di_Chi_Tiet)
        '            Try
        '                ' T?o d?i tu?ng connection và command
        '                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
        '                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Cap_Nhat", myConnection)

        '                ' S? d?ng Store Procedure
        '                myCommand.CommandType = CommandType.StoredProcedure
        '                ' Thêm các Parameters vào th? t?c						
        '                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
        '                pId_E1.Value = myE1_Di_Chi_Tiet.Id_E1
        '                myCommand.Parameters.Add(pId_E1)

        '                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
        '                pId_Duong_Thu.Value = myE1_Di_Chi_Tiet.Id_Duong_Thu
        '                myCommand.Parameters.Add(pId_Duong_Thu)

        '                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
        '                pId_Chuyen_Thu.Value = myE1_Di_Chi_Tiet.Id_Chuyen_Thu
        '                myCommand.Parameters.Add(pId_Chuyen_Thu)

        '                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
        '                pId_E2.Value = myE1_Di_Chi_Tiet.Id_E2
        '                myCommand.Parameters.Add(pId_E2)

        '                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
        '                pId_Ca.Value = myE1_Di_Chi_Tiet.Id_Ca
        '                myCommand.Parameters.Add(pId_Ca)

        '                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
        '                pMa_Bc_Khai_Thac.Value = myE1_Di_Chi_Tiet.Ma_Bc_Khai_Thac
        '                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

        '                Dim pMa_Quay As SqlParameter = New SqlParameter("@Ma_Quay", SqlDbType.Int, 4)
        '                pMa_Quay.Value = myE1_Di_Chi_Tiet.Ma_Quay
        '                myCommand.Parameters.Add(pMa_Quay)

        '                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
        '                pMa_E1.Value = myE1_Di_Chi_Tiet.Ma_E1
        '                myCommand.Parameters.Add(pMa_E1)

        '                Dim pNgay_Phat_Hanh As SqlParameter = New SqlParameter("@Ngay_Phat_Hanh", SqlDbType.Int, 4)
        '                pNgay_Phat_Hanh.Value = myE1_Di_Chi_Tiet.Ngay_Phat_Hanh
        '                myCommand.Parameters.Add(pNgay_Phat_Hanh)

        '                Dim pGio_Phat_Hanh As SqlParameter = New SqlParameter("@Gio_Phat_Hanh", SqlDbType.Int, 4)
        '                pGio_Phat_Hanh.Value = myE1_Di_Chi_Tiet.Gio_Phat_Hanh
        '                myCommand.Parameters.Add(pGio_Phat_Hanh)

        '                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 4)
        '                pNgay_Dong.Value = myE1_Di_Chi_Tiet.Ngay_Dong
        '                myCommand.Parameters.Add(pNgay_Dong)

        '                Dim pGio_Dong As SqlParameter = New SqlParameter("@Gio_Dong", SqlDbType.Int, 4)
        '                pGio_Dong.Value = myE1_Di_Chi_Tiet.Gio_Dong
        '                myCommand.Parameters.Add(pGio_Dong)

        '                Dim pNgay_Nhan As SqlParameter = New SqlParameter("@Ngay_Nhan", SqlDbType.Int, 4)
        '                pNgay_Nhan.Value = myE1_Di_Chi_Tiet.Ngay_Nhan
        '                myCommand.Parameters.Add(pNgay_Nhan)

        '                Dim pGio_Nhan As SqlParameter = New SqlParameter("@Gio_Nhan", SqlDbType.Int, 4)
        '                pGio_Nhan.Value = myE1_Di_Chi_Tiet.Gio_Nhan
        '                myCommand.Parameters.Add(pGio_Nhan)

        '                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
        '                pMa_Don_Vi.Value = myE1_Di_Chi_Tiet.Ma_Don_Vi
        '                myCommand.Parameters.Add(pMa_Don_Vi)

        '                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 4)
        '                pMa_Bc_Goc.Value = myE1_Di_Chi_Tiet.Ma_Bc_Goc
        '                myCommand.Parameters.Add(pMa_Bc_Goc)

        '                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 4)
        '                pMa_Bc_Tra.Value = myE1_Di_Chi_Tiet.Ma_Bc_Tra
        '                myCommand.Parameters.Add(pMa_Bc_Tra)

        '                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
        '                pNuoc_Nhan.Value = myE1_Di_Chi_Tiet.Nuoc_Nhan
        '                myCommand.Parameters.Add(pNuoc_Nhan)

        '                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2)
        '                pNuoc_Tra.Value = myE1_Di_Chi_Tiet.Nuoc_Tra
        '                myCommand.Parameters.Add(pNuoc_Tra)

        '                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
        '                pKhoi_Luong.Value = myE1_Di_Chi_Tiet.Khoi_Luong
        '                myCommand.Parameters.Add(pKhoi_Luong)

        '                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.VarChar, 1)
        '                pPhan_Loai.Value = myE1_Di_Chi_Tiet.Phan_Loai
        '                myCommand.Parameters.Add(pPhan_Loai)

        '                Dim pLoai_Hang_Hoa As SqlParameter = New SqlParameter("@Loai_Hang_Hoa", SqlDbType.Int, 4)
        '                pLoai_Hang_Hoa.Value = myE1_Di_Chi_Tiet.Loai_Hang_Hoa
        '                myCommand.Parameters.Add(pLoai_Hang_Hoa)

        '                Dim pKhoi_Luong_QD As SqlParameter = New SqlParameter("@Khoi_Luong_QD", SqlDbType.Int, 4)
        '                pKhoi_Luong_QD.Value = myE1_Di_Chi_Tiet.Khoi_Luong_QD
        '                myCommand.Parameters.Add(pKhoi_Luong_QD)

        '                Dim pLoai As SqlParameter = New SqlParameter("@Loai", SqlDbType.Int, 4)
        '                pLoai.Value = myE1_Di_Chi_Tiet.Loai
        '                myCommand.Parameters.Add(pLoai)

        '                Dim pDv_Cong_Them As SqlParameter = New SqlParameter("@Dv_Cong_Them", SqlDbType.VarChar, 50)
        '                pDv_Cong_Them.Value = myE1_Di_Chi_Tiet.Dv_Cong_Them
        '                myCommand.Parameters.Add(pDv_Cong_Them)

        '                Dim pDv_Gia_Tang As SqlParameter = New SqlParameter("@Dv_Gia_Tang", SqlDbType.VarChar, 50)
        '                pDv_Gia_Tang.Value = myE1_Di_Chi_Tiet.Dv_Gia_Tang
        '                myCommand.Parameters.Add(pDv_Gia_Tang)

        '                Dim pPPXD As SqlParameter = New SqlParameter("@PPXD", SqlDbType.Float)
        '                pPPXD.Value = myE1_Di_Chi_Tiet.PPXD
        '                myCommand.Parameters.Add(pPPXD)

        '                Dim pCuoc_PPXD As SqlParameter = New SqlParameter("@Cuoc_PPXD", SqlDbType.Int, 4)
        '                pCuoc_PPXD.Value = myE1_Di_Chi_Tiet.Cuoc_PPXD
        '                myCommand.Parameters.Add(pCuoc_PPXD)

        '                Dim pPostCode As SqlParameter = New SqlParameter("@PostCode", SqlDbType.VarChar, 50)
        '                pPostCode.Value = myE1_Di_Chi_Tiet.PostCode
        '                myCommand.Parameters.Add(pPostCode)

        '                Dim pCuoc_PPVX As SqlParameter = New SqlParameter("@Cuoc_PPVX", SqlDbType.Int, 4)
        '                pCuoc_PPVX.Value = myE1_Di_Chi_Tiet.Cuoc_PPVX
        '                myCommand.Parameters.Add(pCuoc_PPVX)

        '                Dim pVAT As SqlParameter = New SqlParameter("@VAT", SqlDbType.Float)
        '                pVAT.Value = myE1_Di_Chi_Tiet.VAT
        '                myCommand.Parameters.Add(pVAT)

        '                Dim pCOD As SqlParameter = New SqlParameter("@COD", SqlDbType.Bit, 1)
        '                pCOD.Value = myE1_Di_Chi_Tiet.COD
        '                myCommand.Parameters.Add(pCOD)

        '                Dim pGia_Tri_Hang As SqlParameter = New SqlParameter("@Gia_Tri_Hang", SqlDbType.Int, 4)
        '                pGia_Tri_Hang.Value = myE1_Di_Chi_Tiet.Gia_Tri_Hang
        '                myCommand.Parameters.Add(pGia_Tri_Hang)

        '                Dim pCuoc_COD As SqlParameter = New SqlParameter("@Cuoc_COD", SqlDbType.Int, 4)
        '                pCuoc_COD.Value = myE1_Di_Chi_Tiet.Cuoc_COD
        '                myCommand.Parameters.Add(pCuoc_COD)

        '                Dim pCuoc_DV As SqlParameter = New SqlParameter("@Cuoc_DV", SqlDbType.Int, 4)
        '                pCuoc_DV.Value = myE1_Di_Chi_Tiet.Cuoc_DV
        '                myCommand.Parameters.Add(pCuoc_DV)

        '                Dim pCuoc_Chinh As SqlParameter = New SqlParameter("@Cuoc_Chinh", SqlDbType.Int, 4)
        '                pCuoc_Chinh.Value = myE1_Di_Chi_Tiet.Cuoc_Chinh
        '                myCommand.Parameters.Add(pCuoc_Chinh)

        '                Dim pCuoc_Giam As SqlParameter = New SqlParameter("@Cuoc_Giam", SqlDbType.Int, 4)
        '                pCuoc_Giam.Value = myE1_Di_Chi_Tiet.Cuoc_Giam
        '                myCommand.Parameters.Add(pCuoc_Giam)

        '                Dim pCuoc_E1 As SqlParameter = New SqlParameter("@Cuoc_E1", SqlDbType.Int, 4)
        '                pCuoc_E1.Value = myE1_Di_Chi_Tiet.Cuoc_E1
        '                myCommand.Parameters.Add(pCuoc_E1)

        '                Dim pKien_So As SqlParameter = New SqlParameter("@Kien_So", SqlDbType.Int, 4)
        '                pKien_So.Value = myE1_Di_Chi_Tiet.Kien_So
        '                myCommand.Parameters.Add(pKien_So)

        '                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 4)
        '                pSTT.Value = myE1_Di_Chi_Tiet.STT
        '                myCommand.Parameters.Add(pSTT)

        '                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
        '                pMa_KH.Value = myE1_Di_Chi_Tiet.Ma_KH
        '                myCommand.Parameters.Add(pMa_KH)

        '                Dim pNguoi_Gui As SqlParameter = New SqlParameter("@Nguoi_Gui", SqlDbType.VarChar, 100)
        '                pNguoi_Gui.Value = myE1_Di_Chi_Tiet.Nguoi_Gui
        '                myCommand.Parameters.Add(pNguoi_Gui)

        '                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.VarChar, 100)
        '                pNguoi_Nhan.Value = myE1_Di_Chi_Tiet.Nguoi_Nhan
        '                myCommand.Parameters.Add(pNguoi_Nhan)

        '                Dim pDia_Chi_Gui As SqlParameter = New SqlParameter("@Dia_Chi_Gui", SqlDbType.VarChar, 200)
        '                pDia_Chi_Gui.Value = myE1_Di_Chi_Tiet.Dia_Chi_Gui
        '                myCommand.Parameters.Add(pDia_Chi_Gui)

        '                Dim pDia_Chi_Nhan As SqlParameter = New SqlParameter("@Dia_Chi_Nhan", SqlDbType.VarChar, 200)
        '                pDia_Chi_Nhan.Value = myE1_Di_Chi_Tiet.Dia_Chi_Nhan
        '                myCommand.Parameters.Add(pDia_Chi_Nhan)

        '                Dim pDien_Thoai_Gui As SqlParameter = New SqlParameter("@Dien_Thoai_Gui", SqlDbType.VarChar, 50)
        '                pDien_Thoai_Gui.Value = myE1_Di_Chi_Tiet.Dien_Thoai_Gui
        '                myCommand.Parameters.Add(pDien_Thoai_Gui)

        '                Dim pDien_Thoai_Nhan As SqlParameter = New SqlParameter("@Dien_Thoai_Nhan", SqlDbType.VarChar, 50)
        '                pDien_Thoai_Nhan.Value = myE1_Di_Chi_Tiet.Dien_Thoai_Nhan
        '                myCommand.Parameters.Add(pDien_Thoai_Nhan)

        '                Dim pHH_Phat_Hanh As SqlParameter = New SqlParameter("@HH_Phat_Hanh", SqlDbType.Int, 4)
        '                pHH_Phat_Hanh.Value = myE1_Di_Chi_Tiet.HH_Phat_Hanh
        '                myCommand.Parameters.Add(pHH_Phat_Hanh)

        '                Dim pHH_Phat_Tra As SqlParameter = New SqlParameter("@HH_Phat_Tra", SqlDbType.Int, 4)
        '                pHH_Phat_Tra.Value = myE1_Di_Chi_Tiet.HH_Phat_Tra
        '                myCommand.Parameters.Add(pHH_Phat_Tra)

        '                Dim pMa_Bc_CH As SqlParameter = New SqlParameter("@Ma_Bc_CH", SqlDbType.Int, 4)
        '                pMa_Bc_CH.Value = myE1_Di_Chi_Tiet.Ma_Bc_CH
        '                myCommand.Parameters.Add(pMa_Bc_CH)

        '                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 4)
        '                pId_Nguoi_Dung.Value = myE1_Di_Chi_Tiet.Id_Nguoi_Dung
        '                myCommand.Parameters.Add(pId_Nguoi_Dung)

        '                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.Int, 4)
        '                pId_Trang_Thai.Value = myE1_Di_Chi_Tiet.Id_Trang_Thai
        '                myCommand.Parameters.Add(pId_Trang_Thai)

        '                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 200)
        '                pGhi_Chu.Value = myE1_Di_Chi_Tiet.Ghi_Chu
        '                myCommand.Parameters.Add(pGhi_Chu)

        '                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
        '                pTruyen_Khai_Thac.Value = myE1_Di_Chi_Tiet.Truyen_Khai_Thac
        '                myCommand.Parameters.Add(pTruyen_Khai_Thac)

        '                Dim pTruyen_Doi_Soat As SqlParameter = New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 1)
        '                pTruyen_Doi_Soat.Value = myE1_Di_Chi_Tiet.Truyen_Doi_Soat
        '                myCommand.Parameters.Add(pTruyen_Doi_Soat)

        '                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
        '                pNgay_He_Thong.Value = myE1_Di_Chi_Tiet.Ngay_He_Thong
        '                myCommand.Parameters.Add(pNgay_He_Thong)

        '                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 1)
        '                pChot_SL.Value = myE1_Di_Chi_Tiet.Chot_SL
        '                myCommand.Parameters.Add(pChot_SL)


        '                myConnection.Open()
        '                myCommand.ExecuteNonQuery()
        '                myConnection.Close()
        '            Catch ex As Exception
        '                Console.Write(ex.ToString)

        '            End Try
        '        End Sub
        '#End Region


        '#Region "Xoa"
        '        ' Ngày t?o: 15/6/08
        '        ' Ngu?i t?o: Nguy?n B?ng
        '        ' N?i dung: Xóa d? li?u t? b?ng Tmp_E1_Di
        '        ' Input: Id_E1
        '        ' Output: 
        '        Public Sub Xoa(ByVal Id_E1 As String)
        '            Try
        '                ' T?o d?i tu?ng connection và command
        '                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
        '                Dim myCommand As SqlCommand = New SqlCommand("Tmp_E1_Di_Xoa", myConnection)

        '                ' S? d?ng Store Procedure
        '                myCommand.CommandType = CommandType.StoredProcedure
        '                ' Thêm các Parameters vào th? t?c
        '                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
        '                pId_E1.Value = Id_E1
        '                myCommand.Parameters.Add(pId_E1)

        '                myConnection.Open()
        '                myCommand.ExecuteNonQuery()
        '                myConnection.Close()
        '            Catch ex As Exception
        '                Console.Write(ex.ToString)


        '            End Try
        '        End Sub
        '#End Region
        '#Region "Danh_Sach"
        '        ' Ngày t?o: 15/6/08
        '        ' Ngu?i t?o: Nguy?n B?ng
        '        ' N?i dung: L?y toàn b? d? li?u t? b?ng E1_Di
        '        ' Input: 
        '        ' Output: DataSet ch?a toàn b? d? li?u l?y v? 
        '        Public Function Danh_Sach() As DataSet
        '            Try
        '                ' T?o d?i tu?ng connection và command
        '                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
        '                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Danh_Sach", myConnection)
        '                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
        '                Dim myDataSet As DataSet = New DataSet

        '                ' S? d?ng Store Procedure
        '                myCommand.CommandType = CommandType.StoredProcedure

        '                myConnection.Open()
        '                myAdapter.SelectCommand = myCommand
        '                myAdapter.Fill(myDataSet, "E1_Di_Danh_Sach")
        '                myConnection.Close()
        '                Return myDataSet
        '            Catch ex As Exception
        '                Console.Write(ex.ToString)

        '            End Try
        '        End Function
        '#End Region

        '#Region "Lay_Boi_Chuyen_Thu_Di"
        '        ' Ngày t?o: 15/6/08
        '        ' Ngu?i t?o: Nguy?n B?ng
        '        ' N?i dung: L?y d? li?u t? b?ng Chuyen_Thu_Di thông qua khóa chính 
        '        ' Input: Id_Chuyen_Thu
        '        ' Output: DataSet ch?a toàn b? d? li?u l?y v? 
        '        Public Function Lay_Boi_Chuyen_Thu_Di(ByVal Id_Chuyen_Thu As String) As DataSet
        '            Try
        '                ' T?o d?i tu?ng connection và command
        '                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
        '                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Lay_Boi_Chuyen_Thu_Di", myConnection)
        '                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
        '                Dim myDataSet As DataSet = New DataSet

        '                ' S? d?ng Store Procedure
        '                myCommand.CommandType = CommandType.StoredProcedure
        '                ' Thêm các Parameters vào th? t?c
        '                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
        '                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
        '                myCommand.Parameters.Add(pId_Chuyen_Thu)

        '                myConnection.Open()
        '                myAdapter.SelectCommand = myCommand
        '                myAdapter.Fill(myDataSet, "E1_Di_Lay_Boi_Chuyen_Thu_Di")
        '                myConnection.Close()
        '                Return myDataSet
        '            Catch ex As Exception
        '                Console.Write(ex.ToString)
        '            End Try
        '        End Function
        '#End Region
        '#Region "Lay_Boi_Ca_San_Xuat"
        '        ' Ngày t?o: 15/6/08
        '        ' Ngu?i t?o: Nguy?n B?ng
        '        ' N?i dung: L?y d? li?u t? b?ng Ca_San_Xuat thông qua khóa chính 
        '        ' Input: Id_Ca
        '        ' Output: DataSet ch?a toàn b? d? li?u l?y v? 
        '        Public Function Lay_Boi_Ca_San_Xuat(ByVal Id_Ca As String) As DataSet
        '            Try
        '                ' T?o d?i tu?ng connection và command
        '                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
        '                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Lay_Boi_Ca_San_Xuat", myConnection)
        '                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
        '                Dim myDataSet As DataSet = New DataSet

        '                ' S? d?ng Store Procedure
        '                myCommand.CommandType = CommandType.StoredProcedure
        '                ' Thêm các Parameters vào th? t?c
        '                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
        '                pId_Ca.Value = Id_Ca
        '                myCommand.Parameters.Add(pId_Ca)

        '                myConnection.Open()
        '                myAdapter.SelectCommand = myCommand
        '                myAdapter.Fill(myDataSet, "E1_Di_Lay_Boi_Ca_San_Xuat")
        '                myConnection.Close()
        '                Return myDataSet
        '            Catch ex As Exception
        '                Console.Write(ex.ToString)
        '            End Try
        '        End Function
        '#End Region
        '#Region "Lay_Boi_Duong_Thu_Di"
        '        ' Ngày t?o: 15/6/08
        '        ' Ngu?i t?o: Nguy?n B?ng
        '        ' N?i dung: L?y d? li?u t? b?ng Duong_Thu_Di thông qua khóa chính 
        '        ' Input: Id_Duong_Thu
        '        ' Output: DataSet ch?a toàn b? d? li?u l?y v? 
        '        Public Function Lay_Boi_Duong_Thu_Di(ByVal Id_Duong_Thu As String) As DataSet
        '            Try
        '                ' T?o d?i tu?ng connection và command
        '                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
        '                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Lay_Boi_Duong_Thu_Di", myConnection)
        '                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
        '                Dim myDataSet As DataSet = New DataSet

        '                ' S? d?ng Store Procedure
        '                myCommand.CommandType = CommandType.StoredProcedure
        '                ' Thêm các Parameters vào th? t?c
        '                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
        '                pId_Duong_Thu.Value = Id_Duong_Thu
        '                myCommand.Parameters.Add(pId_Duong_Thu)

        '                myConnection.Open()
        '                myAdapter.SelectCommand = myCommand
        '                myAdapter.Fill(myDataSet, "E1_Di_Lay_Boi_Duong_Thu_Di")
        '                myConnection.Close()
        '                Return myDataSet
        '            Catch ex As Exception
        '                Console.Write(ex.ToString)
        '            End Try
        '        End Function
        '#End Region
        '#Region "Lay_Boi_Ma_Bc_Khai_Thac"
        '        ' Ngày t?o: 15/6/08
        '        ' Ngu?i t?o: Nguy?n B?ng
        '        ' N?i dung: L?y d? li?u t? b?ng Ma_Bc_Khai_Thac thông qua khóa chính 
        '        ' Input: Ma_Bc_Khai_Thac
        '        ' Output: DataSet ch?a toàn b? d? li?u l?y v? 
        '        Public Function Lay_Boi_Ma_Bc_Khai_Thac(ByVal Ma_Bc_Khai_Thac As Integer) As DataSet
        '            Try
        '                ' T?o d?i tu?ng connection và command
        '                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
        '                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Lay_Boi_Ma_Bc_Khai_Thac", myConnection)
        '                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
        '                Dim myDataSet As DataSet = New DataSet

        '                ' S? d?ng Store Procedure
        '                myCommand.CommandType = CommandType.StoredProcedure
        '                ' Thêm các Parameters vào th? t?c
        '                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
        '                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
        '                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

        '                myConnection.Open()
        '                myAdapter.SelectCommand = myCommand
        '                myAdapter.Fill(myDataSet, "E1_Di_Lay_Boi_Ma_Bc_Khai_Thac")
        '                myConnection.Close()
        '                Return myDataSet
        '            Catch ex As Exception
        '                Console.Write(ex.ToString)
        '            End Try
        '        End Function
        '#End Region
        '#Region "E1_Di_Lay_Boi_E2_Di"
        '        ' Ngày t?o: 15/6/08
        '        ' Ngu?i t?o: Nguy?n B?ng
        '        ' N?i dung: L?y d? li?u t? b?ng E2_Di thông qua khóa chính 
        '        ' Input: Id_E2
        '        ' Output: DataSet ch?a toàn b? d? li?u l?y v? 
        '        Public Function E1_Di_Lay_Boi_E2_Di(ByVal Id_E2 As String) As DataSet
        '            Try
        '                ' T?o d?i tu?ng connection và command
        '                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
        '                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Lay_Boi_E2_Di", myConnection)
        '                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
        '                Dim myDataSet As DataSet = New DataSet

        '                ' S? d?ng Store Procedure
        '                myCommand.CommandType = CommandType.StoredProcedure
        '                ' Thêm các Parameters vào th? t?c
        '                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
        '                pId_E2.Value = Id_E2
        '                myCommand.Parameters.Add(pId_E2)

        '                myConnection.Open()
        '                myAdapter.SelectCommand = myCommand
        '                myAdapter.Fill(myDataSet, "E1_Di_Lay_Boi_E2_Di")
        '                myConnection.Close()
        '                Return myDataSet
        '            Catch ex As Exception
        '                Console.Write(ex.ToString)
        '            End Try
        '        End Function
        '#End Region

        '#Region "Lay_Boi_Quay_Giao_Dich"
        '        ' Ngày t?o: 15/6/08
        '        ' Ngu?i t?o: Nguy?n B?ng
        '        ' N?i dung: L?y d? li?u t? b?ng Quay_Giao_Dich thông qua khóa chính 
        '        ' Input: Ma_Quay
        '        ' Output: DataSet ch?a toàn b? d? li?u l?y v? 
        '        Public Function Lay_Boi_Quay_Giao_Dich(ByVal Ma_Quay As Integer) As DataSet
        '            Try
        '                ' T?o d?i tu?ng connection và command
        '                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
        '                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Lay_Boi_Quay_Giao_Dich", myConnection)
        '                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
        '                Dim myDataSet As DataSet = New DataSet

        '                ' S? d?ng Store Procedure
        '                myCommand.CommandType = CommandType.StoredProcedure
        '                ' Thêm các Parameters vào th? t?c
        '                Dim pMa_Quay As SqlParameter = New SqlParameter("@Ma_Quay", SqlDbType.Int, 4)
        '                pMa_Quay.Value = Ma_Quay
        '                myCommand.Parameters.Add(pMa_Quay)

        '                myConnection.Open()
        '                myAdapter.SelectCommand = myCommand
        '                myAdapter.Fill(myDataSet, "E1_Di_Lay_Boi_Quay_Giao_Dich")
        '                myConnection.Close()
        '                Return myDataSet
        '            Catch ex As Exception
        '                Console.Write(ex.ToString)
        '            End Try
        '        End Function
        '#End Region
        '#Region "Lay_Boi_Khach_Hang"
        '        ' Ngày t?o: 15/6/08
        '        ' Ngu?i t?o: Nguy?n B?ng
        '        ' N?i dung: L?y d? li?u t? b?ng Khach_Hang thông qua khóa chính 
        '        ' Input: Ma_KH
        '        ' Output: DataSet ch?a toàn b? d? li?u l?y v? 
        '        Public Function Lay_Boi_Khach_Hang(ByVal Ma_KH As String) As DataSet
        '            Try
        '                ' T?o d?i tu?ng connection và command
        '                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
        '                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Lay_Boi_Khach_Hang", myConnection)
        '                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
        '                Dim myDataSet As DataSet = New DataSet

        '                ' S? d?ng Store Procedure
        '                myCommand.CommandType = CommandType.StoredProcedure
        '                ' Thêm các Parameters vào th? t?c
        '                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
        '                pMa_KH.Value = Ma_KH
        '                myCommand.Parameters.Add(pMa_KH)

        '                myConnection.Open()
        '                myAdapter.SelectCommand = myCommand
        '                myAdapter.Fill(myDataSet, "E1_Di_Lay_Boi_Khach_Hang")
        '                myConnection.Close()
        '                Return myDataSet
        '            Catch ex As Exception
        '                Console.Write(ex.ToString)
        '            End Try
        '        End Function
        '#End Region
        '#Region "Lay_Tong_So_E1"
        '        Public Function Lay_Tong_So_E1(ByVal myId_E2 As String) As Integer
        '            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
        '            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
        '            Dim myCommand As SqlCommand
        '            Dim ReturnValue As Integer

        '            myCommand = New SqlCommand("Select count(*) from E1_Di where Id_E2= '" & myId_E2 & "'", myConnection)

        '            myConnection.Open()
        '            myCommand.CommandType = CommandType.Text
        '            myAdapter.SelectCommand = myCommand
        '            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
        '            myConnection.Close()

        '            Return ReturnValue
        '        End Function
        '#End Region

        '#Region "Khai Thác"
        '#Region "Tmp_E1_Di_Insert_To_E1_Di_KT"
        '        ' Ngày tạo: 01/07/08
        '        ' Người tạo: Đỗ Quốc Khánh
        '        ' Nội dung: Insert dữ liệu từ bảng tạm (Tmp_E1_Di) sang bảng chính (E1_Di)
        '        ' Input: Id_E2
        '        Public Sub Tmp_E1_Di_Insert_To_E1_Di_KT(ByVal Id_E2 As String)
        '            Try
        '                ' Tạo đối tượng connection và command
        '                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
        '                Dim myCommand As SqlCommand = New SqlCommand("Tmp_E1_Di_Insert_To_E1_Di_KT", myConnection)
        '                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
        '                Dim myDataSet As DataSet = New DataSet

        '                ' Sử dụng Store Procedure
        '                myCommand.CommandType = CommandType.StoredProcedure
        '                ' Thêm các Parameters vào thủ tục
        '                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
        '                pId_E2.Value = Id_E2
        '                myCommand.Parameters.Add(pId_E2)

        '                myConnection.Open()
        '                myAdapter.SelectCommand = myCommand
        '                myAdapter.Fill(myDataSet, "Tmp_E1_Di_Insert_To_E1_Di_KT")
        '                myConnection.Close()
        '            Catch ex As Exception
        '                Console.Write(ex.ToString)
        '            End Try
        '        End Sub
        '#End Region
        '#Region "Tmp_E1_Di_Xoa_Theo_Id_E2_KT"
        '        ' Ngày tạo: 01/07/08
        '        ' Người tạo: Đỗ Quốc Khánh
        '        ' Nội dung: Xóa dữ liệu từ bảng Tmp_E1_Di theo Id_E2
        '        ' Input: Id_E2
        '        ' Output: 
        '        Public Sub Tmp_E1_Di_Xoa_Theo_Id_E2_KT(ByVal Id_E2 As String)
        '            Try
        '                ' Tạo đối tượng connection và command
        '                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
        '                Dim myCommand As SqlCommand = New SqlCommand("Tmp_E1_Di_Xoa_Theo_Id_E2_KT", myConnection)

        '                ' Sử dụng Store Procedure
        '                myCommand.CommandType = CommandType.StoredProcedure
        '                ' Thêm các Parameters vào thủ tục
        '                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 48)
        '                pId_E2.Value = Id_E2
        '                myCommand.Parameters.Add(pId_E2)

        '                myConnection.Open()
        '                myCommand.ExecuteNonQuery()
        '                myConnection.Close()
        '            Catch ex As Exception
        '                Console.Write(ex.ToString)

        '            End Try
        '        End Sub
        '#End Region
        '#Region "Tmp_E1_Di_Lay_Boi_E2_Di_KT"
        '        ' Ngày tạo: 26/6/08
        '        ' Người tạo: Đỗ Quốc Khánh
        '        ' Nội dung: Lấy dữ liệu từ bảng E2_Di thông qua khóa chính 
        '        ' Input: Id_E2
        '        ' Output: DataSet chứa toàn bộ dữ liệu về
        '        Public Function Tmp_E1_Di_Lay_Boi_Id_E2_KT(ByVal Id_E2 As String) As DataSet
        '            Try
        '                ' T?o d?i tu?ng connection và command
        '                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
        '                Dim myCommand As SqlCommand = New SqlCommand("Tmp_E1_Di_Lay_Boi_Id_E2_KT", myConnection)
        '                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
        '                Dim myDataSet As DataSet = New DataSet

        '                ' S? d?ng Store Procedure
        '                myCommand.CommandType = CommandType.StoredProcedure
        '                ' Thêm các Parameters vào th? t?c
        '                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
        '                pId_E2.Value = Id_E2
        '                myCommand.Parameters.Add(pId_E2)

        '                myConnection.Open()
        '                myAdapter.SelectCommand = myCommand
        '                myAdapter.Fill(myDataSet, "Tmp_E1_Di_Lay_Boi_Id_E2_KT")
        '                myConnection.Close()
        '                Return myDataSet
        '            Catch ex As Exception
        '                Console.Write(ex.ToString)
        '            End Try
        '        End Function
        '#End Region
        '#Region "Tmp_E1_Di_Cap_Nhat_Them_KT"
        '        ' Ngày tạo: 28/6/08
        '        ' Người tạo: Đỗ Quốc Khánh
        '        ' Nội dung: Cập nhật thêm dữ liệu v
        '        ' Input: Id_E1,  Id_Duong_Thu , Id_Chuyen_Thu , Id_E2 , Id_Ca , Ma_Bc_Khai_Thac , Ma_Quay , Ma_E1 , Ngay_Phat_Hanh , Gio_Phat_Hanh , Ngay_Dong , Gio_Dong , Ngay_Nhan , Gio_Nhan , Ma_Don_Vi , Ma_Bc_Goc , Ma_Bc_Tra , Nuoc_Nhan , Nuoc_Tra , Khoi_Luong , Phan_Loai , Loai_Hang_Hoa , Khoi_Luong_QD , Loai , Dv_Cong_Them , Dv_Gia_Tang , PPXD , Cuoc_PPXD , PostCode , Cuoc_PPVX , VAT , COD , Gia_Tri_Hang , Cuoc_COD , Cuoc_DV , Cuoc_Chinh , Cuoc_Giam , Cuoc_E1 , Kien_So , STT , Ma_KH , Nguoi_Gui , Nguoi_Nhan , Dia_Chi_Gui , Dia_Chi_Nhan , Dien_Thoai_Gui , Dien_Thoai_Nhan , HH_Phat_Hanh , HH_Phat_Tra , Ma_Bc_CH , Id_Nguoi_Dung , Id_Trang_Thai , Ghi_Chu , Truyen_Khai_Thac , Truyen_Doi_Soat , Chot_SL ,
        '        ' Output: 
        '        Public Sub Tmp_E1_Di_Cap_Nhat_Them_KT(ByVal Id_E1 As String, ByVal Id_Duong_Thu As String, ByVal Id_Chuyen_Thu As String, ByVal Id_E2 As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Quay As Integer, ByVal Ma_E1 As String, ByVal Ngay_Phat_Hanh As Integer, ByVal Gio_Phat_Hanh As Integer, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Ma_Don_Vi As String, ByVal Ma_Bc_Goc As Integer, ByVal Ma_Bc_Tra As Integer, ByVal Nuoc_Nhan As String, ByVal Nuoc_Tra As String, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal Loai_Hang_Hoa As Integer, ByVal Khoi_Luong_QD As Integer, ByVal Loai As Integer, ByVal Dv_Cong_Them As String, ByVal Dv_Gia_Tang As String, ByVal PPXD As Double, ByVal Cuoc_PPXD As Integer, ByVal PostCode As String, ByVal Cuoc_PPVX As Integer, ByVal VAT As Double, ByVal COD As Boolean, ByVal Gia_Tri_Hang As Integer, ByVal Cuoc_COD As Integer, ByVal Cuoc_DV As Integer, ByVal Cuoc_Chinh As Integer, ByVal Cuoc_Giam As Integer, ByVal Cuoc_E1 As Integer, ByVal Kien_So As Integer, ByVal STT As Integer, ByVal Ma_KH As String, ByVal Nguoi_Gui As String, ByVal Nguoi_Nhan As String, ByVal Dia_Chi_Gui As String, ByVal Dia_Chi_Nhan As String, ByVal Dien_Thoai_Gui As String, ByVal Dien_Thoai_Nhan As String, ByVal HH_Phat_Hanh As Integer, ByVal HH_Phat_Tra As Integer, ByVal Ma_Bc_CH As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Id_Trang_Thai As Integer, ByVal Ghi_Chu As String, ByVal Truyen_Khai_Thac As Boolean, ByVal Truyen_Doi_Soat As Boolean, ByVal Chot_SL As Boolean)
        '            Try
        '                ' T?o d?i tu?ng connection và command
        '                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
        '                Dim myCommand As SqlCommand = New SqlCommand("Tmp_E1_Di_Cap_Nhat_Them_KT", myConnection)

        '                ' S? d?ng Store Procedure
        '                myCommand.CommandType = CommandType.StoredProcedure
        '                ' Thêm các Parameters vào th? t?c
        '                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
        '                pId_E1.Value = Id_E1
        '                myCommand.Parameters.Add(pId_E1)

        '                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
        '                pId_Duong_Thu.Value = Id_Duong_Thu
        '                myCommand.Parameters.Add(pId_Duong_Thu)

        '                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
        '                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
        '                myCommand.Parameters.Add(pId_Chuyen_Thu)

        '                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
        '                pId_E2.Value = Id_E2
        '                myCommand.Parameters.Add(pId_E2)

        '                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
        '                pId_Ca.Value = Id_Ca
        '                myCommand.Parameters.Add(pId_Ca)

        '                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
        '                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
        '                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

        '                Dim pMa_Quay As SqlParameter = New SqlParameter("@Ma_Quay", SqlDbType.Int, 4)
        '                pMa_Quay.Value = Ma_Quay
        '                myCommand.Parameters.Add(pMa_Quay)

        '                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
        '                pMa_E1.Value = Ma_E1
        '                myCommand.Parameters.Add(pMa_E1)

        '                Dim pNgay_Phat_Hanh As SqlParameter = New SqlParameter("@Ngay_Phat_Hanh", SqlDbType.Int, 4)
        '                pNgay_Phat_Hanh.Value = Ngay_Phat_Hanh
        '                myCommand.Parameters.Add(pNgay_Phat_Hanh)

        '                Dim pGio_Phat_Hanh As SqlParameter = New SqlParameter("@Gio_Phat_Hanh", SqlDbType.Int, 4)
        '                pGio_Phat_Hanh.Value = Gio_Phat_Hanh
        '                myCommand.Parameters.Add(pGio_Phat_Hanh)

        '                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 4)
        '                pNgay_Dong.Value = Ngay_Dong
        '                myCommand.Parameters.Add(pNgay_Dong)

        '                Dim pGio_Dong As SqlParameter = New SqlParameter("@Gio_Dong", SqlDbType.Int, 4)
        '                pGio_Dong.Value = Gio_Dong
        '                myCommand.Parameters.Add(pGio_Dong)

        '                Dim pNgay_Nhan As SqlParameter = New SqlParameter("@Ngay_Nhan", SqlDbType.Int, 4)
        '                pNgay_Nhan.Value = Ngay_Nhan
        '                myCommand.Parameters.Add(pNgay_Nhan)

        '                Dim pGio_Nhan As SqlParameter = New SqlParameter("@Gio_Nhan", SqlDbType.Int, 4)
        '                pGio_Nhan.Value = Gio_Nhan
        '                myCommand.Parameters.Add(pGio_Nhan)

        '                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
        '                pMa_Don_Vi.Value = Ma_Don_Vi
        '                myCommand.Parameters.Add(pMa_Don_Vi)

        '                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 4)
        '                pMa_Bc_Goc.Value = Ma_Bc_Goc
        '                myCommand.Parameters.Add(pMa_Bc_Goc)

        '                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 4)
        '                pMa_Bc_Tra.Value = Ma_Bc_Tra
        '                myCommand.Parameters.Add(pMa_Bc_Tra)

        '                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
        '                pNuoc_Nhan.Value = Nuoc_Nhan
        '                myCommand.Parameters.Add(pNuoc_Nhan)

        '                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2)
        '                pNuoc_Tra.Value = Nuoc_Tra
        '                myCommand.Parameters.Add(pNuoc_Tra)

        '                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
        '                pKhoi_Luong.Value = Khoi_Luong
        '                myCommand.Parameters.Add(pKhoi_Luong)

        '                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.VarChar, 1)
        '                pPhan_Loai.Value = Phan_Loai
        '                myCommand.Parameters.Add(pPhan_Loai)

        '                Dim pLoai_Hang_Hoa As SqlParameter = New SqlParameter("@Loai_Hang_Hoa", SqlDbType.Int, 4)
        '                pLoai_Hang_Hoa.Value = Loai_Hang_Hoa
        '                myCommand.Parameters.Add(pLoai_Hang_Hoa)

        '                Dim pKhoi_Luong_QD As SqlParameter = New SqlParameter("@Khoi_Luong_QD", SqlDbType.Int, 4)
        '                pKhoi_Luong_QD.Value = Khoi_Luong_QD
        '                myCommand.Parameters.Add(pKhoi_Luong_QD)

        '                Dim pLoai As SqlParameter = New SqlParameter("@Loai", SqlDbType.Int, 4)
        '                pLoai.Value = Loai
        '                myCommand.Parameters.Add(pLoai)

        '                Dim pDv_Cong_Them As SqlParameter = New SqlParameter("@Dv_Cong_Them", SqlDbType.VarChar, 50)
        '                pDv_Cong_Them.Value = Dv_Cong_Them
        '                myCommand.Parameters.Add(pDv_Cong_Them)

        '                Dim pDv_Gia_Tang As SqlParameter = New SqlParameter("@Dv_Gia_Tang", SqlDbType.VarChar, 50)
        '                pDv_Gia_Tang.Value = Dv_Gia_Tang
        '                myCommand.Parameters.Add(pDv_Gia_Tang)

        '                Dim pPPXD As SqlParameter = New SqlParameter("@PPXD", SqlDbType.Float)
        '                pPPXD.Value = PPXD
        '                myCommand.Parameters.Add(pPPXD)

        '                Dim pCuoc_PPXD As SqlParameter = New SqlParameter("@Cuoc_PPXD", SqlDbType.Int, 4)
        '                pCuoc_PPXD.Value = Cuoc_PPXD
        '                myCommand.Parameters.Add(pCuoc_PPXD)

        '                Dim pPostCode As SqlParameter = New SqlParameter("@PostCode", SqlDbType.VarChar, 50)
        '                pPostCode.Value = PostCode
        '                myCommand.Parameters.Add(pPostCode)

        '                Dim pCuoc_PPVX As SqlParameter = New SqlParameter("@Cuoc_PPVX", SqlDbType.Int, 4)
        '                pCuoc_PPVX.Value = Cuoc_PPVX
        '                myCommand.Parameters.Add(pCuoc_PPVX)

        '                Dim pVAT As SqlParameter = New SqlParameter("@VAT", SqlDbType.Float)
        '                pVAT.Value = VAT
        '                myCommand.Parameters.Add(pVAT)

        '                Dim pCOD As SqlParameter = New SqlParameter("@COD", SqlDbType.Bit, 1)
        '                pCOD.Value = COD
        '                myCommand.Parameters.Add(pCOD)

        '                Dim pGia_Tri_Hang As SqlParameter = New SqlParameter("@Gia_Tri_Hang", SqlDbType.Int, 4)
        '                pGia_Tri_Hang.Value = Gia_Tri_Hang
        '                myCommand.Parameters.Add(pGia_Tri_Hang)

        '                Dim pCuoc_COD As SqlParameter = New SqlParameter("@Cuoc_COD", SqlDbType.Int, 4)
        '                pCuoc_COD.Value = Cuoc_COD
        '                myCommand.Parameters.Add(pCuoc_COD)

        '                Dim pCuoc_DV As SqlParameter = New SqlParameter("@Cuoc_DV", SqlDbType.Int, 4)
        '                pCuoc_DV.Value = Cuoc_DV
        '                myCommand.Parameters.Add(pCuoc_DV)

        '                Dim pCuoc_Chinh As SqlParameter = New SqlParameter("@Cuoc_Chinh", SqlDbType.Int, 4)
        '                pCuoc_Chinh.Value = Cuoc_Chinh
        '                myCommand.Parameters.Add(pCuoc_Chinh)

        '                Dim pCuoc_Giam As SqlParameter = New SqlParameter("@Cuoc_Giam", SqlDbType.Int, 4)
        '                pCuoc_Giam.Value = Cuoc_Giam
        '                myCommand.Parameters.Add(pCuoc_Giam)

        '                Dim pCuoc_E1 As SqlParameter = New SqlParameter("@Cuoc_E1", SqlDbType.Int, 4)
        '                pCuoc_E1.Value = Cuoc_E1
        '                myCommand.Parameters.Add(pCuoc_E1)

        '                Dim pKien_So As SqlParameter = New SqlParameter("@Kien_So", SqlDbType.Int, 4)
        '                pKien_So.Value = Kien_So
        '                myCommand.Parameters.Add(pKien_So)

        '                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 4)
        '                pSTT.Value = STT
        '                myCommand.Parameters.Add(pSTT)

        '                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
        '                pMa_KH.Value = Ma_KH
        '                myCommand.Parameters.Add(pMa_KH)

        '                Dim pNguoi_Gui As SqlParameter = New SqlParameter("@Nguoi_Gui", SqlDbType.VarChar, 100)
        '                pNguoi_Gui.Value = Nguoi_Gui
        '                myCommand.Parameters.Add(pNguoi_Gui)

        '                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.VarChar, 100)
        '                pNguoi_Nhan.Value = Nguoi_Nhan
        '                myCommand.Parameters.Add(pNguoi_Nhan)

        '                Dim pDia_Chi_Gui As SqlParameter = New SqlParameter("@Dia_Chi_Gui", SqlDbType.VarChar, 200)
        '                pDia_Chi_Gui.Value = Dia_Chi_Gui
        '                myCommand.Parameters.Add(pDia_Chi_Gui)

        '                Dim pDia_Chi_Nhan As SqlParameter = New SqlParameter("@Dia_Chi_Nhan", SqlDbType.VarChar, 200)
        '                pDia_Chi_Nhan.Value = Dia_Chi_Nhan
        '                myCommand.Parameters.Add(pDia_Chi_Nhan)

        '                Dim pDien_Thoai_Gui As SqlParameter = New SqlParameter("@Dien_Thoai_Gui", SqlDbType.VarChar, 50)
        '                pDien_Thoai_Gui.Value = Dien_Thoai_Gui
        '                myCommand.Parameters.Add(pDien_Thoai_Gui)

        '                Dim pDien_Thoai_Nhan As SqlParameter = New SqlParameter("@Dien_Thoai_Nhan", SqlDbType.VarChar, 50)
        '                pDien_Thoai_Nhan.Value = Dien_Thoai_Nhan
        '                myCommand.Parameters.Add(pDien_Thoai_Nhan)

        '                Dim pHH_Phat_Hanh As SqlParameter = New SqlParameter("@HH_Phat_Hanh", SqlDbType.Int, 4)
        '                pHH_Phat_Hanh.Value = HH_Phat_Hanh
        '                myCommand.Parameters.Add(pHH_Phat_Hanh)

        '                Dim pHH_Phat_Tra As SqlParameter = New SqlParameter("@HH_Phat_Tra", SqlDbType.Int, 4)
        '                pHH_Phat_Tra.Value = HH_Phat_Tra
        '                myCommand.Parameters.Add(pHH_Phat_Tra)

        '                Dim pMa_Bc_CH As SqlParameter = New SqlParameter("@Ma_Bc_CH", SqlDbType.Int, 4)
        '                pMa_Bc_CH.Value = Ma_Bc_CH
        '                myCommand.Parameters.Add(pMa_Bc_CH)

        '                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 4)
        '                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
        '                myCommand.Parameters.Add(pId_Nguoi_Dung)

        '                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.Int, 4)
        '                pId_Trang_Thai.Value = Id_Trang_Thai
        '                myCommand.Parameters.Add(pId_Trang_Thai)

        '                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 200)
        '                pGhi_Chu.Value = Ghi_Chu
        '                myCommand.Parameters.Add(pGhi_Chu)

        '                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
        '                pTruyen_Khai_Thac.Value = Truyen_Khai_Thac
        '                myCommand.Parameters.Add(pTruyen_Khai_Thac)

        '                Dim pTruyen_Doi_Soat As SqlParameter = New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 1)
        '                pTruyen_Doi_Soat.Value = Truyen_Doi_Soat
        '                myCommand.Parameters.Add(pTruyen_Doi_Soat)

        '                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 1)
        '                pChot_SL.Value = Chot_SL
        '                myCommand.Parameters.Add(pChot_SL)


        '                myConnection.Open()
        '                myCommand.ExecuteNonQuery()
        '                myConnection.Close()
        '            Catch ex As Exception
        '                Console.Write(ex.ToString)
        '            End Try
        '        End Sub
        '#End Region
        '#Region "Tmp_E1_Di_Lay_Boi_E2_Loi_KT"
        '        ' Ngày tạo: 02/08/08
        '        ' Người tạo: Đỗ Quốc Khánh
        '        ' Nội dung: Lấy lại dữ liệu bản kê E2 lỗi sau khi xóa bản kê e2_lỗi (Tờ E2 này đang được người khác cập nhật)
        '        ' Input: Id_E1,  Id_Duong_Thu , Id_Chuyen_Thu , Id_E2 , Id_Ca , Ma_Bc_Khai_Thac , Ma_Quay , Ma_E1 , Ngay_Phat_Hanh , Gio_Phat_Hanh , Ngay_Dong , Gio_Dong , Ngay_Nhan , Gio_Nhan , Ma_Don_Vi , Ma_Bc_Goc , Ma_Bc_Tra , Nuoc_Nhan , Nuoc_Tra , Khoi_Luong , Phan_Loai , Loai_Hang_Hoa , Khoi_Luong_QD , Loai , Dv_Cong_Them , Dv_Gia_Tang , PPXD , Cuoc_PPXD , PostCode , Cuoc_PPVX , VAT , COD , Gia_Tri_Hang , Cuoc_COD , Cuoc_DV , Cuoc_Chinh , Cuoc_Giam , Cuoc_E1 , Kien_So , STT , Ma_KH , Nguoi_Gui , Nguoi_Nhan , Dia_Chi_Gui , Dia_Chi_Nhan , Dien_Thoai_Gui , Dien_Thoai_Nhan , HH_Phat_Hanh , HH_Phat_Tra , Ma_Bc_CH , Id_Nguoi_Dung , Id_Trang_Thai , Ghi_Chu , Truyen_Khai_Thac , Truyen_Doi_Soat , Chot_SL ,
        '        ' Output: 
        '        Public Sub Tmp_E1_Di_Lay_Boi_E2_Loi_KT(ByVal Id_Duong_Thu As String, ByVal Id_Chuyen_Thu As String, ByVal Id_E2 As String, ByVal Id_Ca As String, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal Chuyen_Thu As Integer, ByVal Tui_So As Integer)
        '            Try
        '                ' Tạo đối tượng connection và command
        '                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
        '                Dim myCommand As SqlCommand = New SqlCommand("Tmp_E1_Di_Lay_Boi_E2_Loi_KT", myConnection)

        '                ' Sử dụng Store Procedure
        '                myCommand.CommandType = CommandType.StoredProcedure
        '                ' Thêm các Parameters vào thủ tục
        '                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
        '                pId_Duong_Thu.Value = Id_Duong_Thu
        '                myCommand.Parameters.Add(pId_Duong_Thu)

        '                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
        '                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
        '                myCommand.Parameters.Add(pId_Chuyen_Thu)

        '                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
        '                pId_E2.Value = Id_E2
        '                myCommand.Parameters.Add(pId_E2)

        '                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
        '                pId_Ca.Value = Id_Ca
        '                myCommand.Parameters.Add(pId_Ca)

        '                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 12)
        '                pTu_Ngay.Value = Tu_Ngay
        '                myCommand.Parameters.Add(pTu_Ngay)

        '                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 12)
        '                pDen_Ngay.Value = Den_Ngay
        '                myCommand.Parameters.Add(pDen_Ngay)

        '                Dim pChuyen_Thu As SqlParameter = New SqlParameter("@Chuyen_Thu", SqlDbType.Int, 12)
        '                pChuyen_Thu.Value = Chuyen_Thu
        '                myCommand.Parameters.Add(pChuyen_Thu)

        '                Dim pTui_So As SqlParameter = New SqlParameter("@Tui_So", SqlDbType.Int, 12)
        '                pTui_So.Value = Tui_So
        '                myCommand.Parameters.Add(pTui_So)

        '                myConnection.Open()
        '                myCommand.ExecuteNonQuery()
        '                myConnection.Close()
        '            Catch ex As Exception
        '                Console.Write(ex.ToString)
        '            End Try
        '        End Sub
        '#End Region
        '#Region "Tmp_E1_Di_Kiem_Tra_Trung_MA_E1_Id_E2_KT"
        '        ' Ngày tạo: 05/08/08
        '        ' Người tạo: Đỗ Quốc Khánh
        '        ' Nội dung: Kiểm tra trùng dữ liệu trong cùng 1 túi
        '        ' Input: MA_E1, Id_E2
        '        ' Output: myDataTable
        '        Public Function Tmp_E1_Di_Kiem_Tra_Trung_MA_E1_Id_E2_KT(ByVal MA_E1 As String, ByVal Id_E2 As String) As Tmp_E1_Di_Chi_Tiet
        '            Try
        '                ' Tạo đối tượng connection và command
        '                Dim myTmp_E1_Di_Chi_Tiet As New Tmp_E1_Di_Chi_Tiet
        '                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
        '                Dim myCommand As SqlCommand = New SqlCommand("Tmp_E1_Di_Kiem_Tra_Trung_MA_E1_Id_E2_KT", myConnection)
        '                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
        '                Dim myDataSet As DataSet = New DataSet

        '                ' Sử dụng Store Procedure
        '                myCommand.CommandType = CommandType.StoredProcedure
        '                ' Thêm các Parameters vào thủ tục
        '                Dim pMA_E1 As SqlParameter = New SqlParameter("@MA_E1", SqlDbType.VarChar, 13)
        '                pMA_E1.Value = MA_E1
        '                myCommand.Parameters.Add(pMA_E1)
        '                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
        '                pId_E2.Value = Id_E2
        '                myCommand.Parameters.Add(pId_E2)

        '                myConnection.Open()
        '                myAdapter.SelectCommand = myCommand
        '                myAdapter.Fill(myDataSet, "Tmp_E1_Di_Kiem_Tra_Trung_MA_E1_Id_E2_KT")
        '                myConnection.Close()

        '                If myDataSet.Tables(0).Rows.Count > 0 Then
        '                    With myTmp_E1_Di_Chi_Tiet
        '                        .Id_E1 = myDataSet.Tables(0).Rows(0)("Id_E1")
        '                        .Ngay_Phat_Hanh = myDataSet.Tables(0).Rows(0)("Ngay_Phat_Hanh")
        '                        .Gio_Phat_Hanh = myDataSet.Tables(0).Rows(0)("Gio_Phat_Hanh")
        '                        .Ma_Bc_Goc = myDataSet.Tables(0).Rows(0)("Ma_Bc_Goc")
        '                        .Ma_Don_Vi = myDataSet.Tables(0).Rows(0)("Ma_Don_Vi")
        '                        .Ma_Bc_Tra = myDataSet.Tables(0).Rows(0)("Ma_Bc_Tra")
        '                        .Nuoc_Nhan = myDataSet.Tables(0).Rows(0)("Nuoc_Nhan")
        '                        .Nuoc_Tra = myDataSet.Tables(0).Rows(0)("Nuoc_Tra")
        '                        .Khoi_Luong = myDataSet.Tables(0).Rows(0)("Khoi_Luong")
        '                        .Phan_Loai = myDataSet.Tables(0).Rows(0)("Phan_Loai")
        '                        .Loai_Hang_Hoa = myDataSet.Tables(0).Rows(0)("Loai_Hang_Hoa")
        '                        .Khoi_Luong_QD = myDataSet.Tables(0).Rows(0)("Khoi_Luong_QD")
        '                        .Loai = myDataSet.Tables(0).Rows(0)("Loai")
        '                        .PPXD = myDataSet.Tables(0).Rows(0)("PPXD")
        '                        .Cuoc_PPXD = myDataSet.Tables(0).Rows(0)("Cuoc_PPXD")
        '                        .PostCode = myDataSet.Tables(0).Rows(0)("Postcode")
        '                        .Cuoc_PPVX = myDataSet.Tables(0).Rows(0)("Cuoc_PPVX")
        '                        .VAT = myDataSet.Tables(0).Rows(0)("VAT")
        '                        .COD = myDataSet.Tables(0).Rows(0)("COD")
        '                        .Gia_Tri_Hang = myDataSet.Tables(0).Rows(0)("Gia_Tri_Hang")
        '                        .Cuoc_Giam = myDataSet.Tables(0).Rows(0)("Cuoc_Giam")
        '                        .Cuoc_E1 = myDataSet.Tables(0).Rows(0)("Cuoc_E1")
        '                        .Cuoc_Chinh = myDataSet.Tables(0).Rows(0)("Cuoc_Chinh")
        '                        .Cuoc_COD = myDataSet.Tables(0).Rows(0)("Cuoc_COD")
        '                        .Dv_Cong_Them = myDataSet.Tables(0).Rows(0)("Dv_Cong_Them")
        '                        .Dv_Gia_Tang = myDataSet.Tables(0).Rows(0)("Dv_Gia_Tang")
        '                        .Cuoc_DV = myDataSet.Tables(0).Rows(0)("Cuoc_Dv")
        '                        .Ma_Bc_CH = myDataSet.Tables(0).Rows(0)("Ma_Bc_Ch")
        '                        .HH_Phat_Tra = myDataSet.Tables(0).Rows(0)("HH_Phat_Tra")
        '                        .HH_Phat_Hanh = myDataSet.Tables(0).Rows(0)("HH_Phat_Hanh")
        '                        .Id_Trang_Thai = myDataSet.Tables(0).Rows(0)("Id_Trang_Thai")
        '                        .Ma_Bc_CH = myDataSet.Tables(0).Rows(0)("Ma_Bc_Ch")
        '                    End With
        '                Else
        '                    myTmp_E1_Di_Chi_Tiet.Id_E1 = ""
        '                End If
        '                Return myTmp_E1_Di_Chi_Tiet
        '            Catch ex As Exception
        '                Console.Write(ex.ToString)
        '            End Try
        '        End Function
        '#End Region
        '#End Region
    End Class
#End Region
End Namespace
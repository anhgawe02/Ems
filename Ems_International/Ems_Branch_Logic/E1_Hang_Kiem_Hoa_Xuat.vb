
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "E1_Hang_Kiem_Hoa_Xuat_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop E1_Hang_Kiem_Hoa_Xuat_Chi_Tiet
    'Tuong ung voi moi truong trong bang E1_Hang_Kiem_Hoa_Xuat trong co so du lieu
    '***********************************************************
    Public Class E1_Hang_Kiem_Hoa_Xuat_Chi_Tiet
        Public Id_Chi_Tiet As String
        Public Id_E1 As String
        Public Ma_To_Khai As String
        Public Ma_Bc_Khai_Thac As Integer
        Public STT_Hang_Hoa As Integer
        Public Ma_Hang_Hoa As String
        Public Ten_Hang_Hoa As String
        Public Xuat_Xu As String
        Public Don_Vi_Tinh As String
        Public Luong_Hang As Double
        Public Don_Gia As Double
        Public Ma_Tien_Te As String
        Public Gia_Tri_Hang As Double
        Public Gia_Tri_Hang_VN As Integer
        Public Thue_NK As Double
        Public Tien_Thue_NK As Integer
        Public Thue_VAT As Double
        Public Tien_Thue_VAT As Integer
        Public Thue_Dac_Biet As Double
        Public Tien_Thue_Dac_Biet As Integer
        Public Thue_Tieu_Thu As Double
        Public Tien_Thue_Tieu_Thu As Integer
        Public Thue_Qua_Tang As Double
        Public Tien_Thue_Qua_Tang As Integer
        Public Thue_Han_Ngach As Double
        Public Tien_Thue_Han_Ngach As Integer
        Public Thue_Uu_Dai As Double
        Public Tien_Thue_Uu_Dai As Integer
        Public Tong_Thue As Integer
        Public Id_Nguoi_Dung As Integer
        Public Id_Ca As String
        Public Ngay_He_Thong As Integer
        Public Gio_He_Thong As Integer
        Public Da_Truyen As Boolean
        Public Chot_SL As Boolean
    End Class
#End Region

#Region "E1_Hang_Kiem_Hoa_Xuat"
    Public Class E1_Hang_Kiem_Hoa_Xuat
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "E1_Hang_Kiem_Hoa_Xuat_Cap_Nhat"
        Public Function E1_Hang_Kiem_Hoa_Xuat_Cap_Nhat(ByVal Id_Chi_Tiet As String, ByVal Id_E1 As String, ByVal Ma_To_Khai As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal STT_Hang_Hoa As Integer, ByVal Ma_Hang_Hoa As String, ByVal Ten_Hang_Hoa As String, ByVal Xuat_Xu As String, ByVal Don_Vi_Tinh As String, ByVal Luong_Hang As Double, ByVal Don_Gia As Double, ByVal Ma_Tien_Te As String, ByVal Gia_Tri_Hang As Double, ByVal Gia_Tri_Hang_VN As Integer, ByVal Thue_NK As Double, ByVal Tien_Thue_NK As Integer, ByVal Thue_VAT As Double, ByVal Tien_Thue_VAT As Integer, ByVal Thue_Dac_Biet As Double, ByVal Tien_Thue_Dac_Biet As Integer, ByVal Thue_Tieu_Thu As Double, ByVal Tien_Thue_Tieu_Thu As Integer, ByVal Thue_Qua_Tang As Double, ByVal Tien_Thue_Qua_Tang As Integer, ByVal Thue_Han_Ngach As Double, ByVal Tien_Thue_Han_Ngach As Integer, ByVal Thue_Uu_Dai As Double, ByVal Tien_Thue_Uu_Dai As Integer, ByVal Tong_Thue As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Id_Ca As String, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer, ByVal Da_Truyen As Boolean, ByVal Chot_SL As Boolean) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Hang_Kiem_Hoa_Xuat_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet As New E1_Hang_Kiem_Hoa_Xuat_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Chi_Tiet As SqlParameter = New SqlParameter("@Id_Chi_Tiet", SqlDbType.VarChar, 52)
                pId_Chi_Tiet.Value = Id_Chi_Tiet
                MyCommand.Parameters.Add(pId_Chi_Tiet)

                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                MyCommand.Parameters.Add(pId_E1)

                Dim pMa_To_Khai As SqlParameter = New SqlParameter("@Ma_To_Khai", SqlDbType.VarChar, 20)
                pMa_To_Khai.Value = Ma_To_Khai
                MyCommand.Parameters.Add(pMa_To_Khai)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pSTT_Hang_Hoa As SqlParameter = New SqlParameter("@STT_Hang_Hoa", SqlDbType.Int, 0)
                pSTT_Hang_Hoa.Value = STT_Hang_Hoa
                MyCommand.Parameters.Add(pSTT_Hang_Hoa)

                Dim pMa_Hang_Hoa As SqlParameter = New SqlParameter("@Ma_Hang_Hoa", SqlDbType.VarChar, 20)
                pMa_Hang_Hoa.Value = Ma_Hang_Hoa
                MyCommand.Parameters.Add(pMa_Hang_Hoa)

                Dim pTen_Hang_Hoa As SqlParameter = New SqlParameter("@Ten_Hang_Hoa", SqlDbType.NVarChar, 100)
                pTen_Hang_Hoa.Value = Ten_Hang_Hoa
                MyCommand.Parameters.Add(pTen_Hang_Hoa)

                Dim pXuat_Xu As SqlParameter = New SqlParameter("@Xuat_Xu", SqlDbType.NVarChar, 200)
                pXuat_Xu.Value = Xuat_Xu
                MyCommand.Parameters.Add(pXuat_Xu)

                Dim pDon_Vi_Tinh As SqlParameter = New SqlParameter("@Don_Vi_Tinh", SqlDbType.NVarChar, 20)
                pDon_Vi_Tinh.Value = Don_Vi_Tinh
                MyCommand.Parameters.Add(pDon_Vi_Tinh)

                Dim pLuong_Hang As SqlParameter = New SqlParameter("@Luong_Hang", SqlDbType.Float, 0)
                pLuong_Hang.Value = Luong_Hang
                MyCommand.Parameters.Add(pLuong_Hang)

                Dim pDon_Gia As SqlParameter = New SqlParameter("@Don_Gia", SqlDbType.Float, 0)
                pDon_Gia.Value = Don_Gia
                MyCommand.Parameters.Add(pDon_Gia)

                Dim pMa_Tien_Te As SqlParameter = New SqlParameter("@Ma_Tien_Te", SqlDbType.VarChar, 5)
                pMa_Tien_Te.Value = Ma_Tien_Te
                MyCommand.Parameters.Add(pMa_Tien_Te)

                Dim pGia_Tri_Hang As SqlParameter = New SqlParameter("@Gia_Tri_Hang", SqlDbType.Float, 0)
                pGia_Tri_Hang.Value = Gia_Tri_Hang
                MyCommand.Parameters.Add(pGia_Tri_Hang)

                Dim pGia_Tri_Hang_VN As SqlParameter = New SqlParameter("@Gia_Tri_Hang_VN", SqlDbType.Int, 0)
                pGia_Tri_Hang_VN.Value = Gia_Tri_Hang_VN
                MyCommand.Parameters.Add(pGia_Tri_Hang_VN)

                Dim pThue_NK As SqlParameter = New SqlParameter("@Thue_NK", SqlDbType.Float, 0)
                pThue_NK.Value = Thue_NK
                MyCommand.Parameters.Add(pThue_NK)

                Dim pTien_Thue_NK As SqlParameter = New SqlParameter("@Tien_Thue_NK", SqlDbType.Int, 0)
                pTien_Thue_NK.Value = Tien_Thue_NK
                MyCommand.Parameters.Add(pTien_Thue_NK)

                Dim pThue_VAT As SqlParameter = New SqlParameter("@Thue_VAT", SqlDbType.Float, 0)
                pThue_VAT.Value = Thue_VAT
                MyCommand.Parameters.Add(pThue_VAT)

                Dim pTien_Thue_VAT As SqlParameter = New SqlParameter("@Tien_Thue_VAT", SqlDbType.Int, 0)
                pTien_Thue_VAT.Value = Tien_Thue_VAT
                MyCommand.Parameters.Add(pTien_Thue_VAT)

                Dim pThue_Dac_Biet As SqlParameter = New SqlParameter("@Thue_Dac_Biet", SqlDbType.Float, 0)
                pThue_Dac_Biet.Value = Thue_Dac_Biet
                MyCommand.Parameters.Add(pThue_Dac_Biet)

                Dim pTien_Thue_Dac_Biet As SqlParameter = New SqlParameter("@Tien_Thue_Dac_Biet", SqlDbType.Int, 0)
                pTien_Thue_Dac_Biet.Value = Tien_Thue_Dac_Biet
                MyCommand.Parameters.Add(pTien_Thue_Dac_Biet)

                Dim pThue_Tieu_Thu As SqlParameter = New SqlParameter("@Thue_Tieu_Thu", SqlDbType.Float, 0)
                pThue_Tieu_Thu.Value = Thue_Tieu_Thu
                MyCommand.Parameters.Add(pThue_Tieu_Thu)

                Dim pTien_Thue_Tieu_Thu As SqlParameter = New SqlParameter("@Tien_Thue_Tieu_Thu", SqlDbType.Int, 0)
                pTien_Thue_Tieu_Thu.Value = Tien_Thue_Tieu_Thu
                MyCommand.Parameters.Add(pTien_Thue_Tieu_Thu)

                Dim pThue_Qua_Tang As SqlParameter = New SqlParameter("@Thue_Qua_Tang", SqlDbType.Float, 0)
                pThue_Qua_Tang.Value = Thue_Qua_Tang
                MyCommand.Parameters.Add(pThue_Qua_Tang)

                Dim pTien_Thue_Qua_Tang As SqlParameter = New SqlParameter("@Tien_Thue_Qua_Tang", SqlDbType.Int, 0)
                pTien_Thue_Qua_Tang.Value = Tien_Thue_Qua_Tang
                MyCommand.Parameters.Add(pTien_Thue_Qua_Tang)

                Dim pThue_Han_Ngach As SqlParameter = New SqlParameter("@Thue_Han_Ngach", SqlDbType.Float, 0)
                pThue_Han_Ngach.Value = Thue_Han_Ngach
                MyCommand.Parameters.Add(pThue_Han_Ngach)

                Dim pTien_Thue_Han_Ngach As SqlParameter = New SqlParameter("@Tien_Thue_Han_Ngach", SqlDbType.Int, 0)
                pTien_Thue_Han_Ngach.Value = Tien_Thue_Han_Ngach
                MyCommand.Parameters.Add(pTien_Thue_Han_Ngach)

                Dim pThue_Uu_Dai As SqlParameter = New SqlParameter("@Thue_Uu_Dai", SqlDbType.Float, 0)
                pThue_Uu_Dai.Value = Thue_Uu_Dai
                MyCommand.Parameters.Add(pThue_Uu_Dai)

                Dim pTien_Thue_Uu_Dai As SqlParameter = New SqlParameter("@Tien_Thue_Uu_Dai", SqlDbType.Int, 0)
                pTien_Thue_Uu_Dai.Value = Tien_Thue_Uu_Dai
                MyCommand.Parameters.Add(pTien_Thue_Uu_Dai)

                Dim pTong_Thue As SqlParameter = New SqlParameter("@Tong_Thue", SqlDbType.Int, 0)
                pTong_Thue.Value = Tong_Thue
                MyCommand.Parameters.Add(pTong_Thue)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                MyCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                MyCommand.Parameters.Add(pId_Ca)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Value = Ngay_He_Thong
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Value = Gio_He_Thong
                MyCommand.Parameters.Add(pGio_He_Thong)

                Dim pDa_Truyen As SqlParameter = New SqlParameter("@Da_Truyen", SqlDbType.Bit, 0)
                pDa_Truyen.Value = Da_Truyen
                MyCommand.Parameters.Add(pDa_Truyen)

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

#Region "E1_Hang_Kiem_Hoa_Xuat_Cap_Nhat_Them"
        Public Function E1_Hang_Kiem_Hoa_Xuat_Cap_Nhat_Them(ByVal Id_Chi_Tiet As String, ByVal Id_E1 As String, ByVal Ma_To_Khai As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal STT_Hang_Hoa As Integer, ByVal Ma_Hang_Hoa As String, ByVal Ten_Hang_Hoa As String, ByVal Xuat_Xu As String, ByVal Don_Vi_Tinh As String, ByVal Luong_Hang As Double, ByVal Don_Gia As Double, ByVal Ma_Tien_Te As String, ByVal Gia_Tri_Hang As Double, ByVal Gia_Tri_Hang_VN As Integer, ByVal Thue_NK As Double, ByVal Tien_Thue_NK As Integer, ByVal Thue_VAT As Double, ByVal Tien_Thue_VAT As Integer, ByVal Thue_Dac_Biet As Double, ByVal Tien_Thue_Dac_Biet As Integer, ByVal Thue_Tieu_Thu As Double, ByVal Tien_Thue_Tieu_Thu As Integer, ByVal Thue_Qua_Tang As Double, ByVal Tien_Thue_Qua_Tang As Integer, ByVal Thue_Han_Ngach As Double, ByVal Tien_Thue_Han_Ngach As Integer, ByVal Thue_Uu_Dai As Double, ByVal Tien_Thue_Uu_Dai As Integer, ByVal Tong_Thue As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Id_Ca As String, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer, ByVal Da_Truyen As Boolean, ByVal Chot_SL As Boolean) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Hang_Kiem_Hoa_Xuat_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet As New E1_Hang_Kiem_Hoa_Xuat_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Chi_Tiet As SqlParameter = New SqlParameter("@Id_Chi_Tiet", SqlDbType.VarChar, 52)
                pId_Chi_Tiet.Value = Id_Chi_Tiet
                MyCommand.Parameters.Add(pId_Chi_Tiet)

                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                MyCommand.Parameters.Add(pId_E1)

                Dim pMa_To_Khai As SqlParameter = New SqlParameter("@Ma_To_Khai", SqlDbType.VarChar, 20)
                pMa_To_Khai.Value = Ma_To_Khai
                MyCommand.Parameters.Add(pMa_To_Khai)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pSTT_Hang_Hoa As SqlParameter = New SqlParameter("@STT_Hang_Hoa", SqlDbType.Int, 0)
                pSTT_Hang_Hoa.Value = STT_Hang_Hoa
                MyCommand.Parameters.Add(pSTT_Hang_Hoa)

                Dim pMa_Hang_Hoa As SqlParameter = New SqlParameter("@Ma_Hang_Hoa", SqlDbType.VarChar, 20)
                pMa_Hang_Hoa.Value = Ma_Hang_Hoa
                MyCommand.Parameters.Add(pMa_Hang_Hoa)

                Dim pTen_Hang_Hoa As SqlParameter = New SqlParameter("@Ten_Hang_Hoa", SqlDbType.NVarChar, 100)
                pTen_Hang_Hoa.Value = Ten_Hang_Hoa
                MyCommand.Parameters.Add(pTen_Hang_Hoa)

                Dim pXuat_Xu As SqlParameter = New SqlParameter("@Xuat_Xu", SqlDbType.NVarChar, 200)
                pXuat_Xu.Value = Xuat_Xu
                MyCommand.Parameters.Add(pXuat_Xu)

                Dim pDon_Vi_Tinh As SqlParameter = New SqlParameter("@Don_Vi_Tinh", SqlDbType.NVarChar, 20)
                pDon_Vi_Tinh.Value = Don_Vi_Tinh
                MyCommand.Parameters.Add(pDon_Vi_Tinh)

                Dim pLuong_Hang As SqlParameter = New SqlParameter("@Luong_Hang", SqlDbType.Float, 0)
                pLuong_Hang.Value = Luong_Hang
                MyCommand.Parameters.Add(pLuong_Hang)

                Dim pDon_Gia As SqlParameter = New SqlParameter("@Don_Gia", SqlDbType.Float, 0)
                pDon_Gia.Value = Don_Gia
                MyCommand.Parameters.Add(pDon_Gia)

                Dim pMa_Tien_Te As SqlParameter = New SqlParameter("@Ma_Tien_Te", SqlDbType.VarChar, 5)
                pMa_Tien_Te.Value = Ma_Tien_Te
                MyCommand.Parameters.Add(pMa_Tien_Te)

                Dim pGia_Tri_Hang As SqlParameter = New SqlParameter("@Gia_Tri_Hang", SqlDbType.Float, 0)
                pGia_Tri_Hang.Value = Gia_Tri_Hang
                MyCommand.Parameters.Add(pGia_Tri_Hang)

                Dim pGia_Tri_Hang_VN As SqlParameter = New SqlParameter("@Gia_Tri_Hang_VN", SqlDbType.Int, 0)
                pGia_Tri_Hang_VN.Value = Gia_Tri_Hang_VN
                MyCommand.Parameters.Add(pGia_Tri_Hang_VN)

                Dim pThue_NK As SqlParameter = New SqlParameter("@Thue_NK", SqlDbType.Float, 0)
                pThue_NK.Value = Thue_NK
                MyCommand.Parameters.Add(pThue_NK)

                Dim pTien_Thue_NK As SqlParameter = New SqlParameter("@Tien_Thue_NK", SqlDbType.Int, 0)
                pTien_Thue_NK.Value = Tien_Thue_NK
                MyCommand.Parameters.Add(pTien_Thue_NK)

                Dim pThue_VAT As SqlParameter = New SqlParameter("@Thue_VAT", SqlDbType.Float, 0)
                pThue_VAT.Value = Thue_VAT
                MyCommand.Parameters.Add(pThue_VAT)

                Dim pTien_Thue_VAT As SqlParameter = New SqlParameter("@Tien_Thue_VAT", SqlDbType.Int, 0)
                pTien_Thue_VAT.Value = Tien_Thue_VAT
                MyCommand.Parameters.Add(pTien_Thue_VAT)

                Dim pThue_Dac_Biet As SqlParameter = New SqlParameter("@Thue_Dac_Biet", SqlDbType.Float, 0)
                pThue_Dac_Biet.Value = Thue_Dac_Biet
                MyCommand.Parameters.Add(pThue_Dac_Biet)

                Dim pTien_Thue_Dac_Biet As SqlParameter = New SqlParameter("@Tien_Thue_Dac_Biet", SqlDbType.Int, 0)
                pTien_Thue_Dac_Biet.Value = Tien_Thue_Dac_Biet
                MyCommand.Parameters.Add(pTien_Thue_Dac_Biet)

                Dim pThue_Tieu_Thu As SqlParameter = New SqlParameter("@Thue_Tieu_Thu", SqlDbType.Float, 0)
                pThue_Tieu_Thu.Value = Thue_Tieu_Thu
                MyCommand.Parameters.Add(pThue_Tieu_Thu)

                Dim pTien_Thue_Tieu_Thu As SqlParameter = New SqlParameter("@Tien_Thue_Tieu_Thu", SqlDbType.Int, 0)
                pTien_Thue_Tieu_Thu.Value = Tien_Thue_Tieu_Thu
                MyCommand.Parameters.Add(pTien_Thue_Tieu_Thu)

                Dim pThue_Qua_Tang As SqlParameter = New SqlParameter("@Thue_Qua_Tang", SqlDbType.Float, 0)
                pThue_Qua_Tang.Value = Thue_Qua_Tang
                MyCommand.Parameters.Add(pThue_Qua_Tang)

                Dim pTien_Thue_Qua_Tang As SqlParameter = New SqlParameter("@Tien_Thue_Qua_Tang", SqlDbType.Int, 0)
                pTien_Thue_Qua_Tang.Value = Tien_Thue_Qua_Tang
                MyCommand.Parameters.Add(pTien_Thue_Qua_Tang)

                Dim pThue_Han_Ngach As SqlParameter = New SqlParameter("@Thue_Han_Ngach", SqlDbType.Float, 0)
                pThue_Han_Ngach.Value = Thue_Han_Ngach
                MyCommand.Parameters.Add(pThue_Han_Ngach)

                Dim pTien_Thue_Han_Ngach As SqlParameter = New SqlParameter("@Tien_Thue_Han_Ngach", SqlDbType.Int, 0)
                pTien_Thue_Han_Ngach.Value = Tien_Thue_Han_Ngach
                MyCommand.Parameters.Add(pTien_Thue_Han_Ngach)

                Dim pThue_Uu_Dai As SqlParameter = New SqlParameter("@Thue_Uu_Dai", SqlDbType.Float, 0)
                pThue_Uu_Dai.Value = Thue_Uu_Dai
                MyCommand.Parameters.Add(pThue_Uu_Dai)

                Dim pTien_Thue_Uu_Dai As SqlParameter = New SqlParameter("@Tien_Thue_Uu_Dai", SqlDbType.Int, 0)
                pTien_Thue_Uu_Dai.Value = Tien_Thue_Uu_Dai
                MyCommand.Parameters.Add(pTien_Thue_Uu_Dai)

                Dim pTong_Thue As SqlParameter = New SqlParameter("@Tong_Thue", SqlDbType.Int, 0)
                pTong_Thue.Value = Tong_Thue
                MyCommand.Parameters.Add(pTong_Thue)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                MyCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                MyCommand.Parameters.Add(pId_Ca)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Value = Ngay_He_Thong
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Value = Gio_He_Thong
                MyCommand.Parameters.Add(pGio_He_Thong)

                Dim pDa_Truyen As SqlParameter = New SqlParameter("@Da_Truyen", SqlDbType.Bit, 0)
                pDa_Truyen.Value = Da_Truyen
                MyCommand.Parameters.Add(pDa_Truyen)

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

#Region "E1_Hang_Kiem_Hoa_Xuat_Danh_Sach"

        Public Function E1_Hang_Kiem_Hoa_Xuat_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Id_Chi_Tiet
            ' Id_E1
            ' Ma_To_Khai
            ' Ma_Bc_Khai_Thac
            ' STT_Hang_Hoa
            ' Ma_Hang_Hoa
            ' Ten_Hang_Hoa
            ' Xuat_Xu
            ' Don_Vi_Tinh
            ' Luong_Hang
            ' Don_Gia
            ' Ma_Tien_Te
            ' Gia_Tri_Hang
            ' Gia_Tri_Hang_VN
            ' Thue_NK
            ' Tien_Thue_NK
            ' Thue_VAT
            ' Tien_Thue_VAT
            ' Thue_Dac_Biet
            ' Tien_Thue_Dac_Biet
            ' Thue_Tieu_Thu
            ' Tien_Thue_Tieu_Thu
            ' Thue_Qua_Tang
            ' Tien_Thue_Qua_Tang
            ' Thue_Han_Ngach
            ' Tien_Thue_Han_Ngach
            ' Thue_Uu_Dai
            ' Tien_Thue_Uu_Dai
            ' Tong_Thue
            ' Id_Nguoi_Dung
            ' Id_Ca
            ' Ngay_He_Thong
            ' Gio_He_Thong
            ' Da_Truyen
            ' Chot_SL


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Hang_Kiem_Hoa_Xuat_Danh_Sach"
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

#Region "E1_Hang_Kiem_Hoa_Xuat_Danh_Sach_Lay_Boi_Id_E1"

        Public Function E1_Hang_Kiem_Hoa_Xuat_Danh_Sach_Lay_Boi_Id_E1(ByVal Id_E1 As String) As DataSet

            ' The procedure returns these columns:
            ' Id_Chi_Tiet
            ' Id_E1
            ' Ma_To_Khai
            ' Ma_Bc_Khai_Thac
            ' STT_Hang_Hoa
            ' Ma_Hang_Hoa
            ' Ten_Hang_Hoa
            ' Xuat_Xu
            ' Don_Vi_Tinh
            ' Luong_Hang
            ' Don_Gia
            ' Ma_Tien_Te
            ' Gia_Tri_Hang
            ' Gia_Tri_Hang_VN
            ' Thue_NK
            ' Tien_Thue_NK
            ' Thue_VAT
            ' Tien_Thue_VAT
            ' Thue_Dac_Biet
            ' Tien_Thue_Dac_Biet
            ' Thue_Tieu_Thu
            ' Tien_Thue_Tieu_Thu
            ' Thue_Qua_Tang
            ' Tien_Thue_Qua_Tang
            ' Thue_Han_Ngach
            ' Tien_Thue_Han_Ngach
            ' Thue_Uu_Dai
            ' Tien_Thue_Uu_Dai
            ' Tong_Thue
            ' Id_Nguoi_Dung
            ' Id_Ca
            ' Ngay_He_Thong
            ' Gio_He_Thong
            ' Da_Truyen
            ' Chot_SL


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Hang_Kiem_Hoa_Xuat_Danh_Sach_Lay_Boi_Id_E1"
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

#Region "E1_Hang_Kiem_Hoa_Xuat_Danh_Sach_Lay_Boi_Ma_To_Khai"

        Public Function E1_Hang_Kiem_Hoa_Xuat_Danh_Sach_Lay_Boi_Ma_To_Khai(ByVal Ma_To_Khai As String) As DataSet

            ' The procedure returns these columns:
            ' Id_Chi_Tiet
            ' Id_E1
            ' Ma_To_Khai
            ' Ma_Bc_Khai_Thac
            ' STT_Hang_Hoa
            ' Ma_Hang_Hoa
            ' Ten_Hang_Hoa
            ' Xuat_Xu
            ' Don_Vi_Tinh
            ' Luong_Hang
            ' Don_Gia
            ' Ma_Tien_Te
            ' Gia_Tri_Hang
            ' Gia_Tri_Hang_VN
            ' Thue_NK
            ' Tien_Thue_NK
            ' Thue_VAT
            ' Tien_Thue_VAT
            ' Thue_Dac_Biet
            ' Tien_Thue_Dac_Biet
            ' Thue_Tieu_Thu
            ' Tien_Thue_Tieu_Thu
            ' Thue_Qua_Tang
            ' Tien_Thue_Qua_Tang
            ' Thue_Han_Ngach
            ' Tien_Thue_Han_Ngach
            ' Thue_Uu_Dai
            ' Tien_Thue_Uu_Dai
            ' Tong_Thue
            ' Id_Nguoi_Dung
            ' Id_Ca
            ' Ngay_He_Thong
            ' Gio_He_Thong
            ' Da_Truyen
            ' Chot_SL


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Hang_Kiem_Hoa_Xuat_Danh_Sach_Lay_Boi_Ma_To_Khai"
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

#Region "E1_Hang_Kiem_Hoa_Xuat_Danh_Sach_Lay_Boi_Ma_To_Khai_Id_E1"

        Public Function E1_Hang_Kiem_Hoa_Xuat_Danh_Sach_Lay_Boi_Ma_To_Khai_Id_E1(ByVal Ma_To_Khai As String, ByVal Id_E1 As String) As DataSet

            ' The procedure returns these columns:
            ' Id_Chi_Tiet
            ' Id_E1
            ' Ma_To_Khai
            ' Ma_Bc_Khai_Thac
            ' STT_Hang_Hoa
            ' Ma_Hang_Hoa
            ' Ten_Hang_Hoa
            ' Xuat_Xu
            ' Don_Vi_Tinh
            ' Luong_Hang
            ' Don_Gia
            ' Ma_Tien_Te
            ' Gia_Tri_Hang
            ' Gia_Tri_Hang_VN
            ' Thue_NK
            ' Tien_Thue_NK
            ' Thue_VAT
            ' Tien_Thue_VAT
            ' Thue_Dac_Biet
            ' Tien_Thue_Dac_Biet
            ' Thue_Tieu_Thu
            ' Tien_Thue_Tieu_Thu
            ' Thue_Qua_Tang
            ' Tien_Thue_Qua_Tang
            ' Thue_Han_Ngach
            ' Tien_Thue_Han_Ngach
            ' Thue_Uu_Dai
            ' Tien_Thue_Uu_Dai
            ' Tong_Thue
            ' Id_Nguoi_Dung
            ' Id_Ca
            ' Ngay_He_Thong
            ' Gio_He_Thong
            ' Da_Truyen
            ' Chot_SL


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Hang_Kiem_Hoa_Xuat_Danh_Sach_Lay_Boi_Ma_To_Khai_Id_E1"
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

#Region "E1_Hang_Kiem_Hoa_Xuat_Lay"
        Public Function E1_Hang_Kiem_Hoa_Xuat_Lay(ByVal Id_Chi_Tiet As String) As E1_Hang_Kiem_Hoa_Xuat_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Hang_Kiem_Hoa_Xuat_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet As New E1_Hang_Kiem_Hoa_Xuat_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Chi_Tiet As SqlParameter = New SqlParameter("@Id_Chi_Tiet", SqlDbType.VarChar, 52)
                pId_Chi_Tiet.Value = Id_Chi_Tiet
                MyCommand.Parameters.Add(pId_Chi_Tiet)

                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_E1)

                Dim pMa_To_Khai As SqlParameter = New SqlParameter("@Ma_To_Khai", SqlDbType.VarChar, 20)
                pMa_To_Khai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_To_Khai)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pSTT_Hang_Hoa As SqlParameter = New SqlParameter("@STT_Hang_Hoa", SqlDbType.Int, 0)
                pSTT_Hang_Hoa.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSTT_Hang_Hoa)

                Dim pMa_Hang_Hoa As SqlParameter = New SqlParameter("@Ma_Hang_Hoa", SqlDbType.VarChar, 20)
                pMa_Hang_Hoa.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Hang_Hoa)

                Dim pTen_Hang_Hoa As SqlParameter = New SqlParameter("@Ten_Hang_Hoa", SqlDbType.NVarChar, 100)
                pTen_Hang_Hoa.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTen_Hang_Hoa)

                Dim pXuat_Xu As SqlParameter = New SqlParameter("@Xuat_Xu", SqlDbType.NVarChar, 200)
                pXuat_Xu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pXuat_Xu)

                Dim pDon_Vi_Tinh As SqlParameter = New SqlParameter("@Don_Vi_Tinh", SqlDbType.NVarChar, 20)
                pDon_Vi_Tinh.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDon_Vi_Tinh)

                Dim pLuong_Hang As SqlParameter = New SqlParameter("@Luong_Hang", SqlDbType.Float, 0)
                pLuong_Hang.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pLuong_Hang)

                Dim pDon_Gia As SqlParameter = New SqlParameter("@Don_Gia", SqlDbType.Float, 0)
                pDon_Gia.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDon_Gia)

                Dim pMa_Tien_Te As SqlParameter = New SqlParameter("@Ma_Tien_Te", SqlDbType.VarChar, 5)
                pMa_Tien_Te.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Tien_Te)

                Dim pGia_Tri_Hang As SqlParameter = New SqlParameter("@Gia_Tri_Hang", SqlDbType.Float, 0)
                pGia_Tri_Hang.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGia_Tri_Hang)

                Dim pGia_Tri_Hang_VN As SqlParameter = New SqlParameter("@Gia_Tri_Hang_VN", SqlDbType.Int, 0)
                pGia_Tri_Hang_VN.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGia_Tri_Hang_VN)

                Dim pThue_NK As SqlParameter = New SqlParameter("@Thue_NK", SqlDbType.Float, 0)
                pThue_NK.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThue_NK)

                Dim pTien_Thue_NK As SqlParameter = New SqlParameter("@Tien_Thue_NK", SqlDbType.Int, 0)
                pTien_Thue_NK.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTien_Thue_NK)

                Dim pThue_VAT As SqlParameter = New SqlParameter("@Thue_VAT", SqlDbType.Float, 0)
                pThue_VAT.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThue_VAT)

                Dim pTien_Thue_VAT As SqlParameter = New SqlParameter("@Tien_Thue_VAT", SqlDbType.Int, 0)
                pTien_Thue_VAT.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTien_Thue_VAT)

                Dim pThue_Dac_Biet As SqlParameter = New SqlParameter("@Thue_Dac_Biet", SqlDbType.Float, 0)
                pThue_Dac_Biet.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThue_Dac_Biet)

                Dim pTien_Thue_Dac_Biet As SqlParameter = New SqlParameter("@Tien_Thue_Dac_Biet", SqlDbType.Int, 0)
                pTien_Thue_Dac_Biet.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTien_Thue_Dac_Biet)

                Dim pThue_Tieu_Thu As SqlParameter = New SqlParameter("@Thue_Tieu_Thu", SqlDbType.Float, 0)
                pThue_Tieu_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThue_Tieu_Thu)

                Dim pTien_Thue_Tieu_Thu As SqlParameter = New SqlParameter("@Tien_Thue_Tieu_Thu", SqlDbType.Int, 0)
                pTien_Thue_Tieu_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTien_Thue_Tieu_Thu)

                Dim pThue_Qua_Tang As SqlParameter = New SqlParameter("@Thue_Qua_Tang", SqlDbType.Float, 0)
                pThue_Qua_Tang.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThue_Qua_Tang)

                Dim pTien_Thue_Qua_Tang As SqlParameter = New SqlParameter("@Tien_Thue_Qua_Tang", SqlDbType.Int, 0)
                pTien_Thue_Qua_Tang.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTien_Thue_Qua_Tang)

                Dim pThue_Han_Ngach As SqlParameter = New SqlParameter("@Thue_Han_Ngach", SqlDbType.Float, 0)
                pThue_Han_Ngach.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThue_Han_Ngach)

                Dim pTien_Thue_Han_Ngach As SqlParameter = New SqlParameter("@Tien_Thue_Han_Ngach", SqlDbType.Int, 0)
                pTien_Thue_Han_Ngach.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTien_Thue_Han_Ngach)

                Dim pThue_Uu_Dai As SqlParameter = New SqlParameter("@Thue_Uu_Dai", SqlDbType.Float, 0)
                pThue_Uu_Dai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThue_Uu_Dai)

                Dim pTien_Thue_Uu_Dai As SqlParameter = New SqlParameter("@Tien_Thue_Uu_Dai", SqlDbType.Int, 0)
                pTien_Thue_Uu_Dai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTien_Thue_Uu_Dai)

                Dim pTong_Thue As SqlParameter = New SqlParameter("@Tong_Thue", SqlDbType.Int, 0)
                pTong_Thue.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTong_Thue)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0)
                pId_Nguoi_Dung.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Ca)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_He_Thong)

                Dim pDa_Truyen As SqlParameter = New SqlParameter("@Da_Truyen", SqlDbType.Bit, 0)
                pDa_Truyen.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDa_Truyen)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 0)
                pChot_SL.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pChot_SL)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Id_Chi_Tiet = Id_Chi_Tiet
                myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Id_E1 = pId_E1.Value
                myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Ma_To_Khai = pMa_To_Khai.Value
                myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Ma_Bc_Khai_Thac = pMa_Bc_Khai_Thac.Value
                myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.STT_Hang_Hoa = pSTT_Hang_Hoa.Value
                myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Ma_Hang_Hoa = pMa_Hang_Hoa.Value
                myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Ten_Hang_Hoa = pTen_Hang_Hoa.Value
                myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Xuat_Xu = pXuat_Xu.Value
                myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Don_Vi_Tinh = pDon_Vi_Tinh.Value
                myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Luong_Hang = pLuong_Hang.Value
                myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Don_Gia = pDon_Gia.Value
                myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Ma_Tien_Te = pMa_Tien_Te.Value
                myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Gia_Tri_Hang = pGia_Tri_Hang.Value
                myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Gia_Tri_Hang_VN = pGia_Tri_Hang_VN.Value
                myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Thue_NK = pThue_NK.Value
                myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Tien_Thue_NK = pTien_Thue_NK.Value
                myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Thue_VAT = pThue_VAT.Value
                myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Tien_Thue_VAT = pTien_Thue_VAT.Value
                myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Thue_Dac_Biet = pThue_Dac_Biet.Value
                myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Tien_Thue_Dac_Biet = pTien_Thue_Dac_Biet.Value
                myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Thue_Tieu_Thu = pThue_Tieu_Thu.Value
                myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Tien_Thue_Tieu_Thu = pTien_Thue_Tieu_Thu.Value
                myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Thue_Qua_Tang = pThue_Qua_Tang.Value
                myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Tien_Thue_Qua_Tang = pTien_Thue_Qua_Tang.Value
                myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Thue_Han_Ngach = pThue_Han_Ngach.Value
                myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Tien_Thue_Han_Ngach = pTien_Thue_Han_Ngach.Value
                myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Thue_Uu_Dai = pThue_Uu_Dai.Value
                myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Tien_Thue_Uu_Dai = pTien_Thue_Uu_Dai.Value
                myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Tong_Thue = pTong_Thue.Value
                myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Id_Nguoi_Dung = pId_Nguoi_Dung.Value
                myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Id_Ca = pId_Ca.Value
                myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Gio_He_Thong = pGio_He_Thong.Value
                myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Da_Truyen = pDa_Truyen.Value
                myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Chot_SL = pChot_SL.Value

                Return myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet
                'Return myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet

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

#Region "E1_Hang_Kiem_Hoa_Xuat_Them"
        Public Function E1_Hang_Kiem_Hoa_Xuat_Them(ByVal Id_Chi_Tiet As String, ByVal Id_E1 As String, ByVal Ma_To_Khai As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal STT_Hang_Hoa As Integer, ByVal Ma_Hang_Hoa As String, ByVal Ten_Hang_Hoa As String, ByVal Xuat_Xu As String, ByVal Don_Vi_Tinh As String, ByVal Luong_Hang As Double, ByVal Don_Gia As Double, ByVal Ma_Tien_Te As String, ByVal Gia_Tri_Hang As Double, ByVal Gia_Tri_Hang_VN As Integer, ByVal Thue_NK As Double, ByVal Tien_Thue_NK As Integer, ByVal Thue_VAT As Double, ByVal Tien_Thue_VAT As Integer, ByVal Thue_Dac_Biet As Double, ByVal Tien_Thue_Dac_Biet As Integer, ByVal Thue_Tieu_Thu As Double, ByVal Tien_Thue_Tieu_Thu As Integer, ByVal Thue_Qua_Tang As Double, ByVal Tien_Thue_Qua_Tang As Integer, ByVal Thue_Han_Ngach As Double, ByVal Tien_Thue_Han_Ngach As Integer, ByVal Thue_Uu_Dai As Double, ByVal Tien_Thue_Uu_Dai As Integer, ByVal Tong_Thue As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Id_Ca As String, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer, ByVal Da_Truyen As Boolean, ByVal Chot_SL As Boolean) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Hang_Kiem_Hoa_Xuat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet As New E1_Hang_Kiem_Hoa_Xuat_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Chi_Tiet As SqlParameter = New SqlParameter("@Id_Chi_Tiet", SqlDbType.VarChar, 52)
                pId_Chi_Tiet.Value = Id_Chi_Tiet
                MyCommand.Parameters.Add(pId_Chi_Tiet)

                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                MyCommand.Parameters.Add(pId_E1)

                Dim pMa_To_Khai As SqlParameter = New SqlParameter("@Ma_To_Khai", SqlDbType.VarChar, 20)
                pMa_To_Khai.Value = Ma_To_Khai
                MyCommand.Parameters.Add(pMa_To_Khai)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pSTT_Hang_Hoa As SqlParameter = New SqlParameter("@STT_Hang_Hoa", SqlDbType.Int, 0)
                pSTT_Hang_Hoa.Value = STT_Hang_Hoa
                MyCommand.Parameters.Add(pSTT_Hang_Hoa)

                Dim pMa_Hang_Hoa As SqlParameter = New SqlParameter("@Ma_Hang_Hoa", SqlDbType.VarChar, 20)
                pMa_Hang_Hoa.Value = Ma_Hang_Hoa
                MyCommand.Parameters.Add(pMa_Hang_Hoa)

                Dim pTen_Hang_Hoa As SqlParameter = New SqlParameter("@Ten_Hang_Hoa", SqlDbType.NVarChar, 100)
                pTen_Hang_Hoa.Value = Ten_Hang_Hoa
                MyCommand.Parameters.Add(pTen_Hang_Hoa)

                Dim pXuat_Xu As SqlParameter = New SqlParameter("@Xuat_Xu", SqlDbType.NVarChar, 200)
                pXuat_Xu.Value = Xuat_Xu
                MyCommand.Parameters.Add(pXuat_Xu)

                Dim pDon_Vi_Tinh As SqlParameter = New SqlParameter("@Don_Vi_Tinh", SqlDbType.NVarChar, 20)
                pDon_Vi_Tinh.Value = Don_Vi_Tinh
                MyCommand.Parameters.Add(pDon_Vi_Tinh)

                Dim pLuong_Hang As SqlParameter = New SqlParameter("@Luong_Hang", SqlDbType.Float, 0)
                pLuong_Hang.Value = Luong_Hang
                MyCommand.Parameters.Add(pLuong_Hang)

                Dim pDon_Gia As SqlParameter = New SqlParameter("@Don_Gia", SqlDbType.Float, 0)
                pDon_Gia.Value = Don_Gia
                MyCommand.Parameters.Add(pDon_Gia)

                Dim pMa_Tien_Te As SqlParameter = New SqlParameter("@Ma_Tien_Te", SqlDbType.VarChar, 5)
                pMa_Tien_Te.Value = Ma_Tien_Te
                MyCommand.Parameters.Add(pMa_Tien_Te)

                Dim pGia_Tri_Hang As SqlParameter = New SqlParameter("@Gia_Tri_Hang", SqlDbType.Float, 0)
                pGia_Tri_Hang.Value = Gia_Tri_Hang
                MyCommand.Parameters.Add(pGia_Tri_Hang)

                Dim pGia_Tri_Hang_VN As SqlParameter = New SqlParameter("@Gia_Tri_Hang_VN", SqlDbType.Int, 0)
                pGia_Tri_Hang_VN.Value = Gia_Tri_Hang_VN
                MyCommand.Parameters.Add(pGia_Tri_Hang_VN)

                Dim pThue_NK As SqlParameter = New SqlParameter("@Thue_NK", SqlDbType.Float, 0)
                pThue_NK.Value = Thue_NK
                MyCommand.Parameters.Add(pThue_NK)

                Dim pTien_Thue_NK As SqlParameter = New SqlParameter("@Tien_Thue_NK", SqlDbType.Int, 0)
                pTien_Thue_NK.Value = Tien_Thue_NK
                MyCommand.Parameters.Add(pTien_Thue_NK)

                Dim pThue_VAT As SqlParameter = New SqlParameter("@Thue_VAT", SqlDbType.Float, 0)
                pThue_VAT.Value = Thue_VAT
                MyCommand.Parameters.Add(pThue_VAT)

                Dim pTien_Thue_VAT As SqlParameter = New SqlParameter("@Tien_Thue_VAT", SqlDbType.Int, 0)
                pTien_Thue_VAT.Value = Tien_Thue_VAT
                MyCommand.Parameters.Add(pTien_Thue_VAT)

                Dim pThue_Dac_Biet As SqlParameter = New SqlParameter("@Thue_Dac_Biet", SqlDbType.Float, 0)
                pThue_Dac_Biet.Value = Thue_Dac_Biet
                MyCommand.Parameters.Add(pThue_Dac_Biet)

                Dim pTien_Thue_Dac_Biet As SqlParameter = New SqlParameter("@Tien_Thue_Dac_Biet", SqlDbType.Int, 0)
                pTien_Thue_Dac_Biet.Value = Tien_Thue_Dac_Biet
                MyCommand.Parameters.Add(pTien_Thue_Dac_Biet)

                Dim pThue_Tieu_Thu As SqlParameter = New SqlParameter("@Thue_Tieu_Thu", SqlDbType.Float, 0)
                pThue_Tieu_Thu.Value = Thue_Tieu_Thu
                MyCommand.Parameters.Add(pThue_Tieu_Thu)

                Dim pTien_Thue_Tieu_Thu As SqlParameter = New SqlParameter("@Tien_Thue_Tieu_Thu", SqlDbType.Int, 0)
                pTien_Thue_Tieu_Thu.Value = Tien_Thue_Tieu_Thu
                MyCommand.Parameters.Add(pTien_Thue_Tieu_Thu)

                Dim pThue_Qua_Tang As SqlParameter = New SqlParameter("@Thue_Qua_Tang", SqlDbType.Float, 0)
                pThue_Qua_Tang.Value = Thue_Qua_Tang
                MyCommand.Parameters.Add(pThue_Qua_Tang)

                Dim pTien_Thue_Qua_Tang As SqlParameter = New SqlParameter("@Tien_Thue_Qua_Tang", SqlDbType.Int, 0)
                pTien_Thue_Qua_Tang.Value = Tien_Thue_Qua_Tang
                MyCommand.Parameters.Add(pTien_Thue_Qua_Tang)

                Dim pThue_Han_Ngach As SqlParameter = New SqlParameter("@Thue_Han_Ngach", SqlDbType.Float, 0)
                pThue_Han_Ngach.Value = Thue_Han_Ngach
                MyCommand.Parameters.Add(pThue_Han_Ngach)

                Dim pTien_Thue_Han_Ngach As SqlParameter = New SqlParameter("@Tien_Thue_Han_Ngach", SqlDbType.Int, 0)
                pTien_Thue_Han_Ngach.Value = Tien_Thue_Han_Ngach
                MyCommand.Parameters.Add(pTien_Thue_Han_Ngach)

                Dim pThue_Uu_Dai As SqlParameter = New SqlParameter("@Thue_Uu_Dai", SqlDbType.Float, 0)
                pThue_Uu_Dai.Value = Thue_Uu_Dai
                MyCommand.Parameters.Add(pThue_Uu_Dai)

                Dim pTien_Thue_Uu_Dai As SqlParameter = New SqlParameter("@Tien_Thue_Uu_Dai", SqlDbType.Int, 0)
                pTien_Thue_Uu_Dai.Value = Tien_Thue_Uu_Dai
                MyCommand.Parameters.Add(pTien_Thue_Uu_Dai)

                Dim pTong_Thue As SqlParameter = New SqlParameter("@Tong_Thue", SqlDbType.Int, 0)
                pTong_Thue.Value = Tong_Thue
                MyCommand.Parameters.Add(pTong_Thue)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                MyCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                MyCommand.Parameters.Add(pId_Ca)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Value = Ngay_He_Thong
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Value = Gio_He_Thong
                MyCommand.Parameters.Add(pGio_He_Thong)

                Dim pDa_Truyen As SqlParameter = New SqlParameter("@Da_Truyen", SqlDbType.Bit, 0)
                pDa_Truyen.Value = Da_Truyen
                MyCommand.Parameters.Add(pDa_Truyen)

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

#Region "E1_Hang_Kiem_Hoa_Xuat_Xoa"
        Public Function E1_Hang_Kiem_Hoa_Xuat_Xoa(ByVal Id_Chi_Tiet As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Hang_Kiem_Hoa_Xuat_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet As New E1_Hang_Kiem_Hoa_Xuat_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Chi_Tiet As SqlParameter = New SqlParameter("@Id_Chi_Tiet", SqlDbType.VarChar, 52)
                pId_Chi_Tiet.Value = Id_Chi_Tiet
                MyCommand.Parameters.Add(pId_Chi_Tiet)


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

#Region "E1_Hang_Kiem_Hoa_Xuat_Xoa_Boi_Id_E1"
        Public Function E1_Hang_Kiem_Hoa_Xuat_Xoa_Boi_Id_E1(ByVal Id_E1 As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Hang_Kiem_Hoa_Xuat_Xoa_Boi_Id_E1"
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

#Region "E1_Hang_Kiem_Hoa_Xuat_Xoa_Boi_Ma_To_Khai"
        Public Function E1_Hang_Kiem_Hoa_Xuat_Xoa_Boi_Ma_To_Khai(ByVal Ma_To_Khai As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Hang_Kiem_Hoa_Xuat_Xoa_Boi_Ma_To_Khai"
            MyCommand.CommandType = CommandType.StoredProcedure


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

#Region "E1_Hang_Kiem_Hoa_Xuat_Cap_Nhat_Ma_To_Khai_Thuc_Cap"
        Public Function E1_Hang_Kiem_Hoa_Xuat_Cap_Nhat_Ma_To_Khai_Thuc_Cap(ByVal Ma_To_Khai_GIp_May_Tinh As String, ByVal Ma_To_Khai_Thuc_Cap As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Hang_Kiem_Hoa_Xuat_Cap_Nhat_Ma_To_Khai_Thuc_Cap"
            MyCommand.CommandType = CommandType.StoredProcedure

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_To_Khai_GIp_May_Tinh As SqlParameter = New SqlParameter("@Ma_To_Khai_GIp_May_Tinh", SqlDbType.VarChar, 20)
                pMa_To_Khai_GIp_May_Tinh.Value = Ma_To_Khai_GIp_May_Tinh
                MyCommand.Parameters.Add(pMa_To_Khai_GIp_May_Tinh)

                Dim pMa_To_Khai_Thuc_Cap As SqlParameter = New SqlParameter("@Ma_To_Khai_Thuc_Cap", SqlDbType.VarChar, 20)
                pMa_To_Khai_Thuc_Cap.Value = Ma_To_Khai_Thuc_Cap
                MyCommand.Parameters.Add(pMa_To_Khai_Thuc_Cap)


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

#Region "E1_Hang_Kiem_Hoa_Xuat_Lay_STT_Max_Theo_Id_E1"
        Public Function E1_Hang_Kiem_Hoa_Xuat_Lay_STT_Max_Theo_Id_E1(ByVal Id_E1 As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Hang_Kiem_Hoa_Xuat_Lay_STT_Max_Theo_Id_E1"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet As New E1_Hang_Kiem_Hoa_Xuat_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                MyCommand.Parameters.Add(pId_E1)

                Dim pSTT_Max As SqlParameter = New SqlParameter("@STT_Max", SqlDbType.Int, 0)
                pSTT_Max.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSTT_Max)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values               

                Return pSTT_Max.Value
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


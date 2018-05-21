
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "Danh_Muc_Duong_Bay_So_Hieu_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop Danh_Muc_Duong_Bay_So_Hieu_Chi_Tiet
    'Tuong ung voi moi truong trong bang Danh_Muc_Duong_Bay_So_Hieu trong co so du lieu
    '***********************************************************
    Public Class Danh_Muc_Duong_Bay_So_Hieu_Chi_Tiet
        Public Id_Duong_Bay As String
        Public Id_Duong_Thu As String
        Public Loai_Van_Chuyen As Integer
        Public So_Hieu As String
        Public San_Bay_Xuat_Phat As String
        Public San_Bay_Do_Hang As String
        Public IPMC_Gui As String
        Public IPMC_Nhan As String
        Public Gio_Khoi_Hanh As Integer
        Public Gio_Den As Integer
        Public Qua_Ngay As Boolean
        Public Tong_So_Ngay As Integer
        Public Qua_Giang As Boolean
        Public So_Chang As Integer
        Public Su_Dung As Integer
        Public Ma_Bc_Qua_Giang As Integer
        Public Quy_Luat As Integer
        Public Thu_2 As Boolean
        Public Thu_3 As Boolean
        Public Thu_4 As Boolean
        Public Thu_5 As Boolean
        Public Thu_6 As Boolean
        Public Thu_7 As Boolean
        Public Chu_Nhat As Boolean
        Public Dot_Giao_Hang As Integer
        Public So_Hieu_1 As String
        Public Nuoc_Xuat_Phat_1 As String
        Public San_Bay_Xuat_Phat_1 As String
        Public Gio_Xuat_Phat_1 As Integer
        Public Nuoc_Den_1 As String
        Public San_Bay_Den_1 As String
        Public Gio_Den_1 As Integer
        Public Qua_Ngay_1 As Boolean
        Public Ghi_Chu_1 As String
        Public So_Hieu_2 As String
        Public Nuoc_Xuat_Phat_2 As String
        Public San_Bay_Xuat_Phat_2 As String
        Public Gio_Xuat_Phat_2 As Integer
        Public Nuoc_Den_2 As String
        Public San_Bay_Den_2 As String
        Public Gio_Den_2 As Integer
        Public Qua_Ngay_2 As Boolean
        Public Ghi_Chu_2 As String
        Public So_Hieu_3 As String
        Public Nuoc_Xuat_Phat_3 As String
        Public San_Bay_Xuat_Phat_3 As String
        Public Gio_Xuat_Phat_3 As Integer
        Public Nuoc_Den_3 As String
        Public San_Bay_Den_3 As String
        Public Gio_Den_3 As Integer
        Public Qua_Ngay_3 As Boolean
        Public Ghi_Chu_3 As String
        Public So_Hieu_4 As String
        Public Nuoc_Xuat_Phat_4 As String
        Public San_Bay_Xuat_Phat_4 As String
        Public Gio_Xuat_Phat_4 As Integer
        Public Nuoc_Den_4 As String
        Public San_Bay_Den_4 As String
        Public Gio_Den_4 As Integer
        Public Qua_Ngay_4 As Boolean
        Public Ghi_Chu_4 As String
        Public So_Hieu_5 As String
        Public Nuoc_Xuat_Phat_5 As String
        Public San_Bay_Xuat_Phat_5 As String
        Public Gio_Xuat_Phat_5 As Integer
        Public Nuoc_Den_5 As String
        Public San_Bay_Den_5 As String
        Public Gio_Den_5 As Integer
        Public Qua_Ngay_5 As Boolean
        Public Ghi_Chu_5 As String
    End Class
#End Region

#Region "Danh_Muc_Duong_Bay_So_Hieu"
    Public Class Danh_Muc_Duong_Bay_So_Hieu
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "Danh_Muc_Duong_Bay_So_Hieu_Cap_Nhat"
        Public Function Danh_Muc_Duong_Bay_So_Hieu_Cap_Nhat(ByVal Id_Duong_Bay As String, ByVal Id_Duong_Thu As String, ByVal Loai_Van_Chuyen As Integer, ByVal So_Hieu As String, ByVal San_Bay_Xuat_Phat As String, ByVal San_Bay_Do_Hang As String, ByVal IPMC_Gui As String, ByVal IPMC_Nhan As String, ByVal Gio_Khoi_Hanh As Integer, ByVal Gio_Den As Integer, ByVal Qua_Ngay As Boolean, ByVal Tong_So_Ngay As Integer, ByVal Qua_Giang As Boolean, ByVal So_Chang As Integer, ByVal Su_Dung As Integer, ByVal Ma_Bc_Qua_Giang As Integer, ByVal Quy_Luat As Integer, ByVal Thu_2 As Boolean, ByVal Thu_3 As Boolean, ByVal Thu_4 As Boolean, ByVal Thu_5 As Boolean, ByVal Thu_6 As Boolean, ByVal Thu_7 As Boolean, ByVal Chu_Nhat As Boolean, ByVal Dot_Giao_Hang As Integer, ByVal So_Hieu_1 As String, ByVal Nuoc_Xuat_Phat_1 As String, ByVal San_Bay_Xuat_Phat_1 As String, ByVal Gio_Xuat_Phat_1 As Integer, ByVal Nuoc_Den_1 As String, ByVal San_Bay_Den_1 As String, ByVal Gio_Den_1 As Integer, ByVal Qua_Ngay_1 As Boolean, ByVal Ghi_Chu_1 As String, ByVal So_Hieu_2 As String, ByVal Nuoc_Xuat_Phat_2 As String, ByVal San_Bay_Xuat_Phat_2 As String, ByVal Gio_Xuat_Phat_2 As Integer, ByVal Nuoc_Den_2 As String, ByVal San_Bay_Den_2 As String, ByVal Gio_Den_2 As Integer, ByVal Qua_Ngay_2 As Boolean, ByVal Ghi_Chu_2 As String, ByVal So_Hieu_3 As String, ByVal Nuoc_Xuat_Phat_3 As String, ByVal San_Bay_Xuat_Phat_3 As String, ByVal Gio_Xuat_Phat_3 As Integer, ByVal Nuoc_Den_3 As String, ByVal San_Bay_Den_3 As String, ByVal Gio_Den_3 As Integer, ByVal Qua_Ngay_3 As Boolean, ByVal Ghi_Chu_3 As String, ByVal So_Hieu_4 As String, ByVal Nuoc_Xuat_Phat_4 As String, ByVal San_Bay_Xuat_Phat_4 As String, ByVal Gio_Xuat_Phat_4 As Integer, ByVal Nuoc_Den_4 As String, ByVal San_Bay_Den_4 As String, ByVal Gio_Den_4 As Integer, ByVal Qua_Ngay_4 As Boolean, ByVal Ghi_Chu_4 As String, ByVal So_Hieu_5 As String, ByVal Nuoc_Xuat_Phat_5 As String, ByVal San_Bay_Xuat_Phat_5 As String, ByVal Gio_Xuat_Phat_5 As Integer, ByVal Nuoc_Den_5 As String, ByVal San_Bay_Den_5 As String, ByVal Gio_Den_5 As Integer, ByVal Qua_Ngay_5 As Boolean, ByVal Ghi_Chu_5 As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Duong_Bay_So_Hieu_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet As New Danh_Muc_Duong_Bay_So_Hieu_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Duong_Bay As SqlParameter = New SqlParameter("@Id_Duong_Bay", SqlDbType.VarChar, 50)
                pId_Duong_Bay.Value = Id_Duong_Bay
                MyCommand.Parameters.Add(pId_Duong_Bay)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pLoai_Van_Chuyen As SqlParameter = New SqlParameter("@Loai_Van_Chuyen", SqlDbType.Int, 0)
                pLoai_Van_Chuyen.Value = Loai_Van_Chuyen
                MyCommand.Parameters.Add(pLoai_Van_Chuyen)

                Dim pSo_Hieu As SqlParameter = New SqlParameter("@So_Hieu", SqlDbType.VarChar, 30)
                pSo_Hieu.Value = So_Hieu
                MyCommand.Parameters.Add(pSo_Hieu)

                Dim pSan_Bay_Xuat_Phat As SqlParameter = New SqlParameter("@San_Bay_Xuat_Phat", SqlDbType.VarChar, 10)
                pSan_Bay_Xuat_Phat.Value = San_Bay_Xuat_Phat
                MyCommand.Parameters.Add(pSan_Bay_Xuat_Phat)

                Dim pSan_Bay_Do_Hang As SqlParameter = New SqlParameter("@San_Bay_Do_Hang", SqlDbType.VarChar, 10)
                pSan_Bay_Do_Hang.Value = San_Bay_Do_Hang
                MyCommand.Parameters.Add(pSan_Bay_Do_Hang)

                Dim pIPMC_Gui As SqlParameter = New SqlParameter("@IPMC_Gui", SqlDbType.VarChar, 6)
                pIPMC_Gui.Value = IPMC_Gui
                MyCommand.Parameters.Add(pIPMC_Gui)

                Dim pIPMC_Nhan As SqlParameter = New SqlParameter("@IPMC_Nhan", SqlDbType.VarChar, 6)
                pIPMC_Nhan.Value = IPMC_Nhan
                MyCommand.Parameters.Add(pIPMC_Nhan)

                Dim pGio_Khoi_Hanh As SqlParameter = New SqlParameter("@Gio_Khoi_Hanh", SqlDbType.Int, 0)
                pGio_Khoi_Hanh.Value = Gio_Khoi_Hanh
                MyCommand.Parameters.Add(pGio_Khoi_Hanh)

                Dim pGio_Den As SqlParameter = New SqlParameter("@Gio_Den", SqlDbType.Int, 0)
                pGio_Den.Value = Gio_Den
                MyCommand.Parameters.Add(pGio_Den)

                Dim pQua_Ngay As SqlParameter = New SqlParameter("@Qua_Ngay", SqlDbType.Bit, 0)
                pQua_Ngay.Value = Qua_Ngay
                MyCommand.Parameters.Add(pQua_Ngay)

                Dim pTong_So_Ngay As SqlParameter = New SqlParameter("@Tong_So_Ngay", SqlDbType.Int, 0)
                pTong_So_Ngay.Value = Tong_So_Ngay
                MyCommand.Parameters.Add(pTong_So_Ngay)

                Dim pQua_Giang As SqlParameter = New SqlParameter("@Qua_Giang", SqlDbType.Bit, 0)
                pQua_Giang.Value = Qua_Giang
                MyCommand.Parameters.Add(pQua_Giang)

                Dim pSo_Chang As SqlParameter = New SqlParameter("@So_Chang", SqlDbType.Int, 0)
                pSo_Chang.Value = So_Chang
                MyCommand.Parameters.Add(pSo_Chang)

                Dim pSu_Dung As SqlParameter = New SqlParameter("@Su_Dung", SqlDbType.Int, 0)
                pSu_Dung.Value = Su_Dung
                MyCommand.Parameters.Add(pSu_Dung)

                Dim pMa_Bc_Qua_Giang As SqlParameter = New SqlParameter("@Ma_Bc_Qua_Giang", SqlDbType.Int, 0)
                pMa_Bc_Qua_Giang.Value = Ma_Bc_Qua_Giang
                MyCommand.Parameters.Add(pMa_Bc_Qua_Giang)

                Dim pQuy_Luat As SqlParameter = New SqlParameter("@Quy_Luat", SqlDbType.Int, 0)
                pQuy_Luat.Value = Quy_Luat
                MyCommand.Parameters.Add(pQuy_Luat)

                Dim pThu_2 As SqlParameter = New SqlParameter("@Thu_2", SqlDbType.Bit, 0)
                pThu_2.Value = Thu_2
                MyCommand.Parameters.Add(pThu_2)

                Dim pThu_3 As SqlParameter = New SqlParameter("@Thu_3", SqlDbType.Bit, 0)
                pThu_3.Value = Thu_3
                MyCommand.Parameters.Add(pThu_3)

                Dim pThu_4 As SqlParameter = New SqlParameter("@Thu_4", SqlDbType.Bit, 0)
                pThu_4.Value = Thu_4
                MyCommand.Parameters.Add(pThu_4)

                Dim pThu_5 As SqlParameter = New SqlParameter("@Thu_5", SqlDbType.Bit, 0)
                pThu_5.Value = Thu_5
                MyCommand.Parameters.Add(pThu_5)

                Dim pThu_6 As SqlParameter = New SqlParameter("@Thu_6", SqlDbType.Bit, 0)
                pThu_6.Value = Thu_6
                MyCommand.Parameters.Add(pThu_6)

                Dim pThu_7 As SqlParameter = New SqlParameter("@Thu_7", SqlDbType.Bit, 0)
                pThu_7.Value = Thu_7
                MyCommand.Parameters.Add(pThu_7)

                Dim pChu_Nhat As SqlParameter = New SqlParameter("@Chu_Nhat", SqlDbType.Bit, 0)
                pChu_Nhat.Value = Chu_Nhat
                MyCommand.Parameters.Add(pChu_Nhat)

                Dim pDot_Giao_Hang As SqlParameter = New SqlParameter("@Dot_Giao_Hang", SqlDbType.Int, 0)
                pDot_Giao_Hang.Value = Dot_Giao_Hang
                MyCommand.Parameters.Add(pDot_Giao_Hang)

                Dim pSo_Hieu_1 As SqlParameter = New SqlParameter("@So_Hieu_1", SqlDbType.VarChar, 10)
                pSo_Hieu_1.Value = So_Hieu_1
                MyCommand.Parameters.Add(pSo_Hieu_1)

                Dim pNuoc_Xuat_Phat_1 As SqlParameter = New SqlParameter("@Nuoc_Xuat_Phat_1", SqlDbType.VarChar, 2)
                pNuoc_Xuat_Phat_1.Value = Nuoc_Xuat_Phat_1
                MyCommand.Parameters.Add(pNuoc_Xuat_Phat_1)

                Dim pSan_Bay_Xuat_Phat_1 As SqlParameter = New SqlParameter("@San_Bay_Xuat_Phat_1", SqlDbType.VarChar, 3)
                pSan_Bay_Xuat_Phat_1.Value = San_Bay_Xuat_Phat_1
                MyCommand.Parameters.Add(pSan_Bay_Xuat_Phat_1)

                Dim pGio_Xuat_Phat_1 As SqlParameter = New SqlParameter("@Gio_Xuat_Phat_1", SqlDbType.Int, 0)
                pGio_Xuat_Phat_1.Value = Gio_Xuat_Phat_1
                MyCommand.Parameters.Add(pGio_Xuat_Phat_1)

                Dim pNuoc_Den_1 As SqlParameter = New SqlParameter("@Nuoc_Den_1", SqlDbType.VarChar, 2)
                pNuoc_Den_1.Value = Nuoc_Den_1
                MyCommand.Parameters.Add(pNuoc_Den_1)

                Dim pSan_Bay_Den_1 As SqlParameter = New SqlParameter("@San_Bay_Den_1", SqlDbType.VarChar, 3)
                pSan_Bay_Den_1.Value = San_Bay_Den_1
                MyCommand.Parameters.Add(pSan_Bay_Den_1)

                Dim pGio_Den_1 As SqlParameter = New SqlParameter("@Gio_Den_1", SqlDbType.Int, 0)
                pGio_Den_1.Value = Gio_Den_1
                MyCommand.Parameters.Add(pGio_Den_1)

                Dim pQua_Ngay_1 As SqlParameter = New SqlParameter("@Qua_Ngay_1", SqlDbType.Bit, 0)
                pQua_Ngay_1.Value = Qua_Ngay_1
                MyCommand.Parameters.Add(pQua_Ngay_1)

                Dim pGhi_Chu_1 As SqlParameter = New SqlParameter("@Ghi_Chu_1", SqlDbType.VarChar, 50)
                pGhi_Chu_1.Value = Ghi_Chu_1
                MyCommand.Parameters.Add(pGhi_Chu_1)

                Dim pSo_Hieu_2 As SqlParameter = New SqlParameter("@So_Hieu_2", SqlDbType.VarChar, 10)
                pSo_Hieu_2.Value = So_Hieu_2
                MyCommand.Parameters.Add(pSo_Hieu_2)

                Dim pNuoc_Xuat_Phat_2 As SqlParameter = New SqlParameter("@Nuoc_Xuat_Phat_2", SqlDbType.VarChar, 2)
                pNuoc_Xuat_Phat_2.Value = Nuoc_Xuat_Phat_2
                MyCommand.Parameters.Add(pNuoc_Xuat_Phat_2)

                Dim pSan_Bay_Xuat_Phat_2 As SqlParameter = New SqlParameter("@San_Bay_Xuat_Phat_2", SqlDbType.VarChar, 3)
                pSan_Bay_Xuat_Phat_2.Value = San_Bay_Xuat_Phat_2
                MyCommand.Parameters.Add(pSan_Bay_Xuat_Phat_2)

                Dim pGio_Xuat_Phat_2 As SqlParameter = New SqlParameter("@Gio_Xuat_Phat_2", SqlDbType.Int, 0)
                pGio_Xuat_Phat_2.Value = Gio_Xuat_Phat_2
                MyCommand.Parameters.Add(pGio_Xuat_Phat_2)

                Dim pNuoc_Den_2 As SqlParameter = New SqlParameter("@Nuoc_Den_2", SqlDbType.VarChar, 2)
                pNuoc_Den_2.Value = Nuoc_Den_2
                MyCommand.Parameters.Add(pNuoc_Den_2)

                Dim pSan_Bay_Den_2 As SqlParameter = New SqlParameter("@San_Bay_Den_2", SqlDbType.VarChar, 3)
                pSan_Bay_Den_2.Value = San_Bay_Den_2
                MyCommand.Parameters.Add(pSan_Bay_Den_2)

                Dim pGio_Den_2 As SqlParameter = New SqlParameter("@Gio_Den_2", SqlDbType.Int, 0)
                pGio_Den_2.Value = Gio_Den_2
                MyCommand.Parameters.Add(pGio_Den_2)

                Dim pQua_Ngay_2 As SqlParameter = New SqlParameter("@Qua_Ngay_2", SqlDbType.Bit, 0)
                pQua_Ngay_2.Value = Qua_Ngay_2
                MyCommand.Parameters.Add(pQua_Ngay_2)

                Dim pGhi_Chu_2 As SqlParameter = New SqlParameter("@Ghi_Chu_2", SqlDbType.VarChar, 50)
                pGhi_Chu_2.Value = Ghi_Chu_2
                MyCommand.Parameters.Add(pGhi_Chu_2)

                Dim pSo_Hieu_3 As SqlParameter = New SqlParameter("@So_Hieu_3", SqlDbType.VarChar, 10)
                pSo_Hieu_3.Value = So_Hieu_3
                MyCommand.Parameters.Add(pSo_Hieu_3)

                Dim pNuoc_Xuat_Phat_3 As SqlParameter = New SqlParameter("@Nuoc_Xuat_Phat_3", SqlDbType.VarChar, 2)
                pNuoc_Xuat_Phat_3.Value = Nuoc_Xuat_Phat_3
                MyCommand.Parameters.Add(pNuoc_Xuat_Phat_3)

                Dim pSan_Bay_Xuat_Phat_3 As SqlParameter = New SqlParameter("@San_Bay_Xuat_Phat_3", SqlDbType.VarChar, 3)
                pSan_Bay_Xuat_Phat_3.Value = San_Bay_Xuat_Phat_3
                MyCommand.Parameters.Add(pSan_Bay_Xuat_Phat_3)

                Dim pGio_Xuat_Phat_3 As SqlParameter = New SqlParameter("@Gio_Xuat_Phat_3", SqlDbType.Int, 0)
                pGio_Xuat_Phat_3.Value = Gio_Xuat_Phat_3
                MyCommand.Parameters.Add(pGio_Xuat_Phat_3)

                Dim pNuoc_Den_3 As SqlParameter = New SqlParameter("@Nuoc_Den_3", SqlDbType.VarChar, 2)
                pNuoc_Den_3.Value = Nuoc_Den_3
                MyCommand.Parameters.Add(pNuoc_Den_3)

                Dim pSan_Bay_Den_3 As SqlParameter = New SqlParameter("@San_Bay_Den_3", SqlDbType.VarChar, 3)
                pSan_Bay_Den_3.Value = San_Bay_Den_3
                MyCommand.Parameters.Add(pSan_Bay_Den_3)

                Dim pGio_Den_3 As SqlParameter = New SqlParameter("@Gio_Den_3", SqlDbType.Int, 0)
                pGio_Den_3.Value = Gio_Den_3
                MyCommand.Parameters.Add(pGio_Den_3)

                Dim pQua_Ngay_3 As SqlParameter = New SqlParameter("@Qua_Ngay_3", SqlDbType.Bit, 0)
                pQua_Ngay_3.Value = Qua_Ngay_3
                MyCommand.Parameters.Add(pQua_Ngay_3)

                Dim pGhi_Chu_3 As SqlParameter = New SqlParameter("@Ghi_Chu_3", SqlDbType.VarChar, 50)
                pGhi_Chu_3.Value = Ghi_Chu_3
                MyCommand.Parameters.Add(pGhi_Chu_3)

                Dim pSo_Hieu_4 As SqlParameter = New SqlParameter("@So_Hieu_4", SqlDbType.VarChar, 10)
                pSo_Hieu_4.Value = So_Hieu_4
                MyCommand.Parameters.Add(pSo_Hieu_4)

                Dim pNuoc_Xuat_Phat_4 As SqlParameter = New SqlParameter("@Nuoc_Xuat_Phat_4", SqlDbType.VarChar, 2)
                pNuoc_Xuat_Phat_4.Value = Nuoc_Xuat_Phat_4
                MyCommand.Parameters.Add(pNuoc_Xuat_Phat_4)

                Dim pSan_Bay_Xuat_Phat_4 As SqlParameter = New SqlParameter("@San_Bay_Xuat_Phat_4", SqlDbType.VarChar, 3)
                pSan_Bay_Xuat_Phat_4.Value = San_Bay_Xuat_Phat_4
                MyCommand.Parameters.Add(pSan_Bay_Xuat_Phat_4)

                Dim pGio_Xuat_Phat_4 As SqlParameter = New SqlParameter("@Gio_Xuat_Phat_4", SqlDbType.Int, 0)
                pGio_Xuat_Phat_4.Value = Gio_Xuat_Phat_4
                MyCommand.Parameters.Add(pGio_Xuat_Phat_4)

                Dim pNuoc_Den_4 As SqlParameter = New SqlParameter("@Nuoc_Den_4", SqlDbType.VarChar, 2)
                pNuoc_Den_4.Value = Nuoc_Den_4
                MyCommand.Parameters.Add(pNuoc_Den_4)

                Dim pSan_Bay_Den_4 As SqlParameter = New SqlParameter("@San_Bay_Den_4", SqlDbType.VarChar, 3)
                pSan_Bay_Den_4.Value = San_Bay_Den_4
                MyCommand.Parameters.Add(pSan_Bay_Den_4)

                Dim pGio_Den_4 As SqlParameter = New SqlParameter("@Gio_Den_4", SqlDbType.Int, 0)
                pGio_Den_4.Value = Gio_Den_4
                MyCommand.Parameters.Add(pGio_Den_4)

                Dim pQua_Ngay_4 As SqlParameter = New SqlParameter("@Qua_Ngay_4", SqlDbType.Bit, 0)
                pQua_Ngay_4.Value = Qua_Ngay_4
                MyCommand.Parameters.Add(pQua_Ngay_4)

                Dim pGhi_Chu_4 As SqlParameter = New SqlParameter("@Ghi_Chu_4", SqlDbType.VarChar, 50)
                pGhi_Chu_4.Value = Ghi_Chu_4
                MyCommand.Parameters.Add(pGhi_Chu_4)

                Dim pSo_Hieu_5 As SqlParameter = New SqlParameter("@So_Hieu_5", SqlDbType.VarChar, 10)
                pSo_Hieu_5.Value = So_Hieu_5
                MyCommand.Parameters.Add(pSo_Hieu_5)

                Dim pNuoc_Xuat_Phat_5 As SqlParameter = New SqlParameter("@Nuoc_Xuat_Phat_5", SqlDbType.VarChar, 2)
                pNuoc_Xuat_Phat_5.Value = Nuoc_Xuat_Phat_5
                MyCommand.Parameters.Add(pNuoc_Xuat_Phat_5)

                Dim pSan_Bay_Xuat_Phat_5 As SqlParameter = New SqlParameter("@San_Bay_Xuat_Phat_5", SqlDbType.VarChar, 3)
                pSan_Bay_Xuat_Phat_5.Value = San_Bay_Xuat_Phat_5
                MyCommand.Parameters.Add(pSan_Bay_Xuat_Phat_5)

                Dim pGio_Xuat_Phat_5 As SqlParameter = New SqlParameter("@Gio_Xuat_Phat_5", SqlDbType.Int, 0)
                pGio_Xuat_Phat_5.Value = Gio_Xuat_Phat_5
                MyCommand.Parameters.Add(pGio_Xuat_Phat_5)

                Dim pNuoc_Den_5 As SqlParameter = New SqlParameter("@Nuoc_Den_5", SqlDbType.VarChar, 2)
                pNuoc_Den_5.Value = Nuoc_Den_5
                MyCommand.Parameters.Add(pNuoc_Den_5)

                Dim pSan_Bay_Den_5 As SqlParameter = New SqlParameter("@San_Bay_Den_5", SqlDbType.VarChar, 3)
                pSan_Bay_Den_5.Value = San_Bay_Den_5
                MyCommand.Parameters.Add(pSan_Bay_Den_5)

                Dim pGio_Den_5 As SqlParameter = New SqlParameter("@Gio_Den_5", SqlDbType.Int, 0)
                pGio_Den_5.Value = Gio_Den_5
                MyCommand.Parameters.Add(pGio_Den_5)

                Dim pQua_Ngay_5 As SqlParameter = New SqlParameter("@Qua_Ngay_5", SqlDbType.Bit, 0)
                pQua_Ngay_5.Value = Qua_Ngay_5
                MyCommand.Parameters.Add(pQua_Ngay_5)

                Dim pGhi_Chu_5 As SqlParameter = New SqlParameter("@Ghi_Chu_5", SqlDbType.VarChar, 50)
                pGhi_Chu_5.Value = Ghi_Chu_5
                MyCommand.Parameters.Add(pGhi_Chu_5)


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

#Region "Danh_Muc_Duong_Bay_So_Hieu_Cap_Nhat_Them"
        Public Function Danh_Muc_Duong_Bay_So_Hieu_Cap_Nhat_Them(ByVal Id_Duong_Bay As String, ByVal Id_Duong_Thu As String, ByVal Loai_Van_Chuyen As Integer, ByVal So_Hieu As String, ByVal San_Bay_Xuat_Phat As String, ByVal San_Bay_Do_Hang As String, ByVal IPMC_Gui As String, ByVal IPMC_Nhan As String, ByVal Gio_Khoi_Hanh As Integer, ByVal Gio_Den As Integer, ByVal Qua_Ngay As Boolean, ByVal Tong_So_Ngay As Integer, ByVal Qua_Giang As Boolean, ByVal So_Chang As Integer, ByVal Su_Dung As Integer, ByVal Ma_Bc_Qua_Giang As Integer, ByVal Quy_Luat As Integer, ByVal Thu_2 As Boolean, ByVal Thu_3 As Boolean, ByVal Thu_4 As Boolean, ByVal Thu_5 As Boolean, ByVal Thu_6 As Boolean, ByVal Thu_7 As Boolean, ByVal Chu_Nhat As Boolean, ByVal Dot_Giao_Hang As Integer, ByVal So_Hieu_1 As String, ByVal Nuoc_Xuat_Phat_1 As String, ByVal San_Bay_Xuat_Phat_1 As String, ByVal Gio_Xuat_Phat_1 As Integer, ByVal Nuoc_Den_1 As String, ByVal San_Bay_Den_1 As String, ByVal Gio_Den_1 As Integer, ByVal Qua_Ngay_1 As Boolean, ByVal Ghi_Chu_1 As String, ByVal So_Hieu_2 As String, ByVal Nuoc_Xuat_Phat_2 As String, ByVal San_Bay_Xuat_Phat_2 As String, ByVal Gio_Xuat_Phat_2 As Integer, ByVal Nuoc_Den_2 As String, ByVal San_Bay_Den_2 As String, ByVal Gio_Den_2 As Integer, ByVal Qua_Ngay_2 As Boolean, ByVal Ghi_Chu_2 As String, ByVal So_Hieu_3 As String, ByVal Nuoc_Xuat_Phat_3 As String, ByVal San_Bay_Xuat_Phat_3 As String, ByVal Gio_Xuat_Phat_3 As Integer, ByVal Nuoc_Den_3 As String, ByVal San_Bay_Den_3 As String, ByVal Gio_Den_3 As Integer, ByVal Qua_Ngay_3 As Boolean, ByVal Ghi_Chu_3 As String, ByVal So_Hieu_4 As String, ByVal Nuoc_Xuat_Phat_4 As String, ByVal San_Bay_Xuat_Phat_4 As String, ByVal Gio_Xuat_Phat_4 As Integer, ByVal Nuoc_Den_4 As String, ByVal San_Bay_Den_4 As String, ByVal Gio_Den_4 As Integer, ByVal Qua_Ngay_4 As Boolean, ByVal Ghi_Chu_4 As String, ByVal So_Hieu_5 As String, ByVal Nuoc_Xuat_Phat_5 As String, ByVal San_Bay_Xuat_Phat_5 As String, ByVal Gio_Xuat_Phat_5 As Integer, ByVal Nuoc_Den_5 As String, ByVal San_Bay_Den_5 As String, ByVal Gio_Den_5 As Integer, ByVal Qua_Ngay_5 As Boolean, ByVal Ghi_Chu_5 As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Duong_Bay_So_Hieu_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet As New Danh_Muc_Duong_Bay_So_Hieu_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Duong_Bay As SqlParameter = New SqlParameter("@Id_Duong_Bay", SqlDbType.VarChar, 50)
                pId_Duong_Bay.Value = Id_Duong_Bay
                MyCommand.Parameters.Add(pId_Duong_Bay)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pLoai_Van_Chuyen As SqlParameter = New SqlParameter("@Loai_Van_Chuyen", SqlDbType.Int, 0)
                pLoai_Van_Chuyen.Value = Loai_Van_Chuyen
                MyCommand.Parameters.Add(pLoai_Van_Chuyen)

                Dim pSo_Hieu As SqlParameter = New SqlParameter("@So_Hieu", SqlDbType.VarChar, 30)
                pSo_Hieu.Value = So_Hieu
                MyCommand.Parameters.Add(pSo_Hieu)

                Dim pSan_Bay_Xuat_Phat As SqlParameter = New SqlParameter("@San_Bay_Xuat_Phat", SqlDbType.VarChar, 10)
                pSan_Bay_Xuat_Phat.Value = San_Bay_Xuat_Phat
                MyCommand.Parameters.Add(pSan_Bay_Xuat_Phat)

                Dim pSan_Bay_Do_Hang As SqlParameter = New SqlParameter("@San_Bay_Do_Hang", SqlDbType.VarChar, 10)
                pSan_Bay_Do_Hang.Value = San_Bay_Do_Hang
                MyCommand.Parameters.Add(pSan_Bay_Do_Hang)

                Dim pIPMC_Gui As SqlParameter = New SqlParameter("@IPMC_Gui", SqlDbType.VarChar, 6)
                pIPMC_Gui.Value = IPMC_Gui
                MyCommand.Parameters.Add(pIPMC_Gui)

                Dim pIPMC_Nhan As SqlParameter = New SqlParameter("@IPMC_Nhan", SqlDbType.VarChar, 6)
                pIPMC_Nhan.Value = IPMC_Nhan
                MyCommand.Parameters.Add(pIPMC_Nhan)

                Dim pGio_Khoi_Hanh As SqlParameter = New SqlParameter("@Gio_Khoi_Hanh", SqlDbType.Int, 0)
                pGio_Khoi_Hanh.Value = Gio_Khoi_Hanh
                MyCommand.Parameters.Add(pGio_Khoi_Hanh)

                Dim pGio_Den As SqlParameter = New SqlParameter("@Gio_Den", SqlDbType.Int, 0)
                pGio_Den.Value = Gio_Den
                MyCommand.Parameters.Add(pGio_Den)

                Dim pQua_Ngay As SqlParameter = New SqlParameter("@Qua_Ngay", SqlDbType.Bit, 0)
                pQua_Ngay.Value = Qua_Ngay
                MyCommand.Parameters.Add(pQua_Ngay)

                Dim pTong_So_Ngay As SqlParameter = New SqlParameter("@Tong_So_Ngay", SqlDbType.Int, 0)
                pTong_So_Ngay.Value = Tong_So_Ngay
                MyCommand.Parameters.Add(pTong_So_Ngay)

                Dim pQua_Giang As SqlParameter = New SqlParameter("@Qua_Giang", SqlDbType.Bit, 0)
                pQua_Giang.Value = Qua_Giang
                MyCommand.Parameters.Add(pQua_Giang)

                Dim pSo_Chang As SqlParameter = New SqlParameter("@So_Chang", SqlDbType.Int, 0)
                pSo_Chang.Value = So_Chang
                MyCommand.Parameters.Add(pSo_Chang)

                Dim pSu_Dung As SqlParameter = New SqlParameter("@Su_Dung", SqlDbType.Int, 0)
                pSu_Dung.Value = Su_Dung
                MyCommand.Parameters.Add(pSu_Dung)

                Dim pMa_Bc_Qua_Giang As SqlParameter = New SqlParameter("@Ma_Bc_Qua_Giang", SqlDbType.Int, 0)
                pMa_Bc_Qua_Giang.Value = Ma_Bc_Qua_Giang
                MyCommand.Parameters.Add(pMa_Bc_Qua_Giang)

                Dim pQuy_Luat As SqlParameter = New SqlParameter("@Quy_Luat", SqlDbType.Int, 0)
                pQuy_Luat.Value = Quy_Luat
                MyCommand.Parameters.Add(pQuy_Luat)

                Dim pThu_2 As SqlParameter = New SqlParameter("@Thu_2", SqlDbType.Bit, 0)
                pThu_2.Value = Thu_2
                MyCommand.Parameters.Add(pThu_2)

                Dim pThu_3 As SqlParameter = New SqlParameter("@Thu_3", SqlDbType.Bit, 0)
                pThu_3.Value = Thu_3
                MyCommand.Parameters.Add(pThu_3)

                Dim pThu_4 As SqlParameter = New SqlParameter("@Thu_4", SqlDbType.Bit, 0)
                pThu_4.Value = Thu_4
                MyCommand.Parameters.Add(pThu_4)

                Dim pThu_5 As SqlParameter = New SqlParameter("@Thu_5", SqlDbType.Bit, 0)
                pThu_5.Value = Thu_5
                MyCommand.Parameters.Add(pThu_5)

                Dim pThu_6 As SqlParameter = New SqlParameter("@Thu_6", SqlDbType.Bit, 0)
                pThu_6.Value = Thu_6
                MyCommand.Parameters.Add(pThu_6)

                Dim pThu_7 As SqlParameter = New SqlParameter("@Thu_7", SqlDbType.Bit, 0)
                pThu_7.Value = Thu_7
                MyCommand.Parameters.Add(pThu_7)

                Dim pChu_Nhat As SqlParameter = New SqlParameter("@Chu_Nhat", SqlDbType.Bit, 0)
                pChu_Nhat.Value = Chu_Nhat
                MyCommand.Parameters.Add(pChu_Nhat)

                Dim pDot_Giao_Hang As SqlParameter = New SqlParameter("@Dot_Giao_Hang", SqlDbType.Int, 0)
                pDot_Giao_Hang.Value = Dot_Giao_Hang
                MyCommand.Parameters.Add(pDot_Giao_Hang)

                Dim pSo_Hieu_1 As SqlParameter = New SqlParameter("@So_Hieu_1", SqlDbType.VarChar, 10)
                pSo_Hieu_1.Value = So_Hieu_1
                MyCommand.Parameters.Add(pSo_Hieu_1)

                Dim pNuoc_Xuat_Phat_1 As SqlParameter = New SqlParameter("@Nuoc_Xuat_Phat_1", SqlDbType.VarChar, 2)
                pNuoc_Xuat_Phat_1.Value = Nuoc_Xuat_Phat_1
                MyCommand.Parameters.Add(pNuoc_Xuat_Phat_1)

                Dim pSan_Bay_Xuat_Phat_1 As SqlParameter = New SqlParameter("@San_Bay_Xuat_Phat_1", SqlDbType.VarChar, 3)
                pSan_Bay_Xuat_Phat_1.Value = San_Bay_Xuat_Phat_1
                MyCommand.Parameters.Add(pSan_Bay_Xuat_Phat_1)

                Dim pGio_Xuat_Phat_1 As SqlParameter = New SqlParameter("@Gio_Xuat_Phat_1", SqlDbType.Int, 0)
                pGio_Xuat_Phat_1.Value = Gio_Xuat_Phat_1
                MyCommand.Parameters.Add(pGio_Xuat_Phat_1)

                Dim pNuoc_Den_1 As SqlParameter = New SqlParameter("@Nuoc_Den_1", SqlDbType.VarChar, 2)
                pNuoc_Den_1.Value = Nuoc_Den_1
                MyCommand.Parameters.Add(pNuoc_Den_1)

                Dim pSan_Bay_Den_1 As SqlParameter = New SqlParameter("@San_Bay_Den_1", SqlDbType.VarChar, 3)
                pSan_Bay_Den_1.Value = San_Bay_Den_1
                MyCommand.Parameters.Add(pSan_Bay_Den_1)

                Dim pGio_Den_1 As SqlParameter = New SqlParameter("@Gio_Den_1", SqlDbType.Int, 0)
                pGio_Den_1.Value = Gio_Den_1
                MyCommand.Parameters.Add(pGio_Den_1)

                Dim pQua_Ngay_1 As SqlParameter = New SqlParameter("@Qua_Ngay_1", SqlDbType.Bit, 0)
                pQua_Ngay_1.Value = Qua_Ngay_1
                MyCommand.Parameters.Add(pQua_Ngay_1)

                Dim pGhi_Chu_1 As SqlParameter = New SqlParameter("@Ghi_Chu_1", SqlDbType.VarChar, 50)
                pGhi_Chu_1.Value = Ghi_Chu_1
                MyCommand.Parameters.Add(pGhi_Chu_1)

                Dim pSo_Hieu_2 As SqlParameter = New SqlParameter("@So_Hieu_2", SqlDbType.VarChar, 10)
                pSo_Hieu_2.Value = So_Hieu_2
                MyCommand.Parameters.Add(pSo_Hieu_2)

                Dim pNuoc_Xuat_Phat_2 As SqlParameter = New SqlParameter("@Nuoc_Xuat_Phat_2", SqlDbType.VarChar, 2)
                pNuoc_Xuat_Phat_2.Value = Nuoc_Xuat_Phat_2
                MyCommand.Parameters.Add(pNuoc_Xuat_Phat_2)

                Dim pSan_Bay_Xuat_Phat_2 As SqlParameter = New SqlParameter("@San_Bay_Xuat_Phat_2", SqlDbType.VarChar, 3)
                pSan_Bay_Xuat_Phat_2.Value = San_Bay_Xuat_Phat_2
                MyCommand.Parameters.Add(pSan_Bay_Xuat_Phat_2)

                Dim pGio_Xuat_Phat_2 As SqlParameter = New SqlParameter("@Gio_Xuat_Phat_2", SqlDbType.Int, 0)
                pGio_Xuat_Phat_2.Value = Gio_Xuat_Phat_2
                MyCommand.Parameters.Add(pGio_Xuat_Phat_2)

                Dim pNuoc_Den_2 As SqlParameter = New SqlParameter("@Nuoc_Den_2", SqlDbType.VarChar, 2)
                pNuoc_Den_2.Value = Nuoc_Den_2
                MyCommand.Parameters.Add(pNuoc_Den_2)

                Dim pSan_Bay_Den_2 As SqlParameter = New SqlParameter("@San_Bay_Den_2", SqlDbType.VarChar, 3)
                pSan_Bay_Den_2.Value = San_Bay_Den_2
                MyCommand.Parameters.Add(pSan_Bay_Den_2)

                Dim pGio_Den_2 As SqlParameter = New SqlParameter("@Gio_Den_2", SqlDbType.Int, 0)
                pGio_Den_2.Value = Gio_Den_2
                MyCommand.Parameters.Add(pGio_Den_2)

                Dim pQua_Ngay_2 As SqlParameter = New SqlParameter("@Qua_Ngay_2", SqlDbType.Bit, 0)
                pQua_Ngay_2.Value = Qua_Ngay_2
                MyCommand.Parameters.Add(pQua_Ngay_2)

                Dim pGhi_Chu_2 As SqlParameter = New SqlParameter("@Ghi_Chu_2", SqlDbType.VarChar, 50)
                pGhi_Chu_2.Value = Ghi_Chu_2
                MyCommand.Parameters.Add(pGhi_Chu_2)

                Dim pSo_Hieu_3 As SqlParameter = New SqlParameter("@So_Hieu_3", SqlDbType.VarChar, 10)
                pSo_Hieu_3.Value = So_Hieu_3
                MyCommand.Parameters.Add(pSo_Hieu_3)

                Dim pNuoc_Xuat_Phat_3 As SqlParameter = New SqlParameter("@Nuoc_Xuat_Phat_3", SqlDbType.VarChar, 2)
                pNuoc_Xuat_Phat_3.Value = Nuoc_Xuat_Phat_3
                MyCommand.Parameters.Add(pNuoc_Xuat_Phat_3)

                Dim pSan_Bay_Xuat_Phat_3 As SqlParameter = New SqlParameter("@San_Bay_Xuat_Phat_3", SqlDbType.VarChar, 3)
                pSan_Bay_Xuat_Phat_3.Value = San_Bay_Xuat_Phat_3
                MyCommand.Parameters.Add(pSan_Bay_Xuat_Phat_3)

                Dim pGio_Xuat_Phat_3 As SqlParameter = New SqlParameter("@Gio_Xuat_Phat_3", SqlDbType.Int, 0)
                pGio_Xuat_Phat_3.Value = Gio_Xuat_Phat_3
                MyCommand.Parameters.Add(pGio_Xuat_Phat_3)

                Dim pNuoc_Den_3 As SqlParameter = New SqlParameter("@Nuoc_Den_3", SqlDbType.VarChar, 2)
                pNuoc_Den_3.Value = Nuoc_Den_3
                MyCommand.Parameters.Add(pNuoc_Den_3)

                Dim pSan_Bay_Den_3 As SqlParameter = New SqlParameter("@San_Bay_Den_3", SqlDbType.VarChar, 3)
                pSan_Bay_Den_3.Value = San_Bay_Den_3
                MyCommand.Parameters.Add(pSan_Bay_Den_3)

                Dim pGio_Den_3 As SqlParameter = New SqlParameter("@Gio_Den_3", SqlDbType.Int, 0)
                pGio_Den_3.Value = Gio_Den_3
                MyCommand.Parameters.Add(pGio_Den_3)

                Dim pQua_Ngay_3 As SqlParameter = New SqlParameter("@Qua_Ngay_3", SqlDbType.Bit, 0)
                pQua_Ngay_3.Value = Qua_Ngay_3
                MyCommand.Parameters.Add(pQua_Ngay_3)

                Dim pGhi_Chu_3 As SqlParameter = New SqlParameter("@Ghi_Chu_3", SqlDbType.VarChar, 50)
                pGhi_Chu_3.Value = Ghi_Chu_3
                MyCommand.Parameters.Add(pGhi_Chu_3)

                Dim pSo_Hieu_4 As SqlParameter = New SqlParameter("@So_Hieu_4", SqlDbType.VarChar, 10)
                pSo_Hieu_4.Value = So_Hieu_4
                MyCommand.Parameters.Add(pSo_Hieu_4)

                Dim pNuoc_Xuat_Phat_4 As SqlParameter = New SqlParameter("@Nuoc_Xuat_Phat_4", SqlDbType.VarChar, 2)
                pNuoc_Xuat_Phat_4.Value = Nuoc_Xuat_Phat_4
                MyCommand.Parameters.Add(pNuoc_Xuat_Phat_4)

                Dim pSan_Bay_Xuat_Phat_4 As SqlParameter = New SqlParameter("@San_Bay_Xuat_Phat_4", SqlDbType.VarChar, 3)
                pSan_Bay_Xuat_Phat_4.Value = San_Bay_Xuat_Phat_4
                MyCommand.Parameters.Add(pSan_Bay_Xuat_Phat_4)

                Dim pGio_Xuat_Phat_4 As SqlParameter = New SqlParameter("@Gio_Xuat_Phat_4", SqlDbType.Int, 0)
                pGio_Xuat_Phat_4.Value = Gio_Xuat_Phat_4
                MyCommand.Parameters.Add(pGio_Xuat_Phat_4)

                Dim pNuoc_Den_4 As SqlParameter = New SqlParameter("@Nuoc_Den_4", SqlDbType.VarChar, 2)
                pNuoc_Den_4.Value = Nuoc_Den_4
                MyCommand.Parameters.Add(pNuoc_Den_4)

                Dim pSan_Bay_Den_4 As SqlParameter = New SqlParameter("@San_Bay_Den_4", SqlDbType.VarChar, 3)
                pSan_Bay_Den_4.Value = San_Bay_Den_4
                MyCommand.Parameters.Add(pSan_Bay_Den_4)

                Dim pGio_Den_4 As SqlParameter = New SqlParameter("@Gio_Den_4", SqlDbType.Int, 0)
                pGio_Den_4.Value = Gio_Den_4
                MyCommand.Parameters.Add(pGio_Den_4)

                Dim pQua_Ngay_4 As SqlParameter = New SqlParameter("@Qua_Ngay_4", SqlDbType.Bit, 0)
                pQua_Ngay_4.Value = Qua_Ngay_4
                MyCommand.Parameters.Add(pQua_Ngay_4)

                Dim pGhi_Chu_4 As SqlParameter = New SqlParameter("@Ghi_Chu_4", SqlDbType.VarChar, 50)
                pGhi_Chu_4.Value = Ghi_Chu_4
                MyCommand.Parameters.Add(pGhi_Chu_4)

                Dim pSo_Hieu_5 As SqlParameter = New SqlParameter("@So_Hieu_5", SqlDbType.VarChar, 10)
                pSo_Hieu_5.Value = So_Hieu_5
                MyCommand.Parameters.Add(pSo_Hieu_5)

                Dim pNuoc_Xuat_Phat_5 As SqlParameter = New SqlParameter("@Nuoc_Xuat_Phat_5", SqlDbType.VarChar, 2)
                pNuoc_Xuat_Phat_5.Value = Nuoc_Xuat_Phat_5
                MyCommand.Parameters.Add(pNuoc_Xuat_Phat_5)

                Dim pSan_Bay_Xuat_Phat_5 As SqlParameter = New SqlParameter("@San_Bay_Xuat_Phat_5", SqlDbType.VarChar, 3)
                pSan_Bay_Xuat_Phat_5.Value = San_Bay_Xuat_Phat_5
                MyCommand.Parameters.Add(pSan_Bay_Xuat_Phat_5)

                Dim pGio_Xuat_Phat_5 As SqlParameter = New SqlParameter("@Gio_Xuat_Phat_5", SqlDbType.Int, 0)
                pGio_Xuat_Phat_5.Value = Gio_Xuat_Phat_5
                MyCommand.Parameters.Add(pGio_Xuat_Phat_5)

                Dim pNuoc_Den_5 As SqlParameter = New SqlParameter("@Nuoc_Den_5", SqlDbType.VarChar, 2)
                pNuoc_Den_5.Value = Nuoc_Den_5
                MyCommand.Parameters.Add(pNuoc_Den_5)

                Dim pSan_Bay_Den_5 As SqlParameter = New SqlParameter("@San_Bay_Den_5", SqlDbType.VarChar, 3)
                pSan_Bay_Den_5.Value = San_Bay_Den_5
                MyCommand.Parameters.Add(pSan_Bay_Den_5)

                Dim pGio_Den_5 As SqlParameter = New SqlParameter("@Gio_Den_5", SqlDbType.Int, 0)
                pGio_Den_5.Value = Gio_Den_5
                MyCommand.Parameters.Add(pGio_Den_5)

                Dim pQua_Ngay_5 As SqlParameter = New SqlParameter("@Qua_Ngay_5", SqlDbType.Bit, 0)
                pQua_Ngay_5.Value = Qua_Ngay_5
                MyCommand.Parameters.Add(pQua_Ngay_5)

                Dim pGhi_Chu_5 As SqlParameter = New SqlParameter("@Ghi_Chu_5", SqlDbType.VarChar, 50)
                pGhi_Chu_5.Value = Ghi_Chu_5
                MyCommand.Parameters.Add(pGhi_Chu_5)


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


#Region "Danh_Muc_Duong_Bay_So_Hieu_Danh_Sach"

        Public Function Danh_Muc_Duong_Bay_So_Hieu_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Id_Duong_Bay
            ' Id_Duong_Thu
            ' Loai_Van_Chuyen
            ' So_Hieu
            ' San_Bay_Xuat_Phat
            ' San_Bay_Do_Hang
            ' IPMC_Gui
            ' IPMC_Nhan
            ' Gio_Khoi_Hanh
            ' Gio_Den
            ' Qua_Ngay
            ' Tong_So_Ngay
            ' Qua_Giang
            ' So_Chang
            ' Su_Dung
            ' Ma_Bc_Qua_Giang
            ' Quy_Luat
            ' Thu_2
            ' Thu_3
            ' Thu_4
            ' Thu_5
            ' Thu_6
            ' Thu_7
            ' Chu_Nhat
            ' Dot_Giao_Hang
            ' So_Hieu_1
            ' Nuoc_Xuat_Phat_1
            ' San_Bay_Xuat_Phat_1
            ' Gio_Xuat_Phat_1
            ' Nuoc_Den_1
            ' San_Bay_Den_1
            ' Gio_Den_1
            ' Qua_Ngay_1
            ' Ghi_Chu_1
            ' So_Hieu_2
            ' Nuoc_Xuat_Phat_2
            ' San_Bay_Xuat_Phat_2
            ' Gio_Xuat_Phat_2
            ' Nuoc_Den_2
            ' San_Bay_Den_2
            ' Gio_Den_2
            ' Qua_Ngay_2
            ' Ghi_Chu_2
            ' So_Hieu_3
            ' Nuoc_Xuat_Phat_3
            ' San_Bay_Xuat_Phat_3
            ' Gio_Xuat_Phat_3
            ' Nuoc_Den_3
            ' San_Bay_Den_3
            ' Gio_Den_3
            ' Qua_Ngay_3
            ' Ghi_Chu_3
            ' So_Hieu_4
            ' Nuoc_Xuat_Phat_4
            ' San_Bay_Xuat_Phat_4
            ' Gio_Xuat_Phat_4
            ' Nuoc_Den_4
            ' San_Bay_Den_4
            ' Gio_Den_4
            ' Qua_Ngay_4
            ' Ghi_Chu_4
            ' So_Hieu_5
            ' Nuoc_Xuat_Phat_5
            ' San_Bay_Xuat_Phat_5
            ' Gio_Xuat_Phat_5
            ' Nuoc_Den_5
            ' San_Bay_Den_5
            ' Gio_Den_5
            ' Qua_Ngay_5
            ' Ghi_Chu_5


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Duong_Bay_So_Hieu_Danh_Sach"
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

#Region "Danh_Muc_Duong_Bay_So_Hieu_Lay"
        Public Function Danh_Muc_Duong_Bay_So_Hieu_Lay(ByVal Id_Duong_Bay As String) As Danh_Muc_Duong_Bay_So_Hieu_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Duong_Bay_So_Hieu_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet As New Danh_Muc_Duong_Bay_So_Hieu_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Duong_Bay As SqlParameter = New SqlParameter("@Id_Duong_Bay", SqlDbType.VarChar, 50)
                pId_Duong_Bay.Value = Id_Duong_Bay
                MyCommand.Parameters.Add(pId_Duong_Bay)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pLoai_Van_Chuyen As SqlParameter = New SqlParameter("@Loai_Van_Chuyen", SqlDbType.Int, 0)
                pLoai_Van_Chuyen.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pLoai_Van_Chuyen)

                Dim pSo_Hieu As SqlParameter = New SqlParameter("@So_Hieu", SqlDbType.VarChar, 30)
                pSo_Hieu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSo_Hieu)

                Dim pSan_Bay_Xuat_Phat As SqlParameter = New SqlParameter("@San_Bay_Xuat_Phat", SqlDbType.VarChar, 10)
                pSan_Bay_Xuat_Phat.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSan_Bay_Xuat_Phat)

                Dim pSan_Bay_Do_Hang As SqlParameter = New SqlParameter("@San_Bay_Do_Hang", SqlDbType.VarChar, 10)
                pSan_Bay_Do_Hang.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSan_Bay_Do_Hang)

                Dim pIPMC_Gui As SqlParameter = New SqlParameter("@IPMC_Gui", SqlDbType.VarChar, 6)
                pIPMC_Gui.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pIPMC_Gui)

                Dim pIPMC_Nhan As SqlParameter = New SqlParameter("@IPMC_Nhan", SqlDbType.VarChar, 6)
                pIPMC_Nhan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pIPMC_Nhan)

                Dim pGio_Khoi_Hanh As SqlParameter = New SqlParameter("@Gio_Khoi_Hanh", SqlDbType.Int, 0)
                pGio_Khoi_Hanh.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Khoi_Hanh)

                Dim pGio_Den As SqlParameter = New SqlParameter("@Gio_Den", SqlDbType.Int, 0)
                pGio_Den.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Den)

                Dim pQua_Ngay As SqlParameter = New SqlParameter("@Qua_Ngay", SqlDbType.Bit, 0)
                pQua_Ngay.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pQua_Ngay)

                Dim pTong_So_Ngay As SqlParameter = New SqlParameter("@Tong_So_Ngay", SqlDbType.Int, 0)
                pTong_So_Ngay.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTong_So_Ngay)

                Dim pQua_Giang As SqlParameter = New SqlParameter("@Qua_Giang", SqlDbType.Bit, 0)
                pQua_Giang.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pQua_Giang)

                Dim pSo_Chang As SqlParameter = New SqlParameter("@So_Chang", SqlDbType.Int, 0)
                pSo_Chang.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSo_Chang)

                Dim pSu_Dung As SqlParameter = New SqlParameter("@Su_Dung", SqlDbType.Int, 0)
                pSu_Dung.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSu_Dung)

                Dim pMa_Bc_Qua_Giang As SqlParameter = New SqlParameter("@Ma_Bc_Qua_Giang", SqlDbType.Int, 0)
                pMa_Bc_Qua_Giang.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc_Qua_Giang)

                Dim pQuy_Luat As SqlParameter = New SqlParameter("@Quy_Luat", SqlDbType.Int, 0)
                pQuy_Luat.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pQuy_Luat)

                Dim pThu_2 As SqlParameter = New SqlParameter("@Thu_2", SqlDbType.Bit, 0)
                pThu_2.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThu_2)

                Dim pThu_3 As SqlParameter = New SqlParameter("@Thu_3", SqlDbType.Bit, 0)
                pThu_3.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThu_3)

                Dim pThu_4 As SqlParameter = New SqlParameter("@Thu_4", SqlDbType.Bit, 0)
                pThu_4.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThu_4)

                Dim pThu_5 As SqlParameter = New SqlParameter("@Thu_5", SqlDbType.Bit, 0)
                pThu_5.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThu_5)

                Dim pThu_6 As SqlParameter = New SqlParameter("@Thu_6", SqlDbType.Bit, 0)
                pThu_6.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThu_6)

                Dim pThu_7 As SqlParameter = New SqlParameter("@Thu_7", SqlDbType.Bit, 0)
                pThu_7.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThu_7)

                Dim pChu_Nhat As SqlParameter = New SqlParameter("@Chu_Nhat", SqlDbType.Bit, 0)
                pChu_Nhat.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pChu_Nhat)

                Dim pDot_Giao_Hang As SqlParameter = New SqlParameter("@Dot_Giao_Hang", SqlDbType.Int, 0)
                pDot_Giao_Hang.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDot_Giao_Hang)

                Dim pSo_Hieu_1 As SqlParameter = New SqlParameter("@So_Hieu_1", SqlDbType.VarChar, 10)
                pSo_Hieu_1.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSo_Hieu_1)

                Dim pNuoc_Xuat_Phat_1 As SqlParameter = New SqlParameter("@Nuoc_Xuat_Phat_1", SqlDbType.VarChar, 2)
                pNuoc_Xuat_Phat_1.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNuoc_Xuat_Phat_1)

                Dim pSan_Bay_Xuat_Phat_1 As SqlParameter = New SqlParameter("@San_Bay_Xuat_Phat_1", SqlDbType.VarChar, 3)
                pSan_Bay_Xuat_Phat_1.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSan_Bay_Xuat_Phat_1)

                Dim pGio_Xuat_Phat_1 As SqlParameter = New SqlParameter("@Gio_Xuat_Phat_1", SqlDbType.Int, 0)
                pGio_Xuat_Phat_1.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Xuat_Phat_1)

                Dim pNuoc_Den_1 As SqlParameter = New SqlParameter("@Nuoc_Den_1", SqlDbType.VarChar, 2)
                pNuoc_Den_1.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNuoc_Den_1)

                Dim pSan_Bay_Den_1 As SqlParameter = New SqlParameter("@San_Bay_Den_1", SqlDbType.VarChar, 3)
                pSan_Bay_Den_1.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSan_Bay_Den_1)

                Dim pGio_Den_1 As SqlParameter = New SqlParameter("@Gio_Den_1", SqlDbType.Int, 0)
                pGio_Den_1.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Den_1)

                Dim pQua_Ngay_1 As SqlParameter = New SqlParameter("@Qua_Ngay_1", SqlDbType.Bit, 0)
                pQua_Ngay_1.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pQua_Ngay_1)

                Dim pGhi_Chu_1 As SqlParameter = New SqlParameter("@Ghi_Chu_1", SqlDbType.VarChar, 50)
                pGhi_Chu_1.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGhi_Chu_1)

                Dim pSo_Hieu_2 As SqlParameter = New SqlParameter("@So_Hieu_2", SqlDbType.VarChar, 10)
                pSo_Hieu_2.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSo_Hieu_2)

                Dim pNuoc_Xuat_Phat_2 As SqlParameter = New SqlParameter("@Nuoc_Xuat_Phat_2", SqlDbType.VarChar, 2)
                pNuoc_Xuat_Phat_2.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNuoc_Xuat_Phat_2)

                Dim pSan_Bay_Xuat_Phat_2 As SqlParameter = New SqlParameter("@San_Bay_Xuat_Phat_2", SqlDbType.VarChar, 3)
                pSan_Bay_Xuat_Phat_2.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSan_Bay_Xuat_Phat_2)

                Dim pGio_Xuat_Phat_2 As SqlParameter = New SqlParameter("@Gio_Xuat_Phat_2", SqlDbType.Int, 0)
                pGio_Xuat_Phat_2.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Xuat_Phat_2)

                Dim pNuoc_Den_2 As SqlParameter = New SqlParameter("@Nuoc_Den_2", SqlDbType.VarChar, 2)
                pNuoc_Den_2.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNuoc_Den_2)

                Dim pSan_Bay_Den_2 As SqlParameter = New SqlParameter("@San_Bay_Den_2", SqlDbType.VarChar, 3)
                pSan_Bay_Den_2.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSan_Bay_Den_2)

                Dim pGio_Den_2 As SqlParameter = New SqlParameter("@Gio_Den_2", SqlDbType.Int, 0)
                pGio_Den_2.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Den_2)

                Dim pQua_Ngay_2 As SqlParameter = New SqlParameter("@Qua_Ngay_2", SqlDbType.Bit, 0)
                pQua_Ngay_2.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pQua_Ngay_2)

                Dim pGhi_Chu_2 As SqlParameter = New SqlParameter("@Ghi_Chu_2", SqlDbType.VarChar, 50)
                pGhi_Chu_2.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGhi_Chu_2)

                Dim pSo_Hieu_3 As SqlParameter = New SqlParameter("@So_Hieu_3", SqlDbType.VarChar, 10)
                pSo_Hieu_3.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSo_Hieu_3)

                Dim pNuoc_Xuat_Phat_3 As SqlParameter = New SqlParameter("@Nuoc_Xuat_Phat_3", SqlDbType.VarChar, 2)
                pNuoc_Xuat_Phat_3.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNuoc_Xuat_Phat_3)

                Dim pSan_Bay_Xuat_Phat_3 As SqlParameter = New SqlParameter("@San_Bay_Xuat_Phat_3", SqlDbType.VarChar, 3)
                pSan_Bay_Xuat_Phat_3.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSan_Bay_Xuat_Phat_3)

                Dim pGio_Xuat_Phat_3 As SqlParameter = New SqlParameter("@Gio_Xuat_Phat_3", SqlDbType.Int, 0)
                pGio_Xuat_Phat_3.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Xuat_Phat_3)

                Dim pNuoc_Den_3 As SqlParameter = New SqlParameter("@Nuoc_Den_3", SqlDbType.VarChar, 2)
                pNuoc_Den_3.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNuoc_Den_3)

                Dim pSan_Bay_Den_3 As SqlParameter = New SqlParameter("@San_Bay_Den_3", SqlDbType.VarChar, 3)
                pSan_Bay_Den_3.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSan_Bay_Den_3)

                Dim pGio_Den_3 As SqlParameter = New SqlParameter("@Gio_Den_3", SqlDbType.Int, 0)
                pGio_Den_3.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Den_3)

                Dim pQua_Ngay_3 As SqlParameter = New SqlParameter("@Qua_Ngay_3", SqlDbType.Bit, 0)
                pQua_Ngay_3.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pQua_Ngay_3)

                Dim pGhi_Chu_3 As SqlParameter = New SqlParameter("@Ghi_Chu_3", SqlDbType.VarChar, 50)
                pGhi_Chu_3.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGhi_Chu_3)

                Dim pSo_Hieu_4 As SqlParameter = New SqlParameter("@So_Hieu_4", SqlDbType.VarChar, 10)
                pSo_Hieu_4.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSo_Hieu_4)

                Dim pNuoc_Xuat_Phat_4 As SqlParameter = New SqlParameter("@Nuoc_Xuat_Phat_4", SqlDbType.VarChar, 2)
                pNuoc_Xuat_Phat_4.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNuoc_Xuat_Phat_4)

                Dim pSan_Bay_Xuat_Phat_4 As SqlParameter = New SqlParameter("@San_Bay_Xuat_Phat_4", SqlDbType.VarChar, 3)
                pSan_Bay_Xuat_Phat_4.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSan_Bay_Xuat_Phat_4)

                Dim pGio_Xuat_Phat_4 As SqlParameter = New SqlParameter("@Gio_Xuat_Phat_4", SqlDbType.Int, 0)
                pGio_Xuat_Phat_4.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Xuat_Phat_4)

                Dim pNuoc_Den_4 As SqlParameter = New SqlParameter("@Nuoc_Den_4", SqlDbType.VarChar, 2)
                pNuoc_Den_4.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNuoc_Den_4)

                Dim pSan_Bay_Den_4 As SqlParameter = New SqlParameter("@San_Bay_Den_4", SqlDbType.VarChar, 3)
                pSan_Bay_Den_4.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSan_Bay_Den_4)

                Dim pGio_Den_4 As SqlParameter = New SqlParameter("@Gio_Den_4", SqlDbType.Int, 0)
                pGio_Den_4.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Den_4)

                Dim pQua_Ngay_4 As SqlParameter = New SqlParameter("@Qua_Ngay_4", SqlDbType.Bit, 0)
                pQua_Ngay_4.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pQua_Ngay_4)

                Dim pGhi_Chu_4 As SqlParameter = New SqlParameter("@Ghi_Chu_4", SqlDbType.VarChar, 50)
                pGhi_Chu_4.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGhi_Chu_4)

                Dim pSo_Hieu_5 As SqlParameter = New SqlParameter("@So_Hieu_5", SqlDbType.VarChar, 10)
                pSo_Hieu_5.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSo_Hieu_5)

                Dim pNuoc_Xuat_Phat_5 As SqlParameter = New SqlParameter("@Nuoc_Xuat_Phat_5", SqlDbType.VarChar, 2)
                pNuoc_Xuat_Phat_5.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNuoc_Xuat_Phat_5)

                Dim pSan_Bay_Xuat_Phat_5 As SqlParameter = New SqlParameter("@San_Bay_Xuat_Phat_5", SqlDbType.VarChar, 3)
                pSan_Bay_Xuat_Phat_5.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSan_Bay_Xuat_Phat_5)

                Dim pGio_Xuat_Phat_5 As SqlParameter = New SqlParameter("@Gio_Xuat_Phat_5", SqlDbType.Int, 0)
                pGio_Xuat_Phat_5.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Xuat_Phat_5)

                Dim pNuoc_Den_5 As SqlParameter = New SqlParameter("@Nuoc_Den_5", SqlDbType.VarChar, 2)
                pNuoc_Den_5.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNuoc_Den_5)

                Dim pSan_Bay_Den_5 As SqlParameter = New SqlParameter("@San_Bay_Den_5", SqlDbType.VarChar, 3)
                pSan_Bay_Den_5.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSan_Bay_Den_5)

                Dim pGio_Den_5 As SqlParameter = New SqlParameter("@Gio_Den_5", SqlDbType.Int, 0)
                pGio_Den_5.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Den_5)

                Dim pQua_Ngay_5 As SqlParameter = New SqlParameter("@Qua_Ngay_5", SqlDbType.Bit, 0)
                pQua_Ngay_5.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pQua_Ngay_5)

                Dim pGhi_Chu_5 As SqlParameter = New SqlParameter("@Ghi_Chu_5", SqlDbType.VarChar, 50)
                pGhi_Chu_5.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGhi_Chu_5)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Id_Duong_Bay = Id_Duong_Bay
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Id_Duong_Thu = pId_Duong_Thu.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Loai_Van_Chuyen = pLoai_Van_Chuyen.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.So_Hieu = pSo_Hieu.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.San_Bay_Xuat_Phat = pSan_Bay_Xuat_Phat.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.San_Bay_Do_Hang = pSan_Bay_Do_Hang.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.IPMC_Gui = pIPMC_Gui.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.IPMC_Nhan = pIPMC_Nhan.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Gio_Khoi_Hanh = pGio_Khoi_Hanh.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Gio_Den = pGio_Den.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Qua_Ngay = pQua_Ngay.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Tong_So_Ngay = pTong_So_Ngay.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Qua_Giang = pQua_Giang.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.So_Chang = pSo_Chang.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Su_Dung = pSu_Dung.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Ma_Bc_Qua_Giang = pMa_Bc_Qua_Giang.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Quy_Luat = pQuy_Luat.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Thu_2 = pThu_2.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Thu_3 = pThu_3.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Thu_4 = pThu_4.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Thu_5 = pThu_5.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Thu_6 = pThu_6.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Thu_7 = pThu_7.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Chu_Nhat = pChu_Nhat.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Dot_Giao_Hang = pDot_Giao_Hang.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.So_Hieu_1 = pSo_Hieu_1.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Nuoc_Xuat_Phat_1 = pNuoc_Xuat_Phat_1.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.San_Bay_Xuat_Phat_1 = pSan_Bay_Xuat_Phat_1.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Gio_Xuat_Phat_1 = pGio_Xuat_Phat_1.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Nuoc_Den_1 = pNuoc_Den_1.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.San_Bay_Den_1 = pSan_Bay_Den_1.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Gio_Den_1 = pGio_Den_1.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Qua_Ngay_1 = pQua_Ngay_1.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Ghi_Chu_1 = pGhi_Chu_1.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.So_Hieu_2 = pSo_Hieu_2.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Nuoc_Xuat_Phat_2 = pNuoc_Xuat_Phat_2.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.San_Bay_Xuat_Phat_2 = pSan_Bay_Xuat_Phat_2.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Gio_Xuat_Phat_2 = pGio_Xuat_Phat_2.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Nuoc_Den_2 = pNuoc_Den_2.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.San_Bay_Den_2 = pSan_Bay_Den_2.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Gio_Den_2 = pGio_Den_2.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Qua_Ngay_2 = pQua_Ngay_2.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Ghi_Chu_2 = pGhi_Chu_2.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.So_Hieu_3 = pSo_Hieu_3.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Nuoc_Xuat_Phat_3 = pNuoc_Xuat_Phat_3.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.San_Bay_Xuat_Phat_3 = pSan_Bay_Xuat_Phat_3.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Gio_Xuat_Phat_3 = pGio_Xuat_Phat_3.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Nuoc_Den_3 = pNuoc_Den_3.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.San_Bay_Den_3 = pSan_Bay_Den_3.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Gio_Den_3 = pGio_Den_3.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Qua_Ngay_3 = pQua_Ngay_3.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Ghi_Chu_3 = pGhi_Chu_3.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.So_Hieu_4 = pSo_Hieu_4.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Nuoc_Xuat_Phat_4 = pNuoc_Xuat_Phat_4.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.San_Bay_Xuat_Phat_4 = pSan_Bay_Xuat_Phat_4.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Gio_Xuat_Phat_4 = pGio_Xuat_Phat_4.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Nuoc_Den_4 = pNuoc_Den_4.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.San_Bay_Den_4 = pSan_Bay_Den_4.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Gio_Den_4 = pGio_Den_4.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Qua_Ngay_4 = pQua_Ngay_4.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Ghi_Chu_4 = pGhi_Chu_4.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.So_Hieu_5 = pSo_Hieu_5.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Nuoc_Xuat_Phat_5 = pNuoc_Xuat_Phat_5.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.San_Bay_Xuat_Phat_5 = pSan_Bay_Xuat_Phat_5.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Gio_Xuat_Phat_5 = pGio_Xuat_Phat_5.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Nuoc_Den_5 = pNuoc_Den_5.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.San_Bay_Den_5 = pSan_Bay_Den_5.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Gio_Den_5 = pGio_Den_5.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Qua_Ngay_5 = pQua_Ngay_5.Value
                myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet.Ghi_Chu_5 = pGhi_Chu_5.Value

                Return myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet
                'Return myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet

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

#Region "Danh_Muc_Duong_Bay_So_Hieu_Them"
        Public Function Danh_Muc_Duong_Bay_So_Hieu_Them(ByVal Id_Duong_Bay As String, ByVal Id_Duong_Thu As String, ByVal Loai_Van_Chuyen As Integer, ByVal So_Hieu As String, ByVal San_Bay_Xuat_Phat As String, ByVal San_Bay_Do_Hang As String, ByVal IPMC_Gui As String, ByVal IPMC_Nhan As String, ByVal Gio_Khoi_Hanh As Integer, ByVal Gio_Den As Integer, ByVal Qua_Ngay As Boolean, ByVal Tong_So_Ngay As Integer, ByVal Qua_Giang As Boolean, ByVal So_Chang As Integer, ByVal Su_Dung As Integer, ByVal Ma_Bc_Qua_Giang As Integer, ByVal Quy_Luat As Integer, ByVal Thu_2 As Boolean, ByVal Thu_3 As Boolean, ByVal Thu_4 As Boolean, ByVal Thu_5 As Boolean, ByVal Thu_6 As Boolean, ByVal Thu_7 As Boolean, ByVal Chu_Nhat As Boolean, ByVal Dot_Giao_Hang As Integer, ByVal So_Hieu_1 As String, ByVal Nuoc_Xuat_Phat_1 As String, ByVal San_Bay_Xuat_Phat_1 As String, ByVal Gio_Xuat_Phat_1 As Integer, ByVal Nuoc_Den_1 As String, ByVal San_Bay_Den_1 As String, ByVal Gio_Den_1 As Integer, ByVal Qua_Ngay_1 As Boolean, ByVal Ghi_Chu_1 As String, ByVal So_Hieu_2 As String, ByVal Nuoc_Xuat_Phat_2 As String, ByVal San_Bay_Xuat_Phat_2 As String, ByVal Gio_Xuat_Phat_2 As Integer, ByVal Nuoc_Den_2 As String, ByVal San_Bay_Den_2 As String, ByVal Gio_Den_2 As Integer, ByVal Qua_Ngay_2 As Boolean, ByVal Ghi_Chu_2 As String, ByVal So_Hieu_3 As String, ByVal Nuoc_Xuat_Phat_3 As String, ByVal San_Bay_Xuat_Phat_3 As String, ByVal Gio_Xuat_Phat_3 As Integer, ByVal Nuoc_Den_3 As String, ByVal San_Bay_Den_3 As String, ByVal Gio_Den_3 As Integer, ByVal Qua_Ngay_3 As Boolean, ByVal Ghi_Chu_3 As String, ByVal So_Hieu_4 As String, ByVal Nuoc_Xuat_Phat_4 As String, ByVal San_Bay_Xuat_Phat_4 As String, ByVal Gio_Xuat_Phat_4 As Integer, ByVal Nuoc_Den_4 As String, ByVal San_Bay_Den_4 As String, ByVal Gio_Den_4 As Integer, ByVal Qua_Ngay_4 As Boolean, ByVal Ghi_Chu_4 As String, ByVal So_Hieu_5 As String, ByVal Nuoc_Xuat_Phat_5 As String, ByVal San_Bay_Xuat_Phat_5 As String, ByVal Gio_Xuat_Phat_5 As Integer, ByVal Nuoc_Den_5 As String, ByVal San_Bay_Den_5 As String, ByVal Gio_Den_5 As Integer, ByVal Qua_Ngay_5 As Boolean, ByVal Ghi_Chu_5 As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Duong_Bay_So_Hieu_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet As New Danh_Muc_Duong_Bay_So_Hieu_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Duong_Bay As SqlParameter = New SqlParameter("@Id_Duong_Bay", SqlDbType.VarChar, 50)
                pId_Duong_Bay.Value = Id_Duong_Bay
                MyCommand.Parameters.Add(pId_Duong_Bay)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pLoai_Van_Chuyen As SqlParameter = New SqlParameter("@Loai_Van_Chuyen", SqlDbType.Int, 0)
                pLoai_Van_Chuyen.Value = Loai_Van_Chuyen
                MyCommand.Parameters.Add(pLoai_Van_Chuyen)

                Dim pSo_Hieu As SqlParameter = New SqlParameter("@So_Hieu", SqlDbType.VarChar, 30)
                pSo_Hieu.Value = So_Hieu
                MyCommand.Parameters.Add(pSo_Hieu)

                Dim pSan_Bay_Xuat_Phat As SqlParameter = New SqlParameter("@San_Bay_Xuat_Phat", SqlDbType.VarChar, 10)
                pSan_Bay_Xuat_Phat.Value = San_Bay_Xuat_Phat
                MyCommand.Parameters.Add(pSan_Bay_Xuat_Phat)

                Dim pSan_Bay_Do_Hang As SqlParameter = New SqlParameter("@San_Bay_Do_Hang", SqlDbType.VarChar, 10)
                pSan_Bay_Do_Hang.Value = San_Bay_Do_Hang
                MyCommand.Parameters.Add(pSan_Bay_Do_Hang)

                Dim pIPMC_Gui As SqlParameter = New SqlParameter("@IPMC_Gui", SqlDbType.VarChar, 6)
                pIPMC_Gui.Value = IPMC_Gui
                MyCommand.Parameters.Add(pIPMC_Gui)

                Dim pIPMC_Nhan As SqlParameter = New SqlParameter("@IPMC_Nhan", SqlDbType.VarChar, 6)
                pIPMC_Nhan.Value = IPMC_Nhan
                MyCommand.Parameters.Add(pIPMC_Nhan)

                Dim pGio_Khoi_Hanh As SqlParameter = New SqlParameter("@Gio_Khoi_Hanh", SqlDbType.Int, 0)
                pGio_Khoi_Hanh.Value = Gio_Khoi_Hanh
                MyCommand.Parameters.Add(pGio_Khoi_Hanh)

                Dim pGio_Den As SqlParameter = New SqlParameter("@Gio_Den", SqlDbType.Int, 0)
                pGio_Den.Value = Gio_Den
                MyCommand.Parameters.Add(pGio_Den)

                Dim pQua_Ngay As SqlParameter = New SqlParameter("@Qua_Ngay", SqlDbType.Bit, 0)
                pQua_Ngay.Value = Qua_Ngay
                MyCommand.Parameters.Add(pQua_Ngay)

                Dim pTong_So_Ngay As SqlParameter = New SqlParameter("@Tong_So_Ngay", SqlDbType.Int, 0)
                pTong_So_Ngay.Value = Tong_So_Ngay
                MyCommand.Parameters.Add(pTong_So_Ngay)

                Dim pQua_Giang As SqlParameter = New SqlParameter("@Qua_Giang", SqlDbType.Bit, 0)
                pQua_Giang.Value = Qua_Giang
                MyCommand.Parameters.Add(pQua_Giang)

                Dim pSo_Chang As SqlParameter = New SqlParameter("@So_Chang", SqlDbType.Int, 0)
                pSo_Chang.Value = So_Chang
                MyCommand.Parameters.Add(pSo_Chang)

                Dim pSu_Dung As SqlParameter = New SqlParameter("@Su_Dung", SqlDbType.Int, 0)
                pSu_Dung.Value = Su_Dung
                MyCommand.Parameters.Add(pSu_Dung)

                Dim pMa_Bc_Qua_Giang As SqlParameter = New SqlParameter("@Ma_Bc_Qua_Giang", SqlDbType.Int, 0)
                pMa_Bc_Qua_Giang.Value = Ma_Bc_Qua_Giang
                MyCommand.Parameters.Add(pMa_Bc_Qua_Giang)

                Dim pQuy_Luat As SqlParameter = New SqlParameter("@Quy_Luat", SqlDbType.Int, 0)
                pQuy_Luat.Value = Quy_Luat
                MyCommand.Parameters.Add(pQuy_Luat)

                Dim pThu_2 As SqlParameter = New SqlParameter("@Thu_2", SqlDbType.Bit, 0)
                pThu_2.Value = Thu_2
                MyCommand.Parameters.Add(pThu_2)

                Dim pThu_3 As SqlParameter = New SqlParameter("@Thu_3", SqlDbType.Bit, 0)
                pThu_3.Value = Thu_3
                MyCommand.Parameters.Add(pThu_3)

                Dim pThu_4 As SqlParameter = New SqlParameter("@Thu_4", SqlDbType.Bit, 0)
                pThu_4.Value = Thu_4
                MyCommand.Parameters.Add(pThu_4)

                Dim pThu_5 As SqlParameter = New SqlParameter("@Thu_5", SqlDbType.Bit, 0)
                pThu_5.Value = Thu_5
                MyCommand.Parameters.Add(pThu_5)

                Dim pThu_6 As SqlParameter = New SqlParameter("@Thu_6", SqlDbType.Bit, 0)
                pThu_6.Value = Thu_6
                MyCommand.Parameters.Add(pThu_6)

                Dim pThu_7 As SqlParameter = New SqlParameter("@Thu_7", SqlDbType.Bit, 0)
                pThu_7.Value = Thu_7
                MyCommand.Parameters.Add(pThu_7)

                Dim pChu_Nhat As SqlParameter = New SqlParameter("@Chu_Nhat", SqlDbType.Bit, 0)
                pChu_Nhat.Value = Chu_Nhat
                MyCommand.Parameters.Add(pChu_Nhat)

                Dim pDot_Giao_Hang As SqlParameter = New SqlParameter("@Dot_Giao_Hang", SqlDbType.Int, 0)
                pDot_Giao_Hang.Value = Dot_Giao_Hang
                MyCommand.Parameters.Add(pDot_Giao_Hang)

                Dim pSo_Hieu_1 As SqlParameter = New SqlParameter("@So_Hieu_1", SqlDbType.VarChar, 10)
                pSo_Hieu_1.Value = So_Hieu_1
                MyCommand.Parameters.Add(pSo_Hieu_1)

                Dim pNuoc_Xuat_Phat_1 As SqlParameter = New SqlParameter("@Nuoc_Xuat_Phat_1", SqlDbType.VarChar, 2)
                pNuoc_Xuat_Phat_1.Value = Nuoc_Xuat_Phat_1
                MyCommand.Parameters.Add(pNuoc_Xuat_Phat_1)

                Dim pSan_Bay_Xuat_Phat_1 As SqlParameter = New SqlParameter("@San_Bay_Xuat_Phat_1", SqlDbType.VarChar, 3)
                pSan_Bay_Xuat_Phat_1.Value = San_Bay_Xuat_Phat_1
                MyCommand.Parameters.Add(pSan_Bay_Xuat_Phat_1)

                Dim pGio_Xuat_Phat_1 As SqlParameter = New SqlParameter("@Gio_Xuat_Phat_1", SqlDbType.Int, 0)
                pGio_Xuat_Phat_1.Value = Gio_Xuat_Phat_1
                MyCommand.Parameters.Add(pGio_Xuat_Phat_1)

                Dim pNuoc_Den_1 As SqlParameter = New SqlParameter("@Nuoc_Den_1", SqlDbType.VarChar, 2)
                pNuoc_Den_1.Value = Nuoc_Den_1
                MyCommand.Parameters.Add(pNuoc_Den_1)

                Dim pSan_Bay_Den_1 As SqlParameter = New SqlParameter("@San_Bay_Den_1", SqlDbType.VarChar, 3)
                pSan_Bay_Den_1.Value = San_Bay_Den_1
                MyCommand.Parameters.Add(pSan_Bay_Den_1)

                Dim pGio_Den_1 As SqlParameter = New SqlParameter("@Gio_Den_1", SqlDbType.Int, 0)
                pGio_Den_1.Value = Gio_Den_1
                MyCommand.Parameters.Add(pGio_Den_1)

                Dim pQua_Ngay_1 As SqlParameter = New SqlParameter("@Qua_Ngay_1", SqlDbType.Bit, 0)
                pQua_Ngay_1.Value = Qua_Ngay_1
                MyCommand.Parameters.Add(pQua_Ngay_1)

                Dim pGhi_Chu_1 As SqlParameter = New SqlParameter("@Ghi_Chu_1", SqlDbType.VarChar, 50)
                pGhi_Chu_1.Value = Ghi_Chu_1
                MyCommand.Parameters.Add(pGhi_Chu_1)

                Dim pSo_Hieu_2 As SqlParameter = New SqlParameter("@So_Hieu_2", SqlDbType.VarChar, 10)
                pSo_Hieu_2.Value = So_Hieu_2
                MyCommand.Parameters.Add(pSo_Hieu_2)

                Dim pNuoc_Xuat_Phat_2 As SqlParameter = New SqlParameter("@Nuoc_Xuat_Phat_2", SqlDbType.VarChar, 2)
                pNuoc_Xuat_Phat_2.Value = Nuoc_Xuat_Phat_2
                MyCommand.Parameters.Add(pNuoc_Xuat_Phat_2)

                Dim pSan_Bay_Xuat_Phat_2 As SqlParameter = New SqlParameter("@San_Bay_Xuat_Phat_2", SqlDbType.VarChar, 3)
                pSan_Bay_Xuat_Phat_2.Value = San_Bay_Xuat_Phat_2
                MyCommand.Parameters.Add(pSan_Bay_Xuat_Phat_2)

                Dim pGio_Xuat_Phat_2 As SqlParameter = New SqlParameter("@Gio_Xuat_Phat_2", SqlDbType.Int, 0)
                pGio_Xuat_Phat_2.Value = Gio_Xuat_Phat_2
                MyCommand.Parameters.Add(pGio_Xuat_Phat_2)

                Dim pNuoc_Den_2 As SqlParameter = New SqlParameter("@Nuoc_Den_2", SqlDbType.VarChar, 2)
                pNuoc_Den_2.Value = Nuoc_Den_2
                MyCommand.Parameters.Add(pNuoc_Den_2)

                Dim pSan_Bay_Den_2 As SqlParameter = New SqlParameter("@San_Bay_Den_2", SqlDbType.VarChar, 3)
                pSan_Bay_Den_2.Value = San_Bay_Den_2
                MyCommand.Parameters.Add(pSan_Bay_Den_2)

                Dim pGio_Den_2 As SqlParameter = New SqlParameter("@Gio_Den_2", SqlDbType.Int, 0)
                pGio_Den_2.Value = Gio_Den_2
                MyCommand.Parameters.Add(pGio_Den_2)

                Dim pQua_Ngay_2 As SqlParameter = New SqlParameter("@Qua_Ngay_2", SqlDbType.Bit, 0)
                pQua_Ngay_2.Value = Qua_Ngay_2
                MyCommand.Parameters.Add(pQua_Ngay_2)

                Dim pGhi_Chu_2 As SqlParameter = New SqlParameter("@Ghi_Chu_2", SqlDbType.VarChar, 50)
                pGhi_Chu_2.Value = Ghi_Chu_2
                MyCommand.Parameters.Add(pGhi_Chu_2)

                Dim pSo_Hieu_3 As SqlParameter = New SqlParameter("@So_Hieu_3", SqlDbType.VarChar, 10)
                pSo_Hieu_3.Value = So_Hieu_3
                MyCommand.Parameters.Add(pSo_Hieu_3)

                Dim pNuoc_Xuat_Phat_3 As SqlParameter = New SqlParameter("@Nuoc_Xuat_Phat_3", SqlDbType.VarChar, 2)
                pNuoc_Xuat_Phat_3.Value = Nuoc_Xuat_Phat_3
                MyCommand.Parameters.Add(pNuoc_Xuat_Phat_3)

                Dim pSan_Bay_Xuat_Phat_3 As SqlParameter = New SqlParameter("@San_Bay_Xuat_Phat_3", SqlDbType.VarChar, 3)
                pSan_Bay_Xuat_Phat_3.Value = San_Bay_Xuat_Phat_3
                MyCommand.Parameters.Add(pSan_Bay_Xuat_Phat_3)

                Dim pGio_Xuat_Phat_3 As SqlParameter = New SqlParameter("@Gio_Xuat_Phat_3", SqlDbType.Int, 0)
                pGio_Xuat_Phat_3.Value = Gio_Xuat_Phat_3
                MyCommand.Parameters.Add(pGio_Xuat_Phat_3)

                Dim pNuoc_Den_3 As SqlParameter = New SqlParameter("@Nuoc_Den_3", SqlDbType.VarChar, 2)
                pNuoc_Den_3.Value = Nuoc_Den_3
                MyCommand.Parameters.Add(pNuoc_Den_3)

                Dim pSan_Bay_Den_3 As SqlParameter = New SqlParameter("@San_Bay_Den_3", SqlDbType.VarChar, 3)
                pSan_Bay_Den_3.Value = San_Bay_Den_3
                MyCommand.Parameters.Add(pSan_Bay_Den_3)

                Dim pGio_Den_3 As SqlParameter = New SqlParameter("@Gio_Den_3", SqlDbType.Int, 0)
                pGio_Den_3.Value = Gio_Den_3
                MyCommand.Parameters.Add(pGio_Den_3)

                Dim pQua_Ngay_3 As SqlParameter = New SqlParameter("@Qua_Ngay_3", SqlDbType.Bit, 0)
                pQua_Ngay_3.Value = Qua_Ngay_3
                MyCommand.Parameters.Add(pQua_Ngay_3)

                Dim pGhi_Chu_3 As SqlParameter = New SqlParameter("@Ghi_Chu_3", SqlDbType.VarChar, 50)
                pGhi_Chu_3.Value = Ghi_Chu_3
                MyCommand.Parameters.Add(pGhi_Chu_3)

                Dim pSo_Hieu_4 As SqlParameter = New SqlParameter("@So_Hieu_4", SqlDbType.VarChar, 10)
                pSo_Hieu_4.Value = So_Hieu_4
                MyCommand.Parameters.Add(pSo_Hieu_4)

                Dim pNuoc_Xuat_Phat_4 As SqlParameter = New SqlParameter("@Nuoc_Xuat_Phat_4", SqlDbType.VarChar, 2)
                pNuoc_Xuat_Phat_4.Value = Nuoc_Xuat_Phat_4
                MyCommand.Parameters.Add(pNuoc_Xuat_Phat_4)

                Dim pSan_Bay_Xuat_Phat_4 As SqlParameter = New SqlParameter("@San_Bay_Xuat_Phat_4", SqlDbType.VarChar, 3)
                pSan_Bay_Xuat_Phat_4.Value = San_Bay_Xuat_Phat_4
                MyCommand.Parameters.Add(pSan_Bay_Xuat_Phat_4)

                Dim pGio_Xuat_Phat_4 As SqlParameter = New SqlParameter("@Gio_Xuat_Phat_4", SqlDbType.Int, 0)
                pGio_Xuat_Phat_4.Value = Gio_Xuat_Phat_4
                MyCommand.Parameters.Add(pGio_Xuat_Phat_4)

                Dim pNuoc_Den_4 As SqlParameter = New SqlParameter("@Nuoc_Den_4", SqlDbType.VarChar, 2)
                pNuoc_Den_4.Value = Nuoc_Den_4
                MyCommand.Parameters.Add(pNuoc_Den_4)

                Dim pSan_Bay_Den_4 As SqlParameter = New SqlParameter("@San_Bay_Den_4", SqlDbType.VarChar, 3)
                pSan_Bay_Den_4.Value = San_Bay_Den_4
                MyCommand.Parameters.Add(pSan_Bay_Den_4)

                Dim pGio_Den_4 As SqlParameter = New SqlParameter("@Gio_Den_4", SqlDbType.Int, 0)
                pGio_Den_4.Value = Gio_Den_4
                MyCommand.Parameters.Add(pGio_Den_4)

                Dim pQua_Ngay_4 As SqlParameter = New SqlParameter("@Qua_Ngay_4", SqlDbType.Bit, 0)
                pQua_Ngay_4.Value = Qua_Ngay_4
                MyCommand.Parameters.Add(pQua_Ngay_4)

                Dim pGhi_Chu_4 As SqlParameter = New SqlParameter("@Ghi_Chu_4", SqlDbType.VarChar, 50)
                pGhi_Chu_4.Value = Ghi_Chu_4
                MyCommand.Parameters.Add(pGhi_Chu_4)

                Dim pSo_Hieu_5 As SqlParameter = New SqlParameter("@So_Hieu_5", SqlDbType.VarChar, 10)
                pSo_Hieu_5.Value = So_Hieu_5
                MyCommand.Parameters.Add(pSo_Hieu_5)

                Dim pNuoc_Xuat_Phat_5 As SqlParameter = New SqlParameter("@Nuoc_Xuat_Phat_5", SqlDbType.VarChar, 2)
                pNuoc_Xuat_Phat_5.Value = Nuoc_Xuat_Phat_5
                MyCommand.Parameters.Add(pNuoc_Xuat_Phat_5)

                Dim pSan_Bay_Xuat_Phat_5 As SqlParameter = New SqlParameter("@San_Bay_Xuat_Phat_5", SqlDbType.VarChar, 3)
                pSan_Bay_Xuat_Phat_5.Value = San_Bay_Xuat_Phat_5
                MyCommand.Parameters.Add(pSan_Bay_Xuat_Phat_5)

                Dim pGio_Xuat_Phat_5 As SqlParameter = New SqlParameter("@Gio_Xuat_Phat_5", SqlDbType.Int, 0)
                pGio_Xuat_Phat_5.Value = Gio_Xuat_Phat_5
                MyCommand.Parameters.Add(pGio_Xuat_Phat_5)

                Dim pNuoc_Den_5 As SqlParameter = New SqlParameter("@Nuoc_Den_5", SqlDbType.VarChar, 2)
                pNuoc_Den_5.Value = Nuoc_Den_5
                MyCommand.Parameters.Add(pNuoc_Den_5)

                Dim pSan_Bay_Den_5 As SqlParameter = New SqlParameter("@San_Bay_Den_5", SqlDbType.VarChar, 3)
                pSan_Bay_Den_5.Value = San_Bay_Den_5
                MyCommand.Parameters.Add(pSan_Bay_Den_5)

                Dim pGio_Den_5 As SqlParameter = New SqlParameter("@Gio_Den_5", SqlDbType.Int, 0)
                pGio_Den_5.Value = Gio_Den_5
                MyCommand.Parameters.Add(pGio_Den_5)

                Dim pQua_Ngay_5 As SqlParameter = New SqlParameter("@Qua_Ngay_5", SqlDbType.Bit, 0)
                pQua_Ngay_5.Value = Qua_Ngay_5
                MyCommand.Parameters.Add(pQua_Ngay_5)

                Dim pGhi_Chu_5 As SqlParameter = New SqlParameter("@Ghi_Chu_5", SqlDbType.VarChar, 50)
                pGhi_Chu_5.Value = Ghi_Chu_5
                MyCommand.Parameters.Add(pGhi_Chu_5)


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

#Region "Danh_Muc_Duong_Bay_So_Hieu_Xoa"
        Public Function Danh_Muc_Duong_Bay_So_Hieu_Xoa(ByVal Id_Duong_Bay As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Duong_Bay_So_Hieu_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDanh_Muc_Duong_Bay_So_Hieu_Chi_Tiet As New Danh_Muc_Duong_Bay_So_Hieu_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Duong_Bay As SqlParameter = New SqlParameter("@Id_Duong_Bay", SqlDbType.VarChar, 50)
                pId_Duong_Bay.Value = Id_Duong_Bay
                MyCommand.Parameters.Add(pId_Duong_Bay)


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


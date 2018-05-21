
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "Huong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop Huong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet
    'Tuong ung voi moi truong trong bang Huong_Di_Buu_Pham_Quoc_Te_Den trong co so du lieu
    '***********************************************************
    Public Class Huong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet
        Public Id_Chi_Tiet As String
        Public Ma_E1 As String
        Public Nuoc_Nhan As String
        Public Phan_Loai As String
        Public Khoi_Luong As Integer
        Public Ngay_Dong_914 As Integer
        Public Id_E1_914_Den As String
        Public Ngay_Den_914 As Integer
        Public Gio_Den_914 As Integer
        Public Den_Close_914 As Boolean
        Public Id_E1_914_Di As String
        Public Ngay_Di_914 As Integer
        Public Gio_Di_914 As Integer
        Public Di_Close_914 As Boolean
        Public Id_E1_907_Den As String
        Public Ngay_Den_907 As Integer
        Public Gio_Den_907 As Integer
        Public Den_Close_907 As Boolean
        Public Id_E1_907_Di As String
        Public Ngay_Di_907 As Integer
        Public Gio_Di_907 As Integer
        Public Di_Close_907 As Boolean
        Public Id_E1_917_Den As String
        Public Ngay_Den_917 As Integer
        Public Gio_Den_917 As Integer
        Public Den_Close_917 As Boolean
        Public Id_E1_917_Di As String
        Public Ngay_Di_917 As Integer
        Public Gio_Di_917 As Integer
        Public Di_Close_917 As Boolean
        Public Id_E1_927_Den As String
        Public Ngay_Den_927 As Integer
        Public Gio_Den_927 As Integer
        Public Den_Close_927 As Boolean
        Public Id_E1_927_Di As String
        Public Ngay_Di_927 As Integer
        Public Gio_Di_927 As Integer
        Public Di_Close_927 As Boolean
        Public Id_E1_937_Den As String
        Public Ngay_Den_937 As Integer
        Public Gio_Den_937 As Integer
        Public Den_Close_937 As Boolean
        Public Id_E1_937_Di As String
        Public Ngay_Di_937 As Integer
        Public Gio_Di_937 As Integer
        Public Di_Close_937 As Boolean
        Public Id_E1_915_Den As String
        Public Ngay_Den_915 As Integer
        Public Gio_Den_915 As Integer
        Public Den_Close_915 As Boolean
        Public Id_E1_915_Di As String
        Public Ngay_Di_915 As Integer
        Public Gio_Di_915 As Integer
        Public Is_Close As Boolean
        Public Kieu_Huong_Di As String
        Public Ngay_Kiem_Hoa As Integer
        Public Gio_Kiem_Hoa As Integer
        Public Ngay_Roi_HQ As Integer
        Public Gio_Roi_HQ As Integer
        Public Ma_Bc_Roi_HQ As Integer
        Public Ngay_He_Thong As Integer
        Public Gio_He_Thong As Integer
    End Class
#End Region

#Region "Huong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ton_Kho_Chi_Tiet"
    '***********************************************************    
    Public Class Huong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ton_Kho_Chi_Tiet
        Public M_Phan_Loai As String
        Public D_Phan_Loai As String
        Public M_Ton_Dau_Ky As Integer
        Public D_Ton_Dau_Ky As Integer
        Public M_Tong_So_Den As Integer
        Public D_Tong_So_Den As Integer
        Public M_Tong_So_Di As Integer
        Public D_Tong_So_Di As Integer
        Public M_Ton_Cuoi_Ky As Integer
        Public D_Ton_Cuoi_Ky As Integer
    End Class
#End Region

#Region "Huong_Di_Buu_Pham_Quoc_Te_Den"
    Public Class Huong_Di_Buu_Pham_Quoc_Te_Den
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "Huong_Di_Buu_Pham_Quoc_Te_Den_Cap_Nhat"
        Public Function Huong_Di_Buu_Pham_Quoc_Te_Den_Cap_Nhat(ByVal Id_Chi_Tiet As String, ByVal Ma_E1 As String, ByVal Nuoc_Nhan As String, ByVal Phan_Loai As String, ByVal Khoi_Luong As Integer, ByVal Ngay_Dong_914 As Integer, ByVal Id_E1_914_Den As String, ByVal Ngay_Den_914 As Integer, ByVal Gio_Den_914 As Integer, ByVal Den_Close_914 As Boolean, ByVal Id_E1_914_Di As String, ByVal Ngay_Di_914 As Integer, ByVal Gio_Di_914 As Integer, ByVal Di_Close_914 As Boolean, ByVal Id_E1_907_Den As String, ByVal Ngay_Den_907 As Integer, ByVal Gio_Den_907 As Integer, ByVal Den_Close_907 As Boolean, ByVal Id_E1_907_Di As String, ByVal Ngay_Di_907 As Integer, ByVal Gio_Di_907 As Integer, ByVal Di_Close_907 As Boolean, ByVal Id_E1_917_Den As String, ByVal Ngay_Den_917 As Integer, ByVal Gio_Den_917 As Integer, ByVal Den_Close_917 As Boolean, ByVal Id_E1_917_Di As String, ByVal Ngay_Di_917 As Integer, ByVal Gio_Di_917 As Integer, ByVal Di_Close_917 As Boolean, ByVal Id_E1_927_Den As String, ByVal Ngay_Den_927 As Integer, ByVal Gio_Den_927 As Integer, ByVal Den_Close_927 As Boolean, ByVal Id_E1_927_Di As String, ByVal Ngay_Di_927 As Integer, ByVal Gio_Di_927 As Integer, ByVal Di_Close_927 As Boolean, ByVal Id_E1_937_Den As String, ByVal Ngay_Den_937 As Integer, ByVal Gio_Den_937 As Integer, ByVal Den_Close_937 As Boolean, ByVal Id_E1_937_Di As String, ByVal Ngay_Di_937 As Integer, ByVal Gio_Di_937 As Integer, ByVal Di_Close_937 As Boolean, ByVal Id_E1_915_Den As String, ByVal Ngay_Den_915 As Integer, ByVal Gio_Den_915 As Integer, ByVal Den_Close_915 As Boolean, ByVal Id_E1_915_Di As String, ByVal Ngay_Di_915 As Integer, ByVal Gio_Di_915 As Integer, ByVal Is_Close As Boolean, ByVal Kieu_Huong_Di As String, ByVal Ngay_Kiem_Hoa As Integer, ByVal Gio_Kiem_Hoa As Integer, ByVal Ngay_Roi_HQ As Integer, ByVal Gio_Roi_HQ As Integer, ByVal Ma_Bc_Roi_HQ As Integer, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Huong_Di_Buu_Pham_Quoc_Te_Den_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet As New Huong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Chi_Tiet As SqlParameter = New SqlParameter("@Id_Chi_Tiet", SqlDbType.VarChar, 30)
                pId_Chi_Tiet.Value = Id_Chi_Tiet
                MyCommand.Parameters.Add(pId_Chi_Tiet)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                MyCommand.Parameters.Add(pMa_E1)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Value = Nuoc_Nhan
                MyCommand.Parameters.Add(pNuoc_Nhan)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.VarChar, 1)
                pPhan_Loai.Value = Phan_Loai
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 0)
                pKhoi_Luong.Value = Khoi_Luong
                MyCommand.Parameters.Add(pKhoi_Luong)

                Dim pNgay_Dong_914 As SqlParameter = New SqlParameter("@Ngay_Dong_914", SqlDbType.Int, 0)
                pNgay_Dong_914.Value = Ngay_Dong_914
                MyCommand.Parameters.Add(pNgay_Dong_914)

                Dim pId_E1_914_Den As SqlParameter = New SqlParameter("@Id_E1_914_Den", SqlDbType.VarChar, 48)
                pId_E1_914_Den.Value = Id_E1_914_Den
                MyCommand.Parameters.Add(pId_E1_914_Den)

                Dim pNgay_Den_914 As SqlParameter = New SqlParameter("@Ngay_Den_914", SqlDbType.Int, 0)
                pNgay_Den_914.Value = Ngay_Den_914
                MyCommand.Parameters.Add(pNgay_Den_914)

                Dim pGio_Den_914 As SqlParameter = New SqlParameter("@Gio_Den_914", SqlDbType.Int, 0)
                pGio_Den_914.Value = Gio_Den_914
                MyCommand.Parameters.Add(pGio_Den_914)

                Dim pDen_Close_914 As SqlParameter = New SqlParameter("@Den_Close_914", SqlDbType.Bit, 0)
                pDen_Close_914.Value = Den_Close_914
                MyCommand.Parameters.Add(pDen_Close_914)

                Dim pId_E1_914_Di As SqlParameter = New SqlParameter("@Id_E1_914_Di", SqlDbType.VarChar, 48)
                pId_E1_914_Di.Value = Id_E1_914_Di
                MyCommand.Parameters.Add(pId_E1_914_Di)

                Dim pNgay_Di_914 As SqlParameter = New SqlParameter("@Ngay_Di_914", SqlDbType.Int, 0)
                pNgay_Di_914.Value = Ngay_Di_914
                MyCommand.Parameters.Add(pNgay_Di_914)

                Dim pGio_Di_914 As SqlParameter = New SqlParameter("@Gio_Di_914", SqlDbType.Int, 0)
                pGio_Di_914.Value = Gio_Di_914
                MyCommand.Parameters.Add(pGio_Di_914)

                Dim pDi_Close_914 As SqlParameter = New SqlParameter("@Di_Close_914", SqlDbType.Bit, 0)
                pDi_Close_914.Value = Di_Close_914
                MyCommand.Parameters.Add(pDi_Close_914)

                Dim pId_E1_907_Den As SqlParameter = New SqlParameter("@Id_E1_907_Den", SqlDbType.VarChar, 48)
                pId_E1_907_Den.Value = Id_E1_907_Den
                MyCommand.Parameters.Add(pId_E1_907_Den)

                Dim pNgay_Den_907 As SqlParameter = New SqlParameter("@Ngay_Den_907", SqlDbType.Int, 0)
                pNgay_Den_907.Value = Ngay_Den_907
                MyCommand.Parameters.Add(pNgay_Den_907)

                Dim pGio_Den_907 As SqlParameter = New SqlParameter("@Gio_Den_907", SqlDbType.Int, 0)
                pGio_Den_907.Value = Gio_Den_907
                MyCommand.Parameters.Add(pGio_Den_907)

                Dim pDen_Close_907 As SqlParameter = New SqlParameter("@Den_Close_907", SqlDbType.Bit, 0)
                pDen_Close_907.Value = Den_Close_907
                MyCommand.Parameters.Add(pDen_Close_907)

                Dim pId_E1_907_Di As SqlParameter = New SqlParameter("@Id_E1_907_Di", SqlDbType.VarChar, 48)
                pId_E1_907_Di.Value = Id_E1_907_Di
                MyCommand.Parameters.Add(pId_E1_907_Di)

                Dim pNgay_Di_907 As SqlParameter = New SqlParameter("@Ngay_Di_907", SqlDbType.Int, 0)
                pNgay_Di_907.Value = Ngay_Di_907
                MyCommand.Parameters.Add(pNgay_Di_907)

                Dim pGio_Di_907 As SqlParameter = New SqlParameter("@Gio_Di_907", SqlDbType.Int, 0)
                pGio_Di_907.Value = Gio_Di_907
                MyCommand.Parameters.Add(pGio_Di_907)

                Dim pDi_Close_907 As SqlParameter = New SqlParameter("@Di_Close_907", SqlDbType.Bit, 0)
                pDi_Close_907.Value = Di_Close_907
                MyCommand.Parameters.Add(pDi_Close_907)

                Dim pId_E1_917_Den As SqlParameter = New SqlParameter("@Id_E1_917_Den", SqlDbType.VarChar, 48)
                pId_E1_917_Den.Value = Id_E1_917_Den
                MyCommand.Parameters.Add(pId_E1_917_Den)

                Dim pNgay_Den_917 As SqlParameter = New SqlParameter("@Ngay_Den_917", SqlDbType.Int, 0)
                pNgay_Den_917.Value = Ngay_Den_917
                MyCommand.Parameters.Add(pNgay_Den_917)

                Dim pGio_Den_917 As SqlParameter = New SqlParameter("@Gio_Den_917", SqlDbType.Int, 0)
                pGio_Den_917.Value = Gio_Den_917
                MyCommand.Parameters.Add(pGio_Den_917)

                Dim pDen_Close_917 As SqlParameter = New SqlParameter("@Den_Close_917", SqlDbType.Bit, 0)
                pDen_Close_917.Value = Den_Close_917
                MyCommand.Parameters.Add(pDen_Close_917)

                Dim pId_E1_917_Di As SqlParameter = New SqlParameter("@Id_E1_917_Di", SqlDbType.VarChar, 48)
                pId_E1_917_Di.Value = Id_E1_917_Di
                MyCommand.Parameters.Add(pId_E1_917_Di)

                Dim pNgay_Di_917 As SqlParameter = New SqlParameter("@Ngay_Di_917", SqlDbType.Int, 0)
                pNgay_Di_917.Value = Ngay_Di_917
                MyCommand.Parameters.Add(pNgay_Di_917)

                Dim pGio_Di_917 As SqlParameter = New SqlParameter("@Gio_Di_917", SqlDbType.Int, 0)
                pGio_Di_917.Value = Gio_Di_917
                MyCommand.Parameters.Add(pGio_Di_917)

                Dim pDi_Close_917 As SqlParameter = New SqlParameter("@Di_Close_917", SqlDbType.Bit, 0)
                pDi_Close_917.Value = Di_Close_917
                MyCommand.Parameters.Add(pDi_Close_917)

                Dim pId_E1_927_Den As SqlParameter = New SqlParameter("@Id_E1_927_Den", SqlDbType.VarChar, 48)
                pId_E1_927_Den.Value = Id_E1_927_Den
                MyCommand.Parameters.Add(pId_E1_927_Den)

                Dim pNgay_Den_927 As SqlParameter = New SqlParameter("@Ngay_Den_927", SqlDbType.Int, 0)
                pNgay_Den_927.Value = Ngay_Den_927
                MyCommand.Parameters.Add(pNgay_Den_927)

                Dim pGio_Den_927 As SqlParameter = New SqlParameter("@Gio_Den_927", SqlDbType.Int, 0)
                pGio_Den_927.Value = Gio_Den_927
                MyCommand.Parameters.Add(pGio_Den_927)

                Dim pDen_Close_927 As SqlParameter = New SqlParameter("@Den_Close_927", SqlDbType.Bit, 0)
                pDen_Close_927.Value = Den_Close_927
                MyCommand.Parameters.Add(pDen_Close_927)

                Dim pId_E1_927_Di As SqlParameter = New SqlParameter("@Id_E1_927_Di", SqlDbType.VarChar, 48)
                pId_E1_927_Di.Value = Id_E1_927_Di
                MyCommand.Parameters.Add(pId_E1_927_Di)

                Dim pNgay_Di_927 As SqlParameter = New SqlParameter("@Ngay_Di_927", SqlDbType.Int, 0)
                pNgay_Di_927.Value = Ngay_Di_927
                MyCommand.Parameters.Add(pNgay_Di_927)

                Dim pGio_Di_927 As SqlParameter = New SqlParameter("@Gio_Di_927", SqlDbType.Int, 0)
                pGio_Di_927.Value = Gio_Di_927
                MyCommand.Parameters.Add(pGio_Di_927)

                Dim pDi_Close_927 As SqlParameter = New SqlParameter("@Di_Close_927", SqlDbType.Bit, 0)
                pDi_Close_927.Value = Di_Close_927
                MyCommand.Parameters.Add(pDi_Close_927)

                Dim pId_E1_937_Den As SqlParameter = New SqlParameter("@Id_E1_937_Den", SqlDbType.VarChar, 48)
                pId_E1_937_Den.Value = Id_E1_937_Den
                MyCommand.Parameters.Add(pId_E1_937_Den)

                Dim pNgay_Den_937 As SqlParameter = New SqlParameter("@Ngay_Den_937", SqlDbType.Int, 0)
                pNgay_Den_937.Value = Ngay_Den_937
                MyCommand.Parameters.Add(pNgay_Den_937)

                Dim pGio_Den_937 As SqlParameter = New SqlParameter("@Gio_Den_937", SqlDbType.Int, 0)
                pGio_Den_937.Value = Gio_Den_937
                MyCommand.Parameters.Add(pGio_Den_937)

                Dim pDen_Close_937 As SqlParameter = New SqlParameter("@Den_Close_937", SqlDbType.Bit, 0)
                pDen_Close_937.Value = Den_Close_937
                MyCommand.Parameters.Add(pDen_Close_937)

                Dim pId_E1_937_Di As SqlParameter = New SqlParameter("@Id_E1_937_Di", SqlDbType.VarChar, 48)
                pId_E1_937_Di.Value = Id_E1_937_Di
                MyCommand.Parameters.Add(pId_E1_937_Di)

                Dim pNgay_Di_937 As SqlParameter = New SqlParameter("@Ngay_Di_937", SqlDbType.Int, 0)
                pNgay_Di_937.Value = Ngay_Di_937
                MyCommand.Parameters.Add(pNgay_Di_937)

                Dim pGio_Di_937 As SqlParameter = New SqlParameter("@Gio_Di_937", SqlDbType.Int, 0)
                pGio_Di_937.Value = Gio_Di_937
                MyCommand.Parameters.Add(pGio_Di_937)

                Dim pDi_Close_937 As SqlParameter = New SqlParameter("@Di_Close_937", SqlDbType.Bit, 0)
                pDi_Close_937.Value = Di_Close_937
                MyCommand.Parameters.Add(pDi_Close_937)

                Dim pId_E1_915_Den As SqlParameter = New SqlParameter("@Id_E1_915_Den", SqlDbType.VarChar, 48)
                pId_E1_915_Den.Value = Id_E1_915_Den
                MyCommand.Parameters.Add(pId_E1_915_Den)

                Dim pNgay_Den_915 As SqlParameter = New SqlParameter("@Ngay_Den_915", SqlDbType.Int, 0)
                pNgay_Den_915.Value = Ngay_Den_915
                MyCommand.Parameters.Add(pNgay_Den_915)

                Dim pGio_Den_915 As SqlParameter = New SqlParameter("@Gio_Den_915", SqlDbType.Int, 0)
                pGio_Den_915.Value = Gio_Den_915
                MyCommand.Parameters.Add(pGio_Den_915)

                Dim pDen_Close_915 As SqlParameter = New SqlParameter("@Den_Close_915", SqlDbType.Bit, 0)
                pDen_Close_915.Value = Den_Close_915
                MyCommand.Parameters.Add(pDen_Close_915)

                Dim pId_E1_915_Di As SqlParameter = New SqlParameter("@Id_E1_915_Di", SqlDbType.VarChar, 48)
                pId_E1_915_Di.Value = Id_E1_915_Di
                MyCommand.Parameters.Add(pId_E1_915_Di)

                Dim pNgay_Di_915 As SqlParameter = New SqlParameter("@Ngay_Di_915", SqlDbType.Int, 0)
                pNgay_Di_915.Value = Ngay_Di_915
                MyCommand.Parameters.Add(pNgay_Di_915)

                Dim pGio_Di_915 As SqlParameter = New SqlParameter("@Gio_Di_915", SqlDbType.Int, 0)
                pGio_Di_915.Value = Gio_Di_915
                MyCommand.Parameters.Add(pGio_Di_915)

                Dim pIs_Close As SqlParameter = New SqlParameter("@Is_Close", SqlDbType.Bit, 0)
                pIs_Close.Value = Is_Close
                MyCommand.Parameters.Add(pIs_Close)

                Dim pKieu_Huong_Di As SqlParameter = New SqlParameter("@Kieu_Huong_Di", SqlDbType.VarChar, 1)
                pKieu_Huong_Di.Value = Kieu_Huong_Di
                MyCommand.Parameters.Add(pKieu_Huong_Di)

                Dim pNgay_Kiem_Hoa As SqlParameter = New SqlParameter("@Ngay_Kiem_Hoa", SqlDbType.Int, 0)
                pNgay_Kiem_Hoa.Value = Ngay_Kiem_Hoa
                MyCommand.Parameters.Add(pNgay_Kiem_Hoa)

                Dim pGio_Kiem_Hoa As SqlParameter = New SqlParameter("@Gio_Kiem_Hoa", SqlDbType.Int, 0)
                pGio_Kiem_Hoa.Value = Gio_Kiem_Hoa
                MyCommand.Parameters.Add(pGio_Kiem_Hoa)

                Dim pNgay_Roi_HQ As SqlParameter = New SqlParameter("@Ngay_Roi_HQ", SqlDbType.Int, 0)
                pNgay_Roi_HQ.Value = Ngay_Roi_HQ
                MyCommand.Parameters.Add(pNgay_Roi_HQ)

                Dim pGio_Roi_HQ As SqlParameter = New SqlParameter("@Gio_Roi_HQ", SqlDbType.Int, 0)
                pGio_Roi_HQ.Value = Gio_Roi_HQ
                MyCommand.Parameters.Add(pGio_Roi_HQ)

                Dim pMa_Bc_Roi_HQ As SqlParameter = New SqlParameter("@Ma_Bc_Roi_HQ", SqlDbType.Int, 0)
                pMa_Bc_Roi_HQ.Value = Ma_Bc_Roi_HQ
                MyCommand.Parameters.Add(pMa_Bc_Roi_HQ)

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

#Region "Huong_Di_Buu_Pham_Quoc_Te_Den_Cap_Nhat_Them"
        Public Function Huong_Di_Buu_Pham_Quoc_Te_Den_Cap_Nhat_Them(ByVal Id_Chi_Tiet As String, ByVal Ma_E1 As String, ByVal Nuoc_Nhan As String, ByVal Phan_Loai As String, ByVal Khoi_Luong As Integer, ByVal Ngay_Dong_914 As Integer, ByVal Id_E1_914_Den As String, ByVal Ngay_Den_914 As Integer, ByVal Gio_Den_914 As Integer, ByVal Den_Close_914 As Boolean, ByVal Id_E1_914_Di As String, ByVal Ngay_Di_914 As Integer, ByVal Gio_Di_914 As Integer, ByVal Di_Close_914 As Boolean, ByVal Id_E1_907_Den As String, ByVal Ngay_Den_907 As Integer, ByVal Gio_Den_907 As Integer, ByVal Den_Close_907 As Boolean, ByVal Id_E1_907_Di As String, ByVal Ngay_Di_907 As Integer, ByVal Gio_Di_907 As Integer, ByVal Di_Close_907 As Boolean, ByVal Id_E1_917_Den As String, ByVal Ngay_Den_917 As Integer, ByVal Gio_Den_917 As Integer, ByVal Den_Close_917 As Boolean, ByVal Id_E1_917_Di As String, ByVal Ngay_Di_917 As Integer, ByVal Gio_Di_917 As Integer, ByVal Di_Close_917 As Boolean, ByVal Id_E1_927_Den As String, ByVal Ngay_Den_927 As Integer, ByVal Gio_Den_927 As Integer, ByVal Den_Close_927 As Boolean, ByVal Id_E1_927_Di As String, ByVal Ngay_Di_927 As Integer, ByVal Gio_Di_927 As Integer, ByVal Di_Close_927 As Boolean, ByVal Id_E1_937_Den As String, ByVal Ngay_Den_937 As Integer, ByVal Gio_Den_937 As Integer, ByVal Den_Close_937 As Boolean, ByVal Id_E1_937_Di As String, ByVal Ngay_Di_937 As Integer, ByVal Gio_Di_937 As Integer, ByVal Di_Close_937 As Boolean, ByVal Id_E1_915_Den As String, ByVal Ngay_Den_915 As Integer, ByVal Gio_Den_915 As Integer, ByVal Den_Close_915 As Boolean, ByVal Id_E1_915_Di As String, ByVal Ngay_Di_915 As Integer, ByVal Gio_Di_915 As Integer, ByVal Is_Close As Boolean, ByVal Kieu_Huong_Di As String, ByVal Ngay_Kiem_Hoa As Integer, ByVal Gio_Kiem_Hoa As Integer, ByVal Ngay_Roi_HQ As Integer, ByVal Gio_Roi_HQ As Integer, ByVal Ma_Bc_Roi_HQ As Integer, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Huong_Di_Buu_Pham_Quoc_Te_Den_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet As New Huong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Chi_Tiet As SqlParameter = New SqlParameter("@Id_Chi_Tiet", SqlDbType.VarChar, 30)
                pId_Chi_Tiet.Value = Id_Chi_Tiet
                MyCommand.Parameters.Add(pId_Chi_Tiet)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                MyCommand.Parameters.Add(pMa_E1)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Value = Nuoc_Nhan
                MyCommand.Parameters.Add(pNuoc_Nhan)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.VarChar, 1)
                pPhan_Loai.Value = Phan_Loai
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 0)
                pKhoi_Luong.Value = Khoi_Luong
                MyCommand.Parameters.Add(pKhoi_Luong)

                Dim pNgay_Dong_914 As SqlParameter = New SqlParameter("@Ngay_Dong_914", SqlDbType.Int, 0)
                pNgay_Dong_914.Value = Ngay_Dong_914
                MyCommand.Parameters.Add(pNgay_Dong_914)

                Dim pId_E1_914_Den As SqlParameter = New SqlParameter("@Id_E1_914_Den", SqlDbType.VarChar, 48)
                pId_E1_914_Den.Value = Id_E1_914_Den
                MyCommand.Parameters.Add(pId_E1_914_Den)

                Dim pNgay_Den_914 As SqlParameter = New SqlParameter("@Ngay_Den_914", SqlDbType.Int, 0)
                pNgay_Den_914.Value = Ngay_Den_914
                MyCommand.Parameters.Add(pNgay_Den_914)

                Dim pGio_Den_914 As SqlParameter = New SqlParameter("@Gio_Den_914", SqlDbType.Int, 0)
                pGio_Den_914.Value = Gio_Den_914
                MyCommand.Parameters.Add(pGio_Den_914)

                Dim pDen_Close_914 As SqlParameter = New SqlParameter("@Den_Close_914", SqlDbType.Bit, 0)
                pDen_Close_914.Value = Den_Close_914
                MyCommand.Parameters.Add(pDen_Close_914)

                Dim pId_E1_914_Di As SqlParameter = New SqlParameter("@Id_E1_914_Di", SqlDbType.VarChar, 48)
                pId_E1_914_Di.Value = Id_E1_914_Di
                MyCommand.Parameters.Add(pId_E1_914_Di)

                Dim pNgay_Di_914 As SqlParameter = New SqlParameter("@Ngay_Di_914", SqlDbType.Int, 0)
                pNgay_Di_914.Value = Ngay_Di_914
                MyCommand.Parameters.Add(pNgay_Di_914)

                Dim pGio_Di_914 As SqlParameter = New SqlParameter("@Gio_Di_914", SqlDbType.Int, 0)
                pGio_Di_914.Value = Gio_Di_914
                MyCommand.Parameters.Add(pGio_Di_914)

                Dim pDi_Close_914 As SqlParameter = New SqlParameter("@Di_Close_914", SqlDbType.Bit, 0)
                pDi_Close_914.Value = Di_Close_914
                MyCommand.Parameters.Add(pDi_Close_914)

                Dim pId_E1_907_Den As SqlParameter = New SqlParameter("@Id_E1_907_Den", SqlDbType.VarChar, 48)
                pId_E1_907_Den.Value = Id_E1_907_Den
                MyCommand.Parameters.Add(pId_E1_907_Den)

                Dim pNgay_Den_907 As SqlParameter = New SqlParameter("@Ngay_Den_907", SqlDbType.Int, 0)
                pNgay_Den_907.Value = Ngay_Den_907
                MyCommand.Parameters.Add(pNgay_Den_907)

                Dim pGio_Den_907 As SqlParameter = New SqlParameter("@Gio_Den_907", SqlDbType.Int, 0)
                pGio_Den_907.Value = Gio_Den_907
                MyCommand.Parameters.Add(pGio_Den_907)

                Dim pDen_Close_907 As SqlParameter = New SqlParameter("@Den_Close_907", SqlDbType.Bit, 0)
                pDen_Close_907.Value = Den_Close_907
                MyCommand.Parameters.Add(pDen_Close_907)

                Dim pId_E1_907_Di As SqlParameter = New SqlParameter("@Id_E1_907_Di", SqlDbType.VarChar, 48)
                pId_E1_907_Di.Value = Id_E1_907_Di
                MyCommand.Parameters.Add(pId_E1_907_Di)

                Dim pNgay_Di_907 As SqlParameter = New SqlParameter("@Ngay_Di_907", SqlDbType.Int, 0)
                pNgay_Di_907.Value = Ngay_Di_907
                MyCommand.Parameters.Add(pNgay_Di_907)

                Dim pGio_Di_907 As SqlParameter = New SqlParameter("@Gio_Di_907", SqlDbType.Int, 0)
                pGio_Di_907.Value = Gio_Di_907
                MyCommand.Parameters.Add(pGio_Di_907)

                Dim pDi_Close_907 As SqlParameter = New SqlParameter("@Di_Close_907", SqlDbType.Bit, 0)
                pDi_Close_907.Value = Di_Close_907
                MyCommand.Parameters.Add(pDi_Close_907)

                Dim pId_E1_917_Den As SqlParameter = New SqlParameter("@Id_E1_917_Den", SqlDbType.VarChar, 48)
                pId_E1_917_Den.Value = Id_E1_917_Den
                MyCommand.Parameters.Add(pId_E1_917_Den)

                Dim pNgay_Den_917 As SqlParameter = New SqlParameter("@Ngay_Den_917", SqlDbType.Int, 0)
                pNgay_Den_917.Value = Ngay_Den_917
                MyCommand.Parameters.Add(pNgay_Den_917)

                Dim pGio_Den_917 As SqlParameter = New SqlParameter("@Gio_Den_917", SqlDbType.Int, 0)
                pGio_Den_917.Value = Gio_Den_917
                MyCommand.Parameters.Add(pGio_Den_917)

                Dim pDen_Close_917 As SqlParameter = New SqlParameter("@Den_Close_917", SqlDbType.Bit, 0)
                pDen_Close_917.Value = Den_Close_917
                MyCommand.Parameters.Add(pDen_Close_917)

                Dim pId_E1_917_Di As SqlParameter = New SqlParameter("@Id_E1_917_Di", SqlDbType.VarChar, 48)
                pId_E1_917_Di.Value = Id_E1_917_Di
                MyCommand.Parameters.Add(pId_E1_917_Di)

                Dim pNgay_Di_917 As SqlParameter = New SqlParameter("@Ngay_Di_917", SqlDbType.Int, 0)
                pNgay_Di_917.Value = Ngay_Di_917
                MyCommand.Parameters.Add(pNgay_Di_917)

                Dim pGio_Di_917 As SqlParameter = New SqlParameter("@Gio_Di_917", SqlDbType.Int, 0)
                pGio_Di_917.Value = Gio_Di_917
                MyCommand.Parameters.Add(pGio_Di_917)

                Dim pDi_Close_917 As SqlParameter = New SqlParameter("@Di_Close_917", SqlDbType.Bit, 0)
                pDi_Close_917.Value = Di_Close_917
                MyCommand.Parameters.Add(pDi_Close_917)

                Dim pId_E1_927_Den As SqlParameter = New SqlParameter("@Id_E1_927_Den", SqlDbType.VarChar, 48)
                pId_E1_927_Den.Value = Id_E1_927_Den
                MyCommand.Parameters.Add(pId_E1_927_Den)

                Dim pNgay_Den_927 As SqlParameter = New SqlParameter("@Ngay_Den_927", SqlDbType.Int, 0)
                pNgay_Den_927.Value = Ngay_Den_927
                MyCommand.Parameters.Add(pNgay_Den_927)

                Dim pGio_Den_927 As SqlParameter = New SqlParameter("@Gio_Den_927", SqlDbType.Int, 0)
                pGio_Den_927.Value = Gio_Den_927
                MyCommand.Parameters.Add(pGio_Den_927)

                Dim pDen_Close_927 As SqlParameter = New SqlParameter("@Den_Close_927", SqlDbType.Bit, 0)
                pDen_Close_927.Value = Den_Close_927
                MyCommand.Parameters.Add(pDen_Close_927)

                Dim pId_E1_927_Di As SqlParameter = New SqlParameter("@Id_E1_927_Di", SqlDbType.VarChar, 48)
                pId_E1_927_Di.Value = Id_E1_927_Di
                MyCommand.Parameters.Add(pId_E1_927_Di)

                Dim pNgay_Di_927 As SqlParameter = New SqlParameter("@Ngay_Di_927", SqlDbType.Int, 0)
                pNgay_Di_927.Value = Ngay_Di_927
                MyCommand.Parameters.Add(pNgay_Di_927)

                Dim pGio_Di_927 As SqlParameter = New SqlParameter("@Gio_Di_927", SqlDbType.Int, 0)
                pGio_Di_927.Value = Gio_Di_927
                MyCommand.Parameters.Add(pGio_Di_927)

                Dim pDi_Close_927 As SqlParameter = New SqlParameter("@Di_Close_927", SqlDbType.Bit, 0)
                pDi_Close_927.Value = Di_Close_927
                MyCommand.Parameters.Add(pDi_Close_927)

                Dim pId_E1_937_Den As SqlParameter = New SqlParameter("@Id_E1_937_Den", SqlDbType.VarChar, 48)
                pId_E1_937_Den.Value = Id_E1_937_Den
                MyCommand.Parameters.Add(pId_E1_937_Den)

                Dim pNgay_Den_937 As SqlParameter = New SqlParameter("@Ngay_Den_937", SqlDbType.Int, 0)
                pNgay_Den_937.Value = Ngay_Den_937
                MyCommand.Parameters.Add(pNgay_Den_937)

                Dim pGio_Den_937 As SqlParameter = New SqlParameter("@Gio_Den_937", SqlDbType.Int, 0)
                pGio_Den_937.Value = Gio_Den_937
                MyCommand.Parameters.Add(pGio_Den_937)

                Dim pDen_Close_937 As SqlParameter = New SqlParameter("@Den_Close_937", SqlDbType.Bit, 0)
                pDen_Close_937.Value = Den_Close_937
                MyCommand.Parameters.Add(pDen_Close_937)

                Dim pId_E1_937_Di As SqlParameter = New SqlParameter("@Id_E1_937_Di", SqlDbType.VarChar, 48)
                pId_E1_937_Di.Value = Id_E1_937_Di
                MyCommand.Parameters.Add(pId_E1_937_Di)

                Dim pNgay_Di_937 As SqlParameter = New SqlParameter("@Ngay_Di_937", SqlDbType.Int, 0)
                pNgay_Di_937.Value = Ngay_Di_937
                MyCommand.Parameters.Add(pNgay_Di_937)

                Dim pGio_Di_937 As SqlParameter = New SqlParameter("@Gio_Di_937", SqlDbType.Int, 0)
                pGio_Di_937.Value = Gio_Di_937
                MyCommand.Parameters.Add(pGio_Di_937)

                Dim pDi_Close_937 As SqlParameter = New SqlParameter("@Di_Close_937", SqlDbType.Bit, 0)
                pDi_Close_937.Value = Di_Close_937
                MyCommand.Parameters.Add(pDi_Close_937)

                Dim pId_E1_915_Den As SqlParameter = New SqlParameter("@Id_E1_915_Den", SqlDbType.VarChar, 48)
                pId_E1_915_Den.Value = Id_E1_915_Den
                MyCommand.Parameters.Add(pId_E1_915_Den)

                Dim pNgay_Den_915 As SqlParameter = New SqlParameter("@Ngay_Den_915", SqlDbType.Int, 0)
                pNgay_Den_915.Value = Ngay_Den_915
                MyCommand.Parameters.Add(pNgay_Den_915)

                Dim pGio_Den_915 As SqlParameter = New SqlParameter("@Gio_Den_915", SqlDbType.Int, 0)
                pGio_Den_915.Value = Gio_Den_915
                MyCommand.Parameters.Add(pGio_Den_915)

                Dim pDen_Close_915 As SqlParameter = New SqlParameter("@Den_Close_915", SqlDbType.Bit, 0)
                pDen_Close_915.Value = Den_Close_915
                MyCommand.Parameters.Add(pDen_Close_915)

                Dim pId_E1_915_Di As SqlParameter = New SqlParameter("@Id_E1_915_Di", SqlDbType.VarChar, 48)
                pId_E1_915_Di.Value = Id_E1_915_Di
                MyCommand.Parameters.Add(pId_E1_915_Di)

                Dim pNgay_Di_915 As SqlParameter = New SqlParameter("@Ngay_Di_915", SqlDbType.Int, 0)
                pNgay_Di_915.Value = Ngay_Di_915
                MyCommand.Parameters.Add(pNgay_Di_915)

                Dim pGio_Di_915 As SqlParameter = New SqlParameter("@Gio_Di_915", SqlDbType.Int, 0)
                pGio_Di_915.Value = Gio_Di_915
                MyCommand.Parameters.Add(pGio_Di_915)

                Dim pIs_Close As SqlParameter = New SqlParameter("@Is_Close", SqlDbType.Bit, 0)
                pIs_Close.Value = Is_Close
                MyCommand.Parameters.Add(pIs_Close)

                Dim pKieu_Huong_Di As SqlParameter = New SqlParameter("@Kieu_Huong_Di", SqlDbType.VarChar, 1)
                pKieu_Huong_Di.Value = Kieu_Huong_Di
                MyCommand.Parameters.Add(pKieu_Huong_Di)

                Dim pNgay_Kiem_Hoa As SqlParameter = New SqlParameter("@Ngay_Kiem_Hoa", SqlDbType.Int, 0)
                pNgay_Kiem_Hoa.Value = Ngay_Kiem_Hoa
                MyCommand.Parameters.Add(pNgay_Kiem_Hoa)

                Dim pGio_Kiem_Hoa As SqlParameter = New SqlParameter("@Gio_Kiem_Hoa", SqlDbType.Int, 0)
                pGio_Kiem_Hoa.Value = Gio_Kiem_Hoa
                MyCommand.Parameters.Add(pGio_Kiem_Hoa)

                Dim pNgay_Roi_HQ As SqlParameter = New SqlParameter("@Ngay_Roi_HQ", SqlDbType.Int, 0)
                pNgay_Roi_HQ.Value = Ngay_Roi_HQ
                MyCommand.Parameters.Add(pNgay_Roi_HQ)

                Dim pGio_Roi_HQ As SqlParameter = New SqlParameter("@Gio_Roi_HQ", SqlDbType.Int, 0)
                pGio_Roi_HQ.Value = Gio_Roi_HQ
                MyCommand.Parameters.Add(pGio_Roi_HQ)

                Dim pMa_Bc_Roi_HQ As SqlParameter = New SqlParameter("@Ma_Bc_Roi_HQ", SqlDbType.Int, 0)
                pMa_Bc_Roi_HQ.Value = Ma_Bc_Roi_HQ
                MyCommand.Parameters.Add(pMa_Bc_Roi_HQ)

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

#Region "Huong_Di_Buu_Pham_Quoc_Te_Den_Danh_Sach"

        Public Function Huong_Di_Buu_Pham_Quoc_Te_Den_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Id_Chi_Tiet
            ' Ma_E1
            ' Nuoc_Nhan
            ' Phan_Loai
            ' Khoi_Luong
            ' Ngay_Dong_914
            ' Id_E1_914_Den
            ' Ngay_Den_914
            ' Gio_Den_914
            ' Den_Close_914
            ' Id_E1_914_Di
            ' Ngay_Di_914
            ' Gio_Di_914
            ' Di_Close_914
            ' Id_E1_907_Den
            ' Ngay_Den_907
            ' Gio_Den_907
            ' Den_Close_907
            ' Id_E1_907_Di
            ' Ngay_Di_907
            ' Gio_Di_907
            ' Di_Close_907
            ' Id_E1_917_Den
            ' Ngay_Den_917
            ' Gio_Den_917
            ' Den_Close_917
            ' Id_E1_917_Di
            ' Ngay_Di_917
            ' Gio_Di_917
            ' Di_Close_917
            ' Id_E1_927_Den
            ' Ngay_Den_927
            ' Gio_Den_927
            ' Den_Close_927
            ' Id_E1_927_Di
            ' Ngay_Di_927
            ' Gio_Di_927
            ' Di_Close_927
            ' Id_E1_937_Den
            ' Ngay_Den_937
            ' Gio_Den_937
            ' Den_Close_937
            ' Id_E1_937_Di
            ' Ngay_Di_937
            ' Gio_Di_937
            ' Di_Close_937
            ' Id_E1_915_Den
            ' Ngay_Den_915
            ' Gio_Den_915
            ' Den_Close_915
            ' Id_E1_915_Di
            ' Ngay_Di_915
            ' Gio_Di_915
            ' Is_Close
            ' Kieu_Huong_Di
            ' Ngay_Kiem_Hoa
            ' Gio_Kiem_Hoa
            ' Ngay_Roi_HQ
            ' Gio_Roi_HQ
            ' Ma_Bc_Roi_HQ
            ' Ngay_He_Thong
            ' Gio_He_Thong


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Huong_Di_Buu_Pham_Quoc_Te_Den_Danh_Sach"
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

#Region "Huong_Di_Buu_Pham_Quoc_Te_Den_Lay"
        Public Function Huong_Di_Buu_Pham_Quoc_Te_Den_Lay(ByVal Id_Chi_Tiet As String) As Huong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Huong_Di_Buu_Pham_Quoc_Te_Den_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet As New Huong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Chi_Tiet As SqlParameter = New SqlParameter("@Id_Chi_Tiet", SqlDbType.VarChar, 30)
                pId_Chi_Tiet.Value = Id_Chi_Tiet
                MyCommand.Parameters.Add(pId_Chi_Tiet)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_E1)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNuoc_Nhan)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.VarChar, 1)
                pPhan_Loai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 0)
                pKhoi_Luong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pKhoi_Luong)

                Dim pNgay_Dong_914 As SqlParameter = New SqlParameter("@Ngay_Dong_914", SqlDbType.Int, 0)
                pNgay_Dong_914.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Dong_914)

                Dim pId_E1_914_Den As SqlParameter = New SqlParameter("@Id_E1_914_Den", SqlDbType.VarChar, 48)
                pId_E1_914_Den.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_E1_914_Den)

                Dim pNgay_Den_914 As SqlParameter = New SqlParameter("@Ngay_Den_914", SqlDbType.Int, 0)
                pNgay_Den_914.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Den_914)

                Dim pGio_Den_914 As SqlParameter = New SqlParameter("@Gio_Den_914", SqlDbType.Int, 0)
                pGio_Den_914.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Den_914)

                Dim pDen_Close_914 As SqlParameter = New SqlParameter("@Den_Close_914", SqlDbType.Bit, 0)
                pDen_Close_914.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDen_Close_914)

                Dim pId_E1_914_Di As SqlParameter = New SqlParameter("@Id_E1_914_Di", SqlDbType.VarChar, 48)
                pId_E1_914_Di.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_E1_914_Di)

                Dim pNgay_Di_914 As SqlParameter = New SqlParameter("@Ngay_Di_914", SqlDbType.Int, 0)
                pNgay_Di_914.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Di_914)

                Dim pGio_Di_914 As SqlParameter = New SqlParameter("@Gio_Di_914", SqlDbType.Int, 0)
                pGio_Di_914.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Di_914)

                Dim pDi_Close_914 As SqlParameter = New SqlParameter("@Di_Close_914", SqlDbType.Bit, 0)
                pDi_Close_914.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDi_Close_914)

                Dim pId_E1_907_Den As SqlParameter = New SqlParameter("@Id_E1_907_Den", SqlDbType.VarChar, 48)
                pId_E1_907_Den.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_E1_907_Den)

                Dim pNgay_Den_907 As SqlParameter = New SqlParameter("@Ngay_Den_907", SqlDbType.Int, 0)
                pNgay_Den_907.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Den_907)

                Dim pGio_Den_907 As SqlParameter = New SqlParameter("@Gio_Den_907", SqlDbType.Int, 0)
                pGio_Den_907.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Den_907)

                Dim pDen_Close_907 As SqlParameter = New SqlParameter("@Den_Close_907", SqlDbType.Bit, 0)
                pDen_Close_907.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDen_Close_907)

                Dim pId_E1_907_Di As SqlParameter = New SqlParameter("@Id_E1_907_Di", SqlDbType.VarChar, 48)
                pId_E1_907_Di.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_E1_907_Di)

                Dim pNgay_Di_907 As SqlParameter = New SqlParameter("@Ngay_Di_907", SqlDbType.Int, 0)
                pNgay_Di_907.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Di_907)

                Dim pGio_Di_907 As SqlParameter = New SqlParameter("@Gio_Di_907", SqlDbType.Int, 0)
                pGio_Di_907.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Di_907)

                Dim pDi_Close_907 As SqlParameter = New SqlParameter("@Di_Close_907", SqlDbType.Bit, 0)
                pDi_Close_907.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDi_Close_907)

                Dim pId_E1_917_Den As SqlParameter = New SqlParameter("@Id_E1_917_Den", SqlDbType.VarChar, 48)
                pId_E1_917_Den.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_E1_917_Den)

                Dim pNgay_Den_917 As SqlParameter = New SqlParameter("@Ngay_Den_917", SqlDbType.Int, 0)
                pNgay_Den_917.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Den_917)

                Dim pGio_Den_917 As SqlParameter = New SqlParameter("@Gio_Den_917", SqlDbType.Int, 0)
                pGio_Den_917.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Den_917)

                Dim pDen_Close_917 As SqlParameter = New SqlParameter("@Den_Close_917", SqlDbType.Bit, 0)
                pDen_Close_917.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDen_Close_917)

                Dim pId_E1_917_Di As SqlParameter = New SqlParameter("@Id_E1_917_Di", SqlDbType.VarChar, 48)
                pId_E1_917_Di.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_E1_917_Di)

                Dim pNgay_Di_917 As SqlParameter = New SqlParameter("@Ngay_Di_917", SqlDbType.Int, 0)
                pNgay_Di_917.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Di_917)

                Dim pGio_Di_917 As SqlParameter = New SqlParameter("@Gio_Di_917", SqlDbType.Int, 0)
                pGio_Di_917.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Di_917)

                Dim pDi_Close_917 As SqlParameter = New SqlParameter("@Di_Close_917", SqlDbType.Bit, 0)
                pDi_Close_917.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDi_Close_917)

                Dim pId_E1_927_Den As SqlParameter = New SqlParameter("@Id_E1_927_Den", SqlDbType.VarChar, 48)
                pId_E1_927_Den.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_E1_927_Den)

                Dim pNgay_Den_927 As SqlParameter = New SqlParameter("@Ngay_Den_927", SqlDbType.Int, 0)
                pNgay_Den_927.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Den_927)

                Dim pGio_Den_927 As SqlParameter = New SqlParameter("@Gio_Den_927", SqlDbType.Int, 0)
                pGio_Den_927.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Den_927)

                Dim pDen_Close_927 As SqlParameter = New SqlParameter("@Den_Close_927", SqlDbType.Bit, 0)
                pDen_Close_927.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDen_Close_927)

                Dim pId_E1_927_Di As SqlParameter = New SqlParameter("@Id_E1_927_Di", SqlDbType.VarChar, 48)
                pId_E1_927_Di.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_E1_927_Di)

                Dim pNgay_Di_927 As SqlParameter = New SqlParameter("@Ngay_Di_927", SqlDbType.Int, 0)
                pNgay_Di_927.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Di_927)

                Dim pGio_Di_927 As SqlParameter = New SqlParameter("@Gio_Di_927", SqlDbType.Int, 0)
                pGio_Di_927.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Di_927)

                Dim pDi_Close_927 As SqlParameter = New SqlParameter("@Di_Close_927", SqlDbType.Bit, 0)
                pDi_Close_927.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDi_Close_927)

                Dim pId_E1_937_Den As SqlParameter = New SqlParameter("@Id_E1_937_Den", SqlDbType.VarChar, 48)
                pId_E1_937_Den.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_E1_937_Den)

                Dim pNgay_Den_937 As SqlParameter = New SqlParameter("@Ngay_Den_937", SqlDbType.Int, 0)
                pNgay_Den_937.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Den_937)

                Dim pGio_Den_937 As SqlParameter = New SqlParameter("@Gio_Den_937", SqlDbType.Int, 0)
                pGio_Den_937.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Den_937)

                Dim pDen_Close_937 As SqlParameter = New SqlParameter("@Den_Close_937", SqlDbType.Bit, 0)
                pDen_Close_937.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDen_Close_937)

                Dim pId_E1_937_Di As SqlParameter = New SqlParameter("@Id_E1_937_Di", SqlDbType.VarChar, 48)
                pId_E1_937_Di.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_E1_937_Di)

                Dim pNgay_Di_937 As SqlParameter = New SqlParameter("@Ngay_Di_937", SqlDbType.Int, 0)
                pNgay_Di_937.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Di_937)

                Dim pGio_Di_937 As SqlParameter = New SqlParameter("@Gio_Di_937", SqlDbType.Int, 0)
                pGio_Di_937.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Di_937)

                Dim pDi_Close_937 As SqlParameter = New SqlParameter("@Di_Close_937", SqlDbType.Bit, 0)
                pDi_Close_937.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDi_Close_937)

                Dim pId_E1_915_Den As SqlParameter = New SqlParameter("@Id_E1_915_Den", SqlDbType.VarChar, 48)
                pId_E1_915_Den.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_E1_915_Den)

                Dim pNgay_Den_915 As SqlParameter = New SqlParameter("@Ngay_Den_915", SqlDbType.Int, 0)
                pNgay_Den_915.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Den_915)

                Dim pGio_Den_915 As SqlParameter = New SqlParameter("@Gio_Den_915", SqlDbType.Int, 0)
                pGio_Den_915.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Den_915)

                Dim pDen_Close_915 As SqlParameter = New SqlParameter("@Den_Close_915", SqlDbType.Bit, 0)
                pDen_Close_915.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDen_Close_915)

                Dim pId_E1_915_Di As SqlParameter = New SqlParameter("@Id_E1_915_Di", SqlDbType.VarChar, 48)
                pId_E1_915_Di.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_E1_915_Di)

                Dim pNgay_Di_915 As SqlParameter = New SqlParameter("@Ngay_Di_915", SqlDbType.Int, 0)
                pNgay_Di_915.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Di_915)

                Dim pGio_Di_915 As SqlParameter = New SqlParameter("@Gio_Di_915", SqlDbType.Int, 0)
                pGio_Di_915.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Di_915)

                Dim pIs_Close As SqlParameter = New SqlParameter("@Is_Close", SqlDbType.Bit, 0)
                pIs_Close.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pIs_Close)

                Dim pKieu_Huong_Di As SqlParameter = New SqlParameter("@Kieu_Huong_Di", SqlDbType.VarChar, 1)
                pKieu_Huong_Di.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pKieu_Huong_Di)

                Dim pNgay_Kiem_Hoa As SqlParameter = New SqlParameter("@Ngay_Kiem_Hoa", SqlDbType.Int, 0)
                pNgay_Kiem_Hoa.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Kiem_Hoa)

                Dim pGio_Kiem_Hoa As SqlParameter = New SqlParameter("@Gio_Kiem_Hoa", SqlDbType.Int, 0)
                pGio_Kiem_Hoa.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Kiem_Hoa)

                Dim pNgay_Roi_HQ As SqlParameter = New SqlParameter("@Ngay_Roi_HQ", SqlDbType.Int, 0)
                pNgay_Roi_HQ.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Roi_HQ)

                Dim pGio_Roi_HQ As SqlParameter = New SqlParameter("@Gio_Roi_HQ", SqlDbType.Int, 0)
                pGio_Roi_HQ.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Roi_HQ)

                Dim pMa_Bc_Roi_HQ As SqlParameter = New SqlParameter("@Ma_Bc_Roi_HQ", SqlDbType.Int, 0)
                pMa_Bc_Roi_HQ.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc_Roi_HQ)

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
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Id_Chi_Tiet = Id_Chi_Tiet
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Ma_E1 = pMa_E1.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Nuoc_Nhan = pNuoc_Nhan.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Phan_Loai = pPhan_Loai.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Khoi_Luong = pKhoi_Luong.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Ngay_Dong_914 = pNgay_Dong_914.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Id_E1_914_Den = pId_E1_914_Den.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Ngay_Den_914 = pNgay_Den_914.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Gio_Den_914 = pGio_Den_914.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Den_Close_914 = pDen_Close_914.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Id_E1_914_Di = pId_E1_914_Di.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Ngay_Di_914 = pNgay_Di_914.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Gio_Di_914 = pGio_Di_914.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Di_Close_914 = pDi_Close_914.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Id_E1_907_Den = pId_E1_907_Den.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Ngay_Den_907 = pNgay_Den_907.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Gio_Den_907 = pGio_Den_907.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Den_Close_907 = pDen_Close_907.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Id_E1_907_Di = pId_E1_907_Di.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Ngay_Di_907 = pNgay_Di_907.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Gio_Di_907 = pGio_Di_907.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Di_Close_907 = pDi_Close_907.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Id_E1_917_Den = pId_E1_917_Den.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Ngay_Den_917 = pNgay_Den_917.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Gio_Den_917 = pGio_Den_917.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Den_Close_917 = pDen_Close_917.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Id_E1_917_Di = pId_E1_917_Di.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Ngay_Di_917 = pNgay_Di_917.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Gio_Di_917 = pGio_Di_917.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Di_Close_917 = pDi_Close_917.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Id_E1_927_Den = pId_E1_927_Den.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Ngay_Den_927 = pNgay_Den_927.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Gio_Den_927 = pGio_Den_927.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Den_Close_927 = pDen_Close_927.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Id_E1_927_Di = pId_E1_927_Di.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Ngay_Di_927 = pNgay_Di_927.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Gio_Di_927 = pGio_Di_927.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Di_Close_927 = pDi_Close_927.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Id_E1_937_Den = pId_E1_937_Den.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Ngay_Den_937 = pNgay_Den_937.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Gio_Den_937 = pGio_Den_937.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Den_Close_937 = pDen_Close_937.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Id_E1_937_Di = pId_E1_937_Di.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Ngay_Di_937 = pNgay_Di_937.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Gio_Di_937 = pGio_Di_937.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Di_Close_937 = pDi_Close_937.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Id_E1_915_Den = pId_E1_915_Den.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Ngay_Den_915 = pNgay_Den_915.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Gio_Den_915 = pGio_Den_915.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Den_Close_915 = pDen_Close_915.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Id_E1_915_Di = pId_E1_915_Di.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Ngay_Di_915 = pNgay_Di_915.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Gio_Di_915 = pGio_Di_915.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Is_Close = pIs_Close.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Kieu_Huong_Di = pKieu_Huong_Di.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Ngay_Kiem_Hoa = pNgay_Kiem_Hoa.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Gio_Kiem_Hoa = pGio_Kiem_Hoa.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Ngay_Roi_HQ = pNgay_Roi_HQ.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Gio_Roi_HQ = pGio_Roi_HQ.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Ma_Bc_Roi_HQ = pMa_Bc_Roi_HQ.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet.Gio_He_Thong = pGio_He_Thong.Value

                Return myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet
                'Return myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet

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

#Region "Huong_Di_Buu_Pham_Quoc_Te_Den_Them"
        Public Function Huong_Di_Buu_Pham_Quoc_Te_Den_Them(ByVal Id_Chi_Tiet As String, ByVal Ma_E1 As String, ByVal Nuoc_Nhan As String, ByVal Phan_Loai As String, ByVal Khoi_Luong As Integer, ByVal Ngay_Dong_914 As Integer, ByVal Id_E1_914_Den As String, ByVal Ngay_Den_914 As Integer, ByVal Gio_Den_914 As Integer, ByVal Den_Close_914 As Boolean, ByVal Id_E1_914_Di As String, ByVal Ngay_Di_914 As Integer, ByVal Gio_Di_914 As Integer, ByVal Di_Close_914 As Boolean, ByVal Id_E1_907_Den As String, ByVal Ngay_Den_907 As Integer, ByVal Gio_Den_907 As Integer, ByVal Den_Close_907 As Boolean, ByVal Id_E1_907_Di As String, ByVal Ngay_Di_907 As Integer, ByVal Gio_Di_907 As Integer, ByVal Di_Close_907 As Boolean, ByVal Id_E1_917_Den As String, ByVal Ngay_Den_917 As Integer, ByVal Gio_Den_917 As Integer, ByVal Den_Close_917 As Boolean, ByVal Id_E1_917_Di As String, ByVal Ngay_Di_917 As Integer, ByVal Gio_Di_917 As Integer, ByVal Di_Close_917 As Boolean, ByVal Id_E1_927_Den As String, ByVal Ngay_Den_927 As Integer, ByVal Gio_Den_927 As Integer, ByVal Den_Close_927 As Boolean, ByVal Id_E1_927_Di As String, ByVal Ngay_Di_927 As Integer, ByVal Gio_Di_927 As Integer, ByVal Di_Close_927 As Boolean, ByVal Id_E1_937_Den As String, ByVal Ngay_Den_937 As Integer, ByVal Gio_Den_937 As Integer, ByVal Den_Close_937 As Boolean, ByVal Id_E1_937_Di As String, ByVal Ngay_Di_937 As Integer, ByVal Gio_Di_937 As Integer, ByVal Di_Close_937 As Boolean, ByVal Id_E1_915_Den As String, ByVal Ngay_Den_915 As Integer, ByVal Gio_Den_915 As Integer, ByVal Den_Close_915 As Boolean, ByVal Id_E1_915_Di As String, ByVal Ngay_Di_915 As Integer, ByVal Gio_Di_915 As Integer, ByVal Is_Close As Boolean, ByVal Kieu_Huong_Di As String, ByVal Ngay_Kiem_Hoa As Integer, ByVal Gio_Kiem_Hoa As Integer, ByVal Ngay_Roi_HQ As Integer, ByVal Gio_Roi_HQ As Integer, ByVal Ma_Bc_Roi_HQ As Integer, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Huong_Di_Buu_Pham_Quoc_Te_Den_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet As New Huong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Chi_Tiet As SqlParameter = New SqlParameter("@Id_Chi_Tiet", SqlDbType.VarChar, 30)
                pId_Chi_Tiet.Value = Id_Chi_Tiet
                MyCommand.Parameters.Add(pId_Chi_Tiet)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                MyCommand.Parameters.Add(pMa_E1)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Value = Nuoc_Nhan
                MyCommand.Parameters.Add(pNuoc_Nhan)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.VarChar, 1)
                pPhan_Loai.Value = Phan_Loai
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 0)
                pKhoi_Luong.Value = Khoi_Luong
                MyCommand.Parameters.Add(pKhoi_Luong)

                Dim pNgay_Dong_914 As SqlParameter = New SqlParameter("@Ngay_Dong_914", SqlDbType.Int, 0)
                pNgay_Dong_914.Value = Ngay_Dong_914
                MyCommand.Parameters.Add(pNgay_Dong_914)

                Dim pId_E1_914_Den As SqlParameter = New SqlParameter("@Id_E1_914_Den", SqlDbType.VarChar, 48)
                pId_E1_914_Den.Value = Id_E1_914_Den
                MyCommand.Parameters.Add(pId_E1_914_Den)

                Dim pNgay_Den_914 As SqlParameter = New SqlParameter("@Ngay_Den_914", SqlDbType.Int, 0)
                pNgay_Den_914.Value = Ngay_Den_914
                MyCommand.Parameters.Add(pNgay_Den_914)

                Dim pGio_Den_914 As SqlParameter = New SqlParameter("@Gio_Den_914", SqlDbType.Int, 0)
                pGio_Den_914.Value = Gio_Den_914
                MyCommand.Parameters.Add(pGio_Den_914)

                Dim pDen_Close_914 As SqlParameter = New SqlParameter("@Den_Close_914", SqlDbType.Bit, 0)
                pDen_Close_914.Value = Den_Close_914
                MyCommand.Parameters.Add(pDen_Close_914)

                Dim pId_E1_914_Di As SqlParameter = New SqlParameter("@Id_E1_914_Di", SqlDbType.VarChar, 48)
                pId_E1_914_Di.Value = Id_E1_914_Di
                MyCommand.Parameters.Add(pId_E1_914_Di)

                Dim pNgay_Di_914 As SqlParameter = New SqlParameter("@Ngay_Di_914", SqlDbType.Int, 0)
                pNgay_Di_914.Value = Ngay_Di_914
                MyCommand.Parameters.Add(pNgay_Di_914)

                Dim pGio_Di_914 As SqlParameter = New SqlParameter("@Gio_Di_914", SqlDbType.Int, 0)
                pGio_Di_914.Value = Gio_Di_914
                MyCommand.Parameters.Add(pGio_Di_914)

                Dim pDi_Close_914 As SqlParameter = New SqlParameter("@Di_Close_914", SqlDbType.Bit, 0)
                pDi_Close_914.Value = Di_Close_914
                MyCommand.Parameters.Add(pDi_Close_914)

                Dim pId_E1_907_Den As SqlParameter = New SqlParameter("@Id_E1_907_Den", SqlDbType.VarChar, 48)
                pId_E1_907_Den.Value = Id_E1_907_Den
                MyCommand.Parameters.Add(pId_E1_907_Den)

                Dim pNgay_Den_907 As SqlParameter = New SqlParameter("@Ngay_Den_907", SqlDbType.Int, 0)
                pNgay_Den_907.Value = Ngay_Den_907
                MyCommand.Parameters.Add(pNgay_Den_907)

                Dim pGio_Den_907 As SqlParameter = New SqlParameter("@Gio_Den_907", SqlDbType.Int, 0)
                pGio_Den_907.Value = Gio_Den_907
                MyCommand.Parameters.Add(pGio_Den_907)

                Dim pDen_Close_907 As SqlParameter = New SqlParameter("@Den_Close_907", SqlDbType.Bit, 0)
                pDen_Close_907.Value = Den_Close_907
                MyCommand.Parameters.Add(pDen_Close_907)

                Dim pId_E1_907_Di As SqlParameter = New SqlParameter("@Id_E1_907_Di", SqlDbType.VarChar, 48)
                pId_E1_907_Di.Value = Id_E1_907_Di
                MyCommand.Parameters.Add(pId_E1_907_Di)

                Dim pNgay_Di_907 As SqlParameter = New SqlParameter("@Ngay_Di_907", SqlDbType.Int, 0)
                pNgay_Di_907.Value = Ngay_Di_907
                MyCommand.Parameters.Add(pNgay_Di_907)

                Dim pGio_Di_907 As SqlParameter = New SqlParameter("@Gio_Di_907", SqlDbType.Int, 0)
                pGio_Di_907.Value = Gio_Di_907
                MyCommand.Parameters.Add(pGio_Di_907)

                Dim pDi_Close_907 As SqlParameter = New SqlParameter("@Di_Close_907", SqlDbType.Bit, 0)
                pDi_Close_907.Value = Di_Close_907
                MyCommand.Parameters.Add(pDi_Close_907)

                Dim pId_E1_917_Den As SqlParameter = New SqlParameter("@Id_E1_917_Den", SqlDbType.VarChar, 48)
                pId_E1_917_Den.Value = Id_E1_917_Den
                MyCommand.Parameters.Add(pId_E1_917_Den)

                Dim pNgay_Den_917 As SqlParameter = New SqlParameter("@Ngay_Den_917", SqlDbType.Int, 0)
                pNgay_Den_917.Value = Ngay_Den_917
                MyCommand.Parameters.Add(pNgay_Den_917)

                Dim pGio_Den_917 As SqlParameter = New SqlParameter("@Gio_Den_917", SqlDbType.Int, 0)
                pGio_Den_917.Value = Gio_Den_917
                MyCommand.Parameters.Add(pGio_Den_917)

                Dim pDen_Close_917 As SqlParameter = New SqlParameter("@Den_Close_917", SqlDbType.Bit, 0)
                pDen_Close_917.Value = Den_Close_917
                MyCommand.Parameters.Add(pDen_Close_917)

                Dim pId_E1_917_Di As SqlParameter = New SqlParameter("@Id_E1_917_Di", SqlDbType.VarChar, 48)
                pId_E1_917_Di.Value = Id_E1_917_Di
                MyCommand.Parameters.Add(pId_E1_917_Di)

                Dim pNgay_Di_917 As SqlParameter = New SqlParameter("@Ngay_Di_917", SqlDbType.Int, 0)
                pNgay_Di_917.Value = Ngay_Di_917
                MyCommand.Parameters.Add(pNgay_Di_917)

                Dim pGio_Di_917 As SqlParameter = New SqlParameter("@Gio_Di_917", SqlDbType.Int, 0)
                pGio_Di_917.Value = Gio_Di_917
                MyCommand.Parameters.Add(pGio_Di_917)

                Dim pDi_Close_917 As SqlParameter = New SqlParameter("@Di_Close_917", SqlDbType.Bit, 0)
                pDi_Close_917.Value = Di_Close_917
                MyCommand.Parameters.Add(pDi_Close_917)

                Dim pId_E1_927_Den As SqlParameter = New SqlParameter("@Id_E1_927_Den", SqlDbType.VarChar, 48)
                pId_E1_927_Den.Value = Id_E1_927_Den
                MyCommand.Parameters.Add(pId_E1_927_Den)

                Dim pNgay_Den_927 As SqlParameter = New SqlParameter("@Ngay_Den_927", SqlDbType.Int, 0)
                pNgay_Den_927.Value = Ngay_Den_927
                MyCommand.Parameters.Add(pNgay_Den_927)

                Dim pGio_Den_927 As SqlParameter = New SqlParameter("@Gio_Den_927", SqlDbType.Int, 0)
                pGio_Den_927.Value = Gio_Den_927
                MyCommand.Parameters.Add(pGio_Den_927)

                Dim pDen_Close_927 As SqlParameter = New SqlParameter("@Den_Close_927", SqlDbType.Bit, 0)
                pDen_Close_927.Value = Den_Close_927
                MyCommand.Parameters.Add(pDen_Close_927)

                Dim pId_E1_927_Di As SqlParameter = New SqlParameter("@Id_E1_927_Di", SqlDbType.VarChar, 48)
                pId_E1_927_Di.Value = Id_E1_927_Di
                MyCommand.Parameters.Add(pId_E1_927_Di)

                Dim pNgay_Di_927 As SqlParameter = New SqlParameter("@Ngay_Di_927", SqlDbType.Int, 0)
                pNgay_Di_927.Value = Ngay_Di_927
                MyCommand.Parameters.Add(pNgay_Di_927)

                Dim pGio_Di_927 As SqlParameter = New SqlParameter("@Gio_Di_927", SqlDbType.Int, 0)
                pGio_Di_927.Value = Gio_Di_927
                MyCommand.Parameters.Add(pGio_Di_927)

                Dim pDi_Close_927 As SqlParameter = New SqlParameter("@Di_Close_927", SqlDbType.Bit, 0)
                pDi_Close_927.Value = Di_Close_927
                MyCommand.Parameters.Add(pDi_Close_927)

                Dim pId_E1_937_Den As SqlParameter = New SqlParameter("@Id_E1_937_Den", SqlDbType.VarChar, 48)
                pId_E1_937_Den.Value = Id_E1_937_Den
                MyCommand.Parameters.Add(pId_E1_937_Den)

                Dim pNgay_Den_937 As SqlParameter = New SqlParameter("@Ngay_Den_937", SqlDbType.Int, 0)
                pNgay_Den_937.Value = Ngay_Den_937
                MyCommand.Parameters.Add(pNgay_Den_937)

                Dim pGio_Den_937 As SqlParameter = New SqlParameter("@Gio_Den_937", SqlDbType.Int, 0)
                pGio_Den_937.Value = Gio_Den_937
                MyCommand.Parameters.Add(pGio_Den_937)

                Dim pDen_Close_937 As SqlParameter = New SqlParameter("@Den_Close_937", SqlDbType.Bit, 0)
                pDen_Close_937.Value = Den_Close_937
                MyCommand.Parameters.Add(pDen_Close_937)

                Dim pId_E1_937_Di As SqlParameter = New SqlParameter("@Id_E1_937_Di", SqlDbType.VarChar, 48)
                pId_E1_937_Di.Value = Id_E1_937_Di
                MyCommand.Parameters.Add(pId_E1_937_Di)

                Dim pNgay_Di_937 As SqlParameter = New SqlParameter("@Ngay_Di_937", SqlDbType.Int, 0)
                pNgay_Di_937.Value = Ngay_Di_937
                MyCommand.Parameters.Add(pNgay_Di_937)

                Dim pGio_Di_937 As SqlParameter = New SqlParameter("@Gio_Di_937", SqlDbType.Int, 0)
                pGio_Di_937.Value = Gio_Di_937
                MyCommand.Parameters.Add(pGio_Di_937)

                Dim pDi_Close_937 As SqlParameter = New SqlParameter("@Di_Close_937", SqlDbType.Bit, 0)
                pDi_Close_937.Value = Di_Close_937
                MyCommand.Parameters.Add(pDi_Close_937)

                Dim pId_E1_915_Den As SqlParameter = New SqlParameter("@Id_E1_915_Den", SqlDbType.VarChar, 48)
                pId_E1_915_Den.Value = Id_E1_915_Den
                MyCommand.Parameters.Add(pId_E1_915_Den)

                Dim pNgay_Den_915 As SqlParameter = New SqlParameter("@Ngay_Den_915", SqlDbType.Int, 0)
                pNgay_Den_915.Value = Ngay_Den_915
                MyCommand.Parameters.Add(pNgay_Den_915)

                Dim pGio_Den_915 As SqlParameter = New SqlParameter("@Gio_Den_915", SqlDbType.Int, 0)
                pGio_Den_915.Value = Gio_Den_915
                MyCommand.Parameters.Add(pGio_Den_915)

                Dim pDen_Close_915 As SqlParameter = New SqlParameter("@Den_Close_915", SqlDbType.Bit, 0)
                pDen_Close_915.Value = Den_Close_915
                MyCommand.Parameters.Add(pDen_Close_915)

                Dim pId_E1_915_Di As SqlParameter = New SqlParameter("@Id_E1_915_Di", SqlDbType.VarChar, 48)
                pId_E1_915_Di.Value = Id_E1_915_Di
                MyCommand.Parameters.Add(pId_E1_915_Di)

                Dim pNgay_Di_915 As SqlParameter = New SqlParameter("@Ngay_Di_915", SqlDbType.Int, 0)
                pNgay_Di_915.Value = Ngay_Di_915
                MyCommand.Parameters.Add(pNgay_Di_915)

                Dim pGio_Di_915 As SqlParameter = New SqlParameter("@Gio_Di_915", SqlDbType.Int, 0)
                pGio_Di_915.Value = Gio_Di_915
                MyCommand.Parameters.Add(pGio_Di_915)

                Dim pIs_Close As SqlParameter = New SqlParameter("@Is_Close", SqlDbType.Bit, 0)
                pIs_Close.Value = Is_Close
                MyCommand.Parameters.Add(pIs_Close)

                Dim pKieu_Huong_Di As SqlParameter = New SqlParameter("@Kieu_Huong_Di", SqlDbType.VarChar, 1)
                pKieu_Huong_Di.Value = Kieu_Huong_Di
                MyCommand.Parameters.Add(pKieu_Huong_Di)

                Dim pNgay_Kiem_Hoa As SqlParameter = New SqlParameter("@Ngay_Kiem_Hoa", SqlDbType.Int, 0)
                pNgay_Kiem_Hoa.Value = Ngay_Kiem_Hoa
                MyCommand.Parameters.Add(pNgay_Kiem_Hoa)

                Dim pGio_Kiem_Hoa As SqlParameter = New SqlParameter("@Gio_Kiem_Hoa", SqlDbType.Int, 0)
                pGio_Kiem_Hoa.Value = Gio_Kiem_Hoa
                MyCommand.Parameters.Add(pGio_Kiem_Hoa)

                Dim pNgay_Roi_HQ As SqlParameter = New SqlParameter("@Ngay_Roi_HQ", SqlDbType.Int, 0)
                pNgay_Roi_HQ.Value = Ngay_Roi_HQ
                MyCommand.Parameters.Add(pNgay_Roi_HQ)

                Dim pGio_Roi_HQ As SqlParameter = New SqlParameter("@Gio_Roi_HQ", SqlDbType.Int, 0)
                pGio_Roi_HQ.Value = Gio_Roi_HQ
                MyCommand.Parameters.Add(pGio_Roi_HQ)

                Dim pMa_Bc_Roi_HQ As SqlParameter = New SqlParameter("@Ma_Bc_Roi_HQ", SqlDbType.Int, 0)
                pMa_Bc_Roi_HQ.Value = Ma_Bc_Roi_HQ
                MyCommand.Parameters.Add(pMa_Bc_Roi_HQ)

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

#Region "Huong_Di_Buu_Pham_Quoc_Te_Den_Xoa"
        Public Function Huong_Di_Buu_Pham_Quoc_Te_Den_Xoa(ByVal Id_Chi_Tiet As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Huong_Di_Buu_Pham_Quoc_Te_Den_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myHuong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet As New Huong_Di_Buu_Pham_Quoc_Te_Den_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Chi_Tiet As SqlParameter = New SqlParameter("@Id_Chi_Tiet", SqlDbType.VarChar, 30)
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

#Region "----------báo cáo qu?n lý kho h?i quan----------"
#Region "Huong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Tong_Hop_Ton_Toan_Bo_Kho_HQ"
        Public Function Huong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Tong_Hop_Ton_Toan_Bo_Kho_HQ(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer) As Huong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ton_Kho_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Huong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Tong_Hop_Ton_Toan_Bo_Kho_HQ"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myHuong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ton_Kho_Chi_Tiet As New Huong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ton_Kho_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0)
                pTu_Ngay.Value = Tu_Ngay
                MyCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 0)
                pDen_Ngay.Value = Den_Ngay
                MyCommand.Parameters.Add(pDen_Ngay)

                Dim pM_Phan_Loai As SqlParameter = New SqlParameter("@M_Phan_Loai", SqlDbType.VarChar, 1)
                pM_Phan_Loai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pM_Phan_Loai)

                Dim pD_Phan_Loai As SqlParameter = New SqlParameter("@D_Phan_Loai", SqlDbType.VarChar, 1)
                pD_Phan_Loai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pD_Phan_Loai)

                Dim pM_Ton_Dau_Ky As SqlParameter = New SqlParameter("@M_Ton_Dau_Ky", SqlDbType.Int, 0)
                pM_Ton_Dau_Ky.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pM_Ton_Dau_Ky)

                Dim pD_Ton_Dau_Ky As SqlParameter = New SqlParameter("@D_Ton_Dau_Ky", SqlDbType.Int, 0)
                pD_Ton_Dau_Ky.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pD_Ton_Dau_Ky)

                Dim pM_Tong_So_Den As SqlParameter = New SqlParameter("@M_Tong_So_Den", SqlDbType.Int, 0)
                pM_Tong_So_Den.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pM_Tong_So_Den)

                Dim pD_Tong_So_Den As SqlParameter = New SqlParameter("@D_Tong_So_Den", SqlDbType.Int, 0)
                pD_Tong_So_Den.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pD_Tong_So_Den)

                Dim pM_Tong_So_Di As SqlParameter = New SqlParameter("@M_Tong_So_Di", SqlDbType.Int, 0)
                pM_Tong_So_Di.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pM_Tong_So_Di)

                Dim pD_Tong_So_Di As SqlParameter = New SqlParameter("@D_Tong_So_Di", SqlDbType.Int, 0)
                pD_Tong_So_Di.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pD_Tong_So_Di)

                Dim pM_Ton_Cuoi_Ky As SqlParameter = New SqlParameter("@M_Ton_Cuoi_Ky", SqlDbType.Int, 0)
                pM_Ton_Cuoi_Ky.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pM_Ton_Cuoi_Ky)

                Dim pD_Ton_Cuoi_Ky As SqlParameter = New SqlParameter("@D_Ton_Cuoi_Ky", SqlDbType.Int, 0)
                pD_Ton_Cuoi_Ky.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pD_Ton_Cuoi_Ky)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values                
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ton_Kho_Chi_Tiet.M_Phan_Loai = pM_Phan_Loai.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ton_Kho_Chi_Tiet.D_Phan_Loai = pD_Phan_Loai.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ton_Kho_Chi_Tiet.M_Ton_Dau_Ky = pM_Ton_Dau_Ky.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ton_Kho_Chi_Tiet.D_Ton_Dau_Ky = pD_Ton_Dau_Ky.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ton_Kho_Chi_Tiet.M_Tong_So_Den = pM_Tong_So_Den.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ton_Kho_Chi_Tiet.D_Tong_So_Den = pD_Tong_So_Den.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ton_Kho_Chi_Tiet.M_Tong_So_Di = pM_Tong_So_Di.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ton_Kho_Chi_Tiet.D_Tong_So_Di = pD_Tong_So_Di.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ton_Kho_Chi_Tiet.M_Ton_Cuoi_Ky = pM_Ton_Cuoi_Ky.Value
                myHuong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ton_Kho_Chi_Tiet.D_Ton_Cuoi_Ky = pD_Ton_Cuoi_Ky.Value

                Return myHuong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ton_Kho_Chi_Tiet
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

#Region "Huong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ty_Le_Kiem_Quan_Hang_Phi_MD"

        Public Function Huong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ty_Le_Kiem_Quan_Hang_Phi_MD(ByVal Kieu_So_Sanh As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal So_Ngay_Yeu_Cau As Integer) As DataSet

            ' The procedure returns these columns:
            ' Phan_Loai
            ' Tong_So_Den
            ' Tong_So_BP_Phi_MD
            ' Tong_So_Kiem_Hoa


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Huong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ty_Le_Kiem_Quan_Hang_Phi_MD"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pKieu_So_Sanh As SqlParameter = New SqlParameter("@Kieu_So_Sanh", SqlDbType.Int, 0)
                pKieu_So_Sanh.Value = Kieu_So_Sanh
                MyCommand.Parameters.Add(pKieu_So_Sanh)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0)
                pTu_Ngay.Value = Tu_Ngay
                MyCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 0)
                pDen_Ngay.Value = Den_Ngay
                MyCommand.Parameters.Add(pDen_Ngay)

                Dim pSo_Ngay_Yeu_Cau As SqlParameter = New SqlParameter("@So_Ngay_Yeu_Cau", SqlDbType.Int, 0)
                pSo_Ngay_Yeu_Cau.Value = So_Ngay_Yeu_Cau
                MyCommand.Parameters.Add(pSo_Ngay_Yeu_Cau)


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

#Region "Huong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ty_Le_Mo_To_Khai_Chua_Thong_Quan"

        Public Function Huong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ty_Le_Mo_To_Khai_Chua_Thong_Quan(ByVal Kieu_So_Sanh As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal So_Ngay_Yeu_Cau As Integer) As DataSet

            ' The procedure returns these columns:
            ' Phan_Loai
            ' Tong_So_Den
            ' Tong_So_BP_Phi_MD
            ' Tong_So_Kiem_Hoa
            ' Tong_So_Chua_Thong_Quan


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Huong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ty_Le_Mo_To_Khai_Chua_Thong_Quan"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pKieu_So_Sanh As SqlParameter = New SqlParameter("@Kieu_So_Sanh", SqlDbType.Int, 0)
                pKieu_So_Sanh.Value = Kieu_So_Sanh
                MyCommand.Parameters.Add(pKieu_So_Sanh)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0)
                pTu_Ngay.Value = Tu_Ngay
                MyCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 0)
                pDen_Ngay.Value = Den_Ngay
                MyCommand.Parameters.Add(pDen_Ngay)

                Dim pSo_Ngay_Yeu_Cau As SqlParameter = New SqlParameter("@So_Ngay_Yeu_Cau", SqlDbType.Int, 0)
                pSo_Ngay_Yeu_Cau.Value = So_Ngay_Yeu_Cau
                MyCommand.Parameters.Add(pSo_Ngay_Yeu_Cau)


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

#Region "Huong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ty_Le_Thong_Quan"

        Public Function Huong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ty_Le_Thong_Quan(ByVal Kieu_So_Sanh As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal So_Ngay_Yeu_Cau As Integer) As DataSet

            ' The procedure returns these columns:
            ' Phan_Loai
            ' Tong_So_Den
            ' Tong_So_Roi_HQ
            ' Tong_So_Qua_Giang


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Huong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ty_Le_Thong_Quan"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pKieu_So_Sanh As SqlParameter = New SqlParameter("@Kieu_So_Sanh", SqlDbType.Int, 0)
                pKieu_So_Sanh.Value = Kieu_So_Sanh
                MyCommand.Parameters.Add(pKieu_So_Sanh)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0)
                pTu_Ngay.Value = Tu_Ngay
                MyCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 0)
                pDen_Ngay.Value = Den_Ngay
                MyCommand.Parameters.Add(pDen_Ngay)

                Dim pSo_Ngay_Yeu_Cau As SqlParameter = New SqlParameter("@So_Ngay_Yeu_Cau", SqlDbType.Int, 0)
                pSo_Ngay_Yeu_Cau.Value = So_Ngay_Yeu_Cau
                MyCommand.Parameters.Add(pSo_Ngay_Yeu_Cau)


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

#End Region

#Region "Báo cáo danh sách chi tiết"

#Region "Huong_Di_Buu_Pham_Quoc_Te_Den_Danh_Sach_Chua_Thong_Quan_Trong_Khoang_Ngay_Yeu_Cau"

        Public Function Huong_Di_Buu_Pham_Quoc_Te_Den_Danh_Sach_Chua_Thong_Quan_Trong_Khoang_Ngay_Yeu_Cau(ByVal Kieu_So_Sanh As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal So_Ngay_Yeu_Cau As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ma_E1
            ' Ma_Nuoc
            ' Phan_Loai
            ' Khoi_Luong
            ' Ngay_Dong
            ' Ten_Duong_Thu_XND
            ' Ngay_XND
            ' Gio_XND
            ' Ngay_Roi_HQ
            ' Gio_Roi_HQ


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Huong_Di_Buu_Pham_Quoc_Te_Den_Danh_Sach_Chua_Thong_Quan_Trong_Khoang_Ngay_Yeu_Cau"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pKieu_So_Sanh As SqlParameter = New SqlParameter("@Kieu_So_Sanh", SqlDbType.Int, 0)
                pKieu_So_Sanh.Value = Kieu_So_Sanh
                MyCommand.Parameters.Add(pKieu_So_Sanh)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0)
                pTu_Ngay.Value = Tu_Ngay
                MyCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 0)
                pDen_Ngay.Value = Den_Ngay
                MyCommand.Parameters.Add(pDen_Ngay)

                Dim pSo_Ngay_Yeu_Cau As SqlParameter = New SqlParameter("@So_Ngay_Yeu_Cau", SqlDbType.Int, 0)
                pSo_Ngay_Yeu_Cau.Value = So_Ngay_Yeu_Cau
                MyCommand.Parameters.Add(pSo_Ngay_Yeu_Cau)


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


#Region "Huong_Di_Buu_Pham_Quoc_Te_Den_Danh_Sach_Mo_To_Khai_Chua_Kiem_Quan_Trong_Khoang_Ngay_Yeu_Cau"

        Public Function Huong_Di_Buu_Pham_Quoc_Te_Den_Danh_Sach_Mo_To_Khai_Chua_Kiem_Quan_Trong_Khoang_Ngay_Yeu_Cau(ByVal Kieu_So_Sanh As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal So_Ngay_Yeu_Cau As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ma_E1
            ' Ma_Nuoc
            ' Phan_Loai
            ' Khoi_Luong
            ' Ngay_Dong
            ' Ten_Duong_Thu_XND
            ' Ngay_XND
            ' Gio_XND
            ' Ngay_Roi_HQ
            ' Gio_Roi_HQ


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Huong_Di_Buu_Pham_Quoc_Te_Den_Danh_Sach_Mo_To_Khai_Chua_Kiem_Quan_Trong_Khoang_Ngay_Yeu_Cau"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pKieu_So_Sanh As SqlParameter = New SqlParameter("@Kieu_So_Sanh", SqlDbType.Int, 0)
                pKieu_So_Sanh.Value = Kieu_So_Sanh
                MyCommand.Parameters.Add(pKieu_So_Sanh)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0)
                pTu_Ngay.Value = Tu_Ngay
                MyCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 0)
                pDen_Ngay.Value = Den_Ngay
                MyCommand.Parameters.Add(pDen_Ngay)

                Dim pSo_Ngay_Yeu_Cau As SqlParameter = New SqlParameter("@So_Ngay_Yeu_Cau", SqlDbType.Int, 0)
                pSo_Ngay_Yeu_Cau.Value = So_Ngay_Yeu_Cau
                MyCommand.Parameters.Add(pSo_Ngay_Yeu_Cau)


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


#Region "Huong_Di_Buu_Pham_Quoc_Te_Den_Danh_Sach_Mo_To_Khai_Chua_Thong_Quan_Trong_Khoang_Ngay_Yeu_Cau"

        Public Function Huong_Di_Buu_Pham_Quoc_Te_Den_Danh_Sach_Mo_To_Khai_Chua_Thong_Quan_Trong_Khoang_Ngay_Yeu_Cau(ByVal Kieu_So_Sanh As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal So_Ngay_Yeu_Cau As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ma_E1
            ' Ma_Nuoc
            ' Phan_Loai
            ' Khoi_Luong
            ' Ngay_Dong
            ' Ten_Duong_Thu_XND
            ' Ngay_XND
            ' Gio_XND
            ' Ngay_Roi_HQ
            ' Gio_Roi_HQ


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Huong_Di_Buu_Pham_Quoc_Te_Den_Danh_Sach_Mo_To_Khai_Chua_Thong_Quan_Trong_Khoang_Ngay_Yeu_Cau"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pKieu_So_Sanh As SqlParameter = New SqlParameter("@Kieu_So_Sanh", SqlDbType.Int, 0)
                pKieu_So_Sanh.Value = Kieu_So_Sanh
                MyCommand.Parameters.Add(pKieu_So_Sanh)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0)
                pTu_Ngay.Value = Tu_Ngay
                MyCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 0)
                pDen_Ngay.Value = Den_Ngay
                MyCommand.Parameters.Add(pDen_Ngay)

                Dim pSo_Ngay_Yeu_Cau As SqlParameter = New SqlParameter("@So_Ngay_Yeu_Cau", SqlDbType.Int, 0)
                pSo_Ngay_Yeu_Cau.Value = So_Ngay_Yeu_Cau
                MyCommand.Parameters.Add(pSo_Ngay_Yeu_Cau)


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


#Region "Huong_Di_Buu_Pham_Quoc_Te_Den_Danh_Sach_Soi_May_Chua_Kiem_Quan_Trong_Khoang_Ngay_Yeu_Cau"

        Public Function Huong_Di_Buu_Pham_Quoc_Te_Den_Danh_Sach_Soi_May_Chua_Kiem_Quan_Trong_Khoang_Ngay_Yeu_Cau(ByVal Kieu_So_Sanh As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal So_Ngay_Yeu_Cau As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ma_E1
            ' Ma_Nuoc
            ' Phan_Loai
            ' Khoi_Luong
            ' Ngay_Dong
            ' Ten_Duong_Thu_XND
            ' Ngay_XND
            ' Gio_XND
            ' Ngay_Roi_HQ
            ' Gio_Roi_HQ


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Huong_Di_Buu_Pham_Quoc_Te_Den_Danh_Sach_Soi_May_Chua_Kiem_Quan_Trong_Khoang_Ngay_Yeu_Cau"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pKieu_So_Sanh As SqlParameter = New SqlParameter("@Kieu_So_Sanh", SqlDbType.Int, 0)
                pKieu_So_Sanh.Value = Kieu_So_Sanh
                MyCommand.Parameters.Add(pKieu_So_Sanh)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0)
                pTu_Ngay.Value = Tu_Ngay
                MyCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 0)
                pDen_Ngay.Value = Den_Ngay
                MyCommand.Parameters.Add(pDen_Ngay)

                Dim pSo_Ngay_Yeu_Cau As SqlParameter = New SqlParameter("@So_Ngay_Yeu_Cau", SqlDbType.Int, 0)
                pSo_Ngay_Yeu_Cau.Value = So_Ngay_Yeu_Cau
                MyCommand.Parameters.Add(pSo_Ngay_Yeu_Cau)


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

#End Region

#Region "Sử dụng trong chức năng Bưu phẩm bưu kiện"
#Region "Huong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ty_Le_Thong_Quan_Buu_Pham_Buu_Kien"

        Public Function Huong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ty_Le_Thong_Quan_Buu_Pham_Buu_Kien(ByVal Kieu_So_Sanh As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal So_Ngay_Yeu_Cau As Integer, ByVal Ma_Nuoc As String) As DataSet

            ' The procedure returns these columns:
            ' Tong_SL_Den
            ' Tong_KL_Den
            ' Tong_So_Roi_HQ


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Huong_Di_Buu_Pham_Quoc_Te_Den_Bao_Cao_Ty_Le_Thong_Quan_Buu_Pham_Buu_Kien"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pKieu_So_Sanh As SqlParameter = New SqlParameter("@Kieu_So_Sanh", SqlDbType.Int, 0)
                pKieu_So_Sanh.Value = Kieu_So_Sanh
                MyCommand.Parameters.Add(pKieu_So_Sanh)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0)
                pTu_Ngay.Value = Tu_Ngay
                MyCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 0)
                pDen_Ngay.Value = Den_Ngay
                MyCommand.Parameters.Add(pDen_Ngay)

                Dim pSo_Ngay_Yeu_Cau As SqlParameter = New SqlParameter("@So_Ngay_Yeu_Cau", SqlDbType.Int, 0)
                pSo_Ngay_Yeu_Cau.Value = So_Ngay_Yeu_Cau
                MyCommand.Parameters.Add(pSo_Ngay_Yeu_Cau)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                MyCommand.Parameters.Add(pMa_Nuoc)


                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                MyCommand.CommandTimeout = 20000
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
#End Region

    End Class
#End Region
End Namespace


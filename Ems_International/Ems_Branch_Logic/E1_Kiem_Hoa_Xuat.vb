
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "E1_Kiem_Hoa_Xuat_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop E1_Kiem_Hoa_Xuat_Chi_Tiet
    'Tuong ung voi moi truong trong bang E1_Kiem_Hoa_Xuat trong co so du lieu
    '***********************************************************
    Public Class E1_Kiem_Hoa_Xuat_Chi_Tiet
        Public Id_E1 As String
        Public Id_E2 As String
        Public Id_Ca As String
        Public Ma_Bc_Khai_Thac As Integer
        Public Ma_E1 As String
        Public Nuoc_Nhan As String
        Public Nuoc_Tra As String
        Public Khoi_Luong As Integer
        Public Phan_Loai As String
        Public STT As Integer
        Public Nguoi_Gui As String
        Public Nguoi_Nhan As String
        Public Dia_Chi_Gui As String
        Public Dia_Chi_Nhan As String
        Public Dien_Thoai_Gui As String
        Public Dien_Thoai_Nhan As String
        Public Id_Nguoi_Dung As Integer
        Public Id_Trang_Thai As Integer
        Public Ghi_Chu As String
        Public Truyen_Khai_Thac As Boolean
        Public Truyen_Doi_Soat As Boolean
        Public Ngay_He_Thong As Integer
        Public Gio_He_Thong As Integer
        Public Chot_SL As Boolean
        Public Ma_To_Khai As String
        Public Ip_May_Tinh As String
        Public Ban_So As Integer
        Public Tong_Muc_Hang As Integer
        Public Tong_Tri_Gia As Double
    End Class
#End Region

#Region "E1_Kiem_Hoa_Xuat"
    Public Class E1_Kiem_Hoa_Xuat
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "E1_Kiem_Hoa_Xuat_Cap_Nhat"
        Public Function E1_Kiem_Hoa_Xuat_Cap_Nhat(ByVal Id_E1 As String, ByVal Id_E2 As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_E1 As String, ByVal Nuoc_Nhan As String, ByVal Nuoc_Tra As String, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal STT As Integer, ByVal Nguoi_Gui As String, ByVal Nguoi_Nhan As String, ByVal Dia_Chi_Gui As String, ByVal Dia_Chi_Nhan As String, ByVal Dien_Thoai_Gui As String, ByVal Dien_Thoai_Nhan As String, ByVal Id_Nguoi_Dung As Integer, ByVal Id_Trang_Thai As Integer, ByVal Ghi_Chu As String, ByVal Truyen_Khai_Thac As Boolean, ByVal Truyen_Doi_Soat As Boolean, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer, ByVal Chot_SL As Boolean, ByVal Ma_To_Khai As String, ByVal Ip_May_Tinh As String, ByVal Ban_So As Integer, ByVal Tong_Muc_Hang As Integer, ByVal Tong_Tri_Gia As Double) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Kiem_Hoa_Xuat_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myE1_Kiem_Hoa_Xuat_Chi_Tiet As New E1_Kiem_Hoa_Xuat_Chi_Tiet

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

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                MyCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                MyCommand.Parameters.Add(pMa_E1)

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

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Value = STT
                MyCommand.Parameters.Add(pSTT)

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

                Dim pDien_Thoai_Gui As SqlParameter = New SqlParameter("@Dien_Thoai_Gui", SqlDbType.VarChar, 50)
                pDien_Thoai_Gui.Value = Dien_Thoai_Gui
                MyCommand.Parameters.Add(pDien_Thoai_Gui)

                Dim pDien_Thoai_Nhan As SqlParameter = New SqlParameter("@Dien_Thoai_Nhan", SqlDbType.VarChar, 50)
                pDien_Thoai_Nhan.Value = Dien_Thoai_Nhan
                MyCommand.Parameters.Add(pDien_Thoai_Nhan)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                MyCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.Int, 0)
                pId_Trang_Thai.Value = Id_Trang_Thai
                MyCommand.Parameters.Add(pId_Trang_Thai)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
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

                Dim pMa_To_Khai As SqlParameter = New SqlParameter("@Ma_To_Khai", SqlDbType.VarChar, 20)
                pMa_To_Khai.Value = Ma_To_Khai
                MyCommand.Parameters.Add(pMa_To_Khai)

                Dim pIp_May_Tinh As SqlParameter = New SqlParameter("@Ip_May_Tinh", SqlDbType.VarChar, 15)
                pIp_May_Tinh.Value = Ip_May_Tinh
                MyCommand.Parameters.Add(pIp_May_Tinh)

                Dim pBan_So As SqlParameter = New SqlParameter("@Ban_So", SqlDbType.Int, 0)
                pBan_So.Value = Ban_So
                MyCommand.Parameters.Add(pBan_So)

                Dim pTong_Muc_Hang As SqlParameter = New SqlParameter("@Tong_Muc_Hang", SqlDbType.Int, 0)
                pTong_Muc_Hang.Value = Tong_Muc_Hang
                MyCommand.Parameters.Add(pTong_Muc_Hang)

                Dim pTong_Tri_Gia As SqlParameter = New SqlParameter("@Tong_Tri_Gia", SqlDbType.Float, 0)
                pTong_Tri_Gia.Value = Tong_Tri_Gia
                MyCommand.Parameters.Add(pTong_Tri_Gia)


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

#Region "E1_Kiem_Hoa_Xuat_Cap_Nhat_Ma_To_Khai_Thuc_Cap"
        Public Function E1_Kiem_Hoa_Xuat_Cap_Nhat_Ma_To_Khai_Thuc_Cap(ByVal Ma_To_Khai_GIp_May_Tinh As String, ByVal Ma_To_Khai_Thuc_Cap As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Kiem_Hoa_Xuat_Cap_Nhat_Ma_To_Khai_Thuc_Cap"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myE1_Kiem_Hoa_Xuat_Chi_Tiet As New E1_Kiem_Hoa_Xuat_Chi_Tiet

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

#Region "E1_Kiem_Hoa_Xuat_Cap_Nhat_Them"
        Public Function E1_Kiem_Hoa_Xuat_Cap_Nhat_Them(ByVal Id_E1 As String, ByVal Id_E2 As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_E1 As String, ByVal Nuoc_Nhan As String, ByVal Nuoc_Tra As String, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal STT As Integer, ByVal Nguoi_Gui As String, ByVal Nguoi_Nhan As String, ByVal Dia_Chi_Gui As String, ByVal Dia_Chi_Nhan As String, ByVal Dien_Thoai_Gui As String, ByVal Dien_Thoai_Nhan As String, ByVal Id_Nguoi_Dung As Integer, ByVal Id_Trang_Thai As Integer, ByVal Ghi_Chu As String, ByVal Truyen_Khai_Thac As Boolean, ByVal Truyen_Doi_Soat As Boolean, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer, ByVal Chot_SL As Boolean, ByVal Ma_To_Khai As String, ByVal Ip_May_Tinh As String, ByVal Ban_So As Integer, ByVal Tong_Muc_Hang As Integer, ByVal Tong_Tri_Gia As Double) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Kiem_Hoa_Xuat_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myE1_Kiem_Hoa_Xuat_Chi_Tiet As New E1_Kiem_Hoa_Xuat_Chi_Tiet

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

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                MyCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                MyCommand.Parameters.Add(pMa_E1)

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

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Value = STT
                MyCommand.Parameters.Add(pSTT)

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

                Dim pDien_Thoai_Gui As SqlParameter = New SqlParameter("@Dien_Thoai_Gui", SqlDbType.VarChar, 50)
                pDien_Thoai_Gui.Value = Dien_Thoai_Gui
                MyCommand.Parameters.Add(pDien_Thoai_Gui)

                Dim pDien_Thoai_Nhan As SqlParameter = New SqlParameter("@Dien_Thoai_Nhan", SqlDbType.VarChar, 50)
                pDien_Thoai_Nhan.Value = Dien_Thoai_Nhan
                MyCommand.Parameters.Add(pDien_Thoai_Nhan)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                MyCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.Int, 0)
                pId_Trang_Thai.Value = Id_Trang_Thai
                MyCommand.Parameters.Add(pId_Trang_Thai)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
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

                Dim pMa_To_Khai As SqlParameter = New SqlParameter("@Ma_To_Khai", SqlDbType.VarChar, 20)
                pMa_To_Khai.Value = Ma_To_Khai
                MyCommand.Parameters.Add(pMa_To_Khai)

                Dim pIp_May_Tinh As SqlParameter = New SqlParameter("@Ip_May_Tinh", SqlDbType.VarChar, 15)
                pIp_May_Tinh.Value = Ip_May_Tinh
                MyCommand.Parameters.Add(pIp_May_Tinh)

                Dim pBan_So As SqlParameter = New SqlParameter("@Ban_So", SqlDbType.Int, 0)
                pBan_So.Value = Ban_So
                MyCommand.Parameters.Add(pBan_So)

                Dim pTong_Muc_Hang As SqlParameter = New SqlParameter("@Tong_Muc_Hang", SqlDbType.Int, 0)
                pTong_Muc_Hang.Value = Tong_Muc_Hang
                MyCommand.Parameters.Add(pTong_Muc_Hang)

                Dim pTong_Tri_Gia As SqlParameter = New SqlParameter("@Tong_Tri_Gia", SqlDbType.Float, 0)
                pTong_Tri_Gia.Value = Tong_Tri_Gia
                MyCommand.Parameters.Add(pTong_Tri_Gia)


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

#Region "E1_Kiem_Hoa_Xuat_Danh_Sach"

        Public Function E1_Kiem_Hoa_Xuat_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Id_E1
            ' Id_E2
            ' Id_Ca
            ' Ma_Bc_Khai_Thac
            ' Ma_E1
            ' Nuoc_Nhan
            ' Nuoc_Tra
            ' Khoi_Luong
            ' Phan_Loai
            ' STT
            ' Nguoi_Gui
            ' Nguoi_Nhan
            ' Dia_Chi_Gui
            ' Dia_Chi_Nhan
            ' Dien_Thoai_Gui
            ' Dien_Thoai_Nhan
            ' Id_Nguoi_Dung
            ' Id_Trang_Thai
            ' Ghi_Chu
            ' Truyen_Khai_Thac
            ' Truyen_Doi_Soat
            ' Ngay_He_Thong
            ' Gio_He_Thong
            ' Chot_SL
            ' Ma_To_Khai
            ' Ip_May_Tinh
            ' Ban_So
            ' Tong_Muc_Hang
            ' Tong_Tri_Gia


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Kiem_Hoa_Xuat_Danh_Sach"
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

#Region "E1_Kiem_Hoa_Xuat_Danh_Sach_Lay_Boi_Ma_To_Khai_Hang_Xuat"

        Public Function E1_Kiem_Hoa_Xuat_Danh_Sach_Lay_Boi_Ma_To_Khai_Hang_Xuat(ByVal Ma_To_Khai As String) As DataSet

            ' The procedure returns these columns:
            ' Id_E1
            ' Id_E2
            ' Id_Ca
            ' Ma_Bc_Khai_Thac
            ' Ma_E1
            ' Nuoc_Nhan
            ' Nuoc_Tra
            ' Khoi_Luong
            ' Phan_Loai
            ' STT
            ' Nguoi_Gui
            ' Nguoi_Nhan
            ' Dia_Chi_Gui
            ' Dia_Chi_Nhan
            ' Dien_Thoai_Gui
            ' Dien_Thoai_Nhan
            ' Id_Nguoi_Dung
            ' Id_Trang_Thai
            ' Ghi_Chu
            ' Truyen_Khai_Thac
            ' Truyen_Doi_Soat
            ' Ngay_He_Thong
            ' Gio_He_Thong
            ' Chot_SL
            ' Ma_To_Khai
            ' Ip_May_Tinh
            ' Ban_So
            ' Nhap_Chi_Tiet_Hang_Hoa
            ' Tong_Muc_Hang
            ' Tong_Tri_Gia


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Kiem_Hoa_Xuat_Danh_Sach_Lay_Boi_Ma_To_Khai_Hang_Xuat"
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

#Region "E1_Kiem_Hoa_Xuat_Lay"
        Public Function E1_Kiem_Hoa_Xuat_Lay(ByVal Id_E1 As String) As E1_Kiem_Hoa_Xuat_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Kiem_Hoa_Xuat_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myE1_Kiem_Hoa_Xuat_Chi_Tiet As New E1_Kiem_Hoa_Xuat_Chi_Tiet

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

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_E1)

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

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSTT)

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

                Dim pDien_Thoai_Gui As SqlParameter = New SqlParameter("@Dien_Thoai_Gui", SqlDbType.VarChar, 50)
                pDien_Thoai_Gui.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDien_Thoai_Gui)

                Dim pDien_Thoai_Nhan As SqlParameter = New SqlParameter("@Dien_Thoai_Nhan", SqlDbType.VarChar, 50)
                pDien_Thoai_Nhan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDien_Thoai_Nhan)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0)
                pId_Nguoi_Dung.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.Int, 0)
                pId_Trang_Thai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Trang_Thai)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
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

                Dim pMa_To_Khai As SqlParameter = New SqlParameter("@Ma_To_Khai", SqlDbType.VarChar, 20)
                pMa_To_Khai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_To_Khai)

                Dim pIp_May_Tinh As SqlParameter = New SqlParameter("@Ip_May_Tinh", SqlDbType.VarChar, 15)
                pIp_May_Tinh.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pIp_May_Tinh)

                Dim pBan_So As SqlParameter = New SqlParameter("@Ban_So", SqlDbType.Int, 0)
                pBan_So.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pBan_So)

                Dim pTong_Muc_Hang As SqlParameter = New SqlParameter("@Tong_Muc_Hang", SqlDbType.Int, 0)
                pTong_Muc_Hang.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTong_Muc_Hang)

                Dim pTong_Tri_Gia As SqlParameter = New SqlParameter("@Tong_Tri_Gia", SqlDbType.Float, 0)
                pTong_Tri_Gia.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTong_Tri_Gia)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Id_E1 = Id_E1
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Id_E2 = pId_E2.Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Id_Ca = pId_Ca.Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Ma_Bc_Khai_Thac = pMa_Bc_Khai_Thac.Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Ma_E1 = pMa_E1.Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Nuoc_Nhan = pNuoc_Nhan.Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Nuoc_Tra = pNuoc_Tra.Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Khoi_Luong = pKhoi_Luong.Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Phan_Loai = pPhan_Loai.Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.STT = pSTT.Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Nguoi_Gui = pNguoi_Gui.Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Nguoi_Nhan = pNguoi_Nhan.Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Dia_Chi_Gui = pDia_Chi_Gui.Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Dia_Chi_Nhan = pDia_Chi_Nhan.Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Dien_Thoai_Gui = pDien_Thoai_Gui.Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Dien_Thoai_Nhan = pDien_Thoai_Nhan.Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Id_Nguoi_Dung = pId_Nguoi_Dung.Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Id_Trang_Thai = pId_Trang_Thai.Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Truyen_Khai_Thac = pTruyen_Khai_Thac.Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Truyen_Doi_Soat = pTruyen_Doi_Soat.Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Gio_He_Thong = pGio_He_Thong.Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Chot_SL = pChot_SL.Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Ma_To_Khai = pMa_To_Khai.Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Ip_May_Tinh = pIp_May_Tinh.Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Ban_So = pBan_So.Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Tong_Muc_Hang = pTong_Muc_Hang.Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Tong_Tri_Gia = pTong_Tri_Gia.Value

                Return myE1_Kiem_Hoa_Xuat_Chi_Tiet
                'Return myE1_Kiem_Hoa_Xuat_Chi_Tiet

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

#Region "E1_Kiem_Hoa_Xuat_Them"
        Public Function E1_Kiem_Hoa_Xuat_Them(ByVal Id_E1 As String, ByVal Id_E2 As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_E1 As String, ByVal Nuoc_Nhan As String, ByVal Nuoc_Tra As String, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal STT As Integer, ByVal Nguoi_Gui As String, ByVal Nguoi_Nhan As String, ByVal Dia_Chi_Gui As String, ByVal Dia_Chi_Nhan As String, ByVal Dien_Thoai_Gui As String, ByVal Dien_Thoai_Nhan As String, ByVal Id_Nguoi_Dung As Integer, ByVal Id_Trang_Thai As Integer, ByVal Ghi_Chu As String, ByVal Truyen_Khai_Thac As Boolean, ByVal Truyen_Doi_Soat As Boolean, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer, ByVal Chot_SL As Boolean, ByVal Ma_To_Khai As String, ByVal Ip_May_Tinh As String, ByVal Ban_So As Integer, ByVal Tong_Muc_Hang As Integer, ByVal Tong_Tri_Gia As Double) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Kiem_Hoa_Xuat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myE1_Kiem_Hoa_Xuat_Chi_Tiet As New E1_Kiem_Hoa_Xuat_Chi_Tiet

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

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                MyCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                MyCommand.Parameters.Add(pMa_E1)

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

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Value = STT
                MyCommand.Parameters.Add(pSTT)

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

                Dim pDien_Thoai_Gui As SqlParameter = New SqlParameter("@Dien_Thoai_Gui", SqlDbType.VarChar, 50)
                pDien_Thoai_Gui.Value = Dien_Thoai_Gui
                MyCommand.Parameters.Add(pDien_Thoai_Gui)

                Dim pDien_Thoai_Nhan As SqlParameter = New SqlParameter("@Dien_Thoai_Nhan", SqlDbType.VarChar, 50)
                pDien_Thoai_Nhan.Value = Dien_Thoai_Nhan
                MyCommand.Parameters.Add(pDien_Thoai_Nhan)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                MyCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.Int, 0)
                pId_Trang_Thai.Value = Id_Trang_Thai
                MyCommand.Parameters.Add(pId_Trang_Thai)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
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

                Dim pMa_To_Khai As SqlParameter = New SqlParameter("@Ma_To_Khai", SqlDbType.VarChar, 20)
                pMa_To_Khai.Value = Ma_To_Khai
                MyCommand.Parameters.Add(pMa_To_Khai)

                Dim pIp_May_Tinh As SqlParameter = New SqlParameter("@Ip_May_Tinh", SqlDbType.VarChar, 15)
                pIp_May_Tinh.Value = Ip_May_Tinh
                MyCommand.Parameters.Add(pIp_May_Tinh)

                Dim pBan_So As SqlParameter = New SqlParameter("@Ban_So", SqlDbType.Int, 0)
                pBan_So.Value = Ban_So
                MyCommand.Parameters.Add(pBan_So)

                Dim pTong_Muc_Hang As SqlParameter = New SqlParameter("@Tong_Muc_Hang", SqlDbType.Int, 0)
                pTong_Muc_Hang.Value = Tong_Muc_Hang
                MyCommand.Parameters.Add(pTong_Muc_Hang)

                Dim pTong_Tri_Gia As SqlParameter = New SqlParameter("@Tong_Tri_Gia", SqlDbType.Float, 0)
                pTong_Tri_Gia.Value = Tong_Tri_Gia
                MyCommand.Parameters.Add(pTong_Tri_Gia)


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

#Region "E1_Kiem_Hoa_Xuat_Xoa"
        Public Function E1_Kiem_Hoa_Xuat_Xoa(ByVal Id_E1 As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Kiem_Hoa_Xuat_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myE1_Kiem_Hoa_Xuat_Chi_Tiet As New E1_Kiem_Hoa_Xuat_Chi_Tiet

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

#Region "E1_Kiem_Hoa_Xuat_Xoa_Boi_Ma_To_Khai"
        Public Function E1_Kiem_Hoa_Xuat_Xoa_Boi_Ma_To_Khai(ByVal Ma_To_Khai As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Kiem_Hoa_Xuat_Xoa_Boi_Ma_To_Khai"
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

    End Class
#End Region
End Namespace


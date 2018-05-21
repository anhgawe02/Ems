
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Math
Namespace EMS
#Region "E1_Le_Phi_Di_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp E1_Le_Phi_Di_Chi_Tiet
    ' tương ứng với một trường của bảng E1_Le_Phi_Di trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class E1_Le_Phi_Di_Chi_Tiet
        Public Id_E1 As String ' SSSSSSRRRRRRDDDDBBBYYYYMMDDHHMMEEXXXXXXXXXVNQQQQ
        Public Id_Duong_Thu As String ' Đường thư đóng đi
        Public Id_Chuyen_Thu As String ' Id chuyến thư đóng đi
        Public Id_E2 As String ' Id E2 đóng đi
        Public Id_Ca As String ' Ca sản xuất
        Public Ma_Bc_Khai_Thac As Integer ' Mã bưu cục khai thác BP
        Public Ma_E1 As String
        Public Ngay_Dong As Integer ' Ngày đóng BP
        Public Gio_Dong As Integer ' Giờ đóng BP
        Public Ma_Don_Vi As String ' Mã dịch vụ
        Public Ma_Bc_Goc As Integer ' Mã bưu cục chấp nhận bưu phẩm (có thể là mã đầu tỉnh)
        Public Ma_Bc_Tra As Integer ' Mã bưu cục phát trả bưu phẩm (Có thể là mã đầu tỉnh)
        Public Nuoc_Nhan As String ' Nước chấp nhận bưu phẩm
        Public Nuoc_Tra As String ' Nước phát trả BP
        Public Khoi_Luong As Integer
        Public So_TKHQ As String ' Số tờ khai hải quan
        Public So_Bien_Lai As String ' Số biên lai thu lệ phí hải quan
        Public Le_Phi_HQ As Integer ' Lệ phí hải quan
        Public Thue_NK As Integer 'Thuế nhập khẩu 
        Public Thue_VAT As Integer 'Thuế  VAT
        Public Thue_NK_VAT As Integer 'Thuế nhập khẩu và VAT
        Public Kien_So As Integer ' Kiện số (Sử dụng cho Hàng 1 Vận đơn)
        Public STT As Integer ' Số thứ tự trong bản kê E2
        Public Id_Nguoi_Dung As Integer
        Public Truyen_Khai_Thac As Boolean ' Truyền dữ liệu khai thác
        Public Truyen_Doi_Soat As Boolean ' Truyền dữ liệu đối soát sau khi đã cân đối ca
        Public Ngay_He_Thong As Integer
        Public Chot_SL As Boolean ' Chốt số liệu sau khi đã cân đối ca
        Public Le_Phi_VH As Integer
        Public Le_Phi_YT As Integer
        Public Le_Phi_DV As Integer
        Public Le_Phi_TV As Integer
        Public Le_Phi_Khac As Integer

        'Public Ma_Tinh_Tra As Integer 'Mã Tỉnh Phát trả bưu phẩm
        'Public Phan_Loai_Duong_Thu As Integer 'Phân loại đường thư: (nội thành, ngoại thành)
    End Class
#End Region
#Region "E1_Le_Phi_Di"
    Public Class E1_Le_Phi_Di
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        Public Function Lay(ByVal Id_E1 As String) As E1_Le_Phi_Di_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Le_Phi_Di_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                myCommand.Parameters.Add(pId_E1)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_E2)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_E1)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 4)
                pNgay_Dong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_Dong)

                Dim pGio_Dong As SqlParameter = New SqlParameter("@Gio_Dong", SqlDbType.Int, 4)
                pGio_Dong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGio_Dong)

                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
                pMa_Don_Vi.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Don_Vi)

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 4)
                pMa_Bc_Goc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 4)
                pMa_Bc_Tra.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_Tra)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNuoc_Nhan)

                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2)
                pNuoc_Tra.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNuoc_Tra)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pLe_Phi_HQ As SqlParameter = New SqlParameter("@Le_Phi_HQ", SqlDbType.Int, 4)
                pLe_Phi_HQ.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pLe_Phi_HQ)

                Dim pThue_NK As SqlParameter = New SqlParameter("@Thue_NK", SqlDbType.Int, 4)
                pThue_NK.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pThue_NK)

                Dim pThue_VAT As SqlParameter = New SqlParameter("@Thue_VAT", SqlDbType.Int, 4)
                pThue_VAT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pThue_VAT)

                Dim pThue_NK_VAT As SqlParameter = New SqlParameter("@Thue_NK_VAT", SqlDbType.Int, 4)
                pThue_NK_VAT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pThue_NK_VAT)

                Dim pSo_TKHQ As SqlParameter = New SqlParameter("@So_TKHQ", SqlDbType.VarChar, 50)
                pSo_TKHQ.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSo_TKHQ)

                Dim pSo_Bien_Lai As SqlParameter = New SqlParameter("@So_Bien_Lai", SqlDbType.VarChar, 50)
                pSo_Bien_Lai.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSo_Bien_Lai)

                Dim pKien_So As SqlParameter = New SqlParameter("@Kien_So", SqlDbType.Int, 4)
                pKien_So.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pKien_So)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 4)
                pSTT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSTT)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 4)
                pId_Nguoi_Dung.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTruyen_Khai_Thac)

                Dim pTruyen_Doi_Soat As SqlParameter = New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 1)
                pTruyen_Doi_Soat.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTruyen_Doi_Soat)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 1)
                pChot_SL.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pChot_SL)

                Dim pLe_Phi_VH As SqlParameter = New SqlParameter("@Le_Phi_VH", SqlDbType.Int, 4)
                pLe_Phi_VH.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pLe_Phi_VH)

                Dim pLe_Phi_YT As SqlParameter = New SqlParameter("@Le_Phi_YT", SqlDbType.Int, 4)
                pLe_Phi_YT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pLe_Phi_YT)

                Dim pLe_Phi_DV As SqlParameter = New SqlParameter("@Le_Phi_DV", SqlDbType.Int, 4)
                pLe_Phi_DV.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pLe_Phi_DV)

                Dim pLe_Phi_TV As SqlParameter = New SqlParameter("@Le_Phi_TV", SqlDbType.Int, 4)
                pLe_Phi_TV.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pLe_Phi_TV)

                Dim pLe_Phi_Khac As SqlParameter = New SqlParameter("@Le_Phi_Khac", SqlDbType.Int, 4)
                pLe_Phi_Khac.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pLe_Phi_Khac)

                'Dim pMa_Tinh_Tra As SqlParameter = New SqlParameter("@Ma_Tinh_Tra", SqlDbType.Int, 4)
                'pMa_Tinh_Tra.Direction = ParameterDirection.Output
                'myCommand.Parameters.Add(pMa_Tinh_Tra)

                'Dim pPhan_Loai_Duong_Thu As SqlParameter = New SqlParameter("@Phan_Loai_Duong_Thu", SqlDbType.Int, 4)
                'pPhan_Loai_Duong_Thu.Direction = ParameterDirection.Output
                'myCommand.Parameters.Add(pPhan_Loai_Duong_Thu)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myE1_Le_Phi_Di_Chi_Tiet As E1_Le_Phi_Di_Chi_Tiet = New E1_Le_Phi_Di_Chi_Tiet
                myE1_Le_Phi_Di_Chi_Tiet.Id_E1 = Id_E1
                myE1_Le_Phi_Di_Chi_Tiet.Id_Duong_Thu = pId_Duong_Thu.Value
                myE1_Le_Phi_Di_Chi_Tiet.Id_Chuyen_Thu = pId_Chuyen_Thu.Value
                myE1_Le_Phi_Di_Chi_Tiet.Id_E2 = pId_E2.Value
                myE1_Le_Phi_Di_Chi_Tiet.Id_Ca = pId_Ca.Value
                myE1_Le_Phi_Di_Chi_Tiet.Ma_Bc_Khai_Thac = pMa_Bc_Khai_Thac.Value
                myE1_Le_Phi_Di_Chi_Tiet.Ma_E1 = pMa_E1.Value
                myE1_Le_Phi_Di_Chi_Tiet.Ngay_Dong = pNgay_Dong.Value
                myE1_Le_Phi_Di_Chi_Tiet.Gio_Dong = pGio_Dong.Value
                myE1_Le_Phi_Di_Chi_Tiet.Ma_Don_Vi = pMa_Don_Vi.Value
                myE1_Le_Phi_Di_Chi_Tiet.Ma_Bc_Goc = pMa_Bc_Goc.Value
                myE1_Le_Phi_Di_Chi_Tiet.Ma_Bc_Tra = pMa_Bc_Tra.Value
                myE1_Le_Phi_Di_Chi_Tiet.Nuoc_Nhan = pNuoc_Nhan.Value
                myE1_Le_Phi_Di_Chi_Tiet.Nuoc_Tra = pNuoc_Tra.Value
                myE1_Le_Phi_Di_Chi_Tiet.Khoi_Luong = pKhoi_Luong.Value
                myE1_Le_Phi_Di_Chi_Tiet.Le_Phi_HQ = pLe_Phi_HQ.Value
                myE1_Le_Phi_Di_Chi_Tiet.Thue_NK = pThue_NK.Value
                myE1_Le_Phi_Di_Chi_Tiet.Thue_VAT = pThue_VAT.Value
                myE1_Le_Phi_Di_Chi_Tiet.Thue_NK_VAT = pThue_NK_VAT.Value
                myE1_Le_Phi_Di_Chi_Tiet.So_TKHQ = pSo_TKHQ.Value
                myE1_Le_Phi_Di_Chi_Tiet.So_Bien_Lai = pSo_Bien_Lai.Value
                myE1_Le_Phi_Di_Chi_Tiet.Kien_So = pKien_So.Value
                myE1_Le_Phi_Di_Chi_Tiet.STT = pSTT.Value
                myE1_Le_Phi_Di_Chi_Tiet.Id_Nguoi_Dung = pId_Nguoi_Dung.Value
                myE1_Le_Phi_Di_Chi_Tiet.Truyen_Khai_Thac = pTruyen_Khai_Thac.Value
                myE1_Le_Phi_Di_Chi_Tiet.Truyen_Doi_Soat = pTruyen_Doi_Soat.Value
                myE1_Le_Phi_Di_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myE1_Le_Phi_Di_Chi_Tiet.Chot_SL = pChot_SL.Value
                myE1_Le_Phi_Di_Chi_Tiet.Le_Phi_VH = pLe_Phi_VH.Value
                myE1_Le_Phi_Di_Chi_Tiet.Le_Phi_YT = pLe_Phi_YT.Value
                myE1_Le_Phi_Di_Chi_Tiet.Le_Phi_DV = pLe_Phi_DV.Value
                myE1_Le_Phi_Di_Chi_Tiet.Le_Phi_TV = pLe_Phi_TV.Value
                myE1_Le_Phi_Di_Chi_Tiet.Le_Phi_Khac = pLe_Phi_Khac.Value
                'myE1_Le_Phi_Di_Chi_Tiet.Ma_Tinh_Tra = pMa_Tinh_Tra.Value
                'myE1_Le_Phi_Di_Chi_Tiet.Phan_Loai_Duong_Thu = pPhan_Loai_Duong_Thu.Value
                Return myE1_Le_Phi_Di_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "E1_Le_Phi_Di_Cap_Nhat"
        Public Function E1_Le_Phi_Di_Cap_Nhat(ByVal id_E1 As String, ByVal id_Duong_Thu As String, ByVal id_Chuyen_Thu As String, ByVal id_E2 As String, ByVal id_Ca As String, ByVal ma_Bc_Khai_Thac As Integer, ByVal ma_E1 As String, ByVal ngay_Dong As Integer, ByVal gio_Dong As Integer, ByVal ma_Don_Vi As String, ByVal ma_Bc_Goc As Integer, ByVal ma_Bc_Tra As Integer, ByVal nuoc_Nhan As String, ByVal nuoc_Tra As String, ByVal khoi_Luong As Integer, ByVal so_TKHQ As String, ByVal so_Bien_Lai As String, ByVal le_Phi_HQ As Integer, ByVal thue_NK As Integer, ByVal thue_VAT As Integer, ByVal thue_NK_VAT As Integer, ByVal kien_So As Integer, ByVal stt As Integer, ByVal id_Nguoi_Dung As Integer, ByVal truyen_Khai_Thac As Boolean, ByVal truyen_Doi_Soat As Boolean, ByVal ngay_He_Thong As Integer, ByVal chot_SL As Boolean, ByVal Le_Phi_VH As Integer, ByVal Le_Phi_YT As Integer, ByVal Le_Phi_DV As Integer, ByVal Le_Phi_TV As Integer, ByVal Le_Phi_Khac As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Le_Phi_Di_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_E1", SqlDbType.VarChar, 48, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_E1))
                MyCommand.Parameters.Add(New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_Duong_Thu))
                MyCommand.Parameters.Add(New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_Chuyen_Thu))
                MyCommand.Parameters.Add(New SqlParameter("@Id_E2", SqlDbType.VarChar, 31, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_E2))
                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_Ca))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Bc_Khai_Thac))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, ma_E1))
                MyCommand.Parameters.Add(New SqlParameter("@Ngay_Dong", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ngay_Dong))
                MyCommand.Parameters.Add(New SqlParameter("@Gio_Dong", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, gio_Dong))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, ma_Don_Vi))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Bc_Goc))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Bc_Tra))
                MyCommand.Parameters.Add(New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, nuoc_Nhan))
                MyCommand.Parameters.Add(New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, nuoc_Tra))
                MyCommand.Parameters.Add(New SqlParameter("@Khoi_Luong", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, khoi_Luong))
                MyCommand.Parameters.Add(New SqlParameter("@So_TKHQ", SqlDbType.VarChar, 50, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, so_TKHQ))
                MyCommand.Parameters.Add(New SqlParameter("@So_Bien_Lai", SqlDbType.VarChar, 50, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, so_Bien_Lai))
                MyCommand.Parameters.Add(New SqlParameter("@Le_Phi_HQ", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, le_Phi_HQ))
                MyCommand.Parameters.Add(New SqlParameter("@Thue_NK", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, thue_NK))
                MyCommand.Parameters.Add(New SqlParameter("@Thue_VAT", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, thue_VAT))
                MyCommand.Parameters.Add(New SqlParameter("@Thue_NK_VAT", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, thue_NK_VAT))
                MyCommand.Parameters.Add(New SqlParameter("@Kien_So", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, kien_So))
                MyCommand.Parameters.Add(New SqlParameter("@STT", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, stt))
                MyCommand.Parameters.Add(New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, id_Nguoi_Dung))
                MyCommand.Parameters.Add(New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, truyen_Khai_Thac))
                MyCommand.Parameters.Add(New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, truyen_Doi_Soat))
                MyCommand.Parameters.Add(New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ngay_He_Thong))
                MyCommand.Parameters.Add(New SqlParameter("@Chot_SL", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, chot_SL))
                MyCommand.Parameters.Add(New SqlParameter("@Le_Phi_VH", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Le_Phi_VH))
                MyCommand.Parameters.Add(New SqlParameter("@Le_Phi_YT", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Le_Phi_YT))
                MyCommand.Parameters.Add(New SqlParameter("@Le_Phi_DV", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Le_Phi_DV))
                MyCommand.Parameters.Add(New SqlParameter("@Le_Phi_TV", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Le_Phi_TV))
                MyCommand.Parameters.Add(New SqlParameter("@Le_Phi_Khac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Le_Phi_Khac))
                'MyCommand.Parameters.Add(New SqlParameter("@Ma_Tinh_Tra", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Ma_Tinh_Tra))
                'MyCommand.Parameters.Add(New SqlParameter("@Phan_Loai_Duong_Thu", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Phan_Loai_Duong_Thu))

                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                Return numRows
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
#Region "E1_Le_Phi_Di_Cap_Nhat_Them"
        Public Function E1_Le_Phi_Di_Cap_Nhat_Them(ByVal id_E1 As String, ByVal id_Duong_Thu As String, ByVal id_Chuyen_Thu As String, ByVal id_E2 As String, ByVal id_Ca As String, ByVal ma_Bc_Khai_Thac As Integer, ByVal ma_E1 As String, ByVal ngay_Dong As Integer, ByVal gio_Dong As Integer, ByVal ma_Don_Vi As String, ByVal ma_Bc_Goc As Integer, ByVal ma_Bc_Tra As Integer, ByVal nuoc_Nhan As String, ByVal nuoc_Tra As String, ByVal khoi_Luong As Integer, ByVal so_TKHQ As String, ByVal so_Bien_Lai As String, ByVal le_Phi_HQ As Integer, ByVal thue_NK As Integer, ByVal thue_VAT As Integer, ByVal thue_NK_VAT As Integer, ByVal kien_So As Integer, ByVal stt As Integer, ByVal id_Nguoi_Dung As Integer, ByVal truyen_Khai_Thac As Boolean, ByVal truyen_Doi_Soat As Boolean, ByVal ngay_He_Thong As Integer, ByVal chot_SL As Boolean, ByVal Le_Phi_VH As Integer, ByVal Le_Phi_YT As Integer, ByVal Le_Phi_DV As Integer, ByVal Le_Phi_TV As Integer, ByVal Le_Phi_Khac As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Le_Phi_Di_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_E1", SqlDbType.VarChar, 48, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_E1))
                MyCommand.Parameters.Add(New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_Duong_Thu))
                MyCommand.Parameters.Add(New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_Chuyen_Thu))
                MyCommand.Parameters.Add(New SqlParameter("@Id_E2", SqlDbType.VarChar, 31, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_E2))
                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_Ca))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Bc_Khai_Thac))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, ma_E1))
                MyCommand.Parameters.Add(New SqlParameter("@Ngay_Dong", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ngay_Dong))
                MyCommand.Parameters.Add(New SqlParameter("@Gio_Dong", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, gio_Dong))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, ma_Don_Vi))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Bc_Goc))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Bc_Tra))
                MyCommand.Parameters.Add(New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, nuoc_Nhan))
                MyCommand.Parameters.Add(New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, nuoc_Tra))
                MyCommand.Parameters.Add(New SqlParameter("@Khoi_Luong", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, khoi_Luong))
                MyCommand.Parameters.Add(New SqlParameter("@So_TKHQ", SqlDbType.VarChar, 50, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, so_TKHQ))
                MyCommand.Parameters.Add(New SqlParameter("@So_Bien_Lai", SqlDbType.VarChar, 50, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, so_Bien_Lai))
                MyCommand.Parameters.Add(New SqlParameter("@Le_Phi_HQ", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, le_Phi_HQ))
                MyCommand.Parameters.Add(New SqlParameter("@Thue_NK", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, thue_NK))
                MyCommand.Parameters.Add(New SqlParameter("@Thue_VAT", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, thue_VAT))
                MyCommand.Parameters.Add(New SqlParameter("@Thue_NK_VAT", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, thue_NK_VAT))
                MyCommand.Parameters.Add(New SqlParameter("@Kien_So", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, kien_So))
                MyCommand.Parameters.Add(New SqlParameter("@STT", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, stt))
                MyCommand.Parameters.Add(New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, id_Nguoi_Dung))
                MyCommand.Parameters.Add(New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, truyen_Khai_Thac))
                MyCommand.Parameters.Add(New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, truyen_Doi_Soat))
                MyCommand.Parameters.Add(New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ngay_He_Thong))
                MyCommand.Parameters.Add(New SqlParameter("@Chot_SL", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, chot_SL))
                MyCommand.Parameters.Add(New SqlParameter("@Le_Phi_VH", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Le_Phi_VH))
                MyCommand.Parameters.Add(New SqlParameter("@Le_Phi_YT", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Le_Phi_YT))
                MyCommand.Parameters.Add(New SqlParameter("@Le_Phi_DV", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Le_Phi_DV))
                MyCommand.Parameters.Add(New SqlParameter("@Le_Phi_TV", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Le_Phi_TV))
                MyCommand.Parameters.Add(New SqlParameter("@Le_Phi_Khac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Le_Phi_Khac))
                'MyCommand.Parameters.Add(New SqlParameter("@Ma_Tinh_Tra", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Ma_Tinh_Tra))
                'MyCommand.Parameters.Add(New SqlParameter("@Phan_Loai_Duong_Thu", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Phan_Loai_Duong_Thu))

                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                Return numRows
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
#Region "E1_Le_Phi_Di_Danh_Sach"

        Public Function E1_Le_Phi_Di_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Id_E1
            ' Id_Duong_Thu
            ' Id_Chuyen_Thu
            ' Id_E2
            ' Id_Ca
            ' Ma_Bc_Khai_Thac
            ' Ma_E1
            ' Ngay_Dong
            ' Gio_Dong
            ' Ma_Don_Vi
            ' Ma_Bc_Goc
            ' Ma_Bc_Tra
            ' Nuoc_Nhan
            ' Nuoc_Tra
            ' Khoi_Luong
            ' So_TKHQ
            ' So_Bien_Lai
            ' Le_Phi_HQ
            ' Thue_NK
            ' Thue_VAT
            ' Thue_NK_VAT
            ' Kien_So
            ' STT
            ' Id_Nguoi_Dung
            ' Truyen_Khai_Thac
            ' Truyen_Doi_Soat
            ' Ngay_He_Thong
            ' Chot_SL
            ' Ma_Tinh_Tra
            ' Phan_Loai_Duong_Thu

            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Le_Phi_Di_Danh_Sach"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
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
#Region "E1_Le_Phi_Di_Them"
        Public Function E1_Le_Phi_Di_Them(ByVal id_E1 As String, ByVal id_Duong_Thu As String, ByVal id_Chuyen_Thu As String, ByVal id_E2 As String, ByVal id_Ca As String, ByVal ma_Bc_Khai_Thac As Integer, ByVal ma_E1 As String, ByVal ngay_Dong As Integer, ByVal gio_Dong As Integer, ByVal ma_Don_Vi As String, ByVal ma_Bc_Goc As Integer, ByVal ma_Bc_Tra As Integer, ByVal nuoc_Nhan As String, ByVal nuoc_Tra As String, ByVal khoi_Luong As Integer, ByVal so_TKHQ As String, ByVal so_Bien_Lai As String, ByVal le_Phi_HQ As Integer, ByVal thue_NK As Integer, ByVal thue_VAT As Integer, ByVal thue_NK_VAT As Integer, ByVal kien_So As Integer, ByVal stt As Integer, ByVal id_Nguoi_Dung As Integer, ByVal truyen_Khai_Thac As Boolean, ByVal truyen_Doi_Soat As Boolean, ByVal ngay_He_Thong As Integer, ByVal chot_SL As Boolean, ByVal Le_Phi_VH As Integer, ByVal Le_Phi_YT As Integer, ByVal Le_Phi_DV As Integer, ByVal Le_Phi_TV As Integer, ByVal Le_Phi_Khac As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Le_Phi_Di_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_E1", SqlDbType.VarChar, 48, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_E1))
                MyCommand.Parameters.Add(New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_Duong_Thu))
                MyCommand.Parameters.Add(New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_Chuyen_Thu))
                MyCommand.Parameters.Add(New SqlParameter("@Id_E2", SqlDbType.VarChar, 31, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_E2))
                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_Ca))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Bc_Khai_Thac))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, ma_E1))
                MyCommand.Parameters.Add(New SqlParameter("@Ngay_Dong", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ngay_Dong))
                MyCommand.Parameters.Add(New SqlParameter("@Gio_Dong", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, gio_Dong))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, ma_Don_Vi))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Bc_Goc))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Bc_Tra))
                MyCommand.Parameters.Add(New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, nuoc_Nhan))
                MyCommand.Parameters.Add(New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, nuoc_Tra))
                MyCommand.Parameters.Add(New SqlParameter("@Khoi_Luong", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, khoi_Luong))
                MyCommand.Parameters.Add(New SqlParameter("@So_TKHQ", SqlDbType.VarChar, 50, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, so_TKHQ))
                MyCommand.Parameters.Add(New SqlParameter("@So_Bien_Lai", SqlDbType.VarChar, 50, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, so_Bien_Lai))
                MyCommand.Parameters.Add(New SqlParameter("@Le_Phi_HQ", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, le_Phi_HQ))
                MyCommand.Parameters.Add(New SqlParameter("@Thue_NK", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, thue_NK))
                MyCommand.Parameters.Add(New SqlParameter("@Thue_VAT", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, thue_VAT))
                MyCommand.Parameters.Add(New SqlParameter("@Thue_NK_VAT", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, thue_NK_VAT))
                MyCommand.Parameters.Add(New SqlParameter("@Kien_So", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, kien_So))
                MyCommand.Parameters.Add(New SqlParameter("@STT", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, stt))
                MyCommand.Parameters.Add(New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, id_Nguoi_Dung))
                MyCommand.Parameters.Add(New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, truyen_Khai_Thac))
                MyCommand.Parameters.Add(New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, truyen_Doi_Soat))
                MyCommand.Parameters.Add(New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ngay_He_Thong))
                MyCommand.Parameters.Add(New SqlParameter("@Chot_SL", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, chot_SL))
                MyCommand.Parameters.Add(New SqlParameter("@Le_Phi_VH", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Le_Phi_VH))
                MyCommand.Parameters.Add(New SqlParameter("@Le_Phi_YT", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Le_Phi_YT))
                MyCommand.Parameters.Add(New SqlParameter("@Le_Phi_DV", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Le_Phi_DV))
                MyCommand.Parameters.Add(New SqlParameter("@Le_Phi_TV", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Le_Phi_TV))
                MyCommand.Parameters.Add(New SqlParameter("@Le_Phi_Khac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Le_Phi_Khac))
                'MyCommand.Parameters.Add(New SqlParameter("@Ma_Tinh_Tra", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Ma_Tinh_Tra))
                'MyCommand.Parameters.Add(New SqlParameter("@Phan_Loai_Duong_Thu", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Phan_Loai_Duong_Thu))

                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                Return numRows
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
#Region "E1_Le_Phi_Di_Xoa"
        Public Function E1_Le_Phi_Di_Xoa(ByVal id_E1 As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Le_Phi_Di_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_E1", SqlDbType.VarChar, 48, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_E1))

                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                Return numRows
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
#Region "Khai Thác"
#Region "E1_Le_Phi_Di_Cap_Nhat_Them_KT"
        Public Function E1_Le_Phi_Di_Cap_Nhat_Them_KT(ByVal id_E1 As String, ByVal id_Duong_Thu As String, ByVal id_Chuyen_Thu As String, ByVal id_E2 As String, ByVal id_Ca As String, ByVal ma_Bc_Khai_Thac As Integer, ByVal ma_E1 As String, ByVal ngay_Dong As Integer, ByVal gio_Dong As Integer, ByVal ma_Don_Vi As String, ByVal ma_Bc_Goc As Integer, ByVal ma_Bc_Tra As Integer, ByVal nuoc_Nhan As String, ByVal nuoc_Tra As String, ByVal khoi_Luong As Integer, ByVal so_TKHQ As String, ByVal so_Bien_Lai As String, ByVal le_Phi_HQ As Integer, ByVal thue_NK As Integer, ByVal thue_VAT As Integer, ByVal thue_NK_VAT As Integer, ByVal kien_So As Integer, ByVal stt As Integer, ByVal id_Nguoi_Dung As Integer, ByVal truyen_Khai_Thac As Boolean, ByVal truyen_Doi_Soat As Boolean, ByVal chot_SL As Boolean, ByVal Le_Phi_VH As Integer, ByVal Le_Phi_YT As Integer, ByVal Le_Phi_DV As Integer, ByVal Le_Phi_TV As Integer, ByVal Le_Phi_Khac As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Le_Phi_Di_Cap_Nhat_Them_KT"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_E1", SqlDbType.VarChar, 48, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_E1))
                MyCommand.Parameters.Add(New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_Duong_Thu))
                MyCommand.Parameters.Add(New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_Chuyen_Thu))
                MyCommand.Parameters.Add(New SqlParameter("@Id_E2", SqlDbType.VarChar, 31, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_E2))
                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_Ca))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Bc_Khai_Thac))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, ma_E1))
                MyCommand.Parameters.Add(New SqlParameter("@Ngay_Dong", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ngay_Dong))
                MyCommand.Parameters.Add(New SqlParameter("@Gio_Dong", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, gio_Dong))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, ma_Don_Vi))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Bc_Goc))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Bc_Tra))
                MyCommand.Parameters.Add(New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, nuoc_Nhan))
                MyCommand.Parameters.Add(New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, nuoc_Tra))
                MyCommand.Parameters.Add(New SqlParameter("@Khoi_Luong", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, khoi_Luong))
                MyCommand.Parameters.Add(New SqlParameter("@So_TKHQ", SqlDbType.VarChar, 50, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, so_TKHQ))
                MyCommand.Parameters.Add(New SqlParameter("@So_Bien_Lai", SqlDbType.VarChar, 50, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, so_Bien_Lai))
                MyCommand.Parameters.Add(New SqlParameter("@Le_Phi_HQ", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, le_Phi_HQ))
                MyCommand.Parameters.Add(New SqlParameter("@Thue_NK", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, thue_NK))
                MyCommand.Parameters.Add(New SqlParameter("@Thue_VAT", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, thue_VAT))
                MyCommand.Parameters.Add(New SqlParameter("@Thue_NK_VAT", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, thue_NK_VAT))
                MyCommand.Parameters.Add(New SqlParameter("@Kien_So", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, kien_So))
                MyCommand.Parameters.Add(New SqlParameter("@STT", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, stt))
                MyCommand.Parameters.Add(New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, id_Nguoi_Dung))
                MyCommand.Parameters.Add(New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, truyen_Khai_Thac))
                MyCommand.Parameters.Add(New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, truyen_Doi_Soat))
                MyCommand.Parameters.Add(New SqlParameter("@Chot_SL", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, chot_SL))
                MyCommand.Parameters.Add(New SqlParameter("@Le_Phi_VH", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Le_Phi_VH))
                MyCommand.Parameters.Add(New SqlParameter("@Le_Phi_YT", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Le_Phi_YT))
                MyCommand.Parameters.Add(New SqlParameter("@Le_Phi_DV", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Le_Phi_DV))
                MyCommand.Parameters.Add(New SqlParameter("@Le_Phi_TV", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Le_Phi_TV))
                MyCommand.Parameters.Add(New SqlParameter("@Le_Phi_Khac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Le_Phi_Khac))
                'MyCommand.Parameters.Add(New SqlParameter("@Ma_Tinh_Tra", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Ma_Tinh_Tra))
                'MyCommand.Parameters.Add(New SqlParameter("@Phan_Loai_Duong_Thu", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Phan_Loai_Duong_Thu))

                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                Return numRows
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
#End Region
#Region "Tổng hợp thuế và lệ phí hải quan"
        Public Function E1_Le_Phi_Di_Tong_Hop_Le_Phi_Theo_Ma_Tinh(ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Tinh_Tra As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer) As DataSet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Le_Phi_Di_Tong_Hop_Le_Phi_Theo_Ma_Tinh"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            MyCommand.Parameters.Add(New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Tu_Ngay))
            MyCommand.Parameters.Add(New SqlParameter("@Den_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Den_Ngay))
            MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, Ma_Bc_Khai_Thac))
            MyCommand.Parameters.Add(New SqlParameter("@Ma_Tinh_Tra", SqlDbType.Int, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, Ma_Tinh_Tra))

            Try
                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                adapter.Fill(MyDataSet)

                Return MyDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
            Finally
                MyConnection.Close()
                MyCommand.Dispose()
                adapter.Dispose()
            End Try
        End Function
#End Region
#Region "Danh_Sach_E1_Truyen"
        ' Ngày tạo: 04/09/2008
        ' Người tạo: Đỗ QUốc Khánh
        ' Nội dung: Lấy E1 từ bảng E1_Di
        ' Input: Id_Chuyen_Thu
        ' Output: DataSet 
        Public Function Danh_Sach_E1_Truyen(ByVal Id_Chuyen_Thu As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Le_Phi_Di_Danh_Sach_E1_Lay_Boi_Id_Chuyen_Thu_Truyen", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)


                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Le_Phi_Di_Danh_Sach_E1_Lay_Boi_Id_Chuyen_Thu_Truyen")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
    End Class
#End Region
End Namespace

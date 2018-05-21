Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Tính Cước quốc tế chi tiết"
    Public Class Tinh_Cuoc_Chi_Tiet
        '*******************************************************
        ' Mỗi thuộc tính của lớp Cuoc_QT_Chi_Tiet
        ' tương ứng với mỗi giá trị cước
        '
        '*******************************************************
        Public Cuoc_CS As Integer 'Cước tính theo bảng cước hiện hành
        Public Cuoc_Chinh As Integer 'Cước tính bao gồm cả phụ phí xăng dầu, phụ phí vùng xa
        Public Cuoc_Dich_Vu As Integer
        Public Cong_Phat As Integer
        Public Cong_Chap_Nhan As Integer
        Public PPXD As Double
        Public Cuoc_PPXD As Integer
        Public Cuoc_PPVX As Integer
        Public Cuoc_COD As Integer
        Public VAT As Double
        Public Ty_Gia As Integer
    End Class
#End Region

    Public Class Tinh_Cuoc
#Region "Tinh_Cuoc"
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "Tính Cước trong nước"
        Public Function Tinh_Cuoc_TN(ByVal MAE1 As String, ByVal Ma_Nuoc_Tra As String, ByVal Ma_Bc_Tra As Integer, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal Ngay_Chap_Nhan As Integer, ByVal Loai_Hang_Hoa As Integer) As Tinh_Cuoc_Chi_Tiet
            Dim myTinh_Cuoc_Chi_Tiet As New Tinh_Cuoc_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tinh_Cuoc_Trong_Nuoc", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMae1 As SqlParameter = New SqlParameter("@v_Mae1", SqlDbType.VarChar, 13)
                pMae1.Value = MAE1
                myCommand.Parameters.Add(pMae1)
                Dim pKhoiluong As SqlParameter = New SqlParameter("@v_Khoiluong", SqlDbType.Int, 12)
                pKhoiluong.Value = Khoi_Luong
                myCommand.Parameters.Add(pKhoiluong)
                Dim pMaBCTra As SqlParameter = New SqlParameter("@v_MaBCTra", SqlDbType.Int, 12)
                pMaBCTra.Value = Ma_Bc_Tra
                myCommand.Parameters.Add(pMaBCTra)
                Dim pPhan_Loai As SqlParameter = New SqlParameter("@v_Phanloai", SqlDbType.VarChar, 1)
                pPhan_Loai.Value = Phan_Loai
                myCommand.Parameters.Add(pPhan_Loai)
                Dim pNgaychapnhan As SqlParameter = New SqlParameter("@v_Ngaychapnhan", SqlDbType.Int, 12)
                pNgaychapnhan.Value = Ngay_Chap_Nhan
                myCommand.Parameters.Add(pNgaychapnhan)

                Dim pThoathuan As SqlParameter = New SqlParameter("@v_thoathuan", SqlDbType.Bit, 1)
                pThoathuan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pThoathuan)

                Dim pCuoc_CS As SqlParameter = New SqlParameter("@v_Cuoc_CS", SqlDbType.Int, 12)
                pCuoc_CS.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_CS)

                Dim pPPXD As SqlParameter = New SqlParameter("@v_ppxd", SqlDbType.Float, 12)
                pPPXD.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pPPXD)

                Dim pVAT As SqlParameter = New SqlParameter("@v_VAT", SqlDbType.Float, 12)
                pVAT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pVAT)

                Dim pCongChapNhan As SqlParameter = New SqlParameter("@v_CongChapNhan", SqlDbType.Int, 12)
                pCongChapNhan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCongChapNhan)

                Dim pCongPhat As SqlParameter = New SqlParameter("@v_CongPhat", SqlDbType.Int, 12)
                pCongPhat.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCongPhat)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                With myTinh_Cuoc_Chi_Tiet
                    .Cuoc_CS = CDbl(pCuoc_CS.Value)
                    .VAT = pVAT.Value
                    .PPXD = pPPXD.Value
                    If Loai_Hang_Hoa = 1 Then 'Hàng nhẹ
                        .Cuoc_Chinh = CLng(pCuoc_CS.Value * (1 + pPPXD.Value / 100) * 1.5)
                        .Cong_Chap_Nhan = CLng(pCongChapNhan.Value * 1.5)
                    Else 'Hàng bình thường và hàng cồng kềnh
                        .Cuoc_Chinh = CLng(pCuoc_CS.Value * (1 + pPPXD.Value / 100))
                        .Cong_Chap_Nhan = pCongChapNhan.Value
                    End If
                    .Cuoc_PPXD = CLng(myTinh_Cuoc_Chi_Tiet.Cuoc_Chinh * (pPPXD.Value / 100))
                    .Ty_Gia = 0
                    .Cuoc_PPVX = 0
                    .Cuoc_Dich_Vu = 0
                    .Cuoc_COD = 0
                    .Cong_Phat = pCongPhat.Value
                End With

            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
            Return myTinh_Cuoc_Chi_Tiet
        End Function
#End Region

#Region "Tính Cước quốc tế"
        Public Function Tinh_Cuoc_QT(ByVal MAE1 As String, ByVal Ma_Nuoc_Tra As String, ByVal Ma_Bc_Tra As Integer, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal PostCode As String, ByVal Ngay_Chap_Nhan As Integer, ByVal Loai_Hang_Hoa As Integer) As Tinh_Cuoc_Chi_Tiet
            Dim myTinh_Cuoc_Chi_Tiet As New Tinh_Cuoc_Chi_Tiet
            If PostCode = "" Then
                PostCode = "KhongCo"
            End If
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tinh_Cuoc_Quoc_Te", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                Dim pMae1 As SqlParameter = New SqlParameter("@v_Mae1", SqlDbType.VarChar, 13)
                pMae1.Value = MAE1
                myCommand.Parameters.Add(pMae1)
                Dim pKhoiluong As SqlParameter = New SqlParameter("@v_Khoiluong", SqlDbType.Int, 12)
                pKhoiluong.Value = Khoi_Luong
                myCommand.Parameters.Add(pKhoiluong)
                Dim pMaNCTra As SqlParameter = New SqlParameter("@v_MaNCTra", SqlDbType.VarChar, 2)
                pMaNCTra.Value = Ma_Nuoc_Tra
                myCommand.Parameters.Add(pMaNCTra)
                Dim pPhan_Loai As SqlParameter = New SqlParameter("@v_Phanloai", SqlDbType.VarChar, 1)
                pPhan_Loai.Value = Phan_Loai
                myCommand.Parameters.Add(pPhan_Loai)
                Dim pPostCode As SqlParameter = New SqlParameter("@v_PostCode", SqlDbType.VarChar, 20)
                pPostCode.Value = PostCode
                myCommand.Parameters.Add(pPostCode)
                Dim pNgaychapnhan As SqlParameter = New SqlParameter("@v_Ngaychapnhan", SqlDbType.Int, 12)
                pNgaychapnhan.Value = Ngay_Chap_Nhan
                myCommand.Parameters.Add(pNgaychapnhan)

                Dim pCuoc_CS As SqlParameter = New SqlParameter("@v_Cuoc_CS", SqlDbType.Float, 12)
                pCuoc_CS.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_CS)

                Dim pPPXD As SqlParameter = New SqlParameter("@v_ppxd", SqlDbType.Float, 12)
                pPPXD.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pPPXD)

                Dim pPPVX As SqlParameter = New SqlParameter("@v_ppvx", SqlDbType.Float, 12)
                pPPVX.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pPPVX)

                Dim pVAT As SqlParameter = New SqlParameter("@v_VAT", SqlDbType.Float, 12)
                pVAT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pVAT)

                Dim pTyGia As SqlParameter = New SqlParameter("@v_TyGia", SqlDbType.Int, 12)
                pTyGia.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTyGia)

                Dim pCongChapNhan As SqlParameter = New SqlParameter("@v_CongChapNhan", SqlDbType.Int, 12)
                pCongChapNhan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCongChapNhan)

                Dim pCongPhat As SqlParameter = New SqlParameter("@v_CongPhat", SqlDbType.Int, 12)
                pCongPhat.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCongPhat)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                With myTinh_Cuoc_Chi_Tiet
                    .Cuoc_CS = pCuoc_CS.Value * pTyGia.Value
                    .VAT = pVAT.Value
                    .PPXD = pPPXD.Value
                    .Ty_Gia = pTyGia.Value

                    .Cuoc_PPVX = CLng(pPPVX.Value * pTyGia.Value)
                    If Loai_Hang_Hoa = 1 Then 'Hàng nhẹ
                        .Cuoc_Chinh = CLng((pCuoc_CS.Value * (1 + pPPXD.Value / 100) + pPPVX.Value) * pTyGia.Value * 1.5)
                        .Cong_Chap_Nhan = CLng(pCongChapNhan.Value * 1.5)
                    Else 'Hàng bình thường và hàng cồng kềnh
                        .Cuoc_Chinh = CLng(pCuoc_CS.Value * (1 + pPPXD.Value / 100))
                        .Cong_Chap_Nhan = pCongChapNhan.Value
                    End If
                    .Cuoc_PPXD = CLng(myTinh_Cuoc_Chi_Tiet.Cuoc_Chinh * (pPPXD.Value / 100) * pTyGia.Value)
                    .Cuoc_Dich_Vu = 0
                    .Cuoc_COD = 0
                    .Cong_Phat = pCongPhat.Value
                End With

            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
            Return myTinh_Cuoc_Chi_Tiet
        End Function
#End Region

#Region "Tính công phát"
        Public Function Tinh_Cong_Phat(ByVal MAE1 As String, ByVal Ma_Nuoc_Tra As String, ByVal Ma_Bc_Tra As Integer, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal Ngay_Chap_Nhan As Integer) As Integer
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tinh_Cong_Phat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                Dim pMae1 As SqlParameter = New SqlParameter("@v_Mae1", SqlDbType.VarChar, 13)
                pMae1.Value = MAE1
                myCommand.Parameters.Add(pMae1)
                Dim pKhoiluong As SqlParameter = New SqlParameter("@v_Khoiluong", SqlDbType.Int, 12)
                pKhoiluong.Value = Khoi_Luong
                myCommand.Parameters.Add(pKhoiluong)
                Dim pMaBCTra As SqlParameter = New SqlParameter("@v_MaBCTra", SqlDbType.Int, 12)
                pMaBCTra.Value = Ma_Bc_Tra
                myCommand.Parameters.Add(pMaBCTra)
                Dim pPhan_Loai As SqlParameter = New SqlParameter("@v_Phanloai", SqlDbType.VarChar, 1)
                pPhan_Loai.Value = Phan_Loai
                myCommand.Parameters.Add(pPhan_Loai)
                Dim pNgaychapnhan As SqlParameter = New SqlParameter("@v_Ngaychapnhan", SqlDbType.Int, 12)
                pNgaychapnhan.Value = Ngay_Chap_Nhan
                myCommand.Parameters.Add(pNgaychapnhan)

                Dim pCongPhat As SqlParameter = New SqlParameter("@v_CongPhat", SqlDbType.Int, 12)
                pCongPhat.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCongPhat)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()

                Return pCongPhat.Value
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Tính Cước"
        Public Function Tinh_Cuoc(ByVal MAE1 As String, ByVal Ma_Nuoc_Tra As String, ByVal Ma_Bc_Tra As Integer, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal PostCode As String, ByVal Ngay_Chap_Nhan As Integer, ByVal Loai_Hang_Hoa As Integer) As Tinh_Cuoc_Chi_Tiet
            Dim myTinh_Cuoc_Chi_Tiet As New Tinh_Cuoc_Chi_Tiet
            If PostCode = "" Then
                PostCode = "KhongCo"
            End If
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tinh_Cuoc", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                Dim pMae1 As SqlParameter = New SqlParameter("@v_Mae1", SqlDbType.VarChar, 13)
                pMae1.Value = MAE1
                myCommand.Parameters.Add(pMae1)
                Dim pKhoiluong As SqlParameter = New SqlParameter("@v_Khoiluong", SqlDbType.Int, 12)
                pKhoiluong.Value = Khoi_Luong
                myCommand.Parameters.Add(pKhoiluong)
                Dim pMaNCTra As SqlParameter = New SqlParameter("@v_MaNCTra", SqlDbType.VarChar, 2)
                pMaNCTra.Value = Ma_Nuoc_Tra
                myCommand.Parameters.Add(pMaNCTra)
                Dim pMaBCTra As SqlParameter = New SqlParameter("@v_MaBCTra", SqlDbType.Int, 12)
                pMaBCTra.Value = Ma_Bc_Tra
                myCommand.Parameters.Add(pMaBCTra)
                Dim pPhan_Loai As SqlParameter = New SqlParameter("@v_Phanloai", SqlDbType.VarChar, 1)
                pPhan_Loai.Value = Phan_Loai
                myCommand.Parameters.Add(pPhan_Loai)
                Dim pPostCode As SqlParameter = New SqlParameter("@v_PostCode", SqlDbType.VarChar, 20)
                pPostCode.Value = PostCode
                myCommand.Parameters.Add(pPostCode)
                Dim pNgaychapnhan As SqlParameter = New SqlParameter("@v_Ngaychapnhan", SqlDbType.Int, 12)
                pNgaychapnhan.Value = Ngay_Chap_Nhan
                myCommand.Parameters.Add(pNgaychapnhan)
                Dim pLamTronTN As SqlParameter = New SqlParameter("@v_LamTronTN", SqlDbType.Int, 12)
                pLamTronTN.Value = 1
                myCommand.Parameters.Add(pLamTronTN)
                Dim pLamTronQT As SqlParameter = New SqlParameter("@v_LamTronQT", SqlDbType.Int, 12)
                pLamTronQT.Value = 100
                myCommand.Parameters.Add(pLamTronQT)

                Dim pThoaThuan As SqlParameter = New SqlParameter("@v_ThoaThuan", SqlDbType.Bit, 1)
                pThoaThuan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pThoaThuan)

                Dim pCuoc_CS As SqlParameter = New SqlParameter("@v_Cuoc_CS", SqlDbType.Int, 12)
                pCuoc_CS.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_CS)

                Dim pPPXD As SqlParameter = New SqlParameter("@v_ppxd", SqlDbType.Float, 12)
                pPPXD.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pPPXD)

                Dim pCuoc_PPXD As SqlParameter = New SqlParameter("@v_Cuoc_ppxd", SqlDbType.Int, 12)
                pCuoc_PPXD.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_PPXD)

                Dim pCuoc_PPVX As SqlParameter = New SqlParameter("@v_Cuoc_PPVX", SqlDbType.Int, 12)
                pCuoc_PPVX.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_PPVX)

                Dim pCuoc_Chinh As SqlParameter = New SqlParameter("@v_Cuoc_Chinh", SqlDbType.Int, 12)
                pCuoc_Chinh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_Chinh)

                Dim pVAT As SqlParameter = New SqlParameter("@v_VAT", SqlDbType.Float, 12)
                pVAT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pVAT)

                Dim pTyGia As SqlParameter = New SqlParameter("@v_TyGia", SqlDbType.Int, 12)
                pTyGia.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTyGia)

                Dim pCongChapNhan As SqlParameter = New SqlParameter("@v_CongChapNhan", SqlDbType.Int, 12)
                pCongChapNhan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCongChapNhan)

                Dim pCongPhat As SqlParameter = New SqlParameter("@v_CongPhat", SqlDbType.Int, 12)
                pCongPhat.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCongPhat)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                With myTinh_Cuoc_Chi_Tiet
                    .Cuoc_CS = pCuoc_CS.Value
                    .Cuoc_Chinh = pCuoc_Chinh.Value
                    .Cuoc_Dich_Vu = 0
                    .Cong_Phat = pCongPhat.Value
                    .Cong_Chap_Nhan = pCongChapNhan.Value
                    .PPXD = pPPXD.Value
                    .Cuoc_PPXD = pCuoc_PPXD.Value
                    .Cuoc_PPVX = pCuoc_PPVX.Value
                    .Cuoc_COD = 0
                    .VAT = pVAT.Value
                    .Ty_Gia = pTyGia.Value


                    '.Cuoc_CS = pCuoc_CS.Value * pTyGia.Value
                    '.VAT = pVAT.Value
                    '.PPXD = pPPXD.Value
                    '.Ty_Gia = pTyGia.Value

                    '.Cuoc_PPVX = CLng(pCuoc_PPVX.Value * pTyGia.Value)
                    'If Loai_Hang_Hoa = 1 Then 'Hàng nhẹ
                    '    .Cuoc_Chinh = CLng((pCuoc_CS.Value * (1 + pPPXD.Value / 100) + pCuoc_PPVX.Value) * pTyGia.Value * 1.5)
                    '    .Cong_Chap_Nhan = CLng(pCongChapNhan.Value * 1.5)
                    'Else 'Hàng bình thường và hàng cồng kềnh
                    '    .Cuoc_Chinh = CLng(pCuoc_CS.Value * (1 + pPPXD.Value / 100))
                    '    .Cong_Chap_Nhan = pCongChapNhan.Value
                    'End If
                    '.Cuoc_PPXD = CLng(myTinh_Cuoc_Chi_Tiet.Cuoc_Chinh * (pPPXD.Value / 100) * pTyGia.Value)
                    '.Cuoc_Dich_Vu = 0
                    '.Cuoc_COD = 0
                    '.Cong_Phat = pCongPhat.Value
                End With

            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
            Return myTinh_Cuoc_Chi_Tiet
        End Function
#End Region

#Region "Tính Cước TCT"
        Public Function Tinh_Cuoc_TCT(ByVal Ngay_Gui As Integer, ByVal Gia_Tri As Integer) As Integer

            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tinh_Cuoc_TCT", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pNgay_Gui As SqlParameter = New SqlParameter("@Ngay_Gui", SqlDbType.Int)
                pNgay_Gui.Value = Ngay_Gui
                myCommand.Parameters.Add(pNgay_Gui)
                Dim pGia_Tri As SqlParameter = New SqlParameter("@Gia_Tri", SqlDbType.Int)
                pGia_Tri.Value = Gia_Tri
                myCommand.Parameters.Add(pGia_Tri)

                Dim pCuoc_TCT As SqlParameter = New SqlParameter("@Cuoc_TCT", SqlDbType.Int)
                pCuoc_TCT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_TCT)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                'Gia tri TCT = 1/2 muc gia TCT binh thuong
                Return Convert.ToInt32(pCuoc_TCT.Value) / 2

            Catch ex As Exception
                Return 0
                Console.Write(ex.ToString)
            End Try

        End Function
#End Region

#Region "Cuoc_DV_Cong_Them"
        Public Function Cuoc_DV_Cong_Them(ByVal To_Hop_Ma As String, ByVal Ngay_Gui As Integer) As Integer
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_DV_Cong_Them_E1", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                Dim pTo_Hop_Ma As SqlParameter = New SqlParameter("@To_Hop_Ma", SqlDbType.VarChar, 50)
                pTo_Hop_Ma.Value = To_Hop_Ma
                myCommand.Parameters.Add(pTo_Hop_Ma)

                Dim pNgay_Gui As SqlParameter = New SqlParameter("@Ngay_Gui", SqlDbType.Int, 4)
                pNgay_Gui.Value = Ngay_Gui
                myCommand.Parameters.Add(pNgay_Gui)

                Dim pCuoc_DV As SqlParameter = New SqlParameter("@Cuoc_DV", SqlDbType.Int, 4)
                pCuoc_DV.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_DV)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()

                Return pCuoc_DV.Value
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Cuoc_DV_Gia_Tang"
        Public Function Cuoc_DV_Gia_Tang(ByVal Ma_Bc_Goc As Integer, ByVal Ma_Bc_Tra As Integer, ByVal Dv_Gia_Tang As String, ByVal Khoi_Luong As Integer, ByVal Ngay_Gui As Integer) As Integer
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_DV_Gia_Tang_E1", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 4)
                pMa_Bc_Goc.Value = Ma_Bc_Goc
                myCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 4)
                pMa_Bc_Tra.Value = Ma_Bc_Tra
                myCommand.Parameters.Add(pMa_Bc_Tra)

                Dim pDv_Gia_Tang As SqlParameter = New SqlParameter("@Dv_Gia_Tang", SqlDbType.VarChar, 50)
                pDv_Gia_Tang.Value = Dv_Gia_Tang
                myCommand.Parameters.Add(pDv_Gia_Tang)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Value = Khoi_Luong
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pNgay_Gui As SqlParameter = New SqlParameter("@Ngay_Gui", SqlDbType.Int, 4)
                pNgay_Gui.Value = Ngay_Gui
                myCommand.Parameters.Add(pNgay_Gui)

                Dim pCuoc_DV As SqlParameter = New SqlParameter("@Cuoc_DV", SqlDbType.Int, 4)
                pCuoc_DV.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_DV)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()

                Return pCuoc_DV.Value
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "HH_Phat_Tra"
        Public Function HH_Phat_Tra(ByVal Ma_Bc_Goc As Integer, ByVal Nuoc_Nhan As String, ByVal Ma_Bc_Tra As Integer, ByVal Nuoc_Tra As String, ByVal Khoi_Luong As Integer, ByVal Loai As Integer, ByVal Ngay_Gui As Integer) As Integer
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Hoa_Hong_Phat_Tra_E1", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 4)
                pMa_Bc_Goc.Value = Ma_Bc_Goc
                myCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Value = Nuoc_Nhan
                myCommand.Parameters.Add(pNuoc_Nhan)

                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 4)
                pMa_Bc_Tra.Value = Ma_Bc_Tra
                myCommand.Parameters.Add(pMa_Bc_Tra)

                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2)
                pNuoc_Tra.Value = Nuoc_Tra
                myCommand.Parameters.Add(pNuoc_Tra)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Value = Khoi_Luong
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pLoai As SqlParameter = New SqlParameter("@Loai", SqlDbType.Int, 4)
                pLoai.Value = Loai
                myCommand.Parameters.Add(pLoai)

                Dim pNgay_Gui As SqlParameter = New SqlParameter("@Ngay_Gui", SqlDbType.Int, 4)
                pNgay_Gui.Value = Ngay_Gui
                myCommand.Parameters.Add(pNgay_Gui)

                Dim pCuoc_Phat_Tra As SqlParameter = New SqlParameter("@Cuoc_Phat_Tra", SqlDbType.Int, 4)
                pCuoc_Phat_Tra.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_Phat_Tra)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()

                Return pCuoc_Phat_Tra.Value
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "HH_Phat_Hanh"
        Public Function HH_Phat_Hanh(ByVal Ma_Bc_Goc As Integer, ByVal Ma_Bc_Tra As Integer, ByVal Loai As Integer, ByVal Ngay_Gui As Integer) As Double
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Phan_Tram_Hoa_Hong_Phat_Hanh_E1", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 4)
                pMa_Bc_Goc.Value = Ma_Bc_Goc
                myCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 4)
                pMa_Bc_Tra.Value = Ma_Bc_Tra
                myCommand.Parameters.Add(pMa_Bc_Tra)

                Dim pNgay_Gui As SqlParameter = New SqlParameter("@Ngay_Gui", SqlDbType.Int, 4)
                pNgay_Gui.Value = Ngay_Gui
                myCommand.Parameters.Add(pNgay_Gui)

                Dim pPhan_Tram_Phat_Hanh As SqlParameter = New SqlParameter("@Phan_Tram_Phat_Hanh", SqlDbType.Float)
                pPhan_Tram_Phat_Hanh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pPhan_Tram_Phat_Hanh)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()

                Return pPhan_Tram_Phat_Hanh.Value
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Cuoc_E1-Cuoc_Chinh"
        Public Function Cuoc_Chinh_E1(ByVal Ma_Bc_Goc As Integer, ByVal Nuoc_Nhan As String, ByVal Ma_Bc_Tra As Integer, ByVal Nuoc_Tra As String, ByVal PostCode As String, ByVal Phan_Loai_BP As String, ByVal Khoi_Luong As Integer, ByVal Ngay_Gui As Integer, ByVal Loai As Integer) As Double
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_E1", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 4)
                pMa_Bc_Goc.Value = Ma_Bc_Goc
                myCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Value = Nuoc_Nhan
                myCommand.Parameters.Add(pNuoc_Nhan)

                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 4)
                pMa_Bc_Tra.Value = Ma_Bc_Tra
                myCommand.Parameters.Add(pMa_Bc_Tra)

                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2)
                pNuoc_Tra.Value = Nuoc_Tra
                myCommand.Parameters.Add(pNuoc_Tra)

                Dim pPostCode As SqlParameter = New SqlParameter("@PostCode", SqlDbType.VarChar, 50)
                pPostCode.Value = PostCode
                myCommand.Parameters.Add(pPostCode)

                Dim pPhan_Loai_BP As SqlParameter = New SqlParameter("@Phan_Loai_BP", SqlDbType.VarChar, 1)
                pPhan_Loai_BP.Value = Phan_Loai_BP
                myCommand.Parameters.Add(pPhan_Loai_BP)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Value = Khoi_Luong
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pNgay_Gui As SqlParameter = New SqlParameter("@Ngay_Gui", SqlDbType.Int, 4)
                pNgay_Gui.Value = Ngay_Gui
                myCommand.Parameters.Add(pNgay_Gui)

                Dim pLoai As SqlParameter = New SqlParameter("@Loai", SqlDbType.Int, 4)
                pLoai.Value = Loai
                myCommand.Parameters.Add(pLoai)

                Dim pCuoc_Chinh_E1 As SqlParameter = New SqlParameter("@Cuoc_Chinh_E1", SqlDbType.Float)
                pCuoc_Chinh_E1.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_Chinh_E1)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()

                Return pCuoc_Chinh_E1.Value
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#End Region

    End Class
End Namespace
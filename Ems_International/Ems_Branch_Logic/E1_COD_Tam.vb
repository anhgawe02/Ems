
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "E1_COD_Tam_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp E1_COD_Tam_Chi_Tiet
    ' tương ứng với mộ trường của bảng E1_COD_Tam trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class E1_COD_Tam_Chi_Tiet
        Public Id_E1 As String ' Mã Id_E1
        Public Ma_Bc_Khai_Thac As Integer ' Mã bưu cục khai thác
        Public Ma_Quay As Integer ' Mã quầy giao dịch
        Public Ma_E1 As String ' Mã số hiệu vận đơn E1
        Public Ngay_Phat_Hanh As Integer ' Ngày phát hành bưu phẩm
        Public Gio_Phat_Hanh As Integer ' Giờ phát hành bưu phẩm
        Public Ma_Don_Vi As String ' Mã đơn vị
        Public Ma_Bc_Goc As Integer ' Mã bưu cục nhận
        Public Ma_Bc_Tra As Integer ' Mã bưu cục trả
        Public Dv_Thu_Ho As String ' Mã dịch vụ cộng thêm : các mã dv cách nhau dấu phẩy
        Public Gia_Tri_Hang As Integer ' Giá trị tiền hàng
        Public Cuoc_Thu_Ho As Integer ' Cước người nhận phải trả (ngoài giá trị)
        Public Cuoc_Chinh As Integer ' Cước chính
        Public Ma_KH As String ' Mã Khách hàng
        Public Nguoi_Gui As String ' Họ tên người gửi
        Public Nguoi_Nhan As String ' Họ tên Người nhận
        Public Dia_Chi_Gui As String ' Địa chỉ người gửi
        Public Dia_Chi_Nhan As String ' Địa chỉ người nhận
        Public Dien_Thoai_Gui As String ' Điện thoại người gửi
        Public Dien_Thoai_Nhan As String ' Điện thoại người nhận
        Public Ghi_Chu As String ' ghi chú dịch vụ
        Public Ngay_He_Thong As Integer ' Ngày hệ thống
        Public Ma_COD1 As String ' Mã COD
        Public Nguoi_Thu_Huong As String
        Public Dia_Chi_Thu_Huong As String
        Public Dien_Thoai_Thu_Huong As String
        Public Da_Lay As Boolean ' 0 : chưa lấy, 1 : Đã lấy
        Public Cuoc_CP_Thu_Tai As Boolean ' 0: Thu tại người gửi , 1 : thu tại người nhận
        Public Cuoc_TC_Thu_Tai As Boolean ' 0: Thu tại người gửi , 1 : thu tại người nhận
        Public Cuoc_Cong_Them_CP As Integer ' Cước cộng thêm Cước Phát
        Public Cuoc_Cong_Them_TC As Integer ' Cước cộng thêm Thu Chi
        Public So_Sanh_Cuoc As Boolean ' 0: Bằng nhau, 1 : Chênh lệch
        Public Cuoc_TC_PayPost As Integer ' Cước TC do PayPost tính
        Public Id_Ca As String
    End Class
#End Region
#Region "E1_COD_Tam"
    Public Class E1_COD_Tam
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng E1_COD_Tam
        ' Input: Id_E1
        ' Output: E1_COD_Tam_Chi_Tiet
        Public Function Lay(ByVal Id_E1 As String) As E1_COD_Tam_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_COD_Tam_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                myCommand.Parameters.Add(pId_E1)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Quay As SqlParameter = New SqlParameter("@Ma_Quay", SqlDbType.Int, 4)
                pMa_Quay.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Quay)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_E1)

                Dim pNgay_Phat_Hanh As SqlParameter = New SqlParameter("@Ngay_Phat_Hanh", SqlDbType.Int, 4)
                pNgay_Phat_Hanh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_Phat_Hanh)

                Dim pGio_Phat_Hanh As SqlParameter = New SqlParameter("@Gio_Phat_Hanh", SqlDbType.Int, 4)
                pGio_Phat_Hanh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGio_Phat_Hanh)

                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
                pMa_Don_Vi.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Don_Vi)

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 4)
                pMa_Bc_Goc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 4)
                pMa_Bc_Tra.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_Tra)

                Dim pDv_Thu_Ho As SqlParameter = New SqlParameter("@Dv_Thu_Ho", SqlDbType.VarChar, 50)
                pDv_Thu_Ho.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDv_Thu_Ho)

                Dim pGia_Tri_Hang As SqlParameter = New SqlParameter("@Gia_Tri_Hang", SqlDbType.Int, 4)
                pGia_Tri_Hang.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGia_Tri_Hang)

                Dim pCuoc_Thu_Ho As SqlParameter = New SqlParameter("@Cuoc_Thu_Ho", SqlDbType.Int, 4)
                pCuoc_Thu_Ho.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_Thu_Ho)

                Dim pCuoc_Chinh As SqlParameter = New SqlParameter("@Cuoc_Chinh", SqlDbType.Int, 4)
                pCuoc_Chinh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_Chinh)

                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_KH)

                Dim pNguoi_Gui As SqlParameter = New SqlParameter("@Nguoi_Gui", SqlDbType.NVarChar, 100)
                pNguoi_Gui.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNguoi_Gui)

                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.NVarChar, 100)
                pNguoi_Nhan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNguoi_Nhan)

                Dim pDia_Chi_Gui As SqlParameter = New SqlParameter("@Dia_Chi_Gui", SqlDbType.NVarChar, 200)
                pDia_Chi_Gui.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDia_Chi_Gui)

                Dim pDia_Chi_Nhan As SqlParameter = New SqlParameter("@Dia_Chi_Nhan", SqlDbType.NVarChar, 200)
                pDia_Chi_Nhan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDia_Chi_Nhan)

                Dim pDien_Thoai_Gui As SqlParameter = New SqlParameter("@Dien_Thoai_Gui", SqlDbType.VarChar, 50)
                pDien_Thoai_Gui.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDien_Thoai_Gui)

                Dim pDien_Thoai_Nhan As SqlParameter = New SqlParameter("@Dien_Thoai_Nhan", SqlDbType.VarChar, 50)
                pDien_Thoai_Nhan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDien_Thoai_Nhan)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 200)
                pGhi_Chu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGhi_Chu)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pMa_COD1 As SqlParameter = New SqlParameter("@Ma_COD1", SqlDbType.VarChar, 15)
                pMa_COD1.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_COD1)

                Dim pNguoi_Thu_Huong As SqlParameter = New SqlParameter("@Nguoi_Thu_Huong", SqlDbType.NVarChar, 100)
                pNguoi_Thu_Huong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNguoi_Thu_Huong)

                Dim pDia_Chi_Thu_Huong As SqlParameter = New SqlParameter("@Dia_Chi_Thu_Huong", SqlDbType.NVarChar, 100)
                pDia_Chi_Thu_Huong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDia_Chi_Thu_Huong)

                Dim pDien_Thoai_Thu_Huong As SqlParameter = New SqlParameter("@Dien_Thoai_Thu_Huong", SqlDbType.VarChar, 50)
                pDien_Thoai_Thu_Huong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDien_Thoai_Thu_Huong)

                Dim pDa_Lay As SqlParameter = New SqlParameter("@Da_Lay", SqlDbType.Bit, 1)
                pDa_Lay.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDa_Lay)

                Dim pCuoc_CP_Thu_Tai As SqlParameter = New SqlParameter("@Cuoc_CP_Thu_Tai", SqlDbType.Bit, 1)
                pCuoc_CP_Thu_Tai.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_CP_Thu_Tai)

                Dim pCuoc_TC_Thu_Tai As SqlParameter = New SqlParameter("@Cuoc_TC_Thu_Tai", SqlDbType.Bit, 1)
                pCuoc_TC_Thu_Tai.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_TC_Thu_Tai)

                Dim pCuoc_Cong_Them_CP As SqlParameter = New SqlParameter("@Cuoc_Cong_Them_CP", SqlDbType.Int, 4)
                pCuoc_Cong_Them_CP.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_Cong_Them_CP)

                Dim pCuoc_Cong_Them_TC As SqlParameter = New SqlParameter("@Cuoc_Cong_Them_TC", SqlDbType.Int, 4)
                pCuoc_Cong_Them_TC.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_Cong_Them_TC)

                Dim pSo_Sanh_Cuoc As SqlParameter = New SqlParameter("@So_Sanh_Cuoc", SqlDbType.Bit, 1)
                pSo_Sanh_Cuoc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSo_Sanh_Cuoc)

                Dim pCuoc_TC_PayPost As SqlParameter = New SqlParameter("@Cuoc_TC_PayPost", SqlDbType.Int, 4)
                pCuoc_TC_PayPost.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_TC_PayPost)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Ca)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myE1_COD_Tam_Chi_Tiet As E1_COD_Tam_Chi_Tiet = New E1_COD_Tam_Chi_Tiet
                myE1_COD_Tam_Chi_Tiet.Id_E1 = Id_E1
                myE1_COD_Tam_Chi_Tiet.Ma_Bc_Khai_Thac = pMa_Bc_Khai_Thac.Value
                myE1_COD_Tam_Chi_Tiet.Ma_Quay = pMa_Quay.Value
                myE1_COD_Tam_Chi_Tiet.Ma_E1 = pMa_E1.Value
                myE1_COD_Tam_Chi_Tiet.Ngay_Phat_Hanh = pNgay_Phat_Hanh.Value
                myE1_COD_Tam_Chi_Tiet.Gio_Phat_Hanh = pGio_Phat_Hanh.Value
                myE1_COD_Tam_Chi_Tiet.Ma_Don_Vi = pMa_Don_Vi.Value
                myE1_COD_Tam_Chi_Tiet.Ma_Bc_Goc = pMa_Bc_Goc.Value
                myE1_COD_Tam_Chi_Tiet.Ma_Bc_Tra = pMa_Bc_Tra.Value
                myE1_COD_Tam_Chi_Tiet.Dv_Thu_Ho = pDv_Thu_Ho.Value
                myE1_COD_Tam_Chi_Tiet.Gia_Tri_Hang = pGia_Tri_Hang.Value
                myE1_COD_Tam_Chi_Tiet.Cuoc_Thu_Ho = pCuoc_Thu_Ho.Value
                myE1_COD_Tam_Chi_Tiet.Cuoc_Chinh = pCuoc_Chinh.Value
                myE1_COD_Tam_Chi_Tiet.Ma_KH = pMa_KH.Value
                myE1_COD_Tam_Chi_Tiet.Nguoi_Gui = pNguoi_Gui.Value
                myE1_COD_Tam_Chi_Tiet.Nguoi_Nhan = pNguoi_Nhan.Value
                myE1_COD_Tam_Chi_Tiet.Dia_Chi_Gui = pDia_Chi_Gui.Value
                myE1_COD_Tam_Chi_Tiet.Dia_Chi_Nhan = pDia_Chi_Nhan.Value
                myE1_COD_Tam_Chi_Tiet.Dien_Thoai_Gui = pDien_Thoai_Gui.Value
                myE1_COD_Tam_Chi_Tiet.Dien_Thoai_Nhan = pDien_Thoai_Nhan.Value
                myE1_COD_Tam_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value
                myE1_COD_Tam_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myE1_COD_Tam_Chi_Tiet.Ma_COD1 = pMa_COD1.Value
                myE1_COD_Tam_Chi_Tiet.Nguoi_Thu_Huong = pNguoi_Thu_Huong.Value
                myE1_COD_Tam_Chi_Tiet.Dia_Chi_Thu_Huong = pDia_Chi_Thu_Huong.Value
                myE1_COD_Tam_Chi_Tiet.Dien_Thoai_Thu_Huong = pDien_Thoai_Thu_Huong.Value
                myE1_COD_Tam_Chi_Tiet.Da_Lay = pDa_Lay.Value
                myE1_COD_Tam_Chi_Tiet.Cuoc_CP_Thu_Tai = pCuoc_CP_Thu_Tai.Value
                myE1_COD_Tam_Chi_Tiet.Cuoc_TC_Thu_Tai = pCuoc_TC_Thu_Tai.Value
                myE1_COD_Tam_Chi_Tiet.Cuoc_Cong_Them_CP = pCuoc_Cong_Them_CP.Value
                myE1_COD_Tam_Chi_Tiet.Cuoc_Cong_Them_TC = pCuoc_Cong_Them_TC.Value
                myE1_COD_Tam_Chi_Tiet.So_Sanh_Cuoc = pSo_Sanh_Cuoc.Value
                myE1_COD_Tam_Chi_Tiet.Cuoc_TC_PayPost = pCuoc_TC_PayPost.Value
                myE1_COD_Tam_Chi_Tiet.Id_Ca = pId_Ca.Value
                Return myE1_COD_Tam_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Cap_Nhat_Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng E1_COD_Tam
        ' Input: Id_E1,  Ma_Bc_Khai_Thac , Ma_Quay , Ma_E1 , Ngay_Phat_Hanh , Gio_Phat_Hanh , Ma_Don_Vi , Ma_Bc_Goc , Ma_Bc_Tra , Dv_Thu_Ho , Gia_Tri_Hang , Cuoc_Thu_Ho , Cuoc_Chinh , Ma_KH , Nguoi_Gui , Nguoi_Nhan , Dia_Chi_Gui , Dia_Chi_Nhan , Dien_Thoai_Gui , Dien_Thoai_Nhan , Ghi_Chu , Ngay_He_Thong , Ma_COD1 , Nguoi_Thu_Huong , Dia_Chi_Thu_Huong , Dien_Thoai_Thu_Huong , Da_Lay , Cuoc_CP_Thu_Tai , Cuoc_TC_Thu_Tai , Cuoc_Cong_Them_CP , Cuoc_Cong_Them_TC , So_Sanh_Cuoc , Cuoc_TC_PayPost ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Id_E1 As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Quay As Integer, ByVal Ma_E1 As String, ByVal Ngay_Phat_Hanh As Integer, ByVal Gio_Phat_Hanh As Integer, ByVal Ma_Don_Vi As String, ByVal Ma_Bc_Goc As Integer, ByVal Ma_Bc_Tra As Integer, ByVal Dv_Thu_Ho As String, ByVal Gia_Tri_Hang As Integer, ByVal Cuoc_Thu_Ho As Integer, ByVal Cuoc_Chinh As Integer, ByVal Ma_KH As String, ByVal Nguoi_Gui As String, ByVal Nguoi_Nhan As String, ByVal Dia_Chi_Gui As String, ByVal Dia_Chi_Nhan As String, ByVal Dien_Thoai_Gui As String, ByVal Dien_Thoai_Nhan As String, ByVal Ghi_Chu As String, ByVal Ngay_He_Thong As Integer, ByVal Ma_COD1 As String, ByVal Nguoi_Thu_Huong As String, ByVal Dia_Chi_Thu_Huong As String, ByVal Dien_Thoai_Thu_Huong As String, ByVal Da_Lay As Boolean, ByVal Cuoc_CP_Thu_Tai As Boolean, ByVal Cuoc_TC_Thu_Tai As Boolean, ByVal Cuoc_Cong_Them_CP As Integer, ByVal Cuoc_Cong_Them_TC As Integer, ByVal So_Sanh_Cuoc As Boolean, ByVal Cuoc_TC_PayPost As Integer, ByVal Id_Ca As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_COD_Tam_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                myCommand.Parameters.Add(pId_E1)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Quay As SqlParameter = New SqlParameter("@Ma_Quay", SqlDbType.Int, 4)
                pMa_Quay.Value = Ma_Quay
                myCommand.Parameters.Add(pMa_Quay)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pNgay_Phat_Hanh As SqlParameter = New SqlParameter("@Ngay_Phat_Hanh", SqlDbType.Int, 4)
                pNgay_Phat_Hanh.Value = Ngay_Phat_Hanh
                myCommand.Parameters.Add(pNgay_Phat_Hanh)

                Dim pGio_Phat_Hanh As SqlParameter = New SqlParameter("@Gio_Phat_Hanh", SqlDbType.Int, 4)
                pGio_Phat_Hanh.Value = Gio_Phat_Hanh
                myCommand.Parameters.Add(pGio_Phat_Hanh)

                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
                pMa_Don_Vi.Value = Ma_Don_Vi
                myCommand.Parameters.Add(pMa_Don_Vi)

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 4)
                pMa_Bc_Goc.Value = Ma_Bc_Goc
                myCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 4)
                pMa_Bc_Tra.Value = Ma_Bc_Tra
                myCommand.Parameters.Add(pMa_Bc_Tra)

                Dim pDv_Thu_Ho As SqlParameter = New SqlParameter("@Dv_Thu_Ho", SqlDbType.VarChar, 50)
                pDv_Thu_Ho.Value = Dv_Thu_Ho
                myCommand.Parameters.Add(pDv_Thu_Ho)

                Dim pGia_Tri_Hang As SqlParameter = New SqlParameter("@Gia_Tri_Hang", SqlDbType.Int, 4)
                pGia_Tri_Hang.Value = Gia_Tri_Hang
                myCommand.Parameters.Add(pGia_Tri_Hang)

                Dim pCuoc_Thu_Ho As SqlParameter = New SqlParameter("@Cuoc_Thu_Ho", SqlDbType.Int, 4)
                pCuoc_Thu_Ho.Value = Cuoc_Thu_Ho
                myCommand.Parameters.Add(pCuoc_Thu_Ho)

                Dim pCuoc_Chinh As SqlParameter = New SqlParameter("@Cuoc_Chinh", SqlDbType.Int, 4)
                pCuoc_Chinh.Value = Cuoc_Chinh
                myCommand.Parameters.Add(pCuoc_Chinh)

                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Value = Ma_KH
                myCommand.Parameters.Add(pMa_KH)

                Dim pNguoi_Gui As SqlParameter = New SqlParameter("@Nguoi_Gui", SqlDbType.NVarChar, 100)
                pNguoi_Gui.Value = Nguoi_Gui
                myCommand.Parameters.Add(pNguoi_Gui)

                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.NVarChar, 100)
                pNguoi_Nhan.Value = Nguoi_Nhan
                myCommand.Parameters.Add(pNguoi_Nhan)

                Dim pDia_Chi_Gui As SqlParameter = New SqlParameter("@Dia_Chi_Gui", SqlDbType.NVarChar, 200)
                pDia_Chi_Gui.Value = Dia_Chi_Gui
                myCommand.Parameters.Add(pDia_Chi_Gui)

                Dim pDia_Chi_Nhan As SqlParameter = New SqlParameter("@Dia_Chi_Nhan", SqlDbType.NVarChar, 200)
                pDia_Chi_Nhan.Value = Dia_Chi_Nhan
                myCommand.Parameters.Add(pDia_Chi_Nhan)

                Dim pDien_Thoai_Gui As SqlParameter = New SqlParameter("@Dien_Thoai_Gui", SqlDbType.VarChar, 50)
                pDien_Thoai_Gui.Value = Dien_Thoai_Gui
                myCommand.Parameters.Add(pDien_Thoai_Gui)

                Dim pDien_Thoai_Nhan As SqlParameter = New SqlParameter("@Dien_Thoai_Nhan", SqlDbType.VarChar, 50)
                pDien_Thoai_Nhan.Value = Dien_Thoai_Nhan
                myCommand.Parameters.Add(pDien_Thoai_Nhan)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 200)
                pGhi_Chu.Value = Ghi_Chu
                myCommand.Parameters.Add(pGhi_Chu)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Value = Ngay_He_Thong
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pMa_COD1 As SqlParameter = New SqlParameter("@Ma_COD1", SqlDbType.VarChar, 15)
                pMa_COD1.Value = Ma_COD1
                myCommand.Parameters.Add(pMa_COD1)

                Dim pNguoi_Thu_Huong As SqlParameter = New SqlParameter("@Nguoi_Thu_Huong", SqlDbType.NVarChar, 100)
                pNguoi_Thu_Huong.Value = Nguoi_Thu_Huong
                myCommand.Parameters.Add(pNguoi_Thu_Huong)

                Dim pDia_Chi_Thu_Huong As SqlParameter = New SqlParameter("@Dia_Chi_Thu_Huong", SqlDbType.NVarChar, 100)
                pDia_Chi_Thu_Huong.Value = Dia_Chi_Thu_Huong
                myCommand.Parameters.Add(pDia_Chi_Thu_Huong)

                Dim pDien_Thoai_Thu_Huong As SqlParameter = New SqlParameter("@Dien_Thoai_Thu_Huong", SqlDbType.VarChar, 50)
                pDien_Thoai_Thu_Huong.Value = Dien_Thoai_Thu_Huong
                myCommand.Parameters.Add(pDien_Thoai_Thu_Huong)

                Dim pDa_Lay As SqlParameter = New SqlParameter("@Da_Lay", SqlDbType.Bit, 1)
                pDa_Lay.Value = Da_Lay
                myCommand.Parameters.Add(pDa_Lay)

                Dim pCuoc_CP_Thu_Tai As SqlParameter = New SqlParameter("@Cuoc_CP_Thu_Tai", SqlDbType.Bit, 1)
                pCuoc_CP_Thu_Tai.Value = Cuoc_CP_Thu_Tai
                myCommand.Parameters.Add(pCuoc_CP_Thu_Tai)

                Dim pCuoc_TC_Thu_Tai As SqlParameter = New SqlParameter("@Cuoc_TC_Thu_Tai", SqlDbType.Bit, 1)
                pCuoc_TC_Thu_Tai.Value = Cuoc_TC_Thu_Tai
                myCommand.Parameters.Add(pCuoc_TC_Thu_Tai)

                Dim pCuoc_Cong_Them_CP As SqlParameter = New SqlParameter("@Cuoc_Cong_Them_CP", SqlDbType.Int, 4)
                pCuoc_Cong_Them_CP.Value = Cuoc_Cong_Them_CP
                myCommand.Parameters.Add(pCuoc_Cong_Them_CP)

                Dim pCuoc_Cong_Them_TC As SqlParameter = New SqlParameter("@Cuoc_Cong_Them_TC", SqlDbType.Int, 4)
                pCuoc_Cong_Them_TC.Value = Cuoc_Cong_Them_TC
                myCommand.Parameters.Add(pCuoc_Cong_Them_TC)

                Dim pSo_Sanh_Cuoc As SqlParameter = New SqlParameter("@So_Sanh_Cuoc", SqlDbType.Bit, 1)
                pSo_Sanh_Cuoc.Value = So_Sanh_Cuoc
                myCommand.Parameters.Add(pSo_Sanh_Cuoc)

                Dim pCuoc_TC_PayPost As SqlParameter = New SqlParameter("@Cuoc_TC_PayPost", SqlDbType.Int, 4)
                pCuoc_TC_PayPost.Value = Cuoc_TC_PayPost
                myCommand.Parameters.Add(pCuoc_TC_PayPost)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region
#Region "Cap_Nhat_Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng E1_COD_Tam
        ' Input: đối tượng datatable
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal myDataTable As DataTable)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                myConnection.Open()
                Dim i As Integer
                For i = 0 To myDataTable.Rows.Count - 1
                    Dim myCommand As SqlCommand = New SqlCommand("E1_COD_Tam_Cap_Nhat_Them", myConnection)

                    ' Sử dụng Store Procedure
                    myCommand.CommandType = CommandType.StoredProcedure
                    ' Thêm các Parameters vào thủ tục				

                    Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                    pId_E1.Value = Convert.ToString(myDataTable.Rows(i).Item("Id_E1"))
                    myCommand.Parameters.Add(pId_E1)

                    Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                    pMa_Bc_Khai_Thac.Value = Convert.ToInt32(myDataTable.Rows(i).Item("Ma_Bc_Khai_Thac"))
                    myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                    Dim pMa_Quay As SqlParameter = New SqlParameter("@Ma_Quay", SqlDbType.Int, 4)
                    pMa_Quay.Value = Convert.ToInt32(myDataTable.Rows(i).Item("Ma_Quay"))
                    myCommand.Parameters.Add(pMa_Quay)

                    Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                    pMa_E1.Value = Convert.ToString(myDataTable.Rows(i).Item("Ma_E1"))
                    myCommand.Parameters.Add(pMa_E1)

                    Dim pNgay_Phat_Hanh As SqlParameter = New SqlParameter("@Ngay_Phat_Hanh", SqlDbType.Int, 4)
                    pNgay_Phat_Hanh.Value = Convert.ToInt32(myDataTable.Rows(i).Item("Ngay_Phat_Hanh"))
                    myCommand.Parameters.Add(pNgay_Phat_Hanh)

                    Dim pGio_Phat_Hanh As SqlParameter = New SqlParameter("@Gio_Phat_Hanh", SqlDbType.Int, 4)
                    pGio_Phat_Hanh.Value = Convert.ToInt32(myDataTable.Rows(i).Item("Gio_Phat_Hanh"))
                    myCommand.Parameters.Add(pGio_Phat_Hanh)

                    Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
                    pMa_Don_Vi.Value = Convert.ToString(myDataTable.Rows(i).Item("Ma_Don_Vi"))
                    myCommand.Parameters.Add(pMa_Don_Vi)

                    Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 4)
                    pMa_Bc_Goc.Value = Convert.ToInt32(myDataTable.Rows(i).Item("Ma_Bc_Goc"))
                    myCommand.Parameters.Add(pMa_Bc_Goc)

                    Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 4)
                    pMa_Bc_Tra.Value = Convert.ToInt32(myDataTable.Rows(i).Item("Ma_Bc_Tra"))
                    myCommand.Parameters.Add(pMa_Bc_Tra)

                    Dim pDv_Thu_Ho As SqlParameter = New SqlParameter("@Dv_Thu_Ho", SqlDbType.VarChar, 50)
                    pDv_Thu_Ho.Value = Convert.ToString(myDataTable.Rows(i).Item("Dv_Thu_Ho"))
                    myCommand.Parameters.Add(pDv_Thu_Ho)

                    Dim pGia_Tri_Hang As SqlParameter = New SqlParameter("@Gia_Tri_Hang", SqlDbType.Int, 4)
                    pGia_Tri_Hang.Value = Convert.ToInt32(myDataTable.Rows(i).Item("Gia_Tri_Hang"))
                    myCommand.Parameters.Add(pGia_Tri_Hang)

                    Dim pCuoc_Thu_Ho As SqlParameter = New SqlParameter("@Cuoc_Thu_Ho", SqlDbType.Int, 4)
                    pCuoc_Thu_Ho.Value = Convert.ToInt32(myDataTable.Rows(i).Item("Cuoc_Thu_Ho"))
                    myCommand.Parameters.Add(pCuoc_Thu_Ho)

                    Dim pCuoc_Chinh As SqlParameter = New SqlParameter("@Cuoc_Chinh", SqlDbType.Int, 4)
                    pCuoc_Chinh.Value = Convert.ToInt32(myDataTable.Rows(i).Item("Cuoc_Chinh"))
                    myCommand.Parameters.Add(pCuoc_Chinh)

                    Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                    pMa_KH.Value = Convert.ToString(myDataTable.Rows(i).Item("Ma_KH"))
                    myCommand.Parameters.Add(pMa_KH)

                    Dim pNguoi_Gui As SqlParameter = New SqlParameter("@Nguoi_Gui", SqlDbType.NVarChar, 100)
                    pNguoi_Gui.Value = Convert.ToString(myDataTable.Rows(i).Item("Nguoi_Gui"))
                    myCommand.Parameters.Add(pNguoi_Gui)

                    Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.NVarChar, 100)
                    pNguoi_Nhan.Value = Convert.ToString(myDataTable.Rows(i).Item("Nguoi_Nhan"))
                    myCommand.Parameters.Add(pNguoi_Nhan)

                    Dim pDia_Chi_Gui As SqlParameter = New SqlParameter("@Dia_Chi_Gui", SqlDbType.NVarChar, 200)
                    pDia_Chi_Gui.Value = Convert.ToString(myDataTable.Rows(i).Item("Dia_Chi_Gui"))
                    myCommand.Parameters.Add(pDia_Chi_Gui)

                    Dim pDia_Chi_Nhan As SqlParameter = New SqlParameter("@Dia_Chi_Nhan", SqlDbType.NVarChar, 200)
                    pDia_Chi_Nhan.Value = Convert.ToString(myDataTable.Rows(i).Item("Dia_Chi_Nhan"))
                    myCommand.Parameters.Add(pDia_Chi_Nhan)

                    Dim pDien_Thoai_Gui As SqlParameter = New SqlParameter("@Dien_Thoai_Gui", SqlDbType.VarChar, 50)
                    pDien_Thoai_Gui.Value = Convert.ToString(myDataTable.Rows(i).Item("Dien_Thoai_Gui"))
                    myCommand.Parameters.Add(pDien_Thoai_Gui)

                    Dim pDien_Thoai_Nhan As SqlParameter = New SqlParameter("@Dien_Thoai_Nhan", SqlDbType.VarChar, 50)
                    pDien_Thoai_Nhan.Value = Convert.ToString(myDataTable.Rows(i).Item("Dien_Thoai_Nhan"))
                    myCommand.Parameters.Add(pDien_Thoai_Nhan)

                    Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 200)
                    pGhi_Chu.Value = Convert.ToString(myDataTable.Rows(i).Item("Ghi_Chu"))
                    myCommand.Parameters.Add(pGhi_Chu)

                    Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                    pNgay_He_Thong.Value = Convert.ToInt32(myDataTable.Rows(i).Item("Ngay_He_Thong"))
                    myCommand.Parameters.Add(pNgay_He_Thong)

                    Dim pMa_COD1 As SqlParameter = New SqlParameter("@Ma_COD1", SqlDbType.VarChar, 15)
                    pMa_COD1.Value = Convert.ToString(myDataTable.Rows(i).Item("Ma_COD1"))
                    myCommand.Parameters.Add(pMa_COD1)

                    Dim pNguoi_Thu_Huong As SqlParameter = New SqlParameter("@Nguoi_Thu_Huong", SqlDbType.NVarChar, 100)
                    pNguoi_Thu_Huong.Value = Convert.ToString(myDataTable.Rows(i).Item("Nguoi_Thu_Huong"))
                    myCommand.Parameters.Add(pNguoi_Thu_Huong)

                    Dim pDia_Chi_Thu_Huong As SqlParameter = New SqlParameter("@Dia_Chi_Thu_Huong", SqlDbType.NVarChar, 100)
                    pDia_Chi_Thu_Huong.Value = Convert.ToString(myDataTable.Rows(i).Item("Dia_Chi_Thu_Huong"))
                    myCommand.Parameters.Add(pDia_Chi_Thu_Huong)

                    Dim pDien_Thoai_Thu_Huong As SqlParameter = New SqlParameter("@Dien_Thoai_Thu_Huong", SqlDbType.VarChar, 50)
                    pDien_Thoai_Thu_Huong.Value = Convert.ToString(myDataTable.Rows(i).Item("Dien_Thoai_Thu_Huong"))
                    myCommand.Parameters.Add(pDien_Thoai_Thu_Huong)

                    Dim pDa_Lay As SqlParameter = New SqlParameter("@Da_Lay", SqlDbType.Bit, 1)
                    pDa_Lay.Value = Convert.ToBoolean(myDataTable.Rows(i).Item("Da_Lay"))
                    myCommand.Parameters.Add(pDa_Lay)

                    Dim pCuoc_CP_Thu_Tai As SqlParameter = New SqlParameter("@Cuoc_CP_Thu_Tai", SqlDbType.Bit, 1)
                    pCuoc_CP_Thu_Tai.Value = Convert.ToBoolean(myDataTable.Rows(i).Item("Cuoc_CP_Thu_Tai"))
                    myCommand.Parameters.Add(pCuoc_CP_Thu_Tai)

                    Dim pCuoc_TC_Thu_Tai As SqlParameter = New SqlParameter("@Cuoc_TC_Thu_Tai", SqlDbType.Bit, 1)
                    pCuoc_TC_Thu_Tai.Value = Convert.ToBoolean(myDataTable.Rows(i).Item("Cuoc_TC_Thu_Tai"))
                    myCommand.Parameters.Add(pCuoc_TC_Thu_Tai)

                    Dim pCuoc_Cong_Them_CP As SqlParameter = New SqlParameter("@Cuoc_Cong_Them_CP", SqlDbType.Int, 4)
                    pCuoc_Cong_Them_CP.Value = Convert.ToInt32(myDataTable.Rows(i).Item("Cuoc_Cong_Them_CP"))
                    myCommand.Parameters.Add(pCuoc_Cong_Them_CP)

                    Dim pCuoc_Cong_Them_TC As SqlParameter = New SqlParameter("@Cuoc_Cong_Them_TC", SqlDbType.Int, 4)
                    pCuoc_Cong_Them_TC.Value = Convert.ToInt32(myDataTable.Rows(i).Item("Cuoc_Cong_Them_TC"))
                    myCommand.Parameters.Add(pCuoc_Cong_Them_TC)

                    Dim pSo_Sanh_Cuoc As SqlParameter = New SqlParameter("@So_Sanh_Cuoc", SqlDbType.Bit, 1)
                    pSo_Sanh_Cuoc.Value = Convert.ToBoolean(myDataTable.Rows(i).Item("So_Sanh_Cuoc"))
                    myCommand.Parameters.Add(pSo_Sanh_Cuoc)

                    Dim pCuoc_TC_PayPost As SqlParameter = New SqlParameter("@Cuoc_TC_PayPost", SqlDbType.Int, 4)
                    pCuoc_TC_PayPost.Value = Convert.ToInt32(myDataTable.Rows(i).Item("Cuoc_TC_PayPost"))
                    myCommand.Parameters.Add(pCuoc_TC_PayPost)

                    Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.Int, 4)
                    pId_Ca.Value = Convert.ToString(myDataTable.Rows(i).Item("Id_Ca"))
                    myCommand.Parameters.Add(pId_Ca)

                    myCommand.ExecuteNonQuery()
                Next
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region
#Region "Xoa"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng E1_COD_Tam
        ' Input: Id_E1
        ' Output: 
        Public Sub Xoa(ByVal Id_E1 As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_COD_Tam_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                myCommand.Parameters.Add(pId_E1)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)


            End Try
        End Sub
#End Region
#Region "Danh_Sach"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng E1_COD_Tam
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_COD_Tam_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_COD_Tam_Danh_Sach")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

        Public Function Lay_Boi_Ca_San_Xuat_E1_Da_Truyen(ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_COD_Tam_Lay_Boi_Ca_San_Xuat_E1_Da_Truyen", myConnection)
                myCommand.CommandTimeout = 20000
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)


                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E1_COD_Tam_Lay_Boi_Ca_San_Xuat_E1_Da_Truyen") Is Nothing Then
                    myDataSet.Tables("E1_COD_Tam_Lay_Boi_Ca_San_Xuat_E1_Da_Truyen").Clear()
                End If
                myAdapter.Fill(myDataSet, "E1_COD_Tam_Lay_Boi_Ca_San_Xuat_E1_Da_Truyen")

                Return myDataSet.Tables("E1_COD_Tam_Lay_Boi_Ca_San_Xuat_E1_Da_Truyen")

            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function

        Public Function Lay_Boi_Ca_San_Xuat_E1_Chua_Truyen(ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_COD_Tam_Lay_Boi_Ca_San_Xuat_E1_Chua_Truyen", myConnection)
                myCommand.CommandTimeout = 20000
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)


                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E1_COD_Tam_Lay_Boi_Ca_San_Xuat_E1_Chua_Truyen") Is Nothing Then
                    myDataSet.Tables("E1_COD_Tam_Lay_Boi_Ca_San_Xuat_E1_Chua_Truyen").Clear()
                End If
                myAdapter.Fill(myDataSet, "E1_COD_Tam_Lay_Boi_Ca_San_Xuat_E1_Chua_Truyen")

                Return myDataSet.Tables("E1_COD_Tam_Lay_Boi_Ca_San_Xuat_E1_Chua_Truyen")

            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function

        Public Function Lay_Boi_Ca_San_Xuat_E1_Lech_Cuoc(ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_COD_Tam_Lay_Boi_Ca_San_Xuat_E1_Lech_Cuoc", myConnection)
                myCommand.CommandTimeout = 20000
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)


                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E1_COD_Tam_Lay_Boi_Ca_San_Xuat_E1_Lech_Cuoc") Is Nothing Then
                    myDataSet.Tables("E1_COD_Tam_Lay_Boi_Ca_San_Xuat_E1_Lech_Cuoc").Clear()
                End If
                myAdapter.Fill(myDataSet, "E1_COD_Tam_Lay_Boi_Ca_San_Xuat_E1_Lech_Cuoc")

                Return myDataSet.Tables("E1_COD_Tam_Lay_Boi_Ca_San_Xuat_E1_Lech_Cuoc")

            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function

    End Class
#End Region
End Namespace
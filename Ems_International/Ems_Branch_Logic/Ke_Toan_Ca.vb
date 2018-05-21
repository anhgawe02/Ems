
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Ke_Toan_Ca_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Ke_Toan_Ca_Chi_Tiet
    ' tương ứng với mộ trường của bảng Ke_Toan_Ca trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Ke_Toan_Ca_Chi_Tiet
        Public Id_Ca As String ' Id ca kế toán: DDDDDDYYYYMMDDW
        Public Ma_Bc_Khai_Thac As Integer ' Mã bưu cục khai thác
        Public Ngay_Khai_Thac As Integer ' Ngày kế toán
        Public Ca_Khai_Thac As Integer ' Ca kế toán
        Public Tong_So_Den As Integer ' Tổng số BP được xác nhận đến
        Public Tong_So_Di As Integer ' Tổng số BP được đóng đi
        Public Tong_KL_Den As Integer ' Tổng KL BP được xác nhận đến
        Public Tong_KL_Di As Integer ' Tổng KL BP được đóng đi
        Public E1_Den_Nhieu As Integer ' Tổng số E1 đến nhiều
        Public E1_Di_Nhieu As Integer ' Tổng số E1 được đóng đi nhiều lần trong ca
        Public E1_Chenh_Lech_KL As Integer ' Tổng số E1 chênh lệch khối lượng giữa xác nhận đến và đóng đi
        Public E1_Den_Chua_Di As Integer ' Tổng số E1 đã được xác nhận đến mà chưa đóng đi
        Public E1_Di_Chua_Den As Integer ' Tổng số E1 đã được đóng đi mà chưa được xác nhận đến
        Public Chot_Sl As Boolean ' Chốt số liệu sau khi cân đối ca
    End Class
#End Region
#Region "Ke_Toan_Ca"
    Public Class Ke_Toan_Ca
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Ke_Toan_Ca
        ' Input: Id_Ca
        ' Output: Ke_Toan_Ca_Chi_Tiet
        Public Function Lay(ByVal Id_Ca As String) As Ke_Toan_Ca_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ke_Toan_Ca_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pNgay_Khai_Thac As SqlParameter = New SqlParameter("@Ngay_Khai_Thac", SqlDbType.Int, 4)
                pNgay_Khai_Thac.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_Khai_Thac)

                Dim pCa_Khai_Thac As SqlParameter = New SqlParameter("@Ca_Khai_Thac", SqlDbType.Int, 4)
                pCa_Khai_Thac.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCa_Khai_Thac)

                Dim pTong_So_Den As SqlParameter = New SqlParameter("@Tong_So_Den", SqlDbType.Int, 4)
                pTong_So_Den.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTong_So_Den)

                Dim pTong_So_Di As SqlParameter = New SqlParameter("@Tong_So_Di", SqlDbType.Int, 4)
                pTong_So_Di.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTong_So_Di)

                Dim pTong_KL_Den As SqlParameter = New SqlParameter("@Tong_KL_Den", SqlDbType.Int, 4)
                pTong_KL_Den.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTong_KL_Den)

                Dim pTong_KL_Di As SqlParameter = New SqlParameter("@Tong_KL_Di", SqlDbType.Int, 4)
                pTong_KL_Di.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTong_KL_Di)

                Dim pE1_Den_Nhieu As SqlParameter = New SqlParameter("@E1_Den_Nhieu", SqlDbType.Int, 4)
                pE1_Den_Nhieu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pE1_Den_Nhieu)

                Dim pE1_Di_Nhieu As SqlParameter = New SqlParameter("@E1_Di_Nhieu", SqlDbType.Int, 4)
                pE1_Di_Nhieu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pE1_Di_Nhieu)

                Dim pE1_Chenh_Lech_KL As SqlParameter = New SqlParameter("@E1_Chenh_Lech_KL", SqlDbType.Int, 4)
                pE1_Chenh_Lech_KL.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pE1_Chenh_Lech_KL)

                Dim pE1_Den_Chua_Di As SqlParameter = New SqlParameter("@E1_Den_Chua_Di", SqlDbType.Int, 4)
                pE1_Den_Chua_Di.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pE1_Den_Chua_Di)

                Dim pE1_Di_Chua_Den As SqlParameter = New SqlParameter("@E1_Di_Chua_Den", SqlDbType.Int, 4)
                pE1_Di_Chua_Den.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pE1_Di_Chua_Den)

                Dim pChot_Sl As SqlParameter = New SqlParameter("@Chot_Sl", SqlDbType.Bit, 1)
                pChot_Sl.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pChot_Sl)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
                Dim myKe_Toan_Ca_Chi_Tiet As Ke_Toan_Ca_Chi_Tiet = New Ke_Toan_Ca_Chi_Tiet
                myKe_Toan_Ca_Chi_Tiet.Id_Ca = Id_Ca
                myKe_Toan_Ca_Chi_Tiet.Ma_Bc_Khai_Thac = pMa_Bc_Khai_Thac.Value
                myKe_Toan_Ca_Chi_Tiet.Ngay_Khai_Thac = pNgay_Khai_Thac.Value
                myKe_Toan_Ca_Chi_Tiet.Ca_Khai_Thac = pCa_Khai_Thac.Value
                myKe_Toan_Ca_Chi_Tiet.Tong_So_Den = pTong_So_Den.Value
                myKe_Toan_Ca_Chi_Tiet.Tong_So_Di = pTong_So_Di.Value
                myKe_Toan_Ca_Chi_Tiet.Tong_KL_Den = pTong_KL_Den.Value
                myKe_Toan_Ca_Chi_Tiet.Tong_KL_Di = pTong_KL_Di.Value
                myKe_Toan_Ca_Chi_Tiet.E1_Den_Nhieu = pE1_Den_Nhieu.Value
                myKe_Toan_Ca_Chi_Tiet.E1_Di_Nhieu = pE1_Di_Nhieu.Value
                myKe_Toan_Ca_Chi_Tiet.E1_Chenh_Lech_KL = pE1_Chenh_Lech_KL.Value
                myKe_Toan_Ca_Chi_Tiet.E1_Den_Chua_Di = pE1_Den_Chua_Di.Value
                myKe_Toan_Ca_Chi_Tiet.E1_Di_Chua_Den = pE1_Di_Chua_Den.Value
                myKe_Toan_Ca_Chi_Tiet.Chot_Sl = pChot_Sl.Value
                Return myKe_Toan_Ca_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Ke_Toan_Ca
        ' Input:  Ma_Bc_Khai_Thac, Ngay_Khai_Thac, Ca_Khai_Thac, Tong_So_Den, Tong_So_Di, Tong_KL_Den, Tong_KL_Di, E1_Den_Nhieu, E1_Di_Nhieu, E1_Chenh_Lech_KL, E1_Den_Chua_Di, E1_Di_Chua_Den, Chot_Sl,
        ' Output: 
        Public Sub Them(ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ngay_Khai_Thac As Integer, ByVal Ca_Khai_Thac As Integer, ByVal Tong_So_Den As Integer, ByVal Tong_So_Di As Integer, ByVal Tong_KL_Den As Integer, ByVal Tong_KL_Di As Integer, ByVal E1_Den_Nhieu As Integer, ByVal E1_Di_Nhieu As Integer, ByVal E1_Chenh_Lech_KL As Integer, ByVal E1_Den_Chua_Di As Integer, ByVal E1_Di_Chua_Den As Integer, ByVal Chot_Sl As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ke_Toan_Ca_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pNgay_Khai_Thac As SqlParameter = New SqlParameter("@Ngay_Khai_Thac", SqlDbType.Int, 4)
                pNgay_Khai_Thac.Value = Ngay_Khai_Thac
                myCommand.Parameters.Add(pNgay_Khai_Thac)

                Dim pCa_Khai_Thac As SqlParameter = New SqlParameter("@Ca_Khai_Thac", SqlDbType.Int, 4)
                pCa_Khai_Thac.Value = Ca_Khai_Thac
                myCommand.Parameters.Add(pCa_Khai_Thac)

                Dim pTong_So_Den As SqlParameter = New SqlParameter("@Tong_So_Den", SqlDbType.Int, 4)
                pTong_So_Den.Value = Tong_So_Den
                myCommand.Parameters.Add(pTong_So_Den)

                Dim pTong_So_Di As SqlParameter = New SqlParameter("@Tong_So_Di", SqlDbType.Int, 4)
                pTong_So_Di.Value = Tong_So_Di
                myCommand.Parameters.Add(pTong_So_Di)

                Dim pTong_KL_Den As SqlParameter = New SqlParameter("@Tong_KL_Den", SqlDbType.Int, 4)
                pTong_KL_Den.Value = Tong_KL_Den
                myCommand.Parameters.Add(pTong_KL_Den)

                Dim pTong_KL_Di As SqlParameter = New SqlParameter("@Tong_KL_Di", SqlDbType.Int, 4)
                pTong_KL_Di.Value = Tong_KL_Di
                myCommand.Parameters.Add(pTong_KL_Di)

                Dim pE1_Den_Nhieu As SqlParameter = New SqlParameter("@E1_Den_Nhieu", SqlDbType.Int, 4)
                pE1_Den_Nhieu.Value = E1_Den_Nhieu
                myCommand.Parameters.Add(pE1_Den_Nhieu)

                Dim pE1_Di_Nhieu As SqlParameter = New SqlParameter("@E1_Di_Nhieu", SqlDbType.Int, 4)
                pE1_Di_Nhieu.Value = E1_Di_Nhieu
                myCommand.Parameters.Add(pE1_Di_Nhieu)

                Dim pE1_Chenh_Lech_KL As SqlParameter = New SqlParameter("@E1_Chenh_Lech_KL", SqlDbType.Int, 4)
                pE1_Chenh_Lech_KL.Value = E1_Chenh_Lech_KL
                myCommand.Parameters.Add(pE1_Chenh_Lech_KL)

                Dim pE1_Den_Chua_Di As SqlParameter = New SqlParameter("@E1_Den_Chua_Di", SqlDbType.Int, 4)
                pE1_Den_Chua_Di.Value = E1_Den_Chua_Di
                myCommand.Parameters.Add(pE1_Den_Chua_Di)

                Dim pE1_Di_Chua_Den As SqlParameter = New SqlParameter("@E1_Di_Chua_Den", SqlDbType.Int, 4)
                pE1_Di_Chua_Den.Value = E1_Di_Chua_Den
                myCommand.Parameters.Add(pE1_Di_Chua_Den)

                Dim pChot_Sl As SqlParameter = New SqlParameter("@Chot_Sl", SqlDbType.Bit, 1)
                pChot_Sl.Value = Chot_Sl
                myCommand.Parameters.Add(pChot_Sl)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Sub
#End Region
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Ke_Toan_Ca
        ' Input: Id_Ca,  Ma_Bc_Khai_Thac , Ngay_Khai_Thac , Ca_Khai_Thac , Tong_So_Den , Tong_So_Di , Tong_KL_Den , Tong_KL_Di , E1_Den_Nhieu , E1_Di_Nhieu , E1_Chenh_Lech_KL , E1_Den_Chua_Di , E1_Di_Chua_Den , Chot_Sl ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ngay_Khai_Thac As Integer, ByVal Ca_Khai_Thac As Integer, ByVal Tong_So_Den As Integer, ByVal Tong_So_Di As Integer, ByVal Tong_KL_Den As Integer, ByVal Tong_KL_Di As Integer, ByVal E1_Den_Nhieu As Integer, ByVal E1_Di_Nhieu As Integer, ByVal E1_Chenh_Lech_KL As Integer, ByVal E1_Den_Chua_Di As Integer, ByVal E1_Di_Chua_Den As Integer, ByVal Chot_Sl As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ke_Toan_Ca_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pNgay_Khai_Thac As SqlParameter = New SqlParameter("@Ngay_Khai_Thac", SqlDbType.Int, 4)
                pNgay_Khai_Thac.Value = Ngay_Khai_Thac
                myCommand.Parameters.Add(pNgay_Khai_Thac)

                Dim pCa_Khai_Thac As SqlParameter = New SqlParameter("@Ca_Khai_Thac", SqlDbType.Int, 4)
                pCa_Khai_Thac.Value = Ca_Khai_Thac
                myCommand.Parameters.Add(pCa_Khai_Thac)

                Dim pTong_So_Den As SqlParameter = New SqlParameter("@Tong_So_Den", SqlDbType.Int, 4)
                pTong_So_Den.Value = Tong_So_Den
                myCommand.Parameters.Add(pTong_So_Den)

                Dim pTong_So_Di As SqlParameter = New SqlParameter("@Tong_So_Di", SqlDbType.Int, 4)
                pTong_So_Di.Value = Tong_So_Di
                myCommand.Parameters.Add(pTong_So_Di)

                Dim pTong_KL_Den As SqlParameter = New SqlParameter("@Tong_KL_Den", SqlDbType.Int, 4)
                pTong_KL_Den.Value = Tong_KL_Den
                myCommand.Parameters.Add(pTong_KL_Den)

                Dim pTong_KL_Di As SqlParameter = New SqlParameter("@Tong_KL_Di", SqlDbType.Int, 4)
                pTong_KL_Di.Value = Tong_KL_Di
                myCommand.Parameters.Add(pTong_KL_Di)

                Dim pE1_Den_Nhieu As SqlParameter = New SqlParameter("@E1_Den_Nhieu", SqlDbType.Int, 4)
                pE1_Den_Nhieu.Value = E1_Den_Nhieu
                myCommand.Parameters.Add(pE1_Den_Nhieu)

                Dim pE1_Di_Nhieu As SqlParameter = New SqlParameter("@E1_Di_Nhieu", SqlDbType.Int, 4)
                pE1_Di_Nhieu.Value = E1_Di_Nhieu
                myCommand.Parameters.Add(pE1_Di_Nhieu)

                Dim pE1_Chenh_Lech_KL As SqlParameter = New SqlParameter("@E1_Chenh_Lech_KL", SqlDbType.Int, 4)
                pE1_Chenh_Lech_KL.Value = E1_Chenh_Lech_KL
                myCommand.Parameters.Add(pE1_Chenh_Lech_KL)

                Dim pE1_Den_Chua_Di As SqlParameter = New SqlParameter("@E1_Den_Chua_Di", SqlDbType.Int, 4)
                pE1_Den_Chua_Di.Value = E1_Den_Chua_Di
                myCommand.Parameters.Add(pE1_Den_Chua_Di)

                Dim pE1_Di_Chua_Den As SqlParameter = New SqlParameter("@E1_Di_Chua_Den", SqlDbType.Int, 4)
                pE1_Di_Chua_Den.Value = E1_Di_Chua_Den
                myCommand.Parameters.Add(pE1_Di_Chua_Den)

                Dim pChot_Sl As SqlParameter = New SqlParameter("@Chot_Sl", SqlDbType.Bit, 1)
                pChot_Sl.Value = Chot_Sl
                myCommand.Parameters.Add(pChot_Sl)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.toString)
            End Try
        End Sub
#End Region
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Ke_Toan_Ca
        ' Input: đối tượng thuộc lớp Ke_Toan_Ca_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myKe_Toan_Ca_Chi_Tiet As Ke_Toan_Ca_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ke_Toan_Ca_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = myKe_Toan_Ca_Chi_Tiet.Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = myKe_Toan_Ca_Chi_Tiet.Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pNgay_Khai_Thac As SqlParameter = New SqlParameter("@Ngay_Khai_Thac", SqlDbType.Int, 4)
                pNgay_Khai_Thac.Value = myKe_Toan_Ca_Chi_Tiet.Ngay_Khai_Thac
                myCommand.Parameters.Add(pNgay_Khai_Thac)

                Dim pCa_Khai_Thac As SqlParameter = New SqlParameter("@Ca_Khai_Thac", SqlDbType.Int, 4)
                pCa_Khai_Thac.Value = myKe_Toan_Ca_Chi_Tiet.Ca_Khai_Thac
                myCommand.Parameters.Add(pCa_Khai_Thac)

                Dim pTong_So_Den As SqlParameter = New SqlParameter("@Tong_So_Den", SqlDbType.Int, 4)
                pTong_So_Den.Value = myKe_Toan_Ca_Chi_Tiet.Tong_So_Den
                myCommand.Parameters.Add(pTong_So_Den)

                Dim pTong_So_Di As SqlParameter = New SqlParameter("@Tong_So_Di", SqlDbType.Int, 4)
                pTong_So_Di.Value = myKe_Toan_Ca_Chi_Tiet.Tong_So_Di
                myCommand.Parameters.Add(pTong_So_Di)

                Dim pTong_KL_Den As SqlParameter = New SqlParameter("@Tong_KL_Den", SqlDbType.Int, 4)
                pTong_KL_Den.Value = myKe_Toan_Ca_Chi_Tiet.Tong_KL_Den
                myCommand.Parameters.Add(pTong_KL_Den)

                Dim pTong_KL_Di As SqlParameter = New SqlParameter("@Tong_KL_Di", SqlDbType.Int, 4)
                pTong_KL_Di.Value = myKe_Toan_Ca_Chi_Tiet.Tong_KL_Di
                myCommand.Parameters.Add(pTong_KL_Di)

                Dim pE1_Den_Nhieu As SqlParameter = New SqlParameter("@E1_Den_Nhieu", SqlDbType.Int, 4)
                pE1_Den_Nhieu.Value = myKe_Toan_Ca_Chi_Tiet.E1_Den_Nhieu
                myCommand.Parameters.Add(pE1_Den_Nhieu)

                Dim pE1_Di_Nhieu As SqlParameter = New SqlParameter("@E1_Di_Nhieu", SqlDbType.Int, 4)
                pE1_Di_Nhieu.Value = myKe_Toan_Ca_Chi_Tiet.E1_Di_Nhieu
                myCommand.Parameters.Add(pE1_Di_Nhieu)

                Dim pE1_Chenh_Lech_KL As SqlParameter = New SqlParameter("@E1_Chenh_Lech_KL", SqlDbType.Int, 4)
                pE1_Chenh_Lech_KL.Value = myKe_Toan_Ca_Chi_Tiet.E1_Chenh_Lech_KL
                myCommand.Parameters.Add(pE1_Chenh_Lech_KL)

                Dim pE1_Den_Chua_Di As SqlParameter = New SqlParameter("@E1_Den_Chua_Di", SqlDbType.Int, 4)
                pE1_Den_Chua_Di.Value = myKe_Toan_Ca_Chi_Tiet.E1_Den_Chua_Di
                myCommand.Parameters.Add(pE1_Den_Chua_Di)

                Dim pE1_Di_Chua_Den As SqlParameter = New SqlParameter("@E1_Di_Chua_Den", SqlDbType.Int, 4)
                pE1_Di_Chua_Den.Value = myKe_Toan_Ca_Chi_Tiet.E1_Di_Chua_Den
                myCommand.Parameters.Add(pE1_Di_Chua_Den)

                Dim pChot_Sl As SqlParameter = New SqlParameter("@Chot_Sl", SqlDbType.Bit, 1)
                pChot_Sl.Value = myKe_Toan_Ca_Chi_Tiet.Chot_Sl
                myCommand.Parameters.Add(pChot_Sl)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Sub
#End Region
#Region "Cap_Nhat_Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Ke_Toan_Ca
        ' Input: Id_Ca,  Ma_Bc_Khai_Thac , Ngay_Khai_Thac , Ca_Khai_Thac , Tong_So_Den , Tong_So_Di , Tong_KL_Den , Tong_KL_Di , E1_Den_Nhieu , E1_Di_Nhieu , E1_Chenh_Lech_KL , E1_Den_Chua_Di , E1_Di_Chua_Den , Chot_Sl ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ngay_Khai_Thac As Integer, ByVal Ca_Khai_Thac As Integer, ByVal Tong_So_Den As Integer, ByVal Tong_So_Di As Integer, ByVal Tong_KL_Den As Integer, ByVal Tong_KL_Di As Integer, ByVal E1_Den_Nhieu As Integer, ByVal E1_Di_Nhieu As Integer, ByVal E1_Chenh_Lech_KL As Integer, ByVal E1_Den_Chua_Di As Integer, ByVal E1_Di_Chua_Den As Integer, ByVal Chot_Sl As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ke_Toan_Ca_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pNgay_Khai_Thac As SqlParameter = New SqlParameter("@Ngay_Khai_Thac", SqlDbType.Int, 4)
                pNgay_Khai_Thac.Value = Ngay_Khai_Thac
                myCommand.Parameters.Add(pNgay_Khai_Thac)

                Dim pCa_Khai_Thac As SqlParameter = New SqlParameter("@Ca_Khai_Thac", SqlDbType.Int, 4)
                pCa_Khai_Thac.Value = Ca_Khai_Thac
                myCommand.Parameters.Add(pCa_Khai_Thac)

                Dim pTong_So_Den As SqlParameter = New SqlParameter("@Tong_So_Den", SqlDbType.Int, 4)
                pTong_So_Den.Value = Tong_So_Den
                myCommand.Parameters.Add(pTong_So_Den)

                Dim pTong_So_Di As SqlParameter = New SqlParameter("@Tong_So_Di", SqlDbType.Int, 4)
                pTong_So_Di.Value = Tong_So_Di
                myCommand.Parameters.Add(pTong_So_Di)

                Dim pTong_KL_Den As SqlParameter = New SqlParameter("@Tong_KL_Den", SqlDbType.Int, 4)
                pTong_KL_Den.Value = Tong_KL_Den
                myCommand.Parameters.Add(pTong_KL_Den)

                Dim pTong_KL_Di As SqlParameter = New SqlParameter("@Tong_KL_Di", SqlDbType.Int, 4)
                pTong_KL_Di.Value = Tong_KL_Di
                myCommand.Parameters.Add(pTong_KL_Di)

                Dim pE1_Den_Nhieu As SqlParameter = New SqlParameter("@E1_Den_Nhieu", SqlDbType.Int, 4)
                pE1_Den_Nhieu.Value = E1_Den_Nhieu
                myCommand.Parameters.Add(pE1_Den_Nhieu)

                Dim pE1_Di_Nhieu As SqlParameter = New SqlParameter("@E1_Di_Nhieu", SqlDbType.Int, 4)
                pE1_Di_Nhieu.Value = E1_Di_Nhieu
                myCommand.Parameters.Add(pE1_Di_Nhieu)

                Dim pE1_Chenh_Lech_KL As SqlParameter = New SqlParameter("@E1_Chenh_Lech_KL", SqlDbType.Int, 4)
                pE1_Chenh_Lech_KL.Value = E1_Chenh_Lech_KL
                myCommand.Parameters.Add(pE1_Chenh_Lech_KL)

                Dim pE1_Den_Chua_Di As SqlParameter = New SqlParameter("@E1_Den_Chua_Di", SqlDbType.Int, 4)
                pE1_Den_Chua_Di.Value = E1_Den_Chua_Di
                myCommand.Parameters.Add(pE1_Den_Chua_Di)

                Dim pE1_Di_Chua_Den As SqlParameter = New SqlParameter("@E1_Di_Chua_Den", SqlDbType.Int, 4)
                pE1_Di_Chua_Den.Value = E1_Di_Chua_Den
                myCommand.Parameters.Add(pE1_Di_Chua_Den)

                Dim pChot_Sl As SqlParameter = New SqlParameter("@Chot_Sl", SqlDbType.Bit, 1)
                pChot_Sl.Value = Chot_Sl
                myCommand.Parameters.Add(pChot_Sl)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.toString)
            End Try
        End Sub
#End Region
#Region "Dùng trong From Đối soát đi đến - DoTQ"
#Region "Cap_Nhat_Them_Can_Doi_Di_Den"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Ke_Toan_Ca
        ' Input: Id_Ca,  Ma_Bc_Khai_Thac , Ngay_Khai_Thac , Ca_Khai_Thac , Tong_So_Den , Tong_So_Di , Tong_KL_Den , Tong_KL_Di , E1_Den_Nhieu , E1_Di_Nhieu , E1_Chenh_Lech_KL , E1_Den_Chua_Di , E1_Di_Chua_Den , Chot_Sl ,
        ' Output: 
        Public Function Cap_Nhat_Them_Can_Doi_Di_Den(ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ngay_Khai_Thac As Integer, ByVal Ca_Khai_Thac As Integer, ByVal Tong_So_Den As Integer, ByVal Tong_So_Di As Integer, ByVal Tong_KL_Den As Integer, ByVal Tong_KL_Di As Integer, ByVal E1_Den_Nhieu As Integer, ByVal E1_Di_Nhieu As Integer, ByVal E1_Chenh_Lech_KL As Integer, ByVal E1_Den_Chua_Di As Integer, ByVal E1_Di_Chua_Den As Integer, ByVal Chot_Sl As Boolean) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ke_Toan_Ca_Cap_Nhat_Them_Can_Doi_Di_Den", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pNgay_Khai_Thac As SqlParameter = New SqlParameter("@Ngay_Khai_Thac", SqlDbType.Int, 4)
                pNgay_Khai_Thac.Value = Ngay_Khai_Thac
                myCommand.Parameters.Add(pNgay_Khai_Thac)

                Dim pCa_Khai_Thac As SqlParameter = New SqlParameter("@Ca_Khai_Thac", SqlDbType.Int, 4)
                pCa_Khai_Thac.Value = Ca_Khai_Thac
                myCommand.Parameters.Add(pCa_Khai_Thac)

                Dim pTong_So_Den As SqlParameter = New SqlParameter("@Tong_So_Den", SqlDbType.Int, 4)
                pTong_So_Den.Value = Tong_So_Den
                myCommand.Parameters.Add(pTong_So_Den)

                Dim pTong_So_Di As SqlParameter = New SqlParameter("@Tong_So_Di", SqlDbType.Int, 4)
                pTong_So_Di.Value = Tong_So_Di
                myCommand.Parameters.Add(pTong_So_Di)

                Dim pTong_KL_Den As SqlParameter = New SqlParameter("@Tong_KL_Den", SqlDbType.Int, 4)
                pTong_KL_Den.Value = Tong_KL_Den
                myCommand.Parameters.Add(pTong_KL_Den)

                Dim pTong_KL_Di As SqlParameter = New SqlParameter("@Tong_KL_Di", SqlDbType.Int, 4)
                pTong_KL_Di.Value = Tong_KL_Di
                myCommand.Parameters.Add(pTong_KL_Di)

                Dim pE1_Den_Nhieu As SqlParameter = New SqlParameter("@E1_Den_Nhieu", SqlDbType.Int, 4)
                pE1_Den_Nhieu.Value = E1_Den_Nhieu
                myCommand.Parameters.Add(pE1_Den_Nhieu)

                Dim pE1_Di_Nhieu As SqlParameter = New SqlParameter("@E1_Di_Nhieu", SqlDbType.Int, 4)
                pE1_Di_Nhieu.Value = E1_Di_Nhieu
                myCommand.Parameters.Add(pE1_Di_Nhieu)

                Dim pE1_Chenh_Lech_KL As SqlParameter = New SqlParameter("@E1_Chenh_Lech_KL", SqlDbType.Int, 4)
                pE1_Chenh_Lech_KL.Value = E1_Chenh_Lech_KL
                myCommand.Parameters.Add(pE1_Chenh_Lech_KL)

                Dim pE1_Den_Chua_Di As SqlParameter = New SqlParameter("@E1_Den_Chua_Di", SqlDbType.Int, 4)
                pE1_Den_Chua_Di.Value = E1_Den_Chua_Di
                myCommand.Parameters.Add(pE1_Den_Chua_Di)

                Dim pE1_Di_Chua_Den As SqlParameter = New SqlParameter("@E1_Di_Chua_Den", SqlDbType.Int, 4)
                pE1_Di_Chua_Den.Value = E1_Di_Chua_Den
                myCommand.Parameters.Add(pE1_Di_Chua_Den)

                Dim pChot_Sl As SqlParameter = New SqlParameter("@Chot_Sl", SqlDbType.Bit, 1)
                pChot_Sl.Value = Chot_Sl
                myCommand.Parameters.Add(pChot_Sl)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("Ke_Toan_Ca_Cap_Nhat_Them_Can_Doi_Di_Den") Is Nothing Then
                    myDataSet.Tables("Ke_Toan_Ca_Cap_Nhat_Them_Can_Doi_Di_Den").Clear()
                End If
                myAdapter.Fill(myDataSet, "Ke_Toan_Ca_Cap_Nhat_Them_Can_Doi_Di_Den")

                Return myDataSet.Tables("Ke_Toan_Ca_Cap_Nhat_Them_Can_Doi_Di_Den")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Id_Ca"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Ke_Toan_Ca
        ' Input: Id_Ca,  Ma_Bc_Khai_Thac , Ngay_Khai_Thac , Ca_Khai_Thac , Tong_So_Den , Tong_So_Di , Tong_KL_Den , Tong_KL_Di , E1_Den_Nhieu , E1_Di_Nhieu , E1_Chenh_Lech_KL , E1_Den_Chua_Di , E1_Di_Chua_Den , Chot_Sl ,
        ' Output: 
        Public Function Lay_Boi_Id_Ca(ByVal Id_Ca As String) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Lay_Boi_Id_Ca_Can_Doi_Di_Den", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("Lay_Boi_Id_Ca_Can_Doi_Di_Den") Is Nothing Then
                    myDataSet.Tables("Lay_Boi_Id_Ca_Can_Doi_Di_Den").Clear()
                End If
                myAdapter.Fill(myDataSet, "Lay_Boi_Id_Ca_Can_Doi_Di_Den")

                Return myDataSet.Tables("Lay_Boi_Id_Ca_Can_Doi_Di_Den")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Id_Ca_Tu_Ngay_Den_Ngay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Ke_Toan_Ca
        ' Input: Id_Ca,  Ma_Bc_Khai_Thac , Ngay_Khai_Thac , Ca_Khai_Thac , Tong_So_Den , Tong_So_Di , Tong_KL_Den , Tong_KL_Di , E1_Den_Nhieu , E1_Di_Nhieu , E1_Chenh_Lech_KL , E1_Den_Chua_Di , E1_Di_Chua_Den , Chot_Sl ,
        ' Output: 
        Public Function Lay_Boi_Id_Ca_Tu_Ngay_Den_Ngay(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_BC_Khai_Thac As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Lay_Boi_Id_Ca_Can_Doi_Di_Den_Tu_Ngay_Den_Ngay", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca_Tu_Ngay As SqlParameter = New SqlParameter("@Id_Ca_Tu_Ngay", SqlDbType.Int)
                pId_Ca_Tu_Ngay.Value = Id_Ca_Tu_Ngay
                myCommand.Parameters.Add(pId_Ca_Tu_Ngay)

                Dim pId_Ca_Den_Ngay As SqlParameter = New SqlParameter("@Id_Ca_Den_Ngay", SqlDbType.Int)
                pId_Ca_Den_Ngay.Value = Id_Ca_Den_Ngay
                myCommand.Parameters.Add(pId_Ca_Den_Ngay)

                Dim pMa_BC_Khai_Thac As SqlParameter = New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int)
                pMa_BC_Khai_Thac.Value = Ma_BC_Khai_Thac
                myCommand.Parameters.Add(pMa_BC_Khai_Thac)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("Lay_Boi_Id_Ca_Can_Doi_Di_Den_Tu_Ngay_Den_Ngay") Is Nothing Then
                    myDataSet.Tables("Lay_Boi_Id_Ca_Can_Doi_Di_Den_Tu_Ngay_Den_Ngay").Clear()
                End If
                myAdapter.Fill(myDataSet, "Lay_Boi_Id_Ca_Can_Doi_Di_Den_Tu_Ngay_Den_Ngay")

                Return myDataSet.Tables("Lay_Boi_Id_Ca_Can_Doi_Di_Den_Tu_Ngay_Den_Ngay")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#End Region
#Region "Xoa"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng Ke_Toan_Ca
        ' Input: Id_Ca
        ' Output: 
        Public Sub Xoa(ByVal Id_Ca As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ke_Toan_Ca_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
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
#Region "Danh_Sach"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Ke_Toan_Ca
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ke_Toan_Ca_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Ke_Toan_Ca_Danh_Sach")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Lay_Boi_Ma_Bc_Khai_Thac"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Ma_Bc_Khai_Thac thông qua khóa chính 
        ' Input: Ma_Bc_Khai_Thac
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ma_Bc_Khai_Thac(ByVal Ma_Bc_Khai_Thac As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ke_Toan_Ca_Lay_Boi_Ma_Bc_Khai_Thac", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Ke_Toan_Ca_Lay_Boi_Ma_Bc_Khai_Thac")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ma_Ca"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Ma_Ca thông qua khóa chính 
        ' Input: Ca_Khai_Thac
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ma_Ca(ByVal Ca_Khai_Thac As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ke_Toan_Ca_Lay_Boi_Ma_Ca", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pCa_Khai_Thac As SqlParameter = New SqlParameter("@Ca_Khai_Thac", SqlDbType.Int, 4)
                pCa_Khai_Thac.Value = Ca_Khai_Thac
                myCommand.Parameters.Add(pCa_Khai_Thac)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Ke_Toan_Ca_Lay_Boi_Ma_Ca")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Chot_SL"
        Public Sub Chot_SL(ByVal Id_Ca As String, ByVal Chot_Sl As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ke_Toan_Ca_Chot_SL", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pChot_Sl As SqlParameter = New SqlParameter("@Chot_Sl", SqlDbType.Bit, 1)
                pChot_Sl.Value = Chot_Sl
                myCommand.Parameters.Add(pChot_Sl)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region
    End Class
#End Region
End Namespace

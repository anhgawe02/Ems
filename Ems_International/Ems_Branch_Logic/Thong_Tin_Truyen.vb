
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Thong_Tin_Truyen_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Thong_Tin_Truyen_Chi_Tiet
    ' tương ứng với mộ trường của bảng Thong_Tin_Truyen trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Thong_Tin_Truyen_Chi_Tiet
        Public Id_Thong_Tin As Integer
        Public Id_Khoa As String ' Tên bảng (với các danh mục), thông tin khóa với E2_Di, Bao_Phat
        Public Ma_Bc_Dich As Integer ' Mã bưu cục đến
        Public Ma_Bc_Goc As Integer ' Mã bưu cục phát sinh
        Public Ten_Bang As String ' Tên bảng phát sinh
        Public Tu_Dong_Gui_Tiep As Boolean ' Tự động gửi tiếp đi không
        Public Ip_Gui As String
        Public Da_Gui As Boolean
    End Class
#End Region
#Region "Thong_Tin_Truyen"
    Public Class Thong_Tin_Truyen
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Thong_Tin_Truyen
        ' Input: Id_Thong_Tin
        ' Output: Thong_Tin_Truyen_Chi_Tiet
        Public Function Lay(ByVal Id_Thong_Tin As Integer) As Thong_Tin_Truyen_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Thong_Tin_Truyen_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Thong_Tin As SqlParameter = New SqlParameter("@Id_Thong_Tin", SqlDbType.Int, 4)
                pId_Thong_Tin.Value = Id_Thong_Tin
                myCommand.Parameters.Add(pId_Thong_Tin)

                Dim pId_Khoa As SqlParameter = New SqlParameter("@Id_Khoa", SqlDbType.NVarChar, 100)
                pId_Khoa.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Khoa)

                Dim pMa_Bc_Dich As SqlParameter = New SqlParameter("@Ma_Bc_Dich", SqlDbType.Int, 4)
                pMa_Bc_Dich.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_Dich)

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 4)
                pMa_Bc_Goc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pTen_Bang As SqlParameter = New SqlParameter("@Ten_Bang", SqlDbType.NVarChar, 50)
                pTen_Bang.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTen_Bang)

                Dim pTu_Dong_Gui_Tiep As SqlParameter = New SqlParameter("@Tu_Dong_Gui_Tiep", SqlDbType.Bit, 1)
                pTu_Dong_Gui_Tiep.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTu_Dong_Gui_Tiep)

                Dim pIp_Gui As SqlParameter = New SqlParameter("@Ip_Gui", SqlDbType.NVarChar, 50)
                pIp_Gui.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pIp_Gui)

                Dim pDa_Gui As SqlParameter = New SqlParameter("@Da_Gui", SqlDbType.Bit, 1)
                pDa_Gui.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDa_Gui)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                Dim myThong_Tin_Truyen_Chi_Tiet As Thong_Tin_Truyen_Chi_Tiet = New Thong_Tin_Truyen_Chi_Tiet
                myThong_Tin_Truyen_Chi_Tiet.Id_Thong_Tin = Id_Thong_Tin
                myThong_Tin_Truyen_Chi_Tiet.Id_Khoa = pId_Khoa.Value
                myThong_Tin_Truyen_Chi_Tiet.Ma_Bc_Dich = pMa_Bc_Dich.Value
                myThong_Tin_Truyen_Chi_Tiet.Ma_Bc_Goc = pMa_Bc_Goc.Value
                myThong_Tin_Truyen_Chi_Tiet.Ten_Bang = pTen_Bang.Value
                myThong_Tin_Truyen_Chi_Tiet.Tu_Dong_Gui_Tiep = pTu_Dong_Gui_Tiep.Value
                myThong_Tin_Truyen_Chi_Tiet.Ip_Gui = pIp_Gui.Value
                myThong_Tin_Truyen_Chi_Tiet.Da_Gui = pDa_Gui.Value
                Return myThong_Tin_Truyen_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Thong_Tin_Truyen
        ' Input:  Id_Khoa, Ma_Bc_Dich, Ma_Bc_Goc, Ten_Bang, Tu_Dong_Gui_Tiep, Ip_Gui, Da_Gui,
        ' Output: 
        Public Sub Them(ByVal Id_Khoa As String, ByVal Ma_Bc_Dich As Integer, ByVal Ma_Bc_Goc As Integer, ByVal Ten_Bang As String, ByVal Tu_Dong_Gui_Tiep As Boolean, ByVal Ip_Gui As String, ByVal Da_Gui As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Thong_Tin_Truyen_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Khoa As SqlParameter = New SqlParameter("@Id_Khoa", SqlDbType.NVarChar, 100)
                pId_Khoa.Value = Id_Khoa
                myCommand.Parameters.Add(pId_Khoa)

                Dim pMa_Bc_Dich As SqlParameter = New SqlParameter("@Ma_Bc_Dich", SqlDbType.Int, 4)
                pMa_Bc_Dich.Value = Ma_Bc_Dich
                myCommand.Parameters.Add(pMa_Bc_Dich)

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 4)
                pMa_Bc_Goc.Value = Ma_Bc_Goc
                myCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pTen_Bang As SqlParameter = New SqlParameter("@Ten_Bang", SqlDbType.NVarChar, 50)
                pTen_Bang.Value = Ten_Bang
                myCommand.Parameters.Add(pTen_Bang)

                Dim pTu_Dong_Gui_Tiep As SqlParameter = New SqlParameter("@Tu_Dong_Gui_Tiep", SqlDbType.Bit, 1)
                pTu_Dong_Gui_Tiep.Value = Tu_Dong_Gui_Tiep
                myCommand.Parameters.Add(pTu_Dong_Gui_Tiep)

                Dim pIp_Gui As SqlParameter = New SqlParameter("@Ip_Gui", SqlDbType.NVarChar, 50)
                pIp_Gui.Value = Ip_Gui
                myCommand.Parameters.Add(pIp_Gui)

                Dim pDa_Gui As SqlParameter = New SqlParameter("@Da_Gui", SqlDbType.Bit, 1)
                pDa_Gui.Value = Da_Gui
                myCommand.Parameters.Add(pDa_Gui)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Sub
#End Region
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Thong_Tin_Truyen
        ' Input: Id_Thong_Tin,  Id_Khoa , Ma_Bc_Dich , Ma_Bc_Goc , Ten_Bang , Tu_Dong_Gui_Tiep , Ip_Gui , Da_Gui ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_Thong_Tin As Integer, ByVal Id_Khoa As String, ByVal Ma_Bc_Dich As Integer, ByVal Ma_Bc_Goc As Integer, ByVal Ten_Bang As String, ByVal Tu_Dong_Gui_Tiep As Boolean, ByVal Ip_Gui As String, ByVal Da_Gui As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Thong_Tin_Truyen_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Thong_Tin As SqlParameter = New SqlParameter("@Id_Thong_Tin", SqlDbType.Int, 4)
                pId_Thong_Tin.Value = Id_Thong_Tin
                myCommand.Parameters.Add(pId_Thong_Tin)

                Dim pId_Khoa As SqlParameter = New SqlParameter("@Id_Khoa", SqlDbType.NVarChar, 100)
                pId_Khoa.Value = Id_Khoa
                myCommand.Parameters.Add(pId_Khoa)

                Dim pMa_Bc_Dich As SqlParameter = New SqlParameter("@Ma_Bc_Dich", SqlDbType.Int, 4)
                pMa_Bc_Dich.Value = Ma_Bc_Dich
                myCommand.Parameters.Add(pMa_Bc_Dich)

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 4)
                pMa_Bc_Goc.Value = Ma_Bc_Goc
                myCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pTen_Bang As SqlParameter = New SqlParameter("@Ten_Bang", SqlDbType.NVarChar, 50)
                pTen_Bang.Value = Ten_Bang
                myCommand.Parameters.Add(pTen_Bang)

                Dim pTu_Dong_Gui_Tiep As SqlParameter = New SqlParameter("@Tu_Dong_Gui_Tiep", SqlDbType.Bit, 1)
                pTu_Dong_Gui_Tiep.Value = Tu_Dong_Gui_Tiep
                myCommand.Parameters.Add(pTu_Dong_Gui_Tiep)

                Dim pIp_Gui As SqlParameter = New SqlParameter("@Ip_Gui", SqlDbType.NVarChar, 50)
                pIp_Gui.Value = Ip_Gui
                myCommand.Parameters.Add(pIp_Gui)

                Dim pDa_Gui As SqlParameter = New SqlParameter("@Da_Gui", SqlDbType.Bit, 1)
                pDa_Gui.Value = Da_Gui
                myCommand.Parameters.Add(pDa_Gui)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Thong_Tin_Truyen
        ' Input: đối tượng thuộc lớp Thong_Tin_Truyen_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myThong_Tin_Truyen_Chi_Tiet As Thong_Tin_Truyen_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Thong_Tin_Truyen_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_Thong_Tin As SqlParameter = New SqlParameter("@Id_Thong_Tin", SqlDbType.Int, 4)
                pId_Thong_Tin.Value = myThong_Tin_Truyen_Chi_Tiet.Id_Thong_Tin
                myCommand.Parameters.Add(pId_Thong_Tin)

                Dim pId_Khoa As SqlParameter = New SqlParameter("@Id_Khoa", SqlDbType.NVarChar, 100)
                pId_Khoa.Value = myThong_Tin_Truyen_Chi_Tiet.Id_Khoa
                myCommand.Parameters.Add(pId_Khoa)

                Dim pMa_Bc_Dich As SqlParameter = New SqlParameter("@Ma_Bc_Dich", SqlDbType.Int, 4)
                pMa_Bc_Dich.Value = myThong_Tin_Truyen_Chi_Tiet.Ma_Bc_Dich
                myCommand.Parameters.Add(pMa_Bc_Dich)

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 4)
                pMa_Bc_Goc.Value = myThong_Tin_Truyen_Chi_Tiet.Ma_Bc_Goc
                myCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pTen_Bang As SqlParameter = New SqlParameter("@Ten_Bang", SqlDbType.NVarChar, 50)
                pTen_Bang.Value = myThong_Tin_Truyen_Chi_Tiet.Ten_Bang
                myCommand.Parameters.Add(pTen_Bang)

                Dim pTu_Dong_Gui_Tiep As SqlParameter = New SqlParameter("@Tu_Dong_Gui_Tiep", SqlDbType.Bit, 1)
                pTu_Dong_Gui_Tiep.Value = myThong_Tin_Truyen_Chi_Tiet.Tu_Dong_Gui_Tiep
                myCommand.Parameters.Add(pTu_Dong_Gui_Tiep)

                Dim pIp_Gui As SqlParameter = New SqlParameter("@Ip_Gui", SqlDbType.NVarChar, 50)
                pIp_Gui.Value = myThong_Tin_Truyen_Chi_Tiet.Ip_Gui
                myCommand.Parameters.Add(pIp_Gui)

                Dim pDa_Gui As SqlParameter = New SqlParameter("@Da_Gui", SqlDbType.Bit, 1)
                pDa_Gui.Value = myThong_Tin_Truyen_Chi_Tiet.Da_Gui
                myCommand.Parameters.Add(pDa_Gui)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Sub
#End Region
#Region "Cap_Nhat_Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Thong_Tin_Truyen
        ' Input: Id_Thong_Tin,  Id_Khoa , Ma_Bc_Dich , Ma_Bc_Goc , Ten_Bang , Tu_Dong_Gui_Tiep , Ip_Gui , Da_Gui ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Id_Thong_Tin As Integer, ByVal Id_Khoa As String, ByVal Ma_Bc_Dich As Integer, ByVal Ma_Bc_Goc As Integer, ByVal Ten_Bang As String, ByVal Tu_Dong_Gui_Tiep As Boolean, ByVal Ip_Gui As String, ByVal Da_Gui As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Thong_Tin_Truyen_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Thong_Tin As SqlParameter = New SqlParameter("@Id_Thong_Tin", SqlDbType.Int, 4)
                pId_Thong_Tin.Value = Id_Thong_Tin
                myCommand.Parameters.Add(pId_Thong_Tin)

                Dim pId_Khoa As SqlParameter = New SqlParameter("@Id_Khoa", SqlDbType.NVarChar, 100)
                pId_Khoa.Value = Id_Khoa
                myCommand.Parameters.Add(pId_Khoa)

                Dim pMa_Bc_Dich As SqlParameter = New SqlParameter("@Ma_Bc_Dich", SqlDbType.Int, 4)
                pMa_Bc_Dich.Value = Ma_Bc_Dich
                myCommand.Parameters.Add(pMa_Bc_Dich)

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 4)
                pMa_Bc_Goc.Value = Ma_Bc_Goc
                myCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pTen_Bang As SqlParameter = New SqlParameter("@Ten_Bang", SqlDbType.NVarChar, 50)
                pTen_Bang.Value = Ten_Bang
                myCommand.Parameters.Add(pTen_Bang)

                Dim pTu_Dong_Gui_Tiep As SqlParameter = New SqlParameter("@Tu_Dong_Gui_Tiep", SqlDbType.Bit, 1)
                pTu_Dong_Gui_Tiep.Value = Tu_Dong_Gui_Tiep
                myCommand.Parameters.Add(pTu_Dong_Gui_Tiep)

                Dim pIp_Gui As SqlParameter = New SqlParameter("@Ip_Gui", SqlDbType.NVarChar, 50)
                pIp_Gui.Value = Ip_Gui
                myCommand.Parameters.Add(pIp_Gui)

                Dim pDa_Gui As SqlParameter = New SqlParameter("@Da_Gui", SqlDbType.Bit, 1)
                pDa_Gui.Value = Da_Gui
                myCommand.Parameters.Add(pDa_Gui)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region
#Region "Xoa"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng Thong_Tin_Truyen
        ' Input: Id_Thong_Tin
        ' Output: 
        Public Sub Xoa(ByVal Id_Thong_Tin As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Thong_Tin_Truyen_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Thong_Tin As SqlParameter = New SqlParameter("@Id_Thong_Tin", SqlDbType.Int, 4)
                pId_Thong_Tin.Value = Id_Thong_Tin
                myCommand.Parameters.Add(pId_Thong_Tin)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
            Catch ex As Exception
                Console.Write(ex.ToString)


            End Try
        End Sub
#End Region
#Region "XoaXoa_Tu_Ngay_Den_Ngay"
        ' Ngày tạo: 22/05/2009
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Xóa dữ liệu từ bảng Thong_Tin_Truyen từ ngày đến ngày
        ' Input: Tu_Ngay, Den_Ngay
        ' Output: 
        Public Sub Xoa_Tu_Ngay_Den_Ngay(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Thong_Tin_Truyen_Xoa_Tu_Ngay_Den_Ngay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Value = Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Value = Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
            Catch ex As Exception
                Console.Write(ex.ToString)


            End Try
        End Sub
#End Region
#Region "Danh_Sach"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Thong_Tin_Truyen
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Thong_Tin_Truyen_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Thong_Tin_Truyen_Danh_Sach")
                myConnection.Close()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region


    End Class
#End Region
End Namespace

Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Noi_Dung_Phat_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Noi_Dung_Phat_Chi_Tiet
    ' tương ứng với một trường của bảng Noi_Dung_Phat trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Noi_Dung_Phat_Chi_Tiet
        Public Id_Noi_Dung As Integer
        Public Id_Bao_Phat As String
        Public Nguoi_Phat As String ' Bưu tá phát
        Public Ngay_Phat As Integer ' Ngày phát
        Public Gio_Phat As Integer ' Giờ phát
        Public Ma_Xu_Ly As String
        Public Ma_Ly_Do As Integer
        Public Phat_Duoc As Boolean
        Public Ghi_Chu As String
        Public Ngay_He_Thong As Integer
        Public Truyen_Bao_Phat As Boolean
    End Class
#End Region
#Region "Noi_Dung_Phat"
    Public Class Noi_Dung_Phat
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Noi_Dung_Phat
        ' Input: Id_Noi_Dung
        ' Output: Noi_Dung_Phat_Chi_Tiet
        Public Function Lay(ByVal Id_Noi_Dung As Integer) As Noi_Dung_Phat_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Noi_Dung_Phat_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Noi_Dung As SqlParameter = New SqlParameter("@Id_Noi_Dung", SqlDbType.Int, 4)
                pId_Noi_Dung.Value = Id_Noi_Dung
                myCommand.Parameters.Add(pId_Noi_Dung)

                Dim pId_Bao_Phat As SqlParameter = New SqlParameter("@Id_Bao_Phat", SqlDbType.VarChar, 48)
                pId_Bao_Phat.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Bao_Phat)

                Dim pNguoi_Phat As SqlParameter = New SqlParameter("@Nguoi_Phat", SqlDbType.VarChar, 100)
                pNguoi_Phat.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNguoi_Phat)

                Dim pNgay_Phat As SqlParameter = New SqlParameter("@Ngay_Phat", SqlDbType.Int, 4)
                pNgay_Phat.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_Phat)

                Dim pGio_Phat As SqlParameter = New SqlParameter("@Gio_Phat", SqlDbType.Int, 4)
                pGio_Phat.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGio_Phat)

                Dim pMa_Xu_Ly As SqlParameter = New SqlParameter("@Ma_Xu_Ly", SqlDbType.VarChar, 1)
                pMa_Xu_Ly.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Xu_Ly)

                Dim pMa_Ly_Do As SqlParameter = New SqlParameter("@Ma_Ly_Do", SqlDbType.Int, 4)
                pMa_Ly_Do.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Ly_Do)

                Dim pPhat_Duoc As SqlParameter = New SqlParameter("@Phat_Duoc", SqlDbType.Bit, 1)
                pPhat_Duoc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pPhat_Duoc)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 50)
                pGhi_Chu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGhi_Chu)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pTruyen_Bao_Phat As SqlParameter = New SqlParameter("@Truyen_Bao_Phat", SqlDbType.Bit, 1)
                pTruyen_Bao_Phat.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTruyen_Bao_Phat)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myNoi_Dung_Phat_Chi_Tiet As Noi_Dung_Phat_Chi_Tiet = New Noi_Dung_Phat_Chi_Tiet
                myNoi_Dung_Phat_Chi_Tiet.Id_Noi_Dung = Id_Noi_Dung
                myNoi_Dung_Phat_Chi_Tiet.Id_Bao_Phat = pId_Bao_Phat.Value
                myNoi_Dung_Phat_Chi_Tiet.Nguoi_Phat = pNguoi_Phat.Value
                myNoi_Dung_Phat_Chi_Tiet.Ngay_Phat = pNgay_Phat.Value
                myNoi_Dung_Phat_Chi_Tiet.Gio_Phat = pGio_Phat.Value
                myNoi_Dung_Phat_Chi_Tiet.Ma_Xu_Ly = pMa_Xu_Ly.Value
                myNoi_Dung_Phat_Chi_Tiet.Ma_Ly_Do = pMa_Ly_Do.Value
                myNoi_Dung_Phat_Chi_Tiet.Phat_Duoc = pPhat_Duoc.Value
                myNoi_Dung_Phat_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value
                myNoi_Dung_Phat_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myNoi_Dung_Phat_Chi_Tiet.Truyen_Bao_Phat = pTruyen_Bao_Phat.Value
                Return myNoi_Dung_Phat_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Noi_Dung_Phat
        ' Input: Id_Noi_Dung,  Id_Bao_Phat , Nguoi_Phat , Ngay_Phat , Gio_Phat , Ma_Xu_Ly , Ma_Ly_Do , Phat_Duoc , Ghi_Chu , Ngay_He_Thong , Truyen_Bao_Phat ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_Noi_Dung As String, ByVal Id_Bao_Phat As String, ByVal Nguoi_Phat As String, ByVal Ngay_Phat As Integer, ByVal Gio_Phat As Integer, ByVal Ma_Xu_Ly As String, ByVal Ma_Ly_Do As Integer, ByVal Phat_Duoc As Boolean, ByVal Ghi_Chu As String, ByVal Ngay_He_Thong As Integer, ByVal Truyen_Bao_Phat As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Noi_Dung_Phat_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Noi_Dung As SqlParameter = New SqlParameter("@Id_Noi_Dung", SqlDbType.VarChar, 50)
                pId_Noi_Dung.Value = Id_Noi_Dung
                myCommand.Parameters.Add(pId_Noi_Dung)

                Dim pId_Bao_Phat As SqlParameter = New SqlParameter("@Id_Bao_Phat", SqlDbType.VarChar, 48)
                pId_Bao_Phat.Value = Id_Bao_Phat
                myCommand.Parameters.Add(pId_Bao_Phat)

                Dim pNguoi_Phat As SqlParameter = New SqlParameter("@Nguoi_Phat", SqlDbType.VarChar, 100)
                pNguoi_Phat.Value = Nguoi_Phat
                myCommand.Parameters.Add(pNguoi_Phat)

                Dim pNgay_Phat As SqlParameter = New SqlParameter("@Ngay_Phat", SqlDbType.Int, 4)
                pNgay_Phat.Value = Ngay_Phat
                myCommand.Parameters.Add(pNgay_Phat)

                Dim pGio_Phat As SqlParameter = New SqlParameter("@Gio_Phat", SqlDbType.Int, 4)
                pGio_Phat.Value = Gio_Phat
                myCommand.Parameters.Add(pGio_Phat)

                Dim pMa_Xu_Ly As SqlParameter = New SqlParameter("@Ma_Xu_Ly", SqlDbType.VarChar, 1)
                pMa_Xu_Ly.Value = Ma_Xu_Ly
                myCommand.Parameters.Add(pMa_Xu_Ly)

                Dim pMa_Ly_Do As SqlParameter = New SqlParameter("@Ma_Ly_Do", SqlDbType.Int, 4)
                pMa_Ly_Do.Value = Ma_Ly_Do
                myCommand.Parameters.Add(pMa_Ly_Do)

                Dim pPhat_Duoc As SqlParameter = New SqlParameter("@Phat_Duoc", SqlDbType.Bit, 1)
                pPhat_Duoc.Value = Phat_Duoc
                myCommand.Parameters.Add(pPhat_Duoc)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 50)
                pGhi_Chu.Value = Ghi_Chu
                myCommand.Parameters.Add(pGhi_Chu)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Value = Ngay_He_Thong
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pTruyen_Bao_Phat As SqlParameter = New SqlParameter("@Truyen_Bao_Phat", SqlDbType.Bit, 1)
                pTruyen_Bao_Phat.Value = Truyen_Bao_Phat
                myCommand.Parameters.Add(pTruyen_Bao_Phat)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Noi_Dung_Phat
        ' Input: đối tượng thuộc lớp Noi_Dung_Phat_Chi_Tiet
        ' Output: 
        Public Sub Them(ByVal myNoi_Dung_Phat_Chi_Tiet As Noi_Dung_Phat_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Noi_Dung_Phat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_Noi_Dung As SqlParameter = New SqlParameter("@Id_Noi_Dung", SqlDbType.VarChar, 50)
                pId_Noi_Dung.Value = myNoi_Dung_Phat_Chi_Tiet.Id_Noi_Dung
                myCommand.Parameters.Add(pId_Noi_Dung)

                Dim pId_Bao_Phat As SqlParameter = New SqlParameter("@Id_Bao_Phat", SqlDbType.VarChar, 48)
                pId_Bao_Phat.Value = myNoi_Dung_Phat_Chi_Tiet.Id_Bao_Phat
                myCommand.Parameters.Add(pId_Bao_Phat)

                Dim pNguoi_Phat As SqlParameter = New SqlParameter("@Nguoi_Phat", SqlDbType.VarChar, 100)
                pNguoi_Phat.Value = myNoi_Dung_Phat_Chi_Tiet.Nguoi_Phat
                myCommand.Parameters.Add(pNguoi_Phat)

                Dim pNgay_Phat As SqlParameter = New SqlParameter("@Ngay_Phat", SqlDbType.Int, 4)
                pNgay_Phat.Value = myNoi_Dung_Phat_Chi_Tiet.Ngay_Phat
                myCommand.Parameters.Add(pNgay_Phat)

                Dim pGio_Phat As SqlParameter = New SqlParameter("@Gio_Phat", SqlDbType.Int, 4)
                pGio_Phat.Value = myNoi_Dung_Phat_Chi_Tiet.Gio_Phat
                myCommand.Parameters.Add(pGio_Phat)

                Dim pMa_Xu_Ly As SqlParameter = New SqlParameter("@Ma_Xu_Ly", SqlDbType.VarChar, 1)
                pMa_Xu_Ly.Value = myNoi_Dung_Phat_Chi_Tiet.Ma_Xu_Ly
                myCommand.Parameters.Add(pMa_Xu_Ly)

                Dim pMa_Ly_Do As SqlParameter = New SqlParameter("@Ma_Ly_Do", SqlDbType.Int, 4)
                pMa_Ly_Do.Value = myNoi_Dung_Phat_Chi_Tiet.Ma_Ly_Do
                myCommand.Parameters.Add(pMa_Ly_Do)

                Dim pPhat_Duoc As SqlParameter = New SqlParameter("@Phat_Duoc", SqlDbType.Bit, 1)
                pPhat_Duoc.Value = myNoi_Dung_Phat_Chi_Tiet.Phat_Duoc
                myCommand.Parameters.Add(pPhat_Duoc)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 50)
                pGhi_Chu.Value = myNoi_Dung_Phat_Chi_Tiet.Ghi_Chu
                myCommand.Parameters.Add(pGhi_Chu)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Value = myNoi_Dung_Phat_Chi_Tiet.Ngay_He_Thong
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pTruyen_Bao_Phat As SqlParameter = New SqlParameter("@Truyen_Bao_Phat", SqlDbType.Bit, 1)
                pTruyen_Bao_Phat.Value = myNoi_Dung_Phat_Chi_Tiet.Truyen_Bao_Phat
                myCommand.Parameters.Add(pTruyen_Bao_Phat)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Noi_Dung_Phat
        ' Input: Id_Noi_Dung,  Id_Bao_Phat , Nguoi_Phat , Ngay_Phat , Gio_Phat , Ma_Xu_Ly , Ma_Ly_Do , Phat_Duoc , Ghi_Chu , Ngay_He_Thong , Truyen_Bao_Phat ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Id_Noi_Dung As Integer, ByVal Id_Bao_Phat As String, ByVal Nguoi_Phat As String, ByVal Ngay_Phat As Integer, ByVal Gio_Phat As Integer, ByVal Ma_Xu_Ly As String, ByVal Ma_Ly_Do As Integer, ByVal Phat_Duoc As Boolean, ByVal Ghi_Chu As String, ByVal Ngay_He_Thong As Integer, ByVal Truyen_Bao_Phat As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Noi_Dung_Phat_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Noi_Dung As SqlParameter = New SqlParameter("@Id_Noi_Dung", SqlDbType.Int, 4)
                pId_Noi_Dung.Value = Id_Noi_Dung
                myCommand.Parameters.Add(pId_Noi_Dung)

                Dim pId_Bao_Phat As SqlParameter = New SqlParameter("@Id_Bao_Phat", SqlDbType.VarChar, 48)
                pId_Bao_Phat.Value = Id_Bao_Phat
                myCommand.Parameters.Add(pId_Bao_Phat)

                Dim pNguoi_Phat As SqlParameter = New SqlParameter("@Nguoi_Phat", SqlDbType.VarChar, 100)
                pNguoi_Phat.Value = Nguoi_Phat
                myCommand.Parameters.Add(pNguoi_Phat)

                Dim pNgay_Phat As SqlParameter = New SqlParameter("@Ngay_Phat", SqlDbType.Int, 4)
                pNgay_Phat.Value = Ngay_Phat
                myCommand.Parameters.Add(pNgay_Phat)

                Dim pGio_Phat As SqlParameter = New SqlParameter("@Gio_Phat", SqlDbType.Int, 4)
                pGio_Phat.Value = Gio_Phat
                myCommand.Parameters.Add(pGio_Phat)

                Dim pMa_Xu_Ly As SqlParameter = New SqlParameter("@Ma_Xu_Ly", SqlDbType.VarChar, 1)
                pMa_Xu_Ly.Value = Ma_Xu_Ly
                myCommand.Parameters.Add(pMa_Xu_Ly)

                Dim pMa_Ly_Do As SqlParameter = New SqlParameter("@Ma_Ly_Do", SqlDbType.Int, 4)
                pMa_Ly_Do.Value = Ma_Ly_Do
                myCommand.Parameters.Add(pMa_Ly_Do)

                Dim pPhat_Duoc As SqlParameter = New SqlParameter("@Phat_Duoc", SqlDbType.Bit, 1)
                pPhat_Duoc.Value = Phat_Duoc
                myCommand.Parameters.Add(pPhat_Duoc)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 50)
                pGhi_Chu.Value = Ghi_Chu
                myCommand.Parameters.Add(pGhi_Chu)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Value = Ngay_He_Thong
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pTruyen_Bao_Phat As SqlParameter = New SqlParameter("@Truyen_Bao_Phat", SqlDbType.Bit, 1)
                pTruyen_Bao_Phat.Value = Truyen_Bao_Phat
                myCommand.Parameters.Add(pTruyen_Bao_Phat)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
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
        ' Nội dung: Xóa dữ liệu từ bảng Noi_Dung_Phat
        ' Input: Id_Noi_Dung
        ' Output: 
        Public Sub Xoa(ByVal Id_Bao_Phat As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Noi_Dung_Phat_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Bao_Phat As SqlParameter = New SqlParameter("@Id_Bao_Phat", SqlDbType.VarChar, 50)
                pId_Bao_Phat.Value = Id_Bao_Phat
                myCommand.Parameters.Add(pId_Bao_Phat)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)


            End Try
        End Sub
#End Region
#Region "Lay so lan co chi tiet phat cua 1 E"
        ' Ngày tạo: 15/6/08
        ' Người tạo: tuyennv
        ' Nội dung: Xóa dữ liệu từ bảng Noi_Dung_Phat
        ' Input: Id_Noi_Dung
        ' Output:        
        Public Function So_Lan_Phat(ByVal Id_Bao_Phat As String) As Integer
            Try
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myCommand As SqlCommand
                Dim ReturnValue As String
                Dim sql As String
                sql = "select count(*) from Noi_Dung_Phat where Id_Bao_Phat= '" & Id_Bao_Phat & "'"
                myCommand = New SqlCommand(sql, myConnection)
                myConnection.Open()
                myCommand.CommandType = CommandType.Text
                myAdapter.SelectCommand = myCommand
                ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
                myConnection.Close()
                myConnection.Dispose()
                Return ReturnValue
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Danh_Sach"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Noi_Dung_Phat
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Noi_Dung_Phat_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Noi_Dung_Phat_Danh_Sach")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_Chua_Truyen"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Noi_Dung_Phat
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Chua_Truyen(ByVal Tungay As Integer, ByVal Denngay As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Noi_Dung_Phat_Danh_Sach_Chua_Truyen", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                ' Thêm các Parameters vào thủ tục
                Dim PTungay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                PTungay.Value = Tungay
                myCommand.Parameters.Add(PTungay)
                Dim PDenngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                PDenngay.Value = Denngay
                myCommand.Parameters.Add(PDenngay)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Noi_Dung_Phat_Danh_Sach_Chua_Truyen")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Danh_Sach_Chua_Truyen_Theo_Bc_Phat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: tuyennv
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Noi_Dung_Phat
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Chua_Truyen_Theo_Bc_Phat(ByVal Tungay As Integer, ByVal Denngay As Integer, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_bc_Phat As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Noi_Dung_Phat_Danh_Sach_Chua_Truyen_Theo_Bc_Phat", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                ' Thêm các Parameters vào thủ tục
                Dim PTungay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                PTungay.Value = Tungay
                myCommand.Parameters.Add(PTungay)
                Dim PDenngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                PDenngay.Value = Denngay
                myCommand.Parameters.Add(PDenngay)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Bc_Phat As SqlParameter = New SqlParameter("@Ma_Bc_Phat", SqlDbType.Int, 4)
                pMa_Bc_Phat.Value = Ma_bc_Phat
                myCommand.Parameters.Add(pMa_Bc_Phat)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Noi_Dung_Phat_Danh_Sach_Chua_Truyen_Theo_Bc_Phat")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Noi_Dung_Phat_Danh_Sach_Chua_Truyen_Ngay_Nghi"
        ' Ngày tạo: 15/6/08
        ' Người tạo:tuyennv
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Noi_Dung_Phat
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Chua_Truyen_Ngay_Nghi(ByVal Ngay_nghi As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Noi_Dung_Phat_Danh_Sach_Chua_Truyen_Ngay_Nghi", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục                
                Dim PNgay_Ngi As SqlParameter = New SqlParameter("@Ngay_nghi", SqlDbType.Int, 4)
                PNgay_Ngi.Value = Ngay_nghi
                myCommand.Parameters.Add(PNgay_Ngi)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Noi_Dung_Phat_Danh_Sach_Chua_Truyen_Ngay_Nghi")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Noi_Dung_Phat_Cap_Nhat_Danh_Sach_Da_Truyen"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Noi_Dung_Phat
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Noi_Dung_Phat_Cap_Nhat_Danh_Sach_Da_Truyen(ByVal Tungay As Integer, ByVal Denngay As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Noi_Dung_Phat_Cap_Nhat_Danh_Sach_Da_Truyen", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                ' Thêm các Parameters vào thủ tục
                Dim PTungay As SqlParameter = New SqlParameter("@Tungay", SqlDbType.Int, 4)
                PTungay.Value = Tungay
                myCommand.Parameters.Add(PTungay)
                Dim PDenngay As SqlParameter = New SqlParameter("@Denngay", SqlDbType.Int, 4)
                PDenngay.Value = Denngay
                myCommand.Parameters.Add(PDenngay)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Noi_Dung_Phat_Cap_Nhat_Danh_Sach_Da_Truyen")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Noi_Dung_Phat_Cap_Nhat_Danh_Sach_Da_Truyen_Ngay_Nghi"
        ' Ngày tạo: 15/6/08
        ' Người tạo: tuyennv
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Noi_Dung_Phat
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Noi_Dung_Phat_Cap_Nhat_Danh_Sach_Da_Truyen_Ngay_Nghi(ByVal Ngay_Nghi As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Noi_Dung_Phat_Cap_Nhat_Danh_Sach_Da_Truyen_Ngay_Nghi", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                ' Thêm các Parameters vào thủ tục
                Dim PNgay_Nghi As SqlParameter = New SqlParameter("@Ngay_Nghi", SqlDbType.Int, 4)
                PNgay_Nghi.Value = Ngay_Nghi
                myCommand.Parameters.Add(PNgay_Nghi)


                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Noi_Dung_Phat_Cap_Nhat_Danh_Sach_Da_Truyen_Ngay_Nghi")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Lay_Boi_Ly_Do"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Ly_Do thông qua khóa chính 
        ' Input: Ma_Ly_Do
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ly_Do(ByVal Ma_Ly_Do As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Noi_Dung_Phat_Lay_Boi_Ly_Do", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Ly_Do As SqlParameter = New SqlParameter("@Ma_Ly_Do", SqlDbType.Int, 4)
                pMa_Ly_Do.Value = Ma_Ly_Do
                myCommand.Parameters.Add(pMa_Ly_Do)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Noi_Dung_Phat_Lay_Boi_Ly_Do")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Bao_Phat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Bao_Phat thông qua khóa chính 
        ' Input: Id_Bao_Phat
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Bao_Phat(ByVal Id_Bao_Phat As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Noi_Dung_Phat_Lay_Boi_Bao_Phat", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Bao_Phat As SqlParameter = New SqlParameter("@Id_Bao_Phat", SqlDbType.VarChar, 48)
                pId_Bao_Phat.Value = Id_Bao_Phat
                myCommand.Parameters.Add(pId_Bao_Phat)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Noi_Dung_Phat_Lay_Boi_Bao_Phat")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Lay_Boi_Xu_Ly"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Xu_Ly thông qua khóa chính 
        ' Input: Ma_Xu_Ly
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Xu_Ly(ByVal Ma_Xu_Ly As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Noi_Dung_Phat_Lay_Boi_Xu_Ly", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Xu_Ly As SqlParameter = New SqlParameter("@Ma_Xu_Ly", SqlDbType.VarChar, 1)
                pMa_Xu_Ly.Value = Ma_Xu_Ly
                myCommand.Parameters.Add(pMa_Xu_Ly)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Noi_Dung_Phat_Lay_Boi_Xu_Ly")
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

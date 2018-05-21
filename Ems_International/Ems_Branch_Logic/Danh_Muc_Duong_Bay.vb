
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Danh_Muc_Duong_Bay_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Danh_Muc_Duong_Bay_Chi_Tiet
    ' tương ứng với mộ trường của bảng Danh_Muc_Duong_Bay trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Danh_Muc_Duong_Bay_Chi_Tiet
        Public Id_Duong_Bay As String
        Public Id_Duong_Thu As String
        Public Loai_van_chuyen As Integer
        Public So_hieu As String
        Public Noi_GUI As String
        Public Noi_NHAN As String
        Public BC_GUI As String
        Public BC_NHAN As String
        Public GIO_KHOI_HANH As Integer
        Public GIO_DEN As Integer
        Public QUA_NGAY As Boolean
        Public QUA_GIANG As Boolean
    End Class
#End Region
#Region "Danh_Muc_Duong_Bay"
    Public Class Danh_Muc_Duong_Bay
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Danh_Muc_Duong_Bay
        ' Input: Id_Duong_Bay
        ' Output: Danh_Muc_Duong_Bay_Chi_Tiet
        Public Function Lay(ByVal Id_Duong_Bay As String) As Danh_Muc_Duong_Bay_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_Duong_Bay_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Duong_Bay As SqlParameter = New SqlParameter("@Id_Duong_Bay", SqlDbType.VarChar, 30)
                pId_Duong_Bay.Value = Id_Duong_Bay
                myCommand.Parameters.Add(pId_Duong_Bay)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pLoai_van_chuyen As SqlParameter = New SqlParameter("@Loai_van_chuyen", SqlDbType.Int, 4)
                pLoai_van_chuyen.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pLoai_van_chuyen)

                Dim pSo_hieu As SqlParameter = New SqlParameter("@So_hieu", SqlDbType.VarChar, 20)
                pSo_hieu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSo_hieu)

                Dim pNoi_GUI As SqlParameter = New SqlParameter("@Noi_GUI", SqlDbType.VarChar, 20)
                pNoi_GUI.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNoi_GUI)

                Dim pNoi_NHAN As SqlParameter = New SqlParameter("@Noi_NHAN", SqlDbType.VarChar, 3)
                pNoi_NHAN.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNoi_NHAN)

                Dim pBC_GUI As SqlParameter = New SqlParameter("@BC_GUI", SqlDbType.VarChar, 6)
                pBC_GUI.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pBC_GUI)

                Dim pBC_NHAN As SqlParameter = New SqlParameter("@BC_NHAN", SqlDbType.VarChar, 6)
                pBC_NHAN.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pBC_NHAN)

                Dim pGIO_KHOI_HANH As SqlParameter = New SqlParameter("@GIO_KHOI_HANH", SqlDbType.Int, 4)
                pGIO_KHOI_HANH.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGIO_KHOI_HANH)

                Dim pGIO_DEN As SqlParameter = New SqlParameter("@GIO_DEN", SqlDbType.Int, 4)
                pGIO_DEN.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGIO_DEN)

                Dim pQUA_NGAY As SqlParameter = New SqlParameter("@QUA_NGAY", SqlDbType.Bit, 1)
                pQUA_NGAY.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pQUA_NGAY)

                Dim pQUA_GIANG As SqlParameter = New SqlParameter("@QUA_GIANG", SqlDbType.Bit, 1)
                pQUA_GIANG.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pQUA_GIANG)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myDanh_Muc_Duong_Bay_Chi_Tiet As Danh_Muc_Duong_Bay_Chi_Tiet = New Danh_Muc_Duong_Bay_Chi_Tiet
                myDanh_Muc_Duong_Bay_Chi_Tiet.Id_Duong_Bay = Id_Duong_Bay
                myDanh_Muc_Duong_Bay_Chi_Tiet.Id_Duong_Thu = pId_Duong_Thu.Value
                myDanh_Muc_Duong_Bay_Chi_Tiet.Loai_van_chuyen = pLoai_van_chuyen.Value
                myDanh_Muc_Duong_Bay_Chi_Tiet.So_hieu = pSo_hieu.Value
                If pNoi_GUI.Value Is System.DBNull.Value Then
                    myDanh_Muc_Duong_Bay_Chi_Tiet.Noi_GUI = ""
                Else
                    myDanh_Muc_Duong_Bay_Chi_Tiet.Noi_GUI = pNoi_GUI.Value
                End If
                myDanh_Muc_Duong_Bay_Chi_Tiet.Noi_NHAN = pNoi_NHAN.Value
                myDanh_Muc_Duong_Bay_Chi_Tiet.BC_GUI = pBC_GUI.Value
                myDanh_Muc_Duong_Bay_Chi_Tiet.BC_NHAN = pBC_NHAN.Value
                myDanh_Muc_Duong_Bay_Chi_Tiet.GIO_KHOI_HANH = pGIO_KHOI_HANH.Value
                myDanh_Muc_Duong_Bay_Chi_Tiet.GIO_DEN = pGIO_DEN.Value
                myDanh_Muc_Duong_Bay_Chi_Tiet.QUA_NGAY = pQUA_NGAY.Value
                myDanh_Muc_Duong_Bay_Chi_Tiet.QUA_GIANG = pQUA_GIANG.Value
                Return myDanh_Muc_Duong_Bay_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Danh_Muc_Duong_Bay
        ' Input:  Id_Duong_Thu, Loai_van_chuyen, So_hieu, Noi_GUI, Noi_NHAN, BC_GUI, BC_NHAN, GIO_KHOI_HANH, GIO_DEN, QUA_NGAY, QUA_GIANG,
        ' Output: 
        Public Sub Them(ByVal Id_Duong_Thu As String, ByVal Loai_van_chuyen As Integer, ByVal So_hieu As String, ByVal Noi_GUI As String, ByVal Noi_NHAN As String, ByVal BC_GUI As String, ByVal BC_NHAN As String, ByVal GIO_KHOI_HANH As Integer, ByVal GIO_DEN As Integer, ByVal QUA_NGAY As Boolean, ByVal QUA_GIANG As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_Duong_Bay_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pLoai_van_chuyen As SqlParameter = New SqlParameter("@Loai_van_chuyen", SqlDbType.Int, 4)
                pLoai_van_chuyen.Value = Loai_van_chuyen
                myCommand.Parameters.Add(pLoai_van_chuyen)

                Dim pSo_hieu As SqlParameter = New SqlParameter("@So_hieu", SqlDbType.VarChar, 20)
                pSo_hieu.Value = So_hieu
                myCommand.Parameters.Add(pSo_hieu)

                Dim pNoi_GUI As SqlParameter = New SqlParameter("@Noi_GUI", SqlDbType.VarChar, 20)
                pNoi_GUI.Value = Noi_GUI
                myCommand.Parameters.Add(pNoi_GUI)

                Dim pNoi_NHAN As SqlParameter = New SqlParameter("@Noi_NHAN", SqlDbType.VarChar, 3)
                pNoi_NHAN.Value = Noi_NHAN
                myCommand.Parameters.Add(pNoi_NHAN)

                Dim pBC_GUI As SqlParameter = New SqlParameter("@BC_GUI", SqlDbType.VarChar, 6)
                pBC_GUI.Value = BC_GUI
                myCommand.Parameters.Add(pBC_GUI)

                Dim pBC_NHAN As SqlParameter = New SqlParameter("@BC_NHAN", SqlDbType.VarChar, 6)
                pBC_NHAN.Value = BC_NHAN
                myCommand.Parameters.Add(pBC_NHAN)

                Dim pGIO_KHOI_HANH As SqlParameter = New SqlParameter("@GIO_KHOI_HANH", SqlDbType.Int, 4)
                pGIO_KHOI_HANH.Value = GIO_KHOI_HANH
                myCommand.Parameters.Add(pGIO_KHOI_HANH)

                Dim pGIO_DEN As SqlParameter = New SqlParameter("@GIO_DEN", SqlDbType.Int, 4)
                pGIO_DEN.Value = GIO_DEN
                myCommand.Parameters.Add(pGIO_DEN)

                Dim pQUA_NGAY As SqlParameter = New SqlParameter("@QUA_NGAY", SqlDbType.Bit, 1)
                pQUA_NGAY.Value = QUA_NGAY
                myCommand.Parameters.Add(pQUA_NGAY)

                Dim pQUA_GIANG As SqlParameter = New SqlParameter("@QUA_GIANG", SqlDbType.Bit, 1)
                pQUA_GIANG.Value = QUA_GIANG
                myCommand.Parameters.Add(pQUA_GIANG)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Sub
#End Region
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Danh_Muc_Duong_Bay
        ' Input: Id_Duong_Bay,  Id_Duong_Thu , Loai_van_chuyen , Hang_van_chuyen , So_hieu , Noi_GUI , Noi_NHAN , BC_GUI , BC_NHAN , GIO_KHOI_HANH , GIO_DEN , QUA_NGAY , QUA_GIANG ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_Duong_Bay As String, ByVal Id_Duong_Thu As String, ByVal Loai_van_chuyen As Integer, ByVal So_hieu As String, ByVal Noi_GUI As String, ByVal Noi_NHAN As String, ByVal BC_GUI As String, ByVal BC_NHAN As String, ByVal GIO_KHOI_HANH As Integer, ByVal GIO_DEN As Integer, ByVal QUA_NGAY As Boolean, ByVal QUA_GIANG As Boolean, ByVal SO_CHANG As Integer, ByVal SU_DUNG As Integer, ByVal MA_BC_QUA_GIANG As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_Duong_Bay_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Duong_Bay As SqlParameter = New SqlParameter("@Id_Duong_Bay", SqlDbType.VarChar, 30)
                pId_Duong_Bay.Value = Id_Duong_Bay
                myCommand.Parameters.Add(pId_Duong_Bay)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pLoai_van_chuyen As SqlParameter = New SqlParameter("@Loai_van_chuyen", SqlDbType.Int, 4)
                pLoai_van_chuyen.Value = Loai_van_chuyen
                myCommand.Parameters.Add(pLoai_van_chuyen)

                Dim pSo_hieu As SqlParameter = New SqlParameter("@So_hieu", SqlDbType.VarChar, 20)
                pSo_hieu.Value = So_hieu
                myCommand.Parameters.Add(pSo_hieu)

                Dim pNoi_GUI As SqlParameter = New SqlParameter("@Noi_GUI", SqlDbType.VarChar, 20)
                pNoi_GUI.Value = Noi_GUI
                myCommand.Parameters.Add(pNoi_GUI)

                Dim pNoi_NHAN As SqlParameter = New SqlParameter("@Noi_NHAN", SqlDbType.VarChar, 3)
                pNoi_NHAN.Value = Noi_NHAN
                myCommand.Parameters.Add(pNoi_NHAN)

                Dim pBC_GUI As SqlParameter = New SqlParameter("@BC_GUI", SqlDbType.VarChar, 6)
                pBC_GUI.Value = BC_GUI
                myCommand.Parameters.Add(pBC_GUI)

                Dim pBC_NHAN As SqlParameter = New SqlParameter("@BC_NHAN", SqlDbType.VarChar, 6)
                pBC_NHAN.Value = BC_NHAN
                myCommand.Parameters.Add(pBC_NHAN)

                Dim pGIO_KHOI_HANH As SqlParameter = New SqlParameter("@GIO_KHOI_HANH", SqlDbType.Int, 4)
                pGIO_KHOI_HANH.Value = GIO_KHOI_HANH
                myCommand.Parameters.Add(pGIO_KHOI_HANH)

                Dim pGIO_DEN As SqlParameter = New SqlParameter("@GIO_DEN", SqlDbType.Int, 4)
                pGIO_DEN.Value = GIO_DEN
                myCommand.Parameters.Add(pGIO_DEN)

                Dim pQUA_NGAY As SqlParameter = New SqlParameter("@QUA_NGAY", SqlDbType.Bit, 1)
                pQUA_NGAY.Value = QUA_NGAY
                myCommand.Parameters.Add(pQUA_NGAY)

                Dim pQUA_GIANG As SqlParameter = New SqlParameter("@QUA_GIANG", SqlDbType.Bit, 1)
                pQUA_GIANG.Value = QUA_GIANG
                myCommand.Parameters.Add(pQUA_GIANG)

                Dim pSO_CHANG As SqlParameter = New SqlParameter("@SO_CHANG", SqlDbType.Int, 4)
                pSO_CHANG.Value = SO_CHANG
                myCommand.Parameters.Add(pSO_CHANG)

                Dim pSU_DUNG As SqlParameter = New SqlParameter("@SU_DUNG", SqlDbType.Int, 4)
                pSU_DUNG.Value = SU_DUNG
                myCommand.Parameters.Add(pSU_DUNG)

                Dim pMA_BC_QUA_GIANG As SqlParameter = New SqlParameter("@MA_BC_QUA_GIANG", SqlDbType.Int, 4)
                pMA_BC_QUA_GIANG.Value = MA_BC_QUA_GIANG
                myCommand.Parameters.Add(pMA_BC_QUA_GIANG)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Danh_Muc_Duong_Bay
        ' Input: Id_Duong_Bay,  Id_Duong_Thu , Loai_van_chuyen , Hang_van_chuyen , So_hieu , Noi_GUI , Noi_NHAN , BC_GUI , BC_NHAN , GIO_KHOI_HANH , GIO_DEN , QUA_NGAY , QUA_GIANG ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Id_Duong_Bay As String, ByVal Id_Duong_Thu As String, ByVal Loai_van_chuyen As Integer, ByVal So_hieu As String, ByVal Noi_GUI As String, ByVal Noi_NHAN As String, ByVal BC_GUI As String, ByVal BC_NHAN As String, ByVal GIO_KHOI_HANH As Integer, ByVal GIO_DEN As Integer, ByVal QUA_NGAY As Boolean, ByVal QUA_GIANG As Boolean, ByVal SO_CHANG As Integer, ByVal SU_DUNG As Integer, ByVal MA_BC_QUA_GIANG As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_Duong_Bay_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Duong_Bay As SqlParameter = New SqlParameter("@Id_Duong_Bay", SqlDbType.VarChar, 30)
                pId_Duong_Bay.Value = Id_Duong_Bay
                myCommand.Parameters.Add(pId_Duong_Bay)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pLoai_van_chuyen As SqlParameter = New SqlParameter("@Loai_van_chuyen", SqlDbType.Int, 4)
                pLoai_van_chuyen.Value = Loai_van_chuyen
                myCommand.Parameters.Add(pLoai_van_chuyen)

                Dim pSo_hieu As SqlParameter = New SqlParameter("@So_hieu", SqlDbType.VarChar, 20)
                pSo_hieu.Value = So_hieu
                myCommand.Parameters.Add(pSo_hieu)

                Dim pNoi_GUI As SqlParameter = New SqlParameter("@Noi_GUI", SqlDbType.VarChar, 20)
                pNoi_GUI.Value = Noi_GUI
                myCommand.Parameters.Add(pNoi_GUI)

                Dim pNoi_NHAN As SqlParameter = New SqlParameter("@Noi_NHAN", SqlDbType.VarChar, 3)
                pNoi_NHAN.Value = Noi_NHAN
                myCommand.Parameters.Add(pNoi_NHAN)

                Dim pBC_GUI As SqlParameter = New SqlParameter("@BC_GUI", SqlDbType.VarChar, 6)
                pBC_GUI.Value = BC_GUI
                myCommand.Parameters.Add(pBC_GUI)

                Dim pBC_NHAN As SqlParameter = New SqlParameter("@BC_NHAN", SqlDbType.VarChar, 6)
                pBC_NHAN.Value = BC_NHAN
                myCommand.Parameters.Add(pBC_NHAN)

                Dim pGIO_KHOI_HANH As SqlParameter = New SqlParameter("@GIO_KHOI_HANH", SqlDbType.Int, 4)
                pGIO_KHOI_HANH.Value = GIO_KHOI_HANH
                myCommand.Parameters.Add(pGIO_KHOI_HANH)

                Dim pGIO_DEN As SqlParameter = New SqlParameter("@GIO_DEN", SqlDbType.Int, 4)
                pGIO_DEN.Value = GIO_DEN
                myCommand.Parameters.Add(pGIO_DEN)

                Dim pQUA_NGAY As SqlParameter = New SqlParameter("@QUA_NGAY", SqlDbType.Bit, 1)
                pQUA_NGAY.Value = QUA_NGAY
                myCommand.Parameters.Add(pQUA_NGAY)

                Dim pQUA_GIANG As SqlParameter = New SqlParameter("@QUA_GIANG", SqlDbType.Bit, 1)
                pQUA_GIANG.Value = QUA_GIANG
                myCommand.Parameters.Add(pQUA_GIANG)

                Dim pSO_CHANG As SqlParameter = New SqlParameter("@SO_CHANG", SqlDbType.Int, 4)
                pSO_CHANG.Value = SO_CHANG
                myCommand.Parameters.Add(pSO_CHANG)

                Dim pSU_DUNG As SqlParameter = New SqlParameter("@SU_DUNG", SqlDbType.Int, 4)
                pSU_DUNG.Value = SU_DUNG
                myCommand.Parameters.Add(pSU_DUNG)

                Dim pMA_BC_QUA_GIANG As SqlParameter = New SqlParameter("@MA_BC_QUA_GIANG", SqlDbType.Int, 4)
                pMA_BC_QUA_GIANG.Value = MA_BC_QUA_GIANG
                myCommand.Parameters.Add(pMA_BC_QUA_GIANG)


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
        ' Nội dung: Xóa dữ liệu từ bảng Danh_Muc_Duong_Bay
        ' Input: Id_Duong_Bay
        ' Output: 
        Public Sub Xoa(ByVal Id_Duong_Bay As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_Duong_Bay_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Duong_Bay As SqlParameter = New SqlParameter("@Id_Duong_Bay", SqlDbType.VarChar, 30)
                pId_Duong_Bay.Value = Id_Duong_Bay
                myCommand.Parameters.Add(pId_Duong_Bay)

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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Danh_Muc_Duong_Bay
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_Duong_Bay_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Danh_Muc_Duong_Bay_Danh_Sach")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Lay_Boi_Duong_Thu_Di_KT"
        Public Function Lay_Boi_Duong_Thu_Di_KT(ByVal Id_Duong_Thu As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_Duong_Bay_Lay_Boi_Duong_Thu_Di_KT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Danh_Muc_Duong_Bay_Lay_Boi_Duong_Thu_Di_KT")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Lay_Boi_Ma_BC"
        ' Ngày tạo: 29/10/08
        ' Người tạo: Quang Trung
        ' Nội dung: Lấy dữ liệu từ bảng Danh_Muc_Duong_Bay theo Ma_BC_KT
        ' Input: Ma_BC_KT
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ma_Bc(ByVal Ma_BC As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_Duong_Bay_Lay_Boi_Ma_BC", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                ' Thêm các Parameters vào thủ tục
                Dim pMa_BC As SqlParameter = New SqlParameter("@Ma_BC", SqlDbType.Int, 4)
                pMa_BC.Value = Ma_BC
                myCommand.Parameters.Add(pMa_BC)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Danh_Muc_Duong_Bay_Lay_Boi_Ma_BC")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ma_BC_Duong_Bay_Khong_Su_Dung"
        ' Ngày tạo: 29/10/08
        ' Người tạo: Quang Trung
        ' Nội dung: Lấy dữ liệu từ bảng Danh_Muc_Duong_Bay theo Ma_BC_KT
        ' Input: Ma_BC_KT
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ma_BC_Duong_Bay_Khong_Su_Dung(ByVal Ma_BC As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_Duong_Bay_Lay_Boi_Ma_BC_Duong_Bay_Khong_Su_Dung", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                ' Thêm các Parameters vào thủ tục
                Dim pMa_BC As SqlParameter = New SqlParameter("@Ma_BC", SqlDbType.Int, 4)
                pMa_BC.Value = Ma_BC
                myCommand.Parameters.Add(pMa_BC)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Danh_Muc_Duong_Bay_Lay_Boi_Ma_BC_Duong_Bay_Khong_Su_Dung")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ma_BC_Duong_Bay_Tat_Ca"
        ' Ngày tạo: 29/10/08
        ' Người tạo: Quang Trung
        ' Nội dung: Lấy dữ liệu từ bảng Danh_Muc_Duong_Bay theo Ma_BC_KT
        ' Input: Ma_BC_KT
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ma_BC_Duong_Bay_Tat_Ca(ByVal Ma_BC As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_Duong_Bay_Lay_Boi_Ma_BC_Tat_Ca_Duong_Bay", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                ' Thêm các Parameters vào thủ tục
                Dim pMa_BC As SqlParameter = New SqlParameter("@Ma_BC", SqlDbType.Int, 4)
                pMa_BC.Value = Ma_BC
                myCommand.Parameters.Add(pMa_BC)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Danh_Muc_Duong_Bay_Lay_Boi_Ma_BC_Tat_Ca_Duong_Bay")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Danh_Muc_Duong_Bay_Lay_Boi_IPMC_So_Hieu"
        ' Ngày tạo: 05/11/08
        ' Người tạo: Quang Trung
        ' Nội dung: Lấy dữ liệu từ bảng Danh_Muc_Duong_Bay theo Bc_Nhan va So_Hieu
        ' Kiem tra su ton tai cua duong bay trong database
        ' Input: Bc_nhan (IPMC) & So_Hieu
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Muc_Duong_Bay_Lay_Boi_IPMC_So_Hieu(ByVal IPMC As String, ByVal So_Hieu As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_Duong_Bay_Lay_Boi_IPMC_So_Hieu", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                ' Thêm các Parameters vào thủ tục
                Dim pIPMC As SqlParameter = New SqlParameter("@Bc_Nhan", SqlDbType.VarChar, 6)
                pIPMC.Value = IPMC
                myCommand.Parameters.Add(pIPMC)
                Dim pSo_Hieu As SqlParameter = New SqlParameter("@So_Hieu", SqlDbType.VarChar, 20)
                pSo_Hieu.Value = So_Hieu
                myCommand.Parameters.Add(pSo_Hieu)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Danh_Muc_Duong_Bay_Lay_Boi_IPMC_So_Hieu")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Danh_Muc_Duong_Bay_Lay_Boi_Duong_Thu_Di_So_Hieu"
        ' Ngày tạo: 05/11/08
        ' Người tạo: Quang Trung
        ' Nội dung: Lấy dữ liệu từ bảng Danh_Muc_Duong_Bay theo Bc_Nhan va So_Hieu
        ' Kiem tra su ton tai cua duong bay trong database
        ' Input: Bc_nhan (IPMC) & So_Hieu
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Muc_Duong_Bay_Lay_Boi_Duong_Thu_Di_So_Hieu(ByVal Id_Duong_Thu As String, ByVal So_Hieu As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_Duong_Bay_Lay_Boi_Duong_Thu_Di_So_Hieu", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                ' Thêm các Parameters vào thủ tục
                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)
                Dim pSo_Hieu As SqlParameter = New SqlParameter("@So_Hieu", SqlDbType.VarChar, 20)
                pSo_Hieu.Value = So_Hieu
                myCommand.Parameters.Add(pSo_Hieu)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Danh_Muc_Duong_Bay_Lay_Boi_IPMC_So_Hieu")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Danh_Muc_Duong_Bay_Lay_Danh_Sach_Ma_Bc_Qua_Giang"

        Public Function Danh_Muc_Duong_Bay_Lay_Danh_Sach_Ma_Bc_Qua_Giang() As DataSet

            ' The procedure returns these columns:
            ' Ma_Bc
            ' IPMC
            ' Ten_Bc


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Duong_Bay_Lay_Danh_Sach_Ma_Bc_Qua_Giang"
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

        '#Region "Cap_Nhat"
        '        ' Ngày tạo: 15/6/08
        '        ' Người tạo: Nguyễn Bằng
        '        ' Nội dung: Cập nhật dữ liệu vào bảng Danh_Muc_Duong_Bay
        '        ' Input: đối tượng thuộc lớp Danh_Muc_Duong_Bay_Chi_Tiet
        '        ' Output: 
        '        Public Sub Cap_Nhat(ByVal myDanh_Muc_Duong_Bay_Chi_Tiet As Danh_Muc_Duong_Bay_Chi_Tiet)
        '            Try
        '                ' Tạo đối tượng connection và command
        '                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
        '                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_Duong_Bay_Cap_Nhat", myConnection)

        '                ' Sử dụng Store Procedure
        '                myCommand.CommandType = CommandType.StoredProcedure
        '                ' Thêm các Parameters vào thủ tục						
        '                Dim pId_Duong_Bay As SqlParameter = New SqlParameter("@Id_Duong_Bay", SqlDbType.VarChar, 30)
        '                pId_Duong_Bay.Value = myDanh_Muc_Duong_Bay_Chi_Tiet.Id_Duong_Bay
        '                myCommand.Parameters.Add(pId_Duong_Bay)

        '                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 13)
        '                pId_Duong_Thu.Value = myDanh_Muc_Duong_Bay_Chi_Tiet.Id_Duong_Thu
        '                myCommand.Parameters.Add(pId_Duong_Thu)

        '                Dim pLoai_van_chuyen As SqlParameter = New SqlParameter("@Loai_van_chuyen", SqlDbType.Int, 4)
        '                pLoai_van_chuyen.Value = myDanh_Muc_Duong_Bay_Chi_Tiet.Loai_van_chuyen
        '                myCommand.Parameters.Add(pLoai_van_chuyen)

        '                Dim pHang_van_chuyen As SqlParameter = New SqlParameter("@Hang_van_chuyen", SqlDbType.VarChar, 2)
        '                pHang_van_chuyen.Value = myDanh_Muc_Duong_Bay_Chi_Tiet.Hang_van_chuyen
        '                myCommand.Parameters.Add(pHang_van_chuyen)

        '                Dim pSo_hieu As SqlParameter = New SqlParameter("@So_hieu", SqlDbType.VarChar, 5)
        '                pSo_hieu.Value = myDanh_Muc_Duong_Bay_Chi_Tiet.So_hieu
        '                myCommand.Parameters.Add(pSo_hieu)

        '                Dim pNoi_GUI As SqlParameter = New SqlParameter("@Noi_GUI", SqlDbType.VarChar, 3)
        '                pNoi_GUI.Value = myDanh_Muc_Duong_Bay_Chi_Tiet.Noi_GUI
        '                myCommand.Parameters.Add(pNoi_GUI)

        '                Dim pNoi_NHAN As SqlParameter = New SqlParameter("@Noi_NHAN", SqlDbType.VarChar, 3)
        '                pNoi_NHAN.Value = myDanh_Muc_Duong_Bay_Chi_Tiet.Noi_NHAN
        '                myCommand.Parameters.Add(pNoi_NHAN)

        '                Dim pBC_GUI As SqlParameter = New SqlParameter("@BC_GUI", SqlDbType.VarChar, 6)
        '                pBC_GUI.Value = myDanh_Muc_Duong_Bay_Chi_Tiet.BC_GUI
        '                myCommand.Parameters.Add(pBC_GUI)

        '                Dim pBC_NHAN As SqlParameter = New SqlParameter("@BC_NHAN", SqlDbType.VarChar, 6)
        '                pBC_NHAN.Value = myDanh_Muc_Duong_Bay_Chi_Tiet.BC_NHAN
        '                myCommand.Parameters.Add(pBC_NHAN)

        '                Dim pGIO_KHOI_HANH As SqlParameter = New SqlParameter("@GIO_KHOI_HANH", SqlDbType.Int, 4)
        '                pGIO_KHOI_HANH.Value = myDanh_Muc_Duong_Bay_Chi_Tiet.GIO_KHOI_HANH
        '                myCommand.Parameters.Add(pGIO_KHOI_HANH)

        '                Dim pGIO_DEN As SqlParameter = New SqlParameter("@GIO_DEN", SqlDbType.Int, 4)
        '                pGIO_DEN.Value = myDanh_Muc_Duong_Bay_Chi_Tiet.GIO_DEN
        '                myCommand.Parameters.Add(pGIO_DEN)

        '                Dim pQUA_NGAY As SqlParameter = New SqlParameter("@QUA_NGAY", SqlDbType.Bit, 1)
        '                pQUA_NGAY.Value = myDanh_Muc_Duong_Bay_Chi_Tiet.QUA_NGAY
        '                myCommand.Parameters.Add(pQUA_NGAY)

        '                Dim pQUA_GIANG As SqlParameter = New SqlParameter("@QUA_GIANG", SqlDbType.Bit, 1)
        '                pQUA_GIANG.Value = myDanh_Muc_Duong_Bay_Chi_Tiet.QUA_GIANG
        '                myCommand.Parameters.Add(pQUA_GIANG)


        '                myConnection.Open()
        '                myCommand.ExecuteNonQuery()
        '                myConnection.Close()
        '                myConnection.Dispose()
        '            Catch ex As Exception
        '                Console.Write(ex.ToString)

        '            End Try
        '        End Sub
        '#End Region

        '#Region "Cap_Nhat_Them"
        '        ' Ngày tạo: 15/6/08
        '        ' Người tạo: Nguyễn Bằng
        '        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Danh_Muc_Duong_Bay
        '        ' Input: đối tượng datatable
        '        ' Output: 
        '        Public Sub Cap_Nhat_Them(ByVal myDataTable As DataTable)
        '            Try
        '                ' Tạo đối tượng connection và command
        '                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
        '                myConnection.Open()
        '                Dim i As Integer
        '                For i = 0 To myDataTable.Rows.Count - 1
        '                    Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_Duong_Bay_Cap_Nhat_Them", myConnection)

        '                    ' Sử dụng Store Procedure
        '                    myCommand.CommandType = CommandType.StoredProcedure
        '                    ' Thêm các Parameters vào thủ tục				

        '                    Dim pId_Duong_Bay As SqlParameter = New SqlParameter("@Id_Duong_Bay", SqlDbType.VarChar, 30)
        '                    pId_Duong_Bay.Value = Convert.ToString(myDataTable.Rows(i).Item("Id_Duong_Bay"))
        '                    myCommand.Parameters.Add(pId_Duong_Bay)

        '                    Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 13)
        '                    pId_Duong_Thu.Value = Convert.ToString(myDataTable.Rows(i).Item("Id_Duong_Thu"))
        '                    myCommand.Parameters.Add(pId_Duong_Thu)

        '                    Dim pLoai_van_chuyen As SqlParameter = New SqlParameter("@Loai_van_chuyen", SqlDbType.Int, 4)
        '                    pLoai_van_chuyen.Value = Convert.ToInt32(myDataTable.Rows(i).Item("Loai_van_chuyen"))
        '                    myCommand.Parameters.Add(pLoai_van_chuyen)

        '                    Dim pHang_van_chuyen As SqlParameter = New SqlParameter("@Hang_van_chuyen", SqlDbType.VarChar, 2)
        '                    pHang_van_chuyen.Value = Convert.ToString(myDataTable.Rows(i).Item("Hang_van_chuyen"))
        '                    myCommand.Parameters.Add(pHang_van_chuyen)

        '                    Dim pSo_hieu As SqlParameter = New SqlParameter("@So_hieu", SqlDbType.VarChar, 5)
        '                    pSo_hieu.Value = Convert.ToString(myDataTable.Rows(i).Item("So_hieu"))
        '                    myCommand.Parameters.Add(pSo_hieu)

        '                    Dim pNoi_GUI As SqlParameter = New SqlParameter("@Noi_GUI", SqlDbType.VarChar, 3)
        '                    pNoi_GUI.Value = Convert.ToString(myDataTable.Rows(i).Item("Noi_GUI"))
        '                    myCommand.Parameters.Add(pNoi_GUI)

        '                    Dim pNoi_NHAN As SqlParameter = New SqlParameter("@Noi_NHAN", SqlDbType.VarChar, 3)
        '                    pNoi_NHAN.Value = Convert.ToString(myDataTable.Rows(i).Item("Noi_NHAN"))
        '                    myCommand.Parameters.Add(pNoi_NHAN)

        '                    Dim pBC_GUI As SqlParameter = New SqlParameter("@BC_GUI", SqlDbType.VarChar, 6)
        '                    pBC_GUI.Value = Convert.ToString(myDataTable.Rows(i).Item("BC_GUI"))
        '                    myCommand.Parameters.Add(pBC_GUI)

        '                    Dim pBC_NHAN As SqlParameter = New SqlParameter("@BC_NHAN", SqlDbType.VarChar, 6)
        '                    pBC_NHAN.Value = Convert.ToString(myDataTable.Rows(i).Item("BC_NHAN"))
        '                    myCommand.Parameters.Add(pBC_NHAN)

        '                    Dim pGIO_KHOI_HANH As SqlParameter = New SqlParameter("@GIO_KHOI_HANH", SqlDbType.Int, 4)
        '                    pGIO_KHOI_HANH.Value = Convert.ToInt32(myDataTable.Rows(i).Item("GIO_KHOI_HANH"))
        '                    myCommand.Parameters.Add(pGIO_KHOI_HANH)

        '                    Dim pGIO_DEN As SqlParameter = New SqlParameter("@GIO_DEN", SqlDbType.Int, 4)
        '                    pGIO_DEN.Value = Convert.ToInt32(myDataTable.Rows(i).Item("GIO_DEN"))
        '                    myCommand.Parameters.Add(pGIO_DEN)

        '                    Dim pQUA_NGAY As SqlParameter = New SqlParameter("@QUA_NGAY", SqlDbType.Bit, 1)
        '                    pQUA_NGAY.Value = Convert.ToBoolean(myDataTable.Rows(i).Item("QUA_NGAY"))
        '                    myCommand.Parameters.Add(pQUA_NGAY)

        '                    Dim pQUA_GIANG As SqlParameter = New SqlParameter("@QUA_GIANG", SqlDbType.Bit, 1)
        '                    pQUA_GIANG.Value = Convert.ToBoolean(myDataTable.Rows(i).Item("QUA_GIANG"))
        '                    myCommand.Parameters.Add(pQUA_GIANG)



        '                    myCommand.ExecuteNonQuery()
        '                Next
        '                myConnection.Close()
        '                myConnection.Dispose()
        '            Catch ex As Exception
        '                Console.Write(ex.ToString)
        '            End Try
        '        End Sub
        '#End Region

    End Class
#End Region
End Namespace
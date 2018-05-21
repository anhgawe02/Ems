
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Nguoi_Dung_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Nguoi_Dung_Chi_Tiet
    ' tương ứng với mộ trường của bảng Nguoi_Dung trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Nguoi_Dung_Chi_Tiet
        Public Id_Nguoi_Dung As Integer
        Public Ten_Dang_Nhap As String
        Public Mat_khau As String
        Public Ho_Ten As String
        Public Chuc_Vu As String
        Public Dien_Thoai As String
        Public Email As String
        Public Admin As Boolean
    End Class
#End Region
#Region "Nguoi_Dung"
    Public Class Nguoi_Dung
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Nguoi_Dung
        ' Input: Id_Nguoi_Dung
        ' Output: Nguoi_Dung_Chi_Tiet
        Public Function Lay(ByVal Id_Nguoi_Dung As Integer) As Nguoi_Dung_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Nguoi_Dung_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 4)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pTen_Dang_Nhap As SqlParameter = New SqlParameter("@Ten_Dang_Nhap", SqlDbType.VarChar, 50)
                pTen_Dang_Nhap.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTen_Dang_Nhap)

                Dim pMat_khau As SqlParameter = New SqlParameter("@Mat_khau", SqlDbType.VarChar, 50)
                pMat_khau.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMat_khau)

                Dim pHo_Ten As SqlParameter = New SqlParameter("@Ho_Ten", SqlDbType.NVarChar, 50)
                pHo_Ten.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHo_Ten)

                Dim pChuc_Vu As SqlParameter = New SqlParameter("@Chuc_Vu", SqlDbType.VarChar, 50)
                pChuc_Vu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pChuc_Vu)

                Dim pDien_Thoai As SqlParameter = New SqlParameter("@Dien_Thoai", SqlDbType.VarChar, 50)
                pDien_Thoai.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDien_Thoai)

                Dim pEmail As SqlParameter = New SqlParameter("@Email", SqlDbType.VarChar, 50)
                pEmail.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pEmail)

                Dim pAdmin As SqlParameter = New SqlParameter("@Admin", SqlDbType.Bit)
                pAdmin.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pAdmin)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myNguoi_Dung_Chi_Tiet As Nguoi_Dung_Chi_Tiet = New Nguoi_Dung_Chi_Tiet
                myNguoi_Dung_Chi_Tiet.Id_Nguoi_Dung = Id_Nguoi_Dung
                myNguoi_Dung_Chi_Tiet.Ten_Dang_Nhap = pTen_Dang_Nhap.Value
                myNguoi_Dung_Chi_Tiet.Mat_khau = pMat_khau.Value
                myNguoi_Dung_Chi_Tiet.Ho_Ten = pHo_Ten.Value
                myNguoi_Dung_Chi_Tiet.Chuc_Vu = pChuc_Vu.Value
                myNguoi_Dung_Chi_Tiet.Dien_Thoai = pDien_Thoai.Value
                myNguoi_Dung_Chi_Tiet.Email = pEmail.Value
                myNguoi_Dung_Chi_Tiet.Admin = pAdmin.Value
                Return myNguoi_Dung_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Nguoi_Dung
        ' Input:  Ten_Dang_Nhap, Mat_khau, Ho_Ten, Chuc_Vu, Dien_Thoai, Email,
        ' Output: 
        Public Sub Them(ByVal Ten_Dang_Nhap As String, ByVal Mat_khau As String, ByVal Ho_Ten As String, ByVal Chuc_Vu As String, ByVal Dien_Thoai As String, ByVal Email As String, ByVal Admin As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Nguoi_Dung_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pTen_Dang_Nhap As SqlParameter = New SqlParameter("@Ten_Dang_Nhap", SqlDbType.VarChar, 50)
                pTen_Dang_Nhap.Value = Ten_Dang_Nhap
                myCommand.Parameters.Add(pTen_Dang_Nhap)

                Dim pMat_khau As SqlParameter = New SqlParameter("@Mat_khau", SqlDbType.VarChar, 50)
                pMat_khau.Value = Mat_khau
                myCommand.Parameters.Add(pMat_khau)

                Dim pHo_Ten As SqlParameter = New SqlParameter("@Ho_Ten", SqlDbType.NVarChar, 50)
                pHo_Ten.Value = Ho_Ten
                myCommand.Parameters.Add(pHo_Ten)

                Dim pChuc_Vu As SqlParameter = New SqlParameter("@Chuc_Vu", SqlDbType.VarChar, 50)
                pChuc_Vu.Value = Chuc_Vu
                myCommand.Parameters.Add(pChuc_Vu)

                Dim pDien_Thoai As SqlParameter = New SqlParameter("@Dien_Thoai", SqlDbType.VarChar, 50)
                pDien_Thoai.Value = Dien_Thoai
                myCommand.Parameters.Add(pDien_Thoai)

                Dim pEmail As SqlParameter = New SqlParameter("@Email", SqlDbType.VarChar, 50)
                pEmail.Value = Email
                myCommand.Parameters.Add(pEmail)

                Dim pAdmin As SqlParameter = New SqlParameter("@Admin", SqlDbType.Bit)
                pAdmin.Value = Admin
                myCommand.Parameters.Add(pAdmin)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Nguoi_Dung
        ' Input: Id_Nguoi_Dung,  Ten_Dang_Nhap , Mat_khau , Ho_Ten , Chuc_Vu , Dien_Thoai , Email ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_Nguoi_Dung As Integer, ByVal Ten_Dang_Nhap As String, ByVal Mat_khau As String, ByVal Ho_Ten As String, ByVal Chuc_Vu As String, ByVal Dien_Thoai As String, ByVal Email As String, ByVal Admin As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Nguoi_Dung_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 4)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pTen_Dang_Nhap As SqlParameter = New SqlParameter("@Ten_Dang_Nhap", SqlDbType.VarChar, 50)
                pTen_Dang_Nhap.Value = Ten_Dang_Nhap
                myCommand.Parameters.Add(pTen_Dang_Nhap)

                Dim pMat_khau As SqlParameter = New SqlParameter("@Mat_khau", SqlDbType.VarChar, 50)
                pMat_khau.Value = Mat_khau
                myCommand.Parameters.Add(pMat_khau)

                Dim pHo_Ten As SqlParameter = New SqlParameter("@Ho_Ten", SqlDbType.NVarChar, 150)
                pHo_Ten.Value = Ho_Ten
                myCommand.Parameters.Add(pHo_Ten)

                Dim pChuc_Vu As SqlParameter = New SqlParameter("@Chuc_Vu", SqlDbType.NVarChar, 150)
                pChuc_Vu.Value = Chuc_Vu
                myCommand.Parameters.Add(pChuc_Vu)

                Dim pDien_Thoai As SqlParameter = New SqlParameter("@Dien_Thoai", SqlDbType.VarChar, 50)
                pDien_Thoai.Value = Dien_Thoai
                myCommand.Parameters.Add(pDien_Thoai)

                Dim pEmail As SqlParameter = New SqlParameter("@Email", SqlDbType.VarChar, 50)
                pEmail.Value = Email
                myCommand.Parameters.Add(pEmail)

                Dim pAdmin As SqlParameter = New SqlParameter("@Admin", SqlDbType.Bit)
                pAdmin.Value = Admin
                myCommand.Parameters.Add(pAdmin)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Nguoi_Dung
        ' Input: đối tượng thuộc lớp Nguoi_Dung_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myNguoi_Dung_Chi_Tiet As Nguoi_Dung_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Nguoi_Dung_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 4)
                pId_Nguoi_Dung.Value = myNguoi_Dung_Chi_Tiet.Id_Nguoi_Dung
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pTen_Dang_Nhap As SqlParameter = New SqlParameter("@Ten_Dang_Nhap", SqlDbType.VarChar, 50)
                pTen_Dang_Nhap.Value = myNguoi_Dung_Chi_Tiet.Ten_Dang_Nhap
                myCommand.Parameters.Add(pTen_Dang_Nhap)

                Dim pMat_khau As SqlParameter = New SqlParameter("@Mat_khau", SqlDbType.VarChar, 50)
                pMat_khau.Value = myNguoi_Dung_Chi_Tiet.Mat_khau
                myCommand.Parameters.Add(pMat_khau)

                Dim pHo_Ten As SqlParameter = New SqlParameter("@Ho_Ten", SqlDbType.NVarChar, 150)
                pHo_Ten.Value = myNguoi_Dung_Chi_Tiet.Ho_Ten
                myCommand.Parameters.Add(pHo_Ten)

                Dim pChuc_Vu As SqlParameter = New SqlParameter("@Chuc_Vu", SqlDbType.NVarChar, 150)
                pChuc_Vu.Value = myNguoi_Dung_Chi_Tiet.Chuc_Vu
                myCommand.Parameters.Add(pChuc_Vu)

                Dim pDien_Thoai As SqlParameter = New SqlParameter("@Dien_Thoai", SqlDbType.VarChar, 50)
                pDien_Thoai.Value = myNguoi_Dung_Chi_Tiet.Dien_Thoai
                myCommand.Parameters.Add(pDien_Thoai)

                Dim pEmail As SqlParameter = New SqlParameter("@Email", SqlDbType.VarChar, 50)
                pEmail.Value = myNguoi_Dung_Chi_Tiet.Email
                myCommand.Parameters.Add(pEmail)

                Dim pAdmin As SqlParameter = New SqlParameter("@Admin", SqlDbType.Bit)
                pAdmin.Value = myNguoi_Dung_Chi_Tiet.Admin
                myCommand.Parameters.Add(pAdmin)


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
        ' Nội dung: Xóa dữ liệu từ bảng Nguoi_Dung
        ' Input: Id_Nguoi_Dung
        ' Output: 
        Public Sub Xoa(ByVal Id_Nguoi_Dung As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Nguoi_Dung_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 4)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                myCommand.Parameters.Add(pId_Nguoi_Dung)

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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Nguoi_Dung
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Nguoi_Dung_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Nguoi_Dung_Danh_Sach")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Cap_Nhat_Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Nguoi_Dung
        ' Input: Id_Nguoi_Dung,  Ten_Dang_Nhap , Mat_khau , Ho_Ten , Chuc_Vu , Dien_Thoai , Email ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Id_Nguoi_Dung As Integer, ByVal Ten_Dang_Nhap As String, ByVal Mat_khau As String, ByVal Ho_Ten As String, ByVal Chuc_Vu As String, ByVal Dien_Thoai As String, ByVal Email As String, ByVal Admin As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Nguoi_Dung_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 4)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pTen_Dang_Nhap As SqlParameter = New SqlParameter("@Ten_Dang_Nhap", SqlDbType.VarChar, 50)
                pTen_Dang_Nhap.Value = Ten_Dang_Nhap
                myCommand.Parameters.Add(pTen_Dang_Nhap)

                Dim pMat_khau As SqlParameter = New SqlParameter("@Mat_khau", SqlDbType.VarChar, 50)
                pMat_khau.Value = Mat_khau
                myCommand.Parameters.Add(pMat_khau)

                Dim pHo_Ten As SqlParameter = New SqlParameter("@Ho_Ten", SqlDbType.NVarChar, 150)
                pHo_Ten.Value = Ho_Ten
                myCommand.Parameters.Add(pHo_Ten)

                Dim pChuc_Vu As SqlParameter = New SqlParameter("@Chuc_Vu", SqlDbType.NVarChar, 150)
                pChuc_Vu.Value = Chuc_Vu
                myCommand.Parameters.Add(pChuc_Vu)

                Dim pDien_Thoai As SqlParameter = New SqlParameter("@Dien_Thoai", SqlDbType.VarChar, 50)
                pDien_Thoai.Value = Dien_Thoai
                myCommand.Parameters.Add(pDien_Thoai)

                Dim pEmail As SqlParameter = New SqlParameter("@Email", SqlDbType.VarChar, 50)
                pEmail.Value = Email
                myCommand.Parameters.Add(pEmail)

                Dim pAdmin As SqlParameter = New SqlParameter("@Admin", SqlDbType.Bit)
                pAdmin.Value = Admin
                myCommand.Parameters.Add(pAdmin)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region
        'Them
#Region "Lay_Boi_Ten_Dang_Nhap"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Nguoi_Dung
        ' Input: Ten_Dang_Nhap, Mat_Khau
        ' Output: Nguoi_Dung_Chi_Tiet
        Public Function Lay_Boi_Ten_Dang_Nhap(ByVal Ten_Dang_Nhap As String, ByVal Mat_Khau As String) As Nguoi_Dung_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Nguoi_Dung_Lay_Boi_Ten_Dang_Nhap", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 4)
                pId_Nguoi_Dung.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pTen_Dang_Nhap As SqlParameter = New SqlParameter("@Ten_Dang_Nhap", SqlDbType.VarChar, 50)
                pTen_Dang_Nhap.Value = Ten_Dang_Nhap
                myCommand.Parameters.Add(pTen_Dang_Nhap)

                Dim pMat_khau As SqlParameter = New SqlParameter("@Mat_khau", SqlDbType.VarChar, 50)
                pMat_khau.Value = Mat_Khau
                myCommand.Parameters.Add(pMat_khau)

                Dim pHo_Ten As SqlParameter = New SqlParameter("@Ho_Ten", SqlDbType.NVarChar, 50)
                pHo_Ten.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHo_Ten)

                Dim pChuc_Vu As SqlParameter = New SqlParameter("@Chuc_Vu", SqlDbType.VarChar, 50)
                pChuc_Vu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pChuc_Vu)

                Dim pDien_Thoai As SqlParameter = New SqlParameter("@Dien_Thoai", SqlDbType.VarChar, 50)
                pDien_Thoai.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDien_Thoai)

                Dim pEmail As SqlParameter = New SqlParameter("@Email", SqlDbType.VarChar, 50)
                pEmail.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pEmail)

                Dim pAdmin As SqlParameter = New SqlParameter("@Admin", SqlDbType.Bit)
                pAdmin.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pAdmin)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myNguoi_Dung_Chi_Tiet As Nguoi_Dung_Chi_Tiet = New Nguoi_Dung_Chi_Tiet
                myNguoi_Dung_Chi_Tiet.Id_Nguoi_Dung = pId_Nguoi_Dung.Value
                myNguoi_Dung_Chi_Tiet.Ten_Dang_Nhap = Ten_Dang_Nhap
                myNguoi_Dung_Chi_Tiet.Mat_khau = Mat_Khau
                myNguoi_Dung_Chi_Tiet.Ho_Ten = pHo_Ten.Value
                myNguoi_Dung_Chi_Tiet.Chuc_Vu = pChuc_Vu.Value
                myNguoi_Dung_Chi_Tiet.Dien_Thoai = pDien_Thoai.Value
                myNguoi_Dung_Chi_Tiet.Email = pEmail.Value
                myNguoi_Dung_Chi_Tiet.Admin = pAdmin.Value
                Return myNguoi_Dung_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Xoa_Boi_Ten_Dang_Nhap"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng Nguoi_Dung
        ' Input: Id_Nguoi_Dung
        ' Output: 
        Public Sub Xoa_Boi_Ten_Dang_Nhap(ByVal Ten_Dang_Nhap As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Nguoi_Dung_Xoa_Boi_Ten_Dang_Nhap", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pTen_Dang_Nhap As SqlParameter = New SqlParameter("@Ten_Dang_Nhap", SqlDbType.VarChar, 50)
                pTen_Dang_Nhap.Value = Ten_Dang_Nhap
                myCommand.Parameters.Add(pTen_Dang_Nhap)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)


            End Try
        End Sub
#End Region
#Region "Danh_Sach_Chuc_Nang"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ Danh sach chuc nang ma nguoi dung duoc xai
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Chuc_Nang(ByVal Ten_Dang_Nhap As String, ByVal Nhom_Chuc_Nang As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Nguoi_Dung_Danh_Sach_Chuc_Nang", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                Dim pTen_Dang_Nhap As SqlParameter = New SqlParameter("@Ten_Dang_Nhap", SqlDbType.VarChar, 50)
                pTen_Dang_Nhap.Value = Ten_Dang_Nhap
                myCommand.Parameters.Add(pTen_Dang_Nhap)

                Dim pNhom_Chuc_Nang As SqlParameter = New SqlParameter("@Nhom_Chuc_Nang", SqlDbType.NVarChar, 200)
                pNhom_Chuc_Nang.Value = Nhom_Chuc_Nang
                myCommand.Parameters.Add(pNhom_Chuc_Nang)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Nguoi_Dung_Danh_Sach_Chuc_Nang")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Lay_Boi_Mot_Nguoi"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Nguoi_Dung
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về một người 
        Public Function Lay_Boi_Mot_Nguoi(ByVal Id_Nguoi_Dung As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Nguoi_Dung_Lay_Boi_Mot_Nguoi", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 4)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Nguoi_Dung_Lay_Boi_Mot_Nguoi")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Xet_Lai_Quyen_Han"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng Nguoi_Dung
        ' Input: Id_Nguoi_Dung
        ' Output: 
        Public Sub Xet_Lai_Quyen_Han(ByVal Id_Nguoi_Dung As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Nguoi_Dung_Xet_Lai_Quyen_Han", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 4)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                myCommand.Parameters.Add(pId_Nguoi_Dung)

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

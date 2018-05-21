
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Toa_Do_In_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Toa_Do_In_Chi_Tiet
    ' tương ứng với mộ trường của bảng Toa_Do_In trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Toa_Do_In_Chi_Tiet
        Public Id_Toa_Do As Integer ' Tự tăng
        Public Kho_Giay As String ' Khổ giấy in thả chữ (E1, E2, HoaDon,...)
        Public Ten_Doi_Tuong As String ' Tên đối tượng thuộc khổ giấy đấy
        Public Ten_Doi_Tuong_VN As String
        Public Toa_Do_Top As Integer ' Tọa độ Top của đối tượng
        Public Toa_Do_Left As Integer ' Tọa độ Left
    End Class
#End Region
#Region "Toa_Do_In"
    Public Class Toa_Do_In
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Toa_Do_In
        ' Input: Id_Toa_Do
        ' Output: Toa_Do_In_Chi_Tiet
        Public Function Lay(ByVal Id_Toa_Do As Integer) As Toa_Do_In_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Toa_Do_In_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Toa_Do As SqlParameter = New SqlParameter("@Id_Toa_Do", SqlDbType.Int, 4)
                pId_Toa_Do.Value = Id_Toa_Do
                myCommand.Parameters.Add(pId_Toa_Do)

                Dim pKho_Giay As SqlParameter = New SqlParameter("@Kho_Giay", SqlDbType.VarChar, 50)
                pKho_Giay.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pKho_Giay)

                Dim pTen_Doi_Tuong As SqlParameter = New SqlParameter("@Ten_Doi_Tuong", SqlDbType.VarChar, 100)
                pTen_Doi_Tuong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTen_Doi_Tuong)

                Dim pTen_Doi_Tuong_VN As SqlParameter = New SqlParameter("@Ten_Doi_Tuong_VN", SqlDbType.NVarChar, 50)
                pTen_Doi_Tuong_VN.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTen_Doi_Tuong_VN)

                Dim pToa_Do_Top As SqlParameter = New SqlParameter("@Toa_Do_Top", SqlDbType.Int, 4)
                pToa_Do_Top.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pToa_Do_Top)

                Dim pToa_Do_Left As SqlParameter = New SqlParameter("@Toa_Do_Left", SqlDbType.Int, 4)
                pToa_Do_Left.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pToa_Do_Left)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                Dim myToa_Do_In_Chi_Tiet As Toa_Do_In_Chi_Tiet = New Toa_Do_In_Chi_Tiet
                myToa_Do_In_Chi_Tiet.Id_Toa_Do = Id_Toa_Do
                myToa_Do_In_Chi_Tiet.Kho_Giay = pKho_Giay.Value
                myToa_Do_In_Chi_Tiet.Ten_Doi_Tuong = pTen_Doi_Tuong.Value
                myToa_Do_In_Chi_Tiet.Ten_Doi_Tuong_VN = pTen_Doi_Tuong_VN.Value
                myToa_Do_In_Chi_Tiet.Toa_Do_Top = pToa_Do_Top.Value
                myToa_Do_In_Chi_Tiet.Toa_Do_Left = pToa_Do_Left.Value
                Return myToa_Do_In_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Toa_Do_In
        ' Input:  Kho_Giay, Ten_Doi_Tuong, Ten_Doi_Tuong_VN, Toa_Do_Top, Toa_Do_Left,
        ' Output: 
        Public Sub Them(ByVal Kho_Giay As String, ByVal Ten_Doi_Tuong As String, ByVal Ten_Doi_Tuong_VN As String, ByVal Toa_Do_Top As Integer, ByVal Toa_Do_Left As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Toa_Do_In_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pKho_Giay As SqlParameter = New SqlParameter("@Kho_Giay", SqlDbType.VarChar, 50)
                pKho_Giay.Value = Kho_Giay
                myCommand.Parameters.Add(pKho_Giay)

                Dim pTen_Doi_Tuong As SqlParameter = New SqlParameter("@Ten_Doi_Tuong", SqlDbType.VarChar, 100)
                pTen_Doi_Tuong.Value = Ten_Doi_Tuong
                myCommand.Parameters.Add(pTen_Doi_Tuong)

                Dim pTen_Doi_Tuong_VN As SqlParameter = New SqlParameter("@Ten_Doi_Tuong_VN", SqlDbType.NVarChar, 50)
                pTen_Doi_Tuong_VN.Value = Ten_Doi_Tuong_VN
                myCommand.Parameters.Add(pTen_Doi_Tuong_VN)

                Dim pToa_Do_Top As SqlParameter = New SqlParameter("@Toa_Do_Top", SqlDbType.Int, 4)
                pToa_Do_Top.Value = Toa_Do_Top
                myCommand.Parameters.Add(pToa_Do_Top)

                Dim pToa_Do_Left As SqlParameter = New SqlParameter("@Toa_Do_Left", SqlDbType.Int, 4)
                pToa_Do_Left.Value = Toa_Do_Left
                myCommand.Parameters.Add(pToa_Do_Left)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Toa_Do_In
        ' Input: Id_Toa_Do,  Kho_Giay , Ten_Doi_Tuong , Ten_Doi_Tuong_VN , Toa_Do_Top , Toa_Do_Left ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_Toa_Do As Integer, ByVal Kho_Giay As String, ByVal Ten_Doi_Tuong As String, ByVal Ten_Doi_Tuong_VN As String, ByVal Toa_Do_Top As Integer, ByVal Toa_Do_Left As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Toa_Do_In_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Toa_Do As SqlParameter = New SqlParameter("@Id_Toa_Do", SqlDbType.Int, 4)
                pId_Toa_Do.Value = Id_Toa_Do
                myCommand.Parameters.Add(pId_Toa_Do)

                Dim pKho_Giay As SqlParameter = New SqlParameter("@Kho_Giay", SqlDbType.VarChar, 50)
                pKho_Giay.Value = Kho_Giay
                myCommand.Parameters.Add(pKho_Giay)

                Dim pTen_Doi_Tuong As SqlParameter = New SqlParameter("@Ten_Doi_Tuong", SqlDbType.VarChar, 100)
                pTen_Doi_Tuong.Value = Ten_Doi_Tuong
                myCommand.Parameters.Add(pTen_Doi_Tuong)

                Dim pTen_Doi_Tuong_VN As SqlParameter = New SqlParameter("@Ten_Doi_Tuong_VN", SqlDbType.NVarChar, 50)
                pTen_Doi_Tuong_VN.Value = Ten_Doi_Tuong_VN
                myCommand.Parameters.Add(pTen_Doi_Tuong_VN)

                Dim pToa_Do_Top As SqlParameter = New SqlParameter("@Toa_Do_Top", SqlDbType.Int, 4)
                pToa_Do_Top.Value = Toa_Do_Top
                myCommand.Parameters.Add(pToa_Do_Top)

                Dim pToa_Do_Left As SqlParameter = New SqlParameter("@Toa_Do_Left", SqlDbType.Int, 4)
                pToa_Do_Left.Value = Toa_Do_Left
                myCommand.Parameters.Add(pToa_Do_Left)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Toa_Do_In
        ' Input: đối tượng thuộc lớp Toa_Do_In_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myToa_Do_In_Chi_Tiet As Toa_Do_In_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Toa_Do_In_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_Toa_Do As SqlParameter = New SqlParameter("@Id_Toa_Do", SqlDbType.Int, 4)
                pId_Toa_Do.Value = myToa_Do_In_Chi_Tiet.Id_Toa_Do
                myCommand.Parameters.Add(pId_Toa_Do)

                Dim pKho_Giay As SqlParameter = New SqlParameter("@Kho_Giay", SqlDbType.VarChar, 50)
                pKho_Giay.Value = myToa_Do_In_Chi_Tiet.Kho_Giay
                myCommand.Parameters.Add(pKho_Giay)

                Dim pTen_Doi_Tuong As SqlParameter = New SqlParameter("@Ten_Doi_Tuong", SqlDbType.VarChar, 100)
                pTen_Doi_Tuong.Value = myToa_Do_In_Chi_Tiet.Ten_Doi_Tuong
                myCommand.Parameters.Add(pTen_Doi_Tuong)

                Dim pTen_Doi_Tuong_VN As SqlParameter = New SqlParameter("@Ten_Doi_Tuong_VN", SqlDbType.NVarChar, 50)
                pTen_Doi_Tuong_VN.Value = myToa_Do_In_Chi_Tiet.Ten_Doi_Tuong_VN
                myCommand.Parameters.Add(pTen_Doi_Tuong_VN)

                Dim pToa_Do_Top As SqlParameter = New SqlParameter("@Toa_Do_Top", SqlDbType.Int, 4)
                pToa_Do_Top.Value = myToa_Do_In_Chi_Tiet.Toa_Do_Top
                myCommand.Parameters.Add(pToa_Do_Top)

                Dim pToa_Do_Left As SqlParameter = New SqlParameter("@Toa_Do_Left", SqlDbType.Int, 4)
                pToa_Do_Left.Value = myToa_Do_In_Chi_Tiet.Toa_Do_Left
                myCommand.Parameters.Add(pToa_Do_Left)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Toa_Do_In
        ' Input: Id_Toa_Do,  Kho_Giay , Ten_Doi_Tuong , Ten_Doi_Tuong_VN , Toa_Do_Top , Toa_Do_Left ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Kho_Giay As String, ByVal Ten_Doi_Tuong As String, ByVal Ten_Doi_Tuong_VN As String, ByVal Toa_Do_Top As Integer, ByVal Toa_Do_Left As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Toa_Do_In_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục             

                Dim pKho_Giay As SqlParameter = New SqlParameter("@Kho_Giay", SqlDbType.VarChar, 50)
                pKho_Giay.Value = Kho_Giay
                myCommand.Parameters.Add(pKho_Giay)

                Dim pTen_Doi_Tuong As SqlParameter = New SqlParameter("@Ten_Doi_Tuong", SqlDbType.VarChar, 100)
                pTen_Doi_Tuong.Value = Ten_Doi_Tuong
                myCommand.Parameters.Add(pTen_Doi_Tuong)

                Dim pTen_Doi_Tuong_VN As SqlParameter = New SqlParameter("@Ten_Doi_Tuong_VN", SqlDbType.NVarChar, 50)
                pTen_Doi_Tuong_VN.Value = Ten_Doi_Tuong_VN
                myCommand.Parameters.Add(pTen_Doi_Tuong_VN)

                Dim pToa_Do_Top As SqlParameter = New SqlParameter("@Toa_Do_Top", SqlDbType.Int, 4)
                pToa_Do_Top.Value = Toa_Do_Top
                myCommand.Parameters.Add(pToa_Do_Top)

                Dim pToa_Do_Left As SqlParameter = New SqlParameter("@Toa_Do_Left", SqlDbType.Int, 4)
                pToa_Do_Left.Value = Toa_Do_Left
                myCommand.Parameters.Add(pToa_Do_Left)


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
        ' Nội dung: Xóa dữ liệu từ bảng Toa_Do_In
        ' Input: Id_Toa_Do
        ' Output: 
        Public Sub Xoa(ByVal Id_Toa_Do As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Toa_Do_In_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Toa_Do As SqlParameter = New SqlParameter("@Id_Toa_Do", SqlDbType.Int, 4)
                pId_Toa_Do.Value = Id_Toa_Do
                myCommand.Parameters.Add(pId_Toa_Do)

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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Toa_Do_In
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Toa_Do_In_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Toa_Do_In_Danh_Sach")
                myConnection.Close()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_Kho_Giay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Toa_Do_In
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Kho_Giay() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Toa_Do_In_Danh_Sach_Kho_Giay", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Toa_Do_In_Danh_Sach_Kho_Giay")
                myConnection.Close()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_Lay_Boi_Kho_Giay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Toa_Do_In
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Lay_Boi_Kho_Giay(ByVal Kho_Giay As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Toa_Do_In_Danh_Sach_Lay_Boi_Kho_Giay", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Parameter
                Dim pKho_Giay As SqlParameter = New SqlParameter("@Kho_Giay", SqlDbType.VarChar, 50)
                pKho_Giay.Value = Kho_Giay
                myCommand.Parameters.Add(pKho_Giay)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Danh_Sach_Lay_Boi_Kho_Giay")
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
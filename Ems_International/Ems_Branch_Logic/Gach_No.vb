
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Gach_No_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Gach_No_Chi_Tiet
    ' tương ứng với mộ trường của bảng Gach_No trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Gach_No_Chi_Tiet
        Public Id_Gach_No As Integer ' Id tự tăng
        Public Id_Hoa_Don As String ' Liên kết với bảng hóa đơn
        Public Ma_E1 As String ' Số hiệu E1
        Public So_Tien As Integer ' Số tiền trả
        Public Ghi_Chu As String ' Ghi chú
    End Class
#End Region
#Region "Gach_No"
    Public Class Gach_No
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Gach_No
        ' Input: Id_Gach_No
        ' Output: Gach_No_Chi_Tiet
        Public Function Lay(ByVal Id_Gach_No As Integer) As Gach_No_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Gach_No_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Gach_No As SqlParameter = New SqlParameter("@Id_Gach_No", SqlDbType.Int, 4)
                pId_Gach_No.Value = Id_Gach_No
                myCommand.Parameters.Add(pId_Gach_No)

                Dim pId_Hoa_Don As SqlParameter = New SqlParameter("@Id_Hoa_Don", SqlDbType.VarChar, 50)
                pId_Hoa_Don.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Hoa_Don)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_E1)

                Dim pSo_Tien As SqlParameter = New SqlParameter("@So_Tien", SqlDbType.Int, 4)
                pSo_Tien.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSo_Tien)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 50)
                pGhi_Chu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGhi_Chu)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
                Dim myGach_No_Chi_Tiet As Gach_No_Chi_Tiet = New Gach_No_Chi_Tiet
                myGach_No_Chi_Tiet.Id_Gach_No = Id_Gach_No
                myGach_No_Chi_Tiet.Id_Hoa_Don = pId_Hoa_Don.Value
                myGach_No_Chi_Tiet.Ma_E1 = pMa_E1.Value
                myGach_No_Chi_Tiet.So_Tien = pSo_Tien.Value
                myGach_No_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value
                Return myGach_No_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Gach_No
        ' Input:  Id_Hoa_Don, Ma_E1, So_Tien, Ghi_Chu,
        ' Output: 
        Public Sub Them(ByVal Id_Hoa_Don As String, ByVal Ma_E1 As String, ByVal So_Tien As Integer, ByVal Ghi_Chu As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Gach_No_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Hoa_Don As SqlParameter = New SqlParameter("@Id_Hoa_Don", SqlDbType.VarChar, 50)
                pId_Hoa_Don.Value = Id_Hoa_Don
                myCommand.Parameters.Add(pId_Hoa_Don)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pSo_Tien As SqlParameter = New SqlParameter("@So_Tien", SqlDbType.Int, 4)
                pSo_Tien.Value = So_Tien
                myCommand.Parameters.Add(pSo_Tien)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 50)
                pGhi_Chu.Value = Ghi_Chu
                myCommand.Parameters.Add(pGhi_Chu)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Gach_No
        ' Input: Id_Gach_No,  Id_Hoa_Don , Ma_E1 , So_Tien , Ghi_Chu ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_Gach_No As Integer, ByVal Id_Hoa_Don As String, ByVal Ma_E1 As String, ByVal So_Tien As Integer, ByVal Ghi_Chu As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Gach_No_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Gach_No As SqlParameter = New SqlParameter("@Id_Gach_No", SqlDbType.Int, 4)
                pId_Gach_No.Value = Id_Gach_No
                myCommand.Parameters.Add(pId_Gach_No)

                Dim pId_Hoa_Don As SqlParameter = New SqlParameter("@Id_Hoa_Don", SqlDbType.VarChar, 50)
                pId_Hoa_Don.Value = Id_Hoa_Don
                myCommand.Parameters.Add(pId_Hoa_Don)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pSo_Tien As SqlParameter = New SqlParameter("@So_Tien", SqlDbType.Int, 4)
                pSo_Tien.Value = So_Tien
                myCommand.Parameters.Add(pSo_Tien)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 50)
                pGhi_Chu.Value = Ghi_Chu
                myCommand.Parameters.Add(pGhi_Chu)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Gach_No
        ' Input: đối tượng thuộc lớp Gach_No_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myGach_No_Chi_Tiet As Gach_No_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Gach_No_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_Gach_No As SqlParameter = New SqlParameter("@Id_Gach_No", SqlDbType.Int, 4)
                pId_Gach_No.Value = myGach_No_Chi_Tiet.Id_Gach_No
                myCommand.Parameters.Add(pId_Gach_No)

                Dim pId_Hoa_Don As SqlParameter = New SqlParameter("@Id_Hoa_Don", SqlDbType.VarChar, 50)
                pId_Hoa_Don.Value = myGach_No_Chi_Tiet.Id_Hoa_Don
                myCommand.Parameters.Add(pId_Hoa_Don)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = myGach_No_Chi_Tiet.Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pSo_Tien As SqlParameter = New SqlParameter("@So_Tien", SqlDbType.Int, 4)
                pSo_Tien.Value = myGach_No_Chi_Tiet.So_Tien
                myCommand.Parameters.Add(pSo_Tien)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 50)
                pGhi_Chu.Value = myGach_No_Chi_Tiet.Ghi_Chu
                myCommand.Parameters.Add(pGhi_Chu)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Gach_No
        ' Input: Id_Gach_No,  Id_Hoa_Don , Ma_E1 , So_Tien , Ghi_Chu ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Id_Gach_No As Integer, ByVal Id_Hoa_Don As String, ByVal Ma_E1 As String, ByVal So_Tien As Integer, ByVal Ghi_Chu As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Gach_No_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Gach_No As SqlParameter = New SqlParameter("@Id_Gach_No", SqlDbType.Int, 4)
                pId_Gach_No.Value = Id_Gach_No
                myCommand.Parameters.Add(pId_Gach_No)

                Dim pId_Hoa_Don As SqlParameter = New SqlParameter("@Id_Hoa_Don", SqlDbType.VarChar, 50)
                pId_Hoa_Don.Value = Id_Hoa_Don
                myCommand.Parameters.Add(pId_Hoa_Don)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pSo_Tien As SqlParameter = New SqlParameter("@So_Tien", SqlDbType.Int, 4)
                pSo_Tien.Value = So_Tien
                myCommand.Parameters.Add(pSo_Tien)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 50)
                pGhi_Chu.Value = Ghi_Chu
                myCommand.Parameters.Add(pGhi_Chu)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.toString)
            End Try
        End Sub
#End Region
#Region "Xoa"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng Gach_No
        ' Input: Id_Gach_No
        ' Output: 
        Public Sub Xoa(ByVal Id_Gach_No As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Gach_No_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Gach_No As SqlParameter = New SqlParameter("@Id_Gach_No", SqlDbType.Int, 4)
                pId_Gach_No.Value = Id_Gach_No
                myCommand.Parameters.Add(pId_Gach_No)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.toString)


            End Try
        End Sub
#End Region
#Region "Danh_Sach"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Gach_No
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Gach_No_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Gach_No_Danh_Sach")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region

#Region "Lay_Boi_Hoa_Don"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Hoa_Don thông qua khóa chính 
        ' Input: Id_Hoa_Don
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Hoa_Don(ByVal Id_Hoa_Don As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Gach_No_Lay_Boi_Hoa_Don", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Hoa_Don As SqlParameter = New SqlParameter("@Id_Hoa_Don", SqlDbType.VarChar, 50)
                pId_Hoa_Don.Value = Id_Hoa_Don
                myCommand.Parameters.Add(pId_Hoa_Don)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Gach_No_Lay_Boi_Hoa_Don")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.toString)
            End Try
        End Function
#End Region

    End Class
#End Region
End Namespace

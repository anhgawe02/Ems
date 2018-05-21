
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Ma_Trang_Thai_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Ma_Trang_Thai_Chi_Tiet
    ' tương ứng với mộ trường của bảng Ma_Trang_Thai trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Ma_Trang_Thai_Chi_Tiet
        Public Id_Trang_Thai As String
        Public Ten_Trang_Thai As String
        Public Ghi_Chu As String
        Public Duoc_Truyen As Boolean ' Cho phép truyền trạng thái này lên hay không
    End Class
#End Region
#Region "Ma_Trang_Thai"
    Public Class Ma_Trang_Thai
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Ma_Trang_Thai
        ' Input: Id_Trang_Thai
        ' Output: Ma_Trang_Thai_Chi_Tiet
        Public Function Lay(ByVal Id_Trang_Thai As String) As Ma_Trang_Thai_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Trang_Thai_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.VarChar, 5)
                pId_Trang_Thai.Value = Id_Trang_Thai
                myCommand.Parameters.Add(pId_Trang_Thai)

                Dim pTen_Trang_Thai As SqlParameter = New SqlParameter("@Ten_Trang_Thai", SqlDbType.NVarChar, 100)
                pTen_Trang_Thai.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTen_Trang_Thai)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 100)
                pGhi_Chu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGhi_Chu)

                Dim pDuoc_Truyen As SqlParameter = New SqlParameter("@Duoc_Truyen", SqlDbType.Bit, 1)
                pDuoc_Truyen.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDuoc_Truyen)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
                Dim myMa_Trang_Thai_Chi_Tiet As Ma_Trang_Thai_Chi_Tiet = New Ma_Trang_Thai_Chi_Tiet
                myMa_Trang_Thai_Chi_Tiet.Id_Trang_Thai = Id_Trang_Thai
                myMa_Trang_Thai_Chi_Tiet.Ten_Trang_Thai = pTen_Trang_Thai.Value
                myMa_Trang_Thai_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value
                myMa_Trang_Thai_Chi_Tiet.Duoc_Truyen = pDuoc_Truyen.Value
                Return myMa_Trang_Thai_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Ma_Trang_Thai
        ' Input:  Ten_Trang_Thai, Ghi_Chu, Duoc_Truyen,
        ' Output: 
        Public Sub Them(ByVal Ten_Trang_Thai As String, ByVal Ghi_Chu As String, ByVal Duoc_Truyen As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Trang_Thai_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pTen_Trang_Thai As SqlParameter = New SqlParameter("@Ten_Trang_Thai", SqlDbType.NVarChar, 100)
                pTen_Trang_Thai.Value = Ten_Trang_Thai
                myCommand.Parameters.Add(pTen_Trang_Thai)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 100)
                pGhi_Chu.Value = Ghi_Chu
                myCommand.Parameters.Add(pGhi_Chu)

                Dim pDuoc_Truyen As SqlParameter = New SqlParameter("@Duoc_Truyen", SqlDbType.Bit, 1)
                pDuoc_Truyen.Value = Duoc_Truyen
                myCommand.Parameters.Add(pDuoc_Truyen)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Ma_Trang_Thai
        ' Input: Id_Trang_Thai,  Ten_Trang_Thai , Ghi_Chu , Duoc_Truyen ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_Trang_Thai As String, ByVal Ten_Trang_Thai As String, ByVal Ghi_Chu As String, ByVal Duoc_Truyen As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Trang_Thai_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.VarChar, 5)
                pId_Trang_Thai.Value = Id_Trang_Thai
                myCommand.Parameters.Add(pId_Trang_Thai)

                Dim pTen_Trang_Thai As SqlParameter = New SqlParameter("@Ten_Trang_Thai", SqlDbType.NVarChar, 100)
                pTen_Trang_Thai.Value = Ten_Trang_Thai
                myCommand.Parameters.Add(pTen_Trang_Thai)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 100)
                pGhi_Chu.Value = Ghi_Chu
                myCommand.Parameters.Add(pGhi_Chu)

                Dim pDuoc_Truyen As SqlParameter = New SqlParameter("@Duoc_Truyen", SqlDbType.Bit, 1)
                pDuoc_Truyen.Value = Duoc_Truyen
                myCommand.Parameters.Add(pDuoc_Truyen)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Ma_Trang_Thai
        ' Input: đối tượng thuộc lớp Ma_Trang_Thai_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myMa_Trang_Thai_Chi_Tiet As Ma_Trang_Thai_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Trang_Thai_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.VarChar, 5)
                pId_Trang_Thai.Value = myMa_Trang_Thai_Chi_Tiet.Id_Trang_Thai
                myCommand.Parameters.Add(pId_Trang_Thai)

                Dim pTen_Trang_Thai As SqlParameter = New SqlParameter("@Ten_Trang_Thai", SqlDbType.NVarChar, 100)
                pTen_Trang_Thai.Value = myMa_Trang_Thai_Chi_Tiet.Ten_Trang_Thai
                myCommand.Parameters.Add(pTen_Trang_Thai)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 100)
                pGhi_Chu.Value = myMa_Trang_Thai_Chi_Tiet.Ghi_Chu
                myCommand.Parameters.Add(pGhi_Chu)

                Dim pDuoc_Truyen As SqlParameter = New SqlParameter("@Duoc_Truyen", SqlDbType.Bit, 1)
                pDuoc_Truyen.Value = myMa_Trang_Thai_Chi_Tiet.Duoc_Truyen
                myCommand.Parameters.Add(pDuoc_Truyen)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Ma_Trang_Thai
        ' Input: Id_Trang_Thai,  Ten_Trang_Thai , Ghi_Chu , Duoc_Truyen ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Id_Trang_Thai As String, ByVal Ten_Trang_Thai As String, ByVal Ghi_Chu As String, ByVal Duoc_Truyen As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Trang_Thai_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.VarChar, 5)
                pId_Trang_Thai.Value = Id_Trang_Thai
                myCommand.Parameters.Add(pId_Trang_Thai)

                Dim pTen_Trang_Thai As SqlParameter = New SqlParameter("@Ten_Trang_Thai", SqlDbType.NVarChar, 100)
                pTen_Trang_Thai.Value = Ten_Trang_Thai
                myCommand.Parameters.Add(pTen_Trang_Thai)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 100)
                pGhi_Chu.Value = Ghi_Chu
                myCommand.Parameters.Add(pGhi_Chu)

                Dim pDuoc_Truyen As SqlParameter = New SqlParameter("@Duoc_Truyen", SqlDbType.Bit, 1)
                pDuoc_Truyen.Value = Duoc_Truyen
                myCommand.Parameters.Add(pDuoc_Truyen)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Ma_Trang_Thai
        ' Input: đối tượng datatable
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal myDataTable As DataTable)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                myConnection.Open()
                Dim i As Integer
                For i = 0 To myDataTable.Rows.Count - 1
                    Dim myCommand As SqlCommand = New SqlCommand("Ma_Trang_Thai_Cap_Nhat_Them", myConnection)

                    ' Sử dụng Store Procedure
                    myCommand.CommandType = CommandType.StoredProcedure
                    ' Thêm các Parameters vào thủ tục				

                    Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.VarChar, 5)
                    pId_Trang_Thai.Value = Convert.ToString(myDataTable.Rows(i).Item("Id_Trang_Thai"))
                    myCommand.Parameters.Add(pId_Trang_Thai)

                    Dim pTen_Trang_Thai As SqlParameter = New SqlParameter("@Ten_Trang_Thai", SqlDbType.NVarChar, 100)
                    pTen_Trang_Thai.Value = Convert.ToString(myDataTable.Rows(i).Item("Ten_Trang_Thai"))
                    myCommand.Parameters.Add(pTen_Trang_Thai)

                    Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 100)
                    pGhi_Chu.Value = Convert.ToString(myDataTable.Rows(i).Item("Ghi_Chu"))
                    myCommand.Parameters.Add(pGhi_Chu)

                    Dim pDuoc_Truyen As SqlParameter = New SqlParameter("@Duoc_Truyen", SqlDbType.Bit, 1)
                    pDuoc_Truyen.Value = Convert.ToBoolean(myDataTable.Rows(i).Item("Duoc_Truyen"))
                    myCommand.Parameters.Add(pDuoc_Truyen)



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
        ' Nội dung: Xóa dữ liệu từ bảng Ma_Trang_Thai
        ' Input: Id_Trang_Thai
        ' Output: 
        Public Sub Xoa(ByVal Id_Trang_Thai As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Trang_Thai_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.VarChar, 5)
                pId_Trang_Thai.Value = Id_Trang_Thai
                myCommand.Parameters.Add(pId_Trang_Thai)

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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Ma_Trang_Thai
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Trang_Thai_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Ma_Trang_Thai_Danh_Sach")
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

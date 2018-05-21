
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Dich_Vu_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Dich_Vu_Chi_Tiet
    ' tương ứng với mộ trường của bảng Dich_Vu trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Dich_Vu_Chi_Tiet
        Public Ma_Dich_Vu As String ' Mã dịch vụ (Tên viết tắt)
        Public Ten_Dich_Vu As String
        Public Phan_Loai As Integer ' Phân loại dịch vụ: 0: Dịch vụ cộng thêm, 1: Dịch vụ gia tăng; 2: COD; 3: Khai gia
    End Class
#End Region
#Region "Dich_Vu"
    Public Class Dich_Vu
        Public Const MaxN As Integer = 100
        Public Trace(MaxN) As Integer
        Public Giatri(MaxN) As String
        Private myDataTable As DataTable
        Private strColumn As String
        Private ConnectionString As String

        Private Sub Output(ByVal k As Integer)

            Dim j As Integer
            Dim strTraVe As String
            strTraVe = Giatri(Trace(1))
            'Selection.TypeText(SoLuong & ":")
            'Selection.TypeText(Giatri(Trace(1))) 'Xuat ra gia tri dau tien
            For j = 2 To k
                strTraVe = strTraVe & "," & Giatri(Trace(j))
                'Selection.TypeText("," + Giatri(Trace(i))) 'Xuat ra cac gia tri tiep theo
            Next
            If Not strTraVe Is Nothing Then
                Dim row As DataRow = myDataTable.NewRow()
                row(strColumn) = strTraVe
                myDataTable.Rows.Add(row)
            End If


        End Sub

        Sub tohop(ByVal i As Integer, ByVal k As Integer, ByVal n As Integer)
            Dim j As Integer
            If i > k Then
                Output(k)
            Else
                For j = Trace(i - 1) + 1 To n
                    Trace(i) = j
                    tohop(i + 1, k, n)
                Next j
            End If
        End Sub

        Private Sub Run(ByVal N As Integer)
            Dim i As Integer
            Dim Th(MaxN) As Integer
            Trace(0) = 0
            For i = 1 To N
                tohop(1, i, N)
            Next i
        End Sub
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Dich_Vu
        ' Input: Ma_Dich_Vu
        ' Output: Dich_Vu_Chi_Tiet
        Public Function Lay(ByVal Ma_Dich_Vu As String) As Dich_Vu_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Dich_Vu_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pMa_Dich_Vu As SqlParameter = New SqlParameter("@Ma_Dich_Vu", SqlDbType.VarChar, 5)
                pMa_Dich_Vu.Value = Ma_Dich_Vu
                myCommand.Parameters.Add(pMa_Dich_Vu)

                Dim pTen_Dich_Vu As SqlParameter = New SqlParameter("@Ten_Dich_Vu", SqlDbType.NVarChar, 100)
                pTen_Dich_Vu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTen_Dich_Vu)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.Int, 4)
                pPhan_Loai.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pPhan_Loai)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
                Dim myDich_Vu_Chi_Tiet As Dich_Vu_Chi_Tiet = New Dich_Vu_Chi_Tiet
                myDich_Vu_Chi_Tiet.Ma_Dich_Vu = Ma_Dich_Vu
                myDich_Vu_Chi_Tiet.Ten_Dich_Vu = pTen_Dich_Vu.Value
                myDich_Vu_Chi_Tiet.Phan_Loai = pPhan_Loai.Value
                Return myDich_Vu_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Dich_Vu
        ' Input:  Ten_Dich_Vu, Phan_Loai,
        ' Output: 
        Public Sub Them(ByVal Ten_Dich_Vu As String, ByVal Phan_Loai As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Dich_Vu_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pTen_Dich_Vu As SqlParameter = New SqlParameter("@Ten_Dich_Vu", SqlDbType.NVarChar, 100)
                pTen_Dich_Vu.Value = Ten_Dich_Vu
                myCommand.Parameters.Add(pTen_Dich_Vu)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.Int, 4)
                pPhan_Loai.Value = Phan_Loai
                myCommand.Parameters.Add(pPhan_Loai)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Dich_Vu
        ' Input: Ma_Dich_Vu,  Ten_Dich_Vu , Phan_Loai ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Ma_Dich_Vu As String, ByVal Ten_Dich_Vu As String, ByVal Phan_Loai As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Dich_Vu_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Dich_Vu As SqlParameter = New SqlParameter("@Ma_Dich_Vu", SqlDbType.VarChar, 5)
                pMa_Dich_Vu.Value = Ma_Dich_Vu
                myCommand.Parameters.Add(pMa_Dich_Vu)

                Dim pTen_Dich_Vu As SqlParameter = New SqlParameter("@Ten_Dich_Vu", SqlDbType.NVarChar, 100)
                pTen_Dich_Vu.Value = Ten_Dich_Vu
                myCommand.Parameters.Add(pTen_Dich_Vu)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.Int, 4)
                pPhan_Loai.Value = Phan_Loai
                myCommand.Parameters.Add(pPhan_Loai)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Dich_Vu
        ' Input: đối tượng thuộc lớp Dich_Vu_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myDich_Vu_Chi_Tiet As Dich_Vu_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Dich_Vu_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pMa_Dich_Vu As SqlParameter = New SqlParameter("@Ma_Dich_Vu", SqlDbType.VarChar, 5)
                pMa_Dich_Vu.Value = myDich_Vu_Chi_Tiet.Ma_Dich_Vu
                myCommand.Parameters.Add(pMa_Dich_Vu)

                Dim pTen_Dich_Vu As SqlParameter = New SqlParameter("@Ten_Dich_Vu", SqlDbType.NVarChar, 100)
                pTen_Dich_Vu.Value = myDich_Vu_Chi_Tiet.Ten_Dich_Vu
                myCommand.Parameters.Add(pTen_Dich_Vu)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.Int, 4)
                pPhan_Loai.Value = myDich_Vu_Chi_Tiet.Phan_Loai
                myCommand.Parameters.Add(pPhan_Loai)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Dich_Vu
        ' Input: Ma_Dich_Vu,  Ten_Dich_Vu , Phan_Loai ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Ma_Dich_Vu As String, ByVal Ten_Dich_Vu As String, ByVal Phan_Loai As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Dich_Vu_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Dich_Vu As SqlParameter = New SqlParameter("@Ma_Dich_Vu", SqlDbType.VarChar, 5)
                pMa_Dich_Vu.Value = Ma_Dich_Vu
                myCommand.Parameters.Add(pMa_Dich_Vu)

                Dim pTen_Dich_Vu As SqlParameter = New SqlParameter("@Ten_Dich_Vu", SqlDbType.NVarChar, 100)
                pTen_Dich_Vu.Value = Ten_Dich_Vu
                myCommand.Parameters.Add(pTen_Dich_Vu)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.Int, 4)
                pPhan_Loai.Value = Phan_Loai
                myCommand.Parameters.Add(pPhan_Loai)


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
        ' Nội dung: Xóa dữ liệu từ bảng Dich_Vu
        ' Input: Ma_Dich_Vu
        ' Output: 
        Public Sub Xoa(ByVal Ma_Dich_Vu As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Dich_Vu_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Dich_Vu As SqlParameter = New SqlParameter("@Ma_Dich_Vu", SqlDbType.VarChar, 5)
                pMa_Dich_Vu.Value = Ma_Dich_Vu
                myCommand.Parameters.Add(pMa_Dich_Vu)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)


            End Try
        End Sub
#End Region
#Region "Kiem tra Ma_Dich_Vu"
        ' Ngày tạo: 27/6/08
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Kiểm tra sự tồn tại
        ' Output: count(*)
        Public Function Chk_Ma_Dich_Vu(ByVal Ma_Dich_Vu As String) As Boolean
            Dim ReturnValue As Boolean
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand

            myCommand = New SqlCommand("Select count(*) from Dich_Vu where (Ma_Dich_Vu= '" & Ma_Dich_Vu & "') ", myConnection)

            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
            myConnection.Close()
myConnection.Dispose()
            Return ReturnValue
        End Function
#End Region
#Region "Danh_Sach"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Dich_Vu
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Dich_Vu_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Dich_Vu_Danh_Sach")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Lay_Boi_Ma_Dich_Vu"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Dich_Vu thông qua khóa chính 
        ' Input: Dich_Vu
        ' Output: Lay Ten_Dv theo Ma_Dich_Vu
        Public Function Lay_Ten_Dich_Vu(ByVal Ma_Dich_Vu As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Dich_Vu_Lay_Ten_Dich_Vu", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Dich_Vu As SqlParameter = New SqlParameter("@Ma_Dich_Vu", SqlDbType.VarChar, 10)
                pMa_Dich_Vu.Value = Ma_Dich_Vu
                myCommand.Parameters.Add(pMa_Dich_Vu)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Dich_Vu_Lay_Ten_Dich_Vu")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Danh_Sach_Dich_Vu_Phan_Loai"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Dich_Vu
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Dich_Vu_Phan_Loai(ByVal Phan_Loai As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Dich_Vu_Danh_Sach_Phan_Loai", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.Int)
                pPhan_Loai.Value = Phan_Loai
                myCommand.Parameters.Add(pPhan_Loai)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Dich_Vu_Danh_Sach_Phan_Loai")
                myConnection.Close()
myConnection.Dispose()

                Dim i As Integer
                For i = 0 To myDataSet.Tables("Dich_Vu_Danh_Sach_Phan_Loai").Rows.Count - 1
                    Giatri(i + 1) = myDataSet.Tables("Dich_Vu_Danh_Sach_Phan_Loai").Rows(i).Item("Ma_Dich_Vu")
                Next
                If Phan_Loai = 0 Then
                    strColumn = "Dv_Cong_Them"
                End If
                If Phan_Loai = 1 Then
                    strColumn = "Dv_Gia_Tang"
                End If
                myDataTable = New DataTable(strColumn)
                'Tao ra cac cot cua bang nay
                Dim colWork As DataColumn = New DataColumn(strColumn, GetType(String))
                myDataTable.Columns.Add(colWork)
                Run(myDataSet.Tables("Dich_Vu_Danh_Sach_Phan_Loai").Rows.Count)
                Dim row As DataRow = myDataTable.NewRow()
                row(strColumn) = String.Empty
                myDataTable.Rows.Add(row)
                Return myDataTable
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
    End Class
#End Region
End Namespace

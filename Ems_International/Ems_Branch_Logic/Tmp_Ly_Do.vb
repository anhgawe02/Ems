
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Tmp_Ly_Do_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Tmp_Ly_Do_Chi_Tiet
    ' tương ứng với mộ trường của bảng Tmp_Ly_Do trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Tmp_Ly_Do_Chi_Tiet
        Public Ma_Ly_Do As Integer
        Public Ten_Ly_Do As String
        Public Ten_Ly_Do_EN As String
        Public To_Hop_Xu_Ly As String
    End Class
#End Region
#Region "Tmp_Ly_Do"
    Public Class Tmp_Ly_Do
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Tmp_Ly_Do
        ' Input: Ma_Ly_Do
        ' Output: Tmp_Ly_Do_Chi_Tiet
        Public Function Lay(ByVal Ma_Ly_Do As Integer) As Tmp_Ly_Do_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Ly_Do_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pMa_Ly_Do As SqlParameter = New SqlParameter("@Ma_Ly_Do", SqlDbType.Int, 4)
                pMa_Ly_Do.Value = Ma_Ly_Do
                myCommand.Parameters.Add(pMa_Ly_Do)

                Dim pTen_Ly_Do As SqlParameter = New SqlParameter("@Ten_Ly_Do", SqlDbType.NVarChar, 200)
                pTen_Ly_Do.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTen_Ly_Do)

                Dim pTen_Ly_Do_EN As SqlParameter = New SqlParameter("@Ten_Ly_Do_EN", SqlDbType.VarChar, 200)
                pTen_Ly_Do_EN.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTen_Ly_Do_EN)

                Dim pTo_Hop_Xu_Ly As SqlParameter = New SqlParameter("@To_Hop_Xu_Ly", SqlDbType.VarChar, 50)
                pTo_Hop_Xu_Ly.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTo_Hop_Xu_Ly)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                Dim myTmp_Ly_Do_Chi_Tiet As Tmp_Ly_Do_Chi_Tiet = New Tmp_Ly_Do_Chi_Tiet
                myTmp_Ly_Do_Chi_Tiet.Ma_Ly_Do = Ma_Ly_Do
                myTmp_Ly_Do_Chi_Tiet.Ten_Ly_Do = pTen_Ly_Do.Value
                myTmp_Ly_Do_Chi_Tiet.Ten_Ly_Do_EN = pTen_Ly_Do_EN.Value
                myTmp_Ly_Do_Chi_Tiet.To_Hop_Xu_Ly = pTo_Hop_Xu_Ly.Value
                Return myTmp_Ly_Do_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Tmp_Ly_Do
        ' Input:  Ten_Ly_Do, Ten_Ly_Do_EN, To_Hop_Xu_Ly,
        ' Output: 
        Public Sub Them(ByVal Ten_Ly_Do As String, ByVal Ten_Ly_Do_EN As String, ByVal To_Hop_Xu_Ly As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Ly_Do_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pTen_Ly_Do As SqlParameter = New SqlParameter("@Ten_Ly_Do", SqlDbType.NVarChar, 200)
                pTen_Ly_Do.Value = Ten_Ly_Do
                myCommand.Parameters.Add(pTen_Ly_Do)

                Dim pTen_Ly_Do_EN As SqlParameter = New SqlParameter("@Ten_Ly_Do_EN", SqlDbType.VarChar, 200)
                pTen_Ly_Do_EN.Value = Ten_Ly_Do_EN
                myCommand.Parameters.Add(pTen_Ly_Do_EN)

                Dim pTo_Hop_Xu_Ly As SqlParameter = New SqlParameter("@To_Hop_Xu_Ly", SqlDbType.VarChar, 50)
                pTo_Hop_Xu_Ly.Value = To_Hop_Xu_Ly
                myCommand.Parameters.Add(pTo_Hop_Xu_Ly)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Sub
#End Region
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Tmp_Ly_Do
        ' Input: Ma_Ly_Do,  Ten_Ly_Do , Ten_Ly_Do_EN , To_Hop_Xu_Ly ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Ma_Ly_Do As Integer, ByVal Ten_Ly_Do As String, ByVal Ten_Ly_Do_EN As String, ByVal To_Hop_Xu_Ly As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Ly_Do_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Ly_Do As SqlParameter = New SqlParameter("@Ma_Ly_Do", SqlDbType.Int, 4)
                pMa_Ly_Do.Value = Ma_Ly_Do
                myCommand.Parameters.Add(pMa_Ly_Do)

                Dim pTen_Ly_Do As SqlParameter = New SqlParameter("@Ten_Ly_Do", SqlDbType.NVarChar, 200)
                pTen_Ly_Do.Value = Ten_Ly_Do
                myCommand.Parameters.Add(pTen_Ly_Do)

                Dim pTen_Ly_Do_EN As SqlParameter = New SqlParameter("@Ten_Ly_Do_EN", SqlDbType.VarChar, 200)
                pTen_Ly_Do_EN.Value = Ten_Ly_Do_EN
                myCommand.Parameters.Add(pTen_Ly_Do_EN)

                Dim pTo_Hop_Xu_Ly As SqlParameter = New SqlParameter("@To_Hop_Xu_Ly", SqlDbType.VarChar, 50)
                pTo_Hop_Xu_Ly.Value = To_Hop_Xu_Ly
                myCommand.Parameters.Add(pTo_Hop_Xu_Ly)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
            Catch ex As Exception
                Console.Write(ex.toString)
            End Try
        End Sub
#End Region
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Tmp_Ly_Do
        ' Input: đối tượng thuộc lớp Tmp_Ly_Do_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myTmp_Ly_Do_Chi_Tiet As Tmp_Ly_Do_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Ly_Do_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pMa_Ly_Do As SqlParameter = New SqlParameter("@Ma_Ly_Do", SqlDbType.Int, 4)
                pMa_Ly_Do.Value = myTmp_Ly_Do_Chi_Tiet.Ma_Ly_Do
                myCommand.Parameters.Add(pMa_Ly_Do)

                Dim pTen_Ly_Do As SqlParameter = New SqlParameter("@Ten_Ly_Do", SqlDbType.NVarChar, 200)
                pTen_Ly_Do.Value = myTmp_Ly_Do_Chi_Tiet.Ten_Ly_Do
                myCommand.Parameters.Add(pTen_Ly_Do)

                Dim pTen_Ly_Do_EN As SqlParameter = New SqlParameter("@Ten_Ly_Do_EN", SqlDbType.VarChar, 200)
                pTen_Ly_Do_EN.Value = myTmp_Ly_Do_Chi_Tiet.Ten_Ly_Do_EN
                myCommand.Parameters.Add(pTen_Ly_Do_EN)

                Dim pTo_Hop_Xu_Ly As SqlParameter = New SqlParameter("@To_Hop_Xu_Ly", SqlDbType.VarChar, 50)
                pTo_Hop_Xu_Ly.Value = myTmp_Ly_Do_Chi_Tiet.To_Hop_Xu_Ly
                myCommand.Parameters.Add(pTo_Hop_Xu_Ly)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Sub
#End Region
#Region "Cap_Nhat_Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Tmp_Ly_Do
        ' Input: Ma_Ly_Do,  Ten_Ly_Do , Ten_Ly_Do_EN , To_Hop_Xu_Ly ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Ma_Ly_Do As Integer, ByVal Ten_Ly_Do As String, ByVal Ten_Ly_Do_EN As String, ByVal To_Hop_Xu_Ly As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Ly_Do_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Ly_Do As SqlParameter = New SqlParameter("@Ma_Ly_Do", SqlDbType.Int, 4)
                pMa_Ly_Do.Value = Ma_Ly_Do
                myCommand.Parameters.Add(pMa_Ly_Do)

                Dim pTen_Ly_Do As SqlParameter = New SqlParameter("@Ten_Ly_Do", SqlDbType.NVarChar, 200)
                pTen_Ly_Do.Value = Ten_Ly_Do
                myCommand.Parameters.Add(pTen_Ly_Do)

                Dim pTen_Ly_Do_EN As SqlParameter = New SqlParameter("@Ten_Ly_Do_EN", SqlDbType.VarChar, 200)
                pTen_Ly_Do_EN.Value = Ten_Ly_Do_EN
                myCommand.Parameters.Add(pTen_Ly_Do_EN)

                Dim pTo_Hop_Xu_Ly As SqlParameter = New SqlParameter("@To_Hop_Xu_Ly", SqlDbType.VarChar, 50)
                pTo_Hop_Xu_Ly.Value = To_Hop_Xu_Ly
                myCommand.Parameters.Add(pTo_Hop_Xu_Ly)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
            Catch ex As Exception
                Console.Write(ex.toString)
            End Try
        End Sub
#End Region
#Region "Xoa"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng Tmp_Ly_Do
        ' Input: Ma_Ly_Do
        ' Output: 
        Public Sub Xoa(ByVal Ma_Ly_Do As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Ly_Do_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Ly_Do As SqlParameter = New SqlParameter("@Ma_Ly_Do", SqlDbType.Int, 4)
                pMa_Ly_Do.Value = Ma_Ly_Do
                myCommand.Parameters.Add(pMa_Ly_Do)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
            Catch ex As Exception
                Console.Write(ex.toString)


            End Try
        End Sub
#End Region
#Region "Danh_Sach"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Tmp_Ly_Do
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Ly_Do_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Tmp_Ly_Do_Danh_Sach")
                myConnection.Close()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region


    End Class
#End Region
End Namespace
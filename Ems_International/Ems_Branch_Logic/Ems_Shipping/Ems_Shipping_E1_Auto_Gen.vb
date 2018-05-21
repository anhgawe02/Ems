
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "E1_Auto_Gen_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp E1_Auto_Gen_Chi_Tiet
    ' tương ứng với mộ trường của bảng E1_Auto_Gen trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class E1_Auto_Gen_Chi_Tiet
        Public id_shipping As Integer
        Public Ma_dv As String
        Public Ma_code As String
        Public Ma_E1 As String
        Public Ma_KH_E_Shipping As String
        Public Ma_BC As Integer
    End Class
#End Region
#Region "E1_Autogeneration_Chi_Tiet"
    Public Class E1_Autogeneration_Chi_Tiet
        Public Ma_KH_E_Shipping As String
        Public Ma_BC As Integer
        Public Nuoc_Nhan As String
        Public Ma_E1 As String
    End Class
#End Region
#Region "E1_Auto_Gen"
    Public Class E1_Auto_Gen
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng E1_Auto_Gen
        ' Input: id_shipping
        ' Output: E1_Auto_Gen_Chi_Tiet
        Public Function Lay(ByVal id_shipping As Integer) As E1_Auto_Gen_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Auto_Gen_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pid_shipping As SqlParameter = New SqlParameter("@id_shipping", SqlDbType.Int, 4)
                pid_shipping.Value = id_shipping
                myCommand.Parameters.Add(pid_shipping)

                Dim pMa_dv As SqlParameter = New SqlParameter("@Ma_dv", SqlDbType.VarChar, 3)
                pMa_dv.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_dv)

                Dim pMa_code As SqlParameter = New SqlParameter("@Ma_code", SqlDbType.VarChar, 2)
                pMa_code.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_code)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_E1)

                Dim pMa_KH_E_Shipping As SqlParameter = New SqlParameter("@Ma_KH_E_Shipping", SqlDbType.VarChar, 50)
                pMa_KH_E_Shipping.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_KH_E_Shipping)

                Dim pMa_BC As SqlParameter = New SqlParameter("@Ma_BC", SqlDbType.Int, 4)
                pMa_BC.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_BC)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myE1_Auto_Gen_Chi_Tiet As E1_Auto_Gen_Chi_Tiet = New E1_Auto_Gen_Chi_Tiet
                myE1_Auto_Gen_Chi_Tiet.id_shipping = id_shipping
                myE1_Auto_Gen_Chi_Tiet.Ma_dv = pMa_dv.Value
                myE1_Auto_Gen_Chi_Tiet.Ma_code = pMa_code.Value
                myE1_Auto_Gen_Chi_Tiet.Ma_E1 = pMa_E1.Value
                myE1_Auto_Gen_Chi_Tiet.Ma_KH_E_Shipping = pMa_KH_E_Shipping.Value
                myE1_Auto_Gen_Chi_Tiet.Ma_BC = pMa_BC.Value
                Return myE1_Auto_Gen_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng E1_Auto_Gen
        ' Input:  Ma_dv, Ma_code, Ma_E1, Ma_KH,
        ' Output: 
        Public Sub Them(ByVal Ma_dv As String, ByVal Ma_code As String, ByVal Ma_E1 As String, ByVal Ma_KH_E_Shipping As String, ByVal Ma_BC As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Auto_Gen_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_dv As SqlParameter = New SqlParameter("@Ma_dv", SqlDbType.VarChar, 3)
                pMa_dv.Value = Ma_dv
                myCommand.Parameters.Add(pMa_dv)

                Dim pMa_code As SqlParameter = New SqlParameter("@Ma_code", SqlDbType.VarChar, 2)
                pMa_code.Value = Ma_code
                myCommand.Parameters.Add(pMa_code)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pMa_KH_E_Shipping As SqlParameter = New SqlParameter("@Ma_KH_E_Shipping", SqlDbType.VarChar, 50)
                pMa_KH_E_Shipping.Value = Ma_KH_E_Shipping
                myCommand.Parameters.Add(pMa_KH_E_Shipping)

                Dim pMa_BC As SqlParameter = New SqlParameter("@Ma_BC", SqlDbType.Int, 4)
                pMa_BC.Value = Ma_BC
                myCommand.Parameters.Add(pMa_BC)

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
        ' Nội dung: Cập nhật dữ liệu vào bảng E1_Auto_Gen
        ' Input: id_shipping,  Ma_dv , Ma_code , Ma_E1 , Ma_KH ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal id_shipping As Integer, ByVal Ma_dv As String, ByVal Ma_code As String, ByVal Ma_E1 As String, ByVal Ma_KH_E_Shipping As String, ByVal Ma_BC As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Auto_Gen_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pid_shipping As SqlParameter = New SqlParameter("@id_shipping", SqlDbType.Int, 4)
                pid_shipping.Value = id_shipping
                myCommand.Parameters.Add(pid_shipping)

                Dim pMa_dv As SqlParameter = New SqlParameter("@Ma_dv", SqlDbType.VarChar, 3)
                pMa_dv.Value = Ma_dv
                myCommand.Parameters.Add(pMa_dv)

                Dim pMa_code As SqlParameter = New SqlParameter("@Ma_code", SqlDbType.VarChar, 2)
                pMa_code.Value = Ma_code
                myCommand.Parameters.Add(pMa_code)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pMa_KH_E_Shipping As SqlParameter = New SqlParameter("@Ma_KH_E_Shipping", SqlDbType.VarChar, 50)
                pMa_KH_E_Shipping.Value = Ma_KH_E_Shipping
                myCommand.Parameters.Add(pMa_KH_E_Shipping)

                Dim pMa_BC As SqlParameter = New SqlParameter("@Ma_BC", SqlDbType.Int, 4)
                pMa_BC.Value = Ma_BC
                myCommand.Parameters.Add(pMa_BC)

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
        ' Nội dung: Cập nhật dữ liệu vào bảng E1_Auto_Gen
        ' Input: đối tượng thuộc lớp E1_Auto_Gen_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myE1_Auto_Gen_Chi_Tiet As E1_Auto_Gen_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Auto_Gen_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pid_shipping As SqlParameter = New SqlParameter("@id_shipping", SqlDbType.Int, 4)
                pid_shipping.Value = myE1_Auto_Gen_Chi_Tiet.id_shipping
                myCommand.Parameters.Add(pid_shipping)

                Dim pMa_dv As SqlParameter = New SqlParameter("@Ma_dv", SqlDbType.VarChar, 3)
                pMa_dv.Value = myE1_Auto_Gen_Chi_Tiet.Ma_dv
                myCommand.Parameters.Add(pMa_dv)

                Dim pMa_code As SqlParameter = New SqlParameter("@Ma_code", SqlDbType.VarChar, 2)
                pMa_code.Value = myE1_Auto_Gen_Chi_Tiet.Ma_code
                myCommand.Parameters.Add(pMa_code)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = myE1_Auto_Gen_Chi_Tiet.Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pMa_KH_E_Shipping As SqlParameter = New SqlParameter("@Ma_KH_E_Shipping", SqlDbType.VarChar, 50)
                pMa_KH_E_Shipping.Value = myE1_Auto_Gen_Chi_Tiet.Ma_KH_E_Shipping
                myCommand.Parameters.Add(pMa_KH_E_Shipping)

                Dim pMa_BC As SqlParameter = New SqlParameter("@Ma_BC", SqlDbType.Int, 4)
                pMa_BC.Value = myE1_Auto_Gen_Chi_Tiet.Ma_BC
                myCommand.Parameters.Add(pMa_BC)

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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng E1_Auto_Gen
        ' Input: id_shipping,  Ma_dv , Ma_code , Ma_E1 , Ma_KH ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal id_shipping As Integer, ByVal Ma_dv As String, ByVal Ma_code As String, ByVal Ma_E1 As String, ByVal Ma_KH_E_Shipping As String, ByVal Ma_BC As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Auto_Gen_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pid_shipping As SqlParameter = New SqlParameter("@id_shipping", SqlDbType.Int, 4)
                pid_shipping.Value = id_shipping
                myCommand.Parameters.Add(pid_shipping)

                Dim pMa_dv As SqlParameter = New SqlParameter("@Ma_dv", SqlDbType.VarChar, 3)
                pMa_dv.Value = Ma_dv
                myCommand.Parameters.Add(pMa_dv)

                Dim pMa_code As SqlParameter = New SqlParameter("@Ma_code", SqlDbType.VarChar, 2)
                pMa_code.Value = Ma_code
                myCommand.Parameters.Add(pMa_code)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pMa_KH_E_Shipping As SqlParameter = New SqlParameter("@Ma_KH_E_Shipping", SqlDbType.VarChar, 50)
                pMa_KH_E_Shipping.Value = Ma_KH_E_Shipping
                myCommand.Parameters.Add(pMa_KH_E_Shipping)

                Dim pMa_BC As SqlParameter = New SqlParameter("@Ma_BC", SqlDbType.Int, 4)
                pMa_BC.Value = Ma_BC
                myCommand.Parameters.Add(pMa_BC)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region

        '#Region "E1_Autogeneration"
        '        ' Ngày tạo: 15/6/08
        '        ' Người tạo: Nguyễn Bằng
        '        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng E1_Auto_Gen
        '        ' Input: id_shipping,  Ma_dv , Ma_code , Ma_E1 , Ma_KH ,
        '        ' Output: 
        '        Public Sub E1_Autogeneration(ByVal Ma_KH As String)
        '            Try
        '                ' Tạo đối tượng connection và command
        '                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
        '                Dim myCommand As SqlCommand = New SqlCommand("E1_Autogeneration", myConnection)

        '                ' Sử dụng Store Procedure
        '                myCommand.CommandType = CommandType.StoredProcedure
        '                ' Thêm các Parameters vào thủ tục
        '                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
        '                pMa_KH.Value = Ma_KH
        '                myCommand.Parameters.Add(pMa_KH)


        '                myConnection.Open()
        '                myCommand.ExecuteNonQuery()
        '                myConnection.Close()
        '                myConnection.Dispose()
        '            Catch ex As Exception
        '                Console.Write(ex.ToString)
        '            End Try
        '        End Sub
        '#End Region

#Region "E1_Autogeneration"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Quang Đô
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng E1_Auto_Gen
        ' Input: id_shipping,  Ma_dv , Ma_code , Ma_E1 , Ma_KH ,
        ' Output: 
        Public Function E1_Autogeneration(ByVal Ma_KH_E_Shipping As String, ByVal Buu_Cuc_Khai_Thac As Integer, ByVal Nuoc_Nhan As String) As E1_Autogeneration_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Autogeneration", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_KH_E_Shipping As SqlParameter = New SqlParameter("@Ma_KH_E_Shipping", SqlDbType.VarChar, 50)
                pMa_KH_E_Shipping.Value = Ma_KH_E_Shipping
                myCommand.Parameters.Add(pMa_KH_E_Shipping)

                Dim pBuu_Cuc_Khai_Thac As SqlParameter = New SqlParameter("@Buu_Cuc_Khai_Thac", SqlDbType.Int, 4)
                pBuu_Cuc_Khai_Thac.Value = Buu_Cuc_Khai_Thac
                myCommand.Parameters.Add(pBuu_Cuc_Khai_Thac)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Value = Nuoc_Nhan
                myCommand.Parameters.Add(pNuoc_Nhan)

                Dim pMa_E1_Return As SqlParameter = New SqlParameter("@Ma_E1_Return", SqlDbType.VarChar, 13)
                pMa_E1_Return.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_E1_Return)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myE1_Autogeneration_Chi_Tiet As E1_Autogeneration_Chi_Tiet = New E1_Autogeneration_Chi_Tiet
                myE1_Autogeneration_Chi_Tiet.Ma_KH_E_Shipping = Ma_KH_E_Shipping
                myE1_Autogeneration_Chi_Tiet.Ma_BC = Buu_Cuc_Khai_Thac
                myE1_Autogeneration_Chi_Tiet.Nuoc_Nhan = Nuoc_Nhan
                myE1_Autogeneration_Chi_Tiet.Ma_E1 = pMa_E1_Return.Value
                Return myE1_Autogeneration_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Cap_Nhat_Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng E1_Auto_Gen
        ' Input: đối tượng datatable
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal myDataTable As DataTable)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                myConnection.Open()
                Dim i As Integer
                For i = 0 To myDataTable.Rows.Count - 1
                    Dim myCommand As SqlCommand = New SqlCommand("E1_Auto_Gen_Cap_Nhat_Them", myConnection)

                    ' Sử dụng Store Procedure
                    myCommand.CommandType = CommandType.StoredProcedure
                    ' Thêm các Parameters vào thủ tục				

                    Dim pid_shipping As SqlParameter = New SqlParameter("@id_shipping", SqlDbType.Int, 4)
                    pid_shipping.Value = Convert.ToInt32(myDataTable.Rows(i).Item("id_shipping"))
                    myCommand.Parameters.Add(pid_shipping)

                    Dim pMa_dv As SqlParameter = New SqlParameter("@Ma_dv", SqlDbType.VarChar, 3)
                    pMa_dv.Value = Convert.ToString(myDataTable.Rows(i).Item("Ma_dv"))
                    myCommand.Parameters.Add(pMa_dv)

                    Dim pMa_code As SqlParameter = New SqlParameter("@Ma_code", SqlDbType.VarChar, 2)
                    pMa_code.Value = Convert.ToString(myDataTable.Rows(i).Item("Ma_code"))
                    myCommand.Parameters.Add(pMa_code)

                    Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                    pMa_E1.Value = Convert.ToString(myDataTable.Rows(i).Item("Ma_E1"))
                    myCommand.Parameters.Add(pMa_E1)

                    Dim pMa_KH_E_Shipping As SqlParameter = New SqlParameter("@Ma_KH_E_Shipping", SqlDbType.VarChar, 50)
                    pMa_KH_E_Shipping.Value = Convert.ToString(myDataTable.Rows(i).Item("Ma_KH_E_Shipping"))
                    myCommand.Parameters.Add(pMa_KH_E_Shipping)

                    Dim pMa_BC As SqlParameter = New SqlParameter("@Ma_BC", SqlDbType.Int, 4)
                    pMa_BC.Value = Convert.ToInt32(myDataTable.Rows(i).Item("Ma_BC"))
                    myCommand.Parameters.Add(pMa_BC)

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
        ' Nội dung: Xóa dữ liệu từ bảng E1_Auto_Gen
        ' Input: id_shipping
        ' Output: 
        Public Sub Xoa(ByVal id_shipping As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Auto_Gen_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pid_shipping As SqlParameter = New SqlParameter("@id_shipping", SqlDbType.Int, 4)
                pid_shipping.Value = id_shipping
                myCommand.Parameters.Add(pid_shipping)

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
        ' Nội dung: Xóa dữ liệu từ bảng E1_Auto_Gen
        ' Input: id_shipping
        ' Output: 
        Public Sub Xoa_Theo_Ma_E1_Ma_KH(ByVal Ma_E1 As String, ByVal Ma_KH As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Auto_Gen_Xoa_Theo_Ma_E1_Ma_KH", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Value = Ma_KH
                myCommand.Parameters.Add(pMa_KH)

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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng E1_Auto_Gen
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Auto_Gen_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Auto_Gen_Danh_Sach")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
        '#Region "Lay_Id_Tu_Ma_E1"
        '        Public Function Lay_Id_Tu_Ma_E1(ByVal Ma_E1 As String) As Integer

        '            Dim ReturnValue As Integer
        '            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
        '            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
        '            Dim myCommand As SqlCommand

        '            myCommand = New SqlCommand("Select id_shipping from E1_Auto_Gen where (Ma_E1= '" & Ma_E1 & "')", myConnection)

        '            myConnection.Open()
        '            myCommand.CommandType = CommandType.Text
        '            myAdapter.SelectCommand = myCommand
        '            ReturnValue = IIf(myCommand.ExecuteScalar Is Nothing Or myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
        '            myConnection.Close()
        '            myConnection.Dispose()

        '            Return ReturnValue
        '        End Function
        '#End Region

    End Class
#End Region
End Namespace
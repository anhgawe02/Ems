
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Danh_Muc_BC_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Danh_Muc_BC_Chi_Tiet
    ' tương ứng với mộ trường của bảng Danh_Muc_BC trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Danh_Muc_BC_Chi_Tiet
        Public Ma_BC As Integer
        Public Ma_Don_Vi As String
        Public Ma_Bc_Cha As Integer
        Public Ma_Tinh As Integer
        Public Ten_Buu_Cuc As String
        Public Cap_Buu_Cuc As Integer
        Public Dia_Chi As String
        Public Dien_Thoai As String
        Public Ma_Nc As String
        Public Fax As String
        Public Ma_Quan_Ly As String
        Public IPMC As String
    End Class
#End Region
#Region "Danh_Muc_BC"
    Public Class Danh_Muc_BC
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Danh_Muc_BC
        ' Input: Ma_BC
        ' Output: Danh_Muc_BC_Chi_Tiet
        Public Function Lay(ByVal Ma_BC As Integer) As Danh_Muc_BC_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_BC_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pMa_BC As SqlParameter = New SqlParameter("@Ma_BC", SqlDbType.Int, 4)
                pMa_BC.Value = Ma_BC
                myCommand.Parameters.Add(pMa_BC)

                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
                pMa_Don_Vi.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Don_Vi)

                Dim pMa_Bc_Cha As SqlParameter = New SqlParameter("@Ma_Bc_Cha", SqlDbType.Int, 4)
                pMa_Bc_Cha.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_Cha)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 4)
                pMa_Tinh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Tinh)

                Dim pTen_Buu_Cuc As SqlParameter = New SqlParameter("@Ten_Buu_Cuc", SqlDbType.NVarChar, 100)
                pTen_Buu_Cuc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTen_Buu_Cuc)

                Dim pCap_Buu_Cuc As SqlParameter = New SqlParameter("@Cap_Buu_Cuc", SqlDbType.Int, 4)
                pCap_Buu_Cuc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCap_Buu_Cuc)

                Dim pDia_Chi As SqlParameter = New SqlParameter("@Dia_Chi", SqlDbType.NVarChar, 200)
                pDia_Chi.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDia_Chi)

                Dim pDien_Thoai As SqlParameter = New SqlParameter("@Dien_Thoai", SqlDbType.VarChar, 50)
                pDien_Thoai.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDien_Thoai)

                Dim pMa_Nc As SqlParameter = New SqlParameter("@Ma_Nc", SqlDbType.VarChar, 2)
                pMa_Nc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Nc)

                Dim pFax As SqlParameter = New SqlParameter("@Fax", SqlDbType.VarChar, 50)
                pFax.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pFax)

                Dim pMa_Quan_Ly As SqlParameter = New SqlParameter("@Ma_Quan_Ly", SqlDbType.VarChar, 2)
                pMa_Quan_Ly.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Quan_Ly)

                Dim pIPMC As SqlParameter = New SqlParameter("@IPMC", SqlDbType.VarChar, 6)
                pIPMC.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pIPMC)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
                Dim myDanh_Muc_BC_Chi_Tiet As Danh_Muc_BC_Chi_Tiet = New Danh_Muc_BC_Chi_Tiet
                myDanh_Muc_BC_Chi_Tiet.Ma_BC = Ma_BC
                If pMa_Don_Vi.Value Is System.DBNull.Value Then
                    myDanh_Muc_BC_Chi_Tiet.Ma_Don_Vi = ""
                Else
                    myDanh_Muc_BC_Chi_Tiet.Ma_Don_Vi = pMa_Don_Vi.Value
                End If

                If pMa_Bc_Cha.Value Is System.DBNull.Value Then
                    myDanh_Muc_BC_Chi_Tiet.Ma_Bc_Cha = 0
                Else
                    myDanh_Muc_BC_Chi_Tiet.Ma_Bc_Cha = pMa_Bc_Cha.Value
                End If

                If pMa_Tinh.Value Is System.DBNull.Value Then
                    myDanh_Muc_BC_Chi_Tiet.Ma_Tinh = 0
                Else
                    myDanh_Muc_BC_Chi_Tiet.Ma_Tinh = pMa_Tinh.Value
                End If

                If pTen_Buu_Cuc.Value Is System.DBNull.Value Then
                    myDanh_Muc_BC_Chi_Tiet.Ten_Buu_Cuc = ""
                Else
                    myDanh_Muc_BC_Chi_Tiet.Ten_Buu_Cuc = pTen_Buu_Cuc.Value
                End If

                If pCap_Buu_Cuc.Value Is System.DBNull.Value Then
                    myDanh_Muc_BC_Chi_Tiet.Cap_Buu_Cuc = 0
                Else
                    myDanh_Muc_BC_Chi_Tiet.Cap_Buu_Cuc = pCap_Buu_Cuc.Value
                End If

                If pDia_Chi.Value Is System.DBNull.Value Then
                    myDanh_Muc_BC_Chi_Tiet.Dia_Chi = ""
                Else
                    myDanh_Muc_BC_Chi_Tiet.Dia_Chi = pDia_Chi.Value
                End If

                If pDien_Thoai.Value Is System.DBNull.Value Then
                    myDanh_Muc_BC_Chi_Tiet.Dien_Thoai = ""
                Else
                    myDanh_Muc_BC_Chi_Tiet.Dien_Thoai = pDien_Thoai.Value
                End If

                If pMa_Nc.Value Is System.DBNull.Value Then
                    myDanh_Muc_BC_Chi_Tiet.Ma_Nc = ""
                Else
                    myDanh_Muc_BC_Chi_Tiet.Ma_Nc = pMa_Nc.Value
                End If

                If pFax.Value Is System.DBNull.Value Then
                    myDanh_Muc_BC_Chi_Tiet.Fax = ""
                Else
                    myDanh_Muc_BC_Chi_Tiet.Fax = pFax.Value
                End If

                If pMa_Quan_Ly.Value Is System.DBNull.Value Then
                    myDanh_Muc_BC_Chi_Tiet.Ma_Quan_Ly = ""
                Else
                    myDanh_Muc_BC_Chi_Tiet.Ma_Quan_Ly = pMa_Quan_Ly.Value
                End If

                If pIPMC.Value Is System.DBNull.Value Then
                    myDanh_Muc_BC_Chi_Tiet.IPMC = ""
                Else
                    myDanh_Muc_BC_Chi_Tiet.IPMC = pIPMC.Value
                End If

                'myDanh_Muc_BC_Chi_Tiet.Ma_Don_Vi = pMa_Don_Vi.Value
                'myDanh_Muc_BC_Chi_Tiet.Ma_Bc_Cha = pMa_Bc_Cha.Value
                'myDanh_Muc_BC_Chi_Tiet.Ma_Tinh = pMa_Tinh.Value
                'myDanh_Muc_BC_Chi_Tiet.Ten_Buu_Cuc = pTen_Buu_Cuc.Value
                'myDanh_Muc_BC_Chi_Tiet.Cap_Buu_Cuc = pCap_Buu_Cuc.Value
                'myDanh_Muc_BC_Chi_Tiet.Dia_Chi = pDia_Chi.Value
                'myDanh_Muc_BC_Chi_Tiet.Dien_Thoai = pDien_Thoai.Value
                'myDanh_Muc_BC_Chi_Tiet.Ma_Nc = pMa_Nc.Value
                'myDanh_Muc_BC_Chi_Tiet.Fax = pFax.Value
                'myDanh_Muc_BC_Chi_Tiet.Ma_Quan_Ly = pMa_Quan_Ly.Value
                'myDanh_Muc_BC_Chi_Tiet.IPMC = pIPMC.Value

                Return myDanh_Muc_BC_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Danh_Muc_BC
        ' Input:  Ma_Don_Vi, Ma_Bc_Cha, Ma_Tinh, Ten_Buu_Cuc, Cap_Buu_Cuc, Dia_Chi, Dien_Thoai, Fax, Ma_Quan_Ly,
        ' Output: 
        Public Sub Them(ByVal Ma_Don_Vi As String, ByVal Ma_Bc_Cha As Integer, ByVal Ma_Tinh As Integer, ByVal Ten_Buu_Cuc As String, ByVal Cap_Buu_Cuc As Integer, ByVal Dia_Chi As String, ByVal Dien_Thoai As String, ByVal Fax As String, ByVal Ma_Quan_Ly As String, ByVal Ma_Nc As String, ByVal IPMC As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_BC_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                
                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
                pMa_Don_Vi.Value = Ma_Don_Vi
                myCommand.Parameters.Add(pMa_Don_Vi)

                Dim pMa_Bc_Cha As SqlParameter = New SqlParameter("@Ma_Bc_Cha", SqlDbType.Int, 4)
                pMa_Bc_Cha.Value = Ma_Bc_Cha
                myCommand.Parameters.Add(pMa_Bc_Cha)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 4)
                pMa_Tinh.Value = Ma_Tinh
                myCommand.Parameters.Add(pMa_Tinh)

                Dim pTen_Buu_Cuc As SqlParameter = New SqlParameter("@Ten_Buu_Cuc", SqlDbType.NVarChar, 100)
                pTen_Buu_Cuc.Value = Ten_Buu_Cuc
                myCommand.Parameters.Add(pTen_Buu_Cuc)

                Dim pCap_Buu_Cuc As SqlParameter = New SqlParameter("@Cap_Buu_Cuc", SqlDbType.Int, 4)
                pCap_Buu_Cuc.Value = Cap_Buu_Cuc
                myCommand.Parameters.Add(pCap_Buu_Cuc)

                Dim pDia_Chi As SqlParameter = New SqlParameter("@Dia_Chi", SqlDbType.NVarChar, 200)
                pDia_Chi.Value = Dia_Chi
                myCommand.Parameters.Add(pDia_Chi)

                Dim pDien_Thoai As SqlParameter = New SqlParameter("@Dien_Thoai", SqlDbType.VarChar, 50)
                pDien_Thoai.Value = Dien_Thoai
                myCommand.Parameters.Add(pDien_Thoai)

                Dim pFax As SqlParameter = New SqlParameter("@Fax", SqlDbType.VarChar, 50)
                pFax.Value = Fax
                myCommand.Parameters.Add(pFax)

                Dim pMa_Quan_Ly As SqlParameter = New SqlParameter("@Ma_Quan_Ly", SqlDbType.VarChar, 2)
                pMa_Quan_Ly.Value = Ma_Quan_Ly
                myCommand.Parameters.Add(pMa_Quan_Ly)

                Dim pMa_Nc As SqlParameter = New SqlParameter("@Ma_Nc", SqlDbType.VarChar, 2)
                pMa_Nc.Value = Ma_Nc
                myCommand.Parameters.Add(pMa_Nc)

                Dim pIPMC As SqlParameter = New SqlParameter("@IPMC", SqlDbType.VarChar, 6)
                pIPMC.Direction = IPMC
                myCommand.Parameters.Add(pIPMC)

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
        ' Nội dung: Cập nhật dữ liệu vào bảng Danh_Muc_BC
        ' Input: Ma_BC,  Ma_Don_Vi , Ma_Bc_Cha , Ma_Tinh , Ten_Buu_Cuc , Cap_Buu_Cuc , Dia_Chi , Dien_Thoai , Fax , Ma_Quan_Ly ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Ma_BC As Integer, ByVal Ma_Don_Vi As String, ByVal Ma_Bc_Cha As Integer, ByVal Ma_Tinh As Integer, ByVal Ten_Buu_Cuc As String, ByVal Cap_Buu_Cuc As Integer, ByVal Dia_Chi As String, ByVal Dien_Thoai As String, ByVal Fax As String, ByVal Ma_Quan_Ly As String, ByVal Ma_Nc As String, ByVal IPMC As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_BC_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_BC As SqlParameter = New SqlParameter("@Ma_BC", SqlDbType.Int, 4)
                pMa_BC.Value = Ma_BC
                myCommand.Parameters.Add(pMa_BC)

                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
                pMa_Don_Vi.Value = Ma_Don_Vi
                myCommand.Parameters.Add(pMa_Don_Vi)

                Dim pMa_Bc_Cha As SqlParameter = New SqlParameter("@Ma_Bc_Cha", SqlDbType.Int, 4)
                pMa_Bc_Cha.Value = Ma_Bc_Cha
                myCommand.Parameters.Add(pMa_Bc_Cha)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 4)
                pMa_Tinh.Value = Ma_Tinh
                myCommand.Parameters.Add(pMa_Tinh)

                Dim pTen_Buu_Cuc As SqlParameter = New SqlParameter("@Ten_Buu_Cuc", SqlDbType.NVarChar, 100)
                pTen_Buu_Cuc.Value = Ten_Buu_Cuc
                myCommand.Parameters.Add(pTen_Buu_Cuc)

                Dim pCap_Buu_Cuc As SqlParameter = New SqlParameter("@Cap_Buu_Cuc", SqlDbType.Int, 4)
                pCap_Buu_Cuc.Value = Cap_Buu_Cuc
                myCommand.Parameters.Add(pCap_Buu_Cuc)

                Dim pDia_Chi As SqlParameter = New SqlParameter("@Dia_Chi", SqlDbType.NVarChar, 200)
                pDia_Chi.Value = Dia_Chi
                myCommand.Parameters.Add(pDia_Chi)

                Dim pDien_Thoai As SqlParameter = New SqlParameter("@Dien_Thoai", SqlDbType.VarChar, 50)
                pDien_Thoai.Value = Dien_Thoai
                myCommand.Parameters.Add(pDien_Thoai)

                Dim pFax As SqlParameter = New SqlParameter("@Fax", SqlDbType.VarChar, 50)
                pFax.Value = Fax
                myCommand.Parameters.Add(pFax)

                Dim pMa_Quan_Ly As SqlParameter = New SqlParameter("@Ma_Quan_Ly", SqlDbType.VarChar, 2)
                pMa_Quan_Ly.Value = Ma_Quan_Ly
                myCommand.Parameters.Add(pMa_Quan_Ly)

                Dim pMa_NC As SqlParameter = New SqlParameter("@Ma_Nc", SqlDbType.VarChar, 2)
                pMa_NC.Value = Ma_Nc
                myCommand.Parameters.Add(pMa_NC)

                Dim pIPMC As SqlParameter = New SqlParameter("@IPMC", SqlDbType.VarChar, 6)
                pIPMC.Value = IPMC
                myCommand.Parameters.Add(pIPMC)

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
        ' Nội dung: Cập nhật dữ liệu vào bảng Danh_Muc_BC
        ' Input: đối tượng thuộc lớp Danh_Muc_BC_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myDanh_Muc_BC_Chi_Tiet As Danh_Muc_BC_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_BC_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pMa_BC As SqlParameter = New SqlParameter("@Ma_BC", SqlDbType.Int, 4)
                pMa_BC.Value = myDanh_Muc_BC_Chi_Tiet.Ma_BC
                myCommand.Parameters.Add(pMa_BC)

                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
                pMa_Don_Vi.Value = myDanh_Muc_BC_Chi_Tiet.Ma_Don_Vi
                myCommand.Parameters.Add(pMa_Don_Vi)

                Dim pMa_Bc_Cha As SqlParameter = New SqlParameter("@Ma_Bc_Cha", SqlDbType.Int, 4)
                pMa_Bc_Cha.Value = myDanh_Muc_BC_Chi_Tiet.Ma_Bc_Cha
                myCommand.Parameters.Add(pMa_Bc_Cha)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 4)
                pMa_Tinh.Value = myDanh_Muc_BC_Chi_Tiet.Ma_Tinh
                myCommand.Parameters.Add(pMa_Tinh)

                Dim pTen_Buu_Cuc As SqlParameter = New SqlParameter("@Ten_Buu_Cuc", SqlDbType.NVarChar, 100)
                pTen_Buu_Cuc.Value = myDanh_Muc_BC_Chi_Tiet.Ten_Buu_Cuc
                myCommand.Parameters.Add(pTen_Buu_Cuc)

                Dim pCap_Buu_Cuc As SqlParameter = New SqlParameter("@Cap_Buu_Cuc", SqlDbType.Int, 4)
                pCap_Buu_Cuc.Value = myDanh_Muc_BC_Chi_Tiet.Cap_Buu_Cuc
                myCommand.Parameters.Add(pCap_Buu_Cuc)

                Dim pDia_Chi As SqlParameter = New SqlParameter("@Dia_Chi", SqlDbType.NVarChar, 200)
                pDia_Chi.Value = myDanh_Muc_BC_Chi_Tiet.Dia_Chi
                myCommand.Parameters.Add(pDia_Chi)

                Dim pDien_Thoai As SqlParameter = New SqlParameter("@Dien_Thoai", SqlDbType.VarChar, 50)
                pDien_Thoai.Value = myDanh_Muc_BC_Chi_Tiet.Dien_Thoai
                myCommand.Parameters.Add(pDien_Thoai)

                Dim pFax As SqlParameter = New SqlParameter("@Fax", SqlDbType.VarChar, 50)
                pFax.Value = myDanh_Muc_BC_Chi_Tiet.Fax
                myCommand.Parameters.Add(pFax)

                Dim pMa_Quan_Ly As SqlParameter = New SqlParameter("@Ma_Quan_Ly", SqlDbType.VarChar, 2)
                pMa_Quan_Ly.Value = myDanh_Muc_BC_Chi_Tiet.Ma_Quan_Ly
                myCommand.Parameters.Add(pMa_Quan_Ly)

                Dim pMa_Nc As SqlParameter = New SqlParameter("@Ma_Nc", SqlDbType.VarChar, 2)
                pMa_Nc.Value = myDanh_Muc_BC_Chi_Tiet.Ma_Nc
                myCommand.Parameters.Add(pMa_Nc)

                Dim pIPMC As SqlParameter = New SqlParameter("@IPMC", SqlDbType.VarChar, 6)
                pIPMC.Value = myDanh_Muc_BC_Chi_Tiet.IPMC
                myCommand.Parameters.Add(pIPMC)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Danh_Muc_BC
        ' Input: Ma_BC,  Ma_Don_Vi , Ma_Bc_Cha , Ma_Tinh , Ten_Buu_Cuc , Cap_Buu_Cuc , Dia_Chi , Dien_Thoai , Fax , Ma_Quan_Ly ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Ma_BC As Integer, ByVal Ma_Don_Vi As String, ByVal Ma_Bc_Cha As Integer, ByVal Ma_Tinh As Integer, ByVal Ten_Buu_Cuc As String, ByVal Cap_Buu_Cuc As Integer, ByVal Dia_Chi As String, ByVal Dien_Thoai As String, ByVal Fax As String, ByVal Ma_Quan_Ly As String, ByVal Ma_NC As String, ByVal IPMC As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_BC_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_BC As SqlParameter = New SqlParameter("@Ma_BC", SqlDbType.Int, 4)
                pMa_BC.Value = Ma_BC
                myCommand.Parameters.Add(pMa_BC)

                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
                pMa_Don_Vi.Value = Ma_Don_Vi
                myCommand.Parameters.Add(pMa_Don_Vi)

                Dim pMa_Bc_Cha As SqlParameter = New SqlParameter("@Ma_Bc_Cha", SqlDbType.Int, 4)
                pMa_Bc_Cha.Value = Ma_Bc_Cha
                myCommand.Parameters.Add(pMa_Bc_Cha)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 4)
                pMa_Tinh.Value = Ma_Tinh
                myCommand.Parameters.Add(pMa_Tinh)

                Dim pTen_Buu_Cuc As SqlParameter = New SqlParameter("@Ten_Buu_Cuc", SqlDbType.NVarChar, 100)
                pTen_Buu_Cuc.Value = Ten_Buu_Cuc
                myCommand.Parameters.Add(pTen_Buu_Cuc)

                Dim pCap_Buu_Cuc As SqlParameter = New SqlParameter("@Cap_Buu_Cuc", SqlDbType.Int, 4)
                pCap_Buu_Cuc.Value = Cap_Buu_Cuc
                myCommand.Parameters.Add(pCap_Buu_Cuc)

                Dim pDia_Chi As SqlParameter = New SqlParameter("@Dia_Chi", SqlDbType.NVarChar, 200)
                pDia_Chi.Value = Dia_Chi
                myCommand.Parameters.Add(pDia_Chi)

                Dim pDien_Thoai As SqlParameter = New SqlParameter("@Dien_Thoai", SqlDbType.VarChar, 50)
                pDien_Thoai.Value = Dien_Thoai
                myCommand.Parameters.Add(pDien_Thoai)

                Dim pFax As SqlParameter = New SqlParameter("@Fax", SqlDbType.VarChar, 50)
                pFax.Value = Fax
                myCommand.Parameters.Add(pFax)

                Dim pMa_Quan_Ly As SqlParameter = New SqlParameter("@Ma_Quan_Ly", SqlDbType.VarChar, 2)
                pMa_Quan_Ly.Value = Ma_Quan_Ly
                myCommand.Parameters.Add(pMa_Quan_Ly)

                Dim pMa_NC As SqlParameter = New SqlParameter("@Ma_NC", SqlDbType.VarChar, 2)
                pMa_NC.Value = Ma_NC
                myCommand.Parameters.Add(pMa_NC)

                Dim pIPMC As SqlParameter = New SqlParameter("@IPMC", SqlDbType.VarChar, 6)
                pIPMC.Value = IPMC
                myCommand.Parameters.Add(pIPMC)

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
        ' Nội dung: Xóa dữ liệu từ bảng Danh_Muc_BC
        ' Input: Ma_BC
        ' Output: 
        Public Sub Xoa(ByVal Ma_BC As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_BC_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
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
#Region "Danh_Sach"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Danh_Muc_BC
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_BC_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Danh_Muc_BC_Danh_Sach")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Danh_Sach_Lay_Theo_Ma_Nuoc"
        Public Function Danh_Sach_Lay_Theo_Ma_Nuoc(ByVal Ma_Nuoc As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_BC_Danh_Sach_Lay_Theo_Ma_Nuoc", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                myCommand.Parameters.Add(pMa_Nuoc)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Danh_Muc_BC_Danh_Sach_Lay_Theo_Ma_Nuoc")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Danh_Sach_Lay_Theo_Ma_Tinh"
        Public Function Danh_Sach_Lay_Theo_Ma_Tinh(ByVal Ma_Tinh As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_BC_Danh_Sach_Lay_Theo_Ma_Tinh", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int)
                pMa_Tinh.Value = Ma_Tinh
                myCommand.Parameters.Add(pMa_Tinh)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Danh_Muc_BC_Danh_Sach_Lay_Theo_Ma_Tinh")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Danh_Sach_IPMC_Not_Null"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Danh_Muc_BC
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_IPMC_Not_Null() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_BC_Danh_Sach_IPMC_Not_Null", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Danh_Muc_BC_Danh_Sach_IPMC_Not_Null")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Lay_Boi_Danh_Muc_Quan_Ly"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Danh_Muc_Quan_Ly thông qua khóa chính 
        ' Input: Ma_Quan_Ly
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Danh_Muc_Quan_Ly(ByVal Ma_Quan_Ly As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_BC_Lay_Boi_Danh_Muc_Quan_Ly", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Quan_Ly As SqlParameter = New SqlParameter("@Ma_Quan_Ly", SqlDbType.VarChar, 2)
                pMa_Quan_Ly.Value = Ma_Quan_Ly
                myCommand.Parameters.Add(pMa_Quan_Ly)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Danh_Muc_BC_Lay_Boi_Danh_Muc_Quan_Ly")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Danh_Sach_Rut_Gon: Hiển thị Ma_Bc, IPMC, Ma_Tinh, Ten_Bc"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Danh_Muc_BC theo dạng rút gọn chỉ gồm Ma_Bc, Ten_Buu_Cuc, Ma_Tinh
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Rut_Gon() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_BC_Danh_Sach_Rut_Gon", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Danh_Muc_BC_Danh_Sach_Rut_Gon")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_Rut_Gon_Theo_Ma_Tinh"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Danh_Muc_BC theo dạng rút gọn chỉ gồm Ma_Bc, Ten_Buu_Cuc, Ma_Tinh
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Rut_Gon_Theo_Ma_Tinh(ByVal Ma_Tinh As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_BC_Danh_Sach_Rut_Gon_Theo_Ma_Tinh", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int)
                pMa_Tinh.Value = Ma_Tinh
                myCommand.Parameters.Add(pMa_Tinh)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Danh_Muc_BC_Danh_Sach_Rut_Gon_Theo_Ma_Tinh")
                myConnection.Close()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_Rut_Gon: Hiển thị Ma_Bc, IPMC, Ma_Tinh, Ten_Bc"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Danh_Muc_BC theo dạng rút gọn chỉ gồm Ma_Bc, Ten_Buu_Cuc, Ma_Tinh
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Rut_Gon_VN() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_BC_Danh_Sach_Rut_Gon_VN", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Danh_Muc_BC_Danh_Sach_Rut_Gon_VN")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_Rut_Gon_IPMC_Not_Null: Hiển thị Ma_Bc, IPMC, Ma_Tinh, Ten_Bc"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Danh_Muc_BC theo dạng rút gọn chỉ gồm Ma_Bc, Ten_Buu_Cuc, Ma_Tinh
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Rut_Gon_IPMC_Not_Null() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_BC_Danh_Sach_Rut_Gon_IPMC_Not_Null", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Danh_Muc_BC_Danh_Sach_Rut_Gon_IPMC_Not_Null")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_Rut_Gon_KT: Hiển thị Ma_Bc, Ten_Bc"
        Public Function Danh_Sach_Rut_Gon_KT() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_BC_Danh_Sach_Rut_Gon_KT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Danh_Muc_BC_Danh_Sach_Rut_Gon_KT")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Lay_Boi_Ma_Don_Vi"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Ma_Don_Vi thông qua khóa chính 
        ' Input: Ma_Don_Vi
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ma_Don_Vi(ByVal Ma_Don_Vi As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_BC_Lay_Boi_Ma_Don_Vi", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myAdapter.Fill(myDataSet, "Danh_Muc_BC_Lay_Boi_Ma_Don_Vi")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
                pMa_Don_Vi.Value = Ma_Don_Vi
                myCommand.Parameters.Add(pMa_Don_Vi)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_IPMC_Theo_Ma_BC"
        Public Function Lay_IPMC_Theo_Ma_BC(ByVal myMa_Bc As Integer) As String
            Try
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myCommand As SqlCommand
                Dim ReturnValue As String

                myCommand = New SqlCommand("Select IPMC from Danh_Muc_Bc where (Ma_bc = " & myMa_Bc & ") ", myConnection)

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
#Region "Kiem tra MaBc"
                ' Ngày tạo: 01/07/08
                ' Người tạo: Nguyễn Đức Trung
                ' Nội dung: Kiểm tra xem co ton tai MABC hay khong
                ' Input: Id_E2
                ' Output: count(*)
        Public Function Kiem_Tra_MaBc(ByVal Ma_Bc As Integer) As Boolean
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_Bc_Kiem_Tra_MaBc", myConnection)
                Dim myReturn As Boolean
                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_BC", SqlDbType.Int, 4)
                pMa_Bc.Value = Ma_Bc
                myCommand.Parameters.Add(pMa_Bc)

                Dim pIsValid As SqlParameter = New SqlParameter("@IsValid", SqlDbType.Bit, 1)
                pIsValid.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pIsValid)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                myReturn = pIsValid.Value
                Return myReturn
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Khai Thác: Proceduce sử dụng trong phần khai thác bưu phẩm"

#Region "Danh_Muc_BC_Lay_Boi_Ma_Don_Vi_KT"
        ' Ngày tạo: 11/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy dữ liệu từ bảng Danh_muc_Bc từ Ma_Don_Vi
        ' Input: Ma_Don_Vi
        ' Output: DataSet chứa toàn bộ dữ liệu
        Public Function Danh_Muc_BC_Lay_Boi_Ma_Don_Vi_KT(ByVal Ma_Don_Vi As String) As Danh_Muc_BC_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_BC_Lay_Boi_Ma_Don_Vi_KT", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
                pMa_Don_Vi.Value = Ma_Don_Vi
                myCommand.Parameters.Add(pMa_Don_Vi)

                Dim pMa_BC As SqlParameter = New SqlParameter("@Ma_BC", SqlDbType.Int, 4)
                pMa_BC.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_BC)

                Dim pMa_Bc_Cha As SqlParameter = New SqlParameter("@Ma_Bc_Cha", SqlDbType.Int, 4)
                pMa_Bc_Cha.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_Cha)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 4)
                pMa_Tinh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Tinh)

                Dim pTen_Buu_Cuc As SqlParameter = New SqlParameter("@Ten_Buu_Cuc", SqlDbType.NVarChar, 100)
                pTen_Buu_Cuc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTen_Buu_Cuc)

                Dim pCap_Buu_Cuc As SqlParameter = New SqlParameter("@Cap_Buu_Cuc", SqlDbType.Int, 4)
                pCap_Buu_Cuc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCap_Buu_Cuc)

                Dim pDia_Chi As SqlParameter = New SqlParameter("@Dia_Chi", SqlDbType.NVarChar, 200)
                pDia_Chi.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDia_Chi)

                Dim pDien_Thoai As SqlParameter = New SqlParameter("@Dien_Thoai", SqlDbType.VarChar, 50)
                pDien_Thoai.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDien_Thoai)

                Dim pFax As SqlParameter = New SqlParameter("@Fax", SqlDbType.VarChar, 50)
                pFax.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pFax)

                Dim pMa_Quan_Ly As SqlParameter = New SqlParameter("@Ma_Quan_Ly", SqlDbType.VarChar, 2)
                pMa_Quan_Ly.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Quan_Ly)

                Dim pMa_Nc As SqlParameter = New SqlParameter("@Ma_Nc", SqlDbType.VarChar, 2)
                pMa_Nc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Nc)

                Dim pIPMC As SqlParameter = New SqlParameter("@IPMC", SqlDbType.VarChar, 6)
                pIPMC.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pIPMC)


                myConnection.Open()
                myCommand.ExecuteScalar()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()

                Dim myDanh_Muc_BC_Chi_Tiet As Danh_Muc_BC_Chi_Tiet = New Danh_Muc_BC_Chi_Tiet
                myDanh_Muc_BC_Chi_Tiet.Ma_BC = pMa_BC.Value
                myDanh_Muc_BC_Chi_Tiet.Ma_Don_Vi = Ma_Don_Vi
                myDanh_Muc_BC_Chi_Tiet.Ma_Bc_Cha = pMa_Bc_Cha.Value
                myDanh_Muc_BC_Chi_Tiet.Ma_Tinh = pMa_Tinh.Value
                myDanh_Muc_BC_Chi_Tiet.Ten_Buu_Cuc = pTen_Buu_Cuc.Value
                myDanh_Muc_BC_Chi_Tiet.Cap_Buu_Cuc = pCap_Buu_Cuc.Value
                myDanh_Muc_BC_Chi_Tiet.Dia_Chi = pDia_Chi.Value
                myDanh_Muc_BC_Chi_Tiet.Dien_Thoai = pDien_Thoai.Value
                myDanh_Muc_BC_Chi_Tiet.Fax = pFax.Value
                myDanh_Muc_BC_Chi_Tiet.Ma_Quan_Ly = pMa_Quan_Ly.Value
                myDanh_Muc_BC_Chi_Tiet.Ma_Nc = pMa_Nc.Value
                myDanh_Muc_BC_Chi_Tiet.IPMC = pIPMC.Value
                Return myDanh_Muc_BC_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Danh_Muc_BC_Nhan_Lay_Boi_MA_E1_KT"
        ' Ngày tạo: 11/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy dữ liệu từ bảng Danh_muc_Bc từ Ma_Don_Vi
        ' Input: Ma_Don_Vi
        ' Output: DataSet chứa toàn bộ dữ liệu
        Public Function Danh_Muc_BC_Nhan_Lay_Boi_MA_E1_KT(ByVal Ma_E1 As String) As Danh_Muc_BC_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_BC_Nhan_Lay_Boi_MA_E1_KT", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
                pMa_Don_Vi.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Don_Vi)

                Dim pMa_BC As SqlParameter = New SqlParameter("@Ma_BC", SqlDbType.Int, 12)
                pMa_BC.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_BC)

                Dim pMa_Bc_Cha As SqlParameter = New SqlParameter("@Ma_Bc_Cha", SqlDbType.Int, 12)
                pMa_Bc_Cha.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_Cha)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 12)
                pMa_Tinh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Tinh)

                Dim pTen_Buu_Cuc As SqlParameter = New SqlParameter("@Ten_Buu_Cuc", SqlDbType.NVarChar, 100)
                pTen_Buu_Cuc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTen_Buu_Cuc)

                Dim pCap_Buu_Cuc As SqlParameter = New SqlParameter("@Cap_Buu_Cuc", SqlDbType.Int, 12)
                pCap_Buu_Cuc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCap_Buu_Cuc)

                Dim pDia_Chi As SqlParameter = New SqlParameter("@Dia_Chi", SqlDbType.NVarChar, 200)
                pDia_Chi.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDia_Chi)

                Dim pDien_Thoai As SqlParameter = New SqlParameter("@Dien_Thoai", SqlDbType.VarChar, 50)
                pDien_Thoai.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDien_Thoai)

                Dim pFax As SqlParameter = New SqlParameter("@Fax", SqlDbType.VarChar, 50)
                pFax.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pFax)

                Dim pMa_Quan_Ly As SqlParameter = New SqlParameter("@Ma_Quan_Ly", SqlDbType.VarChar, 2)
                pMa_Quan_Ly.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Quan_Ly)

                Dim pMa_Nc As SqlParameter = New SqlParameter("@Ma_Nc", SqlDbType.VarChar, 2)
                pMa_Nc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Nc)

                Dim pIPMC As SqlParameter = New SqlParameter("@IPMC", SqlDbType.VarChar, 6)
                pIPMC.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pIPMC)

                myConnection.Open()
                myCommand.ExecuteScalar()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myDanh_Muc_BC_Chi_Tiet As Danh_Muc_BC_Chi_Tiet = New Danh_Muc_BC_Chi_Tiet
                myDanh_Muc_BC_Chi_Tiet.Ma_BC = pMa_BC.Value
                myDanh_Muc_BC_Chi_Tiet.Ma_Don_Vi = pMa_Don_Vi.Value
                myDanh_Muc_BC_Chi_Tiet.Ma_Bc_Cha = pMa_Bc_Cha.Value
                myDanh_Muc_BC_Chi_Tiet.Ma_Tinh = pMa_Tinh.Value
                myDanh_Muc_BC_Chi_Tiet.Ten_Buu_Cuc = pTen_Buu_Cuc.Value
                myDanh_Muc_BC_Chi_Tiet.Cap_Buu_Cuc = pCap_Buu_Cuc.Value
                myDanh_Muc_BC_Chi_Tiet.Dia_Chi = pDia_Chi.Value
                myDanh_Muc_BC_Chi_Tiet.Dien_Thoai = pDien_Thoai.Value
                myDanh_Muc_BC_Chi_Tiet.Fax = pFax.Value
                myDanh_Muc_BC_Chi_Tiet.Ma_Quan_Ly = pMa_Quan_Ly.Value
                myDanh_Muc_BC_Chi_Tiet.Ma_Nc = pMa_Nc.Value
                myDanh_Muc_BC_Chi_Tiet.IPMC = pIPMC.Value
                Return myDanh_Muc_BC_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Danh_Muc_BC_Nhan_Lay_Boi_Ma_Bc_KT"
        ' Ngày tạo: 11/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy dữ liệu từ bảng Danh_muc_Bc từ Ma_Don_Vi
        ' Input: Ma_Don_Vi
        ' Output: DataSet chứa toàn bộ dữ liệu
        Public Function Danh_Muc_BC_Nhan_Lay_Boi_Ma_Bc_KT(ByVal Ma_Bc As Integer) As Danh_Muc_BC_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_BC_Nhan_Lay_Boi_Ma_Bc_KT", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 12)
                pMa_Bc.Value = Ma_Bc
                myCommand.Parameters.Add(pMa_Bc)

                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
                pMa_Don_Vi.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Don_Vi)

                Dim pMa_Bc_Cha As SqlParameter = New SqlParameter("@Ma_Bc_Cha", SqlDbType.Int, 12)
                pMa_Bc_Cha.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_Cha)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 12)
                pMa_Tinh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Tinh)

                Dim pTen_Buu_Cuc As SqlParameter = New SqlParameter("@Ten_Buu_Cuc", SqlDbType.NVarChar, 100)
                pTen_Buu_Cuc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTen_Buu_Cuc)

                Dim pCap_Buu_Cuc As SqlParameter = New SqlParameter("@Cap_Buu_Cuc", SqlDbType.Int, 12)
                pCap_Buu_Cuc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCap_Buu_Cuc)

                Dim pDia_Chi As SqlParameter = New SqlParameter("@Dia_Chi", SqlDbType.NVarChar, 200)
                pDia_Chi.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDia_Chi)

                Dim pDien_Thoai As SqlParameter = New SqlParameter("@Dien_Thoai", SqlDbType.VarChar, 50)
                pDien_Thoai.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDien_Thoai)

                Dim pFax As SqlParameter = New SqlParameter("@Fax", SqlDbType.VarChar, 50)
                pFax.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pFax)

                Dim pMa_Quan_Ly As SqlParameter = New SqlParameter("@Ma_Quan_Ly", SqlDbType.VarChar, 2)
                pMa_Quan_Ly.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Quan_Ly)

                Dim pMa_Nc As SqlParameter = New SqlParameter("@Ma_Nc", SqlDbType.VarChar, 2)
                pMa_Nc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Nc)

                Dim pIPMC As SqlParameter = New SqlParameter("@IPMC", SqlDbType.VarChar, 6)
                pIPMC.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pIPMC)


                myConnection.Open()
                myCommand.ExecuteScalar()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myDanh_Muc_BC_Chi_Tiet As Danh_Muc_BC_Chi_Tiet = New Danh_Muc_BC_Chi_Tiet
                With myDanh_Muc_BC_Chi_Tiet
                    .Ma_BC = Ma_Bc
                    .Ma_Don_Vi = pMa_Don_Vi.Value
                    .Ma_Bc_Cha = pMa_Bc_Cha.Value
                    .Ma_Tinh = pMa_Tinh.Value
                    .Ten_Buu_Cuc = pTen_Buu_Cuc.Value
                    .Cap_Buu_Cuc = pCap_Buu_Cuc.Value
                    .Dia_Chi = pDia_Chi.Value
                    .Dien_Thoai = pDien_Thoai.Value
                    .Fax = pFax.Value
                    .Ma_Quan_Ly = pMa_Quan_Ly.Value
                    .Ma_Nc = pMa_Nc.Value
                    .IPMC = pIPMC.Value
                End With
                Return myDanh_Muc_BC_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#End Region
#Region "Lay_Boi_Ma_IPMC"
        ' Ngày tạo: 20/11/08
        ' Người tạo: Dinh Quang Trung        
        Public Function Lay_Boi_IPMC(ByVal IPMC As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_BC_Lay_Boi_IPMC", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pIPMC As SqlParameter = New SqlParameter("@IPMC", SqlDbType.VarChar, 6)
                pIPMC.Value = IPMC
                myCommand.Parameters.Add(pIPMC)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Danh_Muc_BC_Lay_Boi_IPMC")

                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Danh_Muc_BC_Quoc_Te"

        Public Function Danh_Muc_BC_Quoc_Te() As DataSet

            ' The procedure returns these columns:
            ' Ma_BC
            ' IPMC
            ' Ma_Tinh
            ' Ten_Buu_Cuc


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_BC_Quoc_Te"
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

    End Class
#End Region
End Namespace

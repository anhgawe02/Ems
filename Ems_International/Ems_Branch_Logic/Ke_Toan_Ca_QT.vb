Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Ke_Toan_Ca_QT_Chi_Tiet"
    '*******************************************************    
    '
    '*******************************************************
    Public Class Ke_Toan_Ca_QT_Chi_Tiet
        Public Id_Ca As String ' Id ca k? toán: DDDDDDYYYYMMDDW
        Public Id_Phan_Loai As Integer   ' Phan loai Quoc Te Di / Quoc Te Den
        Public Ma_Bc_Khai_Thac As Integer ' Mã buu c?c khai thác
        Public Ngay_Khai_Thac As Integer ' Ngày k? toán
        Public Ca_Khai_Thac As Integer ' Ca k? toán
        Public Tong_So_Den As Integer ' T?ng s? BP du?c xác nh?n d?n
        Public Tong_So_Di As Integer ' T?ng s? BP du?c dóng di
        Public Tong_KL_Den As Integer ' T?ng KL BP du?c xác nh?n d?n
        Public Tong_KL_Di As Integer ' T?ng KL BP du?c dóng di
        Public E1_Den_Nhieu As Integer ' T?ng s? E1 d?n nhi?u
        Public E1_Di_Nhieu As Integer ' T?ng s? E1 du?c dóng di nhi?u l?n trong ca
        Public E1_Chenh_Lech_KL As Integer ' T?ng s? E1 chênh l?ch kh?i lu?ng gi?a xác nh?n d?n và dóng di
        Public E1_Den_Chua_Di As Integer ' T?ng s? E1 dã du?c xác nh?n d?n mà chua dóng di
        Public E1_Di_Chua_Den As Integer ' T?ng s? E1 dã du?c dóng di mà chua du?c xác nh?n d?n
        Public Chot_Sl As Boolean ' Ch?t s? li?u sau khi cân d?i ca
    End Class
#End Region
#Region "Ke_Toan_Ca_QT"
    Public Class Ke_Toan_Ca_QT
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày t?o: 15/6/08
        ' Ngu?i t?o: Nguy?n B?ng
        ' N?i dung: L?y thông tin t? b?ng Ke_Toan_Ca_QT
        ' Input: Id_Ca
        ' Output: Ke_Toan_Ca_QT_Chi_Tiet
        Public Function Lay(ByVal Id_Ca As String) As Ke_Toan_Ca_QT_Chi_Tiet
            Try
                ' T?o d?i tu?ng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ke_Toan_Ca_QT_Lay", myConnection)

                ' S? d?ng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                myCommand.CommandTimeout = 20000
                ' Thêm các Parameters vào th? t?c            
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 16)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pId_Phan_Loai As SqlParameter = New SqlParameter("@Id_Phan_Loai", SqlDbType.Int, 4)
                pId_Phan_Loai.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Phan_Loai)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pNgay_Khai_Thac As SqlParameter = New SqlParameter("@Ngay_Khai_Thac", SqlDbType.Int, 4)
                pNgay_Khai_Thac.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_Khai_Thac)

                Dim pCa_Khai_Thac As SqlParameter = New SqlParameter("@Ca_Khai_Thac", SqlDbType.Int, 4)
                pCa_Khai_Thac.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCa_Khai_Thac)

                Dim pTong_So_Den As SqlParameter = New SqlParameter("@Tong_So_Den", SqlDbType.Int, 4)
                pTong_So_Den.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTong_So_Den)

                Dim pTong_So_Di As SqlParameter = New SqlParameter("@Tong_So_Di", SqlDbType.Int, 4)
                pTong_So_Di.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTong_So_Di)

                Dim pTong_KL_Den As SqlParameter = New SqlParameter("@Tong_KL_Den", SqlDbType.Int, 4)
                pTong_KL_Den.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTong_KL_Den)

                Dim pTong_KL_Di As SqlParameter = New SqlParameter("@Tong_KL_Di", SqlDbType.Int, 4)
                pTong_KL_Di.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTong_KL_Di)

                Dim pE1_Den_Nhieu As SqlParameter = New SqlParameter("@E1_Den_Nhieu", SqlDbType.Int, 4)
                pE1_Den_Nhieu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pE1_Den_Nhieu)

                Dim pE1_Di_Nhieu As SqlParameter = New SqlParameter("@E1_Di_Nhieu", SqlDbType.Int, 4)
                pE1_Di_Nhieu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pE1_Di_Nhieu)

                Dim pE1_Chenh_Lech_KL As SqlParameter = New SqlParameter("@E1_Chenh_Lech_KL", SqlDbType.Int, 4)
                pE1_Chenh_Lech_KL.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pE1_Chenh_Lech_KL)

                Dim pE1_Den_Chua_Di As SqlParameter = New SqlParameter("@E1_Den_Chua_Di", SqlDbType.Int, 4)
                pE1_Den_Chua_Di.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pE1_Den_Chua_Di)

                Dim pE1_Di_Chua_Den As SqlParameter = New SqlParameter("@E1_Di_Chua_Den", SqlDbType.Int, 4)
                pE1_Di_Chua_Den.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pE1_Di_Chua_Den)

                Dim pChot_Sl As SqlParameter = New SqlParameter("@Chot_Sl", SqlDbType.Bit, 1)
                pChot_Sl.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pChot_Sl)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myKe_Toan_Ca_QT_Chi_Tiet As Ke_Toan_Ca_QT_Chi_Tiet = New Ke_Toan_Ca_QT_Chi_Tiet
                myKe_Toan_Ca_QT_Chi_Tiet.Id_Ca = Id_Ca
                myKe_Toan_Ca_QT_Chi_Tiet.Id_Phan_Loai = pId_Phan_Loai.Value
                myKe_Toan_Ca_QT_Chi_Tiet.Ma_Bc_Khai_Thac = pMa_Bc_Khai_Thac.Value
                myKe_Toan_Ca_QT_Chi_Tiet.Ngay_Khai_Thac = pNgay_Khai_Thac.Value
                myKe_Toan_Ca_QT_Chi_Tiet.Ca_Khai_Thac = pCa_Khai_Thac.Value
                myKe_Toan_Ca_QT_Chi_Tiet.Tong_So_Den = pTong_So_Den.Value
                myKe_Toan_Ca_QT_Chi_Tiet.Tong_So_Di = pTong_So_Di.Value
                myKe_Toan_Ca_QT_Chi_Tiet.Tong_KL_Den = pTong_KL_Den.Value
                myKe_Toan_Ca_QT_Chi_Tiet.Tong_KL_Di = pTong_KL_Di.Value
                myKe_Toan_Ca_QT_Chi_Tiet.E1_Den_Nhieu = pE1_Den_Nhieu.Value
                myKe_Toan_Ca_QT_Chi_Tiet.E1_Di_Nhieu = pE1_Di_Nhieu.Value
                myKe_Toan_Ca_QT_Chi_Tiet.E1_Chenh_Lech_KL = pE1_Chenh_Lech_KL.Value
                myKe_Toan_Ca_QT_Chi_Tiet.E1_Den_Chua_Di = pE1_Den_Chua_Di.Value
                myKe_Toan_Ca_QT_Chi_Tiet.E1_Di_Chua_Den = pE1_Di_Chua_Den.Value
                myKe_Toan_Ca_QT_Chi_Tiet.Chot_Sl = pChot_Sl.Value
                Return myKe_Toan_Ca_QT_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Ke_Toan_Ca_QT_Lay_Boi_Id_Ca_Tu_Ngay_Den_Ngay"
        Public Function Ke_Toan_Ca_QT_Lay_Boi_Id_Ca_Tu_Ngay_Den_Ngay(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_BC_Khai_Thac As Integer, ByVal Id_Phan_Loai As Integer) As DataTable
            Try
                ' T?o d?i tu?ng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ke_Toan_Ca_QT_Lay_Boi_Id_Ca_Tu_Ngay_Den_Ngay", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' S? d?ng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                myCommand.CommandTimeout = 20000
                ' Thêm các Parameters vào th? t?c
                Dim pId_Ca_Tu_Ngay As SqlParameter = New SqlParameter("@Id_Ca_Tu_Ngay", SqlDbType.Int)
                pId_Ca_Tu_Ngay.Value = Id_Ca_Tu_Ngay
                myCommand.Parameters.Add(pId_Ca_Tu_Ngay)

                Dim pId_Ca_Den_Ngay As SqlParameter = New SqlParameter("@Id_Ca_Den_Ngay", SqlDbType.Int)
                pId_Ca_Den_Ngay.Value = Id_Ca_Den_Ngay
                myCommand.Parameters.Add(pId_Ca_Den_Ngay)

                Dim pMa_BC_Khai_Thac As SqlParameter = New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int)
                pMa_BC_Khai_Thac.Value = Ma_BC_Khai_Thac
                myCommand.Parameters.Add(pMa_BC_Khai_Thac)

                Dim pId_Phan_Loai As SqlParameter = New SqlParameter("@Id_Phan_Loai", SqlDbType.Int)
                pId_Phan_Loai.Value = Id_Phan_Loai
                myCommand.Parameters.Add(pId_Phan_Loai)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("Ke_Toan_Ca_QT_Lay_Boi_Id_Ca_Tu_Ngay_Den_Ngay") Is Nothing Then
                    myDataSet.Tables("Ke_Toan_Ca_QT_Lay_Boi_Id_Ca_Tu_Ngay_Den_Ngay").Clear()
                End If
                myAdapter.Fill(myDataSet, "Ke_Toan_Ca_QT_Lay_Boi_Id_Ca_Tu_Ngay_Den_Ngay")

                Return myDataSet.Tables("Ke_Toan_Ca_QT_Lay_Boi_Id_Ca_Tu_Ngay_Den_Ngay")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Ke_Toan_Ca_QT_Lay_Boi_Id_Ca_Can_Doi_Di_Den"

        Public Function Ke_Toan_Ca_QT_Lay_Boi_Id_Ca_Can_Doi_Di_Den(ByVal Id_Ca As String) As DataTable
            Try
                ' T?o d?i tu?ng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ke_Toan_Ca_QT_Lay_Boi_Id_Ca_Can_Doi_Di_Den", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' S? d?ng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                myCommand.CommandTimeout = 20000
                ' Thêm các Parameters vào th? t?c
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 16)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("Ke_Toan_Ca_QT_Lay_Boi_Id_Ca_Can_Doi_Di_Den") Is Nothing Then
                    myDataSet.Tables("Ke_Toan_Ca_QT_Lay_Boi_Id_Ca_Can_Doi_Di_Den").Clear()
                End If
                myAdapter.Fill(myDataSet, "Ke_Toan_Ca_QT_Lay_Boi_Id_Ca_Can_Doi_Di_Den")

                Return myDataSet.Tables("Ke_Toan_Ca_QT_Lay_Boi_Id_Ca_Can_Doi_Di_Den")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Ke_Toan_Ca_QT_Cap_Nhat_Them_Can_Doi_Di_Den"
        Public Function Ke_Toan_Ca_QT_Cap_Nhat_Them_Can_Doi_Di_Den(ByVal id_Ca As String, ByVal id_Phan_Loai As Integer, ByVal ma_BC_Khai_Thac As Integer, ByVal ngay_Khai_Thac As Integer, ByVal ca_Khai_Thac As Integer, ByVal chot_SL As Boolean) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Ke_Toan_Ca_QT_Cap_Nhat_Them_Can_Doi_Di_Den"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_Ca))
                MyCommand.Parameters.Add(New SqlParameter("@Id_Phan_Loai", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, id_Phan_Loai))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_BC_Khai_Thac))
                MyCommand.Parameters.Add(New SqlParameter("@Ngay_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ngay_Khai_Thac))
                MyCommand.Parameters.Add(New SqlParameter("@Ca_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ca_Khai_Thac))
                MyCommand.Parameters.Add(New SqlParameter("@Chot_SL", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, chot_SL))

                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation

                MyConnection.Open()
                MyCommand.CommandTimeout = 20000

                numRows = MyCommand.ExecuteNonQuery()
                Return numRows
                'return the number of rows affected
            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)

            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()

            End Try
        End Function

#End Region

#Region "Lay Thong Tin Ke Toan Quoc Te"

#Region "Lay_Thong_Tin_Ke_Toan"
        Public Function Lay_Thong_Tin_Ke_Toan(ByVal f_date As Decimal, ByVal t_date As Decimal, ByVal chot_sl_den As Boolean, ByVal chot_sl_di As Boolean, ByVal chot_sl_qg As Boolean) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Lay_Thong_Tin_Ke_Toan"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@f_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, f_date))
                MyCommand.Parameters.Add(New SqlParameter("@t_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, t_date))
                MyCommand.Parameters.Add(New SqlParameter("@chot_sl_den", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, chot_sl_den))
                MyCommand.Parameters.Add(New SqlParameter("@chot_sl_di", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, chot_sl_di))
                MyCommand.Parameters.Add(New SqlParameter("@chot_sl_qg", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, chot_sl_qg))

                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                MyCommand.CommandTimeout = 20000
                numRows = MyCommand.ExecuteNonQuery()
                Return numRows
                'return the number of rows affected
            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)

            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()

            End Try
        End Function

#End Region

#Region "Accounting"
#Region "Lay du lieu tu bang Accounting"
        Public Function Accounting_Danh_Sach() As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                myConnection.Open()
                Dim myDataSet As New DataSet
                Dim strSQL As String = "Select * From Accounting"
                Dim myAdapter As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(strSQL, myConnection)
                Dim myDataTable As New DataTable

                myAdapter.Fill(myDataSet, "Accounting")
                myConnection.Close()
                myConnection.Dispose()
                myDataTable = myDataSet.Tables(0)
                Return myDataTable
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Accounting_Danh_Sach_Duong_Thu_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong"

        Public Function Accounting_Danh_Sach_Duong_Thu_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong(ByVal f_date As Decimal, ByVal t_date As Decimal, ByVal chieu As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ma_Bc
            ' Ten_BC


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Danh_Sach_Duong_Thu_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@f_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, f_date))
                MyCommand.Parameters.Add(New SqlParameter("@t_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, t_date))
                MyCommand.Parameters.Add(New SqlParameter("@chieu", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, chieu))

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

#Region "Accounting_Danh_Sach_Chuyen_Thu_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong"

        Public Function Accounting_Danh_Sach_Chuyen_Thu_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong(ByVal f_date As Decimal, ByVal t_date As Decimal, ByVal ma_BC As String, ByVal chieu As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ma_Bc
            ' SCT


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Danh_Sach_Chuyen_Thu_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@f_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, f_date))
                MyCommand.Parameters.Add(New SqlParameter("@t_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, t_date))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_BC", SqlDbType.VarChar, 6, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, ma_BC))
                MyCommand.Parameters.Add(New SqlParameter("@chieu", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, chieu))

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

#Region "Accounting_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_Duong_Thu"

        Public Function Accounting_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_Duong_Thu(ByVal f_date As Decimal, ByVal t_date As Decimal, ByVal ma_Bc As String, ByVal chieu As Integer) As DataSet

            ' The procedure returns these columns:
            ' Acc_Key
            ' ID
            ' Ngay
            ' SCT
            ' BCG
            ' BCN
            ' KL_EMS
            ' KL_EMS_TT
            ' LOAI_D
            ' LOAI_M
            ' LOAI_R
            ' NOTICE
            ' HVC
            ' I_O
            ' Ten_BCG
            ' Ten_BCN


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_Duong_Thu"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@f_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, f_date))
                MyCommand.Parameters.Add(New SqlParameter("@t_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, t_date))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc", SqlDbType.VarChar, 6, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, ma_Bc))
                MyCommand.Parameters.Add(New SqlParameter("@chieu", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, chieu))

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

#Region "Accounting_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_So_Chuyen_Thu"

        Public Function Accounting_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_So_Chuyen_Thu(ByVal f_date As Decimal, ByVal t_date As Decimal, ByVal ma_Bc As String, ByVal sct As String, ByVal chieu As Integer) As DataSet

            ' The procedure returns these columns:
            ' Acc_Key
            ' ID
            ' Ngay
            ' SCT
            ' BCG
            ' BCN
            ' KL_EMS
            ' KL_EMS_TT
            ' LOAI_D
            ' LOAI_M
            ' LOAI_R
            ' NOTICE
            ' HVC
            ' I_O
            ' Ten_BCG
            ' Ten_BCN


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_So_Chuyen_Thu"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@f_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, f_date))
                MyCommand.Parameters.Add(New SqlParameter("@t_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, t_date))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc", SqlDbType.VarChar, 6, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, ma_Bc))
                MyCommand.Parameters.Add(New SqlParameter("@SCT", SqlDbType.VarChar, 6, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, sct))
                MyCommand.Parameters.Add(New SqlParameter("@chieu", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, chieu))

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

#Region "Accounting_Cap_Nhat"
        Public Function Accounting_Cap_Nhat(ByVal acc_Key As Integer, ByVal id As Integer, ByVal ngay As DateTime, ByVal sct As String, ByVal bcg As String, ByVal bcn As String, ByVal kl_ems As Decimal, ByVal loai_d As Decimal, ByVal loai_m As Decimal, ByVal loai_r As Decimal, ByVal notice As String, ByVal hvc As String, ByVal i_o As Decimal) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Acc_Key", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, acc_Key))
                MyCommand.Parameters.Add(New SqlParameter("@ID", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, id))
                MyCommand.Parameters.Add(New SqlParameter("@Ngay", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, ngay))
                MyCommand.Parameters.Add(New SqlParameter("@SCT", SqlDbType.VarChar, 6, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, sct))
                MyCommand.Parameters.Add(New SqlParameter("@BCG", SqlDbType.VarChar, 6, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, bcg))
                MyCommand.Parameters.Add(New SqlParameter("@BCN", SqlDbType.VarChar, 6, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, bcn))
                MyCommand.Parameters.Add(New SqlParameter("@KL_EMS", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 2, "", DataRowVersion.Current, kl_ems))
                MyCommand.Parameters.Add(New SqlParameter("@LOAI_D", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, loai_d))
                MyCommand.Parameters.Add(New SqlParameter("@LOAI_M", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, loai_m))
                MyCommand.Parameters.Add(New SqlParameter("@LOAI_R", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, loai_r))
                MyCommand.Parameters.Add(New SqlParameter("@NOTICE", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, notice))
                MyCommand.Parameters.Add(New SqlParameter("@HVC", SqlDbType.VarChar, 2, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, hvc))
                MyCommand.Parameters.Add(New SqlParameter("@I_O", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, i_o))

                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                Return numRows
                'return the number of rows affected
            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)

            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()

            End Try
        End Function

#End Region

#Region "Accounting_Cap_Nhat_Notice"
        Public Function Accounting_Cap_Nhat_Notice(ByVal acc_Key As Integer, ByVal notice As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Cap_Nhat_Notice"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Acc_Key", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, acc_Key))
                MyCommand.Parameters.Add(New SqlParameter("@NOTICE", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, notice))

                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                Return numRows
                'return the number of rows affected
            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)

            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()

            End Try
        End Function

#End Region

#Region "Accounting_Danh_Sach_Tu_Ngay_Den_Ngay"

        Public Function Accounting_Danh_Sach_Tu_Ngay_Den_Ngay(ByVal f_date As Decimal, ByVal t_date As Decimal) As DataSet

            ' The procedure returns these columns:
            ' Acc_Key
            ' ID
            ' Ngay
            ' SCT
            ' BCG
            ' BCN
            ' KL_EMS
            ' LOAI_D
            ' LOAI_M
            ' LOAI_R
            ' NOTICE
            ' HVC
            ' I_O
            ' Ten_BCG
            ' Ten_BCN


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Danh_Sach_Tu_Ngay_Den_Ngay"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@f_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, f_date))
                MyCommand.Parameters.Add(New SqlParameter("@t_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, t_date))

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

#Region "Accounting_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong"

        Public Function Accounting_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong(ByVal f_date As Decimal, ByVal t_date As Decimal, ByVal chieu As Integer) As DataSet

            ' The procedure returns these columns:
            ' Acc_Key
            ' ID
            ' Ngay
            ' SCT
            ' BCG
            ' BCN
            ' KL_EMS
            ' LOAI_D
            ' LOAI_M
            ' LOAI_R
            ' NOTICE
            ' HVC
            ' I_O
            ' Ten_BCG
            ' Ten_BCN


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@f_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, f_date))
                MyCommand.Parameters.Add(New SqlParameter("@t_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, t_date))
                MyCommand.Parameters.Add(New SqlParameter("@chieu", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, chieu))

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

#Region "Loc theo loai chuyen thu"
#Region "Accounting_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Loai_CT"

        Public Function Accounting_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Loai_CT(ByVal f_date As Decimal, ByVal t_date As Decimal, ByVal chieu As Integer, ByVal loai_ct As String) As DataSet

            ' The procedure returns these columns:
            ' Acc_Key
            ' ID
            ' Ngay
            ' SCT
            ' BCG
            ' BCN
            ' KL_EMS
            ' KL_EMS_TT
            ' LOAI_D
            ' LOAI_M
            ' LOAI_R
            ' NOTICE
            ' HVC
            ' I_O
            ' Ten_BCG
            ' Ten_BCN


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Loai_CT"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@f_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, f_date))
                MyCommand.Parameters.Add(New SqlParameter("@t_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, t_date))
                MyCommand.Parameters.Add(New SqlParameter("@chieu", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, chieu))
                MyCommand.Parameters.Add(New SqlParameter("@loai_ct", SqlDbType.VarChar, 30, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, loai_ct))

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

#Region "Accounting_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_Duong_Thu_Loai_CT"

        Public Function Accounting_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_Duong_Thu_Loai_CT(ByVal f_date As Decimal, ByVal t_date As Decimal, ByVal ma_Bc As String, ByVal chieu As Integer, ByVal loai_CT As String) As DataSet

            ' The procedure returns these columns:
            ' Acc_Key
            ' ID
            ' Ngay
            ' SCT
            ' BCG
            ' BCN
            ' KL_EMS
            ' KL_EMS_TT
            ' LOAI_D
            ' LOAI_M
            ' LOAI_R
            ' NOTICE
            ' HVC
            ' I_O
            ' Ten_BCG
            ' Ten_BCN


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_Duong_Thu_Loai_CT"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@f_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, f_date))
                MyCommand.Parameters.Add(New SqlParameter("@t_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, t_date))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc", SqlDbType.VarChar, 6, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, ma_Bc))
                MyCommand.Parameters.Add(New SqlParameter("@chieu", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, chieu))
                MyCommand.Parameters.Add(New SqlParameter("@Loai_CT", SqlDbType.VarChar, 30, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, loai_CT))

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

#Region "Accounting_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_So_Chuyen_Thu_Loai_CT"

        Public Function Accounting_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_So_Chuyen_Thu_Loai_CT(ByVal f_date As Decimal, ByVal t_date As Decimal, ByVal ma_Bc As String, ByVal sct As String, ByVal chieu As Integer, ByVal loai_CT As String) As DataSet

            ' The procedure returns these columns:
            ' Acc_Key
            ' ID
            ' Ngay
            ' SCT
            ' BCG
            ' BCN
            ' KL_EMS
            ' KL_EMS_TT
            ' LOAI_D
            ' LOAI_M
            ' LOAI_R
            ' NOTICE
            ' HVC
            ' I_O
            ' Ten_BCG
            ' Ten_BCN


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_So_Chuyen_Thu_Loai_CT"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@f_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, f_date))
                MyCommand.Parameters.Add(New SqlParameter("@t_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, t_date))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc", SqlDbType.VarChar, 6, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, ma_Bc))
                MyCommand.Parameters.Add(New SqlParameter("@SCT", SqlDbType.VarChar, 6, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, sct))
                MyCommand.Parameters.Add(New SqlParameter("@chieu", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, chieu))
                MyCommand.Parameters.Add(New SqlParameter("@Loai_CT", SqlDbType.VarChar, 30, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, loai_CT))

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

#Region "Accounting_Danh_Sach_Loai_Chuyen_Thu_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong"

        Public Function Accounting_Danh_Sach_Loai_Chuyen_Thu_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong(ByVal f_date As Decimal, ByVal t_date As Decimal, ByVal chieu As Integer) As DataSet

            ' The procedure returns these columns:
            ' Loai_Chuyen_Thu


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Danh_Sach_Loai_Chuyen_Thu_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@f_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, f_date))
                MyCommand.Parameters.Add(New SqlParameter("@t_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, t_date))
                MyCommand.Parameters.Add(New SqlParameter("@chieu", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, chieu))

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

#End Region

#Region "Accounting_Cap_Nhat_Them"
        Public Function Accounting_Cap_Nhat_Them(ByVal acc_Key As Integer, ByVal id As Integer, ByVal ngay As DateTime, ByVal sct As String, ByVal bcg As String, ByVal bcn As String, ByVal kl_ems As Decimal, ByVal loai_d As Decimal, ByVal loai_m As Decimal, ByVal loai_r As Decimal, ByVal notice As String, ByVal hvc As String, ByVal i_o As Decimal) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Acc_Key", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, acc_Key))
                MyCommand.Parameters.Add(New SqlParameter("@ID", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, id))
                MyCommand.Parameters.Add(New SqlParameter("@Ngay", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, ngay))
                MyCommand.Parameters.Add(New SqlParameter("@SCT", SqlDbType.VarChar, 6, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, sct))
                MyCommand.Parameters.Add(New SqlParameter("@BCG", SqlDbType.VarChar, 6, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, bcg))
                MyCommand.Parameters.Add(New SqlParameter("@BCN", SqlDbType.VarChar, 6, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, bcn))
                MyCommand.Parameters.Add(New SqlParameter("@KL_EMS", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 2, "", DataRowVersion.Current, kl_ems))
                MyCommand.Parameters.Add(New SqlParameter("@LOAI_D", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, loai_d))
                MyCommand.Parameters.Add(New SqlParameter("@LOAI_M", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, loai_m))
                MyCommand.Parameters.Add(New SqlParameter("@LOAI_R", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, loai_r))
                MyCommand.Parameters.Add(New SqlParameter("@NOTICE", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, notice))
                MyCommand.Parameters.Add(New SqlParameter("@HVC", SqlDbType.VarChar, 2, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, hvc))
                MyCommand.Parameters.Add(New SqlParameter("@I_O", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, i_o))

                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                Return numRows
                'return the number of rows affected
            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)

            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()

            End Try
        End Function

#End Region

#Region "Accounting_Xoa"
        Public Function Accounting_Xoa(ByVal acc_Key As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Acc_Key", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, acc_Key))

                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                Return numRows
                'return the number of rows affected
            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)

            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()

            End Try
        End Function

#End Region

#Region "Accounting_Tong_Hop_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong"

        Public Function Accounting_Tong_Hop_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong(ByVal f_date As Decimal, ByVal t_date As Decimal, ByVal chieu As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ten_Dich_Vu
            ' KL_EMS
            ' ED
            ' EM
            ' ER


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Tong_Hop_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@f_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, f_date))
                MyCommand.Parameters.Add(New SqlParameter("@t_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, t_date))
                MyCommand.Parameters.Add(New SqlParameter("@chieu", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, chieu))

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

#End Region

#Region "Accounting_USPS"
#Region "Accounting_USPS_Cap_Nhat"
        Public Function Accounting_USPS_Cap_Nhat(ByVal Acc_Key As Integer, ByVal ID As Integer, ByVal Ngay As DateTime, ByVal SCT As String, ByVal BCG As String, ByVal BCN As String, ByVal KL_EMS As Decimal, ByVal KL_EMS_TT As Decimal, ByVal LOAI_D As Decimal, ByVal LOAI_M As Decimal, ByVal LOAI_R As Decimal, ByVal NOTICE As String, ByVal HVC As String, ByVal I_O As Decimal) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_USPS_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pAcc_Key As SqlParameter = New SqlParameter("@Acc_Key", SqlDbType.Int, 0)
                pAcc_Key.Value = Acc_Key
                MyCommand.Parameters.Add(pAcc_Key)

                Dim pID As SqlParameter = New SqlParameter("@ID", SqlDbType.Int, 0)
                pID.Value = ID
                MyCommand.Parameters.Add(pID)

                Dim pNgay As SqlParameter = New SqlParameter("@Ngay", SqlDbType.DateTime, 0)
                pNgay.Value = Ngay
                MyCommand.Parameters.Add(pNgay)

                Dim pSCT As SqlParameter = New SqlParameter("@SCT", SqlDbType.VarChar, 6)
                pSCT.Value = SCT
                MyCommand.Parameters.Add(pSCT)

                Dim pBCG As SqlParameter = New SqlParameter("@BCG", SqlDbType.VarChar, 6)
                pBCG.Value = BCG
                MyCommand.Parameters.Add(pBCG)

                Dim pBCN As SqlParameter = New SqlParameter("@BCN", SqlDbType.VarChar, 6)
                pBCN.Value = BCN
                MyCommand.Parameters.Add(pBCN)

                Dim pKL_EMS As SqlParameter = New SqlParameter("@KL_EMS", SqlDbType.Decimal, 0)
                pKL_EMS.Value = KL_EMS
                MyCommand.Parameters.Add(pKL_EMS)

                Dim pKL_EMS_TT As SqlParameter = New SqlParameter("@KL_EMS_TT", SqlDbType.Decimal, 0)
                pKL_EMS_TT.Value = KL_EMS_TT
                MyCommand.Parameters.Add(pKL_EMS_TT)

                Dim pLOAI_D As SqlParameter = New SqlParameter("@LOAI_D", SqlDbType.Decimal, 0)
                pLOAI_D.Value = LOAI_D
                MyCommand.Parameters.Add(pLOAI_D)

                Dim pLOAI_M As SqlParameter = New SqlParameter("@LOAI_M", SqlDbType.Decimal, 0)
                pLOAI_M.Value = LOAI_M
                MyCommand.Parameters.Add(pLOAI_M)

                Dim pLOAI_R As SqlParameter = New SqlParameter("@LOAI_R", SqlDbType.Decimal, 0)
                pLOAI_R.Value = LOAI_R
                MyCommand.Parameters.Add(pLOAI_R)

                Dim pNOTICE As SqlParameter = New SqlParameter("@NOTICE", SqlDbType.VarChar, 20)
                pNOTICE.Value = NOTICE
                MyCommand.Parameters.Add(pNOTICE)

                Dim pHVC As SqlParameter = New SqlParameter("@HVC", SqlDbType.VarChar, 2)
                pHVC.Value = HVC
                MyCommand.Parameters.Add(pHVC)

                Dim pI_O As SqlParameter = New SqlParameter("@I_O", SqlDbType.Decimal, 0)
                pI_O.Value = I_O
                MyCommand.Parameters.Add(pI_O)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()

                Return numRows
                'Return numRows

            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)

            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()

            End Try
        End Function

#End Region
#Region "Accounting_USPS_Cap_Nhat_Them"
        Public Function Accounting_USPS_Cap_Nhat_Them(ByVal Acc_Key As Integer, ByVal ID As Integer, ByVal Ngay As DateTime, ByVal SCT As String, ByVal BCG As String, ByVal BCN As String, ByVal KL_EMS As Decimal, ByVal KL_EMS_TT As Decimal, ByVal LOAI_D As Decimal, ByVal LOAI_M As Decimal, ByVal LOAI_R As Decimal, ByVal NOTICE As String, ByVal HVC As String, ByVal I_O As Decimal) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_USPS_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pAcc_Key As SqlParameter = New SqlParameter("@Acc_Key", SqlDbType.Int, 0)
                pAcc_Key.Value = Acc_Key
                MyCommand.Parameters.Add(pAcc_Key)

                Dim pID As SqlParameter = New SqlParameter("@ID", SqlDbType.Int, 0)
                pID.Value = ID
                MyCommand.Parameters.Add(pID)

                Dim pNgay As SqlParameter = New SqlParameter("@Ngay", SqlDbType.DateTime, 0)
                pNgay.Value = Ngay
                MyCommand.Parameters.Add(pNgay)

                Dim pSCT As SqlParameter = New SqlParameter("@SCT", SqlDbType.VarChar, 6)
                pSCT.Value = SCT
                MyCommand.Parameters.Add(pSCT)

                Dim pBCG As SqlParameter = New SqlParameter("@BCG", SqlDbType.VarChar, 6)
                pBCG.Value = BCG
                MyCommand.Parameters.Add(pBCG)

                Dim pBCN As SqlParameter = New SqlParameter("@BCN", SqlDbType.VarChar, 6)
                pBCN.Value = BCN
                MyCommand.Parameters.Add(pBCN)

                Dim pKL_EMS As SqlParameter = New SqlParameter("@KL_EMS", SqlDbType.Decimal, 0)
                pKL_EMS.Value = KL_EMS
                MyCommand.Parameters.Add(pKL_EMS)

                Dim pKL_EMS_TT As SqlParameter = New SqlParameter("@KL_EMS_TT", SqlDbType.Decimal, 0)
                pKL_EMS_TT.Value = KL_EMS_TT
                MyCommand.Parameters.Add(pKL_EMS_TT)

                Dim pLOAI_D As SqlParameter = New SqlParameter("@LOAI_D", SqlDbType.Decimal, 0)
                pLOAI_D.Value = LOAI_D
                MyCommand.Parameters.Add(pLOAI_D)

                Dim pLOAI_M As SqlParameter = New SqlParameter("@LOAI_M", SqlDbType.Decimal, 0)
                pLOAI_M.Value = LOAI_M
                MyCommand.Parameters.Add(pLOAI_M)

                Dim pLOAI_R As SqlParameter = New SqlParameter("@LOAI_R", SqlDbType.Decimal, 0)
                pLOAI_R.Value = LOAI_R
                MyCommand.Parameters.Add(pLOAI_R)

                Dim pNOTICE As SqlParameter = New SqlParameter("@NOTICE", SqlDbType.VarChar, 20)
                pNOTICE.Value = NOTICE
                MyCommand.Parameters.Add(pNOTICE)

                Dim pHVC As SqlParameter = New SqlParameter("@HVC", SqlDbType.VarChar, 2)
                pHVC.Value = HVC
                MyCommand.Parameters.Add(pHVC)

                Dim pI_O As SqlParameter = New SqlParameter("@I_O", SqlDbType.Decimal, 0)
                pI_O.Value = I_O
                MyCommand.Parameters.Add(pI_O)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()

                Return numRows
                'Return numRows

            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)

            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()

            End Try
        End Function

#End Region
#Region "Accounting_USPS_Danh_Sach"

        Public Function Accounting_USPS_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Acc_Key
            ' ID
            ' Ngay
            ' SCT
            ' BCG
            ' BCN
            ' KL_EMS
            ' KL_EMS_TT
            ' LOAI_D
            ' LOAI_M
            ' LOAI_R
            ' NOTICE
            ' HVC
            ' I_O


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_USPS_Danh_Sach"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters


                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                Adapter.Fill(MyDataSet)

                Return MyDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                Adapter.Dispose()
            End Try
        End Function
#End Region
#Region "Accounting_USPS_Xoa"
        Public Function Accounting_USPS_Xoa(ByVal Acc_Key As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_USPS_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pAcc_Key As SqlParameter = New SqlParameter("@Acc_Key", SqlDbType.Int, 0)
                pAcc_Key.Value = Acc_Key
                MyCommand.Parameters.Add(pAcc_Key)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()

                Return numRows
                'Return numRows

            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)

            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()

            End Try
        End Function

#End Region
#Region "Accounting_USPS_Danh_Sach_Duong_Thu_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong"

        Public Function Accounting_USPS_Danh_Sach_Duong_Thu_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong(ByVal F_date As Decimal, ByVal T_date As Decimal, ByVal Chieu As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ma_Bc
            ' Ten_BC


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_USPS_Danh_Sach_Duong_Thu_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pF_date As SqlParameter = New SqlParameter("@f_date", SqlDbType.Decimal, 0)
                pF_date.Value = F_date
                MyCommand.Parameters.Add(pF_date)

                Dim pT_date As SqlParameter = New SqlParameter("@t_date", SqlDbType.Decimal, 0)
                pT_date.Value = T_date
                MyCommand.Parameters.Add(pT_date)

                Dim pChieu As SqlParameter = New SqlParameter("@chieu", SqlDbType.Int, 0)
                pChieu.Value = Chieu
                MyCommand.Parameters.Add(pChieu)


                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                Adapter.Fill(MyDataSet)

                Return MyDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                Adapter.Dispose()
            End Try
        End Function
#End Region
#Region "Accounting_USPS_Danh_Sach_Chuyen_Thu_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong"

        Public Function Accounting_USPS_Danh_Sach_Chuyen_Thu_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong(ByVal f_date As Decimal, ByVal t_date As Decimal, ByVal ma_BC As String, ByVal chieu As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ma_Bc
            ' SCT


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_USPS_Danh_Sach_Chuyen_Thu_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@f_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, f_date))
                MyCommand.Parameters.Add(New SqlParameter("@t_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, t_date))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_BC", SqlDbType.VarChar, 6, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, ma_BC))
                MyCommand.Parameters.Add(New SqlParameter("@chieu", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, chieu))

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
#Region "Accounting_USPS_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_Duong_Thu"

        Public Function Accounting_USPS_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_Duong_Thu(ByVal f_date As Decimal, ByVal t_date As Decimal, ByVal ma_Bc As String, ByVal chieu As Integer) As DataSet

            ' The procedure returns these columns:
            ' Acc_Key
            ' ID
            ' Ngay
            ' SCT
            ' BCG
            ' BCN
            ' KL_EMS
            ' KL_EMS_TT
            ' LOAI_D
            ' LOAI_M
            ' LOAI_R
            ' NOTICE
            ' HVC
            ' I_O
            ' Ten_BCG
            ' Ten_BCN


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_USPS_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_Duong_Thu"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@f_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, f_date))
                MyCommand.Parameters.Add(New SqlParameter("@t_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, t_date))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc", SqlDbType.VarChar, 6, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, ma_Bc))
                MyCommand.Parameters.Add(New SqlParameter("@chieu", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, chieu))

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
#Region "Accounting_USPS_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_So_Chuyen_Thu"

        Public Function Accounting_USPS_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_So_Chuyen_Thu(ByVal f_date As Decimal, ByVal t_date As Decimal, ByVal ma_Bc As String, ByVal sct As String, ByVal chieu As Integer) As DataSet

            ' The procedure returns these columns:
            ' Acc_Key
            ' ID
            ' Ngay
            ' SCT
            ' BCG
            ' BCN
            ' KL_EMS
            ' KL_EMS_TT
            ' LOAI_D
            ' LOAI_M
            ' LOAI_R
            ' NOTICE
            ' HVC
            ' I_O
            ' Ten_BCG
            ' Ten_BCN


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_USPS_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_So_Chuyen_Thu"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@f_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, f_date))
                MyCommand.Parameters.Add(New SqlParameter("@t_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, t_date))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc", SqlDbType.VarChar, 6, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, ma_Bc))
                MyCommand.Parameters.Add(New SqlParameter("@SCT", SqlDbType.VarChar, 6, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, sct))
                MyCommand.Parameters.Add(New SqlParameter("@chieu", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, chieu))

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
#Region "Accounting_USPS_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong"

        Public Function Accounting_USPS_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong(ByVal f_date As Decimal, ByVal t_date As Decimal, ByVal chieu As Integer) As DataSet

            ' The procedure returns these columns:
            ' Acc_Key
            ' ID
            ' Ngay
            ' SCT
            ' BCG
            ' BCN
            ' KL_EMS
            ' LOAI_D
            ' LOAI_M
            ' LOAI_R
            ' NOTICE
            ' HVC
            ' I_O
            ' Ten_BCG
            ' Ten_BCN


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_USPS_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@f_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, f_date))
                MyCommand.Parameters.Add(New SqlParameter("@t_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, t_date))
                MyCommand.Parameters.Add(New SqlParameter("@chieu", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, chieu))

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
#Region "Accounting_USPS_Danh_Sach_Tu_Ngay_Den_Ngay"

        Public Function Accounting_USPS_Danh_Sach_Tu_Ngay_Den_Ngay(ByVal f_date As Decimal, ByVal t_date As Decimal) As DataSet

            ' The procedure returns these columns:
            ' Acc_Key
            ' ID
            ' Ngay
            ' SCT
            ' BCG
            ' BCN
            ' KL_EMS
            ' LOAI_D
            ' LOAI_M
            ' LOAI_R
            ' NOTICE
            ' HVC
            ' I_O
            ' Ten_BCG
            ' Ten_BCN


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_USPS_Danh_Sach_Tu_Ngay_Den_Ngay"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@f_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, f_date))
                MyCommand.Parameters.Add(New SqlParameter("@t_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, t_date))

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
#Region "Accounting_USPS_Tong_Hop_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong"

        Public Function Accounting_USPS_Tong_Hop_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong(ByVal f_date As Decimal, ByVal t_date As Decimal, ByVal chieu As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ten_Dich_Vu
            ' KL_EMS
            ' ED
            ' EM
            ' ER


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_USPS_Tong_Hop_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@f_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, f_date))
                MyCommand.Parameters.Add(New SqlParameter("@t_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, t_date))
                MyCommand.Parameters.Add(New SqlParameter("@chieu", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, chieu))

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

#Region "Loc theo loai chuyen thu"
#Region "Accounting_USPS_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Loai_CT"

        Public Function Accounting_USPS_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Loai_CT(ByVal f_date As Decimal, ByVal t_date As Decimal, ByVal chieu As Integer, ByVal loai_ct As String) As DataSet

            ' The procedure returns these columns:
            ' Acc_Key
            ' ID
            ' Ngay
            ' SCT
            ' BCG
            ' BCN
            ' KL_EMS
            ' KL_EMS_TT
            ' LOAI_D
            ' LOAI_M
            ' LOAI_R
            ' NOTICE
            ' HVC
            ' I_O
            ' Ten_BCG
            ' Ten_BCN


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_USPS_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Loai_CT"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@f_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, f_date))
                MyCommand.Parameters.Add(New SqlParameter("@t_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, t_date))
                MyCommand.Parameters.Add(New SqlParameter("@chieu", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, chieu))
                MyCommand.Parameters.Add(New SqlParameter("@loai_ct", SqlDbType.VarChar, 30, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, loai_ct))

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
#Region "Accounting_USPS_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_Duong_Thu_Loai_CT"

        Public Function Accounting_USPS_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_Duong_Thu_Loai_CT(ByVal f_date As Decimal, ByVal t_date As Decimal, ByVal ma_Bc As String, ByVal chieu As Integer, ByVal loai_CT As String) As DataSet

            ' The procedure returns these columns:
            ' Acc_Key
            ' ID
            ' Ngay
            ' SCT
            ' BCG
            ' BCN
            ' KL_EMS
            ' KL_EMS_TT
            ' LOAI_D
            ' LOAI_M
            ' LOAI_R
            ' NOTICE
            ' HVC
            ' I_O
            ' Ten_BCG
            ' Ten_BCN


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_USPS_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_Duong_Thu_Loai_CT"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@f_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, f_date))
                MyCommand.Parameters.Add(New SqlParameter("@t_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, t_date))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc", SqlDbType.VarChar, 6, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, ma_Bc))
                MyCommand.Parameters.Add(New SqlParameter("@chieu", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, chieu))
                MyCommand.Parameters.Add(New SqlParameter("@Loai_CT", SqlDbType.VarChar, 30, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, loai_CT))

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
#Region "Accounting_USPS_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_So_Chuyen_Thu_Loai_CT"

        Public Function Accounting_USPS_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_So_Chuyen_Thu_Loai_CT(ByVal f_date As Decimal, ByVal t_date As Decimal, ByVal ma_Bc As String, ByVal sct As String, ByVal chieu As Integer, ByVal loai_CT As String) As DataSet

            ' The procedure returns these columns:
            ' Acc_Key
            ' ID
            ' Ngay
            ' SCT
            ' BCG
            ' BCN
            ' KL_EMS
            ' KL_EMS_TT
            ' LOAI_D
            ' LOAI_M
            ' LOAI_R
            ' NOTICE
            ' HVC
            ' I_O
            ' Ten_BCG
            ' Ten_BCN


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_USPS_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong_Theo_So_Chuyen_Thu_Loai_CT"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@f_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, f_date))
                MyCommand.Parameters.Add(New SqlParameter("@t_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, t_date))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc", SqlDbType.VarChar, 6, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, ma_Bc))
                MyCommand.Parameters.Add(New SqlParameter("@SCT", SqlDbType.VarChar, 6, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, sct))
                MyCommand.Parameters.Add(New SqlParameter("@chieu", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, chieu))
                MyCommand.Parameters.Add(New SqlParameter("@Loai_CT", SqlDbType.VarChar, 30, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, loai_CT))

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
#Region "Accounting_USPS_Danh_Sach_Loai_Chuyen_Thu_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong"

        Public Function Accounting_USPS_Danh_Sach_Loai_Chuyen_Thu_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong(ByVal f_date As Decimal, ByVal t_date As Decimal, ByVal chieu As Integer) As DataSet

            ' The procedure returns these columns:
            ' Loai_Chuyen_Thu


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_USPS_Danh_Sach_Loai_Chuyen_Thu_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@f_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, f_date))
                MyCommand.Parameters.Add(New SqlParameter("@t_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, t_date))
                MyCommand.Parameters.Add(New SqlParameter("@chieu", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, chieu))

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

#End Region
#End Region

#Region "Accounting_Transit"
#Region "Lay du lieu tu bang Accounting_Transit"
        Public Function Accounting_Transit_Danh_Sach() As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                myConnection.Open()
                Dim myDataSet As New DataSet
                Dim strSQL As String = "Select * From Accounting_Transit"
                Dim myAdapter As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(strSQL, myConnection)
                Dim myDataTable As New DataTable

                myAdapter.Fill(myDataSet, "Accounting_Transit")
                myConnection.Close()
                myConnection.Dispose()
                myDataTable = myDataSet.Tables(0)
                Return myDataTable
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Accounting_Transit_Danh_Sach_Tu_Ngay_Den_Ngay"

        Public Function Accounting_Transit_Danh_Sach_Tu_Ngay_Den_Ngay(ByVal f_date As Decimal, ByVal t_date As Decimal) As DataSet

            ' The procedure returns these columns:
            ' ID
            ' Ngay
            ' SCT
            ' SH_EMS
            ' BC_GUI
            ' Nuoc_QG
            ' NUOC_NHAN
            ' KL_EMS
            ' Loai
            ' Van_don
            ' Cuoc
            ' Notice


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Transit_Danh_Sach_Tu_Ngay_Den_Ngay"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@f_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, f_date))
                MyCommand.Parameters.Add(New SqlParameter("@t_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, t_date))

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

#Region "Accounting_Transit_Danh_Sach_SCT_Tu_Ngay_Den_Ngay_Theo_Nuoc_QG"

        Public Function Accounting_Transit_Danh_Sach_SCT_Tu_Ngay_Den_Ngay_Theo_Nuoc_QG(ByVal f_date As Decimal, ByVal t_date As Decimal, ByVal nuoc_QG As String) As DataSet

            ' The procedure returns these columns:
            ' Ma_Bc
            ' SCT


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Transit_Danh_Sach_SCT_Tu_Ngay_Den_Ngay_Theo_Nuoc_QG"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@f_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, f_date))
                MyCommand.Parameters.Add(New SqlParameter("@t_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, t_date))
                MyCommand.Parameters.Add(New SqlParameter("@Nuoc_QG", SqlDbType.VarChar, 3, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, nuoc_QG))

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

#Region "Accounting_Transit_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Nuoc_QG"

        Public Function Accounting_Transit_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Nuoc_QG(ByVal f_date As Decimal, ByVal t_date As Decimal, ByVal nuoc_QG As String) As DataSet

            ' The procedure returns these columns:
            ' ID
            ' Ngay
            ' SCT
            ' SH_EMS
            ' BC_GUI
            ' Nuoc_QG
            ' NUOC_NHAN
            ' KL_EMS
            ' Loai
            ' Van_don
            ' Cuoc
            ' Notice


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Transit_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Nuoc_QG"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@f_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, f_date))
                MyCommand.Parameters.Add(New SqlParameter("@t_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, t_date))
                MyCommand.Parameters.Add(New SqlParameter("@Nuoc_QG", SqlDbType.VarChar, 3, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, nuoc_QG))

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

#Region "Accounting_Transit_Danh_Sach_Nuoc_QG_Tu_Ngay_Den_Ngay"

        Public Function Accounting_Transit_Danh_Sach_Nuoc_QG_Tu_Ngay_Den_Ngay(ByVal f_date As Decimal, ByVal t_date As Decimal) As DataSet

            ' The procedure returns these columns:
            ' Ma_Bc
            ' Ten_Bc


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Transit_Danh_Sach_Nuoc_QG_Tu_Ngay_Den_Ngay"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@f_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, f_date))
                MyCommand.Parameters.Add(New SqlParameter("@t_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, t_date))

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

#Region "Accounting_Transit_Cap_Nhat_Notice"
        Public Function Accounting_Transit_Cap_Nhat_Notice(ByVal id As Integer, ByVal notice As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Transit_Cap_Nhat_Notice"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@ID", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, id))
                MyCommand.Parameters.Add(New SqlParameter("@NOTICE", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, notice))

                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                Return numRows
                'return the number of rows affected
            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)

            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()

            End Try
        End Function

#End Region

#Region "Accounting_Transit_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Nuoc_QG_Theo_SCT"

        Public Function Accounting_Transit_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Nuoc_QG_Theo_SCT(ByVal f_date As Decimal, ByVal t_date As Decimal, ByVal nuoc_QG As String, ByVal sct As String) As DataSet

            ' The procedure returns these columns:
            ' ID
            ' Ngay
            ' SCT
            ' SH_EMS
            ' BC_GUI
            ' Nuoc_QG
            ' NUOC_NHAN
            ' KL_EMS
            ' Loai
            ' Van_don
            ' Cuoc
            ' Notice


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Transit_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Nuoc_QG_Theo_SCT"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@f_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, f_date))
                MyCommand.Parameters.Add(New SqlParameter("@t_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, t_date))
                MyCommand.Parameters.Add(New SqlParameter("@Nuoc_QG", SqlDbType.VarChar, 3, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, nuoc_QG))
                MyCommand.Parameters.Add(New SqlParameter("@SCT", SqlDbType.VarChar, 5, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, sct))

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

#Region "Accounting_Transit_Cap_Nhat"
        Public Function Accounting_Transit_Cap_Nhat(ByVal id As Integer, ByVal ngay As DateTime, ByVal sct As String, ByVal sh_ems As String, ByVal bc_gui As String, ByVal nuoc_QG As String, ByVal nuoc_nhan As String, ByVal kl_ems As Decimal, ByVal loai As String, ByVal van_don As String, ByVal cuoc As Decimal, ByVal notice As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Transit_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@ID", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, id))
                MyCommand.Parameters.Add(New SqlParameter("@Ngay", SqlDbType.DateTime, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, ngay))
                MyCommand.Parameters.Add(New SqlParameter("@SCT", SqlDbType.VarChar, 5, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, sct))
                MyCommand.Parameters.Add(New SqlParameter("@SH_EMS", SqlDbType.VarChar, 13, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, sh_ems))
                MyCommand.Parameters.Add(New SqlParameter("@BC_GUI", SqlDbType.VarChar, 6, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, bc_gui))
                MyCommand.Parameters.Add(New SqlParameter("@Nuoc_QG", SqlDbType.VarChar, 3, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, nuoc_QG))
                MyCommand.Parameters.Add(New SqlParameter("@NUOC_NHAN", SqlDbType.VarChar, 3, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, nuoc_nhan))
                MyCommand.Parameters.Add(New SqlParameter("@KL_EMS", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 3, "", DataRowVersion.Current, kl_ems))
                MyCommand.Parameters.Add(New SqlParameter("@Loai", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, loai))
                MyCommand.Parameters.Add(New SqlParameter("@Van_don", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, van_don))
                MyCommand.Parameters.Add(New SqlParameter("@Cuoc", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, cuoc))
                MyCommand.Parameters.Add(New SqlParameter("@Notice", SqlDbType.VarChar, 20, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, notice))

                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                Return numRows
                'return the number of rows affected
            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)

            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()

            End Try
        End Function

#End Region

#Region "Accounting_Transit_Xoa"
        Public Function Accounting_Transit_Xoa(ByVal id As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Transit_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@ID", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, id))

                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                Return numRows
                'return the number of rows affected
            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)

            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()

            End Try
        End Function

#End Region

#Region "Accounting_Transit_Tong_Hop_Tu_Ngay_Den_Ngay"

        Public Function Accounting_Transit_Tong_Hop_Tu_Ngay_Den_Ngay(ByVal f_date As Decimal, ByVal t_date As Decimal) As DataSet

            ' The procedure returns these columns:
            ' Ten_Dich_Vu
            ' KL_EMS
            ' ED
            ' EM
            ' ER


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Accounting_Transit_Tong_Hop_Tu_Ngay_Den_Ngay"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@f_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, f_date))
                MyCommand.Parameters.Add(New SqlParameter("@t_date", SqlDbType.Decimal, 0, ParameterDirection.Input, True, 18, 0, "", DataRowVersion.Current, t_date))

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

#End Region

#End Region

#Region "Lay bao cao tong hop so lieu EMS theo chieu dong - Dung cho nghiep vu"
#Region "E1_San_Luong_QT"

        Public Function E1_San_Luong_QT(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal isQuoc_Te_Den As Boolean) As DataSet

            ' The procedure returns these columns:
            ' Ma_Bc
            ' Ten_Buu_Cuc
            ' So_Luong_D
            ' Khoi_Luong_D
            ' So_Luong_M
            ' Khoi_Luong_M


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_San_Luong_QT"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Tu_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Den_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Den_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@IsQuoc_Te_Den", SqlDbType.Bit, 0, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, isQuoc_Te_Den))

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

#Region "Chuyen_Thu_Den_EMS_Theo_Ngay_KT_Phan_Loai_Chuyen_Thu"
        Public Function Chuyen_Thu_Den_EMS_Theo_Ngay_KT_Phan_Loai_Chuyen_Thu(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Thu_Den_EMS_Theo_Ngay_KT_Phan_Loai_Chuyen_Thu", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet


                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                myCommand.CommandTimeout = 20000
                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Value = Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Value = Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Chuyen_Thu_Den_EMS_Theo_Ngay_KT_Phan_Loai_Chuyen_Thu")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Ban_Ke_Ke_Toan_EMS_Chieu_Den_Theo_Chuyen_Bay_Ngay_Dong"
        Public Function Ban_Ke_Ke_Toan_EMS_Chieu_Den_Theo_Chuyen_Bay_Ngay_Dong(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer) As DataSet
            Try
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tong_Hop_So_Lieu_Ems_Chieu_Den_Theo_Ten_Nuoc_Ngay_KT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                myCommand.CommandTimeout = 20000
                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Value = Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Value = Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myCommand.CommandTimeout = 0
                myAdapter.Fill(myDataSet, "Tong_Hop_So_Lieu_Ems_Chieu_Den_Theo_Ten_Nuoc_Ngay_KT")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Ban_Ke_Ke_Toan_Ems_Chieu_Den_Theo_Nuoc_Ngay_KT"
        Public Function Ban_Ke_Ke_Toan_Ems_Chieu_Den_Theo_Nuoc_Ngay_KT(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer) As DataSet
            Try
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tong_Hop_So_Lieu_Ems_Chieu_Den_Theo_Ten_Nuoc_Ngay_KT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                myCommand.CommandTimeout = 20000
                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Value = Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Value = Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myCommand.CommandTimeout = 0
                myAdapter.Fill(myDataSet, "Tong_Hop_So_Lieu_Ems_Chieu_Den_Theo_Ten_Nuoc_Ngay_KT")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Ban_Ke_Ke_Toan_Ems_Chieu_Den_Theo_Ten_Nuoc_Ngay_Dong"
        Public Function Ban_Ke_Ke_Toan_Ems_Chieu_Den_Theo_Ten_Nuoc_Ngay_Dong(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer) As DataSet
            Try
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tong_Hop_So_Lieu_Ems_Chieu_Den_Theo_Ten_Nuoc_Ngay_Dong", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                myCommand.CommandTimeout = 20000
                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Value = Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Value = Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Tong_Hop_So_Lieu_Ems_Chieu_Den_Theo_Ten_Nuoc_Ngay_KT")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#End Region


    End Class
#End Region
End Namespace

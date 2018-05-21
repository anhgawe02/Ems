
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "Ems_Shipping_Khach_Hang_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop Ems_Shipping_Khach_Hang_Chi_Tiet
    'Tuong ung voi moi truong trong bang Ems_Shipping_Khach_Hang trong co so du lieu
    '***********************************************************
    Public Class Ems_Shipping_Khach_Hang_Chi_Tiet
        Public Ma_KH As String
        Public Ten_Khach_Hang As String
        Public Ngay_Khoi_Tao As Integer
        Public Ngay_Ket_Thuc As Integer
        Public Dien_Thoai As String
        Public Fax As String
        Public Email As String
        Public Dia_Chi As String
        Public Ma_So_Thue As String
        Public Vat As Double
        Public Khach_Hang_Toan_Quoc As Boolean
        Public Truyen_Khai_Thac As Double
        Public Ma_Bc_Khai_Thac As Integer
        Public Tiem_Nang As Boolean
        Public Dai_dien As String
        Public Chuc_vu As String
        Public Tai_khoan As String
        Public Ngan_hang As String
        Public Dia_chi_IP As String
        Public User_VPN As String
        Public Pass_VPN As String
        Public Ma_BC_QL As Integer
        Public Ma_dv As String
        Public Chiet_khau As Double
    End Class
#End Region

#Region "Ems_Shipping_Khach_Hang"
    Public Class Ems_Shipping_Khach_Hang
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "Ems_Shipping_Khach_Hang_Cap_Nhat"
        Public Function Ems_Shipping_Khach_Hang_Cap_Nhat(ByVal Ma_KH As String, ByVal Ten_Khach_Hang As String, ByVal Ngay_Khoi_Tao As Integer, ByVal Ngay_Ket_Thuc As Integer, ByVal Dien_Thoai As String, ByVal Fax As String, ByVal Email As String, ByVal Dia_Chi As String, ByVal Ma_So_Thue As String, ByVal Vat As Double, ByVal Khach_Hang_Toan_Quoc As Boolean, ByVal Truyen_Khai_Thac As Double, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Tiem_Nang As Boolean, ByVal Dai_dien As String, ByVal Chuc_vu As String, ByVal Tai_khoan As String, ByVal Ngan_hang As String, ByVal Dia_chi_IP As String, ByVal User_VPN As String, ByVal Pass_VPN As String, ByVal Ma_BC_QL As Integer, ByVal Ma_dv As String, ByVal Chiet_khau As Double) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Ems_Shipping_Khach_Hang_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myEms_Shipping_Khach_Hang_Chi_Tiet As New Ems_Shipping_Khach_Hang_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Value = Ma_KH
                MyCommand.Parameters.Add(pMa_KH)

                Dim pTen_Khach_Hang As SqlParameter = New SqlParameter("@Ten_Khach_Hang", SqlDbType.NVarChar, 200)
                pTen_Khach_Hang.Value = Ten_Khach_Hang
                MyCommand.Parameters.Add(pTen_Khach_Hang)

                Dim pNgay_Khoi_Tao As SqlParameter = New SqlParameter("@Ngay_Khoi_Tao", SqlDbType.Int, 0)
                pNgay_Khoi_Tao.Value = Ngay_Khoi_Tao
                MyCommand.Parameters.Add(pNgay_Khoi_Tao)

                Dim pNgay_Ket_Thuc As SqlParameter = New SqlParameter("@Ngay_Ket_Thuc", SqlDbType.Int, 0)
                pNgay_Ket_Thuc.Value = Ngay_Ket_Thuc
                MyCommand.Parameters.Add(pNgay_Ket_Thuc)

                Dim pDien_Thoai As SqlParameter = New SqlParameter("@Dien_Thoai", SqlDbType.VarChar, 50)
                pDien_Thoai.Value = Dien_Thoai
                MyCommand.Parameters.Add(pDien_Thoai)

                Dim pFax As SqlParameter = New SqlParameter("@Fax", SqlDbType.VarChar, 50)
                pFax.Value = Fax
                MyCommand.Parameters.Add(pFax)

                Dim pEmail As SqlParameter = New SqlParameter("@Email", SqlDbType.VarChar, 50)
                pEmail.Value = Email
                MyCommand.Parameters.Add(pEmail)

                Dim pDia_Chi As SqlParameter = New SqlParameter("@Dia_Chi", SqlDbType.NVarChar, 200)
                pDia_Chi.Value = Dia_Chi
                MyCommand.Parameters.Add(pDia_Chi)

                Dim pMa_So_Thue As SqlParameter = New SqlParameter("@Ma_So_Thue", SqlDbType.VarChar, 50)
                pMa_So_Thue.Value = Ma_So_Thue
                MyCommand.Parameters.Add(pMa_So_Thue)

                Dim pVat As SqlParameter = New SqlParameter("@Vat", SqlDbType.Float, 0)
                pVat.Value = Vat
                MyCommand.Parameters.Add(pVat)

                Dim pKhach_Hang_Toan_Quoc As SqlParameter = New SqlParameter("@Khach_Hang_Toan_Quoc", SqlDbType.Bit, 0)
                pKhach_Hang_Toan_Quoc.Value = Khach_Hang_Toan_Quoc
                MyCommand.Parameters.Add(pKhach_Hang_Toan_Quoc)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Float, 0)
                pTruyen_Khai_Thac.Value = Truyen_Khai_Thac
                MyCommand.Parameters.Add(pTruyen_Khai_Thac)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pTiem_Nang As SqlParameter = New SqlParameter("@Tiem_Nang", SqlDbType.Bit, 0)
                pTiem_Nang.Value = Tiem_Nang
                MyCommand.Parameters.Add(pTiem_Nang)

                Dim pDai_dien As SqlParameter = New SqlParameter("@Dai_dien", SqlDbType.NVarChar, 50)
                pDai_dien.Value = Dai_dien
                MyCommand.Parameters.Add(pDai_dien)

                Dim pChuc_vu As SqlParameter = New SqlParameter("@Chuc_vu", SqlDbType.NVarChar, 50)
                pChuc_vu.Value = Chuc_vu
                MyCommand.Parameters.Add(pChuc_vu)

                Dim pTai_khoan As SqlParameter = New SqlParameter("@Tai_khoan", SqlDbType.VarChar, 50)
                pTai_khoan.Value = Tai_khoan
                MyCommand.Parameters.Add(pTai_khoan)

                Dim pNgan_hang As SqlParameter = New SqlParameter("@Ngan_hang", SqlDbType.NVarChar, 100)
                pNgan_hang.Value = Ngan_hang
                MyCommand.Parameters.Add(pNgan_hang)

                Dim pDia_chi_IP As SqlParameter = New SqlParameter("@Dia_chi_IP", SqlDbType.VarChar, 15)
                pDia_chi_IP.Value = Dia_chi_IP
                MyCommand.Parameters.Add(pDia_chi_IP)

                Dim pUser_VPN As SqlParameter = New SqlParameter("@User_VPN", SqlDbType.VarChar, 20)
                pUser_VPN.Value = User_VPN
                MyCommand.Parameters.Add(pUser_VPN)

                Dim pPass_VPN As SqlParameter = New SqlParameter("@Pass_VPN", SqlDbType.VarChar, 20)
                pPass_VPN.Value = Pass_VPN
                MyCommand.Parameters.Add(pPass_VPN)

                Dim pMa_BC_QL As SqlParameter = New SqlParameter("@Ma_BC_QL", SqlDbType.Int, 0)
                pMa_BC_QL.Value = Ma_BC_QL
                MyCommand.Parameters.Add(pMa_BC_QL)

                Dim pMa_dv As SqlParameter = New SqlParameter("@Ma_dv", SqlDbType.VarChar, 3)
                pMa_dv.Value = Ma_dv
                MyCommand.Parameters.Add(pMa_dv)

                Dim pChiet_khau As SqlParameter = New SqlParameter("@Chiet_khau", SqlDbType.Float, 0)
                pChiet_khau.Value = Chiet_khau
                MyCommand.Parameters.Add(pChiet_khau)


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

#Region "Ems_Shipping_Khach_Hang_Cap_Nhat_Them"
        Public Function Ems_Shipping_Khach_Hang_Cap_Nhat_Them(ByVal Ma_KH As String, ByVal Ten_Khach_Hang As String, ByVal Ngay_Khoi_Tao As Integer, ByVal Ngay_Ket_Thuc As Integer, ByVal Dien_Thoai As String, ByVal Fax As String, ByVal Email As String, ByVal Dia_Chi As String, ByVal Ma_So_Thue As String, ByVal Vat As Double, ByVal Khach_Hang_Toan_Quoc As Boolean, ByVal Truyen_Khai_Thac As Double, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Tiem_Nang As Boolean, ByVal Dai_dien As String, ByVal Chuc_vu As String, ByVal Tai_khoan As String, ByVal Ngan_hang As String, ByVal Dia_chi_IP As String, ByVal User_VPN As String, ByVal Pass_VPN As String, ByVal Ma_BC_QL As Integer, ByVal Ma_dv As String, ByVal Chiet_khau As Double) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Ems_Shipping_Khach_Hang_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myEms_Shipping_Khach_Hang_Chi_Tiet As New Ems_Shipping_Khach_Hang_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Value = Ma_KH
                MyCommand.Parameters.Add(pMa_KH)

                Dim pTen_Khach_Hang As SqlParameter = New SqlParameter("@Ten_Khach_Hang", SqlDbType.NVarChar, 200)
                pTen_Khach_Hang.Value = Ten_Khach_Hang
                MyCommand.Parameters.Add(pTen_Khach_Hang)

                Dim pNgay_Khoi_Tao As SqlParameter = New SqlParameter("@Ngay_Khoi_Tao", SqlDbType.Int, 0)
                pNgay_Khoi_Tao.Value = Ngay_Khoi_Tao
                MyCommand.Parameters.Add(pNgay_Khoi_Tao)

                Dim pNgay_Ket_Thuc As SqlParameter = New SqlParameter("@Ngay_Ket_Thuc", SqlDbType.Int, 0)
                pNgay_Ket_Thuc.Value = Ngay_Ket_Thuc
                MyCommand.Parameters.Add(pNgay_Ket_Thuc)

                Dim pDien_Thoai As SqlParameter = New SqlParameter("@Dien_Thoai", SqlDbType.VarChar, 50)
                pDien_Thoai.Value = Dien_Thoai
                MyCommand.Parameters.Add(pDien_Thoai)

                Dim pFax As SqlParameter = New SqlParameter("@Fax", SqlDbType.VarChar, 50)
                pFax.Value = Fax
                MyCommand.Parameters.Add(pFax)

                Dim pEmail As SqlParameter = New SqlParameter("@Email", SqlDbType.VarChar, 50)
                pEmail.Value = Email
                MyCommand.Parameters.Add(pEmail)

                Dim pDia_Chi As SqlParameter = New SqlParameter("@Dia_Chi", SqlDbType.NVarChar, 200)
                pDia_Chi.Value = Dia_Chi
                MyCommand.Parameters.Add(pDia_Chi)

                Dim pMa_So_Thue As SqlParameter = New SqlParameter("@Ma_So_Thue", SqlDbType.VarChar, 50)
                pMa_So_Thue.Value = Ma_So_Thue
                MyCommand.Parameters.Add(pMa_So_Thue)

                Dim pVat As SqlParameter = New SqlParameter("@Vat", SqlDbType.Float, 0)
                pVat.Value = Vat
                MyCommand.Parameters.Add(pVat)

                Dim pKhach_Hang_Toan_Quoc As SqlParameter = New SqlParameter("@Khach_Hang_Toan_Quoc", SqlDbType.Bit, 0)
                pKhach_Hang_Toan_Quoc.Value = Khach_Hang_Toan_Quoc
                MyCommand.Parameters.Add(pKhach_Hang_Toan_Quoc)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Float, 0)
                pTruyen_Khai_Thac.Value = Truyen_Khai_Thac
                MyCommand.Parameters.Add(pTruyen_Khai_Thac)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pTiem_Nang As SqlParameter = New SqlParameter("@Tiem_Nang", SqlDbType.Bit, 0)
                pTiem_Nang.Value = Tiem_Nang
                MyCommand.Parameters.Add(pTiem_Nang)

                Dim pDai_dien As SqlParameter = New SqlParameter("@Dai_dien", SqlDbType.NVarChar, 50)
                pDai_dien.Value = Dai_dien
                MyCommand.Parameters.Add(pDai_dien)

                Dim pChuc_vu As SqlParameter = New SqlParameter("@Chuc_vu", SqlDbType.NVarChar, 50)
                pChuc_vu.Value = Chuc_vu
                MyCommand.Parameters.Add(pChuc_vu)

                Dim pTai_khoan As SqlParameter = New SqlParameter("@Tai_khoan", SqlDbType.VarChar, 50)
                pTai_khoan.Value = Tai_khoan
                MyCommand.Parameters.Add(pTai_khoan)

                Dim pNgan_hang As SqlParameter = New SqlParameter("@Ngan_hang", SqlDbType.NVarChar, 100)
                pNgan_hang.Value = Ngan_hang
                MyCommand.Parameters.Add(pNgan_hang)

                Dim pDia_chi_IP As SqlParameter = New SqlParameter("@Dia_chi_IP", SqlDbType.VarChar, 15)
                pDia_chi_IP.Value = Dia_chi_IP
                MyCommand.Parameters.Add(pDia_chi_IP)

                Dim pUser_VPN As SqlParameter = New SqlParameter("@User_VPN", SqlDbType.VarChar, 20)
                pUser_VPN.Value = User_VPN
                MyCommand.Parameters.Add(pUser_VPN)

                Dim pPass_VPN As SqlParameter = New SqlParameter("@Pass_VPN", SqlDbType.VarChar, 20)
                pPass_VPN.Value = Pass_VPN
                MyCommand.Parameters.Add(pPass_VPN)

                Dim pMa_BC_QL As SqlParameter = New SqlParameter("@Ma_BC_QL", SqlDbType.Int, 0)
                pMa_BC_QL.Value = Ma_BC_QL
                MyCommand.Parameters.Add(pMa_BC_QL)

                Dim pMa_dv As SqlParameter = New SqlParameter("@Ma_dv", SqlDbType.VarChar, 3)
                pMa_dv.Value = Ma_dv
                MyCommand.Parameters.Add(pMa_dv)

                Dim pChiet_khau As SqlParameter = New SqlParameter("@Chiet_khau", SqlDbType.Float, 0)
                pChiet_khau.Value = Chiet_khau
                MyCommand.Parameters.Add(pChiet_khau)


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


#Region "Ems_Shipping_Khach_Hang_Danh_Sach"

        Public Function Ems_Shipping_Khach_Hang_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Ma_KH
            ' Ten_Khach_Hang
            ' Ngay_Khoi_Tao
            ' Ngay_Ket_Thuc
            ' Dien_Thoai
            ' Fax
            ' Email
            ' Dia_Chi
            ' Ma_So_Thue
            ' Vat
            ' Khach_Hang_Toan_Quoc
            ' Truyen_Khai_Thac
            ' Ma_Bc_Khai_Thac
            ' Tiem_Nang
            ' Dai_dien
            ' Chuc_vu
            ' Tai_khoan
            ' Ngan_hang
            ' Dia_chi_IP
            ' User_VPN
            ' Pass_VPN
            ' Ma_BC_QL
            ' Ma_dv
            ' Chiet_khau


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Ems_Shipping_Khach_Hang_Danh_Sach"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
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

#Region "Ems_Shipping_Khach_Hang_Lay"
        Public Function Ems_Shipping_Khach_Hang_Lay(ByVal Ma_KH As String) As Ems_Shipping_Khach_Hang_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Ems_Shipping_Khach_Hang_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myEms_Shipping_Khach_Hang_Chi_Tiet As New Ems_Shipping_Khach_Hang_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Value = Ma_KH
                MyCommand.Parameters.Add(pMa_KH)

                Dim pTen_Khach_Hang As SqlParameter = New SqlParameter("@Ten_Khach_Hang", SqlDbType.NVarChar, 200)
                pTen_Khach_Hang.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTen_Khach_Hang)

                Dim pNgay_Khoi_Tao As SqlParameter = New SqlParameter("@Ngay_Khoi_Tao", SqlDbType.Int, 0)
                pNgay_Khoi_Tao.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Khoi_Tao)

                Dim pNgay_Ket_Thuc As SqlParameter = New SqlParameter("@Ngay_Ket_Thuc", SqlDbType.Int, 0)
                pNgay_Ket_Thuc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Ket_Thuc)

                Dim pDien_Thoai As SqlParameter = New SqlParameter("@Dien_Thoai", SqlDbType.VarChar, 50)
                pDien_Thoai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDien_Thoai)

                Dim pFax As SqlParameter = New SqlParameter("@Fax", SqlDbType.VarChar, 50)
                pFax.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pFax)

                Dim pEmail As SqlParameter = New SqlParameter("@Email", SqlDbType.VarChar, 50)
                pEmail.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pEmail)

                Dim pDia_Chi As SqlParameter = New SqlParameter("@Dia_Chi", SqlDbType.NVarChar, 200)
                pDia_Chi.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDia_Chi)

                Dim pMa_So_Thue As SqlParameter = New SqlParameter("@Ma_So_Thue", SqlDbType.VarChar, 50)
                pMa_So_Thue.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_So_Thue)

                Dim pVat As SqlParameter = New SqlParameter("@Vat", SqlDbType.Float, 0)
                pVat.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pVat)

                Dim pKhach_Hang_Toan_Quoc As SqlParameter = New SqlParameter("@Khach_Hang_Toan_Quoc", SqlDbType.Bit, 0)
                pKhach_Hang_Toan_Quoc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pKhach_Hang_Toan_Quoc)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Float, 0)
                pTruyen_Khai_Thac.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTruyen_Khai_Thac)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pTiem_Nang As SqlParameter = New SqlParameter("@Tiem_Nang", SqlDbType.Bit, 0)
                pTiem_Nang.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTiem_Nang)

                Dim pDai_dien As SqlParameter = New SqlParameter("@Dai_dien", SqlDbType.NVarChar, 50)
                pDai_dien.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDai_dien)

                Dim pChuc_vu As SqlParameter = New SqlParameter("@Chuc_vu", SqlDbType.NVarChar, 50)
                pChuc_vu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pChuc_vu)

                Dim pTai_khoan As SqlParameter = New SqlParameter("@Tai_khoan", SqlDbType.VarChar, 50)
                pTai_khoan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTai_khoan)

                Dim pNgan_hang As SqlParameter = New SqlParameter("@Ngan_hang", SqlDbType.NVarChar, 100)
                pNgan_hang.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgan_hang)

                Dim pDia_chi_IP As SqlParameter = New SqlParameter("@Dia_chi_IP", SqlDbType.VarChar, 15)
                pDia_chi_IP.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDia_chi_IP)

                Dim pUser_VPN As SqlParameter = New SqlParameter("@User_VPN", SqlDbType.VarChar, 20)
                pUser_VPN.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pUser_VPN)

                Dim pPass_VPN As SqlParameter = New SqlParameter("@Pass_VPN", SqlDbType.VarChar, 20)
                pPass_VPN.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPass_VPN)

                Dim pMa_BC_QL As SqlParameter = New SqlParameter("@Ma_BC_QL", SqlDbType.Int, 0)
                pMa_BC_QL.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_BC_QL)

                Dim pMa_dv As SqlParameter = New SqlParameter("@Ma_dv", SqlDbType.VarChar, 3)
                pMa_dv.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_dv)

                Dim pChiet_khau As SqlParameter = New SqlParameter("@Chiet_khau", SqlDbType.Float, 0)
                pChiet_khau.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pChiet_khau)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myEms_Shipping_Khach_Hang_Chi_Tiet.Ma_KH = Ma_KH
                myEms_Shipping_Khach_Hang_Chi_Tiet.Ten_Khach_Hang = pTen_Khach_Hang.Value
                myEms_Shipping_Khach_Hang_Chi_Tiet.Ngay_Khoi_Tao = pNgay_Khoi_Tao.Value
                myEms_Shipping_Khach_Hang_Chi_Tiet.Ngay_Ket_Thuc = pNgay_Ket_Thuc.Value
                myEms_Shipping_Khach_Hang_Chi_Tiet.Dien_Thoai = pDien_Thoai.Value
                myEms_Shipping_Khach_Hang_Chi_Tiet.Fax = pFax.Value
                myEms_Shipping_Khach_Hang_Chi_Tiet.Email = pEmail.Value
                myEms_Shipping_Khach_Hang_Chi_Tiet.Dia_Chi = pDia_Chi.Value
                myEms_Shipping_Khach_Hang_Chi_Tiet.Ma_So_Thue = pMa_So_Thue.Value
                myEms_Shipping_Khach_Hang_Chi_Tiet.Vat = pVat.Value
                myEms_Shipping_Khach_Hang_Chi_Tiet.Khach_Hang_Toan_Quoc = pKhach_Hang_Toan_Quoc.Value
                myEms_Shipping_Khach_Hang_Chi_Tiet.Truyen_Khai_Thac = pTruyen_Khai_Thac.Value
                myEms_Shipping_Khach_Hang_Chi_Tiet.Ma_Bc_Khai_Thac = pMa_Bc_Khai_Thac.Value
                myEms_Shipping_Khach_Hang_Chi_Tiet.Tiem_Nang = pTiem_Nang.Value
                myEms_Shipping_Khach_Hang_Chi_Tiet.Dai_dien = pDai_dien.Value
                myEms_Shipping_Khach_Hang_Chi_Tiet.Chuc_vu = pChuc_vu.Value
                myEms_Shipping_Khach_Hang_Chi_Tiet.Tai_khoan = pTai_khoan.Value
                myEms_Shipping_Khach_Hang_Chi_Tiet.Ngan_hang = pNgan_hang.Value
                myEms_Shipping_Khach_Hang_Chi_Tiet.Dia_chi_IP = pDia_chi_IP.Value
                myEms_Shipping_Khach_Hang_Chi_Tiet.User_VPN = pUser_VPN.Value
                myEms_Shipping_Khach_Hang_Chi_Tiet.Pass_VPN = pPass_VPN.Value
                myEms_Shipping_Khach_Hang_Chi_Tiet.Ma_BC_QL = pMa_BC_QL.Value
                myEms_Shipping_Khach_Hang_Chi_Tiet.Ma_dv = pMa_dv.Value
                myEms_Shipping_Khach_Hang_Chi_Tiet.Chiet_khau = pChiet_khau.Value

                Return myEms_Shipping_Khach_Hang_Chi_Tiet
                'Return myEms_Shipping_Khach_Hang_Chi_Tiet

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

#Region "Ems_Shipping_Khach_Hang_Them"
        Public Function Ems_Shipping_Khach_Hang_Them(ByVal Ma_KH As String, ByVal Ten_Khach_Hang As String, ByVal Ngay_Khoi_Tao As Integer, ByVal Ngay_Ket_Thuc As Integer, ByVal Dien_Thoai As String, ByVal Fax As String, ByVal Email As String, ByVal Dia_Chi As String, ByVal Ma_So_Thue As String, ByVal Vat As Double, ByVal Khach_Hang_Toan_Quoc As Boolean, ByVal Truyen_Khai_Thac As Double, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Tiem_Nang As Boolean, ByVal Dai_dien As String, ByVal Chuc_vu As String, ByVal Tai_khoan As String, ByVal Ngan_hang As String, ByVal Dia_chi_IP As String, ByVal User_VPN As String, ByVal Pass_VPN As String, ByVal Ma_BC_QL As Integer, ByVal Ma_dv As String, ByVal Chiet_khau As Double) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Ems_Shipping_Khach_Hang_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myEms_Shipping_Khach_Hang_Chi_Tiet As New Ems_Shipping_Khach_Hang_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Value = Ma_KH
                MyCommand.Parameters.Add(pMa_KH)

                Dim pTen_Khach_Hang As SqlParameter = New SqlParameter("@Ten_Khach_Hang", SqlDbType.NVarChar, 200)
                pTen_Khach_Hang.Value = Ten_Khach_Hang
                MyCommand.Parameters.Add(pTen_Khach_Hang)

                Dim pNgay_Khoi_Tao As SqlParameter = New SqlParameter("@Ngay_Khoi_Tao", SqlDbType.Int, 0)
                pNgay_Khoi_Tao.Value = Ngay_Khoi_Tao
                MyCommand.Parameters.Add(pNgay_Khoi_Tao)

                Dim pNgay_Ket_Thuc As SqlParameter = New SqlParameter("@Ngay_Ket_Thuc", SqlDbType.Int, 0)
                pNgay_Ket_Thuc.Value = Ngay_Ket_Thuc
                MyCommand.Parameters.Add(pNgay_Ket_Thuc)

                Dim pDien_Thoai As SqlParameter = New SqlParameter("@Dien_Thoai", SqlDbType.VarChar, 50)
                pDien_Thoai.Value = Dien_Thoai
                MyCommand.Parameters.Add(pDien_Thoai)

                Dim pFax As SqlParameter = New SqlParameter("@Fax", SqlDbType.VarChar, 50)
                pFax.Value = Fax
                MyCommand.Parameters.Add(pFax)

                Dim pEmail As SqlParameter = New SqlParameter("@Email", SqlDbType.VarChar, 50)
                pEmail.Value = Email
                MyCommand.Parameters.Add(pEmail)

                Dim pDia_Chi As SqlParameter = New SqlParameter("@Dia_Chi", SqlDbType.NVarChar, 200)
                pDia_Chi.Value = Dia_Chi
                MyCommand.Parameters.Add(pDia_Chi)

                Dim pMa_So_Thue As SqlParameter = New SqlParameter("@Ma_So_Thue", SqlDbType.VarChar, 50)
                pMa_So_Thue.Value = Ma_So_Thue
                MyCommand.Parameters.Add(pMa_So_Thue)

                Dim pVat As SqlParameter = New SqlParameter("@Vat", SqlDbType.Float, 0)
                pVat.Value = Vat
                MyCommand.Parameters.Add(pVat)

                Dim pKhach_Hang_Toan_Quoc As SqlParameter = New SqlParameter("@Khach_Hang_Toan_Quoc", SqlDbType.Bit, 0)
                pKhach_Hang_Toan_Quoc.Value = Khach_Hang_Toan_Quoc
                MyCommand.Parameters.Add(pKhach_Hang_Toan_Quoc)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Float, 0)
                pTruyen_Khai_Thac.Value = Truyen_Khai_Thac
                MyCommand.Parameters.Add(pTruyen_Khai_Thac)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pTiem_Nang As SqlParameter = New SqlParameter("@Tiem_Nang", SqlDbType.Bit, 0)
                pTiem_Nang.Value = Tiem_Nang
                MyCommand.Parameters.Add(pTiem_Nang)

                Dim pDai_dien As SqlParameter = New SqlParameter("@Dai_dien", SqlDbType.NVarChar, 50)
                pDai_dien.Value = Dai_dien
                MyCommand.Parameters.Add(pDai_dien)

                Dim pChuc_vu As SqlParameter = New SqlParameter("@Chuc_vu", SqlDbType.NVarChar, 50)
                pChuc_vu.Value = Chuc_vu
                MyCommand.Parameters.Add(pChuc_vu)

                Dim pTai_khoan As SqlParameter = New SqlParameter("@Tai_khoan", SqlDbType.VarChar, 50)
                pTai_khoan.Value = Tai_khoan
                MyCommand.Parameters.Add(pTai_khoan)

                Dim pNgan_hang As SqlParameter = New SqlParameter("@Ngan_hang", SqlDbType.NVarChar, 100)
                pNgan_hang.Value = Ngan_hang
                MyCommand.Parameters.Add(pNgan_hang)

                Dim pDia_chi_IP As SqlParameter = New SqlParameter("@Dia_chi_IP", SqlDbType.VarChar, 15)
                pDia_chi_IP.Value = Dia_chi_IP
                MyCommand.Parameters.Add(pDia_chi_IP)

                Dim pUser_VPN As SqlParameter = New SqlParameter("@User_VPN", SqlDbType.VarChar, 20)
                pUser_VPN.Value = User_VPN
                MyCommand.Parameters.Add(pUser_VPN)

                Dim pPass_VPN As SqlParameter = New SqlParameter("@Pass_VPN", SqlDbType.VarChar, 20)
                pPass_VPN.Value = Pass_VPN
                MyCommand.Parameters.Add(pPass_VPN)

                Dim pMa_BC_QL As SqlParameter = New SqlParameter("@Ma_BC_QL", SqlDbType.Int, 0)
                pMa_BC_QL.Value = Ma_BC_QL
                MyCommand.Parameters.Add(pMa_BC_QL)

                Dim pMa_dv As SqlParameter = New SqlParameter("@Ma_dv", SqlDbType.VarChar, 3)
                pMa_dv.Value = Ma_dv
                MyCommand.Parameters.Add(pMa_dv)

                Dim pChiet_khau As SqlParameter = New SqlParameter("@Chiet_khau", SqlDbType.Float, 0)
                pChiet_khau.Value = Chiet_khau
                MyCommand.Parameters.Add(pChiet_khau)


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

#Region "Ems_Shipping_Khach_Hang_Xoa"
        Public Function Ems_Shipping_Khach_Hang_Xoa(ByVal Ma_KH As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Ems_Shipping_Khach_Hang_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myEms_Shipping_Khach_Hang_Chi_Tiet As New Ems_Shipping_Khach_Hang_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Value = Ma_KH
                MyCommand.Parameters.Add(pMa_KH)


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


    End Class
#End Region
End Namespace


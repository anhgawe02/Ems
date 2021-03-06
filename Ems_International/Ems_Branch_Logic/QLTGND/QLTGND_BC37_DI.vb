
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "QLTGND_BC37_DI_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop QLTGND_BC37_DI_Chi_Tiet
    'Tuong ung voi moi truong trong bang QLTGND_BC37_DI trong co so du lieu
    '***********************************************************
    Public Class QLTGND_BC37_DI_Chi_Tiet
        Public BC37_ID As String
        Public Id_Duong_Thu As String
        Public Id_Ca As String
        Public Ma_Bc_Khai_Thac As Integer
        Public Ma_Bc As Integer
        Public Ngay_Lap As Integer
        Public Gio_Lap As Integer
        Public Dot_Giao As Integer
        Public Ngay_Giao As Integer
        Public Gio_Giao As Integer
        Public So_Chuyen_Thu As Integer
        Public Tong_So_Tui As Integer
        Public Tong_So_BP As Integer
        Public Tong_KL As Integer
        Public Tong_KLBP As Integer
        Public Id_Nguoi_Dung As Integer
        Public Ngay_He_Thong As Integer
        Public Gio_He_Thong As Integer
        Public Da_In As Boolean
        Public Chot_SL As Boolean
        Public Truyen_Khai_Thac As Integer
        Public Trang_Thai As Integer
        Public TRANSPORT_TYPE_ID As String
        Public TRANSPORT_NUMBER As String
        Public PARTNER_ID As String
        Public MAIL_ROUTE_ID As Integer
        Public IS_TRANSITION As Boolean
    End Class
#End Region

#Region "QLTGND_BC37_DI"
    Public Class QLTGND_BC37_DI
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "QLTGND_BC37_DI_Cap_Nhat_Them"
        Public Function QLTGND_BC37_DI_Cap_Nhat_Them(ByVal BC37_ID As String, ByVal Id_Duong_Thu As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Bc As Integer, ByVal Ngay_Lap As Integer, ByVal Gio_Lap As Integer, ByVal Dot_Giao As Integer, ByVal Ngay_Giao As Integer, ByVal Gio_Giao As Integer, ByVal So_Chuyen_Thu As Integer, ByVal Tong_So_Tui As Integer, ByVal Tong_So_BP As Integer, ByVal Tong_KL As Integer, ByVal Tong_KLBP As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer, ByVal Da_In As Boolean, ByVal Chot_SL As Boolean, ByVal Truyen_Khai_Thac As Integer, ByVal Trang_Thai As Integer, ByVal TRANSPORT_TYPE_ID As String, ByVal TRANSPORT_NUMBER As String, ByVal PARTNER_ID As String, ByVal MAIL_ROUTE_ID As Integer, ByVal IS_TRANSITION As Boolean) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_BC37_DI_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_BC37_DI_Chi_Tiet As New QLTGND_BC37_DI_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pBC37_ID As SqlParameter = New SqlParameter("@BC37_ID", SqlDbType.NVarChar, 18)
                pBC37_ID.Value = BC37_ID
                MyCommand.Parameters.Add(pBC37_ID)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                MyCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 0)
                pMa_Bc.Value = Ma_Bc
                MyCommand.Parameters.Add(pMa_Bc)

                Dim pNgay_Lap As SqlParameter = New SqlParameter("@Ngay_Lap", SqlDbType.Int, 0)
                pNgay_Lap.Value = Ngay_Lap
                MyCommand.Parameters.Add(pNgay_Lap)

                Dim pGio_Lap As SqlParameter = New SqlParameter("@Gio_Lap", SqlDbType.Int, 0)
                pGio_Lap.Value = Gio_Lap
                MyCommand.Parameters.Add(pGio_Lap)

                Dim pDot_Giao As SqlParameter = New SqlParameter("@Dot_Giao", SqlDbType.Int, 0)
                pDot_Giao.Value = Dot_Giao
                MyCommand.Parameters.Add(pDot_Giao)

                Dim pNgay_Giao As SqlParameter = New SqlParameter("@Ngay_Giao", SqlDbType.Int, 0)
                pNgay_Giao.Value = Ngay_Giao
                MyCommand.Parameters.Add(pNgay_Giao)

                Dim pGio_Giao As SqlParameter = New SqlParameter("@Gio_Giao", SqlDbType.Int, 0)
                pGio_Giao.Value = Gio_Giao
                MyCommand.Parameters.Add(pGio_Giao)

                Dim pSo_Chuyen_Thu As SqlParameter = New SqlParameter("@So_Chuyen_Thu", SqlDbType.Int, 0)
                pSo_Chuyen_Thu.Value = So_Chuyen_Thu
                MyCommand.Parameters.Add(pSo_Chuyen_Thu)

                Dim pTong_So_Tui As SqlParameter = New SqlParameter("@Tong_So_Tui", SqlDbType.Int, 0)
                pTong_So_Tui.Value = Tong_So_Tui
                MyCommand.Parameters.Add(pTong_So_Tui)

                Dim pTong_So_BP As SqlParameter = New SqlParameter("@Tong_So_BP", SqlDbType.Int, 0)
                pTong_So_BP.Value = Tong_So_BP
                MyCommand.Parameters.Add(pTong_So_BP)

                Dim pTong_KL As SqlParameter = New SqlParameter("@Tong_KL", SqlDbType.Int, 0)
                pTong_KL.Value = Tong_KL
                MyCommand.Parameters.Add(pTong_KL)

                Dim pTong_KLBP As SqlParameter = New SqlParameter("@Tong_KLBP", SqlDbType.Int, 0)
                pTong_KLBP.Value = Tong_KLBP
                MyCommand.Parameters.Add(pTong_KLBP)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                MyCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Value = Ngay_He_Thong
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Value = Gio_He_Thong
                MyCommand.Parameters.Add(pGio_He_Thong)

                Dim pDa_In As SqlParameter = New SqlParameter("@Da_In", SqlDbType.Bit, 0)
                pDa_In.Value = Da_In
                MyCommand.Parameters.Add(pDa_In)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 0)
                pChot_SL.Value = Chot_SL
                MyCommand.Parameters.Add(pChot_SL)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Int, 0)
                pTruyen_Khai_Thac.Value = Truyen_Khai_Thac
                MyCommand.Parameters.Add(pTruyen_Khai_Thac)

                Dim pTrang_Thai As SqlParameter = New SqlParameter("@Trang_Thai", SqlDbType.Int, 0)
                pTrang_Thai.Value = Trang_Thai
                MyCommand.Parameters.Add(pTrang_Thai)

                Dim pTRANSPORT_TYPE_ID As SqlParameter = New SqlParameter("@TRANSPORT_TYPE_ID", SqlDbType.NVarChar, 50)
                pTRANSPORT_TYPE_ID.Value = TRANSPORT_TYPE_ID
                MyCommand.Parameters.Add(pTRANSPORT_TYPE_ID)

                Dim pTRANSPORT_NUMBER As SqlParameter = New SqlParameter("@TRANSPORT_NUMBER", SqlDbType.NVarChar, 30)
                pTRANSPORT_NUMBER.Value = TRANSPORT_NUMBER
                MyCommand.Parameters.Add(pTRANSPORT_NUMBER)

                Dim pPARTNER_ID As SqlParameter = New SqlParameter("@PARTNER_ID", SqlDbType.VarChar, 32)
                pPARTNER_ID.Value = PARTNER_ID
                MyCommand.Parameters.Add(pPARTNER_ID)

                Dim pMAIL_ROUTE_ID As SqlParameter = New SqlParameter("@MAIL_ROUTE_ID", SqlDbType.Int, 0)
                pMAIL_ROUTE_ID.Value = MAIL_ROUTE_ID
                MyCommand.Parameters.Add(pMAIL_ROUTE_ID)

                Dim pIS_TRANSITION As SqlParameter = New SqlParameter("@IS_TRANSITION", SqlDbType.Bit, 1)
                pIS_TRANSITION.Value = IS_TRANSITION
                MyCommand.Parameters.Add(pIS_TRANSITION)

                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()

                Return numRows
                'Return numRows

            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)
                Return Nothing

            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()

            End Try
        End Function

#End Region


#Region "QLTGND_BC37_DI_Danh_Sach"

        Public Function QLTGND_BC37_DI_Danh_Sach(ByVal Ma_Bc_Khai_Thac As Integer) As DataSet

            ' The procedure returns these columns:
            ' BC37_ID
            ' Id_Duong_Thu
            ' Id_Ca
            ' Ma_Bc_Khai_Thac
            ' Ma_Bc
            ' Ngay_Lap
            ' Gio_Lap
            ' Dot_Giao
            ' Ngay_Giao
            ' Gio_Giao
            ' So_Chuyen_Thu
            ' Id_Nguoi_Dung
            ' Ngay_He_Thong
            ' Gio_He_Thong
            ' Da_In
            ' Chot_SL
            ' Truyen_Khai_Thac
            ' Trang_Thai
            ' TRANSPORT_TYPE_ID
            ' TRANSPORT_NUMBER
            ' PARTNER_ID


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_BC37_DI_Danh_Sach"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)
                'Define the parameters


                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                Adapter.Fill(MyDataSet)

                Return MyDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
                Return Nothing
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                Adapter.Dispose()
            End Try
        End Function
#End Region

#Region "QLTGND_BC37_DI_Danh_Sach_Theo_Truc_Duong_Thu"

        Public Function QLTGND_BC37_DI_Danh_Sach_Theo_Truc_Duong_Thu(ByVal Id_Tuyen As Integer, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Bc As Integer, ByVal Ngay_Lap As Integer, ByVal Trang_Thai As Integer) As DataSet

            ' The procedure returns these columns:
            ' BC37_ID
            ' Id_Duong_Thu
            ' Id_Ca
            ' Ma_Bc_Khai_Thac
            ' Ngay_Lap
            ' Gio_Lap
            ' Dot_Giao
            ' Ngay_Giao
            ' Gio_Giao
            ' Id_Nguoi_Dung
            ' Ngay_He_Thong
            ' Gio_He_Thong
            ' Da_In
            ' Chot_SL
            ' Truyen_Khai_Thac
            ' TRANSPORT_TYPE_ID
            ' TRANSPORT_NUMBER
            ' PARTNER_ID


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_BC37_DI_Danh_Sach_Theo_Truc_Duong_Thu"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters
                Dim pId_Tuyen As SqlParameter = New SqlParameter("@Id_Tuyen", SqlDbType.Int, 0)
                pId_Tuyen.Value = Id_Tuyen
                MyCommand.Parameters.Add(pId_Tuyen)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 0)
                pMa_Bc.Value = Ma_Bc
                MyCommand.Parameters.Add(pMa_Bc)

                Dim pNgay_Lap As SqlParameter = New SqlParameter("@Ngay_Lap", SqlDbType.Int, 0)
                pNgay_Lap.Value = Ngay_Lap
                MyCommand.Parameters.Add(pNgay_Lap)

                Dim pTrang_Thai As SqlParameter = New SqlParameter("@Trang_Thai", SqlDbType.Int, 0)
                pTrang_Thai.Value = Trang_Thai
                MyCommand.Parameters.Add(pTrang_Thai)


                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                Adapter.Fill(MyDataSet)

                Return MyDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
                Return Nothing
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                Adapter.Dispose()
            End Try
        End Function
#End Region

#Region "QLTGND_BC37_DI_Danh_Sach_Da_Xu_Ly_Theo_Truc_Duong_Thu"

        Public Function QLTGND_BC37_DI_Danh_Sach_Da_Xu_Ly_Theo_Truc_Duong_Thu(ByVal Id_Tuyen As Integer, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Bc As Integer, ByVal Ngay_Lap As Integer, ByVal Trang_Thai As Integer) As DataSet

            ' The procedure returns these columns:
            ' BC37_ID
            ' Id_Duong_Thu
            ' Id_Ca
            ' Ma_Bc_Khai_Thac
            ' Ngay_Lap
            ' Gio_Lap
            ' Dot_Giao
            ' Ngay_Giao
            ' Gio_Giao
            ' Id_Nguoi_Dung
            ' Ngay_He_Thong
            ' Gio_He_Thong
            ' Da_In
            ' Chot_SL
            ' Truyen_Khai_Thac
            ' TRANSPORT_TYPE_ID
            ' TRANSPORT_NUMBER
            ' PARTNER_ID


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_BC37_DI_Danh_Sach_Da_Xu_Ly_Theo_Truc_Duong_Thu"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters
                Dim pId_Tuyen As SqlParameter = New SqlParameter("@Id_Tuyen", SqlDbType.Int, 0)
                pId_Tuyen.Value = Id_Tuyen
                MyCommand.Parameters.Add(pId_Tuyen)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 0)
                pMa_Bc.Value = Ma_Bc
                MyCommand.Parameters.Add(pMa_Bc)

                Dim pNgay_Lap As SqlParameter = New SqlParameter("@Ngay_Lap", SqlDbType.Int, 0)
                pNgay_Lap.Value = Ngay_Lap
                MyCommand.Parameters.Add(pNgay_Lap)

                Dim pTrang_Thai As SqlParameter = New SqlParameter("@Trang_Thai", SqlDbType.Int, 0)
                pTrang_Thai.Value = Trang_Thai
                MyCommand.Parameters.Add(pTrang_Thai)


                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                Adapter.Fill(MyDataSet)

                Return MyDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
                Return Nothing
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                Adapter.Dispose()
            End Try
        End Function
#End Region

#Region "QLTGND_BC37_DI_Danh_Sach_Theo_Truc_Duong_Thu_Dot_Giao"

        Public Function QLTGND_BC37_DI_Danh_Sach_Theo_Truc_Duong_Thu_Dot_Giao(ByVal Ma_Bc_Khai_Thac As Integer, ByVal Id_Tuyen As Integer, ByVal Ngay_Lap As Integer, ByVal Dot_Giao As Integer, ByVal Trang_Thai As Integer) As DataSet

            ' The procedure returns these columns:
            ' BC37_ID
            ' Id_Duong_Thu
            ' Id_Ca
            ' Ma_Bc_Khai_Thac
            ' Ngay_Lap
            ' Gio_Lap
            ' Dot_Giao
            ' Ngay_Giao
            ' Gio_Giao
            ' Id_Nguoi_Dung
            ' Ngay_He_Thong
            ' Gio_He_Thong
            ' Da_In
            ' Chot_SL
            ' Truyen_Khai_Thac
            ' TRANSPORT_TYPE_ID
            ' TRANSPORT_NUMBER
            ' PARTNER_ID


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_BC37_DI_Danh_Sach_Theo_Truc_Duong_Thu_Dot_Giao"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pId_Tuyen As SqlParameter = New SqlParameter("@Id_Tuyen", SqlDbType.Int, 0)
                pId_Tuyen.Value = Id_Tuyen
                MyCommand.Parameters.Add(pId_Tuyen)

                Dim pNgay_Lap As SqlParameter = New SqlParameter("@Ngay_Lap", SqlDbType.Int, 0)
                pNgay_Lap.Value = Ngay_Lap
                MyCommand.Parameters.Add(pNgay_Lap)

                Dim pDot_Giao As SqlParameter = New SqlParameter("@Dot_Giao", SqlDbType.Int, 0)
                pDot_Giao.Value = Dot_Giao
                MyCommand.Parameters.Add(pDot_Giao)

                Dim pTrang_Thai As SqlParameter = New SqlParameter("@Trang_Thai", SqlDbType.Int, 0)
                pTrang_Thai.Value = Trang_Thai
                MyCommand.Parameters.Add(pTrang_Thai)


                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                Adapter.Fill(MyDataSet)

                Return MyDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
                Return Nothing
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                Adapter.Dispose()
            End Try
        End Function
#End Region

#Region "QLTGND_BC37_DI_Danh_Sach_Theo_BC37_ID"

        Public Function QLTGND_BC37_DI_Danh_Sach_Theo_BC37_ID(ByVal BC37_ID As String, ByVal Trang_Thai As Integer, ByVal Ma_Bc_Khai_Thac As Integer) As DataSet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_BC37_DI_Danh_Sach_Theo_BC37_ID"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pBC37_ID As SqlParameter = New SqlParameter("@BC37_ID", SqlDbType.NVarChar, 18)
                pBC37_ID.Value = BC37_ID
                MyCommand.Parameters.Add(pBC37_ID)

                Dim pTrang_Thai As SqlParameter = New SqlParameter("@Trang_Thai", SqlDbType.Int, 0)
                pTrang_Thai.Value = Trang_Thai
                MyCommand.Parameters.Add(pTrang_Thai)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)



                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                Adapter.Fill(MyDataSet)

                Return MyDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
                Return Nothing
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                Adapter.Dispose()
            End Try
        End Function
#End Region

#Region "QLTGND_BC37_DI_Lay"
        Public Function QLTGND_BC37_DI_Lay(ByVal BC37_ID As String, ByVal Ma_Bc_Khai_Thac As Integer) As QLTGND_BC37_DI_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_BC37_DI_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_BC37_DI_Chi_Tiet As New QLTGND_BC37_DI_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pBC37_ID As SqlParameter = New SqlParameter("@BC37_ID", SqlDbType.NVarChar, 18)
                pBC37_ID.Value = BC37_ID
                MyCommand.Parameters.Add(pBC37_ID)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 0)
                pMa_Bc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc)

                Dim pNgay_Lap As SqlParameter = New SqlParameter("@Ngay_Lap", SqlDbType.Int, 0)
                pNgay_Lap.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Lap)

                Dim pGio_Lap As SqlParameter = New SqlParameter("@Gio_Lap", SqlDbType.Int, 0)
                pGio_Lap.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Lap)

                Dim pDot_Giao As SqlParameter = New SqlParameter("@Dot_Giao", SqlDbType.Int, 0)
                pDot_Giao.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDot_Giao)

                Dim pNgay_Giao As SqlParameter = New SqlParameter("@Ngay_Giao", SqlDbType.Int, 0)
                pNgay_Giao.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Giao)

                Dim pGio_Giao As SqlParameter = New SqlParameter("@Gio_Giao", SqlDbType.Int, 0)
                pGio_Giao.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Giao)

                Dim pSo_Chuyen_Thu As SqlParameter = New SqlParameter("@So_Chuyen_Thu", SqlDbType.Int, 0)
                pSo_Chuyen_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSo_Chuyen_Thu)

                Dim pTong_So_Tui As SqlParameter = New SqlParameter("@Tong_So_Tui", SqlDbType.Int, 0)
                pTong_So_Tui.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTong_So_Tui)

                Dim pTong_So_BP As SqlParameter = New SqlParameter("@Tong_So_BP", SqlDbType.Int, 0)
                pTong_So_BP.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTong_So_BP)

                Dim pTong_KL As SqlParameter = New SqlParameter("@Tong_KL", SqlDbType.Int, 0)
                pTong_KL.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTong_KL)

                Dim pTong_KLBP As SqlParameter = New SqlParameter("@Tong_KLBP", SqlDbType.Int, 0)
                pTong_KLBP.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTong_KLBP)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 0)
                pId_Nguoi_Dung.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_He_Thong)

                Dim pDa_In As SqlParameter = New SqlParameter("@Da_In", SqlDbType.Bit, 0)
                pDa_In.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDa_In)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 0)
                pChot_SL.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pChot_SL)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Int, 0)
                pTruyen_Khai_Thac.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTruyen_Khai_Thac)

                Dim pTrang_Thai As SqlParameter = New SqlParameter("@Trang_Thai", SqlDbType.Int, 0)
                pTrang_Thai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTrang_Thai)

                Dim pTRANSPORT_TYPE_ID As SqlParameter = New SqlParameter("@TRANSPORT_TYPE_ID", SqlDbType.NVarChar, 50)
                pTRANSPORT_TYPE_ID.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTRANSPORT_TYPE_ID)

                Dim pTRANSPORT_NUMBER As SqlParameter = New SqlParameter("@TRANSPORT_NUMBER", SqlDbType.NVarChar, 30)
                pTRANSPORT_NUMBER.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTRANSPORT_NUMBER)

                Dim pPARTNER_ID As SqlParameter = New SqlParameter("@PARTNER_ID", SqlDbType.VarChar, 32)
                pPARTNER_ID.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPARTNER_ID)

                Dim pMAIL_ROUTE_ID As SqlParameter = New SqlParameter("@MAIL_ROUTE_ID", SqlDbType.Int, 0)
                pMAIL_ROUTE_ID.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMAIL_ROUTE_ID)

                Dim pIS_TRANSITION As SqlParameter = New SqlParameter("@IS_TRANSITION", SqlDbType.Bit, 1)
                pIS_TRANSITION.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pIS_TRANSITION)

                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myQLTGND_BC37_DI_Chi_Tiet.BC37_ID = BC37_ID
                myQLTGND_BC37_DI_Chi_Tiet.Ma_Bc_Khai_Thac = Ma_Bc_Khai_Thac
                myQLTGND_BC37_DI_Chi_Tiet.Id_Duong_Thu = pId_Duong_Thu.Value
                myQLTGND_BC37_DI_Chi_Tiet.Id_Ca = pId_Ca.Value
                myQLTGND_BC37_DI_Chi_Tiet.Ma_Bc_Khai_Thac = Ma_Bc_Khai_Thac
                myQLTGND_BC37_DI_Chi_Tiet.Ma_Bc = pMa_Bc.Value
                myQLTGND_BC37_DI_Chi_Tiet.Ngay_Lap = pNgay_Lap.Value
                myQLTGND_BC37_DI_Chi_Tiet.Gio_Lap = pGio_Lap.Value
                myQLTGND_BC37_DI_Chi_Tiet.Dot_Giao = pDot_Giao.Value
                myQLTGND_BC37_DI_Chi_Tiet.Ngay_Giao = pNgay_Giao.Value
                myQLTGND_BC37_DI_Chi_Tiet.Gio_Giao = pGio_Giao.Value
                myQLTGND_BC37_DI_Chi_Tiet.So_Chuyen_Thu = pSo_Chuyen_Thu.Value
                myQLTGND_BC37_DI_Chi_Tiet.Id_Nguoi_Dung = pId_Nguoi_Dung.Value
                myQLTGND_BC37_DI_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myQLTGND_BC37_DI_Chi_Tiet.Gio_He_Thong = pGio_He_Thong.Value
                myQLTGND_BC37_DI_Chi_Tiet.Da_In = pDa_In.Value
                myQLTGND_BC37_DI_Chi_Tiet.Chot_SL = pChot_SL.Value
                myQLTGND_BC37_DI_Chi_Tiet.Tong_So_Tui = pTong_So_Tui.Value
                myQLTGND_BC37_DI_Chi_Tiet.Truyen_Khai_Thac = pTruyen_Khai_Thac.Value
                myQLTGND_BC37_DI_Chi_Tiet.Trang_Thai = pTrang_Thai.Value
                myQLTGND_BC37_DI_Chi_Tiet.TRANSPORT_TYPE_ID = pTRANSPORT_TYPE_ID.Value
                myQLTGND_BC37_DI_Chi_Tiet.TRANSPORT_NUMBER = pTRANSPORT_NUMBER.Value
                myQLTGND_BC37_DI_Chi_Tiet.PARTNER_ID = pPARTNER_ID.Value
                myQLTGND_BC37_DI_Chi_Tiet.MAIL_ROUTE_ID = pMAIL_ROUTE_ID.Value
                myQLTGND_BC37_DI_Chi_Tiet.IS_TRANSITION = pIS_TRANSITION.Value

                Return myQLTGND_BC37_DI_Chi_Tiet
                'Return myQLTGND_BC37_DI_Chi_Tiet

            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)
                Return Nothing

            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()

            End Try
        End Function

#End Region

#Region "QLTGND_BC37_DI_Xoa"
        Public Function QLTGND_BC37_DI_Xoa(ByVal BC37_ID As String, ByVal Ma_Bc_Khai_Thac As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_BC37_DI_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_BC37_DI_Chi_Tiet As New QLTGND_BC37_DI_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pBC37_ID As SqlParameter = New SqlParameter("@BC37_ID", SqlDbType.NVarChar, 18)
                pBC37_ID.Value = BC37_ID
                MyCommand.Parameters.Add(pBC37_ID)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()

                Return numRows
                'Return numRows

            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)
                Return Nothing

            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()

            End Try
        End Function

#End Region

#Region "Kiểm tra sự tồn tại của Túi"
        ' Ngày tạo: 27/6/08
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Kiểm tra sự tồn tại Id_Duong_Thu
        ' Input: Id_Duong_Thu
        ' Output: count(*)
        Public Function BC_37_Di_Kiem_Tra_Tui(ByVal BC37_ID As String, ByVal Ma_Bc_Khai_Thac As Integer) As Boolean
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim ReturnValue As Boolean

            myCommand = New SqlCommand("Select count(*) from QLTGND_POSTBAG_DI where (ID_BC37= '" & BC37_ID & "') " & " And Ma_Bc_Khai_Thac = " & Ma_Bc_Khai_Thac, myConnection)

            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
            myConnection.Close()
            myConnection.Dispose()

            Return ReturnValue
        End Function
#End Region

#Region "QLTGND_BC37_DI_Cap_Nhat_Lai_Trang_Thai_Truyen"
        Public Function QLTGND_BC37_DI_Cap_Nhat_Lai_Trang_Thai_Truyen(ByVal BC37_ID As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Trang_Thai As Integer) As Boolean
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim strSQL As String
            Try
                strSQL = "Update QLTGND_BC37_DI Set Trang_Thai = " & Trang_Thai.ToString & " Where BC37_ID = '" & BC37_ID & "' AND Ma_Bc_Khai_Thac = " & Ma_Bc_Khai_Thac.ToString
                myCommand = New SqlCommand(strSQL, myConnection)

                myConnection.Open()
                myCommand.CommandType = CommandType.Text
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Return True
            Catch ex As Exception
                myConnection.Close()
                myConnection.Dispose()
                Return False
            End Try
        End Function
#End Region
#Region "Lay_Dot_Giao_Tu_Dong"
        Public Function Lay_Dot_Giao_Tu_Dong(ByVal Id_Duong_Thu As String, ByVal Ngay_Lap As Integer) As Integer
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("QLTGND_Lay_Dot_Giao_Tu_Dong", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 15)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pNgay_Lap As SqlParameter = New SqlParameter("@Ngay_Lap", SqlDbType.Int, 4)
                pNgay_Lap.Value = Ngay_Lap
                myCommand.Parameters.Add(pNgay_Lap)

                Dim pDot_Giao As SqlParameter = New SqlParameter("@Dot_Giao", SqlDbType.Float)
                pDot_Giao.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDot_Giao)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()

                Return pDot_Giao.Value
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Kiem_Tra_Chuyen_Thu_Da_Lap_BC37"
        Public Function Kiem_Tra_Chuyen_Thu_Da_Lap_BC37(ByVal Ngay As Integer, ByVal Id_Duong_Thu As String, ByVal So_Chuyen_Thu As Integer) As String
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim ReturnValue As String

            myCommand = New SqlCommand("Select BC37_ID from QLTGND_BC37_Di where Ngay_Lap = " & Ngay & " AND Id_Duong_Thu = '" & Id_Duong_Thu & "' AND So_Chuyen_Thu = '" & So_Chuyen_Thu & "'", myConnection)

            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar = "", "", myCommand.ExecuteScalar)
            myConnection.Close()
            myConnection.Dispose()

            Return ReturnValue
        End Function
#End Region
#Region "Lay_Id_Bc37_Theo_Ngay_Id_Duong_Thu_So_Chuyen_Thu"
        Public Function Lay_Id_Bc37_Theo_Ngay_Id_Duong_Thu_So_Chuyen_Thu(ByVal Ngay As Integer, ByVal Id_Duong_Thu As String, ByVal So_Chuyen_Thu As Integer) As String
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim ReturnValue As String

            myCommand = New SqlCommand("Select BC37_ID from QLTGND_BC37_Di where Ngay_Lap = " & Ngay & " AND Id_Duong_Thu = '" & Id_Duong_Thu & "' AND So_Chuyen_Thu = '" & So_Chuyen_Thu & "'", myConnection)

            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, "", myCommand.ExecuteScalar)

            myConnection.Close()
            myConnection.Dispose()

            Return ReturnValue
        End Function
#End Region
    End Class
#End Region
End Namespace


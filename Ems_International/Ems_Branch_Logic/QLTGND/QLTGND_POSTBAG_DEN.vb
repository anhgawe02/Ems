
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "QLTGND_POSTBAG_DEN_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop QLTGND_POSTBAG_DEN_Chi_Tiet
    'Tuong ung voi moi truong trong bang QLTGND_POSTBAG_DEN trong co so du lieu
    '***********************************************************
    Public Class QLTGND_POSTBAG_DEN_Chi_Tiet
        Public Id_E2 As String
        Public Id_Duong_Thu As String
        Public Id_Chuyen_Thu As String
        Public Id_Ca As String
        Public Ma_Bc_Khai_Thac As Integer
        Public Ma_Bc As Integer
        Public Ngay_Dong As Integer
        Public Gio_Dong As Integer
        Public Ngay_Nhan As Integer
        Public Gio_Nhan As Integer
        Public So_Chuyen_Thu As Integer
        Public Tui_So As Integer
        Public Tui_F As Boolean
        Public Tong_So_BP As Integer
        Public Khoi_Luong_Vo_Tui As Integer
        Public Khoi_Luong_BP As Integer
        Public Tong_Cuoc_COD As Integer
        Public Tong_Cuoc_DV As Integer
        Public Tong_Cuoc_Chinh As Integer
        Public HH_Phat_Hanh As Integer
        Public HH_Phat_Tra As Integer
        Public Truyen_Khai_Thac As Boolean
        Public Truyen_Doi_Soat As Boolean
        Public Ngay_He_Thong As Integer
        Public Chot_SL As Boolean
        Public Id_Tui_Thu As String
        Public Id_BC37 As String
        Public Trang_Thai As Integer
        Public IS_TRANSITION As Boolean
    End Class
#End Region

#Region "QLTGND_POSTBAG_DEN"
    Public Class QLTGND_POSTBAG_DEN
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "QLTGND_POSTBAG_DEN_Cap_Nhat_Them"
        Public Function QLTGND_POSTBAG_DEN_Cap_Nhat_Them(ByVal Id_E2 As String, ByVal Id_Duong_Thu As String, ByVal Id_Chuyen_Thu As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Bc As Integer, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal So_Chuyen_Thu As Integer, ByVal Tui_So As Integer, ByVal Tui_F As Boolean, ByVal Tong_So_BP As Integer, ByVal Khoi_Luong_Vo_Tui As Integer, ByVal Khoi_Luong_BP As Integer, ByVal Tong_Cuoc_COD As Integer, ByVal Tong_Cuoc_DV As Integer, ByVal Tong_Cuoc_Chinh As Integer, ByVal HH_Phat_Hanh As Integer, ByVal HH_Phat_Tra As Integer, ByVal Truyen_Khai_Thac As Boolean, ByVal Truyen_Doi_Soat As Boolean, ByVal Ngay_He_Thong As Integer, ByVal Chot_SL As Boolean, ByVal Id_Tui_Thu As String, ByVal Id_BC37 As String, ByVal Trang_Thai As Integer, ByVal IS_TRANSITION As Boolean) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_POSTBAG_DEN_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_POSTBAG_DEN_Chi_Tiet As New QLTGND_POSTBAG_DEN_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                MyCommand.Parameters.Add(pId_E2)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                MyCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                MyCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 0)
                pMa_Bc.Value = Ma_Bc
                MyCommand.Parameters.Add(pMa_Bc)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 0)
                pNgay_Dong.Value = Ngay_Dong
                MyCommand.Parameters.Add(pNgay_Dong)

                Dim pGio_Dong As SqlParameter = New SqlParameter("@Gio_Dong", SqlDbType.Int, 0)
                pGio_Dong.Value = Gio_Dong
                MyCommand.Parameters.Add(pGio_Dong)

                Dim pNgay_Nhan As SqlParameter = New SqlParameter("@Ngay_Nhan", SqlDbType.Int, 0)
                pNgay_Nhan.Value = Ngay_Nhan
                MyCommand.Parameters.Add(pNgay_Nhan)

                Dim pGio_Nhan As SqlParameter = New SqlParameter("@Gio_Nhan", SqlDbType.Int, 0)
                pGio_Nhan.Value = Gio_Nhan
                MyCommand.Parameters.Add(pGio_Nhan)

                Dim pSo_Chuyen_Thu As SqlParameter = New SqlParameter("@So_Chuyen_Thu", SqlDbType.Int, 0)
                pSo_Chuyen_Thu.Value = So_Chuyen_Thu
                MyCommand.Parameters.Add(pSo_Chuyen_Thu)

                Dim pTui_So As SqlParameter = New SqlParameter("@Tui_So", SqlDbType.Int, 0)
                pTui_So.Value = Tui_So
                MyCommand.Parameters.Add(pTui_So)

                Dim pTui_F As SqlParameter = New SqlParameter("@Tui_F", SqlDbType.Bit, 0)
                pTui_F.Value = Tui_F
                MyCommand.Parameters.Add(pTui_F)

                Dim pTong_So_BP As SqlParameter = New SqlParameter("@Tong_So_BP", SqlDbType.Int, 0)
                pTong_So_BP.Value = Tong_So_BP
                MyCommand.Parameters.Add(pTong_So_BP)

                Dim pKhoi_Luong_Vo_Tui As SqlParameter = New SqlParameter("@Khoi_Luong_Vo_Tui", SqlDbType.Int, 0)
                pKhoi_Luong_Vo_Tui.Value = Khoi_Luong_Vo_Tui
                MyCommand.Parameters.Add(pKhoi_Luong_Vo_Tui)

                Dim pKhoi_Luong_BP As SqlParameter = New SqlParameter("@Khoi_Luong_BP", SqlDbType.Int, 0)
                pKhoi_Luong_BP.Value = Khoi_Luong_BP
                MyCommand.Parameters.Add(pKhoi_Luong_BP)

                Dim pTong_Cuoc_COD As SqlParameter = New SqlParameter("@Tong_Cuoc_COD", SqlDbType.Int, 0)
                pTong_Cuoc_COD.Value = Tong_Cuoc_COD
                MyCommand.Parameters.Add(pTong_Cuoc_COD)

                Dim pTong_Cuoc_DV As SqlParameter = New SqlParameter("@Tong_Cuoc_DV", SqlDbType.Int, 0)
                pTong_Cuoc_DV.Value = Tong_Cuoc_DV
                MyCommand.Parameters.Add(pTong_Cuoc_DV)

                Dim pTong_Cuoc_Chinh As SqlParameter = New SqlParameter("@Tong_Cuoc_Chinh", SqlDbType.Int, 0)
                pTong_Cuoc_Chinh.Value = Tong_Cuoc_Chinh
                MyCommand.Parameters.Add(pTong_Cuoc_Chinh)

                Dim pHH_Phat_Hanh As SqlParameter = New SqlParameter("@HH_Phat_Hanh", SqlDbType.Int, 0)
                pHH_Phat_Hanh.Value = HH_Phat_Hanh
                MyCommand.Parameters.Add(pHH_Phat_Hanh)

                Dim pHH_Phat_Tra As SqlParameter = New SqlParameter("@HH_Phat_Tra", SqlDbType.Int, 0)
                pHH_Phat_Tra.Value = HH_Phat_Tra
                MyCommand.Parameters.Add(pHH_Phat_Tra)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 0)
                pTruyen_Khai_Thac.Value = Truyen_Khai_Thac
                MyCommand.Parameters.Add(pTruyen_Khai_Thac)

                Dim pTruyen_Doi_Soat As SqlParameter = New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 0)
                pTruyen_Doi_Soat.Value = Truyen_Doi_Soat
                MyCommand.Parameters.Add(pTruyen_Doi_Soat)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Value = Ngay_He_Thong
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 0)
                pChot_SL.Value = Chot_SL
                MyCommand.Parameters.Add(pChot_SL)

                Dim pId_Tui_Thu As SqlParameter = New SqlParameter("@Id_Tui_Thu", SqlDbType.VarChar, 39)
                pId_Tui_Thu.Value = Id_Tui_Thu
                MyCommand.Parameters.Add(pId_Tui_Thu)

                Dim pId_BC37 As SqlParameter = New SqlParameter("@Id_BC37", SqlDbType.VarChar, 18)
                pId_BC37.Value = Id_BC37
                MyCommand.Parameters.Add(pId_BC37)

                Dim pTrang_Thai As SqlParameter = New SqlParameter("@Trang_Thai", SqlDbType.Int, 0)
                pTrang_Thai.Value = Trang_Thai
                MyCommand.Parameters.Add(pTrang_Thai)

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


#Region "QLTGND_POSTBAG_DEN_Danh_Sach"

        Public Function QLTGND_POSTBAG_DEN_Danh_Sach(ByVal Ma_Bc_Khai_Thac As Integer) As DataSet

            ' The procedure returns these columns:
            ' Id_E2
            ' Id_Duong_Thu
            ' Id_Chuyen_Thu
            ' Id_Ca
            ' Ma_Bc_Khai_Thac
            ' Ngay_Dong
            ' Gio_Dong
            ' Ngay_Nhan
            ' Gio_Nhan
            ' So_Chuyen_Thu
            ' Tui_So
            ' Tui_F
            ' Tong_So_BP
            ' Khoi_Luong_Vo_Tui
            ' Khoi_Luong_BP
            ' Tong_Cuoc_COD
            ' Tong_Cuoc_DV
            ' Tong_Cuoc_Chinh
            ' HH_Phat_Hanh
            ' HH_Phat_Tra
            ' Truyen_Khai_Thac
            ' Truyen_Doi_Soat
            ' Ngay_He_Thong
            ' Chot_SL
            ' Id_Tui_Thu
            ' Id_BC37


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_POSTBAG_DEN_Danh_Sach"
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

#Region "QLTGND_POSTBAG_DEN_Ban_Ke_BC37"

        Public Function QLTGND_POSTBAG_DEN_Ban_Ke_BC37(ByVal BC37_ID As String, ByVal Trang_Thai As Integer, ByVal Ma_Bc_Khai_Thac As Integer) As DataSet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_POSTBAG_DEN_Ban_Ke_BC37"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000

            Dim pBC37_ID As SqlParameter = New SqlParameter("@BC37_ID", SqlDbType.VarChar, 18)
            pBC37_ID.Value = BC37_ID
            MyCommand.Parameters.Add(pBC37_ID)

            Dim pTrang_Thai As SqlParameter = New SqlParameter("@Trang_Thai", SqlDbType.Int, 0)
            pTrang_Thai.Value = Trang_Thai
            MyCommand.Parameters.Add(pTrang_Thai)

            Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
            pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
            MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)


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
                Return Nothing
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                Adapter.Dispose()
            End Try
        End Function
#End Region

#Region "QLTGND_POSTBAG_DEN_Danh_Sach_Theo_BC37_ID_Trang_Thai"

        Public Function QLTGND_POSTBAG_DEN_Danh_Sach_Theo_BC37_ID_Trang_Thai(ByVal BC37_ID As String, ByVal Trang_Thai As Integer, ByVal Ma_Bc_Khai_Thac As Integer) As DataSet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_POSTBAG_DEN_Danh_Sach_Theo_BC37_ID_Trang_Thai"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000

            Dim pBC37_ID As SqlParameter = New SqlParameter("@BC37_ID", SqlDbType.VarChar, 18)
            pBC37_ID.Value = BC37_ID
            MyCommand.Parameters.Add(pBC37_ID)

            Dim pTrang_Thai As SqlParameter = New SqlParameter("@Trang_Thai", SqlDbType.Int, 0)
            pTrang_Thai.Value = Trang_Thai
            MyCommand.Parameters.Add(pTrang_Thai)

            Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
            pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
            MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

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
                Return Nothing
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                Adapter.Dispose()
            End Try
        End Function
#End Region

#Region "QLTGND_POSTBAG_DEN_Danh_Sach_Theo_BC37_ID_Den"

        Public Function QLTGND_POSTBAG_DEN_Danh_Sach_Theo_BC37_ID_Den(ByVal BC37_ID As String, ByVal Ma_Bc_Khai_Thac As Integer) As DataSet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_POSTBAG_DEN_Danh_Sach_Theo_BC37_ID_Den"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000

            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters
                Dim pBC37_ID As SqlParameter = New SqlParameter("@BC37_ID", SqlDbType.VarChar, 18)
                pBC37_ID.Value = BC37_ID
                MyCommand.Parameters.Add(pBC37_ID)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
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

#Region "QLTGND_POSTBAG_DEN_Danh_Sach_Theo_BC37_ID_Den_Qua_Giang"

        Public Function QLTGND_POSTBAG_DEN_Danh_Sach_Theo_BC37_ID_Den_Qua_Giang(ByVal BC37_ID As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal IS_TRANSITION As Boolean) As DataSet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_POSTBAG_DEN_Danh_Sach_Theo_BC37_ID_Den_Qua_Giang"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000

            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters
                Dim pBC37_ID As SqlParameter = New SqlParameter("@BC37_ID", SqlDbType.VarChar, 18)
                pBC37_ID.Value = BC37_ID
                MyCommand.Parameters.Add(pBC37_ID)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pIS_TRANSITION As SqlParameter = New SqlParameter("@IS_TRANSITION", SqlDbType.Bit, 1)
                pIS_TRANSITION.Value = IS_TRANSITION
                MyCommand.Parameters.Add(pIS_TRANSITION)


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

#Region "QLTGND_POSTBAG_DEN_Danh_Sach_Theo_Id_E2"

        Public Function QLTGND_POSTBAG_DEN_Danh_Sach_Theo_Id_E2(ByVal Id_E2 As String, ByVal Trang_Thai As Integer) As DataSet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_POSTBAG_DEN_Danh_Sach_Theo_Id_E2"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000

            Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
            pId_E2.Value = Id_E2
            MyCommand.Parameters.Add(pId_E2)

            Dim pTrang_Thai As SqlParameter = New SqlParameter("@Trang_Thai", SqlDbType.Int, 0)
            pTrang_Thai.Value = Trang_Thai
            MyCommand.Parameters.Add(pTrang_Thai)

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
                Return Nothing
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                Adapter.Dispose()
            End Try
        End Function
#End Region

#Region "QLTGND_POSTBAG_DEN_Danh_Sach_Theo_Id_Tui_Thu"

        Public Function QLTGND_POSTBAG_DEN_Danh_Sach_Theo_Id_Tui_Thu(ByVal Id_Tui_Thu As String, ByVal Ma_Bc_Khai_Thac As Integer) As DataSet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_POSTBAG_DEN_Danh_Sach_Theo_Id_Tui_Thu"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000

            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try

                'Define the parameters
                Dim pId_Tui_Thu As SqlParameter = New SqlParameter("@Id_Tui_Thu", SqlDbType.VarChar, 39)
                pId_Tui_Thu.Value = Id_Tui_Thu
                MyCommand.Parameters.Add(pId_Tui_Thu)

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

#Region "QLTGND_POSTBAG_DEN_Danh_Sach_Theo_Id_Tui_Thu_Qua_Giang"

        Public Function QLTGND_POSTBAG_DEN_Danh_Sach_Theo_Id_Tui_Thu_Qua_Giang(ByVal Id_Tui_Thu As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal IS_TRANSITION As Boolean) As DataSet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_POSTBAG_DEN_Danh_Sach_Theo_Id_Tui_Thu_Qua_Giang"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000

            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try

                'Define the parameters
                Dim pId_Tui_Thu As SqlParameter = New SqlParameter("@Id_Tui_Thu", SqlDbType.VarChar, 39)
                pId_Tui_Thu.Value = Id_Tui_Thu
                MyCommand.Parameters.Add(pId_Tui_Thu)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pIS_TRANSITION As SqlParameter = New SqlParameter("@IS_TRANSITION", SqlDbType.Bit, 1)
                pIS_TRANSITION.Value = IS_TRANSITION
                MyCommand.Parameters.Add(pIS_TRANSITION)

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

#Region "QLTGND_POSTBAG_DEN_Lay"
        Public Function QLTGND_POSTBAG_DEN_Lay(ByVal Id_E2 As String) As QLTGND_POSTBAG_DEN_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_POSTBAG_DEN_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_POSTBAG_DEN_Chi_Tiet As New QLTGND_POSTBAG_DEN_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                MyCommand.Parameters.Add(pId_E2)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 0)
                pMa_Bc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 0)
                pNgay_Dong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Dong)

                Dim pGio_Dong As SqlParameter = New SqlParameter("@Gio_Dong", SqlDbType.Int, 0)
                pGio_Dong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Dong)

                Dim pNgay_Nhan As SqlParameter = New SqlParameter("@Ngay_Nhan", SqlDbType.Int, 0)
                pNgay_Nhan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Nhan)

                Dim pGio_Nhan As SqlParameter = New SqlParameter("@Gio_Nhan", SqlDbType.Int, 0)
                pGio_Nhan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Nhan)

                Dim pSo_Chuyen_Thu As SqlParameter = New SqlParameter("@So_Chuyen_Thu", SqlDbType.Int, 0)
                pSo_Chuyen_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSo_Chuyen_Thu)

                Dim pTui_So As SqlParameter = New SqlParameter("@Tui_So", SqlDbType.Int, 0)
                pTui_So.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTui_So)

                Dim pTui_F As SqlParameter = New SqlParameter("@Tui_F", SqlDbType.Bit, 0)
                pTui_F.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTui_F)

                Dim pTong_So_BP As SqlParameter = New SqlParameter("@Tong_So_BP", SqlDbType.Int, 0)
                pTong_So_BP.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTong_So_BP)

                Dim pKhoi_Luong_Vo_Tui As SqlParameter = New SqlParameter("@Khoi_Luong_Vo_Tui", SqlDbType.Int, 0)
                pKhoi_Luong_Vo_Tui.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pKhoi_Luong_Vo_Tui)

                Dim pKhoi_Luong_BP As SqlParameter = New SqlParameter("@Khoi_Luong_BP", SqlDbType.Int, 0)
                pKhoi_Luong_BP.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pKhoi_Luong_BP)

                Dim pTong_Cuoc_COD As SqlParameter = New SqlParameter("@Tong_Cuoc_COD", SqlDbType.Int, 0)
                pTong_Cuoc_COD.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTong_Cuoc_COD)

                Dim pTong_Cuoc_DV As SqlParameter = New SqlParameter("@Tong_Cuoc_DV", SqlDbType.Int, 0)
                pTong_Cuoc_DV.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTong_Cuoc_DV)

                Dim pTong_Cuoc_Chinh As SqlParameter = New SqlParameter("@Tong_Cuoc_Chinh", SqlDbType.Int, 0)
                pTong_Cuoc_Chinh.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTong_Cuoc_Chinh)

                Dim pHH_Phat_Hanh As SqlParameter = New SqlParameter("@HH_Phat_Hanh", SqlDbType.Int, 0)
                pHH_Phat_Hanh.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pHH_Phat_Hanh)

                Dim pHH_Phat_Tra As SqlParameter = New SqlParameter("@HH_Phat_Tra", SqlDbType.Int, 0)
                pHH_Phat_Tra.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pHH_Phat_Tra)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 0)
                pTruyen_Khai_Thac.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTruyen_Khai_Thac)

                Dim pTruyen_Doi_Soat As SqlParameter = New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 0)
                pTruyen_Doi_Soat.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTruyen_Doi_Soat)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 0)
                pChot_SL.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pChot_SL)

                Dim pId_Tui_Thu As SqlParameter = New SqlParameter("@Id_Tui_Thu", SqlDbType.VarChar, 39)
                pId_Tui_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Tui_Thu)

                Dim pId_BC37 As SqlParameter = New SqlParameter("@Id_BC37", SqlDbType.VarChar, 18)
                pId_BC37.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_BC37)

                Dim pTrang_Thai As SqlParameter = New SqlParameter("@Trang_Thai", SqlDbType.Int, 0)
                pTrang_Thai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTrang_Thai)

                Dim pIS_TRANSITION As SqlParameter = New SqlParameter("@IS_TRANSITION", SqlDbType.Bit, 1)
                pIS_TRANSITION.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pIS_TRANSITION)

                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myQLTGND_POSTBAG_DEN_Chi_Tiet.Id_E2 = Id_E2
                myQLTGND_POSTBAG_DEN_Chi_Tiet.Id_Duong_Thu = pId_Duong_Thu.Value
                myQLTGND_POSTBAG_DEN_Chi_Tiet.Id_Chuyen_Thu = pId_Chuyen_Thu.Value
                myQLTGND_POSTBAG_DEN_Chi_Tiet.Id_Ca = pId_Ca.Value
                myQLTGND_POSTBAG_DEN_Chi_Tiet.Ma_Bc_Khai_Thac = pMa_Bc_Khai_Thac.Value
                myQLTGND_POSTBAG_DEN_Chi_Tiet.Ma_Bc = pMa_Bc.Value
                myQLTGND_POSTBAG_DEN_Chi_Tiet.Ngay_Dong = pNgay_Dong.Value
                myQLTGND_POSTBAG_DEN_Chi_Tiet.Gio_Dong = pGio_Dong.Value
                myQLTGND_POSTBAG_DEN_Chi_Tiet.Ngay_Nhan = pNgay_Nhan.Value
                myQLTGND_POSTBAG_DEN_Chi_Tiet.Gio_Nhan = pGio_Nhan.Value
                myQLTGND_POSTBAG_DEN_Chi_Tiet.So_Chuyen_Thu = pSo_Chuyen_Thu.Value
                myQLTGND_POSTBAG_DEN_Chi_Tiet.Tui_So = pTui_So.Value
                myQLTGND_POSTBAG_DEN_Chi_Tiet.Tui_F = pTui_F.Value
                myQLTGND_POSTBAG_DEN_Chi_Tiet.Tong_So_BP = pTong_So_BP.Value
                myQLTGND_POSTBAG_DEN_Chi_Tiet.Khoi_Luong_Vo_Tui = pKhoi_Luong_Vo_Tui.Value
                myQLTGND_POSTBAG_DEN_Chi_Tiet.Khoi_Luong_BP = pKhoi_Luong_BP.Value
                myQLTGND_POSTBAG_DEN_Chi_Tiet.Tong_Cuoc_COD = pTong_Cuoc_COD.Value
                myQLTGND_POSTBAG_DEN_Chi_Tiet.Tong_Cuoc_DV = pTong_Cuoc_DV.Value
                myQLTGND_POSTBAG_DEN_Chi_Tiet.Tong_Cuoc_Chinh = pTong_Cuoc_Chinh.Value
                myQLTGND_POSTBAG_DEN_Chi_Tiet.HH_Phat_Hanh = pHH_Phat_Hanh.Value
                myQLTGND_POSTBAG_DEN_Chi_Tiet.HH_Phat_Tra = pHH_Phat_Tra.Value
                myQLTGND_POSTBAG_DEN_Chi_Tiet.Truyen_Khai_Thac = pTruyen_Khai_Thac.Value
                myQLTGND_POSTBAG_DEN_Chi_Tiet.Truyen_Doi_Soat = pTruyen_Doi_Soat.Value
                myQLTGND_POSTBAG_DEN_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myQLTGND_POSTBAG_DEN_Chi_Tiet.Chot_SL = pChot_SL.Value
                myQLTGND_POSTBAG_DEN_Chi_Tiet.Id_Tui_Thu = pId_Tui_Thu.Value
                myQLTGND_POSTBAG_DEN_Chi_Tiet.Id_BC37 = pId_BC37.Value
                myQLTGND_POSTBAG_DEN_Chi_Tiet.Trang_Thai = pTrang_Thai.Value
                myQLTGND_POSTBAG_DEN_Chi_Tiet.IS_TRANSITION = pIS_TRANSITION.Value

                Return myQLTGND_POSTBAG_DEN_Chi_Tiet
                'Return myQLTGND_POSTBAG_DEN_Chi_Tiet

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

#Region "QLTGND_POSTBAG_DEN_Xoa"
        Public Function QLTGND_POSTBAG_DEN_Xoa(ByVal Id_E2 As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_POSTBAG_DEN_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_POSTBAG_DEN_Chi_Tiet As New QLTGND_POSTBAG_DEN_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                MyCommand.Parameters.Add(pId_E2)


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

#Region "Hieu_Chinh"

        Public Sub QLTGND_BC37_DEN_Hieu_Chinh(ByVal BC37_ID As String, ByVal Ma_Bc_Khai_Thac As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("QLTGND_BC37_DEN_Hieu_Chinh", myConnection)
                myCommand.CommandTimeout = 20000
                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pBC37_ID As SqlParameter = New SqlParameter("@BC37_ID", SqlDbType.VarChar, 18)
                pBC37_ID.Value = BC37_ID
                myCommand.Parameters.Add(pBC37_ID)

                ' Thêm các Parameters vào thủ tục
                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Sub
#End Region

#Region "QLTGND_POSTBAG_DEN_Danh_Sach_Theo_Danh_Sach_BC37_ID_Trang_Thai"
        Public Function QLTGND_POSTBAG_DEN_Danh_Sach_Theo_Danh_Sach_BC37_ID_Trang_Thai(ByVal Chuoi_BC37_Id As String, ByVal Trang_Thai As Integer, ByVal Ma_Bc_Khai_Thac As Integer) As DataSet
            Dim MyConnection As New SqlConnection(ConnectionString)
            Try
                Dim strSQL As String
                strSQL = "SELECT	Cast(1 as bit) as Chon,	a.Id_E2 as Id_E2,	a.Id_Duong_Thu as Id_Duong_Thu,	a.Ma_Bc ,	a.Id_Chuyen_Thu as Id_Chuyen_Thu,	a.Id_Ca as Id_Ca,	a.Ma_Bc_Khai_Thac as Ma_Bc_Khai_Thac,	dbo.ConvertIntToDate(a.Ngay_Dong) as Ngay_Dong,	a.Gio_Dong as Gio_Dong,	a.Ngay_Nhan as Ngay_Nhan,	a.Gio_Nhan as Gio_Nhan,	a.So_Chuyen_Thu as So_Chuyen_Thu,	a.Tui_So as Tui_So,	a.Tui_F as Tui_F,	a.Tong_So_BP as Tong_So_BP,	a.Khoi_Luong_Vo_Tui as Khoi_Luong_Vo_Tui,	a.Khoi_Luong_BP as Khoi_Luong_BP,	a.Tong_Cuoc_COD as Tong_Cuoc_COD,	a.Tong_Cuoc_DV as Tong_Cuoc_DV,	a.Tong_Cuoc_Chinh as Tong_Cuoc_Chinh,	a.HH_Phat_Hanh as HH_Phat_Hanh,	a.HH_Phat_Tra as HH_Phat_Tra,	a.Truyen_Khai_Thac as Truyen_Khai_Thac,	a.Truyen_Doi_Soat as Truyen_Doi_Soat,	a.Ngay_He_Thong as Ngay_He_Thong,	a.Chot_SL as Chot_SL,	a.Id_Tui_Thu as Id_Tui_Thu,	a.Id_BC37 as Id_BC37,	a.Trang_Thai as Trang_Thai,	a.IS_TRANSITION as IS_TRANSITION    FROM	QLTGND_POSTBAG_DEN a  WHERE	a.Id_BC37 in " & Chuoi_BC37_Id & "	AND a.Trang_Thai = " & CStr(Trang_Thai) & " And Ma_Bc_Khai_Thac = " & Ma_Bc_Khai_Thac & "    ORDER BY                a.Id_E2"

                Dim myCommand As SqlCommand = New SqlCommand(strSQL, MyConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                myCommand.CommandTimeout = 20000
                MyConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Danh_Sach_Tui")
                MyConnection.Close()
                MyConnection.Dispose()
                Return myDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
                MyConnection.Close()
                MyConnection.Dispose()
                Return Nothing
            End Try
        End Function

#End Region

#Region "QLTGND_POSTBAG_DEN_Danh_Sach_Theo_BC37_ID"

        Public Function QLTGND_POSTBAG_DEN_Danh_Sach_Theo_BC37_ID(ByVal BC37_ID As String, ByVal Ma_Bc_Khai_Thac As Integer) As DataSet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_POSTBAG_DEN_Danh_Sach_Theo_BC37_ID"
            MyCommand.CommandType = CommandType.StoredProcedure

            Dim pBC37_ID As SqlParameter = New SqlParameter("@BC37_ID", SqlDbType.VarChar, 18)
            pBC37_ID.Value = BC37_ID
            MyCommand.Parameters.Add(pBC37_ID)


            Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
            pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
            MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

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
                Return Nothing
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                Adapter.Dispose()
            End Try
        End Function
#End Region

#Region "QLTGND_POSTBAG_DEN_Cap_Nhat_Lai_Trang_Thai_Truyen"
        Public Function QLTGND_POSTBAG_DEN_Cap_Nhat_Lai_Trang_Thai_Truyen(ByVal BC37_ID As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Trang_Thai As Integer) As Boolean
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim strSQL As String
            Try
                strSQL = "Update QLTGND_POSTBAG_DEN Set Trang_Thai = " & Trang_Thai.ToString & " Where Id_BC37 = '" & BC37_ID & "' AND Ma_Bc_Khai_Thac = " & Ma_Bc_Khai_Thac.ToString
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

    End Class
#End Region
End Namespace


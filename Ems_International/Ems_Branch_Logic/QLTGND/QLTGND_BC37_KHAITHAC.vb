
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "QLTGND_BC37_KHAITHAC_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop QLTGND_BC37_KHAITHAC_Chi_Tiet
    'Tuong ung voi moi truong trong bang QLTGND_BC37_KHAITHAC trong co so du lieu
    '***********************************************************
    Public Class QLTGND_BC37_KHAITHAC_Chi_Tiet
        Public BC37_ID As String
        Public Id_Duong_Thu As String
        Public Id_Ca As String
        Public Ma_Bc_Khai_Thac As Integer
        Public Ngay_Lap As Integer
        Public Gio_Lap As Integer
        Public Dot_Giao As Integer
        Public Id_Nguoi_Dung As Integer
        Public Ngay_He_Thong As Integer
        Public Gio_He_Thong As Integer
        Public Da_In As Boolean
        Public Chot_SL As Boolean
        Public Truyen_Khai_Thac As Integer
    End Class
#End Region

#Region "QLTGND_BC37_KHAITHAC"
    Public Class QLTGND_BC37_KHAITHAC
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "QLTGND_BC37_KHAITHAC_Cap_Nhat_Them"
        Public Function QLTGND_BC37_KHAITHAC_Cap_Nhat_Them(ByVal BC37_ID As String, ByVal Id_Duong_Thu As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ngay_Lap As Integer, ByVal Gio_Lap As Integer, ByVal Dot_Giao As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer, ByVal Da_In As Boolean, ByVal Chot_SL As Boolean, ByVal Truyen_Khai_Thac As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_BC37_KHAITHAC_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myQLTGND_BC37_KHAITHAC_Chi_Tiet As New QLTGND_BC37_KHAITHAC_Chi_Tiet

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

                Dim pNgay_Lap As SqlParameter = New SqlParameter("@Ngay_Lap", SqlDbType.Int, 0)
                pNgay_Lap.Value = Ngay_Lap
                MyCommand.Parameters.Add(pNgay_Lap)

                Dim pGio_Lap As SqlParameter = New SqlParameter("@Gio_Lap", SqlDbType.Int, 0)
                pGio_Lap.Value = Gio_Lap
                MyCommand.Parameters.Add(pGio_Lap)

                Dim pDot_Giao As SqlParameter = New SqlParameter("@Dot_Giao", SqlDbType.Int, 0)
                pDot_Giao.Value = Dot_Giao
                MyCommand.Parameters.Add(pDot_Giao)

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


#Region "QLTGND_BC37_KHAITHAC_Danh_Sach"

        Public Function QLTGND_BC37_KHAITHAC_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' BC37_ID
            ' Id_Duong_Thu
            ' Id_Ca
            ' Ma_Bc_Khai_Thac
            ' Ngay_Lap
            ' Gio_Lap
            ' Dot_Giao
            ' Id_Nguoi_Dung
            ' Ngay_He_Thong
            ' Gio_He_Thong
            ' Da_In
            ' Chot_SL
            ' Truyen_Khai_Thac


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_BC37_KHAITHAC_Danh_Sach"
            MyCommand.CommandType = CommandType.StoredProcedure
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

#Region "QLTGND_BC37_KHAITHAC_Lay"
        Public Function QLTGND_BC37_KHAITHAC_Lay(ByVal BC37_ID As String) As QLTGND_BC37_KHAITHAC_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_BC37_KHAITHAC_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myQLTGND_BC37_KHAITHAC_Chi_Tiet As New QLTGND_BC37_KHAITHAC_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pBC37_ID As SqlParameter = New SqlParameter("@BC37_ID", SqlDbType.NVarChar, 18)
                pBC37_ID.Value = BC37_ID
                MyCommand.Parameters.Add(pBC37_ID)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Duong_Thu)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pNgay_Lap As SqlParameter = New SqlParameter("@Ngay_Lap", SqlDbType.Int, 0)
                pNgay_Lap.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Lap)

                Dim pGio_Lap As SqlParameter = New SqlParameter("@Gio_Lap", SqlDbType.Int, 0)
                pGio_Lap.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Lap)

                Dim pDot_Giao As SqlParameter = New SqlParameter("@Dot_Giao", SqlDbType.Int, 0)
                pDot_Giao.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDot_Giao)

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


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myQLTGND_BC37_KHAITHAC_Chi_Tiet.BC37_ID = BC37_ID
                myQLTGND_BC37_KHAITHAC_Chi_Tiet.Id_Duong_Thu = pId_Duong_Thu.Value
                myQLTGND_BC37_KHAITHAC_Chi_Tiet.Id_Ca = pId_Ca.Value
                myQLTGND_BC37_KHAITHAC_Chi_Tiet.Ma_Bc_Khai_Thac = pMa_Bc_Khai_Thac.Value
                myQLTGND_BC37_KHAITHAC_Chi_Tiet.Ngay_Lap = pNgay_Lap.Value
                myQLTGND_BC37_KHAITHAC_Chi_Tiet.Gio_Lap = pGio_Lap.Value
                myQLTGND_BC37_KHAITHAC_Chi_Tiet.Dot_Giao = pDot_Giao.Value
                myQLTGND_BC37_KHAITHAC_Chi_Tiet.Id_Nguoi_Dung = pId_Nguoi_Dung.Value
                myQLTGND_BC37_KHAITHAC_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myQLTGND_BC37_KHAITHAC_Chi_Tiet.Gio_He_Thong = pGio_He_Thong.Value
                myQLTGND_BC37_KHAITHAC_Chi_Tiet.Da_In = pDa_In.Value
                myQLTGND_BC37_KHAITHAC_Chi_Tiet.Chot_SL = pChot_SL.Value
                myQLTGND_BC37_KHAITHAC_Chi_Tiet.Truyen_Khai_Thac = pTruyen_Khai_Thac.Value

                Return myQLTGND_BC37_KHAITHAC_Chi_Tiet
                'Return myQLTGND_BC37_KHAITHAC_Chi_Tiet

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

#Region "QLTGND_BC37_KHAITHAC_Xoa"
        Public Function QLTGND_BC37_KHAITHAC_Xoa(ByVal BC37_ID As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_BC37_KHAITHAC_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myQLTGND_BC37_KHAITHAC_Chi_Tiet As New QLTGND_BC37_KHAITHAC_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pBC37_ID As SqlParameter = New SqlParameter("@BC37_ID", SqlDbType.NVarChar, 18)
                pBC37_ID.Value = BC37_ID
                MyCommand.Parameters.Add(pBC37_ID)


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


    End Class
#End Region
End Namespace


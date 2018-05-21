
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "Thong_Tin_Truyen_Logitic_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop Thong_Tin_Truyen_Logitic_Chi_Tiet
    'Tuong ung voi moi truong trong bang Thong_Tin_Truyen_Logitic trong co so du lieu
    '***********************************************************
    Public Class Thong_Tin_Truyen_Logitic_Chi_Tiet
        Public Id_Chuyen_Thu As String
        Public Ma_Bc_Goc As Integer
        Public Ma_Bc_Dich As Integer
        Public Ip_Goc As String
        Public Ip_Dich As String
        Public Ngay_Gui As Integer
        Public Gio_Gui As Integer
        Public Ngay_He_Thong As Integer
        Public Gio_He_Thong As Integer
        Public Da_Gui As Boolean
    End Class
#End Region

#Region "Thong_Tin_Truyen_Logitic"
    Public Class Thong_Tin_Truyen_Logitic
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "Thong_Tin_Truyen_Logitic_Cap_Nhat_Them"
        Public Function Thong_Tin_Truyen_Logitic_Cap_Nhat_Them(ByVal Id_Chuyen_Thu As String, ByVal Ma_Bc_Goc As Integer, ByVal Ma_Bc_Dich As Integer, ByVal Ip_Goc As String, ByVal Ip_Dich As String, ByVal Ngay_Gui As Integer, ByVal Gio_Gui As Integer, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer, ByVal Da_Gui As Boolean) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Thong_Tin_Truyen_Logitic_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myThong_Tin_Truyen_Logitic_Chi_Tiet As New Thong_Tin_Truyen_Logitic_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                MyCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 0)
                pMa_Bc_Goc.Value = Ma_Bc_Goc
                MyCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pMa_Bc_Dich As SqlParameter = New SqlParameter("@Ma_Bc_Dich", SqlDbType.Int, 0)
                pMa_Bc_Dich.Value = Ma_Bc_Dich
                MyCommand.Parameters.Add(pMa_Bc_Dich)

                Dim pIp_Goc As SqlParameter = New SqlParameter("@Ip_Goc", SqlDbType.VarChar, 50)
                pIp_Goc.Value = Ip_Goc
                MyCommand.Parameters.Add(pIp_Goc)

                Dim pIp_Dich As SqlParameter = New SqlParameter("@Ip_Dich", SqlDbType.VarChar, 50)
                pIp_Dich.Value = Ip_Dich
                MyCommand.Parameters.Add(pIp_Dich)

                Dim pNgay_Gui As SqlParameter = New SqlParameter("@Ngay_Gui", SqlDbType.Int, 0)
                pNgay_Gui.Value = Ngay_Gui
                MyCommand.Parameters.Add(pNgay_Gui)

                Dim pGio_Gui As SqlParameter = New SqlParameter("@Gio_Gui", SqlDbType.Int, 0)
                pGio_Gui.Value = Gio_Gui
                MyCommand.Parameters.Add(pGio_Gui)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Value = Ngay_He_Thong
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Value = Gio_He_Thong
                MyCommand.Parameters.Add(pGio_He_Thong)

                Dim pDa_Gui As SqlParameter = New SqlParameter("@Da_Gui", SqlDbType.Bit, 0)
                pDa_Gui.Value = Da_Gui
                MyCommand.Parameters.Add(pDa_Gui)


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


#Region "Thong_Tin_Truyen_Logitic_Danh_Sach"

        Public Function Thong_Tin_Truyen_Logitic_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Id_Chuyen_Thu
            ' Ma_Bc_Goc
            ' Ma_Bc_Dich
            ' Ip_Goc
            ' Ip_Dich
            ' Ngay_Gui
            ' Gio_Gui
            ' Ngay_He_Thong
            ' Gio_He_Thong
            ' Da_Gui


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Thong_Tin_Truyen_Logitic_Danh_Sach"
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
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                Adapter.Dispose()
            End Try
        End Function
#End Region

#Region "Thong_Tin_Truyen_Logitic_Lay"
        Public Function Thong_Tin_Truyen_Logitic_Lay(ByVal Id_Chuyen_Thu As String) As Thong_Tin_Truyen_Logitic_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Thong_Tin_Truyen_Logitic_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myThong_Tin_Truyen_Logitic_Chi_Tiet As New Thong_Tin_Truyen_Logitic_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                MyCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 0)
                pMa_Bc_Goc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pMa_Bc_Dich As SqlParameter = New SqlParameter("@Ma_Bc_Dich", SqlDbType.Int, 0)
                pMa_Bc_Dich.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc_Dich)

                Dim pIp_Goc As SqlParameter = New SqlParameter("@Ip_Goc", SqlDbType.VarChar, 50)
                pIp_Goc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pIp_Goc)

                Dim pIp_Dich As SqlParameter = New SqlParameter("@Ip_Dich", SqlDbType.VarChar, 50)
                pIp_Dich.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pIp_Dich)

                Dim pNgay_Gui As SqlParameter = New SqlParameter("@Ngay_Gui", SqlDbType.Int, 0)
                pNgay_Gui.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Gui)

                Dim pGio_Gui As SqlParameter = New SqlParameter("@Gio_Gui", SqlDbType.Int, 0)
                pGio_Gui.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Gui)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_He_Thong)

                Dim pDa_Gui As SqlParameter = New SqlParameter("@Da_Gui", SqlDbType.Bit, 0)
                pDa_Gui.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDa_Gui)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myThong_Tin_Truyen_Logitic_Chi_Tiet.Id_Chuyen_Thu = Id_Chuyen_Thu
                myThong_Tin_Truyen_Logitic_Chi_Tiet.Ma_Bc_Goc = pMa_Bc_Goc.Value
                myThong_Tin_Truyen_Logitic_Chi_Tiet.Ma_Bc_Dich = pMa_Bc_Dich.Value
                myThong_Tin_Truyen_Logitic_Chi_Tiet.Ip_Goc = pIp_Goc.Value
                myThong_Tin_Truyen_Logitic_Chi_Tiet.Ip_Dich = pIp_Dich.Value
                myThong_Tin_Truyen_Logitic_Chi_Tiet.Ngay_Gui = pNgay_Gui.Value
                myThong_Tin_Truyen_Logitic_Chi_Tiet.Gio_Gui = pGio_Gui.Value
                myThong_Tin_Truyen_Logitic_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myThong_Tin_Truyen_Logitic_Chi_Tiet.Gio_He_Thong = pGio_He_Thong.Value
                myThong_Tin_Truyen_Logitic_Chi_Tiet.Da_Gui = pDa_Gui.Value

                Return myThong_Tin_Truyen_Logitic_Chi_Tiet
                'Return myThong_Tin_Truyen_Logitic_Chi_Tiet

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

#Region "Thong_Tin_Truyen_Logitic_Xoa"
        Public Function Thong_Tin_Truyen_Logitic_Xoa(ByVal Id_Chuyen_Thu As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Thong_Tin_Truyen_Logitic_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myThong_Tin_Truyen_Logitic_Chi_Tiet As New Thong_Tin_Truyen_Logitic_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                MyCommand.Parameters.Add(pId_Chuyen_Thu)


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


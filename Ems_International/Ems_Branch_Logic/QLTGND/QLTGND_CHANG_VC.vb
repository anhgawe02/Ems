
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "QLTGND_CHANG_VC_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop QLTGND_CHANG_VC_Chi_Tiet
    'Tuong ung voi moi truong trong bang QLTGND_CHANG_VC trong co so du lieu
    '***********************************************************
    Public Class QLTGND_CHANG_VC_Chi_Tiet
        Public Id_Chang As Integer
        Public Id_Tuyen As Integer
        Public Ma_Bc_Goc As Integer
        Public Ten_Bc_Goc As String
        Public Ma_Bc_Dich As Integer
        Public Ten_Bc_Dich As String
        Public Cap_Bc_Dich As Integer
        Public Gio_Di As Integer
        Public Gio_Den As Integer
        Public STT As Integer
    End Class
#End Region

#Region "QLTGND_CHANG_VC"
    Public Class QLTGND_CHANG_VC
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "QLTGND_CHANG_VC_Cap_Nhat_Them"
        Public Function QLTGND_CHANG_VC_Cap_Nhat_Them(ByVal Id_Chang As Integer, ByVal Id_Tuyen As Integer, ByVal Ma_Bc_Goc As Integer, ByVal Ten_Bc_Goc As String, ByVal Ma_Bc_Dich As Integer, ByVal Ten_Bc_Dich As String, ByVal Cap_Bc_Dich As Integer, ByVal Gio_Di As Integer, ByVal Gio_Den As Integer, ByVal STT As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_CHANG_VC_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_CHANG_VC_Chi_Tiet As New QLTGND_CHANG_VC_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Chang As SqlParameter = New SqlParameter("@Id_Chang", SqlDbType.Int, 0)
                pId_Chang.Value = Id_Chang
                MyCommand.Parameters.Add(pId_Chang)

                Dim pId_Tuyen As SqlParameter = New SqlParameter("@Id_Tuyen", SqlDbType.Int, 0)
                pId_Tuyen.Value = Id_Tuyen
                MyCommand.Parameters.Add(pId_Tuyen)

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 0)
                pMa_Bc_Goc.Value = Ma_Bc_Goc
                MyCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pTen_Bc_Goc As SqlParameter = New SqlParameter("@Ten_Bc_Goc", SqlDbType.NVarChar, 200)
                pTen_Bc_Goc.Value = Ten_Bc_Goc
                MyCommand.Parameters.Add(pTen_Bc_Goc)

                Dim pMa_Bc_Dich As SqlParameter = New SqlParameter("@Ma_Bc_Dich", SqlDbType.Int, 0)
                pMa_Bc_Dich.Value = Ma_Bc_Dich
                MyCommand.Parameters.Add(pMa_Bc_Dich)

                Dim pTen_Bc_Dich As SqlParameter = New SqlParameter("@Ten_Bc_Dich", SqlDbType.NVarChar, 200)
                pTen_Bc_Dich.Value = Ten_Bc_Dich
                MyCommand.Parameters.Add(pTen_Bc_Dich)

                Dim pCap_Bc_Dich As SqlParameter = New SqlParameter("@Cap_Bc_Dich", SqlDbType.Int, 0)
                pCap_Bc_Dich.Value = Cap_Bc_Dich
                MyCommand.Parameters.Add(pCap_Bc_Dich)

                Dim pGio_Di As SqlParameter = New SqlParameter("@Gio_Di", SqlDbType.Int, 0)
                pGio_Di.Value = Gio_Di
                MyCommand.Parameters.Add(pGio_Di)

                Dim pGio_Den As SqlParameter = New SqlParameter("@Gio_Den", SqlDbType.Int, 0)
                pGio_Den.Value = Gio_Den
                MyCommand.Parameters.Add(pGio_Den)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Value = STT
                MyCommand.Parameters.Add(pSTT)


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

#Region "QLTGND_CHANG_VC_Cap_Nhat"
        Public Function QLTGND_CHANG_VC_Cap_Nhat(ByVal Id_Tuyen As Integer, ByVal Ma_Bc_Goc As Integer, ByVal Ten_Bc_Goc As String, ByVal Ma_Bc_Dich As Integer, ByVal Ten_Bc_Dich As String, ByVal Cap_Bc_Dich As Integer, ByVal Gio_Di As Integer, ByVal Gio_Den As Integer, ByVal STT As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_CHANG_VC_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_CHANG_VC_Chi_Tiet As New QLTGND_CHANG_VC_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters               

                Dim pId_Tuyen As SqlParameter = New SqlParameter("@Id_Tuyen", SqlDbType.Int, 0)
                pId_Tuyen.Value = Id_Tuyen
                MyCommand.Parameters.Add(pId_Tuyen)

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 0)
                pMa_Bc_Goc.Value = Ma_Bc_Goc
                MyCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pTen_Bc_Goc As SqlParameter = New SqlParameter("@Ten_Bc_Goc", SqlDbType.NVarChar, 200)
                pTen_Bc_Goc.Value = Ten_Bc_Goc
                MyCommand.Parameters.Add(pTen_Bc_Goc)

                Dim pMa_Bc_Dich As SqlParameter = New SqlParameter("@Ma_Bc_Dich", SqlDbType.Int, 0)
                pMa_Bc_Dich.Value = Ma_Bc_Dich
                MyCommand.Parameters.Add(pMa_Bc_Dich)

                Dim pTen_Bc_Dich As SqlParameter = New SqlParameter("@Ten_Bc_Dich", SqlDbType.NVarChar, 200)
                pTen_Bc_Dich.Value = Ten_Bc_Dich
                MyCommand.Parameters.Add(pTen_Bc_Dich)

                Dim pCap_Bc_Dich As SqlParameter = New SqlParameter("@Cap_Bc_Dich", SqlDbType.Int, 0)
                pCap_Bc_Dich.Value = Cap_Bc_Dich
                MyCommand.Parameters.Add(pCap_Bc_Dich)

                Dim pGio_Di As SqlParameter = New SqlParameter("@Gio_Di", SqlDbType.Int, 0)
                pGio_Di.Value = Gio_Di
                MyCommand.Parameters.Add(pGio_Di)

                Dim pGio_Den As SqlParameter = New SqlParameter("@Gio_Den", SqlDbType.Int, 0)
                pGio_Den.Value = Gio_Den
                MyCommand.Parameters.Add(pGio_Den)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Value = STT
                MyCommand.Parameters.Add(pSTT)

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

#Region "QLTGND_CHANG_VC_Danh_Sach"

        Public Function QLTGND_CHANG_VC_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Id_Chang
            ' Id_Tuyen
            ' Ma_Bc_Goc
            ' Ten_Bc_Goc
            ' Ma_Bc_Dich
            ' Ten_Bc_Dich
            ' Cap_Bc_Dich
            ' Gio_Di
            ' Gio_Den
            ' STT


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_CHANG_VC_Danh_Sach"
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
                Return Nothing
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                Adapter.Dispose()
            End Try
        End Function
#End Region

#Region "QLTGND_CHANG_VC_Danh_Sach_Theo_Tuyen"

        Public Function QLTGND_CHANG_VC_Danh_Sach_Theo_Tuyen(ByVal Id_Tuyen As Integer) As DataSet

            ' The procedure returns these columns:
            ' Id_Chang
            ' Id_Tuyen
            ' Ma_Bc_Goc
            ' Ten_Bc_Goc
            ' Ma_Bc_Dich
            ' Ten_Bc_Dich
            ' Cap_Bc_Dich
            ' Gio_Di
            ' Gio_Den
            ' STT


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_CHANG_VC_Danh_Sach_Theo_Tuyen"
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

#Region "QLTGND_CHANG_VC_Danh_Sach_Theo_Ma_Bc_Goc"

        Public Function QLTGND_CHANG_VC_Danh_Sach_Theo_Ma_Bc_Goc(ByVal Ma_Bc_Goc As Integer) As DataSet

            ' The procedure returns these columns:
            ' Id_Chang
            ' Id_Tuyen
            ' Ma_Bc_Goc
            ' Ten_Bc_Goc
            ' Ma_Bc_Dich
            ' Ten_Bc_Dich
            ' Cap_Bc_Dich
            ' Gio_Di
            ' Gio_Den
            ' STT


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_CHANG_VC_Danh_Sach_Theo_Ma_Bc_Goc"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters
                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 0)
                pMa_Bc_Goc.Value = Ma_Bc_Goc
                MyCommand.Parameters.Add(pMa_Bc_Goc)

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
#Region "QLTGND_CHANG_VC_Danh_Sach_Theo_Ma_Bc_Goc_Ma_Bc_Dich"

        Public Function QLTGND_CHANG_VC_Danh_Sach_Theo_Ma_Bc_Goc_Ma_Bc_Dich(ByVal Ma_Bc_Goc As Integer, ByVal Ma_Bc_Dich As Integer) As DataSet

            ' The procedure returns these columns:
            ' Id_Chang
            ' Id_Tuyen
            ' Ma_Bc_Goc
            ' Ten_Bc_Goc
            ' Ma_Bc_Dich
            ' Ten_Bc_Dich
            ' Cap_Bc_Dich
            ' Gio_Di
            ' Gio_Den
            ' STT


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_CHANG_VC_Danh_Sach_Theo_Ma_Bc_Goc_Ma_Bc_Dich"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters
                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int)
                pMa_Bc_Goc.Value = Ma_Bc_Goc
                MyCommand.Parameters.Add(pMa_Bc_Goc)
                Dim pMa_Bc_Dich As SqlParameter = New SqlParameter("@Ma_Bc_Dich", SqlDbType.Int)
                pMa_Bc_Dich.Value = Ma_Bc_Dich
                MyCommand.Parameters.Add(pMa_Bc_Dich)
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
#Region "QLTGND_CHANG_VC_Danh_Sach_Theo_Ma_Bc_Dich"

        Public Function QLTGND_CHANG_VC_Danh_Sach_Theo_Ma_Bc_Dich(ByVal Ma_Bc_Dich As Integer) As DataSet

            ' The procedure returns these columns:
            ' Id_Chang
            ' Id_Tuyen
            ' Ma_Bc_Goc
            ' Ten_Bc_Goc
            ' Ma_Bc_Dich
            ' Ten_Bc_Dich
            ' Cap_Bc_Dich
            ' Gio_Di
            ' Gio_Den
            ' STT


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_CHANG_VC_Danh_Sach_Theo_Ma_Bc_Dich"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters
                Dim pMa_Bc_Dich As SqlParameter = New SqlParameter("@Ma_Bc_Dich", SqlDbType.Int, 0)
                pMa_Bc_Dich.Value = Ma_Bc_Dich
                MyCommand.Parameters.Add(pMa_Bc_Dich)

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

#Region "QLTGND_CHANG_VC_Lay"
        Public Function QLTGND_CHANG_VC_Lay(ByVal Id_Chang As Integer) As QLTGND_CHANG_VC_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_CHANG_VC_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_CHANG_VC_Chi_Tiet As New QLTGND_CHANG_VC_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Chang As SqlParameter = New SqlParameter("@Id_Chang", SqlDbType.Int, 0)
                pId_Chang.Value = Id_Chang
                MyCommand.Parameters.Add(pId_Chang)

                Dim pId_Tuyen As SqlParameter = New SqlParameter("@Id_Tuyen", SqlDbType.Int, 0)
                pId_Tuyen.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Tuyen)

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 0)
                pMa_Bc_Goc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pTen_Bc_Goc As SqlParameter = New SqlParameter("@Ten_Bc_Goc", SqlDbType.NVarChar, 200)
                pTen_Bc_Goc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTen_Bc_Goc)

                Dim pMa_Bc_Dich As SqlParameter = New SqlParameter("@Ma_Bc_Dich", SqlDbType.Int, 0)
                pMa_Bc_Dich.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc_Dich)

                Dim pTen_Bc_Dich As SqlParameter = New SqlParameter("@Ten_Bc_Dich", SqlDbType.NVarChar, 200)
                pTen_Bc_Dich.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTen_Bc_Dich)

                Dim pCap_Bc_Dich As SqlParameter = New SqlParameter("@Cap_Bc_Dich", SqlDbType.Int, 0)
                pCap_Bc_Dich.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCap_Bc_Dich)

                Dim pGio_Di As SqlParameter = New SqlParameter("@Gio_Di", SqlDbType.Int, 0)
                pGio_Di.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Di)

                Dim pGio_Den As SqlParameter = New SqlParameter("@Gio_Den", SqlDbType.Int, 0)
                pGio_Den.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Den)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSTT)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myQLTGND_CHANG_VC_Chi_Tiet.Id_Chang = Id_Chang
                myQLTGND_CHANG_VC_Chi_Tiet.Id_Tuyen = pId_Tuyen.Value
                myQLTGND_CHANG_VC_Chi_Tiet.Ma_Bc_Goc = pMa_Bc_Goc.Value
                myQLTGND_CHANG_VC_Chi_Tiet.Ten_Bc_Goc = pTen_Bc_Goc.Value
                myQLTGND_CHANG_VC_Chi_Tiet.Ma_Bc_Dich = pMa_Bc_Dich.Value
                myQLTGND_CHANG_VC_Chi_Tiet.Ten_Bc_Dich = pTen_Bc_Dich.Value
                myQLTGND_CHANG_VC_Chi_Tiet.Cap_Bc_Dich = pCap_Bc_Dich.Value
                myQLTGND_CHANG_VC_Chi_Tiet.Gio_Di = pGio_Di.Value
                myQLTGND_CHANG_VC_Chi_Tiet.Gio_Den = pGio_Den.Value
                myQLTGND_CHANG_VC_Chi_Tiet.STT = pSTT.Value

                Return myQLTGND_CHANG_VC_Chi_Tiet
                'Return myQLTGND_CHANG_VC_Chi_Tiet

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

#Region "QLTGND_CHANG_VC_Lay_Theo_BC_Goc_Dich"
        Public Function QLTGND_CHANG_VC_Lay_Theo_BC_Goc_Dich(ByVal Ma_Bc_Goc As Integer, ByVal Ma_Bc_Dich As Integer, ByVal Id_Tuyen As Integer) As QLTGND_CHANG_VC_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_CHANG_VC_Lay_Theo_BC_Goc_Dich"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_CHANG_VC_Chi_Tiet As New QLTGND_CHANG_VC_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 0)
                pMa_Bc_Goc.Value = Ma_Bc_Goc
                MyCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pMa_Bc_Dich As SqlParameter = New SqlParameter("@Ma_Bc_Dich", SqlDbType.Int, 0)
                pMa_Bc_Dich.Value = Ma_Bc_Dich
                MyCommand.Parameters.Add(pMa_Bc_Dich)

                Dim pId_Tuyen As SqlParameter = New SqlParameter("@Id_Tuyen", SqlDbType.Int, 0)
                pId_Tuyen.Value = Id_Tuyen
                MyCommand.Parameters.Add(pId_Tuyen)

                Dim pId_Chang As SqlParameter = New SqlParameter("@Id_Chang", SqlDbType.Int, 0)
                pId_Chang.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Chang)

                Dim pTen_Bc_Goc As SqlParameter = New SqlParameter("@Ten_Bc_Goc", SqlDbType.NVarChar, 200)
                pTen_Bc_Goc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTen_Bc_Goc)

                Dim pTen_Bc_Dich As SqlParameter = New SqlParameter("@Ten_Bc_Dich", SqlDbType.NVarChar, 200)
                pTen_Bc_Dich.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTen_Bc_Dich)

                Dim pCap_Bc_Dich As SqlParameter = New SqlParameter("@Cap_Bc_Dich", SqlDbType.Int, 0)
                pCap_Bc_Dich.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCap_Bc_Dich)

                Dim pGio_Di As SqlParameter = New SqlParameter("@Gio_Di", SqlDbType.Int, 0)
                pGio_Di.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Di)

                Dim pGio_Den As SqlParameter = New SqlParameter("@Gio_Den", SqlDbType.Int, 0)
                pGio_Den.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Den)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSTT)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myQLTGND_CHANG_VC_Chi_Tiet.Ma_Bc_Goc = Ma_Bc_Goc
                myQLTGND_CHANG_VC_Chi_Tiet.Ma_Bc_Dich = Ma_Bc_Dich
                myQLTGND_CHANG_VC_Chi_Tiet.Id_Chang = pId_Chang.Value
                myQLTGND_CHANG_VC_Chi_Tiet.Id_Tuyen = pId_Tuyen.Value
                myQLTGND_CHANG_VC_Chi_Tiet.Ten_Bc_Goc = pTen_Bc_Goc.Value
                myQLTGND_CHANG_VC_Chi_Tiet.Ten_Bc_Dich = pTen_Bc_Dich.Value
                myQLTGND_CHANG_VC_Chi_Tiet.Cap_Bc_Dich = pCap_Bc_Dich.Value
                myQLTGND_CHANG_VC_Chi_Tiet.Gio_Di = pGio_Di.Value
                myQLTGND_CHANG_VC_Chi_Tiet.Gio_Den = pGio_Den.Value
                myQLTGND_CHANG_VC_Chi_Tiet.STT = pSTT.Value

                Return myQLTGND_CHANG_VC_Chi_Tiet
                'Return myQLTGND_CHANG_VC_Chi_Tiet

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

#Region "QLTGND_CHANG_VC_Xoa"
        Public Function QLTGND_CHANG_VC_Xoa(ByVal Id_Chang As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_CHANG_VC_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_CHANG_VC_Chi_Tiet As New QLTGND_CHANG_VC_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Chang As SqlParameter = New SqlParameter("@Id_Chang", SqlDbType.Int, 0)
                pId_Chang.Value = Id_Chang
                MyCommand.Parameters.Add(pId_Chang)


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

#Region "QLTGND_CHANG_VC_XOA_THEO_MABC"
        ' Ngày tạo: 27/6/08
        ' Input: mae1
        ' Output: true or false
        Public Sub QLTGND_CHANG_VC_XOA_THEO_MABC(ByVal MABC As String)
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand

            myCommand = New SqlCommand("delete from QLTGND_Chang_Vc where (Ma_Bc_Goc=" + MABC + ") OR (Ma_Bc_Dich=" + MABC + ")", myConnection)
            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand

            myConnection.Close()
            myConnection.Dispose()

        End Sub
#End Region
    End Class
#End Region
End Namespace


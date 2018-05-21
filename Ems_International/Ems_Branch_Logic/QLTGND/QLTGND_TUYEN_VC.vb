
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "QLTGND_TUYEN_VC_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop QLTGND_TUYEN_VC_Chi_Tiet
    'Tuong ung voi moi truong trong bang QLTGND_TUYEN_VC trong co so du lieu
    '***********************************************************
    Public Class QLTGND_TUYEN_VC_Chi_Tiet
        Public Id_Tuyen As Integer
        Public Id_Tuyen_Char As String
        Public Ten_Tuyen As String
        Public Id_Dot As Integer
        Public Ma_Tinh_Goc_Char As String
        Public Ma_Tinh_Dich_Char As String
        Public Ma_Tinh_Goc As Integer
        Public Ma_Tinh_Dich As Integer
        Public Id_Huong As Integer
        Public ROUD_MAP_ID As Integer
        Public TYPE As Integer
        Public PROVINCE As Integer
        Public PARTNER_ID As Integer
        Public TRANSPORT_TYPE_ID As Integer
    End Class
#End Region

#Region "QLTGND_TUYEN_VC"
    Public Class QLTGND_TUYEN_VC
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "QLTGND_TUYEN_VC_Cap_Nhat_Them"
        Public Function QLTGND_TUYEN_VC_Cap_Nhat_Them(ByVal Id_Tuyen As Integer, ByVal Id_Tuyen_Char As String, ByVal Ten_Tuyen As String, ByVal Id_Dot As Integer, ByVal Ma_Tinh_Goc_Char As String, ByVal Ma_Tinh_Dich_Char As String, ByVal Ma_Tinh_Goc As Integer, ByVal Ma_Tinh_Dich As Integer, ByVal Id_Huong As Integer, ByVal ROUD_MAP_ID As Integer, ByVal TYPE As Integer, ByVal PROVINCE As Integer, ByVal PARTNER_ID As Integer, ByVal TRANSPORT_TYPE_ID As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_TUYEN_VC_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            'MyCommand.CommandTimeout = 20000
            Dim myQLTGND_TUYEN_VC_Chi_Tiet As New QLTGND_TUYEN_VC_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Tuyen As SqlParameter = New SqlParameter("@Id_Tuyen", SqlDbType.Int, 0)
                pId_Tuyen.Value = Id_Tuyen
                MyCommand.Parameters.Add(pId_Tuyen)

                Dim pId_Tuyen_Char As SqlParameter = New SqlParameter("@Id_Tuyen_Char", SqlDbType.VarChar, 20)
                pId_Tuyen_Char.Value = Id_Tuyen_Char
                MyCommand.Parameters.Add(pId_Tuyen_Char)

                Dim pTen_Tuyen As SqlParameter = New SqlParameter("@Ten_Tuyen", SqlDbType.NVarChar, 200)
                pTen_Tuyen.Value = Ten_Tuyen
                MyCommand.Parameters.Add(pTen_Tuyen)

                Dim pId_Dot As SqlParameter = New SqlParameter("@Id_Dot", SqlDbType.Int, 0)
                pId_Dot.Value = Id_Dot
                MyCommand.Parameters.Add(pId_Dot)

                Dim pMa_Tinh_Goc_Char As SqlParameter = New SqlParameter("@Ma_Tinh_Goc_Char", SqlDbType.VarChar, 3)
                pMa_Tinh_Goc_Char.Value = Ma_Tinh_Goc_Char
                MyCommand.Parameters.Add(pMa_Tinh_Goc_Char)

                Dim pMa_Tinh_Dich_Char As SqlParameter = New SqlParameter("@Ma_Tinh_Dich_Char", SqlDbType.VarChar, 3)
                pMa_Tinh_Dich_Char.Value = Ma_Tinh_Dich_Char
                MyCommand.Parameters.Add(pMa_Tinh_Dich_Char)

                Dim pMa_Tinh_Goc As SqlParameter = New SqlParameter("@Ma_Tinh_Goc", SqlDbType.Int, 0)
                pMa_Tinh_Goc.Value = Ma_Tinh_Goc
                MyCommand.Parameters.Add(pMa_Tinh_Goc)

                Dim pMa_Tinh_Dich As SqlParameter = New SqlParameter("@Ma_Tinh_Dich", SqlDbType.Int, 0)
                pMa_Tinh_Dich.Value = Ma_Tinh_Dich
                MyCommand.Parameters.Add(pMa_Tinh_Dich)

                Dim pId_Huong As SqlParameter = New SqlParameter("@Id_Huong", SqlDbType.Int, 0)
                pId_Huong.Value = Id_Huong
                MyCommand.Parameters.Add(pId_Huong)

                Dim pROUD_MAP_ID As SqlParameter = New SqlParameter("@ROUD_MAP_ID", SqlDbType.Int, 0)
                pROUD_MAP_ID.Value = ROUD_MAP_ID
                MyCommand.Parameters.Add(pROUD_MAP_ID)

                Dim pTYPE As SqlParameter = New SqlParameter("@TYPE", SqlDbType.Int, 0)
                pTYPE.Value = TYPE
                MyCommand.Parameters.Add(pTYPE)

                Dim pPARTNER_ID As SqlParameter = New SqlParameter("@PARTNER_ID", SqlDbType.Int, 0)
                pPARTNER_ID.Value = PARTNER_ID
                MyCommand.Parameters.Add(pPARTNER_ID)

                Dim pTRANSPORT_TYPE_ID As SqlParameter = New SqlParameter("@TRANSPORT_TYPE_ID", SqlDbType.Int, 0)
                pTRANSPORT_TYPE_ID.Value = TRANSPORT_TYPE_ID
                MyCommand.Parameters.Add(pTRANSPORT_TYPE_ID)

                Dim pPROVINCE As SqlParameter = New SqlParameter("@PROVINCE", SqlDbType.Int, 0)
                pPROVINCE.Value = PROVINCE
                MyCommand.Parameters.Add(pPROVINCE)

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

#Region "QLTGND_TUYEN_VC_Danh_Sach"

        Public Function QLTGND_TUYEN_VC_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Id_Tuyen
            ' Id_Tuyen_Char
            ' Ten_Tuyen
            ' Id_Dot
            ' Ma_Tinh_Goc_Char
            ' Ma_Tinh_Dich_Char
            ' Ma_Tinh_Goc
            ' Ma_Tinh_Dich


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_TUYEN_VC_Danh_Sach"
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

#Region "QLTGND_TUYEN_VC_Danh_Sach_Theo_Id_Tuyen"

        Public Function QLTGND_TUYEN_VC_Danh_Sach_Theo_Id_Tuyen(ByVal Id_Tuyen As Integer) As DataSet

            ' The procedure returns these columns:
            ' Id_Tuyen
            ' Id_Tuyen_Char
            ' Ten_Tuyen
            ' Id_Dot
            ' Ma_Tinh_Goc_Char
            ' Ma_Tinh_Dich_Char
            ' Ma_Tinh_Goc
            ' Ma_Tinh_Dich


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_TUYEN_VC_Danh_Sach_Theo_Id_Tuyen"
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

#Region "QLTGND_TUYEN_VC_Danh_Sach_Monitor"

        Public Function QLTGND_TUYEN_VC_Danh_Sach_Monitor(ByVal Ma_Bc_Khai_Thac As Integer, ByVal Kieu As Integer, ByVal PartnerID As Integer) As DataSet

            ' The procedure returns these columns:
            ' Id_Tuyen
            ' Id_Tuyen_Char
            ' Ten_Tuyen
            ' Id_Dot
            ' Ma_Tinh_Goc_Char
            ' Ma_Tinh_Dich_Char
            ' Ma_Tinh_Goc
            ' Ma_Tinh_Dich
            ' Id_Huong
            ' XN_BC37_Den


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_TUYEN_VC_Danh_Sach_Monitor"
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

                Dim pKieu As SqlParameter = New SqlParameter("@Kieu", SqlDbType.Int, 0)
                pKieu.Value = Kieu
                MyCommand.Parameters.Add(pKieu)

                Dim pPartnerID As SqlParameter = New SqlParameter("@PartnerID", SqlDbType.Int, 0)
                pPartnerID.Value = PartnerID
                MyCommand.Parameters.Add(pPartnerID)


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

#Region "QLTGND_TUYEN_VC_Lay"
        Public Function QLTGND_TUYEN_VC_Lay(ByVal Id_Tuyen As Integer) As QLTGND_TUYEN_VC_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_TUYEN_VC_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_TUYEN_VC_Chi_Tiet As New QLTGND_TUYEN_VC_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Tuyen As SqlParameter = New SqlParameter("@Id_Tuyen", SqlDbType.Int, 0)
                pId_Tuyen.Value = Id_Tuyen
                MyCommand.Parameters.Add(pId_Tuyen)

                Dim pId_Tuyen_Char As SqlParameter = New SqlParameter("@Id_Tuyen_Char", SqlDbType.VarChar, 20)
                pId_Tuyen_Char.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Tuyen_Char)

                Dim pTen_Tuyen As SqlParameter = New SqlParameter("@Ten_Tuyen", SqlDbType.NVarChar, 200)
                pTen_Tuyen.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTen_Tuyen)

                Dim pId_Dot As SqlParameter = New SqlParameter("@Id_Dot", SqlDbType.Int, 0)
                pId_Dot.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Dot)

                Dim pMa_Tinh_Goc_Char As SqlParameter = New SqlParameter("@Ma_Tinh_Goc_Char", SqlDbType.VarChar, 3)
                pMa_Tinh_Goc_Char.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Tinh_Goc_Char)

                Dim pMa_Tinh_Dich_Char As SqlParameter = New SqlParameter("@Ma_Tinh_Dich_Char", SqlDbType.VarChar, 3)
                pMa_Tinh_Dich_Char.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Tinh_Dich_Char)

                Dim pMa_Tinh_Goc As SqlParameter = New SqlParameter("@Ma_Tinh_Goc", SqlDbType.Int, 0)
                pMa_Tinh_Goc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Tinh_Goc)

                Dim pMa_Tinh_Dich As SqlParameter = New SqlParameter("@Ma_Tinh_Dich", SqlDbType.Int, 0)
                pMa_Tinh_Dich.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Tinh_Dich)

                Dim pId_Huong As SqlParameter = New SqlParameter("@Id_Huong", SqlDbType.Int, 0)
                pId_Huong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Huong)

                Dim pROUD_MAP_ID As SqlParameter = New SqlParameter("@ROUD_MAP_ID", SqlDbType.Int, 0)
                pROUD_MAP_ID.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pROUD_MAP_ID)

                Dim pTYPE As SqlParameter = New SqlParameter("@TYPE", SqlDbType.Int, 0)
                pTYPE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTYPE)

                Dim pPROVINCE As SqlParameter = New SqlParameter("@PROVINCE", SqlDbType.Int, 0)
                pPROVINCE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPROVINCE)

                Dim pPARTNER_ID As SqlParameter = New SqlParameter("@PARTNER_ID", SqlDbType.Int, 0)
                pPARTNER_ID.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPARTNER_ID)

                Dim pTRANSPORT_TYPE_ID As SqlParameter = New SqlParameter("@TRANSPORT_TYPE_ID", SqlDbType.Int, 0)
                pTRANSPORT_TYPE_ID.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTRANSPORT_TYPE_ID)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myQLTGND_TUYEN_VC_Chi_Tiet.Id_Tuyen = Id_Tuyen
                myQLTGND_TUYEN_VC_Chi_Tiet.Id_Tuyen_Char = pId_Tuyen_Char.Value
                myQLTGND_TUYEN_VC_Chi_Tiet.Ten_Tuyen = pTen_Tuyen.Value
                myQLTGND_TUYEN_VC_Chi_Tiet.Id_Dot = pId_Dot.Value
                myQLTGND_TUYEN_VC_Chi_Tiet.Ma_Tinh_Goc_Char = pMa_Tinh_Goc_Char.Value
                myQLTGND_TUYEN_VC_Chi_Tiet.Ma_Tinh_Dich_Char = pMa_Tinh_Dich_Char.Value
                myQLTGND_TUYEN_VC_Chi_Tiet.Ma_Tinh_Goc = pMa_Tinh_Goc.Value
                myQLTGND_TUYEN_VC_Chi_Tiet.Ma_Tinh_Dich = pMa_Tinh_Dich.Value
                myQLTGND_TUYEN_VC_Chi_Tiet.Id_Huong = pId_Huong.Value
                myQLTGND_TUYEN_VC_Chi_Tiet.ROUD_MAP_ID = pROUD_MAP_ID.Value
                myQLTGND_TUYEN_VC_Chi_Tiet.TYPE = pTYPE.Value
                myQLTGND_TUYEN_VC_Chi_Tiet.PROVINCE = pPROVINCE.Value
                myQLTGND_TUYEN_VC_Chi_Tiet.PARTNER_ID = pPARTNER_ID.Value
                myQLTGND_TUYEN_VC_Chi_Tiet.TRANSPORT_TYPE_ID = pTRANSPORT_TYPE_ID.Value

                Return myQLTGND_TUYEN_VC_Chi_Tiet
                'Return myQLTGND_TUYEN_VC_Chi_Tiet

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

#Region "QLTGND_TUYEN_VC_Xoa"
        Public Function QLTGND_TUYEN_VC_Xoa(ByVal Id_Tuyen As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_TUYEN_VC_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 20000
            Dim myQLTGND_TUYEN_VC_Chi_Tiet As New QLTGND_TUYEN_VC_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Tuyen As SqlParameter = New SqlParameter("@Id_Tuyen", SqlDbType.Int, 0)
                pId_Tuyen.Value = Id_Tuyen
                MyCommand.Parameters.Add(pId_Tuyen)


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

#Region "QLTGND_TUYEN_VC_XOA_THEO_MABC"
        ' Ngày tạo: 27/6/08
        ' Input: mae1
        ' Output: true or false
        Public Sub QLTGND_TUYEN_VC_XOA_THEO_MABC(ByVal MABC As String)
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand

            myCommand = New SqlCommand("Delete From QLTGND_Tuyen_Vc where Id_Tuyen In (Select distinct Id_Tuyen From QLTGND_Chang_VC Where (Ma_Bc_Goc=" + MABC + ") OR (Ma_Bc_Dich=" + MABC + "))", myConnection)
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


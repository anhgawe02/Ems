
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "Ip_Duong_Thu_Logitic_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop Ip_Duong_Thu_Logitic_Chi_Tiet
    'Tuong ung voi moi truong trong bang Ip_Duong_Thu_Logitic trong co so du lieu
    '***********************************************************
    Public Class Ip_Duong_Thu_Logitic_Chi_Tiet
        Public Id As Integer
        Public Ma_Bc_Goc As Integer
        Public Ma_Bc_Dich As Integer
        Public Ip_Goc As String
        Public Ten_CSDL_Goc As String
        Public User_CSDL_Goc As String
        Public Pass_CSDL_Goc As String
        Public Ip_Dich As String
        Public Ten_CSDL_Dich As String
        Public User_CSDL_Dich As String
        Public Pass_CSDL_Dich As String
    End Class
#End Region

#Region "Ip_Duong_Thu_Logitic"
    Public Class Ip_Duong_Thu_Logitic
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "Ip_Duong_Thu_Logitic_Lay_Boi_Ma_Bc_Goc"
        Public Function Ip_Duong_Thu_Logitic_Lay_Boi_Ma_Bc_Goc(ByVal Ma_Bc_Goc As Integer) As Ip_Duong_Thu_Logitic_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Ip_Duong_Thu_Logitic_Lay_Boi_Ma_Bc_Goc"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myIp_Duong_Thu_Logitic_Chi_Tiet As New Ip_Duong_Thu_Logitic_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 0)
                pMa_Bc_Goc.Value = Ma_Bc_Goc
                MyCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pId As SqlParameter = New SqlParameter("@Id", SqlDbType.Int, 0)
                pId.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId)

                Dim pMa_Bc_Dich As SqlParameter = New SqlParameter("@Ma_Bc_Dich", SqlDbType.Int, 0)
                pMa_Bc_Dich.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc_Dich)

                Dim pIp_Goc As SqlParameter = New SqlParameter("@Ip_Goc", SqlDbType.VarChar, 50)
                pIp_Goc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pIp_Goc)

                Dim pTen_CSDL_Goc As SqlParameter = New SqlParameter("@Ten_CSDL_Goc", SqlDbType.VarChar, 50)
                pTen_CSDL_Goc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTen_CSDL_Goc)

                Dim pUser_CSDL_Goc As SqlParameter = New SqlParameter("@User_CSDL_Goc", SqlDbType.VarChar, 50)
                pUser_CSDL_Goc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pUser_CSDL_Goc)

                Dim pPass_CSDL_Goc As SqlParameter = New SqlParameter("@Pass_CSDL_Goc", SqlDbType.VarChar, 50)
                pPass_CSDL_Goc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPass_CSDL_Goc)

                Dim pIp_Dich As SqlParameter = New SqlParameter("@Ip_Dich", SqlDbType.VarChar, 50)
                pIp_Dich.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pIp_Dich)

                Dim pTen_CSDL_Dich As SqlParameter = New SqlParameter("@Ten_CSDL_Dich", SqlDbType.VarChar, 50)
                pTen_CSDL_Dich.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTen_CSDL_Dich)

                Dim pUser_CSDL_Dich As SqlParameter = New SqlParameter("@User_CSDL_Dich", SqlDbType.VarChar, 50)
                pUser_CSDL_Dich.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pUser_CSDL_Dich)

                Dim pPass_CSDL_Dich As SqlParameter = New SqlParameter("@Pass_CSDL_Dich", SqlDbType.VarChar, 50)
                pPass_CSDL_Dich.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPass_CSDL_Dich)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myIp_Duong_Thu_Logitic_Chi_Tiet.Ma_Bc_Goc = Ma_Bc_Goc
                myIp_Duong_Thu_Logitic_Chi_Tiet.Id = pId.Value
                myIp_Duong_Thu_Logitic_Chi_Tiet.Ma_Bc_Dich = pMa_Bc_Dich.Value
                myIp_Duong_Thu_Logitic_Chi_Tiet.Ip_Goc = pIp_Goc.Value
                myIp_Duong_Thu_Logitic_Chi_Tiet.Ten_CSDL_Goc = pTen_CSDL_Goc.Value
                myIp_Duong_Thu_Logitic_Chi_Tiet.User_CSDL_Goc = pUser_CSDL_Goc.Value
                myIp_Duong_Thu_Logitic_Chi_Tiet.Pass_CSDL_Goc = pPass_CSDL_Goc.Value
                myIp_Duong_Thu_Logitic_Chi_Tiet.Ip_Dich = pIp_Dich.Value
                myIp_Duong_Thu_Logitic_Chi_Tiet.Ten_CSDL_Dich = pTen_CSDL_Dich.Value
                myIp_Duong_Thu_Logitic_Chi_Tiet.User_CSDL_Dich = pUser_CSDL_Dich.Value
                myIp_Duong_Thu_Logitic_Chi_Tiet.Pass_CSDL_Dich = pPass_CSDL_Dich.Value

                Return myIp_Duong_Thu_Logitic_Chi_Tiet
                'Return myIp_Duong_Thu_Logitic_Chi_Tiet

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

#Region "Ip_Duong_Thu_Logitic_Lay_Boi_Ma_Bc_Goc_Ma_Bc_Dich"
        Public Function Ip_Duong_Thu_Logitic_Lay_Boi_Ma_Bc_Goc_Ma_Bc_Dich(ByVal Ma_Bc_Goc As Integer, ByVal Ma_Bc_Dich As Integer) As Ip_Duong_Thu_Logitic_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Ip_Duong_Thu_Logitic_Lay_Boi_Ma_Bc_Goc_Ma_Bc_Dich"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myIp_Duong_Thu_Logitic_Chi_Tiet As New Ip_Duong_Thu_Logitic_Chi_Tiet

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

                Dim pId As SqlParameter = New SqlParameter("@Id", SqlDbType.Int, 0)
                pId.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId)

                Dim pIp_Goc As SqlParameter = New SqlParameter("@Ip_Goc", SqlDbType.VarChar, 50)
                pIp_Goc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pIp_Goc)

                Dim pTen_CSDL_Goc As SqlParameter = New SqlParameter("@Ten_CSDL_Goc", SqlDbType.VarChar, 50)
                pTen_CSDL_Goc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTen_CSDL_Goc)

                Dim pUser_CSDL_Goc As SqlParameter = New SqlParameter("@User_CSDL_Goc", SqlDbType.VarChar, 50)
                pUser_CSDL_Goc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pUser_CSDL_Goc)

                Dim pPass_CSDL_Goc As SqlParameter = New SqlParameter("@Pass_CSDL_Goc", SqlDbType.VarChar, 50)
                pPass_CSDL_Goc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPass_CSDL_Goc)

                Dim pIp_Dich As SqlParameter = New SqlParameter("@Ip_Dich", SqlDbType.VarChar, 50)
                pIp_Dich.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pIp_Dich)

                Dim pTen_CSDL_Dich As SqlParameter = New SqlParameter("@Ten_CSDL_Dich", SqlDbType.VarChar, 50)
                pTen_CSDL_Dich.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTen_CSDL_Dich)

                Dim pUser_CSDL_Dich As SqlParameter = New SqlParameter("@User_CSDL_Dich", SqlDbType.VarChar, 50)
                pUser_CSDL_Dich.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pUser_CSDL_Dich)

                Dim pPass_CSDL_Dich As SqlParameter = New SqlParameter("@Pass_CSDL_Dich", SqlDbType.VarChar, 50)
                pPass_CSDL_Dich.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPass_CSDL_Dich)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myIp_Duong_Thu_Logitic_Chi_Tiet.Ma_Bc_Goc = Ma_Bc_Goc
                myIp_Duong_Thu_Logitic_Chi_Tiet.Ma_Bc_Dich = Ma_Bc_Dich
                myIp_Duong_Thu_Logitic_Chi_Tiet.Id = pId.Value
                myIp_Duong_Thu_Logitic_Chi_Tiet.Ip_Goc = pIp_Goc.Value
                myIp_Duong_Thu_Logitic_Chi_Tiet.Ten_CSDL_Goc = pTen_CSDL_Goc.Value
                myIp_Duong_Thu_Logitic_Chi_Tiet.User_CSDL_Goc = pUser_CSDL_Goc.Value
                myIp_Duong_Thu_Logitic_Chi_Tiet.Pass_CSDL_Goc = pPass_CSDL_Goc.Value
                myIp_Duong_Thu_Logitic_Chi_Tiet.Ip_Dich = pIp_Dich.Value
                myIp_Duong_Thu_Logitic_Chi_Tiet.Ten_CSDL_Dich = pTen_CSDL_Dich.Value
                myIp_Duong_Thu_Logitic_Chi_Tiet.User_CSDL_Dich = pUser_CSDL_Dich.Value
                myIp_Duong_Thu_Logitic_Chi_Tiet.Pass_CSDL_Dich = pPass_CSDL_Dich.Value

                Return myIp_Duong_Thu_Logitic_Chi_Tiet
                'Return myIp_Duong_Thu_Logitic_Chi_Tiet

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


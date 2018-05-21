
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "Danh_Muc_Hang_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop Danh_Muc_Hang_Chi_Tiet
    'Tuong ung voi moi truong trong bang Danh_Muc_Hang trong co so du lieu
    '***********************************************************
    Public Class Danh_Muc_Hang_Chi_Tiet
        Public Id_Hang_Hoa As String
        Public Ma_Hang_Hoa As String
        Public STT As Integer
        Public Ten_Hang_Hoa As String
        Public Ten_Hang_Hoa_EN As String
        Public Don_Vi_Tinh As Integer
        Public Thue_NK As Double
        Public Thue_VAT As Double
        Public Thue_Dac_Biet As Double
        Public Thue_Tieu_Thu As Double
        Public Thue_Qua_Tang As Double
        Public Thue_Han_Ngach As Double
        Public Thue_Uu_Dai As Double
        Public Nhom_Hang As Integer
        Public Ghi_Chu As String
    End Class
#End Region

#Region "Danh_Muc_Hang"
    Public Class Danh_Muc_Hang
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "Danh_Muc_Hang_Cap_Nhat"
        Public Function Danh_Muc_Hang_Cap_Nhat(ByVal Id_Hang_Hoa As String, ByVal Ma_Hang_Hoa As String, ByVal STT As Integer, ByVal Ten_Hang_Hoa As String, ByVal Ten_Hang_Hoa_EN As String, ByVal Don_Vi_Tinh As Integer, ByVal Thue_NK As Double, ByVal Thue_VAT As Double, ByVal Thue_Dac_Biet As Double, ByVal Thue_Tieu_Thu As Double, ByVal Thue_Qua_Tang As Double, ByVal Thue_Han_Ngach As Double, ByVal Thue_Uu_Dai As Double, ByVal Nhom_Hang As Integer, ByVal Ghi_Chu As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Hang_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDanh_Muc_Hang_Chi_Tiet As New Danh_Muc_Hang_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Hang_Hoa As SqlParameter = New SqlParameter("@Id_Hang_Hoa", SqlDbType.VarChar, 20)
                pId_Hang_Hoa.Value = Id_Hang_Hoa
                MyCommand.Parameters.Add(pId_Hang_Hoa)

                Dim pMa_Hang_Hoa As SqlParameter = New SqlParameter("@Ma_Hang_Hoa", SqlDbType.VarChar, 15)
                pMa_Hang_Hoa.Value = Ma_Hang_Hoa
                MyCommand.Parameters.Add(pMa_Hang_Hoa)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Value = STT
                MyCommand.Parameters.Add(pSTT)

                Dim pTen_Hang_Hoa As SqlParameter = New SqlParameter("@Ten_Hang_Hoa", SqlDbType.NVarChar, 100)
                pTen_Hang_Hoa.Value = Ten_Hang_Hoa
                MyCommand.Parameters.Add(pTen_Hang_Hoa)

                Dim pTen_Hang_Hoa_EN As SqlParameter = New SqlParameter("@Ten_Hang_Hoa_EN", SqlDbType.VarChar, 100)
                pTen_Hang_Hoa_EN.Value = Ten_Hang_Hoa_EN
                MyCommand.Parameters.Add(pTen_Hang_Hoa_EN)

                Dim pDon_Vi_Tinh As SqlParameter = New SqlParameter("@Don_Vi_Tinh", SqlDbType.Int, 0)
                pDon_Vi_Tinh.Value = Don_Vi_Tinh
                MyCommand.Parameters.Add(pDon_Vi_Tinh)

                Dim pThue_NK As SqlParameter = New SqlParameter("@Thue_NK", SqlDbType.Float, 0)
                pThue_NK.Value = Thue_NK
                MyCommand.Parameters.Add(pThue_NK)

                Dim pThue_VAT As SqlParameter = New SqlParameter("@Thue_VAT", SqlDbType.Float, 0)
                pThue_VAT.Value = Thue_VAT
                MyCommand.Parameters.Add(pThue_VAT)

                Dim pThue_Dac_Biet As SqlParameter = New SqlParameter("@Thue_Dac_Biet", SqlDbType.Float, 0)
                pThue_Dac_Biet.Value = Thue_Dac_Biet
                MyCommand.Parameters.Add(pThue_Dac_Biet)

                Dim pThue_Tieu_Thu As SqlParameter = New SqlParameter("@Thue_Tieu_Thu", SqlDbType.Float, 0)
                pThue_Tieu_Thu.Value = Thue_Tieu_Thu
                MyCommand.Parameters.Add(pThue_Tieu_Thu)

                Dim pThue_Qua_Tang As SqlParameter = New SqlParameter("@Thue_Qua_Tang", SqlDbType.Float, 0)
                pThue_Qua_Tang.Value = Thue_Qua_Tang
                MyCommand.Parameters.Add(pThue_Qua_Tang)

                Dim pThue_Han_Ngach As SqlParameter = New SqlParameter("@Thue_Han_Ngach", SqlDbType.Float, 0)
                pThue_Han_Ngach.Value = Thue_Han_Ngach
                MyCommand.Parameters.Add(pThue_Han_Ngach)

                Dim pThue_Uu_Dai As SqlParameter = New SqlParameter("@Thue_Uu_Dai", SqlDbType.Float, 0)
                pThue_Uu_Dai.Value = Thue_Uu_Dai
                MyCommand.Parameters.Add(pThue_Uu_Dai)

                Dim pNhom_Hang As SqlParameter = New SqlParameter("@Nhom_Hang", SqlDbType.Int, 0)
                pNhom_Hang.Value = Nhom_Hang
                MyCommand.Parameters.Add(pNhom_Hang)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)


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

#Region "Danh_Muc_Hang_Cap_Nhat_Them"
        Public Function Danh_Muc_Hang_Cap_Nhat_Them(ByVal Id_Hang_Hoa As String, ByVal Ma_Hang_Hoa As String, ByVal STT As Integer, ByVal Ten_Hang_Hoa As String, ByVal Ten_Hang_Hoa_EN As String, ByVal Don_Vi_Tinh As Integer, ByVal Thue_NK As Double, ByVal Thue_VAT As Double, ByVal Thue_Dac_Biet As Double, ByVal Thue_Tieu_Thu As Double, ByVal Thue_Qua_Tang As Double, ByVal Thue_Han_Ngach As Double, ByVal Thue_Uu_Dai As Double, ByVal Nhom_Hang As Integer, ByVal Ghi_Chu As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Hang_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDanh_Muc_Hang_Chi_Tiet As New Danh_Muc_Hang_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Hang_Hoa As SqlParameter = New SqlParameter("@Id_Hang_Hoa", SqlDbType.VarChar, 20)
                pId_Hang_Hoa.Value = Id_Hang_Hoa
                MyCommand.Parameters.Add(pId_Hang_Hoa)

                Dim pMa_Hang_Hoa As SqlParameter = New SqlParameter("@Ma_Hang_Hoa", SqlDbType.VarChar, 15)
                pMa_Hang_Hoa.Value = Ma_Hang_Hoa
                MyCommand.Parameters.Add(pMa_Hang_Hoa)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Value = STT
                MyCommand.Parameters.Add(pSTT)

                Dim pTen_Hang_Hoa As SqlParameter = New SqlParameter("@Ten_Hang_Hoa", SqlDbType.NVarChar, 100)
                pTen_Hang_Hoa.Value = Ten_Hang_Hoa
                MyCommand.Parameters.Add(pTen_Hang_Hoa)

                Dim pTen_Hang_Hoa_EN As SqlParameter = New SqlParameter("@Ten_Hang_Hoa_EN", SqlDbType.VarChar, 100)
                pTen_Hang_Hoa_EN.Value = Ten_Hang_Hoa_EN
                MyCommand.Parameters.Add(pTen_Hang_Hoa_EN)

                Dim pDon_Vi_Tinh As SqlParameter = New SqlParameter("@Don_Vi_Tinh", SqlDbType.Int, 0)
                pDon_Vi_Tinh.Value = Don_Vi_Tinh
                MyCommand.Parameters.Add(pDon_Vi_Tinh)

                Dim pThue_NK As SqlParameter = New SqlParameter("@Thue_NK", SqlDbType.Float, 0)
                pThue_NK.Value = Thue_NK
                MyCommand.Parameters.Add(pThue_NK)

                Dim pThue_VAT As SqlParameter = New SqlParameter("@Thue_VAT", SqlDbType.Float, 0)
                pThue_VAT.Value = Thue_VAT
                MyCommand.Parameters.Add(pThue_VAT)

                Dim pThue_Dac_Biet As SqlParameter = New SqlParameter("@Thue_Dac_Biet", SqlDbType.Float, 0)
                pThue_Dac_Biet.Value = Thue_Dac_Biet
                MyCommand.Parameters.Add(pThue_Dac_Biet)

                Dim pThue_Tieu_Thu As SqlParameter = New SqlParameter("@Thue_Tieu_Thu", SqlDbType.Float, 0)
                pThue_Tieu_Thu.Value = Thue_Tieu_Thu
                MyCommand.Parameters.Add(pThue_Tieu_Thu)

                Dim pThue_Qua_Tang As SqlParameter = New SqlParameter("@Thue_Qua_Tang", SqlDbType.Float, 0)
                pThue_Qua_Tang.Value = Thue_Qua_Tang
                MyCommand.Parameters.Add(pThue_Qua_Tang)

                Dim pThue_Han_Ngach As SqlParameter = New SqlParameter("@Thue_Han_Ngach", SqlDbType.Float, 0)
                pThue_Han_Ngach.Value = Thue_Han_Ngach
                MyCommand.Parameters.Add(pThue_Han_Ngach)

                Dim pThue_Uu_Dai As SqlParameter = New SqlParameter("@Thue_Uu_Dai", SqlDbType.Float, 0)
                pThue_Uu_Dai.Value = Thue_Uu_Dai
                MyCommand.Parameters.Add(pThue_Uu_Dai)

                Dim pNhom_Hang As SqlParameter = New SqlParameter("@Nhom_Hang", SqlDbType.Int, 0)
                pNhom_Hang.Value = Nhom_Hang
                MyCommand.Parameters.Add(pNhom_Hang)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)


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

#Region "Danh_Muc_Hang_Danh_Sach"

        Public Function Danh_Muc_Hang_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Id_Hang_Hoa
            ' Ma_Hang_Hoa
            ' STT
            ' Ten_Hang_Hoa
            ' Ten_Hang_Hoa_EN
            ' Don_Vi_Tinh
            ' Thue_NK
            ' Thue_VAT
            ' Thue_Dac_Biet
            ' Thue_Tieu_Thu
            ' Thue_Qua_Tang
            ' Thue_Han_Ngach
            ' Thue_Uu_Dai
            ' Nhom_Hang
            ' Ghi_Chu


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Hang_Danh_Sach"
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

#Region "Danh_Muc_Hang_Danh_Sach_Rut_Gon"

        Public Function Danh_Muc_Hang_Danh_Sach_Rut_Gon() As DataSet

            ' The procedure returns these columns:
            ' Id_Hang_Hoa
            ' Ma_Hang_Hoa
            ' Ten_Hang_Hoa


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Hang_Danh_Sach_Rut_Gon"
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

#Region "Danh_Muc_Hang_Lay"
        Public Function Danh_Muc_Hang_Lay(ByVal Id_Hang_Hoa As String) As Danh_Muc_Hang_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Hang_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDanh_Muc_Hang_Chi_Tiet As New Danh_Muc_Hang_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Hang_Hoa As SqlParameter = New SqlParameter("@Id_Hang_Hoa", SqlDbType.VarChar, 20)
                pId_Hang_Hoa.Value = Id_Hang_Hoa
                MyCommand.Parameters.Add(pId_Hang_Hoa)

                Dim pMa_Hang_Hoa As SqlParameter = New SqlParameter("@Ma_Hang_Hoa", SqlDbType.VarChar, 15)
                pMa_Hang_Hoa.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Hang_Hoa)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSTT)

                Dim pTen_Hang_Hoa As SqlParameter = New SqlParameter("@Ten_Hang_Hoa", SqlDbType.NVarChar, 100)
                pTen_Hang_Hoa.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTen_Hang_Hoa)

                Dim pTen_Hang_Hoa_EN As SqlParameter = New SqlParameter("@Ten_Hang_Hoa_EN", SqlDbType.VarChar, 100)
                pTen_Hang_Hoa_EN.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTen_Hang_Hoa_EN)

                Dim pDon_Vi_Tinh As SqlParameter = New SqlParameter("@Don_Vi_Tinh", SqlDbType.Int, 0)
                pDon_Vi_Tinh.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDon_Vi_Tinh)

                Dim pThue_NK As SqlParameter = New SqlParameter("@Thue_NK", SqlDbType.Float, 0)
                pThue_NK.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThue_NK)

                Dim pThue_VAT As SqlParameter = New SqlParameter("@Thue_VAT", SqlDbType.Float, 0)
                pThue_VAT.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThue_VAT)

                Dim pThue_Dac_Biet As SqlParameter = New SqlParameter("@Thue_Dac_Biet", SqlDbType.Float, 0)
                pThue_Dac_Biet.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThue_Dac_Biet)

                Dim pThue_Tieu_Thu As SqlParameter = New SqlParameter("@Thue_Tieu_Thu", SqlDbType.Float, 0)
                pThue_Tieu_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThue_Tieu_Thu)

                Dim pThue_Qua_Tang As SqlParameter = New SqlParameter("@Thue_Qua_Tang", SqlDbType.Float, 0)
                pThue_Qua_Tang.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThue_Qua_Tang)

                Dim pThue_Han_Ngach As SqlParameter = New SqlParameter("@Thue_Han_Ngach", SqlDbType.Float, 0)
                pThue_Han_Ngach.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThue_Han_Ngach)

                Dim pThue_Uu_Dai As SqlParameter = New SqlParameter("@Thue_Uu_Dai", SqlDbType.Float, 0)
                pThue_Uu_Dai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThue_Uu_Dai)

                Dim pNhom_Hang As SqlParameter = New SqlParameter("@Nhom_Hang", SqlDbType.Int, 0)
                pNhom_Hang.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNhom_Hang)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
                pGhi_Chu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGhi_Chu)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myDanh_Muc_Hang_Chi_Tiet.Id_Hang_Hoa = Id_Hang_Hoa
                myDanh_Muc_Hang_Chi_Tiet.Ma_Hang_Hoa = pMa_Hang_Hoa.Value
                myDanh_Muc_Hang_Chi_Tiet.STT = pSTT.Value
                myDanh_Muc_Hang_Chi_Tiet.Ten_Hang_Hoa = pTen_Hang_Hoa.Value
                myDanh_Muc_Hang_Chi_Tiet.Ten_Hang_Hoa_EN = pTen_Hang_Hoa_EN.Value
                myDanh_Muc_Hang_Chi_Tiet.Don_Vi_Tinh = pDon_Vi_Tinh.Value
                myDanh_Muc_Hang_Chi_Tiet.Thue_NK = pThue_NK.Value
                myDanh_Muc_Hang_Chi_Tiet.Thue_VAT = pThue_VAT.Value
                myDanh_Muc_Hang_Chi_Tiet.Thue_Dac_Biet = pThue_Dac_Biet.Value
                myDanh_Muc_Hang_Chi_Tiet.Thue_Tieu_Thu = pThue_Tieu_Thu.Value
                myDanh_Muc_Hang_Chi_Tiet.Thue_Qua_Tang = pThue_Qua_Tang.Value
                myDanh_Muc_Hang_Chi_Tiet.Thue_Han_Ngach = pThue_Han_Ngach.Value
                myDanh_Muc_Hang_Chi_Tiet.Thue_Uu_Dai = pThue_Uu_Dai.Value
                myDanh_Muc_Hang_Chi_Tiet.Nhom_Hang = pNhom_Hang.Value
                myDanh_Muc_Hang_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value

                Return myDanh_Muc_Hang_Chi_Tiet
                'Return myDanh_Muc_Hang_Chi_Tiet

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

#Region "Danh_Muc_Hang_Danh_Sach_Lay_Boi_Don_Vi_Tinh"

        Public Function Danh_Muc_Hang_Danh_Sach_Lay_Boi_Don_Vi_Tinh(ByVal Don_Vi_Tinh As Integer) As DataSet

            ' The procedure returns these columns:
            ' Id_Hang_Hoa
            ' Ma_Hang_Hoa
            ' STT
            ' Ten_Hang_Hoa
            ' Ten_Hang_Hoa_EN
            ' Don_Vi_Tinh
            ' Thue_NK
            ' Thue_VAT
            ' Thue_Dac_Biet
            ' Thue_Tieu_Thu
            ' Thue_Qua_Tang
            ' Thue_Han_Ngach
            ' Thue_Uu_Dai
            ' Nhom_Hang
            ' Ghi_Chu


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Hang_Danh_Sach_Lay_Boi_Don_Vi_Tinh"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pDon_Vi_Tinh As SqlParameter = New SqlParameter("@Don_Vi_Tinh", SqlDbType.Int, 0)
                pDon_Vi_Tinh.Value = Don_Vi_Tinh
                MyCommand.Parameters.Add(pDon_Vi_Tinh)


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

#Region "Danh_Muc_Hang_Danh_Sach_Lay_Boi_Nhom_Hang"

        Public Function Danh_Muc_Hang_Danh_Sach_Lay_Boi_Nhom_Hang(ByVal Nhom_Hang As Integer) As DataSet

            ' The procedure returns these columns:
            ' Id_Hang_Hoa
            ' Ma_Hang_Hoa
            ' STT
            ' Ten_Hang_Hoa
            ' Ten_Hang_Hoa_EN
            ' Don_Vi_Tinh
            ' Thue_NK
            ' Thue_VAT
            ' Thue_Dac_Biet
            ' Thue_Tieu_Thu
            ' Thue_Qua_Tang
            ' Thue_Han_Ngach
            ' Thue_Uu_Dai
            ' Nhom_Hang
            ' Ghi_Chu


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Hang_Danh_Sach_Lay_Boi_Nhom_Hang"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pNhom_Hang As SqlParameter = New SqlParameter("@Nhom_Hang", SqlDbType.Int, 0)
                pNhom_Hang.Value = Nhom_Hang
                MyCommand.Parameters.Add(pNhom_Hang)


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

#Region "Danh_Muc_Hang_Danh_Sach_Rut_Gon_Lay_Boi_Nhom_Hang"

        Public Function Danh_Muc_Hang_Danh_Sach_Rut_Gon_Lay_Boi_Nhom_Hang(ByVal nhom_Hang As Integer) As DataSet

            ' The procedure returns these columns:
            ' Id_Hang_Hoa
            ' Ma_Hang_Hoa
            ' Ten_Hang_Hoa


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Hang_Danh_Sach_Rut_Gon_Lay_Boi_Nhom_Hang"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Nhom_Hang", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, nhom_Hang))

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

#Region "Danh_Muc_Hang_Danh_Sach_Lay_Boi_Ma_Hang_Hoa"

        Public Function Danh_Muc_Hang_Danh_Sach_Lay_Boi_Ma_Hang_Hoa(ByVal Ma_Hang_Hoa As String) As DataSet

            ' The procedure returns these columns:
            ' Id_Hang_Hoa
            ' Ma_Hang_Hoa
            ' STT
            ' Ten_Hang_Hoa
            ' Ten_Hang_Hoa_EN
            ' Don_Vi_Tinh
            ' Thue_NK
            ' Thue_VAT
            ' Thue_Dac_Biet
            ' Thue_Tieu_Thu
            ' Thue_Qua_Tang
            ' Thue_Han_Ngach
            ' Thue_Uu_Dai
            ' Nhom_Hang
            ' Ghi_Chu


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Hang_Danh_Sach_Lay_Boi_Ma_Hang_Hoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pMa_Hang_Hoa As SqlParameter = New SqlParameter("@Ma_Hang_Hoa", SqlDbType.VarChar, 15)
                pMa_Hang_Hoa.Value = Ma_Hang_Hoa
                MyCommand.Parameters.Add(pMa_Hang_Hoa)


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

#Region "Danh_Muc_Hang_Lay_Theo_Ten_Hang_Hoa_La_Tai_Lieu"
        Public Function Danh_Muc_Hang_Lay_Theo_Ten_Hang_Hoa_La_Tai_Lieu(ByVal Ten_Hang_Hoa_EN As String) As Danh_Muc_Hang_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Hang_Lay_Theo_Ten_Hang_Hoa_La_Tai_Lieu"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDanh_Muc_Hang_Chi_Tiet As New Danh_Muc_Hang_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters
                Dim pTen_Hang_Hoa_EN As SqlParameter = New SqlParameter("@Ten_Hang_Hoa_EN", SqlDbType.VarChar, 100)
                pTen_Hang_Hoa_EN.Value = Ten_Hang_Hoa_EN
                MyCommand.Parameters.Add(pTen_Hang_Hoa_EN)

                Dim pId_Hang_Hoa As SqlParameter = New SqlParameter("@Id_Hang_Hoa", SqlDbType.VarChar, 20)
                pId_Hang_Hoa.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Hang_Hoa)

                Dim pMa_Hang_Hoa As SqlParameter = New SqlParameter("@Ma_Hang_Hoa", SqlDbType.VarChar, 15)
                pMa_Hang_Hoa.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Hang_Hoa)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSTT)

                Dim pTen_Hang_Hoa As SqlParameter = New SqlParameter("@Ten_Hang_Hoa", SqlDbType.NVarChar, 100)
                pTen_Hang_Hoa.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTen_Hang_Hoa)

                Dim pDon_Vi_Tinh As SqlParameter = New SqlParameter("@Don_Vi_Tinh", SqlDbType.Int, 0)
                pDon_Vi_Tinh.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDon_Vi_Tinh)

                Dim pThue_NK As SqlParameter = New SqlParameter("@Thue_NK", SqlDbType.Float, 0)
                pThue_NK.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThue_NK)

                Dim pThue_VAT As SqlParameter = New SqlParameter("@Thue_VAT", SqlDbType.Float, 0)
                pThue_VAT.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThue_VAT)

                Dim pThue_Dac_Biet As SqlParameter = New SqlParameter("@Thue_Dac_Biet", SqlDbType.Float, 0)
                pThue_Dac_Biet.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThue_Dac_Biet)

                Dim pThue_Tieu_Thu As SqlParameter = New SqlParameter("@Thue_Tieu_Thu", SqlDbType.Float, 0)
                pThue_Tieu_Thu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThue_Tieu_Thu)

                Dim pThue_Qua_Tang As SqlParameter = New SqlParameter("@Thue_Qua_Tang", SqlDbType.Float, 0)
                pThue_Qua_Tang.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThue_Qua_Tang)

                Dim pThue_Han_Ngach As SqlParameter = New SqlParameter("@Thue_Han_Ngach", SqlDbType.Float, 0)
                pThue_Han_Ngach.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThue_Han_Ngach)

                Dim pThue_Uu_Dai As SqlParameter = New SqlParameter("@Thue_Uu_Dai", SqlDbType.Float, 0)
                pThue_Uu_Dai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThue_Uu_Dai)

                Dim pNhom_Hang As SqlParameter = New SqlParameter("@Nhom_Hang", SqlDbType.Int, 0)
                pNhom_Hang.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNhom_Hang)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
                pGhi_Chu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGhi_Chu)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myDanh_Muc_Hang_Chi_Tiet.Id_Hang_Hoa = pId_Hang_Hoa.Value
                myDanh_Muc_Hang_Chi_Tiet.Ma_Hang_Hoa = pMa_Hang_Hoa.Value
                myDanh_Muc_Hang_Chi_Tiet.STT = pSTT.Value
                myDanh_Muc_Hang_Chi_Tiet.Ten_Hang_Hoa = pTen_Hang_Hoa.Value
                myDanh_Muc_Hang_Chi_Tiet.Ten_Hang_Hoa_EN = Ten_Hang_Hoa_EN
                myDanh_Muc_Hang_Chi_Tiet.Don_Vi_Tinh = pDon_Vi_Tinh.Value
                myDanh_Muc_Hang_Chi_Tiet.Thue_NK = pThue_NK.Value
                myDanh_Muc_Hang_Chi_Tiet.Thue_VAT = pThue_VAT.Value
                myDanh_Muc_Hang_Chi_Tiet.Thue_Dac_Biet = pThue_Dac_Biet.Value
                myDanh_Muc_Hang_Chi_Tiet.Thue_Tieu_Thu = pThue_Tieu_Thu.Value
                myDanh_Muc_Hang_Chi_Tiet.Thue_Qua_Tang = pThue_Qua_Tang.Value
                myDanh_Muc_Hang_Chi_Tiet.Thue_Han_Ngach = pThue_Han_Ngach.Value
                myDanh_Muc_Hang_Chi_Tiet.Thue_Uu_Dai = pThue_Uu_Dai.Value
                myDanh_Muc_Hang_Chi_Tiet.Nhom_Hang = pNhom_Hang.Value
                myDanh_Muc_Hang_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value

                Return myDanh_Muc_Hang_Chi_Tiet
                'Return myDanh_Muc_Hang_Chi_Tiet

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

#Region "Danh_Muc_Hang_Them"
        Public Function Danh_Muc_Hang_Them(ByVal Id_Hang_Hoa As String, ByVal Ma_Hang_Hoa As String, ByVal STT As Integer, ByVal Ten_Hang_Hoa As String, ByVal Ten_Hang_Hoa_EN As String, ByVal Don_Vi_Tinh As Integer, ByVal Thue_NK As Double, ByVal Thue_VAT As Double, ByVal Thue_Dac_Biet As Double, ByVal Thue_Tieu_Thu As Double, ByVal Thue_Qua_Tang As Double, ByVal Thue_Han_Ngach As Double, ByVal Thue_Uu_Dai As Double, ByVal Nhom_Hang As Integer, ByVal Ghi_Chu As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Hang_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDanh_Muc_Hang_Chi_Tiet As New Danh_Muc_Hang_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Hang_Hoa As SqlParameter = New SqlParameter("@Id_Hang_Hoa", SqlDbType.VarChar, 20)
                pId_Hang_Hoa.Value = Id_Hang_Hoa
                MyCommand.Parameters.Add(pId_Hang_Hoa)

                Dim pMa_Hang_Hoa As SqlParameter = New SqlParameter("@Ma_Hang_Hoa", SqlDbType.VarChar, 15)
                pMa_Hang_Hoa.Value = Ma_Hang_Hoa
                MyCommand.Parameters.Add(pMa_Hang_Hoa)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 0)
                pSTT.Value = STT
                MyCommand.Parameters.Add(pSTT)

                Dim pTen_Hang_Hoa As SqlParameter = New SqlParameter("@Ten_Hang_Hoa", SqlDbType.NVarChar, 100)
                pTen_Hang_Hoa.Value = Ten_Hang_Hoa
                MyCommand.Parameters.Add(pTen_Hang_Hoa)

                Dim pTen_Hang_Hoa_EN As SqlParameter = New SqlParameter("@Ten_Hang_Hoa_EN", SqlDbType.VarChar, 100)
                pTen_Hang_Hoa_EN.Value = Ten_Hang_Hoa_EN
                MyCommand.Parameters.Add(pTen_Hang_Hoa_EN)

                Dim pDon_Vi_Tinh As SqlParameter = New SqlParameter("@Don_Vi_Tinh", SqlDbType.Int, 0)
                pDon_Vi_Tinh.Value = Don_Vi_Tinh
                MyCommand.Parameters.Add(pDon_Vi_Tinh)

                Dim pThue_NK As SqlParameter = New SqlParameter("@Thue_NK", SqlDbType.Float, 0)
                pThue_NK.Value = Thue_NK
                MyCommand.Parameters.Add(pThue_NK)

                Dim pThue_VAT As SqlParameter = New SqlParameter("@Thue_VAT", SqlDbType.Float, 0)
                pThue_VAT.Value = Thue_VAT
                MyCommand.Parameters.Add(pThue_VAT)

                Dim pThue_Dac_Biet As SqlParameter = New SqlParameter("@Thue_Dac_Biet", SqlDbType.Float, 0)
                pThue_Dac_Biet.Value = Thue_Dac_Biet
                MyCommand.Parameters.Add(pThue_Dac_Biet)

                Dim pThue_Tieu_Thu As SqlParameter = New SqlParameter("@Thue_Tieu_Thu", SqlDbType.Float, 0)
                pThue_Tieu_Thu.Value = Thue_Tieu_Thu
                MyCommand.Parameters.Add(pThue_Tieu_Thu)

                Dim pThue_Qua_Tang As SqlParameter = New SqlParameter("@Thue_Qua_Tang", SqlDbType.Float, 0)
                pThue_Qua_Tang.Value = Thue_Qua_Tang
                MyCommand.Parameters.Add(pThue_Qua_Tang)

                Dim pThue_Han_Ngach As SqlParameter = New SqlParameter("@Thue_Han_Ngach", SqlDbType.Float, 0)
                pThue_Han_Ngach.Value = Thue_Han_Ngach
                MyCommand.Parameters.Add(pThue_Han_Ngach)

                Dim pThue_Uu_Dai As SqlParameter = New SqlParameter("@Thue_Uu_Dai", SqlDbType.Float, 0)
                pThue_Uu_Dai.Value = Thue_Uu_Dai
                MyCommand.Parameters.Add(pThue_Uu_Dai)

                Dim pNhom_Hang As SqlParameter = New SqlParameter("@Nhom_Hang", SqlDbType.Int, 0)
                pNhom_Hang.Value = Nhom_Hang
                MyCommand.Parameters.Add(pNhom_Hang)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)


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

#Region "Danh_Muc_Hang_Xoa"
        Public Function Danh_Muc_Hang_Xoa(ByVal Id_Hang_Hoa As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Hang_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDanh_Muc_Hang_Chi_Tiet As New Danh_Muc_Hang_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Hang_Hoa As SqlParameter = New SqlParameter("@Id_Hang_Hoa", SqlDbType.VarChar, 20)
                pId_Hang_Hoa.Value = Id_Hang_Hoa
                MyCommand.Parameters.Add(pId_Hang_Hoa)


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

#Region "Danh_Muc_Hang_Xoa_Boi_Don_Vi_Tinh"
        Public Function Danh_Muc_Hang_Xoa_Boi_Don_Vi_Tinh(ByVal Don_Vi_Tinh As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Hang_Xoa_Boi_Don_Vi_Tinh"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDanh_Muc_Hang_Chi_Tiet As New Danh_Muc_Hang_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pDon_Vi_Tinh As SqlParameter = New SqlParameter("@Don_Vi_Tinh", SqlDbType.Int, 0)
                pDon_Vi_Tinh.Value = Don_Vi_Tinh
                MyCommand.Parameters.Add(pDon_Vi_Tinh)


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

#Region "Danh_Muc_Hang_Xoa_Boi_Nhom_Hang"
        Public Function Danh_Muc_Hang_Xoa_Boi_Nhom_Hang(ByVal Nhom_Hang As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Hang_Xoa_Boi_Nhom_Hang"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDanh_Muc_Hang_Chi_Tiet As New Danh_Muc_Hang_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pNhom_Hang As SqlParameter = New SqlParameter("@Nhom_Hang", SqlDbType.Int, 0)
                pNhom_Hang.Value = Nhom_Hang
                MyCommand.Parameters.Add(pNhom_Hang)


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

#Region "Danh_Muc_Hang_Hoa_Lay_STT_Cho_Loai_Hang_Trung_Ma"
        Public Function Danh_Muc_Hang_Hoa_Lay_STT_Cho_Loai_Hang_Trung_Ma(ByVal ma_Hang_Hoa As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Danh_Muc_Hang_Hoa_Lay_STT_Cho_Loai_Hang_Trung_Ma"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try

                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Ma_Hang_Hoa", SqlDbType.VarChar, 15, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, ma_Hang_Hoa))
                MyCommand.Parameters.Add(New SqlParameter("@STT", SqlDbType.Int, 0, ParameterDirection.Output, True, 10, 0, "", DataRowVersion.Current, DBNull.Value))

                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                MyCommand.ExecuteNonQuery()
                'Get output values
                Return MyCommand.Parameters(1).Value
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

#Region "Danh_Muc_Hang_Kiem_Tra_Ton_Tai_Ten_Hang"
        ' N?i dung: Ki?m tra s? t?n t?i
        ' Output: count(*)
        Public Function Danh_Muc_Hang_Kiem_Tra_Ton_Tai_Ten_Hang(ByVal Ten_Hang_Hoa As String) As Boolean
            Try
                ' T?o d?i tu?ng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_Hang_Kiem_Tra_Ton_Tai_Ten_Hang", myConnection)

                ' S? d?ng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào th? t?c            
                Dim pTen_Hang_Hoa As SqlParameter = New SqlParameter("@Ten_Hang_Hoa", SqlDbType.NVarChar, 100)
                pTen_Hang_Hoa.Value = Ten_Hang_Hoa
                myCommand.Parameters.Add(pTen_Hang_Hoa)

                Dim pSo_Dong As SqlParameter = New SqlParameter("@So_Dong", SqlDbType.Int, 4)
                pSo_Dong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSo_Dong)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()

                Return IIf(pSo_Dong.Value = 0, False, True)
            Catch ex As Exception
                Console.Write(ex.ToString)
                Return False
            End Try
        End Function
#End Region

    End Class
#End Region
End Namespace


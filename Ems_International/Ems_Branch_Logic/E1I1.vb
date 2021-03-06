
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS

#Region "E1I1_Chi_Tiet"
    Public Class E1I1_Chi_Tiet
        '*******************************************************
        ' Mỗi thuộc tính của lớp E1I1_Chi_Tiet
        ' tương ứng với mộ trường của bảng E1I1 trong cơ sở dữ liệu SQL
        '
        '*******************************************************
        Public Id_E1 As String
        Public Ma_E1 As String
        Public Ngay_Dong As Decimal
        Public Ma_Bc_Khai_Thac As Decimal
        Public Ma_Bc As Decimal
        Public Ma_Bc_Noi_Tinh As Decimal
        Public Phan_Loai_Duong_Thu As Decimal
        Public So_Chuyen_Thu As Decimal
        Public Loai_Chuyen_Thu As String
        Public Tui_So As Decimal
        Public Nuoc_Nhan As String
        Public Nuoc_Tra As String
        Public Ma_Bc_Goc As Decimal
        Public Ma_Bc_Tra As Decimal
        Public Khoi_Luong As Decimal
        Public Phan_Loai As String
    End Class
#End Region

#Region "E1I1"
    Public Class E1I1
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub


#Region "Cap_Nhat_Them_E1I1"
        Public Function Cap_Nhat_Them_E1I1(ByVal id_E1 As String, ByVal ma_E1 As String, ByVal ngay_Dong As Integer, ByVal ma_Bc_Khai_Thac As Integer, ByVal ma_Bc As Integer, ByVal ma_Bc_Noi_Tinh As Integer, ByVal phan_Loai_Duong_Thu As Integer, ByVal so_Chuyen_Thu As Integer, ByVal loai_Chuyen_Thu As String, ByVal tui_So As Integer, ByVal nuoc_Nhan As String, ByVal nuoc_Tra As String, ByVal ma_Bc_Goc As Integer, ByVal ma_Bc_Tra As Integer, ByVal khoi_Luong As Integer, ByVal phan_Loai As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1I1_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_E1", SqlDbType.VarChar, 48, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_E1))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, ma_E1))
                MyCommand.Parameters.Add(New SqlParameter("@Ngay_Dong", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ngay_Dong))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Bc_Khai_Thac))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Bc))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc_Noi_Tinh", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Bc_Noi_Tinh))
                MyCommand.Parameters.Add(New SqlParameter("@Phan_Loai_Duong_Thu", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, phan_Loai_Duong_Thu))
                MyCommand.Parameters.Add(New SqlParameter("@So_Chuyen_Thu", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, so_Chuyen_Thu))
                MyCommand.Parameters.Add(New SqlParameter("@Loai_Chuyen_Thu", SqlDbType.VarChar, 2, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, loai_Chuyen_Thu))
                MyCommand.Parameters.Add(New SqlParameter("@Tui_So", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, tui_So))
                MyCommand.Parameters.Add(New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, nuoc_Nhan))
                MyCommand.Parameters.Add(New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, nuoc_Tra))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Bc_Goc))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Bc_Tra))
                MyCommand.Parameters.Add(New SqlParameter("@Khoi_Luong", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, khoi_Luong))
                MyCommand.Parameters.Add(New SqlParameter("@Phan_Loai", SqlDbType.VarChar, 1, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, phan_Loai))

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

#Region "Lấy dữ liệu từ ngày đến ngày"
        Public Function Lay_Du_Lieu_Tu_Ngay_Den_Ngay(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer) As DataSet
            'Dim MyCommand As SqlCommand = New SqlCommand
            'MyCommand.CommandText = "E1I1_Cap_Nhat_Them"
            'MyCommand.CommandType = CommandType.StoredProcedure
            'Dim MyConnection As New SqlConnection(ConnectionString)

            'MyCommand.Parameters.Add(New SqlParameter("@Id_E1", SqlDbType.VarChar, 48, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_E1))

            '' Sử dụng Store Procedure
            'myCommand.CommandType = CommandType.StoredProcedure
            '' Thêm các Parameters vào thủ tục
            'Dim pMa_Bc_Chu As SqlParameter = New SqlParameter("@Ma_Bc_Chu", SqlDbType.VarChar, 6)
            'pMa_Bc_Chu.Value = Ma_Bc_Chu
            'MyCommand.Parameters.Add(pMa_Bc_Chu)

            'Dim pMa_Bc_Chu As SqlParameter = New SqlParameter("", SqlDbType, 12)
        End Function
#End Region
    End Class
#End Region

End Namespace


Imports System
Imports System.Data
Imports System.Data.OracleClient
Namespace EMS
#Region "Ntinh_Oracle_Chi_Tiet"
    Public Class Ntinh_Oracle_Chi_Tiet
        '*******************************************************
        ' Mỗi thuộc tính của lớp Ntinh_Oracle_Chi_Tiet
        ' tương ứng với mộ trường của bảng Ntinh trong cơ sở dữ liệu Oracle
        '
        '*******************************************************
        Public Mabc As Decimal
        Public Tenbc As String
        Public Taito As Decimal
        Public Lienlac As String
        Public Madv As String
        Public Bta As Decimal
        Public Huong As Decimal
        Public Tenhuong As String
        Public Loai As Decimal
    End Class
#End Region

#Region "Ntinh_Oracle"
    Public Class Ntinh_Oracle
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Danh sách mã bưu cục trong bảng Ntinh trên Oracle"
        Public Function Ntinh_Danh_Sach() As DataSet
            Dim myConnection As OracleConnection = New OracleConnection(ConnectionString)
            Dim MyCommand As New OracleCommand
            Dim myDataSet As New DataSet
            Try
                MyCommand.Connection = myConnection
                MyCommand.CommandText = "Ntinh_Danh_Sach"
                MyCommand.CommandType = CommandType.StoredProcedure

                Dim pNtinh_Curr As OracleParameter = New OracleParameter("v_Ntinh_Curr", OracleType.Cursor)
                pNtinh_Curr.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNtinh_Curr)

                myConnection.Open()
                Dim myAdapter As OracleDataAdapter = New OracleDataAdapter(MyCommand)
                'MyCommand.ExecuteNonQuery()
                'Dim dataAdapter As New OracleClient.OracleDataAdapter(MyCommand)
                myAdapter.Fill(myDataSet, "Ntinh_Danh_Sach")
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            Finally
                'Close the connection and Dispose.
                myConnection.Close()
                MyCommand.Dispose()
            End Try
        End Function
#End Region
    End Class
#End Region
End Namespace

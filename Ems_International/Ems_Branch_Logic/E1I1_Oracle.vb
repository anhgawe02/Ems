Imports System
Imports System.Data
Imports System.Data.OracleClient

Namespace EMS
#Region "E1I1_Oracle_Chi_Tiet"
    Public Class E1I1_Oracle_Chi_Tiet
        '*******************************************************
        ' Mỗi thuộc tính của lớp E1I1_Oracle_Chi_Tiet
        ' tương ứng với mộ trường của bảng E1I1 trong cơ sở dữ liệu Oracle
        '
        '*******************************************************
        Public MAE1 As String
        Public MATT As String
        Public MAVTBC As Decimal
        Public MANCTRA As String
        Public MABCTRA As Decimal
        Public MANCNHAN As String
        Public MABCNHAN As Decimal
        Public KHOILUONG As Decimal
        Public PHANLOAI As Decimal
        Public CUOCCS As Decimal
        Public CUOCDV As Decimal
        Public TRANGTHAI As String
        Public DIACHI As String
        Public MABC As Decimal
        Public CHTHU As Decimal
        Public TUISO As Decimal
        Public NGAY As Decimal
        Public GIO As Decimal
        Public STT As Decimal
        Public MABC_KT As Decimal
        Public DAGUI As Decimal
        Public CHK As Decimal
        Public LOAI As Decimal
        Public MABC_CH As Decimal
        Public NGAYKT As Decimal
        Public CAKT As Decimal
        Public NGAY_DEN As Decimal
        Public SOKIEN As Decimal
        Public NGUOINHAN As String
    End Class
#End Region

#Region "E1I1_Oracle"
    Public Class E1I1_Oracle
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "Lấy dữ liệu trong bảng E1I1 trên Oracle để truyền về máy chủ SQL"
        Public Function E1I1_Oracle_EMS_QT_Tu_Ngay_Den_Ngay(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_E1 As String) As DataSet
            Dim myConnection As OracleConnection = New OracleConnection(ConnectionString)
            Dim MyCommand As New OracleCommand
            Dim myDataSet As New DataSet
            Try
                MyCommand.Connection = myConnection
                MyCommand.CommandText = "E1I1_EMS_QT"
                MyCommand.CommandType = CommandType.StoredProcedure

                Dim pTu_Ngay As OracleParameter = New OracleParameter("v_tu_ngay", OracleType.Number)
                pTu_Ngay.Value = Tu_Ngay
                MyCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As OracleParameter = New OracleParameter("v_den_ngay", OracleType.Number)
                pDen_Ngay.Value = Den_Ngay
                MyCommand.Parameters.Add(pDen_Ngay)

                Dim pMa_Bc_Khai_Thac As OracleParameter = New OracleParameter("v_Ma_Bc_Khai_Thac", OracleType.Number)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_E1 As OracleParameter = New OracleParameter("v_Ma_E1", OracleType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                MyCommand.Parameters.Add(pMa_E1)

                Dim pEMS_QT_Curr As OracleParameter = New OracleParameter("v_EMS_QT_Curr", OracleType.Cursor)
                pEMS_QT_Curr.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pEMS_QT_Curr)

                myConnection.Open()
                Dim myAdapter As OracleDataAdapter = New OracleDataAdapter(MyCommand)
                'MyCommand.ExecuteNonQuery()
                'Dim dataAdapter As New OracleClient.OracleDataAdapter(MyCommand)
                myAdapter.Fill(myDataSet, "E1I1_EMS_QT")
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

#Region "Lấy dữ liệu trong bảng E1I1_DS trên Oracle để truyền về máy chủ SQL"
        Public Function E1I1_DS_Oracle_EMS_QT_Tu_Ngay_Den_Ngay(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Bc As Integer) As DataSet
            Dim myConnection As OracleConnection = New OracleConnection(ConnectionString)
            Dim MyCommand As New OracleCommand
            Dim myDataSet As New DataSet
            Try
                MyCommand.Connection = myConnection
                MyCommand.CommandText = "E1I1_DS_EMS_QT"
                MyCommand.CommandType = CommandType.StoredProcedure

                Dim pTu_Ngay As OracleParameter = New OracleParameter("v_tu_ngay", OracleType.Number)
                pTu_Ngay.Value = Tu_Ngay
                MyCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As OracleParameter = New OracleParameter("v_den_ngay", OracleType.Number)
                pDen_Ngay.Value = Den_Ngay
                MyCommand.Parameters.Add(pDen_Ngay)

                Dim pMa_Bc_Khai_Thac As OracleParameter = New OracleParameter("v_Ma_Bc_Khai_Thac", OracleType.Number)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Bc As OracleParameter = New OracleParameter("v_Ma_Bc", OracleType.Number)
                pMa_Bc.Value = Ma_Bc
                MyCommand.Parameters.Add(pMa_Bc)

                Dim pEMS_QT_Curr As OracleParameter = New OracleParameter("v_EMS_QT_Curr", OracleType.Cursor)
                pEMS_QT_Curr.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pEMS_QT_Curr)

                myConnection.Open()
                Dim myAdapter As OracleDataAdapter = New OracleDataAdapter(MyCommand)
                'MyCommand.ExecuteNonQuery()
                'Dim dataAdapter As New OracleClient.OracleDataAdapter(MyCommand)
                myAdapter.Fill(myDataSet, "E1I1_DS_EMS_QT")
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


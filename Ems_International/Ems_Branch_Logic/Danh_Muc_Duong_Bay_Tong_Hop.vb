
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Danh_Muc_Duong_Bay_Tong_Hop_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Danh_Muc_Duong_Bay_Tong_Hop
    ' tương ứng với mộ trường của bảng Danh_Muc_Duong_Bay_Tong_Hop trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Danh_Muc_Duong_Bay_Tong_Hop_Chi_Tiet
        Public Id_Duong_Bay As String
        Public Id_Duong_Thu As String
        Public Loai_van_chuyen As Integer
        Public So_hieu As String
        Public Noi_GUI As String
        Public Noi_NHAN As String
        Public BC_GUI As String
        Public BC_NHAN As String
        Public GIO_KHOI_HANH As Integer
        Public GIO_DEN As Integer
        Public QUA_NGAY As Boolean
        Public QUA_GIANG As Boolean

    End Class
#End Region

#Region "Danh_Muc_Duong_Bay_Tong_Hop"
    Public Class Danh_Muc_Duong_Bay_Tong_Hop
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

    End Class
#End Region
End Namespace




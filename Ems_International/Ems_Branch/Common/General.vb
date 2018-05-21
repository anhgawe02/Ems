Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports System.Data
Imports System.Data.OracleClient
Imports System.Data.SqlClient
Imports System.Math
Imports Ems_International_Logic.EMS
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction

Module General
    'Các hàm dùng chung được sử dụng trong chương trình
    '
#Region "Khai báo biến toàn cục"
    'Khối lượng bưu phẩm max
    'Số ngày kiểm tra E1 trùng
    'Số tiền cước tối đa


#End Region

#Region "Khai thác"
    Public Function Kiem_Tra_Lac_Huong1(ByVal Nuoc_Tra As String, ByVal Ma_Bc_Tra As String, ByVal myDuong_Thu_Di_Chi_Tiet As Duong_Thu_Di_Chi_Tiet) As Boolean
        Try
            'Kiểm tra bưu phẩm đóng đi lạc hướng so với xác nhận
            'Sai lệch về đường thư so với bưu cục trả và nước trả
            Return False 'Bưu phẩm lạc hướng
            If myDuong_Thu_Di_Chi_Tiet.Chuyen_Tiep = True Then
                'Không kiểm tra lạc hướng
                Return True 'Đúng hướng
            Else
                'Tìm nước đến của đường thư đi
                Dim myDanh_Muc_Bc As New Danh_Muc_BC(GConnectionString)
                Dim myDanh_Muc_Bc_Chi_Tiet As New Danh_Muc_BC_Chi_Tiet
                myDanh_Muc_Bc_Chi_Tiet = myDanh_Muc_Bc.Lay(myDuong_Thu_Di_Chi_Tiet.Ma_Bc)
                If myDanh_Muc_Bc_Chi_Tiet.Ma_Nc.ToUpper <> Nuoc_Tra.ToUpper Then
                    'Bưu phẩm lạc hướng
                    Return False
                Else
                    If myDanh_Muc_Bc_Chi_Tiet.Ma_BC <> Ma_Bc_Tra Then
                        Return False
                    Else
                        Return True
                    End If
                End If
            End If
        Catch ex As Exception
            Console.Write(ex.ToString)
        End Try
    End Function

    Public Function Kiem_Tra_Chuyen_Hoan() As Boolean
        'Kiểm tra điều kiện chuyển hoàn của bưu phẩm
        'Nước nhận với đường thư đi trùng nhau
        'Bưu cục nhận với bưu cục trả trùng nhau


    End Function
#End Region

#Region "Init Function"
    Public Function GetKeyValues(ByVal KeysIn As String, ByVal Ma_Bc_Khai_Thac As Integer) As String

    End Function

    Public Function SetKeyValues(ByVal KeysIn As String, ByVal Ma_Bc_Khai_Thac As Integer) As String

    End Function
#End Region

End Module

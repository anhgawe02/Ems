
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "Event_Viewer_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop Event_Viewer_Chi_Tiet
    'Tuong ung voi moi truong trong bang Event_Viewer trong co so du lieu
    '***********************************************************
    Public Class Event_Viewer_Chi_Tiet
        Public Log_Id As Integer
        Public Ma_Bc_Khai_Thac As Integer
        Public Su_Kien As Integer
        Public Bo_Phan As Integer
        Public Doi_Tuong As Integer
        Public Ngay_Sever As Integer
        Public Gio_Sever As Integer
        Public Ma_Nhan_Vien As Integer
        Public Ten_Nhan_Vien As String
        Public Ip_May_Tinh As String
        Public Chi_Tiet_Truoc As String
        Public Chi_Tiet_Sau As String
        Public Ngay_He_Thong As Integer
        Public Gio_He_Thong As Integer
    End Class
#End Region

#Region "Event_Viewer"
    Public Class Event_Viewer
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "Event_Viewer_Cap_Nhat"
        Public Function Event_Viewer_Cap_Nhat(ByVal Log_Id As Integer, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Su_Kien As Integer, ByVal Bo_Phan As Integer, ByVal Doi_Tuong As Integer, ByVal Ngay_Sever As Integer, ByVal Gio_Sever As Integer, ByVal Ma_Nhan_Vien As Integer, ByVal Ten_Nhan_Vien As String, ByVal Ip_May_Tinh As String, ByVal Chi_Tiet_Truoc As String, ByVal Chi_Tiet_Sau As String, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Event_Viewer_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myEvent_Viewer_Chi_Tiet As New Event_Viewer_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pLog_Id As SqlParameter = New SqlParameter("@Log_Id", SqlDbType.Int, 0)
                pLog_Id.Value = Log_Id
                MyCommand.Parameters.Add(pLog_Id)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pSu_Kien As SqlParameter = New SqlParameter("@Su_Kien", SqlDbType.Int, 0)
                pSu_Kien.Value = Su_Kien
                MyCommand.Parameters.Add(pSu_Kien)

                Dim pBo_Phan As SqlParameter = New SqlParameter("@Bo_Phan", SqlDbType.Int, 0)
                pBo_Phan.Value = Bo_Phan
                MyCommand.Parameters.Add(pBo_Phan)

                Dim pDoi_Tuong As SqlParameter = New SqlParameter("@Doi_Tuong", SqlDbType.Int, 0)
                pDoi_Tuong.Value = Doi_Tuong
                MyCommand.Parameters.Add(pDoi_Tuong)

                Dim pNgay_Sever As SqlParameter = New SqlParameter("@Ngay_Sever", SqlDbType.Int, 0)
                pNgay_Sever.Value = Ngay_Sever
                MyCommand.Parameters.Add(pNgay_Sever)

                Dim pGio_Sever As SqlParameter = New SqlParameter("@Gio_Sever", SqlDbType.Int, 0)
                pGio_Sever.Value = Gio_Sever
                MyCommand.Parameters.Add(pGio_Sever)

                Dim pMa_Nhan_Vien As SqlParameter = New SqlParameter("@Ma_Nhan_Vien", SqlDbType.Int, 0)
                pMa_Nhan_Vien.Value = Ma_Nhan_Vien
                MyCommand.Parameters.Add(pMa_Nhan_Vien)

                Dim pTen_Nhan_Vien As SqlParameter = New SqlParameter("@Ten_Nhan_Vien", SqlDbType.NVarChar, 100)
                pTen_Nhan_Vien.Value = Ten_Nhan_Vien
                MyCommand.Parameters.Add(pTen_Nhan_Vien)

                Dim pIp_May_Tinh As SqlParameter = New SqlParameter("@Ip_May_Tinh", SqlDbType.VarChar, 50)
                pIp_May_Tinh.Value = Ip_May_Tinh
                MyCommand.Parameters.Add(pIp_May_Tinh)

                Dim pChi_Tiet_Truoc As SqlParameter = New SqlParameter("@Chi_Tiet_Truoc", SqlDbType.NVarChar, 200)
                pChi_Tiet_Truoc.Value = Chi_Tiet_Truoc
                MyCommand.Parameters.Add(pChi_Tiet_Truoc)

                Dim pChi_Tiet_Sau As SqlParameter = New SqlParameter("@Chi_Tiet_Sau", SqlDbType.NVarChar, 200)
                pChi_Tiet_Sau.Value = Chi_Tiet_Sau
                MyCommand.Parameters.Add(pChi_Tiet_Sau)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Value = Ngay_He_Thong
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Value = Gio_He_Thong
                MyCommand.Parameters.Add(pGio_He_Thong)


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

#Region "Event_Viewer_Cap_Nhat_Them"
        Public Function Event_Viewer_Cap_Nhat_Them(ByVal Log_Id As Integer, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Su_Kien As Integer, ByVal Bo_Phan As Integer, ByVal Doi_Tuong As Integer, ByVal Ngay_Sever As Integer, ByVal Gio_Sever As Integer, ByVal Ma_Nhan_Vien As Integer, ByVal Ten_Nhan_Vien As String, ByVal Ip_May_Tinh As String, ByVal Chi_Tiet_Truoc As String, ByVal Chi_Tiet_Sau As String, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Event_Viewer_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myEvent_Viewer_Chi_Tiet As New Event_Viewer_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pLog_Id As SqlParameter = New SqlParameter("@Log_Id", SqlDbType.Int, 0)
                pLog_Id.Value = Log_Id
                MyCommand.Parameters.Add(pLog_Id)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pSu_Kien As SqlParameter = New SqlParameter("@Su_Kien", SqlDbType.Int, 0)
                pSu_Kien.Value = Su_Kien
                MyCommand.Parameters.Add(pSu_Kien)

                Dim pBo_Phan As SqlParameter = New SqlParameter("@Bo_Phan", SqlDbType.Int, 0)
                pBo_Phan.Value = Bo_Phan
                MyCommand.Parameters.Add(pBo_Phan)

                Dim pDoi_Tuong As SqlParameter = New SqlParameter("@Doi_Tuong", SqlDbType.Int, 0)
                pDoi_Tuong.Value = Doi_Tuong
                MyCommand.Parameters.Add(pDoi_Tuong)

                Dim pNgay_Sever As SqlParameter = New SqlParameter("@Ngay_Sever", SqlDbType.Int, 0)
                pNgay_Sever.Value = Ngay_Sever
                MyCommand.Parameters.Add(pNgay_Sever)

                Dim pGio_Sever As SqlParameter = New SqlParameter("@Gio_Sever", SqlDbType.Int, 0)
                pGio_Sever.Value = Gio_Sever
                MyCommand.Parameters.Add(pGio_Sever)

                Dim pMa_Nhan_Vien As SqlParameter = New SqlParameter("@Ma_Nhan_Vien", SqlDbType.Int, 0)
                pMa_Nhan_Vien.Value = Ma_Nhan_Vien
                MyCommand.Parameters.Add(pMa_Nhan_Vien)

                Dim pTen_Nhan_Vien As SqlParameter = New SqlParameter("@Ten_Nhan_Vien", SqlDbType.NVarChar, 100)
                pTen_Nhan_Vien.Value = Ten_Nhan_Vien
                MyCommand.Parameters.Add(pTen_Nhan_Vien)

                Dim pIp_May_Tinh As SqlParameter = New SqlParameter("@Ip_May_Tinh", SqlDbType.VarChar, 50)
                pIp_May_Tinh.Value = Ip_May_Tinh
                MyCommand.Parameters.Add(pIp_May_Tinh)

                Dim pChi_Tiet_Truoc As SqlParameter = New SqlParameter("@Chi_Tiet_Truoc", SqlDbType.NVarChar, 200)
                pChi_Tiet_Truoc.Value = Chi_Tiet_Truoc
                MyCommand.Parameters.Add(pChi_Tiet_Truoc)

                Dim pChi_Tiet_Sau As SqlParameter = New SqlParameter("@Chi_Tiet_Sau", SqlDbType.NVarChar, 200)
                pChi_Tiet_Sau.Value = Chi_Tiet_Sau
                MyCommand.Parameters.Add(pChi_Tiet_Sau)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Value = Ngay_He_Thong
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Value = Gio_He_Thong
                MyCommand.Parameters.Add(pGio_He_Thong)


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

#Region "Event_Viewer_Danh_Sach"

        Public Function Event_Viewer_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Log_Id
            ' Ma_Bc_Khai_Thac
            ' Su_Kien
            ' Bo_Phan
            ' Doi_Tuong
            ' Ngay_Sever
            ' Gio_Sever
            ' Ma_Nhan_Vien
            ' Ten_Nhan_Vien
            ' Ip_May_Tinh
            ' Chi_Tiet_Truoc
            ' Chi_Tiet_Sau
            ' Ngay_He_Thong
            ' Gio_He_Thong


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Event_Viewer_Danh_Sach"
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

#Region "Event_Viewer_Lay"
        Public Function Event_Viewer_Lay(ByVal Log_Id As Integer) As Event_Viewer_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Event_Viewer_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myEvent_Viewer_Chi_Tiet As New Event_Viewer_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pLog_Id As SqlParameter = New SqlParameter("@Log_Id", SqlDbType.Int, 0)
                pLog_Id.Value = Log_Id
                MyCommand.Parameters.Add(pLog_Id)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pSu_Kien As SqlParameter = New SqlParameter("@Su_Kien", SqlDbType.Int, 0)
                pSu_Kien.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSu_Kien)

                Dim pBo_Phan As SqlParameter = New SqlParameter("@Bo_Phan", SqlDbType.Int, 0)
                pBo_Phan.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pBo_Phan)

                Dim pDoi_Tuong As SqlParameter = New SqlParameter("@Doi_Tuong", SqlDbType.Int, 0)
                pDoi_Tuong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pDoi_Tuong)

                Dim pNgay_Sever As SqlParameter = New SqlParameter("@Ngay_Sever", SqlDbType.Int, 0)
                pNgay_Sever.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_Sever)

                Dim pGio_Sever As SqlParameter = New SqlParameter("@Gio_Sever", SqlDbType.Int, 0)
                pGio_Sever.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_Sever)

                Dim pMa_Nhan_Vien As SqlParameter = New SqlParameter("@Ma_Nhan_Vien", SqlDbType.Int, 0)
                pMa_Nhan_Vien.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Nhan_Vien)

                Dim pTen_Nhan_Vien As SqlParameter = New SqlParameter("@Ten_Nhan_Vien", SqlDbType.NVarChar, 100)
                pTen_Nhan_Vien.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTen_Nhan_Vien)

                Dim pIp_May_Tinh As SqlParameter = New SqlParameter("@Ip_May_Tinh", SqlDbType.VarChar, 50)
                pIp_May_Tinh.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pIp_May_Tinh)

                Dim pChi_Tiet_Truoc As SqlParameter = New SqlParameter("@Chi_Tiet_Truoc", SqlDbType.NVarChar, 200)
                pChi_Tiet_Truoc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pChi_Tiet_Truoc)

                Dim pChi_Tiet_Sau As SqlParameter = New SqlParameter("@Chi_Tiet_Sau", SqlDbType.NVarChar, 200)
                pChi_Tiet_Sau.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pChi_Tiet_Sau)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGio_He_Thong)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myEvent_Viewer_Chi_Tiet.Log_Id = Log_Id
                myEvent_Viewer_Chi_Tiet.Ma_Bc_Khai_Thac = pMa_Bc_Khai_Thac.Value
                myEvent_Viewer_Chi_Tiet.Su_Kien = pSu_Kien.Value
                myEvent_Viewer_Chi_Tiet.Bo_Phan = pBo_Phan.Value
                myEvent_Viewer_Chi_Tiet.Doi_Tuong = pDoi_Tuong.Value
                myEvent_Viewer_Chi_Tiet.Ngay_Sever = pNgay_Sever.Value
                myEvent_Viewer_Chi_Tiet.Gio_Sever = pGio_Sever.Value
                myEvent_Viewer_Chi_Tiet.Ma_Nhan_Vien = pMa_Nhan_Vien.Value
                myEvent_Viewer_Chi_Tiet.Ten_Nhan_Vien = pTen_Nhan_Vien.Value
                myEvent_Viewer_Chi_Tiet.Ip_May_Tinh = pIp_May_Tinh.Value
                myEvent_Viewer_Chi_Tiet.Chi_Tiet_Truoc = pChi_Tiet_Truoc.Value
                myEvent_Viewer_Chi_Tiet.Chi_Tiet_Sau = pChi_Tiet_Sau.Value
                myEvent_Viewer_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myEvent_Viewer_Chi_Tiet.Gio_He_Thong = pGio_He_Thong.Value

                Return myEvent_Viewer_Chi_Tiet
                'Return myEvent_Viewer_Chi_Tiet

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

#Region "Event_Viewer_Them"
        Public Function Event_Viewer_Them(ByVal Ma_Bc_Khai_Thac As Integer, ByVal Su_Kien As Integer, ByVal Bo_Phan As Integer, ByVal Doi_Tuong As Integer, ByVal Ngay_Sever As Integer, ByVal Gio_Sever As Integer, ByVal Ma_Nhan_Vien As Integer, ByVal Ten_Nhan_Vien As String, ByVal Ip_May_Tinh As String, ByVal Chi_Tiet_Truoc As String, ByVal Chi_Tiet_Sau As String, ByVal Ngay_He_Thong As Integer, ByVal Gio_He_Thong As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Event_Viewer_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myEvent_Viewer_Chi_Tiet As New Event_Viewer_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try

                'Define the parameters

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pSu_Kien As SqlParameter = New SqlParameter("@Su_Kien", SqlDbType.Int, 0)
                pSu_Kien.Value = Su_Kien
                MyCommand.Parameters.Add(pSu_Kien)

                Dim pBo_Phan As SqlParameter = New SqlParameter("@Bo_Phan", SqlDbType.Int, 0)
                pBo_Phan.Value = Bo_Phan
                MyCommand.Parameters.Add(pBo_Phan)

                Dim pDoi_Tuong As SqlParameter = New SqlParameter("@Doi_Tuong", SqlDbType.Int, 0)
                pDoi_Tuong.Value = Doi_Tuong
                MyCommand.Parameters.Add(pDoi_Tuong)

                Dim pNgay_Sever As SqlParameter = New SqlParameter("@Ngay_Sever", SqlDbType.Int, 0)
                pNgay_Sever.Value = Ngay_Sever
                MyCommand.Parameters.Add(pNgay_Sever)

                Dim pGio_Sever As SqlParameter = New SqlParameter("@Gio_Sever", SqlDbType.Int, 0)
                pGio_Sever.Value = Gio_Sever
                MyCommand.Parameters.Add(pGio_Sever)

                Dim pMa_Nhan_Vien As SqlParameter = New SqlParameter("@Ma_Nhan_Vien", SqlDbType.Int, 0)
                pMa_Nhan_Vien.Value = Ma_Nhan_Vien
                MyCommand.Parameters.Add(pMa_Nhan_Vien)

                Dim pTen_Nhan_Vien As SqlParameter = New SqlParameter("@Ten_Nhan_Vien", SqlDbType.NVarChar, 100)
                pTen_Nhan_Vien.Value = Ten_Nhan_Vien
                MyCommand.Parameters.Add(pTen_Nhan_Vien)

                Dim pIp_May_Tinh As SqlParameter = New SqlParameter("@Ip_May_Tinh", SqlDbType.VarChar, 50)
                pIp_May_Tinh.Value = Ip_May_Tinh
                MyCommand.Parameters.Add(pIp_May_Tinh)

                Dim pChi_Tiet_Truoc As SqlParameter = New SqlParameter("@Chi_Tiet_Truoc", SqlDbType.NVarChar, 200)
                pChi_Tiet_Truoc.Value = Chi_Tiet_Truoc
                MyCommand.Parameters.Add(pChi_Tiet_Truoc)

                Dim pChi_Tiet_Sau As SqlParameter = New SqlParameter("@Chi_Tiet_Sau", SqlDbType.NVarChar, 200)
                pChi_Tiet_Sau.Value = Chi_Tiet_Sau
                MyCommand.Parameters.Add(pChi_Tiet_Sau)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 0)
                pNgay_He_Thong.Value = Ngay_He_Thong
                MyCommand.Parameters.Add(pNgay_He_Thong)

                Dim pGio_He_Thong As SqlParameter = New SqlParameter("@Gio_He_Thong", SqlDbType.Int, 0)
                pGio_He_Thong.Value = Gio_He_Thong
                MyCommand.Parameters.Add(pGio_He_Thong)

                Dim pLog_Id As SqlParameter = New SqlParameter("@Log_Id", SqlDbType.Int, 0)
                pLog_Id.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pLog_Id)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                MyCommand.ExecuteNonQuery()
                'Output Value is Log_Id

                Return pLog_Id.Value
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

#Region "Event_Viewer_Xoa"
        Public Function Event_Viewer_Xoa(ByVal Log_Id As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Event_Viewer_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myEvent_Viewer_Chi_Tiet As New Event_Viewer_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pLog_Id As SqlParameter = New SqlParameter("@Log_Id", SqlDbType.Int, 0)
                pLog_Id.Value = Log_Id
                MyCommand.Parameters.Add(pLog_Id)


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

#Region "Event_Viewer_Danh_Sach_Tim_Kiem"

        Public Function Event_Viewer_Danh_Sach_Tim_Kiem(ByVal kieu_Tim_Kiem As Integer, ByVal ma_Bc_Khai_Thac As Integer, ByVal bo_Phan As Integer, ByVal doi_Tuong As Integer, ByVal tu_Ngay As Integer, ByVal den_Ngay As Integer) As DataSet

            ' The procedure returns these columns:
            ' Log_Id
            ' Ma_Bc_Khai_Thac
            ' Ten_Bc_Khai_Thac
            ' Su_Kien
            ' Bo_Phan
            ' Doi_Tuong
            ' Ngay_Sever
            ' Gio_Sever
            ' Ma_Nhan_Vien
            ' Ten_Nhan_Vien
            ' Ip_May_Tinh
            ' Chi_Tiet_Truoc
            ' Chi_Tiet_Sau
            ' Ngay_He_Thong
            ' Gio_He_Thong


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Event_Viewer_Danh_Sach_Tim_Kiem"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Kieu_Tim_Kiem", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, kieu_Tim_Kiem))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Bc_Khai_Thac))
                MyCommand.Parameters.Add(New SqlParameter("@Bo_Phan", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, bo_Phan))
                MyCommand.Parameters.Add(New SqlParameter("@Doi_Tuong", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, doi_Tuong))
                MyCommand.Parameters.Add(New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, tu_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Den_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, den_Ngay))

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

#Region "Event_Viewer_Cap_Nhat_Event_Close_E2"
        Public Function Event_Viewer_Cap_Nhat_Event_Close_E2(ByVal Log_Id As Integer, ByVal Su_Kien As Integer, ByVal Bo_Phan As Integer, ByVal Chi_Tiet_Sau As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Event_Viewer_Cap_Nhat_Event_Close_E2"
            MyCommand.CommandType = CommandType.StoredProcedure

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pLog_Id As SqlParameter = New SqlParameter("@Log_Id", SqlDbType.Int, 0)
                pLog_Id.Value = Log_Id
                MyCommand.Parameters.Add(pLog_Id)

                Dim pSu_Kien As SqlParameter = New SqlParameter("@Su_Kien", SqlDbType.Int, 0)
                pSu_Kien.Value = Su_Kien
                MyCommand.Parameters.Add(pSu_Kien)

                Dim pBo_Phan As SqlParameter = New SqlParameter("@Bo_Phan", SqlDbType.Int, 0)
                pBo_Phan.Value = Bo_Phan
                MyCommand.Parameters.Add(pBo_Phan)

                Dim pChi_Tiet_Sau As SqlParameter = New SqlParameter("@Chi_Tiet_Sau", SqlDbType.NVarChar, 200)
                pChi_Tiet_Sau.Value = Chi_Tiet_Sau
                MyCommand.Parameters.Add(pChi_Tiet_Sau)

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


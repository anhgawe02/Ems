Imports System
Imports System.Data
Imports System.Data.SqlClient

Namespace EMS
    Public Class EDI_detail
        Public ID_CHUYEN_THU As String
        Public ID_DUONG_THU As String
        Public INTREF As String
        Public NGAY As Integer
        Public GIO As Integer
        Public MESSAGE As String
        Public SEND As Integer
        Public MESSAGE_TYPE As String
    End Class
#Region "EDI"
    Public Class EDI
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

        '***********************************************************
        'Moi thuoc tinh thuoc lop PREDES_Chi_Tiet
        'Tuong ung voi moi truong trong bang PREDES trong co so du lieu
        '***********************************************************
#Region "Get_EDI"
        Public Function Get_EDI(ByVal ID_CHUYEN_THU As String) As EDI_detail
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Get_EDI"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myEDI_detail As New EDI_detail

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try
                'Define the parameters
                Dim pID_CHUYEN_THU As SqlParameter = New SqlParameter("@ID_CHUYEN_THU", SqlDbType.VarChar, 28)
                pID_CHUYEN_THU.Value = ID_CHUYEN_THU
                MyCommand.Parameters.Add(pID_CHUYEN_THU)

                Dim pID_DUONG_THU As SqlParameter = New SqlParameter("@ID_DUONG_THU", SqlDbType.VarChar, 14)
                pID_DUONG_THU.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pID_DUONG_THU)

                Dim pINTREF As SqlParameter = New SqlParameter("@INTREF", SqlDbType.VarChar, 14)
                pINTREF.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pINTREF)

                Dim pNGAY As SqlParameter = New SqlParameter("@NGAY", SqlDbType.Int, 0)
                pNGAY.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNGAY)

                Dim pGIO As SqlParameter = New SqlParameter("@GIO", SqlDbType.Int, 0)
                pGIO.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGIO)

                Dim pMESSAGE As SqlParameter = New SqlParameter("@MESSAGE", SqlDbType.VarChar, 50)
                pMESSAGE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMESSAGE)

                Dim pSEND As SqlParameter = New SqlParameter("@SEND", SqlDbType.Int, 0)
                pSEND.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSEND)

                Dim pMESSAGE_TYPE As SqlParameter = New SqlParameter("@MESSAGE_TYPE", SqlDbType.VarChar, 6)
                pMESSAGE_TYPE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMESSAGE_TYPE)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myEDI_detail.ID_CHUYEN_THU = ID_CHUYEN_THU
                myEDI_detail.ID_DUONG_THU = pID_DUONG_THU.Value
                myEDI_detail.INTREF = pINTREF.Value
                myEDI_detail.NGAY = pNGAY.Value
                myEDI_detail.GIO = pGIO.Value
                myEDI_detail.MESSAGE = pMESSAGE.Value
                myEDI_detail.SEND = pSEND.Value
                myEDI_detail.MESSAGE_TYPE = pMESSAGE.Value

                Return myEDI_detail
                'Return myPREDES_Chi_Tiet

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
#Region "Cập nhật EDI"
        Public Sub Add_EDI(ByVal Id_Chuyen_thu As String, ByVal Id_Duong_thu As String, ByVal INTREF As String, ByVal NGAY As Int32, ByVal GIO As Int32, ByVal MESSAGE As String, ByVal MESSAGE_TYPE As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("ADDING_EDI", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Chuyen_thu As SqlParameter = New SqlParameter("@Id_Chuyen_thu", SqlDbType.VarChar, 28)
                pId_Chuyen_thu.Value = Id_Chuyen_thu
                myCommand.Parameters.Add(pId_Chuyen_thu)

                Dim pId_Duong_thu As SqlParameter = New SqlParameter("@Id_Duong_thu", SqlDbType.VarChar, 14)
                pId_Duong_thu.Value = Id_Duong_thu
                myCommand.Parameters.Add(pId_Duong_thu)

                Dim pINTREF As SqlParameter = New SqlParameter("@INTREF", SqlDbType.VarChar, 14)
                pINTREF.Value = INTREF
                myCommand.Parameters.Add(pINTREF)

                Dim pNGAY As SqlParameter = New SqlParameter("@NGAY", SqlDbType.Int)
                pNGAY.Value = NGAY
                myCommand.Parameters.Add(pNGAY)

                Dim pGIO As SqlParameter = New SqlParameter("@GIO", SqlDbType.Int)
                pGIO.Value = GIO
                myCommand.Parameters.Add(pGIO)

                Dim pMESSAGE As SqlParameter = New SqlParameter("@MESSAGE", SqlDbType.VarChar, 50)
                pMESSAGE.Value = MESSAGE
                myCommand.Parameters.Add(pMESSAGE)

                Dim pSEND As SqlParameter = New SqlParameter("@SEND", SqlDbType.Int)
                pSEND.Value = 0
                myCommand.Parameters.Add(pSEND)

                Dim pMESSAGE_TYPE As SqlParameter = New SqlParameter("@MESSAGE_TYPE", SqlDbType.VarChar, 6)
                pMESSAGE_TYPE.Value = MESSAGE_TYPE
                myCommand.Parameters.Add(pMESSAGE_TYPE)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()

            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub

#End Region

    End Class
#End Region
End Namespace

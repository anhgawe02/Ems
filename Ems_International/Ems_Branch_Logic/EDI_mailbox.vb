Imports System
Imports System.Data
Imports System.Data.SqlClient

Namespace EMS
#Region "IPMC_MaNC"
    Public Class IPMC_MaNC
        Public IPMC As String
        Public Ma_NC As String
    End Class
#End Region

#Region "MailBox"
    Public Class MailBox
        Public EDI_PREFIX As String
        Public EDI_CODE As String
        Public S_EVENT_MAILBOX As String
        Public EVENT_MAILBOX As String
        Public EVENT_SEND As Int32
        Public EVENT_INTREF As Int32
        Public BAG_MAILBOX As String
        Public S_BAG_MAILBOX As String
        Public PREDES_SEND As Int32
        Public PREDES_INTREF As Int32
        Public RESDES_SEND As Int32
        Public RESDES_INTREF As Int32
    End Class
#End Region
    Public Class EDI_mailbox
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "Lấy thông tin IPMC và Ma_NC"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Danh_muc_BC
        ' Input: Id_Phan_Quyen
        ' Output: Phan_Quyen_Chi_Tiet
        Public Function Get_IPMC_MaNC(ByVal id_duong_thu As String, ByVal Message_type As String) As IPMC_MaNC
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim s_sql As String
                If Message_type = "PREDES" Then
                    s_sql = "Get_Predes_Ma_Nuoc"
                End If
                If Message_type = "RESDES" Then
                    s_sql = "Get_Resdes_Ma_Nuoc"
                End If

                Dim myCommand As SqlCommand = New SqlCommand(s_sql, myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_duong_thu As SqlParameter = New SqlParameter("@id_duong_thu", SqlDbType.VarChar, 14)
                pId_duong_thu.Value = id_duong_thu
                myCommand.Parameters.Add(pId_duong_thu)

                Dim pIPMC As SqlParameter = New SqlParameter("@IPMC", SqlDbType.VarChar, 6)
                pIPMC.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pIPMC)

                Dim pMa_Nc As SqlParameter = New SqlParameter("@Ma_NC", SqlDbType.VarChar, 2)
                pMa_Nc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Nc)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myIPMC_MaNC As IPMC_MaNC = New IPMC_MaNC
                myIPMC_MaNC.IPMC = pIPMC.Value.ToString()
                myIPMC_MaNC.Ma_NC = pMa_Nc.Value.ToString()

                Return myIPMC_MaNC
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Lấy thông tin EDI_MAIL_BOX"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Danh_muc_BC
        ' Input: Id_Phan_Quyen
        ' Output: Phan_Quyen_Chi_Tiet
        Public Function Get_MailBox(ByVal EDI_CODE As String) As MailBox
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Get_EDI_Mail_Box", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pEDI_CODE As SqlParameter = New SqlParameter("@EDI_CODE", SqlDbType.VarChar, 2)
                pEDI_CODE.Value = EDI_CODE
                myCommand.Parameters.Add(pEDI_CODE)

                Dim pS_EVENT_MAILBOX As SqlParameter = New SqlParameter("@S_EVENT_MAILBOX", SqlDbType.VarChar, 5)
                pS_EVENT_MAILBOX.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pS_EVENT_MAILBOX)

                Dim pEVENT_MAILBOX As SqlParameter = New SqlParameter("@EVENT_MAILBOX", SqlDbType.VarChar, 5)
                pEVENT_MAILBOX.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pEVENT_MAILBOX)

                Dim pEVENT_SEND As SqlParameter = New SqlParameter("@EVENT_SEND", SqlDbType.Int)
                pEVENT_SEND.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pEVENT_SEND)

                Dim pEVENT_INTREF As SqlParameter = New SqlParameter("@EVENT_INTREF", SqlDbType.Int)
                pEVENT_INTREF.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pEVENT_INTREF)

                Dim pBAGS_MAILBOX As SqlParameter = New SqlParameter("@BAG_MAILBOX", SqlDbType.VarChar, 5)
                pBAGS_MAILBOX.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pBAGS_MAILBOX)

                Dim pS_BAGS_MAILBOX As SqlParameter = New SqlParameter("@S_BAG_MAILBOX", SqlDbType.VarChar, 5)
                pS_BAGS_MAILBOX.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pS_BAGS_MAILBOX)

                Dim pPREDES_SEND As SqlParameter = New SqlParameter("@PREDES_SEND", SqlDbType.Int)
                pPREDES_SEND.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pPREDES_SEND)

                Dim pPREDES_INTREF As SqlParameter = New SqlParameter("@PREDES_INTREF", SqlDbType.Int)
                pPREDES_INTREF.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pPREDES_INTREF)

                Dim pRESDES_SEND As SqlParameter = New SqlParameter("@RESDES_SEND", SqlDbType.Int)
                pRESDES_SEND.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pRESDES_SEND)

                Dim pRESDES_INTREF As SqlParameter = New SqlParameter("@RESDES_INTREF", SqlDbType.Int)
                pRESDES_INTREF.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pRESDES_INTREF)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myMailBox As MailBox = New MailBox
                With myMailBox
                    .S_EVENT_MAILBOX = pS_EVENT_MAILBOX.Value.ToString()
                    .EVENT_MAILBOX = pEVENT_MAILBOX.Value.ToString()
                    .EVENT_SEND = Int32.Parse(pEVENT_SEND.Value.ToString())
                    .EVENT_INTREF = Int32.Parse(pEVENT_INTREF.Value.ToString())
                    .BAG_MAILBOX = pBAGS_MAILBOX.Value.ToString()
                    .S_BAG_MAILBOX = pS_BAGS_MAILBOX.Value.ToString()
                    .PREDES_SEND = Int32.Parse(pPREDES_SEND.Value.ToString())
                    .PREDES_INTREF = Int32.Parse(pPREDES_INTREF.Value.ToString())
                    .RESDES_SEND = Int32.Parse(pRESDES_SEND.Value.ToString())
                    .RESDES_INTREF = Int32.Parse(pRESDES_INTREF.Value.ToString())
                End With
                Return myMailBox
            Catch ex As Exception
                Console.Write(ex.ToString())

            End Try
        End Function
#End Region

#Region "Lấy IPMC"
        Public Function Get_IPMC_Code(ByVal MaBC As Int32) As String
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Get_IPMC_Code", myConnection)
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pMaBC As SqlParameter = New SqlParameter("@MaBC", SqlDbType.Int)
                pMaBC.Value = MaBC
                myCommand.Parameters.Add(pMaBC)

                Dim pIPMC As SqlParameter = New SqlParameter("@IPMC", SqlDbType.VarChar, 6)
                pIPMC.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pIPMC)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()

                Return pIPMC.Value.ToString()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function

#End Region

#Region "Cập nhật Resdes INTREF"
        Public Sub Update_Resdes_Intref(ByVal EDI_CODE As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Update_Resdes_Intref", myConnection)

                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pEDI_CODE As SqlParameter = New SqlParameter("@EDI_CODE", SqlDbType.VarChar, 6)
                pEDI_CODE.Value = EDI_CODE
                myCommand.Parameters.Add(pEDI_CODE)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()

            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try

        End Sub
#End Region

#Region "Cập nhật INTREF"
        Public Sub Update_EDI_Intref(ByVal EDI_CODE As String, ByVal Message_type As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Update_EDI_Intref", myConnection)

                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pEDI_CODE As SqlParameter = New SqlParameter("@EDI_CODE", SqlDbType.VarChar, 6)
                pEDI_CODE.Value = EDI_CODE
                myCommand.Parameters.Add(pEDI_CODE)

                Dim pMessage_type As SqlParameter = New SqlParameter("@Message_type", SqlDbType.VarChar, 6)
                pMessage_type.Value = Message_type
                myCommand.Parameters.Add(pMessage_type)

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
End Namespace

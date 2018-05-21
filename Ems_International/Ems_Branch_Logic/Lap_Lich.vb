Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
    Public Class Lap_Lich
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lap_Lich_Sao_Luu"
        Public Sub Lap_Lich_Sao_Luu(ByVal FreqType As Integer, ByVal FreqInterval As Integer, ByVal FreqRecurrenceFactor As Integer, ByVal FreqSubDayType As Integer, ByVal FreqSubDayInterval As Integer, ByVal ActiveStartDate As Integer, ByVal ActiveEndDate As Integer, ByVal ActiveStartTime As Integer, ByVal ActiveEndTime As Integer, ByVal Dest As String, ByVal FileDest As String)
            Try
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Lich_Sao_Luu", myConnection)

                ' Mark the Command as a SPROC
                myCommand.CommandType = CommandType.StoredProcedure
                ' Add Parameters to SPROC
                Dim pFreqType As SqlParameter = New SqlParameter("@FreqType", SqlDbType.Int)
                pFreqType.Value = FreqType
                myCommand.Parameters.Add(pFreqType)

                Dim pFreqInterval As SqlParameter = New SqlParameter("@FreqInterval", SqlDbType.Int)
                pFreqInterval.Value = FreqInterval
                myCommand.Parameters.Add(pFreqInterval)

                Dim pFreqRecurrenceFactor As SqlParameter = New SqlParameter("@FreqRecurrenceFactor", SqlDbType.Int)
                pFreqRecurrenceFactor.Value = FreqRecurrenceFactor
                myCommand.Parameters.Add(pFreqRecurrenceFactor)

                Dim pFreqSubDayType As SqlParameter = New SqlParameter("@FreqSubDayType", SqlDbType.Int)
                pFreqSubDayType.Value = FreqSubDayType
                myCommand.Parameters.Add(pFreqSubDayType)

                Dim pFreqSubDayInterval As SqlParameter = New SqlParameter("@FreqSubDayInterval", SqlDbType.Int)
                pFreqSubDayInterval.Value = FreqSubDayInterval
                myCommand.Parameters.Add(pFreqSubDayInterval)

                Dim pActiveStartDate As SqlParameter = New SqlParameter("@ActiveStartDate", SqlDbType.Int)
                pActiveStartDate.Value = ActiveStartDate
                myCommand.Parameters.Add(pActiveStartDate)

                Dim pActiveEndDate As SqlParameter = New SqlParameter("@ActiveEndDate", SqlDbType.Int)
                pActiveEndDate.Value = ActiveEndDate
                myCommand.Parameters.Add(pActiveEndDate)

                Dim pActiveStartTime As SqlParameter = New SqlParameter("@ActiveStartTime", SqlDbType.Int)
                pActiveStartTime.Value = ActiveStartTime
                myCommand.Parameters.Add(pActiveStartTime)

                Dim pActiveEndTime As SqlParameter = New SqlParameter("@ActiveEndTime", SqlDbType.Int)
                pActiveEndTime.Value = ActiveEndTime
                myCommand.Parameters.Add(pActiveEndTime)

                Dim pFileName As SqlParameter = New SqlParameter("@FileName", SqlDbType.NVarChar, 400)
                pFileName.Value = "BACKUP DATABASE HDKT TO  DISK =N'" + Dest + "\" + FileDest + "' WITH  INIT ,  NOUNLOAD ,  NAME = N'HDKT_Backup',  NOSKIP ,  STATS = 10,  NOFORMAT"
                myCommand.Parameters.Add(pFileName)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
            Catch ex As Exception

            Finally

            End Try
        End Sub
#End Region
#Region "Phuc_Hoi_Du_Lieu"
        Public Sub Phuc_Hoi_Du_Lieu(ByVal sdbName As String, ByVal SourceFile As String)
            Try
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                myConnection.ChangeDatabase("master")
                ' Create Instance of Connection and Command Object            	
                Dim myCommand As SqlCommand = New SqlCommand(" alter database " & sdbName & " SET single_user with rollback immediate", myConnection)
                ' Mark the Command as a SPROC
                myCommand.CommandType = CommandType.Text
                myConnection.Open()
                myCommand.ExecuteNonQuery()

                myCommand = New SqlCommand("sp_detach_db", myConnection)
                myCommand.CommandType = CommandType.StoredProcedure
                myCommand.Parameters.Add("@dbname", SqlDbType.NVarChar, 30)
                myCommand.Parameters("@dbname").Direction = ParameterDirection.Input
                myCommand.Parameters("@dbname").Value = sdbName

                myCommand.Parameters.Add("@skipchecks", SqlDbType.NVarChar, 5)
                myCommand.Parameters("@skipchecks").Direction = ParameterDirection.Input
                myCommand.Parameters("@skipchecks").Value = "true"
                myCommand.ExecuteNonQuery()
                'restore co so du lieu moi
                myCommand = New SqlCommand("RESTORE DATABASE " & sdbName & " FROM DISK=N'" & SourceFile & "' WITH REPLACE", myConnection)
                myCommand.CommandType = CommandType.Text
                myCommand.ExecuteNonQuery()
                'chuyen ve co so du lieu cu
                myConnection.ChangeDatabase(sdbName)
                myConnection.Close()
myConnection.Dispose()
            Catch ex As Exception

            Finally

            End Try
        End Sub
#End Region
    End Class
End Namespace

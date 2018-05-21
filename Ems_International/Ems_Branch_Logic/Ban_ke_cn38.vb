Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Math
Namespace EMS
#Region "Lấy dữ liệu Bản kê CN 38 - By TrungDQ - 15/10/08"
    Public Class Ban_ke_cn38
        'Khai báo biến
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "Chuẩn bị Dữ liệu dùng in bản kê CN38"
        ' Ngày tạo: 15/10/2008
        ' Người tạo: Đinh Quang Trung
        ' Nội dung: Lấy thông tin từ procedured: Chuyen_thu_di_CN38 & E2_Di_QT_CN38
        ' Input: Id_Chuyen_thu
        ' Output: DataSet 
        Public Function Get_Data_CN38(ByVal Id_Chuyen_Thu As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand1 As SqlCommand = New SqlCommand("E2_Di_QT_CN38", myConnection)
                Dim myCommand2 As SqlCommand = New SqlCommand("Chuyen_thu_di_CN38", myConnection)

                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand1.CommandType = CommandType.StoredProcedure
                myCommand2.CommandType = CommandType.StoredProcedure
                'Parameter           
                Dim pId_Chuyen_Thu As SqlParameter

                myConnection.Open()
                'Thong tin detail
                pId_Chuyen_Thu = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand1.Parameters.Add(pId_Chuyen_Thu)
                myAdapter.SelectCommand = myCommand1
                myAdapter.Fill(myDataSet, "E2_Di_QT_CN38")
                'Thong tin header
                pId_Chuyen_Thu = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand2.Parameters.Add(pId_Chuyen_Thu)
                myAdapter.SelectCommand = myCommand2
                myAdapter.Fill(myDataSet, "Chuyen_thu_di_CN38")

                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                MsgBox(Err.Description)
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

    End Class
#End Region
End Namespace
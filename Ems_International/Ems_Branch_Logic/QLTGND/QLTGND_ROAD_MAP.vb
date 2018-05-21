
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "QLTGND_ROAD_MAP_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop QLTGND_ROAD_MAP_Chi_Tiet
    'Tuong ung voi moi truong trong bang QLTGND_ROAD_MAP trong co so du lieu
    '***********************************************************
    Public Class QLTGND_ROAD_MAP_Chi_Tiet
        Public Id As Integer
        Public PO_CODE_1 As String
        Public PO_CODE_2 As String
        Public NAME_1 As String
        Public NAME_2 As String
        Public LONGITUDE_EAST As Integer
        Public LONGITUDE_WEST As Integer
        Public LATITUDE_NORTH As Integer
        Public LATITUDE_SOUTH As Integer
        Public COMMENTS As String
        Public NAME As String
        Public TYPE As String
    End Class
#End Region

#Region "QLTGND_ROAD_MAP"
    Public Class QLTGND_ROAD_MAP
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "QLTGND_ROAD_MAP_Cap_Nhat_Them"
        Public Function QLTGND_ROAD_MAP_Cap_Nhat_Them(ByVal Id As Integer, ByVal PO_CODE_1 As String, ByVal PO_CODE_2 As String, ByVal NAME_1 As String, ByVal NAME_2 As String, ByVal LONGITUDE_EAST As Integer, ByVal LONGITUDE_WEST As Integer, ByVal LATITUDE_NORTH As Integer, ByVal LATITUDE_SOUTH As Integer, ByVal COMMENTS As String, ByVal NAME As String, ByVal TYPE As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_ROAD_MAP_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myQLTGND_ROAD_MAP_Chi_Tiet As New QLTGND_ROAD_MAP_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId As SqlParameter = New SqlParameter("@Id", SqlDbType.Int, 0)
                pId.Value = Id
                MyCommand.Parameters.Add(pId)

                Dim pPO_CODE_1 As SqlParameter = New SqlParameter("@PO_CODE_1", SqlDbType.VarChar, 6)
                pPO_CODE_1.Value = PO_CODE_1
                MyCommand.Parameters.Add(pPO_CODE_1)

                Dim pPO_CODE_2 As SqlParameter = New SqlParameter("@PO_CODE_2", SqlDbType.VarChar, 6)
                pPO_CODE_2.Value = PO_CODE_2
                MyCommand.Parameters.Add(pPO_CODE_2)

                Dim pNAME_1 As SqlParameter = New SqlParameter("@NAME_1", SqlDbType.VarChar, 50)
                pNAME_1.Value = NAME_1
                MyCommand.Parameters.Add(pNAME_1)

                Dim pNAME_2 As SqlParameter = New SqlParameter("@NAME_2", SqlDbType.VarChar, 50)
                pNAME_2.Value = NAME_2
                MyCommand.Parameters.Add(pNAME_2)

                Dim pLONGITUDE_EAST As SqlParameter = New SqlParameter("@LONGITUDE_EAST", SqlDbType.Int, 0)
                pLONGITUDE_EAST.Value = LONGITUDE_EAST
                MyCommand.Parameters.Add(pLONGITUDE_EAST)

                Dim pLONGITUDE_WEST As SqlParameter = New SqlParameter("@LONGITUDE_WEST", SqlDbType.Int, 0)
                pLONGITUDE_WEST.Value = LONGITUDE_WEST
                MyCommand.Parameters.Add(pLONGITUDE_WEST)

                Dim pLATITUDE_NORTH As SqlParameter = New SqlParameter("@LATITUDE_NORTH", SqlDbType.Int, 0)
                pLATITUDE_NORTH.Value = LATITUDE_NORTH
                MyCommand.Parameters.Add(pLATITUDE_NORTH)

                Dim pLATITUDE_SOUTH As SqlParameter = New SqlParameter("@LATITUDE_SOUTH", SqlDbType.Int, 0)
                pLATITUDE_SOUTH.Value = LATITUDE_SOUTH
                MyCommand.Parameters.Add(pLATITUDE_SOUTH)

                Dim pCOMMENTS As SqlParameter = New SqlParameter("@COMMENTS", SqlDbType.NVarChar, 300)
                pCOMMENTS.Value = COMMENTS
                MyCommand.Parameters.Add(pCOMMENTS)

                Dim pNAME As SqlParameter = New SqlParameter("@NAME", SqlDbType.NVarChar, 150)
                pNAME.Value = NAME
                MyCommand.Parameters.Add(pNAME)

                Dim pTYPE As SqlParameter = New SqlParameter("@TYPE", SqlDbType.VarChar, 1)
                pTYPE.Value = TYPE
                MyCommand.Parameters.Add(pTYPE)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()

                Return numRows
                'Return numRows

            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)
                Return Nothing

            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()

            End Try
        End Function

#End Region


#Region "QLTGND_ROAD_MAP_Danh_Sach"

        Public Function QLTGND_ROAD_MAP_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Id
            ' PO_CODE_1
            ' PO_CODE_2
            ' NAME_1
            ' NAME_2
            ' LONGITUDE_EAST
            ' LONGITUDE_WEST
            ' LATITUDE_NORTH
            ' LATITUDE_SOUTH
            ' COMMENTS
            ' NAME
            ' TYPE


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_ROAD_MAP_Danh_Sach"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters


                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                Adapter.Fill(MyDataSet)

                Return MyDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
                Return Nothing
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                Adapter.Dispose()
            End Try
        End Function
#End Region

#Region "QLTGND_ROAD_MAP_Lay"
        Public Function QLTGND_ROAD_MAP_Lay(ByVal Id As Integer) As QLTGND_ROAD_MAP_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_ROAD_MAP_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myQLTGND_ROAD_MAP_Chi_Tiet As New QLTGND_ROAD_MAP_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId As SqlParameter = New SqlParameter("@Id", SqlDbType.Int, 0)
                pId.Value = Id
                MyCommand.Parameters.Add(pId)

                Dim pPO_CODE_1 As SqlParameter = New SqlParameter("@PO_CODE_1", SqlDbType.VarChar, 6)
                pPO_CODE_1.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPO_CODE_1)

                Dim pPO_CODE_2 As SqlParameter = New SqlParameter("@PO_CODE_2", SqlDbType.VarChar, 6)
                pPO_CODE_2.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPO_CODE_2)

                Dim pNAME_1 As SqlParameter = New SqlParameter("@NAME_1", SqlDbType.VarChar, 50)
                pNAME_1.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNAME_1)

                Dim pNAME_2 As SqlParameter = New SqlParameter("@NAME_2", SqlDbType.VarChar, 50)
                pNAME_2.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNAME_2)

                Dim pLONGITUDE_EAST As SqlParameter = New SqlParameter("@LONGITUDE_EAST", SqlDbType.Int, 0)
                pLONGITUDE_EAST.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pLONGITUDE_EAST)

                Dim pLONGITUDE_WEST As SqlParameter = New SqlParameter("@LONGITUDE_WEST", SqlDbType.Int, 0)
                pLONGITUDE_WEST.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pLONGITUDE_WEST)

                Dim pLATITUDE_NORTH As SqlParameter = New SqlParameter("@LATITUDE_NORTH", SqlDbType.Int, 0)
                pLATITUDE_NORTH.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pLATITUDE_NORTH)

                Dim pLATITUDE_SOUTH As SqlParameter = New SqlParameter("@LATITUDE_SOUTH", SqlDbType.Int, 0)
                pLATITUDE_SOUTH.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pLATITUDE_SOUTH)

                Dim pCOMMENTS As SqlParameter = New SqlParameter("@COMMENTS", SqlDbType.NVarChar, 300)
                pCOMMENTS.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCOMMENTS)

                Dim pNAME As SqlParameter = New SqlParameter("@NAME", SqlDbType.NVarChar, 150)
                pNAME.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pNAME)

                Dim pTYPE As SqlParameter = New SqlParameter("@TYPE", SqlDbType.VarChar, 1)
                pTYPE.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pTYPE)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myQLTGND_ROAD_MAP_Chi_Tiet.Id = Id
                myQLTGND_ROAD_MAP_Chi_Tiet.PO_CODE_1 = pPO_CODE_1.Value
                myQLTGND_ROAD_MAP_Chi_Tiet.PO_CODE_2 = pPO_CODE_2.Value
                myQLTGND_ROAD_MAP_Chi_Tiet.NAME_1 = pNAME_1.Value
                myQLTGND_ROAD_MAP_Chi_Tiet.NAME_2 = pNAME_2.Value
                myQLTGND_ROAD_MAP_Chi_Tiet.LONGITUDE_EAST = pLONGITUDE_EAST.Value
                myQLTGND_ROAD_MAP_Chi_Tiet.LONGITUDE_WEST = pLONGITUDE_WEST.Value
                myQLTGND_ROAD_MAP_Chi_Tiet.LATITUDE_NORTH = pLATITUDE_NORTH.Value
                myQLTGND_ROAD_MAP_Chi_Tiet.LATITUDE_SOUTH = pLATITUDE_SOUTH.Value
                myQLTGND_ROAD_MAP_Chi_Tiet.COMMENTS = pCOMMENTS.Value
                myQLTGND_ROAD_MAP_Chi_Tiet.NAME = pNAME.Value
                myQLTGND_ROAD_MAP_Chi_Tiet.TYPE = pTYPE.Value

                Return myQLTGND_ROAD_MAP_Chi_Tiet
                'Return myQLTGND_ROAD_MAP_Chi_Tiet

            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)
                Return Nothing

            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()

            End Try
        End Function

#End Region

#Region "QLTGND_ROAD_MAP_Xoa"
        Public Function QLTGND_ROAD_MAP_Xoa(ByVal Id As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "QLTGND_ROAD_MAP_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myQLTGND_ROAD_MAP_Chi_Tiet As New QLTGND_ROAD_MAP_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId As SqlParameter = New SqlParameter("@Id", SqlDbType.Int, 0)
                pId.Value = Id
                MyCommand.Parameters.Add(pId)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()

                Return numRows
                'Return numRows

            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)
                Return Nothing

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


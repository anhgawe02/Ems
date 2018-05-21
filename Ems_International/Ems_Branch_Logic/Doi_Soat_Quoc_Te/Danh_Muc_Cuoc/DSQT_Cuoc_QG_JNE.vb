
Imports System
Imports System.Data
Imports System.Data.SqlClient


Namespace EMS
#Region "DSQT_Cuoc_QG_JNE_Chi_Tiet"
    '***********************************************************
    'Moi thuoc tinh thuoc lop DSQT_Cuoc_QG_JNE_Chi_Tiet
    'Tuong ung voi moi truong trong bang DSQT_Cuoc_QG_JNE trong co so du lieu
    '***********************************************************
    Public Class DSQT_Cuoc_QG_JNE_Chi_Tiet
        Public Id_Cuoc As String
        Public Ma_Nuoc As String
        Public Ma_Vung As String
        Public Phan_Loai As String
        Public Cach_Tinh As Boolean
        Public Khoi_Luong As Integer
        Public Khoi_Luong_Max As Integer
        Public Gia_Goc As Double
        Public Cuoc_BP As Double
        Public Thue_GST As Double
        Public Phu_Phi_XD As Double
        Public Id_Dot As String
        Public Ghi_Chu As String
        Public Ma_Tien_Te As String
    End Class
#End Region

#Region "DSQT_Cuoc_QG_JNE"
    Public Class DSQT_Cuoc_QG_JNE
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "DSQT_Cuoc_QG_JNE_Cap_Nhat"
        Public Function DSQT_Cuoc_QG_JNE_Cap_Nhat(ByVal Id_Cuoc As String, ByVal Ma_Nuoc As String, ByVal Ma_Vung As String, ByVal Phan_Loai As String, ByVal Cach_Tinh As Boolean, ByVal Khoi_Luong As Integer, ByVal Khoi_Luong_Max As Integer, ByVal Gia_Goc As Double, ByVal Cuoc_BP As Double, ByVal Thue_GST As Double, ByVal Phu_Phi_XD As Double, ByVal Id_Dot As String, ByVal Ghi_Chu As String, ByVal Ma_Tien_Te As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Cuoc_QG_JNE_Cap_Nhat"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Cuoc_QG_JNE_Chi_Tiet As New DSQT_Cuoc_QG_JNE_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Cuoc As SqlParameter = New SqlParameter("@Id_Cuoc", SqlDbType.VarChar, 70)
                pId_Cuoc.Value = Id_Cuoc
                MyCommand.Parameters.Add(pId_Cuoc)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pMa_Vung As SqlParameter = New SqlParameter("@Ma_Vung", SqlDbType.VarChar, 3)
                pMa_Vung.Value = Ma_Vung
                MyCommand.Parameters.Add(pMa_Vung)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.VarChar, 1)
                pPhan_Loai.Value = Phan_Loai
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pCach_Tinh As SqlParameter = New SqlParameter("@Cach_Tinh", SqlDbType.Bit, 0)
                pCach_Tinh.Value = Cach_Tinh
                MyCommand.Parameters.Add(pCach_Tinh)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 0)
                pKhoi_Luong.Value = Khoi_Luong
                MyCommand.Parameters.Add(pKhoi_Luong)

                Dim pKhoi_Luong_Max As SqlParameter = New SqlParameter("@Khoi_Luong_Max", SqlDbType.Int, 0)
                pKhoi_Luong_Max.Value = Khoi_Luong_Max
                MyCommand.Parameters.Add(pKhoi_Luong_Max)

                Dim pGia_Goc As SqlParameter = New SqlParameter("@Gia_Goc", SqlDbType.Float, 0)
                pGia_Goc.Value = Gia_Goc
                MyCommand.Parameters.Add(pGia_Goc)

                Dim pCuoc_BP As SqlParameter = New SqlParameter("@Cuoc_BP", SqlDbType.Float, 0)
                pCuoc_BP.Value = Cuoc_BP
                MyCommand.Parameters.Add(pCuoc_BP)

                Dim pThue_GST As SqlParameter = New SqlParameter("@Thue_GST", SqlDbType.Float, 0)
                pThue_GST.Value = Thue_GST
                MyCommand.Parameters.Add(pThue_GST)

                Dim pPhu_Phi_XD As SqlParameter = New SqlParameter("@Phu_Phi_XD", SqlDbType.Float, 0)
                pPhu_Phi_XD.Value = Phu_Phi_XD
                MyCommand.Parameters.Add(pPhu_Phi_XD)

                Dim pId_Dot As SqlParameter = New SqlParameter("@Id_Dot", SqlDbType.VarChar, 50)
                pId_Dot.Value = Id_Dot
                MyCommand.Parameters.Add(pId_Dot)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 50)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pMa_Tien_Te As SqlParameter = New SqlParameter("@Ma_Tien_Te", SqlDbType.VarChar, 5)
                pMa_Tien_Te.Value = Ma_Tien_Te
                MyCommand.Parameters.Add(pMa_Tien_Te)


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

#Region "DSQT_Cuoc_QG_JNE_Cap_Nhat_Them"
        Public Function DSQT_Cuoc_QG_JNE_Cap_Nhat_Them(ByVal Id_Cuoc As String, ByVal Ma_Nuoc As String, ByVal Ma_Vung As String, ByVal Phan_Loai As String, ByVal Cach_Tinh As Boolean, ByVal Khoi_Luong As Integer, ByVal Khoi_Luong_Max As Integer, ByVal Gia_Goc As Double, ByVal Cuoc_BP As Double, ByVal Thue_GST As Double, ByVal Phu_Phi_XD As Double, ByVal Id_Dot As String, ByVal Ghi_Chu As String, ByVal Ma_Tien_Te As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Cuoc_QG_JNE_Cap_Nhat_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Cuoc_QG_JNE_Chi_Tiet As New DSQT_Cuoc_QG_JNE_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Cuoc As SqlParameter = New SqlParameter("@Id_Cuoc", SqlDbType.VarChar, 70)
                pId_Cuoc.Value = Id_Cuoc
                MyCommand.Parameters.Add(pId_Cuoc)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pMa_Vung As SqlParameter = New SqlParameter("@Ma_Vung", SqlDbType.VarChar, 3)
                pMa_Vung.Value = Ma_Vung
                MyCommand.Parameters.Add(pMa_Vung)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.VarChar, 1)
                pPhan_Loai.Value = Phan_Loai
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pCach_Tinh As SqlParameter = New SqlParameter("@Cach_Tinh", SqlDbType.Bit, 0)
                pCach_Tinh.Value = Cach_Tinh
                MyCommand.Parameters.Add(pCach_Tinh)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 0)
                pKhoi_Luong.Value = Khoi_Luong
                MyCommand.Parameters.Add(pKhoi_Luong)

                Dim pKhoi_Luong_Max As SqlParameter = New SqlParameter("@Khoi_Luong_Max", SqlDbType.Int, 0)
                pKhoi_Luong_Max.Value = Khoi_Luong_Max
                MyCommand.Parameters.Add(pKhoi_Luong_Max)

                Dim pGia_Goc As SqlParameter = New SqlParameter("@Gia_Goc", SqlDbType.Float, 0)
                pGia_Goc.Value = Gia_Goc
                MyCommand.Parameters.Add(pGia_Goc)

                Dim pCuoc_BP As SqlParameter = New SqlParameter("@Cuoc_BP", SqlDbType.Float, 0)
                pCuoc_BP.Value = Cuoc_BP
                MyCommand.Parameters.Add(pCuoc_BP)

                Dim pThue_GST As SqlParameter = New SqlParameter("@Thue_GST", SqlDbType.Float, 0)
                pThue_GST.Value = Thue_GST
                MyCommand.Parameters.Add(pThue_GST)

                Dim pPhu_Phi_XD As SqlParameter = New SqlParameter("@Phu_Phi_XD", SqlDbType.Float, 0)
                pPhu_Phi_XD.Value = Phu_Phi_XD
                MyCommand.Parameters.Add(pPhu_Phi_XD)

                Dim pId_Dot As SqlParameter = New SqlParameter("@Id_Dot", SqlDbType.VarChar, 50)
                pId_Dot.Value = Id_Dot
                MyCommand.Parameters.Add(pId_Dot)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 50)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pMa_Tien_Te As SqlParameter = New SqlParameter("@Ma_Tien_Te", SqlDbType.VarChar, 5)
                pMa_Tien_Te.Value = Ma_Tien_Te
                MyCommand.Parameters.Add(pMa_Tien_Te)


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


#Region "DSQT_Cuoc_QG_JNE_Danh_Sach"

        Public Function DSQT_Cuoc_QG_JNE_Danh_Sach() As DataSet

            ' The procedure returns these columns:
            ' Id_Cuoc
            ' Ma_Nuoc
            ' Ma_Vung
            ' Phan_Loai
            ' Cach_Tinh
            ' Khoi_Luong
            ' Khoi_Luong_Max
            ' Gia_Goc
            ' Cuoc_BP
            ' Thue_GST
            ' Phu_Phi_XD
            ' Id_Dot
            ' Ghi_Chu
            ' Ma_Tien_Te


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Cuoc_QG_JNE_Danh_Sach"
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


#Region "DSQT_Cuoc_QG_JNE_Danh_Sach_Theo_Id_Dot"

        Public Function DSQT_Cuoc_QG_JNE_Danh_Sach_Theo_Id_Dot(ByVal Id_Dot As String) As DataSet

            ' The procedure returns these columns:
            ' Id_Cuoc
            ' Ma_Nuoc
            ' Ma_Vung
            ' Phan_Loai
            ' Cach_Tinh
            ' Khoi_Luong
            ' Khoi_Luong_Max
            ' Gia_Goc
            ' Cuoc_BP
            ' Thue_GST
            ' Phu_Phi_XD
            ' Id_Dot
            ' Ghi_Chu
            ' Ma_Tien_Te


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Cuoc_QG_JNE_Danh_Sach_Theo_Id_Dot"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pId_Dot As SqlParameter = New SqlParameter("@Id_Dot", SqlDbType.VarChar, 50)
                pId_Dot.Value = Id_Dot
                MyCommand.Parameters.Add(pId_Dot)


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


#Region "DSQT_Cuoc_QG_JNE_Danh_Sach_Theo_Id_Dot_Trong_Chuc_Nang_Load_Dot_Tinh_Cuoc_Lien_Truoc"

        Public Function DSQT_Cuoc_QG_JNE_Danh_Sach_Theo_Id_Dot_Trong_Chuc_Nang_Load_Dot_Tinh_Cuoc_Lien_Truoc(ByVal Id_Dot As String) As DataSet

            ' The procedure returns these columns:
            ' Id_Cuoc
            ' Ma_Nuoc
            ' Ma_Vung
            ' Phan_Loai
            ' Cach_Tinh
            ' Khoi_Luong
            ' Khoi_Luong_Max
            ' Gia_Goc
            ' Cuoc_BP
            ' Thue_GST
            ' Phu_Phi_XD
            ' Id_Dot
            ' Ghi_Chu
            ' Ma_Tien_Te


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Cuoc_QG_JNE_Danh_Sach_Theo_Id_Dot_Trong_Chuc_Nang_Load_Dot_Tinh_Cuoc_Lien_Truoc"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pId_Dot As SqlParameter = New SqlParameter("@Id_Dot", SqlDbType.VarChar, 50)
                pId_Dot.Value = Id_Dot
                MyCommand.Parameters.Add(pId_Dot)


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

#Region "DSQT_Cuoc_QG_JNE_Lay"
        Public Function DSQT_Cuoc_QG_JNE_Lay(ByVal Id_Cuoc As String) As DSQT_Cuoc_QG_JNE_Chi_Tiet
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Cuoc_QG_JNE_Lay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Cuoc_QG_JNE_Chi_Tiet As New DSQT_Cuoc_QG_JNE_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Cuoc As SqlParameter = New SqlParameter("@Id_Cuoc", SqlDbType.VarChar, 70)
                pId_Cuoc.Value = Id_Cuoc
                MyCommand.Parameters.Add(pId_Cuoc)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pMa_Vung As SqlParameter = New SqlParameter("@Ma_Vung", SqlDbType.VarChar, 3)
                pMa_Vung.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Vung)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.VarChar, 1)
                pPhan_Loai.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pCach_Tinh As SqlParameter = New SqlParameter("@Cach_Tinh", SqlDbType.Bit, 0)
                pCach_Tinh.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCach_Tinh)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 0)
                pKhoi_Luong.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pKhoi_Luong)

                Dim pKhoi_Luong_Max As SqlParameter = New SqlParameter("@Khoi_Luong_Max", SqlDbType.Int, 0)
                pKhoi_Luong_Max.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pKhoi_Luong_Max)

                Dim pGia_Goc As SqlParameter = New SqlParameter("@Gia_Goc", SqlDbType.Float, 0)
                pGia_Goc.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGia_Goc)

                Dim pCuoc_BP As SqlParameter = New SqlParameter("@Cuoc_BP", SqlDbType.Float, 0)
                pCuoc_BP.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pCuoc_BP)

                Dim pThue_GST As SqlParameter = New SqlParameter("@Thue_GST", SqlDbType.Float, 0)
                pThue_GST.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pThue_GST)

                Dim pPhu_Phi_XD As SqlParameter = New SqlParameter("@Phu_Phi_XD", SqlDbType.Float, 0)
                pPhu_Phi_XD.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pPhu_Phi_XD)

                Dim pId_Dot As SqlParameter = New SqlParameter("@Id_Dot", SqlDbType.VarChar, 50)
                pId_Dot.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pId_Dot)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 50)
                pGhi_Chu.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pMa_Tien_Te As SqlParameter = New SqlParameter("@Ma_Tien_Te", SqlDbType.VarChar, 5)
                pMa_Tien_Te.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pMa_Tien_Te)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                'Get output values
                myDSQT_Cuoc_QG_JNE_Chi_Tiet.Id_Cuoc = Id_Cuoc
                myDSQT_Cuoc_QG_JNE_Chi_Tiet.Ma_Nuoc = pMa_Nuoc.Value
                myDSQT_Cuoc_QG_JNE_Chi_Tiet.Ma_Vung = pMa_Vung.Value
                myDSQT_Cuoc_QG_JNE_Chi_Tiet.Phan_Loai = pPhan_Loai.Value
                myDSQT_Cuoc_QG_JNE_Chi_Tiet.Cach_Tinh = pCach_Tinh.Value
                myDSQT_Cuoc_QG_JNE_Chi_Tiet.Khoi_Luong = pKhoi_Luong.Value
                myDSQT_Cuoc_QG_JNE_Chi_Tiet.Khoi_Luong_Max = pKhoi_Luong_Max.Value
                myDSQT_Cuoc_QG_JNE_Chi_Tiet.Gia_Goc = pGia_Goc.Value
                myDSQT_Cuoc_QG_JNE_Chi_Tiet.Cuoc_BP = pCuoc_BP.Value
                myDSQT_Cuoc_QG_JNE_Chi_Tiet.Thue_GST = pThue_GST.Value
                myDSQT_Cuoc_QG_JNE_Chi_Tiet.Phu_Phi_XD = pPhu_Phi_XD.Value
                myDSQT_Cuoc_QG_JNE_Chi_Tiet.Id_Dot = pId_Dot.Value
                myDSQT_Cuoc_QG_JNE_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value
                myDSQT_Cuoc_QG_JNE_Chi_Tiet.Ma_Tien_Te = pMa_Tien_Te.Value

                Return myDSQT_Cuoc_QG_JNE_Chi_Tiet
                'Return myDSQT_Cuoc_QG_JNE_Chi_Tiet

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

#Region "DSQT_Cuoc_QG_JNE_Them"
        Public Function DSQT_Cuoc_QG_JNE_Them(ByVal Id_Cuoc As String, ByVal Ma_Nuoc As String, ByVal Ma_Vung As String, ByVal Phan_Loai As String, ByVal Cach_Tinh As Boolean, ByVal Khoi_Luong As Integer, ByVal Khoi_Luong_Max As Integer, ByVal Gia_Goc As Double, ByVal Cuoc_BP As Double, ByVal Thue_GST As Double, ByVal Phu_Phi_XD As Double, ByVal Id_Dot As String, ByVal Ghi_Chu As String, ByVal Ma_Tien_Te As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Cuoc_QG_JNE_Them"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Cuoc_QG_JNE_Chi_Tiet As New DSQT_Cuoc_QG_JNE_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Cuoc As SqlParameter = New SqlParameter("@Id_Cuoc", SqlDbType.VarChar, 70)
                pId_Cuoc.Value = Id_Cuoc
                MyCommand.Parameters.Add(pId_Cuoc)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pMa_Vung As SqlParameter = New SqlParameter("@Ma_Vung", SqlDbType.VarChar, 3)
                pMa_Vung.Value = Ma_Vung
                MyCommand.Parameters.Add(pMa_Vung)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.VarChar, 1)
                pPhan_Loai.Value = Phan_Loai
                MyCommand.Parameters.Add(pPhan_Loai)

                Dim pCach_Tinh As SqlParameter = New SqlParameter("@Cach_Tinh", SqlDbType.Bit, 0)
                pCach_Tinh.Value = Cach_Tinh
                MyCommand.Parameters.Add(pCach_Tinh)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 0)
                pKhoi_Luong.Value = Khoi_Luong
                MyCommand.Parameters.Add(pKhoi_Luong)

                Dim pKhoi_Luong_Max As SqlParameter = New SqlParameter("@Khoi_Luong_Max", SqlDbType.Int, 0)
                pKhoi_Luong_Max.Value = Khoi_Luong_Max
                MyCommand.Parameters.Add(pKhoi_Luong_Max)

                Dim pGia_Goc As SqlParameter = New SqlParameter("@Gia_Goc", SqlDbType.Float, 0)
                pGia_Goc.Value = Gia_Goc
                MyCommand.Parameters.Add(pGia_Goc)

                Dim pCuoc_BP As SqlParameter = New SqlParameter("@Cuoc_BP", SqlDbType.Float, 0)
                pCuoc_BP.Value = Cuoc_BP
                MyCommand.Parameters.Add(pCuoc_BP)

                Dim pThue_GST As SqlParameter = New SqlParameter("@Thue_GST", SqlDbType.Float, 0)
                pThue_GST.Value = Thue_GST
                MyCommand.Parameters.Add(pThue_GST)

                Dim pPhu_Phi_XD As SqlParameter = New SqlParameter("@Phu_Phi_XD", SqlDbType.Float, 0)
                pPhu_Phi_XD.Value = Phu_Phi_XD
                MyCommand.Parameters.Add(pPhu_Phi_XD)

                Dim pId_Dot As SqlParameter = New SqlParameter("@Id_Dot", SqlDbType.VarChar, 50)
                pId_Dot.Value = Id_Dot
                MyCommand.Parameters.Add(pId_Dot)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 50)
                pGhi_Chu.Value = Ghi_Chu
                MyCommand.Parameters.Add(pGhi_Chu)

                Dim pMa_Tien_Te As SqlParameter = New SqlParameter("@Ma_Tien_Te", SqlDbType.VarChar, 5)
                pMa_Tien_Te.Value = Ma_Tien_Te
                MyCommand.Parameters.Add(pMa_Tien_Te)


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

#Region "DSQT_Cuoc_QG_JNE_Xoa"
        Public Function DSQT_Cuoc_QG_JNE_Xoa(ByVal Id_Cuoc As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "DSQT_Cuoc_QG_JNE_Xoa"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myDSQT_Cuoc_QG_JNE_Chi_Tiet As New DSQT_Cuoc_QG_JNE_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_Cuoc As SqlParameter = New SqlParameter("@Id_Cuoc", SqlDbType.VarChar, 70)
                pId_Cuoc.Value = Id_Cuoc
                MyCommand.Parameters.Add(pId_Cuoc)


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


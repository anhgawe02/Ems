﻿
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "COD_Di_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp COD_Di_Chi_Tiet
    ' tương ứng với mộ trường của bảng COD_Di trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class COD_Di_Chi_Tiet
        Public Id_E1 As String
        Public Ma_E1 As String ' Số hiệu E1
        Public Ma_COD1 As String
        Public Id_Nguoi_Dung As Integer
        Public So_TT As Integer ' Số thứ tự trả tiền
        Public So_Hoa_Don As String ' Số hóa đơn chứng từ kèm theo
        Public Gia_Tri As Integer ' Giá trị tiền hàng
        Public Cuoc_COD As Integer ' Cước COD
        Public Cuoc_TCT As Integer ' Cước phiếu chuyển tiền
        Public Cuoc_Thu_Ho As Integer ' Cước người nhận phải trả (ngoài giá trị)
        Public Cuoc_Chuyen_Nhanh As Integer ' Cước chuyển nhanh
        Public Cuoc_Chuyen_Tiep As Integer ' Cước chuyển tiếp
        Public Cuoc_EMS As Integer
        Public EMS As Boolean ' Là chuyển phát
        Public COD As Boolean ' Ai trả tiền cước COD
        Public Nhanh As Boolean ' Hình thức phiếu chuyển tiền
        Public Chuyen_Tiep As Boolean ' Là chuyển tiếp
        Public Giay_To_Kem_Theo As String ' Giấy tờ người gửi kèm theo khi nhận tiền
        Public Ngay_Gui As Integer
        Public Gio_Gui As Integer
        Public Ngay_Nhan As Integer
        Public Gio_Nhan As Integer
        Public Ma_Bc_Goc As Integer
        Public Ma_Bc_Tra As Integer
        Public Ma_Bc_Chuyen_Tiep As Integer ' Bưu cục chuyển tiếp
        Public Nguoi_Gui_Nhan_Tien As Boolean
        Public Truyen_Khai_Thac As Boolean
    End Class
#End Region
#Region "COD_Di"
    Public Class COD_Di
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng COD_Di
        ' Input: Id_E1
        ' Output: COD_Di_Chi_Tiet
        Public Function Lay(ByVal Id_E1 As String) As COD_Di_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("COD_Di_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                myCommand.Parameters.Add(pId_E1)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_E1)

                Dim pMa_COD1 As SqlParameter = New SqlParameter("@Ma_COD1", SqlDbType.VarChar, 15)
                pMa_COD1.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_COD1)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 4)
                pId_Nguoi_Dung.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pSo_TT As SqlParameter = New SqlParameter("@So_TT", SqlDbType.Int, 4)
                pSo_TT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSo_TT)

                Dim pSo_Hoa_Don As SqlParameter = New SqlParameter("@So_Hoa_Don", SqlDbType.NVarChar, 50)
                pSo_Hoa_Don.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSo_Hoa_Don)

                Dim pGia_Tri As SqlParameter = New SqlParameter("@Gia_Tri", SqlDbType.Int, 4)
                pGia_Tri.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGia_Tri)

                Dim pCuoc_COD As SqlParameter = New SqlParameter("@Cuoc_COD", SqlDbType.Int, 4)
                pCuoc_COD.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_COD)

                Dim pCuoc_TCT As SqlParameter = New SqlParameter("@Cuoc_TCT", SqlDbType.Int, 4)
                pCuoc_TCT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_TCT)

                Dim pCuoc_Thu_Ho As SqlParameter = New SqlParameter("@Cuoc_Thu_Ho", SqlDbType.Int, 4)
                pCuoc_Thu_Ho.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_Thu_Ho)

                Dim pCuoc_Chuyen_Nhanh As SqlParameter = New SqlParameter("@Cuoc_Chuyen_Nhanh", SqlDbType.Int, 4)
                pCuoc_Chuyen_Nhanh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_Chuyen_Nhanh)

                Dim pCuoc_Chuyen_Tiep As SqlParameter = New SqlParameter("@Cuoc_Chuyen_Tiep", SqlDbType.Int, 4)
                pCuoc_Chuyen_Tiep.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_Chuyen_Tiep)

                Dim pCuoc_EMS As SqlParameter = New SqlParameter("@Cuoc_EMS", SqlDbType.Int, 4)
                pCuoc_EMS.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_EMS)

                Dim pEMS As SqlParameter = New SqlParameter("@EMS", SqlDbType.Bit, 1)
                pEMS.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pEMS)

                Dim pCOD As SqlParameter = New SqlParameter("@COD", SqlDbType.Bit, 1)
                pCOD.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCOD)

                Dim pNhanh As SqlParameter = New SqlParameter("@Nhanh", SqlDbType.Bit, 1)
                pNhanh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNhanh)

                Dim pChuyen_Tiep As SqlParameter = New SqlParameter("@Chuyen_Tiep", SqlDbType.Bit, 1)
                pChuyen_Tiep.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pChuyen_Tiep)

                Dim pGiay_To_Kem_Theo As SqlParameter = New SqlParameter("@Giay_To_Kem_Theo", SqlDbType.NVarChar, 100)
                pGiay_To_Kem_Theo.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGiay_To_Kem_Theo)

                Dim pNgay_Gui As SqlParameter = New SqlParameter("@Ngay_Gui", SqlDbType.Int, 4)
                pNgay_Gui.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_Gui)

                Dim pGio_Gui As SqlParameter = New SqlParameter("@Gio_Gui", SqlDbType.Int, 4)
                pGio_Gui.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGio_Gui)

                Dim pNgay_Nhan As SqlParameter = New SqlParameter("@Ngay_Nhan", SqlDbType.Int, 4)
                pNgay_Nhan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_Nhan)

                Dim pGio_Nhan As SqlParameter = New SqlParameter("@Gio_Nhan", SqlDbType.Int, 4)
                pGio_Nhan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGio_Nhan)

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 4)
                pMa_Bc_Goc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 4)
                pMa_Bc_Tra.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_Tra)

                Dim pMa_Bc_Chuyen_Tiep As SqlParameter = New SqlParameter("@Ma_Bc_Chuyen_Tiep", SqlDbType.Int, 4)
                pMa_Bc_Chuyen_Tiep.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_Chuyen_Tiep)

                Dim pNguoi_Gui_Nhan_Tien As SqlParameter = New SqlParameter("@Nguoi_Gui_Nhan_Tien", SqlDbType.Bit, 1)
                pNguoi_Gui_Nhan_Tien.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNguoi_Gui_Nhan_Tien)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTruyen_Khai_Thac)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
                Dim myCOD_Di_Chi_Tiet As COD_Di_Chi_Tiet = New COD_Di_Chi_Tiet
                myCOD_Di_Chi_Tiet.Id_E1 = Id_E1
                myCOD_Di_Chi_Tiet.Ma_E1 = pMa_E1.Value
                myCOD_Di_Chi_Tiet.Ma_COD1 = pMa_COD1.Value
                myCOD_Di_Chi_Tiet.Id_Nguoi_Dung = pId_Nguoi_Dung.Value
                myCOD_Di_Chi_Tiet.So_TT = pSo_TT.Value
                myCOD_Di_Chi_Tiet.So_Hoa_Don = pSo_Hoa_Don.Value
                myCOD_Di_Chi_Tiet.Gia_Tri = pGia_Tri.Value
                myCOD_Di_Chi_Tiet.Cuoc_COD = pCuoc_COD.Value
                myCOD_Di_Chi_Tiet.Cuoc_TCT = pCuoc_TCT.Value
                myCOD_Di_Chi_Tiet.Cuoc_Thu_Ho = pCuoc_Thu_Ho.Value
                myCOD_Di_Chi_Tiet.Cuoc_Chuyen_Nhanh = pCuoc_Chuyen_Nhanh.Value
                myCOD_Di_Chi_Tiet.Cuoc_Chuyen_Tiep = pCuoc_Chuyen_Tiep.Value
                myCOD_Di_Chi_Tiet.Cuoc_EMS = pCuoc_EMS.Value
                myCOD_Di_Chi_Tiet.EMS = pEMS.Value
                myCOD_Di_Chi_Tiet.COD = pCOD.Value
                myCOD_Di_Chi_Tiet.Nhanh = pNhanh.Value
                myCOD_Di_Chi_Tiet.Chuyen_Tiep = pChuyen_Tiep.Value
                myCOD_Di_Chi_Tiet.Giay_To_Kem_Theo = pGiay_To_Kem_Theo.Value
                myCOD_Di_Chi_Tiet.Ngay_Gui = pNgay_Gui.Value
                myCOD_Di_Chi_Tiet.Gio_Gui = pGio_Gui.Value
                myCOD_Di_Chi_Tiet.Ngay_Nhan = pNgay_Nhan.Value
                myCOD_Di_Chi_Tiet.Gio_Nhan = pGio_Nhan.Value
                myCOD_Di_Chi_Tiet.Ma_Bc_Goc = pMa_Bc_Goc.Value
                myCOD_Di_Chi_Tiet.Ma_Bc_Tra = pMa_Bc_Tra.Value
                myCOD_Di_Chi_Tiet.Ma_Bc_Chuyen_Tiep = pMa_Bc_Chuyen_Tiep.Value
                myCOD_Di_Chi_Tiet.Nguoi_Gui_Nhan_Tien = pNguoi_Gui_Nhan_Tien.Value
                myCOD_Di_Chi_Tiet.Truyen_Khai_Thac = pTruyen_Khai_Thac.Value
                Return myCOD_Di_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng COD_Di
        ' Input:  Ma_E1, Ma_COD1, Id_Nguoi_Dung, So_TT, So_Hoa_Don, Gia_Tri, Cuoc_COD, Cuoc_TCT, Cuoc_Thu_Ho, Cuoc_Chuyen_Nhanh, Cuoc_Chuyen_Tiep, Cuoc_EMS, EMS, COD, Nhanh, Chuyen_Tiep, Giay_To_Kem_Theo, Ngay_Gui, Gio_Gui, Ngay_Nhan, Gio_Nhan, Ma_Bc_Goc, Ma_Bc_Tra, Ma_Bc_Chuyen_Tiep, Nguoi_Gui_Nhan_Tien, Truyen_Khai_Thac,
        ' Output: 
        Public Sub Them(ByVal Ma_E1 As String, ByVal Ma_COD1 As String, ByVal Id_Nguoi_Dung As Integer, ByVal So_TT As Integer, ByVal So_Hoa_Don As String, ByVal Gia_Tri As Integer, ByVal Cuoc_COD As Integer, ByVal Cuoc_TCT As Integer, ByVal Cuoc_Thu_Ho As Integer, ByVal Cuoc_Chuyen_Nhanh As Integer, ByVal Cuoc_Chuyen_Tiep As Integer, ByVal Cuoc_EMS As Integer, ByVal EMS As Boolean, ByVal COD As Boolean, ByVal Nhanh As Boolean, ByVal Chuyen_Tiep As Boolean, ByVal Giay_To_Kem_Theo As String, ByVal Ngay_Gui As Integer, ByVal Gio_Gui As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Ma_Bc_Goc As Integer, ByVal Ma_Bc_Tra As Integer, ByVal Ma_Bc_Chuyen_Tiep As Integer, ByVal Nguoi_Gui_Nhan_Tien As Boolean, ByVal Truyen_Khai_Thac As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("COD_Di_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pMa_COD1 As SqlParameter = New SqlParameter("@Ma_COD1", SqlDbType.VarChar, 15)
                pMa_COD1.Value = Ma_COD1
                myCommand.Parameters.Add(pMa_COD1)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 4)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pSo_TT As SqlParameter = New SqlParameter("@So_TT", SqlDbType.Int, 4)
                pSo_TT.Value = So_TT
                myCommand.Parameters.Add(pSo_TT)

                Dim pSo_Hoa_Don As SqlParameter = New SqlParameter("@So_Hoa_Don", SqlDbType.NVarChar, 50)
                pSo_Hoa_Don.Value = So_Hoa_Don
                myCommand.Parameters.Add(pSo_Hoa_Don)

                Dim pGia_Tri As SqlParameter = New SqlParameter("@Gia_Tri", SqlDbType.Int, 4)
                pGia_Tri.Value = Gia_Tri
                myCommand.Parameters.Add(pGia_Tri)

                Dim pCuoc_COD As SqlParameter = New SqlParameter("@Cuoc_COD", SqlDbType.Int, 4)
                pCuoc_COD.Value = Cuoc_COD
                myCommand.Parameters.Add(pCuoc_COD)

                Dim pCuoc_TCT As SqlParameter = New SqlParameter("@Cuoc_TCT", SqlDbType.Int, 4)
                pCuoc_TCT.Value = Cuoc_TCT
                myCommand.Parameters.Add(pCuoc_TCT)

                Dim pCuoc_Thu_Ho As SqlParameter = New SqlParameter("@Cuoc_Thu_Ho", SqlDbType.Int, 4)
                pCuoc_Thu_Ho.Value = Cuoc_Thu_Ho
                myCommand.Parameters.Add(pCuoc_Thu_Ho)

                Dim pCuoc_Chuyen_Nhanh As SqlParameter = New SqlParameter("@Cuoc_Chuyen_Nhanh", SqlDbType.Int, 4)
                pCuoc_Chuyen_Nhanh.Value = Cuoc_Chuyen_Nhanh
                myCommand.Parameters.Add(pCuoc_Chuyen_Nhanh)

                Dim pCuoc_Chuyen_Tiep As SqlParameter = New SqlParameter("@Cuoc_Chuyen_Tiep", SqlDbType.Int, 4)
                pCuoc_Chuyen_Tiep.Value = Cuoc_Chuyen_Tiep
                myCommand.Parameters.Add(pCuoc_Chuyen_Tiep)

                Dim pCuoc_EMS As SqlParameter = New SqlParameter("@Cuoc_EMS", SqlDbType.Int, 4)
                pCuoc_EMS.Value = Cuoc_EMS
                myCommand.Parameters.Add(pCuoc_EMS)

                Dim pEMS As SqlParameter = New SqlParameter("@EMS", SqlDbType.Bit, 1)
                pEMS.Value = EMS
                myCommand.Parameters.Add(pEMS)

                Dim pCOD As SqlParameter = New SqlParameter("@COD", SqlDbType.Bit, 1)
                pCOD.Value = COD
                myCommand.Parameters.Add(pCOD)

                Dim pNhanh As SqlParameter = New SqlParameter("@Nhanh", SqlDbType.Bit, 1)
                pNhanh.Value = Nhanh
                myCommand.Parameters.Add(pNhanh)

                Dim pChuyen_Tiep As SqlParameter = New SqlParameter("@Chuyen_Tiep", SqlDbType.Bit, 1)
                pChuyen_Tiep.Value = Chuyen_Tiep
                myCommand.Parameters.Add(pChuyen_Tiep)

                Dim pGiay_To_Kem_Theo As SqlParameter = New SqlParameter("@Giay_To_Kem_Theo", SqlDbType.NVarChar, 100)
                pGiay_To_Kem_Theo.Value = Giay_To_Kem_Theo
                myCommand.Parameters.Add(pGiay_To_Kem_Theo)

                Dim pNgay_Gui As SqlParameter = New SqlParameter("@Ngay_Gui", SqlDbType.Int, 4)
                pNgay_Gui.Value = Ngay_Gui
                myCommand.Parameters.Add(pNgay_Gui)

                Dim pGio_Gui As SqlParameter = New SqlParameter("@Gio_Gui", SqlDbType.Int, 4)
                pGio_Gui.Value = Gio_Gui
                myCommand.Parameters.Add(pGio_Gui)

                Dim pNgay_Nhan As SqlParameter = New SqlParameter("@Ngay_Nhan", SqlDbType.Int, 4)
                pNgay_Nhan.Value = Ngay_Nhan
                myCommand.Parameters.Add(pNgay_Nhan)

                Dim pGio_Nhan As SqlParameter = New SqlParameter("@Gio_Nhan", SqlDbType.Int, 4)
                pGio_Nhan.Value = Gio_Nhan
                myCommand.Parameters.Add(pGio_Nhan)

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 4)
                pMa_Bc_Goc.Value = Ma_Bc_Goc
                myCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 4)
                pMa_Bc_Tra.Value = Ma_Bc_Tra
                myCommand.Parameters.Add(pMa_Bc_Tra)

                Dim pMa_Bc_Chuyen_Tiep As SqlParameter = New SqlParameter("@Ma_Bc_Chuyen_Tiep", SqlDbType.Int, 4)
                pMa_Bc_Chuyen_Tiep.Value = Ma_Bc_Chuyen_Tiep
                myCommand.Parameters.Add(pMa_Bc_Chuyen_Tiep)

                Dim pNguoi_Gui_Nhan_Tien As SqlParameter = New SqlParameter("@Nguoi_Gui_Nhan_Tien", SqlDbType.Bit, 1)
                pNguoi_Gui_Nhan_Tien.Value = Nguoi_Gui_Nhan_Tien
                myCommand.Parameters.Add(pNguoi_Gui_Nhan_Tien)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Value = Truyen_Khai_Thac
                myCommand.Parameters.Add(pTruyen_Khai_Thac)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Sub
#End Region
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng COD_Di
        ' Input: Id_E1,  Ma_E1 , Ma_COD1 , Id_Nguoi_Dung , So_TT , So_Hoa_Don , Gia_Tri , Cuoc_COD , Cuoc_TCT , Cuoc_Thu_Ho , Cuoc_Chuyen_Nhanh , Cuoc_Chuyen_Tiep , Cuoc_EMS , EMS , COD , Nhanh , Chuyen_Tiep , Giay_To_Kem_Theo , Ngay_Gui , Gio_Gui , Ngay_Nhan , Gio_Nhan , Ma_Bc_Goc , Ma_Bc_Tra , Ma_Bc_Chuyen_Tiep , Nguoi_Gui_Nhan_Tien , Truyen_Khai_Thac ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_E1 As String, ByVal Ma_E1 As String, ByVal Ma_COD1 As String, ByVal Id_Nguoi_Dung As Integer, ByVal So_TT As Integer, ByVal So_Hoa_Don As String, ByVal Gia_Tri As Integer, ByVal Cuoc_COD As Integer, ByVal Cuoc_TCT As Integer, ByVal Cuoc_Thu_Ho As Integer, ByVal Cuoc_Chuyen_Nhanh As Integer, ByVal Cuoc_Chuyen_Tiep As Integer, ByVal Cuoc_EMS As Integer, ByVal EMS As Boolean, ByVal COD As Boolean, ByVal Nhanh As Boolean, ByVal Chuyen_Tiep As Boolean, ByVal Giay_To_Kem_Theo As String, ByVal Ngay_Gui As Integer, ByVal Gio_Gui As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Ma_Bc_Goc As Integer, ByVal Ma_Bc_Tra As Integer, ByVal Ma_Bc_Chuyen_Tiep As Integer, ByVal Nguoi_Gui_Nhan_Tien As Boolean, ByVal Truyen_Khai_Thac As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("COD_Di_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                myCommand.Parameters.Add(pId_E1)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pMa_COD1 As SqlParameter = New SqlParameter("@Ma_COD1", SqlDbType.VarChar, 15)
                pMa_COD1.Value = Ma_COD1
                myCommand.Parameters.Add(pMa_COD1)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 4)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pSo_TT As SqlParameter = New SqlParameter("@So_TT", SqlDbType.Int, 4)
                pSo_TT.Value = So_TT
                myCommand.Parameters.Add(pSo_TT)

                Dim pSo_Hoa_Don As SqlParameter = New SqlParameter("@So_Hoa_Don", SqlDbType.NVarChar, 50)
                pSo_Hoa_Don.Value = So_Hoa_Don
                myCommand.Parameters.Add(pSo_Hoa_Don)

                Dim pGia_Tri As SqlParameter = New SqlParameter("@Gia_Tri", SqlDbType.Int, 4)
                pGia_Tri.Value = Gia_Tri
                myCommand.Parameters.Add(pGia_Tri)

                Dim pCuoc_COD As SqlParameter = New SqlParameter("@Cuoc_COD", SqlDbType.Int, 4)
                pCuoc_COD.Value = Cuoc_COD
                myCommand.Parameters.Add(pCuoc_COD)

                Dim pCuoc_TCT As SqlParameter = New SqlParameter("@Cuoc_TCT", SqlDbType.Int, 4)
                pCuoc_TCT.Value = Cuoc_TCT
                myCommand.Parameters.Add(pCuoc_TCT)

                Dim pCuoc_Thu_Ho As SqlParameter = New SqlParameter("@Cuoc_Thu_Ho", SqlDbType.Int, 4)
                pCuoc_Thu_Ho.Value = Cuoc_Thu_Ho
                myCommand.Parameters.Add(pCuoc_Thu_Ho)

                Dim pCuoc_Chuyen_Nhanh As SqlParameter = New SqlParameter("@Cuoc_Chuyen_Nhanh", SqlDbType.Int, 4)
                pCuoc_Chuyen_Nhanh.Value = Cuoc_Chuyen_Nhanh
                myCommand.Parameters.Add(pCuoc_Chuyen_Nhanh)

                Dim pCuoc_Chuyen_Tiep As SqlParameter = New SqlParameter("@Cuoc_Chuyen_Tiep", SqlDbType.Int, 4)
                pCuoc_Chuyen_Tiep.Value = Cuoc_Chuyen_Tiep
                myCommand.Parameters.Add(pCuoc_Chuyen_Tiep)

                Dim pCuoc_EMS As SqlParameter = New SqlParameter("@Cuoc_EMS", SqlDbType.Int, 4)
                pCuoc_EMS.Value = Cuoc_EMS
                myCommand.Parameters.Add(pCuoc_EMS)

                Dim pEMS As SqlParameter = New SqlParameter("@EMS", SqlDbType.Bit, 1)
                pEMS.Value = EMS
                myCommand.Parameters.Add(pEMS)

                Dim pCOD As SqlParameter = New SqlParameter("@COD", SqlDbType.Bit, 1)
                pCOD.Value = COD
                myCommand.Parameters.Add(pCOD)

                Dim pNhanh As SqlParameter = New SqlParameter("@Nhanh", SqlDbType.Bit, 1)
                pNhanh.Value = Nhanh
                myCommand.Parameters.Add(pNhanh)

                Dim pChuyen_Tiep As SqlParameter = New SqlParameter("@Chuyen_Tiep", SqlDbType.Bit, 1)
                pChuyen_Tiep.Value = Chuyen_Tiep
                myCommand.Parameters.Add(pChuyen_Tiep)

                Dim pGiay_To_Kem_Theo As SqlParameter = New SqlParameter("@Giay_To_Kem_Theo", SqlDbType.NVarChar, 100)
                pGiay_To_Kem_Theo.Value = Giay_To_Kem_Theo
                myCommand.Parameters.Add(pGiay_To_Kem_Theo)

                Dim pNgay_Gui As SqlParameter = New SqlParameter("@Ngay_Gui", SqlDbType.Int, 4)
                pNgay_Gui.Value = Ngay_Gui
                myCommand.Parameters.Add(pNgay_Gui)

                Dim pGio_Gui As SqlParameter = New SqlParameter("@Gio_Gui", SqlDbType.Int, 4)
                pGio_Gui.Value = Gio_Gui
                myCommand.Parameters.Add(pGio_Gui)

                Dim pNgay_Nhan As SqlParameter = New SqlParameter("@Ngay_Nhan", SqlDbType.Int, 4)
                pNgay_Nhan.Value = Ngay_Nhan
                myCommand.Parameters.Add(pNgay_Nhan)

                Dim pGio_Nhan As SqlParameter = New SqlParameter("@Gio_Nhan", SqlDbType.Int, 4)
                pGio_Nhan.Value = Gio_Nhan
                myCommand.Parameters.Add(pGio_Nhan)

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 4)
                pMa_Bc_Goc.Value = Ma_Bc_Goc
                myCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 4)
                pMa_Bc_Tra.Value = Ma_Bc_Tra
                myCommand.Parameters.Add(pMa_Bc_Tra)

                Dim pMa_Bc_Chuyen_Tiep As SqlParameter = New SqlParameter("@Ma_Bc_Chuyen_Tiep", SqlDbType.Int, 4)
                pMa_Bc_Chuyen_Tiep.Value = Ma_Bc_Chuyen_Tiep
                myCommand.Parameters.Add(pMa_Bc_Chuyen_Tiep)

                Dim pNguoi_Gui_Nhan_Tien As SqlParameter = New SqlParameter("@Nguoi_Gui_Nhan_Tien", SqlDbType.Bit, 1)
                pNguoi_Gui_Nhan_Tien.Value = Nguoi_Gui_Nhan_Tien
                myCommand.Parameters.Add(pNguoi_Gui_Nhan_Tien)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Value = Truyen_Khai_Thac
                myCommand.Parameters.Add(pTruyen_Khai_Thac)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng COD_Di
        ' Input: đối tượng thuộc lớp COD_Di_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myCOD_Di_Chi_Tiet As COD_Di_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("COD_Di_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = myCOD_Di_Chi_Tiet.Id_E1
                myCommand.Parameters.Add(pId_E1)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = myCOD_Di_Chi_Tiet.Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pMa_COD1 As SqlParameter = New SqlParameter("@Ma_COD1", SqlDbType.VarChar, 15)
                pMa_COD1.Value = myCOD_Di_Chi_Tiet.Ma_COD1
                myCommand.Parameters.Add(pMa_COD1)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 4)
                pId_Nguoi_Dung.Value = myCOD_Di_Chi_Tiet.Id_Nguoi_Dung
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pSo_TT As SqlParameter = New SqlParameter("@So_TT", SqlDbType.Int, 4)
                pSo_TT.Value = myCOD_Di_Chi_Tiet.So_TT
                myCommand.Parameters.Add(pSo_TT)

                Dim pSo_Hoa_Don As SqlParameter = New SqlParameter("@So_Hoa_Don", SqlDbType.NVarChar, 50)
                pSo_Hoa_Don.Value = myCOD_Di_Chi_Tiet.So_Hoa_Don
                myCommand.Parameters.Add(pSo_Hoa_Don)

                Dim pGia_Tri As SqlParameter = New SqlParameter("@Gia_Tri", SqlDbType.Int, 4)
                pGia_Tri.Value = myCOD_Di_Chi_Tiet.Gia_Tri
                myCommand.Parameters.Add(pGia_Tri)

                Dim pCuoc_COD As SqlParameter = New SqlParameter("@Cuoc_COD", SqlDbType.Int, 4)
                pCuoc_COD.Value = myCOD_Di_Chi_Tiet.Cuoc_COD
                myCommand.Parameters.Add(pCuoc_COD)

                Dim pCuoc_TCT As SqlParameter = New SqlParameter("@Cuoc_TCT", SqlDbType.Int, 4)
                pCuoc_TCT.Value = myCOD_Di_Chi_Tiet.Cuoc_TCT
                myCommand.Parameters.Add(pCuoc_TCT)

                Dim pCuoc_Thu_Ho As SqlParameter = New SqlParameter("@Cuoc_Thu_Ho", SqlDbType.Int, 4)
                pCuoc_Thu_Ho.Value = myCOD_Di_Chi_Tiet.Cuoc_Thu_Ho
                myCommand.Parameters.Add(pCuoc_Thu_Ho)

                Dim pCuoc_Chuyen_Nhanh As SqlParameter = New SqlParameter("@Cuoc_Chuyen_Nhanh", SqlDbType.Int, 4)
                pCuoc_Chuyen_Nhanh.Value = myCOD_Di_Chi_Tiet.Cuoc_Chuyen_Nhanh
                myCommand.Parameters.Add(pCuoc_Chuyen_Nhanh)

                Dim pCuoc_Chuyen_Tiep As SqlParameter = New SqlParameter("@Cuoc_Chuyen_Tiep", SqlDbType.Int, 4)
                pCuoc_Chuyen_Tiep.Value = myCOD_Di_Chi_Tiet.Cuoc_Chuyen_Tiep
                myCommand.Parameters.Add(pCuoc_Chuyen_Tiep)

                Dim pCuoc_EMS As SqlParameter = New SqlParameter("@Cuoc_EMS", SqlDbType.Int, 4)
                pCuoc_EMS.Value = myCOD_Di_Chi_Tiet.Cuoc_EMS
                myCommand.Parameters.Add(pCuoc_EMS)

                Dim pEMS As SqlParameter = New SqlParameter("@EMS", SqlDbType.Bit, 1)
                pEMS.Value = myCOD_Di_Chi_Tiet.EMS
                myCommand.Parameters.Add(pEMS)

                Dim pCOD As SqlParameter = New SqlParameter("@COD", SqlDbType.Bit, 1)
                pCOD.Value = myCOD_Di_Chi_Tiet.COD
                myCommand.Parameters.Add(pCOD)

                Dim pNhanh As SqlParameter = New SqlParameter("@Nhanh", SqlDbType.Bit, 1)
                pNhanh.Value = myCOD_Di_Chi_Tiet.Nhanh
                myCommand.Parameters.Add(pNhanh)

                Dim pChuyen_Tiep As SqlParameter = New SqlParameter("@Chuyen_Tiep", SqlDbType.Bit, 1)
                pChuyen_Tiep.Value = myCOD_Di_Chi_Tiet.Chuyen_Tiep
                myCommand.Parameters.Add(pChuyen_Tiep)

                Dim pGiay_To_Kem_Theo As SqlParameter = New SqlParameter("@Giay_To_Kem_Theo", SqlDbType.NVarChar, 100)
                pGiay_To_Kem_Theo.Value = myCOD_Di_Chi_Tiet.Giay_To_Kem_Theo
                myCommand.Parameters.Add(pGiay_To_Kem_Theo)

                Dim pNgay_Gui As SqlParameter = New SqlParameter("@Ngay_Gui", SqlDbType.Int, 4)
                pNgay_Gui.Value = myCOD_Di_Chi_Tiet.Ngay_Gui
                myCommand.Parameters.Add(pNgay_Gui)

                Dim pGio_Gui As SqlParameter = New SqlParameter("@Gio_Gui", SqlDbType.Int, 4)
                pGio_Gui.Value = myCOD_Di_Chi_Tiet.Gio_Gui
                myCommand.Parameters.Add(pGio_Gui)

                Dim pNgay_Nhan As SqlParameter = New SqlParameter("@Ngay_Nhan", SqlDbType.Int, 4)
                pNgay_Nhan.Value = myCOD_Di_Chi_Tiet.Ngay_Nhan
                myCommand.Parameters.Add(pNgay_Nhan)

                Dim pGio_Nhan As SqlParameter = New SqlParameter("@Gio_Nhan", SqlDbType.Int, 4)
                pGio_Nhan.Value = myCOD_Di_Chi_Tiet.Gio_Nhan
                myCommand.Parameters.Add(pGio_Nhan)

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 4)
                pMa_Bc_Goc.Value = myCOD_Di_Chi_Tiet.Ma_Bc_Goc
                myCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 4)
                pMa_Bc_Tra.Value = myCOD_Di_Chi_Tiet.Ma_Bc_Tra
                myCommand.Parameters.Add(pMa_Bc_Tra)

                Dim pMa_Bc_Chuyen_Tiep As SqlParameter = New SqlParameter("@Ma_Bc_Chuyen_Tiep", SqlDbType.Int, 4)
                pMa_Bc_Chuyen_Tiep.Value = myCOD_Di_Chi_Tiet.Ma_Bc_Chuyen_Tiep
                myCommand.Parameters.Add(pMa_Bc_Chuyen_Tiep)

                Dim pNguoi_Gui_Nhan_Tien As SqlParameter = New SqlParameter("@Nguoi_Gui_Nhan_Tien", SqlDbType.Bit, 1)
                pNguoi_Gui_Nhan_Tien.Value = myCOD_Di_Chi_Tiet.Nguoi_Gui_Nhan_Tien
                myCommand.Parameters.Add(pNguoi_Gui_Nhan_Tien)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Value = myCOD_Di_Chi_Tiet.Truyen_Khai_Thac
                myCommand.Parameters.Add(pTruyen_Khai_Thac)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Sub
#End Region
#Region "Cap_Nhat_Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng COD_Di
        ' Input: Id_E1,  Ma_E1 , Ma_COD1 , Id_Nguoi_Dung , So_TT , So_Hoa_Don , Gia_Tri , Cuoc_COD , Cuoc_TCT , Cuoc_Thu_Ho , Cuoc_Chuyen_Nhanh , Cuoc_Chuyen_Tiep , Cuoc_EMS , EMS , COD , Nhanh , Chuyen_Tiep , Giay_To_Kem_Theo , Ngay_Gui , Gio_Gui , Ngay_Nhan , Gio_Nhan , Ma_Bc_Goc , Ma_Bc_Tra , Ma_Bc_Chuyen_Tiep , Nguoi_Gui_Nhan_Tien , Truyen_Khai_Thac ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Id_E1 As String, ByVal Ma_E1 As String, ByVal Ma_COD1 As String, ByVal Id_Nguoi_Dung As Integer, ByVal So_TT As Integer, ByVal So_Hoa_Don As String, ByVal Gia_Tri As Integer, ByVal Cuoc_COD As Integer, ByVal Cuoc_TCT As Integer, ByVal Cuoc_Thu_Ho As Integer, ByVal Cuoc_Chuyen_Nhanh As Integer, ByVal Cuoc_Chuyen_Tiep As Integer, ByVal Cuoc_EMS As Integer, ByVal EMS As Boolean, ByVal COD As Boolean, ByVal Nhanh As Boolean, ByVal Chuyen_Tiep As Boolean, ByVal Giay_To_Kem_Theo As String, ByVal Ngay_Gui As Integer, ByVal Gio_Gui As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Ma_Bc_Goc As Integer, ByVal Ma_Bc_Tra As Integer, ByVal Ma_Bc_Chuyen_Tiep As Integer, ByVal Nguoi_Gui_Nhan_Tien As Boolean, ByVal Truyen_Khai_Thac As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("COD_Di_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                myCommand.Parameters.Add(pId_E1)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pMa_COD1 As SqlParameter = New SqlParameter("@Ma_COD1", SqlDbType.VarChar, 15)
                pMa_COD1.Value = Ma_COD1
                myCommand.Parameters.Add(pMa_COD1)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 4)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pSo_TT As SqlParameter = New SqlParameter("@So_TT", SqlDbType.Int, 4)
                pSo_TT.Value = So_TT
                myCommand.Parameters.Add(pSo_TT)

                Dim pSo_Hoa_Don As SqlParameter = New SqlParameter("@So_Hoa_Don", SqlDbType.NVarChar, 50)
                pSo_Hoa_Don.Value = So_Hoa_Don
                myCommand.Parameters.Add(pSo_Hoa_Don)

                Dim pGia_Tri As SqlParameter = New SqlParameter("@Gia_Tri", SqlDbType.Int, 4)
                pGia_Tri.Value = Gia_Tri
                myCommand.Parameters.Add(pGia_Tri)

                Dim pCuoc_COD As SqlParameter = New SqlParameter("@Cuoc_COD", SqlDbType.Int, 4)
                pCuoc_COD.Value = Cuoc_COD
                myCommand.Parameters.Add(pCuoc_COD)

                Dim pCuoc_TCT As SqlParameter = New SqlParameter("@Cuoc_TCT", SqlDbType.Int, 4)
                pCuoc_TCT.Value = Cuoc_TCT
                myCommand.Parameters.Add(pCuoc_TCT)

                Dim pCuoc_Thu_Ho As SqlParameter = New SqlParameter("@Cuoc_Thu_Ho", SqlDbType.Int, 4)
                pCuoc_Thu_Ho.Value = Cuoc_Thu_Ho
                myCommand.Parameters.Add(pCuoc_Thu_Ho)

                Dim pCuoc_Chuyen_Nhanh As SqlParameter = New SqlParameter("@Cuoc_Chuyen_Nhanh", SqlDbType.Int, 4)
                pCuoc_Chuyen_Nhanh.Value = Cuoc_Chuyen_Nhanh
                myCommand.Parameters.Add(pCuoc_Chuyen_Nhanh)

                Dim pCuoc_Chuyen_Tiep As SqlParameter = New SqlParameter("@Cuoc_Chuyen_Tiep", SqlDbType.Int, 4)
                pCuoc_Chuyen_Tiep.Value = Cuoc_Chuyen_Tiep
                myCommand.Parameters.Add(pCuoc_Chuyen_Tiep)

                Dim pCuoc_EMS As SqlParameter = New SqlParameter("@Cuoc_EMS", SqlDbType.Int, 4)
                pCuoc_EMS.Value = Cuoc_EMS
                myCommand.Parameters.Add(pCuoc_EMS)

                Dim pEMS As SqlParameter = New SqlParameter("@EMS", SqlDbType.Bit, 1)
                pEMS.Value = EMS
                myCommand.Parameters.Add(pEMS)

                Dim pCOD As SqlParameter = New SqlParameter("@COD", SqlDbType.Bit, 1)
                pCOD.Value = COD
                myCommand.Parameters.Add(pCOD)

                Dim pNhanh As SqlParameter = New SqlParameter("@Nhanh", SqlDbType.Bit, 1)
                pNhanh.Value = Nhanh
                myCommand.Parameters.Add(pNhanh)

                Dim pChuyen_Tiep As SqlParameter = New SqlParameter("@Chuyen_Tiep", SqlDbType.Bit, 1)
                pChuyen_Tiep.Value = Chuyen_Tiep
                myCommand.Parameters.Add(pChuyen_Tiep)

                Dim pGiay_To_Kem_Theo As SqlParameter = New SqlParameter("@Giay_To_Kem_Theo", SqlDbType.NVarChar, 100)
                pGiay_To_Kem_Theo.Value = Giay_To_Kem_Theo
                myCommand.Parameters.Add(pGiay_To_Kem_Theo)

                Dim pNgay_Gui As SqlParameter = New SqlParameter("@Ngay_Gui", SqlDbType.Int, 4)
                pNgay_Gui.Value = Ngay_Gui
                myCommand.Parameters.Add(pNgay_Gui)

                Dim pGio_Gui As SqlParameter = New SqlParameter("@Gio_Gui", SqlDbType.Int, 4)
                pGio_Gui.Value = Gio_Gui
                myCommand.Parameters.Add(pGio_Gui)

                Dim pNgay_Nhan As SqlParameter = New SqlParameter("@Ngay_Nhan", SqlDbType.Int, 4)
                pNgay_Nhan.Value = Ngay_Nhan
                myCommand.Parameters.Add(pNgay_Nhan)

                Dim pGio_Nhan As SqlParameter = New SqlParameter("@Gio_Nhan", SqlDbType.Int, 4)
                pGio_Nhan.Value = Gio_Nhan
                myCommand.Parameters.Add(pGio_Nhan)

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 4)
                pMa_Bc_Goc.Value = Ma_Bc_Goc
                myCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 4)
                pMa_Bc_Tra.Value = Ma_Bc_Tra
                myCommand.Parameters.Add(pMa_Bc_Tra)

                Dim pMa_Bc_Chuyen_Tiep As SqlParameter = New SqlParameter("@Ma_Bc_Chuyen_Tiep", SqlDbType.Int, 4)
                pMa_Bc_Chuyen_Tiep.Value = Ma_Bc_Chuyen_Tiep
                myCommand.Parameters.Add(pMa_Bc_Chuyen_Tiep)

                Dim pNguoi_Gui_Nhan_Tien As SqlParameter = New SqlParameter("@Nguoi_Gui_Nhan_Tien", SqlDbType.Bit, 1)
                pNguoi_Gui_Nhan_Tien.Value = Nguoi_Gui_Nhan_Tien
                myCommand.Parameters.Add(pNguoi_Gui_Nhan_Tien)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Value = Truyen_Khai_Thac
                myCommand.Parameters.Add(pTruyen_Khai_Thac)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region
#Region "Xoa"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng COD_Di
        ' Input: Id_E1
        ' Output: 
        Public Sub Xoa(ByVal Id_E1 As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("COD_Di_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                myCommand.Parameters.Add(pId_E1)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)


            End Try
        End Sub
#End Region
#Region "Danh_Sach"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng COD_Di
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("COD_Di_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "COD_Di_Danh_Sach")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_Theo_Ngay_Gui"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng COD_Di
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Theo_Ngay_Gui(ByVal Ngay_Gui As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("COD_Di_Danh_Sach_Theo_Ngay_Gui", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                Dim pNgay_Gui As SqlParameter = New SqlParameter("@Ngay_Gui", SqlDbType.Int)
                pNgay_Gui.Value = Ngay_Gui
                myCommand.Parameters.Add(pNgay_Gui)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "COD_Di_Danh_Sach_Theo_Ngay_Gui")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Lay_Max_Ma_COD1"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng COD_Di
        ' Input: Id_COD
        ' Output: 
        Public Function Lay_Max_Ma_COD1() As String
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("COD_Di_Lay_Max_Ma_COD1", myConnection)
                Dim str As String

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_COD1 As SqlParameter = New SqlParameter("@Ma_COD1", SqlDbType.VarChar, 15)
                pMa_COD1.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_COD1)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
                str = "000000" + pMa_COD1.Value
                str = str.Substring(str.Length - 6)
                Return str
            Catch ex As Exception
                Console.Write(ex.ToString)
                Return ""
            End Try
        End Function
#End Region
#Region "Tim_Kiem"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng COD_Di
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Tim_Kiem(ByVal strSQL As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand(strSQL, myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.Text

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "COD_Tim_Kiem")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Truyen so lieu"
#Region "Danh_Sach_Lay_Boi_Id_E2_Truyen"
        Public Function Danh_Sach_Lay_Boi_Id_Chuyen_Thu_Truyen(ByVal Id_Chuyen_Thu As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("COD_Di_Danh_Sach_Lay_Boi_Id_Chuyen_Thu_Truyen", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "COD_Di_Danh_Sach_Lay_Boi_Id_Chuyen_Thu_Truyen")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#End Region
#Region "Bao cao chieu di cua COD"
        ' Ngày tạo: 05/08/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Báo cáo chiều đi của dịch vụ COD
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function COD_Di_Bao_Cao(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer) As DataSet
            Try
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("COD_Di_Bao_Cao", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataset As DataSet = New DataSet

                'su dung Store procedure
                myCommand.CommandType = CommandType.StoredProcedure
                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int)
                pTu_Ngay.Value = Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                myCommand.CommandType = CommandType.StoredProcedure
                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int)
                pDen_Ngay.Value = Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataset, "COD_Di_Bao_Cao")
                myConnection.Close()
myConnection.Dispose()
                Return myDataset


            Catch ex As Exception
                Console.WriteLine(ex.ToString)

            End Try

        End Function
#End Region
#Region "Thong_Ke_Nhan_Buu_Gui"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng COD_Di
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Thong_Ke_Nhan_Buu_Gui(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("COD_Di_Thong_Ke_Nhan_Buu_Gui", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int)
                pTu_Ngay.Value = Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int)
                pDen_Ngay.Value = Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "COD_Di_Thong_Ke_Nhan_Buu_Gui")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
    End Class
#End Region
End Namespace

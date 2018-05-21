Imports System
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OracleClient

Namespace EMS
#Region "ORA_Receptacle_Chi_Tiet"

#Region "ORA_Doi_Tac_Chi_Tiet"
    Public Class ORA_Doi_Tac_Chi_Tiet
        '*******************************************************        
        '
        '*******************************************************
        Public ID_DOI_TAC As Double
        Public TEN_DOI_TAC As String
        Public TEN_TAT As String
        Public SO_HOP_DONG As String
        Public NGAY_KY As Double
        Public TOM_TAT_NOI_DUNG As String
    End Class
#End Region
#Region "ORA_TT_Giao_Nhan_Chi_Tiet"
    Public Class ORA_TT_Giao_Nhan_Chi_Tiet
        '*******************************************************        
        '
        '*******************************************************
        Public ID_GIAO_NHAN As String
        Public ID_DOI_TAC As Double
        Public ID_PHUONG_TIEN As Double
        Public LOAI_GIAO_NHAN As Double
        Public MA_BC_KHAI_THAC As Double
        Public NGAY_GIAO As Double
        Public GIO_GIAO As Double
        Public DOT_GIAO As Double
        Public MA_BC_NHAN As Double
    End Class
#End Region
#Region "ORA_TT_Tui_Thu_Chi_Tiet"
    Public Class ORA_TT_Tui_Thu_Chi_Tiet
        '*******************************************************        
        '
        '*******************************************************
        Public ID_TT_TUI_THU As Double
        Public ID_TUI_THU As String
        Public ID_DUONG_THU As Double
        Public ID_CHUYEN_THU As String
        Public ID_GIAO_NHAN As String
        Public MA_BC_GUI As Double
        Public MA_BC_NHAN As Double
        Public CHUYEN_THU As Double
        Public TUI_SO As Double
        Public KHOI_LUONG As Double
        Public KHOI_LUONG_QD As Double
        Public TONG_SO_BP As Double
        Public CUOC_EMS As Double
        Public CUOC_DV As Double
        Public NGAY_DONG As Double
        Public GIO_DONG As Double
        Public LOAI_TUI_THU As Double
        Public LOAI_XAC_NHAN As Double
    End Class
#End Region
#End Region
#Region "ORA_Receptacle"
    Public Class ORA_Receptacle
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "er_doi_tac_theo_ma_buu_cuc"
        'dataset tra ve : 
        'Id_Doi_Tac     double
        'Ten_Doi_Tac    double
        Public Function er_doi_tac_theo_ma_buu_cuc(ByVal Ma_Bc_Khai_Thac As Double, ByVal Ma_Bc_Nhan As Double) As DataSet
            Dim myConnection As OracleConnection = New OracleConnection(ConnectionString)
            Dim MyCommand As New OracleCommand
            Dim myDataSet As New DataSet
            Try
                MyCommand.Connection = myConnection
                MyCommand.CommandText = "er.er_doi_tac_theo_ma_buu_cuc"
                MyCommand.CommandType = CommandType.StoredProcedure

                Dim pMa_Bc_Khai_Thac As OracleParameter = New OracleParameter("v_Ma_Bc_Khai_Thac", OracleType.Number)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Bc_Nhan As OracleParameter = New OracleParameter("v_Ma_Bc_Nhan", OracleType.Number)
                pMa_Bc_Nhan.Value = Ma_Bc_Nhan
                MyCommand.Parameters.Add(pMa_Bc_Nhan)

                MyCommand.Parameters.Add("p_ResultSet", OracleType.Cursor).Direction = ParameterDirection.Output
                Dim myAdapter As OracleDataAdapter = New OracleDataAdapter(MyCommand)

                myConnection.Open()
                myAdapter.Fill(myDataSet, "Doi_Tac")
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
                'EventLog.WriteEntry("Loi goi : er_doi_tac_theo_ma_buu_cuc", ex.ToString, System.Diagnostics.EventLogEntryType.[Error])
                MessageBox.Show("Lỗi không lấy được danh sách đối tác!!! Kiểm tra kết nối với máy chủ ORACLE.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return Nothing
            Finally
                'Close the connection and Dispose.
                myConnection.Close()
                MyCommand.Dispose()
            End Try
        End Function
#End Region
#Region "er_phuong_tien_buu_cuc_doi_tac"
        'dataset tra ve : 
        'Id_Loai_Phuong_Tien     Double
        'Loai_Phuong_Tien        string
        'So_Hieu                 string
        Public Function er_phuong_tien_buu_cuc_doi_tac(ByVal Ma_Bc_Khai_Thac As Double, ByVal Id_Doi_Tac As Double) As DataSet
            Dim myConnection As OracleConnection = New OracleConnection(ConnectionString)
            Dim MyCommand As New OracleCommand
            Dim myDataSet As New DataSet
            Try
                MyCommand.Connection = myConnection
                MyCommand.CommandText = "er.er_phuong_tien_buu_cuc_doi_tac"
                MyCommand.CommandType = CommandType.StoredProcedure

                Dim pMa_Bc_Khai_Thac As OracleParameter = New OracleParameter("v_Ma_Bc_Khai_Thac", OracleType.Number)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pId_Doi_Tac As OracleParameter = New OracleParameter("v_Id_Doi_Tac", OracleType.Number)
                pId_Doi_Tac.Value = Id_Doi_Tac
                MyCommand.Parameters.Add(pId_Doi_Tac)

                MyCommand.Parameters.Add("p_ResultSet", OracleType.Cursor).Direction = ParameterDirection.Output
                Dim myAdapter As OracleDataAdapter = New OracleDataAdapter(MyCommand)

                myConnection.Open()
                myAdapter.Fill(myDataSet, "Phuong_Tien")
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
                'EventLog.WriteEntry("Loi goi : er_phuong_tien_buu_cuc_doi_tac", ex.ToString, System.Diagnostics.EventLogEntryType.[Error])
                MessageBox.Show("Lỗi không lấy được danh sách phương tiện!!! Kiểm tra kết nối với máy chủ ORACLE.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return Nothing
            Finally
                'Close the connection and Dispose.
                myConnection.Close()
                MyCommand.Dispose()
            End Try
        End Function
#End Region
#Region "er_BC_nhan_BC_Khai_thac"
        'dataset tra ve : 
        'Ma_Bc_Nhan     Double
        'Ten_Buu_Cuc    string
        Public Function er_BC_nhan_BC_Khai_thac(ByVal Ma_Bc_Khai_Thac As Double) As DataSet
            Dim myConnection As OracleConnection = New OracleConnection(ConnectionString)
            Dim MyCommand As New OracleCommand
            Dim myDataSet As New DataSet
            Try
                MyCommand.Connection = myConnection
                MyCommand.CommandText = "er.er_BC_nhan_BC_Khai_thac"
                MyCommand.CommandType = CommandType.StoredProcedure

                Dim pMa_Bc_Khai_Thac As OracleParameter = New OracleParameter("v_Ma_Bc_Khai_Thac", OracleType.Number)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                MyCommand.Parameters.Add("p_ResultSet", OracleType.Cursor).Direction = ParameterDirection.Output
                Dim myAdapter As OracleDataAdapter = New OracleDataAdapter(MyCommand)

                myConnection.Open()
                myAdapter.Fill(myDataSet, "Buu_Cuc_Van_Chuyen")
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
                'EventLog.WriteEntry("Loi goi : er_BC_nhan_BC_Khai_thac", ex.ToString, System.Diagnostics.EventLogEntryType.[Error])
                MessageBox.Show("Lỗi không lấy được danh sách bưu cục nhận!!! Kiểm tra kết nối với máy chủ ORACLE.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return Nothing
            Finally
                'Close the connection and Dispose.
                myConnection.Close()
                MyCommand.Dispose()
            End Try
        End Function
#End Region
#Region "er_tt_giao_nhan_them"
        ' Output: 
        Public Function er_tt_giao_nhan_them(ByVal myTT_Giao_Nhan_Chi_Tiet As ORA_TT_Giao_Nhan_Chi_Tiet) As Integer
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As OracleConnection = New OracleConnection(ConnectionString)
                Dim myCommand As OracleCommand = New OracleCommand("er.er_tt_giao_nhan_them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pID_GIAO_NHAN As OracleParameter = New OracleParameter("v_ID_GIAO_NHAN", OracleType.VarChar, 28)
                pID_GIAO_NHAN.Value = myTT_Giao_Nhan_Chi_Tiet.ID_GIAO_NHAN
                myCommand.Parameters.Add(pID_GIAO_NHAN)

                Dim pID_DOI_TAC As OracleParameter = New OracleParameter("v_ID_DOI_TAC", OracleType.Number)
                pID_DOI_TAC.Value = myTT_Giao_Nhan_Chi_Tiet.ID_DOI_TAC
                myCommand.Parameters.Add(pID_DOI_TAC)

                Dim pID_PHUONG_TIEN As OracleParameter = New OracleParameter("v_ID_PHUONG_TIEN", OracleType.Number)
                pID_PHUONG_TIEN.Value = myTT_Giao_Nhan_Chi_Tiet.ID_PHUONG_TIEN
                myCommand.Parameters.Add(pID_PHUONG_TIEN)

                Dim pLOAI_GIAO_NHAN As OracleParameter = New OracleParameter("v_LOAI_GIAO_NHAN", OracleType.Number)
                pLOAI_GIAO_NHAN.Value = myTT_Giao_Nhan_Chi_Tiet.LOAI_GIAO_NHAN
                myCommand.Parameters.Add(pLOAI_GIAO_NHAN)

                Dim pMA_BC_KHAI_THAC As OracleParameter = New OracleParameter("v_MA_BC_KHAI_THAC", OracleType.Number)
                pMA_BC_KHAI_THAC.Value = myTT_Giao_Nhan_Chi_Tiet.MA_BC_KHAI_THAC
                myCommand.Parameters.Add(pMA_BC_KHAI_THAC)

                Dim pMA_BC_NHAN As OracleParameter = New OracleParameter("v_MA_BC_NHAN", OracleType.Number)
                pMA_BC_NHAN.Value = myTT_Giao_Nhan_Chi_Tiet.MA_BC_NHAN
                myCommand.Parameters.Add(pMA_BC_NHAN)

                'Dim pNGAY_GIAO As OracleParameter = New OracleParameter("v_NGAY_GIAO", OracleType.Number)
                'pNGAY_GIAO.Value = myTT_Giao_Nhan_Chi_Tiet.NGAY_GIAO
                'myCommand.Parameters.Add(pNGAY_GIAO)

                'Dim pGIO_GIAO As OracleParameter = New OracleParameter("v_GIO_GIAO", OracleType.Number)
                'pGIO_GIAO.Value = myTT_Giao_Nhan_Chi_Tiet.GIO_GIAO
                'myCommand.Parameters.Add(pGIO_GIAO)

                Dim pDOT_GIAO As OracleParameter = New OracleParameter("v_DOT_GIAO", OracleType.Number)
                pDOT_GIAO.Value = myTT_Giao_Nhan_Chi_Tiet.DOT_GIAO
                myCommand.Parameters.Add(pDOT_GIAO)

                Dim pSTATUS As OracleParameter = New OracleParameter("v_STATUS", OracleType.Number)
                pSTATUS.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSTATUS)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()

                Return pSTATUS.Value
            Catch ex As Exception
                Console.Write(ex.ToString)
                EventLog.WriteEntry("Loi goi : er_tt_giao_nhan_them", ex.ToString, System.Diagnostics.EventLogEntryType.[Error])
                Return 0
            End Try
        End Function
#End Region
#Region "er_tt_tui_thu_them"
        ' Output: 
        Public Function er_tt_tui_thu_them(ByVal myTT_Tui_Thu_Chi_Tiet As ORA_TT_Tui_Thu_Chi_Tiet) As Integer
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As OracleConnection = New OracleConnection(ConnectionString)
                Dim myCommand As OracleCommand = New OracleCommand("er.er_tt_tui_thu_them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pID_TT_TUI_THU As OracleParameter = New OracleParameter("v_ID_TT_TUI_THU", OracleType.Number)
                pID_TT_TUI_THU.Value = myTT_Tui_Thu_Chi_Tiet.ID_TT_TUI_THU
                myCommand.Parameters.Add(pID_TT_TUI_THU)

                Dim pID_TUI_THU As OracleParameter = New OracleParameter("v_ID_TUI_THU", OracleType.VarChar, 50)
                pID_TUI_THU.Value = myTT_Tui_Thu_Chi_Tiet.ID_TUI_THU
                myCommand.Parameters.Add(pID_TUI_THU)

                Dim pID_DUONG_THU As OracleParameter = New OracleParameter("v_ID_DUONG_THU", OracleType.Number)
                pID_DUONG_THU.Value = myTT_Tui_Thu_Chi_Tiet.ID_DUONG_THU
                myCommand.Parameters.Add(pID_DUONG_THU)

                Dim pID_CHUYEN_THU As OracleParameter = New OracleParameter("v_ID_CHUYEN_THU", OracleType.VarChar, 50)
                pID_CHUYEN_THU.Value = myTT_Tui_Thu_Chi_Tiet.ID_CHUYEN_THU
                myCommand.Parameters.Add(pID_CHUYEN_THU)

                Dim pID_GIAO_NHAN As OracleParameter = New OracleParameter("v_ID_GIAO_NHAN", OracleType.VarChar, 28)
                pID_GIAO_NHAN.Value = myTT_Tui_Thu_Chi_Tiet.ID_GIAO_NHAN
                myCommand.Parameters.Add(pID_GIAO_NHAN)

                Dim pMA_BC_GUI As OracleParameter = New OracleParameter("v_MA_BC_GUI", OracleType.Number)
                pMA_BC_GUI.Value = myTT_Tui_Thu_Chi_Tiet.MA_BC_GUI
                myCommand.Parameters.Add(pMA_BC_GUI)

                Dim pMA_BC_NHAN As OracleParameter = New OracleParameter("v_MA_BC_NHAN", OracleType.Number)
                pMA_BC_NHAN.Value = myTT_Tui_Thu_Chi_Tiet.MA_BC_NHAN
                myCommand.Parameters.Add(pMA_BC_NHAN)

                Dim pCHUYEN_THU As OracleParameter = New OracleParameter("v_CHUYEN_THU", OracleType.Number)
                pCHUYEN_THU.Value = myTT_Tui_Thu_Chi_Tiet.CHUYEN_THU
                myCommand.Parameters.Add(pCHUYEN_THU)

                Dim pTUI_SO As OracleParameter = New OracleParameter("v_TUI_SO", OracleType.Number)
                pTUI_SO.Value = myTT_Tui_Thu_Chi_Tiet.TUI_SO
                myCommand.Parameters.Add(pTUI_SO)

                Dim pKHOI_LUONG As OracleParameter = New OracleParameter("v_KHOI_LUONG", OracleType.Number)
                pKHOI_LUONG.Value = myTT_Tui_Thu_Chi_Tiet.KHOI_LUONG
                myCommand.Parameters.Add(pKHOI_LUONG)

                Dim pKHOI_LUONG_QD As OracleParameter = New OracleParameter("v_KHOI_LUONG_QD", OracleType.Number)
                pKHOI_LUONG_QD.Value = myTT_Tui_Thu_Chi_Tiet.KHOI_LUONG_QD
                myCommand.Parameters.Add(pKHOI_LUONG_QD)

                Dim pTONG_SO_BP As OracleParameter = New OracleParameter("v_TONG_SO_BP", OracleType.Number)
                pTONG_SO_BP.Value = myTT_Tui_Thu_Chi_Tiet.TONG_SO_BP
                myCommand.Parameters.Add(pTONG_SO_BP)

                Dim pCUOC_EMS As OracleParameter = New OracleParameter("v_CUOC_EMS", OracleType.Number)
                pCUOC_EMS.Value = myTT_Tui_Thu_Chi_Tiet.CUOC_EMS
                myCommand.Parameters.Add(pCUOC_EMS)

                Dim pCUOC_DV As OracleParameter = New OracleParameter("v_CUOC_DV", OracleType.Number)
                pCUOC_DV.Value = myTT_Tui_Thu_Chi_Tiet.CUOC_DV
                myCommand.Parameters.Add(pCUOC_DV)

                Dim pNGAY_DONG As OracleParameter = New OracleParameter("v_NGAY_DONG", OracleType.Number)
                pNGAY_DONG.Value = myTT_Tui_Thu_Chi_Tiet.NGAY_DONG
                myCommand.Parameters.Add(pNGAY_DONG)

                Dim pGIO_DONG As OracleParameter = New OracleParameter("v_GIO_DONG", OracleType.Number)
                pGIO_DONG.Value = myTT_Tui_Thu_Chi_Tiet.GIO_DONG
                myCommand.Parameters.Add(pGIO_DONG)

                Dim pLOAI_TUI_THU As OracleParameter = New OracleParameter("v_LOAI_TUI_THU", OracleType.Number)
                pLOAI_TUI_THU.Value = myTT_Tui_Thu_Chi_Tiet.LOAI_TUI_THU
                myCommand.Parameters.Add(pLOAI_TUI_THU)

                Dim pLOAI_XAC_NHAN As OracleParameter = New OracleParameter("v_LOAI_XAC_NHAN", OracleType.Number)
                pLOAI_XAC_NHAN.Value = myTT_Tui_Thu_Chi_Tiet.LOAI_XAC_NHAN
                myCommand.Parameters.Add(pLOAI_XAC_NHAN)

                Dim pSTATUS As OracleParameter = New OracleParameter("v_STATUS", OracleType.Number)
                pSTATUS.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSTATUS)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()

                Return pSTATUS.Value
            Catch ex As Exception
                Console.Write(ex.ToString)
                EventLog.WriteEntry("Loi goi : er_tt_tui_thu_them", ex.ToString, System.Diagnostics.EventLogEntryType.[Error])
                Return 0
            End Try
        End Function
#End Region
#Region "er_tt_giao_nhan_hoan_tat_giao"
        ' Output: 
        Public Function er_tt_giao_nhan_hoan_tat_giao(ByVal ID_GIAO_NHAN As String) As Integer
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As OracleConnection = New OracleConnection(ConnectionString)
                Dim myCommand As OracleCommand = New OracleCommand("er.er_tt_giao_nhan_hoan_tat_giao", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pID_GIAO_NHAN As OracleParameter = New OracleParameter("v_ID_GIAO_NHAN", OracleType.VarChar, 28)
                pID_GIAO_NHAN.Value = ID_GIAO_NHAN
                myCommand.Parameters.Add(pID_GIAO_NHAN)

                Dim pSTATUS As OracleParameter = New OracleParameter("v_STATUS", OracleType.Number)
                pSTATUS.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSTATUS)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()

                Return pSTATUS.Value

            Catch ex As Exception
                Console.Write(ex.ToString)
                Return 0
            End Try
        End Function
#End Region
#Region "er_tt_giao_nhan_hoan_tat_nhan"
        ' Output: 
        Public Function er_tt_giao_nhan_hoan_tat_nhan(ByVal ID_GIAO_NHAN As String) As Integer
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As OracleConnection = New OracleConnection(ConnectionString)
                Dim myCommand As OracleCommand = New OracleCommand("er.er_tt_giao_nhan_hoan_tat_nhan", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pID_GIAO_NHAN As OracleParameter = New OracleParameter("v_ID_GIAO_NHAN", OracleType.VarChar, 28)
                pID_GIAO_NHAN.Value = ID_GIAO_NHAN
                myCommand.Parameters.Add(pID_GIAO_NHAN)

                Dim pSTATUS As OracleParameter = New OracleParameter("v_STATUS", OracleType.Number)
                pSTATUS.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSTATUS)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()

                Return pSTATUS.Value

            Catch ex As Exception
                Console.Write(ex.ToString)
                Return 0
            End Try
        End Function
#End Region
#Region "er_tt_giao_nhan_xoa"
        ' Output: 
        Public Function er_tt_giao_nhan_xoa(ByVal ID_GIAO_NHAN As String) As Integer
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As OracleConnection = New OracleConnection(ConnectionString)
                Dim myCommand As OracleCommand = New OracleCommand("er.er_tt_giao_nhan_xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pID_GIAO_NHAN As OracleParameter = New OracleParameter("v_ID_GIAO_NHAN", OracleType.VarChar, 28)
                pID_GIAO_NHAN.Value = ID_GIAO_NHAN
                myCommand.Parameters.Add(pID_GIAO_NHAN)

                Dim pSTATUS As OracleParameter = New OracleParameter("v_STATUS", OracleType.Number)
                pSTATUS.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSTATUS)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()

                Return pSTATUS.Value
            Catch ex As Exception
                Console.Write(ex.ToString)
                EventLog.WriteEntry("Loi goi : er_tt_giao_nhan_xoa", ex.ToString, System.Diagnostics.EventLogEntryType.[Error])
                Return 0
            End Try
        End Function
#End Region
#Region "er_tt_tui_thu_xoa"
        ' Output: 
        Public Function er_tt_tui_thu_xoa(ByVal ID_TT_TUI_THU As Double, ByVal ID_TUI_THU As String, ByVal ID_GIAO_NHAN As Double) As Integer
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As OracleConnection = New OracleConnection(ConnectionString)
                Dim myCommand As OracleCommand = New OracleCommand("er.er_tt_tui_thu_xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pID_TT_TUI_THU As OracleParameter = New OracleParameter("v_ID_TT_TUI_THU", OracleType.Number)
                pID_TT_TUI_THU.Value = ID_TT_TUI_THU
                myCommand.Parameters.Add(pID_TT_TUI_THU)

                Dim pID_TUI_THU As OracleParameter = New OracleParameter("v_ID_TUI_THU", OracleType.VarChar, 50)
                pID_TUI_THU.Value = ID_TUI_THU
                myCommand.Parameters.Add(pID_TUI_THU)

                Dim pID_GIAO_NHAN As OracleParameter = New OracleParameter("v_ID_GIAO_NHAN", OracleType.Number)
                pID_GIAO_NHAN.Value = ID_GIAO_NHAN
                myCommand.Parameters.Add(pID_GIAO_NHAN)

                Dim pSTATUS As OracleParameter = New OracleParameter("v_STATUS", OracleType.Number)
                pSTATUS.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSTATUS)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()

                Return pSTATUS.Value
            Catch ex As Exception
                Console.Write(ex.ToString)
                EventLog.WriteEntry("Loi goi : er_tt_tui_thu_xoa", ex.ToString, System.Diagnostics.EventLogEntryType.[Error])
                Return 0
            End Try
        End Function
#End Region
#Region "er_lay_tt_giao_nhan"
        'dataset tra ve : 
        'Id_Giao_Nhan           string
        'Id_Doi_Tac             double
        'ID_PHUONG_TIEN         double
        'MA_BC_KHAI_THAC        double
        'MA_BC_NHAN             double
        'NGAY_GIAO              double
        'DOT_GIAO               double
        'SO_LUONG_TUI           double
        'KHOI_LUONG             double
        'KHOI_LUONG_QD          double
        'Trang thai tra ve
        'Status = 2 (Da hoan tat)  ;  1 (lay duoc thong tin - khong co du lieu hoac co du lieu nhung chua hoan tat)  ;  0: loi
        Public Function er_lay_tt_giao_nhan(ByVal ID_GIAO_NHAN As String, ByVal Ma_Bc_Khai_Thac As Double, ByVal Loai_Giao_Nhan As Integer, ByRef Status As Integer) As DataSet
            Dim myConnection As OracleConnection = New OracleConnection(ConnectionString)
            Dim MyCommand As New OracleCommand
            Dim myDataSet As New DataSet
            Try
                MyCommand.Connection = myConnection
                MyCommand.CommandText = "er.er_lay_tt_giao_nhan"
                MyCommand.CommandType = CommandType.StoredProcedure

                Dim pID_GIAO_NHAN As OracleParameter = New OracleParameter("v_ID_GIAO_NHAN", OracleType.VarChar, 28)
                pID_GIAO_NHAN.Value = ID_GIAO_NHAN
                MyCommand.Parameters.Add(pID_GIAO_NHAN)

                Dim pMa_Bc_Khai_Thac As OracleParameter = New OracleParameter("v_Ma_Bc_Khai_Thac", OracleType.Number)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pLoai_Giao_Nhan As OracleParameter = New OracleParameter("v_Loai_Giao_Nhan", OracleType.Number)
                pLoai_Giao_Nhan.Value = Loai_Giao_Nhan
                MyCommand.Parameters.Add(pLoai_Giao_Nhan)

                Dim pSTATUS As OracleParameter = New OracleParameter("v_STATUS", OracleType.Number)
                pSTATUS.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSTATUS)


                MyCommand.Parameters.Add("p_ResultSet", OracleType.Cursor).Direction = ParameterDirection.Output
                Dim myAdapter As OracleDataAdapter = New OracleDataAdapter(MyCommand)


                myConnection.Open()
                myAdapter.Fill(myDataSet, "tt_giao_nhan")

                Status = pSTATUS.Value

                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
                EventLog.WriteEntry("Loi goi : er_lay_tt_giao_nhan", ex.ToString, System.Diagnostics.EventLogEntryType.[Error])
                Status = 0
                Return Nothing
            Finally
                'Close the connection and Dispose.
                myConnection.Close()
                MyCommand.Dispose()
            End Try
        End Function
#End Region
#Region "er_lay_tui_thu_giao_nhan"
        'dataset tra ve : 
        'ID_TT_TUI_THU          double
        'ID_TUI_THU             string
        'ID_DUONG_THU           double
        'ID_CHUYEN_THU          string
        'MA_BC_GUI              double
        'MA_BC_NHAN             double
        'CHUYEN_THU             double
        'TUI_SO                 Double
        'KHOI_LUONG             Double
        'KHOI_LUONG_QD          Double
        'TONG_SO_BP             Double
        'NGAY_DONG              Double
        'GIO_DONG               Double
        'LOAI_TUI_THU           Double
        'NGAY_XN_DEN            Double
        'GIO_XN_DEN             Double       
        'Trang thái trả về: 
        'Status = 2 (Da hoan tat)  ;  1 (lay duoc thong tin - khong co du lieu hoac co du lieu nhung chua hoan tat)  ;  0: loi
        Public Function er_lay_tui_thu_giao_nhan(ByVal ID_GIAO_NHAN As String, ByVal Ma_Bc_Khai_Thac As Double, ByVal Loai_Giao_Nhan As Integer, ByRef Status As Integer) As DataSet
            Dim myConnection As OracleConnection = New OracleConnection(ConnectionString)
            Dim MyCommand As New OracleCommand
            Dim myDataSet As New DataSet
            Try
                MyCommand.Connection = myConnection
                MyCommand.CommandText = "er.er_lay_tui_thu_giao_nhan"
                MyCommand.CommandType = CommandType.StoredProcedure

                Dim pID_GIAO_NHAN As OracleParameter = New OracleParameter("v_ID_GIAO_NHAN", OracleType.VarChar, 28)
                pID_GIAO_NHAN.Value = ID_GIAO_NHAN
                MyCommand.Parameters.Add(pID_GIAO_NHAN)

                Dim pMa_Bc_Khai_Thac As OracleParameter = New OracleParameter("v_Ma_Bc_Khai_Thac", OracleType.Number)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pLoai_Giao_Nhan As OracleParameter = New OracleParameter("v_Loai_Giao_Nhan", OracleType.Number)
                pLoai_Giao_Nhan.Value = Loai_Giao_Nhan
                MyCommand.Parameters.Add(pLoai_Giao_Nhan)

                Dim pSTATUS As OracleParameter = New OracleParameter("v_STATUS", OracleType.Number)
                pSTATUS.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSTATUS)

                MyCommand.Parameters.Add("p_ResultSet", OracleType.Cursor).Direction = ParameterDirection.Output
                Dim myAdapter As OracleDataAdapter = New OracleDataAdapter(MyCommand)

                myConnection.Open()
                myAdapter.Fill(myDataSet, "tui_thu_giao_nhan")

                Status = pSTATUS.Value

                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
                EventLog.WriteEntry("Loi goi : er_lay_tui_thu_giao_nhan", ex.ToString, System.Diagnostics.EventLogEntryType.[Error])
                Status = 0
                Return Nothing
            Finally
                'Close the connection and Dispose.
                myConnection.Close()
                MyCommand.Dispose()
            End Try
        End Function
#End Region
#Region "er_lay_tui_thu_da_nhan"
        'dataset tra ve : 
        'ID_TT_TUI_THU          double
        'ID_TUI_THU             string
        'ID_DUONG_THU           double
        'ID_CHUYEN_THU          string
        'MA_BC_GUI              double
        'MA_BC_NHAN             double
        'CHUYEN_THU             double
        'TUI_SO                 Double
        'KHOI_LUONG             Double
        'KHOI_LUONG_QD          Double
        'TONG_SO_BP             Double
        'NGAY_DONG              Double
        'GIO_DONG               Double
        'LOAI_TUI_THU           Double
        'NGAY_XN_DEN            Double
        'GIO_XN_DEN             Double       
        'Trang thái trả về: 
        'Status = 2 (Da hoan tat)  ;  1 (lay duoc thong tin - khong co du lieu hoac co du lieu nhung chua hoan tat)  ;  0: loi
        Public Function er_lay_tui_thu_da_nhan(ByVal ID_GIAO_NHAN As String, ByVal Ma_Bc_Khai_Thac As Double, ByRef Status As Integer) As DataSet
            Dim myConnection As OracleConnection = New OracleConnection(ConnectionString)
            Dim MyCommand As New OracleCommand
            Dim myDataSet As New DataSet
            Try
                MyCommand.Connection = myConnection
                MyCommand.CommandText = "er.er_lay_tui_thu_da_nhan"
                MyCommand.CommandType = CommandType.StoredProcedure

                Dim pID_GIAO_NHAN As OracleParameter = New OracleParameter("v_ID_GIAO_NHAN", OracleType.VarChar, 28)
                pID_GIAO_NHAN.Value = ID_GIAO_NHAN
                MyCommand.Parameters.Add(pID_GIAO_NHAN)

                Dim pMa_Bc_Khai_Thac As OracleParameter = New OracleParameter("v_Ma_Bc_Khai_Thac", OracleType.Number)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pSTATUS As OracleParameter = New OracleParameter("v_STATUS", OracleType.Number)
                pSTATUS.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSTATUS)

                MyCommand.Parameters.Add("p_ResultSet", OracleType.Cursor).Direction = ParameterDirection.Output
                Dim myAdapter As OracleDataAdapter = New OracleDataAdapter(MyCommand)

                myConnection.Open()
                myAdapter.Fill(myDataSet, "tui_thu_giao_nhan")

                Status = pSTATUS.Value

                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
                EventLog.WriteEntry("Loi goi : er_lay_tui_thu_da_nhan", ex.ToString, System.Diagnostics.EventLogEntryType.[Error])
                Status = 0
                Return Nothing
            Finally
                'Close the connection and Dispose.
                myConnection.Close()
                MyCommand.Dispose()
            End Try
        End Function
#End Region
#Region "er_lay_tui_thu_in_bc37_th"
        'dataset tra ve : 
        'SCT          double
        'Buu_Cuc_Dong             double
        'Buu_Cuc_Nhan           double
        'Tui_So          double
        'Dich_Vu              string
        'Khoi_Luong             double
        'Khoi_Luong_QD             double
        'Ghi_Chu                 string               
        'Trang thái trả về: 
        'Status = 2 (Da hoan tat)  ;  1 (lay duoc thong tin - khong co du lieu hoac co du lieu nhung chua hoan tat)  ;  0: loi
        Public Function er_lay_tui_thu_in_bc37_th(ByVal ID_GIAO_NHAN As String, ByVal Ma_Bc_Khai_Thac As Double, ByRef Status As Integer) As DataSet
            Dim myConnection As OracleConnection = New OracleConnection(ConnectionString)
            Dim MyCommand As New OracleCommand
            Dim myDataSet As New DataSet
            Try
                MyCommand.Connection = myConnection
                MyCommand.CommandText = "er.er_lay_tui_thu_in_bc37_th"
                MyCommand.CommandType = CommandType.StoredProcedure

                Dim pID_GIAO_NHAN As OracleParameter = New OracleParameter("v_ID_GIAO_NHAN", OracleType.VarChar, 28)
                pID_GIAO_NHAN.Value = ID_GIAO_NHAN
                MyCommand.Parameters.Add(pID_GIAO_NHAN)

                Dim pMa_Bc_Khai_Thac As OracleParameter = New OracleParameter("v_Ma_Bc_Khai_Thac", OracleType.Number)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pSTATUS As OracleParameter = New OracleParameter("v_STATUS", OracleType.Number)
                pSTATUS.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSTATUS)

                MyCommand.Parameters.Add("p_ResultSet", OracleType.Cursor).Direction = ParameterDirection.Output
                Dim myAdapter As OracleDataAdapter = New OracleDataAdapter(MyCommand)

                myConnection.Open()
                myAdapter.Fill(myDataSet, "tui_thu_giao_nhan")

                Status = pSTATUS.Value

                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
                EventLog.WriteEntry("Loi goi : er_lay_tui_thu_in_bc37_th", ex.ToString, System.Diagnostics.EventLogEntryType.[Error])
                Status = 0
                Return Nothing
            Finally
                'Close the connection and Dispose.
                myConnection.Close()
                MyCommand.Dispose()
            End Try
        End Function
#End Region
#Region "er_XN_Tui_Den"
        'dataset tra ve : 
        'ID_TT_TUI_THU          double
        'ID_TUI_THU             string
        'ID_DUONG_THU           double
        'ID_CHUYEN_THU          string
        'MA_BC_GUI              double
        'MA_BC_NHAN             double
        'CHUYEN_THU             double
        'TUI_SO                 Double
        'KHOI_LUONG             Double
        'KHOI_LUONG_QD          Double
        'TONG_SO_BP             Double
        'NGAY_DONG              Double
        'GIO_DONG               Double
        'LOAI_TUI_THU           Double
        'NGAY_XN_DEN            Double
        'GIO_XN_DEN             Double       
        'Trang thái trả về: 
        'Status = 2 (Da hoan tat)  ;  1 (lay duoc thong tin - khong co du lieu hoac co du lieu nhung chua hoan tat)  ;  0: loi
        Public Function er_XN_Tui_Den(ByVal ID_GIAO_NHAN As String, ByVal Id_Tui_Thu As String, ByVal Ma_Bc_Khai_Thac As Double, ByVal Loai_Giao_Nhan As Integer, ByRef Status As Integer) As DataSet

            Dim myConnection As OracleConnection = New OracleConnection(ConnectionString)
            Dim MyCommand As New OracleCommand
            Dim myDataSet As New DataSet
            Try
                MyCommand.Connection = myConnection
                MyCommand.CommandText = "er.er_XN_Tui_Den"
                MyCommand.CommandType = CommandType.StoredProcedure

                Dim pID_GIAO_NHAN As OracleParameter = New OracleParameter("v_ID_GIAO_NHAN", OracleType.VarChar, 28)
                pID_GIAO_NHAN.Value = ID_GIAO_NHAN
                MyCommand.Parameters.Add(pID_GIAO_NHAN)

                Dim pId_Tui_Thu As OracleParameter = New OracleParameter("v_Id_Tui_Thu", OracleType.VarChar, 29)
                pId_Tui_Thu.Value = Id_Tui_Thu
                MyCommand.Parameters.Add(pId_Tui_Thu)


                Dim pMa_Bc_Khai_Thac As OracleParameter = New OracleParameter("v_Ma_Bc_Khai_Thac", OracleType.Number)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pLoai_Giao_Nhan As OracleParameter = New OracleParameter("v_Loai_Giao_Nhan", OracleType.Number)
                pLoai_Giao_Nhan.Value = Loai_Giao_Nhan
                MyCommand.Parameters.Add(pLoai_Giao_Nhan)

                Dim pSTATUS As OracleParameter = New OracleParameter("v_STATUS", OracleType.Number)
                pSTATUS.Direction = ParameterDirection.Output
                MyCommand.Parameters.Add(pSTATUS)

                MyCommand.Parameters.Add("p_ResultSet", OracleType.Cursor).Direction = ParameterDirection.Output
                Dim myAdapter As OracleDataAdapter = New OracleDataAdapter(MyCommand)

                myConnection.Open()
                myAdapter.Fill(myDataSet, "XN_Tui_Den")

                Status = pSTATUS.Value

                Return myDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
                EventLog.WriteEntry("Loi goi : er_XN_Tui_Den", ex.ToString, System.Diagnostics.EventLogEntryType.[Error])
                Status = 0
                Return Nothing
            Finally
                'Close the connection and Dispose.
                myConnection.Close()
                MyCommand.Dispose()
            End Try
        End Function

#End Region
#Region "er_tt_tsl_tui_thu"
        Public Function er_tt_tsl_tui_thu(ByVal id_tt_tui_thu As Integer, ByVal tinh_trang_tsl As Integer) As Boolean
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As OracleConnection = New OracleConnection(ConnectionString)
                Dim myCommand As OracleCommand = New OracleCommand("er.er_tt_tsl_tui_thu", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pid_tt_tui_thu As OracleParameter = New OracleParameter("v_id_tt_tui_thu", OracleType.Number)
                pid_tt_tui_thu.Value = id_tt_tui_thu
                myCommand.Parameters.Add(pid_tt_tui_thu)

                Dim ptinh_trang_tsl As OracleParameter = New OracleParameter("v_tinh_trang_tsl", OracleType.Number)
                ptinh_trang_tsl.Value = tinh_trang_tsl
                myCommand.Parameters.Add(ptinh_trang_tsl)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()

                Return True

            Catch ex As Exception
                Console.Write(ex.ToString)
                Return False
            End Try
        End Function
#End Region
#Region "er_lay_loai_phuong_tien"
        Public Function er_lay_loai_phuong_tien(ByVal Id_Phuong_Tien As Integer, ByRef Status As Integer) As String
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As OracleConnection = New OracleConnection(ConnectionString)
                Dim myCommand As OracleCommand = New OracleCommand("er.er_lay_loai_phuong_tien", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Phuong_Tien As OracleParameter = New OracleParameter("v_id_loai_phuong_tien", OracleType.Number)
                pId_Phuong_Tien.Value = Id_Phuong_Tien
                myCommand.Parameters.Add(pId_Phuong_Tien)

                Dim pStatus As OracleParameter = New OracleParameter("v_status", OracleType.Number)
                pStatus.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pStatus)

                Dim pLoai_Phuong_Tien As OracleParameter = New OracleParameter("v_loai_phuong_tien", OracleType.VarChar)
                pLoai_Phuong_Tien.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pLoai_Phuong_Tien)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()

                Status = pStatus.Value
                Return pLoai_Phuong_Tien.Value

            Catch ex As Exception
                Console.Write(ex.ToString)
                Status = 0
                Return ""
            End Try
        End Function
#End Region
#Region "er_tui_thu_cap_nhat_tt_nhan"
        Public Function er_tui_thu_cap_nhat_tt_nhan(ByVal id_giao_nhan As String, ByVal id_tt_tui_thu As Integer, ByVal id_tui_thu As String, ByVal ngay_xn_den As Integer, ByVal gio_xn_den As Integer) As Integer
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As OracleConnection = New OracleConnection(ConnectionString)
                Dim myCommand As OracleCommand = New OracleCommand("er.er_tui_thu_cap_nhat_tt_nhan", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pID_GIAO_NHAN As OracleParameter = New OracleParameter("v_ID_GIAO_NHAN", OracleType.VarChar, 28)
                pID_GIAO_NHAN.Value = id_giao_nhan
                myCommand.Parameters.Add(pID_GIAO_NHAN)

                Dim pID_TT_TUI_THU As OracleParameter = New OracleParameter("v_ID_TT_TUI_THU", OracleType.Number)
                pID_TT_TUI_THU.Value = id_tt_tui_thu
                myCommand.Parameters.Add(pID_TT_TUI_THU)

                Dim pID_TUI_THU As OracleParameter = New OracleParameter("v_ID_TUI_THU", OracleType.VarChar, 50)
                pID_TUI_THU.Value = id_tui_thu
                myCommand.Parameters.Add(pID_TUI_THU)

                Dim pNGAY_XN_DEN As OracleParameter = New OracleParameter("v_NGAY_XN_DEN", OracleType.Number)
                pNGAY_XN_DEN.Value = ngay_xn_den
                myCommand.Parameters.Add(pNGAY_XN_DEN)

                Dim pGIO_XN_DEN As OracleParameter = New OracleParameter("v_GIO_XN_DEN", OracleType.Number)
                pGIO_XN_DEN.Value = gio_xn_den
                myCommand.Parameters.Add(pGIO_XN_DEN)

                Dim pSTATUS As OracleParameter = New OracleParameter("v_STATUS", OracleType.Number)
                pSTATUS.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSTATUS)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()

                Return pSTATUS.Value

            Catch ex As Exception
                Console.Write(ex.ToString)
                Return 0
            End Try
        End Function
#End Region
#Region "er_dot_giao_max_theo_ngay"
        Public Function er_dot_giao_max_theo_ngay(ByVal ma_bc_khai_thac As Integer, ByVal ma_bc_nhan As Integer, ByVal ngay_giao As Integer, ByRef Status As Integer) As Integer
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As OracleConnection = New OracleConnection(ConnectionString)
                Dim myCommand As OracleCommand = New OracleCommand("er.er_dot_giao_max_theo_ngay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pma_bc_khai_thac As OracleParameter = New OracleParameter("v_ma_bc_khai_thac", OracleType.Number)
                pma_bc_khai_thac.Value = ma_bc_khai_thac
                myCommand.Parameters.Add(pma_bc_khai_thac)

                Dim pma_bc_nhan As OracleParameter = New OracleParameter("v_ma_bc_nhan", OracleType.Number)
                pma_bc_nhan.Value = ma_bc_nhan
                myCommand.Parameters.Add(pma_bc_nhan)

                Dim pngay_giao As OracleParameter = New OracleParameter("v_ngay_giao", OracleType.Number)
                pngay_giao.Value = ngay_giao
                myCommand.Parameters.Add(pngay_giao)

                Dim pStatus As OracleParameter = New OracleParameter("v_status", OracleType.Number)
                pStatus.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pStatus)

                Dim p_Result As OracleParameter = New OracleParameter("p_Result", OracleType.Number)
                p_Result.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(p_Result)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()

                Status = pStatus.Value
                Return p_Result.Value

            Catch ex As Exception
                Console.Write(ex.ToString)
                Status = 0
                Return ""
            End Try
        End Function
#End Region
    End Class
#End Region
#Region "ORA_Receptacle_Ham_Dung_Chung"
    Public NotInheritable Class ORA_Receptacle_Ham_Dung_Chung
        Private Sub New()
        End Sub
        Public Const GLa_Giao_Tui As Integer = 0
        Public Const GLa_Nhan_Tui As Integer = 1

        Public Shared Function Create_Id_Giao_Nhan(ByVal mMa_Bc_Khai_Thac As Integer, ByVal mMa_Bc_Nhan As Integer, ByVal mNgay_Giao As Integer, ByVal mId_Doi_Tac As Integer, ByVal mDot_Giao As Integer) As String
            Return mMa_Bc_Khai_Thac.ToString & mMa_Bc_Nhan.ToString & mNgay_Giao.ToString & mId_Doi_Tac.ToString & mDot_Giao.ToString()
        End Function
    End Class
#End Region

End Namespace


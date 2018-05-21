Imports System
Imports System.Data
Imports System.Data.SqlClient

Namespace EMS
#Region "UNB"
    Public Class Predes_UNB
        Public UNB_S001 As String
        Public UNB_001 As String
        Public UNB_002 As String
        Public UNB_S002 As String
        Public UNB_S003 As String
        Public UNB_S004 As String
        Public UNB_0017 As String
        Public UNB_0019 As String
        Public UNB_S005 As String
    End Class
#End Region

#Region "UNH"
    Public Class Predes_UNH
        Public UNH_0062 As String
        Public UNH_S009 As String
        Public UNH_0065 As String
        Public UNH_0052 As String
        Public UNH_0054 As String
        Public UNH_0051 As String
    End Class
#End Region

#Region "BGM"
    Public Class Predes_BGM
        Public BGM_C002 As String
        Public BGM_1004 As String
        Public BGM_C570 As String
        Public BGM_1225 As String
        Public BGM_C506 As String
        Public BGM_C507 As String
        Public BGM_4343 As String
    End Class
#End Region

#Region "Dispatch Information"
    Public Class Predes_Dispatch_Information
        Public Id_Chuyen_thu As String
        Public Ma_BC_KT As String
        Public Ma_BC As String
        Public So_Chuyen_thu As Int32
        Public Phan_loai As String
        Public Tong_So_tui As Int32
        Public Tong_KL As Int32
        Public Tong_KLBP As Int32
        Public Tong_So_BP As Int32
        Public Ngay_dong As Int32
        Public Gio_dong As Int32
    End Class
#End Region

#Region "DTM"
    Public Class Predes_DTM
        Public DTM_C507 As String
        Public DTM_2005 As String
        Public DTM_2380 As String
        Public DTM_2379 As String
    End Class
#End Region

#Region "TDT"
    Public Class Predes_TDT
        Public TDT_8051 As String
        Public TDT_8028 As String
        Public TDT_C220 As String
        Public TDT_8067 As String
        Public TDT_C222 As String
        Public TDT_C228 As String
        Public TDT_C040 As String
        Public TDT_3127 As String
        Public TDT_1131 As String
        Public TDT_3055 As String
    End Class
#End Region

#Region "LOC"
    Public Class Predes_LOC
        Public LOC_3227 As String
        Public LOC_3225 As String
        Public LOC_1131 As String
        Public LOC_3055 As String
    End Class
#End Region

#Region "DTM_Flight"
    Public Class Predes_DTM_Flight
        Public DTM_2005 As String
        Public DTM_2380 As String
        Public DTM_2379 As String
    End Class
#End Region

#Region "Flight Schedules"
    Public Class Predes_Flight_Schedules
        Public Flight_number As String
        Public Airlines As String
        Public From_Country As String
        Public To_Country As String
        Public From_Airport As String
        Public To_Airport As String
        Public Dep_Time As String
        Public Arr_Time As String
        Public Over_Day As Int32
    End Class
#End Region

#Region "GID"
    Public Class Predes_GID
        Public GID_1496 As String
        Public GID_C213 As String
        Public GID_7224 As String
        Public GID_7065 As String
    End Class
#End Region

#Region "PCI"
    Public Class Predes_PCI
        Public PCI_4233 As String
        Public PCI_C210 As String
        Public PCI_C506 As String
        Public PCI_1153 As String
        Public PCI_1154 As String
        Public PCI_1156 As String
    End Class
#End Region

#Region "UNT"
    Public Class Predes_UNT
        Public UNT_0074 As String
        Public UNT_0062 As String
    End Class
#End Region

#Region "UNZ"
    Public Class Predes_UNZ
        Public UNZ_0036 As String
        Public UNZ_0020 As String
    End Class
#End Region

#Region "PREDES"
    Public Class Predes
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

        Dim myEdi_MailBox As New EDI_mailbox(ConnectionString)

#Region "Lấy UNB"
        Public Function Get_UNB(ByVal myMailBox As MailBox, ByVal PREDES_INTREF As Int32) As Predes_UNB
            Dim myPredes_UNB As Predes_UNB = New Predes_UNB
            myPredes_UNB.UNB_S001 = "UNOA:1"
            myPredes_UNB.UNB_001 = "UNOA"
            myPredes_UNB.UNB_002 = "1"
            myPredes_UNB.UNB_S002 = myMailBox.S_BAG_MAILBOX & ":UP"
            myPredes_UNB.UNB_S003 = myMailBox.BAG_MAILBOX & ":DL"
            myPredes_UNB.UNB_S004 = (DateTime.Now.Year.ToString().Substring(2) + (IIf(DateTime.Now.Month > 9, DateTime.Now.Month.ToString(), "0" & DateTime.Now.Month.ToString())) + (IIf(DateTime.Now.Day > 9, DateTime.Now.Day.ToString(), "0" & DateTime.Now.Day.ToString())) & ":") + (IIf(DateTime.Now.Hour > 9, DateTime.Now.Hour.ToString(), "0" & DateTime.Now.Hour.ToString())) + (IIf(DateTime.Now.Minute > 9, DateTime.Now.Minute.ToString(), "0" & DateTime.Now.Minute.ToString()))
            myPredes_UNB.UNB_0017 = DateTime.Now.Year.ToString() & IIf(DateTime.Now.Month > 9, DateTime.Now.Month.ToString(), "0" & DateTime.Now.Month.ToString()) & IIf(DateTime.Now.Day > 9, DateTime.Now.Day.ToString(), "0" & DateTime.Now.Day.ToString())
            myPredes_UNB.UNB_0019 = (IIf(DateTime.Now.Hour > 9, DateTime.Now.Hour.ToString(), "0" & DateTime.Now.Hour.ToString())) + (IIf(DateTime.Now.Minute > 9, DateTime.Now.Minute.ToString(), "0" & DateTime.Now.Minute.ToString()))
            myPredes_UNB.UNB_S005 = PREDES_INTREF.ToString()

            myPredes_UNB.UNB_S005 = "INTREF" + PREDES_INTREF.ToString()
            Return myPredes_UNB
        End Function
#End Region

#Region "Lấy UNH"
        Public Function Get_UNH() As Predes_UNH
            Dim obj As New Random
            Dim myPredes_UNH As Predes_UNH = New Predes_UNH
            myPredes_UNH.UNH_0062 = ("MESREF" & (IIf(DateTime.Now.Month > 9, DateTime.Now.Month.ToString(), "0" & DateTime.Now.Month.ToString()))) + (IIf(DateTime.Now.Day > 9, DateTime.Now.Day.ToString(), "0" & DateTime.Now.Day.ToString())) + obj.[Next](9999).ToString()

            myPredes_UNH.UNH_S009 = "PREDES" & ":" & "2" & ":" & "912" & ":" & "UP"
            myPredes_UNH.UNH_0065 = "PREDES"
            myPredes_UNH.UNH_0052 = "2"
            myPredes_UNH.UNH_0054 = "912"
            myPredes_UNH.UNH_0051 = "UP"

            Return myPredes_UNH
        End Function
#End Region

#Region "Lấy BGM"
        Public Function Get_BGM(ByVal Ma_BC_KT As String, ByVal Ma_BC As String, ByVal phan_loai As String, ByVal ngay As Int32, ByVal So_chuyen_thu As Int32) As Predes_BGM
            Dim myPredes_BGM As Predes_BGM = New Predes_BGM
            Dim s_chthu = "000" + So_chuyen_thu.ToString()
            s_chthu = s_chthu.Substring(s_chthu.Length() - 4, 4)

            myPredes_BGM.BGM_1004 = Ma_BC_KT & Ma_BC & "A" & phan_loai & ngay.ToString().Substring(3, 1) & s_chthu
            myPredes_BGM.BGM_4343 = "AB"
            myPredes_BGM.BGM_1225 = ""
            myPredes_BGM.BGM_C002 = ""
            myPredes_BGM.BGM_C506 = ""
            myPredes_BGM.BGM_C507 = ""
            myPredes_BGM.BGM_C570 = ""
            Return myPredes_BGM
        End Function
#End Region

#Region "Lấy thông tin chuyến thư"
        Public Function Get_Predes_Dispatch_Information(ByVal Id_Chuyen_thu As String, ByVal myEdi_MailBox As EDI_mailbox) As Predes_Dispatch_Information
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Get_Predes_Dispatch_Information", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Chuyen_thu As SqlParameter = New SqlParameter("@Id_Chuyen_thu", SqlDbType.VarChar, 28)
                pId_Chuyen_thu.Value = Id_Chuyen_thu
                myCommand.Parameters.Add(pId_Chuyen_thu)

                Dim pSo_Chuyen_Thu As SqlParameter = New SqlParameter("@So_Chuyen_Thu", SqlDbType.Int)
                pSo_Chuyen_Thu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSo_Chuyen_Thu)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int)
                pNgay_Dong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_Dong)

                Dim pGio_Dong As SqlParameter = New SqlParameter("@Gio_Dong", SqlDbType.Int)
                pGio_Dong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGio_Dong)

                Dim pTong_So_Tui As SqlParameter = New SqlParameter("@Tong_So_Tui", SqlDbType.Int)
                pTong_So_Tui.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTong_So_Tui)

                Dim pTong_So_BP As SqlParameter = New SqlParameter("@Tong_So_BP", SqlDbType.Int)
                pTong_So_BP.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTong_So_BP)

                Dim pTong_KL As SqlParameter = New SqlParameter("@Tong_KL", SqlDbType.Int)
                pTong_KL.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTong_KL)

                Dim pTong_KLBP As SqlParameter = New SqlParameter("@Tong_KLBP", SqlDbType.Int)
                pTong_KLBP.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTong_KLBP)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.VarChar, 7)
                pMa_Bc_Khai_Thac.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.VarChar, 7)
                pMa_Bc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myPredes_Dispatch_Information As Predes_Dispatch_Information = New Predes_Dispatch_Information

                myPredes_Dispatch_Information.Ma_BC = myEdi_MailBox.Get_IPMC_Code(Int32.Parse(pMa_Bc.Value.ToString()))
                myPredes_Dispatch_Information.Ma_BC_KT = myEdi_MailBox.Get_IPMC_Code(Int32.Parse(pMa_Bc_Khai_Thac.Value.ToString()))
                myPredes_Dispatch_Information.So_Chuyen_thu = Int32.Parse(pSo_Chuyen_Thu.Value.ToString())
                myPredes_Dispatch_Information.Ngay_dong = Int32.Parse(pNgay_Dong.Value.ToString())
                myPredes_Dispatch_Information.Gio_dong = Int32.Parse(pGio_Dong.Value.ToString())
                myPredes_Dispatch_Information.Tong_So_tui = Int32.Parse(pTong_So_Tui.Value.ToString())
                myPredes_Dispatch_Information.Tong_So_BP = Int32.Parse(pTong_So_BP.Value.ToString())
                myPredes_Dispatch_Information.Tong_KL = Int32.Parse(pTong_KL.Value.ToString())
                myPredes_Dispatch_Information.Tong_KLBP = Int32.Parse(pTong_KLBP.Value.ToString())
                '                If Id_Chuyen_thu.Length() = 27 Then
                myPredes_Dispatch_Information.Phan_loai = Id_Chuyen_thu.Substring(Id_Chuyen_thu.Length() - 2, 2)
                '                End If
                Return myPredes_Dispatch_Information
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function

#End Region

#Region "Lấy DTM"
        Public Function Get_DTM(ByVal Ngay_dong As Int32, ByVal Gio_dong As Int32) As Predes_DTM
            Dim myPredes_DTM As Predes_DTM = New Predes_DTM
            Dim s_ngay As String
            s_ngay = Ngay_dong.ToString().Substring(2, 6)
            Dim hh As String
            Dim mm As String

            hh = ""
            mm = ""

            If (Gio_dong.ToString().Length = 4) Then
                hh = Gio_dong.ToString().Substring(0, 2)
                mm = Gio_dong.ToString().Substring(2, 2)
            End If

            If (Gio_dong.ToString().Length = 3) Then
                If (Int32.Parse(Gio_dong.ToString().Substring(0, 2)) > 12) Then
                    hh = "0" & Gio_dong.ToString().Substring(0, 1)
                    mm = Gio_dong.ToString().Substring(1, 2)
                Else
                    hh = Gio_dong.ToString().Substring(0, 2)
                    mm = "0" & Gio_dong.ToString().Substring(2, 1)
                End If
            End If

            If (Gio_dong.ToString().Length = 2) Then
                hh = "0" & Gio_dong.ToString().Substring(0, 1)
                mm = "0" & Gio_dong.ToString().Substring(1, 1)
            End If

            myPredes_DTM.DTM_C507 = "164:" & s_ngay + hh + mm + ":201"
            myPredes_DTM.DTM_2005 = "164"
            myPredes_DTM.DTM_2380 = Ngay_dong.ToString() + hh + mm
            myPredes_DTM.DTM_2379 = "201"

            Return myPredes_DTM
        End Function
#End Region

#Region "Lấy TDT"
        Public Function Get_TDT(ByVal Id_duong_thu As String, ByVal Ngay_dong As Int32, ByVal So_Chuyen_thu As Int32) As Predes_TDT()

            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myCommand As SqlCommand = New SqlCommand("Get_Flight_Information", myConnection)

            ' Sử dụng Store Procedure
            myCommand.CommandType = CommandType.StoredProcedure
            ' Thêm các Parameters vào thủ tục            
            Dim pId_duong_thu As SqlParameter = New SqlParameter("@Id_duong_thu", SqlDbType.VarChar, 14)
            pId_duong_thu.Value = Id_duong_thu
            myCommand.Parameters.Add(pId_duong_thu)

            Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int)
            pNgay_Dong.Value = Ngay_dong
            myCommand.Parameters.Add(pNgay_Dong)

            Dim pSo_Chuyen_thu As SqlParameter = New SqlParameter("@So_Chuyen_thu", SqlDbType.Int)
            pSo_Chuyen_thu.Value = So_Chuyen_thu
            myCommand.Parameters.Add(pSo_Chuyen_thu)

            Dim pLoai_Van_Chuyen As SqlParameter = New SqlParameter("@Loai_Van_Chuyen", SqlDbType.Int)
            pLoai_Van_Chuyen.Direction = ParameterDirection.Output
            myCommand.Parameters.Add(pLoai_Van_Chuyen)

            Dim pSo_hieu As SqlParameter = New SqlParameter("@So_hieu", SqlDbType.VarChar, 20)
            pSo_hieu.Direction = ParameterDirection.Output
            myCommand.Parameters.Add(pSo_hieu)

            myConnection.Open()
            myCommand.ExecuteNonQuery()
            myConnection.Close()
            myConnection.Dispose()

            If (pSo_hieu.Value.ToString().Length() >= 5) Then
                Dim i As Int32
                i = 0
                For j As Integer = 0 To pSo_hieu.Value.ToString().Length() - 1
                    Dim str As String
                    str = ""
                    str = pSo_hieu.Value.ToString().Substring(j, 1)
                    If str = "/" Then
                        i = i + 1
                    End If
                Next
                Dim flight As String
                flight = ""

                Dim flight_number(i) As String
                Dim myPredes_TDT(i) As Predes_TDT

                i = 0
                For j As Integer = 0 To pSo_hieu.Value.ToString().Length() - 1
                    Dim str As String
                    str = ""
                    str = pSo_hieu.Value.ToString().Substring(j, 1)
                    If str = "/" Then
                        flight_number(i) = flight
                        i = i + 1
                        flight = ""
                    Else
                        flight = flight + str
                    End If
                Next
                flight_number(i) = flight

                For j As Integer = 0 To flight_number.Length - 1
                    Dim myPredes_TDT_i As New Predes_TDT
                    With myPredes_TDT_i
                        .TDT_8051 = "20"
                        .TDT_8028 = flight_number(j)
                        .TDT_C220 = pLoai_Van_Chuyen.Value.ToString()
                        .TDT_8067 = ""
                        .TDT_C222 = ""
                        .TDT_C228 = ""
                        .TDT_C040 = flight_number(j).Substring(0, 2) & ":172:3"
                        .TDT_3127 = ""
                        .TDT_1131 = "172"
                        .TDT_3055 = "3"
                    End With
                    myPredes_TDT(j) = myPredes_TDT_i
                Next
                Return myPredes_TDT
            Else
                Dim myPredes_TDT(0) As Predes_TDT
                Return myPredes_TDT
            End If
        End Function
#End Region

#Region "Lấy LOC"
        Public Function Get_LOC(ByVal airport As String, ByVal direction As Int32) As Predes_LOC
            Dim myPredes_LOC As New Predes_LOC
            myPredes_LOC.LOC_3227 = direction.ToString()
            myPredes_LOC.LOC_3225 = airport.ToString()
            myPredes_LOC.LOC_1131 = "163"
            myPredes_LOC.LOC_3055 = "3"
            Return myPredes_LOC
        End Function
#End Region

#Region "Lấy GID"
        Public Function Get_GID() As Predes_GID
            Dim myPredes_GID As New Predes_GID

            myPredes_GID.GID_1496 = ""
            myPredes_GID.GID_C213 = "1:BG"
            myPredes_GID.GID_7224 = "1"
            myPredes_GID.GID_7065 = "PU"

            Return myPredes_GID
        End Function
#End Region

#Region "Lấy PCI"
        Public Function Get_PCI(ByVal So_chuyen_thu As Int32, ByVal Tui_So As Int32, ByVal Khoi_luong_BP As Int32, ByVal Khoi_luong_Vo_Tui As Int32, ByVal MA_BC_KT As String, ByVal MA_BC As String, ByVal phan_loai As String, ByVal Ngay_dong As Int32, ByVal Tui_F As Int32, ByVal Ma_nuoc As String) As Predes_PCI
            Dim myPredes_PCI As New Predes_PCI
            Dim s_chthu As String = ""
            Dim s_tuiso As String = ""
            Dim s_khoiluong As String = ""
            Dim kl As Decimal = 0
            s_chthu = "0000" & So_chuyen_thu.ToString()
            s_chthu = s_chthu.Substring(s_chthu.Length - 4, 4)

            s_tuiso = "000" & Tui_So.ToString()
            s_tuiso = s_tuiso.Substring(s_tuiso.Length - 3, 3)
            If Tui_F = -1 Then
                s_tuiso = s_tuiso & "1"
            Else
                s_tuiso = s_tuiso & "0"
            End If
            kl = (Decimal.Parse(Khoi_luong_BP + Khoi_luong_Vo_Tui) / 100)

            kl = Decimal.Round(kl, 0)
            s_khoiluong = kl.ToString()

            s_khoiluong = "000" & s_khoiluong
            s_khoiluong = s_khoiluong.Substring(s_khoiluong.Length - 4, 4)

            myPredes_PCI.PCI_4233 = ""
            myPredes_PCI.PCI_C210 = ""
            myPredes_PCI.PCI_C506 = "CW:" & MA_BC_KT + MA_BC & "A" & phan_loai & Ngay_dong.ToString().Substring(3, 1) & s_chthu & s_tuiso & "0" + s_khoiluong & ":" + Tui_So.ToString()
            myPredes_PCI.PCI_1153 = "CW"
            myPredes_PCI.PCI_1154 = MA_BC_KT & MA_BC & Ma_nuoc & Ngay_dong.ToString() + So_chuyen_thu.ToString() + Tui_So.ToString()
            myPredes_PCI.PCI_1156 = Tui_So.ToString()

            Return myPredes_PCI
        End Function
#End Region

#Region "Lấy DTM_Flight"
        Public Function Get_DTM_Flight(ByVal Ngay_dong As Int32, ByVal Gio As String, ByVal direction As Int32, ByVal over_day As Int32, ByVal departure As Int32) As Predes_DTM_Flight
            Dim ngay As String
            Dim ngay_sau As String
            ngay = Ngay_dong.ToString()
            Dim frmt As System.IFormatProvider = New System.Globalization.CultureInfo("en-US", True)
            Dim dt As DateTime = DateTime.ParseExact(((ngay.Substring(4, 2) & "/") + ngay.Substring(6, 2) & "/") + ngay.Substring(2, 2), "MM/dd/yy", frmt)
            Dim tmp_day As DateTime = dt.AddDays(1)
            ngay_sau = tmp_day.Year.ToString() + (IIf(Int32.Parse(tmp_day.Month.ToString()) > 9, tmp_day.Month.ToString(), "0" & tmp_day.Month.ToString())) + (IIf(Int32.Parse(tmp_day.Day.ToString()) > 9, tmp_day.Day.ToString(), "0" & tmp_day.Day.ToString()))

            Dim myPredes_DTM_Flight As New Predes_DTM_Flight
            If departure = 0 Then
                myPredes_DTM_Flight.DTM_2005 = "189"
            Else
                myPredes_DTM_Flight.DTM_2005 = "232"
            End If
            If direction = 0 Then
                myPredes_DTM_Flight.DTM_2380 = ngay.Substring(2, 6) + Gio.ToString()
            Else
                If over_day = 0 Then
                    myPredes_DTM_Flight.DTM_2380 = ngay.Substring(2, 6) + Gio.ToString()
                Else
                    'Dim frmt As System.IFormatProvider = New System.Globalization.CultureInfo("en-US", True)
                    'Dim dt As DateTime = DateTime.ParseExact(((ngay.Substring(4, 2) & "/") + ngay.Substring(6, 2) & "/") + ngay.Substring(2, 2), "MM/dd/yy", frmt)
                    'Dim tmp_day As DateTime = dt.AddDays(1)
                    'ngay = tmp_day.Year.ToString() + (IIf(Int32.Parse(tmp_day.Month.ToString()) > 9, tmp_day.Month.ToString(), "0" & tmp_day.Month.ToString())) + (IIf(Int32.Parse(tmp_day.Day.ToString()) > 9, tmp_day.Day.ToString(), "0" & tmp_day.Day.ToString()))
                    myPredes_DTM_Flight.DTM_2380 = ngay_sau.Substring(2, 6) + Gio.ToString()
                End If
            End If
            myPredes_DTM_Flight.DTM_2379 = "201"
            Return myPredes_DTM_Flight
        End Function
#End Region

#Region "Lấy lich bay"
        Public Function Get_Flight_Schedule(ByVal So_Hieu As String) As Predes_Flight_Schedules
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Get_Flight_Schedule", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pSo_Hieu As SqlParameter = New SqlParameter("@So_Hieu", SqlDbType.VarChar, 6)
                pSo_Hieu.Value = So_Hieu
                myCommand.Parameters.Add(pSo_Hieu)

                Dim pHang_Hang_Khong As SqlParameter = New SqlParameter("@Hang_Hang_Khong", SqlDbType.VarChar, 2)
                pHang_Hang_Khong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHang_Hang_Khong)

                Dim pNuoc_Xuat_Phat As SqlParameter = New SqlParameter("@Nuoc_Xuat_Phat", SqlDbType.VarChar, 2)
                pNuoc_Xuat_Phat.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNuoc_Xuat_Phat)

                Dim pSan_Bay_Xuat_Phat As SqlParameter = New SqlParameter("@San_Bay_Xuat_Phat", SqlDbType.VarChar, 3)
                pSan_Bay_Xuat_Phat.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Bay_Xuat_Phat)

                Dim pGio_Xuat_Phat As SqlParameter = New SqlParameter("@Gio_Xuat_Phat", SqlDbType.VarChar, 4)
                pGio_Xuat_Phat.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGio_Xuat_Phat)

                Dim pNuoc_Den As SqlParameter = New SqlParameter("@Nuoc_Den", SqlDbType.VarChar, 2)
                pNuoc_Den.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNuoc_Den)

                Dim pSan_Bay_Den As SqlParameter = New SqlParameter("@San_Bay_Den", SqlDbType.VarChar, 3)
                pSan_Bay_Den.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Bay_Den)

                Dim pGio_Den As SqlParameter = New SqlParameter("@Gio_Den", SqlDbType.VarChar, 4)
                pGio_Den.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGio_Den)

                Dim pQua_Ngay As SqlParameter = New SqlParameter("@Qua_Ngay", SqlDbType.Int)
                pQua_Ngay.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pQua_Ngay)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myPredes_Flight_Schedules As Predes_Flight_Schedules = New Predes_Flight_Schedules
                myPredes_Flight_Schedules.Flight_number = So_Hieu
                myPredes_Flight_Schedules.Airlines = pHang_Hang_Khong.Value.ToString()
                myPredes_Flight_Schedules.From_Country = pNuoc_Xuat_Phat.Value.ToString()
                myPredes_Flight_Schedules.From_Airport = pSan_Bay_Xuat_Phat.Value.ToString()
                myPredes_Flight_Schedules.Dep_Time = pGio_Xuat_Phat.Value.ToString()
                myPredes_Flight_Schedules.To_Country = pNuoc_Den.Value.ToString()
                myPredes_Flight_Schedules.To_Airport = pSan_Bay_Den.Value.ToString()
                myPredes_Flight_Schedules.Arr_Time = pGio_Den.Value.ToString()
                myPredes_Flight_Schedules.Over_Day = Int32.Parse(pQua_Ngay.Value.ToString())
                Return myPredes_Flight_Schedules
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function

#End Region

#Region "Lấy danh sach cac ban tin chua truyen"
        Public Function Get_Predes_UnSending() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Get_Predes_UnSending", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Get_Predes_UnSending")
                myConnection.Close()
                myConnection.Dispose()

                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function

#End Region

#Region "Lấy danh sach đầy đủ cac ban tin chua truyen"
        Public Function Danh_Sach_Predes_UnSending() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Get_EDI_UnSending", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pMESSAGE_TYPE As SqlParameter = New SqlParameter("@MESSAGE_TYPE", SqlDbType.VarChar, 28)
                pMESSAGE_TYPE.Value = "PREDES"
                myCommand.Parameters.Add(pMESSAGE_TYPE)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Predes_Danh_Sach_Predes_UnSending")
                myConnection.Close()
                myConnection.Dispose()

                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function

#End Region

#Region "Lấy danh sach tui thu"
        Public Function Get_E2(ByVal So_Hieu As String) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Get_Flight_Schedule", myConnection)
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Lấy UNT"
        Public Function Get_UNT(ByVal numMessages As Int32, ByVal tblunhstr As String) As Predes_UNT
            Dim myPredes_UNT As New Predes_UNT

            myPredes_UNT.UNT_0074 = numMessages.ToString()
            myPredes_UNT.UNT_0062 = tblunhstr

            Return myPredes_UNT
        End Function
#End Region

#Region "Lấy UNZ"
        Public Function Get_UNZ(ByVal tblunbstr As String) As Predes_UNZ
            Dim myPredes_UNZ As New Predes_UNZ

            myPredes_UNZ.UNZ_0036 = "1"
            myPredes_UNZ.UNZ_0020 = tblunbstr

            Return myPredes_UNZ
        End Function
#End Region


#Region "PREDES_Cap_Nhat_Them"
        Public Function PREDES_Cap_Nhat_Them(ByVal ID_CHUYEN_THU As String, ByVal ID_DUONG_THU As String, ByVal INTREF As String, ByVal NGAY As Integer, ByVal GIO As Integer, ByVal MESSAGE As String, ByVal SEND As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "ADDING_EDI"
            MyCommand.CommandType = CommandType.StoredProcedure

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pID_CHUYEN_THU As SqlParameter = New SqlParameter("@ID_CHUYEN_THU", SqlDbType.VarChar, 28)
                pID_CHUYEN_THU.Value = ID_CHUYEN_THU
                MyCommand.Parameters.Add(pID_CHUYEN_THU)

                Dim pID_DUONG_THU As SqlParameter = New SqlParameter("@ID_DUONG_THU", SqlDbType.VarChar, 14)
                pID_DUONG_THU.Value = ID_DUONG_THU
                MyCommand.Parameters.Add(pID_DUONG_THU)

                Dim pINTREF As SqlParameter = New SqlParameter("@INTREF", SqlDbType.VarChar, 14)
                pINTREF.Value = INTREF
                MyCommand.Parameters.Add(pINTREF)

                Dim pNGAY As SqlParameter = New SqlParameter("@NGAY", SqlDbType.Int, 0)
                pNGAY.Value = NGAY
                MyCommand.Parameters.Add(pNGAY)

                Dim pGIO As SqlParameter = New SqlParameter("@GIO", SqlDbType.Int, 0)
                pGIO.Value = GIO
                MyCommand.Parameters.Add(pGIO)

                Dim pMESSAGE As SqlParameter = New SqlParameter("@MESSAGE", SqlDbType.VarChar, 50)
                pMESSAGE.Value = MESSAGE
                MyCommand.Parameters.Add(pMESSAGE)

                Dim pSEND As SqlParameter = New SqlParameter("@SEND", SqlDbType.Int, 0)
                pSEND.Value = SEND
                MyCommand.Parameters.Add(pSEND)

                Dim pMESSAGE_TYPE As SqlParameter = New SqlParameter("@MESSAGE_TYPE", SqlDbType.VarChar, 6)
                pMESSAGE_TYPE.Value = "PREDES"
                MyCommand.Parameters.Add(pMESSAGE_TYPE)

                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()

                'Return numRows
                Return numRows

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
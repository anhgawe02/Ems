Imports System.Net
Imports System.IO
Namespace EMS
    Public Class Ham_Dung_Chung

#Region "Dinh dang 20081217 => 81217"
        Public Shared Function ConvertDateIntToInt_VNPOST(ByVal myDate As Integer) As Integer
            Return myDate.ToString.Substring(3, 5)
        End Function
#End Region

#Region "Convert string dd/MM/yyyy hh:mm:ss to datetim MM/dd/yyyy hh:mm:ss"
        Public Shared Function ConvertStringToDateTime(ByVal strdatetime As String) As Date
            Dim strdate(3) As String
            Dim strnewdate As String
            strdate = strdatetime.Split("/")
            strnewdate &= strdate(1) & "/" & strdate(0) & "/" & strdate(2)
            Return CDate(strnewdate)
        End Function
#End Region

#Region "Convert string MM/dd/yyyy hh:mm:ss to datetim dd/MM/yyyy hh:mm:ss"
        Public Shared Function ConvertStringToDateTime_VN(ByVal strdatetime As String) As Date
            Dim strdate(3) As String
            Dim strnewdate As String
            strdate = strdatetime.Split("/")
            strnewdate &= strdate(1) & "/" & strdate(0) & "/" & strdate(2)
            Return Convert.ToDateTime(strnewdate)
        End Function
#End Region

        'Dinh dang 12/17/2008 <=> 20081217
        Public Shared Function ConvertDateToInt(ByVal myDate As Date) As Integer
            Return myDate.Year * 10000 + myDate.Month * 100 + myDate.Day
        End Function
        'Dinh dang 20081217 <=> 12/17/2008
        Public Shared Function ConvertIntToDate(ByVal myDate As Integer) As Date
            If myDate.ToString.Length <> 8 Then
                Return Now.Date
            End If
            Return Convert.ToDateTime(myDate.ToString.Substring(4, 2) + "/" + myDate.ToString.Substring(6, 2) + "/" + myDate.ToString.Substring(0, 4))
        End Function
        'Dinh dang 20081217 <=> 12/17/2008
        'Public Shared Function ConvertIntToDate_Type_VN(ByVal myDate As Integer) As Date
        '    If myDate.ToString.Length <> 8 Then
        '        Return Now.Date
        '    End If
        '    Return Convert.ToDateTime(myDate.ToString.Substring(4, 2) + "/" + myDate.ToString.Substring(6, 2) + "/" + myDate.ToString.Substring(0, 4))
        'End Function
        'Dinh dang 20081217 <=> 17/12/2008
        Public Shared Function ConvertIntToVNDateType(ByVal myDate As Integer) As String
            If myDate.ToString.Length <> 8 Then
                Return Now.Date
            End If
            Return myDate.ToString.Substring(6, 2) + "/" + myDate.ToString.Substring(4, 2) + "/" + myDate.ToString.Substring(0, 4)
        End Function

        'Dinh dang 20080912, 1212 <=> '12/09/2008 12:12'
        Public Shared Function ConvertIntToDateTimeVNDateType(ByVal myDate As Date) As String
            Return ConvertDateToInt(myDate).ToString.Substring(6, 2) + "/" + ConvertDateToInt(myDate).ToString.Substring(4, 2) + "/" + ConvertDateToInt(myDate).ToString.Substring(0, 4) + " " + IIf(myDate.Hour.ToString.Length = 2, myDate.Hour.ToString, "0" + myDate.Hour.ToString) + ":" + IIf(myDate.Minute.ToString.Length = 2, myDate.Minute.ToString, "0" + myDate.Minute.ToString) + ":" + IIf(myDate.Second.ToString.Length = 2, myDate.Second.ToString, "0" + myDate.Second.ToString)
        End Function

        'Dinh dang 20081217 <=> ngay 12 thang 17 nam 2008 - do
        Public Shared Function ConvertIntToDate_VN(ByVal myDate As Integer) As String
            If myDate.ToString.Length <> 8 Then
                Return Now.Date
            End If
            Return "Ngày " + myDate.ToString.Substring(6, 2) + " tháng " + myDate.ToString.Substring(4, 2) + " năm " + myDate.ToString.Substring(0, 4)
        End Function
        'Trừ ngày
        Public Shared Function MinusIntDate(ByVal myDate As Integer, ByVal myMunusIntDate As Integer) As Integer
            Return ConvertDateToInt(ConvertIntToDate(myDate).AddDays(-myMunusIntDate))
        End Function

        'Cộng ngày
        Public Shared Function AddIntDate(ByVal myDate As Integer, ByVal myAddIntDate As Integer) As Integer
            Return ConvertDateToInt(ConvertIntToDate(myDate).AddDays(myAddIntDate))
        End Function

        'Dinh dang 20080912, 1212 <=> '09/12/2008 12:12'
        Public Shared Function ConvertIntToDate(ByVal myDate As Integer, ByVal myTime As Integer) As Date
            Return New Date(myDate.ToString.Substring(0, 4), myDate.ToString.Substring(4, 2), myDate.ToString.Substring(6, 2), ConvertIntToTime(myTime).Substring(0, 2), ConvertIntToTime(myTime).Substring(3, 2), 0)
        End Function
        'Dinh dang 17:12 <=> 1712
        Public Shared Function ConvertTimeToInt(ByVal myTime As String) As Integer
            Return Convert.ToInt32(myTime.Replace(":", ""))
        End Function
        'Dinh dang 12/17/2008 : 15:14 <=> 1514
        Public Shared Function ConvertTimeToInt(ByVal myTime As Date) As Integer
            Return myTime.Hour * 100 + myTime.Minute
        End Function

        'Dinh dang 12/17/2008 : 15:14 <=> 1514 (varchar)
        Public Shared Function Format_Text_Time(ByVal myTime As String) As String
            myTime = myTime.Replace(":", "")
            Select Case myTime.Trim.Length
                Case 1
                    Return "000" & myTime
                Case 2
                    Return "00" & myTime
                Case 3
                    Return "0" & myTime
                Case 4
                    Return myTime
                Case Else
                    Return "0000"
            End Select
        End Function

        'Dinh dang 1003 <=> 10:03
        Public Shared Function ConvertIntToTime(ByVal myTime As Integer) As String
            If myTime.ToString.Length = 3 Then
                Return "0" + myTime.ToString.Substring(0, 1) + ":" + myTime.ToString.Substring(1, 2)
            End If
            If myTime.ToString.Length = 4 Then
                Return myTime.ToString.Substring(0, 2) + ":" + myTime.ToString.Substring(2, 2)
            End If
            Return "00:00"
        End Function
        'Bat dau cua mot ngay
        Public Shared Function dBeginDay(ByVal ddate As Date) As Date
            Return Convert.ToDateTime(ddate.Month & "/" & ddate.Day & "/" & ddate.Year & " 00:00:00 AM")
        End Function
        'Ket thuc cua mot ngay
        Public Shared Function dEndDay(ByVal ddate As Date) As Date
            Return Convert.ToDateTime(ddate.Month & "/" & ddate.Day & "/" & ddate.Year & " 11:59:59 PM")
        End Function
        'Bat dau cua mot thang
        Public Shared Function dBeginMonth(ByVal dDate As Date) As Date
            Dim strtemp As String
            strtemp = dDate.Month & "/01/" & dDate.Year
            Return dBeginDay(Date.Parse(strtemp))
        End Function
        'Ket thuc cua mot thang
        Public Shared Function dEndMonth(ByVal dDate As Date) As Date
            Dim temp As Date
            Dim strtemp As String
            temp = DateAdd(DateInterval.Month, 1, dDate)
            strtemp = temp.Month & "/01/" & temp.Year
            temp = Date.Parse(strtemp)
            Return dEndDay(DateAdd(DateInterval.Day, -1, temp))
        End Function

        'Public Shared Function LastDayOfYear(ByVal dYear As Integer) As Date
        '    Dim time As New DateTime((dYear + 1), 1, 1)
        '    Return time.AddDays(-1)
        'End Function

        'Chuyen kieu ngay Viet sang ngay Anh
        'Noi dung '22/06/2008' => #06/22/2008
        Public Shared Function dVietToEng(ByVal dViet As String) As Date
            Dim Temp As String()
            Temp = dViet.Split("/")
            If Temp.Length <> 3 Then
                Return Now
            End If
            Return Convert.ToDateTime(Temp(1) & "/" & Temp(0) & "/" & Temp(2))
        End Function
        'Chuyen kieu ngay Viet sang kieu so
        'Noi dung '22/06/2008' => 20080622
        Public Shared Function dVietToInt(ByVal dViet As String) As Integer
            Dim Temp As String()
            Temp = dViet.Split("/")
            If Temp.Length <> 3 Then
                Return ConvertDateToInt(Now)
            End If
            Return ConvertDateToInt(Convert.ToDateTime(Temp(1) & "/" & Temp(0) & "/" & Temp(2)))
        End Function
        'La kieu so integer
        Public Shared Function IsInt(ByVal myString As String) As Boolean
            Try
                Int32.Parse(myString)
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function
        'La kieu Date
        Public Shared Function IsDate(ByVal myDate As String) As Boolean
            Try
                Date.Parse(myDate)
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function
        'Kiểm tra ký tự đó có phải là ký tự chữ không
        Public Shared Function IsCharacter(ByVal CharIn As String) As Boolean
            Select Case CharIn.ToUpper
                Case "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", _
                    "A", "S", "D", "F", "G", "H", "J", "K", "L", _
                    "Z", "X", "C", "V", "B", "N", "M"
                    Return True
                Case Else 'Không phải là ký tự chữ
                    Return False
            End Select
        End Function

        'Kiem tra MAE1 theo code 39
        Public Shared Function Check_E1(ByVal SoHieu_E1 As String, ByVal Chuan_UPU_s10 As Boolean) As Boolean
            Dim MaE1_So As Long
            'Kiểm tra định dạng của Số hiệu E1
            'Nếu không phải là 13 ký tự
            If SoHieu_E1.Length <> 13 Then
                Check_E1 = False 'Số Hiệu không có thực
                Exit Function
            End If
            'Nếu không phải là định dạnh của EMS
            If (SoHieu_E1.Substring(0, 1).ToUpper <> "E") And (SoHieu_E1.Substring(0, 1).ToUpper <> "C") Then
                'Cho phép đầu mã là E, C
                Check_E1 = False 'Số Hiệu không có thực
                Exit Function
            End If
            'Nếu không đúng định dạng của các ký tự tiếp theo: thứ 2, 12, 13
            If (IsCharacter(SoHieu_E1.Substring(1, 1)) = False) Or _
                    (IsCharacter(SoHieu_E1.Substring(11, 1)) = False) Or _
                    (IsCharacter(SoHieu_E1.Substring(12, 1)) = False) Then
                Check_E1 = False 'Số Hiệu không có thực
                Exit Function
            End If
            If IsNumeric(Mid(Trim(SoHieu_E1), 3, 9)) Then
                MaE1_So = CLng(Mid(Trim(SoHieu_E1), 3, 9))
                If MaE1_So > 0 Then
                    If SoHieu_E1 <> "" Then
                        If (Chuan_UPU_s10) Then
                            Dim a, b, c, D, E, F, G, H, i, P, PP, S As Integer
                            a = Val(Mid(SoHieu_E1, 3, 1))
                            b = Val(Mid(SoHieu_E1, 4, 1))
                            c = Val(Mid(SoHieu_E1, 5, 1))
                            D = Val(Mid(SoHieu_E1, 6, 1))
                            E = Val(Mid(SoHieu_E1, 7, 1))
                            F = Val(Mid(SoHieu_E1, 8, 1))
                            G = Val(Mid(SoHieu_E1, 9, 1))
                            H = Val(Mid(SoHieu_E1, 10, 1))
                            i = Val(Mid(SoHieu_E1, 11, 1))
                            S = (a * 8) + (b * 6) + (c * 4) + (D * 2) + (E * 3) + (F * 5) + (G * 9) + (H * 7)
                            P = 11 - (S Mod 11)
                            If P = 10 Then
                                PP = 0
                            ElseIf P = 11 Then
                                PP = 5
                            Else
                                PP = P
                            End If
                            If PP <> i Then
                                Check_E1 = False 'Số Hiệu không có thực
                                Exit Function
                            Else
                                Check_E1 = True 'Số Hiệu có thực
                            End If
                        Else
                            Check_E1 = True 'So hieu co thuc
                        End If
                    Else
                        Check_E1 = False 'So hieu khong co thuc
                    End If
                Else
                    Check_E1 = False 'Số Hiệu không có thực
                End If
            Else 'So hieu co thuc
                Check_E1 = False 'Số Hiệu không có thực
            End If
        End Function
        Public Shared Function Check_E1(ByVal SoHieu_E1 As String) As Boolean
            Dim MaE1_So As Long
            'Kiểm tra định dạng của Số hiệu E1
            'Nếu không phải là 13 ký tự
            If SoHieu_E1.Length <> 13 Then
                Check_E1 = False 'Số Hiệu không có thực
                Exit Function
            End If
            'Nếu không phải là định dạnh của EMS
            If (SoHieu_E1.Substring(0, 1).ToUpper <> "E") And (SoHieu_E1.Substring(0, 1).ToUpper <> "C") Then
                'Cho phép đầu mã là E, C
                Check_E1 = False 'Số Hiệu không có thực
                Exit Function
            End If
            'Nếu không đúng định dạng của các ký tự tiếp theo: thứ 2, 12, 13
            If (IsCharacter(SoHieu_E1.Substring(1, 1)) = False) Or _
                    (IsCharacter(SoHieu_E1.Substring(11, 1)) = False) Or _
                    (IsCharacter(SoHieu_E1.Substring(12, 1)) = False) Then
                Check_E1 = False 'Số Hiệu không có thực
                Exit Function
            End If
            If IsNumeric(Mid(Trim(SoHieu_E1), 3, 9)) Then

                MaE1_So = CLng(Mid(Trim(SoHieu_E1), 3, 9))
                If MaE1_So > 0 Then
                    If SoHieu_E1 <> "" Then
                        Dim a, b, c, D, E, F, G, H, i, P, PP, S As Integer
                        a = Val(Mid(SoHieu_E1, 3, 1))
                        b = Val(Mid(SoHieu_E1, 4, 1))
                        c = Val(Mid(SoHieu_E1, 5, 1))
                        D = Val(Mid(SoHieu_E1, 6, 1))
                        E = Val(Mid(SoHieu_E1, 7, 1))
                        F = Val(Mid(SoHieu_E1, 8, 1))
                        G = Val(Mid(SoHieu_E1, 9, 1))
                        H = Val(Mid(SoHieu_E1, 10, 1))
                        i = Val(Mid(SoHieu_E1, 11, 1))
                        S = (a * 8) + (b * 6) + (c * 4) + (D * 2) + (E * 3) + (F * 5) + (G * 9) + (H * 7)
                        P = 11 - (S Mod 11)
                        If P = 10 Then
                            PP = 0
                        ElseIf P = 11 Then
                            PP = 5
                        Else
                            PP = P
                        End If
                        If PP <> i Then
                            Check_E1 = False 'Số Hiệu không có thực
                            Exit Function
                        End If
                    End If
                    Check_E1 = True 'Số Hiệu có thực
                Else
                    Check_E1 = False 'Số Hiệu không có thực
                End If

            Else 'So hieu co thuc
                Check_E1 = False 'Số Hiệu không có thực
            End If
        End Function
        Public Shared Function UrlIsValid(ByVal url As String) As Boolean
            Dim is_valid As Boolean = False
            If url.ToLower().StartsWith("www.") Then url = _
                "http://" & url

            Dim web_response As HttpWebResponse = Nothing
            Try
                Dim web_request As HttpWebRequest = _
                    HttpWebRequest.Create(url)
                web_response = _
                    DirectCast(web_request.GetResponse(), _
                    HttpWebResponse)
                Return True
            Catch ex As Exception
                Return False
            Finally
                If Not (web_response Is Nothing) Then _
                    web_response.Close()
            End Try
        End Function
#Region "-------------------Lay StartDate va EndDate cua nam---------------"
        Public Function CreateStartDate(ByVal NgayHienTai As Integer) As Integer
            Return (NgayHienTai \ 10000) * 10000
        End Function

        Public Function CreateEndDate(ByVal NgayHienTai As Integer) As Integer
            Return (NgayHienTai \ 10000) * 10000 + 9999
        End Function
#End Region
    End Class
End Namespace
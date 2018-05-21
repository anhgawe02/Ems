Imports System.Text

Public Class ConvertNumberToString
    '===============================21/8/2006=======================================

    '...:::o_n_hoang@yahoo.com:::... 

    'compile cái file source này rồi add reference vào project của bạn 

    'sử dụng: 

    'Dim doc As New DocSoTien.DocsoTien() 

    'doc.Tien = "48948911216464" 

    'Label1.Text = doc.Doc 

    '======================================================================

    Private soTien As Double = 0.0

    Private docRa As StringBuilder

    Public ReadOnly Property StringNumber() As String
        Get
            StringNumber = NumberInput()
        End Get
    End Property

    Public Property Number() As Double
        Get
            Number = soTien
        End Get
        Set(ByVal value As Double)
            soTien = value
        End Set
    End Property
    Private Function NumberInput() As String
        docRa = New StringBuilder
        Dim strTien As String
        If soTien.ToString().IndexOf(".") > 0 Then
            strTien = soTien.ToString().Substring(0, soTien.ToString().IndexOf("."))
        Else
            strTien = soTien.ToString()
        End If
        Dim subTien As String = ""
        strTien = ThemSoKhong(strTien)
        process(strTien, subTien, docRa, "", 3)

        process(strTien, subTien, docRa, "ngàn", 6)

        process(strTien, subTien, docRa, "triệu", 9)

        process(strTien, subTien, docRa, "tỷ", 12)

        process(strTien, subTien, docRa, "ngàn", 15)

        process(strTien, subTien, docRa, "triệu", 18)

        process(strTien, subTien, docRa, "tỷ", 21)

        process(strTien, subTien, docRa, "ngàn", 24)

        process(strTien, subTien, docRa, "triệu", 27)

        process(strTien, subTien, docRa, "tỷ", 30)

        process(strTien, subTien, docRa, "ngàn", 33)

        process(strTien, subTien, docRa, "triệu", 36)

        process(strTien, subTien, docRa, "tỷ", 39)
        'Cho chu dau tien thanh dang chu hoa
        If docRa.Length > 0 Then docRa(0) = System.Char.ToUpper(docRa(0))
        Return docRa.ToString()

    End Function

    Private Sub process(ByRef strTien As String, ByRef subTien As String, ByRef docRa As StringBuilder, ByVal dv As String, ByVal i As Integer)
        Try
            strTien.Substring(strTien.Length - i, 3)
            subTien = strTien.Substring(strTien.Length - i, 3)
            If subTien.IndexOf("000") <> 0 Then
                docRa.Insert(0, DocTien(subTien) & " " & dv & " ")
                strTien.Substring(strTien.Length - i - 3, 3)
                Try
                    strTien.Substring(strTien.Length - i - 3, 3)
                    If subTien.IndexOf("00") = 0 Then
                        docRa.Insert(0, "không trăm lẽ ")
                    Else
                        If subTien.IndexOf("0") = 0 Then
                            docRa.Insert(0, "không trăm ")
                        End If
                    End If
                Catch ex As Exception
                End Try
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Function ThemSoKhong(ByVal tien As String) As String
        While True
            If tien.Length Mod 3 <> 0 Then
                tien = "0" & tien
            Else
                Return tien
            End If
        End While
    End Function
    Private Function DocTien(ByVal tien As String)
        If tien.IndexOf("000") = 0 Then
            Return ""
        Else
            If tien.IndexOf("00") = 0 Then
                Return DocDonVi(tien.Substring(2, 1))
            Else
                If tien.IndexOf("0") = 0 Then
                    Return DocChuc(tien.Substring(1, 2))
                Else
                    Return DocTram(tien)
                End If
            End If
        End If
    End Function
    Private Function DocDonVi(ByVal tien As String) As String
        Select Case tien
            Case "1" : Return "một"
            Case "2" : Return "hai"
            Case "3" : Return "ba"
            Case "4" : Return "bốn"
            Case "5" : Return "năm"
            Case "6" : Return "sáu"
            Case "7" : Return "bảy"
            Case "8" : Return "tám"
            Case "9" : Return "chín"
        End Select
    End Function
    Private Function DocChuc(ByVal tien As String) As String
        Dim t1 As String = tien.Substring(0, 1)
        Dim t2 As String = tien.Substring(1, 1)
        Dim reValue As String = ""
        If tien = "00" Then
            Return ""
        Else
            If tien.IndexOf(0) = 0 Then
                Debug.WriteLine("t2 la:" & t2)
                reValue = "lẻ " & DocDonVi(t2)
            Else
                If tien = "10" Then
                    Return "mười"
                End If
                If t1 = "1" Then
                    reValue = "mười"
                Else
                    reValue = DocDonVi(t1)
                End If
                If t1 <> 1 And t2 = 1 Then
                    reValue = reValue & " mươi mốt"
                Else
                    If t2 = "5" And t1 <> "1" Then
                        reValue = reValue & " mươi lăm"
                    Else
                        If t2 = "5" And t1 = "1" Then
                            reValue = reValue & " lăm"
                        Else
                            If t1 = "1" And t2 <> "5" Then
                                reValue = reValue & " " & DocDonVi(t2)
                            Else
                                reValue = reValue & " mươi " & DocDonVi(t2)
                            End If
                        End If
                    End If
                End If
            End If
        End If
        Return reValue
    End Function
    Private Function DocTram(ByVal tien As String) As String
        Dim t1 As String = tien.Substring(0, 1)
        Dim t2 As String = tien.Substring(1, 2)
        Dim reValue As String = ""
        reValue &= DocDonVi(t1)
        reValue &= " trăm "
        reValue &= DocChuc(t2)
        Return reValue
    End Function
End Class

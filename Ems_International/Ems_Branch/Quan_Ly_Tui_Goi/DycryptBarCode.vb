Imports System.Math
Imports Ems_International_Logic.EMS

Namespace DycryptBarCode
    Public Class bc37code
        Private _MaBuuCucGui As String
        Private _MaBuuCucNhan As String
        Private _NgayLapBC37 As String
        Private _SoChuyenThu As String
        Public Sub New()
        End Sub
        Public Sub New(ByVal mycode As String)
            If check(mycode) = True Then
                _MaBuuCucGui = mycode.Substring(0, 6)
                _MaBuuCucNhan = mycode.Substring(6, 6)
                Dim nam = DateTime.Now.Year.ToString().Substring(0, 3) & mycode.Substring(12, 1)
                Dim thang = mycode.Substring(13, 2)
                Dim ngay = mycode.Substring(15, 2)
                _NgayLapBC37 = thang & "/" & ngay & "/" & nam
                _SoChuyenThu = mycode.Substring(17, 1)
            Else
                _MaBuuCucGui = ""
                _MaBuuCucNhan = ""
                _NgayLapBC37 = ""
                _SoChuyenThu = ""
            End If

        End Sub
        Public Sub New(ByVal mabcgui As String, ByVal mabcnhan As String, ByVal NgayLapBC37 As String, ByVal SoChuyenThu As String)

            _MaBuuCucGui = mabcgui
            _MaBuuCucNhan = mabcnhan
            _NgayLapBC37 = NgayLapBC37
            _SoChuyenThu = SoChuyenThu
        End Sub
        Public Function check(ByVal ma_bc37 As String) As Boolean
            If (ma_bc37.Length <> 18) Then
                Return False
            End If
            If Not IsNumeric(ma_bc37.Substring(0, 6)) Then
                Return False
            End If
            If Not IsNumeric(ma_bc37.Substring(6, 6)) Then
                Return False
            End If
            If Not IsNumeric(ma_bc37.Substring(12, 1)) Then
                Return False
            End If
            If Not IsNumeric(ma_bc37.Substring(17, 1)) Then
                Return False
            End If
            If Not IsNumeric(ma_bc37.Substring(13, 2)) Then
                Return False
            Else
                Dim thang = Integer.Parse(ma_bc37.Substring(13, 2)) 'lớn hơn 12
                If thang > 12 Or thang < 0 Then
                    Return False
                Else
                    If Not IsNumeric(ma_bc37.Substring(15, 2)) Then
                        Return False
                    Else
                        Dim ngay = Integer.Parse(ma_bc37.Substring(15, 2))
                        Select Case thang
                            Case 1
                                If ngay < 1 Or ngay > 31 Then
                                    Return False
                                End If
                            Case 2
                                If ngay < 1 Or ngay > 29 Then
                                    Return False
                                End If
                            Case 3
                                If ngay < 1 Or ngay > 31 Then
                                    Return False
                                End If
                            Case 4
                                If ngay < 1 Or ngay > 30 Then
                                    Return False
                                End If
                            Case 5
                                If ngay < 1 Or ngay > 31 Then
                                    Return False
                                End If
                            Case 6
                                If ngay < 1 Or ngay > 30 Then
                                    Return False
                                End If
                            Case 7
                                If ngay < 1 Or ngay > 31 Then
                                    Return False
                                End If
                            Case 8
                                If ngay < 1 Or ngay > 31 Then
                                    Return False
                                End If
                            Case 9
                                If ngay < 1 Or ngay > 30 Then
                                    Return False
                                End If
                            Case 10
                                If ngay < 1 Or ngay > 31 Then
                                    Return False
                                End If
                            Case 11
                                If ngay < 1 Or ngay > 30 Then
                                    Return False
                                End If
                            Case 12
                                If ngay < 1 Or ngay > 31 Then
                                    Return False
                                End If
                        End Select
                    End If
                End If
            End If
            Return True
        End Function
        Public Property MaBuuCucGui() As String
            Get
                Return _MaBuuCucGui
            End Get
            Set(ByVal Value As String)
                _MaBuuCucGui = Value
            End Set
        End Property
        Public Property MaBuuCucNhan() As String
            Get
                Return _MaBuuCucNhan
            End Get
            Set(ByVal Value As String)
                _MaBuuCucNhan = Value
            End Set
        End Property
        Public Property NgayLapBC37() As String
            Get
                Return _NgayLapBC37
            End Get
            Set(ByVal Value As String)
                _NgayLapBC37 = Value
            End Set
        End Property
        Public Property SoChuyenThu() As String
            Get
                Return _SoChuyenThu
            End Get
            Set(ByVal Value As String)
                _SoChuyenThu = Value
            End Set
        End Property
        Public Function GeneralBC37Code() As String
            Dim strBC37Code = ""
            strBC37Code &= _MaBuuCucGui & _MaBuuCucNhan & _NgayLapBC37.Substring(9, 1) & _NgayLapBC37.Substring(0, 2) & _NgayLapBC37.Substring(3, 2) & _SoChuyenThu
            Return strBC37Code
        End Function
    End Class
    Public Class e4code
        Public Sub New()
        End Sub
        Public Sub New(ByVal mycode As String)
            If check(mycode) = True Then
                _MaBuuCucGui = mycode.Substring(0, 6)
                _MaBuuCucNhan = mycode.Substring(6, 6)
                _LoaiChuyenThu = mycode.Substring(12, 1)
                _MaDichVu = mycode.Substring(13, 2)
                _NamChuyenThu = mycode.Substring(15, 1)
                _SoHieuChuyenThu = mycode.Substring(16, 4)
                _TuiSo = mycode.Substring(20, 3)
                If (mycode.Substring(23, 1) = "0") Then
                    _TuiF = False
                Else : _TuiF = True
                End If
                If (mycode.Substring(24, 1) = "0") Then
                    _LoaiTui = False
                Else : _LoaiTui = True
                End If
                _TrongLuong = Decimal.Parse(mycode.Substring(25, 3) & "." & mycode.Substring(28, 1))
            Else
                _MaBuuCucGui = ""
                _MaBuuCucNhan = ""
                _LoaiChuyenThu = ""
                _MaDichVu = ""
                _NamChuyenThu = ""
                _SoHieuChuyenThu = ""
                _TuiSo = ""
                _TrongLuong = 0
            End If

        End Sub
        Public Sub New(ByVal mabcgui As String, ByVal mabcnhan As String, ByVal LoaiChuyenThu As String, ByVal MaDichVu As String, ByVal NamChuyenThu As String, ByVal SoHieuChuyenThu As String, ByVal TuiSo As String, ByVal TuiF As Boolean, ByVal LoaiTui As Boolean, ByVal TrongLuong As Integer)
            _MaBuuCucGui = mabcgui
            _MaBuuCucNhan = mabcnhan
            _LoaiChuyenThu = LoaiChuyenThu
            _MaDichVu = MaDichVu
            _NamChuyenThu = NamChuyenThu
            _SoHieuChuyenThu = SoHieuChuyenThu
            _TuiSo = TuiSo
            _TuiF = TuiF
            _LoaiTui = LoaiTui
            _TrongLuong = TrongLuong
        End Sub
        Public Function check(ByVal ma_e4 As String) As Boolean
            If (ma_e4.Length <> 29) Then
                Return False
            End If
            If Not IsNumeric(ma_e4.Substring(0, 6)) Then
                Return False
            End If
            If Not IsNumeric(ma_e4.Substring(6, 6)) Then
                Return False
            End If
            If Not IsNumeric(ma_e4.Substring(15, 1)) Then
                Return False
            End If
            If Not IsNumeric(ma_e4.Substring(16, 4)) Then
                Return False
            End If
            If Not IsNumeric(ma_e4.Substring(20, 3)) Then
                Return False
            End If
            If Not IsNumeric(ma_e4.Substring(23, 1)) Then
                Return False
            End If
            If Not IsNumeric(ma_e4.Substring(24, 1)) Then
                Return False
            End If
            If Not IsNumeric(ma_e4.Substring(25, 4)) Then
                Return False
            End If
            Return True
        End Function
        Private _MaBuuCucGui As String
        Private _MaBuuCucNhan As String
        Private _LoaiChuyenThu As String
        Private _MaDichVu As String
        Private _NamChuyenThu As String
        Private _SoHieuChuyenThu As String
        Private _TuiSo As String
        Private _TuiF As Boolean
        Private _LoaiTui As Boolean
        Private _TrongLuong As Integer
        Public Property MaBuuCucGui() As String
            Get
                Return _MaBuuCucGui
            End Get
            Set(ByVal Value As String)
                _MaBuuCucGui = Value
            End Set
        End Property
        Public Property MaBuuCucNhan() As String
            Get
                Return _MaBuuCucNhan
            End Get
            Set(ByVal Value As String)
                _MaBuuCucNhan = Value
            End Set
        End Property
        Public Property LoaiChuyenThu() As String
            Get
                Return _LoaiChuyenThu
            End Get
            Set(ByVal Value As String)
                _LoaiChuyenThu = Value
            End Set
        End Property
        Public Property MaDichVu() As String
            Get
                Return _MaDichVu
            End Get
            Set(ByVal Value As String)
                _MaDichVu = Value
            End Set
        End Property
        Public Property NamChuyenThu() As String
            Get
                Return _NamChuyenThu
            End Get
            Set(ByVal Value As String)
                _NamChuyenThu = Value
            End Set
        End Property
        Public Property SoHieuChuyenThu() As String
            Get
                Return _SoHieuChuyenThu
            End Get
            Set(ByVal Value As String)
                _SoHieuChuyenThu = Value
            End Set
        End Property
        Public Property TuiSo() As String
            Get
                Return _TuiSo
            End Get
            Set(ByVal Value As String)
                _TuiSo = Value
            End Set
        End Property
        Public Property TuiF() As Boolean
            Get
                Return _TuiF
            End Get
            Set(ByVal Value As Boolean)
                _TuiF = Value
            End Set
        End Property
        Public Property LoaiTui() As Boolean
            Get
                Return _LoaiTui
            End Get
            Set(ByVal Value As Boolean)
                _LoaiTui = Value
            End Set
        End Property
        Public Property TrongLuong() As Integer
            Get
                Return _TrongLuong
            End Get
            Set(ByVal Value As Integer)
                _TrongLuong = Value
            End Set
        End Property
        Function GeneralE4Code() As String
            Dim strE4Code = ""
            strE4Code &= _MaBuuCucGui & _MaBuuCucNhan & _LoaiChuyenThu & _MaDichVu & _NamChuyenThu & _SoHieuChuyenThu & _TuiSo
            If (_TuiF) Then
                strE4Code &= "1"
            Else
                strE4Code &= "0"
            End If
            If (_LoaiTui) Then
                strE4Code &= "1"
            Else
                strE4Code &= "0"
            End If

            Dim mTrongLuong As Integer
            mTrongLuong = Round(_TrongLuong / 100, 0)
            Dim strKG As String = mTrongLuong.ToString("0000")

            strE4Code &= strKG

            Return strE4Code
        End Function

        Function GeneralE4Code_With_Space() As String
            Dim strE4Code = ""
            strE4Code &= _MaBuuCucGui & " " & _MaBuuCucNhan & " " & _LoaiChuyenThu & " " & _MaDichVu & " " & _NamChuyenThu & " " & _SoHieuChuyenThu & " " & _TuiSo & " "
            If (_TuiF) Then
                strE4Code &= "1"
            Else
                strE4Code &= "0"
            End If
            If (_LoaiTui) Then
                strE4Code &= "1"
            Else
                strE4Code &= "0"
            End If

            Dim mTrongLuong As Integer
            mTrongLuong = Round(_TrongLuong / 100, 0)
            Dim strKG As String = mTrongLuong.ToString("0000")

            strE4Code &= " " & strKG

            Return strE4Code
        End Function

    End Class
End Namespace



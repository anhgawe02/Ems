Imports System.Drawing.Drawing2D
Public Class cHands
    Private Angle As Integer = 0
    Public Path As New GraphicsPath
    Public filled As Boolean = False

    ' We have to set a new angle so subtract it from the old one and thats 
    ' how far we have to move
    '
    Public Sub setAngle(ByVal newAngle As Integer, ByVal imgCenter As PointF)
        Dim Rotate As Integer = newAngle - Angle
        Dim trans As New Drawing2D.Matrix
        trans.RotateAt(Rotate, imgCenter)
        Path.Transform(trans)
        Me.Angle = newAngle
    End Sub

    ' V? kim phút, gi?, giây
    '
    Public Sub draw(ByVal imgDraw As Graphics)
        If filled Then
            imgDraw.FillPath(Brushes.WhiteSmoke, Path)
            imgDraw.DrawPath(Pens.Black, Path)
        Else
            imgDraw.DrawPath(New Pen(Color.Black, 1), Path)
        End If
        'V? nút tròn ? gi?a
        imgDraw.FillEllipse(Brushes.DarkSlateBlue, New Rectangle(32, 32, 7, 7))
    End Sub
End Class

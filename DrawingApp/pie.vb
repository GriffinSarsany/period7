Public Class pie
    Public Property xspeed As Integer
    Public Property yspeed As Integer
    Public Property Pen As Pen
    Public Property w As Integer
    Public Property h As Integer
    Public Property xoffset As Integer
    Public Property yoffset As Integer

    Dim m_image As Image
    Dim m_a As Point
    Dim m_b As Point

    Public Sub New(i As Image, a As Point, b As Point)
        Pen = Pens.Red
        m_image = i
        m_a = a
        m_b = b
    End Sub
    Public Sub Draw()
        xoffset += xspeed
        yoffset += yspeed
        Using g As Graphics = Graphics.FromImage(m_image)
            g.DrawLine(Pen, m_a.X + xoffset, m_a.Y + yoffset, m_b.X + xoffset, m_b.Y + yoffset)
            ' g.DrawRectangle(Pen, m_a.X, m_a.Y, w, h)
        End Using

    End Sub
End Class



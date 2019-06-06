Public Class BufferedPanel
    Inherits Panel
    Sub New()
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
    End Sub
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        e.Graphics.CompositingMode = Drawing2D.CompositingMode.SourceCopy
        MyBase.OnPaint(e)
    End Sub
End Class

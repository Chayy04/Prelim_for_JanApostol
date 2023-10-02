Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
Public Class RoundBuuton
    Inherits Button
    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        Dim path As GraphicsPath = New GraphicsPath()
        path.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height)
        Me.Region = New Region(path)
        MyBase.OnPaint(pevent)
    End Sub

End Class

Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class CirclePictureBox
    Inherits PictureBox

    ' Property to control the border radius
    Private _borderRadius As Integer = 20

    Public Property BorderRadius As Integer
        Get
            Return _borderRadius
        End Get
        Set(value As Integer)
            _borderRadius = value
            Me.Invalidate() ' Redraw the picture box with updated border radius
        End Set
    End Property

    ' Override the OnResize method to update the rounded region on resize
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        ' Adjust the region to a rounded shape based on the current size and border radius
        UpdateRoundedRegion()
    End Sub

    ' Override the OnPaint method to ensure smooth edges
    Protected Overrides Sub OnPaint(pe As PaintEventArgs)
        MyBase.OnPaint(pe)
        ' Apply smoothing for smooth edges
        pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias
    End Sub

    ' Method to update the region to a rounded rectangle
    Private Sub UpdateRoundedRegion()
        If Me.Width > 0 AndAlso Me.Height > 0 Then
            ' Create a rounded rectangle region using the BorderRadius property
            Dim path As New GraphicsPath()
            path.AddArc(0, 0, _borderRadius * 2, _borderRadius * 2, 180, 90) ' Top-left corner
            path.AddArc(Me.Width - _borderRadius * 2, 0, _borderRadius * 2, _borderRadius * 2, 270, 90) ' Top-right corner
            path.AddArc(Me.Width - _borderRadius * 2, Me.Height - _borderRadius * 2, _borderRadius * 2, _borderRadius * 2, 0, 90) ' Bottom-right corner
            path.AddArc(0, Me.Height - _borderRadius * 2, _borderRadius * 2, _borderRadius * 2, 90, 90) ' Bottom-left corner
            path.CloseFigure()

            ' Set the region to the rounded rectangle
            Me.Region = New Region(path)
        End If
    End Sub
End Class

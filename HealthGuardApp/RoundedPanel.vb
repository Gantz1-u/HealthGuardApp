Imports System
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class RoundedPanel
    Inherits Panel

    <DllImport("gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(ByVal nLeftRect As Integer, ByVal nTopRect As Integer,
                                               ByVal nRightRect As Integer, ByVal nBottomRect As Integer,
                                               ByVal nWidthEllipse As Integer, ByVal nHeightEllipse As Integer) As IntPtr
    End Function

    <DllImport("gdi32.dll", EntryPoint:="DeleteObject")>
    Private Shared Function DeleteObject(hObject As IntPtr) As Boolean
    End Function

    Private _cornerRadius As Integer = 20

    ' Property to get/set the corner radius
    Public Property CornerRadius As Integer
        Get
            Return _cornerRadius
        End Get
        Set(value As Integer)
            _cornerRadius = value
            Me.Invalidate() ' Redraw the panel to apply changes 
        End Set
    End Property

    ' Override the OnPaint method to apply the rounded corners
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        ' Create a rounded region
        Dim regionHandle As IntPtr = CreateRoundRectRgn(0, 0, Me.Width, Me.Height, _cornerRadius, _cornerRadius)

        ' Set the region for the panel to make the corners rounded
        If regionHandle <> IntPtr.Zero Then
            Me.Region = Region.FromHrgn(regionHandle)

            ' Cleanup the region handle after use
            DeleteObject(regionHandle)
        End If
    End Sub

    ' Override the OnResize method to ensure the region is updated on resize
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Me.Invalidate() ' Force the panel to be redrawn when resized
    End Sub
End Class

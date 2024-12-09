﻿Imports System.Drawing.Drawing2D

Public Class SymptomsPage
    Inherits Form

    ' Define the radius for the rounded corners
    Private _cornerRadius As Integer = 50

    Public Sub New()
        InitializeComponent()
        ' Optionally, you can set the form's border style to None to get rid of the default border
        Me.FormBorderStyle = FormBorderStyle.None
        ' Call this method to apply rounded corners to the form
        ApplyRoundedCorners()
    End Sub

    ' This method applies the rounded corners to the form
    Private Sub ApplyRoundedCorners()
        Dim path As New GraphicsPath()
        ' Create a rounded rectangle path
        path.AddArc(0, 0, _cornerRadius, _cornerRadius, 180, 90) ' Top-left corner
        path.AddArc(Me.Width - _cornerRadius, 0, _cornerRadius, _cornerRadius, 270, 90) ' Top-right corner
        path.AddArc(Me.Width - _cornerRadius, Me.Height - _cornerRadius, _cornerRadius, _cornerRadius, 0, 90) ' Bottom-right corner
        path.AddArc(0, Me.Height - _cornerRadius, _cornerRadius, _cornerRadius, 90, 90) ' Bottom-left corner
        path.CloseFigure() ' Close the figure to form the rounded rectangle

        ' Set the form's region to the rounded rectangle path
        Me.Region = New Region(path)
    End Sub

    ' Optionally, handle the resizing of the form
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        ApplyRoundedCorners() ' Reapply the rounded corners when resizing
    End Sub

    Private _selectedDoctor As String

    ' Public property to expose the selected doctor
    Public Property SelectedDoctor As String
        Get
            Return _selectedDoctor
        End Get
        Set(value As String)
            _selectedDoctor = value
        End Set
    End Property

    ' Button Click Event Handlers for Each Department Button
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles RoundedButton5.Click, RoundedButton1.Click, RoundedButton2.Click, RoundedButton4.Click, RoundedButton3.Click
        ' Determine which button was clicked
        Dim clickedButton As Button = CType(sender, Button)

        ' Set the selected doctor based on the button clicked
        Select Case clickedButton.Name
            Case "RoundedButton5"
                SelectedDoctor = "Dr. Robert Anderson (Pediatrician)"
                SpecialistPage.Show()
            Case "RoundedButton1"
                SelectedDoctor = "Dr. Julie Grande (Dermatologist)"
                DermatologyPage.Show()
            Case "RoundedButton2"
                SelectedDoctor = "Dr. Joseph Shaffer (Physician)"
                PhysicalTherapy.Show()
            Case "RoundedButton4"
                SelectedDoctor = "Dr. Tanya Lao (Psychiatrist)"
                Psychiatry.Show()
            Case "RoundedButton3"
                SelectedDoctor = "Dr. Noel Hauge (Orthopedist)"
                Orthopedics.Show()
            Case Else
                MessageBox.Show("Unrecognized button clicked.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub ' Stop the code here if unrecognized
        End Select

        Me.Hide() ' Hide the current form (SymptomsPage)
    End Sub
End Class

Public Class DoctorPrescriptionPatients
    ' Private field to store the selected patient ID
    Private _selectedPatient As Integer

    ' Public property to expose the selected patient ID
    Public Property SelectedPatient As Integer
        Get
            Return _selectedPatient
        End Get
        Private Set(value As Integer)
            _selectedPatient = value
        End Set
    End Property

    ' Back button to navigate to the menu page
    Private Sub BackButton(sender As Object, e As EventArgs) Handles PictureBox4.Click
        DoctorMenuPage.Show()
        Me.Hide()
    End Sub

    ' Event handlers for selecting a patient
    Private Sub SelectPatient1(sender As Object, e As EventArgs) Handles CirclePictureBox1.Click
        SelectedPatient = 1
        OpenPrescriptionForm()
    End Sub

    Private Sub SelectPatient2(sender As Object, e As EventArgs) Handles CirclePictureBox2.Click
        SelectedPatient = 2
        OpenPrescriptionForm()
    End Sub

    Private Sub SelectPatient3(sender As Object, e As EventArgs) Handles CirclePictureBox3.Click
        SelectedPatient = 3
        OpenPrescriptionForm()
    End Sub

    Private Sub SelectPatient4(sender As Object, e As EventArgs) Handles CirclePictureBox4.Click
        SelectedPatient = 4
        OpenPrescriptionForm()
    End Sub

    Private Sub SelectPatient5(sender As Object, e As EventArgs) Handles CirclePictureBox5.Click
        SelectedPatient = 5
        OpenPrescriptionForm()
    End Sub

    ' Method to open the DoctorPrescription form and pass the SelectedPatient
    Private Sub OpenPrescriptionForm()
        Dim prescriptionForm As New DoctorPrescription()
        prescriptionForm.SelectedPatientID = SelectedPatient ' Pass the selected patient ID
        prescriptionForm.Show()
        Me.Hide()
    End Sub
End Class

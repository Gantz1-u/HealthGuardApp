Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class DoctorPatientData
    Inherits Form

    ' Define the radius for the rounded corners
    Private _cornerRadius As Integer = 50
    Private _patientID As String

    ' Constructor that accepts patientID
    Public Sub New(patientID As String)
        InitializeComponent()
        _patientID = patientID ' Store the selected patient ID
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

    ' Load patient data when the form loads
    Private Sub DoctorPatientData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not String.IsNullOrEmpty(_patientID) Then
            ' Load the patient data based on the selected patient ID
            LoadDoctorPatientData(_patientID)
        Else
            MessageBox.Show("No patient selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Method to handle loading doctor patient data
    Private Sub LoadDoctorPatientData(patientID As String)
        ' Initialize DB connection using your custom DBConnection class
        Dim conn As New DBConnection()

        ' Open the database connection
        conn.Open()

        ' SQL query to retrieve patient data based on the PatientID
        Dim query As String = "SELECT PatientID, FirstName, MiddleName, LastName, Sex, DateOfBirth, Age, BloodType, Phone, ParentGuardian, Email, Address, PrimaryDiagnoses FROM Patients WHERE PatientID = @PatientID"

        ' Create the command using the connection
        Dim cmd As New MySqlCommand(query, conn.Open()) ' Use the connection directly

        ' Use parameterized query to prevent SQL injection
        cmd.Parameters.AddWithValue("@PatientID", patientID)

        Try
            ' Execute the query and read the data
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                reader.Read() ' Read the first row

                ' Assign the data to the labels (example of how data can be shown on the form)
                lbl_FirstName.Text = reader("FirstName").ToString()
                lbl_MiddleName.Text = reader("MiddleName").ToString()
                lbl_LastName.Text = reader("LastName").ToString()
                lbl_Sex.Text = reader("Sex").ToString()
                lbl_BirthDate.Text = Convert.ToDateTime(reader("DateOfBirth")).ToShortDateString()
                lbl_Age.Text = reader("Age").ToString()
                lbl_BloodType.Text = reader("BloodType").ToString()
                lbl_ContactNumber.Text = reader("Phone").ToString()
                lbl_ParentGuardian.Text = reader("ParentGuardian").ToString()
                lbl_Email.Text = reader("Email").ToString()
                lbl_Address.Text = reader("Address").ToString()
                lbl_PrimaryDiagnoses.Text = reader("PrimaryDiagnoses").ToString()
            Else
                MessageBox.Show("Patient not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            reader.Close()
        Catch ex As MySqlException
            MessageBox.Show("Error fetching data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Always close the connection when done
            conn.Close()
        End Try
    End Sub

    ' Back button functionality
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        DoctorPatientList.Show()
        Me.Hide() ' Navigate back to the DoctorPatientList form
    End Sub

    ' Home button functionality
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        DoctorMenuPage.Show()
        Me.Hide()
    End Sub
End Class

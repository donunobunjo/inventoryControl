Public Class ViewClassifications

    Private Sub ViewClassifications_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IGontrol.Classification' table. You can move, or remove it, as needed.
        Me.ClassificationTableAdapter.Fill(Me.IGontrol.Classification)
        Me.CenterToScreen()
        Me.Top = 50
    End Sub
End Class
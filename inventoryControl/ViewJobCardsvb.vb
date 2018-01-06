Public Class ViewJobCardsvb

    Private Sub ViewJobCardsvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IGontrol.JobCard' table. You can move, or remove it, as needed.
        Me.JobCardTableAdapter.Fill(Me.IGontrol.JobCard)
        Me.CenterToScreen()
        Me.Top = 40
    End Sub
End Class
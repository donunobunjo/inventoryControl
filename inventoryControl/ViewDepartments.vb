Public Class ViewDepartments

    Private Sub ViewDepartments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IGontrol.Department' table. You can move, or remove it, as needed.
        Me.DepartmentTableAdapter.Fill(Me.IGontrol.Department)
        Me.CenterToScreen()
        Me.Top = 50
    End Sub
End Class
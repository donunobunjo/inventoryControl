Public Class NewDepartment

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TextBox1.Text = "") Then
            MessageBox.Show("You need to enter a department")
            TextBox1.Focus()
            Exit Sub
        End If
        Me.DepartmentTableAdapter.InsertQuery(TextBox1.Text)
        TextBox1.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub NewClassification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IGontrol.Department' table. You can move, or remove it, as needed.
        Me.DepartmentTableAdapter.Fill(Me.IGontrol.Department)
        'TODO: This line of code loads data into the 'IGontrol.Classification' table. You can move, or remove it, as needed.
        ''  Me.ClassificationTableAdapter.Fill(Me.IGontrol.Classification)
        Me.CenterToScreen()
        Me.Top = 50
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "") Then
            MessageBox.Show("You need to enter a department")
            TextBox1.Focus()
            Exit Sub
        End If
        Me.DepartmentTableAdapter.InsertQuery(TextBox1.Text)
        Me.Close()
    End Sub
End Class
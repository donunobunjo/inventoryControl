Public Class NewJobCardvb

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub NewJobCardvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IGontrol.JobCard' table. You can move, or remove it, as needed.
        ' Me.JobCardTableAdapter.Fill(Me.IGontrol.JobCard)
        Me.CenterToScreen()
        Me.Top = 40
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("You need to enter a job card number")
            TextBox1.Focus()
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            MessageBox.Show("You need to enter a brief description of the job card")
            TextBox2.Focus()
            Exit Sub
        End If

        Me.JobCardTableAdapter.InsertQuery(TextBox1.Text, TextBox2.Text)
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("You need to enter a job card number")
            TextBox1.Focus()
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            MessageBox.Show("You need to enter a brief description of the job card")
            TextBox2.Focus()
            Exit Sub
        End If

        Me.JobCardTableAdapter.InsertQuery(TextBox1.Text, TextBox2.Text)
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Focus()
    End Sub
End Class
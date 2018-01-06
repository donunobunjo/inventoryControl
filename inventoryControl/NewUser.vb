Public Class NewUser

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        TextBox1.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim insertuser As New iGontrolTableAdapters.UserTableAdapter
        Dim assignfn As New AssignFuctionsToUser
        Dim dt As DataTable
        If TextBox1.Text = "" Then
            MessageBox.Show("User name required")
            TextBox1.Focus()
            Exit Sub
        End If
       
        dt = insertuser.GetDataBy1(TextBox1.Text)
        If dt.Rows.Count = 0 Then
            ' insertuser.InsertQuery(txtUser.Text, "", "", dtpDate.Value, True, dlocation, dstore)
            ' insertuser.InsertQuery(txtUser.Text, "", "", dtpDate.Value, True, ComboBox1.Text, ComboBox2.Text)
            insertuser.InsertQuery(TextBox1.Text, "", True)
        Else
            MessageBox.Show("This user exists in the database")
            TextBox1.Focus()
            Exit Sub
        End If
        ' Me.Close()
        assignfn.user = TextBox1.Text
        assignfn.ShowDialog()
        Me.Close()
    End Sub

    Private Sub NewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.Top = 30
    End Sub
End Class
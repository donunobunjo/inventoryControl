Public Class NewAcctCode

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub NewJobCardvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IGontrol.AcctCodes' table. You can move, or remove it, as needed.
        Me.AcctCodesTableAdapter.Fill(Me.IGontrol.AcctCodes)
        'TODO: This line of code loads data into the 'IGontrol.JobCard' table. You can move, or remove it, as needed.
        ' Me.JobCardTableAdapter.Fill(Me.IGontrol.JobCard)
        Me.CenterToScreen()
        Me.Top = 40
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mydt As DataTable
        If TextBox1.Text = "" Then
            MessageBox.Show("You need to enter an account code")
            TextBox1.Focus()
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            MessageBox.Show("You need to enter an account code description")
            TextBox2.Focus()
            Exit Sub
        End If
        mydt = Me.AcctCodesTableAdapter.GetDataByCheckDups(TextBox1.Text)
        If mydt.Rows.Count = 0 Then
            'Me.JobCardTableAdapter.InsertQuery(TextBox1.Text, TextBox2.Text)
            Me.AcctCodesTableAdapter.InsertQuery(TextBox1.Text, TextBox2.Text)
            Me.Close()
        Else
            MessageBox.Show("You have this account code in the database already, you can please change it")
            TextBox1.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim mydt As DataTable
        If TextBox1.Text = "" Then
            MessageBox.Show("You need to enter an account code")
            TextBox1.Focus()
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            MessageBox.Show("You need to enter an account code description")
            TextBox2.Focus()
            Exit Sub
        End If
        mydt = Me.AcctCodesTableAdapter.GetDataByCheckDups(TextBox1.Text)
        If mydt.Rows.Count = 0 Then
            'Me.JobCardTableAdapter.InsertQuery(TextBox1.Text, TextBox2.Text)
            Me.AcctCodesTableAdapter.InsertQuery(TextBox1.Text, TextBox2.Text)
            ' Me.Close()
        Else
            MessageBox.Show("You have this account code in the database already, you can please change it")
            TextBox1.Focus()
            Exit Sub
        End If
        '  Me.JobCardTableAdapter.InsertQuery(TextBox1.Text, TextBox2.Text)
        Me.AcctCodesTableAdapter.InsertQuery(TextBox1.Text, TextBox2.Text)
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Focus()
    End Sub
End Class
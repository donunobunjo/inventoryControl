Public Class login
    Dim trials As Int32
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dt As DataTable
        ' Dim validate As New iGontrolTableAdapters.UsersTableAdapter
        Dim validate As New iGontrolTableAdapters.UserTableAdapter
       
        If TextBox1.Text = "" Then
            MessageBox.Show("Username is required")
            Exit Sub
        End If
       
        dt = validate.GetDataByValidate(TextBox1.Text, TextBox2.Text)
        If dt.Rows.Count = 0 Then
            MessageBox.Show("Incorrect password")
            trials = trials + 1
            If trials = 3 Then
                ' MessageBox.Show("Shutting down ...")
                Me.Close()
            End If
            TextBox1.Focus()
            Exit Sub
        Else
            If TextBox2.Text = "" Then
                ' MessageBox.Show(" new user")
                ''
                'forchanging
                '''
                Dim setpasswd As New CahngeNewUserPassword
                setpasswd.user = Trim(TextBox1.Text)
                ' setpasswd.dlocation = Trim(dt.Rows(0).Item("Location").ToString)
                'setpasswd.dstore = Trim(dt.Rows(0).Item("Store").ToString)
                setpasswd.Show()
                Me.Close()

            Else
                Dim mainform As New mdi

                mainform.user = Trim(TextBox1.Text)
                ' mainform.role = dt.Rows(0).Item(3).ToString
                '  mainform.role = Trim(dt.Rows(0).Item(3).ToString)
                mainform.passwd = Trim(dt.Rows(0).Item(2).ToString)
                ' mainform.dlocation = Trim(dt.Rows(0).Item("Location").ToString)
                '  mainform.dstore = Trim(dt.Rows(0).Item("Store").ToString)
                mainform.Show()
            End If
        End If
        'userdatails.usernamess = TextBox1.Text
        Me.Close()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class
Public Class NewSupplier

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub NewSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IGontrol.Supplier' table. You can move, or remove it, as needed.
        ' Me.SupplierTableAdapter.Fill(Me.IGontrol.Supplier)
        Me.CenterToScreen()
        Me.Top = 40
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Then
            MessageBox.Show("You will need to enter supplier's name")
            TextBox2.Focus()
            Exit Sub
        End If
        If ComboBox1.Text = "" Then
            MessageBox.Show("You will need to select a supplier type")
            ComboBox1.Focus()
            Exit Sub
        End If
        Me.SupplierTableAdapter.InsertQuery(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, ComboBox1.Text)
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text = "" Then
            MessageBox.Show("You will need to enter supplier's name")
            TextBox2.Focus()
            Exit Sub
        End If
        If ComboBox1.Text = "" Then
            MessageBox.Show("You will need to select a supplier type")
            ComboBox1.Focus()
            Exit Sub
        End If
        Me.SupplierTableAdapter.InsertQuery(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, ComboBox1.Text)
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox1.Focus()
    End Sub
End Class
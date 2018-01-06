Public Class ViewItems

    Private Sub YiewItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IGontrol.Item' table. You can move, or remove it, as needed.
        Me.ItemTableAdapter.Fill(Me.IGontrol.Item)
        Me.CenterToScreen()
        Me.Top = 30
    End Sub
End Class
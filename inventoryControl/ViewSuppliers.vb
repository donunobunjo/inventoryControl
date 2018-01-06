Public Class ViewSuppliers

    Private Sub ViewSuppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IGontrol.Supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.IGontrol.Supplier)
        Me.CenterToScreen()
        Me.Top = 50
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
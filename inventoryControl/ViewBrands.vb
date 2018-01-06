Public Class ViewBrands

    Private Sub ViewBrands_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IGontrol.Brand' table. You can move, or remove it, as needed.
        Me.BrandTableAdapter.Fill(Me.IGontrol.Brand)
        Me.CenterToScreen()
        Me.Top = 50
    End Sub
End Class
Public Class ViewWarehouse

    Private Sub ViewWarehouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IGontrol.WareHouse' table. You can move, or remove it, as needed.
        Me.WareHouseTableAdapter.Fill(Me.IGontrol.WareHouse)
        Me.CenterToScreen()
        Me.Top = 50
    End Sub
End Class
Public Class ViewAcctCodes

    Private Sub ViewAcctCodes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IGontrol.AcctCodes' table. You can move, or remove it, as needed.
        Me.AcctCodesTableAdapter.Fill(Me.IGontrol.AcctCodes)
        Me.CenterToScreen()
        Me.Top = 5
    End Sub
End Class
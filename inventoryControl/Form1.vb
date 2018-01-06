Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IGontrol.RequisitionSummary' table. You can move, or remove it, as needed.
        Me.RequisitionSummaryTableAdapter.Fill(Me.IGontrol.RequisitionSummary)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.RequisitionSummaryTableAdapter.Update(Me.IGontrol.RequisitionSummary)
    End Sub
End Class
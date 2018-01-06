Public Class Vendor_History

    Private Sub Vendor_History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'iGontrol.Supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.iGontrol.Supplier)
        'TODO: This line of code loads data into the 'iGontrol.VendorHistory' table. You can move, or remove it, as needed.
        ComboBox1.SelectedIndex = -1
        Me.CenterToScreen()
        Me.Top = 5
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.VendorHistoryTableAdapter.FillBy(Me.iGontrol.VendorHistory, ComboBox1.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
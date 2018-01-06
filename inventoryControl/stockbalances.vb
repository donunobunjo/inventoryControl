Public Class stockbalances

    Private Sub stockbalances_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'iGontrol.check_Balance' table. You can move, or remove it, as needed.
        ' Me.Check_BalanceTableAdapter.Fill(Me.iGontrol.check_Balance)
        Dim myDT As DataTable
        Dim issued As Decimal
        Dim reciepts As Decimal
        Dim bal As Decimal
        'TODO: This line of code loads data into the 'iGontrol.WareHouse' table. You can move, or remove it, as needed.
        Me.WareHouseTableAdapter.Fill(Me.iGontrol.WareHouse)
        'TODO: This line of code loads data into the 'iGontrol.ItemMaster' table. You can move, or remove it, as needed.
        myDT = Me.ItemMasterTableAdapter.GetData
        ' MessageBox.Show(myDT.Rows.Count)
        For j = 0 To myDT.Rows.Count - 1
            Dim upda As New iGontrolTableAdapters.ItemMasterTableAdapter
            Dim itemNum As String
            Dim loca As String
            itemNum = Trim(myDT.Rows(j).Item(6).ToString)
            loca = Trim(myDT.Rows(j).Item(9).ToString)
            issued = Me.Check_BalanceTableAdapter.TotalIssued(itemNum, loca)
            reciepts = Me.Check_BalanceTableAdapter.TotalReciepts(itemNum, loca)
            bal = reciepts - issued
            upda.UpdateQuery(bal, itemNum, loca)
        Next j
        ComboBox1.SelectedIndex = -1
        Me.CenterToScreen()
        Me.Top = 5
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.ItemMasterTableAdapter.FillBy(Me.iGontrol.ItemMaster, ComboBox1.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class
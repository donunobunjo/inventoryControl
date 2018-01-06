Public Class ItemHistory

    Private Sub ItemHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IGontrol.ItemHistory' table. You can move, or remove it, as needed.
        ' Me.ItemHistoryTableAdapter.Fill(Me.IGontrol.ItemHistory)
        'TODO: This line of code loads data into the 'IGontrol.Item' table. You can move, or remove it, as needed.
        Me.ItemTableAdapter.Fill(Me.IGontrol.Item)
        'TODO: This line of code loads data into the 'IGontrol.WareHouse' table. You can move, or remove it, as needed.
        Me.WareHouseTableAdapter.Fill(Me.IGontrol.WareHouse)
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        Me.CenterToScreen()
        Me.Top = 5
        ' Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Me.ItemHistoryTableAdapter.FillBy(Me.IGontrol.ItemHistory, Trim(ComboBox2.Text), Trim(ComboBox1.Text), Trim(ComboBox1.Text))
        Me.ItemHistoryTableAdapter.FillBy(Me.IGontrol.ItemHistory, Trim(ComboBox2.Text), Trim(ComboBox1.Text), Trim(ComboBox1.Text), Trim(ComboBox1.Text), Trim(ComboBox1.Text))
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ' Me.ItemHistoryTableAdapter.FillBy(Me.IGontrol.ItemHistory, Trim(ComboBox2.Text), Trim(ComboBox1.Text), Trim(ComboBox1.Text))
        Me.ItemHistoryTableAdapter.FillBy(Me.IGontrol.ItemHistory, Trim(ComboBox2.Text), Trim(ComboBox1.Text), Trim(ComboBox1.Text), Trim(ComboBox1.Text), Trim(ComboBox1.Text))
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
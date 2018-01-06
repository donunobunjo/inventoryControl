Public Class ApproveRequisition

    Private Sub ApproveRequisition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IGontrol.WareHouse' table. You can move, or remove it, as needed.
        Me.WareHouseTableAdapter.Fill(Me.IGontrol.WareHouse)
        'TODO: This line of code loads data into the 'IGontrol.RequisitionSummary' table. You can move, or remove it, as needed.
        Me.RequisitionSummaryTableAdapter.FillByAll(Me.IGontrol.RequisitionSummary, "PENDIhhhhNG")
        'TODO: This line of code loads data into the 'IGontrol.Department' table. You can move, or remove it, as needed.
        Me.DepartmentTableAdapter.Fill(Me.IGontrol.Department)
        ComboBox1.SelectedIndex = -1
        Me.CenterToScreen()
        Me.Top = 3
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            ComboBox1.Enabled = True
            
        Else
            ComboBox1.Enabled = False
            Me.RequisitionSummaryTableAdapter.FillByAll(Me.IGontrol.RequisitionSummary, "PENDIhhhhNG")
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
        Else
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
            Me.RequisitionSummaryTableAdapter.FillByAll(Me.IGontrol.RequisitionSummary, "PENDIhhhhNG")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.RequisitionSummaryTableAdapter.Update(Me.IGontrol.RequisitionSummary)
        MessageBox.Show("Database updated successfully")
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Me.RequisitionSummaryTableAdapter.FillByAll(Me.IGontrol.RequisitionSummary, "PENDING")
        Else
            Me.RequisitionSummaryTableAdapter.FillByAll(Me.IGontrol.RequisitionSummary, "PENDIhhhhNG")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.RequisitionSummaryTableAdapter.FillByDept(Me.IGontrol.RequisitionSummary, ComboBox1.Text, "PENDING")
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Me.RequisitionSummaryTableAdapter.FillByDate(Me.IGontrol.RequisitionSummary, DateTimePicker1.Text, DateTimePicker2.Text, "PENDING")
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Me.RequisitionSummaryTableAdapter.FillByDate(Me.IGontrol.RequisitionSummary, DateTimePicker1.Text, DateTimePicker2.Text, "PENDING")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim apprvDetails As New ApproveRequisitionDetails
        If DataGridView1.SelectedRows.Count > 0 Then
            apprvDetails.reqNum = DataGridView1.SelectedRows(0).Cells(0).Value
            apprvDetails.department = DataGridView1.SelectedRows(0).Cells(1).Value
            apprvDetails.locatn = DataGridView1.SelectedRows(0).Cells(8).Value
            apprvDetails.ShowDialog()
        Else
            MessageBox.Show("Select a row, by clicking the row marker, before you hit Invoice")
            Exit Sub
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            ComboBox2.Enabled = True

        Else
            ComboBox2.Enabled = False
            Me.RequisitionSummaryTableAdapter.FillByAll(Me.IGontrol.RequisitionSummary, "PENDIhhhhNG")
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Me.RequisitionSummaryTableAdapter.FillByLocations(Me.IGontrol.RequisitionSummary, "PEMDING", ComboBox2.Text)
    End Sub
End Class
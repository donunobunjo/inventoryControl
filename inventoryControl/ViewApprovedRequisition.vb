Public Class ViewApprovedRequisition

    Private Sub ViewApprovedRequisition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IGontrol.ViewApprovedRequisitions' table. You can move, or remove it, as needed.
        ' Me.ViewApprovedRequisitionsTableAdapter.Fill(Me.IGontrol.ViewApprovedRequisitions)
        Me.ViewApprovedRequisitionsTableAdapter.FillByAll(Me.IGontrol.ViewApprovedRequisitions, "APPROVED")
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
            ComboBox1.SelectedIndex = -1
            ComboBox1.Enabled = False
            Me.ViewApprovedRequisitionsTableAdapter.FillByAll(Me.IGontrol.ViewApprovedRequisitions, "APPRsfsfOVED")
            ' Me.RequisitionSummaryTableAdapter.FillByAll(Me.IGontrol.RequisitionSummary, "PENDIhhhhNG")
        End If
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
        Else
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
            Me.ViewApprovedRequisitionsTableAdapter.FillByAll(Me.IGontrol.ViewApprovedRequisitions, "APPRsfsfOVED")
            ' Me.RequisitionSummaryTableAdapter.FillByAll(Me.IGontrol.RequisitionSummary, "PENDIhhhhNG")
        End If
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Me.ViewApprovedRequisitionsTableAdapter.FillByAll(Me.IGontrol.ViewApprovedRequisitions, "APPROVED")
        Else
            Me.ViewApprovedRequisitionsTableAdapter.FillByAll(Me.IGontrol.ViewApprovedRequisitions, "APPRsfsfOVED")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.ViewApprovedRequisitionsTableAdapter.FillByDepartment(Me.IGontrol.ViewApprovedRequisitions, "APPROVED", ComboBox1.Text)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Me.ViewApprovedRequisitionsTableAdapter.FillByDateOfAppvr(Me.IGontrol.ViewApprovedRequisitions, "APPROVED", DateTimePicker1.Text, DateTimePicker2.Text)
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Me.ViewApprovedRequisitionsTableAdapter.FillByDateOfAppvr(Me.IGontrol.ViewApprovedRequisitions, "APPROVED", DateTimePicker1.Text, DateTimePicker2.Text)
    End Sub
End Class
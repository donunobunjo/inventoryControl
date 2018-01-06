Public Class ApproveRequisitionDetails

    Public Property reqNum As String
    Public Property department As String
    Public Property locatn As String
    Private Sub ApproveRequisitionDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IGontrol.ApprvForIssueUpdate' table. You can move, or remove it, as needed.
        Me.ApprvForIssueUpdateTableAdapter.Fill(Me.IGontrol.ApprvForIssueUpdate)
        'TODO: This line of code loads data into the 'IGontrol.RequisitionSummary' table. You can move, or remove it, as needed.
        Me.RequisitionSummaryTableAdapter.Fill(Me.IGontrol.RequisitionSummary)
        'TODO: This line of code loads data into the 'IGontrol.ApprovedRequisitions' table. You can move, or remove it, as needed.
        Me.ApprovedRequisitionsTableAdapter.Fill(Me.IGontrol.ApprovedRequisitions)
        'TODO: This line of code loads data into the 'IGontrol.Requisitions' table. You can move, or remove it, as needed.
        Me.RequisitionsTableAdapter.FillByReqNum(Me.IGontrol.Requisitions, Trim(reqNum))
        TextBox1.Text = reqNum
        TextBox2.Text = department
        TextBox3.Text = locatn
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cnt As Integer
        Dim dt As DataTable
        Dim qty, qtyapprv, bal, qtyApprvInDatabase, qtyApprvReal As Decimal
        Dim bigStatus As String
        Dim status, realReqNum, classs, brand, itemNum, ItemName, partnum, realdepartment, originator, realloc As String
        Dim DOA, DOR As Date
        Dim approved, rejected, partiall As Boolean
        realReqNum = Trim(reqNum)
        realdepartment = Trim(department)

        cnt = Me.DataGridView1.RowCount
        For j = 0 To (cnt - 1)
            qty = Convert.ToDecimal(DataGridView1.Item(11, j).Value.ToString)
            Try
                qtyapprv = Convert.ToDecimal(DataGridView1.Item(12, j).Value.ToString)
            Catch
                qtyapprv = 0D
            End Try
            If qtyapprv > qty Then
                MessageBox.Show("There is something wrong, quantity approved can't be greater than quantity requested. Please check the quantity approved you entered")
                Exit Sub
            End If

            If qtyapprv = 0D Then
                status = "REJECTED"
                bal = qty - qtyapprv
                rejected = True
                approved = False
                partiall = False
            End If
            If qtyapprv < qty And qtyapprv <> 0D Then
                status = "PARTIAL"
                bal = qty - qtyapprv
                rejected = False
                approved = False
                partiall = True
            End If
            If qtyapprv = qty Then
                status = "APPROVED"
                bal = qty - qtyapprv
                rejected = False
                approved = True
                partiall = False
            End If
            classs = DataGridView1.Item(2, j).Value.ToString
            brand = DataGridView1.Item(3, j).Value.ToString
            itemNum = DataGridView1.Item(4, j).Value.ToString
            ItemName = DataGridView1.Item(5, j).Value.ToString
            partnum = DataGridView1.Item(6, j).Value.ToString
            DOR = Convert.ToDateTime(DataGridView1.Item(7, j).Value)
            realloc = Trim(locatn)
            'DOA=(Date)DateTimePicker1.Text
            originator = DataGridView1.Item(8, j).Value.ToString
            Me.ApprovedRequisitionsTableAdapter.InsertQuery(realReqNum, classs, brand, itemNum, ItemName, partnum, DOR, realdepartment, originator, status, qty, 0.0, 0.0, DOA, qtyapprv, approved, rejected, partiall, bal, realloc)
            dt = Me.CheckApprovedQtyTableAdapter.GetData(Trim(itemNum), Trim(locatn))
            qtyApprvInDatabase = System.Convert.ToDecimal(dt.Rows(0).Item(1).ToString)
            qtyApprvReal = qtyapprv + qtyApprvInDatabase
            Me.ApprvForIssueUpdateTableAdapter.UpdateQuery(qtyApprvReal, Trim(locatn), Trim(itemNum))
        Next
        Me.RequisitionSummaryTableAdapter.StatusToTreated("TREATED", realReqNum)
        Me.RequisitionsTableAdapter.Update(Me.IGontrol.Requisitions)

        MessageBox.Show("Requisition has been treated")
        Me.Close()
        '' Me.RequisitionsTableAdapter.Update(Me.IGontrol.Requisitions)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
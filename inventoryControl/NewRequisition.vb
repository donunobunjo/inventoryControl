Public Class NewRequisition
    Dim total As Decimal
    Dim loc As String
    Dim amount As Double
    Private Sub NewRequisition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IGontrol.WareHouse' table. You can move, or remove it, as needed.
        Me.WareHouseTableAdapter.Fill(Me.IGontrol.WareHouse)
        'TODO: This line of code loads data into the 'IGontrol.RequisitionSummary' table. You can move, or remove it, as needed.
        Me.RequisitionSummaryTableAdapter.Fill(Me.IGontrol.RequisitionSummary)
        'TODO: This line of code loads data into the 'IGontrol.Requisitions' table. You can move, or remove it, as needed.
        Me.RequisitionsTableAdapter.Fill(Me.IGontrol.Requisitions)
        'TODO: This line of code loads data into the 'IGontrol.Department' table. You can move, or remove it, as needed.
        Me.DepartmentTableAdapter.Fill(Me.IGontrol.Department)
        'TODO: This line of code loads data into the 'IGontrol.Item' table. You can move, or remove it, as needed.
        '  Me.ItemTableAdapter.Fill(Me.IGontrol.Item)
        'TODO: This line of code loads data into the 'IGontrol.Brand' table. You can move, or remove it, as needed.
        Me.BrandTableAdapter.Fill(Me.IGontrol.Brand)
        'TODO: This line of code loads data into the 'IGontrol.Classification' table. You can move, or remove it, as needed.
        Me.ClassificationTableAdapter.Fill(Me.IGontrol.Classification)
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1
        ComboBox4.SelectedIndex = -1
        ComboBox5.SelectedIndex = -1
        Me.CenterToScreen()
        Me.Top = 1
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mydata As DataTable

        If TextBox1.Text = "" Then
            MessageBox.Show("You need to enter a requisition number")
            TextBox1.Focus()
            Exit Sub
        End If
        mydata = Me.RequisitionSummaryTableAdapter.GetDataByRequisitionNumber(TextBox1.Text)
        If mydata.Rows.Count > 0 Then
            MessageBox.Show("A requistion with this requisition number already exists, please change the requisition number")
            TextBox1.Focus()
            Exit Sub
        End If
        If ComboBox1.Text = "" Then
            MessageBox.Show("You need to pick a classification")
            ComboBox1.Focus()
            Exit Sub
        End If
        If ComboBox2.Text = "" Then
            MessageBox.Show("You need to pick a brand")
            ComboBox2.Focus()
            Exit Sub
        End If
        If ComboBox3.Text = "" Then
            MessageBox.Show("You need to pick an item number")
            ComboBox3.Focus()
            Exit Sub
        End If
        If ComboBox4.Text = "" Then
            MessageBox.Show("You need to pick an originating department")
            ComboBox4.Focus()
            Exit Sub
        End If
        If ComboBox5.Text = "" Then
            MessageBox.Show("You need to pick a location")
            ComboBox5.Focus()
            Exit Sub
        End If
        If TextBox3.Text = "" Then
            MessageBox.Show("You need to enter a quantity")
            TextBox3.Focus()
            Exit Sub
        End If
        If TextBox4.Text = "" Then
            MessageBox.Show("You need to enter aa amount")
            TextBox4.Focus()
            Exit Sub
        End If
        Dim itemnum, itemnumsssss As String
        Dim j As Integer
        For j = 0 To Me.DataGridView1.RowCount - 1
            itemnumsssss = DataGridView1.Rows(j).Cells(3).Value
            itemnum = Trim(ComboBox4.Text)
            If itemnumsssss = itemnum Then
                MessageBox.Show("You have already entered this item number in the grid, you can't enter it again")
                Exit Sub
            End If
        Next
        Dim itemsCount As Int32
        Dim rate, quantity As Double
        Dim itemname, partnumber As String
        Dim dt As DataTable
        dt = Me.ItemTableAdapter.GetDataByItemNumber(ComboBox3.Text)
        itemsCount = DataGridView1.RowCount
        DataGridView1.Rows.Add()
        DataGridView1.Rows(itemsCount - 1).Cells(0).Value = TextBox1.Text
        DataGridView1.Rows(itemsCount - 1).Cells(1).Value = ComboBox1.Text
        DataGridView1.Rows(itemsCount - 1).Cells(2).Value = ComboBox2.Text
        DataGridView1.Rows(itemsCount - 1).Cells(3).Value = ComboBox3.Text
        DataGridView1.Rows(itemsCount - 1).Cells(4).Value = Trim(dt.Rows(0).Item(4).ToString)
        DataGridView1.Rows(itemsCount - 1).Cells(5).Value = Trim(dt.Rows(0).Item(1).ToString)
        DataGridView1.Rows(itemsCount - 1).Cells(6).Value = DateTimePicker1.Text
        DataGridView1.Rows(itemsCount - 1).Cells(7).Value = ComboBox4.Text
        DataGridView1.Rows(itemsCount - 1).Cells(8).Value = TextBox2.Text
        DataGridView1.Rows(itemsCount - 1).Cells(10).Value = TextBox3.Text
        DataGridView1.Rows(itemsCount - 1).Cells(11).Value = TextBox4.Text
        rate = Convert.ToDouble(TextBox4.Text)
        quantity = Convert.ToDouble(TextBox3.Text)
        amount = rate * quantity
        total = total + amount
        TextBox6.Text = Convert.ToString(total)
        DataGridView1.Rows(itemsCount - 1).Cells(12).Value = amount
        TextBox1.Enabled = False
        DateTimePicker1.Enabled = False
        ComboBox4.Enabled = False
        loc = ComboBox5.Text
        ComboBox5.Enabled = False
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""

    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
                If Me.TextBox3.Text.Contains(".") Then
                    If Me.TextBox3.Text.Split(".")(1).Length < 2 Then
                        If Char.IsDigit(e.KeyChar) = False Then
                            e.Handled = True
                        End If
                    Else
                        e.Handled = True
                    End If
                End If
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
                If Me.TextBox4.Text.Contains(".") Then
                    If Me.TextBox4.Text.Split(".")(1).Length < 2 Then
                        If Char.IsDigit(e.KeyChar) = False Then
                            e.Handled = True
                        End If
                    Else
                        e.Handled = True
                    End If
                End If
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        TextBox6.Text = FormatNumber(total, 2, TriState.True)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim deduct As Decimal
        If DataGridView1.SelectedRows.Count > 0 Then
            deduct = Convert.ToDecimal(DataGridView1.SelectedRows(0).Cells(12).Value)
            total = total - deduct
            TextBox6.Text = Convert.ToString(total)
            DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
        Else
            MessageBox.Show("Select a row, by clicking the row marker, before you hit Remove Button")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox6.Text = ""
        total = 0D
        DataGridView1.Rows.Clear()
        TextBox1.Enabled = True
        ComboBox4.Enabled = True
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1
        ComboBox4.SelectedIndex = -1
        DateTimePicker1.Enabled = True
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox1.Clear()
        TextBox4.Clear()
        TextBox6.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim reqdate As Date
        Dim reqnum, classs, brand, itemnum, itemname, partnum, dept, originator, status As String
        Dim quantity, rate, amount As Decimal
        
        For j = 0 To (Me.DataGridView1.RowCount - 1) - 1
            reqnum = DataGridView1.Item(0, j).Value.ToString
            classs = DataGridView1.Item(1, j).Value.ToString
            brand = DataGridView1.Item(2, j).Value.ToString
            itemnum = DataGridView1.Item(3, j).Value.ToString
            itemname = DataGridView1.Item(4, j).Value.ToString
            partnum = DataGridView1.Item(5, j).Value.ToString
            reqdate = Convert.ToDateTime(DataGridView1.Item(6, j).Value)
            dept = DataGridView1.Item(7, j).Value.ToString
            originator = DataGridView1.Item(8, j).Value.ToString
            status = "PENDING"
            quantity = Convert.ToDecimal(DataGridView1.Item(10, j).Value.ToString)
            rate = Convert.ToDecimal(DataGridView1.Item(11, j).Value.ToString)
            amount = Convert.ToDecimal(DataGridView1.Item(12, j).Value.ToString)
            Me.RequisitionsTableAdapter.InsertQuery(reqnum, classs, brand, itemnum, itemname, partnum, reqdate, dept, originator, status, quantity, rate, amount, reqdate, 0.0, False, False, False, loc)

        Next
        Me.RequisitionSummaryTableAdapter.InsertQuery(reqnum, dept, reqdate, total, status, False, False, False, loc)
        MessageBox.Show("The rquisition has been stored")
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim reqdate As Date
        Dim reqnum, classs, brand, itemnum, itemname, partnum, dept, originator, status As String
        Dim quantity, rate, amount As Decimal

        For j = 0 To (Me.DataGridView1.RowCount - 1) - 1
            reqnum = DataGridView1.Item(0, j).Value.ToString
            classs = DataGridView1.Item(1, j).Value.ToString
            brand = DataGridView1.Item(2, j).Value.ToString
            itemnum = DataGridView1.Item(3, j).Value.ToString
            itemname = DataGridView1.Item(4, j).Value.ToString
            partnum = DataGridView1.Item(5, j).Value.ToString
            reqdate = Convert.ToDateTime(DataGridView1.Item(6, j).Value)
            dept = DataGridView1.Item(7, j).Value.ToString
            originator = DataGridView1.Item(8, j).Value.ToString
            status = "PENDING"
            quantity = Convert.ToDecimal(DataGridView1.Item(10, j).Value.ToString)
            rate = Convert.ToDecimal(DataGridView1.Item(11, j).Value.ToString)
            amount = Convert.ToDecimal(DataGridView1.Item(12, j).Value.ToString)
            Me.RequisitionsTableAdapter.InsertQuery(reqnum, classs, brand, itemnum, itemname, partnum, reqdate, dept, originator, status, quantity, rate, amount, reqdate, 0.0, False, False, False, loc)

        Next
        Me.RequisitionSummaryTableAdapter.InsertQuery(reqnum, dept, reqdate, total, status, False, False, False, loc)
        MessageBox.Show("The rquisition has been stored")
        TextBox6.Text = ""
        total = 0D
        DataGridView1.Rows.Clear()
        TextBox1.Enabled = True
        ComboBox4.Enabled = True
        ComboBox5.Enabled = True
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1
        ComboBox4.SelectedIndex = -1
        ComboBox5.SelectedIndex = -1
        DateTimePicker1.Enabled = True
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox1.Clear()
        TextBox4.Clear()
        TextBox6.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub

    Private Sub ComboBox3_Enter(sender As Object, e As EventArgs) Handles ComboBox3.Enter
        Me.ItemTableAdapter.FillByClassificationNDBrand(Me.IGontrol.Item, ComboBox1.Text, ComboBox2.Text)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox3.SelectedIndex = -1
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox3.SelectedIndex = -1
    End Sub
End Class
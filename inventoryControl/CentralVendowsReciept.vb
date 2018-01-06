Public Class CentralVendowsReciept
    Dim total As Decimal
    Dim amount As Double
    Private Sub CentralVendowsReciept_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IGontrol.Stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter.Fill(Me.IGontrol.Stock)
        'TODO: This line of code loads data into the 'IGontrol.Item' table. You can move, or remove it, as needed.
        ' Me.ItemTableAdapter.Fill(Me.IGontrol.Item)
        'TODO: This line of code loads data into the 'IGontrol.Brand' table. You can move, or remove it, as needed.
        Me.BrandTableAdapter.Fill(Me.IGontrol.Brand)
        'TODO: This line of code loads data into the 'IGontrol.Classification' table. You can move, or remove it, as needed.
        Me.ClassificationTableAdapter.Fill(Me.IGontrol.Classification)
        'TODO: This line of code loads data into the 'IGontrol.Supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.IGontrol.Supplier)
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1
        ComboBox4.SelectedIndex = -1
        Me.CenterToScreen()
        Me.Top = 5
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Then
            MessageBox.Show("You need to pick a vendor")
            ComboBox1.Focus()
            Exit Sub
        End If
        If ComboBox2.Text = "" Then
            MessageBox.Show("You need to pick a Classification")
            ComboBox2.Focus()
            Exit Sub
        End If
        If ComboBox3.Text = "" Then
            MessageBox.Show("You need to pick a brand")
            ComboBox3.Focus()
            Exit Sub
        End If
        If ComboBox4.Text = "" Then
            MessageBox.Show("You need to pick an item number")
            ComboBox4.Focus()
            Exit Sub
        End If
        If TextBox1.Text = "" Then
            MessageBox.Show("You need to enter quantity")
            TextBox1.Focus()
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            MessageBox.Show("You need to enter the unit price")
            TextBox2.Focus()
            Exit Sub
        End If
        Dim itemsCount As Int32
        Dim rate, quantity As Double
        Dim itemname, partnumber As String
        Dim dt As DataTable
        dt = Me.ItemTableAdapter.GetDataByItemNumber(ComboBox3.Text)
        itemsCount = DataGridView1.RowCount
        DataGridView1.Rows.Add()
        DataGridView1.Rows(itemsCount - 1).Cells(0).Value = Trim(ComboBox2.Text)
        DataGridView1.Rows(itemsCount - 1).Cells(1).Value = Trim(ComboBox3.Text)
        DataGridView1.Rows(itemsCount - 1).Cells(2).Value = Trim(ComboBox4.Text)
        DataGridView1.Rows(itemsCount - 1).Cells(3).Value = Trim(TextBox4.Text)
        DataGridView1.Rows(itemsCount - 1).Cells(4).Value = Trim(TextBox5.Text)
        DataGridView1.Rows(itemsCount - 1).Cells(5).Value = Trim(TextBox1.Text)
        DataGridView1.Rows(itemsCount - 1).Cells(6).Value = Trim(TextBox2.Text)
        DataGridView1.Rows(itemsCount - 1).Cells(8).Value = DateTimePicker2.Text
        DataGridView1.Rows(itemsCount - 1).Cells(9).Value = DateTimePicker1.Text
        rate = Convert.ToDouble(TextBox2.Text)
        quantity = Convert.ToDouble(TextBox1.Text)
        amount = rate * quantity
        total = total + amount
        TextBox3.Text = Convert.ToString(amount)
        TextBox6.Text = Convert.ToString(total)
        DataGridView1.Rows(itemsCount - 1).Cells(7).Value = amount
        ComboBox1.Enabled = False
        DateTimePicker1.Enabled = False
        amount = 0
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox2.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1
        ComboBox4.SelectedIndex = -1
    End Sub

    Private Sub ComboBox3_Enter(sender As Object, e As EventArgs) Handles ComboBox3.Enter

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
                If Me.TextBox1.Text.Contains(".") Then
                    If Me.TextBox1.Text.Split(".")(1).Length < 2 Then
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

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
                If Me.TextBox2.Text.Contains(".") Then
                    If Me.TextBox2.Text.Split(".")(1).Length < 2 Then
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

    Private Sub ComboBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox4.KeyPress
        'Me.ItemTableAdapter.FillByClassificationNDBrand(Me.IGontrol.Item, ComboBox2.Text, ComboBox3.Text)
    End Sub

    Private Sub ComboBox4_Enter(sender As Object, e As EventArgs) Handles ComboBox4.Enter
        Me.ItemTableAdapter.FillByClassificationNDBrand(Me.IGontrol.Item, ComboBox2.Text, ComboBox3.Text)
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox4.SelectedIndex = -1
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        ComboBox4.SelectedIndex = -1
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        Dim dt As DataTable
        dt = Me.ItemTableAdapter.GetDataByItemNumber(ComboBox4.Text)
        If dt.Rows.Count = 0 Then
            TextBox4.Text = ""
            TextBox5.Text = ""
        Else
            TextBox4.Text = dt.Rows(0).Item(4).ToString
            TextBox5.Text = dt.Rows(0).Item(1).ToString
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        TextBox3.Text = FormatNumber(amount, 2, TriState.True)
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

        TextBox6.Text = FormatNumber(total, 2, TriState.True)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim deduct As Decimal
        If DataGridView1.SelectedRows.Count > 0 Then
            deduct = Convert.ToDecimal(DataGridView1.SelectedRows(0).Cells(7).Value)
            total = total - deduct
            TextBox6.Text = Convert.ToString(total)
            DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
        Else
            MessageBox.Show("Select a row, by clicking the row marker, before you hit Remove Button")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim recdate, expdate As Date
        Dim source, destination, classs, brand, itemnum, itemname, partnum, loc, typeoftrans, major, majorminor, minor, detail As String
        Dim rate, amount, reciepts, issued As Decimal
        For j = 0 To (Me.DataGridView1.RowCount - 1) - 1
            classs = DataGridView1.Item(0, j).Value.ToString
            brand = DataGridView1.Item(1, j).Value.ToString
            itemnum = DataGridView1.Item(2, j).Value.ToString
            itemname = DataGridView1.Item(3, j).Value.ToString
            partnum = DataGridView1.Item(4, j).Value.ToString
            'quantity = Convert.ToDecimal(DataGridView1.Item(5, j).Value.ToString)
            rate = Convert.ToDecimal(DataGridView1.Item(6, j).Value.ToString)
            amount = Convert.ToDecimal(DataGridView1.Item(7, j).Value.ToString)
            source = Trim(ComboBox1.Text)
            destination = "CENTRAL"
            loc = "CENTRAL"
            typeoftrans = "SUPPLY"
            major = "SUPPLY"
            majorminor = "SUPPLY"
            minor = "CENTRAL"
            detail = "VENDOR SUPPLY"
            reciepts = Convert.ToDecimal(DataGridView1.Item(5, j).Value.ToString)
            issued = 0.0
            expdate = Convert.ToDateTime(DataGridView1.Item(8, j).Value)
            recdate = Convert.ToDateTime(DataGridView1.Item(9, j).Value)
            Me.StockTableAdapter.InsertQuery(classs, brand, loc, "", typeoftrans, detail, "", "", recdate, source, destination, issued, reciepts, rate, amount, itemnum, itemname, partnum, expdate, major, majorminor, minor, 0.0)
        Next
        MessageBox.Show("Database updated successfully")
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        amount = 0
        total = 0
        ComboBox1.Enabled = True
        DateTimePicker1.Enabled = True
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1
        ComboBox4.SelectedIndex = -1
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        DataGridView1.Rows.Clear()
        ComboBox1.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim recdate, expdate As Date
        Dim source, destination, classs, brand, itemnum, itemname, partnum, loc, typeoftrans, major, majorminor, minor, detail As String
        Dim rate, amount, reciepts, issued As Decimal
        For j = 0 To (Me.DataGridView1.RowCount - 1) - 1
            classs = DataGridView1.Item(0, j).Value.ToString
            brand = DataGridView1.Item(1, j).Value.ToString
            itemnum = DataGridView1.Item(2, j).Value.ToString
            itemname = DataGridView1.Item(3, j).Value.ToString
            partnum = DataGridView1.Item(4, j).Value.ToString
            'quantity = Convert.ToDecimal(DataGridView1.Item(5, j).Value.ToString)
            rate = Convert.ToDecimal(DataGridView1.Item(6, j).Value.ToString)
            amount = Convert.ToDecimal(DataGridView1.Item(7, j).Value.ToString)
            source = Trim(ComboBox1.Text)
            destination = "CENTRAL"
            loc = "CENTRAL"
            typeoftrans = "SUPPLY"
            major = "SUPPLY"
            majorminor = "SUPPLY"
            minor = "CENTRAL"
            detail = "VENDOR SUPPLY"
            reciepts = Convert.ToDecimal(DataGridView1.Item(5, j).Value.ToString)
            issued = 0.0
            expdate = Convert.ToDateTime(DataGridView1.Item(8, j).Value)
            recdate = Convert.ToDateTime(DataGridView1.Item(9, j).Value)
            Me.StockTableAdapter.InsertQuery(classs, brand, loc, "", typeoftrans, detail, "", "", recdate, source, destination, issued, reciepts, rate, amount, itemnum, itemname, partnum, expdate, major, majorminor, minor, 0.0)
        Next
        MessageBox.Show("Database updated successfully")
        amount = 0
        total = 0
        ComboBox1.Enabled = True
        DateTimePicker1.Enabled = True
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1
        ComboBox4.SelectedIndex = -1
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        DataGridView1.Rows.Clear()
        ComboBox1.Focus()
    End Sub
End Class
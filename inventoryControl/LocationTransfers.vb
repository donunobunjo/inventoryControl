Public Class LocationTransfers
    Dim total As Decimal
    Dim amount As Double
    Dim totalIssued As Decimal
    Dim totalRecieved As Decimal
    Dim bal As Decimal
    Dim qtyentered As Decimal
    Dim dtApprovedQty As DataTable
    Dim qtyAprvv As Decimal
    Private Sub CentralVendowsReciept_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IGontrol.WareHouse' table. You can move, or remove it, as needed.
        Me.WareHouseTableAdapter.Fill(Me.IGontrol.WareHouse)
        'TODO: This line of code loads data into the 'IGontrol.checkCost' table. You can move, or remove it, as needed.
        Me.CheckCostTableAdapter.Fill(Me.IGontrol.checkCost)
        'TODO: This line of code loads data into the 'IGontrol.ItemMaster' table. You can move, or remove it, as needed.
        Me.ItemMasterTableAdapter.Fill(Me.IGontrol.ItemMaster)
        'TODO: This line of code loads data into the 'IGontrol.check_Balance' table. You can move, or remove it, as needed.
        Me.Check_BalanceTableAdapter.Fill(Me.IGontrol.check_Balance)
        'TODO: This line of code loads data into the 'IGontrol.JobCard' table. You can move, or remove it, as needed.
        Me.JobCardTableAdapter.Fill(Me.IGontrol.JobCard)
        'TODO: This line of code loads data into the 'IGontrol.Department' table. You can move, or remove it, as needed.
        Me.DepartmentTableAdapter.Fill(Me.IGontrol.Department)
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
        ComboBox5.SelectedIndex = -1
        Me.CenterToScreen()
        Me.Top = 5
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
       
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
        If TextBox1.Text = "0" Then
            MessageBox.Show("quantity can't be zero")
            TextBox1.Focus()
            Exit Sub
        End If
        If ComboBox1.Text = "" Then
            MessageBox.Show("You need to pick a source location")
            ComboBox1.Focus()
            Exit Sub
        End If
        If ComboBox5.Text = "" Then
            MessageBox.Show("You need to pick a destination location")
            ComboBox5.Focus()
            Exit Sub
        End If
        If ComboBox1.Text = ComboBox5.Text Then
            MessageBox.Show("Source location and destination location can't be the same")
            Exit Sub
        End If
        Try
            totalIssued = Me.Check_BalanceTableAdapter.TotalIssued(Trim(ComboBox4.Text), Trim(ComboBox1.Text))
        Catch
            totalIssued = 0
        End Try
        Try
            totalRecieved = Me.Check_BalanceTableAdapter.TotalReciepts(Trim(ComboBox4.Text), Trim(ComboBox1.Text))
        Catch
            totalRecieved = 0
        End Try
        bal = totalRecieved - totalIssued
        qtyentered = System.Convert.ToDecimal(TextBox1.Text)
        
        If qtyentered > bal Then
            MessageBox.Show("Quantity you entered is more than the quantity in stock")
            TextBox1.Focus()
            Exit Sub
        End If
        ' check for duplicates
        Dim itemnum, itemnumsssss As String
        Dim j As Integer
        For j = 0 To Me.DataGridView1.RowCount - 1
            itemnumsssss = DataGridView1.Rows(j).Cells(2).Value
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
        DataGridView1.Rows(itemsCount - 1).Cells(0).Value = Trim(ComboBox2.Text)
        DataGridView1.Rows(itemsCount - 1).Cells(1).Value = Trim(ComboBox3.Text)
        DataGridView1.Rows(itemsCount - 1).Cells(2).Value = Trim(ComboBox4.Text)
        DataGridView1.Rows(itemsCount - 1).Cells(3).Value = Trim(TextBox4.Text)
        DataGridView1.Rows(itemsCount - 1).Cells(4).Value = Trim(TextBox5.Text)
        DataGridView1.Rows(itemsCount - 1).Cells(5).Value = Trim(ComboBox1.Text)
        DataGridView1.Rows(itemsCount - 1).Cells(6).Value = Trim(ComboBox5.Text)
        DataGridView1.Rows(itemsCount - 1).Cells(7).Value = DateTimePicker1.Text
        DataGridView1.Rows(itemsCount - 1).Cells(8).Value = Trim(TextBox1.Text)
        
        quantity = Convert.ToDouble(TextBox1.Text)
       
        TextBox3.Text = Convert.ToString(amount)

       
        DateTimePicker1.Enabled = False
        ComboBox1.Enabled = False
        ComboBox5.Enabled = False
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

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs)

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

        ' Dim unitCost As String
        dt = Me.ItemTableAdapter.GetDataByItemNumber(ComboBox4.Text)
        If ComboBox4.Text = "" Then
            Exit Sub
        Else
            If dt.Rows.Count = 0 Then
                TextBox4.Text = ""
                TextBox5.Text = ""
            Else
                TextBox4.Text = dt.Rows(0).Item(4).ToString
                TextBox5.Text = dt.Rows(0).Item(1).ToString
            End If
           
        End If
        If ComboBox1.Enabled = False And ComboBox5.Enabled = False Then
            Try
                totalIssued = Me.Check_BalanceTableAdapter.TotalIssued(Trim(ComboBox4.Text), Trim(ComboBox1.Text))
            Catch
                totalIssued = 0
            End Try
            Try
                totalRecieved = Me.Check_BalanceTableAdapter.TotalReciepts(Trim(ComboBox4.Text), Trim(ComboBox1.Text))
            Catch
                totalRecieved = 0
            End Try
            bal = totalRecieved - totalIssued

            TextBox3.Text = bal.ToString

            Try
                totalIssued = Me.Check_BalanceTableAdapter.TotalIssued(Trim(ComboBox4.Text), Trim(ComboBox5.Text))
            Catch
                totalIssued = 0
            End Try
            Try
                totalRecieved = Me.Check_BalanceTableAdapter.TotalReciepts(Trim(ComboBox4.Text), Trim(ComboBox5.Text))
            Catch
                totalRecieved = 0
            End Try
            bal = totalRecieved - totalIssued

            TextBox2.Text = bal.ToString
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        'TextBox3.Text = FormatNumber(amount, 2, TriState.True)
    End Sub



    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim deduct As Decimal
        If DataGridView1.SelectedRows.Count > 0 Then
            deduct = Convert.ToDecimal(DataGridView1.SelectedRows(0).Cells(7).Value)
            total = total - deduct

            DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
        Else
            MessageBox.Show("Select a row, by clicking the row marker, before you hit Remove Button")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim recdate, expdate As Date
        Dim source, destination, classs, brand, itemnum, itemname, partnum, loc, typeoftrans, major, majorminor, minor, detail As String
        Dim amount, reciepts, issued, quantity As Decimal
        For j = 0 To (Me.DataGridView1.RowCount - 1) - 1
            classs = DataGridView1.Item(0, j).Value.ToString
            brand = DataGridView1.Item(1, j).Value.ToString
            itemnum = DataGridView1.Item(2, j).Value.ToString
            itemname = DataGridView1.Item(3, j).Value.ToString
            partnum = DataGridView1.Item(4, j).Value.ToString
            quantity = Convert.ToDecimal(DataGridView1.Item(8, j).Value.ToString)
            ' rate = Convert.ToDecimal(DataGridView1.Item(6, j).Value.ToString)
            ' amount = Convert.ToDecimal(DataGridView1.Item(7, j).Value.ToString)
            source = DataGridView1.Item(5, j).Value.ToString

            loc = DataGridView1.Item(5, j).Value.ToString
            typeoftrans = "LOC TRANSFERS"
            major = "LOCTRANSFERS"
            majorminor = "LOCTRANSFERS"
            minor = "LOCTRANSFERS"
            detail = "INTER LOC. TRANSFERS"
            'reciepts = Convert.ToDecimal(DataGridView1.Item(5, j).Value.ToString)
            issued = quantity
            reciepts = quantity
            ' issued = Convert.ToDecimal(DataGridView1.Item(5, j).Value.ToString)
            ' expdate = Convert.ToDateTime(DataGridView1.Item(8, j).Value)
            recdate = Convert.ToDateTime(DataGridView1.Item(7, j).Value)
           
            destination = DataGridView1.Item(6, j).Value.ToString
            ' Me.StockTableAdapter.InsertQuery(classs, brand, loc, "", typeoftrans, detail, "", "", recdate, source, destination, issued, reciepts, rate, amount, itemnum, itemname, partnum, expdate, major, majorminor, minor)
            ' Me.StockTableAdapter.InsertQuery(classs, brand, loc, destination, typeoftrans, detail, "", "", recdate, source, destination, issued, reciepts, 0.0, 0.0, itemnum, itemname, partnum, recdate, major, major, minor, 0)
            Me.StockTableAdapter.InsertQuery(classs, brand, loc, "", typeoftrans, detail, "", "", recdate, source, destination, 0, reciepts, 0, 0, itemnum, itemname, partnum, recdate, major, majorminor, destination, 0)
            Me.StockTableAdapter.InsertQuery(classs, brand, loc, "", typeoftrans, detail, "", "", recdate, source, destination, issued, 0, 0, 0, itemnum, itemname, partnum, recdate, major, majorminor, source, 0)
        Next
        MessageBox.Show("Database updated successfully")
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        amount = 0
        total = 0
        ComboBox1.Enabled = True
        ComboBox5.Enabled = True
        DateTimePicker1.Enabled = True
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1
        'ComboBox4.SelectedIndex = -1
        ComboBox5.SelectedIndex = -1
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        '      TextBox6.Text = ""
        '     TextBox7.Text = ""

        DataGridView1.Rows.Clear()
        'ComboBox1.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim recdate, expdate As Date
        Dim source, destination, classs, brand, itemnum, itemname, partnum, loc, typeoftrans, major, majorminor, minor, detail As String
        Dim amount, reciepts, issued, quantity As Decimal
        For j = 0 To (Me.DataGridView1.RowCount - 1) - 1
            classs = DataGridView1.Item(0, j).Value.ToString
            brand = DataGridView1.Item(1, j).Value.ToString
            itemnum = DataGridView1.Item(2, j).Value.ToString
            itemname = DataGridView1.Item(3, j).Value.ToString
            partnum = DataGridView1.Item(4, j).Value.ToString
            quantity = Convert.ToDecimal(DataGridView1.Item(8, j).Value.ToString)
            ' rate = Convert.ToDecimal(DataGridView1.Item(6, j).Value.ToString)
            ' amount = Convert.ToDecimal(DataGridView1.Item(7, j).Value.ToString)
            source = DataGridView1.Item(5, j).Value.ToString

            loc = DataGridView1.Item(5, j).Value.ToString
            typeoftrans = "LOC TRANSFERS"
            major = "LOCTRANSFERS"
            majorminor = "LOCTRANSFERS"
            minor = "LOCTRANSFERS"
            detail = "INTER LOC. TRANSFERS"
            'reciepts = Convert.ToDecimal(DataGridView1.Item(5, j).Value.ToString)
            issued = quantity
            reciepts = quantity
            ' issued = Convert.ToDecimal(DataGridView1.Item(5, j).Value.ToString)
            ' expdate = Convert.ToDateTime(DataGridView1.Item(8, j).Value)
            recdate = Convert.ToDateTime(DataGridView1.Item(7, j).Value)

            destination = DataGridView1.Item(6, j).Value.ToString
            ' Me.StockTableAdapter.InsertQuery(classs, brand, loc, "", typeoftrans, detail, "", "", recdate, source, destination, issued, reciepts, rate, amount, itemnum, itemname, partnum, expdate, major, majorminor, minor)
            ' Me.StockTableAdapter.InsertQuery(classs, brand, loc, destination, typeoftrans, detail, "", "", recdate, source, destination, issued, reciepts, 0.0, 0.0, itemnum, itemname, partnum, recdate, major, major, minor, 0)
            Me.StockTableAdapter.InsertQuery(classs, brand, loc, "", typeoftrans, detail, "", "", recdate, source, destination, 0, reciepts, 0, 0, itemnum, itemname, partnum, recdate, major, majorminor, minor, 0)
            Me.StockTableAdapter.InsertQuery(classs, brand, loc, "", typeoftrans, detail, "", "", recdate, source, destination, issued, 0, 0, 0, itemnum, itemname, partnum, recdate, major, majorminor, minor, 0)
        Next
        MessageBox.Show("Database updated successfully")
        amount = 0
        total = 0
        ComboBox1.Enabled = True
        ComboBox5.Enabled = True
        DateTimePicker1.Enabled = True
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1
        'ComboBox4.SelectedIndex = -1
        ComboBox5.SelectedIndex = -1
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        '      TextBox6.Text = ""
        '     TextBox7.Text = ""

        DataGridView1.Rows.Clear()
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
       
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs)
        'TextBox7.Text = FormatNumber(amount, 2, TriState.True)
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs)
       
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Try
            totalIssued = Me.Check_BalanceTableAdapter.TotalIssued(Trim(ComboBox4.Text), Trim(ComboBox1.Text))
        Catch
            totalIssued = 0
        End Try
        Try
            totalRecieved = Me.Check_BalanceTableAdapter.TotalReciepts(Trim(ComboBox4.Text), Trim(ComboBox1.Text))
        Catch
            totalRecieved = 0
        End Try
        bal = totalRecieved - totalIssued

        TextBox3.Text = bal.ToString
       
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged

        Try
            totalIssued = Me.Check_BalanceTableAdapter.TotalIssued(Trim(ComboBox4.Text), Trim(ComboBox5.Text))
        Catch
            totalIssued = 0
        End Try
        Try
            totalRecieved = Me.Check_BalanceTableAdapter.TotalReciepts(Trim(ComboBox4.Text), Trim(ComboBox5.Text))
        Catch
            totalRecieved = 0
        End Try
        bal = totalRecieved - totalIssued
       
        TextBox2.Text = bal.ToString
       
    End Sub
End Class
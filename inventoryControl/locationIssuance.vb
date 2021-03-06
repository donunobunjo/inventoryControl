﻿Public Class locationIssuance
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
        ComboBox6.SelectedIndex = -1
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
        If ComboBox6.Text = "" Then
            MessageBox.Show("You need to pick a location")
            ComboBox6.Focus()
            Exit Sub
        End If
        If ComboBox1.Text = "" Then
            MessageBox.Show("You need to pick a department")
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
        If TextBox1.Text = "0" Then
            MessageBox.Show("quantity can't be zero")
            TextBox1.Focus()
            Exit Sub
        End If
        Try
            totalIssued = Me.Check_BalanceTableAdapter.TotalIssued(Trim(ComboBox4.Text), Trim(ComboBox6.Text))
        Catch
            totalIssued = 0
        End Try
        Try
            totalRecieved = Me.Check_BalanceTableAdapter.TotalReciepts(Trim(ComboBox4.Text), Trim(ComboBox6.Text))
        Catch
            totalRecieved = 0
        End Try
        bal = totalRecieved - totalIssued
        qtyentered = System.Convert.ToDecimal(TextBox1.Text)
        dtApprovedQty = Me.ItemMasterTableAdapter.GetDataByCheckApprovedQty(Trim(ComboBox4.Text), Trim(ComboBox6.Text))
        qtyAprvv = Convert.ToDecimal(dtApprovedQty.Rows(0).Item(8).ToString)
        If qtyentered > qtyAprvv And qtyentered < bal Then
            MessageBox.Show("Quantity you entered is more than the quantity approved for release")
            TextBox1.Focus()
            Exit Sub
        End If
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
        DataGridView1.Rows(itemsCount - 1).Cells(5).Value = Trim(TextBox1.Text)
        DataGridView1.Rows(itemsCount - 1).Cells(6).Value = Trim(TextBox2.Text)
        DataGridView1.Rows(itemsCount - 1).Cells(8).Value = DateTimePicker1.Text
        DataGridView1.Rows(itemsCount - 1).Cells(9).Value = Trim(ComboBox1.Text)
        DataGridView1.Rows(itemsCount - 1).Cells(10).Value = Trim(ComboBox5.Text)
        DataGridView1.Rows(itemsCount - 1).Cells(11).Value = Trim(TextBox6.Text)
        DataGridView1.Rows(itemsCount - 1).Cells(12).Value = Trim(ComboBox1.Text)
        ''''''''''' DataGridView1.Rows(itemsCount - 1).Cells(9).Value = DateTimePicker1.Text
        rate = Convert.ToDouble(TextBox2.Text)
        quantity = Convert.ToDouble(TextBox1.Text)
        amount = rate * quantity
        total = total + amount
        TextBox3.Text = Convert.ToString(amount)

        DataGridView1.Rows(itemsCount - 1).Cells(7).Value = amount
        ' ComboBox1.Enabled = False
        DateTimePicker1.Enabled = False
        ComboBox6.Enabled = False
        amount = 0
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox7.Text = ""
        TextBox6.Text = ""
        ComboBox2.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1
        ComboBox4.SelectedIndex = -1
        ComboBox1.SelectedIndex = -1
        ComboBox5.SelectedIndex = -1
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
        Dim dtCost As DataTable
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
            Try
                totalIssued = Me.Check_BalanceTableAdapter.TotalIssued(Trim(ComboBox4.Text), Trim(ComboBox6.Text))
            Catch
                totalIssued = 0
            End Try
            Try
                totalRecieved = Me.Check_BalanceTableAdapter.TotalReciepts(Trim(ComboBox4.Text), Trim(ComboBox6.Text))
            Catch
                totalRecieved = 0
            End Try
            bal = totalRecieved - totalIssued
            'qtyentered = System.Convert.ToDecimal(TextBox1.Text)
            dtApprovedQty = Me.ItemMasterTableAdapter.GetDataByCheckApprovedQty(Trim(ComboBox4.Text), Trim(ComboBox6.Text))
            qtyAprvv = Convert.ToDecimal(dtApprovedQty.Rows(0).Item(8).ToString)
            dtCost = Me.CheckCostTableAdapter.GetDataBy(Trim(ComboBox4.Text), "SUPPLY")
            TextBox3.Text = bal.ToString
            TextBox7.Text = qtyAprvv.ToString
            TextBox2.Text = dtCost.Rows(0).Item(0).ToString
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
        Dim source, destination, classs, brand, itemnum, itemname, partnum, loc, typeoftrans, major, majorminor, minor, detail, jobcardnum, jobCardDescription As String
        Dim rate, amount, reciepts, issued, quantity As Decimal
        For j = 0 To (Me.DataGridView1.RowCount - 1) - 1
            classs = DataGridView1.Item(0, j).Value.ToString
            brand = DataGridView1.Item(1, j).Value.ToString
            itemnum = DataGridView1.Item(2, j).Value.ToString
            itemname = DataGridView1.Item(3, j).Value.ToString
            partnum = DataGridView1.Item(4, j).Value.ToString
            quantity = Convert.ToDecimal(DataGridView1.Item(5, j).Value.ToString)
            rate = Convert.ToDecimal(DataGridView1.Item(6, j).Value.ToString)
            ' amount = Convert.ToDecimal(DataGridView1.Item(7, j).Value.ToString)
            source = Trim(ComboBox6.Text)

            loc = Trim(ComboBox6.Text)
            typeoftrans = "LOCATIONISSUANCE"
            major = "CENTRALISSUANCE"
            majorminor = "LOCATIONISSUANCE"
            minor = "LOCATIONISSUANCE"
            detail = "LOCATION ISSUANCE"
            'reciepts = Convert.ToDecimal(DataGridView1.Item(5, j).Value.ToString)
            ' issued = 0.0
            reciepts = 0.0
            issued = Convert.ToDecimal(DataGridView1.Item(5, j).Value.ToString)
            ' expdate = Convert.ToDateTime(DataGridView1.Item(8, j).Value)
            recdate = Convert.ToDateTime(DataGridView1.Item(8, j).Value)
            jobcardnum = DataGridView1.Item(10, j).Value.ToString
            jobCardDescription = DataGridView1.Item(11, j).Value.ToString
            destination = DataGridView1.Item(12, j).Value.ToString
            ' Me.StockTableAdapter.InsertQuery(classs, brand, loc, "", typeoftrans, detail, "", "", recdate, source, destination, issued, reciepts, rate, amount, itemnum, itemname, partnum, expdate, major, majorminor, minor)
            Me.StockTableAdapter.InsertQuery(classs, brand, loc, destination, typeoftrans, detail, jobcardnum, jobCardDescription, recdate, source, destination, issued, reciepts, 0.0, 0.0, itemnum, itemname, partnum, recdate, major, major, source, rate)
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
        ComboBox5.SelectedIndex = -1
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""

        DataGridView1.Rows.Clear()
        ComboBox1.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim recdate, expdate As Date
        Dim source, destination, classs, brand, itemnum, itemname, partnum, loc, typeoftrans, major, majorminor, minor, detail, jobcardnum, jobCardDescription As String
        Dim rate, amount, reciepts, issued, quantity As Decimal
        For j = 0 To (Me.DataGridView1.RowCount - 1) - 1
            classs = DataGridView1.Item(0, j).Value.ToString
            brand = DataGridView1.Item(1, j).Value.ToString
            itemnum = DataGridView1.Item(2, j).Value.ToString
            itemname = DataGridView1.Item(3, j).Value.ToString
            partnum = DataGridView1.Item(4, j).Value.ToString
            quantity = Convert.ToDecimal(DataGridView1.Item(5, j).Value.ToString)
            rate = Convert.ToDecimal(DataGridView1.Item(6, j).Value.ToString)
            ' amount = Convert.ToDecimal(DataGridView1.Item(7, j).Value.ToString)
            source = Trim(ComboBox6.Text)

            loc = Trim(ComboBox6.Text)
            typeoftrans = "LOCATIONLISSUANCE"
            major = "LOCATIONISSUANCE"
            majorminor = "LOCATIONISSUANCE"
            minor = "LOCATIONISSUANCE"
            detail = "LOCATION ISSUANCE"
            'reciepts = Convert.ToDecimal(DataGridView1.Item(5, j).Value.ToString)
            ' issued = 0.0
            reciepts = 0.0
            issued = Convert.ToDecimal(DataGridView1.Item(5, j).Value.ToString)
            ' expdate = Convert.ToDateTime(DataGridView1.Item(8, j).Value)
            recdate = Convert.ToDateTime(DataGridView1.Item(8, j).Value)
            jobcardnum = DataGridView1.Item(10, j).Value.ToString
            jobCardDescription = DataGridView1.Item(11, j).Value.ToString
            destination = DataGridView1.Item(12, j).Value.ToString
            ' Me.StockTableAdapter.InsertQuery(classs, brand, loc, "", typeoftrans, detail, "", "", recdate, source, destination, issued, reciepts, rate, amount, itemnum, itemname, partnum, expdate, major, majorminor, minor)
            Me.StockTableAdapter.InsertQuery(classs, brand, loc, destination, typeoftrans, detail, jobcardnum, jobCardDescription, recdate, source, destination, issued, reciepts, 0.0, 0.0, itemnum, itemname, partnum, recdate, major, major, source, rate)
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
        ComboBox5.SelectedIndex = -1
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""

        DataGridView1.Rows.Clear()
        ComboBox1.Focus()
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave




    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        'TextBox7.Text = FormatNumber(amount, 2, TriState.True)
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        Dim dtjbcard As DataTable
        dtjbcard = Me.JobCardTableAdapter.GetDataBy1(ComboBox5.Text)
        If dtjbcard.Rows.Count = 0 Then
            TextBox6.Text = ""
        Else
            TextBox6.Text = dtjbcard.Rows(0).Item(2).ToString
        End If
    End Sub
End Class
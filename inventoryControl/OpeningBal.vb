Public Class OpeningBal

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub NewItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IGontrol.AcctCodes' table. You can move, or remove it, as needed.
        Me.AcctCodesTableAdapter.Fill(Me.IGontrol.AcctCodes)
        'TODO: This line of code loads data into the 'IGontrol.WareHouse' table. You can move, or remove it, as needed.
        Me.WareHouseTableAdapter.Fill(Me.IGontrol.WareHouse)
        'TODO: This line of code loads data into the 'IGontrol.ItemMaster' table. You can move, or remove it, as needed.
        Me.ItemMasterTableAdapter.Fill(Me.IGontrol.ItemMaster)
        'TODO: This line of code loads data into the 'IGontrol.Item' table. You can move, or remove it, as needed.
        ' Me.ItemTableAdapter.Fill(Me.IGontrol.Item)
        'TODO: This line of code loads data into the 'IGontrol.Brand' table. You can move, or remove it, as needed.
        Me.BrandTableAdapter.Fill(Me.IGontrol.Brand)
        'TODO: This line of code loads data into the 'IGontrol.Classification' table. You can move, or remove it, as needed.
        Me.ClassificationTableAdapter.Fill(Me.IGontrol.Classification)
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1
        ComboBox4.SelectedIndex = -1
        Me.CenterToScreen()
        Me.Top = 5
        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dt, mydt, chkdupDT As DataTable
        Dim acctDesc As String
        Dim recdate As Date
        Dim rate, amount, reciepts, issued As Decimal
        Dim source, destination, classs, brand, itemnum, itemname, partnum, loc, typeoftrans, major, majorminor, minor, detail, desc As String
        For j = 0 To (Me.DataGridView1.RowCount - 1) - 1
           
            mydt = Me.AcctCodesTableAdapter.GetDataByCheckDups(Trim(ComboBox3.Text))
            acctDesc = Trim(mydt.Rows(0).Item(2).ToString)
            Me.ItemTableAdapter.InsertQuery(TextBox3.Text, ComboBox1.Text, ComboBox2.Text, TextBox2.Text, TextBox4.Text, TextBox1.Text, 0.0, 0.0, Trim(ComboBox3.Text), acctDesc)
            itemnum = DataGridView1.Item(0, j).Value.ToString
            classs = DataGridView1.Item(1, j).Value.ToString
            brand = DataGridView1.Item(2, j).Value.ToString
            itemname = DataGridView1.Item(3, j).Value.ToString
            partnum = DataGridView1.Item(4, j).Value.ToString
            reciepts = Convert.ToDecimal(DataGridView1.Item(5, j).Value.ToString)
            rate = Convert.ToDecimal(DataGridView1.Item(6, j).Value.ToString)
            loc = DataGridView1.Item(7, j).Value.ToString
            desc = DataGridView1.Item(8, j).Value.ToString
            recdate = Convert.ToDateTime(DataGridView1.Item(9, j).Value)
            issued = 0.0
            source = "OPENING BAL"
            destination = loc
            typeoftrans = "OPENING BAL"
            major = "OPENING BAL"
            majorminor = "OPENING BAL"
            minor = loc
            detail = "OPENING BAL."
            dt = Me.WareHouseTableAdapter.GetData()
            For Each dr In dt.Rows
                Dim location As String
                location = dr.Item(1)

                'Me.ItemMasterTableAdapter.InsertQuery(TextBox3.Text, ComboBox1.Text, ComboBox2.Text, TextBox2.Text, TextBox4.Text, TextBox1.Text, 0, 0, location)
                Me.ItemMasterTableAdapter.InsertQuery(partnum, classs, brand, itemname, desc, itemnum, 0.0, 0.0, location)
            Next
            mydt = Me.AcctCodesTableAdapter.GetDataByCheckDups(Trim(ComboBox3.Text))
            acctDesc = Trim(mydt.Rows(0).Item(2).ToString)
            Me.ItemTableAdapter.InsertQuery(TextBox3.Text, ComboBox1.Text, ComboBox2.Text, TextBox2.Text, TextBox4.Text, TextBox1.Text, 0.0, 0.0, Trim(ComboBox3.Text), acctDesc)
            ' Me.Close()
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dt, mydt, chkdupDT As DataTable
        Dim acctDesc As String
        If TextBox1.Text = "" Then
            MessageBox.Show("You will need to enter the item number")
            TextBox1.Focus()
            Exit Sub
        End If
        If ComboBox1.Text = "" Then
            MessageBox.Show("You need to choose item classification")
            ComboBox1.Focus()
            Exit Sub
        End If
        If ComboBox2.Text = "" Then
            MessageBox.Show("You need to choose item brand")
            ComboBox2.Focus()
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            MessageBox.Show("You need to enter item name")
            TextBox2.Focus()
            Exit Sub
        End If
        If ComboBox3.Text = "" Then
            MessageBox.Show("You need to choose an account code")
            ComboBox3.Focus()
            Exit Sub
        End If
        chkdupDT = Me.ItemTableAdapter.GetDataByItemNumber(Trim(TextBox1.Text))
        If chkdupDT.Rows.Count = 0 Then
            dt = Me.WareHouseTableAdapter.GetData()
            For Each dr In dt.Rows
                Dim location As String
                location = dr.Item(1)

                Me.ItemMasterTableAdapter.InsertQuery(TextBox3.Text, ComboBox1.Text, ComboBox2.Text, TextBox2.Text, TextBox4.Text, TextBox1.Text, 0, 0, location)
            Next
            mydt = Me.AcctCodesTableAdapter.GetDataByCheckDups(Trim(ComboBox3.Text))
            acctDesc = Trim(mydt.Rows(0).Item(2).ToString)
            Me.ItemTableAdapter.InsertQuery(TextBox3.Text, ComboBox1.Text, ComboBox2.Text, TextBox2.Text, TextBox4.Text, TextBox1.Text, 0.0, 0.0, Trim(ComboBox3.Text), acctDesc)
            ComboBox1.SelectedIndex = -1
            ComboBox2.SelectedIndex = -1
            ComboBox3.SelectedIndex = -1
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox1.Focus()
        Else
            MessageBox.Show("An item with this number already exist, please change it")
            TextBox1.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
                If Me.TextBox5.Text.Contains(".") Then
                    If Me.TextBox5.Text.Split(".")(1).Length < 2 Then
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

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
                If Me.TextBox6.Text.Contains(".") Then
                    If Me.TextBox6.Text.Split(".")(1).Length < 2 Then
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("You will need to enter the item number")
            TextBox1.Focus()
            Exit Sub
        End If
        If ComboBox1.Text = "" Then
            MessageBox.Show("You need to choose item classification")
            ComboBox1.Focus()
            Exit Sub
        End If
        If ComboBox2.Text = "" Then
            MessageBox.Show("You need to choose item brand")
            ComboBox2.Focus()
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            MessageBox.Show("You need to enter item name")
            TextBox2.Focus()
            Exit Sub
        End If
        If ComboBox3.Text = "" Then
            MessageBox.Show("You need to choose an account code")
            ComboBox3.Focus()
            Exit Sub
        End If
        If TextBox5.Text = "" Then
            MessageBox.Show("You need to enter quantity")
            TextBox5.Focus()
            Exit Sub
        End If
        If ComboBox4.Text = "" Then
            MessageBox.Show("You need to choose location")
            ComboBox4.Focus()
            Exit Sub
        End If
        Dim itemsCount As Int32
        Dim rate, quantity As Double
        itemsCount = DataGridView1.RowCount
        DataGridView1.Rows.Add()
        DataGridView1.Rows(itemsCount - 1).Cells(0).Value = Trim(TextBox1.Text)
        DataGridView1.Rows(itemsCount - 1).Cells(1).Value = Trim(ComboBox1.Text)
        DataGridView1.Rows(itemsCount - 1).Cells(2).Value = Trim(ComboBox2.Text)
        DataGridView1.Rows(itemsCount - 1).Cells(3).Value = Trim(TextBox2.Text)
        DataGridView1.Rows(itemsCount - 1).Cells(4).Value = Trim(TextBox3.Text)
        DataGridView1.Rows(itemsCount - 1).Cells(5).Value = Trim(TextBox5.Text)
        DataGridView1.Rows(itemsCount - 1).Cells(6).Value = Trim(TextBox6.Text)
        DataGridView1.Rows(itemsCount - 1).Cells(7).Value = Trim(ComboBox4.Text)
        DataGridView1.Rows(itemsCount - 1).Cells(8).Value = Trim(TextBox4.Text)
        DataGridView1.Rows(itemsCount - 1).Cells(9).Value = DateTimePicker1.Text
        ComboBox4.Enabled = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1
        TextBox1.Focus()
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If DataGridView1.SelectedRows.Count > 0 Then
           
            DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
        Else
            MessageBox.Show("Select a row, by clicking the row marker, before you hit Remove Button")
        End If
    End Sub
End Class
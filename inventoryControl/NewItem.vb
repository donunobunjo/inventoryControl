Public Class NewItem

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
        Me.CenterToScreen()
        Me.Top = 40
        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
            Me.Close()
        Else
            MessageBox.Show("An item with this number already exist, please change it")
            TextBox1.Focus()
            Exit Sub
        End If
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
End Class
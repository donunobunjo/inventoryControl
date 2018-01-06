Public Class Newwarehouse

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dt As DataTable
        Dim dr As DataRow
        If (TextBox1.Text = "") Then
            MessageBox.Show("You need to enter a warehouse")
            TextBox1.Focus()
            Exit Sub
        End If
        dt = Me.ItemTableAdapter.GetData()
        For Each dr In dt.Rows
            Dim partnum, classs, brand, partname, desc, itemnumm As String
            partnum = dr.Item(1)
            classs = dr.Item(2)
            brand = dr.Item(3)
            partname = dr.Item(4)
            desc = dr.Item(5)
            itemnumm = dr.Item(6)
            Me.ItemMasterTableAdapter.InsertQuery(partnum, classs, brand, partname, desc, itemnumm, 0, 0, TextBox1.Text)
        Next
        Me.WareHouseTableAdapter.InsertQuery(TextBox1.Text)
        TextBox1.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub NewClassification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IGontrol.Item' table. You can move, or remove it, as needed.
        Me.ItemTableAdapter.Fill(Me.IGontrol.Item)
        'TODO: This line of code loads data into the 'IGontrol.ItemMaster' table. You can move, or remove it, as needed.
        Me.ItemMasterTableAdapter.Fill(Me.IGontrol.ItemMaster)
        'TODO: This line of code loads data into the 'IGontrol.WareHouse' table. You can move, or remove it, as needed.
        Me.WareHouseTableAdapter.Fill(Me.IGontrol.WareHouse)
        'TODO: This line of code loads data into the 'IGontrol.Classification' table. You can move, or remove it, as needed.
        ' Me.WareHouseTableAdapter.Fill(Me.IGontrol.Classification)
        Me.CenterToScreen()
        Me.Top = 50
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dt As DataTable
        Dim dr As DataRow
        If (TextBox1.Text = "") Then
            MessageBox.Show("You need to enter a warehouse")
            TextBox1.Focus()
            Exit Sub
        End If
        dt = Me.ItemTableAdapter.GetData()
        For Each dr In dt.Rows
            Dim partnum, classs, brand, partname, desc, itemnumm As String
            partnum = dr.Item(1)
            classs = dr.Item(2)
            brand = dr.Item(3)
            partname = dr.Item(4)
            desc = dr.Item(5)
            itemnumm = dr.Item(6)
            Me.ItemMasterTableAdapter.InsertQuery(partnum, classs, brand, partname, desc, itemnumm, 0, 0, TextBox1.Text)
        Next
        Me.WareHouseTableAdapter.InsertQuery(TextBox1.Text)
        Me.Close()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
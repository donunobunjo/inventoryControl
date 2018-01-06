Public Class AssignFuctionsToUser
    Public Property user As String
    Dim allfunctions As New iGontrolTableAdapters.FunctionTableAdapter
    Dim dtAllFuctions As DataTable
    Dim functionn As String
    Private Sub AssignFuctionsToUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
        Label3.Text = user
        dtAllFuctions = allfunctions.GetData
        For j = 0 To dtAllFuctions.Rows.Count - 1
            functionn = dtAllFuctions.Rows(j).Item(1).ToString
            ListBox1.Items.Add(functionn)
        Next
        ' MessageBox.Show("hello")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dtAllFuctions = allfunctions.GetData
        For j = 0 To dtAllFuctions.Rows.Count - 1
            functionn = dtAllFuctions.Rows(j).Item(1).ToString
            ListBox2.Items.Add(functionn)
        Next
        dtAllFuctions = allfunctions.GetData
        For j = 0 To dtAllFuctions.Rows.Count - 1
            functionn = dtAllFuctions.Rows(j).Item(1).ToString
            ListBox1.Items.Remove(functionn)
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        dtAllFuctions = allfunctions.GetData
        For j = 0 To dtAllFuctions.Rows.Count - 1
            functionn = dtAllFuctions.Rows(j).Item(1).ToString
            ListBox1.Items.Add(functionn)
        Next
        dtAllFuctions = allfunctions.GetData
        For j = 0 To dtAllFuctions.Rows.Count - 1
            functionn = dtAllFuctions.Rows(j).Item(1).ToString
            ListBox2.Items.Remove(functionn)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim functionn As String
        Try
            functionn = ListBox1.SelectedItem.ToString
        Catch
            MessageBox.Show("You need to select an item")
            Exit Sub
        End Try
        If Me.ListBox2.Items.Contains(functionn) Then
            Exit Sub
        Else
            ListBox2.Items.Add(functionn)
            ListBox1.Items.Remove(functionn)
        End If
    End Sub

  

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim functionn As String
        Try
            functionn = ListBox2.SelectedItem.ToString
        Catch
            MessageBox.Show("You need to select an item")
            Exit Sub
        End Try
        If Me.ListBox1.Items.Contains(functionn) Then
            Exit Sub
        Else
            ListBox1.Items.Add(functionn)
            ListBox2.Items.Remove(functionn)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim query As New iGontrolTableAdapters.UserFunctionsTableAdapter
        ' query.DeleteQuery(user)
        If ListBox2.Items.Count = 0 Then
            MessageBox.Show("Functions have not been assign to the user")
            Exit Sub
        End If
        For i As Integer = 0 To ListBox2.Items.Count - 1
            'Dim fn As String = CStr(MyListBox.Items(l_index))
            Dim fn As String = Convert.ToString(ListBox2.Items(i))
            query.InsertQuery(user, fn)
        Next
        MessageBox.Show(user + " has been assigned to the functions")
        Me.Close()
    End Sub
End Class
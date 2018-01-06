Public Class ManageUsers
    Public Property dlocation As String
    Public Property dstore As String
    Private Sub ManageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IGontrol.User' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.IGontrol.User)
        'TODO: This line of code loads data into the 'SAAEvoDataset.Users' table. You can move, or remove it, as needed.
        ' Me.UsersTableAdapter.Fill(Me.SAAEvoDataset.Users)
        '''''''''''''' Me.UsersTableAdapter.FillByActiveStoreUsers(SAAEvoDataset.Users, dlocation, dstore)
        'Me.MdiParent = Main
        Me.CenterToScreen()
        Me.Top = 5

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        '''''''''''''''' Me.UsersTableAdapter.Update(Me.SAAEvoDataset.Users)
        Me.UserTableAdapter.Update(Me.IGontrol.User)
        MessageBox.Show("Users database updated successfully")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user As String
        Dim changerole As New ChangeUserFunctions
        If DataGridView1.SelectedRows.Count > 0 Then
            ' dgvItems.Rows.Remove(dgvItems.SelectedRows(0))
            ' user = DataGridView1.Rows(0).Cells(1).Value.ToString
            user = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
            changerole.user = user
            'changerole.username = user
            changerole.ShowDialog()
        Else
            MessageBox.Show("Select a row, by clicking the row marker, before you hit change role button")
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

   
End Class
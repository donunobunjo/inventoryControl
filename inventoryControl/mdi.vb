Imports System.Windows.Forms

Public Class mdi
    Public Property user As String
    Public Property passwd As String
    Private Sub mdi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width
        Me.Top = 1
        Me.Left = 1
    End Sub

    Private Sub Ribbon1_Click(sender As Object, e As EventArgs) Handles Ribbon1.Click

    End Sub

    Private Sub RibbonButton3_Click(sender As Object, e As EventArgs) Handles RibbonButton3.Click
        Dim classif As New NewClassification
        classif.MdiParent = Me
        classif.Show()
    End Sub

    Private Sub RibbonButton4_Click(sender As Object, e As EventArgs) Handles RibbonButton4.Click
        Dim viewClass As New ViewClassifications
        viewClass.MdiParent = Me
        viewClass.Show()
    End Sub

    Private Sub RibbonButton5_Click(sender As Object, e As EventArgs) Handles RibbonButton5.Click
        Dim brand As New NewBrand
        brand.MdiParent = Me
        brand.Show()
    End Sub

    Private Sub RibbonButton23_Click(sender As Object, e As EventArgs) Handles RibbonButton23.Click
        Dim wareas As New Newwarehouse
        wareas.MdiParent = Me
        wareas.Show()
    End Sub

    Private Sub RibbonButton6_Click(sender As Object, e As EventArgs) Handles RibbonButton6.Click
        Dim BRd As New ViewBrands
        BRd.MdiParent = Me
        BRd.Show()
    End Sub

    Private Sub RibbonButton24_Click(sender As Object, e As EventArgs) Handles RibbonButton24.Click
        Dim wre As New ViewWarehouse
        wre.MdiParent = Me
        wre.Show()
    End Sub

    Private Sub RibbonButton13_Click(sender As Object, e As EventArgs) Handles RibbonButton13.Click
        Dim item As New NewItem
        item.MdiParent = Me
        item.Show()
    End Sub

    Private Sub RibbonButton14_Click(sender As Object, e As EventArgs) Handles RibbonButton14.Click
        Dim vwitems As New ViewItems
        vwitems.MdiParent = Me
        vwitems.Show()
    End Sub

    Private Sub RibbonButton15_Click(sender As Object, e As EventArgs) Handles RibbonButton15.Click
        Dim sup As New NewSupplier
        sup.MdiParent = Me
        sup.Show()
    End Sub

    Private Sub RibbonButton16_Click(sender As Object, e As EventArgs) Handles RibbonButton16.Click
        Dim vwsup As New ViewSuppliers
        vwsup.MdiParent = Me
        vwsup.Show()
    End Sub

    Private Sub mdi_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As Integer = MessageBox.Show("Do you want to quit Inventory Control", "Want to quit", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub RibbonButton29_Click(sender As Object, e As EventArgs) Handles RibbonButton29.Click
        Dim nwUser As New NewUser
        Dim checkfunction As New iGontrolTableAdapters.UserFunctionsTableAdapter
        Dim dtcheckfunction As DataTable
        dtcheckfunction = checkfunction.GetDataByCheckFunction(user, "CREATE USERS")
        If dtcheckfunction.Rows.Count = 0 Then
            MessageBox.Show("You are not assigned this function")
            Exit Sub
        Else
            nwUser.MdiParent = Me
            nwUser.Show()
        End If
    End Sub

    Private Sub RibbonButton30_Click(sender As Object, e As EventArgs) Handles RibbonButton30.Click
        Dim mnguser As New ManageUsers
        Dim nwUser As New NewUser
        Dim checkfunction As New iGontrolTableAdapters.UserFunctionsTableAdapter
        Dim dtcheckfunction As DataTable
        dtcheckfunction = checkfunction.GetDataByCheckFunction(user, "CREATE USERS")
        If dtcheckfunction.Rows.Count = 0 Then
            MessageBox.Show("You are not assigned this function")
            Exit Sub
        Else
            mnguser.MdiParent = Me
            mnguser.Show()
        End If
    End Sub

    Private Sub RibbonButton26_Click(sender As Object, e As EventArgs) Handles RibbonButton26.Click
        System.Diagnostics.Process.Start("calc.exe")
    End Sub

    Private Sub RibbonButton27_Click(sender As Object, e As EventArgs) Handles RibbonButton27.Click
        Dim chanepwd As New CahngePassword
        chanepwd.MdiParent = Me
        chanepwd.user = user
        chanepwd.Show()
    End Sub

    Private Sub RibbonButton9_Click(sender As Object, e As EventArgs) Handles RibbonButton9.Click
        Dim nwreqas As New NewRequisition
        Dim checkfunction As New iGontrolTableAdapters.UserFunctionsTableAdapter
        Dim dtcheckfunction As DataTable
        dtcheckfunction = checkfunction.GetDataByCheckFunction(user, "RAISE REQUISITIONS")
        If dtcheckfunction.Rows.Count = 0 Then
            MessageBox.Show("You are not assigned this function")
            Exit Sub
        Else
            nwreqas.MdiParent = Me
            nwreqas.Show()
        End If
    End Sub

    Private Sub RibbonButton11_Click(sender As Object, e As EventArgs) Handles RibbonButton11.Click
        Dim vwApprvReq As New ViewApprovedRequisition
        vwApprvReq.MdiParent = Me
        vwApprvReq.Show()
    End Sub

    Private Sub RibbonButton36_Click(sender As Object, e As EventArgs) Handles RibbonButton36.Click
        Dim nwdept As New NewDepartment
        nwdept.MdiParent = Me
        nwdept.Show()
    End Sub

    Private Sub RibbonButton10_Click(sender As Object, e As EventArgs) Handles RibbonButton10.Click
        Dim aprvReq As New ApproveRequisition
        Dim checkfunction As New iGontrolTableAdapters.UserFunctionsTableAdapter
        Dim dtcheckfunction As DataTable
        dtcheckfunction = checkfunction.GetDataByCheckFunction(user, "APPROVE REQUISITIONS")
        If dtcheckfunction.Rows.Count = 0 Then
            MessageBox.Show("You are not assigned this function")
            Exit Sub
        Else
            aprvReq.MdiParent = Me
            aprvReq.Show()
        End If
    End Sub

    Private Sub RibbonButton38_Click(sender As Object, e As EventArgs) Handles RibbonButton38.Click
        Dim vwRejReq As New ViewRejectedRequisition
        vwRejReq.MdiParent = Me
        vwRejReq.Show()
    End Sub

    Private Sub RibbonButton12_Click(sender As Object, e As EventArgs) Handles RibbonButton12.Click
        Dim vwPartReq As New ViewPartialRequisition
        vwPartReq.MdiParent = Me
        vwPartReq.Show()
    End Sub

    Private Sub RibbonButton1_Click(sender As Object, e As EventArgs) Handles RibbonButton1.Click
       
    End Sub

    Private Sub RibbonButton37_Click(sender As Object, e As EventArgs) Handles RibbonButton37.Click
        Dim vwDepatments As New ViewDepartments
        vwDepatments.MdiParent = Me
        vwDepatments.Show()
    End Sub

    Private Sub RibbonButton18_Click(sender As Object, e As EventArgs) Handles RibbonButton18.Click
        Dim centralReciepts As New CentralVendowsReciept
        centralReciepts.MdiParent = Me
        centralReciepts.Show()
    End Sub

    Private Sub RibbonButton32_Click(sender As Object, e As EventArgs) Handles RibbonButton32.Click
        Dim nwjbc As New NewJobCardvb
        nwjbc.MdiParent = Me
        nwjbc.Show()
    End Sub

    Private Sub RibbonButton35_Click(sender As Object, e As EventArgs) Handles RibbonButton35.Click
        Dim vjbc As New ViewJobCardsvb
        vjbc.MdiParent = Me
        vjbc.Show()
    End Sub

    Private Sub RibbonButton19_Click(sender As Object, e As EventArgs) Handles RibbonButton19.Click
        Dim cenIssue As New CentralIssuance
        cenIssue.MdiParent = Me
        cenIssue.Show()
    End Sub

    Private Sub RibbonButton21_Click(sender As Object, e As EventArgs) Handles RibbonButton21.Click
        Dim interloctrans As New LocationTransfers
        interloctrans.MdiParent = Me
        interloctrans.Show()
    End Sub

    Private Sub RibbonButton31_Click(sender As Object, e As EventArgs) Handles RibbonButton31.Click
        Dim locissu As New locationIssuance
        locissu.MdiParent = Me
        locissu.Show()
    End Sub

    Private Sub RibbonButton39_Click(sender As Object, e As EventArgs) Handles RibbonButton39.Click
        Dim stkbal As New stockbalances
        stkbal.MdiParent = Me
        stkbal.Show()
    End Sub

    Private Sub RibbonButton40_Click(sender As Object, e As EventArgs) Handles RibbonButton40.Click
        Dim venhist As New Vendor_History
        venhist.MdiParent = Me
        venhist.Show()
    End Sub

    Private Sub RibbonButton41_Click(sender As Object, e As EventArgs) Handles RibbonButton41.Click
        Dim itmHis As New ItemHistory
        itmHis.MdiParent = Me
        itmHis.Show()
    End Sub

    Private Sub RibbonButton48_Click(sender As Object, e As EventArgs) Handles RibbonButton48.Click
        Dim vwAcctLists As New ViewAcctCodes
        vwAcctLists.MdiParent = Me
        vwAcctLists.Show()
    End Sub

    Private Sub RibbonButton47_Click(sender As Object, e As EventArgs) Handles RibbonButton47.Click
        Dim actcodes As New NewAcctCode
        actcodes.MdiParent = Me
        actcodes.Show()
    End Sub

    Private Sub RibbonButton49_Click(sender As Object, e As EventArgs) Handles RibbonButton49.Click
        Dim actcodes As New OpeningBal

        actcodes.MdiParent = Me
        actcodes.Show()
    End Sub
End Class

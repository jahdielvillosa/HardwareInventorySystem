Public Class Report

    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub InventoryBtn_Click(sender As Object, e As EventArgs) Handles InventoryBtn.Click
        InventoryMenu.Show()
        Me.Close()
    End Sub

    Private Sub SalesBtn_Click(sender As Object, e As EventArgs) Handles SalesBtn.Click
        Sales.Show()
        Me.Close()
    End Sub
End Class
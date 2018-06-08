Public Class MenuMain

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles viewItensPanelBtn.Click, PictureBox4.Click
        TableView.Show()
    End Sub

   
    Private Sub Panel4_DoubleClick(sender As Object, e As EventArgs) Handles AddItemPanelBtn.Click, PictureBox3.Click
        AddForm.Show()
    End Sub

    Private Sub Panel7_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel7.MouseClick, PictureBox6.Click
        Search.Show()

    End Sub

    Private Sub Panel6_MouseClick(sender As Object, e As MouseEventArgs) Handles verifyPanelBtn.MouseClick, PictureBox2.Click
        Verify.Show()
    End Sub

    Private Sub Panel5_MouseClick(sender As Object, e As MouseEventArgs) Handles returnedPanelBtn.MouseClick, PictureBox5.Click
        ReturnDamage.Show()
    End Sub

    Private Sub Panel8_MouseClick(sender As Object, e As MouseEventArgs) Handles ReportPanel.MouseClick, PictureBox1.Click
        Report.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Sales.Show()

    End Sub

    Private Sub Panel7_MouseHover(sender As Object, e As EventArgs) Handles Panel7.MouseHover
        searchLabel.ForeColor = Color.Aqua
    End Sub

    Private Sub MenuMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class